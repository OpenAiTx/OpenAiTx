# 🇮🇹 SQLite Suddivisioni Amministrative Indonesia

Database SQLite che contiene **dati delle suddivisioni amministrative dell’Indonesia** basati su BPS (Badan Pusat Statistik) in modo completo:

✅ Provincia  
✅ Kabupaten/Kota  
✅ Kecamatan  
✅ Desa/Kelurahan <br>
✅ Codice Postale

Questi dati sono utili per applicazioni web, mobile e API che richiedono riferimenti gerarchici delle suddivisioni dell’Indonesia.

---

## 🎯 Caratteristiche

- Dati ufficiali e completi delle suddivisioni dell’Indonesia
- Formato SQLite leggero, veloce e portatile
- **Open source**, libero per uso commerciale e non commerciale
- Facile da integrare con Laravel, CodeIgniter, Node.js o altri framework
- Relazioni tra tabelle che facilitano query gerarchiche sui dati

---
## 📂 Struttura del Database

Il database `records.sqlite` contiene le seguenti tabelle:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relazioni tra le tabelle:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Installazione tramite Composer

Questo pacchetto è disponibile su Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Modalità di installazione

Esegui il comando Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

Dopo di ciò, puoi utilizzare il file del database presente nel percorso vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Esempio di Utilizzo in PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Recupera tutte le province
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Installazione tramite NPM

Questo pacchetto è disponibile su NPM:

🔗 NPM - sqlite-wilayah-indonesia

Come Installare

Esegui il comando del package manager NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Esempio di Utilizzo in Node.js

```javascript
// Esempio di utilizzo di sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Puntare al file SQLite in node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Recupera tutte le province
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Come Utilizzare

### 1️⃣ Scarica il Database

Scarica il file `records.sqlite` da questo repository, quindi salvalo nel tuo progetto.

### 2️⃣ Query SQL Diretta

Esempio di query SQL di base:

```sql
-- Prendi tutte le province
SELECT * FROM provinces;

-- Prendi i comuni/città in base all'ID della provincia
SELECT * FROM cities WHERE city_province_code = '31';

-- Prendi i distretti in base all'ID del comune/città
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Prendi i villaggi/quartieri in base all'ID del distretto
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (In Arrivo):

Status API: Attualmente in fase di sviluppo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---