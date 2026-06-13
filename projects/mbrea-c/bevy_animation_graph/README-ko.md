_라이브러리 크레이트:_  
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)  
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph)](https://crates.io/crates/bevy_animation_graph)  

_에디터 크레이트:_  
[![Crates.io](https://img.shields.io/crates/v/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)  
[![Crates.io](https://img.shields.io/crates/d/bevy_animation_graph_editor)](https://crates.io/crates/bevy_animation_graph_editor)  

[![CI](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml/badge.svg)](https://github.com/mbrea-c/bevy_animation_graph/actions/workflows/ci.yaml)  

# Bevy 애니메이션 그래프  

> **_공지:_** 현재 `0.8.0` 버전 이하를 사용 중이라면,  
> `0.9.0`에서 여러 가지 파괴적 변경사항이 도입되었음을 참고하세요.  
> 업그레이드를 위한  
> [마이그레이션 가이드](https://mbrea-c.github.io/bevy_animation_graph/migration_guides/0.8_to_0.9.html)를 확인하세요.  

## 동기  

애니메이션 그래프는 현대 3D 게임의 애니메이션 파이프라인에서 존재하는 복잡성을 관리하는 데 필수적인 도구입니다.  
게임에 복잡한 블렌드와 전환을 가진 수십 개의 애니메이션이 있거나,  
아주 적은 키프레임으로부터 절차적으로 애니메이션을 생성하고 싶을 때, 단순한 애니메이션 클립 재생만으로는 부족합니다.  

이 크레이트는 대부분의 `bevy_animation`을 대체하는 역할을 하며,  
애니메이션 그래프, 애니메이션 상태 머신(즉, 애니메이션 컨트롤러) 및 애니메이션 그래프와 상태 머신을 생성하기 위한 그래픽 에디터를 포함한  
완전한 애니메이션 시스템과 개발 워크플로우를 제공하는 것을 목표로 합니다.  

_참고: 이 프로젝트는 `bevy_animation` 0.14 버전에서 도입된 애니메이션 그래프와는 별개입니다._  

![예시 사용 스크린샷](https://raw.githubusercontent.com/mbrea-c/bevy_animation_graph/master/locomotion_graph.png)  

## 현재 기능  

- 애니메이션 그래프는 에셋입니다. 에셋 파일에서 로드하거나,  
  코드에서 인체공학적인 API를 통해 생성할 수 있습니다.  
- 시각적 그래프 에디터.




- 애니메이션 상태 머신:
  - 애니메이션 상태 머신은 애니메이션 그래프 내의 노드로 내장되어 있습니다.
  - 상태 머신의 각 상태는 필요에 따라 자체 애니메이션 그래프를 재생합니다.
  - 전환도 자체 애니메이션 그래프를 가지며, 출발 상태와 도착 상태의 애니메이션 그래프를 조회할 수 있습니다.
- 래그돌 지원:
  - 에디터 내 시각적 래그돌 편집 기능.
  - 일부 뼈는 시뮬레이션되고 다른 뼈는 목표 애니메이션 포즈에 의해 운동학적으로 구동되는 _부분 래그돌_ 지원.
- Rust로 작성된 사용자 정의 노드 지원.
  - 사용자는 에디터 플러그인을 추가하고 Bevy 타입 레지스트리에 추가 사용자 정의 노드를 등록하여 자체 에디터 바이너리를 만들 수 있습니다. 에디터는 등록된 모든 노드를 자동으로 인식합니다.
- 제공되는 내장 노드에는 다음이 포함됩니다:
  - 애니메이션 체이닝(즉, 한 노드가 끝난 후 다음 노드를 재생).
  - 두 뼈 역운동학.
  - 반복 재생.
  - 선형 블렌딩(뼈 공간에서).
  - 2D 블렌드 스페이스 노드.
  - YZ 평면을 기준으로 애니메이션 미러링.
  - 애니메이션 클립 재생.
  - 뼈 마스크를 사용하여 포즈 내 일부 뼈에 회전 적용.
  - 애니메이션 재생 속도 가속 또는 감속.
  - 애니메이션 그래프 노드.
  - 애니메이션 상태 머신 노드.
  - 산술 노드: f32, Vec3, Quat 등에서의 다양한 일반 연산.
- 다른 그래프 내 노드로 애니메이션 그래프 중첩.
- 이벤트 트랙을 사용한 애니메이션 동기화.
- 불필요한 계산을 방지하기 위해 그래프 노드 출력 캐싱.

## 계획된 기능

1. 래그돌 "포즈 따라가기" 모드, 시뮬레이션된 래그돌 뼈가 물리적 힘을 사용하여 목표 포즈와 일치하려고 시도하는 모드:
   - _절대_ 일치 모드: 목표 뼈의 월드 공간 위치/회전을 추적하여 래그돌 뼈에 대한 스프링 힘의 앵커로 사용.
   - _상대_ 일치 모드: 래그돌 뼈가 부모 뼈에 대한 목표 위치/회전을 맞추려고 시도. 이 모드를 제대로 구현하려면 Avian에서 조인트 모터 지원이 필요할 수 있습니다.









## 설치

### 라이브러리

[bevy_animation_graph](https://crates.io/crates/bevy_animation_graph)는
이 프로젝트의 라이브러리 부분입니다. 애니메이션 그래프를 사용하려면
프로젝트에 의존성으로 추가해야 합니다. crates.io에서 최신 공개
버전을 설치하려면 다음을 실행하세요.


```bash
cargo add bevy_animation_graph
```
또는 최신 버전을 수동으로 `Cargo.toml`에 추가하세요.

최신 git 마스터를 설치하려면, 다음을 `Cargo.toml`에 추가하세요:


```toml
# ...
[dependencies]
# ...
bevy_animation_graph = { git = "https://github.com/mbrea-c/bevy_animation_graph.git" }
# ...
```
### 에디터

[bevy_animation_graph_editor](https://crates.io/crates/bevy_animation_graph_editor)
는 에디터입니다. 다른 러스트 바이너리를 설치하는 것처럼 설치할 수 있습니다:


```bash
# for the latest crates.io version
cargo install bevy_animation_graph_editor
# for the latest master
cargo install --git https://github.com/mbrea-c/bevy_animation_graph bevy_animation_graph_editor
# for the version from a local workspace
cargo install --path <PATH_TO_WORKSPACE> bevy_animation_graph_editor

# use the --force flag to force reinstall
```
또는 자신의 크레이트/워크스페이스에서 동일한 라이브러리 버전을 사용하는
자체 에디터 바이너리를 설정하기 위해
[플러그인 예제로서의 에디터](https://github.com/mbrea-c/bevy_animation_graph/blob/master/examples/editor_as_a_plugin/examples/editor_as_a_plugin.rs)를
참고할 것을 권장합니다. 이를 통해 이 크레이트의 강력한 기능인
사용자 정의 애니메이션 그래프 노드를 등록할 수 있습니다.

## 시작하기

[진행 중인 책](https://sarahihme.github.io/initial_book_bevy_animation_graph/)의
튜토리얼을 확인하세요 (이 작업을 시작해 주신 @SarahIhme 님께 감사드립니다!).

추가로 최신 예제들은
[examples](https://github.com/mbrea-c/bevy_animation_graph/tree/master/examples)
디렉토리에 포함되어 있습니다.

다음 자료들도 유용할 수 있지만, 다소 구식입니다:

- [docs.rs](https://docs.rs/bevy_animation_graph)에 있는 문서에는
  라이브러리와 에디터 소개 및 간단한 애니메이션 그래프 예제 설명이 포함되어 있습니다.
  아래 비디오도 에디터 사용법 시연에 참고하세요.
- 구식인
  [사용법 비디오 워크스루](https://www.youtube.com/watch?v=q-JBSQJIcX0)가 있습니다.

## 기여하거나 도움 받기

버그가 발생하거나 새로운 기능에 대해 논의하고 싶다면,
이슈를 올리거나 PR을 열거나 Discord에서 저에게 연락하세요 (@mbreac, Bevy Discord 내,
`bevy_animation_graph`에 대한 crate-help 게시판이 있습니다:
[링크](https://discord.com/channels/691052431525675048/1202998277482479616)).

## FAQ

### 이것이 프로덕션용으로 준비되었나요?

상황에 따라 다릅니다.

작고 중간 규모 프로젝트에는 이미 유용할 수 있지만, API를 보장할 수는 없습니다.



`0.x` 버전 간의 안정성 문제(이 라이브러리는 크고, 비교적 젊으며 애니메이션 프로그래밍에 대한 이전 경험이 없기 때문에
아직 최적의 방법을 찾는 중입니다)가 있습니다. 이는 애니메이션 그래프 자산을 버전 간에 수동으로 마이그레이션해야 할 가능성이
높다는 의미이며, 더 나은 마이그레이션 방법을 찾기 전까지는 이 과정이 필요할 것입니다.

또한, 버그 및 기타 문제가 발생할 수 있습니다. 발생하는 즉시 고치려고 노력하고 있습니다.

### 기능 X를 구현할 예정인가요?

작은 기능(예: 추가 벡터 또는 부동 소수점 산술 노드 등)이라면 단지 아직 구현하지 않은 경우일 가능성이 큽니다.
이슈를 열면 아마도 빠르게 구현할 것입니다. PR도 환영합니다.

더 큰 기능의 경우, 논의를 위해 이슈를 먼저 열거나 Bevy 디스코드에서 저에게 연락하는 것이 좋습니다.

## 버전 표

| `bevy` | `bevy_animation_graph` | 
| ------ | ---------------------- | 
| 0.18 | master | 
| 0.18 | 0.10 | 
| 0.17 | 0.9 | 
| 0.17 | 0.8 | 
| 0.16 | 0.7 | 
| 0.15 | 0.6 | 
| 0.14 | 0.5 | 
| 0.13 | 0.4 | 
| 0.13 | 0.3 | 
| 0.12 | 0.2 |

## 감사의 말

애니메이션 프로그래밍 강의를 해주신 [Bobby Anguelov](https://www.youtube.com/@BobbyAnguelov) 님께 깊은 감사를 드립니다.









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---