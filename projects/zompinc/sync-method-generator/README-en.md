# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

This [.NET source generator](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) produces a sync method from an async one.

## Use cases

- A library which exposes both sync and async version of a method
- An application has to process two kinds of data in the same way:
  - Large data from I/O which cannot be stored in memory before processing: Original async method
  - Small sample of data in memory, usually a sample of the larger data: Generated sync method

## How it works

### CreateSyncVersionAttribute

Decorate your async method with `CreateSyncVersionAttribute` in your `partial` class, struct or record

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

And it will generate a sync version of the method:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

A list of changes applied to the new synchronized method:

- Remove async modifier
- Remove await from methods as well as `foreach` statement
- Change types

  | From                                                                                                                                                                                                | To                                                                                                                                   |
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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s are handled exactly like [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s
- Remove parameters
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Invocation changes
  - Remove `ConfigureAwait` from [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) and [Asynchronous Enumerations](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Remove `WaitAsync` from [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Remove [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Rewrite asynchronous invocations with `Async` suffix to call synchronous version (e.g. [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) becomes [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Remove asynchronous invocations without the `Async` suffix
  - Remove [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) parameter
  - Remove [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report) call
  - Remove [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span) property
  - Change `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) to `value`
  - Change `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) to [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Change any invocation returning [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) to [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Remove `CreateSyncVersionAttribute`
- Update XML documentation

#### Properties

##### OmitNullableDirective

This source generator detects language version during the compilation. By default it will generate `#nullable enable` directive if and only if the language version is 8 or above. Since it is [impossible](https://github.com/dotnet/roslyn/issues/49555) to reliably determine whether nullable context is turned on or not, `OmitNullableDirective` property is available to omit that directive from generating.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY symbol

In case there is logic which should only be executed in the synchronized version of the method, wrap it in `SYNC_ONLY` #if directive.

`SYNC_ONLY` must not be defined anywhere. The source generator will scan #if directives for this symbol.

Code inside `SYNC_ONLY` block will be copied as is. Unless global namespaces are used in the project, this code should contain fully qualified namespaces.

The following syntax:

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

will output:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

If you only want to execute in the original async version, flip the flag like this: `#if !SYNC_ONLY`.

Note: `SYNC_ONLY` cannot be mixed with other symbols in a conditional expression and cannot have `#elif` directive.

## Installation

To add the library use:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Development

### Related projects

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Allows switching between sync and async versions of a method. Very useful in development of this library.

### Act

This project is fully compatible with [act](https://github.com/nektos/act).

Other than required packages to run `act` itself, GitHub Actions script installs anything else that might be missing, such as node, yarn and dotnet. On Windows platform, software installation is performed on the host itself due to [lack](https://github.com/nektos/act/issues/1608) of container support.

To build the project using act follow these instructions:

#### Windows

Install [chocolatey](https://chocolatey.org/install) if missing.

Install the following packages if missing:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

In the project directory run:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Install act by following these [instructions](https://lindevs.com/install-act-on-ubuntu).

In the project directory run:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---