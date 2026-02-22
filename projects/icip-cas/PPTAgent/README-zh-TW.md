
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-CN">簡體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ko">韓國語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">印地語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=th">泰語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fr">法語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=de">德語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=es">西班牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=it">義大利語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ru">俄語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pt">葡萄牙語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=nl">荷蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=pl">波蘭語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=ar">阿拉伯語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=fa">波斯語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=tr">土耳其語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=vi">越南語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=id">印尼語</a>
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=as">阿薩姆語</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/pptagent-logo.png" width="240px">
</div>

https://github.com/user-attachments/assets/938889e8-d7d8-4f4f-b2a1-07ee3ef3991a

## 📫 聯絡方式
> 此倉庫的主要貢獻者為2026年畢業的碩士研究生，歡迎聯繫合作或尋求機會。
>
> 本倉庫的主要貢獻者是一名 2026 屆碩士畢業生，歡迎聯繫合作或交流機會。

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/wechat.jpg" width="140px">
</div>

## 📅 最新消息
- [2026/01]: 現已支援自由格式和範本產生，支援 PPTX 匯出及離線模式！新增上下文管理以避免上下文溢出。
- [2025/12]: 🔥 發布 V2，帶來重大改進——深度研究整合、自由格式視覺設計、自主資產創建、文本轉圖像生成，以及具備沙盒和 20+ 工具的代理環境。
- [2025/09]: 🛠️ 新增 MCP 伺服器支援——請參閱 [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-) 了解配置細節
- [2025/09]: 🚀 發布 v2，帶來重大改進——詳情請參閱 [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.2.0)
- [2025/08]: 🎉 論文被 **EMNLP 2025** 錄用！
- [2025/05]: ✨ 發布 v1，具備核心功能及 🌟 突破：GitHub 星標突破 1,000！詳情請參閱 [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.1.0)
- [2025/01]: 🔓 開源代碼庫，實驗性代碼已存檔於 [experiment release](https://github.com/icip-cas/PPTAgent/releases/tag/experiment)

## 📖 使用說明

> [!IMPORTANT]
> 1. 所有這些 API 金鑰、配置和服務均為**必需**。
> 2. 代理主幹推薦：研究代理建議使用 Claude，設計代理建議使用 Gemini。開源模型中，GLM-4.7 也是不錯的選擇。
> 3. 支援離線模式，功能有限（詳見下方離線配置）。


### 1. 環境配置

- **建立配置檔案**（於專案根目錄）：

  ```bash
  cp deeppresenter/deeppresenter/config.yaml.example deeppresenter/deeppresenter/config.yaml
  cp deeppresenter/deeppresenter/mcp.json.example deeppresenter/deeppresenter/mcp.json
  ```

- **線上設置**：
  - **MinerU**：在 [mineru.net](https://mineru.net/apiManage/docs) 申請 API 金鑰。請注意，每個金鑰有效期為 14 天。
  - **Tavily**：在 [tavily.com](https://www.tavily.com/) 申請 API 金鑰。
  - **LLM**：在 `config.yaml` 中設置您的模型端點、API 金鑰與相關參數。

- **離線設置**：
  - **MinerU**：請依照 [MinerU docker 指南](https://opendatalab.github.io/MinerU/quick_start/docker_deployment/#start-services-directly-with-docker-compose) 部署 MinerU 伺服器。
  - **設定切換**：在 [`config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/config.yaml) 中設置 `offline_mode: true`，以避免加載需網路的工具（如 `fetch`、`search`）。
  - **MinerU 端點**：在 [`mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/deeppresenter/mcp.json) 中將 `MINERU_API_URL` 設為您本地的 MinerU 服務網址。

### 2. 服務啟動

建置 docker 映像檔：`docker compose build`

- **使用 Docker Compose 啟動**：

  ```bash
  docker compose up -d
  ```

- **在本地運行**：

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