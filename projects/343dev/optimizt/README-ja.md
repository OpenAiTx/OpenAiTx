# @343dev/optimizt

<img align="right" width="176" height="176"
     alt="Optimiztのロゴ：指の間にモナリザの画像があるOKサイン"
     src="https://raw.githubusercontent.com/343dev/optimizt/main/./docs/logo.png">

[![npm](https://img.shields.io/npm/v/@343dev/optimizt.svg)](https://www.npmjs.com/package/@343dev/optimizt)
[![Docker](https://img.shields.io/docker/v/343dev/optimizt?label=Docker)](https://hub.docker.com/r/343dev/optimizt)

**Optimizt** は、ウェブ用の画像を準備するのに役立つコマンドラインツールです。

PNG、JPEG、GIF、SVGをロスあり・ロスなしで圧縮でき、ラスター画像にはAVIFとWebPのバージョンも作成します。

## 理由

フロントエンド開発者として、画像に気を配る必要があります：PNGやJPEGの圧縮、SVGの不要な部分の削除、モダンブラウザ向けのAVIFやWebPの作成など。ある日、これらのために多くのアプリを使うのに疲れ、一つのツールでやりたいことをすべてできるものを作りました。

## 使い方

インストール：

```sh
npm install -g @343dev/optimizt
```

最適化！

```sh
optimizt path/to/picture.jpg
```

## コマンドラインフラグ

- `--avif` — 画像のAVIFバージョンを作成します。
- `--webp` — 画像のWebPバージョンを作成します。
- `-f, --force` — 既に存在していてもAVIFおよびWebPバージョンを再作成します。
- `-l, --lossless` — ロスレスで最適化します（ロッシーではなく）。
- `-v, --verbose` — 詳細な出力を表示します（例：スキップしたファイル）。
- `-c, --config` — デフォルトではなくカスタム設定ファイルを使用します。
- `-o, --output` — 指定したディレクトリに結果を書き込みます。
- `-p, --prefix` — 最適化されたファイル名にプレフィックスを追加します。
- `-s, --suffix` — 最適化されたファイル名にサフィックスを追加します。
- `-V, --version` — ツールのバージョンを表示します。
- `-h, --help` — ヘルプメッセージを表示します。

## 使用例

```bash
# optimize a single image
optimizt path/to/picture.jpg

# optimize multiple images losslessly
optimizt --lossless path/to/picture.jpg path/to/another/picture.png

# recursively create AVIF and WebP versions for all images in a directory
optimizt --avif --webp path/to/directory

# recursively optimize JPEG files in the current directory
find . -iname \*.jpg -exec optimizt {} +
```

## ロスィとロスレスの違い

### ロスィ（デフォルト）

ファイルサイズ削減と視覚的品質の損失を最小限に抑える最適なバランスを提供します。

### ロスレス（`--lossless` フラグ）

- **AVIF/WebP**：ロスレス圧縮を使用します。
- **PNG/JPEG/GIF**：ファイルサイズが大きくなる代わりに画像品質を最大化します。
- **SVG**：両モードで設定は同一です。

## 設定

画像処理は以下を利用します：

- [sharp](https://github.com/lovell/sharp) を [JPEG](https://sharp.pixelplumbing.com/api-output#jpeg)、[PNG](https://sharp.pixelplumbing.com/api-output#png)、[WebP](https://sharp.pixelplumbing.com/api-output#webp)、および [AVIF](https://sharp.pixelplumbing.com/api-output#avif) に。
- [svgo](https://github.com/svg/svgo) を SVG に。
- [gifsicle](https://github.com/kohler/gifsicle) を GIF に。

> [!注意]
> JPEG のロスレスモードでは [Guetzli](https://github.com/google/guetzli) が使用されます。繰り返しの最適化は視覚品質を劣化させることがあります。

デフォルト設定は [.optimiztrc.cjs](./.optimiztrc.cjs) に定義されており、すべてのサポートされているパラメータが含まれています。任意のパラメータは `false` に設定して無効化できます。

`--config path/to/.optimiztrc.cjs` を使用すると、指定した設定ファイルが使用されます。`--config` が指定されていない場合、Optimizt はカレントディレクトリから上位ディレクトリに向かって再帰的に `.optimiztrc.cjs` を検索します。見つからなければデフォルトが適用されます。

## トラブルシューティング

### “spawn guetzli ENOENT” のようなエラー

[npm の ignore-scripts](https://docs.npmjs.com/cli/v6/using-npm/config#ignore-scripts) オプションが無効になっていることを確認してください。
詳細: [funbox/optimizt/issues/9](https://github.com/funbox/optimizt/issues/9)。

## Docker

### 事前構築済みイメージ

```bash
# pull latest
docker pull 343dev/optimizt

# pull specific version
docker pull 343dev/optimizt:9.0.2
```

### 手動ビルド

```bash
# clone repository
git clone https://github.com/343dev/optimizt.git
cd optimizt

# build image
docker build --tag 343dev/optimizt .
```
代わりに：


```bash
# build directly from GitHub
# ignores .dockerignore (see: https://github.com/docker/cli/issues/2827)
docker build --tag 343dev/optimizt https://github.com/343dev/optimizt.git
```

### コンテナの実行

```bash
# mount current directory to /src in the container
docker run --rm --volume $(pwd):/src 343dev/optimizt --webp ./image.png
```

## 統合

Optimiztは以下とシームレスに連携します：

- [JetBrains IDEs](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/jetbrains.md)
- [Visual Studio Code](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/vscode.md)
- [Sublime Text 3](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/sublime-text.md)
- [GitHub Actions Workflow](https://raw.githubusercontent.com/343dev/optimizt/main/./docs/github.md)

## 記事

- [anuwong.com](https://anuwong.com/blog/2023-08-21-save-tons-of-gbs-with-optimizt/) — アップロード前にファイルを圧縮し、数GBを節約。🇹🇭
- [Linux Format, Issue 277 (2021年7月)](https://www.linuxformat.com/archives?issue=277#:~:text=Kitchen%20Tales%2C%20zFRAG%2C-,Optimizt,-and%20SingleFileZ.) — Optimiztは品質を落とさずに画像のディスク容量を削減するのに理想的です。

## クレジット

プロジェクトのかわいい画像は[Igor Garybaldi](http://pandabanda.com/)によって作成されました。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-07

---