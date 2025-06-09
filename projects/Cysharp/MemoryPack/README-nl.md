# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Zero encoding extreme performance binary serializer voor C# en Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> In vergelijking met [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Gemeten op .NET 7 / Ryzen 9 5950X machine. Deze serializers hebben een `IBufferWriter<byte>` methode, geserialiseerd met `ArrayBufferWriter<byte>` en hergebruikt om buffer kopiëren te vermijden.

Voor standaard objecten is MemoryPack x10 sneller en x2 ~ x5 sneller dan andere binaire serializers. Voor struct arrays is MemoryPack zelfs nog krachtiger, met snelheden tot x50 ~ x200 hoger dan andere serializers.

MemoryPack is mijn 4e serializer. Hiervoor heb ik bekende serializers gemaakt, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). De reden voor de snelheid van MemoryPack is het C#-specifieke, voor C# geoptimaliseerde binaire formaat en een goed afgestemde implementatie gebaseerd op mijn eerdere ervaring. Het is ook een compleet nieuw ontwerp dat gebruik maakt van .NET 7 en C# 11 en de Incremental Source Generator (.NET Standard 2.1 (.NET 5, 6) en er is ook Unity-ondersteuning).

Andere serializers voeren veel coderingsbewerkingen uit zoals VarInt-codering, tags, string, enz. Het MemoryPack-formaat gebruikt een zero-encoding ontwerp dat zoveel mogelijk C#-geheugen kopieert. Zero-encoding lijkt op FlatBuffers, maar heeft geen speciaal type nodig, het serialisatiedoel van MemoryPack is POCO.

Naast prestaties heeft MemoryPack de volgende functies.

* Ondersteunt moderne I/O-API's (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Native AOT-vriendelijke Source Generator gebaseerde codegeneratie, geen Dynamic CodeGen (IL.Emit)
* Reflectievrije niet-generieke API's
* Deserialiseren in een bestaand instantie
* Polymorfe (Union) serialisatie
* Beperkt versie-tolerant (snel/standaard) en volledige versie-tolerante ondersteuning
* Serialisatie van circulaire referenties
* PipeWriter/Reader gebaseerde streaming serialisatie
* TypeScript codegeneratie en ASP.NET Core Formatter
* Unity (2021.3) IL2CPP-ondersteuning via .NET Source Generator

Installatie
---
Deze bibliotheek wordt verspreid via NuGet. Voor de beste prestaties wordt `.NET 7` aanbevolen. De minimale vereiste is `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Daarnaast vereist een code-editor Roslyn 4.3.1 ondersteuning, bijvoorbeeld Visual Studio 2022 versie 17.3, .NET SDK 6.0.401. Zie voor details het [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support) document.

Voor Unity zijn de vereisten en het installatieproces volledig anders. Zie de [Unity](#unity) sectie voor details.

Snelle start
---
Definieer een struct of klasse om te serialiseren en annoteer deze met het `[MemoryPackable]` attribuut en het `partial` sleutelwoord.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Serialisatiecode wordt gegenereerd door de C# source generator functionaliteit, die de `IMemoryPackable<T>` interface implementeert. In Visual Studio kun je de gegenereerde code bekijken door de sneltoets `Ctrl+K, R` te gebruiken op de klassenaam en `*.MemoryPackFormatter.g.cs` te selecteren.

Roep `MemoryPackSerializer.Serialize<T>/Deserialize<T>` aan om een objectinstantie te serialiseren/deserialiseren.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

De `Serialize`-methode ondersteunt een returntype van `byte[]` evenals serialisatie naar `IBufferWriter<byte>` of `Stream`. De `Deserialize`-methode ondersteunt `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` en `Stream`. Er zijn ook niet-generieke versies.

Standaard ondersteunde types
---
Deze types kunnen standaard worden geserialiseerd:

* .NET-primitieven (`byte`, `int`, `bool`, `char`, `double`, etc.)
* Unmanaged types (Elke `enum`, elke door de gebruiker gedefinieerde `struct` zonder referentietypes)
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
* Immutable collecties (`ImmutableList<>`, etc.) en interfaces (`IImmutableList<>`, etc.)

Definieer `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` kan worden geannoteerd op elke `class`, `struct`, `record`, `record struct` en `interface`. Als een type een `struct` of `record struct` is die geen referentietypes bevat ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), wordt extra annotatie (ignore, include, constructor, callbacks) niet gebruikt; deze worden direct uit het geheugen geserialiseerd/gedeserialiseerd.

Anders serialiseert `[MemoryPackable]` standaard de publieke instantie-eigenschappen of velden. Je kunt `[MemoryPackIgnore]` gebruiken om een serialisatiedoel te verwijderen, `[MemoryPackInclude]` promoot een privé-lid tot serialisatiedoel.

```csharp
[MemoryPackable]
public partial class Sample
{
    // deze types worden standaard geserialiseerd
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // deze types worden standaard niet geserialiseerd
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // gebruik [MemoryPackIgnore] om een publiek lid uit te sluiten van serialisatie
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // gebruik [MemoryPackInclude] om een privé-lid te promoten tot serialisatiedoel
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

De codegenerator van `MemoryPack` voegt informatie toe over welke leden worden geserialiseerd aan de `<remarks />` sectie. Dit kan worden bekeken door met Intellisense over het type te zweven.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Alle leden moeten memorypack-serialiseerbaar zijn, zo niet dan zal de codegenerator een foutmelding geven.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack heeft 35 diagnosticaregels (`MEMPACK001` tot `MEMPACK035`) om comfortabel te definiëren.

Als een doeltijdstype extern MemoryPack-serialisatie heeft en geregistreerd is, gebruik dan `[MemoryPackAllowSerialize]` om diagnostics te onderdrukken.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

De volgorde van leden is **belangrijk**. MemoryPack serialiseert niet de ledennaam of andere informatie, maar serialiseert velden in de volgorde waarin ze zijn gedeclareerd. Als een type is overgeërfd, gebeurt serialisatie in de volgorde ouder → kind. De volgorde van leden mag niet veranderen voor de deserialisatie. Zie voor schema-evolutie de [Version tolerant](#version-tolerant) sectie.

De standaardvolgorde is sequentieel, maar je kunt een expliciete layout kiezen met `[MemoryPackable(SerializeLayout.Explicit)]` en `[MemoryPackOrder()]`.

```csharp
// serialiseer Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Constructorselectie

MemoryPack ondersteunt zowel geparametriseerde als parameterloze constructors. De selectie van de constructor volgt deze regels (geldt voor klassen en structs):

* Als er een `[MemoryPackConstructor]` is, wordt deze gebruikt.
* Als er geen expliciete constructor is (inclusief privé), wordt een parameterloze gebruikt.
* Als er één parameterloze/geparametriseerde constructor is (inclusief privé), wordt deze gebruikt.
* Als er meerdere constructors zijn, dan moet het `[MemoryPackConstructor]` attribuut worden toegepast op de gewenste constructor (de generator kiest niet automatisch), anders geeft de generator een foutmelding.
* Bij gebruik van een geparametriseerde constructor moeten alle parameternamen overeenkomen met de corresponderende ledennamen (hoofdletterongevoelig).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Je kunt een geparametriseerde constructor gebruiken - parameternamen moeten overeenkomen met de corresponderende ledennaam (hoofdletterongevoelig)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// ondersteunt ook record primary constructor
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
// Als er meerdere constructors zijn, dan moet [MemoryPackConstructor] gebruikt worden
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Serialisatie-callbacks

Bij serialiseren/deserialiseren kan MemoryPack een before/after event aanroepen met behulp van de attributen `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Deze kunnen zowel statische als instantie (niet-statische) methoden annoteren, en zowel publieke als private methoden.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // aanroepvolgorde van de methoden is statisch -> instantie
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // private methode is ook toegestaan
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

    // Let op: instantie-methode met MemoryPackOnDeserializing wordt niet aangeroepen als instantie niet via `ref` is meegegeven
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

Callbacks staan parameterloze methoden en `ref reader/writer, ref T value` methoden toe. Bijvoorbeeld, ref callbacks kunnen een custom header schrijven/uitlezen vóór het serialisatieproces.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, gebruik where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // schrijf GUID in de header.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // lees custom header vóór deserialisatie
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Als je een waarde toekent aan `ref value`, kun je de waarde wijzigen die wordt gebruikt voor serialisatie/deserialisatie. Bijvoorbeeld, instantieren vanuit een ServiceProvider.

```csharp
// voor je deze formatter gebruikt, stel ServiceProvider in
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

Definieer een custom collectie
---
Standaard probeert een met `[MemoryPackObject]` geannoteerd type zijn members te serialiseren. Echter, als een type een collectie is (`ICollection<>`, `ISet<>`, `IDictionary<,>`), gebruik dan `GenerateType.Collection` om het correct te serialiseren.

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

Statische constructor
---
Een MemoryPackable class kan geen statische constructor definiëren omdat de gegenereerde partial class deze gebruikt. In plaats daarvan kun je een `static partial void StaticConstructor()` definiëren om hetzelfde te bereiken.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polymorfisme (Union)
---
MemoryPack ondersteunt het serialiseren van interface- en abstracte klasse-objecten voor polymorfe serialisatie. In MemoryPack wordt deze functie Union genoemd. Alleen interfaces en abstracte klassen mogen worden geannoteerd met `[MemoryPackUnion]` attributen. Unieke union-tags zijn vereist.

```csharp
// Annoteer [MemoryPackable] en afgeleide types met [MemoryPackUnion]
// Union ondersteunt ook abstracte klassen
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

// Serialize als interface type.
var bin = MemoryPackSerializer.Serialize(data);

// Deserialize als interface type.
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

`tag` staat waarden toe van `0` ~ `65535`, het is vooral efficiënt voor minder dan `250`.
```
Als een interface en afgeleide typen zich in verschillende assemblies bevinden, kun je in plaats daarvan `MemoryPackUnionFormatterAttribute` gebruiken. Formatters worden zo gegenereerd dat ze automatisch worden geregistreerd via `ModuleInitializer` in C# 9.0 en hoger.

> Let op: `ModuleInitializer` wordt niet ondersteund in Unity, dus de formatter moet handmatig worden geregistreerd. Om je union formatter te registreren, roep je `{naam van je union formatter}Initializer.RegisterFormatter()` handmatig aan in Startup. Bijvoorbeeld `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB definieer de definitie buiten het doeldtype
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union kan in code worden samengesteld via `DynamicUnionFormatter<T>`.

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
`Serialize` heeft drie overloads.

```csharp
// Niet-generieke API is ook beschikbaar, bij deze versies is het eerste argument Type en de waarde object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Voor prestaties wordt de aanbevolen API met `BufferWriter` gebruikt. Dit serialiseert direct in de buffer. Het kan worden toegepast op `PipeWriter` in `System.IO.Pipelines`, `BodyWriter` in ASP .NET Core, enzovoort.

Als een `byte[]` vereist is (bijv. `RedisValue` in [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), is de teruggegeven `byte[]` API eenvoudig en bijna net zo snel.

Let op dat `SerializeAsync` voor `Stream` alleen asynchroon is voor Flush; het serialiseert alles in één keer in de interne poolbuffer van MemoryPack en schrijft vervolgens met `WriteAsync`. Daarom is de `BufferWriter` overload, die buffer en flush scheidt en beheert, beter.

Als je volledig streaming wilt schrijven, zie de sectie [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` configureert of strings als UTF16 of UTF8 worden geserialiseerd. Dit kan worden geconfigureerd door `MemoryPackSerializerOptions.Utf8` door te geven voor UTF8-codering, `MemoryPackSerializerOptions.Utf16` voor UTF16-codering, of `MemoryPackSerializerOptions.Default` wat standaard op UTF8 staat. Null doorgeven of de standaardparameter gebruiken resulteert in UTF8-codering.

Aangezien de interne stringrepresentatie van C# UTF16 is, presteert UTF16 beter. Echter, de payload is meestal groter; in UTF8 is een ASCII-string één byte, terwijl deze in UTF16 twee bytes is. Omdat het verschil in grootte van deze payload zo groot is, wordt standaard UTF8 gebruikt.

Als de data niet-ASCII is (bijv. Japans, wat meer dan 3 bytes kan zijn, en UTF8 is dan groter), of als je het apart moet comprimeren, kan UTF16 betere resultaten geven.

Hoewel tijdens serialisatie kan worden gekozen voor UTF8 of UTF16, is het niet nodig om dit tijdens deserialisatie te specificeren. Het wordt automatisch gedetecteerd en normaal gedeserialiseerd.

Daarnaast kun je `IServiceProvider? ServiceProvider { get; init; }` uit de opties krijgen/instellen. Dit is handig om een DI-object (zoals `ILogger<T>`) te verkrijgen tijdens het serialisatieproces (`MemoryPackReader/MemoryPackWriter` heeft een .Options property).

Deserialize API
---
`Deserialize` heeft overloads voor `ReadOnlySpan<byte>` en `ReadOnlySequence<byte>`, `Stream` en `ref` ondersteuning.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

De `ref` overload overschrijft een bestaande instantie, zie voor details de [Overwrite](#overwrite) sectie.

`DeserializeAsync(Stream)` is geen volledige streaming read-operatie; eerst wordt tot het einde van de stream gelezen in de interne pool van MemoryPack, daarna wordt gedeserialiseerd.

Als je een volledige streaming read-operatie wilt uitvoeren, zie de sectie [Streaming Serialization](#streaming-serialization).

Overwrite
---
Om allocaties te verminderen ondersteunt MemoryPack deserialisatie naar een bestaande instantie, waarbij deze wordt overschreven. Dit kan met de overload `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// overschrijf data naar bestaande instantie.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack zal proberen zoveel mogelijk te overschrijven, maar als aan de volgende voorwaarden niet wordt voldaan, wordt er een nieuwe instantie aangemaakt (zoals bij normale deserialisatie).

* ref waarde (inclusief leden in het objectgrafiek) is null, stel een nieuwe instantie in
* alleen parameterloze constructor toegestaan, als een constructor met parameters wordt gebruikt, wordt een nieuwe instantie gemaakt
* als waarde `T[]` is, alleen hergebruiken als de lengte gelijk is, anders een nieuwe instantie maken
* als waarde een collectie is die een `.Clear()` methode heeft (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) wordt Clear() aangeroepen en wordt deze hergebruikt, anders wordt een nieuwe instantie aangemaakt

Version tolerant
---
Standaard (`GenerateType.Object`) ondersteunt MemoryPack beperkte schema-evolutie.

* unmanaged struct kan niet meer worden gewijzigd
* leden kunnen worden toegevoegd, maar niet verwijderd
* lidnaam kan worden gewijzigd
* ledenvolgorde kan niet worden gewijzigd
* lidtype kan niet worden gewijzigd

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Toevoegen is OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Verwijderen is NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Volgorde wijzigen is NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

In het gebruiksgeval, oude data opslaan (naar bestand, naar redis, etc...) en lezen naar nieuw schema is altijd oké. In het RPC-scenario bestaat het schema zowel aan de client- als aan de serverzijde; de client moet vóór de server worden bijgewerkt. Een bijgewerkte client kan zonder problemen verbinding maken met de oude server, maar een oude client kan niet verbinden met een nieuwe server.

Standaard, wanneer oude data wordt gelezen naar een nieuw schema, worden leden die niet aan de datazijde staan geïnitialiseerd met het `default` literal.
Als je dit wilt vermijden en de initiële waarden van velden/properties wilt gebruiken, kun je `[SuppressDefaultInitialization]` gebruiken.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < als oude data ontbreekt, wordt `111` gezet.
    
    public int Prop3 { get; set; } = 222; // < als oude data ontbreekt, wordt `default` gezet.
}
```

 `[SuppressDefaultInitialization]` heeft de volgende beperking:
- Kan niet worden gebruikt met readonly, init-only en required modifier.

De volgende [Serialization info](#serialization-info) sectie laat zien hoe je kunt controleren op schemawijzigingen, bijvoorbeeld met CI, om ongelukken te voorkomen.

Bij gebruik van `GenerateType.VersionTolerant` wordt volledige versie-tolerantie ondersteund.

* unmanaged struct kan niet meer worden gewijzigd
* alle leden moeten expliciet `[MemoryPackOrder]` krijgen (behalve als `SerializeLayout.Sequential` is geannoteerd)
* leden kunnen worden toegevoegd, verwijderd, maar volgorde niet hergebruiken (wel ontbrekende volgorde gebruiken)
* lidnaam kan worden gewijzigd
* ledenvolgorde kan niet worden gewijzigd
* lidtype kan niet worden gewijzigd

```csharp
// Ok om te serialiseren/deserialiseren beide 
// VersionTolerantObject1 -> VersionTolerantObject2 en 
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

// verwijderd
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// toegevoegd
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Indien SerializeLayout.Sequential expliciet is ingesteld, wordt automatische ordening toegestaan.
// Maar het is niet mogelijk om leden te verwijderen voor versie-tolerantie.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` is langzamer dan `GenerateType.Object` bij het serialiseren. Ook zal de payload-grootte iets groter zijn.

Serialisatie-informatie
----
Je kunt via IntelliSense in het type zien welke leden worden geserialiseerd. Er is een optie om deze informatie tijdens het compileren naar een bestand te schrijven. Stel `MemoryPackGenerator_SerializationInfoOutputDirectory` als volgt in.

```xml
<!-- output memorypack serialisatie-info naar een map -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

De volgende informatie wordt naar het bestand geschreven.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Als het type unmanaged is, wordt `unmanaged` vóór de typenaam weergegeven.

```txt
unmanaged FooStruct
---
int x
int y
```

Door de verschillen in dit bestand te controleren, kunnen gevaarlijke schemawijzigingen worden voorkomen. Bijvoorbeeld, je kunt CI gebruiken om de volgende regels te detecteren

* wijziging van unmanaged type
* wijziging van ledenvolgorde
* verwijderen van leden

Circulaire Referentie
---
MemoryPack ondersteunt ook circulaire referenties. Dit maakt het mogelijk om boomstructuren als zodanig te serialiseren.

```csharp
// om circulaire referentie mogelijk te maken, gebruik GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

 Bijvoorbeeld, [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) code wordt dan als volgt.

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

`GenerateType.CircularReference` heeft dezelfde eigenschappen als versie-tolerant. Echter, als extra beperking zijn alleen parameterloze constructors toegestaan. Ook wordt object-referentie-tracking alleen gedaan voor objecten gemarkeerd met `GenerateType.CircularReference`. Als je een ander object wilt volgen, wikkel het dan in.

CustomFormatter
---
Als je `MemoryPackCustomFormatterAttribute<T>` of `MemoryPackCustomFormatterAttribute<TFormatter, T>` implementeert (presteert beter, maar complexer), kun je een custom formatter configureren voor een lid van een MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack biedt de volgende formatter-attributen: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serialiseer dit lid als UTF16 String, het is sneller dan UTF8 maar in ASCII is de grootte groter (maar voor niet-ASCII soms kleiner).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Bij deserialisatie wordt Dictionary geïnitialiseerd met StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // Tijdens deserialisatie worden alle strings geïnterneerd (zie: String.Intern). Als vergelijkbare waarden vaak voorkomen, bespaart dit geheugen.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Om een gelijkheidscomparer voor een set/dictionary te configureren, hebben alle ingebouwde formatters een comparer-constructor overload. Je kunt eenvoudig aangepaste gelijkheidscomparer-formatters maken.

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

`BitPackFormatter` comprimeert alleen `bool[]` types. `bool[]` wordt normaal geserialiseerd als 1 byte per boolean waarde, maar `BitPackFormatter` serialiseert `bool[]` zoals een `BitArray` waarbij elke bool als 1 bit wordt opgeslagen. Door `BitPackFormatter` te gebruiken, worden 8 booleans 1 byte, terwijl dat normaal 8 bytes zou zijn, wat resulteert in een 8x kleinere grootte.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` is voor `byte[]`, bijvoorbeeld kun je met Brotli een grote payload comprimeren.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` is voor `string`, serialiseer gecomprimeerde string (UTF16) met Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```

`BrotliFormatter<T>` is voor elk type, seriële data gecomprimeerd door Brotli. Als een type `byte[]` of `string` is, kun je voor de prestaties beter `BrotliFormatter` of `BrotliStringFormatter` gebruiken.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserialiseren met array pooling
---
Om een grote array (elke `T`) te deserialiseren, biedt MemoryPack meerdere efficiënte pooling-methoden. De meest effectieve manier is om de [#Overwrite](#overwrite) functie te gebruiken. In het bijzonder wordt `List<T>` altijd hergebruikt.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> wordt hergebruikt, geen allocatie bij deserialiseren.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// voor efficiënte bewerking kun je Span<T> krijgen via CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Een handige manier is deserialiseren naar een ArrayPool op het moment van deserialisatie. MemoryPack biedt `MemoryPoolFormatter<T>` en `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Je moet zelf de return code schrijven, hier een snippet.

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
    // doe iets...
}   // teruggeven aan ArrayPool
```

Prestaties
---
Zie mijn blogpost [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Payloadgrootte en compressie
---
De payloadgrootte hangt af van de doelwaarde; in tegenstelling tot JSON zijn er geen sleutels en het is een binair formaat, dus de payloadgrootte zal waarschijnlijk kleiner zijn dan bij JSON.

Voor formaten met varint-codering, zoals MessagePack en Protobuf, is MemoryPack vaak groter als er veel ints worden gebruikt (in MemoryPack zijn ints altijd 4 bytes vanwege fixed size encoding, terwijl MessagePack 1~5 bytes gebruikt).

float en double zijn 4 bytes en 8 bytes in MemoryPack, maar 5 bytes en 9 bytes in MessagePack. Dus MemoryPack is kleiner, bijvoorbeeld voor Vector3 (float, float, float) arrays.

String is standaard UTF8, wat vergelijkbaar is met andere serializers, maar als de UTF16-optie wordt gekozen, heeft het een ander karakter.

In elk geval, als de payloadgrootte groot is, moet compressie worden overwogen. LZ4, ZStandard en Brotli worden aanbevolen.

### Compressie

MemoryPack biedt een efficiënte helper voor [Brotli](https://github.com/google/brotli) compressie via [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) en [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). MemoryPack's `BrotliCompressor` en `BrotliDecompressor` bieden compressie/decompressie geoptimaliseerd voor het interne gedrag van MemoryPack.

```csharp
using MemoryPack.Compression;

// Compressie (vereist using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Verkrijg gecomprimeerde byte[]
var compressedBytes = compressor.ToArray();

// Of schrijf naar een andere IBufferWriter<byte> (bijvoorbeeld PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Decompressie (vereist using)
using var decompressor = new BrotliDecompressor();

// Verkrijg gedecomprimeerde ReadOnlySequence<byte> van ReadOnlySpan<byte> of ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Zowel `BrotliCompressor` als `BrotliDecompressor` zijn structs, ze alloceren geen geheugen op de heap. Beide slaan gecomprimeerde of gedecomprimeerde data op in een interne geheugenpool voor Serialize/Deserialize. Daarom is het noodzakelijk om het geheugengebruik vrij te geven; vergeet niet om `using` te gebruiken.

Het compressieniveau is erg belangrijk. De standaardwaarde is ingesteld op quality-1 (CompressionLevel.Fastest), wat anders is dan de .NET-standaard (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) is qua snelheid vergelijkbaar met [LZ4](https://github.com/lz4/lz4), maar 4 is veel langzamer. Dit is cruciaal bevonden in het serializer-gebruiksscenario. Wees voorzichtig bij het gebruik van de standaard `BrotliStream` (quality-4 is de standaard). In elk geval zullen compressie-/decompressiesnelheden en -groottes zeer verschillende resultaten opleveren voor verschillende data. Bereid de data voor die jouw applicatie moet verwerken en test het zelf.

Let op: er is een meervoudige snelheidsstraf tussen MemoryPack's ongecomprimeerde en Brotli's extra compressie.

Brotli wordt ook ondersteund in een custom formatter. Met `BrotliFormatter` kun je een specifiek lid comprimeren.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Externe types serialiseren
---
Als je externe types wilt serialiseren, kun je een custom formatter maken en deze registreren bij de provider, zie [Formatter/Provider API](#formatterprovider-api) voor details. Het maken van een custom formatter is echter moeilijk. Daarom raden we aan een wrappertype te maken. Bijvoorbeeld, als je een extern type wilt serialiseren genaamd `AnimationCurve`.

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

Het te wrappen type is public, maar uitgesloten van serialisatie (`MemoryPackIgnore`). De properties die je wilt serialiseren zijn private, maar inbegrepen (`MemoryPackInclude`). Twee patronen van constructors moeten ook voorbereid zijn. De constructor die door de serializer wordt gebruikt, moet private zijn.

Zoals het nu is, moet het elke keer worden gewrapt, wat onhandig is. En een struct wrapper kan geen null representeren. Laten we dus een custom formatter maken.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity ondersteunt geen scoped en TBufferWriter, dus wijzig de signature naar `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Registreer tenslotte de formatter in startup.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Opmerking: Unity's AnimationCurve is standaard serialiseerbaar, dus deze aangepaste formatter is niet nodig voor AnimationCurve

Pakketten
---
MemoryPack heeft de volgende pakketten.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` is de hoofd bibliotheek en biedt volledige ondersteuning voor hoge prestaties bij serialisatie en deserialisatie van binaire objecten. Het is afhankelijk van `MemoryPack.Core` voor de kernbibliotheken en van `MemoryPack.Generator` voor codegeneratie. `MemoryPack.Streaming` voegt aanvullende extensies toe voor [Streaming Serialization](#streaming-serialization).  `MemoryPack.AspNetCoreMvcFormatter` voegt input/output formatters toe voor ASP.NET Core. `MemoryPack.UnityShims` voegt Unity shim types en formatters toe voor gedeeld gebruik van types tussen .NET en Unity.

TypeScript en ASP.NET Core Formatter
---
MemoryPack ondersteunt TypeScript codegeneratie. Het genereert klassen- en serialisatiecode vanuit C#, met andere woorden, je kunt types delen met de browser zonder gebruik te maken van OpenAPI, proto, etc.

Codegeneratie is geïntegreerd met Source Generator, de volgende optie (`MemoryPackGenerator_TypeScriptOutputDirectory`) stelt de uitvoermap in voor TypeScript-code. Runtime code wordt gelijktijdig gegenereerd, dus er zijn geen aanvullende afhankelijkheden vereist.

```xml
<!-- output memorypack TypeScript-code naar map -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Een C# MemoryPackable type moet geannoteerd zijn met `[GenerateTypeScript]`.

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

Runtime code en TypeScript type worden gegenereerd in de doelmap.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

De gegenereerde code ziet er als volgt uit, met eenvoudige velden en statische methoden voor serialize/serializeArray en deserialize/deserializeArray.

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

Je kunt dit type als volgt gebruiken.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serialiseer naar Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserialiseer van ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Het pakket `MemoryPack.AspNetCoreMvcFormatter` voegt `MemoryPack` input en output formatters toe aan ASP.NET Core MVC. Je kunt `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` toevoegen aan ASP.NET Core MVC met de volgende code.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Als checkContentType: true, dan kan meerdere formaten outputten (JSON/MemoryPack, etc...). standaard is false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Als je aanroept vanuit HttpClient, kun je `application/x-memorypack` instellen als content-header.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### TypeScript Type Mapping

Er zijn enkele beperkingen op de typen die gegenereerd kunnen worden. Onder de primitieve types worden `char` en `decimal` niet ondersteund. Ook kan een OpenGenerics type niet gebruikt worden.

|  C#  |  TypeScript  | Beschrijving |
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
| `Guid` |  `string`  | In TypeScript wordt dit als string weergegeven, maar bij serialiseren/deserialiseren als 16-byte binaire data
| `DateTime` | `Date` | DateTimeKind wordt genegeerd
| `enum` | `const enum` | `long` en `ulong` als onderliggende types worden niet ondersteund
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Ondersteunt alle `ICollection<T>` geïmplementeerde types zoals `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Ondersteunt alle `ISet<T>` geïmplementeerde types zoals `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Ondersteunt alle `IDictionary<K,V>` geïmplementeerde types zoals `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Ondersteunt alleen klassen
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` kan alleen op klassen worden toegepast en wordt momenteel niet ondersteund voor structs.

### Extensie van importbestand en lidnaamnotatie configureren

Standaard genereert MemoryPack de bestandsextensie als `.js`, bijvoorbeeld `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Wil je een andere extensie of geen extensie, gebruik dan `MemoryPackGenerator_TypeScriptImportExtension` om dit te configureren.
Ook worden de lidnamen automatisch omgezet naar camelCase. Wil je de originele naam gebruiken, zet `MemoryPackGenerator_TypeScriptConvertPropertyName` op `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- mag leeg zijn -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- standaard is true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- standaard is false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` zorgt ervoor dat C# nullable annotaties worden weerspiegeld in de TypeScript-code. De standaardwaarde is false, waardoor alles nullable wordt.

Streaming Serialisatie
---
`MemoryPack.Streaming` biedt `MemoryPackStreamingSerializer`, die extra ondersteuning toevoegt voor het serialiseren en deserialiseren van collecties met streams.

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
Als je een formatter handmatig wilt implementeren, erf dan van `MemoryPackFormatter<T>` en overschrijf de methoden `Serialize` en `Deserialize`.

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

        // gebruik writer-methoden.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // gebruik reader-methoden.
    }
}
```
De gemaakte formatter wordt geregistreerd met `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Let op: `unmanaged struct` (bevat geen referentietypen) kan geen custom formatter gebruiken, deze wordt altijd geserialiseerd volgens de native geheugenlayout.

MemoryPackWriter/ReaderOptionalState
---
Initialiseren van `MemoryPackWriter`/`MemoryPackReader` vereist OptionalState. Dit is een wrapper om `MemoryPackSerializerOptions`, en kan worden gemaakt via `MemoryPackWriterOptionalStatePool`.

```csharp
// bij dispose, wordt OptionalState teruggegeven aan de pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// voor Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Afhankelijkheid van target framework
---
MemoryPack biedt `netstandard2.1` en `net7.0`, maar deze zijn niet compatibel met elkaar. Als je bijvoorbeeld MemoryPackable types onder een `netstandard2.1` project gebruikt vanuit een `net7.0` project, krijg je een runtime-exceptie zoals:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Omdat net7.0 gebruikmaakt van statische abstracte leden (`Virtual static method`), die niet worden ondersteund door netstandard2.1, is dit het verwachte gedrag.

Een .NET 7-project mag de netstandard 2.1 dll niet gebruiken. Met andere woorden: als de applicatie een .NET 7-project is, moeten alle afhankelijkheden die MemoryPack gebruiken .NET 7 ondersteunen. Dus als een bibliotheekontwikkelaar afhankelijk is van MemoryPack, moet je een dual target framework configureren.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) is een code-first grpc-dotnet framework dat MessagePack gebruikt in plaats van protobuf. MagicOnion ondersteunt nu MemoryPack als serialisatielaag via het `MagicOnion.Serialization.MemoryPack`-pakket (preview). Zie details: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

Minimaal ondersteunde Unity-versie is `2022.3.12f1`.

Het `MemoryPack`-kernpakket is beschikbaar via nuget. Het is ook beschikbaar in Unity. Wil je ondersteuning voor Unity ingebouwde types, dan bieden we aanvullend de MemoryPack.Unity-extensie.

1. Installeer `MemoryPack` vanuit NuGet met [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Open het venster via NuGet -> Beheer NuGet Packages, zoek "MemoryPack" en druk op Installeren.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Krijg je een foutmelding over versieconflicten, schakel dan versievalidatie uit in Player Settings (Edit -> Projectinstellingen -> Player -> Scroll naar beneden en vouw "Other Settings" uit, schakel vervolgens "Assembly Version Validation" uit onder het kopje "Configuration").

2. Installeer het `MemoryPack.Unity`-pakket door te verwijzen naar de git-URL

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack gebruikt het *.*.* release tag-systeem, dus je kunt een versie opgeven als #1.0.0. Bijvoorbeeld: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Net als bij de .NET-versie wordt de code gegenereerd door een code generator (`MemoryPack.Generator.dll`). Implementatie zonder reflectie biedt ook de beste prestaties in IL2CPP.

Voor meer informatie over Unity en Source Generator, zie de [Unity documentatie](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator wordt ook officieel gebruikt door Unity door [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) en [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Met andere woorden, het is de standaard voor codegeneratie in de volgende generatie Unity.

Je kunt alle unmanaged types (zoals `Vector3`, `Rect`, etc...) en enkele klassen (`AnimationCurve`, `Gradient`, `RectOffset`) serialiseren. Wil je andere Unity-specifieke types serialiseren, zie het gedeelte [Externe types serialiseren](#serialize-external-types).

Qua prestaties in Unity is MemoryPack x3~x10 sneller dan JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Als gedeelde code Unity-types bevat (`Vector2`, etc...), biedt MemoryPack het `MemoryPack.UnityShims`-pakket via NuGet.

Het `MemoryPack.UnityShims`-pakket biedt shims voor Unity's standaard structs (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) en enkele klassen (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WAARSCHUWING]
> Momenteel gelden de volgende beperkingen voor gebruik in Unity


1. De Unity-versie ondersteunt geen CustomFormatter.
2. Als je .NET7 of nieuwer gebruikt, is het MemoryPack binaire formaat niet volledig compatibel met Unity.
    - Dit probleem doet zich voor bij waarde types waarvoor `[StructLayout(LayoutKind.Auto)]` expliciet is opgegeven. (De standaard voor struct is `LayoutKind.Sequencial`.) Voor zulke types kunnen binaries die in .NET zijn geserialiseerd, niet worden gedeserialiseerd in Unity. Evenzo kan een binary die in Unity is geserialiseerd, niet worden geserialiseerd aan de .NET-kant.
    - De getroffen types omvatten doorgaans de volgende types:
        - `DateTimeOffset`
        - `ValueTuple`
    - Momenteel is de eenvoudige oplossing om deze types niet te gebruiken.


Native AOT
---
Helaas veroorzaakt .NET 7 Native AOT een crash (`Generic virtual method pointer lookup failure`) bij gebruik van MemoryPack, vanwege een runtime bug. 
Dit wordt opgelost in .NET 8. Door ``Microsoft.DotNet.ILCompiler`` preview te gebruiken, wordt het probleem in .NET 7 opgelost. Zie [opmerking bij issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) voor instructies om dit in te stellen.

Binaire wireformaatspecificatie
---
Het type `T` dat wordt gedefinieerd in `Serialize<T>` en `Deserialize<T>` wordt het C#-schema genoemd. Het MemoryPack-formaat is geen zelfbeschrijvend formaat. Voor deserialisatie is het bijbehorende C#-schema vereist. Deze types bestaan als interne representaties van binaries, maar types kunnen niet worden bepaald zonder een C#-schema.

Endianness moet `Little Endian` zijn. De C#-implementatie houdt echter geen rekening met endianness en kan dus niet worden gebruikt op big-endian machines. Moderne computers zijn echter vrijwel altijd little-endian.

Er zijn acht types formaten.

* Unmanaged struct
* Object
* Version Tolerant Object
* Circulaire Referentie Object
* Tuple
* Collectie
* String
* Unie

### Unmanaged struct

Unmanaged struct is een C# struct die geen referentietypen bevat, vergelijkbare beperking als [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Serialiseren van struct layout zoals het is, inclusief padding.

### Object

`(byte memberCount, [values...])`

Object heeft 1 byte unsigned byte als aantal leden in de header. Aantal leden kan van `0` tot `249`, `255` geeft aan dat het object `null` is. Waarden slaan memorypack-waarde op voor het aantal leden.

### Version Tolerant Object

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Version Tolerant Object is vergelijkbaar met Object maar heeft de bytelengte van de waarden in de header. varint volgt deze specificatie, eerste sbyte is waarde of typeCode en de volgende X bytes zijn de waarde. 0 tot 127 = unsigned byte waarde, -1 tot -120 = signed byte waarde, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Circulaire Referentie Object

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Circulaire Referentie Object is vergelijkbaar met Version Tolerant Object maar als memberCount 250 is, is de volgende varint(unsigned-int32) de referenceId. Zo niet, dan wordt na byte-length-of-values, varint referenceId geschreven.

### Tuple

`(values...)`

Tuple is een collectie met vaste grootte van niet-nullable waarden. In .NET worden `KeyValuePair<TKey, TValue>` en `ValueTuple<T,...>` geserialiseerd als Tuple.

### Collectie

`(int length, [values...])`

Collectie heeft een 4-byte signed integer als datatelling in de header, `-1` betekent `null`. Waarden slaan memorypack-waarde op voor het aantal van de lengte.

### String

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String heeft twee vormen, UTF16 en UTF8. Als de eerste 4-byte signed integer `-1` is, betekent dit null. `0` betekent leeg. UTF16 is hetzelfde als collectie (serialiseren als `ReadOnlySpan<char>`, utf16-value's byte-telling is utf16-length * 2). Als het eerste signed integer <= `-2`, wordt de waarde gecodeerd in UTF8. utf8-byte-count is gecodeerd in complement, `~utf8-byte-count` om het aantal bytes te bepalen. De volgende signed integer is utf16-length, dit kan `-1` zijn wat onbekende lengte betekent. utf8-bytes slaan bytes op voor het aantal utf8-byte-count.

### Unie

`(byte tag, value)`  
`(250, ushort tag, value)`

Eerste unsigned byte is tag voor gediscrimineerde waarde type of vlag, `0` tot `249` betekent tag, `250` betekent dat de volgende unsigned short de tag is, `255` betekent dat de unie `null` is.

Licentie
---
Deze bibliotheek is gelicentieerd onder de MIT-licentie.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---