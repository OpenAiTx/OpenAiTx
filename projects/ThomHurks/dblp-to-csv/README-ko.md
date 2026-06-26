# dblp-to-csv
DBLP(컴퓨터 과학 참고 문헌) XML 파일을 CSV 형식으로 변환합니다.

## 사용법
XML 파일의 각 요소, 예를 들어 article, book, phdthesis 등에 대해 이 도구는 출력 파일을 생성합니다.
각 요소 출력 파일은 해당 요소에 필요한 열만 포함하며, 각 열은 적어도 한 행에서 비어 있지 않습니다.
요소에서 여러 유사 속성 태그가 발견되면, 예를 들어 논문의 여러 저자, 해당 값들은 배열 "[item1|item2|...|itemN]"로 포함됩니다.
도구를 호출할 때 입력 XML 파일, DTD 파일 및 원하는 출력 파일 이름 형식을 매개변수로 전달합니다; 예를 들어 output.csv는 output_article.csv, output_book.csv 등을 생성합니다.

## 선택적 타입 주석 헤더
선택적으로 --annotate를 사용하여 타입 주석을 활성화할 수 있습니다. 요소별로, 이 옵션은 주석이 달린 헤더가 포함된 한 줄짜리 추가 헤더 파일을 생성합니다. 이 주석 헤더는 각 열에 대해 name:type 형식 또는 배열 항목이 하나 이상 있는 열에 대해 name:type[] 형식입니다. 타입은 integer, float, boolean 또는 string일 수 있습니다.

## 명령줄 옵션
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
## 예제

```
chmod +x XMLToCSV.py
./XMLToCSV.py --annotate --neo4j dblp.xml dblp.dtd output.csv --relations author:authored_by journal:published_in publisher:published_by school:submitted_at editor:edited_by cite:has_citation series:is_part_of
```
이 명령어는 DTD 파일 dblp.dtd를 사용하여 DBLP XML 파일 dblp.xml을 파싱합니다. ```--annotate``` 옵션이 사용되었기 때문에 타입 주석도 생성됩니다. ```--relations``` 옵션이 주어졌으므로, author, journal, publisher, school, editor 요소 속성들이 노드로 처리되고, 이 노드들과 이를 포함하는 요소들 사이에 관계가 생성됩니다. 문자열 ```output.csv```가 패턴으로 사용되어 생성된 파일들은 ```output_article.csv``` 등으로 이름이 지정됩니다. 타입 주석은 유사한 이름의 파일들, 예를 들어 ```output_article_header.csv```에 저장됩니다. 또한 ```--neo4j``` 옵션도 전달되었기 때문에 타입 주석은 Neo4j 호환 형식으로 생성되며, 도구는 ```neo4j-admin import``` 대량 가져오기 도구를 사용하여 생성된 CSV 파일들을 Neo4j 그래프 데이터베이스에 가져오기 위해 실행할 수 있는 ```neo4j_import.sh```라는 셸 스크립트를 생성합니다.

## 요구사항
- Python 3.7+ (확인을 위해 ```python3 --version``` 사용)
- lxml (```pip3 install lxml``` )
- 또는: ```pip3 install -r requirements.txt```

## 링크
- DBLP에 대해 더 알아보기: https://dblp.dagstuhl.de
- DBLP XML 파일 다운로드: https://dblp.dagstuhl.de/xml/
  - gzipped XML 파일 압축 해제: ```gunzip dblp.xml.gz```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-26

---