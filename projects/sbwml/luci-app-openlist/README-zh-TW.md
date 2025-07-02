# luci-app-openlist

🗂️ 一個支援多儲存設備的檔案列表程式，由 Gin 和 Solidjs 驅動。

## 如何編譯

- 安裝 `libfuse` 開發套件。

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

- 進入你的 openwrt 目錄

- Openwrt 官方 SnapShots

  *1. 需要 golang 1.24.x 或最新版本（修復舊分支 OpenWrt 的編譯問題）*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. 取得 luci-app-openlist 代碼並編譯*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # 選擇 LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # 編譯 luci-app-openlist
  ```

--------------

## 如何安裝預編譯套件（LuCI2）

- 登入 OpenWrt 終端機（SSH）

- 安裝 `curl` 套件
  ```shell
  # 適用於 opkg 套件管理器（openwrt 21.02 ~ 24.10）
  opkg update
  opkg install curl
  
  # 適用於 apk 套件管理器
  apk update
  apk add curl
  ```

- 執行安裝腳本（多架構支援）
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  透過 ghproxy 安裝：
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---