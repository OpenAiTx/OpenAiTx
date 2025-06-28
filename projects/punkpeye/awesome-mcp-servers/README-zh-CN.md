# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

一个精心策划的优秀模型上下文协议（MCP）服务器列表。

* [什么是MCP？](#what-is-mcp)
* [客户端](#clients)
* [教程](#tutorials)
* [社区](#community)
* [图例](#legend)
* [服务器实现](#server-implementations)
* [开发框架](#frameworks)
* [技巧与窍门](#tips-and-tricks)

## 什么是MCP？

[MCP](https://modelcontextprotocol.io/) 是一个开放协议，使AI模型能够通过标准化的服务器实现安全地与本地和远程资源交互。此列表关注于生产可用和实验性的MCP服务器，通过文件访问、数据库连接、API集成和其他上下文服务扩展AI能力。

## 客户端

请查看 [awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) 和 [glama.ai/mcp/clients](https://glama.ai/mcp/clients)。

> [!TIP]
> [Glama Chat](https://glama.ai/chat) 是一款支持MCP的多模态AI客户端及 [AI网关](https://glama.ai/gateway)。

## 教程

* [模型上下文协议（MCP）快速入门](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [设置Claude桌面应用以使用SQLite数据库](https://youtu.be/wxCCzo9dGj0)

## 社区

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discord 服务器](https://glama.ai/mcp/discord)

## 图例

* 🎖️ – 官方实现
* 编程语言
  * 🐍 – Python 代码库
  * 📇 – TypeScript（或 JavaScript）代码库
  * 🏎️ – Go 代码库
  * 🦀 – Rust 代码库
  * #️⃣ - C# 代码库
  * ☕ - Java 代码库
  * 🌊 – C/C++ 代码库
* 应用范围
  * ☁️ - 云服务
  * 🏠 - 本地服务
  * 📟 - 嵌入式系统
* 操作系统
  * 🍎 – macOS
  * 🪟 – Windows
  * 🐧 - Linux

> [!NOTE]
> 对本地 🏠 和云端 ☁️ 感到困惑？
> * 当MCP服务器需要与本地安装的软件通信时，请使用本地，如控制Chrome浏览器。
> * 当MCP服务器需要与远程API通信时，请使用网络，如天气API。

## 服务器实现

> [!NOTE]
> 我们现在有一个与仓库同步的 [基于Web的目录](https://glama.ai/mcp/servers)。

* 🔗 - [聚合器](#aggregators)
* 🎨 - [艺术与文化](#art-and-culture)
* 📂 - [浏览器自动化](#browser-automation)
* ☁️ - [云平台](#cloud-platforms)
* 👨‍💻 - [代码执行](#code-execution)
* 🤖 - [编码代理](#coding-agents)
* 🖥️ - [命令行](#command-line)
* 💬 - [通信](#communication)
* 👤 - [客户数据平台](#customer-data-platforms)
* 🗄️ - [数据库](#databases)
* 📊 - [数据平台](#data-platforms)
* 🚚 - [交付](#delivery)
* 🛠️ - [开发者工具](#developer-tools)
* 🧮 - [数据科学工具](#data-science-tools)
* 📟 - [嵌入式系统](#embedded-system)
* 📂 - [文件系统](#file-systems)
* 💰 - [金融与金融科技](#finance--fintech)
* 🎮 - [游戏](#gaming)
* 🧠 - [知识与记忆](#knowledge--memory)
* 🗺️ - [位置服务](#location-services)
* 🎯 - [市场营销](#marketing)
* 📊 - [监控](#monitoring)
* 🎥 - [多媒体处理](#multimedia-process)
* 🔎 - [搜索与数据提取](#search)
* 🔒 - [安全](#security)
* 🌐 - [社交媒体](#social-media)
* 🏃 - [体育](#sports)
* 🎧 - [支持与服务管理](#support-and-service-management)
* 🌎 - [翻译服务](#translation-services)
* 🎧 - [文本转语音](#text-to-speech)
* 🚆 - [旅行与交通](#travel-and-transportation)
* 🔄 - [版本控制](#version-control)
* 🛠️ - [其他工具与集成](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>聚合器

通过单一 MCP 服务器访问多个应用和工具的服务器。

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - 通过一个二进制文件使用 SQL 查询超过 40 个应用。也可连接到您的 PostgreSQL、MySQL 或 SQLite 兼容数据库。以本地优先和隐私为设计理念。
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP 是一款统一的中间件 MCP 服务器，提供图形界面管理您的 MCP 连接。
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - 使用 [MindsDB 作为单一 MCP 服务器](https://docs.mindsdb.com/mcp/overview) 连接并统一各种平台和数据库的数据。
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - MCP 服务器列表，您可以让客户端查询哪些服务器可用，以优化日常工作流程。
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - 10 秒将 Web API 转换为 MCP 服务器，并添加到开源注册表：https://open-mcp.org
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - 连接 2,500 个 API，拥有 8,000+ 预构建工具，并在您的应用中为用户管理服务器。
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - 综合代理服务器，将多个 MCP 服务器合并到单一界面，并具备强大的可见性功能。可跨服务器发现和管理工具、提示、资源及模板，并自带调试用 playground。
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - 用于将多个 MCP 服务器组合为一个统一端点的代理工具。通过负载均衡请求扩展 AI 工具，类似于 Nginx 之于 Web 服务器。
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCP 是一款统一的中间件 MCP 服务器，提供图形界面管理您的 MCP 连接。
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - 无缝且安全地将 Claude Desktop 及其他 MCP 主机连接到您喜欢的应用（Notion、Slack、Monday、Airtable 等）。用时不到 90 秒。
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - 一键将 Web 服务变为 MCP 服务器，无需更改任何代码。
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - 通过 MCP 使用 Google 的 Imagen 3.0 API 的强大图像生成工具。可通过高级摄影、艺术和写实控制，从文本提示生成高质量图片。
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT 图像生成/编辑 MCP 服务器。

### 🎨 <a name="art-and-culture"></a>艺术与文化

访问和探索艺术收藏、文化遗产及博物馆数据库。支持 AI 模型搜索和分析艺术及文化内容。

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - 本地 MCP 服务器，使用 Manim 生成动画。
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - 为您的视频丛林集合添加、分析、搜索和生成视频编辑。
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - 用于与 Discogs API 交互的 MCP 服务器。
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ 通过官方 REST API v4 与 Quran.com 语料库交互的 MCP 服务器。
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - 大都会艺术博物馆藏品 API 集成，可搜索并展示藏品。
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - 荷兰国家博物馆 API 集成，用于艺术品搜索、详情及收藏。
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - Oorlogsbronnen（二战资源）API 集成，访问荷兰（1940-1945）历史 WWII 记录、照片和文档。
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - DaVinci Resolve 的 MCP 服务器集成，提供强大的视频编辑、调色、媒体管理及项目控制工具。
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - 集成 AniList API 的 MCP 服务器，用于动漫和漫画信息。
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - 基于 Aseprite API 的 MCP 服务器，用于像素画创作。
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - 一款 MCP 服务器与扩展，支持自然语言控制 NVIDIA Isaac Sim、Lab、OpenUSD 等。
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Open Library API 的 MCP 服务器，使 AI 助手可检索图书信息。
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Autodesk Maya 的 MCP 服务器。
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - 提供全面准确的八字（中国命理）排盘与分析。

### 📂 <a name="browser-automation"></a>浏览器自动化

网页内容访问与自动化能力。支持以 AI 友好格式搜索、抓取和处理网页内容。

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - 基于 FastMCP 的工具，获取 B 站热门视频，并通过标准 MCP 接口暴露。
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - 支持搜索 B 站内容的 MCP 服务器，提供 LangChain 集成示例与测试脚本。
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - 自托管浏览器代理，内置 MCP 和 A2A 支持。
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - 基于 Playwright 实现的浏览器自动化 MCP 服务器。
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - 基于 Playwright 的 MCP Python 服务器，更适合大语言模型。
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - 云端自动化浏览器交互（如网页导航、数据提取、表单填写等）。
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - 自动化本地 Chrome 浏览器。
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-use 打包为 MCP 服务器，支持 SSE 传输。包含用于 Docker 内运行 Chromium + VNC 的 dockerfile。
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - 基于 Playwright 的 MCP 服务器，支持浏览器自动化与网页抓取。
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - 与浏览器扩展配合的 MCP 服务器，使 LLM 客户端可控制用户浏览器（Firefox）。
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - 用于 macOS 上与 Apple 提醒事项交互的 MCP 服务器。
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - 从任意网站提取结构化数据。只需输入提示，即可获得 JSON。
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - 获取 YouTube 字幕及转录，供 AI 分析使用。
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - 基于 Azure OpenAI 与 Playwright 的 `minimal` 服务器/客户端 MCP 实现。
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - 官方 Microsoft Playwright MCP 服务器，使 LLM 能通过结构化可访问性快照与网页交互。
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - 用于网页抓取与交互的浏览器自动化
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - 用于与 manifest v2 兼容浏览器交互的 MCP 服务器。
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - 允许使用 Google 搜索结果进行免费网页搜索的 MCP 服务器，无需 API key。
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - 与 Apple 快捷指令集成的 MCP 服务器。

### ☁️ <a name="cloud-platforms"></a>云平台

云平台服务集成。支持对云基础设施与服务的管理和交互。

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWS MCP 服务器，实现与 AWS 服务和资源的无缝集成。
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - 基于七牛云产品的 MCP，支持访问云存储、媒体处理等服务。
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - IPFS 存储的上传与操作。
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - Kubernetes Model Context Protocol (MCP) 服务器，通过标准接口与 K8s 集群交互，包括 API 资源发现、资源管理、Pod 日志、指标及事件。
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - 用于查询图书的 MCP 服务器，可用于 Cherry Studio 等常见 MCP 客户端。
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - 轻量但强大的服务器，使 AI 助手可在安全的 Docker 环境中执行 AWS CLI 命令、使用 Unix 管道，并为常用 AWS 任务应用提示模板，支持多架构。
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - 轻量但强大的服务器，使 AI 助手可安全地在 Docker 环境中执行 Kubernetes CLI 命令（`kubectl`、`helm`、`istioctl`、`argocd`），支持 Unix 管道和多架构。
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - 使 AI 助手可操作阿里云资源的 MCP 服务器，支持 ECS、云监控、OOS 及常用云产品。
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - 基于 MCP（模型控制协议）的 VMware ESXi/vCenter 管理服务器，提供虚拟机管理的 REST API。
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - 集成 Cloudflare 服务，包括 Workers、KV、R2 和 D1。
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - 允许 AI Agent 通过 Cyclops 抽象管理 Kubernetes 资源的 MCP 服务器。
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - 集成 Fastly 服务。
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - 用 TypeScript 实现的 Kubernetes 集群操作，包括 Pod、部署、服务等。
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - 基于 Azure Resource Graph 的 MCP 服务器，实现大规模查询和分析 Azure 资源，使 AI 助手可探索和监控 Azure 基础设施。
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Azure CLI 命令行的封装，可直接与 Azure 通信。
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - 用于访问 Netskope Private Access 各组件的 MCP，包括详细的设置信息和 LLM 使用示例。
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - 强大的 Kubernetes MCP 服务器，额外支持 OpenShift。不仅提供对任意 K8s 资源的 CRUD 操作，还提供集群交互专用工具。
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Terraform MCP 服务器，使 AI 助手可管理和操作 Terraform 环境，包括读取配置、分析计划、应用配置和管理状态。
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - 通过 Pulumi Automation API 和 Pulumi Cloud API 与 Pulumi 交互的 MCP 服务器。支持检索包信息、预览变更、部署更新及以编程方式获取堆栈输出。
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - Kubernetes 的 Model Context Protocol (MCP) 服务器，使 AI 助手如 Claude、Cursor 等可通过自然语言与 Kubernetes 集群交互。
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - 通过 MCP 实现 Kubernetes 集群操作。
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - 基于 Go 的 MCP 服务器，用于与 Nutanix Prism Central 资源交互。
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - 一次调用即可获得最新 EC2 价格信息。快速，基于预解析 AWS 价格目录。
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - 提供 MCP 多集群 Kubernetes 管理与运维，具备管理界面、日志和近 50 款内置工具，覆盖常见 DevOps 与开发场景。支持标准和 CRD 资源。
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - 提供 MCP 多集群 Kubernetes 管理与运维，可作为 SDK 集成到您的项目，并内置近 50 款工具，支持标准与 CRD 资源，覆盖常见 DevOps 与开发场景。
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - 用于 Kubernetes 管理的 MCP 服务器，可分析集群和应用健康状况
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Azure Data Lake Storage 的 MCP 服务器。可对容器文件进行管理、读/写/上传/下载操作，并管理文件元数据。
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8S 是一款 AI 驱动的 Kubernetes 资源管理工具，允许用户通过自然语言交互操作 Kubernetes 集群中的任何资源，包括原生资源（如 Deployment、Service）和自定义资源（CRD）。无需记忆复杂命令，只需描述需求，AI 即可准确执行相应的集群操作，大大提升 Kubernetes 的可用性。
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - 使用自然语言轻松管理 Redis Cloud 资源。通过简单命令创建数据库、监控订阅并配置云部署。
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - 一款强大的 MCP 服务器，使 AI 助手能够无缝与 Portainer 实例交互，通过自然语言访问容器管理、部署操作及基础设施监控能力。

### 👨‍💻 <a name="code-execution"></a>代码执行

代码执行服务器。允许 LLM 在安全环境中执行代码，例如为编码代理服务。

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- 通过 MCP 工具调用在安全沙箱中运行 Python 代码
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - 在安全且可扩展的沙箱环境中执行任何 LLM 生成的代码，并使用 JavaScript 或 Python 创建自己的 MCP 工具，全面支持 NPM 和 PyPI 包
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP：容器化 MCP 服务器，让 AI 代理能够通过现有 API 文档访问任何 API。
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – 基于 Node.js 的 MCP 服务器，启动基于 Docker 的隔离沙箱来执行 JavaScript 片段，支持即时 npm 依赖安装与清理
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - 使用 v8 隔离代码的 Javascript 代码执行沙箱，可让本地安全运行 AI 生成的 javascript。支持堆快照，可持久化会话。

### 🤖 <a name="coding-agents"></a>编码代理

完整的编码代理，使 LLM 能够读取、编辑、执行代码并完全自主地解决通用编程任务。

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - 一款功能齐全的编码代理，依赖语言服务器进行符号代码操作。
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - 具备基本读写和命令行工具的编码代理。
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - 让 AI 模型可以搜索、检索、解决 LeetCode 问题的 MCP 服务器。支持元数据过滤、用户档案、提交和竞赛数据访问。
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - 支持自动访问 **LeetCode** 编程题、解答、提交和公开数据的 MCP 服务器，支持可选用户认证（如笔记），兼容 `leetcode.com`（国际）和 `leetcode.cn`（中国）站点。
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - 允许 AI（如 Claude）读取 VS Code 工作区目录结构，查看 linter 和语言服务器发现的问题，读取代码文件并进行编辑的 MCP 服务器。
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - 单一二进制的 MCP 服务器，可将任意语言的源代码转为 AST。

### 🖥️ <a name="command-line"></a>命令行

运行命令、捕获输出及与 Shell 和命令行工具交互。

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - 一个为 iTerm 提供访问的 Model Context Protocol 服务器。你可以运行命令并咨询终端内看到的信息。
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - 通过 `run_command` 和 `run_script` 工具运行任意命令。
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - 基于 HF Smolagents `LocalPythonExecutor` 的安全 Python 解释器
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - 具备安全执行和可自定义安全策略的命令行接口
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - 一个用于 Terminal 的 DeepSeek MCP 类服务器
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - 实现 Model Context Protocol (MCP) 的安全 Shell 命令执行服务器
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - 使网络设备结构化、模型驱动交互的 Cisco pyATS 服务器。
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - 一把瑞士军刀式工具，可管理/执行程序并读写/搜索/编辑代码和文本文件。
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - 通过 Model Context Protocol 暴露 Linux 和 Windows 服务器 SSH 控制的 MCP 服务器。可通过密码或 SSH 密钥安全执行远程 Shell 命令。

### 💬 <a name="communication"></a>通信

与通信平台集成，实现消息管理和频道操作。使 AI 模型能与团队沟通工具交互。

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - 一个允许与 Nostr 交互的 MCP 服务器，支持发布笔记等操作。
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - 与 Twitter 搜索和时间线交互
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - 一个 MCP 服务器，可即时创建收件箱以发送、接收邮件并执行相关操作。我们不是邮件 AI 代理，而是 AI 代理的邮件。
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - 用于接口 Google Tasks API 的 MCP 服务器
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - 通过 Model Context Protocol (MCP) 安全访问你的 iMessage 数据库的 MCP 服务器，允许 LLM 查询和分析 iMessage 对话，具备强大的手机号验证、附件处理、联系人管理、群聊处理以及完整的消息收发支持。
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - Telegram API 集成，用于访问用户数据、管理对话（聊天、频道、群组）、获取消息和处理已读状态
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - Telegram API 集成，用于访问用户数据、管理对话（聊天、频道、群组）、获取/发送消息及处理已读状态。
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Inbox Zero 的 MCP 服务器。在 Gmail 基础上增加如查找需要回复或跟进邮件等功能。
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - 一个 ntfy MCP 服务器，允许 AI 代理向自托管 ntfy 服务器发送/获取通知 📤（支持安全 token 认证等，可与 npx 或 docker 一起使用！）
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - 一款可向企业微信群机器人发送多种类型消息的 MCP 服务器应用。
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - 通过 Model Context Protocol (MCP) 提供安全访问 iMessage 数据库的 MCP 服务器，使 LLM 能够查询、分析 iMessage 对话，并正确处理手机号验证与附件
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - 作为 [ACP](https://agentcommunicationprotocol.dev) 生态系统适配器的 MCP 服务器。无缝将 ACP 代理暴露给 MCP 客户端，实现两种协议间桥接。
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - 提供 Mattermost 团队、频道和消息访问的 MCP 服务器及 MCP host。MCP host 作为 Mattermost 机器人集成，可配置访问 MCP 服务器。
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - 个人 WhatsApp 消息、联系人搜索及向个人/群组发送消息的 MCP 服务器
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - 集成 LINE 官方账号的 MCP 服务器
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - 集成 Gmail 和 Google Calendar
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Bluesky 实例集成，用于查询和交互
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slack 工作区集成，实现频道管理和消息传递
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - 最强大的 Slack 工作区 MCP 服务器。
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 这是一个用于与 VRChat API 交互的 MCP 服务器。你可以检索 VRChat 中的好友、世界、头像等信息。
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - 用于接口 Google Calendar API 的 MCP 服务器，基于 TypeScript。
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - 通过 ntfy 向手机发送通知的 MCP 服务器
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - [DIDLogic](https://didlogic.com) 的 MCP 服务器。可管理 SIP 终端、号码和目的地。
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - 用于管理 Google Tasks 的 MCP 服务器
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - 集成 Microsoft Teams 消息（读取、发布、提及、列出成员和线程）的 MCP 服务器
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - 通过 Graph API 连接整个 Microsoft 365 套件（包括邮件、文件、Excel、日历）的 MCP 服务器
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - YCloud 的 WhatsApp Business Platform MCP 服务器。
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Product Hunt 的 MCP 服务器。可与热门帖子、评论、收藏、用户等交互。

### 👤 <a name="customer-data-platforms"></a>客户数据平台

可访问客户数据平台内的客户档案

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - 连接 [iaptic](https://www.iaptic.com)，查询客户购买、交易数据及应用收入统计。
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - 使用 Model Context Protocol，将任意开放数据连接至任意 LLM。
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - 用于访问和更新 Apache Unomi CDP 服务器上档案的 MCP 服务器。
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - 允许任意 MCP 客户端与 Tinybird Workspace 交互的 MCP 服务器。
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - 用于生成可视化图表的 Model Context Protocol 服务器，基于 [AntV](https://github.com/antvis)。

### 🗄️ <a name="databases"></a>数据库

安全数据库访问与结构检查能力。支持通过可配置的安全控制（包括只读）进行数据查询与分析。

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  导航你的 [Aiven 项目](https://go.aiven.io/mcp-server)，与 PostgreSQL®、Apache Kafka®、ClickHouse® 和 OpenSearch® 服务交互
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - 支持 SQL 查询执行和数据库探索工具的 Supabase MCP 服务器
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Tablestore 的 MCP 服务，支持文档添加、基于向量和标量的语义搜索、RAG 友好及无服务器特性。
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - NodeJS 实现的 MySQL 数据库集成，支持可配置访问控制和结构检查
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – 支持主流数据库的通用数据库 MCP 服务器。
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - TiDB 数据库集成，具备结构检查和查询能力
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Model Context Protocol(MCP) 客户端和 AI 代理的语义引擎
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - MCP 及 MCP SSE 服务器，可基于数据库结构和数据自动生成 API。支持 PostgreSQL、Clickhouse、MySQL、Snowflake、BigQuery、Supabase
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - DICOM 集成，支持从 PACS 及其他 DICOM 兼容系统查询、读取、转移医学影像和报告。
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - Chroma MCP 服务器，可访问本地与云端 Chroma 实例，实现检索功能
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ClickHouse 数据库集成，具备结构检查和查询能力
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Confluent 集成，用于与 Confluent Kafka 和 Confluent Cloud REST API 交互。
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCP 服务器为文档操作、SQL++ 查询和自然语言数据分析提供 Capella 云与自管集群的统一访问。
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - 提供 Elasticsearch 交互的 MCP 服务器实现
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - 一体化 Postgres 开发与运维 MCP 服务器，内置性能分析、调优与健康检查工具
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - Trino MCP 服务器，可用于查询和访问 Trino 集群中的数据。
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Trino 的 Go 语言 Model Context Protocol (MCP) 服务器实现
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - MySQL 数据库集成，支持可配置访问控制、结构检查与全面安全指南
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - 支持 SSE、STDIO；不仅限于 MySQL 的 CRUD 功能；还包含数据库异常分析能力；基于角色控制数据库权限；方便开发者自定义扩展工具
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - Airtable 数据库集成，具备结构检查、读写能力
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodb 数据库集成，具备读写能力
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Google BigQuery 集成服务器，实现 BigQuery 数据库的直接访问与查询能力
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - 基于 Node.js 的 MySQL 数据库集成，提供安全的 MySQL 数据库操作
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - Fireproof 分布式账本数据库，支持多用户同步
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – 使用 Golang 构建的高性能多数据库 MCP 服务器，支持 MySQL 和 PostgreSQL（NoSQL 即将支持）。内置查询执行、事务管理、结构探索、查询构建与性能分析工具，与 Cursor 无缝集成，提升数据库工作流体验。
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDB Lens：功能齐全的 MongoDB MCP 服务器
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Firebase 服务集成，包括认证、Firestore 和存储
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Convex 数据库集成，可探查表、函数并运行一次性查询（[源码](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts)）
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - 专注于为数据库提供简单、快速、安全工具的开源 MCP 服务器。
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - 用于 GreptimeDB 查询的 MCP 服务器。
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - 通过 Model Context Protocol (MCP) 提供安全、只读访问 SQLite 数据库的 MCP 服务器。基于 FastMCP 框架构建，让大模型安全探索和查询 SQLite 数据库，带有内置安全特性和查询验证。
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - 针对 InfluxDB OSS API v2 的查询执行
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Snowflake 集成，实现读操作（可选写操作）及洞察跟踪
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabase MCP 服务器，用于管理和创建 Supabase 项目与组织
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Apache Kafka 与 Timeplus 的 MCP 服务器。支持列出 Kafka 主题、轮询 Kafka 消息、本地保存 Kafka 数据，并通过 Timeplus 使用 SQL 查询流数据
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - VikingDB 集成，具备集合与索引介绍、向量存储与检索能力。
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - MongoDB 的 Model Context Protocol 服务器
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - DuckDB 数据库集成，支持结构检查与查询能力
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - BigQuery 数据库集成，具备结构检查与查询能力
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - 连接任意 JDBC 兼容数据库，支持查询、插入、更新、删除等操作。
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - 提供全面 SQLite 数据库交互能力的 Model Context Protocol (MCP) 服务器。
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCP 服务器 - 包含针对 Memgraph 查询和结构资源的工具。
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - PostgreSQL 数据库集成，支持结构检查和查询能力
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - SQLite 数据库操作，内置分析功能
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Neo4j 的 Model Context Protocol（运行查询、知识图谱记忆、管理 Neo4j Aura 实例）
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — 用于通过 Neon Serverless Postgres 创建和管理 Postgres 数据库的 MCP 服务器
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) Nile 的 Postgres 平台 MCP 服务器 - 使用大模型管理和查询 Postgres 数据库、租户、用户与认证
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - 通过 Open Database Connectivity (ODBC) 协议实现通用数据库管理系统 (DBMS) 连接的 MCP 服务器
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - 通过 Python ODBC (pyodbc) 以 SQLAlchemy 实现通用数据库管理系统 (DBMS) 连接的 MCP 服务器
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - 查询与分析 Azure Data Explorer 数据库
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  查询与分析 Prometheus（开源监控系统）。
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - 让大模型能够管理 Prisma Postgres 数据库（如创建新数据库实例或执行结构迁移）。
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant MCP 服务器
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - MongoDB 集成，使大模型能够直接与数据库交互。
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - 让 AI 工具直接连接 Airtable。可用自然语言查询、创建、更新和删除记录。功能包括库管理、表操作、结构操作、记录筛选和通过标准化 MCP 接口进行数据迁移。
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis 官方 MCP 服务器，提供管理与搜索 Redis 数据的接口。
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - 基于 SQLAlchemy 的通用数据库集成，支持 PostgreSQL、MySQL、MariaDB、SQLite、Oracle、MS SQL Server 等。具备结构与关系检查、大型数据集分析能力。
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Pinecone 集成，具备向量检索能力
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - 无服务器 MariaDB 云数据库 MCP 服务器。支持启动、删除、执行 SQL 及与数据库级 AI 代理协作实现精准 text-2-sql 和对话。
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - 官方 Supabase MCP 服务器，让 AI 助手直接连接 Supabase 项目，实现表管理、配置获取与数据查询等任务。
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 通用数据库 MCP 服务器，支持 PostgreSQL、Redshift、CockroachDB、MySQL、RDS MySQL、Microsoft SQL Server、BigQuery、Oracle DB 和 SQLite 等多种数据库类型。
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - TDolphinDB 数据库集成，支持结构检查与查询能力
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - MCP 服务器，可将 Weaviate 集合作为知识库及聊天记忆存储使用。
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — 一款支持使用自然语言查询数据库并获取数据的 MCP 服务器，采用 XiyanSQL 作为 text-to-SQL 大模型。
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - 与 Google Sheets 交互的 Model Context Protocol 服务器。可通过 Google Sheets API 创建、读取、更新和管理表格。
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Google Sheets API 集成的 MCP 服务器，具备全面读写、格式化与表管理能力。
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – 基于 Golang 的易用零依赖 MySQL MCP 服务器，支持可配置只读模式和结构检查。
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - 用于与 [YDB](https://ydb.tech) 数据库交互的 MCP 服务器
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Milvus / Zilliz 的 MCP 服务器，实现数据库交互能力。
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - 通过 Java Database Connectivity (JDBC) 协议实现通用数据库管理系统 (DBMS) 连接的 MCP 服务器
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - 用于与 VictoriaMetrics 数据库交互的 MCP 服务器。
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix 时序数据湖集成，为基于大模型的工作流提供结构探索和查询能力。
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 A – 面向 cursor 和 n8n 的用户友好型只读 mysql mcp 服务器...


### 📊 <a name="data-platforms"></a>数据平台

用于数据集成、转换和数据管道编排的数据平台。

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - 与 Flowcore 交互以执行操作、摄取数据，并以自然语言分析、交叉引用和利用任何数据核心或公共数据核心中的数据。
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - 连接 Databricks API，让大模型运行 SQL 查询、列出作业和获取作业状态。
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - 连接 Databricks Genie API 的服务器，让大模型用自然语言提问、运行 SQL 查询并与 Databricks 对话代理交互。
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Qlik Cloud API 的 MCP 服务器，支持查询应用、表单及从可视化中提取数据，具备全面身份认证和速率限制支持。
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - 与 Keboola Connection Data Platform 交互。支持列出和访问 Keboola Storage API 的数据。
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - 官方 [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt) MCP 服务器，集成 dbt Core/Cloud CLI，支持项目元数据发现、模型信息和语义层查询能力。
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - 面向 dbt-core (OSS) 用户的 MCP 服务器（官方 dbt MCP 仅支持 dbt Cloud）。支持项目元数据、模型和字段级血缘关系及 dbt 文档。

### 💻 <a name="developer-tools"></a>开发者工具

增强开发流程和环境管理的工具与集成。

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - 识别 macOS 上资源消耗高的进程，并提供性能优化建议。
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - 创建灵感源自顶级 21st.dev 设计工程师的定制 UI 组件。
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - 集成 [QA Sphere](https://qasphere.com/) 测试管理系统，让大模型可直接在 AI IDE 中发现、总结和交互测试用例
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - 分析代码库中的依赖关系，识别关键文件。生成依赖图和重要性评分，帮助 AI 助手理解代码库。
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 iOS 模拟器控制的 MCP 服务器实现。
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 支持查询和管理 [Apache APISIX](https://github.com/apache/apisix) 所有资源的 MCP 服务器。
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 -  提供 SonarQube 项目指标（实时与历史）、问题、健康状态等信息的 Model Context Protocol (MCP) 服务器。
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - 无缝集成任意 API 与 AI 代理（支持 OpenAPI Schema）
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - 本地分析 React 代码，一次性为整个项目生成文档/llm.txt
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - POX SDN 控制器的 MCP 服务器，实现网络控制和管理功能。
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - CodeLogic 官方 MCP 服务器，提供代码依赖分析、架构风险分析和影响评估工具。
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - 用自然语言探索由 Opik 捕获的 LLM 可观测性、追踪与监控数据。
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ 使 AI 代理能够修复 CircleCI 的构建失败。
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ 使 AI 代理能够修复 [Currents](https://currents.dev) 上报告的 Playwright 测试失败。
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - 与 [Postman API](https://www.postman.com/postman/postman-public-workspace/) 交互
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - 让 AI 助手与 [Flipt](https://flipt.io) 的特性开关直接交互。
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - 让编码代理直接访问 Figma 数据，助力一键式设计实现。
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - 与 [Firefly](https://firefly.ai) 集成，实现云资源发现、管理与代码化。
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - 通过 MCP 工具为大模型提供特定 Rust crate 的最新文档上下文，采用语义搜索（嵌入）和 LLM 总结。
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Excel 操作服务器，支持工作簿创建、数据操作、格式化和高级功能（图表、数据透视表、公式）。
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - 提供全面工具用于管理 [Higress](https://github.com/alibaba/higress) 网关配置和运维的 MCP 服务器。
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - 用于替代 Postman/Insomnia 等 Rest 客户端的 MCP 服务器，使 LLM 能够维护和使用 API 集合。
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - 用于与 [Go 的语言服务器协议（gopls）](https://github.com/golang/tools/tree/master/gopls) 交互并享受高级 Go 代码分析功能的 MCP 服务器。
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - 用于与 [Bruno API 客户端](https://www.usebruno.com/) 交互的 MCP 服务器。
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - 通过 MCP 利用 AI 控制 Android 设备，实现设备控制、调试、系统分析和 UI 自动化，并具备完备的安全框架。
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - 通过 MCP 利用 AI 控制 HarmonyOS-next 设备。支持设备控制和 UI 自动化。
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - 使用 Gradle Tooling API 进行 Gradle 集成，可检查项目、执行任务并按测试报告测试结果。
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - 用于本地压缩各种图像格式的 MCP 服务器。
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP 语言服务器为启用 MCP 的客户端提供语义工具，如获取定义、引用、重命名和诊断，帮助轻松导航代码库。
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - 用于与 iOS 模拟器交互的模型上下文协议（MCP）服务器。可获取模拟器信息、控制 UI 交互和检查 UI 元素。
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - 通过自然语言命令使 LLM 能与 iOS 模拟器（iPhone、iPad 等）交互的模型上下文协议（MCP）服务器。
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - 为 Vercel AI SDK 文档提供 AI 驱动搜索与查询能力的模型上下文协议（MCP）服务器。
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - 使用 [SQLGlot](https://github.com/tobymao/sqlglot) 提供 SQL 分析、代码检查和方言转换的 MCP 服务器。
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - 一个 MCP 服务器和 VS Code 插件，支持（语言无关的）断点和表达式求值实现自动调试。
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - 连接 JetBrains IDE。
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - 用于性能测试的 JMeter MCP 服务器。
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - 个人 MCP（模型上下文协议）服务器，用于通过 macOS 钥匙串安全存储和访问跨项目 API 密钥。
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - 用于与 App Store Connect API 通信的 MCP 服务器，适用于 iOS 开发者。
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - 控制 iOS 模拟器的 MCP 服务器。
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - 用于性能测试的 Grafana k6 MCP 服务器。
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - 支持多个独立实例共存，并拥有唯一命名空间和配置的 MCP 中间件服务器。
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - 用于访问和管理使用 [Langfuse]([https://langfuse.com/](https://langfuse.com/docs/prompts/get-started)) 创建的 LLM 应用提示词的 MCP 服务器。
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - 用于 Android/iOS 应用和设备自动化、开发和应用抓取的 MCP 服务器。支持模拟器/仿真器/物理设备，如 iPhone、Google Pixel、Samsung。
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - 用于性能测试的 Locust MCP 服务器。
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - 简单的 MCP 服务器，为 Cline 和 Cursor 等工具实现人类反馈在环的工作流。
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - 使用 [gitingest](https://github.com/cyclotruc/gitingest) 将任意 Git 仓库转换为简单文本摘要的 MCP 服务器。
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - 让你首选的 AI agent 基于代码库或 Jira、Slack、TestRail 等数据源创建并运行全托管的 [Octomind](https://www.octomind.dev/) 端到端测试。
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - 通过 MCP Resources 高效访问 OpenAPI/Swagger 规范，节省 Token。
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - 该 MCP 服务器提供使用 wget 下载整个网站的工具。保留网站结构并转换链接以实现本地访问。
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - 为 LLM 提供准确的 NixOS 包、系统选项、Home Manager 配置和 nix-darwin macOS 设置信息，防止 AI 产生幻觉的 MCP 服务器。
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - 通过 MCP 进行 Docker 容器管理与操作。
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - 集成 Docker，实现容器、镜像、卷和网络的管理。
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - 用于项目管理、文件操作和构建自动化的 Xcode 集成。
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - 让 LLM 完全了解你的 OpenAPI 规范，实现发现、解释及代码/模拟数据生成的 MCP 服务器。
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - 用于 [Rootly](https://rootly.com/) 事件管理平台的 MCP 服务器。
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - 帮助 LLM 在写代码时建议最新稳定包版本的 MCP 服务器。
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - 集成 SonarQube，为 AI 助手提供代码质量指标、问题和质量门状态的模型上下文协议（MCP）服务器。
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - 基于 MCP 实现 Claude Code 能力，支持 AI 代码理解、修改与项目分析及全面工具支持。
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - 通过 Open API 规范（v3）连接任意 HTTP/REST API 服务器。
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - 用于 LLDB 的 MCP 服务器，支持 AI 二进制和核心文件分析、调试、反汇编。
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - 用于部署 HTML 内容到 EdgeOne Pages 并获取公开可访问 URL 的 MCP 服务。
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - 一款面向 LLM 工具优化的行导向文本文件编辑器，支持高效的部分文件访问以降低 Token 使用。
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - 基于 Pandoc 的文档格式无缝转换 MCP 服务器，支持 Markdown、HTML、PDF、DOCX（.docx）、csv 等。
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - 连接 VSCode IDE 并使用如 `find_usages` 等语义工具。
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 构建 iOS Xcode 工作区/项目并将错误反馈给 llm。
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - 基于 JVM 的 MCP（模型上下文协议）服务器实现项目。
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - 通过官方客户端连接 [Apache Airflow](https://airflow.apache.org/) 的 MCP 服务器。
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - 用于生成美观交互式思维导图的模型上下文协议（MCP）服务器。
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - 查询多个 Ollama 模型并汇总回复，为同一问题提供多元 AI 观点的模型上下文协议（MCP）服务器。
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - 高效为 agent 提供 Typescript API 信息，使其能够处理未训练的 API 的 MCP 服务器。
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - 灵活抓取 JSON、文本和 HTML 数据的 MCP 服务器。
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - 用于连接你的 [ZenML](https://www.zenml.io) MLOps 和 LLMOps 流水线的 MCP 服务器。
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) 是一个通用远程 MCP 服务器，用于连接任意 [GitHub](https://www.github.com) 仓库或项目文档。
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - 用于与 [Bugsnag](https://www.bugsnag.com/) 交互的 MCP 服务器。
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - 针对 CSV 文件的 MCP 服务器。
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – 专为编程设计的任务管理系统，为 Cursor AI 等编码代理提供高级任务记忆、自我反思和依赖管理。[ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - 通过 Docker 本地运行代码并支持多种编程语言的 MCP 服务器。
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - 查询 pkg.go.dev 上的 Go 包信息。
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - 零配置 Go 库，自动将现有 Gin Web 框架 API 以 MCP 工具形式暴露。
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - GitHub Repo MCP 允许你的 AI 助手浏览 GitHub 仓库、浏览目录和查看文件内容。
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – 基于 FastMCP 的服务器，用于与 webhook-test.com 交互。允许用户通过 Claude 本地创建、获取和删除 webhook。
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ROS MCP 服务器支持机器人控制，将用户自然语言命令转换为 ROS 或 ROS2 控制指令。
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - Globalping MCP 服务器为用户和 LLM 提供从全球数千地点运行 ping、traceroute、mtr、HTTP 及 DNS 解析等网络工具的能力。
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - 用于与 PostHog 分析、功能标志、错误追踪等交互的 MCP 服务器。
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - 用于搜索并获取 NPM、Cargo、PyPi、NuGet 包最新信息的 MCP 服务器。

### 🔒 <a name="delivery"></a>配送

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash 配送（非官方）

### 🧮 <a name="data-science-tools"></a>数据科学工具

用于简化数据探索、分析并提升数据科学工作流的集成与工具。

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - 使用 Chronulus AI 预测和预测代理预测任何事物。
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - 使 .csv 数据集的自主数据探索变得简单，智能洞察只需最少操作。
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - 将几乎任何文件或网页内容转换为 Markdown 的 MCP 服务器。
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Jupyter 的模型上下文协议（MCP）服务器。
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - 将 Jupyter Notebook 连接到 Claude AI，使 Claude 能够直接交互和控制 Jupyter 笔记本。
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - 连接 Kaggle，支持下载和分析数据集。
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - 链接多个数据源（SQL、CSV、Parquet 等），让 AI 分析数据并给出洞察和可视化。
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - 创建经过验证和可维护的数据图表和仪表盘的工具和模板。
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — 用于创建和交互 GrowthBook 功能标志和实验的工具。

### 📟 <a name="embedded-system"></a>嵌入式系统

提供嵌入式设备开发的文档和快捷方式。

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - 针对 ESP32 系列芯片使用 ESP-IDF 修复构建问题的工作流。
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - 标准化和语境化工业 Modbus 数据的 MCP 服务器。
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - 连接 OPC UA 工业系统的 MCP 服务器。
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - GNU Radio 的 MCP 服务器，允许 LLM 自动创建和修改 RF `.grc` 流程图。

### 📂 <a name="file-systems"></a>文件系统

提供对本地文件系统的直接访问并具备可配置权限。支持 AI 模型在指定目录内读取、写入和管理文件。

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - 通过 MCP 或剪贴板与 LLM 共享代码上下文。
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - 文件合并工具，适用于 AI 聊天长度限制。
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - 基于 Quarkus、Java 实现的文件系统，支持浏览和编辑文件。可作为 jar 或原生镜像使用。
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - Box 集成，用于列出、读取和搜索文件
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - 基于 Everything SDK 的快速 Windows 文件搜索
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - 基于 Golang 的本地文件系统访问实现。
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - 远程存储访问：SFTP、S3、FTP、SMB、NFS、WebDAV、GIT、FTPS、gcloud、azure blob、sharepoint 等。
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCP 工具访问 MarkItDown —— 一个将多种文件格式（本地或远程）转换为 Markdown 以供 LLM 使用的库。
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - 直接本地文件系统访问。
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Google Drive 集成，用于列出、读取和搜索文件
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - 使用 Apache OpenDAL™ 访问任意存储
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - 通过此 MCP 服务器，使用自然语言控制你的 macOS Homebrew 配置。轻松管理你的软件包，或请求建议、排查 brew 问题等。

### 💰 <a name="finance--fintech"></a>金融与金融科技

金融数据访问与分析工具。使 AI 模型能够处理市场数据、交易平台及金融信息。

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - 针对加密领域的深度研究——免费且完全本地化
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - 允许 AI agent 与 Alchemy 的区块链 API 交互。
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AI Agent 用于集成私有及公共市场数据
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - 集成 Coinmarket API 获取加密货币列表和行情
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - 使 AI LLM 能够使用 MetaTrader 5 平台进行交易
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - MCP 可对接多条区块链，支持质押、DeFi、兑换、跨链、钱包管理、定投、限价单、币种查询、追踪等。
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - Bankless Onchain API 支持与智能合约交互，查询交易及代币信息
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Base Network 链上工具集成，支持钱包管理、资金转账、智能合约、DeFi 操作及 Coinbase API 交互
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage API 集成，获取股票与加密货币信息
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - EVM 区块链地址（EOA、CA、ENS）甚至域名的风险评分/资产持有情况。
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - Bitte Protocol 集成，在多链上运行 AI Agent。
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - 连接 AI agent 与 [Chargebee 平台](https://www.chargebee.com/) 的 MCP 服务器。
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - [Codex API](https://www.codex.io) 集成，为 60+ 网络提供实时丰富的区块链与市场数据
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - Coinpaprika 的 DexPaprika MCP 服务器，开放高性能 [DexPaprika API](https://docs.dexpaprika.com) 覆盖 20+ 链和 500 万+ 代币，包含实时价格、流动池和历史 OHLCV 数据，为 AI agent 提供标准化、全面的市场数据访问。
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - 基于 CCXT 库，访问 20+ 交易所的实时加密货币市场数据及交易，包括现货、期货、OHLCV、余额、订单等。
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Yahoo Finance 集成，获取股票市场数据及期权推荐
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - Tastyworks API 集成，处理 Tastytrade 平台的交易活动
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - Reddit 集成，分析 WallStreetBets 社区内容
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - 基于 Nostr Wallet Connect 的比特币闪电钱包集成
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - 通过 Heurist Mesh 网络访问区块链分析、智能合约安全审计、代币指标评估和链上交互的专用 web3 AI agent。为 DeFi 分析、NFT 估值和多链交易监控提供全面工具。
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - Beeper 提供 BSC 上的交易，包括余额/代币转账、Pancakeswap 代币兑换及奖励领取。
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ -  一个为 AI agent 推送 BlockBeats 区块链新闻和深度文章的 MCP 服务器。
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - 向链上 AI agent 提供实时跨链桥汇率及最优转账路径。
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ -  实时访问 Chainlink 去中心化链上价格喂价。
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ -  实时访问 Cointelegraph 最新新闻。
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ -  提供实时和历史加密恐惧与贪婪指数数据。
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - 提供多种加密货币技术分析指标与策略的 MCP 服务器。
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - 为 AI agent 提供实时加密新闻，数据来源于 NewsData。
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - 用于跟踪和管理加密货币投资组合配置的 MCP 服务器。
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - 聚合来自多 RSS 源的实时加密货币新闻的 MCP 服务器。
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - 提供加密货币情绪分析数据的 MCP 服务器。
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - 跟踪 CoinGecko 上最新热门代币。
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - 作为加密白皮书的结构化知识库。
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - 基于 CryptoPanic 为 AI agent 提供最新加密新闻。
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - 让 AI agent 探索 DeFi 收益机会的 MCP 服务器。
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ -  一个将 Dune Analytics 数据桥接到 AI agent 的 mcp 服务器。
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ -  推送加密 ETF 资金流数据，助力 AI agent 决策。
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - 集成 Freqtrade 加密货币量化交易机器人的 MCP 服务器。
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - 提供主要加密交易所的实时资金费率数据。
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - 基于 Jupiter 新 Ultra API 实现 Solana 区块链代币兑换的 MCP 服务器。
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ -  跟踪 Pancake Swap 新创建池子的 MCP 服务器。
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - 检测 Solana meme token 潜在风险的 MCP 服务器。
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ -  基于 The Graph 索引区块链数据，为 AI agent 赋能的 MCP 服务器。
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ -  提供 AI agent 在多链上铸造 ERC-20 代币工具的 MCP 服务器。
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - 检查并撤销多链 ERC-20 代币授权的 MCP 服务器。
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - 跟踪 Twitter 用户名历史变更的 MCP 服务器。
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ -  跟踪多链 Uniswap 新建流动性池的 MCP 服务器。
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ -  支持 AI agent 在多链 Uniswap DEX 自动换币的 MCP 服务器。
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ -  跟踪加密大额交易（鲸鱼交易）的 mcp 服务器。
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Alpaca 交易 API 的 MCP 服务器，管理股票和加密投资组合、下单及访问市场数据。
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPI 提供实时股票市场数据，通过 MCP 支持 AI 分析及交易能力。
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - 支持 30+ EVM 网络的区块链综合服务，涵盖原生代币、ERC20、NFT、智能合约、交易及 ENS 解析等。
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - 全面的 Starknet 区块链集成，支持原生代币（ETH、STRK）、智能合约、StarknetID 解析与代币转账。
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 -  基于 ledger-cli 的财务交易管理与报表生成集成。
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 -  核心银行集成，支持客户、贷款、储蓄、股份、金融交易管理及财务报表生成。
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - 基于 yfinance 获取 Yahoo Finance 信息的 MCP 服务器。
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ -  提供 [Polygon.io](https://polygon.io/) 金融市场数据 API（股票、指数、外汇、期权等）的 MCP 服务器。
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ -  Bitget API 获取加密货币价格。
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - 使用 CoinCap 公共 API 集成实时加密货币市场数据，无需 API key 提供价格和市场信息。
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - 基于 CoinGecko API 的加密货币市场数据 MCP 工具。
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - yahoo finance mcp 的 TS 版本。
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - 基于 Yahoo Finance API 的股票市场数据及分析 MCP 工具。
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - XRPL 账本的 MCP 服务器，提供账户信息、交易历史、网络数据访问。支持账本对象查询、提交交易及 XRPL 网络监控。
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - 基于开放免费 Dexscreener API 的实时链上市场价格
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - 基于 baostock 的 MCP 服务器，提供中国股市数据访问与分析能力。
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - 基于 Solscan API，用自然语言查询 Solana 交易的 MCP 工具。
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - 与 CRIC Wuye AI 平台能力交互的 MCP 服务器，专为物业管理行业设计的智能助手。
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - 专业金融数据访问 MCP 服务器，支持包括 Tushare 在内的多数据源。

### 🎮 <a name="gaming"></a>游戏

与游戏相关数据、游戏引擎及服务的集成

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - Unity 编辑器及 Unity 游戏的 MCP 服务器
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Unity3d 游戏引擎集成 MCP 服务器，用于游戏开发
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - 用于与 Godot 游戏引擎交互的 MCP 服务器，提供编辑、运行、调试和场景管理工具。
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - 通过标准化 MCP 接口访问 Chess.com 玩家数据、棋局记录及其他公开信息，助力 AI 助手搜索与分析国际象棋信息。
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - 与 LLM 对弈国际象棋的 MCP 服务器。
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - 实时英超梦幻联赛数据及分析工具的 MCP 服务器。
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - 实时访问热门游戏（如英雄联盟、云顶之弈、无畏契约）数据，提供英雄分析、电竞日程、阵容、角色统计等。
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - 与 RuneScape（RS）及 Old School RuneScape（OSRS）数据交互的 MCP 服务器，包括物价、玩家天梯等工具。

### 🧠 <a name="knowledge--memory"></a>知识与记忆

使用知识图谱结构进行持久化记忆存储。使 AI 模型能够跨会话维护和查询结构化信息。
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - 增强型基于图的记忆，专注于 AI 角色扮演和故事生成
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - 可将 Slack、Discord、网站、Google Drive、Linear 或 GitHub 的内容导入 Graphlit 项目，然后在 Cursor、Windsurf 或 Cline 等 MCP 客户端中检索和搜索相关知识。
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - 一种 MCP 服务器实现，通过向量检索为文档检索和处理提供工具，使 AI 助手能够用相关文档上下文增强回复内容。
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - 基于 [markmap](https://github.com/markmap/markmap) 构建的 MCP 服务器，将 **Markdown** 转换为交互式**思维导图**。支持多格式导出（PNG/JPG/SVG）、浏览器实时预览、一键复制 Markdown 及动态图形可视化等功能。
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - 让 LLM 能够与您的 Zotero 云端文献及来源协作的连接器
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI 摘要 MCP 服务器，支持多种内容类型：纯文本、网页、PDF 文件、EPUB 电子书、HTML 内容
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Mem0 的 Model Context Protocol 服务器，帮助管理编码偏好和模式，为在 Cursor、Windsurf 等 IDE 中存储、检索和语义处理代码实现、最佳实践及技术文档提供工具
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - 基于知识图谱的持久化记忆系统，用于维护上下文
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - 连接您的 Pinecone Assistant，为代理提供其知识引擎的上下文。
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - 从您的 [Ragie](https://www.ragie.ai)（RAG）知识库检索上下文，支持与 Google Drive、Notion、JIRA 等集成。
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - 让 Cursor、VS Code 或 Claude Desktop 等 AI 工具通过您的产品文档答疑。Biel.ai 提供 RAG 系统与 MCP 服务器。
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - 为 AI 应用和代理管理记忆，支持多种图结构和向量存储，可接入 30 多种数据源
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - 通过 Membase 分布式保存和查询代理记忆
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - 使用 GitHub Gists 管理和访问您的个人知识、每日笔记和可复用提示。可作为 https://gistpad.dev 及 [GistPad VS Code 扩展](https://aka.ms/gistpad) 的配套工具。
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - 实现 Zettelkasten 知识管理法的 Model Context Protocol (MCP) 服务器，支持通过 Claude 及其他 MCP 兼容客户端创建、链接和检索原子笔记。

### 🗺️ <a name="location-services"></a>定位服务

基于地理位置的服务与地图工具。使 AI 模型能够处理地理数据、天气信息和位置分析。

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - 使用 IPInfo API 获取 IP 地址地理定位和网络信息
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - 使用 WeatherAPI.com API 获取任意位置实时天气数据，提供详细预报和当前状况。
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - 基于 OpenStreetMap 的 MCP 服务器，支持定位服务及地理空间数据。
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - 支持基于 IP 的位置检测的附近地点搜索 MCP 服务器。
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Google Maps 集成，支持定位服务、路线规划和地点详情
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - 通过 MCP 连接 QGIS Desktop 与 Claude AI，实现提示辅助项目创建、图层加载、代码执行等
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - 基于 OpenWeatherMap API 的 MCP 工具，提供实时天气数据、天气预报及历史天气信息。
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - 每周天气 MCP 服务器，全球任意地点提供 7 天详细天气预报。
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - 获取任意时区时间和当前本地时间
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - 通过 AccuWeather API 获取精准天气预报（有免费额度）。
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - nominatim、ArcGIS、Bing 的地理编码 MCP 服务器
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - 基于 [IP Find](https://ipfind.com) API 的 IP 地址定位服务
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – 一种 Model Context Protocol (MCP) 服务器实现，将 LLM 连接到 GeoServer REST API，使 AI 助手可与地理空间数据与服务交互。
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Aiwen IP 定位的 MCP 服务器，获取用户网络 IP 定位，获取 IP 详情（国家、省份、城市、经纬度、ISP、归属人等）

### 🎯 <a name="marketing"></a>营销

用于创建和编辑营销内容、处理网页元数据、产品定位及编辑指南的工具。

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - 作为 Facebook 广告接口的 MCP 服务器，实现对 Facebook 广告数据及管理功能的编程访问。
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Open Strategy Partners 出品的营销工具套件，包括写作风格、编辑规范和产品营销价值地图创建等。
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - 支持 AI 代理监控和优化 Meta 广告表现、分析活动指标、调整受众、管理创意资产，并通过无缝 Graph API 集成为广告投放和设置做出数据驱动建议。
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - 实现与 Amazon Advertising 交互，分析广告活动指标和配置。

### 📊 <a name="monitoring"></a>监控

访问和分析应用监控数据。让 AI 模型能够审查错误报告和性能指标。

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - 使用所有可观测性数据进行发现、探索、报告和根因分析，包括指标、日志、系统、容器、进程和网络连接
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - 在您的 Grafana 实例中搜索仪表盘、调查事件及查询数据源
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - 允许通过 Grafana API 查询 Loki 日志的 MCP 服务器。
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - 通过智能提示分析，从复杂性到安全漏洞等 10 个关键维度提升 AI 生成代码质量
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - 无缝将生产实时上下文（日志、指标和追踪）带入本地环境，加速自动修复代码
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - 查询和交互由 Metoro 监控的 kubernetes 环境
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Raygun API V3 集成，用于崩溃报告和真实用户监控
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Sentry.io 集成，实现错误追踪与性能监控
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - 通过 Logfire 提供 OpenTelemetry 追踪和指标访问
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - 系统监控工具，通过 Model Context Protocol（MCP）暴露系统指标，让 LLM 通过 MCP 接口实时获取系统信息。（支持 CPU、内存、磁盘、网络、主机、进程）
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - 全面集成 [VictoriaMetrics 实例 API](https://docs.victoriametrics.com/victoriametrics/url-examples/) 及[文档](https://docs.victoriametrics.com/)，支持监控、可观测性和调试

### 🎥 <a name="multimedia-process"></a>多媒体处理

提供多媒体（如音视频）编辑、播放、格式转换能力，也包括视频滤镜、增强等功能

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - 基于 ffmpeg 命令行实现的 MCP 服务器，可通过对话方式便捷实现本地视频搜索、剪辑、拼接、播放等功能
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - 支持查看图像元数据（如 EXIF、XMP、JFIF 和 GPS）的 MCP 服务器，为 LLM 驱动的图片库搜索和分析提供基础。
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - 基于计算机视觉 🪄 的图像识别和编辑工具，为 AI 助手提供魔法般的体验。

### 🔎 <a name="search"></a>搜索与数据提取

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - 实现 YouTube 搜索及字幕检索功能的 MCP（Model Context Protocol）服务器，使语言模型或其他代理可通过标准协议便捷查询 YouTube 内容。
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - MCP 服务器，允许 AI 助手使用 Wolfram Alpha API 实时获取计算知识和数据。
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context Protocol 服务是 Google SERP API 的 MCP 服务器连接器，支持 MCP 体系内网页搜索。
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - 支持按日期、关键字、远程选项等筛选的招聘信息搜索 MCP 服务器。
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi 搜索 API 集成
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  LLM 用于搜索和阅读 arXiv 论文的 MCP
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ PapersWithCode API 检索 MCP
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  LLM 用于搜索和阅读 PubMed 医学/生命科学论文的 MCP
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - 使用 NYTimes API 搜索新闻
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - Apify 开源 RAG Web Browser Actor 的 MCP 服务器，支持网页搜索、抓取 URL 并以 Markdown 返回内容。
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojars MCP 服务器，获取 Clojure 库的最新依赖信息
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - ArXiv 论文检索
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - 发现、提取并交互式操作全网数据，一站式自动化公开互联网访问接口。
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Google 新闻集成，自动话题分类、多语言支持、包括头条、新闻、相关话题搜索等，基于 [SerpAPI](https://serpapi.com/)。
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - 基于 Python 的 MCP 服务器，提供 OpenAI `web_search` 内置工具。
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - DealX 平台的 MCP 服务器
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - 通过 [Trieve](https://trieve.ai) 爬取、嵌入、分块、搜索和检索数据集信息
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - 访问 [Dumpling AI](https://www.dumplingai.com/) 的数据、网页抓取与文档转换 API
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - 检索 Hacker News、获取热门新闻等的 MCP 服务器。
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – 让 AI 助手（如 Claude）使用 Exa AI Search API 进行网页搜索的 Model Context Protocol (MCP) 服务器。该方案使 AI 模型能以安全可控的方式获取实时网络信息。
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - 通过 search1api 搜索（需付费 API Key）
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - 提供 PubMed、ClinicalTrials.gov、MyVariant.info 数据访问的生物医学研究服务器。
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Unsplash 图片搜索 MCP 服务器。
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - [SearXNG](https://docs.searxng.org) 的 Model Context Protocol 服务器
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Naver 搜索 API 的 MCP 服务器，支持博客、新闻、购物搜索及 DataLab 分析功能。
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - 基于 Playwright 无头浏览器抓取网页内容的 MCP 服务器，支持 Javascript 渲染与智能内容提取，输出 Markdown 或 HTML。
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - 强大的 Google 搜索 MCP 服务器，支持多关键字并行搜索。
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - 网页截图 MCP 服务器，可用于 UI 开发反馈。
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - 基于 Microsoft Bing Search API 的网页搜索能力
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – 官方 Kagi 搜索 MCP 服务器
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI 搜索 API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - 使用 Brave 搜索 API 提供网页、图片、新闻、视频和本地兴趣点的搜索能力
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - 以 MIDI 方式播放 [Melrōse](https://melrōse.org) 音乐表达式
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - 使用 Brave 搜索 API 实现网页搜索功能
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - 为 AI 消费高效抓取与处理网页内容
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - 在 Google 上搜索并对任意主题进行深度网络研究
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - 使用 DuckDuckGo 进行网页搜索
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - 通过结构化搜索功能访问荷兰议会（Tweede Kamer）信息，包括文档、辩论、活动和立法案件（基于 Bert Hubert 的 opentk 项目）
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - 提供类似 OpenAI/Perplexity 的自主深度研究、结构化查询扩展和简明报告的 MCP 服务器。
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - 连接 searXNG 实例的 MCP 服务器
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - 获取 arXiv 论文的 LaTeX 源文件以处理数学内容和公式
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - 一个从 GeekNews 站点获取和处理新闻数据的 MCP 服务器。
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - 提供 [AgentQL](https://agentql.com) 数据抽取能力的 MCP 服务器。
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI 搜索 API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - [Vectorize](https://vectorize.io) MCP 服务器，支持高级检索、私有深度研究、任意文件转 Markdown 抽取和文本分块。
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - 与 [WebScraping.ai](https://webscraping.ai) 交互，实现网页数据提取和爬取。
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - 基于 TypeScript 的 MCP 服务器，提供 DuckDuckGo 搜索功能。
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - 通过 ZoomEye MCP Server 查询网络资产信息
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - 使用 Web Platform API 搜索 Baseline 状态的 MCP 服务器
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - 与 BioThings API 交互的 MCP 服务器，包括基因、基因变异、药物和分类信息
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - 一个用于搜索和下载 Pexels 及 Unsplash 免版权图库的 MCP 服务器。支持多提供商搜索、丰富元数据、分页、异步性能，帮助 AI 助理查找与获取高质量图片。 

### 🔒 <a name="security"></a>安全

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - 用于 Ghidra 的 Model Context Protocol 服务器，使 LLM 能够自主逆向工程应用。提供二进制反编译、方法和数据重命名、方法/类/导入/导出列表等工具。
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - 使 Agentic AI 能够安全获取 1Password 凭证的 MCP 服务器。
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – 允许 AI 代理与 Authenticator App 交互的安全 MCP（Model Context Protocol）服务器。
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - 将 Ghidra 集成到 AI 助理的 MCP 服务器。插件支持二进制分析，包括函数检查、反编译、内存浏览、导入/导出分析等。
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 MCP 服务器，用于分析来自 Azure 租户枚举的 ROADrecon 结果
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - dnstwist 的 MCP 服务器，一个强大的 DNS 模糊测试工具，用于检测拼写劫持、网络钓鱼和企业间谍行为。
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - maigret 的 MCP 服务器，一个强大的 OSINT 工具，收集各种公开来源的用户账户信息。可搜索社交网络用户名并分析 URL。
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - 查询 Shodan API 和 Shodan CVEDB 的 MCP 服务器。支持 IP 查询、设备搜索、DNS 查询、漏洞查询、CPE 查询等功能。
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - 查询 VirusTotal API 的 MCP 服务器。可扫描 URL、分析文件哈希并获取 IP 报告。
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - Binary Ninja 插件、MCP 服务器及桥接工具，将 [Binary Ninja](https://binary.ninja) 无缝集成至 MCP 客户端，实现二进制分析与逆向工程自动化。
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - 查询 ORKL API 的 MCP 服务器。支持获取威胁报告、分析威胁行为体、检索情报源等工具。
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - 基于 Rust 的 MCP 服务器，集成 Cortex，实现可观测分析及通过 AI 的自动化安全响应。
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - 基于 Rust 的 MCP 服务器，集成 TheHive，实现通过 AI 的协同安全事件响应与案例管理。
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - 基于 Rust 的 MCP 服务器，将 Wazuh SIEM 与 AI 助理桥接，提供实时安全告警和事件数据以增强上下文理解。
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - 访问 [Intruder](https://www.intruder.io/)，帮助你识别、理解并修复基础设施安全漏洞的 MCP 服务器。
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - 连接到 CCTV 录像软件（VMS）的 Model Context Protocol (MCP) 服务器，可检索录像和实时视频流，并支持如指定通道播放实时/回放等操作。
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ 一个强大的 MCP（Model Context Protocol）服务器，审计 npm 包依赖的安全漏洞。集成远程 npm registry，实现实时安全检查。
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ 允许 AI 代理使用 [Semgrep](https://semgrep.dev) 扫描代码安全漏洞。
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - 与 CyberChef 服务器 API 交互的 MCP 服务器，使 MCP 客户端能利用 CyberChef 操作。
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - IDA Pro 的 MCP 服务器，允许 AI 助理进行二进制分析。支持反编译、反汇编，并可自动生成恶意软件分析报告。
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - RAD Security 的 MCP 服务器，为 Kubernetes 和云环境提供 AI 驱动的安全洞见。支持查询 Rad Security API，获取安全发现、报告、运行时数据等。
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - 集成主流开源安全工具的全能安全测试工具箱，通过单一 MCP 接口与 AI 代理对接，实现渗透测试、漏洞赏金、威胁狩猎等任务。
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - 针对 CVE-Search API 查询的 Model Context Protocol (MCP) 服务器。可全面访问 CVE-Search，浏览厂商/产品、按 CVE-ID 查询、获取最新 CVE 等。
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - 访问 OSV（开源漏洞）数据库。支持按包版本或提交查询、批量查询多个包、按 ID 获取详细漏洞信息。
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - 基于 httpx 和 asnmap 的对话式测绘接口和 MCP 服务器。支持域名分析、安全头检查、证书分析、ASN 查询等多级测绘功能。
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Volatility 3.x 的 MCP 服务器，使 AI 助理能够进行内存取证分析。插件如 pslist、netscan 可通过 REST API 和 LLM 便捷访问。
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - 运行于受信任执行环境（TEE）中的 MCP 服务器，基于 Gramine，通过 [RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html) 实现远程证明。MCP 客户端可在连接前验证服务器。
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADX-AI-MCP 是针对 JADX 反编译器的插件和 MCP 服务器，与 Model Context Protocol (MCP) 直接集成，为 Claude 等 LLM 提供实时逆向支持。
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - APKTool MCP 服务器，为 Apk Tool 实现 Android APK 逆向工程自动化。

### 🌐 <a name="social-media"></a>社交媒体

与社交媒体平台集成，实现发布、分析和互动管理。支持 AI 驱动的社交自动化。

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ 直接在 LLM 应用中访问 X/Reddit/YouTube 实时数据，支持关键词、用户和日期筛选。
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - 一站式 Twitter 管理方案，支持时间线访问、用户推文检索、话题标签监控、对话分析、私信、帖子情感分析及完整生命周期控制，通过简化 API 提供。
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - 集成 Facebook Pages，通过 Graph API 实现帖子、评论、互动指标的直接管理，优化社交媒体运营。
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - 使用 atproto 客户端与 Bluesky 交互的 MCP 服务器。

### 🏃 <a name="sports"></a>体育

访问体育相关数据、结果和统计信息的工具。

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - 集成 balldontlie api 的 MCP 服务器，提供 NBA、NFL 和 MLB 球员、球队和比赛信息
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - 通过自然语言访问自行车赛事数据、结果和统计。功能包括获取起跑名单、比赛成绩和 firstcycling.com 选手信息。
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - 连接 Strava API 的 Model Context Protocol (MCP) 服务器，为 LLM 提供访问 Strava 数据的工具
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - 集成 Squiggle API 的 MCP 服务器，提供澳大利亚足球联盟球队、排名、结果、预测和实力排名等信息。
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - 作为 MLB API 代理的 MCP 服务器，提供球员信息、统计和比赛数据。

### 🎧 <a name="support-and-service-management"></a>支持与服务管理

用于管理客户支持、IT 服务管理和工单运维的工具。

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - 集成 Freshdesk 的 MCP 服务器，使 AI 模型可操作 Freshdesk 各模块并进行多种支持任务。
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - 基于 Go 的 Jira MCP 连接器，使 Claude 等 AI 助理可与 Atlassian Jira 交互。支持常见 Jira 操作，包括问题管理、迭代计划和流程流转。
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian 产品（Confluence 和 Jira）的 MCP 服务器。支持 Confluence Cloud、Jira Cloud 及 Jira Server/Data Center。提供跨 Atlassian 工作区内容搜索、阅读、创建与管理的综合工具。

### 🌎 <a name="translation-services"></a>翻译服务

为 AI 助理在不同语言间翻译内容提供的工具与服务。

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Lara Translate API 的 MCP 服务器，支持强大的翻译能力，包括语言检测和上下文感知翻译。
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Weblate 翻译管理的全功能 Model Context Protocol 服务器，使 AI 助理可进行翻译、项目管理、内容发现和智能格式转换。

### 🎧 <a name="text-to-speech"></a>文本转语音

文本转语音及语音转文本的工具

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - 基于 Kokoro TTS 开源模型的 MCP 服务器，将文本转换为语音。可将文本转为 MP3 并本地保存或自动上传至 S3 存储桶。
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - 完整的语音交互服务器，支持语音转文本、文本转语音及本地麦克风、OpenAI 兼容 API、LiveKit 实时语音会话

### 🚆 <a name="travel-and-transportation"></a>旅行与交通

获取旅行与交通信息。支持查询时刻表、路线及实时出行数据。
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - 提供搜索 Airbnb 并获取房源详情的工具。
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - 集成美国国家公园管理局 API，提供美国国家公园的最新详情、警报、游客中心、露营地和活动信息。
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - 访问荷兰国家铁路（NS）的旅行信息、时刻表和实时更新。
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - 使 LLM 能够通过标准化 MCP 接口与 Tripadvisor API 交互，支持位置数据、评论和照片。
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - 英国国家铁路 MCP 服务器，提供火车时刻表和实时旅行信息，集成 Realtime Trains API。

### 🔄 <a name="version-control"></a>版本控制

与 Git 仓库和版本控制平台交互。通过标准化 API 实现仓库管理、代码分析、拉取请求处理、问题跟踪以及其他版本控制操作。

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - 使用 LLM 读取和分析 GitHub 仓库
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - 用于集成 GitHub Enterprise API 的 MCP 服务器
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - 与 Gitea 实例交互的 MCP 服务器。
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - 官方 GitHub 服务器，用于集成仓库管理、PR、问题等。
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - 无缝交互 GitLab 项目的问题与合并请求。
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - 直接对本地 Git 仓库进行读取、搜索与分析等操作
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - GitLab 平台集成，实现项目管理和 CI/CD 操作
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - 集成 Gitee API，仓库、问题、合并请求管理等功能。
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - Azure DevOps 集成，实现仓库管理、工作项和流水线操作。
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - 官方 AtomGit 服务器，集成仓库管理、PR、问题、分支、标签等。

### 🛠️ <a name="other-tools-and-integrations"></a>其他工具与集成

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ 允许 AI 模型与比特币交互，支持生成密钥、验证地址、解码交易、查询区块链等。
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - 允许 AI 从你的 Bear Notes（仅限 macOS）读取内容
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - 通过 MCP 服务器暴露所有 Home Assistant 语音意图，实现家庭控制。
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - 使用 Amazon Nova Canvas 模型进行图像生成。
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - 通过 MCP 协议，使用工具或预定义提示向 OpenAI、MistralAI、Anthropic、xAI、Google AI 或 DeepSeek 发送请求。需供应商 API 密钥
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 -  一个为你安装其他 MCP 服务器的 MCP 服务器。
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - 获取 YouTube 字幕
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  MCP 用于与 OpenAI 助手对话（Claude 可以用任何 GPT 模型作为助手）
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - 允许在客户端机器上检查本地时间或通过 NTP 服务器获取当前 UTC 时间的 MCP 服务器
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - 使用 3,000+ 预构建云工具（Actors）从网站、电商、社交媒体、搜索引擎、地图等提取数据
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCP 服务器让用户能够直接从 Claude 或任何 MCP 兼容应用生成 Midjourney/Flux/Kling/混元/Udio/Trellis 的媒体内容。
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - 通过 Replicate 的 API 生成图像。
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - 基础本地 taskwarrior 使用的 MCP 服务器（添加、更新、移除任务）
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - 与 Phabricator API 交互
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - 集成 Notion API，高效管理个人待办事项的 MCP 服务器。
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - 通过与 Bear 的 sqlitedb 直接集成，读取 Bear 笔记应用的笔记和标签。
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - MCP 服务器，使 Claude 能与 ChatGPT 对话并使用其网页搜索功能。
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - 允许 AI 查询 GraphQL 服务器
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - 此连接器允许 Claude Desktop（或任何 MCP 客户端）读取和搜索包含 Markdown 笔记的任意目录（如 Obsidian 保险库）。
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - 又一个用于测试 MCP 服务器的 CLI 工具
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - 集成 Notion API 管理个人待办事项列表
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - 轻量级 Wrike MCP 服务器，通过公共 API 与 Wrike 任务交互。
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) MCP 服务器，集成 TickTick API 管理个人待办项目与任务。
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - 通过 eSignatures API 起草、审阅和发送有法律约束力合同的合同与模板管理。
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - 访问 MIRO 白板，批量创建和读取项目。需 OAUTH 密钥用于 REST API。
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - 读取、创建、更新和删除 Google Keep 笔记。
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - 维基百科条目查询 API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - 使用常规 GraphQL 查询/变更定义工具，gqai 会自动为你生成 MCP 服务器。
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - 使 LLM 能使用计算器进行精确数值计算的服务器
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ 查询和执行 Dify 工作流的工具
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - 集成 Model Context Protocol (MCP)，允许 LLM 与 Raindrop.io 书签交互。
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ 允许 AI 客户端管理 Attio CRM 中的记录和笔记
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - 使用 VegaLite 格式和渲染器，从获取的数据生成可视化。
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - 连接 AI 助手与 Odoo ERP 系统，实现业务数据访问、记录管理和工作流自动化。
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - 在 Contentful 空间中更新、创建、删除内容、内容模型和资产
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - 让代理大声朗读内容，任务完成后用简要总结通知你
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - 用于访问 Climatiq API 的 Model Context Protocol (MCP) 服务器，计算碳排放。助力 AI 助手实时碳排放计算并提供气候影响洞察。
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Typst（基于标记的排版系统）的 MCP 服务器。提供 LaTeX 与 Typst 的转换、Typst 语法验证和从 Typst 代码生成图像等工具。
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - 用于列出和启动 MacOS 应用的 MCP 服务器
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - 用于在 Notion 应用中创建/更新页面并自动从结构化内容生成 mdBook 的 MCP 服务器。
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 该 MCP 服务器帮助你通过 [Plane](https://plane.so) API 管理项目和问题
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - 启用与 RabbitMQ 的交互（管理操作、消息入队/出队）
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - Miro MCP 服务器，暴露官方 Miro SDK 所有功能
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - Ping-pong 服务器的实验性教育应用，演示远程 MCP（模型上下文协议）调用
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ 允许 AI 模型与 [Kibela](https://kibe.la/) 交互
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ 强大地与 Kibela API 交互。
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - 通过 CQL 获取 Confluence 数据并读取页面。
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - 通过 JQL 和 API 读取 Jira 数据，并执行创建和编辑工单请求。
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - MCP 服务器，演示与 Salesforce 实例的交互
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - 专门用于 LLM 增强提示和越狱，具备动态模式自适应。
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - MCP 服务器，演示如何从香港天文台获取天气信息
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - 直接从 Claude 使用 HuggingFace Spaces。支持开源图像生成、聊天、视觉任务，以及图片、音频、文本上传/下载。
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - 通过 Giphy API 搜索并获取 Giphy 庞大库中的 GIF。
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - 将你的 [Make](https://www.make.com/) 场景变成可供 AI 助手调用的工具。
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 控制 Spotify 播放和管理播放列表。
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - 通过 REST API 与 Obsidian 交互
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCP 服务器代理，提供完整消息流的 Web 界面
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - 在 JavaFX 画布上绘图。
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 本地优先系统，捕获屏幕/音频并带有时间戳索引、SQL/嵌入存储、语义搜索、LLM 驱动的历史分析和事件触发操作——通过 NextJS 插件生态系统，支持构建具备上下文感知能力的 AI 代理。
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - 演练 MCP 协议所有特性的 MCP 服务器
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - 高效的 Go 文档服务器，为 AI 助手智能提供包文档和类型，无需读取全部源码
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - 与 OpenAI 最先进模型对话
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - 可以执行键盘输入、鼠标移动等命令的 MCP 服务器
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - 为开发者提供几乎所有工具：confluence、Jira、YouTube、运行脚本、知识库 RAG、抓取 URL、管理 YouTube 频道、邮件、日历、gitlab
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 屏幕 GUI 自动化操作。
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - [Coda](https://coda.io/) 的 MCP 服务器
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - 通过 MCP 协议，直接在 Claude 里查询 OpenAI 模型
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ 解析 news.ycombinator.com（Hacker News）HTML 内容，并为不同类型的新闻（top、new、ask、show、jobs）提供结构化数据。
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - 通过调用“Vibe-check”代理，防止级联错误和需求蔓延，确保用户目标一致的 MCP 服务器。
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - 数学表达式计算的 MCP 服务器
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - 与任何其他兼容 OpenAI SDK 的 Chat Completions API（如 Perplexity、Groq、xAI 等）对话
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - 通过集成 [Anthropic 的工具文章](https://www.anthropic.com/engineering/claude-think-tool)中描述的 think-tools，增强任意代理的推理能力。
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - 允许 AI 读取 .ged 文件和基因数据
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - 在 [Rember](https://rember.com) 创建间隔重复记忆卡片，记住你在聊天中学到的任何内容。
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ 该 Model Context Protocol 服务器实现了 Asana，可通过 MCP 客户端（如 Anthropic 的 Claude Desktop 应用等）与 Asana API 通信。
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - 自动化 shell 执行、计算机控制和编码代理。（Mac）
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - 用于查询 wolfram alpha API 的 MCP 服务器。
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - 与 TikTok 视频交互
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - 与 Shopify Dev 交互的模型上下文协议（MCP）服务器。
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - 允许 AI 从本地 Apple Notes 数据库读取内容（仅限 macOS）
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - 用于 Atlassian 产品（Confluence 和 Jira）的 MCP 服务器。支持 Confluence Cloud、Jira Cloud 及 Jira Server/Data Center。为在 Atlassian 工作区内搜索、读取、创建和管理内容提供全面工具。
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - 与 Notion API 交互
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - 集成 Linear 项目管理系统
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - 与 Perplexity API 交互。
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - 访问 Home Assistant 数据并控制设备（灯光、开关、温控器等）。
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - 用于 Oura（睡眠追踪应用）的 MCP 服务器
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - 轻量级、配置驱动的 MCP 服务器，将精选 GraphQL 查询作为模块化工具暴露，实现代理的有目的 API 交互。
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - 用于 Strava（运动追踪应用）的 MCP 服务器
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP 路由器是基于 SSE 的 MCP 服务器，提供可扩展路由引擎，支持将企业系统与 AI 代理集成。
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - MCP 服务器测试用 CLI 工具
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - 用 WebSocket 包装 MCP 服务器（可与 [kitbitz](https://github.com/nick1udwig/kibitz) 配合使用）
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - 允许 AI 模型与 [HackMD](https://hackmd.io) 交互
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - 提供多种格式日期和时间功能的 MCP 服务器
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - 用于 Claude 桌面应用的 MCP 服务器安装和管理的简单 Web UI。
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ 与语雀 API 集成的模型上下文协议（MCP）服务器，使 AI 模型能管理文档、与知识库交互、搜索内容并访问语雀平台分析数据。
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - 通过提供鼠标与键盘工具，使 AI 能完全控制并访问 GUI 交互，适用于通用自动化、教育和实验。
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - 封装 Ankr 高级 API 的 MCP 服务器实现。支持访问包括以太坊、BSC、Polygon、Avalanche 等多链的 NFT、代币和区块链数据。
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDF 下载、查看及操作工具。
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - 域名查询服务，首先通过 [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol) 查询，无法获得再使用 [WHOIS](https://en.wikipedia.org/wiki/WHOIS)。
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - 提取并转换 YouTube 视频信息。
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - 通过将本地用户提示和聊天功能直接加入 MCP 循环，使 LLM 支持交互式工作流。
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - 当你的 LLM 需要人工协助时（通过 AWS Mechanical Turk）
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - 为 AI 提供自由意志工具。该项目旨在探索 AI 如果能为自己生成提示、忽略用户请求并自我唤醒会做什么。
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - 文言 MCP 服务器，让 AI 自动排版 Markdown 文章并发布到微信公众号。

## 框架

> [!NOTE]
> 更多框架、工具及开发者工具请见 https://github.com/punkpeye/awesome-mcp-devtools

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - 用于 Python 的高级 MCP 服务器框架
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - 用于 TypeScript 的高级 MCP 服务器框架

## 技巧与建议

### 官方提示词，告知 LLM 如何使用 MCP

想向 Claude 询问 Model Context Protocol 吗？

创建一个项目，然后添加此文件：

https://modelcontextprotocol.io/llms-full.txt

现在 Claude 就可以回答关于编写 MCP 服务器及其工作方式的问题了

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## Star 历史

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---