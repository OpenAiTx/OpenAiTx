# wechat2tg-mac

基於微信 Mac 協議，在 Telegram 收發微信消息，wx2tg-server 服務端出於安全考量不開源

## TG 群組: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## 主要功能

1. 接收微信單聊消息、微信群消息、訂閱號（公眾號）消息、企業微信消息
2. 可從 Telegram 向指定的微信用戶、微信群、訂閱號發送消息
3. 屏蔽指定群組的消息

## 支援的消息類型

### 微信消息類型支援列表

+ [x] 文字消息
+ [x] 企業微信消息
+ [x] 微信貼圖（表情包）
+ [x] 圖片消息
+ [x] 視頻消息
+ [x] 音訊/視頻通話（僅消息提醒）
+ [x] 檔案消息
+ [x] 連結消息
+ [x] 群聊消息
+ [x] 群聊@消息（@所有人和@你會轉換為 Telegram @你）
+ [x] 訂閱號消息
+ [x] emoji
+ [x] 位置消息
+ [x] 撤回消息
+ [x] 語音消息
+ [ ] 紅包消息（提醒，無法獲取紅包內容）
+ [ ] 小程序消息

### Telegram 消息類型支援列表

+ [x] 文字消息
+ [x] 貼圖表情
+ [x] 圖片消息
+ [x] 視頻消息
+ [x] 檔案消息
+ [x] 語音消息

## 注意事項

1. 本專案僅用於技術研究與學習，不得用於非法用途
2. 無論遇到任何問題，均歡迎提交 issue

## 部署安裝

先複製一份 `.env.example` 為 `.env` 檔案，然後設定 `.env` 檔案中的環境變數

將專案中的 `app.conf.example` 複製為 `app.conf` 檔案到 `conf` 目錄，將 Redis 地址設為你部署的 Redis 地址

### docker-compose

建立 `docker-compose.yml` 檔案：

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # 保存文件夾掛載後貼圖文件不需重新轉換
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # 拉取映像檔
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

#### 執行

```shell
docker-compose up -d
```

#### 關閉 bot 隱私模式

關閉機器人的隱私模式，打開 BotFather，輸入 `/mybots`，選擇你的 bot。點擊 `Bot Settings` - `Group Privacy` - `Turn off`
，出現 `Privacy mode is disabled for xxx` 即表示關閉成功

## 使用說明

### BOT 命令

- `/login`：獲取登入二維碼；首次部署啟動時，最先發送 `/login` 命令的人將成為 `BOT` 擁有者

- `/flogin`：獲取文件傳輸助手登入二維碼，支援接收視頻和文件

- `/update`：更新群組頭像和暱稱資訊

- `/message`：開關群組消息接收

- `/forward`：開關轉發群組內其他人或 bot 的消息

- `/user`：獲取微信用戶列表；點擊按鈕後可建立新群組或綁定用戶（可通過名稱或備註搜尋，例如： `/user 張` 查找包含「張」的微信用戶）

- `/room`：獲取微信群列表；點擊按鈕後可建立新群組或綁定微信群（可通過名稱或備註搜尋，例如： `/room 外賣` 查找含有「外賣」的微信群）

- `/settings`：程式設定

- `/unbind`：解除綁定微信群或微信用戶（僅支援在群組中使用）

### 環境變數說明

|名稱| 是否必填 | 說明                                                               |
|--|------|--------------------------------------------------------------------|
|`BOT_TOKEN`| 是    | Telegram Bot 的 token，透過 [BotFather](https://t.me/BotFather) 建立 |
|`API_ID`| 是    | Telegram API 的 API ID                                           |
|`API_HASH`| 是    | Telegram API 的 API HASH                                         |
|`BASE_API`| 是    | wx2tg-server 容器的 API 請求位址，需填完整路徑                              | |
|`PROXY_PROTOCOL`| 否    | 代理類型可選值（socks5,http,https）                                     |
|`PROXY_HOST`| 否    | 代理的 URL                                                          |
|`PROXY_PORT`| 否    | 代理的埠號                                                            |
|`PROXY_USERNAME`| 否    | 代理的用戶名                                                          |
|`PROXY_PASSWORD`| 否    | 代理的密碼                                                            |
|`ROOM_MESSAGE`| 否    | BOT 中微信群消息的顯示格式                                                |
|`OFFICIAL_MESSAGE`| 否    | BOT 中訂閱號消息的顯示格式                                                |
|`CONTACT_MESSAGE`| 否    | BOT 中微信用戶消息的顯示格式                                               |
|`ROOM_MESSAGE_GROUP`| 否    | 群組中微信群消息的顯示格式                                                 |
|`CONTACT_MESSAGE_GROUP`| 否    | 群組中微信用戶消息的顯示格式                                                |
|`OFFICIAL_MESSAGE_GROUP`| 否    | 群組中訂閱號消息的顯示格式                                                 |
|`CREATE_ROOM_NAME`| 否    | 自動建立微信群對應的群組時，群組名稱的格式                                     |
|`CREATE_CONTACT_NAME`| 否    | 自動建立微信聯絡人對應的群組時，群組名稱的格式                                 |
|`MESSAGE_DISPLAY`| 否    | 文字消息的顯示格式                                                        |

---

### 設定項 `/settings` 命令說明

1. 微信 emoji 是否以圖片連結顯示：開啟後會將好友發來的小黃人表情轉為圖片連結顯示

2. 啟動時同步群組資訊：開啟後程式啟動時會同步所有人的資訊，會更新群組頭像和名稱

---

### 語音轉文字

1. 配置 `TENCENT_SECRET_ID` 和 `TENCENT_SECRET_KEY`，可於騰訊[語音識別控制台](https://console.cloud.tencent.com/asr)開通
   。有免費使用額度
2. 在 `/settings` 中開啟自動語音轉文字功能

---

### 取得 `API_ID` 和 `API_HASH`

1. 登入 [telegram account](https://my.telegram.org/)

2. 點擊「API development tools」並填寫應用詳細資訊（僅需應用標題與簡稱）

3. 點擊「Create application」

---

### 自訂消息模板

若需修改消息發送者格式，可修改 docker 的環境變數或 `.env` 檔案

自訂消息模板佔位符：

`#[alias]`：聯絡人備註

`#[name]`：聯絡人暱稱

`#[topic]`：群聊暱稱

`#[alias_first]`：備註優先，無備註則顯示聯絡人暱稱

`#[identity]`：身份資訊文字

`#[body]`：消息主體文字

`#[br]`：換行

### 如何 @所有人

發送以 `@all` 開頭的消息會 @所有人，僅支援文字消息 @所有人

---

## 常見問題

## 參與開發

1. fork 專案，切換到 `wx2tg-mac-dev` 分支，或新建分支。請勿直接提交到主分支
2. 提交 Pull Request 至 `wx2tg-mac-dev` 分支

## License

[MIT](LICENSE)

## Thanks

感謝 Jetbrains 對本專案的支持

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---