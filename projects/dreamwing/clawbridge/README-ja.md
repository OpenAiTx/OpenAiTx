<div align="center">
  <img src="https://raw.githubusercontent.com/dreamwing/clawbridge/master/public/app-icon.png" width="120" alt="ClawBridge ロゴ" />
  <h1>ClawBridge ダッシュボード</h1>
  <p><strong>OpenClaw モバイルダッシュボード＆ミッションコントロール。</strong></p>

  <a href="https://clawbridge.app">
    <img src="https://img.shields.io/badge/Website-clawbridge.app-3b82f6?style=for-the-badge&logo=google-chrome&logoColor=white" alt="ウェブサイト" />
  </a>
  <a href="https://github.com/openclaw/openclaw">
    <img src="https://img.shields.io/badge/OpenClaw-Compatible-22c55e?style=for-the-badge&logo=robot-framework&logoColor=white" alt="OpenClaw" />
  </a>
  <a href="LICENSE">
    <img src="https://img.shields.io/badge/License-MIT-fab005?style=for-the-badge" alt="ライセンス" />
  </a>
  
  <br/><br/>
  [ <strong>English</strong> | <a href="README_CN.md">简体中文</a> ]
</div>

---

**ClawBridge** は OpenClaw エージェントのための決定版 **モバイルダッシュボード** です。ポケットサイズの **ミッションコントロール** として機能し、リアルタイムの思考監視、トークンコストの追跡、バックグラウンドタスクの管理をどこからでも安全かつ即時に行えます。

## ✨ 主な特徴

*   **📱 モバイルファーストダッシュボード**: スマホ画面に最適化。ログ、統計、コントロールを見やすく表示。
*   **🧠 ライブアクティビティフィード**: エージェントの「思考」やツールの実行をリアルタイムで観察。インテリジェントな並列ログ記録（バックグラウンドタスクの取りこぼしなし）と重複排除機能搭載。
*   **💰 トークン経済**: 日次/月次のLLMコストと使用傾向を追跡。お金の使い道を正確に把握。
*   **🔍 [コストコントロールセンター](https://raw.githubusercontent.com/dreamwing/clawbridge/master/docs/cost-control-center.md)**: 10種類の自動診断が使用状況を分析し、節約額を計算、一タップで最適化を適用可能。APIコストを30～90％削減。
*   **📜 メモリータイムライン**: エージェントの日記と長期記憶の変遷を閲覧。
*   **🚀 ミッションコントロール**: UIから直接cronジョブの起動、サービスの再起動、暴走スクリプトの停止が可能。
*   **⚡ ゼロコンフィグリモート**: 
    *   **自動ポート選択**: 3000番ポートが使用中でも自動で空きポートを検出。
    *   **スマートネットワーキング**: **Tailscale/WireGuard** を自動検出し直接安全にアクセス。
    *   **クイックトンネル**: VPNが無い場合はCloudflare経由の一時的な公開URLを自動生成（ゼロコンフィグ）。

## 🚀 インストール

OpenClawサーバー（Ubuntu/Debian）で以下のワンライナーを実行してください：

```bash
curl -sL https://clawbridge.app/install.sh | bash
```
以上です。スクリプトは以下を行います：
1.  あなたの環境（VPNまたはパブリック）を検出します。
2.  安全なアクセスキーを生成します。
3.  すぐに使えるURLを提供します。

## 📱 使い方

### 1. ゼロコンフィグアクセス（デフォルト）
試してみたいだけなら、インストーラーは**クイックトンネル**URLを提供します：
`https://<random-name>.trycloudflare.com/?key=<YOUR_KEY>`

*   **利点**：どこからでも即時アクセス可能。
*   **欠点**：サービスを再起動するとURLが変わります。

### 2. VPN直接アクセス（プライバシー重視）
**Tailscale**や**WireGuard**が検出されると、インストーラーはパブリックトンネルをスキップし、プライベートリンクを提供します：
`http://<VPN_IP>:3000/?key=<YOUR_KEY>`

*   **利点**：最速の速度、最大限のプライバシー。
*   **欠点**：スマホがVPNに接続されている必要があります。

### 3. 永続的なパブリックドメイン（上級者向け）
`dash.yoursite.com`のような固定URLが欲しいですか？
1.  [Cloudflare Dash \> ネットワーキング \> トンネル](https://dash.cloudflare.com/?to=/:account/tunnels)から**Cloudflareトンネルトークン**を取得します。
2.  トークンを使ってインストーラーを実行します：

    ```bash
    cd skills/clawbridge
    ./install.sh --token=<YOUR_TOKEN>
    ```
    *   または新しいクイックトンネルを強制作成: `./install.sh --force-cf`
3.  インストールが成功したら、Cloudflare Tunnelの**Public Hostname**（または**Routes**）ページに戻り、**Add a public hostname**をクリックして、自分のドメインを`localhost:3000`にバインドし、恒久的なアクセスを可能にします。

### 4. Docker（コンテナ化）
ClawBridgeはDockerコンテナとして実行できます。イメージは自動的に[GitHub Container Registry (ghcr.io)](https://github.com/dreamwing/clawbridge/pkgs/container/clawbridge)に公開されています。
```bash
docker pull ghcr.io/dreamwing/clawbridge:latest
docker run -d --name clawbridge \
  -p 3000:3000 \
  -e ACCESS_KEY=your_secret_key \
  -e OPENCLAW_STATE_DIR=/openclaw \
  -e OPENCLAW_WORKSPACE=/openclaw/workspace \
  -v ~/.openclaw:/openclaw:ro \
  -v ./data:/app/data \
  ghcr.io/dreamwing/clawbridge:latest
```

## 📱 モバイルアプリ（PWA）
1.  ダッシュボードをSafari（iOS）またはChrome（Android）で開きます。
2.  「共有」→「ホーム画面に追加」をタップします。
3.  ネイティブアプリのように起動します（全画面表示、ブラウザバーなし）。

## 🛠️ 技術スタック
*   **バックエンド**: Node.js（Express、WebSocket）- 軽量サイドカープロセス。
*   **フロントエンド**: バニラJS - ビルド不要、即時ロード。
*   **トンネル**: Cloudflared

## クレジット

ClawBridgeの改善にご協力いただいたコミュニティの皆様に感謝します：
- [@yaochao](https://github.com/yaochao) 重大なセキュリティおよび移植性の問題報告とアーキテクチャのリファクタリング提案 (#1, #2, #3, #4, #5, #6, #7)。
- [@斯图超哥](https://x.com/StewartLi666) Linux互換性、IP検出の安定性、Quick Tunnelリフレッシュロジックに関するフィードバック (#12)。
- [@zjy4fun](https://github.com/zjy4fun) ワークスペース検出修正の貴重な貢献（PR #22）。
- [@chrisuhg](https://github.com/chrisuhg) インストールおよび認証ループ問題の解決に貴重な貢献（Issue #19）。
- [@ForceConstant](https://github.com/ForceConstant) バージョン付きDockerイメージの機能リクエストに貴重な貢献（#24）（Issue #24）。

---
*MITライセンス。OpenClawコミュニティのために構築。*


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-14

---