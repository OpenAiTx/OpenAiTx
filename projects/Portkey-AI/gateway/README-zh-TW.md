<p align="right">
   <strong>English</strong> | <a href="./.github/README.cn.md">中文</a> | <a href="./.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### 只需一個快速且友善的 API，即可串接 250+ 種 LLM

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[文件](https://portkey.wiki/gh-1) | [企業版](https://portkey.wiki/gh-2) | [託管 Gateway](https://portkey.wiki/gh-3) | [更新日誌](https://portkey.wiki/gh-4) | [API 參考](https://portkey.wiki/gh-5)


[![License](https://img.shields.io/github/license/Ileriayo/markdown-badges)](./LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npm version](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) 專為快速、可靠且安全地路由至 1600+ 種語言、視覺、音頻及圖像模型設計。這是一套輕量級、開源且企業級的解決方案，讓你能在 2 分鐘內整合任何語言模型。

- [x] **極速運作**（<1ms 延遲），體積超小（122kb）
- [x] **經過實戰驗證**，每日處理超過 100 億 tokens
- [x] **企業就緒**，強化安全性、可擴展性與自訂部署

<br>

#### 你可以用 AI Gateway 做什麼？
- 2 分鐘內整合任何 LLM - [快速上手](#quickstart-2-mins)
- 透過 **[自動重試](https://portkey.wiki/gh-11)** 和 **[備援機制](https://portkey.wiki/gh-12)** 防止停機
- 以 **[負載平衡](https://portkey.wiki/gh-13)** 和 **[條件路由](https://portkey.wiki/gh-14)** 擴展 AI 應用
- 以 **[防護欄](https://portkey.wiki/gh-15)** 保護你的 AI 部署
- 輕鬆拓展至**[多模態能力](https://portkey.wiki/gh-16)**
- 進一步探索**[代理型工作流](https://portkey.wiki/gh-17)** 整合

<br><br>

> [!TIP]
> 給本倉庫加星有助於讓更多開發者發現 AI Gateway 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## 快速上手（2 分鐘）

### 1. 設定你的 AI Gateway

```bash
# 在本地運行 Gateway（需先安裝 Node.js 和 npm）
npx @portkey-ai/gateway
```
> Gateway 運行於 `http://localhost:8787/v1`
> 
> Gateway 控制台運行於 `http://localhost:8787/public/`

<sup>
部署指南：
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud（推薦）</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> 其他...</a>

</sup>

### 2. 發送你的第一個請求

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI 相容的 client
client = Portkey(
    provider="openai", # 或 'anthropic', 'bedrock', 'groq', 等等
    Authorization="sk-***" # 供應商 API 金鑰
)

# 透過 AI Gateway 發送請求
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>支援的函式庫：
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [更多..](https://portkey.wiki/gh-26)
</sup>

在 Gateway 控制台 (`http://localhost:8787/public/`) 中，你可以集中查看所有本地日誌。

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. 路由與防護欄
LLM gateway 的 `Configs` 讓你可以建立路由規則、增強可靠性並設置防護欄。
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# 將 config 附加到 client
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# 由於防護欄會拒絕所有包含 "Apple" 的回應，因此這裡總是回覆 "Bat"。重試設定會在放棄前重試 5 次。
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

你可以在 AI Gateway 的 config 中做更多進階設定。[查看更多範例 →](https://portkey.wiki/gh-27)

<br/>

### 企業版（私有部署）

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM Gateway 的[企業版](https://portkey.wiki/gh-86) 提供 **組織管理**、**治理**、**安全性** 等[進階功能](https://portkey.wiki/gh-87)。[查看功能比較 →](https://portkey.wiki/gh-32)

支援平台的企業部署架構，請參考此處 - [**企業私有雲部署**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book an enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### AI Engineering Hours

每週五（上午 8 點 PT）加入社群會議，快速啟動你的 AI Gateway 專案！[每週五固定舉行](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

會議紀錄[於此發布](https://portkey.wiki/gh-36)。


<hr>

### LLMs in Prod'25

基於超過 2 兆 tokens，橫跨 90+ 區域、650+ 團隊的生產環境分析洞察。本報告內容包含：
- 引領 AI 採用與 LLM 供應商成長的趨勢。
- 優化速度、成本與可靠性的基準。
- 大規模生產級 AI 系統的擴展策略。

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**取得報告**</a>
<hr>


## 核心功能
### 可靠路由
- <a href="https://portkey.wiki/gh-37">**故障轉移（Fallbacks）**</a>：當請求失敗時，通過 LLM Gateway 自動切換到其他供應商或模型。你可以指定觸發故障轉移的錯誤類型，提升應用程式的可靠性。
- <a href="https://portkey.wiki/gh-38">**自動重試（Automatic Retries）**</a>：自動重試失敗的請求，最多可達 5 次。採用指數退避策略，以避免網路過載。
- <a href="https://portkey.wiki/gh-39">**負載平衡（Load Balancing）**</a>：將 LLM 請求分配到多個 API 金鑰或 AI 供應商，通過權重分配，確保高可用性與最佳效能。
- <a href="https://portkey.wiki/gh-40">**請求逾時（Request Timeouts）**</a>：通過設置細緻的請求逾時，管理 LLM 的異常與延遲，自動終止超時的請求。
- <a href="https://portkey.wiki/gh-41">**多模態 LLM Gateway**</a>：使用熟悉的 OpenAI 介面，從多家供應商調用視覺、音訊（文字轉語音與語音轉文字）、圖像生成模型。
- <a href="https://portkey.wiki/gh-42">**即時 API**</a>：通過整合 websockets 伺服器，調用 OpenAI 推出的即時 API。

### 安全性與準確性
- <a href="https://portkey.wiki/gh-88">**防護軌道（Guardrails）**</a>：驗證你的 LLM 輸入與輸出是否符合指定檢查。可從 40 多個預建防護軌道中選擇，以確保符合安全與準確標準。你也可以<a href="https://portkey.wiki/gh-43">自訂防護軌道</a>或選用我們的<a href="https://portkey.wiki/gh-44">多家合作夥伴</a>。
- [**安全金鑰管理**](https://portkey.wiki/gh-45)：可使用自己的金鑰，或即時產生虛擬金鑰。
- [**基於角色的存取控制**](https://portkey.wiki/gh-46)：為用戶、工作區及 API 金鑰提供細緻存取控制。
- <a href="https://portkey.wiki/gh-47">**合規性與資料隱私**</a>：AI Gateway 符合 SOC2、HIPAA、GDPR 及 CCPA 標準。

### 成本管理
- [**智慧快取**](https://portkey.wiki/gh-48)：快取 LLM 回應以降低成本並提升延遲表現。支援簡單及語意*快取。
- [**使用分析**](https://portkey.wiki/gh-49)：監控並分析你的 AI 與 LLM 使用情況，包括請求量、延遲、成本及錯誤率。
- [**供應商最佳化***](https://portkey.wiki/gh-89)：根據使用模式與價格自動切換至最具成本效益的供應商。

### 協作與工作流
- <a href="https://portkey.ai/docs/integrations/agents">**代理支援**</a>：可無縫整合主流代理框架，構建複雜 AI 應用。Gateway 可與 [Autogen](https://portkey.wiki/gh-50)、[CrewAI](https://portkey.wiki/gh-51)、[LangChain](https://portkey.wiki/gh-52)、[LlamaIndex](https://portkey.wiki/gh-53)、[Phidata](https://portkey.wiki/gh-54)、[Control Flow](https://portkey.wiki/gh-55)，甚至[自訂代理](https://portkey.wiki/gh-56)順利整合。
- [**提示模板管理***](https://portkey.wiki/gh-57)：透過通用提示遊樂場協作建立、管理與版本化提示模板。
<br/><br/>

<sup>
*&nbsp;僅在雲端與企業版提供
</sup>

<br>

## 教學範例（Cookbooks）

### ☄️ 熱門
- 使用 AI Gateway 連接 [Nvidia NIM](/cookbook/providers/nvidia.ipynb) 模型
- 用 Portkey 監控 [CrewAI Agents](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb)！
- 與 AI Gateway 比較 [前 10 名 LMSYS 模型](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb)。

### 🚨 最新
* [使用 Nemotron 建立合成資料集](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [將 LLM Gateway 與 Vercel 的 AI SDK 整合使用](/cookbook/integrations/vercel-ai.md)
* [用 Portkey 的 LLM Gateway 監控 Llama Agents](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[檢視所有教學範例 →](https://portkey.wiki/gh-58)
<br/><br/>

## 支援的供應商

探索 Gateway 與 [45+ 供應商](https://portkey.wiki/gh-59) 及 [8+ 代理框架](https://portkey.wiki/gh-90) 的整合。

|                                                                                                                            | 供應商                                                                                      | 支援 | 串流 |
| -------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ---- | ---- |
| <img src="docs/images/openai.png" width=35 />                                                                              | [OpenAI](https://portkey.wiki/gh-60)                           | ✅       | ✅      |
| <img src="docs/images/azure.png" width=35>                                                                                 | [Azure OpenAI](https://portkey.wiki/gh-61)               | ✅       | ✅      |
| <img src="docs/images/anyscale.png" width=35>                                                                              | [Anyscale](https://portkey.wiki/gh-62) | ✅       | ✅      |
| <img src="https://upload.wikimedia.org/wikipedia/commons/2/2d/Google-favicon-2015.png" width=35>                           | [Google Gemini](https://portkey.wiki/gh-63)             | ✅       | ✅      |
| <img src="docs/images/anthropic.png" width=35>                                                                             | [Anthropic](https://portkey.wiki/gh-64)                     | ✅       | ✅      |
| <img src="docs/images/cohere.png" width=35>                                                                                | [Cohere](https://portkey.wiki/gh-65)                           | ✅       | ✅      |
| <img src="https://assets-global.website-files.com/64f6f2c0e3f4c5a91c1e823a/654693d569494912cfc0c0d4_favicon.svg" width=35> | [Together AI](https://portkey.wiki/gh-66)                 | ✅       | ✅      |
| <img src="https://www.perplexity.ai/favicon.svg" width=35>                                                                 | [Perplexity](https://portkey.wiki/gh-67)                | ✅       | ✅      |
| <img src="https://docs.mistral.ai/img/favicon.ico" width=35>                                                               | [Mistral](https://portkey.wiki/gh-68)                      | ✅       | ✅      |
| <img src="https://docs.nomic.ai/img/nomic-logo.png" width=35>                                                              | [Nomic](https://portkey.wiki/gh-69)                             | ✅       | ✅      |
| <img src="https://files.readme.io/d38a23e-small-studio-favicon.png" width=35>                                              | [AI21](https://portkey.wiki/gh-91)                                    | ✅       | ✅      |
| <img src="https://platform.stability.ai/small-logo-purple.svg" width=35>                                                   | [Stability AI](https://portkey.wiki/gh-71)               | ✅       | ✅      |
| <img src="https://deepinfra.com/_next/static/media/logo.4a03fd3d.svg" width=35>                                            | [DeepInfra](https://portkey.sh/gh-92)                               | ✅       | ✅      |
| <img src="https://ollama.com/public/ollama.png" width=35>                                                                  | [Ollama](https://portkey.wiki/gh-72)                           | ✅       | ✅      |
| <img src="https://novita.ai/favicon.ico" width=35>                                                                         | [Novita AI](https://portkey.wiki/gh-73)                              | ✅       | ✅      | `/chat/completions`, `/completions` |


> [點擊這裡檢視 200+ 支援模型完整清單](https://portkey.wiki/gh-74)
<br>

<br>

## 代理框架
Gateway 可無縫整合主流代理框架。[閱讀相關文件](https://portkey.wiki/gh-75)。

| 框架 | 呼叫 200+ LLM | 進階路由 | 快取 | 日誌與追蹤* | 可觀察性* | 提示管理* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [自建代理](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

*僅限於 [雲端應用](https://portkey.wiki/gh-76)。詳細文件請[點此](https://portkey.wiki/gh-100)。

## Gateway 企業版
讓你的 AI 應用更<ins>可靠</ins>、<ins>前向相容</ins>，同時確保<ins>資料安全</ins>與<ins>隱私</ins>。

✅&nbsp; 安全金鑰管理 —— 支援基於角色的存取控制與追蹤<br>
✅&nbsp; 簡單與語意快取 —— 更快回應重複查詢，節省成本<br>
✅&nbsp; 存取控制與入站規則 —— 控制哪些 IP 與地區可連接你的部署<br>
✅&nbsp; PII 資料遮蔽 —— 自動移除請求中的敏感資料，防止意外外洩<br>
✅&nbsp; SOC2、ISO、HIPAA、GDPR 合規 —— 採用最佳安全實踐<br>
✅&nbsp; 專業技術支援 —— 及功能優先開發服務<br>

[預約通話，討論企業部署](https://portkey.sh/demo-13)

<br>

## 貢獻指南

最簡單的貢獻方式是選擇帶有 `good first issue` 標籤的議題 💪。請閱讀[貢獻指南](/.github/CONTRIBUTING.md)。

回報錯誤？[請點這裡](https://portkey.wiki/gh-78) ｜ 功能需求？[請點這裡](https://portkey.wiki/gh-78)

### 社群新手入門
每週五（美西時間上午 8 點）參加我們的 AI 工程時間，內容包括：
- 與其他貢獻者及社群成員交流
- 學習 Gateway 進階功能與實作範例
- 分享經驗並獲得協助
- 隨時掌握最新開發方向

[加入下次會議 →](https://portkey.wiki/gh-101) ｜ [會議紀錄](https://portkey.wiki/gh-102)

<br>

## 社群

加入我們遍佈全球的社群，尋求協助、交流想法與 AI 討論。

- 查看官方 [部落格](https://portkey.wiki/gh-78)
- 在 [Discord](https://portkey.wiki/community) 與我們交流
- 追蹤我們的 [Twitter](https://portkey.wiki/gh-79)
- 連結我們的 [LinkedIn](https://portkey.wiki/gh-80)
- 閱讀 [日文版文件](./.github/README.jp.md)
- 造訪我們的 [YouTube](https://portkey.wiki/gh-103)
- 加入我們的 [開發者社群](https://portkey.wiki/gh-82)
<!-- - Questions tagged #portkey on [Stack Overflow](https://stackoverflow.com/questions/tagged/portkey) -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---