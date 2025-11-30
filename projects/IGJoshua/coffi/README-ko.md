# coffi
[![Clojars Project](https://img.shields.io/clojars/v/org.suskalo/coffi.svg)](https://clojars.org/org.suskalo/coffi)
[![cljdoc badge](https://cljdoc.org/badge/org.suskalo/coffi)](https://cljdoc.org/d/org.suskalo/coffi)

Coffi는 JDK 22 이상에서 [Foreign Function & Memory API](https://openjdk.org/jeps/454)를 사용하는 Clojure용 외부 함수 인터페이스 라이브러리입니다.  
이는 JNI처럼 라이브러리 전용 자바 또는 네이티브 코드를 필요로 하지 않고 Clojure에서 네이티브 코드를 직접 호출할 수 있게 합니다. Coffi는 사용 편의성에 중점을 두어 래퍼를 생성하는 함수와 매크로를 포함하여 네이티브 함수가 마치 Clojure 함수처럼 동작하도록 합니다. 그러나 이는 FF&M API가 제공하는 저수준 접근을 활용하여 데이터 마샬링 비용을 최소화하고 성능 최적화를 위한 시스템을 작성하는 능력을 제한하지 않습니다.

- [시작하기](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/doc/getting-started)
- [API 문서](https://cljdoc.org/d/org.suskalo/coffi/CURRENT/api/coffi)
- [최근 변경사항](https://raw.githubusercontent.com/IGJoshua/coffi/develop/CHANGELOG.md)

## 설치
이 라이브러리는 Clojars에서 사용 가능하며, git 의존성으로도 사용할 수 있습니다.  
다음 항목 중 하나를 `deps.edn`의 `:deps` 키에 추가하세요:








```clojure
org.suskalo/coffi {:mvn/version "1.0.615"}
io.github.IGJoshua/coffi {:git/tag "v1.0.615" :git/sha "7401485"}
```
이 라이브러리를 git 종속성으로 사용할 경우, 라이브러리를 준비해야 합니다.



```sh
$ clj -X:deps prep
```
Coffi는 `java.lang.foreign` 패키지의 사용을 요구하며, 대부분의
작업은 JDK에서 안전하지 않은 것으로 간주되어
명령줄 플래그를 전달하지 않으면 코드에서 사용할 수 없습니다.
coffi를 사용하려면 애플리케이션에 다음 JVM 인수를 추가하세요.


```sh
--enable-native-access=ALL-UNNAMED
```

JVM 인수를 Clojure CLI의 특정 호출에서 지정하려면
다음과 같이 `-J` 플래그를 사용합니다:

``` sh
clj -J--enable-native-access=ALL-UNNAMED
```

`deps.edn` 파일의 `:jvm-opts` 키 아래에 별칭으로 지정할 수도 있습니다(다음 예 참조).
그런 다음 해당 별칭을 사용하여 CLI를 `-M`, `-A` 또는 `-X`와 함께 호출합니다.


``` clojure
{:aliases {:dev {:jvm-opts ["--enable-native-access=ALL-UNNAMED"]}}}
```
다른 빌드 도구들도 문서를 확인하면 유사한 기능을 제공할 것입니다.

실행 가능한 jar 파일을 만들 때, 매니페스트 속성 `Enable-Native-Access: ALL-UNNAMED`를
jar에 추가하면 이 인수를 전달할 필요가 없습니다. 추가 방법은 빌드 도구의 문서를 참고하세요.

Coffi는 또한 린터 clj-kondo를 지원합니다. clj-kondo를 사용 중이고
이 라이브러리의 매크로가 올바르게 린팅되지 않는 경우, 라이브러리와 함께 제공되는
설정을 설치해야 할 수 있습니다. 프로젝트 디렉토리에서 다음 셸 명령어를 실행하여 설치할 수 있습니다:





```sh
$ clj-kondo --copy-configs --dependencies --lint "$(clojure -Spath)"
```

## 사용법
두 개의 주요 네임스페이스는 `coffi.mem`으로, 오프힙 메모리를 할당하고 조작하며 값을 (역)직렬화하는 기능을 제공합니다, 그리고 `coffi.ffi`로, 네이티브 라이브러리를 로드하고 네이티브 함수 래퍼를 선언하며 콜백으로서 함수를 (역)직렬화할 수 있습니다.




```clojure
(require '[coffi.mem :as mem])
(require '[coffi.ffi :as ffi :refer [defcfn]])

(defcfn strlen
  "Given a string, measures its length in bytes."
  strlen [::mem/c-string] ::mem/long)

(strlen "hello")
;; => 5

(ffi/load-system-library "z")
```
`coffi.mem` 네임스페이스에는 C의 모든 부호 있는 원시 숫자형 타입과 `::mem/pointer`, `::mem/c-string` 타입이 있으며,
malli와 유사한 타입 선언을 사용하여 구조체, 공용체, 배열, 열거형, 플래그셋을 정의하는 방법이 포함되어 있습니다.

## 대안들
이 라이브러리는 네이티브 코드에 접근할 수 있는 유일한 클로저 라이브러리가 아닙니다. 
추가로 다음과 같은 라이브러리들이 존재합니다(그 외에도 다수 있음):

- [dtype-next](https://github.com/cnuernber/dtype-next)
- [tech.jna](https://github.com/techascent/tech.jna)
- [clojure-jna](https://github.com/Chouser/clojure-jna)

Dtype-next는 Java 8-15, 17+, 그리고 GraalVM을 지원하지만, 주로 배열 기반 프로그래밍에 집중하며,
데이터를 클로저 네이티브 구조로 마샬링하기보다는 네이티브 쪽 메모리를 유지하는 데 중점을 둡니다.
Java 17+에서는 Foreign Function & Memory API(프로젝트 파나마의 일부로 JDK 22에서 안정화 예정)를 사용하며,
다른 Java 버전에서는 JNA를 사용합니다.

Tech.jna와 clojure-jna는 모두 모든 경우에 JNA 라이브러리를 사용하며, 콜백에 대한 명시적 지원은 제공하지 않습니다.
JNA는 `java.nio.ByteBuffer`를 사용하여 구조체를 값으로 전달하는 것을 허용하며,
두 라이브러리 모두 이 값 전달 방식을 이용해 참조로 API를 호출하는 방법을 제공합니다.

coffi의 또 다른 대안은 JNI를 직접 사용하는 것인데, 이는 JVM에서 네이티브 코드를 래핑하는 가장 오래된 방법입니다.
하지만 네이티브 코드와 자바 코드를 모두 작성해야 한다는 단점이 있으며,
클로저에서만 사용하려는 경우에도 마찬가지입니다.

애플리케이션이 JVM 22 이전 버전에서 실행되어야 한다면,
다른 옵션들을 고려하는 것이 좋습니다. Dtype-next가 네이티브 코드에 대해 가장 견고한 지원을 제공하지만,
단순한 라이브러리를 래핑하는 경우에는 API 표면적이 더 작고 함수 래핑이 더 쉬운 다른 라이브러리들이 더 매력적일 수 있습니다.

또한 클로저용 FFI 옵션에 대한 [서드파티 정리](https://docs.google.com/spreadsheets/d/1ViLHNUgrO2osh2AH0h7MaCaXz8g0UpLbyWojY5f10kk/edit?gid=332155605#gid=332155605)도 있습니다.











## 알려진 문제
프로젝트 작성자는 이 문제들을 인지하고 있으며 향후 릴리스에서 수정할 계획입니다:

- coffi에 의존하는 라이브러리에서 codox로 문서를 생성할 때 아래와 같은 오류가 발생합니다. 임시 해결책으로는 codox 빌드에 명시적으로 insn 0.2.1 버전을 의존성으로 추가하는 것입니다.

  ```
  Unable to find static field: ACC_OPEN in interface org.objectweb.asm.Opcodes
  ```
## 미래 계획
이 기능들은 향후 릴리스에서 계획되어 있습니다.

- va_args 타입 지원
- 데이터 모델 생성을 위한 헤더 파싱 도구? (아마도 [clong](https://github.com/phronmophobic/clong)과 함께 작동 가능?)
- 제네릭 타입 별칭
- 부호 없는 정수 타입
- 출력 인자를 위한 헬퍼 매크로
- defcfn 매크로의 오류 메시지 개선
- 매핑된 메모리
- 더 복합적인 데이터 타입을 위한 사용자 정의 serde 구현용 헬퍼 매크로
- GraalVM Native Image 지원 (FFM 지원이 성숙해지면)

## 라이선스

저작권 © 2023 Joshua Suskalo

Eclipse Public License 버전 1.0에 따라 배포됩니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-30

---