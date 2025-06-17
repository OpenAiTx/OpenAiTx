# تولیدکننده متد همگام (Sync Method Generator)

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![پشتیبانی از .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

این [تولیدکننده سورس .NET](https://learn.microsoft.com/fa-ir/dotnet/csharp/roslyn-sdk/source-generators-overview) یک متد همگام از یک متد ناهمگام تولید می‌کند.

## موارد استفاده

- کتابخانه‌ای که هر دو نسخه همگام و ناهمگام یک متد را ارائه می‌دهد
- یک برنامه باید دو نوع داده را به یک شکل پردازش کند:
  - داده‌های حجیم از I/O که نمی‌توان قبل از پردازش در حافظه ذخیره کرد: متد ناهمگام اصلی
  - نمونه کوچک داده در حافظه، معمولاً نمونه‌ای از داده‌های بزرگ‌تر: متد همگام تولید شده

## نحوه عملکرد

### CreateSyncVersionAttribute

متد ناهمگام خود را در کلاس، ساختار یا رکورد `partial` با `CreateSyncVersionAttribute` تزئین کنید.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

و نسخه همگام متد به صورت زیر تولید خواهد شد:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

فهرست تغییرات اعمال شده به متد همگام جدید:

- حذف مبدل async
- حذف await از متدها و همچنین عبارت `foreach`
- تغییر نوع‌ها

  | از                                                                                                                                                                                                | به                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/fa-ir/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/fa-ir/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/fa-ir/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/fa-ir/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.valuetask)ها دقیقاً مانند [Task](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task)ها مدیریت می‌شوند
- حذف پارامترها
  - [CancellationToken](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.iprogress-1)
- تغییرات فراخوانی
  - حذف `ConfigureAwait` از [Taskها](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task.configureawait) و [Enumerationهای ناهمگام](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)
  - حذف `WaitAsync` از [Taskها](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task.waitasync)
  - حذف [WithCancellation](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation)
  - بازنویسی فراخوانی‌های ناهمگام با پسوند `Async` برای فراخوانی نسخه همگام (مثال: [MoveNextAsync()](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) به [MoveNext()](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.ienumerator.movenext) تبدیل می‌شود)
  - حذف فراخوانی‌های ناهمگام بدون پسوند `Async`
  - حذف پارامتر [CancellationToken](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.cancellationtoken)
  - حذف فراخوانی [IProgress\<T>.Report(T)](https://learn.microsoft.com/fa-ir/dotnet/api/system.iprogress-1.report)
  - حذف ویژگی [Memory\<T>.Span](https://learn.microsoft.com/fa-ir/dotnet/api/system.memory-1.span)
  - تبدیل `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task.fromresult)(`value`) به `value`
  - تبدیل `await` [Task.Delay](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.tasks.task.delay)(`value`) به [Thread.Sleep](https://learn.microsoft.com/fa-ir/dotnet/api/system.threading.thread.sleep)(`value`)
  - تبدیل هر فراخوانی که [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/fa-ir/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) برمی‌گرداند به [IEnumerable.GetEnumerator](https://learn.microsoft.com/fa-ir/dotnet/api/system.collections.ienumerable.getenumerator)()
- حذف `CreateSyncVersionAttribute`
- به‌روزرسانی مستندات XML

#### ویژگی‌ها

##### OmitNullableDirective

این تولیدکننده سورس نسخه زبان را هنگام کامپایل تشخیص می‌دهد. به طور پیش‌فرض، اگر و فقط اگر نسخه زبان ۸ یا بالاتر باشد، دستور `#nullable enable` را ایجاد می‌کند. از آنجا که [غیرممکن](https://github.com/dotnet/roslyn/issues/49555) است که به طور قابل اعتماد تشخیص داد زمینه nullable فعال است یا نه، ویژگی `OmitNullableDirective` برای حذف آن دستور فراهم شده است.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### نماد SYNC_ONLY

در صورتی که منطقی دارید که فقط باید در نسخه همگام متد اجرا شود، آن را در دستور #if با SYNC_ONLY قرار دهید.

`SYNC_ONLY` نباید در هیچ جایی تعریف شده باشد. تولیدکننده سورس نمادها را در دستورات #if بررسی می‌کند.

کد داخل بلوک SYNC_ONLY عیناً کپی می‌شود. مگر اینکه فضای نام سراسری در پروژه استفاده شده باشد، این کد باید شامل فضای نام‌های کامل باشد.

سینتکس زیر:

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

خروجی زیر را خواهد داد:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

اگر فقط می‌خواهید در نسخه ناهمگام اصلی اجرا شود، پرچم را به این صورت قرار دهید: `#if !SYNC_ONLY`.

توجه: `SYNC_ONLY` نباید با نمادهای دیگر در عبارت شرطی ترکیب شود و نمی‌تواند دستور `#elif` داشته باشد.

## نصب

برای افزودن کتابخانه از دستور زیر استفاده کنید:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## توسعه

### پروژه‌های مرتبط

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - امکان جابجایی بین نسخه‌های همگام و ناهمگام یک متد را فراهم می‌کند. در توسعه این کتابخانه بسیار مفید است.

### act

این پروژه کاملاً با [act](https://github.com/nektos/act) سازگار است.

علاوه بر بسته‌های مورد نیاز برای اجرای خود act، اسکریپت GitHub Actions هر نرم‌افزاری که ممکن است کم باشد را نصب می‌کند، مانند node، yarn و dotnet. در پلتفرم ویندوز، نصب نرم‌افزار روی خود میزبان انجام می‌شود به دلیل [کمبود](https://github.com/nektos/act/issues/1608) پشتیبانی از کانتینر.

برای ساخت پروژه با استفاده از act، دستورالعمل‌های زیر را دنبال کنید:

#### ویندوز

در صورت نبود [chocolatey](https://chocolatey.org/install) آن را نصب کنید.

بسته‌های زیر را در صورت نبود نصب کنید:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

در دایرکتوری پروژه اجرا کنید:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### لینوکس

act را با دنبال کردن این [دستورالعمل‌ها](https://lindevs.com/install-act-on-ubuntu) نصب کنید.

در دایرکتوری پروژه اجرا کنید:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---