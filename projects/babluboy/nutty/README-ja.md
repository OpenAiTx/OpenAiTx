
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=babluboy&project=nutty&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Nutty [![翻訳状況](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![ビルド状況](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap 状況](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![寄付](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
ネットワークユーティリティ

著者: Siddhartha Das

elementary OS向けに作られたシンプルなアプリケーションで、ネットワーク関連の重要な情報を提供します。情報は以下のタブとして表示されます。<br>
1. マイ情報: デバイスのネットワークカードに関する基本的かつ詳細な情報を提供します<br>
2. 使用状況: ネットワークデータ使用量を履歴と現在の2つのビューで表示します<br>
3. 速度: アップロードおよびダウンロード速度をチェックし、ホストまでのルート時間を取得します<br>
4. ポート: ローカルデバイス上でアクティブなポートとそれを使用しているアプリケーションに関する情報を提供します<br>
5. デバイス: ネットワークに接続されている他のデバイスを監視し、警告し、情報を提供します<br>

Nutty のウェブサイトで、機能、ショートカット、Ubuntu や他の対応ディストリビューション向けのインストールガイドなどの詳細を確認してください: <br>
https://babluboy.github.io/nutty/

## ソースからのビルド、テスト、およびインストール

ビルドには以下の依存関係が必要です:
* libgranite-dev
* libnotify-dev
* libxml2-dev
* libxml2-utils
* libgee-0.8-dev
* libgtk-3-dev
* libsqlite3-dev
* meson
* valac

実行には以下の依存関係が必要です:
* net-tools
* nethogs
* nmap
* traceroute
* vnstat
* curl
* wireless-tools
* iproute2
* pciutils

インストール時に vnstat が起動しない場合は、適切な init システムコマンドで vnstat デーモンを起動してください。例: `sudo systemctl enable vnstat`

`meson build` を実行してビルド環境を構成し、`ninja test` を実行してビルドします

```
git clone https://github.com/babluboy/nutty.git
cd nutty
meson build --prefix=/usr
cd build
ninja
```
インストールするには、`sudo ninja install` を使用し、その後 `com.github.babluboy.nutty` で実行します。


```
sudo ninja install
com.github.babluboy.nutty
```
アンインストールするには、ビルドディレクトリに移動して実行してください。

```
sudo ninja uninstall
```

### Debパッケージからのインストール

`.deb`パッケージからNuttyをインストールするには、Nuttyの上記の実行依存関係がすべてインストールされていることを確認してください（ビルド依存関係は不要です）。その後、以下のコマンドを実行します。
```bash
sudo dpkg -i <deb-package-name>.deb
```
`.deb` パッケージでインストールした Nutty をアンインストールするには、次のコマンドを実行してください。

```bash
sudo apt autoremove com.github.babluboy.nutty
```
もしNuttyの`.deb`パッケージを直接ビルドしたい場合は、上記のビルド依存関係をインストールしてから次を実行してください。

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