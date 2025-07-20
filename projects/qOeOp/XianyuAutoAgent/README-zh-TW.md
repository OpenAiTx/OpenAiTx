<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - 智能閒魚客服機器人系統

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

專為閒魚平台打造的AI值守解決方案，實現閒魚平台7×24小時自動化值守，支援多專家協同決策、智能議價和上下文感知對話。

## 🎮 Playground - 快速體驗（免設定版）

無需本地環境或設定 Secrets！**直接通過 GitHub Actions 網頁端傳入參數**，一鍵啟動閒魚機器人。

### 如何使用
1. **Fork 本倉庫** → 點擊右上角 `Fork` 按鈕
2. **觸發 Action**：
   - 進入你的倉庫 `Actions` 標籤頁
   - 選擇 **`🚀 Run Service`** 工作流
   - 點擊 **`Run workflow`** 按鈕，填寫參數：
      - `API Key`: 貼上你的大模型 API Key（如阿里雲 DashScope）
      - `Cookies`: 貼上閒魚網頁端的完整 Cookie 字串
3. **查看運行日誌**：
   - 機器人啟動後會自動監聽閒魚訊息
   - 在 Action 日誌中搜尋 `🤖 Reply:` 查看對話記錄

### 注意事項
⚠️ 注意臨時運行限制：
- 預設運行 **30分鐘**（GitHub 免費帳戶限制）
- 敏感資訊（如 Cookie）**不會儲存**，僅本次有效

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 核心特性

### 智能對話引擎
| 功能模組   | 技術實現            | 關鍵特性                                                     |
| ---------- | ------------------- | ------------------------------------------------------------ |
| 上下文感知 | 會話歷史存儲        | 輕量級對話記憶管理，完整對話歷史作為LLM上下文輸入            |
| 專家路由   | LLM prompt+規則路由 | 基於提示工程的意圖識別 → 專家Agent動態分發，支援議價/技術/客服多場景切換 |

### 業務功能矩陣
| 模組     | 已實現                        | 規劃中                     |
| -------- | ----------------------------- | ----------------------- |
| 核心引擎 | ✅ LLM自動回覆<br>✅ 上下文管理 | 🔄 情感分析增強               |
| 議價系統 | ✅ 階梯降價策略                | 🔄 市場比價功能               |
| 技術支持 | ✅ 網路搜尋整合                | 🔄 RAG知識庫增強             |

## 🚴 快速開始

### 環境要求
- JDK 21+
- Maven 3.9.10+

### 安裝步驟

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 參與貢獻

歡迎通過 Issue 提交建議或 PR 貢獻程式碼，請遵循 [貢獻指南](https://contributing.md/)



## 🛡 注意事項

⚠️ 注意：**本專案僅供學習與交流，如有侵權請聯繫作者刪除。**

鑒於專案的特殊性，開發團隊可能在任何時間**停止更新**或**刪除專案**。


## 🧸 特別鳴謝

本專案基於以下開源專案重構：
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - 智能閒魚客服機器人系統，由 [@shaxiu](https://github.com/shaxiu) 和 [@cv-cat](https://github.com/cv-cat) 開發


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---