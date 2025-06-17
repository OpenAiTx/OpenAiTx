# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (와!! NB)

VANB는 GStreamer 기반의 비디오/오디오 스트림 변환 도구로, NDI와 RTMP 프로토콜 간의 양방향 변환을 지원합니다. 이 도구를 통해 NDI 소스를 RTMP 서버로 송출하거나, RTMP 스트림을 NDI 출력으로 변환할 수 있습니다.

본 프로젝트는 [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html) 라이선스로 오픈소스 공개됩니다.

## 지원 플랫폼

현재 주로 다음 플랫폼을 지원합니다:
- macOS (Apple Silicon)

## 환경 요구사항

### 시스템 의존성
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### 설치 단계
1. [NewTek NDI SDK](https://www.ndi.tv/sdk/) 설치

2. Homebrew를 통해 GStreamer 설치
```bash
brew install --cask --zap gstreamer-development
```

3. 프로젝트 저장소 클론
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Python 의존성 설치
```bash
pip install -r requirements.txt
```

5. 환경 변수 설정 (.env 파일 참고)
```bash
# NDI SDK 경로 설정
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# GStreamer 플러그인 경로 설정
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## 사용 방법

### NDI to RTMP (송신 측)
```bash
python vanb_tx.py
```
프로그램이 자동으로 사용 가능한 NDI 소스를 스캔한 뒤, RTMP 송출 주소 입력을 안내합니다.

### RTMP to NDI (수신 측)
```bash
python vanb_rx.py
```
RTMP 수신 주소 입력 후, 프로그램이 자동으로 새로운 NDI 출력을 생성합니다.

## 개발 상태

### 구현된 기능
- ✓ NDI에서 RTMP로 변환
- ✓ RTMP에서 NDI로 변환
- ✓ 자동 프레임레이트 및 해상도 적응
- ✓ 오디오/비디오 동기화
- ✓ NDI 소스 자동 스캔
- ✓ NDI 출력 자동 명명
- ✓ VideoToolbox 하드웨어 코덱 지원

### 미구현 기능
- ⨯ 구성 파일 지원 (Profile/config.json)
  - 구성 파일을 통한 입출력 파라미터 제어
  - 다양한 트랜스코딩 프리셋 지원
  - 버퍼 크기 및 지연 파라미터 설정 지원
  - 트랜스코딩 품질/성능 균형 설정 지원
- ⨯ 다중 스트림 동시 처리

## 라이선스 안내

⚠️ **중요 안내: 라이선스 및 컴플라이언스**

### 소프트웨어 라이선스

본 프로젝트는 [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html)로 라이선스됩니다.

GPL-3.0 라이선스를 선택한 이유:
1. 본 프로젝트는 여러 GPL 라이선스의 GStreamer 플러그인을 사용합니다:
   - `x264`: H.264 비디오 인코더 (GPL)
   - `x265`: HEVC/H.265 비디오 인코더 (GPL)
   - `faad`: AAC 오디오 디코더 (GPL)
2. GPL의 전염성 조항에 따라, GPL 구성요소를 사용하는 소프트웨어 역시 GPL 라이선스를 따라야 합니다
3. GPL-3.0 선택을 통해 모든 의존 구성요소와 라이선스 호환성을 보장할 수 있습니다

### 라이선스 준수 요건

본 프로젝트 사용 시, 다음 사항을 준수해야 합니다:
1. **소스코드 공개**: 본 프로젝트의 코드를 수정하거나 귀하의 프로젝트에 통합하는 경우, 전체 소스코드를 공개해야 합니다
2. **라이선스 유지**: 귀하의 프로젝트 역시 GPL-3.0 라이선스를 계속 사용해야 합니다
3. **저작권 고지**: 원본 저작권 및 라이선스 고지를 유지해야 합니다
4. **변경 사항 명시**: 코드를 수정한 경우, 변경 내역을 명확히 표시해야 합니다
5. **특허 허여**: GPL-3.0은 명확한 특허 허여 조항을 포함합니다

### GStreamer 구성요소 라이선스
1. 본 프로젝트는 개발 및 테스트 용도로만 사용해야 합니다
2. NDI®는 NewTek, Inc.의 등록 상표입니다
3. 본 프로젝트 사용 시 NewTek NDI® SDK 라이선스 계약을 준수해야 합니다
4. 운영 환경에서 사용 전, 모든 필요한 라이선스 및 권한을 취득해야 합니다

## 문제 피드백

문제가 발생한 경우, 다음을 확인해 주세요:
1. 환경 변수가 올바르게 설정되었는지 확인
2. GStreamer 플러그인이 정상적으로 설치되었는지 확인
3. 로그 파일의 상세 오류 내용 확인
4. Issues를 통해 문제를 피드백하고, 로그 및 환경 정보를 첨부해 주세요

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---