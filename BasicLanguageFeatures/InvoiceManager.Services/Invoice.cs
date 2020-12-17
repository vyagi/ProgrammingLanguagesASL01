using System;

namespace InvoiceManager.Services
{
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
