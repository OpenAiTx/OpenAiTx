# ESP32 트랜스파일러

[![License](https://img.shields.io/github/license/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/blob/master/LICENSE)
[![Releases](https://img.shields.io/github/v/release/andygeiss/esp32)](https://github.com/andygeiss/esp32-transpiler/releases)
[![Go Report Card](https://goreportcard.com/badge/github.com/andygeiss/esp32)](https://goreportcard.com/report/github.com/andygeiss/esp32)
[![Maintainability](https://api.codeclimate.com/v1/badges/90bf72e5a7b538c9e50e/maintainability)](https://codeclimate.com/github/andygeiss/esp32-transpiler/maintainability)

## 목적

[Arduino IDE](https://www.arduino.cc/en/Main/Software)는 사용하기 쉽습니다.
하지만 더 복잡한 IoT 프로젝트에서 유지보수성과 테스트 가능성 문제에 직면했습니다.
코드 기능을 테스트하기 전에 ESP32를 100% 수동으로 컴파일하고 플래시해야 했습니다.

이 솔루션은 Golang을 Arduino 코드로 트랜스파일하며, ESP32 툴체인을 사용해 이미지를 컴파일할 수 있습니다.
이제 100% 수동 대신 완전 자동화된 테스트 방식을 사용할 수 있습니다.

**중요**:

트랜스파일러는 [Golang 언어 명세](https://golang.org/ref/spec)의 아주 작은 부분 집합만 지원합니다.
현재 기능은 [매핑](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/handlers/mapping.go)과 [테스트](https://github.com/andygeiss/esp32-transpiler/blob/master/transpile/service_test.go)를 참고하세요.
Golang이 자동으로 처리하기 때문에 C/C++ 가비지 컬렉션을 트리거하는 것도 불가능합니다.
Go 문자열은 스택에서 처리할 수 있는 C 상수 char 배열로 트랜스파일됩니다.

### 사전 준비

1. 최신 버전의 [Go](https://golang.org/dl/)를 설치하세요.
2. 최신 버전의 [Just](https://github.com/casey/just)를 설치하세요.
3. `$HOME/bin`을 `$PATH`에 포함시키세요.

## 설치

레포지토리를 클론하고 `esp32-transpiler` 바이너리를 `$HOME/bin`에 설치하세요:

    just install

## 사용법

Golang 소스 파일을 Arduino 스케치 파일로 트랜스파일하세요:

```bash
    esp32-transpiler -source my_source.go -target my_target.ino
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-18

---