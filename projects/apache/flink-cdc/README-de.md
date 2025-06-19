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


Flink CDC ist ein verteiltes Datenintegrations-Tool für Echtzeit- und Batch-Daten. Flink CDC bringt die Einfachheit 
und Eleganz der Datenintegration über YAML mit, um die Datenbewegung und -transformation in einer 
[Data Pipeline](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md) zu beschreiben.


Flink CDC priorisiert eine effiziente End-to-End-Datenintegration und bietet erweiterte Funktionalitäten wie 
vollständige Datenbanksynchronisation, Sharding-Tabellensynchronisation, Schema-Evolution und Datentransformation.

![Flink CDC Framework Design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Schnellstart-Anleitung

Flink CDC stellt ein CdcUp CLI-Tool zur Verfügung, um eine Playground-Umgebung zu starten und Flink CDC Jobs auszuführen.
Sie benötigen eine funktionierende Docker- und Docker Compose-Umgebung, um es zu verwenden.

1. Führen Sie `git clone https://github.com/apache/flink-cdc.git --depth=1` aus, um eine Kopie des Flink CDC-Quellcodes zu erhalten.
2. Führen Sie `cd tools/cdcup/ && ./cdcup.sh init` aus, um mit dem CdcUp-Tool eine Playground-Umgebung zu starten.
3. Führen Sie `./cdcup.sh up` aus, um die Docker-Container zu starten, und warten Sie, bis diese bereit sind.
4. Führen Sie `./cdcup.sh mysql` aus, um eine MySQL-Sitzung zu öffnen, und erstellen Sie mindestens eine Tabelle.

```sql
-- Datenbank und Tabelle initialisieren
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- Testdaten einfügen
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- Überprüfen, ob die Daten erfolgreich eingefügt wurden
SELECT * FROM test_table;
```

5. Führen Sie `./cdcup.sh pipeline pipeline-definition.yaml` aus, um den Pipeline-Job einzureichen. Sie können die Pipeline-Definitionsdatei auch für weitere Konfigurationen anpassen.
6. Führen Sie `./cdcup.sh flink` aus, um auf die Flink Web UI zuzugreifen.

### Erste Schritte

1. Bereiten Sie einen [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) Cluster vor und setzen Sie die Umgebungsvariable `FLINK_HOME`.
2. [Laden Sie](https://github.com/apache/flink-cdc/releases) das Flink CDC-Tar herunter, entpacken Sie es und legen Sie die JARs des Pipeline-Connectors im Flink-`lib`-Verzeichnis ab.

> Wenn Sie macOS oder Linux verwenden, können Sie mit `brew install apache-flink-cdc` Flink CDC und kompatible Konnektoren schnell installieren.

3. Erstellen Sie eine **YAML**-Datei, um die Datenquelle und das Datenziel zu beschreiben. Im folgenden Beispiel werden alle Tabellen der MySQL-Datenbank app_db nach Doris synchronisiert:
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
4. Reichen Sie den Pipeline-Job mit dem Skript `flink-cdc.sh` ein.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Überwachen Sie den Ausführungsstatus des Jobs über die Flink WebUI oder die Zieldatenbank.

Probieren Sie es selbst mit unserem ausführlicheren [Tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) aus. 
Sie können auch die [Connector-Übersicht](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) einsehen, um einen umfassenden Katalog der aktuell verfügbaren Konnektoren zu erhalten und detailliertere Konfigurationen zu verstehen.

### Der Community beitreten

Es gibt viele Möglichkeiten, an der Apache Flink CDC-Community teilzunehmen. Die
[Mailinglisten](https://flink.apache.org/what-is-flink/community/#mailing-lists) sind der Hauptort, an dem alle Flink-Committer präsent sind. Für Benutzerunterstützung und Fragen nutzen Sie bitte die User-Mailingliste. Wenn Sie ein Problem mit Flink CDC gefunden haben,
erstellen Sie bitte ein [Flink JIRA](https://issues.apache.org/jira/projects/FLINK/summary) und versehen Sie es mit dem `Flink CDC`-Tag.   
Fehler und Feature-Anfragen können entweder auf der Dev-Mailingliste oder auf JIRA diskutiert werden.



### Beiträge

Willkommen zu Beiträgen an Flink CDC! Bitte beachten Sie unseren [Developer Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
und [APIs Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Lizenz

[Apache 2.0 Lizenz](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Besonderer Dank

Die Flink CDC-Community heißt alle willkommen, die beitragen möchten – sei es durch das Melden von Fehlern,
die Verbesserung der Dokumentation oder das Einreichen von Code-Beiträgen für Bugfixes, Testergänzungen oder die Entwicklung neuer Features.     
Danke an alle Mitwirkenden für ihre engagierten Beiträge.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---