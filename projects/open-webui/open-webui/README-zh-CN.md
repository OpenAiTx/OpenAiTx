# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUI 是一个[可扩展](https://docs.openwebui.com/features/plugin/)、功能丰富且用户友好的自托管 AI 平台，旨在完全离线运行。** 它支持多种 LLM 运行环境，如 **Ollama** 和 **兼容 OpenAI 的 API**，内置 RAG 推理引擎，是一款**强大的 AI 部署解决方案**。

![Open WebUI 演示](./demo.gif)

> [!TIP]  
> **正在寻找 [企业版计划](https://docs.openwebui.com/enterprise)？** – **[立即联系我们的销售团队！](mailto:sales@openwebui.com)**
>
> 获取**增强功能**，包括**自定义主题与品牌**、**服务级协议(SLA)支持**、**长期支持(LTS)版本**以及更多！

更多信息请查阅我们的 [Open WebUI 文档](https://docs.openwebui.com/)。

## Open WebUI 主要特性 ⭐

- 🚀 **轻松安装**：可通过 Docker 或 Kubernetes（kubectl、kustomize 或 helm）无缝安装，支持 `:ollama` 与 `:cuda` 标签镜像，体验无忧。

- 🤝 **Ollama/OpenAI API 集成**：轻松集成兼容 OpenAI 的 API，与 Ollama 模型并行对话。自定义 OpenAI API 地址以连接 **LMStudio、GroqCloud、Mistral、OpenRouter 等**。

- 🛡️ **细粒度权限与用户组**：管理员可创建详细的用户角色与权限，确保安全的用户环境。这种细粒度不仅提升了安全性，还能实现个性化用户体验，增强用户的归属感和责任感。

- 📱 **响应式设计**：在台式机、笔记本、移动设备上均能获得流畅体验。

- 📱 **移动端渐进式 Web 应用(PWA)**：通过我们的 PWA，在移动设备上享受原生应用般体验，支持本地离线访问与无缝界面。

- ✒️🔢 **完整 Markdown 与 LaTeX 支持**：全面的 Markdown 和 LaTeX 能力，丰富你的 LLM 互动体验。

- 🎤📹 **免提语音/视频通话**：集成免提语音和视频通话功能，使对话更加动态和交互。

- 🛠️ **模型生成器**：通过 Web UI 轻松创建 Ollama 模型。创建和添加自定义角色/智能体，自定义聊天元素，并通过 [Open WebUI 社区](https://openwebui.com/) 集成轻松导入模型。

- 🐍 **原生 Python 函数调用工具**：工具工作区内置代码编辑器支持，为 LLM 增强能力。只需添加纯 Python 函数，即可实现 BYOF（自带函数），无缝集成 LLM。

- 📚 **本地 RAG 集成**：前沿的检索增强生成（RAG）支持，将文档交互无缝集成至对话体验。你可以直接将文档加载至聊天窗口，或添加到文档库，并通过查询前加 `#` 指令便捷访问。

- 🔍 **RAG 网页搜索**：可使用 `SearXNG`、`Google PSE`、`Brave Search`、`serpstack`、`serper`、`Serply`、`DuckDuckGo`、`TavilySearch`、`SearchApi`、`Bing` 等搜索引擎，并将结果直接注入对话。

- 🌐 **网页浏览能力**：通过 `#` 命令后跟 URL，将网站内容直接集成到对话，丰富交流深度。

- 🎨 **图像生成集成**：集成如 AUTOMATIC1111 API、ComfyUI（本地）和 OpenAI 的 DALL-E（外部）等图像生成功能，为对话增添动态图像内容。

- ⚙️ **多模型并发对话**：可同时与多种模型交互，发挥各自优势，获得最佳回复。并行调用多样模型，提升体验。

- 🔐 **基于角色的访问控制(RBAC)**：确保安全访问与权限限制；仅授权用户可访问你的 Ollama，模型创建/拉取权限仅限管理员。

- 🌐🌍 **多语言支持**：通过国际化（i18n）支持，以你喜欢的语言体验 Open WebUI。欢迎加入我们，一起扩展支持语言！我们正在积极寻找贡献者！

- 🧩 **Pipelines 与 Open WebUI 插件支持**：使用 [Pipelines 插件框架](https://github.com/open-webui/pipelines)将自定义逻辑与 Python 库无缝集成到 Open WebUI。启动 Pipelines 实例，将 OpenAI URL 设置为 Pipelines URL，探索无限可能。[示例](https://github.com/open-webui/pipelines/tree/main/examples)包括**函数调用**、用户**限流**、**使用监控**（如 Langfuse）、**LibreTranslate 实时翻译**、**有害消息过滤**等。

- 🌟 **持续更新**：我们承诺定期更新与修复，不断为 Open WebUI 带来新特性。

想了解更多 Open WebUI 特性？请查阅我们的[Open WebUI 文档](https://docs.openwebui.com/features)获取全面概览！

## 赞助商 🙌

#### 绿宝石赞助商

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • 你的界面还没有后端吗？<br>试试 <a href="https://n8n.io/">n8n</a>
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • 开发者的智能终端
    </td>
  </tr>
</table>

---

我们非常感谢各位赞助商的慷慨支持。他们的贡献帮助我们维护和改进项目，确保我们能够持续为社区提供高质量成果。感谢你们！

## 安装方法 🚀

### 通过 Python pip 安装 🐍

Open WebUI 可以通过 pip（Python 包管理器）安装。安装前请确保你使用的是 **Python 3.11** 以避免兼容性问题。

1. **安装 Open WebUI**：
   打开终端，运行以下命令安装 Open WebUI：

   ```bash
   pip install open-webui
   ```

2. **运行 Open WebUI**：
   安装完成后，通过执行以下命令启动 Open WebUI：

   ```bash
   open-webui serve
   ```

这将启动 Open WebUI 服务器，你可以通过 [http://localhost:8080](http://localhost:8080) 访问。

### Docker 快速启动 🐳

> [!NOTE]  
> 请注意，某些 Docker 环境可能需要额外配置。如遇到连接问题，请参考我们详细的 [Open WebUI 文档](https://docs.openwebui.com/)。

> [!WARNING]
> 使用 Docker 安装 Open WebUI 时，务必在命令中添加 `-v open-webui:/app/backend/data`。此步骤至关重要，它确保数据库正确挂载，防止数据丢失。

> [!TIP]  
> 若需使用自带 Ollama 或 CUDA 加速的 Open WebUI，建议使用官方 `:cuda` 或 `:ollama` 标签镜像。启用 CUDA 前，请在你的 Linux/WSL 系统上安装 [Nvidia CUDA 容器工具包](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/)。

### 默认配置安装

- **如果 Ollama 在本机**，请使用以下命令：

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **如果 Ollama 在其他服务器**，请使用以下命令：

  若需连接其他服务器上的 Ollama，请将 `OLLAMA_BASE_URL` 修改为服务器地址：

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **如需使用 Nvidia GPU 运行 Open WebUI**，请使用以下命令：

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### 仅使用 OpenAI API 安装

- **仅使用 OpenAI API 时**，请使用以下命令：

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### 带 Ollama 支持的 Open WebUI 安装

此方法使用单一容器镜像，将 Open WebUI 与 Ollama 打包，便于一条命令完成安装。请根据硬件环境选择合适命令：

- **支持 GPU**：
  利用 GPU 资源，运行如下命令：

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **仅 CPU**：
  若不使用 GPU，请使用下列命令：

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

以上命令可一站式安装 Open WebUI 与 Ollama，确保你快速上手。

安装完成后，可通过 [http://localhost:3000](http://localhost:3000) 访问 Open WebUI。祝你使用愉快！😄

### 其他安装方式

我们还提供多种安装方式，包括非 Docker 的原生安装、Docker Compose、Kustomize 以及 Helm。请访问我们的 [Open WebUI 文档](https://docs.openwebui.com/getting-started/)或加入 [Discord 社区](https://discord.gg/5rJgQTnV4s)获取详细指导。

### 故障排查

遇到连接问题？请参考我们的 [Open WebUI 文档](https://docs.openwebui.com/troubleshooting/)。如需更多帮助，欢迎加入 [Open WebUI Discord](https://discord.gg/5rJgQTnV4s) 社区。

#### Open WebUI：服务器连接错误

若遇到连接问题，通常是因为 WebUI Docker 容器无法连接到容器内的 Ollama 服务器（127.0.0.1:11434 或 host.docker.internal:11434）。可在 Docker 命令中加入 `--network=host` 参数解决。注意端口将变为 8080，即链接为 `http://localhost:8080`。

**示例 Docker 命令**：

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Docker 安装更新方法

如需将本地 Docker 安装更新至最新版，可借助 [Watchtower](https://containrrr.dev/watchtower/) 完成：

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

若你的容器名不同，请将命令最后的 `open-webui` 替换为你的容器名。

请查阅我们的[更新指南](https://docs.openwebui.com/getting-started/updating)。

### 使用开发分支 🌙

> [!WARNING]
> `:dev` 分支包含最新的非稳定特性和更改。请自行承担风险，可能存在 Bug 或未完成的功能。

想体验最新前沿特性且能接受偶尔的不稳定？可使用 `:dev` 标签：

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### 离线模式

如在离线环境运行 Open WebUI，可设置环境变量 `HF_HUB_OFFLINE=1`，防止从互联网下载模型。

```bash
export HF_HUB_OFFLINE=1
```

## 接下来？🌟

在 [Open WebUI 文档](https://docs.openwebui.com/roadmap/) 中探索我们的功能路线图。

## 许可协议 📜

本项目采用 [Open WebUI License](LICENSE)（修订版 BSD-3-Clause）许可。你拥有与经典 BSD-3 许可证相同的权利：可用于专有和商业产品，可修改和分发软件，仅需遵守最小限制。唯一额外要求是保留“Open WebUI”品牌，详见 LICENSE 文件。完整条款请查阅 [LICENSE](LICENSE) 文件。📄

## 支持 💬

如有任何问题、建议或需要帮助，请提交 issue 或加入我们的
[Open WebUI Discord 社区](https://discord.gg/5rJgQTnV4s) 与我们联系！🤝

## Star 历史

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

由 [Timothy Jaeryang Baek](https://github.com/tjbck) 创建 —— 让我们共同让 Open WebUI 变得更加出色！💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---