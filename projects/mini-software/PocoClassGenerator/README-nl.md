[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator is gestart met `Necroskillz`'s POCO Generator [Genereer C# POCO's vanuit SQL-statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Functies

- Ondersteunt het genereren van POCO-classcode voor alle tabellen en views in de huidige database
- Ondersteunt [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Ondersteunt meerdere RDBMS: `sqlserver, oracle, mysql, postgresql`
- Klein en snel (genereert code voor 100 tabellen in slechts 5 seconden)
- Gebruikt voor elke databasequery de juiste dialect-schema-tabel-SQL

### DEMO
- [POCOGenerator Genereer Klasse Via Dynamische SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Aan de slag

👇Eerst:  Kopieer en plak [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) code in je project of LINQPad.  
of installeer via [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Ten tweede: Gebruik de connectie om `GenerateAllTables` aan te roepen en print het resultaat.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Ondersteuning voor Dapper Contrib POCO Class
- Roep eenvoudig de methode aan met `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**De online demo: [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Genereer Commentaar

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Genereer View

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Genereer View en Commentaar en Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Genereer één klasse via SQL

1. Genereer één klasse
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Specificeer de klassenaam
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Code op [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

```C#
var dt = new DataTable();
dt.TableName = "TestTable";
dt.Columns.Add(new DataColumn() { ColumnName = "ID", DataType = typeof(string) });

var result = dt.GenerateClass();
var expect =
@"public class TestTable
{
public string ID { get; set; }
}";
Assert.Equal(expect, result);
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---