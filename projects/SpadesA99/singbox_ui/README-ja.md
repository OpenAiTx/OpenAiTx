# Sing-box UI

**[English](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/README_EN.md) | 中文**

<div align="center">

[![Docker Image](https://img.shields.io/badge/ghcr.io-singbox__ui-blue?logo=docker)](https://github.com/SpadesA99/singbox_ui/pkgs/container/singbox_ui)
[![Build Status](https://github.com/SpadesA99/singbox_ui/actions/workflows/docker-build.yml/badge.svg)](https://github.com/SpadesA99/singbox_ui/actions)
[![GitHub Stars](https://img.shields.io/github/stars/SpadesA99/singbox_ui?style=flat&logo=github)](https://github.com/SpadesA99/singbox_ui/stargazers)
[![License](https://img.shields.io/github/license/SpadesA99/singbox_ui)](LICENSE)

**モダンな sing-box 設定管理ツール**

Go 1.24 + Next.js 16 をベースに構築され、Docker コンテナで sing-box を管理

</div>

![Sing-box UI 界面截图](https://raw.githubusercontent.com/SpadesA99/singbox_ui/main/docs/zh.png)

---

## コア機能

### プロトコル対応

| インバウンドプロトコル | アウトバウンドプロトコル | サブスクリプション解析 |
|---------|---------|---------|
| WireGuard | すべてのインバウンドプロトコル | VMess |
| Mixed (Socks5+HTTP) | direct (直結) | VLESS |
| VLESS | block (ブロック) | Trojan |
| VMess | | Shadowsocks |
| Trojan | | AnyTLS |
| Shadowsocks | | Clash YAML フォーマット |
| Hysteria2 | | |
| TUIC | | |
| Naive | | |
| ShadowTLS | | |
| AnyTLS | | |
| HTTP | | |

### TLS 証明書管理

- **ACME 自動証明書**: Let's Encrypt の自動申請および更新をサポート  
- **手動証明書**: 独自の証明書ファイルのアップロードをサポート  
- **マルチプロトコル対応**: VLESS、VMess、Trojan、Hysteria2 などの TLS プロトコルで ACME をサポート  

### ルール設定

- **クイックテンプレート**: よく使うルールをワンクリックで有効化（広告ブロック、中国 IP/ドメイン直通、プライベート IP 直通）  
- **ルールのクイック追加**: IP またはドメインを直通/プロキシ/ブロックリストに迅速に追加可能  
- **直通モード**: プロキシ経由の送信がない場合、自動的に直通モードに設定  

### ロードバランシング

- **URLTest モード**: sing-box の `urltest` 送信をベースに、最も低遅延のノードを自動選択  
- **設定可能な許容差**: 遅延許容値（デフォルト 50ms）をカスタマイズし、頻繁な切り替えを防止  
- **動的ノードプール**: 購読から複数ノードを柔軟に選択してロードバランスグループを構成  
- **スマートルーティング**: 自動でルールを生成し、トラフィックをスマートに分散  

### マルチインスタンス管理

- 複数の名前付き sing-box インスタンス作成をサポート  
- 各インスタンスは独立して設定、起動・停止可能  
- 独立したコンテナログと状態監視  

### WireGuard VPN 管理

- Curve25519 鍵生成  
- IP バインド鍵キャッシュ  
- クライアント設定管理（大量生成、QRコード、設定ダウンロード）  

### Cloudflare WARP 送信

- **ワンクリック登録**: Curve25519 鍵ペアを自動生成し Cloudflare 登録 API を呼び出し、デバイストークンをローカルキャッシュ、手動設定不要  
- **WARP+ バインド**: ライセンス入力で WARP+ アカウントをバインド、無制限トラフィック獲得可能  
- **エンドポイント最適化**: 本物の WireGuard ハンドシェイク検出——候補 `IP:Port` に WG 初期パケットを送信し、92 バイトの `MessageResponse` を検証、パケットロス率＋平均 RTT でソートし、UDP パス品質を正確に反映（[CloudflareWarpSpeedTest](https://github.com/peanut996/CloudflareWarpSpeedTest) 実装参照）  
- **広範囲スキャン**: 8 個の Cloudflare /24 セグメント × 54 個の既知 WARP UDP ポートを並列スキャン・サンプリングをシャッフルし、最速のエッジノードを高速発見  

### ノードヘルスチェック

- 非同期マルチノード並行検出  
- 成功率スライディングウィンドウ統計  
- API ポーリングによる検出結果取得  

### 管理機能  

- 設定プレビュー（JSONエディター）  
- コンテナログの閲覧  
- コンテナ状態の監視  

---  

## クイックスタート  

### Docker Compose（推奨）  

`docker-compose.yml` を作成:

```yaml
services:
  singbox-ui:
    image: ghcr.io/spadesa99/singbox_ui:latest
    container_name: singbox-ui
    restart: unless-stopped
    network_mode: host
    volumes:
      - /var/run/docker.sock:/var/run/docker.sock
      - ./data:/home/data
    environment:
      - DATA_DIR=/home/data
      - HOST_DATA_DIR=${PWD}/data
      - LISTEN_ADDR=127.0.0.1:7000
      - TZ=Asia/Shanghai
```

```bash
docker compose up -d
```

http://127.0.0.1:7000 にアクセス

> **説明**:
> - コンテナがホストのネットワークを直接使用できるように `network_mode: host` を使用
> - デフォルトで `127.0.0.1:7000` をリッスンし、ローカルアクセスのみ。`LISTEN_ADDR` 環境変数でカスタマイズ可能
> - sing-box コンテナ管理用に Docker Socket をマウント
> - `HOST_DATA_DIR` は `${PWD}` によりホストのデータディレクトリを自動マッピングし、sing-box コンテナにマウント
> - sing-box v1.13.5 イメージを内蔵し、初回起動時に自動ロード、ネットワークからの取得不要

### リモートアクセス

サービスはデフォルトで `127.0.0.1` のみリッスンしており、SSH トンネルを通じた安全なアクセスを推奨：

```bash
ssh -L 7000:127.0.0.1:7000 user@your-server
```
そしてローカルブラウザで http://127.0.0.1:7000 にアクセスします

> **セキュリティの注意**: `LISTEN_ADDR` を `0.0.0.0:7000` に変更して直接パブリックに公開することは推奨されません。管理パネルには認証保護がありません。外部からアクセスする場合は、SSHトンネルの利用や認証付きリバースプロキシ（例: Nginx + Basic Auth）の設定を行ってください。

---

## 環境変数

| 変数 | 説明 | デフォルト値 |
|------|------|--------------|
| `DATA_DIR` | コンテナ内データディレクトリ | `/home/data` |
| `HOST_DATA_DIR` | ホストマシンのデータディレクトリ（sing-boxコンテナのマウント用） | `${PWD}/data` |
| `LISTEN_ADDR` | サービスのリッスンアドレス | `127.0.0.1:7000` |
| `TZ` | タイムゾーン | `Asia/Shanghai` |

---

## 技術スタック

| フロントエンド | バックエンド |
|----------------|--------------|
| Next.js 16 | Go 1.24 |
| React 19 | Gin 1.11 |
| Tailwind CSS | Docker SDK |
| shadcn/ui | |

---

## ライセンス

[MIT License](LICENSE)

## Star History

[![Star History Chart](https://api.star-history.com/svg?repos=SpadesA99/singbox_ui&type=Date)](https://star-history.com/#SpadesA99/singbox_ui&Date)

## 謝辞

- [sing-box](https://github.com/SagerNet/sing-box)

- [Next.js](https://nextjs.org/)
- [Gin](https://github.com/gin-gonic/gin)
- [shadcn/ui](https://ui.shadcn.com/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---