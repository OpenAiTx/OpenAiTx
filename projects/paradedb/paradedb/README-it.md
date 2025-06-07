<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres per Ricerca e Analisi</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Sito Web</a> &bull;
  <a href="https://docs.paradedb.com">Documentazione</a> &bull;
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

[ParadeDB](https://paradedb.com) è una moderna alternativa a Elasticsearch basata su Postgres. Progettata per carichi di lavoro in tempo reale e con frequenti aggiornamenti.

## Roadmap

- [x] Ricerca
  - [x] Ricerca full-text con BM25 tramite [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Ricerca vettoriale densa e sparsa tramite [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Ricerca distribuita
- [ ] Analisi
  - [x] Ricerca facetata sui dati Postgres con [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Metodo di accesso alle tabelle Postgres orientato alle colonne

Per una roadmap dettagliata, consulta la [Roadmap ParadeDB per il 2025](https://github.com/orgs/paradedb/discussions/2041).

## Per Iniziare

Per iniziare, visita la nostra [documentazione](https://docs.paradedb.com).

## Deploy di ParadeDB

ParadeDB e le sue estensioni possono essere distribuite in due modi:

- Immagine Docker basata su [Postgres](https://hub.docker.com/_/postgres) ([vedi istruzioni di deploy](https://docs.paradedb.com/deploy/aws))
- Helm chart per Kubernetes basato su [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([vedi istruzioni di deploy](https://docs.paradedb.com/deploy/helm))

Per maggiori informazioni, incluse funzionalità enterprise e supporto, [contattaci via email](mailto:sales@paradedb.com).

### Estensioni

Puoi trovare i binari precompilati delle estensioni Postgres ParadeDB per Debian 11, 12, Ubuntu 22.04 e 24.04, Red Hat Enterprise Linux 8 e 9, e macOS 14 (Sonoma) e 15 (Sequoia) per Postgres 14+ nelle [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB supporta tutte le versioni supportate dal PostgreSQL Global Development Group, incluso PostgreSQL 14+, e puoi compilare le estensioni per altre versioni di Postgres seguendo le istruzioni nel README dell’estensione specifica.

### Immagine Docker

Per avviare rapidamente un’istanza ParadeDB, esegui semplicemente il pull e l’avvio dell’ultima immagine Docker:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Questo avvierà un’istanza ParadeDB con utente predefinito `postgres` e password `password`. Puoi quindi connetterti al database usando `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Per installare ParadeDB in locale o on-premise, si consiglia di utilizzare il nostro file `docker-compose.yml`. In alternativa, puoi passare le variabili di ambiente appropriate al comando `docker run`, sostituendo i <> con i valori desiderati:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<utente> \
  -e POSTGRES_PASSWORD=<password> \
  -e POSTGRES_DB=<dbname> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Questo avvierà un’istanza ParadeDB con utente non-root `<utente>` e password `<password>`. Il flag `-v` consente ai dati ParadeDB di persistere tra i riavvii in un volume Docker denominato `paradedb_data`.

Puoi quindi connetterti al database usando `psql`:

```bash
docker exec -it paradedb psql -U <utente> -d <dbname> -p 5432 -W
```

### Helm Chart

ParadeDB è disponibile anche per Kubernetes tramite il nostro Helm chart. Puoi trovare il nostro Helm chart nel [repository GitHub ParadeDB Helm Chart](https://github.com/paradedb/charts) o scaricarlo direttamente da [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Al momento, ParadeDB non è disponibile come servizio cloud gestito. Se sei interessato a un servizio ParadeDB Cloud, faccelo sapere iscrivendoti alla nostra [lista d’attesa](https://form.typeform.com/to/jHkLmIzx).

## Supporto

Se ti manca una funzionalità o hai trovato un bug, apri una
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Per supporto dalla community, puoi:

- Pubblicare una domanda nella [Community Slack di ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Chiedere aiuto sulle nostre [GitHub Discussions](https://github.com/paradedb/paradedb/discussions)

Se hai bisogno di supporto commerciale, [contatta il team ParadeDB](mailto:sales@paradedb.com).

## Contribuire

Accogliamo con piacere contributi dalla community, grandi o piccoli, e siamo qui per guidarti lungo il percorso. Per iniziare a contribuire, consulta le nostre [prime issue per nuovi contributori](https://github.com/paradedb/paradedb/labels/good%20first%20issue) oppure scrivici nella [Community Slack di ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Dopo aver contribuito, scrivici su Slack e ti invieremo qualche gadget ParadeDB!

Per ulteriori informazioni su come contribuire, consulta la nostra
[Guida al Contributo](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Questo progetto è rilasciato con un [Codice di Condotta dei Contributori](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Partecipando a questo progetto, accetti di seguirne i termini.

Grazie per aiutarci a rendere ParadeDB migliore per tutti :heart:.

## Licenza

ParadeDB è rilasciato sotto [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) e come software commerciale. Per licenze commerciali, contattaci a [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---