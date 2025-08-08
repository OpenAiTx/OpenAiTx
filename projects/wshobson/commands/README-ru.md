
<div align="right">
  <details>
    <summary >🌐 Язык</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=commands&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Слэш-команды Claude Code

Готовые к использованию слэш-команды для [Claude Code](https://docs.anthropic.com/en/docs/claude-code), ускоряющие разработку с помощью интеллектуальной автоматизации.

**52 команды** организованы как:
- **🤖 Рабочие процессы**: Мульти-субагентная оркестрация для сложных задач
- **🔧 Инструменты**: Утилиты с одной функцией для конкретных операций

### 🤝 Требуются субагенты Claude Code

Эти команды работают с [субагентами Claude Code](https://github.com/wshobson/agents) для возможностей оркестрации.

## Установка

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Доступные команды

- **🤖 Рабочие процессы** - Оркестрация нескольких подагентов для выполнения сложных задач
- **🔧 Инструменты** - Команды с одной целью для конкретных операций

## Использование

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code автоматически предлагает релевантные команды на основе контекста.

## 🤖 Рабочие процессы

Оркестрация нескольких субагентов для сложных задач:

### Разработка функций
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Субагенты для backend, frontend, тестирования и деплоя создают полноценные функции
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Несколько субагентов рецензирования обеспечивают комплексный анализ кода
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Анализирует проблемы и делегирует их профильным субагентам

### Процессы разработки
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Реализует эффективные Git-процессы с ветвлением и шаблонами PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Повышает производительность субагентов за счет оптимизации промптов
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Модернизирует устаревшие кодовые базы с помощью специализированных субагентов
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Создает ML-конвейеры с субагентами по данным и ML-инженерии
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Создает кроссплатформенные приложения с координацией субагентов
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Автоматизирует процессы CI/CD, мониторинга и деплоя

### Рабочие процессы с субагентами
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Мультиплатформенные функции с backend, frontend и мобильными субагентами
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Реализация с приоритетом безопасности с помощью специализированных субагентов
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ML-функции с субагентами по анализу данных
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Комплексная оптимизация с субагентами по производительности
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Решение инцидентов в продакшене с субагентами для операций

## 🔧 Инструменты (Команды с одной задачей)

### AI и машинное обучение
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Создание готовых к продакшену AI-ассистентов и чат-ботов
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Специализированная ревизия кодовой базы AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Создание агентов LangChain/LangGraph с современными паттернами
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Создание полноценного ML-конвейера с MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Оптимизация AI-промптов для качества и производительности

### Архитектура и качество кода
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Генерация подробных объяснений сложного кода
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Миграция кода между языками, фреймворками или версиями
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Рефакторинг кода для поддержки и производительности
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Анализ и приоритизация технического долга

### Данные и базы данных
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Проектирование масштабируемых архитектур для потоков данных
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Реализация комплексных систем валидации данных
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Продвинутые стратегии миграции баз данных

### DevOps и инфраструктура
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Генерация конфигураций и чек-листов для деплоя
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Продвинутая оптимизация контейнеров
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Деплой Kubernetes уровня продакшена
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Настройка комплексного мониторинга и наблюдаемости
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Реализация целевых показателей уровня сервиса (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Автоматизация процессов разработки и эксплуатации

### Разработка и тестирование
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Создание реалистичных моков API для разработки и тестирования
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Генерация готовых к продакшену API-эндпоинтов с полной реализацией
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Создание комплексных тестовых наборов с определением фреймворка

### Безопасность и соответствие стандартам
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Комплексное тестирование и исправление доступности
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Обеспечение соответствия нормативным требованиям (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Комплексное сканирование безопасности с автоматическим устранением

### Отладка и анализ
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Продвинутые стратегии отладки и трассировки
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Глубокий анализ паттернов ошибок и стратегии решения
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Трассировка и диагностика ошибок в продакшене
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Создание структурированных задач для GitHub/GitLab

### Зависимости и конфигурация
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Валидация и управление конфигурацией приложения
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Аудит зависимостей на безопасность и лицензирование
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Безопасное обновление зависимостей проекта

### Документация и совместная работа
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Генерация комплексной документации
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Реализация эффективных Git-процессов
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Улучшение пул-запросов с проверками качества

### Оптимизация затрат
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Оптимизация расходов на облако и инфраструктуру

### Онбординг и настройка
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Настройка среды разработки для новых участников команды

### Инструменты субагентов
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Многопрофильное ревью кода с помощью специализированных субагентов
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Глубокая отладка с субагентами по отладке и производительности
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Комплексная оптимизация всего стека с несколькими субагентами
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Сохранение контекста проекта с помощью субагента-менеджера контекста
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Восстановление сохраненного контекста для непрерывности

## Возможности

- Реализации, готовые к продакшену
- Автоматическое определение фреймворков
- Лучшие практики безопасности
- Встроенный мониторинг и тестирование

- Команды работают вместе без сбоев

## Количество команд

**Всего: 52 готовых к использованию слэш-команды**, организованных по категориям:

### 🤖 Рабочие процессы (14 команд)

- Разработка и ревью функций (3 команды) 
- Автоматизация процессов разработки (6 команд)
- Оркестрированные подагентом процессы (5 команд)

### 🔧 Инструменты (38 команд)

- ИИ и машинное обучение (5 команд)
- Архитектура и качество кода (4 команды)
- Данные и базы данных (3 команды)
- DevOps и инфраструктура (6 команд)
- Разработка и тестирование (3 команды)
- Безопасность и соответствие требованиям (3 команды)
- Отладка и анализ (4 команды)
- Зависимости и конфигурация (3 команды)
- Документация и совместная работа (1 команда)
- Ввод в эксплуатацию и настройка (1 команда)
- Специализированные инструменты подагентов (5 команд)

## Примеры использования

### 🤖 Примеры рабочих процессов

```bash
# Implement a complete feature
/feature-development Add user authentication with OAuth2

# Comprehensive code review
/full-review Review the authentication module

# Smart issue resolution
/smart-fix Fix performance degradation in API response times

# Modernize legacy system
/legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/incident-response High CPU usage causing service degradation in production
```

### 🔧 Примеры инструментов (однократные команды)

```bash
# Create a user management API
/api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/error-trace analyze high memory usage in production pods

# Secure container images
/security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/multi-agent-review Review authentication module

# Deep debugging
/smart-debug Investigate memory leak in production workers

# Full-stack optimization
/multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/context-save Save current project state and architectural decisions

# Restore project context
/context-restore Load context from last week's sprint
```

## Расширенные команды

### Безопасность и DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Комплексное сканирование безопасности с автоматическим устранением.

- **Мультиинструментальное сканирование**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Автоматическое исправление**: Автоматическое устранение распространённых уязвимостей
- **Интеграция с CI/CD**: Ворота безопасности для GitHub Actions/GitLab CI
- **Сканирование контейнеров**: Анализ уязвимостей образов
- **Обнаружение секретов**: Интеграция с GitLeaks и TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Продвинутые стратегии оптимизации контейнеров.

- **Интеллектуальная оптимизация**: Анализирует и предлагает улучшения
- **Многоэтапные сборки**: Оптимизированные Dockerfile под конкретные фреймворки
- **Современные инструменты**: BuildKit, Bun, UV для ускорения сборки
- **Усиление безопасности**: Distroless-образы, запуск не от root-пользователя
- **Интеграция с другими командами**: Работает с выводом /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Kubernetes-развертывания промышленного уровня.

- **Продвинутые паттерны**: Стандарты безопасности Pod, сетевые политики, OPA
- **Готовность к GitOps**: Конфигурации FluxCD и ArgoCD
- **Наблюдаемость**: Prometheus ServiceMonitors, OpenTelemetry
- **Автоматическое масштабирование**: Настройки HPA, VPA и кластерного автоскейлера
- **Service Mesh**: Интеграция с Istio/Linkerd

### Frontend & Data

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Продвинутые стратегии миграции баз данных.

- **Мультимодельные БД**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Без простоев**: Blue-green-развертывания, пошаговые миграции
- **Event Sourcing**: Интеграция с Kafka/Kinesis для CDC
- **Кроссплатформенность**: Работа с полиглотной персистентностью
- **Мониторинг**: Проверки состояния миграций и откаты

## Комбинирование рабочих процессов и инструментов

Реальная сила — в комбинировании рабочих процессов и инструментов для полного цикла разработки:

### Пример: создание новой функции

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/test-harness Add integration tests for WebSocket connections
/security-scan Check for WebSocket vulnerabilities
/docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/full-review Review the entire chat feature implementation
```

### Пример: Модернизация устаревшего кода

```bash
# 1. Start with the modernization workflow
/legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/deps-upgrade Update all dependencies to latest versions
/refactor-clean Remove deprecated patterns and dead code
/test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/docker-optimize Create multi-stage production build
/k8s-manifest Deploy with zero-downtime strategy
```

## Шаблоны оркестрации команд

Команды могут использоваться отдельно или комбинироваться в мощные шаблоны:

### Последовательное выполнение
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Параллельный анализ
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Итеративная доработка
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Интеграция между доменами
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Когда использовать рабочие процессы и инструменты

### 🔀 Рабочие процессы и инструменты подагентов
- **Решение проблем**: Анализируйте и исправляйте проблемы адаптивно
- **Множественные перспективы**: Координируйте работу специализированных подагентов
- **Сложные задачи**: Многошаговые процессы в разных областях
- **Неизвестные решения**: Позвольте подагентам определить подход

### 🛠️ Специализированные инструменты
- **Настройка инфраструктуры**: Конфигурирование окружения
- **Генерация кода**: Создание конкретных реализаций
- **Анализ**: Формирование отчетов без исправлений
- **Задачи по домену**: Высокоспециализированные операции

**Примеры:**
- "Реализовать систему аутентификации пользователей" → `/feature-development`
- "Исправить проблемы с производительностью во всех слоях" → `/smart-fix`
- "Модернизировать устаревший монолит" → `/legacy-modernize`

### 🔧 Используйте инструменты, когда:
- **Нужна конкретная экспертиза** — Четкая, сфокусированная задача в одной области
- **Требуется точный контроль** — Хотите определить детали реализации
- **Часть ручного процесса** — Интеграция в существующие рабочие процессы
- **Требуется глубокая специализация** — Нужна экспертная реализация
- **Развитие существующего решения** — Улучшение или доработка предыдущих результатов

**Примеры:**
- "Создать манифесты Kubernetes" → `/k8s-manifest`
- "Провести сканирование на уязвимости безопасности" → `/security-scan`
- "Сгенерировать документацию API" → `/doc-generate`

## Формат команд

Слэш-команды — это простые markdown-файлы, где:
- Имя файла становится именем команды (например, `api-scaffold.md` → `/api-scaffold`)
- Содержимое файла — это запрос/инструкция, выполняемая при вызове
- Используйте плейсхолдер `$ARGUMENTS` для пользовательского ввода

## Лучшие практики

### Выбор команды
- **Позвольте Claude Code предлагать автоматически** — Анализирует контекст и выбирает оптимальные команды
- **Используйте рабочие процессы для сложных задач** — Подагенты координируют реализации в разных доменах
- **Используйте инструменты для узконаправленных задач** — Применяйте специфические команды для целевых улучшений

### Эффективное использование
- **Предоставляйте полный контекст** — Включайте стек технологий, ограничения и требования
- **Стратегически связывайте команды** — Рабочие процессы → Инструменты → Доработки
- **Стройте на предыдущих результатах** — Команды разработаны для совместной работы

## Внесение изменений

1. Создайте файл `.md` в папке `workflows/` или `tools/`
2. Используйте имена в нижнем регистре через дефис
3. Включайте `$ARGUMENTS` для пользовательского ввода

## Устранение неполадок

**Команда не найдена**: Проверьте, что файлы находятся в `~/.claude/commands/`

**Медленные рабочие процессы**: Это нормально — они координируют работу нескольких подагентов

**Общий результат**: Добавьте более конкретный контекст о вашем стеке технологий

**Проблемы интеграции**: Проверьте пути к файлам и последовательность команд

## Советы по производительности

**Выбор команды:**
- **Рабочие процессы**: Координация нескольких подагентов для сложных функций
- **Инструменты**: Операции с одной целью для конкретных задач
- **Простые изменения**: Оставайтесь с основным агентом

**Оптимизация:**
- Начинайте с инструментов для известных проблем
- Сразу предоставляйте подробные требования
- Стройте на предыдущих результатах команд
- Дождитесь завершения рабочих процессов перед изменениями

### Добавление нового рабочего процесса:
- Сосредоточьтесь на оркестрации и логике делегирования подагентов
- Укажите, каких специализированных подагентов использовать и в каком порядке
- Определите паттерны координации между подагентами

### Добавление нового инструмента:
- Включайте полные, готовые к производству реализации
- Структурируйте содержимое с четкими разделами и практическими результатами
- Включайте примеры, лучшие практики и точки интеграции

## Узнать больше

- [Документация Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Документация по слэш-командам](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Документация по подагентам](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Коллекция подагентов Claude Code](https://github.com/wshobson/agents) — Специализированные подагенты, используемые этими командами


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---