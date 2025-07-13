# 🇮🇩 SQLite 인도네시아 행정구역

SQLite 데이터베이스에는 BPS(중앙통계청)를 기반으로 한 **인도네시아 행정구역 데이터**가 완벽하게 포함되어 있습니다:

✅ 주(Provinsi)  
✅ 군/시(Kabupaten/Kota)  
✅ 구(Kecamatan)  
✅ 마을/동(Desa/Kelurahan) <br>
✅ 우편번호(코드 포스)

이 데이터는 인도네시아의 행정구역 참조가 필요한 웹, 모바일, API 애플리케이션에 유용합니다.

---

## 🎯 특징

- 인도네시아 공식 및 완전한 행정구역 데이터
- 가볍고, 빠르고, 휴대 가능한 SQLite 포맷
- **오픈 소스**, 상업적 및 비상업적 용도로 자유롭게 사용 가능
- Laravel, CodeIgniter, Node.js 또는 기타 프레임워크와 쉽게 통합 가능
- 테이블 간의 관계로 계층적 데이터 쿼리가 용이

---
## 📂 데이터베이스 구조

데이터베이스 `records.sqlite`에는 다음과 같은 테이블이 있습니다:

- `provinces`
- `regencies`
- `districts`
- `villages`

**테이블 간의 관계:**

- `regencies.province_id` → `provinces.id`
- `districts.regency_id` → `regencies.id`
- `villages.district_id` → `districts.id`

---

## Composer

📦 Composer를 통한 설치

이 패키지는 Packagist에서 사용할 수 있습니다:

🔗 Packagist - maftuhichsan/sqlite-wilayah-indonesia

설치 방법

Composer 명령어를 실행하세요:

composer require maftuhichsan/sqlite-wilayah-indonesia

이후, vendor 경로 내에 있는 데이터베이스 파일을 사용할 수 있습니다:

vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite


⸻

✨ PHP(PDO) 사용 예시

```php

$db = new PDO(__DIR__.'/vendor/maftuhichsan/sqlite-wilayah-indonesia/database/records.sqlite');

// 모든 주(Provinsi) 가져오기
$stmt = $db->query("SELECT * FROM provinces");
$provinces = $stmt->fetchAll(PDO::FETCH_ASSOC);

print_r($provinces);

```
⸻

## NPM

📦 NPM을 통한 설치

이 패키지는 NPM에서 사용할 수 있습니다:

🔗 NPM - sqlite-wilayah-indonesia

설치 방법

NPM 패키지 매니저 명령어를 실행하세요:

npm install sqlite-wilayah-indonesia

⸻

✨ Node.js에서의 사용 예시

```javascript
// sqlite3 사용 예시
const sqlite3 = require('sqlite3').verbose();
const path = require('path');

// node_modules 내 SQLite 파일 경로 지정
const dbPath = path.join(
  __dirname,
  'node_modules',
  'sqlite-wilayah-indonesia',
  'database',
  'records.sqlite'
);

const db = new sqlite3.Database(dbPath);

// 모든 주(Provinsi) 가져오기
db.all("SELECT * FROM provinces", [], (err, rows) => {
  if (err) {
    throw err;
  }
  console.log(rows);
});

db.close();
```
## 🚀 사용 방법

### 1️⃣ 데이터베이스 다운로드

이 저장소에서 `records.sqlite` 파일을 다운로드한 후, 프로젝트에 저장하세요.

### 2️⃣ 직접 SQL 쿼리 실행

기본 SQL 쿼리 예시:

```sql
-- 모든 주(도) 조회
SELECT * FROM provinces;

-- 주(도) ID로 시/군 조회
SELECT * FROM cities WHERE city_province_code = '31';

-- 시/군 ID로 읍/면/동 조회
SELECT * FROM sub_districts WHERE sub_district_city_code = '3171';

-- 읍/면/동 ID로 리/행정동 조회
SELECT * FROM villages WHERE village_sub_district_code = '3171020';

```
## 🌐 Endpoint API (곧 출시 예정):

Status API: 개발 중입니다.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---