using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return;
            }

            resultTextBox.Text = File.ReadAllText(path);
        }

        private void groupByNamesButton_Click(object sender, EventArgs e)
        {
            if (!EnsureFileExists(pathTextBox.Text)) return;

            var invoices = Invoices(pathTextBox.Text);

            var grouped = invoices.GroupBy(x => x.Name)
                .Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}")
                .OrderBy(x => x);

            resultTextBox.Text = string.Join("\r\n", grouped);
        }

        private static IEnumerable<Invoice> Invoices(string path) =>
            File.ReadAllLines(path).Skip(1).Select(ToInvoice).ToList();

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!EnsureFileExists(pathTextBox.Text)) return;

            var lines = Invoices(pathTextBox.Text)
                .GroupBy(x => new {x.Date.Year, Month = x.Date.ToString("MMMM"), MonthNumber = x.Date.Month})
                .OrderBy(x => x.Key.Year)
                .ThenBy(x => x.Key.MonthNumber)
                .Select(x => $"{x.Key.Year}, {x.Key.Month}: {x.Sum(y => y.Amount)}");

            resultTextBox.Text = string.Join("\r\n", lines);
        }

        private bool EnsureFileExists(string path)
        {
            return File.Exists(path) ? ExistsAction() : DoesNotExistAction();
            
            bool DoesNotExistAction()
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return true;
            }

            bool ExistsAction() => true;
        }

        private static Invoice ToInvoice(string line)
        {
            var split = line.Split('\t');

            return new Invoice(split[0], Convert.ToDateTime(split[1]), Convert.ToDecimal(split[2].Replace(",",
                CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator)));
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
