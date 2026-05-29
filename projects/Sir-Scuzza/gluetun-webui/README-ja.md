
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Sir-Scuzza&project=gluetun-webui&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Gluetun WebUI

軽量なウェブUIで、[Gluetun](https://github.com/qdm12/gluetun) を監視・操作できます — Docker用VPNクライアントコンテナ。

![ステータス: 接続済み](https://img.shields.io/badge/status-connected-brightgreen)
![ノード 25](https://img.shields.io/badge/node-25--alpine-blue)
![Docker](https://img.shields.io/badge/docker-compose-blue)

---

## 特徴

- ✨ **マルチVPN対応** — 最大20個のGluetunインスタンスを同時に監視・制御
- ライブVPNステータスバナー（接続済み / 一時停止 / 切断）
- 公開出口IP、国、地域、都市、組織
- VPNプロバイダー、プロトコル（WireGuard / OpenVPN）、サーバー詳細
- ポートフォワーディングおよびDNSステータス
- VPNの開始 / 停止コントロール
- 設定可能な間隔（5秒～60秒）で自動更新
- 履歴バーで色分けされた直近30回のポーリング
- レスポンシブデザイン（モバイル、タブレット、デスクトップ）

---

## スクリーンショット
![alt text](https://raw.githubusercontent.com/Sir-Scuzza/gluetun-webui/main/image-1.png)

---

## 必要条件

- Docker + Docker Compose
- GluetunがHTTPコントロールサーバーを有効化して実行中（デフォルトポート `8000`）
- Gluetunおよびgluetun-webuiが同一のDockerネットワーク上

> `linux/amd64` と `linux/arm64` をサポート（Mac Intel/Apple Silicon、Linux、Windowsで動作）。

---

## クイックスタート

### オプションA1: シングルインスタンス（推奨）

Gluetunと一緒に、既存のcomposeファイルに`gluetun-webui`を追加します:

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    # Uncomment if Gluetun auth is enabled:
    #- GLUETUN_API_KEY=yourtoken
    #- GLUETUN_USER=username
    #- GLUETUN_PASSWORD=password
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
  healthcheck:
    test: ["CMD", "wget", "-qO-", "http://localhost:3000/api/health"]
    interval: 30s
    timeout: 5s
    start_period: 10s
    retries: 3
```

### オプションA2：複数インスタンス

2つ以上のGluetunインスタンスを別々のダッシュボードで監視：

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  container_name: gluetun-webui
  ports:
    - "127.0.0.1:3000:3000"
  environment:
    - GLUETUN_1_NAME=VPN - London
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1
    
    - GLUETUN_2_NAME=VPN - Amsterdam  
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2
    
    - GLUETUN_3_NAME=VPN - Singapore
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_API_KEY=token3
  networks:
    - your_network_name
  restart: unless-stopped
  read_only: true
  tmpfs:
    - /tmp
  security_opt:
    - no-new-privileges:true
  cap_drop:
    - ALL
```

### オプションB：ローカルでビルドする

```bash
git clone https://github.com/Sir-Scuzza/gluetun-webui.git
cd gluetun-webui
docker compose up -d --build
```

次に、以下のいずれかのオプションを実行します：

```bash
docker compose up -d
```

UIは **http://localhost:3000** で利用可能です

---

## ネットワーク設定

Gluetunとgluetun-webuiは同じDockerネットワーク上にある必要があり、`http://gluetun:8000` が正しく解決されます。

**同じcomposeファイル** — 両方のサービスを同じネットワークに追加するだけです（最も一般的）:

```yaml
services:
  gluetun:
    networks:
      - arr-stack
  gluetun-webui:
    networks:
      - arr-stack

networks:
  arr-stack:
    driver: bridge
```

**Composeファイルを分割する** — Gluetunの既存ネットワークを外部として参照します。ネットワーク名は`docker network ls`で確認してください：

```yaml
networks:
  ext-network:
    external: true
    name: your_gluetun_network_name
```

---

## マルチVPNサポート

### 複数インスタンス

gluetun-webuiは**複数のGluetunインスタンスを同時に**監視および制御することをサポートしています。各インスタンスはレスポンシブグリッド内の別々のダッシュボードとして表示されます。

**設定**: 番号付き環境変数を使用してください：

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    # Instance 1
    - GLUETUN_1_NAME=VPN 1
    - GLUETUN_1_URL=http://gluetun-1:8000
    - GLUETUN_1_API_KEY=token1  # optional

    # Instance 2
    - GLUETUN_2_NAME=VPN 2
    - GLUETUN_2_URL=http://gluetun-2:8000
    - GLUETUN_2_API_KEY=token2  # optional

    # Instance 3
    - GLUETUN_3_NAME=VPN 3
    - GLUETUN_3_URL=http://gluetun-3:8000
    - GLUETUN_3_USER=admin
    - GLUETUN_3_PASSWORD=secret  # optional (HTTP Basic auth)
```

**サポート対象**: 最大20インスタンス（`GLUETUN_1_URL`から`GLUETUN_20_URL`まで）  
**レスポンシブ対応**: 1つの全幅ダッシュボード → 2つの半幅 → 3つの3分の1幅 → 4つの4分の1幅 → 5つ以上はスクロール可能

### 後方互換性

番号付き変数が設定されていない場合は、**従来の単一インスタンスモード**にフォールバックします:

```yaml
environment:
  - GLUETUN_CONTROL_URL=http://gluetun:8000  # legacy
  - GLUETUN_API_KEY=token
```

### インスタンスごとの認証

各インスタンスは異なる認証を持つことができます:

```yaml
# Instance with API key
- GLUETUN_1_API_KEY=my-secret-token

# Instance with HTTP Basic auth
- GLUETUN_2_USER=admin
- GLUETUN_2_PASSWORD=mysecret

# Instance with no auth
- GLUETUN_3_URL=http://gluetun-3:8000  # auth optional
```

---

## 設定

| 変数 | デフォルト | 説明 |
|---|---|---|
| `GLUETUN_1_*` から `GLUETUN_20_*` | _(空)_ | **マルチインスタンス設定**（最大20インスタンス） |
| `GLUETUN_{N}_URL` | – | インスタンスNのGluetun HTTPコントロールサーバーURL |
| `GLUETUN_{N}_NAME` | `Instance {N}` | インスタンスNの表示名 |
| `GLUETUN_{N}_API_KEY` | _(空)_ | インスタンスNのベアラートークン（認証有効時） |
| `GLUETUN_{N}_USER` | _(空)_ | HTTPベーシック認証のユーザー名（インスタンスN） |
| `GLUETUN_{N}_PASSWORD` | _(空)_ | HTTPベーシック認証のパスワード（インスタンスN） |
| `GLUETUN_CONTROL_URL` | `http://gluetun:8000` | **レガシー** – 単一インスタンスのみ（`GLUETUN_1_*`変数がない場合のフォールバック） |
| `GLUETUN_API_KEY` | _(空)_ | **レガシー** – 単一インスタンス用ベアラートークン |
| `GLUETUN_USER` | _(空)_ | **レガシー** – HTTPベーシック認証のユーザー名 |
| `GLUETUN_PASSWORD` | _(空)_ | **レガシー** – HTTPベーシック認証のパスワード |
| `PORT` | `3000` | Web UIが待ち受けるポート |
| `TRUST_PROXY` | `false` | リバースプロキシ（nginx、Traefik等）背後で動作させる場合は`true`に設定 |

---

## セキュリティ

- ポートは `127.0.0.1` にバインドされており、ネットワークには公開されません
- コンテナは非rootユーザーで読み取り専用ファイルシステムおよび権限削除で実行されます
- すべてのAPIルートにレート制限を適用
- 上流のエラー詳細はサーバー側でのみログ記録され、ブラウザには一般的なメッセージが返されます

### リバースプロキシの設定

gluetun-webuiをリバースプロキシ（nginx、Traefik、Caddy等）背後で実行する場合は、環境変数に `TRUST_PROXY=true` を設定してください：

```yaml
gluetun-webui:
  image: scuzza/gluetun-webui:latest
  environment:
    - GLUETUN_CONTROL_URL=http://gluetun:8000
    - TRUST_PROXY=true  # Required for reverse proxies
```
これにより、アプリは正確なレート制限とIP検出のために `X-Forwarded-For` および関連ヘッダーを正しく解析できます。**注意：** 実際にリバースプロキシの背後にいる場合にのみこれを有効にしてください。リバースプロキシからのプロキシヘッダーを信頼するためです。

### リバースプロキシ認証

VPNの開始/停止コントロールには組み込みの認証がありません。UIをlocalhost以外に公開する場合は、HTTPベーシック認証付きのリバースプロキシの背後に配置してください。

**Caddy**（`Caddyfile`）：

```
your.domain.com {
  basicauth {
    user $2a$14$<bcrypt-hash>
  }
  reverse_proxy localhost:3000
}
```
ハッシュを生成するには：`caddy hash-password`

**Nginx**（`nginx.conf`）：
```nginx
location / {
  auth_basic "Restricted";
  auth_basic_user_file /etc/nginx/.htpasswd;
  proxy_pass http://localhost:3000;
}
```
パスワードファイルを生成するには: `htpasswd -c /etc/nginx/.htpasswd user`

**Traefik**（Dockerラベル）:
```yaml
labels:
  - "traefik.enable=true"
  - "traefik.http.routers.gluetun-webui.rule=Host(`your.domain.com`)"
  - "traefik.http.routers.gluetun-webui.middlewares=auth"
  - "traefik.http.middlewares.auth.basicauth.users=user:$$apr1$$<hash>"
```
`htpasswd -nb user password`でハッシュを生成

---

## 謝辞

- **[Gluetun](https://github.com/qdm12/gluetun)** — このwebuiが構築されたVPNクライアントコンテナ
- **[gluetun-monitor](https://github.com/csmarshall/gluetun-monitor)** — このwebuiと組み合わせるのに最適な監視ツール
- **AI支援開発** — 本プロジェクトはAI支援で構築されました

---

## ライセンス

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-29

---