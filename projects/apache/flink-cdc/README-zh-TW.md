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


Flink CDC 是一款分散式的資料整合工具，支援即時數據與批次數據。Flink CDC 透過 YAML 以簡潔直觀的方式描述資料在[數據管道](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)中的移動與轉換，讓資料整合變得更加簡單優雅。

Flink CDC 著重於高效的端到端數據整合，並提供了豐富的功能，例如全庫同步、分片表同步、結構演進與數據轉換。

![Flink CDC 框架設計](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### 快速入門指南

Flink CDC 提供 CdcUp CLI 工具，可以啟動一個 playground 環境並運行 Flink CDC 任務。
您需要有可用的 Docker 與 Docker compose 環境。

1. 執行 `git clone https://github.com/apache/flink-cdc.git --depth=1` 以取得 Flink CDC 原始碼。
2. 執行 `cd tools/cdcup/ && ./cdcup.sh init` 使用 CdcUp 工具啟動一個 playground 環境。
3. 執行 `./cdcup.sh up` 啟動 docker 容器，並等待容器就緒。
4. 執行 `./cdcup.sh mysql` 進入 MySQL 會話，並建立至少一個資料表。

```sql
-- 初始化資料庫與資料表
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- 插入測試資料
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- 驗證資料是否成功插入
SELECT * FROM test_table;
```

5. 執行 `./cdcup.sh pipeline pipeline-definition.yaml` 提交管道任務。您也可以編輯管道定義檔以進行進一步配置。
6. 執行 `./cdcup.sh flink` 存取 Flink Web UI。

### 開始使用

1. 準備一個 [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) 叢集，並設置 `FLINK_HOME` 環境變數。
2. [下載](https://github.com/apache/flink-cdc/releases) Flink CDC 壓縮包，解壓後將 pipeline connector 的 jar 放至 Flink 的 `lib` 目錄下。

> 如果您使用的是 macOS 或 Linux，可以通過 `brew install apache-flink-cdc` 快速安裝 Flink CDC 及其兼容的 connector。

3. 建立一個 **YAML** 文件描述資料來源與目標，下例將 MySQL app_db 資料庫下所有資料表同步至 Doris：
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
4. 使用 `flink-cdc.sh` 腳本提交管道任務。
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. 透過 Flink WebUI 或下游資料庫檢查任務執行情況。

您可以參考我們更詳細的[教學](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md)自行體驗。
也可以參考 [connector 概覽](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) 查看當前提供的連接器目錄並瞭解更詳細的配置方式。

### 加入社群

有多種方式可以參與 Apache Flink CDC 社群。
[郵件列表](https://flink.apache.org/what-is-flink/community/#mailing-lists) 是所有 Flink 貢獻者的主要交流場所。用戶支持與疑問請使用 user 郵件列表。如果您發現了 Flink CDC 的問題，請創建一個 [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary)，並標記 `Flink CDC` 標籤。   
Bug 與功能需求可在 dev 郵件列表或 Jira 上討論。

### 貢獻指南

歡迎為 Flink CDC 做出貢獻，請參閱我們的 [開發者指南](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
以及 [APIs 指南](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md)。

### 授權

[Apache 2.0 License](LICENSE)。

### 特別感謝

Flink CDC 社群歡迎所有願意貢獻的人士，無論是提交錯誤報告、增強文件、還是為錯誤修復、測試添加或新功能開發提供代碼貢獻。     
感謝所有貢獻者的熱情投入。

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---