<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZero 為 LLM 應用創建一個優化反饋循環——將生產數據轉化為更聰明、更快、更便宜的模型。**

1. 整合我們的模型閘道器
2. 發送指標或反饋
3. 優化提示詞、模型和推理策略
4. 觀察你的 LLM 隨時間持續進步

它透過統一以下功能，為 LLM 提供一個**數據與學習飛輪**：

- [x] **推理：**一個 API 支援所有 LLM，P99 延遲小於 1 毫秒
- [x] **可觀察性：**推理與反饋 → 你的資料庫
- [x] **優化：**從提示詞到微調與強化學習
- [x] **評估：**比較提示詞、模型、推理策略
- [x] **實驗：**內建 A/B 測試、路由、備援

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">官方網站</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">文件</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">快速開始（5分鐘）</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">完整教學</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">部署指南</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">API 參考</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">配置參考</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>什麼是 TensorZero？</b></td>
    <td width="70%" valign="top">TensorZero 是一個開源框架，用於構建生產等級的 LLM 應用。它統一了 LLM 閘道器、可觀察性、優化、評估與實驗功能。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 與其他 LLM 框架有何不同？</b></td>
    <td width="70%" valign="top">
      1. TensorZero 讓你能基於生產指標與人工反饋來優化複雜的 LLM 應用。<br>
      2. TensorZero 支援工業級 LLM 應用的需求：低延遲、高吞吐、型別安全、自主託管、GitOps、自訂化等。<br>
      3. TensorZero 統一了整個 LLMOps 技術棧，帶來複利效應。例如，LLM 評估可用於模型微調，並結合 AI 評審。
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>我可以搭配 ___ 使用 TensorZero 嗎？</b></td>
    <td width="70%" valign="top">可以。支援所有主流程式語言。你可以使用我們的 Python 客戶端、任何 OpenAI SDK 或 HTTP API。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 適合生產環境嗎？</b></td>
    <td width="70%" valign="top">是的。這裡有一個案例研究：<b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">利用 LLM 在大型銀行自動化程式碼變更日誌</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZero 費用多少？</b></td>
    <td width="70%" valign="top">免費。TensorZero 為 100% 自主託管且開源。沒有付費功能。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>誰在開發 TensorZero？</b></td>
    <td width="70%" valign="top">我們的技術團隊包含前 Rust 編譯器維護者、機器學習研究員（來自 Stanford、CMU、Oxford、Columbia，擁有數千篇引用），以及十角獸新創公司的首席產品長。我們獲得與頂尖開源專案（如 ClickHouse、CockroachDB）及 AI 實驗室（如 OpenAI、Anthropic）同一批投資人的支持。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>如何開始使用？</b></td>
    <td width="70%" valign="top">你可以漸進地導入 TensorZero。我們的<b><a href="https://www.tensorzero.com/docs/quickstart">快速開始</a></b>僅需 5 分鐘即可從簡單的 OpenAI 包裝器到具備可觀察性與微調的生產級 LLM 應用。</td>
  </tr>
</table>

---

## 功能特色

### 🌐 LLM 閘道器

> **只需整合 TensorZero 一次，即可存取所有主流 LLM 供應商。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>模型供應商</b></td>
    <td width="50%" align="center" valign="middle"><b>功能</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero 閘道器原生支援：
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/anthropic">Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-bedrock">AWS Bedrock</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/aws-sagemaker">AWS SageMaker</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/azure">Azure OpenAI Service</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/deepseek">DeepSeek</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/fireworks">Fireworks</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-anthropic">GCP Vertex AI Anthropic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/gcp-vertex-ai-gemini">GCP Vertex AI Gemini</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/google-ai-studio-gemini">Google AI Studio (Gemini API)</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/hyperbolic">Hyperbolic</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/mistral">Mistral</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai">OpenAI</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/together">Together</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/vllm">vLLM</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/xai">xAI</a></b></li>
      </ul>
      <p>
        <em>
          還需要其他供應商嗎？
          你的供應商很可能已支援，因為 TensorZero 可整合 <b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">任何 OpenAI 相容 API（如 Ollama）</a></b>。
          </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero 閘道器支援進階功能，例如：
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">重試與備援</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">推理時最佳化</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">提示詞模板與結構</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">實驗（A/B 測試）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">程式化配置（GitOps）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">批次推理</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">多模態推理（VLMs）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">推理快取</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">指標與反饋</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">多步驟 LLM 工作流（Episodes）</a></b></li>
        <li><em>以及更多…</em></li>
      </ul>
      <p>
        TensorZero 閘道器以 Rust 🦀 編寫，著重<b>效能</b>（@ 10k QPS，P99 延遲小於 1 毫秒）。
        請參見 <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">效能基準</a></b>。<br>
      </p>
      <p>
        你可以使用 <b>TensorZero 客戶端</b>（推薦）、<b>OpenAI 客戶端</b>，或 <b>HTTP API</b> 進行推理。
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>用法：Python — TensorZero 客戶端（推薦）</b></summary>

你可以使用 TensorZero Python 客戶端存取任何供應商。

1. `pip install tensorzero`
2. 選擇性：設定 TensorZero 配置。
3. 執行推理：

```python
from tensorzero import TensorZeroGateway  # 或 AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # 輕鬆嘗試其他供應商："anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "寫一首有關人工智慧的俳句。",
                }
            ]
        },
    )
```

更多資訊請見 **[快速開始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：Python — OpenAI 客戶端</b></summary>

你可以使用 OpenAI Python 客戶端結合 TensorZero 存取任何供應商。

1. `pip install tensorzero`
2. 選擇性：設定 TensorZero 配置。
3. 執行推理：

```python
from openai import OpenAI  # 或 AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # 輕鬆嘗試其他供應商: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "寫一首關於人工智慧的俳句。",
        }
    ],
)
```

查看更多資訊，請參閱 **[快速開始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：JavaScript / TypeScript (Node) &mdash; OpenAI 用戶端</b></summary>

你可以透過 TensorZero 使用 OpenAI Node 用戶端存取任何供應商。

1. 使用 Docker 部署 `tensorzero/gateway`。
   **[詳細說明 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. 設定 TensorZero 配置。
3. 執行推論：

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // 輕鬆嘗試其他供應商: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "寫一首關於人工智慧的俳句。",
    },
  ],
});
```

查看更多資訊，請參閱 **[快速開始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<details>
<summary><b>用法：其他語言與平台 &mdash; HTTP API</b></summary>

TensorZero 透過其 HTTP API 幾乎支援所有程式語言或平台。

1. 使用 Docker 部署 `tensorzero/gateway`。
   **[詳細說明 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. （可選）設定 TensorZero 配置。
3. 執行推論：

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "寫一首關於人工智慧的俳句。"
        }
      ]
    }
  }'
```

查看更多資訊，請參閱 **[快速開始](https://www.tensorzero.com/docs/quickstart)**。

</details>

<br>

### 📈 LLM 最佳化

> **傳送生產指標及人類回饋，輕鬆優化你的提示詞、模型與推論策略 — 可以透過 UI 或程式化操作。**

#### 模型最佳化

使用監督式微調（SFT）及偏好微調（DPO）來最佳化封閉原始碼及開放原始碼模型。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>監督式微調 &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>偏好微調 (DPO) &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### 推論時最佳化

透過動態更新你的提示詞與相關範例、組合多次推論的回應等方式提升效能。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-N 取樣</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-N 取樣</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">動態上下文學習（DICL）</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">思維鏈（CoT）</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_更多功能即將推出..._

<br>

#### 提示詞最佳化

利用研究導向的最佳化技術，程式化地優化你的提示詞。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy 整合</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZero 內建多種最佳化配方，你也可以輕鬆自訂。
      此範例展示如何利用任意工具優化 TensorZero 函式 —— 這裡以 DSPy 為例，一個熱門的自動化提示工程函式庫。
    </td>
  </tr>
</table>

_更多功能即將推出..._

<br>

### 🔍 LLM 可觀測性

> **放大檢查單一 API 呼叫進行除錯，或縮小監控跨模型與提示詞的指標變化 —— 一切盡在開源的 TensorZero UI。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>可觀測性 » 推論</b></td>
    <td width="50%" align="center" valign="middle"><b>可觀測性 » 函式</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM 評測

> **使用 TensorZero Evaluations 比較提示詞、模型與推論策略 —— 支援啟發式與 LLM 評審。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>評測 » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>評測 » CLI</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/f4bf54e3-1b63-46c8-be12-2eaabf615699"></td>
    <td width="50%" align="left" valign="middle">
<pre><code class="language-bash">docker compose run --rm evaluations \
  --evaluation-name extract_data \
  --dataset-name hard_test_cases \
  --variant-name gpt_4o \
  --concurrency 5</code></pre>
<pre><code class="language-bash">Run ID: 01961de9-c8a4-7c60-ab8d-15491a9708e4
Number of datapoints: 100
██████████████████████████████████████ 100/100
exact_match: 0.83 ± 0.03
semantic_match: 0.98 ± 0.01
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## 展示

> **觀看 LLMs 如何在 TensorZero 上即時提升資料擷取能力！**
>
> **[動態語境學習（DICL）](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** 是 TensorZero 內建的一項強大推論時優化功能。
> 它能自動將相關的歷史範例納入提示詞中，無需對模型進行微調，即可提升 LLM 表現。

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## 使用 TensorZero 進行 LLM 工程

<br>
<p align="center" >
  <a href="https://www.tensorzero.com/docs">
    <picture>
      <source media="(prefers-color-scheme: light)" srcset="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6">
      <source media="(prefers-color-scheme: dark)" srcset="https://github.com/user-attachments/assets/e8bc699b-6378-4c2a-9cc1-6d189025e270">
      <img alt="TensorZero Flywheel" src="https://github.com/user-attachments/assets/34a92c18-242e-4d76-a99c-861283de68a6" width=720>
    </picture>
  </a>
</p>
<br>

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** 是一個以 Rust 🦀 編寫的高效能模型閘道，為所有主流 LLM 供應商提供統一 API 介面，實現無縫跨平台整合與備援切換。
2. 它以結構化 schema 為基礎的推論處理，P99 延遲開銷小於 1 毫秒（請參考 **[效能基準](https://www.tensorzero.com/docs/gateway/benchmarks)**），並內建可觀測性、實驗管理、以及**[推論時優化](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)**功能。
3. 同時收集這些推論結果的下游指標與回饋，並針對多步驟 LLM 系統提供一流支援。
4. 所有資料皆存儲於您可控的 ClickHouse 數據倉儲中，實現即時、可擴展且對開發者友善的分析功能。
5. 隨著時間推移，**[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** 會利用這個結構化資料集來優化您的提示詞與模型：可執行預建的常見流程優化食譜（如微調），也可用任意語言或平台自訂屬於自己的流程。
6. 最後，閘道的實驗功能及 GitOps 編排讓您無論是單一 LLM 或上千個 LLM，都能自信地迭代與部署。

我們的目標是協助工程師打造、管理並優化下一代 LLM 應用系統：讓系統能從真實世界經驗中持續學習。
進一步了解我們的**[願景與路線圖](https://www.tensorzero.com/docs/vision-roadmap/)**。

## 立即開始

**立即開始開發。**
參考 **[快速入門](https://www.tensorzero.com/docs/quickstart)**，即可輕鬆設定 TensorZero 的 LLM 應用。
想進一步深入學習，可參考**[教學課程](https://www.tensorzero.com/docs/gateway/tutorial)**，學習如何建立簡單的聊天機器人、郵件助手、天氣 RAG 系統，以及結構化資料擷取流程。

**有問題嗎？**
歡迎加入 **[Slack](https://www.tensorzero.com/slack)** 或 **[Discord](https://www.tensorzero.com/discord)** 與我們討論。

**在工作中使用 TensorZero？**
歡迎來信 **[hello@tensorzero.com](mailto:hello@tensorzero.com)**，我們可協助您與團隊免費建立 Slack 或 Teams 頻道。

**加入我們。**
我們正在**[紐約市徵才](https://www.tensorzero.com/jobs)**。
同時也歡迎**[開源貢獻](https://raw.githubusercontent.com/tensorzero/tensorzero/main/CONTRIBUTING.md)**！

## 範例

我們正在製作一系列**完整可執行範例**，展示 TensorZero 的數據與學習飛輪。

> **[使用 TensorZero 優化資料擷取（NER）](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/data-extraction-ner)**
>
> 本範例展示如何利用 TensorZero 優化資料擷取流程。
> 我們說明了微調與動態語境學習（DICL）等技巧。
> 最終，優化後的 GPT-4o Mini 模型在這個任務上超越 GPT-4o，僅需極少的訓練資料，成本與延遲大幅降低。

> **[Agentic RAG — 使用 LLM 進行多跳問答](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> 本範例展示如何透過 TensorZero 建立一個多跳檢索代理。
> 代理會迭代搜尋維基百科收集資訊，並判斷何時擁有足夠的上下文來回答複雜問題。

> **[為滿足隱藏偏好的評審寫俳句](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/haiku-hidden-preferences)**
>
> 此範例將 GPT-4o Mini 微調至能依特定喜好生成俳句。
> 您將見證 TensorZero 的「一站式資料飛輪」：更佳變體帶來更佳資料，進而產生更佳變體。
> 同時可見多次微調 LLM 的進展。

> **[利用 Best-of-N 取樣提升 LLM 西洋棋能力](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/chess-puzzles/)**
>
> 本範例展示如何透過多方案取樣（Best-of-N sampling），從多個生成選項中選取最佳步驟，大幅提升 LLM 的西洋棋能力。

> **[使用自訂食譜（DSPy）自動提示工程優化數學推理](https://raw.githubusercontent.com/tensorzero/tensorzero/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZero 提供多種預建最佳化食譜，涵蓋常見 LLM 工程流程。
> 但您也能輕鬆自訂專屬食譜與流程！
> 本範例展示如何利用任意工具（此處為 DSPy）最佳化 TensorZero 函數。

_還有更多精彩範例，敬請期待！_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---