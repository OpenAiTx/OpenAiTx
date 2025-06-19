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


Flink CDC adalah alat integrasi data terdistribusi untuk data real-time dan data batch. Flink CDC menghadirkan kesederhanaan 
dan keanggunan integrasi data melalui YAML untuk mendeskripsikan perpindahan dan transformasi data dalam sebuah 
[Data Pipeline](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md).


Flink CDC memprioritaskan integrasi data end-to-end yang efisien dan menawarkan fungsionalitas tambahan seperti 
sinkronisasi database penuh, sinkronisasi tabel sharding, evolusi skema, dan transformasi data.

![Desain kerangka Flink CDC](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Panduan Kilat

Flink CDC menyediakan utilitas CLI CdcUp untuk memulai lingkungan playground dan menjalankan pekerjaan Flink CDC.
Anda perlu memiliki Docker dan Docker compose yang berfungsi untuk menggunakannya.

1. Jalankan `git clone https://github.com/apache/flink-cdc.git --depth=1` untuk mengambil salinan kode sumber Flink CDC.
2. Jalankan `cd tools/cdcup/ && ./cdcup.sh init` untuk menggunakan alat CdcUp guna memulai lingkungan playground.
3. Jalankan `./cdcup.sh up` untuk menyalakan kontainer docker, dan tunggu hingga siap.
4. Jalankan `./cdcup.sh mysql` untuk membuka sesi MySQL, dan buat setidaknya satu tabel.

```sql
-- inisialisasi db dan tabel
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- masukkan data uji
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- verifikasi apakah data berhasil dimasukkan
SELECT * FROM test_table;
```

5. Jalankan `./cdcup.sh pipeline pipeline-definition.yaml` untuk mengirimkan pekerjaan pipeline. Anda juga dapat mengedit file definisi pipeline untuk konfigurasi lebih lanjut.
6. Jalankan `./cdcup.sh flink` untuk mengakses Flink Web UI.

### Memulai

1. Siapkan klaster [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) dan atur variabel lingkungan `FLINK_HOME`.
2. [Unduh](https://github.com/apache/flink-cdc/releases) file tar Flink CDC, ekstrak dan letakkan file jar konektor pipeline ke direktori `lib` Flink.

> Jika Anda menggunakan macOS atau Linux, Anda bisa menggunakan `brew install apache-flink-cdc` untuk menginstal Flink CDC dan konektor yang kompatibel dengan cepat.

3. Buat file **YAML** untuk mendeskripsikan sumber data dan target data, contoh berikut menyinkronkan semua tabel di bawah database MySQL app_db ke Doris :
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
     name: Sinkronisasi Database MySQL ke Doris
     parallelism: 2
     user-defined-function:
       - name: addone
         classpath: com.example.functions.AddOneFunctionClass
       - name: format
         classpath: com.example.functions.FormatFunctionClass
  ```
4. Kirim pekerjaan pipeline menggunakan skrip `flink-cdc.sh`.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Lihat status eksekusi pekerjaan melalui Flink WebUI atau database tujuan.

Coba sendiri dengan [tutorial](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) kami yang lebih detail. 
Anda juga dapat melihat [overview konektor](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) untuk melihat katalog lengkap konektor yang tersedia dan memahami konfigurasi yang lebih rinci.

### Bergabung dengan Komunitas

Ada banyak cara untuk berpartisipasi dalam komunitas Apache Flink CDC. 
[Milis](https://flink.apache.org/what-is-flink/community/#mailing-lists) adalah tempat utama di mana seluruh committer Flink hadir. Untuk dukungan pengguna dan pertanyaan gunakan milis user. Jika Anda menemukan masalah pada Flink CDC,
silakan buat [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) dan beri tag `Flink CDC`.   
Bug dan permintaan fitur dapat didiskusikan di milis dev atau di Jira.



### Kontribusi

Silakan berkontribusi pada Flink CDC, silakan lihat [Panduan Pengembang](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
dan [Panduan API](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md).



### Lisensi

[Lisensi Apache 2.0](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).



### Ucapan Terima Kasih Khusus

Komunitas Flink CDC menyambut siapa saja yang ingin berkontribusi, baik dengan mengirimkan laporan bug,
meningkatkan dokumentasi, maupun mengirimkan kontribusi kode untuk perbaikan bug, penambahan pengujian, atau pengembangan fitur baru.     
Terima kasih kepada semua kontributor atas kontribusi antusias mereka.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---