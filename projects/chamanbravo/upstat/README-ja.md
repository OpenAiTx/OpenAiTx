<div align="center" width="100%">
    <img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/upstat.png" width="128" alt="" />
</div>

# Upstat

> シンプルで使いやすいセルフホスト型ステータス監視ツール

![](https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/dashboard.png)

## 💻 ライブデモ

お試しください。

デモサーバー（場所：シンガポール）：[https://demo.upstat.com](https://upstat.chamanbudhathoki.com.np/)

ユーザー名: `demo`
パスワード: `demodemo`

## ⭐ 特徴

機能はまだ必要ですが、現状では...

- HTTP(s) の稼働時間監視
- ステータスとレイテンシチャート
- Discordによる通知
- 60秒間隔
- 洗練された、反応の良い、高速なUI/UX
- 複数のステータスページ
- 特定ドメインへのステータスページのマッピング
- Pingチャート
- 証明書情報
- PWA
- Sqlite & Postgres データベース対応

そして、さらに多数の小さな機能が追加予定です。

## 🔧 インストール方法

### 🐳 Docker

Sqlite用に

```bash
curl https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose-sqlite.yml -o docker-compose.yml
docker compose up
```

Postgres用  

```bash
curl -O https://raw.githubusercontent.com/chamanbravo/upstat/main/docker-compose.yml
docker compose up
```

Upstat は現在 http://localhost:3000 で実行されています

> [!IMPORTANT]
> デプロイする前に環境変数の値を必ず変更してください。

### 💪🏻 Dockerを使わない場合

必要条件：

- Node.js 14 / 16 / 18 / 20.4
- npm 9
- Golang 1.21+
- Postgres（オプション）

```shell
cp .sample.env .env
```

```shell
air
cd web && npm run dev
```

## 技術スタック

- React
- Shadcn
- Golang
- Postgres/Sqlite

## 🙌 貢献について

貢献を歓迎します！貢献こそがオープンソースコミュニティを学び、刺激を受け、創造する素晴らしい場所にしています。あなたの貢献は**非常に感謝されます**。

もし改善案があれば、リポジトリをフォークして変更を加え、プルリクエストを作成してください。または「enhancement」タグを付けてIssueを開くだけでも構いません。
プロジェクトにスターを付けるのもお忘れなく！改めてありがとうございます！

1. プロジェクトをフォークする
2. フィーチャーブランチを作成する (`git checkout -b feature/AmazingFeature`)
3. 変更をコミットする (`git commit -m 'Add some AmazingFeature'`)
4. ブランチをプッシュする (`git push origin feature/AmazingFeature`)
5. プルリクエストを開く

## 貢献者

<a href="https://github.com/chamanbravo/upstat/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=chamanbravo/upstat" />
</a>

## 📄 ライセンス

本プロジェクトは[MITライセンス](https://opensource.org/license/mit/)の下でライセンスされています。

## 🖼 追加スクリーンショット

モニター作成画面

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/create.png" width="512" alt="" />

モニターページ

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/chart.png" width="512" alt="" />

Settings Page

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/settings.png" width="512" alt="" />

Notifications

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/notifications.png" width="512" alt="" />

<img src="https://raw.githubusercontent.com/chamanbravo/upstat/main/./docs/assets/discord_notification.png" width="512" alt="" />


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-24

---