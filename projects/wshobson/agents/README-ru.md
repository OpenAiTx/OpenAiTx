<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Коллекция подагентов Claude Code

Обширная коллекция специализированных ИИ-подагентов для [Claude Code](https://docs.anthropic.com/en/docs/claude-code), созданная для повышения эффективности рабочих процессов разработки с учетом специфики предметной области.

## Обзор

Этот репозиторий содержит 76 специализированных подагентов, расширяющих возможности Claude Code. Каждый подагент является экспертом в определенной области и вызывается автоматически в зависимости от контекста или вручную по необходимости. Все агенты настроены на использование конкретных моделей Claude в зависимости от сложности задачи для оптимальной производительности и экономичности.

## Доступные подагенты

### Разработка и архитектура
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - Проектирует RESTful API, границы микросервисов и схемы баз данных
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Создаёт React-компоненты, реализует адаптивные макеты и управляет состоянием на стороне клиента
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - Создаёт дизайн интерфейсов, wireframe-макеты и дизайн-системы
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - Проверяет, достигли ли изменения в UI поставленных целей, используя тщательный анализ скриншотов
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - Разрабатывает приложения на React Native или Flutter с интеграцией нативных функций
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - Проектирует схемы GraphQL, резолверы и федерацию
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - Проводит ревью изменений кода на соответствие архитектурным принципам и шаблонам

### Специалисты по языкам программирования
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - Пишет идиоматичный Python-код с применением продвинутых функций и оптимизаций
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - Пишет идиоматичный Ruby-код с метапрограммированием, шаблонами Rails, разработкой gem-ов и тестированием
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - Пишет идиоматичный Go-код с использованием горутин, каналов и интерфейсов
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - Пишет идиоматичный Rust с паттернами владения, временем жизни и реализацией traits
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - Пишет эффективный C-код с правильным управлением памятью и системными вызовами
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - Пишет идиоматичный C++-код с современными возможностями, RAII, умными указателями и алгоритмами STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - Осваивает современный JavaScript с ES6+, асинхронными паттернами и API Node.js
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - Осваивает TypeScript с продвинутыми типами, дженериками и строгой типизацией
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - Пишет идиоматичный PHP-код с современными возможностями и оптимизацией производительности
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - Осваивает современный Java с потоками, параллелизмом и оптимизацией JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - Пишет идиоматичный Elixir-код с шаблонами OTP, функциональным программированием и фреймворком Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - Пишет современный C#-код с продвинутыми возможностями и оптимизацией .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - Осваивает промышленную разработку на Scala с функциональным программированием, распределёнными системами и обработкой больших данных
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Осваивает разработку на Flutter с использованием Dart, виджетов и интеграции с платформами
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - Создаёт игры на Unity с оптимизированными скриптами и настройкой производительности
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Осваивает разработку плагинов для серверов Minecraft с использованием Bukkit, Spigot и Paper API
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Разрабатывает нативные приложения для iOS на Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - Пишет сложные SQL-запросы, оптимизирует планы выполнения и проектирует нормализованные схемы

### Инфраструктура и эксплуатация
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - Отлаживает проблемы в продакшене, анализирует логи и устраняет ошибки развертывания
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - Настраивает CI/CD-пайплайны, контейнеры Docker и облачные развертывания
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - Проектирует инфраструктуру AWS/Azure/GCP и оптимизирует затраты на облако
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - Проектирует гибридную облачную инфраструктуру на базе AWS/Azure/GCP и OpenStack в локальных средах
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - Проектирует облачно-нативную инфраструктуру на базе Kubernetes и принципов GitOps для AWS/Azure/GCP и гибридных сред.
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - Оптимизирует SQL-запросы, проектирует эффективные индексы и проводит миграции баз данных
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - Управляет базами данных: резервное копирование, репликация и мониторинг
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - Пишет продвинутые модули Terraform, управляет файлами состояния и реализует лучшие практики IaC
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - Оперативно и точно реагирует на инциденты в продакшене
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** – Отладка сетевой связности, настройка балансировщиков нагрузки и анализ трафика
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** – Специалист по опыту разработчика, улучшает инструменты, настройку и рабочие процессы

### Качество и Безопасность
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** – Эксперт по ревью кода с акцентом на безопасность конфигурации и надежность в продакшене
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** – Проверяет код на уязвимости и обеспечивает соответствие стандарту OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** – Создает комплексные тестовые пакеты: юнит, интеграционные и e2e тесты
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** – Профилирует приложения, оптимизирует узкие места и внедряет стратегии кэширования
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** – Специалист по отладке ошибок, сбоям тестов и неожиданному поведению
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** – Ищет ошибки в логах и кодовой базе, анализирует стек-трейсы и аномалии
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** – Эксперт по веб-исследованиям с использованием продвинутых техник поиска и синтеза

### Данные и ИИ
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** – Эксперт по анализу данных: SQL-запросы, операции BigQuery и аналитика
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** – Создает ETL-пайплайны, хранилища данных и стриминговые архитектуры
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** – Разрабатывает приложения LLM, системы RAG и пайплайны подсказок
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** – Реализует ML-процессы, сервисы моделей и инженеринг признаков
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** – Создает ML-процессы, отслеживание экспериментов и реестры моделей
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** – Оптимизирует подсказки для LLM и ИИ-систем

### Специализированные Области
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** – Создает спецификации OpenAPI/Swagger и пишет документацию для разработчиков
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** – Интегрирует Stripe, PayPal и другие платежные системы
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** – Создает финансовые модели, тестирует торговые стратегии и анализирует рыночные данные
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** – Мониторит риски портфеля, R-множители и лимиты позиций
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** – Рефакторинг устаревших кодовых баз и постепенная модернизация
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** – Управляет контекстом между агентами и длительными задачами

### Документация
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** – Создает комплексную техническую документацию на основе существующего кода
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** – Создает диаграммы Mermaid для блок-схем, последовательностей, ERD и архитектур
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** – Создает исчерпывающие технические справочники и API-документацию
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** – Создает пошаговые руководства и обучающие материалы на основе кода

### Бизнес и Маркетинг
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** – Анализирует метрики, составляет отчеты и отслеживает KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** – Пишет статьи в блог, контент для соцсетей и email-рассылки
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** – Партнер по найму, адаптации/увольнению, отпускам, эффективности, политикам и отношениям с сотрудниками.
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** – Готовит шаблоны холодных писем, фоллоу-апов и коммерческих предложений
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** – Обрабатывает заявки поддержки, отвечает на FAQ и письма клиентов
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - Составляет политики конфиденциальности, условия использования, отказы от ответственности и юридические уведомления

### SEO и оптимизация контента
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - Анализирует предоставленный контент на качество, сигналы E-E-A-T и лучшие практики SEO
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - Создаёт оптимизированные мета-заголовки, описания и рекомендации по URL
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - Анализирует использование ключевых слов, рассчитывает плотность, предлагает семантические вариации
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - Оптимизирует структуру контента, иерархию заголовков и разметку схемы
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - Форматирует контент для избранных сниппетов и функций SERP
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - Определяет устаревшие элементы и предлагает обновления контента
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - Анализирует несколько страниц на совпадение и конфликт ключевых слов
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - Анализирует контент на сигналы E-E-A-T и индикаторы доверия
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - Пишет SEO-оптимизированный контент по ключевым словам и техническим заданиям
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - Создаёт структуры контента, тематические кластеры и календари

## Назначение моделей

Все 76 субагентов настроены на использование определённых моделей Claude в зависимости от сложности задачи:

### 🚀 Haiku (Быстро и экономично) - 15 агентов
**Модель:** `haiku`
- `data-scientist` - SQL-запросы и анализ данных
- `api-documenter` - Документация OpenAPI/Swagger
- `reference-builder` - Подробные технические справочники и API-документация
- `business-analyst` - Отслеживание метрик и KPI
- `content-marketer` - Блог-посты и социальные сети
- `customer-support` - Техподдержка и ответы на частые вопросы
- `sales-automator` - Холодные письма и коммерческие предложения
- `search-specialist` - Веб-исследования и сбор информации
- `legal-advisor` - Политики конфиденциальности и документы по соответствию
- `seo-meta-optimizer` - Оптимизация мета-заголовков и описаний
- `seo-keyword-strategist` - Анализ плотности и семантики ключевых слов
- `seo-structure-architect` - Структура контента и разметка схемы
- `seo-snippet-hunter` - Форматирование для избранных сниппетов
- `seo-content-refresher` - Обновление свежести контента
- `seo-cannibalization-detector` - Обнаружение пересечений по ключевым словам
- `seo-content-planner` - Контент-календари и структуры

### ⚡ Sonnet (Сбалансированная производительность) - 45 агентов
**Модель:** `sonnet`

**Разработка и языки программирования:**
- `python-pro` - Разработка на Python с расширенными возможностями
- `ruby-pro` - Разработка на Ruby с метапрограммированием, паттернами Rails и созданием gem
- `javascript-pro` - Современный JavaScript и Node.js
- `typescript-pro` - Продвинутый TypeScript с типовыми системами
- `golang-pro` - Параллелизм и идиоматические паттерны Go
- `rust-pro` - Безопасность памяти и системное программирование на Rust
- `c-pro` - Программирование на C и встроенные системы
- `cpp-pro` - Современный C++ с STL и шаблонами
- `php-pro` - Современный PHP с расширенными возможностями
- `java-pro` - Современный Java с потоками и параллелизмом
- `elixir-pro` - Elixir с паттернами OTP и Phoenix
- `csharp-pro` - Современный C# с .NET фреймворками и паттернами
- `scala-pro` - Корпоративный Scala с Apache Pekko, Akka, Spark, и ZIO/Cats Effect
- `flutter-expert` - Разработка на Flutter с управлением состоянием и анимациями
- `unity-developer` - Разработка и оптимизация игр на Unity
- `minecraft-bukkit-pro` - Разработка плагинов Minecraft с Bukkit/Spigot/Paper
- `ios-developer` - Нативная разработка iOS на Swift/SwiftUI
- `frontend-developer` - Компоненты React и пользовательский интерфейс
- `ui-ux-designer` - Дизайн интерфейса и wireframes
- `ui-visual-validator` - Тщательная визуальная проверка UI через анализ скриншотов
- `backend-architect` - Проектирование API и микросервисов
- `mobile-developer` - Приложения на React Native/Flutter
- `sql-pro` - Оптимизация сложных SQL запросов
- `graphql-architect` - Схемы и резолверы GraphQL

**Инфраструктура и операции:**
- `devops-troubleshooter` - Отладка продакшна
- `deployment-engineer` - CI/CD пайплайны
- `database-optimizer` - Оптимизация запросов
- `database-admin` - Операции с базами данных
- `terraform-specialist` - Инфраструктура как код
- `network-engineer` - Конфигурация сети
- `dx-optimizer` - Оптимизация разработческого опыта
- `data-engineer` - ETL пайплайны

**Качество и поддержка:**
- `test-automator` - Создание тестовых наборов
- `code-reviewer` - Анализ качества кода
- `debugger` - Исследование ошибок
- `error-detective` - анализ логов
- `ml-engineer` - деплой моделей машинного обучения
- `legacy-modernizer` - миграция с устаревших фреймворков
- `payment-integration` - обработка платежей
- `mermaid-expert` - диаграммы Mermaid и визуальная документация
- `flutter-expert` - разработка на Flutter
- `seo-content-auditor` - аудит качества контента и анализ E-E-A-T
- `seo-authority-builder` - оптимизация сигналов авторитетности
- `seo-content-writer` - создание SEO-оптимизированного контента

### 🧠 Opus (Максимальные возможности) - 15 агентов
**Модель:** `opus`
- `ai-engineer` - LLM-приложения и RAG-системы
- `security-auditor` - анализ уязвимостей
- `performance-engineer` - оптимизация приложений
- `incident-responder` - обработка инцидентов в продакшене
- `mlops-engineer` - инфраструктура для ML
- `architect-reviewer` - архитектурная целостность
- `cloud-architect` - проектирование облачной инфраструктуры
- `prompt-engineer` - оптимизация prompt'ов для LLM
- `context-manager` - координация мультиагентных систем
- `quant-analyst` - финансовое моделирование
- `risk-manager` - управление рисками портфеля
- `docs-architect` - комплексная техническая документация по кодовой базе
- `tutorial-engineer` - пошаговые руководства и обучающий контент

## Установка

Эти субагенты автоматически доступны при размещении в директории `~/.claude/agents/`.

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## Использование

### Автоматический вызов
Claude Code автоматически делегирует задачу соответствующему субагенту в зависимости от контекста задачи и описания субагента.

### Явный вызов
Упомяните субагента по имени в вашем запросе:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## Примеры использования

### Задачи для одного агента
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```

### Многоагентные рабочие процессы

Эти субагенты работают вместе без сбоев, а для более сложных оркестраций вы можете использовать коллекцию **[Claude Code Commands](https://github.com/wshobson/commands)**, которая предоставляет 52 предустановленные слэш-команды, использующие этих субагентов в сложных рабочих процессах.

```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### Продвинутые рабочие процессы с Slash-командами

Для более сложной оркестрации с несколькими субагентами используйте сопутствующий [репозиторий Commands](https://github.com/wshobson/commands):

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## Формат субагента

Каждый субагент следует этой структуре:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### Конфигурация модели

Начиная с Claude Code v1.0.64, субагенты могут указывать, какую модель Claude им следует использовать. Это позволяет эффективно делегировать задачи с учетом их сложности и стоимости:

- **Низкая сложность (Haiku)**: Простые задачи, такие как базовый анализ данных, генерация документации и стандартные ответы
- **Средняя сложность (Sonnet)**: Задачи разработки, ревью кода, тестирование и обычная инженерная работа  
- **Высокая сложность (Opus)**: Критические задачи, такие как аудит безопасности, ревью архитектуры, реагирование на инциденты и инженерия ИИ/МО

Доступные модели (упрощенные названия с Claude Code v1.0.64):
- `haiku` – Быстрая и экономичная для простых задач
- `sonnet` – Сбалансированная производительность для большинства задач разработки
- `opus` – Наиболее способная для сложного анализа и критических задач

Если модель не указана, субагент использует модель по умолчанию системы.

## Шаблоны оркестрации агентов

Claude Code автоматически координирует агентов, используя эти распространенные шаблоны:

### Последовательные рабочие процессы
```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### Условное ветвление
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### Проверка и подтверждение
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```

## Когда использовать какого агента

### 🏗️ Планирование и архитектура
- **backend-architect**: Проектирование API, схемы баз данных, системная архитектура
- **frontend-developer**: Планирование UI/UX, архитектура компонентов
- **ui-ux-designer**: Дизайн интерфейса, вайрфреймы, дизайн-системы, исследование пользователей
- **cloud-architect**: Проектирование инфраструктуры, планирование масштабируемости

### 🔧 Реализация и разработка  
- **python-pro**: Задачи по разработке на Python
- **ruby-pro**: Метапрограммирование Ruby, приложения на Rails, разработка гемов, тестирование RSpec/Minitest
- **golang-pro**: Задачи по разработке на Go
- **rust-pro**: Разработка на Rust, безопасность памяти, системное программирование
- **c-pro**: Программирование на C, встроенные системы, производительно-критичный код
- **javascript-pro**: Современный JavaScript, асинхронные паттерны, код для Node.js/браузера
- **typescript-pro**: Продвинутый TypeScript, дженерики, вывод типов, корпоративные паттерны
- **java-pro**: Современная разработка на Java, стримы, конкурентность, Spring Boot
- **elixir-pro**: Разработка на Elixir, паттерны OTP, фреймворки Phoenix, функциональное программирование
- **csharp-pro**: Современная разработка на C#, фреймворки .NET, корпоративные паттерны
- **scala-pro**: Корпоративная Scala с функциональным программированием, акторы Apache Pekko/Akka, Apache Spark, ZIO/Cats Effect, реактивные архитектуры
- **flutter-expert**: Разработка на Flutter, Dart, управление состоянием, анимации, кроссплатформенное развертывание
- **unity-developer**: Разработка игр на Unity, скрипты на C#, оптимизация производительности
- **minecraft-bukkit-pro**: Разработка плагинов Minecraft, системы событий, серверные функции
- **ios-developer**: Нативная разработка iOS на Swift/SwiftUI
- **sql-pro**: Запросы к базам данных, проектирование схем, оптимизация запросов
- **mobile-developer**: Разработка на React Native/Flutter

### 🛠️ Операции и обслуживание
- **devops-troubleshooter**: Производственные проблемы, сбои при развертывании
- **incident-responder**: Критические сбои, требующие немедленного реагирования
- **database-optimizer**: Производительность запросов, стратегии индексации
- **database-admin**: Стратегии резервного копирования, репликация, управление пользователями, восстановление после сбоев
- **terraform-specialist**: Инфраструктура как код, модули Terraform, управление состоянием
- **network-engineer**: Сетевое подключение, балансировщики нагрузки, SSL/TLS, отладка DNS

### 📊 Анализ и оптимизация
- **performance-engineer**: Узкие места приложения, оптимизация
- **security-auditor**: Сканирование уязвимостей, проверка на соответствие требованиям
- **data-scientist**: Анализ данных, получение инсайтов, отчеты
- **mlops-инженер**: ML-инфраструктура, отслеживание экспериментов, реестры моделей, автоматизация конвейеров

### 🧪 Контроль качества
- **ревьюер-кода**: Качество кода, безопасность конфигураций, надежность в продакшене
- **автоматизатор-тестов**: Стратегия тестирования, создание набора тестов
- **отладчик**: Исследование багов, устранение ошибок
- **детектив-ошибок**: Анализ логов, распознавание паттернов ошибок, анализ первопричин
- **специалист-по-поиску**: Глубокий веб-поиск, конкурентный анализ, проверка фактов

### 📚 Документация
- **документатор-api**: OpenAPI/Swagger спецификации, документация по API
- **архитектор-документов**: Всесторонняя техническая документация, архитектурные гайды, системные руководства
- **создатель-референсов**: Полные справочники по API, руководства по конфигурации, описание параметров
- **инженер-обучения**: Пошаговые туториалы, обучающие курсы, образовательный контент

### 💼 Бизнес и стратегия
- **бизнес-аналитик**: KPI, модели дохода, прогнозы роста, метрики для инвесторов
- **менеджер-рисков**: Риски портфеля, стратегии хеджирования, R-мультипликаторы, определение размера позиции
- **контент-маркетолог**: SEO-контент, блог-посты, социальные сети, email-кампании
- **автоматизатор-продаж**: Холодные письма, последующие обращения, предложения, взращивание лидов
- **поддержка-клиентов**: Тикеты поддержки, FAQ, справочная документация, устранение проблем
- **юридический-консультант** - Составление политики конфиденциальности, условий использования, отказов от ответственности и юридических уведомлений

## Лучшие практики

### 🎯 Делегирование задач
1. **Позвольте Claude Code делегировать автоматически** — основной агент анализирует контекст и выбирает оптимальных агентов
2. **Будьте конкретны в требованиях** — включайте ограничения, стек технологий и требования к качеству
3. **Доверьтесь экспертизе агентов** — каждый агент оптимизирован под свою область

### 🔄 Мультиагентские рабочие процессы
4. **Начинайте с высокоуровневых запросов** — пусть агенты координируют сложные многошаговые задачи
5. **Передавайте контекст между агентами** — убедитесь, что агенты имеют всю необходимую информацию
6. **Проверяйте точки интеграции** — смотрите, как результаты разных агентов работают вместе

### 🎛️ Явный контроль
7. **Используйте явное вызовы для специфических нужд** — когда нужен взгляд конкретного эксперта
8. **Стратегически комбинируйте нескольких агентов** — разные специалисты могут проверять работу друг друга
9. **Запрашивайте конкретные схемы ревью** — «Пусть security-auditor проверит API-дизайн backend-architect»

### 📈 Оптимизация
10. **Отслеживайте эффективность агентов** — Узнайте, какие агенты лучше всего подходят для ваших задач
11. **Итерация сложных задач** — Используйте обратную связь от агента для уточнения требований
12. **Используйте сильные стороны агентов** — Соотносите сложность задачи с возможностями агента

## Внесение изменений

Чтобы добавить нового субагента:
1. Создайте новый файл `.md`, следуя приведённому выше формату
2. Используйте имена в нижнем регистре, разделённые дефисами
3. Дайте чёткое описание, когда следует использовать субагента
4. Включите конкретные инструкции в системную подсказку

## Устранение неполадок

### Распространённые проблемы

**Агент не вызывается автоматически:**
- Убедитесь, что ваш запрос явно указывает домен (например, "проблема с производительностью" → performance-engineer)
- Будьте конкретны в типе задачи (например, "проверить код" → code-reviewer)

**Неожиданный выбор агента:**
- Предоставьте больше информации о вашем техническом стеке и требованиях
- Используйте явное указание, если нужен конкретный агент

**Несколько агентов дают противоречивые советы:**
- Это нормально — у разных специалистов могут быть разные приоритеты
- Попросите разъяснить: "Согласуйте рекомендации security-auditor и performance-engineer"

**Агенту не хватает контекста:**
- Предоставьте в запросе дополнительную информацию
- Сошлитесь на предыдущие беседы или устоявшиеся шаблоны

### Получение помощи

Если агенты работают не так, как ожидалось:
1. Проверьте описания агентов в их индивидуальных файлах
2. Попробуйте использовать более конкретные формулировки в запросах
3. Используйте явное указание для тестирования конкретных агентов
4. Предоставьте больше информации о вашем проекте и целях

## Лицензия

Этот проект лицензирован по лицензии MIT - подробности смотрите в файле [LICENSE](LICENSE).

## Узнать больше

- [Документация Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Документация Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code на GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---