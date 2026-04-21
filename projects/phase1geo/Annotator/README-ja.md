
<div align="right">
  <details>
    <summary >🌐 言語</summary>
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

# Annotator

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenterで入手"/>
  </a>
</p>

![<center><b>メインウィンドウ - ライトテーマ</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS用画像アノテーション")

## 概要

画像に注釈をつけて、1枚の写真で1000の言葉を伝えましょう。

- ファイルシステムやクリップボードから画像を読み込み、またはスクリーンショットを作成して注釈を追加できます。
- 画像の詳細を強調するために、図形、ステッカー、画像、テキスト、描画、その他のコールアウトを追加できます。
- 画像の詳細を強調するマグニファイアを追加できます。
- データを隠すために画像の一部をぼかすことができます。
- トリミング、リサイズ、画像の枠線追加が可能です。
- 色、線の太さ、フォントの詳細をコントロールできます。
- ズーム機能に対応しています。
- 読み込んだ画像内でカラーピッカーが利用できます。
- あらゆる変更に対して無制限の元に戻す／やり直しが可能です。
- 注釈画像のPNGコピーをドラッグ＆ドロップできます。
- JPEG、PNG、TIFF、BMP、PDF、SVG、WebP画像形式へのエクスポートが可能です。
- 注釈画像をクリップボードへコピーする機能に対応しています。
- 印刷機能に対応しています。

## インストール

### Debian（ソースから）

Annotatorをビルドするには、次の依存関係が必要です：

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

ソースからAnnotatorをインストールするには、`./app install`を実行してください。

Annotator を実行するには、`com.github.phase1geo.annotator` を実行してください。

### Ubuntu (PPA)

@PandaJim によって管理されている [PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/) を使用できます。PPA は Ubuntu 20.04 以降をサポートしています。以下のコマンドを順番に入力してください。

```
sudo add-apt-repository ppa:ubuntuhandbook1/annotator
sudo apt update
sudo apt install com.github.phase1geo.annotator
```

### Arch Linux

Arch Linuxユーザーの場合は、
[AURパッケージ](https://aur.archlinux.org/packages/annotator/)
`annotator`があります：

```
% yay -S annotator
```

### Flatpak

さらに、AnnotatorはFlatpak経由でインストールおよび実行することができます。

elementary Flatpakをソースからビルドするには、`./app elementary` を実行してください。

Flathub Flatpakをソースからビルドするには、`./app flathub` を実行してください。

その後、`./app run-flatpak` にて実行できます。

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenterで入手"/>
  </a>
</p>

## クレジット

`document-edit-symbolic.svg` および `image-crop-symbolic.svg` を
[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic) より組み込んでいます。
これらはGPL v3.0ライセンスの条件下で提供されています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-21

---