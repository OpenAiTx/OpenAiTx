# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), อ่านว่า
`ดี-โน`) คือรันไทม์สำหรับ JavaScript, TypeScript และ WebAssembly ที่มีค่าเริ่มต้นความปลอดภัยสูงและประสบการณ์ที่ดีสำหรับนักพัฒนา พัฒนาบนพื้นฐานของ [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) และ [Tokio](https://tokio.rs/)

เรียนรู้เพิ่มเติมเกี่ยวกับ Deno runtime
[ในเอกสารประกอบ](https://docs.deno.com/runtime/manual)

## การติดตั้ง

ติดตั้ง Deno runtime บนระบบของคุณโดยใช้คำสั่งใดคำสั่งหนึ่งด้านล่าง โปรดทราบว่ามีหลายวิธีในการติดตั้ง Deno - คุณสามารถดูรายการตัวเลือกทั้งหมดได้
[ที่นี่](https://docs.deno.com/runtime/manual/getting_started/installation)

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

### การคอมไพล์และติดตั้งจากซอร์ส

คำแนะนำแบบสมบูรณ์สำหรับการคอมไพล์ Deno จากซอร์ส สามารถดูได้
[ที่นี่](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source)

## โปรแกรม Deno แรกของคุณ

Deno สามารถใช้งานได้หลากหลายรูปแบบ แต่โดยทั่วไปนิยมใช้สร้างเว็บเซิร์ฟเวอร์ สร้างไฟล์ชื่อ `server.ts` และเพิ่มโค้ด TypeScript ดังนี้:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

รันเซิร์ฟเวอร์ของคุณด้วยคำสั่งนี้:

```sh
deno run --allow-net server.ts
```

คำสั่งนี้จะเริ่มต้นเว็บเซิร์ฟเวอร์บนเครื่องที่
[http://localhost:8000](http://localhost:8000)

เรียนรู้เพิ่มเติมเกี่ยวกับการเขียนและรันโปรแกรม Deno
[ในเอกสาร](https://docs.deno.com/runtime/manual)

## แหล่งข้อมูลเพิ่มเติม

- **[Deno Docs](https://docs.deno.com)**: คู่มือและเอกสารอ้างอิงอย่างเป็นทางการสำหรับ Deno runtime, [Deno Deploy](https://deno.com/deploy) และอื่นๆ
- **[Deno Standard Library](https://jsr.io/@std)**: ยูทิลิตี้มาตรฐานที่ได้รับการสนับสนุนอย่างเป็นทางการสำหรับโปรแกรม Deno
- **[JSR](https://jsr.io/)**: รีจิสทรีแพ็กเกจโอเพ่นซอร์สสำหรับ JavaScript และ TypeScript สมัยใหม่
- **[Developer Blog](https://deno.com/blog)**: อัปเดตผลิตภัณฑ์, บทแนะนำ, และข่าวสารจากทีม Deno

## การมีส่วนร่วม

เรายินดีรับความช่วยเหลือจากคุณ! หากต้องการร่วมพัฒนา กรุณาอ่าน
[คำแนะนำการมีส่วนร่วม](.github/CONTRIBUTING.md)

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