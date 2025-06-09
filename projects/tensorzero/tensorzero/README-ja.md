<img src="https://github.com/user-attachments/assets/47d67430-386d-4675-82ad-d4734d3262d9" width=128 height=128>

# TensorZero

**TensorZeroは、LLMアプリケーションの最適化のためのフィードバックループを作成し、本番データをよりスマートで高速、かつ低コストなモデルへと進化させます。**

1. モデルゲートウェイを統合
2. メトリクスまたはフィードバックを送信
3. プロンプト、モデル、推論戦略を最適化
4. LLMの進化を継続的に観察

TensorZeroは、以下を統合することで**LLMのためのデータ＆ラーニング・フライホイール**を提供します。

- [x] **推論:** すべてのLLM用の単一API、P99オーバーヘッド<1ms
- [x] **可観測性:** 推論＆フィードバック → あなたのデータベース
- [x] **最適化:** プロンプトからファインチューニング、RLまで
- [x] **評価:** プロンプト、モデル、推論戦略の比較
- [x] **実験:** 組み込みのA/Bテスト、ルーティング、フォールバック

---

<p align="center">
  <b><a href="https://www.tensorzero.com/" target="_blank">ウェブサイト</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs" target="_blank">ドキュメント</a></b>
  ·
  <b><a href="https://www.x.com/tensorzero" target="_blank">Twitter</a></b>
  ·
  <b><a href="https://www.tensorzero.com/slack" target="_blank">Slack</a></b>
  ·
  <b><a href="https://www.tensorzero.com/discord" target="_blank">Discord</a></b>
  <br>
  <br>
  <b><a href="https://www.tensorzero.com/docs/quickstart" target="_blank">クイックスタート（5分）</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/tutorial" target="_blank">包括的チュートリアル</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">デプロイガイド</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/api-reference" target="_blank">APIリファレンス</a></b>
  ·
  <b><a href="https://www.tensorzero.com/docs/gateway/deployment" target="_blank">設定リファレンス</a></b>
</p>

---

<table>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroとは？</b></td>
    <td width="70%" valign="top">TensorZeroは、本番運用レベルのLLMアプリケーションを構築するためのオープンソースフレームワークです。LLMゲートウェイ、可観測性、最適化、評価、実験を統合します。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroは他のLLMフレームワークと何が違うのですか？</b></td>
    <td width="70%" valign="top">
      1. TensorZeroは、本番メトリクスや人間のフィードバックに基づいて複雑なLLMアプリケーションを最適化できます。<br>
      2. TensorZeroは、低レイテンシー、高スループット、型安全性、セルフホスト、GitOps、カスタマイズ性など、産業規模のLLMアプリケーションの要件をサポートします。<br>
      3. TensorZeroはLLMOpsスタック全体を統合し、複利的な恩恵をもたらします。例えば、LLM評価はAIジャッジとともにモデルのファインチューニングにも利用できます。
    </td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroは___と一緒に使えますか？</b></td>
    <td width="70%" valign="top">はい。主要なプログラミング言語すべてに対応しています。TensorZeroのPythonクライアント、任意のOpenAI SDK、またはHTTP APIが利用できます。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroは本番運用に対応していますか？</b></td>
    <td width="70%" valign="top">はい。こちらが事例です: <b><a href="https://www.tensorzero.com/blog/case-study-automating-code-changelogs-at-a-large-bank-with-llms">大手銀行におけるLLMによるコードチェンジログの自動化</a></b></td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroのコストは？</b></td>
    <td width="70%" valign="top">無料です。TensorZeroは100%セルフホスト＆オープンソースで、有料機能はありません。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>TensorZeroの開発者は？</b></td>
    <td width="70%" valign="top">当社技術チームには、元Rustコンパイラメンテナー、数千件の引用を持つ機械学習研究者（スタンフォード、CMU、オックスフォード、コロンビア）、デカコーンスタートアップのCPOが在籍しています。ClickHouseやCockroachDBなどのオープンソースプロジェクト、OpenAIやAnthropicなどのAIラボと同じ投資家の支援を受けています。</td>
  </tr>
  <tr>
    <td width="30%" valign="top"><b>どうやって始めればいいですか？</b></td>
    <td width="70%" valign="top">TensorZeroは段階的に導入できます。<b><a href="https://www.tensorzero.com/docs/quickstart">クイックスタート</a></b>では、素のOpenAIラッパーから可観測性やファインチューニングを備えた本番レベルのLLMアプリケーションまで、5分で到達できます。</td>
  </tr>
</table>

---

## 特長

### 🌐 LLMゲートウェイ

> **TensorZeroを一度統合するだけで、主要なLLMプロバイダーすべてにアクセス可能。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>モデルプロバイダー</b></td>
    <td width="50%" align="center" valign="middle"><b>特長</b></td>
  </tr>
  <tr>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gatewayは以下をネイティブサポートします:
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
          他に必要なプロバイダーは？TensorZeroは<b><a href="https://www.tensorzero.com/docs/gateway/guides/providers/openai-compatible">OpenAI互換API（例: Ollama）</a></b>にも対応しているため、ほとんどのプロバイダーが利用可能です。
        </em>
      </p>
    </td>
    <td width="50%" align="left" valign="top">
      <p>
        TensorZero Gatewayは以下のような高度な機能をサポートします:
      </p>
      <ul>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/retries-fallbacks">リトライ＆フォールバック</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations">推論時最適化</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/prompt-templates-schemas">プロンプトテンプレート＆スキーマ</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/tutorial#experimentation">実験（A/Bテスト）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/configuration-reference">コードによる設定（GitOps）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/batch-inference">バッチ推論</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/multimodal-inference">マルチモーダル推論（VLMs）</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-caching">推論キャッシュ</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/metrics-feedback">メトリクス＆フィードバック</a></b></li>
        <li><b><a href="https://www.tensorzero.com/docs/gateway/guides/episodes">マルチステップLLMワークフロー（エピソード）</a></b></li>
        <li><em>その他多数…</em></li>
      </ul>
      <p>
        TensorZero Gatewayはパフォーマンスを重視してRust 🦀 で記述されています（10k QPSでp99レイテンシーオーバーヘッド&lt;1ms）。
        <b><a href="https://www.tensorzero.com/docs/gateway/benchmarks">ベンチマーク</a></b>を参照してください。<br>
      </p>
      <p>
        <b>TensorZeroクライアント</b>（推奨）、<b>OpenAIクライアント</b>、または<b>HTTP API</b>で推論が可能です。
      </p>
    </td>
  </tr>
</table>

<br>

<details open>
<summary><b>使い方: Python &mdash; TensorZeroクライアント（推奨）</b></summary>

TensorZero Pythonクライアントを使えば、どのプロバイダーにもアクセス可能です。

1. `pip install tensorzero`
2. オプション: TensorZeroの設定を行う
3. 推論を実行:

```python
from tensorzero import TensorZeroGateway  # または AsyncTensorZeroGateway


with TensorZeroGateway.build_embedded(clickhouse_url="...", config_file="...") as client:
    response = client.inference(
        model_name="openai::gpt-4o-mini",
        # 他のプロバイダーも簡単に試せます: "anthropic::claude-3-7-sonnet-20250219"
        input={
            "messages": [
                {
                    "role": "user",
                    "content": "人工知能について俳句を書いてください。",
                }
            ]
        },
    )
```

詳しくは**[クイックスタート](https://www.tensorzero.com/docs/quickstart)**をご覧ください。

</details>

<details>
<summary><b>使い方: Python &mdash; OpenAIクライアント</b></summary>

OpenAI PythonクライアントとTensorZeroを組み合わせて、どのプロバイダーにもアクセス可能です。

1. `pip install tensorzero`
2. オプション: TensorZeroの設定を行う
3. 推論を実行:

```python
from openai import OpenAI  # または AsyncOpenAI
from tensorzero import patch_openai_client

client = OpenAI()
```
```python
patch_openai_client(
    client,
    clickhouse_url="http://chuser:chpassword@localhost:8123/tensorzero",
    config_file="config/tensorzero.toml",
    async_setup=False,
)

response = client.chat.completions.create(
    model="tensorzero::model_name::openai::gpt-4o-mini",
    # 他のプロバイダーも簡単に試せます: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
    messages=[
        {
            "role": "user",
            "content": "人工知能について俳句を書いてください。",
        }
    ],
)
```

詳細は **[クイックスタート](https://www.tensorzero.com/docs/quickstart)** をご覧ください。

</details>

<details>
<summary><b>使い方: JavaScript / TypeScript (Node) &mdash; OpenAI クライアント</b></summary>

TensorZeroを使って、OpenAI Nodeクライアントで任意のプロバイダーにアクセスできます。

1. Dockerで `tensorzero/gateway` をデプロイします。
   **[詳細手順 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. TensorZeroの設定を行います。
3. 推論を実行します:

```ts
import OpenAI from "openai";

const client = new OpenAI({
  baseURL: "http://localhost:3000/openai/v1",
});

const response = await client.chat.completions.create({
  model: "tensorzero::model_name::openai::gpt-4o-mini",
  // 他のプロバイダーも簡単に試せます: "tensorzero::model_name::anthropic::claude-3-7-sonnet-20250219"
  messages: [
    {
      role: "user",
      content: "人工知能について俳句を書いてください。",
    },
  ],
});
```

詳細は **[クイックスタート](https://www.tensorzero.com/docs/quickstart)** をご覧ください。

</details>

<details>
<summary><b>使い方: その他の言語 & プラットフォーム &mdash; HTTP API</b></summary>

TensorZeroはHTTP API経由で、ほぼすべてのプログラミング言語やプラットフォームをサポートしています。

1. Dockerで `tensorzero/gateway` をデプロイします。
   **[詳細手順 →](https://www.tensorzero.com/docs/gateway/deployment)**
2. 任意: TensorZeroの設定を行います。
3. 推論を実行します:

```bash
curl -X POST "http://localhost:3000/inference" \
  -H "Content-Type: application/json" \
  -d '{
    "model_name": "openai::gpt-4o-mini",
    "input": {
      "messages": [
        {
          "role": "user",
          "content": "人工知能について俳句を書いてください。"
        }
      ]
    }
  }'
```

詳細は **[クイックスタート](https://www.tensorzero.com/docs/quickstart)** をご覧ください。

</details>

<br>

### 📈 LLM最適化

> **本番メトリクスや人間のフィードバックを送信して、プロンプト・モデル・推論戦略を簡単に最適化できます（UIまたはプログラムから）。**

#### モデル最適化

教師ありファインチューニング（SFT）や選好ファインチューニング（DPO）を用いて、クローズドソース・オープンソース両方のモデルを最適化できます。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>教師ありファインチューニング &mdash; UI</b></td>
    <td width="50%" align="center" valign="middle"><b>選好ファインチューニング（DPO） &mdash; Jupyter Notebook</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/cf7acf66-732b-43b3-af2a-5eba1ce40f6f"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/a67a0634-04a7-42b0-b934-9130cb7cdf51"></td>
  </tr>
</table>

#### 推論時最適化

関連する例でプロンプトを動的に更新したり、複数推論のレスポンスを組み合わせるなどしてパフォーマンスを向上させます。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">Best-of-Nサンプリング</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#mixture-of-n-sampling">Mixture-of-Nサンプリング</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/c0edfa4c-713c-4996-9964-50c0d26e6970"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/75b5bf05-4c1f-43c4-b158-d69d1b8d05be"></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl">動的インコンテキスト学習（DICL）</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#chain-of-thought-cot">Chain-of-Thought（CoT）</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d8489e92-ce93-46ac-9aab-289ce19bb67d"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/ea13d73c-76a4-4e0c-a35b-0c648f898311" height="320"></td>
  </tr>
</table>

_近日公開予定..._

<br>

#### プロンプト最適化

研究駆動型の最適化手法を使ってプログラムからプロンプトを最適化できます。

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b><a href="https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#best-of-n-sampling">MIPROv2</a></b></td>
    <td width="50%" align="center" valign="middle"><b><a href="https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy">DSPy連携</a></b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/d81a7c37-382f-4c46-840f-e6c2593301db" alt="MIPROv2 diagram"></td>
    <td width="50%" align="center" valign="middle">
      TensorZeroには複数の最適化レシピが付属していますが、独自のレシピも簡単に作成できます。
      この例は、TensorZero関数を任意のツール（ここでは自動プロンプトエンジニアリング用の人気ライブラリDSPy）で最適化する方法を示しています。
    </td>
  </tr>
</table>

_近日公開予定..._

<br>

### 🔍 LLM可観測性

> **個々のAPIコールをデバッグするためにズームインしたり、モデルやプロンプト全体のメトリクスを時系列で監視するためにズームアウトできます（すべてオープンソースのTensorZero UIで実現）。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>可観測性 » 推論</b></td>
    <td width="50%" align="center" valign="middle"><b>可観測性 » 関数</b></td>
  </tr>
  <tr>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/2cc3cc9a-f33f-4e94-b8de-07522326f80a"></td>
    <td width="50%" align="center" valign="middle"><img src="https://github.com/user-attachments/assets/00ae6605-8fa0-4efd-8238-ae8ea589860f"></td>
  </tr>
</table>

<br>

### 📊 LLM評価

> **TensorZero Evaluationsで、プロンプト・モデル・推論戦略を比較できます。ヒューリスティックやLLMジャッジに対応。**

<table>
  <tr></tr> <!-- flip highlight order -->
  <tr>
    <td width="50%" align="center" valign="middle"><b>評価 » UI</b></td>
    <td width="50%" align="center" valign="middle"><b>評価 » CLI</b></td>
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
```
semantic_match: 0.98 ± 0.01  
item_count: 7.15 ± 0.39</code></pre>
    </td>
  </tr>
</table>

## デモ

> **TensorZeroで、LLMがリアルタイムでデータ抽出性能を向上させる様子を体験しよう！**
>
> **[Dynamic in-context learning (DICL)](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations#dynamic-in-context-learning-dicl)** は、TensorZeroに標準搭載された強力な推論時最適化機能です。
> モデルのファインチューニングなしで、関連する過去の事例を自動でプロンプトに組み込むことで、LLMの性能を向上させます。

https://github.com/user-attachments/assets/4df1022e-886e-48c2-8f79-6af3cdad79cb

## TensorZeroによるLLMエンジニアリング

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

1. **[TensorZero Gateway](https://www.tensorzero.com/docs/gateway/)** はRust 🦀 製の高性能モデルゲートウェイであり、主要なLLMプロバイダーすべてに対して統一APIインターフェースを提供し、シームレスなクロスプラットフォーム統合やフェイルオーバーが可能です。
2. 構造化スキーマベース推論を&lt;1msのP99レイテンシーオーバーヘッド（**[ベンチマーク](https://www.tensorzero.com/docs/gateway/benchmarks)** 参照）で処理し、可観測性・実験・**[推論時最適化](https://www.tensorzero.com/docs/gateway/guides/inference-time-optimizations)** を標準搭載しています。
3. これら推論に付随するダウンストリームのメトリクスやフィードバックも収集し、マルチステップLLMシステムを一級でサポートします。
4. すべては開発者フレンドリーかつスケーラブルなリアルタイム分析を可能にする、ユーザー管理のClickHouseデータウェアハウスに保存されます。
5. 時間経過とともに、**[TensorZero Recipes](https://www.tensorzero.com/docs/recipes)** がこの構造化データセットを活用し、プロンプトやモデルを最適化します：ファインチューニングなど一般的なワークフロー向けのレシピを実行したり、任意の言語やプラットフォームで独自のレシピ・ワークフローも柔軟に作成できます。
6. 最後に、ゲートウェイの実験機能やGitOpsオーケストレーションにより、単一LLMから数千のLLMまで自信を持って反復・デプロイできます。

私たちの目標は、エンジニアが次世代のLLMアプリケーション ― 実世界から学習するシステム ― の構築・管理・最適化を支援することです。  
詳細は **[ビジョン＆ロードマップ](https://www.tensorzero.com/docs/vision-roadmap/)** をご覧ください。

## はじめよう

**今日から構築を始めましょう。**  
**[クイックスタート](https://www.tensorzero.com/docs/quickstart)** では、TensorZeroを使ったLLMアプリケーションのセットアップがいかに簡単かを紹介しています。  
さらに深く学びたい方は、**[チュートリアル](https://www.tensorzero.com/docs/gateway/tutorial)** で、チャットボット・メールコパイロット・天気RAGシステム・構造化データ抽出パイプラインの作り方を解説しています。

**質問はありますか？**  
**[Slack](https://www.tensorzero.com/slack)** または **[Discord](https://www.tensorzero.com/discord)** でお尋ねください。

**TensorZeroを職場で利用していますか？**  
**[hello@tensorzero.com](mailto:hello@tensorzero.com)** までご連絡いただければ、無料でチーム用のSlackやTeamsチャンネルを設定します。

**一緒に働きませんか。**  
私たちは **[NYCで採用中](https://www.tensorzero.com/jobs)** です。  
**[オープンソースへの貢献](https://github.com/tensorzero/tensorzero/blob/main/CONTRIBUTING.md)** も大歓迎です！

## サンプル

TensorZeroのデータ＆学習フライホイールを例示する**完全実行可能なサンプル**を順次公開しています。

> **[TensorZeroによるデータ抽出（NER）の最適化](https://github.com/tensorzero/tensorzero/tree/main/examples/data-extraction-ner)**
>
> この例では、TensorZeroを用いたデータ抽出パイプラインの最適化方法を紹介します。
> ファインチューニングやDynamic in-context learning（DICL）などの手法をデモします。
> 最終的に、最適化されたGPT-4o Miniモデルが、このタスクでGPT-4oを上回ります ― コストもレイテンシも大幅に削減し、少量のトレーニングデータのみで達成しています。

> **[Agentic RAG ― LLMによるマルチホップ質問応答](https://github.com/tensorzero/tensorzero/tree/main/examples/rag-retrieval-augmented-generation/simple-agentic-rag/)**
>
> この例では、TensorZeroを用いてマルチホップリトリーバルエージェントを構築する方法を示します。
> エージェントはWikipediaを反復的に検索して情報を収集し、十分なコンテキストが揃った時点で複雑な質問に回答します。

> **[隠れた好みを持つ審査員を満足させる俳句生成](https://github.com/tensorzero/tensorzero/tree/main/examples/haiku-hidden-preferences)**
>
> この例では、特定の嗜好に合わせた俳句を生成するようGPT-4o Miniをファインチューニングします。
> TensorZeroの「データフライホイール・イン・ボックス」が実際に機能する様子が見られます：より良いバリアントはより良いデータを生み、より良いデータはさらに良いバリアントを生み出します。
> LLMを複数回ファインチューニングして進捗を確認できます。

> **[Best-of-NサンプリングによるLLMチェス能力の向上](https://github.com/tensorzero/tensorzero/tree/main/examples/chess-puzzles/)**
>
> この例では、Best-of-Nサンプリングで複数の候補手から最も有望な手を選択することで、LLMのチェス能力を大幅に向上できることを示します。

> **[自動プロンプトエンジニアリング（DSPy）によるカスタムレシピで数学的推論を向上](https://github.com/tensorzero/tensorzero/tree/main/examples/gsm8k-custom-recipe-dspy)**
>
> TensorZeroは、一般的なLLMエンジニアリングワークフロー向けに多数の最適化レシピをあらかじめ用意しています。
> もちろん、独自のレシピやワークフローも簡単に作成可能です！
> この例では、任意のツール（ここではDSPy）を使ってTensorZero関数を最適化する方法を紹介します。

_他にも多数のサンプルを公開予定です！_

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---