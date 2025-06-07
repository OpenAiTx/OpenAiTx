# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="maskot dinosaurus deno berdiri di bawah hujan">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), diucapkan
`dee-no`) adalah runtime JavaScript, TypeScript, dan WebAssembly dengan pengaturan default yang aman dan pengalaman pengembang yang luar biasa. Ini dibangun di atas [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/), dan [Tokio](https://tokio.rs/).

Pelajari lebih lanjut tentang runtime Deno
[di dokumentasi](https://docs.deno.com/runtime/manual).

## Instalasi

Pasang runtime Deno di sistem Anda menggunakan salah satu perintah di bawah ini. Perlu dicatat bahwa ada beberapa cara untuk menginstal Deno - daftar lengkap opsi instalasi dapat ditemukan
[di sini](https://docs.deno.com/runtime/manual/getting_started/installation).

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

### Build dan instal dari sumber

Instruksi lengkap untuk membangun Deno dari sumber dapat ditemukan
[di sini](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Program Deno Pertama Anda

Deno dapat digunakan untuk berbagai aplikasi, namun paling umum digunakan untuk membuat web server. Buat file bernama `server.ts` dan masukkan kode TypeScript berikut:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Jalankan server Anda dengan perintah berikut:

```sh
deno run --allow-net server.ts
```

Ini akan memulai web server lokal pada
[http://localhost:8000](http://localhost:8000).

Pelajari lebih lanjut tentang menulis dan menjalankan program Deno
[di dokumentasi](https://docs.deno.com/runtime/manual).

## Sumber daya tambahan

- **[Deno Docs](https://docs.deno.com)**: panduan resmi dan dokumentasi referensi untuk
  runtime Deno, [Deno Deploy](https://deno.com/deploy), dan lainnya.
- **[Deno Standard Library](https://jsr.io/@std)**: utilitas umum yang didukung secara resmi untuk program Deno.
- **[JSR](https://jsr.io/)**: Registri paket open-source untuk JavaScript dan TypeScript modern
- **[Developer Blog](https://deno.com/blog)**: Pembaruan produk, tutorial, dan
  lainnya dari tim Deno.

## Berkontribusi

Kami menghargai bantuan Anda! Untuk berkontribusi, silakan baca
[instruksi kontribusi](.github/CONTRIBUTING.md) kami.

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