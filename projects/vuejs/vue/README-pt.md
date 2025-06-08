## Vue 2 chegou ao Fim da Vida Útil

**Você está visualizando o repositório agora inativo do Vue 2. O repositório ativamente mantido para a versão mais recente do Vue é [vuejs/core](https://github.com/vuejs/core).**

O Vue chegou ao Fim da Vida Útil em 31 de dezembro de 2023. Ele não recebe mais novos recursos, atualizações ou correções. No entanto, ainda está disponível em todos os canais de distribuição existentes (CDNs, gerenciadores de pacotes, Github, etc).

Se você está começando um novo projeto, por favor, inicie com a versão mais recente do Vue (3.x). Também recomendamos fortemente que os usuários atuais do Vue 2 façam a atualização ([guia](https://v3-migration.vuejs.org/)), mas reconhecemos que nem todos os usuários têm tempo ou incentivo para fazê-lo. Se você precisa permanecer no Vue 2, mas também tem requisitos de conformidade ou segurança relativos a software sem manutenção, confira o [Vue 2 NES](https://www.herodevs.com/support/nes-vue?utm_source=vuejs-github&utm_medium=vue2-readme).

<p align="center"><a href="https://vuejs.org" target="_blank" rel="noopener noreferrer"><img width="100" src="https://vuejs.org/images/logo.png" alt="Vue logo"></a></p>

<p align="center">
  <a href="https://circleci.com/gh/vuejs/vue/tree/dev"><img src="https://img.shields.io/circleci/project/github/vuejs/vue/dev.svg?sanitize=true" alt="Build Status"></a>
  <a href="https://codecov.io/github/vuejs/vue?branch=dev"><img src="https://img.shields.io/codecov/c/github/vuejs/vue/dev.svg?sanitize=true" alt="Coverage Status"></a>
  <a href="https://npmcharts.com/compare/vue?minimal=true"><img src="https://img.shields.io/npm/dm/vue.svg?sanitize=true" alt="Downloads"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/v/vue.svg?sanitize=true" alt="Version"></a>
  <a href="https://www.npmjs.com/package/vue"><img src="https://img.shields.io/npm/l/vue.svg?sanitize=true" alt="License"></a>
  <a href="https://chat.vuejs.org/"><img src="https://img.shields.io/badge/chat-on%20discord-7289da.svg?sanitize=true" alt="Chat"></a>
</p>

## Patrocinadores

Vue.js é um projeto open source licenciado sob MIT, com seu desenvolvimento contínuo possibilitado inteiramente pelo apoio destes incríveis [apoiadores](https://github.com/vuejs/core/blob/main/BACKERS.md). Se você gostaria de se juntar a eles, por favor, considere [patrocinar o desenvolvimento do Vue](https://vuejs.org/sponsor/).

<p align="center">
  <h3 align="center">Patrocinador Especial</h3>
</p>

<p align="center">
  <a target="_blank" href="https://github.com/appwrite/appwrite">
  <img alt="special sponsor appwrite" src="https://sponsors.vuejs.org/images/appwrite.svg" width="300">
  </a>
</p>

<p align="center">
  <a target="_blank" href="https://vuejs.org/sponsor/">
    <img alt="sponsors" src="https://sponsors.vuejs.org/sponsors.svg?v3">
  </a>
</p>

---

## Introdução

Vue (pronuncia-se `/vjuː/`, como view) é um **framework progressivo** para construção de interfaces de usuário. Ele foi projetado desde o início para ser adotado incrementalmente, podendo escalar facilmente entre uma biblioteca e um framework, dependendo dos diferentes casos de uso. Consiste em uma biblioteca central acessível, que foca apenas na camada de visualização, e um ecossistema de bibliotecas de suporte que ajuda a lidar com a complexidade em grandes Aplicações de Página Única (SPA).

#### Compatibilidade com Navegadores

Vue.js é compatível com todos os navegadores que são [compatíveis com ES5](https://compat-table.github.io/compat-table/es5/) (IE8 e inferiores não são suportados).

## Ecossistema

| Projeto               | Status                                                       | Descrição                                               |
| --------------------- | ------------------------------------------------------------ | ------------------------------------------------------- |
| [vue-router]          | [![vue-router-status]][vue-router-package]                   | Roteamento para aplicação de página única               |
| [vuex]                | [![vuex-status]][vuex-package]                               | Gerenciamento de estado em larga escala                 |
| [vue-cli]             | [![vue-cli-status]][vue-cli-package]                         | Estruturação de projetos                                |
| [vue-loader]          | [![vue-loader-status]][vue-loader-package]                   | Loader de Componente de Arquivo Único (`*.vue`) para webpack |
| [vue-server-renderer] | [![vue-server-renderer-status]][vue-server-renderer-package] | Suporte à renderização do lado do servidor              |
| [vue-class-component] | [![vue-class-component-status]][vue-class-component-package] | Decorador TypeScript para API baseada em classes        |
| [vue-rx]              | [![vue-rx-status]][vue-rx-package]                           | Integração com RxJS                                     |
| [vue-devtools]        | [![vue-devtools-status]][vue-devtools-package]               | Extensão DevTools para navegador                        |

[vue-router]: https://github.com/vuejs/vue-router
[vuex]: https://github.com/vuejs/vuex
[vue-cli]: https://github.com/vuejs/vue-cli
[vue-loader]: https://github.com/vuejs/vue-loader
[vue-server-renderer]: https://github.com/vuejs/vue/tree/dev/packages/vue-server-renderer
[vue-class-component]: https://github.com/vuejs/vue-class-component
[vue-rx]: https://github.com/vuejs/vue-rx
[vue-devtools]: https://github.com/vuejs/vue-devtools
[vue-router-status]: https://img.shields.io/npm/v/vue-router.svg
[vuex-status]: https://img.shields.io/npm/v/vuex.svg
[vue-cli-status]: https://img.shields.io/npm/v/@vue/cli.svg
[vue-loader-status]: https://img.shields.io/npm/v/vue-loader.svg
[vue-server-renderer-status]: https://img.shields.io/npm/v/vue-server-renderer.svg
[vue-class-component-status]: https://img.shields.io/npm/v/vue-class-component.svg
[vue-rx-status]: https://img.shields.io/npm/v/vue-rx.svg
[vue-devtools-status]: https://img.shields.io/chrome-web-store/v/nhdogjmejiglipccpnnnanhbledajbpd.svg
[vue-router-package]: https://npmjs.com/package/vue-router
[vuex-package]: https://npmjs.com/package/vuex
[vue-cli-package]: https://npmjs.com/package/@vue/cli
[vue-loader-package]: https://npmjs.com/package/vue-loader
[vue-server-renderer-package]: https://npmjs.com/package/vue-server-renderer
[vue-class-component-package]: https://npmjs.com/package/vue-class-component
[vue-rx-package]: https://npmjs.com/package/vue-rx
[vue-devtools-package]: https://chrome.google.com/webstore/detail/vuejs-devtools/nhdogjmejiglipccpnnnanhbledajbpd

## Documentação

Para ver [exemplos ao vivo](https://v2.vuejs.org/v2/examples/) e a documentação, acesse [vuejs.org](https://v2.vuejs.org).

## Dúvidas

Para dúvidas e suporte, por favor utilize [o fórum oficial](https://forum.vuejs.org) ou [chat da comunidade](https://chat.vuejs.org/). A lista de issues deste repositório é **exclusivamente** para relatos de bugs e pedidos de recursos.

## Problemas

Por favor, certifique-se de ler o [Checklist de Relato de Issues](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md#issue-reporting-guidelines) antes de abrir um issue. Issues que não estejam de acordo com as diretrizes podem ser fechadas imediatamente.

## Registro de Alterações

As mudanças detalhadas de cada versão estão documentadas nas [notas de lançamento](https://github.com/vuejs/vue/releases).

## Fique em Contato

- [Twitter](https://twitter.com/vuejs)
- [Blog](https://medium.com/the-vue-point)
- [Quadro de Vagas](https://vuejobs.com/?ref=vuejs)

## Contribuição

Por favor, certifique-se de ler o [Guia de Contribuição](https://github.com/vuejs/vue/blob/dev/.github/CONTRIBUTING.md) antes de fazer um pull request. Se você tem um projeto/componente/ferramenta relacionada ao Vue, adicione-o com um pull request a [esta lista curada](https://github.com/vuejs/awesome-vue)!

Obrigado a todas as pessoas que já contribuíram com o Vue!

<a href="https://github.com/vuejs/vue/graphs/contributors"><img src="https://opencollective.com/vuejs/contributors.svg?width=890" /></a>

## Licença

[MIT](https://opensource.org/licenses/MIT)

Copyright (c) 2013-presente, Yuxi (Evan) You

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---