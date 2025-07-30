<h1 align="center">
  <a href="https://github.com/tbruno25/can-explorer">
    <!-- ここにロゴのパスを指定してください -->
    <img src="https://github.com/Tbruno25/can-explorer/raw/main/docs/images/logo.png" alt="Logo" width="200" height="200">
  </a>
</h1>

<div align="center">
  can-explorer
  <br />
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=bug&template=01_BUG_REPORT.md&title=bug%3A+">バグを報告する</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=enhancement&template=02_FEATURE_REQUEST.md&title=feature%3A+">機能をリクエストする</a>
  ·
  <a href="https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+">質問する</a>
</div>

<div align="center">
<br/>


[![PyPI version](https://img.shields.io/pypi/v/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Python Versions](https://img.shields.io/pypi/pyversions/can-explorer?color=mediumseagreen)](https://pypi.org/project/can-explorer/)
[![Stars](https://img.shields.io/github/stars/tbruno25/can-explorer?color=mediumseagreen)](https://github.com/Tbruno25/can-explorer/stargazers)
</div>

---

## 概要

`can-explorer` はリバースエンジニアリング支援のために設計されたCANバス可視化ツールです。

![Demo](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/demo.gif)

### これはどう役立つのか？
各CAN IDごとにすべてのペイロードを継続的にプロットすることで、特定の動作に対応する傾向を特定しやすくなります。

このアプローチを使ってどのIDに速度計データが含まれているかを見つける実例については、私が書いたこの[以前の記事](https://tbruno25.medium.com/car-hacking-faster-reverse-engineering-using-canopy-be1955843d57)をご参照ください。

### 使用技術


[![DearPyGui](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/dearpygui-logo.png)](https://github.com/hoffstadt/DearPyGui)
[![PythonCan](https://github.com/Tbruno25/can-explorer/raw/main/docs/images/pythoncan-logo.png)](https://github.com/hardbyte/python-can)

## はじめに

### インストール

[pipx](https://pypa.github.io/pipx/) の使用を推奨しますが、`pyproject.toml`ファイルをサポートする任意のパッケージマネージャーを使用できます。


```sh
pipx install can-explorer
``` 

## 使用法

GUIは、以下のいずれかのコマンドをターミナルから実行することで起動できます。
```sh 
can-explorer
``` 

```sh 
python3 -m can_explorer
``` 
ビューアを起動する前に、***必ず***設定タブに移動し、インターフェースアダプタの設定を入力してバスインスタンスを作成してください。サポートされている各種インターフェースの詳細については、[python-can ドキュメント](https://python-can.readthedocs.io/en/stable/index.html)を参照してください。 

GUIはデモフラグを付けて起動することもでき、これにより仮想インターフェースオプションが自動選択され、バックグラウンドプロセスでシミュレートされたCANデータのストリーミングが開始されます。


```sh 
can-explorer --demo
``` 

## サポート

メンテナに連絡するには、以下のいずれかの場所をご利用ください：
- [GitHub Issues](https://github.com/tbruno25/can-explorer/issues/new?assignees=&labels=question&template=04_SUPPORT_QUESTION.md&title=support%3A+)
- [このGitHubプロフィール](https://github.com/tbruno25)に記載されている連絡先オプション

can-explorerの積極的な開発を**感謝**または支援したい場合は、プロジェクトに[GitHubスター](https://github.com/tbruno25/can-explorer)を付けることを検討してください。


## 貢献

[貢献ガイドライン](https://raw.githubusercontent.com/Tbruno25/can-explorer/main/docs/CONTRIBUTING.md)をお読みください。

すべての著者と貢献者の完全なリストは、[貢献者ページ](https://github.com/tbruno25/can-explorer/contributors)をご覧ください。

## ライセンス

このプロジェクトは**GNU 一般公衆利用許諾契約書 v3**の下でライセンスされています。

詳細については[LICENSE](LICENSE)をご覧ください。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-30

---