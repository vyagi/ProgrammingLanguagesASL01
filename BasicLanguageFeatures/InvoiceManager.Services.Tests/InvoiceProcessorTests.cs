using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Moq;

namespace InvoiceManager.Services.Tests
{
    [TestClass]
    public class InvoiceProcessorTests
    {
        [TestMethod]
        public void GetInvoices_returns_correct_collection_of_invoices()
        {
            var lineProviderMock = new Mock<ILineProvider>();
            lineProviderMock
                .Setup(x => x.GetLines())
                .Returns(InvoicesStrings);

            var processor = new InvoiceProcessor(lineProviderMock.Object);

            var invoices = processor.GetInvoices();

            invoices.Should().HaveCount(3);
        }

        [TestMethod]
        public void GetInvoicesGroupedByName_returns_data_grouped_correctly()
        {
            var lineProviderMock = new Mock<ILineProvider>();
            lineProviderMock
                .Setup(x => x.GetLines())
                .Returns(InvoicesStrings);

            var processor = new InvoiceProcessor(lineProviderMock.Object);

            var groups = processor.GetInvoicesGroupedByName().ToList();

            groups.Should().HaveCount(2);
            groups.First().Name.Should().Be("John");
            groups.First().TotalAmount.Should().Be(500);

            groups.Skip(1).First().Name.Should().Be("Marcin");
            groups.Skip(1).First().TotalAmount.Should().Be(1100);
        }
        
        public IEnumerable<string> InvoicesStrings = new List<string>
        {
            "Marcin\t2020-12-17\t1000",
            "John\t2020-12-16\t500",
            "Marcin\t2020-12-15\t100"
        };
    }
}
