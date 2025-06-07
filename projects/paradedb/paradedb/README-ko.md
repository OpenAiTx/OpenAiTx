<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>검색 및 분석을 위한 Postgres</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">웹사이트</a> &bull;
  <a href="https://docs.paradedb.com">문서</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">커뮤니티</a> &bull;
  <a href="https://paradedb.com/blog/">블로그</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">변경 이력</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com)는 Postgres 위에 구축된 최신 Elasticsearch 대안입니다. 실시간, 업데이트가 빈번한 워크로드를 위해 만들어졌습니다.

## 로드맵

- [x] 검색
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)를 이용한 BM25 기반의 전문 검색
  - [x] [pgvector](https://github.com/pgvector/pgvector#pgvector)를 이용한 조밀 및 희소 벡터 검색
  - [ ] 분산 검색
- [ ] 분석
  - [x] [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)를 통한 Postgres 데이터에 대한 파셋 검색
  - [ ] 컬럼 지향 Postgres 테이블 접근 방식

자세한 로드맵은 [2025 ParadeDB 로드맵](https://github.com/orgs/paradedb/discussions/2041)을 참조하세요.

## 시작하기

시작하려면 [문서](https://docs.paradedb.com)를 방문하세요.

## ParadeDB 배포

ParadeDB 및 확장 기능은 다음 두 가지 방법 중 하나로 배포할 수 있습니다:

- [Postgres](https://hub.docker.com/_/postgres)를 기반으로 하는 Docker 이미지 ([배포 안내 보기](https://docs.paradedb.com/deploy/aws))
- [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg)를 기반으로 하는 Kubernetes Helm 차트 ([배포 안내 보기](https://docs.paradedb.com/deploy/helm))

엔터프라이즈 기능 및 지원 등 자세한 내용은 [이메일로 문의](mailto:sales@paradedb.com)해 주세요.

### 확장 기능

ParadeDB Postgres 확장 기능의 미리 빌드된 바이너리는 Debian 11, 12, Ubuntu 22.04 및 24.04, Red Hat Enterprise Linux 8 및 9, macOS 14(Sonoma) 및 15(Sequoia)에서 Postgres 14+용으로 [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest)에서 확인하실 수 있습니다.

ParadeDB는 PostgreSQL Global Development Group에서 지원하는 모든 버전(PostgreSQL 14+ 포함)을 지원하며, 각 확장 기능의 README에 따라 다른 Postgres 버전용으로도 컴파일할 수 있습니다.

### Docker 이미지

ParadeDB 인스턴스를 빠르게 시작하려면, 최신 Docker 이미지를 pull 및 실행하세요:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

이 명령은 기본 사용자 `postgres`와 비밀번호 `password`로 ParadeDB 인스턴스를 시작합니다. 이후 `psql`을 이용해 데이터베이스에 접속할 수 있습니다:

```bash
docker exec -it paradedb psql -U postgres
```

ParadeDB를 로컬 또는 온프레미스에 설치하려면, `docker-compose.yml` 파일 사용을 권장합니다. 또는 아래와 같이 환경 변수를 직접 지정할 수도 있습니다(<> 부분을 원하는 값으로 교체):

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<user> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

이 명령은 `<user>`와 `<password>`로 비root ParadeDB 인스턴스를 시작합니다. `-v` 플래그는 `paradedb_data`라는 Docker 볼륨에 데이터를 저장하여 재시작 시 데이터가 유지되도록 합니다.

이후 아래와 같이 데이터베이스에 접속할 수 있습니다:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm 차트

ParadeDB는 Kubernetes에서 Helm 차트로도 제공됩니다. [ParadeDB Helm Chart GitHub 저장소](https://github.com/paradedb/charts) 또는 [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb)에서 Helm 차트를 확인할 수 있습니다.

### ParadeDB 클라우드

현재 ParadeDB는 관리형 클라우드 서비스로는 제공되지 않습니다. ParadeDB 클라우드 서비스에 관심이 있다면 [대기자 명단](https://form.typeform.com/to/jHkLmIzx)에 등록해 주세요.

## 지원

기능이 누락되었거나 버그를 발견한 경우 [GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose)를 등록해 주세요.

커뮤니티 지원을 받으시려면:

- [ParadeDB Slack 커뮤니티](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)에 질문을 올리세요
- [GitHub Discussions](https://github.com/paradedb/paradedb/discussions)에서 도움을 요청하세요

상업적 지원이 필요하다면 [ParadeDB 팀에 문의](mailto:sales@paradedb.com)해 주세요.

## 기여하기

커뮤니티의 크고 작은 기여를 환영하며, 여러분의 참여를 적극 지원합니다. 기여를 시작하려면 [first timer issues](https://github.com/paradedb/paradedb/labels/good%20first%20issue)를 확인하거나 [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)에서 메시지를 보내주세요. 기여하신 후 Slack에서 알려주시면 ParadeDB 굿즈를 보내드립니다!

기여 방법에 대한 자세한 안내는
[기여 가이드](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md)를 참고하세요.

본 프로젝트는 [기여자 행동 강령](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md)과 함께 공개됩니다.
본 프로젝트에 참여함으로써 해당 규정을 준수함에 동의합니다.

모두를 위해 ParadeDB를 더 나은 제품으로 만드는 데 함께 해주셔서 감사합니다 :heart:.

## 라이선스

ParadeDB는 [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) 및 상용 라이선스로 제공됩니다. 상용 라이선스가 필요하신 경우 [sales@paradedb.com](mailto:sales@paradedb.com)으로 문의해 주세요.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---