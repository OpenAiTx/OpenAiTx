# Telegram Bot + HAX Data Monitoring Script

This is a combined project for Telegram Bot management and HAX.CO.ID data center monitoring, supporting **Docker deployment** and **server background running** modes.
The original project code was provided by a Telegram group friend (named ez ez) (big brother, if you have any issues please DM me, considering personal privacy I won’t post the big brother’s Telegram account here), it threw errors when run directly. I used ChatGPT to modify and improve it, and it is currently running smoothly.

---

## 📦 Feature Overview

- 🤖 `bot.py`: A Telegram Bot implemented using `python-telegram-bot`, supporting interactive features (such as buttons, commands, callbacks).
- 📡 `hax.py`: Fetches data center status from [https://hax.co.id/data-center/](https://hax.co.id/data-center/) every 60 seconds.
- 🔁 Supports automatic background running (suitable for Linux VPS)
- 🐳 Provides Docker image build script
- 📜 Automatically checks and installs Python3 environment (server mode)

---


## 📂 Project Structure

```
project/                 # 自行创建一个文件夹存放项目文件，名称随意，英文命名
├── bot.py               # Telegram Bot 主程序
├── hax.py               # HAX 数据中心监控脚本
├── requirements.txt     # 所有依赖声明
├── Dockerfile           # Docker 镜像定义
├── run_docker.sh        # 一键 Docker 构建 + 启动脚本
├── run_server.sh        # 一键后台运行（非 Docker）
└── logs/                # 自动生成日志文件目录
```
## 🖥️ Operation Mode 1: Running in the Background on a Regular Server

### ✅ Prerequisites

- Suitable for mainstream servers such as Ubuntu / Debian / CentOS
- Python 3 environment (can be installed automatically)

### ▶️ One-Click Run



```bash
chmod +x run_server.sh
./run_server.sh
```

The first run will:

- Check if `python3` / `pip3` is installed on the system
- Automatically install dependencies from `requirements.txt`
- Start the script you choose in the background (using `nohup`)
- Output logs to the `logs/` directory

### 📄 View logs

```bash
tail -f logs/bot.log     # 查看 Telegram Bot 日志
tail -f logs/hax.log     # 查看 HAX 监控日志
```

### ❌ Stop Process

```bash
pkill -f bot.py
pkill -f hax.py
```

---

## 🐳 运行方式二：Docker 模式

### 🔧 构建镜像并运行

```bash
chmod +x run_docker.sh
./run_docker.sh
```

You can choose to run:

- `bot.py` (Telegram Bot)
- `hax.py` (HAX Monitoring)
- 'Run both bot.py and hax.py scripts simultaneously...'
- Either one can run independently in the container

---

---

## 📌 Dependencies

- `requests`
- `beautifulsoup4`
- `lxml`
- `python-telegram-bot[job-queue]>=20.0`

Installation method:

```bash
pip install -r requirements.txt
```

---

## 📬 联系方式

欢迎 issue 或 PR，有建议请提！随缘回复


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-18

---