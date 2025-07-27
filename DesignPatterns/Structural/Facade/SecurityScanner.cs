using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class SecurityScanner
    {
        public IEnumerable<string> SecurityScan(string githubUrl)
        {
            Console.WriteLine($"Scanning {githubUrl} for security issues...");

            return new List<string> { "SecurityError1", "SecurityError2" };
        }
    }
}
