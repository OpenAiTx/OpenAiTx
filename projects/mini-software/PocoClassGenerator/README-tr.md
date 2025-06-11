[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator, `Necroskillz`'in POCO Generator'ı ile başlatılmıştır [LINQPad'de SQL ifadesinden C# POCO'ları oluşturun](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Özellikler

- Geçerli Veritabanındaki tüm tabloları ve görünümleri POCO sınıf kodu olarak oluşturma desteği
- [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib) desteği
- Birden fazla RDBMS desteği: `sqlserver,oracle,mysql,postgresql`
- Minimal ve hızlı (sadece 5 saniyede 100 tablo kodu oluşturur)
- Her veritabanı sorgusu için uygun diyalekt şema tablo SQL kullanımı

### DEMO
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Başlarken

👇İlk olarak: [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) dosyasındaki kodu projenize veya LINQPad'e kopyalayın.  
veya [NuGet](https://www.nuget.org/packages/PocoClassGenerator/) üzerinden yükleyin
```cmd
PM> install-package PocoClassGenerator
```

👇İkinci olarak:  Bağlantı oluşturun, `GenerateAllTables` fonksiyonunu çağırın ve çıktıyı yazdırın.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Dapper Contrib POCO Sınıf Desteği
- Sadece `GeneratorBehavior.DapperContrib` ile metodu çağırın

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**Çevrimiçi Demo : [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Açıklama (Comment) Üretme

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Görünüm (View) Üretme

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Görünüm ve Açıklama ve Dapper.Contrib Üretme

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### SQL ile bir sınıf üretme

1. Bir sınıf üretme
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Sınıf adını belirtme
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Kod burada: [DataTablePocoClassGenerator.cs](https://github.com/shps951023/PocoClassGenerator/blob/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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