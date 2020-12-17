using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace InvoiceManager.Services
{
    public class InvoiceProcessor
    {
        private readonly IList<Invoice> _invoices = new List<Invoice>();

        public InvoiceProcessor(ILineProvider lineProvider)
        {
            if (lineProvider == null)
                throw new ArgumentNullException(nameof(lineProvider));

            foreach (var line in lineProvider.GetLines())
            {
                var split = line.Split('\t');

                var name = split[0];
                var date = Convert.ToDateTime(split[1]);
                var amount = Convert.ToDecimal(split[2].Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));

                _invoices.Add(new Invoice(name, date, amount));
            }
        }

        public IEnumerable<Invoice> GetInvoices() => _invoices;

        public IEnumerable<(string Name, decimal TotalAmount)> GetInvoicesGroupedByName() =>
            _invoices.GroupBy(x => x.Name)
                .Select(x => (x.Key, x.Sum(y => y.Amount)))
                .OrderBy(x => x);
    }
}