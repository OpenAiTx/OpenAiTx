# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

C# 與 Unity 的零編碼極致效能二進位序列化器。

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> 與 [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json)、[protobuf-net](https://github.com/protobuf-net/protobuf-net)、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)、[Orleans.Serialization](https://github.com/dotnet/orleans/) 的比較。於 .NET 7 / Ryzen 9 5950X 機器上測量。這些序列化器都有 `IBufferWriter<byte>` 方法，使用 `ArrayBufferWriter<byte>` 進行序列化並重複利用以避免計算緩衝區複製的時間。

對於標準物件，MemoryPack 的速度比其他二進位序列化器快上 10 倍，約為其他序列化器的 2 至 5 倍。對於結構體陣列，MemoryPack 的效能更為卓越，速度高達其他序列化器的 50 至 200 倍。

MemoryPack 是我開發的第四個序列化器，過去我已創建了知名的序列化器，~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~、~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)。MemoryPack 之所以能有如此速度，是因為它採用了專為 C# 優化的二進位格式，並根據我過去的經驗進行精心調校的實作。這也是一個全新設計，利用 .NET 7 與 C# 11 以及增量原始碼產生器（.NET Standard 2.1（.NET 5, 6）也有支援，並提供 Unity 支援）。

其他序列化器會執行許多編碼操作，例如 VarInt 編碼、標籤、字串等。MemoryPack 格式採用零編碼設計，盡可能直接複製 C# 記憶體。零編碼類似於 FlatBuffers，但無需特殊型別，MemoryPack 的序列化目標是 POCO。

除了效能外，MemoryPack 還具有以下特點：

* 支援現代化 I/O API（`IBufferWriter<byte>`、`ReadOnlySpan<byte>`、`ReadOnlySequence<byte>`）
* 原生 AOT 友善的基於原始碼產生器的程式碼產生，無動態程式碼產生（IL.Emit）
* 無反射、非泛型 API
* 可反序列化到既有實例
* 多型（聯集）序列化
* 支援有限版本容錯（快速/預設）與完整版本容錯
* 支援循環參照序列化
* 基於 PipeWriter/Reader 的串流序列化
* TypeScript 程式碼產生與 ASP.NET Core Formatter
* Unity（2021.3）IL2CPP 支援，透過 .NET 原始碼產生器

安裝方式
---
此函式庫可經由 NuGet 發佈。為獲得最佳效能，建議使用 `.NET 7`。最低需求為 `.NET Standard 2.1`。

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

此外，程式碼編輯器需支援 Roslyn 4.3.1，例如 Visual Studio 2022 17.3 版、.NET SDK 6.0.401。詳情請參閱 [Roslyn 版本支援](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) 文件。

Unity 的需求與安裝流程完全不同。請參閱 [Unity](#unity) 章節了解詳情。

快速開始
---
定義要序列化的 struct 或 class，並標註 `[MemoryPackable]` 屬性與 `partial` 關鍵字。

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

序列化程式碼由 C# 原始碼產生器功能自動產生，實作 `IMemoryPackable<T>` 介面。在 Visual Studio 中，可於類別名稱按下快捷鍵 `Ctrl+K, R` 並選擇 `*.MemoryPackFormatter.g.cs` 以檢視產生的程式碼。

呼叫 `MemoryPackSerializer.Serialize<T>/Deserialize<T>` 來序列化/反序列化物件實例。

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` 方法支援回傳型別為 `byte[]`，同時也能序列化到 `IBufferWriter<byte>` 或 `Stream`。`Deserialize` 方法支援 `ReadOnlySpan<byte>`、`ReadOnlySequence<byte>` 及 `Stream`。也有非泛型版本可用。

內建支援的型別
---
這些型別預設即可序列化：

* .NET 原始型別（`byte`、`int`、`bool`、`char`、`double` 等）
* 非託管型別（任意 `enum`，任何不含參考型別的自訂 `struct`）
* `string`、`decimal`、`Half`、`Int128`、`UInt128`、`Guid`、`Rune`、`BigInteger`
* `TimeSpan`、`DateTime`、`DateTimeOffset`、`TimeOnly`、`DateOnly`、`TimeZoneInfo`
* `Complex`、`Plane`、`Quaternion`、`Matrix3x2`、`Matrix4x4`、`Vector2`、`Vector3`、`Vector4`
* `Uri`、`Version`、`StringBuilder`、`Type`、`BitArray`、`CultureInfo`
* `T[]`、`T[,]`、`T[,,]`、`T[,,,]`、`Memory<>`、`ReadOnlyMemory<>`、`ArraySegment<>`、`ReadOnlySequence<>`
* `Nullable<>`、`Lazy<>`、`KeyValuePair<,>`、`Tuple<,...>`、`ValueTuple<,...>`
* `List<>`、`LinkedList<>`、`Queue<>`、`Stack<>`、`HashSet<>`、`SortedSet<>`、`PriorityQueue<,>`
* `Dictionary<,>`、`SortedList<,>`、`SortedDictionary<,>`、`ReadOnlyDictionary<,>` 
* `Collection<>`、`ReadOnlyCollection<>`、`ObservableCollection<>`、`ReadOnlyObservableCollection<>`
* `IEnumerable<>`、`ICollection<>`、`IList<>`、`IReadOnlyCollection<>`、`IReadOnlyList<>`、`ISet<>`
* `IDictionary<,>`、`IReadOnlyDictionary<,>`、`ILookup<,>`、`IGrouping<,>`,
* `ConcurrentBag<>`、`ConcurrentQueue<>`、`ConcurrentStack<>`、`ConcurrentDictionary<,>`、`BlockingCollection<>`
* 不變集合（`ImmutableList<>` 等）與介面（`IImmutableList<>` 等）

定義 `[MemoryPackable]` 的 `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` 可標註於任何 `class`、`struct`、`record`、`record struct` 與 `interface`。如果型別是 `struct` 或 `record struct` 且不含參考型別（[C# 非託管型別](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)），任何額外註記（忽略、包含、建構函式、回呼）都不會被使用，直接從記憶體進行序列化/反序列化。

否則，預設情況下，`[MemoryPackable]` 會序列化公開實例屬性或欄位。可使用 `[MemoryPackIgnore]` 排除序列化目標，`[MemoryPackInclude]` 則可將私有成員提升為序列化目標。

```csharp
[MemoryPackable]
public partial class Sample
{
    // 這些型別預設會被序列化
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // 這些型別預設不會被序列化
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // 使用 [MemoryPackIgnore] 移除公開成員的序列化目標
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // 使用 [MemoryPackInclude] 將私有成員提升為序列化目標
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack` 的程式碼產生器會將哪些成員被序列化的資訊加入 `<remarks />` 區段。可於 Intellisense 懸停型別時檢視。

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

所有成員必須可被 MemoryPack 序列化，否則程式碼產生器會拋出錯誤。

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack 共有 35 條診斷規則（`MEMPACK001` 到 `MEMPACK035`），讓你可以舒適地定義型別。

如果目標型別已於外部定義 MemoryPack 序列化並已註冊，請使用 `[MemoryPackAllowSerialize]` 以消除診斷警告。

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

成員順序**很重要**，MemoryPack 不會序列化成員名稱或其他資訊，而是依照宣告順序序列化欄位。如果型別有繼承，則會依父類→子類順序序列化。成員順序在反序列化時不可更動。關於架構演進，請參閱 [版本容錯](#version-tolerant) 章節。

預設順序為連續，但你可以使用 `[MemoryPackable(SerializeLayout.Explicit)]` 及 `[MemoryPackOrder()]` 選擇明確佈局。

```csharp
// 依序序列化 Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### 建構函式選擇

MemoryPack 支援具參數與無參數建構函式。建構函式的選擇遵循下列規則（適用於 class 與 struct）。

* 若有 `[MemoryPackConstructor]`，則使用它。
* 若無任何明確建構函式（包含私有），則使用無參數建構函式。
* 若僅有一個無參數/具參數建構函式（包含私有），則使用它。
* 若有多個建構函式，則必須於欲使用的建構函式上標註 `[MemoryPackConstructor]`（產生器不會自動選擇），否則產生器會拋出錯誤。
* 若使用具參數建構函式，所有參數名稱必須與對應成員名稱相符（不區分大小寫）。

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // 可以使用具參數建構函式—參數名稱需與對應成員名稱相符（不區分大小寫）
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// 也支援 record 主建構函式
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
// 如果有多個建構函式，則應使用 [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### 序列化回呼

在序列化/反序列化時，MemoryPack 可以透過 `[MemoryPackOnSerializing]`、`[MemoryPackOnSerialized]`、`[MemoryPackOnDeserializing]`、`[MemoryPackOnDeserialized]` 屬性呼叫序列化前/後事件。這些屬性可以標註在 static 與 instance（非 static）的方法上，且無論 public 或 private 方法皆可。

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // 方法呼叫順序為 static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // 也允許 private 方法
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

    // 注意：instance 方法搭配 MemoryPackOnDeserializing，若 instance 未以 `ref` 傳遞則不會被呼叫
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

回呼允許無參數方法以及 `ref reader/writer, ref T value` 方法。例如，ref 回呼可以在序列化流程前寫入/讀取自訂標頭。

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, 使用 where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // 在標頭寫入 GUID。
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // 在反序列化前讀取自訂標頭
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

如果對 `ref value` 設定值，就可以變更用於序列化/反序列化的實例。例如，從 ServiceProvider 實體化。

```csharp
// 在使用此 formatter 前，請先設定 ServiceProvider
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

自訂集合定義
---
預設情況下，被標註為 `[MemoryPackObject]` 的型別會嘗試序列化其成員。不過，如果型別為集合（`ICollection<>`、`ISet<>`、`IDictionary<,>`），請使用 `GenerateType.Collection` 來正確進行序列化。

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

靜態建構函式
---
MemoryPackable 類別不能定義靜態建構函式，因為產生的 partial class 會使用它。你可以改為定義 `static partial void StaticConstructor()` 來達到相同效果。

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

多型（Union）
---
MemoryPack 支援介面與抽象類別的多型序列化。在 MemoryPack 中，此功能稱為 Union。僅允許介面與抽象類別標註 `[MemoryPackUnion]` 屬性，且必須指定唯一的 union 標籤。

```csharp
// 標註 [MemoryPackable] 及繼承型別 [MemoryPackUnion]
// Union 也支援抽象類別
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

// 以介面型別序列化。
var bin = MemoryPackSerializer.Serialize(data);

// 以介面型別反序列化。
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

`tag` 允許 `0` ~ `65535`，其中小於 `250` 時效率特別高。
```
如果介面與其衍生型別分屬於不同的組件，則可以改用 `MemoryPackUnionFormatterAttribute`。格式化器會自動產生，並透過 C# 9.0 及以上版本的 `ModuleInitializer` 自動註冊。

> 請注意，Unity 不支援 `ModuleInitializer`，因此必須手動註冊格式化器。要註冊您的 union 格式化器，請在啟動時手動呼叫 `{您的 union 格式化器名稱}Initializer.RegisterFormatter()`。例如 `UnionSampleFormatterInitializer.RegisterFormatter()`。

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB 在目標型別之外定義
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union 也可以透過 `DynamicUnionFormatter<T>` 在程式碼中組裝。

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

序列化 API
---
`Serialize` 有三種多載。

```csharp
// 也有非泛型 API，這個版本的第一個參數是 Type，第二個參數是 object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

為了效能，建議使用 `BufferWriter` 的 API。這會直接序列化到緩衝區。它可以應用於 `System.IO.Pipelines` 的 `PipeWriter`、ASP .NET Core 的 `BodyWriter` 等。

如果需要 `byte[]`（例如 [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) 中的 `RedisValue`），回傳 `byte[]` 的 API 也簡單且幾乎一樣快。

請注意，針對 `Stream` 的 `SerializeAsync` 僅在 Flush 時是非同步的；它會一次性將所有內容序列化到 MemoryPack 的內部緩衝池，然後使用 `WriteAsync` 寫出。因此，分離並控制緩衝區與 flush 的 `BufferWriter` 多載會更好。

如果您想要完整的串流寫入，請參閱 [Streaming Serialization](#streaming-serialization) 章節。

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` 用來設定字串序列化時要使用 UTF16 還是 UTF8。可以傳入 `MemoryPackSerializerOptions.Utf8` 代表 UTF8 編碼、`MemoryPackSerializerOptions.Utf16` 代表 UTF16 編碼，或是 `MemoryPackSerializerOptions.Default`（預設為 UTF8）。傳入 null 或使用預設參數時也是 UTF8 編碼。

因為 C# 內部的字串表示為 UTF16，所以使用 UTF16 會有更好的效能。但產生的資料量通常比較大；在 UTF8 下，ASCII 字元是一個位元組，UTF16 則是兩個位元組。由於這個容量差異很大，所以預設使用 UTF8。

如果資料為非 ASCII（例如日文，可能超過 3 個位元組，UTF8 反而更大），或是需要另外壓縮，則使用 UTF16 可能會有更好的結果。

雖然在序列化時可以選擇 UTF8 或 UTF16，但在反序列化時不需要指定，會自動偵測並正常還原。

此外，您可以從 options 中取得/設定 `IServiceProvider? ServiceProvider { get; init; }`。這對於在序列化過程中（`MemoryPackReader/MemoryPackWriter` 有 .Options 屬性）獲取 DI 物件（例如 `ILogger<T>`）很有用。

反序列化 API
---
`Deserialize` 支援 `ReadOnlySpan<byte>`、`ReadOnlySequence<byte>`、`Stream` 多載以及 `ref` 支援。

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` 多載會覆蓋現有的實例，詳細說明請參閱 [Overwrite](#overwrite) 章節。

`DeserializeAsync(Stream)` 並不是完整的串流讀取操作，會先將資料讀入 MemoryPack 的內部緩衝池直到結束，再進行反序列化。

如果您需要完整的串流讀取操作，請參閱 [Streaming Serialization](#streaming-serialization) 章節。

Overwrite（覆蓋）
---
為了減少配置（allocation），MemoryPack 支援將資料反序列化到現有實例上，覆蓋其內容。這可以透過 `Deserialize(ref T? value)` 多載來使用。

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// 將資料覆蓋到現有實例。
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack 會盡可能進行覆蓋，但如果下列條件不符合，則會建立新實例（如同一般反序列化）：

* ref 變數（包括物件圖中的成員）為 null 時，會建立新實例
* 只允許無參數建構函式，若使用有參數建構函式則會建立新實例
* 若 value 為 `T[]`，只有長度相同時才重用，否則建立新實例
* 若 value 為具有 `.Clear()` 方法的集合（如 `List<>`、`Stack<>`、`Queue<>`、`LinkedList<>`、`HashSet<>`、`PriorityQueue<,>`、`ObservableCollection`、`Collection`、`ConcurrentQueue<>`、`ConcurrentStack<>`、`ConcurrentBag<>`、`Dictionary<,>`、`SortedDictionary<,>`、`SortedList<,>`、`ConcurrentDictionary<,>`），會呼叫 Clear() 並重用，否則建立新實例

版本容錯
---
在預設（`GenerateType.Object`）情境下，MemoryPack 支援有限的 schema 演進。

* unmanaged 結構體不允許變更
* 成員可新增，但不可刪除
* 可以變更成員名稱
* 不可變更成員順序
* 不可變更成員型別

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 新增成員 OK。
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// 移除成員 NG。
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 變更順序 NG。
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

在實際應用中，儲存舊資料（如檔案、redis 等）並用新 schema 讀取是沒問題的。在 RPC 場景下，schema 同時存在於 client 與 server，必須先升級 client。升級後的 client 連舊 server 沒問題，但舊 client 不能連新的 server。

預設情況下，當舊資料被新 schema 讀取時，資料端不存在的成員會以 `default` 字面值初始化。
如果想避免這種情況、而使用欄位/屬性的初始值，可以使用 `[SuppressDefaultInitialization]`。

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < 若舊資料缺少此欄位，設為 `111`。
    
    public int Prop3 { get; set; } = 222; // < 若舊資料缺少此欄位，設為 `default`。
}
```

`[SuppressDefaultInitialization]` 有以下限制：
- 不能用於 readonly、init-only 和 required 修飾詞。

下一節 [Serialization info](#serialization-info) 說明如何透過 CI 等檢查 schema 變更，以避免意外。

當使用 `GenerateType.VersionTolerant` 時，則支援完整版本容錯。

* unmanaged 結構體不能再變更
* 所有成員都必須明確加上 `[MemoryPackOrder]`（除非加上 `SerializeLayout.Sequential` 註記）
* 成員可新增、可刪除但不可重複使用順序（可使用缺失的順序）
* 可以變更成員名稱
* 不可變更成員順序
* 不可變更成員型別

```csharp
// 可以互相序列化/反序列化
// VersionTolerantObject1 -> VersionTolerantObject2 與
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

// deleted
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// added
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// 如果明確設定 SerializeLayout.Sequential，則允許自動排序。
// 但這將無法移除任何成員以支援版本容忍。
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` 在序列化時比 `GenerateType.Object` 慢。此外，資料負載大小也會略大。

序列化資訊
----
你可以在型別的 IntelliSense 中檢查有哪些成員被序列化。也可以選擇在編譯時將這些資訊寫入檔案。請如下設定 `MemoryPackGenerator_SerializationInfoOutputDirectory`。

```xml
<!-- 輸出 memorypack 序列化資訊至目錄 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

以下資訊將被寫入檔案。

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

如果型別是 unmanaged，則會在型別名稱前顯示 `unmanaged`。

```txt
unmanaged FooStruct
---
int x
int y
```

藉由檢查此檔案中的差異，可以防止危險的架構變更。例如，你可能希望在 CI 中偵測以下規則

* 修改 unmanaged 型別
* 成員順序變更
* 成員刪除

循環參考
---
MemoryPack 也支援循環參考。這允許樹狀物件可直接序列化。

```csharp
// 要啟用循環參考，請使用 GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

舉例來說，[System.Text.Json preserve-references](https://learn.microsoft.com/zh-tw/dotnet/standard/serialization/system-text-json/preserve-references) 的程式碼將如下所示。

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

`GenerateType.CircularReference` 與 version-tolerant 具有相同的特性。不過，作為額外限制，只允許無參數建構函式。此外，物件參考追蹤僅針對標記有 `GenerateType.CircularReference` 的物件進行。如果你想追蹤其他物件，請將其包裝。

CustomFormatter
---
如果實作 `MemoryPackCustomFormatterAttribute<T>` 或 `MemoryPackCustomFormatterAttribute<TFormatter, T>`（效能更佳，但較複雜），你可以設定 MemoryPackObject 成員使用自訂 formatter。

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack 提供以下格式化屬性：`Utf8StringFormatterAttribute`、`Utf16StringFormatterAttribute`、`InternStringFormatterAttribute`、`OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`、`BitPackFormatterAttribute`、`BrotliFormatter`、`BrotliStringFormatter`、`BrotliFormatter<T>`、`MemoryPoolFormatter<T>`、`ReadOnlyMemoryPoolFormatter<T>`。

```csharp
[MemoryPackable]
public partial class Sample
{
    // 將此成員序列化為 UTF16 字串，效能優於 UTF8，但在 ASCII 狀況下，大小較大（但非 ASCII，有時較小）。
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // 反序列化時，Dictionary 以 StringComparer.OrdinalIgnoreCase 初始化。
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // 反序列化時，所有字串皆會 intern（參見：String.Intern）。如果有相似的值重複出現，可以節省記憶體。
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

為了設定集合/字典的 equality comparer，所有內建 formatter 都有 comparer 建構子重載。你也可以輕鬆建立自訂的 equality-comparer formatter。

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

`BitPackFormatter` 僅壓縮 `bool[]` 類型。`bool[]` 一般會以每個布林值 1 byte 進行序列化，但 `BitPackFormatter` 會像 `BitArray` 一樣，將每個 bool 以 1 bit 儲存。使用 `BitPackFormatter`，8 個 bool 只需 1 byte，原本需 8 byte，大小縮小 8 倍。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` 用於 `byte[]`，例如你可以用 Brotli 壓縮大型資料負載。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` 用於 `string`，將字串（UTF16）以 Brotli 壓縮後序列化。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` 適用於任何型別，其序列化資料會經過 Brotli 壓縮。如果型別是 `byte[]` 或 `string`，建議為了效能使用 `BrotliFormatter` 或 `BrotliStringFormatter`。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

反序列化陣列池化
---
為了反序列化大量陣列（任何 `T`），MemoryPack 提供多種高效的池化方法。最有效的方式是使用 [#Overwrite](#overwrite) 功能。特別是 `List<T>` 會始終被重複使用。

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> 會被重複使用，反序列化時不會分配新的記憶體。
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// 為了高效操作，你可以透過 CollectionsMarshal 取得 Span<T>
var span = CollectionsMarshal.AsSpan(value.Payload);
```

一個方便的方法是在反序列化時將資料反序列化至 ArrayPool。MemoryPack 提供 `MemoryPoolFormatter<T>` 和 `ReadOnlyMemoryPoolFormatter<T>`。

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

    // 必須自行撰寫歸還程式碼，以下為範例片段。

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
    // 執行任何操作...
}   // 歸還至 ArrayPool
```

效能
---
請參閱我的部落格文章 [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

負載大小與壓縮
---
負載大小取決於目標值；不像 JSON，有鍵值對，MemoryPack 為二進位格式，因此負載大小通常會比 JSON 小。

對於具有 varint 編碼的格式（如 MessagePack 和 Protobuf），若大量使用 int，MemoryPack 的資料量通常較大（因為 MemoryPack 中 int 一律為固定 4 bytes，而 MessagePack 為 1~5 bytes）。

在 MemoryPack 中，float 與 double 分別為 4 bytes 與 8 bytes，而 MessagePack 則為 5 bytes 與 9 bytes。因此對於 Vector3（float, float, float）陣列等情境，MemoryPack 會更小。

字串預設為 UTF8，這與其他序列化器類似，但若選擇 UTF16 選項，則會有不同性質。

無論如何，若負載較大，應考慮進行壓縮。建議使用 LZ4、ZStandard 及 Brotli。

### 壓縮

MemoryPack 針對 [Brotli](https://github.com/google/brotli) 壓縮提供高效輔助工具，透過 [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) 與 [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder)。MemoryPack 的 `BrotliCompressor` 與 `BrotliDecompressor` 提供針對 MemoryPack 內部行為最佳化的壓縮/解壓縮。

```csharp
using MemoryPack.Compression;

// 壓縮（需 using）
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// 取得壓縮後的 byte[]
var compressedBytes = compressor.ToArray();

// 或寫入其他 IBufferWriter<byte>（例如 PipeWriter）
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// 解壓縮（需 using）
using var decompressor = new BrotliDecompressor();

// 從 ReadOnlySpan<byte> 或 ReadOnlySequence<byte> 取得解壓縮後的 ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

`BrotliCompressor` 與 `BrotliDecompressor` 均為 struct，不會在 heap 上配置記憶體。兩者皆將壓縮或解壓縮後的資料儲存在內部記憶體池中以供序列化/反序列化。因此，必須釋放記憶體池，請務必使用 `using`。

壓縮等級非常重要。預設為 quality-1（CompressionLevel.Fastest），這與 .NET 預設（CompressionLevel.Optimal, quality-4）不同。

Fastest（quality-1）速度接近 [LZ4](https://github.com/lz4/lz4)，但 4 會慢上許多。這點在序列化器的使用場景中非常關鍵。使用標準 `BrotliStream` 時請小心（預設為 quality-4）。無論如何，不同資料的壓縮/解壓縮速度與大小會有顯著差異。請準備應用程式所需處理的資料並自行測試。

請注意，MemoryPack 未壓縮與 Brotli 壓縮之間會有數倍的速度損失。

Brotli 亦支援在自定義 formatter 中使用。`BrotliFormatter` 可以針對特定成員進行壓縮。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

序列化外部型別
---
如果想序列化外部型別，可以自訂 formatter 並註冊至 provider，詳情請參閱 [Formatter/Provider API](#formatterprovider-api)。然而，建立自訂 formatter 較為困難，因此建議建立包裝型別。例如，想序列化名為 `AnimationCurve` 的外部型別時：

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

被包裝的型別需為 public，但不參與序列化（`MemoryPackIgnore`）。欲序列化的屬性可為 private，但需標註 `MemoryPackInclude`。亦應準備兩種建構子，序列化器所用建構子應設為 private。

直接包裝每次使用會很不便，且 struct 包裝器無法表達 null。讓我們建立一個自訂 formatter。

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity 不支援 scoped 與 TBufferWriter，因此簽名改為 `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
}
```

最後，在啟動時註冊格式化器。

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> 注意：Unity 的 AnimationCurve 預設即可序列化，因此不需要為 AnimationCurve 使用這個自訂格式化器

套件
---
MemoryPack 有以下這些套件。

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` 是主要的函式庫，提供高效能二進位物件的完整序列化與反序列化支援。它依賴 `MemoryPack.Core` 作為核心基礎函式庫，以及 `MemoryPack.Generator` 用於程式碼產生。`MemoryPack.Streaming` 新增了[串流序列化](#streaming-serialization)的擴充功能。`MemoryPack.AspNetCoreMvcFormatter` 則為 ASP.NET Core 加入輸入/輸出格式化器。`MemoryPack.UnityShims` 則新增了 Unity shim 型別及格式化器，方便 .NET 與 Unity 間共用型別。

TypeScript 與 ASP.NET Core 格式化器
---
MemoryPack 支援 TypeScript 程式碼產生。它會從 C# 產生類別和序列化程式碼，換句話說，你可以不用 OpenAPI、proto 等方式，即可與瀏覽器共用型別。

程式碼產生整合在 Source Generator 中，下列選項（`MemoryPackGenerator_TypeScriptOutputDirectory`）設定 TypeScript 程式碼的輸出目錄。執行時程式碼也會一併輸出，因此不需額外相依其他套件。

```xml
<!-- 輸出 memorypack TypeScript 程式碼到指定目錄 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

C# 的 MemoryPackable 型別必須加上 `[GenerateTypeScript]` 標註。

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

執行時程式碼與 TypeScript 型別會產生在目標目錄下。

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

產生的程式碼如下，擁有簡單欄位與靜態方法，可進行 serialize/serializeArray 與 deserialize/deserializeArray。

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

你可以像下面這樣使用這個型別。

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// 序列化成 Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// 從 ArrayBuffer 反序列化
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` 套件為 ASP.NET Core MVC 新增了 `MemoryPack` 輸入與輸出格式化器。你可以用下列程式碼將 `MemoryPackInputFormatter`、`MemoryPackOutputFormatter` 加入 ASP.NET Core MVC。

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // 若 checkContentType: true，則可輸出多種格式（JSON/MemoryPack 等）。預設為 false。
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

如果你從 HttpClient 呼叫，可以將 `application/x-memorypack` 設定為 content-header。

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript 型別對應表

可產生的型別有一些限制。在基本型別中，`char` 和 `decimal` 不支援。此外，無法使用 OpenGenerics 型別。

|  C#  |  TypeScript  | 說明 |
| ---- | ---- | ---- |
| `bool` |  `boolean`  |
| `byte` |  `number`  |
| `sbyte` |  `number`  |
| `int` |  `number` |
| `uint` |  `number` |
| `short` |  `number` |
| `ushort` |  `number` |
| `long` |  `bigint` |
| `ulong` |  `bigint` |
| `float` |  `number` |
| `double` |  `number` |
| `string` |  `string \| null`  | 
| `Guid` |  `string`  | 在 TypeScript 中以字串表示，但序列化/反序列化時為 16 位元組二進位
| `DateTime` | `Date` | DateTimeKind 會被忽略
| `enum` | `const enum` | 不支援 `long` 與 `ulong` 作為底層型別
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | 支援所有實作 `ICollection<T>` 的型別，如 `List<T>`
| `: ISet<T>` | `Set<T> \| null` | 支援所有實作 `ISet<T>` 的型別，如 `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | 支援所有實作 `IDictionary<K,V>` 的型別，如 `Dictionary<K,V>`
| `[MemoryPackable]` | `class` | 僅支援類別
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` 只能套用於類別，目前尚不支援 struct。

### 設定匯入檔案副檔名與成員名稱大小寫

預設情況下，MemoryPack 產生的副檔名為 `.js`，例如 `import { MemoryPackWriter } from "./MemoryPackWriter.js";`。如需更改副檔名或設為空值，請使用 `MemoryPackGenerator_TypeScriptImportExtension` 來設定。
同時，成員名稱會自動轉為 camelCase。如需使用原始名稱，請將 `MemoryPackGenerator_TypeScriptConvertPropertyName` 設為 `false`。

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- 允許為空 -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- 預設為 true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- 預設為 false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` 允許 C# 的 nullable 標註反映到 TypeScript 代碼中。預設為 false，表示全部皆為 nullable。

串流序列化
---
`MemoryPack.Streaming` 提供了 `MemoryPackStreamingSerializer`，可額外支援以串流方式序列化和反序列化集合。

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
若需手動實作 formatter，請繼承 `MemoryPackFormatter<T>` 並覆寫 `Serialize` 及 `Deserialize` 方法。

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

        // 使用 writer 方法。
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // 使用 reader 方法。
    }
}
```
所建立的 formatter 需使用 `MemoryPackFormatterProvider` 註冊。

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

注意：`unmanaged struct`（不含參考型別）無法使用自訂 formatter，永遠使用原生記憶體佈局進行序列化。

MemoryPackWriter/ReaderOptionalState
---
初始化 `MemoryPackWriter`/`MemoryPackReader` 需要 OptionalState。它是 `MemoryPackSerializerOptions` 的包裝，可由 `MemoryPackWriterOptionalStatePool` 建立。

```csharp
// 當 disposed 時，OptionalState 會歸還到 pool。
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// Reader 用法
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

目標框架相依性
---
MemoryPack 提供 `netstandard2.1` 與 `net7.0`，但兩者不相容。例如，在 `netstandard2.1` 專案下的 MemoryPackable 型別若於 `net7.0` 專案中使用，則執行時會拋出如下例外：

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

由於 net7.0 使用了 static abstract 成員（`Virtual static method`），而此功能不支援 netstandard2.1，這是規範行為。

.NET 7 專案不應該使用 netstandard2.1 的 dll。換言之，若應用程式為 .NET 7 專案，所有依賴 MemoryPack 的相依套件也必須支援 .NET 7。因此，若是函式庫開發者依賴 MemoryPack，需設定雙目標框架。

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) 是一套以 MessagePack 取代 protobuf 的 code-first grpc-dotnet 框架。MagicOnion 現已透過 `MagicOnion.Serialization.MemoryPack` 套件（預覽版）支援 MemoryPack 做為序列化層。詳情請參考：[MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

最低支援 Unity 版本為 `2022.3.12f1`。

`MemoryPack` 核心套件由 nuget 提供，也可於 Unity 中使用。若需支援 Unity 內建型別，額外提供 MemoryPack.Unity 擴充套件。

1. 透過 [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) 從 NuGet 安裝 `MemoryPack`

* 開啟 NuGet 視窗 -> 管理 NuGet 套件，搜尋 "MemoryPack" 並按下安裝。
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* 若遇到版本衝突錯誤，請於 Player 設定（Edit -> Project Settings -> Player -> 下拉並展開 "Other Settings"，取消勾選 "Assembly Version Validation" 於 "Configuration" 區段下）。

2. 透過 git URL 引用安裝 `MemoryPack.Unity` 套件

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack 採用 *.*.* 版本標籤，可指定版本，如 #1.0.0。例如：`https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


如同 .NET 版本，程式碼由程式碼產生器（`MemoryPack.Generator.dll`）自動產生。無反射的實作在 IL2CPP 下也提供最佳效能。

關於 Unity 與 Source Generator 的更多資訊，請參考 [Unity 官方文件](https://docs.unity3d.com/Manual/roslyn-analyzers.html)。

Unity 官方也於 [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) 及 [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) 套件中採用 Source Generator。換言之，這是新一代 Unity 的標準程式碼產生方式。

你可以序列化所有 unmanaged 型別（如 `Vector3`、`Rect` 等）以及部分類別（`AnimationCurve`、`Gradient`、`RectOffset`）。若需序列化其他 Unity 專用型別，請參考 [Serialize external types](#serialize-external-types) 章節。

在 Unity 效能方面，MemoryPack 比 JsonUtility 快 3~10 倍。

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

若共用程式碼有 Unity 型別（如 `Vector2` 等），MemoryPack 在 NuGet 中提供 `MemoryPack.UnityShims` 套件。

`MemoryPack.UnityShims` 套件提供 Unity 標準 struct（`Vector2`、`Vector3`、`Vector4`、`Quaternion`、`Color`、`Bounds`、`Rect`、`Keyframe`、`WrapMode`、`Matrix4x4`、`GradientColorKey`、`GradientAlphaKey`、`GradientMode`、`Color32`、`LayerMask`、`Vector2Int`、`Vector3Int`、`RangeInt`、`RectInt`、`BoundsInt`）及部分類別（`AnimationCurve`、`Gradient`、`RectOffset`）的 shim。

> [!WARNING]
> 目前於 Unity 使用時有以下限制

1. Unity 版本不支援 CustomFormatter。
2. 若使用 .NET7 或更高版本，MemoryPack 二進位格式與 Unity 不完全相容。
    - 此問題發生於明確指定 `[StructLayout(LayoutKind.Auto)]` 的值型別。（struct 預設為 `LayoutKind.Sequential`。）對於這些型別，於 .NET 序列化的二進位資料無法在 Unity 反序列化，反之亦然。
    - 受影響型別通常包括下列型別：
        - `DateTimeOffset`
        - `ValueTuple`
    - 目前的簡單解決方式為避免使用這些型別。

Native AOT
---
很遺憾，由於執行階段 bug，.NET 7 Native AOT 使用 MemoryPack 時會發生 crash（`Generic virtual method pointer lookup failure`）。該問題將於 .NET 8 修復。若使用 ``Microsoft.DotNet.ILCompiler`` 預覽版，於 .NET 7 也能修復。請參見 [issue's comment](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) 以了解設定方法。

二進位線路格式規格
---
`Serialize<T>` 與 `Deserialize<T>` 中定義的 `T` 型別被稱為 C# schema。MemoryPack 格式不是自我描述格式。反序列化時需要對應的 C# schema。這些型別存在於二進位內部表示中，但若無 C# schema，無法判斷型別。

Endian 必須為 `Little Endian`。然而，C# 參考實作並不考慮 endianness，因此無法在 big-endian 機器上使用。不過現代電腦通常皆為 little-endian。

共有八種格式類型。

* Unmanaged struct
* Object
* Version Tolerant Object
* 循環參考物件
* Tuple（元組）
* 集合
* 字串
* 聯合（Union）

### 非託管結構（Unmanaged struct）

非託管結構是指 C# 中不包含參考型別的結構（struct），與 [C# 非託管型別](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types) 的限制相似。序列化時會按照結構的記憶體布局進行，包含填充（padding）。

### 物件（Object）

`(byte memberCount, [values...])`

物件的標頭有 1 個位元組的無號位元組作為成員數量。成員數量允許 `0` 到 `249`，`255` 代表物件為 `null`。Values 依照成員數量儲存 memorypack 值。

### 支援版本容錯的物件（Version Tolerant Object）

`(byte memberCount, [varint byte-length-of-values...], [values...])`

支援版本容錯的物件與一般物件類似，但在標頭中包含 values 的位元組長度。varint 遵循以下規格，第一個 sbyte 為值或 typeCode，接下來的 X 個位元組為值。0 到 127 = 無號位元組值，-1 到 -120 = 有號位元組值，-121 = byte，-122 = sbyte，-123 = ushort，-124 = short，-125 = uint，-126 = int，-127 = ulong，-128 = long。

### 循環參考物件（Circular Reference Object）

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

循環參考物件與支援版本容錯的物件類似，但如果 memberCount 為 250，接下來的 varint（無號 int32）為 referenceId。否則，在 byte-length-of-values 之後會寫入 varint referenceId。

### Tuple（元組）

`(values...)`

Tuple 是固定大小、不可為 null 的值集合。在 .NET 中，`KeyValuePair<TKey, TValue>` 和 `ValueTuple<T,...>` 會被序列化為 Tuple。

### 集合（Collection）

`(int length, [values...])`

集合的標頭有 4 位元組有號整數作為資料數量，`-1` 代表 `null`。Values 依據 length 數量儲存 memorypack 值。

### 字串（String）

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

字串有兩種格式，UTF16 與 UTF8。如果第一個 4 位元組有號整數為 `-1`，代表 null；`0` 代表空字串。UTF16 與集合相同（序列化為 `ReadOnlySpan<char>`，utf16-value 的位元組數為 utf16-length * 2）。如果第一個有號整數 <= `-2`，則值以 UTF8 編碼。utf8-byte-count 以補數編碼，使用 `~utf8-byte-count` 取得位元組數，接下來的有號整數為 utf16-length，可為 `-1` 代表未知長度。utf8-bytes 依 utf8-byte-count 儲存位元組。

### 聯合（Union）

`(byte tag, value)`  
`(250, ushort tag, value)`

第一個無號位元組為 tag，用於區分值型別或旗標，`0` 到 `249` 代表 tag，`250` 代表接下來的無號 short 為 tag，`255` 代表 union 為 `null`。

License
---
本程式庫採用 MIT 授權條款。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---