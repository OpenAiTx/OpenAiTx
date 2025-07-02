# 🚀 MCP AI開発アシスタント

> AI開発者がインテリジェントな要件分析とアーキテクチャ設計を行うためのMCPツール

## ✨ コア機能

- **インテリジェント要件明確化**: プロジェクトタイプを自動識別し、的確な質問を生成
- **ブランチ認識管理**: プロジェクト目標、機能設計、技術的嗜好、UI設計などの側面を追跡
- **アーキテクチャ自動生成**: 完全な要件に基づき技術アーキテクチャ案を生成
- **永続化ストレージ**: 分析結果を自動保存し、ドキュメントのエクスポートに対応

## 📁 クイックセットアップ

### 旧バージョンのセットアップ
1. **コードをクローン**
   ```bash
   git clone https://github.com/jiemobasixiangcai/ai-develop-assistant.git
   ```
2. **仮想環境推奨**
   ```bash
   python -m venv venv
   source venv/bin/activate  # Unix/Linux/MacOS
   venv\Scripts\activate  # Windows
   ```
3. **依存関係をインストール**
   ```bash
   pip install -r requirements.txt
   ```

4. **設定ファイルの場所**
   ```
   Windows: %APPDATA%\Claude\claude_desktop_config.json
   macOS: ~/Library/Application Support/Claude/claude_desktop_config.json
   ```

5. **設定を追加**
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "python",
         "args": ["path/to/AIDevlopStudy.py"],
         "env": {
           "MCP_STORAGE_DIR": "./mcp_data"
         }
       }
     }
   }
   ```

3. **Claude Desktopを再起動**

### 新バージョンのセットアップ
#### 🔧 コアツール
1. **start_new_project** - 新規プロジェクト開始
2. **create_requirement_blueprint** - 要件ブループリント作成
3. **requirement_clarifier** - 要件明確化プロンプト取得
4. **save_clarification_tasks** - 明確化タスク保存
5. **update_branch_status** - ブランチステータス更新
6. **requirement_manager** - 要件ドキュメント管理
7. **check_architecture_prerequisites** - アーキテクチャ前提条件チェック
8. **get_architecture_design_prompt** - アーキテクチャ設計プロンプト取得
9. **save_generated_architecture** - 生成したアーキテクチャ設計保存
10. **export_final_document** - 完全ドキュメントエクスポート
11. **view_requirements_status** - 要件ステータス確認

#### 設定（リモート直結をツールにコピーし、MCP_STORAGE_DIRをローカルディレクトリに置換）
   ```json
   {
     "mcpServers": {
       "ai-develop-assistant": {
         "command": "uvx",
         "args": ["ai-develop-assistant@latest"],
         "env": {
           "MCP_STORAGE_DIR": "/path/to/your/storage"
         }
       }
     }
   }
   ```

## 🎯 利用フロー

### 基本ステップ

1. **要件明確化**
   ```
   requirement_clarifier("我要做一个在线教育平台")
   ```

2. **要件管理**
   ```
   requirement_manager("目标用户：学生和教师", "项目概述")
   ```

3. **ステータス確認**
   ```
   view_requirements_status()
   ```

4. **アーキテクチャ設計**
   ```
   architecture_designer("オンライン教育プラットフォームアーキテクチャ")
   ```

5. **ドキュメントのエクスポート**
   ```
   export_final_document()
   ```

## 🚀 はじめに

### クイックスタート
1. **Claude Desktopの設定**（上記の設定方法を参照）
2. **Claude Desktopの再起動**
3. **インテリジェントな要件分析を開始**：
   ```
   requirement_clarifier("あなたのプロジェクトアイデアを記述してください")
   ```
4. **AIのインテリジェントなガイドに従い**、各要件ブランチを順次完成させる
5. **完全なドキュメントをエクスポート**：
   ```
   export_final_document()
   ```

### ベストプラクティス
- 💬 **AIのブランチ管理を信頼する**：AIにすべての要件ブランチの完成を導かせる
- 🎯 **好みを明確に伝える**：技術選定、UIスタイル等について好みを明確に伝える
- 📊 **定期的に進捗を確認**：`view_requirements_status`で進捗状況を把握する
- 🤖 **AIに適切な権限を与える**：不明な部分は「一般的な方法で」と伝えることができる

---

**🎯 これで本当にインテリジェントなAI開発アシスタントを手に入れました。AIはすべての細部を記憶し、完全な要件分析の完了まで導いてくれます！**

## 💬 交流グループ

<div align="center">
<img src="https://raw.githubusercontent.com/jiemobasixiangcai/ai-develop-assistant/main/./assets/qr-code.jpg" width="200" alt="交流群">
<br>
交流グループ
</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---