# GPT-Load

中文文档 | [English](https://raw.githubusercontent.com/tbphp/gpt-load/main/README_EN.md)

[![Release](https://img.shields.io/github/v/release/tbphp/gpt-load)](https://github.com/tbphp/gpt-load/releases)
![Go Version](https://img.shields.io/badge/Go-1.23+-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

고성능, 엔터프라이즈급 AI 인터페이스 투명 프록시 서비스로, 다양한 AI 서비스를 통합해야 하는 기업과 개발자를 위해 설계되었습니다. Go 언어로 개발되었으며, 스마트 키 관리, 부하 분산 및 완벽한 모니터링 기능을 갖추고 있어 고동시성 생산 환경에 최적화되어 있습니다.

자세한 내용은 [공식 문서](https://www.gpt-load.com/docs)를 참고하세요.

<a href="https://hellogithub.com/repository/tbphp/gpt-load" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=554dc4c46eb14092b9b0c56f1eb9021c&claim_uid=Qlh8vzrWJ0HCneG" alt="Featured｜HelloGitHub" style="width: 250px; height: 54px;" width="250" height="54" /></a>

## 기능 특징

- **투명 프록시**: 원본 API 형식을 완전히 유지하며 OpenAI, Google Gemini, Anthropic Claude 등 다양한 형식 지원
- **스마트 키 관리**: 고성능 키 풀, 그룹 관리, 자동 교체 및 장애 복구 지원
- **부하 분산**: 다수의 상위 엔드포인트에 대한 가중 부하 분산 지원으로 서비스 가용성 향상
- **스마트 장애 처리**: 자동 키 블랙리스트 관리 및 복구 메커니즘으로 서비스 연속성 보장
- **동적 구성**: 시스템 설정과 그룹 구성을 핫 리로드 지원, 재시작 없이 즉시 적용 가능
- **엔터프라이즈 아키텍처**: 분산 마스터-슬레이브 배포, 수평 확장 및 고가용성 지원
- **현대적 관리**: Vue 3 기반 웹 관리 인터페이스, 직관적이고 사용 용이
- **포괄적 모니터링**: 실시간 통계, 헬스 체크, 상세 요청 로그 제공
- **고성능 설계**: 제로 카피 스트리밍, 커넥션 풀 재사용, 원자적 연산
- **프로덕션 준비 완료**: 우아한 종료, 오류 복구, 완벽한 보안 메커니즘
- **이중 인증 체계**: 관리측과 프록시측 인증 분리, 프록시 인증은 전역 및 그룹별 키 지원

## 지원하는 AI 서비스

GPT-Load는 투명 프록시 서비스로 각 AI 서비스 제공자의 원본 API 형식을 완벽히 보존합니다:

- **OpenAI 형식**: 공식 OpenAI API, Azure OpenAI 및 기타 OpenAI 호환 서비스
- **Google Gemini 형식**: Gemini Pro, Gemini Pro Vision 등 모델의 원본 API
- **Anthropic Claude 형식**: Claude 시리즈 모델, 고품질 대화 및 텍스트 생성 지원

## 빠른 시작

### 환경 요구 사항

- Go 1.23+ (소스 코드 빌드)
- Docker (컨테이너화 배포)
- MySQL, PostgreSQL, 또는 SQLite (데이터베이스 저장)
- Redis (캐시 및 분산 조정, 선택 사항)

### 방법 1: Docker 빠른 시작

```bash
docker run -d --name gpt-load \
    -p 3001:3001 \
    -e AUTH_KEY=sk-123456 \
    -v "$(pwd)/data":/app/data \
    ghcr.io/tbphp/gpt-load:latest
```
> `sk-123456`를 사용하여 관리 페이지에 로그인하세요: <http://localhost:3001>

### 방법 2: Docker Compose 사용 (권장)

**설치 명령어:**


```bash
# 创建目录
mkdir -p gpt-load && cd gpt-load

# 下载配置文件
wget https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/docker-compose.yml
wget -O .env https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/.env.example

# 启动服务
docker compose up -d
```
기본적으로 설치되는 것은 SQLite 버전으로, 경량 단일기기 애플리케이션에 적합합니다.

MySQL, PostgreSQL 및 Redis를 설치하려면 `docker-compose.yml` 파일에서 필요한 서비스의 주석을 해제하고 해당 환경 구성을 설정한 후 재시작하면 됩니다.

**기타 명령어:**


```bash
# 查看服务状态
docker compose ps

# 查看日志
docker compose logs -f

# 重启服务
docker compose down && docker compose up -d

# 更新到最新版本
docker compose pull && docker compose down && docker compose up -d
```
배포 완료 후：

- 웹 관리 인터페이스 접속: <http://localhost:3001>
- API 프록시 주소: <http://localhost:3001/proxy>

> 기본 인증 키 `sk-123456`로 관리 콘솔에 로그인하며, 인증 키는 .env 파일의 AUTH_KEY에서 변경할 수 있습니다.

### 방법 3: 소스 코드 빌드

소스 코드 빌드는 로컬에 데이터베이스(SQLite, MySQL 또는 PostgreSQL)와 Redis(선택 사항)가 설치되어 있어야 합니다.


```bash
# 克隆并构建
git clone https://github.com/tbphp/gpt-load.git
cd gpt-load
go mod tidy

# 创建配置
cp .env.example .env

# 修改 .env 中 DATABASE_DSN 和 REDIS_DSN 配置
# REDIS_DSN 为可选，如果不配置则启用内存存储

# 运行
make run
```
배포 완료 후：

- 웹 관리 인터페이스 접속: <http://localhost:3001>
- API 프록시 주소: <http://localhost:3001/proxy>

> 기본 인증 Key `sk-123456`로 관리 페이지에 로그인합니다. 인증 Key는 .env 파일에서 AUTH_KEY를 수정하여 변경할 수 있습니다.

### 방법 4: 클러스터 배포

클러스터 배포는 모든 노드가 동일한 MySQL(또는 PostgreSQL)과 Redis에 연결되어야 하며, Redis는 필수입니다. 통합 분산 MySQL 및 Redis 클러스터 사용을 권장합니다.

**배포 요구사항:**

- 모든 노드는 동일한 `AUTH_KEY`, `DATABASE_DSN`, `REDIS_DSN`을 설정해야 합니다.
- 마스터-슬레이브 구조에서 슬레이브 노드는 환경 변수 `IS_SLAVE=true`를 설정해야 합니다.

자세한 내용은 [클러스터 배포 문서](https://www.gpt-load.com/docs/cluster)를 참고하세요.

## 시스템 구성

### 구성 아키텍처 개요

GPT-Load는 이중 구성 아키텍처를 사용합니다:

#### 1. 정적 구성(환경 변수)

- **특징**: 애플리케이션 시작 시 읽으며, 실행 중에는 수정할 수 없고 재시작해야 적용됨
- **용도**: 데이터베이스 연결, 서버 포트, 인증 키 등 인프라 구성
- **관리 방법**: `.env` 파일 또는 시스템 환경 변수로 설정

#### 2. 동적 구성(핫 리로드)

- **시스템 설정**: 데이터베이스에 저장되며, 전체 애플리케이션에 일관된 동작 기준 제공
- **그룹 구성**: 특정 그룹에 맞춘 동작 매개변수로 시스템 설정을 덮어쓸 수 있음
- **구성 우선순위**: 그룹 구성 > 시스템 설정 > 환경 구성
- **특징**: 핫 리로드 지원, 수정 즉시 적용, 애플리케이션 재시작 불필요

<details>
<summary>정적 구성(환경 변수)</summary>

**서버 구성:**

| 구성 항목     | 환경 변수                        | 기본값           | 설명                         |
| ------------ | -------------------------------- | ---------------- | ---------------------------- |
| 서버 포트    | `PORT`                          | 3001             | HTTP 서버 수신 포트           |
| 서버 주소    | `HOST`                          | 0.0.0.0          | HTTP 서버 바인딩 주소         |
| 읽기 타임아웃 | `SERVER_READ_TIMEOUT`           | 60               | HTTP 서버 읽기 타임아웃(초)   |
| 쓰기 타임아웃 | `SERVER_WRITE_TIMEOUT`          | 600              | HTTP 서버 쓰기 타임아웃(초)   |
| 유휴 타임아웃 | `SERVER_IDLE_TIMEOUT`           | 120              | HTTP 연결 유휴 타임아웃(초)   |
| 우아한 종료 타임아웃 | `SERVER_GRACEFUL_SHUTDOWN_TIMEOUT` | 10               | 서비스 우아한 종료 대기 시간(초) |
| 슬레이브 모드 | `IS_SLAVE`                      | false            | 클러스터 배포 시 슬레이브 표시  |
| 시간대       | `TZ`                            | `Asia/Shanghai`  | 지정 시간대                   |

**인증 및 데이터베이스 구성:**

| 구성 항목   | 환경 변수        | 기본값              | 설명                                 |
| ---------- | --------------- | ------------------- | ------------------------------------ |
| 관리 키    | `AUTH_KEY`      | `sk-123456`         | **관리자** 접근 인증 키              |
| 데이터베이스 연결 | `DATABASE_DSN`  | ./data/gpt-load.db  | 데이터베이스 연결 문자열(DSN) 또는 파일 경로 |
| Redis 연결 | `REDIS_DSN`     | -                   | Redis 연결 문자열, 비어 있으면 메모리 저장 사용 |

**성능 및 CORS 구성:**

| 구성 항목      | 환경 변수                 | 기본값                         | 설명                     |
| ------------ | -------------------------- | ------------------------------ | ------------------------ |
| 최대 동시 요청 | `MAX_CONCURRENT_REQUESTS`  | 100                            | 시스템 허용 최대 동시 요청 수 |
| CORS 활성화   | `ENABLE_CORS`              | true                           | CORS(교차 출처 자원 공유) 활성화 여부 |
| 허용 출처     | `ALLOWED_ORIGINS`          | `*`                            | 허용 출처, 쉼표 구분       |
| 허용 메서드   | `ALLOWED_METHODS`          | `GET,POST,PUT,DELETE,OPTIONS`  | 허용 HTTP 메서드           |
| 허용 헤더     | `ALLOWED_HEADERS`          | `*`                            | 허용 요청 헤더, 쉼표 구분  |
| 자격 증명 허용 | `ALLOW_CREDENTIALS`        | false                          | 자격 증명 전송 허용 여부    |

**로그 구성:**

| 구성 항목      | 환경 변수           | 기본값               | 설명                                  |
| ------------ | ------------------ | -------------------- | ------------------------------------- |
| 로그 레벨    | `LOG_LEVEL`        | `info`               | 로그 레벨: debug, info, warn, error   |
| 로그 형식    | `LOG_FORMAT`       | `text`               | 로그 형식: text, json                  |
| 파일 로그 활성화 | `LOG_ENABLE_FILE`  | false                | 파일 로그 출력 활성화 여부             |

| 로그 파일 경로 | `LOG_FILE_PATH`   | `./data/logs/app.log` | 로그 파일 저장 경로                   |

**프록시 설정：**

GPT-Load는 환경 변수에서 프록시 설정을 자동으로 읽어 상위 AI 서비스 제공자에 요청을 보냅니다.

| 설정 항목    | 환경 변수      | 기본값 | 설명                                     |
| ------------ | ------------- | ------ | ---------------------------------------- |
| HTTP 프록시  | `HTTP_PROXY`  | -      | HTTP 요청에 사용하는 프록시 서버 주소     |
| HTTPS 프록시 | `HTTPS_PROXY` | -      | HTTPS 요청에 사용하는 프록시 서버 주소    |
| 프록시 제외  | `NO_PROXY`    | -      | 프록시를 사용하지 않는 호스트나 도메인, 쉼표로 구분 |

지원하는 프록시 프로토콜 형식:

- **HTTP**: `http://user:pass@host:port`
- **HTTPS**: `https://user:pass@host:port`
- **SOCKS5**: `socks5://user:pass@host:port`
</details>

<details>
<summary>동적 설정(핫 리로드)</summary>

**기본 설정：**

| 설정 항목        | 필드명                               | 기본값                      | 그룹 덮어쓰기 가능 | 설명                                   |
| --------------- | ---------------------------------- | --------------------------- | ----------------- | -------------------------------------- |
| 프로젝트 주소    | `app_url`                          | `http://localhost:3001`     | ❌                | 프로젝트 기본 URL                      |
| 로그 보존 일수   | `request_log_retention_days`       | 7                           | ❌                | 요청 로그 보존 일수, 0이면 삭제 안 함  |
| 로그 기록 간격   | `request_log_write_interval_minutes` | 1                           | ❌                | 로그를 데이터베이스에 기록하는 주기(분) |
| 전역 프록시 키  | `proxy_keys`                       | 초기값은 환경 변수 AUTH_KEY  | ❌                | 전역으로 적용되는 프록시 인증 키, 여러 개는 쉼표로 구분 |

**요청 설정：**

| 설정 항목         | 필드명                    | 기본값 | 그룹 덮어쓰기 가능 | 설명                           |
| ---------------- | ------------------------- | ------ | ----------------- | ------------------------------ |
| 요청 타임아웃    | `request_timeout`         | 600    | ✅                | 요청 전체 생명주기 타임아웃(초) |
| 연결 타임아웃    | `connect_timeout`         | 15     | ✅                | 상위 서비스 연결 타임아웃(초)   |
| 유휴 연결 타임아웃 | `idle_conn_timeout`       | 120    | ✅                | HTTP 클라이언트 유휴 연결 타임아웃(초) |
| 응답 헤더 타임아웃 | `response_header_timeout` | 600    | ✅                | 상위 응답 헤더 대기 타임아웃(초) |
| 최대 유휴 연결 수 | `max_idle_conns`          | 100    | ✅                | 커넥션 풀 최대 유휴 연결 수     |
| 매 호스트 최대 유휴 연결 수 | `max_idle_conns_per_host` | 50     | ✅         | 각 업스트림 호스트의 최대 유휴 연결 수             |
| 프록시 서버 주소           | `proxy_url`               | -      | ✅         | 요청 전달에 사용하는 HTTP/HTTPS 프록시, 비어있으면 환경 설정 사용 |

**키 구성:**

| 구성 항목       | 필드명                              | 기본값 | 그룹 덮어쓰기 가능 | 설명                                               |
| -------------- | ---------------------------------- | ------ | ----------------- | -------------------------------------------------- |
| 최대 재시도 횟수 | `max_retries`                      | 3      | ✅                | 단일 요청에서 다른 키를 사용하는 최대 재시도 횟수 |
| 블랙리스트 임계값 | `blacklist_threshold`              | 3      | ✅                | 키가 연속 실패한 횟수 후 블랙리스트로 진입         |
| 키 검증 간격    | `key_validation_interval_minutes` | 60     | ✅                | 백그라운드 정기 키 검증 주기(분)                   |
| 키 검증 동시성  | `key_validation_concurrency`       | 10     | ✅                | 백그라운드 정기 무효 키 검증 시 동시 처리 수       |
| 키 검증 타임아웃 | `key_validation_timeout_seconds`   | 20     | ✅                | 백그라운드 정기 단일 키 API 요청 타임아웃(초)      |

</details>

## 웹 관리 인터페이스

관리 콘솔 접속: <http://localhost:3001> (기본 주소)

### 인터페이스 화면

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/dashboard.png" alt="대시보드" width="600" />

<br/>

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/keys.png" alt="키 관리" width="600" />

<br/>

웹 관리 인터페이스는 다음 기능을 제공합니다:

- **대시보드**: 실시간 통계 정보 및 시스템 상태 개요
- **키 관리**: AI 서비스 제공자 그룹 생성 및 구성, API 키 추가, 삭제 및 모니터링
- **요청 로그**: 자세한 요청 이력 및 디버깅 정보
- **시스템 설정**: 전역 구성 관리 및 핫 리로드

## API 사용 설명

<details>
<summary>프록시 인터페이스 호출 방법</summary>
GPT-Load는 그룹 이름을 통해 요청을 서로 다른 AI 서비스로 라우팅합니다. 사용 방법은 다음과 같습니다:

#### 1. 프록시 엔드포인트 형식


```text
http://localhost:3001/proxy/{group_name}/{原始API路径}
```
- `{group_name}`: 관리 인터페이스에서 생성한 그룹 이름  
- `{原始API路径}`: 원래 AI 서비스와 완전히 동일한 경로 유지  

#### 2. 인증 방식  

웹 관리 인터페이스에서 **프록시 키** (`Proxy Keys`)를 구성할 수 있으며, 시스템 수준과 그룹 수준의 프록시 키를 설정할 수 있습니다.  

- **인증 방식**: 원본 API와 동일하지만 원래 키 대신 구성된 프록시 키를 사용해야 합니다.  
- **키 범위**: 시스템 설정에서 구성된 **전역 프록시 키**는 모든 그룹에서 사용할 수 있고, 그룹에서 구성된 **그룹 프록시 키**는 현재 그룹에서만 유효합니다.  
- **형식**: 여러 키는 반각 쉼표로 구분합니다.  

#### 3. OpenAI 인터페이스 호출 예시  

`openai`라는 이름의 그룹을 생성했다고 가정:  

**원본 호출 방식:**  


```bash
curl -X POST https://api.openai.com/v1/chat/completions \
  -H "Authorization: Bearer sk-your-openai-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**대리 호출 방식：**

```bash
curl -X POST http://localhost:3001/proxy/openai/v1/chat/completions \
  -H "Authorization: Bearer your-proxy-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**변경 사항 설명：**

- `https://api.openai.com`을 `http://localhost:3001/proxy/openai`로 교체
- 원래 API 키를 **프록시 키**로 교체

#### 4. Gemini 인터페이스 호출 예제

`gemini`라는 그룹을 생성했다고 가정：

**원본 호출 방식：**

```bash
curl -X POST https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key=your-gemini-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**대리 호출 방식：**

```bash
curl -X POST http://localhost:3001/proxy/gemini/v1beta/models/gemini-2.5-pro:generateContent?key=your-proxy-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**변경 설명:**

- `https://generativelanguage.googleapis.com`를 `http://localhost:3001/proxy/gemini`로 교체
- URL 매개변수의 `key=your-gemini-key`를 **프록시 키**로 교체

#### 5. Anthropic 인터페이스 호출 예시

`anthropic`라는 이름의 그룹을 생성했다고 가정:

**원본 호출 방식:**

```bash
curl -X POST https://api.anthropic.com/v1/messages \
  -H "x-api-key: sk-ant-api03-your-anthropic-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**대리 호출 방식：**

```bash
curl -X POST http://localhost:3001/proxy/anthropic/v1/messages \
  -H "x-api-key: your-proxy-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**변경 설명:**

- `https://api.anthropic.com` 를 `http://localhost:3001/proxy/anthropic` 로 변경
- `x-api-key` 헤더의 원래 API 키를 **프록시 키**로 변경

#### 6. 지원되는 인터페이스

**OpenAI 형식:**

- `/v1/chat/completions` - 채팅 대화
- `/v1/completions` - 텍스트 보완
- `/v1/embeddings` - 텍스트 임베딩
- `/v1/models` - 모델 목록
- 그리고 기타 모든 OpenAI 호환 인터페이스

**Gemini 형식:**

- `/v1beta/models/*/generateContent` - 콘텐츠 생성
- `/v1beta/models` - 모델 목록
- 그리고 기타 모든 Gemini 원본 인터페이스

**Anthropic 형식:**

- `/v1/messages` - 메시지 대화
- `/v1/models` - 모델 목록(사용 가능한 경우)
- 그리고 기타 모든 Anthropic 원본 인터페이스

#### 7. 클라이언트 SDK 구성

**OpenAI Python SDK:**

```python
from openai import OpenAI

client = OpenAI(
    api_key="your-proxy-key",  # 使用密钥
    base_url="http://localhost:3001/proxy/openai"  # 使用代理端点
)

response = client.chat.completions.create(
    model="gpt-4.1-mini",
    messages=[{"role": "user", "content": "Hello"}]
)
```

**Google Gemini SDK (파이썬)：**

```python
import google.generativeai as genai

# 配置 API 密钥和基础 URL
genai.configure(
    api_key="your-proxy-key",  # 使用代理密钥
    client_options={"api_endpoint": "http://localhost:3001/proxy/gemini"}
)

model = genai.GenerativeModel('gemini-2.5-pro')
response = model.generate_content("Hello")
```

**Anthropic SDK (파이썬)：**

```python
from anthropic import Anthropic

client = Anthropic(
    api_key="your-proxy-key",  # 使用代理密钥
    base_url="http://localhost:3001/proxy/anthropic"  # 使用代理端点
)

response = client.messages.create(
    model="claude-sonnet-4-20250514",
    messages=[{"role": "user", "content": "Hello"}]
)
```

> **중요 알림**: 투명 프록시 서비스로서, GPT-Load는 각 AI 서비스의 원본 API 형식과 인증 방식을 완전히 유지하며, 엔드포인트 주소만 교체하고 관리 측에서 구성한 **프록시 키**를 사용하면 원활한 이전이 가능합니다.

</details>

## 라이선스

MIT 라이선스 - 자세한 내용은 [LICENSE](LICENSE) 파일을 참조하십시오.

## Star History

[![Stargazers over time](https://starchart.cc/tbphp/gpt-load.svg?variant=adaptive)](https://starchart.cc/tbphp/gpt-load)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---