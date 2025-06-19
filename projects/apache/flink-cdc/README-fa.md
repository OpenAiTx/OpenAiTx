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


Flink CDC یک ابزار توزیع‌شده برای یکپارچه‌سازی داده‌ها در زمان واقعی و داده‌های دسته‌ای است. Flink CDC با استفاده از YAML، سادگی و ظرافت یکپارچه‌سازی داده‌ها را برای توصیف انتقال و تبدیل داده‌ها در یک 
[خط لوله داده](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)
به ارمغان می‌آورد.

Flink CDC بر یکپارچه‌سازی داده کارآمد از ابتدا تا انتها اولویت می‌دهد و قابلیت‌های پیشرفته‌ای مانند همگام‌سازی کامل پایگاه داده، همگام‌سازی جداول شارد شده، تحول شمای داده و تبدیل داده را ارائه می‌دهد.

![طراحی چارچوب Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### راهنمای شروع سریع

Flink CDC ابزار خط فرمان CdcUp را برای راه‌اندازی یک محیط آزمایشی و اجرای وظایف Flink CDC ارائه می‌دهد.
برای استفاده از آن، باید یک محیط Docker و Docker compose فعال داشته باشید.

1. دستور `git clone https://github.com/apache/flink-cdc.git --depth=1` را برای دریافت نسخه‌ای از کد منبع Flink CDC اجرا کنید.
2. دستور `cd tools/cdcup/ && ./cdcup.sh init` را برای استفاده از ابزار CdcUp و راه‌اندازی محیط آزمایشی اجرا کنید.
3. دستور `./cdcup.sh up` را برای راه‌اندازی کانتینرهای داکر اجرا کنید و منتظر بمانید تا آماده شوند.
4. دستور `./cdcup.sh mysql` را برای باز کردن یک نشست MySQL اجرا کنید و حداقل یک جدول ایجاد نمایید.

```sql
-- مقداردهی اولیه پایگاه داده و جدول
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- درج داده آزمایشی
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- بررسی موفقیت درج داده‌ها
SELECT * FROM test_table;
```

5. دستور `./cdcup.sh pipeline pipeline-definition.yaml` را برای ارسال وظیفه خط لوله اجرا کنید. همچنین می‌توانید فایل تعریف خط لوله را برای پیکربندی بیشتر ویرایش نمایید.
6. دستور `./cdcup.sh flink` را برای دسترسی به رابط کاربری وب Flink اجرا کنید.

### شروع به کار

1. یک خوشه [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) آماده کنید و متغیر محیطی `FLINK_HOME` را تنظیم نمایید.
2. [دانلود](https://github.com/apache/flink-cdc/releases) فایل فشرده Flink CDC، آن را از حالت فشرده خارج کنید و فایل‌های jar مربوط به کانکتورهای خط لوله را در پوشه `lib` نرم‌افزار Flink قرار دهید.

> اگر از macOS یا Linux استفاده می‌کنید، می‌توانید با اجرای `brew install apache-flink-cdc` به سرعت Flink CDC و کانکتورهای سازگار را نصب نمایید.

3. یک فایل **YAML** ایجاد کنید تا منبع داده و مقصد داده را توصیف کند، نمونه زیر تمام جداول پایگاه داده app_db در MySQL را به Doris همگام می‌کند:
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
4. وظیفه خط لوله را با اسکریپت `flink-cdc.sh` ارسال کنید.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. وضعیت اجرای وظیفه را از طریق رابط وب Flink یا پایگاه داده مقصد مشاهده کنید.

خودتان با [آموزش گام به گام](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) ما امتحان کنید.
همچنین می‌توانید [نمای کلی کانکتورها](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) را ببینید تا فهرست جامعی از کانکتورهای موجود و پیکربندی‌های دقیق‌تر را مشاهده نمایید.

### به جامعه بپیوندید

راه‌های زیادی برای مشارکت در جامعه Apache Flink CDC وجود دارد. [لیست‌های پستی](https://flink.apache.org/what-is-flink/community/#mailing-lists) محل اصلی حضور تمام committers فلینک است. برای پشتیبانی کاربران و پرسش‌ها از لیست پستی کاربران استفاده کنید. اگر مشکلی در Flink CDC پیدا کردید،
لطفاً یک [مسئله در جیرا Flink](https://issues.apache.org/jira/projects/FLINK/summary) ایجاد کنید و آن را با برچسب `Flink CDC` علامت‌گذاری نمایید.   
باگ‌ها و درخواست‌های ویژگی را می‌توانید در لیست پستی dev یا در جیرا مطرح کنید.

### مشارکت

از شما برای مشارکت در Flink CDC استقبال می‌شود، لطفاً [راهنمای توسعه‌دهندگان](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
و [راهنمای APIها](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md) ما را ببینید.

### مجوز

[مجوز Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### سپاس ویژه

جامعه Flink CDC از همه افرادی که مایل به مشارکت هستند استقبال می‌کند، چه از طریق ارسال گزارش باگ، بهبود مستندات یا مشارکت در کد برای رفع باگ، افزودن تست یا توسعه ویژگی‌های جدید.     
از همه مشارکت‌کنندگان برای همکاری مشتاقانه‌شان سپاسگزاریم.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---