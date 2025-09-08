
<div align="right">
  <details>
    <summary >🌐 Język</summary>
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

# Polecenia ukośne Claude Code

Gotowe do produkcji polecenia ukośne dla [Claude Code](https://docs.anthropic.com/en/docs/claude-code), które przyspieszają rozwój poprzez inteligentną automatyzację.

**52 polecenia** zorganizowane jako:
- **🤖 Przepływy pracy**: Orkiestracja wielu subagentów dla złożonych zadań
- **🔧 Narzędzia**: Jednofunkcyjne narzędzia do konkretnych operacji

### 🤝 Wymaga Claude Code Subagentów

Te polecenia działają z [Claude Code Subagentami](https://github.com/wshobson/agents) dla możliwości orkiestracji.

## Instalacja

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Dostępne polecenia

- **🤖 Przepływy pracy** - Organizuj wiele subagentów do złożonych zadań
- **🔧 Narzędzia** - Polecenia jednofunkcyjne do konkretnych operacji

## Użytkowanie

Polecenia są zorganizowane w katalogach `tools/` i `workflows/`. Używaj ich z prefiksem katalogu:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Uwaga:** Jeśli wolisz używać poleceń bez prefiksów, możesz spłaszczyć katalogi:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code automatycznie sugeruje odpowiednie polecenia na podstawie kontekstu.

## 🤖 Przepływy pracy

Orkiestracja wielu subagentów do złożonych zadań:

### Tworzenie funkcji
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Backend, frontend, testowanie i wdrażanie przez subagentów buduje kompletne funkcje
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Wielu subagentów recenzujących zapewnia kompleksową analizę kodu
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analizuje problemy i deleguje do odpowiednich subagentów specjalistycznych

### Procesy deweloperskie
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Wdraża skuteczne przepływy Git z strategiami branchowania i szablonami PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Zwiększa wydajność subagentów poprzez optymalizację promptów
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernizuje starsze bazy kodu za pomocą wyspecjalizowanych subagentów
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Tworzy pipeline'y ML z subagentami inżynierii danych i ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Buduje aplikacje wieloplatformowe z koordynowanymi subagentami
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatyzuje CI/CD, monitoring i wdrażanie przepływów pracy

### Przepływy pracy orkiestracji subagentów
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funkcje wieloplatformowe z backendem, frontendem i mobilnymi subagentami
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementacja z naciskiem na bezpieczeństwo z wyspecjalizowanymi subagentami
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funkcje oparte na ML z subagentami data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optymalizacja end-to-end z subagentami wydajności
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Rozwiązywanie incydentów produkcyjnych z subagentami ops

## 🔧 Narzędzia (Polecenia jednorazowe)

### AI & Uczenie maszynowe
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Buduj gotowe do produkcji asystenty AI i chatboty
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Specjalistyczna recenzja baz kodu AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Tworzenie agentów LangChain/LangGraph według nowoczesnych wzorców
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Tworzenie kompleksowych pipeline'ów ML z MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optymalizacja promptów AI pod kątem wydajności i jakości

### Architektura & Jakość kodu
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Generowanie szczegółowych wyjaśnień złożonego kodu
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migracja kodu pomiędzy językami, frameworkami lub wersjami
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refaktoryzacja kodu dla lepszej utrzymania i wydajności

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analizuj i priorytetyzuj dług techniczny

### Dane i Baza Danych
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Projektuj skalowalne architektury potoków danych
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Wdrażaj kompleksowe systemy walidacji danych
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Zaawansowane strategie migracji baz danych

### DevOps i Infrastruktura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Generuj konfiguracje wdrożeniowe i listy kontrolne
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Zaawansowane strategie optymalizacji kontenerów
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Wdrożenia Kubernetes klasy produkcyjnej
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Konfiguruj kompleksowe monitorowanie i obserwowalność
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Wdrażaj cele poziomu usług (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatyzuj przepływy pracy rozwojowe i operacyjne

### Rozwój i Testowanie
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Twórz realistyczne mocki API do rozwoju i testowania
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Generuj gotowe do produkcji końcówki API z pełnym stosikiem implementacji
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Twórz kompleksowe zestawy testów z wykrywaniem frameworków

### Bezpieczeństwo i Zgodność
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kompleksowe testowanie dostępności i poprawki
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Zapewnij zgodność z przepisami (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Kompleksowe skanowanie bezpieczeństwa z automatycznym zarządzaniem lukami

### Debugowanie i Analiza
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Zaawansowane strategie debugowania i śledzenia
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Dogłębna analiza wzorców błędów i strategie rozwiązywania
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Śledź i diagnozuj błędy produkcyjne
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Twórz dobrze ustrukturyzowane zgłoszenia GitHub/GitLab

### Zależności i Konfiguracja
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Waliduj i zarządzaj konfiguracją aplikacji
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audytuj zależności pod kątem bezpieczeństwa i licencji
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Bezpiecznie aktualizuj zależności projektu

### Dokumentacja i Współpraca
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Generuj kompleksową dokumentację
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Wdrażaj skuteczne przepływy pracy Git
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Ulepszaj pull requesty poprzez kontrolę jakości

### Optymalizacja kosztów
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optymalizuj koszty chmury i infrastruktury

### Wprowadzenie i konfiguracja
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Konfiguruj środowiska deweloperskie dla nowych członków zespołu

### Narzędzia subagentów
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Wieloaspektowa recenzja kodu z wyspecjalizowanymi subagentami
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Głębokie debugowanie z subagentami debuggera i wydajności
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optymalizacja full-stack z wieloma subagentami
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Zapisz kontekst projektu za pomocą subagenta context-manager
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Przywróć zapisany kontekst dla ciągłości pracy

## Funkcje

- Gotowe do produkcji implementacje
- Automatyczne wykrywanie frameworków
- Najlepsze praktyki bezpieczeństwa
- Wbudowany monitoring i testowanie
- Komendy współpracują ze sobą płynnie

## Liczba komend

**Łącznie: 52 gotowe do produkcji komendy slash** zorganizowane w:

### 🤖 Workflows (14 komend)

- Rozwój funkcjonalności i recenzje (3 komendy)
- Automatyzacja procesu deweloperskiego (6 komend)
- Przepływy pracy z orkiestracją subagentów (5 komend)

### 🔧 Narzędzia (38 komend)

- AI i uczenie maszynowe (5 komend)
- Architektura i jakość kodu (4 komendy)
- Dane i bazy danych (3 komendy)
- DevOps i infrastruktura (6 komend)
- Programowanie i testowanie (3 komendy)
- Bezpieczeństwo i zgodność (3 komendy)
- Debugowanie i analiza (4 polecenia)
- Zależności i konfiguracja (3 polecenia)
- Dokumentacja i współpraca (1 polecenie)
- Wdrożenie i konfiguracja (1 polecenie)
- Narzędzia specyficzne dla subagenta (5 poleceń)

## Przykłady użycia

### 🤖 Przykłady przepływów pracy

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

### 🔧 Przykłady narzędzi (polecenia jednofunkcyjne)

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

## Rozszerzone polecenia

### Bezpieczeństwo i DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Kompleksowe skanowanie bezpieczeństwa z automatyczną naprawą.

- **Skanowanie wielonarzędziowe**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automatyczne naprawy**: Automatyczna naprawa typowych podatności
- **Integracja z CI/CD**: Bramki bezpieczeństwa dla GitHub Actions/GitLab CI
- **Skanowanie kontenerów**: Analiza podatności obrazów
- **Wykrywanie sekretów**: Integracja z GitLeaks i TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Zaawansowane strategie optymalizacji kontenerów.

- **Inteligentna optymalizacja**: Analiza i sugestie ulepszeń
- **Wielostopniowe budowanie**: Dockerfile zoptymalizowane dla konkretnych frameworków
- **Nowoczesne narzędzia**: BuildKit, Bun, UV dla szybszego budowania
- **Wzmacnianie bezpieczeństwa**: Obrazy distroless, użytkownicy bez uprawnień root
- **Integracja między poleceniami**: Współpraca z wynikami /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Wdrożenia Kubernetes klasy produkcyjnej.

- **Zaawansowane wzorce**: Standardy bezpieczeństwa Podów, polityki sieciowe, OPA
- **Gotowe do GitOps**: Konfiguracje FluxCD i ArgoCD
- **Obserwowalność**: Prometheus ServiceMonitors, OpenTelemetry
- **Automatyczne skalowanie**: Konfiguracje HPA, VPA i autoskalera klastra
- **Service Mesh**: Integracja z Istio/Linkerd

### Frontend i dane

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Zaawansowane strategie migracji baz danych.

- **Wiele baz danych**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Brak przestojów**: wdrożenia blue-green, migracje etapowe
- **Event Sourcing**: integracja z Kafka/Kinesis dla CDC
- **Wieloplatformowość**: obsługuje poliglotyczną trwałość danych
- **Monitorowanie**: kontrole stanu migracji i możliwość wycofania

## Łączenie procesów i narzędzi

Prawdziwa siła tkwi w łączeniu procesów i narzędzi dla pełnych cykli rozwojowych:

### Przykład: Tworzenie nowej funkcji

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

### Przykład: Unowocześnianie kodu dziedziczonego

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

## Wzorce Orkiestracji Poleceń

Polecenia mogą być używane indywidualnie lub łączone w potężne wzorce:

### Wykonanie Sekwencyjne
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Analiza równoległa
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iteracyjne udoskonalanie
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integracja międzydomenowa
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Kiedy używać workflowów vs narzędzi

### 🔀 Workflowy i narzędzia subagentów
- **Rozwiązywanie problemów**: Analiza i adaptacyjne rozwiązywanie problemów
- **Wiele perspektyw**: Koordynacja subagentów-specjalistów
- **Złożone zadania**: Procesy wieloetapowe obejmujące różne dziedziny
- **Nieznane rozwiązania**: Pozwól subagentom określić podejście

### 🛠️ Narzędzia specjalistyczne
- **Konfiguracja infrastruktury**: Ustawianie środowisk
- **Generowanie kodu**: Tworzenie konkretnych implementacji
- **Analiza**: Generowanie raportów bez naprawy błędów
- **Zadania domenowe**: Wysoce specjalistyczne operacje

**Przykłady:**
- "Zaimplementuj system uwierzytelniania użytkowników" → `/workflows:feature-development`
- "Napraw problemy z wydajnością w całym stacku" → `/workflows:smart-fix`
- "Unowocześnij monolit legacy" → `/workflows:legacy-modernize`

### 🔧 Używaj narzędzi, gdy:
- **Potrzebna konkretna wiedza** - Jasne, skoncentrowane zadanie w jednej dziedzinie
- **Pożądana precyzyjna kontrola** - Chęć dokładnego określenia szczegółów implementacji
- **Część ręcznego workflowu** - Integracja z istniejącymi procesami
- **Wymagana głęboka specjalizacja** - Potrzeba eksperckiej implementacji
- **Budowanie na istniejącej pracy** - Ulepszanie lub dopracowywanie wcześniejszych wyników

**Przykłady:**
- "Utwórz manifesty Kubernetes" → `/tools:k8s-manifest`
- "Skanuj podatności bezpieczeństwa" → `/tools:security-scan`
- "Generuj dokumentację API" → `/tools:doc-generate`

## Format poleceń

Polecenia typu slash to proste pliki markdown, gdzie:
- Nazwa pliku staje się nazwą polecenia (np. `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Zawartość pliku to polecenie/instrukcja wykonywana przy wywołaniu
- Użyj zastępnika `$ARGUMENTS` dla danych wejściowych użytkownika

## Najlepsze praktyki

### Wybór poleceń
- **Pozwól Claude Code sugerować automatycznie** - Analizuje kontekst i wybiera optymalne polecenia
- **Używaj workflowów do złożonych zadań** - Subagenci koordynują wdrożenia wielodomenowe
- **Używaj narzędzi do ukierunkowanych zadań** - Stosuj konkretne polecenia dla celowanych usprawnień

### Skuteczne użycie
- **Zapewnij pełny kontekst** - Uwzględnij stos technologiczny, ograniczenia i wymagania
- **Łącz polecenia strategicznie** - Workflows → Narzędzia → Udoskonalenia
- **Buduj na poprzednich wynikach** - Polecenia są zaprojektowane do współpracy

## Wkład

1. Utwórz plik `.md` w `workflows/` lub `tools/`
2. Używaj nazw z małymi literami i myślnikami
3. Dodaj `$ARGUMENTS` dla danych wejściowych użytkownika

## Rozwiązywanie problemów

**Polecenie nie znalezione**: 
- Sprawdź, czy pliki są w `~/.claude/commands/tools/` lub `~/.claude/commands/workflows/`
- Użyj właściwego prefiksu: `/tools:nazwa-polecenia` lub `/workflows:nazwa-polecenia`
- Lub spłaszcz katalogi jeśli wolisz bez prefiksów: `cp tools/*.md . && cp workflows/*.md .`

**Wolne workflowy**: Normalne - koordynują wiele subagentów

**Ogólny wynik**: Dodaj bardziej szczegółowy kontekst dotyczący swojego stosu technologicznego

**Problemy z integracją**: Zweryfikuj ścieżki plików i sekwencję poleceń

## Wskazówki dotyczące wydajności

**Wybór polecenia:**
- **Workflows**: Koordynacja wielu subagentów dla złożonych funkcji
- **Narzędzia**: Operacje jednego celu dla konkretnych zadań
- **Proste edycje**: Pozostań przy głównym agencie

**Optymalizacja:**
- Zacznij od narzędzi dla znanych problemów
- Podaj szczegółowe wymagania od samego początku
- Buduj na podstawie wcześniejszych wyników poleceń
- Pozwól, aby przepływy pracy zakończyły się przed wprowadzeniem modyfikacji

### Dodawanie nowego przepływu pracy:
- Skup się na orkiestracji subagentów i logice delegowania
- Określ, których wyspecjalizowanych subagentów użyć i w jakiej kolejności
- Zdefiniuj wzorce koordynacji między subagentami

### Dodawanie nowego narzędzia:
- Uwzględnij kompletne, gotowe do produkcji implementacje
- Strukturyzuj treść z wyraźnymi sekcjami i praktycznymi wynikami
- Dodaj przykłady, najlepsze praktyki i punkty integracji

## Dowiedz się więcej

- [Dokumentacja Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Dokumentacja Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Dokumentacja Subagentów](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - Wyspecjalizowani subagenci używani przez te polecenia


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---