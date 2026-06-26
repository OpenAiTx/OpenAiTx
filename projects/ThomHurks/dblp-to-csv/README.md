# dblp-to-csv
Convert a DBLP (Computer Science Bibliography) XML file to CSV format.

## Usage
For each element in the XML file, so article, book, phdthesis, etc, this tool will generate an output file.
Each element output file contains only the necessary columns for that element, meaning each column will be non-empty on at least one row.
When multiple similar attribute tags are encountered on an element, e.g. multiple authors of an article, then those values will be contained within an array "[item1|item2|...|itemN]".
When calling the tool, pass as parameters the input XML file, the DTD file and the desired output file name format; e.g. output.csv will generate output_article.csv, output_book.csv, etc.

## Optional type annotated headers
Optionally, one can use --annotate to enable type annotation. Per element, this will create an extra header file containing a single line with an annotated header. This annotated header is of the format name:type per column or name:type[] for columns that contain at least one array entry. The type can be integer, float, boolean or string.

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

## Example
```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
This command will parse the DBLP XML file dblp.xml using the DTD file dblp.dtd. Because the ```--annotate``` option is used, type annotations will be generated as well. The ```--relations``` option is given, so the element attributes author, journal, publisher, school and editor will be treated as nodes and relations will be created between these nodes and the elements that contained them. The string ```output.csv``` is used as a pattern, so generated files will be named ```output_article.csv``` etc. The type annotations will be stored in similarly named files, for example ```output_article_header.csv```. Since we also passed the ```--neo4j``` option, the type annotations will be Neo4j compatible, and the tool generates a shell script called ```neo4j_import.sh``` that can be run to import the generated CSV files into a Neo4j graph database using the ```neo4j-admin import``` bulk importer tool.

## Requirements
- Python 3.7+ (use ```python3 --version``` to confirm)
- lxml (```pip3 install lxml```)
- Or: ```pip3 install -r requirements.txt```

## Links
- To learn more about DBLP: https://dblp.dagstuhl.de
- Download the DBLP XML files at: https://dblp.dagstuhl.de/xml/
  - To unpack the gzipped XML file: ```gunzip dblp.xml.gz```
