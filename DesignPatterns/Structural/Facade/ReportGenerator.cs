using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class ReportGenerator
    {
        public void GenerateReport(IEnumerable<string> qualityIssues,
            IEnumerable<string> securityIssues,
            IEnumerable<string> dependencyIssues)
        {
            Console.WriteLine("Generating report...");

            Console.WriteLine("Quality Issues:");
            Console.WriteLine(string.Join(", ", qualityIssues));

            Console.WriteLine("Security Issues:");
            Console.WriteLine(string.Join(", ", securityIssues));

            Console.WriteLine("Dependency Issues:");
            Console.WriteLine(string.Join(", ", dependencyIssues));

            Console.WriteLine("Report generation complete.");
        }
    }
}
