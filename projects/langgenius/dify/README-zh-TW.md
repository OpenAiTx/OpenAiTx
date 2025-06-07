![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">介紹 Dify Workflow 檔案上傳：重現 Google NotebookLM Podcast</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify 雲端</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">自行部署</a> ·
  <a href="https://docs.dify.ai">文件說明</a> ·
  <a href="https://dify.ai/pricing">Dify 版本概覽</a>
</p>

<p align="center">
    <a href="https://dify.ai" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/Product-F04438"></a>
    <a href="https://dify.ai/pricing" target="_blank">
        <img alt="Static Badge" src="https://img.shields.io/badge/free-pricing?logo=free&color=%20%23155EEF&label=pricing&labelColor=%20%23528bff"></a>
    <a href="https://discord.gg/FngNHpbcY7" target="_blank">
        <img src="https://img.shields.io/discord/1082486657678311454?logo=discord&labelColor=%20%235462eb&logoColor=%20%23f5f5f5&color=%20%235462eb"
            alt="chat on Discord"></a>
    <a href="https://reddit.com/r/difyai" target="_blank">  
        <img src="https://img.shields.io/reddit/subreddit-subscribers/difyai?style=plastic&logo=reddit&label=r%2Fdifyai&labelColor=white"
            alt="join Reddit"></a>
    <a href="https://twitter.com/intent/follow?screen_name=dify_ai" target="_blank">
        <img src="https://img.shields.io/twitter/follow/dify_ai?logo=X&color=%20%23f5f5f5"
            alt="follow on X(Twitter)"></a>
    <a href="https://www.linkedin.com/company/langgenius/" target="_blank">
        <img src="https://custom-icon-badges.demolab.com/badge/LinkedIn-0A66C2?logo=linkedin-white&logoColor=fff"
            alt="follow on LinkedIn"></a>
    <a href="https://hub.docker.com/u/langgenius" target="_blank">
        <img alt="Docker Pulls" src="https://img.shields.io/docker/pulls/langgenius/dify-web?labelColor=%20%23FDB062&color=%20%23f79009"></a>
    <a href="https://github.com/langgenius/dify/graphs/commit-activity" target="_blank">
        <img alt="Commits last month" src="https://img.shields.io/github/commit-activity/m/langgenius/dify?labelColor=%20%2332b583&color=%20%2312b76a"></a>
    <a href="https://github.com/langgenius/dify/" target="_blank">
        <img alt="Issues closed" src="https://img.shields.io/github/issues-search?query=repo%3Alanggenius%2Fdify%20is%3Aclosed&label=issues%20closed&labelColor=%20%237d89b0&color=%20%235d6b98"></a>
    <a href="https://github.com/langgenius/dify/discussions/" target="_blank">
        <img alt="Discussion posts" src="https://img.shields.io/github/discussions/langgenius/dify?labelColor=%20%239b8afb&color=%20%237a5af8"></a>
</p>

<p align="center">
  <a href="./README.md"><img alt="README in English" src="https://img.shields.io/badge/English-d9d9d9"></a>
  <a href="./README_TW.md"><img alt="繁體中文文件" src="https://img.shields.io/badge/繁體中文-d9d9d9"></a>
  <a href="./README_CN.md"><img alt="简体中文版自述文件" src="https://img.shields.io/badge/简体中文-d9d9d9"></a>
  <a href="./README_JA.md"><img alt="日本語のREADME" src="https://img.shields.io/badge/日本語-d9d9d9"></a>
  <a href="./README_ES.md"><img alt="README en Español" src="https://img.shields.io/badge/Español-d9d9d9"></a>
  <a href="./README_FR.md"><img alt="README en Français" src="https://img.shields.io/badge/Français-d9d9d9"></a>
  <a href="./README_KL.md"><img alt="README tlhIngan Hol" src="https://img.shields.io/badge/Klingon-d9d9d9"></a>
  <a href="./README_KR.md"><img alt="README in Korean" src="https://img.shields.io/badge/한국어-d9d9d9"></a>
  <a href="./README_AR.md"><img alt="README بالعربية" src="https://img.shields.io/badge/العربية-d9d9d9"></a>
  <a href="./README_TR.md"><img alt="Türkçe README" src="https://img.shields.io/badge/Türkçe-d9d9d9"></a>
  <a href="./README_VI.md"><img alt="README Tiếng Việt" src="https://img.shields.io/badge/Ti%E1%BA%BFng%20Vi%E1%BB%87t-d9d9d9"></a>
  <a href="./README_DE.md"><img alt="README in Deutsch" src="https://img.shields.io/badge/German-d9d9d9"></a>
  <a href="./README_BN.md"><img alt="README in বাংলা" src="https://img.shields.io/badge/বাংলা-d9d9d9"></a>
</p>

Dify 是一個開源的 LLM 應用開發平台。其直觀介面結合了 Agent 型 AI 工作流、RAG 管線、Agent 能力、模型管理、可觀測性等多種功能，讓你能快速從原型開發到正式上線。

## 快速開始

> 在安裝 Dify 前，請確認您的機器符合以下最低系統需求：
>
> - CPU >= 2 核心
> - 記憶體 >= 4 GiB

</br>

啟動 Dify 伺服器最簡單的方式是使用 [docker compose](docker/docker-compose.yaml)。在執行以下指令前，請確保您的機器已安裝 [Docker](https://docs.docker.com/get-docker/) 與 [Docker Compose](https://docs.docker.com/compose/install/)：

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

執行後，您可在瀏覽器中訪問 [http://localhost/install](http://localhost/install) 進行初始化流程。

#### 尋求協助

如遇設定 Dify 的問題，請參考我們的 [常見問答](https://docs.dify.ai/getting-started/install-self-hosted/faqs)。如仍有疑問，請[聯絡社群與我們](#community--contact)。

> 若您想為 Dify 貢獻或進行更多開發，請參見我們的[原始碼部署指南](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code)

## 核心功能

**1. 工作流**：  
在視覺化畫布上構建並測試強大的 AI 工作流，並可利用下述所有功能及更多。

**2. 全面模型支援**：  
無縫整合數百種專有／開源 LLM，來自多家推理服務商與自建方案，覆蓋 GPT、Mistral、Llama3 及任何相容 OpenAI API 的模型。完整支援的模型供應商列表可見[此處](https://docs.dify.ai/getting-started/readme/model-providers)。

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. Prompt IDE**：  
直觀介面用於撰寫提示詞、比較模型效能，並為聊天應用新增如語音轉文字等附加功能。

**4. RAG 管線**：  
涵蓋從文件導入到檢索的完整 RAG 能力，原生支援從 PDF、PPT 及其他常見文件格式提取文字。

**5. Agent 能力**：  
可基於 LLM Function Calling 或 ReAct 定義 agent，並為 agent 加入預設或自訂工具。Dify 提供 50+ 種內建 AI agent 工具，如 Google 搜尋、DALL·E、Stable Diffusion 與 WolframAlpha 等。

**6. LLMOps**：  
監控並分析應用日誌與效能。你可根據生產數據和註解持續優化提示詞、資料集與模型。

**7. 後端即服務（Backend-as-a-Service）**：  
Dify 所有功能皆提供對應 API，輕鬆整合至自身業務流程。

## 功能比較

<table style="width: 100%;">
  <tr>
    <th align="center">功能</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">程式設計方式</td>
    <td align="center">API + 應用導向</td>
    <td align="center">Python 程式碼</td>
    <td align="center">應用導向</td>
    <td align="center">API 導向</td>
  </tr>
  <tr>
    <td align="center">支援 LLM</td>
    <td align="center">多元豐富</td>
    <td align="center">多元豐富</td>
    <td align="center">多元豐富</td>
    <td align="center">僅限 OpenAI</td>
  </tr>
  <tr>
    <td align="center">RAG 引擎</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">Agent</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">工作流</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">可觀測性</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">企業功能（SSO/權限控管）</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">本地部署</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## 使用 Dify

- **雲端版 </br>**  
  我們提供 [Dify 雲端](https://dify.ai) 服務，零設定即可試用。此服務具備所有自建版本功能，沙盒方案還含 200 次 GPT-4 免費調用。

- **自行部署 Dify 社群版</br>**  
  依循此[入門指南](#quick-start)可快速於您的環境安裝 Dify。更多資訊請參考我們的[文件說明](https://docs.dify.ai)。

- **企業／組織版 Dify</br>**  
  提供更多企業級專屬功能。[透過此聊天機器人向我們提問](https://udify.app/chat/22L1zSxg6yW1cWQg)或[來信聯絡](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry)洽談企業需求。 </br>
  > AWS 上的新創或中小企業，請參見 [AWS Marketplace 上的 Dify Premium](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6)，一鍵部署至您的 AWS VPC。這是實惠的 AMI 方案，可自訂應用 logo 與品牌。

## 持續領先

在 GitHub 上標星 Dify，第一時間獲取新版本通知。

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## 進階設定

如需自訂設定，請參考我們 [.env.example](docker/.env.example) 檔案的註解，並於 `.env` 檔對應欄位進行修改。根據您的部署環境與需求，也可能需調整 `docker-compose.yaml` 內容，如映像版本、埠對映、掛載資料夾等。變更後請重新執行 `docker-compose up -d`。完整環境變數清單請見[文件說明](https://docs.dify.ai/getting-started/install-self-hosted/environments)。

若需高可用部署，可參考社群貢獻的 [Helm Charts](https://helm.sh/) 與 YAML 檔，將 Dify 部署於 Kubernetes。

- [@LeoQuote 貢獻的 Helm Chart](https://github.com/douban/charts/tree/master/charts/dify)
- [@BorisPolonsky 貢獻的 Helm Chart](https://github.com/BorisPolonsky/dify-helm)
- [@magicsong 貢獻的 Helm Chart](https://github.com/magicsong/ai-charts)
- [@Winson-030 貢獻的 YAML 檔](https://github.com/Winson-030/dify-kubernetes)
- [@wyy-holding 貢獻的 YAML 檔](https://github.com/wyy-holding/dify-k8s)

#### 使用 Terraform 部署

利用 [terraform](https://www.terraform.io/) 一鍵部署 Dify 至雲端平台。

##### Azure 全球

- [@nikawang 的 Azure Terraform](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [@sotazum 的 Google Cloud Terraform](https://github.com/DeNA/dify-google-cloud-terraform)

#### 使用 AWS CDK 部署

利用 [CDK](https://aws.amazon.com/cdk/) 部署 Dify 至 AWS。

##### AWS

- [@KevinZhao 的 AWS CDK](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## 貢獻

若您想貢獻程式碼，請參閱[貢獻指南](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)。  
同時，也歡迎在社群媒體、活動、研討會上分享 Dify，支持本專案。

> 我們正在尋找協助將 Dify 翻譯成非中文、英文語言的貢獻者。如有興趣，請參閱 [i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) 了解詳情，並於我們 [Discord 社群](https://discord.gg/8Tpq4AcN9c) 的 `global-users` 頻道留言。

## 社群與聯絡

- [GitHub 討論區](https://github.com/langgenius/dify/discussions)。適合：分享反饋、提問。
- [GitHub 問題](https://github.com/langgenius/dify/issues)。適合：回報 Dify.AI 使用時遇到的 bug、提出新功能。請參閱[貢獻指南](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)。
- [Discord](https://discord.gg/FngNHpbcY7)。適合：分享您的應用、與社群互動。
- [X(Twitter)](https://twitter.com/dify_ai)。適合：分享您的應用、與社群互動。

**貢獻者**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## Star 歷史

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## 安全性揭露

為保護您的隱私，請勿在 GitHub 上提交安全性問題。請將您的疑問發送至 security@dify.ai，我們將提供更詳細的答覆。

## 授權

本儲存庫採用 [Dify 開源授權](LICENSE)，基本上為 Apache 2.0，並有少數額外限制。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---