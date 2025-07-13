# 🇮🇩 SQLite เขตการปกครองของอินโดนีเซีย

ฐานข้อมูล SQLite ที่มี **ข้อมูลเขตการปกครองของอินโดนีเซีย** ตาม BPS (สำนักงานสถิติกลาง) อย่างครบถ้วน:

✅ จังหวัด  
✅ อำเภอ/เมือง  
✅ ตำบล  
✅ หมู่บ้าน/ตำบลเมือง <br>
✅ รหัสไปรษณีย์

ข้อมูลนี้มีประโยชน์สำหรับแอปพลิเคชันเว็บ, โมบาย, และ API ที่ต้องการอ้างอิงข้อมูลเขตการปกครองของอินโดนีเซียแบบลำดับชั้น

---

## 🎯 คุณสมบัติ

- ข้อมูลเขตการปกครองของอินโดนีเซียที่เป็นทางการและครบถ้วน
- รูปแบบ SQLite ที่เบา รวดเร็ว และพกพาสะดวก
- **โอเพนซอร์ส** ใช้งานได้ฟรีทั้งเชิงพาณิชย์และไม่ใช่เชิงพาณิชย์
- ง่ายต่อการเชื่อมต่อกับ Laravel, CodeIgniter, Node.js หรือเฟรมเวิร์กอื่น ๆ
- ความสัมพันธ์ระหว่างตารางช่วยให้สามารถ query ข้อมูลแบบลำดับชั้นได้สะดวก

---
## 📂 โครงสร้างฐานข้อมูล

ฐานข้อมูล `records.sqlite` ประกอบด้วยตาราง:

- `provinces`
- `regencies`
- `districts`
- `villages`

**ความสัมพันธ์ระหว่างตาราง:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 การติดตั้งผ่าน Composer

แพ็คเกจนี้มีให้บริการที่ Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

วิธีการติดตั้ง

รันคำสั่ง Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

หลังจากนั้น คุณสามารถใช้ไฟล์ฐานข้อมูลที่อยู่ใน vendor path:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ ตัวอย่างการใช้งานใน PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// ดึงข้อมูลจังหวัดทั้งหมด
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 การติดตั้งผ่าน NPM

แพ็กเกจนี้มีให้ใช้งานใน NPM:

🔗 NPM - sqlite-wilayah-indonesia

วิธีติดตั้ง

รันคำสั่ง package manager NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ ตัวอย่างการใช้งานใน Node.js

```javascript
// ตัวอย่างการใช้ sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// ชี้ไปที่ไฟล์ SQLite ใน node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// ดึงข้อมูลจังหวัดทั้งหมด
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 วิธีการใช้งาน

### 1️⃣ ดาวน์โหลดฐานข้อมูล

ดาวน์โหลดไฟล์ `records.sqlite` จาก repository นี้ แล้วบันทึกไว้ในโปรเจกต์ของคุณ

### 2️⃣ คิวรี SQL โดยตรง

ตัวอย่างคิวรี SQL พื้นฐาน:

```sql
-- ดึงข้อมูลจังหวัดทั้งหมด
SELECT * FROM provinces;

-- ดึงข้อมูลอำเภอ/เมืองตามรหัสจังหวัด
SELECT * FROM cities WHERE city_province_code = '31';

-- ดึงข้อมูลตำบลตามรหัสอำเภอ/เมือง
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- ดึงข้อมูลหมู่บ้าน/แขวงตามรหัสตำบล
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (เร็วๆ นี้):

Status API: กำลังอยู่ในระหว่างการพัฒนา.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---