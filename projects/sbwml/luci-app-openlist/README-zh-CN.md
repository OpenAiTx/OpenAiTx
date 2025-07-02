# luci-app-openlist

🗂️ 一个支持多存储的文件列表程序，由 Gin 和 Solidjs 提供支持。

## 如何编译

- 安装 `libfuse` 开发包。

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

- 进入你的 openwrt 目录

- Openwrt 官方 SnapShots

  *1. 需要 golang 1.24.x 或最新版本（修复旧版 OpenWrt 分支的编译问题。）*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. 获取 luci-app-openlist 代码并编译*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # 选择 LUCI -> Applications -> luci-app-openlist
  make package/openlist/luci-app-openlist/compile V=s # 编译 luci-app-openlist
  ```

--------------

## 如何安装预编译包（LuCI2）

- 登录 OpenWrt 终端（SSH）

- 安装 `curl` 包
  ```shell
  # 适用于 opkg 包管理器（openwrt 21.02 ~ 24.10）
  opkg update
  opkg install curl
  
  # 适用于 apk 包管理器
  apk update
  apk add curl
  ```

- 执行安装脚本（多架构支持）
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  通过 ghproxy 安装：
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---