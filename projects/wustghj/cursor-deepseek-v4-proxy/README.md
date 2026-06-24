# 🧠 Cursor DeepSeek V4 Proxy

> **一键修复 Cursor 使用 DeepSeek V4 时的 `reasoning_content` 错误，告别 `Rate limit exceeded`，让 AI Agent 模式稳定运行。**

[![GitHub stars](https://img.shields.io/github/stars/你的用户名/cursor-deepseek-v4-proxy?style=social)](https://github.com/你的用户名/cursor-deepseek-v4-proxy)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

---

## 📌 你能用这个项目解决什么问题？

如果你在 Cursor 中调用 DeepSeek V4（Pro / Flash）时，频繁遇到下面任意一种错误：

* `Provider returned error: The reasoning_content in the thinking mode must be passed back to the API.`
* `User API Key Rate limit exceeded`（明明配额还剩很多却报错）
* `AI Model Not Found: deepseek-v4-pro`（后台任务报模型名无效）
* 聊天第一轮正常，第二轮就开始报错、中断

**不用再折腾了，跟着本指南走 5 分钟就能彻底解决。**

> ⚠️  **2026-05-14 修复**：纯文本模型现已自动过滤图片，解决 502 错误。详见 [更新日志](#changelog)

---

## ✨ 核心功能

* ✅ **自动缓存 & 回传思维链**：再也不会因为 `reasoning_content` 缺失而报错。
* ✅ **智能限流**：内置令牌桶，防止突发的并发请求打满免费额度。
* ✅ **支持流式输出**：不影响 Cursor 的打字机渲染效果。
* ✅ **一键启动脚本**：Windows / macOS / Linux 通用，双击即可运行。
* ✅ **透明日志**：终端会实时显示请求状态，方便排错。
* ✅ **零侵入**：不需要修改 Cursor 程序文件，只改一个 Base URL。

---

## 🖥️ 适用环境

| 操作系统 | 支持情况 |
| :--- | :--- |
| **Windows 10 / 11** | ✅ 支持 |
| **macOS** | ✅ 支持 |
| **Linux** | ✅ 支持 |

> **唯一要求**：安装 **Python 3.8** 或更高版本（安装时请务必勾选 `Add Python to PATH`）。

---

## 🚀 超详细三步上手（小白专用）

### 第一步：下载项目并安装依赖

1.  下载本项目仓库的 ZIP 包，解压到本地（**路径请勿包含中文**）。
2.  进入解压后的文件夹，在文件夹地址栏输入 `cmd` 并回车，打开命令行窗口。
3.  执行以下命令安装依赖：
    ```bash
    pip install -r requirements.txt
    ```
    *若提示 `pip不是内部命令`，请重新安装 Python 并勾选 `Add to PATH`。*

### 第二步：启动本地代理 + 隧道

你需要一个隧道来生成公网地址（Cursor 限制访问 localhost）。

#### 🪟 Windows 用户
1.  确保文件夹内有 `cloudflared-windows-amd64.exe`（若无，请前往 [Cloudflare 官网](https://github.com/cloudflare/cloudflared/releases) 下载）。
2.  双击运行 **`start_proxy.bat`**。
3.  会弹出两个窗口。在**隧道窗口**中，找到一串 `https://xxx.trycloudflare.com` 的地址并**复制**。

#### 🍎 macOS / Linux 用户
1.  在终端中进入项目目录，运行：
    ```bash
    bash start_proxy.sh
    ```
2.  稍等片刻，复制终端输出的 `https://xxx.trycloudflare.com` 地址。

> ⚠️ **注意**：窗口不能关闭。隧道地址每次重启会变化，只要不关窗口就一直有效。

### 第三步：配置 Cursor

1.  打开 Cursor 设置：按 `Ctrl+Shift+P` → 输入 `Cursor Settings`。
2.  进入 **Models** 选项卡。
3.  在 **"Override OpenAI Base URL"** 中，粘贴刚才复制的地址，并**在末尾加上 `/v1`**：
    * 例如：`https://xxxxxx.trycloudflare.com/v1`
4.  在 API Key 处填入你的 **DeepSeek API Key**。
5.  **彻底退出并重启 Cursor**。

---

## 🛡️ 修复 "Model name not valid" 错误

如果在执行 Apply 或后台任务时报错，请按以下步骤操作：

1.  按 `Ctrl+Shift+P`，输入 `Preferences: Open User Settings (JSON)` 并回车。
2.  在 JSON 的大括号 `{}` 内添加如下配置：
    ```json
    "cursor.models": {
        "deepseek-v4-pro": {
            "provider": "openai",
            "apiBase": "[https://你的隧道地址.trycloudflare.com/v1](https://你的隧道地址.trycloudflare.com/v1)",
            "apiKey": "你的DeepSeek API Key"
        }
    }
    ```
3.  保存并重启 Cursor。

---

## ❓ 常见问题 (FAQ)

<details>
<summary>🔁 隧道地址变了怎么办？</summary>
每次重启脚本都会生成新地址。你只需重新获取并更新到 Cursor 的 Base URL 即可。
</details>

<details>
<summary>💸 还是提示 Rate limit exceeded？</summary>
DeepSeek 免费层级频率极低。你可以编辑 `proxy.py`，将 `TokenBucket(rate=5/60.0, capacity=5)` 中的 `5` 调小（如 `3`），强制降低请求频率。
</details>

<details>
<summary>🚫 必须用隧道吗？能不能连 localhost？</summary>
Cursor 出于安全原因禁止直接连接 `localhost`。Cloudflare Tunnel 是目前最简单、免费且无需注册的穿透方案。
</details>

<details>
<summary>🧪 代理会影响模型智商吗？</summary>
在 99% 的场景下无感知。代理仅是在模型“忘记”回传思维链时进行自动补全，确保对话不中断。
</details>

<details>
<summary>🧪 为什么只有 200k context，不是 1M？</summary>
这是 Cursor 的默认限制，不是代理问题。

Cursor 默认使用 200k context window。
如需启用模型支持的 1M context，需要在 Cursor Chat 中开启 `Max Mode`。
路径：
Chat -> Model Selector -> Max Mode
</details>

---

## ⚙️ 高级自定义

* **更换上游**：修改 `proxy.py` 中的 `UPSTREAM_URL`。
* **固定域名**：如果你有自己的域名，可以配置 Cloudflare 命名隧道（Persistent Tunnel）。

<a name="changelog"></a>
## 🆕 更新日志

### 2026-05-14：纯文本模型图片兼容修复

**修复内容**
当 Cursor 等客户端向 `deepseek-v4-pro`（纯文本模型）发送包含图片的消息时，代理层现在会自动过滤掉 `image_url` 内容块，仅保留文本部分。如果某条消息全部为图片（无文本），则替换为提示文本，避免模型收到空消息。
此修复解决了 DeepSeek API 返回 `"unknown variant image_url, expected text"` 导致的 502 错误。

**额外改进**

- 统一上游错误返回格式，客户端将收到结构化的 JSON 错误（而非原始报错或空白页）。
- 图片兼容逻辑对推理缓存 (`reasoning_content`) 无影响，历史消息处理保持正常。

------

### 致谢

感谢 [@BG-ah](https://github.com/BG-ah) 在 Issue [#4](https://github.com/wustghj/cursor-deepseek-v4-proxy/issues/4) 中反馈速率限制问题，以及 [@CH-nolyn](https://github.com/CH-nolyn) 的参与讨论。你们的反馈直接推动了本次兼容性修复，让代理在纯文本模型下运行得更稳定。

------

> 💡 **提示**：如果你需要让模型真正理解图片内容，请将请求中的 `model` 字段改为支持多模态的 `deepseek-chat`，并确保你的 DeepSeek 账户已开通相应权限。

