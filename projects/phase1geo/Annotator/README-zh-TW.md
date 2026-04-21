<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=phase1geo&project=Annotator&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# 標註工具

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="在 AppCenter 取得"/>
  </a>
</p>


![<center><b>主視窗 - 淺色主題</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Image Annotation for Elementary OS")

## 概覽

為您的圖片加註解，讓一張圖片勝過千言萬語。

- 從檔案系統、剪貼簿載入圖片，或建立截圖以標註。
- 新增形狀、貼紙、圖片、文字、繪圖及其他標註，突顯圖片細節。
- 加入放大鏡以強調圖片細節。
- 模糊圖片部分區域以隱藏資料。
- 裁剪、調整大小並加入圖片邊框。
- 控制顏色、線條粗細與字體細節。
- 支援縮放功能。
- 在已載入圖片內支援取色器。
- 任何變更皆可無限次復原/重做。
- 可拖曳標註後的圖片以 PNG 格式複製。
- 匯出為 JPEG、PNG、TIFF、BMP、PDF、SVG 及 WebP 等圖片格式。
- 支援將標註圖片複製到剪貼簿。
- 支援列印功能。

## 安裝

### Debian（從原始碼）

您需要以下相依套件才能編譯 Annotator：

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-7-dev
- libgtk-4-dev
- libxml2-dev
- libarchive-dev
- libwebp-dev

要從原始碼安裝 Annotator，請執行 `./app install`。

要執行 Annotator，請運行 `com.github.phase1geo.annotator`。

### Ubuntu（PPA）

你可以使用由 @PandaJim 維護的 [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/)。此 PPA 支援 Ubuntu 20.04+。請依次輸入以下指令

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

如果你是 Arch Linux 使用者，可以使用
[AUR 軟體包](https://aur.archlinux.org/packages/annotator/)
`annotator`：

```
% yay -S annotator
```

### Flatpak

此外，Annotator 也可以透過 Flatpak 安裝並執行。

要從原始碼建置 elementary Flatpak，請執行 `./app elementary`。

要從原始碼建置 Flathub Flatpak，請執行 `./app flathub`。

之後，您可以透過：`./app run-flatpak` 執行它。

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="Get it on AppCenter"/>
  </a>
</p>

## 致謝

本程式包含來自
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic)
的 `document-edit-symbolic.svg` 及 `image-crop-symbolic.svg`，
依據 GPL v3.0 授權條款使用。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---