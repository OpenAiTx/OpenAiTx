# 파이토치에서의 플로우 매칭

이 저장소는 논문 [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747)의 간단한 파이토치 구현을 포함하고 있습니다.

## 2D 플로우 매칭 예제

아래 gif는 단일 가우시안 분포를 체커보드 분포로 매핑하는 과정을 벡터 필드와 함께 시각화한 것입니다.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_checkerboard.gif" height="400" />
</p>

그리고, 여기 달 모양 데이터셋의 또 다른 예제가 있습니다.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_moons.gif" height="400" />
</p>

## 시작하기

저장소를 클론하고 파이썬 환경을 설정하세요.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```
Python 3.10 이상이 설치되어 있는지 확인하세요.
`uv`를 사용하여 파이썬 환경을 설정하려면:


```bash
uv sync
source .venv/bin/activate
```

또는 `pip`을 사용하여:

```bash
python -m venv .venv
source .venv/bin/activate
pip install -e .
```

## 조건부 플로우 매칭 [Lipman+ 2023]

이는 원본 CFM 논문 구현 [1]입니다. 코드의 일부 구성 요소는 [2]와 [3]에서 가져왔습니다.

### 2D 토이 데이터셋

`checkerboard` 및 `moons`와 같은 2D 합성 데이터셋에서 CFM 모델을 학습할 수 있습니다. `--dataset` 옵션으로 데이터셋 이름을 지정하세요. 학습 매개변수는 스크립트에 미리 정의되어 있으며, 학습 결과 시각화는 `outputs/` 디렉토리에 저장됩니다. 기본 설정으로 쉽게 재현 가능하므로 모델 체크포인트는 포함되어 있지 않습니다.

```bash
python train_flow_matching_2d.py --dataset checkerboard
```
벡터 필드와 생성된 샘플들은 이 README 상단에 GIF로 표시된 것과 같이 이제 `outputs/cfm/` 디렉토리에서 찾을 수 있습니다.

### 이미지 데이터셋

또한 인기 있는 이미지 분류 데이터셋에서 클래스 조건부 CFM 모델을 훈련할 수 있습니다. 생성된 샘플과 모델 체크포인트는 모두 `outputs/cfm` 디렉토리에 저장됩니다. 훈련 파라미터의 자세한 목록은 `python train_flow_matching_on_images.py --help` 명령어를 실행하세요.

MNIST 데이터셋에서 클래스 조건부 CFM을 훈련하려면 다음을 실행하세요:


```bash
python train_flow_matching_on_image.py --do_train --dataset mnist
```

학습 후에는 다음과 같이 샘플을 생성할 수 있습니다:

```bash
python train_flow_matching_on_image.py --do_sample --dataset mnist
```
이제 `outputs/cfm/mnist/` 디렉토리에서 생성된 샘플을 볼 수 있습니다.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

이는 Rectified Flow 논문 [2]에서 제안된 Reflow 모델(특히 2-Rectified Flow)의 구현입니다.

### 2D 합성 데이터

CFM과 동일하게 2D 합성 데이터셋에서 Reflow를 구현했습니다. Reflow는 증류 모델이기 때문에 학습 시 사전 학습된 CFM 체크포인트를 지정해야 합니다.

예를 들어, 사전 학습된 CFM 체크포인트로 `checkerboard` 데이터셋에서 학습하려면:


```bash
python train_reflow_2d.py --dataset checkerboard --pretrained-model outputs/cfm/checkerboard/ckpt.pth
```
학습 결과는 벡터 필드 시각화 및 생성된 샘플을 포함하여 `outputs/reflow/` 폴더에 저장됩니다.

### CFM과 Reflow의 샘플링 과정 비교

2차원 데이터셋에서 CFM과 Reflow를 비교하려면 다음을 실행하세요:


```bash
python plot_comparison_2d.py --dataset checkerboard
```
결과 GIF는 `outputs/comparisons/` 폴더에서 확인할 수 있습니다. 아래는 `checkerboard` 데이터셋에서 두 방법의 비교 예시입니다:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## 참고문헌

- [1] Lipman, Yaron, et al. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, et al. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-24

---