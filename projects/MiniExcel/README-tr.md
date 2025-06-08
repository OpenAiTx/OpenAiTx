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
<p>Bu proje <a href="https://www.dotnetfoundation.org/">.NET Foundation</a>'ın bir parçasıdır ve onların <a href="https://www.dotnetfoundation.org/code-of-conduct">davranış kurallarına</a> tabidir.</p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 Sizin <a href="https://github.com/mini-software/MiniExcel">Yıldızınız</a> ve <a href="https://miniexcel.github.io">Bağışınız</a> MiniExcel'i daha iyi yapabilir
</div>

---

### Giriş

MiniExcel, OOM'dan (bellek taşması) kaçınmak için basit ve verimli bir .NET Excel işleme aracıdır.

Şu anda en popüler frameworkler, işlemleri kolaylaştırmak için tüm verileri belleğe yüklemeye ihtiyaç duyar, fakat bu durum bellek tüketimi sorunlarına yol açar. MiniExcel, algoritmayı bir akış (stream) üzerinden kullanarak orijinalde 1000 MB olan bellek kullanımını birkaç MB'a düşürmeye ve OOM'dan (bellek taşması) kaçınmaya çalışır.

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)




### Özellikler

- Düşük bellek tüketimi, OOM'dan (bellek taşması) ve tam GC'den kaçınır
- Her veri satırı üzerinde gerçek zamanlı işlem desteği
- LINQ ertelenmiş yürütme desteği, düşük tüketimli, hızlı sayfalama ve diğer karmaşık sorgulamaları yapabilir
- Hafif, Microsoft Office kurulumu gerektirmez, COM+ yok, DLL boyutu 400KB'den küçük
- Excel okuma/yazma/doldurma için kolay API stili

### Hızlı Başlangıç

- [Excel İçe Aktar/Sorgu](#getstart1)

- [Excel Dışa Aktar/Oluştur](#getstart2)

- [Excel Şablonu](#getstart3)

- [Excel Sütun Adı/İndeks/Yoksayma Özelliği](#getstart4)

- [Örnekler](#getstart5)



### Kurulum

Paketi [NuGet üzerinden](https://www.nuget.org/packages/MiniExcel) yükleyebilirsiniz

### Sürüm Notları

Lütfen [Sürüm Notları](docs) bölümüne bakın

### YAPILACAKLAR

Lütfen [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true) bölümüne bakın

### Performans

Kıyaslama kodlarına [MiniExcel.Benchmarks](benchmarks/MiniExcel.Benchmarks/Program.cs) üzerinden ulaşabilirsiniz.

Performans testlerinde kullanılan dosya [**Test1,000,000x10.xlsx**](benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), her bir hücresinde "HelloWorld" yazan, 1.000.000 satır * 10 sütundan oluşan 32MB'lık bir belgedir.

Tüm kıyaslamaları çalıştırmak için:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Son sürüme ait kıyaslama sonuçlarını [burada](benchmarks/results) bulabilirsiniz.


### Excel Sorgu/İçe Aktar  <a name="getstart1"></a>

#### 1. Sorgu çalıştır ve sonuçları güçlü türde bir IEnumerable'a eşle [[Deneyin]](https://dotnetfiddle.net/w5WD1J)

Daha iyi verimlilik için Stream.Query kullanılması önerilir.

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

// veya

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Başlık kullanmadan sorgu çalıştır ve sonucu dinamik nesne listesine eşle [[Deneyin]](https://dotnetfiddle.net/w5WD1J)

* dinamik anahtar `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// veya
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. İlk başlık satırıyla sorgu çalıştır [[Deneyin]](https://dotnetfiddle.net/w5WD1J)

not : aynı sütun adı için en sağdaki kullanılır

Excel Girişi :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// veya

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Sorguda LINQ Uzantı First/Take/Skip ...vs destekler

İlk Değeri Sorgula
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// veya

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

MiniExcel/ExcelDataReader/ClosedXML/EPPlus performans karşılaştırması
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Sayfa adına göre sorgu

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//veya
stream.Query(sheetName: "SheetName");
```

#### 6. Tüm sayfa adlarını ve satırları sorgula
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Sütunları Al

```csharp
var columns = MiniExcel.GetColumns(path); // örn. sonuç : ["A","B"...]

var cnt = columns.Count;  // sütun sayısını al
```

#### 8. Dinamik Sorgu satırı `IDictionary<string,object>`'e dönüştürme

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// veya
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// veya Belirtilen aralıkları sorgula (büyük harfli)
// A2, A sütununun ikinci satırını, C3 ise C sütununun üçüncü satırını temsil eder
// Sadece satırları kısıtlamak istemiyorsanız, sayıları dahil etmeyin
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. Excel Sorgulama ile DataTable Döndürme

Tavsiye edilmez, çünkü DataTable tüm veriyi belleğe yükler ve MiniExcel'in düşük bellek tüketimi özelliğini kaybettirir.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. Veriyi Okumaya Başlanacak Hücreyi Belirtme

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. Birleştirilmiş Hücreleri Doldur

Not: Verimlilik, `birleştirme doldurma kullanılmadığında` göre daha yavaştır.

Sebep: OpenXml standardı mergeCells'i dosyanın en altına koyar, bu da sheetxml'in iki kez foreach ile gezilmesi gerektiği anlamına gelir.

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

değişken uzunluk ve genişlikte çoklu satır ve sütun doldurma desteklenir

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Disk tabanlı önbellek ile büyük dosya okuma (Disk-Tabanlı Önbellek - SharedString)

SharedStrings boyutu 5 MB'ı aşarsa, MiniExcel varsayılan olarak yerel disk önbelleği kullanır, örn, [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (bir milyon satır veri), disk önbelleği devre dışı bırakıldığında maksimum bellek kullanımı 195MB'dır, ancak disk önbelleği etkinleştirildiğinde sadece 65MB gerekir. Dikkat, bu optimizasyonun bir miktar verimlilik maliyeti vardır, bu nedenle bu durumda okuma süresi 7.4 saniyeden 27.2 saniyeye çıkar. Eğer buna ihtiyacınız yoksa disk önbelleğini aşağıdaki kod ile devre dışı bırakabilirsiniz:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

`SharedStringCacheSize ` ile sharedString dosya boyutunu, disk önbellekleme için aşılması gereken boyutu değiştirebilirsiniz.
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)









### Excel Oluştur/İhracat Et  <a name="getstart2"></a>

1. Ortak parametresiz kurucuya sahip soyut olmayan bir tip olmalı.

2. MiniExcel, parametre olarak IEnumerable Ertelenmiş Yürütme'yi destekler. En az bellek kullanmak istiyorsanız, ToList gibi metodları çağırmayınız.

örn : ToList ile veya olmadan bellek kullanımı
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. Anonim veya güçlü tip [[Deneyin]](https://dotnetfiddle.net/w5WD1J)

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

Oluşturulan Dosya Sonucu :

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `Tavsiye edilir`, tüm veriyi belleğe yüklemekten kaçınır
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader ile birden fazla sayfa dışa aktarımı (Dapper ExecuteReader ile önerilir)

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

- `Tavsiye edilmez`, tüm veriyi belleğe yükler

- DataTable önce sütun adı için Caption'ı, sonra columname'i kullanır

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

####  5. Dapper Sorgusu

Teşekkürler @shaofing #552 , lütfen `CommandDefinition + CommandFlags.NoCache` kullanın

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Not: QueryAsync kapalı bağlantı hatası fırlatır
    MiniExcel.SaveAs(path, rows);
```
```
}

```

Aşağıdaki kod tüm verileri belleğe yükleyecektir

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. Bellek Akışına (MemoryStream) Kaydetme  [[Deneyin]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) // FileStream, MemoryStream vb. desteklenir.
{
    stream.SaveAs(values);
}
```

Örneğin : excel dışa aktarma api'si

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


#### 7. Çoklu Sayfa Oluşturma

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


#### 8. Tablo Stilleri Seçenekleri

Varsayılan stil

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

Stil yapılandırması olmadan

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. Otomatik Filtre (AutoFilter)

v0.19.0'dan itibaren `OpenXmlConfiguration.AutoFilter` ile Otomatik Filtre etkinleştirilebilir/devre dışı bırakılabilir, varsayılan değeri `true`'dur. Otomatik Filtre ayarlama şekli:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. Resim Oluşturma

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



#### 11. Bayt Dizisi Dosya Aktarımı

1.22.0'dan itibaren, değer tipi `byte[]` olduğunda sistem varsayılan olarak dosya yolunu hücrede kaydeder ve içe aktarımda sistem `byte[]`'ye dönüştürebilir. Bunu kullanmak istemiyorsanız, `OpenXmlConfiguration.EnableConvertByteArray`'i `false` olarak ayarlayabilirsiniz, bu sistem verimliliğini artırabilir.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

1.22.0'dan itibaren, değer tipi `byte[]` olduğunda sistem varsayılan olarak dosya yolunu hücrede kaydeder ve içe aktarımda sistem `byte[]`'ye dönüştürebilir. Bunu kullanmak istemiyorsanız, `OpenXmlConfiguration.EnableConvertByteArray`'i `false` olarak ayarlayabilirsiniz, bu sistem verimliliğini artırabilir.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Aynı Hücreleri Dikey Olarak Birleştirme

Bu işlev yalnızca `xlsx` formatında desteklenir ve @merge ile @endmerge etiketleri arasındaki hücreleri dikey olarak birleştirir.
@mergelimit kullanarak dikey birleştirme sınırlarını belirleyebilirsiniz.

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

Birleştirme öncesi ve sonrası dosya içeriği:

Birleştirme sınırı olmadan:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

Birleştirme sınırı ile:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. Boş Değerleri Atla

Boş değerler için boş hücre yazma konusunda yeni bir açık seçenek:

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
     EnableWriteNullValueCell = true // Varsayılan değer.
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

Önceki davranış:
```
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // Varsayılan değer true'dur.
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

Null ve DBNull değerler için çalışır.

#### 14. Pencere Dondurma (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // varsayılan değer 1
    FreezeColumnCount = 2   // varsayılan değer 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### Excel Şablonuna Veri Doldurma <a name="getstart3"></a>

- Bildirim, Vue şablonundaki `{{değişken adı}}` veya koleksiyon işleme `{{koleksiyon adı.alan adı}}` ile benzerdir
- Koleksiyon işleme IEnumerable/DataTable/DapperRow destekler

#### 1. Temel Doldurma

Şablon:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

Sonuç:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

Kod:
```csharp
// 1. POCO ile
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. Dictionary ile
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. IEnumerable Veri Doldurma

> Not1: Listenin doldurulmasında aynı sütundan ilk IEnumerable temel alınır

Şablon:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

Sonuç:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

Kod:
```csharp
//1. POCO ile
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

//2. Dictionary ile
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



#### 3. Karmaşık Veri Doldurma

> Not: Çoklu sayfa ve aynı değişkeni kullanma desteği vardır

Şablon:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

Sonuç:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. POCO ile
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

// 2. Dictionary ile
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

#### 4. Büyük Veri Doldurma Performansı

> NOT: MiniExcel'de maksimum bellek kullanımını azaltmak için IEnumerable ertelenmiş yürütme kullanın, ToList kullanmayın

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. Hücre değeri otomatik tip eşleme

Şablon

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

Sonuç

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Sınıf

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



#### 6. Örnek: Github Projeleri Listesi

Şablon

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


Sonuç

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

#### 7. Gruplandırılmış Veri Doldurma

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
##### 1. `@group` etiketiyle ve `@header` etiketiyle

Önce

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

Sonra

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. @group etiketiyle ve @header etiketi olmadan

Önce

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

Sonra

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. @group etiketi olmadan

Önce

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

Sonra

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. Hücre İçinde If/ElseIf/Else İfadeleri

Kurallar:
1. DateTime, Double, Int tiplerinde ==, !=, >, >=, <, <= operatörlerini destekler.
2. String tipinde ==, != operatörlerini destekler.
3. Her ifade yeni satırda olmalıdır.
4. Operatörlerin öncesinde ve sonrasında birer boşluk olmalıdır.
5. İfadelerin içinde yeni satır olmamalıdır.
6. Hücre aşağıdaki formatta olmalıdır.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

Önce

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

Sonra

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. Parametre Olarak DataTable

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
#### 10. Formüller

##### 1. Örnek
Formülünüzün başına `$` ekleyin ve sayılabilir veri başlangıç ve bitiş satır referansları için `$enumrowstart` ve `$enumrowend` kullanın:

![image](docs/images/template-formulas-1.png)

Şablon işlendiğinde, `$` ön eki kaldırılır ve `$enumrowstart` ile `$enumrowend` ilgili veri aralığı satır numaraları ile değiştirilir:

![image](docs/images/template-formulas-2.png)

##### 2. Diğer Örnek Formüller:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Toplam       | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| Alternatif Ortalama | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Aralık       | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. Diğer

##### 1. Şablon parametre anahtarını kontrol etme

V1.24.0 sürümünden itibaren, varsayılan olarak eksik şablon parametre anahtarları yok sayılır ve boş string ile değiştirilir. `IgnoreTemplateParameterMissing` ayarı ile istisna fırlatılıp fırlatılmayacağını kontrol edebilirsiniz.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### Excel Sütun Adı/İndeksi/Yok Sayma Özelliği <a name="getstart4"></a>



#### 1. Sütun adını, sütun indeksini, sütunu yok sayma

Excel Örneği

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

Kod

```csharp
public class ExcelAttributeDemo
{
    [ExcelColumnName("Column1")]
```
```csharp
public string Test1 { get; set; }
[ExcelColumnName("Column2")]
public string Test2 { get; set; }
[ExcelIgnore]
public string Test3 { get; set; }
[ExcelColumnIndex("I")] // sistem "I" harfini 8. indekse dönüştürecek
public string Test4 { get; set; }
public string Test5 { get; } // set olmadan ignore edilir
public string Test6 { get; private set; } // public olmayan set ignore edilir
[ExcelColumnIndex(3)] // 0'dan başlar
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





#### 2. Özel Format (ExcelFormatAttribute)

V0.21.0'dan itibaren, `ToString(string content)` metodunu içeren sınıflar için format desteği sağlanır

Sınıf

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

Sonuç

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Sorgu işlemi özel format dönüşümünü destekler

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. Sütun Genişliğini Ayarlama (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. Aynı özelliğe birden fazla sütun adı eşleştirme.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

1.24.0'dan itibaren, sistem System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute desteği sağlar

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

V1.26.0'dan itibaren, birden fazla özellik aşağıdaki gibi sadeleştirilebilir:
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

V1.26.0'dan itibaren, Sütun özellikleri dinamik olarak ayarlanabilir
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

V1.31.4'ten itibaren Sheet (Sayfa) özellikleri dinamik olarak ayarlanabilir. Sayfa adı ve durumu (görünürlük) ayarlanabilir.
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

Ayrıca yeni ExcelSheetAttribute özniteliği de kullanılabilir:

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

### Ekleme, Silme, Güncelleme

#### Ekleme

v1.28.0 ile birlikte CSV dosyasına son satırdan sonra N satır veri ekleme desteği

```csharp
// Orijinal
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Son satırdan sonra 1 satır ekle
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Son satırdan sonra N satır ekle
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

v1.37.0 mevcut bir çalışma kitabına yeni bir sayfa eklemeyi destekler

```csharp
// Orijinal excel
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Yeni bir sayfa ekle
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### Sil (bekleniyor)

#### Güncelle (bekleniyor)



### Excel Tipi Otomatik Kontrol <a name="getstart5"></a>

- MiniExcel varsayılan olarak `dosya uzantısına` göre xlsx veya csv olup olmadığını kontrol eder, ancak bu durumda yanlışlık olabilir, lütfen manuel olarak belirtin.
- Akıştan (Stream) hangi excel türü olduğu anlaşılamaz, lütfen manuel olarak belirtin.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//veya
stream.SaveAs(excelType:ExcelType.XLSX);
//veya
stream.Query(excelType:ExcelType.CSV);
//veya
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### Not

- Varsayılan olarak `string` tipinde döner ve değerler sayıya veya datetime'a dönüştürülmez, tip güçlü tip generic ile tanımlanmadıkça.



#### Özel ayraç

Varsayılan olarak `,` ayraçtır, özelleştirmek için `Seperator` özelliğini değiştirebilirsiniz

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

V1.30.1'den itibaren özel ayraç fonksiyonu destekleniyor (teşekkürler @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### Özel satır sonu

Varsayılan olarak `\r\n` yeni satır karakteridir, özelleştirmek için `NewLine` özelliğini değiştirebilirsiniz

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### Özel kodlama

- Varsayılan kodlama "Detect Encoding From Byte Order Marks"  (detectEncodingFromByteOrderMarks: true)
- Özel kodlama gereksiniminiz varsa, lütfen StreamReaderFunc / StreamWriterFunc  özelliğini değiştirin

```csharp
// Oku
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Yaz
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### Boş string'i null olarak oku

Varsayılan olarak, boş değerler string.Empty ile eşlenir. Bu davranışı değiştirebilirsiniz

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
1.23.0'dan itibaren GetDataReader kullanabilirsiniz

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

- v0.17.0 Async desteği (teşekkürler isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  v1.25.0 `cancellationToken` desteği.



### Diğerleri

#### 1. Enum

Excel ve özellik adının aynı olmasına dikkat edin, sistem otomatik olarak eşleyecektir (büyük/küçük harfe duyarsız)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

V0.18.0'dan itibaren Enum Description desteği

```csharp
public class Dto
{
    public string Name { get; set; }
    public I49RYZUserType UserType { get; set; }
}

public enum Type
{
    [Description("Genel Kullanıcı")]
    V1,
    [Description("Genel Yönetici")]
    V2,
    [Description("Süper Yönetici")]
    V3
}
```
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

1.30.0 sürümünden itibaren excel Description'dan Enum'a destek eklendi, teşekkürler @KaneLeung

#### 2. CSV'den XLSX'e veya XLSX'ten CSV'ye Dönüştürme

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

#### 3. Özel CultureInfo

1.22.0 sürümünden itibaren aşağıdaki gibi özel CultureInfo kullanabilirsiniz, sistem varsayılanı `CultureInfo.InvariantCulture`'dır.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// veya
MiniExcel.Query(path, configuration: config);
```


#### 4. Özel Buffer Boyutu
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

Sistem belleği kontrol etmez, fakat daha hızlı kayıt hızı elde edebilirsiniz.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Toplu Resim Ekleme (MiniExcel.AddPicture)

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // varsayılan null ilk sayfa
        CellAddress = "C3", // zorunlu
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // varsayılan PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // zorunlu
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. Sayfa Boyutlarını Al

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### Örnekler:

#### 1. SQLite & Dapper `Büyük Boyutlu Dosya` SQL Ekleme OOM'dan Kaçınma

not: Lütfen Query'den sonra ToList/ToArray metodlarını çağırmayın, tüm veriyi belleğe yükler

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

performans:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 veya MVC 5 Excel Xlsx API İndir/Yükle Demo [Deneyin](tests/MiniExcel.Tests.AspNetCore)

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
<p>Excel Yükle</p>
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
```
```csharp
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
            // kendi mantığınızı burada gerçekleştirin vb.
        }

        return Ok("Dosya başarıyla yüklendi");
    }
}
```

####  3. Sayfalama Sorgusu

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== 1. Sayfa ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== 50. Sayfa ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== 5000. Sayfa ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. WebForm ile hafızadan Excel dışa aktarma

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



#### 5. Dinamik i18n çoklu dil ve rol yetki yönetimi

Örnekteki gibi, i18n ve izin yönetimini işlemek için bir metot oluşturun ve dinamik ve düşük bellekli işleme etkisini elde etmek için `yield return` ile `IEnumerable<Dictionary<string, object>>` döndürün.

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us ve Satış rolü");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN ve PMC rolü");
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
            throw new InvalidDataException($"lang {lang} yanlış");
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



### SSS

#### S: Excel başlık adı, sınıf özelliği adı ile eşleşmiyorsa nasıl eşleştirme yapılır?

C: Lütfen ExcelColumnName özniteliğini kullanın.

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### S: Çoklu sayfa (multi-sheet) sorgulama veya dışa aktarma nasıl yapılır?

C: `GetSheetNames` yöntemi ile ve Query metodunun sheetName parametresi ile yapılabilir.



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

#### S: Sayfa görünürlüğü hakkında nasıl sorgulama veya dışa aktarma yapılır?

C: `GetSheetInformations` yöntemi ile yapılır.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // sonraki sayfanın index'i - 0'dan başlar
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // sayfa adı
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // sayfa görünürlük durumu - visible / hidden
}
```
#### S. Count kullanmak tüm veriyi belleğe yükler mi?

Hayır, görseldeki testte 1 milyon satır*10 sütun veri var, maksimum bellek kullanımı <60MB ve 13.65 saniye sürüyor.

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### S. Query tamsayı indekslerini nasıl kullanır?

Query'nin varsayılan indeksi string Anahtar: A,B,C... şeklindedir. Sayısal indeks kullanmak istiyorsanız, dönüştürmek için aşağıdaki metodu oluşturun.

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

#### S. Excel dışa aktarılırken değer boşsa başlıksız boş excel oluşuyor

MiniExcel, API işlemlerini basitleştirmek için JSON.NET'e benzer bir mantıkla tipini dinamik olarak veriden alır; veri olmadan tip bilinemez. Anlamak için [issue #133](https://github.com/mini-software/MiniExcel/issues/133)'e göz atabilirsiniz.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Strong type & DataTable başlık oluşturur, fakat Dictionary yine de boş Excel üretir.

#### S. Boş satırda foreach nasıl durdurulur?

MiniExcel, foreach iteratorünü durdurmak için `LINQ TakeWhile` ile birlikte kullanılabilir.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### S. Boş satırlar nasıl kaldırılır?

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

#### S. SaveAs(path,value) ile mevcut dosyanın üzerine yazıp "...xlsx already exists" hatası almamak için

Dosya oluşturma mantığını özelleştirmek için Stream sınıfını kullanabilirsiniz, örneğin:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```

veya, V1.25.0'dan itibaren, SaveAs fonksiyonunda overwriteFile parametresiyle mevcut dosyanın üzerine yazma desteği eklendi

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```

### Sınırlamalar ve dikkat edilmesi gerekenler

- Şu anda xls ve şifreli dosyalar desteklenmiyor
- xlsm sadece Query'yi destekler

### Referanslar

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)

### Teşekkürler

####  [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

Bu projeye ücretsiz All product IDE sağladığınız için teşekkürler ([Lisans](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))

### Katkı paylaşımı bağışı
Bağlantı https://github.com/orgs/mini-software/discussions/754

### Katkıda Bulunanlar

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---