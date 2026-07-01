# DocLite

SQLite 위에 구축된 강력한 PHP NoSQL 문서 저장소입니다.

[![CI](https://github.com/dwgebler/doclite/actions/workflows/ci.yml/badge.svg)](https://github.com/dwgebler/doclite/actions/workflows/ci.yml)

## 소개

DocLite는 SQLite를 기반으로 한 PHP용 NoSQL 문서 저장소입니다. PHP PDO SQLite 라이브러리를 사용하여 JSON으로 저장된 명명된 컬렉션으로 구성된 문서를 자동으로 관리합니다. DocLite는 SQLite JSON1 확장 기능을 활용하여 JSON 문서를 저장, 파싱, 인덱싱 및 쿼리할 수 있어, 완전한 트랜잭션 및 ACID 준수 NoSQL 솔루션의 강력함을 로컬 파일 시스템 내에서 제공합니다.

DocLite는 빠른 프로토타이핑, 중소규모 웹사이트 및 애플리케이션, 원격 API 데이터의 빠른 로컬 캐시, 평면 파일 저장소의 견고한 대체제, 마이크로서비스 또는 로컬 웹 앱용 데이터베이스 등 다양한 용도에 적합합니다. 넓게 보면 [SQLite 자체와 동일한 사용 사례](https://www.sqlite.org/whentouse.html)에 적합하지만, NoSQL 문서 모델이 선호되는 경우에 적합합니다.

## 설치

```bash
composer require dwgebler/doclite
```
PHP 8.1 이상 및 `pdo_sqlite` 확장 모듈이 필요합니다.

1.x 버전에서 업그레이드 중이신가요? [UPGRADE-2.0.md](https://raw.githubusercontent.com/dwgebler/doclite/main/UPGRADE-2.0.md)를 참조하세요.

## 빠른 시작


```php
use Gebler\Doclite\FileDatabase;

$db = new FileDatabase('./data');
$users = $db->collection('users');

$alice = $users->get();
$alice->setValue('name', 'Alice');
$alice->setValue('email', 'alice@example.com');
$alice->save();

$found = $users->findOneBy(['email' => 'alice@example.com']);
echo $found->getValue('name'); // Alice
```
## 문서

- [시작하기](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/getting-started.md) — 설치, 요구사항, 첫 번째 데이터베이스
- [컬렉션 & 문서](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/collections.md) — CRUD, 트랜잭션, 스키마, 커스텀 클래스 매핑
- [쿼리](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/queries.md) — 쿼리 빌더, 조인, 페이지네이션, 집계, 인덱싱
- [전문 검색](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/full-text-search.md) — FTS5 기반 검색
- [고급](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/advanced.md) — 임포트/익스포트, 저널 모드, JSONB, PSR-16 캐시 어댑터, 로깅
- [Symfony 통합](https://raw.githubusercontent.com/dwgebler/doclite/main/docs/symfony.md) — Symfony 앱에 DocLite 연결하기

## 라이선스

MIT. [LICENSE](LICENSE)를 참조하세요.

## 버그 신고

[GitHub](https://github.com/dwgebler/doclite/issues)에 이슈를 제기해 주세요.

## 취약점 신고

[SECURITY.md](https://raw.githubusercontent.com/dwgebler/doclite/main/SECURITY.md)를 참조하세요.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-07-01

---