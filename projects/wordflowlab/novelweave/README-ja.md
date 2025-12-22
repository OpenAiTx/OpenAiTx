# NovelWeave - AI搭載小説執筆VSCode拡張機能

[English](#) | [简体中文](https://raw.githubusercontent.com/wordflowlab/novelweave/main/README.zh-CN.md)

> 🌟 AI支援、体系的手法、シームレスなVSCode統合で小説執筆体験を変革します。
>
> 実績ある[novel-writer](https://github.com/wordflowlab/novel-writer)手法を基に、NovelWeaveはプロフェッショナルな小説作成ツールを直接VSCodeワークフローに提供します。

## ✨ 主な特徴

- 📝 **7ステップ手法** - 仕様主導の小説作成ワークフロー
- 🎨 **ビジュアルインターフェース** - 直感的なサイドバー、ウェブビュー、統合AIチャット
- 🤖 **マルチAI対応** - Claude 4、GPT-4、Gemini Pro、400以上のAIモデル対応
- 🧠 **エージェントスキル** - 専門的な執筆知識のためのモジュール式AI知識システム
- 📊 **プロジェクト管理** - 章管理、キャラクタープロフィール、プロットスレッド
- 🔌 **スラッシュコマンド** - novel-writerコマンドシステムの完全サポート
- ✅ **品質保証** - プロット追跡、タイムライン管理、一貫性検証
- 🌐 **クロスプラットフォーム** - Windows、macOS、Linux対応

## 🚀 クイックスタート

### 1. インストール

VSCodeマーケットプレイスからNovelWeaveをインストール：

```bash
# Search "NovelWeave" in VSCode Extensions
# Or install via command:
code --install-extension novelweave.novelweave
```
### 2. 最初の小説プロジェクトを作成する

1. VSCodeを開き、アクティビティバーのNovelWeaveアイコンをクリックします
2. 「新しいプロジェクト」をクリックして小説プロジェクトを初期化します
3. AIモデルを選択し、設定を構成します
4. AIの支援を受けながら執筆を開始しましょう！

### 3. 7ステップの方法論を使う

NovelWeaveは、実証済みの7ステップ小説作成方法論を実装しています：


```
1. /constitution  → Establish core creative principles
2. /specify       → Define story requirements
3. /clarify       → Resolve ambiguities through Q&A
4. /plan          → Design technical implementation
5. /tasks         → Break down into actionable steps
6. /write         → Execute the actual writing
7. /analyze       → Validate quality and consistency
```
## 📚 7ステップの方法論

### ステップ1: `/constitution` - クリエイティブ憲法

譲れない執筆原則、スタイルガイドライン、そして小説全体を導く中核的価値を定義します。

### ステップ2: `/specify` - ストーリー仕様

製品要件書（PRD）のように、作成したい物語、ターゲット読者、成功基準を正確に定義します。

### ステップ3: `/clarify` - 重要な確認事項

AIが仕様の曖昧さを特定し、執筆前に混乱を排除するための最大5つの重要な質問を生成します。

### ステップ4: `/plan` - クリエイティブプラン

抽象的な要求を具体的な技術的解決策に変換します：章構成、キャラクターの成長軌跡、世界観構築、プロットのタイムライン。

### ステップ5: `/tasks` - タスク分解

プランを優先順位と依存関係が明確な実行可能な執筆タスクに分解します。

### ステップ6: `/write` - 執筆の実行

タスクリストに基づき、憲法の原則とクリエイティブプランに従って執筆します。

### ステップ7: `/analyze` - 包括的検証

プロットの一貫性、タイムラインの正確さ、キャラクターの成長、クリエイティブ原則の遵守を検証します。

> 📖 **詳細な方法論**: [novel-writerドキュメント](https://github.com/wordflowlab/novel-writer)でさらに学べます

## 🔧 NovelWeave と novel-writer CLI の比較

| 機能                   | novel-writer CLI        | NovelWeave VSCode                   |
| ---------------------- | ---------------------- | ------------------------------------ |
| **インターフェース**   | コマンドライン         | グラフィカルUI                      |
| **インストール方法**   | `npm install -g`       | VSCodeマーケットプレイス            |
| **AI統合**             | 基本的                 | フルAIチャット＆支援                |

| **プロジェクト管理**    | ファイルシステム        | VSCodeワークスペース + UIパネル       |
| **スラッシュコマンド**  | ✅                     | ✅                                   |
| **ビジュアル追跡**      | ❌                     | ✅（プロット、キャラクター、タイムライン） |
| **習得難易度**          | CLIの知識が必要         | 直感的なUI                          |
| **最適対象**            | 技術に詳しい作家        | すべての作家、特にVSCodeユーザー    |

**両者は連携して使えます！** 自動化やスクリプトにはnovel-writer CLIを使用し、NovelWeaveはビジュアルインターフェースとAIとの対話を提供します。

## 🎯 ユースケース

- **長編小説** - 100章以上の複雑なプロット管理
- **ウェブ連載執筆** - AI支援で毎日の継続的な更新
- **脚本・シナリオ** - シーン管理による構造化されたストーリーテリング
- **ファンフィクション** - 原作との整合性維持
- **創作執筆** - どんな物語プロジェクトも構造化された手法で恩恵を受ける

## 📖 詳細機能

### エージェントスキルシステム

NovelWeaveの革新的な**エージェントスキル**システムは、オンデマンドで起動可能な専門知識モジュールをAIアシスタントに提供します：

- **組み込みスキル** - プロの執筆専門知識を含む：
    - ジャンル知識（ロマンス、ミステリー、ファンタジー）
    - 執筆技術（対話、シーン構造）
    - 品質保証（整合性チェック、要件検出）
- **プロジェクトスキル** - チーム固有のガイドラインを`.agent/skills/`で共有
- **パーソナルスキル** - 自分専用の再利用可能な知識ライブラリ
- **スマート起動** - AIがタスクに基づき関連スキルを自動選択
- **カスタムスキル** - 簡単なMarkdownで独自の専門モジュールを作成

> 📖 **詳細はこちら**：[エージェントスキルユーザーガイド](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) をご覧ください。

### AI搭載執筆アシスタント

- **スマート継続** - あなたの文体に基づき次の段落をAIが提案
- **キャラクターボイス** - 一貫したキャラクター性を維持
- **プロット提案** - プロットの穴やテンポの問題をAIが支援
- **スタイル分析** - 執筆スタイルと読みやすさに関するフィードバック

### プロジェクト組織

- **チャプターマネジメント** - サイドバーでチャプターをナビゲート・整理
- **キャラクタープロフィール** - キャラクターの成長と関係性を追跡
- **ワールドビルディング** - 設定、ルール、伝承を管理
- **プロットスレッド** - 複数のストーリーラインを視覚化・追跡

### 品質保証

- **一貫性チェック** - キャラクターの特徴、タイムライン、事実を検証
- **プロット追跡** - すべてのプロットスレッドが解決されていることを確認
- **タイムライン管理** - 時系列の正確性を検証
- **スタイルの一貫性** - 独自の文体を維持

## 🆕 新機能

### v0.13.0（最新）

- 🧠 **エージェントスキルシステム** - モジュラー型AI知識アーキテクチャ
    - 14の組み込みプロフェッショナルライティングスキル
    - 3層構造：拡張スキル、プロジェクトスキル、パーソナルスキル
    - タスクコンテキストに基づくスマート自動起動
    - カスタムスキルの閲覧、管理、作成のための完全なUI
- ✅ 品質保証ツールの強化
- 📚 包括的なドキュメントとベストプラクティスガイド

### v1.0

- ✅ 完全な7ステップメソッドの実装
- ✅ マルチAIモデル対応（400以上のモデル）
- ✅ 視覚的プロジェクト管理インターフェース
- ✅ 統合されたプロット・キャラクター追跡
- ✅ リアルタイムAIライティング支援
- ✅ 小説作家向けスラッシュコマンド完全対応

## 💡 ベストプラクティス

1. **憲法から始める** - 執筆前に原則を定義する
2. **Clarifyを積極的に使う** - 曖昧さを早期に解消して書き直しを防ぐ
3. **プロセスを信頼する** - 最良の結果のために7ステップすべてを実行する
4. **繰り返す** - 物語が進展するにつれて、以前のステップに戻る  
5. **一貫して追跡する** - 主要な章ごとにトラッカーを更新する  

## 🔗 関連リソース  

### ドキュメント  

- 📖 [エージェントスキルユーザーガイド](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-user-guide.md) - スキルの使い方と作成方法を学ぶ  
- 🛠️ [エージェントスキル開発者ガイド](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/agent-skills-developer-guide.md) - 技術的アーキテクチャとAPI  
- ✍️ [スキル作成のベストプラクティス](https://raw.githubusercontent.com/wordflowlab/novelweave/main/docs/writing-skills-best-practices.md) - 高品質なスキルを作成する  

### コミュニティ＆ツール  

- 📦 [novel-writer CLIツール](https://github.com/wordflowlab/novel-writer) - コマンドラインの補助ツール  
- 📖 [7ステップメソッド](https://github.com/wordflowlab/novel-writer/blob/main/METHODOLOGY.md) - 詳細な方法論ガイド  
- 💬 [コミュニティDiscord](#) - NovelWeaveを使う他の作家と交流  
- 📺 [ビデオチュートリアル](#) - ステップバイステップのガイドを見る  

## 🤝 貢献について  

貢献を歓迎します！詳細は[貢献ガイド](https://raw.githubusercontent.com/wordflowlab/novelweave/main/CONTRIBUTING.md)をご覧ください。  

## 📄 ライセンス  

MITライセンス - 詳細は[LICENSE](LICENSE)ファイルを参照してください。  

## 🙏 謝辞  

- [NovelWeave](https://github.com/NovelWeave-Org/novelweave)アーキテクチャを基盤に構築  
- 方法論は[novel-writer](https://github.com/wordflowlab/novel-writer)より  
- [Spec Kit](https://github.com/sublayerapp/spec-kit)の原則に着想を得る  

---  

**NovelWeave** - AIとストーリーテリングの達人技が融合する場所 ✨📚  

すべての作家のために❤️を込めて作られました


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-22

---