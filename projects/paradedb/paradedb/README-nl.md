<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres voor Zoeken en Analyse</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Website</a> &bull;
  <a href="https://docs.paradedb.com">Documentatie</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Community</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Changelog</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) is een modern alternatief voor Elasticsearch, gebouwd op Postgres. Ontworpen voor real-time, update-intensieve werklasten.

## Roadmap

- [x] Zoeken
  - [x] Volledige-tekstzoektocht met BM25 via [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Dichte en spaarzame vectorzoektocht met [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Gedistribueerd zoeken
- [ ] Analyse
  - [x] Gefacetteerde zoekopdrachten over Postgres-data met [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Kolomgeoriënteerde Postgres tabeltoegangs-methode

Voor een gedetailleerde roadmap, zie de [ParadeDB Roadmap voor 2025](https://github.com/orgs/paradedb/discussions/2041).

## Aan de slag

Om aan de slag te gaan, bezoek onze [documentatie](https://docs.paradedb.com).

## ParadeDB implementeren

ParadeDB en de extensies kunnen op twee manieren worden geïmplementeerd:

- Docker-image gebaseerd op [Postgres](https://hub.docker.com/_/postgres) ([zie implementatie-instructies](https://docs.paradedb.com/deploy/aws))
- Kubernetes Helm-chart gebaseerd op [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([zie implementatie-instructies](https://docs.paradedb.com/deploy/helm))

Voor meer informatie, inclusief enterprise-functionaliteiten en support, [neem contact met ons op via e-mail](mailto:sales@paradedb.com).

### Extensies

Je kunt kant-en-klare binaries vinden voor de ParadeDB Postgres-extensies op Debian 11, 12, Ubuntu 22.04 en 24.04, Red Hat Enterprise Linux 8 en 9, en macOS 14 (Sonoma) en 15 (Sequoia) voor Postgres 14+ in de [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB ondersteunt alle versies die ondersteund worden door de PostgreSQL Global Development Group, waaronder PostgreSQL 14+, en je kunt de extensies voor andere versies van Postgres compileren door de instructies in het README-bestand van de betreffende extensie te volgen.

### Docker Image

Om snel een ParadeDB-instantie op te zetten, kun je de nieuwste Docker-image pullen en uitvoeren:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Hiermee start je een ParadeDB-instantie met standaard gebruiker `postgres` en wachtwoord `password`. Je kunt vervolgens verbinding maken met de database via `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Voor lokale of on-premise installatie van ParadeDB raden we aan ons `docker-compose.yml` bestand te gebruiken. Alternatief kun je de juiste omgevingsvariabelen meegeven aan het `docker run` commando, waarbij je de <> vervangt door je gewenste waarden:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<gebruiker> \
  -e POSTGRES_PASSWORD=<wachtwoord> \
  -e POSTGRES_DB=<databasenaam> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Hiermee start je een ParadeDB-instantie met een niet-root gebruiker `<gebruiker>` en wachtwoord `<wachtwoord>`. De `-v` vlag zorgt ervoor dat je ParadeDB-data bewaard blijft over herstarts in een Docker-volume met de naam `paradedb_data`.

Je kunt vervolgens verbinding maken met de database via `psql`:

```bash
docker exec -it paradedb psql -U <gebruiker> -d <databasenaam> -p 5432 -W
```

### Helm Chart

ParadeDB is ook beschikbaar voor Kubernetes via onze Helm-chart. Je vindt onze Helm-chart in de [ParadeDB Helm Chart GitHub repository](https://github.com/paradedb/charts) of download deze direct van [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Op dit moment is ParadeDB niet beschikbaar als beheerde cloudservice. Als je geïnteresseerd bent in een ParadeDB Cloud-dienst, laat het ons weten door je aan te melden voor onze [wachtlijst](https://form.typeform.com/to/jHkLmIzx).

## Ondersteuning

Als je een functionaliteit mist of een bug hebt gevonden, open dan een [GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Voor community-ondersteuning kun je:

- Een vraag stellen in de [ParadeDB Slack Community](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Om hulp vragen op onze [GitHub Discussions](https://github.com/paradedb/paradedb/discussions)

Voor commerciële ondersteuning, [neem contact op met het ParadeDB team](mailto:sales@paradedb.com).

## Bijdragen

We verwelkomen bijdragen van de community, groot of klein, en helpen je graag op weg. Om te beginnen met bijdragen, bekijk onze [first timer issues](https://github.com/paradedb/paradedb/labels/good%20first%20issue) of stuur ons een bericht in de [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Als je hebt bijgedragen, laat het ons weten in Slack en we sturen je ParadeDB-swag!

Voor meer informatie over bijdragen, zie onze [Bijdragegids](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Dit project wordt uitgebracht met een [Contributor Code of Conduct](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md). Door deel te nemen aan dit project, ga je akkoord met de voorwaarden.

Bedankt dat je helpt om ParadeDB beter te maken voor iedereen :heart:.

## Licentie

ParadeDB is gelicenseerd onder de [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) en als commerciële software. Voor commerciële licenties, neem contact met ons op via [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---