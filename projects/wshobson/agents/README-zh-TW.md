<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=wshobson&project=agents&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Claude Code 子代理集合

這是一個針對 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 所設計的專業 AI 子代理全方位集合，旨在以領域專家知識提升開發流程。

## 概覽

本儲存庫包含 58 個專業子代理，能擴展 Claude Code 的功能。每個子代理皆為特定領域專家，能根據上下文自動啟用，或於需要時明確調用。所有代理均根據任務複雜度配置特定 Claude 模型，以實現最佳效能及成本效益。

## 可用子代理

### 開發與架構
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - 設計 RESTful API、微服務邊界與資料庫結構
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - 建構 React 元件，實作響應式版面，處理前端狀態管理
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - 製作介面設計、線框圖和設計系統
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - 開發具原生整合的 React Native 或 Flutter 應用程式
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - 設計 GraphQL 結構、解析器與聯邦架構
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - 審查程式碼變更以確保架構一致性與設計模式

### 語言專家
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - 撰寫地道 Python 程式，運用進階功能與最佳化
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - 撰寫地道 Go 程式，運用 goroutine、channels 與介面
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - 撰寫地道 Rust 程式，運用所有權模式、生命週期與 trait 實作
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - 撰寫高效能 C 程式，妥善管理記憶體與系統呼叫
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - 撰寫地道 C++ 程式，運用現代語法、RAII、智能指標與 STL 演算法
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - 精通現代 JavaScript（ES6+）、非同步模式與 Node.js API
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - 精通 TypeScript，運用進階型別、泛型與嚴格型別安全
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - 撰寫地道 PHP 程式，善用現代語法與效能最佳化
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - 精通現代 Java，善用串流、並發與 JVM 最佳化
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - 撰寫地道 Elixir 程式，運用 OTP 模式、函數式程式與 Phoenix 框架
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - 撰寫現代 C# 程式，運用進階功能與 .NET 最佳化
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - 精通企業級 Scala 開發，運用函數式編程、分散式系統與大數據處理
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - 使用最佳化腳本與效能調校製作 Unity 遊戲
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - 精通 Minecraft 伺服器插件開發，使用 Bukkit、Spigot 與 Paper API
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - 使用 Swift/SwiftUI 開發原生 iOS 應用程式
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - 撰寫複雜 SQL 查詢，最佳化執行計畫與設計正規化資料結構

### 基礎設施與運維
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - 偵錯生產問題，分析日誌並修復部署故障
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - 配置 CI/CD 流程、Docker 容器與雲端部署
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - 設計 AWS/Azure/GCP 基礎設施並最佳化雲端成本
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - 最佳化 SQL 查詢、設計高效索引並處理資料庫遷移
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - 管理資料庫運作、備份、複製與監控
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - 撰寫進階 Terraform 模組，管理狀態檔並實踐 IaC 最佳實務
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - 以高度緊急與精準處理生產事故
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - 偵錯網路連線、配置負載平衡器並分析流量模式
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - 開發者體驗專家，改善工具、設置與工作流程

### 品質與安全
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - 專業程式碼審查，注重配置安全與生產可靠性
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - 審查程式碼漏洞並確保符合 OWASP 標準
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - 建立完整的測試套件，包括單元、整合與端到端測試
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - 應用程式效能分析、瓶頸優化與快取策略實施
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - 專業除錯，處理錯誤、測試失敗及異常行為
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - 搜尋日誌與程式碼庫中的錯誤模式、堆疊追蹤與異常
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - 精通網路研究，善用進階搜尋技巧與資訊整合

### 資料與人工智慧
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - 資料分析專家，精通 SQL 查詢、BigQuery 操作與資料洞察
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - 建構 ETL 流程、資料倉儲與串流架構
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - 開發 LLM 應用、RAG 系統與提示流程
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - 實作機器學習流程、模型部署與特徵工程
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - 建立機器學習流程、實驗追蹤與模型登錄
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - 優化 LLM 與 AI 系統的提示語

### 專業領域
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - 建立 OpenAPI/Swagger 規格並撰寫開發文件
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - 整合 Stripe、PayPal 及支付處理器
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - 建立金融模型、回測交易策略與分析市場資料
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - 監控投資組合風險、R 倍數及持倉限制
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - 重構舊有程式碼庫並逐步現代化
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - 管理多代理人及長時間任務的上下文

### 文件化
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - 根據現有程式碼庫建立完整技術文件
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - 製作流程圖、序列圖、ERD 及架構的 Mermaid 圖表
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - 建立詳盡技術參考與 API 文件
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - 根據程式建立逐步教學與教育內容

### 商業與行銷
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - 分析指標、撰寫報告並追蹤 KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - 撰寫部落格、社群內容及電子郵件新聞稿
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - 起草冷郵件、後續聯絡及提案模板
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - 處理支援票、FAQ 回覆及客戶郵件
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - 撰寫隱私政策、服務條款、免責聲明及法律通知

## 模型分配

所有 58 個子代理人均依任務複雜度配置專屬 Claude 模型：

### 🚀 Haiku（快速且具成本效益）- 9 個代理
**模型：** `haiku`
- `data-scientist` - SQL 查詢與資料分析
- `api-documenter` - OpenAPI/Swagger 文件編寫
- `reference-builder` - 完整技術參考與 API 文件
- `business-analyst` - 指標與 KPI 追蹤
- `content-marketer` - 部落格文章與社群媒體內容
- `customer-support` - 客服工單與常見問答
- `sales-automator` - 冷郵件與提案書
- `search-specialist` - 網路研究與資訊收集
- `legal-advisor` - 隱私政策與合規文件

### ⚡ Sonnet（均衡效能）- 36 個代理
**模型：** `sonnet`

**開發與程式語言：**
- `python-pro` - 進階 Python 開發
- `javascript-pro` - 現代 JavaScript 與 Node.js
- `typescript-pro` - 進階 TypeScript 型別系統
- `golang-pro` - Go 並發與慣用設計
- `rust-pro` - Rust 記憶體安全與系統程式設計
- `c-pro` - C 程式設計與嵌入式系統
- `cpp-pro` - 現代 C++，包含 STL 與模板
- `php-pro` - 現代 PHP 與進階功能
- `java-pro` - 現代 Java，含串流與並行
- `elixir-pro` - Elixir OTP 模式與 Phoenix
- `csharp-pro` - 現代 C# 與 .NET 框架及模式
- `scala-pro` - 企業級 Scala，支援 Apache Pekko、Akka、Spark、ZIO/Cats Effect
- `unity-developer` - Unity 遊戲開發與優化
- `minecraft-bukkit-pro` - Minecraft 插件開發（Bukkit/Spigot/Paper）
- `ios-developer` - 原生 iOS 開發（Swift/SwiftUI）
- `frontend-developer` - React 元件與 UI
- `ui-ux-designer` - 介面設計與線框圖
- `backend-architect` - API 設計與微服務
- `mobile-developer` - React Native/Flutter 應用程式
- `sql-pro` - 複雜 SQL 優化
- `graphql-architect` - GraphQL 結構與解析器

**基礎設施與運維：**
- `devops-troubleshooter` - 生產環境除錯
- `deployment-engineer` - CI/CD 管線
- `database-optimizer` - 查詢優化
- `database-admin` - 數據庫操作
- `terraform-specialist` - 基礎架構即程式碼
- `network-engineer` - 網路配置
- `dx-optimizer` - 開發者體驗
- `data-engineer` - ETL 管線

**品質與支援：**
- `test-automator` - 測試套件建立
- `code-reviewer` - 程式碼品質分析
- `debugger` - 錯誤調查
- `error-detective` - 日誌分析
- `ml-engineer` - 機器學習模型部署
- `legacy-modernizer` - 框架遷移
- `payment-integration` - 支付處理
- `mermaid-expert` - Mermaid 圖表與視覺化文件

### 🧠 Opus（最大能力）- 13 個代理
**模型：** `opus`
- `ai-engineer` - 大型語言模型應用與 RAG 系統
- `security-auditor` - 漏洞分析
- `performance-engineer` - 應用程式優化
- `incident-responder` - 線上事故處理
- `mlops-engineer` - 機器學習基礎架構
- `architect-reviewer` - 架構一致性
- `cloud-architect` - 雲端基礎架構設計
- `prompt-engineer` - LLM 提示最佳化
- `context-manager` - 多代理協作
- `quant-analyst` - 財務建模
- `risk-manager` - 投資組合風險管理
- `docs-architect` - 從程式碼庫產出完整技術文件
- `tutorial-engineer` - 步驟教學與教育內容

## 安裝

將這些子代理放置於 `~/.claude/agents/` 目錄後即可自動使用。

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## 使用方法

### 自動調用
Claude Code 會根據任務情境和子代理的描述，自動委派給適當的子代理。

### 明確調用
在您的請求中提及子代理的名稱：
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## 使用範例

### 單一代理任務
```bash
# Code quality and review
"Use code-reviewer to analyze this component for best practices"
"Have code-reviewer scrutinize these configuration changes"
"Have security-auditor check for OWASP compliance issues"

# Development tasks  
"Get backend-architect to design a user authentication API"
"Use frontend-developer to create a responsive dashboard layout"

# Infrastructure and operations
"Have devops-troubleshooter analyze these production logs"
"Use cloud-architect to design a scalable AWS architecture"
"Get network-engineer to debug SSL certificate issues"
"Use database-admin to set up backup and replication"

# Data and AI
"Get data-scientist to analyze this customer behavior dataset"
"Use ai-engineer to build a RAG system for document search"
"Have mlops-engineer set up MLflow experiment tracking"

# Business and marketing
"Have business-analyst create investor deck with growth metrics"
"Use content-marketer to write SEO-optimized blog post"
"Get sales-automator to create cold email sequence"
"Have customer-support draft FAQ documentation"
```

### 多代理工作流程

這些子代理可以無縫協作，若需更複雜的協調作業，您可以使用 **[Claude Code Commands](https://github.com/wshobson/commands)** 集合，該集合提供 52 個預先建構的斜線命令，可在高級工作流程中運用這些子代理。

```bash
# Feature development workflow
"Implement user authentication feature"
# Automatically uses: backend-architect → frontend-developer → test-automator → security-auditor

# Performance optimization workflow  
"Optimize the checkout process performance"
# Automatically uses: performance-engineer → database-optimizer → frontend-developer

# Production incident workflow
"Debug high memory usage in production"
# Automatically uses: incident-responder → devops-troubleshooter → error-detective → performance-engineer

# Network connectivity workflow
"Fix intermittent API timeouts"
# Automatically uses: network-engineer → devops-troubleshooter → performance-engineer

# Database maintenance workflow
"Set up disaster recovery for production database"
# Automatically uses: database-admin → database-optimizer → incident-responder

# ML pipeline workflow
"Build end-to-end ML pipeline with monitoring"
# Automatically uses: mlops-engineer → ml-engineer → data-engineer → performance-engineer

# Product launch workflow
"Launch new feature with marketing campaign"
# Automatically uses: business-analyst → content-marketer → sales-automator → customer-support
```

### 使用斜線指令的進階工作流程

若需更複雜的多子代理協作，請使用配套的 [Commands 儲存庫](https://github.com/wshobson/commands)：

```bash
# Complex feature development (8+ subagents)
/full-stack-feature Build user dashboard with real-time analytics

# Production incident response (5+ subagents) 
/incident-response Database connection pool exhausted

# ML infrastructure setup (6+ subagents)
/ml-pipeline Create recommendation engine with A/B testing

# Security-focused implementation (7+ subagents)
/security-hardening Implement OAuth2 with zero-trust architecture
```

## 子代理格式

每個子代理都遵循以下結構：
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### 模型配置

自 Claude Code v1.0.64 起，子代理可以指定應使用哪個 Claude 模型。這使得根據任務複雜度進行具成本效益的委派成為可能：

- **低複雜度（Haiku）**：如基本資料分析、文件產生、標準回覆等簡單任務
- **中複雜度（Sonnet）**：開發任務、程式碼審查、測試及標準工程工作  
- **高複雜度（Opus）**：如安全稽核、架構審查、事件回應及 AI/ML 工程等關鍵任務

可用模型（依 Claude Code v1.0.64 的簡化命名）：
- `haiku` - 針對簡單任務快速且具成本效益
- `sonnet` - 適用於大多數開發工作的平衡效能
- `opus` - 最適合複雜分析及關鍵任務的高能力模型

若未指定模型，子代理將使用系統預設模型。

## 代理協作模式

Claude Code 會自動以以下常見模式協調代理：

### 序列工作流程
```
User Request → Agent A → Agent B → Agent C → Result

Example: "Build a new API feature"
backend-architect → frontend-developer → test-automator → security-auditor
```

### Parallel Execution
```
User Request → Agent A + Agent B (simultaneously) → Merge Results

Example: "Optimize application performance" 
performance-engineer + database-optimizer → Combined recommendations
```

### 條件分支
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### 審查與驗證
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```

## 何時使用哪個代理人

### 🏗️ 規劃與架構
- **backend-architect**：API 設計、資料庫架構、系統架構
- **frontend-developer**：UI/UX 規劃、元件架構
- **ui-ux-designer**：介面設計、線框圖、設計系統、用戶研究
- **cloud-architect**：基礎架構設計、可擴展性規劃

### 🔧 實作與開發  
- **python-pro**：Python 專屬開發任務
- **golang-pro**：Go 專屬開發任務
- **rust-pro**：Rust 專屬開發、記憶體安全、系統程式設計
- **c-pro**：C 程式設計、嵌入式系統、效能關鍵程式
- **javascript-pro**：現代 JavaScript、非同步模式、Node.js/瀏覽器程式
- **typescript-pro**：進階 TypeScript、泛型、型別推論、企業模式
- **java-pro**：現代 Java 開發、串流、並行、Spring Boot
- **elixir-pro**：Elixir 開發、OTP 模式、Phoenix 框架、函數式程式設計
- **csharp-pro**：現代 C# 開發、.NET 框架、企業模式
- **scala-pro**：企業級 Scala 與函數式程式設計、Apache Pekko/Akka actors、Apache Spark、ZIO/Cats Effect、反應式架構
- **unity-developer**：Unity 遊戲開發、C# 腳本、效能最佳化
- **minecraft-bukkit-pro**：Minecraft 外掛開發、事件系統、伺服器端功能
- **ios-developer**：以 Swift/SwiftUI 進行原生 iOS 開發
- **sql-pro**：資料庫查詢、架構設計、查詢最佳化
- **mobile-developer**：React Native/Flutter 開發

### 🛠️ 運維與維護
- **devops-troubleshooter**：生產問題、部署困難
- **incident-responder**：重大故障需即時應對
- **database-optimizer**：查詢效能、索引策略
- **database-admin**：備份策略、複製、用戶管理、災難復原
- **terraform-specialist**：基礎架構即程式碼、Terraform 模組、狀態管理
- **network-engineer**：網路連線、負載平衡、SSL/TLS、DNS 除錯

### 📊 分析與最佳化
- **performance-engineer**：應用瓶頸、效能最佳化
- **security-auditor**：漏洞掃描、合規檢查
- **data-scientist**：資料分析、洞察、報告
- **mlops-engineer**：機器學習基礎架構、實驗追蹤、模型註冊、流程自動化

### 🧪 品質保證
- **code-reviewer**：程式碼品質、配置安全、產品可靠性
- **test-automator**：測試策略、測試套件建立
- **debugger**：錯誤調查、錯誤修復
- **error-detective**：日誌分析、錯誤模式辨識、根本原因分析
- **search-specialist**：深度網路研究、競爭分析、事實查核

### 📚 文件編撰
- **api-documenter**：OpenAPI/Swagger 規格、API 文件
- **docs-architect**：完整技術文件、架構指南、系統手冊
- **reference-builder**：詳盡 API 參考、配置指南、參數說明
- **tutorial-engineer**：逐步教學、學習路徑、教育內容

### 💼 商務與策略
- **business-analyst**：KPI、營收模式、成長預測、投資者指標
- **risk-manager**：投資組合風險、避險策略、R 倍數、部位尺寸
- **content-marketer**：SEO 內容、部落格文章、社群媒體、電子郵件行銷
- **sales-automator**：冷信件、跟進、提案、潛在客戶培養
- **customer-support**：客服單、常見問答、說明文件、疑難排解
- **legal-advisor** - 撰寫隱私政策、服務條款、免責聲明及法律通知

## 最佳實踐

### 🎯 任務委派
1. **讓 Claude Code 自動分派** — 主要代理分析上下文並選擇最佳代理人
2. **明確說明需求** — 包含限制、技術棧與品質要求
3. **信任代理專業** — 每個代理人都針對其領域優化

### 🔄 多代理工作流程
4. **從高階請求開始** — 讓代理協調複雜多步驟任務
5. **在代理間提供背景** — 確保代理擁有必要背景資訊
6. **檢查整合點** — 檢查不同代理輸出的協同效果

### 🎛️ 明確控制
7. **針對特定需求明確呼叫** — 當你需要特定專家的觀點時
8. **策略性結合多位代理** — 不同專家可互相驗證成果
9. **指定檢查模式** — 「請 security-auditor 審查 backend-architect 的 API 設計」

### 📈 最佳化
10. **監控代理效能** — 瞭解哪些代理最適合你的使用場景
11. **反覆執行複雜任務** - 利用代理的回饋來完善需求  
12. **善用代理優勢** - 根據代理能力匹配任務複雜度  

## 貢獻指南  

要新增一個子代理：  
1. 依照上述格式建立新的 `.md` 檔案  
2. 使用小寫並以連字號分隔命名  
3. 撰寫清楚的描述，說明何時應使用此子代理  
4. 在系統提示中加入具體指令  

## 疑難排解  

### 常見問題  

**代理未自動被呼叫：**  
- 請確保您的請求明確指出領域（例如「效能問題」→ performance-engineer）  
- 明確指定任務類型（例如「審查程式碼」→ code-reviewer）  

**代理選擇不如預期：**  
- 提供更多有關技術架構及需求的背景  
- 若需特定代理，請明確呼叫  

**多個代理產生相互衝突的建議：**  
- 這很正常，不同專家有不同優先考量  
- 可要求釐清：「請協調 security-auditor 和 performance-engineer 的建議」  

**代理似乎缺乏背景資訊：**  
- 在請求中提供相關背景說明  
- 引用先前對話或既有模式  

### 尋求協助  

若代理運作未如預期：  
1. 檢查各代理個別檔案中的描述  
2. 在請求中嘗試更具體的語言  
3. 明確呼叫以測試特定代理  
4. 提供更多有關您的專案及目標的資訊  

## 授權

此專案採用 MIT 授權條款 - 詳情請參閱 [LICENSE](LICENSE) 檔案。

## 進一步了解

- [Claude Code 文件](https://docs.anthropic.com/en/docs/claude-code)
- [Subagents 文件](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---