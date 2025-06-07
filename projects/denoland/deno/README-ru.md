# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="талисман динозавра Deno, стоящий под дождём">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), произносится
`ди-но`) — это среда выполнения JavaScript, TypeScript и WebAssembly с безопасными
настройками по умолчанию и отличным опытом для разработчиков. Основана на [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/) и [Tokio](https://tokio.rs/).

Узнайте больше о среде выполнения Deno
[в документации](https://docs.deno.com/runtime/manual).

## Установка

Установите среду выполнения Deno на свою систему с помощью одной из команд ниже. Обратите внимание, что существует несколько способов установки Deno — полный список вариантов установки доступен
[здесь](https://docs.deno.com/runtime/manual/getting_started/installation).

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

### Сборка и установка из исходников

Полные инструкции по сборке Deno из исходников можно найти
[здесь](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Ваша первая программа на Deno

Deno может использоваться для различных приложений, но чаще всего применяется для
создания веб-серверов. Создайте файл с названием `server.ts` и добавьте следующий
код на TypeScript:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Запустите ваш сервер следующей командой:

```sh
deno run --allow-net server.ts
```

Это запустит локальный веб-сервер по адресу
[http://localhost:8000](http://localhost:8000).

Узнайте больше о написании и запуске программ на Deno
[в документации](https://docs.deno.com/runtime/manual).

## Дополнительные ресурсы

- **[Документация Deno](https://docs.deno.com)**: официальные руководства и справочные материалы по
  среде выполнения Deno, [Deno Deploy](https://deno.com/deploy) и не только.
- **[Стандартная библиотека Deno](https://jsr.io/@std)**: официально поддерживаемые общие
  утилиты для программ на Deno.
- **[JSR](https://jsr.io/)**: Реестр open-source пакетов для современного
  JavaScript и TypeScript.
- **[Блог разработчиков](https://deno.com/blog)**: Новости о продукте, обучающие материалы и
  многое другое от команды Deno.

## Вклад в проект

Мы ценим вашу помощь! Чтобы внести вклад, пожалуйста, ознакомьтесь с нашими
[инструкциями по участию](.github/CONTRIBUTING.md).

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