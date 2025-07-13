# 🇮🇩 SQLite Wilayah Indonesia

Banco de dados SQLite contendo **dados das regiões administrativas da Indonésia** com base no BPS (Badan Pusat Statistik) de forma completa:

✅ Província  
✅ Regência/Cidade  
✅ Subdistrito  
✅ Vila/Kelurahan <br>
✅ Código Postal

Esses dados são úteis para aplicativos web, mobile e API que necessitam de referência hierárquica das regiões da Indonésia.

---

## 🎯 Recursos

- Dados oficiais e completos das regiões da Indonésia
- Formato SQLite leve, rápido e portátil
- **Código aberto**, livre para uso comercial e não comercial
- Fácil integração com Laravel, CodeIgniter, Node.js ou outros frameworks
- Relações entre tabelas facilitam consultas de dados em vários níveis

---
## 📂 Estrutura do Banco de Dados

O banco de dados `records.sqlite` contém as tabelas:

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relação entre as tabelas:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Instalação via Composer

Este pacote está disponível no Packagist:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Como Instalar

Execute o comando do Composer:

composer require maftuhichsan/sqlite-wilayah-indonesia

Após isso, você pode utilizar o arquivo do banco de dados que está no caminho vendor:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Exemplo de Uso em PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Buscar todas as províncias
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Instalação via NPM

Este pacote está disponível no NPM:

🔗 NPM - sqlite-wilayah-indonesia

Como Instalar

Execute o comando do gerenciador de pacotes NPM:

npm install sqlite-wilayah-indonesia

⸻

✨ Exemplo de Uso no Node.js

```javascript
// Exemplo usando sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Aponte para o arquivo SQLite em node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Obtenha todas as províncias
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Como Usar

### 1️⃣ Baixe o Banco de Dados

Faça o download do arquivo `records.sqlite` deste repositório e salve-o no seu projeto.

### 2️⃣ Consulta SQL Direta

Exemplo de consulta SQL básica:

```sql
-- Buscar todas as províncias
SELECT * FROM provinces;

-- Buscar municípios/cidades pelo ID da província
SELECT * FROM cities WHERE city_province_code = '31';

-- Buscar distritos pelo ID do município/cidade
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Buscar vilas/bairros pelo ID do distrito
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Em Breve):

Status da API: Em desenvolvimento.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---