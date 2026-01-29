# django-pgschemas

[![Build status](https://github.com/lorinkoz/django-pgschemas/workflows/code/badge.svg)](https://github.com/lorinkoz/django-pgschemas/actions)
[![Documentation status](https://readthedocs.org/projects/django-pgschemas/badge/?version=latest)](https://django-pgschemas.readthedocs.io/)
[![Code coverage](https://coveralls.io/repos/github/lorinkoz/django-pgschemas/badge.svg?branch=master)](https://coveralls.io/github/lorinkoz/django-pgschemas?branch=master)
[![PyPi version](https://badge.fury.io/py/django-pgschemas.svg)](http://badge.fury.io/py/django-pgschemas)
[![Downloads](https://pepy.tech/badge/django-pgschemas/month)](https://pepy.tech/project/django-pgschemas/)

이 패키지는 Postgres 스키마를 사용하여 단일 Django 프로젝트 내에서 데이터 다중 테넌시를 지원합니다. 이는 몇 가지 개념적 변경이 적용된 [django-tenants](https://github.com/django-tenants/django-tenants)의 포크입니다:

- 정적 테넌트와 동적 테넌트가 있습니다. 정적 테넌트는 자체 앱과 urlconf를 가질 수 있습니다.
- 테넌트는 다음을 통해 라우팅될 수 있습니다:
  - 공유 서브도메인에서 서브도메인 또는 서브폴더를 사용하는 URL
  - 세션
  - 헤더
- Public 스키마는 메인 사이트 데이터를 저장하는 데 사용되어서는 안 되며, 모든 테넌트에 걸친 진정한 공유 데이터를 저장해야 합니다. 검색 경로를 통한 테이블 "오버라이딩"은 권장되지 않습니다.
- 관리 명령은 와일드카드를 통해 여러 스키마에서 순차적이거나 멀티스레딩을 사용하여 병렬로 실행할 수 있습니다.

## 문서

https://django-pgschemas.readthedocs.io/

## 기여

이 프로젝트에 기여하는 방법에 대한 자세한 내용은 [CONTRIBUTING.md](https://github.com/lorinkoz/django-pgschemas?tab=contributing-ov-file)를 참조하세요.

## 크레딧

- [django-tenants](https://github.com/django-tenants/django-tenants)의 Tom Turner.
- [django-tenant-schemas](https://github.com/bernardopires/django-tenant-schemas)의 Bernardo Pires.
- [pg-clone-schema](https://github.com/denishpatel/pg-clone-schema)의 Denish Patel.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-29

---