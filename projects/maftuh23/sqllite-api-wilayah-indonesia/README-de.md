# 🇩🇪 SQLite Regionen Indonesiens

SQLite-Datenbank enthält **Verwaltungsgebietsdaten von Indonesien** gemäß BPS (Zentralamt für Statistik), vollständig:

✅ Provinz  
✅ Regierungsbezirk/Stadt  
✅ Distrikt  
✅ Dorf/Kelurahan <br>
✅ Postleitzahl

Diese Daten sind nützlich für Web-, Mobile-Anwendungen und APIs, die eine hierarchische Referenz der indonesischen Regionen benötigen.

---

## 🎯 Funktionen

- Offizielle und vollständige Daten der indonesischen Regionen
- Leichtgewichtiges, schnelles und portables SQLite-Format
- **Open Source**, frei für kommerzielle & nicht-kommerzielle Zwecke verwendbar
- Einfache Integration mit Laravel, CodeIgniter, Node.js oder anderen Frameworks
- Beziehungen zwischen Tabellen erleichtern gestufte Datenabfragen

---
## 📂 Datenbankstruktur

Die Datenbank `records.sqlite` enthält folgende Tabellen:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Beziehungen zwischen den Tabellen:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Installation über Composer

Dieses Paket ist auf Packagist verfügbar:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Installationsanleitung

Führen Sie den folgenden Composer-Befehl aus:

composer require maftuhichsan/sqlite-wilayah-indonesia

Danach können Sie die Datenbankdatei im Vendor-Verzeichnis verwenden:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Beispiel für die Verwendung in PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Alle Provinzen abrufen
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Installation über NPM

Dieses Paket ist auf NPM verfügbar:

🔗 NPM - sqlite-wilayah-indonesia

Installationsanleitung

Führen Sie den folgenden Befehl im NPM-Paketmanager aus:

npm install sqlite-wilayah-indonesia

⸻

✨ Beispiel für die Verwendung in Node.js

```javascript
// Beispiel mit sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Verweis auf die SQLite-Datei im node_modules-Verzeichnis
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Alle Provinzen abrufen
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Verwendungshinweise

### 1️⃣ Datenbank herunterladen

Laden Sie die Datei `records.sqlite` aus diesem Repository herunter und speichern Sie sie in Ihrem Projekt.

### 2️⃣ Direkte SQL-Abfragen

Beispiel für eine einfache SQL-Abfrage:

```sql
-- Alle Provinzen abrufen
SELECT * FROM provinces;

-- Landkreise/Städte anhand der Provinz-ID abrufen
SELECT * FROM cities WHERE city_province_code = '31';

-- Bezirke anhand der Landkreis-/Stadt-ID abrufen
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Dörfer/Gemeinden anhand der Bezirks-ID abrufen
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Demnächst verfügbar):

Status-API: Befindet sich in der Entwicklung.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---