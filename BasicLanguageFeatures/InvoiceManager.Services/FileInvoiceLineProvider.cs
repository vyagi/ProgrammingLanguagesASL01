using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace InvoiceManager.Services
{
    public class FileInvoiceLineProvider : ILineProvider
    {
        private readonly string _path;

        public FileInvoiceLineProvider(string path)
        {
            if (!File.Exists(path))
                throw new FileProviderException($"File {path} does not exist");
            
            _path = path;
        }
        
        public IEnumerable<string> GetLines()
        {
            try
            {
                return File.ReadLines(_path).Skip(1);
            }
            catch (UnauthorizedAccessException)
            {
                throw new FileProviderException($"You don't have rights to read {_path}");
            }
        }
    }
}