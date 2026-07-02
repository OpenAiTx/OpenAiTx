<div align="center" width="100%">

<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png">
  <img alt="Docker Hytale Server Logo" src="https://github.com/deinfreu/hytale-server-container/blob/main/assets/images/logo_Light.png" width="800">
</picture>

[![GitHub stars](https://img.shields.io/github/stars/deinfreu/hytale-server-container?style=for-the-badge&color=daaa3f)](https://github.com/deinfreu/hytale-server-container)
[![GitHub last commit](https://img.shields.io/github/last-commit/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container)
[![Discord](https://img.shields.io/discord/1458149014808821965?style=for-the-badge&label=Discord&labelColor=5865F2)](https://discord.gg/M8yrdnHb32)
[![Docker Pulls](https://img.shields.io/docker/pulls/deinfreu/hytale-server?style=for-the-badge)](https://hub.docker.com/r/deinfreu/hytale-server)
[![Docker Image Size (tag)](https://img.shields.io/docker/image-size/deinfreu/hytale-server/latest-alpine-liberica?sort=date&style=for-the-badge&label=ALPINE%20LIBERICA%20SIZE)](https://hub.docker.com/layers/deinfreu/hytale-server/latest-alpine-liberica/images/)
[![GitHub license](https://img.shields.io/github/license/deinfreu/hytale-server-container?style=for-the-badge)](https://github.com/deinfreu/hytale-server-container/blob/main/LICENSE)

10人以上の貢献者によるコミュニティ重視のDockerイメージでHytale専用サーバーを展開します。  
このプロジェクトは、組み込みのセキュリティ、ネットワーキング、およびデバッグツールを備えたHytaleのセルフホスティングを簡素化します。  
直接サポートを受けたり、他のサーバー所有者とつながるために、活発なDiscordに参加してください。  
モッドのテストや永続的なワールドの運用にかかわらず、このコンテナは一つのコマンドで一貫した本番環境を提供します。

</div>

## サポートとリソース

* **ドキュメント：** 詳細なパフォーマンス最適化およびセキュリティ仕様は[プロジェクトドキュメント](https://hytale-server-container.com/?utm_source=github&utm_medium=social&utm_campaign=github_readme)にあります。
* **トラブルシューティング：** 問題を報告する前に[support](https://hytale-server-container.com/installation/support//?utm_source=github&utm_medium=social&utm_campaign=github_readme)ページと[セキュリティポリシー](https://raw.githubusercontent.com/deinfreu/hytale-server-container/main/SECURITY.md)を確認してください。  
  また、[Discord](https://discord.com/invite/2kn2T6zpaV)もご利用いただけます。

## クイックスタート

Linuxにはdockerの[CLI](https://docs.docker.com/engine/install/)、Windows、macOS、Linuxには[GUI](https://docs.docker.com/desktop)をインストールしてください。

CLIで以下を実行してコンテナを起動できます。
```bash
docker run \
  --name hytale-server \
  -e SERVER_IP="0.0.0.0" \
  -e SERVER_PORT="5520" \
  -e PROD="FALSE" \
  -e DEBUG="FALSE" \
  -e TZ="Europe/Amsterdam" \
  -p 5520:5520/udp \
  -v "hytale-server:/home/container" \
  -v "/etc/machine-id:/etc/machine-id:ro" \
  --restart unless-stopped \
  deinfreu/hytale-server:latest
```

または、Docker Composeを使用してデプロイすることもできます。以下の設定を使用するか、より高度なテンプレートについては[examples](https://github.com/deinfreu/hytale-server-container/tree/main/examples)フォルダを参照してください。

```bash
services:
  hytale:
    image: deinfreu/hytale-server:latest
    container_name: hytale-server
    environment:
      SERVER_IP: "0.0.0.0"
      SERVER_PORT: "5520"
      PROD: "FALSE"
      DEBUG: "FALSE"
      TZ: "Europe/Amsterdam"
    restart: unless-stopped
    ports:
      - "5520:5520/udp"
    volumes:
      - ./data:/home/container
      - /etc/machine-id:/etc/machine-id:ro
    tty: true
    stdin_open: true
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-02

---