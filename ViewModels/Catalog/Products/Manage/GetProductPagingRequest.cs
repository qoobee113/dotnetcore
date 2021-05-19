using System;
using System.Collections.Generic;
using System.Text;
using ViewModels.Common;

namespace ViewModels.Catalog.Products.Manage
{
    public class GetProductPagingRequest : PagingRequestBase
    {
        public string Keyword { set; get; }

        public List<int> CategoryIds { set; get; }


    }
}
