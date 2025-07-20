<div align="center">
  <img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/logo.svg" alt="Claude Code UI" width="64" height="64">
  <h1>Claude Code UI</h1>
</div>


[Claude Code](https://docs.anthropic.com/en/docs/claude-code)、Anthropic公式のAI支援コーディング用CLIのためのデスクトップおよびモバイルUIです。ローカルまたはリモートで使用でき、claude code内のアクティブなプロジェクトやセッションを表示し、claude code CLIと同じ方法で変更を加えることができます。これにより、どこでも使える適切なインターフェースが提供されます。

## スクリーンショット

<div align="center">
  
<table>
<tr>
<td align="center">
<h3>デスクトップビュー</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/desktop-main.png" alt="Desktop Interface" width="400">
<br>
<em>プロジェクト概要とチャットを表示するメインインターフェース</em>
</td>
<td align="center">
<h3>モバイル体験</h3>
<img src="https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/mobile-chat.png" alt="Mobile Interface" width="250">
<br>
<em>タッチナビゲーション対応のレスポンシブモバイルデザイン</em>
</td>
</tr>
</table>



</div>

## 特徴

- **レスポンシブデザイン** - デスクトップ、タブレット、モバイルでシームレスに動作し、モバイルからもClaude Codeを利用可能
- **インタラクティブチャットインターフェース** - Claude Codeとのスムーズなコミュニケーションのための組み込みチャットインターフェース
- **統合シェルターミナル** - 組み込みシェル機能を通じてClaude Code CLIへ直接アクセス可能
- **ファイルエクスプローラー** - シンタックスハイライトとライブ編集機能を備えたインタラクティブなファイルツリー
- **Gitエクスプローラー** - 変更の表示、ステージング、コミットが可能。ブランチの切り替えも対応
- **セッション管理** - 会話の再開、複数セッションの管理、履歴の追跡が可能


## クイックスタート

### 前提条件

- [Node.js](https://nodejs.org/) v20以上
- [Claude Code CLI](https://docs.anthropic.com/en/docs/claude-code) のインストールと設定済み

### インストール

1. **リポジトリをクローン:**
```bash
git clone https://github.com/siteboon/claudecodeui.git
cd claudecodeui
```
2. **依存関係をインストールする：**

```bash
npm install
```
3. **環境の設定：**

```bash
cp .env.example .env
# Edit .env with your preferred settings
```
4. **アプリケーションを起動する：**

```bash
# Development mode (with hot reload)
npm run dev

```
アプリケーションは、.envで指定したポートで起動します

5. **ブラウザを開く:**
   - 開発環境: `http://localhost:3001`

## セキュリティとツール設定

**🔒 重要なお知らせ**: すべてのClaude Codeツールは**デフォルトで無効**になっています。これは潜在的に有害な操作が自動で実行されるのを防ぐためです。

### ツールの有効化

Claude Codeの全機能を使用するには、手動でツールを有効にする必要があります:

1. **ツール設定を開く** - サイドバーの歯車アイコンをクリック
3. **選択的に有効化** - 必要なツールだけをオンにする
4. **設定を適用** - 設定はローカルに保存されます

<div align="center">

![ツール設定モーダル](https://raw.githubusercontent.com/siteboon/claudecodeui/main/public/screenshots/tools-modal.png)
*ツール設定インターフェース - 必要なものだけを有効化*

</div>

**推奨方法**: 基本的なツールを有効にして開始し、必要に応じて追加してください。後からいつでも設定を調整できます。

## 使用ガイド

### コア機能

#### プロジェクト管理
UIは自動的に`~/.claude/projects/`からClaude Codeプロジェクトを検出し、以下を提供します:
- **ビジュアルプロジェクトブラウザ** - メタデータとセッション数を含むすべての利用可能なプロジェクト
- **プロジェクト操作** - 名前変更、削除、整理
- **スマートナビゲーション** - 最近のプロジェクトやセッションへのクイックアクセス

#### チャットインターフェース
- **レスポンシブチャットまたはClaude Code CLIの使用** - 適応されたチャットインターフェースを使うか、シェルボタンでClaude Code CLIに接続可能
- **リアルタイム通信** - WebSocket接続でClaudeからの応答をストリーミング
- **セッション管理** - 以前の会話を再開したり、新しいセッションを開始
- **メッセージ履歴** - タイムスタンプとメタデータ付きの完全な会話履歴
- **マルチフォーマット対応** - テキスト、コードブロック、ファイル参照

#### ファイルエクスプローラー＆エディター
- **インタラクティブファイルツリー** - 展開/折りたたみナビゲーションでプロジェクト構造を閲覧
- **ライブファイル編集** - インターフェース内で直接ファイルの読み込み、編集、保存
- **構文ハイライト** - 複数のプログラミング言語に対応
- **ファイル操作** - ファイルとディレクトリの作成、名前変更、削除

#### Gitエクスプローラー


#### セッション管理
- **セッションの永続化** - すべての会話が自動的に保存されます
- **セッションの整理** - プロジェクトとタイムスタンプでグループ化
- **セッション操作** - 名前変更、削除、会話履歴のエクスポート
- **デバイス間同期** - どのデバイスからでもセッションにアクセス可能

### モバイルアプリ
- **レスポンシブデザイン** - すべての画面サイズに最適化
- **タッチフレンドリーなインターフェース** - スワイプジェスチャーとタッチナビゲーション
- **モバイルナビゲーション** - 親指で操作しやすい下部タブバー
- **適応レイアウト** - 折りたたみ可能なサイドバーとスマートなコンテンツ優先順位付け
- **ホーム画面へのショートカット追加** - ホーム画面にショートカットを追加すると、アプリはPWAのように動作します

## アーキテクチャ

### システム概要

```
┌─────────────────┐    ┌─────────────────┐    ┌─────────────────┐
│   Frontend      │    │   Backend       │    │  Claude CLI     │
│   (React/Vite)  │◄──►│ (Express/WS)    │◄──►│  Integration    │
└─────────────────┘    └─────────────────┘    └─────────────────┘
```
### バックエンド（Node.js + Express）
- **Expressサーバー** - 静的ファイル提供付きのRESTful API
- **WebSocketサーバー** - チャットとプロジェクトのリフレッシュ用通信
- **Claude CLI連携** - プロセスの生成と管理
- **セッション管理** - JSONL解析と会話の永続化
- **ファイルシステムAPI** - プロジェクト用ファイルブラウザの公開

### フロントエンド（React + Vite）
- **React 18** - フックを用いたモダンなコンポーネントアーキテクチャ
- **CodeMirror** - 構文ハイライト機能付き高度なコードエディタ





### コントリビュート

貢献を歓迎します！以下のガイドラインに従ってください：

#### はじめに
1. リポジトリを**フォーク**する
2. フォークを**クローン**：`git clone <your-fork-url>`
3. 依存関係を**インストール**：`npm install`
4. 機能ブランチを**作成**：`git checkout -b feature/amazing-feature`

#### 開発プロセス
1. 既存のコードスタイルに従い**変更を加える**
2. **十分にテスト**し、全機能が正しく動作することを確認する
3. **品質チェックを実行**：`npm run lint && npm run format`
4. [Conventional Commits](https://conventionalcommits.org/) に従い説明的なメッセージで**コミット**
5. ブランチに**プッシュ**：`git push origin feature/amazing-feature`
6. 以下を含むプルリクエストを**提出**：
   - 変更点の明確な説明
   - UI変更のスクリーンショット
   - 該当する場合はテスト結果

#### 貢献できる内容
- **バグ修正** - 安定性の向上に貢献
- **新機能** - 機能拡張（まずはissueで相談）
- **ドキュメント** - ガイドやAPIドキュメントの改善
- **UI/UX改善** - より良いユーザー体験
- **パフォーマンス最適化** - 処理速度向上

## トラブルシューティング

### よくある問題と解決策

#### 「Claudeプロジェクトが見つかりません」
**問題**：UIにプロジェクトが表示されない、またはプロジェクトリストが空
**解決策**：
- [Claude CLI](https://docs.anthropic.com/en/docs/claude-code)が正しくインストールされているか確認
- 少なくとも1つのプロジェクトディレクトリで`claude`コマンドを実行して初期化
- `~/.claude/projects/`ディレクトリが存在し、適切な権限があるか確認
d

#### ファイルエクスプローラーの問題
**問題**：ファイルが読み込めない、権限エラー、空のディレクトリ
**解決策**：
- プロジェクトディレクトリの権限を確認（ターミナルで`ls -la`）
- プロジェクトパスが存在しアクセス可能か確認
- サーバーのコンソールログで詳細なエラーメッセージを確認
- プロジェクト範囲外のシステムディレクトリにアクセスしようとしていないか確認


## ライセンス

GNU一般公衆利用許諾契約書 バージョン3.0 - 詳細は[LICENSE](LICENSE)ファイル参照。

本プロジェクトはGPL v3ライセンスの下、オープンソースで自由に使用、改変、配布可能です。

## 謝辞

### 使用技術
- **[Claude Code](https://docs.anthropic.com/en/docs/claude-code)** - Anthropic公式CLI
- **[React](https://react.dev/)** - ユーザーインターフェースライブラリ
- **[Vite](https://vitejs.dev/)** - 高速ビルドツール兼開発サーバー
- **[Tailwind CSS](https://tailwindcss.com/)** - ユーティリティファーストCSSフレームワーク
- **[CodeMirror](https://codemirror.net/)** - 高度なコードエディタ


## サポートとコミュニティ

### 最新情報を入手
- このリポジトリに**スター**を付けてサポート
- 更新や新リリースを**ウォッチ**
- プロジェクトの**フォロー**でアナウンスを受け取る

### スポンサー
- [Siteboon - AI搭載ウェブサイトビルダー](https://siteboon.ai)
---

<div align="center">
  <strong>Claude Codeコミュニティのために心を込めて作成。</strong>
</div>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---