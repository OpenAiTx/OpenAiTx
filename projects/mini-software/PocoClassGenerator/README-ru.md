[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator основан на POCO Generator от `Necroskillz` [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Особенности

- Поддержка генерации кода POCO-классов для всех таблиц и представлений текущей базы данных
- Поддержка [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Поддержка нескольких СУБД: `sqlserver,oracle,mysql,postgresql`
- Минималистичный и быстрый (только за 5 секунд генерирует код для 100 таблиц)
- Использует соответствующий SQL-диалект для схемы таблиц каждой базы данных

### ДЕМО
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Начало работы

👇Первое:  Скопируйте и вставьте код из [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) в ваш проект или в LINQPad.  
или установите из [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Второе:  Используйте соединение для вызова `GenerateAllTables` и затем выведите результат.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Поддержка Dapper Contrib POCO Class
- Просто вызовите метод с параметром `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**Онлайн-демо: [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Генерация комментариев

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Генерация представлений

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Генерация представлений, комментариев и Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Генерация одного класса по SQL

1. Генерация одного класса
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Указание имени класса
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Код находится в [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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