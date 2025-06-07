# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="de deno mascotte dinosaurus die in de regen staat">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), uitgesproken als
`dee-no`) is een JavaScript-, TypeScript- en WebAssembly-runtime met veilige
standaardinstellingen en een uitstekende ontwikkelaarservaring. Het is gebouwd op [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) en [Tokio](https://tokio.rs/).

Leer meer over de Deno-runtime
[in de documentatie](https://docs.deno.com/runtime/manual).

## Installatie

Installeer de Deno-runtime op uw systeem met een van de onderstaande commando's. Merk op
dat er verschillende manieren zijn om Deno te installeren – een uitgebreide lijst van
installatie-opties is te vinden
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

### Bouwen en installeren vanuit broncode

Volledige instructies voor het bouwen van Deno vanuit de broncode zijn te vinden
[hier](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Uw eerste Deno-programma

Deno kan voor veel verschillende toepassingen worden gebruikt, maar wordt het vaakst gebruikt om
webservers te bouwen. Maak een bestand genaamd `server.ts` en voeg de volgende
TypeScript-code toe:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Voer uw server uit met het volgende commando:

```sh
deno run --allow-net server.ts
```

Dit zou een lokale webserver moeten starten op
[http://localhost:8000](http://localhost:8000).

Leer meer over het schrijven en uitvoeren van Deno-programma’s
[in de documentatie](https://docs.deno.com/runtime/manual).

## Aanvullende bronnen

- **[Deno Docs](https://docs.deno.com)**: officiële handleidingen en referentiedocumentatie voor
  de Deno-runtime, [Deno Deploy](https://deno.com/deploy), en meer.
- **[Deno Standaardbibliotheek](https://jsr.io/@std)**: officieel ondersteunde algemene
  hulpmiddelen voor Deno-programma’s.
- **[JSR](https://jsr.io/)**: Het open-source pakketregister voor moderne
  JavaScript en TypeScript.
- **[Developer Blog](https://deno.com/blog)**: Productupdates, tutorials en
  meer van het Deno-team.

## Bijdragen

Wij waarderen uw hulp! Lees onze
[instructies voor bijdragen](.github/CONTRIBUTING.md) om bij te dragen.

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