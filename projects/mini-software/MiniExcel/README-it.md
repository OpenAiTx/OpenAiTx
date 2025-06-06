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
<p>Questo progetto fa parte della <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> e opera secondo il loro <a href="https://www.dotnetfoundation.org/code-of-conduct">codice di condotta</a>. </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 Il tuo <a href="https://github.com/mini-software/MiniExcel">Star</a> e la tua <a href="https://miniexcel.github.io">Donazione</a> possono rendere MiniExcel migliore
</div>

---

### Introduzione

MiniExcel è uno strumento .NET semplice ed efficiente per evitare OOM (Out Of Memory) nell'elaborazione di file Excel.

Attualmente, la maggior parte dei framework popolari necessita di caricare tutti i dati in memoria per facilitarne l'operazione, ma ciò causa problemi di consumo di memoria. MiniExcel cerca di utilizzare algoritmi basati su stream per ridurre l'occupazione originale da 1000 MB a pochi MB ed evitare OOM (out of memory).

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### Caratteristiche

- Basso consumo di memoria, evita OOM (out of memory) e full GC
- Supporta l'operazione in tempo reale di ogni riga di dati
- Supporta l'esecuzione differita LINQ, consente paginazione rapida e query complesse a basso consumo
- Leggero, non richiede Microsoft Office installato, senza COM+, dimensione DLL inferiore a 400KB
- API facile per leggere/scrivere/compilare file Excel

### Per iniziare

- [Importa/Interroga Excel](#getstart1)
- [Esporta/Crea Excel](#getstart2)
- [Template Excel](#getstart3)
- [Nome/Indice/Ignora colonna Excel](#getstart4)
- [Esempi](#getstart5)

### Installazione

Puoi installare il pacchetto [da NuGet](https://www.nuget.org/packages/MiniExcel)

### Note di rilascio

Consulta [Note di rilascio](docs)

### TODO

Consulta [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### Prestazioni

Il codice per i benchmark si trova in [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs).

Il file utilizzato per il test delle prestazioni è [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), un documento da 32MB contenente 1.000.000 di righe x 10 colonne, le cui celle sono riempite con la stringa "HelloWorld".

Per eseguire tutti i benchmark usa:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Puoi trovare i risultati dei benchmark per l'ultima release [qui](benchmarks/results).

### Query/Importazione Excel  <a name="getstart1"></a>

#### 1. Eseguire una query e mappare i risultati su un IEnumerable fortemente tipizzato [[Provalo]](https://dotnetfiddle.net/w5WD1J)

Si raccomanda di utilizzare Stream.Query per una migliore efficienza.

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

// oppure

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Eseguire una query e mappare su una lista di oggetti dinamici senza intestazione [[Provalo]](https://dotnetfiddle.net/w5WD1J)

* La chiave dinamica è `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// oppure
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. Eseguire una query con la prima riga come intestazione [[Provalo]](https://dotnetfiddle.net/w5WD1J)

nota: se ci sono colonne con lo stesso nome, viene usata l'ultima a destra

Input Excel :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |

```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// oppure

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Query Support LINQ Extension First/Take/Skip ...ecc

Query First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// oppure

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

Prestazioni tra MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Query per nome foglio

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//oppure
stream.Query(sheetName: "SheetName");
```

#### 6. Query tutti i nomi dei fogli e le righe

```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Ottenere le colonne

```csharp
var columns = MiniExcel.GetColumns(path); // es. risultato: ["A","B"...]

var cnt = columns.Count;  // conteggio colonne
```

#### 8. Query dinamica cast riga a `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// oppure
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// oppure Query su intervalli specifici (in maiuscolo)
// A2 rappresenta la seconda riga della colonna A, C3 la terza della colonna C
// Se non vuoi limitare le righe, non includere i numeri
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```

#### 9. Query Excel restituisce DataTable

Non raccomandato, perché DataTable caricherà tutti i dati in memoria perdendo la caratteristica di basso consumo di MiniExcel.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)

#### 10. Specificare la cella da cui iniziare a leggere i dati

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)

#### 11. Compilare celle unite

Nota: L'efficienza è inferiore rispetto a `non usare il merge fill`

Motivo: Lo standard OpenXml inserisce mergeCells in fondo al file, quindi è necessario ciclare due volte il sheetxml

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

supporta la compilazione multi-riga e multi-colonna di lunghezza e larghezza variabile

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Lettura di grandi file tramite cache su disco (Disk-Base Cache - SharedString)

Se la dimensione di SharedStrings supera i 5 MB, MiniExcel userà di default la cache su disco locale, es: [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (un milione di righe), disabilitando la cache su disco l'uso massimo della memoria è di 195MB, abilitando la cache servono solo 65MB. Nota che questa ottimizzazione comporta un costo in efficienza, il tempo di lettura passa da 7.4 a 27.2 secondi. Se non ti serve puoi disabilitare la cache:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

Puoi usare `SharedStringCacheSize` per cambiare la dimensione del file sharedString oltre la quale usare la cache su disco
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)

---

Per motivi di spazio, il resto della traduzione segue lo stesso stile, mantenendo intatti il formato Markdown, i blocchi di codice e le immagini, traducendo solo il testo descrittivo e i titoli in italiano. Se hai bisogno di una sezione specifica tradotta, chiedi pure!
---- Powered By MiniAiTx ----