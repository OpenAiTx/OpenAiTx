# 🚄 China Railway Ticket Monitor

간결하고 효율적인 12306 잔여표 모니터링 도구로, 잔여표가 있을 때 다양한 방식으로 알림을 전송할 수 있습니다.  
감사합니다 원저자: https://github.com/BobLiu0518/CRTicketMonitor

> ⚠️ 면책 조항  
> 본 프로그램은 12306 공식 사이트의 잔여표 정보를 학습 및 모니터링하기 위한 용도로만 사용되며, 티켓抢票 소프트웨어가 아니며 티켓抢票 관련 기능을 추가하지 않습니다. 프로그램 저자는 모니터링 결과의 정확성에 대해 어떠한 보장도 하지 않으며, 본 프로그램 사용으로 인해 발생하는 상업적 또는 법적 분쟁에 대해 책임을 지지 않습니다.

## 🆕 대화형 구성 기능

대화형 인터페이스를 통해 다음을 할 수 있습니다:

- 🔍 출발지, 목적지, 날짜를 입력하여 실시간으로 열차 목록 조회  
- 📋 전체 열차 정보와 잔여표 상황 확인  
- ⚙️ 모니터링할 열차 및 좌석 종류 동적 선택  
- 📲 알림 전송 방식을 설정  
- 💾 자동으로 구성 파일 생성 및 저장  
- 🚀 원클릭으로 모니터링 프로그램 시작

자세한 사용법은 [CLI_GUIDE.md](https://raw.githubusercontent.com/wxory/CRTMonitor/main/CLI_GUIDE.md)를 참고하세요.

# 배포

## 방법 1: 사전 컴파일된 프로그램 사용 (권장)

### 다운로드

프로젝트의 Releases 페이지에서 운영 체제에 맞는 최신 버전을 다운로드하세요.  
[CNB(권장)](https://cnb.cool/wxory/CRTMonitor/-/releases)  
[Github](https://github.com/wxory/CRTMonitor/releases)

### 구성

프로그램을 처음 실행하면 config.yml 템플릿 파일이 자동으로 생성됩니다.  
[파라미터 구성](#配置-1) 설명에 따라 해당 파일을 수정하세요.

### 실행

구성된 config.yml 파일을 실행 파일과 동일한 디렉터리에 두고, 바로 실행하면 됩니다.

## 수동 배포

### 1. Node.js 설치

[Node.js 공식 사이트](https://nodejs.org/zh-cn)에서 다운로드 및 설치하거나, [패키지 관리자](https://nodejs.org/zh-cn/download/package-manager)를 사용하세요.

### 2. 코드 다운로드

직접 [Zip 파일 다운로드](https://github.com/wxory/CRTicketMonitor/archive/refs/heads/main.zip) 하거나 Git을 사용하세요:
```bash
$ git clone https://github.com/wxory/CRTMonitor.git
$ git clone https://cnb.cool/wxory/CRTMonitor.git
```
### 3. 의존성 설치


```bash
$ npm i
```

### 4. 运行

#### 前台运行 (适用于所有系统):

```
npm start
```
#### 백그라운드 실행 (Linux 서버에 적합):

프로젝트에는 run.sh 스크립트가 내장되어 있으며, screen을 사용하여 백그라운드에서 지속적으로 실행됩니다.


```
# 确保已安装 screen: sudo apt install screen (Debian/Ubuntu)
./run.sh
```

## 구성

프로그램 시작 시 동일 디렉터리 내의 config.yml 파일을 찾습니다. 파일이 없으면 템플릿이 자동으로 생성됩니다.

다음은 완전한 구성 예시입니다:

config.yml 예시:

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

## 푸시 알림

현재 Feishu 푸시, Telegram 푸시, 기업 WeChat 푸시, Bark 푸시 및 SMTP 이메일 푸시 알림을 지원합니다.

### Feishu 푸시 구성

Feishu 봇의 webhook 주소를 얻으려면 [Feishu 개발 문서](https://open.feishu.cn/document/client-docs/bot-v3/add-custom-bot)를 참조하세요.

#### 기본 구성

`config.yml`에 Feishu 봇의 Webhook 주소를 입력하면 됩니다. 예를 들면:

```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
```
#### 서명 검증 설정(권장)

보안을 강화하기 위해, Feishu 봇의 서명 검증 기능을 활성화할 것을 권장합니다:

1. Feishu 그룹에서 맞춤형 봇 설정 페이지로 이동합니다
2. 보안 설정에서 "서명 검증"을 선택합니다
3. 생성된 비밀키를 복사합니다
4. 구성 파일에 `secret` 필드를 추가합니다:


```yaml
notifications:
  - type: "Lark"
    webhook: "https://open.feishu.cn/open-apis/bot/v2/hook/your-webhook-url"
    secret: "your-secret-key" # 签名密钥（可选，启用签名校验时必填）
```
**주의 사항:**

- 서명 키는 메시지 출처의 신뢰성을 검증하고 악의적 호출을 방지하는 데 사용됩니다.
- 서명 검증을 활성화하면 모든 요청은 서명 검증을 통과해야 합니다.
- 서명 알고리즘은 HmacSHA256 + Base64 인코딩을 사용합니다.

### 텔레그램 푸시 설정

텔레그램 푸시를 사용하려면 먼저 텔레그램 봇을 생성하고 관련 정보를 얻어야 합니다:

1. 텔레그램에서 [@BotFather](https://t.me/BotFather)를 찾아 `/newbot`을 보내 새 봇을 생성합니다.
2. 안내에 따라 봇 이름과 사용자 이름을 설정하고 봇 토큰을 획득합니다.
3. 봇을 채팅에 추가하거나 봇과 직접 개인 채팅을 시작합니다.
4. 채팅 ID 획득:
   - 봇에게 메시지를 보낸 후, `https://api.telegram.org/bot<YOUR_BOT_TOKEN>/getUpdates`에 접속합니다.
   - 반환된 JSON에서 `chat.id` 필드를 찾습니다.

`config.yml`에서 텔레그램 푸시를 다음과 같이 설정합니다:


```yaml
notifications:
  - type: "Telegram"
    botToken: "123456789:ABCdefGHIjklMNOpqrsTUVwxyz" # 机器人Token
    chatId: "123456789" # Chat ID（可以是个人ID或群组ID）
```
### 기업 위챗 푸시 설정

기업 위챗 푸시를 사용하려면 먼저 기업 위챗 그룹 봇을 생성해야 합니다:

1. 기업 위챗 그룹에서, 그룹 설정 → 그룹 봇 → 봇 추가 클릭
2. 봇 이름과 프로필 사진 설정, Webhook URL 획득
3. Webhook URL 전체 복사 (key 매개변수 포함)

`config.yml`에서 기업 위챗 푸시 설정:


```yaml
notifications:
  - type: "WechatWork"
    webhook: "https://qyapi.weixin.qq.com/cgi-bin/webhook/send?key=your-webhook-key"
```
### Bark 푸시 설정

Bark는 iOS 푸시 알림 앱으로, API를 통해 iPhone/iPad로 푸시를 보낼 수 있습니다.

#### Bark 디바이스 키 가져오기

1. App Store에서 [Bark](https://apps.apple.com/app/bark-customed-notifications/id1403753865) 앱을 다운로드하고 설치합니다.
2. 앱을 열고 표시된 디바이스 키(Device Key)를 복사합니다.
3. 선택 사항: 자체 Bark 서버가 있는 경우 서버 주소를 수정할 수도 있습니다.

#### Bark 푸시 설정

`config.yml`에서 Bark 푸시를 설정합니다:


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

#### Bark 푸시 레벨 설명

- `active`（기본값）：시스템이 즉시 화면을 켜고 알림을 표시합니다.
- `critical`：중요 경고, 무음 모드에서도 벨소리가 울립니다.
- `timeSensitive`：시기적절한 알림으로 집중 모드에서도 표시할 수 있습니다.
- `passive`：알림 목록에만 알림을 추가하며 화면을 켜지 않습니다.

### SMTP 이메일 푸시 구성

SMTP 이메일 푸시는 표준 메일 서버를 통해 잔여 표 알림 메일을 보낼 수 있습니다.

#### SMTP 이메일 푸시 구성

`config.yml`에서 SMTP 이메일 푸시를 구성합니다:

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

#### 자주 사용하는 이메일 서버 구성

**Gmail:**

```yaml
host: "smtp.gmail.com"
port: 587
secure: false # 使用STARTTLS
# 需要开启两步验证并生成应用密码
```

**QQ 이메일:**

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

**전망:**

```yaml
host: "smtp-mail.outlook.com"
port: 587
secure: false
```
#### 이메일 보안 설정

- **Gmail**: 2단계 인증을 활성화하고 앱 전용 비밀번호를 생성해야 합니다.
- **QQ 이메일**: 설정에서 SMTP 서비스를 활성화하고 인증 코드를 비밀번호로 사용해야 합니다.
- **163 이메일**: SMTP 서비스를 활성화하고 인증 코드를 비밀번호로 사용해야 합니다.
- **기업 이메일**: 기업 이메일 서비스 제공자의 요구에 따라 구성합니다.

#### 포트 번호 설명

- `25`: 표준 SMTP 포트 (일반적으로 ISP에 의해 차단됨)
- `587`: STARTTLS 암호화 포트 (권장)
- `465`: SSL/TLS 암호화 포트

이렇게 하면 잔여 좌석이 있을 때 프로그램이 해당 플랫폼을 통해 알림을 보냅니다.

## 좌석 종류 설정

선택 가능한 좌석 종류는 다음과 같습니다:

- 침대차:
  - `고급 연철 침대`
  - `연철 침대` (동차 1등 침대 포함)
  - `경철 침대` (2등 침대 포함)
- 좌석표:
  - `비즈니스석`
  - `특등석`
  - `우선 1등석`
  - `1등석`
  - `2등석`
  - `연철 좌석`
  - `경철 좌석`
  - `무좌석`
- 기타:
  - `기타` (객실 연철 침대 등 포함)
  - `YB` (알 수 없는 유형)
  - `SRRB` (알 수 없는 유형)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-25

---