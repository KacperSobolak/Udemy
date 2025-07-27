using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class QualityScanner
    {
        public IEnumerable<string> QualityScan(string githubUrl)
        {
            Console.WriteLine($"Scanning {githubUrl} for quality issues...");

            return new List<string> { "Error1", "Error2" };
        }
    }
}
