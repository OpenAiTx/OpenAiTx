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
- **🔧 Strumenti**: Utilità monoscopo per operazioni specifiche


### 🤝 Richiede Claude Code Subagents

Questi comandi funzionano con i [Claude Code Subagents](https://github.com/wshobson/agents) per capacità di orchestrazione.

## Installazione

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Comandi Disponibili

- **🤖 Flussi di lavoro** - Orchestrare più subagenti per compiti complessi
- **🔧 Strumenti** - Comandi monouso per operazioni specifiche

## Utilizzo

I comandi sono organizzati nelle directory `tools/` e `workflows/`. Usali con il prefisso della directory:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Nota:** Se preferisci utilizzare i comandi senza prefissi, puoi appiattire le directory:
```bash
cp tools/*.md .
cp workflows/*.md .
```

Claude Code suggerisce automaticamente i comandi rilevanti in base al contesto.

## 🤖 Workflow

Orchestrazione multi-subagente per compiti complessi:

### Sviluppo di Funzionalità
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagenti backend, frontend, testing e deployment costruiscono funzionalità complete
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Diversi subagenti di revisione forniscono un'analisi del codice completa
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analizza i problemi e li delega ai subagenti specialisti appropriati

### Processi di Sviluppo
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementa workflow Git efficaci con strategie di branching e template per PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Migliora le prestazioni dei subagenti tramite l'ottimizzazione dei prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernizza codebase legacy tramite subagenti specializzati
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Crea pipeline ML con subagenti di data e ML engineering
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Costruisce app multipiattaforma con subagenti coordinati
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatizza i workflow CI/CD, monitoraggio e deployment

### Workflow Orchestrati da Subagenti
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funzionalità multipiattaforma con subagenti backend, frontend e mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementazione orientata alla sicurezza con subagenti specializzati
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funzionalità alimentate da ML con subagenti data science
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Ottimizzazione end-to-end con subagenti dedicati alle performance
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Risoluzione di incidenti in produzione con subagenti operativi

## 🔧 Strumenti (Comandi Monouso)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Crea assistenti AI e chatbot pronti per la produzione
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
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Progetta architetture scalabili per pipeline di dati
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementa sistemi completi di validazione dei dati
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Strategie avanzate di migrazione del database

### DevOps & Infrastruttura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Genera configurazioni e checklist di distribuzione
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Strategie avanzate di ottimizzazione dei container
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Deployment Kubernetes di livello produttivo
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configura monitoraggio e osservabilità completi
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementa gli Obiettivi di Livello di Servizio (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatizza i flussi di lavoro di sviluppo e operativi

### Sviluppo & Testing
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Crea mock API realistici per sviluppo e test
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Genera endpoint API pronti per la produzione con stack implementativo completo
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Crea suite di test complete con rilevamento framework

### Sicurezza & Compliance
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Test e correzioni completi sull'accessibilità
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Garantisce la conformità normativa (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Scansione di sicurezza completa con rimedio automatizzato

### Debug & Analisi
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Strategie avanzate di debug e tracciamento
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Analisi approfondita dei pattern di errore e strategie di risoluzione
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Traccia e diagnostica errori in produzione
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Crea issue strutturate su GitHub/GitLab

### Dipendenze & Configurazione
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Valida e gestisci la configurazione dell'applicazione
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Controlla le dipendenze per sicurezza e licenze
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Aggiorna in sicurezza le dipendenze del progetto

### Documentazione & Collaborazione
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Genera documentazione completa
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementa workflow Git efficaci
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Migliora le pull request con controlli di qualità

### Ottimizzazione dei Costi
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Ottimizza i costi di cloud e infrastruttura

### Onboarding & Configurazione
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configura ambienti di sviluppo per nuovi membri del team

### Strumenti Subagent
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revisione del codice da più prospettive con subagent specializzati
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Debug approfondito con subagent per debug e performance
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Ottimizzazione full-stack con molteplici subagent
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Salva il contesto del progetto usando il subagent context-manager
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Ripristina il contesto salvato per la continuità

## Funzionalità

- Implementazioni pronte per la produzione
- Rilevamento automatico del framework
- Best practice di sicurezza
- Monitoraggio e test integrati
- I comandi lavorano insieme in modo fluido

## Numero di Comandi

**Totale: 52 comandi slash pronti per la produzione** organizzati in:

### 🤖 Flussi di Lavoro (14 comandi)

- Sviluppo Funzionalità & Revisione (3 comandi)
- Automazione dei Processi di Sviluppo (6 comandi)
- Flussi di Lavoro Orchestrati da Subagent (5 comandi)

### 🔧 Strumenti (38 comandi)

- AI & Machine Learning (5 comandi)
- Architettura & Qualità del Codice (4 comandi)
- Dati & Database (3 comandi)
- DevOps & Infrastruttura (6 comandi)
- Sviluppo & Test (3 comandi)
- Sicurezza & Conformità (3 comandi)
- Debug & Analisi (4 comandi)
- Dipendenze & Configurazione (3 comandi)
- Documentazione & Collaborazione (1 comando)
- Onboarding & Configurazione (1 comando)
- Strumenti Specifici per Subagent (5 comandi)

## Esempi di Utilizzo

### 🤖 Esempi di Workflow

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

### 🔧 Esempi di Strumenti (Comandi Monouso)

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

## Comandi Avanzati

### Sicurezza & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Scansione di sicurezza completa con rimedio automatico.

- **Scansione Multi-Strumento**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Correzioni Automatiche**: Vulnerabilità comuni risolte automaticamente
- **Integrazione CI/CD**: Barriere di sicurezza per GitHub Actions/GitLab CI
- **Scansione Container**: Analisi delle vulnerabilità delle immagini
- **Rilevamento Segreti**: Integrazione con GitLeaks e TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Strategie avanzate di ottimizzazione dei container.

- **Ottimizzazione Intelligente**: Analizza e suggerisce miglioramenti
- **Build Multi-Stadio**: Dockerfile ottimizzati per framework specifici
- **Strumenti Moderni**: BuildKit, Bun, UV per build più veloci
- **Rinforzo della Sicurezza**: Immagini distroless, utenti non-root
- **Integrazione Cross-Command**: Funziona con gli output di /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Deployment Kubernetes di livello produttivo.

- **Pattern Avanzati**: Pod Security Standards, Network Policies, OPA
- **Pronto per GitOps**: Configurazioni FluxCD e ArgoCD
- **Osservabilità**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: Configurazioni HPA, VPA e cluster autoscaler
- **Service Mesh**: Integrazione con Istio/Linkerd

### Frontend & Dati

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Strategie avanzate di migrazione database.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Deployment blue-green, migrazioni progressive
- **Event Sourcing**: Integrazione Kafka/Kinesis per CDC
- **Cross-Platform**: Gestisce la persistenza poliglotta
- **Monitoring**: Verifiche dello stato delle migrazioni e rollback

## Combinare flussi di lavoro e strumenti

La vera potenza deriva dalla combinazione di flussi di lavoro e strumenti per cicli di sviluppo completi:

### Esempio: Sviluppare una nuova funzionalità

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

### Esempio: Modernizzazione del Codice Legacy

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

## Modelli di orchestrazione dei comandi

I comandi possono essere utilizzati singolarmente o combinati in schemi potenti:

### Esecuzione sequenziale
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Analisi Parallela
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Perfezionamento Iterativo
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integrazione tra Domini
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Quando usare Workflow vs Strumenti

### 🔀 Workflow & Strumenti Subagente
- **Risoluzione di problemi**: Analizza e risolvi problemi in modo adattivo
- **Prospettive multiple**: Coordina subagenti specialisti
- **Compiti complessi**: Processi multi-step tra domini
- **Soluzioni sconosciute**: Lascia decidere ai subagenti l'approccio

### 🛠️ Strumenti Specializzati
- **Configurazione infrastruttura**: Configura ambienti
- **Generazione codice**: Crea implementazioni specifiche
- **Analisi**: Genera report senza correzioni
- **Compiti di dominio**: Operazioni altamente specializzate

**Esempi:**
- "Implementa sistema di autenticazione utenti" → `/workflows:feature-development`
- "Correggi problemi di performance nello stack" → `/workflows:smart-fix`
- "Modernizza il monolite legacy" → `/workflows:legacy-modernize`

### 🔧 Usa Strumenti Quando:
- **Serve competenza specifica** - Compito chiaro e mirato in un solo dominio
- **Desideri controllo preciso** - Vuoi dirigere dettagli di implementazione specifici
- **Parte di workflow manuale** - Integrazione in processi esistenti
- **Specializzazione profonda necessaria** - Serve implementazione di livello esperto
- **Costruire su lavoro esistente** - Migliorare o affinare risultati precedenti

**Esempi:**
- "Crea manifest Kubernetes" → `/tools:k8s-manifest`
- "Scansiona vulnerabilità di sicurezza" → `/tools:security-scan`
- "Genera documentazione API" → `/tools:doc-generate`

## Formato Comandi

Gli slash command sono semplici file markdown dove:
- Il nome del file diventa il nome del comando (es. `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Il contenuto del file è il prompt/istruzioni eseguite quando invocato
- Usa il segnaposto `$ARGUMENTS` per l'input dell'utente

## Best Practice

### Selezione dei Comandi
- **Lascia che Claude Code suggerisca automaticamente** - Analizza il contesto e seleziona i comandi ottimali
- **Usa workflow per compiti complessi** - I sottoagenti coordinano implementazioni multidominio
- **Usa strumenti per compiti mirati** - Applica comandi specifici per miglioramenti mirati

### Uso Efficace
- **Fornisci un contesto completo** - Includi stack tecnologico, vincoli e requisiti
- **Collega strategicamente i comandi** - Workflow → Strumenti → Raffinamenti
- **Costruisci sui risultati precedenti** - I comandi sono progettati per lavorare insieme

## Contribuire

1. Crea un file `.md` in `workflows/` o `tools/`
2. Usa nomi con trattino e minuscole
3. Includi `$ARGUMENTS` per l'input dell’utente

## Risoluzione dei Problemi

**Comando non trovato**: 
- Controlla che i file siano in `~/.claude/commands/tools/` o `~/.claude/commands/workflows/`
- Usa il prefisso corretto: `/tools:nome-comando` o `/workflows:nome-comando`
- Oppure appiattisci le directory se preferisci senza prefissi: `cp tools/*.md . && cp workflows/*.md .`

**Workflow lenti**: Normale - coordinano più sottoagenti

**Output generico**: Aggiungi un contesto più specifico sul tuo stack tecnologico

**Problemi di integrazione**: Verifica i percorsi dei file e la sequenza dei comandi

## Suggerimenti sulle Prestazioni

**Selezione dei Comandi:**
- **Workflow**: Coordinamento multi-sottoagente per funzionalità complesse
- **Strumenti**: Operazioni monoscopo per compiti specifici
- **Modifiche semplici**: Rimani con l’agente principale

**Ottimizzazione:**
- Parti dagli strumenti per problemi noti
- Fornisci requisiti dettagliati fin dall’inizio
- Basarsi sui risultati dei comandi precedenti
- Lasciare che i workflow si completino prima delle modifiche

### Aggiunta di un Nuovo Workflow:
- Concentrarsi sull’orchestrazione e sulla logica di delega dei subagent
- Specificare quali subagent specializzati utilizzare e in quale ordine
- Definire i modelli di coordinamento tra i subagent

### Aggiunta di un Nuovo Strumento:
- Includere implementazioni complete e pronte per la produzione
- Strutturare il contenuto con sezioni chiare e output operativi
- Includere esempi, best practice e punti di integrazione

## Per Saperne di Più

- [Documentazione Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentazione Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentazione Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Collezione Claude Code Subagents](https://github.com/wshobson/agents) - Subagent specializzati utilizzati da questi comandi


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---