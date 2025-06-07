# Open WebUI 👋

![GitHub stars](https://img.shields.io/github/stars/open-webui/open-webui?style=social)
![GitHub forks](https://img.shields.io/github/forks/open-webui/open-webui?style=social)
![GitHub watchers](https://img.shields.io/github/watchers/open-webui/open-webui?style=social)
![GitHub repo size](https://img.shields.io/github/repo-size/open-webui/open-webui)
![GitHub language count](https://img.shields.io/github/languages/count/open-webui/open-webui)
![GitHub top language](https://img.shields.io/github/languages/top/open-webui/open-webui)
![GitHub last commit](https://img.shields.io/github/last-commit/open-webui/open-webui?color=red)
[![Discord](https://img.shields.io/badge/Discord-Open_WebUI-blue?logo=discord&logoColor=white)](https://discord.gg/5rJgQTnV4s)
[![](https://img.shields.io/static/v1?label=Sponsor&message=%E2%9D%A4&logo=GitHub&color=%23fe8e86)](https://github.com/sponsors/tjbck)

**Open WebUIは、[拡張可能](https://docs.openwebui.com/features/plugin/)で多機能かつユーザーフレンドリーな、完全オフライン動作を前提としたセルフホスト型AIプラットフォームです。**  
Ollamaや**OpenAI互換API**など多様なLLMランナーをサポートし、**組み込みRAG推論エンジン**を備えた**強力なAIデプロイメントソリューション**です。

![Open WebUI Demo](./demo.gif)

> [!TIP]  
> **[エンタープライズプラン](https://docs.openwebui.com/enterprise)をお探しですか？** – **[営業チームにご相談ください！](mailto:sales@openwebui.com)**
>
> **カスタムテーマ・ブランディング**、**SLAサポート**、**LTSバージョン**など、**強化された機能**がご利用いただけます！

詳細は[Open WebUIドキュメント](https://docs.openwebui.com/)をご確認ください。

## Open WebUI の主な特徴 ⭐

- 🚀 **簡単セットアップ**: DockerまたはKubernetes（kubectl、kustomize、helm）でシームレスにインストール。`:ollama`や`:cuda`タグ付きイメージをサポートし、手間のかからない体験を提供します。

- 🤝 **Ollama/OpenAI API統合**: OpenAI互換APIとOllamaモデルを併用可能。OpenAI APIのURLをカスタマイズし、**LMStudio、GroqCloud、Mistral、OpenRouter**などと連携できます。

- 🛡️ **詳細な権限管理とユーザーグループ**: 管理者が詳細なユーザーロール・権限を作成可能。セキュリティを強化し、カスタマイズ可能なユーザー体験や、責任感・所有感を高めます。

- 📱 **レスポンシブデザイン**: デスクトップPC、ノートPC、モバイルデバイスで快適な体験を実現。

- 📱 **モバイル向けPWA（プログレッシブウェブアプリ）**: PWAによるネイティブアプリのような体験。ローカルホストでのオフラインアクセスやシームレスなUIを提供します。

- ✒️🔢 **MarkdownおよびLaTeX完全対応**: 豊富なMarkdown/LaTeX機能により、LLM体験を強化。

- 🎤📹 **ハンズフリー音声・ビデオ通話**: 音声・ビデオ通話機能を統合し、より動的かつインタラクティブなチャット環境を実現。

- 🛠️ **モデルビルダー**: Web UI上で簡単にOllamaモデルを作成。カスタムキャラクター/エージェントの追加やチャット要素のカスタマイズ、[Open WebUI Community](https://openwebui.com/)連携によるモデルインポートも可能。

- 🐍 **ネイティブPython関数呼び出しツール**: ツールワークスペースで組み込みコードエディターをサポート。純粋なPython関数を追加するだけで、LLMとのシームレスな統合を実現。

- 📚 **ローカルRAG統合**: 画期的な検索拡張生成（RAG）対応。ドキュメントをチャットに直接読み込んだり、ライブラリにファイル追加し、クエリ前の`#`コマンドで簡単アクセス。

- 🔍 **RAG向けウェブ検索**: `SearXNG`、`Google PSE`、`Brave Search`、`serpstack`、`serper`、`Serply`、`DuckDuckGo`、`TavilySearch`、`SearchApi`、`Bing`等のプロバイダーでウェブ検索し、結果をチャットに直接挿入。

- 🌐 **ウェブ閲覧機能**: `#`コマンドの後にURLを入力することで、ウェブサイト内容をチャットに統合。会話をより豊かに、深いものにします。

- 🎨 **画像生成機能統合**: AUTOMATIC1111 APIやComfyUI（ローカル）、OpenAIのDALL-E（外部）などによる画像生成機能をシームレスに統合し、ダイナミックなビジュアル体験を提供。

- ⚙️ **複数モデル同時会話**: 複数モデルを同時に活用し、それぞれの強みを引き出して最適な応答を実現。多様なモデルを並行利用し、体験を向上。

- 🔐 **ロールベースアクセス制御（RBAC）**: 権限を制限し、安全なアクセスを実現。Ollamaへのアクセスやモデル作成/取得権限は管理者のみに限定。

- 🌐🌍 **多言語対応**: 国際化（i18n）により、好きな言語でOpen WebUIを利用可能。言語拡充にご協力ください！コントリビューター募集中！

- 🧩 **パイプライン・Open WebUIプラグインサポート**: [Pipelines Plugin Framework](https://github.com/open-webui/pipelines)でカスタムロジックやPythonライブラリを統合。Pipelinesインスタンスを起動し、OpenAI URLをPipelines URLに設定して新たな可能性を探求。[例](https://github.com/open-webui/pipelines/tree/main/examples): **関数呼び出し**、ユーザー**レート制限**、**使用状況監視**（Langfuse等）、**LibreTranslateによるリアルタイム翻訳**、**有害メッセージフィルタ**など。

- 🌟 **継続的なアップデート**: 定期的な更新、修正、新機能追加でOpen WebUIの改善に取り組んでいます。

Open WebUIの機能についてさらに知りたい方は、[Open WebUIドキュメント](https://docs.openwebui.com/features)で詳細をご覧ください！

## スポンサー 🙌

#### エメラルド

<table>
  <tr>
    <td>
      <a href="https://n8n.io/" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/n8n.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      N8N • あなたのインターフェースにバックエンドはありますか？<br>ぜひ <a href="https://n8n.io/">n8n</a> をお試しください
    </td>
  </tr>
  <tr>
    <td>
      <a href="https://warp.dev/open-webui" target="_blank">
        <img src="https://docs.openwebui.com/sponsors/logos/warp.png" alt="n8n" style="width: 8rem; height: 8rem; border-radius: .75rem;" />
      </a>
    </td>
    <td>
      <a href="https://warp.dev/open-webui">Warp</a> • 開発者向けインテリジェントターミナル
    </td>
  </tr>
</table>

---

寛大なスポンサーのご支援に心より感謝いたします。ご支援のおかげでプロジェクトの維持・改善が可能となり、コミュニティに質の高い成果を届けることができます。ありがとうございます！

## インストール方法 🚀

### Python pipによるインストール 🐍

Open WebUIはPythonパッケージ管理ツールpipでインストールできます。互換性の問題を避けるため、**Python 3.11**をご利用ください。

1. **Open WebUIのインストール**:  
   ターミナルで以下のコマンドを実行します。

   ```bash
   pip install open-webui
   ```

2. **Open WebUIの起動**:  
   インストール後、次のコマンドでOpen WebUIを起動できます。

   ```bash
   open-webui serve
   ```

これでOpen WebUIサーバーが起動し、[http://localhost:8080](http://localhost:8080) でアクセスできます。

### Dockerによるクイックスタート 🐳

> [!NOTE]  
> 一部のDocker環境では追加設定が必要な場合があります。接続問題が発生した場合は、[Open WebUIドキュメント](https://docs.openwebui.com/)をご参照ください。

> [!WARNING]
> Open WebUIをDockerでインストールする際は、必ずコマンドに`-v open-webui:/app/backend/data`を含めてください。これによりデータベースが適切にマウントされ、データ損失を防げます。

> [!TIP]  
> Ollama同梱やCUDA対応でOpen WebUIを利用したい場合は、公式の`:cuda`または`:ollama`タグイメージの利用を推奨します。CUDA有効化には、Linux/WSL環境に[Nvidia CUDA container toolkit](https://docs.nvidia.com/dgx/nvidia-container-runtime-upgrade/)のインストールが必要です。

### デフォルト構成でのインストール

- **Ollamaがローカルにある場合**、以下のコマンドを使用:

  ```bash
  docker run -d -p 3000:8080 --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Ollamaが別サーバーの場合**、以下のコマンドを使用:

  OllamaのサーバーURLに`OLLAMA_BASE_URL`を変更してください。

  ```bash
  docker run -d -p 3000:8080 -e OLLAMA_BASE_URL=https://example.com -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

- **Nvidia GPUサポートでOpen WebUIを実行する場合**:

  ```bash
  docker run -d -p 3000:8080 --gpus all --add-host=host.docker.internal:host-gateway -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:cuda
  ```

### OpenAI APIのみ利用時のインストール

- **OpenAI APIのみ利用する場合**、以下のコマンドを使用:

  ```bash
  docker run -d -p 3000:8080 -e OPENAI_API_KEY=your_secret_key -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:main
  ```

### Ollama同梱Open WebUIのインストール

Open WebUIとOllamaを一体化したコンテナイメージで、1コマンドの簡単セットアップが可能です。ハードウェア構成に応じて下記コマンドを選択してください。

- **GPUサポートあり**:
  GPUリソースを活用する場合は以下を実行:

  ```bash
  docker run -d -p 3000:8080 --gpus=all -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

- **CPUのみの場合**:
  GPU未使用の場合は以下を実行:

  ```bash
  docker run -d -p 3000:8080 -v ollama:/root/.ollama -v open-webui:/app/backend/data --name open-webui --restart always ghcr.io/open-webui/open-webui:ollama
  ```

どちらもOpen WebUIとOllamaの組み込みインストールを簡単に実現します。

インストール後、[http://localhost:3000](http://localhost:3000)でOpen WebUIにアクセスできます。お楽しみください！😄

### その他のインストール方法

Docker未使用のネイティブインストール、Docker Compose、Kustomize、Helmなど各種インストール方法をご用意しています。[Open WebUIドキュメント](https://docs.openwebui.com/getting-started/)や[Discordコミュニティ](https://discord.gg/5rJgQTnV4s)もご活用ください。

### トラブルシューティング

接続問題が発生した場合は、[Open WebUIドキュメント](https://docs.openwebui.com/troubleshooting/)をご参照ください。さらなるサポートやコミュニティ参加は[Open WebUI Discord](https://discord.gg/5rJgQTnV4s)へ。

#### Open WebUI: サーバー接続エラー

WebUIのDockerコンテナが127.0.0.1:11434（host.docker.internal:11434）のOllamaサーバーに接続できない場合が主な原因です。dockerコマンドに`--network=host`フラグを付与して解決できます。この場合ポートは3000から8080に変わり、リンクは`http://localhost:8080`となります。

**例: Docker コマンド**

```bash
docker run -d --network=host -v open-webui:/app/backend/data -e OLLAMA_BASE_URL=http://127.0.0.1:11434 --name open-webui --restart always ghcr.io/open-webui/open-webui:main
```

### Dockerインストールの最新版へのアップデート

Dockerインストールを最新バージョンへアップデートしたい場合は、[Watchtower](https://containrrr.dev/watchtower/)を利用できます。

```bash
docker run --rm --volume /var/run/docker.sock:/var/run/docker.sock containrrr/watchtower --run-once open-webui
```

コマンド末尾の`open-webui`は、コンテナ名が異なる場合は適宜置き換えてください。

更新ガイドは[Open WebUIドキュメント](https://docs.openwebui.com/getting-started/updating)を参照してください。

### Devブランチの利用 🌙

> [!WARNING]
> `:dev`ブランチは最新の不安定な機能や変更が含まれます。バグや未完成機能がある場合もあるので自己責任でご利用ください。

最先端機能を試したい場合、`:dev`タグを次のように使用できます。

```bash
docker run -d -p 3000:8080 -v open-webui:/app/backend/data --name open-webui --add-host=host.docker.internal:host-gateway --restart always ghcr.io/open-webui/open-webui:dev
```

### オフラインモード

オフライン環境でOpen WebUIを利用する場合、`HF_HUB_OFFLINE`環境変数に`1`を設定することでインターネットからのモデルダウンロードを防げます。

```bash
export HF_HUB_OFFLINE=1
```

## 次は何をしますか？🌟

今後の機能予定は[Open WebUIドキュメント](https://docs.openwebui.com/roadmap/)のロードマップをご覧ください。

## ライセンス 📜

本プロジェクトは[Open WebUI License](LICENSE)（改訂版BSD-3-Clauseライセンス）で提供されています。従来のBSD-3ライセンスと同様、ソフトウェアの利用・改変・再配布（商用・プロプライエタリ製品への組込含む）が最小限の制約で可能です。追加要件は「Open WebUI」ブランド表示の維持のみです。詳細は[LICENSE](LICENSE)をご参照ください。📄

## サポート 💬

ご質問・ご提案・サポートが必要な場合はIssueを立てるか、
[Open WebUI Discordコミュニティ](https://discord.gg/5rJgQTnV4s)にご参加ください！🤝

## スター履歴

<a href="https://star-history.com/#open-webui/open-webui&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=open-webui/open-webui&type=Date" />
  </picture>
</a>

---

作成者: [Timothy Jaeryang Baek](https://github.com/tjbck)  
Open WebUIを一緒にさらに素晴らしいものにしていきましょう！💪

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---