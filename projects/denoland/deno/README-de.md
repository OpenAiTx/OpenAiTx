# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="das Deno Maskottchen Dinosaurier steht im Regen">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), ausgesprochen
`dee-no`) ist eine JavaScript-, TypeScript- und WebAssembly-Laufzeitumgebung mit sicheren Voreinstellungen und einer großartigen Entwicklererfahrung. Es basiert auf [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) und [Tokio](https://tokio.rs/).

Erfahren Sie mehr über die Deno-Laufzeitumgebung
[in der Dokumentation](https://docs.deno.com/runtime/manual).

## Installation

Installieren Sie die Deno-Laufzeitumgebung auf Ihrem System mit einem der folgenden Befehle. Beachten Sie, dass es verschiedene Möglichkeiten gibt, Deno zu installieren – eine umfassende Liste der Installationsoptionen finden Sie
[hier](https://docs.deno.com/runtime/manual/getting_started/installation).

Shell (Mac, Linux):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows):

```powershell
winget install --id=DenoLand.Deno
```

### Aus dem Quellcode bauen und installieren

Vollständige Anweisungen zum Bauen von Deno aus dem Quellcode finden Sie
[hier](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Ihr erstes Deno-Programm

Deno kann für viele verschiedene Anwendungen genutzt werden, wird aber am häufigsten zum Erstellen von Webservern verwendet. Erstellen Sie eine Datei namens `server.ts` und fügen Sie folgenden TypeScript-Code ein:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Starten Sie Ihren Server mit folgendem Befehl:

```sh
deno run --allow-net server.ts
```

Dadurch wird ein lokaler Webserver unter
[http://localhost:8000](http://localhost:8000) gestartet.

Erfahren Sie mehr über das Schreiben und Ausführen von Deno-Programmen
[in der Dokumentation](https://docs.deno.com/runtime/manual).

## Weitere Ressourcen

- **[Deno Docs](https://docs.deno.com)**: Offizielle Anleitungen und Referenzdokumente für die Deno-Laufzeitumgebung, [Deno Deploy](https://deno.com/deploy) und mehr.
- **[Deno Standardbibliothek](https://jsr.io/@std)**: Offiziell unterstützte, allgemeine Hilfsprogramme für Deno-Programme.
- **[JSR](https://jsr.io/)**: Das Open-Source-Paketregister für modernes JavaScript und TypeScript.
- **[Developer Blog](https://deno.com/blog)**: Produktneuigkeiten, Tutorials und mehr vom Deno-Team.

## Beitrag leisten

Wir schätzen Ihre Hilfe! Um einen Beitrag zu leisten, lesen Sie bitte unsere
[Beitragsanweisungen](.github/CONTRIBUTING.md).

[Build status - Cirrus]: https://github.com/denoland/deno/workflows/ci/badge.svg?branch=main&event=push
[Build status]: https://github.com/denoland/deno/actions
[Twitter badge]: https://img.shields.io/twitter/follow/deno_land.svg?style=social&label=Follow
[Twitter link]: https://twitter.com/intent/follow?screen_name=deno_land
[Bluesky badge]: https://img.shields.io/badge/Follow-whitesmoke?logo=bluesky
[Bluesky link]: https://bsky.app/profile/deno.land
[YouTube badge]: https://img.shields.io/youtube/channel/subscribers/UCqC2G2M-rg4fzg1esKFLFIw?style=social
[YouTube link]: https://www.youtube.com/@deno_land
[Discord badge]: https://img.shields.io/discord/684898665143206084?logo=discord&style=social
[Discord link]: https://discord.gg/deno

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---