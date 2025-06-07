<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack Logo" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopack — это фреймворк для установки и автообновления кроссплатформенных приложений. Он имеет собственное мнение, невероятно прост в использовании и не требует конфигурации. Всего одной командой вы получаете готовое к установке приложение, а для ваших пользователей это также очень быстро.

## Возможности

- 😍 **Нулевая конфигурация** — Velopack берёт результат сборки вашего проекта и за одну команду генерирует установщик, обновления, дельта-пакеты и самобновляемый портативный пакет.
- 🎯 **Кроссплатформенность** — Velopack поддерживает создание пакетов для **Windows**, **OSX** и **Linux**, позволяя использовать одно решение для всех целей.
- 🚀 **Автоматическая миграция** — Если вы переходите с других популярных фреймворков (например, [Squirrel](https://github.com/Squirrel/Squirrel.Windows)), Velopack может автоматически мигрировать ваше приложение.
- ⚡️ **Молниеносная скорость** — Velopack написан на Rust для нативной производительности. Дельта-пакеты означают, что пользователь скачивает только то, что изменилось между версиями.
- 📔 **Языковая независимость** — Поддержка C#, C++, JS, Rust и других языков. Используйте знакомый API для обновлений независимо от языка вашего проекта.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Документация
- 📖 [Читать документацию](https://docs.velopack.io/)
- ⚡ [Руководства для быстрого старта](https://docs.velopack.io/category/quick-start)
- 🕶️ [Посмотреть примеры приложений](https://docs.velopack.io/category/sample-apps)
- 📺 [Сайт и демонстрация](https://velopack.io/)

## Сообщество
- ❓ Задавайте вопросы, получайте поддержку и обсуждайте идеи на [Discord](https://discord.gg/CjrCrNzd3F)
- 🗣️ Сообщайте об ошибках и предлагайте улучшения на [GitHub Issues](https://github.com/velopack/velopack/issues)

## Вклад в проект
- 💬 Присоединяйтесь к обсуждениям на [Discord](https://discord.gg/CjrCrNzd3F)
- 🚦 Прочитайте наше [руководство для контрибьюторов](https://docs.velopack.io/category/contributing)

## Отзывы
Теперь моё внешнее приложение использует Velopack. Я очень впечатлён. Всё работает просто отлично и гораздо быстрее как при первоначальной сборке, так и при обновлении программного обеспечения на конечном компьютере пользователя, чем это было с Squirrel. Это удивительно и лучший установщик, который я использовал за 30 лет разработки. Огромное спасибо! Вы делаете отличную работу!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Хочу сказать огромное спасибо. Я использовал Clowd.Squirrel пару лет, после того как Squirrel.Windows перестал для меня работать. Сегодня зашёл в тот репозиторий за документацией и заметил релиз Velopack. Какой сюрприз! Всё работает прекрасно и намного быстрее, вау! Спасибо ещё раз, объём работы, вложенной в Clowd.Squirrel и Velopack, поражает. Очень ценю это.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Я использовал много фреймворков для установщиков, и Velopack — безусловно лучший. Всё похоже на магию: запускаешь установщик, и приложение тут же открывается, готово к использованию. Обновления применяются и перезапускаются примерно за 2 секунды без запросов UAC. Процесс создания установщика прост и легко интегрируется с подписанием кода, а инструмент командной строки упрощает загрузку файлов обновлений. Не нужно возиться с отдельными скриптами установщика на каком-то странном языке; все хуки можно добавить прямо в ваше основное приложение! Поддержка тоже потрясающая; на все мои вопросы был получен ответ. Это будущее десктопных установщиков.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Я чрезвычайно впечатлён производительностью Velopack при создании релизов, а также при проверке и установке обновлений. Это значительно быстрее других инструментов. CLI vpk интуитивно понятен и легко внедряется, даже в мой сложный процесс сборки. Благодаря Velopack я смог оптимизировать рабочий процесс и сэкономить ценное время. Это фантастический инструмент, который я настоятельно рекомендую!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)


---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---