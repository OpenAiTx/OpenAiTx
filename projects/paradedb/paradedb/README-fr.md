<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres pour la Recherche et l’Analytique</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Site Web</a> &bull;
  <a href="https://docs.paradedb.com">Documentation</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Communauté</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Journal des modifications</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) est une alternative moderne à Elasticsearch, construite sur Postgres. Conçue pour des charges de travail en temps réel et fortement mises à jour.

## Feuille de route

- [x] Recherche
  - [x] Recherche en texte intégral avec BM25 via [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Recherche vectorielle dense et clairsemée avec [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Recherche distribuée
- [ ] Analytique
  - [x] Recherche à facettes sur les données Postgres avec [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Méthode d’accès aux tables Postgres orientée colonne

Pour une feuille de route détaillée, voir la [Feuille de route ParadeDB pour 2025](https://github.com/orgs/paradedb/discussions/2041).

## Pour commencer

Pour débuter, veuillez consulter notre [documentation](https://docs.paradedb.com).

## Déployer ParadeDB

ParadeDB et ses extensions peuvent être déployés de deux manières :

- Image Docker basée sur [Postgres](https://hub.docker.com/_/postgres) ([voir les instructions de déploiement](https://docs.paradedb.com/deploy/aws))
- Chart Helm Kubernetes basé sur [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([voir les instructions de déploiement](https://docs.paradedb.com/deploy/helm))

Pour plus d’informations, y compris les fonctionnalités d’entreprise et le support, veuillez [nous contacter par email](mailto:sales@paradedb.com).

### Extensions

Vous pouvez trouver des binaires précompilés pour les extensions Postgres de ParadeDB sur Debian 11, 12, Ubuntu 22.04 et 24.04, Red Hat Enterprise Linux 8 et 9, et macOS 14 (Sonoma) et 15 (Sequoia) pour Postgres 14+ dans les [releases GitHub](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB prend en charge toutes les versions prises en charge par le PostgreSQL Global Development Group, ce qui inclut PostgreSQL 14+, et vous pouvez compiler les extensions pour d’autres versions de Postgres en suivant les instructions dans le README de chaque extension.

### Image Docker

Pour lancer rapidement une instance ParadeDB, il suffit de tirer et d’exécuter la dernière image Docker :

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Cela démarre une instance ParadeDB avec l’utilisateur par défaut `postgres` et le mot de passe `password`. Vous pouvez ensuite vous connecter à la base de données avec `psql` :

```bash
docker exec -it paradedb psql -U postgres
```

Pour installer ParadeDB localement ou sur site, nous recommandons d’utiliser notre fichier `docker-compose.yml`. Alternativement, vous pouvez passer les variables d’environnement appropriées à la commande `docker run`, en remplaçant les <> par vos valeurs souhaitées :

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<utilisateur> \
  -e POSTGRES_PASSWORD=<motdepasse> \
  -e POSTGRES_DB=<basededonnees> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Cela démarre une instance ParadeDB avec l’utilisateur non-root `<utilisateur>` et le mot de passe `<motdepasse>`. L’option `-v` permet de persister vos données ParadeDB entre les redémarrages dans un volume Docker nommé `paradedb_data`.

Vous pouvez ensuite vous connecter à la base de données avec :

```bash
docker exec -it paradedb psql -U <utilisateur> -d <basededonnees> -p 5432 -W
```

### Chart Helm

ParadeDB est également disponible pour Kubernetes via notre chart Helm. Vous pouvez trouver notre chart Helm dans le [dépôt GitHub ParadeDB Helm Chart](https://github.com/paradedb/charts) ou le télécharger directement depuis [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Pour le moment, ParadeDB n’est pas disponible en tant que service cloud managé. Si vous êtes intéressé par un service ParadeDB Cloud, veuillez nous le faire savoir en rejoignant notre [liste d’attente](https://form.typeform.com/to/jHkLmIzx).

## Support

Si une fonctionnalité vous manque ou si vous avez trouvé un bug, veuillez ouvrir un
[GitHub Issue](https://github.com/paradedb/paradedb/issues/new/choose).

Pour obtenir du support communautaire, vous pouvez :

- Poser une question dans la [Communauté Slack ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Demander de l’aide sur nos [Discussions GitHub](https://github.com/paradedb/paradedb/discussions)

Si vous avez besoin d’un support commercial, veuillez [contacter l’équipe ParadeDB](mailto:sales@paradedb.com).

## Contribuer

Nous accueillons les contributions de la communauté, grandes ou petites, et sommes là pour vous accompagner tout au long du processus. Pour commencer à contribuer, consultez nos [issues pour débutant](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
ou envoyez-nous un message sur la [Communauté Slack ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Une fois votre contribution réalisée, signalez-le-nous sur Slack et nous vous enverrons des goodies ParadeDB !

Pour plus d’informations sur la contribution, veuillez consulter notre
[Guide de contribution](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Ce projet est publié avec un [Code de conduite du contributeur](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
En participant à ce projet, vous acceptez d’en respecter les termes.

Merci de nous aider à améliorer ParadeDB pour tous :heart:.

## Licence

ParadeDB est distribué sous la [Licence Publique Générale Affero GNU v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) ainsi qu’en tant que logiciel commercial. Pour une licence commerciale, veuillez nous contacter à [sales@paradedb.com](mailto:sales@paradedb.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---