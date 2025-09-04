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

一套專為 [Claude Code](https://docs.anthropic.com/en/docs/claude-code) 設計的 AI 專業子代理全面集合，提升開發流程並注入領域專業知識。

## 概覽

本倉庫包含 76 個專業子代理，擴展了 Claude Code 的功能。每個子代理均為特定領域專家，可依據情境自動啟用或根據需求明確呼叫。所有代理均根據任務複雜度配置專屬 Claude 模型，兼顧效能與成本效益。

## 可用子代理

### 開發與架構
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - 設計 RESTful API、微服務邊界和資料庫結構
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - 建置 React 元件、實作響應式版面配置並處理前端狀態管理
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - 創建介面設計、線框圖與設計系統
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - 透過嚴謹的截圖分析，驗證 UI 修改是否達成預期目標
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - 開發具備原生整合的 React Native 或 Flutter 應用程式
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - 設計 GraphQL 結構、resolver 與聯邦架構
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - 審查程式碼變更，確保架構一致性與設計模式

### 語言專家
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - 撰寫具備進階功能與最佳化的 Python 慣用程式碼
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - 撰寫 Ruby 慣用語法，包含元編程、Rails 模式、gem 開發及測試框架
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - 撰寫具備 goroutines、channels 與介面的 Go 慣用語法
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - 撰寫具備所有權模式、生命週期與 trait 實作的 Rust 慣用語法
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - 撰寫高效 C 程式碼，具備適當記憶體管理與系統呼叫
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - 撰寫具備現代特性、RAII、智能指標與 STL 演算法的 C++ 慣用語法
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - 精通現代 JavaScript，包含 ES6+、非同步模式及 Node.js API
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - 精通 TypeScript，具備進階型別、泛型及嚴格型別安全
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - 撰寫具備現代特性與效能最佳化的 PHP 慣用語法
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - 精通現代 Java，包含串流、並行處理與 JVM 優化
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - 撰寫具備 OTP 模式、函數式程式設計與 Phoenix 框架的 Elixir 慣用語法
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - 撰寫具備進階特性及 .NET 優化的現代 C# 程式碼
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - 精通企業級 Scala 開發，涵蓋函數式程式設計、分散式系統與大數據處理
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - 精通 Flutter 開發，包含 Dart、元件和平台整合
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - 建置 Unity 遊戲，優化腳本與效能調校
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - 精通 Minecraft 伺服器外掛開發，包含 Bukkit、Spigot 與 Paper API
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - 使用 Swift/SwiftUI 開發原生 iOS 應用程式
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - 撰寫複雜 SQL 查詢、最佳化執行計畫並設計正規化資料結構

### 基礎建設與運維
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - 偵錯生產環境問題、分析日誌並修復部署失敗
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - 配置 CI/CD 流程、Docker 容器與雲端部署
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - 設計 AWS/Azure/GCP 基礎建設並最佳化雲端成本
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - 設計橫跨 AWS/Azure/GCP 及 OpenStack 本地環境的混合雲基礎建設
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - 以 Kubernetes 為核心設計雲原生基礎建設，並在 AWS/Azure/GCP 及混合環境中導入 GitOps 原則
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - 優化 SQL 查詢、設計高效索引並處理資料庫遷移
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - 管理資料庫操作、備份、複製與監控
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - 撰寫進階 Terraform 模組、管理狀態檔並實作 IaC 最佳實踐
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - 以急迫且精確的方式處理生產環境事故
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - 除錯網路連線、配置負載平衡器，以及分析流量模式
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - 提升開發者體驗，優化工具、設置與工作流程的專家

### 品質與安全
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - 專業的程式碼審查，深度關注配置安全與生產可靠性
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - 程式碼弱點審查並確保 OWASP 合規
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - 建立完整的單元、整合及端到端測試套件
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - 應用程式效能分析、瓶頸優化與快取策略實施
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - 錯誤、測試失敗與異常行為的除錯專家
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - 搜尋日誌與程式碼庫的錯誤模式、堆疊追蹤與異常
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - 採用進階搜尋技巧與綜合分析的網路研究專家

### 數據與人工智慧
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - SQL 查詢、BigQuery 操作與資料洞察的數據分析專家
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - 建置 ETL 流程、數據倉儲及串流架構
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - 建置 LLM 應用、RAG 系統與提示流程
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - 實作機器學習流程、模型服務與特徵工程
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - 建置 ML 流程、實驗追蹤及模型登錄
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - 為 LLM 及人工智慧系統優化提示詞

### 專業領域
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - 建立 OpenAPI/Swagger 規格並撰寫開發者文件
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - 整合 Stripe、PayPal 及各種支付處理器
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - 建構金融模型、回測交易策略並分析市場數據
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - 監控投資組合風險、R 倍數與持倉限制
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - 重構舊有程式碼庫並實施漸進式現代化
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - 管理多代理與長期任務的上下文

### 文件化
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - 從現有程式碼庫建立完整技術文件
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - 製作流程圖、序列、ERD 與架構的 Mermaid 圖表
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - 建立詳盡的技術參考與 API 文件
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - 依據程式碼製作逐步教學與教育內容

### 商業與行銷
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - 分析指標、製作報告並追蹤 KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - 撰寫部落格、社群內容與電子報
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** - 協助招聘、入職/離職、休假、績效、合規政策及員工關係
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - 草擬冷郵件、跟進信及提案模板
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - 處理支援票、FAQ 回覆及客戶信件
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - 起草隱私政策、服務條款、免責聲明和法律通知

### SEO 與內容優化
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - 分析所提供內容的品質、E-E-A-T 信號及 SEO 最佳實踐
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - 創建優化的 meta 標題、描述及 URL 建議
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - 分析關鍵字使用、計算密度、建議語意變化
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - 優化內容結構、標題層級及 schema 標記
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - 格式化內容以符合精選摘要及搜尋結果頁功能
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - 識別過時元素並提出內容更新建議
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - 分析多個頁面之關鍵字重疊與衝突
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - 分析內容的 E-E-A-T 信號及信任指標
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - 根據關鍵字與簡報撰寫 SEO 最佳化內容
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - 建立內容大綱、主題集群及日曆

## 模型分配

所有 76 個子代理皆依任務複雜度配置專屬 Claude 模型：

### 🚀 Haiku（快速且具成本效益）- 15 個代理
**模型：** `haiku`
- `data-scientist` - SQL 查詢及數據分析
- `api-documenter` - OpenAPI/Swagger 文件編寫
- `reference-builder` - 詳盡技術參考及 API 文件
- `business-analyst` - 指標及 KPI 追蹤
- `content-marketer` - 部落格文章及社群媒體
- `customer-support` - 支援票據及常見問答
- `sales-automator` - 冷郵件及提案書
- `search-specialist` - 網路研究與資訊收集
- `legal-advisor` - 隱私政策及合規文件
- `seo-meta-optimizer` - Meta 標題及描述最佳化
- `seo-keyword-strategist` - 關鍵字密度及語意分析
- `seo-structure-architect` - 內容結構及 schema 標記
- `seo-snippet-hunter` - 精選摘要格式化
- `seo-content-refresher` - 內容新鮮度更新
- `seo-cannibalization-detector` - 關鍵字重疊檢測
- `seo-content-planner` - 內容日曆及大綱

### ⚡ Sonnet（平衡效能）- 45 個代理
**模型：** `sonnet`

**開發與語言：**
- `python-pro` - Python 開發，具備進階功能
- `ruby-pro` - Ruby 開發，包含元編程、Rails 模式與 gem 開發
- `javascript-pro` - 現代 JavaScript 與 Node.js
- `typescript-pro` - 進階 TypeScript 型別系統
- `golang-pro` - Go 並行與慣用設計模式
- `rust-pro` - Rust 記憶體安全與系統程式設計
- `c-pro` - C 程式設計與嵌入式系統
- `cpp-pro` - 現代 C++，含 STL 與模板
- `php-pro` - 現代 PHP，具備進階功能
- `java-pro` - 現代 Java，含串流與並行
- `elixir-pro` - Elixir，具備 OTP 模式與 Phoenix
- `csharp-pro` - 現代 C#，含 .NET 架構與設計模式
- `scala-pro` - 企業級 Scala，含 Apache Pekko、Akka、Spark 及 ZIO/Cats Effect
- `flutter-expert` - Flutter 開發，含狀態管理與動畫
- `unity-developer` - Unity 遊戲開發與優化
- `minecraft-bukkit-pro` - Minecraft 插件開發，支援 Bukkit/Spigot/Paper
- `ios-developer` - 原生 iOS 開發，使用 Swift/SwiftUI
- `frontend-developer` - React 元件與 UI
- `ui-ux-designer` - 介面設計與線框稿
- `ui-visual-validator` - 通過截圖分析嚴格驗證 UI
- `backend-architect` - API 設計與微服務架構
- `mobile-developer` - React Native/Flutter 應用程式
- `sql-pro` - 複雜 SQL 優化
- `graphql-architect` - GraphQL 架構與解析器設計

**基礎設施與運維：**
- `devops-troubleshooter` - 生產環境除錯
- `deployment-engineer` - CI/CD 流程設計
- `database-optimizer` - 查詢優化
- `database-admin` - 資料庫運維
- `terraform-specialist` - 基礎設施即程式碼
- `network-engineer` - 網路設定
- `dx-optimizer` - 開發者體驗優化
- `data-engineer` - ETL 流程設計

**品質與支援：**
- `test-automator` - 測試套件建立
- `code-reviewer` - 程式碼品質分析
- `debugger` - 錯誤調查
- `error-detective` - 日誌分析
- `ml-engineer` - 機器學習模型部署
- `legacy-modernizer` - 框架遷移
- `payment-integration` - 支付處理
- `mermaid-expert` - Mermaid 圖表與視覺化文件
- `flutter-expert` - Flutter 開發
- `seo-content-auditor` - 內容品質與 E-E-A-T 分析
- `seo-authority-builder` - 權威信號優化
- `seo-content-writer` - SEO 優化內容創作

### 🧠 Opus（最高能力）- 15 個代理
**模型：** `opus`
- `ai-engineer` - LLM 應用及 RAG 系統
- `security-auditor` - 漏洞分析
- `performance-engineer` - 應用優化
- `incident-responder` - 線上事件處理
- `mlops-engineer` - 機器學習基礎建設
- `architect-reviewer` - 架構一致性審查
- `cloud-architect` - 雲端基礎建設設計
- `prompt-engineer` - LLM 提示優化
- `context-manager` - 多代理協作管理
- `quant-analyst` - 金融建模
- `risk-manager` - 投資組合風險管理
- `docs-architect` - 從程式碼庫生成完整技術文件
- `tutorial-engineer` - 按步教學與教育內容

## 安裝

這些子代理只需放置於 `~/.claude/agents/` 目錄下即可自動使用。

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

## 何時使用哪個代理

### 🏗️ 規劃與架構
- **backend-architect**：API 設計、資料庫結構、系統架構
- **frontend-developer**：UI/UX 規劃、元件架構
- **ui-ux-designer**：介面設計、線框圖、設計系統、用戶研究
- **cloud-architect**：基礎架構設計、可擴展性規劃

### 🔧 實作與開發  
- **python-pro**：專注於 Python 的開發任務
- **ruby-pro**：Ruby 元編程、Rails 應用程式、gem 開發、RSpec/Minitest 測試
- **golang-pro**：專注於 Go 的開發任務
- **rust-pro**：Rust 開發、記憶體安全、系統程式設計
- **c-pro**：C 程式設計、嵌入式系統、效能關鍵程式碼
- **javascript-pro**：現代 JavaScript、非同步模式、Node.js/瀏覽器程式碼
- **typescript-pro**：進階 TypeScript、泛型、型別推斷、企業級模式
- **java-pro**：現代 Java 開發、串流、並行、Spring Boot
- **elixir-pro**：Elixir 開發、OTP 模式、Phoenix 框架、函數式程式設計
- **csharp-pro**：現代 C# 開發、.NET 框架、企業級模式
- **scala-pro**：企業級 Scala 與函數式程式設計、Apache Pekko/Akka actors、Apache Spark、ZIO/Cats Effect、反應式架構
- **flutter-expert**：Flutter 開發、Dart、狀態管理、動畫、跨平台部署
- **unity-developer**：Unity 遊戲開發、C# 腳本、效能優化
- **minecraft-bukkit-pro**：Minecraft 外掛開發、事件系統、伺服器端功能
- **ios-developer**：原生 iOS 開發（Swift/SwiftUI）
- **sql-pro**：資料庫查詢、結構設計、查詢優化
- **mobile-developer**：React Native/Flutter 開發

### 🛠️ 運維與維護
- **devops-troubleshooter**：生產問題、部署困難
- **incident-responder**：重大故障需即時處理
- **database-optimizer**：查詢效能、索引策略
- **database-admin**：備份策略、複製、使用者管理、災難復原
- **terraform-specialist**：基礎架構即程式碼、Terraform 模組、狀態管理
- **network-engineer**：網路連線、負載平衡、SSL/TLS、DNS 偵錯

### 📊 分析與優化
- **performance-engineer**：應用程式瓶頸、效能優化
- **security-auditor**：漏洞掃描、合規性檢查
- **data-scientist**：資料分析、洞察、報告
- **mlops-engineer**：機器學習基礎設施、實驗追蹤、模型註冊庫、流程自動化

### 🧪 品質保證
- **code-reviewer**：程式碼品質、配置安全、產品可靠性
- **test-automator**：測試策略、測試套件建立
- **debugger**：錯誤調查、錯誤解決
- **error-detective**：日誌分析、錯誤模式辨識、根本原因分析
- **search-specialist**：深度網絡研究、競爭分析、事實查核

### 📚 文件化
- **api-documenter**：OpenAPI/Swagger 規範、API 文件
- **docs-architect**：全面性技術文件、架構指南、系統手冊
- **reference-builder**：詳盡 API 參考、配置指南、參數說明文件
- **tutorial-engineer**：逐步教學、學習路徑、教育內容

### 💼 商業與策略
- **business-analyst**：KPI、營收模型、成長預測、投資者指標
- **risk-manager**：投資組合風險、避險策略、R 倍數、部位規劃
- **content-marketer**：SEO 內容、部落格文章、社群媒體、電子郵件行銷
- **sales-automator**：冷郵件、後續跟進、提案、潛在客戶培育
- **customer-support**：支援單、常見問答、說明文件、疑難排解
- **legal-advisor** - 草擬隱私政策、服務條款、免責聲明及法律公告

## 最佳實踐

### 🎯 任務分派
1. **讓 Claude Code 自動分派** - 主代理分析情境並選擇最佳代理人
2. **明確說明需求** - 包含限制、技術堆疊及品質要求
3. **信任代理專業** - 每個代理皆針對其領域最佳化

### 🔄 多代理工作流程
4. **從高層次請求開始** - 讓代理協作完成複雜多步驟任務
5. **在代理間提供背景資訊** - 確保代理擁有必要的背景資料
6. **檢查整合點** - 檢查不同代理成果如何協同運作

### 🎛️ 明確控制
7. **針對特定需求明確呼叫** - 當你需要某專家的觀點時
8. **策略性結合多個代理** - 不同專家能相互驗證彼此成果
9. **要求特定審查模式** - 「請 security-auditor 審查 backend-architect 的 API 設計」

### 📈 最佳化
10. **監控代理效能** - 了解哪些代理最適合您的使用情境
11. **針對複雜任務反覆調整** - 使用代理回饋來完善需求
12. **發揮代理優勢** - 依任務複雜度選擇合適的代理能力

## 貢獻方式

要新增一個子代理：
1. 新建一個依照上述格式的 `.md` 檔案
2. 使用小寫且以連字號分隔的名稱
3. 撰寫明確描述何時應使用此子代理
4. 在系統提示中加入具體指令

## 疑難排解

### 常見問題

**代理未自動執行：**
- 請確認您的請求明確指出領域（例如，「效能問題」→ performance-engineer）
- 明確指定任務類型（例如，「審查程式碼」→ code-reviewer）

**代理選擇不如預期：**
- 提供更多有關技術堆疊及需求的資訊
- 若需要特定代理，請使用明確的呼叫方式

**多個代理給予相互衝突的建議：**
- 這屬正常現象—不同專家有不同優先事項
- 請求釐清：「協調 security-auditor 與 performance-engineer 的建議」

**代理似乎缺乏上下文：**
- 在請求中提供背景資訊
- 引用先前對話或既定模式

### 尋求協助

若代理未如預期運作：
1. 檢查各自檔案中的代理描述
2. 在請求中使用更具體的語言
3. 明確呼叫以測試特定代理
4. 提供更多有關您的專案及目標的資訊

## 授權

本專案採用 MIT 授權條款 - 詳情請參閱 [LICENSE](LICENSE) 檔案。

## 進一步瞭解

- [Claude Code 文件](https://docs.anthropic.com/en/docs/claude-code)
- [Subagents 文件](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---