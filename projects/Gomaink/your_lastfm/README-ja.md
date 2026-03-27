
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Gomaink&project=your_lastfm&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

**Last.fm** からスクロブルを同期し、ローカルの **SQLite** データベースに保存し、ウェブダッシュボードとして提供するコンテナ化された Node.js アプリケーションです。

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />
---

## プロジェクト

**Your LastFM** は Node.js アプリケーションであり、**Last.fm から音楽のスクロブルを自動的に同期**します。リスニング履歴をローカルの SQLite データベースに保存し、データ可視化のための Web インターフェースを提供します。

このプロジェクトは **Docker** で完全にコンテナ化されており、自動エントリーポイントを利用してデータベースの初期化とシーケンシャル実行（最初に同期、次に Web API の起動）を行います。また、**PM2** をコンテナ内のプロセスマネージャーとして利用し、Web サービスの継続的な稼働と堅牢性を確保します。

## 特徴
### インタラクティブな Web ダッシュボード

- 音楽アクティビティを可視化するクリーンでモダンな Web インターフェース。

### 自動 Last.fm スクロブル同期

- Last.fm からリスニング履歴（スクロブル）を定期的に取得・保存します。
- 手動操作なしで常にデータが最新の状態に保たれます。

### ローカル音楽履歴データベース

- すべてのスクロブルをローカルの SQLite データベースに永続化します。
- 高速なクエリや過去のリスニングデータへのオフラインアクセスが可能です。

### 最近のスクロブル表示

- 最新の再生トラックを表示します。
- トラック・アルバム・アーティストのためのスマートな画像フォールバックロジック。

### フレンド比較（互換性ビュー）

- Last.fm フレンドと音楽の好みを比較できます。
- 互換性レベル（非常に低い → スーパー）を表示します。
- 共通のトップアーティスト、アルバム、トラックを表示します。
- 実際のリスニングデータに基づいて互換性を計算・正規化します。

### シェア可能なミュージックカード

- リスニングデータに基づいて動的な画像を生成します。
- フィード投稿や Instagram ストーリー（9:16）用に最適化されたレイアウト。

- サーバーサイド画像レンダリングのために node-canvas を使用して構築されています。

## 前提条件

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## インストール

### `.env` ファイルを作成する

```env
LASTFM_API_KEY=your_lastfm_api_key
LASTFM_USERNAME=your_lastfm_username
```

Last.fm: APIキーを取得するには、[こちら](https://www.last.fm/api/account/create)でAPIアカウントを作成してください。

### Docker Compose

```yml
services:
  your-lastfm:
    image: gomaink/your-lastfm
    container_name: your-lastfm
    ports:
      - "1533:1533"
    env_file:
      - .env
    volumes:
      - ./data:/app/data
    restart: unless-stopped
```

ターミナルで：  
`docker compose up -d`  

その後アクセス：
```
http://localhost:1533
```

（または `localhost` をサーバーのIPに置き換えてください）

## ライセンス

このプロジェクトはMITライセンスの下でライセンスされています。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-27

---