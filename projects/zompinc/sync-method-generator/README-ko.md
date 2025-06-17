# Sync Method Generator

[![Build](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml/badge.svg)](https://github.com/zompinc/sync-method-generator/actions/workflows/build.yml)
![Support .NET Standard 2.0](https://img.shields.io/badge/dotnet%20version-.NET%20Standard%202.0-blue)
[![Nuget](https://img.shields.io/nuget/v/Zomp.SyncMethodGenerator)](https://www.nuget.org/packages/Zomp.SyncMethodGenerator)
[![codecov](https://codecov.io/gh/zompinc/sync-method-generator/branch/master/graph/badge.svg)](https://codecov.io/gh/zompinc/sync-method-generator)

이 [.NET 소스 생성기](https://learn.microsoft.com/ko-kr/dotnet/csharp/roslyn-sdk/source-generators-overview)는 비동기 메서드에서 동기 메서드를 생성합니다.

## 사용 사례

- 동기 및 비동기 버전의 메서드를 모두 제공하는 라이브러리
- 애플리케이션이 동일한 방식으로 두 종류의 데이터를 처리해야 하는 경우:
  - 메모리에 저장할 수 없는 대용량 I/O 데이터: 원래의 비동기 메서드
  - 메모리 내의 소량 샘플 데이터, 일반적으로 대용량 데이터의 샘플: 생성된 동기 메서드

## 작동 방식

### CreateSyncVersionAttribute

`partial` 클래스, 구조체 또는 레코드 내에서 비동기 메서드에 `CreateSyncVersionAttribute`를 데코레이트합니다.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion]
static async Task WriteAsync(ReadOnlyMemory<byte> buffer, Stream stream, 
CancellationToken ct)
    => await stream.WriteAsync(buffer, ct).ConfigureAwait(true);
```

그러면 아래와 같이 동기 버전 메서드가 생성됩니다:

```cs
static void Write(ReadOnlySpan<byte> buffer, Stream stream)
    => stream.Write(buffer);
```

새롭게 동기화된 메서드에 적용되는 변경 사항 목록:

- async 한정자 제거
- 메서드 및 `foreach` 문에서 await 제거
- 타입 변경

  | From                                                                                                                                                                                                | To                                                                                                                                   |
  | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------------------ |
  | [Task](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task)*                                                                                                                   | void                                                                                                                                 |
  | [Task\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task-1)                                                                                                              | T                                                                                                                                    |
  | [Func](https://learn.microsoft.com/ko-kr/dotnet/api/system.func-1)\<Task>                                                                                                                           | [Action](https://learn.microsoft.com/ko-kr/dotnet/api/system.action)                                                                 |
  | Func\<Task\<T>>                                                                                                                                                                                     | Func\<T>                                                                                                                             |
  | [IAsyncEnumerable\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.iasyncenumerable-1)                                                                                  | [IEnumerable\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerable-1)                             |
  | [IAsyncEnumerator\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.iasyncenumerator-1)                                                                                  | [IEnumerator\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.Enumerator](https://learn.microsoft.com/ko-kr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.enumerator)                 | [IEnumerator\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerator-1)                             |
  | [ConfiguredCancelableAsyncEnumerable\<T>.GetAsyncEnumerator](https://learn.microsoft.com/ko-kr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1.getasyncenumerator) | [IEnumerable\<T>.GetEnumerator](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.ienumerable-1.getenumerator) |
  | [Memory\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.memory-1)                                                                                                                          | [Span\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.span-1)                                                               |
  | [ReadOnlyMemory\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.readonlymemory-1)                                                                                                          | [ReadOnlySpan\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.readonlyspan-1)                                               |
- \* [ValueTask](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.valuetask)는 [Task](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task)와 동일하게 처리됩니다.
- 파라미터 제거
  - [CancellationToken](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.cancellationtoken)
  - [IProgress\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.iprogress-1)
- 호출 변경
  - [Tasks](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task.configureawait) 및 [비동기 열거](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.configureawait)에서 `ConfigureAwait` 제거
  - [Tasks](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task.waitasync)에서 `WaitAsync` 제거
  - [WithCancellation](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.taskasyncenumerableextensions.withcancellation) 제거
  - `Async` 접미사가 붙은 비동기 호출을 동기 버전 호출로 변경 (예: [MoveNextAsync()](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.generic.iasyncenumerator-1.movenextasync) → [MoveNext()](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.ienumerator.movenext))
  - `Async` 접미사가 없는 비동기 호출 제거
  - [CancellationToken](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.cancellationtoken) 파라미터 제거
  - [IProgress\<T>.Report(T)](https://learn.microsoft.com/ko-kr/dotnet/api/system.iprogress-1.report) 호출 제거
  - [Memory\<T>.Span](https://learn.microsoft.com/ko-kr/dotnet/api/system.memory-1.span) 프로퍼티 제거
  - `await` [Task\<TResult>.FromResult](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task.fromresult)(`value`)를 `value`로 변경
  - `await` [Task.Delay](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.tasks.task.delay)(`value`)를 [Thread.Sleep](https://learn.microsoft.com/ko-kr/dotnet/api/system.threading.thread.sleep)(`value`)로 변경
  - [ConfiguredCancelableAsyncEnumerable\<T>](https://learn.microsoft.com/ko-kr/dotnet/api/system.runtime.compilerservices.configuredcancelableasyncenumerable-1)를 반환하는 호출을 [IEnumerable.GetEnumerator](https://learn.microsoft.com/ko-kr/dotnet/api/system.collections.ienumerable.getenumerator)()로 변경
- `CreateSyncVersionAttribute` 제거
- XML 문서화 업데이트

#### 속성

##### OmitNullableDirective

이 소스 생성기는 컴파일 시 언어 버전을 감지합니다. 기본적으로 언어 버전이 8 이상인 경우에만 `#nullable enable` 지시문을 생성합니다. 널 컨텍스트가 활성화되었는지 신뢰성 있게 판단하는 것이 [불가능](https://github.com/dotnet/roslyn/issues/49555)하기 때문에, 해당 지시문 생성을 생략하려면 `OmitNullableDirective` 속성을 사용하면 됩니다.

```cs
[Zomp.SyncMethodGenerator.CreateSyncVersion(OmitNullableDirective = true)]
public async Task MethodAsync()
{
    string f = null;
}
```

### SYNC_ONLY 심볼

동기화된 버전에서만 실행되어야 하는 로직이 있다면, `SYNC_ONLY` #if 지시문 안에 코드를 작성하세요.

`SYNC_ONLY`는 어디에서도 정의되면 안 됩니다. 소스 생성기는 이 심볼에 대해 #if 지시문을 검사합니다.

`SYNC_ONLY` 블록 내의 코드는 그대로 복사됩니다. 글로벌 네임스페이스를 사용하지 않는 한, 이 코드는 완전히 한정된 네임스페이스를 포함해야 합니다.

다음과 같은 문법은:

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

아래와 같이 출력됩니다:

```cs
public void WithSyncOnlyDirective()
{
    System.Console.Write("Sync");
}
```

원래 비동기 버전에서만 실행하고 싶다면, 플래그를 이렇게 반전시키세요: `#if !SYNC_ONLY`.

참고: `SYNC_ONLY`는 조건식 내에서 다른 심볼과 혼합될 수 없으며, `#elif` 지시문을 가질 수 없습니다.

## 설치

라이브러리 추가는 다음을 사용하세요:

```sh
dotnet add package Zomp.SyncMethodGenerator
```

## 개발

### 관련 프로젝트

- [SyncToAsyncExtension](https://marketplace.visualstudio.com/items?itemName=lsoft.SyncToAsyncExtension) - 메서드의 동기/비동기 버전 간 전환을 지원합니다. 이 라이브러리 개발에 매우 유용합니다.

### Act

이 프로젝트는 [act](https://github.com/nektos/act)와 완전히 호환됩니다.

`act` 실행에 필요한 패키지 외에, GitHub Actions 스크립트는 누락된 node, yarn, dotnet 등을 자동으로 설치합니다. Windows 플랫폼에서는 [컨테이너 미지원](https://github.com/nektos/act/issues/1608)으로 인해 호스트 자체에서 소프트웨어를 설치합니다.

act로 프로젝트를 빌드하려면 다음 안내를 따르세요:

#### Windows

[chocolatey](https://chocolatey.org/install)를 설치하세요(없을 경우).

아래 패키지를 설치하세요(없을 경우):

```pwsh
choco install git -y
choco install act-cli -y
refreshenv
```

프로젝트 디렉터리에서 실행:

```pwsh
act -P windows-latest=-self-hosted --artifact-server-path /tmp/artifacts
```

#### Linux

이 [안내](https://lindevs.com/install-act-on-ubuntu)를 따라 act를 설치하세요.

프로젝트 디렉터리에서 실행:

```pwsh
act --artifact-server-path /tmp/artifacts
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---