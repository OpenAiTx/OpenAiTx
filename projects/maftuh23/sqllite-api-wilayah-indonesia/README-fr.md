# 🇮🇩 SQLite Régions d’Indonésie

Base de données SQLite contenant les **données des divisions administratives de l’Indonésie** selon la BPS (Badan Pusat Statistik), complètes :

✅ Province  
✅ Kabupaten/Kota (Département/Ville)  
✅ Kecamatan (Arrondissement)  
✅ Desa/Kelurahan (Village/Quartier) <br>
✅ Code postal

Ces données sont utiles pour les applications web, mobiles et les API nécessitant une référence hiérarchique des régions d’Indonésie.

---

## 🎯 Fonctionnalités

- Données officielles et complètes des régions d’Indonésie
- Format SQLite léger, rapide et portable
- **Open source**, utilisation libre à des fins commerciales & non commerciales
- Facile à intégrer avec Laravel, CodeIgniter, Node.js ou d’autres frameworks
- Relations entre les tables facilitant les requêtes de données hiérarchisées

---
## 📂 Structure de la base de données

La base de données `records.sqlite` contient les tables :

- `provinces`
- `regencies`
- `districts`
- `villages`

**Relations entre les tables :**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Installation via Composer

Ce paquet est disponible sur Packagist :

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

Méthode d'installation

Exécutez la commande Composer :

composer require maftuhichsan/sqlite-wilayah-indonesia

Après cela, vous pouvez utiliser le fichier de base de données situé dans le chemin vendor :

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ Exemple d’utilisation en PHP (PDO)

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// Récupérer toutes les provinces
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 Installation via NPM

Ce paquet est disponible sur NPM :

🔗 NPM - sqlite-wilayah-indonesia

Méthode d'installation

Exécutez la commande du gestionnaire de paquets NPM :

npm install sqlite-wilayah-indonesia

⸻

✨ Exemple d’utilisation avec Node.js

```javascript
// Exemple d'utilisation de sqlite3
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// Pointez vers le fichier SQLite dans node_modules
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// Récupérer toutes les provinces
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 Mode d'emploi

### 1️⃣ Télécharger la base de données

Téléchargez le fichier `records.sqlite` depuis ce dépôt, puis enregistrez-le dans votre projet.

### 2️⃣ Requête SQL directe

Exemple de requêtes SQL basiques :

```sql
-- Récupérer toutes les provinces
SELECT * FROM provinces;

-- Récupérer les départements/villes selon l'ID de la province
SELECT * FROM cities WHERE city_province_code = '31';

-- Récupérer les districts selon l'ID du département/ville
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- Récupérer les villages/quartiers selon l'ID du district
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (Bientôt disponible) : 

API de statut : En cours de développement.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---