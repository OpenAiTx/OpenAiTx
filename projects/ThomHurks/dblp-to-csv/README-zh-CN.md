# dblp-to-csv
将 DBLP（计算机科学文献目录）XML 文件转换为 CSV 格式。

## Usage
对于 XML 文件中的每个元素，如 article、book、phdthesis 等，该工具将生成一个输出文件。
每个元素的输出文件仅包含该元素所需的列，意味着每列至少在一行中非空。
当在元素中遇到多个类似的属性标签时，例如文章的多个作者，这些值将包含在数组中 "[item1|item2|...|itemN]"。
调用该工具时，传入参数为输入的 XML 文件、DTD 文件和所需的输出文件名格式；例如 output.csv 将生成 output_article.csv、output_book.csv 等。

## Optional type annotated headers
可选地，可以使用 --annotate 启用类型注释。每个元素将创建一个额外的头文件，包含一行带注释的表头。该注释表头的格式为每列的 name:type，或者对于包含至少一个数组条目的列为 name:type[]。类型可以是 integer、float、boolean 或 string。

## Commandline options
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

## 示例
```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
此命令将使用DTD文件dblp.dtd解析DBLP XML文件dblp.xml。由于使用了```--annotate```选项，也将生成类型注释。给定了```--relations```选项，因此元素属性author、journal、publisher、school和editor将被视为节点，并将在这些节点与包含它们的元素之间创建关系。字符串```output.csv```用作模式，因此生成的文件将被命名为```output_article.csv```等。类型注释将存储在类似命名的文件中，例如```output_article_header.csv```。由于我们还传递了```--neo4j```选项，类型注释将兼容Neo4j，并且该工具生成了一个名为```neo4j_import.sh```的shell脚本，可以运行该脚本使用```neo4j-admin import```批量导入工具将生成的CSV文件导入到Neo4j图数据库中。

## 要求
- Python 3.7+（使用```python3 --version```确认）
- lxml（```pip3 install lxml```）
- 或：```pip3 install -r requirements.txt```

## 链接
- 了解更多关于DBLP的信息：https://dblp.dagstuhl.de
- 下载DBLP XML文件：https://dblp.dagstuhl.de/xml/
  - 解压gzipped XML文件：```gunzip dblp.xml.gz```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---