# QuickSand バージョン 2

QuickSand Python パッケージおよびコマンドラインツール

QuickSand は、疑わしいマルウェアドキュメントを解析し、さまざまなエンコーディングや圧縮のストリーム内のエクスプロイトを特定するための Python ベースの解析フレームワークです。QuickSand はドキュメント、PDF、Mime/Email、Postscript およびその他の一般的なフォーマットをサポートします。組み込みのコマンドラインツールは、単一のドキュメントまたはドキュメントのディレクトリを処理できます。

QuickSand は、ドキュメントや PDF のデコードされたストリーム内を Yara シグネチャを使ってスキャンし、エクスプロイトや高リスクのアクティブコンテンツを特定します。

インストールなしで試せるホスティング版が [scan.tylabs.com](https://scan.tylabs.com/) にあります。


## ファイル一覧:

- src/quicksand/quicksand.py: メインの quicksand クラスおよび CLI ツール

- src/quicksand/quicksand_exe.yara: 実行可能ファイル検出用の Yara ルール

- src/quicksand/quicksand_exploits.yara: ドキュメント内のエクスプロイト検出用の Yara ルール

- src/quicksand/quicksand_pdf.yara: PDF 内のエクスプロイト検出用の Yara ルール

- bin/quicksand: コマンドラインツール

- requirements.txt: Python の依存パッケージ

- [lambda/](https://raw.githubusercontent.com/tylabs/quicksand/main/lambda/README.md) オプションの AWS Lambda 関数


### 制作者の皆様に感謝:

- pdfreader

- oletools

- cryptography

- zipfile38

- olefile

- yara-python (バージョン 4.3.0 以上が必要)

- yara


## pip を使った Pypi からのインストール

```
pip3 install quicksand
```


## Upgrade from Pypi using pip

```
pip3 install --upgrade quicksand
```

## ソースからのインストール

GitHubからダウンロードしたuicksand-main.zipのようなソースからインストールしたい場合：

```
pip3 install quicksand-main.zip
```

## コマンドラインの使い方

quicksand用のコマンドラインツールで、jsonまたはtxtの結果を処理して出力します。


```
usage: quicksand [-h] [-v] [-c] [-y] [-t TIMEOUT] [-e EXPLOIT] [-x EXE] [-a PDF] [-f {json,txt}] [-o OUT] [-p PASSWORD]
                 [-d DROPDIR]
                 document

QuickSand Document and PDF maldoc analysis tool.

positional arguments:
  document              document or directory to scan

optional arguments:
  -h, --help            show this help message and exit
  -v, --verbose         increase output verbosity
  -c, --capture         capture stream content
  -y, --yara            capture yara matched strings
  -t TIMEOUT, --timeout TIMEOUT
                        timeout in seconds
  -e EXPLOIT, --exploit EXPLOIT
                        yara exploit signatures
  -x EXE, --exe EXE     yara executable signatures
  -a PDF, --pdf PDF     yara PDF signatures
  -f {json,txt}, --format {json,txt}
                        output format
  -o OUT, --out OUT     save output to this filename
  -p PASSWORD, --password PASSWORD
                        password to decrypt ole or pdf
  -d DROPDIR, --dropdir DROPDIR
                        save objects to this directory

```

### 単一ファイルの処理

```
quicksand document.doc
```

### ファイルのディレクトリを処理する

```
quicksand malware/
```

## Python モジュールの使用方法


### メモリからのファイル読み込み

```
from quicksand.quicksand import quicksand
import pprint

qs = quicksand(data, timeout=18, strings=True)
qs.process()
pprint.pprint(qs.results)
```

### ファイル名を使用した処理

```
from quicksand.quicksand import quicksand

qs2 = quicksand("file.doc")
qs2.process()
qs.results
```

### ディレクトリを処理する

```
from quicksand.quicksand import quicksand
qs = quicksand.readDir("malware")
qs
```
ファイル名をキー、`qs_results`を値とする辞書を返します。


### オプショナルな初期化値

- capture: True|False 抽出されたストリームの内容を返す

- debug: True|False デバッグメッセージを標準出力に表示する

- exploityara: エクスプロイト用Yaraルールのパス

- execyara: 実行可能ファイル用Yaraルールのパス

- pdfyara: PDFエクスプロイト用Yaraルール

- password: 暗号化されたドキュメント/PDFのパスワード

- timeout: 処理のタイムアウト：0で無制限


## スコアリング

ドキュメントは関連するYaraシグネチャのメタデータ内のランク値に基づいてスコアリングされます。

加えて、各シグネチャは検出された項目がエクスプロイト、警告、またはリスキーな特徴かどうかを定義します。結果の解釈方法の詳細については、[https://scan.tylabs.com/howto](https://quicksand.io/howto)をご覧ください。

独自のシグネチャを追加する場合、動作に必要な追加のメタデータを含める必要はありません。

### MacOSのzlib問題

MacOSユーザーは、MacOS 10.4以降のOpenSSLヘッダーの欠如により、zlibの問題（PDF FlateDecodeなど）が発生する場合があります。


```
zlib.error: Error -3 while decompressing data: unknown compression method
zlib.error: Error -3 while decompressing data: incorrect header check
```

一つの解決策は、Brew.shでzlibをインストールし、pyenvを使用してPython 3を再インストールすることです:

```
export LDFLAGS="-L/usr/local/opt/zlib/lib"
export CPPFLAGS="-I/usr/local/opt/zlib/include"
pyenv install 3.8.5
```

## Quicksandを使っていますか？

[お知らせください](https://tylabs.com) @tylabs


## 問題とプロジェクトのホーム

[QuickSand GitHub](https://github.com/tylabs/quicksand/)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---