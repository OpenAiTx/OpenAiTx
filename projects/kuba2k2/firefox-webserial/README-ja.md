
# Firefox 用 WebSerial

Mozilla Firefox ブラウザ向けの WebSerial API ポリフィル

## はじめに

このアドオンは Firefox で WebSerial API を使用可能にします。

シリアルポートと通信するためにネイティブアプリケーションを使用します。

**注意:** 現時点では、このアドオンは Windows と Linux（x86-64）でのみ動作します。

## インストール

アドオンは Mozilla Addons からダウンロード可能です:
[Firefox 用 WebSerial](https://addons.mozilla.org/pl/firefox/addon/webserial-for-firefox/)。

ネイティブアプリケーションは先にコンピュータにインストールする必要があります。シリアルポートを初めて開こうとすると
GUI がネイティブアプリケーションのダウンロードを提案します。

### Windows でのインストール

.exe ファイルはインストーラーです。開いてネイティブアプリケーションをインストールしてください。

### Linux でのインストール

スクリプトを実行してください:

```sh
curl -s -L https://raw.githubusercontent.com/kuba2k2/firefox-webserial/master/native/install/linux_x86_64.sh | bash
```
#### または手動でインストールする

1. ダウンロードしたファイルを `~/.mozilla/native-messaging-hosts` に置きます
2. ファイル名を `firefox-webserial` に変更します。
3. 実行可能にします：`chmod +x ~/.mozilla/native-messaging-hosts/firefox-webserial`。
4. 同じディレクトリに `io.github.kuba2k2.webserial.json` というファイルを作成し、以下の内容を記述します：


	```json
	{
		"name": "io.github.kuba2k2.webserial",
		"description": "WebSerial for Firefox",
		"path": "/home/USER/.mozilla/native-messaging-hosts/firefox-webserial",
		"type": "stdio",
		"allowed_extensions": ["webserial@kuba2k2.github.io"]
	}
	```
	`/home/USER` を自分のユーザー名に合わせて調整してください。
5. ブラウザを再起動し、拡張機能を使用します。

**注意:** Alpine Linux（または他のmuslベースのディストリビューション）では、`gcompat` をインストールする必要があります。

## 使用法

このアドオンでFirefox上で動作する可能性のあるアプリケーション：

- [Spacehuhn Serial Terminal](https://serial.huhn.me/)
- [Google Chrome Labs Serial Terminal](https://googlechromelabs.github.io/serial-terminal/)
- [ESPWebTool by Spacehuhn](https://esp.huhn.me/)
- [ESP Tool by Espressif](https://espressif.github.io/esptool-js/)
- [ESPHome Web](https://web.esphome.io/)
- [ESP Web Tools by ESPHome](https://esphome.github.io/esp-web-tools/)
- [NinjaTerm by Geoffrey Hunter](https://ninjaterm.mbedded.ninja/)

## デバッグ

拡張機能が生成するログをデバッグ目的で表示するには：

- [about:debugging](about:debugging) を開き、`This Firefox` をクリック
- `WebSerial for Firefox` を見つけて、`Inspect` をクリック
- コンソールに次を入力：`window.wsdebug = true`
- 任意のウェブサイトに移動し、シリアルポートへの接続を試みるとコンソールに拡張機能のログが表示されます。

## ライセンス

```
MIT License

Copyright (c) 2023 Kuba Szczodrzyński

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all
copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
SOFTWARE.
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---