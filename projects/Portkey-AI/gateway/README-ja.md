<p align="right">
   <strong>English</strong> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.cn.md">中文</a> | <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/.github/README.jp.md">日本語</a>
</p>

<div align="center">

<a href="https://portkey.sh/report-github"><img src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Frame.png"></img></a>
<br>

# AI Gateway
#### 1つの高速かつフレンドリーなAPIで250以上のLLMへルーティング

<img src="https://cfassets.portkey.ai/sdk.gif" width="550px" alt="Portkey AI Gateway Demo showing LLM routing capabilities" style="margin-left:-35px">

[ドキュメント](https://portkey.wiki/gh-1) | [エンタープライズ](https://portkey.wiki/gh-2) | [ホステッドゲートウェイ](https://portkey.wiki/gh-3) | [変更履歴](https://portkey.wiki/gh-4) | [APIリファレンス](https://portkey.wiki/gh-5)


[![ライセンス](https://img.shields.io/github/license/Ileriayo/markdown-badges)](https://raw.githubusercontent.com/Portkey-AI/gateway/main/LICENSE)
[![Discord](https://img.shields.io/discord/1143393887742861333)](https://portkey.wiki/gh-6)
[![Twitter](https://img.shields.io/twitter/url/https/twitter/follow/portkeyai?style=social&label=Follow%20%40PortkeyAI)](https://portkey.wiki/gh-7)
[![npmバージョン](https://badge.fury.io/js/%40portkey-ai%2Fgateway.svg)](https://portkey.wiki/gh-8)
[![Better Stack Badge](https://uptime.betterstack.com/status-badges/v1/monitor/q94g.svg)](https://portkey.wiki/gh-9)

<a href="https://us-east-1.console.aws.amazon.com/cloudformation/home?region=us-east-1#/stacks/quickcreate?stackName=portkey-gateway&templateURL=https://portkey-gateway-ec2-quicklaunch.s3.us-east-1.amazonaws.com/portkey-gateway-ec2-quicklaunch.template.yaml"><img src="https://img.shields.io/badge/Deploy_to_EC2-232F3E?style=for-the-badge&logo=amazonwebservices&logoColor=white" alt="Deploy to AWS EC2" width="105"/></a> [![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/Portkey-AI/gateway)
</div>

<br/>

[**AI Gateway**](https://portkey.wiki/gh-10) は、高速・信頼性・セキュリティを兼ね備えた1600以上の言語、ビジョン、音声、画像モデルへのルーティングを実現します。軽量でオープンソース、エンタープライズ対応のソリューションで、2分以内にあらゆる言語モデルと統合できます。

- [x] **圧倒的な高速性**（<1msレイテンシ）、超軽量（122kb）
- [x] **実戦で検証済み**、毎日100億トークン以上を処理
- [x] **エンタープライズ対応**、強化されたセキュリティ・スケール・カスタムデプロイに対応

<br>

#### AI Gatewayでできること
- 2分以内に任意のLLMと統合 - [クイックスタート](#quickstart-2-mins)
- **[自動リトライ](https://portkey.wiki/gh-11)**や**[フォールバック](https://portkey.wiki/gh-12)**でダウンタイムを防止
- **[ロードバランシング](https://portkey.wiki/gh-13)**や**[条件付きルーティング](https://portkey.wiki/gh-14)**でAIアプリをスケール
- **[ガードレール](https://portkey.wiki/gh-15)**でAIデプロイを保護
- **[マルチモーダル対応](https://portkey.wiki/gh-16)**でテキスト以外も扱える
- **[エージェントワークフロー](https://portkey.wiki/gh-17)**の統合も可能

<br><br>

> [!TIP]
> このリポジトリにスターを付けていただくと、より多くの開発者がAI Gatewayを発見できます 🙏🏻
>
> ![star-2](https://github.com/user-attachments/assets/53597dce-6333-4ecc-a154-eb05532954e4)
> 
<br>


<br>

## クイックスタート（2分）

### 1. AI Gatewayのセットアップ

```bash
# ゲートウェイをローカルで実行（Node.jsとnpmが必要です）
npx @portkey-ai/gateway
```
> ゲートウェイは `http://localhost:8787/v1` で稼働します
> 
> ゲートウェイコンソールは `http://localhost:8787/public/` で利用できます

<sup>
デプロイガイド:
&nbsp; <a href="https://portkey.wiki/gh-18"><img height="12" width="12" src="https://cfassets.portkey.ai/logo/dew-color.svg" /> Portkey Cloud（推奨）</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#docker"><img height="12" width="12" src="https://cdn.simpleicons.org/docker/3776AB" /> Docker</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#nodejs-server"><img height="12" width="12" src="https://cdn.simpleicons.org/node.js/3776AB" /> Node.js</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#cloudflare-workers"><img height="12" width="12" src="https://cdn.simpleicons.org/cloudflare/3776AB" /> Cloudflare</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md#replit"><img height="12" width="12" src="https://cdn.simpleicons.org/replit/3776AB" /> Replit</a>
&nbsp; <a href="https://raw.githubusercontent.com/Portkey-AI/gateway/main/docs/installation-deployments.md"> その他...</a>

</sup>

### 2. 最初のリクエストを送信

<!-- <details open>
<summary>Python Example</summary> -->
```python
# pip install -qU portkey-ai

from portkey_ai import Portkey

# OpenAI互換クライアント
client = Portkey(
    provider="openai", # または 'anthropic', 'bedrock', 'groq', など
    Authorization="sk-***" # プロバイダーのAPIキー
)

# AI Gatewayを通じてリクエストを送信
client.chat.completions.create(
    messages=[{"role": "user", "content": "What's the weather like?"}],
    model="gpt-4o-mini"
)
```



<sup>対応ライブラリ:
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/javascript/3776AB" /> JS](https://portkey.wiki/gh-19)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/python/3776AB" /> Python](https://portkey.wiki/gh-20)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/gnubash/3776AB" /> REST](https://portkey.sh/gh-84)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/openai/3776AB" /> OpenAI SDKs](https://portkey.wiki/gh-21)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/langchain/3776AB" /> Langchain](https://portkey.wiki/gh-22)
&nbsp; [LlamaIndex](https://portkey.wiki/gh-23)
&nbsp; [Autogen](https://portkey.wiki/gh-24)
&nbsp; [CrewAI](https://portkey.wiki/gh-25)
&nbsp; [その他..](https://portkey.wiki/gh-26)
</sup>

Gatewayコンソール（`http://localhost:8787/public/`）で、すべてのローカルログを一元的に確認できます。

<img src="https://github.com/user-attachments/assets/362bc916-0fc9-43f1-a39e-4bd71aac4a3a" width="400" />


### 3. ルーティング & ガードレール
LLMゲートウェイの`Configs`を使ってルーティングルールを作成し、信頼性やガードレールを追加できます。
```python
config = {
  "retry": {"attempts": 5},

  "output_guardrails": [{
    "default.contains": {"operator": "none", "words": ["Apple"]},
    "deny": True
  }]
}

# クライアントにコンフィグをアタッチ
client = client.with_options(config=config)

client.chat.completions.create(
    model="gpt-4o-mini",
    messages=[{"role": "user", "content": "Reply randomly with Apple or Bat"}]
)

# この設定では、ガードレールにより"Apple"を含む返信がすべて拒否されるため、常に"Bat"で応答します。リトライ設定により、最大5回までリトライします。
```
<div align="center">
<img src="https://portkey.ai/blog/content/images/size/w1600/2024/11/image-15.png" width=600 title="Request flow through Portkey's AI gateway with retries and guardrails" alt="Request flow through Portkey's AI gateway with retries and guardrails"/>
</div>

AI Gatewayのコンフィグでさらに多くのことが可能です。[サンプルはこちら →](https://portkey.wiki/gh-27)

<br/>

### エンタープライズ版（プライベートデプロイ）

<sup>

[<img height="12" width="12" src="https://cfassets.portkey.ai/amazon-logo.svg" /> AWS](https://portkey.wiki/gh-28)
&nbsp; [<img height="12" width="12" src="https://cfassets.portkey.ai/azure-logo.svg" /> Azure](https://portkey.wiki/gh-29)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/googlecloud/3776AB" /> GCP](https://portkey.wiki/gh-30)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/redhatopenshift/3776AB" /> OpenShift](https://portkey.wiki/gh-31)
&nbsp; [<img height="12" width="12" src="https://cdn.simpleicons.org/kubernetes/3776AB" /> Kubernetes](https://portkey.wiki/gh-85)

</sup>

LLM Gatewayの[エンタープライズ版](https://portkey.wiki/gh-86)は、**組織管理**、**ガバナンス**、**セキュリティ**など高度な機能を標準搭載しています。[機能比較を見る →](https://portkey.wiki/gh-32)

各プラットフォーム向けのエンタープライズデプロイ構成はこちら - [**エンタープライズプライベートクラウドデプロイ**](https://portkey.wiki/gh-33)

<a href="https://portkey.sh/demo-13"><img src="https://portkey.ai/blog/content/images/2024/08/Get-API-Key--5-.png" height=50 alt="Book an enterprise AI gateway demo" /></a><br/>


<br>

<hr>

### AIエンジニアリングアワー

毎週金曜日（午前8時PT）にコミュニティコールを開催し、AI Gateway導入をサポートします！ [毎週金曜開催](https://portkey.wiki/gh-35)

<a href="https://portkey.wiki/gh-35"><img width="500" src="https://github.com/user-attachments/assets/c2885699-f197-4289-b819-21eb839fbae1" /></a>

議事録は[こちらで公開](https://portkey.wiki/gh-36)しています。


<hr>

### LLMs in Prod'25

2兆トークン以上・90地域・650チーム超のプロダクション運用から得た知見。レポートで得られる内容：
- AI導入とLLMプロバイダー成長の潮流
- スピード・コスト・信頼性最適化のベンチマーク
- 本番AIシステムをスケールするための戦略

<a href="https://portkey.sh/report-github"><img width="500" src="https://raw.githubusercontent.com/siddharthsambharia-portkey/Portkey-Product-Images/refs/heads/main/LLM%20Report%20Campaign%20Image.png" /></a>

<a href="https://portkey.sh/report-github">**レポートを入手する**</a>
<hr>


## 主な機能
### 信頼性の高いルーティング
- <a href="https://portkey.wiki/gh-37">**フォールバック**</a>：LLMゲートウェイを使用してリクエストが失敗した際に、別のプロバイダーやモデルにフォールバックします。フォールバックをトリガーするエラーを指定できます。アプリケーションの信頼性が向上します。
- <a href="https://portkey.wiki/gh-38">**自動リトライ**</a>：失敗したリクエストを最大5回まで自動でリトライします。指数バックオフ戦略により、リトライ試行の間隔を調整し、ネットワークの過負荷を防ぎます。
- <a href="https://portkey.wiki/gh-39">**ロードバランシング**</a>：複数のAPIキーまたはAIプロバイダーにLLMリクエストを重み付けで分散し、高可用性と最適なパフォーマンスを確保します。
- <a href="https://portkey.wiki/gh-40">**リクエストタイムアウト**</a>：詳細なリクエストタイムアウトを設定することで、制御しづらいLLMやレイテンシーを管理し、指定した時間を超過したリクエストを自動で終了させます。
- <a href="https://portkey.wiki/gh-41">**マルチモーダルLLMゲートウェイ**</a>：OpenAIと同じシグネチャで、複数プロバイダーからビジョン、音声（テキスト読み上げ＆音声認識）、画像生成モデルを呼び出せます。
- <a href="https://portkey.wiki/gh-42">**リアルタイムAPI**</a>：OpenAIが提供するリアルタイムAPIを統合WebSocketサーバー経由で呼び出せます。

### セキュリティ & 精度
- <a href="https://portkey.wiki/gh-88">**ガードレール**</a>：LLMの入力および出力が指定したチェックに準拠しているか検証します。40以上の事前構築済みガードレールから選択でき、セキュリティおよび精度基準への準拠を確保します。<a href="https://portkey.wiki/gh-43">独自のガードレールを持ち込む</a>ことも、<a href="https://portkey.wiki/gh-44">多くのパートナー</a>から選ぶこともできます。
- [**セキュアなキー管理**](https://portkey.wiki/gh-45)：独自のキーの利用や、オンザフライで仮想キーを生成できます。
- [**ロールベースのアクセス制御**](https://portkey.wiki/gh-46)：ユーザー、ワークスペース、APIキーごとに詳細なアクセス制御が可能です。
- <a href="https://portkey.wiki/gh-47">**コンプライアンス＆データプライバシー**</a>：AIゲートウェイはSOC2、HIPAA、GDPR、CCPAに準拠しています。

### コスト管理
- [**スマートキャッシュ**](https://portkey.wiki/gh-48)：LLMからのレスポンスをキャッシュし、コスト削減とレイテンシー向上を実現。シンプルキャッシュとセマンティック*キャッシュの両方に対応。
- [**利用分析**](https://portkey.wiki/gh-49)：リクエスト量、レイテンシー、コスト、エラー率など、AIやLLMの利用状況を監視・分析できます。
- [**プロバイダー最適化***](https://portkey.wiki/gh-89)：利用パターンや価格モデルに基づき、最もコスト効率の良いプロバイダーへ自動で切り替えます。

### コラボレーション & ワークフロー
- <a href="https://portkey.ai/docs/integrations/agents">**エージェント対応**</a>：人気のエージェントフレームワークとシームレスに統合し、複雑なAIアプリケーションを構築できます。ゲートウェイは[Autogen](https://portkey.wiki/gh-50)、[CrewAI](https://portkey.wiki/gh-51)、[LangChain](https://portkey.wiki/gh-52)、[LlamaIndex](https://portkey.wiki/gh-53)、[Phidata](https://portkey.wiki/gh-54)、[Control Flow](https://portkey.wiki/gh-55)、さらには[カスタムエージェント](https://portkey.wiki/gh-56)ともシームレスに統合します。
- [**プロンプトテンプレート管理***](https://portkey.wiki/gh-57)：ユニバーサルなプロンプトプレイグラウンドで、プロンプトテンプレートの作成、管理、バージョン管理を共同で行えます。
<br/><br/>

<sup>
*&nbsp;ホスト版およびエンタープライズ版で利用可能
</sup>

<br>

## クックブック

### ☄️ トレンド
- [Nvidia NIM](/cookbook/providers/nvidia.ipynb)のモデルをAI Gatewayで利用
- [CrewAIエージェント](/cookbook/monitoring-agents/CrewAI_with_Telemetry.ipynb)をPortkeyで監視！
- AI Gatewayで[トップ10 LMSYSモデル](/cookbook/use-cases/LMSYS%20Series/comparing-top10-LMSYS-models-with-Portkey.ipynb)を比較

### 🚨 最新
* [Nemotronを使った合成データセット作成](/cookbook/use-cases/Nemotron_GPT_Finetuning_Portkey.ipynb)
* [VercelのAI SDKでLLM Gatewayを利用](/cookbook/integrations/vercel-ai.md)
* [PortkeyのLLM GatewayでLlamaエージェントを監視](/cookbook/monitoring-agents/Llama_Agents_with_Telemetry.ipynb)

[すべてのクックブックを見る →](https://portkey.wiki/gh-58)
<br/><br/>

## サポートプロバイダー

[45以上のプロバイダー](https://portkey.wiki/gh-59)および[8以上のエージェントフレームワーク](https://portkey.wiki/gh-90)とのGateway統合をご覧ください。

|                                                                                                                            | プロバイダー                                                                                      | サポート | ストリーム |
| -------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | ------- | ------ |
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


> [サポートされている200以上のモデルの完全リストはこちら](https://portkey.wiki/gh-74)
<br>

<br>

## エージェント
Gatewayは人気のエージェントフレームワークとシームレスに統合します。[ドキュメントはこちら](https://portkey.wiki/gh-75)。


| フレームワーク | 200以上のLLM呼び出し | 高度なルーティング | キャッシュ | ロギング＆トレーシング* | 可観測性* | プロンプト管理* |
|------------------------------|--------|-------------|---------|------|---------------|-------------------|
| [Autogen](https://portkey.wiki/gh-93)    | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [CrewAI](https://portkey.wiki/gh-94)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [LangChain](https://portkey.wiki/gh-95)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Phidata](https://portkey.wiki/gh-96)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Llama Index](https://portkey.wiki/gh-97)             | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [Control Flow](https://portkey.wiki/gh-98) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |
| [独自エージェントの構築](https://portkey.wiki/gh-99) | ✅     | ✅          | ✅      | ✅   | ✅            | ✅                |

<br>

* [ホストアプリ](https://portkey.wiki/gh-76)で利用可能。詳細なドキュメントは[こちら](https://portkey.wiki/gh-100)。


## Gateway エンタープライズ版
AIアプリを<ins>より信頼性高く</ins>、<ins>将来互換性</ins>のあるものにし、<ins>完全なデータセキュリティ</ins>と<ins>プライバシー</ins>を確保します。

✅&nbsp; セキュアなキー管理 - ロールベースのアクセス制御とトラッキング用 <br>
✅&nbsp; シンプル＆セマンティックキャッシュ - 繰り返しの問い合わせを高速化・コスト削減 <br>
✅&nbsp; アクセス制御＆インバウンドルール - 接続可能なIPや地域を制御 <br>
✅&nbsp; PII自動マスキング - リクエストから機密データを自動で除去し、意図しない漏洩を防止 <br>
✅&nbsp; SOC2、ISO、HIPAA、GDPR準拠 - 最高のセキュリティプラクティス <br>
✅&nbsp; プロフェッショナルサポート - 機能の優先対応も含む <br>

[エンタープライズ導入のご相談はこちら](https://portkey.sh/demo-13)

<br>


## コントリビューション（貢献）

最も簡単な貢献方法は、`good first issue`タグのついたIssueを選ぶことです💪。貢献ガイドラインは[こちら](/.github/CONTRIBUTING.md)。

バグ報告は？[こちら](https://portkey.wiki/gh-78) | 機能要望は？[こちら](https://portkey.wiki/gh-78)


### コミュニティで始める
毎週金曜日（午前8時PT）に開催されるAIエンジニアリングアワーにご参加ください：
- 他の貢献者やコミュニティメンバーと交流
- Gatewayの高度な機能や実装パターンを学ぶ
- 経験を共有しサポートを受ける
- 最新の開発優先事項をキャッチアップ

[次回セッションに参加 →](https://portkey.wiki/gh-101) | [ミーティングノート](https://portkey.wiki/gh-102)

<br>

## コミュニティ

世界中で拡大するコミュニティに参加し、AIに関するヘルプ・アイデア・議論をどうぞ。

- 公式[ブログ](https://portkey.wiki/gh-78)を見る
- [Discord](https://portkey.wiki/community)でチャット
- [Twitter](https://portkey.wiki/gh-79)をフォロー
- [LinkedIn](https://portkey.wiki/gh-80)でつながる
- [日本語ドキュメント](./.github/README.jp.md)を読む
- [YouTube](https://portkey.wiki/gh-103)を見る
- [開発者コミュニティ](https://portkey.wiki/gh-82)に参加
<!-- - 質問は[Stack Overflowの #portkey タグ](https://stackoverflow.com/questions/tagged/portkey) もご利用ください -->

![Rubeus Social Share (4)](https://github.com/Portkey-AI/gateway/assets/971978/89d6f0af-a95d-4402-b451-14764c40d03f)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---