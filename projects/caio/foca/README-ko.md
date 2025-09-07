# Foca: 원하는 방식의 클러스터 멤버십 발견

Foca는 당신의 가십 기반 클러스터 발견을 위한 빌딩 블록입니다.  
이는 SWIM 프로토콜과 유용한 확장(`SWIM+Inf.+Susp.`)을 구현한  
작고 `no_std` + `alloc` 크레이트입니다.

프로젝트:

* Git 저장소: https://caio.co/de/foca/  
* 이슈 트래커: https://github.com/caio/foca/issues  
* CI: https://github.com/caio/foca/actions/workflows/ci.yml  
* 패키지: https://crates.io/crates/foca  
* 문서: https://docs.rs/foca  


# 소개

Foca의 가장 주목할 만한 점은 거의 아무 것도 하지 않는다는 사실입니다.  
기본적으로 제공하는 것은 신뢰할 수 있고 효율적인  
[SWIM 프로토콜][1] 구현뿐이며, 이는 전송 방식과  
식별 방식에 구애받지 않습니다.

SWIM이 어떻게 작동하는지 아는 것은 도움이 되지만 이 라이브러리를  
사용하는 데 반드시 필요하지는 않습니다. `Message` 열거형에 대한 문서를  
읽으면 프로토콜이 어떻게 작동하는지 대략 알 수 있지만, 논문은  
매우 접근하기 쉬운 읽을거리입니다.

Foca는 모든 종류의 전송에 맞게 설계되었습니다: 네트워크가  
피어들이 서로 통신할 수 있다면 Foca를 배포할 수 있습니다.  
일반적인 대역폭 요구사항이 낮을 뿐만 아니라, 멤버들이  
서로를 식별하는 방법(`./examples/identity_golf.rs` 참조)과  
메시지 인코딩 방식을 완전히 제어할 수 있습니다.


# 사용법

`./examples/foca_insecure_udp_agent.rs`를 살펴보세요.  
이는 간단한 tokio 기반 에이전트가 어떻게 생겼는지 보여주고  
실제로 Foca가 작동하는 모습을 실행하여 확인할 수 있습니다.

~~~
$ cargo run --features std,tracing,bincode-codec --example foca_insecure_udp_agent -- --help
foca_insecure_udp_agent 

USAGE:
    foca_insecure_udp_agent [OPTIONS] <BIND_ADDR>

FLAGS:
    -h, --help       Prints help information
    -V, --version    Prints version information

OPTIONS:
    -a, --announce <announce>    Address to another Foca instance to join with
    -f, --filename <filename>    Name of the file that will contain all active members
    -i, --identity <identity>    The address cluster members will use to talk to you.
                                 Defaults to BIND_ADDR

ARGS:
    <BIND_ADDR>    Socket address to bind to. Example: 127.0.0.1:8080
~~~

따라서 한 터미널에서 에이전트를 시작하려면
`./foca_insecure_udp_agent 127.0.0.1:8000`를 실행하고, 다른 여러 인스턴스들과
연결하려면 다른 `BIND_ADDR`과 실행 중인 인스턴스를 가리키는 `--announce`를 사용하면 됩니다.
예시:
`./foca_insecure_udp_agent 127.0.0.1:8001 -a 127.0.0.1:8000`.

에이전트는 [tracing][]의 서브스크라이버를 통해 콘솔에 일부 정보를 출력합니다.
기본 로그 레벨은 `INFO`이며, `RUST_LOG` 환경 변수를 통해
[tracing_subscriber의 EnvFilter 지시문][dir]으로 커스터마이즈할 수 있습니다.


## Cargo Features

모든 기능은 선택 사항입니다. `default` 세트는 항상 비어 있습니다.

* `std`: `std::net::SocketAddr*`에 대해 `foca::Identity`를 구현하며,
  `Config::new_lan` 및 `Config::new_wan`을 노출합니다.
* `tracing`: [tracing][] 크레이트를 사용하여 Foca에 계측을 추가합니다. 고수준

  프로토콜 상호작용은 `DEBUG` 추적으로 출력되며, 더 자세한 내용은 `TRACE` 레벨에서 노출될 수 있습니다. 다른 레벨은 출력되지 않습니다.
* `serde`: Foca의 공개 타입에 대해 `Serialize` 및 `Deserialize`를 파생합니다.
* `bincode-codec`: [bincode][]를 내부적으로 사용하는 serde 기반 코덱 타입 `BincodeCodec`을 제공합니다.
* `postcard-codec`: [postcard][]를 내부적으로 사용하는 serde 기반의 `no_std` 친화적 코덱 `PostcardCodec`을 제공합니다.
* `unstable-notifications`: 전송 및 수신되는 메시지를 검사할 수 있는 새로운 알림을 제공합니다.


# 노트

이 라이브러리를 작성할 때 주요 목표는 테스트, 시뮬레이션 및 이해하기 쉬운 간단하고 작은 코어를 갖는 것이었습니다; 주로 논문을 읽은 후 프로토콜을 더 잘 이해하는 데 초점이 맞춰져 있었습니다.

이 목표를 고수하다 보니 하드웨어 시계, 원자성, 스레드 같은 많은 운영 체제 기능에 의존하지 않는 구현이 자연스럽게 되었고, 그래서 힙 할당이 필요하긴 하지만 `no_std` 크레이트가 된 것은 우연한 좋은 부가 기능으로 받아들여 Commit 하기로 했습니다.


## memberlist와의 비교

내 구현에 만족할 때까지 [memberlist][2]를 보지 않으려 했습니다. 그 이후에 비철저하게 살펴보았습니다:

* memberlist는 복잡한 서비스 탐색 시나리오에 매우 유용한 사용자 정의 방송을 지원하므로, 이제 Foca도 사용자 데이터 전파를 지원합니다(`BroadcastHandler` 문서 참조) :-)

* 멤버 간 가입과 주기적 상태 병합에 사용되는 스트림 기반 동기화 메커니즘(push-pull)을 갖고 있습니다: 이는 Foca의 책임 범위를 훨씬 벗어나지만 매우 흥미로운 아이디어여서, 이를 활용할 수 있도록 `Foca::apply_many` 메서드를 노출했습니다.



















  원하는 경우 Foca를 사용하여 유사한 작업을 수행할 수 있습니다.

* 구성 매개변수는 (현재) 클러스터 크기에 따라 변경됩니다.
  사용자는 `Config::new_{lan,wan}`과 함께
  `Foca::set_config`를 사용하여 동일한 작업을 수행할 수 있습니다.

# 참고 문헌

* 논문 [SWIM: Scalable Weakly-consistent Infection-style Process Group Membership
Protocol][1]
* HashiCorp의 [memberlist][2]

[1]: https://www.cs.cornell.edu/projects/Quicksilver/public_pdfs/SWIM.pdf
[2]: https://github.com/hashicorp/memberlist
[bincode]: https://github.com/bincode-org/bincode
[postcard]: https://github.com/jamesmunns/postcard
[tracing]: https://docs.rs/tracing/latest/tracing/
[dir]: https://docs.rs/tracing-subscriber/0.3.17/tracing_subscriber/filter/struct.EnvFilter.html#directives

# 라이선스

명시적으로 달리 명시되지 않는 한, 모든 작업은
Mozilla Public License 버전 2.0의 조건을 따릅니다.

`examples/` 디렉터리 내의 파일은 퍼블릭 도메인에 속합니다.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-07

---