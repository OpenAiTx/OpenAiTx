# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Serializer biner dengan performa ekstrim dan zero encoding untuk C# dan Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Dibandingkan dengan [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Diukur menggunakan mesin .NET 7 / Ryzen 9 5950X. Serializer-serializer ini memiliki metode `IBufferWriter<byte>`, diserialisasi menggunakan `ArrayBufferWriter<byte>` dan digunakan ulang untuk menghindari pengukuran copy buffer.

Untuk objek standar, MemoryPack sekitar 10x lebih cepat dan 2 ~ 5x lebih cepat dari serializer biner lainnya. Untuk array struct, MemoryPack bahkan lebih unggul, dengan kecepatan hingga 50 ~ 200x lebih cepat dibanding serializer lain.

MemoryPack adalah serializer ke-4 yang saya buat, sebelumnya saya telah membuat serializer yang cukup dikenal, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). Alasan kecepatan MemoryPack adalah karena format binernya yang spesifik untuk C#, dioptimalkan untuk C#, serta implementasi yang telah disetel berdasarkan pengalaman saya sebelumnya. Ini juga merupakan desain baru yang memanfaatkan .NET 7 dan C# 11 serta Incremental Source Generator (Juga mendukung .NET Standard 2.1 (.NET 5, 6) dan Unity).

Serializer lain melakukan banyak operasi encoding seperti VarInt encoding, tag, string, dll. Format MemoryPack menggunakan desain zero-encoding yang menyalin memori C# sebanyak mungkin. Zero-encoding mirip dengan FlatBuffers, tetapi tidak memerlukan tipe khusus, target serialisasi MemoryPack adalah POCO.

Selain performa, MemoryPack memiliki fitur-fitur berikut:

* Mendukung API I/O modern (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Native AOT friendly code generation berbasis Source Generator, tanpa Dynamic CodeGen (IL.Emit)
* API non-generic tanpa refleksi
* Deserialisasi ke instance yang sudah ada
* Serialisasi polimorfisme (Union)
* Dukungan version-tolerant terbatas (cepat/default) dan version-tolerant penuh
* Serialisasi circular reference
* Serialisasi streaming berbasis PipeWriter/Reader
* Code generation TypeScript dan ASP.NET Core Formatter
* Dukungan Unity (2021.3) IL2CPP melalui .NET Source Generator

Instalasi
---
Library ini didistribusikan melalui NuGet. Untuk performa terbaik, disarankan menggunakan `.NET 7`. Persyaratan minimum adalah `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Editor kode juga membutuhkan dukungan Roslyn 4.3.1, misalnya Visual Studio 2022 versi 17.3, .NET SDK 6.0.401. Untuk detailnya, lihat dokumen [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Untuk Unity, persyaratan dan proses instalasinya berbeda sepenuhnya. Lihat bagian [Unity](#unity) untuk detailnya.

Quick Start
---
Definisikan sebuah struct atau class yang akan diserialisasikan dan anotasi dengan atribut `[MemoryPackable]` serta gunakan keyword `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Kode serialisasi dihasilkan oleh fitur source generator C# yang mengimplementasikan interface `IMemoryPackable<T>`. Di Visual Studio Anda dapat memeriksa kode yang dihasilkan dengan shortcut `Ctrl+K, R` pada nama kelas dan pilih `*.MemoryPackFormatter.g.cs`.

Panggil `MemoryPackSerializer.Serialize<T>/Deserialize<T>` untuk serialisasi/deserialisasi instance objek.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

Metode `Serialize` mendukung tipe return `byte[]` serta dapat melakukan serialisasi ke `IBufferWriter<byte>` atau `Stream`. Metode `Deserialize` mendukung `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` dan `Stream`. Tersedia juga versi non-generic.

Tipe yang didukung secara bawaan
---
Tipe-tipe berikut dapat diserialisasikan secara default:

* Primitive .NET (`byte`, `int`, `bool`, `char`, `double`, dll.)
* Tipe unmanaged (Semua `enum`, struct buatan pengguna yang tidak mengandung tipe referensi)
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
* Immutable collections (`ImmutableList<>`, dll.) dan interface (`IImmutableList<>`, dll.)

Definisikan `[MemoryPackable]` pada `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` dapat digunakan pada `class`, `struct`, `record`, `record struct` maupun `interface`. Jika tipe adalah `struct` atau `record struct` yang tidak mengandung tipe referensi ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), anotasi tambahan (ignore, include, constructor, callbacks) tidak digunakan, sehingga serialisasi/deserialisasi langsung dari memori.

Selain itu, secara default, `[MemoryPackable]` akan mensialisikan properti atau field instance yang public. Anda dapat menggunakan `[MemoryPackIgnore]` untuk menghapus target serialisasi, `[MemoryPackInclude]` untuk mempromosikan member privat ke target serialisasi.

```csharp
[MemoryPackable]
public partial class Sample
{
    // tipe-tipe berikut diserialisasikan secara default
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // tipe-tipe berikut tidak diserialisasikan secara default
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // gunakan [MemoryPackIgnore] untuk menghapus target dari anggota public
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // gunakan [MemoryPackInclude] untuk mempromosikan anggota privat ke target serialisasi
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Generator kode `MemoryPack` menambahkan informasi tentang anggota mana saja yang diserialisasikan ke bagian `<remarks />`. Ini dapat dilihat dengan mengarahkan kursor ke tipe tersebut menggunakan Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Semua anggota harus dapat diserialisasikan oleh memorypack, jika tidak generator kode akan mengeluarkan error.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack memiliki 35 aturan diagnostik (`MEMPACK001` hingga `MEMPACK035`) agar dapat didefinisikan dengan nyaman.

Jika tipe target telah didefinisikan serialisasi MemoryPack secara eksternal dan didaftarkan, gunakan `[MemoryPackAllowSerialize]` untuk membisukan diagnostik.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

Urutan anggota **penting**, MemoryPack tidak menyimpan nama anggota atau informasi lain, melainkan menyimpan field sesuai urutan deklarasi. Jika tipe merupakan turunan, serialisasi dilakukan dalam urutan parent → child. Urutan anggota tidak boleh berubah untuk proses deserialisasi. Untuk evolusi skema, lihat bagian [Version tolerant](#version-tolerant).

Urutan default adalah sequential, tetapi Anda bisa memilih explicit layout dengan `[MemoryPackable(SerializeLayout.Explicit)]` dan `[MemoryPackOrder()]`.

```csharp
// serialize Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Pemilihan konstruktor

MemoryPack mendukung konstruktor dengan parameter maupun tanpa parameter. Pemilihan konstruktor mengikuti aturan berikut (berlaku untuk class dan struct):

* Jika terdapat `[MemoryPackConstructor]`, maka digunakan.
* Jika tidak ada konstruktor eksplisit (termasuk private), digunakan konstruktor tanpa parameter.
* Jika hanya ada satu konstruktor tanpa parameter/berparameter (termasuk private), maka digunakan.
* Jika ada beberapa konstruktor, atribut `[MemoryPackConstructor]` harus diterapkan pada konstruktor yang diinginkan (generator tidak akan memilih otomatis), jika tidak generator akan mengeluarkan error.
* Jika menggunakan konstruktor dengan parameter, semua nama parameter harus sesuai dengan nama anggota yang bersesuaian (case-insensitive).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Anda dapat menggunakan konstruktor berparameter - nama parameter harus sesuai dengan nama anggota yang bersesuaian (case-insensitive)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// juga mendukung record primary constructor
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
// Jika ada beberapa konstruktor, maka [MemoryPackConstructor] harus digunakan
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callback Serialisasi

Saat melakukan serialisasi/deserialisasi, MemoryPack dapat memanggil event sebelum/sesudah menggunakan atribut `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Atribut ini dapat digunakan pada metode statis maupun instance (non-statis), serta metode public maupun private.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // urutan pemanggilan metode adalah statis -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // juga mendukung metode private
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

    // Catatan: metode instance dengan MemoryPackOnDeserializing, tidak akan dipanggil jika instance tidak dilewatkan dengan `ref`
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

Callback memungkinkan metode tanpa parameter dan metode `ref reader/writer, ref T value`. Sebagai contoh, callback ref dapat menulis/membaca header kustom sebelum proses serialisasi.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, gunakan where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // menulis GUID di header.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // membaca header kustom sebelum deserialisasi
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Jika mengatur nilai pada `ref value`, Anda dapat mengubah nilai yang digunakan untuk serialisasi/deserialisasi. Misalnya, melakukan instansiasi dari ServiceProvider.

```csharp
// sebelum menggunakan formatter ini, set ServiceProvider
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

Definisikan koleksi kustom
---
Secara default, tipe yang dianotasi `[MemoryPackObject]` akan mencoba men-serialisasi anggotanya. Namun, jika tipe tersebut adalah koleksi (`ICollection<>`, `ISet<>`, `IDictionary<,>`), gunakan `GenerateType.Collection` agar serialisasi berjalan dengan benar.

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

Konstruktor statis
---
Kelas MemoryPackable tidak dapat mendefinisikan konstruktor statis karena partial class yang dihasilkan menggunakannya. Sebagai gantinya, Anda dapat mendefinisikan `static partial void StaticConstructor()` untuk melakukan hal yang sama.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfisme (Union)
---
MemoryPack mendukung serialisasi objek interface dan kelas abstrak untuk kebutuhan serialisasi polimorfisme. Di MemoryPack, fitur ini disebut Union. Hanya interface dan kelas abstrak yang diperbolehkan diberi atribut `[MemoryPackUnion]`. Diperlukan tag union yang unik.

```csharp
// Tandai [MemoryPackable] dan tipe turunan dengan [MemoryPackUnion]
// Union juga mendukung kelas abstrak
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

// Serialisasi sebagai tipe interface.
var bin = MemoryPackSerializer.Serialize(data);

// Deserialisasi sebagai tipe interface.
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

`tag` memperbolehkan nilai `0` ~ `65535`, sangat efisien terutama untuk nilai kurang dari `250`.
```
Jika sebuah interface dan tipe turunannya berada di assembly yang berbeda, Anda dapat menggunakan `MemoryPackUnionFormatterAttribute` sebagai gantinya. Formatter akan dihasilkan sedemikian rupa sehingga secara otomatis terdaftar melalui `ModuleInitializer` di C# 9.0 dan yang lebih baru.

> Perhatikan bahwa `ModuleInitializer` tidak didukung di Unity, sehingga formatter harus didaftarkan secara manual. Untuk mendaftarkan union formatter Anda, panggil `{nama union formatter Anda}Initializer.RegisterFormatter()` secara manual di Startup. Misalnya `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB mendefinisikan definisi di luar target type
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union dapat dirakit dalam kode melalui `DynamicUnionFormatter<T>`.

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
`Serialize` memiliki tiga overload.

```csharp
// Non generic API juga tersedia, versi ini argumen pertama adalah Type dan value adalah object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Untuk performa, API yang direkomendasikan menggunakan `BufferWriter`. Ini melakukan serialisasi langsung ke buffer. Dapat diterapkan ke `PipeWriter` di `System.IO.Pipelines`, `BodyWriter` di ASP .NET Core, dll.

Jika diperlukan `byte[]` (misal `RedisValue` di [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), API return `byte[]` sederhana dan hampir secepat itu.

Perhatikan bahwa `SerializeAsync` untuk `Stream` hanya asinkron untuk Flush; ia melakukan serialisasi semuanya sekaligus ke buffer internal pool MemoryPack lalu menulis menggunakan `WriteAsync`. Oleh karena itu, overload `BufferWriter`, yang memisahkan dan mengontrol buffer serta flush, lebih baik.

Jika Anda ingin melakukan streaming write secara penuh, lihat bagian [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` mengatur apakah string diserialisasi sebagai UTF16 atau UTF8. Ini dapat dikonfigurasi dengan melewatkan `MemoryPackSerializerOptions.Utf8` untuk encoding UTF8, `MemoryPackSerializerOptions.Utf16` untuk encoding UTF16, atau `MemoryPackSerializerOptions.Default` yang secara default menggunakan UTF8. Melewatkan null atau menggunakan parameter default menghasilkan encoding UTF8.

Karena representasi string internal C# adalah UTF16, performa UTF16 lebih baik. Namun, payload cenderung lebih besar; pada UTF8, string ASCII adalah satu byte, sedangkan di UTF16 dua byte. Karena perbedaan ukuran payload sangat besar, UTF8 dijadikan default.

Jika data bukan ASCII (misal Jepang, yang bisa lebih dari 3 byte, dan UTF8 jadi lebih besar), atau Anda harus mengompresnya secara terpisah, UTF16 mungkin memberikan hasil lebih baik.

Meskipun UTF8 atau UTF16 bisa dipilih saat serialisasi, tidak perlu ditentukan saat deserialisasi. Akan dideteksi dan didekode secara otomatis.

Selain itu, Anda bisa mendapatkan/mengatur `IServiceProvider? ServiceProvider { get; init; }` dari options. Ini berguna untuk mengambil objek DI (seperti `ILogger<T>`) dari proses serialisasi (`MemoryPackReader/MemoryPackWriter` memiliki properti .Options).

Deserialize API
---
`Deserialize` memiliki overload untuk `ReadOnlySpan<byte>` dan `ReadOnlySequence<byte>`, `Stream` serta dukungan `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

Overload `ref` menimpa instance yang sudah ada, untuk detail lihat bagian [Overwrite](#overwrite).

`DeserializeAsync(Stream)` bukan operasi baca streaming penuh, pertama ia membaca ke dalam pool internal MemoryPack hingga akhir stream, lalu mendeserialisasi.

Jika Anda ingin melakukan operasi baca streaming penuh, lihat bagian [Streaming Serialization](#streaming-serialization).

Overwrite
---
Untuk mengurangi alokasi, MemoryPack mendukung deserialisasi ke instance yang sudah ada, menimpanya. Ini dapat digunakan dengan overload `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// timpa data ke instance yang sudah ada.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack akan mencoba menimpa sebanyak mungkin, tetapi jika kondisi berikut tidak terpenuhi, maka akan membuat instance baru (seperti pada deserialisasi normal).

* nilai ref (termasuk anggota dalam object graph) adalah null, set instance baru
* hanya memperbolehkan konstruktor tanpa parameter, jika konstruktor berparameter digunakan, buat instance baru
* jika value adalah `T[]`, digunakan kembali hanya jika panjang sama, jika tidak buat instance baru
* jika value adalah koleksi yang memiliki metode `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) maka panggil Clear() dan gunakan kembali, jika tidak buat instance baru

Version tolerant
---
Secara default (`GenerateType.Object`), MemoryPack mendukung evolusi skema terbatas.

* struct unmanaged tidak dapat diubah lagi
* anggota dapat ditambahkan, tapi tidak dapat dihapus
* dapat mengganti nama anggota
* tidak dapat mengubah urutan anggota
* tidak dapat mengubah tipe anggota

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Add is OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Remove is NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Change order is NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

Dalam penggunaannya, menyimpan data lama (ke file, ke redis, dll...) dan membaca ke skema baru selalu aman. Dalam skenario RPC, skema ada di sisi klien dan server, klien harus diperbarui sebelum server. Klien yang sudah diperbarui tidak masalah terhubung ke server lama, tapi klien lama tidak dapat terhubung ke server baru.


Secara default, ketika data lama dibaca ke skema baru, semua anggota yang tidak ada pada sisi data akan diinisialisasi dengan literal `default`.
Jika Anda ingin menghindari ini dan menggunakan nilai awal field/properti, Anda dapat menggunakan `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < jika data lama tidak ada, set `111`.
    
    public int Prop3 { get; set; } = 222; // < jika data lama tidak ada, set `default`.
}
```

 `[SuppressDefaultInitialization]` memiliki batasan berikut:
- Tidak dapat digunakan dengan modifier readonly, init-only, dan required.

Bagian selanjutnya [Serialization info](#serialization-info) menunjukkan cara memeriksa perubahan skema, misalnya, dengan CI, untuk mencegah kecelakaan.

Saat menggunakan `GenerateType.VersionTolerant`, ini mendukung toleransi versi penuh.

* struct unmanaged tidak bisa diubah lagi
* semua anggota harus menambahkan `[MemoryPackOrder]` secara eksplisit (kecuali diberi anotasi `SerializeLayout.Sequential`)
* anggota bisa ditambah, bisa dihapus tapi tidak boleh menggunakan ulang order (boleh menggunakan order yang hilang)
* bisa mengubah nama anggota
* tidak bisa mengubah urutan anggota
* tidak bisa mengubah tipe anggota

```csharp
// Ok untuk serialize/deserialize kedua arah 
// VersionTolerantObject1 -> VersionTolerantObject2 dan 
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

// dihapus
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// ditambahkan
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Jika SerializeLayout.Sequential diatur secara eksplisit, maka pengurutan otomatis diizinkan.
// Namun, tidak dapat menghapus anggota apa pun untuk versi-tolerant.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` lebih lambat daripada `GenerateType.Object` dalam proses serialisasi. Selain itu, ukuran payload akan sedikit lebih besar.

Info Serialisasi
----
Anda dapat memeriksa IntelliSense pada tipe untuk mengetahui anggota mana yang diserialisasi. Ada opsi untuk menuliskan informasi tersebut ke dalam file pada saat kompilasi. Atur `MemoryPackGenerator_SerializationInfoOutputDirectory` seperti berikut.

```xml
<!-- output info serialisasi memorypack ke direktori -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Informasi berikut akan dituliskan ke dalam file.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Jika tipe tersebut unmanaged, akan ditampilkan `unmanaged` sebelum nama tipe.

```txt
unmanaged FooStruct
---
int x
int y
```

Dengan memeriksa perbedaan pada file ini, perubahan skema yang berbahaya dapat dicegah. Misalnya, Anda dapat menggunakan CI untuk mendeteksi aturan berikut

* memodifikasi tipe unmanaged
* perubahan urutan anggota
* penghapusan anggota

Referensi Sirkular
---
MemoryPack juga mendukung referensi sirkular. Ini memungkinkan objek pohon untuk diserialisasi apa adanya.

```csharp
// untuk mengaktifkan circular-reference, gunakan GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Sebagai contoh, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) kodenya akan menjadi seperti berikut.

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

`GenerateType.CircularReference` memiliki karakteristik yang sama seperti version-tolerant. Namun, sebagai batasan tambahan, hanya konstruktor tanpa parameter yang diizinkan. Selain itu, pelacakan referensi objek hanya dilakukan untuk objek yang ditandai dengan `GenerateType.CircularReference`. Jika Anda ingin melacak objek lain, bungkus objek tersebut.

CustomFormatter
---
Jika mengimplementasikan `MemoryPackCustomFormatterAttribute<T>` atau `MemoryPackCustomFormatterAttribute<TFormatter, T>` (lebih cepat, namun lebih kompleks), Anda dapat mengonfigurasi agar anggota MemoryPackObject menggunakan custom formatter.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack menyediakan atribut pemformatan berikut: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serialisasikan anggota ini sebagai UTF16 String, performa lebih baik daripada UTF8 tetapi untuk ASCII, ukuran lebih besar (namun untuk non-ASCII, kadang lebih kecil).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Saat deserialisasi, Dictionary diinisialisasi dengan StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Saat deserialisasi, semua string di-intern (lihat: String.Intern). Jika nilai serupa sering muncul, ini menghemat memori.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Untuk mengonfigurasi equality comparer pada set/dictionary, semua formatter bawaan memiliki overload konstruktor comparer. Anda dapat dengan mudah membuat custom equality-comparer formatter.

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

`BitPackFormatter` hanya mengompresi tipe `bool[]`. `bool[]` biasanya diserialisasi sebagai 1 byte per nilai boolean, namun `BitPackFormatter` menserialisasi `bool[]` seperti `BitArray` dengan menyimpan setiap bool sebagai 1 bit. Dengan menggunakan `BitPackFormatter`, 8 nilai bool menjadi 1 byte, yang biasanya membutuhkan 8 byte, sehingga ukurannya menjadi 8x lebih kecil.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` digunakan untuk `byte[]`, misalnya Anda dapat mengompresi payload besar dengan Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` digunakan untuk `string`, serialisasi string terkompresi (UTF16) dengan Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` digunakan untuk tipe apa pun, data ter-serialisasi dikompresi oleh Brotli. Jika tipe tersebut adalah `byte[]` atau `string`, Anda sebaiknya menggunakan `BrotliFormatter` atau `BrotliStringFormatter` demi performa.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserialisasi dengan Array Pooling
---
Untuk mendeserialisasi array besar (tipe apa pun `T`), MemoryPack menawarkan beberapa metode pooling yang efisien. Cara paling efektif adalah menggunakan fungsi [#Overwrite](#overwrite). Khusus untuk `List<T>`, selalu digunakan kembali.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> digunakan kembali, tanpa alokasi saat deserialisasi.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// untuk operasi yang efisien, Anda dapat mengambil Span<T> melalui CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Cara yang praktis adalah mendeserialisasi ke ArrayPool saat waktu deserialisasi. MemoryPack menyediakan `MemoryPoolFormatter<T>` dan `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Anda harus menulis kode pengembalian sendiri, berikut cuplikannya.

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
    // lakukan apapun...
}   // kembali ke ArrayPool
```

Performa
---
Lihat postingan blog saya [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Ukuran Payload dan Kompresi
---
Ukuran payload tergantung pada nilai target; berbeda dengan JSON, tidak ada key dan ini adalah format biner, sehingga ukuran payload kemungkinan lebih kecil daripada JSON.

Untuk yang menggunakan varint encoding, seperti MessagePack dan Protobuf, MemoryPack cenderung lebih besar jika banyak menggunakan int (pada MemoryPack, int selalu 4 byte karena fixed size encoding, sedangkan MessagePack adalah 1~5 byte).

float dan double adalah 4 byte dan 8 byte di MemoryPack, namun 5 byte dan 9 byte di MessagePack. Jadi MemoryPack lebih kecil, misalnya, untuk array Vector3 (float, float, float).

String secara default adalah UTF8, yang mirip dengan serializer lain, namun jika opsi UTF16 dipilih, akan berbeda sifatnya.

Dalam kasus apa pun, jika ukuran payload besar, kompresi harus dipertimbangkan. LZ4, ZStandard, dan Brotli direkomendasikan.

### Kompresi

MemoryPack menyediakan helper efisien untuk kompresi [Brotli](https://github.com/google/brotli) melalui [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) dan [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). `BrotliCompressor` dan `BrotliDecompressor` dari MemoryPack menyediakan kompresi/dekompresi yang dioptimalkan untuk perilaku internal MemoryPack.

```csharp
using MemoryPack.Compression;

// Kompresi (perlu using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Dapatkan byte[] terkompresi
var compressedBytes = compressor.ToArray();

// Atau tulis ke IBufferWriter<byte> lain (misal PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Dekompresi (perlu using)
using var decompressor = new BrotliDecompressor();

// Dapatkan ReadOnlySequence<byte> terdekompresi dari ReadOnlySpan<byte> atau ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Baik `BrotliCompressor` maupun `BrotliDecompressor` adalah struct, tidak mengalokasikan memori di heap. Keduanya menyimpan data yang terkompresi atau terdekompresi dalam memory pool internal untuk Serialize/Deserialize. Oleh karena itu, perlu melepaskan pooling memory, jangan lupa gunakan `using`.

Level kompresi sangat penting. Default diatur ke quality-1 (CompressionLevel.Fastest), berbeda dengan default .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) akan mendekati kecepatan [LZ4](https://github.com/lz4/lz4), tetapi 4 jauh lebih lambat. Ini dianggap krusial dalam skenario penggunaan serializer. Hati-hati saat menggunakan `BrotliStream` standar (quality-4 adalah default). Dalam kasus apa pun, kecepatan dan ukuran kompresi/dekompresi akan menghasilkan hasil yang sangat berbeda untuk data berbeda. Silakan siapkan data yang akan ditangani aplikasi Anda dan uji sendiri.

Perlu dicatat bahwa terdapat penalti kecepatan beberapa kali lipat antara MemoryPack tanpa kompresi dan MemoryPack dengan kompresi Brotli.

Brotli juga didukung di custom formatter. `BrotliFormatter` dapat mengompres member tertentu.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Serialisasi tipe eksternal
---
Jika Anda ingin men-serialisasi tipe eksternal, Anda bisa membuat custom formatter dan mendaftarkannya ke provider, lihat [Formatter/Provider API](#formatterprovider-api) untuk detailnya. Namun, membuat custom formatter itu sulit. Oleh karena itu, kami menyarankan untuk membuat tipe pembungkus (wrapper). Contohnya, jika Anda ingin men-serialisasi tipe eksternal bernama `AnimationCurve`.

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

Tipe yang dibungkus bersifat public, tetapi dikecualikan dari serialisasi (`MemoryPackIgnore`). Properti yang ingin Anda serialisasi bersifat private, tetapi disertakan (`MemoryPackInclude`). Dua pola konstruktor juga harus disiapkan. Konstruktor yang digunakan oleh serializer harus bersifat private.

Dengan cara ini, harus dibungkus setiap kali, yang cukup merepotkan. Selain itu, struct wrapper tidak dapat merepresentasikan nilai null. Jadi mari kita buat custom formatter.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity tidak mendukung scoped dan TBufferWriter sehingga tandatangan diubah menjadi `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Terakhir, daftarkan formatter di saat startup.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Catatan: AnimationCurve milik Unity sudah dapat diserialisasi secara default sehingga tidak membutuhkan formatter kustom ini untuk AnimationCurve

Paket
---
MemoryPack memiliki paket-paket berikut.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` adalah pustaka utama, menyediakan dukungan penuh untuk serialisasi dan deserialisasi objek biner dengan performa tinggi. Pustaka ini bergantung pada `MemoryPack.Core` untuk pustaka dasar inti dan `MemoryPack.Generator` untuk pembuatan kode. `MemoryPack.Streaming` menambahkan ekstensi untuk [Streaming Serialization](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` menambahkan input/output formatters untuk ASP.NET Core. `MemoryPack.UnityShims` menambahkan tipe shim Unity dan formatter untuk berbagi tipe antara .NET dan Unity.

TypeScript dan ASP.NET Core Formatter
---
MemoryPack mendukung pembuatan kode TypeScript. Ia menghasilkan kelas dan kode serialisasi dari C#, dengan kata lain, Anda dapat berbagi tipe dengan Browser tanpa menggunakan OpenAPI, proto, dll.

Pembuatan kode diintegrasikan dengan Source Generator, opsi berikut (`MemoryPackGenerator_TypeScriptOutputDirectory`) mengatur direktori output untuk kode TypeScript. Kode runtime juga dihasilkan pada saat yang sama, sehingga tidak diperlukan dependensi tambahan.

```xml
<!-- output memorypack TypeScript code to directory -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Tipe MemoryPackable C# harus dianotasi dengan `[GenerateTypeScript]`.

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

Kode runtime dan tipe TypeScript akan dihasilkan di direktori target.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Kode yang dihasilkan adalah sebagai berikut, dengan field sederhana dan metode statis untuk serialize/serializeArray dan deserialize/deserializeArray.

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

Anda dapat menggunakan tipe ini seperti berikut.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serialize ke Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserialize dari ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Paket `MemoryPack.AspNetCoreMvcFormatter` menambahkan input dan output formatter `MemoryPack` untuk ASP.NET Core MVC. Anda dapat menambahkan `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` ke ASP.NET Core MVC dengan kode berikut.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Jika checkContentType: true maka dapat output beberapa format (JSON/MemoryPack, dll...). default-nya adalah false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Jika Anda memanggil dari HttpClient, Anda dapat mengatur `application/x-memorypack` ke content-header.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript Type Mapping

Ada beberapa batasan pada tipe yang dapat dihasilkan. Di antara tipe primitif, `char` dan `decimal` tidak didukung. Selain itu, tipe OpenGenerics tidak dapat digunakan.

|  C#  |  TypeScript  | Deskripsi |
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
| `Guid` |  `string`  | Di TypeScript, direpresentasikan sebagai string namun serialisasi/deserialisasi sebagai binary 16byte
| `DateTime` | `Date` | DateTimeKind akan diabaikan
| `enum` | `const enum` | Tipe dasar `long` dan `ulong` tidak didukung
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Mendukung semua tipe yang mengimplementasikan `ICollection<T>` seperti `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Mendukung semua tipe yang mengimplementasikan `ISet<T>` seperti `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Mendukung semua tipe yang mengimplementasikan `IDictionary<K,V>` seperti `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Hanya mendukung kelas
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` hanya dapat diterapkan pada kelas dan saat ini tidak didukung oleh struct.

### Konfigurasi ekstensi file import dan penamaan anggota

Secara default, MemoryPack menghasilkan ekstensi file `.js` seperti `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Jika Anda ingin mengubah ke ekstensi lain atau kosong, gunakan `MemoryPackGenerator_TypeScriptImportExtension` untuk mengaturnya.
Selain itu, nama anggota secara otomatis dikonversi ke camelCase. Jika Anda ingin menggunakan nama asli, gunakan `MemoryPackGenerator_TypeScriptConvertPropertyName` ke `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- bisa dikosongkan -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- default adalah true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- default adalah false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` memungkinkan anotasi nullable C# tercermin dalam kode TypeScript. Default-nya adalah false, sehingga semuanya menjadi nullable.

Serialisasi Streaming
---
`MemoryPack.Streaming` menyediakan `MemoryPackStreamingSerializer`, yang menambahkan dukungan tambahan untuk serialisasi dan deserialisasi koleksi menggunakan stream.

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
Jika Anda ingin mengimplementasikan formatter secara manual, turunkan dari `MemoryPackFormatter<T>` dan override metode `Serialize` dan `Deserialize`.

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

        // gunakan metode writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // gunakan metode reader.
    }
}
```
Formatter yang dibuat didaftarkan dengan `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Catatan: `unmanged struct` (tidak mengandung tipe referensi) tidak dapat menggunakan custom formatter, selalu diserialisasi dengan native memory layout.

MemoryPackWriter/ReaderOptionalState
---
Inisialisasi `MemoryPackWriter`/`MemoryPackReader` memerlukan OptionalState. Ini adalah pembungkus dari `MemoryPackSerializerOptions`, bisa dibuat dari `MemoryPackWriterOptionalStatePool`.

```csharp
// ketika di-dispose, OptionalState akan dikembalikan ke pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// untuk Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Dependensi target framework
---
MemoryPack menyediakan `netstandard2.1` dan `net7.0` namun keduanya tidak kompatibel. Misalnya, tipe MemoryPackable di bawah proyek `netstandard2.1` dan digunakan dari proyek `net7.0`, akan menimbulkan exception runtime seperti berikut

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Karena net7.0 menggunakan anggota static abstract (`Virtual static method`), yang tidak didukung oleh netstandard2.1, perilaku ini adalah spesifikasi.

Proyek .NET 7 sebaiknya tidak menggunakan dll netstandard 2.1. Dengan kata lain, jika aplikasinya adalah Proyek .NET 7, semua dependensi yang menggunakan MemoryPack harus mendukung .NET 7. Jadi jika pengembang library memiliki dependensi pada MemoryPack, Anda perlu mengonfigurasi target framework ganda.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) adalah framework grpc-dotnet code-first menggunakan MessagePack sebagai pengganti protobuf. MagicOnion kini mendukung MemoryPack sebagai lapisan serialisasi melalui paket `MagicOnion.Serialization.MemoryPack` (preview). Lihat detailnya: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Versi Unity minimum yang didukung adalah `2022.3.12f1`.

Paket inti `MemoryPack` disediakan melalui nuget. Ini juga tersedia di Unity. Jika Anda ingin mendapatkan dukungan tipe bawaan Unity, kami juga menyediakan ekstensi MemoryPack.Unity.

1. Instal `MemoryPack` dari NuGet menggunakan [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Buka Window dari NuGet -> Manage NuGet Packages, Cari "MemoryPack" dan tekan Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Jika Anda menemui error konflik versi, silakan nonaktifkan validasi versi di Player Settings (Edit -> Project Settings -> Player -> Scroll ke bawah dan expand "Other Settings" lalu hilangkan centang "Assembly Version Validation" di bagian "Configuration").

2. Instal paket `MemoryPack.Unity` dengan mereferensikan URL git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack menggunakan tag rilis *.*.*, jadi Anda dapat menentukan versi seperti #1.0.0. Contoh: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Seperti halnya versi .NET, kode dihasilkan oleh code generator (`MemoryPack.Generator.dll`). Implementasi tanpa refleksi juga memberikan performa terbaik di IL2CPP.

Untuk informasi lebih lanjut tentang Unity dan Source Generator, silakan lihat [dokumentasi Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator juga digunakan secara resmi oleh Unity oleh [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) dan [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Dengan kata lain, ini adalah standar untuk code generation di Unity generasi berikutnya.

Anda dapat melakukan serialisasi semua tipe unmanaged (seperti `Vector3`, `Rect`, dll...) dan beberapa kelas (`AnimationCurve`, `Gradient`, `RectOffset`). Jika Anda ingin melakukan serialisasi tipe khusus Unity lainnya, lihat bagian [Serialize external types](#serialize-external-types).

Dalam performa Unity, MemoryPack x3~x10 lebih cepat dari JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Jika kode bersama memiliki tipe Unity (`Vector2`, dll...), MemoryPack menyediakan paket `MemoryPack.UnityShims` di NuGet.

Paket `MemoryPack.UnityShims` menyediakan shim untuk struct standar Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) dan beberapa kelas (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Saat ini, terdapat batasan-batasan berikut untuk penggunaan di Unity


1. Versi Unity tidak mendukung CustomFormatter.
2. Jika Anda menggunakan .NET7 atau lebih baru, format biner MemoryPack tidak sepenuhnya kompatibel dengan Unity.
    - Masalah ini terjadi pada tipe value yang secara eksplisit diberikan `[StructLayout(LayoutKind.Auto)]`. (Default untuk struct adalah `LayoutKind.Sequencial`.) Untuk tipe seperti ini, binary yang diserialisasi di .NET tidak dapat dideserialisasi di Unity. Begitu juga sebaliknya, binary yang diserialisasi di Unity tidak dapat dideserialisasi di sisi .NET.
    - Tipe yang terpengaruh biasanya meliputi tipe berikut.
        - `DateTimeOffset`
        - `ValueTuple`
    - Solusi sederhana saat ini adalah tidak menggunakan tipe-tipe ini.


Native AOT
---
Sayangnya, .NET 7 Native AOT menyebabkan crash (`Generic virtual method pointer lookup failure`) saat menggunakan MemoryPack karena bug runtime. 
Akan diperbaiki di .NET 8. Menggunakan versi preview ``Microsoft.DotNet.ILCompiler`` akan memperbaikinya di .NET 7. Silakan lihat [komentar issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) untuk cara setup-nya.

Spesifikasi format wire biner
---
Tipe `T` yang didefinisikan dalam `Serialize<T>` dan `Deserialize<T>` disebut skema C#. Format MemoryPack bukanlah format self-described. Deserialisasi membutuhkan skema C# yang sesuai. Tipe-tipe ini ada sebagai representasi internal dari binary, namun tipe tidak dapat ditentukan tanpa skema C#.

Endian harus `Little Endian`. Namun, implementasi referensi C# tidak memperhatikan endianness sehingga tidak dapat digunakan pada mesin big-endian. Namun, komputer modern biasanya menggunakan little-endian.

Ada delapan tipe format.

* Unmanaged struct
* Object
* Version Tolerant Object
* Circular Reference Object
* Tuple
* Collection
* String
* Union

### Unmanaged struct

Unmanaged struct adalah struct C# yang tidak mengandung tipe referensi, dengan batasan serupa pada [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Serialisasi struct sesuai dengan layout aslinya, termasuk padding.

### Object

`(byte memberCount, [values...])`

Object memiliki 1 byte unsigned sebagai jumlah anggota di header. Jumlah anggota mengizinkan `0` hingga `249`, `255` merepresentasikan object adalah `null`. Values menyimpan nilai memorypack sebanyak jumlah anggota.

### Version Tolerant Object

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Version Tolerant Object mirip dengan Object tetapi memiliki panjang byte dari values di header. varint mengikuti spesifikasi ini, sbyte pertama adalah nilai atau typeCode dan X byte berikutnya adalah nilai. 0 hingga 127 = unsigned byte value, -1 hingga -120 = signed byte value, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Circular Reference Object

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Circular Reference Object mirip dengan Version Tolerant Object tetapi jika memberCount adalah 250, varint(unsigned-int32) berikutnya adalah referenceId. Jika tidak, setelah byte-length-of-values, varint referenceId ditulis.

### Tuple

`(values...)`

Tuple adalah koleksi nilai dengan ukuran tetap dan tidak dapat bernilai null. Di .NET, `KeyValuePair<TKey, TValue>` dan `ValueTuple<T,...>` diserialisasi sebagai Tuple.

### Collection

`(int length, [values...])`

Collection memiliki 4 byte signed integer sebagai jumlah data di header, `-1` merepresentasikan `null`. Values menyimpan nilai memorypack sebanyak jumlah length.

### String

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String memiliki dua bentuk, UTF16 dan UTF8. Jika 4 byte signed integer pertama adalah `-1`, merepresentasikan null. `0`, merepresentasikan kosong. UTF16 sama seperti collection (diserialisasi sebagai `ReadOnlySpan<char>`, jumlah byte utf16-value adalah utf16-length * 2). Jika signed integer pertama <= `-2`, nilai diencode dengan UTF8. utf8-byte-count diencode dalam bentuk komplemen, gunakan `~utf8-byte-count` untuk mendapatkan jumlah byte. Signed integer berikutnya adalah utf16-length, mengizinkan `-1` yang berarti panjang tidak diketahui. utf8-bytes menyimpan byte sebanyak utf8-byte-count.

### Union

`(byte tag, value)`  
`(250, ushort tag, value)`

Byte unsigned pertama adalah tag untuk tipe nilai yang dibedakan atau flag, `0` hingga `249` merepresentasikan tag, `250` berarti unsigned short berikutnya adalah tag, `255` merepresentasikan union adalah `null`.

License
---
Perpustakaan ini dilisensikan di bawah MIT License.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---