<img src=".github/splash.png" alt="Tauri" />

[![status](https://img.shields.io/badge/status-stabil-blau.svg)](https://github.com/tauri-apps/tauri/tree/dev)
[![Lizenz](https://img.shields.io/badge/License-MIT%20oder%20Apache%202-grün.svg)](https://opencollective.com/tauri)
[![test core](https://img.shields.io/github/actions/workflow/status/tauri-apps/tauri/test-core.yml?label=test%20core&logo=github)](https://github.com/tauri-apps/tauri/actions/workflows/test-core.yml)
[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=shield)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_shield)
[![Chat Server](https://img.shields.io/badge/chat-discord-7289da.svg)](https://discord.gg/SpmNs4S)
[![website](https://img.shields.io/badge/website-tauri.app-lila.svg)](https://tauri.app)
[![https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg](https://good-labs.github.io/greater-good-affirmation/assets/images/badge.svg)](https://good-labs.github.io/greater-good-affirmation)
[![support](https://img.shields.io/badge/sponsor-Open%20Collective-blau.svg)](https://opencollective.com/tauri)

## Einführung

Tauri ist ein Framework zum Erstellen winziger, blitzschneller Binärdateien für alle großen Desktop-Plattformen. Entwickler können jedes Frontend-Framework integrieren, das zu HTML, JS und CSS kompiliert, um ihre Benutzeroberfläche zu erstellen. Das Backend der Anwendung ist eine in Rust geschriebene Binärdatei mit einer API, mit der das Frontend interagieren kann.

Die Benutzeroberfläche in Tauri-Apps nutzt derzeit [`tao`](https://docs.rs/tao) als Fensterverwaltungslibrary unter macOS, Windows, Linux, Android und iOS. Zum Rendern der Anwendung verwendet Tauri [WRY](https://github.com/tauri-apps/wry), eine Bibliothek, die eine einheitliche Schnittstelle zum systemeigenen WebView bereitstellt. Dabei werden WKWebView auf macOS & iOS, WebView2 auf Windows, WebKitGTK auf Linux und Android System WebView auf Android verwendet.

Um mehr über die Details und das Zusammenspiel aller Komponenten zu erfahren, lesen Sie bitte dieses [ARCHITECTURE.md](https://github.com/tauri-apps/tauri/blob/dev/ARCHITECTURE.md)-Dokument.

## Erste Schritte

Wenn Sie daran interessiert sind, eine Tauri-App zu entwickeln, besuchen Sie bitte die [Dokumentations-Website](https://tauri.app).

Der schnellste Weg zum Einstieg ist, die [Voraussetzungen](https://v2.tauri.app/start/prerequisites/) für Ihr System zu installieren und ein neues Projekt mit [`create-tauri-app`](https://github.com/tauri-apps/create-tauri-app/#usage) zu erstellen. Zum Beispiel mit `npm`:

```sh
npm create tauri-app@latest
```

## Funktionen

Die Liste der Tauri-Funktionen umfasst unter anderem:

- Integrierter App-Bundler zum Erstellen von App-Bundles in Formaten wie `.app`, `.dmg`, `.deb`, `.rpm`, `.AppImage` sowie Windows-Installern wie `.exe` (über NSIS) und `.msi` (über WiX).
- Integrierter Auto-Updater (nur Desktop)
- System-Tray-Icons
- Native Benachrichtigungen
- Native WebView-Protokolle (tauri erstellt keinen lokalen http(s)-Server, um die WebView-Inhalte bereitzustellen)
- GitHub Action für optimiertes CI
- VS Code Erweiterung

### Plattformen

Tauri unterstützt derzeit die Entwicklung und Verteilung auf den folgenden Plattformen:

| Plattform  | Versionen                                                                                                        |
| :--------- | :-------------------------------------------------------------------------------------------------------------- |
| Windows    | 7 und höher                                                                                                     |
| macOS      | 10.15 und höher                                                                                                 |
| Linux      | webkit2gtk 4.0 für Tauri v1 (z.B. Ubuntu 18.04). webkit2gtk 4.1 für Tauri v2 (z.B. Ubuntu 22.04).              |
| iOS/iPadOS | 9 und höher                                                                                                     |
| Android    | 7 und höher (derzeit 8 und höher)                                                                               |

## Beitrag leisten

Bevor Sie mit der Arbeit an einem Thema beginnen, sollten Sie zunächst prüfen, ob bereits ein entsprechendes Issue existiert. Es ist auch ratsam, auf dem Discord-Server vorbeizuschauen und mit dem Team abzuklären, ob es sinnvoll ist oder ob bereits jemand daran arbeitet.

Bitte lesen Sie vor dem Erstellen eines Pull Requests den [Beitragsleitfaden](./.github/CONTRIBUTING.md).

Vielen Dank an alle, die zu Tauri beitragen!

### Dokumentation

Dokumentation in einem polyglotten System ist eine Herausforderung. Daher bevorzugen wir es, so viel wie möglich Inline-Dokumentation im Rust- und JS-Quellcode zu nutzen. Weitere Informationen finden Sie im Repository der Dokumentationsseite: <https://github.com/tauri-apps/tauri-docs>

## Partner

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

Die vollständige Liste der Sponsoren finden Sie auf unserer [Website](https://tauri.app#sponsors) und bei [Open Collective](https://opencollective.com/tauri).

## Organisation

Tauri hat das Ziel, ein nachhaltiges Kollektiv zu sein, das sich an Prinzipien für [nachhaltige freie und Open-Source-Software-Gemeinschaften](https://sfosc.org) orientiert. Zu diesem Zweck ist es ein Programm innerhalb der [Commons Conservancy](https://commonsconservancy.org/) geworden, und Sie können finanziell über [Open Collective](https://opencollective.com/tauri) beitragen.

## Lizenzen

Code: (c) 2015 - Gegenwart - Das Tauri-Programm innerhalb der Commons Conservancy.

MIT oder MIT/Apache 2.0, wo zutreffend.

Logo: CC-BY-NC-ND

- Original Tauri Logo-Designs von [Alve Larsson](https://alve.io/), [Daniel Thompson-Yvetot](https://github.com/nothingismagick) und [Guillaume Chau](https://github.com/akryum)

[![FOSSA Status](https://app.fossa.com/api/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri.svg?type=large)](https://app.fossa.com/projects/git%2Bgithub.com%2Ftauri-apps%2Ftauri?ref=badge_large)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---