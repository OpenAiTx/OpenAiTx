# دينو

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="ديناصور دينو يقف تحت المطر">

[دينـو](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A)، تُنطق
`دي-نو`) هو بيئة تشغيل لـ JavaScript وTypeScript وWebAssembly مع إعدادات أمان افتراضية وتجربة تطوير رائعة. تم بناؤه باستخدام [V8](https://v8.dev/)، و[Rust](https://www.rust-lang.org/)، و[Tokio](https://tokio.rs/).

تعرّف أكثر على بيئة تشغيل دينو
[في الوثائق](https://docs.deno.com/runtime/manual).

## التثبيت

قم بتثبيت بيئة تشغيل دينو على نظامك باستخدام أحد الأوامر التالية. لاحظ
أن هناك عدة طرق لتثبيت دينو – يمكن العثور على قائمة شاملة بخيارات التثبيت
[هنا](https://docs.deno.com/runtime/manual/getting_started/installation).

شل (ماك، لينكس):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (ويندوز):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (ماك):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (ويندوز):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (ويندوز):

```powershell
winget install --id=DenoLand.Deno
```

### البناء والتثبيت من المصدر

يمكنك العثور على تعليمات كاملة لبناء دينو من المصدر
[هنا](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## أول برنامج لك باستخدام دينو

يمكن استخدام دينو في العديد من التطبيقات المختلفة، لكن الاستخدام الأكثر شيوعًا هو
بناء خوادم الويب. أنشئ ملفًا باسم `server.ts` وأضف الكود التالي بلغة TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

شغّل الخادم باستخدام الأمر التالي:

```sh
deno run --allow-net server.ts
```

يجب أن يبدأ هذا خادم ويب محلي على
[http://localhost:8000](http://localhost:8000).

تعرّف أكثر على كتابة وتشغيل برامج دينو
[في الوثائق](https://docs.deno.com/runtime/manual).

## مصادر إضافية

- **[وثائق دينو](https://docs.deno.com)**: أدلة رسمية ومرجعية لبيئة تشغيل دينو، و[Deno Deploy](https://deno.com/deploy)، وأكثر.
- **[مكتبة دينو القياسية](https://jsr.io/@std)**: أدوات مساعدة شائعة مدعومة رسميًا لبرامج دينو.
- **[JSR](https://jsr.io/)**: سجل الحزم مفتوح المصدر لجافاسكريبت وTypeScript الحديثة.
- **[مدونة المطورين](https://deno.com/blog)**: تحديثات المنتج، دروس تعليمية، والمزيد من فريق دينو.

## المساهمة

نقدّر مساعدتك! للمساهمة، يُرجى قراءة
[تعليمات المساهمة](.github/CONTRIBUTING.md).

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