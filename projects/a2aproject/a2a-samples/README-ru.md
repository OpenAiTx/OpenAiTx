# Примеры Agent2Agent (A2A)

<a href="https://studio.firebase.google.com/new?template=https%3A%2F%2Fgithub.com%2Fa2aproject%2Fa2a-samples%2Ftree%2Fmain%2F.firebase-studio">
  <picture>
    <source
      media="(prefers-color-scheme: dark)"
      srcset="https://cdn.firebasestudio.dev/btn/try_light_20.svg">
    <source
      media="(prefers-color-scheme: light)"
      srcset="https://cdn.firebasestudio.dev/btn/try_dark_20.svg">
    <img
      height="20"
      alt="Попробовать в Firebase Studio"
      src="https://cdn.firebasestudio.dev/btn/try_blue_20.svg">
  </picture>
</a>

<div style="text-align: right;">
  <details>
    <summary>🌐 Язык</summary>
    <div style="text-align: center;">
      <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=en">English</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-CN">简体中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=zh-TW">繁體中文</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ja">日本語</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ko">한국어</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=hi">हिन्दी</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=th">ไทย</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fr">Français</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=de">Deutsch</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=es">Español</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=it">Italiano</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pt">Português</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=nl">Nederlands</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=pl">Polski</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ar">العربية</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=fa">فارسی</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=tr">Türkçe</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=vi">Tiếng Việt</a>
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=ru">Русский</a>
    </div>
  </details>
</div>

Этот репозиторий содержит примеры кода и демонстрации, использующие [Agent2Agent (A2A) Protocol](https://goo.gle/a2a).

## Связанные репозитории

- [A2A](https://github.com/a2aproject/A2A) — Спецификация и документация A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) — Python SDK для A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) — UI-инструмент для инспекции агентов с поддержкой A2A.

## Вклад

Приветствуются ваши вклады! См. [Руководство по вкладу](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Получение помощи

Пожалуйста, используйте [страницу с проблемами](https://github.com/a2aproject/a2a-samples/issues) для предложений, отзывов или сообщения об ошибке.

## Отказ от ответственности

Этот репозиторий сам по себе не является официально поддерживаемым продуктом Google. Код в данном репозитории предназначен только для демонстрационных целей.

Важно: Приведённый пример кода предназначен для демонстрации и иллюстрирует механику протокола Agent-to-Agent (A2A). При создании рабочих приложений критически важно рассматривать любого агента, работающего вне вашего прямого контроля, как потенциально ненадёжную сущность.

Все данные, полученные от внешнего агента — включая, но не ограничиваясь, его AgentCard, сообщения, артефакты и статусы задач — должны рассматриваться как ненадёжный ввод. Например, вредоносный агент может предоставить AgentCard с поддельными данными в его полях (например, описание, имя, skills.description). Если эти данные используются без фильтрации для создания подсказок для большой языковой модели (LLM), это может подвергнуть ваше приложение атакам с внедрением подсказок. Отсутствие должной проверки и фильтрации этих данных перед использованием может привести к появлению уязвимостей безопасности в вашем приложении.

Разработчики несут ответственность за внедрение соответствующих мер безопасности, таких как валидация ввода и безопасная обработка учетных данных, для защиты своих систем и пользователей.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---