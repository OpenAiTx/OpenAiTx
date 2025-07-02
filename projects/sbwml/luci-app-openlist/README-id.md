# luci-app-openlist

🗂️ Program daftar file yang mendukung multi penyimpanan, didukung oleh Gin dan Solidjs.

## Cara membangun

- Instal paket pengembangan `libfuse`.

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

- Masuk ke direktori openwrt Anda

- SnapShots resmi Openwrt

  *1. membutuhkan golang 1.24.x atau versi terbaru (Memperbaiki build untuk branch lama OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. dapatkan kode luci-app-openlist & proses build*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # pilih LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # build luci-app-openlist
  ```

--------------

## Cara menginstal paket prebuilt (LuCI2)

- Masuk ke terminal OpenWrt (SSH)

- Instal paket `curl`
  ```shell
  # untuk manajer paket opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # untuk manajer paket apk
  apk update
  apk add curl
  ```

- Jalankan script instalasi (Dukungan multi-arsitektur)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  instalasi melalui ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---