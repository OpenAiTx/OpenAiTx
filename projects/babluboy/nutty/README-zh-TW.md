<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">阿薩姆語</
      </div>
    </div>
  </details>
</div>

# Nutty [![翻譯狀態](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![建置狀態](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap 狀態](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![捐贈](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
網路工具程式

作者：Siddhartha Das

這是一個為 elementary OS 開發的簡單應用程式，用於提供網路相關的基本資訊。所呈現的資訊分為下列標籤頁。<br>
1. 我的資訊：提供裝置網路卡的基本與詳細資訊<br>
2. 使用量：以兩種視圖提供網路數據使用量－歷史使用量與目前使用量<br>

3. 速度：檢查上傳和下載速度，並獲取到主機的路由時間<br>
4. 埠：提供本地設備上使用中埠口及其應用程式的資訊<br>
5. 裝置：監控、警告並提供連接到網路上其他裝置的資訊<br>

請參閱 Nutty 官方網站以獲得功能、快捷鍵、Ubuntu 及其他支援發行版的安裝指南等詳細資訊：<br>
https://babluboy.github.io/nutty/

## 從原始碼建置、測試及安裝

建置時您需要以下相依套件：
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

執行時需要以下相依套件：
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

有時 vnstat 安裝後未啟動，請使用適當的 init 系統命令啟動 vnstat 服務，例如 `sudo systemctl enable vnstat`

執行 `meson build` 以設定建置環境，並執行 `ninja test` 進行建置

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
要安裝，請使用 `sudo ninja install`，然後以 `com.github.babluboy.nutty` 執行


```
sudo ninja install
com.github.babluboy.nutty
```
要解除安裝，請前往 build 目錄並執行

```
sudo ninja uninstall
```

### 從 Deb 套件安裝

要從 `.deb` 套件安裝 Nutty，請確保您已安裝上述所有執行期相依套件（不需要建置相依套件）。然後執行以下指令
```bash
sudo dpkg -i <deb-package-name>.deb
```

若要卸載透過 `.deb` 套件安裝的 Nutty，請執行
```bash
sudo apt autoremove com.github.babluboy.nutty
```
如果你想要自行直接建構 Nutty 的 `.deb` 軟體包，請安裝上述的建構相依套件，然後執行

```bash
git clone https://github.com/babluboy/nutty.git
cd nutty
dpkg-buildpackage -us -uc
cd ..
```


## Screenshot

![screenshot](https://raw.githubusercontent.com/babluboy/nutty/gh-pages/images/Nutty_Device_Alert.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---