
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
        | <a href="https://openaitx.github.io/view.html?user=icip-cas&project=PPTAgent&lang=hi">印度語</a>
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

## 聯絡方式 📫
> 本倉庫的主要貢獻者是一位將於 2026 年畢業的碩士生，歡迎聯絡合作或交流機會。
>
> 本倉庫的主要貢獻者是一名 2026 屆碩士畢業生，歡迎聯絡合作或交流機會。

<div align="center">
  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/wechat.jpg" width="140px">
</div>

## 最新消息 📅
- [2026/03]：我們現已支持 CLI，並已在 [Hugging Face 🤗](https://huggingface.co/collections/ICIP/deeppresenter) 發佈我們的微調模型！
- [2026/01]：我們支持自由格式與模板生成，並支援 PPTX 匯出與離線模式！新增上下文管理功能以避免上下文溢出。
- [2025/12]：🔥 發佈 V2，重大改進 - 深度研究整合、自由形式視覺設計、自主資產創建、文字轉圖片生成，並有沙盒環境及 20+ 工具。
- [2025/09]：🛠️ 增加 MCP 伺服器支援 - 設定詳情請參見 [MCP Server](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/PPTAgent/DOC.md#mcp-server-) 
- [2025/09]：🚀 發佈 v2，重大改進 - 詳情請參見 [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.2.0)
- [2025/08]：🎉 論文已被 **EMNLP 2025** 接收！
- [2025/05]：✨ 發佈 v1，核心功能與 🌟 突破：GitHub 點贊數達 1,000！詳情請參見 [release notes](https://github.com/icip-cas/PPTAgent/releases/tag/v0.1.0)
- [2025/01]：🔓 原始碼開源，實驗性代碼已存檔於 [experiment release](https://github.com/icip-cas/PPTAgent/releases/tag/experiment)

## 使用方法 📖

> [!重要]
> 不支援 Windows。如在 Windows 上，請使用 WSL。
>
> 強烈建議先從 CLI 與最小任務開始，以確認依賴項與環境配置正確。

### 設定

若使用 CLI，`pptagent onboard` 可協助互動式創建與更新這些設定。若使用 Docker Compose 或源碼建構，則需手動準備：

```bash
cp deeppresenter/config.yaml.example deeppresenter/config.yaml
cp deeppresenter/mcp.json.example deeppresenter/mcp.json
```

#### 提升品質的可選服務

以下服務可以顯著提升生成品質，尤其是在研究深度、PDF解析及視覺素材創建方面：

- **Tavily**：提升網頁搜尋品質。請至 [tavily.com](https://www.tavily.com/) 申請 API 金鑰，然後於 [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json) 設定 `TAVILY_API_KEY`。
- **MinerU**：提升 PDF 解析品質。你可以至 [mineru.net](https://mineru.net/apiManage/docs) 申請 API 金鑰並於 [`deeppresenter/mcp.json`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/mcp.json) 設定 `MINERU_API_KEY`，或是在本地部署 MinerU 並改設 `MINERU_API_URL`。
- **文字轉圖像模型**：提升圖像生成品質。在 [`deeppresenter/config.yaml`](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/config.yaml) 設定 `t2i_model`。


若你希望完全離線運作，請在本地部署 MinerU 並於 `deeppresenter/config.yaml` 設定 `offline_mode: true`，以避免載入如網頁搜尋等需網路的工具。

更多可調整的變數可在 [constants.py](https://raw.githubusercontent.com/icip-cas/PPTAgent/main/deeppresenter/utils/constants.py) 找到。

### 1. 個人使用／OpenClaw 整合：CLI

> [!NOTE]
> 在 macOS 上，CLI 可能會自動安裝多項本地依賴，包括 Homebrew、Node.js、Docker、poppler、Playwright 與 llama.cpp。
>
> 在 Linux 上，你需自行準備環境。

若你想要最快速的本地安裝，或希望將 DeepPresenter 透過 CLI 插入 OpenClaw，請使用此模式。

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

| 指令                   | 說明                                               |
| ------------------- | ------------------------------------------------- |
| `pptagent onboard`  | 互動式設定精靈                                      |
| `pptagent generate` | 產生簡報                                            |
| `pptagent config`   | 查看目前設定                                        |
| `pptagent reset`    | 重設設定                                            |
| `pptagent serve`    | 啟動 CLI 使用的本地推論服務                         |

### 2. 最小化設定／開發：從原始碼建置

如果你想在開發過程中擁有最少的抽象層並完全掌控相依性，請使用此模式。

```bash
uv pip install -e .
playwright install-deps
playwright install chromium
npm install --prefix deeppresenter/html2pptx
modelscope download forceless/fasttext-language-id

docker pull forceless/deeppresenter-sandbox
docker pull forceless/deeppresenter-host
docker tag forceless/deeppresenter-sandbox deeppresenter-sandbox

# or build from dockerfile
docker build -t deeppresenter-sandbox -f deeppresenter/docker/SandBox.Dockerfile .
```
啟動應用程式：


```bash
python webui.py
```

### 3. 伺服器部署：Docker Compose

使用此模式可建立具有明確依賴關係的穩定伺服器環境。

```bash
# Pull the public images to avoid build from source
docker pull forceless/deeppresenter-sandbox
docker tag forceless/deeppresenter-sandbox deeppresenter-sandbox

# Or build from source
docker build -t deeppresenter-sandbox -f deeppresenter/docker/SandBox.Dockerfile .

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

  <img src="https://raw.githubusercontent.com/icip-cas/PPTAgent/main/resource/v2/presentation2/0015.jpg" alt="圖片15" width="200"/>

</div>

---

## 貢獻者 🌟

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
        <a href=https://github.com/Dnoob>
            <img src=https://avatars.githubusercontent.com/u/92987618?v=4 width="80;"  alt=Dnoob/>
            <br />
            <sub style="font-size:14px"><b>Dnoob</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Sadahlu>
            <img src=https://avatars.githubusercontent.com/u/126563707?v=4 width="80;"  alt=Sadahlu/>
            <br />
            <sub style="font-size:14px"><b>Sadahlu</b></sub>
        </a>
    </td>
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/KurisuMakiseSame>
            <img src=https://avatars.githubusercontent.com/u/168447425?v=4 width="80;"  alt=KurisuMakiseSame/>
            <br />
            <sub style="font-size:14px"><b>KurisuMakiseSame</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/Angelenx>
            <img src=https://avatars.githubusercontent.com/u/39873863?v=4 width="80;"  alt=Angelen/>
            <br />
            <sub style="font-size:14px"><b>Angelen</b></sub>
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
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/ISCAS-zwl>
            <img src=https://avatars.githubusercontent.com/u/179820048?v=4 width="80;"  alt=ISCAS-zwl/>
            <br />
            <sub style="font-size:14px"><b>ISCAS-zwl</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/James4Ever0>
            <img src=https://avatars.githubusercontent.com/u/103997068?v=4 width="80;"  alt=James Brown/>
            <br />
            <sub style="font-size:14px"><b>James Brown</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/LasRuinasCirculares>
            <img src=https://avatars.githubusercontent.com/u/119716645?v=4 width="80;"  alt=JunZhang/>
            <br />
            <sub style="font-size:14px"><b>JunZhang</b></sub>
        </a>
    </td>
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
</tr>
<tr>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/DeJeune>
            <img src=https://avatars.githubusercontent.com/u/67425183?v=4 width="80;"  alt=SuYao/>
            <br />
            <sub style="font-size:14px"><b>SuYao</b></sub>
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
            <sub style="font-size:14px"><b>Zhenyu</b></sub>
        </a>
    </td>
    <td align="center" style="word-wrap: break-word; width: 120.0; height: 120.0">
        <a href=https://github.com/lnennnn>
            <img src=https://avatars.githubusercontent.com/u/124434018?v=4 width="80;"  alt=lnennnn/>
            <br />
            <sub style="font-size:14px"><b>lnennnn</b></sub>
        </a>
    </td>
</tr>
</table>

[![Star History Chart](https://api.star-history.com/svg?repos=icip-cas/PPTAgent&type=Date)](https://star-history.com/#icip-cas/PPTAgent&Date)

## 引用 🙏

如果您覺得本專案對您有幫助，請使用以下內容進行引用：
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-09

---