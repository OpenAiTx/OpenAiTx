# 廃止予定
この拡張機能は廃止されましたが、代わりに新しい拡張機能Smart Homeがリリースされています。https://github.com/vchlum/smart-home にアクセスしてください。

# hue-lights
![スクリーンショット](https://github.com/vchlum/hue-lights/blob/main/screenshot.png)

## Gnome Shell拡張機能
hue-lightsは、ローカルネットワーク上のPhilips Hue Bridgeで制御されるPhilips Hueライト用のGnome Shell拡張機能です。拡張機能はライトをゾーンや部屋にグループ化します。状態、明るさ、色や色温度の制御が可能です。シーンはゾーンや部屋ごとにアクティブ化できます。複数のブリッジの制御も可能です。通知時に点滅するライトの設定も可能です。

## Philips Hueエンターテインメントエリア
この拡張機能はエンターテインメントエリアをサポートしています。スマートフォンの公式アプリを使ってエンターテインメントエリアを作成できます。その後、画面とライトの同期を開始できます。同期機能にはブリッジペアリングで生成された特別なキーが必要です。バージョン8以前からアップグレードする場合は、Philips Hueブリッジの削除と再接続が必要です。ブリッジは最新の状態に保ってください。この機能はAPIバージョン1.22以降を必要とします。

## Philips Hue HDMI同期ボックスのサポート
この拡張機能はローカルネットワーク上のPhilips Hue HDMI同期ボックスの制御を可能にします。同期の有効/無効切り替え、モード変更、強度変更、明るさ調整、エンターテインメントエリアの選択、HDMI入力の選択が可能です。

## トラブルシューティング
 1. アップグレードで問題が発生した場合は、一度ログアウトして再ログインしてください。
 1. 問題が解決しない場合は、gnomeのキー「/org/gnome/shell/extensions/hue-lights/」をリセットしてこの拡張機能をリセットしてください。
    * `dconf reset -f /org/gnome/shell/extensions/hue-lights/` を呼び出すか、`dconf-editor` を使用できます。
 1. 問題が解決しない場合はGitHubで問題を報告してください。可能であれば設定でデバッグモードを有効にし、ログファイルを添付してください。
    * ログファイルは次のように取得できます: `journalctl -f /usr/bin/gnome-shell 2>&1 | grep -i hue > hue-lights.log`。

## 警告
このアプリケーションは、単独または画面上の特定のコンテンツと組み合わせて急激に変化するライト効果を使用します。これにより、これまでに発作やてんかんの既往歴がない人でも未検出のてんかん症状や発作を引き起こす可能性があります。

## 対応Gnome Shellバージョン
この拡張機能はGnome Shellバージョン45以上をサポートしています。

## e.g.oからのインストール
https://extensions.gnome.org/extension/3737/hue-lights

## 手動インストール

 1. `git clone https://github.com/vchlum/hue-lights.git`
 1. `cd hue-lights`
 1. `make build`
 1. `make install`
 1. ログアウトしてログイン
 1. `gnome-extensions enable hue-lights@chlumskyvaclav.gmail.com`

## 依存関係のインストール
  - これはソースからインストールする場合のみ必要です
  - `make`
  - `gnome-shell` （`gnome-extensions`コマンド）
  - `glib-compile-resources`
  - `libglib2.0-dev-bin`
  - `gettext`
  - 拡張機能を動作させるために推奨されるもの
  - `avahi-tools` （ローカルネットワーク上のデバイス検出用の`avahi-browse`コマンド）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---