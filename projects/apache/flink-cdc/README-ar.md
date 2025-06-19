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


Flink CDC هو أداة توزيع تكامل البيانات للبيانات اللحظية وبيانات الدفعة. يجلب Flink CDC البساطة 
والأناقة لتكامل البيانات عبر YAML لوصف حركة البيانات وتحويلها في 
[خط أنابيب البيانات](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


يعطي Flink CDC الأولوية لتكامل البيانات الفعال من البداية إلى النهاية ويوفر وظائف محسنة مثل 
مزامنة قاعدة البيانات بالكامل، ومزامنة الجداول المجزأة، وتطور المخطط، وتحويل البيانات.

![تصميم إطار عمل Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### دليل البدء السريع

يوفر Flink CDC أداة CLI باسم CdcUp لبدء بيئة اختبار وتشغيل وظائف Flink CDC.
ستحتاج إلى وجود بيئة Docker وDocker compose فعّالة لاستخدامها.

1. نفذ الأمر `git clone https://github.com/apache/flink-cdc.git --depth=1` للحصول على نسخة من كود مصدر Flink CDC.
2. نفذ الأمر `cd tools/cdcup/ && ./cdcup.sh init` لاستخدام أداة CdcUp لبدء بيئة اختبار.
3. نفذ الأمر `./cdcup.sh up` لتشغيل حاويات Docker، وانتظر حتى تصبح جاهزة.
4. نفذ الأمر `./cdcup.sh mysql` لفتح جلسة MySQL، وأنشئ على الأقل جدولاً واحدًا.

```sql
-- تهيئة قاعدة البيانات والجدول
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- إدخال بيانات اختبار
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- التحقق مما إذا تم الإدخال بنجاح
SELECT * FROM test_table;
```

5. نفذ الأمر `./cdcup.sh pipeline pipeline-definition.yaml` لتقديم وظيفة خط الأنابيب. يمكنك أيضًا تعديل ملف تعريف خط الأنابيب لمزيد من التهيئات.
6. نفذ الأمر `./cdcup.sh flink` للوصول إلى واجهة الويب لـ Flink.

### البدء

1. حضّر عنقود [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) واضبط متغير البيئة `FLINK_HOME`.
2. [حمّل](https://github.com/apache/flink-cdc/releases) حزمة Flink CDC المضغوطة، ثم فك الضغط وضع ملفات jar لوصلات خط الأنابيب في مجلد `lib` الخاص بـ Flink.

> إذا كنت تستخدم macOS أو Linux، يمكنك استخدام `brew install apache-flink-cdc` لتثبيت Flink CDC ووصلاته المتوافقة بسرعة.

3. أنشئ ملف **YAML** لوصف مصدر البيانات ومصب البيانات، المثال التالي يقوم بمزامنة جميع الجداول تحت قاعدة بيانات MySQL باسم app_db إلى Doris :
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
4. قدم وظيفة خط الأنابيب باستخدام سكربت `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. راقب حالة تنفيذ الوظيفة من خلال واجهة الويب لـ Flink أو قاعدة البيانات النهائية.

جربها بنفسك من خلال [الشرح التفصيلي](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md).
يمكنك أيضًا رؤية [نظرة عامة على الوصلات](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) للاطلاع على كتالوج شامل للوصلات المتوفرة حاليًا وفهم المزيد من التهيئات التفصيلية.

### انضم إلى المجتمع

هناك العديد من الطرق للمشاركة في مجتمع Apache Flink CDC. تعتبر
[قوائم البريد](https://flink.apache.org/what-is-flink/community/#mailing-lists) هي المكان الأساسي الذي يتواجد فيه جميع ملتزمي Flink.
لدعم المستخدمين والأسئلة استخدم قائمة البريد للمستخدمين. إذا وجدت مشكلة في Flink CDC،
يرجى إنشاء [تذكرة Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) ووضع علامة `Flink CDC` عليها.   
يمكن مناقشة الأخطاء وطلبات الميزات إما على قائمة بريد المطورين أو على Jira.



### المساهمة

مرحبًا بك للمساهمة في Flink CDC، يرجى الاطلاع على [دليل المطور](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
و[دليل واجهات البرمجة](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### الرخصة

[رخصة Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### شكراً خاصاً

يرحب مجتمع Flink CDC بالجميع للمساهمة، سواء من خلال تقديم تقارير الأخطاء،
أو تحسين التوثيق، أو تقديم مساهمات برمجية لإصلاح الأخطاء، أو إضافة اختبارات، أو تطوير ميزات جديدة.     
شكراً لجميع المساهمين على مساهماتهم الحماسية.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---