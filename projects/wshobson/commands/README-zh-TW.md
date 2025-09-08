
<div align="right">
  <details>
    <summary >🌐 語言</summary>
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

# Claude Code 斜線指令

適用於 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 的生產級斜線指令，透過智能自動化加速開發流程。

**52 條指令** 組織為：
- **🤖 工作流程**：多子代理協同運作以處理複雜任務
- **🔧 工具**：針對特定操作的單一用途工具

### 🤝 需要 Claude Code 子代理程式

這些指令與 [Claude Code 子代理程式](https://github.com/wshobson/agents) 搭配使用，以提供協同作業能力。

## 安裝

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 可用指令

- **🤖 工作流程** - 協調多個子代理執行複雜任務
- **🔧 工具** - 用於特定操作的單一功能指令

## 使用方式

指令分別存放於 `tools/` 和 `workflows/` 目錄。使用時需加上目錄前綴：

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**注意：**如果您偏好使用無前綴的指令，可以將目錄結構扁平化：
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code 會根據上下文自動建議相關指令。

## 🤖 工作流程

多子代理協同處理複雜任務：

### 功能開發
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 後端、前端、測試與部署子代理共同建構完整功能
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 多個審查子代理提供全面的程式碼分析
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 分析問題並分派給適當的專業子代理

### 開發流程
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 實施有效的 Git 工作流程，包含分支策略與 PR 樣板
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 透過提示優化提升子代理效能
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 利用專業子代理現代化舊有程式碼庫
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 資料與機器學習工程子代理建構 ML 流程
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 多子代理協同開發跨平台應用程式
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - 自動化 CI/CD、監控及部署工作流程

### 子代理協同工作流程
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 多平台功能，涵蓋後端、前端與行動子代理
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 以安全為核心，由專業子代理實作
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 由資料科學子代理打造 ML 驅動功能
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 全方位效能優化，由性能子代理協作
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 生產環境事件處理，由運維子代理負責

## 🔧 工具（單一用途指令）

### AI 與機器學習
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 建立可商用的 AI 助理和聊天機器人
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - AI/ML 程式碼庫的專業審查
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 以現代模式創建 LangChain/LangGraph 代理
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - 建立端到端 ML 流程，結合 MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - 優化 AI 提示以提升效能與品質

### 架構與程式碼品質
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 生成複雜程式碼的詳細說明
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 在不同語言、框架或版本間遷移程式碼
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 重構程式碼以提升可維護性與效能

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 分析並優先處理技術債務

### 資料與資料庫
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 設計可擴展的資料管道架構
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 實作全面的資料驗證系統
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 進階的資料庫遷移策略

### DevOps 與基礎架構
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 產生部署組態與檢查清單
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 進階容器最佳化策略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 生產等級 Kubernetes 部署
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 建立全面性監控與可觀察性
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 實作服務等級目標 (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 自動化開發與營運工作流程

### 開發與測試
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 建立真實的 API 模擬用於開發與測試
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 產生可用於生產的 API 端點及完整實作堆疊
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 建立全面性的測試套件並偵測測試框架

### 資安與法規遵循
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 全面性無障礙測試與修正
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 確保符合法規 (GDPR、HIPAA、SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 全面性安全掃描及自動修正

### 除錯與分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 進階除錯與追蹤策略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 深入錯誤模式分析與解決策略
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 追蹤並診斷生產環境錯誤
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 建立結構良好的 GitHub/GitLab 問題單

### 相依性與組態
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 驗證並管理應用程式組態
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 審核相依性安全性與授權
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 安全升級專案相依套件

### 文件與協作
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 產生全面性的文件
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 實作有效的 Git 工作流程
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 加強拉取請求品質檢查

### 成本優化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 優化雲端與基礎設施成本

### 新人導入與設置
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 為新團隊成員設置開發環境

### 子代理工具
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 以多重視角進行程式碼審查，採用專用子代理
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 結合除錯器與效能子代理進行深度除錯
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 多子代理全端優化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - 使用上下文管理子代理儲存專案上下文
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 恢復已儲存的上下文以便持續作業

## 功能特色

- 可直接用於生產環境的實作
- 自動偵測框架
- 安全性最佳實踐
- 內建監控與測試功能
- 指令能無縫協作

## 指令數量

**總計：52 個可用於生產環境的斜線指令**，組織如下：

### 🤖 工作流程（14 個指令）

- 功能開發與審查（3 個指令） 
- 開發流程自動化（6 個指令）
- 子代理協同流程（5 個指令）

### 🔧 工具（38 個指令）

- AI 與機器學習（5 個指令）
- 架構與程式碼品質（4 個指令）
- 資料與資料庫（3 個指令）
- DevOps 與基礎設施（6 個指令）
- 開發與測試（3 個指令）
- 安全與合規（3 個指令）
- 偵錯與分析（4 條命令）
- 依賴項與配置（3 條命令）
- 文件與協作（1 條命令）
- 入職與設置（1 條命令）
- 子代理專用工具（5 條命令）

## 使用範例

### 🤖 工作流程範例

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

### 🔧 工具範例（單一用途指令）

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

## 增強型指令

### 資安與 DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

全面性安全掃描並自動修復。

- **多工具掃描**：Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自動修復**：自動修復常見漏洞
- **CI/CD 整合**：GitHub Actions/GitLab CI 安全閘道
- **容器掃描**：映像檔漏洞分析
- **機密偵測**：整合 GitLeaks 與 TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

進階容器優化策略。

- **智慧優化**：分析並提出改進建議
- **多階段建置**：針對框架最佳化的 Dockerfile
- **現代化工具**：BuildKit、Bun、UV 加速建置
- **安全強化**：無系統映像檔、非 root 使用者
- **跨指令整合**：可與 /api-scaffold 輸出結合使用

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

生產等級 Kubernetes 部署。

- **高階模式**：Pod 安全標準、網路政策、OPA
- **GitOps 支援**：FluxCD 與 ArgoCD 設定
- **可觀測性**：Prometheus ServiceMonitors、OpenTelemetry
- **自動擴展**：HPA、VPA 與叢集自動擴展設定
- **服務網格**：整合 Istio/Linkerd

### 前端與資料

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

進階資料庫遷移策略。

- **多資料庫**：PostgreSQL、MySQL、MongoDB、DynamoDB
- **零停機時間**：藍綠部署、滾動遷移
- **事件溯源**：Kafka/Kinesis 整合 CDC
- **跨平台**：處理多語言持久化
- **監控**：遷移健康檢查與回滾

## 結合工作流程與工具

真正的強大來自於將工作流程和工具結合，實現完整的開發週期：

### 範例：建立新功能

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

### 範例：現代化遺留程式碼

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

## 指令協作模式

指令可以單獨使用，也可以組合成強大的模式：

### 依序執行
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### 平行分析
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 反覆精煉
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### 跨領域整合
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## 何時應使用工作流程與工具

### 🔀 工作流程與子代理工具
- **問題解決**：分析並適應性修復問題
- **多元視角**：協調專家子代理
- **複雜任務**：跨領域多步驟流程
- **未知解法**：讓子代理自行決定方法

### 🛠️ 專業工具
- **基礎設施設置**：配置環境
- **程式碼產生**：建立特定實作
- **分析**：產生報告但不進行修復
- **領域任務**：高度專業化操作

**範例：**
- 「實作使用者驗證系統」→ `/workflows:feature-development`
- 「修復全端效能問題」→ `/workflows:smart-fix`
- 「現代化舊有單體系統」→ `/workflows:legacy-modernize`

### 🔧 何時使用工具：
- **需要特定專業知識**－單一領域明確且集中的任務
- **希望精確控制**－想直接指導具體實作細節
- **作為手動流程一部分**－整合進現有流程
- **需深度專業化**－需要專家等級的實作
- **建立在既有成果上**－強化或精煉先前產出

**範例：**
- 「建立 Kubernetes 清單」→ `/tools:k8s-manifest`
- 「掃描安全漏洞」→ `/tools:security-scan`
- 「產生 API 文件」→ `/tools:doc-generate`

## 指令格式

斜線指令是簡易的 Markdown 檔案：
- 檔名即為指令名稱（如 `tools/api-scaffold.md` → `/tools:api-scaffold`）
- 檔案內容為執行時的提示/指令
- 使用 `$ARGUMENTS` 佔位符作為使用者輸入

## 最佳實踐

### 指令選擇
- **讓 Claude Code 自動建議** - 分析上下文並選擇最佳指令
- **複雜任務使用工作流** - 次代理協調多領域實作
- **專注任務使用工具** - 應用特定指令以針對性改進

### 有效使用
- **提供完整上下文** - 包含技術棧、限制與需求
- **策略性串接指令** - 工作流 → 工具 → 優化
- **建立在先前輸出基礎上** - 指令設計可相互配合

## 貢獻方式

1. 在 `workflows/` 或 `tools/` 建立 `.md` 檔案
2. 使用小寫連字號名稱
3. 包含 `$ARGUMENTS` 以供使用者輸入

## 疑難排解

**找不到指令**：
- 檢查檔案是否在 `~/.claude/commands/tools/` 或 `~/.claude/commands/workflows/`
- 使用正確前綴：`/tools:command-name` 或 `/workflows:command-name`
- 或者如果偏好無前綴，可平坦化目錄：`cp tools/*.md . && cp workflows/*.md .`

**工作流緩慢**：屬正常現象－因需協調多個次代理

**輸出過於通用**：請提供更明確的技術棧資訊

**整合問題**：請確認檔案路徑與指令順序

## 效能提示

**指令選擇：**
- **工作流**：複雜功能多代理協調
- **工具**：特定任務單一操作
- **簡單編輯**：直接用主代理即可

**最佳化：**
- 先用工具處理已知問題
- 事先提供詳細需求
- 建立在先前指令輸出之上
- 在修改前讓工作流程完成

### 新增工作流程：
- 著重於子代理協同與委派邏輯
- 指定要使用哪些專業子代理以及執行順序
- 定義子代理之間的協調模式

### 新增工具：
- 包含完整、可用於正式環境的實作
- 以清楚的章節與可執行的輸出來組織內容
- 包含範例、最佳實踐與整合重點

## 了解更多

- [Claude Code 文件](https://docs.anthropic.com/en/docs/claude-code)
- [斜線命令文件](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [子代理文件](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 子代理蒐集庫](https://github.com/wshobson/agents) - 這些指令所使用的專業子代理


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---