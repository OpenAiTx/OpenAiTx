# 🚄 China Railway Ticket Monitor

A simple and efficient 12306 ticket availability monitoring tool that can send notifications through various methods when tickets become available.  
Thanks to the original author: https://github.com/BobLiu0518/CRTicketMonitor

> ⚠️ Disclaimer  
> This program is only for learning and monitoring ticket availability information on the official 12306 website. It is not a ticket-snatching software and does not include any ticket-snatching features. The author does not guarantee the accuracy of the monitoring results and is not responsible for any commercial or legal disputes arising from the use of this program.

## 🆕 Interactive Configuration Features

Through the interactive interface, you can:

- 🔍 Enter departure, destination, and date to query the train list in real time  
- 📋 View complete train information and ticket availability  
- ⚙️ Dynamically select trains and seat types to monitor  
- 📲 Configure notification methods  
- 💾 Automatically generate and save configuration files  
- 🚀 Start the monitoring program with one click

For detailed usage instructions, please refer to [CLI_GUIDE.md](https://raw.githubusercontent.com/wxory/CRTMonitor/main/CLI_GUIDE.md)

# Deployment

## Method 1: Use Precompiled Program (Recommended)

### Download

Download the latest version corresponding to your operating system from the project's Releases page.  
[CNB (Recommended)](https://cnb.cool/wxory/CRTMonitor/-/releases)  
[Github](https://github.com/wxory/CRTMonitor/releases)

### Configuration

The program will automatically generate a config.yml template file upon first run. Please modify this file according to the [Parameter Configuration](#配置-1) instructions.

### Run

Place the configured config.yml file in the same directory as the executable program, then run it directly.

## Manual Deployment

### 1. Install Node.js

Go to the [Node.js official website](https://nodejs.org/zh-cn) to download and install, or use a [package manager](https://nodejs.org/zh-cn/download/package-manager) to install.

### 2. Download Code

Download the [Zip file directly](https://github.com/wxory/CRTicketMonitor/archive/refs/heads/main.zip), or use Git:

```bash
$ git clone https://github.com/wxory/CRTMonitor.git
$ git clone https://cnb.cool/wxory/CRTMonitor.git
```

### 3. Install Dependencies

```bash
$ npm i
```

### 4. 运行

#### 前台运行 (适用于所有系统):

```
npm start
```

#### Running in the Background (Applicable to Linux Servers):

The project includes a built-in run.sh script that uses screen to achieve persistent background execution.

```
# 确保已安装 screen: sudo apt install screen (Debian/Ubuntu)
./run.sh
```

## Configuration

The program will look for a config.yml file in the same directory when it starts. If the file does not exist, a template will be created automatically.

Below is a complete configuration example:

config.yml example:

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

## Push Notifications

Currently supports Feishu push, Telegram push, WeCom push, Bark push, and SMTP email push notifications.

### Feishu Push Configuration

To obtain the webhook address for the Feishu bot, refer to the [Feishu Developer Documentation](https://open.feishu.cn/document/client-docs/bot-v3/add-custom-bot)

#### Basic Configuration

Fill in the Feishu bot's Webhook address in `config.yml`, for example:

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
```

#### Signature Verification Configuration (Recommended)

To enhance security, it is recommended to enable the signature verification feature for Feishu bots:

1. In the Feishu group, go to the custom bot configuration page
2. Select "Signature Verification" in the security settings
3. Copy the generated secret key
4. Add the `secret` field in the configuration file:

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
    secret: "your-secret-key" # 签名密钥（可选，启用签名校验时必填）
```

**Notes:**

- The signature key is used to verify the authenticity of the message source and prevent malicious calls
- After enabling signature verification, all requests must pass signature validation
- The signature algorithm uses HmacSHA256 + Base64 encoding

### Telegram Push Configuration

To use Telegram push notifications, you need to first create a Telegram bot and obtain relevant information:

1. Find [@BotFather](https://t.me/BotFather) in Telegram and send `/newbot` to create a new bot
2. Follow the prompts to set the bot's name and username, and get the bot Token
3. Add the bot to your chat, or chat directly with the bot
4. Obtain the Chat ID:
   - After sending a message to the bot, visit `https://api.telegram.org/bot<YOUR_BOT_TOKEN>/getUpdates`
   - Find the `chat.id` field in the returned JSON

Configure Telegram push in `config.yml`:

```yaml
notifications:
  - type: "Telegram"
    botToken: "123456789:ABCdefGHIjklMNOpqrsTUVwxyz" # 机器人Token
    chatId: "123456789" # Chat ID（可以是个人ID或群组ID）
```

### Enterprise WeChat Push Configuration

To use Enterprise WeChat push, you need to first create an Enterprise WeChat group bot:

1. In the Enterprise WeChat group, click Group Settings → Group Bot → Add Bot
2. Set the bot name and avatar, then obtain the Webhook URL
3. Copy the complete Webhook URL (including the key parameter)

Configure Enterprise WeChat push in `config.yml`:

```yaml
notifications:
  - type: "WechatWork"
    webhook: "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=your-webhook-key"
```

### Bark Push Configuration

Bark is an iOS push notification app that supports sending pushes to iPhone/iPad via API.

#### Obtaining Bark Device Key

1. Download and install the [Bark](https://apps.apple.com/app/bark-customed-notifications/id1403753865) app from the App Store
2. Open the app and copy the displayed Device Key
3. Optional: If you have your own Bark server, you can also modify the server address

#### Configuring Bark Push

Configure Bark push in `config.yml`:

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

#### Bark Push Level Description

- `active` (default): The system will immediately light up the screen to display the notification  
- `critical`: Important warning, will ring even in silent mode  
- `timeSensitive`: Time-sensitive notification, can display notifications during Focus mode  
- `passive`: Only adds the notification to the notification list, no screen lighting reminder  

### SMTP Email Push Configuration

SMTP email push supports sending ticket availability notification emails through standard mail servers.

#### Configure SMTP Email Push

Configure SMTP email push in `config.yml`:

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

#### Common Email Server Configurations

**Gmail:**

```yaml
host: "smtp.gmail.com"
port: 587
secure: false # 使用STARTTLS
# 需要开启两步验证并生成应用密码
```

**QQ Email:**

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

**Outlook:**

```yaml
host: "smtp-mail.outlook.com"
port: 587
secure: false
```
#### Email Security Settings

- **Gmail**: Two-step verification needs to be enabled, and an app-specific password generated  
- **QQ Mail**: SMTP service needs to be enabled in settings, using an authorization code as the password  
- **163 Mail**: SMTP service needs to be enabled, using an authorization code as the password  
- **Enterprise Mail**: Configured according to the requirements of the enterprise mail provider  

#### Port Number Explanation

- `25`: Standard SMTP port (usually blocked by ISPs)  
- `587`: STARTTLS encryption port (recommended)  
- `465`: SSL/TLS encryption port  

In this way, when there are remaining tickets, the program will send notifications through the corresponding platform.  

## Seat Type Settings

Available seat types are as follows:  

- Sleeper:  
  - `Premium Soft Sleeper`  
  - `Soft Sleeper` (including first-class soft sleeper on bullet trains)  
  - `Hard Sleeper` (including second-class sleeper)  
- Seat Tickets:  
  - `Business Seat`  
  - `Special Class Seat`  
  - `Preferred First Class Seat`  
  - `First Class Seat`  
  - `Second Class Seat`  
  - `Soft Seat`  
  - `Hard Seat`  
  - `No Seat`  
- Others:  
  - `Other` (including compartment hard sleeper, etc.)  
  - `YB` (unknown type)  
  - `SRRB` (unknown type)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---