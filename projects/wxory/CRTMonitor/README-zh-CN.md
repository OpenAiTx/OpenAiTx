# 🚄 China Railway Ticket Monitor

一个简洁、高效的 12306 余票监控工具，当出现余票时，可通过多种方式推送通知。  
感谢原作者：https://github.com/BobLiu0518/CRTicketMonitor

> ⚠️ 免责声明  
> 本程序仅用于学习和监控 12306 官网的余票信息，并非抢票软件，也不会增加任何抢票相关功能。程序作者不对监控结果的准确性做出任何保证，不为任何因使用本程序而产生的商业或法律纠纷负责。

## 🆕 交互式配置功能

通过交互式界面可以：

- 🔍 输入出发地、目的地、日期，实时查询车次列表  
- 📋 查看完整的车次信息和余票情况  
- ⚙️ 动态选择监控车次和席别  
- 📲 配置推送通知方式  
- 💾 自动生成和保存配置文件  
- 🚀 一键启动监控程序

详细使用说明请参考 [CLI_GUIDE.md](https://raw.githubusercontent.com/wxory/CRTMonitor/main/CLI_GUIDE.md)

# 部署

## 方式一：使用预编译程序 (推荐)

### 下载

在项目的 Releases 页面下载对应您操作系统的最新版本。  
[CNB(推荐)](https://cnb.cool/wxory/CRTMonitor/-/releases)  
[Github](https://github.com/wxory/CRTMonitor/releases)

### 配置

首次运行程序会自动生成一份 config.yml 模板文件。请根据 [参数配置](#配置-1) 说明修改该文件。

### 运行

将配置好的 config.yml 文件放置于可执行程序的同一目录下，然后直接运行即可。

## 手动部署

### 1. 安装 Node.js

前往 [Node.js 官网](https://nodejs.org/zh-cn) 下载并安装，或使用 [包管理器](https://nodejs.org/zh-cn/download/package-manager) 安装。

### 2. 下载代码

直接 [下载 Zip 文件](https://github.com/wxory/CRTicketMonitor/archive/refs/heads/main.zip)，或使用 Git：

```bash
$ git clone https://github.com/wxory/CRTMonitor.git
$ git clone https://cnb.cool/wxory/CRTMonitor.git
```

### 3. 安装依赖

```bash
$ npm i
```

### 4. 运行

#### 前台运行 (适用于所有系统):

```
npm start
```

#### 后台运行 (适用于 Linux 服务器):

项目内置了 run.sh 脚本，它使用 screen 来实现后台持久化运行。

```
# 确保已安装 screen: sudo apt install screen (Debian/Ubuntu)
./run.sh
```

## 配置

程序启动时会查找同目录下的 config.yml 文件。如果文件不存在，将自动创建一个模板。

以下是一个完整的配置示例：

config.yml 示例:

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

目前支持飞书推送、Telegram 推送、企业微信推送、Bark 推送和 SMTP 邮件推送通知。

### 飞书推送配置

获取飞书机器人的 webhook 地址可参考[飞书开发文档](https://open.feishu.cn/document/client-docs/bot-v3/add-custom-bot)

#### 基础配置

在 `config.yml` 中填写飞书机器人的 Webhook 地址即可，例如：

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
```
#### 签名校验配置（推荐）

为了提高安全性，建议启用飞书机器人的签名校验功能：

1. 在飞书群组中，进入自定义机器人的配置页面
2. 在安全设置中选择“签名校验”
3. 复制生成的密钥
4. 在配置文件中添加 `secret` 字段：


```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
    secret: "your-secret-key" # 签名密钥（可选，启用签名校验时必填）
```

**注意事项：**

- 签名密钥用于验证消息来源的可信性，防止恶意调用
- 启用签名校验后，所有请求都需要通过签名验证
- 签名算法使用 HmacSHA256 + Base64 编码

### Telegram 推送配置

使用 Telegram 推送需要先创建一个 Telegram 机器人并获取相关信息：

1. 在 Telegram 中找到 [@BotFather](https://t.me/BotFather) 并发送 `/newbot` 创建新机器人
2. 按照提示设置机器人名称和用户名，获取机器人 Token
3. 将机器人添加到您的聊天中，或直接与机器人私聊
4. 获取 Chat ID：
   - 发送消息给机器人后，访问 `https://api.telegram.org/bot<YOUR_BOT_TOKEN>/getUpdates`
   - 在返回的 JSON 中找到 `chat.id` 字段

在 `config.yml` 中配置 Telegram 推送：

```yaml
notifications:
  - type: "Telegram"
    botToken: "123456789:ABCdefGHIjklMNOpqrsTUVwxyz" # 机器人Token
    chatId: "123456789" # Chat ID（可以是个人ID或群组ID）
```

### 企业微信推送配置

使用企业微信推送需要先创建企业微信群机器人：

1. 在企业微信群中，点击群设置 → 群机器人 → 添加机器人
2. 设置机器人名称和头像，获取 Webhook URL
3. 复制完整的 Webhook URL（包含 key 参数）

在 `config.yml` 中配置企业微信推送：

```yaml
notifications:
  - type: "WechatWork"
    webhook: "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=your-webhook-key"
```

### Bark 推送配置

Bark 是一个 iOS 推送通知应用，支持通过 API 发送推送到 iPhone/iPad。

#### 获取 Bark 设备密钥

1. 在 App Store 下载并安装 [Bark](https://apps.apple.com/app/bark-customed-notifications/id1403753865) 应用
2. 打开应用，复制显示的设备密钥（Device Key）
3. 可选：如果你有自己的 Bark 服务器，也可以修改服务器地址

#### 配置 Bark 推送

在 `config.yml` 中配置 Bark 推送：

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
#### Bark 推送级别说明

- `active`（默认）：系统会立即亮屏显示通知
- `critical`：重要警告，在静音模式下也会响铃
- `timeSensitive`：时效性通知，可在专注状态下显示通知
- `passive`：仅将通知添加到通知列表，不会亮屏提醒

### SMTP 邮件推送配置

SMTP 邮件推送支持通过标准邮件服务器发送余票通知邮件。

#### 配置 SMTP 邮件推送

在 `config.yml` 中配置 SMTP 邮件推送：


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

#### 常用邮箱服务器配置

**Gmail：**

```yaml
host: "smtp.gmail.com"
port: 587
secure: false # 使用STARTTLS
# 需要开启两步验证并生成应用密码
```

**QQ 邮箱：**

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

**展望：**

```yaml
host: "smtp-mail.outlook.com"
port: 587
secure: false
```

#### 邮箱安全设置

- **Gmail**: 需要开启两步验证，生成应用专用密码
- **QQ 邮箱**: 需要在设置中开启 SMTP 服务，使用授权码作为密码
- **163 邮箱**: 需要开启 SMTP 服务，使用授权码作为密码
- **企业邮箱**: 根据企业邮箱服务商的要求配置

#### 端口号说明

- `25`: 标准 SMTP 端口（通常被 ISP 封禁）
- `587`: STARTTLS 加密端口（推荐）
- `465`: SSL/TLS 加密端口

这样，当有余票时，程序会通过相应的平台发送通知。

## 席别设置

可选的席别如下：

- 卧铺：
  - `高级软卧`
  - `软卧`（含动卧一等卧）
  - `硬卧`（含二等卧）
- 坐票：
  - `商务座`
  - `特等座`
  - `优选一等座`
  - `一等座`
  - `二等座`
  - `软座`
  - `硬座`
  - `无座`
- 其他：
  - `其他`（含包厢硬卧等）
  - `YB`（未知类型）
  - `SRRB`（未知类型）


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---