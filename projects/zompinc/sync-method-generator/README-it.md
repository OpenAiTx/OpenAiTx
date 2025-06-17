# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Questo [generatore di codice sorgente .NET](https://learn.microsoft.com/it-it/dotnet/csharp/roslyn-sdk/source-generators-overview) produce un metodo sincrono a partire da uno asincrono.

## Casi d'uso

- Una libreria che espone sia la versione sincrona che asincrona di un metodo
- Un'applicazione deve processare due tipi di dati nello stesso modo:
  - Dati di grandi dimensioni da I/O che non possono essere memorizzati in memoria prima dell'elaborazione: Metodo asincrono originale
  - Piccolo campione di dati in memoria, solitamente un campione dei dati più grandi: Metodo sincrono generato

## Come funziona

### CreateSyncVersionAttribute

Decora il tuo metodo asincrono con `CreateSyncVersionAttribute` nella tua classe, struct o record `partial`

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

E genererà una versione sincrona del metodo:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Elenco delle modifiche applicate al nuovo metodo sincronizzato:

- Rimozione del modificatore async
- Rimozione di await dai metodi così come dall'istruzione `foreach`
- Cambio dei tipi

  | Da                                                                                                                                                                                                | A                                                                                                                                    |
  | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task)*                                                                                                                 | void                                                                                                                                |
  | [Task\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task-1)                                                                                                            | T                                                                                                                                   |
  | [Func](https://learn.microsoft.com/it-it/dotnet/api/system.func-1)\<Task>                                                                                                                         | [Action](https://learn.microsoft.com/it-it/dotnet/api/system.action)                                                                |
  | Func\<Task\<T>>                                                                                                                                                                                   | Func\<T>                                                                                                                            |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                | [IEnumerable\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.ienumerable-1)                            |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                | [IEnumerator\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.ienumerator-1)                            |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/it-it/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)               | [IEnumerator\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.ienumerator-1)                            |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/it-it/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.memory-1)                                                                                                                        | [Span\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.span-1)                                                              |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.readonlymemory-1)                                                                                                        | [ReadOnlySpan\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.readonlyspan-1)                                              |
- \* [ValueTask](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.valuetask) viene gestito esattamente come [Task](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task)
- Rimozione dei parametri
  - [CancellationToken](https://learn.microsoft.com/it-it/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.iprogress-1)
- Modifiche nelle invocazioni
  - Rimozione di `ConfigureAwait` da [Tasks](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task.configureawait) e [Enumerazioni asincrone](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Rimozione di `WaitAsync` da [Tasks](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task.waitasync)
  - Rimozione di [WithCancellation](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Riscrittura delle invocazioni asincrone con suffisso `Async` per chiamare la versione sincrona (es. [MoveNextAsync()](https://learn.microsoft.com/it-it/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) diventa [MoveNext()](https://learn.microsoft.com/it-it/dotnet/api/system.collections.ienumerator.movenext))
  - Rimozione delle invocazioni asincrone senza suffisso `Async`
  - Rimozione del parametro [CancellationToken](https://learn.microsoft.com/it-it/dotnet/api/system.threading.cancellationtoken)
  - Rimozione della chiamata [IProgress\<T>.Report(T)](https://learn.microsoft.com/it-it/dotnet/api/system.iprogress-1.report)
  - Rimozione della proprietà [Memory\<T>.Span](https://learn.microsoft.com/it-it/dotnet/api/system.memory-1.span)
  - Conversione di `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task.fromresult)(`value`) in `value`
  - Conversione di `await` [Task.Delay](https://learn.microsoft.com/it-it/dotnet/api/system.threading.tasks.task.delay)(`value`) in [Thread.Sleep](https://learn.microsoft.com/it-it/dotnet/api/system.threading.thread.sleep)(`value`)
  - Conversione di qualsiasi invocazione che restituisce [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/it-it/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) in [IEnumerable.GetEnumerator](https://learn.microsoft.com/it-it/dotnet/api/system.collections.ienumerable.getenumerator)()
- Rimozione di `CreateSyncVersionAttribute`
- Aggiornamento della documentazione XML

#### Proprietà

##### OmitNullableDirective

Questo generatore di codice sorgente rileva la versione del linguaggio durante la compilazione. Per impostazione predefinita, genererà la direttiva `#nullable enable` se e solo se la versione del linguaggio è 8 o superiore. Poiché è [impossibile](https://github.com/dotnet/roslyn/issues/49555) determinare in modo affidabile se il contesto nullable è attivato o meno, è disponibile la proprietà `OmitNullableDirective` per omettere la generazione di tale direttiva.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Simbolo SYNC_ONLY

Nel caso in cui ci sia una logica che deve essere eseguita solo nella versione sincronizzata del metodo, racchiudila nella direttiva `SYNC_ONLY` #if.

`SYNC_ONLY` non deve essere definito da nessuna parte. Il generatore di codice sorgente cercherà questa simbolo nelle direttive #if.

Il codice all'interno del blocco `SYNC_ONLY` verrà copiato così com'è. A meno che non vengano usati namespace globali nel progetto, questo codice dovrebbe contenere namespace completamente qualificati.

La seguente sintassi:

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

produrrà:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Se vuoi eseguire solo nella versione asincrona originale, inverti il flag così: `#if !SYNC_ONLY`.

Nota: `SYNC_ONLY` non può essere combinato con altri simboli in un'espressione condizionale e non può avere la direttiva `#elif`.

## Installazione

Per aggiungere la libreria usa:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Sviluppo

### Progetti correlati

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Permette di passare tra versioni sincrone e asincrone di un metodo. Molto utile nello sviluppo di questa libreria.

### Act

Questo progetto è pienamente compatibile con [act](https://github.com/nektos/act).

Oltre ai pacchetti necessari per eseguire `act` stesso, lo script GitHub Actions installa tutto ciò che potrebbe mancare, come node, yarn e dotnet. Su piattaforma Windows, l'installazione del software viene eseguita sull'host stesso a causa della [mancanza](https://github.com/nektos/act/issues/1608) di supporto ai container.

Per compilare il progetto usando act, segui queste istruzioni:

#### Windows

Installa [chocolatey](https://chocolatey.org/install) se manca.

Installa i seguenti pacchetti se mancanti:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Nella directory del progetto esegui:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Installa act seguendo queste [istruzioni](https://lindevs.com/install-act-on-ubuntu).

Nella directory del progetto esegui:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---