# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Deze [.NET source generator](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) genereert een synchrone methode uit een asynchrone.

## Gebruikssituaties

- Een bibliotheek die zowel een synchrone als asynchrone versie van een methode aanbiedt
- Een applicatie moet twee soorten data op dezelfde manier verwerken:
  - Grote data van I/O die niet vooraf in het geheugen kunnen worden opgeslagen: Originele asynchrone methode
  - Kleine steekproef van data in het geheugen, meestal een sample van de grotere dataset: Gegenereerde synchrone methode

## Hoe het werkt

### CreateSyncVersionAttribute

Voorzie je asynchrone methode van de `CreateSyncVersionAttribute` in je `partial` class, struct of record.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

En het genereert een synchrone versie van de methode:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Een lijst met wijzigingen die op de nieuwe gesynchroniseerde methode worden toegepast:

- Verwijder de async-modifier
- Verwijder await uit methoden en uit `foreach`-statements
- Wijzig types

  | Van                                                                                                                                                                                                | Naar                                                                                                                                    |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------- |
  | [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)*                                                                                                                  | void                                                                                                                                   |
  | [Task\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task-1)                                                                                                             | T                                                                                                                                      |
  | [Func](https://learn.microsoft.com/en-us/dotnet/api/system.func-1)\<Task>                                                                                                                          | [Action](https://learn.microsoft.com/en-us/dotnet/api/system.action)                                                                   |
  | Func\<Task\<T>>                                                                                                                                                                                    | Func\<T>                                                                                                                               |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                 | [IEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1)                               |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                 | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                               |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                | [IEnumerator\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerator-1)                               |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.ienumerable-1.getenumerator)   |
  | [Memory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1)                                                                                                                         | [Span\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.span-1)                                                                 |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlymemory-1)                                                                                                         | [ReadOnlySpan\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.readonlyspan-1)                                                 |
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s worden exact hetzelfde behandeld als [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s
- Verwijder parameters
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Wijzigingen in aanroepen
  - Verwijder `ConfigureAwait` van [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) en [Asynchrone Enumeraties](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Verwijder `WaitAsync` van [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Verwijder [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Herschrijf asynchrone aanroepen met het achtervoegsel `Async` om de synchrone versie aan te roepen (bijv. [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) wordt [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Verwijder asynchrone aanroepen zonder het achtervoegsel `Async`
  - Verwijder de [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) parameter
  - Verwijder aanroep van [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Verwijder [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span) property
  - Wijzig `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) naar `value`
  - Wijzig `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) naar [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Wijzig elke aanroep die [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) retourneert naar [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Verwijder `CreateSyncVersionAttribute`
- Werk XML-documentatie bij

#### Eigenschappen

##### OmitNullableDirective

Deze source generator detecteert de taalversie tijdens het compileren. Standaard genereert deze `#nullable enable` directive als en alleen als de taalversie 8 of hoger is. Omdat het [onmogelijk](https://github.com/dotnet/roslyn/issues/49555) is om betrouwbaar te bepalen of de nullable context aanstaat, is de eigenschap `OmitNullableDirective` beschikbaar om die directive niet te genereren.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY symbool

Als er logica is die alleen in de gesynchroniseerde versie van de methode moet worden uitgevoerd, plaats deze dan binnen de `SYNC_ONLY` #if-directive.

`SYNC_ONLY` mag nergens gedefinieerd zijn. De source generator zal #if-directives op dit symbool scannen.

Code binnen een `SYNC_ONLY`-blok wordt letterlijk overgenomen. Tenzij globale namespaces gebruikt worden in het project, moet deze code volledig gekwalificeerde namespaces bevatten.

De volgende syntax:

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

zal het volgende opleveren:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Wil je alleen uitvoeren in de originele asynchrone versie, draai de vlag dan om: `#if !SYNC_ONLY`.

Let op: `SYNC_ONLY` kan niet gecombineerd worden met andere symbolen in een voorwaarde en mag geen `#elif` directive hebben.

## Installatie

Om de bibliotheek toe te voegen, gebruik:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Ontwikkeling

### Gerelateerde projecten

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Maakt het mogelijk te schakelen tussen sync en async versies van een methode. Erg handig bij de ontwikkeling van deze bibliotheek.

### Act

Dit project is volledig compatibel met [act](https://github.com/nektos/act).

Naast de vereiste pakketten om `act` zelf uit te voeren, installeert het GitHub Actions-script alles wat verder nodig is, zoals node, yarn en dotnet. Op het Windows-platform wordt software op de host zelf geïnstalleerd vanwege het [gebrek](https://github.com/nektos/act/issues/1608) aan container-ondersteuning.

Om het project te bouwen met act, volg deze instructies:

#### Windows

Installeer [chocolatey](https://chocolatey.org/install) indien nodig.

Installeer de volgende pakketten indien nodig:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Voer in de projectdirectory uit:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Installeer act volgens deze [instructies](https://lindevs.com/install-act-on-ubuntu).

Voer in de projectdirectory uit:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---