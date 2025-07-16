<translate-content># 🚀 Xianyu AutoAgent - Intelligent Xianyu Customer Service Robot System

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

An AI on-duty solution specially designed for the Xianyu platform, achieving 7×24-hour automated on-duty service on Xianyu, supporting multi-expert collaborative decision-making, intelligent bargaining, and context-aware conversations.

## 🎮 Playground - Quick Experience (No Configuration Version)

No local environment or Secrets setup required! **Pass parameters directly through the GitHub Actions web interface**, and start the Xianyu robot with one click.

### How to Use
1. **Fork this repository** → Click the `Fork` button at the top right
2. **Trigger the Action**:
   - Go to your repository's `Actions` tab
   - Select the **`🚀 Run Service`** workflow
   - Click the **`Run workflow`** button and fill in the parameters:
      - `API Key`: Paste your large model API Key (e.g., Alibaba Cloud DashScope)
      - `Cookies`: Paste the complete Cookie string from the Xianyu web client
3. **View the running logs**:
   - After the robot starts, it will automatically listen to Xianyu messages
   - Search for `🤖 Reply:` in the Action logs to view conversation records

### Notes
⚠️ Please note temporary run limitations:
- Default runtime is **30 minutes** (GitHub free account limit)
- Sensitive information (such as Cookies) **will not be stored**, effective only during the current run

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Core Features

### Intelligent Dialogue Engine
| Feature Module | Technology Implementation  | Key Features                                               |
| -------------- | -------------------------- | ---------------------------------------------------------- |
| Context Awareness | Session History Storage   | Lightweight dialogue memory management, complete conversation history as LLM context input |
| Expert Routing | LLM prompt + Rule Routing  | Intent recognition based on prompt engineering → dynamic dispatch to expert Agents, supports bargaining/technical/support multi-scenario switching |

### Business Function Matrix
| Module     | Implemented                  | Planned                    |
| ---------- | ---------------------------- | -------------------------- |
| Core Engine | ✅ LLM Auto Reply<br>✅ Context Management | 🔄 Sentiment Analysis Enhancement |
| Bargaining System | ✅ Tiered Discount Strategy | 🔄 Market Price Comparison Feature |
| Technical Support | ✅ Network Search Integration | 🔄 RAG Knowledge Base Enhancement |

## 🚴 Quick Start

### Environment Requirements
- JDK 21+
- Maven 3.9.10+

### Installation Steps</translate-content>
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---