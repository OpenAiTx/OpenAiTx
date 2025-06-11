[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator با الهام از POCO Generator ساخته شده توسط `Necroskillz` [تولید POCOهای #C از دستورات SQL در LINQPad](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx) آغاز شد.

### قابلیت‌ها

- پشتیبانی از تولید کد کلاس POCO برای تمامی جداول و نماهای دیتابیس فعلی
- پشتیبانی از [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- پشتیبانی از چندین RDBMS: `sqlserver,oracle,mysql,postgresql`
- کم حجم و سریع (تنها در ۵ ثانیه کد ۱۰۰ جدول را تولید می‌کند)
- استفاده از SQL شمای مناسب برای هر بانک داده جهت کوئری

### دموی آنلاین
- [تولید کلاس POCO با SQL داینامیک | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [تولیدکننده کلاس POCO GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [تولیدکننده کلاس POCO از DataTable | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### شروع به کار

👇ابتدا: کد [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) را کپی و در پروژه یا LINQPad خود قرار دهید.  
یا از [NuGet](https://www.nuget.org/packages/PocoClassGenerator/) نصب کنید.
```cmd
PM> install-package PocoClassGenerator
```

👇سپس: با استفاده از Connection متد `GenerateAllTables` را فراخوانی و چاپ کنید.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### پشتیبانی از کلاس POCO برای Dapper.Contrib
- کافی است متد را با `GeneratorBehavior.DapperContrib` فراخوانی کنید

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**دموی آنلاین: [تولیدکننده کلاس POCO Dapper Contrib GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### تولید کامنت

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### تولید View

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### تولید View و کامنت و Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### تولید یک کلاس با SQL

1. تولید یک کلاس
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. مشخص کردن نام کلاس
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
کد در [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs) موجود است.

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