# 🇮🇩 SQLite Indonesian Regions

A SQLite database containing **Indonesian administrative region data** based on the official data from BPS (Badan Pusat Statistik):

✅ Province  
✅ Regency/City  
✅ District  
✅ Village/Sub-district <br>
✅ Postal Code

This data is useful for web, mobile, and API applications that require a hierarchical reference of Indonesian regions.

---

## 🎯 Features

- Official and complete Indonesian regional data
- Lightweight, fast, and portable SQLite format
- **Open source**, free to use for commercial & non-commercial purposes
- Easy integration with Laravel, CodeIgniter, Node.js, or other frameworks
- Table relations make it easy to perform hierarchical data queries

---
## 📂 Database Structure

The `records.sqlite` database contains the following tables:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Table relationships:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Installation via Composer

This package is available on Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

How to Install

Run the following Composer command:

composer require maftuhichsan/sqlite-wilayah-indonesia

After that, you can use the database file found in the vendor path:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Example Usage in PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Get all provinces
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Installation via NPM

This package is available on NPM:

🔗 NPM - sqlite-wilayah-indonesia

How to Install

Run the NPM package manager command:

npm install sqlite-wilayah-indonesia

⸻

✨ Example Usage in Node.js

```javascript
// Example using sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Point to the SQLite file in node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Retrieve all provinces
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 How to Use

### 1️⃣ Download the Database

Download the `records.sqlite` file from this repository, then save it in your project.

### 2️⃣ Direct SQL Query

Basic SQL query examples:

```sql
-- Retrieve all provinces
SELECT * FROM provinces;

-- Retrieve regencies/cities by province ID
SELECT * FROM cities WHERE city_province_code = '31';

-- Retrieve sub-districts by regency/city ID
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Retrieve villages/urban villages by sub-district ID
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Coming Soon):

Status API: Currently in development.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---