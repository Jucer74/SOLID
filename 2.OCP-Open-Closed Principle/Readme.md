# Open/Close Principle (OCP)
Un módulo o clase debe **estar abierto para su extensión** pero **cerrado para su modificación**.

Lo cual permite que sea facilmente extendible sin tener que modificarse internamente.

### Ejemplo
En el ejemplo hemos modificado la clase **ReporGenerator** para que se puedan crear reportes en formato separado por comas o en formato XML así:

```csharp
namespace Solid.Principles
{
  using System.Collections.Generic;
  using System.IO;
  using System.Xml.Serialization;
  using Define;
  using Dto;

  public class ReportGenerator
  {
    /// <summary>
    /// Method to generate report
    /// </summary>
    public static void Generate(string reportFilename, List<EmployeeDto> employees, ReportType reporType)
    {
      switch (reporType)
      {
        case ReportType.CSV:
          GenerateCSV(reportFilename, employees);
          break;
        case ReportType.XML:
          GenerateXML(reportFilename, employees);
          break;
      }
    }

    private static void GenerateCSV(string reportFilename, List<EmployeeDto> employees)
    {
      var fullReportFileName = $"{Constants.ReportsPath}{reportFilename}.csv";
      var sw = new StreamWriter(fullReportFileName);

      foreach (var emp in employees)
      {
        sw.WriteLine($"{emp.Id},{emp.FirstName},{emp.LastName},{emp.HireDate},{emp.Email},{emp.Phone}");
      }

      sw.Flush();
      sw.Close();
    }

    private static void GenerateXML(string reportFilename, List<EmployeeDto> employees)
    {
      var fullReportFileName = $"{Constants.ReportsPath}{reportFilename}.xml";
      var sw = new StreamWriter(fullReportFileName);
      XmlSerializer xml = new XmlSerializer(typeof(List<EmployeeDto>));
      xml.Serialize(sw, employees);
      sw.Flush();
      sw.Close();
    }
  }
}

```

### Qué anda mal?
Si queremos adicionar un nuevo formato como por ejemplo PDF, deberiamos modificar la misma Clase (**ReportGenerator**), por lo tanto se estaría rompiendo el princio de OCP, pues la idea es que este abierto para extender una nueva funcionalidad sin tener quemodificar la clase.

### Cómo lo solucionamos?
La forma de solucionarlo es permitir que su implementacion de la función que genera el reporte, no dependa de la clase en si, sino de los argumentos que reciba para poder ejecutar su operación, de la siguiente manera:

Primero: creamos una Interface para independizar su implementación así:

Segundo: creamos una clase por cada tipo de reporte que queramos generar.

Tercero: Modificamos el llamado para que la función solo reciba la instancia del objeto segun el tipo de reporte a generar. 
