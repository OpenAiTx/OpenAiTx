# BoostServerTech チャット

このリポジトリは、C++で書かれたチャットアプリケーションのコードを保持しています。

完全なドキュメントは[こちら](https://anarthal.github.io/servertech-chat/)をご覧ください。

| ビルド                                                                                            | ドキュメント                                                                                                                                    | ライブサーバー                   |
| -------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------- | ------------------------------- |
| ![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/build.yml/badge.svg) | [![Build Status](https://github.com/anarthal/servertech-chat/actions/workflows/doc.yml/badge.svg)](https://anarthal.github.io/servertech-chat/) | [試してみる！](http://16.171.43.27/) |

## BoostServerTech プロジェクトについて

これは[BoostServerTech プロジェクト群](https://docs.google.com/document/d/1ZQrod1crs8EaNLLqSYIRMacwR3Rv0hC5l-gfL-jOp2M)の最初のプロジェクトであり、
C++とBoostを使ったサーバーサイドコードの利用例を示すプロジェクトのコレクションです。

## アーキテクチャ

サーバーはBoost.Beastをベースにしており、非同期（C++20コルーチン）かつシングルスレッドで動作します。ビルドにはC++20が必要です。永続化にはRedisとMySQLを使用しています。

クライアントはウェブベースでNext.jsを使用しています。サーバーとはWebSocketで通信します。

アーキテクチャの詳細は
[ドキュメントのこのセクション](https://anarthal.github.io/servertech-chat/01-architecture.html)でご覧いただけます。

## ローカル開発

リポジトリのルートで以下のコマンドを実行することで、Docker Composeを使ってローカルホストでチャットアプリケーションをすぐに起動できます：





```
docker compose up --build
```

または、従来の開発環境のセットアップ方法については
[こちら](https://anarthal.github.io/servertech-chat/02-local-dev.html)をご覧ください。

## 数分でライブ公開

このプロジェクトには、コードを数分でサーバーにデプロイできるCI/CDパイプラインが備わっています。  
必要なのはSSHが有効なLinuxサーバー、またはAWSアカウントだけです。  
詳細は[こちら](https://anarthal.github.io/servertech-chat/03-fork-modify-deploy.html)で確認できます。

## 貢献したいですか？

[cpplang Slack](https://cpplang.slack.com/archives/C06BRML5EFK)でメッセージをお送りください！  
貢献者を大歓迎します！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-27

---