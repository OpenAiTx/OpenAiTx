
<div align="right">
  <details>
    <summary >🌐 语言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/pptagent-logo.jpg" width="240px" alt="https://github.com/icip-cas/PPTAgent">
</div>

<table>
  <tr>
    <td width="50%">
      <video controls width="100%" src="https://github.com/user-attachments/assets/314bed6a-185e-4c81-9de5-35728e83e22a">
      </video>
    </td>
    <td width="50%">
      <video controls width="100%" src="https://github.com/user-attachments/assets/96eee616-5f79-4ea1-bd7f-bcaa466eda9e">
      </video>
    </td>
  </tr>
</table>

我们**强烈推荐**部署我们微调过的模型，以获得最佳的代理项目体验。根据我们的实验，微调模型**显著优于现有开源模型**。

| 格式 | HuggingFace | ModelScope |
|--------|-------------|------------|
| GGUF（量化） | [Forceless/DeepPresenter-9B-GGUF](https://huggingface.co/Forceless/DeepPresenter-9B-GGUF) | [forceless/DeepPresenter-9B-GGUF](https://modelscope.cn/models/forceless/DeepPresenter-9B-GGUF) |
| 全权重 | [Forceless/DeepPresenter-9B](https://huggingface.co/Forceless/DeepPresenter-9B) | [forceless/DeepPresenter-9B](https://modelscope.cn/models/forceless/DeepPresenter-9B) |

## 📅 新闻

- **[2026/04]** 🎉 [DeepPresenter](https://arxiv.org/abs/2602.22839) 被 **ACL 2026** 接收！
- **[2026/03]** 🤗 我们在 [Hugging Face](https://huggingface.co/collections/ICIP/deeppresenter) 发布了微调模型和任务集。
- **[2026/01]** 🆕 自由格式与模板生成现已支持 PPTX 导出及离线模式。新增上下文管理以防止上下文溢出。
- **[2025/12]** 🔥 发布了 **DeepPresenter** 代码库，重大升级 —— 深度研究集成、自由视觉设计、自主资产生成、文本到图像生成，以及带有沙盒和 20+ 工具的代理环境。
- **[2025/09]** 🛠️ 增加 MCP 服务器支持——配置详情见 [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-)。
- **[2025/08]** 🎉 [PPTAgent](https://arxiv.org/abs/2501.03936) 被 **EMNLP 2025** 接收！
- **[2025/05]** ⭐ GitHub 上达到了 **1,000 颗星**！
- **[2025/01]** 🔓 PPTAgent 代码库开源。

## 使用方法 📖

> [!重要]
> 不支持 Windows。如果您使用 Windows，请使用 WSL。
>
> 我们强烈建议从 CLI 和最小任务开始，以确认依赖项和环境已正确配置。

### 配置

如果您使用 CLI，`pptagent onboard` 可以帮助您交互式创建和更新这些配置。如果您使用 Docker Compose 或源码构建，则需要手动准备：

```bash
cp deeppresenter/config.yaml.example deeppresenter/config.yaml
cp deeppresenter/mcp.json.example deeppresenter/mcp.json
```

#### 提升质量的可选服务

以下服务可以显著提升生成质量，特别是在研究深度、PDF解析和视觉资产创建方面：

- **Tavily**：提升网页搜索质量。在 [tavily.com](https://www.tavily.com/) 申请 API 密钥，然后在 [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json) 中设置 `TAVILY_API_KEY`。
- **MinerU**：提升 PDF 解析质量。你可以在 [mineru.net](https://mineru.net/apiManage/docs) 申请 API 密钥，并在 [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json) 中设置 `MINERU_API_KEY`，或者本地部署 MinerU 并设置 `MINERU_API_URL`。
- **文本转图像模型**：提升图片生成质量。在 [`deeppresenter/config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/config.yaml) 中配置 `t2i_model`。


如果你想要完全离线的环境，可以本地部署 MinerU，并在 `deeppresenter/config.yaml` 中设置 `offline_mode: true`，以避免加载如网页搜索等依赖网络的工具。

更多可配置变量可在 [constants.py](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/utils/constants.py) 中找到。

### 1. 个人使用 / OpenClaw 集成：命令行界面（CLI）

> [!NOTE]
> 在 macOS 上，命令行界面可能会自动安装多个本地依赖，包括 Homebrew、Node.js、Docker、poppler、Playwright 和 llama.cpp。
>
> 在 Linux 上，你需要自行准备运行环境。

如果你想要最快的本地部署，或希望通过命令行将 DeepPresenter 插件集成到 OpenClaw，请使用此模式。

```bash
# Install uv
curl -LsSf https://astral.sh/uv/install.sh | sh

# First-time interactive setup
uvx pptagent onboard

# Generate a presentation
uvx pptagent generate "Single Page with Title: Hello World" -o hello.pptx

# Generate with attachments
uvx pptagent generate "Q4 Report" \
  -f data.xlsx \
  -f charts.pdf \
  -p "10-12" \
  -o report.pptx
```

| 命令                  | 描述                                               |
| ------------------- | ------------------------------------------------- |
| `pptagent onboard`  | 交互式配置向导                                      |
| `pptagent generate` | 生成演示文稿                                        |
| `pptagent config`   | 查看当前配置                                        |
| `pptagent reset`    | 重置配置                                            |
| `pptagent serve`    | 启动 CLI 使用的本地推理服务                         |

### Docker 镜像

DeepPresenter 发布了两个运行时镜像：

| 本地镜像名称           | 用途                                 | Docker Hub | 1ms.run 镜像 |
| ---                  | ---                                  | --- | --- |
| `deeppresenter-host` | 用于 Web UI 和编排运行时的主机服务      | [`forceless/deeppresenter-host`](https://hub.docker.com/r/forceless/deeppresenter-host) | [`docker.1ms.run/forceless/deeppresenter-host`](https://1ms.run/r/forceless/deeppresenter-host) |
| `deeppresenter-sandbox` | 运行时用于隔离工具执行的沙箱镜像         | [`forceless/deeppresenter-sandbox`](https://hub.docker.com/r/forceless/deeppresenter-sandbox) | [`docker.1ms.run/forceless/deeppresenter-sandbox`](https://1ms.run/r/forceless/deeppresenter-sandbox) |

### 2. 最小化设置 / 开发：从源代码构建

如需在开发过程中拥有最小抽象层和对依赖项的完全控制，请使用此模式。

```bash
uv pip install -e .
playwright install-deps
playwright install chromium
npm install --prefix deeppresenter/html2pptx
modelscope download forceless/fasttext-language-id

docker pull forceless/deeppresenter-sandbox
docker pull forceless/deeppresenter-host
docker tag forceless/deeppresenter-sandbox deeppresenter-sandbox
docker tag forceless/deeppresenter-host deeppresenter-host

# or pull through the 1ms.run mirror
docker pull docker.1ms.run/forceless/deeppresenter-sandbox
docker pull docker.1ms.run/forceless/deeppresenter-host
docker tag docker.1ms.run/forceless/deeppresenter-sandbox deeppresenter-sandbox
docker tag docker.1ms.run/forceless/deeppresenter-host deeppresenter-host

# or build from dockerfile
docker build -t deeppresenter-sandbox -f deeppresenter/docker/SandBox.Dockerfile .
docker build -t deeppresenter-host -f deeppresenter/docker/Host.Dockerfile .
```
启动应用程序：


```bash
python webui.py
```

### 3. 服务器部署：Docker Compose

使用此模式可获得具有明确依赖关系的稳定服务器环境。

```bash
# Pull the public images to avoid build from source
docker pull forceless/deeppresenter-sandbox
docker pull forceless/deeppresenter-host
docker tag forceless/deeppresenter-sandbox deeppresenter-sandbox
docker tag forceless/deeppresenter-host deeppresenter-host

# Or pull through the 1ms.run mirror
docker pull docker.1ms.run/forceless/deeppresenter-sandbox
docker pull docker.1ms.run/forceless/deeppresenter-host
docker tag docker.1ms.run/forceless/deeppresenter-sandbox deeppresenter-sandbox
docker tag docker.1ms.run/forceless/deeppresenter-host deeppresenter-host

# Or build from source
docker build -t deeppresenter-sandbox -f deeppresenter/docker/SandBox.Dockerfile .
docker build -t deeppresenter-host -f deeppresenter/docker/Host.Dockerfile .

# Start the host service
docker compose up -d
```

The service exposes the web UI on `http://localhost:7861`.

## Case Study 💡

- #### Prompt: Please present the given document to me.

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0008.jpg" alt="图片8" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0009.jpg" alt="图片9" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/manuscript/0010.jpg" alt="图片10" width="200"/>

</div>

- #### Prompt: 请介绍小米 SU7 的外观和价格

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation1/0006.jpg" alt="图片6" width="200"/>

</div>

- #### Prompt: 请制作一份高中课堂展示课件，主题为“解码立法过程：理解其对国际关系的影响”

<div style="display: flex; flex-wrap: wrap; gap: 10px;">

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0001.jpg" alt="图片1" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0002.jpg" alt="图片2" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0003.jpg" alt="图片3" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0004.jpg" alt="图片4" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0005.jpg" alt="图片5" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0006.jpg" alt="图片6" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0007.jpg" alt="图片7" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0008.jpg" alt="图片8" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0009.jpg" alt="图片9" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0010.jpg" alt="图片10" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0011.jpg" alt="图片11" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0012.jpg" alt="图片12" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0013.jpg" alt="图片13" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0014.jpg" alt="图片14" width="200"/>

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0015.jpg" alt="图片15" width="200"/>

</div>

---

## 贡献者 🌟

<table>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Force1ess>
            <img src=https://avatars.githubusercontent.com/u/72636351?v=4 width="80;"  alt=Force1ess/>
            <br />
            <sub style="font-size:14px"><b>Force1ess</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Puellaquae>
            <img src=https://avatars.githubusercontent.com/u/22560343?v=4 width="80;"  alt=Puelloc/>
            <br />
            <sub style="font-size:14px"><b>Puelloc</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/hysyyds>
            <img src=https://avatars.githubusercontent.com/u/80150669?v=4 width="80;"  alt=hongyan/>
            <br />
            <sub style="font-size:14px"><b>hongyan</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/imHuZijian>
            <img src=https://avatars.githubusercontent.com/u/97173940?v=4 width="80;"  alt=BrandonHu/>
            <br />
            <sub style="font-size:14px"><b>BrandonHu</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Dnoob>
            <img src=https://avatars.githubusercontent.com/u/92987618?v=4 width="80;"  alt=Dnoob/>
            <br />
            <sub style="font-size:14px"><b>Dnoob</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Sadahlu>
            <img src=https://avatars.githubusercontent.com/u/126563707?v=4 width="80;"  alt=Sadahlu/>
            <br />
            <sub style="font-size:14px"><b>Sadahlu</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/lnennnn>
            <img src=https://avatars.githubusercontent.com/u/124434018?v=4 width="80;"  alt=lnennnn/>
            <br />
            <sub style="font-size:14px"><b>lnennnn</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/KurisuMakiseSame>
            <img src=https://avatars.githubusercontent.com/u/168447425?v=4 width="80;"  alt=KurisuMakiseSame/>
            <br />
            <sub style="font-size:14px"><b>KurisuMakiseSame</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/RheagalFire>
            <img src=https://avatars.githubusercontent.com/u/60213893?v=4 width="80;"  alt=Aarish Alam/>
            <br />
            <sub style="font-size:14px"><b>Aarish Alam</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Angelenx>
            <img src=https://avatars.githubusercontent.com/u/39873863?v=4 width="80;"  alt=Angelen/>
            <br />
            <sub style="font-size:14px"><b>Angelen</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/kylooh>
            <img src=https://avatars.githubusercontent.com/u/26456650?v=4 width="80;"  alt=Eliot White/>
            <br />
            <sub style="font-size:14px"><b>Eliot White</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/EvolvedGhost>
            <img src=https://avatars.githubusercontent.com/u/92856393?v=4 width="80;"  alt=EvolvedGhost/>
            <br />
            <sub style="font-size:14px"><b>EvolvedGhost</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/ISCAS-zwl>
            <img src=https://avatars.githubusercontent.com/u/179820048?v=4 width="80;"  alt=ISCAS-zwl/>
            <br />
            <sub style="font-size:14px"><b>ISCAS-zwl</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/James4Ever0>
            <img src=https://avatars.githubusercontent.com/u/103997068?v=4 width="80;"  alt=白雨 | James Brown/>
            <br />
            <sub style="font-size:14px"><b>白雨 | James Brown</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/LasRuinasCirculares>
            <img src=https://avatars.githubusercontent.com/u/119716645?v=4 width="80;"  alt=JunZhang/>
            <br />
            <sub style="font-size:14px"><b>JunZhang</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/openaitx-system>
            <img src=https://avatars.githubusercontent.com/u/215529505?v=4 width="80;"  alt=Open AI Tx/>
            <br />
            <sub style="font-size:14px"><b>Open AI Tx</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/haosenwang1018>
            <img src=https://avatars.githubusercontent.com/u/167664334?v=4 width="80;"  alt=Sense_wang/>
            <br />
            <sub style="font-size:14px"><b>Sense_wang</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/DeJeune>
            <img src=https://avatars.githubusercontent.com/u/67425183?v=4 width="80;"  alt=SuYao/>
            <br />
            <sub style="font-size:14px"><b>苏遥</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/JiwaniZakir>
            <img src=https://avatars.githubusercontent.com/u/108548454?v=4 width="80;"  alt=Zakir Jiwani/>
            <br />
            <sub style="font-size:14px"><b>Zakir Jiwani</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Dormiveglia-elf>
            <img src=https://avatars.githubusercontent.com/u/81767213?v=4 width="80;"  alt=Zhenyu/>
            <br />
            <sub style="font-size:14px"><b>振宇</b></sub>
        </a>
    </td>
</tr>
</table>

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)

## 引用 🙏

如果您觉得此项目有帮助，请使用以下方式引用：
```bibtex
@inproceedings{zheng-etal-2025-pptagent,
    title = "{PPTA}gent: Generating and Evaluating Presentations Beyond Text-to-Slides",
    author = "Zheng, Hao  and
      Guan, Xinyan  and
      Kong, Hao  and
      Zhang, Wenkai  and
      Zheng, Jia  and
      Zhou, Weixiang  and
      Lin, Hongyu  and
      Lu, Yaojie  and
      Han, Xianpei  and
      Sun, Le",
    editor = "Christodoulopoulos, Christos  and
      Chakraborty, Tanmoy  and
      Rose, Carolyn  and
      Peng, Violet",
    booktitle = "Proceedings of the 2025 Conference on Empirical Methods in Natural Language Processing",
    month = nov,
    year = "2025",
    address = "Suzhou, China",
    publisher = "Association for Computational Linguistics",
    url = "https://aclanthology.org/2025.emnlp-main.728/",
    doi = "10.18653/v1/2025.emnlp-main.728",
    pages = "14413--14429",
    ISBN = "979-8-89176-332-6",
    abstract = "Automatically generating presentations from documents is a challenging task that requires accommodating content quality, visual appeal, and structural coherence. Existing methods primarily focus on improving and evaluating the content quality in isolation, overlooking visual appeal and structural coherence, which limits their practical applicability. To address these limitations, we propose PPTAgent, which comprehensively improves presentation generation through a two-stage, edit-based approach inspired by human workflows. PPTAgent first analyzes reference presentations to extract slide-level functional types and content schemas, then drafts an outline and iteratively generates editing actions based on selected reference slides to create new slides. To comprehensively evaluate the quality of generated presentations, we further introduce PPTEval, an evaluation framework that assesses presentations across three dimensions: Content, Design, and Coherence. Results demonstrate that PPTAgent significantly outperforms existing automatic presentation generation methods across all three dimensions."
}

@misc{zheng2026deeppresenterenvironmentgroundedreflectionagentic,
      title={DeepPresenter: Environment-Grounded Reflection for Agentic Presentation Generation},
      author={Hao Zheng and Guozhao Mo and Xinru Yan and Qianhao Yuan and Wenkai Zhang and Xuanang Chen and Yaojie Lu and Hongyu Lin and Xianpei Han and Le Sun},
      year={2026},
      eprint={2602.22839},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2602.22839},
}
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-24

---