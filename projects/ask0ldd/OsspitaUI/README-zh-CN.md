Release : Alpha 1.0.5

<div style="display:flex; width:100%; column-gap:16px; margin-bottom:12px;">
    <span>兼容性 :</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/windows.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
    <span style="display:flex; height:100%;">&</span>
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/ubuntu.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/chrome.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/firefox.png">
    <img style="width:24px; height:24px;" src="https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/brave.png">
</div>

# OSSPITA : 本地运行您的 AI 助手，体验直观界面，只需几次点击即可调整所有代理。享受免费且有保障的隐私。

OSSPITA 是一个轻量级、完全本地化、开源的桌面界面，允许用户免费实时与各种开源大型语言模型（LLM）交互。借助 [Ollama API](https://github.com/ollama/ollama)，OSSPITA 提供了一个用户友好的体验，让您轻松接触前沿的 AI 技术。

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot2.png "osspita main")

Alpha 1.0.1 版本的视频演示，更及时的视频即将发布：

[![OSspita Video Demo](https://img.youtube.com/vi/zKxcANYu-9I/0.jpg)](https://www.youtube.com/watch?v=zKxcANYu-9I "OSspita Video Demo")<br>
_点击上方图片，在 YouTube 上观看视频_

## I - 功能

- 与大多数开源 AI 模型的**实时交互**。
- 轻量级且**完全本地化**操作。
- **适合初学者**的安装流程。
- 多上下文代理调优。
- 支持 **Llama Vision**。
- 支持与各种历史人物的聊天功能。
- 复杂任务解决的**代理链**。
- 检索增强生成（RAG），让您在**保护隐私**的同时查询自己的文档。
- 集成更多**最新信息**的网页搜索功能。
- 全面的推理统计。
- 记忆分配跟踪，用于**上下文长度调节**。
- 带有（版本控制即将推出）的**提示库**。
- 便捷访问最**常用的 LLM 设置**。

## II - 即将推出

- **响应式**设计。
- 为代理链增加**并行处理**。
- 改进的网页搜索算法，增强选项。
- 在线域名排名。
- 改进的 RAG 算法，增强选项。
- 在线提示和代理共享平台。
- 提示版本管理系统。
- 专用编程代理。
- 代码语法高亮。
- **暗黑模式**主题。
- 图表生成。
- 语音模式。
- 上下文自动调整选项。
- 深入的 RAG 统计与数据。
- 深入的网页搜索统计与数据。

## III - 截图

![osspita main](https://github.com/ask0ldd/OsspitaUI/blob/main/Front/src/assets/screenshot1.png "osspita main")

## IV - 入门指南

### 先决条件

- Node.js（v22.11.0 或更高版本）：https://nodejs.org/en/
- npm（10.9.0 或更高版本）
- Ollama（本地安装并运行）：https://ollama.com/download
- OSspita 后端运行中。
- 至少一个开源模型。
- 如果需要，安装 Nvidia CUDA：https://developer.nvidia.com/cuda-downloads

模型推荐：

| GPU 显存   | 模型              | 用途           | 链接                                                                 |
| ---------- | ----------------- | -------------- | -------------------------------------------------------------------- |
| 4GB        | Llama 3.2:3b      | 对话           | [Ollama 上的 Llama 3.2](https://ollama.com/library/llama3.2:3b)              |
| 8GB        | Aya Expanse:8b    | 对话           | [Ollama 上的 Aya Expanse](https://ollama.com/library/aya-expanse:8b)   |
| 12GB       | Mistral Nemo:12b  | 对话           | [Ollama 上的 Mistal Nemo](https://ollama.com/library/mistral-nemo:12b)           |
| 4GB        | starcoder2:3b     | 编程           | [Ollama 上的 StarCoder2](https://ollama.com/library/starcoder2)        |
| 8GB & 12GB | qwen2.5-coder:7b  | 编程           | [Ollama 上的 Qwen 2.5 Coder](https://ollama.com/library/qwen2.5-coder) |

### 安装

克隆仓库：

> git clone https://github.com/ask0ldd/OsspitaUI.git

进入项目目录：

> cd OsspitaUI

#### 前端

> cd front

安装依赖：

> npm install

启动开发服务器：

> npm run dev

打开浏览器并访问 http://localhost:5173 ，以便引导您完成其余的安装流程。

## V - 使用说明

视频演示：

## VI - 使用技术

- React 18.3.1
- Vite
- Ollama API
- ExpressJS
- LokiJS
- Zustand
- Duck-duck-scrape
- Cheerio
- React-pdftotext
- Marked 14.1.1
- Turndown
- Cors
- BodyParser

## VII - 贡献

如果您遇到任何错误或希望我添加/改进某些功能，请打开问题并提出请求。非常感谢您的帮助。

## VIII - 致谢

- Georgi Gerganov 及所有与 llama.cpp 相关的贡献者。
- Ollama 团队，感谢提供用于推理的 API。
- React 和 Vite 社区，感谢他们出色的工具。
- 所有项目的贡献者和支持者。
- 所有制作 GGUF 模型的人。
- 最后，感谢所有参与我所使用库开发的人们。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-22

---