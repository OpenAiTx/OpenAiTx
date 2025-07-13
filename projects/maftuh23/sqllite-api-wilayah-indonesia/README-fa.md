# 🇮🇩 پایگاه داده SQLite مناطق اندونزی

پایگاه داده SQLite شامل **اطلاعات مناطق اداری اندونزی** بر اساس BPS (اداره مرکزی آمار) به صورت کامل است:

✅ استان  
✅ شهرستان/شهر  
✅ بخش  
✅ روستا/محله <br>
✅ کد پستی

این داده‌ها برای برنامه‌های وب، موبایل و API‌هایی که به مرجع مناطق اندونزی به صورت سلسله‌مراتبی نیاز دارند، مفید است.

---

## 🎯 ویژگی‌ها

- داده‌های رسمی و کامل مناطق اندونزی
- فرمت SQLite سبک، سریع و قابل حمل
- **متن‌باز**، قابل استفاده آزاد برای اهداف تجاری و غیرتجاری
- ادغام آسان با Laravel، CodeIgniter، Node.js یا سایر فریم‌ورک‌ها
- ارتباط بین جداول، انجام کوئری‌های سلسله‌مراتبی را آسان می‌کند

---
## 📂 ساختار پایگاه داده

پایگاه داده `records.sqlite` شامل جداول زیر است:

- `provinces`
- `regencies`
- `districts`
- `villages`

**روابط بین جداول:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 نصب از طریق Composer

این پکیج در Packagist موجود است:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

روش نصب

دستور Composer زیر را اجرا کنید:

composer require maftuhichsan/sqlite-wilayah-indonesia

پس از آن، می‌توانید از فایل پایگاه داده موجود در مسیر vendor استفاده کنید:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ نمونه استفاده در PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// دریافت تمام استان‌ها
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 نصب از طریق NPM

این پکیج در NPM موجود است:

🔗 NPM - sqlite-wilayah-indonesia

روش نصب

دستور package manager مربوط به NPM را اجرا کنید:

npm install sqlite-wilayah-indonesia

⸻

✨ نمونه استفاده در Node.js

```javascript
// نمونه استفاده از sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// مسیر دهی به فایل SQLite در node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// دریافت تمام استان‌ها
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 نحوه استفاده

### 1️⃣ دانلود پایگاه داده

فایل `records.sqlite` را از این مخزن دانلود کرده و در پروژه خود ذخیره کنید.

### 2️⃣ کوئری مستقیم SQL

نمونه‌ای از کوئری پایه SQL:

```sql
-- دریافت همه استان‌ها
SELECT * FROM provinces;

-- دریافت شهرستان/شهر بر اساس شناسه استان
SELECT * FROM cities WHERE city_province_code = '31';

-- دریافت بخش‌ها بر اساس شناسه شهرستان/شهر
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- دریافت روستا/دهیاری بر اساس شناسه بخش
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (به‌زودی):

وضعیت API: در حال توسعه.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---