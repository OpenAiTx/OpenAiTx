# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Trình tuần tự hóa nhị phân hiệu năng cực cao không mã hóa cho C# và Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> So sánh với [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Được đo bằng máy .NET 7 / Ryzen 9 5950X. Các serializer này đều có phương thức `IBufferWriter<byte>`, được tuần tự hóa bằng `ArrayBufferWriter<byte>` và tái sử dụng để tránh đo việc sao chép bộ đệm. 

Đối với các đối tượng thông thường, MemoryPack nhanh hơn x10 và nhanh hơn x2 ~ x5 so với các serializer nhị phân khác. Đối với mảng struct, MemoryPack còn mạnh mẽ hơn nữa, với tốc độ nhanh hơn x50 ~ x200 so với các serializer khác.

MemoryPack là trình tuần tự hóa thứ 4 tôi phát triển, trước đây tôi đã tạo ra các serializer nổi tiếng, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). Lý do MemoryPack nhanh là nhờ định dạng nhị phân tối ưu hóa riêng cho C#, và một triển khai được tinh chỉnh dựa trên kinh nghiệm trước đây của tôi. Đây cũng là một thiết kế hoàn toàn mới tận dụng .NET 7, C# 11 và Incremental Source Generator (hỗ trợ .NET Standard 2.1 (.NET 5, 6) và có hỗ trợ Unity).

Các serializer khác thực hiện nhiều thao tác mã hóa như mã hóa VarInt, tag, chuỗi, v.v. Định dạng MemoryPack sử dụng thiết kế không mã hóa, sao chép càng nhiều bộ nhớ C# càng tốt. Không mã hóa tương tự như FlatBuffers, nhưng không cần kiểu đặc biệt, mục tiêu tuần tự hóa của MemoryPack là POCO.

Ngoài hiệu năng, MemoryPack còn có các tính năng sau.

* Hỗ trợ các API I/O hiện đại (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Sinh mã dựa trên Source Generator thân thiện với Native AOT, không sử dụng Dynamic CodeGen (IL.Emit)
* API không phản xạ, không generic
* Khả năng giải tuần tự vào instance đã có sẵn
* Tuần tự hóa đa hình (Union)
* Hỗ trợ chịu lỗi phiên bản giới hạn (fast/default) và đầy đủ
* Tuần tự hóa tham chiếu vòng lặp
* Tuần tự hóa luồng dựa trên PipeWriter/Reader
* Sinh mã TypeScript và ASP.NET Core Formatter
* Hỗ trợ Unity (2021.3) IL2CPP qua .NET Source Generator

Cài đặt
---
Thư viện này được phân phối qua NuGet. Để đạt hiệu năng tốt nhất, khuyến nghị sử dụng `.NET 7`. Yêu cầu tối thiểu là `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Ngoài ra trình soạn thảo mã cần hỗ trợ Roslyn 4.3.1, ví dụ Visual Studio 2022 phiên bản 17.3, .NET SDK 6.0.401. Xem chi tiết tại tài liệu [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Đối với Unity, yêu cầu và quá trình cài đặt hoàn toàn khác. Xem chi tiết ở mục [Unity](#unity).

Bắt đầu nhanh
---
Định nghĩa một struct hoặc class để tuần tự hóa và gắn thuộc tính `[MemoryPackable]` cùng từ khóa `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Mã tuần tự hóa được sinh ra bởi tính năng source generator của C# triển khai giao diện `IMemoryPackable<T>`. Trong Visual Studio, bạn có thể xem mã sinh ra bằng tổ hợp phím `Ctrl+K, R` trên tên lớp và chọn `*.MemoryPackFormatter.g.cs`.

Gọi `MemoryPackSerializer.Serialize<T>/Deserialize<T>` để tuần tự hóa/giải tuần tự một instance đối tượng.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Phương thức `Serialize` hỗ trợ kiểu trả về `byte[]` cũng như có thể tuần tự hóa vào `IBufferWriter<byte>` hoặc `Stream`. Phương thức `Deserialize` hỗ trợ `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` và `Stream`. Ngoài ra còn có các phiên bản không generic.

Các kiểu được hỗ trợ sẵn
---
Các kiểu này có thể được tuần tự hóa mặc định:

* Kiểu nguyên thủy .NET (`byte`, `int`, `bool`, `char`, `double`, v.v.)
* Kiểu unmanaged (Bất kỳ `enum`, bất kỳ `struct` do người dùng định nghĩa không chứa kiểu tham chiếu)
* `string`, `decimal`, `Half`, `Int128`, `UInt128`, `Guid`, `Rune`, `BigInteger`
* `TimeSpan`,  `DateTime`, `DateTimeOffset`, `TimeOnly`, `DateOnly`, `TimeZoneInfo`
* `Complex`, `Plane`, `Quaternion` `Matrix3x2`, `Matrix4x4`, `Vector2`, `Vector3`, `Vector4`
* `Uri`, `Version`, `StringBuilder`, `Type`, `BitArray`, `CultureInfo`
* `T[]`, `T[,]`, `T[,,]`, `T[,,,]`, `Memory<>`, `ReadOnlyMemory<>`, `ArraySegment<>`, `ReadOnlySequence<>`
* `Nullable<>`, `Lazy<>`, `KeyValuePair<,>`, `Tuple<,...>`, `ValueTuple<,...>`
* `List<>`, `LinkedList<>`, `Queue<>`, `Stack<>`, `HashSet<>`, `SortedSet<>`, `PriorityQueue<,>`
* `Dictionary<,>`, `SortedList<,>`, `SortedDictionary<,>`,  `ReadOnlyDictionary<,>` 
* `Collection<>`, `ReadOnlyCollection<>`, `ObservableCollection<>`, `ReadOnlyObservableCollection<>`
* `IEnumerable<>`, `ICollection<>`, `IList<>`, `IReadOnlyCollection<>`, `IReadOnlyList<>`, `ISet<>`
* `IDictionary<,>`, `IReadOnlyDictionary<,>`, `ILookup<,>`, `IGrouping<,>`,
* `ConcurrentBag<>`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentDictionary<,>`, `BlockingCollection<>`
* Bộ sưu tập bất biến (`ImmutableList<>`, v.v.) và interface (`IImmutableList<>`, v.v.)

Định nghĩa `[MemoryPackable]` cho `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` có thể gắn vào bất kỳ `class`, `struct`, `record`, `record struct` và `interface`. Nếu kiểu là `struct` hoặc `record struct` không chứa kiểu tham chiếu ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)) thì mọi annotation bổ sung (bỏ qua, bao gồm, constructor, callback) sẽ không được dùng, sẽ tuần tự hóa/giải tuần tự trực tiếp từ bộ nhớ.

Ngược lại, mặc định `[MemoryPackable]` sẽ tuần tự hóa các property hoặc field instance public. Bạn có thể sử dụng `[MemoryPackIgnore]` để loại khỏi mục tiêu tuần tự hóa, `[MemoryPackInclude]` để đẩy một thành viên private thành mục tiêu tuần tự hóa.

```csharp
[MemoryPackable]
public partial class Sample
{
    // các kiểu này được tuần tự hóa mặc định
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // các kiểu này không được tuần tự hóa mặc định
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // dùng [MemoryPackIgnore] để loại public member khỏi tuần tự hóa
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // dùng [MemoryPackInclude] để đưa một thành viên private vào tuần tự hóa
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Bộ sinh mã của `MemoryPack` sẽ thêm thông tin về các thành viên được tuần tự hóa vào phần `<remarks />`. Có thể xem bằng cách di chuột lên kiểu với Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Tất cả các thành viên phải có khả năng tuần tự hóa bởi memorypack, nếu không bộ sinh mã sẽ báo lỗi.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack có 35 quy tắc chẩn đoán (`MEMPACK001` đến `MEMPACK035`) để định nghĩa một cách thoải mái.

Nếu kiểu mục tiêu đã có tuần tự hóa MemoryPack định nghĩa bên ngoài và đã đăng ký, sử dụng `[MemoryPackAllowSerialize]` để tắt cảnh báo chẩn đoán.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Thứ tự thành viên là **quan trọng**, MemoryPack không tuần tự hóa tên thành viên hay thông tin khác, thay vào đó tuần tự hóa các trường theo thứ tự khai báo. Nếu kiểu kế thừa, tuần tự hóa thực hiện theo thứ tự cha → con. Thứ tự các thành viên không thể thay đổi khi giải tuần tự. Để tiến hóa schema, xem mục [Version tolerant](#version-tolerant).

Thứ tự mặc định là tuần tự, nhưng bạn có thể chọn layout rõ ràng với `[MemoryPackable(SerializeLayout.Explicit)]` và `[MemoryPackOrder()]`.

```csharp
// tuần tự hóa Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Lựa chọn constructor

MemoryPack hỗ trợ cả constructor có tham số và không tham số. Việc lựa chọn constructor tuân theo các quy tắc sau. (Áp dụng cho cả class và struct).

* Nếu có `[MemoryPackConstructor]`, sẽ sử dụng nó.
* Nếu không có constructor rõ ràng (bao gồm cả private), sử dụng constructor không tham số.
* Nếu chỉ có một constructor không tham số/ có tham số (bao gồm cả private), sẽ sử dụng nó.
* Nếu có nhiều constructor, thuộc tính `[MemoryPackConstructor]` phải được áp dụng cho constructor mong muốn (bộ sinh mã sẽ không tự động chọn), nếu không sẽ phát sinh lỗi.
* Nếu sử dụng constructor có tham số, tất cả tên tham số phải khớp với tên thành viên tương ứng (không phân biệt hoa thường).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Có thể sử dụng constructor có tham số - tên tham số phải khớp với tên thành viên (không phân biệt hoa thường)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// cũng hỗ trợ record primary constructor
[MemoryPackable]
public partial record Person2(int Age, string Name);

public partial class Person3
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Person3()
    {
    }
```
```csharp
// Nếu có nhiều constructor, thì nên sử dụng [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callback khi tuần tự hóa

Khi tuần tự hóa/giải tuần tự, MemoryPack có thể gọi một sự kiện trước/sau bằng cách sử dụng các thuộc tính `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Có thể đánh dấu cả phương thức static và instance (không static), cũng như phương thức public và private.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // thứ tự gọi phương thức là static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // cũng cho phép phương thức private
    [MemoryPackOnSerializing]
    void OnSerializing2()
    {
        Console.WriteLine(nameof(OnSerializing2));
    }

    // serializing -> /* serialize */ -> serialized
    [MemoryPackOnSerialized]
    static void OnSerialized1()
    {
        Console.WriteLine(nameof(OnSerialized1));
    }

    [MemoryPackOnSerialized]
    public void OnSerialized2()
    {
        Console.WriteLine(nameof(OnSerialized2));
    }

    [MemoryPackOnDeserializing]
    public static void OnDeserializing1()
    {
        Console.WriteLine(nameof(OnDeserializing1));
    }

    // Lưu ý: phương thức instance với MemoryPackOnDeserializing sẽ không được gọi nếu instance không được truyền bằng `ref`
    [MemoryPackOnDeserializing]
    public void OnDeserializing2()
    {
        Console.WriteLine(nameof(OnDeserializing2));
    }

    [MemoryPackOnDeserialized]
    public static void OnDeserialized1()
    {
        Console.WriteLine(nameof(OnDeserialized1));
    }

    [MemoryPackOnDeserialized]
    public void OnDeserialized2()
    {
        Console.WriteLine(nameof(OnDeserialized2));
    }
}
```

Callback cho phép phương thức không tham số và phương thức `ref reader/writer, ref T value`. Ví dụ, callback ref có thể ghi/đọc header tùy chỉnh trước quá trình tuần tự hóa.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, sử dụng where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // ghi GUID vào header.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // đọc header tùy chỉnh trước khi giải tuần tự
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Nếu gán giá trị cho `ref value`, bạn có thể thay đổi giá trị được sử dụng cho quá trình tuần tự hóa/giải tuần tự. Ví dụ, khởi tạo từ ServiceProvider.

```csharp
// trước khi sử dụng formatter này, đặt ServiceProvider
// var options = MemoryPackSerializerOptions.Default with { ServiceProvider = provider };
// MemoryPackSerializer.Deserialize(value, options);

[MemoryPackable]
public partial class InstantiateFromServiceProvider
{
    static IServiceProvider serviceProvider = default!;

    public int MyProperty { get; private set; }

    [MemoryPackOnDeserializing]
    static void OnDeserializing(ref MemoryPackReader reader, ref InstantiateFromServiceProvider value)
    {
        if (value != null) return;
        value = reader.Options.ServiceProvider!.GetRequiredService<InstantiateFromServiceProvider>();
    }
}
```

Định nghĩa collection tùy chỉnh
---
Theo mặc định, kiểu được đánh dấu `[MemoryPackObject]` sẽ cố gắng tuần tự hóa các thành viên của nó. Tuy nhiên, nếu một kiểu là collection (`ICollection<>`, `ISet<>`, `IDictionary<,>`), hãy sử dụng `GenerateType.Collection` để tuần tự hóa chính xác.

```csharp
[MemoryPackable(GenerateType.Collection)]
public partial class MyList<T> : List<T>
{
}

[MemoryPackable(GenerateType.Collection)]
public partial class MyStringDictionary<TValue> : Dictionary<string, TValue>
{

}
```

Static constructor
---
Lớp MemoryPackable không thể định nghĩa static constructor vì partial class được sinh ra sẽ sử dụng nó. Thay vào đó, bạn có thể định nghĩa một `static partial void StaticConstructor()` để thực hiện cùng chức năng.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Đa hình (Union)
---
MemoryPack hỗ trợ tuần tự hóa các object của interface và abstract class để phục vụ tuần tự hóa đa hình. Trong MemoryPack, tính năng này được gọi là Union. Chỉ interface và abstract class mới được phép đánh dấu thuộc tính `[MemoryPackUnion]`. Tag của union phải là duy nhất.

```csharp
// Đánh dấu [MemoryPackable] và các kiểu kế thừa với [MemoryPackUnion]
// Union cũng hỗ trợ abstract class
[MemoryPackable]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial interface IUnionSample
{
}

[MemoryPackable]
public partial class FooClass : IUnionSample
{
    public int XYZ { get; set; }
}

[MemoryPackable]
public partial class BarClass : IUnionSample
{
    public string? OPQ { get; set; }
}
// ---

IUnionSample data = new FooClass() { XYZ = 999 };

// Tuần tự hóa dưới dạng kiểu interface.
var bin = MemoryPackSerializer.Serialize(data);

// Giải tuần tự dưới dạng kiểu interface.
var reData = MemoryPackSerializer.Deserialize<IUnionSample>(bin);

switch (reData)
{
    case FooClass x:
        Console.WriteLine(x.XYZ);
        break;
    case BarClass x:
        Console.WriteLine(x.OPQ);
        break;
    default:
        break;
}
```

`tag` cho phép giá trị từ `0` ~ `65535`, đặc biệt hiệu quả với giá trị nhỏ hơn `250`.
```
Nếu một interface và các kiểu dẫn xuất nằm ở các assembly khác nhau, bạn có thể sử dụng `MemoryPackUnionFormatterAttribute` thay thế. Các formatter được sinh ra sẽ tự động được đăng ký thông qua `ModuleInitializer` trong C# 9.0 trở lên.

> Lưu ý rằng `ModuleInitializer` không được hỗ trợ trong Unity, do đó formatter phải được đăng ký thủ công. Để đăng ký union formatter của bạn, hãy gọi `{tên union formatter của bạn}Initializer.RegisterFormatter()` một cách thủ công trong Startup. Ví dụ `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB định nghĩa formatter bên ngoài kiểu mục tiêu
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union có thể được lắp ráp trong code thông qua `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

Serialize API
---
`Serialize` có ba overload.

```csharp
// API không generic cũng có sẵn, phiên bản này tham số đầu tiên là Type và value là object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Để đạt hiệu suất tốt nhất, nên sử dụng API với `BufferWriter`. API này sẽ serialize trực tiếp vào buffer. Có thể áp dụng với `PipeWriter` trong `System.IO.Pipelines`, `BodyWriter` trong ASP .NET Core, v.v.

Nếu cần một `byte[]` (ví dụ `RedisValue` trong [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), API trả về `byte[]` rất đơn giản và gần như nhanh tương đương.

Lưu ý rằng `SerializeAsync` cho `Stream` chỉ thực sự bất đồng bộ khi Flush; nó serialize tất cả vào buffer nội bộ của MemoryPack rồi mới ghi bằng `WriteAsync`. Do đó, overload `BufferWriter` cho phép tách biệt và kiểm soát buffer và flush sẽ tốt hơn.

Nếu bạn muốn thực hiện ghi streaming hoàn chỉnh, xem phần [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` cấu hình việc chuỗi ký tự được serialize ở dạng UTF16 hay UTF8. Có thể cấu hình bằng cách truyền `MemoryPackSerializerOptions.Utf8` cho mã hóa UTF8, `MemoryPackSerializerOptions.Utf16` cho mã hóa UTF16 hoặc `MemoryPackSerializerOptions.Default` (mặc định là UTF8). Truyền null hoặc dùng tham số mặc định sẽ dùng mã hóa UTF8.

Vì biểu diễn chuỗi nội bộ của C# là UTF16 nên UTF16 cho hiệu suất tốt hơn. Tuy nhiên, payload thường lớn hơn; với UTF8, chuỗi ASCII chỉ chiếm một byte, còn UTF16 là hai byte. Do sự khác biệt kích thước payload này khá lớn nên mặc định là UTF8.

Nếu dữ liệu là non-ASCII (ví dụ tiếng Nhật có thể hơn 3 byte và UTF8 sẽ lớn hơn), hoặc nếu bạn cần nén riêng, UTF16 có thể cho kết quả tốt hơn.

Dù có thể chọn UTF8 hoặc UTF16 khi serialize, khi deserialize không cần chỉ định; sẽ tự động phát hiện và giải mã bình thường.

Ngoài ra, bạn có thể get/set `IServiceProvider? ServiceProvider { get; init; }` từ options. Điều này hữu ích để lấy DI object (như `ILogger<T>`) từ quá trình serialization (`MemoryPackReader/MemoryPackWriter` có thuộc tính .Options).

Deserialize API
---
`Deserialize` có overload cho `ReadOnlySpan<byte>` và `ReadOnlySequence<byte>`, `Stream` và hỗ trợ `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

Overload `ref` sẽ ghi đè lên instance hiện có, chi tiết xem phần [Overwrite](#overwrite).

`DeserializeAsync(Stream)` không phải là một thao tác đọc streaming hoàn chỉnh, đầu tiên nó đọc vào pool nội bộ của MemoryPack đến hết stream, sau đó mới giải mã.

Nếu bạn muốn thực hiện đọc streaming hoàn chỉnh, xem phần [Streaming Serialization](#streaming-serialization).

Overwrite
---
Để giảm việc cấp phát bộ nhớ, MemoryPack hỗ trợ deserialize vào một instance đã có sẵn, ghi đè lên nó. Có thể sử dụng với overload `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// ghi đè dữ liệu lên instance đã có
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack sẽ cố gắng ghi đè tối đa có thể, nhưng nếu các điều kiện sau không thỏa mãn thì sẽ tạo instance mới (như deserialization thông thường).

* ref value (bao gồm các thành viên trong object graph) là null, thì tạo instance mới
* chỉ cho phép constructor không tham số, nếu dùng constructor có tham số sẽ tạo instance mới
* nếu value là `T[]`, chỉ reuse nếu độ dài giống nhau, ngược lại sẽ tạo instance mới
* nếu value là collection có phương thức `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) sẽ gọi Clear() và reuse, ngược lại tạo instance mới

Version tolerant
---
Ở mặc định (`GenerateType.Object`), MemoryPack hỗ trợ tiến hóa schema ở mức giới hạn.

* unmanaged struct không thể thay đổi nữa
* có thể thêm thành viên, nhưng không được xóa
* có thể đổi tên thành viên
* không thể thay đổi thứ tự thành viên
* không thể thay đổi kiểu thành viên

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Thêm thành viên thì OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Xóa thành viên thì KHÔNG được.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Đổi thứ tự thì KHÔNG được.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

Trong trường hợp sử dụng, việc lưu dữ liệu cũ (vào file, redis, v.v...) và đọc bằng schema mới luôn OK. Với RPC, schema tồn tại cả phía client và server, client phải được cập nhật trước server. Client đã cập nhật sẽ không gặp vấn đề khi kết nối với server cũ, nhưng client cũ không thể kết nối server mới.

Theo mặc định, khi dữ liệu cũ đọc bằng schema mới, các thành viên không có trong dữ liệu sẽ được khởi tạo với literal `default`.
Nếu bạn muốn tránh điều này và sử dụng giá trị khởi tạo của field/property, có thể dùng `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < nếu dữ liệu cũ thiếu, sẽ set `111`.
    
    public int Prop3 { get; set; } = 222; // < nếu dữ liệu cũ thiếu, sẽ set `default`.
}
```

 `[SuppressDefaultInitialization]` có các hạn chế sau:
- Không được dùng với readonly, init-only, và required modifier.

Phần tiếp theo [Serialization info](#serialization-info) sẽ hướng dẫn cách kiểm tra sự thay đổi schema, ví dụ bằng CI, để tránh sự cố.

Khi sử dụng `GenerateType.VersionTolerant`, sẽ hỗ trợ version-tolerant hoàn chỉnh.

* unmanaged struct không thể thay đổi nữa
* tất cả thành viên phải thêm `[MemoryPackOrder]` rõ ràng (trừ khi dùng `SerializeLayout.Sequential`)
* có thể thêm, xóa thành viên nhưng không được reuse order (có thể bỏ qua order bị thiếu)
* có thể đổi tên thành viên
* không thể thay đổi thứ tự thành viên
* không thể thay đổi kiểu thành viên

```csharp
// Có thể serialize/deserialize cả hai chiều
// VersionTolerantObject1 -> VersionTolerantObject2 và 
// VersionTolerantObject2 -> VersionTolerantObject1

[MemoryPackable(GenerateType.VersionTolerant)]
public partial class VersionTolerantObject1
{
    [MemoryPackOrder(0)]
    public int MyProperty0 { get; set; } = default;

    [MemoryPackOrder(1)]
    public long MyProperty1 { get; set; } = default;

    [MemoryPackOrder(2)]
    public short MyProperty2 { get; set; } = default;
}

[MemoryPackable(GenerateType.VersionTolerant)]
public partial class VersionTolerantObject2
{
```csharp
[MemoryPackOrder(0)]
public int MyProperty0 { get; set; } = default;

// đã xóa
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// đã thêm
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Nếu đặt SerializeLayout.Sequential một cách tường minh, sẽ cho phép tự động sắp xếp thứ tự.
// Tuy nhiên, không thể xóa bất kỳ thành viên nào đối với version-tolerant.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` chậm hơn `GenerateType.Object` khi tuần tự hóa. Ngoài ra, kích thước payload sẽ hơi lớn hơn một chút.

Thông tin tuần tự hóa
----
Bạn có thể kiểm tra trong IntelliSense các thành viên nào của kiểu dữ liệu được tuần tự hóa. Có một tùy chọn để ghi thông tin đó ra file khi biên dịch. Thiết lập `MemoryPackGenerator_SerializationInfoOutputDirectory` như sau.

```xml
<!-- xuất thông tin tuần tự hóa memorypack ra thư mục -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Thông tin sau sẽ được ghi vào file.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Nếu kiểu là unmanaged, sẽ hiển thị `unmanaged` trước tên kiểu.

```txt
unmanaged FooStruct
---
int x
int y
```

Bằng cách kiểm tra sự khác biệt trong file này, có thể ngăn chặn các thay đổi schema nguy hiểm. Ví dụ, bạn có thể sử dụng CI để phát hiện các quy tắc sau

* chỉnh sửa kiểu unmanaged
* thay đổi thứ tự thành viên
* xóa thành viên

Tham chiếu vòng lặp (Circular Reference)
---
MemoryPack cũng hỗ trợ tham chiếu vòng lặp. Điều này cho phép các đối tượng dạng cây được tuần tự hóa giữ nguyên cấu trúc.

```csharp
// để bật circular-reference, sử dụng GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 Ví dụ, đoạn code [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) sẽ trở thành như sau.

```csharp
// https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references?pivots=dotnet-7-0
Employee tyler = new()
{
    Name = "Tyler Stein"
};

Employee adrian = new()
{
    Name = "Adrian King"
};

tyler.DirectReports = new List<Employee> { adrian };
adrian.Manager = tyler;

var bin = MemoryPackSerializer.Serialize(tyler);
Employee? tylerDeserialized = MemoryPackSerializer.Deserialize<Employee>(bin);

Console.WriteLine(tylerDeserialized?.DirectReports?[0].Manager == tylerDeserialized); // true

[MemoryPackable(GenerateType.CircularReference)]
public partial class Employee
{
    [MemoryPackOrder(0)]
    public string? Name { get; set; }
    [MemoryPackOrder(1)]
    public Employee? Manager { get; set; }
    [MemoryPackOrder(2)]
    public List<Employee>? DirectReports { get; set; }
}
```

`GenerateType.CircularReference` có đặc điểm tương tự version-tolerant. Tuy nhiên, như một ràng buộc bổ sung, chỉ được phép sử dụng constructor không tham số. Ngoài ra, việc theo dõi tham chiếu đối tượng chỉ được thực hiện cho các đối tượng được đánh dấu với `GenerateType.CircularReference`. Nếu bạn muốn theo dõi đối tượng khác, hãy bọc nó lại.

CustomFormatter
---
Nếu triển khai `MemoryPackCustomFormatterAttribute<T>` hoặc `MemoryPackCustomFormatterAttribute<TFormatter, T>` (hiệu năng cao hơn, nhưng phức tạp hơn), bạn có thể cấu hình để sử dụng custom formatter cho thành viên của MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack cung cấp các thuộc tính định dạng sau: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // tuần tự hóa thành viên này dưới dạng UTF16 String, hiệu năng cao hơn UTF8 nhưng với ASCII thì kích thước lớn hơn (nhưng với non-ASCII, đôi khi lại nhỏ hơn).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Khi giải tuần tự, Dictionary được khởi tạo với StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Khi giải tuần tự, tất cả chuỗi đều được intern (xem: String.Intern). Nếu giá trị tương tự lặp lại nhiều, sẽ tiết kiệm bộ nhớ.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Để cấu hình equality comparer cho set/dictionary, tất cả các formatter tích hợp sẵn đều có overload constructor với comparer. Bạn có thể dễ dàng tạo custom equality-comparer formatter.

```csharp
public sealed class OrdinalIgnoreCaseStringDictionaryFormatter<TValue> : MemoryPackCustomFormatterAttribute<Dictionary<string, TValue?>>
{
    static readonly DictionaryFormatter<string, TValue?> formatter = new DictionaryFormatter<string, TValue?>(StringComparer.OrdinalIgnoreCase);

    public override IMemoryPackFormatter<Dictionary<string, TValue?>> GetFormatter()
    {
        return formatter;
    }
}
```

`BitPackFormatter` chỉ nén các kiểu `bool[]`. Thông thường `bool[]` được tuần tự hóa với 1 byte cho mỗi giá trị boolean, nhưng `BitPackFormatter` sẽ tuần tự hóa `bool[]` như `BitArray` lưu mỗi bool chỉ 1 bit. Khi dùng `BitPackFormatter`, 8 giá trị bool chỉ tốn 1 byte thay vì 8 byte, giảm kích thước đi 8 lần.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` dùng cho `byte[]`, ví dụ bạn có thể nén payload lớn bằng Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` dùng cho `string`, tuần tự hóa chuỗi đã nén (UTF16) bằng Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` dành cho bất kỳ kiểu dữ liệu nào, dữ liệu được nén bằng Brotli khi tuần tự hóa. Nếu kiểu dữ liệu là `byte[]` hoặc `string`, bạn nên sử dụng `BrotliFormatter` hoặc `BrotliStringFormatter` để đạt hiệu năng tốt nhất.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Giải tuần tự với array pooling
---
Để giải tuần tự một mảng lớn (bất kỳ kiểu `T` nào), MemoryPack cung cấp nhiều phương pháp pooling hiệu quả. Cách hiệu quả nhất là sử dụng chức năng [#Overwrite](#overwrite). Đặc biệt, `List<T>` luôn được tái sử dụng.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> được tái sử dụng, không cấp phát bộ nhớ mới khi giải tuần tự.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// để vận hành hiệu quả, bạn có thể lấy Span<T> bằng CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Một cách tiện lợi là giải tuần tự vào một ArrayPool tại thời điểm giải tuần tự. MemoryPack cung cấp `MemoryPoolFormatter<T>` và `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class PoolModelSample : IDisposable
{
    public int Id { get; }

    [MemoryPoolFormatter<byte>]
    public Memory<byte> Payload { get; private set; }

    public PoolModelSample(int id, Memory<byte> payload)
    {
        Id = id;
        Payload = payload;
    }

    // Bạn phải tự viết mã trả về, đây là ví dụ.

    bool usePool;

    [MemoryPackOnDeserialized]
    void OnDeserialized()
    {
        usePool = true;
    }

    public void Dispose()
    {
        if (!usePool) return;

        Return(Payload); Payload = default;
    }

    static void Return<T>(Memory<T> memory) => Return((ReadOnlyMemory<T>)memory);

    static void Return<T>(ReadOnlyMemory<T> memory)
    {
        if (MemoryMarshal.TryGetArray(memory, out var segment) && segment.Array is { Length: > 0 })
        {
            ArrayPool<T>.Shared.Return(segment.Array, clearArray: RuntimeHelpers.IsReferenceOrContainsReferences<T>());
        }
    }
}

// ---

using(var value = MemoryPackSerializer.Deserialize<PoolModelSample>(bin))
{
    // thực hiện các thao tác...
}   // trả lại ArrayPool
```

Hiệu năng
---
Xem bài viết trên blog của tôi [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Kích thước payload và nén
---
Kích thước payload phụ thuộc vào giá trị mục tiêu; không giống JSON, không có khóa và là định dạng nhị phân, do đó kích thước payload thường nhỏ hơn JSON.

Với các định dạng mã hóa varint như MessagePack và Protobuf, MemoryPack thường lớn hơn nếu sử dụng nhiều kiểu int (trong MemoryPack, int luôn chiếm 4 byte do mã hóa kích thước cố định, trong khi MessagePack là 1~5 byte).

float và double lần lượt là 4 byte và 8 byte trong MemoryPack, nhưng là 5 byte và 9 byte trong MessagePack. Do đó, MemoryPack nhỏ hơn, ví dụ với mảng Vector3 (float, float, float).

Chuỗi mặc định là UTF8, giống như các serializer khác, nhưng nếu chọn tùy chọn UTF16 thì sẽ có tính chất khác biệt.

Trong mọi trường hợp, nếu kích thước payload lớn, nên cân nhắc nén. Khuyến nghị sử dụng LZ4, ZStandard hoặc Brotli.

### Nén

MemoryPack cung cấp tiện ích hiệu quả cho nén [Brotli](https://github.com/google/brotli) thông qua [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) và [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). `BrotliCompressor` và `BrotliDecompressor` của MemoryPack cung cấp nén/giải nén tối ưu cho hành vi nội bộ của MemoryPack.

```csharp
using MemoryPack.Compression;

// Nén (cần using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Lấy mảng byte[] đã nén
var compressedBytes = compressor.ToArray();

// Hoặc ghi vào IBufferWriter<byte> khác (ví dụ PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Giải nén (cần using)
using var decompressor = new BrotliDecompressor();

// Lấy ReadOnlySequence<byte> đã giải nén từ ReadOnlySpan<byte> hoặc ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Cả `BrotliCompressor` và `BrotliDecompressor` đều là struct, không cấp phát bộ nhớ trên heap. Cả hai lưu trữ dữ liệu đã nén hoặc giải nén trong một memory pool nội bộ cho Serialize/Deserialize. Do đó, cần giải phóng memory pooling, đừng quên sử dụng `using`.

Mức độ nén rất quan trọng. Mặc định là quality-1 (CompressionLevel.Fastest), khác với mặc định của .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) sẽ gần với tốc độ của [LZ4](https://github.com/lz4/lz4), nhưng quality-4 thì chậm hơn nhiều. Điều này rất quan trọng trong kịch bản sử dụng serializer. Hãy cẩn thận khi sử dụng `BrotliStream` chuẩn (mặc định là quality-4). Trong mọi trường hợp, tốc độ nén/giải nén và kích thước sẽ rất khác nhau tùy vào dữ liệu. Vui lòng chuẩn bị dữ liệu phù hợp với ứng dụng của bạn và tự kiểm tra.

Lưu ý có sự chênh lệch tốc độ nhiều lần giữa MemoryPack không nén và MemoryPack có nén Brotli.

Brotli cũng được hỗ trợ trong custom formatter. `BrotliFormatter` có thể nén một thành viên cụ thể.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Tuần tự hóa các kiểu external
---
Nếu bạn muốn tuần tự hóa các kiểu external, bạn có thể tạo custom formatter và đăng ký vào provider, xem [Formatter/Provider API](#formatterprovider-api) để biết chi tiết. Tuy nhiên, việc tạo custom formatter là khó. Do đó, chúng tôi khuyến nghị tạo một kiểu wrapper. Ví dụ, nếu bạn muốn tuần tự hóa một kiểu external tên là `AnimationCurve`.

```csharp
// Keyframe: (float time, float inTangent, float outTangent, int tangentMode, int weightedMode, float inWeight, float outWeight)
[MemoryPackable]
public readonly partial struct SerializableAnimationCurve
{
    [MemoryPackIgnore]
    public readonly AnimationCurve AnimationCurve;

    [MemoryPackInclude]
    WrapMode preWrapMode => AnimationCurve.preWrapMode;
    [MemoryPackInclude]
    WrapMode postWrapMode => AnimationCurve.postWrapMode;
    [MemoryPackInclude]
    Keyframe[] keys => AnimationCurve.keys;

    [MemoryPackConstructor]
    SerializableAnimationCurve(WrapMode preWrapMode, WrapMode postWrapMode, Keyframe[] keys)
    {
        var curve = new AnimationCurve(keys);
        curve.preWrapMode = preWrapMode;
        curve.postWrapMode = postWrapMode;
        this.AnimationCurve = curve;
    }

    public SerializableAnimationCurve(AnimationCurve animationCurve)
    {
        this.AnimationCurve = animationCurve;
    }
}
```

Kiểu cần wrap là public, nhưng được loại trừ khỏi tuần tự hóa (`MemoryPackIgnore`). Các thuộc tính cần tuần tự hóa là private, nhưng được đưa vào (`MemoryPackInclude`). Nên chuẩn bị hai mẫu constructor. Constructor dùng cho serializer nên là private.

Tuy nhiên, như vậy thì mỗi lần đều phải wrap, khá bất tiện. Ngoài ra, struct wrapper không thể biểu diễn null. Do đó, hãy tạo một custom formatter.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity không hỗ trợ scoped và TBufferWriter nên cần đổi chữ ký thành `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
    public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref AnimationCurve? value)
    {
        if (value == null)
```csharp
{
    writer.WriteNullObjectHeader();
    return;
}

writer.WritePackable(new SerializableAnimationCurve(value));
}

public override void Deserialize(ref MemoryPackReader reader, scoped ref AnimationCurve? value)
{
    if (reader.PeekIsNull())
    {
        reader.Advance(1); // skip null block
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

Cuối cùng, đăng ký formatter trong phần khởi động.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Lưu ý: AnimationCurve của Unity mặc định đã có thể tuần tự hóa nên không cần formatter tùy chỉnh này cho AnimationCurve

Các gói (Packages)
---
MemoryPack có các gói sau.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` là thư viện chính, cung cấp đầy đủ hỗ trợ cho việc tuần tự hóa và giải tuần tự hóa nhị phân hiệu năng cao. Thư viện này phụ thuộc vào `MemoryPack.Core` cho các thư viện cơ bản và `MemoryPack.Generator` cho việc sinh mã. `MemoryPack.Streaming` bổ sung các phần mở rộng cho [Streaming Serialization](#streaming-serialization).  `MemoryPack.AspNetCoreMvcFormatter` thêm các input/output formatter cho ASP.NET Core. `MemoryPack.UnityShims` bổ sung các loại shim và formatter cho Unity để chia sẻ kiểu giữa .NET và Unity.

TypeScript và ASP.NET Core Formatter
---
MemoryPack hỗ trợ sinh mã TypeScript. Nó sinh class và mã tuần tự hóa từ C#, nói cách khác, bạn có thể chia sẻ kiểu dữ liệu với trình duyệt mà không cần dùng OpenAPI, proto, v.v.

Việc sinh mã tích hợp với Source Generator, các tùy chọn sau (`MemoryPackGenerator_TypeScriptOutputDirectory`) sẽ thiết lập thư mục xuất mã TypeScript. Mã runtime sẽ được xuất đồng thời, vì vậy không cần thêm bất kỳ phụ thuộc nào khác.

```xml
<!-- xuất mã memorypack TypeScript vào thư mục -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Một kiểu MemoryPackable C# phải được gắn chú thích `[GenerateTypeScript]`.

```csharp
[MemoryPackable]
[GenerateTypeScript]
public partial class Person
{
    public required Guid Id { get; init; }
    public required int Age { get; init; }
    public required string FirstName { get; init; }
    public required string LastName { get; init; }
    public required DateTime DateOfBirth { get; init; }
    public required Gender Gender { get; init; }
    public required string[] Emails { get; init; }
}

public enum Gender
{
    Male, Female, Other
}
```

Mã runtime và kiểu TypeScript sẽ được sinh ra trong thư mục đích.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Mã được sinh ra như sau, với các trường đơn giản và các phương thức tĩnh cho serialize/serializeArray và deserialize/deserializeArray.

```typescript
import { MemoryPackWriter } from "./MemoryPackWriter.js";
import { MemoryPackReader } from "./MemoryPackReader.js";
import { Gender } from "./Gender.js"; 

export class Person {
    id: string;
    age: number;
    firstName: string | null;
    lastName: string | null;
    dateOfBirth: Date;
    gender: Gender;
    emails: (string | null)[] | null;

    constructor() {
        // snip...
    }

    static serialize(value: Person | null): Uint8Array {
        // snip...
    }

    static serializeCore(writer: MemoryPackWriter, value: Person | null): void {
        // snip...
    }

    static serializeArray(value: (Person | null)[] | null): Uint8Array {
        // snip...
    }

    static serializeArrayCore(writer: MemoryPackWriter, value: (Person | null)[] | null): void {
        // snip...
    }
    static deserialize(buffer: ArrayBuffer): Person | null {
        // snip...
    }

    static deserializeCore(reader: MemoryPackReader): Person | null {
        // snip...
    }

    static deserializeArray(buffer: ArrayBuffer): (Person | null)[] | null {
        // snip...
    }

    static deserializeArrayCore(reader: MemoryPackReader): (Person | null)[] | null {
        // snip...
    }
}
```

Bạn có thể sử dụng kiểu này như sau.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// tuần tự hóa thành Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// giải tuần tự từ ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Gói `MemoryPack.AspNetCoreMvcFormatter` bổ sung input và output formatter `MemoryPack` cho ASP.NET Core MVC. Bạn có thể thêm `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` vào ASP.NET Core MVC với đoạn mã sau.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Nếu checkContentType: true thì có thể output nhiều định dạng (JSON/MemoryPack, v.v...). Mặc định là false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Nếu bạn gọi từ HttpClient, bạn có thể thiết lập `application/x-memorypack` cho content-header.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Ánh xạ kiểu TypeScript

Có một vài hạn chế về các kiểu có thể sinh ra. Trong các kiểu nguyên thủy, `char` và `decimal` không được hỗ trợ. Ngoài ra, không thể sử dụng kiểu OpenGenerics.

|  C#  |  TypeScript  | Mô tả |
| ---- | ---- | ---- |
| `bool` |  `boolean`  |
| `byte` |  `number`  |
| `sbyte` |  `number`  |
| `int` |  `number` |
| `uint` |  `number` |
| `short` |  `number` |
| `ushort` |  `number` |
| `long` |  `bigint` |
```
| `ulong` |  `bigint` |
| `float` |  `number` |
| `double` |  `number` |
| `string` |  `string \| null`  | 
| `Guid` |  `string`  | Trong TypeScript, thể hiện dưới dạng chuỗi nhưng tuần tự hóa/giải tuần tự dưới dạng nhị phân 16 byte
| `DateTime` | `Date` | DateTimeKind sẽ bị bỏ qua
| `enum` | `const enum` | Kiểu nền `long` và `ulong` không được hỗ trợ
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Hỗ trợ tất cả các kiểu triển khai `ICollection<T>` như `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Hỗ trợ tất cả các kiểu triển khai `ISet<T>` như `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Hỗ trợ tất cả các kiểu triển khai `IDictionary<K,V>` như `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Chỉ hỗ trợ class
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` chỉ có thể áp dụng cho class và hiện tại chưa hỗ trợ cho struct.

### Cấu hình phần mở rộng file import và kiểu đặt tên thành viên

Mặc định, MemoryPack tạo phần mở rộng file là `.js` như `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Nếu bạn muốn thay đổi phần mở rộng khác hoặc để trống, hãy sử dụng `MemoryPackGenerator_TypeScriptImportExtension` để cấu hình.
Ngoài ra, tên thành viên sẽ tự động được chuyển sang camelCase. Nếu bạn muốn giữ nguyên tên gốc, đặt `MemoryPackGenerator_TypeScriptConvertPropertyName` thành `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- cho phép để trống -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- mặc định là true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- mặc định là false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` cho phép chú thích nullable của C# được phản ánh vào mã TypeScript. Mặc định là false, làm cho mọi thứ đều có thể null.

Streaming Serialization
---
`MemoryPack.Streaming` cung cấp `MemoryPackStreamingSerializer`, bổ sung hỗ trợ cho việc tuần tự hóa và giải tuần tự hóa các collection với stream.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

Formatter/Provider API
---
Nếu bạn muốn tự triển khai formatter, kế thừa `MemoryPackFormatter<T>` và override các phương thức `Serialize` và `Deserialize`.

```csharp
public class SkeltonFormatter : MemoryPackFormatter<Skelton>
{
    public override void Serialize<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, scoped ref Skelton? value)
    {
        if (value == null)
        {
            writer.WriteNullObjectHeader();
            return;
        }

        // sử dụng phương thức của writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // sử dụng phương thức của reader.
    }
}
```
Formatter vừa tạo sẽ được đăng ký với `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Lưu ý: `unmanged struct` (không chứa kiểu tham chiếu) không thể sử dụng custom formatter, nó luôn tuần tự hóa theo cấu trúc bộ nhớ gốc.

MemoryPackWriter/ReaderOptionalState
---
Khởi tạo `MemoryPackWriter`/`MemoryPackReader` cần OptionalState. Đây là wrapper của `MemoryPackSerializerOptions`, có thể tạo từ `MemoryPackWriterOptionalStatePool`.

```csharp
// khi dispose, OptionalState sẽ trả về pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// cho Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Phụ thuộc framework mục tiêu
---
MemoryPack cung cấp `netstandard2.1` và `net7.0` nhưng cả hai không tương thích với nhau. Ví dụ, các kiểu MemoryPackable dưới project `netstandard2.1` và sử dụng từ project `net7.0` sẽ ném ra ngoại lệ runtime như sau

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Vì net7.0 sử dụng static abstract members (`Virtual static method`), điều này không được hỗ trợ bởi netstandard2.1, đây là hành vi theo đặc tả.

Project .NET 7 không nên sử dụng dll netstandard 2.1. Nói cách khác, nếu ứng dụng là dự án .NET 7, tất cả các phụ thuộc sử dụng MemoryPack phải hỗ trợ .NET 7. Vì vậy, nếu nhà phát triển thư viện phụ thuộc vào MemoryPack, bạn cần cấu hình dual target framework.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) là framework grpc-dotnet code-first sử dụng MessagePack thay vì protobuf. MagicOnion hiện đã hỗ trợ MemoryPack như một lớp tuần tự hóa qua package `MagicOnion.Serialization.MemoryPack` (bản preview). Xem chi tiết: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Phiên bản Unity tối thiểu được hỗ trợ là `2022.3.12f1`.

Gói core `MemoryPack` được cung cấp qua nuget. Nó cũng có sẵn cho Unity. Nếu bạn muốn có hỗ trợ kiểu dựng sẵn của Unity, chúng tôi còn cung cấp thêm extension MemoryPack.Unity.

1. Cài đặt `MemoryPack` từ NuGet bằng [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Mở cửa sổ từ NuGet -> Manage NuGet Packages, tìm kiếm "MemoryPack" và nhấn Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Nếu bạn gặp lỗi conflict version, vui lòng tắt xác thực version trong Player Settings (Edit -> Project Settings -> Player -> Kéo xuống và mở rộng "Other Settings" sau đó bỏ chọn "Assembly Version Validation" trong phần "Configuration").

2. Cài đặt package `MemoryPack.Unity` bằng cách tham chiếu git URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack sử dụng tag phát hành *.*.*, bạn có thể chỉ định phiên bản như #1.0.0. Ví dụ: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Tương tự phiên bản .NET, mã được sinh bởi code generator (`MemoryPack.Generator.dll`). Triển khai không dùng reflection cũng mang lại hiệu năng tốt nhất cho IL2CPP.

Để biết thêm thông tin về Unity và Source Generator, vui lòng tham khảo [Unity documentation](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator cũng được Unity sử dụng chính thức qua [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) và [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Nói cách khác, đây là tiêu chuẩn cho sinh mã trong Unity thế hệ kế tiếp.

Bạn có thể tuần tự hóa tất cả các kiểu unmanaged (như `Vector3`, `Rect`, v.v...) và một số class (`AnimationCurve`, `Gradient`, `RectOffset`). Nếu bạn muốn tuần tự hóa các kiểu đặc thù khác của Unity, xem phần [Serialize external types](#serialize-external-types).

Về hiệu năng Unity, MemoryPack nhanh hơn JsonUtility khoảng x3~x10 lần.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Nếu mã dùng chung có kiểu của Unity (`Vector2`, v.v...), MemoryPack cung cấp gói `MemoryPack.UnityShims` trên NuGet.

Gói `MemoryPack.UnityShims` cung cấp các shim cho các struct chuẩn của Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) và một số class (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Hiện tại có các giới hạn sau khi sử dụng trong Unity


1. Phiên bản Unity không hỗ trợ CustomFormatter.
2. Nếu bạn đang sử dụng .NET7 trở lên, định dạng nhị phân của MemoryPack không hoàn toàn tương thích với Unity.
    - Vấn đề này xảy ra với các kiểu value mà `[StructLayout(LayoutKind.Auto)]` được chỉ định rõ ràng. (Mặc định cho struct là `LayoutKind.Sequencial`.) Với các kiểu này, nhị phân được tuần tự hóa trong .NET sẽ không giải tuần tự được ở Unity. Tương tự, nhị phân tuần tự hóa ở Unity sẽ không tuần tự hóa được ở phía .NET.
    - Các kiểu bị ảnh hưởng thường bao gồm những kiểu sau.
        - `DateTimeOffset`
        - `ValueTuple`
    - Hiện tại, giải pháp đơn giản là không sử dụng các kiểu này.


Native AOT
---
Đáng tiếc, .NET 7 Native AOT sẽ gây crash (`Generic virtual method pointer lookup failure`) khi sử dụng MemoryPack do bug runtime. 
Sẽ được sửa trong .NET 8. Sử dụng bản preview của ``Microsoft.DotNet.ILCompiler`` sẽ khắc phục trên .NET 7. Vui lòng xem [bình luận của issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) để biết cách thiết lập.

Đặc tả định dạng nhị phân wire
---
Kiểu `T` được định nghĩa trong `Serialize<T>` và `Deserialize<T>` được gọi là schema C#. Định dạng MemoryPack không phải là định dạng tự mô tả. Giải tuần tự hóa cần schema C# tương ứng. Các kiểu này tồn tại như biểu diễn nội bộ của nhị phân, nhưng không thể xác định kiểu nếu không có schema C#.

Endian phải là `Little Endian`. Tuy nhiên, bản C# tham chiếu không quan tâm đến endianness nên không thể dùng trên máy big-endian. Tuy nhiên, các máy tính hiện đại thường là little-endian.

Có tám loại định dạng.

* Unmanaged struct
* Object
* Version Tolerant Object
* Đối tượng Tham chiếu Vòng lặp (Circular Reference Object)
* Tuple
* Collection
* Chuỗi (String)
* Union

### struct không quản lý (Unmanaged struct)

Unmanaged struct là struct trong C# không chứa các kiểu tham chiếu, có ràng buộc tương tự như [kiểu không quản lý trong C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Việc tuần tự hóa sẽ giữ nguyên bố cục struct, bao gồm cả phần đệm (padding).

### Đối tượng (Object)

`(byte memberCount, [values...])`

Đối tượng có 1 byte không dấu ở phần đầu để biểu diễn số lượng thành viên. Số lượng thành viên cho phép từ `0` đến `249`, `255` biểu diễn đối tượng là `null`. Các giá trị lưu trữ giá trị memorypack cho số lượng thành viên tương ứng.

### Đối tượng chịu được phiên bản (Version Tolerant Object)

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Đối tượng chịu được phiên bản tương tự như Đối tượng nhưng có thêm chiều dài tính theo byte của các giá trị ở phần header. varint tuân theo quy tắc sau: sbyte đầu tiên là giá trị hoặc typeCode, và X byte tiếp theo là giá trị. 0 đến 127 = giá trị unsigned byte, -1 đến -120 = giá trị signed byte, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Đối tượng Tham chiếu Vòng lặp (Circular Reference Object)

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Đối tượng Tham chiếu Vòng lặp tương tự như Đối tượng chịu được phiên bản, nhưng nếu memberCount là 250, varint(unsigned-int32) tiếp theo là referenceId. Nếu không, sau phần byte-length-of-values, varint referenceId sẽ được ghi.

### Tuple

`(values...)`

Tuple là một tập hợp giá trị cố định, không thể là null. Trong .NET, `KeyValuePair<TKey, TValue>` và `ValueTuple<T,...>` được tuần tự hóa dưới dạng Tuple.

### Collection

`(int length, [values...])`

Collection có một số nguyên 4 byte có dấu ở phần header đại diện cho số lượng dữ liệu, `-1` biểu diễn `null`. Các giá trị lưu trữ giá trị memorypack cho số lượng phần tử tương ứng với length.

### Chuỗi (String)

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

Chuỗi có hai dạng, UTF16 và UTF8. Nếu số nguyên 4 byte đầu tiên là `-1`, biểu diễn null. `0`, biểu diễn chuỗi rỗng. UTF16 giống như collection (tuần tự hóa như `ReadOnlySpan<char>`, số byte của utf16-value là utf16-length * 2). Nếu số nguyên đầu tiên <= `-2`, giá trị được mã hóa bằng UTF8. utf8-byte-count được mã hóa ở dạng bù, sử dụng `~utf8-byte-count` để lấy số byte. Số nguyên tiếp theo là utf16-length, cho phép giá trị `-1` để biểu diễn độ dài không xác định. utf8-bytes lưu trữ các byte với số lượng là utf8-byte-count.

### Union

`(byte tag, value)`  
`(250, ushort tag, value)`

Byte không dấu đầu tiên là tag dùng cho kiểu giá trị phân biệt hoặc cờ, `0` đến `249` biểu diễn tag, `250` biểu diễn unsigned short tiếp theo là tag, `255` biểu diễn union là `null`.

Giấy phép
---
Thư viện này được cấp phép theo Giấy phép MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---