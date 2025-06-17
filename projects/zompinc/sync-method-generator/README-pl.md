# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Ten [generator źródłowy .NET](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) generuje metodę synchroniczną na podstawie asynchronicznej.

## Przypadki użycia

- Biblioteka udostępniająca zarówno synchroniczną, jak i asynchroniczną wersję metody
- Aplikacja musi przetwarzać dwa rodzaje danych w ten sam sposób:
  - Duże dane z I/O, których nie można przechowywać w pamięci przed przetworzeniem: Oryginalna metoda asynchroniczna
  - Mały próbka danych w pamięci, zwykle próbka większych danych: Wygenerowana metoda synchroniczna

## Jak to działa

### CreateSyncVersionAttribute

Oznacz swoją asynchroniczną metodę atrybutem `CreateSyncVersionAttribute` w swojej klasie, strukturze lub rekordzie oznaczonym jako `partial`

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

I zostanie wygenerowana synchroniczna wersja metody:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Lista zmian zastosowanych do nowej, zsynchronizowanej metody:

- Usunięcie modyfikatora async
- Usunięcie await z metod oraz instrukcji `foreach`
- Zmiana typów

  | Z                                                                                                                                                                                                   | Na                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/en-us/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask) są traktowane dokładnie tak samo jak [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)
- Usunięcie parametrów
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Zmiany wywołań
  - Usunięcie `ConfigureAwait` z [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) oraz [Asynchronous Enumerations](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Usunięcie `WaitAsync` z [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Usunięcie [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Przepisanie asynchronicznych wywołań z sufiksem `Async` na wywołanie wersji synchronicznej (np. [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) staje się [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Usunięcie asynchronicznych wywołań bez sufiksu `Async`
  - Usunięcie parametru [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - Usunięcie wywołania [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Usunięcie właściwości [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - Zmiana `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) na `value`
  - Zmiana `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) na [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Zmiana każdego wywołania zwracającego [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) na [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Usunięcie `CreateSyncVersionAttribute`
- Aktualizacja dokumentacji XML

#### Właściwości

##### OmitNullableDirective

Ten generator źródłowy wykrywa wersję języka podczas kompilacji. Domyślnie wygeneruje dyrektywę `#nullable enable` wtedy i tylko wtedy, gdy wersja języka to 8 lub wyższa. Ponieważ [nie da się](https://github.com/dotnet/roslyn/issues/49555) wiarygodnie określić, czy kontekst nullowalności jest włączony, dostępna jest właściwość `OmitNullableDirective`, aby pominąć generowanie tej dyrektywy.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Symbol SYNC_ONLY

Jeśli istnieje logika, która powinna być wykonywana tylko w zsynchronizowanej wersji metody, należy ją umieścić w dyrektywie `SYNC_ONLY` #if.

`SYNC_ONLY` nie może być zdefiniowany nigdzie. Generator źródłowy przeszuka dyrektywy #if w poszukiwaniu tego symbolu.

Kod wewnątrz bloku `SYNC_ONLY` zostanie skopiowany bez zmian. O ile w projekcie nie są używane przestrzenie nazw globalnych, ten kod powinien zawierać w pełni kwalifikowane przestrzenie nazw.

Poniższa składnia:

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

wygeneruje:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Jeśli chcesz, aby kod był wykonywany tylko w oryginalnej wersji asynchronicznej, odwróć flagę jak poniżej: `#if !SYNC_ONLY`.

Uwaga: `SYNC_ONLY` nie może być łączony z innymi symbolami w wyrażeniu warunkowym i nie może mieć dyrektywy `#elif`.

## Instalacja

Aby dodać bibliotekę, użyj:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Rozwój

### Powiązane projekty

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Umożliwia przełączanie się między synchronicznymi a asynchronicznymi wersjami metody. Bardzo przydatne podczas rozwoju tej biblioteki.

### Act

Ten projekt jest w pełni kompatybilny z [act](https://github.com/nektos/act).

Poza wymaganymi paczkami do uruchomienia samego `act`, skrypt GitHub Actions instaluje wszystko inne, co może być potrzebne, takie jak node, yarn i dotnet. Na platformie Windows instalacja oprogramowania odbywa się na samym hoście z powodu [braku](https://github.com/nektos/act/issues/1608) wsparcia dla kontenerów.

Aby zbudować projekt za pomocą act, postępuj według poniższych instrukcji:

#### Windows

Zainstaluj [chocolatey](https://chocolatey.org/install), jeśli nie jest zainstalowany.

Zainstaluj następujące pakiety, jeśli ich brakuje:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

W katalogu projektu uruchom:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Zainstaluj act, postępując według tych [instrukcji](https://lindevs.com/install-act-on-ubuntu).

W katalogu projektu uruchom:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---