# トータルリコール

Claude Code のための記憶システムで、重要なことは覚え、重要でないことは忘れます。

## 問題点

Claude Code はセッション間で何も覚えていません。新しい会話を始めるたびに、記憶喪失の人と話しているようなものです。結局、同じことを繰り返します：

- 「その方法はもう試しましたが、うまくいきませんでした。」
- 「認証ファイルには触らないでください。」
- 「スペースよりタブが好きです。」
- 「クライアントの名前はサラではなくサーラです。」

これはすぐに飽きてしまいます。

## トータルリコールの機能

Claude Code に、セッション間で引き継がれるメモ帳を与えますが、*厳選された*メモ帳です。すべてが保存されるわけではありません。永久保存される前に、簡単なテストを通過しなければなりません：**明日も重要か？**

数ヶ月続くあなたの好み？保存。あなたが下した決定とその理由？保存。5分前にテストを実行した事実？保存しません。システムはクリーンな状態を保ち、Claude が関連するものを探しやすくしています。

## 仕組み

キッチンに4つの収納エリアがあると考えてください：

**カウンター** (`CLAUDE.local.md`)：毎日手に取るもの。毎セッション自動で読み込まれます。意図的に小さく、テキスト1ページ程度。

**パントリー** (`memory/registers/`)：カテゴリー別に整理されています。あなたの好み、重要な決定、プロジェクトの詳細、仕事仲間。Claude は特定のものが必要なときにここをチェックします。

**デイリーノート** (`memory/daily/`)：日付入りのメモ書きです。すべて最初にここに書かれます。後で何を永久保存するか決めます。

**収納クローゼット** (`memory/archive/`)：終了または古くなったもの。検索は可能ですが、自動的には読み込まれません。

重要なアイデア：**メモはまずデイリーノートに入り、そこから保存すべきものを昇格させます。** Claude 自身が何を永久に覚えるべきかを決めることはありません。決めるのはあなたです。

## クイックスタート

### プラグインとしてインストール（推奨）

```
/plugin marketplace add davegoldblatt/recall-marketplace
/plugin install recall@recall-marketplace
```

### またはスタンドアロンでインストールする

```
git clone https://github.com/davegoldblatt/total-recall.git
cd total-recall
./install.sh /path/to/your/project
```
インストール後、Claude Codeを再起動するか、`/hooks`を実行して有効化してください。

## 使用方法

日常的には以下の通りです：

**Claudeが記憶すべきことに気づきます。** それをあなたの日記に書き込み、あなたに伝えます。あなたは何もする必要はありません。

**Claudeに何かを記憶させたい場合。** 「これを覚えて」と言うか、書き込みコマンドを使用してください：


```
/recall-write Dave prefers concise error messages, no stack traces in prod
```

**一日の終わり（または任意のタイミング）** たまったものを確認し、良いものを昇格させる:

```
/recall-promote
```

**先週の何かを見つける。** すべての中から検索:

```
/recall-search authentication decision
```

**あなたはクロードを訂正します。** 訂正は一度にすべて更新されます：日誌、レジスター、カウンター。同じミスは二度と起こりません。

### 全コマンド

| コマンド | 内容 |
|---|---|
| `/recall-init` | メモリフォルダを初めてセットアップする |
| `/recall-write <note>` | ノートを保存する（保持する価値があるか確認し、保存場所を提案） |
| `/recall-log <note>` | 日誌にクイックノート、質問なしで記録 |
| `/recall-search <query>` | すべてを検索する |
| `/recall-promote` | 日々のノートを見直し、保持すべきものをレジスターに移動 |
| `/recall-status` | 健康チェック。すべてが正常か？ |
| `/recall-maintain` | 古くなったり重複したエントリをクリーンアップ |
| `/recall-forget <query>` | 何かを古い情報としてマークする |
| `/recall-context` | 現在クロードが読み込んでいるメモリを表示 |

プラグインとしてインストールされている場合、コマンドは名前空間付き：`/recall:recall-write` となり `/recall-write` ではありません。

## 書き込みゲート

これが核心的な考え方です。何かが恒久的なメモリに昇格される前に、少なくとも以下のチェックのどれかを通過しなければなりません：

1. **次回のクロードの振る舞いを変えるか？**（好み、境界線、パターン）
2. **誰かが頼りにしている約束か？**（締め切り、成果物、フォローアップ）
3. **理由を覚えておく価値のある決定か？**（なぜXを選んだかなど）
4. **安定した事実でまた現れるか？**（明日には変わらないもの）
5. **「これを覚えて」と明確に言ったか？**

これらのどれも当てはまらなければ、日誌に留まり、やがて期限切れになります。これでメモリがスリムに保たれます。不要な引き出しはなし。

## 訂正が起こるとき

クロードに間違いを指摘すると、ただ「すみません」と言って終わるのではありません。日誌、該当するレジスター、カウンターを一度に更新します。古い情報は削除されずに置き換え済みとしてマークされ、何がいつ変わったかの記録が残ります。

## 自動的に読み込まれるもの

毎セッション、以下の2つだけ：

| 何を | どこで | どのように |
|---|---|---|
| ルール（書き込みゲート、修正プロトコル） | `rules/total-recall.md` | Claude Codeは全てのルールファイルを自動的に読み込みます |
| カウンター / 作業メモリ | `CLAUDE.local.md` | Claude Codeはこれを自動的に読み込みます |

その他は必要に応じて読み込みます：検索時、関連時、またはセッション開始時のフック経由で。

## フック

バックグラウンドで自動的に2つのことが起こります：

**セッション開始時：** Claudeは未完了項目と最近の日次ノートの概要を取得します。これは「ここまでの進捗」ブリーフィングです。

**メモリ圧縮前：** タイムスタンプが日次ノートに書き込まれ、記録が残ります。これは無音で行われます。Claudeはこれを見ず、単なる帳簿管理です。

両方のフックは安全に失敗します。問題があってもClaude Codeの動作を妨げません。

フックはパス解決に`$CLAUDE_PROJECT_DIR`（スタンドアロン）または`${CLAUDE_PLUGIN_ROOT}`（プラグイン）を使用します。トランスクリプト解析はありません。PreCompactフックはタイムスタンプマーカーを日次ログに書き込むだけで、会話トランスクリプトの読み込みや解析は行いません。

## アーキテクチャ

技術的な詳細を知りたい方向け。

```
Conversation (ephemeral, compacted/discarded)
    |
    v  WRITE GATE: "Does this change future behavior?"
    |
Daily Log (memory/daily/YYYY-MM-DD.md)
    All writes land here first. Raw, timestamped.
    |
    v  PROMOTION: user-controlled via /recall-promote
    |
Registers (memory/registers/*.md)
    Structured claims with metadata (confidence, evidence, last_verified)
    |
    v  DISTILLATION: only what's essential for every session
    |
Working Memory (CLAUDE.local.md)
    ~1500 words. Auto-loaded. The persistent "personality."
    |
    v  EXPIRY
    |
Archive (memory/archive/)
    Searchable history. Never auto-loaded.
```

### 主要メカニズム

**書き込みゲート:** ノイズを除去します。行動を変える事実、約束、決定、および明示的な「これを覚えておいて」要求のみが通過します。

**日次ログ優先:** すべての書き込みは日次ログに記録されます。レジスタへの昇格は別のステップで、ユーザーが制御します。これによりモデルが推論を早期に固定化するのを防ぎます。

**矛盾プロトコル:** 静かに上書きしません。古い主張は日付と理由とともに`[superseded]`としてマークされます。変更のパターンは保持されます。

**訂正ゲート:** 人間の訂正が最優先です。1回の訂正で日次ログ＋レジスタ＋作業メモリへの書き込みがトリガーされます。

### ファイル構造

**プラグイン形式**（`/plugin install`でインストール）:

```
total-recall/                     # Plugin root
├── .claude-plugin/
│   └── plugin.json               # Plugin manifest
├── skills/                       # Slash commands (namespaced)
│   ├── recall-write/SKILL.md
│   ├── recall-search/SKILL.md
│   └── ...
├── hooks/
│   ├── hooks.json                # Hook configuration
│   ├── session-start.sh
│   └── pre-compact.sh
├── rules/
│   └── total-recall.md           # Protocol (auto-loaded)
└── templates/                    # Scaffolding templates
    ├── SCHEMA.md
    ├── CLAUDE.local.md
    └── registers/
```

**スタンドアロン形式**（`install.sh`を使用してインストール）:

```
your-project/
├── .claude/
│   ├── commands/recall-*.md      # Slash commands
│   ├── rules/total-recall.md     # Protocol (auto-loaded)
│   ├── hooks/*.sh                # Hook scripts
│   └── settings.local.json       # Hook configuration
├── memory/
│   ├── SCHEMA.md
│   ├── daily/YYYY-MM-DD.md
│   ├── registers/*.md
│   └── archive/
├── CLAUDE.md
└── CLAUDE.local.md               # Working memory (gitignored)
```
### 他のメモリーツールとの比較

|  | Total Recall | 自動取り込みツール |
|---|---|---|
| **保存されるもの** | 書き込みゲートを通過したもののみ | すべて |
| **デフォルトの保存先** | 日次ログ（後で昇格） | 永続ストレージ |
| **コンテキストコスト** | 約1500語の作業メモリ | 無制限に増加 |
| **修正** | 全階層に即時反映 | 変動あり |
| **ユーザー制御** | 昇格は明示的 | 自動 |
| **アーキテクチャ** | メタデータ付き4層構造 | フラットまたは2層 |

## プライバシー

- すべてローカルで動作。ネットワークコールなし、テレメトリなし、外部サービスなし。
- すべてのメモリは自分で読んだり編集したりできるプレーンなMarkdownファイル。
- `CLAUDE.local.md`はデフォルトでgitignoreされている（個人用）。
- `memory/`もデフォルトでgitignoreされている（個人メモを含む可能性あり）。
- フックは会話のトランスクリプトを読み取らない。
- 何が起きているか正確に知りたい場合は、`hooks/*.sh`と`memory/`を確認。すべてプレーンテキスト。
- アンインストールするには、`memory/`、`CLAUDE.local.md`、および`.claude/`のエントリ（または`/plugin uninstall recall`）を削除。

## Superpowersとの併用

[Superpowers](https://github.com/obra/superpowers)を使用しても競合はありません。SuperpowersはClaudeの動作方法（方法論、TDD、計画）を管理し、Total RecallはClaudeが何を記憶するかを管理します。役割は異なりますが、同じプロジェクトです。

## ライセンス

MIT



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---