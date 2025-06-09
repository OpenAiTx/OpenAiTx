# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Serializador binario de alto rendimiento y codificación cero para C# y Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Comparado con [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Medido en máquina .NET 7 / Ryzen 9 5950X. Estos serializadores tienen el método `IBufferWriter<byte>`, serializados usando `ArrayBufferWriter<byte>` y reutilizados para evitar medir la copia del búfer.

Para objetos estándar, MemoryPack es x10 veces más rápido y x2 ~ x5 veces más rápido que otros serializadores binarios. Para arrays de struct, MemoryPack es aún más potente, con velocidades hasta x50 ~ x200 superiores a otros serializadores.

MemoryPack es mi cuarto serializador, previamente he creado serializadores conocidos, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). La razón de la velocidad de MemoryPack es su formato binario específico y optimizado para C#, y una implementación muy afinada basada en mi experiencia previa. Además, es un diseño completamente nuevo que utiliza .NET 7 y C# 11 y el Incremental Source Generator (también hay soporte para .NET Standard 2.1 (.NET 5, 6) y Unity).

Otros serializadores realizan muchas operaciones de codificación como codificación VarInt, etiquetas, cadenas, etc. El formato de MemoryPack utiliza un diseño de codificación cero que copia tanta memoria de C# como sea posible. La codificación cero es similar a FlatBuffers, pero no necesita un tipo especial, el objetivo de serialización de MemoryPack es POCO.

Además del rendimiento, MemoryPack tiene estas características.

* Soporte para APIs modernas de I/O (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Generación de código basada en Source Generator nativo compatible con AOT, sin Dynamic CodeGen (IL.Emit)
* APIs sin reflexión y no genéricas
* Deserialización en una instancia existente
* Serialización polimórfica (Union)
* Soporte limitado a la tolerancia de versión (rápido/predeterminado) y soporte completo de tolerancia de versión
* Serialización de referencias circulares
* Serialización en streaming basada en PipeWriter/Reader
* Generación de código TypeScript y formateador para ASP.NET Core
* Soporte para Unity (2021.3) IL2CPP mediante .NET Source Generator

Instalación
---
Esta biblioteca se distribuye a través de NuGet. Para el mejor rendimiento, se recomienda usar `.NET 7`. El requisito mínimo es `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Además, el editor de código requiere soporte para Roslyn 4.3.1, por ejemplo Visual Studio 2022 versión 17.3, .NET SDK 6.0.401. Para más detalles, consulte el documento de [Soporte de versiones de Roslyn](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Para Unity, los requisitos y el proceso de instalación son completamente diferentes. Consulte la sección [Unity](#unity) para más detalles.

Inicio rápido
---
Defina una struct o clase para serializar y anótela con el atributo `[MemoryPackable]` y la palabra clave `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

El código de serialización se genera mediante la función de source generator de C#, que implementa la interfaz `IMemoryPackable<T>`. En Visual Studio puede revisar el código generado usando el atajo `Ctrl+K, R` sobre el nombre de la clase y seleccionar `*.MemoryPackFormatter.g.cs`.

Llame a `MemoryPackSerializer.Serialize<T>/Deserialize<T>` para serializar/deserializar una instancia de objeto.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

El método `Serialize` soporta un tipo de retorno `byte[]` así como puede serializar a `IBufferWriter<byte>` o `Stream`. El método `Deserialize` soporta `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` y `Stream`. Y también existen versiones no genéricas.

Tipos soportados integrados
---
Estos tipos pueden ser serializados por defecto:

* Primitivos de .NET (`byte`, `int`, `bool`, `char`, `double`, etc.)
* Tipos unmanaged (Cualquier `enum`, cualquier `struct` definido por el usuario que no contenga tipos de referencia)
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
* Colecciones inmutables (`ImmutableList<>`, etc.) e interfaces (`IImmutableList<>`, etc.)

Definir `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` puede anotarse en cualquier `class`, `struct`, `record`, `record struct` e `interface`. Si el tipo es un `struct` o `record struct` que no contiene tipos de referencia ([C# Unmanaged types](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), cualquier anotación adicional (ignore, include, constructor, callbacks) no se utiliza, ya que se serializa/deserializa directamente desde la memoria.

De lo contrario, por defecto, `[MemoryPackable]` serializa las propiedades o campos de instancia públicos. Puede usar `[MemoryPackIgnore]` para eliminar un objetivo de serialización, `[MemoryPackInclude]` promociona un miembro privado como objetivo de serialización.

```csharp
[MemoryPackable]
public partial class Sample
{
    // estos tipos se serializan por defecto
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // estos tipos no se serializan por defecto
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // use [MemoryPackIgnore] para eliminar un miembro público de la serialización
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // use [MemoryPackInclude] para promocionar un miembro privado como objetivo de serialización
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

El generador de código de `MemoryPack` agrega información sobre qué miembros se serializan en la sección `<remarks />`. Esto puede verse al pasar el cursor sobre el tipo con Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Todos los miembros deben ser serializables por MemoryPack, si no lo son el generador de código emitirá un error.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

MemoryPack tiene 35 reglas de diagnóstico (`MEMPACK001` a `MEMPACK035`) para definir cómodamente.

Si el tipo de destino tiene definida la serialización de MemoryPack externamente y está registrado, use `[MemoryPackAllowSerialize]` para silenciar los diagnósticos.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

El orden de los miembros es **importante**, MemoryPack no serializa el nombre del miembro ni otra información, en su lugar serializa los campos en el orden en que están declarados. Si un tipo es heredado, la serialización se realiza en el orden de padre → hijo. El orden de los miembros no puede cambiar para la deserialización. Para la evolución del esquema, consulte la sección [Version tolerant](#version-tolerant).

El orden predeterminado es secuencial, pero puede elegir el layout explícito con `[MemoryPackable(SerializeLayout.Explicit)]` y `[MemoryPackOrder()]`.

```csharp
// serializa Prop0 -> Prop1
[MemoryPackable(SerializeLayout.Explicit)]
public partial class SampleExplicitOrder
{
    [MemoryPackOrder(1)]
    public int Prop1 { get; set; }
    [MemoryPackOrder(0)]
    public int Prop0 { get; set; }
}
```

### Selección de constructor

MemoryPack soporta constructores con y sin parámetros. La selección del constructor sigue estas reglas. (Se aplica a clases y structs).

* Si existe `[MemoryPackConstructor]`, úselo.
* Si no hay constructor explícito (incluido privado), use uno sin parámetros.
* Si hay un solo constructor sin parámetros o con parámetros (incluido privado), úselo.
* Si hay múltiples constructores, entonces el atributo `[MemoryPackConstructor]` debe aplicarse al constructor deseado (el generador no elegirá uno automáticamente), de lo contrario el generador emitirá un error.
* Si usa un constructor con parámetros, todos los nombres de parámetros deben coincidir con los nombres de los miembros correspondientes (no distingue mayúsculas de minúsculas).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Puede usar un constructor con parámetros - los nombres de los parámetros deben coincidir con los miembros correspondientes (no distingue mayúsculas de minúsculas)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// también soporta el constructor primario de record
[MemoryPackable]
public partial record Person2(int Age, string Name);

public partial class Person3
{
    public int Age { get; set; }
    public string Name { get; set; }

    public Person3()
    {
    }

```csharp
// Si existen múltiples constructores, entonces se debe usar [MemoryPackConstructor]
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callbacks de serialización

Al serializar/deserializar, MemoryPack puede invocar un evento antes/después usando los atributos `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Se puede anotar tanto métodos estáticos como de instancia (no estáticos), y métodos públicos y privados.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // el orden de llamada de los métodos es static -> instance
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // también permite método privado
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

    // Nota: método de instancia con MemoryPackOnDeserializing, no se llama si la instancia no se pasa por `ref`
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

Los callbacks permiten métodos sin parámetros y métodos `ref reader/writer, ref T value`. Por ejemplo, los callbacks ref pueden escribir/leer un encabezado personalizado antes del proceso de serialización.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, use where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // escribe un GUID en el encabezado.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // lee el encabezado personalizado antes de deserializar
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Si se asigna un valor a `ref value`, se puede cambiar el valor utilizado para la serialización/deserialización. Por ejemplo, instanciar desde ServiceProvider.

```csharp
// antes de usar este formateador, establece ServiceProvider
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

Definir colección personalizada
---
Por defecto, un tipo anotado con `[MemoryPackObject]` intenta serializar sus miembros. Sin embargo, si un tipo es una colección (`ICollection<>`, `ISet<>`, `IDictionary<,>`), utiliza `GenerateType.Collection` para serializarlo correctamente.

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

Constructor estático
---
Una clase MemoryPackable no puede definir un constructor estático porque la clase parcial generada lo utiliza. En su lugar, puedes definir un `static partial void StaticConstructor()` para hacer lo mismo.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfismo (Unión)
---
MemoryPack soporta la serialización de objetos de interfaces y clases abstractas para la serialización polimórfica. En MemoryPack esta característica se llama Unión (Union). Solo se permite anotar interfaces y clases abstractas con los atributos `[MemoryPackUnion]`. Se requieren etiquetas de unión únicas.

```csharp
// Anotar [MemoryPackable] y los tipos de herencia con [MemoryPackUnion]
// Union también soporta clases abstractas
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

// Serializa como tipo interfaz.
var bin = MemoryPackSerializer.Serialize(data);

// Deserializa como tipo interfaz.
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

`tag` permite valores de `0` a `65535`, es especialmente eficiente para menos de `250`.
```
Si una interfaz y los tipos derivados están en diferentes ensamblados, puedes usar `MemoryPackUnionFormatterAttribute` en su lugar. Los formateadores se generan de manera que se registran automáticamente a través de `ModuleInitializer` en C# 9.0 y superior.

> Ten en cuenta que `ModuleInitializer` no es compatible con Unity, por lo que el formateador debe registrarse manualmente. Para registrar tu formateador de unión, invoca manualmente `{nombre de tu formateador de unión}Initializer.RegisterFormatter()` en el inicio (Startup). Por ejemplo, `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB define definición fuera del tipo objetivo
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

La unión puede ser ensamblada en código mediante `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

API de Serialización
---
`Serialize` tiene tres sobrecargas.

```csharp
// También disponible una API no genérica, en estas versiones el primer argumento es Type y el valor es object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Por rendimiento, la API recomendada utiliza `BufferWriter`. Esto serializa directamente en el buffer. Puede aplicarse a `PipeWriter` en `System.IO.Pipelines`, `BodyWriter` en ASP .NET Core, etc.

Si se requiere un `byte[]` (por ejemplo `RedisValue` en [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), la API que retorna `byte[]` es simple y casi igual de rápida.

Ten en cuenta que `SerializeAsync` para `Stream` es asíncrona solo para Flush; serializa todo de una vez en el buffer interno de MemoryPack y luego escribe usando `WriteAsync`. Por lo tanto, la sobrecarga con `BufferWriter`, que separa y controla el buffer y el flush, es mejor.

Si deseas realizar una escritura completamente en streaming, consulta la sección [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` configura si las cadenas se serializan como UTF16 o UTF8. Esto se puede configurar pasando `MemoryPackSerializerOptions.Utf8` para codificación UTF8, `MemoryPackSerializerOptions.Utf16` para UTF16 o `MemoryPackSerializerOptions.Default` que por defecto es UTF8. Pasar null o usar el parámetro por defecto resulta en codificación UTF8.

Dado que la representación interna de string en C# es UTF16, UTF16 tiene mejor rendimiento. Sin embargo, la carga útil tiende a ser mayor; en UTF8, una cadena ASCII ocupa un byte, mientras que en UTF16 ocupa dos bytes. Debido a que la diferencia de tamaño de esta carga útil es grande, UTF8 es el valor predeterminado.

Si los datos no son ASCII (por ejemplo japonés, que puede ocupar más de 3 bytes y UTF8 es mayor), o si tienes que comprimirlo por separado, UTF16 puede dar mejores resultados.

Aunque puedes elegir UTF8 o UTF16 durante la serialización, no es necesario especificarlo durante la deserialización. Se detectará automáticamente y se deserializará normalmente.

Adicionalmente, puedes obtener/establecer `IServiceProvider? ServiceProvider { get; init; }` desde las opciones. Es útil para obtener un objeto DI (como `ILogger<T>`) durante el proceso de serialización (`MemoryPackReader/MemoryPackWriter` tiene la propiedad .Options).

API de Deserialización
---
`Deserialize` tiene sobrecargas para `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` y soporte para `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

La sobrecarga `ref` sobrescribe una instancia existente, para más detalles consulta la sección [Overwrite](#overwrite).

`DeserializeAsync(Stream)` no es una operación de lectura completamente en streaming; primero lee hasta el final del stream en el pool interno de MemoryPack y luego deserializa.

Si deseas hacer una lectura completamente en streaming, consulta la sección [Streaming Serialization](#streaming-serialization).

Sobrescribir (Overwrite)
---
Para reducir asignaciones, MemoryPack admite deserializar en una instancia existente, sobrescribiéndola. Esto se puede usar con la sobrecarga `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// sobrescribe los datos en la instancia existente.
MemoryPackSerializer.Deserialize(bin, ref person);
```

MemoryPack intentará sobrescribir tanto como sea posible, pero si no se cumplen las siguientes condiciones, creará una nueva instancia (como en la deserialización normal).

* si el valor ref (incluye miembros en el grafo de objetos) es null, se crea una nueva instancia
* solo permite constructor sin parámetros, si se usa un constructor con parámetros, se crea una nueva instancia
* si el valor es `T[]`, solo se reutiliza si la longitud es la misma, de lo contrario se crea una nueva instancia
* si el valor es una colección que tiene el método `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) se llama a Clear() y se reutiliza, de lo contrario se crea una nueva instancia

Tolerancia de versiones (Version tolerant)
---
Por defecto (`GenerateType.Object`), MemoryPack admite una evolución limitada del esquema.

* las struct no administradas no pueden ser modificadas
* se pueden agregar miembros, pero no eliminar
* se puede cambiar el nombre de los miembros
* no se puede cambiar el orden de los miembros
* no se puede cambiar el tipo de miembro

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Agregar es OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Eliminar es NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Cambiar el orden es NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

En el caso de uso, almacenar datos antiguos (en archivo, en redis, etc...) y leerlos en el nuevo esquema siempre es válido. En el escenario RPC, el esquema existe tanto en el cliente como en el servidor, el cliente debe actualizarse antes que el servidor. Un cliente actualizado no tiene problema en conectarse al servidor antiguo, pero un cliente antiguo no puede conectarse a un servidor nuevo.

Por defecto, cuando los datos antiguos se leen en un esquema nuevo, cualquier miembro que no esté en los datos se inicializa con el literal `default`.
Si quieres evitar esto y usar los valores iniciales de los campos/propiedades, puedes usar `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < si faltan datos antiguos, se establece `111`.
    
    public int Prop3 { get; set; } = 222; // < si faltan datos antiguos, se establece `default`.
}
```

 `[SuppressDefaultInitialization]` tiene la siguiente limitación:
- No se puede usar con modificadores readonly, init-only y required.

La siguiente sección [Serialization info](#serialization-info) muestra cómo comprobar cambios de esquema, por ejemplo, mediante CI, para prevenir accidentes.

Al usar `GenerateType.VersionTolerant`, se admite tolerancia completa de versiones.

* las struct no administradas no pueden cambiarse más
* todos los miembros deben agregar `[MemoryPackOrder]` explícitamente (excepto si se anota `SerializeLayout.Sequential`)
* se pueden agregar miembros, se pueden eliminar pero no reutilizar el orden (se puede usar orden faltante)
* se puede cambiar el nombre de los miembros
* no se puede cambiar el orden de los miembros
* no se puede cambiar el tipo de miembro

```csharp
// Ok para serializar/deserializar ambos 
// VersionTolerantObject1 -> VersionTolerantObject2 y 
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

// eliminado
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// agregado
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Si se configura SerializeLayout.Sequential explícitamente, permite el orden automático.
// Pero no se puede eliminar ningún miembro para tolerancia de versión.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` es más lento que `GenerateType.Object` al serializar. Además, el tamaño del payload será ligeramente mayor.

Información de serialización
----
Puedes consultar en IntelliSense qué miembros de un tipo son serializados. Hay una opción para escribir esa información en un archivo en tiempo de compilación. Configura `MemoryPackGenerator_SerializationInfoOutputDirectory` de la siguiente manera.

```xml
<!-- exporta información de serialización de memorypack al directorio -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

La siguiente información se escribe en el archivo.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Si el tipo es unmanaged, se muestra `unmanaged` antes del nombre del tipo.

```txt
unmanaged FooStruct
---
int x
int y
```

Al comprobar las diferencias en este archivo, se pueden prevenir cambios peligrosos en el esquema. Por ejemplo, puedes querer usar CI para detectar las siguientes reglas

* modificar tipo unmanaged
* cambio en el orden de los miembros
* eliminación de miembros

Referencia circular
---
MemoryPack también soporta referencias circulares. Esto permite que los objetos en forma de árbol se serialicen tal cual.

```csharp
// para habilitar referencias circulares, usa GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Por ejemplo, el código de [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) se vería así.

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

`GenerateType.CircularReference` tiene las mismas características que version-tolerant. Sin embargo, como restricción adicional, solo se permiten constructores sin parámetros. Además, el seguimiento de referencias de objetos solo se realiza para objetos marcados con `GenerateType.CircularReference`. Si deseas rastrear cualquier otro objeto, envuélvelo.

CustomFormatter
---
Si implementas `MemoryPackCustomFormatterAttribute<T>` o `MemoryPackCustomFormatterAttribute<TFormatter, T>` (más eficiente, pero más complejo), puedes configurar el uso de un formateador personalizado para el miembro de un MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack proporciona los siguientes atributos de formateo: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serializa este miembro como cadena UTF16, es más eficiente que UTF8 pero en ASCII el tamaño es mayor (pero en no ASCII, a veces es menor).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Al deserializar, el Dictionary se inicializa con StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // En el momento de la deserialización, todas las cadenas son internadas (ver: String.Intern). Si valores similares se repiten, ahorra memoria.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Para configurar el comparador de igualdad de un set/dictionary, todos los formateadores incorporados tienen una sobrecarga de constructor con comparador. Puedes crear fácilmente formateadores personalizados con comparador de igualdad.

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

`BitPackFormatter` comprime solo tipos `bool[]`. `bool[]` normalmente se serializa como 1 byte por valor booleano, sin embargo, `BitPackFormatter` serializa `bool[]` como un `BitArray` almacenando cada bool como 1 bit. Usando `BitPackFormatter`, 8 bools se convierten en 1 byte, cuando normalmente serían 8 bytes, resultando en un tamaño 8 veces menor.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` es para `byte[]`, por ejemplo puedes comprimir grandes payloads con Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` es para `string`, serializa cadenas comprimidas (UTF16) usando Brotli.

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
`BrotliFormatter<T>` es para cualquier tipo, los datos serializados se comprimen con Brotli. Si el tipo es `byte[]` o `string`, deberías usar `BrotliFormatter` o `BrotliStringFormatter` para obtener un mejor rendimiento.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Deserialización con agrupamiento de arreglos
---
Para deserializar un arreglo grande (cualquier `T`), MemoryPack ofrece múltiples métodos eficientes de agrupamiento (pooling). La forma más efectiva es usar la función [#Overwrite](#overwrite). En particular, `List<T>` siempre se reutiliza.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> se reutiliza, sin asignaciones en la deserialización.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// para una operación eficiente, puedes obtener Span<T> usando CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Una forma conveniente es deserializar en un ArrayPool en el momento de la deserialización. MemoryPack proporciona `MemoryPoolFormatter<T>` y `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Debes escribir el código de retorno tú mismo, aquí hay un fragmento.

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
    // haz cualquier cosa...
}   // retorna al ArrayPool
```

Rendimiento
---
Consulta mi publicación en el blog [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Tamaño del payload y compresión
---
El tamaño del payload depende del valor objetivo; a diferencia de JSON, no hay claves y es un formato binario, por lo que el tamaño del payload probablemente será menor que JSON.

Para aquellos con codificación varint, como MessagePack y Protobuf, MemoryPack tiende a ser más grande si se usan muchos ints (en MemoryPack, los ints siempre son de 4 bytes debido a la codificación de tamaño fijo, mientras que en MessagePack son de 1 a 5 bytes).

float y double son de 4 bytes y 8 bytes en MemoryPack, pero de 5 bytes y 9 bytes en MessagePack. Así que MemoryPack es más pequeño, por ejemplo, para arreglos de Vector3 (float, float, float).

String es UTF8 por defecto, lo cual es similar a otros serializadores, pero si se elige la opción UTF16, será de naturaleza diferente.

En cualquier caso, si el tamaño del payload es grande, se debe considerar la compresión. Se recomienda LZ4, ZStandard y Brotli.

### Compresión

MemoryPack proporciona un ayudante eficiente para la compresión [Brotli](https://github.com/google/brotli) a través de [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) y [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). Los componentes `BrotliCompressor` y `BrotliDecompressor` de MemoryPack proporcionan compresión/descompresión optimizada para el comportamiento interno de MemoryPack.

```csharp
using MemoryPack.Compression;

// Compresión (requiere using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Obtener el byte[] comprimido
var compressedBytes = compressor.ToArray();

// O escribir a otro IBufferWriter<byte> (por ejemplo PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Descompresión (requiere using)
using var decompressor = new BrotliDecompressor();

// Obtener ReadOnlySequence<byte> descomprimido desde ReadOnlySpan<byte> o ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Tanto `BrotliCompressor` como `BrotliDecompressor` son structs, no asignan memoria en el heap. Ambos almacenan los datos comprimidos o descomprimidos en un agrupamiento de memoria interna para Serializar/Deserializar. Por lo tanto, es necesario liberar el agrupamiento de memoria, no olvides usar `using`.

El nivel de compresión es muy importante. El valor predeterminado es quality-1 (CompressionLevel.Fastest), que es diferente del predeterminado de .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) estará cerca de la velocidad de [LZ4](https://github.com/lz4/lz4), pero 4 es mucho más lento. Esto se determinó como crítico en el escenario de uso del serializador. Ten cuidado al usar el `BrotliStream` estándar (quality-4 es el valor predeterminado). En cualquier caso, las velocidades y tamaños de compresión/descompresión darán resultados muy diferentes según los datos. Por favor, prepara los datos que manejará tu aplicación y pruébalo tú mismo.

Ten en cuenta que hay una penalización de velocidad varias veces mayor entre el MemoryPack sin comprimir y la compresión adicional de Brotli.

Brotli también es compatible en un formateador personalizado. `BrotliFormatter` puede comprimir un miembro específico.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

Serializar tipos externos
---
Si deseas serializar tipos externos, puedes crear un formateador personalizado y registrarlo en el proveedor, consulta [Formatter/Provider API](#formatterprovider-api) para más detalles. Sin embargo, crear un formateador personalizado es difícil. Por lo tanto, recomendamos crear un tipo wrapper. Por ejemplo, si deseas serializar un tipo externo llamado `AnimationCurve`.

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

El tipo a envolver es público, pero está excluido de la serialización (`MemoryPackIgnore`). Las propiedades que deseas serializar son privadas, pero están incluidas (`MemoryPackInclude`). También deben prepararse dos patrones de constructores. El constructor usado por el serializador debe ser privado.

Tal cual, debe envolverse cada vez, lo cual es inconveniente. Además, el wrapper struct no puede representar null. Así que vamos a crear un formateador personalizado.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity no soporta scoped y TBufferWriter así que cambia la firma a `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
        reader.Advance(1); // omitir bloque nulo
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
```

Finalmente, registre el formateador en el inicio.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Nota: AnimationCurve de Unity es serializable por defecto, por lo que no necesita este formateador personalizado para AnimationCurve.

Paquetes
---
MemoryPack incluye estos paquetes.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` es la biblioteca principal, proporciona soporte completo para la serialización y deserialización de objetos binarios de alto rendimiento. Depende de `MemoryPack.Core` para las bibliotecas base principales y de `MemoryPack.Generator` para la generación de código. `MemoryPack.Streaming` agrega extensiones adicionales para la [Serialización de Streaming](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` agrega formateadores de entrada/salida para ASP.NET Core. `MemoryPack.UnityShims` agrega tipos shim y formateadores para compartir tipos entre .NET y Unity.

TypeScript y Formateador ASP.NET Core
---
MemoryPack soporta la generación de código TypeScript. Genera clases y código de serialización a partir de C#, en otras palabras, puedes compartir tipos con el navegador sin usar OpenAPI, proto, etc.

La generación de código está integrada con el Source Generator, las siguientes opciones (`MemoryPackGenerator_TypeScriptOutputDirectory`) establecen el directorio de salida para el código TypeScript. El código de tiempo de ejecución se genera al mismo tiempo, por lo que no se requieren dependencias adicionales.

```xml
<!-- salida de código TypeScript de memorypack al directorio -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Un tipo C# MemoryPackable debe ser anotado con `[GenerateTypeScript]`.

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

El código de tiempo de ejecución y el tipo TypeScript se generarán en el directorio destino.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

El código generado es el siguiente, con campos simples y métodos estáticos para serialize/serializeArray y deserialize/deserializeArray.

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

Puedes usar este tipo de la siguiente manera.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serializar a Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// deserializar desde ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

El paquete `MemoryPack.AspNetCoreMvcFormatter` agrega formateadores de entrada y salida `MemoryPack` para ASP.NET Core MVC. Puedes agregar `MemoryPackInputFormatter` y `MemoryPackOutputFormatter` a ASP.NET Core MVC con el siguiente código.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Si checkContentType: true entonces puede emitir múltiples formatos (JSON/MemoryPack, etc...). El valor por defecto es false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Si llamas desde HttpClient, puedes establecer `application/x-memorypack` en el encabezado de contenido.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Mapeo de Tipos TypeScript

Existen algunas restricciones en los tipos que pueden ser generados. Entre los primitivos, `char` y `decimal` no son soportados. Además, no se puede usar el tipo OpenGenerics.

|  C#  |  TypeScript  | Descripción |
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
| `Guid` |  `string`  | En TypeScript, se representa como string pero se serializa/deserializa como binario de 16 bytes
| `DateTime` | `Date` | DateTimeKind será ignorado
| `enum` | `const enum` | No se admite el tipo subyacente `long` y `ulong`
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Soporta todos los tipos que implementan `ICollection<T>` como `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Soporta todos los tipos que implementan `ISet<T>` como `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Soporta todos los tipos que implementan `IDictionary<K,V>` como `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Solo soporta clases
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` solo se puede aplicar a clases y actualmente no es compatible con struct.

### Configurar la extensión de archivo de importación y la convención de nombres de miembros

Por defecto, MemoryPack genera la extensión de archivo como `.js` por ejemplo `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Si deseas cambiar a otra extensión o dejarla vacía, usa `MemoryPackGenerator_TypeScriptImportExtension` para configurarlo.
Además, el nombre de los miembros se convierte automáticamente a camelCase. Si quieres usar el nombre original, pon `MemoryPackGenerator_TypeScriptConvertPropertyName` en `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- permite vacío -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- el valor por defecto es true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- el valor por defecto es false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` permite que las anotaciones nullable de C# se reflejen en el código TypeScript. El valor predeterminado es false, haciendo que todo sea nullable.

Serialización por Streaming
---
`MemoryPack.Streaming` proporciona `MemoryPackStreamingSerializer`, que añade soporte adicional para serializar y deserializar colecciones con streams.

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
Si deseas implementar un formatter manualmente, hereda de `MemoryPackFormatter<T>` y sobreescribe los métodos `Serialize` y `Deserialize`.

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

        // usa el método writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // usa el método reader.
    }
}
```
El formatter creado se registra con `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Nota: los `unmanaged struct` (que no contienen tipos de referencia) no pueden usar custom formatter, siempre serializan el layout de memoria nativo.

MemoryPackWriter/ReaderOptionalState
---
Inicializar `MemoryPackWriter`/`MemoryPackReader` requiere OptionalState. Es un wrapper de `MemoryPackSerializerOptions`, y se puede crear desde `MemoryPackWriterOptionalStatePool`.

```csharp
// cuando se desecha, OptionalState volverá al pool.
using(var state = MemoryPackWriterOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var writer = new MemoryPackWriter<T>(ref t, state);
}

// para Reader
using (var state = MemoryPackReaderOptionalStatePool.Rent(MemoryPackSerializerOptions.Default))
{
    var reader = new MemoryPackReader(buffer, state);
}
```

Dependencia del framework de destino
---
MemoryPack proporciona `netstandard2.1` y `net7.0` pero ambos no son compatibles entre sí. Por ejemplo, los tipos MemoryPackable bajo un proyecto `netstandard2.1` y usados desde un proyecto `net7.0`, lanzan una excepción en tiempo de ejecución como esta

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Como net7.0 utiliza miembros abstractos estáticos (`Virtual static method`), que no son compatibles con netstandard2.1, este comportamiento es parte de la especificación.

Un proyecto .NET 7 no debe usar la dll de netstandard 2.1. En otras palabras, si la aplicación es un proyecto .NET 7, todas las dependencias que usen MemoryPack deben soportar .NET 7. Así que si un desarrollador de librerías depende de MemoryPack, necesita configurar multi-target framework.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) es un framework grpc-dotnet code-first que utiliza MessagePack en vez de protobuf. MagicOnion ahora soporta MemoryPack como capa de serialización a través del paquete `MagicOnion.Serialization.MemoryPack` (preview). Ver detalles: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

La versión mínima de Unity soportada es `2022.3.12f1`.

El paquete principal de `MemoryPack` está disponible en nuget. También está disponible en Unity. Si quieres soporte para tipos integrados de Unity, también proveemos la extensión MemoryPack.Unity.

1. Instala `MemoryPack` desde NuGet usando [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Abre la ventana desde NuGet -> Manage NuGet Packages, busca "MemoryPack" y pulsa Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Si encuentras un error de conflicto de versiones, por favor deshabilita la validación de versiones en Player Settings (Edit -> Project Settings -> Player -> Baja y expande "Other Settings" y luego desmarca "Assembly Version Validation" en la sección "Configuration").

2. Instala el paquete `MemoryPack.Unity` referenciando la URL del git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


MemoryPack usa la etiqueta de versión *.*.*, por lo que puedes especificar una versión como #1.0.0. Por ejemplo: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Al igual que en la versión de .NET, el código se genera por un generador de código (`MemoryPack.Generator.dll`). La implementación libre de reflexión también proporciona el mejor rendimiento en IL2CPP.

Para más información sobre Unity y Source Generator, por favor consulta la [documentación de Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator también es utilizado oficialmente por Unity en [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) y [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Es decir, es el estándar para la generación de código en la próxima generación de Unity.

Puedes serializar todos los tipos unmanaged (como `Vector3`, `Rect`, etc...) y algunas clases (`AnimationCurve`, `Gradient`, `RectOffset`). Si deseas serializar otros tipos específicos de Unity, consulta la sección [Serialize external types](#serialize-external-types).

En cuanto a rendimiento en Unity, MemoryPack es de 3 a 10 veces más rápido que JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Si el código compartido tiene un tipo de Unity (`Vector2`, etc...), MemoryPack provee el paquete `MemoryPack.UnityShims` en NuGet.

El paquete `MemoryPack.UnityShims` provee shims para los structs estándar de Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) y algunas clases (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!WARNING]
> Actualmente, existen las siguientes limitaciones para el uso en Unity


1. La versión de Unity no soporta CustomFormatter.
2. Si usas .NET7 o posterior, el formato binario de MemoryPack no es completamente compatible con Unity.
    - Este problema ocurre con tipos de valor a los que se ha especificado explícitamente `[StructLayout(LayoutKind.Auto)]`. (El valor predeterminado para struct es `LayoutKind.Sequential`). Para estos tipos, los binarios serializados en .NET no se pueden deserializar en Unity. De igual forma, un binario serializado en Unity no se puede deserializar en .NET.
    - Los tipos afectados típicamente incluyen los siguientes:
        - `DateTimeOffset`
        - `ValueTuple`
    - Actualmente, la solución más simple es no usar estos tipos.


Native AOT
---
Desafortunadamente, .NET 7 Native AOT provoca un fallo (`Generic virtual method pointer lookup failure`) al usar MemoryPack debido a un bug en tiempo de ejecución. 
Se solucionará en .NET 8. Usando la versión preview de ``Microsoft.DotNet.ILCompiler` se soluciona en .NET 7. Por favor consulta el [comentario del issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) para saber cómo configurarlo.

Especificación del formato binario wire
---
El tipo de `T` definido en `Serialize<T>` y `Deserialize<T>` se llama esquema C#. El formato de MemoryPack no es un formato autodescriptivo. La deserialización requiere el esquema C# correspondiente. Estos tipos existen como representaciones internas de los binarios, pero los tipos no pueden determinarse sin un esquema C#.

El endianness debe ser `Little Endian`. Sin embargo, la implementación de referencia en C# no se preocupa por el endianness, por lo que no se puede usar en una máquina big-endian. No obstante, los ordenadores modernos suelen ser little-endian.

Existen ocho tipos de formatos.

* Unmanaged struct
* Object
* Version Tolerant Object
* Objeto de Referencia Circular
* Tupla
* Colección
* Cadena
* Unión

### struct no administrada

Una struct no administrada es una struct de C# que no contiene tipos de referencia, restricción similar a los [tipos no administrados de C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Serializa el layout de la struct tal cual, incluyendo el padding.

### Objeto

`(byte memberCount, [values...])`

El objeto tiene un byte sin signo de 1 byte como contador de miembros en el encabezado. El contador de miembros permite valores de `0` a `249`, `255` representa que el objeto es `null`. Los valores almacenan el valor de memorypack para la cantidad de miembros.

### Objeto Tolerante a Versiones

`(byte memberCount, [varint byte-length-of-values...], [values...])`

El Objeto Tolerante a Versiones es similar al Objeto pero tiene la longitud en bytes de los valores en el encabezado. varint sigue esta especificación: el primer sbyte es el valor o typeCode y los siguientes X bytes son el valor. 0 a 127 = valor de byte sin signo, -1 a -120 = valor de byte con signo, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Objeto de Referencia Circular

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

El Objeto de Referencia Circular es similar al Objeto Tolerante a Versiones, pero si el memberCount es 250, el siguiente varint (unsigned-int32) es referenceId. Si no, después de byte-length-of-values, se escribe varint referenceId.

### Tupla

`(values...)`

La Tupla es una colección de valores de tamaño fijo y no anulable. En .NET, `KeyValuePair<TKey, TValue>` y `ValueTuple<T,...>` se serializan como Tupla.

### Colección

`(int length, [values...])`

La Colección tiene un entero con signo de 4 bytes como contador de datos en el encabezado, `-1` representa `null`. Los valores almacenan el valor de memorypack para la cantidad de longitud.

### Cadena

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

La Cadena tiene dos formas, UTF16 y UTF8. Si el primer entero con signo de 4 bytes es `-1`, representa null. `0`, representa vacío. UTF16 es igual que colección (serializa como `ReadOnlySpan<char>`, el conteo de bytes de utf16-value es utf16-length * 2). Si el primer entero con signo es <= `-2`, el valor está codificado en UTF8. utf8-byte-count está codificado en complemento, `~utf8-byte-count` para obtener el conteo de bytes. El siguiente entero con signo es utf16-length, permite `-1` que representa longitud desconocida. utf8-bytes almacena los bytes según el número de utf8-byte-count.

### Unión

`(byte tag, value)`  
`(250, ushort tag, value)`

El primer byte sin signo es tag, utilizado para el tipo de valor discriminado o bandera, `0` a `249` representan tag, `250` indica que el siguiente unsigned short es tag, `255` representa que la unión es `null`.

Licencia
---
Esta biblioteca está licenciada bajo la Licencia MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---