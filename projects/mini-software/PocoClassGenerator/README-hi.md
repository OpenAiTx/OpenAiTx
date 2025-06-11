[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator की शुरुआत `Necroskillz` के POCO Generator [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx) से हुई है।

### विशेषताएँ

- वर्तमान डेटाबेस की सभी टेबल्स और व्यूज़ के लिए POCO क्लास कोड जेनरेट करने का समर्थन करता है
- [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib) का समर्थन करता है
- कई RDBMS का समर्थन करता है: `sqlserver,oracle,mysql,postgresql`
- छोटा और तेज़ (सिर्फ 5 सेकंड में 100 टेबल्स का कोड जेनरेट करें)
- प्रत्येक डेटाबेस क्वेरी के लिए उपयुक्त डायलेक्ट स्कीमा टेबल SQL का उपयोग करता है

### डेमो
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### शुरुआत करें

👇पहला : [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) कोड को अपनी प्रोजेक्ट या LINQPad में कॉपी और पेस्ट करें।  
या [NuGet](https://www.nuget.org/packages/PocoClassGenerator/) से इंस्टॉल करें।
```cmd
PM> install-package PocoClassGenerator
```

👇दूसरा : कनेक्शन का उपयोग करके `GenerateAllTables` को कॉल करें और इसे प्रिंट करें।
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Dapper Contrib POCO Class का समर्थन
- बस `GeneratorBehavior.DapperContrib` के साथ मेथड को कॉल करें

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**ऑनलाइन डेमो : [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### कमेंट जेनरेट करें

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### व्यू जेनरेट करें

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### व्यू, कमेंट और Dapper.Contrib जेनरेट करें

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### SQL द्वारा एक क्लास जेनरेट करें

1. एक क्लास जेनरेट करें
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. क्लास नाम निर्दिष्ट करें
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
कोड यहाँ है: [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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