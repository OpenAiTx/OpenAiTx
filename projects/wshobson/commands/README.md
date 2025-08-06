# Claude Code Slash Commands

Production-ready slash commands for [Claude Code](https://docs.anthropic.com/en/docs/claude-code) that accelerate development through intelligent automation.

**52 commands** organized as:
- **🤖 Workflows**: Multi-subagent orchestration for complex tasks
- **🔧 Tools**: Single-purpose utilities for specific operations

### 🤝 Requires Claude Code Subagents

These commands work with the [Claude Code Subagents](https://github.com/wshobson/agents) for orchestration capabilities.

## Installation

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Available Commands

- **🤖 Workflows** - Orchestrate multiple subagents for complex tasks
- **🔧 Tools** - Single-purpose commands for specific operations

## Usage

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```

Claude Code automatically suggests relevant commands based on context.

## 🤖 Workflows

Multi-subagent orchestration for complex tasks:

### Feature Development
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Backend, frontend, testing, and deployment subagents build complete features
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Multiple review subagents provide comprehensive code analysis
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Analyzes issues and delegates to appropriate specialist subagents

### Development Processes
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Implements effective Git workflows with branching strategies and PR templates
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Enhances subagent performance through prompt optimization
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Modernizes legacy codebases using specialized subagents
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Creates ML pipelines with data and ML engineering subagents
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Builds cross-platform apps with coordinated subagents
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Automates CI/CD, monitoring, and deployment workflows

### Subagent-Orchestrated Workflows
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Multi-platform features with backend, frontend, and mobile subagents
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Security-first implementation with specialized subagents
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - ML-powered features with data science subagents
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - End-to-end optimization with performance subagents
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Production incident resolution with ops subagents

## 🔧 Tools (Single-Purpose Commands)

### AI & Machine Learning
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Build production-ready AI assistants and chatbots
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Specialized review for AI/ML codebases
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Create LangChain/LangGraph agents with modern patterns
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Create end-to-end ML pipelines with MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Optimize AI prompts for performance and quality

### Architecture & Code Quality
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Generate detailed explanations of complex code
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Migrate code between languages, frameworks, or versions
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Refactor code for maintainability and performance
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Analyze and prioritize technical debt

### Data & Database
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Design scalable data pipeline architectures
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Implement comprehensive data validation systems
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Advanced database migration strategies

### DevOps & Infrastructure
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Generate deployment configurations and checklists
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Advanced container optimization strategies
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Production-grade Kubernetes deployments
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Set up comprehensive monitoring and observability
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Implement Service Level Objectives (SLOs)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Automate development and operational workflows

### Development & Testing
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Create realistic API mocks for development and testing
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Generate production-ready API endpoints with complete implementation stack
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Create comprehensive test suites with framework detection

### Security & Compliance
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Comprehensive accessibility testing and fixes
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Ensure regulatory compliance (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Comprehensive security scanning with automated remediation

### Debugging & Analysis
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Advanced debugging and tracing strategies
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Deep error pattern analysis and resolution strategies
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Trace and diagnose production errors
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Create well-structured GitHub/GitLab issues

### Dependencies & Configuration
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Validate and manage application configuration
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Audit dependencies for security and licensing
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Safely upgrade project dependencies

### Documentation & Collaboration
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Generate comprehensive documentation
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Implement effective Git workflows
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Enhance pull requests with quality checks

### Cost Optimization
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Optimize cloud and infrastructure costs

### Onboarding & Setup
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Set up development environments for new team members

### Subagent Tools
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Multi-perspective code review with specialized subagents
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Deep debugging with debugger and performance subagents
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Full-stack optimization with multiple subagents
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Save project context using context-manager subagent
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Restore saved context for continuity

## Features

- Production-ready implementations
- Framework auto-detection
- Security best practices
- Built-in monitoring and testing
- Commands work together seamlessly

## Command Count

**Total: 52 production-ready slash commands** organized into:

### 🤖 Workflows (14 commands)

- Feature Development & Review (3 commands) 
- Development Process Automation (6 commands)
- Subagent-Orchestrated Workflows (5 commands)

### 🔧 Tools (38 commands)

- AI & Machine Learning (5 commands)
- Architecture & Code Quality (4 commands)
- Data & Database (3 commands)
- DevOps & Infrastructure (6 commands)
- Development & Testing (3 commands)
- Security & Compliance (3 commands)
- Debugging & Analysis (4 commands)
- Dependencies & Configuration (3 commands)
- Documentation & Collaboration (1 command)
- Onboarding & Setup (1 command)
- Subagent-Specific Tools (5 commands)

## Usage Examples

### 🤖 Workflow Examples

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

### 🔧 Tool Examples (Single-Purpose Commands)

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

## Enhanced Commands

### Security & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Comprehensive security scanning with automated remediation.

- **Multi-Tool Scanning**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Automated Fixes**: Common vulnerabilities auto-remediated
- **CI/CD Integration**: Security gates for GitHub Actions/GitLab CI
- **Container Scanning**: Image vulnerability analysis
- **Secret Detection**: GitLeaks and TruffleHog integration

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Advanced container optimization strategies.

- **Smart Optimization**: Analyzes and suggests improvements
- **Multi-Stage Builds**: Framework-specific optimized Dockerfiles
- **Modern Tools**: BuildKit, Bun, UV for faster builds
- **Security Hardening**: Distroless images, non-root users
- **Cross-Command Integration**: Works with /api-scaffold outputs

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Production-grade Kubernetes deployments.

- **Advanced Patterns**: Pod Security Standards, Network Policies, OPA
- **GitOps Ready**: FluxCD and ArgoCD configurations
- **Observability**: Prometheus ServiceMonitors, OpenTelemetry
- **Auto-Scaling**: HPA, VPA, and cluster autoscaler configs
- **Service Mesh**: Istio/Linkerd integration

### Frontend & Data

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Advanced database migration strategies.

- **Multi-Database**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Zero-Downtime**: Blue-green deployments, rolling migrations
- **Event Sourcing**: Kafka/Kinesis integration for CDC
- **Cross-Platform**: Handles polyglot persistence
- **Monitoring**: Migration health checks and rollback

## Combining Workflows and Tools

The real power comes from combining workflows and tools for complete development cycles:

### Example: Building a New Feature

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

### Example: Modernizing Legacy Code

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

## Command Orchestration Patterns

Commands can be used individually or combined in powerful patterns:

### Sequential Execution
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Parallel Analysis
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Iterative Refinement
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Cross-Domain Integration
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```

## When to Use Workflows vs Tools

### 🔀 Workflows & Subagent Tools
- **Problem-solving**: Analyze and fix issues adaptively
- **Multiple perspectives**: Coordinate specialist subagents
- **Complex tasks**: Multi-step processes across domains
- **Unknown solutions**: Let subagents determine approach

### 🛠️ Specialized Tools
- **Infrastructure setup**: Configure environments
- **Code generation**: Create specific implementations
- **Analysis**: Generate reports without fixes
- **Domain tasks**: Highly specialized operations

**Examples:**
- "Implement user authentication system" → `/feature-development`
- "Fix performance issues across the stack" → `/smart-fix`
- "Modernize legacy monolith" → `/legacy-modernize`

### 🔧 Use Tools When:
- **Specific expertise needed** - Clear, focused task in one domain
- **Precise control desired** - Want to direct specific implementation details
- **Part of manual workflow** - Integrating into existing processes
- **Deep specialization required** - Need expert-level implementation
- **Building on existing work** - Enhancing or refining previous outputs

**Examples:**
- "Create Kubernetes manifests" → `/k8s-manifest`
- "Scan for security vulnerabilities" → `/security-scan`
- "Generate API documentation" → `/doc-generate`

## Command Format

Slash commands are simple markdown files where:
- The filename becomes the command name (e.g., `api-scaffold.md` → `/api-scaffold`)
- The file content is the prompt/instructions executed when invoked
- Use `$ARGUMENTS` placeholder for user input

## Best Practices

### Command Selection
- **Let Claude Code suggest automatically** - Analyzes context and selects optimal commands
- **Use workflows for complex tasks** - Subagents coordinate multi-domain implementations
- **Use tools for focused tasks** - Apply specific commands for targeted improvements

### Effective Usage
- **Provide comprehensive context** - Include tech stack, constraints, and requirements
- **Chain commands strategically** - Workflows → Tools → Refinements
- **Build on previous outputs** - Commands are designed to work together

## Contributing

1. Create `.md` file in `workflows/` or `tools/`
2. Use lowercase-hyphen-names
3. Include `$ARGUMENTS` for user input

## Troubleshooting

**Command not found**: Check files are in `~/.claude/commands/`

**Workflows slow**: Normal - they coordinate multiple subagents

**Generic output**: Add more specific context about your tech stack

**Integration issues**: Verify file paths and command sequence

## Performance Tips

**Command Selection:**
- **Workflows**: Multi-subagent coordination for complex features
- **Tools**: Single-purpose operations for specific tasks
- **Simple edits**: Stay with main agent

**Optimization:**
- Start with tools for known problems
- Provide detailed requirements upfront
- Build on previous command outputs
- Let workflows complete before modifications

### Adding a New Workflow:
- Focus on subagent orchestration and delegation logic
- Specify which specialized subagents to use and in what order
- Define coordination patterns between subagents

### Adding a New Tool:
- Include complete, production-ready implementations
- Structure content with clear sections and actionable outputs
- Include examples, best practices, and integration points

## Learn More

- [Claude Code Documentation](https://docs.anthropic.com/en/docs/claude-code)
- [Slash Commands Documentation](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Subagents Documentation](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code Subagents Collection](https://github.com/wshobson/agents) - Specialized subagents used by these commands
