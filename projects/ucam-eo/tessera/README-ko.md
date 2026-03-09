# 지구 표현 및 분석을 위한 표면 스펙트럼의 시간적 임베딩 (TESSERA) [CVPR2026]
<div align="center">
    <a href="#readme-top">
        <img src="https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/banner.png" alt="Banner">
    </a>
    <br />
    <p align="center">
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">버그 신고 🛠️</a> &nbsp;&nbsp;•&nbsp;&nbsp;
        <a href="https://github.com/FrankFeng-23/btfm_project/issues">기능 요청 💡</a>
    </p>
</div>

<!--  ![Version](https://img.shields.io/badge/version-alpha-red) -->
![PyPI 버전](https://img.shields.io/pypi/v/geotessera?label=PyPI%20version&color=blue)
![라이선스](https://img.shields.io/badge/License-MIT-blue.svg)


# 목차

  - TESSERA에 대해 배우기
      - [소개](#introduction)
      - [논문](#Papers)
      - [팟캐스트](https://www.satellite-image-deep-learning.com/p/tessera-a-temporal-foundation-model)
      - [발표자료](#presentations)
      - [라이선스](#License)
  - TESSERA 사용하기
      - [허용 사용 정책](#AUP)
      - [사전 계산된 임베딩 접근](#global-embeddings-access)
      - [직접 임베딩 생성하기](#creating-your-own-embeddings)
      - [하위 작업](#downstream-tasks)
      - [TESSERA 사용자 그룹](#tessera-users-group)
  - 추가 정보
      - [팀](#team)
      - [연락처](#contact)
      - [인용](#citation)
      - [감사의 말](#acknowledgments)
      - [스타 기록](#star-history)

# TESSERA에 대해 배우기
## 소개
위성 원격 탐사는 서식지 지도 작성, 탄소 회계, 보존 및 지속 가능한 토지 이용 전략 등 다양한 하위 응용 분야를 가능하게 합니다. 그러나 위성 시계열 데이터는 방대하고 종종 구름에 의해 손상되어 사용하기 어렵습니다. 과학 커뮤니티가 실행 가능한 통찰력을 추출하는 능력은 종종 라벨이 지정된 학습 데이터셋의 부족과 시계열 데이터를 처리하는 계산 부담에 의해 제한됩니다. [Dr. Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/)의 통찰력에 따르면, 두 개의 구름 없는 무작위 샘플에서 파생된 오토인코더 임베딩을 [Barlow Twins](https://proceedings.mlr.press/v139/zbontar21a/zbontar21a.pdf)를 사용해 정렬하도록 강제하면 누락된 관측값을 포함한 전체 시계열을 나타내는 임베딩이 생성됩니다.

이 아이디어는 전 세계 10미터 해상도에서 픽셀별 스펙트럼-시간 신호를 128차원 잠재 표현으로 보존하는 공개 기초 모델인 TESSERA의 핵심입니다. 이 모델은 자체 감독 학습을 사용하여 페타바이트 규모의 지구 관측 데이터를 요약합니다. 우리는 다섯 가지 다양한 하위 작업에서 최신 작업별 모델과 다른 기초 모델과 비교하여 TESSERA가 이들 기준 모델과 거의 동일하거나 더 우수한 성능을 보임을 발견했습니다. 기존 접근법에서 일반적으로 손실되는 시간적 생리학 신호를 보존함으로써 TESSERA는 생태계 역학, 농업 식품 시스템 및 환경 변화 탐지에 대한 새로운 통찰을 가능하게 합니다. 또한, 오픈 소스 구현은 재현성과 확장성을 지원하며, 개인정보 보호 설계는 연구자들이 데이터 주권을 유지할 수 있게 합니다.

우리가 알기로, TESSERA는 사용 용이성, 규모 및 정확성 면에서 전례가 없습니다: 다른 어떤 기초 모델도 분석 준비된 출력물을 제공하고, 공개되어 있으며, 픽셀 수준의 스펙트럼-시간 특성만을 사용하여 전 세계 연간 10미터 해상도 범위를 제공하지 않습니다.

다음은 TESSERA 표현 맵의 시각화 결과입니다(처음 세 채널을 RGB로 사용):

![repr_demo](https://raw.githubusercontent.com/ucam-eo/tessera/alpha_version_1.0/images/repr_demo.png)

## 논문
다음은 TESSERA와 관련된 출판물 및 사전 인쇄물이며, 연대순으로 나열되어 있습니다:
* Lisaius, M. C., Blake, A., Keshav, S., & Atzberger, C. (2024). Using Barlow Twins to Create Representations From Cloud-Corrupted Remote Sensing Time Series. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing, 17, 13162–13168. IEEE Journal of Selected Topics in Applied Earth Observations and Remote Sensing. https://doi.org/10.1109/JSTARS.2024.3426044

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav (2025), [TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis](https://arxiv.org/abs/2506.20380), To Appear, CVPR 2026. ArXiv 재인쇄. https://arxiv.org/abs/2506.20380

* Lisaius, M. C., Blake, A., Atzberger, C., & Keshav, S. (2026). Towards improved crop type classification: A compact embedding approach suitable for small fields. ISPRS Conference 2026 논문집에 게재 예정. 국제 사진측량 및 원격 탐사 학회.

* Z. Feng, C. Atzberger, S. Jaffer, J. Knezevic, S. Sormunen, R. Young, M.C. Lisaius, M. Immitzer, T. Jackson, J. Ball, D.A. Coomes, A. Madhavapeddy, A. Blake, S. Keshav, (2026) [Applications of the TESSERA Geospatial Foundation Model to Diverse Environmental Mapping Tasks](http://ssrn.com/abstract=6142416), SSRN 사전 인쇄. http://ssrn.com/abstract=6142416
  
* Young, R., & Keshav, S. (2026). Interpolation of GEDI Biomass Estimates with Calibrated Uncertainty Quantification, arXiv 사전 인쇄. https://doi.org/10.48550/ArXiv.2601.16834
  
* Lisaius, M. C., Keshav, S., Blake, A., & Atzberger, C. (2026). Embedding-based Crop Type Classification in the Groundnut Basin of Senegal (arXiv:2601.16900). ArXiv 사전 인쇄. https://doi.org/10.48550/arXiv.2601.16900

* Ball, J.G.C, Wicklein J.A. , Feng, Z.,  Knezevic, J.,  Jaffer, S., Atzberger, C.,  Dalponte, M., and Coomes, D. Geospatial foundation models enable data-efficient tree species mapping in temperate montane forests, BioArxiv, https://doi.org/10.64898/2026.02.23.707022

## 발표

* [AI for Good 세미나에서의 TESSERA 개요](https://www.youtube.com/live/9yrpwFrwbGY), Frank Feng, 2026년 1월 22일
* [TESSERA: Precomputed FAIR Global Pixel Embeddings for Earth Representation and Analysis](https://www.grss-ieee.org/event/tessera-precomputed-fair-global-pixel-embeddings-for-earth-representation-and-analysis/) IEEE GRSS 강연, Frank Feng, 2025년 12월 12일
* [2슬라이드 요약 (PPTX)](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) CRI 플래시 토크, S. Keshav, 2025년 10월 7일
* 생태학 그룹 회의를 위한 기초 모델 개요 (PPTX), 케임브리지 대학교, DAB, James Ball, 2025년 10월 6일
* [생태학 응용에 초점을 맞춘 TESSERA 개요 발표](https://www.dropbox.com/scl/fi/8xvanw3kk586lp1ld31kd/maryland_talk_slides.pdf?rlkey=osyhtk1kc2pcj81iel0u32lub&st=6kedpwv6&dl=0) (PDF) 메릴랜드 대학교, Frank Feng, 2025년 10월 1일
* [TESSERA 개요 발표](https://www.dropbox.com/scl/fi/0rsq4wkao3c7fgwljd8ec/JCU-tesserav2.pptx?rlkey=ccutcxgwi068c09n20t1yi549&st=13if23b3&dl=0) (PPTX) 제임스 쿡 대학교, S. Keshav, 2025년 9월 29일
* [TESSERA 개요 발표](https://www.dropbox.com/scl/fi/1p7nabvlvie8fzyomkx7w/dab_talk_slides.pdf?rlkey=ym3d44o80mbrdkasyzct9kzi5&st=ozvwczs7&dl=0) 케임브리지 대학교, DAB, Frank Feng, 2025년 5월 20일
* [지구 관측을 위한 자체 감독 학습](https://www.dropbox.com/scl/fi/zjo4trov0z2qnmdeitng0/CRI-2slide.pptx?rlkey=5kkojiknt6hdn2zplzlotqnbt&st=ezafh67n&dl=0) (PPTX) S. Keshav, 엑서터, 2025년 4월

## 라이선스


TESSERA 소프트웨어는 표준 MIT 라이선스 하에 배포됩니다. 임베딩과 모델 가중치는 [CC0](https://creativecommons.org/publicdomain/zero/1.0/) 라이선스 하에 배포됩니다: 본질적으로,
상업적 및 비상업적 목적 모두에 자유롭게 사용할 수 있습니다. 법적으로 저작자 표시를 요구하지는 않지만,
저작자 표시는 요청합니다.

# TESSERA 사용하기

<a id="global-embeddings-access"></a>

## GeoTessera를 사용한 임베딩 접근 (권장)

우리는 2024년 기준 10m 해상도로 전 세계 임베딩을 생성했습니다.
이들은 [GeoTessera](https://github.com/ucam-eo/geotessera) 라이브러리를 사용하여 다운받아 후속 응용 프로그램에 사용할 수 있으며,
상당한 계산 시간과 자원을 절약할 수 있습니다.
우리는 2017년까지 연도별로 점진적으로 적용 범위를 확장할 예정입니다. 현재 적용 범위 지도는 아래와 같습니다:

<img src="https://github.com/ucam-eo/tessera-coverage-map/blob/main/map.png"> 

## TESSERA 사용자 그룹

관심 있는 사용자는 [Zulip](https://eeg.zulipchat.com/login/) 토론 그룹에 참여하시기 바랍니다.


# 직접 임베딩 생성하기

소프트웨어를 사용하여 직접 임베딩을 생성하려면 아래 지침을 따르십시오. 이는 계산적으로 도전적인 작업이며,
상당한 컴퓨팅 및 저장 자원에 접근할 수 있어야 합니다.

## 하드웨어 요구사항

### 1. 저장 공간 요구사항

이 파이프라인을 실행하려면 상당한 저장 공간이 필요합니다. 파이프라인은 처리 후 일부 중간 파일을 정리하지만,
다운로드한 원시 Sentinel-2 및 Sentinel-1 파일은 여전히 많은 디스크 공간을 차지합니다. 예를 들어, 2022년 기준 100km×100km 영역을 처리하여 TESSERA 표현 지도(10m 해상도)를 출력하려면 최소 1TB의 저장 공간이 필요합니다.

### 2. 메모리 요구사항

우리는 처음에 Microsoft Planetary Computer에서 전처리된 데이터를 사용합니다. 그러나 차세대 임베딩은 ASF DAAC의 OPERA를 사용할 예정입니다. 어느 경우든, 대부분의 지리 전처리는 완료된 상태입니다. 그래도 최소 128GB의 RAM을 권장합니다.

### 3. CPU 및 GPU

파이프라인은 CPU 및 GPU에 대한 엄격한 요구사항이 없지만, 더 많은 CPU 코어와 더 강력한 GPU는 추론 속도를 크게 향상시킬 수 있습니다. 2022년 기준 110km×110km 영역을 처리할 때, 128코어 CPU와 단일 NVIDIA A30 GPU를 사용하여 추론(각각 CPU와 GPU가 추론의 50%씩 처리)한 테스트에서는 약 10시간이 소요되었습니다.
### 4. 운영 체제

데이터 전처리 파이프라인은 거의 모든 리눅스 시스템을 지원합니다. 윈도우의 경우 WSL 사용을 권장합니다. 현재로서는 MacOS는 지원하지 않습니다.

모델 추론 부분은 리눅스와 윈도우 WSL에서만 테스트되었으며 정상 작동합니다.

## 데이터 전처리

### 개요
_**파이프라인을 실행하기 전에 전체 튜토리얼을 빠르게 검토할 것을 강력히 권장합니다.**_

이 단계에서는 Sentinel-1과 Sentinel-2 데이터를 1년치 시간 축을 따라 쌓아 합성 영상을 생성합니다. Sentinel-2의 경우 합성 영상의 형태는 (T,H,W,B)이며, 여기서 T는 해당 연도의 유효 관측치 수, B는 밴드 수(우리는 10개 밴드를 선택함)입니다. Sentinel-1은 상승궤도와 하강궤도 데이터를 모두 추출했습니다. 상승궤도를 예로 들면, 합성 영상의 형태는 (T',H,W,B')이며, T'는 해당 연도의 유효 상승 관측치 수, B'는 VV와 VH 밴드 2개이므로 2입니다.

초기에는 Sentinel-1과 Sentinel-2 데이터를 Microsoft의 Planetary Computer에서 가져왔습니다:
- Sentinel-1 데이터 소스: https://planetarycomputer.microsoft.com/dataset/sentinel-1-rtc
- Sentinel-2 데이터 소스: https://planetarycomputer.microsoft.com/dataset/sentinel-2-l2a

새로운 세대 임베딩은 ASF DAAC의 OPERA를 사용합니다:
- Sentinel-1 데이터 소스:  https://registry.opendata.aws/nasa-operal2rtc-s1v1/
- Sentinel-2 데이터 소스: https://registry.opendata.aws/sentinel-2-l2a-cogs/

현재 파이프라인은 TIFF 형식 입력만 받습니다. 입력 ROI TIFF의 해상도는 다양할 수 있으나(예: 30m), 파이프라인은 **항상 구성된 `RESOLUTION`(기본 10m)에서 Sentinel-1과 Sentinel-2 출력을 생성**하며, **ROI 범위는 동일하게 유지**합니다. TIFF 내 유효 ROI 영역은 값이 1이고, 그렇지 않으면 0입니다. 쉐이프파일만 있어도 괜찮으며, `convert_shp_to_tiff.py` 스크립트를 제공합니다.

### 소스 코드 다운로드

먼저 빈 작업 디렉터리를 생성합니다:

```bash
mkdir tessera_project
cd tessera_project
git clone https://github.com/ucam-eo/tessera.git
```
더 쉬운 파이프라인 운영을 위해, 데이터 출력 디렉토리를 `tessera_infer`와 `tessera_preprocessing`와 같은 레벨에 배치할 것을 권장합니다:


```
tessera_project
 ┣ tessera_infer
 ┣ tessera_preprocessing
 ┣ my_data
   ┣ roi.shp (your shapefile)
   ┗ roi.tiff (we recommend generating this using convert_shp_to_tiff.py)
```
`roi.tiff` 파일은 `tessera_preprocessing/convert_shp_to_tiff.py`에 위치한 `convert_shp_to_tiff.py`를 사용하여 생성할 수 있습니다. 사용하려면, 메인 함수에서 셰이프파일 경로를 지정하기만 하면 동일한 디렉토리에 같은 이름의 TIFF 파일이 출력됩니다.

⚠️알림: _만약 ROI가 상대적으로 크다면, 예를 들어 100 km × 100 km인 경우, TIFF를 20 km × 20 km를 넘지 않는 작은 구간으로 미리 분할하는 것을 강력히 권장합니다. 그런 다음 각 작은 TIFF 파일을 파이프라인에서 순차적으로 처리하세요. 너무 큰 ROI는 백엔드 타일 제공자에 문제를 일으킬 수 있습니다._

### Python 환경

지리 처리 패키지가 필요합니다(다행히도 환경 설정이 매우 복잡한 GDAL은 사용하지 않습니다) 그리고 머신러닝 패키지(PyTorch)가 필요합니다만, 하드웨어가 컴퓨터마다 다르므로 직접 설치해야 합니다. 공통 패키지는 `requirements.txt`에 모아두었으며, 다음과 같이 설치할 수 있습니다:


```bash
pip install -r requirements.txt
```
참고: 관리되는 환경에 있는 경우 먼저 venv를 설치해야 할 수 있습니다, 사용하여
```bash
python3 -m venv venv
source venv/bin/activate
```

### 스크립트 구성

먼저, `tessera_preprocessing` 폴더로 이동하세요:

```bash
cd tessera_preprocessing
```

그런 다음 s1_s2_downloader.sh 파일을 수정하여 ROI TIFF 파일, 출력 및 임시 디렉토리, 데이터 소스를 가리키도록 합니다:

```bash
# === Basic Configuration ===
INPUT_TIFF="/absolute/path/to/your/data_dir/roi.tiff"
OUT_DIR="/absolute/path/to/your/data_dir"

export TEMP_DIR="/absolute/path/to/your/temp_dir"     # Temporary file directory

mkdir -p "$OUT_DIR"

# Python environment path
PYTHON_ENV="/absolute/path/to/your/python_env/bin/python"

# === Sentinel-1 & Sentinel-2 Processing Configuration ===
YEAR=2022 # Range [2017-2025]
RESOLUTION=10.0  # Output resolution (meters). ROI TIFF can be any resolution; extent is preserved.

# === Data Source Configuration ===
# mpc: Microsoft Planetary Computer (sentinel-1-rtc, sentinel-2-l2a)
# aws: AWS Open Data backends (S1=OPERA RTC-S1 via ASF/CMR + ASF Earthdata Cloud COGs, S2=Earth-search Sentinel-2 L2A COGs)
DATA_SOURCE="mpc"   # choices: mpc/aws
```
참고: `RESOLUTION`은 출력 픽셀 크기를 제어합니다. 파이프라인은 ROI 경계를 고정하고 ROI 마스크를 출력 그리드에 재샘플링합니다.

### AWS 자격 증명 (`DATA_SOURCE="aws"`일 때만 필요)
Earth-search의 Sentinel-2는 공개되어 있으며 **자격 증명이 필요하지 않습니다**.

Sentinel-1 OPERA RTC-S1은 ASF Earthdata Cloud(COG over HTTPS)를 통해 접근합니다. Earthdata 로그인 토큰이 필요합니다:
- **Earthdata 계정 생성**: [NASA Earthdata Login](https://urs.earthdata.nasa.gov/home)에서 생성합니다.
- **애플리케이션 승인**: 계정을 등록한 후, Applications 탭에서 Alaska Satellite Facility Data Access를 승인된 애플리케이션 목록에 추가합니다.
- **EDL 베어러 토큰 / JWT 얻기**: **Generate Token**을 클릭하여 토큰을 생성하고 로컬에 저장합니다(커밋 금지).

권장 방법 (간단 + 명시적):


```bash
nano ~/.edl_bearer_token
# paste token, save+exit (Ctrl-O Enter, then Ctrl-X)
chmod 600 ~/.edl_bearer_token
```
AWS S1 다운로더는 이 토큰을 사용하여 ASF Earthdata Cloud에서 COG를 읽습니다.

임시 S3 자격 증명(고급; 일반적으로 이 파이프라인에서는 필요하지 않음)을 가져오려면 ASF 지침을 참조하세요:
- `https://cumulus.asf.alaska.edu/s3credentialsREADME`

위 구성 아래에는 컴퓨터 성능에 따라 수정할 수 있는 추가 구성이 있습니다.

먼저, `s1_s2_downloader.sh`에 권한을 부여하세요:


```bash
chmod +x s1_s2_downloader.sh
```

그런 다음, 우리는 다음을 실행할 수 있습니다:

```bash
bash s1_s2_downloader.sh
```
네트워크 상태로 인해 일부 타일 처리 시간이 초과될 수 있습니다. 당사의 스크립트는 이러한 문제를 방지하기 위해 정교한 시간 초과 관리를 포함하고 있습니다. 그러나 때때로 일부 타일이 여전히 실패할 수 있습니다. 위 명령을 다시 실행하면 보통 해결됩니다.

모든 Sentinel-1 및 Sentinel-2 데이터가 올바르게 생성되면 시간 차원에 따라 쌓을 수 있습니다. 이 단계에서는 두 개의 Rust로 생성된 실행 파일을 사용하여 매우 빠르게 처리합니다. `s1_s2_stacker.sh`를 열어 다음을 편집할 수 있습니다:


```bash
# === Basic Configuration ===
BASE_DIR="/absolute/path/to/your/data_dir"
OUT_DIR="${BASE_DIR}/data_processed"
DOWNSAMPLE_RATE=1
```

보통, 우리는 스태킹 중에 다운샘플링을 수행하지 않도록 `DOWNSAMPLE_RATE`를 수정하지 않습니다. 위 코드에서 `BASE_DIR`은 `s1_s2_downloader.sh`에서 수정한 `OUT_DIR`과 동일합니다.

마찬가지로, `s1_s2_stacker.sh`에 권한을 부여하세요:

```bash
chmod +x s1_s2_stacker.sh
```
그런 다음 스태킹을 실행할 수 있습니다:


```bash
bash s1_s2_stacker.sh
```
성공하면 `/absolute/path/to/your/data_dir/data_processed`에 몇 개의 `.npy` 파일이 생성됩니다. 보통 이 `.npy` 파일들은 상당히 크기 때문에, 더 작고 관리하기 쉬운 단위로 패치화할 것입니다.

다음 명령을 실행하세요:


```bash
python dpixel_retiler.py \
    --tiff_path /absolute/path/to/your/data_dir/roi.tif \
    --d_pixel_dir /absolute/path/to/your/data_dir/data_processed \
    --patch_size 500 \
    --out_dir /absolute/path/to/your/data_dir/retiled_d_pixel \
    --num_workers 16 \
    --overwrite \
    --block_size 2000
```
위의 `patch_size`와 `block_size`는 직접 변경할 수 있습니다. 위의 구성은 (5000,5000) 크기와 10m 해상도를 가진 TIFF에 권장되는 구성입니다.

위 코드가 원활하게 실행되면 `my_data/retiled_d_pixel`에 일부 하위 폴더를 얻을 수 있습니다.

## 추론

### 개요

데이터 전처리가 완료되면 추론을 시작할 수 있습니다. 진행하기 전에 `my_data/retiled_d_pixel` 폴더에 다음과 같은 하위 폴더가 있는지 확인하세요:

```
retiled_d_pixel
 ┣ 0_3500_500_4000
 ┣ 0_4000_500_4500
 ┣ 0_4500_500_5000
 ┣ 0_5000_500_5500
 ┣ 0_5500_500_6000
 ┣ 0_6000_500_6500
```
각 하위 폴더에는 다음 파일이 포함되어야 합니다:

```
0_3500_500_4000
 ┣ bands.npy
 ┣ doys.npy
 ┣ masks.npy
 ┣ roi.tiff
 ┣ sar_ascending.npy
 ┣ sar_ascending_doy.npy
 ┣ sar_descending.npy
 ┗ sar_descending_doy.npy
```
만약 이 파일들이 존재한다면, 추론을 시작할 수 있습니다. 그렇지 않다면, 첫 번째 단계가 성공적으로 완료되었는지 확인하세요.

추론에는 PyTorch가 필요합니다. 각 시스템마다 CUDA 버전이 약간씩 다를 수 있기 때문에, 데이터 전처리 때처럼 Docker로 캡슐화된 Python 환경을 제공할 수 없습니다. 다행히도 추론을 위한 Python 환경은 GDAL이나 SNAP과 같은 지리 처리 패키지를 사용하지 않기 때문에 데이터 전처리보다 훨씬 간단하게 구성할 수 있습니다.

### Pytorch 준비

만약 Pytorch를 설치하지 않았다면, 아래 단계를 참고하세요. 그렇지 않으면 이 섹션을 무시하셔도 됩니다.

먼저, 시스템의 CUDA 버전을 확인하세요:


```bash
nvidia-smi
```

그런 다음 https://pytorch.org/ 를 방문하여 CUDA 버전에 따라 설치할 적절한 버전을 선택하십시오, 예를 들어:

```bash
pip install torch torchvision torchaudio --index-url https://download.pytorch.org/whl/cu128
```

### 모델 가중치

다음으로, [Google Drive](https://drive.google.com/drive/folders/18RPptbUkCIgUfw1aMdMeOrFML_ZVMszn?usp=sharing)에서 모델 가중치를 다운로드하고 `.pt` 파일을 `tessera_infer/checkpoints` 디렉토리에 위치시킵니다:

```
tessera_infer
 ┗ checkpoints
     ┗ best_model_fsdp_20250427_084307.pt
 ┗ configs
 ┗ src
```

_**위에서 언급한 체크포인트는 초기 단계 모델로, 기본적으로 float32 임베딩을 생성합니다. 따라서 이 모델은 geotessera 라이브러리에서 int8 임베딩을 생성하는 데 사용된 모델이 아닙니다. 곧 geotessera 임베딩을 생성하는 데 사용된 특정 체크포인트를 전체 파이프라인에 배포할 예정입니다.**_

### Bash 스크립트 구성

추론 구성을 간소화하기 위해 `tessera_infer/infer_all_tiles.sh`를 제공합니다. 몇 가지 매개변수만 수정하면 됩니다:

a. 기본 데이터 디렉터리:
```bash
BASE_DATA_DIR="your_data_directory"
```
이것은 데이터 저장 폴더로, 이전 bash의 `BASE_DATA_DIR`와 동일하며 예를 들어 `/maps/usr/tessera_project/my_data`입니다.

b. 파이썬 환경:
```bash
export PYTHON_ENV="your_python_path"
```
여기에 Python 환경의 절대 경로를 작성하세요. 예: `/home/user/anaconda3/envs/tessera_env/bin/python`

c. CPU/GPU 분할:
```bash
CPU_GPU_SPLIT="1:1"  # Format: CPU:GPU ratio
```
이 스크립트는 CPU와 GPU를 동시에 사용한 추론을 지원합니다. 이 비율은 각 장치가 처리할 `retiled_patches`의 비율을 지정합니다. 기본값은 1:1(균등 분할)입니다. GPU 전용 추론의 경우 0:1로 설정하세요.

d. CPU 관련 설정

```bash
MAX_CONCURRENT_PROCESSES_CPU=20
```
타일 추론을 위한 최대 CPU 프로세스 수입니다. 예를 들어 20으로 설정하면 20개의 타일을 동시에 처리합니다.

```bash
AVAILABLE_CORES=$((TOTAL_CPU_CORES / 2)) # Use 50% of the cores
```
사용할 CPU 코어 수입니다. 너무 많은 CPU 자원을 소비하지 않도록 필요에 따라 이 값을 수정하세요!

e. GPU 관련 설정:
```bash
MAX_CONCURRENT_PROCESSES_GPU=1
```
추론을 위한 최대 GPU 프로세스 수입니다. 시스템에 GPU가 1개만 있으면 이 값을 1로 설정하세요.

```bash
GPU_BATCH_SIZE=1024  # Larger for GPU, if this takes too much memory, reduce it
```
PyTorch 추론 중 한 번에 처리할 샘플 수입니다. 이 값이 너무 많은 GPU 메모리를 사용하거나 GPU에서 OOM 오류를 발생시키면 적절히 줄이십시오.

f. 기타 설정
구성할 수 있는 다른 매개변수도 있습니다. 필요에 따라 조정하십시오.

### 추론 시작

모든 준비가 완료되면 `tessera_infer` 폴더로 이동하십시오:

```bash
cd tessera_infer
```

그런 다음 `infer_all_tiles.sh`에 권한을 부여하십시오:

```bash
chmod +x infer_all_tiles.sh
```

그런 다음 실행하세요:

```bash
bash infer_all_tiles.sh
```

성공하면 다음과 같은 로그를 볼 수 있습니다:

```
(base) zf281@daintree:/scratch/zf281/tessera_project/tessera_infer$ bash infer_all_tiles.sh
[INFO] Total CPU cores: 256, Using: 192
[INFO] CPU:GPU split ratio = 1:1 (total: 2)

==== SETUP DIRECTORIES ====
[SUCCESS] Created necessary directories

==== SCANNING TILES ====
[INFO] Tile directory: /scratch/zf281/jovana/retiled_d_pixel
[INFO] Output directory: /scratch/zf281/jovana/representation_retiled
[SUCCESS] Found 226 tiles total
[INFO] Sample tiles:
  - 0_3500_500_4000
  - 0_4000_500_4500
  - 0_4500_500_5000
  - ...
```
동시에, `tessera_infer` 폴더 내에 각 CPU 및 GPU 프로세스에 대한 보다 자세한 로깅이 포함된 `logs` 폴더가 생성됩니다.

### 최종 표현 맵 병합

추론은 일반적으로 ROI 크기와 하드웨어 성능에 따라 오래 걸립니다. 완료되면 `my_data/representation_retiled`에서 여러 `.npy` 파일을 찾을 수 있습니다:


```
representation_retiled
 ┣ 0_3500_500_4000.npy
 ┣ 0_4000_500_4500.npy
 ┣ 0_4500_500_5000.npy
 ┣ 0_5000_500_5500.npy
 ┣ 0_5500_500_6000.npy
 ┣ 0_6000_500_6500.npy
 ┣ 0_6500_500_7000.npy
 ┣ 0_7000_500_7500.npy
 ┣ 1000_0_1500_500.npy
 ┣ 1000_1000_1500_1500.npy
 ┣ 1000_1500_1500_2000.npy
 ┣ 1000_2000_1500_2500.npy
```
마지막 단계는 `tessera_infer/stitch_tiled_representation.py`를 사용하여 이들을 함께 연결하는 것입니다:


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /path/to/d_pixel_retiled \
--representation_retiled_path /path/to/representation_retiled \
--downstream_tiff /path/to/downstream.tiff \
--out_dir /path/to/output_directory
```
예를 들어:


```bash
python stitch_tiled_representation.py \
--d_pixel_retiled_path /maps/usr/tessera_project/my_data/d_pixel_retiled \
--representation_retiled_path /maps/usr/tessera_project/my_data/representation_retiled \
--downstream_tiff /maps/usr/tessera_project/my_data/downstream.tiff \
--out_dir /maps/usr/tessera_project/my_data
```

마지막으로, 초기 `roi.tiff`와 동일한 크기 (H,W,128)를 가진 표현 맵이 `my_data` 디렉토리에 생성됩니다. 표현 맵은 NumPy 배열입니다. QGIS와 같은 소프트웨어에서 보기 위해 TIFF로 변환하려면 `tessera_infer/convert_npy2tiff.py` 스크립트를 사용할 수 있습니다. 메인 함수를 다음과 같이 수정하세요:

```python
npy_path = "/maps/usr/tessera_project/my_data/stitched_representation.npy"  # Change to the actual npy file path
ref_tiff_path = "/maps/usr/tessera_project/my_data/roi.tiff"  # Change to the actual reference tiff file path
out_dir = "/maps/usr/tessera_project/my_data/"  # Change to the actual output directory
```
## 다운스트림 작업

논문에 있는 다운스트림 작업을 재현하고 싶다면 https://github.com/ucam-eo/tessera-downstream-task 를 방문할 수 있습니다. 거기에는 많은 예제가 제공되어 있습니다.

# 추가 정보

## 팀

### 케임브리지 교수진
* [S. Keshav](https://svr-sk818-web.cl.cam.ac.uk/keshav/wiki/index.php/Main_Page)
* [Anil Madhavapeddy](https://anil.recoil.org)
* [Sadiq Jaffer](https://toao.com)
* [David Coomes](https://www.plantsci.cam.ac.uk/directory/david-coomes)

### 박사후 연구원
* James Ball
  
### 박사과정
* Madeleine Lisaius
* Zhengpeng (Frank) Feng
* Robin Young
* Jovana Knezevic

### 학부생
* Zejia Yang (Part II 학생, Frank Feng과 함께 공간 특징 추출기의 MAE 사전학습 작업 중)

### 인턴
* Kenzy Soror (워털루 대학교, Robin Young과 함께 작업)
* Artyom Gabtraupov (워털루 대학교, Robin Young과 함께 작업)
* Gabriel Mahler (케임브리지 대학교, Anil Madhavapeddy와 Silviu Petrovan과 함께 [고슴도치 서식지 및 추적](https://anil.recoil.org/ideas/hedgehog-mapping) 작업)
* Leyu Pan (임페리얼 칼리지, Frank Feng과 함께 OSM에서 생성된 텍스트 임베딩 작업)

### 협력자
* [Clement Atzberger](https://www.linkedin.com/in/clement-atzberger-8abb8065/?originalSubdomain=at), dClimate Labs
* [Andrew Blake](https://en.wikipedia.org/wiki/Andrew_Blake_(computer_scientist)), Mantle Labs

### 방문 연구원
* Silja Sormunnen, 알토 대학교, 핀란드
* Isabel Mansley (에든버러 대학교, David Coomes 및 Anil Madhavapeddy와 함께 [스코틀랜드 서식지 매핑](https://anil.recoil.org/ideas/cairngorms-connect-habitats) 작업)


## 연락처

기술적인 질문은 Frank Feng (zf281@cam.ac.uk)에게 문의하시거나 [Zulip 포럼](https://eeg.zulipchat.com/login/)에 질문해 주세요. 비기술적인 질문은 Prof. S. Keshav (sk818@cam.ac.uk)에게 보내실 수 있습니다.

## 인용

연구에 TESSERA를 사용하셨다면, [arXiv 논문](https://arxiv.org/abs/2506.20380)을 인용해 주세요:

```bibtex
@misc{feng2025tesseratemporalembeddingssurface,
      title={TESSERA: Temporal Embeddings of Surface Spectra for Earth Representation and Analysis}, 
      author={Zhengpeng Feng et al.},
      year={2025},
      eprint={2506.20380},
      archivePrefix={arXiv},
      primaryClass={cs.LG},
      url={https://arxiv.org/abs/2506.20380}, 
}
```
## 감사의 말  
우리는 이 프로젝트에 대한 관대한 지원에 대해 UKRI와 케임브리지의 [DAWN](https://www.hpc.cam.ac.uk/d-w-n) 슈퍼컴퓨터 팀에 감사를 표합니다. 또한 [AMD](https://www.amd.com/en.html), [Vultr](https://www.vultr.com/), [Dirac 고성능 컴퓨팅 시설](https://dirac.ac.uk), [Microsoft AI For Good Lab](https://www.microsoft.com/en-us/research/group/ai-for-good-research-lab/), Dr. Robert Sansom, [dClimate](https://www.dclimate.net/), 그리고 AWS Open Data 프로그램(https://opendata.aws/) 하에 있는 [Amazon Web Services (AWS)](https://aws.amazon.com/)의 지원도 인정합니다. 이 작업은 그들의 지원, 계산 자원 및 기술 지원 없이는 불가능했을 것입니다.  

## 스타 히스토리  
[![Star History Chart](https://api.star-history.com/svg?repos=ucam-eo/tessera&type=Date)](https://www.star-history.com/#ucam-eo/tessera&Date)  

## AUP  

### TESSERA 이용 약관 및 윤리 지침  

### 라이선스  

TESSERA 데이터 및 임베딩은 **Creative Commons 0 국제 라이선스 [CC-0](https://creativecommons.org/public-domain/cc0/)** 하에 제공됩니다.  
이는 다음이 자유롭다는 것을 의미합니다:  

* **공유** — 어떤 매체나 형식으로든 자료를 복사하고 재배포할 수 있음  
* **적용** — 자료를 리믹스, 변형, 그리고 상업적 목적을 포함하여 어떤 목적으로든 구축할 수 있음  

### 목적 및 의도된 사용  

TESSERA는 과학 연구를 진전시키고 환경 모니터링, 보존, 지속 가능한 농업 및 지구 시스템 이해를 지원하기 위해 개발되었습니다. 이 도구는 다음을 가능하게 하도록 설계되었습니다:  

* 과학 연구 및 교육  
* 환경 모니터링 및 보존  
* 농업 및 식량 안보 분석  
* 기후 변화 연구 및 적응 계획  
* 지속 가능한 토지 이용 및 자원 관리  
* 사회와 환경에 이익이 되는 공익적 응용  

### 윤리 지침  

CC0 라이선스가 광범위한 사용을 허용하지만, 사용자가 작업의 윤리적 함의를 고려할 것을 강력히 권고합니다. 이 윤리 지침은 자문적이며 법적 구속력을 갖는 제한을 부과하지 않습니다. 사용자에게 다음을 요청합니다:  

**책임감 있게 행동하십시오:**  
* 특정 위치 분석 시 프라이버시 영향 고려  
* 영향을 받는 공동체의 권리와 존엄성 존중  
* 잠재적 이중 사용 문제에 유의  

**투명성을 유지하십시오:**

* 데이터의 특성(연간 해상도, 10m 공간 해상도)을 정확하게 표현하세요  
* 응용 프로그램의 한계를 인지하세요  
* TESSERA의 기능을 오해하지 마세요  

**긍정적 영향 지원:**  
* 귀하의 작업이 사회적 이익에 어떻게 기여하는지 고려하세요  
* 적절할 경우 영향을 받는 커뮤니티와 소통하세요  
* 공공 지식을 향상시키는 결과를 공유하세요  

### 데이터 특성  

사용자는 TESSERA가 다음을 제공한다는 점을 이해해야 합니다:  
* **연간 시간 해상도** — 데이터는 실시간이나 고주파수 모니터링이 아닌 연간 요약을 나타냅니다  
* **10미터 공간 해상도** — 경관 규모 분석에 적합합니다  
* **스펙트럼-시간 임베딩** — 압축된 표현으로 원시 영상이 아닙니다  

이 특성들을 작업에 정확하게 반영해 주십시오.  

### 커뮤니티 기준  

책임감 있는 사용을 권장하며 커뮤니티 피드백을 환영합니다. 잠재적 응용에 대한 우려나 지침 개선 제안이 있으면 연락해 주십시오.  

우리는 커뮤니티 의견 및 새로운 고려 사항에 따라 이 지침을 업데이트할 권리를 보유하지만, 이러한 업데이트는 데이터가 배포된 CC-0 라이선스에 소급 적용되지 않습니다.  

### 연락처  

질문이나 피드백: 이메일 sk818@cam.ac.uk  

---  

*최종 업데이트: 2026년 2월 25일*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-09

---