# dblp-to-csv
DBLP（コンピュータサイエンス文献目録）のXMLファイルをCSV形式に変換します。

## 使い方
XMLファイル内の各要素、例えばarticle、book、phdthesisなどに対して、このツールは出力ファイルを生成します。
各要素の出力ファイルには、その要素に必要なカラムのみが含まれ、各カラムは少なくとも1行で空でない値を持ちます。
要素に複数の類似した属性タグがある場合、例えば記事の複数の著者など、それらの値は配列 "[item1|item2|...|itemN]" の形式で含まれます。
ツールを呼び出す際には、入力XMLファイル、DTDファイル、そして希望する出力ファイル名の形式をパラメータとして渡します。例としてoutput.csvはoutput_article.csv、output_book.csvなどを生成します。

## オプションの型注釈付きヘッダー
オプションで、--annotateを使用して型注釈を有効にできます。要素ごとに、注釈付きヘッダーを含む1行のみの追加ヘッダーファイルを作成します。この注釈付きヘッダーは、各カラムごとにname:typeの形式、配列を含むカラムにはname:type[]の形式です。型はinteger、float、boolean、またはstringです。

## コマンドラインオプション
```
usage: XMLToCSV.py [-h] [--annotate] [--neo4j]
                   [--relations RELATIONS [RELATIONS ...]]
                   xml_filename dtd_filename outputfile

Parse the DBLP XML file and convert it to CSV

positional arguments:
  xml_filename          The XML file that will be parsed
  dtd_filename          The DTD file used to parse the XML file
  outputfile            The output CSV file

optional arguments:
  -h, --help            show this help message and exit
  --annotate            Write a separate annotated header with type
                        information
  --neo4j               Headers become more Neo4J-specific and a neo4j-import
                        shell script is generated for easy importing. Implies
                        --annotate.
  --relations RELATIONS [RELATIONS ...]
                        The element attributes that will be treated as
                        elements, and for which a relation to the parent
                        element will be created. For example, in order to turn
                        the author attribute of the article element into an
                        element with a relation, use "author:authors". The
                        part after the colon is used as the name of the
                        relation.

```
## 例

```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
このコマンドは、DTDファイルdblp.dtdを使用してDBLP XMLファイルdblp.xmlを解析します。```--annotate```オプションが使用されているため、型注釈も生成されます。```--relations```オプションが指定されているので、author、journal、publisher、school、editorの要素属性がノードとして扱われ、これらのノードとそれらを含む要素との間にリレーションが作成されます。文字列```output.csv```がパターンとして使われるため、生成されるファイルは```output_article.csv```などと名付けられます。型注釈は同様の名前のファイル、例えば```output_article_header.csv```に格納されます。さらに```--neo4j```オプションも渡しているため、型注釈はNeo4j互換となり、```neo4j-admin import```のバルクインポーターツールを用いて生成されたCSVファイルをNeo4jグラフデータベースにインポートするためのシェルスクリプト```neo4j_import.sh```が生成されます。

## 必要条件
- Python 3.7以上（```python3 --version```で確認可能）
- lxml（```pip3 install lxml```）
- または：```pip3 install -r requirements.txt```

## リンク
- DBLPについて詳しく知るには：https://dblp.dagstuhl.de
- DBLP XMLファイルのダウンロード：https://dblp.dagstuhl.de/xml/
  - gzipped XMLファイルの解凍：```gunzip dblp.xml.gz```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---