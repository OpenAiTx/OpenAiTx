![cover-v5-optimized](./images/GitHub_README_if.png)

<p align="center">
  📌 <a href="https://dify.ai/blog/introducing-dify-workflow-file-upload-a-demo-on-ai-podcast">Difyワークフローファイルアップロードのご紹介：Google NotebookLM Podcastの再現</a>
</p>

<p align="center">
  <a href="https://cloud.dify.ai">Dify Cloud</a> ·
  <a href="https://docs.dify.ai/getting-started/install-self-hosted">セルフホスティング</a> ·
  <a href="https://docs.dify.ai">ドキュメント</a> ·
  <a href="https://dify.ai/pricing">Difyエディションの概要</a>
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

DifyはオープンソースのLLMアプリ開発プラットフォームです。直感的なインターフェースで、エージェントAIワークフロー、RAGパイプライン、エージェント機能、モデル管理、可観測性機能などを統合し、プロトタイプから本番まで迅速に移行できます。

## クイックスタート

> Difyをインストールする前に、マシンが以下の最低システム要件を満たしていることを確認してください:
>
> - CPU >= 2コア
> - RAM >= 4 GiB

</br>

Difyサーバーを始める最も簡単な方法は、[docker compose](docker/docker-compose.yaml)を使うことです。以下のコマンドでDifyを実行する前に、[Docker](https://docs.docker.com/get-docker/)と[Docker Compose](https://docs.docker.com/compose/install/)がインストールされていることを確認してください。

```bash
cd dify
cd docker
cp .env.example .env
docker compose up -d
```

実行後、ブラウザで [http://localhost/install](http://localhost/install) にアクセスし、初期化プロセスを開始できます。

#### サポートが必要な場合

Difyのセットアップで問題が発生した場合は、[FAQ](https://docs.dify.ai/getting-started/install-self-hosted/faqs) をご参照ください。それでも解決しない場合は、[コミュニティや私たち](#community--contact)にご連絡ください。

> Difyへの貢献や追加開発を希望される場合は、[ソースコードからのデプロイガイド](https://docs.dify.ai/getting-started/install-self-hosted/local-source-code) をご覧ください。

## 主な特徴

**1. ワークフロー**:  
ビジュアルキャンバス上で強力なAIワークフローを構築・テスト可能。下記の全機能を含みます。

**2. 幅広いモデル対応**:  
多数の推論プロバイダーやセルフホスト型ソリューションから、数百の独自・オープンソースLLMとシームレスに統合。GPT、Mistral、Llama3、OpenAI API互換モデルなどをカバー。対応モデルプロバイダー一覧は[こちら](https://docs.dify.ai/getting-started/readme/model-providers)。

![providers-v5](https://github.com/langgenius/dify/assets/13230914/5a17bdbe-097a-4100-8363-40255b70f6e3)

**3. プロンプトIDE**:  
プロンプト作成、モデル性能比較、テキスト読み上げなど機能追加も直感的に行えるインターフェース。

**4. RAGパイプライン**:  
ドキュメント取り込みから検索までをカバーする強力なRAG機能。PDF、PPTなど主要ドキュメント形式のテキスト抽出にも対応。

**5. エージェント機能**:  
LLM関数呼び出しやReActベースのエージェントを定義可能。Google検索、DALL·E、Stable Diffusion、WolframAlphaなど50種類以上のビルトインツールを提供し、カスタムツール追加も可能。

**6. LLMOps**:  
アプリのログやパフォーマンスを継続的に監視・分析。運用データやアノテーションに基づき、プロンプト・データセット・モデルを改善。

**7. バックエンド・アズ・ア・サービス**:  
Difyの全機能に対応するAPIを提供。自社業務ロジックへの統合も容易です。

## 機能比較

<table style="width: 100%;">
  <tr>
    <th align="center">機能</th>
    <th align="center">Dify.AI</th>
    <th align="center">LangChain</th>
    <th align="center">Flowise</th>
    <th align="center">OpenAI Assistants API</th>
  </tr>
  <tr>
    <td align="center">プログラミング手法</td>
    <td align="center">API + アプリ指向</td>
    <td align="center">Pythonコード</td>
    <td align="center">アプリ指向</td>
    <td align="center">API指向</td>
  </tr>
  <tr>
    <td align="center">対応LLM</td>
    <td align="center">多種多様</td>
    <td align="center">多種多様</td>
    <td align="center">多種多様</td>
    <td align="center">OpenAIのみ</td>
  </tr>
  <tr>
    <td align="center">RAGエンジン</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">エージェント</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
  </tr>
  <tr>
    <td align="center">ワークフロー</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">可観測性</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">エンタープライズ機能（SSO/アクセス制御）</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
    <td align="center">❌</td>
  </tr>
  <tr>
    <td align="center">ローカルデプロイ</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">✅</td>
    <td align="center">❌</td>
  </tr>
</table>

## Difyの利用方法

- **クラウド </br>**  
  [Dify Cloud](https://dify.ai) サービスを提供しており、どなたでもセットアップ不要ですぐに試せます。セルフデプロイ版と同等の機能を持ち、サンドボックスプランではGPT-4を200回まで無料で利用可能です。

- **セルフホスティング Dify コミュニティエディション</br>**  
  [スターターガイド](#quick-start)で素早く環境構築が可能です。詳細な手順やリファレンスは[ドキュメント](https://docs.dify.ai)をご参照ください。

- **エンタープライズ／組織向け Dify</br>**  
  エンタープライズ向けの機能も提供しています。[こちらのチャットボット](https://udify.app/chat/22L1zSxg6yW1cWQg) または [メール](mailto:business@dify.ai?subject=[GitHub]Business%20License%20Inquiry) でご相談ください。</br>
  > AWSを利用するスタートアップや中小企業の方は、[AWS MarketplaceのDify Premium](https://aws.amazon.com/marketplace/pp/prodview-t22mebxzwjhu6) もご検討ください。ワンクリックで自社AWS VPCにデプロイ可能で、カスタムロゴ・ブランディングにも対応した低価格AMIプランです。

## 最新情報を入手

GitHubでDifyにスターを付けて、新しいリリースの通知を受け取りましょう。

![star-us](https://github.com/langgenius/dify/assets/13230914/b823edc1-6388-4e25-ad45-2f6b187adbb4)

## 詳細なセットアップ

設定をカスタマイズする場合は、[.env.example](docker/.env.example) ファイル内のコメントを参照し、ご自身の `.env` ファイルの値を更新してください。さらに、デプロイ環境や要件に応じて `docker-compose.yaml` のイメージバージョン、ポートマッピング、ボリュームマウントの変更が必要な場合もあります。変更後は `docker-compose up -d` を再実行してください。利用可能な環境変数の一覧は[こちら](https://docs.dify.ai/getting-started/install-self-hosted/environments)です。

高可用性構成が必要な場合は、コミュニティ提供の [Helm Chart](https://helm.sh/) やYAMLファイルを利用してKubernetes上にデプロイできます。

- [@LeoQuoteによるHelm Chart](https://github.com/douban/charts/tree/master/charts/dify)
- [@BorisPolonskyによるHelm Chart](https://github.com/BorisPolonsky/dify-helm)
- [@magicsongによるHelm Chart](https://github.com/magicsong/ai-charts)
- [@Winson-030によるYAMLファイル](https://github.com/Winson-030/dify-kubernetes)
- [@wyy-holdingによるYAMLファイル](https://github.com/wyy-holding/dify-k8s)

#### Terraformによるデプロイ

[terraform](https://www.terraform.io/) を使ってワンクリックでクラウドプラットフォームにDifyをデプロイ可能です。

##### Azure Global

- [@nikawangによるAzure Terraform](https://github.com/nikawang/dify-azure-terraform)

##### Google Cloud

- [@sotazumによるGoogle Cloud Terraform](https://github.com/DeNA/dify-google-cloud-terraform)

#### AWS CDKによるデプロイ

[CDK](https://aws.amazon.com/cdk/) を使ってAWSにDifyをデプロイ。

##### AWS

- [@KevinZhaoによるAWS CDK](https://github.com/aws-samples/solution-for-deploying-dify-on-aws)

## コントリビューション

コードへの貢献をご希望の場合は、[コントリビューションガイド](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)をご参照ください。
また、SNSやイベント、カンファレンスでDifyをご紹介いただくこともサポートになります。

> 中国語・英語以外の言語への翻訳協力者を募集しています。ご興味のある方は[i18n README](https://github.com/langgenius/dify/blob/main/web/i18n/README.md) をご確認の上、[Discordコミュニティサーバー](https://discord.gg/8Tpq4AcN9c) の `global-users` チャンネルでご連絡ください。

## コミュニティ & お問い合わせ

- [GitHub Discussion](https://github.com/langgenius/dify/discussions) — フィードバック共有や質問に最適です。
- [GitHub Issues](https://github.com/langgenius/dify/issues) — Dify.AIで発生したバグや機能提案はこちら。[コントリビューションガイド](https://github.com/langgenius/dify/blob/main/CONTRIBUTING.md)も参照ください。
- [Discord](https://discord.gg/FngNHpbcY7) — アプリケーションの共有やコミュニティでの交流に最適です。
- [X(Twitter)](https://twitter.com/dify_ai) — アプリの共有やコミュニティ交流にご利用ください。

**コントリビューター**

<a href="https://github.com/langgenius/dify/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=langgenius/dify" />
</a>

## スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=langgenius/dify&type=Date)](https://star-history.com/#langgenius/dify&Date)

## セキュリティ情報の開示について

プライバシー保護のため、セキュリティ問題はGitHubに投稿せず、security@dify.ai までご連絡ください。詳細な回答をお送りします。

## ライセンス

本リポジトリは[ Dify Open Source License ](LICENSE)の下で提供されています（Apache 2.0にいくつかの追加制限を加えたものです）。

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---