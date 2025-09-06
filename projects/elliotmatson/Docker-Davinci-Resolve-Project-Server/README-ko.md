# 다빈치 리졸브 프로젝트 서버

![Lint](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/lint.yml/badge.svg)
![Healthcheck](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/stack-healthcheck.yml/badge.svg)
![Docker Build](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/actions/workflows/docker.yml/badge.svg)

자동 백업 기능이 있는 간단한 리졸브 프로젝트 서버

## 목차

- [다빈치 리졸브 프로젝트 서버](#다빈치-리졸브-프로젝트-서버)
  - [목차](#목차)
  - [소개](#소개)
    - [특징](#특징)
  - [설정](#설정)
    - [데이터베이스](#데이터베이스)
    - [백업](#백업)
    - [PGAdmin](#pgadmin)
    - [볼륨 위치](#볼륨-위치)
  - [설치](#설치)
    - [QNAP 설치](#qnap-설치)
    - [Synology](#synology)
    - [리눅스](#리눅스)
  - [다른 PostgreSQL 버전](#다른-postgresql-버전)
    - [PostgreSQL 9.5 또는 11 프로젝트 서버 설정](#postgresql-95-또는-11-프로젝트-서버-설정)
  - [감사합니다](#감사합니다)

## 소개

리졸브 프로젝트 서버를 호스팅하는 방법은 많지만, 각각 고유한 문제점이 있습니다. 공식 프로젝트 서버는 수동 백업이 필요하고, 다른 옵션은 IT 팀에 접근할 수 없는 사람들에게 복잡할 수 있습니다. 이 솔루션이 소규모 팀에게 더 신뢰할 수 있고 간단한 대안이 되길 바랍니다!

### 특징

- **경량화** - Docker 기반으로, 전체 macOS 또는 Windows 머신이나 VM이 필요 없습니다.
- **플랫폼 독립적** - Windows, Mac, Linux, QNAP, Synology, RPi 등 Docker를 실행할 수 있는 모든 곳에 설치 가능.
- **리졸브의 기존 백업/복원 기능과 호환** - 모든 백업 파일은 표준 리졸브 \*.backup 파일 형식을 사용하며, 리졸브 UI에서 복원이 가능합니다.
- **내장 PGAdmin 서버** - PGAdmin은 PostgreSQL 서버 관리 도구로, 문제 진단과 전체 서버 마이그레이션/업데이트에 유용합니다.

## 설정

설치를 구성하기 위해 docker-compose.yml 파일 상단에서 편집해야 할 몇 가지 항목이 있습니다:

```yaml
---
version: "3.8"
x-common:
  database: &db-environment
    POSTGRES_DB: database
    POSTGRES_USER: &pg-user postgres
    POSTGRES_PASSWORD: DaVinci
    TZ: America/Chicago
    POSTGRES_LOCATION: &db-location "???:/var/lib/postgresql/data"
  backup: &backup-environment
    SCHEDULE: "@daily"
    BACKUP_KEEP_DAYS: 7
    BACKUP_KEEP_WEEKS: 4
    BACKUP_KEEP_MONTHS: 6
    BACKUP_LOCATION: &bk-location "???:/backups"
  admin: &admin-environment
    PGADMIN_DEFAULT_EMAIL: admin@admin.com
    PGADMIN_DEFAULT_PASSWORD: root
    PGADMIN_PORT: &pgadmin-port "3001:80"
```

### 데이터베이스

서버 자체를 구성하려면 아래 환경 변수를 설정해야 합니다:
| 환경 변수 | 의미 |
|---|---|
| POSTGRES_DB | 데이터베이스 이름입니다. 원하는 대로 지정하세요. |
| POSTGRES_USER | 데이터베이스에 연결할 때 사용할 사용자 이름입니다. Resolve의 기본값은 "postgres"입니다. |
| POSTGRES_PASSWORD | 데이터베이스에 연결할 때 사용할 비밀번호입니다. Resolve의 기본값은 "DaVinci"입니다. |
| TZ | 시간대입니다. [목록](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones)을 참고하세요. |
| POSTGRES_LOCATION | 데이터베이스가 저장될 위치입니다. [볼륨 위치](#volume-locations)를 참고하세요. |

### 백업

백업을 구성하려면 아래 변수를 설정해야 합니다:
| 환경 변수 | 의미 |
|---|---|
| SCHEDULE | 백업 생성 빈도를 지정하는 [크론 문자열](https://www.freeformatter.com/cron-expression-generator-quartz.html)입니다. "@daily", "@every 1h" 등으로 설정할 수 있습니다. |
| BACKUP_KEEP_DAYS | 제거하기 전까지 보관할 일일 백업 개수입니다. |
| BACKUP_KEEP_WEEKS | 제거하기 전까지 보관할 주간 백업 개수입니다. |
| BACKUP_KEEP_MONTHS | 제거하기 전까지 보관할 월간 백업 개수입니다. |
| BACKUP_LOCATION | 백업이 저장될 위치입니다. [볼륨 위치](#volume-locations)를 참고하세요. |

### PGAdmin

PGAdmin을 구성하려면 아래 변수를 설정해야 합니다:
| 환경 변수 | 의미 |
|---|---|
| PGADMIN_DEFAULT_EMAIL | PGAdmin 로그인에 사용되는 이메일입니다. 기본값은 "admin@admin.com"입니다. |
| PGADMIN_DEFAULT_PASSWORD | PGAdmin 로그인에 사용되는 비밀번호입니다. 기본값은 "root"입니다. |
| PGADMIN_PORT | PGAdmin을 노출할 포트를 설정하는 문자열입니다. 형식은 "YOUR_PORT:80"입니다. |

### 볼륨 위치

데이터베이스와 백업의 위치는 설치하는 플랫폼에 따라 다릅니다. 저장할 폴더의 전체 경로가 필요합니다. 예를 들어 QNAP NAS에서, 백업 위치로 "Videos"라는 공유 폴더 내 "Backups"라는 폴더를 사용하고 싶다면 경로는 `/shares/Videos/Backups/`가 되며, `BACKUP_LOCATION` 값은 다음과 같이 설정합니다:

```yaml
BACKUP_LOCATION: &bk-location "/shares/Videos/Backups/:/backups"
```
우분투에서, "johndoe"라는 사용자의 홈 디렉토리에 있는 "database"라는 폴더를 데이터베이스 위치로 사용하려면 경로는 `/home/johndoe/database/`가 되고, `POSTGRES_LOCATION` 값은 다음과 같이 됩니다:


```yaml
POSTGRES_LOCATION: &db-location "johndoe/database/:/var/lib/postgresql/data"
```
데이터베이스를 SSD에 두는 것을 권장합니다. 회전하는 드라이브에서는 접근 속도가 눈에 띄게 느려집니다.

이 설정을 완료한 후, 수정한 docker-compose.yml 파일을 저장하고 설치로 넘어가세요!

## 설치

### QNAP 설치

QNAP NAS에 설치하는 것은 비교적 간단합니다. 한 가지 주의할 점은 데이터베이스 파일을 SSD에 두라는 것입니다. 나중에 고마워할 겁니다.

1. 아직 설치하지 않았다면 QNAP 앱 스토어에서 Container Station을 설치하세요.
2. Container Station에서 "Create"를 클릭한 다음 "Create Application"을 클릭하세요.
3. 애플리케이션 이름을 원하는 대로 지정하세요 (예: ResolveServer)
4. 수정한 docker-compose.yml 파일을 복사/붙여넣기 하고, "Validate YAML"을 눌러 테스트한 후 통과하면 "Create"를 클릭하세요.
5. Container Station이 필요한 파일을 다운로드하고 앱을 시작합니다. 완료되면 데이터베이스 이름과 자격 증명을 사용하여 QNAP의 IP 주소로 Resolve에 연결할 수 있어야 합니다.

### Synology

[이 토론](https://github.com/elliotmatson/Docker-Davinci-Resolve-Project-Server/discussions/15#discussioncomment-4615278)을 참조하세요.

### Linux

1. [Linux 배포판용 Docker 설치 지침](https://docs.docker.com/engine/install/)을 따르세요.
2. [Docker Compose](https://docs.docker.com/compose/install/)를 설치하세요.
3. 수정한 docker-compose.yml 파일을 Linux 머신의 폴더로 옮긴 후, 터미널에서 해당 폴더로 이동하세요.
4. 다음 명령어를 실행하세요:
   `docker-compose up -d`
5. Docker-compose가 필요한 파일을 다운로드하고 앱을 시작합니다. 완료되면 데이터베이스 이름과 자격 증명을 사용하여 Linux 서버 인스턴스의 IP 주소로 Resolve에 연결할 수 있어야 합니다.

## 서로 다른 PostgreSQL 버전

일반적으로 Resolve는 PostgreSQL 버전 불일치에 대해 관대하지 않습니다. Resolve 18은 PostgreSQL 13을 사용하며, 이 저장소도 기본값으로 설정되어 있습니다. Resolve 17 이하 버전은 PostgreSQL 9.5를 사용합니다. 불행히도 9.5 메이저 버전은 EOL이며, 특히 9.5.4는 많은 취약점이 있어 안전하지 않습니다.
대부분의 사용자가 서버에 대해 기본 Resolve 자격 증명을 사용하고 있기 때문에 보안이 가장 큰 문제는 아니지만, 오래된 Resolve 버전으로 프로젝트 서버를 보호하려면 지원되는 PostgreSQL 버전으로 이동해야 합니다.

Resolve 17 이하 버전은 PostgreSQL 12에서 제거된 레거시 기능을 여전히 사용하므로, 사용할 수 있는 최신 메이저 버전은 11이며, 2023년 11월 9일까지 유지 관리됩니다.

### PostgreSQL 9.5 또는 11 프로젝트 서버 설정

13 대신 PostgreSQL 9.5 또는 11 서버를 설정하려면 docker_compose.yml 파일에서 2줄을 변경해야 합니다:


```yaml
services:
  postgres:
    image: postgres:13
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:13
    ...
...
```
다음으로:


```yaml
services:
  postgres:
    image: postgres:9.5
    ...
  pgbackups:
    image: prodrigestivill/postgres-backup-local:9.5
    ...
...
```

## 감사합니다

-[prodrigestivill](https://github.com/prodrigestivill/) 그의 [PostgreSQL 백업 도커 이미지](https://github.com/prodrigestivill/docker-postgres-backup-local) 감사합니다


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-06

---