# luci-app-openlist

🗂️ برنامج قائمة الملفات يدعم تعدد التخزين، يعمل بواسطة Gin وSolidjs.

## كيفية البناء

- تثبيت حزمة تطوير `libfuse`.

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

- ادخل إلى دليل openwrt الخاص بك

- SnapShots الرسمية لـ Openwrt

  *1. يتطلب golang 1.24.x أو أحدث إصدار (إصلاح البناء لفروع OpenWrt القديمة.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. الحصول على كود luci-app-openlist والبناء*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # اختر LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # بناء luci-app-openlist
  ```

--------------

## كيفية تثبيت الحزم الجاهزة (LuCI2)

- تسجيل الدخول إلى طرفية OpenWrt (SSH)

- تثبيت حزمة `curl`
  ```shell
  # لمدير الحزم opkg (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # لمدير الحزم apk
  apk update
  apk add curl
  ```

- تنفيذ برنامج التثبيت (دعم تعدد المعماريات)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  التثبيت عبر ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---