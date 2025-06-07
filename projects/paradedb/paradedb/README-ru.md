<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres для поиска и аналитики</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Веб-сайт</a> &bull;
  <a href="https://docs.paradedb.com">Документация</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Сообщество</a> &bull;
  <a href="https://paradedb.com/blog/">Блог</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Список изменений</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) — это современная альтернатива Elasticsearch, построенная на Postgres. Разработана для рабочих нагрузок в реальном времени с частыми обновлениями.

## Дорожная карта

- [x] Поиск
  - [x] Полнотекстовый поиск с BM25 с помощью [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Поиск по плотным и разреженным векторам с помощью [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Распределённый поиск
- [ ] Аналитика
  - [x] Фасетный поиск по данным Postgres с помощью [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Колонковый метод доступа к таблицам Postgres

Для подробной дорожной карты смотрите [Дорожная карта ParadeDB на 2025 год](https://github.com/orgs/paradedb/discussions/2041).

## Начало работы

Для начала работы посетите нашу [документацию](https://docs.paradedb.com).

## Развертывание ParadeDB

ParadeDB и её расширения можно развернуть двумя способами:

- Docker-образ на базе [Postgres](https://hub.docker.com/_/postgres) ([инструкция по развертыванию](https://docs.paradedb.com/deploy/aws))
- Helm-чарт Kubernetes на базе [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([инструкция по развертыванию](https://docs.paradedb.com/deploy/helm))

Для получения дополнительной информации, включая корпоративные функции и поддержку, [свяжитесь с нами по электронной почте](mailto:sales@paradedb.com).

### Расширения

Готовые бинарные файлы расширений ParadeDB для Postgres доступны для Debian 11, 12, Ubuntu 22.04 и 24.04, Red Hat Enterprise Linux 8 и 9, а также macOS 14 (Sonoma) и 15 (Sequoia) для Postgres 14+ в разделе [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB поддерживает все версии, поддерживаемые PostgreSQL Global Development Group, включая PostgreSQL 14+, а также вы можете скомпилировать расширения для других версий Postgres, следуя инструкциям в README соответствующего расширения.

### Docker-образ

Чтобы быстро запустить ParadeDB, просто выполните команду для получения и запуска последнего Docker-образа:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Эта команда запустит экземпляр ParadeDB с пользователем по умолчанию `postgres` и паролем `password`. Вы можете подключиться к базе данных, используя `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Для локальной или on-premise установки ParadeDB мы рекомендуем использовать наш файл `docker-compose.yml`. В качестве альтернативы, вы можете передать соответствующие переменные окружения в команду `docker run`, заменив <> на нужные значения:

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

Эта команда запустит ParadeDB с непривилегированным пользователем `<user>` и паролем `<password>`. Флаг `-v` обеспечивает сохранение данных ParadeDB между перезапусками в Docker-томе с именем `paradedb_data`.

Затем вы можете подключиться к базе данных, используя `psql`:

```bash
docker exec -it paradedb psql -U <user> -d <dbname> -p 5432 -W
```

### Helm-чарт

ParadeDB также доступна для Kubernetes через наш Helm-чарт. Вы можете найти Helm-чарт в [GitHub репозитории ParadeDB Helm Chart](https://github.com/paradedb/charts) или загрузить его напрямую с [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

В настоящее время ParadeDB недоступна как управляемый облачный сервис. Если вы заинтересованы в облачном сервисе ParadeDB, пожалуйста, сообщите нам, присоединившись к нашему [листу ожидания](https://form.typeform.com/to/jHkLmIzx).

## Поддержка

Если вам не хватает какой-либо функции или вы нашли ошибку, пожалуйста, создайте
[Issue на GitHub](https://github.com/paradedb/paradedb/issues/new/choose).

Для получения поддержки сообщества вы можете:

- Задать вопрос в [Slack-сообществе ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Попросить помощи в разделе [GitHub Discussions](https://github.com/paradedb/paradedb/discussions)

Если вам нужна коммерческая поддержка, пожалуйста, [свяжитесь с командой ParadeDB](mailto:sales@paradedb.com).

## Вклад в проект

Мы приветствуем вклад сообщества любого масштаба и готовы помочь вам на каждом шаге. Чтобы начать вносить вклад, ознакомьтесь с нашими [issues для новичков](https://github.com/paradedb/paradedb/labels/good%20first%20issue) или напишите нам в [Slack-сообществе ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). После первого вклада сообщите нам в Slack, и мы отправим вам сувениры ParadeDB!

Для получения дополнительной информации о вкладе смотрите наше
[Руководство по вкладу](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Этот проект распространяется с [Кодексом поведения для участников](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Участвуя в проекте, вы соглашаетесь соблюдать его условия.

Спасибо, что помогаете сделать ParadeDB лучше для всех :heart:.

## Лицензия

ParadeDB распространяется по лицензии [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) и как коммерческое программное обеспечение. Для коммерческой лицензии, пожалуйста, свяжитесь с нами по адресу [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---