# wechat2tg-mac

Send and receive WeChat messages on Telegram based on the WeChat Mac protocol. The wx2tg-server backend is not open source for security reasons.

## TG Group: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## Main Features

1. Receive private WeChat messages, group chat messages, official account messages, and WeCom (Enterprise WeChat) messages
2. Send messages from Telegram to specified WeChat users, groups, or official accounts
3. Block messages from specified groups

## Supported Message Types

### Supported WeChat Message Types

+ [x] Text messages
+ [x] WeCom (Enterprise WeChat) messages
+ [x] WeChat sticker packs
+ [x] Image messages
+ [x] Video messages
+ [x] Audio/Video call (notification only)
+ [x] File messages
+ [x] Link messages
+ [x] Group chat messages
+ [x] Group chat @ messages (@everyone and @you will be converted to Telegram @you)
+ [x] Official account messages
+ [x] emoji
+ [x] Location messages
+ [x] Message recall
+ [x] Voice messages
+ [ ] Red packet messages (notification only, content cannot be obtained)
+ [ ] Mini program messages

### Supported Telegram Message Types

+ [x] Text messages
+ [x] Sticker emojis
+ [x] Image messages
+ [x] Video messages
+ [x] File messages
+ [x] Voice messages

## Notes

1. This project is for technical research and study only. Do not use for illegal purposes.
2. No matter what problem you encounter, feel free to submit an issue.

## Deployment and Installation

First, copy `.env.example` to `.env`, then configure the environment variables in the `.env` file.

Copy `app.conf.example` from the project to `app.conf` in the `conf` directory, and set the Redis address to the address of your deployed Redis.

### docker-compose

Create a `docker-compose.yml` file:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # After mounting the save folder, sticker files do not need to be reconverted
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # Pull the image
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

#### Run

```shell
docker-compose up -d
```

#### Disable bot privacy mode

Disable the bot's privacy mode. Open BotFather, enter `/mybots`, select your bot. Click `Bot Settings` - `Group Privacy` - `Turn off`. If you see `Privacy mode is disabled for xxx`, it means it was successfully disabled.

## Usage Instructions

### BOT Commands

- `/login`: Get login QR code; when deployed for the first time, the first user to send `/login` will become the owner of the `BOT`.

- `/flogin`: Get the File Transfer Assistant login QR code, supports receiving videos and files

- `/update`: Update group avatars and nickname information

- `/message`: Toggle group message reception

- `/forward`: Toggle forwarding of messages from others or bots in the group

- `/user`: Get WeChat user list; after clicking the button you can create a new group or bind a user (you can search by name or remark, for example: `/user Zhang` to find WeChat users containing "Zhang")

- `/room`: Get WeChat group list; after clicking the button you can create a new group or bind a WeChat group (you can search by name or remark, for example: `/room Takeout` to find WeChat groups containing "Takeout")

- `/settings`: Program settings

- `/unbind`: Unbind WeChat group or user (only supported in groups)

### Environment Variable Description

| Name | Required | Description |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| Yes | Telegram Bot token, created via [BotFather](https://t.me/BotFather) |
|`API_ID`| Yes | Telegram API's API ID |
|`API_HASH`| Yes | Telegram API's API HASH |
|`BASE_API`| Yes | API request address of wx2tg-server container, must be a complete path |
|`PROXY_PROTOCOL`| No | Proxy type, optional values (socks5, http, https) |
|`PROXY_HOST`| No | Proxy URL |
|`PROXY_PORT`| No | Proxy port |
|`PROXY_USERNAME`| No | Proxy username |
|`PROXY_PASSWORD`| No | Proxy password |
|`ROOM_MESSAGE`| No | Display format of WeChat group messages in BOT |
|`OFFICIAL_MESSAGE`| No | Display format of official account messages in BOT |
|`CONTACT_MESSAGE`| No | Display format of WeChat user messages in BOT |
|`ROOM_MESSAGE_GROUP`| No | Display format of WeChat group messages in group |
|`CONTACT_MESSAGE_GROUP`| No | Display format of WeChat user messages in group |
|`OFFICIAL_MESSAGE_GROUP`| No | Display format of official account messages in group |
|`CREATE_ROOM_NAME`| No | Format of group name when automatically creating a WeChat group |
|`CREATE_CONTACT_NAME`| No | Format of group name when automatically creating a WeChat contact group |
|`MESSAGE_DISPLAY`| No | Display format for text messages |

---

### `/settings` Command Description

1. Whether to display WeChat emoji as image links: When enabled, yellow face emojis sent by friends will be displayed as image links

2. Sync group info on startup: When enabled, the information of all users will be synchronized at program startup, and group avatars and names will be updated

---

### Speech-to-Text

1. Configure `TENCENT_SECRET_ID` and `TENCENT_SECRET_KEY`, which can be obtained from Tencent's [Speech Recognition Console](https://console.cloud.tencent.com/asr). There are free usage quotas.
2. Enable the automatic speech-to-text feature in `/settings`.

---

### Get `API_ID` and `API_HASH`

1. Log in to [telegram account](https://my.telegram.org/)

2. Click "API development tools" and fill in application details (only the app title and short name are needed)

3. Finally, click "Create application"

---

### Custom Message Templates

If you want to modify the sender's message format, you can modify the environment variables in Docker or in the `.env` file.

Custom message template placeholders:

`#[alias]`: Contact remark

`#[name]`: Contact nickname

`#[topic]`: Group chat nickname

`#[alias_first]`: Remark first, if no remark, display contact nickname

`#[identity]`: Identity information text

`#[body]`: Message body text

`#[br]`: New line

### How to @everyone

Send a message starting with `@all` to @everyone. Only text messages support @everyone.

---

## FAQ

## Contributing

1. Fork the project, switch to the `wx2tg-mac-dev` branch, or create a new branch. Please do not submit code directly to the main branch.
2. Submit a Pull Request to the `wx2tg-mac-dev` branch.

## License

[MIT](LICENSE)

## Thanks

Thanks to Jetbrains for supporting this project

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---