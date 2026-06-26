# dblp-to-csv
Convertir un archivo XML de DBLP (Bibliografía de Ciencias de la Computación) a formato CSV.

## Uso
Para cada elemento en el archivo XML, como article, book, phdthesis, etc., esta herramienta generará un archivo de salida.
Cada archivo de salida de elemento contiene solo las columnas necesarias para ese elemento, es decir, cada columna tendrá al menos una fila no vacía.
Cuando se encuentran múltiples etiquetas de atributos similares en un elemento, por ejemplo, varios autores de un artículo, esos valores se incluirán dentro de un arreglo "[item1|item2|...|itemN]".
Al llamar a la herramienta, pase como parámetros el archivo XML de entrada, el archivo DTD y el formato deseado para el nombre del archivo de salida; por ejemplo, output.csv generará output_article.csv, output_book.csv, etc.

## Cabeceras anotadas opcionales por tipo
Opcionalmente, se puede usar --annotate para habilitar la anotación de tipo. Por elemento, esto creará un archivo de cabecera adicional que contiene una sola línea con una cabecera anotada. Esta cabecera anotada tiene el formato name:type por columna o name:type[] para columnas que contienen al menos una entrada de arreglo. El tipo puede ser integer, float, boolean o string.

## Opciones de línea de comandos
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
## Ejemplo

```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
Este comando analizará el archivo XML de DBLP dblp.xml utilizando el archivo DTD dblp.dtd. Debido a que se usa la opción ```--annotate```, también se generarán anotaciones de tipo. Se proporciona la opción ```--relations```, por lo que los atributos de elemento author, journal, publisher, school y editor se tratarán como nodos y se crearán relaciones entre estos nodos y los elementos que los contenían. La cadena ```output.csv``` se usa como patrón, por lo que los archivos generados se nombrarán ```output_article.csv``` etc. Las anotaciones de tipo se almacenarán en archivos con nombres similares, por ejemplo, ```output_article_header.csv```. Dado que también pasamos la opción ```--neo4j```, las anotaciones de tipo serán compatibles con Neo4j, y la herramienta genera un script de shell llamado ```neo4j_import.sh``` que se puede ejecutar para importar los archivos CSV generados en una base de datos gráfica Neo4j utilizando la herramienta de importación masiva ```neo4j-admin import```.

## Requisitos
- Python 3.7+ (use ```python3 --version``` para confirmar)
- lxml (```pip3 install lxml```)
- O: ```pip3 install -r requirements.txt```

## Enlaces
- Para aprender más sobre DBLP: https://dblp.dagstuhl.de
- Descargar los archivos XML de DBLP en: https://dblp.dagstuhl.de/xml/
  - Para desempaquetar el archivo XML comprimido: ```gunzip dblp.xml.gz```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---