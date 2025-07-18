<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### C.O.R.E: Ваш цифровой мозг для эры искусственного интеллекта

<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Документация</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🧠 C.O.R.E.

**Contextual Observation & Recall Engine**

C.O.R.E — это переносимый граф памяти, построенный на основе ваших взаимодействий с LLM и личных данных, делающий весь ваш контекст и историю рабочих процессов доступными для любого AI-инструмента — как цифровой мозг. Это избавляет от необходимости повторно передавать один и тот же контекст. Цель — предоставить:

- **Унифицированная, переносимая память**: Добавляйте и вспоминайте контекст без усилий, объединяйте свою память между такими приложениями, как Claude, Cursor, Windsurf и другими.
- **Реляционные связи, а не только факты**: CORE организует ваши знания, сохраняя как факты, так и их отношения для создания более глубокой и богатой памяти, как в настоящем мозге.
- **Пользовательское владение**: Вы решаете, что хранить, обновлять или удалять, и делитесь своей памятью между нужными инструментами, избавляясь от привязки к поставщику.

## 🎥 Демонстрационное видео

[Посмотреть демо C.O.R.E](https://youtu.be/iANZ32dnK60)

<img width="954" height="700" alt="Core dashboard" src="https://github.com/user-attachments/assets/d684b708-6907-47be-9499-a30b25434694" />

## 🧩  Ключевые возможности

- **Граф памяти**: Визуализируйте, как связаны ваши факты и предпочтения
- **Чат с памятью**: Задавайте вопросы о памяти для мгновенного получения информации и понимания
- **Plug n Play**: Мгновенно используйте память CORE в таких приложениях, как Cursor, Claude

## ☁️ Установка C.O.R.E в облаке

1. Зарегистрируйтесь на [Core Cloud](https://core.heysol.ai) и начните строить свой граф памяти.
2. Добавьте свой текст, который вы хотите сохранить в памяти. После нажатия на кнопку `+ Add` ваш граф памяти будет сгенерирован.
3. [Подключите Core Memory MCP к Cursor](#connecting-core-mcp-with-cursor)

## 💻 Локальная установка C.O.R.E

#### Необходимые компоненты

1. Docker
2. Ключ API OpenAI


> **Примечание:** Мы активно работаем над улучшением поддержки моделей Llama. В данный момент C.O.R.E не обеспечивает оптимальных результатов с моделями на базе Llama, но мы стремимся обеспечить лучшую совместимость и качество работы в ближайшем будущем.
> 
#### Запуск C.O.R.E локально

1. **Скопируйте переменные среды**

   Скопируйте пример файла переменных среды в `.env`:


   ```bash
   cp .env.example .env
   ```
2. **Запустите приложение**

   Используйте Docker Compose для запуска всех необходимых сервисов:


   ```bash
   docker-compose up
   ```
3. **Доступ к приложению**

   После запуска контейнеров откройте браузер и перейдите по адресу [http://localhost:3000](http://localhost:3000).

4. **Создание аккаунта с помощью Magic Link**

   - Чтобы создать аккаунт, нажмите кнопку `Continue with email`

     <img width="865" height="490" alt="Создать аккаунт" src="https://github.com/user-attachments/assets/65de110b-2b1f-42a5-9b8a-954227d68d52" />

   - Введите свой email и нажмите кнопку `Send a Magic Link`

     <img width="824" height="429" alt="Введите email" src="https://github.com/user-attachments/assets/76128b61-2086-48df-8332-38c2efa14087" />

   - `Скопируйте magic link из логов терминала` и откройте его в браузере

     <img width="1010" height="597" alt="Magic link" src="https://github.com/user-attachments/assets/777cb4b1-bb93-4d54-b6ab-f7147e65aa5c" />


5. **Создайте свое приватное пространство и добавьте данные**

   - На панели управления перейдите в правый верхний угол -> Введите сообщение, например, `Я люблю играть в бадминтон`, и нажмите `+Add`.
   - Ваша память поставлена в очередь на обработку; статус можно отслеживать в разделе `Logs`.
     
     <img width="1496" height="691" alt="Core memory logs" src="https://github.com/user-attachments/assets/dc34a7af-fe52-4142-9ecb-49ddc4e0e854" />

   - После завершения обработки узлы будут добавлены в ваш приватный граф знаний и отображены на панели управления.
   - Позже вы сможете подключить эту память к другим инструментам или оставить ее приватной.

6. **Поиск по вашей памяти**

   - Используйте функцию поиска на панели управления для запросов к вашим данным в приватном пространстве.


## Подключение CORE MCP к Cursor

1. Откройте панель CORE и перейдите в раздел API для создания нового API-токена.
2. В Cursor перейдите: Settings → Tools & Integrations → New MCP Server.
3. Добавьте сервер CORE MCP, используя приведенный ниже формат конфигурации. Не забудьте заменить значение API_TOKEN на токен, созданный на шаге 1.

   Конфигурация MCP для добавления в Cursor


   ```json
   {
     "mcpServers": {
       "memory": {
         "command": "npx",
         "args": ["-y", "@redplanethq/core-mcp"],
         "env": {
           "API_TOKEN": "YOUR_API_TOKEN_HERE",
           "API_BASE_URL": "https://core.heysol.ai",
           "SOURCE": "cursor"
         }
       }
     }
   }
   ```
4. Перейдите в Настройки -> Пользовательские правила -> Новое правило -> и добавьте следующее правило, чтобы все ваши чат-взаимодействия сохранялись в памяти CORE


```
After every interaction, update the memory with the user's query and the assistant's
response to core-memory mcp. sessionId should be the uuid of the conversation
```
## Документация

Изучите нашу документацию, чтобы получить максимум от CORE
- [Базовые концепции](https://docs.heysol.ai/core/overview)
- [Справочник API](https://docs.heysol.ai/core/local-setup)
- [Подключение Core Memory MCP к Cursor](#connecting-core-mcp-with-cursor)


## 🧑‍💻 Поддержка
Есть вопросы или отзывы? Мы готовы помочь:
- Discord: [Присоединиться к каналу core-support](https://discord.gg/YGUZcvDjUa)
- Документация: [docs.heysol.ai/core](https://docs.heysol.ai/core/overview)
- Email: manik@poozle.dev

## Руководство по использованию

**Хранить:**

- Историю переписки
- Пользовательские настройки
- Контекст задач
- Справочные материалы

**Не хранить:**

- Конфиденциальные данные (PII)
- Учетные данные
- Системные логи
- Временные данные

## 👥 Участники

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---