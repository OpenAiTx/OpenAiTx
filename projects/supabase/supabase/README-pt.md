<p align="center">
<img src="https://user-images.githubusercontent.com/8291514/213727234-cda046d6-28c6-491a-b284-b86c5cede25d.png#gh-light-mode-only">
<img src="https://user-images.githubusercontent.com/8291514/213727225-56186826-bee8-43b5-9b15-86e839d89393.png#gh-dark-mode-only">
</p>

# Supabase

[Supabase](https://supabase.com) é uma alternativa open source ao Firebase. Estamos construindo as funcionalidades do Firebase utilizando ferramentas open source de nível empresarial.

- [x] Banco de Dados Postgres hospedado. [Documentação](https://supabase.com/docs/guides/database)
- [x] Autenticação e Autorização. [Documentação](https://supabase.com/docs/guides/auth)
- [x] APIs geradas automaticamente.
  - [x] REST. [Documentação](https://supabase.com/docs/guides/api)
  - [x] GraphQL. [Documentação](https://supabase.com/docs/guides/graphql)
  - [x] Assinaturas em tempo real. [Documentação](https://supabase.com/docs/guides/realtime)
- [x] Funções.
  - [x] Funções do Banco de Dados. [Documentação](https://supabase.com/docs/guides/database/functions)
  - [x] Edge Functions [Documentação](https://supabase.com/docs/guides/functions)
- [x] Armazenamento de Arquivos. [Documentação](https://supabase.com/docs/guides/storage)
- [x] Ferramentas de IA + Vetor/Embeddings. [Documentação](https://supabase.com/docs/guides/ai)
- [x] Painel de Controle

![Painel Supabase](https://raw.githubusercontent.com/supabase/supabase/master/apps/www/public/images/github/supabase-dashboard.png)

Acompanhe os "releases" deste repositório para ser notificado de atualizações importantes.

<kbd><img src="https://raw.githubusercontent.com/supabase/supabase/d5f7f413ab356dc1a92075cb3cee4e40a957d5b1/web/static/watch-repo.gif" alt="Acompanhar este repositório"/></kbd>

## Documentação

Para a documentação completa, visite [supabase.com/docs](https://supabase.com/docs)

Para saber como contribuir, acesse [Primeiros Passos](./DEVELOPERS.md)

## Comunidade & Suporte

- [Fórum da Comunidade](https://github.com/supabase/supabase/discussions). Indicado para: ajuda no desenvolvimento, discussão sobre melhores práticas em banco de dados.
- [GitHub Issues](https://github.com/supabase/supabase/issues). Indicado para: bugs e erros encontrados ao usar o Supabase.
- [Suporte por E-mail](https://supabase.com/docs/support#business-support). Indicado para: problemas com seu banco de dados ou infraestrutura.
- [Discord](https://discord.supabase.com). Indicado para: compartilhar suas aplicações e interagir com a comunidade.

## Como funciona

O Supabase é uma combinação de ferramentas open source. Estamos construindo as funcionalidades do Firebase usando produtos open source de nível empresarial. Se as ferramentas e comunidades existirem, com uma licença aberta MIT, Apache 2 ou equivalente, iremos utilizar e apoiar essa ferramenta. Se a ferramenta não existir, nós a construímos e a disponibilizamos como open source. O Supabase não é um mapeamento 1-para-1 do Firebase. Nosso objetivo é oferecer aos desenvolvedores uma experiência semelhante à do Firebase, utilizando ferramentas open source.

**Arquitetura**

O Supabase é uma [plataforma hospedada](https://supabase.com/dashboard). Você pode se cadastrar e começar a usar o Supabase sem instalar nada.
Você também pode [hospedar por conta própria](https://supabase.com/docs/guides/hosting/overview) e [desenvolver localmente](https://supabase.com/docs/guides/local-development).

![Arquitetura](apps/docs/public/img/supabase-architecture.svg)

- [Postgres](https://www.postgresql.org/) é um sistema de banco de dados objeto-relacional com mais de 30 anos de desenvolvimento ativo, conquistando uma forte reputação por confiabilidade, robustez de recursos e desempenho.
- [Realtime](https://github.com/supabase/realtime) é um servidor Elixir que permite escutar inserts, updates e deletes no PostgreSQL usando websockets. O Realtime consulta a funcionalidade de replicação interna do Postgres para alterações no banco de dados, converte as alterações para JSON e transmite o JSON por websockets para clientes autorizados.
- [PostgREST](http://postgrest.org/) é um servidor web que transforma seu banco de dados PostgreSQL diretamente em uma API RESTful.
- [GoTrue](https://github.com/supabase/gotrue) é uma API de autenticação baseada em JWT que simplifica cadastros, logins e gerenciamento de sessões em suas aplicações.
- [Storage](https://github.com/supabase/storage-api) é uma API RESTful para gerenciamento de arquivos no S3, com o Postgres controlando permissões.
- [pg_graphql](http://github.com/supabase/pg_graphql/) é uma extensão do PostgreSQL que expõe uma API GraphQL.
- [postgres-meta](https://github.com/supabase/postgres-meta) é uma API RESTful para gerenciar seu Postgres, permitindo buscar tabelas, adicionar roles, executar queries, etc.
- [Kong](https://github.com/Kong/kong) é um gateway de API nativo para a nuvem.

#### Bibliotecas cliente

Nossa abordagem para bibliotecas cliente é modular. Cada sub-biblioteca é uma implementação independente para um único sistema externo. Esta é uma das formas de apoiarmos ferramentas existentes.

<table style="table-layout:fixed; white-space: nowrap;">
  <tr>
    <th>Linguagem</th>
    <th>Cliente</th>
    <th colspan="5">Clientes de Funcionalidade (incluídos no cliente Supabase)</th>
  </tr>
  <!-- notranslate -->
  <tr>
    <th></th>
    <th>Supabase</th>
    <th><a href="https://github.com/postgrest/postgrest" target="_blank" rel="noopener noreferrer">PostgREST</a></th>
    <th><a href="https://github.com/supabase/gotrue" target="_blank" rel="noopener noreferrer">GoTrue</a></th>
    <th><a href="https://github.com/supabase/realtime" target="_blank" rel="noopener noreferrer">Realtime</a></th>
    <th><a href="https://github.com/supabase/storage-api" target="_blank" rel="noopener noreferrer">Storage</a></th>
    <th>Funções</th>
  </tr>
  <!-- TEMPLATE FOR NEW ROW -->
  <!-- START ROW
  <tr>
    <td>lang</td>
    <td><a href="https://github.com/supabase-community/supabase-lang" target="_blank" rel="noopener noreferrer">supabase-lang</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-lang" target="_blank" rel="noopener noreferrer">postgrest-lang</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-lang" target="_blank" rel="noopener noreferrer">gotrue-lang</a></td>
    <td><a href="https://github.com/supabase-community/realtime-lang" target="_blank" rel="noopener noreferrer">realtime-lang</a></td>
    <td><a href="https://github.com/supabase-community/storage-lang" target="_blank" rel="noopener noreferrer">storage-lang</a></td>
  </tr>
  END ROW -->
  <!-- /notranslate -->
  <th colspan="7">⚡️ Oficial ⚡️</th>
  <!-- notranslate -->
  <tr>
    <td>JavaScript (TypeScript)</td>
    <td><a href="https://github.com/supabase/supabase-js" target="_blank" rel="noopener noreferrer">supabase-js</a></td>
    <td><a href="https://github.com/supabase/postgrest-js" target="_blank" rel="noopener noreferrer">postgrest-js</a></td>
    <td><a href="https://github.com/supabase/gotrue-js" target="_blank" rel="noopener noreferrer">gotrue-js</a></td>
    <td><a href="https://github.com/supabase/realtime-js" target="_blank" rel="noopener noreferrer">realtime-js</a></td>
    <td><a href="https://github.com/supabase/storage-js" target="_blank" rel="noopener noreferrer">storage-js</a></td>
    <td><a href="https://github.com/supabase/functions-js" target="_blank" rel="noopener noreferrer">functions-js</a></td>
  </tr>
    <tr>
    <td>Flutter</td>
    <td><a href="https://github.com/supabase/supabase-flutter" target="_blank" rel="noopener noreferrer">supabase-flutter</a></td>
    <td><a href="https://github.com/supabase/postgrest-dart" target="_blank" rel="noopener noreferrer">postgrest-dart</a></td>
    <td><a href="https://github.com/supabase/gotrue-dart" target="_blank" rel="noopener noreferrer">gotrue-dart</a></td>
    <td><a href="https://github.com/supabase/realtime-dart" target="_blank" rel="noopener noreferrer">realtime-dart</a></td>
    <td><a href="https://github.com/supabase/storage-dart" target="_blank" rel="noopener noreferrer">storage-dart</a></td>
    <td><a href="https://github.com/supabase/functions-dart" target="_blank" rel="noopener noreferrer">functions-dart</a></td>
  </tr>
  <tr>
    <td>Swift</td>
    <td><a href="https://github.com/supabase/supabase-swift" target="_blank" rel="noopener noreferrer">supabase-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/PostgREST" target="_blank" rel="noopener noreferrer">postgrest-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Auth" target="_blank" rel="noopener noreferrer">auth-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Realtime" target="_blank" rel="noopener noreferrer">realtime-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Storage" target="_blank" rel="noopener noreferrer">storage-swift</a></td>
    <td><a href="https://github.com/supabase/supabase-swift/tree/main/Sources/Functions" target="_blank" rel="noopener noreferrer">functions-swift</a></td>
  </tr>
  <tr>
    <td>Python</td>
    <td><a href="https://github.com/supabase/supabase-py" target="_blank" rel="noopener noreferrer">supabase-py</a></td>
    <td><a href="https://github.com/supabase/postgrest-py" target="_blank" rel="noopener noreferrer">postgrest-py</a></td>
    <td><a href="https://github.com/supabase/gotrue-py" target="_blank" rel="noopener noreferrer">gotrue-py</a></td>
    <td><a href="https://github.com/supabase/realtime-py" target="_blank" rel="noopener noreferrer">realtime-py</a></td>
    <td><a href="https://github.com/supabase/storage-py" target="_blank" rel="noopener noreferrer">storage-py</a></td>
    <td><a href="https://github.com/supabase/functions-py" target="_blank" rel="noopener noreferrer">functions-py</a></td>
  </tr>
  <!-- /notranslate -->
  <th colspan="7">💚 Comunidade 💚</th>
  <!-- notranslate -->
  <tr>
    <td>C#</td>
    <td><a href="https://github.com/supabase-community/supabase-csharp" target="_blank" rel="noopener noreferrer">supabase-csharp</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-csharp" target="_blank" rel="noopener noreferrer">postgrest-csharp</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-csharp" target="_blank" rel="noopener noreferrer">gotrue-csharp</a></td>
    <td><a href="https://github.com/supabase-community/realtime-csharp" target="_blank" rel="noopener noreferrer">realtime-csharp</a></td>
    <td><a href="https://github.com/supabase-community/storage-csharp" target="_blank" rel="noopener noreferrer">storage-csharp</a></td>
    <td><a href="https://github.com/supabase-community/functions-csharp" target="_blank" rel="noopener noreferrer">functions-csharp</a></td>
  </tr>
  <tr>
    <td>Go</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-go" target="_blank" rel="noopener noreferrer">postgrest-go</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-go" target="_blank" rel="noopener noreferrer">gotrue-go</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-go" target="_blank" rel="noopener noreferrer">storage-go</a></td>
    <td><a href="https://github.com/supabase-community/functions-go" target="_blank" rel="noopener noreferrer">functions-go</a></td>
  </tr>
  <tr>
    <td>Java</td>
    <td>-</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/gotrue-java" target="_blank" rel="noopener noreferrer">gotrue-java</a></td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/storage-java" target="_blank" rel="noopener noreferrer">storage-java</a></td>
    <td>-</td>
  </tr>
  <tr>
    <td>Kotlin</td>
    <td><a href="https://github.com/supabase-community/supabase-kt" target="_blank" rel="noopener noreferrer">supabase-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Postgrest" target="_blank" rel="noopener noreferrer">postgrest-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Auth" target="_blank" rel="noopener noreferrer">auth-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Realtime" target="_blank" rel="noopener noreferrer">realtime-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Storage" target="_blank" rel="noopener noreferrer">storage-kt</a></td>
    <td><a href="https://github.com/supabase-community/supabase-kt/tree/master/Functions" target="_blank" rel="noopener noreferrer">functions-kt</a></td>
  </tr>
  <tr>
    <td>Ruby</td>
    <td><a href="https://github.com/supabase-community/supabase-rb" target="_blank" rel="noopener noreferrer">supabase-rb</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-rb" target="_blank" rel="noopener noreferrer">postgrest-rb</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Rust</td>
    <td>-</td>
    <td><a href="https://github.com/supabase-community/postgrest-rs" target="_blank" rel="noopener noreferrer">postgrest-rs</a></td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
    <td>-</td>
  </tr>
  <tr>
    <td>Godot Engine (GDScript)</td>
    <td><a href="https://github.com/supabase-community/godot-engine.supabase" target="_blank" rel="noopener noreferrer">supabase-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/postgrest-gdscript" target="_blank" rel="noopener noreferrer">postgrest-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/gotrue-gdscript" target="_blank" rel="noopener noreferrer">gotrue-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/realtime-gdscript" target="_blank" rel="noopener noreferrer">realtime-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/storage-gdscript" target="_blank" rel="noopener noreferrer">storage-gdscript</a></td>
    <td><a href="https://github.com/supabase-community/functions-gdscript" target="_blank" rel="noopener noreferrer">functions-gdscript</a></td>
  </tr>
  <!-- /notranslate -->
</table>

<!--- Remove this list if you're translating to another language, it's hard to keep updated across multiple files-->
<!--- Keep only the link to the list of translation files-->

## Selos

![Feito com Supabase](./apps/www/public/badge-made-with-supabase.svg)

```md
[![Feito com Supabase](https://supabase.com/badge-made-with-supabase.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase.svg"
    alt="Feito com Supabase"
  />
</a>
```

![Feito com Supabase (escuro)](./apps/www/public/badge-made-with-supabase-dark.svg)

```md
[![Feito com Supabase](https://supabase.com/badge-made-with-supabase-dark.svg)](https://supabase.com)
```

```html
<a href="https://supabase.com">
  <img
    width="168"
    height="30"
    src="https://supabase.com/badge-made-with-supabase-dark.svg"
    alt="Feito com Supabase"
  />
</a>
```

## Traduções

- [Lista de traduções](/i18n/languages.md) <!--- Mantenha apenas este -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---