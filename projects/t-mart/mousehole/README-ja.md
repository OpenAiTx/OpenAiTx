# Mousehole, MAM用シードボックスIPアップデーター

MAMのシードボックスIPを更新するバックグラウンドサービスと管理用のHTTPサーバー。

![Mousehole Demo](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/demo.webp)

ホスト/VPN/シードボックスを使用してシードしているが、そのIPアドレスが安定しない場合に役立ちます。

特徴：

- ホストのIPアドレスを定期的にMAMに更新するバックグラウンドサービス。

  更新前に、Mouseholeはホストの現在のIPアドレスとASを最後のMAM応答と比較し、
  実際に更新が必要かどうかをチェックします。

- サービスを管理するフロントエンドウェブサイトを提供し、以下が可能：

  - MAMクッキーの設定
  - ステータス情報の表示
  - チェックの手動トリガー

- 管理用エンドポイントを持つAPIサーバー。

  詳細は[API.md](https://github.com/t-mart/mousehole/blob/master/docs/API.md)を参照。

## はじめに

Mouseholeを使用するには以下が必要です：

1. [サービスの実行](#running-the-service)
2. [ウェブインターフェースでMAMクッキーを設定](#setting-your-mam-cookie)
3. [MAMエラーの処理](#handling-errors)（もしあれば）

### サービスの実行

#### Docker Compose（推奨）




```yaml
services:
  gluetun:
    image: qmcgaw/gluetun:latest
    cap_add:
      - NET_ADMIN
    devices:
      - /dev/net/tun:/dev/net/tun
    ports:
      - "5010:5010" # Mousehole port
      - "8080:8080" # qBittorrent Web UI port
      - "6881:6881/tcp" # qBittorrent TCP torrent port
      - "6881:6881/udp" # qBittorrent UDP torrent port
    environment:
      VPN_SERVICE_PROVIDER: "your-vpn-provider"
      FIREWALL_VPN_INPUT_PORTS: "6881" # qBittorrent torrent
      # more is needed here -- see Gluetun documentation
      # https://github.com/qdm12/gluetun-wiki
      # https://github.com/qdm12/gluetun-wiki/tree/main/setup/providers
    restart: unless-stopped

  qbittorrent:
    image: lscr.io/linuxserver/qbittorrent:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
      WEBUI_PORT: 8080
      TORRENTING_PORT: 6881
    restart: unless-stopped

  mousehole:
    image: tmmrtn/mousehole:latest
    network_mode: "service:gluetun"
    environment:
      TZ: Etc/UTC # Set to your timezone for localization
    volumes:
      # persist cookie data across container restarts
      - "mousehole:/srv/mousehole"
    restart: unless-stopped

volumes:
  mousehole:
```


スターター Docker Compose の例：

- ⭐ [Gluetun + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/gluetun-qb.md)
- [Wireguard + qBittorrent + Mousehole](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/wireguard-qb.md)
- [VPNなしの例](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/docker-compose-examples/non-vpn.md)

任意の VPN セットアップは、サイドカーとして Mousehole を含むように適応できます。詳細は
[Docker Compose での Mousehole のサイドカー利用](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/sidecars.md) を参照してください。

#### Unraid

インストール手順は [Unraid インストールガイド](https://raw.githubusercontent.com/t-mart/mousehole/master/./contrib/unraid/README.md) を参照してください。

#### ローカル

サーバーを以下のコマンドで起動します：



```bash
bun run start
```
### MAMクッキーの設定

Mouseholeが起動したら、ブラウザでそのWeb UIにアクセスします：`http://<host>:5010`。  
ローカルで実行している場合は、おそらく <http://localhost:5010> です。

初めて起動する場合（またはクッキーが同期しなくなった場合）は、  
Mouseholeのクッキーを手動で設定する必要があります。

MouseholeのWebインターフェースにアクセスすると、  
クッキーを設定するフォームが表示されます。クッキーを貼り付けて「Set」ボタンをクリックしてください。

![Mousehole Cookie Form](https://raw.githubusercontent.com/t-mart/mousehole/master/docs/images/cookie-form.png)

クッキーの取得方法がわからない場合は、「What do I enter here?」ボタンをクリックしてチュートリアルを参照してください。


### エラーの対処

Mouseholeが起動していても、自動で修正できない問題が発生することがあります。  
よくあるエラーは以下の通りです：

- ["Invalid session - ASN mismatch"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/asn-mismatch.md)  
- ["Invalid session - Invalid cookie"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/invalid-cookie.md)  
- ["Last Change too recent"](https://raw.githubusercontent.com/t-mart/mousehole/master/./docs/errors/last-change-too-recent.md)  

## Dockerタグ

Mouseholeは複数のイメージタグを  
[Docker Hub](https://hub.docker.com/r/tmmrtn/mousehole)に公開しています：

- セマンティックバージョン（`0`、`0.1`、`0.1.11` など）  
- 最新リリース版の `latest`  
- `master` ブランチの最新コミットを示す `edge`  
- `master` ブランチ向けのプルリクエスト用テストタグ `pr-<number>`

どれを選べばいいかわからない場合は `latest` を選んでください。




## 環境変数

- `MOUSEHOLE_PORT`: _(デフォルト `5010`)_ HTTPサーバーがリッスンするポート。
- `MOUSEHOLE_STATE_DIR_PATH`: _(デフォルト `/srv/mousehole`)_ サービスがデータを保存するディレクトリ。
- `MOUSEHOLE_USER_AGENT`: _(デフォルト `mousehole-by-timtimtim/<version>`)_ MAMへのリクエストに使用するユーザーエージェント。
- `MOUSEHOLE_CHECK_INTERVAL_SECONDS`: _(デフォルト `300` (5分))_ チェック間隔（秒）。
- `MOUSEHOLE_STALE_RESPONSE_SECONDS`: _(デフォルト `86400` (1日))_ MAMのレスポンスが古いとみなす秒数。これによりMouseholeが定期的にMAMと通信し、クッキーの帯域外の変更を検出していることを保証する。
- `TZ`: _(デフォルト `Etc/UTC`)_ ローカライズされた時間表示のためのタイムゾーン。

## コントリビューション

貢献したいですか？[貢献ガイドライン](https://raw.githubusercontent.com/t-mart/mousehole/master/./CONTRIBUTING.md)をチェックしてください。

また、有用な補助機能を含む[`contrib`](./contrib/)ディレクトリもあります。

## リンク

- [リポジトリ](https://github.com/t-mart/mousehole)
- [Docker Hubイメージ](https://hub.docker.com/r/tmmrtn/mousehole)
- [フォーラム投稿](https://www.myanonamouse.net/f/t/84712/p/p1013257)

## 開発

- 開発サーバーを起動するには:









  ```bash
  bun run dev
  ```

- 新しいバージョンは、`package.json` のバージョンを変更してGitHubにプッシュするだけで
  タグ付け、リリース、Docker Hubへのプッシュが可能です。CIワークフローが
  残りの処理を自動で行います。

## 帰属表示

Mouse Hole by Sergey Demushkin from
[Noun Project](https://thenounproject.com/term/mouse-hole/) (CC BY 3.0)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-12

---