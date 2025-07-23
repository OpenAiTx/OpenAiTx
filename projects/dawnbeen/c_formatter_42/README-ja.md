<p align="center">
  <a style="text-decoration:none" href="https://badge.fury.io/py/c-formatter-42"><img src="https://badge.fury.io/py/c-formatter-42.svg" alt="PyPI version" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-package.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://github.com/dawnbeen/c_formatter_42/actions"><img src="https://github.com/cacharle/c_formatter_42/actions/workflows/python-publish.yml/badge.svg" height="20"></a>
  <a style="text-decoration:none" href="https://pypi.org/project/c-formatter-42/"><img src="https://img.shields.io/pypi/pyversions/c-formatter-42" height="20"></a>
</p>

<br />

<p align="center">
  <img width="65%" align="center" src="https://raw.githubusercontent.com/dawnbeen/c_formatter_42/master/./img/final_back.png">
</p>

# c_formatter_42

42ノームv3に準拠したC言語のコード整形ツールです。
あなたはすでに優れたノーム遵守者であることを知っています。
これは単に利便性のためのものです。

## インストール

Python3.8以上（3.9、3.10、3.11、3.12）を必要とします。

### PyPIからのインストール

```sh
pip3 install c-formatter-42
pip3 install --user c-formatter-42  # If you don't have root privileges
```


Ubuntu 22.04以降（またはPEP 668が有効なDebianベースのシステム）を使用している場合、次のようなエラーが表示されることがあります：

`error: externally-managed-environment`

これを修正するには、`--break-system-packages`フラグを追加してください：


```sh
pip3 install --break-system-packages c-formatter-42
```
### ソースから


```sh
git clone https://github.com/cacharle/c_formatter_42
cd c_formatter_42
pip3 install -e .
```
## 使用法

### コマンドライン


```sh
c_formatter_42 < file.c
python3 -m c_formatter_42 < file.c  # If you get 'command not found' with the previous one

c_formatter_42 --help
usage: c_formatter_42 [-h] [-c] [FILE [FILE ...]]

Format C source according to the norm

positional arguments:
  FILE           File to format inplace, if no file is provided read STDIN

optional arguments:
  -h, --help     show this help message and exit
  -c, --confirm  Ask confirmation before overwriting any file
```


## プラグイン / 拡張機能

### Vim

[`c_formatter_42.vim`](https://github.com/cacharle/c_formatter_42.vim) プラグインをチェックしてください。このプラグインは `c_formatter_42` パッケージをpipで自動的にインストールします。

### Visual Studio Code

1. `c_formatter_42` をインストールします
1. [`keyhr.42-c-format`](https://marketplace.visualstudio.com/items?itemName=keyhr.42-c-format) 拡張機能をインストールします
1. `.vscode/settings.json` で Cファイルのデフォルトフォーマッターとして `keyhr.42-c-format` を設定します


```json
{
  "[c]": {
    "editor.defaultFormatter": "keyhr.42-c-format"
  }
}
```
## 貢献

問題の報告や貢献はお気軽にどうぞ。:)

### テストの実行


```sh
pip3 install tox
tox
tox -e py311  # for a specific python version
```
### 新しいバージョンを展開する


```sh
pip3 install bumpversion
bumpversion [major|minor|patch]
git push
git push --tags
```


次のURLにアクセスしてください: <https://github.com/dawnbeen/c_formatter_42/tags> そして、先ほど作成したタグをクリックします。  
次に `Create release from tag` をクリックすると、パイプラインがそのバージョンのビルドとデプロイを行います。  



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---