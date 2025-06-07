# wechat2tg-mac

WeChat Mac プロトコルをベースに、Telegram で WeChat メッセージの送受信を実現します。wx2tg-server サーバーサイドはセキュリティ上の理由からソース非公開です。

## TG グループ: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## 主な機能

1. WeChat 個別チャットメッセージ、グループチャットメッセージ、公式アカウントメッセージの受信、WeCom（企業微信）メッセージの受信
2. Telegram から指定した WeChat ユーザー、グループチャット、公式アカウントへのメッセージ送信
3. 指定したグループのメッセージをミュート

## サポートされるメッセージタイプ

### WeChat メッセージタイプ対応リスト

+ [x] テキストメッセージ
+ [x] 企業微信メッセージ
+ [x] WeChat スタンプ
+ [x] 画像メッセージ
+ [x] 動画メッセージ
+ [x] 音声/ビデオ通話（通知のみ）
+ [x] ファイルメッセージ
+ [x] リンクメッセージ
+ [x] グループチャットメッセージ
+ [x] グループチャット @ メッセージ（@全員および@あなた は Telegram の@あなた に変換）
+ [x] 公式アカウントメッセージ
+ [x] emoji
+ [x] 位置情報メッセージ
+ [x] メッセージの撤回
+ [x] 音声メッセージ
+ [ ] 紅包メッセージ（通知のみ、内容取得不可）
+ [ ] ミニプログラムメッセージ

### Telegram メッセージタイプ対応リスト

+ [x] テキストメッセージ
+ [x] ステッカー
+ [x] 画像メッセージ
+ [x] 動画メッセージ
+ [x] ファイルメッセージ
+ [x] ボイスメッセージ

## 注意事項

1. 本プロジェクトは技術研究と学習の目的のみに使用してください。不正な用途での利用は禁止です。
2. 問題が発生した場合は issue の提出を歓迎します。

## デプロイ・インストール

まず `.env.example` をコピーして `.env` ファイルを作成し、`.env` ファイルの環境変数を設定してください。

プロジェクト内の `app.conf.example` を `app.conf` ファイルとして `conf` ディレクトリにコピーし、Redis のアドレスを自身がデプロイした Redis のアドレスに設定してください。

### docker-compose

`docker-compose.yml` ファイルを作成します：

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # 保存フォルダをマウントするとステッカーファイルの再変換不要
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # イメージ取得
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### 起動

```shell
docker-compose up -d
```

#### bot のプライバシーモードをオフにする

Bot のプライバシーモードをオフにします。BotFather を開き `/mybots` を入力し、ボットを選択。「Bot Settings」-「Group Privacy」-「Turn off」をクリック。
「Privacy mode is disabled for xxx」と表示されれば成功です。

## 使い方

### BOT コマンド

- `/login`：ログイン用 QR コード取得。初回デプロイ時に最初に `/login` コマンドを送った人が BOT の所有者になります。

- `/flogin`：ファイル転送アシスタントログイン用 QR コード取得。動画やファイルの受信に対応。

- `/update`：グループのアイコンとニックネーム情報を更新。

- `/message`：グループメッセージの受信 ON/OFF。

- `/forward`：グループ内の他ユーザーや bot のメッセージ転送の ON/OFF。

- `/user`：WeChat ユーザーリスト取得。ボタンをクリックすると新グループの作成やユーザーの紐付けが可能（名前や備考で検索可能、例： `/user 張` で「張」を含むユーザーを検索）。

- `/room`：WeChat グループリスト取得。ボタンをクリックすると新グループの作成やグループの紐付けが可能（名前や備考で検索可能、例： `/room 外卖` で「外卖」を含むグループを検索）。

- `/settings`：プログラム設定

- `/unbind`：WeChat グループまたはユーザーの紐付け解除（グループ内のみ利用可能）

### 環境変数の説明

|名前| 必須 | 説明                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| はい    | Telegram Bot の token。 [BotFather](https://t.me/BotFather) で作成         |
|`API_ID`| はい    | Telegram API の API ID                                          |
|`API_HASH`| はい    | Telegram API の API HASH                                        |
|`BASE_API`| はい    | wx2tg-server コンテナの API リクエストアドレス。フルパスで記載すること           | |
|`PROXY_PROTOCOL`| いいえ    | プロキシ種別（socks5, http, https）                                      |
|`PROXY_HOST`| いいえ    | プロキシの URL                                                        |
|`PROXY_PORT`| いいえ    | プロキシのポート番号                                                        |
|`PROXY_USERNAME`| いいえ    | プロキシのユーザー名                                                       |
|`PROXY_PASSWORD`| いいえ    | プロキシのパスワード                                                       |
|`ROOM_MESSAGE`| いいえ    | BOT での WeChat グループメッセージ表示形式                                 |
|`OFFICIAL_MESSAGE`| いいえ    | BOT での公式アカウントメッセージ表示形式                                 |
|`CONTACT_MESSAGE`| いいえ    | BOT での WeChat ユーザーメッセージ表示形式                                 |
|`ROOM_MESSAGE_GROUP`| いいえ    | グループでの WeChat グループメッセージ表示形式                              |
|`CONTACT_MESSAGE_GROUP`| いいえ    | グループでの WeChat ユーザーメッセージ表示形式                              |
|`OFFICIAL_MESSAGE_GROUP`| いいえ    | グループでの公式アカウントメッセージ表示形式                                 |
|`CREATE_ROOM_NAME`| いいえ    | WeChat グループのグループ自動作成時のグループ名フォーマット                    |
|`CREATE_CONTACT_NAME`| いいえ    | WeChat 連絡先のグループ自動作成時のグループ名フォーマット                     |
|`MESSAGE_DISPLAY`| いいえ    | テキストメッセージの表示形式                                               |

 ---

### 設定項目 `/settings` コマンドの説明

1. WeChat emoji を画像リンクで表示：オンにすると友達から送られた絵文字（小黄人）が画像リンクで表示されます

1. 起動時にグループ情報を同期：オンにするとプログラム起動時に全員の情報を同期し、グループのアイコンと名前を更新します

---

### 音声からテキストへの変換

1. `TENCENT_SECRET_ID` と `TENCENT_SECRET_KEY` を設定します。Tencent [音声認識コンソール](https://console.cloud.tencent.com/asr)で開通可能。無料枠あり。
2. `/settings` で自動音声テキスト変換機能を有効にします。

---

### `API_ID` と `API_HASH` の取得方法

1. [telegram account](https://my.telegram.org/) にログイン

2. 「API development tools」をクリックし、アプリケーション詳細を入力（タイトルと略称のみで可）

3. 最後に「Create application」をクリック

---

### カスタムメッセージテンプレート

送信者のフォーマットを変更したい場合は、docker の環境変数または `.env` ファイルを修正してください。

カスタムメッセージテンプレートのプレースホルダー：

`#[alias]`：連絡先の備考

`#[name]`：連絡先のニックネーム

`#[topic]`：グループチャットのニックネーム

`#[alias_first]`：備考優先。なければ連絡先のニックネームを表示

`#[identity]`：身分情報テキスト

`#[body]`：メッセージ本文

`#[br]`：改行

### @全員 する方法

`@all` で始まるメッセージを送信すると、@全員 になります。テキストメッセージのみ対応。

---

## よくある質問


## 開発参加

1. プロジェクトを fork し、`wx2tg-mac-dev` ブランチに切り替えるか、新しいブランチを作成してください。メインブランチへの直接コミットは禁止です。
2. `wx2tg-mac-dev` ブランチへ Pull Request を送ってください。

## License

[MIT](LICENSE)

## Thanks

本プロジェクトへの Jetbrains のご支援に感謝いたします

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---