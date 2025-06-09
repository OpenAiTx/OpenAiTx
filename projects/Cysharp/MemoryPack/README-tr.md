# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

C# ve Unity için sıfır kodlama, aşırı yüksek performanslı ikili serileştirici.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/) ile karşılaştırılmıştır. .NET 7 / Ryzen 9 5950X makinesiyle ölçülmüştür. Bu serileştiriciler `IBufferWriter<byte>` metoduna sahiptir, `ArrayBufferWriter<byte>` kullanılarak serileştirilmiş ve tampon kopyasının ölçülmemesi için yeniden kullanılmıştır.

Standart nesneler için, MemoryPack diğer ikili serileştiricilerden x10 daha hızlı ve x2 ~ x5 daha hızlıdır. Struct dizi için ise, MemoryPack çok daha güçlüdür ve diğer serileştiricilere göre x50 ~ x200 daha hızlıdır.

MemoryPack benim 4. serileştiricimdir, daha önce iyi bilinen serileştiricileri geliştirdim: ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). MemoryPack’in hızı, C#’a özgü, C#’a optimize edilmiş ikili formatı ve geçmiş tecrübelerime dayanan iyi ayarlanmış bir uygulamadan kaynaklanmaktadır. Ayrıca tamamen yeni bir tasarımdır ve .NET 7, C# 11 ve Artımlı Kaynak Oluşturucu’yu kullanır (.NET Standard 2.1 (.NET 5, 6) ve Unity desteği de mevcuttur).

Diğer serileştiriciler VarInt kodlama, etiket, dize gibi birçok kodlama işlemi yapar. MemoryPack formatı ise, mümkün olduğunca çok C# belleğini kopyalayan sıfır kodlama tasarımı kullanır. Sıfır kodlama, FlatBuffers'a benzer, ancak özel bir türe ihtiyaç duymaz, MemoryPack’in serileştirme hedefi POCO’dur.

Performansın yanı sıra, MemoryPack aşağıdaki özelliklere de sahiptir.

* Modern I/O API’lerini destekler (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Yerel AOT dostu Kaynak Üreteci tabanlı kod üretimi, Dinamik Kod Oluşturma (IL.Emit) yoktur
* Yansıtmasız, jenerik olmayan API’ler
* Mevcut örneğe serileştirme
* Polimorfizm (Union) serileştirme
* Sınırlı sürüm-toleranslı (hızlı/varsayılan) ve tam sürüm-toleranslı destek
* Dairesel referans serileştirme
* PipeWriter/Reader tabanlı akış serileştirme
* TypeScript kod üretimi ve ASP.NET Core Biçimlendirici
* Unity (2021.3) IL2CPP Desteği .NET Kaynak Üreteci ile

Kurulum
---
Bu kütüphane NuGet üzerinden dağıtılmaktadır. En iyi performans için `.NET 7` kullanmanız önerilir. Minimum gereksinim `.NET Standard 2.1`’dir.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Ayrıca, bir kod editörünün Roslyn 4.3.1 desteğine ihtiyacı vardır; örneğin Visual Studio 2022 sürüm 17.3, .NET SDK 6.0.401. Detaylar için [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) dokümanına bakınız.

Unity için, gereksinimler ve kurulum süreci tamamen farklıdır. Detaylar için [Unity](#unity) bölümüne bakınız.

Hızlı Başlangıç
---
Serileştirilecek bir struct veya class tanımlayın ve `[MemoryPackable]` özniteliği ile `partial` anahtar kelimesini ekleyin.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Serileştirme kodu, `IMemoryPackable<T>` arayüzünü uygulayan C# kaynak üreteci özelliğiyle oluşturulur. Visual Studio’da, sınıf adının üzerine gelip `Ctrl+K, R` kısayolu ile `*.MemoryPackFormatter.g.cs` dosyasını seçerek üretilen kodu görebilirsiniz.

Bir nesne örneğini serileştirmek/deserileştirmek için `MemoryPackSerializer.Serialize<T>/Deserialize<T>` metodunu çağırın.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

`Serialize` metodu `byte[]` döndürebildiği gibi, `IBufferWriter<byte>` veya `Stream`’e de serileştirme yapabilir. `Deserialize` metodu ise `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` ve `Stream`’i destekler. Ayrıca jenerik olmayan versiyonları da mevcuttur.

Yerleşik desteklenen türler
---
Varsayılan olarak şu türler serileştirilebilir:

* .NET ilkel türleri (`byte`, `int`, `bool`, `char`, `double`, vb.)
* Yönetilmeyen türler (Herhangi bir `enum`, referans türü içermeyen kullanıcı tanımlı her `struct`)
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
* Değişmez koleksiyonlar (`ImmutableList<>`, vb.) ve arayüzler (`IImmutableList<>`, vb.)

`[MemoryPackable]` `class` / `struct` / `record` / `record struct` Tanımlayın
---
`[MemoryPackable]` herhangi bir `class`, `struct`, `record`, `record struct` ve `interface`’a eklenebilir. Bir tür, referans türü içermeyen `struct` veya `record struct` ise ([C# Yönetilmeyen Türler](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), ek açıklama (yok say, dahil et, kurucu, geri çağırmalar) kullanılmaz, doğrudan bellekten serileştir/deserileştir edilir.

Aksi takdirde, varsayılan olarak `[MemoryPackable]` yalnızca genel örnek özellikleri veya alanları serileştirir. Serileştirme hedefini kaldırmak için `[MemoryPackIgnore]` kullanabilir, özel bir üyeyi serileştirme hedefine taşımak için `[MemoryPackInclude]` kullanabilirsiniz.

```csharp
[MemoryPackable]
public partial class Sample
{
    // bu türler varsayılan olarak serileştirilir
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // bu türler varsayılan olarak serileştirilmez
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // Genel bir üyenin serileştirme hedefinden kaldırılması için [MemoryPackIgnore] kullanılır
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // Özel bir üyeyi serileştirme hedefine taşımak için [MemoryPackInclude] kullanılır
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

`MemoryPack`’in kod üreteci, hangi üyelerin serileştirildiğine dair bilgiyi `<remarks />` bölümüne ekler. Bu bilgiye Intellisense ile türün üzerine gelerek erişebilirsiniz.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Tüm üyeler memorypack ile serileştirilebilir olmalıdır, aksi halde kod üreteci hata verir.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack, rahatça tanımlanması için 35 teşhis kuralına sahiptir (`MEMPACK001`'den `MEMPACK035`'e kadar).

Hedef tür harici olarak MemoryPack serileştirmesiyle tanımlanmış ve kaydedilmişse, uyarıları susturmak için `[MemoryPackAllowSerialize]` kullanın.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Üye sırası **önemlidir**, MemoryPack üye adını veya başka bilgileri serileştirmez, bunun yerine alanları bildirildikleri sırada serileştirir. Bir tür miras alıyorsa, serileştirme ebeveyn → çocuk sırası ile yapılır. Üye sırası, deserileştirme için değiştirilemez. Şema evrimi için [Version tolerant](#version-tolerant) bölümüne bakınız.

Varsayılan sıra sıralıdır, ancak `[MemoryPackable(SerializeLayout.Explicit)]` ve `[MemoryPackOrder()]` ile açık düzen seçebilirsiniz.

```csharp
// Prop0 -> Prop1 olarak serileştir
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Kurucu seçimi

MemoryPack hem parametreli hem de parametresiz kurucuları destekler. Kurucu seçimi şu kuralları izler. (Sınıf ve struct’lar için geçerlidir).

* `[MemoryPackConstructor]` varsa, onu kullanır.
* Açık bir kurucu yoksa (özel dahil), parametresiz olanı kullanır.
* Bir tane parametresiz/parametreli kurucu varsa (özel dahil), onu kullanır.
* Birden fazla kurucu varsa, istenen kurucuya `[MemoryPackConstructor]` özniteliği uygulanmalıdır (üreteç otomatik olarak birini seçmez), aksi halde üreteç hata verir.
* Parametreli kurucu kullanılıyorsa, tüm parametre adları karşılık gelen üye adlarıyla eşleşmelidir (büyük/küçük harf duyarsız).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Parametreli kurucu kullanabilirsiniz - parametre adları ilgili üye adlarıyla eşleşmelidir (büyük/küçük harf duyarsız)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// Kayıt birincil kurucu da desteklenir
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
// Birden fazla yapıcı varsa, [MemoryPackConstructor] kullanılmalıdır
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
}
```

### Serileştirme geri çağrıları

Serileştirme/serileştirmeyi kaldırma sırasında, MemoryPack `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]` özniteliklerini kullanarak bir önce/sonra olayını tetikleyebilir. Hem statik hem de örnek (statik olmayan) yöntemleri, ayrıca public ve private yöntemleri işaretleyebilir.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // metod çağrı sırası statik -> örnek
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // private yönteme de izin verir
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

    // Not: MemoryPackOnDeserializing ile örnek yöntemi, örnek `ref` ile aktarılmazsa çağrılmaz
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

Geri çağrılar parametresiz yöntem ve `ref reader/writer, ref T value` yöntemine izin verir. Örneğin, ref geri çağrılar serileştirme işleminden önce özel başlık yazabilir/okuyabilir.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, kullanımı: where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // başlığa GUID ekle.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // serileştirmeden önce özel başlık oku
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

`ref value`'ya bir değer atarsanız, serileştirme/serileştirmeden kaldırma için kullanılan değeri değiştirebilirsiniz. Örneğin, ServiceProvider'dan örneklendirme.

```csharp
// bu formatlayıcıyı kullanmadan önce ServiceProvider ayarla
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

Özel koleksiyon tanımlama
---
Varsayılan olarak, `[MemoryPackObject]` ile işaretlenen tür üyelerini serileştirmeye çalışır. Ancak, bir tür koleksiyon ise (`ICollection<>`, `ISet<>`, `IDictionary<,>`), doğru şekilde serileştirmek için `GenerateType.Collection` kullanılır.

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

Statik yapıcı
---
MemoryPackable sınıfı statik yapıcı tanımlayamaz çünkü oluşturulan partial sınıf bunu kullanır. Bunun yerine, aynı işlev için `static partial void StaticConstructor()` tanımlayabilirsiniz.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfizm (Union)
---
MemoryPack, polimorfizm serileştirmesi için arayüz ve soyut sınıf nesnelerinin serileştirilmesini destekler. MemoryPack'te bu özelliğe Union denir. Yalnızca arayüzler ve soyut sınıflar `[MemoryPackUnion]` öznitelikleriyle işaretlenebilir. Benzersiz union etiketleri gereklidir.

```csharp
// [MemoryPackable] ve kalıtım türlerini [MemoryPackUnion] ile işaretle
// Union, soyut sınıfı da destekler
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

// Arayüz türü olarak serileştir.
var bin = MemoryPackSerializer.Serialize(data);

// Arayüz türü olarak serileştirmeden kaldır.
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

`tag` değeri olarak `0` ~ `65535` kullanılabilir, özellikle `250`'den küçükse daha verimlidir.
```
Farklı assembly'lerde bir arayüz ve türetilmiş tipler bulunuyorsa, bunun yerine `MemoryPackUnionFormatterAttribute` kullanabilirsiniz. Formatlayıcılar, C# 9.0 ve üzeri sürümlerde `ModuleInitializer` aracılığıyla otomatik olarak kaydedilecek şekilde oluşturulur.

> Dikkat: `ModuleInitializer`, Unity'de desteklenmez, bu nedenle formatlayıcı elle kaydedilmelidir. Birleştirme formatlayıcınızı kaydetmek için `{birleştirme formatlayıcınızın adı}Initializer.RegisterFormatter()` metodunu Startup'ta elle çağırmalısınız. Örneğin: `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB hedef tipin dışında tanımlama yapar
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Bir birleştirme, kod üzerinden `DynamicUnionFormatter<T>` ile de oluşturulabilir.

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
`Serialize` metodunun üç aşırı yüklemesi vardır.

```csharp
// Generic olmayan API da mevcuttur, bu versiyonda ilk argüman Type ve değer object? olur
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Performans açısından önerilen API `BufferWriter` kullanır. Bu, doğrudan tampon içine serileştirir. `System.IO.Pipelines` içindeki `PipeWriter`, ASP .NET Core'daki `BodyWriter` vb. ile kullanılabilir.

Eğer bir `byte[]` gerekiyorsa (örn. [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis) içindeki `RedisValue` gibi), dönen `byte[]` API'si basit ve neredeyse aynı derecede hızlıdır.

Dikkat: `Stream` için `SerializeAsync` sadece Flush işlemi için asenkron çalışır; her şeyi bir kerede MemoryPack'in dahili havuz tamponuna serileştirir ve ardından `WriteAsync` ile yazar. Bu nedenle, tampon ve flush işlemini ayırıp kontrol edebilen `BufferWriter` aşırı yüklemesi daha iyidir.

Tam anlamıyla bir akış yazımı yapmak istiyorsanız, [Streaming Serialization](#streaming-serialization) bölümüne bakınız.

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions`, dizelerin UTF16 mı yoksa UTF8 olarak mı serileştirileceğini yapılandırır. Bu, UTF8 kodlaması için `MemoryPackSerializerOptions.Utf8`, UTF16 için `MemoryPackSerializerOptions.Utf16` veya varsayılan olarak UTF8 olan `MemoryPackSerializerOptions.Default` ile yapılandırılabilir. Null geçirilirse veya varsayılan parametre kullanılırsa, UTF8 kodlaması uygulanır.

C#'ın dahili dize temsili UTF16 olduğundan, UTF16 daha iyi performans gösterir. Ancak, yük genellikle daha büyük olur; UTF8'de bir ASCII dizesi bir bayt, UTF16'da ise iki bayttır. Bu yük boyutundaki fark oldukça büyük olduğundan, varsayılan olarak UTF8 ayarlanmıştır.

Veri ASCII dışındaysa (örn. Japonca, bu durumda 3 bayttan fazla olabilir ve UTF8 daha büyük olur) veya ayrıca sıkıştırmanız gerekiyorsa, UTF16 daha iyi sonuçlar verebilir.

Serileştirme sırasında UTF8 veya UTF16 seçilebilir, ancak serileştirme sırasında belirtmek gerekmez. Otomatik olarak algılanır ve normal şekilde serileştirilir.

Ek olarak, seçeneklerden `IServiceProvider? ServiceProvider { get; init; }` alabilir veya ayarlayabilirsiniz. Serileştirme işlemi sırasında DI nesnesi almak için (örn. `ILogger<T>`) kullanışlıdır (`MemoryPackReader/MemoryPackWriter`'da .Options özelliği vardır).

Deserialize API
---
`Deserialize`, `ReadOnlySpan<byte>` ve `ReadOnlySequence<byte>`, `Stream` aşırı yüklemeleri ve `ref` desteği sunar.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

`ref` aşırı yüklemesi mevcut bir örneği üzerine yazar, ayrıntılar için [Overwrite](#overwrite) bölümüne bakınız.

`DeserializeAsync(Stream)` tam anlamıyla bir akış okuma işlemi değildir, önce akışın sonuna kadar MemoryPack'in dahili havuzuna okur, ardından serileştirir.

Tam anlamıyla bir akış okuma işlemi yapmak istiyorsanız, [Streaming Serialization](#streaming-serialization) bölümüne bakınız.

Overwrite
---
Atamaları azaltmak için, MemoryPack mevcut bir örneğe serileştirmeye destek verir ve üzerine yazar. Bu, `Deserialize(ref T? value)` aşırı yüklemesiyle kullanılabilir.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// veriyi mevcut örneğe üzerine yaz.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack, mümkün olduğunca üzerine yazmaya çalışır; ancak aşağıdaki koşullar karşılanmazsa yeni bir örnek oluşturur (normal serileştirmede olduğu gibi).

* ref değer (nesne grafiğindeki üyeler dahil) null ise, yeni bir örnek atanır
* yalnızca parametresiz yapıcıya izin verilir, parametreli yapıcı kullanılmışsa yeni bir örnek oluşturulur
* değer `T[]` ise, yalnızca uzunluk aynıysa yeniden kullanılır, aksi takdirde yeni bir örnek oluşturulur
* değeri `.Clear()` metodu olan bir koleksiyon ise (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) Clear() çağrılır ve tekrar kullanılır, aksi takdirde yeni bir örnek oluşturulur

Version tolerant
---
Varsayılan olarak (`GenerateType.Object`), MemoryPack sınırlı şema evrimine destek verir.

* yönetilmeyen struct daha fazla değiştirilemez
* üye eklenebilir, ancak silinemez
* üye adı değiştirilebilir
* üye sırası değiştirilemez
* üye türü değiştirilemez

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Ekleme OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Silme NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Sıra değiştirmek NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

Kullanım senaryosunda, eski veri (dosyaya, redis'e vb.) saklanır ve yeni şemaya okunması her zaman mümkündür. RPC senaryosunda, şema hem istemci hem de sunucu tarafında bulunur, istemci sunucudan önce güncellenmelidir. Güncellenmiş istemcinin eski sunucuya bağlanmasında sorun yoktur; ancak eski istemci yeni sunucuya bağlanamaz.

Varsayılan olarak, eski veriler yeni şemaya okunduğunda, veride olmayan üyeler `default` literal ile başlatılır.
Bunu önlemek ve alan/özelliklerin başlangıç değerlerini kullanmak isterseniz, `[SuppressDefaultInitialization]` kullanabilirsiniz.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < eski veri eksikse, `111` atanır.
    
    public int Prop3 { get; set; } = 222; // < eski veri eksikse, `default` atanır.
}
```

 `[SuppressDefaultInitialization]` aşağıdaki kısıtlamalara sahiptir:
- Readonly, init-only ve required değiştiricilerle kullanılamaz.

Sonraki [Serialization info](#serialization-info) bölümü, şema değişikliklerini kontrol etmenin yollarını (ör. CI ile) gösterir ve kazaları önlemeye yardımcı olur.

`GenerateType.VersionTolerant` kullanıldığında, tam sürüm toleransı desteklenir.

* yönetilmeyen struct daha fazla değiştirilemez
* tüm üyelere açıkça `[MemoryPackOrder]` eklenmelidir (yalnızca `SerializeLayout.Sequential` ile işaretlenmemişse)
* üye eklenebilir, silinebilir fakat sıra yeniden kullanılamaz (eksik sıra kullanılabilir)
* üye adı değiştirilebilir
* üye sırası değiştirilemez
* üye türü değiştirilemez

```csharp
// Her iki şekilde de serileştirilebilir/serileştirilebilir
// VersionTolerantObject1 -> VersionTolerantObject2 ve 
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

// silindi
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// eklendi
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Eğer SerializeLayout.Sequential açıkça ayarlanırsa, otomatik sıralamaya izin verir.
// Ancak sürüme dayanıklı (version-tolerant) için herhangi bir üye kaldırılamaz.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant`, serileştirmede `GenerateType.Object`'tan daha yavaştır. Ayrıca, yük boyutu biraz daha büyük olacaktır.

Serileştirme Bilgisi
----
Bir tipte hangi üyelerin serileştirildiğini IntelliSense üzerinden kontrol edebilirsiniz. Ayrıca, bu bilgiyi derleme sırasında bir dosyaya yazmak için bir seçenek mevcuttur. `MemoryPackGenerator_SerializationInfoOutputDirectory` aşağıdaki gibi ayarlanır.

```xml
<!-- memorypack serileştirme bilgisini dizine çıktı olarak yaz -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Aşağıdaki bilgi dosyaya yazılır.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Eğer tip unmanaged ise, tip adının önünde `unmanaged` gösterilir.

```txt
unmanaged FooStruct
---
int x
int y
```

Bu dosyadaki farkları kontrol ederek, tehlikeli şema değişiklikleri önlenebilir. Örneğin, CI üzerinde aşağıdaki kuralları tespit etmek isteyebilirsiniz

* unmanaged tipin değiştirilmesi
* üye sırasının değişmesi
* üye silinmesi

Döngüsel Referans
---
MemoryPack, döngüsel referansı da destekler. Bu, ağaç nesnelerin olduğu gibi serileştirilmesine olanak tanır.

```csharp
// döngüsel referansı etkinleştirmek için GenerateType.CircularReference kullanılır
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Örneğin, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) kodu burada olduğu gibi olur.

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

`GenerateType.CircularReference`, version-tolerant ile aynı özelliklere sahiptir. Ancak ek bir kısıtlama olarak, yalnızca parametresiz yapıcıya (constructor) izin verilir. Ayrıca, nesne referans takibi sadece `GenerateType.CircularReference` ile işaretlenmiş nesneler için yapılır. Başka bir nesneyi takip etmek istiyorsanız, onu sarmalayın.

CustomFormatter
---
Eğer `MemoryPackCustomFormatterAttribute<T>` veya `MemoryPackCustomFormatterAttribute<TFormatter, T>` (daha performanslı ama daha karmaşık) uygularsanız, MemoryPackObject üyesi için özel biçimlendirici kullanılacak şekilde yapılandırabilirsiniz.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack aşağıdaki biçimlendirme özniteliklerini sağlar: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // Bu üyeyi UTF16 String olarak serileştir, UTF8'e göre daha performanslıdır ancak ASCII'de boyut daha büyüktür (ama ASCII olmayanlarda bazen daha küçüktür).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Serileştirme sırasında, Dictionary StringComparer.OrdinalIgnoreCase ile başlatılır.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Serileştirme sırasında, tüm string'ler intern edilir (bakınız: String.Intern). Benzer değerler tekrar tekrar gelirse, hafıza tasarrufu sağlar.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Bir set/dictionary'nin eşitlik karşılaştırıcısını yapılandırmak için, tüm yerleşik biçimlendiricilerin bir karşılaştırıcı kurucu aşırı yüklemesi vardır. Kendi özel eşitlik-karşılaştırıcı biçimlendiricinizi kolayca oluşturabilirsiniz.

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

`BitPackFormatter` yalnızca `bool[]` tiplerini sıkıştırır. `bool[]` normalde her boolean değer için 1 bayt olarak serileştirilir, ancak `BitPackFormatter` ile her bool 1 bit olarak saklanır (BitArray gibi). `BitPackFormatter` kullanarak, 8 bool normalde 8 baytken, 1 bayta düşer ve 8 kat daha küçük olur.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter`, `byte[]` içindir; örneğin büyük bir yükü Brotli ile sıkıştırabilirsiniz.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter`, `string` içindir; Brotli ile sıkıştırılmış string'i (UTF16) serileştirir.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` herhangi bir tür için, serileştirilmiş verileri Brotli ile sıkıştırılmış olarak kullanır. Eğer türünüz `byte[]` veya `string` ise, performans için `BrotliFormatter` veya `BrotliStringFormatter` kullanmalısınız.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Diziyi havuzdan çekerek serileştirmeyi kaldırma (Deserialize array pooling)
---
Büyük bir diziyi (herhangi bir `T`) serileştirmeyi kaldırmak için, MemoryPack birden fazla verimli havuzlama yöntemi sunar. En etkili yol [#Overwrite](#overwrite) fonksiyonunu kullanmaktır. Özellikle `List<T>` her zaman tekrar kullanılır.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> tekrar kullanılır, serileştirmeyi kaldırmada (deserialize) tahsis yapılmaz.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// Verimli işlem için CollectionsMarshal ile Span<T> elde edebilirsiniz.
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Kullanışlı bir yöntem, serileştirmeyi kaldırma sırasında bir ArrayPool'a serileştirmeyi kaldırmaktır. MemoryPack, `MemoryPoolFormatter<T>` ve `ReadOnlyMemoryPoolFormatter<T>` sağlar.

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

    // Geri dönüş kodunu (return code) kendiniz yazmalısınız, işte bir örnek.

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
    // istediğiniz işlemi yapın...
}   // ArrayPool'a geri döner
```

Performans
---
Blog yazıma bakınız: [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Yük boyutu ve sıkıştırma (Payload size and compression)
---
Yük boyutu hedef değere bağlıdır; JSON'un aksine anahtarlar yoktur ve ikili (binary) bir formattır, bu nedenle yük boyutu muhtemelen JSON'dan daha küçüktür.

MessagePack ve Protobuf gibi varint kodlaması olanlarda, MemoryPack ile int çok kullanılırsa boyut daha büyük olabilir (MemoryPack'te int'ler sabit boyutlu kodlama nedeniyle her zaman 4 bayttır, MessagePack'te ise 1~5 bayt olabilir).

float ve double, MemoryPack'te sırasıyla 4 ve 8 bayt, MessagePack'te ise 5 ve 9 bayttır. Örneğin, Vector3 (float, float, float) dizileri için MemoryPack daha küçüktür.

String varsayılan olarak UTF8'dir, bu diğer serileştiricilere benzerdir, ancak UTF16 seçilirse farklı bir yapıda olur.

Her durumda, yük boyutu büyükse sıkıştırma göz önünde bulundurulmalıdır. LZ4, ZStandard ve Brotli önerilir.

### Sıkıştırma

MemoryPack, [Brotli](https://github.com/google/brotli) sıkıştırması için [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) ve [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder) aracılığıyla verimli bir yardımcı sağlar. MemoryPack'in `BrotliCompressor` ve `BrotliDecompressor` yapıları, MemoryPack'in iç davranışına optimize edilmiş sıkıştırma/açma işlemleri sunar.

```csharp
using MemoryPack.Compression;

// Sıkıştırma (kullanım için using gerekli)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Sıkıştırılmış byte[] elde et
var compressedBytes = compressor.ToArray();

// Ya da başka bir IBufferWriter<byte>'a yaz (örneğin PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Açma (decompression, kullanım için using gerekli)
using var decompressor = new BrotliDecompressor();

// ReadOnlySpan<byte> veya ReadOnlySequence<byte>'dan açılmış ReadOnlySequence<byte> elde et
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Hem `BrotliCompressor` hem de `BrotliDecompressor` birer struct'tır, heap'te bellek tahsis etmezler. Her ikisi de Serialize/Deserialize işlemleri için sıkıştırılmış veya açılmış veriyi dahili bir bellek havuzunda tutar. Bu nedenle, bellek havuzlamasını serbest bırakmak gereklidir, `using` kullanmayı unutmayın.

Sıkıştırma seviyesi çok önemlidir. Varsayılan olarak kalite-1 (CompressionLevel.Fastest) ayarlanmıştır, bu .NET varsayılanından (CompressionLevel.Optimal, kalite-4) farklıdır.

En hızlısı (quality-1), [LZ4](https://github.com/lz4/lz4) hızına yakın olur, fakat kalite-4 çok daha yavaştır. Serileştirici kullanım senaryosunda bunun kritik olduğu tespit edilmiştir. Standart `BrotliStream` kullanırken dikkatli olun (kalite-4 varsayılandır). Her durumda, sıkıştırma/açma hızları ve boyutları, farklı veriler için çok farklı sonuçlar verecektir. Uygulamanızda işleyeceğiniz verileri hazırlayın ve kendiniz test edin.

MemoryPack'in sıkıştırılmamış ve Brotli ile sıkıştırılmış sürümleri arasında birkaç kat hız farkı olduğunu unutmayın.

Brotli, özel bir biçimlendiricide de desteklenir. `BrotliFormatter` belirli bir üyeyi sıkıştırabilir.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Harici türleri serileştirme (Serialize external types)
---
Harici türleri serileştirmek istiyorsanız, özel bir biçimlendirici (formatter) oluşturup sağlayıcıya (provider) kaydedebilirsiniz, detaylar için [Formatter/Provider API](#formatterprovider-api) bölümüne bakınız. Ancak, özel biçimlendirici oluşturmak zordur. Bu nedenle, bir sarmalayıcı (wrapper) tür oluşturmanızı öneririz. Örneğin, harici bir `AnimationCurve` türünü serileştirmek istiyorsanız:

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

Sarmalanacak tür public'tir, fakat serileştirmeden hariç tutulur (`MemoryPackIgnore`). Serileştirmek istediğiniz özellikler privatedır, fakat dahil edilmiştir (`MemoryPackInclude`). İki farklı yapıcı (constructor) da hazırlanmalıdır. Serileştirici tarafından kullanılan yapıcı private olmalıdır.

Olduğu gibi kullanılırsa, her seferinde sarmalamak gerekir, bu da kullanışsızdır. Ayrıca, struct sarmalayıcı null temsil edemez. Bu yüzden özel bir biçimlendirici oluşturalım.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity scoped ve TBufferWriter desteklemediğinden, imzayı `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)` olarak değiştirin
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
        reader.Advance(1); // null bloğu atla
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

Son olarak, formatlayıcıyı başlangıçta kaydedin.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Not: Unity'nin AnimationCurve'u varsayılan olarak serileştirilebilir, bu nedenle AnimationCurve için bu özel formatlayıcıya ihtiyaç yoktur.

Paketler
---
MemoryPack aşağıdaki paketlere sahiptir.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` ana kütüphanedir, ikili nesnelerin yüksek performanslı serileştirme ve deserileştirmesi için tam destek sağlar. Temel taban kütüphaneleri için `MemoryPack.Core`'a ve kod üretimi için `MemoryPack.Generator`'a bağlıdır. `MemoryPack.Streaming`, [Streaming Serialization](#streaming-serialization) için ek uzantılar ekler. `MemoryPack.AspNetCoreMvcFormatter`, ASP.NET Core için giriş/çıkış formatlayıcıları ekler. `MemoryPack.UnityShims`, .NET ve Unity arasında paylaşılan tipler ve formatlayıcılar ekler.

TypeScript ve ASP.NET Core Formatlayıcı
---
MemoryPack, TypeScript kod üretimini destekler. C#'tan sınıf ve serileştirme kodu üretir, başka bir deyişle, OpenAPI, proto vb. kullanmadan tarayıcı ile tip paylaşabilirsiniz.

Kod üretimi Source Generator ile entegredir, aşağıdaki seçenek (`MemoryPackGenerator_TypeScriptOutputDirectory`) TypeScript kodu için çıktı dizinini ayarlar. Çalışma zamanı kodu aynı anda çıktılanır, bu nedenle ek bir bağımlılık gerekmez.

```xml
<!-- memorypack TypeScript kodunu dizine çıktıla -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Bir C# MemoryPackable tipi `[GenerateTypeScript]` ile işaretlenmelidir.

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

Çalışma zamanı kodu ve TypeScript tipi hedef dizinde üretilecektir.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Üretilen kod aşağıdaki gibidir; basit alanlar ve serialize/serializeArray ile deserialize/deserializeArray için statik metotlar içerir.

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

Bu tipi aşağıdaki gibi kullanabilirsiniz.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// Uint8Array'e serileştir
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// ArrayBuffer'dan deserileştir
let person2 = Person.deserialize(buffer);
```

`MemoryPack.AspNetCoreMvcFormatter` paketi, ASP.NET Core MVC için `MemoryPack` giriş ve çıkış formatlayıcılarını ekler. `MemoryPackInputFormatter`, `MemoryPackOutputFormatter`'ı aşağıdaki kod ile ASP.NET Core MVC'ye ekleyebilirsiniz.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Eğer checkContentType: true ise, birden fazla format (JSON/MemoryPack, vb.) çıktılayabilir. Varsayılan false'dur.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

HttpClient ile çağırırsanız, content-header olarak `application/x-memorypack` ayarlayabilirsiniz.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript Tip Eşlemesi

Üretilebilecek tiplerde bazı kısıtlamalar vardır. İlkel tipler arasında `char` ve `decimal` desteklenmez. Ayrıca, OpenGenerics tipi kullanılamaz.

|  C#  |  TypeScript  | Açıklama |
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
| `Guid` |  `string`  | TypeScript'te string olarak temsil edilir ama serileştirme/deserileştirme 16 baytlık binary olarak yapılır
| `DateTime` | `Date` | DateTimeKind dikkate alınmaz
| `enum` | `const enum` | `long` ve `ulong` temel türü desteklenmez
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | `List<T>` gibi tüm `ICollection<T>` uygulayan türleri destekler
| `: ISet<T>` | `Set<T> \| null` | `HashSet<T>` gibi tüm `ISet<T>` uygulayan türleri destekler
| `: IDictionary<K,V>` | `Map<K, V> \| null` | `Dictionary<K,V>` gibi tüm `IDictionary<K,V>` uygulayan türleri destekler.
| `[MemoryPackable]` | `class` | Sadece sınıf desteklenir
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` yalnızca sınıflara uygulanabilir ve şu anda struct için desteklenmemektedir.

### İçe aktarma dosya uzantısını ve üye adı büyük/küçük harf biçimini yapılandırma

Varsayılan olarak, MemoryPack dosya uzantısını `.js` olarak üretir, örneğin `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Farklı bir uzantı veya boş bırakmak isterseniz, bunu yapılandırmak için `MemoryPackGenerator_TypeScriptImportExtension` kullanın.
Ayrıca üye adları otomatik olarak camelCase'e dönüştürülür. Orijinal ismi kullanmak isterseniz, `MemoryPackGenerator_TypeScriptConvertPropertyName`'ı `false` olarak ayarlayın.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- boş bırakılabilir -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- varsayılan true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- varsayılan false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes`, C# null anotasyonlarının TypeScript koduna yansıtılmasını sağlar. Varsayılan olarak false'dur, her şeyi nullable yapar.

Streaming Serialization
---
`MemoryPack.Streaming`, koleksiyonların akışlarla serileştirilmesi ve deserileştirilmesi için ek destek sağlayan `MemoryPackStreamingSerializer`'ı sunar.

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
Formatter'ı manuel olarak uygulamak isterseniz, `MemoryPackFormatter<T>`'dan türeyin ve `Serialize` ve `Deserialize` metotlarını geçersiz kılın.

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

        // writer metodunu kullanın.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // reader metodunu kullanın.
    }
}
```
Oluşturulan formatter, `MemoryPackFormatterProvider` ile kaydedilir.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Not: `unmanaged struct`(referans türü içermeyen) özel formatter kullanamaz, her zaman yerel bellek düzeninde serileştirilir.

MemoryPackWriter/ReaderOptionalState
---
`MemoryPackWriter`/`MemoryPackReader` başlatmak için OptionalState gereklidir. Bu, `MemoryPackSerializerOptions`'ın sarmalayıcısıdır ve `MemoryPackWriterOptionalStatePool` üzerinden oluşturulabilir.

```csharp
// dispose edildiğinde, OptionalState havuza geri döner.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// Reader için
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Hedef framework bağımlılığı
---
MemoryPack, `netstandard2.1` ve `net7.0` sağlar ancak ikisi uyumlu değildir. Örneğin, bir `netstandard2.1` projesi altında MemoryPackable türlerini tanımlayıp bunu bir `net7.0` projesinde kullanırsanız, aşağıdaki gibi bir çalışma zamanı hatası alırsınız:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Çünkü net7.0, netstandard2.1'de desteklenmeyen statik soyut üyeler (`Virtual static method`) kullanır, bu bir gerekliliktir.

.NET 7 projesi netstandard 2.1 dll'si kullanmamalıdır. Başka bir deyişle, uygulama bir .NET 7 projesiyse, MemoryPack kullanan tüm bağımlılıklar .NET 7'yi desteklemelidir. Yani, bir kütüphane geliştiricisi MemoryPack'e bağımlıysa, çift hedef framework yapılandırmanız gerekir.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion), protobuf yerine MessagePack kullanan kod-öncelikli bir grpc-dotnet framework'üdür. MagicOnion artık `MagicOnion.Serialization.MemoryPack` paketi (önizleme) ile MemoryPack'i serileştirme katmanı olarak destekliyor. Detaylar için: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Minimum desteklenen Unity sürümü `2022.3.12f1`'dir.

`MemoryPack` çekirdek paketi nuget ile sağlanır. Unity'de de kullanılabilir. Unity yerleşik tür desteği istiyorsanız, ayrıca MemoryPack.Unity uzantısı sağlıyoruz.

1. [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity) ile NuGet üzerinden `MemoryPack` yükleyin

* NuGet -> Manage NuGet Packages penceresini açın, "MemoryPack" arayın ve Install'a basın.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Sürüm çakışma hatası alırsanız, lütfen Player Settings'te (Edit -> Project Settings -> Player -> "Other Settings" bölümünü genişletin ve "Assembly Version Validation" seçeneğini kaldırın) sürüm doğrulamayı devre dışı bırakın.

2. git URL'sini referans göstererek `MemoryPack.Unity` paketini yükleyin

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack *.*.* sürüm etiketi kullanır, bu yüzden #1.0.0 gibi bir sürüm belirtebilirsiniz. Örneğin: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


.NET sürümünde olduğu gibi, kod bir kod üreteci (`MemoryPack.Generator.dll`) tarafından oluşturulur. Yansımasız uygulama, IL2CPP'de de en iyi performansı sağlar.

Unity ve Source Generator hakkında daha fazla bilgi için [Unity belgelerine](https://docs.unity3d.com/Manual/roslyn-analyzers.html) bakınız.

Source Generator, Unity tarafından da resmi olarak [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) ve [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html) ile kullanılmaktadır. Yani, gelecek nesil Unity'de kod üretimi için standarttır.

Tüm unmanaged türleri (ör: `Vector3`, `Rect`, vs...) ve bazı sınıfları (`AnimationCurve`, `Gradient`, `RectOffset`) serileştirebilirsiniz. Diğer Unity'ye özgü türleri serileştirmek istiyorsanız, [Harici türleri serileştirme](#serialize-external-types) bölümüne bakınız.

Unity performansında, MemoryPack JsonUtility'den 3 ila 10 kat daha hızlıdır.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Paylaşılan kodda Unity'nin türleri (`Vector2`, vb...) varsa, MemoryPack NuGet'te `MemoryPack.UnityShims` paketini sağlar.

`MemoryPack.UnityShims` paketi, Unity'nin standart struct'ları (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) ve bazı sınıflar (`AnimationCurve`, `Gradient`, `RectOffset`) için shims sağlar.

> [!WARNING]
> Şu anda Unity'de kullanım için aşağıdaki kısıtlamalar vardır


1. Unity sürümünde CustomFormatter desteklenmemektedir.
2. .NET7 veya sonrası kullanıyorsanız, MemoryPack ikili formatı Unity ile tam uyumlu değildir.
    - Bu sorun, `[StructLayout(LayoutKind.Auto)]`'nun açıkça belirtildiği değer türlerinde oluşur. (Struct için varsayılan `LayoutKind.Sequential`'dir.) Bu türlerde, .NET'te serileştirilen ikili Unity'de deserileştirilemez. Benzer şekilde, Unity'de serileştirilen ikili .NET tarafında deserileştirilemez.
    - Etkilenen türler genellikle şunlardır:
        - `DateTimeOffset`
        - `ValueTuple`
    - Şu anda, basit çözüm bu türleri kullanmamaktır.


Native AOT
---
Maalesef, .NET 7 Native AOT, MemoryPack kullanıldığında bir çalışma zamanı hatası (`Generic virtual method pointer lookup failure`) nedeniyle çöküyor. 
.NET 8'de düzeltilecek. ``Microsoft.DotNet.ILCompiler`` önizleme sürümünü kullanmak, .NET 7'de de sorunu çözer. Kurulum için [issue'nun yorumuna](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) bakınız.

İkili veri formatı spesifikasyonu
---
`Serialize<T>` ve `Deserialize<T>`'de tanımlanan `T` tipi, C# şeması olarak adlandırılır. MemoryPack formatı kendi kendini tanımlayan bir format değildir. Deserileştirme, karşılık gelen C# şemasını gerektirir. Bu türler, ikili dosyaların içsel temsilleri olarak bulunur, ancak türler bir C# şeması olmadan belirlenemez.

Endian, `Little Endian` olmalıdır. Ancak, referans C# uygulaması endianness ile ilgilenmez, bu yüzden büyük-endian makinelerde kullanılamaz. Modern bilgisayarlar genellikle little-endian'dır.

Sekiz çeşit format vardır.

* Unmanaged struct
* Object
* Version Tolerant Object
* Dairesel Referans Nesnesi
* Tuple
* Koleksiyon
* Dize (String)
* Birlik (Union)

### Yönetilmeyen struct

Yönetilmeyen struct, referans türleri içermeyen C# struct’ıdır, [C# Yönetilmeyen türler](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types) ile benzer bir kısıtlamaya sahiptir. Struct düzeni olduğu gibi serileştirilir, dolgu (padding) dahil edilir.

### Nesne (Object)

`(byte üyeSayısı, [değerler...])`

Nesnenin başlığında 1 baytlık işaretsiz bayt olarak üye sayısı bulunur. Üye sayısı `0` ile `249` arasında olabilir, `255` nesnenin `null` olduğunu belirtir. Değerler, üye sayısı kadar memorypack değeri depolar.

### Sürüme Dayanıklı Nesne (Version Tolerant Object)

`(byte üyeSayısı, [varint değerlerin bayt uzunluğu...], [değerler...])`

Sürüme Dayanıklı Nesne, Nesne’ye benzer ancak başlıkta değerlerin bayt uzunluğunu içerir. Varint şu kurallara uyar: ilk sbyte değer veya typeCode’dur ve sonraki X bayt değerdir. 0'dan 127'ye = işaretsiz bayt değeri, -1'den -120'ye = işaretli bayt değeri, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Dairesel Referans Nesnesi

`(byte üyeSayısı, [varint değerlerin bayt uzunluğu...], varint referansId, [değerler...])`  
`(250, varint referansId)`

Dairesel Referans Nesnesi, Sürüme Dayanıklı Nesne’ye benzer ancak üyeSayısı 250 ise, bir sonraki varint (işaretsiz-int32) referansId’dir. Aksi halde, değerlerin bayt uzunluğundan sonra varint referansId yazılır.

### Tuple

`(değerler...)`

Tuple, sabit boyutlu, null olamayan değer koleksiyonudur. .NET’te, `KeyValuePair<TKey, TValue>` ve `ValueTuple<T,...>` Tuple olarak serileştirilir.

### Koleksiyon

`(int uzunluk, [değerler...])`

Koleksiyonun başlığında veri sayısı olarak 4 bayt işaretli tamsayı bulunur, `-1` değeri `null`’ı belirtir. Değerler, uzunluk kadar memorypack değeri depolar.

### Dize (String)

`(int utf16-uzunluk, utf16-değer)`  
`(int ~utf8-bayt-sayısı, int utf16-uzunluk, utf8-baytlar)`

Dizenin iki biçimi vardır, UTF16 ve UTF8. Eğer ilk 4 baytlık işaretli tamsayı `-1` ise, bu null anlamına gelir. `0`, boş dizgeyi belirtir. UTF16, koleksiyon ile aynıdır (`ReadOnlySpan<char>` olarak serileştirilir, utf16-değer’in bayt sayısı utf16-uzunluk * 2’dir). Eğer ilk işaretli tamsayı <= `-2` ise, değer UTF8 ile kodlanmıştır. utf8-bayt-sayısı, kompleman olarak kodlanır, bayt sayısını almak için `~utf8-bayt-sayısı` kullanılır. Sonraki işaretli tamsayı utf16-uzunluktur, `-1` olabilir ve bu bilinmeyen uzunluğu belirtir. utf8-baytlar, utf8-bayt-sayısı kadar baytı depolar.

### Birlik (Union)

`(byte etiket, değer)`  
`(250, ushort etiket, değer)`

İlk işaretsiz bayt, ayrık değer türü veya bayrak için etikettir, `0` ile `249` arası etiketleri, `250` bir sonraki işaretsiz kısa (ushort) etiket olduğunu, `255` ise birliğin `null` olduğunu belirtir.

Lisans
---
Bu kütüphane MIT Lisansı ile lisanslanmıştır.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---