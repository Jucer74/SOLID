## Single Responsability Principle (SRP)
Un módulo solo debe tener **un motivo para cambiar**.

Lo cual quiere decir que una clase debería estar destinada a **una única responsabilidad** y no mezclar la de otros o las que no le incumben a su dominio.

## Ejemplo
El siguiente ejemplo es una clase que permite interactuar con los datos de los empleados y permite generar un reporte con los mismos.


<pre>
<code class='language-cs'>
public class ApplicationData
{
  private readonly SqlDatabase sqlDatabase;
}
</code>
</pre>

```csharp
public class ApplicationData
{
  private readonly SqlDatabase sqlDatabase;
}
```

### Qué anda mal?
El código en general esta bien, pero el problema es que comparte la responsabilidad de generar un reporte, la cual no esta dentro de su dominio principal, el cual es interactuar con los registro de la tabla **Employees**.

Sabemos que no tiene una sola responsabilidad si hacemos las siguientes preguntas:

* Qué clase debemos cambiar si queremos cambiar el tipo de formato en el que se genera el reporte de separado por comas a XML?
* Qué clase debemos cambiar si queremos adicionar una funcion para borrar los datos de los empleados?

Si la respuesta es la misma (**ApplicationData**), entonces esta clase no tiene una sola responsabilidad.

