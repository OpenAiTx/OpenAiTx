# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

この [.NET ソースジェネレーター](https://learn.microsoft.com/ja-jp/dotnet/csharp/roslyn-sdk/source-generators-overview) は、非同期メソッドから同期メソッドを生成します。

## ユースケース

- ライブラリがメソッドの同期版と非同期版の両方を公開したい場合
- アプリケーションが同じ方法で2種類のデータを処理する必要がある場合：
  - I/Oからの大容量データで、処理前にメモリに保持できない場合：元の非同期メソッド
  - メモリ上の小規模データ、通常は大容量データのサンプル：生成された同期メソッド

## 仕組み

### CreateSyncVersionAttribute

`partial` クラス、構造体、またはレコード内の非同期メソッドに `CreateSyncVersionAttribute` を付与します。

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

これにより、同期版のメソッドが生成されます：

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

新しく生成された同期メソッドに適用される変更一覧：

- async 修飾子を削除
- メソッドや `foreach` 文から await を削除
- 型の変換

  | 変換元                                                                                                                                                                                                | 変換先                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/ja-jp/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/ja-jp/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/ja-jp/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/ja-jp/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.valuetask) も [Task](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task) と同じように扱われます
- 以下のパラメーターを削除
  - [CancellationToken](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.iprogress-1)
- 呼び出しの変更
  - [Tasks](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.configureawait) や [非同期列挙](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait) の `ConfigureAwait` を削除
  - [Tasks](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.waitasync) の `WaitAsync` を削除
  - [WithCancellation](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation) を削除
  - `Async` サフィックスの付いた非同期呼び出しを同期版呼び出しに書き換え（例：[MoveNextAsync()](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) → [MoveNext()](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.ienumerator.movenext)）
  - `Async` サフィックスのない非同期呼び出しを削除
  - [CancellationToken](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.cancellationtoken) パラメータを削除
  - [IProgress\<T>.Report(T)](https://learn.microsoft.com/ja-jp/dotnet/api/system.iprogress-1.report) 呼び出しを削除
  - [Memory\<T>.Span](https://learn.microsoft.com/ja-jp/dotnet/api/system.memory-1.span) プロパティを削除
  - `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.fromresult)(`value`) を `value` に変換
  - `await` [Task.Delay](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.tasks.task.delay)(`value`) を [Thread.Sleep](https://learn.microsoft.com/ja-jp/dotnet/api/system.threading.thread.sleep)(`value`) に変換
  - [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/ja-jp/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) を返す呼び出しは [IEnumerable.GetEnumerator](https://learn.microsoft.com/ja-jp/dotnet/api/system.collections.ienumerable.getenumerator)() に変換
- `CreateSyncVersionAttribute` を削除
- XML ドキュメントを更新

#### プロパティ

##### OmitNullableDirective

このソースジェネレーターはコンパイル時に言語バージョンを検出します。デフォルトでは、言語バージョンが 8 以上の場合に限り `#nullable enable` ディレクティブを生成します。nullable コンテキストが有効かどうかを確実に判断することは[不可能](https://github.com/dotnet/roslyn/issues/49555)なため、`OmitNullableDirective` プロパティを指定することでこのディレクティブの生成を省略できます。

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY シンボル

メソッドの同期版でのみ実行したい処理がある場合は、`SYNC_ONLY` の #if ディレクティブで囲みます。

`SYNC_ONLY` はどこにも定義してはいけません。ソースジェネレーターはこのシンボルが使われている #if ディレクティブを検出します。

`SYNC_ONLY` ブロック内のコードはそのままコピーされます。プロジェクトでグローバル名前空間を使用していない限り、このコードには完全修飾名前空間を含めるべきです。

以下のような記述：

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

は、以下のように出力されます：

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

元の非同期版のみで実行したい場合は、このようにフラグを反転させます：`#if !SYNC_ONLY`。

注意：`SYNC_ONLY` は条件式で他のシンボルと組み合わせたり、`#elif` ディレクティブを持つことはできません。

## インストール

ライブラリの追加方法：

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## 開発

### 関連プロジェクト

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - メソッドの同期版と非同期版を切り替える拡張機能。本ライブラリの開発時に非常に便利です。

### Act

このプロジェクトは [act](https://github.com/nektos/act) と完全互換です。

`act` の実行に必要なパッケージ以外にも、GitHub Actions スクリプトは node、yarn、dotnet など不足しているものを自動インストールします。Windows プラットフォームでは、[コンテナ非対応](https://github.com/nektos/act/issues/1608)のためホスト上でソフトウェアのインストールが行われます。

act でプロジェクトをビルドするには以下の手順に従ってください：

#### Windows

[chocolatey](https://chocolatey.org/install) をインストールします（未インストールの場合）。

以下のパッケージが未インストールの場合はインストールします：

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

プロジェクトディレクトリで実行：

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

[こちらの手順](https://lindevs.com/install-act-on-ubuntu)に従って act をインストールします。

プロジェクトディレクトリで実行：

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---