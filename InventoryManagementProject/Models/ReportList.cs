using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementProject.Models
{
    public class ReportList
    {
        private List<Report> reports = new List<Report>();

        public void AddReport(Report r)
        {
            reports.Add(r);
        }

        public List<Report> GetAllReports()
        {
            return reports;
        }

        public List<Report> GetReportsByType(string type)
        {
            return reports.Where(r => r.ReportType.Equals(type, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        public Report GetLatestReport()
        {
            return reports.OrderByDescending(r => r.ReportDate).FirstOrDefault();
        }

        public void SetReports(List<Report> loadedReports)
        {
            reports = loadedReports;
        }
    }
}
