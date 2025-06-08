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
<p>Dự án này là một phần của <a href="https://www.dotnetfoundation.org/">.NET Foundation</a> và tuân theo <a href="https://www.dotnetfoundation.org/code-of-conduct">quy tắc ứng xử</a> của họ. </p>
</div>

---

<div style="text-align: center">
<p><strong><a href="README.md">English</a> | <a href="README.zh-CN.md">简体中文</a> | <a href="README.zh-Hant.md">繁體中文</a></strong></p>
</div>

---

<div style="text-align: center">
 Ngôi sao <a href="https://github.com/mini-software/MiniExcel">Star</a> và <a href="https://miniexcel.github.io">ủng hộ Donate</a> của bạn sẽ giúp MiniExcel phát triển tốt hơn
</div>

---

### Giới thiệu

MiniExcel là công cụ xử lý Excel trên .NET đơn giản và hiệu quả giúp tránh OOM.

Hiện nay, hầu hết các framework phổ biến đều cần tải toàn bộ dữ liệu vào bộ nhớ để dễ thao tác, điều này dẫn đến vấn đề tiêu tốn bộ nhớ. MiniExcel cố gắng sử dụng thuật toán từ luồng (stream) để giảm mức chiếm dụng từ 1000 MB xuống chỉ còn vài MB, tránh hiện tượng OOM (hết bộ nhớ).

![image](https://user-images.githubusercontent.com/12729184/113086657-ab8bd000-9214-11eb-9563-c970ac1ee35e.png)

### Tính năng

- Tiêu thụ bộ nhớ thấp, tránh OOM (hết bộ nhớ) và full GC
- Hỗ trợ xử lý dữ liệu từng dòng theo thời gian thực
- Hỗ trợ thực thi LINQ deferred, cho phép truy vấn phức tạp, phân trang nhanh với mức tiêu thụ thấp
- Nhẹ, không cần cài đặt Microsoft Office, không COM+, DLL có kích thước nhỏ hơn 400KB
- API dễ sử dụng để đọc/ghi/điền dữ liệu excel

### Bắt đầu

- [Nhập/Truy vấn Excel](#getstart1)

- [Xuất/Tạo Excel](#getstart2)

- [Mẫu Excel Template](#getstart3)

- [Tên/Cột/Chỉ số/Cột bị bỏ qua](#getstart4)

- [Ví dụ](#getstart5)

### Cài đặt

Bạn có thể cài đặt package [từ NuGet](https://www.nuget.org/packages/MiniExcel)

### Ghi chú phát hành

Vui lòng xem [Ghi chú phát hành](docs)

### Công việc cần làm

Vui lòng xem [TODO](https://github.com/mini-software/MiniExcel/projects/1?fullscreen=true)

### Hiệu năng

Mã nguồn cho các benchmark có thể được tìm thấy tại [MiniExcel.Benchmarks](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Program.cs).

File dùng để kiểm tra hiệu năng là [**Test1,000,000x10.xlsx**](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/MiniExcel.Benchmarks/Test1%2C000%2C000x10.xlsx), một tài liệu 32MB chứa 1.000.000 dòng * 10 cột, các ô đều có giá trị "HelloWorld".

Để chạy tất cả các benchmark, sử dụng:

```bash
dotnet run -project .\benchmarks\MiniExcel.Benchmarks -c Release -f net9.0 -filter * --join
```

Bạn có thể tìm kết quả benchmark cho bản phát hành mới nhất [tại đây](https://raw.githubusercontent.com/mini-software/MiniExcel/master/benchmarks/results).

### Truy vấn/Nhập Excel  <a name="getstart1"></a>

#### 1. Thực thi truy vấn và ánh xạ kết quả vào IEnumerable kiểu mạnh [[Thử ngay]](https://dotnetfiddle.net/w5WD1J)

Khuyến nghị sử dụng Stream.Query để đạt hiệu quả tốt hơn.

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

// hoặc

using (var stream = File.OpenRead(path))
    var rows = stream.Query<UserAccount>();
```

![image](https://user-images.githubusercontent.com/12729184/111107423-c8c46b80-8591-11eb-982f-c97a2dafb379.png)

#### 2. Thực thi truy vấn và ánh xạ vào danh sách đối tượng động không cần dùng dòng đầu làm tiêu đề [[Thử ngay]](https://dotnetfiddle.net/w5WD1J)

* Khóa dynamic là `A.B.C.D..`

| MiniExcel | 1 |
|-----------|---|
| Github    | 2 |

```csharp

var rows = MiniExcel.Query(path).ToList();

// hoặc
using (var stream = File.OpenRead(path))
{
    var rows = stream.Query().ToList();

    Assert.Equal("MiniExcel", rows[0].A);
    Assert.Equal(1, rows[0].B);
    Assert.Equal("Github", rows[1].A);
    Assert.Equal(2, rows[1].B);
}
```

#### 3. Thực thi truy vấn với dòng đầu tiên là tiêu đề [[Thử ngay]](https://dotnetfiddle.net/w5WD1J)

Lưu ý: Nếu trùng tên cột sẽ dùng cột bên phải cuối cùng

Excel đầu vào:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


```csharp

var rows = MiniExcel.Query(useHeaderRow:true).ToList();

// hoặc

using (var stream = File.OpenRead(path))
{
    var rows = stream.Query(useHeaderRow:true).ToList();

    Assert.Equal("MiniExcel", rows[0].Column1);
    Assert.Equal(1, rows[0].Column2);
    Assert.Equal("Github", rows[1].Column1);
    Assert.Equal(2, rows[1].Column2);
}
```

#### 4. Truy vấn hỗ trợ LINQ Extension First/Take/Skip ...v.v.

Truy vấn First
```csharp
var row = MiniExcel.Query(path).First();
Assert.Equal("HelloWorld", row.A);

// hoặc

using (var stream = File.OpenRead(path))
{
    var row = stream.Query().First();
    Assert.Equal("HelloWorld", row.A);
}
```

Hiệu năng giữa MiniExcel/ExcelDataReader/ClosedXML/EPPlus
![queryfirst](https://user-images.githubusercontent.com/12729184/111072392-6037a900-8515-11eb-9693-5ce2dad1e460.gif)

#### 5. Truy vấn theo tên sheet

```csharp
MiniExcel.Query(path, sheetName: "SheetName");
//hoặc
stream.Query(sheetName: "SheetName");
```

#### 6. Truy vấn tất cả tên sheet và dòng dữ liệu
```csharp
var sheetNames = MiniExcel.GetSheetNames(path);
foreach (var sheetName in sheetNames)
{
    var rows = MiniExcel.Query(path, sheetName: sheetName);
}
```

#### 7. Lấy Các Cột

```csharp
var columns = MiniExcel.GetColumns(path); // ví dụ kết quả: ["A","B"...]

var cnt = columns.Count;  // lấy số lượng cột
```

#### 8. Dynamic Query ép kiểu dòng sang `IDictionary<string,object>`

```csharp
foreach(IDictionary<string,object> row in MiniExcel.Query(path))
{
    //..
}

// hoặc
var rows = MiniExcel.Query(path).Cast<IDictionary<string,object>>();
// hoặc truy vấn phạm vi chỉ định (viết hoa)
// A2 đại diện cho dòng thứ hai của cột A, C3 đại diện cho dòng thứ ba của cột C
// Nếu bạn không muốn giới hạn dòng, chỉ cần không bao gồm số
var rows = MiniExcel.QueryRange(path, startCell: "A2", endCell: "C3").Cast<IDictionary<string, object>>();
```



#### 9. Query Excel trả về DataTable

Không khuyến nghị, vì DataTable sẽ tải toàn bộ dữ liệu vào bộ nhớ và làm mất tính năng tiêu thụ bộ nhớ thấp của MiniExcel.

```C#
var table = MiniExcel.QueryAsDataTable(path, useHeaderRow: true);
```

![image](https://user-images.githubusercontent.com/12729184/116673475-07917200-a9d6-11eb-947e-a6f68cce58df.png)



#### 10. Chỉ định ô bắt đầu đọc dữ liệu

```csharp
MiniExcel.Query(path,useHeaderRow:true,startCell:"B3")
```

![image](https://user-images.githubusercontent.com/12729184/117260316-8593c400-ae81-11eb-9877-c087b7ac2b01.png)



#### 11. Điền các ô gộp (Merged Cells)

Lưu ý: Hiệu suất sẽ chậm hơn so với `không sử dụng fill merge`

Lý do: Chuẩn OpenXml đặt mergeCells ở cuối file, dẫn đến việc phải duyệt sheetxml hai lần

```csharp
    var config = new OpenXmlConfiguration()
    {
        FillMergedCells = true
    };
    var rows = MiniExcel.Query(path, configuration: config);
```

![image](https://user-images.githubusercontent.com/12729184/117973630-3527d500-b35f-11eb-95c3-bde255f8114e.png)

hỗ trợ điền đa hàng và đa cột với chiều dài và chiều rộng biến đổi

![image](https://user-images.githubusercontent.com/12729184/117973820-6d2f1800-b35f-11eb-88d8-555063938108.png)

#### 12. Đọc file lớn bằng bộ nhớ đệm trên đĩa (Disk-Base Cache - SharedString)

Nếu kích thước SharedStrings vượt quá 5 MB, MiniExcel mặc định sẽ sử dụng bộ nhớ đệm trên ổ đĩa cục bộ, ví dụ, [10x100000.xlsx](https://github.com/MiniExcel/MiniExcel/files/8403819/NotDuplicateSharedStrings_10x100000.xlsx) (một triệu dòng dữ liệu), khi tắt cache ổ đĩa, bộ nhớ tối đa sử dụng là 195MB, nhưng bật cache ổ đĩa chỉ cần 65MB. Lưu ý, tối ưu hóa này sẽ mất một ít hiệu suất, nên trường hợp này thời gian đọc sẽ tăng từ 7.4 giây lên 27.2 giây. Nếu bạn không cần, có thể tắt cache ổ đĩa với đoạn code sau:

```csharp
var config = new OpenXmlConfiguration { EnableSharedStringCache = false };
MiniExcel.Query(path,configuration: config)
```

Bạn có thể dùng `SharedStringCacheSize` để thay đổi kích thước file sharedString vượt quá ngưỡng chỉ định cho việc cache trên đĩa.
```csharp
var config = new OpenXmlConfiguration { SharedStringCacheSize=500*1024*1024 };
MiniExcel.Query(path, configuration: config);
```


![image](https://user-images.githubusercontent.com/12729184/161411851-1c3f72a7-33b3-4944-84dc-ffc1d16747dd.png)

![image](https://user-images.githubusercontent.com/12729184/161411825-17f53ec7-bef4-4b16-b234-e24799ea41b0.png)









### Tạo/Xuất Excel  <a name="getstart2"></a>

1. Phải là kiểu không trừu tượng với constructor không tham số công khai.

2. MiniExcel hỗ trợ tham số IEnumerable Deferred Execution, nếu bạn muốn sử dụng ít bộ nhớ nhất, vui lòng không gọi các phương thức như ToList

ví dụ: ToList hoặc không sử dụng bộ nhớ
![image](https://user-images.githubusercontent.com/12729184/112587389-752b0b00-8e38-11eb-8a52-cfb76c57e5eb.png)



#### 1. Ẩn danh hoặc kiểu mạnh [[Thử ngay]](https://dotnetfiddle.net/w5WD1J)

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

Kết quả File Tạo:

| Column1   | Column2 |
|-----------|---------|
| MiniExcel | 1       |
| Github    | 2       |


#### 3.  IDataReader
- `Khuyến nghị`, có thể tránh tải toàn bộ dữ liệu vào bộ nhớ
```csharp
MiniExcel.SaveAs(path, reader);
```

![image](https://user-images.githubusercontent.com/12729184/121275378-149a5e80-c8bc-11eb-85fe-5453552134f0.png)

DataReader xuất nhiều sheet (được khuyên dùng bởi Dapper ExecuteReader)

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

- `Không khuyến nghị`, sẽ tải toàn bộ dữ liệu vào bộ nhớ

- DataTable sử dụng Caption cho tên cột trước, sau đó mới dùng columname

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

Cảm ơn @shaofing #552, vui lòng sử dụng `CommandDefinition + CommandFlags.NoCache`

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(
        new CommandDefinition(
            @"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2"
            , flags: CommandFlags.NoCache)
        );
    // Lưu ý: QueryAsync sẽ throw exception đóng kết nối
    MiniExcel.SaveAs(path, rows);
```
}
```

Đoạn mã dưới đây sẽ tải tất cả dữ liệu vào bộ nhớ

```csharp
using (var connection = GetConnection(connectionString))
{
    var rows = connection.Query(@"select 'MiniExcel' as Column1,1 as Column2 union all select 'Github',2");
    MiniExcel.SaveAs(path, rows);
}
```


#### 6. Lưu với MemoryStream  [[Thử ngay]](https://dotnetfiddle.net/JOen0e)

```csharp
using (var stream = new MemoryStream()) //hỗ trợ FileStream, MemoryStream, v.v.
{
    stream.SaveAs(values);
}
```

ví dụ: API xuất excel

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


#### 7. Tạo nhiều Sheet

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


#### 8. Tuỳ chọn TableStyles

Kiểu mặc định

![image](https://user-images.githubusercontent.com/12729184/138234373-cfa97109-b71f-4711-b7f5-0eaaa4a0a3a6.png)

Không cấu hình kiểu dáng

```csharp
var config = new OpenXmlConfiguration()
{
     TableStyles = TableStyles.None
};
MiniExcel.SaveAs(path, value,configuration:config);
```

![image](https://user-images.githubusercontent.com/12729184/118784917-f3e57700-b8c2-11eb-8718-8d955b1bc197.png)


#### 9. AutoFilter

Từ phiên bản v0.19.0  `OpenXmlConfiguration.AutoFilter` có thể bật/tắt AutoFilter, giá trị mặc định là `true`, và thiết lập AutoFilter như sau:

```csharp
MiniExcel.SaveAs(path, value, configuration: new OpenXmlConfiguration() { AutoFilter = false });
```



#### 10. Tạo ảnh

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



#### 11. Xuất file mảng Byte

Từ phiên bản 1.22.0, khi kiểu dữ liệu là `byte[]` thì hệ thống sẽ lưu đường dẫn file tại ô theo mặc định, và khi import hệ thống có thể chuyển đổi về `byte[]`. Nếu bạn không muốn sử dụng tính năng này, bạn có thể thiết lập `OpenXmlConfiguration.EnableConvertByteArray` thành `false`, điều này giúp cải thiện hiệu suất hệ thống.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

Từ phiên bản 1.22.0, khi kiểu dữ liệu là `byte[]` thì hệ thống sẽ lưu đường dẫn file tại ô theo mặc định, và khi import hệ thống có thể chuyển đổi về `byte[]`. Nếu bạn không muốn sử dụng tính năng này, bạn có thể thiết lập `OpenXmlConfiguration.EnableConvertByteArray` thành `false`, điều này giúp cải thiện hiệu suất hệ thống.

![image](https://user-images.githubusercontent.com/12729184/153702334-c3b834f4-6ae4-4ddf-bd4e-e5005d5d8c6a.png)

#### 12. Gộp các ô giống nhau theo chiều dọc

Chức năng này chỉ hỗ trợ định dạng `xlsx` và sẽ gộp các ô theo chiều dọc giữa thẻ @merge và @endmerge.  
Bạn có thể sử dụng @mergelimit để giới hạn phạm vi gộp các ô theo chiều dọc.

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

Nội dung file trước và sau khi gộp:

Không giới hạn gộp:

<img width="318" alt="Screenshot 2023-08-07 at 11 59 24" src="https://github.com/mini-software/MiniExcel/assets/38832863/49cc96b9-6c35-4bf3-8d43-a9752a15b22e">

<img width="318" alt="Screenshot 2023-08-07 at 11 59 57" src="https://github.com/mini-software/MiniExcel/assets/38832863/3fbd529b-3ae6-4bbe-b4d8-2793a5a58010">

Có giới hạn gộp:

<img width="346" alt="Screenshot 2023-08-08 at 18 21 00" src="https://github.com/mini-software/MiniExcel/assets/38832863/04049d28-84d5-4c2a-bcff-5847547df5e1">

<img width="346" alt="Screenshot 2023-08-08 at 18 21 40" src="https://github.com/mini-software/MiniExcel/assets/38832863/f5cf8957-b0b0-4831-b8fc-8556299235c2">

#### 13. Bỏ qua giá trị null

Tùy chọn mới để ghi các ô trống cho giá trị null:

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
     EnableWriteNullValueCell = true // Giá trị mặc định.
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

Hành vi trước đây:
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
     EnableWriteNullValueCell = false // Giá trị mặc định là true.
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

Hoạt động cho giá trị null và DBNull.

#### 14. Cố định khung bảng (Freeze Panes)
```csharp
/* ... */

OpenXmlConfiguration configuration = new OpenXmlConfiguration()
{
    FreezeRowCount = 1,     // mặc định là 1
    FreezeColumnCount = 2   // mặc định là 0
};

MiniExcel.SaveAs(@"C:\temp\Book1.xlsx", dt, configuration: configuration);
```

![image](https://raw.githubusercontent.com/mini-software/MiniExcel/master/docs/images/freeze-pane-1.png)


### Đổ Dữ Liệu Vào Mẫu Excel <a name="getstart3"></a>

- Cú pháp khai báo tương tự như template Vue `{{tên biến}}`, hoặc render tập hợp `{{tên tập hợp.tên trường}}`
- Render tập hợp hỗ trợ IEnumerable/DataTable/DapperRow

#### 1. Đổ Dữ Liệu Cơ Bản

Mẫu:
![image](https://user-images.githubusercontent.com/12729184/114537556-ed8d2b00-9c84-11eb-8303-a69f62c41e5b.png)

Kết quả:
![image](https://user-images.githubusercontent.com/12729184/114537490-d8180100-9c84-11eb-8c69-db58692f3a85.png)

Mã nguồn:
```csharp
// 1. Bằng POCO
var value = new
{
    Name = "Jack",
    CreateDate = new DateTime(2021, 01, 01),
    VIP = true,
    Points = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);


// 2. Bằng Dictionary
var value = new Dictionary<string, object>()
{
    ["Name"] = "Jack",
    ["CreateDate"] = new DateTime(2021, 01, 01),
    ["VIP"] = true,
    ["Points"] = 123
};
MiniExcel.SaveAsByTemplate(path, templatePath, value);
```



#### 2. Đổ Dữ Liệu IEnumerable

> Lưu ý1: Sử dụng IEnumerable đầu tiên cùng cột làm cơ sở để đổ danh sách

Mẫu:
![image](https://user-images.githubusercontent.com/12729184/114564652-14f2f080-9ca3-11eb-831f-09e3fedbc5fc.png)

Kết quả:
![image](https://user-images.githubusercontent.com/12729184/114564204-b2015980-9ca2-11eb-900d-e21249f93f7c.png)

Mã nguồn:
```csharp
//1. Bằng POCO
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

//2. Bằng Dictionary
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



#### 3. Đổ Dữ Liệu Phức Tạp

> Lưu ý: Hỗ trợ nhiều sheet và sử dụng cùng một biến

Mẫu:

![image](https://user-images.githubusercontent.com/12729184/114565255-acf0da00-9ca3-11eb-8a7f-8131b2265ae8.png)

Kết quả:

![image](https://user-images.githubusercontent.com/12729184/114565329-bf6b1380-9ca3-11eb-85e3-3969e8bf6378.png)

```csharp
// 1. Bằng POCO
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

// 2. Bằng Dictionary
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

#### 4. Hiệu Năng Đổ Dữ Liệu Lớn

> LƯU Ý: Sử dụng IEnumerable thực thi deferred thay vì ToList sẽ giúp tiết kiệm tối đa bộ nhớ khi dùng MiniExcel

![image](https://user-images.githubusercontent.com/12729184/114577091-5046ec80-9cae-11eb-924b-087c7becf8da.png)



#### 5. Tự động ánh xạ kiểu dữ liệu cho giá trị ô

Mẫu

![image](https://user-images.githubusercontent.com/12729184/114802504-64830a80-9dd0-11eb-8d56-8e8c401b3ace.png)

Kết quả

![image](https://user-images.githubusercontent.com/12729184/114802419-43221e80-9dd0-11eb-9ffe-a2ce34fe7076.png)

Class

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

Mã nguồn

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



#### 6. Ví dụ: Liệt kê các dự án Github

Mẫu

![image](https://user-images.githubusercontent.com/12729184/115068623-12073280-9f25-11eb-9124-f4b3efcdb2a7.png)


Kết quả

![image](https://user-images.githubusercontent.com/12729184/115068639-1a5f6d80-9f25-11eb-9f45-27c434d19a78.png)

Mã nguồn

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

#### 7. Điền dữ liệu theo nhóm

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
##### 1. Với thẻ `@group` và thẻ `@header`

Trước

![before_with_header](https://user-images.githubusercontent.com/38832863/218646717-21b9d57a-2be2-4e9a-801b-ae212231d2b4.PNG)

Sau

![after_with_header](https://user-images.githubusercontent.com/38832863/218646721-58a7a340-7004-4bc2-af24-cffcb2c20737.PNG)

##### 2. Với thẻ @group và không có thẻ @header

Trước

![before_without_header](https://user-images.githubusercontent.com/38832863/218646873-b12417fa-801b-4890-8e96-669ed3b43902.PNG)

Sau

![after_without_header](https://user-images.githubusercontent.com/38832863/218646872-622461ba-342e-49ee-834f-b91ad9c2dac3.PNG)

##### 3. Không có thẻ @group

Trước

![without_group](https://user-images.githubusercontent.com/38832863/218646975-f52a68eb-e031-43b5-abaa-03b67c052d1a.PNG)

Sau

![without_group_after](https://user-images.githubusercontent.com/38832863/218646974-4a3c0e07-7c66-4088-ad07-b4ad3695b7e1.PNG)

#### 8. Câu lệnh If/ElseIf/Else trong ô

Quy tắc:
1. Hỗ trợ DateTime, Double, Int với các toán tử ==, !=, >, >=, <, <=.
2. Hỗ trợ String với các toán tử ==, !=.
3. Mỗi câu lệnh phải trên một dòng mới.
4. Thêm một khoảng trắng trước và sau toán tử.
5. Không được có dòng mới bên trong câu lệnh.
6. Ô phải có định dạng chính xác như bên dưới.

```csharp
@if(name == Jack)
{{employees.name}}
@elseif(name == Neo)
Test {{employees.name}}
@else
{{employees.department}}
@endif
```

Trước

![if_before](https://user-images.githubusercontent.com/38832863/235360606-ca654769-ff55-4f5b-98d2-d2ec0edb8173.PNG)

Sau

![if_after](https://user-images.githubusercontent.com/38832863/235360609-869bb960-d63d-45ae-8d64-9e8b0d0ab658.PNG)

#### 9. DataTable làm tham số

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
#### 10. Công thức

##### 1. Ví dụ
Thêm tiền tố `$` cho công thức của bạn và sử dụng `$enumrowstart` và `$enumrowend` để đánh dấu tham chiếu đến dòng bắt đầu và dòng kết thúc của tập hợp:

![image](docs/images/template-formulas-1.png)

Khi mẫu được render, tiền tố `$` sẽ bị loại bỏ và `$enumrowstart`, `$enumrowend` sẽ được thay thế bằng số dòng bắt đầu và kết thúc của tập hợp:

![image](docs/images/template-formulas-2.png)

##### 2. Một số công thức ví dụ khác:

|              |                                                                                           |
|--------------|-------------------------------------------------------------------------------------------|
| Tổng         | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}})`                                              |
| TB thay thế  | `$=SUM(C{{$enumrowstart}}:C{{$enumrowend}}) / COUNT(C{{$enumrowstart}}:C{{$enumrowend}})` |
| Khoảng       | `$=MAX(C{{$enumrowstart}}:C{{$enumrowend}}) - MIN(C{{$enumrowstart}}:C{{$enumrowend}})`   |


#### 11. Khác

##### 1. Kiểm tra key tham số mẫu

Từ phiên bản V1.24.0, mặc định sẽ bỏ qua key tham số mẫu bị thiếu và thay bằng chuỗi rỗng, `IgnoreTemplateParameterMissing` có thể kiểm soát việc ném ngoại lệ hay không.

```csharp
var config = new OpenXmlConfiguration()
{
    IgnoreTemplateParameterMissing = false,
};
MiniExcel.SaveAsByTemplate(path, templatePath, value, config)
```

![image](https://user-images.githubusercontent.com/12729184/157464332-e316f829-54aa-4c84-a5aa-9aef337b668d.png)



### Thuộc tính Tên/Chỉ số/Cột Bỏ qua của Excel <a name="getstart4"></a>



#### 1. Chỉ định tên cột, chỉ số cột, bỏ qua cột

Ví dụ Excel

![image](https://user-images.githubusercontent.com/12729184/114230869-3e163700-99ac-11eb-9a90-2039d4b4b313.png)

Mã nguồn

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
[ExcelColumnIndex("I")] // hệ thống sẽ chuyển "I" thành chỉ số 8
public string Test4 { get; set; }
public string Test5 { get; } //không có set sẽ bị bỏ qua
public string Test6 { get; private set; } //set không public sẽ bị bỏ qua
[ExcelColumnIndex(3)] // bắt đầu từ 0
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





#### 2. Định Dạng Tùy Chỉnh (ExcelFormatAttribute)

Từ V0.21.0 hỗ trợ class chứa phương thức định dạng `ToString(string content)`

Class

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

Kết quả

![image](https://user-images.githubusercontent.com/12729184/118910788-ab2bcd80-b957-11eb-8d42-bfce36621b1b.png)

Query hỗ trợ chuyển đổi định dạng tùy chỉnh

![image](https://user-images.githubusercontent.com/12729184/118911286-87b55280-b958-11eb-9a88-c8ff403d240a.png)

#### 3. Đặt Độ Rộng Cột (ExcelColumnWidthAttribute)

```csharp
public class Dto
{
    [ExcelColumnWidth(20)]
    public int ID { get; set; }
    [ExcelColumnWidth(15.50)]
    public string Name { get; set; }
}
```

#### 4. Nhiều tên cột ánh xạ vào cùng một thuộc tính.

```csharp
public class Dto
{
    [ExcelColumnName(excelColumnName:"EmployeeNo",aliases:new[] { "EmpNo","No" })]
    public string Empno { get; set; }
    public string Name { get; set; }
}
```



#### 5. System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

Từ phiên bản 1.24.0, hệ thống hỗ trợ System.ComponentModel.DisplayNameAttribute = ExcelColumnName.excelColumnNameAttribute

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

Từ phiên bản V1.26.0, nhiều thuộc tính có thể được đơn giản hóa như sau:
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

Từ phiên bản V1.26.0, chúng ta có thể thiết lập thuộc tính của Column một cách động
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

Từ phiên bản V1.31.4 chúng ta có thể thiết lập thuộc tính của Sheet một cách động. Có thể đặt tên sheet và trạng thái (hiển thị/ẩn).
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

Chúng ta cũng có thể sử dụng thuộc tính mới ExcelSheetAttribute:

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

### Thêm, Xóa, Cập Nhật

#### Thêm

v1.28.0 hỗ trợ CSV chèn N dòng dữ liệu sau dòng cuối cùng

```csharp
// Gốc
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value);
}
// Chèn 1 dòng sau dòng cuối
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, value);
}
// Chèn N dòng sau dòng cuối
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

v1.37.0 hỗ trợ chèn một sheet mới vào một workbook excel đã tồn tại

```csharp
// File excel gốc
{
    var value = new[] {
          new { ID=1,Name ="Jack",InDate=new DateTime(2021,01,03)},
          new { ID=2,Name ="Henry",InDate=new DateTime(2020,05,03)},
    };
    MiniExcel.SaveAs(path, value, sheetName: "Sheet1");
}
// Chèn một sheet mới
{
    var value = new { ID=3,Name = "Mike", InDate = new DateTime(2021, 04, 23) };
    MiniExcel.Insert(path, table, sheetName: "Sheet2");
}
```



#### Xóa (chờ cập nhật)

#### Cập nhật (chờ cập nhật)



### Tự động kiểm tra loại Excel <a name="getstart5"></a>

- MiniExcel sẽ kiểm tra xem là xlsx hay csv dựa trên `phần mở rộng của file` theo mặc định, tuy nhiên có thể không chính xác, vui lòng chỉ định thủ công nếu cần.
- Đối với Stream thì không thể biết từ loại excel nào, vui lòng chỉ định thủ công.

```csharp
stream.SaveAs(excelType:ExcelType.CSV);
//hoặc
stream.SaveAs(excelType:ExcelType.XLSX);
//hoặc
stream.Query(excelType:ExcelType.CSV);
//hoặc
stream.Query(excelType:ExcelType.XLSX);
```





### CSV

#### Lưu ý

- Mặc định trả về kiểu `string`, và giá trị sẽ không được chuyển đổi sang số hoặc datetime, trừ khi kiểu được định nghĩa bằng generic kiểu mạnh.



#### Tùy chỉnh ký tự phân cách

Mặc định là `,` làm ký tự phân cách, bạn có thể sửa thuộc tính `Seperator` để tùy chỉnh

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    Seperator=';'
};
MiniExcel.SaveAs(path, values,configuration: config);
```

Từ phiên bản V1.30.1 hỗ trợ hàm tùy chỉnh ký tự phân cách (cảm ơn @hyzx86)

```csharp
var config = new CsvConfiguration()
{
    SplitFn = (row) => Regex.Split(row, $"[\t,](?=(?:[^\"]|\"[^\"]*\")*$)")
        .Select(s => Regex.Replace(s.Replace("\"\"", "\""), "^\"|\"$", "")).ToArray()
};
var rows = MiniExcel.Query(path, configuration: config).ToList();
```



#### Tùy chỉnh ký tự xuống dòng

Mặc định là `\r\n` làm ký tự xuống dòng, bạn có thể sửa thuộc tính `NewLine` để tùy chỉnh

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    NewLine='\n'
};
MiniExcel.SaveAs(path, values,configuration: config);
```



#### Tùy chỉnh mã hóa

- Mặc định mã hóa là "Detect Encoding From Byte Order Marks"  (detectEncodingFromByteOrderMarks: true)
- Nếu bạn có yêu cầu mã hóa riêng, vui lòng chỉnh sửa thuộc tính StreamReaderFunc / StreamWriterFunc

```csharp
// Đọc
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamReaderFunc = (stream) => new StreamReader(stream,Encoding.GetEncoding("gb2312"))
};
var rows = MiniExcel.Query(path, true,excelType:ExcelType.CSV,configuration: config);

// Ghi
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
    StreamWriterFunc = (stream) => new StreamWriter(stream, Encoding.GetEncoding("gb2312"))
};
MiniExcel.SaveAs(path, value,excelType:ExcelType.CSV, configuration: config);
```

#### Đọc chuỗi rỗng thành null

Theo mặc định, giá trị rỗng sẽ được ánh xạ thành string.Empty. Bạn có thể thay đổi hành vi này

```csharp
var config = new MiniExcelLibs.Csv.CsvConfiguration()
{
   ReadEmptyStringAsNull = true
};
```


### DataReader

#### 1. GetReader
Từ phiên bản 1.23.0, bạn có thể GetDataReader

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

- v0.17.0 hỗ trợ Async (cảm ơn isdaniel ( SHIH,BING-SIOU)](https://github.com/isdaniel))

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

-  v1.25.0 hỗ trợ `cancellationToken`.



### Khác

#### 1. Enum

Hãy chắc chắn tên cột trong excel và tên thuộc tính giống nhau, hệ thống sẽ tự động ánh xạ (không phân biệt hoa thường)

![image](https://user-images.githubusercontent.com/12729184/116210595-9784b100-a775-11eb-936f-8e7a8b435961.png)

Từ phiên bản V0.18.0 hỗ trợ Enum Description

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
```

![image](https://user-images.githubusercontent.com/12729184/133116630-27cc7161-099a-48b8-9784-cd1e443af3d1.png)

Từ phiên bản 1.30.0 đã hỗ trợ mô tả excel cho Enum, cảm ơn @KaneLeung

#### 2. Chuyển đổi CSV sang XLSX hoặc chuyển đổi XLSX sang CSV

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

#### 3. Tuỳ chỉnh CultureInfo

Từ phiên bản 1.22.0, bạn có thể tuỳ chỉnh CultureInfo như bên dưới, mặc định hệ thống là `CultureInfo.InvariantCulture`.

```csharp
var config = new CsvConfiguration()
{
    Culture = new CultureInfo("fr-FR"),
};
MiniExcel.SaveAs(path, value, configuration: config);

// hoặc
MiniExcel.Query(path, configuration: config);
```


#### 4. Tuỳ chỉnh Buffer Size
```csharp
    public abstract class Configuration : IConfiguration
    {
        public int BufferSize { get; set; } = 1024 * 512;
    }
```

#### 5. FastMode

Hệ thống sẽ không kiểm soát bộ nhớ, nhưng bạn có thể có tốc độ lưu nhanh hơn.

```csharp
var config = new OpenXmlConfiguration() { FastMode = true };
MiniExcel.SaveAs(path, reader,configuration:config);
```

#### 6. Thêm nhiều ảnh một lúc (MiniExcel.AddPicture)

```csharp
var images = new[]
{
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/github_logo.png")),
        SheetName = null, // mặc định null là sheet đầu tiên
        CellAddress = "C3", // bắt buộc
    },
    new MiniExcelPicture
    {
        ImageBytes = File.ReadAllBytes(PathHelper.GetFile("images/google_logo.png")),
        PictureType = "image/png", // mặc định PictureType = image/png
        SheetName = "Demo",
        CellAddress = "C9", // bắt buộc
        WidthPx = 100,
        HeightPx = 100,
    },
};
MiniExcel.AddPicture(path, images);
```
![Image](https://github.com/user-attachments/assets/19c4d241-9753-4ede-96c8-f810c1a22247)

#### 7. Lấy kích thước Sheet

```csharp
var dim = MiniExcel.GetSheetDimensions(path);
```

### Ví dụ:

#### 1. SQLite & Dapper `Large Size File` SQL Insert Tránh OOM

lưu ý : vui lòng không gọi các phương thức ToList/ToArray sau khi Query, vì nó sẽ tải toàn bộ dữ liệu vào bộ nhớ

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

hiệu năng:
![image](https://user-images.githubusercontent.com/12729184/111072579-2dda7b80-8516-11eb-9843-c01a1edc88ec.png)





#### 2. ASP.NET Core 3.1 hoặc MVC 5 Download/Upload Excel Xlsx API Demo [Dùng thử](tests/MiniExcel.Tests.AspNetCore)

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
            // xử lý logic của bạn ở đây, v.v.
        }

        return Ok("Tải file lên thành công");
    }
}
```

####  3. Truy vấn phân trang

```csharp
void Main()
{
    var rows = MiniExcel.Query(path);

    Console.WriteLine("==== Trang số 1 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:1));
    Console.WriteLine("==== Trang số 50 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:50));
    Console.WriteLine("==== Trang số 5000 ====");
    Console.WriteLine(Page(rows,pageSize:3,page:5000));
}

public static IEnumerable<T> Page<T>(IEnumerable<T> en, int pageSize, int page)
{
    return en.Skip(page * pageSize).Take(pageSize);
}
```

![20210419](https://user-images.githubusercontent.com/12729184/114679083-6ef4c400-9d3e-11eb-9f78-a86daa45fe46.gif)



#### 4. WebForm xuất Excel bằng memorystream

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



#### 5. Đa ngôn ngữ động (i18n) và quản lý quyền vai trò

Như ví dụ, tạo một phương thức để xử lý i18n và quản lý phân quyền, và sử dụng `yield return` để trả về `IEnumerable<Dictionary<string, object>>` nhằm đạt được hiệu ứng xử lý động và tiết kiệm bộ nhớ.

```csharp
void Main()
{
    var value = new Order[] {
        new Order(){OrderNo = "SO01",CustomerID="C001",ProductID="P001",Qty=100,Amt=500},
        new Order(){OrderNo = "SO02",CustomerID="C002",ProductID="P002",Qty=300,Amt=400},
    };

    Console.WriteLine("en-Us và vai trò Sales");
    {
        var path = Path.GetTempPath() + Guid.NewGuid() + ".xlsx";
        var lang = "en-US";
        var role = "Sales";
        MiniExcel.SaveAs(path, GetOrders(lang, role, value));
        MiniExcel.Query(path, true).Dump();
    }

    Console.WriteLine("zh-CN và vai trò PMC");
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

#### Q: Tiêu đề cột trong Excel không giống tên thuộc tính của class, làm sao để ánh xạ?

A. Vui lòng sử dụng thuộc tính ExcelColumnName

![image](https://user-images.githubusercontent.com/12729184/116020475-eac50980-a678-11eb-8804-129e87200e5e.png)

#### Q. Làm sao để truy vấn hoặc xuất nhiều sheet?

A. Sử dụng phương thức `GetSheetNames` với tham số sheetName trong  Query .



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

#### Q. Làm sao để truy vấn hoặc xuất thông tin về trạng thái hiển thị của sheet?

A. Sử dụng phương thức `GetSheetInformations`.



```csharp
var sheets = MiniExcel.GetSheetInformations(path);
foreach (var sheetInfo in sheets)
{
    Console.WriteLine($"sheet index : {sheetInfo.Index} "); // chỉ số sheet tiếp theo - đánh số từ 0
    Console.WriteLine($"sheet name : {sheetInfo.Name} ");   // tên sheet
    Console.WriteLine($"sheet state : {sheetInfo.State} "); // trạng thái hiển thị của sheet - visible / hidden
}
```

#### Hỏi. Việc sử dụng Count có tải tất cả dữ liệu vào bộ nhớ không?

Không, bài kiểm tra hình ảnh có 1 triệu dòng * 10 cột dữ liệu, mức sử dụng bộ nhớ tối đa là <60MB, và mất 13,65 giây

![image](https://user-images.githubusercontent.com/12729184/117118518-70586000-adc3-11eb-9ce3-2ba76cf8b5e5.png)

#### Hỏi. Query sử dụng chỉ số số nguyên như thế nào?

Chỉ số mặc định của Query là Key dạng chuỗi: A,B,C.... Nếu bạn muốn chuyển sang chỉ số số, hãy tạo phương thức sau để chuyển đổi

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

#### Hỏi. Khi xuất Excel, nếu giá trị rỗng thì tạo file excel không có tiêu đề

Vì MiniExcel sử dụng logic tương tự JSON.NET để lấy kiểu dữ liệu từ giá trị một cách động nhằm đơn giản hóa thao tác API, nên không thể biết được kiểu dữ liệu nếu không có dữ liệu. Bạn có thể xem thêm tại [issue #133](https://github.com/mini-software/MiniExcel/issues/133) để hiểu rõ hơn.

![image](https://user-images.githubusercontent.com/12729184/122639771-546c0c00-d12e-11eb-800c-498db27889ca.png)

> Kiểu strong type & DataTable sẽ sinh tiêu đề, nhưng Dictionary vẫn tạo file Excel rỗng

#### Hỏi. Làm thế nào để dừng foreach khi gặp dòng trống?

MiniExcel có thể kết hợp với `LINQ TakeWhile` để dừng vòng lặp foreach.

![Image](https://user-images.githubusercontent.com/12729184/130209137-162621c2-f337-4479-9996-beeac65bc4d4.png)

#### Hỏi. Làm thế nào để loại bỏ các dòng trống?

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

#### Hỏi. Làm thế nào để SaveAs(path,value) ghi đè file đã tồn tại mà không báo lỗi "The file ...xlsx already exists error"

Vui lòng sử dụng lớp Stream để tùy chỉnh logic tạo file, ví dụ:

```C#
    using (var stream = File.Create("Demo.xlsx"))
        MiniExcel.SaveAs(stream,value);
```

hoặc, từ phiên bản V1.25.0, SaveAs hỗ trợ tham số overwriteFile để bật/tắt ghi đè file đã tồn tại

```csharp
    MiniExcel.SaveAs(path, value, overwriteFile: true);
```

### Giới hạn và lưu ý

- Hiện không hỗ trợ xls và file mã hóa
- xlsm chỉ hỗ trợ Query

### Tham khảo

[ExcelDataReader](https://github.com/ExcelDataReader/ExcelDataReader)  / [ClosedXML](https://github.com/ClosedXML/ClosedXML) / [Dapper](https://github.com/DapperLib/Dapper) / [ExcelNumberFormat](https://github.com/andersnm/ExcelNumberFormat)

### Cảm ơn

#### [Jetbrains](https://www.jetbrains.com/)

![jetbrains-variant-2](https://user-images.githubusercontent.com/12729184/123997015-8456c180-da02-11eb-829a-aec476fe8e94.png)

Cảm ơn đã cung cấp miễn phí All product IDE cho dự án này ([License](https://user-images.githubusercontent.com/12729184/123988233-6ab17c00-d9fa-11eb-8739-2a08c6a4a263.png))

### Chia sẻ đóng góp donate
Liên kết https://github.com/orgs/mini-software/discussions/754

### Những người đóng góp

![](https://contrib.rocks/image?repo=mini-software/MiniExcel)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---