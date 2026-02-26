# 포켓몬 레드 (RL 에디션)

![테스트](https://github.com/thatguy11325/pokemonred_puffer/actions/workflows/workflow.yml/badge.svg)

이 저장소는 포켓몬 레드 RL 개발에 사용될 라이브러리로 설계되었습니다. 여기에는 라이브러리 환경에서는 사용하지 말아야 할 편의 함수들이 포함되어 있으며, 포크해서 사용해야 합니다. 앞으로는 이러한 편의 함수들이 마이그레이션되어 포크가 필요 없게 될 예정입니다.

## 빠른 시작

### 설치

라이브러리를 설치하려면 다음 중 하나를 선택할 수 있습니다.

1. 저장소를 로컬 머신에 클론하고 설치합니다.
2. 저장소를 포크한 후 포크한 저장소를 로컬 머신에 클론합니다.

예를 들어,

```sh
pip3 install -e . 
```
### 실행

아래는 경우에 따라 기본 인수를 사용하는 명령어입니다. 이 저장소와 관련된 명령줄 작업 사용법이 확실하지 않은 경우 `python3 -m pokemonred_puffer.train --help`를 실행해 주세요. 일부 명령어는 최근에 테스트되지 않았을 수 있으니 문제가 있으면 이슈를 남겨 주세요.

설치 후에는 다음 명령어로 학습을 시작할 수 있습니다:


```sh
# Run before training to test what num_envs value you should use
python3 -m pokemonred_puffer.train autotune
# Default
python3 -m pokemonred_puffer.train train
```

### 멀티노드 하이퍼파라미터 스윕 (진행 중)

하이퍼파라미터 스윕을 실행하려면 관련 패키지를 설치하고 두 개의 명령어를 실행하면 됩니다:

```sh
pip3 install -e '.[sweep]'
python3 -m pokemonred_puffer.sweep launch-sweep
python3 -m pokemonred_puffer.sweep launch-agent <sweep-id>
```
스윕 ID는 스윕을 시작할 때 출력됩니다. 스윕을 재개하려면 다음과 같이 스윕을 다시 실행할 수 있습니다.


```sh
python3 -m pokemonred_puffer.sweep launch-sweep --sweep-id <sweep-id>
```
스윕은 스윕 구성(기본값은 `sweep-config.yaml`)과 기본 구성(기본값은 `config.yaml`)으로 설정할 수 있습니다. 하이퍼파라미터 스윕은 스윕 구성을 사용하여 범위를 설정하고 하이퍼파라미터를 기본 구성의 파라미터를 중심으로 설정합니다. 하이퍼파라미터 알고리즘에 대해 더 알고 싶다면 [Imbue의 CARBS 저장소](https://github.com/imbue-ai/carbs/tree/main)를 방문하세요.

참고: 현재 단일 노드 스윕은 지원되지 않습니다. 이 기능이 필요하다면 이슈를 만들어 주세요.

### 학습을 위한 수정

실행 중인 작업이 있는데 변경하고 싶다면, 어떻게 해야 할까요?

몇 가지 옵션이 있습니다:

1. `config.yaml`에서 파라미터를 변경하기 시작합니다.
2. 코드를 직접 수정하기 시작합니다(나중에 자세히 다룹니다).
3. 이 저장소를 라이브러리로 사용하고 자신만의 래퍼를 만듭니다.

### 디버깅
변경 사항을 테스트하고 싶다면 다음을 실행할 수 있습니다.


```sh
python3 -m pokemonred_puffer.train --config config.yaml --debug
```
비상 상황에서는 `environment.py`에서 `send_input` 함수 호출을 제거하는 것이 권장됩니다. 이렇게 하면 모델의 일정에 맞추지 않고 직접 보상을 테스트할 수 있습니다.

## 디렉토리 구조

이 저장소는 궁극적으로 라이브러리로 사용될 예정입니다. 모든 소스 파일은 `pokemonred_puffer` 디렉토리 아래에 있어야 합니다. `__main__`이 포함된 모듈을 추가하고 싶다면 자유롭게 추가하되, 반드시 `pokemonred_puffer` 디렉토리 내에 두어야 합니다. 이후에는 `python3 -m pokemonred_puffer.<your-module>` 명령어로 메인을 실행할 수 있어야 합니다.

`pokemonred_puffer` 디렉토리 내에는 다음과 같은 파일과 디렉토리가 있습니다:

- `policies`: 모델을 실행할 때 사용할 다양한 정책들이 있는 디렉토리입니다.
- `rewards`: `RedGymEnv` (포켓몬 레드용 gym 환경) 객체의 보상을 추적하는 `gym.Env` 클래스들이 있는 디렉토리입니다.
- `wrappers`: 사용하고자 하는 래퍼들이 있는 디렉토리로, 예를 들어 [Pokemon Red Map Visualizer](https://pwhiddy.github.io/pokerl-map-viz/)에 로그를 남기는 래퍼 등이 있습니다.
- `cleanrl_puffer.py` - 실제 학습 로직을 실행하는 책임이 있는 파일입니다.
- `environment.py` - 포켓몬 레드 Gym 환경의 핵심 로직입니다.
- `eval.py` - 학습 중 로그용 시각화를 생성하는 파일입니다.
- `kanto_map_dsv.png` - 칸토 지역의 고해상도 지도입니다.
- `train.py` - 학습을 시작하는 스크립트 및 진입점입니다.

## 변경 사항 만들기

간단한 변경 사항은 `config.yaml`을 직접 수정할 수 있습니다. `config.yaml`에는 몇 가지 중요한 규칙이 있습니다. `wrappers`, `rewards`, `policies`의 경우, 래퍼, 보상, 정책은 반드시 `module_name.class_name` 키로 지정되어야 합니다. 이 섹션들은 여러 종류의 `wrappers`, `rewards`, `policies`를 포함할 수 있습니다. 일반적인 구조는 `label : 클래스에 대한 인자` 형태입니다. 더 나은 간접 참조 방식이 마련될 때까지 이 방식을 사용합니다.

### 래퍼 추가하기

래퍼를 추가하려면 `gym.Wrapper`를 상속하는 새 클래스를 `wrappers` 디렉토리에 추가합니다. 그 다음 `config.yaml`의 `wrappers` 섹션을 업데이트합니다. 래퍼들은 기본 환경을 위에서 아래 순서로 감쌉니다. 래퍼 목록은 클래스 경로로 키가 지정되지 않습니다. 래퍼 컬렉션을 구별하는 고유 이름입니다.

### 보상 추가하기

보상을 추가하려면 `rewards` 디렉토리에 새 클래스를 추가합니다. 그 다음 `config.yaml`의 `rewards` 섹션을 업데이트합니다. 보상 섹션은 클래스 경로로 키가 지정됩니다.

### 정책 추가하기

정책을 추가하려면 `policies` 디렉토리에 새 클래스를 추가합니다. 그 다음 `config.yaml`의 `policies` 섹션을 업데이트합니다. 정책 섹션은 클래스 경로로 키가 지정됩니다. 순환 정책은 감싸는 정책과 같은 모듈에 존재한다고 가정합니다.

## 개발

이 저장소는 [pre-commit](https://pre-commit.com/)을 사용하여 포맷과 린트를 강제합니다. 개발을 위해서는 다음 명령어로 이 저장소를 설치하세요:


```sh
pip3 install -e '.[dev]'
pre-commit install
```
변경 사항이 있을 경우 PR을 제출해 주세요.

## 저자

[David Rubinstein](https://github.com/drubinstein), [Keelan Donovan](https://github.com/leanke), [Daniel Addis](https://github.com/xinpw8), 최경환, [Joseph Suarez](https://puffer.ai/), [Peter Whidden](https://peterwhidden.webflow.io/)

<a href="https://star-history.com/#drubinstein/pokemonred_puffer&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=drubinstein/pokemonred_puffer&type=Date" />
 </picture>
</a>

[![](https://raw.githubusercontent.com/drubinstein/pokemonred_puffer/main/assets/puffer.png)](https://puffer.ai)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-26

---