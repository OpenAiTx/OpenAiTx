![Ogresアプリのスクリーンショット](https://raw.githubusercontent.com/samcf/ogres/main/site/web/media/ogres-media-collection.webp)

## 特徴

[ogres.app](https://ogres.app) はブラウザで動作し、友達と遊べる無料のオープンソース仮想テーブルトップです。今日利用可能なより包括的なツールの非常に軽量な代替を目指しています。限られたコア機能セットは、ダンジョンマスターが最も重要な必需品だけで素早く遭遇や冒険を設定できるよう設計されています。

- ゲーム準備をすぐに開始；登録や広告なし
- 友達とのオンライン協力セッションを開始
- 複数のシーンを同時に準備・管理
- スムーズな遭遇のための内蔵イニシアティブトラッカー
- スマホやタブレットに対応したレスポンシブデザイン
- 他のゲームシステムでも使いやすい
- ...そしてさらに多くの機能を計画中！

## 貢献

バグ修正や機能拡張に興味がありますか？**初心者歓迎**とラベル付けされた課題を探し、その作業をしたい旨コメントしてください。以下はローカル開発環境を始めるための手順（開発者向け）です。

> [!IMPORTANT]
> `node`、`npm`、`clojure`のインストールが必要です。

```sh
#!/bin/sh

# copy the repository
git clone git@github.com:samcf/ogres.git

# install dependencies and start the local web server
# by default opens at http://localhost:8080
npm install
npm start

# run the process that bundles CSS files
npm run style

# optionally, start the application server necessary
# for hosting online sessions
clojure -M -m ogres.server.core 5000
```

## 自分のサーバーを運用する

このアプリケーションのインスタンスをDockerを使って自分で運用できます。詳細は[wikiドキュメント](https://github.com/samcf/ogres/wiki/Docker-Usage)を参照してください。以下のコマンドでアプリケーションをインストールして実行します。

```sh
#!/bin/sh
docker compose up -d
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-25

---