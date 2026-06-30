<p align="center">
  <img src="https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/cover.jpg" alt="claudex — one terminal, six providers, bring your own key" width="100%">
</p>

# claudex

> **Claude Codeを単一のターミナルから複数アカウント＋複数プロバイダ（Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter…）で使用。自分のキーを持ち込め。**

`claudex`は、[Claude Code](https://www.anthropic.com/claude-code)の独自の`ANTHROPIC_BASE_URL` / `CLAUDE_CONFIG_DIR`環境変数オーバーライド機構をベースに構築—**プロキシなし、ルーターなし**。単一コマンドで新しい`claudeX`エイリアスを追加：自分のAPIキーを入力し、プロバイダ＋モデルを選択して完了。

[English version below ↓](#english)

---

## 🇹🇷 Türkçe

### Neden?

- DeepSeek / Z.ai / MiniMaxのような**はるかに安価または無料**のAnthropic互換プロバイダをClaude Code経由で使うため
- 複数の**別請求**APIアカウント（例：個人＋会社）を単一のターミナルで、分離された`CLAUDE_CONFIG_DIR`で管理するため
- すべてClaude Codeの独自UI/skill/MCP/agent環境内で、裏のモデル＋キーだけが変わる

> ⚠️ **このツールはAnthropic Pro/Maxサブスクリプションを複数ユーザーに共有したり、アカウントごとのレートリミットを回避するためのものではありません。** Anthropicの[消費者規約](https://www.anthropic.com/legal/consumer-terms)および[利用規約](https://www.anthropic.com/legal/aup)で禁止されています。`claudex`はあくまで**別々に認可された**プロバイダアカウント／APIキーを独立したプロファイルとして管理します。

### Önkoşullar

| Gereken | Nasıl yüklerim |
|---|---|
| Node.js 20+ | https://nodejs.org/ |
| Claude Code | `npm install -g @anthropic-ai/claude-code` |
| zsh veya bash | macOS / Linuxでデフォルト |

### Kurulum (30 saniye)

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` は近日公開予定。今のところは `git clone`。

### 最初のプロファイル（ガイド付き）

```bash
claudex quickstart
```

Z.ai → MiniMax → OpenRouter の順に進みます。各ステップで:
- Key の URL を表示します（登録 → API キー作成）
- Key を貼り付けます（秘密）
- 「スキップしたい」→ enter → スキップします
完了したら `source ~/.zshrc` → `claude-zai` （または `claude-minimax`、`claude-or`）と入力すると Claude Code が起動します。

### どのモデルを選べばよいですか？

```bash
claudex recommend
```
インタラクティブ：「何をしたいですか？」→ 8つのユースケース（高速コード／リファクタリング／長いコンテキスト／ビジョン／…）。トップ3の提案を理由とともに表示し、作成するコマンドを出力します。

またはノンインタラクティブ：

```bash
claudex recommend coding-fast --json
```

### 決定木

```
Ücretsiz?
├── Süresiz ücretsiz model → claudex add <name> --provider zai
├── 32 ücretsiz modelin biri → claudex add <name> --provider openrouter
└── Trial (Kasım 7 2026'a kadar) → claudex add <name> --provider minimax

Ucuz ödemeli?
└── DeepSeek (~10x Sonnet'ten ucuz) → claudex add <name> --provider deepseek

Birden fazla ayrı-faturalı Anthropic API hesabı (kişisel/şirket/proje izolasyonu)?
└── claudex add <name> --provider anthropic --no-share
```
### すべてのコマンド


```bash
claudex init                       # ilk kurulum (~/.claudex + shell rc block)
claudex quickstart                 # 3 ücretsiz sağlayıcı için kılavuzlu setup
claudex recommend [<intent>]       # ne yapmak istediğine göre top-3 model önerisi
claudex add <isim> [-p <provider>] # yeni alias (interactive)
claudex validate <isim>            # 1-token ping ile key + model doğrula
claudex list                       # tüm profilleri listele
claudex remove <isim>              # alias kaldır
claudex providers [info <id>]      # sağlayıcı kataloğu
claudex export <isim> [-o file]    # redacted JSON template (key olmadan)
claudex import <file>              # template'i yükle, key sor, profil oluştur
claudex doctor                     # kurulum sağlığı
claudex --lang en                  # İngilizce output
```
### バンドルされたプロバイダー

| ID | レベル | サイト | デフォルト |
|----|--------|--------|------------|
| `anthropic` | 公式 | https://console.anthropic.com | (デフォルト) |
| `zai` | **永遠に無料** | https://z.ai | GLM-4.7-Flash |
| `minimax` | **無料トライアル** (2026年11月7日まで) | https://platform.minimax.io | M2.7 |
| `deepseek` | 低価格支払い | https://platform.deepseek.com | deepseek-v4-pro |
| `moonshot` | 有料（長文コンテキスト専門） | https://platform.moonshot.ai | Kimi K2.5 |
| `openrouter` | 32の無料モデル | https://openrouter.ai | qwen3-coder:free |

すべて**Anthropic互換**のエンドポイントを持つ — プロキシ不要。詳細 → [docs/PROVIDERS.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/PROVIDERS.md)。

### 仕組みは？

Claude Codeは5つの環境変数を参照する：
- `CLAUDE_CONFIG_DIR` — セッション、履歴、ユーザーステートの保存場所
- `ANTHROPIC_BASE_URL` — APIエンドポイント（デフォルト: api.anthropic.com）
- `ANTHROPIC_AUTH_TOKEN` — エンドポイントのキー
- `ANTHROPIC_MODEL`, `ANTHROPIC_SMALL_FAST_MODEL` — メイン＋小型モデル

`claudex add` は各プロファイルのためにシェル関数を生成する。関数は `.env` からキーを読み込み、環境変数を設定し、`claude` バイナリを呼び出す。キーは引数に表示されず、履歴にも残らない。

### ファイル構成


```
~/.claudex/
├── profiles/<isim>/
│   ├── .env                # API key (mode 0600)
│   └── (CLAUDE_CONFIG_DIR — symlink veya isolated)
├── generated/aliases.sh    # ~/.zshrc tarafından source edilir
└── backups/                # her rc edit'inde otomatik backup
```

既存の `~/.claude/` と共有: デフォルトで agents/commands/skills/plugins/CLAUDE.md/settings.json/mcp.json が **シンボリックリンク** される → すべてのプロファイルで同じツールを使用。`--no-share` で完全に分離されたプロファイル。

### セキュリティ

- キーは `~/.claudex/profiles/<名前>/.env` に、モード0600で保存
- `claudex` リポジトリにはキーは一切コミットされない（自動 `.gitignore`）
- 詳細 → [docs/SECURITY.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/docs/SECURITY.md)

### 新しいプロバイダの追加

[`src/templates/providers.json`](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/src/templates/providers.json) にJSONエントリを追加し、PRを送る。コードは変更しない。詳細 → [CONTRIBUTING.md](https://raw.githubusercontent.com/sasdsamatt123/claudex/main/CONTRIBUTING.md)。

### ロードマップ (v0.3+)

- `claudex bench` — プロファイルのレイテンシー/コスト比較
- macOSキーチェーン暗号化シークレット（オプトイン）
- コスト追跡 — Claude Codeログからのトークンカウント
- タブ補完（zsh/bash/fish）
- Anthropic非対応プロバイダ（Groq、Gemini直接）向けclaude-code-routerプロキシモード

### 法的免責事項

`claudex` は **独立した** オープンソースツールです。Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter、その他のプロバイダによってサポートまたは承認されていません。プロバイダの利用規約を守るのはあなたの責任です。

---

## English

### Why?

- Claude Codeを通じて、**より安価または無料** のAnthropic互換プロバイダ（DeepSeek、Z.ai、MiniMax、OpenRouter…）を使う
- 複数の**別請求**APIアカウント（例：個人＋会社）を、一つのターミナルで分離された `CLAUDE_CONFIG_DIR` で管理
- すべてはClaude CodeのUI/スキル/MCP/エージェントのエコシステム内に留まり、背後のモデル＋キーだけが変わる

> ⚠️ **これはAnthropic Pro/Maxのサブスクリプションをユーザー間で共有・複製したり、アカウントごとのレート制限を回避する方法ではありません。** Anthropicの[利用者規約](https://www.anthropic.com/legal/consumer-terms)および[使用ポリシー](https://www.anthropic.com/legal/aup)で禁止されています。`claudex` は**別々に認可された**プロバイダアカウント/APIキーを独立したプロファイルとして管理します。

### 前提条件

- Node.js 20以上 — https://nodejs.org/
- Claude Code — `npm install -g @anthropic-ai/claude-code`
- zsh または bash

### インストール（30秒）

```bash
git clone https://github.com/sasdsamatt123/claudex.git
cd claudex
npm install && npm run build && npm link
claudex init
```

> ℹ️ `npm install -g claudex` の公開は近日予定です。今のところは：git clone。

### 最初のプロファイル（ガイド付き）

```bash
claudex quickstart
```
Z.ai → MiniMax → OpenRouter（任意のものをスキップ）を案内します。完了したら：`source ~/.zshrc` を実行し、`claude-zai`（または `claude-minimax`、`claude-or`）で新しいモデルのClaude Codeを起動します。

### どのモデル？


```bash
claudex recommend
```
インタラクティブ: 「何をしたいですか？」→ 8つのユースケース（高速コーディング／リファクタリング／長いコンテキスト／ビジョン／…）。トップ3を理由とインストールコマンドと共に表示。

非インタラクティブ:

```bash
claudex recommend coding-fast --json
```

### 決定木

```
Free?
├── Forever-free model → claudex add <name> --provider zai
├── One of 32 free models → claudex add <name> --provider openrouter
└── Trial (until Nov 7 2026) → claudex add <name> --provider minimax

Cheap paid?
└── DeepSeek (~10x cheaper than Sonnet) → claudex add <name> --provider deepseek

Multiple separately-billed Anthropic API accounts (personal/company/project isolation)?
└── claudex add <name> --provider anthropic --no-share
```

### コマンド

```bash
claudex init                        # initial setup (~/.claudex + shell rc block)
claudex quickstart                  # guided setup of 3 free providers
claudex recommend [<intent>]        # top-3 model suggestions per use case
claudex add <name> [-p <provider>]  # add an alias (interactive)
claudex validate <name>             # ping the provider with a 1-token test
claudex list                        # list all profiles
claudex remove <name>               # remove alias
claudex providers [info <id>]       # provider catalog
claudex export <name> [-o file]     # redacted JSON template (no key)
claudex import <file>               # load template, prompt for key
claudex doctor                      # health check
claudex --lang tr                   # Turkish output
```

### 免責事項

`claudex` は独立したオープンソースツールです。**Anthropic、Z.ai、MiniMax、DeepSeek、Moonshot、OpenRouter、またはその他のプロバイダーとは一切関係なく、承認もスポンサーシップも受けていません。** 各プロバイダーの利用規約の遵守はユーザーの責任です。

### ライセンス

[MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-30

---