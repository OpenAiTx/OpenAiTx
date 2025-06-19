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

Flink CDC एक वितरित डेटा एकीकरण उपकरण है जो रीयल टाइम डेटा और बैच डेटा के लिए उपयोग होता है। Flink CDC डेटा पाइपलाइन में डेटा मूवमेंट और ट्रांसफॉर्मेशन का वर्णन करने के लिए YAML के माध्यम से डेटा एकीकरण की सरलता और सुंदरता लाता है।  
[डेटा पाइपलाइन](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/core-concept/data-pipeline.md)।

Flink CDC कुशल एंड-टू-एंड डेटा एकीकरण को प्राथमिकता देता है और पूर्ण डेटाबेस सिंक्रोनाइज़ेशन, शार्डिंग टेबल सिंक्रोनाइज़ेशन, स्कीमा इवोल्यूशन और डेटा ट्रांसफॉर्मेशन जैसी उन्नत सुविधाएँ प्रदान करता है।

![Flink CDC framework design](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/static/fig/architecture.png)

### क्विकस्टार्ट गाइड

Flink CDC एक CdcUp CLI यूटिलिटी प्रदान करता है जिससे आप प्लेग्राउंड एनवायरनमेंट शुरू कर सकते हैं और Flink CDC जॉब्स चला सकते हैं।  
इसे उपयोग करने के लिए आपके पास कार्यरत Docker और Docker Compose एनवायरनमेंट होना चाहिए।

1. Flink CDC स्रोत कोड प्राप्त करने के लिए `git clone https://github.com/apache/flink-cdc.git --depth=1` चलाएँ।
2. `cd tools/cdcup/ && ./cdcup.sh init` चलाएँ ताकि CdcUp टूल से प्लेग्राउंड एनवायरनमेंट शुरू हो सके।
3. `./cdcup.sh up` चलाएँ ताकि डॉकर कंटेनर चालू हो जाएँ, और उनके तैयार होने तक प्रतीक्षा करें।
4. `./cdcup.sh mysql` चलाएँ ताकि एक MySQL सेशन खुल सके, और कम से कम एक टेबल बनाएँ।

```sql
-- db और table इनिशियलाइज़ करें
CREATE DATABASE cdc_playground;
USE cdc_playground;
CREATE TABLE test_table (id INT PRIMARY KEY, name VARCHAR(32));

-- टेस्ट डेटा डालें
INSERT INTO test_table VALUES (1, 'alice'), (2, 'bob'), (3, 'cicada'), (4, 'derrida');

-- जांचें कि डेटा सफलतापूर्वक डाला गया है या नहीं
SELECT * FROM test_table;
```

5. `./cdcup.sh pipeline pipeline-definition.yaml` चलाएँ ताकि पाइपलाइन जॉब सबमिट हो सके। आप आगे की कॉन्फिगरेशन के लिए पाइपलाइन डेफिनिशन फाइल भी संपादित कर सकते हैं।
6. `./cdcup.sh flink` चलाएँ ताकि Flink वेब UI एक्सेस कर सकें।

### आरंभ करें

1. एक [Apache Flink](https://nightlies.apache.org/flink/flink-docs-master/docs/try-flink/local_installation/#starting-and-stopping-a-local-cluster) क्लस्टर तैयार करें और `FLINK_HOME` एनवायरनमेंट वेरिएबल सेट करें।
2. [डाउनलोड करें](https://github.com/apache/flink-cdc/releases) Flink CDC टार, अनज़िप करें और पाइपलाइन कनेक्टर के jars को Flink के `lib` डायरेक्टरी में रखें।

> यदि आप macOS या Linux का उपयोग कर रहे हैं, तो आप `brew install apache-flink-cdc` से Flink CDC और संगत कनेक्टर्स जल्दी से इंस्टॉल कर सकते हैं।

3. डेटा स्रोत और डेटा सिंक का वर्णन करने के लिए एक **YAML** फाइल बनाएँ, निम्न उदाहरण MySQL के app_db डेटाबेस के सभी टेबल्स को Doris में सिंक्रोनाइज़ करता है :
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
       description: प्रोजेक्ट फील्ड्स और फ़िल्टर
     - source-table: adb.web_order02
       projection: \*, format('%S', product_name) as product_name
       filter: addone(id) > 20 AND order_id > 200
       description: प्रोजेक्ट फील्ड्स और फ़िल्टर

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
4. `flink-cdc.sh` स्क्रिप्ट का उपयोग करके पाइपलाइन जॉब सबमिट करें।
 ```shell
  bash bin/flink-cdc.sh /path/mysql-to-doris.yaml
 ```
5. Flink WebUI या डाउनस्ट्रीम डेटाबेस के माध्यम से जॉब एक्जीक्यूशन की स्थिति देखें।

हमारे अधिक विस्तृत [ट्यूटोरियल](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/get-started/quickstart/mysql-to-doris.md) के साथ इसे स्वयं आज़माएँ।  
आप [कनेक्टर ओवरव्यू](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/connectors/pipeline-connectors/overview.md) भी देख सकते हैं ताकि वर्तमान में उपलब्ध कनेक्टर की विस्तृत सूची देख सकें और अधिक विस्तार से कॉन्फिगरेशन समझ सकें।

### समुदाय से जुड़ें

Apache Flink CDC समुदाय में भाग लेने के कई तरीके हैं।  
[मेलिंग लिस्ट्स](https://flink.apache.org/what-is-flink/community/#mailing-lists) प्रमुख स्थान हैं जहाँ सभी Flink कमिटर्स उपस्थित रहते हैं।  
यूज़र सपोर्ट और प्रश्नों के लिए यूज़र मेलिंग लिस्ट का उपयोग करें। यदि आपको Flink CDC में कोई समस्या मिली है, तो कृपया एक [Flink jira](https://issues.apache.org/jira/projects/FLINK/summary) बनाएं और उसे `Flink CDC` टैग करें।  
बग्स और फीचर रिक्वेस्ट्स या तो dev मेलिंग लिस्ट पर या Jira पर चर्चा की जा सकती हैं।

### योगदान करें

Flink CDC में योगदान के लिए आपका स्वागत है, कृपया हमारा [डेवलपर गाइड](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/contribute-to-flink-cdc.md)  
और [APIs गाइड](https://raw.githubusercontent.com/apache/flink-cdc/master/docs/content/docs/developer-guide/understand-flink-cdc-api.md) देखें।

### लाइसेंस

[Apache 2.0 License](https://raw.githubusercontent.com/apache/flink-cdc/master/LICENSE)।

### विशेष धन्यवाद

Flink CDC समुदाय उन सभी का स्वागत करता है जो योगदान देने के इच्छुक हैं, चाहे वह बग रिपोर्ट्स सबमिट करना हो,  
डॉक्युमेंटेशन को बेहतर बनाना हो, या बग फिक्स, टेस्ट एडिशन या नई फीचर्स डेवलप करने के लिए कोड योगदान करना हो।  
सभी योगदानकर्ताओं को उनके उत्साही योगदान के लिए धन्यवाद।

<a href="https://github.com/apache/flink-cdc/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=apache/flink-cdc"/>
</a>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---