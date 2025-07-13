# 🇮🇩 قاعدة بيانات SQLite لمناطق إندونيسيا

قاعدة بيانات SQLite تحتوي على **بيانات المناطق الإدارية لإندونيسيا** بناءً على بيانات الهيئة المركزية للإحصاء (BPS) بشكل كامل:

✅ المقاطعة  
✅ الكابوبتن/المدينة  
✅ المقاطعة الفرعية (الكecamatan)  
✅ القرية/الحي (desa/kelurahan) <br>
✅ الرمز البريدي

تُعد هذه البيانات مفيدة لتطبيقات الويب، وتطبيقات الجوال، وواجهات برمجة التطبيقات (API) التي تحتاج إلى مرجع هيكلي لمناطق إندونيسيا.

---

## 🎯 الميزات

- بيانات رسمية وكاملة لمناطق إندونيسيا
- تنسيق SQLite خفيف وسريع وقابل للنقل
- **مفتوحة المصدر**، مجانية للاستخدام التجاري وغير التجاري
- سهلة التكامل مع Laravel، CodeIgniter، Node.js، أو أي إطار عمل آخر
- العلاقات بين الجداول تسهل الاستعلام عن البيانات بشكل هرمي

---
## 📂 هيكلية قاعدة البيانات

تحتوي قاعدة البيانات `records.sqlite` على الجداول التالية:

- `provinces`
- `regencies`
- `districts`
- `villages`

**العلاقات بين الجداول:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 التثبيت عبر Composer

هذه الحزمة متوفرة على Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

طريقة التثبيت

قم بتشغيل أمر Composer التالي:

composer require maftuhichsan/sqlite-wilayah-indonesia

بعد ذلك، يمكنك استخدام ملف قاعدة البيانات الموجود في مسار vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ مثال على الاستخدام في PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// جلب جميع المحافظات
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 التثبيت عبر NPM

هذا الحزمة متوفرة على NPM:

🔗 NPM - sqlite-wilayah-indonesia

طريقة التثبيت

شغّل أمر مدير الحزم NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ مثال الاستخدام في Node.js

```javascript
// مثال باستخدام sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// وجّه إلى ملف SQLite في node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// جلب جميع المحافظات
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 كيفية الاستخدام

### 1️⃣ تنزيل قاعدة البيانات

قم بتنزيل ملف `records.sqlite` من هذا المستودع، ثم احفظه في مشروعك.

### 2️⃣ استعلام SQL مباشر

مثال على استعلام SQL أساسي:

```sql
-- جلب جميع المحافظات
SELECT * FROM provinces;

-- جلب الكابوبتن/المدن بناءً على معرف المحافظة
SELECT * FROM cities WHERE city_province_code = '31';

-- جلب المناطق الفرعية بناءً على معرف الكابوبتن/المدينة
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- جلب القرى/البلديات بناءً على معرف المنطقة الفرعية
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 واجهة برمجة التطبيقات للنقاط النهائية (قريبًا):

واجهة برمجة تطبيقات الحالة: قيد التطوير.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---