
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
- **🔧 Werkzeuge**: Einzweck-Werkzeuge für spezifische Operationen

### 🤝 Erfordert Claude-Code-Subagenten

Diese Befehle funktionieren mit den [Claude-Code-Subagenten](https://github.com/wshobson/agents) für Orchestrierungsfunktionen.

## Installation

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Verfügbare Befehle

- **🤖 Workflows** – Orchestrieren Sie mehrere Subagenten für komplexe Aufgaben
- **🔧 Tools** – Einzweckbefehle für spezielle Operationen

## Verwendung

Befehle sind in den Verzeichnissen `tools/` und `workflows/` organisiert. Verwenden Sie sie mit dem Verzeichnis-Präfix:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Hinweis:** Wenn Sie lieber Befehle ohne Präfixe verwenden möchten, können Sie die Verzeichnisse flach machen:
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code schlägt automatisch relevante Befehle basierend auf dem Kontext vor.

## 🤖 Workflows

Multi-Subagenten-Orchestrierung für komplexe Aufgaben:

### Feature-Entwicklung
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** – Backend-, Frontend-, Test- und Deployment-Subagenten entwickeln vollständige Features
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** – Mehrere Review-Subagenten bieten umfassende Code-Analysen
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** – Analysiert Probleme und delegiert an passende Spezialisten-Subagenten

### Entwicklungsprozesse
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** – Effektive Git-Workflows mit Branching-Strategien und PR-Vorlagen
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** – Verbessert die Leistung von Subagenten durch Optimierung von Prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** – Modernisiert Legacy-Codebasen mit spezialisierten Subagenten
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** – Erstellt ML-Pipelines mit Data- und ML-Engineering-Subagenten
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** – Entwickelt plattformübergreifende Apps mit koordinierten Subagenten
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** – Automatisiert CI/CD-, Monitoring- und Deployment-Workflows

### Subagenten-orchestrierte Workflows
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** – Multi-Plattform-Features mit Backend-, Frontend- und Mobile-Subagenten
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** – Sicherheitsorientierte Implementierung mit spezialisierten Subagenten
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** – ML-basierte Features mit Data-Science-Subagenten
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** – End-to-End-Optimierung mit Performance-Subagenten
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** – Produktions-Störungsbehebung mit Ops-Subagenten

## 🔧 Tools (Einzweckbefehle)

### KI & Maschinelles Lernen
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** – Entwicklung von produktionsreifen KI-Assistenten und Chatbots
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** – Spezialisierte Reviews für KI/ML-Codebasen
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** – Erstellung von LangChain/LangGraph-Agenten mit modernen Mustern
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** – Erstellung von End-to-End-ML-Pipelines mit MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** – Optimierung von KI-Prompts für Leistung und Qualität

### Architektur & Codequalität
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** – Ausführliche Erklärungen komplexer Codes generieren
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** – Code-Migration zwischen Sprachen, Frameworks oder Versionen
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** – Refaktorierung von Code für Wartbarkeit und Leistung
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Technische Schulden analysieren und priorisieren

### Daten & Datenbank
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Skalierbare Datenpipeline-Architekturen entwerfen
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Umfassende Systeme zur Datenvalidierung implementieren
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Erweiterte Strategien für Datenbankmigration

### DevOps & Infrastruktur
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Bereitstellungskonfigurationen und Checklisten generieren
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Erweiterte Strategien zur Container-Optimierung
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Produktionsreife Kubernetes-Bereitstellungen
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Umfassendes Monitoring und Observability einrichten
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Service Level Objectives (SLOs) implementieren
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Entwicklungs- und Betriebsworkflows automatisieren

### Entwicklung & Test
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Realistische API-Mocks für Entwicklung und Test erstellen
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Produktionsreife API-Endpunkte mit vollständigem Implementierungsstack generieren
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Umfassende Test-Suiten mit Framework-Erkennung erstellen

### Sicherheit & Compliance
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Umfassende Barrierefreiheitstests und Korrekturen
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Einhaltung von Vorschriften sicherstellen (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Umfassende Sicherheitsüberprüfung mit automatisierter Behebung

### Debugging & Analyse
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Erweiterte Debugging- und Tracing-Strategien
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Tiefgehende Fehleranalyse und Lösungsstrategien
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Produktionsfehler nachverfolgen und diagnostizieren
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Gut strukturierte GitHub/GitLab-Issues erstellen

### Abhängigkeiten & Konfiguration
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Anwendungskonfiguration validieren und verwalten
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Abhängigkeiten auf Sicherheit und Lizenzierung prüfen
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Projektabhängigkeiten sicher aktualisieren

### Dokumentation & Zusammenarbeit
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Umfassende Dokumentation generieren
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Effektive Git-Workflows implementieren
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Pull Requests mit Qualitätsprüfungen verbessern

### Kostenoptimierung
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Cloud- und Infrastrukturkosten optimieren

### Onboarding & Einrichtung
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Entwicklungsumgebungen für neue Teammitglieder einrichten

### Subagenten-Tools
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Code-Review aus mehreren Perspektiven mit spezialisierten Subagenten
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Tiefgehendes Debugging mit Debugger- und Performance-Subagenten
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Full-Stack-Optimierung mit mehreren Subagenten
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Projektkontext mit Kontextmanager-Subagent speichern
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Gespeicherten Kontext für Kontinuität wiederherstellen

## Funktionen

- Produktionsreife Implementierungen
- Automatische Framework-Erkennung
- Sicherheits-Best Practices
- Integriertes Monitoring und Testing
- Befehle arbeiten nahtlos zusammen

## Befehlsanzahl

**Insgesamt: 52 produktionsreife Slash-Befehle** organisiert in:

### 🤖 Workflows (14 Befehle)

- Feature-Entwicklung & Review (3 Befehle)
- Automatisierung von Entwicklungsprozessen (6 Befehle)
- Subagenten-orchestrierte Workflows (5 Befehle)

### 🔧 Tools (38 Befehle)

- KI & Maschinelles Lernen (5 Befehle)
- Architektur & Codequalität (4 Befehle)
- Daten & Datenbank (3 Befehle)
- DevOps & Infrastruktur (6 Befehle)
- Entwicklung & Testing (3 Befehle)
- Sicherheit & Compliance (3 Befehle)
- Debugging & Analyse (4 Befehle)
- Abhängigkeiten & Konfiguration (3 Befehle)
- Dokumentation & Zusammenarbeit (1 Befehl)
- Onboarding & Einrichtung (1 Befehl)
- Subagent-spezifische Werkzeuge (5 Befehle)

## Anwendungsbeispiele

### 🤖 Workflow-Beispiele

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

### 🔧 Werkzeugbeispiele (Einzweckbefehle)

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

## Erweiterte Befehle

### Sicherheit & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Umfassender Sicherheitsscan mit automatisierter Behebung.

- **Multi-Tool-Scan**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automatisierte Behebungen**: Häufige Schwachstellen werden automatisch behoben
- **CI/CD-Integration**: Sicherheits-Gates für GitHub Actions/GitLab CI
- **Container-Scanning**: Schwachstellenanalyse von Images
- **Secret-Erkennung**: Integration von GitLeaks und TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Erweiterte Strategien zur Container-Optimierung.

- **Intelligente Optimierung**: Analysiert und schlägt Verbesserungen vor
- **Multi-Stage-Builds**: Framework-spezifisch optimierte Dockerfiles
- **Moderne Tools**: BuildKit, Bun, UV für schnellere Builds
- **Security-Hardening**: Distroless Images, Nicht-Root-Nutzer
- **Cross-Command-Integration**: Kompatibel mit /api-scaffold Ausgaben

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Produktionsreife Kubernetes-Deployments.

- **Erweiterte Muster**: Pod-Sicherheitsstandards, Netzwerk-Policies, OPA
- **GitOps-Ready**: FluxCD- und ArgoCD-Konfigurationen
- **Observability**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: HPA-, VPA- und Cluster-Autoscaler-Konfigurationen
- **Service Mesh**: Istio/Linkerd-Integration

### Frontend & Daten

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Fortschrittliche Strategien für Datenbankmigrationen.

- **Multi-Datenbank**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Kein-Ausfallzeit**: Blue-Green-Deployments, rollierende Migrationen
- **Event Sourcing**: Kafka/Kinesis-Integration für CDC
- **Plattformübergreifend**: Unterstützt polyglotte Persistenz
- **Überwachung**: Migrations-Gesundheitschecks und Rollback

## Kombination von Workflows und Tools

Die eigentliche Stärke liegt in der Kombination von Workflows und Tools für vollständige Entwicklungszyklen:

### Beispiel: Entwicklung eines neuen Features

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

### Beispiel: Modernisierung von Altsystem-Code

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

## Befehlsorchestrierungsmuster

Befehle können einzeln verwendet oder in leistungsstarken Mustern kombiniert werden:

### Sequentielle Ausführung
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Parallelanalyse
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iterative Verfeinerung
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Domänenübergreifende Integration
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Wann Workflows vs. Tools verwenden

### 🔀 Workflows & Subagenten-Tools
- **Problemlösung**: Analysiere und behebe Probleme adaptiv
- **Mehrere Perspektiven**: Koordiniere spezialisierte Subagenten
- **Komplexe Aufgaben**: Mehrstufige Prozesse über verschiedene Bereiche hinweg
- **Unbekannte Lösungen**: Subagenten bestimmen den Ansatz

### 🛠️ Spezialisierte Tools
- **Infrastruktur-Einrichtung**: Konfiguriere Umgebungen
- **Code-Generierung**: Erstelle spezifische Implementierungen
- **Analyse**: Erzeuge Berichte ohne Fehlerbehebung
- **Domänenaufgaben**: Hochspezialisierte Operationen

**Beispiele:**
- „Implementiere ein Benutzer-Authentifizierungssystem“ → `/workflows:feature-development`
- „Behebe Performance-Probleme im gesamten Stack“ → `/workflows:smart-fix`
- „Modernisiere Legacy-Monolith“ → `/workflows:legacy-modernize`

### 🔧 Tools verwenden, wenn:
- **Spezifische Expertise benötigt** – Klare, fokussierte Aufgabe in einem Bereich
- **Präzise Kontrolle gewünscht** – Details der Implementierung gezielt steuern
- **Teil eines manuellen Workflows** – Integration in bestehende Prozesse
- **Tiefe Spezialisierung erforderlich** – Expertenniveau der Umsetzung notwendig
- **Auf bestehender Arbeit aufbauen** – Vorherige Ergebnisse erweitern oder verfeinern

**Beispiele:**
- „Erstelle Kubernetes-Manifeste“ → `/tools:k8s-manifest`
- „Scanne nach Sicherheitslücken“ → `/tools:security-scan`
- „Generiere API-Dokumentation“ → `/tools:doc-generate`

## Befehlsformat

Slash-Commands sind einfache Markdown-Dateien, bei denen:
- Der Dateiname zum Befehlsnamen wird (z. B. `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Der Dateiinhalte ist die Aufforderung/Anweisung, die beim Aufruf ausgeführt wird
- Verwende den Platzhalter `$ARGUMENTS` für Benutzereingaben

## Best Practices

### Befehlsauswahl
- **Automatische Vorschläge von Claude Code** – Analysiert den Kontext und wählt optimale Befehle aus
- **Workflows für komplexe Aufgaben verwenden** – Subagenten koordinieren bereichsübergreifende Implementierungen
- **Tools für fokussierte Aufgaben nutzen** – Wende spezifische Befehle für gezielte Verbesserungen an

### Effektive Nutzung
- **Umfassenden Kontext bereitstellen** – Tech-Stack, Einschränkungen und Anforderungen einbeziehen
- **Befehle strategisch verketten** – Workflows → Tools → Verfeinerungen
- **Auf vorherigen Ausgaben aufbauen** – Befehle sind darauf ausgelegt, zusammenzuarbeiten

## Beitrag leisten

1. Erstelle eine `.md`-Datei in `workflows/` oder `tools/`
2. Verwende kleingeschriebene Namen mit Bindestrich
3. Füge `$ARGUMENTS` für Benutzereingaben hinzu

## Fehlerbehebung

**Befehl nicht gefunden**:
- Prüfe, ob die Dateien in `~/.claude/commands/tools/` oder `~/.claude/commands/workflows/` liegen
- Verwende das korrekte Präfix: `/tools:befehl-name` oder `/workflows:befehl-name`
- Oder Verzeichnisse flach halten, falls keine Präfixe gewünscht: `cp tools/*.md . && cp workflows/*.md .`

**Workflows langsam**: Normal – sie koordinieren mehrere Subagenten

**Generische Ausgabe**: Gib spezifischeren Kontext zu deinem Tech-Stack an

**Integrationsprobleme**: Überprüfe Dateipfade und Befehlsreihenfolge

## Leistungstipps

**Befehlsauswahl:**
- **Workflows**: Koordination mehrerer Subagenten für komplexe Funktionen
- **Tools**: Einzelzweckoperationen für spezifische Aufgaben
- **Einfache Bearbeitungen**: Beim Hauptagenten bleiben

**Optimierung:**
- Beginne mit Tools für bekannte Probleme
- Detaillierte Anforderungen direkt bereitstellen
- Aufbau auf den vorherigen Befehlsausgaben
- Lassen Sie Workflows abschließen, bevor Sie Änderungen vornehmen

### Hinzufügen eines neuen Workflows:
- Fokus auf Subagenten-Orchestrierung und Delegationslogik
- Geben Sie an, welche spezialisierten Subagenten verwendet werden und in welcher Reihenfolge
- Definieren Sie Koordinationsmuster zwischen den Subagenten

### Hinzufügen eines neuen Tools:
- Fügen Sie vollständige, produktionsreife Implementierungen bei
- Strukturieren Sie den Inhalt mit klaren Abschnitten und umsetzbaren Ergebnissen
- Fügen Sie Beispiele, Best Practices und Integrationspunkte hinzu

## Mehr erfahren

- [Claude Code Dokumentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash-Befehle Dokumentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagenten Dokumentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagenten-Sammlung](https://github.com/wshobson/agents) - Spezialisierte Subagenten, die von diesen Befehlen verwendet werden


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---