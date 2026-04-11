# PM Claude Code セットアップ

[![Stars](https://img.shields.io/github/stars/aakashg/pm-claude-code-setup?style=flat-square)](https://github.com/aakashg/pm-claude-code-setup/stargazers)
[![License](https://img.shields.io/github/license/aakashg/pm-claude-code-setup?style=flat-square)](LICENSE)

プロダクトマネージャー向けの本番対応可能なClaude Code設定です。これらのファイルをプロジェクトに入れるだけで、Claude Codeは即座にPMの仕事を理解します。

`CLAUDE.md`コンテキストファイル、6つのPMスキル、4つのテンプレートが含まれています。設定にかかる時間は60秒です。

**このセットアップは単独で機能します。フルPMオペレーティングシステムはさらに進んでおり、41以上のスキル、7つのサブエージェント視点、完全なコンテキストライブラリ、ローンチテンプレート、100回以上の反復で洗練されたスプリント計画ワークフローを備えています。**

**[フルPMオペレーティングシステムを入手 →](https://www.news.aakashg.com/p/pm-os)**

---

## 内容紹介

```
pm-claude-code-setup/
├── CLAUDE.md                           # Master context file — drop in your project root
├── templates/
│   ├── prd-template.md                 # Blank PRD structure
│   ├── launch-plan.md                  # Launch planning template
│   ├── okr-template.md                 # OKR scorecard
│   └── sprint-review.md               # Sprint review template
└── .claude/
    └── skills/
        ├── prd-writer/                 # "write a PRD" → structured PRD with clarifying questions
        ├── competitive-analysis/       # "analyze competitor" → smart/weak/implications framework
        ├── launch-checklist/           # "launch checklist" → risk-scaled pre/post launch plan
        ├── metrics-definer/            # "define metrics" → primary, guardrail, and anti-metrics
        ├── sprint-planner/             # "plan sprint" → capacity-checked sprint with risks
        └── user-research/              # "synthesize research" → evidence-ranked findings
```

## クイックセットアップ

**ステップ1:** `CLAUDE.md` をプロジェクトのルートにコピーしてください:
```bash
cp CLAUDE.md /path/to/your/project/
```

**ステップ2:** skillsフォルダーをコピーしてください：
```bash
cp -r .claude/ /path/to/your/project/
```
**ステップ3:** プロジェクトでClaude Codeを開きます。自動的に読み込まれます。

完了。ClaudeはあなたがPMであることを認識し、あなたの文体を踏襲し、指示に応じてPRDを作成します。

## CLAUDE.mdの役割

`CLAUDE.md`はマニュアルではなく、簡潔な設定ファイルです。Claudeにあなたが誰であるか、どのように書くか、守るべきルールを伝えます。冒頭の`[FILL IN]`部分を埋めるだけ（約2分）で、すぐに機能します：

- **あなたの文脈** — 役割、製品、指標、OKR、用語
- **執筆ルール** — 遵守すべきトーン、禁止語句、出力基準
- **サブエージェントの役割** — 6名のレビュアー（エンジニア、デザイナー、経営者、懐疑派、顧客、データ分析者）を表形式で
- **出力基準** — 生成前の確認質問、基準値付き指標、リスクと緩和策
- **スキル参照** — `.claude/skills/`へのリンク（ロジックの重複なし）
- **MCP連携** — あなたの統合環境（Notion、Jira、Slackなど）

ファイルは60行未満に抑えられています。Claudeは短く具体的な指示を長いものよりもよく理解します。

## PRDライタースキルの機能

「PRDを書いて」または「[機能名]のPRDを作成して」と言うと、Claudeは：

1. まず3〜5の確認質問を行う（盲目的に生成しない）
2. 仮説、問題、解決策、指標、非目標の構造化フォーマットに従う
3. 情報不足は`[NEED: data from X]`のプレースホルダーで示す
4. 要求がなければ2ページ以内にまとめる
5. 具体的な数値とガードレールを含む成功指標を提示する

## このセットアップを最大限活用する方法

### サブエージェントを連鎖させる

PRDを書く → 「エンジニアとしてレビュー」 → ギャップを修正 → 「懐疑派としてレビュー」 → 仮定を厳密化 → 「顧客としてレビュー」 → 価値提案を簡潔化。3回のパスで3分、仕様が劇的に向上。

### @参照を使う

ドキュメントをチャットに貼り付けず、参照先を指示してください：


```
Read @templates/prd-template.md and use that structure.
Summarize @meeting-notes/standup-03-04.md into action items.
Compare @competitor-notes/notion.md against @competitor-notes/monday.md.
```

Claudeは必要に応じてファイルを読み込みます。あなたのコンテキストウィンドウはクリアなままです。

### プランモードを使用する（Shift+Tab）

複雑なタスクの前に切り替えます。Claudeに実行前にアプローチを概説させます。あなたがプランを承認すると実行されます。未解決の質問があるPRDや複数ファイルの編集、「元に戻す」が高コストな場合に最適です。

### フックの設定

CLAUDE.mdの指示（助言）とは異なり、フックは決定論的に実行されます：

```
"Write a hook that spell-checks every file after I edit it"
"Write a hook that blocks writes to /templates/"
"Write a hook that runs a word count check — block any PRD over 1500 words"
```
/hooks または .claude/settings.json で設定します。終了コード0 = 続行、終了コード2 = フィードバック付きでブロック。

### セッション管理

- **無関係なタスク間は `/clear` を使用。** コンテキストの混在は品質低下の最大要因です。
- **会話は約50回のやり取りで制限。** これを超えると品質が低下します。
- **ハンドオフを活用。** 長いセッションを終える前に：「HANDOFF.mdを書いてください。」次のセッションで：「@HANDOFF.md を読み、続行してください。」
- **並行セッションを実行。** 複数のターミナルで、それぞれ独立したClaudeインスタンスとコンテキストウィンドウを使用。
- **セッションを再開。** 最後のセッションは `claude --continue`、履歴から選択するには `claude --resume`。

### CLAUDE.md を自己改善させる

Claudeがミスをしたら修正し、「そのミスを繰り返さないルールをCLAUDE.mdに追加してください。」と指示。Claudeがルールを提案し、承認するとファイルを編集。次回セッションで自動的にルールが読み込まれます。四半期ごとに整理。

### スキルをカスタマイズ

スキルには汎用例が付属。自社製品の実例に置き換えましょう。チームの速度を理解したスプリントプランナーは、常に汎用的なものより優れています。

### 実際のアーティファクトを投入

Slackのスレッドを説明せずに貼り付けてください。ユーザーインタビューを要約せずに、トランスクリプトを貼り付けます。スキルは散らかった情報を抽出・構造化します。生の入力が最高の出力を生みます。

### クイックリファレンス


```
/clear              Reset context (CLAUDE.md reloads automatically)
/hooks              Configure automation hooks
/init               Generate a starter CLAUDE.md from your project
/permissions        Set tool access rules
Shift+Tab           Toggle Plan Mode
Esc                 Cancel current generation
claude --continue   Resume last session
claude --resume     Pick a specific past session
claude -p "prompt"  Non-interactive single prompt
```

---

## フルセットアップが欲しいですか？

このセットアップはコアのPMワークフローをカバーしています。フルPM OSは私が毎日実行するすべてのPMタスクをカバーします：

- 41以上のカスタムスキルがすべてのPMタスクに対応
- 7つのサブエージェント視点（エンジニア、デザイナー、経営陣、懐疑主義者、顧客、データアナリスト、法務）
- OKR、用語集、チーム構成のコンテキストライブラリ
- ローンチ、ロードマップ、レトロスペクティブ、スプリント計画のテンプレート
- 自動スペルチェックとファイル保護のフック

**[フルPMオペレーティングシステムを入手する →](https://www.news.aakashg.com/p/pm-os)**

---

[Aakash Gupta](https://www.aakashg.com) 作成 | [プロダクト成長ニュースレター](https://www.news.aakashg.com)

---

## トラブルシューティング

よくある問題と解決策。

### ClaudeがCLAUDE.mdの指示に従わないようです

- **ファイルの場所を確認してください。** CLAUDE.mdはプロジェクトのルート（`claude`を実行するディレクトリ）に置く必要があります。Claude Codeは作業ディレクトリから自動的に読み込みます。
- **ファイルサイズを確認してください。** 約150行を超えるとClaudeは指示を無視し始めます。積極的に整理してください。ドメイン知識はスキルに移動しましょう。
- **矛盾する指示がないか確認してください。** 矛盾したルールは予測不可能な動作を引き起こします。矛盾を監査してください。
- **セッションを再起動してください。** `/clear`を実行するか、新しいターミナルを開始してください。Claudeはセッション開始時にCLAUDE.mdを読み込みます。

### スキルが起動しない

- **パスを確認してください。** スキルは`.claude/skills/<skill-name>/SKILL.md`にある必要があります（大文字・小文字も正確に）。
- **トリガーを確認してください。** SKILL.mdには、あなたの問いかけと一致する明確なトリガーフレーズが必要です。もしSKILL.mdが「ユーザーがPRDの作成を依頼したときに起動」と書いていて、あなたが「仕様書を作成して」と言うと、Claudeは結びつけられないかもしれません。
- **明示的なリクエストでテストしてください。** 例：「prd-writerスキルを使ってXのPRDを書いてください。」これで動作するが自然な言葉で動かない場合は、トリガーの説明を改善しましょう。
- **SKILL.mdが空または不正でないか確認してください。** 開いて内容を確認しましょう。

### Claudeが会話途中でコンテキストを忘れる
- **コンテキスト制限。** 長い会話は約50回のやり取り後に劣化します。`/clear` を使って要約とともに新しく始めてください。  
- **ハンドオフを使う。** クリアする前に、ClaudeにHANDOFF.mdを作成させて状態、決定事項、次のステップをまとめさせてください。新しいセッションは「Read @HANDOFF.md and continue.」で始めます。  
- **巨大なドキュメントを貼り付けない。** チャットに全文を貼るのではなく、`@`参照を使ってください。  

### フックが動作しない場合  

- **`.claude/settings.json`を確認。** フックはそこに設定されており、CLAUDE.mdにはありません。  
- **終了コードを確認。** フックはexit 0（続行）とexit 2（ブロック＋フィードバック）を使います。他の終了コードは予期しない動作を引き起こす可能性があります。  
- **権限を確認。** フックスクリプトは実行可能である必要があります（`chmod +x`）。  

### MCPサーバーが接続できない場合  

- **認証情報を確認。** 多くのMCPサーバーはAPIキーやOAuthトークンを必要とします。現在のものか確認してください。  
- **サーバー設定を確認。** MCP接続はClaude Codeの設定で行い、CLAUDE.mdでは参照用にのみ記述されています。  
- **Claude Codeを再起動。** MCP接続は起動時に初期化されます。  

### 「CLAUDE.mdを変更したが何も変わらない」  

Claudeはセッション開始時にCLAUDE.mdを読み込みます。セッション中の編集はリロードが必要です：  
1. `/clear`を実行してコンテキストをリセット（CLAUDE.mdは自動で再読み込みされます）  
2. または新しいターミナルセッションを開始



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-11

---