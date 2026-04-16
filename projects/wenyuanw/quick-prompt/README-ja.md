# クイックプロンプト

<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wenyuanw&project=quick-prompt&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<p align="center">
  <img src="https://raw.githubusercontent.com/wenyuanw/quick-prompt/main/./assets/icon.png" alt="Quick Prompt Logo" width="128" style="background: transparent;">
</p>

強力なブラウザ拡張機能で、プロンプト管理と迅速な入力に特化しています。ユーザーがプロンプトライブラリを作成・管理・整理し、任意のウェブページの入力欄にプリセットされたプロンプト内容を素早く挿入できるため、作業効率を向上させます。

> ブラウザ拡張機能はウェブ上でのみ使用可能なため、同等の機能を持つ [Raycast プラグイン](https://github.com/wenyuanw/quick-prompt-raycast) をオープンソース化しました。ブラウザ拡張機能とデータ形式互換で、同じ JSON データによりシームレスに移行可能です。

## ✨ 機能特長

- 📚 **プロンプト管理**：プロンプトライブラリの作成、編集、管理が簡単にできます
- 🚀 **高速入力**：任意のウェブページの入力欄で `/p` を入力するとプロンプトセレクターを素早く起動
- ⌨️ ショートカットキーでプロンプトセレクターの起動＆選択テキストをプロンプトとして保存可能
- 📑 右クリックメニューから選択したテキストを直接プロンプトとして保存可能
- 🎯 カテゴリ、タイトル、内容、タグ、変数などカスタムプロンプトをサポート
- 🧑‍💻 **変数サポート**：プロンプト内で `{{変数名}}` 形式の変数が利用でき、使用時に値を入力可能
- 💾 **データバックアップ**：プロンプトライブラリのエクスポート・インポートに対応し、デバイス間移行やバックアップが簡単
- 🔗 **クラウド同期**：プロンプトライブラリを Notion データベースまたは Gitee/GitHub Gist と同期可能
- 🔍 プロンプトの検索・フィルタ機能に対応
- 🌙 システムのライト・ダークテーマに自動対応

## 🚀 使い方

1. **クイック起動**：任意のウェブページのテキスト入力欄で `/p` を入力しプロンプトセレクターを起動
2. **ショートカットでセレクター起動**：`Ctrl+Shift+P`（Windows/Linux）または `Command+Shift+P`（macOS）でプロンプトセレクターを開く
3. **プロンプトを選択**：表示されたセレクターから必要なプロンプトをクリックし、現在の入力欄に自動挿入
4. **クイック保存**：任意のテキストを選択後、`Ctrl+Shift+S`（Windows/Linux）または `Command+Shift+S`（macOS）で素早くプロンプトとして保存
5. **右クリックメニューで保存**：任意のテキスト選択後、右クリックして「このプロンプトを保存」を選択し内容をプロンプトとして保存
6. **プロンプトライブラリエクスポート**：管理ページの「エクスポート」ボタンで全プロンプトをJSONファイルとしてローカル保存
7. **プロンプトライブラリインポート**：管理ページの「インポート」ボタンでローカルJSONファイルからプロンプトをインポート（マージまたは上書き可能）

## 📸 インターフェースプレビュー

Quick Prompt は直感的で使いやすいユーザーインターフェースを提供し、プロンプトの管理と利用が簡単です。

### プロンプトセレクター

![プロンプトセレクター](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![プロンプトセレクター](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` クイックコマンドやショートカットキーでどんな入力欄でも素早くプロンプトセレクターを呼び出し、必要なプロンプトを簡単に選んで挿入できます。

### プロンプト管理ページ

![プロンプト管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

管理ページでは新しいプロンプトの作成、既存プロンプトの編集、タグ追加やカテゴリ管理が可能です。画面はシンプルで操作も簡単です。

### 右クリックメニューで保存

![右クリックメニューで保存](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

ウェブページ上の任意のテキストを選択し、右クリックするだけで素早くプロンプトとして保存でき、作業効率が向上します。

### プロンプト変数入力

![プロンプト変数ポップアップ](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

プロンプトは変数の設定に対応しており、選択後にポップアップで対応する変数値を入力します。

## ⚙️ カスタム設定

1. 拡張機能のアイコンをクリックし、「プロンプト管理」ボタンをクリック
2. 管理ページでは、以下の操作が可能です:
   - 新しいプロンプトの追加
   - 既存プロンプトの編集
   - 不要なプロンプトの削除
   - プロンプトにタグを追加して分類
   - プロンプトライブラリをエクスポートしてバックアップ
   - 以前バックアップしたプロンプトライブラリのインポート

## 📦 インストールガイド

### ストアからインストール

現在Chromeウェブストアで公開中！[こちらをクリックしてダウンロード＆インストール](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releases から入手

1. [GitHub Releases ページ](https://github.com/wenyuanw/quick-prompt/releases)にアクセス
2. 最新バージョンのビルド済み拡張パックをダウンロード
3. ダウンロードしたファイルを解凍
4. 下記の説明に従ってビルド済み拡張機能をインストール

### ソースコードからビルド

1. リポジトリをクローン
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

### Build済み拡張機能のインストール

#### Chrome / Edge
1. 拡張機能管理ページを開く（`chrome://extensions` または `edge://extensions`）
2. 「デベロッパーモード」を有効にする
3. 「パッケージ化されていない拡張機能を読み込む」をクリック
4. プロジェクトの `.output/chrome-mv3/` ディレクトリを選択

#### Firefox
1. `about:debugging` を開く
2. 「この Firefox」をクリック
3. 「一時的にアドオンを読み込む」をクリック
4. プロジェクトの `.output/firefox-mv2/` ディレクトリ内の `manifest.json` ファイルを選択

## 📄 ライセンス

MIT

## 🤝 貢献ガイド

Pull Request や Issue の提出を歓迎します！

1. このリポジトリをフォークする
2. 機能ブランチを作成する（`git checkout -b feature/amazing-feature`）
3. 変更をコミットする（`git commit -m 'Add some amazing feature'`）
4. ブランチにプッシュする（`git push origin feature/amazing-feature`）
5. Pull Request を作成する

## 👏 貢献者一覧

プロジェクトに貢献してくださった開発者の皆様に感謝します！

<a href="https://github.com/wenyuanw/quick-prompt/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=wenyuanw/quick-prompt" />
</a>


## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=wenyuanw/quick-prompt&type=Date)](https://www.star-history.com/#wenyuanw/quick-prompt&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-16

---