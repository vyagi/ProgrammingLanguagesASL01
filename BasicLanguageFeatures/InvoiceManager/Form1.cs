using System;
using System.Collections.Generic;
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

        private void button1_Click(object sender, EventArgs e) =>
            HandleClick(() => resultTextBox.Text = 
                Join(_factory
                    .Create(pathTextBox.Text)
                    .GetInvoices()
                    .Select(x => $"{x.Name}\t{x.Date:yyyy-MM-dd}\t{x.Amount}")));

        private void groupByNamesButton_Click(object sender, EventArgs e) =>
            HandleClick(() => resultTextBox.Text = 
                Join(_factory
                    .Create(pathTextBox.Text)
                    .GetInvoicesGroupedByName()
                    .Select(x => $"{x.Name}: {x.TotalAmount}")));

        private static void HandleClick(Action action)
        {
            try
            {
                action();
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}", "Error occured");
            }
        }

        private string Join(IEnumerable<string> strings) => 
            string.Join("\r\n", strings);
    }
}
