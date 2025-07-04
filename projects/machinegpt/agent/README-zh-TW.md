![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

一個高速、可自給自足的 Python AI agent 框架，利用 OpenAI Python SDK 解讀自然語言指令，動態生成並執行程式碼，並以零摩擦管理其運行環境。它具備自動依賴安裝、安全環境配置、結構化日誌紀錄，以及極簡的插件介面，用於嵌入強大的 Python 工具——全部採用寬鬆的 Apache 2.0 授權。

## ⭐ Star 歷史

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 環境設置

### Python 虛擬環境
在設置專案前，建議建立虛擬環境。請按照下列步驟操作：

了解虛擬環境：[Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

建立並啟用虛擬環境：

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### 專案設置
本專案需要 OpenAI API 金鑰才能運行。請在根目錄建立一個 .env 檔案，內容如下：
```
OPENAI_API_KEY=
```
或者，你可以複製提供的 .env.example 檔案並更新金鑰：
```
cp .env.example .env
```

## 🧠 啟動
要啟動 agent，只需執行：
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ 貢獻

歡迎貢獻、建議、錯誤回報與修正！

如要新增功能、元件或擴充，請先開 issue 討論再提交 PR。

## 💖 本專案能有今日成果，感謝所有貢獻者
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---