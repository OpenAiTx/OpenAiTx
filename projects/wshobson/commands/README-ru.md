
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

# Claude Code Slash Commands

Готовые к производству слэш-команды для [Claude Code](https://docs.anthropic.com/en/docs/claude-code), ускоряющие разработку с помощью интеллектуальной автоматизации.

**52 команды**, организованные как:
- **🤖 Рабочие процессы**: Многоагентная оркестрация для сложных задач
- **🔧 Инструменты**: Узкоспециализированные утилиты для конкретных операций

### 🤝 Требуются субагенты Claude Code

Эти команды работают с [Claude Code Subagents](https://github.com/wshobson/agents) для обеспечения возможностей оркестрации.

## Установка

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Доступные команды

- **🤖 Рабочие процессы** - Организация работы нескольких подагентов для сложных задач
- **🔧 Инструменты** - Одноцелевые команды для конкретных операций

## Использование

Команды организованы в каталогах `tools/` и `workflows/`. Используйте их с префиксом каталога:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Примечание:** Если вы предпочитаете использовать команды без префиксов, вы можете сделать структуру каталогов плоской:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code автоматически предлагает релевантные команды на основе контекста.

## 🤖 Рабочие процессы

Оркестрация нескольких субагентов для сложных задач:

### Разработка функций
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** — Субагенты по backend, frontend, тестированию и деплою создают полноценные функции
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** — Несколько субагентов по ревью проводят комплексный анализ кода
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** — Анализирует проблемы и делегирует их подходящим субагентам-специалистам

### Процессы разработки
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** — Реализует эффективные Git-процессы с стратегиями ветвления и шаблонами PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** — Повышает производительность субагентов через оптимизацию подсказок
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** — Модернизирует устаревшие кодовые базы с помощью специализированных субагентов
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** — Создает ML-пайплайны с субагентами по данным и машинному обучению
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** — Разрабатывает кроссплатформенные приложения с координированными субагентами
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** — Автоматизирует рабочие процессы CI/CD, мониторинга и деплоя

### Рабочие процессы, оркестрируемые субагентами
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** — Мультиплатформенные функции с backend, frontend и мобильными субагентами
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** — Реализация с приоритетом безопасности с использованием специализированных субагентов
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** — Функции на базе ML с субагентами по Data Science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** — Комплексная оптимизация с субагентами по производительности
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** — Разрешение инцидентов в продакшене с помощью субагентов по эксплуатации

## 🔧 Инструменты (Одноцелевые команды)

### ИИ и Машинное обучение
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** — Создание готовых к продакшену AI-ассистентов и чат-ботов
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** — Специализированное ревью для AI/ML-кодовых баз
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** — Создание агентов LangChain/LangGraph с современными паттернами
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** — Создание end-to-end ML-пайплайнов с MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** — Оптимизация AI-подсказок для производительности и качества

### Архитектура и качество кода
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** — Генерация подробных объяснений сложного кода
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** — Миграция кода между языками, фреймворками или версиями
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** — Рефакторинг кода для поддерживаемости и производительности

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Анализируйте и расставляйте приоритеты технического долга

### Данные и база данных
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Проектируйте масштабируемые архитектуры конвейеров данных
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Реализуйте комплексные системы валидации данных
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Продвинутые стратегии миграции баз данных

### DevOps и инфраструктура
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Генерируйте конфигурации и чек-листы для развертывания
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Продвинутые стратегии оптимизации контейнеров
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Промышленные развертывания Kubernetes
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Настройте комплексный мониторинг и наблюдаемость
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Реализуйте целевые показатели обслуживания (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Автоматизируйте рабочие процессы разработки и эксплуатации

### Разработка и тестирование
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Создавайте реалистичные мок-версии API для разработки и тестирования
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Генерируйте готовые к эксплуатации конечные точки API с полной реализацией
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Создавайте комплексные наборы тестов с обнаружением фреймворка

### Безопасность и соответствие
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Комплексное тестирование доступности и исправление ошибок
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Обеспечьте соблюдение нормативных требований (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Комплексное сканирование безопасности с автоматическим исправлением

### Отладка и анализ
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Продвинутые стратегии отладки и трассировки
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Глубокий анализ ошибок и стратегии их решения
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Отслеживайте и диагностируйте ошибки в продакшене
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Создавайте структурированные задачи для GitHub/GitLab

### Зависимости и конфигурация
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Проверяйте и управляйте конфигурацией приложения
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Аудит зависимостей на безопасность и лицензирование
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Безопасно обновляйте зависимости проекта

### Документация и совместная работа
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Генерируйте подробную документацию
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Реализуйте эффективные рабочие процессы Git
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Улучшайте pull request-ы с помощью проверок качества

### Оптимизация затрат
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Оптимизация расходов на облачные и инфраструктурные ресурсы

### Введение и настройка
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Настройка среды разработки для новых членов команды

### Инструменты субагентов
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Мульти-перспективный код-ревью с использованием специализированных субагентов
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Глубокая отладка с помощью отладчика и субагентов производительности
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Оптимизация полного стека с использованием нескольких субагентов
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Сохранение контекста проекта с помощью субагента управления контекстом
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Восстановление сохраненного контекста для обеспечения непрерывности

## Возможности

- Готовые к промышленной эксплуатации реализации
- Автоматическое определение фреймворка
- Лучшие практики безопасности
- Встроенный мониторинг и тестирование
- Команды работают совместно без сбоев

## Количество команд

**Всего: 52 готовых к эксплуатации slash-команды**, организованных в:

### 🤖 Рабочие процессы (14 команд)

- Разработка и ревью функций (3 команды)
- Автоматизация процессов разработки (6 команд)
- Рабочие процессы с оркестрацией субагентов (5 команд)

### 🔧 Инструменты (38 команд)

- ИИ и машинное обучение (5 команд)
- Архитектура и качество кода (4 команды)
- Данные и базы данных (3 команды)
- DevOps и инфраструктура (6 команд)
- Разработка и тестирование (3 команды)
- Безопасность и соответствие (3 команды)
- Отладка и анализ (4 команды)
- Зависимости и конфигурация (3 команды)
- Документация и сотрудничество (1 команда)
- Введение и настройка (1 команда)
- Инструменты для подпроцессов (5 команд)

## Примеры использования

### 🤖 Примеры рабочих процессов

```bash
# Implement a complete feature
/workflows:feature-development Add user authentication with OAuth2

# Comprehensive code review
/workflows:full-review Review the authentication module

# Smart issue resolution
/workflows:smart-fix Fix performance degradation in API response times

# Modernize legacy system
/workflows:legacy-modernize Migrate monolithic Java app to microservices

# Build comprehensive multi-platform feature
/workflows:full-stack-feature User authentication with social login across web and mobile

# Implement security-first architecture
/workflows:security-hardening Harden API endpoints and implement zero-trust security model

# Create data-driven ML feature
/workflows:data-driven-feature Build recommendation engine with real-time personalization

# Optimize entire application stack
/workflows:performance-optimization Improve response times and reduce infrastructure costs

# Respond to production incident
/workflows:incident-response High CPU usage causing service degradation in production
```

### 🔧 Примеры инструментов (однократные команды)

```bash
# Create a user management API
/tools:api-scaffold user CRUD operations with JWT auth and role-based access

# Review microservices architecture
/tools:multi-agent-review analyze our microservices for coupling and scalability issues

# Optimize LLM chat application
/tools:prompt-optimize reduce latency for customer support chatbot while maintaining accuracy

# Create fraud detection pipeline
/tools:data-pipeline real-time fraud detection with feature store and monitoring

# Debug production issue
/tools:error-trace analyze high memory usage in production pods

# Secure container images
/tools:security-scan scan and fix vulnerabilities in Docker images

# Generate API documentation
/tools:doc-generate create OpenAPI docs with examples for REST endpoints

# Onboard new developer
/tools:onboard Setup development environment for React/Node.js project

# Multi-perspective code review
/tools:multi-agent-review Review authentication module

# Deep debugging
/tools:smart-debug Investigate memory leak in production workers

# Full-stack optimization
/tools:multi-agent-optimize Optimize checkout flow for better conversion

# Save project context
/tools:context-save Save current project state and architectural decisions

# Restore project context
/tools:context-restore Load context from last week's sprint
```

## Расширенные команды

### Безопасность и DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Комплексное сканирование безопасности с автоматическим устранением уязвимостей.

- **Многоинструментальное сканирование**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Автоматическое исправление**: Автоматическое устранение общих уязвимостей
- **Интеграция с CI/CD**: Ворота безопасности для GitHub Actions/GitLab CI
- **Сканирование контейнеров**: Анализ уязвимостей образов
- **Обнаружение секретов**: Интеграция с GitLeaks и TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Продвинутые стратегии оптимизации контейнеров.

- **Умная оптимизация**: Анализирует и предлагает улучшения
- **Многоэтапные сборки**: Оптимизированные Dockerfile для разных фреймворков
- **Современные инструменты**: BuildKit, Bun, UV для ускорения сборки
- **Усиление безопасности**: Образы distroless, непривилегированные пользователи
- **Интеграция с другими командами**: Совместимость с выводом /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Промышленные развертывания Kubernetes.

- **Продвинутые паттерны**: Стандарты безопасности Pod, сетевые политики, OPA
- **Готово для GitOps**: Конфигурации FluxCD и ArgoCD
- **Наблюдаемость**: Prometheus ServiceMonitors, OpenTelemetry
- **Автоматическое масштабирование**: Конфигурации HPA, VPA и кластерного автоскейлера
- **Сервисная сетка**: Интеграция Istio/Linkerd

### Фронтенд и данные

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Продвинутые стратегии миграции баз данных.

- **Мульти-база данных**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Без простоя**: Развертывание по схеме blue-green, поэтапные миграции
- **Event Sourcing**: Интеграция с Kafka/Kinesis для CDC
- **Кроссплатформенность**: Поддержка полиглотной персистентности
- **Мониторинг**: Проверка состояния миграций и откат изменений

## Комбинирование рабочих процессов и инструментов

Настоящая сила заключается в объединении рабочих процессов и инструментов для полного цикла разработки:

### Пример: Создание новой функции

```bash
# 1. Use a workflow to implement the feature with multiple subagents
/workflows:feature-development Add real-time chat feature with WebSocket support

# 2. Use tools for specific enhancements
/tools:test-harness Add integration tests for WebSocket connections
/tools:security-scan Check for WebSocket vulnerabilities
/tools:docker-optimize Optimize container for WebSocket connections

# 3. Use a workflow for comprehensive review
/workflows:full-review Review the entire chat feature implementation
```

### Пример: Модернизация устаревшего кода

```bash
# 1. Start with the modernization workflow
/workflows:legacy-modernize Migrate Express.js v4 app to modern architecture

# 2. Use specific tools for cleanup
/tools:deps-upgrade Update all dependencies to latest versions
/tools:refactor-clean Remove deprecated patterns and dead code
/tools:test-harness Ensure 100% test coverage

# 3. Optimize and deploy
/tools:docker-optimize Create multi-stage production build
/tools:k8s-manifest Deploy with zero-downtime strategy
```

## Шаблоны оркестрации команд

Команды могут использоваться отдельно или комбинироваться в мощные шаблоны:

### Последовательное выполнение
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Параллельный анализ
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Итеративная доработка
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Интеграция между доменами
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Когда использовать рабочие процессы и инструменты

### 🔀 Рабочие процессы и инструменты субагентов
- **Решение проблем**: Анализируйте и адаптивно устраняйте проблемы
- **Множественные перспективы**: Координируйте работу специализированных субагентов
- **Сложные задачи**: Многоступенчатые процессы между областями
- **Неизвестные решения**: Позвольте субагентам определить подход

### 🛠️ Специализированные инструменты
- **Настройка инфраструктуры**: Конфигурируйте среды
- **Генерация кода**: Создавайте конкретные реализации
- **Анализ**: Формируйте отчеты без исправлений
- **Задачи домена**: Высокоспециализированные операции

**Примеры:**
- "Реализовать систему аутентификации пользователей" → `/workflows:feature-development`
- "Исправить проблемы производительности по всему стеку" → `/workflows:smart-fix`
- "Модернизировать устаревший монолит" → `/workflows:legacy-modernize`

### 🔧 Используйте инструменты, когда:
- **Нужна специфическая экспертиза** — Четкая, сфокусированная задача в одной области
- **Требуется точный контроль** — Желание управлять деталями реализации
- **Часть ручного рабочего процесса** — Интеграция в существующие процессы
- **Требуется глубокая специализация** — Нужна экспертная реализация
- **Развитие существующих решений** — Улучшение или доработка предыдущих результатов

**Примеры:**
- "Создать манифесты Kubernetes" → `/tools:k8s-manifest`
- "Провести сканирование на уязвимости безопасности" → `/tools:security-scan`
- "Сгенерировать документацию API" → `/tools:doc-generate`

## Формат команд

Слэш-команды — это простые файлы markdown, где:
- Имя файла становится названием команды (например, `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Содержимое файла — это инструкция/промпт, выполняемый при вызове
- Используйте плейсхолдер `$ARGUMENTS` для пользовательского ввода

## Лучшие практики

### Выбор команды
- **Пусть Claude Code предлагает автоматически** — анализирует контекст и выбирает оптимальные команды
- **Используйте workflows для сложных задач** — субагенты координируют реализации в нескольких доменах
- **Используйте инструменты для целевых задач** — применяйте конкретные команды для точечных улучшений

### Эффективное использование
- **Предоставляйте полный контекст** — указывайте технологический стек, ограничения и требования
- **Стратегически связывайте команды** — Workflows → Инструменты → Доработки
- **Стройте работу на предыдущих результатах** — команды спроектированы для совместной работы

## Участие

1. Создайте `.md` файл в `workflows/` или `tools/`
2. Используйте имена в нижнем регистре через дефис
3. Включайте `$ARGUMENTS` для ввода пользователя

## Устранение неполадок

**Команда не найдена**: 
- Проверьте, что файлы находятся в `~/.claude/commands/tools/` или `~/.claude/commands/workflows/`
- Используйте правильный префикс: `/tools:имя-команды` или `/workflows:имя-команды`
- Или объединяйте директории, если не нужны префиксы: `cp tools/*.md . && cp workflows/*.md .`

**Workflows работают медленно**: Это нормально — они координируют работу нескольких субагентов

**Общий результат**: Добавьте более конкретный контекст о вашем технологическом стеке

**Проблемы с интеграцией**: Проверьте пути к файлам и последовательность команд

## Рекомендации по производительности

**Выбор команды:**
- **Workflows**: Координация нескольких субагентов для сложных функций
- **Инструменты**: Одноцелевые операции для конкретных задач
- **Простые правки**: Работайте с основным агентом

**Оптимизация:**
- Начинайте с инструментов для известных проблем
- Сразу предоставляйте подробные требования
- Основывайтесь на выводах предыдущих команд
- Позвольте рабочим процессам завершиться перед внесением изменений

### Добавление нового рабочего процесса:
- Сосредоточьтесь на оркестрации и логике делегирования подагентов
- Укажите, каких специализированных подагентов использовать и в каком порядке
- Определите схемы координации между подагентами

### Добавление нового инструмента:
- Включайте полные, готовые к производству реализации
- Структурируйте содержание с чёткими разделами и результатами для действий
- Добавляйте примеры, лучшие практики и точки интеграции

## Подробнее

- [Документация Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Документация Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Документация Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Коллекция Claude Code Subagents](https://github.com/wshobson/agents) - Специализированные подагенты, используемые этими командами


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---