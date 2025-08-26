
<div align="right">
  <details>
    <summary >🌐 言語</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

コンテナイメージ（Docker等）をGitリポジトリへ変換するRustアプリケーションです。各コンテナレイヤーはGitコミットとして表現され、元のイメージの履歴と構造が保持されます。

![OCI2Gitがnginxイメージを変換するデモ](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 特徴

- Dockerイメージを解析し、レイヤー情報を抽出
- 各イメージレイヤーをコミットとして表現するGitリポジトリを作成
- 空のレイヤー（ENV、WORKDIRなど）を空のコミットとしてサポート
- 完全なメタデータ抽出をMarkdown形式で対応
- 異なるコンテナエンジンをサポート可能な拡張性のあるアーキテクチャ

## ユースケース

### レイヤー差分
コンテナの問題をトラブルシュートする際、Gitの強力なdiff機能を使って任意の2つのレイヤー間で何が変更されたか正確に特定できます。`git diff`をコミット間で実行することで、エンジニアはどのファイルが追加、変更、削除されたかを正確に把握でき、各Dockerfile命令の影響や問題のある変更箇所を簡単に見つけられます。
![レイヤー差分の例](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### オリジントラッキング
`git blame`を使うことで、開発者は特定のファイルやコード行がどのレイヤーで導入されたかを素早く特定できます。これは設定ファイルや依存関係の問題を診断する際に特に有用です。各レイヤーを手作業で調査する代わりに、任意のファイルの起源を即座にその元レイヤーや対応するDockerfile命令まで遡ることができます。

### ファイルのライフサイクルトラッキング
OCI2Gitは、特定ファイルがコンテナイメージの履歴全体でどのように変遷したかを追跡できます。ファイルが最初に作成された時期、各レイヤーでどのように変更されたか、最終的に削除されたかどうかを観察できます。この包括的な視点により、多数のレイヤーにまたがる変更を手作業で追跡することなく、ファイルの進化を理解できます。

コンテナイメージ内のファイル履歴を追跡するには（作成時期、変更、削除など）、変換後にこれらのGitコマンドを使用できます。

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```
これらのコマンドにより、レイヤーのtarballを手動で抽出・比較する複雑さなしに、任意のファイルのコンテナレイヤー全体の履歴を簡単に追跡できます。

### マルチレイヤー分析
時には、連続していない複数のレイヤー間の変更を調べることが最も洞察に富んだ比較をもたらします。OCI2Gitを使えば、Gitの比較ツールを利用して複数のビルドステージにわたるコンポーネントの進化を分析し、隣接するレイヤーだけを見ていると見えないパターンを特定できます。

### レイヤーの探索
`git checkout`を使用して任意のコミットに移動することで、そのレイヤーの時点でのコンテナファイルシステムを正確に調べることができます。これにより、開発者はイメージ作成プロセスの任意の時点でのファイルやディレクトリの正確な状態を検査でき、デバッグやコンテナの動作検証時に非常に有用なコンテキストを提供します。
![Checkout to previous commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### マルチイメージ分析

共通の起源を持つ複数のコンテナイメージを扱う場合、OCI2Gitは実際にイメージが分岐したときのみブランチを賢く作成します。これにより、共通の履歴を保持しつつ、単一のリポジトリ内で複数の関連イメージを分析できます。


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Gitは、イメージ間の共有レイヤーを自動的に検出し、それらの共通のベースを反映したブランチ構造を作成します。Gitの履歴には以下が表示されます：
- すべての共有レイヤーを含む共通の幹
- イメージが実際に異なる場合にのみ分岐する個別のブランチ
- イメージが共通の祖先を共有する部分と、独自の部分が明確に視覚化される
- 賢い重複処理：まったく同じイメージが二度処理された場合、最終的なメタデータコミットの前にこれを検出し、重複したブランチの作成をスキップ

このアプローチは特に次の点で有用です：
- **イメージファミリー分析**：異なるバージョン、アーキテクチャ、または構成など、イメージの異なるバリアントが互いにどのように関連しているかを理解する
- **ベースイメージの影響**：ベースイメージの変更が複数の派生イメージにどのように影響するかを正確に把握する
- **最適化の機会**：イメージバリアント間でより良く活用できる共有コンポーネントを特定する

![共有ベースと分岐するブランチを示すマルチイメージリポジトリ構造](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### 追加のユースケース

- **セキュリティ監査**：脆弱なパッケージや設定が正確にいつ導入されたかを特定し、特定のビルド指示に遡ることができる。
- **イメージ最適化**：レイヤー構造を分析して冗長な操作や統合可能な大きなファイルを見つけ、イメージサイズの削減に役立てる。
- **依存関係管理**：依存関係がイメージ履歴のどの時点で追加、アップグレード、または削除されたかを監視する。
- **ビルドプロセスの改善**：レイヤー構成を検証してDockerfileの指示を最適化し、キャッシュ効率とイメージサイズの縮小を図る。
- **クロスイメージ比較**：複数の関連イメージをGitリポジトリに変換し、Gitの比較ツールを使って差異と共通点を分析する。

## インストール

### ソースからのインストール


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Crates.ioからの入手方法

```bash
cargo install oci2git
```

## 使用方法

```bash
oci2git [OPTIONS] <IMAGE>
```

引数:
  `<IMAGE>`  変換するイメージ名（例: 'ubuntu:latest'）またはtarエンジン使用時のtarボールのパス

オプション:
  `-o, --output <o>`  Gitリポジトリの出力ディレクトリ [デフォルト: ./container_repo]
  `-e, --engine <ENGINE>`  使用するコンテナエンジン（docker、nerdctl、tar） [デフォルト: docker]
  `-h, --help`            ヘルプ情報を表示
  `-V, --version`         バージョン情報を表示

環境変数:
  `TMPDIR`  中間データ処理に使用されるデフォルトの場所を変更するためにこの環境変数を設定します。これはプラットフォーム依存です（例: Unix/macOSでは`TMPDIR`、Windowsでは`TEMP`または`TMP`）。

## 例

Dockerエンジン使用（デフォルト）:
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

すでにダウンロードされたイメージtarballを使用する場合：
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```
tarエンジンは有効なOCIフォーマットのtarボールを期待しており、これは通常`docker save`で作成されます：

```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

これにより、`./ubuntu-repo` に以下を含むGitリポジトリが作成されます：
- `Image.md` - 画像に関する完全なメタデータをMarkdown形式で記述
- `rootfs/` - コンテナからのファイルシステムの内容

Gitの履歴はコンテナのレイヤー履歴を反映します：
- 最初のコミットは完全なメタデータを含む `Image.md` ファイルのみ
- 以降の各コミットは元のイメージのレイヤーを表す
- コミットメッセージにはDockerfileのコマンドが含まれる

## リポジトリ構成

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```

## 要件

- Rust 2021 エディション
- Docker CLI（Dockerエンジンのサポート用）
- Git

## ライセンス

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---