**Language:** English | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md) | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

# Everything Claude Code

![Everything Claude Code — the performance system for AI agent harnesses](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/assets/hero.png)

[![Stars](https://img.shields.io/github/stars/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/stargazers)
[![Forks](https://img.shields.io/github/forks/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/network/members)
[![Contributors](https://img.shields.io/github/contributors/affaan-m/everything-claude-code?style=flat)](https://github.com/affaan-m/everything-claude-code/graphs/contributors)
[![npm ecc-universal](https://img.shields.io/npm/dw/ecc-universal?label=ecc-universal%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-universal)
[![npm ecc-agentshield](https://img.shields.io/npm/dw/ecc-agentshield?label=ecc-agentshield%20weekly%20downloads&logo=npm)](https://www.npmjs.com/package/ecc-agentshield)
[![GitHub App Install](https://img.shields.io/badge/GitHub%20App-150%20installs-2ea44f?logo=github)](https://github.com/marketplace/ecc-tools)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
![Shell](https://img.shields.io/badge/-Shell-4EAA25?logo=gnu-bash&logoColor=white)
![TypeScript](https://img.shields.io/badge/-TypeScript-3178C6?logo=typescript&logoColor=white)
![Python](https://img.shields.io/badge/-Python-3776AB?logo=python&logoColor=white)
![Go](https://img.shields.io/badge/-Go-00ADD8?logo=go&logoColor=white)
![Java](https://img.shields.io/badge/-Java-ED8B00?logo=openjdk&logoColor=white)
![Perl](https://img.shields.io/badge/-Perl-39457E?logo=perl&logoColor=white)
![Markdown](https://img.shields.io/badge/-Markdown-000000?logo=markdown&logoColor=white)

> **140K+ stars** | **21K+ forks** | **170+ contributors** | **12+ language ecosystems** | **Anthropic Hackathon Winner**

---

<div align="center">

**Language / 语言 / 語言 / Dil**

[**English**](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.md) | [Português (Brasil)](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/pt-BR/README.md) | [简体中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/README.zh-CN.md) | [繁體中文](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/zh-TW/README.md) | [日本語](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ja-JP/README.md) | [한국어](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ko-KR/README.md)
 | [Türkçe](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/tr/README.md)

</div>

---

**The performance optimization system for AI agent harnesses. From an Anthropic hackathon winner.**

Not just configs. A complete system: skills, instincts, memory optimization, continuous learning, security scanning, and research-first development. Production-ready agents, skills, hooks, rules, MCP configurations, and legacy command shims evolved over 10+ months of intensive daily use building real products.

**Claude Code**、**Codex**、**Cursor**、**OpenCode**、**Gemini**、およびその他のAIエージェントハーネスに対応しています。

ECC v2.0.0-rc.1は、その再利用可能なレイヤーの上にパブリックHermesオペレーターのストーリーを追加します：まず[Hermesセットアップガイド](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/HERMES-SETUP.md)を参照し、その後[rc.1リリースノート](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/releases/2.0.0-rc.1/release-notes.md)と[クロスハーネスアーキテクチャ](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/architecture/cross-harness.md)を確認してください。

---

## ガイド

このリポジトリはコードのみです。ガイドがすべてを説明しています。

<table>
<tr>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2012378465664745795">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/shorthand-guide.png" alt="The Shorthand Guide to Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2014040193557471352">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/guides/longform-guide.png" alt="The Longform Guide to Everything Claude Code" />
</a>
</td>
<td width="33%">
<a href="https://x.com/affaanmustafa/status/2033263813387223421">
<img src="https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./assets/images/security/security-guide-header.png" alt="The Shorthand Guide to Everything Agentic Security" />
</a>
</td>
</tr>
<tr>
<td align="center"><b>ショートハンドガイド</b><br/>セットアップ、基礎、哲学。<b>まずこれを読んでください。</b></td>
<td align="center"><b>ロングフォームガイド</b><br/>トークン最適化、メモリ永続性、評価、並列化。</td>
<td align="center"><b>セキュリティガイド</b><br/>攻撃ベクトル、サンドボックス化、サニタイズ、CVE、AgentShield。</td>
</tr>
</table>

| トピック | 学べる内容 |
|-------|-------------------|
| トークン最適化 | モデル選択、システムプロンプトのスリム化、バックグラウンドプロセス |
| メモリ永続性 | セッション間で自動的にコンテキストを保存/読み込みするフック |
| 継続学習 | セッションからパターンを自動抽出し、再利用可能なスキルに変換 |
| 検証ループ | チェックポイント vs 連続評価、グレーダータイプ、pass@k メトリクス |
| 並列化 | Git ワークツリー、カスケード方式、インスタンス拡張のタイミング |
| サブエージェントオーケストレーション | コンテキスト問題、反復的取得パターン |

---

## 新着情報

### v2.0.0-rc.1 — サーフェス刷新、オペレーター ワークフロー、ECC 2.0 アルファ（2026年4月）

- **ダッシュボード GUI** — 新しい Tkinter ベースのデスクトップアプリケーション（`ecc_dashboard.py` または `npm run dashboard`）で、ダーク/ライトテーマ切替、フォントカスタマイズ、ヘッダーおよびタスクバーにプロジェクトロゴを搭載。
- **パブリックサーフェスがライブリポジトリに同期** — メタデータ、カタログカウント、プラグインマニフェスト、インストール向けドキュメントが実際の OSS サーフェスに一致：48 エージェント、182 スキル、68 レガシーコマンドシム。
- **オペレーターおよびアウトバウンドワークフロー拡充** — `brand-voice`、`social-graph-ranker`、`connections-optimizer`、`customer-billing-ops`、`ecc-tools-cost-audit`、`google-workspace-ops`、`project-flow-ops`、`workspace-surface-audit` がオペレーターラインを完成。
- **メディアおよびローンチツール** — `manim-video`、`remotion-video-creation`、および強化されたソーシャル公開サーフェスにより、技術説明動画とローンチコンテンツを同一システムに統合。
- **フレームワークおよび製品サーフェス拡大** — `nestjs-patterns`、より豊かな Codex/OpenCode インストールサーフェス、拡張されたクロスハーネスパッケージングにより、Claude Code 単独を超えてリポジトリの利用性を維持。
- **ECC 2.0 アルファがインツリー化** — `ecc2/` の Rust コントロールプレーンプロトタイプがローカルビルド可能になり、`dashboard`、`start`、`sessions`、`status`、`stop`、`resume`、`daemon` コマンドを公開。アルファとして使用可能で、まだ一般リリースではない。
- **エコシステム強化** — AgentShield、ECC Tools コスト管理、請求ポータル作業、ウェブサイト刷新がコアプラグイン周辺で継続的に提供され、別々のサイロに分散しない。

### v1.9.0 — 選択的インストールと言語拡張（2026年3月）

- **選択的インストールアーキテクチャ** — マニフェスト駆動のインストールパイプラインで、`install-plan.js` と `install-apply.js` によりターゲットコンポーネントのインストールを実現。状態ストアがインストール済みを追跡し、増分更新を可能に。
- **6 新エージェント** — `typescript-reviewer`、`pytorch-build-resolver`、`java-build-resolver`、`java-reviewer`、`kotlin-reviewer`、`kotlin-build-resolver` により言語対応が 10 言語に拡大。
- **新スキル** — 深層学習ワークフロー向け `pytorch-patterns`、API リファレンス調査用 `documentation-lookup`、最新 JS ツールチェーンの `bun-runtime` と `nextjs-turbopack`、さらに 8 の運用ドメインスキルと `mcp-server-patterns`。
- **セッション＆状態インフラ** — SQLite 状態ストアとクエリ CLI、構造化記録のためのセッションアダプター、自己改善スキルのためのスキル進化基盤。
- **オーケストレーション刷新** — Harness 監査スコアを決定論的にし、オーケストレーション状態とランチャー互換性を強化、5層ガードによるオブザーバーループ防止。
- **オブザーバー信頼性** — スロットリングとテイルサンプリングによるメモリ爆発修正、サンドボックスアクセス修正、遅延起動ロジック、再入制御ガード。
- **12 言語エコシステム** — Java、PHP、Perl、Kotlin/Android/KMP、C++、Rust 向けの新ルールが、既存の TypeScript、Python、Go、共通ルールに加わる。
- **コミュニティ貢献** — 韓国語・中国語翻訳、バイオームフック最適化、動画処理スキル、運用スキル、PowerShell インストーラー、Antigravity IDE サポート。
- **CI 強化** — 19 件のテスト失敗修正、カタログカウント検証、インストールマニフェスト検証、完全テストスイートのグリーン化。

### v1.8.0 — Harness パフォーマンスシステム（2026年3月）

- **Harness ファーストリリース** — ECC はもはや単なる設定パックではなく、エージェントハーネスパフォーマンスシステムとして明確に位置付け。
- **フック信頼性刷新** — SessionStart ルートフォールバック、Stop フェーズのセッションサマリー、脆弱なインラインワンライナーに代わるスクリプトベースフック。
- **フックランタイム制御** — フックファイル編集不要のランタイム制御に `ECC_HOOK_PROFILE=minimal|standard|strict` と `ECC_DISABLED_HOOKS=...`。
- **新ハーネスコマンド** — `/harness-audit`、`/loop-start`、`/loop-status`、`/quality-gate`、`/model-route`。
- **NanoClaw v2** — モデルルーティング、スキルホットロード、セッションのブランチ/検索/エクスポート/コンパクト/メトリクス。
- **クロスハーネスパリティ** — Claude Code、Cursor、OpenCode、Codex のアプリ/CLI 間の挙動を統一。
- **997 内部テスト合格** — フック／ランタイムリファクタリングと互換性更新後にフルスイートがグリーン。

### v1.7.0 — クロスプラットフォーム拡張 & プレゼンテーションビルダー（2026年2月）

- **Codexアプリ + CLIサポート** — 直接の `AGENTS.md` ベースのCodexサポート、インストーラーターゲティング、Codexドキュメント
- **`frontend-slides` スキル** — PPTX変換ガイダンスと厳密なビューポートフィットルールを備えたゼロ依存HTMLプレゼンテーションビルダー
- **5つの新しい汎用ビジネス/コンテンツスキル** — `article-writing`、`content-engine`、`market-research`、`investor-materials`、`investor-outreach`
- **ツールカバレッジの拡大** — Cursor、Codex、OpenCodeのサポート強化により、同一リポジトリが主要な全ハーネスでクリーンに動作
- **992の内部テスト** — プラグイン、フック、スキル、パッケージング全体で検証と回帰テストの拡充

### v1.6.0 — Codex CLI、AgentShield & マーケットプレイス（2026年2月）

- **Codex CLIサポート** — 新しい `/codex-setup` コマンドがOpenAI Codex CLI互換の `codex.md` を生成
- **7つの新しいスキル** — `search-first`、`swift-actor-persistence`、`swift-protocol-di-testing`、`regex-vs-llm-structured-text`、`content-hash-cache-pattern`、`cost-aware-llm-pipeline`、`skill-stocktake`
- **AgentShield統合** — `/security-scan` スキルがClaude Codeから直接AgentShieldを実行；1282テスト、102ルール
- **GitHubマーケットプレイス** — ECC Tools GitHubアプリが [github.com/marketplace/ecc-tools](https://github.com/marketplace/ecc-tools) で公開、無料/プロ/エンタープライズプラン対応
- **30以上のコミュニティPRマージ** — 6言語にわたる30名の貢献者からの寄与
- **978の内部テスト** — エージェント、スキル、コマンド、フック、ルールの検証スイート拡大

### v1.4.1 — バグ修正（2026年2月）

- **instinctインポートの内容損失を修正** — `/instinct-import` 実行時に `parse_instinct_file()` がフロントマター（Action、Evidence、Examplesセクション）以降の全内容を静かに破棄していた問題を修正。([#148](https://github.com/affaan-m/everything-claude-code/issues/148)、[#161](https://github.com/affaan-m/everything-claude-code/pull/161))

### v1.4.0 — 多言語ルール、インストールウィザード & PM2（2026年2月）

- **対話型インストールウィザード** — 新しい `configure-ecc` スキルがマージ・上書き検出付きのセットアップガイドを提供
- **PM2 & マルチエージェントオーケストレーション** — 複雑なマルチサービスワークフロー管理のための6つの新コマンド（`/pm2`、`/multi-plan`、`/multi-execute`、`/multi-backend`、`/multi-frontend`、`/multi-workflow`）
- **多言語ルールアーキテクチャ** — ルールをフラットファイルから `common/`、`typescript/`、`python/`、`golang/` ディレクトリに再構成。必要な言語のみインストール可能
- **中国語（zh-CN）翻訳** — 全エージェント、コマンド、スキル、ルール（80以上のファイル）を完全翻訳
- **GitHub Sponsors対応** — GitHub Sponsors経由でプロジェクトを支援可能
- **CONTRIBUTING.md強化** — 各貢献タイプ向けの詳細なPRテンプレート

### v1.3.0 — OpenCodeプラグインサポート（2026年2月）

- **完全なOpenCode統合** — OpenCodeのプラグインシステム（20以上のイベントタイプ）を介した12エージェント、24コマンド、16スキルのフックサポート
- **3つのネイティブカスタムツール** — run-tests、check-coverage、security-audit
- **LLMドキュメント** — 包括的なOpenCodeドキュメント用の `llms.txt`

### v1.2.0 — 統一コマンド & スキル（2026年2月）

- **Python/Djangoサポート** — Djangoパターン、セキュリティ、TDD、検証スキル
- **Java Spring Bootスキル** — Spring Bootのパターン、セキュリティ、TDD、検証
- **セッション管理** — セッション履歴用の `/sessions` コマンド  
- **継続学習 v2** — 信頼度スコア付きの本能ベース学習、インポート/エクスポート、進化  

完全な変更履歴は[Releases](https://github.com/affaan-m/everything-claude-code/releases)をご覧ください。  

---  

## クイックスタート  

2分以内にセットアップ完了：  

### どちらか一つのパスを選択  

ほとんどのClaude Codeユーザーは、正確に一つのインストールパスを使用するべきです：  

- **推奨デフォルト：** Claude Codeプラグインをインストールし、必要なルールフォルダのみをコピーします。  
- **マニュアルインストーラーは、** より細かい制御が必要な場合、プラグインパスを完全に避けたい場合、またはClaude Codeビルドがセルフホステッドマーケットプレイスのエントリを解決できない場合にのみ使用してください。  
- **インストール方法を重ねてはいけません。** 最もよくある壊れた構成は：まず `/plugin install` を実行し、その後に `install.sh --profile full` または `npx ecc-install --profile full` を実行することです。  

すでに複数のインストールを重ねて重複が見られる場合は、すぐに[Reset / Uninstall ECC](#reset--uninstall-ecc)に進んでください。  

### 低コンテキスト / フックなしパス  

フックがあまりにもグローバルすぎると感じる場合や、ECCのルール、エージェント、コマンド、コアワークフロースキルだけを使いたい場合は、プラグインをスキップして最小限のマニュアルプロファイルを使用してください：

```bash
./install.sh --profile minimal --target claude
```

```powershell
.\install.ps1 --profile minimal --target claude
# or
npx ecc-install --profile minimal --target claude
```
このプロファイルは意図的に `hooks-runtime` を除外しています。

通常のコアプロファイルが必要で、フックを無効にしたい場合は、次を使用してください：


```bash
./install.sh --profile core --without baseline:hooks --target claude
```

後でフックを追加するのは、実行時の強制を行いたい場合のみです:

```bash
./install.sh --target claude --modules hooks-runtime
```

### まずは適切なコンポーネントを見つける

どのECCプロファイルやコンポーネントをインストールすべきか分からない場合は、任意のプロジェクトからパッケージアドバイザーに問い合わせてください:

```bash
npx ecc consult "security reviews" --target claude
```

一致するコンポーネント、関連するプロファイル、およびプレビュー/インストールコマンドを返します。正確なファイルプランを確認したい場合は、インストール前にプレビューコマンドを使用してください。

### ステップ1：プラグインのインストール（推奨）

> 注意：プラグインは便利ですが、Claude Code ビルドがセルフホステッドマーケットプレイスのエントリを解決するのに問題がある場合は、以下のOSSインストーラーが最も信頼できる方法です。

```bash
# Add marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install plugin
/plugin install everything-claude-code@everything-claude-code
```

### 命名＋移行ノート

ECCには現在3つの公開識別子があり、互換性はありません：

- GitHubソースリポジトリ：`affaan-m/everything-claude-code`
- Claudeマーケットプレイス／プラグイン識別子：`everything-claude-code@everything-claude-code`
- npmパッケージ：`ecc-universal`

これは意図的なものです。Anthropicマーケットプレイス／プラグインのインストールは正規のプラグイン識別子でキー付けされるため、ECCはリスティング名、`/plugin install`、`/plugin list`、およびリポジトリのドキュメントを1つの公開インストール表面に合わせるために`everything-claude-code@everything-claude-code`を標準化しました。古い投稿にはまだ旧短縮ニックネームが表示されることがありますが、その略称は非推奨です。別途、npmパッケージは`ecc-universal`のままなので、npmインストールとマーケットプレイスインストールは意図的に異なる名前を使用しています。

### ステップ2：ルールのインストール（必須）

> 警告：**重要：** Claude Codeプラグインは`rules`を自動配布できません。
>
> すでに`/plugin install`でECCをインストールしている場合、**その後に`./install.sh --profile full`、`.\install.ps1 --profile full`、または`npx ecc-install --profile full`を実行しないでください**。プラグインはすでにECCのスキル、コマンド、フックを読み込んでいます。プラグインインストール後にフルインストーラーを実行すると、同じ表面がユーザーディレクトリにコピーされ、スキルの重複や実行時の動作重複が発生する可能性があります。
>
> プラグインインストールの場合、必要な`rules/`ディレクトリのみを`~/.claude/rules/ecc/`以下に手動でコピーしてください。`rules/common`と実際に使う言語やフレームワークのパック1つから始めてください。すべてのルールディレクトリをコピーすると、Claudeにその全コンテキストが明示的に欲しい場合を除き避けてください。
>
> フルインストーラーは、プラグイン経由ではなく完全手動でECCをインストールする場合にのみ使用してください。
>
> ローカルのClaudeセットアップが消去またはリセットされた場合でも、ECCを再購入する必要はありません。まず`node scripts/ecc.js list-installed`を実行し、続けて`node scripts/ecc.js doctor`と`node scripts/ecc.js repair`を実行してから再インストールしてください。これにより通常はECC管理ファイルが再構築せずに復元されます。問題がECCツールのアカウントまたはマーケットプレイスアクセスの場合は、課金／アカウント回復を別途対応してください。

```bash
# Clone the repo first
git clone https://github.com/affaan-m/everything-claude-code.git
cd everything-claude-code

# Install dependencies (pick your package manager)
npm install        # or: pnpm install | yarn install | bun install

# Plugin install path: copy only ECC rules into an ECC-owned namespace
mkdir -p ~/.claude/rules/ecc
cp -R rules/common ~/.claude/rules/ecc/
cp -R rules/typescript ~/.claude/rules/ecc/

# Fully manual ECC install path (use this instead of /plugin install)
# ./install.sh --profile full
```

```powershell
# Windows PowerShell

# Plugin install path: copy only ECC rules into an ECC-owned namespace
New-Item -ItemType Directory -Force -Path "$HOME/.claude/rules/ecc" | Out-Null
Copy-Item -Recurse rules/common "$HOME/.claude/rules/ecc/"
Copy-Item -Recurse rules/typescript "$HOME/.claude/rules/ecc/"

# Fully manual ECC install path (use this instead of /plugin install)
# .\install.ps1 --profile full
# npx ecc-install --profile full
```

手動インストールの手順については、`rules/` フォルダー内の README を参照してください。ルールを手動でコピーする場合は、内部のファイルではなく言語ディレクトリ全体（例えば `rules/common` や `rules/golang`）をコピーしてください。これにより相対参照が機能し続け、ファイル名の衝突を防げます。

### 完全手動インストール（フォールバック）

プラグインパスを意図的にスキップする場合にのみ使用してください：

```bash
./install.sh --profile full
```

```powershell
.\install.ps1 --profile full
# or
npx ecc-install --profile full
```

この方法を選択した場合、そこで止めてください。`/plugin install`も実行しないでください。

### ECCのリセット / アンインストール

ECCが重複している、煩わしい、または壊れていると感じた場合は、何度も再インストールしないでください。

- **プラグインパス:** Claude Codeからプラグインを削除し、その後手動でコピーした`~/.claude/rules/ecc/`内の特定のルールフォルダを削除します。
- **手動インストーラー / CLIパス:** リポジトリのルートから、まず削除をプレビューします：

```bash
node scripts/uninstall.js --dry-run
```

次に、ECC管理ファイルを削除します：

```bash
node scripts/uninstall.js
```

ライフサイクルラッパーも使用できます：

```bash
node scripts/ecc.js list-installed
node scripts/ecc.js doctor
node scripts/ecc.js repair
node scripts/ecc.js uninstall --dry-run
```
ECCはインストール状態に記録されたファイルのみを削除します。インストールしていない関連のないファイルは削除しません。

もしメソッドを積み重ねた場合は、次の順序でクリーンアップしてください：

1. Claude Codeプラグインのインストールを削除します。
2. リポジトリのルートからECCのアンインストールコマンドを実行して、インストール状態管理ファイルを削除します。
3. 手動でコピーした不要なルールフォルダを削除します。
4. 一度だけ、単一のパスを使って再インストールします。

### ステップ3: 使用開始


```bash
# Skills are the primary workflow surface.
# Existing slash-style command names still work while ECC migrates off commands/.

# Plugin install uses the canonical namespaced form
/everything-claude-code:plan "Add user authentication"

# Manual install keeps the shorter slash form:
# /plan "Add user authentication"

# Check available commands
/plugin list everything-claude-code@everything-claude-code
```

**以上です！** これで48のエージェント、182のスキル、および68のレガシーコマンドシムにアクセスできます。

### ダッシュボードGUI

デスクトップダッシュボードを起動して、ECCコンポーネントを視覚的に探索しましょう：

```bash
npm run dashboard
# or
python3 ./ecc_dashboard.py
```
**特徴:**
- タブ式インターフェイス: エージェント、スキル、コマンド、ルール、設定
- ダーク/ライトテーマ切り替え
- フォントカスタマイズ（ファミリー＆サイズ）
- ヘッダーとタスクバーにプロジェクトロゴ
- すべてのコンポーネントでの検索とフィルタリング

### マルチモデルコマンドは追加設定が必要

> 警告: `multi-*` コマンドは上記の基本プラグイン/ルールのインストールには**含まれていません**。
>
> `/multi-plan`、`/multi-execute`、`/multi-backend`、`/multi-frontend`、および `/multi-workflow` を使用するには、`ccg-workflow` ランタイムもインストールする必要があります。
>
> `npx ccg-workflow` で初期化してください。
>
> このランタイムはこれらのコマンドが期待する外部依存関係を提供します。例：
> - `~/.claude/bin/codeagent-wrapper`
> - `~/.claude/.ccg/prompts/*`
>
> `ccg-workflow` がないと、これらの `multi-*` コマンドは正しく動作しません。

---

## クロスプラットフォーム対応

このプラグインは現在、**Windows、macOS、Linux** を完全にサポートし、主要なIDE（Cursor、OpenCode、Antigravity）やCLIハーネスとの緊密な統合も実現しています。すべてのフックとスクリプトは最大の互換性を目指してNode.jsで書き直されています。

### パッケージマネージャーの検出

プラグインは優先順位に従い、使用中のパッケージマネージャー（npm、pnpm、yarn、bun）を自動検出します：

1. **環境変数**: `CLAUDE_PACKAGE_MANAGER`
2. **プロジェクト設定**: `.claude/package-manager.json`
3. **package.json**: `packageManager` フィールド
4. **ロックファイル**: package-lock.json、yarn.lock、pnpm-lock.yaml、bun.lockbから検出
5. **グローバル設定**: `~/.claude/package-manager.json`
6. **フォールバック**: 利用可能な最初のパッケージマネージャー

使用したいパッケージマネージャーを設定するには：


```bash
# Via environment variable
export CLAUDE_PACKAGE_MANAGER=pnpm

# Via global config
node scripts/setup-package-manager.js --global pnpm

# Via project config
node scripts/setup-package-manager.js --project bun

# Detect current setting
node scripts/setup-package-manager.js --detect
```

またはClaude Codeで`/setup-pm`コマンドを使用します。

### フックランタイムコントロール

実行時フラグを使用して厳密さを調整したり、特定のフックを一時的に無効にしたりします：

```bash
# Hook strictness profile (default: standard)
export ECC_HOOK_PROFILE=standard

# Comma-separated hook IDs to disable
export ECC_DISABLED_HOOKS="pre:bash:tmux-reminder,post:edit:typecheck"

# Cap SessionStart additional context (default: 8000 chars)
export ECC_SESSION_START_MAX_CHARS=4000

# Disable SessionStart additional context entirely for low-context/local-model setups
export ECC_SESSION_START_CONTEXT=off
```

---

## What's Inside

This repo is a **Claude Code plugin** - install it directly or copy components manually.

```
everything-claude-code/
|-- .claude-plugin/   # Plugin and marketplace manifests
|   |-- plugin.json         # Plugin metadata and component paths
|   |-- marketplace.json    # Marketplace catalog for /plugin marketplace add
|
|-- agents/           # 36 specialized subagents for delegation
|   |-- planner.md           # Feature implementation planning
|   |-- architect.md         # System design decisions
|   |-- tdd-guide.md         # Test-driven development
|   |-- code-reviewer.md     # Quality and security review
|   |-- security-reviewer.md # Vulnerability analysis
|   |-- build-error-resolver.md
|   |-- e2e-runner.md        # Playwright E2E testing
|   |-- refactor-cleaner.md  # Dead code cleanup
|   |-- doc-updater.md       # Documentation sync
|   |-- docs-lookup.md       # Documentation/API lookup
|   |-- chief-of-staff.md    # Communication triage and drafts
|   |-- loop-operator.md     # Autonomous loop execution
|   |-- harness-optimizer.md # Harness config tuning
|   |-- cpp-reviewer.md      # C++ code review
|   |-- cpp-build-resolver.md # C++ build error resolution
|   |-- go-reviewer.md       # Go code review
|   |-- go-build-resolver.md # Go build error resolution
|   |-- python-reviewer.md   # Python code review
|   |-- database-reviewer.md # Database/Supabase review
|   |-- typescript-reviewer.md # TypeScript/JavaScript code review
|   |-- java-reviewer.md     # Java/Spring Boot code review
|   |-- java-build-resolver.md # Java/Maven/Gradle build errors
|   |-- kotlin-reviewer.md   # Kotlin/Android/KMP code review
|   |-- kotlin-build-resolver.md # Kotlin/Gradle build errors
|   |-- rust-reviewer.md     # Rust code review
|   |-- rust-build-resolver.md # Rust build error resolution
|   |-- pytorch-build-resolver.md # PyTorch/CUDA training errors
|
|-- skills/           # Workflow definitions and domain knowledge
|   |-- coding-standards/           # Language best practices
|   |-- clickhouse-io/              # ClickHouse analytics, queries, data engineering
|   |-- backend-patterns/           # API, database, caching patterns
|   |-- frontend-patterns/          # React, Next.js patterns
|   |-- frontend-slides/            # HTML slide decks and PPTX-to-web presentation workflows (NEW)
|   |-- article-writing/            # Long-form writing in a supplied voice without generic AI tone (NEW)
|   |-- content-engine/             # Multi-platform social content and repurposing workflows (NEW)
|   |-- market-research/            # Source-attributed market, competitor, and investor research (NEW)
|   |-- investor-materials/         # Pitch decks, one-pagers, memos, and financial models (NEW)
|   |-- investor-outreach/          # Personalized fundraising outreach and follow-up (NEW)
|   |-- continuous-learning/        # Legacy v1 Stop-hook pattern extraction
|   |-- continuous-learning-v2/     # Instinct-based learning with confidence scoring
|   |-- iterative-retrieval/        # Progressive context refinement for subagents
|   |-- strategic-compact/          # Manual compaction suggestions (Longform Guide)
|   |-- tdd-workflow/               # TDD methodology
|   |-- security-review/            # Security checklist
|   |-- eval-harness/               # Verification loop evaluation (Longform Guide)
|   |-- verification-loop/          # Continuous verification (Longform Guide)
|   |-- videodb/                   # Video and audio: ingest, search, edit, generate, stream (NEW)
|   |-- golang-patterns/            # Go idioms and best practices
|   |-- golang-testing/             # Go testing patterns, TDD, benchmarks
|   |-- cpp-coding-standards/         # C++ coding standards from C++ Core Guidelines (NEW)
|   |-- cpp-testing/                # C++ testing with GoogleTest, CMake/CTest (NEW)
|   |-- django-patterns/            # Django patterns, models, views (NEW)
|   |-- django-security/            # Django security best practices (NEW)
|   |-- django-tdd/                 # Django TDD workflow (NEW)
|   |-- django-verification/        # Django verification loops (NEW)
|   |-- laravel-patterns/           # Laravel architecture patterns (NEW)
|   |-- laravel-security/           # Laravel security best practices (NEW)
|   |-- laravel-tdd/                # Laravel TDD workflow (NEW)
|   |-- laravel-verification/       # Laravel verification loops (NEW)
|   |-- python-patterns/            # Python idioms and best practices (NEW)
|   |-- python-testing/             # Python testing with pytest (NEW)
|   |-- springboot-patterns/        # Java Spring Boot patterns (NEW)
|   |-- springboot-security/        # Spring Boot security (NEW)
|   |-- springboot-tdd/             # Spring Boot TDD (NEW)
|   |-- springboot-verification/    # Spring Boot verification (NEW)
|   |-- configure-ecc/              # Interactive installation wizard (NEW)
|   |-- security-scan/              # AgentShield security auditor integration (NEW)
|   |-- java-coding-standards/     # Java coding standards (NEW)
|   |-- jpa-patterns/              # JPA/Hibernate patterns (NEW)
|   |-- postgres-patterns/         # PostgreSQL optimization patterns (NEW)
|   |-- nutrient-document-processing/ # Document processing with Nutrient API (NEW)
|   |-- docs/examples/project-guidelines-template.md  # Template for project-specific skills
|   |-- database-migrations/         # Migration patterns (Prisma, Drizzle, Django, Go) (NEW)
|   |-- api-design/                  # REST API design, pagination, error responses (NEW)
|   |-- deployment-patterns/         # CI/CD, Docker, health checks, rollbacks (NEW)
|   |-- docker-patterns/            # Docker Compose, networking, volumes, container security (NEW)
|   |-- e2e-testing/                 # Playwright E2E patterns and Page Object Model (NEW)
|   |-- content-hash-cache-pattern/  # SHA-256 content hash caching for file processing (NEW)
|   |-- cost-aware-llm-pipeline/     # LLM cost optimization, model routing, budget tracking (NEW)
|   |-- regex-vs-llm-structured-text/ # Decision framework: regex vs LLM for text parsing (NEW)
|   |-- swift-actor-persistence/     # Thread-safe Swift data persistence with actors (NEW)
|   |-- swift-protocol-di-testing/   # Protocol-based DI for testable Swift code (NEW)
|   |-- search-first/               # Research-before-coding workflow (NEW)
|   |-- skill-stocktake/            # Audit skills and commands for quality (NEW)
|   |-- liquid-glass-design/         # iOS 26 Liquid Glass design system (NEW)
|   |-- foundation-models-on-device/ # Apple on-device LLM with FoundationModels (NEW)
|   |-- swift-concurrency-6-2/       # Swift 6.2 Approachable Concurrency (NEW)
|   |-- perl-patterns/             # Modern Perl 5.36+ idioms and best practices (NEW)
|   |-- perl-security/             # Perl security patterns, taint mode, safe I/O (NEW)
|   |-- perl-testing/              # Perl TDD with Test2::V0, prove, Devel::Cover (NEW)
|   |-- autonomous-loops/           # Autonomous loop patterns: sequential pipelines, PR loops, DAG orchestration (NEW)
|   |-- plankton-code-quality/      # Write-time code quality enforcement with Plankton hooks (NEW)
|
|-- commands/         # Maintained slash-entry compatibility; prefer skills/
|   |-- plan.md             # /plan - Implementation planning
|   |-- code-review.md      # /code-review - Quality review
|   |-- build-fix.md        # /build-fix - Fix build errors
|   |-- refactor-clean.md   # /refactor-clean - Dead code removal
|   |-- quality-gate.md     # /quality-gate - Verification gate
|   |-- learn.md            # /learn - Extract patterns mid-session (Longform Guide)
|   |-- learn-eval.md       # /learn-eval - Extract, evaluate, and save patterns (NEW)
|   |-- checkpoint.md       # /checkpoint - Save verification state (Longform Guide)
|   |-- setup-pm.md         # /setup-pm - Configure package manager
|   |-- go-review.md        # /go-review - Go code review (NEW)
|   |-- go-test.md          # /go-test - Go TDD workflow (NEW)
|   |-- go-build.md         # /go-build - Fix Go build errors (NEW)
|   |-- skill-create.md     # /skill-create - Generate skills from git history (NEW)
|   |-- instinct-status.md  # /instinct-status - View learned instincts (NEW)
|   |-- instinct-import.md  # /instinct-import - Import instincts (NEW)
|   |-- instinct-export.md  # /instinct-export - Export instincts (NEW)
|   |-- evolve.md           # /evolve - Cluster instincts into skills
|   |-- prune.md            # /prune - Delete expired pending instincts (NEW)
|   |-- pm2.md              # /pm2 - PM2 service lifecycle management (NEW)
|   |-- multi-plan.md       # /multi-plan - Multi-agent task decomposition (NEW)
|   |-- multi-execute.md    # /multi-execute - Orchestrated multi-agent workflows (NEW)
|   |-- multi-backend.md    # /multi-backend - Backend multi-service orchestration (NEW)
|   |-- multi-frontend.md   # /multi-frontend - Frontend multi-service orchestration (NEW)
|   |-- multi-workflow.md   # /multi-workflow - General multi-service workflows (NEW)
|   |-- sessions.md         # /sessions - Session history management
|   |-- test-coverage.md    # /test-coverage - Test coverage analysis
|   |-- update-docs.md      # /update-docs - Update documentation
|   |-- update-codemaps.md  # /update-codemaps - Update codemaps
|   |-- python-review.md    # /python-review - Python code review (NEW)
|-- legacy-command-shims/   # Opt-in archive for retired shims such as /tdd and /eval
|   |-- tdd.md              # /tdd - Prefer the tdd-workflow skill
|   |-- e2e.md              # /e2e - Prefer the e2e-testing skill
|   |-- eval.md             # /eval - Prefer the eval-harness skill
|   |-- verify.md           # /verify - Prefer the verification-loop skill
|   |-- orchestrate.md      # /orchestrate - Prefer dmux-workflows or multi-workflow
|
|-- rules/            # Always-follow guidelines (copy to ~/.claude/rules/ecc/)
|   |-- README.md            # Structure overview and installation guide
|   |-- common/              # Language-agnostic principles
|   |   |-- coding-style.md    # Immutability, file organization
|   |   |-- git-workflow.md    # Commit format, PR process
|   |   |-- testing.md         # TDD, 80% coverage requirement
|   |   |-- performance.md     # Model selection, context management
|   |   |-- patterns.md        # Design patterns, skeleton projects
|   |   |-- hooks.md           # Hook architecture, TodoWrite
|   |   |-- agents.md          # When to delegate to subagents
|   |   |-- security.md        # Mandatory security checks
|   |-- typescript/          # TypeScript/JavaScript specific
|   |-- python/              # Python specific
|   |-- golang/              # Go specific
|   |-- swift/               # Swift specific
|   |-- php/                 # PHP specific (NEW)
|
|-- hooks/            # Trigger-based automations
|   |-- README.md                 # Hook documentation, recipes, and customization guide
|   |-- hooks.json                # All hooks config (PreToolUse, PostToolUse, Stop, etc.)
|   |-- memory-persistence/       # Session lifecycle hooks (Longform Guide)
|   |-- strategic-compact/        # Compaction suggestions (Longform Guide)
|
|-- scripts/          # Cross-platform Node.js scripts (NEW)
|   |-- lib/                     # Shared utilities
|   |   |-- utils.js             # Cross-platform file/path/system utilities
|   |   |-- package-manager.js   # Package manager detection and selection
|   |-- hooks/                   # Hook implementations
|   |   |-- session-start.js     # Load context on session start
|   |   |-- session-end.js       # Save state on session end
|   |   |-- pre-compact.js       # Pre-compaction state saving
|   |   |-- suggest-compact.js   # Strategic compaction suggestions
|   |   |-- evaluate-session.js  # Extract patterns from sessions
|   |-- setup-package-manager.js # Interactive PM setup
|
|-- tests/            # Test suite (NEW)
|   |-- lib/                     # Library tests
|   |-- hooks/                   # Hook tests
|   |-- run-all.js               # Run all tests
|
|-- contexts/         # Dynamic system prompt injection contexts (Longform Guide)
|   |-- dev.md              # Development mode context
|   |-- review.md           # Code review mode context
|   |-- research.md         # Research/exploration mode context
|
|-- examples/         # Example configurations and sessions
|   |-- CLAUDE.md             # Example project-level config
|   |-- user-CLAUDE.md        # Example user-level config
|   |-- saas-nextjs-CLAUDE.md   # Real-world SaaS (Next.js + Supabase + Stripe)
|   |-- go-microservice-CLAUDE.md # Real-world Go microservice (gRPC + PostgreSQL)
|   |-- django-api-CLAUDE.md      # Real-world Django REST API (DRF + Celery)
|   |-- laravel-api-CLAUDE.md     # Real-world Laravel API (PostgreSQL + Redis) (NEW)
|   |-- rust-api-CLAUDE.md        # Real-world Rust API (Axum + SQLx + PostgreSQL) (NEW)
|
|-- mcp-configs/      # MCP server configurations
|   |-- mcp-servers.json    # GitHub, Supabase, Vercel, Railway, etc.
|
|-- ecc_dashboard.py  # Desktop GUI dashboard (Tkinter)
|
|-- assets/           # Assets for dashboard
|   |-- images/
|       |-- ecc-logo.png
|
|-- marketplace.json  # Self-hosted marketplace config (for /plugin marketplace add)
```

---

## エコシステムツール

### スキルクリエイター

リポジトリからClaude Codeスキルを生成する2つの方法：

#### オプションA：ローカル解析（内蔵）

外部サービスを使わずにローカル解析を行うには、`/skill-create`コマンドを使用します：

```bash
/skill-create                    # Analyze current repo
/skill-create --instincts        # Also generate instincts for continuous-learning-v2
```

これはローカルでgit履歴を分析し、SKILL.mdファイルを生成します。

#### オプションB: GitHubアプリ（上級者向け）

高度な機能（1万件以上のコミット、自動PR、チーム共有）向け：

[GitHubアプリをインストール](https://github.com/apps/skill-creator) | [ecc.tools](https://ecc.tools)

```bash
# Comment on any issue:
/skill-creator analyze

# Or auto-triggers on push to default branch
```

両方のオプションは以下を作成します：
- **SKILL.md ファイル** - Claude Code 用のすぐに使えるスキル
- **Instinct コレクション** - continuous-learning-v2 用
- **パターン抽出** - コミット履歴から学習

### AgentShield — セキュリティ監査ツール

> Claude Code ハッカソン（Cerebral Valley x Anthropic、2026年2月）で作成。1282件のテスト、98％のカバレッジ、102の静的解析ルール。

Claude Code の設定をスキャンして、脆弱性、誤設定、インジェクションリスクを検出します。

```bash
# Quick scan (no install needed)
npx ecc-agentshield scan

# Auto-fix safe issues
npx ecc-agentshield scan --fix

# Deep analysis with three Opus 4.6 agents
npx ecc-agentshield scan --opus --stream

# Generate secure config from scratch
npx ecc-agentshield init
```

**スキャン対象:** CLAUDE.md、settings.json、MCP設定、フック、エージェント定義、および5つのカテゴリにわたるスキル — シークレット検出（14パターン）、権限監査、フックインジェクション分析、MCPサーバーリスクプロファイリング、エージェント設定レビュー。

**`--opus` フラグ** は、レッドチーム／ブルーチーム／監査人のパイプラインで3つのClaude Opus 4.6エージェントを実行します。攻撃者がエクスプロイトチェーンを発見し、防御者が保護を評価し、監査人が両者を優先順位付きリスク評価に統合します。単なるパターンマッチングではなく、敵対的推論です。

**出力形式:** ターミナル（A-Fのカラーグレーディング）、JSON（CIパイプライン用）、Markdown、HTML。重大な発見時にはビルドゲート用に終了コード2を返します。

Claude Codeで`/security-scan`を使って実行するか、[GitHub Action](https://github.com/affaan-m/agentshield)でCIに追加してください。

[GitHub](https://github.com/affaan-m/agentshield) | [npm](https://www.npmjs.com/package/ecc-agentshield)

### 継続学習 v2

本能に基づく学習システムが自動的にあなたのパターンを学習します：

```bash
/instinct-status        # Show learned instincts with confidence
/instinct-import <file> # Import instincts from others
/instinct-export        # Export your instincts for sharing
/evolve                 # Cluster related instincts into skills
```

完全なドキュメントは `skills/continuous-learning-v2/` を参照してください。  
レガシーの v1 Stop-hook 学習スキルのフローを明示的に使用したい場合のみ、`continuous-learning/` を保持してください。

---

## 要件

### Claude Code CLI バージョン

**最小バージョン: v2.1.0 以降**

このプラグインは、フックの処理方法が変更されたため、Claude Code CLI v2.1.0 以降が必要です。

バージョンを確認してください：
```bash
claude --version
```

### 重要: フックの自動読み込み動作

> 警告: **貢献者の皆様へ:** `.claude-plugin/plugin.json` に `"hooks"` フィールドを追加しないでください。これはリグレッションテストによって強制されています。

Claude Code v2.1+ は、慣例によりインストールされたプラグインの `hooks/hooks.json` を**自動的に読み込み**ます。`plugin.json` に明示的に宣言すると重複検出エラーが発生します:

```
Duplicate hooks file detected: ./hooks/hooks.json resolves to already-loaded file
```

**履歴：** これにより、このリポジトリで繰り返し修正/元に戻すサイクルが発生しました（[#29](https://github.com/affaan-m/everything-claude-code/issues/29)、[#52](https://github.com/affaan-m/everything-claude-code/issues/52)、[#103](https://github.com/affaan-m/everything-claude-code/issues/103)）。挙動はClaude Codeのバージョン間で変化し、混乱を招きました。現在、これが再導入されるのを防ぐための回帰テストがあります。

---

## インストール

### オプション1: プラグインとしてインストール（推奨）

このリポジトリを使用する最も簡単な方法は、Claude Codeプラグインとしてインストールすることです：

```bash
# Add this repo as a marketplace
/plugin marketplace add https://github.com/affaan-m/everything-claude-code

# Install the plugin
/plugin install everything-claude-code@everything-claude-code
```

または直接 `~/.claude/settings.json` に追加してください:

```json
{
  "extraKnownMarketplaces": {
    "ecc": {
      "source": {
        "source": "github",
        "repo": "affaan-m/everything-claude-code"
      }
    }
  },
  "enabledPlugins": {
    "everything-claude-code@everything-claude-code": true
  }
}
```
これにより、すべてのコマンド、エージェント、スキル、およびフックに即座にアクセスできます。

> **注意:** Claude Codeプラグインシステムは、プラグイン経由での`rules`の配布をサポートしていません（[上流の制限](https://code.claude.com/docs/en/plugins-reference)）。ルールは手動でインストールする必要があります:
>
> ```bash
> # まずリポジトリをクローン
> git clone https://github.com/affaan-m/everything-claude-code.git
>
> # オプションA: ユーザーレベルのルール（すべてのプロジェクトに適用）
> mkdir -p ~/.claude/rules/ecc
> cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # スタックを選択
> cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
> cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/
>
> # オプションB: プロジェクトレベルのルール（現在のプロジェクトにのみ適用）
> mkdir -p .claude/rules/ecc
> cp -r everything-claude-code/rules/common .claude/rules/ecc/
> cp -r everything-claude-code/rules/typescript .claude/rules/ecc/     # スタックを選択
> ```

---

### オプション2: 手動インストール

インストール内容を手動で制御したい場合:


```bash
# Clone the repo
git clone https://github.com/affaan-m/everything-claude-code.git

# Copy agents to your Claude config
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Copy rules directories (common + language-specific)
mkdir -p ~/.claude/rules/ecc
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/typescript ~/.claude/rules/ecc/   # pick your stack
cp -r everything-claude-code/rules/python ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/golang ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/php ~/.claude/rules/ecc/

# Copy skills first (primary workflow surface)
# Recommended (new users): core/general skills only
mkdir -p ~/.claude/skills/ecc
cp -r everything-claude-code/.agents/skills/* ~/.claude/skills/ecc/
cp -r everything-claude-code/skills/search-first ~/.claude/skills/ecc/

# Optional: add niche/framework-specific skills only when needed
# for s in django-patterns django-tdd laravel-patterns springboot-patterns; do
# cp -r everything-claude-code/skills/$s ~/.claude/skills/ecc/
# done

# Optional: keep maintained slash-command compatibility during migration
mkdir -p ~/.claude/commands
cp everything-claude-code/commands/*.md ~/.claude/commands/

# Retired shims live in legacy-command-shims/commands/.
# Copy individual files from there only if you still need old names such as /tdd.
```

#### フックのインストール

生のリポジトリの `hooks/hooks.json` を `~/.claude/settings.json` や `~/.claude/hooks/hooks.json` にコピーしないでください。 そのファイルはプラグイン/リポジトリ指向であり、ECCインストーラーを通じてインストールするかプラグインとして読み込むことを意図しているため、生のコピーはサポートされていない手動インストール方法です。

インストーラーを使用してClaudeフックランタイムのみをインストールし、コマンドパスが正しく書き換えられるようにしてください：

```bash
# macOS / Linux
bash ./install.sh --target claude --modules hooks-runtime
```

```powershell
# Windows PowerShell
pwsh -File .\install.ps1 --target claude --modules hooks-runtime
```

これは解決されたフックを `~/.claude/hooks/hooks.json` に書き込み、既存の `~/.claude/settings.json` はそのままにします。

ECCを `/plugin install` 経由でインストールした場合、それらのフックを `settings.json` にコピーしないでください。Claude Code v2.1+ はプラグインの `hooks/hooks.json` を自動的に読み込むため、`settings.json` に重複して記載すると実行が重複し、クロスプラットフォームのフック競合が発生します。

Windowsの注意点：Claudeの設定ディレクトリは `~/claude` ではなく `%USERPROFILE%\\.claude` です。

#### MCPの設定

Claudeプラグインのインストールでは意図的にECC同梱のMCPサーバー定義を自動的に有効にしません。これは、厳格なサードパーティゲートウェイ上でプラグインMCPツール名が長くなりすぎるのを避けつつ、手動でのMCP設定を可能にするためです。

ライブのClaude Codeサーバー変更にはClaude Codeの `/mcp` コマンドまたはCLI管理のMCP設定を使用してください。Claude Codeの実行時無効化には `/mcp` を使用し、これらの選択は `~/.claude.json` に保持されます。

リポジトリローカルのMCPアクセスには、必要なMCPサーバー定義を `mcp-configs/mcp-servers.json` からプロジェクトスコープの `.mcp.json` にコピーしてください。

すでにECC同梱のMCPを独自に稼働させている場合は、以下を設定してください：

```bash
export ECC_DISABLED_MCPS="github,context7,exa,playwright,sequential-thinking,memory"
```

ECC管理のインストールおよびCodex同期フローは、重複を再追加する代わりに、それらのバンドルされたサーバーをスキップまたは削除します。`ECC_DISABLED_MCPS`はECCのインストール/同期フィルターであり、ライブのClaude Codeトグルではありません。

**重要：** `YOUR_*_HERE`のプレースホルダーは実際のAPIキーに置き換えてください。

---

## キーコンセプト

### エージェント

サブエージェントは限定的な範囲の委任されたタスクを処理します。例：

```markdown
---
name: code-reviewer
description: Reviews code for quality, security, and maintainability
tools: ["Read", "Grep", "Glob", "Bash"]
model: opus
---

You are a senior code reviewer...
```

### スキル

スキルは主要なワークフローの表面です。これらは直接呼び出すことができ、自動的に提案され、エージェントによって再利用されます。ECCは移行期間中も維持されている`commands/`を引き続き提供し、廃止された短縮名シムは明示的なオプトイン専用として`legacy-command-shims/`にあります。新しいワークフロー開発はまず`skills/`に配置するべきです。

```markdown
# TDD Workflow

1. Define interfaces first
2. Write failing tests (RED)
3. Implement minimal code (GREEN)
4. Refactor (IMPROVE)
5. Verify 80%+ coverage
```

### フック

フックはツールのイベントで発火します。例 - console.logについて警告する:

```json
{
  "matcher": "tool == \"Edit\" && tool_input.file_path matches \"\\\\.(ts|tsx|js|jsx)$\"",
  "hooks": [{
    "type": "command",
    "command": "#!/bin/bash\ngrep -n 'console\\.log' \"$file_path\" && echo '[Hook] Remove console.log' >&2"
  }]
}
```

### ルール

ルールは常に守るべきガイドラインであり、`common/`（言語非依存）および言語固有のディレクトリに整理されています：

```
rules/
  common/          # Universal principles (always install)
  typescript/      # TS/JS specific patterns and tools
  python/          # Python specific patterns and tools
  golang/          # Go specific patterns and tools
  swift/           # Swift specific patterns and tools
  php/             # PHP specific patterns and tools
```

インストールおよび構造の詳細については、[`rules/README.md`](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/rules/README.md) を参照してください。

---

## どのエージェントを使うべきか？

どこから始めればよいかわからない場合は、このクイックリファレンスを使ってください。スキルは標準的なワークフローの表面であり、管理されたスラッシュエントリはコマンド主導のワークフローに常に利用可能です。

| したいこと | 使用する表面 | 使用されるエージェント |
|--------------|-----------------|------------|
| 新機能を計画する | `/everything-claude-code:plan "Add auth"` | planner |
| システムアーキテクチャを設計する | `/everything-claude-code:plan` + architect エージェント | architect |
| テストファーストでコードを書く | `tdd-workflow` スキル | tdd-guide |
| 書いたコードをレビューする | `/code-review` | code-reviewer |
| ビルドエラーを修正する | `/build-fix` | build-error-resolver |
| エンドツーエンドテストを実行する | `e2e-testing` スキル | e2e-runner |
| セキュリティ脆弱性を見つける | `/security-scan` | security-reviewer |
| デッドコードを削除する | `/refactor-clean` | refactor-cleaner |
| ドキュメントを更新する | `/update-docs` | doc-updater |
| Goコードをレビューする | `/go-review` | go-reviewer |
| Pythonコードをレビューする | `/python-review` | python-reviewer |
| TypeScript/JavaScriptコードをレビューする | *(`typescript-reviewer` を直接呼び出す)* | typescript-reviewer |
| データベースクエリを監査する | *(自動委譲)* | database-reviewer |

### 一般的なワークフロー

以下のスラッシュフォームは管理されたコマンド表面の一部である場合に表示されています。`/tdd` や `/eval` のような廃止された短縮名シムは `legacy-command-shims/` にあり、明示的なオプトインでのみ使用されます。

**新機能の開始：**
```
/everything-claude-code:plan "Add user authentication with OAuth"
                                              → planner creates implementation blueprint
tdd-workflow skill                            → tdd-guide enforces write-tests-first
/code-review                                  → code-reviewer checks your work
```

**バグの修正：**
```
tdd-workflow skill                            → tdd-guide: write a failing test that reproduces it
                                              → implement the fix, verify test passes
/code-review                                  → code-reviewer: catch regressions
```

**生産準備中：**
```
/security-scan                                → security-reviewer: OWASP Top 10 audit
e2e-testing skill                             → e2e-runner: critical user flow tests
/test-coverage                                → verify 80%+ coverage
```

---

## FAQ

<details>
<summary><b>How do I check which agents/commands are installed?</b></summary>

```bash
/plugin list everything-claude-code@everything-claude-code
```
これはプラグインから利用可能なすべてのエージェント、コマンド、およびスキルを示しています。
</details>

<details>
<summary><b>フックが動作しない / 「Duplicate hooks file」エラーが表示される</b></summary>

これは最も一般的な問題です。**`.claude-plugin/plugin.json` に `"hooks"` フィールドを追加しないでください。** Claude Code v2.1+ はインストールされたプラグインから自動的に `hooks/hooks.json` を読み込みます。明示的に宣言すると重複検出エラーが発生します。詳細は [#29](https://github.com/affaan-m/everything-claude-code/issues/29)、[#52](https://github.com/affaan-m/everything-claude-code/issues/52)、[#103](https://github.com/affaan-m/everything-claude-code/issues/103) を参照してください。
</details>

<details>
<summary><b>カスタムAPIエンドポイントやモデルゲートウェイでClaude CodeとECCを使えますか？</b></summary>

はい。ECCはAnthropicホストのトランスポート設定をハードコードしていません。Claude Codeの通常のCLI／プラグインインターフェースを通じてローカルで動作するため、以下に対応しています：

- AnthropicホストのClaude Code
- `ANTHROPIC_BASE_URL` と `ANTHROPIC_AUTH_TOKEN` を使った公式Claude Codeゲートウェイ設定
- Claude Codeが期待するAnthropic APIに対応した互換性のあるカスタムエンドポイント

最小限の例：


```bash
export ANTHROPIC_BASE_URL=https://your-gateway.example.com
export ANTHROPIC_AUTH_TOKEN=your-token
claude
```

ゲートウェイがモデル名をリマップする場合は、ECCではなくClaude Codeで設定してください。`claude` CLIがすでに動作している場合、ECCのフック、スキル、コマンド、ルールはモデルプロバイダーに依存しません。

公式リファレンス：
- [Claude Code LLMゲートウェイドキュメント](https://docs.anthropic.com/en/docs/claude-code/llm-gateway)
- [Claude Codeモデル構成ドキュメント](https://docs.anthropic.com/en/docs/claude-code/model-config)

</details>

<details>
<summary><b>コンテキストウィンドウが縮小している / Claudeのコンテキストが不足している</b></summary>

MCPサーバーが多すぎるとコンテキストが食われます。各MCPツールの説明は200kトークンのウィンドウから消費され、約70kに減少する可能性があります。SessionStartのコンテキストはデフォルトで8000文字に制限されています。`ECC_SESSION_START_MAX_CHARS=4000`で減らすか、ローカルモデルや低コンテキスト環境では`ECC_SESSION_START_CONTEXT=off`で無効にしてください。

**対処法：** Claude Codeの`/mcp`で未使用のMCPを無効にします。Claude Codeはこれらの実行時選択を`~/.claude.json`に書き込みます。`.claude/settings.json`や`.claude/settings.local.json`は既にロードされたMCPサーバーの信頼できる切り替えではありません。

有効なMCPは10未満、アクティブなツールは80未満に抑えてください。
</details>

<details>
<summary><b>一部のコンポーネント（例：エージェントのみ）だけ使用できますか？</b></summary>

はい。オプション2（手動インストール）を使用し、必要なものだけをコピーしてください：

```bash
# Just agents
cp everything-claude-code/agents/*.md ~/.claude/agents/

# Just rules
mkdir -p ~/.claude/rules/ecc/
cp -r everything-claude-code/rules/common ~/.claude/rules/ecc/
```
各コンポーネントは完全に独立しています。
</details>

<details>
<summary><b>これは Cursor / OpenCode / Codex / Antigravity と連携しますか？</b></summary>

はい。ECC はクロスプラットフォーム対応です：
- **Cursor**：`.cursor/` に事前翻訳された設定があります。[Cursor IDE サポート](#cursor-ide-support)を参照してください。
- **Gemini CLI**：`.gemini/GEMINI.md` と共有インストーラーの仕組みを使った実験的なプロジェクトローカルサポート。
- **OpenCode**：`.opencode/` での完全なプラグインサポート。[OpenCode サポート](#opencode-support)を参照してください。
- **Codex**：macOS アプリと CLI の両方をファーストクラスでサポートし、アダプターのドリフトガードと SessionStart のフォールバックを備えています。PR [#257](https://github.com/affaan-m/everything-claude-code/pull/257) を参照してください。
- **Antigravity**：`.agent/` にワークフロー、スキル、フラット化されたルールのための密接に統合されたセットアップ。[Antigravity ガイド](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/ANTIGRAVITY-GUIDE.md)を参照してください。
- **ネイティブでないハーネス**：Grok や類似インターフェースの手動フォールバックパス。[手動適応ガイド](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/MANUAL-ADAPTATION-GUIDE.md)を参照してください。
- **Claude Code**：ネイティブ — これが主なターゲットです。
</details>

<details>
<summary><b>新しいスキルやエージェントをどうやって貢献できますか？</b></summary>

[CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md)を参照してください。簡単な手順は：
1. リポジトリをフォークする
2. `skills/your-skill-name/SKILL.md` にスキルを作成する（YAML フロントマター付き）
3. または `agents/your-agent.md` にエージェントを作成する
4. 何をするか、いつ使うかを明確に説明した PR を提出する
</details>

---

## テストの実行

プラグインには包括的なテストスイートが含まれています：


```bash
# Run all tests
node tests/run-all.js

# Run individual test files
node tests/lib/utils.test.js
node tests/lib/package-manager.test.js
node tests/hooks/hooks.test.js
```

---

## 貢献について

**貢献は歓迎され、奨励されています。**

このリポジトリはコミュニティのリソースとして設計されています。もし以下のものがあれば：
- 有用なエージェントやスキル
- 賢いフック
- より良いMCP設定
- 改善されたルール

ぜひご貢献ください！ガイドラインは[CONTRIBUTING.md](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/CONTRIBUTING.md)をご覧ください。

### 貢献のアイデア

- 言語特化のスキル（Rust、C#、Kotlin、Java） — Go、Python、Perl、Swift、TypeScriptは既に含まれています
- フレームワーク特化の設定（Rails、FastAPI） — Django、NestJS、Spring Boot、Laravelは既に含まれています
- DevOpsエージェント（Kubernetes、Terraform、AWS、Docker）
- テスト戦略（異なるフレームワーク、ビジュアルリグレッション）
- ドメイン特化の知識（ML、データエンジニアリング、モバイル）

### コミュニティエコシステムの注記

これらはECCにバンドルされておらず、このリポジトリによる監査もありませんが、より広範なClaude Codeスキルエコシステムを探索する際に知っておく価値があります：

- [claude-seo](https://github.com/AgriciDaniel/claude-seo) — SEOに特化したスキルとエージェントのコレクション
- [claude-ads](https://github.com/AgriciDaniel/claude-ads) — 広告監査および有料成長ワークフローのコレクション
- [claude-cybersecurity](https://github.com/AgriciDaniel/claude-cybersecurity) — セキュリティ志向のスキルとエージェントのコレクション

---

## Cursor IDEサポート

ECCはCursorのプロジェクトレイアウトに適応したフック、ルール、エージェント、スキル、コマンド、MCP設定を提供し、Cursor IDEのサポートを行います。

### クイックスタート（Cursor）

```bash
# macOS/Linux
./install.sh --target cursor typescript
./install.sh --target cursor python golang swift php
```

```powershell
# Windows PowerShell
.\install.ps1 --target cursor typescript
.\install.ps1 --target cursor python golang swift php
```

### 含まれるもの

| コンポーネント | 数量 | 詳細 |
|-----------|-------|---------|
| フックイベント | 15 | sessionStart、beforeShellExecution、afterFileEdit、beforeMCPExecution、beforeSubmitPrompt、その他10件 |
| フックスクリプト | 16 | 共有アダプター経由で `scripts/hooks/` に委譲する薄いNode.jsスクリプト |
| ルール | 34 | 9件の共通（alwaysApply）+ 25件の言語別（TypeScript、Python、Go、Swift、PHP） |
| エージェント | 48 | インストール時の `.cursor/agents/ecc-*.md`；ユーザーやマーケットプレイスのエージェントと衝突しないよう接頭辞付き |
| スキル | 共有 + バンドル | 翻訳追加用の `.cursor/skills/` |
| コマンド | 共有 | インストール時の `.cursor/commands/` |
| MCP設定 | 共有 | インストール時の `.cursor/mcp.json` |

### Cursor読み込みに関する注意

ECCはルートの `AGENTS.md` を `.cursor/` にインストールしません。Cursorはネストされた `AGENTS.md` ファイルをディレクトリコンテキストとして扱うため、ECCのリポジトリIDをホストプロジェクトにコピーすると、そのプロジェクトが汚染されます。

Cursorネイティブの読み込み動作はCursorビルドにより異なる場合があります。ECCはエージェントを `.cursor/agents/ecc-*.md` としてインストールします。もし使用しているCursorビルドがプロジェクトエージェントを公開しない場合でも、それらのファイルは非表示のグローバルプロンプトコンテキストではなく明示的な参照定義として機能します。

### フックアーキテクチャ（DRYアダプターパターン）

Cursorは**Claude Codeより多くのフックイベントを持つ**（20対8）。`.cursor/hooks/adapter.js` モジュールはCursorのstdin JSONをClaude Codeの形式に変換し、既存の `scripts/hooks/*.js` を重複なく再利用可能にします。

```
Cursor stdin JSON → adapter.js → transforms → scripts/hooks/*.js
                                              (shared with Claude Code)
```
キー・フック:
- **beforeShellExecution** — tmux外の開発サーバーをブロック（終了コード 2）、gitプッシュレビュー
- **afterFileEdit** — 自動フォーマット + TypeScriptチェック + console.log警告
- **beforeSubmitPrompt** — プロンプト内のシークレット（sk-、ghp_、AKIAパターン）を検出
- **beforeTabFileRead** — Tabによる.env、.key、.pemファイルの読み取りをブロック（終了コード 2）
- **beforeMCPExecution / afterMCPExecution** — MCP監査ログ記録

### ルール形式

カーソルルールは`description`、`globs`、`alwaysApply`を含むYAMLフロントマターを使用:


```yaml
---
description: "TypeScript coding style extending common rules"
globs: ["**/*.ts", "**/*.tsx", "**/*.js", "**/*.jsx"]
alwaysApply: false
---
```

---

## Codex macOSアプリ + CLIサポート

ECCは、macOSアプリとCLIの両方に対して**一流のCodexサポート**を提供しており、参照用設定、Codex専用のAGENTS.md補足、および共有スキルが含まれています。

### クイックスタート（Codexアプリ + CLI）

```bash
# Run Codex CLI in the repo — AGENTS.md and .codex/ are auto-detected
codex

# Automatic setup: sync ECC assets (AGENTS.md, skills, MCP servers) into ~/.codex
npm install && bash scripts/sync-ecc-to-codex.sh
# or: pnpm install && bash scripts/sync-ecc-to-codex.sh
# or: yarn install && bash scripts/sync-ecc-to-codex.sh
# or: bun install && bash scripts/sync-ecc-to-codex.sh

# Or manually: copy the reference config to your home directory
cp .codex/config.toml ~/.codex/config.toml
```
同期スクリプトは、ECC MCPサーバーを既存の `~/.codex/config.toml` に安全にマージします。**追加のみ**の戦略を採用しており、既存のサーバーを削除または変更することはありません。`--dry-run` を付けて実行すると変更内容をプレビューでき、`--update-mcp` を付けるとECCサーバーを最新の推奨設定に強制更新します。

Context7については、ECCは正規のCodexセクション名 `[mcp_servers.context7]` を使用しつつ、`@upstash/context7-mcp` パッケージを起動します。すでにレガシーの `[mcp_servers.context7-mcp]` エントリーがある場合、`--update-mcp` によって正規のセクション名に移行されます。

Codex macOSアプリ：
- このリポジトリをワークスペースとして開きます。
- ルートの `AGENTS.md` は自動検出されます。
- `.codex/config.toml` と `.codex/agents/*.toml` はプロジェクトローカルに保つのが最適です。
- 参照用の `.codex/config.toml` は意図的に `model` や `model_provider` を固定していないため、Codexはオーバーライドしない限り自身の現在のデフォルトを使用します。
- 任意：グローバルなデフォルトとして `.codex/config.toml` を `~/.codex/config.toml` にコピーしてください。マルチエージェントのロールファイルは、`.codex/agents/` をコピーしない限りプロジェクトローカルに保ちます。

### 含まれるもの

| コンポーネント | 数量 | 詳細 |
|-----------|-------|---------|
| 設定 | 1 | `.codex/config.toml` — トップレベルの承認/サンドボックス/ウェブ検索、MCPサーバー、通知、プロファイル |
| AGENTS.md | 2 | ルート（ユニバーサル） + `.codex/AGENTS.md`（Codex専用補足） |
| スキル | 32 | `.agents/skills/` — 各スキルの SKILL.md と agents/openai.yaml |
| MCPサーバー | 6 | GitHub、Context7、Exa、Memory、Playwright、Sequential Thinking（`--update-mcp` 同期でSupabase経由の7も） |
| プロファイル | 2 | `strict`（読み取り専用サンドボックス）と `yolo`（完全自動承認） |
| エージェントロール | 3 | `.codex/agents/` — explorer、reviewer、docs-researcher |

### スキル

`.agents/skills/` のスキルはCodexによって自動ロードされます。

`claude-api`、`frontend-design`、`skill-creator` のような標準的なAnthropicスキルはここでは再バンドルされていません。公式バージョンが欲しい場合は、[`anthropics/skills`](https://github.com/anthropics/skills) からインストールしてください。

| スキル | 説明 |
|-------|-------------|
| agent-introspection-debugging | エージェントの挙動、ルーティング、プロンプト境界のデバッグ |
| agent-sort | エージェントカタログと割当サーフェスの並べ替え |
| api-design | REST API設計パターン |
| article-writing | ノートや音声参照からの長文執筆 |
| backend-patterns | API設計、データベース、キャッシュ |
| brand-voice | 実際のコンテンツから抽出した執筆スタイルプロファイル |
| bun-runtime | ランタイム、パッケージマネージャ、バンドラー、テストランナーとしてのBun |
| coding-standards | 汎用的なコーディング標準 |
| content-engine | プラットフォームネイティブなソーシャルコンテンツと再利用 |

| crosspost | X、LinkedIn、Threadsをまたぐマルチプラットフォームコンテンツ配信 |
| deep-research | 複数ソースからのリサーチと統合、ソース帰属 |
| dmux-workflows | tmuxペインマネージャーを使ったマルチエージェントオーケストレーション |
| documentation-lookup | Context7 MCPによる最新のライブラリとフレームワークドキュメント |
| e2e-testing | PlaywrightによるE2Eテスト |
| eval-harness | 評価駆動型開発 |
| everything-claude-code | プロジェクトの開発規約とパターン |
| exa-search | Exa MCPによるウェブ、コード、企業リサーチのニューラル検索 |
| fal-ai-media | 画像、動画、音声の統合メディア生成 |
| frontend-patterns | React/Next.jsのパターン |
| frontend-slides | HTMLプレゼンテーション、PPTX変換、ビジュアルスタイルの探求 |
| investor-materials | デッキ、メモ、モデル、ワンページ資料 |
| investor-outreach | パーソナライズされたアプローチ、フォローアップ、イントロ文 |
| market-research | ソース帰属の市場および競合リサーチ |
| mcp-server-patterns | Node/TypeScript SDKでMCPサーバーを構築 |
| nextjs-turbopack | Next.js 16+ と Turbopack のインクリメンタルバンドリング |
| product-capability | 製品目標をスコープ付き能力マップに翻訳 |
| security-review | 包括的なセキュリティチェックリスト |
| strategic-compact | コンテキスト管理 |
| tdd-workflow | 80%以上のカバレッジを持つテスト駆動開発 |
| verification-loop | ビルド、テスト、リンティング、型チェック、セキュリティ |
| video-editing | FFmpegとRemotionを使ったAI支援動画編集ワークフロー |
| x-api | 投稿と解析のためのX/Twitter API統合 |

### 重要な制限事項

Codexは**まだClaudeスタイルのフック実行の同等性を提供していません**。ECCの強制は`AGENTS.md`による命令ベースで、任意の`model_instructions_file`オーバーライド、サンドボックス／承認設定で行われます。

### マルチエージェントサポート

現行のCodexビルドは安定したマルチエージェントワークフローをサポートしています。

- `.codex/config.toml`で`features.multi_agent = true`を有効化
- `[agents.<name>]`の下にロールを定義
- 各ロールを`.codex/agents/`内のファイルに向ける
- CLIで`/agent`を使い子エージェントを検査または操作

ECCは3つのサンプルロール設定を同梱しています：

| ロール | 目的 |
|------|---------|
| `explorer` | 編集前の読み取り専用コードベース証拠収集 |
| `reviewer` | 正確性、セキュリティ、およびテスト漏れのレビュー |
| `docs_researcher` | リリース/ドキュメント変更前のドキュメントおよびAPI検証 |

---

## OpenCode サポート

ECCはプラグインとフックを含む**完全なOpenCodeサポート**を提供します。

### クイックスタート

```bash
# Install OpenCode
npm install -g opencode

# Run in the repository root
opencode
```
設定は `.opencode/opencode.json` から自動的に検出されます。

### 機能の同等性

| 機能 | Claude Code | OpenCode | 状態 |
|---------|-------------|----------|--------|
| エージェント | 合格: 48 エージェント | 合格: 12 エージェント | **Claude Code がリード** |
| コマンド | 合格: 68 コマンド | 合格: 31 コマンド | **Claude Code がリード** |
| スキル | 合格: 182 スキル | 合格: 37 スキル | **Claude Code がリード** |
| フック | 合格: 8 イベントタイプ | 合格: 11 イベント | **OpenCode の方が多い！** |
| ルール | 合格: 29 ルール | 合格: 13 命令 | **Claude Code がリード** |
| MCP サーバー | 合格: 14 サーバー | 合格: 完全 | **完全同等** |
| カスタムツール | 合格: フック経由 | 合格: 6 ネイティブツール | **OpenCode の方が優れている** |

### プラグインによるフックサポート

OpenCode のプラグインシステムは Claude Code よりも高度で、20以上のイベントタイプがあります:

| Claude Code フック | OpenCode プラグインイベント |
|-----------------|----------------------|
| PreToolUse | `tool.execute.before` |
| PostToolUse | `tool.execute.after` |
| Stop | `session.idle` |
| SessionStart | `session.created` |
| SessionEnd | `session.deleted` |

**追加の OpenCode イベント**: `file.edited`, `file.watcher.updated`, `message.updated`, `lsp.client.diagnostics`, `tui.toast.show` など。

### 維持されているスラッシュエントリ

| コマンド | 説明 |
|---------|-------------|
| `/plan` | 実装計画を作成 |
| `/code-review` | コード変更をレビュー |
| `/build-fix` | ビルドエラーを修正 |
| `/refactor-clean` | 不要コードを除去 |
| `/learn` | セッションからパターン抽出 |
| `/checkpoint` | 検証状態を保存 |
| `/quality-gate` | 維持されている検証ゲートを実行 |

| `/update-docs` | ドキュメントを更新 |
| `/update-codemaps` | コードマップを更新 |
| `/test-coverage` | カバレッジを分析 |
| `/go-review` | Goコードレビュー |
| `/go-test` | GoのTDDワークフロー |
| `/go-build` | Goビルドエラーを修正 |
| `/python-review` | Pythonコードレビュー（PEP 8、型ヒント、セキュリティ） |
| `/multi-plan` | マルチモデル協調計画 |
| `/multi-execute` | マルチモデル協調実行 |
| `/multi-backend` | バックエンド重視のマルチモデルワークフロー |
| `/multi-frontend` | フロントエンド重視のマルチモデルワークフロー |
| `/multi-workflow` | フルマルチモデル開発ワークフロー |
| `/pm2` | PM2サービスコマンドを自動生成 |
| `/sessions` | セッション履歴を管理 |
| `/skill-create` | gitからスキルを生成 |
| `/instinct-status` | 学習済み本能を表示 |
| `/instinct-import` | 本能をインポート |
| `/instinct-export` | 本能をエクスポート |
| `/evolve` | 本能をクラスタリングしてスキル化 |
| `/promote` | プロジェクト本能をグローバルスコープに昇格 |
| `/projects` | 既知のプロジェクトと本能統計を一覧表示 |
| `/prune` | 期限切れの保留中本能を削除（30日TTL） |
| `/learn-eval` | 保存前にパターンを抽出・評価 |
| `/setup-pm` | パッケージマネージャを設定 |
| `/harness-audit` | ハーネスの信頼性、評価準備状況、リスク体制を監査 |
| `/loop-start` | 制御されたエージェントループ実行パターンを開始 |
| `/loop-status` | アクティブループの状態とチェックポイントを確認 |
| `/quality-gate` | パスまたはリポジトリ全体の品質ゲートチェックを実行 |
| `/model-route` | タスクを複雑さと予算でモデルに振り分け |

### プラグインのインストール

**オプション1: 直接使用**
```bash
cd everything-claude-code
opencode
```

**オプション 2: npm パッケージとしてインストール**
```bash
npm install ecc-universal
```

次に、`opencode.json` に追加します：
```json
{
  "plugin": ["ecc-universal"]
}
```
そのnpmプラグインエントリは、ECCが公開したOpenCodeプラグインモジュール（フック/イベントおよびプラグインツール）を有効にします。  
ECCの完全なコマンド/エージェント/インストラクションカタログを自動的にプロジェクト設定に追加するものではありません。  

完全なECC OpenCodeセットアップには、以下のいずれかを行ってください：  
- このリポジトリ内でOpenCodeを実行する、または  
- バンドルされた`.opencode/`の設定資産をプロジェクトにコピーし、`opencode.json`内の`instructions`、`agent`、および`command`エントリを接続する  

### ドキュメント  

- **移行ガイド**: `.opencode/MIGRATION.md`  
- **OpenCodeプラグインREADME**: `.opencode/README.md`  
- **統合ルール**: `.opencode/instructions/INSTRUCTIONS.md`  
- **LLMドキュメント**: `llms.txt`（LLM向けの完全なOpenCodeドキュメント）  

---  

## クロスツール機能の同等性  

ECCは**すべての主要なAIコーディングツールを最大限に活用する初のプラグイン**です。各ツールの活用状況は以下の通りです：  

| 機能 | Claude Code | Cursor IDE | Codex CLI | OpenCode |  
|---------|------------|------------|-----------|----------|  
| **エージェント** | 48 | 共有 (AGENTS.md) | 共有 (AGENTS.md) | 12 |  
| **コマンド** | 68 | 共有 | インストラクションベース | 31 |  
| **スキル** | 182 | 共有 | 10（ネイティブ形式） | 37 |  
| **フックイベント** | 8 種類 | 15 種類 | なし（未実装） | 11 種類 |  
| **フックスクリプト** | 20+ スクリプト | 16 スクリプト（DRYアダプター） | 該当なし | プラグインフック |  
| **ルール** | 34（共通＋言語） | 34（YAMLフロントマター） | インストラクションベース | 13 インストラクション |  
| **カスタムツール** | フック経由 | フック経由 | 該当なし | 6 ネイティブツール |  
| **MCPサーバー** | 14 | 共有 (mcp.json) | 7（TOMLパーサーで自動マージ） | 完全対応 |  
| **設定フォーマット** | settings.json | hooks.json + rules/ | config.toml | opencode.json |  
| **コンテキストファイル** | CLAUDE.md + AGENTS.md | AGENTS.md | AGENTS.md | AGENTS.md |  
| **シークレット検出** | フックベース | beforeSubmitPromptフック | サンドボックスベース | フックベース |  
| **自動フォーマット** | PostToolUseフック | afterFileEditフック | 該当なし | file.editedフック |  
| **バージョン** | プラグイン | プラグイン | 参照設定 | 2.0.0-rc.1 |  

**重要なアーキテクチャ上の決定事項：**  
- ルートの**AGENTS.md**は全4ツール共通のユニバーサルファイルです（全ツールで読み込み）  
- **DRYアダプターパターン**により、CursorはClaude Codeのフックスクリプトを複製せずに再利用可能

- **スキルフォーマット**（YAMLフロントマター付きのSKILL.md）はClaude Code、Codex、OpenCodeで共通して機能します  
- Codexのフック不足は`AGENTS.md`、オプションの`model_instructions_file`オーバーライド、サンドボックス権限で補われています  

---

## 背景

私は実験的リリース以来Claude Codeを使っています。2025年9月に[@DRodriguezFX](https://x.com/DRodriguezFX)と共にAnthropic x Forum Venturesハッカソンで優勝し、Claude Codeだけで[zenith.chat](https://zenith.chat)を構築しました。  

これらの設定は複数の本番アプリケーションで実戦テスト済みです。  

---

## トークン最適化

Claude Codeの使用はトークン消費を管理しないとコストが高くなります。これらの設定は品質を犠牲にせずにコストを大幅に削減します。  

### 推奨設定

`~/.claude/settings.json`に追加：

```json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50"
  }
}
```
| 設定 | デフォルト | 推奨 | 影響 |
|---------|---------|-------------|--------|
| `model` | opus | **sonnet** | コスト約60%削減；80%以上のコーディングタスクに対応 |
| `MAX_THINKING_TOKENS` | 31,999 | **10,000** | リクエストごとの隠れ思考コストを約70%削減 |
| `CLAUDE_AUTOCOMPACT_PCT_OVERRIDE` | 95 | **50** | 早めに圧縮—長時間セッションで品質向上 |

深いアーキテクチャ推論が必要な場合のみOpusに切り替えてください：

```
/model opus
```

### 日々のワークフローコマンド

| コマンド | 使用タイミング |
|---------|-------------|
| `/model sonnet` | ほとんどのタスクのデフォルト |
| `/model opus` | 複雑なアーキテクチャ、デバッグ、深い推論 |
| `/clear` | 無関係なタスク間（無料、即時リセット） |
| `/compact` | 論理的なタスク区切りで（調査完了、マイルストーン達成） |
| `/cost` | セッション中のトークン使用量の監視 |

### 戦略的圧縮

このプラグインに含まれる`strategic-compact`スキルは、95%コンテキストでの自動圧縮に頼る代わりに、論理的な区切りで`/compact`を提案します。詳細な判断ガイドは`skills/strategic-compact/SKILL.md`を参照してください。

**圧縮すべき時:**
- 調査・探索後、実装前
- マイルストーン完了後、次開始前
- デバッグ後、機能作業継続前
- 失敗したアプローチ後、新しい試行前

**圧縮すべきでない時:**
- 実装途中（変数名、ファイルパス、部分的状態が失われる）

### コンテキストウィンドウ管理

**重要:** すべてのMCPを一度に有効にしないでください。各MCPツールの説明が200kのウィンドウからトークンを消費し、約70kまで減少する可能性があります。

- プロジェクトごとに有効MCPは10未満に保つ
- アクティブなツールは80未満に保つ
- `/mcp`コマンドで未使用のClaude Code MCPサーバーを無効化；これらのランタイム設定は`~/.claude.json`に保存されます
- `ECC_DISABLED_MCPS`はインストール/同期フロー中にECC生成のMCP設定をフィルタリングするためだけに使用

### エージェントチームのコスト警告

エージェントチームは複数のコンテキストウィンドウを生成します。各チームメンバーは独立してトークンを消費します。並列処理に明確な価値があるタスク（マルチモジュール作業、並列レビュー）でのみ使用してください。単純な順次タスクにはサブエージェントのほうがトークン効率が良いです。

---

## 警告：重要な注意点

### トークン最適化

毎日の制限に達していますか？推奨設定とワークフローのヒントについては、**[トークン最適化ガイド](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/docs/token-optimization.md)**をご覧ください。

すぐに効果が出る方法：

```json
// ~/.claude/settings.json
{
  "model": "sonnet",
  "env": {
    "MAX_THINKING_TOKENS": "10000",
    "CLAUDE_AUTOCOMPACT_PCT_OVERRIDE": "50",
    "CLAUDE_CODE_SUBAGENT_MODEL": "haiku"
  }
}
```

関連しないタスク間は`/clear`を使用し、論理的な区切りでは`/compact`を使い、支出を監視するには`/cost`を使用してください。

### カスタマイズ

これらの設定は私のワークフローに適しています。あなたは：
1. 共感できるものから始める
2. 自分のスタックに合わせて修正する
3. 使わないものは削除する
4. 独自のパターンを追加する

---

## コミュニティプロジェクト

Everything Claude Codeに基づく、または触発されたプロジェクト：

| プロジェクト | 説明 |
|---------|-------------|
| [EVC](https://github.com/SaigonXIII/evc) | マーケティングエージェントの作業スペース — コンテンツオペレーター、ブランドガバナンス、マルチチャネル出版のための42コマンド。[ビジュアル概要](https://saigonxiii.github.io/evc)。 |

ECCで何か作成しましたか？ここに追加するためにPRを開いてください。

---

## スポンサー

このプロジェクトは無料でオープンソースです。スポンサーは維持と成長を助けます。

[**スポンサーになる**](https://github.com/sponsors/affaan-m) | [スポンサー階層](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORS.md) | [スポンサーシッププログラム](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/SPONSORING.md)

---

## スター履歴

[![スター履歴チャート](https://api.star-history.com/svg?repos=affaan-m/everything-claude-code&type=Date)](https://star-history.com/#affaan-m/everything-claude-code&Date)

---

## リンク
- **ショートハンドガイド（ここから始めてください）：** [The Shorthand Guide to Everything Claude Code](https://x.com/affaanmustafa/status/2012378465664745795)
- **ロングフォームガイド（上級者向け）：** [The Longform Guide to Everything Claude Code](https://x.com/affaanmustafa/status/2014040193557471352)
- **セキュリティガイド：** [Security Guide](https://raw.githubusercontent.com/affaan-m/everything-claude-code/main/./the-security-guide.md) | [スレッド](https://x.com/affaanmustafa/status/2033263813387223421)
- **フォロー：** [@affaanmustafa](https://x.com/affaanmustafa)

---

## ライセンス

MIT - 自由に使用し、必要に応じて変更し、可能であれば貢献してください。

---

**このリポジトリが役立ったらスターを付けてください。両方のガイドを読んでください。素晴らしいものを作りましょう。**



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-06

---