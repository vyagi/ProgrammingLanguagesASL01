using System;
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
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist. Cannot proceed");
                return;
            }

            var lines = File.ReadAllLines(path).Skip(1);

            foreach (var line in lines)
            {
                var split = line.Split('\t');
                var name = split[0];
                var date = split[1];
                var amount = split[2];


            }

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
