# Git Smart Squash

コミットの手動整理に時間を無駄にするのはやめましょう。AIに任せてください。

## 問題点

こんな経験はありませんか？機能追加のための15個のコミット、その半分が「fix」「typo」「WIP」。そして、PRレビューのためにきれいにまとめる必要があります。手作業でのsquashや書き換えは面倒です。

## 解決策

Git Smart Squashは、あなたの変更内容を分析し、論理的なコミットと適切なメッセージに再編成します。

```bash
# Before: your messy branch
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation
```
# After: clean, logical commits
* feat: JWT認証システムを実装
* test: 認証エンドポイントのカバレッジを追加
```

## クイックスタート

### 1. インストール

```bash
# pipを使用
pip install git-smart-squash

# pipxを使用（分離インストール推奨）
pipx install git-smart-squash

# uvを使用（高速なPythonパッケージマネージャー）
uv tool install git-smart-squash
```
### 2. AIのセットアップ

**オプションA: ローカル（無料、プライベート）**
```bash
# https://ollama.com からOllamaをインストール
ollama pull devstral  # デフォルトモデル
```

**オプションB: クラウド（より良い結果）**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. 実行

```bash
cd your-repo
git-smart-squash
```
以上です。プランを確認し、承認してください。

## コマンドラインパラメータ

| パラメータ | 説明 | デフォルト |
|------------|------|------------|
| `--base` | 比較対象となるベースブランチ | 設定ファイルまたは `main` |
| `--ai-provider` | 使用するAIプロバイダー（openai、anthropic、local、gemini） | 設定で構成 |
| `--model` | 使用する特定のAIモデル（下記の推奨モデルを参照） | プロバイダーのデフォルト |
| `--config` | カスタム設定ファイルへのパス | `.git-smart-squash.yml` または `~/.git-smart-squash.yml` |
| `--auto-apply` | 確認プロンプトなしでコミットプランを適用 | `false` |
| `--instructions`, `-i` | AIへのカスタム指示（例：「機能エリアごとにグループ化」） | なし |
| `--no-attribution` | コミットでの帰属メッセージを無効化 | `false` |
| `--debug` | 詳細情報のデバッグログを有効化 | `false` |

## 推奨モデル

### デフォルトモデル
- **OpenAI**: `gpt-4.1`（デフォルト）
- **Anthropic**: `claude-sonnet-4-20250514`（デフォルト）
- **Gemini**: `gemini-2.5-pro`（デフォルト）
- **Local/Ollama**: `devstral`（デフォルト）
### モデル選択
```bash
# 別のモデルを指定する
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# ローカルOllamaの場合
git-smart-squash --ai-provider local --model llama-3.1
```

## カスタムインストラクション

`--instructions` パラメータを使用すると、コミットの整理方法を制御できます。

### 例
```bash
# チケットのプレフィックスを追加
git-smart-squash -i "すべてのコミットに [ABC-1234] をプレフィックスとして追加する"

# 種類ごとに分ける
git-smart-squash -i "バックエンドとフロントエンドの変更を別々のコミットにする"
```
# コミット数の制限
git-smart-squash -i "コミット数を合計3つまでにする"
```

### より良い結果を得るためのヒント
- **具体的に指示する**：「データベースマイグレーションは別々にまとめてください」の方が「きれいに整理してください」より効果的です
- **1回につき1つの指示**：複雑な複数指示は一部無視される場合があります
- **より良いモデルを使う**：大規模モデルの方が小規模モデルより指示に忠実です

## よくあるユースケース

### 「PRレビュー前にクリーンアップしたい」
```bash
git-smart-squash              # プランを表示し、確認を求めます
git-smart-squash --auto-apply # 確認なしで自動適用します
```

### 「メインブランチが異なる場合」
```bash
git-smart-squash --base develop
```
### 「特定のAIプロバイダーを使用したい」
```bash
git-smart-squash --ai-provider openai
```

## セーフティ

**あなたのコードは安全です：**
- 変更を行う前に計画を表示
- 自動バックアップブランチを作成
- クリーンな作業ディレクトリが必要
- あなたのコマンドなしにプッシュしません

**もし何か問題が発生した場合：**
```bash
# バックアップを探す
git branch | grep backup

# 復元
git reset --hard your-branch-backup-[timestamp]
```

## AIプロバイダー

| プロバイダー | コスト | プライバシー |
|--------------|--------|--------------|
| **Ollama**   | 無料   | ローカル     |
| **OpenAI**   | 約$0.01 | クラウド     |
| **Anthropic**| 約$0.01 | クラウド     |
| **Gemini**   | 約$0.01 | クラウド     |

## 高度な設定（オプション）

カスタマイズしたい場合は、設定ファイルを作成してください：

**プロジェクト固有**（リポジトリ内の`.git-smart-squash.yml`）:
```yaml
ai:
  provider: openai  # このプロジェクトではOpenAIを使用
base: develop       # このプロジェクトのベースブランチとしてdevelopを使用
```
**グローバルデフォルト**（`~/.git-smart-squash.yml`）:
```yaml
ai:
  provider: local   # デフォルトで常にローカルAIを使用
base: main          # すべてのプロジェクトのデフォルトベースブランチ
```

## トラブルシューティング

### 「無効なJSON」エラー
これは通常、AIモデルがレスポンスを正しくフォーマットできなかったことを意味します。
- **Ollamaの場合**: `llama2`から`mistral`または`mixtral`に切り替えてください
- **解決方法**: `ollama pull mistral` を実行してから再試行
- **代替案**: `--ai-provider openai` を指定してクラウドプロバイダを利用

### モデルが指示に従わない
一部のモデルは複雑な指示が苦手です。
- **より良いモデルを使用**: `--model gpt-4-turbo` または `--model claude-3-opus`
- **指示を簡潔に**: 複数よりも一つの明確な指示が効果的
- **明示的に伝える**: 「[ABC-123] を前置してください」と伝え、「チケット番号を追加して」ではなく
### "Ollama が見つかりません"
```bash
# https://ollama.com からインストール
ollama serve
ollama pull devstral  # デフォルトモデル
```

### コミットのグループ化が不十分
AI がコミットを作りすぎたり、うまくグループ化できない場合:
- **モデルが不十分**: より大きなモデルを使用してください
- **指示を追加**: `-i "関連する変更をまとめて、最大3コミットにする"`
- **フィードバックを提供**: GitHubでIssueを作成し、何が起こったかお知らせください

### インストールの問題（Mac）
pipがない場合や、分離されたインストールを希望する場合:
```bash
# pipxを使用（推奨）
brew install pipx
pipx install git-smart-squash
```
### 「再編成する変更はありません」
```bash
git log --oneline main..HEAD  # コミットがあるか確認
git diff main                 # 変更があるか確認
```

### 大きな差分 / トークン制限
ローカルモデルには約32kトークンの制限があります。大きな変更の場合：
- より新しいコミットで `--base` を使用する
- クラウドに切り替える: `--ai-provider openai`
- 小さなPRに分割する

### さらにヘルプが必要ですか？

[詳細なドキュメント](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md)をご覧いただくか、issueを作成してください！

## ライセンス

MITライセンス - 詳細は [LICENSE](LICENSE) ファイルをご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---