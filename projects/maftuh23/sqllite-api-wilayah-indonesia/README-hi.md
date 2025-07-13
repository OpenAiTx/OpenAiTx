# 🇮🇩 SQLite भारत का क्षेत्र

SQLite डेटाबेस में **इंडोनेशिया के प्रशासनिक क्षेत्रों का डेटा** BPS (Badan Pusat Statistik) के अनुसार पूर्ण रूप से शामिल है:

✅ प्रांत  
✅ रीजेंसी/शहर  
✅ उप-जिला  
✅ गाँव/वार्ड <br>
✅ पिन कोड

यह डेटा उन वेब, मोबाइल, और API एप्लिकेशनों के लिए उपयोगी है जिन्हें इंडोनेशिया के क्षेत्रों की हायरार्किकल रेफरेंस की आवश्यकता होती है।

---

## 🎯 विशेषताएँ

- इंडोनेशिया के क्षेत्र का आधिकारिक और पूर्ण डेटा
- हल्के, तेज़, और पोर्टेबल SQLite फॉर्मेट में
- **ओपन सोर्स**, व्यावसायिक और गैर-व्यावसायिक उपयोग के लिए स्वतंत्र
- Laravel, CodeIgniter, Node.js, या किसी अन्य फ्रेमवर्क के साथ आसानी से एकीकृत किया जा सकता है
- तालिकाओं के बीच संबंध से डेटा को लेयर अनुसार क्वेरी करना आसान
## 📂 डेटाबेस संरचना

डेटाबेस `records.sqlite` में निम्नलिखित टेबल्स शामिल हैं:

- `provinces`
- `regencies`
- `districts`
- `villages`

**टेबल्स के बीच संबंध:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## कॉम्पोज़र

📦 कॉम्पोज़र के माध्यम से इंस्टॉलेशन

यह पैकेज Packagist पर उपलब्ध है:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

इंस्टॉल करने का तरीका

कॉम्पोज़र कमांड चलाएँ:

composer require maftuhichsan/sqlite-wilayah-indonesia

इसके बाद, आप vendor पाथ में मौजूद डेटाबेस फ़ाइल का उपयोग कर सकते हैं:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP (PDO) में उपयोग का उदाहरण

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// सभी प्रांत प्राप्त करें
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 NPM के माध्यम से इंस्टॉलेशन

यह पैकेज NPM पर उपलब्ध है:

🔗 NPM - sqlite-wilayah-indonesia

इंस्टॉल करने का तरीका

NPM पैकेज मैनेजर का कमांड चलाएँ:

npm install sqlite-wilayah-indonesia

⸻

✨ Node.js में उपयोग का उदाहरण

```javascript
// sqlite3 का उपयोग करने का उदाहरण
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// node_modules में SQLite फाइल की ओर इंगित करें
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// सभी प्रांत प्राप्त करें
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 उपयोग करने का तरीका

### 1️⃣ डेटाबेस डाउनलोड करें

इस रिपॉजिटरी से `records.sqlite` फाइल डाउनलोड करें, फिर इसे अपने प्रोजेक्ट में सेव करें।

### 2️⃣ सीधे SQL क्वेरी करें

बुनियादी SQL क्वेरी का उदाहरण:

```sql
-- सभी प्रांत प्राप्त करें
SELECT * FROM provinces;

-- प्रांत आईडी के आधार पर जिले/शहर प्राप्त करें
SELECT * FROM cities WHERE city_province_code = '31';

-- जिले/शहर आईडी के आधार पर उप-जिले प्राप्त करें
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- उप-जिला आईडी के आधार पर गाँव/वार्ड प्राप्त करें
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 एंडपॉइंट एपीआई (जल्द आ रहा है):

स्टेटस एपीआई: विकासाधीन।

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---