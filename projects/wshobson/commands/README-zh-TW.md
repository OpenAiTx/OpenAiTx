
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

可用於生產環境的 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 斜線指令，透過智慧自動化加速開發流程。

**共 52 條指令**，分類如下：
- **🤖 工作流程**：多子代理協作，用於複雜任務
- **🔧 工具**：單一用途工具，用於特定操作

### 🤝 需要 Claude Code 子代理

這些指令需配合 [Claude Code 子代理](https://github.com/wshobson/agents) 使用，以實現協作能力。

## 安裝

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## 可用指令

- **🤖 工作流程** - 協調多個子代理執行複雜任務
- **🔧 工具** - 用於特定操作的單一用途指令

## 使用方法

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code 會根據上下文自動建議相關指令。

## 🤖 工作流程

多子代理協作以處理複雜任務：

### 功能開發
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - 後端、前端、測試及部署子代理構建完整功能
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - 多個審查子代理提供全面程式碼分析
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - 分析問題並分派至適當專家子代理

### 開發流程
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - 實作有效的 Git 工作流程與分支策略及 PR 模板
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - 透過提示優化提升子代理效能
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - 利用專業子代理現代化舊有程式碼庫
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - 用資料與機器學習工程子代理建立 ML 流程
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - 由協調子代理構建跨平台應用
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - 自動化 CI/CD、監控與部署流程

### 子代理協作流程
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - 後端、前端與行動子代理實作多平台功能
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - 由專業子代理負責安全優先實作
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - 資料科學子代理打造 ML 驅動功能
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - 由效能子代理進行端到端最佳化
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - 運維子代理協助解決生產事故

## 🔧 工具（單一用途指令）

### AI 與機器學習
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - 建立可投入生產的 AI 助手與聊天機器人
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - 專為 AI/ML 程式碼庫設計的審查
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - 以現代模式建立 LangChain/LangGraph 代理
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - 以 MLOps 實現端到端 ML 流程
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - 優化 AI 提示以提升效能與品質

### 架構與程式碼品質
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - 生成複雜程式碼的詳細解釋
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - 於語言、框架或版本間遷移程式碼
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - 重構程式碼以提升維護性與效能
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - 分析並優先處理技術債務

### 資料與資料庫
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - 設計可擴展的資料流程架構
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - 實現全面性的資料驗證系統
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - 進階資料庫遷移策略

### DevOps 與基礎建設
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - 生成部署配置與檢查清單
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - 進階容器最佳化策略
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - 生產等級 Kubernetes 部署
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - 建置全面監控與可觀測性
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - 實作服務等級目標（SLO）
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - 自動化開發與運維流程

### 開發與測試
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - 建立真實的 API 模擬用於開發與測試
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - 產生具備完整實作堆疊的生產等級 API 端點
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - 建立具框架偵測能力的完整測試套件

### 安全與合規
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - 完整的無障礙測試與修復
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - 確保符合法規（GDPR、HIPAA、SOC2）
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - 全面安全掃描並自動修復

### 除錯與分析
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - 進階除錯與追蹤策略
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - 深度錯誤樣式分析與解決策略
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - 追蹤與診斷生產錯誤
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - 建立結構良好的 GitHub/GitLab 問題單

### 相依性與組態
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - 驗證與管理應用程式組態
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - 審查相依性安全性與授權
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - 安全升級專案相依套件

### 文件與協作
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - 產生完整文件
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - 實作有效的 Git 工作流程
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - 強化拉取請求的品質檢查

### 成本最佳化
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - 優化雲端與基礎設施成本

### 新手上線與設置
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - 為新成員設置開發環境

### 子代理工具
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - 多專業子代理進行多角度程式碼審查
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - 除錯器與效能子代理進行深度除錯
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - 多子代理全端最佳化
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - 使用 context-manager 子代理儲存專案上下文
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - 恢復儲存的上下文以保持連續性

## 功能

- 可投入生產的實作
- 自動偵測框架
- 安全最佳實踐
- 內建監控與測試

- 指令無縫協作

## 指令數量

**總計：52 個可用於生產環境的斜線指令**，組織如下：

### 🤖 工作流程（14 條指令）

- 功能開發與審查（3 條指令）
- 開發流程自動化（6 條指令）
- 子代理協作工作流程（5 條指令）

### 🔧 工具（38 條指令）

- AI 與機器學習（5 條指令）
- 架構與程式碼品質（4 條指令）
- 數據與資料庫（3 條指令）
- DevOps 與基礎架構（6 條指令）
- 開發與測試（3 條指令）
- 資安與合規（3 條指令）
- 除錯與分析（4 條指令）
- 依賴與設定（3 條指令）
- 文件與協作（1 條指令）
- 新手導入與設定（1 條指令）
- 子代理專屬工具（5 條指令）

## 使用範例

### 🤖 工作流程範例

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

### 🔧 工具範例（單一用途指令）

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

## 強化指令

### 安全性與 DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

全面的安全掃描與自動修復。

- **多工具掃描**：Bandit、Safety、Trivy、Semgrep、ESLint Security、Snyk
- **自動修復**：常見漏洞自動修補
- **CI/CD 整合**：GitHub Actions/GitLab CI 的安全閘道
- **容器掃描**：映像檔漏洞分析
- **秘密偵測**：整合 GitLeaks 和 TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

進階容器最佳化策略。

- **智能優化**：分析並提出改進建議
- **多階段建構**：針對框架最佳化的 Dockerfile
- **現代工具**：BuildKit、Bun、UV 快速建構
- **安全強化**：無基礎映像、非 root 用戶
- **跨指令整合**：可與 /api-scaffold 輸出協作

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

生產等級 Kubernetes 部署。

- **進階模式**：Pod 安全標準、網路政策、OPA
- **GitOps 就緒**：FluxCD 與 ArgoCD 設定
- **可觀測性**：Prometheus ServiceMonitors、OpenTelemetry
- **自動擴展**：HPA、VPA 及叢集自動擴展設定
- **服務網格**：整合 Istio/Linkerd

### 前端與資料

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

進階資料庫遷移策略。

- **多資料庫**：PostgreSQL、MySQL、MongoDB、DynamoDB
- **零停機**：藍綠部署、滾動遷移
- **事件溯源**：Kafka/Kinesis 整合 CDC
- **跨平台**：處理多語言持久化
- **監控**：遷移健康檢查與回滾

## 結合工作流程與工具

真正的威力來自於結合工作流程與工具，以實現完整的開發週期：

### 範例：建立新功能

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

### 範例：現代化遺留程式碼

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

## 指令協作模式

指令可以單獨使用，也可以組合成強大的模式：

### 依序執行
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### 平行分析
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### 反覆精煉
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### 跨領域整合
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## 何時使用工作流程與工具

### 🔀 工作流程與子代理工具
- **問題解決**：具適應性地分析並修復問題
- **多重觀點**：協調專家子代理
- **複雜任務**：跨領域的多步驟流程
- **未知解決方案**：讓子代理決定方法

### 🛠️ 專業工具
- **基礎設施設定**：配置環境
- **程式碼生成**：建立特定實作
- **分析**：產生報告但不修正
- **領域任務**：高度專業化的操作

**範例：**
- 「實作用戶驗證系統」→ `/feature-development`
- 「修復全端效能問題」→ `/smart-fix`
- 「現代化舊式單體系統」→ `/legacy-modernize`

### 🔧 何時使用工具：
- **需特定專業** - 明確且聚焦於單一領域的任務
- **需精確掌控** - 希望指導特定實作細節
- **屬於手動流程一環** - 整合至既有流程
- **需深度專業化** - 需要專家級實作
- **在既有成果上增建** - 強化或細化先前輸出

**範例：**
- 「建立 Kubernetes 清單」→ `/k8s-manifest`
- 「掃描安全漏洞」→ `/security-scan`
- 「產生 API 文件」→ `/doc-generate`

## 指令格式

斜線指令是簡單的 Markdown 檔案：
- 檔名即為指令名稱（如 `api-scaffold.md` → `/api-scaffold`）
- 檔案內容即為執行時的提示/指令
- 使用 `$ARGUMENTS` 佔位符來接收使用者輸入

## 最佳實踐

### 指令選擇
- **讓 Claude Code 自動推薦** - 會分析情境並選擇最適指令
- **複雜任務用工作流程** - 子代理協調跨領域實作
- **聚焦任務用工具** - 使用專指令針對性改進

### 有效運用
- **提供完整背景** - 包含技術棧、限制與需求
- **策略性串接指令** - 工作流程 → 工具 → 精修
- **建立在先前輸出上** - 指令設計可協同運作

## 貢獻方式

1. 在 `workflows/` 或 `tools/` 建立 `.md` 檔案
2. 使用小寫-連字命名
3. 包含 `$ARGUMENTS` 以接收使用者輸入

## 疑難排解

**找不到指令**：檢查檔案是否在 `~/.claude/commands/`

**工作流程慢**：正常－因需協調多個子代理

**輸出過於一般**：請提供更明確技術棧背景

**整合問題**：確認檔案路徑與指令順序

## 效能建議

**指令選擇：**
- **工作流程**：多子代理協調複雜功能
- **工具**：單一用途的專業任務
- **簡單編輯**：直接由主代理處理

**最佳化：**
- 已知問題先用工具處理
- 前置詳列需求
- 建立在先前指令輸出上
- 工作流程完成後再修正

### 新增工作流程：
- 著重於子代理協調與委派邏輯
- 明確指定使用哪些專門子代理及順序
- 定義子代理間協作模式

### 新增工具：
- 包含完整、可用於生產環境的實作
- 內容結構清晰且具操作性
- 包含範例、最佳實踐與整合重點

## 進一步學習

- [Claude Code 文件](https://docs.anthropic.com/en/docs/claude-code)
- [斜線指令文件](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [子代理文件](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Claude Code 子代理收藏](https://github.com/wshobson/agents) - 這些指令所用的專業子代理



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---