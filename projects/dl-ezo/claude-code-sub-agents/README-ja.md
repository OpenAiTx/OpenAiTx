# Claude Code 総合エージェントコレクション

**言語**: [英語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README.md) | [日本語](https://raw.githubusercontent.com/dl-ezo/claude-code-sub-agents/main/README_JA.md)

要求分析から本番展開および継続的な保守までのエンドツーエンドのソフトウェア開発自動化を可能にする、Claude Code用の専門サブエージェントの完全なコレクション。

## 🎯 概要

このリポジトリには、最小限の人的介入で完全なソフトウェア開発ライフサイクルを処理するための包括的なClaude Codeサブエージェントのセットが含まれています。エージェントは、現代のソフトウェア開発のあらゆる側面をカバーする6つのカテゴリに分類されています。

## 📦 エージェントカテゴリ

### 1. 要件および分析
**目的**: ビジネスニーズを詳細な技術仕様に変換する

- **requirements-analyst** - ユーザーのニーズを分析し、詳細な機能仕様を作成する
- **user-story-generator** - 包括的なユーザーストーリーと受け入れ基準を作成する  
- **business-process-analyst** - ビジネスプロセスを分析し、技術要件に翻訳する
- **requirements-validator** - 要件の完全性と一貫性を検証する

### 2. 設計およびアーキテクチャ
**目的**: 強固でスケーラブルなシステム設計を作成する

- **system-architect** - 包括的なシステムアーキテクチャと技術スタックを設計する
- **data-architect** - データモデル、スキーマ、および統合戦略を設計する
- **interface-designer** - ユーザーインターフェースとAPI仕様を設計する
- **security-architect** - セキュリティフレームワークとデータ保護戦略を設計する
- **design-reviewer** - システム設計の品質をレビューし検証する

### 3. 実装および開発
**目的**: コード開発と品質保証のあらゆる側面を担当する

- **code-reviewer** - 包括的なコード品質評価を実施する
- **test-suite-generator** - 包括的なテストカバレッジを生成する
- **code-refactoring-specialist** - 安全にコード構造を改善し技術的負債を削減する
- **security-analyzer** - 脆弱性とセキュリティ問題を特定する
- **performance-optimizer** - コードのパフォーマンスを分析し最適化する
- **api-designer** - 適切な仕様を持つクリーンなRESTful APIを設計する
- **documentation-generator** - 技術文書とコードコメントを作成する
- **dependency-manager** - パッケージ依存関係を管理し競合を解決する
- **database-schema-designer** - 効率的なデータベーススキーマとマイグレーションを設計する
- **git-manager** - Git操作、コミット整理、およびリポジトリ保守を管理する
- **cicd-builder** - CI/CDパイプラインを作成および構成する

### 4. プロジェクト管理
**目的**: 開発プロセス全体の調整と管理を行う

- **project-planner** - 包括的なプロジェクト計画とスケジュールを作成する
- **risk-manager** - プロジェクトリスクを特定し緩和戦略を策定する
- **progress-tracker** - プロジェクト進捗を監視し障害を特定する
- **qa-coordinator** - 品質基準を確立しテストを調整する
- **stakeholder-communicator** - ステークホルダーとのコミュニケーションと報告を管理する

### 5. 展開および運用
**目的**: 本番展開および継続的な運用を担当する

- **project-orchestrator** - エンドツーエンドのプロジェクト実行の総合コーディネーター
- **deployment-ops-manager** - 本番展開と運用監視を担当する
- **uat-coordinator** - ビジネスステークホルダーとユーザー受け入れテストを調整する
- **training-change-manager** - トレーニング資料を作成しシステム導入を管理する
- **project-template-manager** - プロジェクトテンプレートを管理し一般的なプロジェクトパターンの迅速設定を実現する

### 6. メタ管理
**目的**: Claude Code自体を最大効率で最適化する

- **context-manager** - セッションコンテキストを監視し継続性のため情報を管理する
- **session-continuity-manager** - Claude Codeセッション間のシームレスな移行を保証する
- **memory-manager** - Claude Codeのメモリ使用量とプロジェクト文書を最適化する
- **workflow-optimizer** - 開発ワークフローとエージェント使用を分析し最適化する
- **resource-monitor** - リソース使用を監視し最適化戦略を提案する
- **agent-creator** - プロジェクトニーズに応じて新しい専門エージェントを動的に作成する

## 🚀 主な特徴

### 完全自動化
- **エンドツーエンド開発**: 要件から本番展開まで
- **インテリジェントなオーケストレーション**: エージェントが自動で作業を調整・順序付け
- **動的な専門化**: 独自のプロジェクトニーズに応じて新エージェントを作成
- **セッションの継続性**: 長期開発セッション間でコンテキストを維持

### プロフェッショナル品質
- **業界ベストプラクティス**: 各エージェントが確立された方法論に従う
- **包括的テスト**: 自動テスト生成と品質保証
- **セキュリティ優先**: 組み込みのセキュリティ分析とコンプライアンスチェック
- **本番対応**: 完全な展開と運用サポート

### スケーラブルなアーキテクチャ
- **モジュラー設計**: 個別エージェントまたは完全ワークフローを使用可能
- **コンテキスト保持**: 長期プロジェクトのための効率的なメモリ管理
- **リソース最適化**: Claude Code使用の監視と最適化
- **テンプレート駆動**: 実績あるパターンで迅速なプロジェクト設定

## 💡 ユースケース

### 完全プロジェクト自動化
```
User: "Create a library management system for our company"
Result: Fully functional web application with database, API, frontend, tests, documentation, and deployment
```
### 専門的な開発作業

```
User: "Review this authentication code for security issues"
Agent: security-analyzer performs comprehensive security audit
```
### 長期プロジェクト管理

```
User: "Manage the development of a multi-tenant SaaS platform"
Agent: project-orchestrator coordinates all phases with appropriate specialists
```

## 📋 インストール

1. **エージェント定義をクローンまたはコピー**して、プロジェクトの `.claude/agents/` ディレクトリに配置します:
   ```bash
   mkdir -p .claude/agents
   # Copy the agent definition files to this directory
   ```

2. **インストールの確認**:
   ```bash
   ls .claude/agents/
   # Should show all agent files (.md format)
   ```

3. **Claude Codeでエージェントの使用を開始する**:
   ```
   Use the project-orchestrator agent to build a complete web application
   ```

## 🎮 使用例

### 新しいWebアプリケーションの開始
```
"I want to build a task management web application with user authentication, real-time updates, and mobile responsiveness. Handle everything from requirements to deployment."
```

**プロジェクトオーケストレーター**は以下を行います：
1. **要件アナリスト**を使用して詳細な要件を収集する
2. **システムアーキテクト**と**データアーキテクト**を調整して設計する
3. 開発エージェントと共に実装を管理する
4. テスト、展開、およびドキュメント作成を担当する
5. エンドユーザー向けのトレーニング資料を提供する

### コード品質レビュー
```
"Review my e-commerce checkout process for security vulnerabilities, performance issues, and code quality."
```

複数のエージェントが連携：
- **security-analyzer** は脆弱性をチェック
- **performance-optimizer** はボトルネックを特定  
- **code-reviewer** はベストプラクティスを保証

### 長期プロジェクト管理
```
"Manage the development of our new customer portal over the next 6 months with regular stakeholder updates."
```
システムは以下を提供します：
- 自動化されたプロジェクト計画とリスク管理
- 定期的な進捗追跡と報告
- 品質ゲートおよびテスト調整
- ステークホルダーとのコミュニケーション管理

## 🔧 エージェントワークフローパターン

### シーケンシャルパターン
要件 → 設計 → 実装 → テスト → 展開

### パラレルパターン
複数の開発エージェントが異なるコンポーネントを同時に作業

### アダプティブパターン
**agent-creator** が独自の要件に特化したエージェントを生成

### コンティニュアスパターン
メタ管理エージェントが継続的な最適化と監視を提供

## 📝 エージェント定義フォーマット

各エージェントはClaude Codeの標準フォーマットに従います：

```markdown
---
name: agent-name
description: Detailed description with examples and usage patterns
---

Comprehensive system prompt defining the agent's expertise, responsibilities, and methodologies.
```

## 🔄 エージェント間の相互作用

### マスターコーディネーター
- **project-orchestrator** はプロジェクト全体の流れを管理
- 適切なエージェントを自動的に選択し順序付け
- エージェント間の通信と依存関係の管理を担当

### 専門チーム
- **要件チーム**: プロジェクトのニーズを収集し検証
- **設計チーム**: 技術アーキテクチャと仕様を作成  
- **開発チーム**: コードの実装、テスト、最適化
- **運用チーム**: 本番システムの展開と維持管理
- **メタチーム**: Claude Codeの使用と継続性を最適化

## 📚 ドキュメント

各エージェントには以下を含む：
- **詳細な説明** と使用例
- **具体的なユースケース** とトリガー条件
- **期待される出力** と成果物
- **他エージェントとの統合パターン**

## 🎯 完全自動化の例

### 入力
```
"Create a library management system for our company"
```
### 自動化プロセス
1. **要件分析**: ステークホルダーのニーズ → 技術仕様
2. **システム設計**: アーキテクチャ → データベース設計 → API設計 → UI設計
3. **実装**: バックエンド → フロントエンド → テスト → ドキュメント作成
4. **品質保証**: コードレビュー → セキュリティ分析 → パフォーマンス最適化
5. **デプロイ**: 本番環境設定 → CI/CDパイプライン → 監視
6. **引き継ぎ**: ユーザートレーニング → ドキュメント → サポート手順

### 出力
- 完全に機能するウェブアプリケーション
- 高いカバレッジを持つ完全なテストスイート
- 監視付きの本番展開
- ユーザードキュメントとトレーニング資料
- 継続的なメンテナンス手順

## 🤝 貢献

ご協力を歓迎します！以下をお願いします：

1. 既存のエージェント定義フォーマットに従うこと
2. 包括的な例とドキュメントを含めること
3. 実際のプロジェクトで十分にテストすること
4. エージェントが既存のワークフローと良く統合されることを保証すること
5. エージェントの機能を明確に文書化して提出すること

## 📄 ライセンス

MITライセンス - これらのエージェントを目的に応じて自由に使用、改変、配布できます。

## 🙏 謝辞

[Claude Code](https://claude.ai/code)とシームレスに連携するよう設計されており、サブエージェント開発のすべての確立されたパターンとベストプラクティスに従っています。

## 📞 サポート

問題、質問、提案については：
- このリポジトリでイシューを開いてください
- Claude Codeのドキュメントを https://docs.anthropic.com/en/docs/claude-code でご確認ください
- エージェントの例と使用パターンをレビューしてください

---

*インテリジェントな自動化で開発プロセスを変革しましょう。単一の要件から本番システムまで、エージェントが複雑さを処理し、あなたはビジョンに集中できます。*

## 🚀 クイックスタート

1. **エージェントをコピー**してプロジェクトの `.claude/agents/` ディレクトリに配置
2. プロジェクト内で **Claude Codeを起動**
3. **次のように言う**: 「プロジェクトオーケストレーターを使って[あなたのプロジェクトの説明]を構築して」
4. システムが要件からデプロイまで全てを処理するのを **見守る**

**以上です！** エージェントが自動的に調整し、完全な本番対応ソリューションを提供します。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-31

---