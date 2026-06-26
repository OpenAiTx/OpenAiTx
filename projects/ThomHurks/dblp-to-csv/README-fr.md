# dblp-to-csv
Convertir un fichier XML DBLP (Bibliographie en informatique) au format CSV.

## Utilisation
Pour chaque élément dans le fichier XML, comme article, livre, thèse de doctorat, etc., cet outil générera un fichier de sortie.
Chaque fichier de sortie d’élément contient uniquement les colonnes nécessaires pour cet élément, ce qui signifie que chaque colonne sera non vide au moins sur une ligne.
Lorsque plusieurs balises d’attribut similaires sont rencontrées sur un élément, par exemple plusieurs auteurs d’un article, ces valeurs seront contenues dans un tableau "[item1|item2|...|itemN]".
Lors de l’appel de l’outil, passez en paramètres le fichier XML d’entrée, le fichier DTD et le format de nom de fichier de sortie souhaité ; par exemple output.csv générera output_article.csv, output_book.csv, etc.

## En-têtes optionnels avec annotation de type
Optionnellement, on peut utiliser --annotate pour activer l’annotation de type. Par élément, cela créera un fichier d’en-tête supplémentaire contenant une seule ligne avec un en-tête annoté. Cet en-tête annoté est au format nom:type par colonne ou nom:type[] pour les colonnes contenant au moins une entrée de tableau. Le type peut être integer, float, boolean ou string.

## Options en ligne de commande
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

## Exemple
```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
Cette commande analysera le fichier XML DBLP dblp.xml en utilisant le fichier DTD dblp.dtd. Parce que l'option ```--annotate``` est utilisée, des annotations de type seront également générées. L'option ```--relations``` est donnée, donc les attributs d'élément author, journal, publisher, school et editor seront traités comme des nœuds et des relations seront créées entre ces nœuds et les éléments qui les contenaient. La chaîne ```output.csv``` est utilisée comme motif, donc les fichiers générés seront nommés ```output_article.csv``` etc. Les annotations de type seront stockées dans des fichiers nommés de manière similaire, par exemple ```output_article_header.csv```. Comme nous avons également passé l'option ```--neo4j```, les annotations de type seront compatibles Neo4j, et l'outil génère un script shell appelé ```neo4j_import.sh``` qui peut être exécuté pour importer les fichiers CSV générés dans une base de données graphique Neo4j en utilisant l'outil d'importation en masse ```neo4j-admin import```.

## Exigences
- Python 3.7+ (utilisez ```python3 --version``` pour confirmer)
- lxml (```pip3 install lxml```)
- Ou : ```pip3 install -r requirements.txt```

## Liens
- Pour en savoir plus sur DBLP : https://dblp.dagstuhl.de
- Télécharger les fichiers XML DBLP sur : https://dblp.dagstuhl.de/xml/
  - Pour décompresser le fichier XML compressé : ```gunzip dblp.xml.gz```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---