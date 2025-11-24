# アノテーター

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenterで入手"/>
  </a>
</p>

![<center><b>メインウィンドウ - ライトテーマ</b></center>](https://raw.githubusercontent.com/phase1geo/Annotator/master/data/screenshots/screenshot-editor.png "Elementary OS用画像注釈")

## 概要

画像に注釈を付けて、1枚の写真で1000語を伝えましょう。

- ファイルシステム、クリップボードから画像を読み込むか、スクリーンショットを作成して注釈を付けます。
- 画像の詳細を強調するために、図形、ステッカー、画像、テキスト、描画、その他のコールアウトを追加します。
- 拡大鏡を追加して画像の詳細を強調します。
- 画像の一部をぼかしてデータを隠します。
- トリミング、リサイズ、画像の枠線を追加します。
- 色、線の太さ、フォントの詳細を制御します。
- ズーム対応。
- 読み込んだ画像内でのカラーピッカー対応。
- 変更の無制限の元に戻す/やり直し。
- 注釈付き画像のPNGコピーをドラッグアンドドロップ。
- JPEG、PNG、TIFF、BMP、PDF、SVG、WebP形式でエクスポート。
- 注釈付き画像のクリップボードへのコピー対応。
- プリンター対応。

## インストール

### Debian（ソースから）

Annotatorをビルドするには以下の依存関係が必要です：

- meson
- valac
- debhelper
- gobject-2.0
- glib-2.0
- libgee-0.8-dev
- libgranite-dev  
- libxml2-dev  
- libgtk-3-dev  
- libhandy-1-dev  
- libwebp-dev  

Annotatorをソースからインストールするには、`./app install`を実行してください。  

Annotatorを実行するには、`com.github.phase1geo.annotator`を実行してください。  

### Ubuntu (PPA)  

@PandaJimが管理する[ PPA](https://launchpad.net/~ubuntuhandbook1/+archive/ubuntu/annotator/)を使用できます。PPAはUbuntu 20.04以降をサポートしています。以下のコマンドを一つずつ入力してください。

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

さらに、AnnotatorはFlatpakを通じてインストールおよび実行できます。

ソースからFlatpakをビルドしてインストールするには、`./app flatpak`を実行してください。

その後、`flatpak run com.github.phase1geo.annotator`で実行できます。

<p align="center">
  <a href="https://appcenter.elementary.io/com.github.phase1geo.annotator">
    <img src="https://appcenter.elementary.io/badge.svg" alt="AppCenterで入手"/>
  </a>
</p>

## クレジット

[elementary/icons](https://github.com/elementary/icons/tree/main/actions/symbolic) の  
`document-edit-symbolic.svg` と `image-crop-symbolic.svg` を組み込んでおり、  
GPL v3.0ライセンスの条件のもとで提供されています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-24

---