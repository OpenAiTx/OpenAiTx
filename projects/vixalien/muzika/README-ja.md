# Muzika

> [!CAUTION]
> Muzikaは現在メンテナンスされておらず、将来的にアーカイブされる予定です。詳細はhttps://github.com/vixalien/muzika/issues/220をご覧ください。

Muzikaはエレガントな音楽ストリーミングアプリです。

![Muzika home page](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/home.png)

![Muzika playing "My Queen is Angela Davis"](https://raw.githubusercontent.com/vixalien/muzika/main/data/resources/screenshots/playing.png)

> 注意: これは進行中の作業です。アプリはまだ本番環境用に準備されていません。

## 機能

- パーソナライズされたホーム画面
- 曲、アルバム、アーティスト、ラジオ、プレイリストの検索
- Googleでログインし、ライブラリからプレイリストなどにアクセス
- パーソナライズされたラジオ＆ミックスの再生
- 歌詞と関連情報の表示
- アーティスト、アルバム、プレイリストの閲覧など

## インストール

### 最新のナイトリーフラットパックを使用する

[最新のナイトリーフラットパック](https://vixalien.github.io/muzika/muzika.flatpakref)をダウンロードできます。

### ソースから

依存関係：

- GNOME Builder

1. リポジトリをクローンする

```bash
git clone https://github.com/vixalien/muzika.git --recurse-submodules
```
2. GNOME Builderでプロジェクトを開き、「ビルド」を使ってプロジェクトをビルドします。

> 注意: Muzikaは最新の（未リリースの）libadwaitaコンポーネントを使用しているため、
> MesonやNinjaを直接使う方法はサポートされていません。

## ナビゲーション

Muzikaには堅牢なナビゲーターがあり、muzika URIを使って異なるページを移動できます。
以下にいくつかの例を示します。

muzika URIは `muzika:endpoint:data` の形式です。URIにはクエリパラメータも含められます。
例えば、`muzika:library?view=grid` はライブラリページをグリッドビューで開きます。

検索バーに直接muzika URIを入力すると、そのページに直接移動し、検索は行われません。

また、ナビゲーターアクションを手動でトリガーして特定のエンドポイントに移動することもできます：

1. `Ctrl+Shift+I` を押してGTKインスペクターを開きます。
2. 右側の `Actions` タブをクリックします。
3. `navigator.visit` というアクションを探し、`Parameter` フィールドにURIを入力してから `Activate` をクリックします。

### エンドポイント

すべてのエンドポイント一覧は [こちら](https://raw.githubusercontent.com/vixalien/muzika/main/src/pages.ts) にあります。

- `muzika:home` - ホームページ
- `muzika:playlist:<playlistId>` - プレイリストページ。例：
  `muzika:playlist:PL4fGSI1pDJn6puJdseH2Rt9sMvt9E2M4i`/
- `muzika:album:<albumId>` - アルバムページ。
- `muzika:artist:<channelId>` - アーティストまたはチャンネルページ。
- `search:<query>` - 検索。クエリはURLエンコードされている必要があります。例：
  `search:hello%20world` は `hello world` を検索します。
- `muzika:library` - ライブラリ。

Muzikaが新機能をサポートするにつれて、さらに多くのエンドポイントが追加されます。







---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-05

---