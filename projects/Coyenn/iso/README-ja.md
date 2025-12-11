<div align="center">
  <a href="https://iso.tim.cv/" target="_blank">
    <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-dashboard-bg-image.png" alt="Isoダッシュボードのスクリーンショット" width="800" />
  </a>
</div>

<br />
<div align="center">
  <a href="https://iso.tim.cv" target="_blank">デモ</a>
  |
  <a href="https://hub.docker.com/r/coyann/iso" target="_blank">Docker</a>
  |
  <a href="https://github.com/Coyenn/iso/" target="_blank">GitHub</a>
</div>
<br />

**Iso** は、すべてのセルフホストサービス向けのプラグアンドプレイダッシュボードです。
個人のホームラボ用に構築されました — 今ではあなたのためにオープンソース化されています。

- 単一の `config.json` ファイルで**完全に設定可能**
- **多言語対応**：英語、スペイン語、フランス語、ドイツ語
- **アイコン対応**：組み込みアイコンから選択可能、または独自のアイコンを提供可能
- **Dockerファースト**：シンプルなコマンド一つでどこでも実行可能

## ‍️クイックスタート

### Docker

```bash
docker run -d \
  --name iso \
  -p 3000:3000 \
  -e AUTH_SECRET="changeme" \
  -e AUTH_PASSWORD="changeme" \
  -v ./config:/config \
  coyann/iso
```

### Docker Compose

```yaml
services:
  iso:
    image: coyann/iso:latest
    container_name: iso
    ports:
      - "3000:3000"
    environment:
      - AUTH_SECRET=changeme
      - AUTH_PASSWORD=changeme
    volumes:
      - ./config:/config
    restart: unless-stopped
```

http://localhost:3000 を開くと、すぐに起動します！

## 設定

Iso は `/config` ディレクトリにある単一の `config.json` ファイルで設定されます。

### 設定例

```json
{
  "title": "My Dashboard",
  "services": [
    {
      "order": 1,
      "icon": "tv",
      "label": "Plex",
      "href": "https://plex.example.com"
    },
    {
      "order": 2,
      "icon": "lock",
      "label": "Bitwarden",
      "href": "https://vault.example.com"
    }
  ],
  "locale": "en",
  "theme": "amethyst",
  "greetings": [],
  "pageLoadAnimation": true,
  "search": {
    "enabled": true,
    "engine": "google",
    "engineUrl": "",
    "placeholder": "Search ..."
  }
}
```
### 設定オプション

- **title**: ヘッダーに表示されるダッシュボードのタイトル
- **services**: サービスオブジェクトの配列で以下を含む:
  - `order`: 表示順序（数値）
  - `icon`: 組み込みセットからのアイコン名
  - `label`: サービス表示名
  - `href`: サービスのURL
- **locale**: 言語コード（`en`、`es`、`fr`、`de`）
- **theme**: カラーテーマ（例：`amethyst`）
- **greetings**: カスタムの挨拶メッセージ
- **pageLoadAnimation**: ページアニメーションの有効/無効
- **search**: 検索バー設定を含むオブジェクト
  - `enabled`: 検索バーの表示切替
  - `engine`: 組み込み検索エンジン（`google`、`bing`、`duckduckgo`、`startpage`、`qwant`、`searx`、または`custom`）
  - `engineUrl`: カスタム検索エンジンのURL。検索クエリには`[q]`をプレースホルダーとして使用。
  - `placeholder`: 検索バーに表示される入力プレースホルダーのテキスト

## 環境変数

| 変数 | 説明 | デフォルト | 必須 |
|----------|-------------|---------|----------|
| `AUTH_SECRET` | 認証用の秘密鍵 | - | いいえ |
| `AUTH_PASSWORD` | ダッシュボードアクセス用パスワード | - | いいえ |
| `APP_DATA_PATH` | 設定ディレクトリのパス | `/config` | いいえ |

## その他のスクリーンショット

<div style="display: flex;">
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-settings.png" alt="Iso settings screenshot" width="400" style="width: 49%;" />
  <img src="https://raw.githubusercontent.com/Coyenn/iso/main/./.github/assets/preview-login.png" alt="Iso login screenshot" width="400" style="width: 49%;" />
</div>

## 開発

### 前提条件

- Nix


または

- [Bun](https://bun.sh/) JavaScript ランタイム

### ローカルセットアップ

1. リポジトリをクローンする：
```bash
git clone https://github.com/Coyenn/iso.git
cd iso
```

2. 依存関係をインストールする:
```bash
bun install
```

3. 開発サーバーを起動します:
```bash
bun dev
```

4. ブラウザで http://localhost:3000 を開きます

## ライセンス

MITライセンスの下で配布されています。詳細は `LICENSE` を参照してください。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-11

---