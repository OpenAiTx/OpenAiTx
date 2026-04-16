
## 📖 프로젝트 소개

ASMRoner는 Go 언어 명령줄 도구로, asmr.one 음성 작품을 검색, 다운로드, 동기화하며 간단한 웹 재생 인터페이스를 제공합니다.

> 🌐 파생 작품: [asmr.furina.in](https://asmr.furina.in) — 깔끔하고 단순한 온라인 ASMR 청취 페이지

## 🚀 빠른 시작

```bash
git clone https://github.com/fireinrain/asmroner.git && cd asmroner
go build -o asmroner
./asmroner config   # 交互式初始化配置
```

## 📋 자주 사용하는 명령어

```bash
# 搜索
./asmroner search "护士" -c 20
./asmroner search "护士,-中出@duration:1h" -c 50

# 下载
./asmroner download RJ01037721 -d ./downloads
./asmroner download RJ01037721,RJ02000001 -d ./downloads
./asmroner download hot100 -n 10 -d ./downloads

# 搜索 + 下载/导出
./asmroner search download "护士" -d ./downloads -s 20
./asmroner search export "护士" -n 100 -f data.json

# 同步元数据 & 批量下载
./asmroner sync
./asmroner sync download -d ./downloads
./asmroner sync retry -d ./downloads
./asmroner sync report

# Web 播放界面
./asmroner listen -p 8080 ./syncdata
```
## 📸 스크린샷

| 설정 | 검색 |
|:---:|:---:|
| ![설정](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/config.png) | ![검색](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/search.png) |
| **다운로드** | **동기화** |
| ![다운로드](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/download.png) | ![동기화](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync.png) |
| **동기화 다운로드** | **통계** |
| ![동기화 다운로드](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-down.png) | ![통계](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/sync-report.png) |
| **웹 인터페이스** | **웹 인터페이스 2** |
| ![웹인터페이스](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen.png) | ![웹인터페이스2](https://raw.githubusercontent.com/fireinrain/asmr-downloader/v2/dist/listen2.png) |

<details>
<summary><b>✨ 기능 특성</b></summary>

- **검색**: 단일/대량 RJID, 고급 검색 구문, 결과 내보내기 CSV/JSON
- **다운로드**: 단일/대량/인기 작품 다운로드, 자동 제한, 재시도, 지수 백오프
- **동기화**: 메타데이터 동기화, 대량 다운로드 제어, 상태 추적, 실패 재시도
- **웹 인터페이스**: 시각적 탐색, 브라우저 내 재생, 반응형 디자인
- **설정**: 대화형 초기화, 프록시, 제한, 지터 등 고급 설정 지원

</details>

<details>
<summary><b>⚙️ 설정 파일 설명</b></summary>

설정 파일 경로: `~/.asmroner/config.toml` (TOML 형식)


```toml
[user]
account = "guest"
password = "guest"

[downloader]
api_url = ""                # 留空自动获取最快站点
proxy_url = ""              # 支持 http / socks5
max_workers = 5
max_retries = 3
sync_data_folder = "./syncdata"
sync_wanted_size = "200MB"  # 同步容量限制
prefer_media = "all"        # all | mp3>wav>flac

[limit]
sync_qps = 2
sync_jitter_min = 100       # ms
sync_jitter_max = 500
download_qps = 0.2
download_jitter_min = 2000
download_jitter_max = 5000
```
</details>

<details>
<summary><b>📋 명령 옵션 빠른 참조</b></summary>

| 명령 | 옵션 | 설명 |
|------|------|------|
| `search` | `-c` | 검색 결과 수 (기본값 10) |
| `search download` | `-d`, `-s` | 다운로드 디렉토리, 다운로드 수 |
| `search export` | `-f`, `-n` | 내보내기 파일명 (.csv/.json), 내보내기 수 |
| `download` | `-d`, `-n` | 다운로드 디렉토리, hot100 수 |
| `sync download` | `-d` | 다운로드 디렉토리 |
| `sync retry` | `-d` | 실패 파일이 있는 디렉토리 |
| `sync export` | `-s`, `-f` | 상태 (failed/success), 내보내기 파일 |
| `listen` | `-p` | 포트 (기본값 9999) |

</details>

<details>
<summary><b>📁 프로젝트 구조</b></summary>


```
asmroner/
├── cmd/                # 命令行接口（config/download/search/sync/listen）
├── internal/
│   ├── engine/        # 核心下载引擎（限流、重试、并发控制）
│   ├── logger/        # 结构化日志系统
│   ├── model/         # 数据模型与查询参数解析
│   ├── database/      # SQLite 数据库
│   ├── consts/        # 常量定义
│   └── utils/         # 工具函数
├── webui/             # 内嵌 Web 界面（Tailwind + Plyr）
├── main.go
└── go.mod
```
</details>

<details>
<summary><b>🛠 기술 스택</b></summary>

| 컴포넌트 | 용도 |
|------|------|
| Cobra + Viper | CLI 프레임워크 + 설정 관리 |
| GORM + SQLite | 데이터 영속성 |
| Resty | HTTP 클라이언트 (HTTP/SOCKS5 프록시 지원) |
| Pond | 동시 작업 풀 |
| x/time/rate | 토큰 버킷 속도 제한 |
| Gin | 웹 서비스 |
| Tailwind + Plyr | 프론트엔드 UI + 오디오 재생 |

</details>

<details>
<summary><b>🔧 자주 묻는 질문</b></summary>

**설정 파일을 찾을 수 없음** → `./asmroner config` 실행하여 초기화

**다운로드 실패 (stream error)** → 프로그램이 자동 재시도; 계속 실패 시 `sync retry`로 재시도하거나 `.asmroner-data/download_errors.log` 확인

**웹 인터페이스 접속 불가** → 포트가 점유되지 않았는지 확인, `-p` 옵션으로 다른 포트 지정 시도

**검색 결과가 없음** → 쿼리 문법 확인, 조건 단순화 시도

</details>

## 🤝 기여

Pull Request 제출을 환영합니다! Fork → 새 브랜치 생성 → 변경 사항 커밋 → PR 열기.

## 📄 라이선스

본 프로젝트는 MIT 라이선스를 따릅니다. 자세한 내용은 [LICENSE](/LICENSE) 파일 참조.

## 🙏 감사드립니다

- 특별히 감사드립니다 [go-asmr-spider](https://github.com/DiheChen/go-asmr-spider)
- 모든 기여자와 사용자분들께 감사드립니다!

---

**ASMRoner** — 매일 밤 다른 동생과 함께 잠들어요 :)

*마지막 업데이트: 2026년 2월*



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---