
<div align="right">
  <details>
    <summary >🌐 Lingua</summary>
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

# Comandi Slash Claude Code

Comandi slash pronti per la produzione per [Claude Code](https://docs.anthropic.com/en/docs/claude-code) che accelerano lo sviluppo tramite automazione intelligente.

**52 comandi** organizzati come:
- **🤖 Flussi di lavoro**: Orchestrazione multi-subagente per compiti complessi
- **🔧 Strumenti**: Utility monouso per operazioni specifiche

### 🤝 Richiede Subagenti Claude Code

Questi comandi funzionano con i [Subagenti Claude Code](https://github.com/wshobson/agents) per capacità di orchestrazione.

## Installazione

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Comandi Disponibili

- **🤖 Flussi di lavoro** - Orchestrare più subagent per compiti complessi
- **🔧 Strumenti** - Comandi monouso per operazioni specifiche

## Utilizzo

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code suggerisce automaticamente i comandi rilevanti in base al contesto.

## 🤖 Workflow

Orchestrazione multi-subagente per compiti complessi:

### Sviluppo di Funzionalità
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagenti backend, frontend, testing e deployment costruiscono funzionalità complete
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Più subagenti di revisione forniscono un’analisi del codice approfondita
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analizza i problemi e delega agli specialisti appropriati

### Processi di Sviluppo
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementa workflow Git efficaci con strategie di branching e template PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Migliora le prestazioni dei subagenti tramite ottimizzazione dei prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernizza codebase legacy tramite subagenti specializzati
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crea pipeline ML con subagenti di data e ML engineering
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Costruisce app multipiattaforma con subagenti coordinati
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatizza workflow CI/CD, monitoraggio e deployment

### Workflow Orchestrati da Subagenti
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funzionalità multipiattaforma con subagenti backend, frontend e mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementazione security-first con subagenti specializzati
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funzionalità basate su ML con subagenti di data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Ottimizzazione end-to-end con subagenti di performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Risoluzione incidenti in produzione con subagenti ops

## 🔧 Strumenti (Comandi Monouso)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Costruisci assistenti AI e chatbot pronti per la produzione
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revisione specializzata per codebase AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Crea agenti LangChain/LangGraph con pattern moderni
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Crea pipeline ML end-to-end con MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Ottimizza prompt AI per performance e qualità

### Architettura & Qualità del Codice
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Genera spiegazioni dettagliate di codice complesso
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migra codice tra linguaggi, framework o versioni
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Rifattorizza il codice per manutenibilità e performance
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analizza e prioritizza il debito tecnico

### Dati & Database
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Progetta architetture di data pipeline scalabili
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementa sistemi completi di validazione dati
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Strategie avanzate di migrazione database

### DevOps & Infrastruttura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Genera configurazioni e checklist di deployment
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Strategie avanzate di ottimizzazione container
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Deployment Kubernetes di livello produzione
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configura monitoraggio e osservabilità completi
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementa Service Level Objectives (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatizza workflow di sviluppo e operativi

### Sviluppo & Testing
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Crea mock API realistici per sviluppo e testing
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Genera endpoint API pronti per la produzione con stack completo
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Crea suite di test complete con rilevamento framework

### Sicurezza & Conformità
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Test di accessibilità completi e correzioni
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Garantisce la conformità normativa (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Scansione di sicurezza completa con remediation automatica

### Debug & Analisi
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Strategie avanzate di debug e tracing
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analisi approfondita dei pattern di errore e strategie di risoluzione
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Traccia e diagnostica errori in produzione
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Crea issue GitHub/GitLab ben strutturate

### Dipendenze & Configurazione
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valida e gestisce la configurazione delle applicazioni
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Effettua audit delle dipendenze per sicurezza e licenze
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Aggiorna in sicurezza le dipendenze di progetto

### Documentazione & Collaborazione
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Genera documentazione completa
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementa workflow Git efficaci
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Migliora le pull request con controlli di qualità

### Ottimizzazione dei Costi
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Ottimizza i costi cloud e infrastrutturali

### Onboarding & Setup
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configura ambienti di sviluppo per nuovi membri del team

### Strumenti per Subagenti
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Code review multiprospettiva con subagenti specializzati
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Debug approfondito con subagenti debugger e performance
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Ottimizzazione full-stack con più subagenti
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Salva il contesto di progetto tramite subagente context-manager
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Ripristina il contesto salvato per la continuità

## Funzionalità

- Implementazioni pronte per la produzione
- Rilevamento automatico dei framework
- Best practice di sicurezza
- Monitoraggio e testing integrati

- I comandi funzionano insieme senza problemi

## Conteggio Comandi

**Totale: 52 comandi slash pronti per la produzione** organizzati in:

### 🤖 Flussi di lavoro (14 comandi)

- Sviluppo e revisione funzionalità (3 comandi)
- Automazione del processo di sviluppo (6 comandi)
- Flussi di lavoro orchestrati da subagent (5 comandi)

### 🔧 Strumenti (38 comandi)

- AI & Machine Learning (5 comandi)
- Architettura & Qualità del codice (4 comandi)
- Dati & Database (3 comandi)
- DevOps & Infrastruttura (6 comandi)
- Sviluppo & Testing (3 comandi)
- Sicurezza & Conformità (3 comandi)
- Debugging & Analisi (4 comandi)
- Dipendenze & Configurazione (3 comandi)
- Documentazione & Collaborazione (1 comando)
- Onboarding & Setup (1 comando)
- Strumenti specifici per subagent (5 comandi)

## Esempi d’Uso

### 🤖 Esempi di Flussi di lavoro

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

### 🔧 Esempi di Strumenti (Comandi Monouso)

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

## Comandi Avanzati

### Sicurezza & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Scansione di sicurezza completa con rimedio automatico.

- **Scansione Multi-Strumento**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Correzioni Automatiche**: Vulnerabilità comuni risolte automaticamente
- **Integrazione CI/CD**: Gate di sicurezza per GitHub Actions/GitLab CI
- **Scansione di Container**: Analisi delle vulnerabilità delle immagini
- **Rilevamento Segreti**: Integrazione con GitLeaks e TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Strategie avanzate di ottimizzazione dei container.

- **Ottimizzazione Intelligente**: Analizza e suggerisce miglioramenti
- **Build Multi-Stadio**: Dockerfile ottimizzati per framework specifici
- **Strumenti Moderni**: BuildKit, Bun, UV per build più veloci
- **Rafforzamento della Sicurezza**: Immagini distroless, utenti non-root
- **Integrazione Cross-Command**: Funziona con gli output di /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Deployment Kubernetes di livello produzione.

- **Pattern Avanzati**: Pod Security Standards, Network Policies, OPA
- **Pronto per GitOps**: Configurazioni FluxCD e ArgoCD
- **Osservabilità**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: Configurazioni HPA, VPA e cluster autoscaler
- **Service Mesh**: Integrazione con Istio/Linkerd

### Frontend & Dati

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Strategie avanzate di migrazione database.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Deployment blue-green, migrazioni rolling
- **Event Sourcing**: Integrazione Kafka/Kinesis per CDC
- **Cross-Platform**: Gestisce persistenza poliglotta
- **Monitoraggio**: Controlli salute migrazione e rollback

## Combinare Workflow e Strumenti

La vera potenza deriva dalla combinazione di workflow e strumenti per cicli di sviluppo completi:

### Esempio: Sviluppare una Nuova Funzionalità

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

### Esempio: Modernizzazione del Codice Legacy

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

## Modelli di orchestrazione dei comandi

I comandi possono essere utilizzati singolarmente o combinati in schemi potenti:

### Esecuzione sequenziale
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Analisi Parallela
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Perfezionamento Iterativo
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Integrazione tra Domini
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## Quando usare Workflow vs Strumenti

### 🔀 Workflow & Strumenti Subagente
- **Risoluzione di problemi**: Analizza e correggi problemi in modo adattivo
- **Prospettive multiple**: Coordina subagenti specialistici
- **Compiti complessi**: Processi multi-step tra domini diversi
- **Soluzioni sconosciute**: Lascia che i subagenti decidano l’approccio

### 🛠️ Strumenti specializzati
- **Configurazione infrastruttura**: Configura ambienti
- **Generazione di codice**: Crea implementazioni specifiche
- **Analisi**: Genera report senza correzioni
- **Attività di dominio**: Operazioni altamente specializzate

**Esempi:**
- "Implementa sistema di autenticazione utente" → `/feature-development`
- "Correggi problemi di performance su tutto lo stack" → `/smart-fix`
- "Modernizza monolite legacy" → `/legacy-modernize`

### 🔧 Usa strumenti quando:
- **Serve competenza specifica** - Compito chiaro e mirato in un solo dominio
- **Desiderio di controllo preciso** - Vuoi dirigere dettagli di implementazione specifici
- **Parte di workflow manuale** - Integrazione in processi esistenti
- **Richiesta di alta specializzazione** - Serve implementazione a livello esperto
- **Basarsi su lavoro esistente** - Migliorare o affinare output precedenti

**Esempi:**
- "Crea manifest Kubernetes" → `/k8s-manifest`
- "Scansiona vulnerabilità di sicurezza" → `/security-scan`
- "Genera documentazione API" → `/doc-generate`

## Formato Comando

Gli slash command sono semplici file markdown dove:
- Il nome del file diventa il nome del comando (es: `api-scaffold.md` → `/api-scaffold`)
- Il contenuto del file è il prompt/istruzioni eseguite quando invocato
- Usa il segnaposto `$ARGUMENTS` per input utente

## Best Practice

### Selezione dei Comandi
- **Lascia che Claude Code suggerisca automaticamente** - Analizza il contesto e seleziona i comandi ottimali
- **Usa workflow per compiti complessi** - I subagenti coordinano implementazioni multi-dominio
- **Usa strumenti per compiti mirati** - Applica comandi specifici per miglioramenti mirati

### Uso efficace
- **Fornisci contesto completo** - Includi stack tecnologico, vincoli e requisiti
- **Collega comandi strategicamente** - Workflow → Strumenti → Rifiniture
- **Basati su output precedenti** - I comandi sono progettati per lavorare insieme

## Contribuire

1. Crea file `.md` in `workflows/` o `tools/`
2. Usa nomi lowercase-con-trattini
3. Includi `$ARGUMENTS` per input utente

## Risoluzione dei problemi

**Comando non trovato**: Verifica che i file siano in `~/.claude/commands/`

**Workflow lenti**: Normale - coordinano più subagenti

**Output generico**: Aggiungi contesto più specifico sul tuo stack tecnologico

**Problemi di integrazione**: Verifica percorsi file e sequenza comandi

## Suggerimenti sulle prestazioni

**Selezione comandi:**
- **Workflow**: Coordinazione multi-subagente per funzionalità complesse
- **Strumenti**: Operazioni mirate per compiti specifici
- **Modifiche semplici**: Rimani con l’agente principale

**Ottimizzazione:**
- Inizia con strumenti per problemi noti
- Fornisci requisiti dettagliati subito
- Basati sugli output dei comandi precedenti
- Lascia che i workflow completino prima di apportare modifiche

### Aggiunta di un nuovo Workflow:
- Concentrati su orchestrazione e logica di delega tra subagenti
- Specifica quali subagenti specializzati usare e in che ordine
- Definisci schemi di coordinazione tra subagenti

### Aggiunta di un nuovo Strumento:
- Includi implementazioni complete pronte per la produzione
- Struttura il contenuto con sezioni chiare e output azionabili
- Includi esempi, best practice e punti di integrazione

## Per saperne di più

- [Documentazione Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentazione Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentazione Subagenti](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Collezione Subagenti](https://github.com/wshobson/agents) - Subagenti specializzati utilizzati da questi comandi


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---