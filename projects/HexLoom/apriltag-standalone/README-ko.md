# AprilTag 독립 감지 라이브러리

이것은 pupil-apriltags 라이브러리를 기반으로 한 AprilTag 인식 도구 모음으로, 카메라에서 AprilTag를 감지하고 추적하는 데 사용됩니다.

<!-- Keep these links. Translations will automatically update with the README. -->
[Deutsch](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=de) | 
[English](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=en) | 
[Español](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=es) | 
[français](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=fr) | 
[日本語](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ja) | 
[한국어](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ko) | 
[Português](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=pt) | 
[Русский](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=ru) | 
[中文](https://www.readme-i18n.com/HexLoom/apriltag-standalone?lang=zh)

## 의존 라이브러리

- Python 3.6+
- OpenCV
- NumPy
- pupil-apriltags

## 설치

1. Python 환경이 설치되어 있는지 확인합니다.
2. 필요한 의존 라이브러리를 설치합니다:

```bash
pip install opencv-python numpy pupil-apriltags
```

## 사용 방법

### 기본 사용법

```python
import cv2
from apriltag import Detector, DetectorOptions

# 감지기 생성
options = DetectorOptions(
    families="tag36h11",  # 태그 패밀리
    border=1,             # 태그 테두리 크기
    nthreads=4,           # 스레드 수
    quad_decimate=1.0,    # 이미지 다운샘플링 계수
    quad_blur=0.0,        # 가우시안 블러 계수
    refine_edges=True     # 에지 정밀화 여부
)
detector = Detector(options)

# 이미지 읽기
img = cv2.imread("test_image.jpg")
gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

# AprilTag 감지
detections = detector.detect(gray)

# 감지 결과 표시
for detection in detections:
    print(f"태그 패밀리: {detection.tag_family}, ID: {detection.tag_id}")
    print(f"위치: {detection.center}")
    print(f"코너: {detection.corners}")
```

### 감지 결과 그리기

```python
import numpy as np
from apriltag import draw_detection_results

# 카메라 내참 행렬 및 왜곡 계수
K = np.array([[800, 0, 320], [0, 800, 240], [0, 0, 1]], dtype=np.float32)
D = np.zeros((4, 1), dtype=np.float32)

# 감지 결과 그리기
result_img = draw_detection_results(img, detections, K, D, tag_size=0.1)

# 결과 표시
cv2.imshow("AprilTag 감지", result_img)
cv2.waitKey(0)
```

### 테스트 스크립트 실행

간단한 테스트 스크립트가 제공되며, AprilTag 감지 기능을 검증할 수 있습니다:

```bash
python test_apriltag.py
```

이 스크립트는 컴퓨터의 기본 카메라를 열어 실시간으로 AprilTag를 감지합니다. "q" 키를 누르면 종료됩니다.

## 지원 태그 패밀리

pupil-apriltags 라이브러리는 다음 태그 패밀리를 지원합니다:
- tag36h11 (기본값)
- tag25h9
- tag16h5
- tagCircle21h7
- tagCircle49h12
- tagStandard41h12
- tagStandard52h13
- tagCustom48h12

## 주의사항

- 더 나은 성능을 위해 DetectorOptions의 매개변수를 조정할 수 있습니다.
- 연산 자원이 제한된 장치에서는 quad_decimate 값을 높여 계산 복잡도를 줄일 수 있습니다.
- 사용하는 AprilTag 마커의 크기가 코드의 tag_size 매개변수와 일치하는지 확인하세요.
- 3D 좌표축을 그리려면 정확한 카메라 파라미터가 필요합니다.

## 기능 특징

- USB 카메라를 통한 실시간 AprilTag 감지 지원
- 태그의 3D 자세(위치 및 방향) 계산 및 표시
- 원본 및 태그 표시 이미지를 저장할 수 있음
- 사용자 정의 구성 및 카메라 파라미터 지원
- 완전한 카메라 캘리브레이션 도구 포함
- ROS에 의존하지 않는 순수 Python 독립 버전 (기존 ROS 패키지의 독립형 버전)

## 설치 단계

### 1. AprilTag C 라이브러리 설치

AprilTag의 C 라이브러리는 필수입니다. 아래의 절차에 따라 설치하세요:

#### Ubuntu/Debian:
```bash
sudo apt-get update
sudo apt-get install -y libapriltag-dev
```

#### Windows:
Windows 사용자는 직접 컴파일하거나 미리 컴파일된 바이너리를 다운로드해야 하며, `apriltag.dll`이 시스템 PATH 또는 현재 디렉터리에 있어야 합니다.

### 2. Python 의존성 설치

```bash
pip install -r requirements.txt  -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
pip install pupil-apriltags -i https://mirrors.tuna.tsinghua.edu.cn/pypi/web/simple
```

## 사용 설명

### 빠른 시작 (추천)

가장 간단한 사용 방법은 통합 도구를 실행하는 것으로, 대화형 메뉴로 모든 단계를 안내합니다:

```bash
python apriltag_tool.py
```

이 도구는 다음과 같은 메뉴 옵션을 제공합니다:
1. 체스보드 캘리브레이션 보드 생성
2. 카메라 캘리브레이션
3. AprilTag 감지
4. 도움말 보기

메뉴 안내에 따라 전체 프로세스를 완료할 수 있습니다.

### 카메라 캘리브레이션

AprilTag 감지 전에는 정확한 카메라 파라미터를 얻기 위해 카메라 캘리브레이션을 권장합니다:

```bash
# 먼저 체스보드 캘리브레이션 보드 생성
python create_chessboard.py --size 9x6 --square 100 --output chessboard.png --dpi 300

# 체스보드를 출력하고 실제 격자 크기를 측정한 뒤 캘리브레이션 실행
python camera_calibration.py --size 9x6 --square 0.025 --output config/camera/HSK_200W53_1080P.yaml
```

파라미터 설명:

**체스보드 생성 도구 (create_chessboard.py):**
- `--size`: 체스보드 내부 코너 수, 가로x세로 (기본값: 9x6)
- `--square`: 격자 크기(픽셀 단위, 기본값: 100)
- `--output`: 출력 파일 경로 (기본값: chessboard.png)
- `--dpi`: 출력 이미지 DPI (기본값: 300), 인쇄 크기에 영향

**카메라 캘리브레이션 프로그램 (camera_calibration.py):**
- `--size`: 체스보드 내부 코너 수, 가로x세로 (기본값: 9x6)
- `--square`: 격자 크기(미터 단위, 기본값: 0.025)
- `--output`: 출력 파일 경로 (기본값: config/camera/HSK_200W53_1080P.yaml)
- `--camera`: 카메라 디바이스 ID (기본값: 0)
- `--width`: 카메라 캡처 폭 (기본값: 1280)
- `--height`: 카메라 캡처 높이 (기본값: 720)
- `--samples`: 캘리브레이션에 필요한 샘플 수 (기본값: 20)
- `--preview`: 캘리브레이션 완료 후 보정 효과 미리보기

캘리브레이션 과정:
1. 체스보드 캘리브레이션 보드 생성 및 인쇄
2. 실제 격자 크기를(미터 단위로) 측정
3. 캘리브레이션 프로그램 실행, 카메라 앞에 체스보드를 다양한 각도로 놓고 샘플 채집
4. 프로그램이 자동으로 체스보드를 감지하고 샘플을 수집하며, 's' 키를 눌러 현재 프레임을 수동 저장할 수도 있음
5. 충분한 샘플이 수집되면, 프로그램이 자동으로 카메라 파라미터를 계산해 지정된 파일에 저장

### AprilTag 감지

캘리브레이션이 완료되면, AprilTag 감지 프로그램을 실행할 수 있습니다:
```bash
python apriltag_detector.py
```

### 고급 사용법

```bash
python apriltag_detector.py [설정 파일 경로] --camera 카메라ID --width 너비 --height 높이 --camera_info 카메라 파라미터 파일
```

파라미터 설명:
- `설정 파일 경로`: AprilTag 설정 파일 경로 (기본값: `config/vision/tags_36h11_all.json`)
- `--camera`: 카메라 장치 ID (기본값: 0)
- `--camera_info`: 카메라 내부 파라미터 파일 경로 (기본값: `config/camera/HSK_200W53_1080P.yaml`)
- `--width`: 카메라 캡처 너비 (기본값: 1280)
- `--height`: 카메라 캡처 높이 (기본값: 720)

### 키보드 제어

- `q`: 프로그램 종료

## 설정 파일 설명

시스템의 모든 설정은 `config/vision/table_setup.json` 파일에서 할 수 있습니다:

```json
{
    "AprilTagConfig": {
        "family": "tag36h11",      // 태그 패밀리
        "size": 0.05,              // 태그 실제 크기(단위: 미터)
        "threads": 2,              // 처리 스레드 수
        "max_hamming": 0,          // 최대 해밍 거리
        "z_up": true,              // Z축이 위로 향함
        "decimate": 1.0,           // 이미지 다운샘플링 계수
        "blur": 0.8,               // 블러 계수
        "refine_edges": 1,         // 에지 정밀화 여부
        "debug": 0                 // 디버그 모드
    },

    "Camera": {
        "device_id": 0,            // 카메라 장치 ID
        "width": 1280,             // 카메라 해상도(너비)
        "height": 720,             // 카메라 해상도(높이)
        "camera_info_path": "config/camera/HSK_200W53_1080P.yaml"  // 카메라 캘리브레이션 파라미터 파일
    },

    "Archive": {
        "enable": true,            // 데이터 아카이브 활성화 여부
        "preview": true,           // 미리보기 창 표시 여부
        "save_raw": false,         // 원본 이미지 저장 여부
        "save_pred": false,        // 예측 이미지 저장 여부
        "path": "./data/table_tracking"  // 데이터 저장 경로
    },

    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 기준 태그 ID 리스트
        "moving_tags": [4, 5, 6],            // 이동 태그 ID 리스트
        "require_initialization": true,       // 초기화 필요 여부
        "tag_positions": {                    // 태그의 사전 위치(있는 경우)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

설정 파일을 수정하여 다음을 할 수 있습니다:
1. AprilTag 감지기 파라미터 설정
2. 카메라 파라미터(장치ID, 해상도, 파라미터 파일) 설정
3. 데이터 아카이브 옵션 설정
4. 기준 태그 및 이동 태그 ID 커스터마이즈
5. 초기화 필요 여부 제어 (`require_initialization`을 `false`로 설정하면 초기화 단계 건너뜀)
6. 태그의 사전 위치 정보 입력

### 사용 방법

아주 간단하게 한 줄 명령어로 시스템을 시작할 수 있습니다:

```
python table_tracking.py
```

커스텀 설정 파일을 사용하려면:

```
python table_tracking.py --config 사용자설정파일경로
```

시스템 실행 후 언제든지 'i' 키를 눌러 수동으로 초기화 과정을 트리거할 수 있습니다.

## 자주 묻는 질문

1. **apriltag 라이브러리를 찾을 수 없음**
   
   apriltag 라이브러리가 올바르게 설치되어 있고, 시스템에서 찾을 수 있는 위치에 있는지 확인하세요.

2. **카메라를 열 수 없음**
   
   카메라 장치 ID가 올바른지, 카메라가 다른 프로그램에 의해 점유되어 있지 않은지 확인하세요.

3. **감지 결과가 정확하지 않음**
   
   카메라가 올바르게 캘리브레이션되었는지, 설정 파일의 태그 크기가 정확한지 확인하세요.


## 파일 구조 설명

```
apriltag_standalone/
├── apriltag.py              # AprilTag 감지 라이브러리 핵심 코드
├── apriltag_detector.py     # AprilTag 감지 메인 프로그램
├── apriltag_tool.py         # 통합 도구 실행 메뉴
├── camera_calibration.py    # 카메라 캘리브레이션 프로그램
├── create_chessboard.py     # 체스보드 생성 도구
├── configs.py               # 설정 파일 처리
├── config/                  # 설정 디렉터리
│   ├── camera/              # 카메라 설정
│   │   └── HSK_200W53_1080P.yaml  # 카메라 파라미터
│   └── vision/              # 비전 설정
│       └── tags_36h11_all.json # AprilTag 설정
├── README.md                # 설명서
└── requirements.txt         # Python 의존성
```

## 기술 설명

본 프로젝트는 ROS용 AprilTag 감지 패키지를 독립적으로 포팅한 버전으로, ROS 의존성을 제거하고 핵심 기능만 남겼습니다.
주요 사용 기술:

- OpenCV: 이미지 처리, 카메라 캘리브레이션 및 자세 추정
- AprilTag C 라이브러리: 태그 감지
- SciPy: 회전 행렬 및 쿼터니언 변환

## 라이선스

본 프로젝트는 MIT 라이선스를 따릅니다

## 신규 기능 설명

### 다중 태그 추적 및 가림(occlusion) 처리

이 시스템은 다음과 같은 신규 기능을 지원합니다:

1. **사진 기반 초기화**: 시스템 시작 시 한 번 자동으로 사진을 찍어 태그의 위치 관계를 기록합니다. 포함:
   - 고정 기준 태그(ID 0-3)의 위치
   - 여러 이동 태그(기본 ID 4,5,6) 간의 상대 위치 관계

2. **가림(occlusion) 처리**: 초기화 후 일부 태그가 가려져도,
   - 기준 태그가 가려진 경우, 시스템은 다른 보이는 기준 태그로 가려진 태그 위치를 추정할 수 있습니다.
   - 이동 태그가 가려진 경우, 다른 보이는 이동 태그로 가려진 이동 태그 위치를 추정할 수 있습니다.

3. **다중 태그 추적**: 여러 이동 태그를 동시에 추적 가능(기본 ID 4,5,6)
   - 이동 태그 사이의 상대 위치가 고정되어 있다면, 하나만 보여도 나머지 태그 위치를 추정 가능
   - 설정 파일에서 이동 태그 ID를 자유롭게 커스터마이즈 가능

### 설정 파일 설명

시스템의 모든 설정은 `config/vision/table_setup.json` 파일에서 할 수 있습니다:

```json
{
    "TableConfig": {
        "reference_tags": [0, 1, 2, 3],      // 기준 태그 ID 리스트
        "moving_tags": [4, 5, 6],            // 이동 태그 ID 리스트
        "require_initialization": true,       // 초기화 필요 여부
        "tag_positions": {                    // 태그의 사전 위치(있는 경우)
            "0": [0.0, 0.0, 0.0],
            "1": [0.5, 0.0, 0.0],
            "2": [0.5, 0.5, 0.0],
            "3": [0.0, 0.5, 0.0]
        }
    }
}
```

설정 파일을 수정하여 다음을 할 수 있습니다:
1. 기준 태그와 이동 태그 ID 커스터마이즈
2. 초기화 필요 여부 제어 (`require_initialization`을 `false`로 설정하면 초기화 단계 건너뜀)
3. 태그의 사전 위치 정보 입력

### 사용 방법

1. 기본 설정으로 시스템 실행:
   ```
   python table_tracking.py
   ```

2. 사용자 설정 파일로 시스템 실행:
   ```
   python table_tracking.py --config 사용자설정파일경로
   ```

3. 수동 초기화: 시스템 실행 중 'i' 키 입력

### 실행 요구 사항

초기화 시 모든 태그가 시야에 들어와 있어야 하며, 시스템은 태그 간 상대 위치 관계를 기록합니다. 초기화 후 일부 태그가 가려져도 시스템은 모든 태그의 위치를 올바르게 추정할 수 있습니다.
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---