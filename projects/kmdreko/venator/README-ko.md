<p align="center">
  <picture>
    <source media="(prefers-color-scheme: dark)" height=170 srcset="docs/images/icon-dark.svg">
    <source media="(prefers-color-scheme: light)" height=170 srcset="docs/images/icon-light.svg">
    <img alt="venator logo" height=170 src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/icon-light.svg">
  </picture>
</p>

Venator는 Rust tracing 크레이트로 계측되었거나 OpenTelemetry를 사용하는 프로그램의 로그 및 스팬을 기록, 조회, 필터링하기 위한 애플리케이션입니다.  
빠른 로컬 개발을 위해 특별히 설계되었습니다.

<picture>
  <img alt="demo" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-demo.gif">
</picture>

## 설치

### 미리 빌드된 바이너리 사용:

바이너리는 [릴리즈 페이지](https://github.com/kmdreko/venator/releases)에서 미리 빌드되어 제공됩니다:  
- Windows (x64)  
- MacOS (Intel, Apple silicon)  

### Cargo 사용:

Cargo로 `venator`를 소스에서 컴파일하고 설치하기 (Rust 1.76 이상 필요):



```
cargo install venator-app
```
## 사용법

### OpenTelemetry 사용:

프로그램의 OpenTelemetry SDK를 구성하여 로그와 추적을
`127.0.0.1:8362` (Venator의 기본 수신 포트)로 내보내고
`grpc` 또는 `http/protobuf`를 사용하도록 설정합니다.

### Rust Tracing 사용:

계측된 프로그램에서:


```toml
[dependencies]
venator = "1.1.0"
```

```rust
use venator::Venator;

Venator::default().install();
```
더 자세한 내용은 [문서](https://docs.rs/venator/latest/venator/)를 참조하십시오.

## 기능

이벤트는 시간 범위로 좁혀 보고 속성, 레벨 및 기타 특성으로 필터링할 수 있습니다.  
레코드 테이블에는 사용자 지정 속성 열을 포함할 수 있습니다.  
그래프는 각 막대에서 레벨별 개수를 표시합니다.

<picture>
  <img alt="이벤트 화면 스크린샷" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-events.png">
</picture>

스팬도 마찬가지로 시간 범위 및 필터로 좁힐 수 있습니다.  
상세 창에서는 선택된 이벤트와 스팬의 모든 속성을 보여줄 수 있습니다.  
그래프는 계층적으로 겹쳐진 스팬을 표시합니다.

<picture>
  <img alt="스팬 화면 스크린샷" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-spans.png">
</picture>

단일 실행 내에서 이벤트와 스팬을 모두 보여주는 트레이스를 볼 수 있습니다.

<picture>
  <img alt="트레이스 화면 스크린샷" src="https://raw.githubusercontent.com/kmdreko/venator/main/docs/images/screenshot-traces.png">
</picture>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-04

---