![note-gen](https://socialify.git.ci/codexu/note-gen/image?custom_description=Cross-Platform+%7C+LLM+%7C+Markdown+%7C++Recording++%26+Writing&description=1&font=Raleway&forks=1&issues=1&logo=https%3A%2F%2Fcamo.githubusercontent.com%2Fbe4a3a39f8724658ad5bc549d63f0454ad4ca98564c73b7b0778704ca5212509%2F68747470733a2f2f73322e6c6f6c692e6e65742f323032352f30352f32362f594d4e67784b5644724238345a74572e706e67&name=1&owner=1&pattern=Circuit+Board&stargazers=1&theme=Light)

# NoteGen

![](https://github.com/codexu/note-gen/actions/workflows/release.yml/badge.svg?branch=release)
![](https://img.shields.io/github/v/release/codexu/note-gen)
![](https://img.shields.io/badge/version-alpha-orange)
![](https://img.shields.io/github/downloads/codexu/note-gen/total)
![](https://img.shields.io/github/commit-activity/m/codexu/note-gen)

English | [简体中文](.github/README.zh.md) | [日本語](.github/README.ja.md) | **Русский**

<div style="display: flex; gap: 1rem;">
  <a href="https://www.producthunt.com/products/notegen-2?embed=true&utm_source=badge-featured&utm_medium=badge&utm_source=badge-notegen&#0045;2" target="_blank"><img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=956348&theme=light&t=1749194675492" alt="NoteGen - A&#0032;cross&#0045;platform&#0032;Markdown&#0032;note&#0045;taking&#0032;application | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" /></a>

  <a href="https://trendshift.io/repositories/12784" target="_blank"><img src="https://trendshift.io/api/badge/repositories/12784" alt="codexu%2Fnote-gen | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>
</div>

## Руководство

NoteGen — это кроссплатформенное приложение для заметок в формате `Markdown`, предназначенное для использования ИИ для объединения записи и написания, организации фрагментированных знаний в читаемую заметку.

🖥️ Официальная документация: [https://notegen.top](https://notegen.top)

💬 Присоединяйтесь к [группе WeChat/QQ](https://github.com/codexu/note-gen/discussions/110)

## Почему выбирают NoteGen?

- Легковесность: [Установочный пакет](https://github.com/codexu/note-gen/releases) всего **20MB**, бесплатен, без рекламы и стороннего ПО.
- Кроссплатформенность: поддерживаются Mac, Windows, Linux, а благодаря возможностям `Tauri2` в будущем будет поддержка iOS и Android.
- Поддержка различных способов записи, включая `скриншоты`, `текст`, `иллюстрации`, `файлы`, `ссылки` и др., отвечая на потребности фрагментированной записи в разных сценариях.
- Родной формат хранения `Markdown(.md)`, без изменений, простая миграция.
- Полноценная офлайн-работа, поддержка синхронизации в реальном времени с `GitHub, Gitee приватными репозиториями` с откатом истории, а также синхронизация через WebDAV.
- Усилено ИИ: настраивается с помощью ChatGPT, Gemini, Ollama, LM Studio, Grok и других моделей, поддержка кастомных сторонних моделей.
- RAG: ваши заметки — ваша база знаний. Поддержка моделей встраивания и reranking-моделей.

## Скриншоты

https://github.com/user-attachments/assets/4f8a3bc5-17f5-4b36-9b17-d87128685257

Запись:

![1.png](https://s2.loli.net/2025/05/19/Cs5viKfkqb2HJmd.png)

Написание:

![2.png](https://s2.loli.net/2025/05/19/5vwQBPoLr6jzgUA.png)

Тема:

![3.png](https://s2.loli.net/2025/05/19/8yU72prmWdsCHeu.png)

## От записи к написанию

Обычные приложения для заметок, как правило, не предоставляют функции записи. Пользователям приходится вручную копировать и вставлять контент для записи, что значительно снижает эффективность. При наличии разрозненного записанного контента требуется значительное время на его организацию.

NoteGen разделён на страницы `Запись` и `Написание`, между которыми существует следующая связь:

- Записи можно организовывать в заметки и переносить на страницу написания для глубокого изложения.
- В процессе написания можно в любой момент вставлять записи.

### Запись

Функция записи похожа на **AI-чатбота**, но при общении с ним вы можете связывать записи с уже сохранённым контентом, переключаясь из режима беседы в режим организации для структурирования записей в читаемую заметку.

Следующие вспомогательные функции помогут вам эффективнее вести записи:

- **Теги** для различения разных сценариев записи.
- **Персоны** с поддержкой кастомных подсказок для точного управления вашим AI-ассистентом.
- **Ассистент буфера обмена**, который автоматически распознаёт текст или изображения в буфере обмена и добавляет их в ваш список.

### Написание

Раздел написания состоит из двух частей: **Файловый менеджер** и **Markdown-редактор**.

**Файловый менеджер**

- Поддержка управления локальными Markdown-файлами и синхронизированными с GitHub файлами.
- Неограниченная вложенность директорий.
- Несколько вариантов сортировки.

**Markdown-редактор**

- Поддержка WYSIWYG, мгновенного рендеринга и режима предпросмотра на разделённом экране.
- Контроль версий с возможностью отката истории.
- AI-ассистент для диалога, продолжения текста, доработки и перевода.
- Хостинг изображений: загрузка изображений с преобразованием в Markdown-ссылки.
- Конвертация HTML в Markdown: автоматическое преобразование скопированного браузерного контента в Markdown.
- Поддержка оглавления, математических формул, интеллект-карт, графиков, блок-схем, диаграмм Ганта, последовательных диаграмм, нотного стана, мультимедиа, голосового чтения, якорей для заголовков, подсветки и копирования кода, рендеринга graphviz, диаграмм plantuml UML.
- Реальное локальное сохранение контента, отложенная (10 секунд без редактирования) автоматическая синхронизация и откат истории.

## Другие функции

- Глобальный поиск для быстрого поиска и перехода к нужному контенту.
- Управление хостингом изображений для удобного контроля за репозиторием изображений.
- Темы и внешний вид: поддержка тёмной темы и настроек оформления для Markdown, кода и пр.
- Интернационализация: поддержка русского, китайского и английского языков.

## Как использовать?

### Скачать

В настоящее время поддерживаются Mac, Windows и Linux. Благодаря возможностям Tauri2 в будущем появится поддержка iOS и Android.

[Скачать NoteGen (alpha)](https://github.com/codexu/note-gen/releases)

### Расширение

Приложение для заметок можно использовать сразу без какой-либо настройки. Для расширенных возможностей откройте страницу настроек и настройте AI и синхронизацию.

## Вклад

- [Прочитать руководство по вкладу](https://raw.githubusercontent.com/codexu/note-gen/dev/.github/CONTRIBUTING.md)
- [Планы обновлений](https://github.com/codexu/note-gen/issues/46)
- [Сообщить об ошибках или предложениях по улучшению](https://github.com/codexu/note-gen/issues)
- [Обсуждения](https://github.com/codexu/note-gen/discussions)

## Участники

<a href="https://github.com/codexu/note-gen/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=codexu/note-gen" />
</a>

## История звёзд

[![Star History Chart](https://api.star-history.com/svg?repos=codexu/note-gen&type=Date)](https://www.star-history.com/#codexu/note-gen&Date)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---