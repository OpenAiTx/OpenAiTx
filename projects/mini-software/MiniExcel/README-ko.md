<div style="text-align: center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div style="text-align: center">
<p>이 프로젝트는 <a href="https://www.dotnetfoundation.org/">.NET 재단</a>의 일부이며, <a href="https://www.dotnetfoundation.org/code-of-conduct">행동 강령</a>을 준수합니다. </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div style="text-align: center">
 여러분의 <a href="https://github.com/mini-software/MiniExcel">스타</a> 또는 <a href="https://miniexcel.github.io">기부</a>가 MiniExcel을 더 발전시킬 수 있습니다.
</div>

---

### 소개

MiniExcel은 .NET을 위한 단순하고 효율적인 엑셀 처리 도구로, 메모리 사용을 최소화하도록 설계되었습니다.

현재 대부분의 인기 있는 프레임워크는 엑셀 문서의 모든 데이터를 메모리로 로드한 후 조작하는 방식을 사용하지만, 이로 인해 메모리 소비 문제가 발생할 수 있습니다. MiniExcel은 다른 접근 방식을 취합니다. 데이터를 스트리밍 방식으로 한 행씩 처리하여, 원래 수백 메가바이트에 이를 수 있는 소비를 몇 메가바이트 수준으로 줄임으로써 효과적으로 Out-of-memory(OOM) 문제를 방지합니다.

![Screenshot 2025-06-22 123525](https://github.com/user-attachments/assets/0b99a61e-8061-4604-8957-0b1f3ec74544)


### 특징

- 메모리 사용을 최소화하여 out-of-memory (OOM) 오류를 예방하고 전체 가비지 컬렉션을 방지함
- 대용량 데이터셋에서 실시간, 행 단위 데이터 처리를 지원하여 성능 향상
- LINQ의 지연 실행을 지원하여 빠르고 메모리 효율적인 페이징 및 복잡한 쿼리 가능
- Microsoft Office나 COM+ 컴포넌트 없이 사용할 수 있으며, DLL 크기가 500KB 미만으로 가볍다
- 엑셀을 읽기/쓰기/채우기 위한 간단하고 직관적인 API 스타일 제공

### 시작하기

- [엑셀 가져오기/쿼리](#getstart1)

- [엑셀 내보내기/생성](#getstart2)

- [엑셀 템플릿](#getstart3)

- [엑셀 컬럼명/인덱스/무시 특성](#getstart4)

- [예제](#getstart5)



### 설치

패키지는 [NuGet에서 설치](https://www.nuget.org/packages/MiniExcel)할 수 있습니다.

### 릴리즈 노트

[릴리즈 노트](docs)를 확인하세요.

### TODO

[TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)를 확인하세요.

### 성능

벤치마크 코드는 [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs)에서 확인할 수 있습니다.

성능 테스트에 사용된 파일은 [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx)로, 1,000,000 행 * 10 열(각 셀에 "HelloWorld" 문자열이 입력됨)로 구성된 32MB 문서입니다.

모든 벤치마크를 실행하려면 다음 명령어를 사용하세요:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

최신 릴리즈에 대한 벤치마크 결과는 [여기](benchmarks/results)에서 확인하실 수 있습니다.


### 엑셀 쿼리/가져오기  <a name="getstart1"></a>

#### 1. 쿼리를 실행하고 결과를 강력한 타입의 IEnumerable로 매핑 [[실행해보기]](https://dotnetfiddle.net/w5WD1J)

Stream.Query를 사용하는 것이 더 효율적이므로 권장합니다.

```csharp
public class UserAccount
{
```csharp
public Guid ID { get; set; }
public string Name { get; set; }
public DateTime BoD { get; set; }
public int Age { get; set; }
public bool VIP { get; set; }
public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// 또는

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. 헤더를 사용하지 않고 동적 객체 리스트에 쿼리 및 매핑 실행 [[Try it]](https://dotnetfiddle.net/w5WD1J)

* dynamic 키는 `A.B.C.D..` 입니다.

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// 또는
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. 첫 번째 헤더 행을 사용하는 쿼리 실행 [[Try it]](https://dotnetfiddle.net/w5WD1J)

참고 : 동일한 컬럼명은 가장 오른쪽에 있는 것을 사용합니다.

입력 엑셀 :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// 또는

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. LINQ 확장(First/Take/Skip 등) 지원 쿼리

첫 번째 행 쿼리
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// 또는

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

MiniExcel/ExcelDataReader/ClosedXML/EPPlus의 성능 비교
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. 시트 이름으로 쿼리

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//또는
stream.Query(sheetName: "SheetName");
```

#### 6. 모든 시트명 및 행 쿼리
```
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. 열 가져오기

```csharp
var columns = MiniExcel.GetColumns(path); // 예시 결과 : ["A","B"...]

var cnt = columns.Count;  // 열 개수 가져오기
```

#### 8. 동적 쿼리에서 행을 `IDictionary<string,object>`로 캐스팅

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// 또는
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// 또는 지정한 범위 쿼리(대문자 사용)
// A2는 A열의 두 번째 행, C3는 C열의 세 번째 행을 의미함
// 행을 제한하지 않으려면 숫자를 포함하지 않으면 됨
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. Excel 쿼리 결과를 DataTable로 반환

권장하지 않습니다. DataTable은 모든 데이터를 메모리로 로드하여 MiniExcel의 저메모리 소비 특성을 잃게 됩니다.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. 데이터를 읽기 시작할 셀 지정

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. 병합된 셀 채우기

참고: `병합 채우기 미사용`에 비해 효율이 느립니다.

이유: OpenXml 표준은 mergeCells를 파일의 하단에 위치시키기 때문에 sheetxml을 두 번 foreach 해야 합니다.

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

가변 길이 및 너비의 다중 행/열 채우기 지원

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. 디스크 기반 캐시로 대용량 파일 읽기 (Disk-Base Cache - SharedString)

SharedStrings의 크기가 5MB를 초과하면, MiniExcel은 기본적으로 로컬 디스크 캐시를 사용합니다. 예시: [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx)(백만 행 데이터). 디스크 캐시를 비활성화하면 최대 메모리 사용량이 195MB이지만, 디스크 캐시 활성화 시 65MB만 필요합니다. 단, 이 최적화는 효율에 약간의 비용이 들어가므로, 이 경우 읽기 시간이 7.4초에서 27.2초로 증가합니다. 필요하지 않으면 아래 코드로 디스크 캐시를 비활성화할 수 있습니다:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

`SharedStringCacheSize`를 사용하여 공유 문자열 파일 크기가 지정한 크기를 초과하면 디스크 캐시를 사용하도록 변경할 수 있습니다.
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)
```
### Create/Export Excel  <a name="getstart2"></a>

1. 반드시 public 매개변수가 없는 생성자가 있는 추상 클래스가 아닌 타입이어야 합니다.

2. MiniExcel은 IEnumerable 지연 실행을 지원합니다. 최소한의 메모리 사용을 원한다면 ToList와 같은 메서드를 호출하지 마십시오.

예시 : ToList 호출 여부에 따른 메모리 사용량
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. 익명 또는 강력한 타입 [[Try it]](https://dotnetfiddle.net/w5WD1J)

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
MiniExcel.SaveAs(path, new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
});
```

#### 2. `IEnumerable<IDictionary<string, object>>`

```csharp
var values = new List<Dictionary<string, object>>()
{
    new Dictionary<string,object>{{ "Column1", "MiniExcel" }, { "Column2", 1 } },
    new Dictionary<string,object>{{ "Column1", "Github" }, { "Column2", 2 } }
};
MiniExcel.SaveAs(path, values);
```

생성된 파일 결과 :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `추천`, 모든 데이터를 메모리에 올리지 않아도 됩니다.
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader로 여러 시트 내보내기 (Dapper ExecuteReader 추천)

```csharp
using (var cnn = Connection)
{
    cnn.Open();
    var sheets = new Dictionary<string,object>();
    sheets.Add("sheet1", cnn.ExecuteReader("select 1 id"));
    sheets.Add("sheet2", cnn.ExecuteReader("select 2 id"));
    MiniExcel.SaveAs("Demo.xlsx", sheets);
}
```



#### 4. Datatable

- `비추천`, 모든 데이터를 메모리에 올립니다.

- DataTable은 우선 Caption을 열 이름으로 사용하고, 그 다음으로 컬럼명을 사용합니다.

```csharp
var path = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid()}.xlsx");
var table = new DataTable();
{
    table.Columns.Add("Column1", typeof(string));
    table.Columns.Add("Column2", typeof(decimal));
    table.Rows.Add("MiniExcel", 1);
    table.Rows.Add("Github", 2);
}

MiniExcel.SaveAs(path, table);
```

####  5. Dapper Query

@shaofing #552에 감사드립니다. `CommandDefinition + CommandFlags.NoCache`를 사용해 주세요.

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // 참고: QueryAsync는 연결 종료 예외를 발생시킬 수 있습니다.
    MiniExcel.SaveAs(path, rows);
}
```

아래 코드는 모든 데이터를 메모리에 로드합니다

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. MemoryStream에 SaveAs 하기  [[직접 해보기]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) // FileStream, MemoryStream 등 지원
{
    stream.SaveAs(values);
}
```

예시 : 엑셀 내보내기 API

```csharp
public IActionResult DownloadExcel()
{
    var values = new[] {
        new { Column1 = "MiniExcel", Column2 = 1 },
        new { Column1 = "Github", Column2 = 2}
    };

    var memoryStream = new MemoryStream();
    memoryStream.SaveAs(values);
    memoryStream.Seek(0, SeekOrigin.Begin);
    return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
    {
        FileDownloadName = "demo.xlsx"
    };
}
```


#### 7. 여러 시트 생성하기

```csharp
// 1. Dictionary<string,object>
var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
var sheets = new Dictionary<string, object>
{
    ["users"] = users,
    ["department"] = department
};
MiniExcel.SaveAs(path, sheets);

// 2. DataSet
var sheets = new DataSet();
sheets.Add(UsersDataTable);
sheets.Add(DepartmentDataTable);
//..
MiniExcel.SaveAs(path, sheets);
```

![image](https://user-images.githubusercontent.com/12729184/118130875-6e7c4580-b430-11eb-9b82-22f02716bd63.png)


#### 8. TableStyles 옵션

기본 스타일

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

스타일 설정 없이

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. 자동 필터(AutoFilter)

v0.19.0부터 `OpenXmlConfiguration.AutoFilter`로 자동 필터를 활성/비활성화 할 수 있으며, 기본값은 `true`입니다. 자동 필터 설정 방법:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. 이미지 생성하기

```csharp
```csharp
var value = new[] {
    new { Name="github",Image=File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png"))},
    new { Name="google",Image=File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png"))},
    new { Name="microsoft",Image=File.ReadAllBytes(PathHelper.GetFile("images/microsoft_logo.png"))},
    new { Name="reddit",Image=File.ReadAllBytes(PathHelper.GetFile("images/reddit_logo.png"))},
    new { Name="statck_overflow",Image=File.ReadAllBytes(PathHelper.GetFile("images/statck_overflow_logo.png"))},
};
MiniExcel.SaveAs(path, value);
```

![image](https://user-images.githubusercontent.com/12729184/150462383-ad9931b3-ed8d-4221-a1d6-66f799743433.png)



#### 11. 바이트 배열 파일 내보내기

버전 1.22.0부터 값 타입이 `byte[]`일 때 시스템은 기본적으로 셀에 파일 경로를 저장하며, 가져올 때 시스템에서 `byte[]`로 변환할 수 있습니다. 이 기능을 사용하지 않으려면 `OpenXmlConfiguration.EnableConvertByteArray`를 `false`로 설정하면 시스템 효율성이 향상될 수 있습니다.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

버전 1.22.0부터 값 타입이 `byte[]`일 때 시스템은 기본적으로 셀에 파일 경로를 저장하며, 가져올 때 시스템에서 `byte[]`로 변환할 수 있습니다. 이 기능을 사용하지 않으려면 `OpenXmlConfiguration.EnableConvertByteArray`를 `false`로 설정하면 시스템 효율성이 향상될 수 있습니다.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. 동일한 셀 세로 병합

이 기능은 `xlsx` 형식에서만 지원되며, @merge 및 @endmerge 태그 사이의 셀을 세로로 병합합니다.
@mergelimit을 사용하여 세로 병합 셀의 범위를 제한할 수 있습니다.

```csharp
var mergedFilePath = Path.Combine(Path.GetTempPath(), $"{Guid.NewGuid().ToString()}.xlsx");

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

MiniExcel.MergeSameCells(mergedFilePath, path);
```

```csharp
var memoryStream = new MemoryStream();

var path = @"../../../../../samples/xlsx/TestMergeWithTag.xlsx";

memoryStream.MergeSameCells(path);
```

병합 전과 후의 파일 내용:

병합 제한 없이:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

병합 제한 사용 시:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. null 값 건너뛰기

null 값에 대해 빈 셀을 쓰는 새로운 명시적 옵션:

```csharp
DataTable dt = new DataTable();

/* ... */

DataRow dr = dt.NewRow();

dr["Name1"] = "Somebody once";
dr["Name2"] = null;
dr["Name3"] = "told me.";

dt.Rows.Add(dr);

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = true // 기본값.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419455-3c0aec8a-4e5f-4d83-b7ec-6572124c165d.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" s="2"></x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

이전 동작:
```
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // 기본값은 true입니다.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://user-images.githubusercontent.com/31481586/241419441-c4f27e8f-3f87-46db-a10f-08665864c874.png)

```xml
<x:row r="2">
    <x:c r="A2" t ="str" s="2">
        <x:v>Somebody once</x:v>
    </x:c>
    <x:c r="B2" t ="str" s="2">
        <x:v></x:v>
    </x:c>
    <x:c r="C2" t ="str" s="2">
        <x:v>told me.</x:v>
    </x:c>
</x:row>
```

null 및 DBNull 값에 대해 동작합니다.

#### 14. 틀 고정(Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // 기본값은 1
    FreezeColumnCount = 2   // 기본값은 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### 엑셀 템플릿에 데이터 채우기 <a name="getstart3"></a>

- 선언 방식은 Vue 템플릿의 `{{변수명}}` 또는 컬렉션 렌더링 `{{컬렉션명.필드명}}`과 유사합니다.
- 컬렉션 렌더링은 IEnumerable/DataTable/DapperRow를 지원합니다.

#### 1. 기본 채우기

템플릿:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

결과:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

코드:
```csharp
// 1. POCO로 사용
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. Dictionary로 사용
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. IEnumerable 데이터 채우기

> 참고1: 동일한 열의 첫 번째 IEnumerable를 리스트 채우기의 기준으로 사용합니다.

템플릿:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

결과:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

코드:
```csharp
//1. POCO로 사용
var value = new
{
    employees = new[] {
```csharp
    new {name="Jack",department="HR"},
    new {name="Lisa",department="HR"},
    new {name="John",department="HR"},
    new {name="Mike",department="IT"},
    new {name="Neo",department="IT"},
    new {name="Loan",department="IT"}
}
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. Dictionary로 사용
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 3. 복잡한 데이터 채우기

> 참고: 다중 시트 및 동일 변수 사용 지원

템플릿:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

결과:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. POCO로 사용
var value = new
{
    title = "FooCompany",
    managers = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    employees = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

// 2. Dictionary로 사용
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Loan",department="IT"}
    },
    ["employees"] = new[] {
        new {name="Wade",department="HR"},
        new {name="Felix",department="HR"},
        new {name="Eric",department="IT"},
        new {name="Keaton",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 4. 대용량 데이터 성능 채우기

> 참고: IEnumerable 지연 실행을 사용하면 MiniExcel에서 최대한의 메모리 사용을 절약할 수 있습니다. ToList는 사용하지 마세요.

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)

#### 5. 셀 값 자동 매핑 타입

템플릿

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

결과

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

클래스

```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
```
```csharp
public decimal? @decimal { get; set; }
public double? @double { get; set; }
public DateTime? datetime { get; set; }
public bool? @bool { get; set; }
public Guid? Guid { get; set; }
}
```

코드

```csharp
var poco = new TestIEnumerableTypePoco { @string = "string", @int = 123, @decimal = decimal.Parse("123.45"), @double = (double)123.33, @datetime = new DateTime(2021, 4, 1), @bool = true, @Guid = Guid.NewGuid() };
var value = new
{
    Ts = new[] {
        poco,
        new TestIEnumerableTypePoco{},
        null,
        poco
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 6. 예제 :  Github 프로젝트 목록

템플릿

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


결과

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

코드

```csharp
var projects = new[]
{
    new {Name = "MiniExcel",Link="https://github.com/mini-software/MiniExcel",Star=146, CreateTime=new DateTime(2021,03,01)},
    new {Name = "HtmlTableHelper",Link="https://github.com/mini-software/HtmlTableHelper",Star=16, CreateTime=new DateTime(2020,02,01)},
    new {Name = "PocoClassGenerator",Link="https://github.com/mini-software/PocoClassGenerator",Star=16, CreateTime=new DateTime(2019,03,17)}
};
var value = new
{
    User = "ITWeiHan",
    Projects = projects,
    TotalStar = projects.Sum(s => s.Star)
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 7. 그룹 데이터 채우기

```csharp
var value = new Dictionary<string, object>()
{
    ["employees"] = new[] {
        new {name="Jack",department="HR"},
        new {name="Jack",department="HR"},
        new {name="John",department="HR"},
        new {name="John",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
await MiniExcel.SaveAsByTemplateAsync(path, templatePath, value);
```
##### 1. `@group` 태그와 `@header` 태그가 있는 경우

변경 전

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

변경 후

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. @group 태그만 있고 @header 태그가 없는 경우

변경 전

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

변경 후

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. @group 태그가 없는 경우

변경 전

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

변경 후

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. 셀 내부의 If/ElseIf/Else 문

규칙:
1. DateTime, Double, Int 타입에서 ==, !=, >, >=, <, <= 연산자를 지원합니다.
2. String 타입에서는 ==, != 연산자를 지원합니다.
3. 각 문장은 새로운 줄에 작성해야 합니다.
4. 연산자 앞뒤에 한 칸의 공백이 있어야 합니다.
5. 문장 내부에는 줄 바꿈이 없어야 합니다.
6. 셀의 형식은 아래 예시와 정확히 일치해야 합니다.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

변경 전

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

변경 후

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable을 파라미터로 사용하기

```csharp
var managers = new DataTable();
{
    managers.Columns.Add("name");
    managers.Columns.Add("department");
    managers.Rows.Add("Jack", "HR");
    managers.Rows.Add("Loan", "IT");
}
var value = new Dictionary<string, object>()
{
    ["title"] = "FooCompany",
    ["managers"] = managers,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```
#### 10. 수식(Formula)

##### 1. 예시
수식 앞에 `$`를 붙이고 `$enumrowstart`, `$enumrowend`로 열거형의 시작 행과 끝 행을 참조할 수 있습니다:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

템플릿이 렌더링될 때 `$` 접두사는 제거되고 `$enumrowstart`, `$enumrowend`는 실제 열거형의 시작/끝 행 번호로 치환됩니다:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. 기타 수식 예시:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| 합계         | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| 평균(대안)   | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| 범위         | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. 기타

##### 1. 템플릿 파라미터 키 확인

V1.24.0부터 기본적으로 템플릿에 없는 파라미터 키는 무시되고 빈 문자열로 대체됩니다. `IgnoreTemplateParameterMissing` 옵션을 통해 예외 발생 여부를 제어할 수 있습니다.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### 엑셀 열 이름/인덱스/무시 속성 <a name="getstart4"></a>



#### 1. 열 이름, 열 인덱스, 열 무시 지정

엑셀 예시

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

코드

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
```csharp
public string Test1 { get; set; }
[ExcelColumnName("Column2")]
public string Test2 { get; set; }
[ExcelIgnore]
public string Test3 { get; set; }
[ExcelColumnIndex("I")] // 시스템이 "I"를 8번 인덱스로 변환합니다.
public string Test4 { get; set; }
public string Test5 { get; } //set이 없으면 무시됩니다.
public string Test6 { get; private set; } //public이 아닌 set은 무시됩니다.
[ExcelColumnIndex(3)] // 0부터 시작
public string Test7 { get; set; }
}

var rows = MiniExcel.Query<ExcelAttributeDemo>(path).ToList();
Assert.Equal("Column1", rows[0].Test1);
Assert.Equal("Column2", rows[0].Test2);
Assert.Null(rows[0].Test3);
Assert.Equal("Test7", rows[0].Test4);
Assert.Null(rows[0].Test5);
Assert.Null(rows[0].Test6);
Assert.Equal("Test4", rows[0].Test7);
```





#### 2. 사용자 지정 포맷 (ExcelFormatAttribute)

V0.21.0부터 `ToString(string content)` 메서드 포맷을 포함하는 클래스를 지원합니다.

클래스

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

코드

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

결과

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Query는 사용자 지정 포맷 변환을 지원합니다.

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. 열 너비 설정(ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. 여러 열 이름을 동일한 속성에 매핑

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

1.24.0부터 시스템은 System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute를 지원합니다.

```C#
public class TestIssueI4TXGTDto
{
    public int ID { get; set; }
    public string Name { get; set; }
    [DisplayName("Specification")]
    public string Spc { get; set; }
    [DisplayName("Unit Price")]
    public decimal Up { get; set; }
}
```
```



#### 6. ExcelColumnAttribute

V1.26.0부터 여러 속성을 다음과 같이 간소화할 수 있습니다:
```csharp
        public class TestIssueI4ZYUUDto
        {
            [ExcelColumn(Name = "ID",Index =0)]
            public string MyProperty { get; set; }
            [ExcelColumn(Name = "CreateDate", Index = 1,Format ="yyyy-MM",Width =100)]
            public DateTime MyProperty2 { get; set; }
        }
```



#### 7. DynamicColumnAttribute

V1.26.0부터는 열의 속성을 동적으로 설정할 수 있습니다.
```csharp
            var config = new OpenXmlConfiguration
            {
                DynamicColumns = new DynamicExcelColumn[] {
                    new DynamicExcelColumn("id"){Ignore=true},
                    new DynamicExcelColumn("name"){Index=1,Width=10},
                    new DynamicExcelColumn("createdate"){Index=0,Format="yyyy-MM-dd",Width=15},
                    new DynamicExcelColumn("point"){Index=2,Name="Account Point"},
                }
            };
            var path = PathHelper.GetTempPath();
            var value = new[] { new { id = 1, name = "Jack", createdate = new DateTime(2022, 04, 12) ,point = 123.456} };
            MiniExcel.SaveAs(path, value, configuration: config);
```
![image](https://user-images.githubusercontent.com/12729184/164510353-5aecbc4e-c3ce-41e8-b6cf-afd55eb23b68.png)

#### 8. DynamicSheetAttribute

V1.31.4부터 시트의 속성을 동적으로 설정할 수 있습니다. 시트 이름과 상태(가시성)를 설정할 수 있습니다.
```csharp
            var configuration = new OpenXmlConfiguration
            {
                DynamicSheets = new DynamicExcelSheet[] {
                    new DynamicExcelSheet("usersSheet") { Name = "Users", State = SheetState.Visible },
                    new DynamicExcelSheet("departmentSheet") { Name = "Departments", State = SheetState.Hidden }
                }
            };

            var users = new[] { new { Name = "Jack", Age = 25 }, new { Name = "Mike", Age = 44 } };
            var department = new[] { new { ID = "01", Name = "HR" }, new { ID = "02", Name = "IT" } };
            var sheets = new Dictionary<string, object>
            {
                ["usersSheet"] = users,
                ["departmentSheet"] = department
            };

            var path = PathHelper.GetTempPath();
            MiniExcel.SaveAs(path, sheets, configuration: configuration);
```

새로운 속성 ExcelSheetAttribute도 사용할 수 있습니다:

```C#
   [ExcelSheet(Name = "Departments", State = SheetState.Hidden)]
   private class DepartmentDto
   {
      [ExcelColumn(Name = "ID",Index = 0)]
      public string ID { get; set; }
      [ExcelColumn(Name = "Name",Index = 1)]
      public string Name { get; set; }
   }
```

### 추가, 삭제, 업데이트

#### 추가

v1.28.0부터 CSV에서 마지막 행 다음에 N개의 데이터를 삽입할 수 있습니다.

```csharp
// 원본
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// 마지막 행 뒤에 1개 행 삽입
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// 마지막 행 뒤에 N개 행 삽입
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
```
```csharp
    };
    MiniExcel.Insert(path, value);
}
```

![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

v1.37.0에서는 기존 워크북에 새 시트를 삽입하는 기능을 지원합니다

```csharp
// 기존 엑셀
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// 새 시트 삽입
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### 삭제(대기 중)

#### 업데이트(대기 중)



### 엑셀 타입 자동 감지 <a name="getstart5"></a>

- MiniExcel은 기본적으로 `파일 확장자`를 기반으로 xlsx 또는 csv인지 확인하지만, 부정확할 수 있으니 수동으로 지정해 주세요.
- Stream의 경우 어느 엑셀 형식인지 알 수 없으니 반드시 수동으로 지정해 주세요.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//또는
stream.SaveAs(excelType:ExcelType.XLSX);
//또는
stream.Query(excelType:ExcelType.CSV);
//또는
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### 참고

- 기본적으로 `string` 타입으로 반환되며, strong typing generic으로 타입이 정의되지 않는 한 값은 숫자나 날짜로 변환되지 않습니다.



#### 사용자 지정 구분자

기본값은 `,` 이며, `Seperator` 속성을 수정하여 사용자 지정할 수 있습니다

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

V1.30.1부터 사용자 정의 구분자 함수 지원(감사합니다 @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### 사용자 지정 줄바꿈

기본값은 `\r\n` 이며, `NewLine` 속성을 수정하여 사용자 지정할 수 있습니다

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### 사용자 지정 인코딩
```
- 기본 인코딩은 "바이트 순서 표시로부터 인코딩 감지"입니다 (detectEncodingFromByteOrderMarks: true)
- 사용자 지정 인코딩이 필요하다면 StreamReaderFunc / StreamWriterFunc 속성을 수정하세요.

```csharp
// 읽기
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// 쓰기
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### 빈 문자열을 null로 읽기

기본적으로 빈 값은 string.Empty로 매핑됩니다. 이 동작을 변경할 수 있습니다.

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
1.23.0 버전부터 GetDataReader를 사용할 수 있습니다.

```csharp
    using (var reader = MiniExcel.GetReader(path,true))
    {
        while (reader.Read())
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                var value = reader.GetValue(i);
            }
        }
    }
```



###  Async

- v0.17.0 버전부터 Async 지원 (감사: isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

```csharp
public static Task SaveAsAsync(string path, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.UNKNOWN, IConfiguration configuration = null)
public static Task SaveAsAsync(this Stream stream, object value, bool printHeader = true, string sheetName = "Sheet1", ExcelType excelType = ExcelType.XLSX, IConfiguration configuration = null)
public static Task<IEnumerable<dynamic>> QueryAsync(string path, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task<IEnumerable<T>> QueryAsync<T>(this Stream stream, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<T>> QueryAsync<T>(string path, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null) where T : class, new()
public static Task<IEnumerable<IDictionary<string, object>>> QueryAsync(this Stream stream, bool useHeaderRow = false, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
public static Task SaveAsByTemplateAsync(this Stream stream, string templatePath, object value)
public static Task SaveAsByTemplateAsync(this Stream stream, byte[] templateBytes, object value)
public static Task SaveAsByTemplateAsync(string path, string templatePath, object value)
public static Task SaveAsByTemplateAsync(string path, byte[] templateBytes, object value)
public static Task<DataTable> QueryAsDataTableAsync(string path, bool useHeaderRow = true, string sheetName = null, ExcelType excelType = ExcelType.UNKNOWN, string startCell = "A1", IConfiguration configuration = null)
```

- v1.25.0 버전부터 `cancellationToken` 지원.



### 기타

#### 1. Enum

엑셀과 속성명이 반드시 동일해야 하며, 시스템이 자동으로 매핑합니다(대소문자 구분 없음).

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

V0.18.0부터 Enum Description 지원

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("일반 사용자")]
    V1,
    [Description("일반 관리자")]
    V2,
    [Description("슈퍼 관리자")]
    V3
}
```
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

1.30.0 버전부터 Excel Description을 Enum으로 지원합니다. @KaneLeung에게 감사드립니다.

#### 2. CSV를 XLSX로 변환 또는 XLSX를 CSV로 변환

```csharp
MiniExcel.ConvertXlsxToCsv(xlsxPath, csvPath);
MiniExcel.ConvertXlsxToCsv(xlsxStream, csvStream);
MiniExcel.ConvertCsvToXlsx(csvPath, xlsxPath);
MiniExcel.ConvertCsvToXlsx(csvStream, xlsxStream);
```
```csharp
using (var excelStream = new FileStream(path: filePath, FileMode.Open, FileAccess.Read))
using (var csvStream = new MemoryStream())
{
   MiniExcel.ConvertXlsxToCsv(excelStream, csvStream);
}
```

#### 3. 사용자 지정 CultureInfo

1.22.0 버전부터 아래와 같이 사용자 지정 CultureInfo를 설정할 수 있습니다. 시스템 기본값은 `CultureInfo.InvariantCulture`입니다.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// 또는
MiniExcel.Query(path, configuration: config);
```


#### 4. 사용자 지정 버퍼 크기
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

시스템이 메모리를 제어하지 않지만, 더 빠른 저장 속도를 얻을 수 있습니다.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. 이미지 일괄 추가 (MiniExcel.AddPicture)

AddPicture를 호출할 때 시스템이 큰 메모리를 사용하지 않도록, 행 데이터를 일괄로 생성하기 전에 이미지를 추가해 주세요.

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // 기본값 null은 첫 번째 시트
        CellAddress = "C3", // 필수
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // 기본값 PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // 필수
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. 시트 크기 가져오기

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### 예시:

#### 1. SQLite & Dapper `대용량 파일` SQL Insert OOM(Out Of Memory) 방지

참고 : Query 이후 ToList/ToArray 메서드를 호출하지 마세요. 모든 데이터를 메모리로 로드하게 됩니다.

```csharp
using (var connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    using (var transaction = connection.BeginTransaction())
    using (var stream = File.OpenRead(path))
```
```csharp
{
   var rows = stream.Query();
   foreach (var row in rows)
         connection.Execute("insert into T (A,B) values (@A,@B)", new { row.A, row.B }, transaction: transaction);
   transaction.Commit();
}
}
```

성능:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 또는 MVC 5 엑셀 Xlsx 다운로드/업로드 API 데모 [실행해보기](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)

```csharp
public class ApiController : Controller
{
    public IActionResult Index()
    {
        return new ContentResult
        {
            ContentType = "text/html",
            StatusCode = (int)HttpStatusCode.OK,
            Content = @"<html><body>
<a href='api/DownloadExcel'>DownloadExcel</a><br>
<a href='api/DownloadExcelFromTemplatePath'>DownloadExcelFromTemplatePath</a><br>
<a href='api/DownloadExcelFromTemplateBytes'>DownloadExcelFromTemplateBytes</a><br>
<p>Upload Excel</p>
<form method='post' enctype='multipart/form-data' action='/api/uploadexcel'>
    <input type='file' name='excel'> <br>
    <input type='submit' >
</form>
</body></html>"
        };
    }

    public IActionResult DownloadExcel()
    {
        var values = new[] {
            new { Column1 = "MiniExcel", Column2 = 1 },
            new { Column1 = "Github", Column2 = 2}
        };
        var memoryStream = new MemoryStream();
        memoryStream.SaveAs(values);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult DownloadExcelFromTemplatePath()
    {
        string templatePath = "TestTemplateComplex.xlsx";

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(templatePath, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    private static Dictionary<string, Byte[]> TemplateBytesCache = new Dictionary<string, byte[]>();

    static ApiController()
    {
        string templatePath = "TestTemplateComplex.xlsx";
        byte[] bytes = System.IO.File.ReadAllBytes(templatePath);
        TemplateBytesCache.Add(templatePath, bytes);
    }

    public IActionResult DownloadExcelFromTemplateBytes()
    {
        byte[] bytes = TemplateBytesCache["TestTemplateComplex.xlsx"];

        Dictionary<string, object> value = new Dictionary<string, object>()
        {
            ["title"] = "FooCompany",
            ["managers"] = new[] {
```
```csharp
                new {name="Jack",department="HR"},
                new {name="Loan",department="IT"}
            },
            ["employees"] = new[] {
                new {name="Wade",department="HR"},
                new {name="Felix",department="HR"},
                new {name="Eric",department="IT"},
                new {name="Keaton",department="IT"}
            }
        };

        MemoryStream memoryStream = new MemoryStream();
        memoryStream.SaveAsByTemplate(bytes, value);
        memoryStream.Seek(0, SeekOrigin.Begin);
        return new FileStreamResult(memoryStream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet")
        {
            FileDownloadName = "demo.xlsx"
        };
    }

    public IActionResult UploadExcel(IFormFile excel)
    {
        var stream = new MemoryStream();
        excel.CopyTo(stream);

        foreach (var item in stream.Query(true))
        {
            // do your logic etc.
        }

        return Ok("File uploaded successfully");
    }
}
```

####  3. 페이징 쿼리

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== 1페이지 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== 50페이지 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== 5000페이지 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. WebForm에서 메모리스트림을 통한 Excel 내보내기

```csharp
var fileName = "Demo.xlsx";
var sheetName = "Sheet1";
HttpResponse response = HttpContext.Current.Response;
response.Clear();
response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
response.AddHeader("Content-Disposition", $"attachment;filename=\"{fileName}\"");
var values = new[] {
    new { Column1 = "MiniExcel", Column2 = 1 },
    new { Column1 = "Github", Column2 = 2}
};
var memoryStream = new MemoryStream();
memoryStream.SaveAs(values, sheetName: sheetName);
memoryStream.Seek(0, SeekOrigin.Begin);
memoryStream.CopyTo(Response.OutputStream);
response.End();
```



#### 5. 동적 i18n 다국어 및 역할 권한 관리

예제처럼 i18n 및 권한 관리를 처리하는 메서드를 만들고, `yield return`을 사용하여 IEnumerable<Dictionary<string, object>>를 반환함으로써 동적이고 저메모리 처리 효과를 얻을 수 있습니다.

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us 및 Sales 역할");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
```
```csharp
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN and PMC role");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "zh-CN";
        var role = "PMC";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }
}

private IEnumerable<Dictionary<string, object>> GetOrders(string lang, string role, Order[] orders)
{
    foreach (var order in orders)
    {
        var newOrder = new Dictionary<string, object>();

        if (lang == "zh-CN")
        {
            newOrder.Add("客户编号", order.CustomerID);
            newOrder.Add("订单编号", order.OrderNo);
            newOrder.Add("产品编号", order.ProductID);
            newOrder.Add("数量", order.Qty);
            if (role == "Sales")
                newOrder.Add("价格", order.Amt);
            yield return newOrder;
        }
        else if (lang == "en-US")
        {
            newOrder.Add("Customer ID", order.CustomerID);
            newOrder.Add("Order No", order.OrderNo);
            newOrder.Add("Product ID", order.ProductID);
            newOrder.Add("Quantity", order.Qty);
            if (role == "Sales")
                newOrder.Add("Amount", order.Amt);
            yield return newOrder;
        }
        else
        {
            throw new InvalidDataException($"lang {lang} wrong");
        }
    }
}

public class Order
{
    public string OrderNo { get; set; }
    public string CustomerID { get; set; }
    public decimal Qty { get; set; }
    public string ProductID { get; set; }
    public decimal Amt { get; set; }
}
```

![image](https://user-images.githubusercontent.com/12729184/118939964-d24bc480-b982-11eb-88dd-f06655f6121a.png)



### FAQ

#### Q: Excel header title not equal class property name, how to mapping?

A. Please use ExcelColumnName attribute

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### Q. How to query or export multiple-sheets?

A. `GetSheetNames` method with  Query  sheetName parameter.



```csharp
var sheets = MiniExcel.GetSheetNames(path);
foreach (var sheet in sheets)
{
    Console.WriteLine($"sheet name : {sheet} ");
    var rows = MiniExcel.Query(path,useHeaderRow:true,sheetName:sheet);
    Console.WriteLine(rows);
}
```

![image](https://user-images.githubusercontent.com/12729184/116199841-2a1f5300-a76a-11eb-90a3-6710561cf6db.png)

#### Q. How to query or export information about sheet visibility?

A. `GetSheetInformations` method.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // next sheet index - numbered from 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // sheet name
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // sheet visibility state - visible / hidden
}
```
```

![image](https://user-images.githubusercontent.com/12729184/118939964-d24bc480-b982-11eb-88dd-f06655f6121a.png)



### FAQ

#### Q: 엑셀 헤더 제목이 클래스 속성명과 다를 때, 어떻게 매핑하나요?

A. ExcelColumnName 특성을 사용하세요.

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### Q. 여러 시트를 쿼리하거나 내보내려면 어떻게 하나요?

A. `GetSheetNames` 메서드와 Query의 sheetName 매개변수를 사용하세요.



```csharp
var sheets = MiniExcel.GetSheetNames(path);
foreach (var sheet in sheets)
{
    Console.WriteLine($"sheet name : {sheet} ");
    var rows = MiniExcel.Query(path,useHeaderRow:true,sheetName:sheet);
    Console.WriteLine(rows);
}
```

![image](https://user-images.githubusercontent.com/12729184/116199841-2a1f5300-a76a-11eb-90a3-6710561cf6db.png)

#### Q. 시트의 표시/숨김 정보를 쿼리하거나 내보내려면 어떻게 하나요?

A. `GetSheetInformations` 메서드를 사용하세요.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // 다음 시트 인덱스 - 0부터 시작
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // 시트 이름
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // 시트 표시 상태 - visible / hidden
}
```
```
```

#### Q. Count를 사용할 경우 모든 데이터가 메모리에 로드되나요?

아니요, 이미지 테스트는 1백만 행 * 10열의 데이터이며, 최대 메모리 사용량은 <60MB이고, 13.65초가 소요됩니다.

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### Q. Query에서 정수 인덱스를 어떻게 사용하나요?

Query의 기본 인덱스는 문자열 Key: A,B,C... 입니다. 숫자 인덱스로 변경하려면, 아래 메서드를 생성하여 변환하십시오.

```csharp
void Main()
{
    var path = @"D:\git\MiniExcel\samples\xlsx\TestTypeMapping.xlsx";
    var rows = MiniExcel.Query(path,true);
    foreach (var r in ConvertToIntIndexRows(rows))
    {
        Console.Write($"column 0 : {r[0]} ,column 1 : {r[1]}");
        Console.WriteLine();
    }
}

private IEnumerable<Dictionary<int, object>> ConvertToIntIndexRows(IEnumerable<object> rows)
{
    ICollection<string> keys = null;
    var isFirst = true;
    foreach (IDictionary<string,object> r in rows)
    {
        if(isFirst)
        {
            keys = r.Keys;
            isFirst = false;
        }

        var dic = new Dictionary<int, object>();
        var index = 0;
        foreach (var key in keys)
            dic[index++] = r[key];
        yield return dic;
    }
}
```

#### Q. Excel 내보내기 시 값이 비어 있을 때 제목 없는 빈 엑셀이 생성됩니다

MiniExcel은 API 사용을 단순화하기 위해 JSON.NET과 유사한 로직을 사용하여 값에서 동적으로 타입을 가져옵니다. 데이터가 없으면 타입을 알 수 없습니다. 자세한 내용은 [issue #133](https://github.com/mini-software/MiniExcel/issues/133)을 참고하세요.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Strong type & DataTable은 헤더를 생성하지만, Dictionary는 여전히 빈 엑셀을 생성합니다.

#### Q. 빈 행에서 foreach를 중단하려면?

MiniExcel은 `LINQ TakeWhile`과 함께 사용하여 foreach 반복자를 중단할 수 있습니다.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### Q. 빈 행을 제거하려면 어떻게 하나요?

![image](https://user-images.githubusercontent.com/12729184/137873865-7107d8f5-eb59-42db-903a-44e80589f1b2.png)

IEnumerable :

```csharp
public static IEnumerable<dynamic> QueryWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string,object> row in rows)
    {
        if(row.Keys.Any(key=>row[key]!=null))
            yield return row;
    }
}
```

DataTable :

```csharp
public static DataTable QueryAsDataTableWithoutEmptyRow(Stream stream, bool useHeaderRow, string sheetName, ExcelType excelType, string startCell, IConfiguration configuration)
{
    if (sheetName == null && excelType != ExcelType.CSV) /*Issue #279*/
        sheetName = stream.GetSheetNames().First();

    var dt = new DataTable(sheetName);
    var first = true;
    var rows = stream.Query(useHeaderRow,sheetName,excelType,startCell,configuration);
    foreach (IDictionary<string, object> row in rows)
    {
        if (first)
        {

            foreach (var key in row.Keys)
            {
                var column = new DataColumn(key, typeof(object)) { Caption = key };
```
```csharp
                dt.Columns.Add(column);
            }

            dt.BeginLoadData();
            first = false;
        }

        var newRow = dt.NewRow();
        var isNull=true;
        foreach (var key in row.Keys)
        {
            var _v = row[key];
            if(_v!=null)
                isNull = false;
            newRow[key] = _v;
        }

        if(!isNull)
            dt.Rows.Add(newRow);
    }

    dt.EndLoadData();
    return dt;
}
```



#### Q. SaveAs(path, value)로 기존 파일을 대체하고 "The file ...xlsx already exists error"를 발생시키지 않으려면 어떻게 해야 하나요?


Stream 클래스를 사용하여 사용자 지정 파일 생성 로직을 사용할 수 있습니다. 예시:

```c#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



또는, V1.25.0부터 SaveAs가 overwriteFile 매개변수를 지원하여 기존 파일 덮어쓰기를 활성화/비활성화할 수 있습니다.

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### 제한 사항 및 주의사항

- 현재 xls 및 암호화 파일은 지원하지 않습니다.
- xlsm은 Query만 지원합니다.



### 참고 자료

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### 감사

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

이 프로젝트를 위해 모든 제품 IDE를 무료로 제공해주셔서 감사합니다 ([라이선스](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### 기여 공유 및 후원
링크 https://github.com/orgs/mini-software/discussions/754

### 기여자

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---