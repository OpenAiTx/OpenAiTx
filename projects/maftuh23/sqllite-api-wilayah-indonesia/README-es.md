# 🇮🇩 SQLite Wilayah Indonesia

Base de datos SQLite que contiene **datos de las divisiones administrativas de Indonesia** según BPS (Badan Pusat Statistik) de forma completa:

✅ Provincia  
✅ Kabupaten/Kota  
✅ Kecamatan  
✅ Desa/Kelurahan <br>
✅ Código Postal

Estos datos son útiles para aplicaciones web, móviles y API que necesitan una referencia jerárquica de las regiones de Indonesia.

---

## 🎯 Características

- Datos oficiales y completos de las regiones de Indonesia
- Formato SQLite, ligero, rápido y portátil
- **Código abierto**, libre para uso comercial y no comercial
- Fácil integración con Laravel, CodeIgniter, Node.js u otros frameworks
- Relaciones entre tablas que facilitan consultas de datos jerárquicas

---
## 📂 Estructura de la Base de Datos

La base de datos `records.sqlite` contiene las siguientes tablas:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relaciones entre las tablas:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Instalación vía Composer

Este paquete está disponible en Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Cómo Instalar

Ejecute el siguiente comando de Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

Después de eso, puede utilizar el archivo de base de datos que se encuentra en la ruta vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Ejemplo de Uso en PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Obtener todas las provincias
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Instalación vía NPM

Este paquete está disponible en NPM:

🔗 NPM - sqlite-wilayah-indonesia

Cómo Instalar

Ejecuta el siguiente comando del gestor de paquetes NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Ejemplo de Uso en Node.js

```javascript
// Ejemplo usando sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Apunta al archivo SQLite en node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Obtener todas las provincias
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Cómo Usar

### 1️⃣ Descargar la Base de Datos

Descarga el archivo `records.sqlite` de este repositorio y guárdalo en tu proyecto.

### 2️⃣ Consulta SQL Directa

Ejemplo de consulta SQL básica:

```sql
-- Obtener todas las provincias
SELECT * FROM provinces;

-- Obtener municipios/ciudades según el ID de la provincia
SELECT * FROM cities WHERE city_province_code = '31';

-- Obtener distritos según el ID del municipio/ciudad
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Obtener aldeas/barrios según el ID del distrito
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Próximamente):

API de Estado: Actualmente en desarrollo.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---