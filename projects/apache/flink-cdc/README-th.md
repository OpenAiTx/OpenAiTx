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


Flink CDC เป็นเครื่องมือบูรณาการข้อมูลแบบกระจายสำหรับข้อมูลเรียลไทม์และข้อมูลแบตช์ Flink CDC นำเสนอความเรียบง่าย 
และความสวยงามของการบูรณาการข้อมูลผ่าน YAML เพื่ออธิบายการเคลื่อนย้ายและการแปลงข้อมูลใน 
[Data Pipeline](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md) 

Flink CDC ให้ความสำคัญกับการบูรณาการข้อมูลแบบ end-to-end อย่างมีประสิทธิภาพ และยังมีฟังก์ชันเพิ่มเติม เช่น 
การซิงโครไนซ์ฐานข้อมูลแบบเต็ม, การซิงโครไนซ์ตารางแบบ sharding, การเปลี่ยนแปลง schema และการแปลงข้อมูล

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### คู่มือเริ่มต้นอย่างรวดเร็ว

Flink CDC มีเครื่องมือ CLI ที่ชื่อว่า CdcUp สำหรับเริ่มต้นสภาพแวดล้อม playground และรันงาน Flink CDC
คุณจำเป็นต้องมี Docker และ Docker compose ที่พร้อมใช้งาน

1. รัน `git clone https://github.com/apache/flink-cdc.git --depth=1` เพื่อดึงซอร์สโค้ด Flink CDC
2. รัน `cd tools/cdcup/ && ./cdcup.sh init` เพื่อใช้เครื่องมือ CdcUp เริ่มต้นสภาพแวดล้อม playground
3. รัน `./cdcup.sh up` เพื่อเปิดใช้งาน docker containers และรอให้พร้อมใช้งาน
4. รัน `./cdcup.sh mysql` เพื่อเปิด session MySQL และสร้างตารางอย่างน้อยหนึ่งตาราง

```sql
-- initialize db and table
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- insert test data
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- verify if it has been successfully inserted
SELECT * FROM test_table;
```

5. รัน `./cdcup.sh pipeline pipeline-definition.yaml` เพื่อ submit งาน pipeline คุณสามารถแก้ไขไฟล์ pipeline definition เพื่อการตั้งค่าเพิ่มเติมได้
6. รัน `./cdcup.sh flink` เพื่อเข้าสู่ Flink Web UI

### เริ่มต้นใช้งาน

1. เตรียม cluster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) และตั้งค่าตัวแปรสภาพแวดล้อม `FLINK_HOME`
2. [ดาวน์โหลด](https://github.com/apache/flink-cdc/releases) Flink CDC tar, แตกไฟล์ และนำ jar ของ pipeline connector ไปไว้ในไดเรกทอรี `lib` ของ Flink

> หากคุณใช้ macOS หรือ Linux คุณสามารถใช้ `brew install apache-flink-cdc` เพื่อติดตั้ง Flink CDC และ connectors ที่เข้ากันได้อย่างรวดเร็ว

3. สร้างไฟล์ **YAML** เพื่ออธิบาย data source และ data sink ตัวอย่างต่อไปนี้ใช้ซิงโครไนซ์ทุกตารางในฐานข้อมูล MySQL app_db ไปยัง Doris:
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
4. ส่งงาน pipeline โดยใช้สคริปต์ `flink-cdc.sh`
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. ตรวจสอบสถานะการทำงานของ job ผ่าน Flink WebUI หรือฐานข้อมูลปลายทาง

ทดลองใช้งานได้ด้วยตนเองผ่าน [คู่มือแบบละเอียด](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) 
และดู [ภาพรวม connector](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) เพื่อดูแค็ตตาล็อกของ connectors ที่มีให้และเข้าใจการตั้งค่าต่าง ๆ เพิ่มเติม

### เข้าร่วมชุมชน

มีหลายวิธีในการเข้าร่วมชุมชน Apache Flink CDC
[list อีเมล](https://flink.apache.org/what-is-flink/community/#mailing-lists) คือช่องทางหลักที่ committers ของ Flink ทุกคนใช้งาน สำหรับการขอความช่วยเหลือหรือสอบถาม ให้ใช้ user mailing list หากคุณพบปัญหาเกี่ยวกับ Flink CDC โปรดสร้าง [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) และติดแท็กว่า `Flink CDC`   
บั๊กและคำขอฟีเจอร์สามารถพูดคุยได้ทั้งใน dev mailing list หรือบน Jira


### การมีส่วนร่วม

ยินดีต้อนรับทุกท่านที่ต้องการมีส่วนร่วมกับ Flink CDC กรุณาดู [Developer Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
และ [APIs Guide](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md)


### ใบอนุญาต

[Apache 2.0 License](LICENSE).


### ขอบคุณเป็นพิเศษ

ชุมชน Flink CDC ยินดีต้อนรับทุกคนที่ต้องการมีส่วนร่วม ไม่ว่าจะเป็นการรายงานบั๊ก
ปรับปรุงเอกสาร หรือส่งโค้ดสำหรับแก้ไขบั๊ก เพิ่มการทดสอบ หรือพัฒนาฟีเจอร์ใหม่    
ขอขอบคุณผู้มีส่วนร่วมทุกท่านสำหรับความมุ่งมั่นและความกระตือรือร้น

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---