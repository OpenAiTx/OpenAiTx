# 🇮🇩 SQLite 印度尼西亚行政区划

SQLite 数据库包含基于 BPS（印度尼西亚中央统计局）的**印度尼西亚行政区划完整数据**：

✅ 省份  
✅ 县/市  
✅ 区  
✅ 村/街道 <br>
✅ 邮政编码

该数据适用于需要分层印度尼西亚行政区划参考的 Web 应用、移动应用和 API。

---

## 🎯 特点

- 官方且完整的印度尼西亚行政区划数据
- 轻量、快速、可移植的 SQLite 格式
- **开源**，可自由用于商业和非商业用途
- 易于与 Laravel、CodeIgniter、Node.js 或其他框架集成
- 表间关联便于分级数据查询

---
## 📂 数据库结构

数据库 `records.sqlite` 包含以下数据表：

- `provinces`
- `regencies`
- `districts`
- `villages`

**表之间的关系：**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 通过 Composer 安装

该包已发布在 Packagist：

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

安装方法

运行 Composer 命令：

composer require maftuhichsan/sqlite-wilayah-indonesia

之后，您可以使用 vendor 路径中的数据库文件：

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP（PDO）使用示例

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// 获取所有省份
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 通过 NPM 安装

该包已在 NPM 上提供：

🔗 NPM - sqlite-wilayah-indonesia

安装方法

运行 NPM 包管理器命令：

npm install sqlite-wilayah-indonesia

⸻

✨ 在 Node.js 中的使用示例

```javascript
// 使用 sqlite3 的示例
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// 指向 node_modules 中的 SQLite 文件
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// 获取所有省份
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 使用方法

### 1️⃣ 下载数据库

从本仓库下载 `records.sqlite` 文件，然后将其保存到您的项目中。

### 2️⃣ 直接使用 SQL 查询

基础 SQL 查询示例：

```sql
-- 获取所有省份
SELECT * FROM provinces;

-- 根据省份ID获取所有的县/市
SELECT * FROM cities WHERE city_province_code = '31';

-- 根据县/市ID获取所有的区/乡镇
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- 根据区/乡镇ID获取所有的村/社区
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 端点 API（即将推出）：

状态 API：正在开发中。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---