# Documentacion Entity Framework Core

### �Qu� es un ORM?
> El mapeo objeto-relacional (m�s conocido por su nombre en ingl�s, Object-Relational mapping, o sus siglas O/RM, ORM, y O/R mapping) es una t�cnica de programaci�n para convertir datos entre el sistema de tipos utilizado en un lenguaje de programaci�n orientado a objetos y la utilizaci�n de una base de datos relacional como motor de persistencia. 
> 
>En la pr�ctica esto crea una base de datos orientada a objetos virtual, sobre la base de datos relacional. Esto posibilita el uso de las caracter�sticas propias de la orientaci�n a objetos (b�sicamente herencia y polimorfismo). Hay paquetes comerciales y de uso libre disponibles que desarrollan el mapeo relacional de objetos, aunque algunos programadores prefieren crear sus propias herramientas ORM.

Object-Relational mapping, o lo que es lo mismo, mapeo de objeto-relacional, es un modelo de programaci�n que consiste en la transformaci�n de las tablas de una base de datos, en una serie de entidades que simplifiquen las tareas b�sicas de acceso a los datos para el programador.

### ORMs m�s utilizados
Casi todos los lenguajes de alto nivel actualmente disponen de alguna soluci�n de este tipo, una de las m�s conocidas es Hibernate para JAVA, pero existen muchas m�s:

 - Java: Hibernate, iBatis, Ebean, etc..
 - .NET: Entity Framework, nHibernate, etc..
 - PHP: Doctrine, Propel, ROcks, Torpor, etc..

### �Qu� es Entity Framework 

EF Core es un asignador relacional de objetos (ORM) que permite a los desarrolladores .NET trabajar con una base de datos utilizando objetos .NET.




Antes de la version .NET 3.5, los desarrolladores usaban para escribir c�digo ADO.NET o Enterprise Data Access Block para guardar o recuperar datos de aplicaciones de la base de datos subyacente.

La mayor�a de los marcos de desarrollo incluyen bibliotecas que permiten el acceso a datos desde bases de datos relacionales a trav�s de estructuras de datos similares a un conjunto de registros. El siguiente ejemplo de c�digo ilustra un escenario t�pico de uso de ADO.NET:
![DAL](https://github.com/imyourpartner/MyFiles/blob/master/ADODotNetDataAccessLayer.jpg)
 - Stored Procedures
```sql
CREATE PROCEDURE dbo.GetBooks
AS
   select * from books


CREATE PROCEDURE dbo.GetBook(@bookid int)
AS
    select * from books where bookid = @bookid


CREATE PROCEDURE dbo.AddBook(  @title varchar(50), @authors varchar(200), @price money, @publisher varchar(50) )
AS

   insert into books (title,authors,price,publisher)
      values(@title,@authors,@price,@publisher)
      
   
CREATE PROCEDURE dbo.DeleteBook	(@bookid int)
AS
	delete from books where bookid = @bookid
	if @@rowcount <> 1 
	    raiserror('Invalid Book Id',16,1)


CREATE PROCEDURE dbo.UpdateBook( @bookid int,  @title varchar(50), @authors varchar(200), @price money, @publisher varchar(50) )
AS

   update books set title= @title, authors  = @authors, price = @price, publisher = @publisher
   where bookid = @bookid;
   
   if @@rowcount <> 1 
      raiserror('Invalid Book Id',16,1)
```


```csharp
using(var conn = new SqlConnection(connectionString))
using(var cmd = new SqlCommand("select * from Products", conn))
{
    var dt = new DataTable();
    using(var da = new SqlDataAdapter(cmd))
    {
        da.Fill(dt);
    }
}
```

Se  abria una conexi�n a la base de datos, crear un conjunto de datos para recuperar o enviar los datos a la base de datos, convertir los datos del conjunto de datos a objetos .NET o viceversa para aplicar reglas de negocios. Este fue un proceso engorroso y propenso a errores. 

Microsoft ha proporcionado un marco denominado "Entity Framework" para automatizar todas estas actividades relacionadas con la base de datos para su aplicaci�n.

Entity Framework es un marco de ORM de c�digo abierto  para aplicaciones .NET admitidas por Microsoft. Permite a los desarrolladores trabajar con datos utilizando objetos de clases espec�ficas del dominio sin centrarse en las tablas y columnas de la base de datos subyacente donde se almacenan estos datos. Con el Entity Framework, los desarrolladores pueden trabajar en un nivel m�s alto de abstracci�n cuando tratan con datos, y pueden crear y mantener aplicaciones orientadas a datos con menos c�digo en comparaci�n con las aplicaciones tradicionales.


### Proveedores de bases de datos compatibles

Entity Framework Core es compatible con muchos proveedores de bases de datos para acceder a diferentes bases de datos y realizar operaciones de base de datos.

 - SQL Server
 - MySQL
 - PostgreSQL
 - SQLite
 - SQL Compact