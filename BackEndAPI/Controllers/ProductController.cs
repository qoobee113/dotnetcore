using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Catalog.Products;
using ViewModels.Catalog.Products;
using Microsoft.AspNetCore.Authorization;

namespace BackEndAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class ProductController : Controller
    {
        private readonly IPublicProductService _publicProductService;
        private readonly IManageProductService _manageProductService;
        public ProductController(IPublicProductService publicProductService, IManageProductService manageProductService)
        {
            _publicProductService = publicProductService;
            _manageProductService = manageProductService;
        }
        [HttpGet]
        public async Task<IActionResult> Get([FromQuery]string language = "vi-VN")
        {
            var product = await _publicProductService.GetAll(language);
            return Ok(product);
        }

        [HttpGet("public-paging")]
        public async Task<IActionResult> Get([FromQuery]GetPublicProductPagingRequest request)
        {
            var product = await _publicProductService.GetAllByCategoryId(request);
            return Ok(product);
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetById(int productId,[FromQuery]string languageId="vi-VN")
        {
            var product = await _manageProductService.GetById(productId, languageId);
            if (product == null) return BadRequest("Cannot find product");
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromForm]ProductCreateRequest request,[FromQuery]string languageId="vi-VN")
        {
            var productId = await _manageProductService.Create(request);
            if (productId == 0) return BadRequest();
            var product = await _manageProductService.GetById(productId,languageId);

            return Created(nameof(GetById), product);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromForm] ProductUpdateRequest request)
        {
            var resultUpdate = await _manageProductService.Update(request);
            if (resultUpdate == 0) return BadRequest();

            return Ok();
        }

        [HttpPut("price/{id}/{newPrice}")]
        public async Task<IActionResult> UpdatePrice(int id,decimal newPrice)
        {
            var resultUpdate = await _manageProductService.UpdatePrice(id,newPrice);
            if (resultUpdate == false) return BadRequest();

            return Ok();
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> Delete(int productId)
        {
            var resultUpdate = await _manageProductService.Delete(productId);
            if (resultUpdate == 0) return BadRequest();

            return Ok();
        }
    }
}
