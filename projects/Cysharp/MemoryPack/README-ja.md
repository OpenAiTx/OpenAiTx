# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

C# と Unity 向けのゼロエンコーディング超高速バイナリシリアライザー。

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json)、[protobuf-net](https://github.com/protobuf-net/protobuf-net)、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp)、[Orleans.Serialization](https://github.com/dotnet/orleans/) との比較。 .NET 7 / Ryzen 9 5950X マシンで計測。これらのシリアライザーは `IBufferWriter<byte>` メソッドを持ち、`ArrayBufferWriter<byte>` を使ってシリアライズし、バッファコピーの計測を避けるため再利用しています。

標準オブジェクトの場合、MemoryPack は他のバイナリシリアライザーより x10、高速なものでも x2 ~ x5 の速度差があります。構造体配列の場合、MemoryPack はさらに強力で、他のシリアライザーより最大 x50 ~ x200 の速度を発揮します。

MemoryPack は私にとって4つ目のシリアライザーで、これまでに有名なシリアライザー、~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~、~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~、[MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp) を作成してきました。MemoryPack の高速さの理由は、C# に特化し最適化されたバイナリフォーマットと、過去の経験をもとにしたチューニングされた実装にあります。また、.NET 7 と C# 11、インクリメンタルソースジェネレーターを活用した全く新しい設計です（.NET Standard 2.1 (.NET 5, 6) および Unity サポートもあります）。

他のシリアライザーは VarInt エンコーディングやタグ、文字列など多くのエンコーディング処理を行いますが、MemoryPack フォーマットは可能な限り C# のメモリをそのままコピーするゼロエンコーディング設計です。ゼロエンコーディングは FlatBuffers に似ていますが、特別な型は不要であり、MemoryPack のシリアライズ対象は POCO です。

パフォーマンス以外にも、MemoryPack には以下の機能があります。

* 最新のI/O API（`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`）に対応
* ネイティブAOTフレンドリーなソースジェネレーターによるコード生成、動的CodeGen（IL.Emit）なし
* リフレクションレスでジェネリックでないAPI
* 既存インスタンスへのデシリアライズ
* ポリモーフィズム（Union）シリアライズ
* 限定的なバージョン耐性（高速/デフォルト）と完全なバージョン耐性のサポート
* 循環参照のシリアライズ
* PipeWriter/Reader ベースのストリーミングシリアライズ
* TypeScript コード生成と ASP.NET Core フォーマッター
* Unity (2021.3) IL2CPP サポート（.NET ソースジェネレーター経由）

インストール
---
このライブラリは NuGet で配布されています。最高のパフォーマンスを得るには `.NET 7` の使用を推奨します。最低要件は `.NET Standard 2.1` です。

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

また、コードエディタには Roslyn 4.3.1 のサポートが必要です。たとえば Visual Studio 2022 バージョン 17.3、.NET SDK 6.0.401 など。詳細は [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) ドキュメントを参照してください。

Unity の場合、要件およびインストール手順は完全に異なります。詳細は [Unity](#unity) セクションをご覧ください。

クイックスタート
---
シリアライズ対象となる struct または class を定義し、`[MemoryPackable]` 属性と `partial` キーワードを付与します。

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

シリアライズコードは、C# のソースジェネレーター機能によって生成され、`IMemoryPackable<T>` インターフェースを実装します。Visual Studio ではクラス名上でショートカット `Ctrl+K, R` を押し、`*.MemoryPackFormatter.g.cs` を選択すると生成されたコードを確認できます。

`MemoryPackSerializer.Serialize<T>/Deserialize<T>` を呼び出して、オブジェクトインスタンスをシリアライズ/デシリアライズします。

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` メソッドは `byte[]` 型の戻り値だけでなく、`IBufferWriter<byte>` や `Stream` へのシリアライズにも対応しています。`Deserialize` メソッドは `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` に対応。非ジェネリック版もあります。

標準対応型
---
これらの型はデフォルトでシリアライズ可能です。

* .NET プリミティブ（`byte`, `int`, `bool`, `char`, `double` など）
* アンマネージド型（任意の `enum`、参照型を含まないユーザー定義 `struct`）
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
* イミュータブルコレクション（`ImmutableList<>` など）やインターフェース（`IImmutableList<>` など）

`[MemoryPackable]` `class` / `struct` / `record` / `record struct` の定義
---
`[MemoryPackable]` は任意の `class`, `struct`, `record`, `record struct`, `interface` に付与できます。型が参照型を含まない `struct` または `record struct`（[C# アンマネージド型](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)）の場合、追加の注釈（ignore, include, constructor, callbacks）は使用されず、メモリから直接シリアライズ/デシリアライズされます。

それ以外の場合、デフォルトでは `[MemoryPackable]` は公開インスタンスプロパティまたはフィールドをシリアライズします。`[MemoryPackIgnore]` でシリアライズ対象から除外し、`[MemoryPackInclude]` でプライベートメンバーをシリアライズ対象に昇格できます。

```csharp
[MemoryPackable]
public partial class Sample
{
    // デフォルトでシリアライズされる型
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // デフォルトではシリアライズされない型
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // 公開メンバーを対象外にするには [MemoryPackIgnore] を使用
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // プライベートメンバーを対象にするには [MemoryPackInclude] を使用
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack` のコードジェネレーターは、どのメンバーがシリアライズされるかの情報を `<remarks />` セクションに追加します。Intellisense で型にマウスオーバーすることで確認できます。

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

全てのメンバーが MemoryPack でシリアライズ可能である必要があり、そうでない場合コードジェネレーターはエラーを出力します。

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack には 35個の診断ルール（`MEMPACK001` から `MEMPACK035`）が用意されており、快適に定義できます。

ターゲット型が MemoryPack シリアライズを外部で定義・登録している場合、`[MemoryPackAllowSerialize]` を使うことで診断を抑制できます。

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

メンバーの順序は**重要**です。MemoryPack はメンバー名や他の情報をシリアライズせず、宣言順にフィールドをシリアライズします。型が継承されている場合、親→子の順でシリアライズされます。メンバーの順序はデシリアライズのために変更できません。スキーマ進化については [Version tolerant](#version-tolerant) セクションを参照してください。

デフォルトは順次順序ですが、`[MemoryPackable(SerializeLayout.Explicit)]` と `[MemoryPackOrder()]` で明示的なレイアウトを選択できます。

```csharp
// Prop0 -> Prop1 の順でシリアライズ
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### コンストラクターの選択

MemoryPack はパラメータあり・なし両方のコンストラクターに対応しています。コンストラクターの選択は以下のルールに従います（クラス・構造体に適用）。

* `[MemoryPackConstructor]` があればそれを使用
* 明示的なコンストラクター（private含む）がなければパラメータなしを使用
* パラメータなし/ありコンストラクターが一つだけ（private含む）ならそれを使用
* 複数コンストラクターがある場合は、希望のコンストラクターに `[MemoryPackConstructor]` 属性を付与（自動選択しない）、付与しない場合はエラー
* パラメータ付きコンストラクターを使う場合、全パラメータ名は対応するメンバー名と一致（大文字小文字無視）

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // パラメータ付きコンストラクターも利用可能 - パラメータ名はメンバー名と一致（大文字小文字無視）
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// record の主コンストラクターにも対応
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
// 複数のコンストラクタが存在する場合は、[MemoryPackConstructor] を使用する必要があります
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### シリアライズコールバック

シリアライズ/デシリアライズ時に、MemoryPack は `[MemoryPackOnSerializing]`、`[MemoryPackOnSerialized]`、`[MemoryPackOnDeserializing]`、`[MemoryPackOnDeserialized]` 属性を使用して前後のイベントを呼び出すことができます。静的メソッドとインスタンス（非静的）メソッド、パブリックおよびプライベートメソッドの両方に注釈を付けることができます。

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // メソッド呼び出し順は static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // プライベートメソッドにも対応
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

    // 注意: MemoryPackOnDeserializing のインスタンスメソッドは、`ref` でインスタンスが渡されない場合は呼び出されません
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

コールバックは引数なしのメソッドと `ref reader/writer, ref T value` メソッドの両方を許可します。例えば、ref コールバックでシリアライズ処理の前にカスタムヘッダを書き込んだり読んだりすることができます。

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1 の場合は where TBufferWriter : class, IBufferWriter<byte> を使用
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // ヘッダに GUID を出力
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // デシリアライズ前にカスタムヘッダを読み込む
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

`ref value` に値を設定すると、シリアライズ/デシリアライズに使用される値を変更できます。例えば、ServiceProvider からインスタンス化することができます。

```csharp
// このフォーマッタを使用する前に、ServiceProvider を設定してください
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

カスタムコレクションの定義
---
デフォルトでは、`[MemoryPackObject]` で注釈された型はメンバーをシリアライズしようとします。しかし、型がコレクション（`ICollection<>`, `ISet<>`, `IDictionary<,>`）の場合は、正しくシリアライズするために `GenerateType.Collection` を使用してください。

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

静的コンストラクタ
---
MemoryPackable クラスでは静的コンストラクタは定義できません（生成された partial クラスが使用するため）。代わりに、同じ処理を行うために `static partial void StaticConstructor()` を定義できます。

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

ポリモーフィズム（ユニオン）
---
MemoryPack は、インターフェースや抽象クラスオブジェクトのポリモーフィズムシリアライズをサポートします。MemoryPack ではこの機能をユニオン（Union）と呼びます。`[MemoryPackUnion]` 属性を注釈できるのはインターフェースと抽象クラスのみです。ユニークなユニオンタグが必要です。

```csharp
// [MemoryPackable] および継承型に [MemoryPackUnion] を注釈
// ユニオンは抽象クラスにも対応
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

// インターフェース型としてシリアライズ
var bin = MemoryPackSerializer.Serialize(data);

// インターフェース型としてデシリアライズ
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

`tag` は `0` ～ `65535` を許容し、特に `250` 未満では効率的です。
```
インターフェースと派生型が異なるアセンブリにある場合は、代わりに `MemoryPackUnionFormatterAttribute` を使用できます。フォーマッタは、C# 9.0 以降で `ModuleInitializer` を介して自動的に登録されるように生成されます。

> `ModuleInitializer` は Unity ではサポートされていないため、フォーマッタを手動で登録する必要があります。ユニオンフォーマッタを登録するには、Startup で `{ユニオンフォーマッタ名}Initializer.RegisterFormatter()` を手動で呼び出してください。例: `UnionSampleFormatterInitializer.RegisterFormatter()`。

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB でターゲット型の外側に定義
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

ユニオンはコード内で `DynamicUnionFormatter<T>` を使って組み立てることもできます。

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
`Serialize` には 3 つのオーバーロードがあります。

```csharp
// ジェネリックでない API も利用可能。これらのバージョンは最初の引数が Type、value は object? です
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

パフォーマンスのためには、`BufferWriter` を使用する API が推奨されます。これはバッファに直接シリアライズします。`System.IO.Pipelines` の `PipeWriter` や、ASP .NET Core の `BodyWriter` などに適用できます。

`byte[]` が必要な場合（例: [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) の `RedisValue` など）、返り値が `byte[]` の API はシンプルでほぼ同じ速さです。

`Stream` 用の `SerializeAsync` は、Flush のみ非同期であり、すべてを一度 MemoryPack の内部プールバッファにシリアライズし、その後 `WriteAsync` で書き込みます。そのため、バッファと Flush を分離・制御できる `BufferWriter` のオーバーロードの方が優れています。

完全なストリーミング書き込みを行いたい場合は、[Streaming Serialization](#streaming-serialization) セクションを参照してください。

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` では、文字列を UTF16 または UTF8 でシリアライズするかを設定できます。UTF8 エンコーディングの場合は `MemoryPackSerializerOptions.Utf8`、UTF16 では `MemoryPackSerializerOptions.Utf16`、デフォルトは `MemoryPackSerializerOptions.Default`（UTF8）です。null を渡すかデフォルトパラメータを使うと UTF8 になります。

C# の内部文字列表現が UTF16 であるため、UTF16 の方がパフォーマンスは良いですが、ペイロードが大きくなりがちです。ASCII 文字列の場合、UTF8 では 1 バイト、UTF16 では 2 バイトです。ペイロードサイズの違いが大きいため、デフォルトは UTF8 です。

データが非 ASCII（例: 日本語では 3 バイト以上となり、UTF8 の方が大きくなる）や、別途圧縮する必要がある場合は、UTF16 の方が良い場合もあります。

シリアライズ時に UTF8 または UTF16 を選択できますが、デシリアライズ時に指定する必要はありません。自動的に検出され、通常通りデシリアライズされます。

また、options から `IServiceProvider? ServiceProvider { get; init; }` を取得・設定できます。シリアライズプロセスから DI オブジェクト（例: `ILogger<T>` など）を取得するのに便利です（`MemoryPackReader/MemoryPackWriter` には .Options プロパティがあります）。

Deserialize API
---
`Deserialize` には、`ReadOnlySpan<byte>` および `ReadOnlySequence<byte>`、`Stream` のオーバーロードと `ref` サポートがあります。

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` オーバーロードは既存のインスタンスを上書きします。詳細は [Overwrite](#overwrite) セクションを参照してください。

`DeserializeAsync(Stream)` は完全なストリーミング読み取りではなく、まず MemoryPack の内部プールにストリームの終わりまで読み込んだ後、デシリアライズします。

完全なストリーミング読み取りを行いたい場合は、[Streaming Serialization](#streaming-serialization) セクションを参照してください。

Overwrite
---
アロケーションを減らすために、MemoryPack では既存のインスタンスへの上書きデシリアライズがサポートされています。これは `Deserialize(ref T? value)` オーバーロードで利用できます。

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// 既存インスタンスにデータを上書き
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack は可能な限り上書きを試みますが、以下の条件が一致しない場合は新しいインスタンスを作成します（通常のデシリアライズと同じ）。

* ref 値（オブジェクトグラフ内のメンバーを含む）が null の場合は新しいインスタンスを設定
* 引数なしコンストラクタのみ許可、引数付きコンストラクタが使われている場合は新しいインスタンスを作成
* 値が `T[]` の場合、長さが同じときのみ再利用、そうでなければ新しいインスタンスを作成
* `.Clear()` メソッドを持つコレクション（`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`）は Clear() を呼び出して再利用、それ以外は新しいインスタンスを作成

Version tolerant
---
デフォルト（`GenerateType.Object`）では、MemoryPack は限定的なスキーマ進化をサポートします。

* 非管理構造体（unmanaged struct）は変更不可
* メンバーの追加は可能、削除は不可
* メンバー名の変更は可能
* メンバーの順序変更は不可
* メンバー型の変更は不可

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 追加はOK
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// 削除はNG
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// 順序変更はNG
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

ユースケースとしては、古いデータを保存（ファイルや Redis など）し、新しいスキーマで読み出すことは常に可能です。RPC シナリオでは、スキーマがクライアントとサーバーの両方に存在するため、クライアントをサーバーより先にアップデートする必要があります。アップデート済みクライアントは古いサーバーに接続可能ですが、古いクライアントは新しいサーバーに接続できません。

デフォルトでは、古いデータを新しいスキーマで読み込むと、データ側に存在しないメンバーは `default` リテラルで初期化されます。
これを避けてフィールドやプロパティの初期値を使いたい場合は、`[SuppressDefaultInitialization]` を使用できます。

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < 古いデータが欠損していれば `111` が設定される
    
    public int Prop3 { get; set; } = 222; // < 古いデータが欠損していれば `default` が設定される
}
```

 `[SuppressDefaultInitialization]` には以下の制限があります:
- readonly, init-only, required 修飾子とは併用不可

次の [Serialization info](#serialization-info) セクションでは、CI などによるスキーマ変更チェックの方法を示しています。

`GenerateType.VersionTolerant` を使用すると、完全なバージョン耐性がサポートされます。

* 非管理構造体（unmanaged struct）はこれ以上変更不可
* すべてのメンバーで `[MemoryPackOrder]` を明示的に付与（`SerializeLayout.Sequential` を注釈した場合を除く）
* メンバーの追加・削除は可能だが順序の再利用は不可（欠番は利用可能）
* メンバー名の変更は可能
* メンバーの順序変更は不可
* メンバー型の変更は不可

```csharp
// 以下のどちらのパターンもシリアライズ／デシリアライズ可能
// VersionTolerantObject1 -> VersionTolerantObject2
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

// 削除済み
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// 追加済み
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// SerializeLayout.Sequential を明示的に設定した場合、自動的に順序付けされます。
// ただし、バージョン耐性のためにメンバーを削除することはできません。
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` はシリアライズ時に `GenerateType.Object` よりも遅くなります。また、ペイロードサイズもわずかに大きくなります。

シリアライズ情報
----
型のどのメンバーがシリアライズされるかは、IntelliSense で確認できます。また、コンパイル時にその情報をファイルへ出力するオプションもあります。`MemoryPackGenerator_SerializationInfoOutputDirectory` を以下のように設定します。

```xml
<!-- memorypack のシリアライズ情報をディレクトリに出力する -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

次のような情報がファイルに書き込まれます。

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

型がアンマネージドの場合、型名の前に `unmanaged` と表示されます。

```txt
unmanaged FooStruct
---
int x
int y
```

このファイルの差分を確認することで、危険なスキーマ変更を防ぐことができます。例えば、CI を使って次のようなルールを検知できます。

* アンマネージド型の変更
* メンバー順序の変更
* メンバーの削除

循環参照
---
MemoryPack は循環参照もサポートしています。これにより、ツリー状のオブジェクトをそのままシリアライズできます。

```csharp
// 循環参照を有効にするには GenerateType.CircularReference を使用します
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

例えば、[System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) のコードは次のようになります。

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

`GenerateType.CircularReference` はバージョン耐性と同じ特性を持ちます。ただし追加の制約として、パラメータなしのコンストラクタのみが許可されます。また、オブジェクト参照の追跡は `GenerateType.CircularReference` が付与されたオブジェクトに対してのみ行われます。他のオブジェクトも追跡したい場合はラップしてください。

CustomFormatter
---
`MemoryPackCustomFormatterAttribute<T>` あるいは（より高性能ですが複雑な）`MemoryPackCustomFormatterAttribute<TFormatter, T>` を実装することで、MemoryPackObject のメンバーにカスタムフォーマッタを設定できます。

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack には次のフォーマッタ属性が用意されています：`Utf8StringFormatterAttribute`、`Utf16StringFormatterAttribute`、`InternStringFormatterAttribute`、`OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`、`BitPackFormatterAttribute`、`BrotliFormatter`、`BrotliStringFormatter`、`BrotliFormatter<T>`、`MemoryPoolFormatter<T>`、`ReadOnlyMemoryPoolFormatter<T>`。

```csharp
[MemoryPackable]
public partial class Sample
{
    // このメンバーを UTF16 文字列としてシリアライズします。UTF8 より高速ですが、ASCII ではサイズが大きくなり（非ASCII では小さくなる場合があります）。
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // デシリアライズ時に Dictionary が StringComparer.OrdinalIgnoreCase で初期化されます。
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // デシリアライズ時、すべての文字列がインターン化されます（参照：String.Intern）。同じ値が繰り返し出現する場合、メモリを節約できます。
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

セット／ディクショナリの EqualityComparer を設定するために、すべての組み込みフォーマッタには comparer コンストラクタのオーバーロードがあります。カスタムの EqualityComparer フォーマッタも簡単に作成できます。

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

`BitPackFormatter` は `bool[]` 型専用の圧縮フォーマッタです。通常、`bool[]` は各要素ごとに1バイトでシリアライズされますが、`BitPackFormatter` では `BitArray` のように各 bool を1ビットで格納します。`BitPackFormatter` を使うと、8個の bool が1バイトになり、通常の8分の1のサイズになります。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` は `byte[]` 用です。例えば、Brotli で大きなペイロードを圧縮できます。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` は `string` 用で、文字列（UTF16）を Brotli で圧縮してシリアライズします。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
```
`BrotliFormatter<T>` は任意の型に対応しており、シリアライズされたデータをBrotliで圧縮します。型が `byte[]` や `string` の場合は、パフォーマンスのために `BrotliFormatter` や `BrotliStringFormatter` を使用してください。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

配列プーリングによるデシリアライズ
---
大きな配列（任意の `T`）をデシリアライズするために、MemoryPackは効率的な複数のプーリング手法を提供します。最も効果的な方法は[#Overwrite](#overwrite) 機能を使用することです。特に `List<T>` は常に再利用されます。

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> は再利用され、デシリアライズ時にアロケーションが発生しません。
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// 効率的な操作のために、CollectionsMarshalでSpan<T>を取得できます
var span = CollectionsMarshal.AsSpan(value.Payload);
```

便利な方法として、デシリアライズ時にArrayPoolにデシリアライズする方法もあります。MemoryPackは `MemoryPoolFormatter<T>` と `ReadOnlyMemoryPoolFormatter<T>` を提供しています。

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

    // 戻り値のコードは自分で記述する必要があります。以下はスニペットです。

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
    // 何らかの処理...
}   // ArrayPoolに返却される
```

パフォーマンス
---
私のブログ記事 [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516) をご覧ください。

ペイロードサイズと圧縮
---
ペイロードサイズはターゲット値によって異なります。JSONと異なりキーがなくバイナリ形式のため、ペイロードサイズはJSONより小さくなる傾向があります。

MessagePackやProtobufのようなvarintエンコーディングを持つものでは、MemoryPackはintを多用するとサイズが大きくなりがちです（MemoryPackではintは常に固定長4バイト、MessagePackでは1～5バイト）。

floatおよびdoubleはMemoryPackで4バイト・8バイトですが、MessagePackでは5バイト・9バイトです。したがって、例えばVector3（float, float, float）の配列ではMemoryPackの方が小さくなります。

文字列はデフォルトでUTF8で、これは他のシリアライザと同様ですが、UTF16オプションを選択した場合は性質が異なります。

いずれにしても、ペイロードサイズが大きい場合は圧縮を検討すべきです。LZ4、ZStandard、Brotliが推奨されます。

### 圧縮

MemoryPackは [Brotli](https://github.com/google/brotli) 圧縮のための効率的なヘルパーを [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) および [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder) 経由で提供します。MemoryPackの `BrotliCompressor` および `BrotliDecompressor` はMemoryPackの内部動作に最適化された圧縮・解凍を提供します。

```csharp
using MemoryPack.Compression;

// 圧縮（usingが必要）
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// 圧縮されたbyte[]を取得
var compressedBytes = compressor.ToArray();

// または他の IBufferWriter<byte>（例えばPipeWriter）に書き込む
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// 解凍（usingが必要）
using var decompressor = new BrotliDecompressor();

// ReadOnlySpan<byte> または ReadOnlySequence<byte> から解凍済み ReadOnlySequence<byte> を取得
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

`BrotliCompressor` と `BrotliDecompressor` はどちらもstructであり、ヒープ上にメモリを割り当てません。どちらも内部メモリプールに圧縮済みまたは解凍済みデータを格納してSerialize/Deserializeします。そのため、メモリプーリングの解放が必要です。`using` の使用を忘れないでください。

圧縮レベルは非常に重要です。デフォルトはquality-1（CompressionLevel.Fastest）に設定されており、.NETのデフォルト（CompressionLevel.Optimal, quality-4）とは異なります。

Fastest（quality-1）は [LZ4](https://github.com/lz4/lz4) の速度に近くなりますが、4ははるかに遅くなります。これはシリアライザ利用シナリオで重要と判断されました。標準の `BrotliStream` を使用する場合（デフォルトはquality-4）には注意してください。いずれにせよ、圧縮・解凍速度やサイズはデータによって大きく異なります。ご自身のアプリケーションで扱うデータを用意し、必ずテストしてください。

MemoryPackの非圧縮時とBrotli圧縮追加時では、速度に数倍の差があることに注意してください。

Brotliはカスタムフォーマッタでもサポートされています。`BrotliFormatter` は特定のメンバを圧縮できます。

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

外部型のシリアライズ
---
外部型をシリアライズしたい場合は、カスタムフォーマッタを作成してプロバイダに登録できます。詳細は [Formatter/Provider API](#formatterprovider-api) をご覧ください。ただし、カスタムフォーマッタの作成は難易度が高いです。したがって、ラッパー型の作成を推奨します。たとえば、`AnimationCurve` という外部型をシリアライズしたい場合は次のようになります。

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

ラップする型はpublicですが、シリアライズからは除外されています（`MemoryPackIgnore`）。シリアライズしたいプロパティはprivateですが、`MemoryPackInclude` で含めています。2つのパターンのコンストラクタも用意すべきです。シリアライザが使用するコンストラクタはprivateにしてください。

このままだと毎回ラップする必要があり不便です。また、structラッパーではnullを表現できません。そこでカスタムフォーマッタを作成しましょう。

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // UnityはscopedとTBufferWriterをサポートしていないので、シグネチャを `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)` に変更してください
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
        reader.Advance(1); // nullブロックをスキップ
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

最後に、スタートアップでフォーマッタを登録します。

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> 注意: UnityのAnimationCurveはデフォルトでシリアライズ可能なので、AnimationCurve用のこのカスタムフォーマッタは不要です。

パッケージ
---
MemoryPack には以下のパッケージがあります。

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` はメインライブラリであり、高速なバイナリオブジェクトのシリアライズ・デシリアライズを完全にサポートします。`MemoryPack.Core` (コアベースライブラリ)と `MemoryPack.Generator` (コード生成) に依存します。`MemoryPack.Streaming` は [ストリーミングシリアライズ](#streaming-serialization) のための拡張機能を追加します。`MemoryPack.AspNetCoreMvcFormatter` は ASP.NET Core 用の入出力フォーマッタを追加します。`MemoryPack.UnityShims` は .NET と Unity 間で型を共有するためのUnity用シム型およびフォーマッタを追加します。

TypeScript および ASP.NET Core フォーマッタ
---
MemoryPack は TypeScript コード生成をサポートします。C# からクラスとシリアライズコードを生成します。つまり、OpenAPI や proto などを使用せずにブラウザと型を共有できます。

コード生成は Source Generator と統合されており、以下のオプション (`MemoryPackGenerator_TypeScriptOutputDirectory`) で TypeScript コードの出力ディレクトリを設定します。ランタイムコードも同時に出力されるため、追加の依存関係は不要です。

```xml
<!-- memorypack の TypeScript コードをディレクトリに出力 -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

C# の MemoryPackable 型は `[GenerateTypeScript]` で注釈付けする必要があります。

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

ランタイムコードとTypeScript型がターゲットディレクトリに生成されます。

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

生成されたコードは以下の通りです。シンプルなフィールドおよび serialize/serializeArray、deserialize/deserializeArray の静的メソッドを持ちます。

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

この型は次のように利用できます。

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// Uint8Array にシリアライズ
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// ArrayBuffer からデシリアライズ
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` パッケージは、ASP.NET Core MVC 用の `MemoryPack` 入出力フォーマッタを追加します。以下のコードで `MemoryPackInputFormatter` と `MemoryPackOutputFormatter` を ASP.NET Core MVC に追加できます。

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // checkContentType: true の場合、複数のフォーマット(JSON/MemoryPack等)を出力できます。デフォルトは false。
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

HttpClient から呼び出す場合は、content-header に `application/x-memorypack` を指定できます。

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript 型マッピング

生成可能な型にはいくつか制限があります。プリミティブ型のうち `char` と `decimal` はサポートされません。また、OpenGenerics型も使用できません。

|  C#  |  TypeScript  | 説明 |
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
| `Guid` |  `string`  | TypeScriptでは文字列として表現されますが、シリアライズ/デシリアライズ時は16バイトのバイナリとして扱われます
| `DateTime` | `Date` | DateTimeKindは無視されます
| `enum` | `const enum` | 基本型が`long`および`ulong`の場合はサポートされていません
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | `List<T>`など、すべての`ICollection<T>`実装型をサポート
| `: ISet<T>` | `Set<T> \| null` | `HashSet<T>`など、すべての`ISet<T>`実装型をサポート
| `: IDictionary<K,V>` | `Map<K, V> \| null` | `Dictionary<K,V>`など、すべての`IDictionary<K,V>`実装型をサポート
| `[MemoryPackable]` | `class` | クラスのみサポート
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]`はクラスのみに適用可能で、現在structはサポートされていません。

### インポートファイル拡張子とメンバー名の大文字小文字変換の設定

デフォルトでは、MemoryPackはファイル拡張子を`.js`として生成します（例：`import { MemoryPackWriter } from "./MemoryPackWriter.js";`）。他の拡張子や空にしたい場合は、`MemoryPackGenerator_TypeScriptImportExtension`を設定してください。
また、メンバー名は自動的にcamelCaseへ変換されます。元の名前を使用したい場合は、`MemoryPackGenerator_TypeScriptConvertPropertyName`を`false`に設定します。

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- 空も可能 -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- デフォルトはtrue -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- デフォルトはfalse -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes`を有効にすると、C#のnullableアノテーションがTypeScriptコードに反映されます。デフォルトはfalseで、すべてnullableになります。

ストリーミングシリアライゼーション
---
`MemoryPack.Streaming`は、コレクションのストリームによるシリアライズ/デシリアライズを追加サポートする`MemoryPackStreamingSerializer`を提供します。

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

フォーマッタ／プロバイダーAPI
---
フォーマッタを手動で実装したい場合は、`MemoryPackFormatter<T>`を継承し、`Serialize`と`Deserialize`メソッドをオーバーライドしてください。

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

        // writerメソッドを使用
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // readerメソッドを使用
    }
}
```
作成したフォーマッタは`MemoryPackFormatterProvider`に登録します。

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

注意: `unmanaged struct`（参照型を含まない構造体）はカスタムフォーマッタを使用できません。常にネイティブメモリレイアウトでシリアライズされます。

MemoryPackWriter/ReaderOptionalState
---
`MemoryPackWriter`や`MemoryPackReader`の初期化にはOptionalStateが必要です。これは`MemoryPackSerializerOptions`のラッパーであり、`MemoryPackWriterOptionalStatePool`から生成できます。

```csharp
// Dispose時にOptionalStateがプールに返却されます
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// Readerの場合
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

ターゲットフレームワーク依存関係
---
MemoryPackは`netstandard2.1`と`net7.0`を提供しますが、両者は互換性がありません。たとえば、`netstandard2.1`プロジェクトでMemoryPackable型を作成し、それを`net7.0`プロジェクトから使用すると、以下のようなランタイム例外が発生します。

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

net7.0は静的抽象メンバー（`Virtual static method`）を使用しており、これはnetstandard2.1ではサポートされていないため、この動作は仕様です。

.NET 7プロジェクトでは、netstandard 2.1のdllを使用しないでください。つまり、アプリケーションが.NET 7プロジェクトの場合、MemoryPackを使用するすべての依存関係は.NET 7をサポートしている必要があります。ライブラリ開発者がMemoryPackへ依存する場合は、複数ターゲットフレームワークの設定が必要です。

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion)は、protobufの代わりにMessagePackを利用するコードファーストなgrpc-dotnetフレームワークです。MagicOnionは現在、シリアライズレイヤーとしてMemoryPackを`MagicOnion.Serialization.MemoryPack`パッケージ（プレビュー）経由でサポートしています。詳細は[MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)をご覧ください。

Unity
---

サポートされる最小Unityバージョンは`2022.3.12f1`です。

`MemoryPack`コアパッケージはnugetで提供されています。Unityでも利用可能です。Unityの組み込み型サポートが必要な場合は、MemoryPack.Unity拡張を追加で提供しています。

1. [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)を利用してNuGetから`MemoryPack`をインストール

* NuGetウィンドウを開き、「MemoryPack」で検索し、インストールを押します。
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* バージョン競合エラーが発生した場合は、Player Settingsでバージョンバリデーションを無効にしてください（Edit -> Project Settings -> Player -> "Other Settings"を展開し、"Assembly Version Validation"のチェックを外す）。

2. git URLを参照して`MemoryPack.Unity`パッケージをインストール

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPackは*.*.*リリースタグを使用しているため、`#1.0.0`のようにバージョンを指定できます。例：`https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


.NET版と同様に、コードはコードジェネレータ（`MemoryPack.Generator.dll`）によって生成されます。リフレクションフリーな実装はIL2CPPでも最高のパフォーマンスを提供します。

UnityとSource Generatorについての詳細は、[Unity公式ドキュメント](https://docs.unity3d.com/Manual/roslyn-analyzers.html)をご参照ください。

Source Generatorは[com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html)や[com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html)でも公式に利用されています。つまり、次世代Unityにおける標準的なコード生成手法です。

すべてのunmanaged型（`Vector3`や`Rect`等）や、一部のクラス（`AnimationCurve`、`Gradient`、`RectOffset`）をシリアライズできます。その他のUnity固有型をシリアライズしたい場合は、[外部型のシリアライズ](#serialize-external-types)セクションをご覧ください。

Unityでのパフォーマンスでは、MemoryPackはJsonUtilityより3～10倍高速です。

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

共有コードでUnity型（`Vector2`等）を利用する場合、MemoryPackはNuGetで`MemoryPack.UnityShims`パッケージも提供しています。

`MemoryPack.UnityShims`パッケージは、Unity標準構造体（`Vector2`、`Vector3`、`Vector4`、`Quaternion`、`Color`、`Bounds`、`Rect`、`Keyframe`、`WrapMode`、`Matrix4x4`、`GradientColorKey`、`GradientAlphaKey`、`GradientMode`、`Color32`、`LayerMask`、`Vector2Int`、`Vector3Int`、`RangeInt`、`RectInt`、`BoundsInt`）や一部のクラス（`AnimationCurve`、`Gradient`、`RectOffset`）のShimsを提供します。

> [!WARNING]
> 現在、Unityで使用する際には以下の制限があります


1. Unity版ではCustomFormatterはサポートされていません。
2. .NET7以降を使用している場合、MemoryPackバイナリフォーマットはUnityと完全互換ではありません。
    - この問題は、`[StructLayout(LayoutKind.Auto)]`が明示的に指定された値型で発生します（structのデフォルトは`LayoutKind.Sequencial`）。このような型では、.NETでシリアライズしたバイナリをUnityでデシリアライズできません。同様に、Unityでシリアライズしたバイナリは.NET側でデシリアライズできません。
    - 影響を受ける型の代表例は以下です。
        - `DateTimeOffset`
        - `ValueTuple`
    - 現状の簡単な解決策は、これらの型を使用しないことです。


Native AOT
---
残念ながら、.NET 7 Native AOTではMemoryPack使用時にランタイムバグによりクラッシュ（`Generic virtual method pointer lookup failure`）します。
この問題は.NET 8で修正予定です。`Microsoft.DotNet.ILCompiler`のプレビューバージョンを使用すると.NET 7でも修正されます。セットアップ方法は[issueのコメント](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611)をご参照ください。

バイナリワイヤフォーマット仕様
---
`Serialize<T>`および`Deserialize<T>`で定義される`T`の型をC#スキーマと呼びます。MemoryPackフォーマットは自己記述型フォーマットではありません。デシリアライズには対応するC#スキーマが必要です。これらの型はバイナリ内部表現として存在しますが、C#スキーマなしでは型を判定できません。

エンディアンは`リトルエンディアン`でなければなりません。ただし、C#リファレンス実装はエンディアンを考慮していないため、ビッグエンディアンマシンでは利用できません。なお、現代のコンピュータは通常リトルエンディアンです。

フォーマットには8種類あります。

* Unmanaged struct
* Object
* Version Tolerant Object
* 循環参照オブジェクト
* タプル
* コレクション
* 文字列
* ユニオン

### アンマネージド構造体

アンマネージド構造体は、参照型を含まないC#構造体であり、[C# アンマネージド型](https://learn.microsoft.com/ja-jp/dotnet/csharp/language-reference/builtin-types/unmanaged-types)の制約と同様です。構造体のレイアウトをそのままシリアライズし、パディングも含みます。

### オブジェクト

`(byte メンバー数, [値...])`

オブジェクトは、ヘッダーとして1バイトの符号なしバイトでメンバー数を持ちます。メンバー数は`0`から`249`まで許容し、`255`はオブジェクトが`null`であることを示します。値は、メンバー数分のメモリパック値が格納されます。

### バージョン耐性オブジェクト

`(byte メンバー数, [varint 値のバイト長...], [値...])`

バージョン耐性オブジェクトはオブジェクトと似ていますが、ヘッダーに値のバイト長を持ちます。varintは次の仕様に従います。最初のsbyteは値またはtypeCodeであり、次のXバイトが値です。0～127は符号なしバイト値、-1～-120は符号付きバイト値、-121はバイト、-122はsbyte、-123はushort、-124はshort、-125はuint、-126はint、-127はulong、-128はlong。

### 循環参照オブジェクト

`(byte メンバー数, [varint 値のバイト長...], varint 参照ID, [値...])`  
`(250, varint 参照ID)`

循環参照オブジェクトはバージョン耐性オブジェクトと似ていますが、メンバー数が250の場合、次のvarint（符号なし32ビット整数）が参照IDになります。そうでない場合、値のバイト長の後にvarint 参照IDが書き込まれます。

### タプル

`(値...)`

タプルは固定サイズでnull不可の値のコレクションです。.NETでは、`KeyValuePair<TKey, TValue>`および`ValueTuple<T,...>`がタプルとしてシリアライズされます。

### コレクション

`(int 長さ, [値...])`

コレクションは、ヘッダーとして4バイトの符号付き整数でデータ数を持ち、`-1`は`null`を示します。値は長さ分のメモリパック値が格納されます。

### 文字列

`(int utf16-長さ, utf16-値)`  
`(int ~utf8-バイト数, int utf16-長さ, utf8-バイト列)`

文字列はUTF16とUTF8の2つの形式があります。最初の4バイト符号付き整数が`-1`の場合、nullを示します。`0`は空を示します。UTF16はコレクションと同様（`ReadOnlySpan<char>`としてシリアライズ、utf16-値のバイト数はutf16-長さ×2）です。最初の符号付き整数が`-2`以下の場合、値はUTF8でエンコードされます。utf8-バイト数は補数でエンコードされているため、`~utf8-バイト数`でバイト数を取得します。次の符号付き整数はutf16-長さで、`-1`（不明な長さ）も許容します。utf8-バイト列はutf8-バイト数分のバイトを格納します。

### ユニオン

`(byte タグ, 値)`  
`(250, ushort タグ, 値)`

最初の符号なしバイトはタグで、判別付き値型またはフラグ用です。`0`～`249`はタグ、`250`は次の符号なしショートがタグ、`255`はユニオンが`null`であることを示します。

ライセンス
---
このライブラリはMITライセンスの下で提供されています。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---