[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator è iniziato con il generatore POCO di `Necroskillz` [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Caratteristiche

- Supporta la generazione del codice della classe POCO per tutte le tabelle e viste dell’attuale DataBase
- Supporta [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Supporta diversi RDBMS: `sqlserver,oracle,mysql,postgresql`
- Mini e veloce (genera il codice di 100 tabelle in soli 5 secondi)
- Utilizza la query SQL dello schema della tabella con il dialetto appropriato per ogni database

### DEMO
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Inizia subito

👇Prima :  Copia e incolla il codice da [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) nel tuo progetto o in LINQPad.  
oppure installa da [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Secondo :  Usa la connessione per chiamare `GenerateAllTables` e stampare il risultato.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Supporto per la classe POCO Dapper Contrib
- Basta chiamare il metodo con `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**Demo online : [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Genera Commenti

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Genera Vista

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Genera Vista, Commento e Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Genera una singola classe tramite SQL

1. Genera una singola classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Specifica il nome della classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Codice in [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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