# Mapperatorinator

[여기](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)에서 생성 모델을 시도하거나, [여기](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)에서 MaiMod를 사용해보세요. 비디오 쇼케이스는 [여기](https://youtu.be/FEr7t1L2EoA)에서 확인할 수 있습니다.

Mapperatorinator는 스펙트로그램 입력을 사용하여 모든 게임 모드에 대해 완전한 기능의 osu! 비트맵을 생성하고 [보조 모딩 비트맵](#maimod-the-ai-driven-modding-tool)을 지원하는 멀티 모델 프레임워크입니다.
이 프로젝트의 목표는 높은 수준의 사용자 정의 가능성으로 어떤 노래든 자동으로 랭크 가능한 품질의 osu! 비트맵을 생성하는 것입니다.

이 프로젝트는 [osuT5](https://github.com/gyataro/osuT5)와 [osu-diffusion](https://github.com/OliBomby/osu-diffusion)를 기반으로 구축되었습니다. 개발 과정에서 4060 Ti와 vast.ai에서 임대한 4090 인스턴스를 사용하여 총 142회 실행에 약 2500시간의 GPU 연산 시간을 투자했습니다.

#### 이 도구를 책임감 있게 사용하세요. 비트맵에 AI 사용 사실을 항상 공개하세요.

## 설치

아래 지침을 따르면 로컬 머신에서 비트맵을 생성할 수 있으며, 또는 [colab 노트북](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mapperatorinator_inference.ipynb)에서 클라우드로 실행할 수 있습니다.

### 1. 저장소 복제하기

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```
### 2. (선택 사항) 가상 환경 생성

Python 3.10을 사용하세요, 이후 버전은 종속성과 호환되지 않을 수 있습니다.


```sh
python -m venv .venv

# In cmd.exe
.venv\Scripts\activate.bat
# In PowerShell
.venv\Scripts\Activate.ps1
# In Linux or MacOS
source .venv/bin/activate
```
### 3. 의존성 설치

- Python 3.10  
- [Git](https://git-scm.com/downloads)  
- [ffmpeg](http://www.ffmpeg.org/)  
- [CUDA](https://developer.nvidia.com/cuda-zone) (NVIDIA GPU용) 또는 [ROCm](https://rocmdocs.amd.com/en/latest/Installation_Guide/Installation-Guide.html) (리눅스의 AMD GPU용)  
- [PyTorch](https://pytorch.org/get-started/locally/): `torch` 및 `torchaudio`를 GPU 지원과 함께 설치하도록 시작 가이드를 반드시 따르세요. 이전 단계에서 설치한 올바른 컴퓨트 플랫폼 버전을 선택하세요.  

- 그리고 나머지 Python 의존성:


```sh
pip install -r requirements.txt
```
## 웹 GUI (권장)

더 사용자 친화적인 경험을 위해 웹 UI 사용을 고려하십시오. 생성 매개변수를 구성하고, 프로세스를 시작하며, 출력을 모니터링할 수 있는 그래픽 인터페이스를 제공합니다.

### GUI 실행하기

터미널에서 클론한 `Mapperatorinator` 디렉토리로 이동한 후 다음 명령어를 실행하세요:


```sh
python web-ui.py
```
이 명령은 로컬 웹 서버를 시작하고 UI를 새 창에서 자동으로 엽니다.

### GUI 사용법

- **설정:** 입력/출력 경로를 양식 필드와 "찾아보기" 버튼을 사용해 설정합니다. 게임 모드, 난이도, 스타일(연도, 매퍼 ID, 설명자), 타이밍, 특정 기능(히트사운드, 슈퍼 타이밍) 등 명령줄 옵션과 동일하게 생성 매개변수를 조정합니다. (참고: `beatmap_path`를 제공하면 UI가 자동으로 `audio_path`와 `output_path`를 결정하므로 해당 필드를 비워둘 수 있습니다)
- **시작:** "Start Inference" 버튼을 클릭하여 비트맵 생성을 시작합니다.
- **취소:** 진행 중인 프로세스는 "Cancel Inference" 버튼으로 중단할 수 있습니다.
- **출력 열기:** 완료되면 "Open Output Folder" 버튼을 사용하여 생성된 파일에 빠르게 접근할 수 있습니다.

웹 UI는 `inference.py` 스크립트를 편리하게 감싸는 래퍼 역할을 합니다. 고급 옵션이나 문제 해결은 명령줄 지침을 참조하세요.

![python_u3zyW0S3Vs](https://github.com/user-attachments/assets/5312a45f-d51c-4b37-9389-da3258ddd0a1)

## 명령줄 추론

명령줄을 선호하거나 고급 설정이 필요한 사용자는 아래 단계를 따르십시오. **참고:** 더 간단한 그래픽 인터페이스가 필요하면 위의 [웹 UI (권장)](#web-ui-recommended) 섹션을 참고하세요.

`inference.py`를 실행하고 인수를 전달하여 비트맵을 생성합니다. 이를 위해 [Hydra override 구문](https://hydra.cc/docs/advanced/override_grammar/basic/)을 사용하세요. 사용 가능한 모든 매개변수는 `configs/inference_v29.yaml`을 참조하세요.

```
python inference.py \
  audio_path           [Path to input audio] \
  output_path          [Path to output directory] \
  beatmap_path         [Path to .osu file to autofill metadata, and output_path, or use as reference] \
  
  gamemode             [Game mode to generate 0=std, 1=taiko, 2=ctb, 3=mania] \
  difficulty           [Difficulty star rating to generate] \
  mapper_id            [Mapper user ID for style] \
  year                 [Upload year to simulate] \
  hitsounded           [Whether to add hitsounds] \
  slider_multiplier    [Slider velocity multiplier] \
  circle_size          [Circle size] \
  keycount             [Key count for mania] \
  hold_note_ratio      [Hold note ratio for mania 0-1] \
  scroll_speed_ratio   [Scroll speed ratio for mania and ctb 0-1] \
  descriptors          [List of beatmap user tags for style] \
  negative_descriptors [List of beatmap user tags for classifier-free guidance] \
  
  add_to_beatmap       [Whether to add generated content to the reference beatmap instead of making a new beatmap] \
  start_time           [Generation start time in milliseconds] \
  end_time             [Generation end time in milliseconds] \
  in_context           [List of additional context to provide to the model [NONE,TIMING,KIAI,MAP,GD,NO_HS]] \
  output_type          [List of content types to generate] \
  cfg_scale            [Scale of the classifier-free guidance] \
  super_timing         [Whether to use slow accurate variable BPM timing generator] \
  seed                 [Random seed for generation] \
```
예:

```
python inference.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'" gamemode=0 difficulty=5.5 year=2023 descriptors="['jump aim','clean']" in_context=[TIMING,KIAI]
```

## 대화형 CLI
터미널 기반 작업 방식을 선호하지만 안내되는 설정을 원한다면, 대화형 CLI 스크립트가 웹 UI에 대한 훌륭한 대안입니다.

### CLI 실행
복제한 디렉토리로 이동합니다. 먼저 스크립트에 실행 권한을 부여해야 할 수도 있습니다.

```sh
# Make the script executable (only needs to be done once)
chmod +x cli_inference.sh
```

```sh
# Run the script
./cli_inference.sh
```
### CLI 사용법  
스크립트는 웹 UI와 마찬가지로 모든 생성 매개변수를 구성하기 위해 일련의 프롬프트를 안내합니다.  

명확성을 위해 색상 코드 인터페이스를 사용합니다.  
화살표 키와 스페이스바를 사용하여 스타일 설명자를 선택할 수 있는 고급 다중 선택 메뉴를 제공합니다.  
모든 질문에 답변하면 최종 명령어가 표시되어 검토할 수 있습니다.  
직접 실행을 확인하거나 취소하고 명령어를 복사하여 수동으로 사용할 수 있습니다.  

## 생성 팁  

- 매번 터미널에 입력하는 대신 `configs/inference_v29.yaml` 파일을 편집하여 인수를 추가할 수 있습니다.  
- 사용 가능한 모든 설명자는 [여기](https://osu.ppy.sh/wiki/en/Beatmap/Beatmap_tags)에서 찾을 수 있습니다.  
- 항상 2007년부터 2023년 사이의 연도 인수를 제공하세요. 알 수 없는 상태로 두면 모델이 일관성 없는 스타일로 생성할 수 있습니다.  
- 항상 난이도 인수를 제공하세요. 알 수 없는 상태로 두면 모델이 일관성 없는 난이도로 생성할 수 있습니다.  
- `cfg_scale` 매개변수를 높이면 `mapper_id` 및 `descriptors` 인수의 효과가 증가합니다.  
- `negative_descriptors` 인수를 사용하여 모델이 특정 스타일에서 벗어나도록 유도할 수 있습니다. 이는 `cfg_scale > 1`일 때만 작동합니다. 부정 설명자 수가 설명자 수와 같아야 합니다.  
- 노래 스타일과 원하는 비트맵 스타일이 잘 맞지 않으면 모델이 지시를 따르지 않을 수 있습니다. 예를 들어, 차분한 노래에 대해 높은 SR, 높은 SV 비트맵을 생성하는 것은 어렵습니다.  
- 노래에 타이밍과 카이아이 시간이 이미 완료된 경우, 이를 모델에 제공하면 추론 속도와 정확도가 크게 향상됩니다: `beatmap_path` 및 `in_context=[TIMING,KIAI]` 인수를 사용하세요.  
- 비트맵의 일부만 리맵하려면 `beatmap_path`, `start_time`, `end_time`, 그리고 `add_to_beatmap=true` 인수를 사용하세요.  
- 비트맵에 게스트 난이도를 생성하려면 `beatmap_path` 및 `in_context=[GD,TIMING,KIAI]` 인수를 사용하세요.  
- 비트맵에 히트사운드를 생성하려면 `beatmap_path` 및 `in_context=[NO_HS,TIMING,KIAI]` 인수를 사용하세요.  
- 노래에 대해 타이밍만 생성하려면 `super_timing=true` 및 `output_type=[TIMING]` 인수를 사용하세요.  

## MaiMod: AI 기반 모딩 도구  

MaiMod는 Mapperatorinator 예측을 사용하여 [Mapset Verifier](https://github.com/Naxesss/MapsetVerifier)와 같은 다른 자동 모딩 도구로 감지할 수 없는 잠재적 결함과 불일치를 찾는 osu! 비트맵용 모딩 도구입니다.  
다음과 같은 문제를 감지할 수 있습니다:  
- 부정확한 스내핑 또는 리듬 패턴  
- 부정확한 타이밍 포인트  
- 일관성 없는 히트 오브젝트 위치 또는 새 콤보 배치  
- 이상한 슬라이더 모양  
- 일관성 없는 히트사운드 또는 볼륨  

MaiMod를 [여기](https://colab.research.google.com/github/OliBomby/Mapperatorinator/blob/main/colab/mai_mod_inference.ipynb)에서 사용해보거나 로컬에서 실행할 수 있습니다:  
로컬에서 MaiMod를 실행하려면 Mapperatorinator를 설치해야 합니다. 그런 다음 `mai_mod.py` 스크립트를 실행하고 `beatmap_path` 인수로 비트맵 경로를 지정하세요.

```sh
python mai_mod.py beatmap_path="'C:\Users\USER\AppData\Local\osu!\Songs\1 Kenji Ninuma - DISCO PRINCE\Kenji Ninuma - DISCOPRINCE (peppy) [Normal].osu'"
```
이것은 모딩 제안을 콘솔에 출력하며, 이후 이를 수동으로 비트맵에 적용할 수 있습니다.  
제안들은 시간 순서대로 정렬되며 카테고리별로 그룹화되어 있습니다.  
원 안의 첫 번째 값은 '서프라이절(surprisal)'을 나타내며, 이는 모델이 해당 문제를 얼마나 예상치 못했는지의 척도로, 가장 중요한 문제를 우선순위로 둘 수 있습니다.  

모델은 특히 서프라이절 값이 낮은 문제에 대해 실수를 할 수 있으므로, 제안을 비트맵에 적용하기 전에 항상 다시 확인하세요.  
주요 목적은 잠재적 문제에 대한 검색 범위를 좁혀, 비트맵의 모든 히트 오브젝트를 수동으로 확인할 필요가 없도록 돕는 것입니다.  

### MaiMod GUI  
MaiMod 웹 UI를 실행하려면 Mapperatorinator를 설치해야 합니다.  
그런 다음 `mai_mod_ui.py` 스크립트를 실행하세요. 이 스크립트는 로컬 웹 서버를 시작하고 새 창에서 UI를 자동으로 엽니다:

```sh
python mai_mod_ui.py
```
<img width="850" height="1019" alt="afbeelding" src="https://github.com/user-attachments/assets/67c03a43-a7bd-4265-a5b1-5e4d62aca1fa" />

## 개요

### 토크나이제이션

Mapperatorinator는 osu! 비트맵을 토큰으로 직접 변환 및 복원할 수 있는 중간 이벤트 표현으로 변환합니다.  
여기에는 히트 오브젝트, 히트사운드, 슬라이더 속도, 새로운 콤보, 타이밍 포인트, 키아이 시간, 타이코/매니아 스크롤 속도가 포함됩니다.

다음은 토크나이제이션 과정의 작은 예시입니다:

![mapperatorinator_parser](https://github.com/user-attachments/assets/84efde76-4c27-48a1-b8ce-beceddd9e695)

어휘 크기를 줄이기 위해, 시간 이벤트는 10ms 간격으로 양자화되고 위치 좌표는 32 픽셀 그리드 포인트로 양자화됩니다.

### 모델 아키텍처
이 모델은 기본적으로 [HF Transformers Whisper](https://huggingface.co/docs/transformers/en/model_doc/whisper#transformers.WhisperForConditionalGeneration) 모델을 감싸는 래퍼로, 맞춤형 입력 임베딩과 손실 함수를 포함합니다.  
모델 크기는 2억 1,900만 개의 파라미터입니다.  
이 모델은 이 작업에서 T5보다 빠르고 정확한 것으로 나타났습니다.

모델의 입력-출력에 대한 고수준 개요는 다음과 같습니다:

![Picture2](https://user-images.githubusercontent.com/28675590/201044116-1384ad72-c540-44db-a285-7319dd01caad.svg)

모델은 인코더 입력으로 멜 스펙트로그램 프레임을 사용하며, 입력 위치마다 한 프레임씩 할당됩니다.  
모델 디코더 출력은 각 단계마다 미리 정의된 이산 이벤트 어휘에 대한 소프트맥스 분포입니다. 출력은 희소하며, 히트 오브젝트가 발생할 때만 이벤트가 필요하고 모든 오디오 프레임에 주석을 다는 것은 아닙니다.

### 다중 작업 학습 포맷

![Multitask training format](https://github.com/user-attachments/assets/62f490bc-a567-4671-a7ce-dbcc5f9cd6d9)

SOS 토큰 앞에는 조건부 생성을 돕는 추가 토큰들이 있습니다. 이 토큰들은 게임 모드, 난이도, 매퍼 ID, 연도 및 기타 메타데이터를 포함합니다.  
학습 중에는 이 토큰들에 대응하는 레이블이 없으므로 모델이 출력하지 않습니다.  
또한 학습 중에는 무작위로 메타데이터 토큰이 'unknown' 토큰으로 대체될 수 있어, 추론 시에 이 'unknown' 토큰을 사용하여 모델에 제공해야 하는 메타데이터 양을 줄일 수 있습니다.

### 원활한 장기 생성

모델의 컨텍스트 길이는 8.192초입니다. 이는 전체 비트맵을 생성하기에는 분명히 부족하므로, 노래를 여러 창으로 나누어 작은 부분씩 비트맵을 생성해야 합니다.  
생성된 비트맵이 창 사이에 눈에 띄는 이음새가 없도록 하기 위해 90% 중첩을 사용하며 창을 순차적으로 생성합니다.  
첫 번째 창을 제외한 각 생성 창은 이전 창에서 생성된 토큰으로 최대 50%까지 디코더가 미리 채워진 상태로 시작합니다.
우리는 로그잇 프로세서를 사용하여 모델이 생성 창의 처음 50%에 해당하는 시간 토큰을 생성하지 못하도록 합니다.  
또한, 생성 창의 마지막 40%는 다음 창을 위해 예약되어 있습니다. 해당 범위 내에서 생성된 시간 토큰은 EOS 토큰으로 처리됩니다.  
이로써 각 생성된 토큰은 적어도 4초의 이전 토큰과 3.3초의 미래 오디오를 조건으로 하여 예측할 수 있습니다.  

긴 생성 과정에서 오프셋 드리프트를 방지하기 위해, 학습 중 디코더의 시간 이벤트에 랜덤 오프셋이 추가되었습니다.  
이것은 오디오의 온셋을 듣고 타이밍 오류를 수정하도록 강제하며, 일관되게 정확한 오프셋을 생성하는 결과를 낳습니다.  

### 디퓨전을 통한 정제된 좌표  

디코더가 생성한 위치 좌표는 32픽셀 격자점으로 양자화되며, 이후 디퓨전을 사용하여 좌표를 노이즈 제거하여 최종 위치로 만듭니다.  
이를 위해 [osu-diffusion](https://github.com/OliBomby/osu-diffusion)의 수정 버전을 학습시켰으며, 이는 노이즈 스케줄의 마지막 10%만을 전문적으로 다루고, Mapperatorinator가 조건부 생성에 사용하는 고급 메타데이터 토큰을 받습니다.  

Mapperatorinator 모델은 슬라이더의 SV를 출력하므로, 슬라이더의 요구 길이는 제어점 경로의 모양과 상관없이 고정됩니다.  
따라서 우리는 디퓨전 과정을 유도하여 요구된 슬라이더 길이에 맞는 좌표를 생성하도록 시도합니다.  
이를 위해 디퓨전 과정의 매 스텝마다 현재 제어점 경로와 요구 길이를 기반으로 슬라이더 끝 위치를 재계산합니다.  
즉, 디퓨전 과정은 슬라이더 끝 위치를 직접 제어할 수 없지만 제어점 경로를 변경하여 간접적으로 영향을 미칠 수 있습니다.  

### 후처리  

Mapperatorinator는 생성된 비트맵의 품질 향상을 위해 추가 후처리를 수행합니다:  

- 디퓨전을 통한 위치 좌표 정제.  
- 모델이 생성한 스냅 분할자를 사용하여 시간 이벤트를 가장 가까운 틱으로 재스냅.  
- 거의 완벽한 위치 중복 스냅.  
- 마니아 열 이벤트를 X 좌표로 변환.  
- 태고 드럼롤을 위한 슬라이더 경로 생성.  
- 요구 슬라이더 길이와 제어점 경로 길이 간 큰 불일치 수정.  

### 슈퍼 타이밍 생성기  

슈퍼 타이밍 생성기는 노래 전체의 타이밍을 20번 추론하고 결과를 평균내어 생성된 타이밍의 정밀도와 정확도를 높이는 알고리즘입니다.  
이는 변동 BPM이나 BPM 변화가 있는 노래에 유용하며, 결과는 거의 완벽하지만 가끔 수동 조정이 필요한 구간이 있습니다.  

## 학습  

아래 지침은 로컬 머신에서 학습 환경을 생성합니다.  

### 1. 저장소 복제하기  

```sh
git clone https://github.com/OliBomby/Mapperatorinator.git
cd Mapperatorinator
```

### 2. 데이터셋 생성

[Mapperator 콘솔 앱](https://github.com/mappingtools/Mapperator/blob/master/README.md#create-a-high-quality-dataset)을 사용하여 자체 데이터셋을 생성하세요. 비트맵을 확인하고 추가 메타데이터를 얻기 위해 [osu! OAuth 클라이언트 토큰](https://osu.ppy.sh/home/account/edit)이 필요합니다. 데이터셋은 `Mapperatorinator` 디렉토리 옆의 `datasets` 디렉토리에 배치하세요.

```sh
Mapperator.ConsoleApp.exe dataset2 -t "/Mapperatorinator/datasets/beatmap_descriptors.csv" -i "path/to/osz/files" -o "/datasets/cool_dataset"
```

### 3. (선택 사항) 로깅을 위한 Weight & Biases 설정
[Weight & Biases](https://wandb.ai/site)에서 계정을 생성하고 계정 설정에서 API 키를 가져옵니다.
그런 다음 `WANDB_API_KEY` 환경 변수를 설정하여 학습 과정이 이 키로 로그를 기록하도록 합니다.

```sh
export WANDB_API_KEY=<your_api_key>
```

### 4. 도커 컨테이너 생성
venv에서 학습하는 것도 가능하지만, 더 나은 성능을 위해 WSL에서 Docker 사용을 권장합니다.
```sh
docker compose up -d --force-recreate
docker attach mapperatorinator_space
cd Mapperatorinator
```

### 5. 파라미터 구성 및 학습 시작

모든 설정은 `./configs/train/default.yaml`에 위치해 있습니다.  
데이터셋에 맞는 `train_dataset_path`와 `test_dataset_path`를 올바르게 설정하고, 학습/테스트 분할을 위한 시작 및 종료 맵셋 인덱스를 지정해야 합니다.  
경로는 도커 컨테이너 내에서의 경로이므로, 예를 들어 `cool_dataset`이라는 데이터셋을 `datasets` 디렉터리에 넣었다면 경로는 `/workspace/datasets/cool_dataset`이 됩니다.  

재현성을 위해 기본 설정을 덮어쓰는 커스텀 설정 파일을 만들어 학습 설정 기록을 남길 것을 권장합니다.

```yaml
data:
  train_dataset_path: "/workspace/datasets/cool_dataset"
  test_dataset_path: "/workspace/datasets/cool_dataset"
  train_dataset_start: 0
  train_dataset_end: 90
  test_dataset_start: 90
  test_dataset_end: 100
```

Begin training by calling `python osuT5/train.py` or `torchrun --nproc_per_node=NUM_GPUS osuT5/train.py` for multi-GPU training.


```sh
python osuT5/train.py -cn train_v29 train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```

### 6. LoRA 미세 조정

사전 학습된 모델을 [LoRA](https://arxiv.org/abs/2106.09685)로 미세 조정하여 특정 스타일이나 게임 모드에 맞출 수도 있습니다.  
이를 위해 `configs/train/lora.yaml`을 필요에 맞게 수정하고 `lora` 훈련 구성을 실행하세요:  

```sh
python osuT5/train.py -cn lora train_dataset_path="/workspace/datasets/cool_dataset" test_dataset_path="/workspace/datasets/cool_dataset" train_dataset_end=90 test_dataset_start=90 test_dataset_end=100
```
중요한 LoRA 매개변수:
- `pretrained_path`: 미세 조정할 기본 모델의 경로나 HF 저장소.
- `r`: LoRA 행렬의 랭크. 값이 클수록 모델 용량이 늘어나지만 메모리 사용량도 증가.
- `lora_alpha`: LoRA 업데이트의 스케일링 팩터.
- `total_steps`: 총 훈련 단계 수. 데이터셋 크기에 맞춰 조절.
- `enable_lora`: LoRA 사용 여부 또는 전체 모델 미세 조정 여부.

추론 시, `lora_path` 인수로 사용할 LoRA 가중치를 지정할 수 있습니다.
이는 로컬 경로나 허깅페이스 저장소일 수 있습니다.

## 참고
- [Mapper Classifier](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./classifier/README.md)
- [RComplexion](https://raw.githubusercontent.com/OliBomby/Mapperatorinator/main/./rcomplexion/README.md)

## 크레딧

특별 감사:
1. [osuT5](https://github.com/gyataro/osuT5) 저자분들께 훈련 코드에 대해.
2. 허깅페이스 팀의 [도구들](https://huggingface.co/docs/transformers/index).
3. 아이디어 교환에 도움을 준 [Jason Won](https://github.com/jaswon)과 [Richard Nagyfi](https://github.com/sedthh).
4. 훈련 크레딧을 기부해주신 [Marvin](https://github.com/minetoblend).
5. 비트맵을 제공해준 osu! 커뮤니티.

## 관련 작업

1. Syps (Nick Sypteras)의 [osu! Beatmap Generator](https://github.com/Syps/osu_beatmap_generator)
2. kotritrona, jyvden, Yoyolick (Ryan Zmuda)의 [osumapper](https://github.com/kotritrona/osumapper)
3. OliBomby (Olivier Schipper), NiceAesth (Andrei Baciu)의 [osu-diffusion](https://github.com/OliBomby/osu-diffusion)
4. gyataro (Xiwen Teoh)의 [osuT5](https://github.com/gyataro/osuT5)
5. sedthh (Richard Nagyfi)의 [Beat Learning](https://github.com/sedthh/BeatLearning)
6. jaswon (Jason Won)의 [osu!dreamer](https://github.com/jaswon/osu-dreamer)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-28

---