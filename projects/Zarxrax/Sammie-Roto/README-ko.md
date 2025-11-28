
# Sammie-Roto
**S**egment **A**nything **M**odel with **M**atting **I**ntegrated **E**legantly

![Sammie-Roto screenshot](https://raw.githubusercontent.com/Zarxrax/Sammie-Roto/main/sammie/sammie_screenshot.webp)

Sammie-Roto는 비디오 클립의 AI 지원 마스킹을 위한 사용자 친화적인 도구로 설계되었습니다. Adobe의 Roto Brush나 DaVinci Resolve의 Magic Mask와 같은 상용 솔루션의 무료 대안으로 제공됩니다. 일반적으로 수동 로토스코핑보다는 정확도가 떨어지지만, 적은 노력으로 꽤 좋은 결과를 얻을 수 있습니다.

## 새로운 [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)를 확인해보세요!

### 업데이트
- [2025/10/31] [Sammie-Roto 2](https://github.com/Zarxrax/Sammie-Roto-2)가 출시되었습니다! 모든 향후 업데이트는 해당 버전에서 이루어집니다.
- [2025/09/22] PNG 내보내기 추가, 이미지 시퀀스 가져오기, 매팅 내보내기 버그 수정, CLI를 통한 비디오 로드 기능 추가.
- [2025/08/23] 내보내기 탭에 파일명에 다양한 정보를 넣을 수 있는 옵션 추가.
- [2025/08/16] 프레임 가장자리의 마스크를 수정하는 데 도움이 되는 테두리 수정 슬라이더 추가. 매팅 시 VRAM 사용량 감소.
- [2025/08/03] 애니메이션 콘텐츠 가장자리 잡음 감소를 위한 중복 제거 기능 추가.
- [2025/05/10] 단일 이미지 가져오기/내보내기 지원 추가. 내보내기 설정이 저장되도록 변경.
- [2025/04/23] Linux/Mac용 설치 프로그램 추가, VRAM 사용량 감소, 여러 개선 및 버그 수정.
- [2025/04/04] 매팅 페이지에 일부 조정 슬라이더 추가.
- [2025/02/26] [MatAnyone](https://github.com/pq-yang/MatAnyone)을 통한 인간 비디오 매팅 지원 및 기타 여러 개선 사항 추가.
- [2025/01/26] 초기 릴리스

### 기능
- Windows, Linux, Mac 지원
- 간단한 설치 프로그램으로 모든 종속성 및 모델 자동 다운로드
- 4GB VRAM 또는 CPU에서도 실행 가능 (하지만 6GB Nvidia GPU 권장)
- 3가지 분할 모델 포함: Sam 2.1 Large, Sam 2.1 Base+, EfficientTAM_s_512x512
- 인간 비디오 매팅을 위한 MatAnyone 모델 지원
- 사용하기 쉬운 인터페이스
- 다중 객체 지원
- 가장자리 부드럽게 처리 등 다양한 마스크 후처리 옵션
- 애니메이션 콘텐츠 가장자리 잡음 감소를 위한 중복 제거 지원
- 여러 내보내기 옵션: 흑백 매트, 알파 채널, 그린스크린

### 설치 (Windows):
- 최신 Windows 버전을 [릴리즈](https://github.com/Zarxrax/Sammie-Roto/releases)에서 다운로드
- zip 압축 파일을 해제
- 'install_dependencies.bat' 실행 후 안내에 따름
- 'run_sammie.bat' 실행하여 소프트웨어 시작

모든 파일은 Sammie-Roto 폴더에 자체 포함되어 있습니다. 애플리케이션을 제거하려면 이 폴더를 삭제하면 됩니다. 폴더를 이동할 수도 있습니다.

### 설치 (리눅스, 맥)
- [Python](https://www.python.org/)이 설치되어 있는지 확인하세요 (버전 3.10 이상)
- [릴리즈](https://github.com/Zarxrax/Sammie-Roto/releases)에서 최신 리눅스/맥 버전을 다운로드하세요
- zip 압축을 해제하세요.
- 터미널을 열고 방금 압축을 푼 Sammie-Roto 폴더로 이동하세요.
- 다음 명령어를 실행하세요: `bash install_dependencies.sh` 그리고 안내에 따라 진행하세요.
- MacOS 사용자: "run_sammie.command"를 더블 클릭하여 프로그램을 실행하세요. 리눅스 사용자: `bash run_sammie.command` 또는 원하는 방식으로 파일을 실행하세요.

### 튜토리얼
[![Sammie-Roto 튜토리얼](https://img.youtube.com/vi/042uKTqlJ_c/0.jpg)](https://www.youtube.com/watch?v=042uKTqlJ_c)

### 감사의 글
* [SAM 2](https://github.com/facebookresearch/sam2)
* [EfficientTAM](https://github.com/yformer/EfficientTAM)
* [MatAnyone](https://github.com/pq-yang/MatAnyone)
* [Wan2GP](https://github.com/deepbeepmeep/Wan2GP) (최적화된 MatAnyone용)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-28

---