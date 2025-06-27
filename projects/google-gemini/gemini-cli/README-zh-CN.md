# Gemini CLI

[![Gemini CLI CI](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml/badge.svg)](https://github.com/google-gemini/gemini-cli/actions/workflows/ci.yml)

![Gemini CLI 截图](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/assets/gemini-screenshot.png)

此仓库包含 Gemini CLI，一款命令行 AI 工作流工具，可连接你的工具，理解你的代码，并加速你的工作流。

使用 Gemini CLI，你可以：

- 在 Gemini 的 1M token 上下文窗口内及更大范围内查询和编辑大型代码库。
- 利用 Gemini 的多模态能力，从 PDF 或草图生成新应用。
- 自动化运维任务，如查询拉取请求或处理复杂的 rebase。
- 使用工具和 MCP 服务器连接新能力，包括 [使用 Imagen、Veo 或 Lyria 生成媒体](https://github.com/GoogleCloudPlatform/vertex-ai-creative-studio/tree/main/experiments/mcp-genmedia)
- 使用内置于 Gemini 的 [Google 搜索](https://ai.google.dev/gemini-api/docs/grounding) 工具，为你的查询提供支撑。

## 快速开始

1. **前置条件：** 确保你已安装 [Node.js 18 版本](https://nodejs.org/en/download)或更高版本。
2. **运行 CLI：** 在终端中执行以下命令：

   ```bash
   npx https://github.com/google-gemini/gemini-cli
   ```

   或者通过以下方式安装：

   ```bash
   npm install -g @google/gemini-cli
   gemini
   ```

3. **选择配色主题**
4. **认证登录：** 按提示使用你的个人 Google 账号登录。这将允许你每分钟最多 60 次模型请求，每天最多 1,000 次模型请求。

你现在已经可以使用 Gemini CLI 了！

### 高级用法或提升请求限额：

如果你需要使用特定模型或更高的请求容量，可以使用 API 密钥：

1. 从 [Google AI Studio](https://aistudio.google.com/apikey) 生成一个密钥。
2. 在终端中将其设置为环境变量。将 `YOUR_API_KEY` 替换为你生成的密钥。

   ```bash
   export GEMINI_API_KEY="YOUR_API_KEY"
   ```

如需其他认证方式，包括 Google Workspace 账号，请参阅 [认证指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/authentication.md)。

## 示例

CLI 运行后，你可以在 shell 中开始与 Gemini 互动。

你可以从新目录开始一个项目：

```sh
cd new-project/
gemini
> 写一个 Gemini Discord 机器人，能够使用我提供的 FAQ.md 文件来回答问题
```

或者在已有项目中工作：

```sh
git clone https://github.com/google-gemini/gemini-cli
cd gemini-cli
gemini
> 总结一下昨天所有的变更内容
```

### 下一步

- 了解如何[参与贡献或从源码构建](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/CONTRIBUTING.md)。
- 探索可用的**[CLI 命令](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/cli/commands.md)**。
- 如遇到任何问题，请查看**[故障排查指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)**。
- 获取更完整的文档，请参见[完整文档](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/index.md)。
- 浏览一些[热门任务](#popular-tasks)以获取更多灵感。

### 故障排查

如遇问题，请前往[故障排查指南](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/troubleshooting.md)。

## 热门任务

### 探索新代码库

首先 `cd` 到已有或新克隆的代码仓库并运行 `gemini`。

```text
> 描述一下该系统架构的主要组成部分。
```

```text
> 有哪些安全机制已就位？
```

### 操作现有代码

```text
> 为 GitHub 问题 #123 实现初稿。
```

```text
> 帮我将该代码库迁移到最新的 Java 版本。请先给出方案。
```

### 自动化工作流

使用 MCP 服务器将本地系统工具与企业协作套件集成。

```text
> 制作一个幻灯片，展示最近 7 天的 git 历史，按功能和团队成员分组。
```

```text
> 制作一个全屏网页应用，用于墙面展示我们被互动最多的 GitHub 问题。
```

### 与系统交互

```text
> 将该目录下所有图片转换为 png，并根据 exif 数据的日期重命名。
```

```text
> 按支出月份整理我的 PDF 发票。
```

## 服务条款和隐私声明

有关你使用 Gemini CLI 适用的服务条款和隐私声明的详细信息，请参见[服务条款和隐私声明](https://raw.githubusercontent.com/google-gemini/gemini-cli/main/docs/tos-privacy.md)。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---