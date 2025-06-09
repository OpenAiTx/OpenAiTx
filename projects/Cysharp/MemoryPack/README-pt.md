# MemoryPack

[![NuGet](https://img.shields.io/nuget/v/MemoryPack.svg)](https://www.nuget.org/packages/MemoryPack)
[![GitHub Actions](https://github.com/Cysharp/MemoryPack/workflows/Build-Debug/badge.svg)](https://github.com/Cysharp/MemoryPack/actions)
[![Releases](https://img.shields.io/github/release/Cysharp/MemoryPack.svg)](https://github.com/Cysharp/MemoryPack/releases)

Serializador binário de desempenho extremo com zero codificação para C# e Unity.

![image](https://user-images.githubusercontent.com/46207/200979655-63ed38ae-dad2-4ca0-bbb7-9e0aa98914af.png)

> Comparado com [System.Text.Json](https://learn.microsoft.com/ja-jp/dotnet/api/system.text.json), [protobuf-net](https://github.com/protobuf-net/protobuf-net), [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp), [Orleans.Serialization](https://github.com/dotnet/orleans/). Medido em máquina .NET 7 / Ryzen 9 5950X. Esses serializadores possuem método `IBufferWriter<byte>`, serializados utilizando `ArrayBufferWriter<byte>` e reutilizados para evitar a medição de cópia de buffer.

Para objetos padrão, o MemoryPack é x10 mais rápido e x2 ~ x5 mais rápido que outros serializadores binários. Para arrays de struct, o MemoryPack é ainda mais poderoso, com velocidades até x50 ~ x200 maiores do que outros serializadores.

MemoryPack é meu quarto serializador, anteriormente criei serializadores bem conhecidos, ~~[ZeroFormatter](https://github.com/neuecc/ZeroFormatter)~~, ~~[Utf8Json](https://github.com/neuecc/Utf8Json)~~, [MessagePack for C#](https://github.com/neuecc/MessagePack-CSharp). O motivo da velocidade do MemoryPack é devido ao seu formato binário específico e otimizado para C#, além de uma implementação bem ajustada baseada em minha experiência anterior. Também é um design completamente novo, utilizando .NET 7 e C# 11 e o Incremental Source Generator (.NET Standard 2.1 (.NET 5, 6) e também há suporte para Unity).

Outros serializadores realizam muitas operações de codificação, como VarInt, tag, string, etc. O formato do MemoryPack utiliza um design de zero-codificação que copia o máximo possível da memória do C#. Zero-codificação é similar ao FlatBuffers, mas não necessita de um tipo especial, o alvo da serialização do MemoryPack é POCO.

Além do desempenho, o MemoryPack possui estes recursos:

* Suporte às APIs modernas de I/O (`IBufferWriter<byte>`, `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`)
* Geração de código baseada em Source Generator nativo amigável para AOT, sem Dynamic CodeGen (IL.Emit)
* APIs não genéricas sem reflexão
* Desserialização em instância existente
* Serialização polimórfica (Union)
* Suporte a tolerância de versão limitada (rápido/padrão) e completa
* Serialização de referência circular
* Serialização de streaming baseada em PipeWriter/Reader
* Geração de código TypeScript e Formatter para ASP.NET Core
* Suporte a Unity (2021.3) IL2CPP via .NET Source Generator

Instalação
---
Esta biblioteca é distribuída via NuGet. Para melhor desempenho, recomenda-se usar `.NET 7`. O requisito mínimo é `.NET Standard 2.1`.

> PM> Install-Package [MemoryPack](https://www.nuget.org/packages/MemoryPack)

Além disso, o editor de código requer suporte ao Roslyn 4.3.1, por exemplo, Visual Studio 2022 versão 17.3, .NET SDK 6.0.401. Para mais detalhes, consulte o documento [Roslyn Version Support](https://learn.microsoft.com/en-us/visualstudio/extensibility/roslyn-version-support).

Para Unity, os requisitos e processo de instalação são completamente diferentes. Veja a seção [Unity](#unity) para detalhes.

Início Rápido
---
Defina uma struct ou classe a ser serializada e anote com o atributo `[MemoryPackable]` e a palavra-chave `partial`.

```csharp
using MemoryPack;

[MemoryPackable]
public partial class Person
{
    public int Age { get; set; }
    public string Name { get; set; }
}
```

O código de serialização é gerado pela funcionalidade de source generator do C#, que implementa a interface `IMemoryPackable<T>`. No Visual Studio você pode verificar o código gerado usando o atalho `Ctrl+K, R` sobre o nome da classe e selecionando `*.MemoryPackFormatter.g.cs`.

Chame `MemoryPackSerializer.Serialize<T>/Deserialize<T>` para serializar/desserializar uma instância de objeto.

```csharp
var v = new Person { Age = 40, Name = "John" };

var bin = MemoryPackSerializer.Serialize(v);
var val = MemoryPackSerializer.Deserialize<Person>(bin);
```

O método `Serialize` suporta tipo de retorno `byte[]`, além de poder serializar para `IBufferWriter<byte>` ou `Stream`. O método `Deserialize` suporta `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>` e `Stream`. Também existem versões não genéricas.

Tipos suportados nativamente
---
Estes tipos podem ser serializados por padrão:

* Primitivos do .NET (`byte`, `int`, `bool`, `char`, `double`, etc.)
* Tipos não gerenciados (Qualquer `enum`, qualquer `struct` definido pelo usuário que não contenha tipos de referência)
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
* Coleções imutáveis (`ImmutableList<>`, etc.) e interfaces (`IImmutableList<>`, etc.)

Defina `[MemoryPackable]` `class` / `struct` / `record` / `record struct`
---
`[MemoryPackable]` pode ser aplicado a qualquer `class`, `struct`, `record`, `record struct` e `interface`. Se o tipo for `struct` ou `record struct` que não contém tipos de referência ([Tipos não gerenciados em C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types)), qualquer anotação adicional (ignore, include, construtor, callbacks) não é usada, pois será serializado/desserializado diretamente da memória.

Caso contrário, por padrão, `[MemoryPackable]` serializa propriedades ou campos de instância públicos. Você pode usar `[MemoryPackIgnore]` para remover o alvo da serialização, `[MemoryPackInclude]` promove um membro privado para alvo de serialização.

```csharp
[MemoryPackable]
public partial class Sample
{
    // estes tipos são serializados por padrão
    public int PublicField;
    public readonly int PublicReadOnlyField;
    public int PublicProperty { get; set; }
    public int PrivateSetPublicProperty { get; private set; }
    public int ReadOnlyPublicProperty { get; }
    public int InitProperty { get; init; }
    public required int RequiredInitProperty { get; init; }

    // estes tipos não são serializados por padrão
    int privateProperty { get; set; }
    int privateField;
    readonly int privateReadOnlyField;

    // use [MemoryPackIgnore] para remover o alvo de um membro público
    [MemoryPackIgnore]
    public int PublicProperty2 => PublicProperty + PublicField;

    // use [MemoryPackInclude] para promover um membro privado como alvo de serialização
    [MemoryPackInclude]
    int privateField2;
    [MemoryPackInclude]
    int privateProperty2 { get; set; }
}
```

O gerador de código do `MemoryPack` adiciona informações sobre quais membros são serializados à seção `<remarks />`. Isso pode ser visualizado ao passar o mouse sobre o tipo com o Intellisense.

![image](https://user-images.githubusercontent.com/46207/192393984-9af01fcb-872e-46fb-b08f-4783e8cef4ae.png)

Todos os membros devem ser serializáveis pelo memorypack, caso contrário o gerador de código emitirá um erro.

![image](https://user-images.githubusercontent.com/46207/192413557-8a47d668-5339-46c5-a3da-a77841666f81.png)

O MemoryPack possui 35 regras de diagnóstico (`MEMPACK001` a `MEMPACK035`) para facilitar a definição.

Se o tipo alvo possuir serialização MemoryPack definida externamente e registrada, use `[MemoryPackAllowSerialize]` para silenciar diagnósticos.

```csharp
[MemoryPackable]
public partial class Sample2
{
    [MemoryPackAllowSerialize]
    public NotSerializableType? NotSerializableProperty { get; set; }
}
```

A ordem dos membros é **importante**, o MemoryPack não serializa o nome do membro nem outras informações, ao invés disso, serializa os campos na ordem em que são declarados. Se um tipo for herdado, a serialização ocorre na ordem pai → filho. A ordem dos membros não pode ser alterada para a desserialização. Para evolução de esquema, veja a seção [Tolerância de versão](#version-tolerant).

A ordem padrão é sequencial, mas você pode escolher o layout explícito com `[MemoryPackable(SerializeLayout.Explicit)]` e `[MemoryPackOrder()]`.

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

### Seleção de construtor

O MemoryPack suporta tanto construtores parametrizados quanto sem parâmetros. A seleção do construtor segue estas regras (aplicável a classes e structs):

* Se houver `[MemoryPackConstructor]`, use-o.
* Se não houver construtor explícito (incluindo privado), use o sem parâmetros.
* Se houver um único construtor sem parâmetros/parametrizado (incluindo privado), use-o.
* Se houver múltiplos construtores, então o atributo `[MemoryPackConstructor]` deve ser aplicado ao construtor desejado (o gerador não escolherá automaticamente), caso contrário, o gerador emitirá um erro.
* Se usar construtor parametrizado, todos os nomes dos parâmetros devem corresponder aos nomes dos membros correspondentes (case-insensitive).

```csharp
[MemoryPackable]
public partial class Person
{
    public readonly int Age;
    public readonly string Name;

    // Você pode usar um construtor parametrizado - os nomes dos parâmetros devem corresponder aos nomes dos membros (case-insensitive)
    public Person(int age, string name)
    {
        this.Age = age;
        this.Name = name;
    }
}

// também suporta record com construtor primário
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
// Se houver múltiplos construtores, então [MemoryPackConstructor] deve ser utilizado
[MemoryPackConstructor]
public Person3(int age, string name)
{
    this.Age = age;
    this.Name = name;
}
```

### Callbacks de serialização

Ao serializar/desserializar, o MemoryPack pode invocar um evento antes/depois utilizando os atributos `[MemoryPackOnSerializing]`, `[MemoryPackOnSerialized]`, `[MemoryPackOnDeserializing]`, `[MemoryPackOnDeserialized]`. Pode-se anotar tanto métodos estáticos quanto de instância (não estáticos), e métodos públicos ou privados.

```csharp
[MemoryPackable]
public partial class MethodCallSample
{
    // a ordem de chamada dos métodos é estático -> instância
    [MemoryPackOnSerializing]
    public static void OnSerializing1()
    {
        Console.WriteLine(nameof(OnSerializing1));
    }

    // também permite método privado
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

    // Nota: método de instância com MemoryPackOnDeserializing, não é chamado se a instância não for passada por `ref`
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

Os callbacks permitem métodos sem parâmetros e métodos com `ref reader/writer, ref T value`. Por exemplo, callbacks com ref podem escrever/ler cabeçalhos personalizados antes do processo de serialização.

```csharp
[MemoryPackable]
public partial class EmitIdData
{
    public int MyProperty { get; set; }

    [MemoryPackOnSerializing]
    static void WriteId<TBufferWriter>(ref MemoryPackWriter<TBufferWriter> writer, ref EmitIdData? value)
        where TBufferWriter : IBufferWriter<byte> // .NET Standard 2.1, use where TBufferWriter : class, IBufferWriter<byte>
    {
        writer.WriteUnmanaged(Guid.NewGuid()); // emite GUID no cabeçalho.
    }

    [MemoryPackOnDeserializing]
    static void ReadId(ref MemoryPackReader reader, ref EmitIdData? value)
    {
        // lê cabeçalho personalizado antes de desserializar
        var guid = reader.ReadUnmanaged<Guid>();
        Console.WriteLine(guid);
    }
}
```

Se definir um valor para `ref value`, você pode alterar o valor utilizado para serialização/desserialização. Por exemplo, instanciar a partir de um ServiceProvider.

```csharp
// antes de usar este formatter, configure o ServiceProvider
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

Definir coleção personalizada
---
Por padrão, o tipo anotado com `[MemoryPackObject]` tenta serializar seus membros. Entretanto, se um tipo for uma coleção (`ICollection<>`, `ISet<>`, `IDictionary<,>`), utilize `GenerateType.Collection` para serializá-lo corretamente.

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

Construtor estático
---
A classe MemoryPackable não pode definir construtor estático porque a classe parcial gerada o utiliza. Em vez disso, você pode definir um `static partial void StaticConstructor()` para realizar a mesma ação.

```csharp
[MemoryPackable]
public partial class CctorSample
{
    static partial void StaticConstructor()
    {
    }
}
```

Polimorfismo (Union)
---
O MemoryPack suporta serialização de objetos de interface e classes abstratas para serialização polimórfica. No MemoryPack este recurso é chamado de Union. Apenas interfaces e classes abstratas podem ser anotadas com os atributos `[MemoryPackUnion]`. Tags únicas de união são obrigatórias.

```csharp
// Anote [MemoryPackable] e os tipos de herança com [MemoryPackUnion]
// Union também suporta classe abstrata
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

// Serializa como tipo de interface.
var bin = MemoryPackSerializer.Serialize(data);

// Desserializa como tipo de interface.
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

`tag` permite valores de `0` ~ `65535`, sendo especialmente eficiente para valores menores que `250`.
```
Se uma interface e os tipos derivados estiverem em assemblies diferentes, você pode usar `MemoryPackUnionFormatterAttribute`. Os formatadores são gerados de forma que sejam registrados automaticamente via `ModuleInitializer` no C# 9.0 e superior.

> Observe que `ModuleInitializer` não é suportado no Unity, portanto o formatador deve ser registrado manualmente. Para registrar seu formatador union, invoque manualmente `{nome do seu union formatter}Initializer.RegisterFormatter()` na inicialização. Por exemplo, `UnionSampleFormatterInitializer.RegisterFormatter()`.

```csharp
// AssemblyA
[MemoryPackable(GenerateType.NoGenerate)]
public partial interface IUnionSample
{
}

// AssemblyB define definição fora do tipo alvo
[MemoryPackUnionFormatter(typeof(IUnionSample))]
[MemoryPackUnion(0, typeof(FooClass))]
[MemoryPackUnion(1, typeof(BarClass))]
public partial class UnionSampleFormatter
{
}
```

Union pode ser montada em código via `DynamicUnionFormatter<T>`.

```csharp
// (ushort, Type)[]
var formatter = new DynamicUnionFormatter<IFooBarBaz>(
    (0, typeof(Foo)),
    (1, typeof(Bar)),
    (2, typeof(Baz))
);

MemoryPackFormatterProvider.Register(formatter);
```

API de Serialização
---
`Serialize` possui três sobrecargas.

```csharp
// API não genérica também disponível, nestas versões o primeiro argumento é Type e o valor é object?
byte[] Serialize<T>(in T? value, MemoryPackSerializerOptions? options = default)
void Serialize<T, TBufferWriter>(in TBufferWriter bufferWriter, in T? value, MemoryPackSerializerOptions? options = default)
async ValueTask SerializeAsync<T>(Stream stream, T? value, MemoryPackSerializerOptions? options = default, CancellationToken cancellationToken = default)
```

Para desempenho, a API recomendada utiliza `BufferWriter`. Isso serializa diretamente no buffer. Pode ser aplicado a `PipeWriter` em `System.IO.Pipelines`, `BodyWriter` no ASP .NET Core, etc.

Se um `byte[]` for necessário (por exemplo, `RedisValue` em [StackExchange.Redis](https://github.com/StackExchange/StackExchange.Redis)), a API que retorna `byte[]` é simples e quase tão rápida quanto.

Observe que o `SerializeAsync` para `Stream` é assíncrono apenas para o Flush; ele serializa tudo de uma vez para o buffer interno do MemoryPack e então escreve usando `WriteAsync`. Portanto, a sobrecarga `BufferWriter`, que separa e controla o buffer e o flush, é melhor.

Se quiser realizar uma gravação totalmente streaming, veja a seção [Streaming Serialization](#streaming-serialization).

### MemoryPackSerializerOptions

`MemoryPackSerializerOptions` configura se strings serão serializadas como UTF16 ou UTF8. Isso pode ser configurado passando `MemoryPackSerializerOptions.Utf8` para codificação UTF8, `MemoryPackSerializerOptions.Utf16` para codificação UTF16 ou `MemoryPackSerializerOptions.Default`, que padrão é UTF8. Passar null ou usar o parâmetro padrão resulta em codificação UTF8.

Como a representação interna de string do C# é UTF16, UTF16 tem melhor desempenho. Porém, o payload tende a ser maior; em UTF8, uma string ASCII é um byte, enquanto em UTF16 são dois bytes. Como a diferença de tamanho desse payload é grande, UTF8 é o padrão.

Se os dados não forem ASCII (ex: japonês, que pode ser mais de 3 bytes, e UTF8 fica maior), ou se você precisar comprimir separadamente, UTF16 pode dar melhores resultados.

Embora UTF8 ou UTF16 possam ser escolhidos durante a serialização, não é necessário especificar durante a desserialização. Será detectado automaticamente e desserializado normalmente.

Adicionalmente, você pode obter/definir `IServiceProvider? ServiceProvider { get; init; }` nas opções. É útil para obter um objeto DI (como `ILogger<T>`) no processo de serialização (`MemoryPackReader/MemoryPackWriter` possui a propriedade .Options).

API de Desserialização
---
`Deserialize` possui sobrecargas para `ReadOnlySpan<byte>`, `ReadOnlySequence<byte>`, `Stream` e suporte a `ref`.

```csharp
T? Deserialize<T>(ReadOnlySpan<byte> buffer)
int Deserialize<T>(ReadOnlySpan<byte> buffer, ref T? value)
T? Deserialize<T>(in ReadOnlySequence<byte> buffer)
int Deserialize<T>(in ReadOnlySequence<byte> buffer, ref T? value)
async ValueTask<T?> DeserializeAsync<T>(Stream stream)
```

A sobrecarga `ref` sobrescreve uma instância existente, para detalhes veja a seção [Overwrite](#overwrite).

`DeserializeAsync(Stream)` não é uma operação de leitura streaming completa, primeiro lê para o pool interno do MemoryPack até o fim do stream, depois desserializa.

Se quiser realizar uma leitura totalmente streaming, veja a seção [Streaming Serialization](#streaming-serialization).

Sobrescrita (Overwrite)
---
Para reduzir alocações, o MemoryPack suporta desserialização para uma instância existente, sobrescrevendo-a. Isso pode ser usado com a sobrecarga `Deserialize(ref T? value)`.

```csharp
var person = new Person();
var bin = MemoryPackSerializer.Serialize(person);

// sobrescreve os dados na instância existente.
MemoryPackSerializer.Deserialize(bin, ref person);
```

O MemoryPack tentará sobrescrever o máximo possível, mas se as seguintes condições não forem atendidas, criará uma nova instância (como na desserialização normal).

* valor ref (inclui membros no grafo de objetos) é null, cria nova instância
* só permite construtor sem parâmetros, se utilizar construtor com parâmetros, cria nova instância
* se o valor for `T[]`, reutiliza apenas se o comprimento for igual, caso contrário cria nova instância
* se o valor for coleção que possui método `.Clear()` (`List<>`, `Stack<>`, `Queue<>`, `LinkedList<>`, `HashSet<>`, `PriorityQueue<,>`, `ObservableCollection`, `Collection`, `ConcurrentQueue<>`, `ConcurrentStack<>`, `ConcurrentBag<>`, `Dictionary<,>`, `SortedDictionary<,>`, `SortedList<,>`, `ConcurrentDictionary<,>`) chama Clear() e reutiliza, senão cria nova instância

Tolerância a Versão
---
Por padrão (`GenerateType.Object`), o MemoryPack suporta evolução de schema limitada.

* struct não gerenciado não pode ser alterado
* membros podem ser adicionados, mas não podem ser removidos
* pode alterar o nome do membro
* não pode alterar a ordem dos membros
* não pode alterar o tipo do membro

```csharp
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Adicionar é OK.
[MemoryPackable]
public partial class VersionCheck
{
    public int Prop1 { get; set; }
    public long Prop2 { get; set; }
    public int? AddedProp { get; set; }
}

// Remover é NG.
[MemoryPackable]
public partial class VersionCheck
{
    // public int Prop1 { get; set; }
    public long Prop2 { get; set; }
}

// Alterar ordem é NG.
[MemoryPackable]
public partial class VersionCheck
{
    public long Prop2 { get; set; }
    public int Prop1 { get; set; }
}
```

No caso de uso, armazenar dados antigos (em arquivo, redis, etc...) e ler para o novo schema sempre é permitido. No cenário de RPC, o schema existe tanto no cliente quanto no servidor, o cliente deve ser atualizado antes do servidor. Um cliente atualizado não tem problemas para conectar com o servidor antigo, mas um cliente antigo não pode conectar com um servidor novo.

Por padrão, quando os dados antigos são lidos para o novo schema, quaisquer membros ausentes no lado dos dados são inicializados com o literal `default`.
Se quiser evitar isso e usar valores iniciais dos campos/propriedades, pode usar `[SuppressDefaultInitialization]`.

```cs
[MemoryPackable]
public partial class DefaultValue
{
    public string Prop1 { get; set; }

    [SuppressDefaultInitialization]
    public int Prop2 { get; set; } = 111; // < se dados antigos não tiverem, define `111`.
    
    public int Prop3 { get; set; } = 222; // < se dados antigos não tiverem, define `default`.
}
```

 `[SuppressDefaultInitialization]` possui as seguintes limitações:
- Não pode ser usado com modificador readonly, init-only e required.

A próxima seção [Serialization info](#serialization-info) mostra como verificar mudanças de schema, por exemplo, via CI, para evitar acidentes.

Ao usar `GenerateType.VersionTolerant`, há suporte total à tolerância de versão.

* struct não gerenciado não pode mais ser alterado
* todos os membros devem adicionar `[MemoryPackOrder]` explicitamente (exceto anotação `SerializeLayout.Sequential`)
* membros podem ser adicionados, podem ser removidos mas não reutilizar ordem (pode usar ordem faltante)
* pode mudar nome do membro
* não pode mudar ordem do membro
* não pode mudar tipo do membro

```csharp
// Ok para serializar/desserializar ambos 
// VersionTolerantObject1 -> VersionTolerantObject2 e 
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

// excluído
//[MemoryPackOrder(1)]
//public long MyProperty1 { get; set; } = default;

[MemoryPackOrder(2)]
public short MyProperty2 { get; set; } = default;

// adicionado
[MemoryPackOrder(3)]
public short MyProperty3 { get; set; } = default;
}
```

```csharp
// Se definir SerializeLayout.Sequential explicitamente, permite ordenação automática.
// Mas não pode remover nenhum membro para tolerância a versões.
[MemoryPackable(GenerateType.VersionTolerant, SerializeLayout.Sequential)]
public partial class VersionTolerantObject3
{
    public int MyProperty0 { get; set; } = default;
    public long MyProperty1 { get; set; } = default;
    public short MyProperty2 { get; set; } = default;
}
```

`GenerateType.VersionTolerant` é mais lento do que `GenerateType.Object` na serialização. Além disso, o tamanho do payload será um pouco maior.

Informações de serialização
----
Você pode verificar no IntelliSense do tipo quais membros são serializados. Existe uma opção para gravar essas informações em um arquivo em tempo de compilação. Defina `MemoryPackGenerator_SerializationInfoOutputDirectory` da seguinte forma.

```xml
<!-- exporta informações de serialização do memorypack para o diretório -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_SerializationInfoOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_SerializationInfoOutputDirectory>$(MSBuildProjectDirectory)\MemoryPackLogs</MemoryPackGenerator_SerializationInfoOutputDirectory>
</PropertyGroup>
```

As seguintes informações são gravadas no arquivo.

![image](https://user-images.githubusercontent.com/46207/192460684-c2fd8bcb-375e-41dd-9960-58205d5b1b7a.png)

Se o tipo for unmanaged, será exibido `unmanaged` antes do nome do tipo.

```txt
unmanaged FooStruct
---
int x
int y
```

Verificando as diferenças neste arquivo, mudanças perigosas no esquema podem ser evitadas. Por exemplo, talvez você queira usar CI para detectar as seguintes regras

* modificar tipo unmanaged
* alteração na ordem dos membros
* deleção de membro

Referência circular
---
MemoryPack também suporta referência circular. Isso permite que os objetos em árvore sejam serializados como estão.

```csharp
// para habilitar referência circular, use GenerateType.CircularReference
[MemoryPackable(GenerateType.CircularReference)]
public partial class Node
{
    [MemoryPackOrder(0)]
    public Node? Parent { get; set; }
    [MemoryPackOrder(1)]
    public Node[]? Children { get; set; }
}
```

Por exemplo, o código [System.Text.Json preserve-references](https://learn.microsoft.com/en-us/dotnet/standard/serialization/system-text-json/preserve-references) ficará assim.

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

`GenerateType.CircularReference` possui as mesmas características que version-tolerant. Entretanto, como restrição adicional, somente construtores sem parâmetros são permitidos. Além disso, o rastreamento de referência de objeto é feito apenas para objetos marcados com `GenerateType.CircularReference`. Se desejar rastrear qualquer outro objeto, encapsule-o.

CustomFormatter
---
Se implementar `MemoryPackCustomFormatterAttribute<T>` ou `MemoryPackCustomFormatterAttribute<TFormatter, T>` (mais performático, porém mais complexo), você pode configurar o uso de formatador personalizado para membros do MemoryPackObject.

```csharp
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = false)]
public abstract class MemoryPackCustomFormatterAttribute<T> : Attribute
{
    public abstract IMemoryPackFormatter<T> GetFormatter();
}
```

MemoryPack fornece os seguintes atributos de formatação: `Utf8StringFormatterAttribute`, `Utf16StringFormatterAttribute`, `InternStringFormatterAttribute`, `OrdinalIgnoreCaseStringDictionaryFormatterAttribute<TValue>`, `BitPackFormatterAttribute`, `BrotliFormatter`, `BrotliStringFormatter`, `BrotliFormatter<T>`, `MemoryPoolFormatter<T>`, `ReadOnlyMemoryPoolFormatter<T>`.

```csharp
[MemoryPackable]
public partial class Sample
{
    // serializa este membro como String UTF16, é mais performático que UTF8 mas em ASCII, o tamanho é maior (mas para não-ASCII, às vezes é menor).
    [Utf16StringFormatter]
    public string? Text { get; set; }

    // Na desserialização, o Dictionary é inicializado com StringComparer.OrdinalIgnoreCase.
    [OrdinalIgnoreCaseStringDictionaryFormatter<int>]
    public Dictionary<string, int>? Ids { get; set; }
    
    // No momento da desserialização, todas as strings são internadas (veja: String.Intern). Se valores semelhantes aparecem repetidamente, economiza memória.
    [InternStringFormatter]
    public string? Flag { get; set; }
}
```

Para configurar o equality comparer de um set/dictionary, todos os formatadores internos possuem um overload de construtor com comparer. Você pode facilmente criar formatadores personalizados de equality-comparer.

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

`BitPackFormatter` comprime apenas tipos `bool[]`. `bool[]` normalmente é serializado como 1 byte por valor booleano, entretanto `BitPackFormatter` serializa `bool[]` como um `BitArray`, armazenando cada bool como 1 bit. Usando `BitPackFormatter`, 8 bools tornam-se 1 byte onde normalmente seriam 8 bytes, resultando em um tamanho 8x menor.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BitPackFormatter]
    public bool[]? Data { get; set; }
}
```

`BrotliFormatter` é para `byte[]`, por exemplo você pode comprimir um payload grande usando Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter]
    public byte[]? Payload { get; set; }
}
```

`BrotliStringFormatter` é para `string`, serializa string comprimida (UTF16) usando Brotli.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliStringFormatter]
    public string? LargeText { get; set; }
}
```
`BrotliFormatter<T>` é para qualquer tipo, dados serializados comprimidos por Brotli. Se um tipo for `byte[]` ou `string`, você deve usar `BrotliFormatter` ou `BrotliStringFormatter` para desempenho.

```csharp
[MemoryPackable]
public partial class Sample
{
    public int Id { get; set; }

    [BrotliFormatter<ChildType>]
    public ChildType? Child { get; set; }
}
```

Pooling de arrays na desserialização
---
Para desserializar um array grande (qualquer `T`), o MemoryPack oferece vários métodos eficientes de pooling. A maneira mais eficaz é usar a função [#Overwrite](#overwrite). Em particular, `List<T>` é sempre reutilizada.

```csharp
[MemoryPackable]
public partial class ListBytesSample
{
    public int Id { get; set; }
    public List<byte> Payload { get; set; }
}

// ----

// List<byte> é reutilizada, sem alocação na desserialização.
MemoryPackSerializer.Deserialize<ListBytesSample>(bin, ref reuseObject);

// para operação eficiente, você pode obter Span<T> por CollectionsMarshal
var span = CollectionsMarshal.AsSpan(value.Payload);
```

Uma maneira conveniente é desserializar para um ArrayPool no momento da desserialização. O MemoryPack fornece `MemoryPoolFormatter<T>` e `ReadOnlyMemoryPoolFormatter<T>`.

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

    // Você deve escrever o código de retorno sozinho, aqui está um trecho.

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
    // faça qualquer coisa...
}   // retorna para ArrayPool
```

Desempenho
---
Veja meu post no blog [How to make the fastest .NET Serializer with .NET 7 / C# 11, case of MemoryPack](https://medium.com/@neuecc/how-to-make-the-fastest-net-serializer-with-net-7-c-11-case-of-memorypack-ad28c0366516)

Tamanho do payload e compressão
---
O tamanho do payload depende do valor de destino; diferente do JSON, não há chaves e é um formato binário, então o tamanho do payload tende a ser menor que o do JSON.

Para aqueles com codificação varint, como MessagePack e Protobuf, o MemoryPack tende a ser maior se muitos ints forem usados (em MemoryPack, ints são sempre 4 bytes devido à codificação de tamanho fixo, enquanto em MessagePack é de 1~5 bytes).

float e double são 4 bytes e 8 bytes em MemoryPack, mas 5 bytes e 9 bytes em MessagePack. Assim, o MemoryPack é menor, por exemplo, para arrays de Vector3 (float, float, float).

String é UTF8 por padrão, o que é semelhante a outros serializadores, mas se a opção UTF16 for escolhida, será de natureza diferente.

Em qualquer caso, se o tamanho do payload for grande, a compressão deve ser considerada. LZ4, ZStandard e Brotli são recomendados.

### Compressão

O MemoryPack fornece um helper eficiente para compressão [Brotli](https://github.com/google/brotli) via [BrotliEncoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotliencoder) e [BrotliDecoder](https://learn.microsoft.com/en-us/dotnet/api/system.io.compression.brotlidecoder). Os `BrotliCompressor` e `BrotliDecompressor` do MemoryPack oferecem compressão/descompressão otimizadas para o comportamento interno do MemoryPack.

```csharp
using MemoryPack.Compression;

// Compressão (requer using)
using var compressor = new BrotliCompressor();
MemoryPackSerializer.Serialize(compressor, value);

// Obter byte[] comprimido
var compressedBytes = compressor.ToArray();

// Ou escrever para outro IBufferWriter<byte> (por exemplo PipeWriter)
compressor.CopyTo(response.BodyWriter);
```

```csharp
using MemoryPack.Compression;

// Descompressão (requer using)
using var decompressor = new BrotliDecompressor();

// Obter ReadOnlySequence<byte> descomprimido a partir de ReadOnlySpan<byte> ou ReadOnlySequence<byte>
var decompressedBuffer = decompressor.Decompress(buffer);

var value = MemoryPackSerializer.Deserialize<T>(decompressedBuffer);
```

Tanto `BrotliCompressor` quanto `BrotliDecompressor` são structs, não alocam memória no heap. Ambos armazenam dados comprimidos ou descomprimidos em um memory pool interno para Serialize/Deserialize. Portanto, é necessário liberar o memory pooling, não esqueça de usar `using`.

O nível de compressão é muito importante. O padrão é definido como quality-1 (CompressionLevel.Fastest), o que é diferente do padrão .NET (CompressionLevel.Optimal, quality-4).

Fastest (quality-1) será próximo à velocidade do [LZ4](https://github.com/lz4/lz4), mas 4 é muito mais lento. Isso foi considerado crítico no cenário de uso do serializador. Tenha cuidado ao usar o `BrotliStream` padrão (quality-4 é o padrão). Em qualquer caso, as velocidades e tamanhos de compressão/descompressão resultarão em resultados muito diferentes para diferentes dados. Prepare os dados que serão tratados por sua aplicação e teste você mesmo.

Observe que há uma penalidade de velocidade várias vezes entre o MemoryPack sem compressão e a compressão Brotli adicionada.

Brotli também é suportado em um formatter personalizado. `BrotliFormatter` pode comprimir um membro específico.

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
Se você quiser serializar tipos externos, pode criar um formatter personalizado e registrá-lo no provider, veja [Formatter/Provider API](#formatterprovider-api) para detalhes. Porém, criar um formatter personalizado é difícil. Portanto, recomendamos fazer um tipo wrapper. Por exemplo, se você quiser serializar um tipo externo chamado `AnimationCurve`.

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

O tipo a ser encapsulado é público, mas excluído da serialização (`MemoryPackIgnore`). As propriedades que você deseja serializar são privadas, mas incluídas (`MemoryPackInclude`). Dois padrões de construtores também devem ser preparados. O construtor usado pelo serializador deve ser privado.

Como está, deve ser encapsulado toda vez, o que é inconveniente. E também o wrapper struct não pode representar null. Então, vamos criar um formatter personalizado.

```csharp
public class AnimationCurveFormatter : MemoryPackFormatter<AnimationCurve>
{
    // Unity não suporta scoped e TBufferWriter então altere a assinatura para `Serialize(ref MemoryPackWriter writer, ref AnimationCurve value)`
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
        reader.Advance(1); // pular bloco nulo
        value = null;
        return;
    }
    
    var wrapped = reader.ReadPackable<SerializableAnimationCurve>();
    value = wrapped.AnimationCurve;
}
}
```

Finalmente, registre o formatador na inicialização.

```csharp
MemoryPackFormatterProvider.Register<AnimationCurve>(new AnimationCurveFormatter());
```
> Nota: AnimationCurve do Unity pode ser serializado por padrão, portanto não necessita deste formatador personalizado para AnimationCurve

Pacotes
---
MemoryPack possui estes pacotes.

* MemoryPack
* MemoryPack.Core
* MemoryPack.Generator
* MemoryPack.Streaming
* MemoryPack.AspNetCoreMvcFormatter
* MemoryPack.UnityShims

`MemoryPack` é a biblioteca principal, fornece suporte completo para serialização e desserialização de objetos binários de alta performance. Depende de `MemoryPack.Core` para as bibliotecas base e de `MemoryPack.Generator` para geração de código. `MemoryPack.Streaming` adiciona extensões para [Serialização Streaming](#streaming-serialization). `MemoryPack.AspNetCoreMvcFormatter` adiciona formatadores de entrada/saída para ASP.NET Core. `MemoryPack.UnityShims` adiciona tipos shims e formatadores para compartilhamento de tipos entre .NET e Unity.

TypeScript e Formatter para ASP.NET Core
---
MemoryPack suporta geração de código TypeScript. Ele gera classes e código de serialização a partir de C#. Em outras palavras, você pode compartilhar tipos com o navegador sem usar OpenAPI, proto, etc.

A geração de código é integrada ao Source Generator, as opções a seguir (`MemoryPackGenerator_TypeScriptOutputDirectory`) definem o diretório de saída para o código TypeScript. O código de runtime é gerado ao mesmo tempo, portanto, nenhuma dependência adicional é necessária.

```xml
<!-- saída do código TypeScript do memorypack para o diretório -->
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
</PropertyGroup>
```

Um tipo C# MemoryPackable deve ser anotado com `[GenerateTypeScript]`.

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

O código de runtime e o tipo TypeScript serão gerados no diretório de destino.

![image](https://user-images.githubusercontent.com/46207/194916544-1b6bb5ed-966b-43c3-a378-3eac297c2b40.png)

O código gerado é o seguinte, com campos simples e métodos estáticos para serialize/serializeArray e deserialize/deserializeArray.

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

Você pode usar este tipo como no exemplo a seguir.

```typescript
let person = new Person();
person.id = crypto.randomUUID();
person.age = 30;
person.firstName = "foo";
person.lastName = "bar";
person.dateOfBirth = new Date(1999, 12, 31, 0, 0, 0);
person.gender = Gender.Other;
person.emails = ["foo@bar.com", "zoo@bar.net"];

// serializar para Uint8Array
let bin = Person.serialize(person);

let blob = new Blob([bin.buffer], { type: "application/x-memorypack" })

let response = await fetch("http://localhost:5260/api",
    { method: "POST", body: blob, headers: { "Content-Type": "application/x-memorypack" } });

let buffer = await response.arrayBuffer();

// desserializar de ArrayBuffer 
let person2 = Person.deserialize(buffer);
```

O pacote `MemoryPack.AspNetCoreMvcFormatter` adiciona formatadores de entrada e saída `MemoryPack` para o ASP.NET Core MVC. Você pode adicionar `MemoryPackInputFormatter` e `MemoryPackOutputFormatter` ao ASP.NET Core MVC com o código a seguir.

```csharp
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

builder.Services.AddControllers(options =>
{
    options.InputFormatters.Insert(0, new MemoryPackInputFormatter());
    // Se checkContentType: true então pode gerar saída em múltiplos formatos (JSON/MemoryPack, etc...). O padrão é false.
    options.OutputFormatters.Insert(0, new MemoryPackOutputFormatter(checkContentType: false));
});
```

Se você chamar a partir do HttpClient, pode definir `application/x-memorypack` no cabeçalho do conteúdo.

```csharp
var content = new ByteArrayContent(bin)
content.Headers.ContentType = new MediaTypeHeaderValue("application/x-memorypack");
```

### Mapeamento de Tipos TypeScript

Há algumas restrições nos tipos que podem ser gerados. Entre os tipos primitivos, `char` e `decimal` não são suportados. Além disso, tipos OpenGenerics não podem ser usados.

|  C#  |  TypeScript  | Descrição |
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
| `Guid` |  `string`  | Em TypeScript, representa como string, mas serializa/desserializa como binário de 16 bytes
| `DateTime` | `Date` | DateTimeKind será ignorado
| `enum` | `const enum` | Tipo subjacente `long` e `ulong` não é suportado
| `T?` | `T \| null` |
| `T[]` | `T[] \| null` |
| `byte[]` | `Uint8Array \| null` |
| `: ICollection<T>` | `T[] \| null` | Suporta todo tipo que implementa `ICollection<T>`, como `List<T>`
| `: ISet<T>` | `Set<T> \| null` | Suporta todo tipo que implementa `ISet<T>`, como `HashSet<T>`
| `: IDictionary<K,V>` | `Map<K, V> \| null` | Suporta todo tipo que implementa `IDictionary<K,V>`, como `Dictionary<K,V>`.
| `[MemoryPackable]` | `class` | Suporta apenas classes
| `[MemoryPackUnion]` | `abstract class` |

`[GenerateTypeScript]` só pode ser aplicado a classes e atualmente não é suportado por struct.

### Configurar extensão de arquivo de importação e formatação dos nomes dos membros

Por padrão, o MemoryPack gera arquivos com extensão `.js`, como `import { MemoryPackWriter } from "./MemoryPackWriter.js";`. Se quiser mudar para outra extensão ou deixar vazio, use `MemoryPackGenerator_TypeScriptImportExtension` para configurar.
Além disso, o nome dos membros é automaticamente convertido para camelCase. Se quiser usar o nome original, defina `MemoryPackGenerator_TypeScriptConvertPropertyName` como `false`.

```xml
<ItemGroup>
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptOutputDirectory" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptImportExtension" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptConvertPropertyName" />
    <CompilerVisibleProperty Include="MemoryPackGenerator_TypeScriptEnableNullableTypes" />
</ItemGroup>
<PropertyGroup>
    <MemoryPackGenerator_TypeScriptOutputDirectory>$(MSBuildProjectDirectory)\wwwroot\js\memorypack</MemoryPackGenerator_TypeScriptOutputDirectory>
    <!-- permite vazio -->
    <MemoryPackGenerator_TypeScriptImportExtension></MemoryPackGenerator_TypeScriptImportExtension>
    <!-- padrão é true -->
    <MemoryPackGenerator_TypeScriptConvertPropertyName>false</MemoryPackGenerator_TypeScriptConvertPropertyName>
    <!-- padrão é false -->
    <MemoryPackGenerator_TypeScriptEnableNullableTypes>true</MemoryPackGenerator_TypeScriptEnableNullableTypes>
</PropertyGroup>
```

`MemoryPackGenerator_TypeScriptEnableNullableTypes` permite que anotações de nullable do C# sejam refletidas no código TypeScript. O padrão é false, tornando tudo nullable.

Serialização Streaming
---
`MemoryPack.Streaming` fornece `MemoryPackStreamingSerializer`, que adiciona suporte adicional para serializar e desserializar coleções com streams.

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
Se você deseja implementar um formatter manualmente, herde de `MemoryPackFormatter<T>` e sobrescreva os métodos `Serialize` e `Deserialize`.

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

        // use o método do writer.
    }

    public override void Deserialize(ref MemoryPackReader reader, scoped ref Skelton? value)
    {
        if (!reader.TryReadObjectHeader(out var count))
        {
            value = null;
            return;
        }

        // use o método do reader.
    }
}
```
O formatter criado é registrado com `MemoryPackFormatterProvider`.

```csharp
MemoryPackFormatterProvider.Register(new SkeltonFormatter());
```

Nota: `unmanaged struct` (não contém tipos de referência) não pode usar custom formatter, sempre serializa o layout de memória nativo.

MemoryPackWriter/ReaderOptionalState
---
Inicializar `MemoryPackWriter`/`MemoryPackReader` requer OptionalState. É um wrapper do `MemoryPackSerializerOptions`, podendo ser criado a partir do `MemoryPackWriterOptionalStatePool`.

```csharp
// ao fazer dispose, OptionalState retorna ao pool.
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

Dependência de framework alvo
---
MemoryPack fornece `netstandard2.1` e `net7.0`, mas ambos não são compatíveis entre si. Por exemplo, tipos MemoryPackable sob projeto `netstandard2.1` usados a partir de um projeto `net7.0` geram exceção de runtime como:

> Unhandled exception. System.TypeLoadException: Virtual static method '*' is not implemented on type '*' from assembly '*'.

Como o net7.0 usa membros static abstract (`Virtual static method`), isso não é suportado em netstandard2.1. Este comportamento é uma especificação.

Projetos .NET 7 não devem usar a dll do netstandard 2.1. Ou seja, se a aplicação é um projeto .NET 7, todas as dependências que usam MemoryPack devem suportar .NET 7. Portanto, se um desenvolvedor de biblioteca depende do MemoryPack, é necessário configurar dual target framework.

```xml
<TargetFrameworks>netstandard2.1;net7.0</TargetFrameworks>
```

RPC
---
[Cysharp/MagicOnion](https://github.com/Cysharp/MagicOnion) é um framework grpc-dotnet code-first usando MessagePack ao invés de protobuf. O MagicOnion agora suporta MemoryPack como camada de serialização via pacote `MagicOnion.Serialization.MemoryPack` (preview). Veja detalhes: [MagicOnion#MemoryPack support](https://github.com/Cysharp/MagicOnion#memorypack-support)

Unity
---

A versão mínima suportada do Unity é `2022.3.12f1`.

O pacote core do `MemoryPack` é fornecido via nuget. Ele também está disponível no Unity. Se você quiser obter suporte para tipos nativos do Unity, fornecemos adicionalmente a extensão MemoryPack.Unity.

1. Instale `MemoryPack` do NuGet usando [NuGetForUnity](https://github.com/GlitchEnzo/NuGetForUnity)

* Abra a janela do NuGet -> Manage NuGet Packages, pesquise por "MemoryPack" e pressione Install.
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/599ff1ed-6cca-4724-be67-3edddb5e62ee)

* Se encontrar erros de conflito de versão, desabilite a validação de versão em Player Settings (Edit -> Project Settings -> Player -> Role para baixo e expanda "Other Settings", depois desmarque "Assembly Version Validation" na seção "Configuration").

2. Instale o pacote `MemoryPack.Unity` referenciando a URL do git

* `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity`
![screenshot](https://github.com/Cysharp/ZLogger/assets/46207/7325d266-05b4-47c9-b06a-a67a40368dd2)
![screenshot](https://github.com/Cysharp/MemoryPack/assets/727159/9a4af1df-ce07-49d7-9420-922dfb139b55)


O MemoryPack usa a tag de release *.*.*, então você pode especificar uma versão como #1.0.0. Por exemplo: `https://github.com/Cysharp/MemoryPack.git?path=src/MemoryPack.Unity/Assets/MemoryPack.Unity#1.0.0`


Assim como na versão .NET, o código é gerado por um gerador de código (`MemoryPack.Generator.dll`). A implementação sem reflection também garante a melhor performance no IL2CPP.

Para mais informações sobre Unity e Source Generator, consulte a [documentação da Unity](https://docs.unity3d.com/Manual/roslyn-analyzers.html).

Source Generator também é usado oficialmente pela Unity por [com.unity.properties](https://docs.unity3d.com/Packages/com.unity.entities@1.0/manual/index.html) e [com.unity.entities](https://docs.unity3d.com/Packages/com.unity.properties@2.0/changelog/CHANGELOG.html). Ou seja, é o padrão para geração de código na próxima geração do Unity.

Você pode serializar todos os tipos unmanaged (como `Vector3`, `Rect`, etc...) e algumas classes (`AnimationCurve`, `Gradient`, `RectOffset`). Se quiser serializar outros tipos específicos do Unity, veja a seção [Serialize external types](#serialize-external-types).

Em performance no Unity, MemoryPack é de 3 a 10 vezes mais rápido que o JsonUtility.

![image](https://user-images.githubusercontent.com/46207/209254561-79ec18fe-c421-4d8c-9c86-b55276dd1a45.png)

Se o código compartilhado possui tipos do Unity (`Vector2`, etc...), o MemoryPack fornece o pacote `MemoryPack.UnityShims` no NuGet.

O pacote `MemoryPack.UnityShims` fornece shims para structs padrão do Unity (`Vector2`, `Vector3`, `Vector4`, `Quaternion`, `Color`, `Bounds`, `Rect`, `Keyframe`, `WrapMode`, `Matrix4x4`, `GradientColorKey`, `GradientAlphaKey`, `GradientMode`, `Color32`, `LayerMask`, `Vector2Int`, `Vector3Int`, `RangeInt`, `RectInt`, `BoundsInt`) e algumas classes (`AnimationCurve`, `Gradient`, `RectOffset`).

> [!AVISO]
> Atualmente, existem as seguintes limitações para uso no Unity


1. A versão do Unity não suporta CustomFormatter.
2. Se você está usando .NET7 ou superior, o formato binário do MemoryPack não é totalmente compatível com o Unity.
    - Esse problema ocorre com tipos de valor que especificam explicitamente `[StructLayout(LayoutKind.Auto)]`. (O padrão para struct é `LayoutKind.Sequential`.) Para esses tipos, binários serializados no .NET não podem ser desserializados no Unity. Da mesma forma, um binário serializado no Unity não pode ser desserializado no lado .NET.
    - Os tipos afetados normalmente incluem:
        - `DateTimeOffset`
        - `ValueTuple`
    - Atualmente, a solução simples é não usar esses tipos.


Native AOT
---
Infelizmente, o .NET 7 Native AOT causa crash (`Generic virtual method pointer lookup failure`) ao usar MemoryPack devido a um bug de runtime. Isso será corrigido no .NET 8. Usando a versão preview do ``Microsoft.DotNet.ILCompiler``, isso será corrigido no .NET 7. Veja o [comentário da issue](https://github.com/Cysharp/MemoryPack/issues/75#issuecomment-1386884611) para saber como configurar.

Especificação do formato binário
---
O tipo `T` definido em `Serialize<T>` e `Deserialize<T>` é chamado de schema C#. O formato MemoryPack não é um formato autodescritivo. A desserialização requer o schema C# correspondente. Esses tipos existem como representações internas dos binários, mas os tipos não podem ser determinados sem um schema C#.

O Endian deve ser `Little Endian`. No entanto, a implementação de referência em C# não se preocupa com endianness, então não pode ser usada em máquinas big-endian. Porém, computadores modernos geralmente são little-endian.

Existem oito tipos de formato.

* Unmanaged struct
* Object
* Version Tolerant Object
* Objeto de Referência Circular
* Tupla
* Coleção
* String
* União

### Struct não gerenciado

Struct não gerenciado é uma struct C# que não contém tipos de referência, restrição semelhante à de [Tipos não gerenciados do C#](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/unmanaged-types). Serializa o layout da struct como está, incluindo preenchimento (padding).

### Objeto

`(byte memberCount, [values...])`

O objeto possui 1 byte sem sinal como contagem de membros no cabeçalho. A contagem de membros permite de `0` a `249`, `255` representa que o objeto é `null`. Os valores armazenam o valor memorypack para o número da contagem de membros.

### Objeto Tolerante a Versão

`(byte memberCount, [varint byte-length-of-values...], [values...])`

Objeto Tolerante a Versão é semelhante ao Objeto, mas possui o comprimento em bytes dos valores no cabeçalho. varint segue estas especificações: o primeiro sbyte é valor ou typeCode e os próximos X bytes são o valor. 0 a 127 = valor byte sem sinal, -1 a -120 = valor byte com sinal, -121 = byte, -122 = sbyte, -123 = ushort, -124 = short, -125 = uint, -126 = int, -127 = ulong, -128 = long.

### Objeto de Referência Circular

`(byte memberCount, [varint byte-length-of-values...], varint referenceId, [values...])`  
`(250, varint referenceId)`

Objeto de Referência Circular é semelhante ao Objeto Tolerante a Versão, mas se memberCount for 250, o próximo varint (uint32 sem sinal) é referenceId. Caso contrário, após o byte-length-of-values, varint referenceId é gravado.

### Tupla

`(values...)`

Tupla é uma coleção de valores de tamanho fixo e não anulável. No .NET, `KeyValuePair<TKey, TValue>` e `ValueTuple<T,...>` são serializados como Tupla.

### Coleção

`(int length, [values...])`

Coleção possui um inteiro de 4 bytes com sinal como contagem de dados no cabeçalho, `-1` representa `null`. Os valores armazenam o valor memorypack para o número do comprimento.

### String

`(int utf16-length, utf16-value)`  
`(int ~utf8-byte-count, int utf16-length, utf8-bytes)`

String possui duas formas, UTF16 e UTF8. Se o primeiro inteiro de 4 bytes com sinal for `-1`, representa nulo. `0` representa vazio. UTF16 é igual a coleção (serializa como `ReadOnlySpan<char>`, a contagem de bytes do valor utf16 é utf16-length * 2). Se o primeiro inteiro com sinal for <= `-2`, o valor é codificado por UTF8. utf8-byte-count é codificado em complemento, `~utf8-byte-count` para recuperar a contagem de bytes. O próximo inteiro com sinal é utf16-length, permitindo `-1` que representa comprimento desconhecido. utf8-bytes armazena os bytes pelo número de utf8-byte-count.

### União

`(byte tag, value)`  
`(250, ushort tag, value)`

O primeiro byte sem sinal é a tag para o tipo de valor discriminado ou flag, `0` a `249` representa tag, `250` indica que o próximo unsigned short é tag, `255` representa que a união é `null`.

Licença
---
Esta biblioteca é licenciada sob a Licença MIT.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---