<div align="right">
  <details>
    <summary >🌐 Language</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
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

# 🚀 Xianyu AutoAgent - Intelligent Xianyu Customer Service Bot System

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

An AI duty solution designed specifically for the Xianyu platform, enabling 24/7 automated operation, supporting multi-expert collaborative decision-making, intelligent price negotiation, and context-aware conversations.

## 🎮 Playground - Quick Experience (No Configuration Needed)

No need for a local environment or setting Secrets! **Directly use GitHub Actions web interface to input parameters** and start the Xianyu bot with one click.

### How to Use
1. **Fork this repository** → Click the `Fork` button in the upper right corner
2. **Trigger Action**:
   - Go to your repository's `Actions` tab
   - Select the **`🚀 Run Service`** workflow
   - Click the **`Run workflow`** button and fill in the parameters:
      - `API Key`: Paste your LLM API Key (e.g., Aliyun DashScope)
      - `Cookies`: Paste the full Xianyu web cookie string
3. **View Running Logs**:
   - After the bot starts, it will automatically listen for Xianyu messages
   - Search for `🤖 Reply:` in the Action logs to view conversation records

### Notes
⚠️ Please note temporary run limitations:
- Default runtime is **30 minutes** (GitHub free account limitation)
- Sensitive information (such as Cookies) **will not be stored**, only effective for that run

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Core Features

### Intelligent Conversation Engine
| Module      | Technical Implementation   | Key Features                                               |
| ----------- | ------------------------- | ---------------------------------------------------------- |
| Contextual  | Conversation history store | Lightweight conversation memory management, full chat history as LLM context input |
| Expert Routing | LLM prompt+rule routing | Intent recognition via prompt engineering → dynamic dispatch to expert Agent, supports scenario switching for price negotiation/tech/customer service |

### Business Function Matrix
| Module     | Implemented                      | Planned                         |
| ---------- | ------------------------------- | ------------------------------- |
| Core Engine| ✅ LLM auto-reply<br>✅ Context management | 🔄 Enhanced sentiment analysis         |
| Pricing    | ✅ Stepwise price reduction strategy     | 🔄 Market price comparison            |
| Tech Support| ✅ Integrated web search               | 🔄 Enhanced RAG knowledge base        |

## 🚴 Quick Start

### Environment Requirements
- JDK 21+
- Maven 3.9.10+

### Installation Steps

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
## 🤝 Participation and Contribution

You are welcome to submit suggestions via Issues or contribute code via PRs, please follow the [Contribution Guide](https://contributing.md/)



## 🛡 Important Notes

⚠️ Note: **This project is for learning and communication purposes only. Contact the author for removal if there is any infringement.**

Due to the special nature of the project, the development team may **stop updating** or **delete the project** at any time.


## 🧸 Special Thanks

This project is refactored based on the following open-source projects:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Intelligent Xianyu Customer Service Robot System, developed by [@shaxiu](https://github.com/shaxiu) and [@cv-cat](https://github.com/cv-cat)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---