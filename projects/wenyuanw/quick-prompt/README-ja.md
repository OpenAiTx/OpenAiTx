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

強力なブラウザ拡張機能で、プロンプト管理と素早い入力に特化しています。ユーザーがプロンプトライブラリを作成・管理・整理し、あらゆるウェブページの入力欄でプリセットされたプロンプトをすぐ挿入できるようにし、業務効率を向上させます。

> ブラウザ拡張機能はウェブ上のみ利用可能なため、同じ機能を持つ [Raycast プラグイン](https://github.com/wenyuanw/quick-prompt-raycast)もオープンソース化しました。拡張機能と互換性のあるデータ形式で、同じJSONデータを使ってシームレスに移行できます。

## ✨ 機能特徴

- 📚 **プロンプト管理**：プロンプトライブラリの作成・編集・管理が簡単
- 🚀 **クイック入力**：任意のウェブ入力欄で `/p` でプロンプトセレクターを素早く呼び出し
- ⌨️ ショートカットキーでプロンプトセレクターを開く＆選択テキストをプロンプトとして保存可能
- 📑 右クリックメニューから選択テキストを直接プロンプトとして保存
- 🎯 カスタムプロンプトに対応：カテゴリ、タイトル、内容、タグ、変数を自由に設定
- 🧑‍💻 **変数サポート**：プロンプト内で `{{変数名}}` 形式の変数が使え、利用時に具体値を入力可能
- 💾 **データバックアップ**：プロンプトライブラリのエクスポート・インポートでデバイス間移行やバックアップが容易
- 🔗 **Notion連携**：プロンプトライブラリをNotionデータベースと同期可能
- 🔍 プロンプトの検索・フィルター機能あり
- 🌙 システムのダーク/ライトテーマに自動対応

## ⚠️ 既知の問題

- 豆包（doubao.com）のウェブページでは、`/p` でプロンプトセレクターを呼び出した後、一部の入力欄で`/p`が消えない問題があります。でもご安心を！私と相棒のCursorが日夜解決策を模索中です。できるだけ早く修正します！

## 🚀 使い方

1. **クイック呼び出し**：どのウェブページのテキスト入力欄でも `/p` と入力してプロンプトセレクターを起動
2. **ショートカットでセレクター起動**：`Ctrl+Shift+P`（Windows/Linux）または `Command+Shift+P`（macOS）でプロンプトセレクターを開く
3. **プロンプト選択**：ポップアップしたセレクターから使いたいプロンプトをクリックすると、現在の入力欄へ自動挿入
4. **クイックプロンプト保存**：任意のテキストを選択し、`Ctrl+Shift+S`（Windows/Linux）または `Command+Shift+S`（macOS）で素早くプロンプトとして保存
5. **右クリック保存**：テキストを選択し、右クリックして「このプロンプトを保存」を選択で、選択内容をプロンプトとして保存
6. **プロンプトエクスポート**：管理ページで「エクスポート」ボタンをクリックし、すべてのプロンプトをJSONファイルでローカルに保存
7. **プロンプトインポート**：管理ページで「インポート」ボタンを押し、ローカルのJSONファイルからプロンプトを取り込み（既存プロンプトのマージ・上書きに対応）

## 📸 インターフェースプレビュー

Quick Promptは直感的で使いやすいUIを提供し、プロンプトの管理と利用を簡単にします。

### プロンプトセレクター

![プロンプトセレクター](https://github.com/user-attachments/assets/41b9897c-d701-4ff0-97f7-2f1754f570a8)

![プロンプトセレクター](https://github.com/user-attachments/assets/22d9d30c-b4c3-4e34-a0a0-8ef51e2cb942)

`/p` ショートコマンドやショートカットキーで、どの入力欄でも素早くプロンプトセレクターを呼び出せ、必要なプロンプトを楽に選んで挿入できます。

### プロンプト管理ページ

![プロンプト管理](https://github.com/user-attachments/assets/371ae51e-1cee-4a66-a2a5-cca017396872)

管理ページでは、新規プロンプトの作成、既存プロンプトの編集、タグ追加やカテゴリ管理が可能です。UIはシンプルで操作も簡単です。

### 右クリック保存

![右クリック保存](https://github.com/user-attachments/assets/17fc3bfd-3fa4-4b0b-ae1a-5cfd0b62be2e)

ウェブページ上の任意のテキストを選択し、右クリックだけで素早くプロンプト保存。作業効率アップに貢献します。

### プロンプト変数入力

![プロンプト変数ポップアップ](https://github.com/user-attachments/assets/c91c1156-983a-454d-aad0-5698b0291b9b)

プロンプトは変数設定に対応し、選択後にポップアップで該当変数値を入力できます。

## ⚙️ カスタム設定

1. 拡張アイコンをクリックし、「プロンプト管理」ボタンをクリック
2. 管理ページでは、以下のことができます:
   - 新しいプロンプトを追加する
   - 既存のプロンプトを編集する
   - 不要なプロンプトを削除する
   - プロンプトにタグを付けて分類する
   - プロンプトライブラリをエクスポートしてバックアップする
   - 以前にバックアップしたプロンプトライブラリをインポートする

## 📦 インストールガイド

### アプリストアからのインストール

Chromeウェブストアで公開中です！[こちらをクリックしてダウンロード＆インストール](https://chromewebstore.google.com/detail/quick-prompt/hnjamiaoicaepbkhdoknhhcedjdocpkd)

### GitHub Releases から入手

1. [GitHub Releases ページ](https://github.com/wenyuanw/quick-prompt/releases)にアクセス
2. 最新バージョンのビルド済みプラグインパッケージをダウンロード
3. ダウンロードしたファイルを解凍
4. 下記の手順に従ってビルド済み拡張機能をインストール

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---