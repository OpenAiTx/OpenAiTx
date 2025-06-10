<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>당신의 프론트엔드를 빛나게 하세요</strong> ✨
</div>

<div align="center">
  Gleam으로 웹 앱을 만드는 프레임워크!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Hex에서 사용 가능" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="문서" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      웹사이트
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      빠른 시작
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      레퍼런스
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      디스코드
    </a>
  </h3>
</div>

<div align="center">
  <sub>❤︎로 만든
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> 및
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    기여자들
  </a>
</div>

---

## 목차

- [특징](#features)
- [예제](#example)
- [철학](#philosophy)
- [설치](#installation)
- [다음 단계](#where-next)
- [지원](#support)

## 특징 {#features}

- **선언적**이고 함수형 API로 HTML을 구성합니다. 템플릿도, 매크로도 없이,
  오직 Gleam만 사용합니다.

- 상태 관리를 위한 Erlang과 Elm에서 영감을 받은 아키텍처.

- 예측 가능하고 테스트 가능한 코드를 위한 **관리된 부수 효과**.

- 범용 컴포넌트. **한 번 작성, 어디서나 실행**. Elm과 Phoenix LiveView의 만남.

- 앱의 스캐폴딩과 빌드를 쉽게 해주는 **배터리 내장 CLI**.

- 정적 HTML 템플릿을 위한 **서버 사이드 렌더링**.

## 예제 {#example}

Lustre는 [20개 이상의 예제](https://hexdocs.pm/lustre/reference/examples.html)를 제공합니다!
다음은 사용 예시입니다:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## 철학 {#philosophy}

Lustre는 소규모에서 중간 규모의 웹 애플리케이션을 만들기 위한 _의견이 확고한_ 프레임워크입니다. 현대 프론트엔드 개발은 어렵고 복잡합니다. 이러한 복잡성 중 일부는 불가피하지만, 많은 부분이 불필요하거나 너무 많은 선택지에서 비롯됩니다. Lustre는 Gleam과 동일한 설계 철학을 따릅니다: 가능한 한, 무언가를 하는 방법은 하나만 존재해야 합니다.

이는 Elm과 Erlang/OTP에서 모델링된 단일 상태 관리 시스템이 기본으로 제공된다는 뜻입니다. 어떤 Lustre 애플리케이션을 열어도 익숙함을 느낄 수 있습니다.

또한 복잡한 방법보다 단순하게 뷰를 구성하는 방식을 권장합니다. Lustre에는 캡슐화된 상태를 가진 컴포넌트를 만드는 방법도 있지만(Elm에서 정말 아쉬웠던 부분!), 이것이 기본값이 되어서는 안 됩니다. 상태ful 컴포넌트보다는 단순한 함수를 선호하세요.

컴포넌트가 _필요한_ 경우, Lustre 컴포넌트는 _어디서나 실행_ 될 수 있다는 점을 활용하세요. Lustre는 기존 Lustre 애플리케이션 내에서, 독립적인 웹 컴포넌트로, 또는 최소한의 런타임으로 서버에서 DOM을 패치하며 실행할 수 있는 컴포넌트를 작성할 도구를 제공합니다. Lustre는 이러한 컴포넌트를 **범용 컴포넌트**라고 하며, Gleam의 멀티 타겟을 고려해 작성됩니다.

## 설치 {#installation}

Lustre는 [Hex](https://hex.pm/packages/lustre)에 배포되어 있습니다! 명령줄에서 Gleam 프로젝트에 추가할 수 있습니다:

```sh
gleam add lustre
```

Lustre에는 개발 도구가 포함된 보조 패키지도 있으니 설치해보세요:

> **참고**: lustre_dev_tools 개발 서버는 파일 시스템에서 Gleam 코드의 변경을 감지하여 자동으로 브라우저를 새로고침할 수 있습니다. 리눅스 사용자는 [inotify-tools]() 설치가 필요합니다.

```sh
gleam add --dev lustre_dev_tools
```

## 다음 단계 {#where-next}

Lustre를 빠르게 익히려면 [빠른 시작 가이드](https://hexdocs.pm/lustre/guide/01-quickstart.html)를 참고하세요.
코드를 보고 싶다면 [예제](https://github.com/lustre-labs/lustre/tree/main/examples)
디렉터리에 프레임워크의 다양한 측면을 보여주는 작은 애플리케이션들이 있습니다.

문서와 API 레퍼런스는
[HexDocs](https://hexdocs.pm/lustre)에서 확인할 수 있습니다.

## 지원 {#support}

Lustre는 대부분 저, [Hayleigh](https://github.com/hayleigh-dot-dev)가 두 개의 직업을 병행하며 개발하고 있습니다.
저의 작업을 후원하고 싶으시다면 [GitHub에서 후원](https://github.com/sponsors/hayleigh-dot-dev)하실 수 있습니다.

기여도 언제든 환영합니다! 버그를 발견했거나, 새로운 기능을 제안하고 싶으시다면 이슈나 풀 리퀘스트를 남겨주세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---