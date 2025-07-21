<translate-content># Scrutor [![Build status](https://ci.appveyor.com/api/projects/status/j00uyvqnm54rdlkb?svg=true)](https://ci.appveyor.com/project/khellang/scrutor) [![NuGet Package](https://img.shields.io/nuget/v/Scrutor.svg)](https://www.nuget.org/packages/Scrutor)

> Scrutor - 徹底的に探すまたは調査すること；探り、調査、または精査すること  
> 動詞の元の意味であるゴミを探ることから。 - https://en.wiktionary.org/wiki/scrutor

Microsoft.Extensions.DependencyInjection 用のアセンブリスキャンおよび装飾拡張

## インストール

[Scrutor NuGet パッケージ](https://www.nuget.org/packages/Scrutor) をインストールしてください。

### パッケージマネージャーコンソール

```
Install-Package Scrutor
```
### .NET Core CLI


```
dotnet add package Scrutor
```
<translate-content>
## 使用法

このライブラリは `IServiceCollection` に2つの拡張メソッドを追加します:

* `Scan` - アセンブリスキャンの設定を開始するためのエントリーポイントです。
* `Decorate` - 既に登録されたサービスを装飾するために使用されるメソッドです。

使用例については、以下の**Examples**を参照してください。

## Examples

### スキャン
</translate-content>
```csharp
var collection = new ServiceCollection();

collection.Scan(scan => scan
     // We start out with all types in the assembly of ITransientService
    .FromAssemblyOf<ITransientService>()
        // AddClasses starts out with all public, non-abstract types in this assembly.
        // These types are then filtered by the delegate passed to the method.
        // In this case, we filter out only the classes that are assignable to ITransientService.
        .AddClasses(classes => classes.AssignableTo<ITransientService>())
            // We then specify what type we want to register these classes as.
            // In this case, we want to register the types as all of its implemented interfaces.
            // So if a type implements 3 interfaces; A, B, C, we'd end up with three separate registrations.
            .AsImplementedInterfaces()
            // And lastly, we specify the lifetime of these registrations.
            .WithTransientLifetime()
        // Here we start again, with a new full set of classes from the assembly above.
        // This time, filtering out only the classes assignable to IScopedService.
        .AddClasses(classes => classes.AssignableTo<IScopedService>())
            // Now, we just want to register these types as a single interface, IScopedService.
            .As<IScopedService>()
            // And again, just specify the lifetime.
            .WithScopedLifetime()
        // Generic interfaces are also supported too, e.g. public interface IOpenGeneric<T> 
        .AddClasses(classes => classes.AssignableTo(typeof(IOpenGeneric<>)))
            .AsImplementedInterfaces()
        // And you scan generics with multiple type parameters too
        // e.g. public interface IQueryHandler<TQuery, TResult>
        .AddClasses(classes => classes.AssignableTo(typeof(IQueryHandler<,>)))
            .AsImplementedInterfaces());
```
#### コンパイル済みビュー（UI）タイプのスキャン
デフォルトでは、Scrutor は `.AddClasses()` タイプフィルターからコンパイラー生成のタイプを除外します。  
[Avalonia UI](https://avaloniaui.net/) のようなフレームワークからビューを読み込む際には、以下のようにコンパイラー生成のタイプを明示的に含める必要があります。

```csharp
.AddClasses(classes => classes
    // Opt-in to compiler-generated types
    .WithAttribute<CompilerGeneratedAttribute>()
    // Optionally filter types to reduce number of service registrations.
    .InNamespaces("MyApp.Desktop.Views")
    .AssignableToAny(
        typeof(Window),
        typeof(UserControl)
    )
    .AsSelf()
    .WithSingletonLifetime()
```
<translate-content>
一部のUIフレームワークでは、これらのコンパイラ生成ビューはかなり多くのインターフェースを実装しているため、必要がない限り、これらのクラスは `.AsSelf()` として登録するのが最善です。つまり、コンパイラ生成型を受け入れるフィルターは非常に正確に指定してください。

### Decoration
</translate-content>
```csharp
var collection = new ServiceCollection();

// First, add our service to the collection.
collection.AddSingleton<IDecoratedService, Decorated>();

// Then, decorate Decorated with the Decorator type.
collection.Decorate<IDecoratedService, Decorator>();

// Finally, decorate Decorator with the OtherDecorator type.
// As you can see, OtherDecorator requires a separate service, IService. We can get that from the provider argument.
collection.Decorate<IDecoratedService>((inner, provider) => new OtherDecorator(inner, provider.GetRequiredService<IService>()));

var serviceProvider = collection.BuildServiceProvider();

// When we resolve the IDecoratedService service, we'll get the following structure:
// OtherDecorator -> Decorator -> Decorated
var instance = serviceProvider.GetRequiredService<IDecoratedService>();
```

## Sponsors

[Entity Framework Extensions](https://entityframework-extensions.net/?utm_source=khellang&utm_medium=Scrutor) and [Dapper Plus](https://dapper-plus.net/?utm_source=khellang&utm_medium=Scrutor) are major sponsors and proud to contribute to the development of Scrutor.

[![Entity Framework Extensions](https://raw.githubusercontent.com/khellang/khellang/refs/heads/master/.github/entity-framework-extensions-sponsor.png)](https://entityframework-extensions.net/bulk-insert?utm_source=khellang&utm_medium=Scrutor)

[![Dapper Plus](https://raw.githubusercontent.com/khellang/khellang/refs/heads/master/.github/dapper-plus-sponsor.png)](https://dapper-plus.net/bulk-insert?utm_source=khellang&utm_medium=Scrutor)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---