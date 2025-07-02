# luci-app-openlist

🗂️ Программа для просмотра списка файлов с поддержкой нескольких хранилищ, основанная на Gin и Solidjs.

## Как собрать

- Установите пакет разработки `libfuse`.

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

- Перейдите в директорию openwrt

- Официальные SnapShots Openwrt

  *1. требуется golang 1.24.x или последней версии (Исправляет сборку для старых веток OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. получить код luci-app-openlist и собрать*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # выберите LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # собрать luci-app-openlist
  ```

--------------

## Как установить готовые пакеты (LuCI2)

- Войдите в терминал OpenWrt (SSH)

- Установите пакет `curl`
  ```shell
  # для менеджера пакетов opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # для менеджера пакетов apk
  apk update
  apk add curl
  ```

- Выполните скрипт установки (поддержка нескольких архитектур)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  установка через ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---