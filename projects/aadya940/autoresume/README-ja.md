<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>オープンソースの履歴書作成ツール。リンクを貼り付けて手動で編集し、AIが履歴書のブラッシュアップ、更新、カスタマイズをお手伝いします。</b>
</p>

---

### 使い方

[Mediumブログリンク](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

このブログは、ユーザーインターフェースおよび使用テンプレートに関しては古くなっています。

## 特徴

- <b>簡単リンクインポート：</b> ウェブサイトからリンクを貼り付け、すばやくPDF履歴書を作成。
- <b>手動エディタ搭載：</b> コードエディタで履歴書をゼロから作成・微調整可能。
- <b>スマートサジェスト：</b> フィードバックや新しいリンクを共有すると、スマート編集で履歴書を洗練・更新できます。
- <b>求人に合わせて調整：</b> 求人情報を貼り付けると、履歴書を合わせるための推奨事項が得られます。
- <b>LaTeX品質：</b> すべての履歴書はLaTeXで生成され、クリーンでプロフェッショナルなレイアウトを実現。
- <b>即時プレビュー：</b> 履歴書をPDFとしてリアルタイムで表示。
- <b>簡単リセット：</b> ワンクリックで履歴書をクリアして再スタート。
- <b>ローカル動作：</b> Dockerを使用して完全にローカルで動作。

---

## はじめに

### 必要条件
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### セットアップ

1. リポジトリをクローンします:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. アプリをビルドして起動します:
   ```bash
   docker compose up --build
   ```
3. アプリにアクセスします:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## 使い方

1. ブラウザでautoResumeを開きます。
2. :gear: アイコンをクリックし、[GOOGLE API KEY](https://aistudio.google.com/)とメールアドレスを貼り付けます。
3. プロフェッショナル情報（例：Github、個人ウェブサイトなど）のリンクを貼り付けます。
4. オプションで、追加のカスタマイズのためにフィードバックや求人情報リンクを追加できます。
5. <b>Generate Resume</b> をクリックし、あとはAIにお任せ！

---

## ライセンス

このプロジェクトはApache 2.0ライセンスの下で提供されています。

## コントリビューションガイド

### フロントエンド
- Reactコンポーネントは `frontend/src/components/` フォルダで実装してください
- コンポーネント実装にはChakra UIを使用しています
- 作成したコンポーネントは `frontend/src/App.jsx` でインポートして使用してください

### バックエンド
- APIルートは `backend/src/routes/` ディレクトリで実装してください
- AI機能は `backend/src/ai/` ディレクトリで追加してください
- Pythonコードには `black` コードフォーマッタを使用します
- ルートハンドラはシンプルにし、ロジックは分離してください

### 一般的なガイドライン
- 機能追加や修正は新しいブランチで作業: `git checkout -b your-branch-name`
- 明確なコミットメッセージを書く
- PR提出前に変更内容をテストする

### 変更の提出
1. プルリクエストを作成
2. PR説明に以下を含めてください:
   - 変更内容
   - 変更理由
   - 関連するスクリーンショットやテスト結果
   - 破壊的変更や必要な移行手順

あなたの貢献に感謝し、できるだけ早くPRをレビューします！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---