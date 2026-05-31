<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou-dark.png">
  <source media="(prefers-color-scheme: light)" srcset="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg">
  <img alt="Piou logo"
    src="https://github.com/Andarius/piou/raw/master/docs/static/piou.jpg"
    width="250"/>
</picture>

# Piou

[![Python versions](https://img.shields.io/pypi/pyversions/piou)](https://pypi.python.org/pypi/piou)
[![Latest PyPI version](https://img.shields.io/pypi/v/piou?logo=pypi)](https://pypi.python.org/pypi/piou)
[![CI](https://github.com/Andarius/piou/actions/workflows/ci.yml/badge.svg)](https://github.com/Andarius/piou/actions/workflows/ci.yml)
[![Latest conda-forge version](https://img.shields.io/conda/vn/conda-forge/piou?logo=conda-forge)](https://anaconda.org/conda-forge/piou)

タイプ検証付きで美しいコマンドラインインターフェースを構築するCLIツール。

## クイック例

```python
from piou import Cli, Option

cli = Cli(description='A CLI tool')


@cli.command(cmd='foo', help='Run foo command')
def foo_main(
        bar: int = Option(help='Bar positional argument (required)'),
        baz: str = Option('-b', '--baz', help='Baz keyword argument (required)'),
        foo: str | None = Option(None, '--foo', help='Foo keyword argument'),
):
    """
    A longer description on what the function is doing.
    """
    pass


if __name__ == '__main__':
    cli.run()
```

![example](https://github.com/Andarius/piou/raw/master/docs/static/simple-output.svg)

## Installation

```bash
pip install piou
```
または[uv](https://docs.astral.sh/uv/)を使用して：


```bash
uv add piou
```

または[conda](https://docs.conda.io/)で：

```bash
conda install piou -c conda-forge
```

### Raw Formatter

デフォルトでは、Piouは美しいターミナル出力のために[Rich](https://github.com/Textualize/rich)を使用します。プレーンテキスト出力を好む場合は、rawフォーマッターを使用できます。

```bash
# Force raw output via environment variable
PIOU_FORMATTER=raw python your_cli.py --help
```
## ドキュメント

完全なドキュメントは **[andarius.github.io/piou](https://andarius.github.io/piou)** で利用可能です。

### 特徴

- FastAPIのような開発者体験と型ヒント
- カスタムフォーマッター（デフォルトはRichベース）
- ネストされたコマンドグループ / サブコマンド
- 再利用可能な引数パターンのための派生オプション
- 非同期コマンド対応
- 型の検証とキャスト
- **コマンド提案と履歴機能付きの対話型TUIモード**
- **ツールやプログラム的なCLI発見のための構造化JSONヘルプ** (`--help-json`)

## なぜPiouなのか？

私は以下を提供するライブラリを見つけられませんでした：

- [FastAPI](https://fastapi.tiangolo.com/) と同じ開発者体験
- インターフェースのカスタマイズ（[Poetry](https://python-poetry.org/)に似たCLIを構築するため）
- 型の検証 / キャスト

[Typer](https://github.com/tiangolo/typer) は最も近い代替ですが、外部ライブラリ（[Rich](https://github.com/Textualize/rich)など）を使って出力をカスタムフォーマットする機能が欠けています。

**Piou** はこれらすべての可能性を提供し、独自のフォーマッターを定義できます。

## 非同期コマンド

コマンドは `async` 関数にでき、piouはコルーチンを検出して自動的に実行します。手動での `asyncio.run()` は不要です：


```python
from piou import Cli, Option

cli = Cli(description='Async example')

@cli.command(cmd='fetch', help='Fetch data')
async def fetch(url: str = Option(help='URL to fetch')):
    import niquests
    async with niquests.AsyncSession() as client:
        r = await client.get(url)
        print(r.status_code)

if __name__ == '__main__':
    cli.run()
```

これはコマンドグループ内のコマンドでも同様に動作します。

## インタラクティブTUIモード

Piouには[Textual](https://textual.textualize.io/)を利用したオプションのインタラクティブTUI（テキストユーザーインターフェース）モードが含まれています。
これにより、コマンドの候補表示、履歴、インライン補完を備えた豊富なターミナル体験が提供されます。

### インストール

```bash
pip install piou[tui]

# With auto-reload support for development
pip install piou[tui-reload]
```

### 使用方法

CLIを作成するときに`tui=True`を設定してTUIモードを有効にします：

```python
from piou import Cli, Option

cli = Cli(description='My Interactive CLI', tui=True)

@cli.command(cmd='hello', help='Say hello')
def hello(name: str = Option(..., help='Name to greet')):
    print(f'Hello, {name}!')

if __name__ == '__main__':
    cli.run()
```

または `--tui` フラグを使用して:

```bash
python my_cli.py --tui
```

または `PIOU_TUI=1` 環境変数を使用して：

```bash
PIOU_TUI=1 python my_cli.py
```

### TUIの機能

- **コマンドの提案**: `/` を入力して利用可能なコマンドと説明を表示
- **サブコマンドのナビゲーション**: `:` を使ってサブコマンドを移動（例: `/stats:uploads`）
- **インライン補完**: 入力中に引数のプレースホルダーを表示
- **コマンド履歴**: 上下矢印で過去のコマンドを移動（セッション間で保持）
- **リッチ出力**: ANSIカラーとフォーマットを出力で保持
- **キーボードショートカット**:
  - `Tab` - 選択中の提案を確定
  - `Up/Down` - 提案または履歴を移動
  - `Ctrl+C` - 入力をクリア（2回押すと終了）
  - `Escape` - 終了
- **開発モード**: ソースファイルの変更時にコマンドを自動リロード（以下参照）

<img alt="TUI Demo" src="https://github.com/Andarius/piou/raw/master/docs/static/tui-demo.gif" width="600"/>

### 自動リロード付き開発モード

より速い開発サイクルのために、開発モードを有効にするとソースファイルの変更時にコマンドが自動でリロードされます：

```bash
pip install piou[tui-reload]
```

次に `--tui-reload` フラグを使用します：

```bash
python my_cli.py --tui-reload
```

または環境変数を介して:

```bash
PIOU_TUI_DEV=1 python my_cli.py --tui
```

有効にすると、Piouはコマンドのソースファイルを監視し、保存時にホットリロードします。実行時に `/tui-reload` コマンドでリロードモードを切り替えることもできます。

リロード後にカスタムコードを実行するには（例：キャッシュデータの更新）、`@cli.tui_on_reload` デコレータを使用してください：

```python
@cli.tui_on_reload
def on_reload():
    print('Code reloaded!')
```

### 高度な例：HTTPベンチマーク

TUIモードはリッチなインタラクティブ表示のためにカスタムTextualウィジェットのマウントをサポートします。この例ではライブ進行グリッドでHTTPライブラリをベンチマークします：

<img alt="HTTPベンチマークTUI" src="https://github.com/Andarius/piou/raw/master/docs/static/bench_1000.gif" width="700"/>

`TuiContext`とカスタムウィジェットを使用した完全な実装は[examples/http_bench_tui.py](https://raw.githubusercontent.com/Andarius/piou/master/examples/http_bench_tui.py)を参照してください。

## 開発

### テストの実行

```bash
uv run pytest
```

### ドキュメントの生成

```bash
# Build docs
uv run --group docs mkdocs build

# Serve locally
uv run --group docs mkdocs serve
```

### スクリーンショットとGIFの生成

ターミナルの録画は[VHS](https://github.com/charmbracelet/vhs)で作成されます。まずはインストールしてください：

```bash
# Ubuntu/Debian
sudo apt install vhs ttyd

# macOS
brew install vhs

# Or via Go
go install github.com/charmbracelet/vhs@latest
```

次に、テープファイルから録音を生成します：

```bash
vhs docs/static/tui-demo.tape
```
テープファイルは `docs/static/` にあり、GIFを生成するスクリプト化された端末セッションを定義しています。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-31

---