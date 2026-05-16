<div align="center">
  <img src="https://raw.githubusercontent.com/Stallion77RepoOfficial/MetalGoose/main/Assets/logo.png" alt="MetalGoose Logo" width="128" height="128">
  
  # MetalGoose
  
  **macOS용 GPU 가속 업스케일링 및 프레임 생성**
  
  [![macOS](https://img.shields.io/badge/macOS-26.0%2B-blue?logo=apple)](https://www.apple.com/macos/)
  [![Metal](https://img.shields.io/badge/Metal-4.0-orange?logo=apple)](https://developer.apple.com/metal/)
  [![License](https://img.shields.io/badge/License-GPL--3.0-green)](LICENSE)
  [![Swift](https://img.shields.io/badge/Swift-6.2-FA7343?logo=swift)](https://swift.org)
  
  [기능](#features) • [설치](#installation) • [사용법](#usage) • [요구사항](#requirements) • [빌드](#building) • [라이선스](#license)
</div>

---

## 개요

MetalGoose는 게임 및 애플리케이션을 위한 실시간 업스케일링 및 프레임 생성을 제공하는 네이티브 macOS 애플리케이션입니다. Apple의 Metal 프레임워크로 완전히 구축되어 NVIDIA DLSS 또는 AMD FSR과 유사한 부드럽고 높은 FPS 경험을 제공하지만 macOS에 최적화되어 있습니다.

## 기능

### MGUP-1 업스케일링
- **성능 모드** — 최소 지연으로 가장 빠른 업스케일링
- **균형 모드** — 최적의 품질/성능 비율
- **품질 모드** — 최대 시각적 충실도
- 다양한 렌더 스케일: 네이티브, 75%, 67%, 50%, 33%
- 대비 적응형 샤프닝 (CAS)

### MGFG-1 프레임 생성
- **2배, 3배, 4배** 프레임 배수
- **적응형** 또는 **고정** 프레임 생성 모드
- 모션 보상 보간
- 광학 흐름 기반 모션 추정
- 품질 모드: 성능, 균형, 품질

### 안티앨리어싱
- **FXAA** — 빠른 근사 안티앨리어싱
- **SMAA** — 향상된 서브픽셀 형태학적 AA
- **MSAA** — 다중 샘플 안티앨리어싱  
- **TAA** — 히스토리를 활용한 시간적 안티앨리어싱  

### 성능 모니터링  
- 실시간 HUD 오버레이  
- 캡처/출력/보간 FPS 추적  
- GPU 시간 및 프레임 시간 지표  
- VRAM 사용량 모니터링  
- 프레임 통계  

## 요구 사항  

| 구성 요소 | 요구 사항 |  
|-----------|-------------|  
| **macOS** | 26.0 (Tahoe) 이상 |  
| **칩** | Apple Silicon (M1/M2/M3/M4) |  
| **Xcode** | 26.0 이상 |  
| **RAM** | 최소 8GB, 권장 16GB |  

## 설치  

### 릴리스 다운로드  
1. [Releases](https://github.com/Stallion77RepoOfficial/MetalGoose/releases) 에서 최신 릴리스를 다운로드합니다.  
2. `MetalGoose.app`를 `/Applications`로 이동합니다.  
3. 화면 녹화 및 접근성 권한을 요청 시 허용합니다.  

### 소스에서 빌드하기
```bash
git clone https://github.com/Stallion77RepoOfficial/MetalGoose
cd MetalGoose
open MetalGoose.xcodeproj
```
## 사용법

1. **MetalGoose 실행**
2. **대상 선택**
   - 캡처할 창 또는 디스플레이 선택
3. **설정 구성**
   - 업스케일링 활성화 (MGUP-1)
   - 프레임 생성 활성화 (MGFG-1)
   - 안티앨리어싱 모드 선택
4. **스케일링 시작**
   - "시작" 클릭하여 처리 시작

### 키보드 단축키

| 단축키 | 동작 |
|--------|-------|
| `⌘ + T` | 스케일 토글 |

# MetalGoose 오류 코드

## UI (MG-UI)
- MG-UI-002: 최전면 앱이 MetalGoose임; 사용자가 대상 창으로 전환해야 함.
- MG-UI-003: 선택한 앱에 대상 창이 없음.
- MG-UI-004: 디스플레이를 찾을 수 없음.
- MG-UI-005: 전체화면 창 감지됨; 가상 디스플레이는 창 모드 또는 테두리 없는 모드 필요.
- MG-UI-006: 대상 창 경계 정보를 사용할 수 없음.
- MG-UI-007: 대상 화면에 대한 디스플레이 ID를 찾을 수 없음.
- MG-UI-008: 디스플레이 새로 고침 빈도 정보를 사용할 수 없음.

## 엔진 (MG-ENG)
- MG-ENG-001: Metal 파이프라인 설정 실패.
- MG-ENG-002: Metal 장치를 사용할 수 없음.
- MG-ENG-003: Metal 명령 대기열을 사용할 수 없음.
- MG-ENG-004: MetalFX 공간 스케일러 생성 실패.
- MG-ENG-005: 옵티컬 플로우 파이프라인을 사용할 수 없음.
- MG-ENG-006: 프레임 보간 실패.
- MG-ENG-007: 안티앨리어싱 파이프라인을 사용할 수 없음.
- MG-ENG-008: 스케일 파이프라인을 사용할 수 없음.
- MG-ENG-009: CAS 파이프라인을 사용할 수 없음.

- MG-ENG-010: IOSurface 텍스처 생성 실패.
- MG-ENG-011: 광학 흐름 파이프라인 사용 불가.
- MG-ENG-012: 광학 흐름 리소스 사용 불가.
- MG-ENG-013: 프레임 생성 파이프라인 사용 불가.

## 가상 디스플레이 (MG-VD)
- MG-VD-001: CGVirtualDisplayDescriptor 생성 실패.
- MG-VD-002: CGVirtualDisplay 생성 실패.
- MG-VD-003: CGVirtualDisplayMode 생성 실패.
- MG-VD-004: CGVirtualDisplaySettings 생성 실패.
- MG-VD-005: 가상 디스플레이 설정 적용 실패.
- MG-VD-006: 활성 가상 디스플레이 없음.
- MG-VD-007: ScreenCaptureKit에서 가상 디스플레이를 찾을 수 없음.
- MG-VD-008: ScreenCaptureKit 캡처 시작 실패.
- MG-VD-009: ScreenCaptureKit 캡처 중지 실패.
- MG-VD-010: 오류로 인해 ScreenCaptureKit 스트림 중지됨.

## 접근성 / 창 이동 (MG-AX)
- MG-AX-001: 접근성 권한이 부여되지 않음.
- MG-AX-002: AX API에서 창 목록 읽기 실패.
- MG-AX-003: 대상 PID에 대한 창을 찾을 수 없음.
- MG-AX-004: AX 위치 값 생성 실패.
- MG-AX-005: AX 창 위치 설정 실패.
- MG-AX-006: 전체 화면 창은 가상 디스플레이로 이동할 수 없음.
- MG-AX-007: AX 크기 값 생성 실패.
- MG-AX-008: AX 창 크기 설정 실패.
- MG-AX-009: 가상 디스플레이 화면을 찾을 수 없음.
- MG-AX-010: 대상 PID에 대한 창 ID를 찾을 수 없음.

## 오버레이 (MG-OV)
- MG-OV-001: 오버레이 생성 대상 화면이 없음.
- MG-OV-002: 오버레이 생성 대상 창 프레임이 없음.
- MG-OV-003: 오버레이 텍스처 생성에 지원되지 않는 픽셀 포맷.

## 마우스 라우팅 (MG-MO)
- MG-MO-001: 마우스 라우팅을 위한 가상 디스플레이가 구성되지 않음.

## 라이선스

이 프로젝트는 GNU 일반 공중 사용 허가서 v3.0에 따라 라이선스가 부여됩니다 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하십시오.

## Acknowledgments

- Apple for the Metal framework and documentation
- The macOS gaming community for feedback and testing
- Contributors who helped improve the project

---

RESOURCES THAT USED FOR THIS PROJECT

https://developer.apple.com/documentation/metal
https://developer.apple.com/documentation/metalfx/
https://developer.apple.com/documentation/coreimage
https://developer.apple.com/documentation/screencapturekit/
https://developer.apple.com/documentation/appkit
https://developer.apple.com/documentation/metal/mtltexture
https://developer.apple.com/documentation/corevideo/cvpixelbuffer
https://developer.apple.com/documentation/metalperformanceshaders
https://developer.apple.com/documentation/metal/compute-passes
https://developer.apple.com/documentation/vision
https://developer.apple.com/documentation/vision/vngenerateopticalflowrequest
https://developer.apple.com/documentation/ScreenCaptureKit/capturing-screen-content-in-macos


<div align="center">
  <sub>Built with ❤️ using Metal for macOS</sub>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-16

---