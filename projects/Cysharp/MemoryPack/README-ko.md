# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

C#와 Unity를 위한 제로 인코딩 초고성능 바이너리 직렬화기입니다.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/)과 비교하였습니다. .NET 7 / Ryzen 9 5950X 머신에서 측정하였습니다. 이 직렬화기들은 `IBufferWriter<byte>` 메서드를 가지고 있으며, `ArrayBufferWriter<byte>`를 사용하여 직렬화하고, 버퍼 복사를 측정하지 않도록 재사용하였습니다.

일반 객체의 경우, MemoryPack은 x10 더 빠르며, 다른 바이너리 직렬화기보다 x2 ~ x5 더 빠릅니다. 구조체 배열의 경우, MemoryPack은 더욱 강력해서 다른 직렬화기보다 x50 ~ x200까지 빠른 속도를 자랑합니다.

MemoryPack은 제가 만든 네 번째 직렬화기로, 이전에는 유명한 직렬화기인 ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)을 만들었습니다. MemoryPack이 빠른 이유는 C#에 특화되고 최적화된 바이너리 포맷과, 과거의 경험을 바탕으로 잘 다듬어진 구현 덕분입니다. 또한 .NET 7, C# 11 및 Incremental Source Generator를 활용한 완전히 새로운 설계이며 (.NET Standard 2.1 (.NET 5, 6) 및 Unity 지원 포함)입니다.

다른 직렬화기는 VarInt 인코딩, 태그, 문자열 등 다양한 인코딩 작업을 많이 수행합니다. MemoryPack 포맷은 가능한 한 많은 C# 메모리를 복사하는 제로 인코딩 설계를 사용합니다. 제로 인코딩은 FlatBuffers와 유사하지만, 특별한 타입이 필요 없으며, MemoryPack의 직렬화 대상은 POCO입니다.

성능 외에도, MemoryPack은 다음과 같은 기능을 제공합니다.

* 최신 I/O API 지원 (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Native AOT 친화적인 Source Generator 기반 코드 생성, Dynamic CodeGen(IL.Emit) 미사용
* 리플렉션 없는 비제네릭 API
* 기존 인스턴스에 대한 역직렬화 지원
* 다형성(Union) 직렬화 지원
* 제한적 버전 내성(fast/default) 및 완전한 버전 내성 지원
* 순환 참조 직렬화 지원
* PipeWriter/Reader 기반 스트리밍 직렬화 지원
* TypeScript 코드 생성 및 ASP.NET Core Formatter
* Unity(2021.3) IL2CPP 지원(.NET Source Generator 기반)

설치
---
이 라이브러리는 NuGet을 통해 배포됩니다. 최고의 성능을 위해 `.NET 7` 사용을 권장합니다. 최소 요구 사항은 `.NET Standard 2.1`입니다.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

그리고 코드 에디터는 Roslyn 4.3.1 지원이 필요합니다. 예를 들어 Visual Studio 2022 버전 17.3, .NET SDK 6.0.401 등이 해당됩니다. 자세한 사항은 [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) 문서를 참고하세요.

Unity의 경우 요구 사항 및 설치 과정이 완전히 다릅니다. 자세한 내용은 [Unity](#unity) 섹션을 참고하세요.

빠른 시작
---
직렬화할 struct 또는 class를 정의하고 `[MemoryPackable]` 특성과 `partial` 키워드를 지정하세요.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

직렬화 코드는 C# 소스 생성기 기능에 의해 생성되며, `IMemoryPackable<T>` 인터페이스를 구현합니다. Visual Studio에서는 클래스 이름에 커서를 두고 단축키 `Ctrl+K, R`을 사용하여 생성된 코드인 `*.MemoryPackFormatter.g.cs`를 확인할 수 있습니다.

객체 인스턴스의 직렬화/역직렬화는 `MemoryPackSerializer.Serialize<T>/Deserialize<T>`를 호출하세요.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` 메서드는 `byte[]` 반환뿐만 아니라 `IBufferWriter<byte>` 또는 `Stream`에도 직렬화할 수 있습니다. `Deserialize` 메서드는 `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream`을 지원합니다. 또한 비제네릭 버전도 존재합니다.

내장 지원 타입
---
다음 타입들은 기본적으로 직렬화가 가능합니다:

* .NET 프리미티브(`byte`, `int`, `bool`, `char`, `double` 등)
* 비관리형 타입(모든 `enum`, 참조 타입을 포함하지 않는 사용자 정의 `struct`)
* `string`, `decimal`, `Half`, `Int128`, `UInt128`, `Guid`, `Rune`, `BigInteger`
* `TimeSpan`,  `DateTime`, `DateTimeOffset`, `TimeOnly`, `DateOnly`, `TimeZoneInfo`
* `Complex`, `Plane`, `Quaternion`, `Matrix3x2`, `Matrix4x4`, `Vector2`, `Vector3`, `Vector4`
* `Uri`, `Version`, `StringBuilder`, `Type`, `BitArray`, `CultureInfo`
* `T[]`, `T[,]`, `T[,,]`, `T[,,,]`, `Memory<>`, `ReadOnlyMemory<>`, `ArraySegment<>`, `ReadOnlySequence<>`
* `Nullable<>`, `Lazy<>`, `KeyValuePair<,>`, `Tuple<,...>`, `ValueTuple<,...>`
* `List<>`, `LinkedList<>`, `Queue<>`, `Stack<>`, `HashSet<>`, `SortedSet<>`, `PriorityQueue<,>`
* `Dictionary<,>`, `SortedList<,>`, `SortedDictionary<,>`,  `ReadOnlyDictionary<,>` 
* `Collection<>`, `ReadOnlyCollection<>`, `ObservableCollection<>`, `ReadOnlyObservableCollection<>`
* `IEnumerable<>`, `ICollection<>`, `IList<>`, `IReadOnlyCollection<>`, `IReadOnlyList<>`, `ISet<>`
* `IDictionary<,>`, `IReadOnlyDictionary<,>`, `ILookup<,>`, `IGrouping<,>`,
* `ConcurrentBag<>`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentDictionary<,>`, `BlockingCollection<>`
* 불변 컬렉션(`ImmutableList<>` 등) 및 인터페이스(`IImmutableList<>` 등)

`[MemoryPackable]` `class` / `struct` / `record` / `record struct` 정의
---
`[MemoryPackable]`은 모든 `class`, `struct`, `record`, `record struct`, `interface`에 지정할 수 있습니다. 만약 타입이 참조 타입을 포함하지 않는 `struct` 또는 `record struct`( [C# 비관리형 타입](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types))이라면 추가 어노테이션(무시, 포함, 생성자, 콜백)은 사용되지 않고 메모리에서 직접 직렬화/역직렬화됩니다.

그 외의 경우, 기본적으로 `[MemoryPackable]`은 public 인스턴스 프로퍼티나 필드를 직렬화합니다. `[MemoryPackIgnore]`를 사용하면 직렬화 대상에서 제외할 수 있고, `[MemoryPackInclude]`를 사용하면 private 멤버를 직렬화 대상으로 승격할 수 있습니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    // 기본적으로 직렬화되는 멤버
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // 기본적으로 직렬화되지 않는 멤버
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // public 멤버를 직렬화 대상에서 제외하려면 [MemoryPackIgnore] 사용
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // private 멤버를 직렬화 대상으로 승격하려면 [MemoryPackInclude] 사용
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack`의 코드 생성기는 어떤 멤버가 직렬화되는지 `<remarks />` 섹션에 정보를 추가합니다. 이는 Intellisense에서 타입에 마우스를 올리면 확인할 수 있습니다.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

모든 멤버는 memorypack-직렬화가 가능해야 하며, 그렇지 않으면 코드 생성기가 오류를 발생시킵니다.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack에는 쾌적한 사용을 위한 35개의 진단 규칙(`MEMPACK001` ~ `MEMPACK035`)이 있습니다.

타입이 외부에서 MemoryPack 직렬화가 정의되어 있고 등록된 경우, `[MemoryPackAllowSerialize]`를 사용하여 진단을 무시할 수 있습니다.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

멤버 순서는 **중요**합니다. MemoryPack은 멤버 이름이나 기타 정보를 직렬화하지 않고, 선언된 순서대로 필드를 직렬화합니다. 타입이 상속된 경우, 직렬화는 부모 → 자식 순서로 진행됩니다. 역직렬화 시 멤버 순서는 변경할 수 없습니다. 스키마 진화에 대해서는 [버전 내성](#version-tolerant) 섹션을 참고하세요.

기본 순서는 선언순이지만, `[MemoryPackable(SerializeLayout.Explicit)]` 및 `[MemoryPackOrder()]`를 사용하여 명시적 레이아웃을 선택할 수 있습니다.

```csharp
// Prop0 -> Prop1 순서로 직렬화
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### 생성자 선택

MemoryPack은 매개변수가 있는 생성자와 매개변수가 없는 생성자 모두를 지원합니다. 생성자 선택 규칙은 다음과 같습니다(클래스 및 구조체에 적용).

* `[MemoryPackConstructor]`가 있으면 이를 사용합니다.
* 명시적 생성자가 없으면(비공개 포함) 매개변수 없는 생성자를 사용합니다.
* 매개변수 없는/있는 생성자가 하나만 있으면(비공개 포함) 이를 사용합니다.
* 여러 생성자가 있으면, 원하는 생성자에 반드시 `[MemoryPackConstructor]` 특성을 지정해야 하며(생성기가 자동으로 선택하지 않음), 그렇지 않으면 생성기가 오류를 발생시킵니다.
* 매개변수 있는 생성자를 사용할 경우, 모든 매개변수 이름은 해당 멤버 이름과 일치해야 합니다(대소문자 무관).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // 매개변수 생성자 사용 가능 - 매개변수 이름은 대응되는 멤버 이름과 일치해야 함(대소문자 무관)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// record의 primary constructor도 지원
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
// 생성자가 여러 개인 경우, [MemoryPackConstructor]를 사용해야 합니다.
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### 직렬화 콜백

직렬화/역직렬화 시, MemoryPack은 `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]` 속성을 사용하여 직렬화 전/후 이벤트를 호출할 수 있습니다. 이 속성은 static 및 인스턴스(비-static) 메서드, public 및 private 메서드 모두에 적용할 수 있습니다.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // 메서드 호출 순서는 static -> instance 입니다.
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // private 메서드도 허용됩니다.
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

    // 참고: MemoryPackOnDeserializing이 붙은 인스턴스 메서드는 인스턴스가 `ref`로 전달되지 않으면 호출되지 않습니다.
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

콜백은 매개변수가 없는 메서드와 `ref reader/writer, ref T value` 메서드를 허용합니다. 예를 들어, ref 콜백을 사용하면 직렬화 과정 전에 커스텀 헤더를 기록/읽기할 수 있습니다.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, 사용할 경우 where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // 헤더에 GUID 기록
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // 역직렬화 전에 커스텀 헤더 읽기
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

`ref value`에 값을 할당하면 직렬화/역직렬화에 사용되는 값을 변경할 수 있습니다. 예를 들어, ServiceProvider에서 인스턴스를 생성할 수 있습니다.

```csharp
// 이 포매터를 사용하기 전에 ServiceProvider를 설정하세요.
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

커스텀 컬렉션 정의
---
기본적으로 `[MemoryPackObject]`가 적용된 타입은 멤버를 직렬화합니다. 하지만 타입이 컬렉션(`ICollection<>`, `ISet<>`, `IDictionary<,>`)인 경우, 올바른 직렬화를 위해 `GenerateType.Collection`을 사용해야 합니다.

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

정적 생성자
---
MemoryPackable 클래스는 생성된 partial 클래스가 정적 생성자를 사용하기 때문에 정적 생성자를 정의할 수 없습니다. 대신, 동일한 동작을 위해 `static partial void StaticConstructor()`를 정의할 수 있습니다.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

다형성(유니온)
---
MemoryPack은 다형성 직렬화를 위해 인터페이스와 추상 클래스 객체의 직렬화를 지원합니다. MemoryPack에서는 이 기능을 Union이라고 부릅니다. `[MemoryPackUnion]` 속성은 인터페이스와 추상 클래스에만 적용할 수 있습니다. 고유한 union 태그가 필요합니다.

```csharp
// [MemoryPackable]과 상속 타입에 [MemoryPackUnion]을 지정
// Union은 추상 클래스도 지원합니다.
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

// 인터페이스 타입으로 직렬화
var bin = MemoryPackSerializer.Serialize(data);

// 인터페이스 타입으로 역직렬화
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

`tag`는 `0` ~ `65535`를 허용하며, `250` 미만에서는 특히 효율적입니다.
```
인터페이스와 파생 타입이 서로 다른 어셈블리에 있는 경우, 대신 `MemoryPackUnionFormatterAttribute`를 사용할 수 있습니다. 포매터는 C# 9.0 이상에서 `ModuleInitializer`를 통해 자동으로 등록되도록 생성됩니다.

> `ModuleInitializer`는 Unity에서 지원되지 않으므로, 포매터를 수동으로 등록해야 합니다. 유니언 포매터를 등록하려면 Startup에서 `{유니언 포매터 이름}Initializer.RegisterFormatter()`를 직접 호출하세요. 예를 들어, `UnionSampleFormatterInitializer.RegisterFormatter()`와 같이 사용합니다.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB에서 대상 타입 외부에 정의
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

유니언은 코드에서 `DynamicUnionFormatter<T>`를 통해 조립할 수 있습니다.

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
`Serialize`는 세 가지 오버로드가 있습니다.

```csharp
// 제네릭이 아닌 API도 제공됩니다. 이 버전은 첫 번째 인자가 Type이고 값은 object?입니다.
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

성능을 위해 권장되는 API는 `BufferWriter`를 사용하는 것입니다. 이 방식은 버퍼에 직접 직렬화합니다. `System.IO.Pipelines`의 `PipeWriter`, ASP .NET Core의 `BodyWriter` 등에 적용할 수 있습니다.

만약 `byte[]`가 필요한 경우(예: [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)의 `RedisValue`), 반환되는 `byte[]` API는 간단하며 거의 동일한 속도를 보입니다.

`Stream`용 `SerializeAsync`는 Flush에만 비동기식입니다. 모든 내용을 한 번에 MemoryPack의 내부 풀 버퍼에 직렬화한 뒤, `WriteAsync`로 작성합니다. 따라서 버퍼와 flush를 분리·제어할 수 있는 `BufferWriter` 오버로드가 더 우수합니다.

완전한 스트리밍 쓰기를 하고 싶다면, [Streaming Serialization](#streaming-serialization) 섹션을 참고하세요.

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions`는 문자열을 UTF16 또는 UTF8로 직렬화할지 여부를 설정합니다. UTF8 인코딩에는 `MemoryPackSerializerOptions.Utf8`, UTF16에는 `MemoryPackSerializerOptions.Utf16`, 기본값인 UTF8에는 `MemoryPackSerializerOptions.Default`를 전달하여 설정할 수 있습니다. null을 전달하거나 기본 파라미터를 사용할 경우 UTF8 인코딩이 됩니다.

C# 내부 문자열 표현은 UTF16이므로, UTF16이 더 나은 성능을 보입니다. 그러나 페이로드가 더 커질 수 있습니다. UTF8에서 ASCII 문자열은 1바이트이지만, UTF16에서는 2바이트입니다. 페이로드 크기 차이가 커서 기본값이 UTF8입니다.

데이터가 비ASCII(예: 일본어 등 3바이트 이상, UTF8이 더 커짐)이거나, 별도로 압축해야 하는 경우라면 UTF16이 더 나은 결과를 제공할 수 있습니다.

직렬화 시에는 UTF8 또는 UTF16을 선택할 수 있지만, 역직렬화 시에는 명시할 필요가 없습니다. 자동으로 감지되어 정상적으로 역직렬화됩니다.

또한 옵션에서 `IServiceProvider? ServiceProvider { get; init; }`를 get/set할 수 있습니다. 직렬화 과정에서 DI 객체(예: `ILogger<T>`)를 가져올 때 유용합니다(`MemoryPackReader/MemoryPackWriter`는 .Options 속성이 있습니다).

Deserialize API
---
`Deserialize`는 `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` 오버로드 및 `ref` 지원을 제공합니다.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` 오버로드는 기존 인스턴스를 덮어씁니다. 자세한 내용은 [Overwrite](#overwrite) 섹션을 참고하세요.

`DeserializeAsync(Stream)`는 완전한 스트리밍 읽기 작업이 아니며, 우선 MemoryPack의 내부 풀에 스트림 끝까지 읽은 후 역직렬화합니다.

완전한 스트리밍 읽기를 원한다면, [Streaming Serialization](#streaming-serialization) 섹션을 참고하세요.

Overwrite
---
할당을 줄이기 위해, MemoryPack은 기존 인스턴스에 역직렬화하여 덮어쓰는 기능을 지원합니다. 이는 `Deserialize(ref T? value)` 오버로드와 함께 사용할 수 있습니다.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// 기존 인스턴스에 데이터를 덮어씁니다.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack은 가능한 한 많이 덮어쓰려 하지만, 아래 조건이 맞지 않으면(일반 역직렬화처럼) 새 인스턴스를 생성합니다.

* ref 값(객체 그래프 내 멤버 포함)이 null이면 새 인스턴스 할당
* 매개변수 없는 생성자만 허용, 매개변수 생성자 사용 시 새 인스턴스 생성
* 값이 `T[]`일 때 길이가 같으면 재사용, 다르면 새 인스턴스 생성
* `.Clear()` 메서드가 있는 컬렉션(`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`)이면 Clear() 호출 후 재사용, 아니면 새 인스턴스 생성

Version tolerant
---
기본값(`GenerateType.Object`)에서 MemoryPack은 제한된 스키마 진화를 지원합니다.

* 언매니지드 struct는 더 이상 변경할 수 없습니다
* 멤버는 추가할 수 있지만 삭제할 수 없습니다
* 멤버 이름 변경 가능
* 멤버 순서 변경 불가
* 멤버 타입 변경 불가

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 추가는 OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// 삭제는 NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 순서 변경은 NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

실제 사용 사례에서는, 이전 데이터를 저장(파일, Redis 등)하고 새 스키마로 읽는 것은 항상 가능합니다. RPC 시나리오에서는 클라이언트와 서버 양쪽에 스키마가 존재하므로, 반드시 클라이언트를 먼저 업데이트해야 합니다. 업데이트된 클라이언트는 이전 서버에 접속해도 문제가 없지만, 이전 클라이언트는 새 서버에 접속할 수 없습니다.

기본적으로 이전 데이터를 새 스키마로 읽을 때, 데이터 쪽에 없는 멤버는 `default` 리터럴로 초기화됩니다.
이것을 피하고 필드/프로퍼티의 초기값을 사용하고 싶다면 `[SuppressDefaultInitialization]`을 사용할 수 있습니다.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < 이전 데이터에 없으면 `111` 할당.
    
    public int Prop3 { get; set; } = 222; // < 이전 데이터에 없으면 `default` 할당.
}
```

`[SuppressDefaultInitialization]`는 다음과 같은 제한이 있습니다:
- readonly, init-only, required 한정자와 함께 사용할 수 없습니다.

다음 [Serialization info](#serialization-info) 섹션에서는 CI 등을 통해 스키마 변화를 검사하여 사고를 방지하는 방법을 보여줍니다.

`GenerateType.VersionTolerant`를 사용하는 경우, 완전한 버전 관용성을 지원합니다.

* 언매니지드 struct는 더 이상 변경할 수 없습니다
* 모든 멤버는 `[MemoryPackOrder]`를 명시적으로 추가해야 합니다(`SerializeLayout.Sequential`을 주석 처리한 경우 제외)
* 멤버는 추가/삭제 가능하나 순서 재사용 불가(누락된 순서 사용 가능)
* 멤버 이름 변경 가능
* 멤버 순서 변경 불가
* 멤버 타입 변경 불가

```csharp
// 양방향 직렬화/역직렬화 가능
// VersionTolerantObject1 -> VersionTolerantObject2 및 
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

// 삭제됨
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// 추가됨
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// SerializeLayout.Sequential을 명시적으로 설정하면, 자동으로 순서를 정렬할 수 있습니다.
// 하지만 버전-내성(Version-Tolerant)을 위해서는 멤버를 제거할 수 없습니다.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant`는 직렬화에서 `GenerateType.Object`보다 느립니다. 또한, 페이로드 크기가 약간 더 커집니다.

Serialization info
----
직렬화되는 멤버가 무엇인지 타입의 IntelliSense에서 확인할 수 있습니다. 이 정보를 컴파일 시 파일로 출력하는 옵션도 있습니다. `MemoryPackGenerator_SerializationInfoOutputDirectory`를 아래와 같이 설정하세요.

```xml
<!-- memorypack 직렬화 정보를 디렉터리에 출력 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

아래와 같은 정보가 파일에 기록됩니다.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

타입이 unmanaged인 경우, 타입 이름 앞에 `unmanaged`가 표시됩니다.

```txt
unmanaged FooStruct
---
int x
int y
```

이 파일의 차이점을 확인하면 위험한 스키마 변경을 방지할 수 있습니다. 예를 들어, CI를 사용해 다음 규칙을 감지할 수 있습니다.

* unmanaged 타입 수정
* 멤버 순서 변경
* 멤버 삭제

Circular Reference
---
MemoryPack는 순환 참조(circular reference)도 지원합니다. 이를 통해 트리 구조 객체를 있는 그대로 직렬화할 수 있습니다.

```csharp
// 순환 참조를 활성화하려면 GenerateType.CircularReference를 사용하세요.
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

예를 들어, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) 코드는 아래와 같습니다.

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

`GenerateType.CircularReference`는 버전-내성(Version-Tolerant)과 동일한 특성을 가집니다. 하지만 추가 제약으로, 파라미터가 없는 생성자만 허용됩니다. 또한, 객체 참조 추적은 `GenerateType.CircularReference`로 표시된 객체에만 적용됩니다. 다른 객체도 추적하고 싶다면 래핑(wrap)하세요.

CustomFormatter
---
`MemoryPackCustomFormatterAttribute<T>` 또는 `MemoryPackCustomFormatterAttribute<TFormatter, T>`(더 성능이 뛰어나지만 복잡함)를 구현하면, MemoryPackObject의 멤버에 사용자 지정 포매터(custom formatter)를 사용할 수 있습니다.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack는 다음과 같은 포매팅 어트리뷰트를 제공합니다: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // 이 멤버를 UTF16 String으로 직렬화합니다. 이는 UTF8보다 성능이 좋지만, ASCII에서는 크기가 크고(비 ASCII에서는 경우에 따라 더 작음).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // 역직렬화 시, Dictionary가 StringComparer.OrdinalIgnoreCase로 초기화됩니다.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // 역직렬화 시, 모든 string은 interned 됩니다(참고: String.Intern). 유사한 값이 반복되면 메모리를 절약할 수 있습니다.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

집합/딕셔너리의 equality comparer를 구성하려면, 모든 내장 포매터에 comparer 생성자 오버로드가 있습니다. 커스텀 equality-comparer 포매터를 쉽게 만들 수 있습니다.

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

`BitPackFormatter`는 `bool[]` 타입만 압축합니다. `bool[]`은 일반적으로 boolean 값 하나당 1바이트로 직렬화되지만, `BitPackFormatter`는 각 bool을 1비트로 저장하는 `BitArray`처럼 직렬화합니다. `BitPackFormatter`를 사용하면 8개의 bool이 1바이트가 되어, 기존 8바이트에서 8배 더 작은 크기가 됩니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter`는 `byte[]`용으로, 예를 들어 큰 페이로드를 Brotli로 압축할 수 있습니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter`는 `string`용으로, 문자열(UTF16)을 Brotli로 압축하여 직렬화합니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>`는 모든 타입에 사용할 수 있으며, 직렬화된 데이터는 Brotli로 압축됩니다. 타입이 `byte[]` 또는 `string`인 경우 성능을 위해 `BrotliFormatter` 또는 `BrotliStringFormatter`를 사용하는 것이 좋습니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

배열 풀링을 이용한 역직렬화
---
대용량 배열(임의의 `T`)을 역직렬화하기 위해 MemoryPack은 여러 효율적인 풀링 방법을 제공합니다. 가장 효과적인 방법은 [#Overwrite](#overwrite) 기능을 사용하는 것입니다. 특히 `List<T>`는 항상 재사용됩니다.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte>는 재사용되며, 역직렬화 시 별도의 할당이 없습니다.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// 효율적인 작업을 위해 CollectionsMarshal을 사용하여 Span<T>를 얻을 수 있습니다.
var span = CollectionsMarshal.AsSpan(value.Payload);
```

간편하게 ArrayPool로 역직렬화할 수도 있습니다. MemoryPack은 `MemoryPoolFormatter<T>`와 `ReadOnlyMemoryPoolFormatter<T>`를 제공합니다.

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

    // 반환 코드는 직접 작성해야 하며, 아래는 예시입니다.

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
    // do anything...
}   // ArrayPool로 반환됨
```

성능
---
블로그 글을 참고하세요: [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

페이로드 크기 및 압축
---
페이로드 크기는 대상 값에 따라 다릅니다. JSON과 달리 키가 없고 이진 포맷이기 때문에 페이로드 크기는 대체로 JSON보다 작습니다.

varint 인코딩(MessagePack, Protobuf 등)이 있는 경우, int를 많이 사용할 때 MemoryPack이 더 커지는 경향이 있습니다(MemoryPack에서는 고정 크기 인코딩으로 int가 항상 4바이트, MessagePack에서는 1~5바이트).

float와 double은 MemoryPack에서는 각각 4바이트, 8바이트이고, MessagePack에서는 각각 5바이트, 9바이트입니다. 따라서 예를 들어 Vector3(float, float, float) 배열의 경우 MemoryPack이 더 작습니다.

문자열은 기본적으로 UTF8로, 다른 직렬화기와 유사하지만, UTF16 옵션을 선택하면 성격이 달라집니다.

어쨌든 페이로드 크기가 크면 압축을 고려해야 합니다. LZ4, ZStandard, Brotli를 추천합니다.

### 압축

MemoryPack은 [Brotli](https://github.com/google/brotli) 압축을 위해 [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) 및 [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder)를 통한 효율적인 헬퍼를 제공합니다. MemoryPack의 `BrotliCompressor`와 `BrotliDecompressor`는 MemoryPack의 내부 동작에 최적화된 압축/해제압축을 제공합니다.

```csharp
using MemoryPack.Compression;

// 압축(사용 필요)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// 압축된 byte[] 가져오기
var compressedBytes = compressor.ToArray();

// 또는 다른 IBufferWriter<byte>(예: PipeWriter)에 쓰기
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// 해제압축(사용 필요)
using var decompressor = new BrotliDecompressor();

// ReadOnlySpan<byte> 또는 ReadOnlySequence<byte>에서 해제압축된 ReadOnlySequence<byte> 가져오기
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

`BrotliCompressor`와 `BrotliDecompressor` 모두 struct로, 힙에 메모리를 할당하지 않습니다. 둘 다 직렬화/역직렬화 시 내부 메모리 풀에 압축/해제압축 데이터를 저장합니다. 따라서 메모리 풀링 해제가 필요하므로 `using`을 잊지 마세요.

압축 레벨이 매우 중요합니다. 기본값은 quality-1(CompressionLevel.Fastest)로, .NET 기본값(CompressionLevel.Optimal, quality-4)과 다릅니다.

Fastest(quality-1)는 [LZ4](https://github.com/lz4/lz4)와 거의 비슷한 속도를 보이지만, 4는 훨씬 느립니다. 이는 직렬화기 사용 시나리오에서 매우 중요하다고 판단되었습니다. 표준 `BrotliStream`을 사용할 때(기본값 quality-4) 주의하세요. 데이터에 따라 압축/해제압축 속도 및 크기는 매우 다르게 나타날 수 있습니다. 반드시 애플리케이션에서 처리할 데이터를 준비하여 직접 테스트하시기 바랍니다.

MemoryPack의 비압축과 Brotli 압축 추가 시에는 속도 저하가 몇 배 발생할 수 있습니다.

Brotli는 커스텀 포매터에서도 지원됩니다. `BrotliFormatter`를 사용하면 특정 멤버만 압축할 수 있습니다.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

외부 타입 직렬화하기
---
외부 타입을 직렬화하고 싶다면 커스텀 포매터를 만들어 provider에 등록할 수 있습니다. 자세한 내용은 [Formatter/Provider API](#formatterprovider-api)를 참고하세요. 하지만 커스텀 포매터 작성은 어렵기 때문에 래퍼 타입을 만드는 것을 추천합니다. 예를 들어, `AnimationCurve`라는 외부 타입을 직렬화하고 싶을 때:

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

래핑할 타입은 public이지만, 직렬화에서는 제외(`MemoryPackIgnore`)됩니다. 직렬화할 속성은 private이지만, 포함(`MemoryPackInclude`)됩니다. 두 가지 형태의 생성자도 준비해야 합니다. 직렬화기가 사용하는 생성자는 private이어야 합니다.

이대로라면 매번 래핑해야 하므로 불편합니다. 그리고 구조체 래퍼는 null을 표현할 수 없습니다. 따라서 커스텀 포매터를 만들어 봅시다.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity는 scoped와 TBufferWriter를 지원하지 않으므로 시그니처를 `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`로 변경합니다.
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

마지막으로, 시작 시 포매터를 등록하세요.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> 참고: Unity의 AnimationCurve는 기본적으로 직렬화가 가능하므로 AnimationCurve에 대한 이 커스텀 포매터가 필요하지 않습니다.

패키지
---
MemoryPack에는 다음과 같은 패키지들이 있습니다.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack`는 메인 라이브러리로, 고성능 이진 객체의 직렬화 및 역직렬화를 완벽하게 지원합니다. `MemoryPack.Core`는 핵심 베이스 라이브러리에 의존하고, `MemoryPack.Generator`는 코드 생성에 사용됩니다. `MemoryPack.Streaming`은 [Streaming Serialization](#streaming-serialization)에 대한 확장 기능을 추가합니다. `MemoryPack.AspNetCoreMvcFormatter`는 ASP.NET Core용 입력/출력 포매터를 추가합니다. `MemoryPack.UnityShims`는 .NET과 Unity 간의 타입 공유를 위한 Unity Shim 타입과 포매터를 추가합니다.

TypeScript 및 ASP.NET Core Formatter
---
MemoryPack은 TypeScript 코드 생성을 지원합니다. C#에서 클래스 및 직렬화 코드를 생성하며, 즉 OpenAPI, proto 등을 사용하지 않고도 브라우저와 타입을 공유할 수 있습니다.

코드 생성은 Source Generator와 통합되어 있으며, 다음 옵션(`MemoryPackGenerator_TypeScriptOutputDirectory`)은 TypeScript 코드의 출력 디렉터리를 설정합니다. 런타임 코드는 동시에 출력되므로 추가 의존성이 필요하지 않습니다.

```xml
<!-- memorypack TypeScript 코드를 디렉터리에 출력 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

C#의 MemoryPackable 타입은 `[GenerateTypeScript]`로 어노테이션되어야 합니다.

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

런타임 코드와 TypeScript 타입이 대상 디렉터리에 생성됩니다.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

생성된 코드는 다음과 같으며, serialize/serializeArray 및 deserialize/deserializeArray를 위한 단순한 필드와 정적 메서드를 포함합니다.

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
        // 생략...
    }

    static serialize(value: Person | null): Uint8Array {
        // 생략...
    }

    static serializeCore(writer: MemoryPackWriter, value: Person | null): void {
        // 생략...
    }

    static serializeArray(value: (Person | null)[] | null): Uint8Array {
        // 생략...
    }

    static serializeArrayCore(writer: MemoryPackWriter, value: (Person | null)[] | null): void {
        // 생략...
    }
    static deserialize(buffer: ArrayBuffer): Person | null {
        // 생략...
    }

    static deserializeCore(reader: MemoryPackReader): Person | null {
        // 생략...
    }

    static deserializeArray(buffer: ArrayBuffer): (Person | null)[] | null {
        // 생략...
    }

    static deserializeArrayCore(reader: MemoryPackReader): (Person | null)[] | null {
        // 생략...
    }
}
```

이 타입은 다음과 같이 사용할 수 있습니다.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// Uint8Array로 직렬화
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// ArrayBuffer에서 역직렬화
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` 패키지는 ASP.NET Core MVC를 위한 `MemoryPack` 입력 및 출력 포매터를 추가합니다. 다음 코드로 ASP.NET Core MVC에 `MemoryPackInputFormatter`, `MemoryPackOutputFormatter`를 추가할 수 있습니다.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // checkContentType: true로 설정하면 여러 포맷(JSON/MemoryPack 등) 출력을 지원합니다. 기본값은 false입니다.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

HttpClient에서 호출할 경우, content-header에 `application/x-memorypack`를 설정할 수 있습니다.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript 타입 매핑

생성할 수 있는 타입에는 몇 가지 제한이 있습니다. 기본형 중 `char`와 `decimal`은 지원하지 않습니다. 또한 OpenGenerics 타입은 사용할 수 없습니다.

|  C#  |  TypeScript  | 설명 |
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
| `Guid` |  `string`  | TypeScript에서는 문자열로 표현되지만 직렬화/역직렬화 시 16바이트 바이너리로 처리됨
| `DateTime` | `Date` | DateTimeKind는 무시됨
| `enum` | `const enum` | `long` 및 `ulong` 기반 형식은 지원되지 않음
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | `List<T>` 등 모든 `ICollection<T>` 구현 타입 지원
| `: ISet<T>` | `Set<T> \| null` | `HashSet<T>` 등 모든 `ISet<T>` 구현 타입 지원
| `: IDictionary<K,V>` | `Map<K, V> \| null` | `Dictionary<K,V>` 등 모든 `IDictionary<K,V>` 구현 타입 지원
| `[MemoryPackable]` | `class` | 클래스만 지원
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]`는 클래스에만 적용 가능하며, 현재 struct는 지원하지 않습니다.

### import 파일 확장자 및 멤버 이름 케이싱 설정

기본적으로 MemoryPack은 `.js` 확장자를 사용하여 파일을 생성합니다(예: `import { MemoryPackWriter } from "./MemoryPackWriter.js";`). 다른 확장자나 빈 값으로 변경하려면 `MemoryPackGenerator_TypeScriptImportExtension`을 사용해 설정할 수 있습니다.
또한 멤버 이름은 자동으로 camelCase로 변환됩니다. 원래 이름을 사용하려면 `MemoryPackGenerator_TypeScriptConvertPropertyName`을 `false`로 설정하세요.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- 빈 값 허용 -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- 기본값은 true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- 기본값은 false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes`를 설정하면 C#의 Nullable 주석이 TypeScript 코드에 반영됩니다. 기본값은 false로, 모든 항목이 Nullable 처리됩니다.

스트리밍 직렬화
---
`MemoryPack.Streaming`은 컬렉션을 스트림으로 직렬화 및 역직렬화할 수 있도록 추가 지원을 제공하는 `MemoryPackStreamingSerializer`를 제공합니다.

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
Formatter를 직접 구현하려면 `MemoryPackFormatter<T>`를 상속받아 `Serialize`와 `Deserialize` 메서드를 오버라이드 하세요.

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

        // writer 메서드 사용.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // reader 메서드 사용.
    }
}
```
생성된 포매터는 `MemoryPackFormatterProvider`에 등록해야 합니다.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

참고: `unmanaged struct`(참조 타입을 포함하지 않는 구조체)는 커스텀 포매터를 사용할 수 없으며 항상 네이티브 메모리 레이아웃으로 직렬화됩니다.

MemoryPackWriter/ReaderOptionalState
---
`MemoryPackWriter`/`MemoryPackReader`를 초기화하려면 OptionalState가 필요합니다. 이는 `MemoryPackSerializerOptions`의 래퍼이며, `MemoryPackWriterOptionalStatePool`에서 생성할 수 있습니다.

```csharp
// Dispose 시 OptionalState는 풀로 반환됨.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// Reader의 경우
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

대상 프레임워크 의존성
---
MemoryPack은 `netstandard2.1`과 `net7.0`을 지원하지만, 두 버전은 호환되지 않습니다. 예를 들어, `netstandard2.1` 프로젝트의 MemoryPackable 타입을 `net7.0` 프로젝트에서 사용할 경우 다음과 같은 런타임 예외가 발생합니다.

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

net7.0은 static abstract 멤버(`Virtual static method`)를 사용하지만, 이는 netstandard2.1에서 지원되지 않으므로 발생하는 명세상 동작입니다.

.NET 7 프로젝트는 netstandard 2.1 DLL을 사용해서는 안 됩니다. 즉, 애플리케이션이 .NET 7 프로젝트라면, MemoryPack을 사용하는 모든 의존성 역시 .NET 7을 지원해야 합니다. 라이브러리 개발자가 MemoryPack에 의존성이 있다면, 듀얼 타겟 프레임워크를 설정해야 합니다.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion)은 protobuf 대신 MessagePack을 사용하는 코드 우선 grpc-dotnet 프레임워크입니다. MagicOnion은 이제 `MagicOnion.Serialization.MemoryPack` 패키지(preview)를 통해 MemoryPack을 직렬화 계층으로 지원합니다. 자세한 내용은 [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)를 참고하세요.

Unity
---

최소 지원 Unity 버전은 `2022.3.12f1`입니다.

`MemoryPack` 코어 패키지는 nuget을 통해 제공되며, Unity에서도 사용할 수 있습니다. Unity의 내장 타입 지원이 필요한 경우, 추가로 MemoryPack.Unity 확장 패키지를 제공합니다.

1. [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)를 이용해 NuGet에서 `MemoryPack` 설치

* NuGet -> Manage NuGet Packages 창을 열고, "MemoryPack"을 검색하여 Install을 누르세요.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* 버전 충돌 오류가 발생하면, Player Settings(Edit -> Project Settings -> Player -> "Other Settings" 펼친 후 "Configuration" 섹션의 "Assembly Version Validation" 체크 해제)를 통해 버전 검증을 비활성화하세요.

2. git URL 참조로 `MemoryPack.Unity` 패키지 설치

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack은 *.*.* 릴리스 태그를 사용하므로, 버전을 명시할 수 있습니다(예: #1.0.0). 예시: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


.NET 버전과 동일하게, 코드는 코드 생성기(`MemoryPack.Generator.dll`)에 의해 생성됩니다. 리플렉션 없는 구현으로 IL2CPP에서도 최고의 성능을 제공합니다.

Unity와 소스 생성기에 대한 자세한 내용은 [Unity documentation](https://docs.unity3d.com/Manual/roslyn-analyzers.html)을 참고하세요.

소스 생성기는 Unity에서 공식적으로 [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html), [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) 등에서 사용되고 있습니다. 즉, 차세대 Unity 코드 생성의 표준입니다.

모든 언매니지드 타입(`Vector3`, `Rect` 등)과 일부 클래스(`AnimationCurve`, `Gradient`, `RectOffset`)를 직렬화할 수 있습니다. Unity 고유 타입을 추가로 직렬화하고 싶다면 [외부 타입 직렬화](#serialize-external-types) 섹션을 참고하세요.

Unity에서의 성능은 JsonUtility 대비 MemoryPack이 x3~x10 더 빠릅니다.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

공유 코드에 Unity 타입(`Vector2` 등)이 포함되어 있다면, NuGet에서 `MemoryPack.UnityShims` 패키지를 제공합니다.

`MemoryPack.UnityShims` 패키지는 Unity 표준 구조체(`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) 및 일부 클래스(`AnimationCurve`, `Gradient`, `RectOffset`)의 shim을 제공합니다.

> [!WARNING]
> 현재 Unity에서 다음과 같은 제한 사항이 있습니다.


1. Unity 버전에서는 CustomFormatter를 지원하지 않습니다.
2. .NET7 이상을 사용하는 경우, MemoryPack 바이너리 포맷이 Unity와 완전히 호환되지 않습니다.
    - `[StructLayout(LayoutKind.Auto)]`가 명시된 값 타입에서 이 문제가 발생합니다(구조체의 기본은 `LayoutKind.Sequential`). 이러한 타입은 .NET에서 직렬화한 바이너리를 Unity에서 역직렬화할 수 없고, 반대로도 마찬가지입니다.
    - 영향받는 대표 타입은 다음과 같습니다.
        - `DateTimeOffset`
        - `ValueTuple`
    - 현재로선, 해당 타입을 사용하지 않는 것이 가장 간단한 해결책입니다.


Native AOT
---
아쉽게도 .NET 7 Native AOT에서 런타임 버그로 인해 MemoryPack을 사용할 경우 크래시(`Generic virtual method pointer lookup failure`)가 발생합니다. 
.NET 8에서 수정될 예정입니다. ``Microsoft.DotNet.ILCompiler` preview 버전을 사용하면 .NET 7에서도 해결할 수 있습니다. [이슈 코멘트](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611)를 참고해 설정하세요.

바이너리 와이어 포맷 명세
---
`Serialize<T>`와 `Deserialize<T>`에 정의된 `T`의 타입을 C# 스키마라고 합니다. MemoryPack 포맷은 자기 기술적(self-described) 포맷이 아닙니다. 역직렬화 시에는 반드시 대응되는 C# 스키마가 필요합니다. 이러한 타입은 바이너리 내부 표현으로 존재하지만, C# 스키마 없이는 타입을 판별할 수 없습니다.

Endian은 반드시 `Little Endian`이어야 합니다. 단, 참조 C# 구현체는 Endian을 고려하지 않으므로 빅 엔디언 머신에서는 사용할 수 없습니다. 그러나 현대 컴퓨터는 대부분 리틀 엔디언입니다.

포맷 종류는 총 8가지가 있습니다.

* Unmanaged struct
* Object
* Version Tolerant Object
* 순환 참조 객체
* 튜플
* 컬렉션
* 문자열
* 유니언

### Unmanaged struct

Unmanaged struct는 참조 타입을 포함하지 않는 C# struct로, [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)와 유사한 제약을 가집니다. struct 레이아웃을 그대로 직렬화하며, 패딩도 포함됩니다.

### Object

`(byte memberCount, [values...])`

Object는 헤더에 멤버 수를 나타내는 1바이트 부호 없는 바이트가 있습니다. 멤버 수는 `0`부터 `249`까지 허용되며, `255`는 객체가 `null`임을 나타냅니다. Values는 멤버 수만큼의 memorypack 값을 저장합니다.

### Version Tolerant Object

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Version Tolerant Object는 Object와 유사하지만, 헤더에 값의 바이트 길이가 포함됩니다. varint는 다음 사양을 따릅니다. 첫 번째 sbyte는 값 또는 typeCode이고, 그 다음 X 바이트가 값입니다. 0~127 = 부호 없는 바이트 값, -1~ -120 = 부호 있는 바이트 값, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### 순환 참조 객체

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

순환 참조 객체는 Version Tolerant Object와 유사하지만, memberCount가 250이면 다음 varint(unsigned-int32)는 referenceId가 됩니다. 그렇지 않으면, byte-length-of-values 다음에 varint referenceId가 기록됩니다.

### 튜플

`(values...)`

튜플은 고정 크기의 null이 될 수 없는 값 컬렉션입니다. .NET에서 `KeyValuePair<TKey, TValue>`와 `ValueTuple<T,...>`는 튜플로 직렬화됩니다.

### 컬렉션

`(int length, [values...])`

컬렉션은 헤더에 데이터 개수를 나타내는 4바이트 부호 있는 정수를 가지며, `-1`은 `null`을 나타냅니다. Values는 length만큼의 memorypack 값을 저장합니다.

### 문자열

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

문자열은 두 가지 형식, UTF16과 UTF8을 가집니다. 첫 4바이트 부호 있는 정수가 `-1`이면 null을 나타냅니다. `0`이면 빈 문자열을 의미합니다. UTF16은 컬렉션과 동일하게 처리되며(`ReadOnlySpan<char>`로 직렬화), utf16-value의 바이트 수는 utf16-length * 2입니다. 첫 정수가 `-2` 이하이면, 값은 UTF8로 인코딩됩니다. utf8-byte-count는 보수로 인코딩되며, 바이트 수를 얻으려면 `~utf8-byte-count`를 사용합니다. 다음 정수는 utf16-length이며, `-1`이 허용되어 길이를 알 수 없는 경우를 나타냅니다. utf8-bytes는 utf8-byte-count만큼의 바이트를 저장합니다.

### 유니언

`(byte tag, value)`  
`(250, ushort tag, value)`

첫 번째 부호 없는 바이트는 구분 값 타입이나 플래그를 위한 태그입니다. `0`부터 `249`까지는 태그를 나타내고, `250`은 다음 부호 없는 short가 태그임을 나타내며, `255`는 유니언이 `null`임을 나타냅니다.

License
---
이 라이브러리는 MIT 라이선스 하에 제공됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---