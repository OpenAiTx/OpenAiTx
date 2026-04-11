<h1 align="center">Openlist-Ani</h1>

<p align="center">
  <b>🎬 RSS 구독 → 자동 다운로드 → AI 이름 변경, 원스톱 애니메이션 자동 관리</b>
</p>

<p align="center">
  애니메이션 관련 RSS 구독 소스에서 자동으로 업데이트를 가져와 Openlist를 통해 오프라인으로 해당 클라우드에 다운로드하고,<br/>
  LLM을 활용해 리소스 이름을 분석하여 Emby / Jellyfin이 인식할 수 있는 형식으로 이름을 변경합니다.
</p>

---

## ✨ 특징

- 📡 **자동 애니메이션 추적** — RSS 애니메이션 업데이트 자동 획득 및 다운로드
- 📦 **다중 클라우드 지원** — OpenList 기반, PikPak, 115 등 오프라인 다운로드 지원
- 🤖 **AI 이름 변경** — AI가 리소스 이름 분석 + TMDB 검색으로 애니메이션 이름, 시즌, 에피소드 정확히 획득
- 💬 **스마트 어시스턴트** — Telegram 봇에 연동, 자연어로 AI가 검색 및 다운로드 지원
- 🔔 **업데이트 알림** — PushPlus, Telegram 등 채널로 업데이트 푸시

## 📋 준비 작업

1. [Openlist 공식 문서](https://doc.oplist.org/guide)를 참고하여 Openlist 배포 및 오프라인 다운로드 설정
2. RSS 구독 링크 준비 (예: [Mikan Project](https://mikanani.me))
3. LLM API 키 준비

## 🚀 빠른 시작

<details open>
<summary><b>방법 1: PIP 설치 (추천)</b></summary>

**1. 설치**

```bash
pip install openlist-ani
```

**2. 설정 파일 생성**

실행 디렉토리에 `config.toml` 파일을 새로 만들고, 다음 내용을 입력하세요:

```toml
[rss]
urls = ["RSS订阅链接"]

[openlist]
url = "http://localhost:5244"       # Openlist 访问地址
token = ""                          # 令牌，见「设置 → 其他 → 令牌」
download_path = "/PikPak/Anime"     # 下载保存路径
offline_download_tool = "QBITTORRENT"  # 离线下载工具

[llm]
openai_api_key = ""                 # API Key
openai_base_url = "https://api.deepseek.com/v1"
openai_model = "deepseek-chat"
```

> 完整配置项请参考 [`config.toml.example`](https://raw.githubusercontent.com/TwooSix/Openlist-Ani/master/config.toml.example) 及 [配置说明](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

**3. 启动**

```bash
openlist-ani
```

**4.（선택 사항）AI 어시스턴트 시작**

구성 파일에 어시스턴트 구성을 추가한 후 실행:

```toml
[assistant]
enabled = true

[assistant.telegram]
bot_token = ""        # 从 @BotFather 获取
allowed_users = []    # 允许的用户 ID 列表，留空则不限制
```

```bash
openlist-ani-assistant
```

</details>

<details>
<summary><b>방법 2: Docker 배포</b></summary>

**1. 파일 준비**

실행 디렉토리에 생성:
- `config.toml` — 설정 파일(내용 동일)
- `data/` — 데이터 디렉토리

**2. 컨테이너 시작**

```bash
docker run -d \
  --name openlist-ani \
  --network host \
  -e ENABLE_ASSISTANT=false \
  -v /path/to/config.toml:/config.toml \
  -v /path/to/data:/data \
  twosix26/openlist-ani:latest
```
> `/path/to/` 를 실제 경로로 바꾸세요.  
> AI 어시스턴트를 사용하려면 설정을 완료한 후 `ENABLE_ASSISTANT` 를 `true` 로 설정하세요.  
> 자세한 내용은 [Docker 배포 가이드](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南) 를 참조하세요.

</details>

<details>
<summary><b>방법 3: 소스 코드에서 컴파일</b></summary>

#### 전제 조건: uv 설치

<table><tr><td>

**Linux / macOS**

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

</td><td>

**윈도우**
```powershell
powershell -ExecutionPolicy ByPass -c "irm https://astral.sh/uv/install.ps1 | iex"
```

</td></tr></table>

> 更多安装方式参考 [uv 官方文档](https://github.com/astral-sh/uv)

#### 步骤

```bash
# 1. 克隆仓库
git clone https://github.com/TwooSix/Openlist-Ani.git && cd Openlist-Ani

# 2. 切换到最新版本（master 为开发分支，不保证稳定）
git checkout v***    # 替换为最新版本号

# 3. 安装依赖
uv sync --no-dev --frozen

# 4. 创建 config.toml 并填写配置（内容同上）

# 5. 启动
uv run openlist-ani

# 6.（可选）启动 AI 助理
uv run openlist-ani-assistant
```

</details>

## 📖 문서

- [빠른 시작](https://github.com/TwooSix/Openlist-Ani/wiki/快速开始)
- [PIP 설치 가이드](https://github.com/TwooSix/Openlist-Ani/wiki/PIP安装指南)
- [Docker 배포 가이드](https://github.com/TwooSix/Openlist-Ani/wiki/Docker部署指南)
- [소스코드 컴파일 가이드](https://github.com/TwooSix/Openlist-Ani/wiki/源码编译指南)
- [설정 설명](https://github.com/TwooSix/Openlist-Ani/wiki/配置说明)

## 🖼️ 효과 시연

| 이름 변경 결과 | 스마트 어시스턴트 |
| :---: | :---: |
| <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic1.png" width="400"/> | <img src="https://github.com/TwooSix/Openlist-Ani/blob/master/imgs/show_pic2.jpg" width="150"/> |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---