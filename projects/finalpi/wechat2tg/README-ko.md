# wechat2tg-mac

WeChat Mac 프로토콜을 기반으로 Telegram에서 WeChat 메시지 송수신, wx2tg-server 서버는 보안상의 이유로 오픈소스가 아닙니다.

## TG 그룹: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## 주요 기능

1. WeChat 1:1 채팅, 그룹 채팅, 공식 계정 메시지, 기업 WeChat 메시지 수신
2. Telegram에서 지정한 WeChat 사용자, 그룹, 공식 계정으로 메시지 전송
3. 지정한 그룹의 메시지 차단

## 지원 메시지 유형

### WeChat 메시지 유형 지원 목록

+ [x] 텍스트 메시지
+ [x] 기업 WeChat 메시지
+ [x] WeChat 이모티콘(스티커)
+ [x] 이미지 메시지
+ [x] 동영상 메시지
+ [x] 오디오/영상 통화 (알림만 지원)
+ [x] 파일 메시지
+ [x] 링크 메시지
+ [x] 그룹 채팅 메시지
+ [x] 그룹 채팅 @ 메시지(@전체, @당신 → Telegram @당신으로 변환)
+ [x] 공식 계정 메시지
+ [x] emoji
+ [x] 위치 메시지
+ [x] 메시지 회수(삭제)
+ [x] 음성 메시지
+ [ ] 홍바오(레드팩) 메시지(알림만, 내용 수신 불가)
+ [ ] 미니프로그램 메시지

### Telegram 메시지 유형 지원 목록

+ [x] 텍스트 메시지
+ [x] 스티커/이모티콘
+ [x] 이미지 메시지
+ [x] 동영상 메시지
+ [x] 파일 메시지
+ [x] 음성 메시지

## 유의사항

1. 본 프로젝트는 기술 연구와 학습 목적에만 사용되며, 불법적 용도로 사용해서는 안 됩니다.
2. 어떤 문제가 있더라도 issue 등록을 환영합니다.

## 배포 및 설치

`.env.example` 파일을 복사하여 `.env` 파일로 만든 후, `.env` 파일 내 환경 변수를 설정하십시오.

프로젝트 내 `app.conf.example`을 `app.conf`로 복사하여 `conf` 디렉토리에 넣고, Redis 주소를 본인이 배포한 Redis 주소로 설정하세요.

### docker-compose

`docker-compose.yml` 파일 생성:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # 저장 폴더를 마운트하면 스티커 파일을 재변환할 필요 없음
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # 이미지 가져오기
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

#### 실행

```shell
docker-compose up -d
```

#### 봇 프라이버시 모드 비활성화

봇의 프라이버시 모드를 꺼주세요. BotFather를 열고 `/mybots` 입력 후, 본인의 봇 선택. `Bot Settings` - `Group Privacy` - `Turn off` 클릭.  
`Privacy mode is disabled for xxx`가 뜨면 비활성화 성공.

## 사용 설명

### BOT 명령어

- `/login` : 로그인 QR코드 받기; 최초 배포 시 가장 먼저 `/login`을 보낸 사람이 `BOT` 소유자가 됩니다.

- `/flogin` : 파일 전송 도우미 로그인 QR코드 받기, 동영상/파일 수신 지원

- `/update` : 그룹 프로필 사진 및 닉네임 정보 갱신

- `/message` : 그룹 메시지 수신 ON/OFF

- `/forward` : 그룹 내 타인 혹은 봇의 메시지 포워딩 ON/OFF

- `/user` : WeChat 사용자 목록 조회; 버튼 클릭 후 새 그룹 생성/사용자 바인딩(이름/메모로 검색 가능, 예: `/user 장` → "장" 포함 사용자 검색)

- `/room` : WeChat 그룹 목록 조회; 버튼 클릭 후 새 그룹 생성/그룹 바인딩(이름/메모로 검색 가능, 예: `/room 배달` → "배달" 포함 그룹 검색)

- `/settings` : 프로그램 설정

- `/unbind` : WeChat 그룹 또는 사용자 바인딩 해제(그룹에서만 사용 가능)

### 환경 변수 설명

|이름| 필수여부 | 설명                                                            |
|--|------|-------------------------------------------------------------|
|`BOT_TOKEN`| 예   | Telegram Bot의 토큰, [BotFather](https://t.me/BotFather)에서 생성  |
|`API_ID`| 예   | Telegram API의 API ID                                   |
|`API_HASH`| 예   | Telegram API의 API HASH                                 |
|`BASE_API`| 예   | wx2tg-server 컨테이너의 API 요청 주소, 전체 경로명 입력 필요             | |
|`PROXY_PROTOCOL`| 아니오   | 프록시 유형 (socks5, http, https)                              |
|`PROXY_HOST`| 아니오   | 프록시 URL                                             |
|`PROXY_PORT`| 아니오   | 프록시 포트번호                                             |
|`PROXY_USERNAME`| 아니오   | 프록시 사용자명                                              |
|`PROXY_PASSWORD`| 아니오   | 프록시 비밀번호                                              |
|`ROOM_MESSAGE`| 아니오   | BOT 내 WeChat 그룹 메시지 표시 형식                              |
|`OFFICIAL_MESSAGE`| 아니오   | BOT 내 공식 계정 메시지 표시 형식                              |
|`CONTACT_MESSAGE`| 아니오   | BOT 내 WeChat 사용자 메시지 표시 형식                            |
|`ROOM_MESSAGE_GROUP`| 아니오   | 그룹 내 WeChat 그룹 메시지 표시 형식                             |
|`CONTACT_MESSAGE_GROUP`| 아니오   | 그룹 내 WeChat 사용자 메시지 표시 형식                           |
|`OFFICIAL_MESSAGE_GROUP`| 아니오   | 그룹 내 공식 계정 메시지 표시 형식                              |
|`CREATE_ROOM_NAME`| 아니오   | WeChat 그룹 자동 생성 시 그룹명 형식                              |
|`CREATE_CONTACT_NAME`| 아니오   | WeChat 연락처 자동 생성 시 그룹명 형식                            |
|`MESSAGE_DISPLAY`| 아니오   | 텍스트 메시지 표시 형식                                         |

 ---

### 설정 항목 `/settings` 명령어 설명

1. WeChat emoji를 이미지 링크로 표시: 활성화 시 친구가 보낸 이모티콘(노란 얼굴)이 이미지 링크로 표시됨

2. 시작 시 그룹 정보 동기화: 활성화 시 프로그램 시작 시점에 모든 정보 동기화, 그룹 프로필 및 이름 갱신

---

### 음성 → 문자 변환

1. `TENCENT_SECRET_ID`, `TENCENT_SECRET_KEY`를 설정(텐센트 [음성인식 콘솔](https://console.cloud.tencent.com/asr)에서 발급, 무료 사용 가능)
2. `/settings`에서 자동 음성→문자 변환 활성화

---

### `API_ID`와 `API_HASH` 얻기

1. [telegram account](https://my.telegram.org/)에 로그인

2. 「API development tools」 클릭 후 앱 정보 입력(앱명과 약칭만 필요)

3. 마지막으로 「Create application」 클릭

---

### 사용자 정의 메시지 템플릿

메시지 발신자 형식을 변경하고 싶다면 docker 환경 변수 또는 `.env` 파일을 수정하면 됩니다.

사용자 정의 메시지 템플릿 치환자:

`#[alias]`: 연락처 메모

`#[name]`: 연락처 닉네임

`#[topic]`: 그룹 채팅명

`#[alias_first]`: 메모 우선, 없으면 닉네임 표시

`#[identity]`: 신분 정보 텍스트

`#[body]`: 메시지 본문

`#[br]`: 줄바꿈

### @전체(모두) 하는 방법

`@all`로 시작하는 메시지를 보내면 @전체가 됩니다. 텍스트 메시지에만 지원합니다.

---

## 자주 묻는 질문


## 개발 참여

1. 프로젝트를 fork 한 뒤, `wx2tg-mac-dev` 브랜치로 전환 또는 새 브랜치 생성. 메인 브랜치에 직접 코드 제출 금지
2. `wx2tg-mac-dev` 브랜치로 Pull Request 제출


## 라이선스

[MIT](https://raw.githubusercontent.com/finalpi/wechat2tg/wx2tg-mac/LICENSE)


## Thanks

Jetbrains의 본 프로젝트 지원에 감사드립니다.

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---