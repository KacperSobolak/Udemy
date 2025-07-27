using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class ScanFacade
    {
        private QualityScanner qualityScanner = new QualityScanner();
        private SecurityScanner securityScanner = new SecurityScanner();
        private DependencyScanner dependencyScanner = new DependencyScanner();
        private ReportGenerator reportGenerator = new ReportGenerator();

        public void Scan(string githubUrl)
        {
            Console.WriteLine("Scanning started");

            var qualityIssues = qualityScanner.QualityScan(githubUrl);
            var securityIssues = securityScanner.SecurityScan(githubUrl);
            var dependencyIssues = dependencyScanner.DependencyScan(githubUrl);

            Console.WriteLine("All scans completed. Generating report...");
            reportGenerator.GenerateReport(qualityIssues, securityIssues, dependencyIssues);
        }
    }
}
