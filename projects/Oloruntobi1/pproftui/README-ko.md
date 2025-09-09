# pproftui: 터미널에서 상호작용하는 Go 프로파일링

`pproftui`는 Go의 `pprof`를 위한 터미널 기반 UI로, 프로파일링을 상호작용적이고 직관적이며 빠르게 만들어줍니다. 웹 브라우저를 오가며 컨텍스트 전환 없이 성능 문제를 정확히 파악할 수 있도록 설계되었으며, 프로파일링 개념에 대한 내장 설명도 제공합니다.

![Demo](https://raw.githubusercontent.com/Oloruntobi1/pproftui/main/./demo.gif)

---

## 왜 `pproftui`인가?

표준 `go tool pprof`는 강력하지만 직관적이지 않을 수 있습니다. 종종 다음과 같은 의문이 생깁니다:
*   "`flat`과 `cum`은 실제로 무슨 의미인가?"
*   "이 100개의 런타임 함수 중에서 *내* 코드가 어디인가?"
*   "이번 버전과 이전 버전 사이에 무엇이 변경되었는지 어떻게 찾지?"
*   "왜 브라우저와 코드 사이를 계속 왔다 갔다 해야 하지?"

`pproftui`는 이러한 문제들을 직접 해결합니다:
*   **통합된 소스 및 그래프 뷰:** 터미널을 벗어나지 않고도 함수의 소스 코드나 호출 그래프를 볼 수 있습니다.
*   **내 코드에 집중:** 프로젝트 함수들을 자동으로 하이라이트합니다. `p`를 눌러 런타임 및 벤더 노이즈를 즉시 숨길 수 있습니다.
*   **강력하고 직관적인 비교:** 두 프로파일을 비교하여 *무엇*이 변했는지 뿐만 아니라 *왜* 변했는지도 알 수 있습니다. UI가 호출 스택을 통해 회귀의 원인을 추적하는 데 도움을 줍니다.
*   **라이브 프로파일링:** 실행 중인 서비스에 `pproftui`를 연결하면 프로파일이 실시간으로 업데이트됩니다.
*   **내장 도움말 (F1):** 프로파일링 용어(`cpu`, `inuse_space`, `flat` vs `cum`)에 대한 명확하고 간단한 설명을 필요할 때 바로 제공합니다.

---

## 시작하기

### 설치
```sh
go install github.com/Oloruntobi1/pproftui@latest
```
### 요리책: 일반적인 프로파일링 작업 흐름

여기 `pproftui`를 사용하여 일반적인 성능 문제를 해결하는 실용적인 레시피가 있습니다.

#### 레시피 1: 로컬 바이너리의 속도 저하 조사
함수가 느리다는 것을 발견했습니다. CPU 프로파일을 생성하고 탐색해 봅시다.

1.  **프로파일 생성:**

    ```sh
    go test -bench=. -cpuprofile=cpu.prof
    ```

2.  **`pproftui`로 분석하기:**
    ```sh
    pproftui cpu.prof
    ```
    *   `c` 키를 눌러 소스 코드 보기와 호출자/피호출자 그래프를 전환할 수 있습니다.
    *   프로파일 유형이 무엇을 의미하는지 확실하지 않으면 언제든지 `F1` 키를 누르세요.

#### 레시피 2: 성능 저하 찾기 (Diff 워크플로우)
최근 커밋이 성능을 저하시켰다고 의심됩니다. `pproftui`의 diff 기능이 강력한 무기입니다.

1.  **`main` 브랜치에서 프로파일을 얻으세요:**
    ```sh
    git checkout main
    go test -bench=. -cpuprofile=main.prof
    ```

2.  **기능 브랜치에서 프로필 가져오기:**
    ```sh
    git checkout your-feature-branch
    go test -bench=. -cpuprofile=feature.prof
    ```

3.  **차이를 비교하세요:**
    ```sh
    pproftui main.prof feature.prof
    ```
    `pproftui`는 이제 *델타*를 보여줍니다. 초록색(`+`)은 `feature.prof`에서 더 많은 리소스가 사용되었음을 의미하고, 빨간색(`-`)은 더 적게 사용되었음을 의미합니다. 이를 사용하여 그래프를 탐색하고 새로운 오버헤드를 도입한 정확한 함수를 찾으세요.

#### 레시피 3: 라이브 서비스 프로파일링
스테이징 환경에서 부하가 걸린 상태에서 애플리케이션이 어떻게 동작하는지 보고 싶습니다.

1.  **애플리케이션이 pprof 엔드포인트를 노출하는지 확인하세요.** (예: `net/http/pprof`를 임포트하여)
2.  **라이브 모드에서 `pproftui`를 실행하세요:**
    ```sh
    # This will fetch a 5-second CPU profile every 10 seconds.
    pproftui -live="http://localhost:6060/debug/pprof/profile?seconds=5" -refresh=10s
    ```
    *   `space` 키를 눌러 실시간 업데이트를 일시 중지하거나 재개하세요.

#### 레시피 4: 잡음을 뚫고 나아가기
프로파일에는 런타임 및 라이브러리 코드가 가득합니다. 중요한 부분, 즉 **자신의 코드**에 집중하는 방법은 다음과 같습니다.

```sh
# Provide your project's go module path
pproftui --module-path="github.com/your/project" cpu.prof
```
*   프로젝트의 함수는 이제 `★`로 표시됩니다.
*   `p`를 눌러 "프로젝트 전용" 모드를 토글하여 나머지 모든 항목을 즉시 숨깁니다.

---

## 단축키

| 키          | 동작                                                   |
| :---------- | :----------------------------------------------------- |
| `↑`/`↓`     | 함수 목록 탐색                                         |
| `t`         | 프로파일 유형 토글 (`inuse_space`, `alloc_objects`)    |
| `c`         | **c**ode와 **c**all 그래프 보기 전환                   |
| `p`         | **p**roject 전용 코드 필터 토글                         |
| `s`         | **s**ort 순서 순환 (`Self`, `Total`, `Name`)           |
| `f`         | **f**lame 그래프 보기 토글                             |
| `Enter`     | *플레임 그래프에서:* 선택한 함수 확대                   |
| `Esc`       | *플레임 그래프에서:* 축소                              |
| `F1`        | 상세 **도움말** 및 설명 표시                            |
| `q` / `ctrl+c`| **Q**uit 종료                                       |


---

## 라이선스

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-09

---