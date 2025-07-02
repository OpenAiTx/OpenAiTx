# luci-app-openlist

🗂️ एक फाइल सूची कार्यक्रम जो मल्टीपल स्टोरेज को सपोर्ट करता है, Gin और Solidjs द्वारा संचालित।

## कैसे बनाएं

- `libfuse` डेवलपमेंट पैकेज इंस्टॉल करें।

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

- अपने openwrt डायरेक्टरी में जाएं

- Openwrt आधिकारिक SnapShots

  *1. golang 1.24.x या नवीनतम संस्करण की आवश्यकता है (OpenWrt की पुरानी शाखाओं के लिए बिल्ड फिक्स करें.)*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. luci-app-openlist कोड प्राप्त करें और बिल्ड करें*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # चुनें LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # luci-app-openlist को बिल्ड करें
  ```

--------------

## प्रीबिल्ट पैकेज (LuCI2) कैसे इंस्टॉल करें

- OpenWrt टर्मिनल (SSH) में लॉगिन करें

- `curl` पैकेज इंस्टॉल करें
  ```shell
  # opkg पैकेज प्रबंधक के लिए (openwrt 21.02 ~ 24.10)
  opkg update
  opkg install curl
  
  # apk पैकेज प्रबंधक के लिए
  apk update
  apk add curl
  ```

- इंस्टॉल स्क्रिप्ट चलाएं (मल्टी-आर्किटेक्चर सपोर्ट)
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  ghproxy के माध्यम से इंस्टॉल करें:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---