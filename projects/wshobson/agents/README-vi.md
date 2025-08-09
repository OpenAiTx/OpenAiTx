<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

# Bộ Sưu Tập Subagent Claude Code

Bộ sưu tập toàn diện các subagent AI chuyên biệt cho [Claude Code](https://docs.anthropic.com/en/docs/claude-code), được thiết kế để nâng cao quy trình phát triển với chuyên môn theo từng lĩnh vực.

## Tổng Quan

Kho lưu trữ này chứa 58 subagent chuyên biệt mở rộng năng lực của Claude Code. Mỗi subagent là chuyên gia trong một lĩnh vực nhất định, được tự động kích hoạt dựa trên ngữ cảnh hoặc gọi trực tiếp khi cần. Tất cả các agent đều được cấu hình với các mô hình Claude cụ thể tùy theo độ phức tạp của nhiệm vụ nhằm tối ưu hiệu năng và chi phí.

## Các Subagent Hiện Có

### Phát triển & Kiến trúc
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - Thiết kế API RESTful, ranh giới vi dịch vụ và sơ đồ cơ sở dữ liệu
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Xây dựng các thành phần React, triển khai bố cục đáp ứng và quản lý trạng thái phía client
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - Tạo thiết kế giao diện, wireframe và hệ thống thiết kế
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - Phát triển ứng dụng React Native hoặc Flutter với tích hợp native
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - Thiết kế schema GraphQL, resolver và federation
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - Đánh giá thay đổi mã nguồn về tính nhất quán kiến trúc và mẫu thiết kế

### Chuyên gia ngôn ngữ
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - Viết mã Python chuẩn với tính năng nâng cao và tối ưu hóa
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - Viết mã Go chuẩn với goroutine, channel và interface
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - Viết mã Rust chuẩn với mô hình sở hữu, lifetime và triển khai trait
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - Viết mã C hiệu quả với quản lý bộ nhớ và gọi hệ thống đúng cách
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - Viết mã C++ chuẩn với tính năng hiện đại, RAII, smart pointer và thuật toán STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - Thành thạo JavaScript hiện đại với ES6+, mẫu async và API Node.js
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - Thành thạo TypeScript với kiểu nâng cao, generic và kiểm tra kiểu nghiêm ngặt
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - Viết mã PHP chuẩn với tính năng hiện đại và tối ưu hiệu năng
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - Thành thạo Java hiện đại với stream, xử lý đồng thời và tối ưu hóa JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - Viết mã Elixir chuẩn với mẫu OTP, lập trình hàm và framework Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - Viết mã C# hiện đại với tính năng nâng cao và tối ưu hóa .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - Thành thạo phát triển Scala cấp doanh nghiệp với lập trình hàm, hệ thống phân tán và xử lý dữ liệu lớn
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - Xây dựng game Unity với mã tối ưu và tinh chỉnh hiệu năng
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Thành thạo phát triển plugin server Minecraft với API Bukkit, Spigot và Paper
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Phát triển ứng dụng iOS native với Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - Viết truy vấn SQL phức tạp, tối ưu hóa kế hoạch thực thi và thiết kế sơ đồ chuẩn hóa

### Hạ tầng & Vận hành
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - Gỡ lỗi sự cố sản xuất, phân tích log và sửa lỗi triển khai
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - Cấu hình pipeline CI/CD, container Docker và triển khai đám mây
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - Thiết kế hạ tầng AWS/Azure/GCP và tối ưu chi phí đám mây
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - Tối ưu hóa truy vấn SQL, thiết kế chỉ mục hiệu quả và xử lý di chuyển cơ sở dữ liệu
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - Quản lý vận hành cơ sở dữ liệu, sao lưu, nhân bản và giám sát
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - Viết module Terraform nâng cao, quản lý file trạng thái và triển khai thực hành IaC tốt nhất
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - Xử lý sự cố sản xuất với sự khẩn trương và chính xác
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - Gỡ lỗi kết nối mạng, cấu hình cân bằng tải và phân tích lưu lượng
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - Chuyên gia trải nghiệm phát triển, cải thiện công cụ, thiết lập và quy trình làm việc

### Chất lượng & Bảo mật
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - Chuyên gia review mã nguồn với trọng tâm bảo mật cấu hình sâu và độ tin cậy sản xuất
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - Xem xét mã nguồn để tìm lỗ hổng và đảm bảo tuân thủ OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - Tạo bộ kiểm thử toàn diện với kiểm thử đơn vị, tích hợp và kiểm thử đầu cuối
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - Phân tích hiệu năng ứng dụng, tối ưu điểm nghẽn và triển khai chiến lược lưu trữ
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - Chuyên gia gỡ lỗi cho các lỗi, lỗi kiểm thử và hành vi bất thường
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - Tìm kiếm nhật ký và mã nguồn để phát hiện mẫu lỗi, dấu vết ngăn xếp và bất thường
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - Chuyên gia nghiên cứu web sử dụng kỹ thuật tìm kiếm nâng cao và tổng hợp

### Dữ liệu & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - Chuyên gia phân tích dữ liệu cho truy vấn SQL, thao tác BigQuery và phân tích dữ liệu
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - Xây dựng pipeline ETL, kho dữ liệu và kiến trúc streaming
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - Xây dựng ứng dụng LLM, hệ thống RAG và pipeline prompt
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - Triển khai pipeline ML, phục vụ mô hình và kỹ thuật đặc trưng
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - Xây dựng pipeline ML, theo dõi thử nghiệm và kho lưu trữ mô hình
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - Tối ưu hóa prompt cho LLM và hệ thống AI

### Lĩnh vực chuyên biệt
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - Tạo đặc tả OpenAPI/Swagger và viết tài liệu cho nhà phát triển
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Tích hợp Stripe, PayPal và các bộ xử lý thanh toán
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - Xây dựng mô hình tài chính, kiểm thử chiến lược giao dịch và phân tích dữ liệu thị trường
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - Giám sát rủi ro danh mục, hệ số R-multiples và giới hạn vị thế
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - Tái cấu trúc mã nguồn cũ và triển khai hiện đại hóa từng bước
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - Quản lý ngữ cảnh giữa nhiều tác vụ và agent chạy lâu dài

### Tài liệu kỹ thuật
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - Tạo tài liệu kỹ thuật toàn diện từ mã nguồn hiện có
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - Tạo sơ đồ Mermaid cho biểu đồ luồng, trình tự, ERD và kiến trúc
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - Tạo tài liệu tham khảo kỹ thuật và tài liệu API đầy đủ
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - Tạo hướng dẫn từng bước và nội dung giáo dục từ mã nguồn

### Kinh doanh & Tiếp thị
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - Phân tích số liệu, tạo báo cáo và theo dõi KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - Viết bài blog, nội dung mạng xã hội và bản tin email
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - Soạn email chào hàng, email theo dõi và mẫu đề xuất
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - Xử lý phiếu hỗ trợ, phản hồi FAQ và email khách hàng
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - Soạn thảo chính sách bảo mật, điều khoản dịch vụ, tuyên bố từ chối trách nhiệm và thông báo pháp lý

## Gán mô hình

Tất cả 58 subagent được cấu hình với các mô hình Claude cụ thể dựa trên độ phức tạp của nhiệm vụ:

### 🚀 Haiku (Nhanh & Hiệu Quả Chi Phí) - 9 tác nhân
**Mô hình:** `haiku`
- `data-scientist` - Truy vấn SQL và phân tích dữ liệu
- `api-documenter` - Tài liệu OpenAPI/Swagger
- `reference-builder` - Tài liệu tham khảo kỹ thuật và API đầy đủ
- `business-analyst` - Theo dõi số liệu và KPI
- `content-marketer` - Bài viết blog và mạng xã hội
- `customer-support` - Phiếu hỗ trợ và Câu hỏi thường gặp
- `sales-automator` - Email tiếp cận lạnh và đề xuất
- `search-specialist` - Nghiên cứu web và thu thập thông tin
- `legal-advisor` - Chính sách quyền riêng tư và tài liệu tuân thủ

### ⚡ Sonnet (Cân Bằng Hiệu Năng) - 36 tác nhân
**Mô hình:** `sonnet`

**Phát triển & Ngôn ngữ:**
- `python-pro` - Phát triển Python với tính năng nâng cao
- `javascript-pro` - JavaScript hiện đại và Node.js
- `typescript-pro` - TypeScript nâng cao với hệ thống kiểu
- `golang-pro` - Đa luồng Go và các mẫu chuẩn
- `rust-pro` - An toàn bộ nhớ Rust và lập trình hệ thống
- `c-pro` - Lập trình C và hệ nhúng
- `cpp-pro` - C++ hiện đại với STL và mẫu
- `php-pro` - PHP hiện đại với tính năng nâng cao
- `java-pro` - Java hiện đại với streams và đa luồng
- `elixir-pro` - Elixir với các mẫu OTP và Phoenix
- `csharp-pro` - C# hiện đại với .NET frameworks và mẫu
- `scala-pro` - Scala doanh nghiệp với Apache Pekko, Akka, Spark và ZIO/Cats Effect
- `unity-developer` - Phát triển game Unity và tối ưu hóa
- `minecraft-bukkit-pro` - Phát triển plugin Minecraft với Bukkit/Spigot/Paper
- `ios-developer` - Phát triển iOS native với Swift/SwiftUI
- `frontend-developer` - Component React và giao diện người dùng
- `ui-ux-designer` - Thiết kế giao diện và khung dây
- `backend-architect` - Thiết kế API và microservices
- `mobile-developer` - Ứng dụng React Native/Flutter
- `sql-pro` - Tối ưu hóa SQL phức tạp
- `graphql-architect` - Schema và resolver GraphQL

**Hạ tầng & Vận hành:**
- `devops-troubleshooter` - Gỡ lỗi sản xuất
- `deployment-engineer` - Các pipeline CI/CD
- `database-optimizer` - Tối ưu hóa truy vấn
- `database-admin` - Vận hành cơ sở dữ liệu
- `terraform-specialist` - Hạ tầng dưới dạng mã nguồn (Infrastructure as Code)
- `network-engineer` - Cấu hình mạng
- `dx-optimizer` - Tối ưu trải nghiệm nhà phát triển
- `data-engineer` - Các pipeline ETL

**Chất lượng & Hỗ trợ:**
- `test-automator` - Tạo bộ kiểm thử tự động
- `code-reviewer` - Phân tích chất lượng mã nguồn
- `debugger` - Điều tra lỗi
- `error-detective` - Phân tích nhật ký
- `ml-engineer` - Triển khai mô hình ML
- `legacy-modernizer` - Di chuyển framework cũ
- `payment-integration` - Xử lý thanh toán
- `mermaid-expert` - Lưu đồ Mermaid và tài liệu trực quan

### 🧠 Opus (Năng lực tối đa) - 13 tác nhân
**Mô hình:** `opus`
- `ai-engineer` - Ứng dụng LLM và hệ thống RAG
- `security-auditor` - Phân tích lỗ hổng bảo mật
- `performance-engineer` - Tối ưu hóa ứng dụng
- `incident-responder` - Xử lý sự cố trong môi trường sản xuất
- `mlops-engineer` - Hạ tầng triển khai ML
- `architect-reviewer` - Đánh giá kiến trúc nhất quán
- `cloud-architect` - Thiết kế hạ tầng đám mây
- `prompt-engineer` - Tối ưu hóa prompt cho LLM
- `context-manager` - Điều phối đa tác nhân
- `quant-analyst` - Mô hình tài chính
- `risk-manager` - Quản lý rủi ro danh mục đầu tư
- `docs-architect` - Tài liệu kỹ thuật toàn diện từ mã nguồn
- `tutorial-engineer` - Hướng dẫn từng bước và nội dung giáo dục

## Cài đặt

Các subagent này sẽ tự động khả dụng khi được đặt trong thư mục `~/.claude/agents/`.

```bash
cd ~/.claude
git clone https://github.com/wshobson/agents.git
```

## Sử dụng

### Kích hoạt tự động
Claude Code sẽ tự động ủy quyền cho phân tác phù hợp dựa trên ngữ cảnh nhiệm vụ và mô tả của phân tác đó.

### Kích hoạt thủ công
Đề cập tên phân tác trong yêu cầu của bạn:
```
"Use the code-reviewer to check my recent changes"
"Have the security-auditor scan for vulnerabilities"
"Get the performance-engineer to optimize this bottleneck"
```

## Ví dụ Sử Dụng

### Nhiệm Vụ Một Tác Nhân
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

### Quy trình làm việc đa tác nhân

Các tác nhân phụ này phối hợp với nhau một cách liền mạch, và đối với các điều phối phức tạp hơn, bạn có thể sử dụng bộ sưu tập **[Claude Code Commands](https://github.com/wshobson/commands)** gồm 52 lệnh gạch chéo dựng sẵn, tận dụng các tác nhân phụ này trong các quy trình làm việc tinh vi.

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

### Quy trình nâng cao với Slash Commands

Để phối hợp nhiều subagent phức tạp hơn, hãy sử dụng kho [Commands repository](https://github.com/wshobson/commands) đi kèm:

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

## Định Dạng Đại Lý Phụ

Mỗi đại lý phụ tuân theo cấu trúc sau:
```markdown
---
name: subagent-name
description: When this subagent should be invoked
model: haiku  # Optional - specify which model to use (haiku/sonnet/opus)
tools: tool1, tool2  # Optional - defaults to all tools
---

System prompt defining the subagent's role and capabilities
```

### Cấu Hình Mô Hình

Từ phiên bản Claude Code v1.0.64, các subagent có thể chỉ định mô hình Claude mà chúng sẽ sử dụng. Điều này cho phép phân bổ nhiệm vụ hiệu quả về chi phí dựa trên độ phức tạp:

- **Độ phức tạp thấp (Haiku)**: Các nhiệm vụ đơn giản như phân tích dữ liệu cơ bản, tạo tài liệu, và phản hồi tiêu chuẩn
- **Độ phức tạp trung bình (Sonnet)**: Nhiệm vụ phát triển, kiểm tra mã, kiểm thử, và công việc kỹ thuật tiêu chuẩn  
- **Độ phức tạp cao (Opus)**: Nhiệm vụ quan trọng như kiểm toán bảo mật, đánh giá kiến trúc, ứng phó sự cố, và kỹ thuật AI/ML

Các mô hình có sẵn (dùng tên gọi đơn giản theo Claude Code v1.0.64):
- `haiku` - Nhanh và tiết kiệm chi phí cho các nhiệm vụ đơn giản
- `sonnet` - Hiệu năng cân bằng cho hầu hết công việc phát triển
- `opus` - Năng lực mạnh nhất cho phân tích phức tạp và nhiệm vụ quan trọng

Nếu không chỉ định mô hình, subagent sẽ sử dụng mô hình mặc định của hệ thống.

## Mẫu Điều Phối Agent

Claude Code tự động phối hợp các agent bằng các mẫu phổ biến sau:

### Quy trình công việc tuần tự
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

### Rẽ Nhánh Có Điều Kiện
```
User Request → Analysis → Route to appropriate specialist

Example: "Fix this bug"
debugger (analyzes) → Routes to: backend-architect OR frontend-developer OR devops-troubleshooter
```

### Xem xét & Xác thực
```
Primary Agent → Review Agent → Final Result

Example: "Implement payment processing"
payment-integration → security-auditor → Validated implementation
```
## Khi Nào Sử Dụng Agent Nào

### 🏗️ Lập Kế Hoạch & Kiến Trúc
- **backend-architect**: Thiết kế API, sơ đồ cơ sở dữ liệu, kiến trúc hệ thống
- **frontend-developer**: Lập kế hoạch UI/UX, kiến trúc thành phần giao diện
- **ui-ux-designer**: Thiết kế giao diện, wireframe, hệ thống thiết kế, nghiên cứu người dùng
- **cloud-architect**: Thiết kế hạ tầng, lập kế hoạch mở rộng quy mô

### 🔧 Triển Khai & Phát Triển  
- **python-pro**: Nhiệm vụ phát triển chuyên về Python
- **golang-pro**: Nhiệm vụ phát triển chuyên về Go
- **rust-pro**: Phát triển với Rust, an toàn bộ nhớ, lập trình hệ thống
- **c-pro**: Lập trình C, hệ thống nhúng, mã tối ưu hiệu năng
- **javascript-pro**: JavaScript hiện đại, async, Node.js/trình duyệt
- **typescript-pro**: TypeScript nâng cao, generic, suy luận kiểu, mô hình doanh nghiệp
- **java-pro**: Phát triển Java hiện đại, streams, concurrency, Spring Boot
- **elixir-pro**: Phát triển Elixir, mô hình OTP, Phoenix, lập trình hàm
- **csharp-pro**: Phát triển C# hiện đại, .NET, mô hình doanh nghiệp
- **scala-pro**: Scala doanh nghiệp với lập trình hàm, Apache Pekko/Akka, Apache Spark, ZIO/Cats Effect, kiến trúc reactive
- **unity-developer**: Phát triển game Unity, lập trình C#, tối ưu hiệu năng
- **minecraft-bukkit-pro**: Phát triển plugin Minecraft, hệ thống sự kiện, tính năng phía server
- **ios-developer**: Phát triển iOS native với Swift/SwiftUI
- **sql-pro**: Truy vấn cơ sở dữ liệu, thiết kế schema, tối ưu truy vấn
- **mobile-developer**: Phát triển React Native/Flutter

### 🛠️ Vận Hành & Bảo Trì
- **devops-troubleshooter**: Vấn đề sản xuất, sự cố triển khai
- **incident-responder**: Sự cố nghiêm trọng cần phản ứng ngay
- **database-optimizer**: Hiệu năng truy vấn, chiến lược lập chỉ mục
- **database-admin**: Chiến lược backup, nhân bản, quản lý người dùng, phục hồi thảm họa
- **terraform-specialist**: Hạ tầng dưới dạng mã, module Terraform, quản lý trạng thái
- **network-engineer**: Kết nối mạng, cân bằng tải, SSL/TLS, gỡ lỗi DNS

### 📊 Phân Tích & Tối Ưu
- **performance-engineer**: Điểm nghẽn ứng dụng, tối ưu hóa
- **security-auditor**: Quét lỗ hổng, kiểm tra tuân thủ
- **data-scientist**: Phân tích dữ liệu, rút ra insight, báo cáo
- **mlops-engineer**: Hạ tầng ML, theo dõi thí nghiệm, quản lý model, tự động hóa pipeline


### 🧪 Đảm Bảo Chất Lượng
- **code-reviewer**: Chất lượng mã, bảo mật cấu hình, độ tin cậy sản phẩm
- **test-automator**: Chiến lược kiểm thử, tạo bộ kiểm thử
- **debugger**: Điều tra lỗi, giải quyết sự cố
- **error-detective**: Phân tích log, nhận diện mẫu lỗi, phân tích nguyên nhân gốc rễ
- **search-specialist**: Nghiên cứu web chuyên sâu, phân tích đối thủ, kiểm tra sự thật

### 📚 Tài Liệu
- **api-documenter**: Đặc tả OpenAPI/Swagger, tài liệu API
- **docs-architect**: Tài liệu kỹ thuật toàn diện, hướng dẫn kiến trúc, sổ tay hệ thống
- **reference-builder**: Tham khảo API đầy đủ, hướng dẫn cấu hình, tài liệu tham số
- **tutorial-engineer**: Hướng dẫn từng bước, lộ trình học, nội dung giáo dục

### 💼 Kinh Doanh & Chiến Lược
- **business-analyst**: KPI, mô hình doanh thu, dự báo tăng trưởng, chỉ số nhà đầu tư
- **risk-manager**: Rủi ro danh mục, chiến lược phòng ngừa, R-multiples, định cỡ vị thế
- **content-marketer**: Nội dung SEO, bài blog, mạng xã hội, chiến dịch email
- **sales-automator**: Email lạnh, theo dõi, đề xuất, nuôi dưỡng khách hàng tiềm năng
- **customer-support**: Phiếu hỗ trợ, câu hỏi thường gặp, tài liệu trợ giúp, xử lý sự cố
- **legal-advisor** - Soạn thảo chính sách bảo mật, điều khoản dịch vụ, tuyên bố miễn trừ, thông báo pháp lý

## Thực Tiễn Tốt Nhất

### 🎯 Phân Công Nhiệm Vụ
1. **Để Claude Code tự động phân công** - Tác nhân chính phân tích ngữ cảnh và chọn tác nhân tối ưu
2. **Cụ thể về yêu cầu** - Bao gồm các ràng buộc, công nghệ sử dụng, và yêu cầu chất lượng
3. **Tin tưởng vào chuyên môn của tác nhân** - Mỗi tác nhân được tối ưu cho lĩnh vực của mình

### 🔄 Quy Trình Đa Tác Nhân
4. **Bắt đầu bằng yêu cầu cấp cao** - Để các tác nhân phối hợp thực hiện nhiệm vụ phức tạp nhiều bước
5. **Cung cấp bối cảnh giữa các tác nhân** - Đảm bảo các tác nhân có đủ thông tin nền cần thiết
6. **Xem lại các điểm tích hợp** - Kiểm tra cách các sản phẩm của các tác nhân phối hợp với nhau

### 🎛️ Kiểm Soát Tường Minh
7. **Dùng gọi tường minh cho nhu cầu cụ thể** - Khi bạn muốn góc nhìn từ chuyên gia cụ thể
8. **Kết hợp nhiều tác nhân một cách chiến lược** - Các chuyên gia khác nhau có thể xác thực lẫn nhau
9. **Yêu cầu mẫu đánh giá cụ thể** - "Hãy để security-auditor đánh giá thiết kế API của backend-architect"

### 📈 Tối Ưu Hóa
10. **Theo dõi hiệu quả tác nhân** - Tìm hiểu tác nhân nào phù hợp nhất với trường hợp sử dụng của bạn
11. **Lặp lại các nhiệm vụ phức tạp** - Sử dụng phản hồi của tác nhân để tinh chỉnh yêu cầu
12. **Tận dụng thế mạnh của tác nhân** - Phù hợp độ phức tạp của nhiệm vụ với khả năng của tác nhân

## Đóng góp

Để thêm một subagent mới:
1. Tạo một file `.md` mới theo định dạng phía trên
2. Sử dụng tên viết thường, cách nhau bằng dấu gạch ngang
3. Viết mô tả rõ ràng về thời điểm sử dụng subagent
4. Bao gồm hướng dẫn cụ thể trong nhắc hệ thống

## Khắc phục sự cố

### Vấn đề thường gặp

**Tác nhân không được kích hoạt tự động:**
- Đảm bảo yêu cầu của bạn chỉ rõ lĩnh vực (ví dụ, "vấn đề hiệu năng" → performance-engineer)
- Cụ thể về loại nhiệm vụ (ví dụ, "kiểm tra mã" → code-reviewer)

**Lựa chọn tác nhân không như mong đợi:**
- Cung cấp thêm thông tin về công nghệ và yêu cầu của bạn
- Sử dụng kích hoạt rõ ràng nếu cần một tác nhân cụ thể

**Nhiều tác nhân đưa ra lời khuyên mâu thuẫn:**
- Điều này là bình thường - các chuyên gia khác nhau có thể ưu tiên khác nhau
- Yêu cầu làm rõ: "Hòa giải khuyến nghị từ security-auditor và performance-engineer"

**Tác nhân có vẻ thiếu ngữ cảnh:**
- Cung cấp thông tin nền trong yêu cầu của bạn
- Tham chiếu các cuộc trò chuyện trước hoặc mẫu đã thiết lập

### Hỗ trợ

Nếu các tác nhân không hoạt động như mong đợi:
1. Kiểm tra mô tả tác nhân trong từng file riêng
2. Thử sử dụng ngôn ngữ cụ thể hơn trong yêu cầu
3. Dùng kích hoạt rõ ràng để kiểm tra từng tác nhân cụ thể
4. Cung cấp thêm ngữ cảnh về dự án và mục tiêu của bạn

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT - xem tệp [LICENSE](LICENSE) để biết chi tiết.

## Tìm hiểu thêm

- [Tài liệu Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Tài liệu Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code trên GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-09

---