# 🇮🇩 SQLite インドネシア地域データベース

SQLiteデータベースには、**BPS（インドネシア統計庁）に基づくインドネシアの行政区域データ**が完全に含まれています：

✅ 州（Provinsi）  
✅ 県/市（Kabupaten/Kota）  
✅ 郡（Kecamatan）  
✅ 村/町（Desa/Kelurahan） <br>
✅ 郵便番号（Kode Pos）

このデータは、インドネシアの地域リファレンスが階層的に必要なWebアプリ、モバイルアプリ、APIに役立ちます。

---

## 🎯 特徴

- インドネシアの公式かつ完全な地域データ
- 軽量、高速、ポータブルなSQLiteフォーマット
- **オープンソース**、商用・非商用問わず自由に利用可能
- Laravel、CodeIgniter、Node.jsその他フレームワークとの統合が簡単
- テーブル間のリレーションにより階層的なデータクエリが容易

---
## 📂 データベース構造

データベース `records.sqlite` には以下のテーブルが含まれています：

- `provinces`
- `regencies`
- `districts`
- `villages`

**テーブル間のリレーション:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Composerによるインストール

このパッケージはPackagistで利用可能です：

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

インストール方法

Composerコマンドを実行してください：

composer require maftuhichsan/sqlite-wilayah-indonesia

その後、vendorパス内のデータベースファイルを使用できます：

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP（PDO）での使用例

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// すべての都道府県を取得
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 NPM経由でのインストール

このパッケージはNPMで利用可能です:

🔗 NPM - sqlite-wilayah-indonesia

インストール方法

NPMパッケージマネージャのコマンドを実行してください:

npm install sqlite-wilayah-indonesia

⸻

✨ Node.jsでの使用例

```javascript
// sqlite3の使用例
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// node_modules内のSQLiteファイルへのパスを指定
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// 全ての都道府県を取得
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 使い方

### 1️⃣ データベースのダウンロード

このリポジトリから `records.sqlite` ファイルをダウンロードし、プロジェクトに保存してください。

### 2️⃣ 直接SQLクエリを実行

基本的なSQLクエリの例：

```sql
-- すべての州（都道府県）を取得
SELECT * FROM provinces;

-- 州IDに基づいて市/区を取得
SELECT * FROM cities WHERE city_province_code = '31';

-- 市/区IDに基づいて郡（サブディストリクト）を取得
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- 郡IDに基づいて村/町を取得
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 エンドポイントAPI（近日公開）:

ステータスAPI：開発中です。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---