<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Introduction

Tauri est un framework pour construire de petits binaires ultra-rapides pour toutes les principales plateformes de bureau. Les développeurs peuvent intégrer n'importe quel framework front-end qui compile en HTML, JS et CSS pour créer leur interface utilisateur. Le backend de l'application est un binaire écrit en Rust avec une API avec laquelle le front-end peut interagir.

L'interface utilisateur dans les applications Tauri s'appuie actuellement sur [`tao`](https://docs.rs/tao) comme bibliothèque de gestion de fenêtres sur macOS, Windows, Linux, Android et iOS. Pour afficher votre application, Tauri utilise [WRY](https://github.com/tauri-apps/wry), une bibliothèque qui fournit une interface unifiée au webview système, s'appuyant sur WKWebView sur macOS & iOS, WebView2 sur Windows, WebKitGTK sur Linux et Android System WebView sur Android.

Pour en savoir plus sur la façon dont toutes ces pièces s'assemblent, veuillez consulter ce document [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md).

## Pour commencer

Si vous souhaitez créer une application Tauri, veuillez visiter le [site de documentation](https://tauri.app).

Le moyen le plus rapide de commencer est d'installer les [prérequis](https://v2.tauri.app/start/prerequisites/) pour votre système et de créer un nouveau projet avec [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Par exemple avec `npm` :

```sh
npm create tauri-app@latest
```

## Fonctionnalités

La liste des fonctionnalités de Tauri inclut, mais sans s'y limiter :

- Un empaqueteur d'applications intégré pour créer des bundles dans des formats tels que `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` et des installateurs Windows comme `.exe` (via NSIS) et `.msi` (via WiX).
- Mise à jour automatique intégrée (bureau uniquement)
- Icônes dans la barre système (system tray)
- Notifications natives
- Protocole WebView natif (Tauri ne crée pas de serveur http(s) localhost pour servir le contenu du WebView)
- Action GitHub pour l'intégration continue (CI) simplifiée
- Extension VS Code

### Plateformes

Tauri prend actuellement en charge le développement et la distribution sur les plateformes suivantes :

| Plateforme   | Versions                                                                                                         |
| :----------- | :-------------------------------------------------------------------------------------------------------------- |
| Windows      | 7 et supérieur                                                                                                  |
| macOS        | 10.15 et supérieur                                                                                              |
| Linux        | webkit2gtk 4.0 pour Tauri v1 (par exemple Ubuntu 18.04). webkit2gtk 4.1 pour Tauri v2 (par exemple Ubuntu 22.04). |
| iOS/iPadOS   | 9 et supérieur                                                                                                  |
| Android      | 7 et supérieur (actuellement 8 et supérieur)                                                                    |

## Contribution

Avant de commencer à travailler sur quelque chose, il est préférable de vérifier s'il existe déjà un ticket à ce sujet. Il est également conseillé de passer sur le serveur Discord et de confirmer avec l'équipe si cela a du sens ou si quelqu'un d'autre y travaille déjà.

Veuillez vous assurer de lire le [guide de contribution](./.github/CONTRIBUTING.md) avant de faire une pull request.

Merci à tous ceux qui contribuent à Tauri !

### Documentation

La documentation dans un système polyglotte est une proposition délicate. À cette fin, nous préférons utiliser autant que possible la documentation en ligne dans le code source Rust & JS. Consultez le dépôt d'hébergement du site de documentation pour plus d'informations : <https://github.com/tauri-apps/tauri-docs>

## Partenaires

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

Pour la liste complète des sponsors, veuillez visiter notre [site web](https://tauri.app#sponsors) et [Open Collective](https://opencollective.com/tauri).

## Organisation

Tauri vise à être un collectif durable basé sur des principes qui guident les [communautés de logiciels libres et open source durables](https://sfosc.org). À cette fin, il est devenu un programme au sein de la [Commons Conservancy](https://commonsconservancy.org/), et vous pouvez contribuer financièrement via [Open Collective](https://opencollective.com/tauri).

## Licences

Code : (c) 2015 - Présent - Le programme Tauri au sein de The Commons Conservancy.

MIT ou MIT/Apache 2.0 là où applicable.

Logo : CC-BY-NC-ND

- Conceptions originales du logo Tauri par [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) et [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)


---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---