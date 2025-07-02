# luci-app-openlist

🗂️ Un programma di elenco file che supporta più archiviazioni, basato su Gin e Solidjs.

## Come compilare

- Installa il pacchetto di sviluppo `libfuse`.

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

- Entra nella tua directory openwrt

- SnapShots ufficiali di Openwrt

  *1. richiede golang 1.24.x o versione più recente (Corregge la compilazione per i vecchi rami di OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. ottieni il codice di luci-app-openlist & compila*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # scegli LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # compila luci-app-openlist
  ```

--------------

## Come installare i pacchetti precompilati (LuCI2)

- Accedi al terminale OpenWrt (SSH)

- Installa il pacchetto `curl`
  ```shell
  # per gestore pacchetti opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # per gestore pacchetti apk
  apk update
  apk add curl
  ```

- Esegui lo script di installazione (Supporto multi-architettura)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  installa tramite ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---