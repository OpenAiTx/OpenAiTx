# luci-app-openlist

🗂️ โปรแกรมแสดงรายการไฟล์ที่รองรับหลายพื้นที่จัดเก็บ พัฒนาโดย Gin และ Solidjs

## วิธีการคอมไพล์

- ติดตั้งแพ็คเกจพัฒนา `libfuse`

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

- เข้าไปที่ไดเรกทอรี openwrt ของคุณ

- Openwrt official SnapShots

  *1. ต้องการ golang 1.24.x หรือเวอร์ชันล่าสุด (แก้ไขสำหรับ branch เก่าของ OpenWrt.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. ดาวน์โหลดโค้ด luci-app-openlist และคอมไพล์*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # เลือก LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # คอมไพล์ luci-app-openlist
  ```

--------------

## วิธีการติดตั้งแพ็คเกจที่คอมไพล์ไว้แล้ว (LuCI2)

- เข้าสู่เทอร์มินัล OpenWrt (SSH)

- ติดตั้งแพ็คเกจ `curl`
  ```shell
  # สำหรับ opkg package manager (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # สำหรับ apk package manager
  apk update
  apk add curl
  ```

- รันสคริปต์ติดตั้ง (รองรับหลายสถาปัตยกรรม)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  ติดตั้งผ่าน ghproxy:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---