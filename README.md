# Principios S.O.L.I.D.
En este espacio realizaremos un ejercicio de Inicio a fin en donde aplicaremos todos los principios SOLID a un proyecto de consola desarrollado en .Net Core e implementado en lenguaje C#.

# Qué es S.O.L.I.D.?
Los principios SOLID son una serie de recomendaciones para escribir un mejor código que ayuda a implementar una **alta cohesión** y **bajo acoplamiento**.

Implementar SOLID puede ser una tarea simple o compleja, todo esto dependerá de la práctica pero tenerlos en cuenta desde un comienzo será más fácil de trabajar. La idea es buscar un punto de equilibrio ya que tal vez no todo nuestro proyecto necesite de dichos principios.

Estos principios se llamaron S.O.L.I.D. por sus siglas en inglés:

* **S**: Single responsibility principle o Principio de responsabilidad única (**SRP**).
* **O**: Open/closed principle o Principio de abierto/cerrado (**OCP**).
* **L**: Liskov substitution principle o Principio de sustitución de Liskov (**LSP**).
* **I**: Interface segregation principle o Principio de segregación de la interfaz (**ISP**).
* **D**: Dependency inversion principle o Principio de inversión de dependencia (**DIP**).


## El Proyecto
El proyecto es una sencilla aplicación de consola, con las siguientes opciones:

     S.O.L.I.D. Principles
    ------------------------------
    1. Insert new Employee
    2. Get Employee List
    3. Generate Employees Report
    4. Show Projects
    0. Exit
    Select Option:


Cada una de la opciones realiza accones sobre una pequeña base de datos SQLite con la siguiente estructura:


La tabla de empleados 