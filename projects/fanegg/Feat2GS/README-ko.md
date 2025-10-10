<h2 align="center"> <a href="https://arxiv.org/abs/2412.09606">Feat2GS: 가우시안 스플래팅을 이용한 시각 기초 모델 탐색</a>
</h2>

<h5 align="center">

[![arXiv](https://img.shields.io/badge/Arxiv-2412.09606-b31b1b.svg?logo=arXiv)](https://arxiv.org/abs/2412.09606) 
[![Home Page](https://img.shields.io/badge/Project-Website-green.svg)](https://fanegg.github.io/Feat2GS/)  [![youtube](https://img.shields.io/badge/Video-E33122?logo=Youtube)](https://youtu.be/4fT5lzcAJqo?si=_fCSIuXNBSmov2VA)  [![Gradio](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Demo-orange)](https://huggingface.co/spaces/endless-ai/Feat2GS)  [![X](https://img.shields.io/badge/@Yue%20Chen-black?logo=X)](https://twitter.com/faneggchen)  [![Bluesky](https://img.shields.io/badge/@Yue%20Chen-white?logo=Bluesky)](https://bsky.app/profile/fanegg.bsky.social)

[Yue Chen](https://fanegg.github.io/),
[Xingyu Chen](https://rover-xingyu.github.io/),
[Anpei Chen](https://apchenstu.github.io/),
[Gerard Pons-Moll](https://virtualhumans.mpi-inf.mpg.de/),
[Yuliang Xiu](https://xiuyuliang.cn/)
</h5>

<div align="center">
이 저장소는 시각 기초 모델의 “텍스처 및 기하학 인식”을 탐색하기 위한 통합 프레임워크인 Feat2GS의 공식 구현체입니다. 새로운 뷰 합성은 3D 평가를 위한 효과적인 대리 지표로 작용합니다.
</div>
<br>

https://github.com/user-attachments/assets/07ebb8e1-6001-47bf-bf74-984b0032cc17


## 업데이트

- [2025년 7월 10일] VGGT 인코더 및 디코더 특징의 새로운 평가 추가. 결과는 [여기](https://raw.githubusercontent.com/fanegg/Feat2GS/main/assets/Feat2GS_Benchmark.pdf)에서 확인하세요.

## 시작하기

### 설치
1. Feat2GS를 클론하고 [DUSt3R](https://github.com/naver/dust3r)/[MASt3R](https://github.com/naver/mast3r)에서 사전 학습된 모델을 다운로드하세요.

```bash
git clone https://github.com/fanegg/Feat2GS.git
cd Feat2GS/submodules/mast3r/
mkdir -p checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/DUSt3R/DUSt3R_ViTLarge_BaseDecoder_512_dpt.pth -P checkpoints/
wget https://download.europe.naverlabs.com/ComputerVision/MASt3R/MASt3R_ViTLarge_BaseDecoder_512_catmlpdpt_metric.pth -P checkpoints/
cd ../../
```
2. 환경을 생성합니다. 여기서는 conda를 사용하는 예를 보여줍니다.

```bash
conda create -n feat2gs python=3.11 cmake=3.14.0
conda activate feat2gs
pip install "torch==2.5.1" "torchvision==0.20.1" "numpy<2" --index-url https://download.pytorch.org/whl/cu121  # use the correct version of cuda for your system
cd Feat2GS/
pip install -r requirements.txt
pip install submodules/simple-knn
```
3. 선택 사항이지만 강력히 권장되며, RoPE용 cuda 커널을 컴파일하십시오(크로코 v2와 동일).

```bash
# DUST3R relies on RoPE positional embeddings for which you can compile some cuda kernels for faster runtime.
cd submodules/mast3r/dust3r/croco/models/curope/
python setup.py build_ext --inplace
cd ../../../../../../
```
4. (선택 사항) [이 지침](https://github.com/cvlab-columbia/zero123?tab=readme-ov-file#novel-view-synthesis-1)을 따라 [Zero123](https://github.com/cvlab-columbia/zero123) 탐색을 위한 요구 사항을 설치하세요.

### 사용법
1. 데이터 준비 (평가 및 추론 데이터셋을 제공합니다: [링크](https://drive.google.com/file/d/1PLTFcvJfiPucrB-pIwfp5QG-AIHcJdjN/view?usp=drive_link))

```bash
  cd <data_root>/Feat2GS/
```
> 사용자 정의 데이터셋을 구축하려면 다음을 따르고 편집하세요:
> ```
> build_dataset/0_create_json.py ## train/test 세트를 분할하기 위한 dataset_split.json 생성
> build_dataset/1_create_feat2gs_dataset.py ## dataset_split.json을 사용하여 데이터셋 생성
> ```


2. Visual Foundation Models 평가:

  | 단계 | 설명 (명령어 링크) |
  |------|-------------|
  | (1)  | [DUSt3R 초기화 및 특징 추출](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L245-L250) |
  | (2)  | [특징에서 3DGS 읽어오기 및 자세 공동 최적화](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L253-L262) |
  | (3)  | [테스트 자세 초기화](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L265-L270) |
  | (4)  | [평가를 위한 테스트 뷰 렌더링](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L273-L282) |
  | (5)  | [지표](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L298-L301) |
  | (선택)  | [생성된 경로로 비디오 렌더링](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L304-L315) |


```bash
  # Run evaluation for all datasets, all VFM features, all probing modes
  bash scripts/run_feat2gs_eval_parallel.sh

  # (Example) Run evaluation for a single scene, DINO feature, Geometry mode
  bash scripts/run_feat2gs_eval.sh
```
> [!NOTE]
> 병렬로 실험을 실행하기 위해, GPU당 하나의 평가 실험만 실행되도록 **GPU 잠금(lock)** 기능을 추가했습니다. 실험이 완료되면 GPU는 자동으로 잠금 해제됩니다. **`Ctrl+C`로 중단할 경우 GPU가 자동으로 잠금 해제되지 않습니다.** 이 문제를 해결하려면 `LOCK_DIR`에 있는 `.lock` 파일을 수동으로 삭제하세요. 이 기능을 비활성화하려면 스크립트에서 다음 줄들을 주석 처리하세요:
    [L4-L5](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L4-L5),
    [L9-L22](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L9-L22),
    [L223-L233](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L223-L233),
    [L330-L331](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L330-L331).

  | 구성 | 작업 내용 |
  |--------|-----------------|
  | GPU | [`<AVAILABLE_GPUS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L7)에서 편집 |
  | 데이터셋 | [`<SCENES[$Dataset]>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L105-L111)에서 편집 |
  | 씬 | [`<SCENES_$Dataset>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L31-L99)에서 편집 |
  | 비주얼 파운데이션 모델 | [`<FEATURES>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L120-L162)에서 편집 |
  | 프로빙 모드 | [`<MODELS>`](https://github.com/fanegg/Feat2GS/blob/b8eadaa54549d34420eba61b388548b8ec8e7325/scripts/run_feat2gs_eval_parallel.sh#L181-L188)에서 편집 |
  | 추론 전용 모드 | [`execute_command`](https://github.com/fanegg/Feat2GS/blob/main/scripts/run_feat2gs_eval_parallel.sh#L325-L327)의 STEP (3)(4)(5)를 주석 처리 |

```bash
  # Evaluate Visual Foundation Models on DTU dataset
  bash scripts/run_feat2gs_eval_dtu_parallel.sh

  # Run InstantSplat for evaluation
  bash scripts/run_instantsplat_eval_parallel.sh
```
3. 학습 후, 생성된 경로를 사용하여 RGB/깊이/노멀 비디오를 렌더링합니다.


```bash
  # If render depth/normal, set RENDER_DEPTH_NORMAL=true
  # Set type of generated trjectory by editing <TRAJ_SCENES>
  bash scripts/run_video_render.sh

  # Render video on DTU dataset
  bash scripts/run_video_render_dtu.sh
```
### 🎮 인터랙티브 데모

#### 🚀 빠른 시작
1. **입력 이미지**
* 동일한 장면의 서로 다른 시점에서 촬영한 2장 이상의 이미지를 업로드하세요
* 최상의 결과를 위해 이미지 간 겹침이 충분한지 확인하세요

2. **1단계: DUSt3R 초기화 및 특징 추출**
* "RUN Step 1"을 클릭하여 이미지를 처리하세요
* 이 단계에서는 초기 DUSt3R 포인트 클라우드와 카메라 위치를 추정하고 각 픽셀에 대해 DUSt3R 특징을 추출합니다

3. **2단계: 특징에서 3DGS 읽어오기**
* 학습 반복 횟수를 설정하세요. 숫자가 클수록 품질은 향상되지만 시간이 더 오래 걸립니다 (기본값: 2000, 최대: 8000)
* "RUN Step 2"를 클릭하여 3D 모델을 최적화하세요

4. **3단계: 비디오 렌더링**
* 카메라 궤적을 선택하세요
* "RUN Step 3"을 클릭하여 3D 모델의 비디오를 생성하세요

```bash
gradio demo.py
```
#### 💡 팁
* 처리 시간은 이미지 해상도와 수량에 따라 다릅니다.
* 최적의 성능을 위해 고성능 GPU(A100/4090)에서 테스트하세요.
* 마우스를 사용하여 3D 모델과 상호작용할 수 있습니다:
  - 왼쪽 버튼: 회전
  - 스크롤 휠: 확대/축소
  - 오른쪽 버튼: 이동


## 감사의 글

이 작업은 많은 훌륭한 연구 작업과 오픈 소스 프로젝트를 기반으로 합니다. 공유해주신 모든 저자분들께 진심으로 감사드립니다!

- [Gaussian-Splatting](https://github.com/graphdeco-inria/gaussian-splatting) 및 [diff-gaussian-rasterization](https://github.com/graphdeco-inria/diff-gaussian-rasterization)
- [gsplat](https://github.com/nerfstudio-project/gsplat)
- [DUSt3R](https://github.com/naver/dust3r) 및 [MASt3R](https://github.com/naver/mast3r)
- [InstantSplat](https://github.com/NVlabs/InstantSplat)
- [Probe3D](https://github.com/mbanani/probe3d)
- [FeatUp](https://github.com/mhamilton723/FeatUp)
- [Shape of Motion](https://github.com/vye16/shape-of-motion/)
- [Splatt3R](https://github.com/btsmart/splatt3r)
- [VGGT](https://github.com/facebookresearch/vggt)

## 인용
본 연구가 여러분의 연구에 도움이 되었다면, 별 :star: 을 눌러주시고 다음 논문 :pencil: 을 인용해 주시기 바랍니다.


```bibTeX
@inproceedings{chen2025feat2gs,
  title={Feat2gs: Probing visual foundation models with gaussian splatting},
  author={Chen, Yue and Chen, Xingyu and Chen, Anpei and Pons-Moll, Gerard and Xiu, Yuliang},
  booktitle={Proceedings of the Computer Vision and Pattern Recognition Conference},
  pages={6348--6361},
  year={2025}
}
```

## 연락처

피드백, 질문 또는 언론 문의는 [Yue Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:faneggchen@gmail.com) 및 [Xingyu Chen](https://raw.githubusercontent.com/fanegg/Feat2GS/main/mailto:roverxingyu@gmail.com)에게 연락해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-10

---