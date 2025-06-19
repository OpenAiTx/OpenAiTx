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


Flink CDCは、リアルタイムデータおよびバッチデータのための分散データ統合ツールです。Flink CDCは、データの移動と変換を[YAML](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)で記述することで、データ統合のシンプルさとエレガンスを[データパイプライン](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)に提供します。

Flink CDCは、効率的なエンドツーエンドのデータ統合を最優先し、データベース全体の同期、シャーディングテーブルの同期、スキーマ進化、データ変換などの高度な機能を提供します。

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### クイックスタートガイド

Flink CDCは、CdcUp CLIユーティリティを提供しており、プレイグラウンド環境の起動やFlink CDCジョブの実行が可能です。
使用するには、DockerおよびDocker Composeが動作する環境が必要です。

1. `git clone https://github.com/apache/flink-cdc.git --depth=1`を実行して、Flink CDCのソースコードを取得します。
2. `cd tools/cdcup/ && ./cdcup.sh init`を実行し、CdcUpツールでプレイグラウンド環境を開始します。
3. `./cdcup.sh up`を実行してDockerコンテナを起動し、準備が整うのを待ちます。
4. `./cdcup.sh mysql`を実行してMySQLセッションを開き、少なくとも1つのテーブルを作成します。

```sql
-- データベースとテーブルの初期化
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- テストデータの挿入
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- 挿入が成功したか確認
SELECT * FROM test_table;
```

5. `./cdcup.sh pipeline pipeline-definition.yaml`を実行してパイプラインジョブを送信します。必要に応じて、パイプライン定義ファイルを編集して追加設定を行えます。
6. `./cdcup.sh flink`を実行してFlink Web UIにアクセスします。

### はじめに

1. [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) クラスターを準備し、`FLINK_HOME`環境変数を設定します。
2. [Flink CDCのtarファイルをダウンロード](https://github.com/apache/flink-cdc/releases)し、解凍して、パイプラインコネクタのjarをFlinkの`lib`ディレクトリに配置します。

> macOSまたはLinuxを使用している場合は、`brew install apache-flink-cdc`を利用して、Flink CDCおよび互換性のあるコネクタを簡単にインストールできます。

3. **YAML**ファイルを作成し、データソースとデータシンクを記述します。以下は、MySQLのapp_dbデータベース配下の全テーブルをDorisに同期する例です：
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
4. `flink-cdc.sh`スクリプトを使ってパイプラインジョブを送信します。
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Flink WebUIまたは下流のデータベースでジョブの実行状況を確認します。

より詳細な[チュートリアル](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md)でご自身でもお試しください。
また、[コネクタの概要](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md)で、現在提供されているコネクタの包括的なカタログや詳細な設定を確認できます。

### コミュニティへの参加

Apache Flink CDCコミュニティへの参加方法は多数あります。
[メーリングリスト](https://flink.apache.org/what-is-flink/community/#mailing-lists)は、すべてのFlinkコミッターが参加している主要な場所です。ユーザーサポートや質問にはユーザーメーリングリストを利用してください。Flink CDCで問題を発見した場合は、[Flink jira](https://issues.apache.org/jira/projects/FLINK/summary)を作成し、`Flink CDC`タグを付けてください。   
バグや機能リクエストは、devメーリングリストまたはJiraで議論できます。

### コントリビューション

Flink CDCへの貢献を歓迎します。詳細は[開発者ガイド](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)および[APIガイド](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md)をご覧ください。

### ライセンス

[Apache 2.0 License](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE)。

### 特別な感謝

Flink CDCコミュニティは、バグ報告、ドキュメントの改善、バグ修正・テスト追加・新機能開発のためのコード貢献など、貢献を希望するすべての方を歓迎します。     
熱心に貢献してくださったすべてのコントリビューターに感謝いたします。

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---