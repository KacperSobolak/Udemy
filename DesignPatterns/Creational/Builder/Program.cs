using Newtonsoft.Json;

namespace Builder
{
    class Program
    {
        public static void Main(string[] args)
        {
            var invoiceBuilder = new InvoiceBuilder();

            invoiceBuilder.SetNote("Test note");
            invoiceBuilder.SetNumber("434");

            var invoice = invoiceBuilder.Build();
        }
    }
}   
