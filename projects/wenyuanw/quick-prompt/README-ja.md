<translate-content># クイックプロンプト

[English](https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./README_en.md) | 中文

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

強力なブラウザ拡張機能で、プロンプト管理と迅速な入力に特化しています。ユーザーがプロンプトライブラリを作成、管理、整理し、どのウェブページの入力欄でも事前設定されたプロンプト内容を素早く挿入できるようにし、作業効率を向上させます。

> ブラウザプラグインはウェブ端末でのみ使用可能なため、同じ機能を持つ [Raycast プラグイン](https://github.com/wenyuanw/quick-prompt-raycast) をオープンソース化しました。ブラウザプラグインのデータ形式と互換性があり、同じJSONデータを通じてシームレスに移行可能です。

## ✨ 機能特徴

- 📚 **プロンプト管理**：簡単にプロンプトライブラリを作成、編集、管理
- 🚀 **迅速入力**：どのウェブページの入力欄でも `/p` でプロンプトセレクターを素早く起動
- ⌨️ ショートカットキーでプロンプトセレクターを開く＆選択テキストをプロンプトとして保存可能
- 📑 右クリックメニューから選択テキストを直接プロンプトとして保存可能
- 🎯 カスタムプロンプト対応（カテゴリ、タイトル、内容、タグ、変数）
- 🧑‍💻 **変数サポート**：プロンプト内で `{{変数名}}` 形式の変数を使用でき、利用時に具体的な値を入力可能
- 💾 **データバックアップ**：プロンプトライブラリのエクスポートとインポートに対応し、デバイス間の移行やバックアップが容易
- 🔗 **Notion同期**：プロンプトライブラリをNotionデータベースと同期可能
- 🔍 プロンプトの検索とフィルター機能をサポート
- 🌙 システムのライト/ダークテーマに自動対応

## ⚠️ 既知の問題

- 豆包（doubao.com）ウェブページで、`/p` によってプロンプトセレクターを起動した後、一部入力欄で `/p` がクリアされない問題があります。しかしご安心ください。私と相棒のCursorは日夜解決策を模索しており、早期修正を目指しています！

## 🚀 使い方

1. **迅速起動**：どのウェブページのテキスト入力欄でも `/p` を入力してプロンプトセレクターを起動
2. **ショートカットで開く**：`Ctrl+Shift+P`（Windows/Linux）または `Command+Shift+P`（macOS）でプロンプトセレクターを開く
3. **プロンプト選択**：ポップアップしたセレクターから必要なプロンプトをクリックすると、現在の入力欄に自動挿入
4. **迅速保存**：任意のテキストを選択後、`Ctrl+Shift+S`（Windows/Linux）または `Command+Shift+S`（macOS）で即座にプロンプトとして保存
5. **右クリックメニュー保存**：任意のテキストを選択後、右クリックして「このプロンプトを保存」を選び、選択内容をプロンプトとして保存
6. **プロンプトライブラリのエクスポート**：管理ページで「エクスポート」ボタンを押し、全プロンプトをJSONファイルにエクスポートしてローカル保存
7. **プロンプトライブラリのインポート**：管理ページで「インポート」ボタンを押し、ローカルJSONファイルからプロンプトをインポート（既存プロンプトのマージまたは上書き対応）

## 📸 インターフェースプレビュー

Quick Promptは直感的で使いやすいユーザーインターフェースを提供し、プロンプトの管理と利用を簡単にします。

### プロンプトセレクター

![プロンプトセレクター](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![プロンプトセレクター](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` コマンドやショートカットで任意の入力欄に素早くプロンプトセレクターを呼び出し、必要なプロンプトを選んで挿入可能です。

### プロンプト管理ページ

![プロンプト管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

管理ページでは、新しいプロンプトの作成、既存プロンプトの編集、タグ付け、カテゴリ管理が可能。インターフェースはシンプルで操作しやすいです。

### 右クリックメニュー保存

![右クリックメニュー保存](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

ウェブページ上の任意のテキストを選択し、右クリックで素早くプロンプトとして保存でき、作業効率を向上。

### プロンプト変数入力

![プロンプト変数ポップアップ](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

プロンプトは変数設定に対応し、選択後にポップアップで対応する変数値を入力できます。

## ⚙️ カスタム設定

1. 拡張機能アイコンをクリックし、「プロンプト管理」ボタンをクリック
2. 管理ページでは以下が可能：
   - 新しいプロンプトの追加
   - 既存プロンプトの編集
   - 不要なプロンプトの削除
   - プロンプトにタグを付けて分類
   - プロンプトライブラリのエクスポートでバックアップ
   - 以前のバックアップからプロンプトライブラリをインポート

## 📦 インストールガイド

### アプリストアからインストール

Chromeウェブストアにて公開中！[こちらをクリックしてダウンロード](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releasesから取得

1. [GitHub Releasesページ](https://github.com/wenyuanw/quick-prompt/releases)にアクセス
2. 最新版のビルド済みプラグインパッケージをダウンロード
3. ダウンロードしたファイルを解凍
4. 以下の説明に従いビルド済み拡張機能をインストール

### ソースコードからビルド

1. リポジトリをクローンする
   ```bash
   git clone https://github.com/wenyuanw/quick-prompt.git
   cd quick-prompt
   ```
2. 依存関係のインストール
   ```bash
   pnpm install
   ```
3. 開発と構築

   ```bash
   # 开发模式 (Chrome)
   pnpm dev
   
   # 开发模式 (Firefox)
   pnpm dev:firefox
   
   # 构建扩展 (Chrome)
   pnpm build
   
   # 构建扩展 (Firefox)
   pnpm build:firefox
   ```
### ビルド済み拡張機能のインストール

#### Chrome / Edge
1. 拡張機能管理ページを開く (`chrome://extensions` または `edge://extensions`)
2. 「デベロッパーモード」を有効にする
3. 「解凍済み拡張機能を読み込む」をクリック
4. プロジェクトの `.output/chrome-mv3/` ディレクトリを選択する

#### Firefox
1. `about:debugging` を開く
2. 「この Firefox」をクリック
3. 「一時的にアドオンを読み込む」をクリック
4. プロジェクトの `.output/firefox-mv2/` ディレクトリ内の `manifest.json` ファイルを選択する

## 📄 ライセンス

MIT

## 🤝 貢献ガイド

Pull Requests と Issues の提出を歓迎します！

1. このリポジトリを Fork する
2. 機能ブランチを作成する (`git checkout -b feature/amazing-feature`)
3. 変更をコミットする (`git commit -m 'Add some amazing feature'`)
4. ブランチにプッシュする (`git push origin feature/amazing-feature`)
5. Pull Request を作成する

## 👏 貢献者リスト

プロジェクトに貢献してくださった皆様に感謝します！

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-15

---