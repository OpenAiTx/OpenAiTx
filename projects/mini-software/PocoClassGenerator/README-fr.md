[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator a débuté avec le POCO Generator de `Necroskillz` [Générer des POCO C# à partir d'une requête SQL dans LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)

### Fonctionnalités

- Prise en charge de la génération du code des classes POCO pour toutes les tables et vues de la base de données actuelle
- Prise en charge de [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib)
- Prise en charge de plusieurs SGBDR : `sqlserver,oracle,mysql,postgresql`
- Léger et rapide (génère le code de 100 tables en seulement 5 secondes)
- Utilise une requête SQL de schéma adaptée à chaque base de données

### DÉMO
- [POCOGenerator Générer une classe par SQL dynamique | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### Démarrage

👇Première étape :  Copiez et collez le code de [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) dans votre projet ou LINQPad.  
ou installez depuis [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)
```cmd
PM> install-package PocoClassGenerator
```

👇Deuxième étape :  Utilisez une connexion pour appeler `GenerateAllTables` puis affichez le résultat.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Prise en charge des classes POCO Dapper Contrib
- Il suffit d'appeler la méthode avec `GeneratorBehavior.DapperContrib`

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**Démo en ligne : [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### Générer les commentaires

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### Générer les vues

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### Générer les vues, les commentaires et Dapper.Contrib

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### Générer une seule classe par SQL

1. Générer une classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. Spécifier le nom de la classe
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
Code disponible à [DataTablePocoClassGenerator.cs](https://github.com/shps951023/PocoClassGenerator/blob/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)

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