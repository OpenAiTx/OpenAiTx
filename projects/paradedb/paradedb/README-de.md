<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres für Suche und Analytik</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Webseite</a> &bull;
  <a href="https://docs.paradedb.com">Dokumentation</a> &bull;
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

[ParadeDB](https://paradedb.com) ist eine moderne Elasticsearch-Alternative, gebaut auf Postgres. Entwickelt für Echtzeit- und update-intensive Arbeitslasten.

## Roadmap

- [x] Suche
  - [x] Volltextsuche mit BM25 mit [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Dichte und spärliche Vektorsuche mit [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Verteilte Suche
- [ ] Analytik
  - [x] Facettierte Suche über Postgres-Daten mit [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Spaltenorientierte Zugriffsmethode für Postgres-Tabellen

Für eine detaillierte Roadmap siehe die [ParadeDB Roadmap für 2025](https://github.com/orgs/paradedb/discussions/2041).

## Loslegen

Um zu beginnen, besuchen Sie bitte unsere [Dokumentation](https://docs.paradedb.com).

## ParadeDB bereitstellen

ParadeDB und seine Erweiterungen können auf zwei Arten bereitgestellt werden:

- Docker-Image basierend auf [Postgres](https://hub.docker.com/_/postgres) ([siehe Bereitstellungsanleitung](https://docs.paradedb.com/deploy/aws))
- Kubernetes Helm Chart basierend auf [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([siehe Bereitstellungsanleitung](https://docs.paradedb.com/deploy/helm))

Für weitere Informationen, einschließlich Enterprise-Funktionen und Support, kontaktieren Sie uns bitte [per E-Mail](mailto:sales@paradedb.com).

### Erweiterungen

Vorgefertigte Binärdateien für die ParadeDB Postgres-Erweiterungen sind für Debian 11, 12, Ubuntu 22.04 und 24.04, Red Hat Enterprise Linux 8 und 9 sowie macOS 14 (Sonoma) und 15 (Sequoia) für Postgres 14+ in den [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest) verfügbar.

ParadeDB unterstützt alle Versionen, die von der PostgreSQL Global Development Group unterstützt werden, einschließlich PostgreSQL 14+. Sie können die Erweiterungen für andere Postgres-Versionen selbst kompilieren, indem Sie die Anweisungen in der jeweiligen README der Erweiterung befolgen.

### Docker-Image

Um eine ParadeDB-Instanz schnell zu starten, ziehen und starten Sie einfach das neueste Docker-Image:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Dies startet eine ParadeDB-Instanz mit dem Standardbenutzer `postgres` und dem Passwort `password`. Sie können dann mit `psql` auf die Datenbank zugreifen:

```bash
docker exec -it paradedb psql -U postgres
```

Um ParadeDB lokal oder on-premise zu installieren, empfehlen wir die Verwendung unserer `docker-compose.yml`-Datei. Alternativ können Sie die entsprechenden Umgebungsvariablen an den `docker run`-Befehl übergeben und die <> durch Ihre gewünschten Werte ersetzen:

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

Dies startet eine ParadeDB-Instanz mit dem Nicht-Root-Benutzer `<user>` und dem Passwort `<password>`. Das `-v`-Flag sorgt dafür, dass Ihre ParadeDB-Daten in einem Docker-Volume namens `paradedb_data` über Neustarts hinweg erhalten bleiben.

Sie können dann mit `psql` auf die Datenbank zugreifen:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB ist auch für Kubernetes über unser Helm Chart verfügbar. Sie finden unser Helm Chart im [ParadeDB Helm Chart GitHub Repository](https://github.com/paradedb/charts) oder laden Sie es direkt von [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb) herunter.

### ParadeDB Cloud

Derzeit ist ParadeDB nicht als verwalteter Cloud-Dienst verfügbar. Wenn Sie an einem ParadeDB Cloud-Service interessiert sind, teilen Sie uns dies bitte mit, indem Sie sich auf unsere [Warteliste](https://form.typeform.com/to/jHkLmIzx) eintragen.

## Support

Wenn Ihnen eine Funktion fehlt oder Sie einen Fehler gefunden haben, eröffnen Sie bitte ein
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Um Community-Support zu erhalten, können Sie:

- Eine Frage in der [ParadeDB Slack Community](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw) stellen
- Hilfe in unseren [GitHub Discussions](https://github.com/paradedb/paradedb/discussions) suchen

Wenn Sie kommerziellen Support benötigen, [kontaktieren Sie das ParadeDB-Team](mailto:sales@paradedb.com).

## Mitwirken

Wir freuen uns über Beiträge aus der Community – ob groß oder klein – und helfen Ihnen gerne dabei. Um mit dem Beitragen zu beginnen, schauen Sie auf unsere [First Timer Issues](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
oder schreiben Sie uns in der [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Nach Ihrem ersten Beitrag, melden Sie sich in Slack, und wir schicken Ihnen etwas ParadeDB-Merch!

Weitere Informationen finden Sie in unserem
[Contributing Guide](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Dieses Projekt wird mit einem [Contributor Code of Conduct](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md) veröffentlicht.
Durch Ihre Teilnahme stimmen Sie dessen Bedingungen zu.

Vielen Dank, dass Sie dazu beitragen, ParadeDB für alle besser zu machen :heart:.

## Lizenz

ParadeDB ist unter der [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) und als kommerzielle Software lizenziert. Für kommerzielle Lizenzen kontaktieren Sie uns bitte unter [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---