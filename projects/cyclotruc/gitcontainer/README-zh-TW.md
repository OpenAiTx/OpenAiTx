![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**將任何 GitHub 儲存庫轉換為可投入生產環境的 Docker 容器，並利用 AI 自動生成 Dockerfile。**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer 是一個 AI 驅動的網頁應用程式，能夠自動分析 GitHub 儲存庫並生成可投入生產環境的 Dockerfile。只需貼上 GitHub URL，即可獲得量身打造的 Dockerfile，包含智慧型基礎映像選擇、相依性管理及最佳 Docker 實踐。

## 🌟 快速存取

只需將任何 GitHub 儲存庫 URL 中的 `github.com` 替換為 `gitcontainer.com`，即可立即進入該儲存庫的 Dockerfile 生成頁面。

例如：
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ 特色

- **🔄 即時 URL 存取**：只需將任何 GitHub URL 中的 'github.com' 替換為 'gitcontainer.com'
- **🤖 AI 智能分析**：運用 OpenAI GPT-4 來分析儲存庫結構並生成智慧型 Dockerfile
- **⚡ 即時串流**：透過 WebSocket 串流即時觀看 AI 生成 Dockerfile 的過程
- **🎯 智慧偵測**：自動偵測技術棧（Python、Node.js、Java、Go 等）
- **🔧 生產環境就緒**：依循最佳實踐生成 Dockerfile，具備完善的安全性、多階段建置及最佳化
- **📋 額外指令**：可新增自訂需求以建構特殊環境
- **📄 Docker Compose**：對於複雜應用程式自動建議 docker-compose.yml
- **🎨 現代化介面**：乾淨、響應式介面，並以 Monaco 編輯器進行語法高亮
- **📱 行動裝置友善**：桌面與行動裝置皆可順暢操作

## 🚀 快速開始

### 先決條件

- Python 3.9 或更高版本
- Git
- OpenAI API 金鑰

### 安裝步驟

1. **複製儲存庫：**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **安裝相依套件：**
   ```bash
   pip install -r requirements.txt
   ```

3. **設定環境變數：**
   ```bash
   # 建立 .env 檔案
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **啟動應用程式：**
   ```bash
   python app.py
   ```

5. **打開瀏覽器：**
   前往 `http://localhost:8000`

## 🛠️ 運作流程

1. **URL 處理**：將任何儲存庫的 'github.com' 替換為 'gitcontainer.com' 即可存取
2. **儲存庫複製**：Gitcontainer 透過 Git 將 GitHub 儲存庫複製到本地
3. **程式碼分析**：使用 [gitingest](https://github.com/cyclotruc/gitingest) 來分析儲存庫結構並擷取相關資訊
4. **AI 生成**：將分析結果與專業提示一同發送至 OpenAI GPT-4 以生成 Dockerfile
5. **智慧最佳化**：AI 會考量：
   - 技術棧偵測
   - 相依性管理
   - 安全性最佳實踐
   - 當有利時採用多階段建置
   - 埠口設定
   - 環境變數
   - 健康檢查

## 📁 專案結構

```
cyclotruc-gitcontainer/
├── app.py                 # 主要 FastAPI 應用程式
├── requirements.txt       # Python 相依套件
├── .env                  # 環境變數（請自行建立）
├── static/               # 靜態資源（圖示、CSS）
├── templates/
│   └── index.jinja       # 主要 HTML 樣板
└── tools/                # 核心功能模組
    ├── __init__.py
    ├── create_container.py  # AI Dockerfile 生成
    ├── git_operations.py    # GitHub 儲存庫複製
    └── gitingest.py        # 儲存庫分析
```

## 🔧 設定

### 環境變數

| 變數 | 說明 | 是否必填 |
|------|------|----------|
| `OPENAI_API_KEY` | 你的 OpenAI API 金鑰 | 是 |
| `PORT` | 伺服器埠（預設：8000） | 否 |
| `HOST` | 伺服器主機（預設：0.0.0.0） | 否 |

### 進階用法

你可以以程式化方式使用這些工具：

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # 複製儲存庫
    clone_result = await clone_repo_tool(github_url)
    
    # 使用 gitingest 分析
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # 產生 Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# 用法
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 自訂

### 新增自訂指令

使用「額外指令」功能來自訂產生內容：

- `"使用 Alpine Linux 以減小映像檔大小"`
- `"包含 Redis 和 PostgreSQL"`
- `"最佳化為生產環境部署"`
- `"加入開發工具以便除錯"`

## 📝 授權

本專案採用 MIT License 授權 - 詳情請參閱 [LICENSE](LICENSE) 檔案。

## 🙏 鳴謝

- **[OpenAI](https://openai.com/)** 提供 GPT-4 API
- **[gitingest](https://github.com/cyclotruc/gitingest)** 提供儲存庫分析功能
- **[FastAPI](https://fastapi.tiangolo.com/)** 優秀的 Web 框架
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** 程式碼語法高亮

## 🔗 連結

- **GitHub 儲存庫**： [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**：以範例儲存庫線上試用
- **問題回報**： [回報錯誤或提出功能需求](https://github.com/cyclotruc/gitcontainer/issues)

---

**由 [Romain Courtois](https://github.com/cyclotruc) ❤️ 製作**

*讓任何儲存庫在幾秒內變成容器！*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---