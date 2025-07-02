# luci-app-openlist

🗂️ Một chương trình liệt kê tập tin hỗ trợ nhiều lưu trữ, được phát triển bởi Gin và Solidjs.

## Hướng dẫn biên dịch

- Cài đặt gói phát triển `libfuse`.

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

- Truy cập vào thư mục openwrt của bạn

- SnapShots chính thức của Openwrt

  *1. yêu cầu golang 1.24.x hoặc phiên bản mới nhất (Khắc phục lỗi biên dịch cho các nhánh OpenWrt cũ hơn.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. lấy mã nguồn luci-app-openlist & biên dịch*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # chọn LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # biên dịch luci-app-openlist
  ```

--------------

## Hướng dẫn cài đặt gói dựng sẵn (LuCI2)

- Đăng nhập terminal OpenWrt (SSH)

- Cài đặt gói `curl`
  ```shell
  # dành cho trình quản lý gói opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # dành cho trình quản lý gói apk
  apk update
  apk add curl
  ```

- Thực thi script cài đặt (Hỗ trợ đa kiến trúc)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  cài đặt thông qua ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---