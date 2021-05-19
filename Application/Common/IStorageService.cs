using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);
        Task SaveFileAsync(Stream medidaBinaryStream, string fileName);
        Task DeleteFileAsync(string fileName);
    }
}
