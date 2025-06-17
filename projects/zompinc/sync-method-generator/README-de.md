# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Dieser [.NET Source Generator](https://learn.microsoft.com/de-de/dotnet/csharp/roslyn-sdk/source-generators-overview) erzeugt aus einer asynchronen Methode eine synchrone Methode.

## Anwendungsfälle

- Eine Bibliothek, die sowohl synchrone als auch asynchrone Versionen einer Methode bereitstellt
- Eine Anwendung muss zwei Arten von Daten auf die gleiche Weise verarbeiten:
  - Große Datenmengen aus I/O, die vor der Verarbeitung nicht im Speicher gehalten werden können: Originale asynchrone Methode
  - Kleine Datenproben im Speicher, meist eine Stichprobe der größeren Daten: Generierte synchrone Methode

## Funktionsweise

### CreateSyncVersionAttribute

Dekorieren Sie Ihre asynchrone Methode mit `CreateSyncVersionAttribute` in Ihrer `partial`-Klasse, Struktur oder Record.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Und es wird eine synchrone Version der Methode generiert:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Eine Liste der an der neuen synchronisierten Methode vorgenommenen Änderungen:

- Entfernen des async-Modifizierers
- Entfernen von await aus Methoden sowie aus `foreach`-Anweisungen
- Typänderungen

  | Von                                                                                                                                                                                                | Zu                                                                                                                                    |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------- |
  | [Task](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task)*                                                                                                                  | void                                                                                                                                  |
  | [Task\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task-1)                                                                                                             | T                                                                                                                                     |
  | [Func](https://learn.microsoft.com/de-de/dotnet/api/system.func-1)\<Task>                                                                                                                          | [Action](https://learn.microsoft.com/de-de/dotnet/api/system.action)                                                                  |
  | Func\<Task\<T>>                                                                                                                                                                                    | Func\<T>                                                                                                                              |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                 | [IEnumerable\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerable-1)                              |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                 | [IEnumerator\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerator-1)                              |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/de-de/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                | [IEnumerator\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerator-1)                              |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/de-de/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.ienumerable-1.getenumerator)  |
  | [Memory\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.memory-1)                                                                                                                         | [Span\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.span-1)                                                                |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.readonlymemory-1)                                                                                                         | [ReadOnlySpan\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.readonlyspan-1)                                                |
- \* [ValueTask](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.valuetask)s werden genauso behandelt wie [Task](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task)s
- Entfernen von Parametern
  - [CancellationToken](https://learn.microsoft.com/de-de/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.iprogress-1)
- Änderungen bei Aufrufen
  - Entfernen von `ConfigureAwait` bei [Tasks](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task.configureawait) und [Asynchronen Enumerationen](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Entfernen von `WaitAsync` bei [Tasks](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task.waitasync)
  - Entfernen von [WithCancellation](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Umschreiben asynchroner Aufrufe mit `Async`-Suffix, sodass die synchrone Version aufgerufen wird (z.B. [MoveNextAsync()](https://learn.microsoft.com/de-de/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) wird zu [MoveNext()](https://learn.microsoft.com/de-de/dotnet/api/system.collections.ienumerator.movenext))
  - Entfernen asynchroner Aufrufe ohne das `Async`-Suffix
  - Entfernen des [CancellationToken](https://learn.microsoft.com/de-de/dotnet/api/system.threading.cancellationtoken)-Parameters
  - Entfernen des Aufrufs von [IProgress\<T>.Report(T)](https://learn.microsoft.com/de-de/dotnet/api/system.iprogress-1.report)
  - Entfernen der Eigenschaft [Memory\<T>.Span](https://learn.microsoft.com/de-de/dotnet/api/system.memory-1.span)
  - Ändern von `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task.fromresult)(`value`) zu `value`
  - Ändern von `await` [Task.Delay](https://learn.microsoft.com/de-de/dotnet/api/system.threading.tasks.task.delay)(`value`) zu [Thread.Sleep](https://learn.microsoft.com/de-de/dotnet/api/system.threading.thread.sleep)(`value`)
  - Jede Rückgabe von [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/de-de/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) wird zu [IEnumerable.GetEnumerator](https://learn.microsoft.com/de-de/dotnet/api/system.collections.ienumerable.getenumerator)()
- Entfernen des `CreateSyncVersionAttribute`
- Aktualisieren der XML-Dokumentation

#### Eigenschaften

##### OmitNullableDirective

Dieser Source Generator erkennt die Sprachversion während der Kompilierung. Standardmäßig wird die Direktive `#nullable enable` nur dann generiert, wenn die Sprachversion 8 oder höher ist. Da es [unmöglich](https://github.com/dotnet/roslyn/issues/49555) ist, zuverlässig zu erkennen, ob der Nullable-Kontext aktiviert ist oder nicht, steht die Eigenschaft `OmitNullableDirective` zur Verfügung, um das Generieren dieser Direktive zu unterdrücken.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY-Symbol

Falls es Logik gibt, die nur in der synchronisierten Version der Methode ausgeführt werden soll, kapseln Sie diese in eine `SYNC_ONLY`-#if-Direktive.

`SYNC_ONLY` darf nirgendwo definiert sein. Der Source Generator durchsucht #if-Direktiven nach diesem Symbol.

Code innerhalb des `SYNC_ONLY`-Blocks wird unverändert übernommen. Sofern keine globalen Namespaces im Projekt verwendet werden, sollte dieser Code vollständig qualifizierte Namespaces enthalten.

Folgende Syntax:

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

ergibt:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Wenn Sie etwas nur in der ursprünglichen asynchronen Version ausführen möchten, kehren Sie das Flag so um: `#if !SYNC_ONLY`.

Hinweis: `SYNC_ONLY` darf nicht mit anderen Symbolen in einem bedingten Ausdruck kombiniert werden und es darf keine `#elif`-Direktive geben.

## Installation

Um die Bibliothek hinzuzufügen, verwenden Sie:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Entwicklung

### Verwandte Projekte

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) – Ermöglicht das Umschalten zwischen synchronen und asynchronen Versionen einer Methode. Sehr nützlich bei der Entwicklung dieser Bibliothek.

### Act

Dieses Projekt ist vollständig kompatibel mit [act](https://github.com/nektos/act).

Abgesehen von den für `act` selbst erforderlichen Paketen installiert das GitHub Actions-Skript alles weitere, was evtl. fehlt, wie node, yarn und dotnet. Auf Windows-Plattformen erfolgt die Softwareinstallation auf dem Host selbst aufgrund des [fehlenden](https://github.com/nektos/act/issues/1608) Container-Supports.

Um das Projekt mit act zu bauen, folgen Sie diesen Anweisungen:

#### Windows

Installieren Sie [chocolatey](https://chocolatey.org/install), falls nicht vorhanden.

Installieren Sie die folgenden Pakete, falls nicht vorhanden:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Im Projektverzeichnis führen Sie aus:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Installieren Sie act, indem Sie diesen [Anweisungen](https://lindevs.com/install-act-on-ubuntu) folgen.

Im Projektverzeichnis führen Sie aus:

```pwsh
act --artifact-server-path /tmp/artifacts
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---