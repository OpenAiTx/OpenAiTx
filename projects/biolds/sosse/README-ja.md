<p>
  <img src="https://raw.githubusercontent.com/biolds/sosse/main/se/static/se/logo.svg" width="64" align="right">
  <a href="https://gitlab.com/biolds1/sosse/" alt="Gitlab code coverage" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-coverage/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/pipelines" alt="Gitlab pipeline status" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/pipeline-status/biolds1/sosse?branch=main&style=flat-square">
  </a>
  <a href="https://sosse.readthedocs.io/en/stable/" alt="Documentation" style="text-decoration: none">
    <img src="https://img.shields.io/readthedocs/sosse?style=flat-square">
  </a>
  <a href="https://discord.gg/Vt9cMf7BGK" alt="Discord" style="text-decoration: none">
    <img src="https://img.shields.io/discord/1102142186423844944?style=flat-square&color=%235865f2">
  </a>
  <a href="https://gitlab.com/biolds1/sosse/-/blob/main/LICENSE" alt="License" style="text-decoration: none">
    <img src="https://img.shields.io/gitlab/license/biolds1/sosse?style=flat-square">
  </a>
</p>

# Sosse 🦦

**Sosse を発見する** — 強力なウェブアーカイブ、クロール、検索のために構築された Selenium オープンソース検索エンジン。  
そのすべての機能と能力については、[公式ウェブサイト](https://sosse.io)をご覧ください。

開発者、研究者、データ愛好家のいずれであっても、Sosse はあなたのプロジェクトをサポートする準備ができています。  
[GitHub](https://github.com/biolds/sosse) や [GitLab](https://gitlab.com/biolds1/sosse) のコミュニティに参加して、機能リクエストの提出、バグ報告、コードの貢献、または[ディスカッションの開始](https://github.com/biolds/sosse/discussions)を行いましょう。

## 主な機能

- 🌍 **ウェブページ検索**: 動的にレンダリングされたページを含むウェブページの内容を、高度なクエリで検索可能。  
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/search.html))

- 🕑 **定期クロール**: 固定間隔でページをクロールするか、コンテンツの変化に応じてクロール頻度を調整可能。  
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/crawl/policies.html))

- 🔖 **ウェブページアーカイブ**: HTML コンテンツをアーカイブし、ローカル利用のためにリンクを調整し、必要なアセットをダウンロードし、動的コンテンツもサポート。  
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/archive.html))

- 🏷️ **タグ**: クロールまたはアーカイブしたページをタグで整理・フィルタリングし、検索と管理を向上。  
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/tags.html))
- 📂 **ファイルダウンロード**: ウェブページからバイナリファイルを一括ダウンロードします。
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/download.html))

- 📡 **Webhook**: 高度に柔軟なWebhookを使用して外部サービスと連携します。独自のAIプラットフォーム
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/ai_api_processing.html))やローカルホストのソリューション
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/local_ai.html))に接続して、高度なデータ抽出、
  要約、自動タグ付け、通知などを可能にします。

- 🔔 **Atomフィード**: フィードがないウェブサイトのコンテンツフィードを生成したり、キーワードを含む新しいページが公開されたときに更新情報を受け取ったりできます。
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/feed_website_monitor.html))

- 🔒 **認証**: クローラーは認証してプライベートページにアクセスし、コンテンツを取得できます。
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/guides/authentication.html))

- 👥 **権限管理**: 管理者はクローラーの設定と統計の閲覧が可能で、認証ユーザーは検索を行うか匿名で操作できます。
  ([ドキュメント](https://sosse.readthedocs.io/en/stable/permissions.html))

- 👤 **検索機能**: プライベート検索履歴 ([ドキュメント](https://sosse.readthedocs.io/en/stable/user/history.html)) や外部検索エンジンのショートカット ([ドキュメント](https://sosse.readthedocs.io/en/stable/user/shortcuts.html)) などを含みます。

📚 [ドキュメント](https://sosse.readthedocs.io/en/stable/index.html) を参照し、
📷 [スクリーンショット](https://sosse.readthedocs.io/en/stable/screenshots.html) もご覧ください。

SosseはPythonで書かれており、[GNU AGPLv3ライセンス](https://www.gnu.org/licenses/agpl-3.0.en.html)で配布されています。JavaScriptに依存するページのインデックス作成には、[Mozilla Firefox](https://www.mozilla.org/firefox/) または
[Google Chromium](https://www.chromium.org/Home) と [Selenium](https://www.selenium.dev/) を用いたブラウザベースのクロールを使用します。より高速なクロールには [Requests](https://docs.python-requests.org/en/latest/index.html) も利用可能です。データストレージには [PostgreSQL](https://www.postgresql.org/) を使用しています。

## お試しください

Dockerで最新バージョンをすばやく試すには：





```
docker run -p 8005:80 biolds/sosse:stable
```

次に、[http://127.0.0.1:8005/](http://127.0.0.1:8005/) を開き、ユーザー名 `admin` とパスワード `admin` でログインします。

Dockerデータの永続化や別のインストール方法については、[インストールガイド](https://sosse.readthedocs.io/en/stable/install.html) を参照してください。

## つながりを保つ

サポートを受けたり、アイデアを共有したり、Sosseについて話し合うには、[Discordサーバー](https://discord.gg/Vt9cMf7BGK) に参加してください！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-29

---