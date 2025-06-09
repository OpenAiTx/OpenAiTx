# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

用于 C# 和 Unity 的零编码极致性能二进制序列化器。

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> 与 [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json)、[protobuf-net](https://github.com/protobuf-net/protobuf-net)、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)、[Orleans.Serialization](https://github.com/dotnet/orleans/) 对比。在 .NET 7 / Ryzen 9 5950X 机器上测试。这些序列化器都支持 `IBufferWriter<byte>` 方法，使用 `ArrayBufferWriter<byte>` 进行序列化并复用以避免测量缓冲区复制。

对于标准对象，MemoryPack 的速度是其他二进制序列化器的 10 倍，是 x2 ~ x5 倍。而对于结构体数组，MemoryPack 更加高效，速度高达其他序列化器的 x50 ~ x200。

MemoryPack 是我开发的第 4 款序列化器，之前我还开发过知名序列化器，~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~、~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)。MemoryPack 之所以如此之快，是因为它采用了针对 C# 优化的二进制格式和基于我以往经验精心调优的实现。这也是一个全新设计，充分利用了 .NET 7、C# 11 以及增量源生成器（.NET Standard 2.1 (.NET 5, 6) 也有支持，并支持 Unity）。

其他序列化器执行许多编码操作，如 VarInt 编码、标签、字符串等。MemoryPack 格式采用零编码设计，尽可能复制 C# 内存。零编码类似于 FlatBuffers，但不需要特殊类型，MemoryPack 的序列化目标是 POCO。

除了性能之外，MemoryPack 还具有以下特性：

* 支持现代 I/O API（`IBufferWriter<byte>`、`ReadOnlySpan<byte>`、`ReadOnlySequence<byte>`）
* 原生 AOT 友好的基于源生成器的代码生成，无动态代码生成（IL.Emit）
* 无反射、非泛型 API
* 支持反序列化到已有实例
* 支持多态（联合）序列化
* 支持有限版本容错（fast/default）和完全版本容错
* 支持循环引用序列化
* 支持基于 PipeWriter/Reader 的流式序列化
* 支持 TypeScript 代码生成和 ASP.NET Core Formatter
* 支持 Unity（2021.3）IL2CPP，通过 .NET 源生成器

安装
---
该库通过 NuGet 分发。为获得最佳性能，推荐使用 `.NET 7`。最低要求为 `.NET Standard 2.1`。

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

同时，代码编辑器需要支持 Roslyn 4.3.1，例如 Visual Studio 2022 17.3 版本、.NET SDK 6.0.401。详情请见 [Roslyn 版本支持](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) 文档。

对于 Unity，要求和安装流程完全不同。详见 [Unity](#unity) 部分。

快速开始
---
定义要序列化的结构体或类，并用 `[MemoryPackable]` 特性和 `partial` 关键字标注。

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

序列化代码通过 C# 源生成器功能生成，实现了 `IMemoryPackable<T>` 接口。在 Visual Studio 中，可以通过快捷键 `Ctrl+K, R` 并选中类名来查看生成的 `*.MemoryPackFormatter.g.cs` 代码。

调用 `MemoryPackSerializer.Serialize<T>/Deserialize<T>` 方法来序列化/反序列化对象实例。

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` 方法支持返回类型为 `byte[]`，也可以序列化到 `IBufferWriter<byte>` 或 `Stream`。`Deserialize` 方法支持 `ReadOnlySpan<byte>`、`ReadOnlySequence<byte>` 和 `Stream`。也有非泛型版本。

内置支持的类型
---
以下类型可被默认序列化：

* .NET 基本类型（`byte`、`int`、`bool`、`char`、`double` 等）
* 非托管类型（任何 `enum`，任何不含引用类型的用户自定义 `struct`）
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
* `IDictionary<,>`、`IReadOnlyDictionary<,>`、`ILookup<,>`、`IGrouping<,>`
* `ConcurrentBag<>`、`ConcurrentQueue<>`、`ConcurrentStack<>`、`ConcurrentDictionary<,>`、`BlockingCollection<>`
* 不可变集合（`ImmutableList<>` 等）及接口（`IImmutableList<>` 等）

定义 `[MemoryPackable]` 的 `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` 可用于任何 `class`、`struct`、`record`、`record struct` 及 `interface`。如果类型是包含无引用类型的 `struct` 或 `record struct`（[C# 非托管类型](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)），则不会使用任何附加标注（ignore、include、constructor、callbacks），而是直接从内存序列化/反序列化。

否则，默认情况下 `[MemoryPackable]` 会序列化公有实例属性或字段。你可以用 `[MemoryPackIgnore]` 排除序列化目标，也可以用 `[MemoryPackInclude]` 将私有成员提升为序列化目标。

```csharp
[MemoryPackable]
public partial class Sample
{
    // 这些类型默认被序列化
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // 这些类型默认不被序列化
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // 用 [MemoryPackIgnore] 移除公有成员的序列化目标
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // 用 [MemoryPackInclude] 将私有成员提升为序列化目标
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack` 的代码生成器会将被序列化的成员信息添加到 `<remarks />` 部分。你可以通过 Intellisense 悬停类型查看。

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

所有成员都必须是可被 MemoryPack 序列化的，否则代码生成器会报错。

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack 拥有 35 条诊断规则（`MEMPACK001` 到 `MEMPACK035`），以便于规范定义。

如果目标类型在外部定义了 MemoryPack 序列化并已注册，可以用 `[MemoryPackAllowSerialize]` 消除诊断警告。

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

成员顺序**很重要**，MemoryPack 不序列化成员名称或其它信息，而是按声明顺序序列化字段。如果类型有继承，则序列化顺序为父类 → 子类。成员顺序在反序列化时不能更改。如需演进 schema，见 [版本容错](#version-tolerant) 部分。

默认顺序是顺序式，也可以使用 `[MemoryPackable(SerializeLayout.Explicit)]` 和 `[MemoryPackOrder()]` 选择显式布局。

```csharp
// 序列化顺序为 Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### 构造函数选择

MemoryPack 支持带参和无参构造函数。构造函数选择规则如下（适用于类和结构体）：

* 如果有 `[MemoryPackConstructor]`，则使用它。
* 如果没有显式构造函数（包括私有），则使用无参构造函数。
* 如果只有一个无参或带参构造函数（包括私有），则使用它。
* 如果有多个构造函数，则必须在所需构造函数上加 `[MemoryPackConstructor]` 特性（生成器不会自动选择），否则会报错。
* 如果使用带参构造函数，则所有参数名必须与对应成员名（不区分大小写）一致。

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // 可以使用带参构造函数——参数名必须与对应成员名（不区分大小写）一致
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// 也支持 record 主构造函数
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
// 如果有多个构造函数，则应使用 [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### 序列化回调

在序列化/反序列化时，MemoryPack 可以通过 `[MemoryPackOnSerializing]`、`[MemoryPackOnSerialized]`、`[MemoryPackOnDeserializing]`、`[MemoryPackOnDeserialized]` 特性调用序列化前/后的事件。它可以标注静态和实例（非静态）方法，以及 public 和 private 方法。

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // 方法调用顺序为 static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // 也允许 private 方法
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

    // 注意：带有 MemoryPackOnDeserializing 的实例方法，如果实例没有通过 `ref` 传递则不会被调用
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

回调允许无参数方法和 `ref reader/writer, ref T value` 方法。例如，ref 回调可以在序列化过程前写入/读取自定义头部。

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, 使用 where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // 在头部写入 GUID。
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // 在反序列化前读取自定义头部
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

如果对 `ref value` 赋值，可以更改用于序列化/反序列化的值。例如，从 ServiceProvider 实例化对象。

```csharp
// 在使用此格式化器前，设置 ServiceProvider
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

定义自定义集合
---
默认情况下，被 `[MemoryPackObject]` 标注的类型会尝试序列化其成员。但如果类型是集合（`ICollection<>`、`ISet<>`、`IDictionary<,>`），应使用 `GenerateType.Collection` 来正确序列化。

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

静态构造函数
---
MemoryPackable 类不能定义静态构造函数，因为生成的 partial 类会使用它。可以改为定义 `static partial void StaticConstructor()` 来实现相同的功能。

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

多态（Union）
---
MemoryPack 支持接口和抽象类对象的多态序列化。在 MemoryPack 中，这个特性称为 Union。只有接口和抽象类允许使用 `[MemoryPackUnion]` 特性标注。要求唯一的 union tag。

```csharp
// 在 [MemoryPackable] 以及继承类型上标注 [MemoryPackUnion]
// Union 同样支持抽象类
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

// 作为接口类型序列化
var bin = MemoryPackSerializer.Serialize(data);

// 作为接口类型反序列化
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

`tag` 允许的范围是 `0` ~ `65535`，特别是在小于 `250` 时效率更高。
```
如果接口和派生类型位于不同的程序集中，可以使用 `MemoryPackUnionFormatterAttribute`。格式化器会以自动通过 C# 9.0 及以上的 `ModuleInitializer` 注册的方式生成。

> 注意，`ModuleInitializer` 在 Unity 中不受支持，因此格式化器必须手动注册。要注册你的 union 格式化器，需要在启动时手动调用 `{你的 union 格式化器名称}Initializer.RegisterFormatter()`。例如 `UnionSampleFormatterInitializer.RegisterFormatter()`。

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB 在目标类型外部定义
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union 也可以通过 `DynamicUnionFormatter<T>` 在代码中组装。

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
`Serialize` 有三个重载。

```csharp
// 也提供非泛型 API，此版本第一个参数为 Type，值为 object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

为了性能，推荐使用 `BufferWriter` 的 API。它会直接序列化到缓冲区。可应用于 `System.IO.Pipelines` 中的 `PipeWriter`，ASP .NET Core 中的 `BodyWriter` 等。

如果需要 `byte[]`（例如 [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) 中的 `RedisValue`），返回 `byte[]` 的 API 简单且几乎同样快速。

注意，`Stream` 的 `SerializeAsync` 仅在 Flush 阶段是异步的；它会一次性序列化所有内容到 MemoryPack 的内部池缓冲区中，然后用 `WriteAsync` 写出。因此，更推荐使用 `BufferWriter` 重载，可以分离和控制缓冲及刷新。

如果你想实现完整的流式写入，请参见 [流式序列化](#streaming-serialization) 部分。

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` 配置字符串序列化为 UTF16 或 UTF8。可以通过传递 `MemoryPackSerializerOptions.Utf8`（UTF8 编码）、`MemoryPackSerializerOptions.Utf16`（UTF16 编码）或 `MemoryPackSerializerOptions.Default`（默认为 UTF8）来配置。传递 null 或使用默认参数也会导致使用 UTF8 编码。

由于 C# 内部字符串表示为 UTF16，UTF16 性能更好。但数据体积通常更大；在 UTF8 中，ASCII 字符串为一个字节，在 UTF16 中为两个字节。由于二者的体积差异巨大，默认设置为 UTF8。

如果数据为非 ASCII（如日文，可能大于 3 字节，UTF8 更大），或者需要单独压缩，UTF16 可能效果更好。

虽然在序列化时可以选择 UTF8 或 UTF16，但反序列化时无需指定，会自动检测并正常反序列化。

此外，可以通过 options 获取/设置 `IServiceProvider? ServiceProvider { get; init; }`。这在序列化过程中（`MemoryPackReader/MemoryPackWriter` 有 .Options 属性）获取 DI 对象（如 `ILogger<T>`）时非常有用。

反序列化 API
---
`Deserialize` 支持 `ReadOnlySpan<byte>`、`ReadOnlySequence<byte>`、`Stream` 重载及 `ref` 支持。

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` 重载会覆盖已存在的实例，详情见 [Overwrite](#overwrite) 部分。

`DeserializeAsync(Stream)` 并不是完全的流式读取操作，首先会读取到 MemoryPack 的内部池直到流末尾，然后再进行反序列化。

如果你想实现完整的流式读取操作，请参见 [流式序列化](#streaming-serialization) 部分。

覆盖写入
---
为了减少分配，MemoryPack 支持反序列化到已有实例上，覆盖其数据。这可以通过 `Deserialize(ref T? value)` 重载实现。

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// 覆盖已有实例的数据。
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack 会尽可能覆盖，但如不满足以下条件，会新建实例（与普通反序列化一样）。

* ref value（包括对象图中的成员）为 null，则创建新实例
* 只允许无参构造函数，若为有参构造则创建新实例
* 若 value 为 `T[]`，仅当长度相同时重用，否则新建实例
* 若 value 为具有 `.Clear()` 方法的集合（如 `List<>`、`Stack<>`、`Queue<>`、`LinkedList<>`、`HashSet<>`、`PriorityQueue<,>`、`ObservableCollection`、`Collection`、`ConcurrentQueue<>`、`ConcurrentStack<>`、`ConcurrentBag<>`、`Dictionary<,>`、`SortedDictionary<,>`、`SortedList<,>`、`ConcurrentDictionary<,>`），则调用 Clear() 并重用，否则新建实例

版本兼容
---
在默认情况下（`GenerateType.Object`），MemoryPack 支持有限的 schema 演进。

* 非托管结构体不可更改
* 成员可以新增，但不可删除
* 可以更改成员名
* 不可更改成员顺序
* 不可更改成员类型

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 新增成员是允许的
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// 删除成员是不允许的
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 更改顺序是不允许的
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

实际用例中，存储旧数据（如存储到文件、Redis 等）并读取到新 schema 总是可以的。在 RPC 场景下，schema 同时存在于客户端和服务端，必须先更新客户端。已更新的客户端可连接旧服务器，但旧客户端不能连接新服务器。

默认情况下，将旧数据读入新 schema 时，数据端不存在的成员会初始化为 `default` 字面量。
如果想避免此情况，使用字段/属性的初始值，可以使用 `[SuppressDefaultInitialization]`。

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < 若旧数据缺失，则设置为 `111`。
    
    public int Prop3 { get; set; } = 222; // < 若旧数据缺失，则设置为 `default`。
}
```

 `[SuppressDefaultInitialization]` 有以下限制：
- 不能用于 readonly、init-only 及 required 修饰符。

下一节 [序列化信息](#serialization-info) 展示了如何通过 CI 等方式检查 schema 变更，以防意外。

当使用 `GenerateType.VersionTolerant` 时，支持完全的版本兼容。

* 非托管结构体不可更改
* 所有成员必须显式添加 `[MemoryPackOrder]`（除非标注 `SerializeLayout.Sequential`）
* 成员可新增、可删除但不可复用序号（可使用缺失的序号）
* 可以更改成员名
* 不可更改成员顺序
* 不可更改成员类型

```csharp
// 支持双向序列化/反序列化 
// VersionTolerantObject1 -> VersionTolerantObject2 以及 
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
// 如果显式设置 SerializeLayout.Sequential，则允许自动排序。
// 但它不能移除任何成员以支持版本容错。
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` 在序列化时比 `GenerateType.Object` 更慢。同时，负载大小也会略大。

序列化信息
----
你可以在类型的 IntelliSense 中查看哪些成员被序列化。也可以选择在编译时将该信息写入文件。设置 `MemoryPackGenerator_SerializationInfoOutputDirectory`，如下所示。

```xml
<!-- 将 memorypack 序列化信息输出到目录 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

以下信息会被写入到文件中。

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

如果类型是非托管类型，则会在类型名前显示 `unmanaged`。

```txt
unmanaged FooStruct
---
int x
int y
```

通过检查此文件中的差异，可以防止危险的 schema 变更。例如，你可以使用 CI 检测以下规则：

* 修改非托管类型
* 成员顺序变化
* 成员删除

循环引用
---
MemoryPack 也支持循环引用。这允许树形对象按原样进行序列化。

```csharp
// 如需启用循环引用，请使用 GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 例如，[System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) 的代码如下所示。

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

`GenerateType.CircularReference` 具有与版本容错相同的特性。但作为额外的约束，只允许无参数构造函数。同时，对象引用跟踪仅针对标记了 `GenerateType.CircularReference` 的对象进行。如果你需要跟踪其他对象，请进行包装。

自定义格式化器（CustomFormatter）
---
如果实现了 `MemoryPackCustomFormatterAttribute<T>` 或 `MemoryPackCustomFormatterAttribute<TFormatter, T>`（性能更高，但更复杂），你可以配置 MemoryPackObject 的成员使用自定义格式化器。

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack 提供了如下格式化属性：`Utf8StringFormatterAttribute`、`Utf16StringFormatterAttribute`、`InternStringFormatterAttribute`、`OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`、`BitPackFormatterAttribute`、`BrotliFormatter`、`BrotliStringFormatter`、`BrotliFormatter<T>`、`MemoryPoolFormatter<T>`、`ReadOnlyMemoryPoolFormatter<T>`。

```csharp
[MemoryPackable]
public partial class Sample
{
    // 将此成员序列化为 UTF16 字符串，比 UTF8 性能高，但在 ASCII 下体积更大（但非 ASCII 下有时更小）。
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // 反序列化时，Dictionary 会以 StringComparer.OrdinalIgnoreCase 初始化。
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // 反序列化时，所有字符串都将被驻留（参见：String.Intern）。如果有大量重复字符串，可以节省内存。
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

为了配置集合/字典的相等比较器，所有内建格式化器都带有比较器构造重载。你可以轻松创建自定义相等比较器格式化器。

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

`BitPackFormatter` 仅压缩 `bool[]` 类型。`bool[]` 通常按每个布尔值 1 字节序列化，但 `BitPackFormatter` 会像 `BitArray` 一样按每个 bool 1 bit 存储。使用 `BitPackFormatter`，8 个 bool 只占 1 字节，而通常为 8 字节，体积缩小 8 倍。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` 用于 `byte[]`，例如你可以用 Brotli 压缩大型负载。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` 用于 `string`，将字符串（UTF16）以 Brotli 压缩方式序列化。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` 适用于任何类型，其序列化数据通过 Brotli 压缩。如果类型是 `byte[]` 或 `string`，为了性能，应该使用 `BrotliFormatter` 或 `BrotliStringFormatter`。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

反序列化数组池化
---
为了反序列化大型数组（任何 `T`），MemoryPack 提供了多种高效的池化方法。最有效的方法是使用 [#Overwrite](#overwrite) 功能。特别是 `List<T>` 总是被复用。

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> 被复用，反序列化时无分配。
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// 为了高效操作，可以通过 CollectionsMarshal 获取 Span<T>
var span = CollectionsMarshal.AsSpan(value.Payload);
```

一种方便的方法是在反序列化时反序列化到 ArrayPool。MemoryPack 提供了 `MemoryPoolFormatter<T>` 和 `ReadOnlyMemoryPoolFormatter<T>`。

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

    // 必须自己编写释放代码，以下为片段示例。

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
    // 执行任何操作...
}   // 归还到 ArrayPool
```

性能
---
参见我的博客文章 [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

负载大小与压缩
---
负载大小取决于目标值；与 JSON 不同，没有键，并且是二进制格式，因此负载大小很可能比 JSON 更小。

对于具有 varint 编码的格式，如 MessagePack 和 Protobuf，如果大量使用 int，MemoryPack 的体积往往更大（在 MemoryPack 中，int 始终为 4 字节，因为采用定长编码，而 MessagePack 为 1~5 字节）。

float 和 double 在 MemoryPack 中分别为 4 字节和 8 字节，但在 MessagePack 中分别为 5 字节和 9 字节。因此，例如对于 Vector3（float, float, float）数组，MemoryPack 更小。

字符串默认是 UTF8，这与其他序列化器类似，但如果选择 UTF16 选项，则有不同的特性。

无论如何，如果负载很大，应该考虑压缩。推荐使用 LZ4、ZStandard 和 Brotli。

### 压缩

MemoryPack 通过 [BrotliEncoder](https://learn.microsoft.com/zh-cn/dotnet/api/system.io.compression.brotliencoder) 和 [BrotliDecoder](https://learn.microsoft.com/zh-cn/dotnet/api/system.io.compression.brotlidecoder) 提供了高效的 [Brotli](https://github.com/google/brotli) 压缩辅助。MemoryPack 的 `BrotliCompressor` 和 `BrotliDecompressor` 针对 MemoryPack 内部行为进行了压缩/解压缩优化。

```csharp
using MemoryPack.Compression;

// 压缩（需要 using）
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// 获取压缩后的 byte[]
var compressedBytes = compressor.ToArray();

// 或写入其他 IBufferWriter<byte>（例如 PipeWriter）
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// 解压缩（需要 using）
using var decompressor = new BrotliDecompressor();

// 从 ReadOnlySpan<byte> 或 ReadOnlySequence<byte> 获取解压后的 ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

`BrotliCompressor` 和 `BrotliDecompressor` 都是结构体，不会在堆上分配内存。两者都将压缩或解压的数据存储在内部内存池中用于序列化/反序列化。因此，需要释放内存池，不要忘记使用 `using`。

压缩级别非常重要。默认设置为 quality-1（CompressionLevel.Fastest），这与 .NET 默认值（CompressionLevel.Optimal，quality-4）不同。

Fastest（quality-1）的速度接近 [LZ4](https://github.com/lz4/lz4)，但 quality-4 慢得多。这在序列化器的使用场景中尤为关键。在使用标准的 `BrotliStream` 时要小心（默认是 quality-4）。无论如何，压缩/解压速度和体积对于不同数据会有很大差异。请准备你应用需要处理的数据并自行测试。

注意，MemoryPack 的未压缩与 Brotli 压缩之间，速度会有数倍的损耗。

Brotli 也支持自定义格式化器。`BrotliFormatter` 可以压缩某个特定成员。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

序列化外部类型
---
如果你想序列化外部类型，可以自定义格式化器并注册到 provider，详见 [Formatter/Provider API](#formatterprovider-api)。然而，创建自定义格式化器较为困难。因此，推荐创建一个包装类型。例如，如果你想序列化一个名为 `AnimationCurve` 的外部类型。

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

需要包装的类型是 public，但通过 `MemoryPackIgnore` 排除序列化。你想序列化的属性是 private，但通过 `MemoryPackInclude` 包含。还应准备两种构造函数模式。序列化器使用的构造函数应为 private。

这样的话，每次都必须进行包装，比较不方便。而且结构体包装器不能表示 null。因此，让我们创建一个自定义格式化器。

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity 不支持 scoped 和 TBufferWriter，因此签名更改为 `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
        reader.Advance(1); // 跳过 null 块
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

最后，在启动时注册格式化器。

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> 注意：Unity 的 AnimationCurve 默认可序列化，因此对于 AnimationCurve 不需要这个自定义格式化器

Packages
---
MemoryPack 包含以下包。

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` 是主库，提供对二进制对象高性能序列化和反序列化的完整支持。它依赖于 `MemoryPack.Core` 作为核心基础库，依赖 `MemoryPack.Generator` 进行代码生成。`MemoryPack.Streaming` 添加了 [流式序列化](#streaming-serialization) 的扩展功能。`MemoryPack.AspNetCoreMvcFormatter` 为 ASP.NET Core 添加输入/输出格式化器。`MemoryPack.UnityShims` 为 .NET 与 Unity 之间共享类型添加了 Unity shim 类型和格式化器。

TypeScript 和 ASP.NET Core 格式化器
---
MemoryPack 支持 TypeScript 代码生成。它可以从 C# 生成类和序列化代码，换句话说，你可以无需 OpenAPI、proto 等即可与浏览器共享类型。

代码生成集成在 Source Generator 中，以下选项（`MemoryPackGenerator_TypeScriptOutputDirectory`）设置 TypeScript 代码的输出目录。运行时代码与类型同时输出，无需额外依赖。

```xml
<!-- 输出 memorypack TypeScript 代码到目录 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

C# 的 MemoryPackable 类型必须使用 `[GenerateTypeScript]` 注解。

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

运行时代码和 TypeScript 类型将会生成在目标目录。

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

生成的代码如下，包含简单字段和用于 serialize/serializeArray 及 deserialize/deserializeArray 的静态方法。

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
        // 省略...
    }

    static serialize(value: Person | null): Uint8Array {
        // 省略...
    }

    static serializeCore(writer: MemoryPackWriter, value: Person | null): void {
        // 省略...
    }

    static serializeArray(value: (Person | null)[] | null): Uint8Array {
        // 省略...
    }

    static serializeArrayCore(writer: MemoryPackWriter, value: (Person | null)[] | null): void {
        // 省略...
    }
    static deserialize(buffer: ArrayBuffer): Person | null {
        // 省略...
    }

    static deserializeCore(reader: MemoryPackReader): Person | null {
        // 省略...
    }

    static deserializeArray(buffer: ArrayBuffer): (Person | null)[] | null {
        // 省略...
    }

    static deserializeArrayCore(reader: MemoryPackReader): (Person | null)[] | null {
        // 省略...
    }
}
```

你可以如下方式使用该类型。

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// 序列化为 Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// 从 ArrayBuffer 反序列化
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` 包为 ASP.NET Core MVC 添加了 `MemoryPack` 输入和输出格式化器。你可以通过如下代码将 `MemoryPackInputFormatter`、`MemoryPackOutputFormatter` 添加到 ASP.NET Core MVC。

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // 如果 checkContentType: true，则可以输出多种格式（JSON/MemoryPack 等），默认为 false。
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

如果从 HttpClient 调用，可以将 `application/x-memorypack` 设置为内容头。

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript 类型映射

可生成的类型有一些限制。在基础类型中，`char` 和 `decimal` 不支持。同时不能使用开放泛型（OpenGenerics）类型。

|  C#  |  TypeScript  | 说明 |
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
| `Guid` |  `string`  | 在 TypeScript 中表示为字符串，但序列化/反序列化为 16 字节二进制
| `DateTime` | `Date` | DateTimeKind 将被忽略
| `enum` | `const enum` | 不支持 `long` 和 `ulong` 基础类型
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | 支持所有实现了 `ICollection<T>` 的类型，如 `List<T>`
| `: ISet<T>` | `Set<T> \| null` | 支持所有实现了 `ISet<T>` 的类型，如 `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | 支持所有实现了 `IDictionary<K,V>` 的类型，如 `Dictionary<K,V>`
| `[MemoryPackable]` | `class` | 仅支持类
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` 只能应用于类，目前不支持结构体。

### 配置导入文件扩展名和成员名称大小写

默认情况下，MemoryPack 生成的文件扩展名为 `.js`，如 `import { MemoryPackWriter } from "./MemoryPackWriter.js";`。如果你想更改为其他扩展名或为空，可以使用 `MemoryPackGenerator_TypeScriptImportExtension` 进行配置。
成员名称会自动转换为 camelCase。如果你想使用原始名称，可将 `MemoryPackGenerator_TypeScriptConvertPropertyName` 设置为 `false`。

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- 允许为空 -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- 默认值为 true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- 默认值为 false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` 允许 C# 的可空注解在 TypeScript 代码中体现。默认值为 false，表示所有类型都可为 null。

流式序列化
---
`MemoryPack.Streaming` 提供了 `MemoryPackStreamingSerializer`，用于支持通过流对集合进行序列化和反序列化。

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
如果你希望手动实现格式化器，可以继承 `MemoryPackFormatter<T>` 并重写 `Serialize` 和 `Deserialize` 方法。

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
创建的格式化器需要通过 `MemoryPackFormatterProvider` 注册。

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

注意：`unmanged struct`（不包含引用类型的结构体）无法使用自定义格式化器，始终以本地内存布局进行序列化。

MemoryPackWriter/ReaderOptionalState
---
初始化 `MemoryPackWriter`/`MemoryPackReader` 时需要 OptionalState。它是 `MemoryPackSerializerOptions` 的包装器，可通过 `MemoryPackWriterOptionalStatePool` 创建。

```csharp
// 释放时，OptionalState 会返回到池中。
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// 对 Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

目标框架依赖
---
MemoryPack 提供了 `netstandard2.1` 和 `net7.0`，但二者并不兼容。例如，在 `netstandard2.1` 项目下定义的 MemoryPackable 类型，如果在 `net7.0` 项目中使用，会在运行时抛出如下异常：

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

由于 net7.0 使用了静态抽象成员（`Virtual static method`），该特性不支持 netstandard2.1，因此这是规范上的限制。

.NET 7 项目不应使用 netstandard 2.1 的 dll。换句话说，如果应用程序是 .NET 7 项目，所有依赖 MemoryPack 的库必须同时支持 .NET 7。因此，如果库开发者依赖 MemoryPack，需要配置双目标框架。

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) 是一个基于代码优先的 grpc-dotnet 框架，使用 MessagePack 替代 protobuf。MagicOnion 现已通过 `MagicOnion.Serialization.MemoryPack` 包（预览版）支持 MemoryPack 作为序列化层。详情见：[MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

最低支持的 Unity 版本为 `2022.3.12f1`。

`MemoryPack` 核心包由 NuGet 提供，也可在 Unity 中使用。如果需要获得 Unity 内置类型支持，我们还提供了 MemoryPack.Unity 扩展包。

1. 使用 [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) 从 NuGet 安装 `MemoryPack`

* 打开 NuGet 窗口 -> 管理 NuGet 包，搜索 "MemoryPack" 并点击安装。
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* 如果遇到版本冲突错误，请在 Player Settings（Edit -> Project Settings -> Player -> 下拉并展开“Other Settings”，然后在“Configuration”部分取消勾选“Assembly Version Validation”）中禁用版本校验。

2. 通过引用 git URL 安装 `MemoryPack.Unity` 包

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)

MemoryPack 使用 *.*.* 版本标签，因此你可以指定版本，如 #1.0.0。例如：`https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`

与 .NET 版本一样，代码通过代码生成器（`MemoryPack.Generator.dll`）生成。无反射实现也为 IL2CPP 提供了最佳性能。

关于 Unity 与 Source Generator 的更多信息，请参阅 [Unity 官方文档](https://docs.unity3d.com/Manual/roslyn-analyzers.html)。

Source Generator 也已被 Unity 官方用于 [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) 和 [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html)。换句话说，它是下一代 Unity 代码生成的标准方式。

你可以序列化所有非托管类型（如 `Vector3`、`Rect` 等）和部分类（`AnimationCurve`、`Gradient`、`RectOffset`）。如需序列化其他 Unity 特有类型，请参阅 [序列化外部类型](#serialize-external-types) 部分。

在 Unity 环境下，MemoryPack 性能比 JsonUtility 快 3~10 倍。

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

如果共享代码中包含 Unity 类型（如 `Vector2` 等），MemoryPack 在 NuGet 中提供了 `MemoryPack.UnityShims` 包。

`MemoryPack.UnityShims` 包为 Unity 的标准结构体（`Vector2`、`Vector3`、`Vector4`、`Quaternion`、`Color`、`Bounds`、`Rect`、`Keyframe`、`WrapMode`、`Matrix4x4`、`GradientColorKey`、`GradientAlphaKey`、`GradientMode`、`Color32`、`LayerMask`、`Vector2Int`、`Vector3Int`、`RangeInt`、`RectInt`、`BoundsInt`）和部分类（`AnimationCurve`、`Gradient`、`RectOffset`）提供了兼容层。

> [!WARNING]
> 目前，Unity 使用存在如下限制：

1. Unity 版本不支持 CustomFormatter。
2. 如果你使用 .NET7 或更高版本，MemoryPack 二进制格式与 Unity 不完全兼容。
    - 该问题出现在显式指定了 `[StructLayout(LayoutKind.Auto)]` 的值类型上。（结构体默认是 `LayoutKind.Sequencil`。）对于此类类型，在 .NET 下序列化的二进制数据无法在 Unity 反序列化。同样，在 Unity 下序列化的二进制数据也无法在 .NET 侧反序列化。
    - 受影响的类型通常包括如下类型：
        - `DateTimeOffset`
        - `ValueTuple`
    - 目前，简单的解决办法是不要使用这些类型。

Native AOT
---
不幸的是，由于运行时的一个 bug，.NET 7 Native AOT 在使用 MemoryPack 时会导致崩溃（`Generic virtual method pointer lookup failure`）。该问题将在 .NET 8 修复。使用 ``Microsoft.DotNet.ILCompiler` 预览版可在 .NET 7 中解决。具体设置方法请参考 [issue 的评论](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611)。

二进制协议格式规范
---
在 `Serialize<T>` 和 `Deserialize<T>` 中定义的 `T` 类型称为 C# schema。MemoryPack 格式不是自描述格式。反序列化时必须提供对应的 C# schema。这些类型作为二进制的内部表示存在，但没有 C# schema 无法确定类型。

字节序必须为 `小端`。不过，参考的 C# 实现未处理字节序问题，因此不能在大端机器上使用。但现代计算机通常是小端。

格式分为八种类型：

* 非托管结构体
* 对象
* 版本容错对象
* 循环引用对象
* 元组
* 集合
* 字符串
* 联合类型

### 非托管结构体

非托管结构体是指 C# 中不包含引用类型的结构体，其约束类似于 [C# 非托管类型](https://learn.microsoft.com/zh-cn/dotnet/csharp/language-reference/builtin-types/unmanaged-types)。序列化时会按结构体的内存布局原样处理，包括填充字节。

### 对象

`(byte 成员数量, [值...])`

对象头部为 1 字节无符号字节，表示成员数量。成员数量允许 `0` 到 `249`，`255` 表示对象为 `null`。值部分按成员数量存储 memorypack 值。

### 版本容错对象

`(byte 成员数量, [varint 值的字节长度...], [值...])`

版本容错对象与对象类似，但在头部包含值的字节长度。varint 遵循如下规范，首字节为 sbyte，既可以是值也可以是 typeCode，后续 X 字节为值。0 到 127 = 无符号字节值，-1 到 -120 = 有符号字节值，-121 = byte，-122 = sbyte，-123 = ushort，-124 = short，-125 = uint，-126 = int，-127 = ulong，-128 = long。

### 循环引用对象

`(byte 成员数量, [varint 值的字节长度...], varint 引用ID, [值...])`  
`(250, varint 引用ID)`

循环引用对象与版本容错对象类似，但如果成员数量为 250，下一个 varint（无符号 int32）为引用ID。否则，在字节长度之后，写入 varint 引用ID。

### 元组

`(值...)`

元组是定长、不可为 null 的值集合。在 .NET 中，`KeyValuePair<TKey, TValue>` 和 `ValueTuple<T,...>` 会被序列化为元组。

### 集合

`(int 长度, [值...])`

集合头部为 4 字节有符号整数，表示数据数量，`-1` 表示 `null`。值部分根据长度存储 memorypack 值。

### 字符串

`(int utf16-长度, utf16-值)`  
`(int ~utf8-字节数, int utf16-长度, utf8-字节)`

字符串有两种格式，UTF16 和 UTF8。如果第一个 4 字节有符号整数为 `-1`，表示 null；为 `0`，表示空字符串。UTF16 格式与集合类似（序列化为 `ReadOnlySpan<char>`，utf16-值的字节数为 utf16-长度 * 2）。如果第一个有符号整数 ≤ `-2`，则值按 UTF8 编码。utf8-字节数以补码形式编码，通过 `~utf8-字节数` 获取实际字节数。下一个有符号整数为 utf16-长度，允许为 `-1`，表示长度未知。utf8-字节根据 utf8-字节数存储实际字节数据。

### 联合类型

`(byte 标签, 值)`  
`(250, ushort 标签, 值)`

第一个无符号字节为标签，用于区分值类型或标志，`0` 到 `249` 表示标签，`250` 表示下一个无符号短整型为标签，`255` 表示联合类型为 `null`。

License
---
该库采用 MIT 许可证。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---