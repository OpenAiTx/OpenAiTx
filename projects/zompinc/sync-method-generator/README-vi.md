# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

Bộ sinh mã nguồn [.NET source generator](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) này tạo ra phương thức đồng bộ từ phương thức bất đồng bộ.

## Trường hợp sử dụng

- Một thư viện cung cấp cả phiên bản đồng bộ và bất đồng bộ của một phương thức
- Một ứng dụng cần xử lý hai loại dữ liệu theo cùng một cách:
  - Dữ liệu lớn từ I/O không thể lưu trữ vào bộ nhớ trước khi xử lý: Phương thức async gốc
  - Mẫu dữ liệu nhỏ trong bộ nhớ, thường là mẫu của dữ liệu lớn hơn: Phương thức sync được sinh ra

## Cách hoạt động

### CreateSyncVersionAttribute

Trang trí phương thức async của bạn với `CreateSyncVersionAttribute` trong class, struct hoặc record `partial` của bạn

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

Và nó sẽ sinh ra phiên bản đồng bộ của phương thức:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

Danh sách các thay đổi được áp dụng cho phương thức đồng bộ mới:

- Loại bỏ từ khóa async
- Loại bỏ await khỏi các phương thức cũng như câu lệnh `foreach`
- Thay đổi kiểu dữ liệu

  | Từ                                                                                                                                                                                                | Thành                                                                                                                                   |
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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s được xử lý giống hệt như [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s
- Loại bỏ tham số
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- Thay đổi lời gọi hàm
  - Loại bỏ `ConfigureAwait` khỏi [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) và [Asynchronous Enumerations](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - Loại bỏ `WaitAsync` khỏi [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync)
  - Loại bỏ [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - Viết lại các lời gọi bất đồng bộ có hậu tố `Async` để gọi phiên bản đồng bộ (ví dụ: [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) thành [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext))
  - Loại bỏ các lời gọi bất đồng bộ không có hậu tố `Async`
  - Loại bỏ tham số [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - Loại bỏ lời gọi [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report)
  - Loại bỏ thuộc tính [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span)
  - Thay thế `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) thành `value`
  - Thay thế `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) thành [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`)
  - Thay đổi bất kỳ lời gọi nào trả về [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) thành [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)()
- Loại bỏ `CreateSyncVersionAttribute`
- Cập nhật tài liệu XML

#### Thuộc tính

##### OmitNullableDirective

Bộ sinh mã nguồn này phát hiện phiên bản ngôn ngữ trong quá trình biên dịch. Theo mặc định, nó sẽ sinh ra chỉ thị `#nullable enable` nếu và chỉ nếu phiên bản ngôn ngữ là 8 trở lên. Vì [không thể](https://github.com/dotnet/roslyn/issues/49555) xác định một cách đáng tin cậy liệu nullable context đã được bật hay chưa, thuộc tính `OmitNullableDirective` được cung cấp để loại bỏ chỉ thị đó khỏi mã sinh ra.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### Ký hiệu SYNC_ONLY

Trong trường hợp có logic chỉ nên được thực thi trong phiên bản đồng bộ của phương thức, hãy bao nó trong chỉ thị `#if SYNC_ONLY`.

`SYNC_ONLY` không được định nghĩa ở bất kỳ đâu. Bộ sinh mã nguồn sẽ quét các chỉ thị #if để tìm ký hiệu này.

Mã bên trong khối `SYNC_ONLY` sẽ được sao chép nguyên trạng. Trừ khi sử dụng global namespace trong dự án, đoạn mã này nên chứa đầy đủ namespace.

Cú pháp sau:

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

sẽ sinh ra:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

Nếu bạn chỉ muốn thực hiện trong phiên bản async gốc, đảo ngược điều kiện như sau: `#if !SYNC_ONLY`.

Lưu ý: `SYNC_ONLY` không được kết hợp với các ký hiệu khác trong biểu thức điều kiện và không được có chỉ thị `#elif`.

## Cài đặt

Để thêm thư viện, sử dụng:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## Phát triển

### Dự án liên quan

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - Cho phép chuyển đổi giữa các phiên bản sync và async của một phương thức. Rất hữu ích khi phát triển thư viện này.

### Act

Dự án này hoàn toàn tương thích với [act](https://github.com/nektos/act).

Ngoài các gói bắt buộc để chạy chính `act`, script GitHub Actions sẽ cài đặt mọi thứ còn thiếu, như node, yarn và dotnet. Trên nền tảng Windows, việc cài đặt phần mềm được thực hiện trực tiếp trên máy chủ do [thiếu](https://github.com/nektos/act/issues/1608) hỗ trợ container.

Để build dự án bằng act, làm theo hướng dẫn sau:

#### Windows

Cài đặt [chocolatey](https://chocolatey.org/install) nếu chưa có.

Cài đặt các gói sau nếu chưa có:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

Trong thư mục dự án, chạy:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

Cài đặt act theo [hướng dẫn này](https://lindevs.com/install-act-on-ubuntu).

Trong thư mục dự án, chạy:

```pwsh
act --artifact-server-path /tmp/artifacts
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---