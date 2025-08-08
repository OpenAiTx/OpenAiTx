
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

# Polecenia Slash Claude Code

Gotowe do produkcji polecenia slash dla [Claude Code](https://docs.anthropic.com/en/docs/claude-code), które przyspieszają rozwój dzięki inteligentnej automatyzacji.

**52 polecenia** zorganizowane jako:
- **🤖 Przepływy pracy**: Orkiestracja wieloagentowa dla złożonych zadań
- **🔧 Narzędzia**: Narzędzia jednorazowe do konkretnych operacji

### 🤝 Wymagane subagenty Claude Code

Te polecenia działają z [subagentami Claude Code](https://github.com/wshobson/agents) zapewniając możliwości orkiestracji.

## Instalacja

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Dostępne polecenia

- **🤖 Przepływy pracy** - Orkiestracja wielu subagentów do złożonych zadań
- **🔧 Narzędzia** - Polecenia jednofunkcyjne do konkretnych operacji

## Użytkowanie

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code automatycznie sugeruje odpowiednie polecenia na podstawie kontekstu.

## 🤖 Przepływy pracy

Orkiestracja wielu subagentów dla złożonych zadań:

### Rozwój funkcjonalności
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagenci backendu, frontendu, testów i wdrożenia budują kompletne funkcjonalności
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Wielu subagentów recenzujących zapewnia kompleksową analizę kodu
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analizuje problemy i deleguje do odpowiednich subagentów specjalistycznych

### Procesy deweloperskie
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Wdraża skuteczne przepływy Git z rozgałęzieniami i szablonami PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Poprawia wydajność subagentów przez optymalizację promptów
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Unowocześnia starsze bazy kodu za pomocą wyspecjalizowanych subagentów
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Tworzy pipeline’y ML z subagentami inżynierii danych i ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Buduje aplikacje wieloplatformowe z koordynacją subagentów
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatyzuje CI/CD, monitoring i wdrożenia

### Przepływy pracy z orkiestracją subagentów
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funkcjonalności wieloplatformowe z backendem, frontendem i mobile subagentami
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Wdrażanie z naciskiem na bezpieczeństwo dzięki wyspecjalizowanym subagentom
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funkcje napędzane ML z subagentami data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Optymalizacja end-to-end z subagentami wydajności
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Rozwiązywanie incydentów produkcyjnych z subagentami ops

## 🔧 Narzędzia (Polecenia jednozadaniowe)

### AI i uczenie maszynowe
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Buduj gotowych do produkcji asystentów AI i chatboty
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Specjalistyczna recenzja kodu AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Twórz agentów LangChain/LangGraph z nowoczesnymi wzorcami
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Twórz kompletne pipeline’y ML z MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optymalizuj prompty AI pod kątem wydajności i jakości

### Architektura i jakość kodu
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Generuj szczegółowe wyjaśnienia złożonego kodu
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migruj kod między językami, frameworkami lub wersjami
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refaktoryzuj kod dla lepszej konserwowalności i wydajności
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analizuj i priorytetyzuj dług techniczny

### Dane i bazy danych
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Projektuj skalowalne architektury pipeline’ów danych
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Wdrażaj kompleksowe systemy walidacji danych
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Zaawansowane strategie migracji baz danych

### DevOps i infrastruktura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Generuj konfiguracje i listy kontrolne wdrożeń
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Zaawansowane strategie optymalizacji kontenerów
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Wdrożenia Kubernetes klasy produkcyjnej
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Konfiguruj kompleksowy monitoring i obserwowalność
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Wdrażaj cele poziomu usług (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatyzuj procesy rozwoju i operacji

### Rozwój i testowanie
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Twórz realistyczne mocki API do rozwoju i testowania
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Generuj gotowe do produkcji endpointy API z pełnym stosem implementacyjnym
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Twórz kompletne zestawy testów z detekcją frameworków

### Bezpieczeństwo i zgodność
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kompleksowe testy dostępności i poprawki
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Zapewnij zgodność z regulacjami (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Kompleksowy skan bezpieczeństwa z automatycznym naprawianiem

### Debugowanie i analiza
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Zaawansowane strategie debugowania i śledzenia
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Głęboka analiza wzorców błędów i strategie naprawy
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Śledź i diagnozuj błędy produkcyjne
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Twórz poprawnie ustrukturyzowane zgłoszenia GitHub/GitLab

### Zależności i konfiguracja
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Waliduj i zarządzaj konfiguracją aplikacji
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audytuj zależności pod kątem bezpieczeństwa i licencji
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Bezpieczna aktualizacja zależności projektu

### Dokumentacja i współpraca
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Generuj kompleksową dokumentację
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Wdrażaj skuteczne przepływy pracy Git
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Ulepszaj pull requesty dzięki kontrolom jakości

### Optymalizacja kosztów
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optymalizuj koszty chmury i infrastruktury

### Onboarding i konfiguracja
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Konfiguruj środowiska deweloperskie dla nowych członków zespołu

### Narzędzia subagentów
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Recenzja kodu z wielu perspektyw przez wyspecjalizowanych subagentów
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Głębokie debugowanie z subagentami debuggera i wydajności
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Optymalizacja full-stack z wieloma subagentami
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Zapisz kontekst projektu za pomocą subagenta context-manager
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Przywróć zapisany kontekst dla zachowania ciągłości

## Funkcje

- Implementacje gotowe do produkcji
- Automatyczne wykrywanie frameworków
- Najlepsze praktyki bezpieczeństwa
- Wbudowany monitoring i testowanie

- Polecenia współpracują ze sobą bezproblemowo

## Liczba Poleceń

**Łącznie: 52 gotowe do produkcji polecenia slash** zorganizowane w:

### 🤖 Przepływy pracy (14 poleceń)

- Rozwój funkcji i przegląd (3 polecenia)
- Automatyzacja procesu deweloperskiego (6 poleceń)
- Przepływy pracy orkiestracji przez subagentów (5 poleceń)

### 🔧 Narzędzia (38 poleceń)

- AI i uczenie maszynowe (5 poleceń)
- Architektura i jakość kodu (4 polecenia)
- Dane i baza danych (3 polecenia)
- DevOps i infrastruktura (6 poleceń)
- Programowanie i testowanie (3 polecenia)
- Bezpieczeństwo i zgodność (3 polecenia)
- Debugowanie i analiza (4 polecenia)
- Zależności i konfiguracja (3 polecenia)
- Dokumentacja i współpraca (1 polecenie)
- Wprowadzenie i konfiguracja (1 polecenie)
- Narzędzia specyficzne dla subagentów (5 poleceń)

## Przykłady użycia

### 🤖 Przykłady przepływów pracy

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

### 🔧 Przykłady narzędzi (polecenia jednofunkcyjne)

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

## Rozszerzone Polecenia

### Bezpieczeństwo i DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Kompleksowe skanowanie bezpieczeństwa z automatyczną naprawą.

- **Wielonarzędziowe Skanowanie**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automatyczne Naprawy**: Powszechne podatności usuwane automatycznie
- **Integracja CI/CD**: Bramki bezpieczeństwa dla GitHub Actions/GitLab CI
- **Skanowanie Kontenerów**: Analiza podatności obrazów
- **Wykrywanie Sekretów**: Integracja GitLeaks i TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Zaawansowane strategie optymalizacji kontenerów.

- **Inteligentna Optymalizacja**: Analizuje i sugeruje ulepszenia
- **Wielostopniowe Buildy**: Optymalizowane Dockerfile dla wybranych frameworków
- **Nowoczesne Narzędzia**: BuildKit, Bun, UV dla szybszych buildów
- **Wzmocnienie Bezpieczeństwa**: Obrazy distroless, użytkownicy bez uprawnień root
- **Integracja z Innymi Poleceniami**: Współpracuje z wynikami /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Wdrożenia Kubernetes klasy produkcyjnej.

- **Zaawansowane Wzorce**: Standardy bezpieczeństwa Pod, Polityki Sieciowe, OPA
- **Gotowość GitOps**: Konfiguracje FluxCD i ArgoCD
- **Obserwowalność**: Prometheus ServiceMonitors, OpenTelemetry
- **Automatyczne Skalowanie**: Konfiguracje HPA, VPA, i autoskalera klastra
- **Service Mesh**: Integracja z Istio/Linkerd

### Frontend i Dane

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Zaawansowane strategie migracji baz danych.

- **Wiele Baz Danych**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Brak Przestojów**: Blue-green deployments, migracje z przetaczaniem
- **Event Sourcing**: Integracja z Kafka/Kinesis do CDC
- **Wieloplatformowość**: Obsługa poliglotycznej persystencji
- **Monitorowanie**: Kontrola stanu migracji i możliwość rollbacku

## Łączenie Przepływów Pracy i Narzędzi

Prawdziwa siła tkwi w łączeniu przepływów pracy i narzędzi w pełne cykle rozwoju:

### Przykład: Budowanie Nowej Funkcjonalności

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

### Przykład: Unowocześnianie kodu dziedziczonego

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

## Wzorce Orkiestracji Poleceń

Polecenia mogą być używane indywidualnie lub łączone w potężne wzorce:

### Wykonanie Sekwencyjne
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Analiza równoległa
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iteracyjne udoskonalanie
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Integracja międzydomenowa
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Kiedy używać Workflowów vs Narzędzi

### 🔀 Workflows & Narzędzia Subagentów
- **Rozwiązywanie problemów**: Analizuj i naprawiaj problemy adaptacyjnie
- **Wiele perspektyw**: Koordynuj subagentów specjalistycznych
- **Złożone zadania**: Procesy wieloetapowe w różnych dziedzinach
- **Nieznane rozwiązania**: Pozwól subagentom określić podejście

### 🛠️ Narzędzia specjalistyczne
- **Konfiguracja infrastruktury**: Ustawianie środowisk
- **Generowanie kodu**: Tworzenie konkretnych implementacji
- **Analiza**: Generowanie raportów bez poprawek
- **Zadania domenowe**: Wysoce specjalistyczne operacje

**Przykłady:**
- "Zaimplementuj system uwierzytelniania użytkowników" → `/feature-development`
- "Napraw problemy wydajnościowe w całym stacku" → `/smart-fix`
- "Unowocześnij monolit legacy" → `/legacy-modernize`

### 🔧 Używaj narzędzi, gdy:
- **Potrzebna specjalistyczna wiedza** – Jasne, skoncentrowane zadanie w jednej domenie
- **Pożądana precyzyjna kontrola** – Chcesz określić szczegóły implementacji
- **Część ręcznego workflowu** – Integracja z istniejącymi procesami
- **Wymagana głęboka specjalizacja** – Potrzebujesz eksperckiej implementacji
- **Budowanie na istniejącej pracy** – Udoskonalanie lub poprawa poprzednich rezultatów

**Przykłady:**
- "Stwórz manifesty Kubernetes" → `/k8s-manifest`
- "Przeskanuj pod kątem luk bezpieczeństwa" → `/security-scan`
- "Wygeneruj dokumentację API" → `/doc-generate`

## Format poleceń

Polecenia slash to proste pliki markdown, gdzie:
- Nazwa pliku staje się nazwą polecenia (np. `api-scaffold.md` → `/api-scaffold`)
- Zawartość pliku to prompt/instrukcje wykonywane po wywołaniu
- Użyj placeholdera `$ARGUMENTS` dla danych wejściowych użytkownika

## Najlepsze praktyki

### Wybór poleceń
- **Pozwól Claude Code sugerować automatycznie** – Analizuje kontekst i wybiera optymalne polecenia
- **Używaj workflowów do złożonych zadań** – Subagenci koordynują wdrożenia w wielu domenach
- **Narzędzia do zadań skupionych** – Stosuj konkretne polecenia do ukierunkowanych usprawnień

### Skuteczne użycie
- **Podaj pełny kontekst** – Uwzględnij stack technologiczny, ograniczenia i wymagania
- **Łącz polecenia strategicznie** – Workflows → Narzędzia → Poprawki
- **Buduj na poprzednich rezultatach** – Polecenia są zaprojektowane do współpracy

## Wkład własny

1. Utwórz plik `.md` w `workflows/` lub `tools/`
2. Używaj nazw z małych liter i myślników
3. Uwzględnij `$ARGUMENTS` dla danych wejściowych użytkownika

## Rozwiązywanie problemów

**Nie znaleziono polecenia**: Sprawdź, czy pliki są w `~/.claude/commands/`

**Wolne workflowy**: Normalne – koordynują wielu subagentów

**Ogólny wynik**: Dodaj bardziej szczegółowy kontekst dotyczący stacku technologicznego

**Problemy z integracją**: Zweryfikuj ścieżki plików i kolejność poleceń

## Wskazówki dotyczące wydajności

**Wybór polecenia:**
- **Workflows**: Koordynacja wielu subagentów dla złożonych funkcji
- **Narzędzia**: Operacje jednofunkcyjne dla konkretnych zadań
- **Proste edycje**: Pozostań przy głównym agencie

**Optymalizacja:**
- Zacznij od narzędzi dla znanych problemów
- Podaj szczegółowe wymagania na początku
- Buduj na poprzednich wynikach poleceń
- Pozwól workflowom zakończyć się przed modyfikacjami

### Dodawanie nowego workflowu:
- Skup się na orkiestracji i logice delegowania subagentów
- Określ, których subagentów specjalistycznych użyć i w jakiej kolejności
- Zdefiniuj wzorce koordynacji między subagentami

### Dodawanie nowego narzędzia:
- Zawiera kompletne, gotowe do produkcji implementacje
- Strukturyzuj zawartość w jasne sekcje i praktyczne rezultaty
- Dodaj przykłady, dobre praktyki i punkty integracji

## Dowiedz się więcej

- [Claude Code Documentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Documentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagents Documentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - Kolekcja specjalistycznych subagentów używanych przez te polecenia


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---