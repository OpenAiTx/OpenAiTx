# 원신 유틸리티 [![License](https://img.shields.io/badge/License-GPL3.0-green.svg)](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) ![OS](https://img.shields.io/badge/OS-Windows-yellow.svg) [![Discord](https://img.shields.io/badge/chat-discord-informational)](https://discord.gg/MrtJvV5tKv)

원신 및 붕괴: 스타레일을 위한 무료 오픈 소스 도구로 몇 가지 편의 기능을 포함합니다. 게임의 OS 버전과만 호환됩니다.

## FAQ

### 모드를 어떻게 로드하나요?
1. [최신 릴리스](https://github.com/lanylow/genshin-utility/releases)에서 바이너리를 다운로드하고 압축을 풉니다.
2. `loader.exe`를 **관리자 권한으로 실행**하면 게임을 기다리고 있다는 창이 나타납니다.
3. 이제 실행된 상태에서 원신 또는 붕괴: 스타레일을 엽니다.
4. 게임이 열리고 모드가 로드됩니다.

### 메뉴를 어떻게 열고 닫나요?
기본적으로 메뉴 토글 키는 <kbd>INSERT</kbd>이며, 구성 파일을 수정하여 변경할 수 있습니다.

### 내 구성 파일은 어디에 저장되나요?
문서 디렉터리 내의 `genshin-utility` 폴더에 `.ini` 형식으로 저장된 구성 파일이 있습니다. 업데이트 후에는 구성 파일을 삭제하고 다시 생성해야 할 수도 있습니다.

### 원신 유틸리티 메뉴가 나타나지 않으면 어떻게 하나요?
이 문제의 가장 흔한 원인은 서드파티 오버레이입니다. MSI 애프터버너(RTSS) 또는 디스코드 게임 오버레이 같은 프로그램이 게임에 연결되어 있지 않은지 확인하세요. 이들이 도구의 메뉴와 충돌할 수 있습니다. 또 다른 가능한 원인은 런처를 통해 게임을 실행하지 않는 경우입니다. 게임 실행 파일을 직접 열면 이 프로그램이 작동하지 않습니다.

## 스크린샷

![image](https://github.com/lanylow/genshin-utility/assets/31806776/88492fe8-4016-447a-80ec-b8c4d9225cc9)

## 사용된 서드파티 라이브러리

* [imgui](https://github.com/ocornut/imgui) - C++용 그래픽 사용자 인터페이스
* [minhook](https://github.com/TsudaKageyu/minhook) - 윈도우용 API 후킹 라이브러리
* [mini](https://github.com/metayeti/mINI) - INI 파일 읽기 및 쓰기

## 라이선스

이 프로젝트는 GPL-3.0 라이선스 하에 배포됩니다 - 자세한 내용은 [LICENSE](https://github.com/lanylow/genshin-utility/blob/main/LICENSE) 파일을 참조하세요.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-03

---