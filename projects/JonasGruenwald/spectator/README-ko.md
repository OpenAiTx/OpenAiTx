## <img width=16 src="https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/spectator/src/spectator/internal/assets/lucy_spectator.svg"> Spectator

[![패키지 버전](https://img.shields.io/hexpm/v/spectator)](https://hex.pm/packages/spectator)
[![Hex 문서](https://img.shields.io/badge/hex-docs-ffaff3)](https://hexdocs.pm/spectator/)

Spectator는 Gleam으로 작성된 BEAM 관찰 도구로, gleam_otp 프로세스와 잘 작동합니다.

![](https://raw.githubusercontent.com/JonasGruenwald/spectator/refs/heads/main/screenshot.png)

## 특징

현재까지 spectator는 다음과 같은 기능을 제공합니다:

- 정렬 가능한 테이블에서 프로세스 표시
- 개별 프로세스에 태그 지정으로 쉽게 식별
- 프로세스 상세 정보 표시
- OTP 프로세스 상태 표시
- OTP 프로세스 일시 중지 / 재개
- ETS 테이블 목록
- ETS 테이블 내용 보기
- 활성 포트 목록
- 리소스 간 클릭 가능한 링크
- 기본 통계가 포함된 대시보드
- 다른 BEAM 노드 검사

## 개발 환경에서 Spectator 사용하기

프로젝트에 spectator를 의존성으로 설치하고, 애플리케이션의 일부로 실행하여 개발 중인 앱을 검사할 수 있습니다.

```sh
gleam add spectator
```
자세한 내용은 [패키지 README](https://hexdocs.pm/spectator/)를 참조하십시오.

## 프로덕션에서 Spectator 사용하기

Spectator를 독립 실행형 앱으로 실행하고 배포된 애플리케이션이 실행 중인 Erlang 노드에 분산 연결하여 BEAM 노드를 검사할 수 있습니다.

독립 실행형 spectator 애플리케이션은 `ghcr.io/jonasgruenwald/spectator`의 도커 이미지와 [릴리스 페이지](https://github.com/JonasGruenwald/spectator/releases)의 escript로 제공됩니다.

레포에는 [도커로 배포된 앱을 검사하기 위해 spectator를 사용하는 전체 예제](https://github.com/JonasGruenwald/spectator/tree/main/example#readme)가 포함되어 있습니다.

먼저, 애플리케이션이 Erlang 이름과 쿠키를 설정했는지 확인하십시오. 예를 들어 애플리케이션 시작 전에 `ERL_FLAGS` 환경 변수를 설정하여 할 수 있습니다:


```sh
ERL_FLAGS="-name myapp@host -setcookie mycookie"
```
만약 애플리케이션이 도커 컨테이너에서 실행 중이라면, 애플리케이션 컨테이너와 spectator를 실행하는 컨테이너를 같은 도커 네트워크에 두고, 애플리케이션 컨테이너의 호스트명이 알고 있는 값으로 설정되어 있는지 확인하세요.

spectator를 시작하고, 애플리케이션 우측 상단의 'Change Target'을 클릭하세요.

검사하고자 하는 노드의 세부 정보를 입력하세요. 이름은 `-sname`으로 설정한 이름에 `@`와 호스트명이 이어져야 합니다.

마지막으로, 'Connect'를 클릭하여 애플리케이션 노드를 검사하세요.

검사 대상은 spectator와 같은 Erlang 쿠키를 설정해야 합니다. 애플리케이션과 마찬가지로, spectator의 쿠키도 `ERL_FLAGS` 환경 변수로 설정할 수 있습니다. 예: `ERL_FLAGS="-name spectator@127.0.0.1 -setcookie mycookie"`.

## 고려 사항

spectator 실행 시 다음 사항을 유의하세요:

- **Spectator는 시스템 속도를 늦출 수 있습니다**  
  모든 표시된 프로세스는 Erlang의 `process_info/2` 함수를 사용해 설정된 간격마다 조사되며, 이 함수는 조사되는 프로세스에 일시적인 락을 겁니다. 프로세스가 많은 메시지를 처리 중이라면 시스템 성능에 영향을 줄 수 있습니다.

- **Spectator는 동적으로 atom을 생성합니다**  
  다른 Erlang 노드에 연결할 때, spectator는 제공한 노드 이름을 atom으로 변환해야 합니다. 따라서 사용자 인터페이스를 통해 spectator가 실행되는 BEAM 인스턴스의 메모리가 고갈될 수 있습니다. atom은 가비지 컬렉션되지 않기 때문입니다.

- **Spectator는 접근 제어를 포함하지 않습니다**  
  spectator는 검사 중인 런타임의 민감한 정보를 웹 인터페이스를 통해 노출하며, 현재 접근을 제한하지 않습니다.  
  프로덕션 환경에서 spectator를 사용할 경우 보안 책임은 사용자에게 있으니, 절대 public 인터넷에 노출하지 마십시오.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---