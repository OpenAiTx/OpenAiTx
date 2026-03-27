
<div align="right">
  <details>
    <summary >🌐 언어</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

컨테이너화된 Node.js 애플리케이션으로, **Last.fm**에서 scrobble을 동기화하고, 이를 로컬 **SQLite** 데이터베이스에 저장하며, 웹 대시보드를 제공합니다.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## 프로젝트

**Your LastFM**은 Last.fm에서 **음악 스크로블을 자동으로 동기화**하도록 설계된 Node.js 애플리케이션입니다. 이 애플리케이션은 사용자의 청취 기록을 로컬 SQLite 데이터베이스에 보존하고, 데이터 시각화를 위한 웹 인터페이스를 제공합니다.

이 프로젝트는 **Docker**로 완전히 컨테이너화되어 있으며, 데이터베이스 초기화와 순차 실행(먼저 동기화, 그 다음 Web API 실행)을 처리하는 자동화된 엔트리포인트를 사용합니다. 또한 컨테이너 내에서 웹 서비스를 항상 활성 상태로 유지하고 복원력을 보장하기 위해 **PM2** 프로세스 관리자를 활용합니다.

## 주요 기능
### 인터랙티브 웹 대시보드

- 음악 활동을 시각화할 수 있는 깔끔하고 현대적인 웹 인터페이스.

### Last.fm 자동 스크로블 동기화

- Last.fm에서 청취 기록(스크로블)을 주기적으로 가져와 저장합니다.
- 수동 개입 없이 항상 최신 데이터로 유지합니다.

### 로컬 음악 기록 데이터베이스

- 모든 스크로블을 로컬 SQLite 데이터베이스에 영구 저장합니다.
- 빠른 쿼리와 오프라인 청취 데이터 접근이 가능합니다.

### 최근 스크로블 보기

- 가장 최근에 들은 트랙을 표시합니다.
- 트랙, 앨범, 아티스트별 스마트 이미지 폴백 로직 적용.

### 친구 비교(호환성 보기)

- Last.fm 친구와 음악 취향을 비교할 수 있습니다.
- 호환성 레벨(매우 낮음 → 슈퍼)을 표시합니다.
- 공통 상위 아티스트, 앨범, 트랙을 보여줍니다.
- 실제 청취 데이터를 기반으로 호환성을 계산 및 정규화합니다.

### 공유 가능한 뮤직 카드

- 청취 데이터를 기반으로 동적 이미지를 생성합니다.
- 피드 게시물 및 인스타그램 스토리(9:16)에 최적화된 레이아웃 제공.

- 서버 측 이미지 렌더링을 위해 node-canvas를 사용하여 구축되었습니다.

## 필수 조건

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## 설치

### `.env` 파일 생성

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```
Last.fm: API 키를 받으려면 [여기](https://www.last.fm/api/account/create)에서 API 계정을 만드세요.

### Docker Compose


```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```
터미널에서:  
`docker compose up -d`  

그런 다음 접속:

```
http://localhost:1533
```

(또는 `localhost`를 서버 IP로 교체하세요)

## 라이선스

이 프로젝트는 MIT 라이선스 하에 라이선스가 부여되었습니다.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---