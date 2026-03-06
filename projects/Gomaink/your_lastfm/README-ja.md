[![Status](https://img.shields.io/badge/status-active-brightgreen)](https://github.com/seuusuario/wakeonweb)
[![License](https://img.shields.io/badge/license-MIT-blue)](LICENSE)

# Your LastFM

コンテナ化されたNode.jsアプリケーションで、**Last.fm**からスコロブルを同期し、ローカルの**SQLite**データベースに保存し、ウェブダッシュボードを提供します。

<img width="1718" height="1066" alt="image" src="https://github.com/user-attachments/assets/97d5a9f1-b39a-42ea-9acf-2b4546426a11" />

---

## プロジェクト

**Your LastFM**は、Last.fmからの音楽スコロブルを**自動的に同期**するために設計されたNode.jsアプリケーションです。リスニング履歴をローカルのSQLiteデータベースに保存し、データの可視化用のウェブインターフェースを提供します。

本プロジェクトは完全に**Docker**でコンテナ化されており、データベースの初期化および順次実行（まず同期、その後Web API起動）を行う自動エントリポイントを使用しています。また、コンテナ内で**PM2**をプロセスマネージャーとして利用し、ウェブサービスの継続的な稼働と耐障害性を確保しています。

## 機能
### インタラクティブなウェブダッシュボード

- 音楽活動を可視化するクリーンでモダンなウェブインターフェース。

### 自動Last.fmスコロブル同期

- 定期的にLast.fmからリスニング履歴（スコロブル）を取得し保存。
- 手動介入なしで常にデータを最新状態に保ちます。

### ローカル音楽履歴データベース

- すべてのスコロブルをローカルSQLiteデータベースに保存。
- 高速なクエリとオフラインでの履歴データアクセスを可能にします。

### 最近のスコロブル表示

- 最新の再生トラックを表示。
- トラック、アルバム、アーティストのスマートな画像フォールバックロジック。

### フレンド比較（互換性ビュー）

- Last.fmのフレンドと音楽の趣味を比較。
- 互換性レベルを表示（非常に低い → 超高）。
- 共通のトップアーティスト、アルバム、トラックを表示。
- 実際のリスニングデータに基づいて互換性を計算し正規化。

### 共有可能なミュージックカード

- リスニングデータに基づいた動的画像を生成。
- フィード投稿やインスタグラムストーリー（9:16）用に最適化されたレイアウト。
- サーバーサイド画像レンダリングに node-canvas を使用して構築。

## 前提条件

* [Docker](https://docs.docker.com/get-docker/)
* [Docker Compose](https://docs.docker.com/compose/install/)

## インストール

### `.env` ファイルの作成

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-06

---