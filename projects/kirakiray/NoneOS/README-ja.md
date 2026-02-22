# NoneOS - ブラウザベースの軽量仮想オペレーティングシステム

[中文](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_CN.md) | [日本語](https://raw.githubusercontent.com/kirakiray/NoneOS/main/./md/README_JP.md)

## プロジェクト紹介

NoneOSは、純粋な静的ファイル構造を採用し、バックエンドサーバーのサポートなしで動作可能な革新的なブラウザベースの仮想オペレーティングシステムソリューションです。

短期目標：ブラウザベースの軽量NASシステムを作成し、デバイス間のシームレスな接続とコラボレーションを実現すること。

- [x] ブラウザベースのファイル管理のサポート
- [x] ブックマーク同期アプリケーション
- [x] ノート同期アプリケーション（Notionに類似）
- [x] ファイル転送アプリケーション（LocalSendに類似）
- [ ] ノート同期アプリケーションの再構築

## クイックスタート

公式サイトに直接アクセス：[https://os.noneos.com/](https://os.noneos.com/)

### ローカル実行
1. プロジェクトをクローンまたはダウンロードし、ローカルにnodejsがインストールされていることを確認してください。
2. 依存関係をインストール：
```bash
npm install
```
3. サーバーを起動します:
```bash
npm run static
```
1. 訪問先: `http://localhost:5559/`

## アプリケーションの作成方法

NoneOSは先進的なWebマイクロアプリケーションアーキテクチャを採用しており、各アプリケーションは強力なofa.jsフレームワーク上に構築されています。開発者は、アプリケーションディレクトリ（例: `others/hello-world.napp`）をシステムの「Apps」フォルダーにインポートするだけで、自分のアプリケーションを簡単に作成し、迅速に展開・実行できます。

現在、より詳細な開発ドキュメントを作成中です。その間、開発者は以下を参照できます:
- 公式のofa.jsドキュメントでフレームワークの機能を理解する。
- `packages/apps`ディレクトリ内のサンプルアプリケーションを開発の参考にする。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-22

---