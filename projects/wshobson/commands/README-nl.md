
<div align="right">
  <details>
    <summary >🌐 Taal</summary>
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

Productieklaar slashcommando's voor [Claude Code](https://docs.anthropic.com/en/docs/claude-code) die ontwikkeling versnellen via intelligente automatisering.

**52 commando's** georganiseerd als:
- **🤖 Workflows**: Multi-subagent orkestratie voor complexe taken
- **🔧 Tools**: Hulpmiddelen met één doel voor specifieke operaties

### 🤝 Vereist Claude Code Subagents

Deze commando's werken met de [Claude Code Subagents](https://github.com/wshobson/agents) voor orkestratie-mogelijkheden.

## Installatie

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Beschikbare Commando's

- **🤖 Workflows** - Orkestreer meerdere subagenten voor complexe taken
- **🔧 Tools** - Enkelvoudige commando's voor specifieke bewerkingen

## Gebruik

Commando's zijn georganiseerd in de mappen `tools/` en `workflows/`. Gebruik ze met de mapvoorvoegsel:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Opmerking:** Als u liever opdrachten zonder prefix gebruikt, kunt u de mappenstructuur plat maken:
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code suggereert automatisch relevante commando's op basis van de context.

## 🤖 Workflows

Multi-subagent orkestratie voor complexe taken:

### Featureontwikkeling
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Backend, frontend, testen en deployment subagents bouwen complete features
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Meerdere review subagents bieden uitgebreide codeanalyse
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analyseert problemen en delegeert naar geschikte specialist subagents

### Ontwikkelingsprocessen
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementeert effectieve Git-workflows met branchingstrategieën en PR-sjablonen
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Verbetert subagentprestaties door promptoptimalisatie
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Moderniseert legacy-codebases met gespecialiseerde subagents
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Creëert ML-pijplijnen met data- en ML-engineering subagents
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Bouwt cross-platform apps met gecoördineerde subagents
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatiseert CI/CD, monitoring en deployment workflows

### Subagent-georkestreerde workflows
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Multi-platform features met backend-, frontend- en mobiele subagents
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Security-first implementatie met gespecialiseerde subagents
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ML-gedreven features met data science subagents
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - End-to-end optimalisatie met performance subagents
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Productie-incidentoplossing met ops subagents

## 🔧 Tools (Single-Purpose Commands)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Bouw productieklare AI-assistenten en chatbots
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Gespecialiseerde review voor AI/ML-codebases
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Maak LangChain/LangGraph agents met moderne patronen
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Creëer end-to-end ML-pijplijnen met MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimaliseer AI-prompts voor prestatie en kwaliteit

### Architectuur & Codekwaliteit
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Genereer gedetailleerde uitleg van complexe code
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migreer code tussen talen, frameworks of versies
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Herstructureer code voor onderhoudbaarheid en prestatie
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analyseer en prioriteer technische schuld

### Data & Database
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Ontwerp schaalbare data-pijplijnarchitecturen
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementeer uitgebreide datavalidatiesystemen
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Geavanceerde strategieën voor database-migratie

### DevOps & Infrastructuur
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Genereer implementatieconfiguraties en checklists
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Geavanceerde container optimalisatiestrategieën
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Kubernetes-implementaties van productieklasse
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Stel uitgebreide monitoring en observatie in
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementeer Service Level Objectives (SLO’s)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatiseer ontwikkelings- en operationele workflows

### Ontwikkeling & Testen
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Maak realistische API-mocks voor ontwikkeling en testen
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Genereer productieklare API-endpoints met volledige implementatiestack
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Maak uitgebreide testsuites met frameworkdetectie

### Beveiliging & Compliance
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Uitgebreide toegankelijkheidstests en oplossingen
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Zorg voor naleving van regelgeving (AVG, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Uitgebreide beveiligingsscan met geautomatiseerde herstelacties

### Debuggen & Analyse
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Geavanceerde debugging- en traceerstrategieën
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Diepe analyse van foutpatronen en oplossingsstrategieën
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Traceer en diagnoseer productiefouten
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Maak goed gestructureerde GitHub/GitLab-issues

### Afhankelijkheden & Configuratie
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valideer en beheer applicatieconfiguratie
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Controleer afhankelijkheden op beveiliging en licenties
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Upgrade projectafhankelijkheden veilig

### Documentatie & Samenwerking
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Genereer uitgebreide documentatie
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementeer effectieve Git-workflows
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Verbeter pull requests met kwaliteitscontroles

### Kostenoptimalisatie
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimaliseer cloud- en infrastructuurkosten

### Onboarding & Setup
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Richt ontwikkelomgevingen in voor nieuwe teamleden

### Subagent Tools
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Code review vanuit meerdere perspectieven met gespecialiseerde subagenten
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Diepgaand debuggen met debugger- en prestatie-subagenten
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Full-stack optimalisatie met meerdere subagenten
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Sla projectcontext op met de context-manager subagent
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Herstel opgeslagen context voor continuïteit

## Functionaliteiten

- Productieklaar geïmplementeerd
- Automatische frameworkdetectie
- Beste beveiligingspraktijken
- Ingebouwde monitoring en testen
- Commando's werken naadloos samen

## Aantal Commando's

**Totaal: 52 productieklare slash-commando's** georganiseerd in:

### 🤖 Workflows (14 commando's)

- Functieontwikkeling & Review (3 commando's) 
- Automatisering van ontwikkelprocessen (6 commando's)
- Subagent-georkestreerde workflows (5 commando's)

### 🔧 Tools (38 commando's)

- AI & Machine Learning (5 commando's)
- Architectuur & Codekwaliteit (4 commando's)
- Data & Database (3 commando's)
- DevOps & Infrastructuur (6 commando's)
- Ontwikkeling & Testen (3 commando's)
- Beveiliging & Compliance (3 commando's)
- Debuggen & Analyse (4 commando's)
- Afhankelijkheden & Configuratie (3 commando's)
- Documentatie & Samenwerking (1 commando)
- Onboarding & Installatie (1 commando)
- Subagent-specifieke tools (5 commando's)

## Voorbeelden van gebruik

### 🤖 Voorbeelden van workflows

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

### 🔧 Voorbeelden van hulpmiddelen (commando's met één doel)

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

## Verbeterde Commando's

### Security & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Uitgebreide beveiligingsscan met geautomatiseerde oplossingen.

- **Multi-Tool Scanning**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automatische Oplossingen**: Veelvoorkomende kwetsbaarheden automatisch opgelost
- **CI/CD Integratie**: Beveiligingspoorten voor GitHub Actions/GitLab CI
- **Container Scanning**: Analyse van kwetsbaarheden in images
- **Geheimendetectie**: Integratie met GitLeaks en TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Geavanceerde strategieën voor containeroptimalisatie.

- **Slimme Optimalisatie**: Analyseert en stelt verbeteringen voor
- **Multi-Stage Builds**: Framework-specifieke geoptimaliseerde Dockerfiles
- **Moderne Tools**: BuildKit, Bun, UV voor snellere builds
- **Security Hardening**: Distroless images, non-root gebruikers
- **Cross-Command Integratie**: Werkt met /api-scaffold outputs

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Productieklare Kubernetes-deployments.

- **Geavanceerde Patronen**: Pod Security Standards, Netwerkbeleid, OPA
- **GitOps Klaar**: Configuraties voor FluxCD en ArgoCD
- **Observability**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: HPA, VPA en cluster autoscaler configuraties
- **Service Mesh**: Integratie met Istio/Linkerd

### Frontend & Data

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Geavanceerde strategieën voor database-migratie.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Blue-green deployments, rollende migraties
- **Event Sourcing**: Kafka/Kinesis-integratie voor CDC
- **Cross-Platform**: Beheert polyglot persistentie
- **Monitoring**: Gezondheidscontroles en rollback van migraties

## Workflows en Tools Combineren

De echte kracht komt voort uit het combineren van workflows en tools voor volledige ontwikkelcycli:

### Voorbeeld: Een Nieuwe Feature Bouwen

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

### Voorbeeld: Modernisering van legacy-code

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

## Patronen voor Command Orchestratie

Commando's kunnen afzonderlijk worden gebruikt of gecombineerd in krachtige patronen:

### Sequentiële Uitvoering
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Parallelle Analyse
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iteratieve verfijning
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integratie tussen domeinen
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Wanneer Workflows vs Tools te Gebruiken

### 🔀 Workflows & Subagent Tools
- **Probleemoplossing**: Analyseer en los problemen adaptief op
- **Meerdere perspectieven**: Coördineer specialistische subagenten
- **Complexe taken**: Meerstapsprocessen over domeinen heen
- **Onbekende oplossingen**: Laat subagenten de aanpak bepalen

### 🛠️ Gespecialiseerde Tools
- **Infrastructuur opzetten**: Configureer omgevingen
- **Codegeneratie**: Maak specifieke implementaties
- **Analyse**: Genereer rapporten zonder oplossingen
- **Domeintaken**: Sterk gespecialiseerde operaties

**Voorbeelden:**
- "Implementeer gebruikersauthenticatiesysteem" → `/workflows:feature-development`
- "Los prestatieproblemen over de stack op" → `/workflows:smart-fix`
- "Moderniseer legacy monoliet" → `/workflows:legacy-modernize`

### 🔧 Gebruik Tools Wanneer:
- **Specifieke expertise nodig** - Duidelijke, gerichte taak binnen één domein
- **Precieze controle gewenst** - Specifieke implementatiedetails aansturen
- **Deel van handmatige workflow** - Integreren in bestaande processen
- **Diepe specialisatie vereist** - Expert-niveau implementatie nodig
- **Voortbouwen op bestaand werk** - Verbeteren of verfijnen van eerdere output

**Voorbeelden:**
- "Maak Kubernetes manifests" → `/tools:k8s-manifest`
- "Scan op beveiligingslekken" → `/tools:security-scan`
- "Genereer API-documentatie" → `/tools:doc-generate`

## Opdrachtformaat

Slash commands zijn eenvoudige markdown-bestanden waarbij:
- De bestandsnaam de opdrachtnaam wordt (bijv. `tools/api-scaffold.md` → `/tools:api-scaffold`)
- De bestandsinhoud is de prompt/instructies die worden uitgevoerd bij oproepen
- Gebruik `$ARGUMENTS` placeholder voor gebruikersinvoer

## Best Practices

### Commandselectie
- **Laat Claude Code automatisch voorstellen** - Analyseert context en selecteert optimale commando's
- **Gebruik workflows voor complexe taken** - Subagenten coördineren multidomein-implementaties
- **Gebruik tools voor gerichte taken** - Pas specifieke commando's toe voor doelgerichte verbeteringen

### Effectief Gebruik
- **Geef uitgebreide context** - Voeg tech stack, beperkingen en vereisten toe
- **Schakel commando's strategisch** - Workflows → Tools → Verfijningen
- **Bouw voort op eerdere output** - Commando's zijn ontworpen om samen te werken

## Bijdragen

1. Maak een `.md` bestand in `workflows/` of `tools/`
2. Gebruik kleine letters en koppeltekens voor namen
3. Voeg `$ARGUMENTEN` toe voor gebruikersinput

## Problemen oplossen

**Commando niet gevonden**: 
- Controleer of bestanden in `~/.claude/commands/tools/` of `~/.claude/commands/workflows/` staan
- Gebruik het juiste prefix: `/tools:commando-naam` of `/workflows:commando-naam`
- Of maak mappen plat als je geen prefix wilt: `cp tools/*.md . && cp workflows/*.md .`

**Workflows traag**: Normaal - ze coördineren meerdere subagenten

**Generieke output**: Voeg meer specifieke context toe over je tech stack

**Integratieproblemen**: Controleer bestandslocaties en volgorde van commando's

## Prestatie Tips

**Commandoselectie:**
- **Workflows**: Multi-subagent coördinatie voor complexe functionaliteit
- **Tools**: Enkelvoudige operaties voor specifieke taken
- **Eenvoudige bewerkingen**: Blijf bij de hoofdagent

**Optimalisatie:**
- Begin met tools voor bekende problemen
- Geef gedetailleerde vereisten direct mee
- Bouw voort op eerdere uitvoer van commando's
- Laat workflows afronden voordat u wijzigingen aanbrengt

### Een nieuwe workflow toevoegen:
- Focus op orkestratie en delegatielogica van subagents
- Specificeer welke gespecialiseerde subagents worden gebruikt en in welke volgorde
- Definieer coördinatiepatronen tussen subagents

### Een nieuw hulpmiddel toevoegen:
- Voeg volledige, productieklare implementaties toe
- Structureer de inhoud met duidelijke secties en uitvoerbare resultaten
- Voeg voorbeelden, best practices en integratiepunten toe

## Meer informatie

- [Claude Code Documentatie](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Documentatie](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagents Documentatie](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collectie](https://github.com/wshobson/agents) - Gespecialiseerde subagents gebruikt door deze commando's


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---