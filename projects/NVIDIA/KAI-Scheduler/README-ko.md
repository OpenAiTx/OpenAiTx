[![License](https://img.shields.io/badge/License-Apache_2.0-blue.svg)](LICENSE) [![Coverage](https://github.com/NVIDIA/KAI-Scheduler/raw/coverage-badge/badges/coverage.svg)](https://github.com/NVIDIA/KAI-Scheduler/blob/main/.github/workflows/update-coverage-badge.yaml)
# KAI 스케줄러
KAI 스케줄러는 AI 및 머신러닝 워크로드를 위한 GPU 리소스 할당을 최적화하는 강력하고 효율적이며 확장 가능한 [쿠버네티스 스케줄러](https://kubernetes.io/docs/concepts/scheduling-eviction/kube-scheduler/)입니다.

수천 개의 노드를 포함한 대규모 GPU 클러스터와 높은 처리량의 워크로드를 관리하도록 설계되어, KAI 스케줄러는 방대한 환경과 까다로운 환경에 이상적입니다.
KAI 스케줄러는 쿠버네티스 클러스터 관리자가 워크로드에 GPU 리소스를 동적으로 할당할 수 있도록 합니다.

KAI 스케줄러는 최소한의 리소스만 필요한 소규모 대화형 작업부터 대규모 트레이닝 및 추론까지, 동일한 클러스터 내에서 AI 라이프사이클 전체를 지원합니다.
서로 다른 소비자 간의 리소스 공정성을 유지하면서 최적의 리소스 할당을 보장합니다.
클러스터에 설치된 다른 스케줄러와 함께 실행될 수 있습니다.

## 주요 기능
* [배치 스케줄링](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/batch/README.md): 그룹 내 모든 파드가 동시에 스케줄링되거나 전혀 스케줄링되지 않도록 보장합니다.
* 빈 패킹 & 분산 스케줄링: 조각화를 최소화(빈 패킹)하거나 복원력 및 부하 분산(분산 스케줄링)을 높여 노드 사용을 최적화합니다.
* [워크로드 우선순위](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/priority/README.md): 큐 내에서 워크로드의 우선순위를 효과적으로 지정합니다.
* [계층적 큐](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/queues/README.md): 유연한 조직적 제어를 위해 2단계 큐 계층 구조로 워크로드를 관리합니다.
* [리소스 분배](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#resource-division-algorithm): 큐별로 쿼터, 초과 쿼터 가중치, 한계, 우선순위 등을 사용자 정의합니다.
* [공정성 정책](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/fairness/README.md#reclaim-strategies): Dominant Resource Fairness(DRF)와 큐 간 리소스 회수를 통해 공정한 리소스 분배를 보장합니다.
* 워크로드 통합: 실행 중인 워크로드를 지능적으로 재할당하여 조각화를 줄이고 클러스터 활용도를 높입니다.
* [탄력적 워크로드](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/elastic/README.md): 정의된 최소 및 최대 파드 수 내에서 워크로드를 동적으로 확장합니다.
* 동적 리소스 할당(DRA): 쿠버네티스 ResourceClaim을 통해 공급업체별 하드웨어 리소스 지원(e.g., NVIDIA 또는 AMD의 GPU).
* [GPU 공유](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/gpu-sharing/README.md): 여러 워크로드가 하나 또는 여러 GPU를 효율적으로 공유하여 리소스 활용을 극대화합니다.
* 클라우드 및 온프레미스 지원: 동적 클라우드 인프라(카펜터와 같은 오토스케일러 포함)는 물론 정적인 온프레미스 배포와도 완벽하게 호환됩니다.

## 사전 준비 사항
KAI 스케줄러를 설치하기 전에 다음을 준비하세요:

- 실행 중인 쿠버네티스 클러스터
- [Helm](https://helm.sh/docs/intro/install) CLI 설치
- GPU 리소스를 요청하는 워크로드를 스케줄링하기 위해 [NVIDIA GPU-Operator](https://github.com/NVIDIA/gpu-operator) 설치

## 설치
KAI 스케줄러는 `kai-scheduler` 네임스페이스에 설치됩니다. 워크로드를 제출할 때는 전용 네임스페이스를 사용하세요.

### 설치 방법
KAI 스케줄러는 다음과 같이 설치할 수 있습니다:

- **프로덕션에서 설치(권장)**
- **소스에서 직접 빌드하여 설치**

#### 프로덕션에서 설치
[릴리즈](https://github.com/NVIDIA/KAI-Scheduler/releases) 페이지에서 최신 릴리즈 버전을 확인하세요.
원하는 릴리즈 버전으로 `<VERSION>`을 바꾼 뒤 아래 명령어를 실행하세요:
```sh
helm upgrade -i kai-scheduler oci://ghcr.io/nvidia/kai-scheduler/kai-scheduler -n kai-scheduler --create-namespace --version <VERSION>
```
#### 소스에서 빌드하여 설치
[여기](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/developer/building-from-source.md)의 지침을 따르세요.

## 빠른 시작
KAI 스케줄러로 워크로드 스케줄링을 시작하려면 [빠른 시작 예제](https://raw.githubusercontent.com/NVIDIA/KAI-Scheduler/main/docs/quickstart/README.md)를 참고하세요.

## 로드맵

### 2025년 주요 우선순위 개요
* 코드베이스 리팩터링을 통한 벤더 중립성 강화
* Scheduling Gates 지원 https://github.com/NVIDIA/KAI-Scheduler/issues/63
* Kueue와의 통합 가능성 연구 https://github.com/NVIDIA/KAI-Scheduler/issues/68
* pod-group의 토폴로지 인식 스케줄링 지원 추가 https://github.com/NVIDIA/KAI-Scheduler/issues/66
* 워크로드별 최소 실행 시간 지원
* 워크로드별 최대 실행 시간 지원(지연 재큐와 함께)
* 기본 KAI 설치에 더 많은 PriorityClass 추가
* JobSet 지원
* LWS(LeaderWorkerSet) 지원
* 파드 및 파드 그룹 선점(preemption) 지표 추가
* 우선순위와 선점 기능 분리

### 장기 목표
* 큐별 시간 감쇠(time decay) 지원
* 하이퍼스케일 개선
* 클러스터 조각화 방지를 위한 추론 워크로드 통합 지원
* n단계 계층적 큐 지원
* 추론 워크로드의 점진적 롤아웃(큐 임시 초과 쿼터 활용한 새 리비전 업데이트)

## 커뮤니티, 토론 및 지원

여러분의 의견을 기다립니다! 소통 방법은 다음과 같습니다:

### 슬랙
먼저 [CNCF 슬랙](https://communityinviter.com/apps/cloud-native/cncf)에 가입 후, [#kai-scheduler](https://cloud-native.slack.com/archives/kai-scheduler) 채널을 방문하세요.

### 격주 커뮤니티 콜  
**일시:** 격주 월요일 17:00 CEST  
[시간대 변환](https://dateful.com/time-zone-converter?t=17&tz2=Germany) | [캘린더에 추가](https://calendar.google.com/calendar/event?action=TEMPLATE&tmeid=N2Q2bjhoNXAzMGc0cWpnZTQ4OGtpdXFhanFfMjAyNTA2MDlUMTUwMDAwWiAxZjQ2OTZiOWVlM2JiMWE1ZWIzMTAwODBkNDZiZmMwMDZjNTUxYWFiZmU1YTM3ZGM2YTc0NTFhYmNhMmE1ODk0QGc&tmsrc=1f4696b9ee3bb1a5eb310080d46bfc006c551aabfe5a37dc6a7451abca2a5894%40group.calendar.google.com&scp=ALL)  | [미팅 노트 & 아젠다](https://docs.google.com/document/d/13K7NGdPebOstlrsif1YLjGz1x-aJafMXeIgqbO7WghI/edit?usp=sharing)

### 메일링 리스트  
격주 미팅 업데이트를 받으려면 [kai-scheduler 메일링 리스트](https://groups.google.com/g/kai-scheduler)에 가입하세요.

### 기술 이슈 & 기능 요청  
버그, 기능 제안 또는 기술 지원이 필요하시면 [GitHub 이슈](https://github.com/NVIDIA/KAI-Scheduler/issues/new/choose)를 생성해 주세요. 요청을 추적하고 효과적으로 대응하는 데 도움이 됩니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---