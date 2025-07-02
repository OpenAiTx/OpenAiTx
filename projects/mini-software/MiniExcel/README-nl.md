<div align="center">
<p><a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/v/MiniExcel.svg" alt="NuGet"></a>  <a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/nuget/dt/MiniExcel.svg" alt=""></a>
<a href="https://ci.appveyor.com/project/mini-software/miniexcel/branch/master"><img src="https://ci.appveyor.com/api/projects/status/b2vustrwsuqx45f4/branch/master?svg=true" alt="Build status"></a>
<a href="https://gitee.com/dotnetchina/MiniExcel"><img src="https://gitee.com/dotnetchina/MiniExcel/badge/star.svg" alt="star"></a> <a href="https://github.com/mini-software/MiniExcel" rel="nofollow"><img src="https://img.shields.io/github/stars/mini-software/MiniExcel?logo=github" alt="GitHub stars"></a>
<a href="https://www.nuget.org/packages/MiniExcel"><img src="https://img.shields.io/badge/.NET-%3E%3D%204.5-red.svg" alt="version"></a>
<a href="https://deepwiki.com/mini-software/MiniExcel"><img src="https://deepwiki.com/badge.svg" alt="Ask DeepWiki"></a>
</p>
</div>

---

[<img align="right" src="https://github.com/dotnet-foundation/swag/blob/main/logo/dotnetfoundation_v4.png?raw=true" width="100" />](https://www.dotnetfoundation.org/)

<div align="center">
<p>Dit project maakt deel uit van de <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> en opereert onder hun <a href="https://www.dotnetfoundation.org/code-of-conduct">gedragscode</a>. </p>
</div>

---

<div align="center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ja">日本語</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ko">한국어</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=hi">हिन्दी</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=th">ไทย</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fr">Français</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=de">Deutsch</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=es">Español</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=it">Italiano</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ru">Русский</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pt">Português</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=nl">Nederlands</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=pl">Polski</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=ar">العربية</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=fa">فارسی</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=tr">Türkçe</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=vi">Tiếng Việt</a> | <a href="https://openaitx.github.io/view.html?user=mini-software&amp;project=MiniExcel&amp;lang=id">Bahasa Indonesia</a><p></p>
</strong></p>
</div>


---

<div align="center">
 Jouw <a href="https://github.com/mini-software/MiniExcel">Sterren</a> of <a href="https://miniexcel.github.io">Donaties</a> kunnen MiniExcel beter maken
</div>

---

### Introductie

MiniExcel is een eenvoudige en efficiënte Excel-verwerkingstool voor .NET, speciaal ontworpen om het geheugengebruik te minimaliseren.

Op dit moment moeten de meeste populaire frameworks alle gegevens uit een Excel-document in het geheugen laden om bewerkingen mogelijk te maken, maar dit kan problemen met geheugenverbruik veroorzaken. De aanpak van MiniExcel is anders: de gegevens worden rij voor rij verwerkt in een streaming-manier, waardoor het oorspronkelijke verbruik van mogelijk honderden megabytes wordt teruggebracht tot slechts enkele megabytes, wat effectief OOM-problemen (out-of-memory) voorkomt.

![Screenshot 2025-06-22 123525](https://github.com/user-attachments/assets/0b99a61e-8061-4604-8957-0b1f3ec74544)


### Kenmerken

- Minimaliseert geheugengebruik, voorkomt out-of-memory (OOM) fouten en vermijdt volledige garbage collections
- Maakt real-time, rij-niveau data-operaties mogelijk voor betere prestaties met grote datasets
- Ondersteunt LINQ met uitgestelde uitvoering, waardoor snelle, geheugen-efficiënte paging en complexe queries mogelijk zijn
- Lichtgewicht, zonder dat Microsoft Office of COM+ componenten nodig zijn, en een DLL-grootte onder de 500KB
- Eenvoudige en intuïtieve API-stijl om excel te lezen/schrijven/invullen

### Aan de slag

- [Importeer/Query Excel](#getstart1)

- [Exporteer/Creëer Excel](#getstart2)

- [Excel Sjabloon](#getstart3)

- [Excel Kolomnaam/Index/Ignore Attribuut](#getstart4)

- [Voorbeelden](#getstart5)



### Installatie

Je kunt het pakket [van NuGet installeren](https://www.nuget.org/packages/MiniExcel)

### Release-opmerkingen

Bekijk de [Release-opmerkingen](docs)

### TODO

Bekijk [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### Prestaties

De code voor de benchmarks is te vinden in [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs).

Het bestand dat wordt gebruikt om de prestaties te testen is [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), een document van 32MB met 1.000.000 rijen * 10 kolommen waarvan de cellen zijn gevuld met de string "HelloWorld".

Om alle benchmarks uit te voeren gebruik je:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Je kunt de benchmarkresultaten voor de laatste release [hier vinden](benchmarks/results).


### Excel Query/Importeren  <a name="getstart1"></a>

#### 1. Voer een query uit en koppel de resultaten aan een sterk getypeerde IEnumerable [[Probeer het]](https://dotnetfiddle.net/w5WD1J)

Aanbevolen om Stream.Query te gebruiken vanwege de betere efficiëntie.

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

var rijen = MiniExcel.Query<UserAccount>(pad);

// of

using (var stream = File.OpenRead(pad))
    var rijen = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Voer een query uit en koppel het aan een lijst van dynamische objecten zonder header te gebruiken [[Probeer het]](https://dotnetfiddle.net/w5WD1J)

* dynamische sleutel is `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rijen = MiniExcel.Query(pad).ToList();

// of
using (var stream = File.OpenRead(pad))
{
    var rijen = stream.Query().ToList();

    Assert.Equal("MiniExcel", rijen[0].A);
    Assert.Equal(1, rijen[0].B);
    Assert.Equal("Github", rijen[1].A);
    Assert.Equal(2, rijen[1].B);
}
```

#### 3. Voer een query uit met de eerste rij als header [[Probeer het]](https://dotnetfiddle.net/w5WD1J)

opmerking: bij dezelfde kolomnaam wordt de meest rechtse gebruikt

Invoer Excel :

| Kolom1    | Kolom2  |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rijen = MiniExcel.Query(useHeaderRow:true).ToList();

// of

using (var stream = File.OpenRead(pad))
{
    var rijen = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rijen[0].Column1);
    Assert.Equal(1, rijen[0].Column2);
    Assert.Equal("Github", rijen[1].Column1);
    Assert.Equal(2, rijen[1].Column2);
}
```

#### 4. Query ondersteunt LINQ-extensie First/Take/Skip ...etc

Query First
```csharp
var rij = MiniExcel.Query(pad).First();
Assert.Equal("HelloWorld", rij.A);

// of

using (var stream = File.OpenRead(pad))
{
    var rij = stream.Query().First();
    Assert.Equal("HelloWorld", rij.A);
}
```

Prestaties tussen MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Query op bladnaam

```csharp
MiniExcel.Query(pad, sheetName: "SheetName");
//of
stream.Query(sheetName: "SheetName");
```

#### 6. Query alle bladnamen en rijen
```
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Kolommen ophalen

```csharp
var columns = MiniExcel.GetColumns(path); // bijv. resultaat : ["A","B"...]

var cnt = columns.Count;  // aantal kolommen ophalen
```

#### 8. Dynamische Query converteert rij naar `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// of
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// of Query opgegeven bereiken (met hoofdletters)
// A2 vertegenwoordigt de tweede rij van kolom A, C3 vertegenwoordigt de derde rij van kolom C
// Als je de rijen niet wilt beperken, laat dan gewoon de cijfers weg
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. Query Excel retourneert DataTable

Niet aanbevolen, omdat DataTable alle data in het geheugen laadt en daarmee het lage geheugengebruik van MiniExcel verloren gaat.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. Specificeer de cel om te beginnen met het lezen van data

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. Samengevoegde cellen vullen

Let op: De efficiëntie is lager vergeleken met `geen merge fill gebruiken`

Reden: De OpenXml-standaard plaatst mergeCells onderaan het bestand, waardoor het nodig is om twee keer door de sheetxml te lopen

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

ondersteunt variabele lengte en breedte voor het vullen van meerdere rijen en kolommen

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Grote bestanden lezen via disk-gebaseerde cache (Disk-Base Cache - SharedString)

Als de SharedStrings-grootte groter is dan 5 MB, zal MiniExcel standaard lokale schijfcache gebruiken, bijv. [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx)(een miljoen rijen data), als de schijfcache is uitgeschakeld is het maximale geheugengebruik 195MB, maar met ingeschakelde schijfcache is slechts 65MB nodig. Let op, deze optimalisatie kost wat efficiëntie, dus in dit geval zal de leestijd stijgen van 7,4 seconden naar 27,2 seconden. Als je dit niet nodig hebt kun je de schijfcache uitschakelen met de volgende code:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

Je kunt `SharedStringCacheSize` gebruiken om de sharedString-bestandsgrootte te wijzigen waarna schijfcaching gebruikt wordt
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)
```
### Maak/Exporteer Excel  <a name="getstart2"></a>

1. Moet een niet-abstrakt type zijn met een publieke parameterloze constructor.

2. MiniExcel ondersteunt parameter IEnumerable Deferred Execution. Als je zo min mogelijk geheugen wilt gebruiken, roep dan geen methoden zoals ToList aan.

bijv.: ToList of geen geheugengebruik
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. Anoniem of sterk getypeerd [[Probeer het]](https://dotnetfiddle.net/w5WD1J)

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

Bestandsresultaat aanmaken:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `Aanbevolen`, hiermee kun je voorkomen dat alle data in het geheugen wordt geladen
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader exporteert meerdere sheets (aanbevolen via Dapper ExecuteReader)

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

- `Niet aanbevolen`, het zal alle data in het geheugen laden

- DataTable gebruikt eerst Caption als kolomnaam, daarna de kolomnaam

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

Dank aan @shaofing #552 , gebruik `CommandDefinition + CommandFlags.NoCache`

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Opmerking: QueryAsync zal een gesloten connectie-exceptie veroorzaken
    MiniExcel.SaveAs(path, rows);
}
```

Onderstaande code laadt alle data in het geheugen

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. SaveAs naar MemoryStream  [[Probeer het]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //ondersteunt FileStream, MemoryStream enz.
{
    stream.SaveAs(values);
}
```

bijv.: api voor exporteren van excel

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


#### 7. Meerdere tabbladen aanmaken

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


#### 8. TableStyles Opties

Standaard stijl

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

Zonder stijlconfiguratie

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. AutoFilter

Sinds v0.19.0 kan `OpenXmlConfiguration.AutoFilter` AutoFilter in- of uitschakelen, de standaardwaarde is `true`, en AutoFilter instellen kan als volgt:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. Afbeelding maken

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



#### 11. Byte Array Bestand Exporteren

Sinds versie 1.22.0, wanneer het waarde type `byte[]` is, slaat het systeem standaard het bestandspad op in de cel, en bij importeren kan het systeem dit omzetten naar `byte[]`. Als je dit niet wilt gebruiken, kun je `OpenXmlConfiguration.EnableConvertByteArray` op `false` zetten, dit kan de systeemefficiëntie verbeteren.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

Sinds versie 1.22.0, wanneer het waarde type `byte[]` is, slaat het systeem standaard het bestandspad op in de cel, en bij importeren kan het systeem dit omzetten naar `byte[]`. Als je dit niet wilt gebruiken, kun je `OpenXmlConfiguration.EnableConvertByteArray` op `false` zetten, dit kan de systeemefficiëntie verbeteren.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Dezelfde cellen verticaal samenvoegen

Deze functionaliteit wordt alleen ondersteund in het `xlsx`-formaat en voegt cellen verticaal samen tussen @merge- en @endmerge-tags.
Je kunt @mergelimit gebruiken om de grenzen van het samenvoegen van cellen verticaal te beperken.

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

Bestandsinhoud vóór en na samenvoegen:

Zonder merge limit:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

Met merge limit:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. Null-waarden overslaan

Nieuwe expliciete optie om lege cellen te schrijven voor null-waarden:

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
     EnableWriteNullValueCell = true // Standaardwaarde.
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

Eerder gedrag:
```
```csharp
/* ... */

OpenXmlConfiguration configuratie = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // Standaardwaarde is true.
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuratie);
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

Werkt voor null- en DBNull-waarden.

#### 14. Bevries Rijen/Kolommen (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuratie = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // standaard is 1
    FreezeColumnCount = 2   // standaard is 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuratie);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### Data Invullen in Excel Sjabloon <a name="getstart3"></a>

- De declaratie lijkt op een Vue-sjabloon `{{variabelenaam}}`, of het weergeven van collecties `{{collectienaam.veldnaam}}`
- Collectieweergave ondersteunt IEnumerable/DataTable/DapperRow

#### 1. Basis Invulling

Sjabloon:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

Resultaat:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

Code:
```csharp
// 1. Door POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. Door Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. IEnumerable Data Invulling

> Opmerking1: Gebruik de eerste IEnumerable met dezelfde kolom als basis voor het invullen van de lijst

Sjabloon:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

Resultaat:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

Code:
```csharp
//1. Door POCO
var value = new
{
    employees = new[] {
```
new {name="Jack",department="HR"},
new {name="Lisa",department="HR"},
new {name="John",department="HR"},
new {name="Mike",department="IT"},
new {name="Neo",department="IT"},
new {name="Loan",department="IT"}
}
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. Met Dictionary
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



#### 3. Complexe gegevensvulling

> Opmerking: Ondersteunt meerdere werkbladen en het gebruik van dezelfde variabele

Sjabloon:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

Resultaat:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. Met POCO
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

// 2. Met Dictionary
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

#### 4. Grote hoeveelheden data vullen: prestaties

> OPMERKING: Gebruik van IEnumerable uitgestelde uitvoering in plaats van ToList kan het maximale geheugengebruik besparen in MiniExcel

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. Celwaarde automatische type-mapping

Sjabloon

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

Resultaat

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Klasse

```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
```csharp
public decimal? @decimal { get; set; }
public double? @double { get; set; }
public DateTime? datetime { get; set; }
public bool? @bool { get; set; }
public Guid? Guid { get; set; }
}
```

Code

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

#### 6. Voorbeeld :  Lijst Github Projecten

Sjabloon

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)

Resultaat

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

Code

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

#### 7. Gegroepeerde Data Invullen

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
##### 1. Met `@group` tag en met `@header` tag

Voor

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

Na

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. Met @group tag en zonder @header tag

Voor

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

Na

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. Zonder @group tag

Voor

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

Na

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)
#### 8. If/ElseIf/Else-instructies in een cel

Regels:
1. Ondersteunt DateTime, Double, Int met de operatoren ==, !=, >, >=, <, <=.
2. Ondersteunt String met de operatoren ==, !=.
3. Elke instructie moet op een nieuwe regel staan.
4. Er moet een enkele spatie vóór en na de operatoren staan.
5. Er mag geen nieuwe regel binnen de instructies staan.
6. De cel moet exact hetzelfde formaat hebben als hieronder.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

Voor

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

Na

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable als parameter

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
#### 10. Formules

##### 1. Voorbeeld
Voeg een `$` toe aan het begin van je formule en gebruik `$enumrowstart` en `$enumrowend` om verwijzingen naar het begin- en eindrij van de enumerable aan te geven:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-1.png)

Wanneer de template wordt gerenderd, wordt het `$`-voorvoegsel verwijderd en worden `$enumrowstart` en `$enumrowend` vervangen door de begin- en eindrijnummers van de enumerable:

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/template-formulas-2.png)

##### 2. Andere Voorbeeldformules:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Som          | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| Alt. Gemiddelde | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Bereik       | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. Overig

##### 1. Controleren van template parameter key

Sinds V1.24.0 wordt standaard het ontbreken van een template parameter key genegeerd en vervangen door een lege string. `IgnoreTemplateParameterMissing` kan bepalen of er een uitzondering wordt gegooid of niet.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### Excel Kolomnaam/Index/Ignore Attribuut <a name="getstart4"></a>



#### 1. Specificeer de kolomnaam, kolomindex, kolom negeren

Excel Voorbeeld

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

Code

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
[ExcelColumnIndex("I")] // systeem zal "I" omzetten naar index 8
public string Test4 { get; set; }
public string Test5 { get; } //zonder set wordt genegeerd
public string Test6 { get; private set; } //niet-publieke set wordt genegeerd
[ExcelColumnIndex(3)] // begint bij 0
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





#### 2. Aangepast formaat (ExcelFormatAttribute)

Sinds V0.21.0 wordt klasse ondersteund die een `ToString(string content)` methode bevat voor formattering

Klasse

```csharp
public class Dto
{
    public string Name { get; set; }

    [ExcelFormat("MMMM dd, yyyy")]
    public DateTime InDate { get; set; }
}
```

Code

```csharp
var value = new Dto[] {
    new Issue241Dto{ Name="Jack",InDate=new DateTime(2021,01,04)},
    new Issue241Dto{ Name="Henry",InDate=new DateTime(2020,04,05)},
};
MiniExcel.SaveAs(path, value);
```

Resultaat

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Query ondersteunt aangepaste formaatconversie

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. Kolombreedte instellen (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. Meerdere kolomnamen toewijzen aan dezelfde property.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

Sinds 1.24.0 ondersteunt het systeem System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

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

Sinds V1.26.0 kunnen meerdere attributen als volgt worden vereenvoudigd:
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

Sinds V1.26.0 kunnen we de attributen van een kolom dynamisch instellen
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

Sinds V1.31.4 kunnen we de attributen van een sheet dynamisch instellen. We kunnen de naam van het werkblad en de status (zichtbaarheid) instellen.
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

We kunnen ook het nieuwe attribuut ExcelSheetAttribute gebruiken:

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

### Toevoegen, Verwijderen, Bijwerken

#### Toevoegen

v1.28.0 ondersteunt CSV invoegen van N rijen na de laatste rij

```csharp
// Oorspronkelijk
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Voeg 1 rij toe na de laatste
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Voeg N rijen toe na de laatste
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

v1.37.0 ondersteunt het invoegen van een nieuw werkblad in een bestaande werkmap

```csharp
// Originele excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Voeg een nieuw werkblad toe
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### Verwijderen (in afwachting)

#### Bijwerken (in afwachting)



### Excel Type Automatisch Controleren <a name="getstart5"></a>

- MiniExcel controleert standaard of het een xlsx of csv is op basis van de `bestandsextensie`, maar dit kan onnauwkeurig zijn, specificeer het daarom handmatig.
- Bij een stream kan niet worden vastgesteld van welk type excel het is, specificeer het daarom handmatig.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//of
stream.SaveAs(excelType:ExcelType.XLSX);
//of
stream.Query(excelType:ExcelType.CSV);
//of
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### Opmerking

- Geeft standaard een `string` type terug, en de waarde zal niet worden omgezet naar getallen of datum/tijd, tenzij het type is gedefinieerd door een sterk getypeerde generic.



#### Aangepaste scheidingsteken

Standaard is `,` het scheidingsteken, je kunt de eigenschap `Seperator` aanpassen voor personalisatie

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

Sinds V1.30.1 is er ondersteuning voor een functie om het scheidingsteken aan te passen (dank aan @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### Aangepaste regeleinde

Standaard is `\r\n` het nieuwe-regel karakter, je kunt de eigenschap `NewLine` aanpassen voor personalisatie

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### Aangepaste codering
- De standaardcodering is "Detect Encoding From Byte Order Marks" (detectEncodingFromByteOrderMarks: true)
- Als u aangepaste coderingsvereisten heeft, pas dan de eigenschap StreamReaderFunc / StreamWriterFunc aan

```csharp
// Lezen
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Schrijven
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### Leeg tekenreeks als null lezen

Standaard worden lege waarden gemapt naar string.Empty. U kunt dit gedrag aanpassen

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
Sinds 1.23.0 kunt u GetDataReader gebruiken

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

- v0.17.0 ondersteunt Async (met dank aan isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  v1.25.0 ondersteunt `cancellationToken`。



### Overige

#### 1. Enum

Zorg ervoor dat de excel- en eigenschapsnaam hetzelfde zijn, het systeem zal automatisch mappen (hoofdletterongevoelig)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

Sinds V0.18.0 wordt Enum Description ondersteund

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("Algemene gebruiker")]
    V1,
    [Description("Algemene beheerder")]
    V2,
    [Description("Superbeheerder")]
    V3
}
```
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

Sinds versie 1.30.0 wordt excel Description naar Enum ondersteund, dank aan @KaneLeung

#### 2. Converteer CSV naar XLSX of converteer XLSX naar CSV

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

#### 3. Aangepaste CultureInfo

Sinds 1.22.0 kun je een aangepaste CultureInfo instellen zoals hieronder, systeemstandaard is `CultureInfo.InvariantCulture`.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// of
MiniExcel.Query(path, configuration: config);
```


#### 4. Aangepaste Buffer Size
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

Het systeem beheert het geheugen niet, maar je kunt wel sneller opslaan.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Afbeeldingen in bulk toevoegen (MiniExcel.AddPicture)

Voeg afbeeldingen toe vóór het batch genereren van rijen met data, anders zal het systeem veel geheugen gebruiken bij het aanroepen van AddPicture.

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // standaard null is eerste sheet
        CellAddress = "C3", // verplicht
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // standaard PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // verplicht
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. Sheet-afmetingen ophalen

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### Voorbeelden:

#### 1. SQLite & Dapper `Groot Bestandsformaat` SQL Insert Voorkomt OOM

opmerking: roep na Query geen ToList/ToArray methoden aan, dit laadt alle data in het geheugen

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

prestaties:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 of MVC 5 Download/Upload Excel Xlsx API Demo [Probeer het](https://raw.githubusercontent.com/mini-software/MiniExcel/master/tests/MiniExcel.Tests.AspNetCore)

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
            // voer je logica uit etc.
        }

        return Ok("Bestand succesvol geüpload");
    }
}
```

####  3. Paginering Query

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== Nr.1 Pagina ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== Nr.50 Pagina ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== Nr.5000 Pagina ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. WebForm exporteer Excel via memorystream

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



#### 5. Dynamische i18n meertaligheid en rolbevoegdheidsbeheer

Zoals in het voorbeeld, maak een methode om i18n en machtigingenbeheer af te handelen en gebruik `yield return om IEnumerable<Dictionary<string, object>>` te retourneren voor dynamische en geheugenarme verwerkingseffecten

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us en Sales rol");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
```
```csharp
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN en PMC rol");
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

#### V: Excel-koptitel is niet gelijk aan de klasse-eigenschapsnaam, hoe te mappen?

A. Gebruik alstublieft het ExcelColumnName-attribuut

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### V. Hoe queryen of exporteren van meerdere sheets?

A. Gebruik de methode `GetSheetNames` met de  Query  parameter sheetName.



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

#### V. Hoe queryen of exporteren van informatie over sheet-zichtbaarheid?

A. Gebruik de methode `GetSheetInformations`.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // volgende sheet index - genummerd vanaf 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // sheetnaam
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // sheet zichtbaarheidstoestand - zichtbaar / verborgen
}
```
```


#### V. Zal het gebruik van Count alle data in het geheugen laden?

Nee, de afbeeldingstest heeft 1 miljoen rijen*10 kolommen aan data, het maximale geheugengebruik is <60MB, en het duurt 13,65 seconden

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### V. Hoe gebruikt Query gehele getal indexen?

De standaard index van Query is de string Key: A,B,C.... Als u wilt overschakelen naar een numerieke index, maak dan de volgende methode aan om te converteren

```csharp
void Main()
{
    var path = @"D:\git\MiniExcel\samples\xlsx\TestTypeMapping.xlsx";
    var rows = MiniExcel.Query(path,true);
    foreach (var r in ConvertToIntIndexRows(rows))
    {
        Console.Write($"kolom 0 : {r[0]} ,kolom 1 : {r[1]}");
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

#### V. Er wordt een lege Excel zonder titel gegenereerd wanneer de waarde leeg is bij het exporteren van Excel

Omdat MiniExcel een vergelijkbare logica als JSON.NET gebruikt om dynamisch het type uit waarden te halen om API-bewerkingen te vereenvoudigen, kan het type niet bekend zijn zonder data. Zie [issue #133](https://github.com/mini-software/MiniExcel/issues/133) voor meer informatie.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Sterk getypeerd & DataTable zal headers genereren, maar Dictionary blijft een lege Excel

#### V. Hoe stop je de foreach bij een lege rij?

MiniExcel kan worden gebruikt met `LINQ TakeWhile` om de foreach-iterator te stoppen.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### V. Hoe verwijder je lege rijen?

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



#### V. Hoe SaveAs(path,value) gebruiken om een bestaand bestand te vervangen zonder de foutmelding "The file ...xlsx already exists error"


Gebruik de Stream-klasse om aangepaste logica voor het aanmaken van bestanden te implementeren, bijvoorbeeld:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```



of, sinds V1.25.0, ondersteunt SaveAs de parameter overwriteFile om het overschrijven van een bestaand bestand mogelijk of onmogelijk te maken

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```




### Beperkingen en kanttekeningen

- Ondersteunt momenteel geen xls- en versleutelde bestanden
- xlsm ondersteunt alleen Query



### Referentie

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)



### Dankwoord

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

Dank voor het gratis ter beschikking stellen van een All product IDE voor dit project ([Licentie](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))



### Donatie voor bijdrage delen
Link https://github.com/orgs/mini-software/discussions/754

### Bijdragers

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---