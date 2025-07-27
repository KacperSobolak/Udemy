using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class DependencyScanner
    {
        public IEnumerable<string> DependencyScan(string githubUrl)
        {
            Console.WriteLine($"Scanning {githubUrl} for dependency issues...");

            return new List<string> { "DependencyError1", "DependencyError2" };
        }
    }
}
