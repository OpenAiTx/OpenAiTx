# Pushbullet Go

[![Chrome Web Store Version](https://img.shields.io/chrome-web-store/v/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Users](https://img.shields.io/chrome-web-store/users/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg) [![Chrome Web Store Rating](https://img.shields.io/chrome-web-store/rating/dghndapbehjdbhiffbckojkhoennbofg)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

> **注意 1**: Chrome Web Storeのポリシーにより、拡張機能名が「Push Go」に変更されました。
>
> **注意 2**: これはPushbullet APIのサードパーティ製オープンソースクライアントです。サービスとは関係がなく、推奨もされていません。

![Pushbullet Go](https://raw.githubusercontent.com/nemofq/pushbullet-go/main/screenshots/1_popup.png)

ブラウザから直接プッシュの受信および送信を可能にする、軽量なPushbullet用Chrome拡張機能です。

この拡張機能はManifest V3に対応しており、公式拡張機能が動作しなくなった代替手段となります。

[![](https://developer.chrome.com/static/docs/webstore/branding/image/UV4C4ybeBTsZt43U4xis.png)](https://chromewebstore.google.com/detail/push-go-for-pushbullet/dghndapbehjdbhiffbckojkhoennbofg)

## 機能

[Pushbullet](https://www.pushbullet.com/)アカウントが必要です。機能は以下の通りです:

- プッシュの受信および送信
- 貼り付け、ドラッグ、アップロードによるファイル/画像のプッシュ（Chromeの制限により単独ウィンドウで）
- コンテキストメニューから現在のページのURL、選択テキスト、画像をデバイスや人を選択してプッシュ
- プッシュ先デバイスを選択して制御
- 受信プッシュの通知とリンクを開く・閉じるボタン付き
- 受信したリンクを新しいタブで自動的に開く（デフォルトはオフ、オプションページで有効化可能）
- 最新100件のプッシュをローカルに保存（完全な履歴はPushbulletウェブサイトで確認可能）
- （新機能）ターゲットデバイス別にプッシュを表示・通知をフィルタリング
- （新機能）ブラウザ発のプッシュ通知の制御（複数ブラウザ利用時に便利）
- （新機能）通知ミラーリング（Pushbullet Androidアプリをインストールし、AndroidアプリとPush Go設定の両方で有効にする必要あり）
- （新機能）ダークモード（デフォルトはシステムに従う、手動選択も可能）
- （新機能）33言語に対応したi18n
- （新機能）未読カウント
- （新機能）ポップアップで現在のタブのリンクを素早く共有（デフォルトはオフ、オプションページで有効化可能）
- （新機能）通知時に音を再生（オプションページで無効化可能）
- （新機能）通知ミラーリングのエンドツーエンド暗号化
- （新機能）ミラー通知から認証コードを抽出（ポップアップでクリックしてコピー可能）

## インストール
> **注意 3**: PushbulletのWebSocketサーバーへの接続を維持するために `chrome.idle` API を使用するため、Chrome 116以降が必要です。
### 推奨

直接 [Chrome ウェブストア](https://chromewebstore.google.com/detail/push-go/dghndapbehjdbhiffbckojkhoennbofg) からインストールするか、または：

### 手動

1. `release/` フォルダから拡張機能をダウンロードして解凍します
2. Chrome を開いて `chrome://extensions/` に移動します
3. 右上の「デベロッパーモード」を有効にします
4. 「パッケージ化されていない拡張機能を読み込む」をクリックし、解凍した `/src` フォルダを選択します

## セットアップ

1. 拡張機能アイコンをクリックして「設定を開く」を選択します
2. OAuth 認証または手動でアクセス トークンを入力します（[Pushbullet 設定](https://www.pushbullet.com/#settings/account)から取得可能）
3. 取得ボタンをクリックして、プッシュの送受信を開始します！
4. 必要に応じてオプションページで設定をカスタマイズします

## 権限

この拡張機能には以下の権限が必要です：
- **ストレージ**：オプションとプッシュ履歴をローカルに保存するため
- **アイドル**：リアルタイムでプッシュを受信するための接続維持に使用
- **通知**：プッシュ通知を表示するため
- **コンテキストメニュー**：コンテンツをプッシュするための右クリックメニューを追加
- **アクティブタブ**：コンテキストメニューやキーボードショートカットのために現在のページの URL とタイトルにアクセス
- **ホストアクセス**：Pushbullet API サーバーと通信するため
- **オフスクリーン**：通知音を再生するため
- **アイデンティティ**：OAuth プロセスを完了するため

## プライバシー

この拡張機能はすべてをローカルに保存し、Pushbullet の API 以外には情報を送信しません。

## ライセンス

このプロジェクトは [AGPL-3.0 ライセンス](https://github.com/nemofq/pushbullet-go?tab=AGPL-3.0-1-ov-file) を使用しています。機能のリクエストやフィードバックがあれば、Issue またはプルリクエストを作成してください。

## もうひとつのこと


もしあなたもiOSとPushbulletのユーザーであれば、これらのショートカットが役立つかもしれません：

- [Push to Pushbullet](https://www.icloud.com/shortcuts/5549bbb5b06e4f0a8ccb1b6fd33e853f)
- [Pushbullet Receiver](https://www.icloud.com/shortcuts/1f94913de21b41debe60ef43631afde2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---