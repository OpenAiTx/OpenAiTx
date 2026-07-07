# Tail Tray
Tailscale 트레이 메뉴 및 Plasma 데스크탑용 UI

**면책 조항** 저는 Tailscale Inc.와 _전혀_ 관련이 없음을 알려드립니다.

이 프로젝트는 개인 프로젝트이며 Tailscale Inc.의 어떤 형태로도 승인받지 않았습니다.

### 기능
- [X] 트레이에서 Tailscale 연결 제어
- [X] IP 표시
- [X] 장치의 현재 연결 상태 표시
- [X] 네트워크 및 네트워크 상태 개요
- [X] Tailscale 출구 노드 설정 및 변경
- [X] 적절한 다중 계정 처리
- [X] Mullvad 출구 노드
- [X] Tail 드라이브 지원 - davfs2 지원과 추가적인 davfs2 설정 및 마운트 도움
- [X] 트레이 메뉴에서 Tailnet의 모든 장치로 파일 전송
- [X] 미리 정의된 디스크 위치로 Tailnet의 모든 장치에서 알림 및 파일 수신
- [X] 주요 배포판용 사전 빌드 바이너리 및 실험적 Windows 지원

### 라이선스
GNU 일반 공중 사용 허가서 v3.0 - 자세한 내용은 [LICENSE](LICENSE) 참조

### 설치
현재 가장 쉽고 신뢰할 수 있는 설치 방법은 소스에서 빌드하는 것입니다.
자세한 내용은 아래의 시작하기 섹션을 참고하세요.

### 전제 조건
* Tailscale 설치 및 실행 - https://tailscale.com
* davfs2 설치 및 구성 (Tail 드라이브 사용 또는 접근 예정인 경우. Tail Tray가 자동 구성도 도와줌) - https://wiki.archlinux.org/title/Davfs2

### 지원 아키텍처
* x86_64
* ARM64
* QT 6이 지원하고 이 프로젝트를 컴파일할 수 있으며 Tailscale이 실행되는 기타 모든 아키텍처

### 시작하기

### 사전 빌드 패키지

 * [Debian / Ubuntu / Mint 기반 배포판](https://github.com/SneWs/tail-tray/releases)
 * [OpenSUSE 및 Fedora RPM](https://software.opensuse.org/download.html?project=home%3Aayankov&package=tail-tray)
 * [NixOS](/docs/nix-os.md)
 * [Windows (실험적! 최신 불안정 버전만, 서명되지 않음)](https://github.com/SneWs/tail-tray/releases/download/latest/Tail-Tray-Windows.zip)

### 소스에서 빌드 및 설치
 * [리눅스에서](/docs/build-from-src.md)
 * [윈도우에서](/docs/build-from-src-windows.md)

### 스크립트 가능한 동작
스크립트 가능한 동작을 작성하고 사용하는 방법에 대해 더 알고 싶다면, [스크립트 가능한 동작 가이드](https://raw.githubusercontent.com/SneWs/tail-tray/master/docs/scriptable-actions.md)를 읽어보세요.

### 참여 및 버그 신고
* 이 프로젝트 개발에 참여하고 싶다면, 자유롭게 저장소를 포크하고 풀 리퀘스트를 제출해 주세요.
* 버그는 누구나 겪습니다... 문제 탭에 이슈를 등록해 주시면 함께 해결해 나가겠습니다.

### 스크린샷
![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/launcher.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/connected-tray.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/disconnected-tray.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/settings-ui.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/network-status.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/file-sharing.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/devices-ui.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/ui-settings.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives01.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives02.png)

![스크린샷](https://raw.githubusercontent.com/SneWs/tail-tray/master/screenshots/tail-drives03.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-07

---