# llum

### 一个快速、轻量、开源的聊天界面

![image](https://github.com/user-attachments/assets/38cc47cf-06a3-4dca-8ee5-d9c9edf57903)

### 主要特点：

- 🔌 多个提供商，插入你的 API 密钥（完全本地存储），即可开始使用

  - 本地模型（通过 Ollama）
  - OpenRouter（允许你使用多个提供商的所有模型：OpenAI、Anthropic、OSS、50 多个其他）
  - OpenAI
  - Anthropic
  - Mistral
  - Groq

- 🛠️ 工具使用
  - 查看 `server/toolfns/toolfns.go`。你只需编写函数。函数注释是模型接收的描述，因此它知道如何使用。点击网页界面中的 `Sync` 按钮刷新你的工具。
- 🖼️ 多模态输入：上传、粘贴或分享图片链接
- 🎨 使用 DALL-E 3 生成图片
- 📝 多轮提示。还可以编辑、删除、重新生成消息，任你所欲
- ⚡ 预设回复（在提供商支持的情况下）
- 🌐 支持所有提供商的所有可用模型
- 🔄 会话中途更换模型
- 🔐 跨设备同步聊天和密钥，端到端加密。可自托管，或使用我们的托管实例。
- 🔗 会话分享（如果你选择分享，你的对话必须存储在外部服务器上，才能生成分享链接。自托管分享选项即将推出。不，我不会查看你的任何内容。）
- 🌿 分支会话历史（类似 ChatGPT 左右箭头，点击可回到之前的回复）

### 隐私：

- 完全私密和透明。所有对话历史和密钥均完全本地存储，仅保存在你的浏览器和设备上。

## 如何安装？

如果你不想使用工具，则无需安装任何东西。托管实例可访问：https://llum.chat

如果你想使用工具，请继续阅读以下内容。

## 单一二进制文件：

llum 工具服务器提供预构建的单一二进制文件。[从发布页面下载预构建包。](https://github.com/zakkor/llum/releases)

下载适合你平台的二进制文件，然后运行它，即可启动工具服务器：

```
./llum-darwin-amd64
Tool server running at http://localhost:8081
```
回到 https://llum.chat，进入 设置 -> 工具调用，然后点击“刷新工具”按钮。你应该可以正常使用了！

### 本地构建客户端和服务器：

1. 克隆代码仓库
2. 安装并启动客户端：`npm i && npm run dev`。客户端将可通过 http://localhost:5173 访问
3. 安装并启动服务器：`cd server && go generate ./... && go build && ./server -password foobar`。服务器将可通过 http://localhost:8081 访问。你可以在聊天界面中将此地址和你选择的密码一起填写到服务器地址中。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---