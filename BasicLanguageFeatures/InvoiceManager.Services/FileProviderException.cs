using System;

namespace InvoiceManager.Services
{
    public class FileProviderException : Exception
    {
        public FileProviderException(string message) : base(message) { }
    }
}