<p align="center">
  <a href="https://www.jukeboxhq.com">
    <img height="500" src="https://raw.githubusercontent.com/skeptrunedev/jukebox/main/frontend/public/opengraph-image.jpg" alt="Trieve ロゴ">
  </a>
</p>

<p align="center">
  <a href="https://hub.docker.com/r/skeptrune/jukebox-server" style="text-decoration: none;">
    <img src="https://img.shields.io/docker/pulls/skeptrune/jukebox-server?style=flat-square" alt="Docker プル数" />
  </a>
  <a href="https://github.com/skeptrunedev/jukebox/stargazers" style="text-decoration: none;">
    <img src="https://img.shields.io/github/stars/skeptrunedev/jukebox?style=flat-square" alt="GitHub スター数" />
  </a>
  <a href="https://x.com/skeptrune" style="text-decoration: none;">
    <img src="https://img.shields.io/badge/follow%20on-x.com-1da1f2?logo=x&style=flat-square" alt="X（Twitter）でフォロー" />
  </a>
</p>

---
# あらゆるデバイスをコラボレーション・ジュークボックスに

**Jukebox** は、友人と一緒に瞬時に共有音楽プレイリストを作成できます。アプリ不要、ログイン不要、広告なし。ボックスを作成し、リンクを共有して、一緒に曲を追加するだけ。パーティー、ドライブ、グループでの集まりに最適です！

- 🌐 **Spotify コラボプレイリストのオープンソース代替**
- 🕵️ **アカウント不要**：匿名で利用可能—サインアップやメール登録不要
- ✨ **リンクを共有して一緒に曲を追加**：誰でもリアルタイムで参加可能
- 🚀 **アプリのダウンロード不要**：どのデバイスでもブラウザで動作
- 🎵 **YouTube連携**：ほぼすべての曲を即座に検索・再生
- 📱 **モバイル対応**：スマートフォン、タブレット、デスクトップに最適化
- ⚖️ **公平なキューイング**：全員に順番が回る自動並び替え
- 🆓 **完全無料、広告なし**

---

## 今すぐ試す

1. **ジュークボックスを作成**：ホームページにアクセスして新しいボックスを作成
2. **リンクを共有**：招待リンクを友達に送信
3. **曲を追加**：YouTubeで検索または手動で曲を追加
4. **音楽を再生**：内蔵プレイヤーで一緒にストリーミング

---
## 機能

- コラボレーションプレイリスト：一緒に曲を追加、キュー、再生が可能
- 匿名利用：ログインやアカウント不要
- YouTube検索＆再生：膨大な音楽ライブラリにアクセス
- モバイルファースト、レスポンシブUI
- オープンソース（MITライセンス）
- Dockerによる簡単デプロイ

### Docker Composeによるデプロイ

全サービスを起動：

```bash
docker-compose up -d
```

イメージ更新後、ダウンタイムゼロでサービスを再デプロイ：

```bash
bash ./redeploy.sh
```
## はじめに

### 必要条件

- Node.js 16以上
- npm または yarn
- YouTube Data API v3 キー（Googleから無料で取得可能）

### YouTube API セットアップ

1. [Google Cloud Console](https://console.cloud.google.com/) にアクセス
2. 新しいプロジェクトを作成するか、既存のプロジェクトを選択
3. **YouTube Data API v3** を有効化
4. 認証情報（APIキー）を作成
5. APIキーをコピー

### インストール
```bash
# リポジトリをクローン
git clone <your-repo-url>
cd jukebox

# サーバーの依存関係をインストール
cd server
yarn install

# フロントエンドの依存関係をインストール
cd ../frontend
yarn install

# 環境変数を設定
cd ../server
cp .env.example .env
# .env を編集して YouTube API キーを追加

# データベースマイグレーションを実行
```
yarn migrate

# 開発サーバーの起動
# バックエンド:
cd server
yarn dev
# ワーカー:
cd server
yarn dev:worker
# フロントエンド（新しいターミナルで）:
cd frontend
yarn dev
```

---

## ライセンス

MIT

---

## 貢献とフィードバック

- [GitHub](https://github.com/skeptrunedev/jukebox)でイシューまたはプルリクエストを作成してください
- 機能リクエストは？ [@skeptrune（X（Twitter））](https://twitter.com/skeptrune) へDMしてください

---

## 変更履歴

最新のアップデートや機能については、[変更履歴](https://jukebox.skeptrune.com#changelog)をご覧ください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-10

---