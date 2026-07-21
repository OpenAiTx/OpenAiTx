## Jelly Music App (JMA)

Jellyfin向けの軽量でエレガントな音楽インターフェースです。直感的でミニマルに設計され、細部にまでこだわった、音楽再生に特化したシンプルなウェブアプリです。Jellyfin APIを使用して、個人の音楽ライブラリにシームレスにアクセスできます。[デモ](https://stannnnn.github.io/jelly-app/login?demo=1)

**ビデオプレーヤーをお探しですか？** Jellyfinライブラリ向けのビデオ特化版、[Jelly Video App](https://github.com/Stannnnn/jelly-video-app/)をチェックしてください！

<br/>

<div>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/light-variant.webp" alt="ライトバリアント" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/dark-variant.webp" alt="ダークバリアント" width="49%">
</div>
<br/>

<details>
  <summary>追加のスクリーンショット</summary>
  <br/>
  <b>サイドナビ検索</b>
  <p>トラック、アーティスト、アルバム、プレイリスト、ジャンルを検索</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-light-variant.png" alt="サイドナビ検索 ライトバリアント" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-dark-variant.png" alt="サイドナビ検索 ダークバリアント" width="49%">
  <br/>
  <br/>
  <b>検索結果</b>
  <p>専用ウィンドウで追加の検索結果を表示</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-light-variant.webp" alt="検索結果 ライトバリアント" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/search-results-dark-variant.webp" alt="検索結果 ダークバリアント" width="49%">
  <br/>
  <br/>
  <b>アーティスト</b>
  <p>最も再生された曲、アルバム、その他のコラボレーションを表示</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-light-variant.webp" alt="アーティスト ライトバリアント" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/artist-dark-variant.webp" alt="アーティスト ダークバリアント" width="49%">
  <br/>
  <br/>
  <b>プレイリスト</b>
  <p>独自の番号付きトラックリストを持つプレイリストビュー</p>
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-light-variant.webp" alt="プレイリスト ライトバリアント" width="49%">
  <img src="https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/playlist-dark-variant.webp" alt="プレイリスト ダークバリアント" width="49%">
</details>
### 特徴

- **エレガントでシンプルなデザイン:** クリーンで散らかりのないインターフェースにより、音楽再生が簡単で楽しくなります。Reactなどの最新ツールを使って、迅速で信頼性の高い体験を実現。
- **デバイス対応:** モバイルでもデスクトップでもスムーズでアプリのような体験を楽しめ、PWAとしてインストール可能で即時アクセスが可能。
- **シームレスなライブラリアクセス:** Jellyfinサーバーに接続して、個人の音楽コレクションを簡単に探索。
- **お気に入りを発見:**
    - **ホーム:** 最近再生したトラック、最も再生されたお気に入り、最近追加されたメディアにすぐにアクセス。
    - **アーティスト:** ライブラリ内の任意のアーティストのトップトラック、アルバム、コラボレーションを閲覧。
    - **プレイリスト:** 明確で番号付きのトラックリストを持つプレイリストを表示し、素早くナビゲーション。
    - **クイック検索:** サイドナビの検索や専用結果ページで、トラック、アーティスト、アルバム、プレイリスト、ジャンルを簡単に検索。
    - **インスタントミックス:** 音楽ライブラリから直接キュレーションされたプレイリストを独立ページで楽しむ。
- **キュー:** 強化され改善されたキュー機能でトラックの管理と並べ替えが簡単に。
- **クロスフェード:** トラック間を滑らかに切り替え、シームレスで没入感のある聴取体験を提供。
- **プリロード:** 次のトラックを賢く事前に読み込み、バッファリング遅延なしのスムーズで途切れない再生を実現。
- **同期歌詞:** 見事なUIでお気に入りの曲の歌詞をラインごとに完璧なタイミングで表示し、新しい楽しみ方を提供。
- **スマートフェッチ:** 音楽を効率的にキャッシュし、即時でスムーズな再生を実現。
- **オフライン同期:** 個別の曲、アルバム全体、プレイリスト、またはアーティストごとにダウンロードしてオフライン再生が可能。
    - **自動同期:** 以前に保存したプレイリスト、アルバム、アーティストに新たに追加されたトラックを自動的にダウンロード。
    - **永続的キュー:** ダウンロードはローカルキューで管理され、セッションをまたいでシームレスに再開。
    - **トランスコードまたは直接ストリーム:** 選択したビットレートに基づき、オリジナル品質またはトランスコードされたダウンロードをサポート。
- **Dockerサポート:** 事前設定されたJellyfinサーバーURL付きの事前構築Dockerイメージをプルして展開し、シームレスなセルフホスティングを実現。

### インストール

Jelly Music Appは専用デスクトップアプリとしてインストール可能で、[GitHubリリースページ](https://github.com/Stannnnn/jelly-app/releases)から入手できます。最新のプロダクションビルドもそこから取得でき、アーカイブフォルダの内容をウェブアクセス可能なディレクトリに配置してウェブサーバーにデプロイ可能です。
<br/>
また、**dockerイメージ**としても提供されており、簡単に展開できます。詳細は下記のdocker情報を参照してください。
<br/>
<br/>

プロジェクトをビルドしたり開発サーバーを自分で実行したい場合は、[Yarn](https://classic.yarnpkg.com/lang/en/docs/install)（`npm i -g yarn`）が必要です。

#### ソースからのビルド

1. リポジトリをクローン:

    ```bash
    git clone https://github.com/Stannnnn/jelly-app.git
    ```
2. 依存関係のインストール：
    ```bash
    yarn
    ```
3. 本番用ファイルをビルドする:
    ```bash
    yarn build
    ```
4. `dist`フォルダの内容をウェブアクセス可能なディレクトリにデプロイします。

または、開発サーバーを直接実行できます：`yarn dev` または `yarn dev:nocache`

アプリケーションのベースパスをルート（`/`）以外にしたい場合は、`URL_BASE_PATH`を希望のベースパスに設定して手動でビルドする必要があります。

設定はデフォルトのままにするか、必要に応じて[`config.json`](https://raw.githubusercontent.com/Stannnnn/jelly-app/main/public/config.json)を変更してください。設定については[アプリ設定セクション](#app-configuration)で説明しています。  
ビルド後でも`config.json`ファイルは直接変更可能です。設定変数のみの変更であれば再ビルドは不要です。

### Docker

ghcr.ioのプリビルドイメージを使ってDockerでJelly Music Appを簡単にホストできます。

#### Dockerイメージをプルする

```bash
docker pull ghcr.io/stannnnn/jelly-music-app:latest
```

#### Dockerイメージを実行する

```bash
docker run --rm -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

Dockerイメージは、-dフラグを追加することでバックグラウンドで実行することもできます `docker run -d ...`

#### 設定変数を使ってdockerイメージを実行する

```bash
docker run --rm \
    -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
    -e LOCK_JELLYFIN_URL=false \
    -p 80:80 ghcr.io/stannnnn/jelly-music-app:latest
```

<br/>

以下はdockerで利用可能なタグです：

| タグ    | 説明                         |
| ------ | ---------------------------- |
| latest | 最新リリースを追跡します     |
| main   | メインブランチを追跡します   |
| vX.X.X | バージョン固有のタグです    |

例：`ghcr.io/stannnnn/jelly-music-app:latest`

#### Dockerコンテナのビルド

Dockerを使ってJelly Music Appをビルドすることもできます。

1.  Dockerイメージをビルドします：

    ```bash
    docker build . --tag jelly-music-app
    ```

2.  Dockerコンテナを実行します：

    ```bash
    docker run --rm -p 80:80 jelly-music-app:latest
    ```

    環境変数を使用して設定を提供することもできます。

    ```bash
    docker run --rm \
        -e DEFAULT_JELLYFIN_URL=https://demo.jellyfin.org/stable \
        -e LOCK_JELLYFIN_URL=false \
        -p 80:80 jelly-music-app:latest
    ```

#### Docker Compose

コンテナ管理を容易にするために、Docker Composeを使用できます。リポジトリには適切なデフォルト設定がされた`docker-compose.yaml`ファイルが用意されています。

1.  環境設定の例ファイルをコピーし、セットアップに合わせてカスタマイズしてください：

    ```bash
    cp .env.example .env
    ```

2.  `.env` ファイルを編集して、Jellyfin サーバーのURLと設定を入力します:

    ```env
    JELLYAPP_PORT=80
    JELLYAPP_DEFAULT_URL=https://demo.jellyfin.org/stable
    JELLYAPP_LOCK_URL=true
    ```

3.  Docker Composeを使用してコンテナを起動します:

    ```bash
    docker-compose up -d
    ```

`docker-compose.yaml` ファイルは、以下のデフォルト値を持つ環境変数を使用しています:

- `JELLYAPP_PORT`: 公開する外部ポート（デフォルト: `80`）
- `JELLYAPP_DEFAULT_URL`: デフォルトのJellyfinサーバーURL（デフォルト: `https://demo.jellyfin.org/stable`）
- `JELLYAPP_LOCK_URL`: JellyfinのURL入力をロック（デフォルト: `false`）

### アプリ設定

アプリの設定は、ビルドプロセス中またはリリースファイル内の `config.json` ファイルを編集して変更できます。Dockerを使用する場合は、環境変数として設定を提供できます。利用可能な設定オプションは以下の通りです:

- `DEFAULT_JELLYFIN_URL`: ローカルストレージにURLが保存されていない場合、アプリ初回アクセス時に読み込まれるデフォルトのJellyfinサーバーURLを設定します。
- `LOCK_JELLYFIN_URL`: `true` に設定すると、URL入力欄が削除され、すべての接続に対してデフォルトURL（`DEFAULT_JELLYFIN_URL`）が強制されます。これは単一サーバーに紐づいたセルフホスト環境に最適です。

### 貢献について

プルリクエストは大歓迎です。`develop` ブランチへのマージをお願いします。ご提案や改善点があれば、Issueを開くかプルリクエストを提出してください。皆様のご貢献をお待ちしております！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-21

---