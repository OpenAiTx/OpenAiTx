# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="la mascotte di deno, un dinosauro, sotto la pioggia">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), pronunciato
`dee-no`) è un runtime per JavaScript, TypeScript e WebAssembly con impostazioni di sicurezza predefinite e un'eccellente esperienza per gli sviluppatori. È costruito su [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) e [Tokio](https://tokio.rs/).

Scopri di più sul runtime Deno
[nella documentazione](https://docs.deno.com/runtime/manual).

## Installazione

Installa il runtime Deno sul tuo sistema utilizzando uno dei comandi qui sotto. Nota
che esistono diversi modi per installare Deno: una lista completa delle opzioni di installazione è disponibile
[qui](https://docs.deno.com/runtime/manual/getting_started/installation).

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

### Compilare e installare dal sorgente

Le istruzioni complete per compilare Deno dal sorgente sono disponibili
[qui](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Il tuo primo programma Deno

Deno può essere utilizzato per molte applicazioni diverse, ma viene più comunemente usato per
costruire web server. Crea un file chiamato `server.ts` e inserisci il seguente
codice TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Esegui il tuo server con il seguente comando:

```sh
deno run --allow-net server.ts
```

Questo avvierà un server web locale su
[http://localhost:8000](http://localhost:8000).

Scopri di più su come scrivere ed eseguire programmi Deno
[nella documentazione](https://docs.deno.com/runtime/manual).

## Risorse aggiuntive

- **[Deno Docs](https://docs.deno.com)**: guide ufficiali e documentazione di riferimento per
  il runtime Deno, [Deno Deploy](https://deno.com/deploy), e altro ancora.
- **[Deno Standard Library](https://jsr.io/@std)**: utilità comuni ufficialmente supportate
  per programmi Deno.
- **[JSR](https://jsr.io/)**: Il registro di pacchetti open-source per JavaScript e TypeScript moderni
- **[Developer Blog](https://deno.com/blog)**: Aggiornamenti sul prodotto, tutorial e
  altro dal team Deno.

## Contribuire

Apprezziamo il tuo aiuto! Per contribuire, leggi le nostre
[istruzioni per i contributori](.github/CONTRIBUTING.md).

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