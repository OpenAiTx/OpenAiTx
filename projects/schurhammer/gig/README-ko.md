# gig

Gig은 gleam으로 작성된 gleam 컴파일러입니다.

## 사용 방법

### 샘플 파일 컴파일 및 실행:

```bash
# clone the repository
git clone https://github.com/schurhammer/gig
cd gig

# compile a sample
gleam run samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
- 이것은 `samples/hello_world.gleam` 파일을 `samples/hello_world.c`로 컴파일한 다음 C 컴파일러를 사용하여 `samples/hello_world.exe`에 바이너리를 생성합니다.
- Gig는 소스 디렉터리와의 일반적인 이름 충돌을 피하기 위해 `.exe` 확장자를 추가합니다.

### gig 컴파일:


```bash
# compile gig into a binary
gleam run src/gig.gleam --gc --release

# compile a sample using the gig binary
src/gig.exe samples/hello_world.gleam

# run the sample
samples/hello_world.exe
```
### gig 바이너리를 사용하여 프로젝트 컴파일하기:

- `gig` 실행 파일을 경로에 추가하거나 프로젝트에 복사하세요.
- `patch` 디렉토리를 프로젝트에 복사하세요.


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your main module
gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
- gig은 프로젝트의 루트 디렉토리에서 실행해야 합니다.
- gig은 메인 모듈 디렉토리, `patch` 디렉토리, 그리고 다운로드된 의존성의 각 소스 디렉토리(예: `build/packages/<package_name>/src`)에서 소스 파일을 포함합니다.
- 의존성은 `gleam deps download`를 사용하여 다운로드하세요.
- 메인 모듈은 중첩되지 않은, 즉 `src` 디렉토리 바로 아래에 있어야 합니다.

### gig을 경로 의존성으로 사용하여 프로젝트 컴파일하기

- `gleam.toml` 파일에 gig을 경로 의존성으로 추가하세요 `gig = { path = "../gig" }`.
- `patch` 디렉토리를 프로젝트로 복사하세요.


```bash
# you should be in your project root
cd <your project root>

# copy patch directory (adjust file paths to match your system)
cp -r ../gig/patch patch

# ensure dependencies are downloaded
gleam deps download

# compile your project using gig as a path dependency
gleam run -m gig src/<main module>.gleam

# run your main module
src/<main module>.exe
```
### 선택적 플래그:

- `--release`: 최적화 활성화.
- `--gc`: 가비지 컬렉션 활성화 (그렇지 않으면 가비지 컬렉션 없음).
- `--debug`: 디버그 심볼 포함.
- `--headers`: FFI 함수용 헤더 파일 생성.
- `--compiler=name`: C 컴파일러 이름/경로.
- `-c`: C 파일만 생성 (바이너리 생성 안함).

> [!IMPORTANT]
> 스택 오버플로우가 발생할 가능성이 높은 경우, 스택 크기를 늘리세요. 이는 종종 세그멘테이션 폴트로 나타납니다.
>
> ```
> ulimit -s unlimited
> ```

## 필수 의존성:

- C 컴파일러 (clang이 가장 잘 작동하는 것으로 보임)
- `--gc` 용도로 Boehm GC 필요 (일명 `libgc`)

## 표준 라이브러리

표준 라이브러리의 많은 부분이 `@external` 호출로 구현되어 있어 현재 모든 함수가 사용 가능하지 않습니다.
일부 함수는 이미 패치를 통해 재구현되었으며, `patch` 디렉터리를 참조하세요. 미구현 함수가 사용되면 컴파일러가 경고를 출력하며 함수 본문은 "todo"로 처리됩니다.

## 패치 시스템

gig는 서드파티 프로젝트이기 때문에, 대부분의 Gleam 라이브러리는
이 프로젝트를 지원하지 않을 가능성이 높습니다. 이런 상황을 위해
작동하지 않는 일부 모듈을 덮어쓸 수 있는 패치 시스템이 있습니다.
이를 위해 단순히 패치하려는 모듈 이름이 `x`일 경우 `x.patch.gleam`라는 모듈을 생성하세요.
패치는 원래 모듈과 병합되므로, 고장 난 함수만 구현하면 됩니다.
패치는 `patch` 디렉터리 또는 소스 디렉터리 어디에나 둘 수 있습니다.

에디터에서 더 나은 C 언어 지원을 위해, 프로젝트에 `.clangd`와
`compile_flags.txt` 파일을 추가할 수 있습니다.



`.clangd`:

```
CompileFlags:
  Add: [-Ipatch]
```
`compile_flags.txt`: (빈 파일)

## FFI

`@external(c, "", "function_name")` 주석을 사용하여 C 함수를 정의할 수 있습니다.  
일반 gleam의 FFI와 유사합니다.  
이후, `--headers` 옵션을 사용하여 컴파일러를 실행하면  
외부 함수 구현에 필요한 함수 및 타입 선언이 포함된 헤더 파일이 생성됩니다.  
구현하는 C 파일은 이 헤더 파일을 `#include` 해야 하며  
헤더 파일과 동일한 이름으로 명명되어야 합니다.  
함수는 가능하면 네임스페이스를 사용하여 예를 들어 `module_name_function_name()`처럼 이름을 지어야 합니다.

## 기능 / 할 일 목록

### 기본 사항

- [x] Bool  
- [x] Int  
- [x] Float  
- [x] 십진법 이외의 숫자 형식  
- [x] 문자열  
- [x] 리스트  
- [x] 동등성  
- [x] 할당  
- [x] 무시 패턴  
- [x] 타입 추론  
- [x] 타입 주석  
- [x] 모듈 (참고: 모듈은 대상 파일을 기준으로 해결됩니다)  
- [x] 의존성  
- [x] 비한정 임포트  
- [x] 타입 별칭  
- [x] 블록  
- [x] 상수  
- [x] 메모리 관리 (GC/RC)

### 함수

- [x] 함수  
- [x] 고차 함수

- [x] 익명 함수
- [x] 함수 캡처
- [x] 제네릭 함수
- [x] 파이프라인
- [x] 레이블 인수
- [ ] 문서 주석 (무시됨)
- [ ] 사용 중단 (무시됨)

### 흐름 제어

- [x] 케이스 표현식
- [x] 변수 패턴
- [x] 생성자 패턴
- [x] 문자열 패턴
- [x] 리스트 패턴
- [x] 재귀
- [ ] 꼬리 호출 (참고: c 컴파일러가 대신 처리할 수 있음)
- [x] 다중 주제
- [x] 대체 패턴
- [x] 패턴 별칭
- [x] 가드
- [ ] 완전성 검사

### 기타 데이터 타입

- [x] 튜플
- [x] 사용자 정의 타입
- [x] 레코드
- [x] 레코드 접근자
- [x] 레코드 업데이트
- [x] 제네릭 사용자 정의 타입
- [x] 결과
- [ ] 비트 배열 (부분 지원)

### 고급 기능

- [ ] 불투명 타입
- [x] 사용
- [x] 할 일
- [x] 패닉
- [x] let assert
- [x] 외부 모듈

## 기여하기

현재 코드 기여는 받고 있지 않습니다. 다만 이슈, 제안, 토론은 언제든지 환영합니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---