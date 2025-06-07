<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres do wyszukiwania i analityki</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Strona internetowa</a> &bull;
  <a href="https://docs.paradedb.com">Dokumentacja</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Społeczność</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Lista zmian</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) to nowoczesna alternatywa dla Elasticsearch zbudowana na Postgresie. Stworzona do obciążeń w czasie rzeczywistym, wymagających częstych aktualizacji.

## Mapa drogowa

- [x] Wyszukiwanie
  - [x] Wyszukiwanie pełnotekstowe z BM25 dzięki [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Wyszukiwanie wektorów gęstych i rzadkich dzięki [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Wyszukiwanie rozproszone
- [ ] Analityka
  - [x] Wyszukiwanie fasetowe na danych Postgresa za pomocą [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Kolumnowy sposób dostępu do tabel Postgresa

Szczegółową mapę drogową znajdziesz w [ParadeDB Roadmap for 2025](https://github.com/orgs/paradedb/discussions/2041).

## Pierwsze kroki

Aby rozpocząć, odwiedź naszą [dokumentację](https://docs.paradedb.com).

## Wdrażanie ParadeDB

ParadeDB i jej rozszerzenia można wdrożyć na dwa sposoby:

- Obraz Dockera oparty na [Postgresie](https://hub.docker.com/_/postgres) ([zobacz instrukcje wdrożenia](https://docs.paradedb.com/deploy/aws))
- Helm chart dla Kubernetes, oparty na [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([zobacz instrukcje wdrożenia](https://docs.paradedb.com/deploy/helm))

Aby uzyskać więcej informacji, w tym dotyczących funkcji dla firm i wsparcia, prosimy o [kontakt mailowy](mailto:sales@paradedb.com).

### Rozszerzenia

Gotowe binaria rozszerzeń ParadeDB dla Postgresa na Debianie 11, 12, Ubuntu 22.04 i 24.04, Red Hat Enterprise Linux 8 i 9 oraz macOS 14 (Sonoma) i 15 (Sequoia) dla Postgresa 14+ znajdziesz w [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB obsługuje wszystkie wersje wspierane przez PostgreSQL Global Development Group, czyli PostgreSQL 14+, a rozszerzenia można skompilować dla innych wersji Postgresa, postępując zgodnie z instrukcjami w README danego rozszerzenia.

### Obraz Dockera

Aby szybko uruchomić instancję ParadeDB, wystarczy pobrać i uruchomić najnowszy obraz Dockera:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Uruchomi to instancję ParadeDB z domyślnym użytkownikiem `postgres` i hasłem `password`. Następnie możesz połączyć się z bazą danych za pomocą `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Aby zainstalować ParadeDB lokalnie lub on-premise, zalecamy użycie pliku `docker-compose.yml`. Alternatywnie, możesz przekazać odpowiednie zmienne środowiskowe do polecenia `docker run`, zamieniając <> na wybrane wartości:

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

Uruchomi to instancję ParadeDB z użytkownikiem `<user>` (nie-root) i hasłem `<password>`. Flaga `-v` umożliwia trwałość danych ParadeDB w wolumenie Dockera o nazwie `paradedb_data` pomiędzy restartami.

Następnie możesz połączyć się z bazą danych za pomocą `psql`:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB jest także dostępna dla Kubernetes poprzez nasz Helm chart. Helm chart znajdziesz w [repozytorium ParadeDB Helm Chart na GitHub](https://github.com/paradedb/charts) lub pobierz bezpośrednio z [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Obecnie ParadeDB nie jest dostępna jako zarządzana usługa w chmurze. Jeśli jesteś zainteresowany usługą ParadeDB Cloud, dołącz do naszej [listy oczekujących](https://form.typeform.com/to/jHkLmIzx).

## Wsparcie

Jeśli brakuje Ci funkcji lub znalazłeś błąd, zgłoś to przez
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Aby uzyskać wsparcie społeczności, możesz:

- Zadać pytanie na [ParadeDB Slack Community](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Poprosić o pomoc w [Dyskusjach na GitHubie](https://github.com/paradedb/paradedb/discussions)

Jeśli potrzebujesz wsparcia komercyjnego, [skontaktuj się z zespołem ParadeDB](mailto:sales@paradedb.com).

## Współtworzenie

Zapraszamy do współtworzenia projektu — zarówno w małej, jak i dużej skali — i chętnie Ci w tym pomożemy. Aby rozpocząć, sprawdź nasze [zadania dla początkujących](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
lub napisz do nas na [ParadeDB Community Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Po pierwszym wkładzie napisz do nas na Slacku, a wyślemy Ci gadżety ParadeDB!

Więcej informacji o współtworzeniu znajdziesz w naszym
[Przewodniku po współtworzeniu](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Ten projekt jest publikowany z [Kodeksem postępowania współtwórców](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Uczestnicząc w projekcie, akceptujesz jego zasady.

Dziękujemy za pomoc w ulepszaniu ParadeDB dla wszystkich :heart:.

## Licencja

ParadeDB jest licencjonowana na [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) oraz jako oprogramowanie komercyjne. W sprawie licencji komercyjnej skontaktuj się z nami pod adresem [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---