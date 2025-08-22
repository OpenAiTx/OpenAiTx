# GPT-Load

Chinese Document | [English](https://raw.githubusercontent.com/tbphp/gpt-load/main/README_EN.md)

[![Release](https://img.shields.io/github/v/release/tbphp/gpt-load)](https://github.com/tbphp/gpt-load/releases)
![Go Version](https://img.shields.io/badge/Go-1.23+-blue.svg)
![License](https://img.shields.io/badge/license-MIT-green.svg)

A high-performance, enterprise-grade AI interface transparent proxy service, specially designed for enterprises and developers who need to integrate multiple AI services. Developed in Go, it features intelligent key management, load balancing, and comprehensive monitoring, specifically designed for high-concurrency production environments.

For details, please refer to the [official documentation](https://www.gpt-load.com/docs)

<a href="https://hellogithub.com/repository/tbphp/gpt-load" target="_blank"><img src="https://api.hellogithub.com/v1/widgets/recommend.svg?rid=554dc4c46eb14092b9b0c56f1eb9021c&claim_uid=Qlh8vzrWJ0HCneG" alt="Featured｜HelloGitHub" style="width: 250px; height: 54px;" width="250" height="54" /></a>

## Features

- **Transparent Proxy**: Fully retains the native API format, supporting multiple formats such as OpenAI, Google Gemini, and Anthropic Claude
- **Intelligent Key Management**: High-performance key pool, supporting group management, automatic rotation, and fault recovery
- **Load Balancing**: Supports weighted load balancing across multiple upstream endpoints to improve service availability
- **Intelligent Fault Handling**: Automatic key blacklist management and recovery mechanism to ensure service continuity
- **Dynamic Configuration**: System settings and group configurations support hot reloads, effective without restarting
- **Enterprise-grade Architecture**: Distributed master-slave deployment, supporting horizontal scaling and high availability
- **Modern Management**: Web management interface based on Vue 3, intuitive and user-friendly
- **Comprehensive Monitoring**: Real-time statistics, health checks, detailed request logs
- **High-performance Design**: Zero-copy streaming transmission, connection pool reuse, atomic operations
- **Production Ready**: Graceful shutdown, error recovery, complete security mechanisms
- **Dual Authentication System**: Separate authentication for management and proxy ends; proxy authentication supports global and group-level keys

## Supported AI Services

As a transparent proxy service, GPT-Load fully retains the native API formats of various AI providers:

- **OpenAI Format**: Official OpenAI API, Azure OpenAI, and other OpenAI-compatible services
- **Google Gemini Format**: Native APIs for models like Gemini Pro, Gemini Pro Vision, etc.
- **Anthropic Claude Format**: Claude series models, supporting high-quality dialogue and text generation

## Quick Start

### Environment Requirements

- Go 1.23+ (Source Code Build)
- Docker (Containerized Deployment)
- MySQL, PostgreSQL, or SQLite (Database Storage)
- Redis (Caching and Distributed Coordination, Optional)

### Method 1: Docker Quick Start

```bash
docker run -d --name gpt-load \
    -p 3001:3001 \
    -e AUTH_KEY=sk-123456 \
    -v "$(pwd)/data":/app/data \
    ghcr.io/tbphp/gpt-load:latest
```

> Log in to the management interface using `sk-123456`: <http://localhost:3001>

### Method 2: Using Docker Compose (Recommended)

**Installation command:**

```bash
# 创建目录
mkdir -p gpt-load && cd gpt-load

# 下载配置文件
wget https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/docker-compose.yml
wget -O .env https://raw.githubusercontent.com/tbphp/gpt-load/refs/heads/main/.env.example

# 启动服务
docker compose up -d
```

The default installation is the SQLite version, suitable for lightweight standalone applications.

If you need to install MySQL, PostgreSQL, and Redis, please uncomment the required services in the `docker-compose.yml` file and configure the corresponding environment settings before restarting.

**Other commands:**

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

After deployment:

- Access the Web management interface: <http://localhost:3001>
- API proxy address: <http://localhost:3001/proxy>

> Use the default authentication Key `sk-123456` to log in to the management console, the authentication Key can be modified in the .env file under AUTH_KEY.

### Method 3: Source Code Build

Source code build requires a locally installed database (SQLite, MySQL, or PostgreSQL) and Redis (optional).

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
After deployment:

- Access the Web management interface: <http://localhost:3001>
- API proxy address: <http://localhost:3001/proxy>

> Use the default authentication Key `sk-123456` to log in to the management end, the authentication Key can be modified in the .env file under AUTH_KEY.

### Method 4: Cluster Deployment

Cluster deployment requires all nodes to connect to the same MySQL (or PostgreSQL) and Redis, and Redis is mandatory. It is recommended to use unified distributed MySQL and Redis clusters.

**Deployment requirements:**

- All nodes must configure the same `AUTH_KEY`, `DATABASE_DSN`, `REDIS_DSN`
- Master-slave architecture, slave nodes must configure the environment variable: `IS_SLAVE=true`

For details, please refer to the [Cluster Deployment Documentation](https://www.gpt-load.com/docs/cluster)

## Configure the System

### Configuration Architecture Overview

GPT-Load adopts a two-layer configuration architecture:

#### 1. Static Configuration (Environment Variables)

- **Features**: Read at application startup, cannot be modified during runtime, requires application restart to take effect
- **Purpose**: Infrastructure configuration such as database connection, server port, authentication keys, etc.
- **Management method**: Set via `.env` file or system environment variables

#### 2. Dynamic Configuration (Hot Reload)

- **System settings**: Stored in the database, providing a unified behavioral baseline for the entire application
- **Group configuration**: Customized behavioral parameters for specific groups, can override system settings
- **Configuration priority**: Group configuration > System settings > Environment configuration
- **Features**: Supports hot reload, takes effect immediately after modification, no need to restart the application

<details>
<summary>Static Configuration (Environment Variables)</summary>


**Server Configuration:**

| Configuration Item | Environment Variable               | Default Value   | Description                 |
| ------------------ | -------------------------------- | --------------- | --------------------------- |
| Server Port        | `PORT`                           | 3001            | HTTP server listening port  |
| Server Address     | `HOST`                           | 0.0.0.0         | HTTP server bind address    |
| Read Timeout       | `SERVER_READ_TIMEOUT`            | 60              | HTTP server read timeout (seconds)  |
| Write Timeout      | `SERVER_WRITE_TIMEOUT`           | 600             | HTTP server write timeout (seconds) |
| Idle Timeout       | `SERVER_IDLE_TIMEOUT`            | 120             | HTTP connection idle timeout (seconds) |
| Graceful Shutdown Timeout | `SERVER_GRACEFUL_SHUTDOWN_TIMEOUT` | 10              | Service graceful shutdown wait time (seconds) |
| Slave Mode         | `IS_SLAVE`                      | false           | Slave node identifier in cluster deployment |
| Time Zone          | `TZ`                             | `Asia/Shanghai` | Specified time zone         |

**Authentication and Database Configuration:**

| Configuration Item | Environment Variable | Default Value      | Description                        |
| ------------------ | --------------------| ------------------ | --------------------------------- |
| Admin Key          | `AUTH_KEY`          | `sk-123456`       | Access authentication key for **admin** |
| Database Connection| `DATABASE_DSN`      | ./data/gpt-load.db | Database connection string (DSN) or file path |
| Redis Connection   | `REDIS_DSN`         | -                  | Redis connection string, uses in-memory storage if empty |

**Performance and CORS Configuration:**

| Configuration Item    | Environment Variable       | Default Value                 | Description               |
| --------------------- | --------------------------| -----------------------------| ------------------------- |
| Max Concurrent Requests| `MAX_CONCURRENT_REQUESTS` | 100                          | Maximum concurrent requests allowed by the system |
| Enable CORS           | `ENABLE_CORS`             | true                         | Whether to enable Cross-Origin Resource Sharing |
| Allowed Origins       | `ALLOWED_ORIGINS`         | `*`                          | Allowed origins, comma-separated |
| Allowed Methods       | `ALLOWED_METHODS`         | `GET,POST,PUT,DELETE,OPTIONS`| Allowed HTTP methods        |
| Allowed Headers       | `ALLOWED_HEADERS`         | `*`                          | Allowed request headers, comma-separated |
| Allow Credentials     | `ALLOW_CREDENTIALS`       | false                        | Whether to allow sending credentials |

**Logging Configuration:**

| Configuration Item | Environment Variable    | Default Value | Description                         |
| ------------------ | -----------------------| ------------- | ---------------------------------- |
| Log Level          | `LOG_LEVEL`            | `info`       | Log level: debug, info, warn, error |
| Log Format         | `LOG_FORMAT`           | `text`       | Log format: text, json              |
| Enable File Logging| `LOG_ENABLE_FILE`      | false        | Whether to enable file log output  |
| Log File Path | `LOG_FILE_PATH`   | `./data/logs/app.log` | Log file storage path                   |

**Proxy Configuration:**

GPT-Load will automatically read proxy settings from environment variables for requests to upstream AI providers.

| Config Item   | Environment Variable | Default | Description                              |
| ------------- | -------------------- | ------- | -------------------------------------- |
| HTTP Proxy    | `HTTP_PROXY`         | -       | Proxy server address for HTTP requests |
| HTTPS Proxy   | `HTTPS_PROXY`        | -       | Proxy server address for HTTPS requests|
| No Proxy      | `NO_PROXY`           | -       | Hosts or domains not accessed via proxy, comma-separated |

Supported proxy protocol formats:

- **HTTP**: `http://user:pass@host:port`
- **HTTPS**: `https://user:pass@host:port`
- **SOCKS5**: `socks5://user:pass@host:port`
</details>

<details>
<summary>Dynamic Configuration (Hot Reload)</summary>

**Basic Settings:**

| Config Item          | Field Name                        | Default                      | Group Overridable | Description                            |
| -------------------- | -------------------------------- | ----------------------------| ----------------- | -------------------------------------|
| Project URL          | `app_url`                        | `http://localhost:3001`      | ❌                | Base URL of the project               |
| Log Retention Days   | `request_log_retention_days`      | 7                            | ❌                | Request log retention days, 0 means no cleanup |
| Log Write Interval   | `request_log_write_interval_minutes` | 1                           | ❌                | Log write interval to database (minutes) |
| Global Proxy Keys    | `proxy_keys`                     | Initially from environment AUTH_KEY | ❌         | Globally effective proxy authentication keys, separated by commas |

**Request Settings:**

| Config Item           | Field Name                  | Default | Group Overridable | Description                        |
| --------------------- | --------------------------- | ------- | ----------------- | ---------------------------------|
| Request Timeout       | `request_timeout`           | 600     | ✅                | Full lifecycle timeout for forwarded requests (seconds) |
| Connect Timeout       | `connect_timeout`           | 15      | ✅                | Timeout for establishing connection with upstream service (seconds) |
| Idle Connection Timeout | `idle_conn_timeout`        | 120     | ✅                | HTTP client idle connection timeout (seconds) |
| Response Header Timeout | `response_header_timeout`  | 600     | ✅                | Timeout waiting for upstream response headers (seconds) |
| Max Idle Connections  | `max_idle_conns`            | 100     | ✅                | Maximum total idle connections in the connection pool |
| Max Idle Connections Per Host | `max_idle_conns_per_host` | 50     | ✅         | Maximum idle connections per upstream host     |
| Proxy Server Address           | `proxy_url`               | -      | ✅         | HTTP/HTTPS proxy for forwarding requests, empty to use environment settings |

**Key Configuration:**

| Item                     | Field Name                         | Default | Group Override | Description                                             |
| ------------------------ | --------------------------------- | ------- | -------------- | ------------------------------------------------------- |
| Max Retry Count          | `max_retries`                     | 3       | ✅             | Maximum retry count using different keys per request   |
| Blacklist Threshold      | `blacklist_threshold`             | 3       | ✅             | Number of consecutive failures before a key is blacklisted |
| Key Validation Interval  | `key_validation_interval_minutes`| 60      | ✅             | Background periodic key validation interval (minutes)  |
| Key Validation Concurrency | `key_validation_concurrency`    | 10      | ✅             | Concurrency for background invalid key validation       |
| Key Validation Timeout   | `key_validation_timeout_seconds` | 20      | ✅             | API request timeout for single key validation (seconds) |

</details>

## Web Management Interface

Access the management console: <http://localhost:3001> (default address)

### Interface Display

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/dashboard.png" alt="Dashboard" width="600" />

<br/>

<img src="https://raw.githubusercontent.com/tbphp/gpt-load/main/screenshot/keys.png" alt="Key Management" width="600" />

<br/>

The web management interface provides the following features:

- **Dashboard**: Real-time statistics and system status overview
- **Key Management**: Create and configure AI provider groups, add, delete, and monitor API keys
- **Request Logs**: Detailed request history and debugging information
- **System Settings**: Global configuration management and hot reload

## API Usage Instructions

<details>
<summary>Proxy Interface Call Method</summary>

GPT-Load routes requests to different AI services through group names. Usage is as follows:

#### 1. Proxy Endpoint Format

```text
http://localhost:3001/proxy/{group_name}/{原始API路径}
```

- `{group_name}`: The group name created in the management interface  
- `{original API path}`: The path exactly consistent with the original AI service  

#### 2. Authentication Method  

Configure **Proxy Keys** in the Web management interface, allowing system-level and group-level proxy keys.  

- **Authentication method**: Same as the native API, but the original key must be replaced with the configured proxy key.  
- **Key scope**: The **global proxy key** configured in system settings can be used in all groups, while the **group proxy key** configured in the group is only valid in the current group.  
- **Format**: Multiple keys are separated by half-width English commas.  

#### 3. OpenAI API Call Example  

Assuming a group named `openai` is created:  

**Original call method:**

```bash
curl -X POST https://api.openai.com/v1/chat/completions \
  -H "Authorization: Bearer sk-your-openai-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Proxy Invocation Method:**

```bash
curl -X POST http://localhost:3001/proxy/openai/v1/chat/completions \
  -H "Authorization: Bearer your-proxy-key" \
  -H "Content-Type: application/json" \
  -d '{"model": "gpt-4.1-mini", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Change Description:**

- Replace `https://api.openai.com` with `http://localhost:3001/proxy/openai`
- Replace the original API Key with the **proxy key**

#### 4. Gemini Interface Call Example

Assuming a group named `gemini` has been created:

**Original call method:**

```bash
curl -X POST https://generativelanguage.googleapis.com/v1beta/models/gemini-2.5-pro:generateContent?key=your-gemini-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Proxy invocation method:**

```bash
curl -X POST http://localhost:3001/proxy/gemini/v1beta/models/gemini-2.5-pro:generateContent?key=your-proxy-key \
  -H "Content-Type: application/json" \
  -d '{"contents": [{"parts": [{"text": "Hello"}]}]}'
```

**Change Description:**

- Replace `https://generativelanguage.googleapis.com` with `http://localhost:3001/proxy/gemini`
- Replace `key=your-gemini-key` in the URL parameters with **proxy key**

#### 5. Anthropic API Call Example

Assuming a group named `anthropic` has been created:

**Original call method:**

```bash
curl -X POST https://api.anthropic.com/v1/messages \
  -H "x-api-key: sk-ant-api03-your-anthropic-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Proxy Invocation Method:**

```bash
curl -X POST http://localhost:3001/proxy/anthropic/v1/messages \
  -H "x-api-key: your-proxy-key" \
  -H "anthropic-version: 2023-06-01" \
  -H "Content-Type: application/json" \
  -d '{"model": "claude-sonnet-4-20250514", "messages": [{"role": "user", "content": "Hello"}]}'
```

**Change Description:**

- Replace `https://api.anthropic.com` with `http://localhost:3001/proxy/anthropic`
- Replace the original API Key in the `x-api-key` header with the **proxy key**

#### 6. Supported Interfaces

**OpenAI Format:**

- `/v1/chat/completions` - Chat conversations
- `/v1/completions` - Text completions
- `/v1/embeddings` - Text embeddings
- `/v1/models` - Model list
- And all other OpenAI-compatible interfaces

**Gemini Format:**

- `/v1beta/models/*/generateContent` - Content generation
- `/v1beta/models` - Model list
- And all other native Gemini interfaces

**Anthropic Format:**

- `/v1/messages` - Message conversations
- `/v1/models` - Model list (if available)
- And all other native Anthropic interfaces

#### 7. Client SDK Configuration

**OpenAI Python SDK：**

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

**Google Gemini SDK (Python):**

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

**Anthropic SDK (Python):**

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

> **Important Note**: As a transparent proxy service, GPT-Load fully preserves the native API format and authentication methods of each AI service, requiring only the replacement of the endpoint address and the use of the **proxy key** configured in the management console for seamless migration.

</details>

## License

MIT License - For details, please refer to the [LICENSE](LICENSE) file.

## Star History

[![Stargazers over time](https://starchart.cc/tbphp/gpt-load.svg?variant=adaptive)](https://starchart.cc/tbphp/gpt-load)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-22

---