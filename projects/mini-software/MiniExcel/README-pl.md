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
<p>Ten projekt jest częścią <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> i działa zgodnie z ich <a href="https://www.dotnetfoundation.org/code-of-conduct">kodeksem postępowania</a>. </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div style="text-align: center">
 Twoje <a href="https://github.com/mini-software/MiniExcel">gwiazdki</a> lub <a href="https://miniexcel.github.io">darowizny</a> mogą uczynić MiniExcel lepszym
</div>

---

### Wprowadzenie

MiniExcel to proste i wydajne narzędzie do obsługi plików Excel dla .NET, specjalnie zaprojektowane w celu minimalizacji użycia pamięci.

Obecnie większość popularnych frameworków musi załadować wszystkie dane z dokumentu Excel do pamięci, aby umożliwić operacje, jednak może to powodować problemy ze zużyciem pamięci. Podejście MiniExcel jest inne: dane są przetwarzane wiersz po wierszu w trybie strumieniowym, co redukuje pierwotne zużycie z potencjalnie setek megabajtów do zaledwie kilku megabajtów, skutecznie zapobiegając problemom z brakiem pamięci (OOM).

![Screenshot 2025-06-22 123525](https://github.com/user-attachments/assets/0b99a61e-8061-4604-8957-0b1f3ec74544)


### Funkcje

- Minimalizuje zużycie pamięci, zapobiegając błędom braku pamięci (OOM) i unikając pełnych kolekcji śmieci
- Umożliwia operacje na danych w czasie rzeczywistym, na poziomie wiersza, zapewniając lepszą wydajność przy dużych zbiorach danych
- Obsługuje LINQ z odroczonym wykonaniem, umożliwiając szybkie, wydajne pamięciowo stronicowanie i złożone zapytania
- Lekka, bez potrzeby instalowania Microsoft Office czy komponentów COM+, a rozmiar DLL poniżej 500KB
- Prosty i intuicyjny interfejs API do odczytu/zapisu/wypełniania plików excel

### Pierwsze kroki

- [Importowanie/Zapytania Excel](#getstart1)

- [Eksportowanie/Tworzenie Excel](#getstart2)

- [Szablon Excel](#getstart3)

- [Nazwa kolumny/Indeks/Atrybut ignorowania](#getstart4)

- [Przykłady](#getstart5)



### Instalacja

Możesz zainstalować pakiet [z NuGet](https://www.nuget.org/packages/MiniExcel)

### Informacje o wydaniu

Proszę sprawdzić [Informacje o wydaniu](docs)

### TODO

Proszę sprawdzić  [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### Wydajność

Kod dla benchmarków znajduje się w [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs).

Plik użyty do testowania wydajności to [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), dokument o rozmiarze 32MB zawierający 1 000 000 wierszy * 10 kolumn, których komórki są wypełnione ciągiem "HelloWorld".

Aby uruchomić wszystkie benchmarki, użyj:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Wyniki benchmarków dla najnowszego wydania znajdziesz [tutaj](benchmarks/results).


### Zapytania/Import Excel  <a name="getstart1"></a>

#### 1. Wykonaj zapytanie i zmapuj wyniki na silnie typizowaną kolekcję IEnumerable [[Wypróbuj]](https://dotnetfiddle.net/w5WD1J)

Zaleca się używanie Stream.Query ze względu na lepszą wydajność.

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

// lub

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Wykonaj zapytanie i zmapuj wynik na listę dynamicznych obiektów bez używania nagłówka [[Wypróbuj]](https://dotnetfiddle.net/w5WD1J)

* dynamiczny klucz to `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// lub
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. Wykonaj zapytanie z pierwszym wierszem jako nagłówkiem [[Wypróbuj]](https://dotnetfiddle.net/w5WD1J)

uwaga: w przypadku powtarzających się nazw kolumn używana jest ta najbardziej na prawo

Wejściowy plik Excel:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// lub

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Zapytania wspierają rozszerzenia LINQ First/Take/Skip ...itd.

Zapytanie First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// lub

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

Wydajność między MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Zapytanie po nazwie arkusza

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//lub
stream.Query(sheetName: "SheetName");
```

#### 6. Zapytanie o wszystkie nazwy arkuszy i wiersze
```
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Pobierz kolumny

```csharp
var columns = MiniExcel.GetColumns(path); // np. wynik : ["A","B"...]

var cnt = columns.Count;  // pobierz liczbę kolumn
```

#### 8. Dynamiczne zapytanie rzutujące wiersz na `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// lub
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// lub zapytanie o określone zakresy (wielkie litery)
// A2 oznacza drugi wiersz kolumny A, C3 oznacza trzeci wiersz kolumny C
// Jeśli nie chcesz ograniczać wierszy, po prostu nie podawaj liczb
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. Zapytanie Excel zwracające DataTable

Niezalecane, ponieważ DataTable załaduje wszystkie dane do pamięci i straci cechę niskiego zużycia pamięci MiniExcel.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. Określ komórkę, od której rozpocząć odczyt danych

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. Wypełnianie scalonych komórek

Uwaga: Wydajność jest niższa w porównaniu do `nieużywania wypełniania scalonych komórek`

Powód: Standard OpenXml umieszcza mergeCells na końcu pliku, co powoduje konieczność dwukrotnego przechodzenia po sheetxml

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

obsługa zmiennej długości i szerokości wielorzędowego i wielokolumnowego wypełniania

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Odczyt dużych plików przez pamięć podręczną na dysku (Disk-Base Cache - SharedString)

Jeśli rozmiar SharedStrings przekracza 5 MB, MiniExcel domyślnie użyje lokalnej pamięci podręcznej na dysku, np. [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (milion wierszy danych), gdy wyłączysz cache dyskowy maksymalne zużycie pamięci to 195MB, ale przy włączonej pamięci podręcznej dysku potrzeba tylko 65MB. Uwaga, ta optymalizacja wymaga pewnych kosztów wydajności, więc w tym przypadku czas odczytu wzrasta z 7,4 sekundy do 27,2 sekundy. Jeśli nie potrzebujesz tej funkcji, możesz ją wyłączyć poniższym kodem:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

Możesz użyć `SharedStringCacheSize`, aby zmienić rozmiar pliku sharedString, po przekroczeniu którego używana jest pamięć podręczna na dysku
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)

### Tworzenie/Eksportowanie Excela  <a name="getstart2"></a>

1. Musi być typem nieabstrakcyjnym z publicznym konstruktorem bezparametrowym.

2. MiniExcel obsługuje parametr IEnumerable Wykonanie Odroczone (Deferred Execution). Jeśli chcesz użyć jak najmniej pamięci, proszę nie wywoływać metod takich jak ToList

np.: ToList lub nie – użycie pamięci
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. Typ anonimowy lub silnie typowany [[Wypróbuj]](https://dotnetfiddle.net/w5WD1J)

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

Wynik utworzonego pliku:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `Zalecane`, pozwala uniknąć ładowania wszystkich danych do pamięci
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

Eksport DataReader do wielu arkuszy (zalecane przez Dapper ExecuteReader)

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

- `Nie zalecane`, ładuje wszystkie dane do pamięci

- DataTable używa Caption jako pierwszego wyboru nazwy kolumny, potem columname

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

####  5. Zapytanie Dapper

Dzięki @shaofing #552, proszę używać `CommandDefinition + CommandFlags.NoCache`

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Uwaga: QueryAsync wyrzuci wyjątek zamkniętego połączenia
    MiniExcel.SaveAs(path, rows);
```
}
```

Poniższy kod załaduje wszystkie dane do pamięci

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. SaveAs do MemoryStream  [[Wypróbuj]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //obsługuje FileStream, MemoryStream itd.
{
    stream.SaveAs(values);
}
```

np.: api eksportu excela

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


#### 7. Tworzenie wielu arkuszy

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


#### 8. Opcje TableStyles

Domyślny styl

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

Bez konfiguracji stylu

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. AutoFilter

Od wersji v0.19.0  `OpenXmlConfiguration.AutoFilter` może włączać/wyłączać AutoFilter, domyślna wartość to `true`, a sposób ustawienia AutoFilter:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. Tworzenie obrazu

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



#### 11. Eksport plików jako tablica bajtów

Od wersji 1.22.0, gdy typ wartości to `byte[]`, system domyślnie zapisze ścieżkę pliku w komórce, a podczas importu system może przekonwertować to na `byte[]`. Jeśli nie chcesz korzystać z tej funkcjonalności, możesz ustawić `OpenXmlConfiguration.EnableConvertByteArray` na `false`, co poprawi wydajność systemu.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

Od wersji 1.22.0, gdy typ wartości to `byte[]`, system domyślnie zapisze ścieżkę pliku w komórce, a podczas importu system może przekonwertować to na `byte[]`. Jeśli nie chcesz korzystać z tej funkcjonalności, możesz ustawić `OpenXmlConfiguration.EnableConvertByteArray` na `false`, co poprawi wydajność systemu.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Scalanie tych samych komórek w pionie

Ta funkcjonalność jest obsługiwana tylko w formacie `xlsx` i scala komórki w pionie pomiędzy znacznikami @merge oraz @endmerge.
Możesz użyć @mergelimit, aby ograniczyć zakres scalania komórek w pionie.

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

Zawartość pliku przed i po scaleniu:

Bez limitu scalania:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

Z limitem scalania:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. Pomijanie wartości null

Nowa jawna opcja do zapisywania pustych komórek dla wartości null:

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
     EnableWriteNullValueCell = true // Wartość domyślna.
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

Poprzednie zachowanie:
```
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // Domyślna wartość to true.
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

Działa dla wartości null i DBNull.

#### 14. Zamrażanie okienek
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // domyślnie 1
    FreezeColumnCount = 2   // domyślnie 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### Wypełnianie danych do szablonu Excela <a name="getstart3"></a>

- Deklaracja jest podobna do szablonu Vue `{{nazwa zmiennej}}`, lub renderowania kolekcji `{{nazwa kolekcji.nazwa pola}}`
- Renderowanie kolekcji obsługuje IEnumerable/DataTable/DapperRow

#### 1. Podstawowe wypełnienie

Szablon:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

Wynik:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

Kod:
```csharp
// 1. Przez POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. Przez Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. Wypełnianie danych IEnumerable

> Uwaga1: Jako podstawę do wypełniania listy użyj pierwszego IEnumerable tej samej kolumny

Szablon:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

Wynik:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

Kod:
```csharp
//1. Przez POCO
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

//2. Przez Dictionary
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



#### 3. Złożone wypełnianie danych

> Uwaga: Obsługa wielu arkuszy oraz używania tych samych zmiennych

Szablon:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

Wynik:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. Przez POCO
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

// 2. Przez Dictionary
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

#### 4. Wydajność wypełniania dużej ilości danych

> UWAGA: Użycie IEnumerable z odroczonym wykonaniem, a nie ToList, pozwala zminimalizować zużycie pamięci w MiniExcel

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. Automatyczne mapowanie typu wartości komórki

Szablon

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

Wynik

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Klasa

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

Kod

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



#### 6. Przykład :  Lista projektów Github

Szablon

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


Wynik

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

Kod

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

#### 7. Grupowe wypełnianie danych

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
##### 1. Z tagiem `@group` oraz z tagiem `@header`

Przed

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

Po

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. Z tagiem @group oraz bez tagu @header

Przed

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

Po

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. Bez tagu @group

Przed

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

Po

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. Instrukcje If/ElseIf/Else w komórce

Zasady:
1. Obsługuje DateTime, Double, Int z operatorami ==, !=, >, >=, <, <=.
2. Obsługuje String z operatorami ==, !=.
3. Każda instrukcja powinna być w nowej linii.
4. Pojedyncza spacja powinna być dodana przed i po operatorach.
5. Nie powinno być nowej linii wewnątrz instrukcji.
6. Komórka powinna być dokładnie w poniższym formacie.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

Przed

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

Po

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable jako parametr

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
#### 10. Formuły

##### 1. Przykład
Poprzedź swoją formułę znakiem `$` i użyj `$enumrowstart` oraz `$enumrowend`, aby oznaczyć odniesienia do początkowego i końcowego wiersza wyliczalnego:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

Po wygenerowaniu szablonu, prefiks `$` zostanie usunięty, a `$enumrowstart` i `$enumrowend` zostaną zastąpione numerami początkowego i końcowego wiersza wyliczalnego:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. Inne przykładowe formuły:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Suma         | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| Średnia alt. | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Rozstęp      | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. Inne

##### 1. Sprawdzanie klucza parametru szablonu

Od wersji V1.24.0 domyślnie pomijany jest brakujący klucz parametru szablonu i zastępowany pustym ciągiem. `IgnoreTemplateParameterMissing` pozwala kontrolować, czy wyjątek powinien być zgłaszany.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### Nazwa kolumny/Indeks/Atrybut Ignoruj w Excelu <a name="getstart4"></a>



#### 1. Określenie nazwy kolumny, indeksu kolumny, ignorowanie kolumny

Przykład Excela

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

Kod

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
[ExcelColumnIndex("I")] // system przekonwertuje "I" na indeks 8
public string Test4 { get; set; }
public string Test5 { get; } //brak set spowoduje pominięcie
public string Test6 { get; private set; } //niepubliczny set spowoduje pominięcie
[ExcelColumnIndex(3)] // zaczyna się od 0
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





#### 2. Własny format (ExcelFormatAttribute)

Od wersji V0.21.0 wspierane są klasy zawierające metodę `ToString(string content)` do formatowania

Klasa

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

Kod

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

Rezultat

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Zapytanie wspiera konwersję własnego formatu

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. Ustawianie szerokości kolumny (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. Mapowanie wielu nazw kolumn na tę samą właściwość.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

Od wersji 1.24.0 system wspiera System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

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

Od wersji V1.26.0 wiele atrybutów może być uproszczonych w następujący sposób:
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

Od wersji V1.26.0 możemy dynamicznie ustawiać atrybuty kolumn.
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

Od wersji V1.31.4 możemy dynamicznie ustawiać atrybuty arkusza. Możemy ustawić nazwę arkusza oraz stan (widoczność).
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

Możemy również użyć nowego atrybutu ExcelSheetAttribute:

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

### Dodawanie, Usuwanie, Aktualizacja

#### Dodawanie

Wersja v1.28.0 obsługuje wstawianie N wierszy do CSV po ostatnim wierszu

```csharp
// Oryginał
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Wstaw 1 wiersz po ostatnim
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Wstaw N wierszy po ostatnim
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

v1.37.0 obsługuje wstawianie nowego arkusza do istniejącego skoroszytu excel

```csharp
// Oryginalny excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Wstaw nowy arkusz
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### Usuwanie (oczekuje)

#### Aktualizacja (oczekuje)



### Automatyczne sprawdzanie typu Excela <a name="getstart5"></a>

- MiniExcel domyślnie sprawdzi czy to xlsx czy csv na podstawie `rozszerzenia pliku`, ale może się to okazać niedokładne, proszę określić to ręcznie.
- W przypadku strumienia nie można określić typu excela, proszę określić to ręcznie.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//lub
stream.SaveAs(excelType:ExcelType.XLSX);
//lub
stream.Query(excelType:ExcelType.CSV);
//lub
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### Uwaga

- Domyślnie zwracany jest typ `string`, a wartość nie będzie konwertowana na liczby ani datę/godzinę, chyba że typ jest określony przez silne typowanie generyczne.



#### Własny separator

Domyślnie separatorem jest `,`, możesz zmodyfikować właściwość `Seperator`, aby dostosować ją do własnych potrzeb

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

Od wersji V1.30.1 obsługuje funkcję własnego separatora (dzięki @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### Własny znak nowej linii

Domyślnie znakiem nowej linii jest `\r\n`, możesz zmodyfikować właściwość `NewLine`, aby dostosować ją do własnych potrzeb

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### Własne kodowanie
- Domyślne kodowanie to "Wykryj kodowanie z bajtowych znaczników porządku"  (detectEncodingFromByteOrderMarks: true)
- Jeśli masz niestandardowe wymagania dotyczące kodowania, zmodyfikuj właściwość StreamReaderFunc / StreamWriterFunc

```csharp
// Odczyt
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Zapis
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### Odczyt pustego ciągu jako null

Domyślnie puste wartości są mapowane na string.Empty. Możesz zmodyfikować to zachowanie

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
Od wersji 1.23.0 możesz użyć GetDataReader

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

- v0.17.0 obsługuje Async (dzięki isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  v1.25.0 obsługuje `cancellationToken`。



### Inne

#### 1. Enum

Upewnij się, że nazwa w excelu i nazwa właściwości są takie same, system automatycznie zmapuje (wielkość liter bez znaczenia)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

Od wersji V0.18.0 obsługa Enum Description

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("General User")]
    V1,
    [Description("General Administrator")]
    V2,
    [Description("Super Administrator")]
    V3
}
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

Od wersji 1.30.0 obsługiwany jest opis Excel do Enum, podziękowania dla @KaneLeung

#### 2. Konwersja CSV do XLSX lub konwersja XLSX do CSV

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

#### 3. Niestandardowa CultureInfo

Od wersji 1.22.0 możesz ustawić własną CultureInfo, jak poniżej, domyślnie system używa `CultureInfo.InvariantCulture`.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// lub
MiniExcel.Query(path, configuration: config);
```


#### 4. Niestandardowy rozmiar bufora
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

System nie będzie kontrolował pamięci, ale możesz uzyskać szybszą prędkość zapisu.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Seryjne dodawanie obrazów (MiniExcel.AddPicture)

Proszę dodawać obrazy przed seryjnym generowaniem danych wierszy, w przeciwnym razie system załaduje dużo pamięci podczas wywoływania AddPicture.

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // domyślnie null to pierwszy arkusz
        CellAddress = "C3", // wymagane
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // domyślnie PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // wymagane
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. Pobieranie rozmiaru arkuszy

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### Przykłady:

#### 1. SQLite & Dapper `Duży plik` SQL Insert bez OOM

uwaga: proszę nie wywoływać metod ToList/ToArray po Query, ponieważ załaduje to wszystkie dane do pamięci

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

wydajność:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 lub MVC 5 Pobieranie/Przesyłanie API Excel Xlsx Demo [Wypróbuj](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)

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
            // wykonaj swoją logikę itp.
        }

        return Ok("Plik został pomyślnie przesłany");
    }
}
```

####  3. Zapytanie stronicowane

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== Strona nr 1 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== Strona nr 50 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== Strona nr 5000 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. WebForm eksport do Excela przez MemoryStream

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



#### 5. Dynamiczne i18n wielojęzyczność i zarządzanie uprawnieniami ról

Jak w przykładzie, utwórz metodę do obsługi i18n oraz zarządzania uprawnieniami i użyj `yield return` do zwracania IEnumerable<Dictionary<string, object>> w celu uzyskania efektu dynamicznego oraz niskiego zużycia pamięci

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us i rola Sales");
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

#### P: Tytuł nagłówka w Excelu nie jest równy nazwie właściwości klasy, jak to mapować?

O. Proszę użyć atrybutu ExcelColumnName

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### P. Jak zapytanie lub eksportować arkusze wielokrotne?

O. Użyj metody `GetSheetNames` z parametrem  Query  sheetName.



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

#### P. Jak zapytanie lub eksportować informacje o widoczności arkusza?

O. Użyj metody `GetSheetInformations`.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // kolejny indeks arkusza - numerowany od 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // nazwa arkusza
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // stan widoczności arkusza - widoczny / ukryty
}
```
```


#### P. Czy użycie Count załaduje wszystkie dane do pamięci?

Nie, test obrazu ma 1 milion wierszy * 10 kolumn danych, maksymalne użycie pamięci to <60MB, a czas wykonania to 13,65 sekundy

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### P. Jak Query używa indeksów liczbowych?

Domyślny indeks Query to klucz tekstowy: A,B,C.... Jeśli chcesz zmienić na indeksy liczbowe, utwórz poniższą metodę konwertującą

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

#### P. Dlaczego generowany jest pusty plik Excel bez nagłówków, gdy eksportowane wartości są puste

Ponieważ MiniExcel używa logiki podobnej do JSON.NET, aby dynamicznie pobierać typ na podstawie wartości i uprościć operacje API, typ nie może być znany bez danych. Zobacz [issue #133](https://github.com/mini-software/MiniExcel/issues/133) aby dowiedzieć się więcej.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Silnie typowane & DataTable wygenerują nagłówki, ale Dictionary nadal wygeneruje pusty plik Excel

#### P. Jak zatrzymać foreach przy pustym wierszu?

MiniExcel można użyć z `LINQ TakeWhile`, aby zatrzymać iterację foreach.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### P. Jak usunąć puste wiersze?

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



#### P. Jak użyć SaveAs(path,value), aby zastąpić istniejący plik i uniknąć błędu "The file ...xlsx already exists error"


Proszę użyć klasy Stream do własnej logiki tworzenia pliku, np.:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



lub, od wersji V1.25.0, SaveAs obsługuje parametr overwriteFile umożliwiający włączenie/wyłączenie nadpisywania istniejącego pliku

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### Ograniczenia i uwagi

- Obecnie brak obsługi plików xls i zaszyfrowanych
- xlsm obsługuje tylko Query



### Odnośniki

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### Podziękowania

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

Dziękujemy za udostępnienie darmowej licencji All product IDE dla tego projektu ([Licencja](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### Wsparcie i darowizny
Link https://github.com/orgs/mini-software/discussions/754

### Współtwórcy

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---