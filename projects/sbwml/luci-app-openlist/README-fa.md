# luci-app-openlist

🗂️ یک برنامه فهرست فایل که از چندین فضای ذخیره‌سازی پشتیبانی می‌کند، مبتنی بر Gin و Solidjs.

## نحوه ساخت (Build)

- بسته توسعه‌ای `libfuse` را نصب کنید.

  - اوبونتو/دبیان:
    ```shell
    sudo apt update
    sudo apt install libfuse-dev
    ```

  - ردهت:
    ```shell
    sudo yum install fuse-devel
    ```

  - آرچ:
    ```shell
    sudo pacman -S fuse2
    ```

- وارد دایرکتوری openwrt خود شوید

- SnapShots رسمی Openwrt

  *1. نیازمند golang نسخه 1.24.x یا جدیدتر (رفع مشکل build برای شاخه‌های قدیمی‌تر OpenWrt)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. دریافت کد luci-app-openlist و ساختن آن*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # انتخاب LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # ساخت luci-app-openlist
  ```

--------------

## نحوه نصب بسته‌های پیش‌ساخته (LuCI2)

- ورود به ترمینال OpenWrt (از طریق SSH)

- نصب بسته `curl`
  ```shell
  # برای مدیر بسته opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # برای مدیر بسته apk
  apk update
  apk add curl
  ```

- اجرای اسکریپت نصب (پشتیبانی از چند معماری)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  نصب از طریق ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---