
# Scrutor [![Build status](https://ci.appveyor.com/api/projects/status/j00uyvqnm54rdlkb?svg=true)](https://ci.appveyor.com/project/khellang/scrutor) [![NuGet Package](https://img.shields.io/nuget/v/Scrutor.svg)](https://www.nuget.org/packages/Scrutor)

> Scrutor - 나는 철저히 찾거나 조사한다; 탐색하고, 조사하거나 면밀히 조사한다  
> 라틴어 scrūta에서 유래, 동사의 원래 의미는 쓰레기를 뒤지다였다. - https://en.wiktionary.org/wiki/scrutor

Microsoft.Extensions.DependencyInjection을 위한 어셈블리 스캐닝 및 장식 확장

## 설치

[Scrutor NuGet 패키지](https://www.nuget.org/packages/Scrutor)를 설치하세요.

### 패키지 관리자 콘솔

```
Install-Package Scrutor
```
### .NET Core CLI


```
dotnet add package Scrutor
```


## 사용법

이 라이브러리는 `IServiceCollection`에 두 가지 확장 메서드를 추가합니다:

* `Scan` - 어셈블리 스캔을 설정하는 진입점입니다.
* `Decorate` - 이미 등록된 서비스를 데코레이트하는 데 사용됩니다.

사용 예는 아래 **예제**를 참조하세요.

## 예제

### 스캔


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
#### 컴파일된 뷰(UI) 타입 스캔
기본적으로 Scrutor는 `.AddClasses()` 타입 필터에서 컴파일러가 생성한 타입을 제외합니다. [Avalonia UI](https://avaloniaui.net/)와 같은 프레임워크에서 뷰를 로드할 때는, 다음과 같이 컴파일러가 생성한 타입을 선택해야 합니다:


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


일부 UI 프레임워크에서는 이 컴파일러 생성 뷰들이 꽤 많은 인터페이스를 구현하므로, 필요하지 않다면 이 클래스들을 `.AsSelf()`로 등록하는 것이 아마도 최선입니다; 다시 말해, 컴파일러 생성 타입을 허용하는 필터를 매우 정확하게 설정하세요.

### 데코레이션


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