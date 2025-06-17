# सिंक मेथड जनरेटर

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

यह [.NET स्रोत जनरेटर](https://learn.microsoft.com/en-us/dotnet/csharp/roslyn-sdk/source-generators-overview) एक async मेथड से सिंक मेथड बनाता है।

## उपयोग के मामले

- एक लाइब्रेरी जो किसी मेथड के दोनों सिंक और async वर्शन प्रदान करती है
- एक एप्लिकेशन को एक ही तरह से दो प्रकार के डेटा को प्रोसेस करना है:
  - I/O से बड़े डेटा को प्रोसेस करना जिसे प्रोसेसिंग से पहले मेमोरी में स्टोर नहीं किया जा सकता: मूल async मेथड
  - मेमोरी में छोटे डेटा का सैंपल, आमतौर पर बड़े डेटा का सैंपल: जनरेट किया गया सिंक मेथड

## यह कैसे काम करता है

### CreateSyncVersionAttribute

अपने async मेथड को `CreateSyncVersionAttribute` के साथ अपने `partial` क्लास, स्ट्रक्चर या रिकॉर्ड में सजाएँ

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

और यह मेथड का सिंक वर्शन जनरेट कर देगा:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

नई सिंक्रोनाइज़्ड मेथड पर लागू किए गए परिवर्तनों की सूची:

- async मॉडिफायर हटाएँ
- मेथड्स और `foreach` स्टेटमेंट से await हटाएँ
- टाइप्स बदलें

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
- \* [ValueTask](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask)s को बिलकुल [Task](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task)s की तरह हैंडल किया जाता है
- पैरामीटर्स हटाएँ
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1)
- इनवोकेशन परिवर्तन
  - [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.configureawait) और [Asynchronous Enumerations](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait) से `ConfigureAwait` हटाएँ
  - [Tasks](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.waitasync) से `WaitAsync` हटाएँ
  - [WithCancellation](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation) हटाएँ
  - `Async` उपसर्ग वाली असिंक्रोनस इनवोकेशन को सिंक्रोनस वर्शन से कॉल करने के लिए री-राइट करें (जैसे [MoveNextAsync()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) को [MoveNext()](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerator.movenext) बना दें)
  - बिना `Async` उपसर्ग वाली असिंक्रोनस इनवोकेशन हटा दें
  - [CancellationToken](https://learn.microsoft.com/en-us/dotnet/api/system.threading.cancellationtoken) पैरामीटर हटा दें
  - [IProgress\<T>.Report(T)](https://learn.microsoft.com/en-us/dotnet/api/system.iprogress-1.report) कॉल हटा दें
  - [Memory\<T>.Span](https://learn.microsoft.com/en-us/dotnet/api/system.memory-1.span) प्रॉपर्टी हटा दें
  - `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.fromresult)(`value`) को `value` में बदलें
  - `await` [Task.Delay](https://learn.microsoft.com/en-us/dotnet/api/system.threading.tasks.task.delay)(`value`) को [Thread.Sleep](https://learn.microsoft.com/en-us/dotnet/api/system.threading.thread.sleep)(`value`) में बदलें
  - [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/en-us/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1) रिटर्न करने वाली किसी भी इनवोकेशन को [IEnumerable.GetEnumerator](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable.getenumerator)() में बदलें
- `CreateSyncVersionAttribute` हटाएँ
- XML डाक्यूमेंटेशन अपडेट करें

#### प्रॉपर्टीज़

##### OmitNullableDirective

यह स्रोत जनरेटर संकलन के दौरान भाषा संस्करण का पता लगाता है। डिफ़ॉल्ट रूप से यह `#nullable enable` निर्देश तभी जनरेट करेगा जब भाषा संस्करण 8 या उससे ऊपर हो। चूंकि यह [असंभव](https://github.com/dotnet/roslyn/issues/49555) है कि nullable संदर्भ चालू है या नहीं, इसलिए `OmitNullableDirective` प्रॉपर्टी उपलब्ध है ताकि यह निर्देश जनरेट न हो।

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY सिंबल

यदि कोई लॉजिक है जिसे केवल मेथड के सिंक्रोनाइज़्ड वर्शन में ही चलाना है, तो उसे `SYNC_ONLY` #if डायरेक्टिव में लपेटें।

`SYNC_ONLY` कहीं भी परिभाषित नहीं होना चाहिए। स्रोत जनरेटर #if डायरेक्टिव में इस सिंबल को स्कैन करेगा।

`SYNC_ONLY` ब्लॉक के अंदर का कोड ज्यों का त्यों कॉपी किया जाएगा। जब तक प्रोजेक्ट में ग्लोबल नेमस्पेस का उपयोग नहीं होता, इस कोड में पूरी तरह से क्वालीफाइड नेमस्पेस होने चाहिए।

निम्नलिखित सिंटैक्स:

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

का आउटपुट होगा:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

यदि आप केवल मूल async वर्शन में निष्पादन करना चाहते हैं, तो फ्लैग को ऐसे पलट दें: `#if !SYNC_ONLY`।

नोट: `SYNC_ONLY` को कंडीशनल एक्सप्रेशन में अन्य सिंबल्स के साथ नहीं मिलाया जा सकता और न ही इसमें `#elif` डायरेक्टिव हो सकता है।

## इंस्टॉलेशन

लाइब्रेरी जोड़ने के लिए यह कमांड चलाएँ:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## विकास

### संबंधित प्रोजेक्ट्स

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - किसी मेथड के सिंक और async वर्शन के बीच स्विच करने की सुविधा देता है। इस लाइब्रेरी के विकास में बहुत उपयोगी।

### Act

यह प्रोजेक्ट [act](https://github.com/nektos/act) के साथ पूरी तरह संगत है।

`act` को चलाने के लिए आवश्यक पैकेजों के अलावा, GitHub Actions स्क्रिप्ट कोई भी अन्य आवश्यक सॉफ़्टवेयर इंस्टॉल कर देती है, जैसे node, yarn और dotnet। विंडोज़ प्लेटफ़ॉर्म पर, सॉफ़्टवेयर इंस्टॉलेशन होस्ट पर ही किया जाता है क्योंकि [container support की कमी](https://github.com/nektos/act/issues/1608) है।

प्रोजेक्ट को act से बनाने के लिए ये निर्देश पालन करें:

#### Windows

यदि [chocolatey](https://chocolatey.org/install) नहीं है तो इंस्टॉल करें।

यदि ये पैकेज नहीं हैं तो इंस्टॉल करें:

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

प्रोजेक्ट डायरेक्टरी में चलाएँ:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

इन [निर्देशों](https://lindevs.com/install-act-on-ubuntu) का पालन कर act इंस्टॉल करें।

प्रोजेक्ट डायरेक्टरी में चलाएँ:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---