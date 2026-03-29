<h1 align="center"><img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="" width="64" style="vertical-align: middle;">&nbsp; CLI-Anything: すべてのソフトウェアをエージェントネイティブにする</h1>

<p align="center">
  <strong>今日のソフトウェアは人間👨‍💻にサービスを提供します。明日のユーザーはエージェント🤖です。<br>
CLI-Anything: AIエージェントと世界中のソフトウェアのギャップを埋める</strong><br>
</p>

**🌐 [CLI-Hub](https://hkuds.github.io/CLI-Anything/)**: コミュニティが構築したすべてのCLIを探して、**[CLI-Hub](https://hkuds.github.io/CLI-Anything/)**でワンクリックでインストール。自分のものを追加したいですか？[PRを開く](https://github.com/HKUDS/CLI-Anything/blob/main/CONTRIBUTING.md) — ハブは即座に更新されます。

<p align="center">
  <a href="#-quick-start"><img src="https://img.shields.io/badge/Quick_Start-5_min-blue?style=for-the-badge" alt="Quick Start"></a>
  <a href="https://hkuds.github.io/CLI-Anything/"><img src="https://img.shields.io/badge/CLI_Hub-Browse_%26_Install-ff69b4?style=for-the-badge" alt="CLI Hub"></a>
  <a href="#-demonstrations"><img src="https://img.shields.io/badge/Demos-16_Apps-green?style=for-the-badge" alt="Demos"></a>
  <a href="#-test-results"><img src="https://img.shields.io/badge/Tests-1%2C839_Passing-brightgreen?style=for-the-badge" alt="Tests"></a>
  <a href="LICENSE"><img src="https://img.shields.io/badge/License-MIT-yellow?style=for-the-badge" alt="License"></a>
</p>

<p align="center">
  <img src="https://img.shields.io/badge/python-≥3.10-blue?logo=python&logoColor=white" alt="Python">
  <img src="https://img.shields.io/badge/click-≥8.0-green" alt="Click">
  <img src="https://img.shields.io/badge/pytest-100%25_pass-brightgreen" alt="Pytest">
  <img src="https://img.shields.io/badge/coverage-unit_%2B_e2e-orange" alt="Coverage">
  <img src="https://img.shields.io/badge/output-JSON_%2B_Human-blueviolet" alt="Output">
  <a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/Feishu-Group-E9DBFC?style=flat&logo=feishu&logoColor=white" alt="Feishu"></a>
<a href="https://github.com/HKUDS/.github/blob/main/profile/README.md"><img src="https://img.shields.io/badge/WeChat-Group-C5EAB4?style=flat&logo=wechat&logoColor=white" alt="WeChat"></a>
</p>

**ワンコマンドライン**: どんなソフトウェアもOpenClaw、nanobot、Cursor、Claude Codeなどのエージェント対応にします。&nbsp;&nbsp;[**中文ドキュメント**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_CN.md) | [**日本語ドキュメント**](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/README_JA.md)

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/cli-typing.gif" alt="CLI-Anything typing demo" width="800">
</p>

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/teaser.png" alt="CLI-Anything Teaser" width="800">
</p>

---

## 📰 ニュース
> コミュニティの皆様の貴重なご尽力に感謝します！毎日、継続的にさらなるアップデートをお届けしています。。

- **2026-03-23** 🤖 **CLI-Hub meta-skill** をリリース — エージェントが [`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) を通じてCLIを自律的に発見・インストール可能に。カタログはGitHub Actions経由で `registry.json` から自動更新され、市場全体がエージェントネイティブに。

- **2026-03-22** 🎵 **MuseScore CLI** にトランスポーズ、エクスポート、楽器管理機能を統合。コミュニティの貢献によりドメインカバレッジが拡大中。

- **2026-03-21** 🔧 インフラ改善 — 複数CLIのテストハーネスとドキュメントを洗練。複数バックエンドのWindows対応を強化。

- **2026-03-20** 🌐 OpenAI互換APIアクセス用に **Novita AI** CLI を追加。ハブ探索のためのレジストリメタデータを改善。

- **2026-03-19** 📦 ハーネス全体のパッケージ構造を改良。コマンドドキュメントを改善したSKILL.md生成を強化。

- **2026-03-18** 🧪 テストカバレッジ拡充 — 複数CLIで追加のE2Eシナリオとエッジケース検証を実施。

- **2026-03-17** 🌐 **[CLI-Hub](https://hkuds.github.io/CLI-Anything/)** を公開 — 1つの `pip` コマンドで任意のCLIを閲覧、検索、インストールできる中央レジストリ。寄稿者は `registry.json` エントリを含むPRを出すだけで新規CLI追加や更新が可能。マージ時にハブは自動更新。

<details>
<summary>過去のニュース</summary>

- **2026-03-16** 🤖 **SKILL.md生成** (フェーズ6.5) を追加 — 生成された全CLIはPythonパッケージ内にAIが発見可能なスキル定義を同梱。ReplSkinは `pip install` 後にスキルファイルを自動検出し、REPLバナーにエージェント用の絶対パスを表示。`skill_generator.py`、Jinja2テンプレート、全setup.pyファイルへの `package_data` 追加、51件の新テストを含む。

- **2026-03-15** 🐾 コミュニティより **OpenClaw** 対応を追加！Windows bash環境でのCLI-Anythingの信頼性確保のため、Windows版 `cygpath` ガードを統合。コミュニティ貢献によりクロスプラットフォーム対応が強化中。

- **2026-03-14** 🔒 GIMP Script-Fu パスインジェクション脆弱性を修正し、**日本語README**翻訳を追加。OpenCodeのバージョン要件を明記し、複数のWindows互換性改善も実施。

- **2026-03-13** 🔌 コミュニティ貢献として **Qodercli** プラグインを正式統合し、専用セットアップスクリプトも追加。CodexスキルにWindows用インストールスクリプトが加わり、プロジェクト全体のプレースホルダーURLを整理。

- **2026-03-12** 📦 **Codexスキル** 統合が完了し、CLI-AnythingがさらなるAIコーディングプラットフォームに対応。Qodercli対応も導入され、制限事項と実験的ラベルを含むドキュメントを更新。

- **2026-03-11** 📞 **Zoom** ビデオ会議用ハーネスを11番目の対応アプリケーションとして追加。Shotcutの自動保存、LibreOffice Windows/macOSバックエンド、OpenCodeサポートに複数のコミュニティ修正を反映。

</details>

---

## 🤔 なぜCLIなのか？

CLIは人間とAIエージェント双方にとっての普遍的インターフェースです：


• **構造化＆合成可能** - テキストコマンドはLLM形式に一致し、複雑なワークフローのチェーンに対応

• **軽量＆ユニバーサル** - 最小限のオーバーヘッドで、依存関係なくすべてのシステムで動作

• **自己記述型** - --helpフラグは自動ドキュメントを提供し、エージェントが検出可能

• **実績のある成功例** - Claude Codeは毎日CLI経由で数千の実際のワークフローを実行

• **エージェントファースト設計** - 構造化されたJSON出力がパースの複雑さを排除

• **決定論的＆信頼性** - 一貫した結果で予測可能なエージェント動作を実現

## 🚀 クイックスタート

### 前提条件

- **Python 3.10+**
- 対象ソフトウェアがインストール済み（例：GIMP、Blender、LibreOffice、または独自アプリケーション）
- 対応AIコーディングエージェント：[Claude Code](#-claude-code) | [OpenClaw](#-openclaw) | [OpenCode](#-opencode) | [Codex](#-codex) | [Qodercli](#-qodercli) | [GitHub Copilot CLI](#-github-copilot-cli) | [その他プラットフォーム](#-more-platforms-coming-soon)

### プラットフォームを選択

<details open>
<summary><h4 id="-claude-code">⚡ Claude Code</h4></summary>

**ステップ1：マーケットプレイスを追加**

CLI-AnythingはGitHubでホストされているClaude Codeプラグインマーケットプレイスとして配布されています。

```bash
# Add the CLI-Anything marketplace
/plugin marketplace add HKUDS/CLI-Anything
```

**ステップ2：プラグインのインストール**

```bash
# Install the cli-anything plugin from the marketplace
/plugin install cli-anything
```
これで完了です。プラグインは現在、あなたのClaude Codeセッションで利用可能です。

> **Windowsユーザーへの注意:** Claude Codeは`bash`を介してシェルコマンドを実行します。WindowsではGit for Windows（`bash`と
`cygpath`を含む）をインストールするかWSLを使用してください。そうしないと、`cygpath: command not found`のエラーが発生する可能性があります。

**ステップ3: 1つのコマンドでCLIを構築する**


```bash
# /cli-anything:cli-anything <software-path-or-repo>
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything:cli-anything ./gimp

# Note: If your Claude Code is under 2.x, use "/cli-anything" instead.
```
これはフルパイプラインを実行します：
1. 🔍 **解析** — ソースコードをスキャンし、GUI操作をAPIにマッピングします
2. 📐 **設計** — コマンドグループ、状態モデル、出力フォーマットを設計します
3. 🔨 **実装** — REPL、JSON出力、元に戻す/やり直しを備えたClick CLIを構築します
4. 📋 **テスト計画** — ユニットおよびE2Eテスト計画を含むTEST.mdを作成します
5. 🧪 **テスト作成** — 包括的なテストスイートを実装します
6. 📝 **ドキュメント** — TEST.mdを結果で更新します
7. 📦 **公開** — `setup.py`を作成し、PATHにインストールします

**ステップ4（オプション）：CLIの改良と改善**

初期ビルド後、カバレッジを拡大し不足機能を追加するためにCLIを反復的に改良できます：


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything:refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything:refine ./gimp "I want more CLIs on image batch processing and filters"
```

refineコマンドは、ソフトウェアの全機能と現在のCLIカバレッジとの間のギャップ分析を行い、特定されたギャップに対して新しいコマンド、テスト、およびドキュメントを実装します。複数回実行することで、カバレッジを段階的に拡大できます — 各実行は増分的で非破壊的です。

<details>
<summary><strong>代替案：手動インストール</strong></summary>

マーケットプレイスを使用したくない場合：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Copy plugin to Claude Code plugins directory
cp -r CLI-Anything/cli-anything-plugin ~/.claude/plugins/cli-anything

# Reload plugins
/reload-plugins
```

</details>

</details>

<details>
<summary><h4 id="-opencode">⚡ OpenCode（実験的）</h4></summary>

**ステップ1：コマンドをインストールする**

> **注意：** 最新のOpenCodeにアップグレードしてください。古いバージョンでは異なるコマンドパスを使用している場合があります。

CLI-Anythingのコマンド**と**`HARNESS.md`をOpenCodeのコマンドディレクトリにコピーしてください：

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Global install (available in all projects)
cp CLI-Anything/opencode-commands/*.md ~/.config/opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md ~/.config/opencode/commands/

# Or project-level install
cp CLI-Anything/opencode-commands/*.md .opencode/commands/
cp CLI-Anything/cli-anything-plugin/HARNESS.md .opencode/commands/
```

> **注意:** `HARNESS.md` はすべてのコマンドが参照する方法論仕様です。コマンドと同じディレクトリに配置する必要があります。

これにより、5つのスラッシュコマンドが追加されます: `/cli-anything`、`/cli-anything-refine`、`/cli-anything-test`、`/cli-anything-validate`、および `/cli-anything-list`。

**ステップ2: 1つのコマンドでCLIを構築する**

```bash
# Generate a complete CLI for GIMP (all 7 phases)
/cli-anything ./gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender
```
コマンドはサブタスクとして実行され、Claude Codeと同じ7段階の方法論に従います。

**ステップ3（オプション）：CLIの洗練と改善**


```bash
# Broad refinement — agent analyzes gaps across all capabilities
/cli-anything-refine ./gimp

# Focused refinement — target a specific functionality area
/cli-anything-refine ./gimp "batch processing and filters"
```
</details>

<details>
<summary><h4 id="-goose">⚡ Goose (デスクトップ / CLI) <sup><code>実験的</code></sup> <sup><code>コミュニティ</code></sup></h4></summary>

**ステップ 1: Goose をインストールする**

公式の Goose インストール手順に従って、OS 用の Goose（デスクトップまたは CLI）をインストールします。

**ステップ 2: CLI プロバイダーを設定する**

Goose を Claude Code のような CLI プロバイダーを使うように設定し、CLI がインストールされ認証されていることを確認します。

**ステップ 3: Goose セッションで CLI-Anything を使う**

Goose が設定できたら、セッションを開始し、上記の Claude Code 用 CLI-Anything コマンドと同じコマンドを使用します。例えば：


```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
```

> 注意: GooseがCLIプロバイダーを通じて実行される場合、そのプロバイダーの機能およびコマンド形式を使用します。
</details>

<details>

<summary><h4 id="-qodercli">⚡ Qodercli <sup><code>コミュニティ</code></sup></h4></summary>

**ステップ1: プラグインの登録**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
bash CLI-Anything/qoder-plugin/setup-qodercli.sh
```

これは `~/.qoder.json` に cli-anything プラグインを登録します。登録後、新しい Qodercli セッションを開始してください。

**ステップ 2: Qodercli から CLI-Anything を使用する**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```
</details>

<details>

<summary><h4 id="-openclaw">⚡ OpenClaw <sup><code>Community</code></sup></h4></summary>

**ステップ1: スキルのインストール**

CLI-AnythingはネイティブのOpenClaw `SKILL.md` ファイルを提供します。これをOpenClawのスキルディレクトリにコピーしてください:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install to the global skills folder
mkdir -p ~/.openclaw/skills/cli-anything
cp CLI-Anything/openclaw-skill/SKILL.md ~/.openclaw/skills/cli-anything/SKILL.md
```

**ステップ2: CLIを構築する**

これでOpenClaw内でスキルを呼び出すことができます:

`@cli-anything build a CLI for ./gimp`

このスキルはClaude CodeおよびOpenCodeと同じ7段階の方法論に従います。

</details>

<details>

<summary><h4 id="-codex">⚡ Codex <sup><code>実験的</code></sup> <sup><code>コミュニティ</code></sup></h4></summary>

**ステップ1: スキルをインストールする**

同梱のインストーラーを実行してください:

```bash
# Clone the repo
git clone https://github.com/HKUDS/CLI-Anything.git

# Install the skill
bash CLI-Anything/codex-skill/scripts/install.sh
```
Windows PowerShellでは、次のコマンドを使用してください：


```powershell
.\CLI-Anything\codex-skill\scripts\install.ps1
```

これはスキルを `$CODEX_HOME/skills/cli-anything` （`CODEX_HOME` が設定されていない場合は `~/.codex/skills/cli-anything`）にインストールします。

インストール後、Codex を再起動してスキルを認識させてください。

**ステップ2: Codex から CLI-Anything を使用する**

タスクを自然言語で記述します。例えば：

```text
Use CLI-Anything to build a harness for ./gimp
Use CLI-Anything to refine ./shotcut for picture-in-picture workflows
Use CLI-Anything to validate ./libreoffice
```

Codexスキルは、Claude CodeプラグインおよびOpenCodeコマンドで使用されている同じ方法論を適用し、
生成されたPythonハーネスのフォーマットは変更しません。
</details>

<details>

<summary><h4 id="-github-copilot-cli">⚡ GitHub Copilot CLI <sup><code>Community</code></sup></h4></summary>

**ステップ1：プラグインをインストールする**

```bash
git clone https://github.com/HKUDS/CLI-Anything.git
cd CLI-Anything
copilot plugin install ./cli-anything-plugin
```

これにより、GitHub Copilot CLIにCLI-Anythingプラグインがインストールされます。プラグインは現在、GitHub Copilot CLIセッションで利用可能なはずです。

**ステップ2：GitHub Copilot CLIからCLI-Anythingを使用する**

```bash
/cli-anything:cli-anything ./gimp
/cli-anything:refine ./gimp "batch processing and filters"
/cli-anything:validate ./gimp
```

</details>

<details>
<summary><h4 id="-more-platforms-coming-soon">🔮 より多くのプラットフォーム（近日公開予定）</h4></summary>

CLI-Anythingはプラットフォームに依存しない設計です。より多くのAIコーディングエージェントのサポートが計画されています：

- **Codex** — `codex-skill/`にバンドルされたスキルで利用可能
- **Cursor** — 近日公開予定
- **Windsurf** — 近日公開予定
- **あなたのお気に入りのツール** — 貢献歓迎！参照実装は`opencode-commands/`ディレクトリを参照してください。

</details>

### 生成されたCLIの使用方法

どのプラットフォームで構築した場合でも、生成されたCLIは同じ方法で動作します：

```bash
# Install to PATH
cd gimp/agent-harness && pip install -e .

# Use from anywhere
cli-anything-gimp --help
cli-anything-gimp project new --width 1920 --height 1080 -o poster.json
cli-anything-gimp --json layer add -n "Background" --type solid --color "#1a1a2e"

# Enter interactive REPL
cli-anything-gimp
```

インストールされた各CLIには、Pythonパッケージ内（`cli_anything/<software>/skills/SKILL.md`）に[`SKILL.md`](#-skillmd-generation)が同梱されています。REPLバナーはこのファイルへの絶対パスを自動的に表示するため、AIエージェントはスキル定義の読み取り場所を正確に把握できます。追加の設定は不要で、`pip install`によりスキルが検出可能になります。

---

## 🤖 CLI-Hubでエージェントを強化する

CLI-Hubはエージェントが必要なCLIを自律的に発見してインストールできるようにします — 人の介入は一切不要です。

コミュニティCLIの全カタログを自由に探索し、タスクに最適なCLIを選択できる**メタスキル**を公開しました。

**ワンコマンドでインストール：**

```bash
# OpenClaw
openclaw skills install cli-anything-hub

# nanobot
nanobot skills install cli-anything-hub
```

**それからエージェントにプロンプトを入力してください：**

```
Find appropriate CLI software in CLI-Hub and complete the task: <your task here>
```
エージェントはカタログを閲覧し、タスクに適したCLIをインストールし、それを使用します — すべて自律的に。

**内部動作の仕組み：**

1. メタスキルはライブカタログ [`https://hkuds.github.io/CLI-Anything/SKILL.txt`](https://hkuds.github.io/CLI-Anything/SKILL.txt) を参照します
2. エージェントはカテゴリ別に整理された20以上のCLIを、1行の `pip install` コマンド付きで読み取ります
3. エージェントはタスクに合ったCLIをインストールし、そのCLIの詳細な使用法をSKILL.mdから読み取ります

カタログは `registry.json` が変更されるたびに自動更新され、新しいコミュニティCLIが自動的に表示されます。

> **Claude Codeユーザー向け：** 同じ自動CLI検出のために、[`cli-hub-meta-skill/SKILL.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-hub-meta-skill/SKILL.md) をプロジェクトまたはスキルディレクトリにコピーしてください。

---

## 💡 CLI-Anythingのビジョン：エージェントネイティブソフトウェアの構築

• 🌐 **ユニバーサルアクセス** - すべてのソフトウェアが構造化されたCLIを通じて即座にエージェント制御可能に。

• 🔗 **シームレスな統合** - API、GUI、再構築や複雑なラッパーなしでエージェントがあらゆるアプリケーションを制御。

• 🚀 **未来対応エコシステム** - 人間設計のソフトウェアをワンコマンドでエージェントネイティブツールに変換。

---

## 🔧 CLI-Anythingを使うタイミング

| カテゴリ | エージェントネイティブ化の方法 | 代表的な例 |
|----------|----------------------|----------|
| **📂 GitHubリポジトリ** | 自動CLI生成によってあらゆるオープンソースプロジェクトをエージェント制御ツールに変換 | VSCodium, WordPress, Calibre, Zotero, Joplin, Logseq, Penpot, Super Productivity |
| **🤖 AI/MLプラットフォーム** | 構造化コマンドによるモデル訓練、推論パイプライン、ハイパーパラメータ調整の自動化 | Stable Diffusion WebUI, ComfyUI, Ollama, InvokeAI, Text-generation-webui, Open WebUI, Fooocus, Kohya_ss, AnythingLLM, SillyTavern |
| **📊 データ＆分析** | プログラム的なデータ処理、可視化、統計解析ワークフローを可能に | JupyterLab, Apache Superset, Metabase, Redash, DBeaver, KNIME, Orange, OpenSearch Dashboards, Lightdash |
| **💻 開発ツール** | コマンドインターフェイスを通じてコード編集、ビルド、テスト、デプロイを効率化 | Jenkins, Gitea, Hoppscotch, Portainer, pgAdmin, SonarQube, ArgoCD, OpenLens, Insomnia, Beekeeper Studio, **[iTerm2](https://iterm2.com)** |
| **🎨 クリエイティブ＆メディア** | コンテンツ作成、編集、レンダリングワークフローをプログラム制御 | Blender, GIMP, OBS Studio, Audacity, Krita, Kdenlive, Shotcut, Inkscape, Darktable, LMMS, Ardour |
| **🔬 科学計算** | 研究ワークフロー、シミュレーション、複雑な計算の自動化 | ImageJ, FreeCAD, QGIS, ParaView, Gephi, LibreCAD, Stellarium, KiCad, JASP, Jamovi |
| **🏢 エンタープライズ＆オフィス** | ビジネスアプリケーションや生産性ツールをエージェントアクセス可能なシステムに変換 | NextCloud, GitLab, Grafana, Mattermost, LibreOffice, AppFlowy, NocoDB, Odoo (Community), Plane, ERPNext |
| **📞 コミュニケーション＆コラボレーション** | 構造化CLIによる会議スケジューリング、参加者管理、録画取得、レポート作成の自動化 | Zoom, Jitsi Meet, BigBlueButton, Mattermost |
| **📐 図表＆可視化** | 図、フローチャート、アーキテクチャ図、視覚ドキュメントの作成と操作をプログラムで実施 | Draw.io (diagrams.net), Mermaid, PlantUML, Excalidraw, yEd |
| **🌐 ネットワーク＆インフラ** | 構造化CLIコマンドでネットワークサービス、DNS、広告ブロック、インフラ管理 | AdGuardHome |
| **🔬 グラフィックス＆GPUデバッグ** | GPUフレームキャプチャ解析、パイプライン状態検査、シェーダー書き出し、レンダリング状態差分 | RenderDoc |

| **✨ AIコンテンツ生成** | AI搭載のクラウドAPIを通じて、プロフェッショナルな成果物（スライド、ドキュメント、図、ウェブサイト、調査レポート）を生成 | [AnyGen](https://www.anygen.io), Gamma, Beautiful.ai, Tome |

---

## CLI-Anythingの主な特徴

### エージェントとソフトウェアのギャップ
AIエージェントは推論は得意だが、本物のプロ用ソフトウェアを使うのは苦手。現状の解決策は壊れやすいUI自動化、限定的なAPI、または機能の90％を失った簡易実装に過ぎない。

**CLI-Anythingの解決策**：あらゆるプロ用ソフトを機能を失わずにエージェントネイティブなツールに変換。

| **現状の問題点** | **CLI-Anythingの解決策** |
|----------|----------------------|
| 🤖 「AIは本物のツールを使えない」 | Blender、LibreOffice、FFmpegなど実際のソフトウェアバックエンドと直接統合 — 完全なプロ機能、妥協なし |
| 💸 「UI自動化は頻繁に壊れる」 | スクリーンショット不要、クリック不要、RPAの脆弱性なし。構造化されたインターフェースによる純粋なコマンドラインの信頼性 |
| 📊 「エージェントは構造化データが必要」 | シームレスなエージェント利用のための組み込みJSON出力＋デバッグ用の人間可読フォーマット |
| 🔧 「カスタム統合はコスト高」 | 1つのClaudeプラグインであらゆるコードベースのCLIを7段階パイプラインで自動生成 |
| ⚡ 「プロトタイプと本番のギャップ」 | 1,839以上のテストと実ソフト検証済み。主要16アプリでの実戦テスト済み |

---

## 🎯 CLI-Anythingで何ができる？

<table>
<tr>
<td width="33%">

### 🛠️ エージェントにワークフローを任せる

プロ用途も日常使いも、コードベースを`/cli-anything`に投げ込むだけ。クリエイティブ作業ならGIMP、Blender、Shotcut。日常作業ならLibreOffice、OBS Studio。ソースがなければオープンソース代替品を入れてください。すぐにエージェントが使える完全CLIが得られます。

</td>
<td width="33%">

### 🔗 分散したAPIを一つのCLIに統合

断片的なウェブサービスAPIの使い分けに疲れた？ドキュメントやSDKマニュアルを`/cli-anything`に渡すと、各エンドポイントを統合した**強力で状態管理可能なCLI**がエージェントに提供されます。数十の生API呼び出しを一つのツールにまとめ、トークン節約しながら機能強化。

</td>
<td width="33%">

### 🚀 GUIエージェントの置き換えまたは強化

CLI-AnythingはGUIベースのエージェントアプローチを完全に**置き換えることができます** — スクリーンショット不要、脆弱なピクセルクリックもなし。ですがここが面白いところ：一度GUIソフトウェアを`/cli-anything`すると、**エージェントタスク、評価者、ベンチマークを**コードとターミナルだけで完全に合成可能 — 完全自動化、反復的に改善可能、非常に効率的です。

</td>
</tr>
</table>

---

## ✨ ⚙️ CLI-Anythingの仕組み

<table>
<tr>
<td width="50%">

### 🏗️ 完全自動化7フェーズパイプライン
コードベース解析からPyPI公開まで — プラグインはアーキテクチャ設計、実装、テスト計画、テスト作成、ドキュメントを完全自動で処理します。

</td>
<td width="50%">

### 🎯 本物のソフトウェア統合
実際のレンダリングのためにリアルアプリを直接呼び出します。LibreOfficeはPDFを生成し、Blenderは3Dシーンをレンダリングし、Audacityはsox経由でオーディオを処理します。**妥協ゼロ**、**おもちゃ実装ゼロ**。

</td>
</tr>
<tr>
<td width="50%">

### 🔁 スマートセッション管理
元に戻す/やり直す機能付きの永続的プロジェクト状態、さらにすべてのCLIで一貫したインタラクティブ体験を提供する統一REPLインターフェース（ReplSkin）。

</td>
<td width="50%">

### 📦 ゼロコンフィグインストール
単純にpip install -e .でcli-anything-<software>が直接PATHに入ります。エージェントは標準のwhichコマンドでツールを発見します。セットアップ不要、ラッパー不要。

</td>
</tr>
<tr>
<td width="50%">

### 🧪 本番品質のテスト
多層的な検証：合成データを用いたユニットテスト、実ファイルとソフトウェアを使ったエンドツーエンドテスト、さらにインストールされたコマンドのCLIサブプロセス検証。

</td>
<td width="50%">

### 🐍 クリーンなパッケージ構造
すべてのCLIはcli_anything.*名前空間の下に整理されており、衝突なし、pipでインストール可能で、一貫した命名規則：cli-anything-gimp、cli-anything-blenderなど。

</td>
</tr>
</table>

### 🤖 SKILL.md 生成

生成される各CLIには、Pythonパッケージ内の`cli_anything/<software>/skills/SKILL.md`に`SKILL.md`ファイルが含まれています。この自己完結型のスキル定義により、Claude Codeのスキルシステムや他のエージェントフレームワークを通じてAIエージェントがCLIを発見し使用できます。

**SKILL.mdが提供するもの：**
- **エージェントのスキル発見用の名前と説明を含むYAMLフロントマター**
- **利用可能なすべてのサブコマンドを文書化したコマンドグループ**
- **一般的なワークフローの使用例**
- **JSON出力、エラー処理、プログラム的利用に関するエージェント向けガイダンス**

SKILL.mdファイルはパイプラインのフェーズ6.5で`skill_generator.py`を使って自動生成され、CLIのClickデコレータ、setup.py、READMEから直接メタデータを抽出します。ファイルはパッケージ内に存在するため、`pip install`でCLIと共にインストールされ、REPLのバナーで自動検出されます — エージェントは起動時に表示される絶対パスを読み取れます。

---

## 🎬 デモンストレーション

### 🎯 汎用
CLI-Anythingはコードベースを持つあらゆるソフトウェアで動作し、ドメインの制限やアーキテクチャの制限はありません。

### 🏭 プロフェッショナル品質のテスト
クリエイティブ、生産性、コミュニケーション、ダイアグラム作成、AI画像生成、AIコンテンツ生成、ネットワーク広告ブロック、ローカルLLM推論など、以前はAIエージェントがアクセスできなかった16の多様で複雑なアプリケーション群でテスト済み。

### 🎨 多様なドメインカバレッジ  
クリエイティブなワークフロー（画像編集、3Dモデリング、ベクターグラフィックス）から、制作ツール（オーディオ、オフィス、ライブストリーミング、ビデオ編集）まで。  

### ✅ 完全なCLI生成  
各アプリケーションには、デモではなく、完全な機能を保持した本格的なCLIインターフェースが提供されています。  

<table>  
<tr>  
<th align="center">ソフトウェア</th>  
<th align="center">ドメイン</th>  
<th align="center">CLIコマンド</th>  
<th align="center">バックエンド</th>  
<th align="center">テスト</th>  
</tr>  
<tr>  
<td align="center"><strong>🎨 GIMP</strong></td>  
<td>画像編集</td>  
<td><code>cli-anything-gimp</code></td>  
<td>Pillow + GEGL/Script-Fu</td>  
<td align="center">✅ 107</td>  
</tr>  
<tr>  
<td align="center"><strong>🧊 Blender</strong></td>  
<td>3Dモデリング＆レンダリング</td>  
<td><code>cli-anything-blender</code></td>  
<td>bpy（Pythonスクリプト）</td>  
<td align="center">✅ 208</td>  
</tr>  
<tr>  
<td align="center"><strong>✏️ Inkscape</strong></td>  
<td>ベクターグラフィックス</td>  
<td><code>cli-anything-inkscape</code></td>  
<td>直接SVG/XML操作</td>  
<td align="center">✅ 202</td>  
</tr>  
<tr>  
<td align="center"><strong>🎵 Audacity</strong></td>  
<td>オーディオ制作</td>  
<td><code>cli-anything-audacity</code></td>  
<td>Python wave + sox</td>
<td align="center">✅ 161</td>
</tr>
<tr>
<td align="center"><strong>🌐 ブラウザ</strong></td>
<td>ブラウザ自動化</td>
<td><code>cli-anything-browser</code></td>
<td>DOMShell MCP + アクセシビリティツリー</td>
<td align="center">✅ <a href="browser/agent-harness/">新規</a></td>
</tr>
<tr>
<td align="center"><strong>📄 LibreOffice</strong></td>
<td>オフィススイート（Writer、Calc、Impress）</td>
<td><code>cli-anything-libreoffice</code></td>
<td>ODF生成 + ヘッドレスLO</td>
<td align="center">✅ 158</td>
</tr>
<tr>
<td align="center"><strong>📝 <a href="mubu/agent-harness/">Mubu</a></strong></td>
<td>ナレッジマネジメント＆アウトライニング</td>
<td><code>cli-anything-mubu</code></td>
<td>ローカルMubuデータ + 同期ログ</td>
<td align="center">✅ 96</td>
</tr>
<tr>
<td align="center"><strong>📹 OBS Studio</strong></td>
<td>ライブストリーミング＆録画</td>
<td><code>cli-anything-obs-studio</code></td>
<td>JSONシーン + obs-websocket</td>
<td align="center">✅ 153</td>
</tr>
<tr>
<td align="center"><strong>🎞️ Kdenlive</strong></td>
<td>ビデオ編集</td>
<td><code>cli-anything-kdenlive</code></td>
<td>MLT XML + meltレンダラー</td>
<td align="center">✅ 155</td>
</tr>
<tr>
<td align="center"><strong>🎬 Shotcut</strong></td>
<td>ビデオ編集</td>
<td><code>cli-anything-shotcut</code></td>
<td>直接MLT XML + melt</td>
<td align="center">✅ 154</td>
</tr>
<tr>
<td align="center"><strong>📞 Zoom</strong></td>
<td>ビデオ会議</td>
<td><code>cli-anything-zoom</code></td>
<td>Zoom REST API (OAuth2)</td>
<td align="center">✅ 22</td>
</tr>
<tr>
<td align="center"><strong>🎵 MuseScore</strong></td>
<td>楽譜作成</td>
<td><code>cli-anything-musescore</code></td>
<td>mscore CLI (MSCX/MusicXML)</td>
<td align="center">✅ 56</td>
</tr>
<tr>
<td align="center"><strong>📐 Draw.io</strong></td>
<td>図表作成</td>
<td><code>cli-anything-drawio</code></td>
<td>mxGraph XML + draw.io CLI</td>
<td align="center">✅ 138</td>
</tr>
<tr>
<td align="center"><strong>🧜 Mermaid Live Editor</strong></td>
<td>図表作成</td>
<td><code>cli-anything-mermaid</code></td>
<td>Mermaid状態 + mermaid.inkレンダラー</td>
<td align="center">✅ 10</td>
</tr>
<tr>
<td align="center"><strong>✨ AnyGen</strong></td>
<td>AIコンテンツ生成</td>
<td><code>cli-anything-anygen</code></td>
<td>AnyGen REST API (anygen.io)</td>
<td align="center">✅ 50</td>
</tr>
<tr>
<td align="center"><strong>🧠 NotebookLM</strong></td>
<td>AIリサーチアシスタント</td>
<td><code>cli-anything-notebooklm</code></td>
<td>NotebookLM CLIラッパー（実験的）</td>
<td align="center">✅ 21</td>
</tr>
<tr>
<td align="center"><strong>🖼️ ComfyUI</strong></td>
<td>AI画像生成</td>
<td><code>cli-anything-comfyui</code></td>
<td>ComfyUI REST API</td>
<td align="center">✅ 70</td>
</tr>
<tr>
<td align="center"><strong>🛡️ AdGuard Home</strong></td>
<td>ネットワーク全体の広告ブロック</td>
<td><code>cli-anything-adguardhome</code></td>
<td>AdGuard Home REST API</td>
<td align="center">✅ 36</td>
</tr>
<tr>
<td align="center"><strong>🦙 Ollama</strong></td>
<td>ローカルLLM推論</td>
<td><code>cli-anything-ollama</code></td>
<td>Ollama REST API</td>
<td align="center">✅ 98</td>
</tr>
<tr>
<td align="center"><strong>🎨 Sketch</strong></td>
<td>UIデザイン</td>
<td><code>sketch-cli</code></td>
<td>sketch-constructor（Node.js）</td>
<td align="center">✅ 19</td>
</tr>
<tr>
<td align="center" colspan="4"><strong>合計</strong></td>
<td align="center"><strong>✅ 1,858</strong></td>
</tr>
</table>

> **100% 合格率** 全1,858テスト — 1,355ユニットテスト + 484エンドツーエンドテスト + 19 Node.jsテスト。

---

## 📊 テスト結果

各CLIハーネスは本番環境での信頼性を確保するために多層の厳格なテストを受けています：

| レイヤー | テスト内容 | 例 |
|---------|-------------|-----|
| **ユニットテスト** | 合成データによる各コア機能の単体テスト | `test_core.py` — プロジェクト作成、レイヤー操作、フィルターパラメータ |
| **E2Eテスト（ネイティブ）** | プロジェクトファイル生成パイプライン | 有効なODF ZIP構造、正しいMLT XML、SVGの整形式 |
| **E2Eテスト（真のバックエンド）** | 実際のソフトウェア呼び出し＋出力検証 | LibreOffice → `%PDF-`マジックバイト付きPDF、Blender → レンダリング済みPNG |
| **CLIサブプロセステスト** | `subprocess.run`経由でインストールされたコマンド | `cli-anything-gimp --json project new` → 有効なJSON出力 |

```
================================ Test Summary ================================
gimp          107 passed  ✅   (64 unit + 43 e2e)
blender       208 passed  ✅   (150 unit + 58 e2e)
inkscape      202 passed  ✅   (148 unit + 54 e2e)
audacity      161 passed  ✅   (107 unit + 54 e2e)
libreoffice   158 passed  ✅   (89 unit + 69 e2e)
mubu           96 passed  ✅   (85 unit + 11 e2e)
obs-studio    153 passed  ✅   (116 unit + 37 e2e)
kdenlive      155 passed  ✅   (111 unit + 44 e2e)
shotcut       154 passed  ✅   (110 unit + 44 e2e)
zoom           22 passed  ✅   (22 unit + 0 e2e)
drawio        138 passed  ✅   (116 unit + 22 e2e)
mermaid        10 passed  ✅   (5 unit + 5 e2e)
anygen         50 passed  ✅   (40 unit + 10 e2e)
notebooklm     21 passed  ✅   (21 unit + 0 e2e)
comfyui        70 passed  ✅   (60 unit + 10 e2e)
adguardhome    36 passed  ✅   (24 unit + 12 e2e)
ollama         98 passed  ✅   (87 unit + 11 e2e)
sketch         19 passed  ✅   (19 jest, Node.js)
renderdoc      59 passed  ✅   (45 unit + 14 e2e)
──────────────────────────────────────────────────────────────────────────────
TOTAL        1,917 passed  ✅   100% pass rate
```

---

## 🏗️ CLI-Anythingのアーキテクチャ

<p align="center">
  <img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/architecture.png" alt="CLI-Anything Architecture" width="750">
</p>

### 🎯 コア設計原則

1. **本物のソフトウェア統合** — CLIは有効なプロジェクトファイル（ODF、MLT XML、SVG）を生成し、レンダリングは実際のアプリケーションに委任します。**私たちはソフトウェアへの構造化されたインターフェースを構築し、代替品を作るのではありません**。

2. **柔軟なインタラクションモデル** — すべてのCLIは二重モードで動作します：対話型エージェントセッションのための状態保持REPL + スクリプト/パイプライン用のサブコマンドインターフェース。**単にコマンドを実行すると→REPLモードに入ります**。

3. **一貫したユーザー体験** — 生成されるすべてのCLIは統一されたREPLインターフェース（repl_skin.py）を共有し、ブランドバナー、スタイル付きプロンプト、コマンド履歴、進行状況インジケーター、標準化されたフォーマットを備えています。

4. **エージェントネイティブ設計** — すべてのコマンドに組み込みの--jsonフラグがあり、機械が消費できる構造化データを提供します。一方で、人間が読むためのテーブルは対話的使用に役立ちます。**エージェントは標準の--helpやwhichコマンドを通じて機能を発見します**。

5. **妥協のない依存関係** — 実際のソフトウェアは必須です—フォールバックなし、グレースフルデグラデーションなし。**バックエンドがない場合はテストが失敗（スキップではなく）し、本物の機能性を保証します**。

---

## 📂 プロジェクト構成

```
cli-anything/
├── 📄 README.md                          # You are here
├── 📁 assets/                            # Images and media
│   ├── icon.png                          # Project icon
│   └── teaser.png                        # Teaser figure
│
├── 🔌 cli-anything-plugin/               # The Claude Code plugin
│   ├── HARNESS.md                        # Methodology SOP (source of truth)
│   ├── README.md                         # Plugin documentation
│   ├── QUICKSTART.md                     # 5-minute getting started
│   ├── PUBLISHING.md                     # Distribution guide
│   ├── repl_skin.py                      # Unified REPL interface
│   ├── commands/                         # Plugin command definitions
│   │   ├── cli-anything.md               # Main build command
│   │   ├── refine.md                     # Expand existing harness coverage
│   │   ├── test.md                       # Test runner
│   │   └── validate.md                   # Standards validation
│   └── scripts/
│       └── setup-cli-anything.sh         # Setup script
│
├── 🤖 codex-skill/                      # Codex skill entry point
├── 🎨 gimp/agent-harness/               # GIMP CLI (107 tests)
├── 🧊 blender/agent-harness/            # Blender CLI (208 tests)
├── ✏️ inkscape/agent-harness/            # Inkscape CLI (202 tests)
├── 🎵 audacity/agent-harness/           # Audacity CLI (161 tests)
├── 🌐 browser/agent-harness/            # Browser CLI (DOMShell MCP, new)
├── 📄 libreoffice/agent-harness/        # LibreOffice CLI (158 tests)
├── 📝 mubu/agent-harness/               # Mubu CLI (96 tests)
├── 📹 obs-studio/agent-harness/         # OBS Studio CLI (153 tests)
├── 🎞️ kdenlive/agent-harness/           # Kdenlive CLI (155 tests)
├── 🎬 shotcut/agent-harness/            # Shotcut CLI (154 tests)
├── 📞 zoom/agent-harness/               # Zoom CLI (22 tests)
├── 🎵 musescore/agent-harness/          # MuseScore CLI (56 tests)
├── 📐 drawio/agent-harness/             # Draw.io CLI (138 tests)
├── 🧜 mermaid/agent-harness/            # Mermaid Live Editor CLI (10 tests)
├── ✨ anygen/agent-harness/             # AnyGen CLI (50 tests)
├── 🖼️ comfyui/agent-harness/            # ComfyUI CLI (70 tests)
├── 🧠 notebooklm/agent-harness/         # NotebookLM CLI (experimental, 21 tests)
├── 🛡️ adguardhome/agent-harness/       # AdGuard Home CLI (36 tests)
├── 🦙 ollama/agent-harness/             # Ollama CLI (98 tests)
├── 🎨 sketch/agent-harness/             # Sketch CLI (19 tests, Node.js)
└── 🔬 renderdoc/agent-harness/          # RenderDoc CLI (59 tests)
```

各 `agent-harness/` には、Click CLI、コアモジュール、ユーティリティ（`repl_skin.py` とバックエンドラッパーを含む）、および包括的なテストを備えた `cli_anything.<software>/` 配下のインストール可能なPythonパッケージが含まれています。

---

## 🎯 プラグインコマンド

| コマンド | 説明 |
|---------|-------------|
| `/cli-anything <software-path-or-repo>` | 完全なCLIハーネスを構築 — 全7フェーズ |
| `/cli-anything:refine <software-path> [focus]` | 既存のハーネスを洗練 — ギャップ分析でカバレッジ拡大 |
| `/cli-anything:test <software-path-or-repo>` | テストを実行し、結果をTEST.mdに更新 |
| `/cli-anything:validate <software-path-or-repo>` | HARNESS.md基準に対して検証 |

### 例示

```bash
# Build a complete CLI for GIMP from local source
/cli-anything /home/user/gimp

# Build from a GitHub repo
/cli-anything https://github.com/blender/blender

# Refine an existing harness — broad gap analysis
/cli-anything:refine /home/user/gimp

# Refine with a specific focus area
/cli-anything:refine /home/user/shotcut "vid-in-vid and picture-in-picture compositing"

# Run tests and update TEST.md
/cli-anything:test /home/user/inkscape

# Validate against HARNESS.md standards
/cli-anything:validate /home/user/audacity
```

---

## 🎮 Demo: Using a Generated CLI

Here's what an agent can do with `cli-anything-libreoffice`:

```bash
# Create a new Writer document
$ cli-anything-libreoffice document new -o report.json --type writer
✓ Created Writer document: report.json

# Add content
$ cli-anything-libreoffice --project report.json writer add-heading -t "Q1 Report" --level 1
✓ Added heading: "Q1 Report"

$ cli-anything-libreoffice --project report.json writer add-table --rows 4 --cols 3
✓ Added 4×3 table

# Export to real PDF via LibreOffice headless
$ cli-anything-libreoffice --project report.json export render output.pdf -p pdf --overwrite
✓ Exported: output.pdf (42,831 bytes) via libreoffice-headless

# JSON mode for agent consumption
$ cli-anything-libreoffice --json document info --project report.json
{
  "name": "Q1 Report",
  "type": "writer",
  "pages": 1,
  "elements": 2,
  "modified": true
}
```

### REPLモード

```
$ cli-anything-blender
╔══════════════════════════════════════════╗
║       cli-anything-blender v1.0.0       ║
║     Blender CLI for AI Agents           ║
╚══════════════════════════════════════════╝

blender> scene new --name ProductShot
✓ Created scene: ProductShot

blender[ProductShot]> object add-mesh --type cube --location 0 0 1
✓ Added mesh: Cube at (0, 0, 1)

blender[ProductShot]*> render execute --output render.png --engine CYCLES
✓ Rendered: render.png (1920×1080, 2.3 MB) via blender --background

blender[ProductShot]> exit
Goodbye! 👋
```

---

## 📖 標準プレイブック: HARNESS.md

HARNESS.md は、任意のソフトウェアを自動CLI生成でエージェント対応可能にするための決定版SOPです。

自動生成プロセスを通じて洗練された実証済みのパターンと手法をコード化しています。

このプレイブックは、16種類すべての多様で本番対応のハーネスを構築した際の重要な洞察を抽出しています。

### 重要な教訓

| 教訓 | 説明 |
|--------|-------------|
| **実際のソフトウェアを使う** | CLIは必ず実際のアプリケーションを呼び出してレンダリングします。GIMPの代わりにPillowを使わない、Blenderにカスタムレンダラーを使わない。正しいプロジェクトファイルを生成し→実際のバックエンドを呼び出す。 |
| **レンダリングギャップ** | GUIアプリはレンダリング時にエフェクトを適用します。CLIがプロジェクトファイルを操作しても単純なエクスポートツールを使うとエフェクトが見えなくなります。解決策：ネイティブレンダラー→フィルター変換→レンダースクリプト。 |
| **フィルター変換** | フォーマット間のエフェクトマッピング（MLT→ffmpeg）では、重複フィルターの統合、ストリーム順序の混在、パラメータ空間の違い、変換不能なエフェクトに注意。 |
| **タイムコード精度** | 非整数フレームレート（29.97fps）は累積的な丸め誤差を生みます。`int()`ではなく`round()`を使い、表示は整数演算で、テストは±1フレームの許容範囲を設ける。 |
| **出力検証** | エクスポートが0終了コードだからといって信じてはいけません。検証は必須：マジックバイト、ZIP/OOXML構造、ピクセル解析、音声RMSレベル、再生時間チェック。 |

> 詳細な手法はこちら：[`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md)

---

## 📦 インストールと使用方法

### プラグインユーザー向け（Claude Code）

```bash
# Add marketplace & install (recommended)
/plugin marketplace add HKUDS/CLI-Anything
/plugin install cli-anything

# Build a CLI for any software with a codebase
/cli-anything <software-name>
```

### 生成されたCLIの場合

```bash
# Install any generated CLI
cd <software>/agent-harness
pip install -e .

# Verify
which cli-anything-<software>

# Use
cli-anything-<software> --help
cli-anything-<software>                    # enters REPL
cli-anything-<software> --json <command>   # JSON output for agents
```

### テストの実行

```bash
# Run tests for a specific CLI
cd <software>/agent-harness
python3 -m pytest cli_anything/<software>/tests/ -v

# Force-installed mode (recommended for validation)
CLI_ANYTHING_FORCE_INSTALLED=1 python3 -m pytest cli_anything/<software>/tests/ -v -s
```

---

## 🤝 貢献について

私たちは貢献を歓迎します！CLI-Anythingは拡張可能な設計です：

- **新しいソフトウェアターゲット** — プラグインを使って任意のコードベースを持つソフトウェアのCLIを生成し、そのハーネスを[`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md)から提出してください。
- **方法論の改善** — 新たに得られた教訓を記述する`HARNESS.md`へのPR
- **プラグインの強化** — 新コマンド、フェーズ改善、より良いバリデーション
- **テストカバレッジ** — さらなるE2Eシナリオ、エッジケース、ワークフローテスト

### 制限事項

- **強力な基盤モデルが必要** — CLI-Anythingは信頼性の高いハーネス生成のために最先端クラスのモデル（例：Claude Opus 4.6、Claude Sonnet 4.6、GPT-5.4）に依存しています。より弱い、または小規模なモデルは不完全または誤ったCLIを生成し、多大な手動修正が必要になる可能性があります。
- **利用可能なソースコードに依存** — 7フェーズのパイプラインはソースコードを解析し生成します。対象ソフトウェアがコンパイル済みバイナリのみで逆コンパイルが必要な場合、ハーネスの品質とカバレッジは大幅に低下します。
- **反復的な改良が必要な場合あり** — 単一の`/cli-anything`実行では全機能を完全にカバーできないことがあります。CLIの性能とカバレッジを本番品質に引き上げるには、`/refine`を一度以上実行することが多く必要です。

### ロードマップ

- [ ] より多くのアプリケーションカテゴリのサポート（CAD、DAW、IDE、EDA、科学ツール）
- [ ] エージェントタスク完了率のベンチマークスイート
- [ ] 内部/カスタムソフトウェア向けコミュニティ貢献のCLIハーネス
- [ ] Claude Code以外の追加エージェントフレームワークとの統合
- [ ] クローズドソースソフトウェアおよびウェブサービスをCLIにパッケージングするAPIのサポート
- [x] エージェントスキル発見とオーケストレーションのためのSKILL.mdをCLIと共に生成

---

## 📖 ドキュメント

| ドキュメント | 説明 |
|----------|-------------|
| [`cli-anything-plugin/HARNESS.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/HARNESS.md) | 方法論SOP — 唯一の信頼できる情報源 |
| [`cli-anything-plugin/README.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/README.md) | プラグインドキュメント — コマンド、オプション、フェーズ |
| [`cli-anything-plugin/QUICKSTART.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/QUICKSTART.md) | 5分で始めるガイド |
| [`cli-anything-plugin/PUBLISHING.md`](https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/cli-anything-plugin/PUBLISHING.md) | 配布および公開ガイド |

生成される各ハーネスには以下も含まれます：
- `<SOFTWARE>.md` — そのアプリケーション固有のアーキテクチャSOP
- `tests/TEST.md` — テスト計画および結果のドキュメント

---

## ⭐ スター履歴

CLI-Anythingがあなたのソフトウェアをエージェントネイティブにする手助けになったら、スターをお願いします！⭐

<div align="center">
  <a href="https://star-history.com/#HKUDS/CLI-Anything&Date">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date&theme=dark" />
      <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
      <img alt="スター履歴チャート" src="https://api.star-history.com/svg?repos=HKUDS/CLI-Anything&type=Date" />
    </picture>
  </a>
</div>

---

## 📄 ライセンス

MITライセンス — 無料で使用、改変、配布可能。

---

<div align="center">

**CLI-Anything** — *あらゆるソフトウェアをエージェントネイティブにする。*

<sub>AIエージェント時代のための手法 | 16のプロフェッショナルソフトウェアデモ | 1,839の合格テスト</sub>

<br>

<img src="https://raw.githubusercontent.com/HKUDS/CLI-Anything/main/assets/icon.png" alt="CLI-Anything アイコン" width="80">

</div>

<p align="center">
  <em> ご訪問ありがとうございます ✨ CLI-Anything!</em><br><br>
  <img src="https://visitor-badge.laobi.icu/badge?page_id=HKUDS.CLI-Anything&style=for-the-badge&color=00d4ff" alt="Views">
</p>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-29

---