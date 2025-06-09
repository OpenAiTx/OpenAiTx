# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Sérialiseur binaire à performance extrême avec zéro encodage pour C# et Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Comparé à [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Mesuré sur une machine .NET 7 / Ryzen 9 5950X. Ces sérialiseurs possèdent la méthode `IBufferWriter<byte>`, sérialisé en utilisant `ArrayBufferWriter<byte>` et réutilisé pour éviter de mesurer la copie de tampon.

Pour les objets standards, MemoryPack est x10 plus rapide et x2 ~ x5 plus rapide que les autres sérialiseurs binaires. Pour un tableau de structures, MemoryPack est encore plus puissant, avec des vitesses jusqu'à x50 ~ x200 supérieures aux autres sérialiseurs.

MemoryPack est mon 4ème sérialiseur, auparavant j'ai créé des sérialiseurs bien connus, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). La raison de la rapidité de MemoryPack provient de son format binaire spécifique à C# et optimisé pour C#, ainsi qu'une implémentation parfaitement ajustée basée sur mon expérience passée. C'est aussi un tout nouveau design utilisant .NET 7 et C# 11 et le Source Generator incrémental (.NET Standard 2.1 (.NET 5, 6) et un support Unity également).

Les autres sérialiseurs effectuent de nombreuses opérations d'encodage comme l'encodage VarInt, tag, string, etc. Le format MemoryPack utilise un design zéro-encodage qui copie autant que possible la mémoire C#. Le zéro-encodage est similaire à FlatBuffers, mais il ne nécessite pas de type spécial, la cible de la sérialisation de MemoryPack est un POCO.

En dehors des performances, MemoryPack offre les fonctionnalités suivantes.

* Prise en charge des API I/O modernes (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Génération de code basée sur Source Generator native AOT friendly, sans Dynamic CodeGen (IL.Emit)
* API non génériques sans réflexion
* Désérialisation dans une instance existante
* Sérialisation polymorphe (Union)
* Support version-tolérant limité (rapide/défaut) et version-tolérant complet
* Sérialisation des références circulaires
* Sérialisation de flux basée sur PipeWriter/Reader
* Génération de code TypeScript et ASP.NET Core Formatter
* Support IL2CPP Unity (2021.3) via .NET Source Generator

Installation
---
Cette bibliothèque est distribuée via NuGet. Pour une performance optimale, il est recommandé d'utiliser `.NET 7`. L'exigence minimale est `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

De plus, un éditeur de code nécessite la prise en charge de Roslyn 4.3.1, par exemple Visual Studio 2022 version 17.3, .NET SDK 6.0.401. Pour plus de détails, voir le document [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Pour Unity, les exigences et le processus d'installation sont complètement différents. Voir la section [Unity](#unity) pour plus de détails.

Démarrage rapide
---
Définissez une structure ou une classe à sérialiser et annotez-la avec l'attribut `[MemoryPackable]` et le mot-clé `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

Le code de sérialisation est généré par la fonctionnalité source generator de C#, qui implémente l'interface `IMemoryPackable<T>`. Dans Visual Studio, vous pouvez vérifier le code généré en utilisant le raccourci `Ctrl+K, R` sur le nom de la classe et sélectionner `*.MemoryPackFormatter.g.cs`.

Appelez `MemoryPackSerializer.Serialize<T>/Deserialize<T>` pour sérialiser/désérialiser une instance d'objet.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

La méthode `Serialize` prend en charge le retour d'un type `byte[]` ainsi que la sérialisation vers `IBufferWriter<byte>` ou `Stream`. La méthode `Deserialize` prend en charge `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` et `Stream`. Il existe également des versions non génériques.

Types intégrés pris en charge
---
Ces types peuvent être sérialisés par défaut :

* Primitifs .NET (`byte`, `int`, `bool`, `char`, `double`, etc.)
* Types unmanaged (Tout `enum`, tout `struct` défini par l'utilisateur qui ne contient pas de types référence)
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
* Collections immuables (`ImmutableList<>`, etc.) et interfaces (`IImmutableList<>`, etc.)

Définir `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` peut annoter n'importe quelle `class`, `struct`, `record`, `record struct` et `interface`. Si un type est `struct` ou `record struct` qui ne contient pas de types référence ([Types unmanaged C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), aucune annotation supplémentaire (ignore, include, constructor, callbacks) n'est utilisée, la sérialisation/désérialisation s'effectue directement à partir de la mémoire.

Sinon, par défaut, `[MemoryPackable]` sérialise les propriétés ou champs d'instance publics. Vous pouvez utiliser `[MemoryPackIgnore]` pour exclure une cible de sérialisation, `[MemoryPackInclude]` promeut un membre privé en cible de sérialisation.

```csharp
[MemoryPackable]
public partial class Sample
{
    // ces types sont sérialisés par défaut
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // ces types ne sont pas sérialisés par défaut
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // utilisez [MemoryPackIgnore] pour exclure un membre public de la sérialisation
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // utilisez [MemoryPackInclude] pour promouvoir un membre privé en cible de sérialisation
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

Le générateur de code de `MemoryPack` ajoute des informations sur les membres sérialisés dans la section `<remarks />`. Cela peut être consulté en survolant le type avec Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Tous les membres doivent être sérialisables par MemoryPack, sinon le générateur de code émettra une erreur.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack possède 35 règles de diagnostic (`MEMPACK001` à `MEMPACK035`) pour garantir une définition confortable.

Si le type cible est défini pour la sérialisation MemoryPack de façon externe et enregistré, utilisez `[MemoryPackAllowSerialize]` pour rendre silencieux le diagnostic.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

L'ordre des membres est **important**, MemoryPack ne sérialise pas le nom du membre ni d'autres informations, il sérialise les champs dans l'ordre où ils sont déclarés. Si un type est hérité, la sérialisation s'effectue dans l'ordre parent → enfant. L'ordre des membres ne peut pas changer pour la désérialisation. Pour l'évolution du schéma, voir la section [Version tolerant](#version-tolerant).

L'ordre par défaut est séquentiel, mais vous pouvez choisir la disposition explicite avec `[MemoryPackable(SerializeLayout.Explicit)]` et `[MemoryPackOrder()]`.

```csharp
// sérialise Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Sélection du constructeur

MemoryPack prend en charge les constructeurs paramétrés et sans paramètre. La sélection du constructeur suit ces règles. (S'applique aux classes et structs).

* S'il y a `[MemoryPackConstructor]`, il est utilisé.
* S'il n'y a pas de constructeur explicite (y compris privé), le constructeur sans paramètre est utilisé.
* S'il n'y a qu'un constructeur sans paramètre/paramétré (y compris privé), il est utilisé.
* S'il y a plusieurs constructeurs, alors l'attribut `[MemoryPackConstructor]` doit être appliqué au constructeur désiré (le générateur ne choisira pas automatiquement), sinon le générateur émettra une erreur.
* Si on utilise un constructeur paramétré, tous les noms de paramètres doivent correspondre aux noms des membres correspondants (insensible à la casse).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Vous pouvez utiliser un constructeur paramétré - les noms des paramètres doivent correspondre aux membres correspondants (insensible à la casse)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// prend aussi en charge le constructeur principal record
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
// S'il existe plusieurs constructeurs, alors [MemoryPackConstructor] doit être utilisé
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Rappels de sérialisation

Lors de la sérialisation/désérialisation, MemoryPack peut invoquer un événement avant/après à l'aide des attributs `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Il est possible d'annoter des méthodes statiques ou d'instance (non statiques), et des méthodes publiques ou privées.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // l'ordre d'appel des méthodes est statique -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // permet également une méthode privée
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

    // Remarque : méthode d'instance avec MemoryPackOnDeserializing, non appelée si l'instance n'est pas passée par `ref`
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

Les rappels permettent une méthode sans paramètre et une méthode `ref reader/writer, ref T value`. Par exemple, les rappels ref peuvent écrire/lire un en-tête personnalisé avant le processus de sérialisation.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, utiliser where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // émettre un GUID dans l'en-tête.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // lire l'en-tête personnalisé avant la désérialisation
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Si vous définissez une valeur pour `ref value`, vous pouvez changer la valeur utilisée pour la sérialisation/désérialisation. Par exemple, instancier depuis un ServiceProvider.

```csharp
// avant d'utiliser ce formateur, définir ServiceProvider
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

Définir une collection personnalisée
---
Par défaut, le type annoté `[MemoryPackObject]` tente de sérialiser ses membres. Cependant, si un type est une collection (`ICollection<>`, `ISet<>`, `IDictionary<,>`), utilisez `GenerateType.Collection` pour le sérialiser correctement.

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

Constructeur statique
---
Une classe MemoryPackable ne peut pas définir de constructeur statique car la classe partielle générée l'utilise. À la place, vous pouvez définir un `static partial void StaticConstructor()` pour obtenir le même résultat.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polymorphisme (Union)
---
MemoryPack prend en charge la sérialisation des objets d'interface et de classe abstraite pour la sérialisation polymorphique. Dans MemoryPack, cette fonctionnalité est appelée Union. Seules les interfaces et les classes abstraites peuvent être annotées avec les attributs `[MemoryPackUnion]`. Des tags d'union uniques sont nécessaires.

```csharp
// Annoter [MemoryPackable] et les types d'héritage avec [MemoryPackUnion]
// Union prend également en charge les classes abstraites
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

// Sérialiser en tant que type interface.
var bin = MemoryPackSerializer.Serialize(data);

// Désérialiser en tant que type interface.
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

Le `tag` permet des valeurs de `0` à `65535`, il est particulièrement efficace pour des valeurs inférieures à `250`.
```
Si une interface et des types dérivés se trouvent dans des assemblages différents, vous pouvez utiliser `MemoryPackUnionFormatterAttribute` à la place. Les formateurs sont générés de manière à être automatiquement enregistrés via `ModuleInitializer` en C# 9.0 et versions ultérieures.

> Notez que `ModuleInitializer` n'est pas pris en charge dans Unity, il faut donc enregistrer manuellement le formateur. Pour enregistrer votre union formatter, appelez manuellement `{nom de votre union formatter}Initializer.RegisterFormatter()` au démarrage. Par exemple, `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB, définition en dehors du type cible
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Une union peut être assemblée en code via `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

API de sérialisation
---
`Serialize` dispose de trois surcharges.

```csharp
// Une API non générique est également disponible, dans cette version le premier argument est Type et value est object ?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Pour les performances, l’API recommandée utilise `BufferWriter`. Cela sérialise directement dans le tampon. Cela peut être appliqué à `PipeWriter` dans `System.IO.Pipelines`, `BodyWriter` dans ASP .NET Core, etc.

Si un `byte[]` est nécessaire (par exemple `RedisValue` dans [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), l’API qui retourne un `byte[]` est simple et presque aussi rapide.

Notez que `SerializeAsync` pour `Stream` est asynchrone uniquement pour le Flush ; il sérialise tout d’un coup dans le tampon interne de MemoryPack puis écrit en utilisant `WriteAsync`. Par conséquent, la surcharge `BufferWriter`, qui sépare et contrôle le tampon et le flush, est préférable.

Si vous souhaitez effectuer une écriture en streaming complète, consultez la section [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` configure si les chaînes sont sérialisées en UTF16 ou UTF8. Cela peut être configuré en passant `MemoryPackSerializerOptions.Utf8` pour l’encodage UTF8, `MemoryPackSerializerOptions.Utf16` pour l’encodage UTF16, ou `MemoryPackSerializerOptions.Default` qui utilise UTF8 par défaut. Passer null ou utiliser la valeur par défaut du paramètre aboutit à un encodage UTF8.

Puisque la représentation interne des chaînes en C# est UTF16, UTF16 est plus performant. Cependant, la charge utile tend à être plus grande ; en UTF8, une chaîne ASCII fait un octet, alors qu’en UTF16 elle en fait deux. Comme la différence de taille de cette charge utile est grande, UTF8 est défini par défaut.

Si les données sont non ASCII (par exemple le japonais, qui peut dépasser 3 octets, et pour lequel UTF8 est plus grand), ou si vous devez les compresser séparément, UTF16 peut donner de meilleurs résultats.

Bien qu’on puisse choisir UTF8 ou UTF16 lors de la sérialisation, il n’est pas nécessaire de le spécifier lors de la désérialisation. Il sera détecté et désérialisé automatiquement.

Vous pouvez également obtenir/modifier `IServiceProvider? ServiceProvider { get; init; }` depuis les options. C’est utile pour obtenir un objet DI (tel que `ILogger<T>`) lors du processus de sérialisation (`MemoryPackReader/MemoryPackWriter` possède la propriété .Options).

API de désérialisation
---
`Deserialize` dispose de surcharges pour `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` et supporte `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

La surcharge `ref` réécrit une instance existante, pour plus de détails voir la section [Overwrite](#overwrite).

`DeserializeAsync(Stream)` n’est pas une opération de lecture en streaming complète, il lit d’abord dans le pool interne de MemoryPack jusqu’à la fin du flux, puis désérialise.

Si vous souhaitez effectuer une lecture en streaming complète, consultez la section [Streaming Serialization](#streaming-serialization).

Overwrite (Écrasement)
---
Pour réduire les allocations, MemoryPack prend en charge la désérialisation dans une instance existante, en l’écrasant. Cela peut être utilisé avec la surcharge `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// écrase les données dans l’instance existante.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack essaiera d’écraser autant que possible, mais si les conditions suivantes ne sont pas remplies, il créera une nouvelle instance (comme lors d’une désérialisation normale).

* la valeur ref (y compris les membres dans le graphe d’objets) est null, création d’une nouvelle instance
* seul le constructeur sans paramètre est autorisé, si un constructeur avec paramètres est utilisé, une nouvelle instance est créée
* si la valeur est `T[]`, on réutilise uniquement si la longueur est identique, sinon on crée une nouvelle instance
* si la valeur est une collection disposant de la méthode `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) on appelle Clear() et on la réutilise, sinon on crée une nouvelle instance

Tolérance de version
---
Par défaut (`GenerateType.Object`), MemoryPack prend en charge une évolution de schéma limitée.

* une struct non managée ne peut plus être modifiée
* des membres peuvent être ajoutés, mais ne peuvent pas être supprimés
* on peut changer le nom d’un membre
* on ne peut pas changer l’ordre des membres
* on ne peut pas changer le type d’un membre

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Ajout accepté.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Suppression refusée.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Changement d’ordre refusé.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

En pratique, stocker d’anciennes données (dans un fichier, dans redis, etc...) et les lire avec un nouveau schéma fonctionne toujours. Dans le cas d’un RPC, le schéma existe à la fois côté client et côté serveur, le client doit être mis à jour avant le serveur. Un client à jour peut se connecter à un ancien serveur, mais un ancien client ne peut pas se connecter à un serveur mis à jour.

Par défaut, lorsque d’anciennes données sont lues dans un nouveau schéma, tout membre absent côté données est initialisé avec la valeur littérale `default`.
Si vous voulez éviter cela et utiliser la valeur initiale du champ/propriété, vous pouvez utiliser `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < si l’ancienne donnée est manquante, on met `111`.
    
    public int Prop3 { get; set; } = 222; // < si l’ancienne donnée est manquante, on met `default`.
}
```

 `[SuppressDefaultInitialization]` a les limitations suivantes :
- Ne peut pas être utilisé avec readonly, init-only, et le modificateur required.

La section suivante [Serialization info](#serialization-info) montre comment vérifier les changements de schéma, par exemple par CI, pour éviter les accidents.

Lors de l’utilisation de `GenerateType.VersionTolerant`, il prend en charge la tolérance de version complète.

* une struct non managée ne peut plus être modifiée
* tous les membres doivent avoir `[MemoryPackOrder]` explicitement (sauf si annoté `SerializeLayout.Sequential`)
* des membres peuvent être ajoutés ou supprimés, mais l’ordre ne peut pas être réutilisé (on peut utiliser un ordre manquant)
* on peut changer le nom d’un membre
* on ne peut pas changer l’ordre des membres
* on ne peut pas changer le type d’un membre

```csharp
// Ok pour sérialiser/désérialiser dans les deux sens 
// VersionTolerantObject1 -> VersionTolerantObject2 et 
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

// supprimé
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// ajouté
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Si vous définissez explicitement SerializeLayout.Sequential, cela permet de trier automatiquement.
// Mais il n'est pas possible de supprimer un membre pour la tolérance de version.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` est plus lent que `GenerateType.Object` lors de la sérialisation. De plus, la taille de la charge utile sera légèrement plus grande.

Informations de sérialisation
----
Vous pouvez vérifier dans l'IntelliSense du type quels membres sont sérialisés. Il existe une option pour écrire ces informations dans un fichier au moment de la compilation. Définissez `MemoryPackGenerator_SerializationInfoOutputDirectory` comme suit.

```xml
<!-- exporter les informations de sérialisation memorypack dans un dossier -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

Les informations suivantes sont écrites dans le fichier.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Si le type est non managé, `unmanaged` est affiché avant le nom du type.

```txt
unmanaged FooStruct
---
int x
int y
```

En vérifiant les différences dans ce fichier, les changements de schéma dangereux peuvent être évités. Par exemple, vous pouvez utiliser l'intégration continue (CI) pour détecter les règles suivantes :

* modification d'un type non managé
* changement de l'ordre des membres
* suppression d'un membre

Référence circulaire
---
MemoryPack prend également en charge les références circulaires. Cela permet de sérialiser les objets arborescents tels quels.

```csharp
// pour activer les références circulaires, utilisez GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Par exemple, le code [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) devient comme suit.

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

`GenerateType.CircularReference` possède les mêmes caractéristiques que la tolérance de version. Cependant, comme contrainte supplémentaire, seuls les constructeurs sans paramètre sont autorisés. De plus, le suivi des références d'objet est effectué uniquement pour les objets marqués avec `GenerateType.CircularReference`. Si vous souhaitez suivre tout autre objet, encapsulez-le.

CustomFormatter
---
Si vous implémentez `MemoryPackCustomFormatterAttribute<T>` ou `MemoryPackCustomFormatterAttribute<TFormatter, T>` (plus performant, mais plus complexe), vous pouvez configurer l'utilisation d'un formateur personnalisé pour un membre de MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack fournit les attributs de formatage suivants : `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // sérialise ce membre en chaîne UTF16, plus performant que UTF8 mais en ASCII la taille est plus grande (mais parfois plus petite pour les caractères non ASCII).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Lors de la désérialisation, le dictionnaire est initialisé avec StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // À la désérialisation, toutes les chaînes sont internées (voir : String.Intern). Si des valeurs similaires se répètent, cela économise de la mémoire.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Pour configurer l'égalité du comparateur d'un ensemble/dictionnaire, tous les formateurs intégrés possèdent une surcharge de constructeur avec comparateur. Vous pouvez facilement créer des formateurs personnalisés avec comparateur d'égalité.

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

`BitPackFormatter` compresse uniquement les types `bool[]`. `bool[]` est normalement sérialisé sous forme de 1 octet par valeur booléenne, cependant `BitPackFormatter` sérialise `bool[]` comme un `BitArray` en stockant chaque booléen sur 1 bit. Avec `BitPackFormatter`, 8 booléens deviennent 1 octet là où ils auraient normalement occupé 8 octets, soit une taille 8 fois plus petite.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` est destiné aux `byte[]`, par exemple vous pouvez compresser une grande charge utile avec Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` s'applique aux `string`, pour sérialiser une chaîne compressée (UTF16) avec Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` est destiné à tout type, les données sérialisées sont compressées par Brotli. Si un type est `byte[]` ou `string`, vous devriez utiliser `BrotliFormatter` ou `BrotliStringFormatter` pour les performances.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Pooling de tableau lors de la désérialisation
---
Pour désérialiser un grand tableau (n'importe quel `T`), MemoryPack offre plusieurs méthodes de pooling efficaces. La méthode la plus efficace est d'utiliser la fonction [#Overwrite](#overwrite). En particulier, `List<T>` est toujours réutilisé.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> est réutilisée, aucune allocation lors de la désérialisation.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// pour une opération efficace, vous pouvez obtenir un Span<T> via CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Une méthode pratique consiste à désérialiser vers un ArrayPool au moment de la désérialisation. MemoryPack fournit `MemoryPoolFormatter<T>` et `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Vous devez écrire le code de retour vous-même, voici un extrait.

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
    // faites ce que vous voulez...
}   // retour vers ArrayPool
```

Performances
---
Voir mon article de blog [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Taille du payload et compression
---
La taille du payload dépend de la valeur cible ; contrairement au JSON, il n'y a pas de clés et il s'agit d'un format binaire, donc la taille du payload est probablement plus petite que le JSON.

Pour ceux utilisant un encodage varint, comme MessagePack et Protobuf, MemoryPack a tendance à être plus volumineux si les int sont beaucoup utilisés (dans MemoryPack, les int font toujours 4 octets à cause de l'encodage à taille fixe, alors que MessagePack fait 1~5 octets).

float et double font 4 octets et 8 octets dans MemoryPack, mais 5 octets et 9 octets dans MessagePack. Ainsi, MemoryPack est plus petit, par exemple, pour des tableaux de Vector3 (float, float, float).

String est en UTF8 par défaut, ce qui est similaire aux autres sérialiseurs, mais si l'option UTF16 est choisie, la nature sera différente.

Dans tous les cas, si la taille du payload est importante, la compression doit être envisagée. LZ4, ZStandard et Brotli sont recommandés.

### Compression

MemoryPack fournit un helper efficace pour la compression [Brotli](https://github.com/google/brotli) via [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) et [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). Les `BrotliCompressor` et `BrotliDecompressor` de MemoryPack offrent une compression/décompression optimisée pour le comportement interne de MemoryPack.

```csharp
using MemoryPack.Compression;

// Compression (require using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Obtenir le tableau d'octets compressé
var compressedBytes = compressor.ToArray();

// Ou écrire dans un autre IBufferWriter<byte> (par exemple PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Décompression (require using)
using var decompressor = new BrotliDecompressor();

// Obtenir un ReadOnlySequence<byte> décompressé à partir d'un ReadOnlySpan<byte> ou ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

`BrotliCompressor` et `BrotliDecompressor` sont tous deux des struct, ils n'allouent pas de mémoire sur le tas. Les deux stockent les données compressées ou décompressées dans un pool de mémoire interne pour la sérialisation/désérialisation. Il est donc nécessaire de libérer le pooling de mémoire, n'oubliez pas d'utiliser `using`.

Le niveau de compression est très important. La valeur par défaut est quality-1 (CompressionLevel.Fastest), ce qui est différent de la valeur par défaut de .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) sera proche de la vitesse de [LZ4](https://github.com/lz4/lz4), mais 4 est beaucoup plus lent. Cela a été jugé critique dans le scénario d'utilisation d'un sérialiseur. Faites attention lors de l'utilisation du `BrotliStream` standard (quality-4 est la valeur par défaut). Dans tous les cas, les vitesses et tailles de compression/décompression donneront des résultats très différents selon les données. Préparez les données à traiter par votre application et testez vous-même.

Notez qu'il existe un ralentissement de plusieurs fois entre MemoryPack non compressé et la compression Brotli ajoutée.

Brotli est également supporté dans un formatter personnalisé. `BrotliFormatter` peut compresser un membre spécifique.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Sérialiser des types externes
---
Si vous souhaitez sérialiser des types externes, vous pouvez créer un formatter personnalisé et l'enregistrer dans le provider, voir [Formatter/Provider API](#formatterprovider-api) pour plus de détails. Cependant, créer un formatter personnalisé est difficile. Par conséquent, nous recommandons de créer un type wrapper. Par exemple, si vous souhaitez sérialiser un type externe appelé `AnimationCurve`.

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

Le type à wrapper est public, mais exclu de la sérialisation (`MemoryPackIgnore`). Les propriétés que vous souhaitez sérialiser sont privées, mais incluses (`MemoryPackInclude`). Deux types de constructeurs doivent aussi être préparés. Le constructeur utilisé par le sérialiseur doit être privé.

En l'état, il faut wrapper à chaque fois, ce qui est peu pratique. De plus, un wrapper struct ne peut pas représenter null. Créons donc un formatter personnalisé.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity ne supporte pas scoped et TBufferWriter donc modifiez la signature en `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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

Enfin, enregistrez le formateur au démarrage.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Remarque : AnimationCurve de Unity est sérialisable par défaut, il n’est donc pas nécessaire d’utiliser ce formateur personnalisé pour AnimationCurve.

Packages
---
MemoryPack propose les packages suivants.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` est la bibliothèque principale, elle offre un support complet pour la sérialisation et la désérialisation haute performance des objets binaires. Elle dépend de `MemoryPack.Core` pour les bibliothèques de base et de `MemoryPack.Generator` pour la génération de code. `MemoryPack.Streaming` ajoute des extensions supplémentaires pour la [sérialisation en streaming](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` ajoute des formateurs d’entrée/sortie pour ASP.NET Core. `MemoryPack.UnityShims` ajoute des types et formateurs shim pour partager des types entre .NET et Unity.

TypeScript et Formateur ASP.NET Core
---
MemoryPack prend en charge la génération de code TypeScript. Il génère une classe et le code de sérialisation à partir du C#, en d’autres termes, vous pouvez partager des types avec le navigateur sans utiliser OpenAPI, proto, etc.

La génération de code est intégrée au Source Generator, les options suivantes (`MemoryPackGenerator_TypeScriptOutputDirectory`) définissent le répertoire de sortie pour le code TypeScript. Le code d’exécution est généré en même temps, donc aucune dépendance supplémentaire n’est requise.

```xml
<!-- exporter le code TypeScript de memorypack dans un répertoire -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Un type MemoryPackable C# doit être annoté avec `[GenerateTypeScript]`.

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

Le code d’exécution et le type TypeScript seront générés dans le répertoire cible.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

Le code généré est le suivant, avec des champs simples et des méthodes statiques pour serialize/serializeArray et deserialize/deserializeArray.

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

Vous pouvez utiliser ce type comme suit.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// sérialiser en Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// désérialiser depuis ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

Le package `MemoryPack.AspNetCoreMvcFormatter` ajoute des formateurs d’entrée et de sortie `MemoryPack` pour ASP.NET Core MVC. Vous pouvez ajouter `MemoryPackInputFormatter`, `MemoryPackOutputFormatter` à ASP.NET Core MVC avec le code suivant.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Si checkContentType: true alors peut sortir plusieurs formats (JSON/MemoryPack, etc...). Par défaut, c’est false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Si vous appelez depuis HttpClient, vous pouvez définir `application/x-memorypack` dans l’en-tête du contenu.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Mappage des types TypeScript

Il existe quelques restrictions sur les types pouvant être générés. Parmi les types primitifs, `char` et `decimal` ne sont pas pris en charge. De plus, le type OpenGenerics ne peut pas être utilisé.

|  C#  |  TypeScript  | Description |
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
| `Guid` |  `string`  | En TypeScript, représenté comme une chaîne mais sérialisé/désérialisé en binaire 16 octets
| `DateTime` | `Date` | DateTimeKind sera ignoré
| `enum` | `const enum` | Le type sous-jacent `long` et `ulong` n'est pas supporté
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Supporte tous les types implémentant `ICollection<T>` comme `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Supporte tous les types implémentant `ISet<T>` comme `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Supporte tous les types implémentant `IDictionary<K,V>` comme `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Supporte uniquement les classes
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` ne peut être appliqué qu'aux classes et n'est actuellement pas supporté pour les structs.

### Configurer l'extension d'importation du fichier et la casse des noms de membres

Par défaut, MemoryPack génère l'extension de fichier en `.js` comme `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Si vous souhaitez changer pour une autre extension ou vide, utilisez `MemoryPackGenerator_TypeScriptImportExtension` pour la configurer.
De plus, le nom des membres est automatiquement converti en camelCase. Si vous souhaitez utiliser le nom d'origine, définissez `MemoryPackGenerator_TypeScriptConvertPropertyName` à `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- permet vide -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- valeur par défaut : true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- valeur par défaut : false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` permet de refléter les annotations nullable C# dans le code TypeScript. Par défaut, la valeur est false, rendant tout nullable.

Sérialisation en streaming
---
`MemoryPack.Streaming` fournit `MemoryPackStreamingSerializer`, qui ajoute un support supplémentaire pour la sérialisation et la désérialisation de collections avec des flux.

```csharp
public static class MemoryPackStreamingSerializer
{
    public static async ValueTask SerializeAsync<T>(PipeWriter pipeWriter, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async ValueTask SerializeAsync<T>(Stream stream, int count, IEnumerable<T> source, int flushRate = 4096, CancellationToken cancellationToken = default)
    public static async IAsyncEnumerable<T?> DeserializeAsync<T>(PipeReader pipeReader, int bufferAtLeast = 4096, int readMinimumSize = 8192, [EnumeratorCancellation] CancellationToken cancellationToken = default)
    public static IAsyncEnumerable<T?> DeserializeAsync<T>(Stream stream, int bufferAtLeast = 4096, int readMinimumSize = 8192, CancellationToken cancellationToken = default)
}
```

API Formatter/Provider
---
Si vous souhaitez implémenter manuellement un formateur, héritez de `MemoryPackFormatter<T>` et surchargez les méthodes `Serialize` et `Deserialize`.

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

        // utiliser la méthode writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // utiliser la méthode reader.
    }
}
```
Le formateur créé est enregistré avec `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Remarque : les `unmanged struct` (qui ne contiennent pas de types référence) ne peuvent pas utiliser de formateur personnalisé, ils sont toujours sérialisés via le layout mémoire natif.

MemoryPackWriter/ReaderOptionalState
---
L'initialisation de `MemoryPackWriter`/`MemoryPackReader` nécessite OptionalState. Il s'agit d'un wrapper de `MemoryPackSerializerOptions`, qui peut être créé à partir de `MemoryPackWriterOptionalStatePool`.

```csharp
// lors de la suppression, OptionalState sera retourné au pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// pour Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Dépendance au framework cible
---
MemoryPack fournit `netstandard2.1` et `net7.0` mais les deux ne sont pas compatibles. Par exemple, les types MemoryPackable sous un projet `netstandard2.1` utilisés depuis un projet `net7.0` génèrent une exception d'exécution telle que

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Comme net7.0 utilise des membres statiques abstraits (`Virtual static method`), ce qui n'est pas supporté par netstandard2.1, ce comportement est voulu.

Un projet .NET 7 ne doit pas utiliser la dll netstandard 2.1. En d'autres termes, si l'application est un projet .NET 7, toutes les dépendances utilisant MemoryPack doivent supporter .NET 7. Donc, si un développeur de bibliothèque dépend de MemoryPack, vous devez configurer le framework cible double.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) est un framework grpc-dotnet code-first utilisant MessagePack à la place de protobuf. MagicOnion supporte désormais MemoryPack comme couche de sérialisation via le package `MagicOnion.Serialization.MemoryPack` (preview). Voir détails : [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

La version minimale supportée de Unity est `2022.3.12f1`.

Le package principal `MemoryPack` est fourni par nuget. Il est également disponible dans Unity. Si vous souhaitez obtenir la prise en charge des types intégrés Unity, nous proposons également l'extension MemoryPack.Unity.

1. Installer `MemoryPack` depuis NuGet en utilisant [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Ouvrez la fenêtre NuGet -> Manage NuGet Packages, recherchez "MemoryPack" et cliquez sur Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Si vous rencontrez une erreur de conflit de versions, veuillez désactiver la validation de version dans les paramètres du Player (Edit -> Project Settings -> Player -> Faites défiler et développez "Other Settings" puis décochez "Assembly Version Validation" dans la section "Configuration").

2. Installez le package `MemoryPack.Unity` en référencant l'URL git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack utilise le tag de release *.*.*, vous pouvez donc spécifier une version comme #1.0.0. Par exemple : `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Comme pour la version .NET, le code est généré par un générateur de code (`MemoryPack.Generator.dll`). L'implémentation sans réflexion offre également les meilleures performances en IL2CPP.

Pour plus d'informations sur Unity et le générateur de source, veuillez consulter la [documentation Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Le générateur de source est également utilisé officiellement par Unity via [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) et [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Autrement dit, c'est le standard de la génération de code dans la prochaine génération de Unity.

Vous pouvez sérialiser tous les types unmanaged (tels que `Vector3`, `Rect`, etc...) et certaines classes (`AnimationCurve`, `Gradient`, `RectOffset`). Si vous souhaitez sérialiser d'autres types spécifiques à Unity, voir la section [Sérialiser des types externes](#serialize-external-types).

En termes de performances Unity, MemoryPack est 3 à 10 fois plus rapide que JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Si le code partagé utilise des types Unity (`Vector2`, etc...), MemoryPack fournit le package `MemoryPack.UnityShims` sur NuGet.

Le package `MemoryPack.UnityShims` fournit des shims pour les structs standards de Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) et certaines classes (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Actuellement, les limitations suivantes existent pour une utilisation dans Unity


1. La version Unity ne supporte pas CustomFormatter.
2. Si vous utilisez .NET7 ou supérieur, le format binaire MemoryPack n'est pas entièrement compatible avec Unity.
    - Ce problème survient avec les types valeur ayant explicitement `[StructLayout(LayoutKind.Auto)]` spécifié. (La valeur par défaut pour struct est `LayoutKind.Sequencil`). Pour ces types, les binaires sérialisés en .NET ne peuvent pas être désérialisés dans Unity. De même, un binaire sérialisé dans Unity ne peut pas être utilisé côté .NET.
    - Les types concernés comprennent généralement les types suivants :
        - `DateTimeOffset`
        - `ValueTuple`
    - Actuellement, la solution la plus simple est de ne pas utiliser ces types.


Native AOT
---
Malheureusement, .NET 7 Native AOT provoque un crash (`Generic virtual method pointer lookup failure`) lors de l'utilisation de MemoryPack en raison d'un bug du runtime. Il 
sera corrigé dans .NET 8. Utiliser la version preview de ``Microsoft.DotNet.ILCompiler`` le corrigera en .NET 7. Veuillez consulter [le commentaire de l'issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) pour savoir comment le configurer.

Spécification du format binaire filaire
---
Le type de `T` défini dans `Serialize<T>` et `Deserialize<T>` est appelé schéma C#. Le format MemoryPack n'est pas auto-descriptif. La désérialisation nécessite le schéma C# correspondant. Ces types existent comme représentations internes des binaires, mais les types ne peuvent pas être déterminés sans schéma C#.

L'endianness doit être `Little Endian`. Cependant, l'implémentation de référence C# ne se soucie pas de l'endianness et ne peut donc pas être utilisée sur une machine big-endian. Cependant, les ordinateurs modernes sont généralement little-endian.

Il existe huit types de format.

* Struct non managée
* Objet
* Objet tolérant à la version
* Objet à référence circulaire
* Tuple
* Collection
* Chaîne de caractères
* Union

### struct non managée

Une struct non managée est une struct C# qui ne contient pas de types référence, contrainte similaire à [C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). La sérialisation de la struct se fait selon sa disposition en mémoire, incluant le padding.

### Objet

`(byte memberCount, [values...])`

Un objet possède un octet non signé (1 byte) comme nombre de membres dans l’en-tête. Le nombre de membres va de `0` à `249`, `255` indique que l’objet est `null`. Les valeurs contiennent la valeur memorypack pour le nombre de membres.

### Objet tolérant aux versions

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Un objet tolérant aux versions est similaire à un objet mais inclut la longueur des valeurs en octets dans l’en-tête. La varint suit ces spécifications : le premier sbyte est la valeur ou typeCode et les X bytes suivants sont la valeur. 0 à 127 = valeur en octet non signé, -1 à -120 = valeur en octet signé, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Objet à référence circulaire

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Un objet à référence circulaire est similaire à un objet tolérant aux versions, mais si memberCount est 250, la varint suivante (uint32 non signé) est referenceId. Sinon, après byte-length-of-values, varint referenceId est écrite.

### Tuple

`(values...)`

Un tuple est une collection de valeurs de taille fixe et non nullable. En .NET, `KeyValuePair<TKey, TValue>` et `ValueTuple<T,...>` sont sérialisés en tant que Tuple.

### Collection

`(int length, [values...])`

Une collection possède un entier signé 4 octets comme nombre d’éléments dans l’en-tête, `-1` indique `null`. Les valeurs contiennent la valeur memorypack pour le nombre de length.

### Chaîne de caractères

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

Une chaîne de caractères a deux formes, UTF16 et UTF8. Si le premier entier signé 4 octets est `-1`, cela indique null. `0` indique vide. UTF16 est identique à une collection (sérialisé comme `ReadOnlySpan<char>`, le nombre d’octets de utf16-value est utf16-length * 2). Si le premier entier signé est inférieur ou égal à `-2`, la valeur est encodée en UTF8. utf8-byte-count est encodé en complément, `~utf8-byte-count` pour récupérer le nombre d’octets. L’entier signé suivant est utf16-length, il peut être `-1` pour indiquer une longueur inconnue. utf8-bytes contient les octets pour le nombre de utf8-byte-count.

### Union

`(byte tag, value)`  
`(250, ushort tag, value)`

Le premier octet non signé est le tag pour le type de valeur discriminée ou le flag, `0` à `249` représentent le tag, `250` indique que l’ushort suivant est le tag, `255` indique que l’union est `null`.

License
---
Cette bibliothèque est sous licence MIT.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---