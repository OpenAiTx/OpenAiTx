# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="la mascotte dinosaure de deno debout sous la pluie">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), prononcé
`dee-no`) est un environnement d’exécution JavaScript, TypeScript et WebAssembly avec des paramètres de sécurité par défaut et une excellente expérience développeur. Il est construit sur [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) et [Tokio](https://tokio.rs/).

Pour en savoir plus sur l'environnement d’exécution Deno,
[consultez la documentation](https://docs.deno.com/runtime/manual).

## Installation

Installez l’environnement d’exécution Deno sur votre système en utilisant l’une des commandes ci-dessous. Notez qu’il existe plusieurs méthodes pour installer Deno – une liste complète des options d’installation est disponible
[ici](https://docs.deno.com/runtime/manual/getting_started/installation).

Shell (Mac, Linux) :

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows) :

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac) :

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows) :

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows) :

```powershell
winget install --id=DenoLand.Deno
```

### Compiler et installer depuis les sources

Les instructions complètes pour compiler Deno depuis les sources se trouvent
[ici](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Votre premier programme Deno

Deno peut être utilisé pour de nombreuses applications différentes, mais il est le plus souvent utilisé pour créer des serveurs web. Créez un fichier appelé `server.ts` et ajoutez le code TypeScript suivant :

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Exécutez votre serveur avec la commande suivante :

```sh
deno run --allow-net server.ts
```

Cela devrait lancer un serveur web local sur
[http://localhost:8000](http://localhost:8000).

Pour en savoir plus sur l’écriture et l’exécution de programmes Deno,
[consultez la documentation](https://docs.deno.com/runtime/manual).

## Ressources supplémentaires

- **[Deno Docs](https://docs.deno.com)** : guides officiels et documentation de référence pour l’environnement Deno, [Deno Deploy](https://deno.com/deploy), et plus encore.
- **[Deno Standard Library](https://jsr.io/@std)** : utilitaires communs officiellement pris en charge pour les programmes Deno.
- **[JSR](https://jsr.io/)** : le registre de paquets open source pour JavaScript et TypeScript modernes.
- **[Developer Blog](https://deno.com/blog)** : mises à jour produit, tutoriels et plus encore de l’équipe Deno.

## Contribuer

Nous apprécions votre aide ! Pour contribuer, veuillez lire nos
[instructions de contribution](.github/CONTRIBUTING.md).

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