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


Flink CDC is een gedistribueerd data-integratiehulpmiddel voor real-time data en batchdata. Flink CDC brengt de eenvoud 
en elegantie van data-integratie via YAML om de databeweging en transformatie te beschrijven in een 
[Data Pipeline](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC geeft prioriteit aan efficiënte end-to-end data-integratie en biedt verbeterde functionaliteiten zoals 
volledige database-synchronisatie, sharding-tabelsynchronisatie, schema-evolutie en datatransformatie.

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Snelstartgids

Flink CDC biedt een CdcUp CLI-hulpprogramma om een playground-omgeving te starten en Flink CDC-jobs uit te voeren.
Je hebt een werkende Docker- en Docker Compose-omgeving nodig om dit te gebruiken.

1. Voer `git clone https://github.com/apache/flink-cdc.git --depth=1` uit om een kopie van de Flink CDC-broncode op te halen.
2. Voer `cd tools/cdcup/ && ./cdcup.sh init` uit om met het CdcUp-hulpmiddel een playground-omgeving te starten.
3. Voer `./cdcup.sh up` uit om de docker-containers te starten, en wacht tot deze klaar zijn.
4. Voer `./cdcup.sh mysql` uit om een MySQL-sessie te openen, en maak ten minste één tabel aan.

```sql
-- initialiseer db en tabel
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- voeg testdata in
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- controleer of de gegevens succesvol zijn ingevoerd
SELECT * FROM test_table;
```

5. Voer `./cdcup.sh pipeline pipeline-definition.yaml` uit om de pipeline-job in te dienen. Je kunt het pipeline-definitiebestand ook bewerken voor verdere configuraties.
6. Voer `./cdcup.sh flink` uit om toegang te krijgen tot de Flink Web UI.

### Aan de slag

1. Bereid een [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) cluster voor en stel de `FLINK_HOME`-omgevingsvariabele in.
2. [Download](https://github.com/apache/flink-cdc/releases) het Flink CDC-tarbestand, pak het uit en plaats de jars van de pipelineconnector in de Flink `lib`-directory.

> Als je macOS of Linux gebruikt, kun je met `brew install apache-flink-cdc` Flink CDC en compatibele connectors snel installeren.

3. Maak een **YAML**-bestand aan om de databron en datasink te beschrijven. In het volgende voorbeeld worden alle tabellen onder de MySQL app_db-database gesynchroniseerd naar Doris :
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
4. Dien de pipeline-job in met het script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Bekijk de uitvoeringsstatus van de job via de Flink WebUI of de downstream-database.

Probeer het zelf met onze meer gedetailleerde [tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md). 
Je kunt ook de [connectoroverzicht](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) bekijken voor een uitgebreid overzicht van de momenteel beschikbare connectors en meer gedetailleerde configuraties.

### Word lid van de community

Er zijn veel manieren om deel te nemen aan de Apache Flink CDC-community. De
[mailinglijsten](https://flink.apache.org/what-is-flink/community/#mailing-lists) zijn de primaire plek waar alle Flink
committers aanwezig zijn. Voor gebruikerssupport en vragen gebruik je de user mailinglist. Als je een probleem hebt gevonden in Flink CDC,
maak dan een [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) aan en tag deze met het `Flink CDC`-label.   
Bugs en feature requests kunnen zowel op de dev-mailinglist als op Jira worden besproken.



### Bijdragen

Bijdragen aan Flink CDC zijn welkom, zie onze [Developer Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
en [APIs Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Licentie

[Apache 2.0 License](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Speciale dank

De Flink CDC-community verwelkomt iedereen die wil bijdragen, of het nu gaat om het melden van bugs,
het verbeteren van de documentatie, of het indienen van codebijdragen voor bugfixes, toevoegingen aan tests, of de ontwikkeling van nieuwe functies.     
Dank aan alle bijdragers voor hun enthousiaste inzet.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---