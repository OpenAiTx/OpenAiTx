# 🇮🇩 SQLite 印尼行政區域

SQLite 資料庫包含根據 BPS（印尼中央統計局）**完整的印尼行政區域資料**：

✅ 省  
✅ 縣/市  
✅ 區  
✅ 村/鎮 <br>
✅ 郵遞區號

這些資料適用於需要分層印尼區域參考的網頁、行動應用程式，以及 API。

---

## 🎯 功能

- 印尼官方且完整的區域資料
- 輕量、快速、可攜帶的 SQLite 格式
- **開源**，可自由用於商業或非商業用途
- 容易整合至 Laravel、CodeIgniter、Node.js 或其他框架
- 表格之間的關聯方便進行階層式查詢

---
## 📂 資料庫結構

資料庫 `records.sqlite` 包含以下資料表：

- `provinces`
- `regencies`
- `districts`
- `villages`

**資料表之間的關聯：**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 透過 Composer 安裝

此套件可於 Packagist 取得：

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

安裝方式

執行 Composer 指令：

composer require maftuhichsan/sqlite-wilayah-indonesia

之後，您可以使用位於 vendor 路徑內的資料庫檔案：

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP (PDO) 使用範例

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// 取得所有省份
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 透過 NPM 安裝

此套件可在 NPM 上取得：

🔗 NPM - sqlite-wilayah-indonesia

安裝方法

執行 NPM 套件管理指令：

npm install sqlite-wilayah-indonesia

⸻

✨ Node.js 使用範例

```javascript
// 使用 sqlite3 的範例
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// 指向 node_modules 內的 SQLite 檔案
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// 取得所有省份
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 使用方法

### 1️⃣ 下載資料庫

下載本儲存庫中的 `records.sqlite` 檔案，然後將其存放到您的專案中。

### 2️⃣ 直接執行 SQL 查詢

基本 SQL 查詢範例：

```sql
-- 取得所有省份
SELECT * FROM provinces;

-- 根據省份 ID 取得縣市
SELECT * FROM cities WHERE city_province_code = '31';

-- 根據縣市 ID 取得區/鄉/鎮
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- 根據區/鄉/鎮 ID 取得村/里
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API（即將推出）:

狀態 API：正在開發中。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---