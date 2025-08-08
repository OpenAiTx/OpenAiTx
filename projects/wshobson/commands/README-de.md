
<div align="right">
  <details>
    <summary >🌐 Sprache</summary>
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

# Claude Code Slash-Befehle

Produktionsreife Slash-Befehle für [Claude Code](https://docs.anthropic.com/en/docs/claude-code), die die Entwicklung durch intelligente Automatisierung beschleunigen.

**52 Befehle** organisiert als:
- **🤖 Workflows**: Multi-Subagenten-Orchestrierung für komplexe Aufgaben
- **🔧 Tools**: Einzweck-Tools für spezifische Operationen

### 🤝 Benötigt Claude Code Subagents

Diese Befehle arbeiten mit den [Claude Code Subagents](https://github.com/wshobson/agents) für Orchestrierungsfunktionen.

## Installation

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Verfügbare Befehle

- **🤖 Workflows** – Koordiniere mehrere Subagenten für komplexe Aufgaben
- **🔧 Tools** – Einzweckbefehle für spezifische Operationen

## Verwendung

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code schlägt automatisch relevante Befehle basierend auf dem Kontext vor.

## 🤖 Workflows

Multi-Subagenten-Orchestrierung für komplexe Aufgaben:

### Feature-Entwicklung
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** – Backend-, Frontend-, Test- und Deployment-Subagenten entwickeln komplette Features
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** – Mehrere Review-Subagenten bieten umfassende Code-Analysen
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** – Analysiert Probleme und delegiert an die passenden Spezialisten-Subagenten

### Entwicklungsprozesse
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** – Implementiert effektive Git-Workflows mit Branching-Strategien und PR-Vorlagen
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** – Verbessert die Leistung von Subagenten durch Prompt-Optimierung
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** – Modernisiert Legacy-Codebasen mit spezialisierten Subagenten
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** – Erstellt ML-Pipelines mit Data- und ML-Engineering-Subagenten
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** – Erstellt plattformübergreifende Apps mit koordinierten Subagenten
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** – Automatisiert CI/CD-, Monitoring- und Deployment-Workflows

### Subagenten-orchestrierte Workflows
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** – Multi-Plattform-Features mit Backend-, Frontend- und Mobile-Subagenten
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** – Sicherheitsorientierte Implementierung mit spezialisierten Subagenten
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** – ML-basierte Features mit Data-Science-Subagenten
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** – End-to-End-Optimierung mit Performance-Subagenten
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** – Produktions-Incident-Resolution mit Ops-Subagenten

## 🔧 Tools (Einzweck-Befehle)

### KI & Maschinelles Lernen
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** – Entwicklung produktionsreifer KI-Assistenten und Chatbots
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** – Spezialisierte Reviews für KI/ML-Codebasen
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** – Erstellung von LangChain/LangGraph-Agenten mit modernen Mustern
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** – End-to-End-ML-Pipelines mit MLOps erstellen
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** – KI-Prompts für Leistung und Qualität optimieren

### Architektur & Code-Qualität
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** – Detaillierte Erklärungen komplexer Codes generieren
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** – Code zwischen Sprachen, Frameworks oder Versionen migrieren
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** – Code für Wartbarkeit und Performance refaktorisieren
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** – Technische Schulden analysieren und priorisieren

### Daten & Datenbanken
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** – Skalierbare Datenpipeline-Architekturen entwerfen
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** – Umfassende Datenvalidierungssysteme implementieren
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** – Erweiterte Datenbank-Migrationsstrategien

### DevOps & Infrastruktur
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** – Deployment-Konfigurationen und Checklisten generieren
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** – Erweiterte Container-Optimierungsstrategien
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** – Produktionsreife Kubernetes-Deployments
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** – Umfassendes Monitoring und Observability einrichten
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** – Service Level Objectives (SLOs) umsetzen
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** – Entwicklungs- und Betriebs-Workflows automatisieren

### Entwicklung & Testen
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** – Realistische API-Mocks für Entwicklung und Test erstellen
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** – Produktionsreife API-Endpunkte mit vollständigem Implementierungs-Stack generieren
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** – Umfassende Test-Suiten mit Framework-Erkennung erstellen

### Sicherheit & Compliance
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** – Umfassende Accessibility-Tests und -Korrekturen
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** – Einhaltung von Vorschriften sicherstellen (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** – Umfassende Sicherheitsscans mit automatisierter Behebung

### Debugging & Analyse
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** – Erweiterte Debugging- und Tracing-Strategien
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** – Tiefgehende Fehleranalyse und Lösungsstrategien
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** – Produktionsfehler nachverfolgen und diagnostizieren
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** – Gut strukturierte GitHub/GitLab-Issues erstellen

### Abhängigkeiten & Konfiguration
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** – Anwendungskonfiguration validieren und verwalten
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** – Abhängigkeiten auf Sicherheit und Lizenzierung prüfen
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** – Projektabhängigkeiten sicher aktualisieren

### Dokumentation & Zusammenarbeit
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** – Umfassende Dokumentation generieren
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** – Effektive Git-Workflows implementieren
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** – Pull Requests mit Qualitätsprüfungen verbessern

### Kostenoptimierung
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** – Cloud- und Infrastrukturkosten optimieren

### Onboarding & Einrichtung
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** – Entwicklungsumgebungen für neue Teammitglieder einrichten

### Subagenten-Tools
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** – Code-Review aus mehreren Perspektiven mit spezialisierten Subagenten
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** – Tiefgehendes Debugging mit Debugger- und Performance-Subagenten
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** – Full-Stack-Optimierung mit mehreren Subagenten
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** – Projektkontext mit Context-Manager-Subagent speichern
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** – Gespeicherten Kontext für Kontinuität wiederherstellen

## Features

- Produktionsreife Implementierungen
- Automatische Framework-Erkennung
- Sicherheits-Best-Practices
- Integriertes Monitoring und Testing

- Befehle arbeiten nahtlos zusammen

## Befehlanzahl

**Insgesamt: 52 einsatzbereite Slash-Befehle**, organisiert in:

### 🤖 Workflows (14 Befehle)

- Feature-Entwicklung & Review (3 Befehle)
- Automatisierung des Entwicklungsprozesses (6 Befehle)
- Von Subagenten orchestrierte Workflows (5 Befehle)

### 🔧 Tools (38 Befehle)

- KI & Maschinelles Lernen (5 Befehle)
- Architektur & Codequalität (4 Befehle)
- Daten & Datenbanken (3 Befehle)
- DevOps & Infrastruktur (6 Befehle)
- Entwicklung & Test (3 Befehle)
- Sicherheit & Compliance (3 Befehle)
- Debugging & Analyse (4 Befehle)
- Abhängigkeiten & Konfiguration (3 Befehle)
- Dokumentation & Zusammenarbeit (1 Befehl)
- Onboarding & Einrichtung (1 Befehl)
- Subagenten-spezifische Tools (5 Befehle)

## Anwendungsbeispiele

### 🤖 Workflow-Beispiele

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

### 🔧 Werkzeugbeispiele (Einzweckbefehle)

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

## Erweiterte Befehle

### Sicherheit & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Umfassendes Sicherheitsscanning mit automatischer Behebung.

- **Multi-Tool-Scanning**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automatische Behebung**: Häufige Schwachstellen werden automatisch behoben
- **CI/CD-Integration**: Sicherheitsprüfungen für GitHub Actions/GitLab CI
- **Container-Scanning**: Analyse von Image-Sicherheitslücken
- **Secret-Erkennung**: GitLeaks- und TruffleHog-Integration

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Fortschrittliche Container-Optimierungsstrategien.

- **Intelligente Optimierung**: Analysiert und schlägt Verbesserungen vor
- **Multi-Stage-Builds**: Framework-spezifisch optimierte Dockerfiles
- **Moderne Tools**: BuildKit, Bun, UV für schnellere Builds
- **Sicherheits-Härtung**: Distroless Images, Non-Root-User
- **Cross-Command-Integration**: Funktioniert mit /api-scaffold-Ausgaben

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Produktionsreife Kubernetes-Deployments.

- **Fortgeschrittene Patterns**: Pod Security Standards, Network Policies, OPA
- **GitOps-Ready**: FluxCD- und ArgoCD-Konfigurationen
- **Beobachtbarkeit**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: HPA-, VPA- und Cluster-Autoscaler-Konfigurationen
- **Service Mesh**: Istio/Linkerd-Integration

### Frontend & Daten

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Fortgeschrittene Datenbank-Migrationsstrategien.

- **Multi-Datenbank**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Blue-Green-Deployments, Rolling Migrations
- **Event Sourcing**: Kafka/Kinesis-Integration für CDC
- **Cross-Platform**: Bewältigt polyglotte Persistenz
- **Monitoring**: Migrations-Gesundheitschecks und Rollback

## Kombination von Workflows und Tools

Die wahre Stärke liegt in der Kombination von Workflows und Tools für vollständige Entwicklungszyklen:

### Beispiel: Entwicklung eines neuen Features

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

### Beispiel: Modernisierung von Altsystem-Code

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

## Befehlsorchestrierungsmuster

Befehle können einzeln verwendet oder in leistungsstarken Mustern kombiniert werden:

### Sequentielle Ausführung
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Parallelanalyse
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iterative Verfeinerung
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Domänenübergreifende Integration
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Wann Workflows vs. Tools verwenden

### 🔀 Workflows & Subagenten-Tools
- **Problemlösung**: Analysieren und adaptive Behebung von Problemen
- **Mehrere Perspektiven**: Koordination von spezialisierten Subagenten
- **Komplexe Aufgaben**: Mehrstufige Prozesse über verschiedene Bereiche
- **Unbekannte Lösungen**: Subagenten entscheiden über den Ansatz

### 🛠️ Spezialisierte Tools
- **Infrastruktur-Einrichtung**: Konfigurieren von Umgebungen
- **Code-Generierung**: Erstellen spezifischer Implementierungen
- **Analyse**: Berichte generieren ohne Behebungen
- **Domänenaufgaben**: Hochspezialisierte Operationen

**Beispiele:**
- "Implementiere ein Benutzer-Authentifizierungssystem" → `/feature-development`
- "Behebe Performance-Probleme im gesamten Stack" → `/smart-fix`
- "Modernisiere Legacy-Monolith" → `/legacy-modernize`

### 🔧 Tools verwenden, wenn:
- **Spezifische Expertise nötig** – Klare, fokussierte Aufgabe in einem Bereich
- **Präzise Kontrolle gewünscht** – Details der Implementierung gezielt steuern
- **Teil eines manuellen Workflows** – Integration in bestehende Prozesse
- **Tiefe Spezialisierung erforderlich** – Experten-Implementierung notwendig
- **Auf bestehender Arbeit aufbauen** – Vorherige Ergebnisse verbessern oder verfeinern

**Beispiele:**
- "Erstelle Kubernetes-Manifeste" → `/k8s-manifest`
- "Scanne auf Sicherheitslücken" → `/security-scan`
- "Generiere API-Dokumentation" → `/doc-generate`

## Kommando-Format

Slash-Befehle sind einfache Markdown-Dateien, wobei:
- Der Dateiname zum Befehl wird (z. B. `api-scaffold.md` → `/api-scaffold`)
- Der Dateiinhalt ist die beim Aufruf ausgeführte Eingabe/Aufforderung
- Verwende `$ARGUMENTS` als Platzhalter für Nutzereingaben

## Best Practices

### Auswahl des Befehls
- **Automatische Empfehlung durch Claude Code** – Analysiert den Kontext und wählt optimale Befehle
- **Workflows für komplexe Aufgaben** – Subagenten koordinieren bereichsübergreifende Implementierungen
- **Tools für fokussierte Aufgaben** – Spezifische Befehle für gezielte Verbesserungen anwenden

### Effektive Nutzung
- **Umfassenden Kontext bereitstellen** – Tech-Stack, Einschränkungen und Anforderungen angeben
- **Befehle strategisch verketten** – Workflows → Tools → Verfeinerungen
- **Auf vorherigen Ergebnissen aufbauen** – Befehle sind auf Zusammenarbeit ausgelegt

## Beitrag leisten

1. Erstelle eine `.md`-Datei in `workflows/` oder `tools/`
2. Verwende Kleinschreibung und Bindestriche für Dateinamen
3. Füge `$ARGUMENTS` für Nutzereingaben ein

## Fehlerbehebung

**Befehl nicht gefunden**: Prüfe, ob die Dateien in `~/.claude/commands/` liegen

**Workflows langsam**: Normal – koordinieren mehrere Subagenten

**Generische Ausgabe**: Mehr spezifischen Kontext zu deinem Tech-Stack hinzufügen

**Integrationsprobleme**: Dateipfade und Befehlsreihenfolge überprüfen

## Performance-Tipps

**Befehlsauswahl:**
- **Workflows**: Multi-Subagenten-Koordination für komplexe Features
- **Tools**: Einzweckoperationen für spezifische Aufgaben
- **Einfache Änderungen**: Beim Hauptagenten bleiben

**Optimierung:**
- Starte mit Tools für bekannte Probleme
- Detaillierte Anforderungen von Anfang an bereitstellen
- Auf vorherigen Befehlsausgaben aufbauen
- Workflows vor Änderungen abschließen lassen

### Einen neuen Workflow hinzufügen:
- Fokus auf Subagenten-Orchestrierung und Delegationslogik
- Festlegen, welche spezialisierten Subagenten in welcher Reihenfolge verwendet werden
- Koordinationsmuster zwischen Subagenten definieren

### Ein neues Tool hinzufügen:
- Vollständige, produktionsbereite Implementierungen einfügen
- Inhalt klar gliedern und handlungsorientierte Ergebnisse bieten
- Beispiele, Best Practices und Integrationspunkte aufnehmen

## Mehr erfahren

- [Claude Code Dokumentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Dokumentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagenten Dokumentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) – Spezialisierte Subagenten, die von diesen Befehlen verwendet werden


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---