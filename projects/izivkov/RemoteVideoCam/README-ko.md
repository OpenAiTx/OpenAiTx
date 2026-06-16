# RemoteVideoCam

Remote Video Cam은 두 기기가 로컬 연결을 통해 고화질 비디오와 오디오를 서로 스트리밍할 수 있게 해주는 오픈 소스 안드로이드 애플리케이션입니다. 아기 모니터, DIY 보안 카메라, 워키토키 등으로 사용하든, RemoteVideoCam은 인터넷 접속이나 제3자 서버 없이도 안전하고 오프라인 우선 솔루션을 제공합니다.

## ✨ 기능

- **제로 구성**: 기기들이 자동으로 서로를 발견하고 연결합니다.
- **견고한 연결**: 사용 가능한 최적의 연결 방식을 자동으로 협상합니다:
  - **로컬 네트워크(LAN)**: 기존 Wi-Fi 네트워크를 사용합니다.
  - **Wi-Fi Aware / Wi-Fi Direct**: 액세스 포인트 없이 기기들을 직접 연결합니다 (오프라인).
- **안전하고 프라이빗함**: 외부 서버 없음. 클라우드 없음. 비디오와 오디오 스트림은 로컬 환경을 벗어나지 않습니다.
- **모던 UI**: **Jetpack Compose**와 **Material 3**로 구축되어, 아름답고 반응형이며 직관적인 인터페이스와 동적 색상을 제공합니다.
- **두 가지 모드**:
  - **카메라 모드**: 방송 역할을 합니다.
  - **디스플레이 모드**: 다른 기기의 영상을 봅니다.
    - *영상 좌우 반전을 위한 "미러" 옵션 포함.*
  - *참고: 양쪽 기기 모두 디스플레이 모드일 경우 서로를 볼 수 있습니다 (양방향).*
- **오디오 지원**: 상대방에서 일어나는 소리를 들을 수 있습니다.

## ⚠️ 중요 안내

**의료 기기가 아님**: RemoteVideoCam은 모니터링(예: 아기 모니터)에 유용할 수 있으나, 인증된 의료 기기가 아닙니다.
- 네트워크 간섭으로 영상이 멈출 수 있습니다.
- 항상 백업 모니터링 수단을 준비하세요.
- **팁**: 초침이 있는 시계 같은 움직이는 물체를 영상에 넣어 영상이 실시간임을 쉽게 확인하세요.

## 🛠️ 기술 스택

- **언어**: Kotlin
- **UI 프레임워크**: Jetpack Compose (Material 3)
- **비디오/오디오**: WebRTC (로컬 협상)
- **컴퓨터 비전**: OpenCV (특정 이미지 처리 작업용)
- **아키텍처**: MVVM과 반응형 데이터 스트림 (RxJava/RxAndroid)

## 📥 distinct

[<img src="https://fdroid.gitlab.io/artwork/badge/get-it-on.png"
     alt="Get it on F-Droid"
     height="80">](https://f-droid.org/packages/org.avmedia.remotevideocam/)
[<img src="https://play.google.com/intl/en_us/badges/images/generic/en-play-badge.png"
     alt="Google Play에서 받기"
     height="80">](https://play.google.com/store/apps/details?id=org.avmedia.remotevideocam)

## 🤝 기여하기

기여는 언제나 환영합니다! 개발자이시고 RemoteVideoCam 개선에 도움을 주고 싶다면, 자유롭게 저장소를 포크하고 풀 리퀘스트를 제출해 주세요.

중대한 변경사항이나 문의가 있을 경우, 유지 관리자에게 `izivkov@gmail.com`으로 연락해 주세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-16

---