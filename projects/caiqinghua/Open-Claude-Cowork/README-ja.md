# 例：作業フォルダの整理を手伝ってください

https://github.com/user-attachments/assets/48743a51-705a-4c66-9fdb-4d7147f8098b


[简体中文](https://raw.githubusercontent.com/caiqinghua/Open-Claude-Cowork/main/README_ZH.md)

# Claude Cowork

**プログラミング、ファイル管理、そしてあなたが説明できるあらゆるタスクを支援する**デスクトップAIアシスタント。

Claude Codeと**まったく同じ設定で完全互換**のため、**Anthropic互換の大規模言語モデルならどれでも実行可能**です。

**✨ Claude Maxのサブスクリプションは不要** - Zhipu GLM 4.7、MiniMax 2.1、Moonshot Kimi、DeepSeekなど、あらゆるAnthropic互換APIモデルをサポート。

> 単なるGUIではありません。  
> 本物のAIコラボレーションパートナーです。  
> Claude Agent SDKを学ぶ必要はありません — タスクを作成し、実行パスを選ぶだけです。


---

## ✨ なぜClaude Coworkなのか？

Claude Codeは強力ですが — **端末でしか動作しません**。

つまり：
- ❌ 複雑なタスクに対する視覚的フィードバックがない
- ❌ 複数セッションの追跡が困難
- ❌ ツールの出力を確認しづらい

**Open Claude Coworkはこれらの問題を解決します：**

- 🖥️ **ネイティブのデスクトップアプリケーション**として動作
- 🤖 あらゆるタスクにおける**AIコラボレーションパートナー**として機能
- 🔁 既存の**`~/.claude/settings.json`を再利用**
- 🧠 Claude Codeと**100%互換**

あなたのマシンでClaude Codeが動くなら —  
**Open Claude Coworkも動きます。**
---

## 🚀 クイックスタート

> **💡 ヒント:** このアプリはClaude Codeの設定と完全に互換性があります。Claude Maxのサブスクリプションは不要で、Zhipu GLM、MiniMax、Kimi、DeepSeek、またはその他のAnthropic対応APIモデルを使用できます。

Open Claude Coworkを使用する前に、Claude Codeがインストールされ正しく設定されていることを確認してください。

### オプション1: リリースをダウンロード

👉 [リリースページへ](https://github.com/caiqinghua/open-claude-cowork/releases)

---

### オプション2: ソースからビルド

#### 前提条件

- [Bun](https://bun.sh/) または Node.js 22以上
- [Claude Code](https://docs.anthropic.com/en/docs/claude-code) がインストールされ認証済み


```bash
# Clone the repository
git clone https://github.com/caiqinghua/open-claude-cowork.git
cd open-claude-cowork

# Install dependencies
bun install

# Configure environment (copy .env.example to .env)
cp .env.example .env

# Run in development mode
bun run dev

# Or build production binaries
bun run dist:mac    # macOS
bun run dist:win    # Windows
bun run dist:linux  # Linux
```

---

## 🧠 コア機能

### 🤖 AIコラボレーションパートナー — ただのGUIではない

Open Claude Coworkは以下が可能なあなたのAIパートナーです：

* **コードの作成と編集** — あらゆるプログラミング言語で
* **ファイル管理** — 作成、移動、整理
* **PPT作成** — プレゼンテーションの内容と構成の生成
* **トピック分析** — 研究テーマや方向性の詳細な分析
* **記事作成** — 各種記事や文書の執筆
* **何でも対応** — 自然言語で記述できれば可能

---

### 📂 セッション管理

* **カスタム作業ディレクトリ**でセッション作成
* 以前の会話を再開可能
* ローカルのセッション履歴完全保存（SQLiteに保存）
* 安全な削除と自動保存

---

### 🎯 リアルタイムストリーミング出力

* **トークン単位のストリーミング出力**
* Claudeの推論過程を閲覧可能
* シンタックスハイライト付きコードのMarkdownレンダリング
* ステータス表示付きのツール呼び出しの可視化

---

### 🔐 ツール権限管理

* 機微な操作には明示的な承認が必要
* ツールごとに許可または拒否可能
* インタラクティブな意思決定パネル  
* Claudeに許可する操作を完全に制御可能  

---

## 🔁 Claude Codeとの完全互換

Open Claude Coworkは**Claude Codeと設定を共有**します。

以下を直接再利用します：

text  
~/.claude/settings.json  

これは以下を意味します：

* 同じAPIキー  
* 同じベースURL  
* 同じモデル  
* 同じ動作  

**対応モデルには以下が含まれます：**  
- Zhipu GLM 4.7  
- MiniMax 2.1  
- Moonshot Kimi  
- DeepSeek  
- その他すべてのAnthropic互換APIモデル  

> Claude Codeを一度設定すれば、どこでも使えます。  

---

## 🔧 トラブルシューティング

### better-sqlite3モジュールエラー

以下のようなエラーが発生した場合：


```
Error: The module was compiled against a different Node.js version using
NODE_MODULE_VERSION 127. This version of Node.js requires NODE_MODULE_VERSION 140.
```

これは、Electronが独自のNode.jsバージョンをバンドルしており、ネイティブモジュールをそれに合わせて再コンパイルする必要があるためです。

**解決策：**

```bash
# Install electron-rebuild as a dev dependency
npm install --save-dev electron-rebuild

# Rebuild better-sqlite3 for Electron
npx electron-rebuild -f -w better-sqlite3

# Run the app again
bun run dev
```
これは、ネイティブモジュールがシステムのNode.jsバージョンではなく、ElectronのNode.jsバージョンに対してコンパイルされることを保証します。

---

## 🧩 アーキテクチャ概要

| レイヤー          | 技術                          |
| ---------------- | ------------------------------ |
| フレームワーク    | Electron 39                   |
| フロントエンド    | React 19, Tailwind CSS 4       |
| 状態管理          | Zustand                       |
| データベース      | better-sqlite3 (WALモード)     |
| AI               | @anthropic-ai/claude-agent-sdk |
| ビルド            | Vite, electron-builder        |

---

## 🛠 開発

bash
# 開発サーバー起動（ホットリロード）
bun run dev

# 型チェック / ビルド
bun run build


---

## 🗺 ロードマップ

予定されている機能：

* モデルおよびAPIキーのGUIベース設定
* 🚧 その他の機能を近日追加予定

---

## 🤝 コントリビューティング

プルリクエストを歓迎します。

1. このリポジトリをフォークしてください
2. フィーチャーブランチを作成してください
3. 変更をコミットしてください
4. プルリクエストを開いてください

---

## ⭐ 最後に

もしあなたが望んでいたなら：

* 永続的なデスクトップAIコラボレーションパートナー
* Claudeの動作を視覚的に理解するインサイト
* プロジェクト間で便利なセッション管理

このプロジェクトはあなたのために作られています。

👉 **もし役に立ったら、スターをお願いします。**

---

## ライセンス

MIT






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-02

---