# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="maskot dinozaura Deno stojący w deszczu">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), wymawiane
`dee-no`) to środowisko uruchomieniowe JavaScript, TypeScript i WebAssembly z bezpiecznymi ustawieniami domyślnymi i świetnym doświadczeniem deweloperskim. Zostało zbudowane na [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) i [Tokio](https://tokio.rs/).

Dowiedz się więcej o środowisku uruchomieniowym Deno
[w dokumentacji](https://docs.deno.com/runtime/manual).

## Instalacja

Zainstaluj środowisko uruchomieniowe Deno na swoim systemie, używając jednej z poniższych komend. Zwróć uwagę, że istnieje wiele sposobów instalacji Deno – pełną listę opcji instalacji znajdziesz
[tutaj](https://docs.deno.com/runtime/manual/getting_started/installation).

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

### Budowanie i instalacja ze źródeł

Pełne instrukcje budowania Deno ze źródeł znajdziesz
[tutaj](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Twój pierwszy program w Deno

Deno może być używany do wielu różnych zastosowań, ale najczęściej służy do tworzenia serwerów internetowych. Utwórz plik o nazwie `server.ts` i umieść w nim następujący kod TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Uruchom swój serwer za pomocą poniższej komendy:

```sh
deno run --allow-net server.ts
```

Powinno to uruchomić lokalny serwer WWW pod adresem
[http://localhost:8000](http://localhost:8000).

Dowiedz się więcej o pisaniu i uruchamianiu programów w Deno
[w dokumentacji](https://docs.deno.com/runtime/manual).

## Dodatkowe zasoby

- **[Deno Docs](https://docs.deno.com)**: oficjalne przewodniki i dokumentacja referencyjna dla środowiska Deno, [Deno Deploy](https://deno.com/deploy) i nie tylko.
- **[Deno Standard Library](https://jsr.io/@std)**: oficjalnie wspierane, popularne narzędzia dla programów Deno.
- **[JSR](https://jsr.io/)**: Otwarta rejestracja pakietów open source dla nowoczesnego JavaScript i TypeScript.
- **[Developer Blog](https://deno.com/blog)**: Nowości produktowe, poradniki i inne informacje od zespołu Deno.

## Współtworzenie

Doceniamy Twoją pomoc! Aby współtworzyć, przeczytaj proszę nasze
[wytyczne dla współtwórców](.github/CONTRIBUTING.md).

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