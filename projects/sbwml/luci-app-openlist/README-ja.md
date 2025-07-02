# luci-app-openlist

🗂️ GinとSolidjsを使用した、マルチストレージ対応のファイルリストプログラム。

## ビルド方法

- `libfuse`開発パッケージをインストールしてください。

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

- openwrtディレクトリに入る

- Openwrt公式SnapShots

  *1. golang 1.24.xまたは最新バージョンが必要です（古いOpenWrtブランチ用ビルド修正）。*
  ```shell
  rm -rf feeds/packages/lang/golang
  git clone https://github.com/sbwml/packages_lang_golang -b 24.x feeds/packages/lang/golang
  ```

  *2. luci-app-openlistコードの取得とビルド*
  ```shell
  git clone https://github.com/sbwml/luci-app-openlist package/openlist
  make menuconfig # LUCI -> Applications -> luci-app-openlist を選択
  make package/openlist/luci-app-openlist/compile V=s # luci-app-openlist をビルド
  ```

--------------

## 事前ビルドパッケージのインストール方法（LuCI2）

- OpenWrt端末にログイン（SSH）

- `curl`パッケージをインストール
  ```shell
  # opkgパッケージマネージャ用（openwrt 21.02 ~ 24.10）
  opkg update
  opkg install curl
  
  # apkパッケージマネージャ用
  apk update
  apk add curl
  ```

- インストールスクリプトを実行（マルチアーキテクチャ対応）
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)"
  ```

  ghproxy経由でインストール:
  ```shell
  sh -c "$(curl -ksS https://raw.githubusercontent.com/sbwml/luci-app-openlist/main/install.sh)" _ gh_proxy="https://gh.cooluc.com"
  ```

--------------

![luci-app-openlist](https://github.com/user-attachments/assets/50d8ee3a-e589-4285-922a-40c82f96b9f5)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---