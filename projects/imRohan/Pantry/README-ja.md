![preview](https://github.com/user-attachments/assets/e6762b5a-479a-4261-8e5c-e6b5d04344c5)
# Pantry
[![build](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml/badge.svg)](https://github.com/imRohan/Pantry/actions/workflows/continuous_integration.yml)
![Maintainability](https://api.codeclimate.com/v1/badges/8f1460270ced1f60744c/maintainability)
![Issues Open](https://img.shields.io/github/issues/imrohan/Pantry?&logo=github)
![Issues Closed](https://img.shields.io/github/issues-closed-raw/imrohan/pantry?color=green&logo=github)
[![Coverage Status](https://coveralls.io/repos/github/imRohan/Pantry/badge.svg?branch=master)](https://coveralls.io/github/imRohan/Pantry?branch=master)

[Pantry](https://getpantry.cloud/) は、小規模プロジェクト向けの消耗品データストレージを提供する無料サービスです。データは、ユーザーとあなたが必要とする限り安全に保存され、一定期間使用されなかった場合に削除されます。RESTful API を使って JSON オブジェクトを投稿するだけで、あとは私たちが処理します。

これは、より小規模なプロジェクトのためのシンプルで再利用可能なストレージソリューションを提供するために構築されました。開発者による開発者のためのもので、必要なときに利用でき、次のプロジェクトの迅速なプロトタイピングを支援します。

## 開発

#### リポジトリをクローン
`git clone https://github.com/imRohan/Pantry.git && cd Pantry`

#### 依存関係のインストール
`yarn`

#### Redis のインストール
マシンに Redis (v^6.2.0) をインストールし、デフォルト設定でサーバーを起動しておく必要があります

#### `.env` と `config.ts` の作成・編集
`cp env.sample .env`
`cp src/app/config.dev.ts src/app/config.ts`

#### フロントエンドアセットのビルドとサーバーの起動（デフォルトポート3000）

`yarn run dev`

#### サンプルHTMLページを開く

お好きなブラウザで `http://localhost:3000/` を開いてください



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-27

---