# ByeTunes 🎵

**iTunes 동기화와 작별하세요!**

ByeTunes는 음악(MP3, M4A, FLAC, WAV)과 벨소리를 기기의 미디어 라이브러리에 직접 주입할 수 있는 네이티브 iOS 앱으로, 매번 컴퓨터 연결 없이도 동기화가 가능합니다. iOS 미디어 데이터베이스와 직접 통신하여 사용자가 원하는 방식으로 음악을 관리할 수 있습니다.

## 기능

-   **직접 음악 주입**: PC 없이 Apple Music 라이브러리에 노래 추가.
-   (현재 비활성화) **벨소리 관리자**: 커스텀 벨소리 주입(`.m4r` 및 `.mp3` 자동 변환).
-   **재생목록 지원**: 즉석에서 재생목록 생성 및 관리.
-   **컴퓨터 불필요** (설정 후): 한 번 페어링하면 자유롭게 사용 가능!
-   **메타데이터 편집**: iTunes 또는 Deezer에서 자동 가져오기.

## 컴파일 지침

ByeTunes를 직접 빌드하려면 Xcode가 설치된 Mac이 필요합니다.

### 사전 조건

1.  **Xcode**: 버전 15 이상 권장.
2.  **iOS 기기**: iOS 16.0 이상 실행 중.

### 외부 라이브러리

ByeTunes는 iOS 내부 파일 시스템과 통신하기 위해 `idevice`(`libimobiledevice` 대체)를 사용합니다. **이 파일들은 라이선스 및 용량 문제로 이 저장소에 포함되어 있지 않습니다.**

앱을 컴파일하려면 이 두 파일을 구해서 `MusicManager/` 디렉터리에 넣어야 합니다:

1.  `libidevice_ffi.a` (정적 라이브러리)
2.  `idevice.h` (헤더 파일)

idevice는 여기에서 찾아 컴파일할 수 있습니다: [https://github.com/jkcoxson/idevice](https://github.com/jkcoxson/idevice)

*이 파일들이 없으면 프로젝트는 컴파일되지 않습니다.*

### 빌드 단계

1.  Rust 설치:
    ```bash
    curl --proto '=https' --tlsv1.2 -sSf https://sh.rustup.rs | sh
    ```
2.  ios 아키텍처 추가:
    ```bash
    rustup target add aarch64-apple-ios
    ```
    
3.  Xcode 명령어 도구가 이미 설치되어 있지 않다면 설치하십시오:
    ```bash
    xcode-select --install
    ```

4.  레포지토리를 클론하세요:
    ```bash
    git clone https://github.com/jkcoxson/idevice
    ```

5.  배포 대상 설정:
    ```bash
    export IPHONEOS_DEPLOYMENT_TARGET=xx.x
    ```

6.  cargo 빌드를 실행합니다:
    ```bash
    cargo build --release --package idevice-ffi --target aarch64-apple-ios
    ```
idevice 폴더 안에서 다음을 찾으세요: idevice.h와 libidevice_ffi.a. Xcode 프로젝트 안으로 이동시키고, **Bridging-Header.h**를 꼭 생성하세요  
Xcode 프로젝트 안에서 그리고 다음을 추가했는지 확인하세요:

 ```bash
    #import "idevice.h"
```
**프로젝트 설정 > 빌드 단계 > 라이브러리와 바이너리 연결에서 libidevice_ffi.a가 목록에 있는지 확인하세요.**

## 사용 방법

1. **LocalDevVPN**:
    - App Store/Altstore PAL https://apps.apple.com/us/app/localdevvpn/id6755608044 에서 LocalDevVPN을 다운로드하세요.
    - 앱을 열고 연결(Connect)을 탭하세요. 앱 내에서 페어링 파일을 가져오기 위해 활성 연결이 필요합니다.

2.  **페어링**:
    -   처음 실행하면 "페어링 파일 가져오기" 화면이 나타납니다.
    -   `페어링 파일`이 필요합니다.
    -   idevice_pair를 다운로드하세요. https://github.com/jkcoxson/idevice_pair 를 참조하세요.
    -   `페어링 파일`을 생성하세요.
    -   컴퓨터에서 내보내고 Airdrop 또는 저장을 통해 iPhone에 전송하세요.
    -   ByeTunes에 가져오세요.
      
3.  **음악 추가**:
    -   "노래 추가"를 탭하고 파일 앱에서 파일을 선택하세요.
    -   "기기에 주입"을 누르고 마법을 지켜보세요.
      
4.  **벨소리**:
    -   벨소리 탭으로 가서 파일을 추가하고 주입하세요!

## 참고 사항

-   **서명된 앱**: 서명 서비스(Signulous, AltStore 등)를 통해 설치하는 경우, 앱에는 파일 가져오기가 충돌 없이 제대로 작동하도록 하는 수정사항(`asCopy: true`)이 포함되어 있습니다.
-   **백업**: 데이터베이스 주입 작업을 하기 전에 항상 음악 라이브러리 백업을 권장합니다!

## 지원 및 버그 신고

버그를 발견하셨나요? 저희가 고치고 싶습니다!

1.  **문제 신고**: [GitHub Issues](https://github.com/EduAlexxis/ByeTunes/issues)에서 티켓을 열어주세요.
2.  **커뮤니티 참여**: [Discord](https://discord.gg/dDQ4P4SyKJ)에서 저희와 채팅하세요.
3.  **디버그 로그 첨부**:
    *   주입 실패가 발생하면 설정 내 라이브러리 삭제 밑의 **디버그 옵션**을 사용하세요.
    *   여기에는 앱 로그를 복사할 수 있는 "디버그 로그" 화면이 포함되어 있습니다.
    *   이 로그를 문제 신고에 첨부해 주세요—문제 해결이 훨씬 빨라집니다!


---
*EduAlexxis가 ❤️를 담아 제작했습니다*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-04

---