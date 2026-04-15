# Nutty [![Translation status](https://hosted.weblate.org/widgets/nutty/-/svg-badge.svg)](https://hosted.weblate.org/engage/nutty/?utm_source=widget) [![Build Status](https://travis-ci.org/babluboy/nutty.svg?branch=master)](https://travis-ci.org/babluboy/nutty) [![Snap Status](https://build.snapcraft.io/badge/babluboy/nutty.svg)](https://build.snapcraft.io/user/babluboy/nutty) [![Donate](https://img.shields.io/badge/Donate-PayPal-green.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=FZP8GK839VGQC)
ネットワークユーティリティ

著者: Siddhartha Das

elementary OS向けに作られたシンプルなアプリケーションで、ネットワーク関連の基本情報を提供します。情報は以下のタブで表示されます。<br>
1. My Info: デバイスのネットワークカードの基本および詳細情報を提供<br>
2. Usage: ネットワークデータ使用量を2つのビューで表示 - 過去の使用量と現在の使用量<br>
3. Speed: アップロードおよびダウンロード速度をチェックし、ホストへのルート時間を取得<br>
4. Ports: ローカルデバイス上のアクティブなポートとそれを使用しているアプリケーションの情報を提供<br>
5. Devices: ネットワークに接続されている他のデバイスを監視し、アラートを出し、情報を提供<br>

Nuttyのウェブサイトで機能、ショートカット、Ubuntuおよび他の対応ディストリビューションのインストールガイドなどの詳細を確認してください。:<br>
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

インストール時にvnstatが起動しないことがあります。その場合は適切なinitシステムのコマンドを使ってvnstatデーモンを起動してください。例: `sudo systemctl enable vnstat`

ビルド環境を設定するには `meson build` を実行し、ビルドを行うには `ninja test` を実行してください

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-15

---