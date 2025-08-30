# Sord

## 개요

Sord는 [**So**rbet](https://sorbet.org)와 [YA**RD**](https://yardoc.org/)의  
크로스오버입니다. YARD 문서 주석에 지정된 **타입을 보고**  
**RBI 및 RBS 타입 시그니처 파일을 자동으로 생성할 수 있습니다**.

프로젝트가 이미 YARD 문서화되어 있다면, 필요한 대부분의  
타입 시그니처를 생성할 수 있습니다!

Sord는 Sorbet의 RBI 형식을 사용하든 Ruby 3/Steep의 RBS 형식을 사용하든  
프로젝트에서 타입 도입을 시작하는 완벽한 방법입니다.

**온라인에서 Sord를 사용해 보세요: [sord.aaronc.cc](https://sord.aaronc.cc)**

Sord는 다음과 같은 기능을 제공합니다:  
  - 모듈, 클래스 및 메서드에 대한 시그니처 자동 생성  
  - 여러 매개변수 또는 반환 타입 지원 (`T.any`/`|`)  
  - 누락된 YARD 타입을 우아하게 처리 (`T.untyped`/`untyped`)  
  - 대응하는 게터의 반환 타입에서 세터 매개변수 타입 추론 가능  
  - 믹스인(`include` 및 `extend`) 인식  
  - `Array<T>`, `Hash<K, V>`와 같은 제네릭 타입 지원  
  - 네임스페이스 클래스 추론 가능 (`[Bar]`는 `GemName::Foo::Bar`가 될 수 있음)  
  - `nil`일 수 있는 반환 타입 처리 (`T.nilable`/`untyped`)  
  - 덕 타임 처리 (`T.untyped`/`untyped`)  
  - 순서가 있는 리스트 타입 지원 (`[Array(Integer, Symbol)]`는 `[Integer, Symbol]`이 됨)  
  - 불리언 타입 지원 (`[true, false]`는 `T::Boolean`/`bool`이 됨)  
  - `@yieldparam` 및 `@yieldreturn`으로 문서화된 `&block` 매개변수 지원  

## 사용법

`sord`를 설치하려면 `gem install sord`를 실행하세요.

Sord는 커맨드 라인 도구입니다. 프로젝트 루트 디렉토리에서 터미널을 열고  
파일을 저장할 경로를 인수로 하여 `sord`를 호출하세요 (이 파일은 덮어쓰기 됩니다):


```
sord defs.rbi
```
Sord는 YARD 문서를 생성한 후 실행하면서 추론한 정보를 출력합니다.  
YARD 문서의 문제를 수정하는 것이 가장 좋으며, 결과 파일에 대한 편집 내용은 Sord를 다시 실행하면 덮어쓰여집니다.  

출력 형식은 사용한 파일 확장자로 추론되지만, `--rbi` 또는 `--rbs` 옵션으로 명시할 수도 있습니다.  

## RBI 타입 배포  

Sord가 생성한 RBI 파일은 두 가지 주요 방식으로 사용될 수 있습니다:  

- [젬 자체에 포함되어 배포](https://sorbet.org/docs/rbi#rbis-within-gems).  
- [sorbet-typed](https://github.com/sorbet/sorbet-typed)에 기여.  

일반적으로 가능하면 타입 시그니처를 젬과 함께 배포하는 것이 좋습니다.  
sorbet-typed는 더 이상 업데이트되지 않거나 유지 관리자가 타입 시그니처를 젬과 함께 배포하기를 원하지 않는 젬을 위한 장소입니다.  

### 플래그  

Sord는 생성된 파일을 변경하기 위한 몇 가지 플래그를 받습니다:  

  - `--rbi`/`--rbs`: 파일 확장자로 추론된 출력 형식을 재정의합니다.  
  - `--no-sord-comments`: 경고/추론/오류에 관한 Sord 코멘트 없이 파일을 생성합니다. (원본 파일의 코멘트는 여전히 포함됩니다.)  
  - `--no-regenerate`: 기본적으로 Sord는 저장소의 YARD 문서를 재생성합니다. 이 옵션은 YARD 문서 재생성을 건너뜁니다.  
  - `--break-params`: 시그니처가 한 줄에서 여러 줄 블록으로 변경되기 위한 매개변수 개수를 결정합니다. (기본값: 4)  
  - `--replace-errors-with-untyped`: `SORD_ERROR_*` 상수 대신 `T.untyped`를 사용합니다.  
  - `--replace-unresolved-with-untyped`: Sord가 상수를 해결하지 못할 때 `T.untyped`를 사용합니다.  
  - `--include-messages` 및 `--exclude-messages`: Sord가 출력하는 로깅 메시지를 필터링하는 데 사용됩니다. `--include-messages`는 화이트리스트로 작동하여 지정된 로깅 종류의 메시지만 출력하며, `--exclude-messages`는














    지정된 로깅 종류를 블랙리스트로 처리하여 억제합니다. 두 플래그 모두 쉼표로 구분된 로깅 종류 목록을 받으며, 예를 들어 `omit,infer`와 같습니다.
    `--include-messages`를 사용할 때는 기본적으로 `done` 종류가 포함됩니다.
    (`--include-messages`와 `--exclude-messages`를 동시에 지정할 수 없습니다.)
  - `--exclude-untyped`: 반환값이 타입이 지정되지 않은 메서드와 속성을 제외합니다.
  - `--tags TAGS`: `yard` 명령어가 인식하는 쉼표로 구분된 태그 목록을 제공합니다. 예: `--tags 'mytag:My Description,mytag2:My New Description'

## 예제

`test.rb`라는 파일이 있다고 가정해 봅시다:




```ruby
module Example
  class Person
    # @param name [String] The name of the Person to create.
    # @param age [Integer] The age of the Person to create.
    # @return [Example::Person]
    def initialize(name, age)
      @name = name
      @age = age
    end

    # @return [String]
    attr_accessor :name

    # @return [Integer]
    attr_accessor :age

    # @param possible_names [Array<String>] An array of potential names to choose from.
    # @param possible_ages [Array<Integer>] An array of potential ages to choose from.
    # @return [Example::Person]
    def self.construct_randomly(possible_names, possible_ages)
      Person.new(possible_names.sample, possible_ages.sample)
    end
  end
end
```
먼저, `yardoc test.rb`를 실행하여 YARD 레지스트리를 생성합니다. 그런 다음, `sord test.rbi`를 실행하여 RBI 파일을 생성할 수 있습니다. (코드 파일을 덮어쓰지 않도록 주의하세요! `.rbi` 파일 확장자에 주의하세요.) 이 과정을 수행하면, Sord는 다음을 출력합니다:




```
[INFER] Assuming from filename you wish to generate in RBI format
[DONE ] Processed 8 objects (2 namespaces and 6 methods)
```
`test.rbi` 파일은 `test.rb`에 대한 완전한 RBI 파일을 포함합니다:


```ruby
# typed: strong
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    sig { params(name: String, age: Integer).void }
    def initialize(name, age); end

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    sig { params(possible_names: T::Array[String], possible_ages: T::Array[Integer]).returns(Example::Person) }
    def self.construct_randomly(possible_names, possible_ages); end

    sig { returns(String) }
    attr_accessor :name

    sig { returns(Integer) }
    attr_accessor :age
  end
end
```
만약 우리가 대신 `test.rbs`를 생성했다면, RBS 형식의 이 파일을 얻게 될 것입니다:


```ruby
module Example
  class Person
    # _@param_ `name` — The name of the Person to create.
    # 
    # _@param_ `age` — The age of the Person to create.
    def initialize: (String name, Integer age) -> void

    # _@param_ `possible_names` — An array of potential names to choose from.
    # 
    # _@param_ `possible_ages` — An array of potential ages to choose from.
    def self.construct_randomly: (Array[String] possible_names, Array[Integer] possible_ages) -> Example::Person

    attr_accessor name: String

    attr_accessor age: Integer
  end
end
```
## 주의할 점

타입 변환에 대한 일반적인 규칙은 다음과 같습니다:

  - Sord가 YARD 타입을 이해하면, 이를 RBI 또는 RBS 타입으로 변환합니다.
  - YARD 타입이 없으면, Sord는 `T.untyped`를 채웁니다.
  - YARD 타입을 이해할 수 없으면, Sord는 알 수 없는 YARD 타입과 유사한 이름의 정의되지 않은 Ruby 상수를 생성합니다.
    예를 들어, 명백히 잘못된 YARD 타입 `A%B`는 `SORD_ERROR_AB`라는 상수가 됩니다.
    결과 파일에서 `SORD_ERROR`를 찾아 수정해야 합니다.

## 기여하기

버그 리포트와 풀 리퀘스트는 https://github.com/AaronC81/sord 에서 환영합니다. 이 프로젝트는 안전하고 환영받는 협업 공간을 목표로 하며, 기여자는 [기여자 행동 강령](http://contributor-covenant.org)을 준수해야 합니다.

기여하는 동안 Sord에 대한 변경 사항의 결과를 보고 싶다면
`examples:seed` Rake 작업을 사용할 수 있습니다. 이 작업은 Bundler, Haml, Rouge, RSpec을 포함한 여러 오픈 소스 Ruby 젬에 대해 Sord를 사용해 타입을 생성합니다.
`rake examples:seed` (및 파일을 다시 생성하려면 `rake examples:reseed`) 명령은 이 젬들의 저장소를 `sord_examples/`에 클론하고 같은 디렉터리에 파일을 생성합니다.

## 라이선스

이 젬은 [MIT 라이선스](https://opensource.org/licenses/MIT) 조건에 따라 오픈 소스로 제공됩니다.

## 행동 강령

Sord 프로젝트의 코드베이스, 이슈 트래커, 채팅방, 메일링 리스트에서 상호작용하는 모든 사람은 [행동 강령](https://github.com/AaronC81/sord/blob/master/CODE_OF_CONDUCT.md)을 준수해야 합니다.









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-30

---