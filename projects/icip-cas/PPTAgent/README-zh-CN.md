
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
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/pptagent-logo.png" width="240px">
</div>

https://github.com/user-attachments/assets/938889e8-d7d8-4f4f-b2a1-07ee3ef3991a

## 📫 联系方式
> 本仓库的主要贡献者为一名预计2026年毕业的硕士研究生，欢迎联系合作或交流机会。
>
> 本仓库的主要贡献者是一名 2026 届硕士毕业生，欢迎联系合作或交流机会。

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/wechat.jpg" width="140px">
</div>

## 📅 新闻动态
- [2026/01]: 我们支持自由格式和模板生成的 PPTX 导出、离线模式现已上线！新增上下文管理以避免上下文溢出。
- [2025/12]: 🔥 发布 V2 重大升级——深度科研集成、自由视觉设计、自主素材生成、文本转图片、支持沙盒和 20+ 工具的 Agent 环境。
- [2025/09]: 🛠️ 新增 MCP 服务器支持——配置详见 [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-)
- [2025/09]: 🚀 发布 v2 重大升级——详情参见 [发布说明](https://github.com/icip-cas/PPTAgent/releases/tag/v0.2.0)
- [2025/08]: 🎉 论文被 **EMNLP 2025** 录用！
- [2025/05]: ✨ 发布 v1，具备核心功能，并🌟突破：GitHub 达到 1,000 星！详见 [发布说明](https://github.com/icip-cas/PPTAgent/releases/tag/v0.1.0)
- [2025/01]: 🔓 代码开源，实验代码已归档于 [experiment release](https://github.com/icip-cas/PPTAgent/releases/tag/experiment)

## 📖 用法

> [!重要]
> 1. 所有这些 API 密钥、配置和服务都是**必需**的。
> 2. Agent 主体建议：科研 Agent 使用 Claude，设计 Agent 使用 Gemini。GLM-4.7 也是开源模型中的不错选择。
> 3. 支持离线模式，功能有限（详见下文离线配置）。


### 1. 环境配置

- **创建配置文件**（在项目根目录下）：

  ```bash
  cp deeppresenter/deeppresenter/config.yaml.example deeppresenter/deeppresenter/config.yaml
  cp deeppresenter/deeppresenter/mcp.json.example deeppresenter/deeppresenter/mcp.json
  ```

- **在线设置**：
  - **MinerU**：在 [mineru.net](https://mineru.net/apiManage/docs) 申请 API 密钥。请注意每个密钥有效期为 14 天。
  - **Tavily**：在 [tavily.com](https://www.tavily.com/) 申请 API 密钥。
  - **LLM**：在 `config.yaml` 中设置您的模型端点、API 密钥以及相关参数。

- **离线设置**：
  - **MinerU**：按照 [MinerU docker 指南](https://opendatalab.github.io/MinerU/quick_start/docker_deployment/#start-services-directly-with-docker-compose) 的说明部署 MinerU 服务器。
  - **配置开关**：在 [`config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/config.yaml) 中设置 `offline_mode: true`，以避免加载依赖网络的工具（例如 `fetch`、`search`）。
  - **MinerU 端点**：在 [`mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/mcp.json) 中将 `MINERU_API_URL` 设置为您的本地 MinerU 服务 URL。

### 2. 服务启动

构建 docker 镜像：`docker compose build`

- **通过 Docker Compose**：

  ```bash
  docker compose up -d
  ```

- **本地运行**：

  ```bash
  cd deeppresenter
  pip install -e .
  playwright install-deps
  playwright install chromium
  npm install
  npx playwright install chromium
  python webui.py
  ```

> [!TIP]
> 🚀 All configurable variables can be found in [constants.py](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/utils/constants.py).

## 💡 Case Study

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


[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)

## Citation 🙏

If you find this project helpful, please use the following to cite it:
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
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---