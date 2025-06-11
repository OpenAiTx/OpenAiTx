[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator foi iniciado com o POCO Generator de `Necroskillz` [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Funcionalidades

- Suporta geração de código de classe POCO para todas as tabelas e views do banco de dados atual
- Suporta [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Suporta múltiplos SGBDs: `sqlserver, oracle, mysql, postgresql`
- Leve e rápido (gera código para 100 tabelas em apenas 5 segundos)
- Utiliza SQL de schema de tabela apropriado para cada consulta de banco de dados

### DEMONSTRAÇÃO
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Início Rápido

👇Primeiro: Copie e cole o código de [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) no seu projeto ou no LINQPad.  
ou instale via [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Segundo: Use uma conexão para chamar `GenerateAllTables` e, em seguida, imprima o resultado.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Suporte a Dapper Contrib POCO Class
- Basta chamar o método com `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**Demonstração Online: [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Gerar Comentário

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Gerar View

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Gerar View, Comentário e Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Gerar uma classe a partir de SQL

1. Gerar uma classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Especificar nome da classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Código em [DataTablePocoClassGenerator.cs](https://github.com/shps951023/PocoClassGenerator/blob/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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