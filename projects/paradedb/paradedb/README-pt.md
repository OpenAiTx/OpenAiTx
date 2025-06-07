<h1 align="center">
  <a href="https://paradedb.com"><img src="https://raw.githubusercontent.com/paradedb/paradedb/dev/docs/logo/readme.svg" alt="ParadeDB"></a>
<br>
</h1>

<p align="center">
  <b>Postgres para Busca e Análise</b> <br />
</p>

<h3 align="center">
  <a href="https://paradedb.com">Site</a> &bull;
  <a href="https://docs.paradedb.com">Documentação</a> &bull;
  <a href="https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw">Comunidade</a> &bull;
  <a href="https://paradedb.com/blog/">Blog</a> &bull;
  <a href="https://docs.paradedb.com/changelog/">Changelog</a>
</h3>

---

[![Artifact Hub](https://img.shields.io/endpoint?url=https://artifacthub.io/badge/repository/paradedb)](https://artifacthub.io/packages/search?repo=paradedb)
[![Docker Pulls](https://img.shields.io/docker/pulls/paradedb/paradedb)](https://hub.docker.com/r/paradedb/paradedb)
[![License](https://img.shields.io/github/license/paradedb/paradedb?color=blue)](https://github.com/paradedb/paradedb?tab=AGPL-3.0-1-ov-file#readme)
[![Slack URL](https://img.shields.io/badge/Join%20Slack-purple?logo=slack&link=https%3A%2F%2Fjoin.slack.com%2Ft%2Fparadedbcommunity%2Fshared_invite%2Fzt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
[![X URL](https://img.shields.io/twitter/url?url=https%3A%2F%2Ftwitter.com%2Fparadedb&label=Follow%20%40paradedb)](https://x.com/paradedb)

[ParadeDB](https://paradedb.com) é uma alternativa moderna ao Elasticsearch construída sobre o Postgres. Feita para cargas de trabalho em tempo real e com muitas atualizações.

## Roadmap

- [x] Busca
  - [x] Busca em texto completo com BM25 usando [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [x] Busca por vetores densos e esparsos com [pgvector](https://github.com/pgvector/pgvector#pgvector)
  - [ ] Busca distribuída
- [ ] Análises
  - [x] Busca facetada em dados do Postgres com [pg_search](https://github.com/paradedb/paradedb/tree/dev/pg_search#overview)
  - [ ] Método de acesso a tabelas orientadas a colunas no Postgres

Para um roadmap detalhado, veja o [Roadmap do ParadeDB para 2025](https://github.com/orgs/paradedb/discussions/2041).

## Primeiros Passos

Para começar, por favor visite nossa [documentação](https://docs.paradedb.com).

## Implantando o ParadeDB

O ParadeDB e suas extensões podem ser implantados de duas formas:

- Imagem Docker baseada no [Postgres](https://hub.docker.com/_/postgres) ([veja as instruções de implantação](https://docs.paradedb.com/deploy/aws))
- Helm chart para Kubernetes baseado no [CloudNativePG](https://artifacthub.io/packages/helm/cloudnative-pg/cloudnative-pg) ([veja as instruções de implantação](https://docs.paradedb.com/deploy/helm))

Para mais informações, incluindo recursos empresariais e suporte, por favor [entre em contato por e-mail](mailto:sales@paradedb.com).

### Extensões

Você pode encontrar binários pré-compilados das extensões ParadeDB para Postgres em Debian 11, 12, Ubuntu 22.04 e 24.04, Red Hat Enterprise Linux 8 e 9, e macOS 14 (Sonoma) e 15 (Sequoia) para Postgres 14+ nos [GitHub Releases](https://github.com/paradedb/paradedb/releases/latest).

O ParadeDB suporta todas as versões mantidas pelo PostgreSQL Global Development Group, incluindo PostgreSQL 14+, e você pode compilar as extensões para outras versões do Postgres seguindo as instruções no README da respectiva extensão.

### Imagem Docker

Para iniciar rapidamente uma instância ParadeDB, basta puxar e rodar a imagem Docker mais recente:

```bash
docker run --name paradedb -e POSTGRES_PASSWORD=password paradedb/paradedb
```

Isso irá iniciar uma instância ParadeDB com o usuário padrão `postgres` e senha `password`. Você pode então se conectar ao banco de dados usando `psql`:

```bash
docker exec -it paradedb psql -U postgres
```

Para instalar o ParadeDB localmente ou on-premises, recomendamos o uso do nosso arquivo `docker-compose.yml`. Alternativamente, você pode passar as variáveis de ambiente apropriadas para o comando `docker run`, substituindo os <> pelos valores desejados:

```bash
docker run \
  --name paradedb \
  -e POSTGRES_USER=<usuario> \
  -e POSTGRES_PASSWORD=<senha> \
  -e POSTGRES_DB=<nomedb> \
  -v paradedb_data:/var/lib/postgresql/data/ \
  -p 5432:5432 \
  -d \
  paradedb/paradedb:latest
```

Isso irá iniciar uma instância ParadeDB com usuário não-root `<usuario>` e senha `<senha>`. O parâmetro `-v` permite que seus dados ParadeDB persistam entre reinicializações em um volume Docker chamado `paradedb_data`.

Você pode então se conectar ao banco de dados usando `psql`:

```bash
docker exec -it paradedb psql -U <usuario> -d <nomedb> -p 5432 -W
```

### Helm Chart

O ParadeDB também está disponível para Kubernetes via nosso Helm chart. Você pode encontrar o Helm chart no [repositório ParadeDB Helm Chart no GitHub](https://github.com/paradedb/charts) ou baixá-lo diretamente do [Artifact Hub](https://artifacthub.io/packages/helm/paradedb/paradedb).

### ParadeDB Cloud

No momento, o ParadeDB não está disponível como serviço gerenciado em nuvem. Se você tem interesse em um serviço ParadeDB Cloud, por favor nos avise entrando em nossa [lista de espera](https://form.typeform.com/to/jHkLmIzx).

## Suporte

Se você sentir falta de algum recurso ou encontrou um bug, por favor abra uma
[Issue no GitHub](https://github.com/paradedb/paradedb/issues/new/choose).

Para obter suporte da comunidade, você pode:

- Publicar uma dúvida na [Comunidade ParadeDB no Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw)
- Pedir ajuda em nossas [Discussões no GitHub](https://github.com/paradedb/paradedb/discussions)

Se precisar de suporte comercial, por favor [entre em contato com o time ParadeDB](mailto:sales@paradedb.com).

## Contribuindo

Agradecemos contribuições da comunidade, grandes ou pequenas, e estamos aqui para te guiar ao longo do caminho. Para começar a contribuir, confira nossos [issues para iniciantes](https://github.com/paradedb/paradedb/labels/good%20first%20issue)
ou envie uma mensagem para nós na [Comunidade ParadeDB no Slack](https://join.slack.com/t/paradedbcommunity/shared_invite/zt-32abtyjg4-yoYoi~RPh9MSW8tDbl0BQw). Assim que contribuir, avise no Slack e enviaremos alguns brindes ParadeDB!

Para mais informações sobre como contribuir, consulte nosso
[Guia de Contribuição](https://raw.githubusercontent.com/paradedb/paradedb/dev/CONTRIBUTING.md).

Este projeto é lançado com um [Código de Conduta do Contribuidor](https://raw.githubusercontent.com/paradedb/paradedb/dev/CODE_OF_CONDUCT.md).
Ao participar deste projeto, você concorda em seguir estes termos.

Obrigado por nos ajudar a tornar o ParadeDB melhor para todos :heart:.

## Licença

O ParadeDB é licenciado sob a [GNU Affero General Public License v3.0](https://raw.githubusercontent.com/paradedb/paradedb/dev/LICENSE) e como software comercial. Para licenciamento comercial, entre em contato conosco em [sales@paradedb.com](mailto:sales@paradedb.com).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---