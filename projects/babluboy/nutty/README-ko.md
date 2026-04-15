# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
네트워크 유틸리티

작성자: Siddhartha Das

elementary OS용으로 만들어진 간단한 애플리케이션으로 네트워크 관련 필수 정보를 제공합니다. 정보는 다음 탭으로 제시됩니다.<br>
1. 내 정보: 장치 네트워크 카드에 대한 기본 및 상세 정보를 제공합니다<br>
2. 사용량: 네트워크 데이터 사용량을 두 가지 뷰로 제공합니다 - 과거 사용량과 현재 사용량<br>
3. 속도: 업로드 및 다운로드 속도를 확인하고 호스트까지의 경로 시간을 얻습니다<br>
4. 포트: 로컬 장치에서 활성 포트 및 이를 사용하는 애플리케이션 정보를 제공합니다<br>
5. 장치: 네트워크에 연결된 다른 장치를 모니터링하고 알림을 제공하며 정보를 제공합니다<br>

기능, 단축키, 우분투 및 기타 지원 배포판 설치 가이드 등 자세한 내용은 Nutty 웹사이트를 확인하세요 : <br>
https://babluboy.github.io/nutty/

## 소스에서 빌드, 테스트 및 설치

빌드하려면 다음 의존성이 필요합니다:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

실행하려면 다음 의존성이 필요합니다:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

가끔 vnstat가 설치 후 시작되지 않는 경우가 있으니, 적절한 init 시스템 명령어를 사용하여 vnstat 데몬을 시작하세요. 예: `sudo systemctl enable vnstat`
`meson build`를 실행하여 빌드 환경을 구성하고 `ninja test`를 실행하여 빌드하세요


```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
설치하려면 `sudo ninja install`을 사용한 후, `com.github.babluboy.nutty`로 실행하십시오.


```
sudo ninja install
com.github.babluboy.nutty
```
제거하려면 빌드 디렉터리로 이동하여 실행하십시오.

```
sudo ninja uninstall
```
### Deb 패키지에서 설치하기

`.deb` 패키지에서 Nutty를 설치하려면 위에 나열된 Nutty 실행에 필요한 모든 종속 항목이 설치되어 있는지 확인하세요 (빌드 종속 항목은 필요 없음). 그런 다음 아래 명령어를 실행하세요

```bash
sudo dpkg -i <deb-package-name>.deb
```

그리고 `.deb` 패키지를 통해 설치된 Nutty를 제거하려면 실행하세요
```bash
sudo apt autoremove com.github.babluboy.nutty
```
만약 Nutty의 `.deb` 패키지를 직접 빌드하고 싶다면 위의 빌드 종속성을 설치한 후 실행하세요

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---