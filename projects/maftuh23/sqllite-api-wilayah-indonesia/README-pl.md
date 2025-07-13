# 🇮🇩 SQLite Wilayah Indonesia

Baza danych SQLite zawierająca **dane jednostek administracyjnych Indonezji** na podstawie BPS (Badan Pusat Statistik), kompletne:

✅ Prowincja  
✅ Powiat/Miasto  
✅ Okręg  
✅ Wieś/Osiedle <br>
✅ Kod pocztowy

Dane te są przydatne dla aplikacji webowych, mobilnych oraz API, które wymagają hierarchicznego odniesienia do terytorium Indonezji.

---

## 🎯 Funkcje

- Oficjalne i kompletne dane terytorium Indonezji
- Lekki, szybki i przenośny format SQLite
- **Open source**, darmowy do użytku komercyjnego i niekomercyjnego
- Łatwa integracja z Laravel, CodeIgniter, Node.js lub innymi frameworkami
- Relacje między tabelami ułatwiają zapytania do danych w sposób hierarchiczny

---
## 📂 Struktura Bazy Danych

Baza danych `records.sqlite` zawiera tabele:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relacje między tabelami:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Instalacja przez Composer

Pakiet jest dostępny na Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Sposób instalacji

Uruchom polecenie Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

Po tym możesz używać pliku bazy danych znajdującego się w ścieżce vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Przykład użycia w PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Pobierz wszystkie prowincje
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Instalacja przez NPM

Pakiet jest dostępny w NPM:

🔗 NPM - sqlite-wilayah-indonesia

Sposób instalacji

Uruchom polecenie menedżera pakietów NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Przykład użycia w Node.js

```javascript
// Przykład użycia sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Wskaż plik SQLite w node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Pobierz wszystkie województwa
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Sposób użycia

### 1️⃣ Pobierz bazę danych

Pobierz plik `records.sqlite` z tego repozytorium, a następnie zapisz go w swoim projekcie.

### 2️⃣ Bezpośrednie zapytania SQL

Przykład podstawowego zapytania SQL:

```sql
-- Pobierz wszystkie województwa
SELECT * FROM provinces;

-- Pobierz powiaty/miasta na podstawie ID województwa
SELECT * FROM cities WHERE city_province_code = '31';

-- Pobierz gminy na podstawie ID powiatu/miasta
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Pobierz wsie/osiedla na podstawie ID gminy
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Wkrótce dostępne): 

Status API: W trakcie opracowywania.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---