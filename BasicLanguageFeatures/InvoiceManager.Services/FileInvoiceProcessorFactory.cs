namespace InvoiceManager.Services
{
    public class FileInvoiceProcessorFactory
    {
        public InvoiceProcessor Create(string path) => 
            new InvoiceProcessor(new FileInvoiceLineProvider(path));
    }
}