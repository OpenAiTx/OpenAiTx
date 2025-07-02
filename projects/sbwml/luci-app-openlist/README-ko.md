# luci-app-openlist

🗂️ Gin과 Solidjs로 구동되는 다중 스토리지를 지원하는 파일 리스트 프로그램입니다.

## 빌드 방법

- `libfuse` 개발 패키지를 설치하세요.

  - ubuntu/debian:
    ```shell
    sudo apt update
    sudo apt install libfuse-dev
    ```

  - redhat:
    ```shell
    sudo yum install fuse-devel
    ```

  - arch:
    ```shell
    sudo pacman -S fuse2
    ```

- openwrt 디렉터리로 이동하세요

- Openwrt 공식 SnapShots

  *1. golang 1.24.x 또는 최신 버전 필요 (이전 OpenWrt 브랜치 빌드 문제 수정)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. luci-app-openlist 코드 다운로드 및 빌드*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # LUCI -> Applications -> luci-app-openlist 선택
  make package/openlist/luci-app-openlist/compile V=s # luci-app-openlist 빌드
  ```

--------------

## 미리 빌드된 패키지 설치 방법 (LuCI2)

- OpenWrt 터미널(SSH)로 로그인

- `curl` 패키지 설치
  ```shell
  # opkg 패키지 매니저용 (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # apk 패키지 매니저용
  apk update
  apk add curl
  ```

- 설치 스크립트 실행 (멀티 아키텍처 지원)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  ghproxy를 통한 설치:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---