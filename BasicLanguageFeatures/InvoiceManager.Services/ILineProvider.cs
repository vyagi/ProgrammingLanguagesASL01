using System.Collections.Generic;

namespace InvoiceManager.Services
{
    public interface ILineProvider
    {
        IEnumerable<string> GetLines();
    }
}