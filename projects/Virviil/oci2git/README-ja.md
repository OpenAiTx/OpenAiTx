# OCI2Git

コンテナイメージ（Dockerなど）をGitリポジトリに変換するRust製アプリケーションです。各コンテナレイヤーはGitコミットとして表現され、元のイメージの履歴と構造が保持されます。

![nginxイメージをOCI2Gitで変換するデモ](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## 機能

- Dockerイメージを解析しレイヤー情報を抽出
- 各イメージレイヤーをコミットとして表現するGitリポジトリを作成
- 空レイヤー（ENV、WORKDIRなど）を空コミットとしてサポート
- メタデータをMarkdown形式で完全抽出
- 異なるコンテナエンジン対応のための拡張可能なアーキテクチャ

## ユースケース

### レイヤーディフ比較
コンテナの問題解決時に、Gitの強力なdiff機能を使って任意の2レイヤー間で何が変更されたか正確に特定可能です。コミット間で`git diff`を実行することで、エンジニアはどのファイルが追加、変更、削除されたかを正確に把握でき、各Dockerfile命令の影響や問題のある変更点を容易に理解できます。
![レイヤーディフの例](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### 起源の追跡
`git blame`を使用することで、開発者は特定のファイルやコード行を導入したレイヤーを迅速に特定できます。これは設定ファイルや依存関係の問題を診断する際に特に有用です。各レイヤーを手動で調査する代わりに、任意のファイルの起源を対応するDockerfile命令とともに即座に辿ることが可能です。

### ファイルのライフサイクル追跡
OCI2Gitはコンテナイメージの履歴における特定ファイルの変遷を追跡可能にします。ファイルが初めて作成された時期、レイヤーをまたいでどのように変更されたか、そして最終的に削除されたかどうかを観察できます。この包括的なビューにより、多数のレイヤーを手動で追跡することなくファイルの進化を理解できます。

コンテナイメージ内のファイルの履歴（初出、変更、削除）を追跡するには、変換後に以下のGitコマンドを使用できます：

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-23

---