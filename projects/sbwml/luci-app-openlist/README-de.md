# luci-app-openlist

🗂️ Ein Dateiliste-Programm mit Unterstützung für mehrere Speicher, basierend auf Gin und Solidjs.

## So wird gebaut

- Installieren Sie das `libfuse` Entwicklungspaket.

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

- Wechseln Sie in Ihr OpenWrt-Verzeichnis

- Offizielle OpenWrt SnapShots

  *1. benötigt golang 1.24.x oder die neueste Version (Behebt Build für ältere OpenWrt-Branches.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. luci-app-openlist Code holen & bauen*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # wähle LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # baue luci-app-openlist
  ```

--------------

## Vorgehen zur Installation von vorgebauten Paketen (LuCI2)

- Melden Sie sich am OpenWrt-Terminal an (SSH)

- Installieren Sie das `curl`-Paket
  ```shell
  # für opkg Paketmanager (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # für apk Paketmanager
  apk update
  apk add curl
  ```

- Installationsskript ausführen (Multi-Architektur-Unterstützung)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  Installation über ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---