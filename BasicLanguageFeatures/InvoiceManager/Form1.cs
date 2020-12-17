using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using InvoiceManager.Services;

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
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return;
            }

            var invoices = new List<Invoice>();

            foreach (var line in File.ReadAllLines(path).Skip(1))
            {
                var split = line.Split('\t');

                var name = split[0];
                var date = Convert.ToDateTime(split[1]);
                var amount = Convert.ToDecimal(split[2].Replace(",", CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator));

                invoices.Add(new Invoice(name, date, amount));
            }

            var grouped = invoices.GroupBy(x => x.Name)
                .Select(x => $"{x.Key}: {x.Sum(y => y.Amount)}")
                .OrderBy(x => x);

            resultTextBox.Text = string.Join("\r\n", grouped);
        }
    }
}
