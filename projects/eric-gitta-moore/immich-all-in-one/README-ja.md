# Immich + cn-clip + RapidOCR + InsightFace

<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=eric-gitta-moore&project=immich-all-in-one&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>

> ~~今後 ente-io/ente への移行を計画していましたが、写真の保存に s3 が必要なためです~~
> 
> ente はやはり機能が少なすぎました
> 
> juicedata/juicefs を利用して s3 をマウントする方式に変更しました

## プロジェクト概要

本プロジェクトは [Immich](https://github.com/immich-app/immich) 写真管理システムの AI 機能拡張ソリューションです。主に以下のコンポーネントによって Immich の標準機能を拡張しています：

- **inference-gateway**：Go 言語で実装されたゲートウェイサービスで、Immich の機械学習リクエストをインテリジェントに振り分けます
- **mt-photos-ai**：Python と FastAPI ベースの AI サービスで、RapidOCR および cn-clip モデルを統合
- Immich の機能拡張（OCR テキスト認識検索、単一メディア AI データ再処理、OCR 全文ベクトルと CLIP ベクトルスコア混合によるランキング）
- PostgreSQL に zhparser 中国語分かち書き追加

## 主な機能

### 1. OCR 文字認識と検索

- RapidOCR を使用して画像内の文字を認識
- 中国語と英語の混合テキスト認識に対応
- 画像内のテキスト内容に基づく検索機能を実現

### 2. CLIP 画像ベクトル処理

- cn-clip モデルにより、より正確な中国語画像 - テキストマッチングを実現
- セマンティック検索に対応し、検索精度を向上

### 3. 単一メディア AI データ再処理

- 単一の画像／動画に対し OCR データの再生成が可能
- 単一の画像／動画に対し CLIP ベクトルデータの再生成が可能
- 認識結果が不正確な場合、手動でリフレッシュする機能を提供

## システムアーキテクチャ

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
## 组件详解

### inference-gateway

Go 言語で実装されたゲートウェイサービスで、主な役割は以下の通りです：
- Immich からの機械学習リクエストを受信
- リクエストタイプに応じて OCR および CLIP リクエストを mt-photos-ai サービスに転送
- その他の機械学習リクエスト（顔認識など）を Immich ネイティブの機械学習サービスに転送
- 認証とデータ形式の変換を処理

### mt-photos-ai

Python と FastAPI で実装された AI サービスで、以下を提供します：
- OCR 文字認識 API（RapidOCR ベース）
- CLIP ベクトル処理 API（cn-clip ベース）
- GPU アクセラレーション対応

## 部署说明

### 环境要求

- Docker および Docker Compose
- NVIDIA GPU（オプションですが、処理高速化のため推奨）
- 十分なストレージ容量

### 配置说明

1. **inference-gateway の設定**

主な環境変数：

```
IMMICH_API=http://localhost:3003  # Immich API地址
MT_PHOTOS_API=http://localhost:8060  # mt-photos-ai服务地址
MT_PHOTOS_API_KEY=mt_photos_ai_extra  # API密钥
PORT=8080  # 网关监听端口
```
2. **mt-photos-ai の設定**

主な環境変数：

```
CLIP_MODEL=ViT-B-16  # CLIP模型名称
CLIP_DOWNLOAD_ROOT=./models/clip  # 模型下载路径
DEVICE=cuda  # 或 cpu，推理设备
HTTP_PORT=8060  # 服务监听端口
```
### デプロイ手順

1. リポジトリをクローンします：

```bash
git clone https://github.com/你的用户名/immich-all-in-one.git
cd immich-all-in-one
```
2. サービスを起動します：

```bash
docker-compose up -d
```
## 使用説明

1. **Immich をカスタム ML サービスで設定する**

Immich の設定ファイルで、機械学習サービスのアドレスを inference-gateway に指定します。

```
MACHINE_LEARNING_URL=http://inference-gateway:8080
```
2. **OCR検索の使用**

- Immichの検索バーで`ocr:`プレフィックスを使ってOCR検索を行う
- 例：`ocr:発票`は画像内に「発票」という文字が含まれる写真を検索する

3. **単一メディアAIデータの再処理**

- 写真の詳細ページで、メニューオプションをクリック
- 「OCRデータを再生成」または「CLIPベクトルを再生成」を選択
- システムがその写真のAIデータを再処理します

## 開発ガイド

### inference-gateway (Go)

コンパイルと実行：

```bash
cd inference-gateway
go build
./inference-gateway
```
### mt-photos-ai (Python)

開発環境の設定：

```bash
cd mt-photos-ai
pip install -r requirements.txt
python -m app.main
```
## 许可证

本プロジェクトは MIT ライセンスのもとでオープンソース化されています。

## 謝辞

- [Immich](https://github.com/immich-app/immich) - オープンソースのセルフホスト型写真・動画バックアップソリューション
- [RapidOCR](https://github.com/RapidAI/RapidOCR) - PaddleOCR ベースのクロスプラットフォーム OCR ライブラリ
- [cn-clip](https://github.com/OFA-Sys/Chinese-CLIP) - 中国語マルチモーダルコントラスト学習事前学習モデル



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---