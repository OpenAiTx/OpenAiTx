# luci-app-openlist

🗂️ Een bestandslijstprogramma dat meerdere opslagmedia ondersteunt, aangedreven door Gin en Solidjs.

## Hoe te bouwen

- Installeer het `libfuse` ontwikkelpakket.

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

- Ga naar je openwrt-map

- Officiële Openwrt SnapShots

  *1. vereist golang 1.24.x of nieuwste versie (Fix build voor oudere takken van OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. haal luci-app-openlist code op & bouwen*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # kies LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # bouw luci-app-openlist
  ```

--------------

## Hoe vooraf gebouwde pakketten te installeren (LuCI2)

- Log in op de OpenWrt terminal (SSH)

- Installeer het `curl` pakket
  ```shell
  # voor opkg pakketbeheerder (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # voor apk pakketbeheerder
  apk update
  apk add curl
  ```

- Voer het installatiescript uit (Multi-architectuur ondersteuning)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  installatie via ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---