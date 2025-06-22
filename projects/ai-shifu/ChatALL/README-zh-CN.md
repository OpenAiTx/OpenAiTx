<div align="center">
  <img src="https://raw.githubusercontent.com/ai-shifu/ChatALL/main/src/assets/logo-cover.png" width=256></img>
  <p><strong>同时与所有AI机器人对话，发现最佳答案</strong></p>

[Deutsch](README_DE-DE.md) | English | [Español](README_ES-ES.md) | [Français](README_FR-FR.md) | [Italian](README_IT-IT.md) | [日本語](README_JA-JP.md) | [한국어](README_KO-KR.md) | [Русский](README_RU-RU.md) | [Tiếng Việt](README_VI-VN.md) | [简体中文](README_ZH-CN.md)

[![Open in GitHub Codespaces](https://github.com/codespaces/badge.svg)](https://codespaces.new/ai-shifu/ChatALL)

</div>

## 截图

![Screenshot](https://raw.githubusercontent.com/ai-shifu/ChatALL/main/screenshots/screenshot-1.png?raw=true)

## 功能

基于大语言模型（LLMs）的AI机器人非常强大，但它们的行为有时会很随机，不同的机器人在不同任务上表现也不一样。如果你想获得最佳体验，不必一个个去尝试。ChatALL（中文名：齐叨）可以同时将你的提问发送给多个AI机器人，帮你发现最优答案。你只需[下载、安装](https://github.com/ai-shifu/ChatALL/releases)并提问即可。

### 你是这样的用户吗？

ChatALL 的典型用户包括：

- 🤠**LLM达人**，希望从多个大模型中找到最佳答案或创意
- 🤓**LLM研究者**，希望直观对比不同领域中各大模型的优劣
- 😎**大模型应用开发者**，希望快速调试提示词，寻找表现最佳的基础模型

### 支持的机器人

| AI 机器人                                                                          | 网页访问     | API        | 备注                                         |
| ----------------------------------------------------------------------------------- | ---------- | --------- | -------------------------------------------- |
| [360智脑](https://ai.360.cn/)                                                       | 是         | 无API     |                                              |
| [百度文心一言](https://yiyan.baidu.com/)                                             | 否         | 是        |                                              |
| [Character.AI](https://character.ai/)                                               | 是         | 无API     |                                              |
| [ChatGLM2 6B & 130B](https://chatglm.cn/)                                           | 是         | 无API     | 无需登录                                     |
| [ChatGPT](https://chatgpt.com)                                                  | 是         | 是        | 包含Web浏览、Azure OpenAI服务                |
| [Claude](https://www.anthropic.com/claude)                                          | 是         | 是        |                                              |
| [Code Llama](https://ai.meta.com/blog/code-llama-large-language-model-coding/)      | 是         | 无API     |                                              |
| [Cohere Aya 23](https://cohere.com/blog/aya23)                                      | 否         | 是        |                                              |
| [Cohere Command R Models](https://cohere.com/command)                               | 否         | 是        |                                              |
| [Copilot](https://copilot.microsoft.com/)                                           | 是         | 无API     |                                              |
| [得到学习助手](https://ai.dedao.cn/)                                                | 即将支持    | 无API     |                                              |
| [Falcon 180B](https://huggingface.co/tiiuae/falcon-180B-chat)                       | 是         | 无API     |                                              |
| [Gemini](https://gemini.google.com/)                                                | 是         | 是        |                                              |
| [Gemma 2B & 7B](https://blog.google/technology/developers/gemma-open-models/)       | 是         | 无API     |                                              |
| [Gradio](https://gradio.app/)                                                       | 是         | 无API     | 用于 Hugging Face Space/自部署模型           |
| [Groq Cloud](https://console.groq.com/docs/models)                                  | 否         | 是        |                                              |
| [HuggingChat](https://huggingface.co/chat/)                                         | 是         | 无API     |                                              |
| [讯飞星火](http://xinghuo.xfyun.cn/)                                                | 是         | 即将支持  |                                              |
| [Kimi](https://kimi.moonshot.cn/)                                                   | 是         | 无API     |                                              |
| [Llama 2 13B & 70B](https://ai.meta.com/llama/)                                     | 是         | 无API     |                                              |
| [MOSS](https://moss.fastnlp.top/)                                                   | 是         | 无API     |                                              |
| [Perplexity](https://www.perplexity.ai/)                                            | 是         | 无API     |                                              |
| [Phind](https://www.phind.com/)                                                     | 是         | 无API     |                                              |
| [Pi](https://pi.ai)                                                                 | 是         | 无API     |                                              |
| [Poe](https://poe.com/)                                                             | 是         | 即将支持  |                                              |
| [天工 SkyWork](https://neice.tiangong.cn/)                                          | 是         | 即将支持  |                                              |
| [通义千问](http://tongyi.aliyun.com/)                                               | 是         | 即将支持  |                                              |
| [Vicuna 13B & 33B](https://lmsys.org/blog/2023-03-30-vicuna/)                       | 是         | 无API     | 无需登录                                     |
| [WizardLM 70B](https://github.com/nlpxucan/WizardLM)                                | 是         | 无API     |                                              |
| [xAI Grok](https://x.ai)                                                            | 否         | 是        |                                              |
| [YouChat](https://you.com/)                                                         | 是         | 无API     |                                              |
| [You](https://you.com/)                                                             | 是         | 无API     |                                              |
| [Zephyr](https://huggingface.co/spaces/HuggingFaceH4/zephyr-chat)                   | 是         | 无API     |                                              |

更多机器人正在不断加入。欢迎在[这些Issue](https://github.com/ai-shifu/ChatALL/labels/more%20LLMs)中为你喜欢的机器人投票。

### 关于网页连接型机器人的可靠性说明

网页连接型AI机器人（表格中“网页访问”为“是”的机器人）本质上不太稳定，容易因服务商频繁调整网页接口与安全措施而出现故障。这些网页连接依赖于逆向工程，维护难度大，经常会突然失效。为确保体验，强烈建议优先使用支持API接入的机器人。

### 其他功能

- 快速提问模式：无需等待上一个请求完成即可发送下一个问题
- 本地保存聊天记录，保护你的隐私
- 可高亮喜欢的回复，删除不满意的回复
- 可随时启用/禁用任意机器人
- 支持单列、双列、三列视图切换
- 自动升级到最新版
- 暗黑模式（贡献者 @tanchekwei）
- 快捷键。按 <kbd>Ctrl</kbd> + <kbd>/</kbd> 查看全部（贡献者 @tanchekwei）
- 支持多会话（贡献者 @tanchekwei）
- 代理设置（贡献者 @msaong）
- 提示词管理（贡献者 @tanchekwei）
- 多语言支持（中文、英文、德语、法语、俄语、越南语、韩语、日语、西班牙语、意大利语）
- 支持 Windows、macOS 和 Linux

计划中的功能：

欢迎你参与这些功能的开发。

- [ ] 前端部署到 GitHub Pages

## 隐私

所有聊天记录、设置和登录信息都保存在你本地电脑上。

ChatALL 会收集匿名使用数据，用于帮助我们改进产品。包括：

- 发送了哪些AI机器人，以及提示词长度（不包括提示词具体内容）
- 回复的长度，及哪些回复被删除/高亮（不包括回复内容）

## 前置条件

ChatALL 是客户端，不是代理。因此，你需要：

1. 拥有各机器人账号和/或API密钥
2. 能与各机器人正常联网

## 下载 / 安装

下载地址：https://github.com/ai-shifu/ChatALL/releases

### Windows

直接下载 \*-win.exe 文件，双击安装。

### macOS

Apple Silicon（M1、M2芯片）请下载 \*-mac-arm64.dmg 文件。

其他Mac请下载 \*-mac-x64.dmg 文件。

如果你在用 [Homebrew](https://brew.sh/)，也可以这样安装：

```bash
brew install --cask chatall
```

### Linux

Debian系：下载 .deb 文件，双击安装即可。
Arch系：可在 [AUR](https://aur.archlinux.org/packages/chatall-bin) 克隆 ChatALL，手动安装或用 yay/paru 等 AUR 助手安装。
其他发行版：下载 .AppImage 文件，赋予可执行权限，点击即可运行。也可用 [AppimageLauncher](https://github.com/TheAssassin/AppImageLauncher)。

## 常见问题

如果你在使用ChatALL过程中遇到问题，可以尝试以下方法解决：

1. **刷新** - 按 <kbd>Ctrl</kbd> + <kbd>R</kbd> 或 <kbd>⌘</kbd> + <kbd>R</kbd>。
2. **重启** - 退出ChatALL后重新运行。
3. **重新登录** - 点击右上角设置按钮，然后点相应登录/注销链接重新登录网站。
4. **新建会话** - 点击 `New Chat` 按钮后重新提问。

如以上方法均无效，可尝试**重置 ChatALL**。注意，此操作会删除所有设置和消息记录。

重置方法：删除以下目录

- Windows: `C:\Users\<user>\AppData\Roaming\chatall\`
- Linux: `/home/<user>/.config/chatall/`
- macOS: `/Users/<user>/Library/Application Support/chatall/`

如问题仍未解决，请[提交Issue](https://github.com/ai-shifu/ChatALL/issues)。

## 开发者相关

### 贡献机器人

[开发指南](https://github.com/ai-shifu/ChatALL/wiki/%E5%A6%82%E4%BD%95%E6%B7%BB%E5%8A%A0%E4%B8%80%E4%B8%AA%E6%96%B0%E7%9A%84-AI-%E5%AF%B9%E8%AF%9D%E6%9C%BA%E5%99%A8%E4%BA%BA) 供你参考。

### 运行

```bash
npm install
npm run electron:serve
```

### 构建

为当前平台构建：

```bash
npm run electron:build
```

构建所有平台：

```bash
npm run electron:build -- -wml --x64 --arm64
```

## 鸣谢

### 贡献者

<a href="https://github.com/ai-shifu/ChatALL/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ai-shifu/ChatALL" />
</a>

### 其他

- GPT-4 贡献了大量代码
- ChatGPT、Copilot 和 Google 提供了许多解决方案（排名顺序）
- 灵感来源于 [ChatHub](https://github.com/chathub-dev/chathub)。致敬！

## 赞助

如果你喜欢这个项目，欢迎支持：

[![ko-fi](https://ko-fi.com/img/githubbutton_sm.svg)](https://ko-fi.com/F1F8KZJGJ)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-22

---