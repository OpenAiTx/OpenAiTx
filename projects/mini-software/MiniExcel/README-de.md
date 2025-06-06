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
<p>Dieses Projekt ist Teil der <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> und unterliegt deren <a href="https://www.dotnetfoundation.org/code-of-conduct">Verhaltenskodex</a>.</p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 Ihr <a href="https://github.com/mini-software/MiniExcel">Star</a> und <a href="https://miniexcel.github.io">Spende</a> können MiniExcel verbessern
</div>

---

### Einführung

MiniExcel ist ein einfaches und effizientes .NET-Tool zur Verarbeitung von Excel-Dateien, das OOM (Out-Of-Memory) vermeidet.

Aktuell müssen die meisten populären Frameworks alle Daten in den Arbeitsspeicher laden, um Operationen zu erleichtern, was jedoch zu hohem Speicherverbrauch führt. MiniExcel versucht, Algorithmen auf Basis von Streams zu verwenden, um die ursprüngliche Belegung von 1000 MB auf wenige MB zu reduzieren und so OOM zu vermeiden.

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### Funktionen

- Geringer Speicherverbrauch, vermeidet OOM (Out-Of-Memory) und vollständigen GC
- Unterstützt Echtzeitoperationen pro Datenzeile
- Unterstützt LINQ-Deferred Execution, ermöglicht speichersparende, schnelle Paginierung und komplexe Abfragen
- Leichtgewichtig, ohne installiertes Microsoft Office, kein COM+, DLL-Größe weniger als 400KB
- Einfache API zum Lesen/Schreiben/Ausfüllen von Excel

### Einstieg

- [Import/Abfrage Excel](#getstart1)

- [Export/Erstellen von Excel](#getstart2)

- [Excel-Vorlage](#getstart3)

- [Excel Spaltenname/Index/Ignorieren-Attribut](#getstart4)

- [Beispiele](#getstart5)

### Installation

Sie können das Paket [von NuGet installieren](https://www.nuget.org/packages/MiniExcel)

### Versionshinweise

Bitte lesen Sie die [Versionshinweise](docs)

### TODO

Bitte schauen Sie unter [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### Leistung

Der Benchmark-Code befindet sich unter [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs).

Die für den Test verwendete Datei ist [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), ein 32MB-Dokument mit 1.000.000 Zeilen * 10 Spalten, gefüllt mit dem String "HelloWorld".

Um alle Benchmarks auszuführen:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Die Benchmark-Ergebnisse für das aktuelle Release finden Sie [hier](benchmarks/results).

### Excel Abfrage/Import  <a name="getstart1"></a>

#### 1. Abfrage ausführen und die Ergebnisse auf einen stark typisierten IEnumerable abbilden [[Ausprobieren]](https://dotnetfiddle.net/w5WD1J)

Empfohlen wird die Verwendung von Stream.Query wegen besserer Effizienz.

```csharp
public class UserAccount
{
    public Guid ID { get; set; }
    public string Name { get; set; }
    public DateTime BoD { get; set; }
    public int Age { get; set; }
    public bool VIP { get; set; }
    public decimal Points { get; set; }
}

var rows = MiniExcel.Query<UserAccount>(path);

// oder

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Abfrage ausführen und auf eine Liste dynamischer Objekte ohne Kopfzeile abbilden [[Ausprobieren]](https://dotnetfiddle.net/w5WD1J)

* dynamischer Schlüssel ist `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// oder
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. Abfrage ausführen mit erster Kopfzeile [[Ausprobieren]](https://dotnetfiddle.net/w5WD1J)

Hinweis: Bei gleichem Spaltennamen wird die zuletzt rechts stehende verwendet

Eingabe Excel:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// oder

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Abfrage unterstützt LINQ-Erweiterungen First/Take/Skip ...usw.

Abfrage First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// oder

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

Leistungsvergleich zwischen MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Abfrage nach Blattname

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//oder
stream.Query(sheetName: "SheetName");
```

#### 6. Alle Blattnamen und Zeilen abfragen

```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Spalten abrufen

```csharp
var columns = MiniExcel.GetColumns(path); // z.B. Ergebnis : ["A","B"...]

var cnt = columns.Count;  // Spaltenanzahl abrufen
```

#### 8. Dynamische Abfrage: Zeile in `IDictionary<string,object>` umwandeln

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// oder
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// oder Abfrage bestimmter Bereiche (Großbuchstaben)
// A2 steht für die zweite Zeile der Spalte A, C3 für die dritte Zeile der Spalte C
// Wenn Sie Zeilen nicht einschränken möchten, lassen Sie Zahlen weg
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```

#### 9. Excel-Abfrage gibt DataTable zurück

Nicht empfohlen, da DataTable alle Daten in den Speicher lädt und das Merkmal des geringen Speicherverbrauchs von MiniExcel verloren geht.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)

#### 10. Zelle zum Starten des Lesens angeben

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)

#### 11. Zusammengeführte Zellen ausfüllen

Hinweis: Die Effizienz ist langsamer als bei `Nicht-Merge-Fill`

Grund: Der OpenXml-Standard legt mergeCells am Ende der Datei ab, was dazu führt, dass das sheetxml zweimal durchlaufen werden muss

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

Unterstützt variable Länge und Breite bei mehrzeiligen und mehrspaltigen Füllungen

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Große Datei mit Festplattencache lesen (Disk-Base Cache - SharedString)

Wenn die SharedStrings-Größe 5 MB überschreitet, verwendet MiniExcel standardmäßig einen lokalen Festplattencache, z.B. [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (eine Million Zeilen Daten). Wenn der Festplattencache deaktiviert ist, beträgt die maximale Speichernutzung 195MB, mit Festplattencache nur 65MB. Diese Optimierung kostet etwas Effizienz – das Lesen verlängert sich von 7,4 auf 27,2 Sekunden. Wer es nicht benötigt, kann den Disk-Cache folgendermaßen deaktivieren:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

Mit `SharedStringCacheSize` kann die Dateigröße für das Caching angepasst werden:
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)

### Excel erstellen/exportieren  <a name="getstart2"></a>

1. Muss ein nicht-abstrakter Typ mit öffentlichem parameterlosem Konstruktor sein.

2. MiniExcel unterstützt IEnumerable Deferred Execution. Für minimalen Speicherverbrauch bitte keine Methoden wie ToList verwenden.

z.B.: ToList oder nicht – Speicherverbrauch
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)

#### 1. Anonym oder stark typisiert [[Ausprobieren]](https://dotnetfiddle.net/w5WD1J)

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

Erstelltes Datei-Ergebnis:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |

#### 3.  IDataReader
- `Empfohlen`, da kein vollständiges Laden aller Daten in den Speicher notwendig ist
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader-Export mehrerer Blätter (empfohlen durch Dapper ExecuteReader)

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

#### 4. DataTable

- `Nicht empfohlen`, lädt alle Daten in den Speicher
- DataTable verwendet Caption als Spaltenname, dann columname

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

Danke an @shaofing #552, bitte `CommandDefinition + CommandFlags.NoCache` verwenden

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Hinweis: QueryAsync wirft eine Close Connection-Exception
    MiniExcel.SaveAs(path, rows);
}
```

Folgender Code lädt alle Daten in den Speicher

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```

#### 6. SaveAs zu MemoryStream  [[Ausprobieren]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //unterstützt FileStream,MemoryStream usw.
{
    stream.SaveAs(values);
}
```

z.B.: API für den Excel-Export

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

#### 7. Mehrere Blätter erstellen

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

#### 8. TableStyles-Optionen

Standardstil

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

Ohne Stilkonfiguration

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)

#### 9. AutoFilter

Ab v0.19.0 kann `OpenXmlConfiguration.AutoFilter` AutoFilter ein-/ausschalten, Standardwert ist `true`:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```

#### 10. Bild erstellen

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

#### 11. Byte-Array-Datei-Export

Ab Version 1.22.0: Wenn der Wert vom Typ `byte[]` ist, wird standardmäßig der Dateipfad in der Zelle gespeichert, und beim Import kann er in `byte[]` konvertiert werden. Wenn Sie dies nicht möchten, können Sie `OpenXmlConfiguration.EnableConvertByteArray` auf `false` setzen, was die Effizienz verbessert.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Gleiche Zellen vertikal zusammenführen

Diese Funktion wird nur im `xlsx`-Format unterstützt und führt Zellen zwischen @merge- und @endmerge-Tags vertikal zusammen.
Sie können @mergelimit verwenden, um die Grenzen der zusammenzuführenden Zellen festzulegen.

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

Dateiinhalt vor und nach dem Zusammenführen:

Ohne Merge-Limit:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

Mit Merge-Limit:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. Nullwerte überspringen

Neue explizite Option, um leere Zellen für Nullwerte zu schreiben:

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
     EnableWriteNullValueCell = true // Standardwert.
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

Vorheriges Verhalten:

```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // Standardwert ist true.
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

Funktioniert für null und DBNull-Werte.

#### 14. Fenster fixieren (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // Standard ist 1
    FreezeColumnCount = 2   // Standard ist 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](docs/images/freeze-pane-1.png)

### Daten in Excel-Vorlage einfüllen <a name="getstart3"></a>

- Die Deklaration ist ähnlich wie bei Vue-Templates `{{Variablenname}}` oder für Kollektionen `{{Sammlungsname.Feldname}}`
- Kollektionen unterstützen IEnumerable/DataTable/DapperRow

#### 1. Einfaches Ausfüllen

Vorlage:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

Ergebnis:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

Code:
```csharp
// 1. Über POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

// 2. Über Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```

#### 2. IEnumerable-Daten ausfüllen

> Hinweis1: Die erste IEnumerable mit derselben Spalte ist die Grundlage für das Ausfüllen der Liste

Vorlage:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

Ergebnis:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

Code:
```csharp
//1. Über POCO
var value = new
{
    employees = new[] {
        new {name="Jack",department="HR"},
        new {name="Lisa",department="HR"},
        new {name="John",department="HR"},
        new {name="Mike",department="IT"},
        new {name="Neo",department="IT"},
        new {name="Loan",department="IT"}
    }
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);

//2. Über Dictionary
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

#### 3. Komplexes Daten-Ausfüllen

> Hinweis: Unterstützt mehrere Blätter und die Verwendung derselben Variablen

Vorlage:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

Ergebnis:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. Über POCO
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

// 2. Über Dictionary
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

#### 4. Leistung beim Ausfüllen großer Datenmengen

> HINWEIS: Durch Deferred Execution von IEnumerable (kein ToList) kann der maximale Speicherverbrauch in MiniExcel eingespart werden

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)

#### 5. Automatische Typzuordnung für Zellwerte

Vorlage

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

Ergebnis

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Klasse

```csharp
public class Poco
{
    public string @string { get; set; }
    public int? @int { get; set; }
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

#### 6. Beispiel: Liste von Github-Projekten

Vorlage

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)

Ergebnis

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

#### 7. Gruppierte Datenausfüllung

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
##### 1. Mit `@group` und `@header`-Tag

Vorher

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

Nachher

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. Mit @group-Tag und ohne @header-Tag

Vorher

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

Nachher

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. Ohne @group-Tag

Vorher

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

Nachher

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. If/ElseIf/Else-Anweisungen in Zellen

Regeln:
1. Unterstützt DateTime, Double, Int mit ==, !=, >, >=, <, <= Operatoren.
2. Unterstützt String mit ==, != Operatoren.
3. Jede Anweisung muss eine neue Zeile sein.
4. Vor und nach Operatoren muss ein Leerzeichen stehen.
5. Keine neue Zeile innerhalb der Anweisung.
6. Die Zelle muss exakt wie unten aussehen.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

Vorher

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

Nachher

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable als Parameter

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
#### 10. Formeln

##### 1. Beispiel
Präfixieren Sie Ihre Formel mit `$` und verwenden Sie `$enumrowstart` und `$enumrowend`, um Referenzen auf den Start- und Endzeilenbereich zu markieren:

![image](docs/images/template-formulas-1.png)

Beim Rendern der Vorlage wird das `$`-Präfix entfernt und `$enumrowstart` und `$enumrowend` werden durch die Start- und Endzeilennummer ersetzt:

![image](docs/images/template-formulas-2.png)

##### 2. Weitere Beispiel-Formeln:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Summe        | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| Alt. Mittel  | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Bereich      | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |

#### 11. Sonstiges

##### 1. Überprüfung des Template-Parameter-Schlüssels

Ab V1.24.0 wird standardmäßig ein fehlender Template-Parameter ignoriert und durch einen leeren String ersetzt, `IgnoreTemplateParameterMissing` kann steuern, ob eine Ausnahme geworfen wird.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)

### Excel Spaltenname/Index/Ignorieren-Attribut <a name="getstart4"></a>

#### 1. Spaltenname, Spaltenindex, Spalte ignorieren angeben

Excel-Beispiel

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

Code

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
    public string Test1 { get; set; }
    [ExcelColumnName("Column2")]
    public string Test2 { get; set; }
    [ExcelIgnore]
    public string Test3 { get; set; }
    [ExcelColumnIndex("I")] // system wandelt "I" in Index 8 um
    public string Test4 { get; set; }
    public string Test5 { get; } //ohne set wird ignoriert
    public string Test6 { get; private set; } //nicht-öffentlicher set wird ignoriert
    [ExcelColumnIndex(3)] // beginnt bei 0
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

#### 2. Benutzerdefiniertes Format (ExcelFormatAttribute)

Ab V0.21.0 unterstützt Klasse mit `ToString(string content)`-Format

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

Ergebnis

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Abfrage unterstützt benutzerdefinierte Formatumwandlung

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. Spaltenbreite setzen (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. Mehrere Spaltennamen auf dieselbe Eigenschaft abbilden.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```

#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

Ab 1.24.0 unterstützt das System System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

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

#### 6. ExcelColumnAttribute

Seit V1.26.0 können mehrere Attribute wie folgt vereinfacht werden:
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

Ab V1.26.0 können die Attribute der Spalten dynamisch gesetzt werden
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

Ab V1.31.4 können die Attribute des Blattes dynamisch gesetzt werden. Es können Blattname und Status (Sichtbarkeit) gesetzt werden.
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

Man kann auch das neue Attribut ExcelSheetAttribute verwenden:

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

### Hinzufügen, Löschen, Aktualisieren

#### Hinzufügen

Ab v1.28.0 unterstützt CSV das Einfügen von N Zeilen nach der letzten Zeile

```csharp
// Ursprünglich
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// 1 Zeile nach der letzten einfügen
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// N Zeilen nach der letzten einfügen
{
    var value = new[] {
          new { ID=4,Name ="Frank",InDate=new DateTime(2021,06,07)},
          new { ID=5,Name ="Gloria",InDate=new DateTime(2022,05,03)},
    };
    MiniExcel.Insert(path, value);
}
```

![image](https://user-images.githubusercontent.com/12729184/191023733-1e2fa732-db5c-4a3a-9722-b891fe5aa069.png)

Ab v1.37.0 unterstützt Excel das Einfügen eines neuen Blattes in eine bestehende Arbeitsmappe

```csharp
// Ursprüngliche Excel-Datei
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Neues Blatt einfügen
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```

#### Löschen (wartend)

#### Aktualisieren (wartend)

### Excel-Typ-Autoprüfung <a name="getstart5"></a>

- MiniExcel prüft standardmäßig anhand der Dateierweiterung, ob es sich um xlsx oder csv handelt, dies kann jedoch ungenau sein, bitte manuell angeben.
- Beim Stream kann der Excel-Typ nicht erkannt werden, bitte manuell angeben.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//oder
stream.SaveAs(excelType:ExcelType.XLSX);
//oder
stream.Query(excelType:ExcelType.CSV);
//oder
stream.Query(excelType:ExcelType.XLSX);
```

### CSV

#### Hinweis

- Standardmäßig wird der Typ `string` zurückgegeben, und Werte werden nicht in Zahlen oder Datum/Uhrzeit konvertiert, es sei denn, der Typ ist durch starke Typisierung festgelegt.

#### Benutzerdefiniertes Trennzeichen

Standardmäßig ist `,` das Trennzeichen, Sie können die `Seperator`-Eigenschaft anpassen

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

Ab V1.30.1 wird eine Funktion zur benutzerdefinierten Trennung unterstützt (danke @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```

#### Benutzerdefinierter Zeilenumbruch

Standardmäßig ist `\r\n` das Zeilenumbruchzeichen, Sie können die `NewLine`-Eigenschaft anpassen

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

#### Benutzerdefinierte Codierung

- Standardcodierung ist "Detect Encoding From Byte Order Marks"  (detectEncodingFromByteOrderMarks: true)
- Bei eigenen Codierungsanforderungen bitte StreamReaderFunc / StreamWriterFunc anpassen

```csharp
// Lesen
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Schreiben
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### Leere Zeichenfolge als Null lesen

Standardmäßig werden leere Werte als string.Empty abgebildet. Sie können dieses Verhalten ändern

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```

### DataReader

#### 1. GetReader
Ab Version 1.23.0 kann man GetDataReader verwenden

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

- Ab v0.17.0 wird Async unterstützt (danke an isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  Ab v1.25.0 wird `cancellationToken` unterstützt.

### Sonstiges

#### 1. Enum

Excel- & Property-Namen müssen gleich sein, dann erfolgt die automatische Zuordnung (Groß-/Kleinschreibung wird ignoriert)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

Ab V0.18.0 wird Enum Description unterstützt

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

Ab Version 1.30.0 wird Excel Description zu Enum unterstützt, danke @KaneLeung

#### 2. CSV zu XLSX oder XLSX zu CSV konvertieren

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

#### 3. Benutzerdefiniertes CultureInfo

Ab Version 1.22.0 kann benutzerdefiniertes CultureInfo wie folgt verwendet werden, Standard ist `CultureInfo.InvariantCulture`.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// oder
MiniExcel.Query(path, configuration: config);
```

#### 4. Benutzerdefinierte Buffergröße
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

Das System kontrolliert den Speicher nicht, aber Sie können schneller speichern.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Mehrfachbild-Einfügung (MiniExcel.AddPicture)

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // Standard null ist erstes Blatt
        CellAddress = "C3", // erforderlich
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // Standard PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // erforderlich
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. Blattdimensionen abrufen

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### Beispiele:

#### 1. SQLite & Dapper `Große Datei` SQL-Insert ohne OOM

Hinweis: Bitte nach Query keine ToList/ToArray Methoden aufrufen, da sonst alle Daten in den Speicher geladen werden

```csharp
using (var connection = new SQLiteConnection(connectionString))
{
    connection.Open();
    using (var transaction = connection.BeginTransaction())
    using (var stream = File.OpenRead(path))
    {
       var rows = stream.Query();
       foreach (var row in rows)
             connection.Execute("insert into T (A,B) values (@A,@B)", new { row.A, row.B }, transaction: transaction);
       transaction.Commit();
    }
}
```

Leistung:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)

#### 2. ASP.NET Core 3.1 oder MVC 5 Download/Upload Excel Xlsx API Demo [Ausprobieren](tests/MiniExcel.Tests.AspNetCore)

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
            // eigene Logik etc.
        }

        return Ok("Datei erfolgreich hochgeladen");
    }
}
```

####  3. Paging-Abfrage

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== Nr.1 Seite ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== Nr.50 Seite ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== Nr.5000 Seite ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)

#### 4. WebForm-Export von Excel per Memorystream

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

#### 5. Dynamisches i18n-Mehrsprachigkeit und Rollenberechtigungsverwaltung

Wie im Beispiel, erstellen Sie eine Methode zur Behandlung von i18n und Berechtigungen und verwenden Sie `yield return` für IEnumerable<Dictionary<string, object>> für eine dynamische und speicherschonende Verarbeitung

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us und Sales-Rolle");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN und PMC-Rolle");
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

#### F: Excel-Überschrift stimmt nicht mit Klassen-Property-Namen überein – wie mappen?

A. Bitte verwenden Sie das ExcelColumnName-Attribut

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### F. Wie mehrere Blätter abfragen oder exportieren?

A. Methode `GetSheetNames` in Verbindung mit dem sheetName-Parameter bei Query.

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

#### F. Wie Abfrage oder Export von Informationen zur Sichtbarkeit von Blättern?

A. Methode `GetSheetInformations`.

```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // nächster Blattindex - beginnt bei 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // Blattname
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // Sichtbarkeitsstatus - sichtbar / ausgeblendet
}
```

#### F. Führt Count dazu, dass alle Daten in den Speicher geladen werden?

Nein, der Bildtest enthält 1 Million Zeilen*10 Spalten Daten, maximale Speichernutzung <60MB, und dauert 13,65 Sekunden

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### F. Wie kann Query mit Integer-Indexen verwendet werden?

Standardmäßig ist der Index von Query der String-Key: A,B,C.... Möchten Sie auf numerischen Index umstellen, erstellen Sie folgende Methode zur Umwandlung

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

#### F. Beim Export leeres Excel ohne Titel, wenn Wert leer ist

Da MiniExcel eine Logik ähnlich wie JSON.NET verwendet, um Typen dynamisch aus Werten zu ermitteln, wird bei fehlenden Daten kein Typ erkannt. Siehe [issue #133](https://github.com/mini-software/MiniExcel/issues/133).

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Starker Typ & DataTable erzeugen Header, Dictionary jedoch bleibt Excel leer

#### F. Wie foreach bei Leerzeile stoppen?

MiniExcel kann mit `LINQ TakeWhile` verwendet werden, um den foreach-Iterator zu stoppen.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### F. Wie leere Zeilen entfernen?

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

#### F. Wie SaveAs(path,value) vorhandene Datei ersetzen ohne "The file ...xlsx already exists error"

Bitte verwenden Sie die Stream-Klasse für eigene Dateierstellungslogik, z.B.:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```

Oder ab V1.25.0 unterstützt SaveAs den Parameter overwriteFile zum Überschreiben bestehender Dateien

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```

### Einschränkungen und Hinweise

- xls und verschlüsselte Dateien werden derzeit nicht unterstützt
- xlsm unterstützt nur Query

### Referenzen

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)

### Dank

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

Vielen Dank für die kostenlose All Product IDE für dieses Projekt ([Lizenz](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))

### Beitragsteilung Spenden
Link https://github.com/orgs/mini-software/discussions/754

### Mitwirkende

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)
---- Powered By MiniAiTx ----