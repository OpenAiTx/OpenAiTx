[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

تم بدء PocoClassGenerator بواسطة أداة توليد POCO الخاصة بـ `Necroskillz` [توليد كائنات POCO للغة C# من تعبير SQL في LINQPad](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### الميزات

- يدعم توليد كود كائنات POCO لجميع الجداول والعروض Views في قاعدة البيانات الحالية
- يدعم [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- يدعم أنظمة قواعد بيانات متعددة: `sqlserver,oracle,mysql,postgresql`
- صغير وسريع (يولد كود 100 جدول خلال 5 ثواني فقط)
- يستخدم استعلام SQL المناسب لكل قاعدة بيانات لاسترجاع المخطط والدوال المناسبة

### العرض التوضيحي DEMO
- [توليد كلاس POCO عن طريق SQL ديناميكي | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [مولد كلاس POCO لجميع الجداول | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [مولد كلاس POCO من DataTable | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### البدء السريع

👇أولاً: قم بنسخ ولصق كود [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) في مشروعك أو في LINQPad.  
أو قم بالتثبيت من [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇ثانياً: استخدم الاتصال لاستدعاء `GenerateAllTables` ثم اطبع الناتج.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### دعم كلاس POCO مع Dapper Contrib
- فقط استدعي الدالة مع `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**العرض التوضيحي على الإنترنت: [توليد كلاس POCO Dapper Contrib لجميع الجداول | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### توليد التعليقات Comment

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### توليد العروض View

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### توليد العروض والتعليقات ودعم Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### توليد كلاس واحد من استعلام SQL

1. توليد كلاس واحد
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. تحديد اسم الكلاس
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
الكود في [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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