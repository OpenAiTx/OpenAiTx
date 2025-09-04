# hcl-rs

[![Build Status](https://github.com/martinohmann/hcl-rs/workflows/ci/badge.svg)](https://github.com/martinohmann/hcl-rs/actions?query=workflow%3Aci)
[![License: Apache 2.0](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

이 저장소는 Hashicorp 구성 언어(HCL)와 관련된 다음 러스트 크레이트들을 포함합니다:

- [`hcl-rs`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-rs):
  `serde` 및 표현식 평가를 지원하는 HCL 라이브러리입니다.
- [`hcl-edit`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-edit):
  공백 및 주석을 유지하면서 HCL 문서를 파싱하고 수정합니다.
- [`hcl-primitives`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl-primitives):
  HCL 하위 언어에서 사용하는 원시 타입들입니다.
- [`hcl2json`](https://github.com/martinohmann/hcl-rs/blob/main/crates/hcl2json):
  HCL을 JSON으로 변환하는 CLI 프로그램입니다.

## go-hcl 구현과의 기능 동등성

이 저장소의 크레이트들은 Hashicorp의 [HCL Go
구현](https://github.com/hashicorp/hcl)의 일부인 다음 명세들을 밀접하게 따르려고 합니다:

- [HCL 문법-독립 정보 모델](https://github.com/hashicorp/hcl/blob/main/spec.md)
- [HCL 네이티브 문법 명세](https://github.com/hashicorp/hcl/blob/main/hclsyntax/spec.md)
- [HCL JSON 문법 명세](https://github.com/hashicorp/hcl/blob/main/json/spec.md)

파서 수준에서는 현재 go-hcl이 지원하는 모든 기능을 지원해야 합니다.
그러나 `hcl-rs`에서의 포매팅 및 표현식 평가 구현은 현재 상대적으로 기본적인 상태입니다. 포매팅과
표현식 평가 기능을 `hcl-edit`로 이전할 계획이 있으며 (`hcl-edit`은 `hcl-rs` 내부에서 사용되고 파서 구현도 포함합니다)
더 강력하게 만들 예정입니다.

또한 아직 포함되지 않은 기능으로는, 파싱된 HCL 문서가 허용된 블록 집합과 예상된 속성만 포함하는지
검증하기 위한 HCL 스키마 지원이 있습니다 (예: 특정 terraform 구성에 잘 형성된 `resource` 및 `data` 블록만 포함하는지 검증 가능).







또한, 스키마 지원은 사용자 정의 타입을 사용하여 보다 복잡한 구성을 인코딩하는 것을 쉽게 만드는 데 도움이 될 수 있습니다. 이러한 구성은 현재 `serde` 모델의 제한으로 인해 조립하기 번거롭습니다.

## 기여하기

기여를 환영합니다! PR을 생성하기 전에
[`CONTRIBUTING.md`](https://github.com/martinohmann/hcl-rs/blob/main/CONTRIBUTING.md)
를 읽어주세요.

## 라이선스

별도로 명시되지 않는 한, 이 저장소 내 소스 코드는
[Apache License, Version
2.0](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-APACHE) 또는 [MIT
라이선스](https://github.com/martinohmann/hcl-rs/blob/main/LICENSE-MIT) 중 하나를
선택하여 사용하실 수 있습니다.





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---