using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    internal class PdfGenerator : Generator
    {
        protected override void PrepareData()
        {
            Console.WriteLine("Prepare pdf data");
        }

        protected override void GenerateFile()
        {
            Console.WriteLine("Generate pdf file");
        }

        protected override void GetData()
        {
            Console.WriteLine("Get data for pdf");
        }
    }
}
