[![NuGet](https://img.shields.io/nuget/v/PocoClassGenerator.svg)](https://www.nuget.org/packages/PocoClassGenerator)
![](https://img.shields.io/nuget/dt/PocoClassGenerator.svg)

---

PocoClassGenerator는 `Necroskillz`의 POCO Generator [Generate C# POCOs from SQL statement in LINQPad ](http://www.necronet.org/archive/2012/10/09/generate-c-pocos-from-sql-statement-in-linqpad.aspx)에서 시작되었습니다.

### 특징

- 현재 데이터베이스의 모든 테이블과 뷰에 대해 POCO 클래스 코드를 생성 지원
- [Dapper.Contrib](https://github.com/StackExchange/Dapper/tree/master/Dapper.Contrib) 지원
- 여러 RDBMS 지원: `sqlserver,oracle,mysql,postgresql`
- 작고 빠름 (5초 만에 100개 테이블 코드 생성)
- 각 데이터베이스 쿼리에 맞는 적절한 방언의 스키마 테이블 SQL 사용

### DEMO
- [POCOGenerator Generate Class By Dynamic SQL | .NET Fiddle](https://dotnetfiddle.net/bDdSCA)
![20191009102303.png](https://i.loli.net/2019/10/09/4AOsU2X8PWBcbGS.png)
- [POCO Class Generator GenerateAllTables  | .NET Fiddle](https://dotnetfiddle.net/GkdqsU)
- [DataTable POCO Class Generator  | .NET Fiddle](https://dotnetfiddle.net/vVeYwA)


![image](https://github.com/user-attachments/assets/235c4952-259b-4ecc-90b2-d0138c17316c)


### 시작하기

👇첫 번째 : [PocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/PocoClassGenerator.cs) 코드를 복사하여 프로젝트 또는 LINQPad에 붙여넣으세요.  
또는 [NuGet](https://www.nuget.org/packages/PocoClassGenerator/)에서 설치하세요.
```cmd
PM> install-package PocoClassGenerator
```

👇두 번째 :  연결(Connection)을 사용하여 `GenerateAllTables`를 호출한 뒤 출력합니다.
```C#
using (var connection = Connection)
{
	Console.WriteLine(connection.GenerateAllTables());
}
```


#### Dapper Contrib POCO 클래스 지원
- `GeneratorBehavior.DapperContrib`로 메서드를 호출하세요.

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```
**온라인 데모: [POCO Dapper Contrib Class Generator GenerateAllTables | .NET Fiddle](https://dotnetfiddle.net/yeuK1E)**

![image](https://github.com/user-attachments/assets/2989c2dc-8c06-4732-9069-a09605e1b18f)


#### 주석 생성

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.Comment);
    Console.WriteLine(result);
}
```

#### 뷰(View) 생성

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View);
    Console.WriteLine(result);
}
```

#### 뷰, 주석, Dapper.Contrib 동시 생성

```C#
using (var conn = GetConnection())
{
    var result = conn.GenerateAllTables(GeneratorBehavior.View | GeneratorBehavior.Comment | GeneratorBehavior.DapperContrib);
    Console.WriteLine(result);
}
```

#### SQL로 단일 클래스 생성

1. 단일 클래스 생성
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("select * from Table");
	Console.WriteLine(classCode);
}
```

2. 클래스명 지정
```C#
using (var connection = Connection)
{
	var classCode = connection.GenerateClass("with EMP as (select 1 ID,'WeiHan' Name,25 Age) select * from EMP", className: "EMP");
	Console.WriteLine(classCode);
}
```


#### DataTablePocoClass
코드는 [DataTablePocoClassGenerator.cs](https://raw.githubusercontent.com/mini-software/PocoClassGenerator/master/PocoClassGenerator/PocoClassGenerator/DataTablePocoClassGenerator.cs)에 있습니다.

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