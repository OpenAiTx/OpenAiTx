[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=zh-CN"><img src="https://img.shields.io/badge/Simplified Chinese-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=zh-TW"><img src="https://img.shields.io/badge/Traditional Chinese-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=ja"><img src="https://img.shields.io/badge/Japanese-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=ko"><img src="https://img.shields.io/badge/Korean-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=th"><img src="https://img.shields.io/badge/Thai-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=fr"><img src="https://img.shields.io/badge/French-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=de"><img src="https://img.shields.io/badge/German-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=es"><img src="https://img.shields.io/badge/Spanish-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=it"><img src="https://img.shields.io/badge/Italian-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=ru"><img src="https://img.shields.io/badge/Russian-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=pt"><img src="https://img.shields.io/badge/Portuguese-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=nl"><img src="https://img.shields.io/badge/Dutch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=pl"><img src="https://img.shields.io/badge/Polish-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=ar"><img src="https://img.shields.io/badge/Arabic-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=tr"><img src="https://img.shields.io/badge/Turkish-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=mini-software&project=PocoClassGenerator&lang=vi"><img src="https://img.shields.io/badge/Vietnamese-white" alt="version"></a> </p></div>

---

PocoClassGenerator is started with `Necroskillz`'s POCO Generator [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Features

- Supports generating POCO class code for all current database tables and views
- Supports [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Supports multiple RDBMS: `sqlserver, oracle, mysql, postgresql`
- Lightweight and fast (generates code for 100 tables in just 5 seconds)
- Uses appropriate dialect schema table SQL for each database query

### DEMO
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Get Started

👇First:  Copy & Paste [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) code into your project or LINQPad.  
or Install from [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Second:  Use the connection to call `GenerateAllTables` and then print it.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Support Dapper Contrib POCO Class
- Just call the method with `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**The Online Demo: [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Generate Comment

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Generate View

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Generate View and Comment and Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Generate one class by SQL

1. Generate one class
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Specify class name
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Code at [DataTablePocoClassGenerator.cs](https://github.com/shps951023/PocoClassGenerator/blob/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---