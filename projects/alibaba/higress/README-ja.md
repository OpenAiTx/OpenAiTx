<a name="readme-top"></a>
<h1 align="center">
    <img src="https://img.alicdn.com/imgextra/i2/O1CN01NwxLDd20nxfGBjxmZ_!!6000000006895-2-tps-960-290.png" alt="Higress" width="240" height="72.5">
  <br>
  AIゲートウェイ
</h1>
<h4 align="center"> AIネイティブAPIゲートウェイ </h4>

<div align="center">
    
[![Build Status](https://github.com/alibaba/higress/actions/workflows/build-and-test.yaml/badge.svg?branch=main)](https://github.com/alibaba/higress/actions)
[![license](https://img.shields.io/github/license/alibaba/higress.svg)](https://www.apache.org/licenses/LICENSE-2.0.html)
[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=flat-square)](https://discord.gg/tSbww9VDaM)

<a href="https://trendshift.io/repositories/10918" target="_blank"><img src="https://trendshift.io/api/badge/repositories/10918" alt="alibaba%2Fhigress | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a> <a href="https://www.producthunt.com/posts/higress?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-higress" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=951287&theme=light&t=1745492822283" alt="Higress - Global&#0032;APIs&#0032;as&#0032;MCP&#0032;powered&#0032;by&#0032;AI&#0032;Gateway | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

</div>

[**公式サイト**](https://higress.ai/en/) &nbsp; |
&nbsp; [**MCPサーバークイックスタート**](https://higress.cn/en/ai/mcp-quick-start/) &nbsp; |
&nbsp; [**Wasmプラグインハブ**](https://higress.cn/en/plugin/) &nbsp; |

<p>
   English | <a href="README_ZH.md">中文<a/> | <a href="README_JP.md">日本語<a/>
</p>

## Higressとは？

Higressは、IstioとEnvoyをベースとしたクラウドネイティブAPIゲートウェイであり、Go/Rust/JSで記述されたWasmプラグインによる拡張が可能です。数十種類の汎用プラグインとすぐに使えるコンソール（[デモはこちら](http://demo.higress.io/)）を提供します。

### 主なユースケース

HigressのAIゲートウェイ機能は、[主流のモデルプロバイダー](https://raw.githubusercontent.com/alibaba/higress/main/plugins/wasm-go/extensions/ai-proxy/provider)（国内外）すべてをサポートします。また、プラグインメカニズムによりMCP（Model Context Protocol）サーバーのホスティングも可能で、AIエージェントがさまざまなツールやサービスを簡単に呼び出せます。[openapi-to-mcpツール](https://github.com/higress-group/openapi-to-mcpserver)を使うことで、OpenAPI仕様を迅速にリモートMCPサーバーに変換できます。HigressはLLM APIとMCP APIの統合管理を実現します。

**🌟 今すぐ[https://mcp.higress.ai/](https://mcp.higress.ai/)で試してみましょう。**  
Higressホスト型リモートMCPサーバーを体験できます：

![Higress MCP Server Platform](https://img.alicdn.com/imgextra/i2/O1CN01nmVa0a1aChgpyyWOX_!!6000000003294-0-tps-3430-1742.jpg)

### エンタープライズ導入事例

HigressはAlibaba内部で、Tengineリロードによる長時間接続サービスへの影響やgRPC/Dubboの負荷分散能力不足の課題を解決するために誕生しました。Alibaba Cloud内では、HigressのAIゲートウェイ機能が「通義·百炼」モデルスタジオ、機械学習PAIプラットフォームなど、コアAIアプリケーションを支えています。Alibaba Cloudは、Higressを基盤としたクラウドネイティブAPIゲートウェイ製品を構築し、多くのエンタープライズ顧客に99.99%のゲートウェイ高可用性サービスを提供しています。

## 目次

- [**クイックスタート**](#quick-start)    
- [**機能紹介**](#feature-showcase)
- [**ユースケース**](#use-cases)
- [**コアメリット**](#core-advantages)
- [**コミュニティ**](#community)

## クイックスタート

HigressはDockerだけですぐに起動でき、個人開発者が学習やシンプルなサイト構築のためにローカルでセットアップするのに便利です：

```bash
# 作業ディレクトリを作成
mkdir higress; cd higress
# higressを起動し、設定ファイルは作業ディレクトリに保存されます
docker run -d --rm --name higress-ai -v ${PWD}:/data \
        -p 8001:8001 -p 8080:8080 -p 8443:8443  \
        higress-registry.cn-hangzhou.cr.aliyuncs.com/higress/all-in-one:latest
```

ポート説明：

- 8001ポート：Higress UIコンソール
- 8080ポート：ゲートウェイHTTPプロトコルエンドポイント
- 8443ポート：ゲートウェイHTTPSプロトコルエンドポイント

> 全てのHigress Dockerイメージは独自のイメージリポジトリを使用しており、Docker Hubのレート制限の影響を受けません。  
> また、イメージの提出・更新はセキュリティスキャンメカニズム（Alibaba Cloud ACR提供）で保護されており、本番環境でも安心して利用できます。  
>
> `higress-registry.cn-hangzhou.cr.aliyuncs.com`からのイメージ取得でタイムアウトが発生する場合は、以下のDockerレジストリミラーソースをお試しください：  
>
> **東南アジア**: `higress-registry.ap-southeast-7.cr.aliyuncs.com`

K8s上でのHelmデプロイなど他のインストール方法については、公式の[クイックスタートドキュメント](https://higress.io/en-us/docs/user/quickstart)を参照してください。

## ユースケース

- **MCPサーバーホスティング**:

  Higressはプラグインメカニズムを通じてMCPサーバーをホスティングし、AIエージェントが様々なツールやサービスを容易に呼び出せます。[openapi-to-mcpツール](https://github.com/higress-group/openapi-to-mcpserver)を利用し、OpenAPI仕様を迅速にリモートMCPサーバーに変換できます。

  ![](https://img.alicdn.com/imgextra/i1/O1CN01wv8H4g1mS4MUzC1QC_!!6000000004952-2-tps-1764-597.png)

  HigressによるMCPサーバーホスティングの主なメリット：
  - 認証・認可の統一メカニズム
  - 濫用を防ぐきめ細やかなレート制限
  - 全ツールコールの包括的な監査ログ
  - 豊富なオブザーバビリティとパフォーマンス監視
  - プラグインメカニズムによる簡素なデプロイ
  - 接続断やダウンタイムなしの動的更新

     [詳細はこちら...](https://higress.cn/en/ai/mcp-quick-start/?spm=36971b57.7beea2de.0.0.d85f20a94jsWGm)

- **AIゲートウェイ**:

  Higressは統一プロトコルで全てのLLMモデルプロバイダーに接続し、AIオブザーバビリティ、マルチモデル負荷分散、トークンレートリミット、キャッシュ機能を備えています：

  ![](https://img.alicdn.com/imgextra/i2/O1CN01izmBNX1jbHT7lP3Yr_!!6000000004566-0-tps-1920-1080.jpg)

- **Kubernetesイングレスコントローラー**:

  Higressは高機能なイングレスコントローラーとしても機能し、K8s nginxイングレスコントローラーの多くのアノテーションと互換性があります。
  
  [Gateway API](https://gateway-api.sigs.k8s.io/)のサポートも近日対応予定で、Ingress APIからGateway APIへのスムーズな移行を実現します。
  
- **マイクロサービスゲートウェイ**:

  Higressはマイクロサービスゲートウェイとしても動作し、Nacos、ZooKeeper、Consul、Eurekaなど様々なサービスレジストリからのマイクロサービス発見が可能です。
  
  [Dubbo](https://github.com/apache/dubbo)、[Nacos](https://github.com/alibaba/nacos)、[Sentinel](https://github.com/alibaba/Sentinel)などのマイクロサービス技術スタックとも深く統合されています。
  
- **セキュリティゲートウェイ**:

  Higressはセキュリティゲートウェイとしても利用でき、WAFやkey-auth、hmac-auth、jwt-auth、basic-auth、oidcなど様々な認証戦略をサポートしています。

## コアメリット

- **プロダクショングレード**

  Alibabaの社内製品として2年以上の本番検証を経ており、数十万QPSの大規模シナリオもサポートします。

  Nginxリロードによるトラフィックの揺れを完全排除し、設定変更はミリ秒単位で反映、ビジネスに透過的です。特にAIビジネスなど長時間接続シナリオに最適です。

- **ストリーミング処理**

  リクエスト/レスポンスボディの完全なストリーミング処理をサポートし、WasmプラグインでSSE（Server-Sent Events）などストリーミングプロトコルのカスタム処理が容易です。

  AIビジネスなどの高帯域幅シナリオでメモリ使用量を大幅に削減します。
    
- **拡張性の高さ**
  
  AI、トラフィック管理、セキュリティ対策など、ビジネスシナリオの90%以上をカバーする公式プラグインライブラリを提供します。

  Wasmプラグイン拡張に注力し、サンドボックス隔離によるメモリ安全性、多言語対応、プラグインバージョンの独立アップグレード、ゲートウェイロジックのトラフィックロスレスなホットアップデートを実現します。

- **セキュアかつ使いやすい**
  
  Ingress APIおよびGateway API標準に基づき、すぐに使えるUIコンソール、WAF保護プラグイン、IP/Cookie CC保護プラグインを提供します。

  Let's Encrypt連携による無料証明書の自動発行・更新をサポートし、K8s外部へのデプロイや、Dockerコマンド一発での起動も可能。個人開発者にも便利です。

## コミュニティ

Discordコミュニティに参加しませんか？Higress開発者やユーザーと交流できます。

[![discord](https://img.shields.io/discord/1364956090566971515?color=5865F2&label=discord&labelColor=black&logo=discord&logoColor=white&style=for-the-badge)](https://discord.gg/tSbww9VDaM)


### 感謝

Higressは、コミュニティのオープンソースプロジェクトの貴重な成果なしには実現しませんでした。特にEnvoyとIstioに感謝いたします。

### 関連リポジトリ

- Higress Console: https://github.com/higress-group/higress-console
- Higress Standalone: https://github.com/higress-group/higress-standalone

### コントリビューター

<a href="https://github.com/alibaba/higress/graphs/contributors">
  <img alt="contributors" src="https://contrib.rocks/image?repo=alibaba/higress"/>
</a>

### スター履歴

[![Star History Chart](https://api.star-history.com/svg?repos=alibaba/higress&type=Date)](https://star-history.com/#alibaba/higress&Date)

<p align="right" style="font-size: 14px; color: #555; margin-top: 20px;">
    <a href="#readme-top" style="text-decoration: none; color: #007bff; font-weight: bold;">
        ↑ ページトップへ戻る ↑
    </a>
</p>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---