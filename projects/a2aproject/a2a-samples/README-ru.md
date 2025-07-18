# Примеры Agent2Agent (A2A)

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
      | <a href="https://openaitx.github.io/view.html?user=a2aproject&project=a2a-samples&lang=id">Bahasa Indonesia</a>
    </div>
  </details>
</div>

Этот репозиторий содержит примеры кода и демонстрации, использующие [протокол Agent2Agent (A2A)](https://goo.gle/a2a).

## Связанные репозитории

- [A2A](https://github.com/a2aproject/A2A) — спецификация и документация A2A.
- [a2a-python](https://github.com/a2aproject/a2a-python) — Python SDK для A2A.
- [a2a-inspector](https://github.com/a2aproject/a2a-inspector) — UI-инструмент для инспектирования агентов с поддержкой A2A.

## Вклад в проект

Вклады приветствуются! См. [руководство по вкладу](https://raw.githubusercontent.com/a2aproject/a2a-samples/main/CONTRIBUTING.md).

## Получение помощи

Пожалуйста, используйте [страницу с вопросами](https://github.com/a2aproject/a2a-samples/issues), чтобы оставить предложения, отзыв или сообщить об ошибке.

## Отказ от ответственности

Сам по себе этот репозиторий не является официально поддерживаемым продуктом Google. Код в этом репозитории предназначен только для демонстрационных целей.

Важно: предоставленный пример кода предназначен для демонстрации и иллюстрирует механику протокола Agent-to-Agent (A2A). При создании производственных приложений крайне важно рассматривать любого агента, находящегося вне вашего прямого контроля, как потенциально ненадежный объект.

Все данные, полученные от внешнего агента, включая, но не ограничиваясь AgentCard, сообщениями, артефактами и статусами задач, должны рассматриваться как ненадежный ввод. Например, вредоносный агент может предоставить AgentCard с поддельными данными в его полях (например, описание, имя, skills.description). Если эти данные будут использованы без фильтрации для создания подсказок для большой языковой модели (LLM), это может подвергнуть ваше приложение атаке через внедрение подсказок. Несоблюдение проверки и фильтрации этих данных перед использованием может привести к уязвимостям в безопасности вашего приложения.

Разработчики несут ответственность за внедрение соответствующих мер безопасности, таких как валидация ввода и безопасное обращение с учетными данными для защиты своих систем и пользователей.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---