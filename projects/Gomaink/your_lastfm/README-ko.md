[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

컨테이너화된 Node.js 애플리케이션으로, **Last.fm**에서 스크로블을 동기화하고 이를 로컬 **SQLite** 데이터베이스에 저장하며 웹 대시보드를 제공합니다.

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## 프로젝트

**Your LastFM**은 Last.fm에서 음악 스크로블을 **자동으로 동기화**하도록 설계된 Node.js 애플리케이션입니다. 사용자의 청취 기록을 로컬 SQLite 데이터베이스에 저장하고, 데이터 시각화를 위한 웹 인터페이스를 제공합니다.

이 프로젝트는 **Docker**로 완전히 컨테이너화되어 있으며, 데이터베이스 초기화 및 순차적 실행(먼저 동기화, 그 다음 웹 API 실행)을 처리하는 자동화된 엔트리포인트를 사용합니다. 또한 컨테이너 내에서 프로세스 매니저로 **PM2**를 활용하여 웹 서비스가 항상 활성 상태를 유지하고 안정적으로 동작하도록 보장합니다.

## 기능
### 인터랙티브 웹 대시보드

- 음악 활동을 시각화할 수 있는 깔끔하고 현대적인 웹 인터페이스.

### 자동 Last.fm 스크로블 동기화

- 주기적으로 Last.fm에서 청취 기록(스크로블)을 가져와 저장합니다.
- 수동 개입 없이 항상 최신 데이터를 유지합니다.

### 로컬 음악 기록 데이터베이스

- 모든 스크로블을 로컬 SQLite 데이터베이스에 저장합니다.
- 빠른 쿼리와 오프라인 청취 기록 접근을 지원합니다.

### 최근 스크로블 보기

- 가장 최근 재생한 트랙을 표시합니다.
- 트랙, 앨범, 아티스트에 대한 스마트 이미지 폴백 로직을 제공합니다.

### 친구 비교 (호환성 보기)

- Last.fm 친구들과 음악 취향을 비교할 수 있습니다.
- 호환성 수준 표시 (매우 낮음 → 최고).
- 공통 상위 아티스트, 앨범 및 트랙 표시.
- 실제 청취 데이터를 기반으로 호환성 계산 및 정규화.

### 공유 가능한 음악 카드

- 청취 데이터를 기반으로 동적 이미지 생성.
- 피드 게시물 및 인스타그램 스토리용 최적화된 레이아웃 (9:16)
- 서버 측 이미지 렌더링을 위한 node-canvas 사용.

## 필수 조건

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## 설치

### `.env` 파일 생성하기

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---