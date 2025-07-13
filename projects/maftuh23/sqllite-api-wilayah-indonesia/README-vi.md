# 🇮🇩 SQLite Địa Giới Hành Chính Indonesia

Cơ sở dữ liệu SQLite chứa **dữ liệu vùng hành chính Indonesia** theo BPS (Badan Pusat Statistik) đầy đủ:

✅ Tỉnh  
✅ Huyện/Thành phố  
✅ Quận/Huyện  
✅ Xã/Phường <br>
✅ Mã bưu điện

Dữ liệu này hữu ích cho các ứng dụng web, di động và API cần tham chiếu vùng lãnh thổ Indonesia theo cấu trúc phân cấp.

---

## 🎯 Tính năng

- Dữ liệu chính thức và đầy đủ về các vùng của Indonesia
- Định dạng SQLite nhẹ, nhanh và di động
- **Mã nguồn mở**, tự do sử dụng cho mục đích thương mại & phi thương mại
- Dễ dàng tích hợp với Laravel, CodeIgniter, Node.js hoặc các framework khác
- Quan hệ giữa các bảng giúp truy vấn dữ liệu phân cấp dễ dàng

---
## 📂 Cấu trúc Cơ sở Dữ liệu

Cơ sở dữ liệu `records.sqlite` chứa các bảng:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Quan hệ giữa các bảng:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Cài đặt qua Composer

Gói này có sẵn trên Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Cách Cài đặt

Chạy lệnh Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

Sau đó, bạn có thể sử dụng file cơ sở dữ liệu có trong đường dẫn vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Ví dụ Sử dụng trong PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Lấy tất cả các tỉnh
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Cài đặt qua NPM

Gói này có sẵn trên NPM:

🔗 NPM - sqlite-wilayah-indonesia

Cách Cài Đặt

Chạy lệnh trình quản lý gói NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Ví dụ Sử dụng trong Node.js

```javascript
// Ví dụ sử dụng sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Trỏ đến file SQLite trong node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Lấy tất cả các tỉnh
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Cách Sử Dụng

### 1️⃣ Tải Xuống Cơ Sở Dữ Liệu

Tải file `records.sqlite` từ repository này, sau đó lưu vào dự án của bạn.

### 2️⃣ Truy Vấn SQL Trực Tiếp

Ví dụ truy vấn SQL cơ bản:

```sql
-- Lấy tất cả các tỉnh/thành phố trực thuộc trung ương
SELECT * FROM provinces;

-- Lấy huyện/thành phố theo ID tỉnh
SELECT * FROM cities WHERE city_province_code = '31';

-- Lấy xã/phường/thị trấn theo ID huyện/thành phố
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Lấy thôn/xã/phường theo ID xã/phường/thị trấn
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Sắp ra mắt):

Status API: Đang được phát triển.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---