<div align="center">

# TAPIP3D: 영속적인 3D 기하학에서 임의의 점 추적하기
<a href="https://arxiv.org/abs/2504.14717"><img src='https://img.shields.io/badge/arXiv-Paper-red?logo=arxiv&logoColor=white' alt='arXiv'></a>
<a href='https://tapip3d.github.io'><img src='https://img.shields.io/badge/Project_Page-Website-green?logo=googlechrome&logoColor=white' alt='Project Page'></a>

[Bowei Zhang](https://scholar.google.com/citations?user=tYH72AYAAAAJ)<sup>1,2</sup>*, [Lei Ke](https://www.kelei.site/)<sup>1</sup>\*, [Adam W. Harley](https://adamharley.com/)<sup>3</sup>, [Katerina Fragkiadaki](https://www.cs.cmu.edu/~katef/)<sup>1</sup>

<sup>1</sup>카네기 멜론 대학교   &nbsp;  <sup>2</sup>베이징 대학교 &nbsp;  <sup>3</sup>스탠포드 대학교

**NeurIPS 2025**

\* 동등 기여

<!-- <a href='https://huggingface.co/spaces/your-username/project'><img src='https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Live_Demo-blue'></a> -->

</div>

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/teaser1.gif" width="100%" alt="TAPIP3D 개요">


---

### 🚀 뉴스
- **(2025.12.28)** 🔥 **학습(Training)** 및 **평가(Evaluation)** 코드를 업데이트했습니다! 아래의 새로운 섹션을 확인하세요.

## 개요
**TAPIP3D**는 단안 RGB 및 RGB-D 비디오 시퀀스에서 장기 **피드포워드(feed-forward)** 3D 점 추적을 위한 방법입니다. 이미지 특징을 영속적인 월드 좌표 공간으로 변환하는 3D 특징 클라우드 표현을 도입하여 카메라 움직임을 상쇄하고 프레임 간 정확한 궤적 추정을 가능하게 합니다.

TAPIP3D에 대한 자세한 [비디오 설명](https://neurips.cc/virtual/2025/loc/san-diego/poster/117634#:~:text=Within%20this%20stabilized%203D%20representation,trained%20checkpoints%20will%20be%20public.)을 제공합니다.

## 설치
### 의존성 설치

1. 환경을 준비하세요
```bash
conda create -n tapip3d python=3.10
conda activate tapip3d

pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 "xformers>=0.0.27" --index-url https://download.pytorch.org/whl/cu124
pip install torch-scatter -f https://data.pyg.org/whl/torch-2.4.1+cu124.html
pip install -r requirements.txt
```

2. pointops2 컴파일하기

```bash
cd third_party/pointops2
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../..
```

3. megasam 컴파일하기
```bash
cd third_party/megasam/base
LIBRARY_PATH=$CONDA_PREFIX/lib:$LIBRARY_PATH python setup.py install
cd ../../..
```
### 체크포인트 다운로드

TAPIP3D 모델 체크포인트를 [여기](https://huggingface.co/zbww/tapip3d/resolve/main/tapip3d_final.pth)에서 다운로드하여 `checkpoints/tapip3d_final.pth`에 저장하세요.

단안 비디오에서 TAPIP3D를 실행하려면 MegaSAM을 실행하기 위해 다음 체크포인트들을 수동으로 준비해야 합니다:

1. [여기](https://huggingface.co/spaces/LiheYoung/Depth-Anything/resolve/main/checkpoints/depth_anything_vitl14.pth)에서 DepthAnything V1 체크포인트를 다운로드하여 `third_party/megasam/Depth-Anything/checkpoints/depth_anything_vitl14.pth`에 넣으세요.

2. [여기](https://drive.google.com/drive/folders/1sWDsfuZ3Up38EUQt7-JDTT1HcGHuJgvT)에서 RAFT 체크포인트를 다운로드하여 `third_party/megasam/cvd_opt/raft-things.pth`에 넣으세요.

또한, [MoGe](https://wangrc.site/MoGePage/)와 [UniDepth](https://github.com/lpiccinelli-eth/UniDepth.git) 체크포인트는 데모 실행 시 자동으로 다운로드됩니다. 네트워크 연결이 가능한지 확인하세요.

## 데모 사용법

간단한 데모 스크립트 `inference.py`와 `demo_inputs/` 디렉터리에 위치한 샘플 입력 데이터를 제공합니다.

스크립트는 입력으로 `.mp4` 비디오 파일 또는 `.npz` 파일을 받습니다. `.npz` 파일을 제공할 경우 다음 형식을 따라야 합니다:

- `video`: (T, H, W, 3) 형태의 배열, dtype: uint8
- `depths` (선택적): (T, H, W) 형태의 배열, dtype: float32
- `intrinsics` (선택적): (T, 3, 3) 형태의 배열, dtype: float32
- `extrinsics` (선택적): (T, 4, 4) 형태의 배열, dtype: float32

데모 목적상, 스크립트는 첫 번째 프레임에서 32x32 격자의 점들을 쿼리로 사용합니다.


### 단안 비디오 추론

`--input_path`로 비디오를 제공하면, 스크립트는 먼저 [MegaSAM](https://github.com/mega-sam/mega-sam)과 [MoGe](https://wangrc.site/MoGePage/)를 사용하여 깊이 맵과 카메라 파라미터를 추정합니다. 이후 모델은 전역 프레임 내에서 이 입력을 처리합니다.

**데모 1**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo1.gif" width="100%" alt="Demo 1">

추론을 실행하려면:


```bash
python inference.py --input_path demo_inputs/sheep.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

npz 파일이 `outputs/inference/`에 저장됩니다. 결과를 시각화하려면:

```bash
python visualize.py <result_npz_path>
```

**Demo 2**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo2.gif" width="100%" alt="Demo 2">

```bash
python inference.py --input_path demo_inputs/pstudio.mp4 --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

**알려진 깊이 및 카메라 매개변수를 사용한 추론**

네 가지 키(`rgb`, `depths`, `intrinsics`, `extrinsics`)가 모두 포함된 `.npz` 파일이 제공되면, 모델은 정렬된 전역 좌표계에서 작동하여 세계 좌표계로 점 궤적을 생성합니다.  
예제 `.npz` 파일 하나를 [여기](https://huggingface.co/zbww/tapip3d/resolve/main/demo_inputs/dexycb.npz?download=true)에서 제공하며, `demo_inputs/` 디렉터리에 넣어주세요.

**데모 3**

<img src="https://raw.githubusercontent.com/zbw001/TAPIP3D/main/./media/demo3.gif" width="100%" alt="Demo 3">

```bash
python inference.py --input_path demo_inputs/dexycb.npz --checkpoint checkpoints/tapip3d_final.pth --resolution_factor 2
```

## 교육 및 평가

### 1. 데이터셋 준비
학습 및 평가를 위한 데이터셋 준비 방법은 [DATASET.md](https://raw.githubusercontent.com/zbw001/TAPIP3D/main/DATASET.md)를 참조하세요.

### 2. 학습
학습을 시작하려면 다음 명령어를 실행하세요:
```bash
bash scripts/train.sh
```
- `experiment_name`: **WandB**에 표시되는 실행 이름입니다.
- `experiment_id`: 고유 식별자입니다. 동일한 `experiment_id`로 재실행하면 **가장 최근 체크포인트에서 자동으로** 훈련이 재개됩니다.

### 3. 평가
체크포인트를 평가하려면 다음을 실행하세요:
```bash
bash scripts/eval.sh
```
`checkpoint` 변수를 `scripts/eval.sh`에서 수정하여 평가할 모델을 지정할 수 있습니다.

## 인용
이 프로젝트가 유용하다면, 인용을 고려해 주세요:

```
@article{tapip3d,
  title={TAPIP3D: Tracking Any Point in Persistent 3D Geometry},
  author={Zhang, Bowei and Ke, Lei and Harley, Adam W and Fragkiadaki, Katerina},
  journal={arXiv preprint arXiv:2504.14717},
  year={2025}
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-12

---