# OneTwoVLA: 적응형 추론을 갖춘 통합 비전-언어-행동 모델

[[프로젝트 페이지]](https://one-two-vla.github.io/) [[논문]](https://arxiv.org/abs/2505.11917) [[처리된 데이터셋]](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)

[Fanqi Lin](https://fanqi-lin.github.io/)<sup>1,2,3,5\*</sup>,
[Ruiqian Nai](https://richard-coder-nai.github.io/)<sup>1,2,3,5\*</sup>,
[Yingdong Hu](https://yingdong-hu.github.io/)<sup>1,2,3\*</sup>,
[Jiacheng You](https://scholar.google.com/citations?user=FiP-TVUAAAAJ)<sup>1,2,3</sup>,
Junming Zhao<sup>1,4</sup>,
[Yang Gao](https://yang-gao.weebly.com/)<sup>1,2,3,5</sup>

<sup>1</sup>칭화대학,
<sup>2</sup>상하이 치즈 연구소,
<sup>3</sup>상하이 AI 연구소,
<sup>4</sup>복단대학,
<sup>5</sup>Spirit AI

<sup>\*</sup>는 동등한 기여를 나타냅니다


## 🛠️ 설치

우리는 Python 의존성을 [uv](https://docs.astral.sh/uv/)로 관리합니다. `uv`를 설치하지 않았다면, [uv 설치 안내](https://docs.astral.sh/uv/getting-started/installation/)를 따라 설치해 주세요.

다음 명령어로 환경을 설정합니다:

```bash
GIT_LFS_SKIP_SMUDGE=1 uv sync
GIT_LFS_SKIP_SMUDGE=1 uv pip install -e .
```
> 참고: LeRobot을 의존성으로 가져오기 위해 `GIT_LFS_SKIP_SMUDGE=1`이 필요합니다.

자세한 내용은 원본 [openpi 저장소](https://github.com/Physical-Intelligence/openpi.git)를 참조하세요.

## 🚀 OneTwoVLA 훈련하기
데이터셋을 다운로드하여 `$LEROBOT_HOME/umi/` 아래에 위치시킵니다.

OneTwoVLA 모델을 훈련하려면, 다음을 실행하세요:

```bash
bash train_scripts/train_<task_name>.sh
```
사용 가능한 작업은 다음과 같습니다:
```bash
train_scripts
|-- train_onetwovla_cocktail.sh
|-- train_onetwovla_visual_grounding.sh
|-- train_pi0_cocktail.sh
|-- train_pi0_visual_grounding.sh
```
## 🦾 실제 배포  
우리는 정책 서버와 하드웨어 클라이언트를 사용하여 추론을 수행합니다. 정책 서버 실행 지침은 [examples/umi/README.md](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/README.md)에서 확인할 수 있으며, UMI 하드웨어 클라이언트 코드는 이 [저장소](https://github.com/Fanqi-Lin/OneTwoVLA-UMI-Client)에서 제공합니다.  

## 📷 데이터  
다음 데이터셋에 대한 접근을 제공합니다:  

- `로봇 데이터셋`: `칵테일` 및 `오픈월드 비주얼 그라운딩` 작업용 데이터셋.  
- `비전-언어 데이터셋`: `오픈월드 비주얼 그라운딩` 작업을 위한 합성 이미지 및 주석된 추론 포함 데이터셋.  

모든 데이터셋은 Hugging Face에서 호스팅됩니다. [여기](https://huggingface.co/datasets/Richard-Nai/onetwovla-dataset)에서 확인할 수 있습니다.  

UMI 데이터 포맷을 LeRobot 데이터 포맷으로 변환하는 코드는 [여기](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/examples/umi/convert_umi_data_to_lerobot.py)에서 제공합니다.  

### 합성 이미지 증강  

합성 이미지가 실제 로봇 관측과 더 유사해지도록, 랜덤 어그멘테이션을 적용하며, 여기에는 랜덤 어안 렌즈 왜곡과 적응형 밝기 조정이 포함된 로봇 그리퍼 합성이 포함됩니다. 구현은 [scripts/augment_vl_data/augment.py](https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/scripts/augment_vl_data/augment.py)에서 확인할 수 있습니다.  

다음은 예시입니다. 좌측부터 우측으로 원본 이미지, 어안 렌즈 왜곡 적용 이미지, 적응형 밝기 조정이 적용된 로봇 그리퍼 합성 이미지, 두 가지 모두 적용된 이미지입니다.  

<img width="90%" src="https://raw.githubusercontent.com/Fanqi-Lin/OneTwoVLA/main/figures/fisheye-aug.png">  

## 🙏 감사의 말씀  
코드를 오픈 소스로 공개해주신 [openpi](https://github.com/Physical-Intelligence/openpi.git) 개발자분들께 진심으로 감사드립니다.  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---