# 🚄 China Railway Ticket Monitor

12306の空きチケットを簡潔かつ効率的に監視するツールで、空きが出た場合に複数の方法で通知をプッシュできます。  
原作者に感謝：https://github.com/BobLiu0518/CRTicketMonitor

> ⚠️ 免責事項  
> 本プログラムは学習および12306公式サイトの空きチケット情報の監視のみを目的としており、チケットの自動取得ソフトではありません。また、チケット取得に関する機能は一切追加しておりません。プログラム作者は監視結果の正確性について一切保証せず、本プログラムの使用に起因する商業的または法的な紛争について一切責任を負いません。

## 🆕 対話式設定機能

対話式インターフェースにより以下が可能です：

- 🔍 出発地、目的地、日付を入力し、リアルタイムで列車一覧を検索  
- 📋 列車の詳細情報と空き状況を確認  
- ⚙️ 監視する列車と席種を動的に選択  
- 📲 通知のプッシュ方法を設定  
- 💾 設定ファイルの自動生成および保存  
- 🚀 ワンクリックで監視プログラムを起動

詳細な使用方法は [CLI_GUIDE.md](https://raw.githubusercontent.com/wxory/CRTMonitor/main/CLI_GUIDE.md) をご参照ください

# デプロイ

## 方法1：プリコンパイル済みプログラムの利用（推奨）

### ダウンロード

プロジェクトのReleasesページからお使いのOSに対応した最新版をダウンロードしてください。  
[CNB(推奨)](https://cnb.cool/wxory/CRTMonitor/-/releases)  
[Github](https://github.com/wxory/CRTMonitor/releases)

### 設定

初回起動時に config.yml のテンプレートファイルが自動生成されます。  
[パラメータ設定](#配置-1)の説明に従い、該当ファイルを編集してください。

### 実行

設定済みの config.yml ファイルを実行ファイルと同じディレクトリに置き、直接実行してください。

## 手動デプロイ

### 1. Node.js のインストール

[Node.js公式サイト](https://nodejs.org/ja/)からダウンロードしてインストールするか、[パッケージマネージャー](https://nodejs.org/ja/download/package-manager)を利用してください。

### 2. コードのダウンロード

[Zipファイルを直接ダウンロード](https://github.com/wxory/CRTicketMonitor/archive/refs/heads/main.zip)するか、Gitを使用してください：
```bash
$ git clone https://github.com/wxory/CRTMonitor.git
$ git clone https://cnb.cool/wxory/CRTMonitor.git
```
### 3. 依存関係のインストール


```bash
$ npm i
```

### 4. 运行

#### 前台运行 (适用于所有系统):

```
npm start
```

#### バックグラウンド実行（Linuxサーバー向け）:

プロジェクトには run.sh スクリプトが組み込まれており、screen を使用してバックグラウンドでの持続的な実行を実現しています。

```
# 确保已安装 screen: sudo apt install screen (Debian/Ubuntu)
./run.sh
```

## 配置

プログラム起動時に同じディレクトリ内の config.yml ファイルを検索します。ファイルが存在しない場合は、自動的にテンプレートが作成されます。

以下は完全な設定例です：

config.yml の例:

```yaml
# 🚄 China Railway Ticket Monitor 配置文件
# 详细配置说明请参考 README.md

# 查询列表 - 可添加多个查询条件
watch:
  - # 基础信息
    from: "上海" # 起点站（包含同城站）
    to: "北京" # 终点站（包含同城站）
    date: "20241001" # 日期（YYYYMMDD 格式）

    # 车次列表（可选）- 不填时默认为全部车次
    trains:
      - code: "G2" # 车次号
        from: "上海" # 指定起点站（可选）
        to: "北京南" # 指定终点站（可选）
        seatCategory: # 限定席别（可选，详见下文）
          - "二等座"
        checkRoundTrip: true # 查询全程车票情况（可选）

# 推送配置 - 支持多种推送方式（详见下文）
notifications:
  - # 飞书推送
    type: "Lark"
    webhook: "" # 飞书机器人 Webhook URL

  - # Telegram推送
    type: "Telegram"
    botToken: "" # Telegram机器人Token
    chatId: "" # 接收消息的Chat ID

  - # Bark推送
    type: "Bark"
    deviceKey: "" # Bark 设备密钥
    serverUrl: "https://api.day.app" # 服务器地址（可选）
    group: "火车票监控" # 推送分组（可选）

  - # SMTP邮件推送
    type: "SMTP"
    host: "smtp.gmail.com" # SMTP服务器地址
    port: 587 # SMTP端口号
    user: "your-email@gmail.com" # 邮箱用户名
    pass: "your-app-password" # 邮箱密码
    to: "recipient@example.com" # 收件人邮箱

# 刷新间隔（分钟，可选，默认 15 分钟）
interval: 15

# 访问延迟（秒，可选，默认 5 秒）
delay: 5
```

## 推送通知

現在はFeishuプッシュ、Telegramプッシュ、企業WeChatプッシュ、BarkプッシュおよびSMTPメールプッシュ通知をサポートしています。

### Feishuプッシュ設定

FeishuボットのWebhookアドレスの取得方法は[Feishu開発ドキュメント](https://open.feishu.cn/document/client-docs/bot-v3/add-custom-bot)を参照してください。

#### 基本設定

`config.yml` にFeishuボットのWebhookアドレスを記入してください。例えば：

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
```

#### 署名検証設定（推奨）

セキュリティを向上させるために、Feishuボットの署名検証機能を有効にすることを推奨します：

1. Feishuグループ内で、カスタムボットの設定ページにアクセスします
2. セキュリティ設定で「署名検証」を選択します
3. 生成されたシークレットキーをコピーします
4. 設定ファイルに `secret` フィールドを追加します：

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
    secret: "your-secret-key" # 签名密钥（可选，启用签名校验时必填）
```
**注意事項：**

- 署名鍵はメッセージの送信元の信頼性を検証し、不正な呼び出しを防止します
- 署名検証を有効にすると、すべてのリクエストが署名検証を通過する必要があります
- 署名アルゴリズムは HmacSHA256 + Base64 エンコードを使用します

### Telegram プッシュ設定

Telegram プッシュを使用するには、まず Telegram ボットを作成し関連情報を取得します：

1. Telegram で [@BotFather](https://t.me/BotFather) を見つけ、`/newbot` を送信して新しいボットを作成します
2. 指示に従ってボットの名前とユーザー名を設定し、ボットのトークンを取得します
3. ボットをチャットに追加するか、直接ボットとプライベートチャットを開始します
4. Chat ID を取得：
   - ボットにメッセージを送信した後、`https://api.telegram.org/bot<YOUR_BOT_TOKEN>/getUpdates` にアクセスします
   - 返された JSON の中の `chat.id` フィールドを見つけます

`config.yml` に Telegram プッシュを設定します：


```yaml
notifications:
  - type: "Telegram"
    botToken: "123456789:ABCdefGHIjklMNOpqrsTUVwxyz" # 机器人Token
    chatId: "123456789" # Chat ID（可以是个人ID或群组ID）
```

### 企業微信プッシュ設定

企業微信プッシュを使用するには、まず企業微信群のロボットを作成する必要があります：

1. 企業微信群で、グループ設定 → グループロボット → ロボットを追加をクリックします
2. ロボットの名前とアイコンを設定し、Webhook URLを取得します
3. 完全なWebhook URL（keyパラメータを含む）をコピーします

`config.yml`に企業微信プッシュを設定します：

```yaml
notifications:
  - type: "WechatWork"
    webhook: "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=your-webhook-key"
```

### Bark 推送設定

Bark は iOS プッシュ通知アプリで、API を通じて iPhone/iPad にプッシュ通知を送信できます。

#### Bark デバイスキーの取得

1. App Store から [Bark](https://apps.apple.com/app/bark-customed-notifications/id1403753865) アプリをダウンロードしてインストールします
2. アプリを開き、表示されるデバイスキー（Device Key）をコピーします
3. 任意：独自の Bark サーバーがある場合は、サーバーアドレスを変更できます

#### Bark プッシュの設定

`config.yml` に Bark プッシュを設定します：

```yaml
notifications:
  - type: "Bark"
    deviceKey: "your-device-key" # 必填：设备密钥
    serverUrl: "https://api.day.app" # 可选：服务器地址，默认官方服务器
    group: "火车票监控" # 可选：推送分组
    sound: "default" # 可选：推送声音
    # 高级选项（可选）
    level: "active" # 推送级别：active(默认)/critical(重要)/timeSensitive(时效)/passive(静默)
    icon: "https://example.com/icon.png" # 自定义图标URL
    url: "https://example.com" # 点击推送后跳转的URL
    autoCopy: false # 是否自动复制推送内容
    isArchive: true # 是否保存到推送历史
```

#### Bark 推送レベルの説明

- `active`（デフォルト）：システムは即座に画面を点灯して通知を表示します
- `critical`：重要警告、サイレントモードでも着信音が鳴ります
- `timeSensitive`：時間敏感型通知、集中モード中でも通知を表示可能
- `passive`：通知リストにのみ通知を追加し、画面点灯はしません

### SMTP メールプッシュ設定

SMTP メールプッシュは標準のメールサーバーを通じて残券通知メールを送信することをサポートします。

#### SMTP メールプッシュの設定

`config.yml` に SMTP メールプッシュを設定します：

```yaml
notifications:
  - type: "SMTP"
    host: "smtp.gmail.com" # 必填：SMTP服务器地址
    port: 587 # 必填：SMTP端口号
    user: "your-email@gmail.com" # 必填：邮箱用户名
    pass: "your-app-password" # 必填：邮箱密码或应用密码
    to: "recipient@example.com" # 必填：收件人邮箱地址
    # 可选配置
    from: "12306监控 <your-email@gmail.com>" # 发件人显示名称
    cc: "cc@example.com" # 抄送邮箱
    bcc: "bcc@example.com" # 密送邮箱
    replyTo: "noreply@example.com" # 回复邮箱
    secure: true # 是否使用SSL/TLS (465端口使用true，587端口使用false)
```

#### 常用メールサーバー設定

**Gmail:**

```yaml
host: "smtp.gmail.com"
port: 587
secure: false # 使用STARTTLS
# 需要开启两步验证并生成应用密码
```

**QQ メールボックス:**

```yaml
host: "smtp.qq.com"
port: 587
secure: false
# 需要开启SMTP服务并使用授权码
```

**163 邮箱:**

```yaml
host: "smtp.163.com"
port: 587
secure: false
# 需要开启SMTP服务并使用授权码
```

**見通し：**

```yaml
host: "smtp-mail.outlook.com"
port: 587
secure: false
```
#### メールセキュリティ設定

- **Gmail**: 2段階認証を有効にし、アプリケーション専用パスワードを生成する必要があります
- **QQメール**: 設定でSMTPサービスを有効にし、認証コードをパスワードとして使用します
- **163メール**: SMTPサービスを有効にし、認証コードをパスワードとして使用します
- **企業メール**: 企業メールサービスプロバイダーの要件に従って設定してください

#### ポート番号の説明

- `25`: 標準SMTPポート（通常ISPによってブロックされています）
- `587`: STARTTLS暗号化ポート（推奨）
- `465`: SSL/TLS暗号化ポート

このように、空席がある場合は、プログラムが対応するプラットフォームを通じて通知を送信します。

## 席種設定

選択可能な席種は以下の通りです：

- 寝台：
  - `高級軟臥`
  - `軟臥`（動卧一等卧を含む）
  - `硬臥`（二等卧を含む）
- 座席：
  - `ビジネスクラス座席`
  - `特等座`
  - `優選一等座`
  - `一等座`
  - `二等座`
  - `軟座`
  - `硬座`
  - `無座`
- その他：
  - `その他`（個室硬臥などを含む）
  - `YB`（不明なタイプ）
  - `SRRB`（不明なタイプ）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---