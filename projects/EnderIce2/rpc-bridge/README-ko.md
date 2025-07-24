
# Wine용 Discord RPC 브리지

![GitHub License](https://img.shields.io/github/license/EnderIce2/rpc-bridge?style=for-the-badge)
![GitHub Downloads (all assets, all releases)](https://img.shields.io/github/downloads/EnderIce2/rpc-bridge/total?style=for-the-badge)
![GitHub Release](https://img.shields.io/github/v/release/EnderIce2/rpc-bridge?style=for-the-badge)

Wine 게임/소프트웨어에서 Discord 리치 프레즌스를 사용할 수 있게 해주는 간단한 브리지입니다.

이 브리지는 프리픽스 내부에 [명명된 파이프](https://learn.microsoft.com/en-us/windows/win32/ipc/named-pipes) `\\.\pipe\discord-ipc-0`를 생성하고 모든 데이터를 파이프 `/run/user/1000/discord-ipc-0`로 전달하는 작은 프로그램을 백그라운드에서 실행하여 작동합니다.

이 브리지는 Wine의 윈도우 서비스 구현을 활용하여 수동으로 프로그램을 실행할 필요를 제거합니다.

---

## 설치 및 사용법

설치하면 `C:\windows\bridge.exe`에 복사되고 윈도우 서비스가 생성됩니다.  
로그는 `C:\windows\logs\bridge.log`에 저장됩니다.

#### 프리픽스 내 설치하기

##### Wine (~/.wine)

- `bridge.exe`를 더블 클릭하고 `Install`을 클릭합니다.
    - ![gui](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/gui.png)
- 제거하려면 같은 과정을 따라 `Remove`를 클릭하면 됩니다.

*참고로 MacOS에서는 [추가 단계](https://github.com/EnderIce2/rpc-bridge?tab=readme-ov-file#macos)가 필요합니다*

##### Lutris

- 게임을 클릭하고 `Run EXE inside Wine prefix`를 선택합니다.
    - ![lutris](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/lutris.png)
- Wine과 동일한 과정을 따를 수 있습니다.

##### Steam

- 게임을 우클릭하고 `속성`을 선택합니다.
- `시작 옵션 설정`에 다음을 추가합니다:
    - ![bridge.sh](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/steam_script.png "시작 옵션에 bridge.sh 경로 설정")
- `bridge.sh` 스크립트는 `bridge.exe`와 같은 디렉토리에 있어야 합니다.

#### Flatpak을 사용하는 경우

- Steam, Lutris 등을 Flatpak에서 실행 중이라면 브리지가 `/run/user/1000/discord-ipc-0` 파일에 접근할 수 있도록 허용해야 합니다.
	- ##### [Flatseal](https://flathub.org/apps/details/com.github.tchx84.Flatseal) 사용 시
		- `Filesystems` 카테고리에 `xdg-run/discord-ipc-0` 추가
			- ![flatseal](https://raw.githubusercontent.com/EnderIce2/rpc-bridge/master/docs/assets/flatseal_permission.png)
	- ##### 터미널 사용 시
		- 앱별로
			- `flatpak override --filesystem=xdg-run/discord-ipc-0 <flatpak 앱 이름>`
		- 전역 설정
			- `flatpak override --user --filesystem=xdg-run/discord-ipc-0`

##### MacOS

MacOS의 경우 단계는 거의 동일하지만 `$TMPDIR` 작동 방식 때문에 **LaunchAgent**를 설치해야 합니다.

- [릴리즈](https://github.com/EnderIce2/rpc-bridge/releases)에서 최신 빌드를 다운로드합니다.
- 압축을 풀고 `launchd.sh` 스크립트에 실행 권한을 부여합니다: `chmod +x launchd.sh`
- LaunchAgent를 **설치**하려면 `./launchd.sh install`을 실행하고, **제거**하려면 `./launchd.sh remove`를 실행합니다.

스크립트는 사용자에게 LaunchAgent를 추가하며, `$TMPDIR` 디렉토리를 `/tmp/rpc-bridge/tmpdir`로 심볼릭 링크합니다.

*참고: `bridge.exe` 파일을 Wine에서 최소 한 번 수동으로 실행해야 등록되어 다음부터 자동으로 실행됩니다.*

LaunchAgent 설치 방법에 대한 자세한 내용은 [문서](https://enderice2.github.io/rpc-bridge/)에서 확인할 수 있습니다.

## 소스에서 컴파일하기

- `wine`, `gcc-mingw-w64` 및 `make` 패키지를 설치합니다.
- 이 파일이 있는 디렉토리에서 터미널을 열고 `make`를 실행합니다.
- 컴파일된 실행 파일은 `build/bridge.exe`에 위치합니다.

## 제작자

이 프로젝트는 [wine-discord-ipc-bridge](https://github.com/0e4ef622/wine-discord-ipc-bridge)에서 영감을 받았습니다.

---



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---