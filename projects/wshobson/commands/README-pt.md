
<div align="right">
  <details>
    <summary >🌐 Idioma</summary>
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

# Comandos Claude Code Slash

Comandos slash prontos para produção para o [Claude Code](https://docs.anthropic.com/en/docs/claude-code) que aceleram o desenvolvimento por meio de automação inteligente.

**52 comandos** organizados como:
- **🤖 Fluxos de Trabalho**: Orquestração de múltiplos subagentes para tarefas complexas
- **🔧 Ferramentas**: Utilitários de propósito único para operações específicas

### 🤝 Requer Subagentes Claude Code

Esses comandos funcionam com os [Subagentes Claude Code](https://github.com/wshobson/agents) para capacidades de orquestração.

## Instalação

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Comandos Disponíveis

- **🤖 Workflows** - Orquestra múltiplos subagentes para tarefas complexas
- **🔧 Ferramentas** - Comandos de propósito único para operações específicas

## Uso

Os comandos estão organizados nos diretórios `tools/` e `workflows/`. Use-os com o prefixo do diretório:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Observação:** Se você preferir usar comandos sem prefixos, pode achatar os diretórios:
```bash
cp tools/*.md .
cp workflows/*.md .
```

O Claude Code sugere automaticamente comandos relevantes com base no contexto.

## 🤖 Workflows

Orquestração de múltiplos subagentes para tarefas complexas:

### Desenvolvimento de Funcionalidades
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Subagentes de backend, frontend, testes e implantação constroem funcionalidades completas
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Múltiplos subagentes de revisão fornecem análise abrangente de código
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analisa problemas e delega para subagentes especialistas apropriados

### Processos de Desenvolvimento
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implementa fluxos de trabalho Git eficazes com estratégias de ramificação e modelos de PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Melhora o desempenho dos subagentes através da otimização de prompts
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Moderniza bases de código legadas usando subagentes especializados
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Cria pipelines de ML com subagentes de engenharia de dados e ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Constrói aplicativos multiplataforma com subagentes coordenados
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automatiza workflows de CI/CD, monitoramento e implantação

### Workflows Orquestrados por Subagentes
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Funcionalidades multiplataforma com subagentes de backend, frontend e mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Implementação focada em segurança com subagentes especializados
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Funcionalidades impulsionadas por ML com subagentes de ciência de dados
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Otimização ponta a ponta com subagentes de desempenho
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Resolução de incidentes em produção com subagentes de operações

## 🔧 Ferramentas (Comandos de Propósito Único)

### IA & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Construa assistentes de IA prontos para produção e chatbots
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Revisão especializada para bases de código de IA/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Crie agentes LangChain/LangGraph com padrões modernos
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Crie pipelines de ML ponta a ponta com MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Otimize prompts de IA para desempenho e qualidade

### Arquitetura & Qualidade de Código
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Gere explicações detalhadas de código complexo
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migre código entre linguagens, frameworks ou versões
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refatore código para melhor manutenção e desempenho
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analisar e priorizar dívida técnica

### Dados & Banco de Dados
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Projetar arquiteturas escaláveis de pipeline de dados
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implementar sistemas abrangentes de validação de dados
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Estratégias avançadas de migração de banco de dados

### DevOps & Infraestrutura
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Gerar configurações e checklists de implantação
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Estratégias avançadas de otimização de containers
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Implantações Kubernetes de nível de produção
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Configurar monitoramento e observabilidade abrangentes
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implementar Objetivos de Nível de Serviço (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automatizar fluxos de trabalho de desenvolvimento e operações

### Desenvolvimento & Testes
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Criar simulações realistas de API para desenvolvimento e testes
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Gerar endpoints de API prontos para produção com pilha completa de implementação
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Criar suítes de testes abrangentes com detecção de framework

### Segurança & Conformidade
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Teste de acessibilidade abrangente e correções
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Garantir conformidade regulatória (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Varredura de segurança abrangente com remediação automatizada

### Depuração & Análise
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Estratégias avançadas de depuração e rastreamento
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Análise profunda de padrões de erro e estratégias de resolução
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Rastrear e diagnosticar erros em produção
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Criar issues bem estruturados para GitHub/GitLab

### Dependências & Configuração
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Validar e gerenciar configuração de aplicações
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Auditar dependências quanto à segurança e licenciamento
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Atualizar dependências do projeto com segurança

### Documentação & Colaboração
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Gerar documentação abrangente
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implementar fluxos de trabalho Git eficazes
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Aprimorar pull requests com verificações de qualidade

### Otimização de Custos
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Otimize custos de nuvem e infraestrutura

### Integração & Configuração
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Configure ambientes de desenvolvimento para novos membros da equipe

### Ferramentas de Subagente
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Revisão de código sob múltiplas perspectivas com subagentes especializados
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Depuração profunda com subagentes de depuração e desempenho
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Otimização full-stack com múltiplos subagentes
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Salve contexto de projeto usando subagente gerenciador de contexto
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restaure o contexto salvo para continuidade

## Funcionalidades

- Implementações prontas para produção
- Detecção automática de framework
- Melhores práticas de segurança
- Monitoramento e testes integrados
- Comandos funcionam juntos de forma integrada

## Contagem de Comandos

**Total: 52 comandos prontos para produção** organizados em:

### 🤖 Workflows (14 comandos)

- Desenvolvimento de Funcionalidades & Revisão (3 comandos) 
- Automação de Processos de Desenvolvimento (6 comandos)
- Workflows Orquestrados por Subagentes (5 comandos)

### 🔧 Ferramentas (38 comandos)

- IA & Aprendizado de Máquina (5 comandos)
- Arquitetura & Qualidade de Código (4 comandos)
- Dados & Banco de Dados (3 comandos)
- DevOps & Infraestrutura (6 comandos)
- Desenvolvimento & Testes (3 comandos)
- Segurança & Conformidade (3 comandos)
- Depuração e Análise (4 comandos)
- Dependências e Configuração (3 comandos)
- Documentação e Colaboração (1 comando)
- Integração Inicial e Configuração (1 comando)
- Ferramentas Específicas do Subagente (5 comandos)

## Exemplos de Uso

### 🤖 Exemplos de Fluxo de Trabalho

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

### 🔧 Exemplos de Ferramentas (Comandos de Propósito Único)

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

## Comandos Avançados

### Segurança & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Varredura de segurança abrangente com correção automatizada.

- **Varredura Multi-Ferramenta**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Correções Automatizadas**: Vulnerabilidades comuns corrigidas automaticamente
- **Integração CI/CD**: Barreiras de segurança para GitHub Actions/GitLab CI
- **Varredura de Containers**: Análise de vulnerabilidades de imagens
- **Detecção de Segredos**: Integração GitLeaks e TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Estratégias avançadas de otimização de containers.

- **Otimização Inteligente**: Analisa e sugere melhorias
- **Builds Multi-Estágio**: Dockerfiles otimizados específicos para frameworks
- **Ferramentas Modernas**: BuildKit, Bun, UV para builds mais rápidos
- **Fortalecimento de Segurança**: Imagens distroless, usuários não-root
- **Integração entre Comandos**: Funciona com saídas do /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Implantações Kubernetes de nível de produção.

- **Padrões Avançados**: Pod Security Standards, Network Policies, OPA
- **Pronto para GitOps**: Configurações FluxCD e ArgoCD
- **Observabilidade**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: Configurações HPA, VPA e cluster autoscaler
- **Service Mesh**: Integração Istio/Linkerd

### Frontend & Dados

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Estratégias avançadas de migração de banco de dados.

- **Multi-Banco de Dados**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Deployments blue-green, migrações contínuas
- **Event Sourcing**: Integração com Kafka/Kinesis para CDC
- **Cross-Platform**: Suporta persistência poliglota
- **Monitoramento**: Verificações de integridade da migração e rollback

## Combinando Fluxos de Trabalho e Ferramentas

O verdadeiro poder vem da combinação de fluxos de trabalho e ferramentas para ciclos completos de desenvolvimento:

### Exemplo: Construindo uma Nova Funcionalidade

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

### Exemplo: Modernizando Código Legado

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

## Padrões de Orquestração de Comandos

Os comandos podem ser usados individualmente ou combinados em padrões poderosos:

### Execução Sequencial
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Análise Paralela
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Refinamento Iterativo
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Integração entre Domínios
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Quando Usar Workflows vs Ferramentas

### 🔀 Workflows & Ferramentas de Subagente
- **Resolução de problemas**: Analisar e corrigir problemas de forma adaptativa
- **Múltiplas perspectivas**: Coordenar subagentes especialistas
- **Tarefas complexas**: Processos de múltiplas etapas em diferentes domínios
- **Soluções desconhecidas**: Permitir que subagentes determinem a abordagem

### 🛠️ Ferramentas Especializadas
- **Configuração de infraestrutura**: Configurar ambientes
- **Geração de código**: Criar implementações específicas
- **Análise**: Gerar relatórios sem correções
- **Tarefas de domínio**: Operações altamente especializadas

**Exemplos:**
- "Implementar sistema de autenticação de usuário" → `/workflows:feature-development`
- "Corrigir problemas de desempenho em toda a stack" → `/workflows:smart-fix`
- "Modernizar monolito legado" → `/workflows:legacy-modernize`

### 🔧 Use Ferramentas Quando:
- **Expertise específica necessária** - Tarefa clara e focada em um domínio
- **Controle preciso desejado** - Quer direcionar detalhes específicos da implementação
- **Parte de workflow manual** - Integração em processos já existentes
- **Especialização profunda requerida** - Necessidade de implementação em nível de especialista
- **Construindo sobre trabalho existente** - Melhorando ou refinando resultados prévios

**Exemplos:**
- "Criar manifestos Kubernetes" → `/tools:k8s-manifest`
- "Escanear por vulnerabilidades de segurança" → `/tools:security-scan`
- "Gerar documentação de API" → `/tools:doc-generate`

## Formato de Comando

Comandos de barra são arquivos markdown simples onde:
- O nome do arquivo vira o nome do comando (ex.: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- O conteúdo do arquivo é o prompt/instruções executados ao serem invocados
- Use o marcador `$ARGUMENTS` para entrada do usuário

## Melhores Práticas

### Seleção de Comandos
- **Deixe o Claude Code sugerir automaticamente** - Analisa o contexto e seleciona comandos ideais
- **Use workflows para tarefas complexas** - Subagentes coordenam implementações multidomínio
- **Use ferramentas para tarefas focadas** - Aplique comandos específicos para melhorias direcionadas

### Uso Eficaz
- **Forneça contexto abrangente** - Inclua stack tecnológica, restrições e requisitos
- **Encadeie comandos estrategicamente** - Workflows → Ferramentas → Refinamentos
- **Construa sobre saídas anteriores** - Os comandos são projetados para funcionar juntos

## Contribuindo

1. Crie arquivo `.md` em `workflows/` ou `tools/`
2. Use nomes-em-minúsculo-com-hífen
3. Inclua `$ARGUMENTS` para entrada do usuário

## Solução de Problemas

**Comando não encontrado**:
- Verifique se os arquivos estão em `~/.claude/commands/tools/` ou `~/.claude/commands/workflows/`
- Use o prefixo correto: `/tools:nome-do-comando` ou `/workflows:nome-do-comando`
- Ou achate os diretórios se preferir sem prefixos: `cp tools/*.md . && cp workflows/*.md .`

**Workflows lentos**: Normal - eles coordenam múltiplos subagentes

**Saída genérica**: Adicione contexto mais específico sobre sua stack tecnológica

**Problemas de integração**: Verifique os caminhos dos arquivos e sequência dos comandos

## Dicas de Desempenho

**Seleção de Comando:**
- **Workflows**: Coordenação multi-subagente para recursos complexos
- **Ferramentas**: Operações de propósito único para tarefas específicas
- **Edições simples**: Fique com o agente principal

**Otimização:**
- Comece com ferramentas para problemas conhecidos
- Forneça requisitos detalhados antecipadamente
- Construa com base nas saídas de comandos anteriores
- Deixe os fluxos de trabalho concluírem antes das modificações

### Adicionando um Novo Fluxo de Trabalho:
- Foque na orquestração e lógica de delegação de subagentes
- Especifique quais subagentes especializados usar e em que ordem
- Defina padrões de coordenação entre subagentes

### Adicionando uma Nova Ferramenta:
- Inclua implementações completas e prontas para produção
- Estruture o conteúdo com seções claras e saídas acionáveis
- Inclua exemplos, melhores práticas e pontos de integração

## Saiba Mais

- [Documentação do Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Documentação dos Comandos Slash](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Documentação de Subagentes](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Coleção de Subagentes Claude Code](https://github.com/wshobson/agents) - Subagentes especializados usados por estes comandos


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---