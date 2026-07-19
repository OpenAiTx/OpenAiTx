<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/logo.png" alt="dbslice ロゴ" width="128">
</p>

# dbslice

[![PyPI バージョン](https://img.shields.io/pypi/v/dbslice)](https://pypi.org/project/dbslice/)
[![ライセンス: MIT](https://img.shields.io/badge/License-MIT-blue.svg)](https://opensource.org/licenses/MIT)
[![Python 3.10+](https://img.shields.io/badge/python-3.10%2B-blue.svg)](https://www.python.org/downloads/)

ローカル開発とデバッグのための最小限かつ参照整合性を保つデータベース部分集合を抽出します。

## 問題点

本番データベース全体を自分のマシンにコピーするのは現実的ではありません。しかし、バグを再現するには、そのバグを引き起こした正確なデータが必要なことが多いです。**dbslice** は必要なレコードだけを抽出し、外部キー関係をたどって参照整合性を保証することでこれを解決します。

<p align="center">
  <img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/dbslice-overview.png" alt="dbslice — シードから部分集合へ">
</p>

## クイックスタート

```bash
# Install globally
uv tool install dbslice   # or: pip install dbslice

# Extract an order and all related records
dbslice extract postgres://localhost/myapp --seed "orders.id=12345" > subset.sql

# Import into local database
psql -d localdb < subset.sql
```
## 特徴

- **ゼロコンフィグ開始** -- スキーマを自動的に解析し、データモデルファイルは不要
- **シングルコマンド** -- 1回のCLI呼び出しで完全なデータサブセットを抽出
- **デフォルトで安全** -- 敏感なフィールド（メール、電話番号、SSNなど）を自動検出して匿名化
- **コンプライアンスプロファイル** -- GDPR、HIPAAセーフハーバー、PCI-DSSの組み込みプロファイル、2段階のPIIスキャン付き
- **カラムマッピングUI** -- ローカルブラウザUIでカラムを視覚的にマッピングし、コンプライアンスプロファイルを適用し、設定をエクスポート
- **複数の出力形式** -- SQL、JSON、CSV
- **ストリーミング** -- 大規模データセット（10万行以上）に対応したメモリ効率の良い抽出
- **仮想外部キー** -- DjangoのGenericForeignKeysや設定による暗黙的なリレーションに対応
- **設定ファイル** -- 繰り返し抽出可能なYAMLベースの設定
- **検証** -- 抽出データの参照整合性をチェック

### データベースサポート

| データベース   | ステータス                |
|------------|-----------------------|
| PostgreSQL | 完全対応       |
| MySQL      | 計画中（まだ実装されていません） |
| SQLite     | 計画中（まだ実装されていません） |

## インストール


```bash
# Install with uv (recommended)
uv add dbslice

# Try without installing
uvx dbslice --help

# Or with pip
pip install dbslice
```

## 使用法

### 基本的な抽出

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

### コントロール・トラバーサル

```bash
# Limit depth (default: 3)
dbslice extract postgres://... --seed "orders.id=1" --depth 2

# Direction: up (parents only), down (children only), both (default)
dbslice extract postgres://... --seed "orders.id=1" --direction up
```

### 匿名化

```bash
# Auto-anonymize detected sensitive fields
dbslice extract postgres://... --seed "users.id=1" --anonymize

# Redact additional fields
dbslice extract postgres://... --seed "users.id=1" --anonymize --redact "audit_logs.ip_address"
```

### カラムマッピングUI

カラムを視覚的にマッピングし、コンプライアンスプロファイルを適用し、すぐに使える設定を生成します — すべてローカルブラウザのUIから。

```bash
dbslice map postgres://localhost/myapp

# Custom port
dbslice map postgres://localhost/myapp --port 8888

# Also works with uvx (no install needed)
uvx dbslice map postgres://localhost/myapp
```
<table>
<tr>
<td width="50%"><strong>列を匿名化ルールにマッピング</strong></td>
<td width="50%"><strong>設定を生成してエクスポート</strong></td>
</tr>
<tr>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping.png" alt="列のマッピング" width="100%"></td>
<td><img src="https://raw.githubusercontent.com/nabroleonx/dbslice/main/docs/assets/mapping_instructions.png" alt="生成された設定" width="100%"></td>
</tr>
</table>

`127.0.0.1:9473`で動作し、一度限りのセッショントークンを使用 — データはマシンを離れません。GDPR、HIPAA、またはPCI-DSSプロファイルをワンクリックで適用し、マスクされる内容を確認してからYAMLをダウンロードしてください。

### コンプライアンスプロファイル


```bash
# HIPAA Safe Harbor — auto-masks all 18 identifier types
dbslice extract postgres://... --seed "patients.id=1" --compliance hipaa --compliance-strict

# Multiple profiles + audit manifest
dbslice extract postgres://... --seed "users.id=1" --compliance gdpr --compliance pci-dss -f subset.sql
# Produces subset.sql + subset.manifest.json
```

### 出力形式

```bash
# SQL (default)
dbslice extract postgres://... --seed "orders.id=1" --output sql

# JSON fixtures
dbslice extract postgres://... --seed "orders.id=1" --output json --out-file fixtures/

# CSV
dbslice extract postgres://... --seed "orders.id=1" --output csv --out-file data/
```

### 仮想外部キー

データベーススキーマに定義されていないリレーションシップ（DjangoのGenericForeignKeys、暗黙のリレーションシップ）について：

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

### スキーマの検査

```bash
dbslice inspect postgres://localhost/myapp
```

### 設定ファイル

```bash
# Generate config from database
dbslice init postgres://localhost/myapp --out-file dbslice.yaml

# Use config
dbslice extract --config dbslice.yaml --seed "orders.id=12345"
```
## 仕組み

1. **イントロスペクト** -- データベーススキーマを読み取り、テーブルと外部キーの関係を発見する  
2. **トラバース** -- シードレコードから開始し、BFSで外部キー関係をたどる  
3. **抽出** -- 特定されたすべてのレコードを取得する  
4. **ソート** -- 正しいINSERT順になるようにテーブルをトポロジカルソートする  
5. **出力** -- 適切なエスケープ付きでSQL/JSON/CSVを生成する  

## 比較

| 機能 | dbslice | Jailer | Greenmask | slice-db |
|---------|---------|--------|-----------|----------|
| 言語 | Python | Java | Go | Ruby |
| 設定 | ゼロコンフィグ | モデルファイル必須 | 設定必須 | 手動YAML |
| セットアップ時間 | 数秒 | 数時間 | 中程度 | 中程度 |
| 匿名化 | 内蔵（Faker） | プラグインベース | 高度な変換器 | 利用不可 |
| コンプライアンスプロファイル | GDPR, HIPAA, PCI-DSS | なし | なし | なし |
| カラムマッピングUI | 内蔵（ローカル） | なし | なし | なし |
| PII値スキャン | 二段階（マスク前後） | なし | なし | なし |
| サブセット化 | 外部キー走査 | 外部キー走査 | 制限あり | 外部キー走査 |
| 出力形式 | SQL, JSON, CSV | SQL, XML, CSV | SQL | SQLのみ |
| 循環処理 | 自動 | 手動設定 | 該当なし | 手動 |
| ストリーミング | 内蔵 | 設定可能 | 内蔵 | 利用不可 |
| メンテナンス | 活発 | 活発 | 活発 | メンテナンス終了 |

**dbslice** は軽量でゼロコンフィグのPythonオプションです：インストールして1分以内に抽出できます。

## 開発


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