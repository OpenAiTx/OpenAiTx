# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="yağmurda duran deno maskotu dinozor">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), telaffuz
`dee-no`) güvenli varsayılanlar ve harika bir geliştirici deneyimi sunan bir JavaScript, TypeScript ve WebAssembly çalışma zamanıdır. [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) ve [Tokio](https://tokio.rs/) üzerine kuruludur.

Deno çalışma zamanı hakkında daha fazla bilgiyi
[dökümantasyonda](https://docs.deno.com/runtime/manual) bulabilirsiniz.

## Kurulum

Aşağıdaki komutlardan birini kullanarak sisteminize Deno çalışma zamanını kurun. Deno'yu kurmanın birçok yolu olduğunu unutmayın - kapsamlı kurulum seçenekleri listesini
[burada](https://docs.deno.com/runtime/manual/getting_started/installation) bulabilirsiniz.

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

### Kaynaktan derleyip kurma

Deno'yu kaynaktan derleme ile ilgili tüm talimatlara
[buradan](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source) ulaşabilirsiniz.

## İlk Deno programınız

Deno birçok farklı uygulama için kullanılabilir, ancak en yaygın olarak web sunucuları oluşturmak için kullanılır. `server.ts` adında bir dosya oluşturun ve aşağıdaki TypeScript kodunu ekleyin:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Sunucunuzu aşağıdaki komutla çalıştırın:

```sh
deno run --allow-net server.ts
```

Bu, yerel bir web sunucusunu
[http://localhost:8000](http://localhost:8000) adresinde başlatmalıdır.

Deno programları yazma ve çalıştırma hakkında daha fazla bilgiyi
[dökümantasyonda](https://docs.deno.com/runtime/manual) bulabilirsiniz.

## Ek kaynaklar

- **[Deno Dokümantasyonu](https://docs.deno.com)**: Deno çalışma zamanı, [Deno Deploy](https://deno.com/deploy) ve daha fazlası için resmi rehberler ve referans dokümanlar.
- **[Deno Standart Kütüphanesi](https://jsr.io/@std)**: Deno programları için resmi olarak desteklenen genel yardımcı araçlar.
- **[JSR](https://jsr.io/)**: Modern JavaScript ve TypeScript için açık kaynak paket kaydı
- **[Geliştirici Blogu](https://deno.com/blog)**: Deno ekibinden ürün güncellemeleri, eğitimler ve daha fazlası.

## Katkıda Bulunma

Yardımınızı takdir ediyoruz! Katkıda bulunmak için lütfen
[katkı talimatlarımızı](.github/CONTRIBUTING.md) okuyun.

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