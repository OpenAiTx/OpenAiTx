<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/logo.png" alt="dbslice logo" width="128">
</p>

# dbslice

[![PyPI version](https://img.shields.io/pypi/v/dbslice)](https://pypi.org/project/dbslice/)
[![License: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Python 3.10+](https://img.shields.io/badge/python-3.10%2B-blue.svg)](https://www.python.org/downloads/)

로컬 개발 및 디버깅을 위해 최소한의 참조 무결성이 보장된 데이터베이스 하위 집합을 추출합니다.

## 문제점

전체 프로덕션 데이터베이스를 복사하는 것은 불가능합니다. 그러나 버그를 재현하려면 해당 버그를 일으킨 정확한 데이터가 필요합니다. **dbslice**는 외래 키 관계를 따라 참조 무결성을 보장하면서 필요한 레코드만 추출하여 이 문제를 해결합니다.

<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/dbslice-overview.png" alt="dbslice — seed to subset">
</p>

## 빠른 시작

```bash
# Install globally
uv tool install dbslice   # or: pip install dbslice

# Extract an order and all related records
dbslice extract postgres://localhost/myapp --seed "orders.id=12345" > subset.sql

# Import into local database
psql -d localdb < subset.sql
```
## 기능

- **제로 구성 시작** -- 스키마를 자동으로 탐색하며, 데이터 모델 파일이 필요 없음  
- **단일 명령어** -- 하나의 CLI 호출로 완전한 데이터 하위 집합 추출  
- **기본적으로 안전함** -- 민감한 필드(이메일, 전화번호, SSN 등)를 자동 감지 및 익명 처리  
- **컴플라이언스 프로필** -- 내장된 GDPR, HIPAA Safe Harbor, PCI-DSS 프로필과 2단계 PII 스캔  
- **컬럼 매핑 UI** -- 로컬 브라우저 UI를 통해 컬럼 시각적 매핑, 컴플라이언스 프로필 적용 및 설정 내보내기  
- **다양한 출력 형식** -- SQL, JSON, CSV  
- **스트리밍** -- 대용량 데이터셋(10만+ 행)에 대한 메모리 효율적 추출  
- **가상 외래 키** -- Django GenericForeignKeys 및 설정을 통한 암시적 관계 지원  
- **설정 파일** -- 반복 가능한 추출을 위한 YAML 기반 구성  
- **검증** -- 추출된 데이터의 참조 무결성 검사  

### 데이터베이스 지원

| 데이터베이스   | 상태                   |
|------------|-----------------------|
| PostgreSQL | 완전 지원              |
| MySQL      | 계획 중 (아직 구현되지 않음) |
| SQLite     | 계획 중 (아직 구현되지 않음) |

## 설치


```bash
# Install with uv (recommended)
uv add dbslice

# Try without installing
uvx dbslice --help

# Or with pip
pip install dbslice
```

## 사용법

### 기본 추출

```bash
# Extract by primary key
dbslice extract postgres://user:pass@host:5432/db --seed "orders.id=12345"

# Extract with WHERE clause
dbslice extract postgres://localhost/db --seed "orders:status='failed' AND created_at > '2024-01-01'"

# Multiple seeds
dbslice extract postgres://localhost/db \
  --seed "orders.id=100" \
  --seed "orders.id=101"
```

### 제어 흐름 탐색

```bash
# Limit depth (default: 3)
dbslice extract postgres://... --seed "orders.id=1" --depth 2

# Direction: up (parents only), down (children only), both (default)
dbslice extract postgres://... --seed "orders.id=1" --direction up
```

### 익명화

```bash
# Auto-anonymize detected sensitive fields
dbslice extract postgres://... --seed "users.id=1" --anonymize

# Redact additional fields
dbslice extract postgres://... --seed "users.id=1" --anonymize --redact "audit_logs.ip_address"
```

### 열 매핑 UI

열을 시각적으로 매핑하고, 컴플라이언스 프로필을 적용하며, 바로 사용할 수 있는 구성을 생성합니다 — 모두 로컬 브라우저 UI에서 가능합니다.

```bash
dbslice map postgres://localhost/myapp

# Custom port
dbslice map postgres://localhost/myapp --port 8888

# Also works with uvx (no install needed)
uvx dbslice map postgres://localhost/myapp
```
<table>
<tr>
<td width="50%"><strong>열을 익명화 규칙에 매핑하기</strong></td>
<td width="50%"><strong>설정 생성 및 내보내기</strong></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping.png" alt="열 매핑" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping_instructions.png" alt="생성된 설정" width="100%"></td>
</tr>
</table>

`127.0.0.1:9473`에서 실행되며 일회성 세션 토큰을 사용 — 데이터는 기기를 벗어나지 않습니다. GDPR, HIPAA 또는 PCI-DSS 프로필을 한 번의 클릭으로 적용하고, 마스킹되는 내용을 검토한 후 YAML을 다운로드하세요.

### 규정 준수 프로필


```bash
# HIPAA Safe Harbor — auto-masks all 18 identifier types
dbslice extract postgres://... --seed "patients.id=1" --compliance hipaa --compliance-strict

# Multiple profiles + audit manifest
dbslice extract postgres://... --seed "users.id=1" --compliance gdpr --compliance pci-dss -f subset.sql
# Produces subset.sql + subset.manifest.json
```

### 출력 형식

```bash
# SQL (default)
dbslice extract postgres://... --seed "orders.id=1" --output sql

# JSON fixtures
dbslice extract postgres://... --seed "orders.id=1" --output json --out-file fixtures/

# CSV
dbslice extract postgres://... --seed "orders.id=1" --output csv --out-file data/
```

### 가상 외래 키

데이터베이스 스키마에 정의되지 않은 관계(Django GenericForeignKeys, 암시적 관계)의 경우:

```yaml
# dbslice.yaml
database:
  url: postgres://localhost:5432/myapp

virtual_foreign_keys:
  - source_table: notifications
    source_columns: [object_id]
    target_table: orders
    description: "Generic FK to orders via ContentType"

  - source_table: audit_log
    source_columns: [user_id]
    target_table: users
    description: "Implicit FK without DB constraint"
```

```bash
dbslice extract --config dbslice.yaml --seed "users.id=1"
```

### 스키마 검사

```bash
dbslice inspect postgres://localhost/myapp
```

### 구성 파일

```bash
# Generate config from database
dbslice init postgres://localhost/myapp --out-file dbslice.yaml

# Use config
dbslice extract --config dbslice.yaml --seed "orders.id=12345"
```
## 작동 원리

1. **내부 조사(Introspect)** -- 데이터베이스 스키마를 읽어 테이블과 외래 키 관계를 탐색
2. **탐색(Traverse)** -- 시작 시드 레코드에서 BFS를 통해 FK 관계를 따라감
3. **추출(Extract)** -- 식별된 모든 레코드 가져오기
4. **정렬(Sort)** -- 올바른 INSERT 순서를 위한 위상 정렬 수행
5. **출력(Output)** -- 적절한 이스케이핑과 함께 SQL/JSON/CSV 생성

## 비교

| 기능 | dbslice | Jailer | Greenmask | slice-db |
|---------|---------|--------|-----------|----------|
| 언어 | Python | Java | Go | Ruby |
| 구성 | 제로 구성 | 모델 파일 필요 | 구성 필요 | 수동 YAML |
| 설치 시간 | 몇 초 | 몇 시간 | 중간 | 중간 |
| 익명화 | 내장 (Faker) | 플러그인 기반 | 고급 변환기 | 불가 |
| 컴플라이언스 프로필 | GDPR, HIPAA, PCI-DSS | 없음 | 없음 | 없음 |
| 컬럼 매핑 UI | 내장 (로컬) | 없음 | 없음 | 없음 |
| PII 값 스캔 | 2단계 (마스킹 전/후) | 없음 | 없음 | 없음 |
| 부분 집합화 | FK 탐색 | FK 탐색 | 제한적 | FK 탐색 |
| 출력 형식 | SQL, JSON, CSV | SQL, XML, CSV | SQL | SQL 전용 |
| 순환 처리 | 자동 | 수동 구성 | 해당 없음 | 수동 |
| 스트리밍 | 내장 | 구성 가능 | 내장 | 불가 |
| 유지보수 | 활성 | 활성 | 활성 | 미유지 |

**dbslice**는 가볍고 제로 구성인 Python 옵션으로, 설치 후 1분 내에 추출 가능하다.

## 개발


```bash
git clone https://github.com/nabroleonx/dbslice.git
cd dbslice
uv sync --dev
uv run pytest
```

## License

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-19

---