<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres para Búsqueda y Analítica</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Sitio Web</a> &bull;
  <a href="https://docs.paradedb.com">Documentación</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Comunidad</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Registro de Cambios</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) es una alternativa moderna a Elasticsearch construida sobre Postgres. Diseñada para cargas de trabajo en tiempo real y con muchas actualizaciones.

## Hoja de Ruta

- [x] Búsqueda
  - [x] Búsqueda de texto completo con BM25 con [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Búsqueda de vectores densos y dispersos con [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Búsqueda distribuida
- [ ] Analítica
  - [x] Búsqueda facetada sobre datos de Postgres con [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Método de acceso a tablas en Postgres orientado a columnas

Para una hoja de ruta detallada, consulta la [Hoja de Ruta de ParadeDB para 2025](https://github.com/orgs/paradedb/discussions/2041).

## Primeros Pasos

Para comenzar, por favor visita nuestra [documentación](https://docs.paradedb.com).

## Despliegue de ParadeDB

ParadeDB y sus extensiones pueden desplegarse de dos maneras:

- Imagen Docker basada en [Postgres](https://hub.docker.com/_/postgres) ([ver instrucciones de despliegue](https://docs.paradedb.com/deploy/aws))
- Chart de Helm para Kubernetes basado en [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([ver instrucciones de despliegue](https://docs.paradedb.com/deploy/helm))

Para más información, incluyendo características empresariales y soporte, por favor [contáctanos por correo electrónico](mailto:sales@paradedb.com).

### Extensiones

Puedes encontrar binarios precompilados para las extensiones de ParadeDB Postgres en Debian 11, 12, Ubuntu 22.04 y 24.04, Red Hat Enterprise Linux 8 y 9, y macOS 14 (Sonoma) y 15 (Sequoia) para Postgres 14+ en los [Lanzamientos de GitHub](https://github.com/paradedb/paradedb/releases/latest).

ParadeDB es compatible con todas las versiones soportadas por el PostgreSQL Global Development Group, que incluye PostgreSQL 14+, y puedes compilar las extensiones para otras versiones de Postgres siguiendo las instrucciones en el README de cada extensión.

### Imagen Docker

Para iniciar rápidamente una instancia de ParadeDB, simplemente descarga y ejecuta la última imagen de Docker:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Esto iniciará una instancia de ParadeDB con el usuario predeterminado `postgres` y la contraseña `password`. Luego, puedes conectarte a la base de datos usando `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Para instalar ParadeDB localmente o en tus propias instalaciones, recomendamos usar nuestro archivo `docker-compose.yml`. Alternativamente, puedes pasar las variables de entorno apropiadas al comando `docker run`, reemplazando los <> con los valores deseados:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<usuario> \
  -e POSTGRES_PASSWORD=<contraseña> \
  -e POSTGRES_DB=<nombredb> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Esto iniciará una instancia de ParadeDB con el usuario no root `<usuario>` y la contraseña `<contraseña>`. La opción `-v` permite que los datos de ParadeDB persistan a través de reinicios en un volumen Docker llamado `paradedb_data`.

Luego puedes conectarte a la base de datos usando `psql`:

```bash
docker exec -it paradedb psql -U <usuario> -d <nombredb> -p 5432 -W
```

### Chart de Helm

ParadeDB también está disponible para Kubernetes a través de nuestro chart de Helm. Puedes encontrar nuestro chart de Helm en el [repositorio de GitHub de ParadeDB Helm Chart](https://github.com/paradedb/charts) o descargarlo directamente desde [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

Por el momento, ParadeDB no está disponible como servicio en la nube gestionado. Si estás interesado en un servicio ParadeDB Cloud, por favor háznoslo saber uniéndote a nuestra [lista de espera](https://form.typeform.com/to/jHkLmIzx).

## Soporte

Si echas de menos alguna característica o has encontrado un error, por favor abre un
[Issue en GitHub](https://github.com/paradedb/paradedb/issues/new/choose).

Para obtener soporte de la comunidad, puedes:

- Publicar una pregunta en la [Comunidad de Slack de ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Pedir ayuda en nuestras [Discusiones de GitHub](https://github.com/paradedb/paradedb/discussions)

Si necesitas soporte comercial, por favor [contacta con el equipo de ParadeDB](mailto:sales@paradedb.com).

## Contribuir

Damos la bienvenida a las contribuciones de la comunidad, grandes o pequeñas, y estamos aquí para guiarte en el proceso. Para comenzar a contribuir, revisa nuestros [issues para principiantes](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
o escríbenos en el [Slack de la Comunidad ParadeDB](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). ¡Una vez que contribuyas, avísanos en Slack y te enviaremos algunos obsequios de ParadeDB!

Para más información sobre cómo contribuir, consulta nuestra
[Guía de Contribución](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Este proyecto se publica con un [Código de Conducta del Colaborador](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Al participar en este proyecto, aceptas seguir sus términos.

Gracias por ayudarnos a hacer ParadeDB mejor para todos :heart:.

## Licencia

ParadeDB está licenciado bajo la [Licencia Pública General de GNU Affero v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) y como software comercial. Para licencias comerciales, por favor contacta con nosotros en [sales@paradedb.com](mailto:sales@paradedb.com).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---