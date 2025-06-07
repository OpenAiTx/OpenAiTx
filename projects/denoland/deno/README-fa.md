# دنو

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[دنو](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A)، تلفظ
`دی-نو`) یک محیط اجرای جاوااسکریپت، تایپ‌اسکریپت و WebAssembly با پیش‌فرض‌های امنیتی و تجربه توسعه‌دهنده عالی است. این محیط بر پایه [V8](https://v8.dev/)،
[Rust](https://www.rust-lang.org/) و [Tokio](https://tokio.rs/) ساخته شده است.

برای کسب اطلاعات بیشتر درباره محیط اجرای دنو به
[مستندات](https://docs.deno.com/runtime/manual) مراجعه کنید.

## نصب

برای نصب محیط اجرای دنو روی سیستم خود از یکی از دستورهای زیر استفاده کنید. توجه داشته باشید که روش‌های مختلفی برای نصب دنو وجود دارد. فهرست کامل گزینه‌های نصب را می‌توانید
[اینجا](https://docs.deno.com/runtime/manual/getting_started/installation) بیابید.

شل (مک، لینوکس):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

پاورشل (ویندوز):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (مک):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (ویندوز):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (ویندوز):

```powershell
winget install --id=DenoLand.Deno
```

### ساخت و نصب از سورس

دستورالعمل کامل برای ساخت دنو از سورس را می‌توانید
[اینجا](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source) پیدا کنید.

## اولین برنامه دنو شما

دنو می‌تواند برای کاربردهای مختلفی استفاده شود اما عمدتاً برای ساخت سرورهای وب استفاده می‌شود. یک فایل به نام `server.ts` ایجاد کرده و کد تایپ‌اسکریپت زیر را در آن قرار دهید:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

سرور خود را با دستور زیر اجرا کنید:

```sh
deno run --allow-net server.ts
```

این دستور باید یک سرور وب محلی در
[http://localhost:8000](http://localhost:8000)
راه‌اندازی کند.

برای یادگیری بیشتر در مورد نوشتن و اجرای برنامه‌های دنو
[به مستندات مراجعه کنید](https://docs.deno.com/runtime/manual).

## منابع بیشتر

- **[مستندات دنو](https://docs.deno.com)**: راهنماها و مستندات مرجع رسمی برای محیط اجرای دنو، [Deno Deploy](https://deno.com/deploy) و موارد دیگر.
- **[کتابخانه استاندارد دنو](https://jsr.io/@std)**: ابزارهای رایج و پشتیبانی‌شده رسمی برای برنامه‌های دنو.
- **[JSR](https://jsr.io/)**: رجیستری بسته متن‌باز برای جاوااسکریپت و تایپ‌اسکریپت مدرن.
- **[وبلاگ توسعه‌دهندگان](https://deno.com/blog)**: به‌روزرسانی‌های محصول، آموزش‌ها و مطالب بیشتر از تیم دنو.

## مشارکت

ما از کمک شما استقبال می‌کنیم! برای مشارکت، لطفاً
[دستورالعمل مشارکت](.github/CONTRIBUTING.md)
ما را مطالعه کنید.

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