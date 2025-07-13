# 🖼️ HEIC 이미지 처리 도구

HEIC(High Efficiency Image Container) 파일을 처리하기 위한 파이썬 도구 모음으로, HDR 콘텐츠 추출 및 EXR 변환에 중점을 두고 있습니다.

## 🛠️ 도구 개요

### 1. gain_map_extract.py
HEIC 파일에서 모든 구성요소를 추출합니다. 포함 항목:
- 기본 이미지
- HDR 게인 맵
- 깊이 맵
- 전체 메타데이터(EXIF, XMP, ICC 프로필)

### 2. heic_to_exr.py
HEIC 파일을 OpenEXR 포맷으로 변환합니다:
- 기본 이미지와 게인 맵을 결합하여 애플 방식으로 HDR EXR 생성
- 전체 다이내믹 레인지 보존
- 가능한 경우 메타데이터 유지
- 배치 처리 지원
### 3. merge_to_exr.sh
배치 처리를 위한 셸 스크립트:
- HEIC를 EXR로 변환 자동화
- 다수의 파일 처리
- 진행 상황 피드백 제공
- 디렉터리 구조 유지

## 🔧 설치

### 사전 요구 사항
- Python 3.8 이상
- pip (Python 패키지 관리자)
- Git (저장소 클론용)

### macOS
```bash
# Homebrew가 설치되어 있지 않다면 설치
/bin/bash -c "$(curl -fsSL https://raw.githubusercontent.com/Homebrew/install/HEAD/install.sh)"

# Python 및 OpenEXR 종속성 설치
brew install python3 openexr

# 저장소를 클론합니다.
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# 가상 환경을 생성하고 활성화합니다.
python3 -m venv venv
source venv/bin/activate

# Python 의존성 설치
pip install -r requirements.txt
```

### Linux (Ubuntu/Debian)
```bash
# 시스템 의존성 설치
sudo apt-get update
sudo apt-get install python3 python3-pip python3-venv openexr libopenexr-dev

# 저장소 복제
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# 가상 환경 생성 및 활성화
python3 -m venv venv
source venv/bin/activate

# Python 의존성 설치
pip install -r requirements.txt
```

### Windows
```powershell
# https://www.python.org/downloads/ 에서 Python 설치
# https://git-scm.com/download/win 에서 Git 설치

# 저장소 복제
git clone https://github.com/finnschi/heic-shenanigans.git
cd heic-shenanigans

# 가상 환경 생성 및 활성화
python -m venv venv
.\venv\Scripts\activate

# Python 의존성 설치
pip install -r requirements.txt
```

## 📋 요구 사항
필요한 모든 Python 패키지는 requirements.txt에 나열되어 있습니다:
- Pillow: 이미지 처리 라이브러리
- pillow-heif: HEIC 파일 지원
- numpy: 수치 연산
- defusedxml: 안전한 XML 파싱

시스템 의존성(패키지 관리자를 통해 설치):
- EXR 파일 처리를 위한 OpenEXR 및 OpenImageIO(oiiotool)

## 💻 사용법
### 게인 맵 추출
```bash
python gain_map_extract.py input.heic [--output-dir OUTPUT_DIR]
```

### HEIC에서 EXR로 변환
```bash
python heic_to_exr.py input.heic [--output-dir OUTPUT_DIR]
```

### 배치 처리
```bash
./merge_to_exr.sh input_directory output_directory
```

## 📁 출력 파일

### gain_map_extract.py 출력:
- 기본 이미지: `{filename}_base.tiff`
- 게인 맵: `{filename}_gain_map_{id}.tiff`
- 뎁스 맵: `{filename}_depth_{index}.tiff`
- 메타데이터: `{filename}_metadata.json`

### heic_to_exr.py 출력:
- HDR EXR 파일: `{filename}.exr`

## 🔍 고급 사용법

### 메타데이터 처리
- 바이너리 데이터는 base64로 인코딩됨
- ICC 프로필이 유지됨
- EXIF 데이터는 가능한 한 보존됨

### HDR 처리
- 게인 맵이 적절하게 스케일링됨
- 선형 색 공간이 유지됨
- EXR 출력에서 전체 다이내믹 레인지가 보존됨

## ⚠️ 알려진 제한사항
- 일부 HEIC 변형은 완전히 지원되지 않을 수 있음
- 뎁스 맵 추출은 지원되는 기기에만 제한됨
- Windows OpenEXR 지원은 추가 구성이 필요할 수 있음
## 🤝 기여하기
기여를 환영합니다! 언제든지 Pull Request를 제출해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---