# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Bu [.NET kaynak üreteci](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) bir async metottan senkron bir metot üretir.

## Kullanım Senaryoları

- Hem senkron hem de asenkron sürümünü sunan bir kütüphane
- Bir uygulamanın iki tür veriyi aynı şekilde işlemesi gerekir:
  - Bellekte tutulamayan büyük I/O verileri: Orijinal async metot
  - Genellikle daha büyük verinin bir örneği olan, bellekte tutulan küçük veri: Üretilen senkron metot

## Nasıl Çalışır

### CreateSyncVersionAttribute

Async metodunuzu `partial` sınıf, struct veya record'unuzda `CreateSyncVersionAttribute` ile işaretleyin

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Ve bunun senkron bir sürümü otomatik olarak üretilir:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Yeni senkronize edilmiş metoda uygulanan değişiklikler listesi:

- async değiştiricisini kaldırır
- await ifadelerini ve `foreach` ifadelerindeki kullanımlarını kaldırır
- Tipleri değiştirir

  | Kaynak                                                                                                                                                                                                | Hedef                                                                                                                                |
  | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)*                                                                                                                    | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)                                                                                                               | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/en-us/dotnet/api/system.func-1)\<Task>                                                                                                                            | [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                      | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                   | [IEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                   | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                  | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator)  | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1)                                                                                                                           | [Span\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlymemory-1)                                                                                                           | [ReadOnlySpan\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask) değerleri [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task) ile aynı şekilde ele alınır
- Parametreleri kaldırır
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Çağrı değişiklikleri
  - [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) ve [Asenkron Numaralandırmalar](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait) üzerinden `ConfigureAwait` çağrılarını kaldırır
  - [Task.WaitAsync](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync) çağrılarını kaldırır
  - [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation) çağrılarını kaldırır
  - `Async` son ekine sahip asenkron çağrıları, senkron sürümlerini çağıracak şekilde dönüştürür (örn. [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) yerine [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - `Async` son eki olmayan asenkron çağrıları kaldırır
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) parametresini kaldırır
  - [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report) çağrısını kaldırır
  - [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span) özelliğini kaldırır
  - `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`değer`) ifadesini `değer` olarak değiştirir
  - `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`değer`) ifadesini [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`değer`) olarak değiştirir
  - [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) döndüren herhangi bir çağrıyı [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)() ile değiştirir
- `CreateSyncVersionAttribute`'ı kaldırır
- XML dokümantasyonunu günceller

#### Özellikler

##### OmitNullableDirective

Bu kaynak üreteci derleme sırasında dil sürümünü algılar. Varsayılan olarak, yalnızca dil sürümü 8 veya üzeriyse `#nullable enable` yönergesini oluşturur. [Güvenilir şekilde](https://github.com/dotnet/roslyn/issues/49555) nullable bağlamın açık olup olmadığını belirlemek imkansız olduğundan, bu yönergenin üretilmesini engellemek için `OmitNullableDirective` özelliği kullanılabilir.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY sembolü

Sadece senkronize edilmiş metot sürümünde çalıştırılması gereken bir kod varsa, bunu `SYNC_ONLY` #if yönergesine sarın.

`SYNC_ONLY` hiçbir yerde tanımlanmamalıdır. Kaynak üreteci #if yönergelerinde bu sembolü tarar.

`SYNC_ONLY` bloğu içindeki kod olduğu gibi kopyalanır. Projede global ad alanları kullanılmıyorsa, bu kod tam nitelikli ad alanları içermelidir.

Aşağıdaki sözdizimi:

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
public async Task WithSyncOnlyDirectiveAsync(CancellationToken ct)
{
#if SYNC_ONLY
    System.Console.Write("Sync");
#endif
    await Task.CompletedTask;
}
```

şunu üretir:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Eğer sadece orijinal async sürümünde çalıştırmak isterseniz, bayrağı şöyle tersine çevirebilirsiniz: `#if !SYNC_ONLY`.

Not: `SYNC_ONLY` başka sembollerle koşullu bir ifadede birleştirilemez ve `#elif` yönergesiyle birlikte kullanılamaz.

## Kurulum

Kütüphaneyi eklemek için şunu kullanın:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Geliştirme

### İlgili Projeler

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Bir metodun senkron ve asenkron sürümleri arasında geçiş yapmanızı sağlar. Bu kütüphanenin geliştirilmesinde çok faydalıdır.

### Act

Bu proje [act](https://github.com/nektos/act) ile tamamen uyumludur.

`act`'i çalıştırmak için gereken paketler dışında, GitHub Actions betiği eksik olabilecek her şeyi kurar; örneğin node, yarn ve dotnet. Windows platformunda, yazılım kurulumu [kapsayıcı desteği eksikliği](https://github.com/nektos/act/issues/1608) nedeniyle doğrudan ana makinede yapılır.

Projeyi act ile derlemek için aşağıdaki talimatları izleyin:

#### Windows

[Chocolatey](https://chocolatey.org/install) yüklü değilse kurun.

Aşağıdaki paketler yüklü değilse kurun:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Proje dizininde şunu çalıştırın:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Bu [talimatları](https://lindevs.com/install-act-on-ubuntu) izleyerek act'i kurun.

Proje dizininde şunu çalıştırın:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---