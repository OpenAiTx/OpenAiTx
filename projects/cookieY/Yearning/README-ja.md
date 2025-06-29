<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

強力でローカルにデプロイできるプラットフォームで、DBAや開発者向けに特化したシームレスなSQL検出およびクエリアドミットを実現します。プライバシーと効率性を重視し、MYSQL監査のための直感的で安全な環境を提供します。

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ 特徴

- **AIアシスタント**: AIアシスタントがリアルタイムでSQL最適化の提案を行い、SQLパフォーマンスを向上させます。また、テキストからSQLへの変換もサポートしており、自然言語を入力するだけで最適化されたSQL文を受け取ることができます。

- **SQL監査**: 承認ワークフローと自動構文チェックを備えたSQL監査チケットを作成できます。SQL文の正確性・セキュリティ・コンプライアンスを検証します。DDL/DML操作に対してはロールバック文が自動生成され、完全な履歴ログにより追跡性を確保します。

- **クエリ監査**: ユーザークエリの監査、データソースやデータベースの制限、機微フィールドの匿名化を行います。クエリ履歴は将来の参照のために保存されます。

- **チェックルール**: 自動構文チェッカーは幅広いチェックルールをサポートしており、ほとんどの自動チェックシナリオに対応しています。

- **プライバシー重視**: Yearningはローカルデプロイ可能なオープンソースソリューションであり、データベースやSQL文のセキュリティを確保します。暗号化機構を備えており、不正アクセスがあった場合でも機微データが安全に保護されます。

- **RBAC（ロールベースアクセス制御）**: 特定の権限を持つロールの作成・管理が可能です。ユーザーロールに基づいてクエリ作業依頼、監査機能、その他機微操作へのアクセスを制限します。

> \[!TIP]
> より詳細な情報は [Yearningガイド](https://next.yearning.io) をご参照ください。


## ⚙️ インストール

[最新リリース](https://github.com/cookieY/Yearning/releases/latest) をダウンロードし、解凍してください。事前に `./config.toml` を設定しておく必要があります。

### 手動インストール

```bash
## データベースの初期化
./Yearning install

## Yearningの起動
./Yearning run

## ヘルプ
./Yearning --help
```

### 🚀 Dockerによるデプロイ
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## データベースの初期化
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## Yearningの起動
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 AIアシスタンス

AIアシスタントは大規模言語モデルを活用し、SQL最適化提案やテキストからSQLへの変換を提供します。デフォルトまたはカスタムプロンプトを利用でき、SQL文の最適化や自然言語入力のSQLクエリへの変換を通してSQLパフォーマンスを向上させます。

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 自動SQLチェッカー

自動SQLチェッカーは、事前定義されたルールや構文に対してSQL文を評価します。特定のコーディング標準、ベストプラクティス、セキュリティ要件に準拠していることを確認し、堅牢な検証レイヤーを提供します。

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 SQL構文ハイライト＆自動補完

SQL構文のハイライトや自動補完により、クエリ作成の効率が向上します。これらの機能により、SQLクエリ内のキーワード、テーブル名、カラム名、演算子などの各要素を視覚的に区別でき、クエリ構造の読みやすさと理解が向上します。

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ オーダー／クエリ記録

当プラットフォームは、ユーザーのオーダーおよびクエリ文の監査をサポートします。この機能により、データソース、データベース、機微フィールドの取扱いを含むすべてのクエリ操作を追跡・記録でき、規制遵守やクエリ履歴の追跡性を確保します。

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

これらの主な機能により、Yearningはユーザーエクスペリエンスを向上させ、SQLパフォーマンスを最適化し、データベース操作におけるコンプライアンスと追跡性を強化します。

## 🛠️ 推奨ツール

- [Spug - オープンソース軽量自動化運用プラットフォーム](https://github.com/openspug/spug)

## ☎️ お問い合わせ

ご質問は henry@yearning.io までメールでご連絡ください。
## 📋 ライセンス

YearningはAGPLライセンスの下でライセンスされています。詳細は[LICENSE](LICENSE)をご覧ください。

2024 © Henry Yee

---

Yearningを使えば、SQL監査と最適化をシンプルかつ安全、効率的に実現できます。


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---