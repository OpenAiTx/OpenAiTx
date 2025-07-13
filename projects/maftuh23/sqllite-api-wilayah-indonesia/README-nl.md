# 🇮🇩 SQLite Gebieden Indonesië

SQLite-database bevat **gegevens van de administratieve gebieden van Indonesië** gebaseerd op BPS (Badan Pusat Statistik) die compleet zijn:

✅ Provincie  
✅ Kabupaten/Stad  
✅ Kecamatan  
✅ Dorp/Kelurahan <br>
✅ Postcode

Deze gegevens zijn nuttig voor web-, mobiele applicaties en API's die een hiërarchische referentie van de Indonesische gebieden nodig hebben.

---

## 🎯 Functies

- Officiële en volledige gegevens van de Indonesische gebieden
- Lichtgewicht, snel en draagbaar SQLite-formaat
- **Open source**, vrij te gebruiken voor commerciële & niet-commerciële doeleinden
- Eenvoudig te integreren met Laravel, CodeIgniter, Node.js of andere frameworks
- Relaties tussen tabellen vergemakkelijken het hiërarchisch opvragen van gegevens

---
## 📂 Databasestructuur

De database `records.sqlite` bevat de volgende tabellen:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relaties tussen de tabellen:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Installatie via Composer

Dit pakket is beschikbaar op Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Installatie-instructies

Voer het volgende Composer-commando uit:

composer require maftuhichsan/sqlite-wilayah-indonesia

Daarna kun je het databasebestand gebruiken dat zich in het vendor-pad bevindt:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Voorbeeld van gebruik in PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Haal alle provincies op
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Installatie via NPM

Dit pakket is beschikbaar op NPM:

🔗 NPM - sqlite-wilayah-indonesia

Installatie-instructies

Voer het volgende NPM package manager-commando uit:

npm install sqlite-wilayah-indonesia

⸻

✨ Voorbeeld van Gebruik in Node.js

```javascript
// Voorbeeld met sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Verwijs naar het SQLite-bestand in node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Haal alle provincies op
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Gebruikshandleiding

### 1️⃣ Download de Database

Download het bestand `records.sqlite` uit deze repository en sla het op in uw project.

### 2️⃣ Directe SQL-query

Voorbeeld van een basis SQL-query:

```sql
-- Haal alle provincies op
SELECT * FROM provinces;

-- Haal regentschappen/steden op basis van provincie-ID op
SELECT * FROM cities WHERE city_province_code = '31';

-- Haal districten op basis van regentschap/stad-ID op
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Haal dorpen/kelurahan op basis van district-ID op
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Binnenkort beschikbaar):

Status API: Momenteel in ontwikkeling.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---