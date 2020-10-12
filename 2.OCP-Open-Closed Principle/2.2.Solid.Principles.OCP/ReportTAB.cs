namespace Solid.Principles
{
  using System.Collections.Generic;
  using System.IO;
  using Define;
  using Dto;

  public class ReportTAB : IReportGenerator
  {
    public void Generate(string reportFilename, List<EmployeeDto> employees)
    {
      var fullReportFileName = $"{Constants.ReportsPath}{reportFilename}.tab";
      var sw = new StreamWriter(fullReportFileName);

      foreach (var emp in employees)
      {
        sw.WriteLine($"{emp.Id}\t{emp.FirstName}\t{emp.LastName}\t{emp.HireDate}\t{emp.Email}\t{emp.Phone}");
      }

      sw.Flush();
      sw.Close();
    }
  }
}
