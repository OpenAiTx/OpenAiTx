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


Flink CDC est un outil distribué d'intégration de données pour les données en temps réel et les données batch. Flink CDC apporte la simplicité 
et l'élégance de l'intégration de données via YAML pour décrire le déplacement et la transformation des données dans un 
[Pipeline de Données](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC privilégie une intégration de données de bout en bout efficace et offre des fonctionnalités avancées telles que 
la synchronisation complète de bases de données, la synchronisation de tables fragmentées (sharding), l'évolution de schéma et la transformation de données.

![Conception du framework Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Guide de démarrage rapide

Flink CDC fournit un utilitaire CLI CdcUp pour démarrer un environnement de test et exécuter des tâches Flink CDC.
Vous devez disposer d'un environnement Docker et Docker compose fonctionnel pour l'utiliser.

1. Exécutez `git clone https://github.com/apache/flink-cdc.git --depth=1` pour récupérer une copie du code source de Flink CDC.
2. Exécutez `cd tools/cdcup/ && ./cdcup.sh init` pour utiliser l'outil CdcUp et démarrer un environnement de test.
3. Exécutez `./cdcup.sh up` pour lancer les conteneurs Docker, et attendez qu'ils soient prêts.
4. Exécutez `./cdcup.sh mysql` pour ouvrir une session MySQL, et créez au moins une table.

```sql
-- initialiser la base de données et la table
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- insérer des données de test
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- vérifier si l'insertion a réussi
SELECT * FROM test_table;
```

5. Exécutez `./cdcup.sh pipeline pipeline-definition.yaml` pour soumettre le job de pipeline. Vous pouvez également modifier le fichier de définition du pipeline pour d'autres configurations.
6. Exécutez `./cdcup.sh flink` pour accéder à l'interface web de Flink.

### Pour bien démarrer

1. Préparez un cluster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) et configurez la variable d'environnement `FLINK_HOME`.
2. [Téléchargez](https://github.com/apache/flink-cdc/releases) l'archive tar de Flink CDC, décompressez-la et placez les fichiers jars du connecteur pipeline dans le répertoire `lib` de Flink.

> Si vous utilisez macOS ou Linux, vous pouvez utiliser `brew install apache-flink-cdc` pour installer rapidement Flink CDC et les connecteurs compatibles.

3. Créez un fichier **YAML** pour décrire la source de données et la destination, l'exemple suivant synchronise toutes les tables de la base de données MySQL app_db vers Doris :
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
       description: projection et filtrage des champs
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: projection et filtrage des champs

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: Synchronisation de la base MySQL vers Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Soumettez le job pipeline en utilisant le script `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Consultez le statut d'exécution du job via le WebUI Flink ou dans la base de données de destination.

Essayez par vous-même avec notre [tutoriel](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) plus détaillé. 
Vous pouvez également consulter [l'aperçu des connecteurs](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) pour voir un catalogue complet des connecteurs actuellement proposés et découvrir plus de configurations détaillées.

### Rejoindre la communauté

Il existe de nombreuses façons de participer à la communauté Apache Flink CDC. Les
[listes de diffusion](https://flink.apache.org/what-is-flink/community/#mailing-lists) sont le principal lieu d'échange où tous les contributeurs Flink sont présents. Pour le support utilisateur et les questions, utilisez la liste de diffusion utilisateur. Si vous trouvez un problème sur Flink CDC,
veuillez créer une [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) et l'étiqueter avec le tag `Flink CDC`.   
Les bugs et demandes de fonctionnalités peuvent être discutés soit sur la liste de diffusion dev, soit sur Jira.



### Contribuer

Vous êtes les bienvenus pour contribuer à Flink CDC, veuillez consulter notre [Guide du Développeur](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
et [Guide des APIs](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Licence

[Licence Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Remerciements Spéciaux

La communauté Flink CDC accueille toute personne souhaitant contribuer, que ce soit via la soumission de rapports de bugs,
l'amélioration de la documentation, ou la soumission de contributions de code pour des corrections de bugs, des ajouts de tests ou le développement de nouvelles fonctionnalités.     
Merci à tous les contributeurs pour leur engagement enthousiaste.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---