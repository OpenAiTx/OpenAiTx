# Shape up ダウンローダー

## 何をするのか？
これはシンプルなCLIアプリケーションで、[Basecampの優れた無料Shape Up本](https://basecamp.com/shapeup)
を単一の自己完結型HTMLファイルにダウンロードします。
* base64画像を使用
* ドキュメント内リンクを使用
* 必要最小限のCSSのみ使用

## なぜこれが存在するのか？
この本は現在HTML形式で利用可能で、各章が一つのドキュメントとなっており、すべての章が一つの自己完結型ファイルにまとめられたPDFドキュメントもあります。本を読んでいるときに電子書籍リーダーで読みたいと思いましたが、
KindleでPDFを読むのはひどく、PDFをepubやmobiに変換するのもせいぜい不安定です。この特定のPDFを生成するために使われたソフトウェアは、いくつかの文字の組み合わせ（例："tf"）を合字で一つのUTF-8コードポイントにまとめています。これが多くの変換ソフトを混乱させます。

したがって、このプロジェクトはすべてのウェブドキュメントをスタイリングなしで単一の自己完結型ファイルにダウンロードして結合するために生まれました。
このHTML形式で本を読むことが意図されているわけではありませんが、さらなる変換ステップの基礎として使用できます。

ファイルをより有用な形式に変換するには、calibreの`ebook-convert`ユーティリティの使用をお勧めします：



```bash
$ ebook-convert shape-up.html shape-up.epub \
    --authors "Ryan Singer" \
    --title "Shape Up: Stop Running in Circles and Ship Work that Matters" \
    --book-producer "Basecamp" \
    --publisher "Basecamp" \
    --language "en"
```
## このHTML/EPUB/MOBIの単一ページ版はどこでダウンロードできますか？
これらのファイルをホストすることの法的影響についてはよくわからないため、私は行っていません。
自分でダウンロードするためのコードはこちらにありますが、自分で使用する必要があります。

## 使用方法
### ローカルPHP

1. [PHPをインストールする](https://www.php.net/manual/en/install.php)
2. [Composerをインストールする](https://getcomposer.org/download/)
3. `php composer.phar install` を実行する（またはComposerがグローバルにインストールされている場合は `composer install`）
4. `php cli.php download:single-html` を実行する

これにより、現在のディレクトリに `shape-up.html` ファイルが作成されます。
以上です。

### Docker方式

PHPを全く扱わずに済む方法があります。そのためにはDockerエンジンがインストールされていれば十分です。

使用方法

```
docker run -it --rm -v $(pwd)/output:/app/output thej6s/shape-up-downloader

```
これにより、./output ディレクトリに `shape-up.html` ファイルが作成されます。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-19

---