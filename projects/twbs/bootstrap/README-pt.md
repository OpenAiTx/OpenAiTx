<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Framework front-end elegante, intuitivo e poderoso para um desenvolvimento web mais rápido e fácil.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Explore a documentação do Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Reportar bug</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Solicitar funcionalidade</a>
  ·
  <a href="https://themes.getbootstrap.com/">Temas</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>


## Bootstrap 5

Nosso branch padrão é para o desenvolvimento do lançamento do Bootstrap 5. Acesse o branch [`v4-dev`](https://github.com/twbs/bootstrap/tree/v4-dev) para ver o readme, documentação e código-fonte do Bootstrap 4.


## Índice

- [Início rápido](#quick-start)
- [Status](#status)
- [O que está incluído](#whats-included)
- [Bugs e solicitações de funcionalidades](#bugs-and-feature-requests)
- [Documentação](#documentation)
- [Contribuindo](#contributing)
- [Comunidade](#community)
- [Versionamento](#versioning)
- [Criadores](#creators)
- [Agradecimentos](#thanks)
- [Direitos autorais e licença](#copyright-and-license)


## Início rápido

Várias opções de início rápido estão disponíveis:

- [Baixar a última versão](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clone o repositório: `git clone https://github.com/twbs/bootstrap.git`
- Instale com [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Instale com [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Instale com [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Instale com [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Instale com [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Leia a [página de Introdução](https://getbootstrap.com/docs/5.3/getting-started/introduction/) para informações sobre o conteúdo do framework, modelos, exemplos e muito mais.


## Status

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)


## O que está incluído

Dentro do download você encontrará os seguintes diretórios e arquivos, agrupando logicamente ativos comuns e fornecendo variações compiladas e minificadas.

<details>
  <summary>Conteúdo do download</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Fornecemos CSS e JS compilados (`bootstrap.*`), assim como CSS e JS compilados e minificados (`bootstrap.min.*`). [Mapas de origem](https://web.dev/articles/source-maps) (`bootstrap.*.map`) estão disponíveis para uso com as ferramentas de desenvolvedor de determinados navegadores. Os arquivos JS agrupados (`bootstrap.bundle.js` e minificado `bootstrap.bundle.min.js`) incluem o [Popper](https://popper.js.org/docs/v2/).


## Bugs e solicitações de funcionalidades

Tem um bug ou uma solicitação de funcionalidade? Por favor, primeiro leia as [diretrizes de issues](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) e pesquise por issues existentes e fechadas. Se seu problema ou ideia ainda não foi abordado, [abra uma nova issue](https://github.com/twbs/bootstrap/issues/new/choose).


## Documentação

A documentação do Bootstrap, incluída neste repositório no diretório raiz, é construída com [Astro](https://astro.build/) e hospedada publicamente no GitHub Pages em <https://getbootstrap.com/>. A documentação também pode ser executada localmente.

A busca na documentação é alimentada pelo [DocSearch da Algolia](https://docsearch.algolia.com/).

### Executando a documentação localmente

1. Execute `npm install` para instalar as dependências do Node.js, incluindo o Astro (o construtor do site).
2. Execute `npm run test` (ou um script npm específico) para reconstruir os arquivos CSS e JavaScript distribuídos, bem como os ativos da documentação.
3. A partir do diretório raiz `/bootstrap`, execute `npm run docs-serve` na linha de comando.
4. Abra `http://localhost:9001/` em seu navegador, e voilà.

Saiba mais sobre como usar o Astro lendo a [documentação](https://docs.astro.build/en/getting-started/).

### Documentação para versões anteriores

Você pode encontrar a documentação de todas as versões anteriores em <https://getbootstrap.com/docs/versions/>.

[Lançamentos anteriores](https://github.com/twbs/bootstrap/releases) e suas documentações também estão disponíveis para download.


## Contribuindo

Por favor, leia as nossas [diretrizes de contribuição](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md). Estão incluídas instruções para abertura de issues, padrões de codificação e notas sobre desenvolvimento.

Além disso, se sua pull request contiver correções ou funcionalidades em JavaScript, você deve incluir [testes unitários relevantes](https://github.com/twbs/bootstrap/tree/main/js/tests). Todo HTML e CSS devem estar em conformidade com o [Code Guide](https://github.com/mdo/code-guide), mantido por [Mark Otto](https://github.com/mdo).

Preferências de editor estão disponíveis no [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) para fácil utilização nos editores de texto mais comuns. Saiba mais e baixe plugins em <https://editorconfig.org/>.


## Comunidade

Receba atualizações sobre o desenvolvimento do Bootstrap e converse com os mantenedores do projeto e membros da comunidade.

- Siga [@getbootstrap no X](https://x.com/getbootstrap).
- Leia e assine [O Blog Oficial do Bootstrap](https://blog.getbootstrap.com/).
- Tire dúvidas e explore [nossas Discussões no GitHub](https://github.com/twbs/bootstrap/discussions).
- Discuta, tire dúvidas e mais no [Discord da comunidade](https://discord.gg/bZUvakRU3M) ou no [subreddit do Bootstrap](https://www.reddit.com/r/bootstrap/).
- Converse com outros usuários do Bootstrap no IRC. No servidor `irc.libera.chat`, no canal `#bootstrap`.
- Ajuda para implementação pode ser encontrada no Stack Overflow (com a tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Desenvolvedores devem usar a palavra-chave `bootstrap` em pacotes que modificam ou adicionam funcionalidades ao Bootstrap ao distribuir via [npm](https://www.npmjs.com/browse/keyword/bootstrap) ou mecanismos similares para máxima descoberta.


## Versionamento

Para transparência em nosso ciclo de lançamentos e na busca por manter compatibilidade retroativa, o Bootstrap é mantido sob [as diretrizes de Versionamento Semântico](https://semver.org/). Às vezes cometemos erros, mas seguimos essas regras sempre que possível.

Veja [a seção de Lançamentos do nosso projeto no GitHub](https://github.com/twbs/bootstrap/releases) para changelogs de cada versão do Bootstrap. As postagens de anúncio de lançamentos no [blog oficial do Bootstrap](https://blog.getbootstrap.com/) contêm resumos das mudanças mais importantes de cada versão.


## Criadores

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>


## Agradecimentos

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Obrigado ao [BrowserStack](https://www.browserstack.com/) por fornecer a infraestrutura que nos permite testar em navegadores reais!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Obrigado à [Netlify](https://www.netlify.com/) por fornecer os Deploy Previews!


## Patrocinadores

Apoie este projeto tornando-se um patrocinador. Seu logo aparecerá aqui com um link para o seu site. [[Torne-se um patrocinador](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)


## Apoiadores

Obrigado a todos os nossos apoiadores! 🙏 [[Torne-se um apoiador](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)


## Direitos autorais e licença

Código e documentação com direitos autorais de 2011-2025 dos [Autores do Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Código lançado sob a [Licença MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Documentação lançada sob [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---