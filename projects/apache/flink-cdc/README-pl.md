<p align="center">
  <a href="https://nightlies.apache.org/flink/flink-cdc-docs-stable/"><img src="https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/flinkcdc-logo.png" alt="Flink CDC" style="width: 375px;"></a>
</p>
<p align="center">
<a href="https://github.com/apache/flink-cdc/" target="_blank">
    <img src="https://img.shields.io/github/stars/apache/flink-cdc?style=social&label=Star&maxAge=2592000" alt="Test">
</a>
<a href="https://github.com/apache/flink-cdc/releases" target="_blank">
    <img src="https://img.shields.io/github/v/release/apache/flink-cdc?color=yellow" alt="Release">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci.yml?branch=master" alt="Build">
</a>
<a href="https://github.com/apache/flink-cdc/actions/workflows/flink_cdc_ci_nightly.yml" target="_blank">
    <img src="https://img.shields.io/github/actions/workflow/status/apache/flink-cdc/flink_cdc_ci_nightly.yml?branch=master&label=nightly" alt="Nightly Build">
</a>
<a href="https://github.com/apache/flink-cdc/tree/master/LICENSE" target="_blank">
    <img src="https://img.shields.io/static/v1?label=license&message=Apache License 2.0&color=white" alt="License">
</a>
</p>


Flink CDC to rozproszone narzędzie do integracji danych dla danych czasu rzeczywistego oraz danych wsadowych. Flink CDC wprowadza prostotę 
i elegancję integracji danych za pomocą YAML do opisu przepływu i transformacji danych w 
[Potoku Danych](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC stawia na wydajną integrację danych end-to-end i oferuje rozszerzone funkcjonalności takie jak 
pełna synchronizacja bazy danych, synchronizacja tabel shardowanych, ewolucja schematów oraz transformacja danych.

![Projekt architektury Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Przewodnik szybkiego startu

Flink CDC dostarcza narzędzie CLI CdcUp do uruchamiania środowiska testowego oraz wykonywania zadań Flink CDC.
Aby z niego korzystać, musisz mieć zainstalowane i działające środowisko Docker oraz Docker Compose.

1. Uruchom `git clone https://github.com/apache/flink-cdc.git --depth=1`, aby pobrać kod źródłowy Flink CDC.
2. Uruchom `cd tools/cdcup/ && ./cdcup.sh init`, aby użyć narzędzia CdcUp do uruchomienia środowiska testowego.
3. Uruchom `./cdcup.sh up`, aby wystartować kontenery dockera i poczekaj, aż będą gotowe.
4. Uruchom `./cdcup.sh mysql`, aby otworzyć sesję MySQL i utwórz przynajmniej jedną tabelę.

```sql
-- inicjalizacja bazy danych i tabeli
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- wstaw dane testowe
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- sprawdź, czy dane zostały poprawnie wstawione
SELECT * FROM test_table;
```

5. Uruchom `./cdcup.sh pipeline pipeline-definition.yaml`, aby wysłać zadanie potoku. Możesz także edytować plik definicji potoku w celu dalszej konfiguracji.
6. Uruchom `./cdcup.sh flink`, aby uzyskać dostęp do Flink Web UI.

### Pierwsze kroki

1. Przygotuj klaster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) i ustaw zmienną środowiskową `FLINK_HOME`.
2. [Pobierz](https://github.com/apache/flink-cdc/releases) paczkę Flink CDC, rozpakuj ją i umieść pliki jar konektora pipeline w katalogu `lib` Flinka.

> Jeśli korzystasz z macOS lub Linuksa, możesz użyć `brew install apache-flink-cdc`, aby szybko zainstalować Flink CDC oraz kompatybilne konektory.

3. Utwórz plik **YAML** opisujący źródło i odbiornik danych. Poniższy przykład synchronizuje wszystkie tabele z bazy MySQL app_db do Doris:
  ```yaml
   source:
     type: mysql
     hostname: localhost
     port: 3306
     username: root
     password: 123456
     tables: app_db.\.*

   sink:
     type: doris
     fenodes: 127.0.0.1:8030
     username: root
     password: ""

   transform:
     - source-table: adb.web_order01
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 10 AND order_id > 100
       description: project fields and filter
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: project fields and filter

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Sync MySQL Database to Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Wyślij zadanie potoku używając skryptu `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Obserwuj status wykonania zadania poprzez Flink WebUI lub docelową bazę danych.

Wypróbuj samodzielnie z naszym bardziej szczegółowym [samouczkiem](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md). 
Możesz także zobaczyć [przegląd konektorów](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md), aby przejrzeć pełny katalog 
aktualnie dostępnych konektorów i poznać szczegółowe konfiguracje.

### Dołącz do społeczności

Istnieje wiele sposobów, aby uczestniczyć w społeczności Apache Flink CDC. 
[Listy mailingowe](https://flink.apache.org/what-is-flink/community/#mailing-lists) to główne miejsce, gdzie obecni są wszyscy komiterzy Flink.
W przypadku wsparcia użytkowników i pytań użyj listy mailingowej użytkowników. Jeśli znalazłeś problem w Flink CDC,
utwórz [zgłoszenie Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) i oznacz je tagiem `Flink CDC`.   
Błędy i prośby o nowe funkcje można omawiać na liście mailingowej deweloperów lub na Jira.



### Współtworzenie

Zapraszamy do współtworzenia Flink CDC, zapoznaj się z naszym [Przewodnikiem Dewelopera](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
oraz [Przewodnikiem po API](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Licencja

[Licencja Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Szczególne podziękowania

Społeczność Flink CDC zaprasza każdego, kto chce się przyczynić — czy to poprzez zgłaszanie błędów,
ulepszanie dokumentacji, czy wkładanie kodu dotyczącego poprawek, rozszerzeń testowych lub rozwoju nowych funkcji.     
Dziękujemy wszystkim współtwórcom za ich entuzjastyczny wkład.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---