# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

這個 [.NET 原始碼產生器](https://learn.microsoft.com/zh-tw/dotnet/csharp/roslyn-sdk/source-generators-overview) 可以根據 async 方法產生同步方法。

## 使用情境

- 函式庫需同時公開同步與非同步版本的方法
- 應用程式需要以相同方式處理兩種資料：
  - 來自 I/O 的大數據，無法事先載入記憶體：原始 async 方法
  - 記憶體中的小型資料樣本，通常是大數據的樣本：產生的同步方法

## 工作原理

### CreateSyncVersionAttribute

在你的 `partial` 類別、結構或紀錄的 async 方法上標註 `CreateSyncVersionAttribute`

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

它將自動產生對應的同步版本方法：

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

對新產生的同步方法應用的變更列表：

- 移除 async 修飾詞
- 從方法與 `foreach` 陳述式中移除 await
- 型別轉換

  | 原始                                                                                                                                                                                                | 轉換後                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/zh-tw/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/zh-tw/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/zh-tw/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/zh-tw/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.valuetask) 會與 [Task](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task) 一樣處理
- 移除參數
  - [CancellationToken](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.iprogress-1)
- 呼叫方式變更
  - 從 [Tasks](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task.configureawait) 及 [非同步列舉](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait) 移除 `ConfigureAwait`
  - 從 [Tasks](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task.waitasync) 移除 `WaitAsync`
  - 移除 [WithCancellation](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - 將帶有 `Async` 字尾的非同步呼叫改寫成對應同步呼叫（例如 [MoveNextAsync()](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) 改為 [MoveNext()](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.ienumerator.movenext)）
  - 移除沒有 `Async` 字尾的非同步呼叫
  - 移除 [CancellationToken](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.cancellationtoken) 參數
  - 移除 [IProgress\<T>.Report(T)](https://learn.microsoft.com/zh-tw/dotnet/api/system.iprogress-1.report) 呼叫
  - 移除 [Memory\<T>.Span](https://learn.microsoft.com/zh-tw/dotnet/api/system.memory-1.span) 屬性
  - 將 `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task.fromresult)(`value`) 改為 `value`
  - 將 `await` [Task.Delay](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.tasks.task.delay)(`value`) 改為 [Thread.Sleep](https://learn.microsoft.com/zh-tw/dotnet/api/system.threading.thread.sleep)(`value`)
  - 任何回傳 [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/zh-tw/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) 的呼叫改為 [IEnumerable.GetEnumerator](https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.ienumerable.getenumerator)()
- 移除 `CreateSyncVersionAttribute`
- 更新 XML 文件註解

#### 屬性

##### OmitNullableDirective

此原始碼產生器會在編譯時偵測語言版本。預設情況下，當語言版本為 8 或以上，才會產生 `#nullable enable` 指令。由於[無法](https://github.com/dotnet/roslyn/issues/49555)可靠判斷是否啟用 nullable context，因此提供 `OmitNullableDirective` 屬性可略過產生該指令。

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY 符號

若有邏輯只需在同步版本執行，請使用 `SYNC_ONLY` #if 指令包裹。

`SYNC_ONLY` 不可於任何地方定義。原始碼產生器會掃描 #if 指令找尋此符號。

`SYNC_ONLY` 區塊內的程式碼會直接複製過去。除非專案中有使用 global namespace，否則這段程式碼應包含完整命名空間。

以下語法：

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

會產生：

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

若只想在原始 async 版本執行，請這樣反向使用：`#if !SYNC_ONLY`。

注意：`SYNC_ONLY` 不能與其他符號組合判斷，也不能有 `#elif` 指令。

## 安裝

新增此函式庫請執行：

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## 開發

### 相關專案

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - 可在同步與非同步方法間切換。對本函式庫開發非常實用。

### Act

本專案完全相容於 [act](https://github.com/nektos/act)。

除了 act 本身所需的套件外，GitHub Actions 腳本會安裝任何可能遺漏的依賴，例如 node、yarn 和 dotnet。在 Windows 平台上，因[缺乏](https://github.com/nektos/act/issues/1608)容器支援，軟體會直接安裝於主機上。

若要用 act 編譯本專案請依下列步驟：

#### Windows

若未安裝 [chocolatey](https://chocolatey.org/install)，請先安裝。

若未安裝下列套件，請安裝：

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

進入專案目錄後執行：

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

依照這些[說明](https://lindevs.com/install-act-on-ubuntu)安裝 act。

進入專案目錄後執行：

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---