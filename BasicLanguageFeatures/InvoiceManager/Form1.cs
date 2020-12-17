using System;
using System.Linq;
using System.Windows.Forms;
using InvoiceManager.Services;

namespace InvoiceManager
{
    public partial class Form1 : Form
    {
        private readonly FileInvoiceProcessorFactory _factory;

        public Form1(FileInvoiceProcessorFactory factory)
        {
            InitializeComponent();
            _factory = factory ?? throw new ArgumentNullException(nameof(factory));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var invoiceProcessor = _factory.Create(pathTextBox.Text);

                var invoices = invoiceProcessor.GetInvoices();

                resultTextBox.Text = string.Join("\r\n", invoices.Select(x => $"{x.Name}\t{x.Date:yyyy-MM-dd}\t{x.Amount}"));
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error occured");
            }
        }

        private void groupByNamesButton_Click(object sender, EventArgs e)
        {
            try
            {
                var invoiceProcessor = _factory.Create(pathTextBox.Text);

                var invoices = invoiceProcessor.GetInvoicesGroupedByName();

                resultTextBox.Text = string.Join("\r\n", invoices.Select(x => $"{x.Name}: {x.TotalAmount}"));
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error occured");
            }
        }
    }
}
