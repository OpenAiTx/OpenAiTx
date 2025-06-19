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

Flink CDC, gerçek zamanlı veri ve toplu veri için dağıtık bir veri entegrasyon aracıdır. Flink CDC, veri hareketini ve dönüşümünü tanımlamak için YAML üzerinden veri entegrasyonunun sadeliğini ve zarafetini [Veri Hattı](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md) ile sunar.

Flink CDC, verimli uçtan uca veri entegrasyonuna öncelik verir ve tam veritabanı senkronizasyonu, sharding tablo senkronizasyonu, şema evrimi ve veri dönüşümü gibi gelişmiş işlevler sunar.

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### Hızlı Başlangıç Rehberi

Flink CDC, bir playground ortamı başlatmak ve Flink CDC işleri çalıştırmak için bir CdcUp CLI aracı sağlar.
Bunu kullanmak için çalışan bir Docker ve Docker compose ortamına ihtiyacınız olacaktır.

1. Flink CDC kaynak kodunun bir kopyasını almak için `git clone https://github.com/apache/flink-cdc.git --depth=1` komutunu çalıştırın.
2. Playground ortamını başlatmak için `cd tools/cdcup/ && ./cdcup.sh init` komutunu çalıştırın.
3. Docker konteynerlerini başlatmak ve hazır olmalarını beklemek için `./cdcup.sh up` komutunu çalıştırın.
4. Bir MySQL oturumu açmak ve en az bir tablo oluşturmak için `./cdcup.sh mysql` komutunu çalıştırın.

```sql
-- veritabanı ve tabloyu başlat
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- test verisi ekle
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- başarıyla eklenip eklenmediğini doğrula
SELECT * FROM test_table;
```

5. Pipeline işini göndermek için `./cdcup.sh pipeline pipeline-definition.yaml` komutunu çalıştırın. Ayrıca pipeline tanım dosyasını daha fazla yapılandırma için düzenleyebilirsiniz.
6. Flink Web UI'ye erişmek için `./cdcup.sh flink` komutunu çalıştırın.

### Başlarken

1. Bir [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) kümesi hazırlayın ve `FLINK_HOME` ortam değişkenini ayarlayın.
2. [Flink CDC](https://github.com/apache/flink-cdc/releases) tar dosyasını indirin, açın ve pipeline konektörlerinin jar dosyalarını Flink `lib` dizinine yerleştirin.

> Eğer macOS veya Linux kullanıyorsanız, Flink CDC ve uyumlu konektörleri hızlıca kurmak için `brew install apache-flink-cdc` komutunu kullanabilirsiniz.

3. Veri kaynağını ve veri hedefini tanımlayan bir **YAML** dosyası oluşturun. Aşağıdaki örnek, MySQL'deki app_db veritabanındaki tüm tabloları Doris'e senkronize eder:
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
       description: alanları projekte et ve filtrele
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: alanları projekte et ve filtrele

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
4. `flink-cdc.sh` betiğini kullanarak pipeline işini gönderin.
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. İş yürütme durumunu Flink WebUI veya hedef veritabanı üzerinden görüntüleyin.

Kendi başınıza denemek için daha detaylı [eğitimimize](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) göz atabilirsiniz.
Ayrıca mevcut konektörlerin kapsamlı kataloğunu görüntülemek ve daha detaylı yapılandırmaları anlamak için [konektör genel bakışına](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) bakabilirsiniz.

### Topluluğa Katılın

Apache Flink CDC topluluğuna katılmanın birçok yolu vardır.
[Tartışma listeleri](https://flink.apache.org/what-is-flink/community/#mailing-lists), tüm Flink katkıcılarının bulunduğu ana yerdir. Kullanıcı desteği ve soruları için kullanıcı tartışma listesini kullanın. Flink CDC'de bir sorun bulduysanız, lütfen bir [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) oluşturun ve `Flink CDC` etiketiyle etiketleyin.   
Hatalar ve özellik talepleri, geliştirici tartışma listesinde veya Jira'da tartışılabilir.

### Katkıda Bulunun

Flink CDC'ye katkıda bulunmak için hoş geldiniz, lütfen [Geliştirici Rehberi](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)
ve [API Rehberi](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md) sayfalarımıza bakınız.

### Lisans

[Apache 2.0 Lisansı](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE).

### Özel Teşekkürler

Flink CDC topluluğu, ister hata raporları göndererek, ister dokümantasyonu geliştirerek, ister hata düzeltmeleri, test eklemeleri veya yeni özellik geliştirmeleri için kod katkıları göndererek katkıda bulunmak isteyen herkesi memnuniyetle karşılar.     
Tüm katkıcıların coşkulu katkıları için teşekkürler.

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---