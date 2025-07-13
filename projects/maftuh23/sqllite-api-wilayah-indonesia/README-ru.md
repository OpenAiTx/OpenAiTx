# 🇮🇩 SQLite Административные единицы Индонезии

База данных SQLite содержит **данные административных единиц Индонезии** на основе данных BPS (Центральное статистическое управление), полные:

✅ Провинции  
✅ Регентства/Города  
✅ Районы (Кечаматан)  
✅ Деревни/Поселки <br>
✅ Почтовые индексы

Эти данные полезны для веб-приложений, мобильных приложений и API, которым требуется иерархическая ссылка на административные единицы Индонезии.

---

## 🎯 Особенности

- Официальные и полные данные по административным единицам Индонезии
- Лёгкий, быстрый и переносимый формат SQLite
- **Open source**, свободно используется для коммерческих и некоммерческих целей
- Легко интегрируется с Laravel, CodeIgniter, Node.js или другими фреймворками
- Связи между таблицами упрощают иерархические запросы данных

---
## 📂 Структура базы данных

База данных `records.sqlite` содержит таблицы:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Связи между таблицами:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Установка через Composer

Пакет доступен на Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Способ установки

Выполните команду Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

После этого вы можете использовать файл базы данных, который находится в vendor path:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Пример использования на PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Получить все провинции
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Установка через NPM

Этот пакет доступен в NPM:

🔗 NPM - sqlite-wilayah-indonesia

Как установить

Выполните команду менеджера пакетов NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Пример использования в Node.js

```javascript
// Пример использования sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Укажите путь к файлу SQLite в node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Получить все провинции
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Как использовать

### 1️⃣ Загрузка базы данных

Скачайте файл `records.sqlite` из этого репозитория и сохраните его в вашем проекте.

### 2️⃣ Прямые SQL-запросы

Пример базовых SQL-запросов:

```sql
-- Получить все провинции
SELECT * FROM provinces;

-- Получить округа/города по ID провинции
SELECT * FROM cities WHERE city_province_code = '31';

-- Получить районы по ID округа/города
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Получить деревни/поселения по ID района
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Скоро будет доступен):

Status API: В настоящее время находится в разработке.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---