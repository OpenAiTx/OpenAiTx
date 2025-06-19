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


Flink CDC è uno strumento distribuito di integrazione dei dati per dati in tempo reale e dati batch. Flink CDC porta la semplicità 
e l’eleganza dell’integrazione dei dati tramite YAML per descrivere il movimento e la trasformazione dei dati in una 
[Pipeline di Dati](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC dà priorità a un’integrazione dati end-to-end efficiente e offre funzionalità avanzate come 
sincronizzazione completa del database, sincronizzazione di tabelle sharding, evoluzione dello schema e trasformazione dei dati.

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Guida Rapida

Flink CDC fornisce un'utilità CLI CdcUp per avviare un ambiente di playground ed eseguire job Flink CDC.
Per utilizzarla, è necessario avere un ambiente Docker e Docker compose funzionante.

1. Esegui `git clone https://github.com/apache/flink-cdc.git --depth=1` per recuperare una copia del codice sorgente di Flink CDC.
2. Esegui `cd tools/cdcup/ && ./cdcup.sh init` per usare lo strumento CdcUp e avviare un ambiente di playground.
3. Esegui `./cdcup.sh up` per avviare i container docker e attendi che siano pronti.
4. Esegui `./cdcup.sh mysql` per aprire una sessione MySQL e crea almeno una tabella.

```sql
-- inizializza db e tabella
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- inserisci dati di test
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- verifica che l’inserimento sia andato a buon fine
SELECT * FROM test_table;
```

5. Esegui `./cdcup.sh pipeline pipeline-definition.yaml` per inviare il job di pipeline. Puoi anche modificare il file di definizione della pipeline per ulteriori configurazioni.
6. Esegui `./cdcup.sh flink` per accedere alla Flink Web UI.

### Per Iniziare

1. Prepara un cluster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) e imposta la variabile d'ambiente `FLINK_HOME`.
2. [Scarica](https://github.com/apache/flink-cdc/releases) il tar di Flink CDC, decomprimilo e inserisci i jar del connettore pipeline nella directory `lib` di Flink.

> Se stai usando macOS o Linux, puoi utilizzare `brew install apache-flink-cdc` per installare rapidamente Flink CDC e i connettori compatibili.

3. Crea un file **YAML** per descrivere la sorgente dati e il sink dati; il seguente esempio sincronizza tutte le tabelle presenti nel database MySQL app_db su Doris:
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
4. Invia il job della pipeline usando lo script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Visualizza lo stato di esecuzione del job tramite Flink WebUI o il database a valle.

Prova tu stesso seguendo il nostro [tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) più dettagliato.
Puoi anche consultare la [panoramica dei connettori](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) per vedere un catalogo completo dei
connettori attualmente disponibili e comprendere le configurazioni più dettagliate.

### Unisciti alla Comunità

Ci sono molti modi per partecipare alla comunità di Apache Flink CDC. Le
[mailing list](https://flink.apache.org/what-is-flink/community/#mailing-lists) sono il luogo principale dove sono presenti tutti i committer di Flink.
Per supporto e domande, usa la mailing list degli utenti. Se hai riscontrato un problema con Flink CDC,
crea un [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) e aggiungi il tag `Flink CDC`.   
Bug e richieste di nuove funzionalità possono essere discusse sia sulla mailing list dev sia su Jira.



### Contribuire

Se vuoi contribuire a Flink CDC, consulta la nostra [Guida per Sviluppatori](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
e la [Guida alle API](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Licenza

[Licenza Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Ringraziamenti Speciali

La comunità di Flink CDC accoglie chiunque desideri contribuire, sia tramite la segnalazione di bug,
il miglioramento della documentazione, o l’invio di contributi di codice per correzioni di bug, aggiunte di test o sviluppo di nuove funzionalità.     
Grazie a tutti i contributori per il loro entusiasmo e contributo.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---