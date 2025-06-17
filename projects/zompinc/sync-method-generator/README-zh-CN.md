# 同步方法生成器

[![构建](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![支持 .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

这个[.NET 源代码生成器](https://learn.microsoft.com/zh-cn/dotnet/csharp/roslyn-sdk/source-generators-overview)可以从异步方法生成一个同步方法。

## 使用场景

- 一个库同时暴露方法的同步和异步版本
- 应用程序需要以相同方式处理两类数据：
  - 来自 I/O 的大数据，无法在处理前存储到内存：使用原始的异步方法
  - 内存中的小样本数据，通常是大数据的一个样本：使用生成的同步方法

## 工作原理

### CreateSyncVersionAttribute

在你的 `partial` 类、结构体或记录类型中的异步方法上添加 `CreateSyncVersionAttribute` 特性

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

它将会生成该方法的同步版本：

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

同步方法应用的更改列表：

- 移除 async 修饰符
- 移除方法及 `foreach` 语句中的 await
- 类型更改

  | 从                                                                                                                                                                                                | 到                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/zh-cn/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/zh-cn/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/zh-cn/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/zh-cn/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.valuetask) 的处理方式与 [Task](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task) 完全相同
- 移除以下参数
  - [CancellationToken](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.iprogress-1)
- 调用更改
  - 移除 [Tasks](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task.configureawait) 和 [异步枚举](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait) 的 `ConfigureAwait`
  - 移除 [Tasks](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task.waitasync) 的 `WaitAsync`
  - 移除 [WithCancellation](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - 重写带有 `Async` 后缀的异步调用为同步版本（如 [MoveNextAsync()](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) 变为 [MoveNext()](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.ienumerator.movenext)）
  - 移除没有 `Async` 后缀的异步调用
  - 移除 [CancellationToken](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.cancellationtoken) 参数
  - 移除 [IProgress\<T>.Report(T)](https://learn.microsoft.com/zh-cn/dotnet/api/system.iprogress-1.report) 调用
  - 移除 [Memory\<T>.Span](https://learn.microsoft.com/zh-cn/dotnet/api/system.memory-1.span) 属性
  - 将 `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task.fromresult)(`value`) 替换为 `value`
  - 将 `await` [Task.Delay](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.tasks.task.delay)(`value`) 替换为 [Thread.Sleep](https://learn.microsoft.com/zh-cn/dotnet/api/system.threading.thread.sleep)(`value`)
  - 将任何返回 [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/zh-cn/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) 的调用替换为 [IEnumerable.GetEnumerator](https://learn.microsoft.com/zh-cn/dotnet/api/system.collections.ienumerable.getenumerator)()
- 移除 `CreateSyncVersionAttribute`
- 更新 XML 注释文档

#### 属性

##### OmitNullableDirective

该源代码生成器会在编译期间检测语言版本。默认情况下，如果语言版本为 8 或更高，则会生成 `#nullable enable` 指令。由于[无法](https://github.com/dotnet/roslyn/issues/49555)可靠检测可空上下文是否启用，因此可通过 `OmitNullableDirective` 属性来省略该指令的生成。

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY 符号

如果某些逻辑只应在方法的同步版本中执行，请用 `SYNC_ONLY` 的 #if 指令包裹。

`SYNC_ONLY` 不能在任何地方被定义。源代码生成器会扫描 #if 指令查找该符号。

`SYNC_ONLY` 代码块内的代码将原样复制。除非项目使用了全局命名空间，否则这些代码应写全限定命名空间。

如下语法：

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

将生成：

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

如果你只想在原始异步版本中执行，只需将标志取反，如：`#if !SYNC_ONLY`。

注意：`SYNC_ONLY` 不能与其他符号混合在条件表达式中，也不能使用 `#elif` 指令。

## 安装

添加库请使用：

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## 开发

### 相关项目

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - 允许在方法的同步和异步版本之间切换。在开发本库时非常有用。

### act

本项目完全兼容 [act](https://github.com/nektos/act)。

除运行 `act` 所需的软件包外，GitHub Actions 脚本会安装所有可能缺失的内容，如 node、yarn 以及 dotnet。在 Windows 平台上，由于[缺乏](https://github.com/nektos/act/issues/1608)容器支持，软件会在主机上直接安装。

在 act 下构建项目请按如下操作：

#### Windows

如未安装 [chocolatey](https://chocolatey.org/install)，请先安装。

如未安装以下软件包，请先安装：

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

在项目目录下运行：

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

按[说明](https://lindevs.com/install-act-on-ubuntu)安装 act。

在项目目录下运行：

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---