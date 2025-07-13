# 🇮🇩 SQLite Endonezya Bölgeleri

SQLite veritabanı, **BPS (Badan Pusat Statistik)** kaynaklı tam **Endonezya idari bölge verilerini** içerir:

✅ Eyalet (Provinsi)  
✅ İl/Şehir (Kabupaten/Kota)  
✅ İlçe (Kecamatan)  
✅ Köy/Mahalle (Desa/Kelurahan) <br>
✅ Posta Kodu (Kode Pos)

Bu veri, Endonezya bölgesel referansına hiyerarşik olarak ihtiyaç duyan web, mobil ve API uygulamaları için kullanışlıdır.

---

## 🎯 Özellikler

- Endonezya'nın resmi ve eksiksiz bölge verileri
- Hafif, hızlı ve taşınabilir SQLite formatı
- **Açık kaynak**, ticari & ticari olmayan kullanımlar için serbesttir
- Laravel, CodeIgniter, Node.js veya diğer frameworklerle kolayca entegre edilebilir
- Tablolar arası ilişkiler, verilerin kademeli sorgulanmasını kolaylaştırır

---
## 📂 Veritabanı Yapısı

Veritabanı `records.sqlite` aşağıdaki tabloları içerir:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Tablolar arası ilişkiler:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Composer ile Kurulum

Bu paket Packagist'te mevcuttur:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Kurulum Yöntemi

Composer komutunu çalıştırın:

composer require maftuhichsan/sqlite-wilayah-indonesia

Bundan sonra, vendor yolunda bulunan veritabanı dosyasını kullanabilirsiniz:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP (PDO) ile Kullanım Örneği

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Tüm illeri al
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 NPM ile Kurulum

Bu paket NPM'de mevcuttur:

🔗 NPM - sqlite-wilayah-indonesia

Kurulum Yöntemi

NPM paket yöneticisi komutunu çalıştırın:

npm install sqlite-wilayah-indonesia

⸻

✨ Node.js'te Kullanım Örneği

```javascript
// sqlite3 kullanımı örneği
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// SQLite dosyasına node_modules içinde yönlendirin
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Tüm illeri alın
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Kullanım Şekli

### 1️⃣ Veritabanını İndirin

Bu repodan `records.sqlite` dosyasını indirin ve projenize kaydedin.

### 2️⃣ Doğrudan SQL Sorgusu

Temel SQL sorgusu örnekleri:

```sql
-- Tüm illeri al
SELECT * FROM provinces;

-- İl ID'sine göre ilçe/şehirleri al
SELECT * FROM cities WHERE city_province_code = '31';

-- İlçe/şehir ID'sine göre mahalleleri al
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Mahalle ID'sine göre köyleri/al
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Uç Nokta API (Yakında):

Durum API'si: Geliştirme aşamasında.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---