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


Flink CDC 是一个面向实时数据与批量数据的分布式数据集成工具。Flink CDC 通过 YAML 文件描述数据流转与转换，使得数据集成在 [数据管道](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md) 中变得简单而优雅。

Flink CDC 优先考虑高效的端到端数据集成，并提供了增强功能，如全库同步、分库分表同步、模式演进和数据转换。

![Flink CDC 框架设计](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### 快速入门指南

Flink CDC 提供了 CdcUp CLI 工具，可用于启动演示环境并运行 Flink CDC 任务。
使用该工具需要安装并配置好 Docker 和 Docker compose 环境。

1. 运行 `git clone https://github.com/apache/flink-cdc.git --depth=1` 获取 Flink CDC 源码。
2. 运行 `cd tools/cdcup/ && ./cdcup.sh init` 使用 CdcUp 工具启动演示环境。
3. 运行 `./cdcup.sh up` 启动 docker 容器，等待环境准备就绪。
4. 运行 `./cdcup.sh mysql` 打开 MySQL 会话，并创建至少一张表。

```sql
-- 初始化数据库和表
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- 插入测试数据
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- 验证数据是否成功插入
SELECT * FROM test_table;
```

5. 运行 `./cdcup.sh pipeline pipeline-definition.yaml` 提交数据管道任务。你也可以编辑 pipeline-definition.yaml 文件进行进一步配置。
6. 运行 `./cdcup.sh flink` 访问 Flink Web UI。

### 开始使用

1. 准备一个 [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) 集群并设置 `FLINK_HOME` 环境变量。
2. [下载](https://github.com/apache/flink-cdc/releases) Flink CDC tar 包，解压后将对应的 pipeline connector jar 包放到 Flink 的 `lib` 目录下。

> 如果你在使用 macOS 或 Linux，可通过 `brew install apache-flink-cdc` 快速安装 Flink CDC 及兼容连接器。

3. 创建一个 **YAML** 文件用于描述数据源与数据汇，以下示例将 MySQL app_db 库下所有表同步至 Doris：
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
       description: 字段投影与过滤
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: 字段投影与过滤

   route:
     - source-table: app_db.orders
       sink-table: ods_db.ods_orders
     - source-table: app_db.shipments
       sink-table: ods_db.ods_shipments
     - source-table: app_db.products
       sink-table: ods_db.ods_products

   pipeline:
     name: 同步 MySQL 数据库到 Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. 使用 `flink-cdc.sh` 脚本提交数据管道任务。
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. 通过 Flink WebUI 或下游数据库查看作业运行状态。

你可以通过我们更详细的 [教程](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) 进行自助体验。
也可以查看 [连接器总览](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) 来了解目前提供的连接器及更详细的参数配置。

### 加入社区

有多种方式可以参与 Apache Flink CDC 社区。[邮件列表](https://flink.apache.org/what-is-flink/community/#mailing-lists) 是所有 Flink 提交者都在的主要交流场所。用户支持与问题请使用 user 邮件列表。如果你发现了 Flink CDC 的问题，请创建一个 [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) 并添加 `Flink CDC` 标签。
Bug 和新功能请求可以在 dev 邮件列表或 Jira 上讨论。

### 参与贡献

欢迎为 Flink CDC 做出贡献，请参阅我们的 [开发者指南](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
和 [API 指南](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md)。

### 许可证

[Apache 2.0 License](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE)。

### 特别感谢

Flink CDC 社区欢迎任何愿意贡献的朋友，无论是提交 bug 报告、完善文档，还是为缺陷修复、测试补充或新特性开发提交代码。
感谢所有贡献者的热情参与！

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---