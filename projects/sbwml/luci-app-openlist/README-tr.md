# luci-app-openlist

🗂️ Birden fazla depolamayı destekleyen, Gin ve Solidjs ile güçlendirilmiş bir dosya listeleme programı.

## Nasıl derlenir

- `libfuse` geliştirme paketini yükleyin.

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

- Openwrt dizininize girin

- Openwrt resmi SnapShot’ları

  *1. golang 1.24.x veya en son sürüm gereklidir (OpenWrt'nin eski dalları için derleme düzeltmesi).*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. luci-app-openlist kodunu alın & derleyin*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # LUCI -> Applications -> luci-app-openlist seçin
  make package/openlist/luci-app-openlist/compile V=s # luci-app-openlist'i derleyin
  ```

--------------

## Hazır paketler nasıl kurulur (LuCI2)

- OpenWrt terminaline giriş yapın (SSH)

- `curl` paketini yükleyin
  ```shell
  # opkg paket yöneticisi için (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # apk paket yöneticisi için
  apk update
  apk add curl
  ```

- Kurulum betiğini çalıştırın (Çoklu mimari desteği)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  ghproxy üzerinden kurulum:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---