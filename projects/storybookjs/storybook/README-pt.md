<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Construa componentes de UI à prova de falhas mais rápido</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook é um ambiente de trabalho frontend para construir componentes e páginas de UI em isolamento. Milhares de equipes o utilizam para desenvolvimento, testes e documentação de UI. Saiba mais em https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Veja o README para:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Índice

- 🚀 [Primeiros Passos](#getting-started)
- 📒 [Projetos](#projects)
  - 🛠 [Frameworks Suportados & Exemplos](#supported-frameworks)
  - 🔗[Addons](#addons)
- 🏅 [Selos & Materiais de Apresentação](#badges--presentation-materials)
- 👥 [Comunidade](#community)
- 👏 [Contribuindo](#contributing)
  - 👨‍💻 [Scripts de Desenvolvimento](#development-scripts)
  - 💸 [Patrocinadores](#sponsors)
  - 💵 [Apoiadores](#backers)
- :memo: [Licença](#license)

## Primeiros Passos

Visite o [site do Storybook](https://storybook.js.org) para saber mais sobre o Storybook e começar.

### Documentação

A documentação está disponível no [site de docs do Storybook](https://storybook.js.org/docs).

### Exemplos

Veja a [Enciclopédia de Componentes](https://storybook.js.org/showcase) para ver como equipes líderes utilizam o Storybook.

Use o [storybook.new](https://storybook.new) para criar rapidamente um projeto de exemplo no Stackblitz.

O Storybook vem com diversos [addons](https://storybook.js.org/docs/configure/user-interface/storybook-addons) para design de componentes, documentação, testes, interatividade, e muito mais. A API do Storybook permite configurar e estender de várias formas. Ele também foi estendido para suportar desenvolvimento em React Native, Android, iOS e Flutter para mobile.

### Comunidade

Para ajuda adicional, compartilhe seu problema nas [Discussões do GitHub do repositório](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Projetos

### Frameworks Suportados

| Renderizador                                                    | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Addons

| Addons                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Teste componentes para acessibilidade do usuário no Storybook               |
| [actions](code/core/src/actions/)                                         | Registre ações conforme os usuários interagem com os componentes na UI      |
| [backgrounds](code/core/src/backgrounds)                                  | Permite aos usuários escolher fundos na UI do Storybook                     |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Adicione/remova dinamicamente recursos CSS no iframe do componente          |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Veja imagens, vídeos e links junto com sua história                         |
| [docs](code/addons/docs/)                                                 | Adicione documentação de alta qualidade aos seus componentes                |
| [events](https://github.com/storybookjs/addon-events)                     | Dispare eventos interativamente para componentes que respondem a EventEmitter|
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Relatórios do Google Analytics em histórias                                 |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Faça queries a um servidor GraphQL dentro das histórias do Storybook        |
| [jest](code/addons/jest/)                                                 | Veja os resultados dos testes unitários dos componentes no Storybook        |
| [links](code/addons/links/)                                               | Crie links entre histórias                                                 |
| [measure](code/core/src/measure/)                                         | Inspecione visualmente o layout e o box model na UI do Storybook            |
| [outline](code/core/src/outline/)                                         | Depure visualmente o layout e alinhamento CSS na UI do Storybook            |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Simule parâmetros de query                                                 |
| [viewport](code/core/src/viewport/)                                       | Altere tamanhos e layouts para componentes responsivos usando o Storybook   |

Veja a [Tabela de Suporte de Addons/Frameworks](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Para continuar melhorando sua experiência, precisamos eventualmente descontinuar ou remover certos addons em favor de novas e melhores ferramentas.

Se você usa info/notes, recomendamos fortemente migrar para [docs](code/addons/docs/) e [aqui está um guia](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) para te ajudar.

Se você usa contexts, recomendamos migrar para [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) e [aqui está um guia](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) para te ajudar.

Se você usa addon-storyshots, recomendamos migrar para o [test-runner](https://github.com/storybookjs/test-runner) do Storybook e [aqui está um guia](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) para te ajudar.

## Selos & Materiais de Apresentação

Temos um selo! Vincule-o ao seu exemplo de Storybook ao vivo.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](link para o site)
```

Se você procura material para usar em sua apresentação do Storybook, como logos, material de vídeo e as cores que usamos, você encontra tudo em nosso [repositório de marca](https://github.com/storybookjs/brand).

## Comunidade

- Twitter: [@storybookjs](https://x.com/storybookjs)
- Blog em [storybook.js.org](https://storybook.js.org/blog/) e [Medium](https://medium.com/storybookjs)
- Chat no [Discord](https://discord.gg/storybook)
- Vídeos e lives no [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Contribuindo

Contribuições para o Storybook são sempre bem-vindas!

- 📥 Pull requests e 🌟 Stars são sempre bem-vindos.
- Leia nosso [guia de contribuição](CONTRIBUTING.md) para começar,
  ou nos encontre no [Discord](https://discord.gg/storybook), vamos te guiar.

Procurando uma primeira issue para resolver?

- Marcamos issues com [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) quando achamos que são adequadas para quem é novo no código ou em OSS em geral.
- [Fale conosco](https://discord.gg/storybook), vamos encontrar algo que combine com suas habilidades e interesse de aprendizado.

### Scripts de Desenvolvimento

O Storybook é organizado como um monorepo. Scripts úteis incluem:

#### `yarn start`

> Executa um storybook sandbox de exemplo com histórias de teste

#### `yarn task`

> Como acima, mas oferece opções para personalizar o sandbox (ex: selecionar outros frameworks)

#### `yarn lint`

> Verifica se o código segue as regras de lint - usa remark & eslint

- `yarn lint:js` - verifica js
- `yarn lint:md` - verifica markdown + exemplos de código
- `yarn lint:js --fix` - corrige js automaticamente

#### `yarn test`

> Verifica se todos os testes unitários passam - usa jest

- `yarn run test --core --watch` - executa testes core em modo de observação

### Patrocinadores

Torne-se um patrocinador para ter seu logo e URL do site no nosso README no Github. \[[Seja um patrocinador](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Apoiadores

Ao fazer uma doação recorrente, você pode nos apoiar e apoiar nosso trabalho. \[[Seja um apoiador](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Licença

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-o fim-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---