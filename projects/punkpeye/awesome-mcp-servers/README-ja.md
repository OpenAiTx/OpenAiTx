# Awesome MCP Servers [![Awesome](https://awesome.re/badge.svg)](https://awesome.re)

[![ไทย](https://img.shields.io/badge/Thai-Click-blue)](README-th.md)
[![English](https://img.shields.io/badge/English-Click-yellow)](README.md)
[![繁體中文](https://img.shields.io/badge/繁體中文-點擊查看-orange)](README-zh_TW.md)
[![简体中文](https://img.shields.io/badge/简体中文-点击查看-orange)](README-zh.md)
[![日本語](https://img.shields.io/badge/日本語-クリック-青)](README-ja.md)
[![한국어](https://img.shields.io/badge/한국어-클릭-yellow)](README-ko.md)
[![Português Brasileiro](https://img.shields.io/badge/Português_Brasileiro-Clique-green)](README-pt_BR.md)
[![Discord](https://img.shields.io/discord/1312302100125843476?logo=discord&label=discord)](https://glama.ai/mcp/discord)
[![Subreddit subscribers](https://img.shields.io/reddit/subreddit-subscribers/mcp?style=flat&logo=reddit&label=subreddit)](https://www.reddit.com/r/mcp/)

厳選された素晴らしいModel Context Protocol（MCP）サーバーのリストです。

* [MCPとは？](#what-is-mcp)
* [クライアント](#clients)
* [チュートリアル](#tutorials)
* [コミュニティ](#community)
* [凡例](#legend)
* [サーバー実装](#server-implementations)
* [フレームワーク](#frameworks)
* [Tips & Tricks](#tips-and-tricks)

## MCPとは？

[MCP](https://modelcontextprotocol.io/)は、AIモデルが標準化されたサーバー実装を通じて、ローカルおよびリモートリソースと安全にやりとりできるオープンプロトコルです。このリストでは、ファイルアクセス、データベース接続、API統合、その他のコンテキストサービスを通じてAIの能力を拡張する、実運用可能および実験的なMCPサーバーに焦点を当てています。

## クライアント

[awesome-mcp-clients](https://github.com/punkpeye/awesome-mcp-clients/) および [glama.ai/mcp/clients](https://glama.ai/mcp/clients) をご覧ください。

> [!TIP]
> [Glama Chat](https://glama.ai/chat) はMCP対応のマルチモーダルAIクライアントであり、[AIゲートウェイ](https://glama.ai/gateway)も提供しています。

## チュートリアル

* [Model Context Protocol (MCP) クイックスタート](https://glama.ai/blog/2024-11-25-model-context-protocol-quickstart)
* [ClaudeデスクトップアプリでSQLiteデータベースを利用する手順](https://youtu.be/wxCCzo9dGj0)

## コミュニティ

* [r/mcp Reddit](https://www.reddit.com/r/mcp)
* [Discordサーバー](https://glama.ai/mcp/discord)

## 凡例

* 🎖️ – 公式実装
* プログラミング言語
  * 🐍 – Pythonコードベース
  * 📇 – TypeScript（またはJavaScript）コードベース
  * 🏎️ – Goコードベース
  * 🦀 – Rustコードベース
  * #️⃣ - C#コードベース
  * ☕ - Javaコードベース
  * 🌊 – C/C++コードベース
* スコープ
  * ☁️ - クラウドサービス
  * 🏠 - ローカルサービス
  * 📟 - 組込みシステム
* オペレーティングシステム
  * 🍎 – macOS向け
  * 🪟 – Windows向け
  * 🐧 - Linux向け

> [!NOTE]
> ローカル🏠とクラウド☁️の違いが分かりませんか？
> * ローカルは、MCPサーバーがローカルにインストールされたソフトウェアと通信する場合（例：Chromeブラウザの制御）に使用します。
> * ネットワーク（クラウド）は、MCPサーバーがリモートAPIと通信する場合（例：天気API）に使用します。

## サーバー実装

> [!NOTE]
> このリポジトリと同期された[ウェブベースのディレクトリ](https://glama.ai/mcp/servers)も利用できます。

* 🔗 - [アグリゲーター](#aggregators)
* 🎨 - [アート＆カルチャー](#art-and-culture)
* 📂 - [ブラウザ自動化](#browser-automation)
* ☁️ - [クラウドプラットフォーム](#cloud-platforms)
* 👨‍💻 - [コード実行](#code-execution)
* 🤖 - [コーディングエージェント](#coding-agents)
* 🖥️ - [コマンドライン](#command-line)
* 💬 - [コミュニケーション](#communication)
* 👤 - [カスタマーデータプラットフォーム](#customer-data-platforms)
* 🗄️ - [データベース](#databases)
* 📊 - [データプラットフォーム](#data-platforms)
* 🚚 - [デリバリー](#delivery)
* 🛠️ - [開発者ツール](#developer-tools)
* 🧮 - [データサイエンスツール](#data-science-tools)
* 📟 - [組込みシステム](#embedded-system)
* 📂 - [ファイルシステム](#file-systems)
* 💰 - [金融・フィンテック](#finance--fintech)
* 🎮 - [ゲーム](#gaming)
* 🧠 - [ナレッジ＆メモリ](#knowledge--memory)
* 🗺️ - [位置情報サービス](#location-services)
* 🎯 - [マーケティング](#marketing)
* 📊 - [モニタリング](#monitoring)
* 🎥 - [マルチメディア処理](#multimedia-process)
* 🔎 - [検索＆データ抽出](#search)
* 🔒 - [セキュリティ](#security)
* 🌐 - [ソーシャルメディア](#social-media)
* 🏃 - [スポーツ](#sports)
* 🎧 - [サポート & サービス管理](#support-and-service-management)
* 🌎 - [翻訳サービス](#translation-services)
* 🎧 - [テキスト読み上げ](#text-to-speech)
* 🚆 - [旅行 & 交通](#travel-and-transportation)
* 🔄 - [バージョン管理](#version-control)
* 🛠️ - [その他ツールおよび統合](#other-tools-and-integrations)


### 🔗 <a name="aggregators"></a>アグリゲーター

複数のアプリやツールに単一のMCPサーバー経由でアクセスできるサーバー。

- [julien040/anyquery](https://github.com/julien040/anyquery) 🏎️ 🏠 ☁️ - 1つのバイナリで40以上のアプリをSQLでクエリ可能。PostgreSQL、MySQL、SQLite互換DBにも接続。ローカルファーストで設計的にプライベート。
- [metatool-ai/metatool-app](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCPはGUIでMCP接続を管理する統合ミドルウェアMCPサーバー。
- [mindsdb/mindsdb](https://github.com/mindsdb/mindsdb) - [MindsDBを単一MCPサーバーとして](https://docs.mindsdb.com/mcp/overview)、様々なプラットフォームやDB間のデータを接続・統合。
- [glenngillen/mcpmcp-server](https://github.com/glenngillen/mcpmcp-server) ☁️ 📇 🍎 🪟 🐧 - MCPサーバーのリスト。クライアントにどのサーバーが利用可能か確認し、日々のワークフローを向上。
- [wegotdocs/open-mcp](https://github.com/wegotdocs/open-mcp) 📇 🏠 🍎 🪟 🐧 - Web APIを10秒でMCPサーバー化し、OSSレジストリhttps://open-mcp.orgへ追加。
- [PipedreamHQ/pipedream](https://github.com/PipedreamHQ/pipedream/tree/master/modelcontextprotocol) ☁️ 🏠 - 8,000以上のツールで2,500のAPIと連携し、ユーザーのサーバー管理を自身のアプリ内で実現。
- [VeriTeknik/pluggedin-mcp-proxy](https://github.com/VeriTeknik/pluggedin-mcp-proxy)  📇 🏠 - 複数MCPサーバーを1つのインターフェースに統合する総合プロキシサーバー。サーバー横断のツール・プロンプト・リソース・テンプレートの発見と管理、MCPサーバー構築時のデバッグプレイグラウンドも提供。
- [tigranbs/mcgravity](https://github.com/tigranbs/mcgravity) 📇 🏠 - 複数MCPサーバーを1つのエンドポイントに統合するプロキシツール。複数MCPサーバーにリクエストをロードバランシングし、WebサーバーのNginxのようにAIツールをスケール。
- [MetaMCP](https://github.com/metatool-ai/metatool-app) 📇 ☁️ 🏠 🍎 🪟 🐧 - MetaMCPはGUIでMCP接続を管理する統合ミドルウェアMCPサーバー。
- [WayStation-ai/mcp](https://github.com/waystation-ai/mcp) ☁️ 🍎 🪟 - Claude Desktopや他のMCPホストをNotion、Slack、Monday、Airtable等のお気に入りアプリと安全かつシームレスに接続。90秒以内で完了。
- [sxhxliang/mcp-access-point](https://github.com/sxhxliang/mcp-access-point) 📇 ☁️ 🏠 🍎 🪟 🐧 - コード変更不要でワンクリックでWebサービスをMCPサーバー化。
- [hamflx/imagen3-mcp](https://github.com/hamflx/imagen3-mcp) 📇 🏠 🪟 🍎 🐧 - GoogleのImagen 3.0 APIをMCP経由で利用する高機能画像生成ツール。テキストプロンプトから高品質な画像生成、高度な写真・アート・写実コントロールも可能。
- [SureScaleAI/openai-gpt-image-mcp](https://github.com/SureScaleAI/openai-gpt-image-mcp) 📇 ☁️ - OpenAI GPT画像生成/編集用MCPサーバー。

### 🎨 <a name="art-and-culture"></a>アート＆カルチャー

美術コレクション、文化遺産、博物館データベースへのアクセス・探索。AIモデルによる芸術・文化コンテンツの検索・分析を実現。

- [abhiemj/manim-mcp-server](https://github.com/abhiemj/manim-mcp-server) 🐍 🏠 🪟 🐧 - Manimを利用したアニメーション生成用ローカルMCPサーバー。
- [burningion/video-editing-mcp](https://github.com/burningion/video-editing-mcp) 🐍 - Video Jungleコレクションからの動画編集の追加・分析・検索・生成。
- [cswkim/discogs-mcp-server](https://github.com/cswkim/discogs-mcp-server) 📇 ☁️ - Discogs APIと連携するMCPサーバー。
- [djalal/quran-mcp-server](https://github.com/djalal/quran-mcp-server) 📇 ☁️ - Quran.comコーパスへ公式REST API v4でアクセスするMCPサーバー。
- [mikechao/metmuseum-mcp](https://github.com/mikechao/metmuseum-mcp) 📇 ☁️ - メトロポリタン美術館コレクションAPI連携。作品検索・表示が可能。
- [r-huijts/rijksmuseum-mcp](https://github.com/r-huijts/rijksmuseum-mcp) 📇 ☁️ - ライクス美術館API連携。作品検索、詳細、コレクション取得。
- [r-huijts/oorlogsbronnen-mcp](https://github.com/r-huijts/oorlogsbronnen-mcp) 📇 ☁️ - オランダWWII歴史記録（1940-1945）・写真・文書取得API統合。
- [samuelgursky/davinci-resolve-mcp](https://github.com/samuelgursky/davinci-resolve-mcp) 🐍 - DaVinci Resolve連携のMCPサーバー。動画編集・カラーグレーディング・メディア管理・プロジェクト制御など強力なツール群。
- [yuna0x0/anilist-mcp](https://github.com/yuna0x0/anilist-mcp) 📇 ☁️ - AniList API統合によるアニメ・マンガ情報取得用MCPサーバー。
- [diivi/aseprite-mcp](https://github.com/diivi/aseprite-mcp) 🐍 🏠 - Aseprite APIを利用したピクセルアート作成用MCPサーバー。
- [omni-mcp/isaac-sim-mcp](https://github.com/omni-mcp/isaac-sim-mcp) 📇 ☁️ - NVIDIA Isaac Sim, Lab, OpenUSD等を自然言語で制御できるMCPサーバー＆拡張機能。
- [8enSmith/mcp-open-library](https://github.com/8enSmith/mcp-open-library) 📇 ☁️ - Open Library API連携MCPサーバー。AIアシスタントによる書籍情報検索を実現。
- [PatrickPalmer/MayaMCP](https://github.com/PatrickPalmer/MayaMCP) 🐍 🏠 - Autodesk Maya用MCPサーバー。
- [cantian-ai/bazi-mcp](https://github.com/cantian-ai/bazi-mcp) 📇 🏠 ☁️ 🍎 🪟 - 包括的かつ高精度な四柱推命チャート生成・分析を提供。

### 📂 <a name="browser-automation"></a>ブラウザ自動化

Webコンテンツアクセスと自動化機能。AIフレンドリーな形式でWebコンテンツの検索・スクレイピング・処理が可能。

- [xspadex/bilibili-mcp](https://github.com/xspadex/bilibili-mcp.git) 📇 🏠 - FastMCPベースでBilibiliのトレンド動画を取得し、標準MCPインターフェースで公開。
- [34892002/bilibili-mcp-js](https://github.com/34892002/bilibili-mcp-js) 📇 🏠 - Bilibiliコンテンツ検索対応MCPサーバー。LangChain連携例やテストスクリプトも提供。
- [aircodelabs/grasp](https://github.com/aircodelabs/grasp) 📇 🏠 - MCPとA2Aサポートを備えたエージェント内蔵のセルフホスト型ブラウザ。
- [automatalabs/mcp-server-playwright](https://github.com/Automata-Labs-team/MCP-Server-Playwright) 🐍 - Playwright利用のブラウザ自動化用MCPサーバー。
- [blackwhite084/playwright-plus-python-mcp](https://github.com/blackwhite084/playwright-plus-python-mcp) 🐍 - Playwrightを使ったMCP Pythonサーバー。llmにより適した設計。
- [browserbase/mcp-server-browserbase](https://github.com/browserbase/mcp-server-browserbase) 🎖️ 📇 - クラウド上でのブラウザ自動操作（Webナビゲーション、データ抽出、フォーム入力等）。
- [browsermcp/mcp](https://github.com/browsermcp/mcp) 📇 🏠 - ローカルChromeブラウザの自動化。
- [co-browser/browser-use-mcp-server](https://github.com/co-browser/browser-use-mcp-server) 🐍 - browser-useをMCPサーバー化しSSEトランスポートで提供。Chromium＋VNCをDockerで実行可能なDockerfile付属。
- [executeautomation/playwright-mcp-server](https://github.com/executeautomation/mcp-playwright) 📇 - Playwrightでブラウザ自動化・Webスクレイピングを行うMCPサーバー。
- [eyalzh/browser-control-mcp](https://github.com/eyalzh/browser-control-mcp) 📇 🏠 - LLMクライアントがユーザーのブラウザ（Firefox）を操作できる拡張機能付きMCPサーバー。
- [fradser/mcp-server-apple-reminders](https://github.com/FradSer/mcp-server-apple-reminders) 📇 🏠 🍎 - macOSのAppleリマインダー操作用MCPサーバー。
- [getrupt/ashra-mcp](https://github.com/getrupt/ashra-mcp) 🐍 🏠 - 任意のWebサイトから構造化データを抽出。プロンプト入力でJSONを取得。
- [kimtaeyoon83/mcp-server-youtube-transcript](https://github.com/kimtaeyoon83/mcp-server-youtube-transcript) 📇 ☁️ - YouTube字幕・トランスクリプトを取得しAI解析に活用。
- [kimtth/mcp-aoai-web-browsing](https://github.com/kimtth/mcp-aoai-web-browsing) 🐍 🏠 - Azure OpenAIとPlaywrightを使った「最小限」サーバ/クライアントMCP実装。
- [microsoft/playwright-mcp](https://github.com/microsoft/playwright-mcp) - Microsoft公式Playwright MCPサーバー。LLMによるWebページ操作をアクセシビリティスナップショット経由で実現。
- [modelcontextprotocol/server-puppeteer](https://github.com/modelcontextprotocol/servers/tree/main/src/puppeteer) 📇 🏠 - Webスクレイピング・操作用ブラウザ自動化。
- [ndthanhdev/mcp-browser-kit](https://github.com/ndthanhdev/mcp-browser-kit) 📇 🏠 - manifest v2互換ブラウザとやりとりするMCPサーバー。
- [pskill9/web-search](https://github.com/pskill9/web-search) 📇 🏠 - Google検索結果を利用し、APIキー不要でWeb検索可能なMCPサーバー。
- [recursechat/mcp-server-apple-shortcuts](https://github.com/recursechat/mcp-server-apple-shortcuts) 📇 🏠 🍎 - Appleショートカット連携MCPサーバー。

### ☁️ <a name="cloud-platforms"></a>クラウドプラットフォーム

クラウドプラットフォームサービスの統合。クラウドインフラやサービスの管理・操作が可能。

- [awslabs/mcp](https://github.com/awslabs/mcp) 🎖️ ☁️ - AWSサービス・リソースとシームレス統合するAWS MCPサーバー。
- [qiniu/qiniu-mcp-server](https://github.com/qiniu/qiniu-mcp-server) 🐍 ☁️ - Qiniu Cloud製品上のMCP。クラウドストレージやメディア処理サービス等に対応。
- [alexbakers/mcp-ipfs](https://github.com/alexbakers/mcp-ipfs) 📇 ☁️ - IPFSストレージのアップロード・操作対応。
- [reza-gholizade/k8s-mcp-server](https://github.com/reza-gholizade/k8s-mcp-server) 🏎️ ☁️/🏠 - KubernetesクラスタとやりとりできるMCPサーバー。APIリソース発見、管理、Podログ・メトリクス・イベントまで対応。
- [VmLia/books-mcp-server](https://github.com/VmLia/books-mcp-server) 📇 ☁️ - 書籍検索用MCPサーバー。Cherry Studio等一般的なMCPクライアントで利用可。
- [alexei-led/aws-mcp-server](https://github.com/alexei-led/aws-mcp-server) 🐍 ☁️ - AIアシスタントによるAWS CLI実行、Unixパイプ、プロンプトテンプレート適用を安全なDocker環境＆マルチアーキテクチャ対応で実現する軽量・高機能サーバー。
- [alexei-led/k8s-mcp-server](https://github.com/alexei-led/k8s-mcp-server) 🐍 - AIアシスタントによるKubernetes CLI（`kubectl`, `helm`, `istioctl`, `argocd`）実行を安全なDocker環境＆マルチアーキテクチャ対応で実現する軽量・堅牢サーバー。
- [aliyun/alibaba-cloud-ops-mcp-server](https://github.com/aliyun/alibaba-cloud-ops-mcp-server) 🎖️ 🐍 ☁️ - AIアシスタントによるAlibaba Cloudリソース操作用MCPサーバー。ECS、Cloud Monitor、OOS他主要クラウド製品に対応。  
- [bright8192/esxi-mcp-server](https://github.com/bright8192/esxi-mcp-server) 🐍 ☁️ - VMware ESXi/vCenter管理用MCPサーバー。仮想マシン操作用のREST APIを提供。
- [cloudflare/mcp-server-cloudflare](https://github.com/cloudflare/mcp-server-cloudflare) 🎖️ 📇 ☁️ - Cloudflare Workers、KV、R2、D1等各種サービス連携。
- [cyclops-ui/mcp-cyclops](https://github.com/cyclops-ui/mcp-cyclops) 🎖️ 🏎️ ☁️ - AIエージェントによるCyclops抽象化経由のKubernetesリソース管理を実現するMCPサーバー。
- [jedisct1/fastly-mcp-server](https://github.com/jedisct1/fastly-openapi-schema) 🎖️ 📇 ☁️ - Fastlyサービス連携。
- [flux159/mcp-server-kubernetes](https://github.com/Flux159/mcp-server-kubernetes) 📇 ☁️/🏠 - TypeScript実装によるKubernetesクラスタ運用（Pod、Deployment、Service等）。
- [hardik-id/azure-resource-graph-mcp-server](https://github.com/hardik-id/azure-resource-graph-mcp-server) 📇 ☁️/🏠 - Azure Resource Graphで大規模Azureリソースのクエリ・分析を可能にするMCPサーバー。AIアシスタントによるインフラ探索・監視が可能。
- [jdubois/azure-cli-mcp](https://github.com/jdubois/azure-cli-mcp) - Azure CLIコマンドラインを直接操作可能にするラッパー。
- [johnneerdael/netskope-mcp](https://github.com/johnneerdael/netskope-mcp) 🔒 ☁️ - Netskope Private Access環境へのアクセス・セットアップ情報・LLM使用例も含むMCP。
- [manusa/Kubernetes MCP Server](https://github.com/manusa/kubernetes-mcp-server) 🏎️ 🏠 - OpenShiftもサポートする高機能Kubernetes MCPサーバー。全KubernetesリソースのCRUD操作に加え、クラスタ操作ツールも搭載。
- [nwiizo/tfmcp](https://github.com/nwiizo/tfmcp) 🦀 🏠 - Terraform環境の運用管理をAIアシスタントに提供するTerraform MCPサーバー。構成読込・プラン分析・反映・状態管理等に対応。
- [pulumi/mcp-server](https://github.com/pulumi/mcp-server) 🎖️ 📇 🏠 - Pulumi Automation API・Pulumi Cloud API連携のMCPサーバー。パッケージ情報取得、変更プレビュー、デプロイ、スタック出力のプログラマティック取得等に対応。
- [rohitg00/kubectl-mcp-server](https://github.com/rohitg00/kubectl-mcp-server) 🐍 ☁️/🏠 - ClaudeやCursor等AIアシスタントから自然言語でKubernetesクラスタとやりとりできるMCPサーバー。
- [strowk/mcp-k8s-go](https://github.com/strowk/mcp-k8s-go) 🏎️ ☁️/🏠 - MCP経由のKubernetesクラスタ操作。
- [thunderboltsid/mcp-nutanix](https://github.com/thunderboltsid/mcp-nutanix) 🏎️ 🏠/☁️ - Nutanix Prism Centralリソース連携用Go製MCPサーバー。
- [trilogy-group/aws-pricing-mcp](https://github.com/trilogy-group/aws-pricing-mcp) 🏎️ ☁️/🏠 - 最新EC2料金情報を高速取得。事前解析済みAWS料金カタログ利用。
- [weibaohui/k8m](https://github.com/weibaohui/k8m) 🏎️ ☁️/🏠 - MCPによるマルチクラスタKubernetes管理・運用。管理UI・ログ収集、DevOps/開発向けツール約50種を内蔵。標準・CRDリソース両対応。
- [weibaohui/kom](https://github.com/weibaohui/kom) 🏎️ ☁️/🏠 - MCPによるマルチクラスタKubernetes管理・運用。自身のプロジェクトにSDKとして統合可能。DevOps/開発向けツール約50種内蔵。標準・CRDリソース両対応。
- [wenhuwang/mcp-k8s-eye](https://github.com/wenhuwang/mcp-k8s-eye) 🏎️ ☁️/🏠 - Kubernetes管理用MCPサーバー。クラスタやアプリケーションのヘルスを分析。
- [erikhoward/adls-mcp-server](https://github.com/erikhoward/adls-mcp-server) 🐍 ☁️/🏠 - Azure Data Lake Storage用MCPサーバー。コンテナの管理や、ファイルの読み書き・アップロード・ダウンロード、ファイルメタデータの管理が可能。
- [silenceper/mcp-k8s](https://github.com/silenceper/mcp-k8s) 🏎️ ☁️/🏠 - MCP-K8SはAI駆動のKubernetesリソース管理ツール。自然言語でKubernetesクラスタ内のあらゆるリソース（Deployment, Service等のネイティブリソースやCRDなどのカスタムリソース）を操作可能。複雑なコマンドを覚える必要なし、要件を記述するだけでAIが適切にクラスタ操作を実行し、Kubernetesの使いやすさを大幅向上。
- [redis/mcp-redis-cloud](https://github.com/redis/mcp-redis-cloud) 📇 ☁️ - 自然言語でRedis Cloudリソースを簡単管理。データベース作成、サブスクリプション監視、クラウドデプロイ設定などをシンプルなコマンドで操作可能。
- [portainer/portainer-mcp](https://github.com/portainer/portainer-mcp) 🏎️ ☁️/🏠 - 強力なMCPサーバー。AIアシスタントがPortainerインスタンスとシームレスに連携し、コンテナ管理、デプロイ操作、インフラ監視などを自然言語で実現。

### 👨‍💻 <a name="code-execution"></a>コード実行

コード実行用サーバー。LLMが安全な環境でコードを実行できるようにします（コーディングエージェント向け等）。

- [pydantic/pydantic-ai/mcp-run-python](https://github.com/pydantic/pydantic-ai/tree/main/mcp-run-python) 🐍 🏠- MCPツールコール経由でPythonコードを安全なサンドボックスで実行
- [yepcode/mcp-server-js](https://github.com/yepcode/mcp-server-js) 🎖️ 📇 ☁️ - 任意のLLM生成コードを安全かつスケーラブルなサンドボックス環境で実行し、JavaScriptまたはPythonで独自のMCPツールを作成可能。NPMおよびPyPIパッケージをフルサポート。
- [ckanthony/openapi-mcp](https://github.com/ckanthony/openapi-mcp) 🏎️ ☁️ - OpenAPI-MCP: 既存のAPIドキュメントを活用し、AIエージェントが任意APIにアクセスできるDocker化されたMCPサーバー。
- [alfonsograziano/node-code-sandbox-mcp](https://github.com/alfonsograziano/node-code-sandbox-mcp) 📇 🏠 – JavaScriptスニペットを実行するための、npm依存関係をその場でインストール・クリーンなテアダウンを行うDockerベース分離サンドボックスを立ち上げるNode.js MCPサーバー
- [r33drichards/mcp-js](https://github.com/r33drichards/mcp-js) 🦀 🏠 🐧 🍎 - v8を用いてコードを分離し、AI生成のJavaScriptをローカルで安全に実行できるJavaScriptコード実行サンドボックス。ヒープスナップショットによる永続セッションもサポート。

### 🤖 <a name="coding-agents"></a>コーディングエージェント

LLMがコードを読み取り・編集・実行し、一般的なプログラミングタスクを完全自律的に解決できるフル機能コーディングエージェント。

- [oraios/serena](https://github.com/oraios/serena)🐍🏠 - 言語サーバーを利用したシンボリックなコード操作に基づく、フル機能のコーディングエージェント。
- [ezyang/codemcp](https://github.com/ezyang/codemcp) 🐍🏠 - 基本的な読み書きやコマンドラインツールを備えたコーディングエージェント。
- [doggybee/mcp-server-leetcode](https://github.com/doggybee/mcp-server-leetcode) 📇 ☁️ - AIモデルがLeetCode問題の検索・取得・解答を可能にするMCPサーバー。メタデータフィルタリング、ユーザープロファイル、提出・コンテストデータアクセス対応。
- [jinzcdev/leetcode-mcp-server](https://github.com/jinzcdev/leetcode-mcp-server) 📇 ☁️ - **LeetCode**の問題・解答・提出・公開データに自動アクセスできるMCPサーバー。ユーザー固有機能（例：ノート）には認証対応。`leetcode.com`（グローバル）・`leetcode.cn`（中国）両対応。
- [juehang/vscode-mcp-server](https://github.com/juehang/vscode-mcp-server) 📇 🏠 - ClaudeなどAIがVS Codeワークスペースのディレクトリ構造から読み取り、リンターや言語サーバーで検出された問題・コードファイルを読んで編集できるMCPサーバー。
- [micl2e2/code-to-tree](https://github.com/micl2e2/code-to-tree) 🌊 🏠 📟 🐧 🪟 🍎 - ソースコードを言語を問わずASTに変換する単一バイナリのMCPサーバー。

### 🖥️ <a name="command-line"></a>コマンドライン

コマンド実行・出力取得・シェルやコマンドラインツールとのインタラクション。

- [ferrislucas/iterm-mcp](https://github.com/ferrislucas/iterm-mcp) 🖥️ 🛠️ 💬 - iTermへのアクセスを提供するModel Context Protocolサーバー。コマンド実行や、iTermターミナルの内容に関する質問が可能。
- [g0t4/mcp-server-commands](https://github.com/g0t4/mcp-server-commands) 📇 🏠 - `run_command`および`run_script`ツールで任意コマンドを実行。
- [maxim-saplin/mcp_safe_local_python_executor](https://github.com/maxim-saplin/mcp_safe_local_python_executor) - HF Smolagents `LocalPythonExecutor`ベースの安全なPythonインタプリタ
- [MladenSU/cli-mcp-server](https://github.com/MladenSU/cli-mcp-server) 🐍 🏠 - セキュアな実行とカスタマイズ可能なセキュリティポリシーを持つコマンドラインインターフェース
- [OthmaneBlial/term_mcp_deepseek](https://github.com/OthmaneBlial/term_mcp_deepseek) 🐍 🏠 - DeepSeekのためのMCPライクなターミナルサーバー
- [tumf/mcp-shell-server](https://github.com/tumf/mcp-shell-server) - Model Context Protocol (MCP)準拠の安全なシェルコマンド実行サーバー
- [automateyournetwork/pyATS_MCP](https://github.com/automateyournetwork/pyATS_MCP) - ネットワーク機器との構造化・モデル駆動インタラクションを可能にするCisco pyATSサーバー。
- [wonderwhy-er/DesktopCommanderMCP](https://github.com/wonderwhy-er/DesktopCommanderMCP) 📇 🏠 🍎 🪟 🐧 - プログラムの管理/実行やコード・テキストファイルの読み書き・検索・編集ができるスイスアーミーナイフ的MCPサーバー。
- [tufantunc/ssh-mcp](https://github.com/tufantunc/ssh-mcp) 📇 🏠 🐧 🪟 - Model Context Protocol経由でLinux/WindowsサーバーのSSH制御を提供するMCPサーバー。パスワードやSSH鍵認証でリモートシェルコマンドを安全実行。

### 💬 <a name="communication"></a>コミュニケーション

メッセージ管理やチャンネル操作のためのコミュニケーションプラットフォーム連携。AIモデルがチームコミュニケーションツールと対話可能。

- [AbdelStark/nostr-mcp](https://github.com/AbdelStark/nostr-mcp) ☁️ - Nostrとの連携を実現し、ノート投稿などを可能にするNostr MCPサーバー。
- [adhikasp/mcp-twikit](https://github.com/adhikasp/mcp-twikit) 🐍 ☁️ - Twitterの検索やタイムラインと連携
- [agentmail-toolkit/mcp](https://github.com/agentmail-to/agentmail-toolkit/tree/main/mcp) 🐍 💬 - メールの送受信やアクションを即時に行うインボックス作成用MCPサーバー。AIエージェント用のメール機能を提供。
- [arpitbatra123/mcp-googletasks](https://github.com/arpitbatra123/mcp-googletasks) 📇 ☁️ - Google Tasks API連携用MCPサーバー
- [carterlasalle/mac_messages_mcp](https://github.com/carterlasalle/mac_messages_mcp) 🏠 🍎 🚀 - Model Context Protocol (MCP)経由でiMessageデータベースに安全にアクセスし、LLMがiMessage会話を問い合わせ・分析できるMCPサーバー。電話番号検証、添付処理、連絡先管理、グループチャット対応、送受信フルサポート。
- [chaindead/telegram-mcp](https://github.com/chaindead/telegram-mcp) 🏎️ 🏠 - ユーザーデータへのアクセス、ダイアログ（チャット・チャンネル・グループ）管理、メッセージ取得、既読管理などができるTelegram API連携
- [chigwell/telegram-mcp](https://github.com/chigwell/telegram-mcp) 🐍 🏠 - ユーザーデータへのアクセス、ダイアログ管理、メッセージ取得・送信、既読管理ができるTelegram API連携
- [elie222/inbox-zero](https://github.com/elie222/inbox-zero/tree/main/apps/mcp-server) 🐍 ☁️ - Inbox Zero用MCPサーバー。Gmailの上に、返信やフォローアップが必要なメールの発見機能を追加。
- [gitmotion/ntfy-me-mcp](https://github.com/gitmotion/ntfy-me-mcp) 📇 ☁️ 🏠 - AIエージェントから自己ホストntfyサーバーへの通知送信・取得用ntfy MCPサーバー（セキュアなトークン認証等対応。npxやdocker利用可！）
- [gotoolkits/wecombot](https://github.com/gotoolkits/mcp-wecombot-server.git) 🚀 ☁️ - WeComグループロボットへ様々なタイプのメッセージを送信するMCPサーバーアプリケーション。
- [hannesrudolph/imessage-query-fastmcp-mcp-server](https://github.com/hannesrudolph/imessage-query-fastmcp-mcp-server) 🐍 🏠 🍎 - Model Context Protocol (MCP)経由でiMessageデータベースに安全にアクセスし、LLMによるiMessage会話のクエリ・分析、電話番号検証や添付ファイル対応も可能なMCPサーバー
- [i-am-bee/acp-mcp](https://github.com/i-am-bee/acp-mcp) 🐍 💬 - [ACP](https://agentcommunicationprotocol.dev)エコシステムへのアダプタとして動作するMCPサーバー。ACPエージェントをMCPクライアントにシームレスに公開し、両プロトコル間のコミュニケーションギャップを橋渡し。
- [jagan-shanmugam/mattermost-mcp-host](https://github.com/jagan-shanmugam/mattermost-mcp-host) 🐍 🏠 - Mattermostのチーム、チャンネル、メッセージへのアクセスを提供するMCPサーバーとホスト。MCPホストはMattermostのボットとして統合され、MCPサーバーアクセスが構成可能。
- [lharries/whatsapp-mcp](https://github.com/lharries/whatsapp-mcp) 🐍 🏎️ - 個人のWhatsAppメッセージ・連絡先の検索や個人・グループへのメッセージ送信ができるMCPサーバー
- [line/line-bot-mcp-server](https://github.com/line/line-bot-mcp-server) 🎖 📇 ☁️ - LINE公式アカウント連携用MCPサーバー
- [MarkusPfundstein/mcp-gsuite](https://github.com/MarkusPfundstein/mcp-gsuite) 🐍 ☁️ - GmailおよびGoogleカレンダー連携
- [modelcontextprotocol/server-bluesky](https://github.com/keturiosakys/bluesky-context-server) 📇 ☁️ - Blueskyインスタンス連携によるクエリ・インタラクション
- [modelcontextprotocol/server-slack](https://github.com/modelcontextprotocol/servers/tree/main/src/slack) 📇 ☁️ - Slackワークスペース連携（チャンネル管理・メッセージ送信等）
- [korotovsky/slack-mcp-server](https://github.com/korotovsky/slack-mcp-server) 📇 ☁️ - Slackワークスペース向け最強のMCPサーバー。
- [sawa-zen/vrchat-mcp](https://github.com/sawa-zen/vrchat-mcp) - 📇 🏠 VRChat APIと連携するMCPサーバー。フレンド・ワールド・アバターなどVRChat内情報の取得が可能。
- [takumi0706/google-calendar-mcp](https://github.com/takumi0706/google-calendar-mcp) 📇 ☁️ - Google Calendar API連携用MCPサーバー。TypeScriptベース。
- [teddyzxcv/ntfy-mcp](https://github.com/teddyzxcv/ntfy-mcp) - ntfy経由でスマホに通知を送るMCPサーバー
- [userad/didlogic_mcp](https://github.com/UserAd/didlogic_mcp) 🐍 ☁️ - [DIDLogic](https://didlogic.com)連携用MCPサーバー。SIPエンドポイント・番号・転送先の管理機能を追加。
- [zcaceres/gtasks-mcp](https://github.com/zcaceres/gtasks-mcp) 📇 ☁️ - Google Tasks管理用MCPサーバー
- [InditexTech/mcp-teams-server](https://github.com/InditexTech/mcp-teams-server) 🐍 ☁️ - Microsoft Teamsメッセージング連携用MCPサーバー（読み取り・投稿・メンション・メンバー/スレッド一覧）
- [softeria/ms-365-mcp-server](https://github.com/softeria/ms-365-mcp-server) 📇 ☁️ - Microsoft 365全体（メール・ファイル・Excel・カレンダー等）にGraph APIで接続するMCPサーバー
- [YCloud-Developers/ycloud-whatsapp-mcp-server](https://github.com/YCloud-Developers/ycloud-whatsapp-mcp-server) 📇 🏠 - YCloudによるWhatsApp Business Platform用MCPサーバー
- [jaipandya/producthunt-mcp-server](https://github.com/jaipandya/producthunt-mcp-server) 🐍 🏠 - Product Hunt用MCPサーバー。トレンド投稿・コメント・コレクション・ユーザー等と連携。

### 👤 <a name="customer-data-platforms"></a>カスタマーデータプラットフォーム

カスタマーデータプラットフォーム内の顧客プロファイルへのアクセスを提供

- [iaptic/mcp-server-iaptic](https://github.com/iaptic/mcp-server-iaptic) 🎖️ 📇 ☁️ - [iaptic](https://www.iaptic.com)と接続し、顧客購入・取引データ・アプリ収益統計を質問可能。
- [OpenDataMCP/OpenDataMCP](https://github.com/OpenDataMCP/OpenDataMCP) 🐍 ☁️ - あらゆるオープンデータをModel Context Protocolで任意LLMに接続。
- [sergehuber/inoyu-mcp-unomi-server](https://github.com/sergehuber/inoyu-mcp-unomi-server) 📇 ☁️ - Apache Unomi CDPサーバー上のプロファイルへのアクセス・更新を行うMCPサーバー。
- [tinybirdco/mcp-tinybird](https://github.com/tinybirdco/mcp-tinybird) 🐍 ☁️ - 任意のMCPクライアントからTinybird Workspaceに対話可能なMCPサーバー。
- [@antv/mcp-server-chart](https://github.com/antvis/mcp-server-chart) 🎖️ 📇 ☁️ - [AntV](https://github.com/antvis)を利用したビジュアルチャート生成用Model Context Protocolサーバー。

### 🗄️ <a name="databases"></a>データベース

スキーマ検査機能付き安全なデータベースアクセス。読み取り専用などセキュリティコントロールを設定し、データのクエリや分析が可能。

- [Aiven-Open/mcp-aiven](https://github.com/Aiven-Open/mcp-aiven) - 🐍 ☁️ 🎖️ -  [Aivenプロジェクト](https://go.aiven.io/mcp-server)をナビゲートし、PostgreSQL®、Apache Kafka®、ClickHouse®、OpenSearch®サービスと連携
- [alexanderzuev/supabase-mcp-server](https://github.com/alexander-zuev/supabase-mcp-server) - SQLクエリ実行やデータベース探索ツールを備えたSupabase MCPサーバー
- [aliyun/alibabacloud-tablestore-mcp-server](https://github.com/aliyun/alibabacloud-tablestore-mcp-server) ☕ 🐍 ☁️ - Tablestore用MCPサービス。ドキュメント追加、ベクトルやスカラーによる意味検索、RAG対応、サーバーレス。
- [benborla29/mcp-server-mysql](https://github.com/benborla/mcp-server-mysql) ☁️ 🏠 - NodeJSによるMySQLデータベース連携。アクセス制御やスキーマ検査を設定可能。
- [bytebase/dbhub](https://github.com/bytebase/dbhub) 📇 🏠 – 主流データベースをサポートするユニバーサルなデータベースMCPサーバー。
- [c4pt0r/mcp-server-tidb](https://github.com/c4pt0r/mcp-server-tidb) 🐍 ☁️ - TiDBデータベース連携。スキーマ検査・クエリ機能付き。
- [Canner/wren-engine](https://github.com/Canner/wren-engine) 🐍 🦀 🏠 - Model Context Protocol(MCP)クライアント・AIエージェント用セマンティックエンジン
- [centralmind/gateway](https://github.com/centralmind/gateway) 🏎️ 🏠 🍎 🪟 - データベーススキーマ・データから自動的にAPIを生成するMCPおよびMCP SSEサーバー。PostgreSQL、Clickhouse、MySQL、Snowflake、BigQuery、Supabase対応
- [ChristianHinge/dicom-mcp](https://github.com/ChristianHinge/dicom-mcp) 🐍 ☁️ 🏠 - DICOM連携で、PACSや他のDICOM準拠システムから医用画像・レポートのクエリ・取得・転送が可能。
- [chroma-core/chroma-mcp](https://github.com/chroma-core/chroma-mcp) 🎖️ 🐍 ☁️ 🏠 - ローカル・クラウドChromaインスタンスへのリトリーバル機能を提供するChroma MCPサーバー
- [ClickHouse/mcp-clickhouse](https://github.com/ClickHouse/mcp-clickhouse) 🐍 ☁️ - ClickHouseデータベース連携。スキーマ検査・クエリ機能付き。
- [confluentinc/mcp-confluent](https://github.com/confluentinc/mcp-confluent) 🐍 ☁️ - Confluent KafkaおよびConfluent Cloud REST APIと連携するためのConfluent統合。
- [Couchbase-Ecosystem/mcp-server-couchbase](https://github.com/Couchbase-Ecosystem/mcp-server-couchbase) 🎖️ 🐍 ☁️ 🏠 - Couchbase MCPサーバーは、ドキュメント操作、SQL++クエリ、自然言語データ分析のためにCapellaクラウドおよびセルフマネージドクラスタの両方への統合アクセスを提供します。
- [cr7258/elasticsearch-mcp-server](https://github.com/cr7258/elasticsearch-mcp-server) 🐍 🏠 - Elasticsearch連携を提供するMCPサーバー実装
- [crystaldba/postgres-mcp](https://github.com/crystaldba/postgres-mcp) 🐍 🏠 - Postgresの開発と運用のためのオールインワンMCPサーバー。パフォーマンス分析、チューニング、ヘルスチェックのツール付き
- [Dataring-engineering/mcp-server-trino](https://github.com/Dataring-engineering/mcp-server-trino) 🐍 ☁️ - TrinoクラスタからのデータのクエリおよびアクセスのためのTrino MCPサーバー。
- [tuannvm/mcp-trino](https://github.com/tuannvm/mcp-trino) 🏎️ ☁️ - Trino用Model Context Protocol（MCP）サーバーのGo実装
- [designcomputer/mysql_mcp_server](https://github.com/designcomputer/mysql_mcp_server) 🐍 🏠 - 設定可能なアクセス制御、スキーマ検査、包括的なセキュリティガイドラインを備えたMySQLデータベース統合
- [wenb1n-dev/mysql_mcp_server_pro](https://github.com/wenb1n-dev/mysql_mcp_server_pro)  🐍 🏠 - SSE、STDIO対応。MySQLのCRUD機能に限定されず、データベース例外分析機能、ロールベースの権限制御、拡張ツールのカスタマイズも容易
- [domdomegg/airtable-mcp-server](https://github.com/domdomegg/airtable-mcp-server) 📇 🏠 - スキーマ検査、読み書き機能付きAirtableデータベース統合
- [edwinbernadus/nocodb-mcp-server](https://github.com/edwinbernadus/nocodb-mcp-server) 📇 ☁️ - Nocodbデータベース統合、読み書き機能対応
- [ergut/mcp-bigquery-server](https://github.com/ergut/mcp-bigquery-server) 📇 ☁️ - Google BigQuery統合のためのサーバー実装。直接BigQueryデータベースアクセスとクエリ機能を提供
- [f4ww4z/mcp-mysql-server](https://github.com/f4ww4z/mcp-mysql-server) 📇 🏠 - Node.jsベースのMySQLデータベース統合で安全なMySQL操作を提供
- [fireproof-storage/mcp-database-server](https://github.com/fireproof-storage/mcp-database-server) 📇 ☁️ - マルチユーザー同期対応のFireproof台帳データベース
- [FreePeak/db-mcp-server](https://github.com/FreePeak/db-mcp-server) 🏎️ 🏠 – Golang製の高性能マルチデータベースMCPサーバー。MySQLとPostgreSQLをサポート（NoSQL対応予定）。クエリ実行、トランザクション管理、スキーマ探索、クエリビルダー、パフォーマンス分析など内蔵ツールを搭載し、シームレスなCursor統合によりデータベースワークフローを強化。
- [furey/mongodb-lens](https://github.com/furey/mongodb-lens) 📇 🏠 - MongoDBデータベース用のフル機能MCPサーバー「MongoDB Lens」
- [gannonh/firebase-mcp](https://github.com/gannonh/firebase-mcp) 🔥 ⛅️ - Firebaseサービス（Auth, Firestore, Storage）対応。
- [get-convex/convex-backend](https://stack.convex.dev/convex-mcp-server) 📇 ☁️ - Convexデータベース統合：テーブルや関数の調査、ワンオフクエリ実行が可能（[ソース](https://github.com/get-convex/convex-backend/blob/main/npm-packages/convex/src/cli/mcp.ts)）
- [googleapis/genai-toolbox](https://github.com/googleapis/genai-toolbox) 🏎️ ☁️ - データベース向けの簡単・高速・安全なツールを提供するオープンソースMCPサーバー。
- [GreptimeTeam/greptimedb-mcp-server](https://github.com/GreptimeTeam/greptimedb-mcp-server) 🐍 🏠 - GreptimeDBのクエリ用MCPサーバー。
- [hannesrudolph/sqlite-explorer-fastmcp-mcp-server](https://github.com/hannesrudolph/sqlite-explorer-fastmcp-mcp-server) 🐍 🏠 - Model Context Protocol（MCP）経由でSQLiteデータベースに安全な読み取り専用アクセスを提供するMCPサーバー。FastMCPフレームワークで構築され、LLMによる探索やクエリバリデーションと安全機能を備える。
- [idoru/influxdb-mcp-server](https://github.com/idoru/influxdb-mcp-server) 📇 ☁️ 🏠 - InfluxDB OSS API v2に対してクエリ実行可能。
- [isaacwasserman/mcp-snowflake-server](https://github.com/isaacwasserman/mcp-snowflake-server) 🐍 ☁️ - Snowflake連携：読み取り・（オプションで）書き込み操作、インサイトトラッキング機能
- [joshuarileydev/supabase-mcp-server](https://github.com/joshuarileydev/supabase) - Supabaseでプロジェクトや組織の管理・作成を行うMCPサーバー
- [jovezhong/mcp-timeplus](https://github.com/jovezhong/mcp-timeplus) 🐍 ☁️ - Apache KafkaとTimeplus用MCPサーバー。Kafkaトピックの一覧表示、メッセージのポーリング、ローカル保存、Timeplusを通じたSQLでのストリーミングデータクエリが可能
- [KashiwaByte/vikingdb-mcp-server](https://github.com/KashiwaByte/vikingdb-mcp-server) 🐍 ☁️ - VikingDB連携：コレクション・インデックス紹介、ベクトルストア・検索機能対応。
- [kiliczsh/mcp-mongo-server](https://github.com/kiliczsh/mcp-mongo-server) 📇 🏠 - MongoDB用のModel Context Protocolサーバー
- [ktanaka101/mcp-server-duckdb](https://github.com/ktanaka101/mcp-server-duckdb) 🐍 🏠 - DuckDBデータベース統合。スキーマ検査・クエリ対応
- [LucasHild/mcp-server-bigquery](https://github.com/LucasHild/mcp-server-bigquery) 🐍 ☁️ - BigQueryデータベース統合。スキーマ検査・クエリ対応
- [quarkiverse/mcp-server-jdbc](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jdbc) ☕ 🏠 - 任意のJDBC互換データベースへ接続し、クエリ・挿入・更新・削除などが可能。
- [jparkerweb/mcp-sqlite](https://github.com/jparkerweb/mcp-sqlite) 📇 🏠 - SQLiteデータベースとの包括的な連携機能を備えたModel Context Protocol（MCP）サーバー。
- [memgraph/mcp-memgraph](https://github.com/memgraph/mcp-memgraph) 🐍 🏠 - Memgraph MCPサーバー。Memgraphへのクエリ実行やスキーマリソース用ツールを含む。
- [modelcontextprotocol/server-postgres](https://github.com/modelcontextprotocol/servers/tree/main/src/postgres) 📇 🏠 - PostgreSQLデータベース統合。スキーマ検査・クエリ対応
- [modelcontextprotocol/server-sqlite](https://github.com/modelcontextprotocol/servers/tree/main/src/sqlite) 🐍 🏠 - SQLiteデータベース操作と組み込み分析機能
- [neo4j-contrib/mcp-neo4j](https://github.com/neo4j-contrib/mcp-neo4j) 🐍 🏠 - Neo4j対応Model Context Protocol（クエリ実行、ナレッジグラフメモリ、Neo4j Auraインスタンス管理）
- [neondatabase/mcp-server-neon](https://github.com/neondatabase/mcp-server-neon) 📇 ☁️ — Neon Serverless Postgresを使ってPostgresデータベースの作成・管理を行うMCPサーバー
- [niledatabase/nile-mcp-server](https://github.com/niledatabase/nile-mcp-server) NileのPostgresプラットフォーム用MCPサーバー - LLMでPostgresデータベース、テナント、ユーザー、認証を管理・クエリ
- [openlink/mcp-server-odbc](https://github.com/OpenLinkSoftware/mcp-odbc-server) 🐍 🏠 - Open Database Connectivity（ODBC）プロトコル経由で汎用データベース管理システム（DBMS）と接続するMCPサーバー
- [openlink/mcp-server-sqlalchemy](https://github.com/OpenLinkSoftware/mcp-sqlalchemy-server) 🐍 🏠 - Python ODBC（pyodbc）を使用したSQLAlchemy経由で汎用DBMS接続するMCPサーバー
- [pab1it0/adx-mcp-server](https://github.com/pab1it0/adx-mcp-server) 🐍 ☁️ - Azure Data Explorerデータベースのクエリ・分析
- [pab1it0/prometheus-mcp-server](https://github.com/pab1it0/prometheus-mcp-server) 🐍 ☁️ -  Prometheus（オープンソース監視システム）のクエリ・分析
- [prisma/prisma](https://github.com/prisma/prisma) 🐍 🏠 - LLMがPrisma Postgresデータベースを管理可能（新規DBインスタンス作成やスキーママイグレーション等）
- [qdrant/mcp-server-qdrant](https://github.com/qdrant/mcp-server-qdrant) 🐍 🏠 - Qdrant MCPサーバー
- [QuantGeekDev/mongo-mcp](https://github.com/QuantGeekDev/mongo-mcp) 📇 🏠 - MongoDB連携。LLMがデータベースと直接やりとり可能
- [rashidazarang/airtable-mcp](https://github.com/rashidazarang/airtable-mcp) 🐍 ☁️ - AIツールをAirtableに直接接続。自然言語でレコードのクエリ・作成・更新・削除が可能。ベース管理、テーブル操作、スキーマ操作、レコードフィルタ、標準化MCPインターフェースによるデータ移行も特長。
- [redis/mcp-redis](https://github.com/redis/mcp-redis) 🐍 🏠 - Redis公式MCPサーバー。Redisデータの管理・検索インターフェースを提供。
- [runekaagaard/mcp-alchemy](https://github.com/runekaagaard/mcp-alchemy) 🐍 🏠 - PostgreSQL、MySQL、MariaDB、SQLite、Oracle、MS SQL Server等多様なDBをサポートするSQLAlchemyベースの汎用DB統合。スキーマ・リレーション検査、大規模データセット分析対応。
- [sirmews/mcp-pinecone](https://github.com/sirmews/mcp-pinecone) 🐍 ☁️ - Pinecone連携：ベクトル検索機能付き
- [skysqlinc/skysql-mcp](https://github.com/skysqlinc/skysql-mcp) 🎖️ ☁️ - サーバーレスMariaDB Cloud DB MCPサーバー。DB起動・削除・SQL実行やDBレベルAIエージェントによるtext-2-sqlや対話をサポート
- [supabase-community/supabase-mcp](https://github.com/supabase-community/supabase-mcp) 🎖️ 📇 ☁️ - 公式Supabase MCPサーバー。AIアシスタントがSupabaseプロジェクトに直接接続し、テーブル管理、設定取得、データクエリ等が可能
- [TheRaLabs/legion-mcp](https://github.com/TheRaLabs/legion-mcp) 🐍 🏠 PostgreSQL、Redshift、CockroachDB、MySQL、RDS MySQL、Microsoft SQL Server、BigQuery、Oracle DB、SQLite等複数DBタイプに対応したユニバーサルDB MCPサーバー
- [tradercjz/dolphindb-mcp-server](https://github.com/tradercjz/dolphindb-mcp-server) 🐍 ☁️ - TDolphinDBデータベース統合。スキーマ検査・クエリ対応
- [weaviate/mcp-server-weaviate](https://github.com/weaviate/mcp-server-weaviate) 🐍 📇 ☁️ - Weaviateコレクションをナレッジベースとして、またチャットメモリストアとしても利用できるMCPサーバー
- [XGenerationLab/xiyan_mcp_server](https://github.com/XGenerationLab/xiyan_mcp_server) 📇 ☁️ — XiyanSQL（text-to-SQL LLM）を利用し自然言語クエリでDBからデータ取得可能なMCPサーバー
- [xing5/mcp-google-sheets](https://github.com/xing5/mcp-google-sheets) 🐍 ☁️ - Google Sheets操作用のModel Context Protocolサーバー。Google Sheets API経由でスプレッドシートの作成・読み書き・管理ツールを提供
- [freema/mcp-gsheets](https://github.com/freema/mcp-gsheets) 📇 ☁️ - Google Sheets API統合用MCPサーバー。包括的な読み書き、フォーマット、シート管理機能付き
- [Zhwt/go-mcp-mysql](https://github.com/Zhwt/go-mcp-mysql) 🏎️ 🏠 – Golang製の使いやすいゼロ依存MySQL MCPサーバー。設定可能な読み取り専用モードとスキーマ検査対応
- [ydb/ydb-mcp](https://github.com/ydb-platform/ydb-mcp) 🎖️ 🐍 ☁️ - [YDB](https://ydb.tech)データベースとの連携用MCPサーバー
- [zilliztech/mcp-server-milvus](https://github.com/zilliztech/mcp-server-milvus) 🐍 🏠 ☁️ - Milvus / Zilliz用MCPサーバー。データベースとのやりとりを実現
- [openlink/mcp-server-jdbc](https://github.com/OpenLinkSoftware/mcp-jdbc-server) 🐍 🏠 - Java Database Connectivity（JDBC）プロトコル経由で汎用DBMSと接続するMCPサーバー
- [yincongcyincong/VictoriaMetrics-mcp-server](https://github.com/yincongcyincong/VictoriaMetrics-mcp-server) 🐍 🏠 - VictoriaMetricsデータベース用MCPサーバー
- [hydrolix/mcp-hydrolix](https://github.com/hydrolix/mcp-hydrolix) 🎖️ 🐍 ☁️ - Hydrolix時系列データレイク統合。LLMベースワークフロー向けスキーマ探索・クエリ機能提供
- [davewind/mysql-mcp-server](https://github.com/dave-wind/mysql-mcp-server) 🏎️ 🏠 – Cursorやn8n向けのユーザーフレンドリーな読み取り専用MySQL MCPサーバー


### 📊 <a name="data-platforms"></a>データプラットフォーム

データ統合・変換・パイプラインオーケストレーションのためのデータプラットフォーム。

- [flowcore/mcp-flowcore-platform](https://github.com/flowcore-io/mcp-flowcore-platform) 🎖️ 📇 ☁️ 🏠 - Flowcoreと連携し、人間の言語で様々なデータコア内やパブリックデータコアのデータ操作・分析・クロスリファレンスを実行
- [JordiNei/mcp-databricks-server](https://github.com/JordiNeil/mcp-databricks-server) 🐍 ☁️ - Databricks APIへの接続。LLMがSQLクエリ実行、ジョブ一覧、ジョブステータス取得可能
- [yashshingvi/databricks-genie-MCP](https://github.com/yashshingvi/databricks-genie-MCP) 🐍 ☁️ - Databricks Genie APIに接続し、LLMによる自然言語質問、SQLクエリ、Databricks対話エージェントとの連携を実現
- [jwaxman19/qlik-mcp](https://github.com/jwaxman19/qlik-mcp) 📇 ☁️ - Qlik Cloud API用MCPサーバー。アプリ・シートのクエリや可視化データ抽出、認証・レート制限対応
- [keboola/keboola-mcp-server](https://github.com/keboola/keboola-mcp-server) 🐍 - Keboola Connection Data Platformとの連携。Keboola Storage APIからのデータ一覧・アクセスツールを提供
- [dbt-labs/dbt-mcp](https://github.com/dbt-labs/dbt-mcp) 🎖️ 🐍 🏠 ☁️ - [dbt (data build tool)](https://www.getdbt.com/product/what-is-dbt)公式MCPサーバー。dbt Core/Cloud CLI、プロジェクトメタデータ発見、モデル情報、セマンティックレイヤークエリに対応
- [mattijsdp/dbt-docs-mcp](https://github.com/mattijsdp/dbt-docs-mcp) 🐍 🏠 - dbt-core（OSS）ユーザー向けMCPサーバー（公式dbt MCPはdbt Cloudのみ対応）。プロジェクトメタデータ、モデル・カラムレベルのリネージ、dbtドキュメントに対応

### 💻 <a name="developer-tools"></a>開発者向けツール

開発ワークフローや環境管理を強化するためのツールや統合。

- [Pratyay/mac-monitor-mcp](https://github.com/Pratyay/mac-monitor-mcp) 🐍 🏠 🍎 - macOS上でリソースを多く消費するプロセスを特定し、パフォーマンス向上の提案を行う
- [21st-dev/Magic-MCP](https://github.com/21st-dev/magic-mcp) - 21st.devのトップデザインエンジニアにインスパイアされたUIコンポーネントを作成
- [Hypersequent/qasphere-mcp](https://github.com/Hypersequent/qasphere-mcp) 🎖️ 📇 ☁️ - [QA Sphere](https://qasphere.com/)テスト管理システムとの連携。LLMがAI搭載IDEからテストケースを直接発見・要約・操作可能
- [admica/FileScopeMCP](https://github.com/admica/FileScopeMCP) 🐍 📇 🦀 - 依存関係解析に基づき重要なファイルを特定し、ダイアグラムや重要度スコアを生成。AIアシスタントによるコードベース理解を支援
- [ambar/simctl-mcp](https://github.com/ambar/simctl-mcp) 📇 🏠 🍎 iOS Simulator制御用MCPサーバー実装
- [api7/apisix-mcp](https://github.com/api7/apisix-mcp) 🎖️ 📇 🏠 [Apache APISIX](https://github.com/apache/apisix)の全リソースのクエリ・管理をサポートするMCPサーバー
- [ArchAI-Labs/fastmcp-sonarqube-metrics](https://github.com/ArchAI-Labs/fastmcp-sonarqube-metrics) 🐍 🏠 🪟 🐧 🍎 - SonarQubeプロジェクトのメトリクス（実績・過去値）、課題、健康状態情報を取得するツール一式を提供するModel Context Protocol（MCP）サーバー
- [automation-ai-labs/mcp-link](https://github.com/automation-ai-labs/mcp-link) 🏎️ 🏠 - 任意のAPIをAIエージェントとシームレスに統合（OpenAPI Schema対応）
- [azer/react-analyzer-mcp](https://github.com/azer/react-analyzer-mcp) 📇 🏠 - Reactコードをローカルで解析し、プロジェクト全体のドキュメント/llm.txtを生成
- [davidlin2k/pox-mcp-server](https://github.com/davidlin2k/pox-mcp-server) 🐍 🏠 - POX SDNコントローラー用MCPサーバー。ネットワーク制御・管理機能を提供
- [CodeLogicIncEngineering/codelogic-mcp-server](https://github.com/CodeLogicIncEngineering/codelogic-mcp-server) 🎖️ 🐍 ☁️ 🍎 🪟 🐧 - CodeLogic公式MCPサーバー。コード依存性分析、アーキテクチャリスク分析、インパクトアセスメントツールを提供
- [Comet-ML/Opik-MCP](https://github.com/comet-ml/opik-mcp) 🎖️ 📇 ☁️ 🏠 - Opikで取得したLLMオブザーバビリティ、トレース、モニタリングデータを自然言語で探索
- [CircleCI/mcp-server-circleci](https://github.com/CircleCI-Public/mcp-server-circleci) 📇 ☁️ AIエージェントによるCircleCIのビルド失敗修正を可能に
- [currents-dev/currents-mcp](https://github.com/currents-dev/currents-mcp) 🎖️ 📇 ☁️ AIエージェントによる[Currents](https://currents.dev)のPlaywrightテスト失敗修正を可能に
- [delano/postman-mcp-server](https://github.com/delano/postman-mcp-server) 📇 ☁️ - [Postman API](https://www.postman.com/postman/postman-public-workspace/)との連携
- [flipt-io/mcp-server-flipt](https://github.com/flipt-io/mcp-server-flipt) 📇 🏠 - [Flipt](https://flipt.io)のフィーチャーフラグをAIアシスタントから操作可能に
- [GLips/Figma-Context-MCP](https://github.com/GLips/Figma-Context-MCP) 📇 🏠 - Figmaデータに直接アクセスし、コーディングエージェントによるワンショットデザイン実装を支援
- [gofireflyio/firefly-mcp](https://github.com/gofireflyio/firefly-mcp) 🎖️ 📇 ☁️ - [Firefly](https://firefly.ai)との統合。クラウドリソースの発見・管理・コーディング化を実現
- [Govcraft/rust-docs-mcp-server](https://github.com/Govcraft/rust-docs-mcp-server) 🦀 🏠 - LLM向けに特定Rustクレートの最新ドキュメントコンテキストをMCPツール経由で提供。セマンティック検索（埋め込み）とLLM要約を活用
- [haris-musa/excel-mcp-server](https://github.com/haris-musa/excel-mcp-server) 🐍 🏠 - Excelワークブックの作成、データ操作、書式設定、チャートやピボットテーブル、数式など高度な機能を備えたExcel操作サーバー
- [higress-group/higress-ops-mcp-server](https://github.com/higress-group/higress-ops-mcp-server) 🐍 🏠 - [Higress](https://github.com/alibaba/higress) ゲートウェイの構成と運用を管理するための包括的なツールを提供するMCPサーバー。
- [hijaz/postmancer](https://github.com/hijaz/postmancer) 📇 🏠 - LLMがAPIコレクションを保持・利用できるようにすることで、Postman/InsomniaのようなRestクライアントの代替となるMCPサーバー。
- [hloiseaufcms/mcp-gopls](https://github.com/hloiseaufcms/mcp-gopls) 🏎️ 🏠 - [GoのLanguage Server Protocol (gopls)](https://github.com/golang/tools/tree/master/gopls)と連携し、高度なGoコード解析機能を活用できるMCPサーバー。
- [hungthai1401/bruno-mcp](https://github.com/hungthai1401/bruno-mcp) 📇 🏠 - [Bruno API Client](https://www.usebruno.com/)と連携するためのMCPサーバー。
- [hyperb1iss/droidmind](https://github.com/hyperb1iss/droidmind) 🐍 🏠 - MCPを通じてAIでAndroidデバイスを制御し、デバイス制御、デバッグ、システム解析、UI自動化を包括的なセキュリティフレームワークで実現。
- [XixianLiang/HarmonyOS-mcp-server](https://github.com/XixianLiang/HarmonyOS-mcp-server) 🐍 🏠 - MCPを通じてAIでHarmonyOS-nextデバイスを制御。デバイス制御とUI自動化をサポート。
- [IlyaGulya/gradle-mcp-server](https://github.com/IlyaGulya/gradle-mcp-server) 🏠 - Gradle Tooling APIを用いたGradle統合。プロジェクトの検査、タスク実行、テストとテストごとの結果レポートを提供。
- [InhiblabCore/mcp-image-compression](https://github.com/InhiblabCore/mcp-image-compression) 🐍 🏠 - 様々な画像フォーマットのローカル圧縮を行うMCPサーバー。
- [isaacphi/mcp-language-server](https://github.com/isaacphi/mcp-language-server) 🏎️ 🏠 - MCP Language Serverは、MCP対応クライアントが定義取得、参照、リネーム、診断などのセマンティックツールを利用してコードベースをより簡単にナビゲートできるよう支援。
- [ios-simulator-mcp](https://github.com/joshuayoes/ios-simulator-mcp) 📇 🏠 🍎 - iOSシミュレータと連携するModel Context Protocol (MCP) サーバー。シミュレータ情報取得、UI操作、UI要素の検査が可能。
- [InditexTech/mcp-server-simulator-ios-idb](https://github.com/InditexTech/mcp-server-simulator-ios-idb) 📇 🏠 🍎 - LLMが自然言語コマンドでiOSシミュレータ（iPhone、iPad等）と連携できるModel Context Protocol (MCP) サーバー。
- [IvanAmador/vercel-ai-docs-mcp](https://github.com/IvanAmador/vercel-ai-docs-mcp) 📇 🏠 - Vercel AI SDKドキュメントのAIによる検索・クエリ機能を提供するModel Context Protocol (MCP) サーバー。
- [j4c0bs/mcp-server-sql-analyzer](https://github.com/j4c0bs/mcp-server-sql-analyzer) 🐍 - [SQLGlot](https://github.com/tobymao/sqlglot)を利用したSQL解析、リンティング、方言変換を行うMCPサーバー。
- [jasonjmcghee/claude-debugs-for-you](https://github.com/jasonjmcghee/claude-debugs-for-you) 📇 🏠 - 言語非依存の自動デバッグ（ブレークポイント・式評価）を可能にするMCPサーバー兼VS Code拡張機能。
- [jetbrains/mcpProxy](https://github.com/JetBrains/mcpProxy) 🎖️ 📇 🏠 - JetBrains IDEへ接続
- [qainsights/jmeter-mcp-server](https://github.com/QAInsights/jmeter-mcp-server) 🐍 🏠 - パフォーマンステスト用JMeter MCPサーバー
- [Jktfe/serveMyAPI](https://github.com/Jktfe/serveMyAPI) 📇 🏠 🍎 - macOSキーチェーンを利用し、複数プロジェクトでAPIキーを安全に保存・アクセスする個人用MCP（Model Context Protocol）サーバー。
- [joshuarileydev/app-store-connect-mcp-server](https://github.com/JoshuaRileyDev/app-store-connect-mcp-server) 📇 🏠 - iOS開発者向けApp Store Connect APIと通信するMCPサーバー
- [joshuarileydev/simulator-mcp-server](https://github.com/JoshuaRileyDev/simulator-mcp-server) 📇 🏠 - iOSシミュレータを制御するMCPサーバー
- [qainsights/k6-mcp-server](https://github.com/QAInsights/k6-mcp-server) 🐍 🏠 - パフォーマンステスト用Grafana k6 MCPサーバー
- [lamemind/mcp-server-multiverse](https://github.com/lamemind/mcp-server-multiverse) 📇 🏠 🛠️ - 複数の独立したインスタンスを固有のネームスペース・設定で共存可能にするMCPサーバー用ミドルウェア。
- [langfuse/mcp-server-langfuse](https://github.com/langfuse/mcp-server-langfuse) 🐍 🏠 - [Langfuse](https://langfuse.com/docs/prompts/get-started) で作成したLLMアプリケーションプロンプトへアクセス・管理するためのMCPサーバー。
- [mobile-next/mobile-mcp](https://github.com/mobile-next/mobile-mcp) 📇 🏠 🐧 🍎 - Android/iOSアプリ・デバイス自動化、開発、アプリスクレイピング用MCPサーバー。iPhone、Google Pixel、Samsung等シミュレータ/エミュレータ/実機対応。
- [qainsights/locust-mcp-server](https://github.com/QAInsights/locust-mcp-server) 🐍 🏠 - パフォーマンステスト用Locust MCPサーバー
- [mrexodia/user-feedback-mcp](https://github.com/mrexodia/user-feedback-mcp) 🐍 🏠 - ClineやCursorのようなツールで人間を介在させるワークフローを可能にするシンプルなMCPサーバー。
- [narumiruna/gitingest-mcp](https://github.com/narumiruna/gitingest-mcp) 🐍 🏠 - [gitingest](https://github.com/cyclotruc/gitingest)を利用し、任意のGitリポジトリをコードベースの簡易テキストダイジェストに変換するMCPサーバー。
- [OctoMind-dev/octomind-mcp](https://github.com/OctoMind-dev/octomind-mcp) 📇 ☁️ - AIエージェントが[Octomind](https://www.octomind.dev/)のエンドツーエンドテストをコードベースやJira、Slack、TestRailなどのデータソースから作成・実行できるようにする。
- [kadykov/mcp-openapi-schema-explorer](https://github.com/kadykov/mcp-openapi-schema-explorer) 📇 ☁️ 🏠 - OpenAPI/Swagger仕様へMCPリソース経由でトークン効率良くアクセス。
- [pskill9/website-downloader](https://github.com/pskill9/website-downloader) 🗄️ 🚀 - このMCPサーバーはwgetでウェブサイト全体をダウンロード可能。サイト構造を保持し、リンクをローカルで動作するように変換。
- [utensils/mcp-nixos](https://github.com/utensils/mcp-nixos) 🐍 🏠 - NixOSパッケージ、システムオプション、Home Manager構成、nix-darwin macOS設定の正確な情報を提供し、AIの幻覚を防ぐMCPサーバー。
- [QuantGeekDev/docker-mcp](https://github.com/QuantGeekDev/docker-mcp) 🏎️ 🏠 - MCP経由でのDockerコンテナ管理・運用
- [ckreiling/mcp-server-docker](https://github.com/ckreiling/mcp-server-docker) 🐍 🏠 - Dockerと連携し、コンテナ、イメージ、ボリューム、ネットワークを管理可能。
- [r-huijts/xcode-mcp-server](https://github.com/r-huijts/xcode-mcp-server) 📇 🏠 🍎 - プロジェクト管理、ファイル操作、ビルド自動化のためのXcode統合
- [ReAPI-com/mcp-openapi](https://github.com/ReAPI-com/mcp-openapi) 📇 🏠 - LLMがOpenAPI仕様を全て把握し、説明やコード/モックデータ生成を行うMCPサーバー
- [Rootly-AI-Labs/Rootly-MCP-server](https://github.com/Rootly-AI-Labs/Rootly-MCP-server) 🎖️ 🐍 ☁️ 🍎 - インシデント管理プラットフォーム[Rootly](https://rootly.com/)用MCPサーバー。
- [sammcj/mcp-package-version](https://github.com/sammcj/mcp-package-version) 📇 🏠 - LLMがコード作成時に最新の安定パッケージバージョンを提案するのを支援するMCPサーバー。
- [sapientpants/sonarqube-mcp-server](https://github.com/sapientpants/sonarqube-mcp-server) 🦀 ☁️ 🏠 - SonarQubeと連携し、AIアシスタントにコード品質指標・問題・品質ゲート状態を提供するModel Context Protocol (MCP) サーバー
- [SDGLBL/mcp-claude-code](https://github.com/SDGLBL/mcp-claude-code) 🐍 🏠 - MCPを用いたClaude Code機能の実装。AIによるコード理解・変更・プロジェクト解析を包括的なツールサポートで実現。
- [snaggle-ai/openapi-mcp-server](https://github.com/snaggle-ai/openapi-mcp-server) 🏎️ 🏠 - Open API spec (v3) を用いて任意のHTTP/REST APIサーバーへ接続
- [stass/lldb-mcp](https://github.com/stass/lldb-mcp) 🐍 🏠 🐧 🍎 - LLDBのMCPサーバー。AIによるバイナリ・コアファイル解析、デバッグ、逆アセンブル対応。
- [TencentEdgeOne/edgeone-pages-mcp](https://github.com/TencentEdgeOne/edgeone-pages-mcp) 📇 ☁️ - HTMLコンテンツをEdgeOne Pagesにデプロイし、公開URLを取得するMCPサービス。
- [tumf/mcp-text-editor](https://github.com/tumf/mcp-text-editor) 🐍 🏠 - 行指向テキストファイルエディタ。効率的な部分ファイルアクセスでトークン使用量を最小限に抑え、LLMツール向けに最適化。
- [vivekvells/mcp-pandoc](https://github.com/vivekVells/mcp-pandoc) 🗄️ 🚀 - Pandocを用いたドキュメントフォーマット変換用MCPサーバー。Markdown、HTML、PDF、DOCX（.docx）、csv等対応。
- [VSCode Devtools](https://github.com/biegehydra/BifrostMCP) 📇 - VSCode IDEへ接続し、`find_usages`等のセマンティックツール利用可能
- [xcodebuild](https://github.com/ShenghaiWang/xcodebuild) 🍎 iOS Xcodeワークスペース/プロジェクトをビルドし、エラーをllmにフィードバック。
- [xzq.xu/jvm-mcp-server](https://github.com/xzq-xu/jvm-mcp-server) 📇 🏠  - JVMベースのMCP（Model Context Protocol）サーバー実装プロジェクト。
- [yangkyeongmo@/mcp-server-apache-airflow](https://github.com/yangkyeongmo/mcp-server-apache-airflow) 🐍 🏠 - 公式クライアントを用いて[Apache Airflow](https://airflow.apache.org/)に接続するMCPサーバー。
- [YuChenSSR/mindmap-mcp-server](https://github.com/YuChenSSR/mindmap-mcp-server) 🐍 🏠 - 美しいインタラクティブマインドマップを生成するModel Context Protocol (MCP) サーバー。
- [YuChenSSR/multi-ai-advisor](https://github.com/YuChenSSR/multi-ai-advisor-mcp) 📇 🏠 - 複数のOllamaモデルにクエリし、回答を統合。1つの質問に多様なAI視点を提供するModel Context Protocol (MCP) サーバー。
- [yWorks/mcp-typescribe](https://github.com/yWorks/mcp-typescribe) 📇 🏠 - Typescript API情報を効率的にエージェントへ提供し、未学習APIとの連携を実現するMCPサーバー
- [zcaceres/fetch-mcp](https://github.com/zcaceres/fetch-mcp) 📇 🏠 - JSON、テキスト、HTMLデータを柔軟に取得するMCPサーバー
- [zenml-io/mcp-zenml](https://github.com/zenml-io/mcp-zenml) 🐍 🏠 ☁️ - [ZenML](https://www.zenml.io) のMLOps・LLMOpsパイプラインと接続するためのMCPサーバー
- [idosal/git-mcp](https://github.com/idosal/git-mcp) 📇 ☁️ - [gitmcp.io](https://gitmcp.io/) は任意の[GitHub](https://www.github.com)リポジトリ/プロジェクトに接続する汎用リモートMCPサーバー（ドキュメント用）
- [tgeselle/bugsnag-mcp](https://github.com/tgeselle/bugsnag-mcp) 📇 ☁️ - [Bugsnag](https://www.bugsnag.com/)と連携するMCPサーバー
- [jordandalton/restcsv-mcp-server](https://github.com/JordanDalton/RestCsvMcpServer) 📇 ☁️ - CSVファイル用のMCPサーバー。
- [cjo4m06/mcp-shrimp-task-manager](https://github.com/cjo4m06/mcp-shrimp-task-manager) 📇 ☁️ 🏠 – Cursor AI等のコーディングエージェントを強化する高機能なタスクメモリ・自己反省・依存関係管理を備えたプログラミング特化型タスク管理システム。[ShrimpTaskManager](https://cjo4m06.github.io/mcp-shrimp-task-manager)
- [axliupore/mcp-code-runner](https://github.com/axliupore/mcp-code-runner) 📇 🏠 - Docker経由でローカルコード実行し、複数言語をサポートするMCPサーバー。
- [yikakia/godoc-mcp-server](https://github.com/yikakia/godoc-mcp-server) 🏎️ ☁️ 🪟 🐧 🍎 - pkg.go.dev上のGoパッケージ情報をクエリ可能
- [ckanthony/gin-mcp](https://github.com/ckanthony/gin-mcp) 🏎️ ☁️ 📟 🪟 🐧 🍎 - 既存のGin WebフレームワークAPIを自動的にMCPツールとして公開するゼロコンフィグGoライブラリ。
- [ryan0204/github-repo-mcp](https://github.com/Ryan0204/github-repo-mcp) 📇 ☁️ 🪟 🐧 🍎 - AIアシスタントがGitHubリポジトリを閲覧・ディレクトリ探索・ファイル内容表示可能にするGitHub Repo MCP。
- [alimo7amed93/webhook-tester-mcp](https://github.com/alimo7amed93/webhook-tester-mcp)  🐍 ☁️ – [webhook-test.com](https://webhook-test.com)と連携するFastMCPベースサーバー。ClaudeでローカルにWebhookの作成・取得・削除が可能。
- [lpigeon/ros-mcp-server](https://github.com/lpigeon/ros-mcp-server) 🐍 🏠 🍎 🪟 🐧 - ユーザー発話の自然言語コマンドをROS/ROS2制御コマンドに変換し、ロボット制御を可能にするROS MCPサーバー。
- [jsdelivr/globalping-mcp-server](https://github.com/jsdelivr/globalping-mcp-server) 🎖️ 📇 ☁️ - ping、traceroute、mtr、HTTP、DNS解決などのネットワークツールを世界中の数千拠点から実行できるGlobalping MCPサーバー。
- [posthog/mcp](https://github.com/posthog/mcp) 🎖️ 📇 ☁️ - PostHogのアナリティクス、フィーチャーフラグ、エラートラッキング等と連携するMCPサーバー。
- [artmann/package-registry-mcp](https://github.com/artmann/package-registry-mcp) 🏠 📇 🍎 🪟 🐧 - NPM、Cargo、PyPi、NuGetパッケージの検索・最新情報取得用MCPサーバー。

### 🔒 <a name="delivery"></a>Delivery

- [https://github.com/jordandalton/doordash-mcp-server](https://github.com/JordanDalton/DoorDash-MCP-Server) 🐍 – DoorDash配達（非公式）

### 🧮 <a name="data-science-tools"></a>Data Science Tools

データ探索・分析を簡素化し、データサイエンスワークフローを強化するための統合・ツール。

- [ChronulusAI/chronulus-mcp](https://github.com/ChronulusAI/chronulus-mcp) 🐍 ☁️ - Chronulus AIによる予測エージェントであらゆるものを予測。
- [reading-plus-ai/mcp-server-data-exploration](https://github.com/reading-plus-ai/mcp-server-data-exploration) 🐍 ☁️ - .csvベースのデータセットで自律的なデータ探索を可能にし、最小限の手間でインテリジェントな洞察を提供。
- [zcaceres/markdownify-mcp](https://github.com/zcaceres/markdownify-mcp) 📇 🏠 - ほぼ全てのファイルやウェブコンテンツをMarkdownに変換するMCPサーバー
- [datalayer/jupyter-mcp-server](https://github.com/datalayer/jupyter-mcp-server) 🐍 🏠 - Jupyter用Model Context Protocol (MCP) サーバー。
- [jjsantos01/jupyter-notebook-mcp](https://github.com/jjsantos01/jupyter-notebook-mcp) 🐍 🏠 - Jupyter NotebookとClaude AIを接続し、Claudeがノートブックを直接操作可能に。
- [arrismo/kaggle-mcp](https://github.com/arrismo/kaggle-mcp) 🐍 ☁️ - Kaggleへ接続し、データセットのダウンロード・分析が可能。
- [kdqed/zaturn](https://github.com/kdqed/zaturn) 🐍 🏠 🪟 🐧 🍎 - 複数データソース（SQL、CSV、Parquet等）を連携し、AIにデータ分析や可視化を依頼可能。
- [mckinsey/vizro-mcp](https://github.com/mckinsey/vizro/tree/main/vizro-mcp) 🎖️ 🐍 🏠 - 検証済みでメンテナンスしやすいデータチャート・ダッシュボード作成のためのツール・テンプレート。
- [growthbook/growthbook-mcp](https://github.com/growthbook/growthbook-mcp) 🎖️ 📇 🏠 🪟 🐧 🍎 — GrowthBookのフィーチャーフラグ・実験を作成・操作するためのツール。

### 📟 <a name="embedded-system"></a>Embedded System

組込みデバイス作業のためのドキュメントおよびショートカットへのアクセスを提供。

- [horw/esp-mcp](https://github.com/horw/esp-mcp) 📟 - ESP-IDFを用いたESP32シリーズチップのビルド問題解決ワークフロー。
- [kukapay/modbus-mcp](https://github.com/kukapay/modbus-mcp) 🐍 📟 - 産業用Modbusデータを標準化・コンテキスト化するMCPサーバー。
- [kukapay/opcua-mcp](https://github.com/kukapay/opcua-mcp) 🐍 📟 - OPC UA対応産業システムに接続するMCPサーバー。
- [yoelbassin/gnuradioMCP](https://github.com/yoelbassin/gnuradioMCP) 🐍 📟 🏠 - LLMがRF `.grc` フローチャートを自律的に作成・修正できるGNU Radio用MCPサーバー。

### 📂 <a name="file-systems"></a>File Systems

指定ディレクトリ内でのファイル読込・書込・管理が可能な、権限設定可能なローカルファイルシステムへの直接アクセスを提供。

- [cyberchitta/llm-context.py](https://github.com/cyberchitta/llm-context.py) 🐍 🏠 - コードコンテキストをMCPまたはクリップボード経由でLLMと共有
- [exoticknight/mcp-file-merger](https://github.com/exoticknight/mcp-file-merger) 🏎️ 🏠 - AIチャット長制限にも適したファイル結合ツール。
- [filesystem@quarkiverse/quarkus-mcp-servers](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/filesystem) ☕ 🏠 - Java/Quarkus実装のファイルシステムでファイル閲覧・編集が可能。jarまたはネイティブイメージで提供。
- [hmk/box-mcp-server](https://github.com/hmk/box-mcp-server) 📇 ☁️ - ファイルの一覧表示、読み取り、検索のためのBox統合
- [mamertofabian/mcp-everything-search](https://github.com/mamertofabian/mcp-everything-search) 🐍 🏠 🪟 - Everything SDKを使用した高速なWindowsファイル検索
- [mark3labs/mcp-filesystem-server](https://github.com/mark3labs/mcp-filesystem-server) 🏎️ 🏠 - ローカルファイルシステムアクセスのためのGolang実装
- [mickaelkerjean/filestash](https://github.com/mickael-kerjean/filestash/tree/master/server/plugin/plg_handler_mcp) 🏎️ ☁️ - リモートストレージアクセス: SFTP、S3、FTP、SMB、NFS、WebDAV、GIT、FTPS、gcloud、azure blob、sharepointなど
- [microsoft/markitdown](https://github.com/microsoft/markitdown/tree/main/packages/markitdown-mcp) 🎖️ 🐍 🏠 - MCPツールによるMarkItDownへのアクセス。MarkItDownは多くのファイル形式（ローカルまたはリモート）をMarkdownへ変換し、LLMでの利用を可能にするライブラリです。
- [modelcontextprotocol/server-filesystem](https://github.com/modelcontextprotocol/servers/tree/main/src/filesystem) 📇 🏠 - ローカルファイルシステムへの直接アクセス
- [modelcontextprotocol/server-google-drive](https://github.com/modelcontextprotocol/servers/tree/main/src/gdrive) 📇 ☁️ - Google Driveとの連携によるファイルの一覧表示、読み取り、検索
- [Xuanwo/mcp-server-opendal](https://github.com/Xuanwo/mcp-server-opendal) 🐍 🏠 ☁️ - Apache OpenDAL™であらゆるストレージへアクセス
- [jeannier/homebrew-mcp](https://github.com/jeannier/homebrew-mcp) 🐍 🏠 🍎 - このMCPサーバーを介し、自然言語でmacOS Homebrewのセットアップを操作。パッケージ管理、提案の取得、brewのトラブルシュートなどが簡単に可能。

### 💰 <a name="finance--fintech"></a>金融・フィンテック

金融データへのアクセスや分析ツール。AIモデルが市場データ、取引プラットフォーム、金融情報と連携できるようにします。

- [aaronjmars/web3-research-mcp](https://github.com/aaronjmars/web3-research-mcp) 📇 ☁️ - 暗号通貨のためのディープリサーチ。無料かつ完全ローカル
- [alchemy/alchemy-mcp-server](https://github.com/alchemyplatform/alchemy-mcp-server) 🎖️ 📇 ☁️ - AIエージェントがAlchemyのブロックチェーンAPIと連携できるようにする
- [OctagonAI/octagon-mcp-server](https://github.com/OctagonAI/octagon-mcp-server) 🐍 ☁️ - Octagon AIエージェントにより、プライベートおよびパブリックな市場データと統合
- [anjor/coinmarket-mcp-server](https://github.com/anjor/coinmarket-mcp-server) 🐍 ☁️ - Coinmarket API統合により暗号通貨のリストと価格を取得
- [ariadng/metatrader-mcp-server](https://github.com/ariadng/metatrader-mcp-server) 🐍 🏠 🪟 - AI LLMがMetaTrader 5プラットフォームで取引実行可能
- [armorwallet/armor-crypto-mcp](https://github.com/armorwallet/armor-crypto-mcp) 🐍 ☁️ - 複数ブロックチェーン、ステーキング、DeFi、スワップ、ブリッジ、ウォレット管理、DCA、リミットオーダー、コイン検索、トラッキング等に対応するMCP
- [bankless/onchain-mcp](https://github.com/Bankless/onchain-mcp/) 📇 ☁️ - スマートコントラクトとのやりとりや取引・トークン情報の取得ができるBankless Onchain API
- [base/base-mcp](https://github.com/base/base-mcp) 🎖️ 📇 ☁️ - Base Network及びCoinbase APIと連携し、ウォレット管理、資金移動、スマートコントラクト、DeFi操作を実現するオンチェーンツールのBase Network統合
- [berlinbra/alpha-vantage-mcp](https://github.com/berlinbra/alpha-vantage-mcp) 🐍 ☁️ - Alpha Vantage API統合により株式と暗号通貨両方の情報を取得
- [ahnlabio/bicscan-mcp](https://github.com/ahnlabio/bicscan-mcp) 🎖️ 🐍 ☁️ - EVMブロックチェーンアドレス（EOA, CA, ENS）やドメイン名のリスクスコア/資産保有状況
- [bitteprotocol/mcp](https://github.com/BitteProtocol/mcp) 📇 - 複数ブロックチェーン上でAIエージェントを実行できるBitte Protocol統合
- [chargebee/mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ - AIエージェントと[Chargebeeプラットフォーム](https://www.chargebee.com/)を接続するMCPサーバー
- [codex-data/codex-mcp](https://github.com/Codex-Data/codex-mcp) 🎖️ 📇 ☁️ - 60以上のネットワークでリアルタイムブロックチェーン・市場データを提供する[Codex API](https://www.codex.io)連携
- [coinpaprika/dexpaprika-mcp](https://github.com/chargebee/agentkit/tree/main/modelcontextprotocol) 🎖️ 📇 ☁️ 🍎 🪟 🐧 - CoinpaprikaのDexPaprika MCPサーバーは、高パフォーマンスな[DexPaprika API](https://docs.dexpaprika.com)を提供し、20+チェーン・500万+トークンのリアルタイム価格、流動性プール、過去データへAIエージェントが標準的にアクセス可能
- [doggybee/mcp-server-ccxt](https://github.com/doggybee/mcp-server-ccxt) 📇 ☁️ - CCXTライブラリを用い、20以上の取引所でリアルタイム暗号市場データ取得・取引可能なMCPサーバー。現物・先物・OHLCV・残高・注文等をサポート
- [ferdousbhai/investor-agent](https://github.com/ferdousbhai/investor-agent) 🐍 ☁️ - Yahoo Finance連携で株式市場データやオプション推奨を取得
- [ferdousbhai/tasty-agent](https://github.com/ferdousbhai/tasty-agent) 🐍 ☁️ - TastytradeのAPI統合で取引活動を管理
- [ferdousbhai/wsb-analyst-mcp](https://github.com/ferdousbhai/wsb-analyst-mcp) 🐍 ☁️ - RedditのWallStreetBetsコミュニティの内容分析
- [getalby/nwc-mcp-server](https://github.com/getalby/nwc-mcp-server) 📇 🏠 - Nostr Wallet ConnectによるBitcoin Lightningウォレット連携
- [heurist-network/heurist-mesh-mcp-server](https://github.com/heurist-network/heurist-mesh-mcp-server) 🎖️ ⛅️ 🏠 🐍 - Heurist Meshネットワーク経由で、ブロックチェーン分析、スマートコントラクト監査、トークン評価、オンチェーン操作等のWeb3 AIエージェントにアクセス。DeFi分析、NFT評価、複数チェーンのトランザクション監視も提供
- [intentos-labs/beeper-mcp](https://github.com/intentos-labs/beeper-mcp) 🐍 - BeeperはBSC上の取引（残高/トークン移転、Pancakeswapでのスワップ、リワード受取等）を提供
- [kukapay/blockbeats-mcp](https://github.com/kukapay/blockbeats-mcp) 🐍 ☁️ - BlockBeatsからのブロックチェーンニュースや記事をAIエージェントに届けるMCPサーバー
- [kukapay/bridge-rates-mcp](https://github.com/kukapay/bridge-rates-mcp) 📇 ☁️ - クロスチェーンブリッジレートや最適な転送ルートをリアルタイムでオンチェーンAIエージェントへ提供
- [kukapay/chainlink-feeds-mcp](https://github.com/kukapay/chainlink-feeds-mcp) 📇 ☁️ - Chainlinkの分散型オンチェーン価格フィードへのリアルタイムアクセス
- [kukapay/cointelegraph-mcp](https://github.com/kukapay/cointelegraph-mcp) 🐍 ☁️ - Cointelegraphの最新ニュースへのリアルタイムアクセス
- [kukapay/crypto-feargreed-mcp](https://github.com/kukapay/crypto-feargreed-mcp) 🐍 ☁️ - Crypto Fear & Greed Indexのリアルタイム・過去データ提供
- [kukapay/crypto-indicators-mcp](https://github.com/kukapay/crypto-indicators-mcp) 🐍 ☁️ - 暗号通貨のテクニカル指標や戦略を提供するMCPサーバー
- [kukapay/crypto-news-mcp](https://github.com/kukapay/crypto-news-mcp) 🐍 ☁️ - NewsDataを情報源とするリアルタイム暗号通貨ニュースMCPサーバー
- [kukapay/crypto-portfolio-mcp](https://github.com/kukapay/crypto-portfolio-mcp) 🐍 ☁️ - 暗号資産ポートフォリオ管理・トラッキング用MCPサーバー
- [kukapay/crypto-rss-mcp](https://github.com/kukapay/crypto-rss-mcp) 🐍 ☁️ - 複数RSSフィードから暗号通貨ニュースをリアルタイム集約するMCPサーバー
- [kukapay/crypto-sentiment-mcp](https://github.com/kukapay/crypto-sentiment-mcp) 🐍 ☁️ - 暗号通貨のセンチメント分析をAIエージェントに提供
- [kukapay/crypto-trending-mcp](https://github.com/kukapay/crypto-trending-mcp) 🐍 ☁️ - CoinGeckoでトレンドのトークンを追跡
- [kukapay/crypto-whitepapers-mcp](https://github.com/kukapay/crypto-whitepapers-mcp) 🐍 ☁️ - 暗号ホワイトペーパーの構造化ナレッジベースとして機能
- [kukapay/cryptopanic-mcp-server](https://github.com/kukapay/cryptopanic-mcp-server) 🐍 ☁️ - CryptoPanic提供の最新暗号通貨ニュースをAIエージェントに提供
- [kukapay/defi-yields-mcp](https://github.com/kukapay/defi-yields-mcp) 🐍 ☁️ - DeFi利回り機会をAIエージェントが探索するためのMCPサーバー
- [kukapay/dune-analytics-mcp](https://github.com/kukapay/dune-analytics-mcp) 🐍 ☁️ - Dune AnalyticsデータをAIエージェントに橋渡しするMCPサーバー
- [kukapay/etf-flow-mcp](https://github.com/kukapay/etf-flow-mcp) 🐍 ☁️ - 暗号ETFフローのデータをAIエージェントの意思決定に提供
- [kukapay/freqtrade-mcp](https://github.com/kukapay/freqtrade-mcp) 🐍 ☁️ - Freqtrade暗号取引ボットと連携するMCPサーバー
- [kukapay/funding-rates-mcp](https://github.com/kukapay/funding-rates-mcp) 🐍 ☁️ - 主要暗号取引所の資金調達レートをリアルタイム提供
- [kukapay/jupiter-mcp](https://github.com/kukapay/jupiter-mcp) 🐍 ☁️ - Solanaブロックチェーン上でJupiterのUltra APIを使ってトークンスワップを実行するMCPサーバー
- [kukapay/pancakeswap-poolspy-mcp](https://github.com/kukapay/pancakeswap-poolspy-mcp) 🐍 ☁️ - Pancake Swap上で新規作成されたプールをトラッキングするMCPサーバー
- [kukapay/rug-check-mcp](https://github.com/kukapay/rug-check-mcp) 🐍 ☁️ - Solanaミームトークンのリスク検出用MCPサーバー
- [kukapay/thegraph-mcp](https://github.com/kukapay/thegraph-mcp) 🐍 ☁️ - The Graphのインデックス済みブロックチェーンデータでAIエージェントを強化
- [kukapay/token-minter-mcp](https://github.com/kukapay/token-minter-mcp) 🐍 ☁️ - ERC-20トークンを複数ブロックチェーンで発行するためのツールをAIエージェントに提供
- [kukapay/token-revoke-mcp](https://github.com/kukapay/token-revoke-mcp) 🐍 ☁️ - 複数ブロックチェーンにおけるERC-20トークン許可確認・取り消し用MCPサーバー
- [kukapay/twitter-username-changes-mcp](https://github.com/kukapay/twitter-username-changes-mcp) 🐍 ☁️ - Twitterユーザー名の変更履歴をトラッキングするMCPサーバー
- [kukapay/uniswap-poolspy-mcp](https://github.com/kukapay/uniswap-poolspy-mcp) 🐍 ☁️ - 複数ブロックチェーン上で新規作成されたUniswap流動性プールを追跡するMCPサーバー
- [kukapay/uniswap-trader-mcp](https://github.com/kukapay/uniswap-trader-mcp) 🐍 ☁️ - 複数ブロックチェーンでUniswap DEX上のトークンスワップを自動化するAIエージェント向けMCPサーバー
- [kukapay/whale-tracker-mcp](https://github.com/kukapay/whale-tracker-mcp) 🐍 ☁️ - 暗号通貨クジラのトランザクションを追跡するMCPサーバー
- [laukikk/alpaca-mcp](https://github.com/laukikk/alpaca-mcp) 🐍 ☁️ - Alpaca取引APIで株式・暗号資産のポートフォリオ管理、取引、マーケットデータ取得を行うMCPサーバー
- [longportapp/openapi](https://github.com/longportapp/openapi/tree/main/mcp) - 🐍 ☁️ - LongPort OpenAPIによりリアルタイム株式市場データ提供、MCP経由でAIによる分析・取引が可能
- [mcpdotdirect/evm-mcp-server](https://github.com/mcpdotdirect/evm-mcp-server) 📇 ☁️ - 30以上のEVMネットワークに対応し、ネイティブトークン、ERC20、NFT、スマートコントラクト、トランザクション、ENS解決など包括的なブロックチェーンサービス
- [mcpdotdirect/starknet-mcp-server](https://github.com/mcpdotdirect/starknet-mcp-server) 📇 ☁️ - Starknetブロックチェーン統合。ネイティブトークン(ETH, STRK)、スマートコントラクト、StarknetID解決、トークン送信等に対応
- [minhyeoky/mcp-server-ledger](https://github.com/minhyeoky/mcp-server-ledger) 🐍 🏠 - ledger-cliによる財務取引管理・レポート生成
- [openMF/mcp-mifosx](https://github.com/openMF/mcp-mifosx) ☁️ 🏠 - クライアント・ローン・預金・シェア・取引管理や財務レポート生成のためのコアバンキング統合
- [narumiruna/yfinance-mcp](https://github.com/narumiruna/yfinance-mcp) 🐍 ☁️ - yfinanceを利用してYahoo Financeの情報を取得するMCPサーバー
- [polygon-io/mcp_polygon)](https://github.com/polygon-io/mcp_polygon)) 🐍 ☁️ - [Polygon.io](https://polygon.io/)金融市場データAPI（株式・指数・FX・オプション等）へアクセスするMCPサーバー
- [pwh-pwh/coin-mcp-server](https://github.com/pwh-pwh/coin-mcp-server) 🐍 ☁️ - Bitget APIによる暗号資産価格取得
- [QuantGeekDev/coincap-mcp](https://github.com/QuantGeekDev/coincap-mcp) 📇 ☁️ - CoinCapのパブリックAPIを用いたリアルタイム暗号市場データ取得。APIキー不要で価格・市場情報へアクセス
- [SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Crypto-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - CoinGecko APIを利用した暗号通貨市場データのMCPツール
- [tooyipjee/yahoofinance-mcp](https://github.com/tooyipjee/yahoofinance-mcp.git) 📇 ☁️ - Yahoo Finance MCPのTypeScript版
- [SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop](https://github.com/SaintDoresh/YFinance-Trader-MCP-ClaudeDesktop.git) 🐍 ☁️ - Yahoo Finance APIを用いた株式市場データ・分析のMCPツール
- [RomThpt/xrpl-mcp-server](https://github.com/RomThpt/mcp-xrpl) 📇 ☁️ - XRP Ledger用のMCPサーバー。アカウント情報・取引履歴・ネットワークデータ取得、台帳オブジェクト検索、トランザクション送信、XRPL監視等が可能
- [janswist/mcp-dexscreener](https://github.com/janswist/mcp-dexscreener) 📇 ☁️ - オープンかつ無料のDexscreener APIによるリアルタイムオンチェーン市場価格
- [HuggingAGI/mcp-baostock-server](https://github.com/HuggingAGI/mcp-baostock-server) 🐍 ☁️ - 中国株式市場データのアクセス・分析のためのbaostockベースのMCPサーバー
- [wowinter13/solscan-mcp](https://github.com/wowinter13/solscan-mcp) 🦀 🏠 - Solscan APIを用い、自然言語でSolanaトランザクションを検索するMCPツール
- [Wuye-AI/mcp-server-wuye-ai](https://github.com/wuye-ai/mcp-server-wuye-ai) 🎖️ 📇 ☁️ - CRIC Wuye AIプラットフォーム（不動産管理業界向け知能アシスタント）の機能と連携するMCPサーバー
- [zlinzzzz/finData-mcp-server](https://github.com/zlinzzzz/finData-mcp-server) 🐍 ☁️ - Tushare等複数データプロバイダ対応のプロ向け金融データ用MCPサーバー

### 🎮 <a name="gaming"></a>ゲーム

ゲーム関連データ、ゲームエンジン、サービスとの統合

- [IvanMurzak/Unity-MCP](https://github.com/IvanMurzak/Unity-MCP) #️⃣ 🏠 🍎 🪟 🐧 - UnityエディタおよびUnity製ゲーム用MCPサーバー
- [CoderGamester/mcp-unity](https://github.com/CoderGamester/mcp-unity) #️⃣ 🏠 - Unity3dゲームエンジン連携によるゲーム開発用MCPサーバー
- [Coding-Solo/godot-mcp](https://github.com/Coding-Solo/godot-mcp) 📇 🏠 - Godotゲームエンジンとの連携用MCPサーバー。Godotプロジェクトの編集・実行・デバッグ・シーン管理ツールを提供
- [pab1ito/chess-mcp](https://github.com/pab1it0/chess-mcp) 🐍 ☁️ - Chess.comのプレイヤーデータ・対局記録・公開情報を標準化MCPインターフェース経由で取得し、AIアシスタントによる検索・分析を可能に
- [jiayao/mcp-chess](https://github.com/jiayao/mcp-chess) 🐍 🏠 - LLMと対局できるチェスMCPサーバー
- [rishijatia/fantasy-pl-mcp](https://github.com/rishijatia/fantasy-pl-mcp/) 🐍 ☁️ - Fantasy Premier Leagueのリアルタイムデータ・分析ツール用MCPサーバー
- [opgginc/opgg-mcp](https://github.com/opgginc/opgg-mcp) 📇 ☁️ - League of Legends、TFT、VALORANTなど人気タイトルのゲーミングデータ、チャンピオン分析、eスポーツ日程、メタ構成、キャラ統計等のリアルタイムアクセス
- [stefan-xyz/mcp-server-runescape](https://github.com/stefan-xyz/mcp-server-runescape) 📇 - RuneScape（RS）・Old School RuneScape（OSRS）データ（アイテム価格、プレイヤーハイスコア等）連携用MCPサーバー

### 🧠 <a name="knowledge--memory"></a>知識・記憶

知識グラフ構造を用いた永続的な記憶ストレージ。AIモデルがセッションをまたいで構造化情報を保持・クエリ可能。
- [CheMiguel23/MemoryMesh](https://github.com/CheMiguel23/MemoryMesh) 📇 🏠 - AIのロールプレイやストーリー生成に特化した、拡張型グラフベースメモリー
- [graphlit-mcp-server](https://github.com/graphlit/graphlit-mcp-server) 📇 ☁️ - Slack、Discord、ウェブサイト、Google Drive、Linear、GitHubなどからGraphlitプロジェクトへ情報を取り込み、Cursor、Windsurf、ClineのようなMCPクライアントで関連知識を検索・取得可能
- [hannesrudolph/mcp-ragdocs](https://github.com/hannesrudolph/mcp-ragdocs) 🐍 🏠 - ベクトル検索によるドキュメントの取得・処理ツールを提供するMCPサーバー実装。AIアシスタントが関連ドキュメント文脈で回答を強化できる
- [jinzcdev/markmap-mcp-server](https://github.com/jinzcdev/markmap-mcp-server) 📇 🏠 - [markmap](https://github.com/markmap/markmap) 上に構築されたMCPサーバー。**Markdown**をインタラクティブな**マインドマップ**へ変換。多形式エクスポート（PNG/JPG/SVG）、ライブブラウザプレビュー、ワンクリックMarkdownコピー、動的可視化に対応
- [kaliaboi/mcp-zotero](https://github.com/kaliaboi/mcp-zotero) 📇 ☁️ - LLMがZotero Cloudのコレクションやソースと連携できるコネクタ
- [mcp-summarizer](https://github.com/0xshellming/mcp-summarizer) 📕 ☁️ - AI要約MCPサーバー。プレーンテキスト、ウェブページ、PDFドキュメント、EPUB書籍、HTMLコンテンツなど多様なコンテンツタイプをサポート
- [mem0ai/mem0-mcp](https://github.com/mem0ai/mem0-mcp) 🐍 🏠 - Mem0向けModel Context Protocolサーバー。コーディングの好みやパターン管理、コード実装やベストプラクティス、技術ドキュメントの保存・取得・意味的処理ツールをCursorやWindsurf等のIDEで提供
- [modelcontextprotocol/server-memory](https://github.com/modelcontextprotocol/servers/tree/main/src/memory) 📇 🏠 - 文脈維持用の知識グラフベースの永続メモリーシステム
- [pinecone-io/assistant-mcp](https://github.com/pinecone-io/assistant-mcp) 🎖️ 🦀 ☁️ - Pinecone Assistantと連携し、エージェントへナレッジエンジンからの文脈を提供
- [@ragieai/mcp-server](https://github.com/ragieai/ragie-mcp-server) 📇 ☁️ - [Ragie](https://www.ragie.ai)（RAG）ナレッジベースからGoogle Drive、Notion、JIRAなどの連携を通じて文脈を取得
- [TechDocsStudio/biel-mcp](https://github.com/TechDocsStudio/biel-mcp) 📇 ☁️ - Cursor、VS Code、Claude DesktopなどAIツールが製品ドキュメントで質問に回答できるように。Biel.aiがRAGシステムとMCPサーバーを提供
- [topoteretes/cognee](https://github.com/topoteretes/cognee/tree/dev/cognee-mcp) 📇 🏠 - 30以上のデータソース取り込み対応、様々なグラフ・ベクトルストアを活用したAIアプリ・エージェント向けメモリーマネージャ
- [unibaseio/membase-mcp](https://github.com/unibaseio/membase-mcp) 📇 ☁️ - Membaseによる分散型エージェントメモリーの保存とクエリ
- [GistPad-MCP](https://github.com/lostintangent/gistpad-mcp) 📇 🏠 - GitHub Gistで個人知識、日々のノート、再利用可能なプロンプトを管理・アクセス。[GistPad VS Code拡張](https://aka.ms/gistpad)およびhttps://gistpad.dev のコンパニオン
- [entanglr/zettelkasten-mcp](https://github.com/entanglr/zettelkasten-mcp) 🐍 🏠 - Zettelkasten知識管理手法を実装したModel Context Protocol(MCP)サーバー。Claude等MCP互換クライアントでアトミックノートの作成・リンク・検索が可能

### 🗺️ <a name="location-services"></a>ロケーションサービス

位置情報サービスと地図ツール。AIモデルが地理データ、天気情報、位置ベース分析を扱うのを支援。

- [briandconnelly/mcp-server-ipinfo](https://github.com/briandconnelly/mcp-server-ipinfo) 🐍 ☁️  - IPInfo APIを利用したIPアドレスのジオロケーションおよびネットワーク情報
- [devilcoder01/weather-mcp-server](https://github.com/devilcoder01/weather-mcp-server) 🐍 ☁️ - WeatherAPI.com APIを使い、任意の場所のリアルタイム天気データ・詳細な予報・現況を取得
- [jagan-shanmugam/open-streetmap-mcp](https://github.com/jagan-shanmugam/open-streetmap-mcp) 🐍 🏠 - 位置情報サービスと地理空間データを提供するOpenStreetMap MCPサーバー
- [kukapay/nearby-search-mcp](https://github.com/kukapay/nearby-search-mcp) 🐍 ☁️ - IPベースの位置検出で周辺施設検索を行うMCPサーバー
- [modelcontextprotocol/server-google-maps](https://github.com/modelcontextprotocol/servers/tree/main/src/google-maps) 📇 ☁️ - Google Maps連携による位置サービス、ルーティング、施設情報
- [QGIS MCP](https://github.com/jjsantos01/qgis_mcp) - QGIS DesktopとClaude AIをMCPで接続。プロンプト支援のプロジェクト作成、レイヤー読み込み、コード実行などに対応
- [SaintDoresh/Weather-MCP-ClaudeDesktop](https://github.com/SaintDoresh/Weather-MCP-ClaudeDesktop.git) 🐍 ☁️ - OpenWeatherMap API利用のリアルタイム天気データ、予報、過去天気情報を提供するMCPツール
- [rossshannon/Weekly-Weather-mcp](https://github.com/rossshannon/weekly-weather-mcp.git) 🐍 ☁️ - 世界中の任意の場所で7日間の詳細な天気予報を返すWeekly Weather MCPサーバー
- [SecretiveShell/MCP-timeserver](https://github.com/SecretiveShell/MCP-timeserver) 🐍 🏠 - 任意のタイムゾーンの時刻取得と現在のローカル時刻取得
- [TimLukaHorstmann/mcp-weather](https://github.com/TimLukaHorstmann/mcp-weather) 📇 ☁️  - AccuWeather API（無料枠あり）による高精度天気予報
- [webcoderz/MCP-Geo](https://github.com/webcoderz/MCP-Geo) 🐍 🏠 - nominatim、ArcGIS、Bing対応のジオコーディングMCPサーバー
- [ipfind/ipfind-mcp-server](https://github.com/ipfind/ipfind-mcp-server) 🐍 ☁️ - [IP Find](https://ipfind.com) APIを利用したIPアドレス位置サービス
- [mahdin75/geoserver-mcp](https://github.com/mahdin75/geoserver-mcp) 🏠 – LLMをGeoServer REST APIに接続するModel Context Protocol (MCP)サーバー実装。AIアシスタントが地理空間データやサービスとやり取り可能
- [ipfred/aiwen-mcp-server-geoip](https://github.com/ipfred/aiwen-mcp-server-geoip) 🐍 📇 ☁️ – Aiwen IPロケーション用MCPサーバー。ユーザーネットワークIPの位置情報取得、IP詳細（国・都道府県・市・緯度経度・ISP・所有者等）取得

### 🎯 <a name="marketing"></a>マーケティング

マーケティングコンテンツの作成・編集、ウェブメタデータ、プロダクトポジショニング、編集ガイドのためのツール

- [gomarble-ai/facebook-ads-mcp-server](https://github.com/gomarble-ai/facebook-ads-mcp-server) 🐍 ☁️ - Facebook広告用のMCPサーバー。プログラムによるFacebook広告データへのアクセス・管理機能提供
- [open-strategy-partners/osp_marketing_tools](https://github.com/open-strategy-partners/osp_marketing_tools) 🐍 🏠 - Open Strategy Partnersによる、文体・編集コード・プロダクトマーケティング価値マップ作成などのマーケティングツール群
- [nictuku/meta-ads-mcp](https://github.com/nictuku/meta-ads-mcp) 🐍 ☁️ 🏠 - AIエージェントによるMeta広告パフォーマンス監視・最適化、キャンペーン指標分析、ターゲット設定調整、クリエイティブ資産管理、広告費・設定のデータ駆動型推奨をGraph API連携で実現
- [marketplaceadpros/amazon-ads-mcp-server](https://github.com/MarketplaceAdPros/amazon-ads-mcp-server) 📇 ☁️  - Amazon Advertisingと連携し、キャンペーン指標や設定の分析ができるツールを提供

### 📊 <a name="monitoring"></a>モニタリング

アプリケーションモニタリングデータへのアクセスと分析。AIモデルによるエラーレポートやパフォーマンス指標のレビューを実現

- [netdata/netdata#Netdata](https://github.com/netdata/netdata/blob/master/src/web/mcp/README.md) 🎖️ 🏠 ☁️ 📟 🍎 🪟 🐧 - メトリクス、ログ、システム、コンテナ、プロセス、ネットワーク接続を含む全観測データの発見・調査・レポート・根本原因分析
- [grafana/mcp-grafana](https://github.com/grafana/mcp-grafana) 🎖️ 🐍 🏠 ☁️ - Grafanaインスタンスのダッシュボード検索、インシデント調査、データソースクエリ
- [tumf/grafana-loki-mcp](https://github.com/tumf/grafana-loki-mcp) 🐍 🏠 - Grafana API経由でLokiログをクエリできるMCPサーバー
- [hyperb1iss/lucidity-mcp](https://github.com/hyperb1iss/lucidity-mcp) 🐍 🏠 - 複雑さからセキュリティ脆弱性まで10の重要指標でAI生成コード品質を知的にプロンプト分析
- [last9/last9-mcp-server](https://github.com/last9/last9-mcp-server) - 本番環境のリアルタイム文脈（ログ・メトリクス・トレース）をローカルに持ち込み、コード自動修正を高速化
- [metoro-io/metoro-mcp-server](https://github.com/metoro-io/metoro-mcp-server) 🎖️ 🏎️ ☁️ - Metoro監視のKubernetes環境のクエリ・対話
- [MindscapeHQ/server-raygun](https://github.com/MindscapeHQ/mcp-server-raygun) 📇 ☁️ - Raygun API V3連携でクラッシュレポートとリアルユーザーモニタリング
- [modelcontextprotocol/server-sentry](https://github.com/modelcontextprotocol/servers/tree/main/src/sentry) 🐍 ☁️ - Sentry.io連携でエラー追跡・パフォーマンス監視
- [pydantic/logfire-mcp](https://github.com/pydantic/logfire-mcp) 🎖️ 🐍 ☁️ - Logfire経由でOpenTelemetryトレースとメトリクスにアクセス
- [seekrays/mcp-monitor](https://github.com/seekrays/mcp-monitor) 🏎️ 🏠 - Model Context Protocol (MCP)対応のシステムモニタリングツール。LLMがMCPインターフェース経由でリアルタイムシステム情報（CPU、メモリ、ディスク、ネットワーク、ホスト、プロセス）を取得可能
- [VictoriaMetrics-Community/mcp-victoriametrics](https://github.com/VictoriaMetrics-Community/mcp-victoriametrics) 🎖️ 🏎️ 🏠 - [VictoriaMetrics API](https://docs.victoriametrics.com/victoriametrics/url-examples/)と[ドキュメント](https://docs.victoriametrics.com/)に完全対応し、監視・可観測性・デバッグ作業をサポート

### 🎥 <a name="multimedia-process"></a>マルチメディア処理

音声・動画編集、再生、フォーマット変換などのマルチメディア処理機能。動画フィルター、強化等も含む

- [video-creator/ffmpeg-mcp](https://github.com/video-creator/ffmpeg-mcp.git) 🎥 🔊 - ffmpegコマンドライン利用のMCPサーバー。対話を通じてローカル動画の検索、切り出し、結合、再生等を簡便に実現
- [stass/exif-mcp](https://github.com/stass/exif-mcp) 📇 🏠 🐧 🍎 🪟 - EXIF、XMP、JFIF、GPS等の画像メタデータを調査可能なMCPサーバー。LLMによる写真ライブラリ・画像コレクションの検索・分析の基盤を提供
- [sunriseapps/imagesorcery-mcp](https://github.com/sunriseapps/imagesorcery-mcp) 🐍 🏠 🐧 🍎 🪟 - ComputerVisionベースの画像認識・編集ツールをAIアシスタント向けに提供

### 🔎 <a name="search"></a>検索＆データ抽出

- [Xyber-Labs/mcp-server-youtube](https://github.com/Xyber-Labs/mcp-servers/tree/main/mcp-server-youtube) 🐍 ☁️ - YouTube検索とトランスクリプト取得機能をMCP（Model Context Protocol）サーバーで提供。標準化プロトコルでYouTubeコンテンツ検索が可能
- [ricocf/mcp-wolframalpha](https://github.com/ricocf/mcp-wolframalpha) 🐍 🏠 ☁️ - Wolfram Alpha API利用でAIアシスタントがリアルタイム計算知識・データへアクセス
- [scrapeless-ai/scrapeless-mcp-server](https://github.com/scrapeless-ai/scrapeless-mcp-server) 🐍 ☁️ - Scrapeless Model Context ProtocolサービスでGoogle SERP APIへ連携し、MCPエコシステム内でウェブ検索を実現
- [0xdaef0f/job-searchoor](https://github.com/0xDAEF0F/job-searchoor) 📇 🏠 - 日付・キーワード・リモートワーク等のフィルタ付き求人検索用MCPサーバー
- [ac3xx/mcp-servers-kagi](https://github.com/ac3xx/mcp-servers-kagi) 📇 ☁️ - Kagi検索API連携
- [andybrandt/mcp-simple-arxiv](https://github.com/andybrandt/mcp-simple-arxiv) - 🐍 ☁️  MCPでarXivの論文を検索・閲覧
- [hbg/mcp-paperswithcode](https://github.com/hbg/mcp-paperswithcode) - 🐍 ☁️ PapersWithCode API検索用MCP
- [andybrandt/mcp-simple-pubmed](https://github.com/andybrandt/mcp-simple-pubmed) - 🐍 ☁️  MCPでPubMedの医学・生命科学論文を検索・閲覧
- [angheljf/nyt](https://github.com/angheljf/nyt) 📇 ☁️ - NYTimes APIで記事検索
- [apify/mcp-server-rag-web-browser](https://github.com/apify/mcp-server-rag-web-browser) 📇 ☁️ - ApifyオープンソースRAG Web Browser Actor用MCPサーバー。ウェブ検索、URLスクレイピング、Markdownでのコンテンツ返却
- [Bigsy/Clojars-MCP-Server](https://github.com/Bigsy/Clojars-MCP-Server) 📇 ☁️ - Clojureライブラリの依存情報を最新で取得するClojars MCPサーバー
- [blazickjp/arxiv-mcp-server](https://github.com/blazickjp/arxiv-mcp-server) ☁️ 🐍 - ArXiv論文検索
- [luminati-io/brightdata-mcp](https://github.com/luminati-io/brightdata-mcp) 📇 ☁️ - ウェブの発見・抽出・操作を一元化するインターフェース。公開インターネットへの自動アクセスを実現
- [chanmeng/google-news-mcp-server](https://github.com/ChanMeng666/server-google-news) 📇 ☁️ - Google News連携。自動トピック分類、多言語サポート、SerpAPI経由でヘッドライン・記事・関連トピックの総合検索
- [ConechoAI/openai-websearch-mcp](https://github.com/ConechoAI/openai-websearch-mcp/) 🐍 🏠 ☁️ - Python製MCPサーバー。OpenAI `web_search`組込ツール提供
- [dealx/mcp-server](https://github.com/DealExpress/mcp-server) ☁️ - DealXプラットフォーム用MCPサーバー
- [devflowinc/trieve](https://github.com/devflowinc/trieve/tree/main/clients/mcp-server) 🎖️ 📇 ☁️ 🏠 - [Trieve](https://trieve.ai)でデータセットのクロール・埋め込み・分割・検索・取得
- [Dumpling-AI/mcp-server-dumplingai](https://github.com/Dumpling-AI/mcp-server-dumplingai) 🎖️ 📇 ☁️ - [Dumpling AI](https://www.dumplingai.com/)のデータ取得、ウェブスクレイピング、ドキュメント変換APIへアクセス
- [erithwik/mcp-hn](https://github.com/erithwik/mcp-hn) 🐍 ☁️ - Hacker Newsの検索、トップストーリー取得等のMCPサーバー
- [exa-labs/exa-mcp-server](https://github.com/exa-labs/exa-mcp-server) 🎖️ 📇 ☁️ – Model Context Protocol (MCP)サーバーでAIアシスタント（Claude等）にExa AI Search APIを提供し、安全・制御下でリアルタイムWeb情報取得
- [fatwang2/search1api-mcp](https://github.com/fatwang2/search1api-mcp) 📇 ☁️ - search1api経由で検索（有料APIキー要）
- [genomoncology/biomcp](https://github.com/genomoncology/biomcp) 🐍 ☁️ - PubMed、ClinicalTrials.gov、MyVariant.infoへアクセスするバイオメディカルリサーチサーバー
- [hellokaton/unsplash-mcp-server](https://github.com/hellokaton/unsplash-mcp-server)) 🐍 ☁️ - Unsplash画像検索用MCPサーバー
- [Ihor-Sokoliuk/MCP-SearXNG](https://github.com/ihor-sokoliuk/mcp-searxng) 📇 🏠/☁️ - [SearXNG](https://docs.searxng.org)用Model Context Protocolサーバー
- [isnow890/naver-search-mcp](https://github.com/isnow890/naver-search-mcp) 📇 ☁️ - Naver Search API連携MCPサーバー。ブログ・ニュース・ショッピング検索やDataLab分析機能をサポート
- [jae-jae/fetcher-mcp](https://github.com/jae-jae/fetcher-mcp) 📇 🏠 - Playwrightヘッドレスブラウザでウェブページを取得。Javascriptレンダリング・知的コンテンツ抽出・Markdown/HTML出力対応のMCPサーバー
- [jae-jae/g-search-mcp](https://github.com/jae-jae/g-search-mcp) 📇 🏠 - Google検索用の強力なMCPサーバー。複数キーワードの並列検索が可能
- [ananddtyagi/webpage-screenshot-mcp](https://github.com/ananddtyagi/webpage-screenshot-mcp) 📇 🏠 - UI開発時のフィードバック用にウェブページのスクリーンショットを取得するMCPサーバー
- [leehanchung/bing-search-mcp](https://github.com/leehanchung/bing-search-mcp) 📇 ☁️ - Microsoft Bing Search API連携のウェブ検索機能
- [kagisearch/kagimcp](https://github.com/kagisearch/kagimcp) ☁️ 📇 – 公式Kagi Search MCPサーバー
- [kshern/mcp-tavily](https://github.com/kshern/mcp-tavily.git) ☁️ 📇 – Tavily AI検索API
- [mikechao/brave-search-mcp](https://github.com/mikechao/brave-search-mcp) 📇 ☁️ - BraveのSearch APIを利用したWeb、画像、ニュース、動画、およびローカルスポットの検索機能
- [emicklei/melrose-mcp](https://github.com/emicklei/melrose-mcp) 🏎️ 🏠 - [Melrōse](https://melrōse.org)の音楽表現をMIDIとして再生
- [modelcontextprotocol/server-brave-search](https://github.com/modelcontextprotocol/servers/tree/main/src/brave-search) 📇 ☁️ - BraveのSearch APIを用いたWeb検索機能
- [modelcontextprotocol/server-fetch](https://github.com/modelcontextprotocol/servers/tree/main/src/fetch) 🐍 🏠 ☁️ - AI向けの効率的なWebコンテンツの取得および処理
- [mzxrai/mcp-webresearch](https://github.com/mzxrai/mcp-webresearch) 🔍📚 - Google検索および任意のトピックに関するディープウェブリサーチ
- [nickclyde/duckduckgo-mcp-server](https://github.com/nickclyde/duckduckgo-mcp-server) 🐍 ☁️ - DuckDuckGoを利用したWeb検索
- [r-huijts/opentk-mcp](https://github.com/r-huijts/opentk-mcp) 📇 ☁️ - オランダ国会（Tweede Kamer）の情報（文書、討論、活動、法案等）への構造化検索機能（Bert Hubertによるopentkプロジェクトに基づく）
- [reading-plus-ai/mcp-server-deep-research](https://github.com/reading-plus-ai/mcp-server-deep-research) 📇 ☁️ - OpenAI/Perplexityのような自律型ディープリサーチ、構造化クエリエラボレーション、簡潔なレポーティングを提供するMCPサーバー。
- [SecretiveShell/MCP-searxng](https://github.com/SecretiveShell/MCP-searxng) 🐍 🏠 - searXNGインスタンスに接続するためのMCPサーバー
- [takashiishida/arxiv-latex-mcp](https://github.com/takashiishida/arxiv-latex-mcp) 🐍 ☁️ - arXiv論文のLaTeXソースを取得し、数式や数理内容を扱う
- [the0807/GeekNews-MCP-Server](https://github.com/the0807/GeekNews-MCP-Server) 🐍 ☁️ - GeekNewsサイトからニュースデータを取得・処理するMCPサーバー。
- [tinyfish-io/agentql-mcp](https://github.com/tinyfish-io/agentql-mcp) 🎖️ 📇 ☁️ - [AgentQL](https://agentql.com)のデータ抽出機能を提供するMCPサーバー。
- [Tomatio13/mcp-server-tavily](https://github.com/Tomatio13/mcp-server-tavily) ☁️ 🐍 – Tavily AI検索API
- [vectorize-io/vectorize-mcp-server](https://github.com/vectorize-io/vectorize-mcp-server/) ☁️ 📇 - 高度なリトリーバル、プライベートディープリサーチ、Anything-to-Markdownファイル抽出およびテキストチャンク化のための[Vectorize](https://vectorize.io) MCPサーバー。
- [webscraping-ai/webscraping-ai-mcp-server](https://github.com/webscraping-ai/webscraping-ai-mcp-server) 🎖️ 📇 ☁️ - [WebScraping.ai](https://webscraping.ai)と連携し、Webデータ抽出やスクレイピングを実現。
- [zhsama/duckduckgo-mcp-server](https://github.com/zhsama/duckduckgo-mpc-server/) 📇 🏠 ☁️ - DuckDuckGo検索機能を提供するTypeScriptベースのMCPサーバー。
- [zoomeye-ai/mcp_zoomeye](https://github.com/zoomeye-ai/mcp_zoomeye) 📇 ☁️ - ZoomEye MCP Serverによるネットワーク資産情報のクエリ
- [yamanoku/baseline-mcp-server](https://github.com/yamanoku/baseline-mcp-server) 📇 🏠 - Web Platform APIを用いてBaselineステータスを検索するMCPサーバー
- [longevity-genie/biothings-mcp](https://github.com/longevity-genie/biothings-mcp) 🐍 ☁️ - BioThings API（遺伝子、遺伝子変異、薬品、分類学情報など）と連携するMCPサーバー
- [joelio/stocky](https://github.com/joelio/stocky) 🐍 ☁️ 🏠 - PexelsやUnsplashからロイヤリティフリーのストックフォトを検索・ダウンロードするためのMCPサーバー。マルチプロバイダー検索、豊富なメタデータ、ページネーション、AIアシスタント向けの非同期パフォーマンスに対応し、高品質画像の発見・取得が可能。

### 🔒 <a name="security"></a>セキュリティ

- [LaurieWired/GhidraMCP](https://github.com/LaurieWired/GhidraMCP) ☕ 🏠 - Ghidra向けのModel Context Protocolサーバー。LLMがアプリケーションを自律的にリバースエンジニアリングすることを可能にし、バイナリのデコンパイル、メソッドやデータのリネーム、メソッド・クラス・インポート・エクスポート一覧の取得ツールを提供。
- [dkvdm/onepassword-mcp-server](https://github.com/dkvdm/onepassword-mcp-server) - Agentic AIで利用するため、1Passwordから安全に認証情報を取得できるMCPサーバー。
- [firstorderai/authenticator_mcp](https://github.com/firstorderai/authenticator_mcp) 📇 🏠 🍎 🪟 🐧 – AIエージェントがAuthenticatorアプリと連携できるセキュアなMCPサーバー（Model Context Protocol）。
- [13bm/GhidraMCP](https://github.com/13bm/GhidraMCP) 🐍 ☕ 🏠 - GhidraとAIアシスタントを統合するMCPサーバー。バイナリアナリシスを実現し、関数の検査やデコンパイル、メモリ探索、インポート/エクスポート解析などのツールを提供。
- [atomicchonk/roadrecon_mcp_server](https://github.com/atomicchonk/roadrecon_mcp_server) 🐍 🪟 🏠 Azureテナント列挙のROADrecon収集結果を解析するMCPサーバー
- [BurtTheCoder/mcp-dnstwist](https://github.com/BurtTheCoder/mcp-dnstwist) 📇 🪟 ☁️ - dnstwistのMCPサーバー。タイポスクワッティング、フィッシング、企業スパイ活動の検出に役立つ強力なDNSファジングツール。
- [BurtTheCoder/mcp-maigret](https://github.com/BurtTheCoder/mcp-maigret) 📇 🪟 ☁️ - maigretのMCPサーバー。様々な公開情報源からユーザーアカウント情報を収集する強力なOSINTツール。SNS横断検索やURL解析のツールを提供。
- [BurtTheCoder/mcp-shodan](https://github.com/BurtTheCoder/mcp-shodan) 📇 🪟 ☁️ - Shodan APIとShodan CVEDBへのクエリ用MCPサーバー。IP検索、デバイス検索、DNS検索、脆弱性検索、CPE検索などのツールを提供。
- [BurtTheCoder/mcp-virustotal](https://github.com/BurtTheCoder/mcp-virustotal) 📇 🪟 ☁️ - VirusTotal APIへのクエリ用MCPサーバー。URLスキャン、ファイルハッシュ解析、IPアドレスレポート取得のツールを提供。
- [fosdickio/binary_ninja_mcp](https://github.com/fosdickio/binary_ninja_mcp) 🐍 🏠 🍎 🪟 🐧 - [Binary Ninja](https://binary.ninja)とお好みのMCPクライアントをシームレスに統合するプラグイン/MCPサーバー/ブリッジ。バイナリアナリシスやリバースエンジニアリングを自動化可能。
- [fr0gger/MCP_Security](https://github.com/fr0gger/MCP_Security) 📇 ☁️ - ORKL APIのクエリ用MCPサーバー。脅威レポート取得、脅威アクター解析、インテリジェンスソース取得のツールを提供。
- [gbrigandi/mcp-server-cortex](https://github.com/gbrigandi/mcp-server-cortex) 🦀 🏠 🚨 🍎 🪟 🐧 - Cortexを統合するRust製MCPサーバー。観測値分析とAIによる自動セキュリティレスポンスを実現。
- [gbrigandi/mcp-server-thehive](https://github.com/gbrigandi/mcp-server-thehive) 🦀 🏠 🚨 🍎 🪟 🐧 - TheHiveを統合するRust製MCPサーバー。AIによるコラボレーション型セキュリティインシデント対応・ケース管理を実現。
- [gbrigandi/mcp-server-wazuh](https://github.com/gbrigandi/mcp-server-wazuh) 🦀 🏠 🚨 🍎 🪟 🐧 - Wazuh SIEMとAIアシスタントを橋渡しするRust製MCPサーバー。リアルタイムセキュリティアラートやイベントデータを提供し、文脈理解を強化。
- [intruder-io/intruder-mcp](https://github.com/intruder-io/intruder-mcp) 🐍 ☁️ - [Intruder](https://www.intruder.io/)にアクセスするMCPサーバー。インフラの脆弱性の特定・理解・修正を支援。
- [jyjune/mcp_vms](https://github.com/jyjune/mcp_vms) 🐍 🏠 🪟 - CCTV録画プログラム（VMS）に接続し、録画・ライブ映像を取得するModel Context Protocol (MCP)サーバー。特定チャンネルのライブ/再生ダイアログ表示などVMS制御ツールも提供。
- [qianniuspace/mcp-security-audit](https://github.com/qianniuspace/mcp-security-audit) 📇 ☁️ npmパッケージ依存関係のセキュリティ脆弱性を監査する強力なMCPサーバー。リモートnpmレジストリ統合によるリアルタイムチェック対応。
- [semgrep/mcp](https://github.com/semgrep/mcp) 📇 ☁️ [Semgrep](https://semgrep.dev)を利用し、AIエージェントによるコードの脆弱性スキャンを実現。
- [slouchd/cyberchef-api-mcp-server](https://github.com/slouchd/cyberchef-api-mcp-server) 🐍 ☁️ - CyberChefサーバーAPIと連携し、MCPクライアントがCyberChef操作を利用可能にするMCPサーバー。
- [mrexodia/ida-pro-mcp](https://github.com/mrexodia/ida-pro-mcp) 🐍 🏠 - IDA Pro向けMCPサーバー。AIアシスタントによるバイナリアナリシス、デコンパイル、逆アセンブル、マルウェア解析レポート自動生成などを実装。
- [rad-security/mcp-server](https://github.com/rad-security/mcp-server) 📇 ☁️ - RAD Security向けMCPサーバー。Kubernetesやクラウド環境向けにAIによるセキュリティインサイトを提供し、APIクエリやセキュリティ所見の取得等に対応。
- [securityfortech/secops-mcp](https://github.com/securityfortech/secops-mcp) 🐍 🏠 - 人気オープンソースツールを統合するオールインワンのセキュリティテストツールボックス。AIエージェントと連携し、ペンテスト、バグバウンティ、脅威ハンティング等を実現。
- [roadwy/cve-search_mcp](https://github.com/roadwy/cve-search_mcp) 🐍 🏠 - CVE-Search APIへのクエリ用MCPサーバー。ベンダー・製品の閲覧、CVE-IDごとの取得、最新CVEの取得など。
- [StacklokLabs/osv-mcp](https://github.com/StacklokLabs/osv-mcp) 🏎️ ☁️ - OSV（Open Source Vulnerabilities）データベースへのアクセス。パッケージバージョンやコミットによる脆弱性検索、複数パッケージのバッチクエリ、ID指定で詳細取得。
- [nickpending/mcp-recon](https://github.com/nickpending/mcp-recon) 🏎️ 🏠 - httpxとasnmapを活用した会話型リコンインターフェース＆MCPサーバー。ドメイン解析、セキュリティヘッダー、証明書分析、ASNルックアップ等に対応。
- [Gaffx/volatility-mcp](https://github.com/Gaffx/volatility-mcp) - Volatility 3.x向けMCPサーバー。pslistやnetscan等のプラグインをREST APIやLLM経由で利用でき、バリアフリーなメモリフォレンジック分析を実現。
- [co-browser/attestable-mcp-server](https://github.com/co-browser/attestable-mcp-server) 🐍 🏠 ☁️ 🐧 - Gramineを用いて信頼実行環境（TEE）内で動作するMCPサーバー。[RA-TLS](https://gramine.readthedocs.io/en/stable/attestation.html)によるリモートアテステーションを実演し、MCPクライアントが接続前にサーバーを検証可能。
- [zinja-coder/jadx-ai-mcp](https://github.com/zinja-coder/jadx-ai-mcp) ☕ 🏠 - JADXデコンパイラ用のプラグイン＆MCPサーバー。Model Context Protocol（MCP）と直接統合し、Claude等のLLMでライブリバースエンジニアリング支援を提供。
- [zinja-coder/apktool-mcp-server](https://github.com/zinja-coder/apktool-mcp-server) 🐍 🏠 - Apk Toolの自動Android APKリバースエンジニアリング用MCPサーバー。

### 🌐 <a name="social-media"></a>ソーシャルメディア

ソーシャルメディアプラットフォームとの統合により、投稿、分析、インタラクション管理を可能にし、AIによる自動化を実現。

- [macrocosm-os/macrocosmos-mcp](https://github.com/macrocosm-os/macrocosmos-mcp) - 🎖️ 🐍 ☁️ X/Reddit/YouTubeのリアルタイムデータへ直接アクセスし、検索語句、ユーザー、日付フィルタリングが可能。
- [kunallunia/twitter-mcp](https://github.com/LuniaKunal/mcp-twitter) 🐍 🏠 - タイムライン取得、ユーザー投稿取得、ハッシュタグ監視、会話分析、DM、投稿の感情分析、投稿ライフサイクル管理等を統合APIで提供するTwitter管理ソリューション。
- [HagaiHen/facebook-mcp-server](https://github.com/HagaiHen/facebook-mcp-server) 🐍 ☁️ - Facebookページと連携し、投稿・コメント・エンゲージメント指標の管理をGraph API経由で実現。
- [gwbischof/bluesky-social-mcp](https://github.com/gwbischof/bluesky-social-mcp) 🐍 🏠 - atprotoクライアントを用いてBlueskyと連携するMCPサーバー。

### 🏃 <a name="sports"></a>スポーツ

スポーツ関連データ、結果、統計情報へのアクセスツール。

- [mikechao/balldontlie-mcp](https://github.com/mikechao/balldontlie-mcp) 📇 - balldontlie APIと連携し、NBA・NFL・MLBの選手、チーム、試合情報を提供するMCPサーバー
- [r-huijts/firstcycling-mcp](https://github.com/r-huijts/firstcycling-mcp) 📇 ☁️ - サイクリングレースのデータ・結果・統計情報に自然言語でアクセス。firstcycling.comからスタートリスト、レース結果、ライダー情報などを取得。
- [r-huijts/strava-mcp](https://github.com/r-huijts/strava-mcp) 📇 ☁️ - Strava APIと連携し、LLMを通じてStravaデータにアクセスできるModel Context Protocol (MCP)サーバー
- [willvelida/mcp-afl-server](https://github.com/willvelida/mcp-afl-server) ☁️ - Squiggle APIと連携し、オーストラリアンフットボールリーグのチーム情報、順位表、結果、ティップス、パワーランキング等を提供するMCPサーバー
- [guillochon/mlb-api-mcp](https://github.com/guillochon/mlb-api-mcp) 🐍 🏠 - MLB APIのプロキシとして機能し、選手情報、統計、試合情報を提供するMCPサーバー。

### 🎧 <a name="support-and-service-management"></a>サポート & サービス管理

カスタマーサポート、ITサービス管理、ヘルプデスク運用のための管理ツール。

- [effytech/freshdesk-mcp](https://github.com/effytech/freshdesk_mcp) 🐍 ☁️ - Freshdeskと連携し、AIモデルによるFreshdeskモジュール操作・各種サポート業務を実現するMCPサーバー。
- [nguyenvanduocit/jira-mcp](https://github.com/nguyenvanduocit/jira-mcp) 🏎️ ☁️ - Go製のJira用MCPコネクタ。Claude等のAIアシスタントがAtlassian Jiraとやり取りできる。課題管理、スプリント計画、ワークフロー遷移など一般的なJira操作をシームレスに提供。
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian製品（Confluence/Jira）用MCPサーバー。Confluence Cloud、Jira Cloud、Jira Server/Data Center対応。ワークスペース横断での検索・閲覧・作成・管理に関する包括的ツールを提供。

### 🌎 <a name="translation-services"></a>翻訳サービス

AIアシスタントによる多言語間の翻訳を可能にするツールおよびサービス。

- [translated/lara-mcp](https://github.com/translated/lara-mcp) 🎖️ 📇 ☁️ - Lara Translate API用MCPサーバー。言語検出や文脈対応翻訳など強力な翻訳機能を提供。
- [mmntm/weblate-mcp](https://github.com/mmntm/weblate-mcp) 📇 ☁️ - Weblate翻訳管理用の包括的なModel Context Protocolサーバー。AIアシスタントによる翻訳タスク、プロジェクト管理、スマートな形式変換対応のコンテンツ発見が可能。

### 🎧 <a name="text-to-speech"></a>テキスト読み上げ

テキストの音声変換およびその逆変換ツール

- [mberg/kokoro-tts-mcp](https://github.com/mberg/kokoro-tts-mcp) 🐍 🏠 - Kokoro TTSモデルを用いてテキストを音声に変換するMCPサーバー。テキストをMP3に変換し、ローカルドライブ保存またはS3バケットへの自動アップロードが可能。
- [mbailey/voice-mcp](https://github.com/mbailey/voice-mcp) 🐍 🏠 - 音声認識・テキスト読み上げ・リアルタイム音声会話をサポートする音声インタラクションサーバー。ローカルマイク、OpenAI互換API、LiveKit統合対応。

### 🚆 <a name="travel-and-transportation"></a>旅行＆交通

旅行・交通情報へのアクセス。時刻表、ルート、リアルタイム移動データのクエリを実現。
- [Airbnb MCP Server](https://github.com/openbnb-org/mcp-server-airbnb) 📇 ☁️ - Airbnbを検索し、リスティングの詳細を取得するためのツールを提供します。
- [KyrieTangSheng/mcp-server-nationalparks](https://github.com/KyrieTangSheng/mcp-server-nationalparks) 📇 ☁️ - アメリカ国立公園局API統合により、公園の詳細情報、アラート、ビジターセンター、キャンプ場、イベントの最新情報を提供します。
- [NS Travel Information MCP Server](https://github.com/r-huijts/ns-mcp-server) 📇 ☁️ - オランダ鉄道（NS）の旅行情報、時刻表、リアルタイム更新情報にアクセスします。
- [pab1it0/tripadvisor-mcp](https://github.com/pab1it0/tripadvisor-mcp) 📇 🐍 - LLMがTripadvisor APIと連携し、標準化されたMCPインターフェースを通じて位置情報、レビュー、写真をサポートするMCPサーバーです。
- [lucygoodchild/mcp-national-rail](https://github.com/lucygoodchild/mcp-national-rail) 📇 ☁️ - 英国ナショナルレールの列車サービス用MCPサーバーで、時刻表やライブ旅行情報を提供し、Realtime Trains APIと統合します。

### 🔄 <a name="version-control"></a>バージョン管理

Gitリポジトリやバージョン管理プラットフォームと連携します。リポジトリ管理、コード解析、プルリクエスト処理、課題追跡、その他バージョン管理操作を標準API経由で可能にします。

- [adhikasp/mcp-git-ingest](https://github.com/adhikasp/mcp-git-ingest) 🐍 🏠 - LLMでGitHubリポジトリを読み取り解析します
- [ddukbg/github-enterprise-mcp](https://github.com/ddukbg/github-enterprise-mcp) 📇 ☁️ 🏠 - GitHub Enterprise API統合用MCPサーバー
- [gitea/gitea-mcp](https://gitea.com/gitea/gitea-mcp) 🎖️ 🏎️ ☁️ 🏠 🍎 🪟 🐧 - MCPでGiteaインスタンスと対話できます。
- [github/github-mcp-server](https://github.com/github/github-mcp-server) 📇 ☁️ - リポジトリ管理、PR、課題などとの統合用公式GitHubサーバー。
- [kopfrechner/gitlab-mr-mcp](https://github.com/kopfrechner/gitlab-mr-mcp) 📇 ☁️ - GitLabプロジェクトの課題やマージリクエストとシームレスに連携します。
- [modelcontextprotocol/server-git](https://github.com/modelcontextprotocol/servers/tree/main/src/git) 🐍 🏠 - ローカルリポジトリの読み取り、検索、解析など直接的なGitリポジトリ操作
- [modelcontextprotocol/server-gitlab](https://github.com/modelcontextprotocol/servers/tree/main/src/gitlab) 📇 ☁️ 🏠 - GitLabプラットフォーム統合によりプロジェクト管理やCI/CD操作に対応
- [oschina/mcp-gitee](https://github.com/oschina/gitee) 🏎️ ☁️ 🏠 - Gitee API統合、リポジトリ・課題・プルリク管理など
- [Tiberriver256/mcp-server-azure-devops](https://github.com/Tiberriver256/mcp-server-azure-devops) 📇 ☁️ - リポジトリ管理、作業項目、パイプラインに対応したAzure DevOps統合
- [kaiyuanxiaobing/atomgit-mcp-server](https://github.com/kaiyuanxiaobing/atomgit-mcp-server) 📇 ☁️ - リポジトリ管理、PR、課題、ブランチ、ラベルなど統合用公式AtomGitサーバー

### 🛠️ <a name="other-tools-and-integrations"></a>その他ツール・統合

- [AbdelStark/bitcoin-mcp](https://github.com/AbdelStark/bitcoin-mcp) - ₿ AIモデルがビットコインと連携し、鍵生成・アドレス検証・トランザクションデコード・ブロックチェーン照会などを可能にするMCPサーバー。
- [akseyh/bear-mcp-server](https://github.com/akseyh/bear-mcp-server) - AIがBear Notes（macOS限定）を読み取れるようにします
- [allenporter/mcp-server-home-assistant](https://github.com/allenporter/mcp-server-home-assistant) 🐍 🏠 - Home Assistantの全ボイスインテントをMCPサーバー経由で公開し、ホームコントロールを可能にします。
- [Amazon Bedrock Nova Canvas](https://github.com/zxkane/mcp-server-amazon-bedrock) 📇 ☁️ - Amazon Nova Canvasモデルによる画像生成が可能です。
- [amidabuddha/unichat-mcp-server](https://github.com/amidabuddha/unichat-mcp-server) 🐍/📇 ☁️ - MCPプロトコルを使用し、OpenAI、MistralAI、Anthropic、xAI、Google AI、DeepSeekへリクエスト送信やプロンプト実行。ベンダーAPIキー要。
- [anaisbetts/mcp-installer](https://github.com/anaisbetts/mcp-installer) 🐍 🏠 - 他のMCPサーバーをインストールするMCPサーバー
- [anaisbetts/mcp-youtube](https://github.com/anaisbetts/mcp-youtube) 📇 ☁️ - YouTube字幕を取得
- [andybrandt/mcp-simple-openai-assistant](https://github.com/andybrandt/mcp-simple-openai-assistant) - 🐍 ☁️  OpenAIアシスタントと会話できるMCP（Claudeは任意のGPTモデルを使用可能）
- [andybrandt/mcp-simple-timeserver](https://github.com/andybrandt/mcp-simple-timeserver) 🐍 🏠☁️ - クライアントマシンのローカル時刻やNTPサーバーから現在のUTC時刻を確認可能なMCPサーバー
- [apify/actors-mcp-server](https://github.com/apify/actors-mcp-server) 📇 ☁️ - 3,000以上のクラウドツール(Actors)を利用し、WebサイトやEC、SNS、検索エンジン、地図などからデータ抽出
- [apinetwork/piapi-mcp-server](https://github.com/apinetwork/piapi-mcp-server) 📇 ☁️ PiAPI MCPサーバーにより、Claudeや他のMCP互換アプリからMidjourney/Flux/Kling/Hunyuan/Udio/Trellisでメディア生成が可能
- [awkoy/replicate-flux-mcp](https://github.com/awkoy/replicate-flux-mcp) 📇 ☁️ - Replicate API経由で画像生成が可能
- [awwaiid/mcp-server-taskwarrior](https://github.com/awwaiid/mcp-server-taskwarrior) 🏠 📇 - 基本的なローカルtaskwarrior操作（追加・更新・削除）ができるMCPサーバー
- [baba786/phabricator-mcp-server](https://github.com/baba786/phabricator-mcp-server) 🐍 ☁️ - Phabricator APIと連携
- [Badhansen/notion-mcp](https://github.com/Badhansen/notion-mcp) 🐍 ☁️ - Notion APIと統合し、個人のToDoリストを効率的に管理できるMCPサーバー
- [bart6114/my-bear-mcp-server](https://github.com/bart6114/my-bear-mcp-server/) 📇 🏠 🍎 - BearノートアプリのノートとタグをBearのsqlitedb直統合で読み取れる
- [billster45/mcp-chatgpt-responses](https://github.com/billster45/mcp-chatgpt-responses) 🐍 ☁️ - ClaudeがChatGPTと会話し、そのWeb検索機能を利用可能にするMCPサーバー。
- [blurrah/mcp-graphql](https://github.com/blurrah/mcp-graphql) 📇 ☁️ - AIがGraphQLサーバーをクエリ可能に
- [calclavia/mcp-obsidian](https://github.com/calclavia/mcp-obsidian) 📇 🏠 - Claude DesktopなどMCPクライアントでObsidianボールト等Markdownノートディレクトリの読み取り・検索を可能に
- [chrishayuk/mcp-cli](https://github.com/chrishayuk/mcp-cli) 🐍 🏠 - MCPサーバーをテストするためのCLIツール
- [danhilse/notion_mcp](https://github.com/danhilse/notion_mcp) 🐍 ☁️ - Notion API連携によるToDoリスト管理
- [EKibort/wrike-mcp-server](https://github.com/EKibort/wrike-mcp-server) - 🐍 🏠 - WrikeのタスクAPIと連携できる軽量MCPサーバー
- [ekkyarmandi/ticktick-mcp](https://github.com/ekkyarmandi/ticktick-mcp) 🐍 ☁️ - [TickTick](https://ticktick.com/) APIと統合し、個人のToDoプロジェクトやタスクを管理
- [esignaturescom/mcp-server-esignatures](https://github.com/esignaturescom/mcp-server-esignatures) 🐍 ☁️️ - eSignatures APIを使った契約書やテンプレートの作成・レビュー・送信管理
- [evalstate/mcp-miro](https://github.com/evalstate/mcp-miro) 📇 ☁️ - MIROホワイトボードへアクセスし、アイテムの一括作成・読み取り。REST API用OAUTHキー要
- [feuerdev/keep-mcp](https://github.com/feuerdev/keep-mcp) 🐍 ☁️ - Google Keepノートの読み取り・作成・更新・削除
- [future-audiences/wikimedia-enterprise-model-context-protocol](https://gitlab.wikimedia.org/repos/future-audiences/wikimedia-enterprise-model-context-protocol) 🐍 ☁️  - Wikipedia記事検索API
- [fotoetienne/gqai](https://github.com/fotoetienne/gqai) 🏎 🏠 - 通常のGraphQLクエリ/ミューテーションでツールを定義し、自動でMCPサーバーを生成
- [githejie/mcp-server-calculator](https://github.com/githejie/mcp-server-calculator) 🐍 🏠 - LLMが計算機を利用し、正確な数値計算を行えるサーバー
- [gotoolkits/DifyWorkflow](https://github.com/gotoolkits/mcp-difyworkflow-server) - 🏎️ ☁️ Difyワークフローのクエリと実行用ツール
- [hiromitsusasaki/raindrop-io-mcp-server](https://github.com/hiromitsusasaki/raindrop-io-mcp-server) 📇 ☁️ - Model Context Protocol (MCP)を使い、Raindrop.ioブックマークと連携
- [hmk/attio-mcp-server](https://github.com/hmk/attio-mcp-server) - 📇 ☁️ AIクライアントがAttio CRM内のレコードやノートを管理可能
- [isaacwasserman/mcp-vegalite-server](https://github.com/isaacwasserman/mcp-vegalite-server) 🐍 🏠 - VegaLite形式とレンダラーを使い、取得したデータの可視化を生成
- [ivnvxd/mcp-server-odoo](https://github.com/ivnvxd/mcp-server-odoo) 🐍 ☁️/🏠 - Odoo ERPシステムとAIアシスタントを連携し、業務データアクセスやレコード管理、ワークフロー自動化を実現
- [ivo-toby/contentful-mcp](https://github.com/ivo-toby/contentful-mcp) 📇 🏠 - Contentful Space内のコンテンツ・モデル・アセットの更新、作成、削除
- [j3k0/speech.sh](https://github.com/j3k0/speech.sh/blob/main/MCP_README.md) 🏠 - エージェントが内容を音声で読み上げ、作業完了時に要約で通知
- [jagan-shanmugam/climatiq-mcp-server](https://github.com/jagan-shanmugam/climatiq-mcp-server) 🐍 🏠 - Climatiq APIへのアクセス用MCPサーバー。AIアシスタントにリアルタイムの炭素排出計算や気候影響のインサイト提供を可能に。
- [johannesbrandenburger/typst-mcp](https://github.com/johannesbrandenburger/typst-mcp) 🐍 🏠 - Typst用MCPサーバー。LaTeX・Typst間変換、Typst構文検証、Typstコードから画像生成などを提供
- [joshuarileydev/mac-apps-launcher-mcp-server](https://github.com/JoshuaRileyDev/mac-apps-launcher) 📇 🏠 - MacOS上のアプリ一覧取得・起動を行うMCPサーバー
- [Harry-027/JotDown](https://github.com/Harry-027/JotDown) 🦀 🏠 - Notionアプリのページ作成/更新や、構造化コンテンツからのmdBook自動生成用MCPサーバー
- [kelvin6365/plane-mcp-server](https://github.com/kelvin6365/plane-mcp-server) - 🏎️ 🏠 [Plane](https://plane.so) APIを通じてプロジェクトや課題を管理できるMCPサーバー
- [kenliao94/mcp-server-rabbitmq](https://github.com/kenliao94/mcp-server-rabbitmq) 🐍 🏠 - RabbitMQへの管理操作やメッセージのenqueue/dequeueが可能
- [k-jarzyna/mcp-miro](https://github.com/k-jarzyna/mcp-miro) 📇 ☁️ - 公式Miro SDKで提供される全機能を公開するMiro MCPサーバー
- [kimtth/mcp-remote-call-ping-pong](https://github.com/kimtth/mcp-remote-call-ping-pong) 🐍 🏠 - リモートMCP（Model Context Protocol）呼び出しを実演する実験的・教育的Ping-pongサーバーアプリ
- [kj455/mcp-kibela](https://github.com/kj455/mcp-kibela) - 📇 ☁️ AIモデルが[Kibela](https://kibe.la/)と連携できる
- [kiwamizamurai/mcp-kibela-server](https://github.com/kiwamizamurai/mcp-kibela-server) - 📇 ☁️ Kibela APIと強力に連携
- [KS-GEN-AI/confluence-mcp-server](https://github.com/KS-GEN-AI/confluence-mcp-server) 📇 ☁️ 🍎 🪟 - CQLを利用してConfluenceデータ取得、ページ読み取り
- [KS-GEN-AI/jira-mcp-server](https://github.com/KS-GEN-AI/jira-mcp-server) 📇 ☁️ 🍎 🪟 - JQL・APIを用いたJiraデータの読み取りやチケット作成・編集
- [salesforce-mcp/salesforce-mcp](https://github.com/salesforce-mcp/salesforce-mcp) 🏠 ☁️ - Salesforceインスタンスとの基本的な連携デモ用MCPサーバー
- [pollinations/chucknorris-mcp](https://github.com/pollinations/chucknorris-mcp) 📇 ☁️ - 動的スキーマ適応を備えたLLM拡張プロンプトと脱獄用MCPサーバー
- [louiscklaw/hko-mcp](https://github.com/louiscklaw/hko-mcp) 📇 🏠 - 香港天文台から天気情報を取得するMCPサーバー
- [evalstate/mcp-hfspace](https://github.com/evalstate/mcp-hfspace) 📇 ☁️ - Claudeから直接HuggingFace Spacesを利用可能。OSSの画像生成、チャット、Visionタスクなど。画像・音声・テキストのアップロード/ダウンロード対応。
- [magarcia/mcp-server-giphy](https://github.com/magarcia/mcp-server-giphy) 📇 ☁️ - Giphy API経由でGIF検索・取得
- [integromat/make-mcp-server](https://github.com/integromat/make-mcp-server) 🎖️ 📇 🏠 - [Make](https://www.make.com/)のシナリオをAIアシスタントが呼び出せるツール化
- [marcelmarais/Spotify](https://github.com/marcelmarais/spotify-mcp-server) - 📇 🏠 Spotifyの再生制御やプレイリスト管理
- [MarkusPfundstein/mcp-obsidian](https://github.com/MarkusPfundstein/mcp-obsidian) 🐍 ☁️ 🏠 - REST API経由でObsidianと連携
- [emicklei/mcp-log-proxy](https://github.com/emicklei/mcp-log-proxy) 🏎️ 🏠 - MCPサーバープロキシで、メッセージフローのWeb UI表示を提供
- [quarkiverse/mcp-server-jfx](https://github.com/quarkiverse/quarkus-mcp-servers/tree/main/jfx) ☕ 🏠 - JavaFXキャンバスへの描画
- [mediar-ai/screenpipe](https://github.com/mediar-ai/screenpipe) - 🎖️ 🦀 🏠 🍎 ローカル優先で画面/音声をタイムスタンプ付きで記録、SQL/埋め込み保存、セマンティック検索、LLMによる履歴分析、イベントトリガーアクションを備えたシステム。NextJSプラグインエコシステムでコンテキスト対応AIエージェント構築を実現。
- [modelcontextprotocol/server-everything](https://github.com/modelcontextprotocol/servers/tree/main/src/everything) 📇 🏠 - MCPプロトコルの全機能を試せるMCPサーバー
- [mrjoshuak/godoc-mcp](https://github.com/mrjoshuak/godoc-mcp) 🏎️ 🏠 - Goパッケージのドキュメントや型情報にAIアシスタントが効率的にアクセスできるトークン効率重視のサーバー
- [mzxrai/mcp-openai](https://github.com/mzxrai/mcp-openai) 📇 ☁️ - OpenAIの最新モデルとチャット可能
- [NakaokaRei/swift-mcp-gui](https://github.com/NakaokaRei/swift-mcp-gui.git) 🏠 🍎 - キーボード入力やマウス操作などのコマンドを実行できるMCPサーバー
- [nguyenvanduocit/all-in-one-model-context-protocol](https://github.com/nguyenvanduocit/all-in-one-model-context-protocol) 🏎️ 🏠 - 開発者向け便利ツール集：confluence、Jira、Youtube、スクリプト実行、ナレッジベースRAG、URL取得、YouTubeチャンネル管理、メール、カレンダー、gitlab等
- [NON906/omniparser-autogui-mcp](https://github.com/NON906/omniparser-autogui-mcp) - 🐍 画面上GUIの自動操作
- [orellazi/coda-mcp](https://github.com/orellazri/coda-mcp) 📇 ☁️ - [Coda](https://coda.io/)用MCPサーバー
- [pierrebrunelle/mcp-server-openai](https://github.com/pierrebrunelle/mcp-server-openai) 🐍 ☁️ - MCPプロトコル経由でClaudeからOpenAIモデルを直接クエリ可能
- [pskill9/hn-server](https://github.com/pskill9/hn-server) - 📇 ☁️ news.ycombinator.com（Hacker News）のHTML内容を解析し、各種ストーリー（トップ・新着・Ask・Show・Jobs）の構造化データを提供
- [PV-Bhat/vibe-check-mcp-server](https://github.com/PV-Bhat/vibe-check-mcp-server) 📇 ☁️ - 「Vibe-check」エージェントを呼び出し、ユーザーの意図と合致しているか確認し、連鎖的エラーやスコープ拡大を防ぐMCPサーバー
- [pwh-pwh/cal-mcp](https://github.com/pwh-pwh/cal-mcp) - 数式計算用MCPサーバー
- [pyroprompts/any-chat-completions-mcp](https://github.com/pyroprompts/any-chat-completions-mcp) - Perplexity、Groq、xAIなど、OpenAI SDK互換のChat Completions APIとチャット
- [Rai220/think-mcp](https://github.com/Rai220/think-mcp) 🐍 🏠 - [Anthropicの記事](https://www.anthropic.com/engineering/claude-think-tool)で紹介されているthink-toolsを統合し、任意のエージェントの推論能力を強化
- [reeeeemo/ancestry-mcp](https://github.com/reeeeemo/ancestry-mcp) 🐍 🏠 - AIが.gedファイルや遺伝データを読み取る
- [rember/rember-mcp](https://github.com/rember/rember-mcp) 📇 🏠 - [Rember](https://rember.com)でスペースドリピティションのフラッシュカードを作成し、チャットで学んだ内容を記憶
- [roychri/mcp-server-asana](https://github.com/roychri/mcp-server-asana) - 📇 ☁️ Asana APIにMCPクライアント（例：Claude Desktop等）からアクセス可能にするModel Context Protocolサーバー
- [rusiaaman/wcgw](https://github.com/rusiaaman/wcgw/blob/main/src/wcgw/client/mcp_server/Readme.md) 🐍 🏠 - 自律的なシェル実行・PC操作・コーディングエージェント（Mac）
- [SecretiveShell/MCP-wolfram-alpha](https://github.com/SecretiveShell/MCP-wolfram-alpha) 🐍 ☁️ - Wolfram Alpha APIへのクエリ用MCPサーバー
- [Seym0n/tiktok-mcp](https://github.com/Seym0n/tiktok-mcp) 📇 ☁️ - TikTok動画と対話するためのMCPサーバー
- [Shopify/dev-mcp](https://github.com/Shopify/dev-mcp) 📇 ☁️ - Shopify Devと連携するModel Context Protocol（MCP）サーバー
- [sirmews/apple-notes-mcp](https://github.com/sirmews/apple-notes-mcp) 🐍 🏠 - AIがローカルのApple Notesデータベースを読み取れるようにする（macOSのみ）
- [sooperset/mcp-atlassian](https://github.com/sooperset/mcp-atlassian) 🐍 ☁️ - Atlassian製品（Confluence, Jira）用のMCPサーバー。Confluence Cloud、Jira Cloud、Jira Server/Data Centerをサポート。Atlassianワークスペース全体のコンテンツの検索、読込、作成、管理のための包括的なツールを提供。
- [suekou/mcp-notion-server](https://github.com/suekou/mcp-notion-server) 📇 🏠 - Notion APIとの連携
- [tacticlaunch/mcp-linear](https://github.com/tacticlaunch/mcp-linear) 📇 ☁️ 🍎 🪟 🐧 - Linearプロジェクト管理システムとの統合
- [tanigami/mcp-server-perplexity](https://github.com/tanigami/mcp-server-perplexity) 🐍 ☁️ - Perplexity APIとの連携
- [tevonsb/homeassistant-mcp](https://github.com/tevonsb/homeassistant-mcp) 📇 🏠 - Home Assistantデータへのアクセスおよびデバイス（ライト、スイッチ、サーモスタット等）の制御
- [tomekkorbak/oura-mcp-server](https://github.com/tomekkorbak/oura-mcp-server) 🐍 ☁️ - 睡眠トラッキングアプリOura用のMCPサーバー
- [UnitVectorY-Labs/mcp-graphql-forge](https://github.com/UnitVectorY-Labs/mcp-graphql-forge) 🏎️ ☁️ 🍎 🪟 🐧 - 厳選されたGraphQLクエリをモジュール型ツールとして公開し、エージェントによる意図的なAPI操作を可能にする軽量・設定駆動型MCPサーバー
- [kw510/strava-mcp](https://github.com/kw510/strava-mcp) 📇 ☁️ - 運動記録アプリStrava用のMCPサーバー
- [wanaku-ai/wanaku](https://github.com/wanaku-ai/wanaku) - ☁️ 🏠 Wanaku MCP Routerは、エンタープライズシステムとAIエージェントの統合を可能にする拡張可能なルーティングエンジンを提供するSSEベースのMCPサーバー
- [wong2/mcp-cli](https://github.com/wong2/mcp-cli) 📇 🏠 - MCPサーバーのテスト用CLIツール
- [ws-mcp](https://github.com/nick1udwig/ws-mcp) - MCPサーバーをWebSocketでラップ（[kitbitz](https://github.com/nick1udwig/kibitz)と併用可能）
- [yuna0x0/hackmd-mcp](https://github.com/yuna0x0/hackmd-mcp) 📇 ☁️ - AIモデルが[HackMD](https://hackmd.io)と連携するためのMCPサーバー
- [ZeparHyfar/mcp-datetime](https://github.com/ZeparHyfar/mcp-datetime) - 様々な形式で日付と時刻の機能を提供するMCPサーバー
- [zueai/mcp-manager](https://github.com/zueai/mcp-manager) 📇 ☁️ - Claude Desktop App用のMCPサーバーをインストール・管理するためのシンプルなWeb UI
- [HenryHaoson/Yuque-MCP-Server](https://github.com/HenryHaoson/Yuque-MCP-Server) - 📇 ☁️ Yuque APIと連携するためのModel-Context-Protocol（MCP）サーバー。AIモデルによる文書管理、ナレッジベースとの対話、コンテンツ検索、アナリティクスデータへのアクセスを実現。
- [Mtehabsim/ScreenPilot](https://github.com/Mtehabsim/ScreenPilot) 🐍 🏠 - AIによるGUI操作の完全制御とアクセスを実現。マウス・キーボードツールを提供し、自動化・教育・実験用途に最適
- [tumf/web3-mcp](https://github.com/tumf/web3-mcp) 🐍 ☁️ - Ankr Advanced APIをラップするMCPサーバー。Ethereum、BSC、Polygon、Avalanche等の複数チェーンにまたがるNFT・トークン・ブロックチェーンデータへのアクセス
- [danielkennedy1/pdf-tools-mcp](https://github.com/danielkennedy1/pdf-tools-mcp) 🐍 - PDFのダウンロード、閲覧、操作ユーティリティ
- [dotemacs/domain-lookup-mcp](https://github.com/dotemacs/domain-lookup-mcp) 🏎️ - [RDAP](https://en.wikipedia.org/wiki/Registration_Data_Access_Protocol)経由でのドメイン名検索サービス（フォールバックで[WHOIS](https://en.wikipedia.org/wiki/WHOIS)も利用）
- [Klavis-AI/YouTube](https://github.com/Klavis-AI/klavis/tree/main/mcp_servers/youtube) 🐍 📇 - YouTube動画情報の抽出と変換
- [ttommyth/interactive-mcp](https://github.com/ttommyth/interactive-mcp) 📇 🏠 🍎 🪟 🐧 - ローカルユーザープロンプトとチャット機能をMCPループに直接追加することで、対話的なLLMワークフローを実現
- [olalonde/mcp-human](https://github.com/olalonde/mcp-human) 📇 ☁️ - LLMが人間の支援を必要とする場合にAWS Mechanical Turkを利用
- [gwbischof/free-will-mcp](https://github.com/gwbischof/free-will-mcp) 🐍 🏠 - AIに自由意志のツールを与えるプロジェクト。AIが自分自身にプロンプトを与えたり、ユーザーリクエストを無視したり、後で自分を起こしたりする能力を探索するための遊び心のあるプロジェクト
- [caol64/wenyan-mcp](https://github.com/caol64/wenyan-mcp) 📇 🏠 🍎 🪟 🐧 - AIがMarkdown記事を自動整形し、WeChat GZHへ投稿できるWenyan MCPサーバー

## フレームワーク

> [!NOTE]
> さらに多くのフレームワーク、ユーティリティ、その他開発者向けツールは https://github.com/punkpeye/awesome-mcp-devtools で公開されています

- [FastMCP](https://github.com/jlowin/fastmcp) 🐍 - PythonでMCPサーバーを構築するためのハイレベルフレームワーク
- [FastMCP](https://github.com/punkpeye/fastmcp) 📇 - TypeScriptでMCPサーバーを構築するためのハイレベルフレームワーク

## ヒント＆トリック

### LLMにMCPの使い方を伝える公式プロンプト

ClaudeにModel Context Protocolについて質問したいですか？

プロジェクトを作成し、次のファイルを追加してください：

https://modelcontextprotocol.io/llms-full.txt

これでClaudeがMCPサーバーの書き方や動作について答えられるようになります

- https://www.reddit.com/r/ClaudeAI/comments/1h3g01r/want_to_ask_claude_about_model_context_protocol/

## スター履歴

<a href="https://star-history.com/#punkpeye/awesome-mcp-servers&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
   <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=punkpeye/awesome-mcp-servers&type=Date" />
 </picture>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---