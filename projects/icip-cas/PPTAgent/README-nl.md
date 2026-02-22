
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">Engels</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">Japans</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">Koreaans</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">Thais</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">Frans</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">Duits</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">Spaans</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">Italiaans</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">Russisch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">Portugees</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">Pools</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">Turks</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">Vietnamees</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">Indonesisch</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/pptagent-logo.png" width="240px">
</div>

https://github.com/user-attachments/assets/938889e8-d7d8-4f4f-b2a1-07ee3ef3991a

## 📫 Contact
> De belangrijkste bijdrager van deze repository is een masterstudent die afstudeert in 2026. Neem gerust contact op voor samenwerking of mogelijkheden.
>
> De belangrijkste bijdrager aan deze repository is een masterstudent die in 2026 afstudeert. Neem gerust contact op voor samenwerking of uitwisseling van ideeën.

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/wechat.jpg" width="140px">
</div>

## 📅 Nieuws
- [2026/01]: We ondersteunen nu vrije vorm en sjabloongeneratie, inclusief PPTX-export en offline modus! Contextbeheer toegevoegd om context-overloop te voorkomen.
- [2025/12]: 🔥 V2 uitgebracht met grote verbeteringen - Diepe Onderzoeksintegratie, Vrije Vorm Visueel Ontwerp, Autonome Asset Creatie, Tekst-naar-beeld Generatie en Agent-omgeving met sandbox & meer dan 20 tools.
- [2025/09]: 🛠️ MCP-serverondersteuning toegevoegd - zie [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-) voor configuratiedetails
- [2025/09]: 🚀 V2 uitgebracht met grote verbeteringen - zie [releasenotes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.2.0) voor details
- [2025/08]: 🎉 Paper geaccepteerd bij **EMNLP 2025**!
- [2025/05]: ✨ V1 uitgebracht met kernfunctionaliteit en 🌟 doorbraak: 1.000 sterren op GitHub bereikt! - zie [releasenotes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.1.0) voor details
- [2025/01]: 🔓 Codebase open source gemaakt, met experimentele code gearchiveerd bij [experiment release](https://github.com/icip-cas/PPTAgent/releases/tag/experiment)

## 📖 Gebruik

> [!BELANGRIJK]
> 1. Al deze API-sleutels, configuraties en diensten zijn **vereist**.
> 2. Aanbevolen Agent-backbone: Gebruik Claude voor de Research Agent en Gemini voor de Design Agent. GLM-4.7 is ook een goede keuze bij open-sourcemodellen.
> 3. Offline modus wordt ondersteund met beperkte functionaliteit (zie Offline Setup hieronder).


### 1. Omgevingsconfiguratie

- **Maak configuratiebestanden aan** (vanaf de hoofdmap van het project):

  ```bash
  cp deeppresenter/deeppresenter/config.yaml.example deeppresenter/deeppresenter/config.yaml
  cp deeppresenter/deeppresenter/mcp.json.example deeppresenter/deeppresenter/mcp.json
  ```

- **Online setup**:
  - **MinerU**: Vraag een API-sleutel aan via [mineru.net](https://mineru.net/apiManage/docs). Let op: elke sleutel is 14 dagen geldig.
  - **Tavily**: Vraag een API-sleutel aan via [tavily.com](https://www.tavily.com/).
  - **LLM**: Stel je model-endpoint, API-sleutels en gerelateerde parameters in via `config.yaml`.

- **Offline setup**:
  - **MinerU**: Implementeer de MinerU-server volgens de instructies op [MinerU docker gids](https://opendatalab.github.io/MinerU/quick_start/docker_deployment/#start-services-directly-with-docker-compose)
  - **Config-switch**: Stel `offline_mode: true` in [`config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/config.yaml) in om te voorkomen dat netwerkafhankelijke tools (zoals `fetch`, `search`) worden geladen.
  - **MinerU endpoint**: Stel `MINERU_API_URL` in [`mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/mcp.json) in op de URL van je lokale MinerU-service

### 2. Service-opstart

Bouw docker-images: `docker compose build`

- **Via Docker Compose**:

  ```bash
  docker compose up -d
  ```

- **Lokaal uitvoeren**:

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