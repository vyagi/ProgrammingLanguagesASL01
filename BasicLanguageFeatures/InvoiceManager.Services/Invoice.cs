using System;
using System.Collections.Generic;

namespace InvoiceManager.Services
{
    public interface ILineProvider
    {
        IEnumerable<string> GetLines();
    }
    public class FileInvoiceLineProvider : ILineProvider
    {
        public IEnumerable<string> GetLines()
        {
            return null;
        }

    }
    public class InvoiceProcessor
    {
        public InvoiceProcessor(ILineProvider lineProvider)
        {
            if (lineProvider == null)
                throw new ArgumentNullException(nameof(lineProvider));


        }
    }
    
    public class Invoice
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public Invoice(string name, DateTime date, decimal amount)
        {
            Name = name;
            Date = date;
            Amount = amount;
        }
    }
}
