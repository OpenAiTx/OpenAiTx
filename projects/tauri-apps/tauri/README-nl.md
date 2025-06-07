<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stable-blue.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![License](https://img.shields.io/badge/License-MIT%20or%20Apache%202-green.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-purple.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blue.svg)](https://opencollective.com/tauri)

## Introductie

Tauri is een framework voor het bouwen van kleine, razendsnelle binaries voor alle grote desktopplatforms. Ontwikkelaars kunnen elk front-end framework integreren dat compileert naar HTML, JS en CSS voor het bouwen van hun gebruikersinterface. De backend van de applicatie is een door Rust gegenereerde binary met een API waarmee de front-end kan communiceren.

De gebruikersinterface in Tauri-apps maakt momenteel gebruik van [`tao`](https://docs.rs/tao) als window handling library op macOS, Windows, Linux, Android en iOS. Voor het renderen van je applicatie gebruikt Tauri [WRY](https://github.com/tauri-apps/wry), een bibliotheek die een uniforme interface biedt naar de systeem-webview, en gebruikt WKWebView op macOS & iOS, WebView2 op Windows, WebKitGTK op Linux en Android System WebView op Android.

Wil je meer weten over hoe al deze onderdelen samenwerken, raadpleeg dan dit [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md) document.

## Aan de slag

Als je geïnteresseerd bent in het maken van een Tauri-app, bezoek dan de [documentatie-website](https://tauri.app).

De snelste manier om te beginnen is het installeren van de [vereisten](https://v2.tauri.app/start/prerequisites/) voor je systeem en het aanmaken van een nieuw project met [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage). Bijvoorbeeld met `npm`:

```sh
npm create tauri-app@latest
```

## Functionaliteiten

De lijst met Tauri-functies omvat, maar is niet beperkt tot:

- Ingebouwde app-bundelaar om appbundels te maken in formaten zoals `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` en Windows-installers zoals `.exe` (via NSIS) en `.msi` (via WiX).
- Ingebouwde automatische updater (alleen desktop)
- Systeemvakpictogrammen
- Native notificaties
- Native WebView Protocol (tauri creëert geen localhost http(s)-server om de WebView-inhoud te serveren)
- GitHub-acties voor gestroomlijnde CI
- VS Code-extensie

### Platforms

Tauri ondersteunt momenteel ontwikkeling en distributie op de volgende platforms:

| Platform   | Versies                                                                                                        |
| :--------- | :------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 en hoger                                                                                                     |
| macOS      | 10.15 en hoger                                                                                                |
| Linux      | webkit2gtk 4.0 voor Tauri v1 (bijvoorbeeld Ubuntu 18.04). webkit2gtk 4.1 voor Tauri v2 (bijvoorbeeld Ubuntu 22.04). |
| iOS/iPadOS | 9 en hoger                                                                                                     |
| Android    | 7 en hoger (momenteel 8 en hoger)                                                                              |

## Bijdragen

Voordat je aan iets gaat werken, is het verstandig eerst te controleren of er al een bestaand issue is. Het is ook een goed idee om even langs te gaan op de Discord-server en te overleggen met het team of het zinvol is, of dat iemand anders er al aan werkt.

Lees alsjeblieft de [Contributing Guide](./.github/CONTRIBUTING.md) voordat je een pull request maakt.

Dank aan iedereen die bijdraagt aan Tauri!

### Documentatie

Documentatie in een polyglot systeem is een lastige aangelegenheid. Daarom geven we er de voorkeur aan zoveel mogelijk inline documentatie te gebruiken in de Rust- en JS-broncode. Bekijk de repository voor de documentatiesite voor meer informatie: <https://github.com/tauri-apps/tauri-docs>

## Partners

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

Voor de volledige lijst met sponsors bezoek onze [website](https://tauri.app#sponsors) en [Open Collective](https://opencollective.com/tauri).

## Organisatie

Tauri streeft ernaar een duurzaam collectief te zijn, gebaseerd op principes die [duurzame vrije en open softwaregemeenschappen](https://sfosc.org) leiden. Om deze reden is het een programma geworden binnen de [Commons Conservancy](https://commonsconservancy.org/), en kun je financieel bijdragen via [Open Collective](https://opencollective.com/tauri).

## Licenties

Code: (c) 2015 - heden - Het Tauri Programma binnen The Commons Conservancy.

MIT of MIT/Apache 2.0 waar van toepassing.

Logo: CC-BY-NC-ND

- Originele Tauri-logo ontwerpen door [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) en [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---