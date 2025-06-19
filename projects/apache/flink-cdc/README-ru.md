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


Flink CDC — это распределённый инструмент интеграции данных для потоковых и пакетных данных в реальном времени. Flink CDC обеспечивает простоту и элегантность интеграции данных с помощью YAML для описания перемещения и трансформации данных в [конвейере данных](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).

Flink CDC уделяет приоритетное внимание эффективной интеграции данных от начала до конца и предлагает расширенные функции, такие как полная синхронизация баз данных, синхронизация шардинг-таблиц, эволюция схемы и трансформация данных.

![Дизайн архитектуры Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Краткое руководство по запуску

Flink CDC предоставляет утилиту командной строки CdcUp для запуска тестовой среды и выполнения заданий Flink CDC.
Для её использования необходимо наличие рабочей среды Docker и Docker compose.

1. Выполните `git clone https://github.com/apache/flink-cdc.git --depth=1`, чтобы получить копию исходного кода Flink CDC.
2. Выполните `cd tools/cdcup/ && ./cdcup.sh init`, чтобы с помощью инструмента CdcUp запустить тестовую среду.
3. Выполните `./cdcup.sh up`, чтобы запустить docker-контейнеры и дождитесь их готовности.
4. Выполните `./cdcup.sh mysql`, чтобы открыть сессию MySQL и создать хотя бы одну таблицу.

```sql
-- инициализация базы данных и таблицы
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- вставка тестовых данных
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- проверка успешной вставки
SELECT * FROM test_table;
```

5. Выполните `./cdcup.sh pipeline pipeline-definition.yaml`, чтобы отправить задание конвейера. Вы также можете отредактировать файл определения конвейера для дополнительных настроек.
6. Выполните `./cdcup.sh flink`, чтобы получить доступ к веб-интерфейсу Flink.

### Начало работы

1. Подготовьте кластер [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) и установите переменную окружения `FLINK_HOME`.
2. [Скачайте](https://github.com/apache/flink-cdc/releases) tar-архив Flink CDC, распакуйте его и поместите jar-файлы коннектора pipeline в директорию Flink `lib`.

> Если вы используете macOS или Linux, вы можете быстро установить Flink CDC и совместимые коннекторы с помощью `brew install apache-flink-cdc`.

3. Создайте **YAML**-файл для описания источника и приёмника данных. Следующий пример синхронизирует все таблицы из базы данных MySQL `app_db` в Doris:
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
4. Отправьте задание конвейера с помощью скрипта `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Просматривайте статус выполнения задания через Flink WebUI или downstream-базу данных.

Попробуйте сами, используя наш более подробный [учебник](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md).
Вы также можете ознакомиться с [обзором коннекторов](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md), чтобы увидеть полный каталог предоставляемых на данный момент коннекторов и узнать о более детальных настройках.

### Присоединяйтесь к сообществу

Существует множество способов принять участие в сообществе Apache Flink CDC. [Списки рассылки](https://flink.apache.org/what-is-flink/community/#mailing-lists) — основное место, где присутствуют все коммиттеры Flink. Для поддержки пользователей и вопросов используйте пользовательский список рассылки. Если вы обнаружили проблему Flink CDC, пожалуйста, создайте [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) и пометьте её тегом `Flink CDC`.   
Ошибки и запросы на новые функции можно обсуждать в списке рассылки разработчиков или в Jira.

### Вклад в проект

Добро пожаловать во Flink CDC, пожалуйста, ознакомьтесь с нашим [Руководством разработчика](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
и [Руководством по API](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).

### Лицензия

[Лицензия Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### Особая благодарность

Сообщество Flink CDC приветствует всех, кто готов внести вклад — будь то отправка отчётов об ошибках, улучшение документации или внесение кода для исправления ошибок, добавления тестов или разработки новых функций.     
Благодарим всех участников за их активный вклад.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---