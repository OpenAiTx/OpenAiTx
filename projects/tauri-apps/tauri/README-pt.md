<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stável-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![Licença](https://img.shields.io/badge/License-MIT%20ou%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Servidor de Chat](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![apoio](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Introdução

Tauri é um framework para construir binários pequenos e incrivelmente rápidos para todas as principais plataformas desktop. Os desenvolvedores podem integrar qualquer framework front-end que compile para HTML, JS e CSS para construir sua interface de usuário. O backend da aplicação é um binário escrito em Rust com uma API que o front-end pode interagir.

A interface de usuário em aplicativos Tauri atualmente utiliza [`tao`](https://docs.rs/tao) como biblioteca de manipulação de janelas no macOS, Windows, Linux, Android e iOS. Para renderizar sua aplicação, o Tauri utiliza [WRY](https://github.com/tauri-apps/wry), uma biblioteca que fornece uma interface unificada para o webview do sistema, aproveitando o WKWebView no macOS & iOS, WebView2 no Windows, WebKitGTK no Linux e Android System WebView no Android.

Para saber mais detalhes de como todas essas peças se encaixam, consulte este documento [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Primeiros Passos

Se você está interessado em criar um app com Tauri, por favor visite o [site da documentação](https://tauri.app).

A maneira mais rápida de começar é instalar os [pré-requisitos](https://v2.tauri.app/start/prerequisites/) para o seu sistema e criar um novo projeto com [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Por exemplo, com `npm`:

```sh
npm create tauri-app@latest
```

## Funcionalidades

A lista de funcionalidades do Tauri inclui, mas não se limita a:

- Empacotador de aplicativos integrado para criar pacotes em formatos como `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` e instaladores do Windows como `.exe` (via NSIS) e `.msi` (via WiX).
- Atualizador automático integrado (apenas desktop)
- Ícones de bandeja do sistema
- Notificações nativas
- Protocolo WebView nativo (o Tauri não cria um servidor http(s) localhost para servir o conteúdo do WebView)
- GitHub action para CI simplificado
- Extensão para VS Code

### Plataformas

O Tauri atualmente suporta desenvolvimento e distribuição nas seguintes plataformas:

| Plataforma | Versões                                                                                                  |
| :--------- | :------------------------------------------------------------------------------------------------------ |
| Windows    | 7 e superiores                                                                                          |
| macOS      | 10.15 e superiores                                                                                      |
| Linux      | webkit2gtk 4.0 para o Tauri v1 (por exemplo Ubuntu 18.04). webkit2gtk 4.1 para o Tauri v2 (por exemplo Ubuntu 22.04). |
| iOS/iPadOS | 9 e superiores                                                                                          |
| Android    | 7 e superiores (atualmente 8 e superiores)                                                              |

## Contribuindo

Antes de começar a trabalhar em algo, é melhor verificar se já existe uma issue aberta sobre o assunto. Também é uma boa ideia passar no servidor Discord e confirmar com a equipe se faz sentido ou se outra pessoa já está trabalhando nisso.

Por favor, leia o [Guia de Contribuição](./.github/CONTRIBUTING.md) antes de fazer um pull request.

Obrigado a todos que contribuem com o Tauri!

### Documentação

Documentação em um sistema poliglota é uma proposta desafiadora. Por isso, preferimos usar documentação inline no código-fonte Rust & JS sempre que possível. Confira o repositório de hospedagem do site de documentação para mais informações: <https://github.com/tauri-apps/tauri-docs>

## Parceiros

<table>
  <tbody>
    <tr>
      <td align="center" valign="middle">
        <a href="https://crabnebula.dev" target="_blank">
          <img src=".github/sponsors/crabnebula.svg" alt="CrabNebula" width="283">
        </a>
      </td>
    </tr>
  </tbody>
</table>

Para a lista completa de patrocinadores, visite nosso [site](https://tauri.app#sponsors) e o [Open Collective](https://opencollective.com/tauri).

## Organização

O Tauri tem como objetivo ser um coletivo sustentável baseado em princípios que orientam [comunidades de software livre e aberto sustentáveis](https://sfosc.org). Para isso, tornou-se um Programa dentro da [Commons Conservancy](https://commonsconservancy.org/), e você pode contribuir financeiramente via [Open Collective](https://opencollective.com/tauri).

## Licenças

Código: (c) 2015 - Presente - O Programa Tauri dentro da Commons Conservancy.

MIT ou MIT/Apache 2.0 onde aplicável.

Logo: CC-BY-NC-ND

- Designs originais do logo Tauri por [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) e [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---