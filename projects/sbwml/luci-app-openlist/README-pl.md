# luci-app-openlist

🗂️ Program do listy plików obsługujący wiele magazynów, oparty na Gin i Solidjs.

## Jak zbudować

- Zainstaluj pakiet developerski `libfuse`.

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

- Przejdź do katalogu openwrt

- Oficjalne SnapShoty Openwrt

  *1. wymagana golang 1.24.x lub najnowsza wersja (Popraw kompilację dla starszych gałęzi OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. pobierz kod luci-app-openlist i buduj*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # wybierz LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # buduj luci-app-openlist
  ```

--------------

## Jak zainstalować gotowe pakiety (LuCI2)

- Zaloguj się do terminala OpenWrt (SSH)

- Zainstaluj pakiet `curl`
  ```shell
  # dla menedżera pakietów opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # dla menedżera pakietów apk
  apk update
  apk add curl
  ```

- Wykonaj skrypt instalacyjny (Wsparcie wielu architektur)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  instalacja przez ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---