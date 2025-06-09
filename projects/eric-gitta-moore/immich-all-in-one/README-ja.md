# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~今後は ente-io/ente へ移行予定でしたが、写真の保存先として s3 が必要なためです~~
> 
> ente はまだ機能が少なすぎました
> 
> juicedata/juicefs を使って s3 をマウントする方式に変更

## プロジェクト概要

本プロジェクトは [Immich](https://github.com/immich-app/immich) 写真管理システムの AI 機能強化ソリューションです。主に以下のコンポーネントによって Immich のネイティブ機能を拡張しています：

- **inference-gateway**：Go 言語で実装されたゲートウェイサービス。Immich の機械学習リクエストをインテリジェントに振り分ける役割を担います
- **mt-photos-ai**：Python と FastAPI ベースの AI サービス。RapidOCR と cn-clip モデルを統合
- Immich の機能拡張：OCR テキスト認識検索や単一メディアの AI データ再処理、OCR 全文ベクトルと CLIP ベクトルのスコア混合ソート
- PostgreSQL に zhparser による中国語分かち書きを追加

## 主な機能

### 1. OCR 文字認識と検索

- RapidOCR を用いて画像中の文字を認識
- 中国語・英語混合テキスト認識に対応
- 画像文字内容に基づく検索機能を実現

### 2. CLIP 画像ベクトル処理

- cn-clip モデルにより、より正確な中国語画像 - テキストマッチングを実現
- セマンティック検索対応、検索精度を向上

### 3. 単一メディア AI データ再処理

- 単一画像・動画の OCR データ再生成に対応
- 単一画像・動画の CLIP ベクトルデータ再生成に対応
- 認識結果が不正確な場合、手動で再処理可能

## システム構成

```
┌─────────────┐      ┌──────────────────┐      ┌───────────────┐
│             │      │                  │      │               │
│   Immich    │─────▶│ inference-gateway│─────▶│  Immich ML    │
│   Server    │      │    (Go网关)      │      │   Server      │
│             │      │                  │      │               │
└─────────────┘      └──────────────────┘      └───────────────┘
                              │
                              │ OCR/CLIP请求
                              ▼
                     ┌──────────────────┐
                     │                  │
                     │   mt-photos-ai   │
                     │  (Python服务)    │
                     │                  │
                     └──────────────────┘
```

## コンポーネント詳細

### inference-gateway

Go 言語で実装されたゲートウェイサービス。主な役割：
- Immich の機械学習リクエストを受信
- リクエスト種別に応じて OCR・CLIP リクエストを mt-photos-ai サービスへ転送
- その他（顔認識等）のリクエストは Immich ネイティブ機械学習サービスへ転送
- 認証やデータフォーマット変換を処理

### mt-photos-ai

Python + FastAPI で実装された AI サービス。提供機能：
- OCR 文字認識 API（RapidOCR ベース）
- CLIP ベクトル処理 API（cn-clip ベース）
- GPU アクセラレーション対応

## デプロイ方法

### 動作環境

- Docker および Docker Compose
- NVIDIA GPU（オプションだが推奨、処理の高速化用）
- 十分なストレージ容量

### 設定方法

1. **inference-gateway の設定**

主な環境変数：
```
IMMICH_API=http://localhost:3003  # Immich API アドレス
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai サービスアドレス
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API キー
PORT=8080  # ゲートウェイ待ち受けポート
```

2. **mt-photos-ai の設定**

主な環境変数：
```
CLIP_MODEL=ViT-B-16  # CLIP モデル名
CLIP_DOWNLOAD_ROOT=./models/clip  # モデルダウンロードパス
DEVICE=cuda  # または cpu、推論デバイス
HTTP_PORT=8060  # サービス待ち受けポート
```

### デプロイ手順

1. リポジトリをクローン：
```bash
git clone https://github.com/あなたのユーザー名/immich-all-in-one.git
cd immich-all-in-one
```

2. サービスを起動：
```bash
docker-compose up -d
```

## 利用方法

1. **Immich でカスタム ML サービスを指定**

Immich の設定ファイルで、機械学習サービスのアドレスを inference-gateway に設定します：
```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```

2. **OCR 検索の利用**

- Immich の検索バーで `ocr:` プレフィックスを使って OCR 検索
- 例：`ocr:発票` は画像内に「発票」と書かれた写真を検索します

3. **単一メディア AI データの再処理**

- 写真詳細ページでメニューから選択
- 「OCR データ再生成」または「CLIP ベクトル再生成」を選択
- システムが該当写真の AI データを再処理します

## 開発ガイド

### inference-gateway (Go)

ビルド・実行：
```bash
cd inference-gateway
go build
./inference-gateway
```

### mt-photos-ai (Python)

開発環境セットアップ：
```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```

## ライセンス

本プロジェクトは MIT ライセンスのもとで公開されています。

## 謝辞

- [Immich](https://github.com/immich-app/immich) - オープンソースのセルフホスト写真・動画バックアップソリューション
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR ベースのクロスプラットフォーム OCR ライブラリ
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 中国語マルチモーダルコントラスト学習事前学習モデル

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---