
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
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

Các lệnh slash sẵn sàng cho sản xuất dành cho [Claude Code](https://docs.anthropic.com/en/docs/claude-code) giúp tăng tốc phát triển thông qua tự động hóa thông minh.

**52 lệnh** được tổ chức như sau:
- **🤖 Quy trình làm việc**: Điều phối đa tác vụ phụ cho các nhiệm vụ phức tạp
- **🔧 Công cụ**: Tiện ích chuyên biệt cho các thao tác cụ thể

### 🤝 Yêu cầu Claude Code Subagents

Các lệnh này hoạt động với [Claude Code Subagents](https://github.com/wshobson/agents) để có khả năng điều phối.

## Cài đặt

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Các Lệnh Có Sẵn

- **🤖 Quy trình công việc** - Điều phối nhiều subagent cho các nhiệm vụ phức tạp
- **🔧 Công cụ** - Lệnh đơn chức năng cho các thao tác cụ thể

## Cách Sử Dụng

Các lệnh được tổ chức trong thư mục `tools/` và `workflows/`. Sử dụng chúng với tiền tố thư mục:

```bash
/tools:api-scaffold user management with authentication
/tools:security-scan check for vulnerabilities
/workflows:feature-development implement chat functionality
```

**Lưu ý:** Nếu bạn muốn sử dụng các lệnh mà không cần tiền tố, bạn có thể làm phẳng các thư mục:
```bash
cp tools/*.md .
cp workflows/*.md .
```
Claude Code tự động đề xuất các lệnh liên quan dựa trên ngữ cảnh.

## 🤖 Quy trình làm việc

Điều phối đa tác tử phụ cho các nhiệm vụ phức tạp:

### Phát triển Tính năng
- **[phat-trien-tinh-nang](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Các tác tử phụ backend, frontend, kiểm thử và triển khai xây dựng tính năng hoàn chỉnh
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Nhiều tác tử phụ kiểm tra cung cấp phân tích mã toàn diện
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Phân tích sự cố và giao việc cho các chuyên gia phù hợp

### Quy trình Phát triển
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Triển khai quy trình Git hiệu quả với chiến lược nhánh và mẫu PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Cải thiện hiệu suất tác tử phụ qua tối ưu hóa prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Hiện đại hóa mã nguồn cũ với các tác tử phụ chuyên biệt
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Tạo pipeline ML với các tác tử phụ dữ liệu và kỹ thuật ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Xây dựng ứng dụng đa nền tảng với các tác tử phụ phối hợp
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Tự động hóa CI/CD, giám sát và quy trình triển khai

### Quy trình phối hợp tác tử phụ
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Tính năng đa nền tảng với các tác tử phụ backend, frontend và mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Triển khai ưu tiên bảo mật với các tác tử phụ chuyên trách
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Tính năng sử dụng ML với các tác tử phụ khoa học dữ liệu
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Tối ưu hóa đầu-cuối với các tác tử phụ hiệu suất
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Xử lý sự cố sản xuất với các tác tử phụ vận hành

## 🔧 Công cụ (Lệnh chuyên dụng)

### AI & Máy học
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Xây dựng trợ lý AI và chatbot sẵn sàng sản xuất
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Kiểm tra chuyên biệt cho mã nguồn AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Tạo tác tử LangChain/LangGraph với mẫu hiện đại
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Tạo pipeline ML đầu-cuối với MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Tối ưu prompt AI cho hiệu suất và chất lượng

### Kiến trúc & Chất lượng mã
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Sinh giải thích chi tiết cho mã phức tạp
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Di chuyển mã giữa các ngôn ngữ, framework hoặc phiên bản
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Tái cấu trúc mã để dễ bảo trì và nâng cao hiệu suất

- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Phân tích và ưu tiên hóa các khoản nợ kỹ thuật

### Dữ liệu & Cơ sở dữ liệu
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Thiết kế kiến trúc đường dẫn dữ liệu có khả năng mở rộng
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Triển khai hệ thống kiểm tra dữ liệu toàn diện
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Chiến lược di chuyển cơ sở dữ liệu nâng cao

### DevOps & Hạ tầng
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Tạo cấu hình và danh sách kiểm tra triển khai
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Chiến lược tối ưu hóa container nâng cao
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Triển khai Kubernetes đạt chuẩn sản xuất
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Thiết lập giám sát và khả năng quan sát toàn diện
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Triển khai Mục tiêu Cấp độ Dịch vụ (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Tự động hóa quy trình phát triển và vận hành

### Phát triển & Kiểm thử
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Tạo các mô hình API thực tế cho phát triển và kiểm thử
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Sinh điểm cuối API sẵn sàng sản xuất với đầy đủ ngăn xếp triển khai
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Tạo bộ test toàn diện với nhận diện framework

### Bảo mật & Tuân thủ
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kiểm tra và khắc phục khả năng tiếp cận toàn diện
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Đảm bảo tuân thủ quy định (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Quét bảo mật toàn diện với khắc phục tự động

### Gỡ lỗi & Phân tích
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Chiến lược gỡ lỗi và truy vết nâng cao
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Phân tích sâu mẫu lỗi và chiến lược xử lý
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Truy vết và chẩn đoán lỗi sản xuất
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Tạo issue GitHub/GitLab có cấu trúc tốt

### Phụ thuộc & Cấu hình
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Kiểm tra và quản lý cấu hình ứng dụng
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Kiểm tra các phụ thuộc về bảo mật và giấy phép
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Nâng cấp phụ thuộc dự án an toàn

### Tài liệu & Hợp tác
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Tạo tài liệu toàn diện
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Triển khai quy trình Git hiệu quả
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Nâng cao pull request với kiểm tra chất lượng

### Tối Ưu Chi Phí
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Tối ưu chi phí hạ tầng và đám mây

### Đón Nhận & Thiết Lập
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Thiết lập môi trường phát triển cho thành viên mới

### Công Cụ Tác Nhân Phụ
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Đánh giá mã nguồn đa góc nhìn với các tác nhân phụ chuyên biệt
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Gỡ lỗi sâu với tác nhân phụ kiểm tra hiệu năng và debug
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Tối ưu toàn stack với nhiều tác nhân phụ
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Lưu ngữ cảnh dự án bằng tác nhân phụ quản lý ngữ cảnh
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Khôi phục ngữ cảnh đã lưu để đảm bảo liên tục

## Tính Năng

- Triển khai sẵn sàng cho sản xuất
- Tự động phát hiện framework
- Thực hành bảo mật tốt nhất
- Giám sát và kiểm thử tích hợp sẵn
- Các lệnh hoạt động liền mạch cùng nhau

## Số Lượng Lệnh

**Tổng: 52 lệnh slash sẵn sàng sản xuất** được tổ chức thành:

### 🤖 Quy Trình Làm Việc (14 lệnh)

- Phát triển & Đánh giá tính năng (3 lệnh)
- Tự động hóa quy trình phát triển (6 lệnh)
- Quy trình phối hợp tác nhân phụ (5 lệnh)

### 🔧 Công Cụ (38 lệnh)

- AI & Máy học (5 lệnh)
- Kiến trúc & Chất lượng mã (4 lệnh)
- Dữ liệu & Cơ sở dữ liệu (3 lệnh)
- DevOps & Hạ tầng (6 lệnh)
- Phát triển & Kiểm thử (3 lệnh)
- Bảo mật & Tuân thủ (3 lệnh)
- Gỡ lỗi & Phân tích (4 lệnh)
- Phụ thuộc & Cấu hình (3 lệnh)
- Tài liệu & Hợp tác (1 lệnh)
- Khởi động & Thiết lập (1 lệnh)
- Công cụ dành riêng cho Subagent (5 lệnh)

## Ví dụ Sử dụng

### 🤖 Ví dụ Quy trình làm việc

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

### 🔧 Ví dụ về công cụ (Lệnh chuyên dụng)

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

## Lệnh Nâng Cao

### Bảo mật & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Quét bảo mật toàn diện với khả năng khắc phục tự động.

- **Quét đa công cụ**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Khắc phục tự động**: Tự động sửa các lỗ hổng phổ biến
- **Tích hợp CI/CD**: Kiểm tra bảo mật cho GitHub Actions/GitLab CI
- **Quét container**: Phân tích lỗ hổng hình ảnh container
- **Phát hiện bí mật**: Tích hợp GitLeaks và TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Chiến lược tối ưu hóa container nâng cao.

- **Tối ưu hóa thông minh**: Phân tích và đề xuất cải tiến
- **Xây dựng đa giai đoạn**: Dockerfile tối ưu hóa theo framework
- **Công cụ hiện đại**: BuildKit, Bun, UV giúp build nhanh hơn
- **Tăng cường bảo mật**: Ảnh distroless, người dùng không phải root
- **Tích hợp đa lệnh**: Hoạt động với kết quả của /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Triển khai Kubernetes đạt chuẩn sản xuất.

- **Mẫu nâng cao**: Tiêu chuẩn bảo mật Pod, Chính sách mạng, OPA
- **Sẵn sàng GitOps**: Cấu hình FluxCD và ArgoCD
- **Khả năng quan sát**: Prometheus ServiceMonitors, OpenTelemetry
- **Tự động mở rộng**: HPA, VPA và cấu hình cluster autoscaler
- **Service Mesh**: Tích hợp Istio/Linkerd

### Frontend & Dữ liệu

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Chiến lược di chuyển cơ sở dữ liệu nâng cao.

- **Đa Cơ Sở Dữ Liệu**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Không Gián Đoạn**: Triển khai blue-green, di chuyển dạng cuốn chiếu
- **Ghi Nhận Sự Kiện**: Tích hợp Kafka/Kinesis cho CDC
- **Đa Nền Tảng**: Xử lý lưu trữ đa ngôn ngữ
- **Giám Sát**: Kiểm tra sức khỏe di chuyển và hoàn nguyên

## Kết Hợp Các Quy Trình Làm Việc và Công Cụ

Sức mạnh thực sự đến từ việc kết hợp quy trình làm việc và công cụ cho chu kỳ phát triển hoàn chỉnh:

### Ví dụ: Xây Dựng Một Tính Năng Mới

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

### Ví dụ: Hiện đại hóa mã nguồn kế thừa

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

## Các Mẫu Điều Phối Lệnh

Các lệnh có thể được sử dụng riêng lẻ hoặc kết hợp theo các mẫu mạnh mẽ:

### Thực Thi Tuần Tự
```bash
# Build → Test → Secure → Deploy pipeline
/tools:api-scaffold user management API
/tools:test-harness comprehensive test suite for user API  
/tools:security-scan check user API for vulnerabilities
/tools:k8s-manifest deploy user API to production
```

### Phân Tích Song Song
```bash
# Multiple perspectives on the same codebase
/tools:multi-agent-review comprehensive architecture and code review
/tools:security-scan audit security posture  
/workflows:performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Tinh chỉnh lặp đi lặp lại
```bash
# Start broad, then narrow focus
/workflows:feature-development implement payment processing
/tools:security-scan focus on payment security
/tools:compliance-check ensure PCI compliance
/tools:test-harness add payment-specific tests
```

### Tích hợp đa miền
```bash
# Frontend + Backend + Infrastructure
/tools:api-scaffold backend payment API
/tools:multi-agent-optimize optimize payment flow performance
/tools:docker-optimize containerize payment service
/tools:monitor-setup payment metrics and alerts
```

## Khi nào sử dụng Workflows và khi nào sử dụng Tools

### 🔀 Workflows & Các công cụ Subagent
- **Giải quyết vấn đề**: Phân tích và khắc phục sự cố một cách thích ứng
- **Nhiều góc nhìn**: Phối hợp các subagent chuyên biệt
- **Nhiệm vụ phức tạp**: Quy trình nhiều bước trên nhiều lĩnh vực
- **Giải pháp chưa xác định**: Để các subagent quyết định cách tiếp cận

### 🛠️ Công cụ chuyên biệt
- **Thiết lập hạ tầng**: Cấu hình môi trường
- **Sinh mã nguồn**: Tạo ra các triển khai cụ thể
- **Phân tích**: Tạo báo cáo mà không cần sửa lỗi
- **Nhiệm vụ theo lĩnh vực**: Các thao tác chuyên môn cao

**Ví dụ:**
- "Triển khai hệ thống xác thực người dùng" → `/workflows:feature-development`
- "Khắc phục sự cố hiệu năng toàn bộ stack" → `/workflows:smart-fix`
- "Hiện đại hóa monolith kế thừa" → `/workflows:legacy-modernize`

### 🔧 Sử dụng Tools khi:
- **Cần chuyên môn cụ thể** - Nhiệm vụ rõ ràng, tập trung trong một lĩnh vực
- **Muốn kiểm soát chính xác** - Muốn chỉ định chi tiết triển khai cụ thể
- **Một phần của quy trình thủ công** - Tích hợp vào các quy trình hiện tại
- **Cần chuyên môn sâu** - Yêu cầu triển khai ở mức chuyên gia
- **Phát triển dựa trên công việc hiện có** - Nâng cấp hoặc tinh chỉnh đầu ra trước đó

**Ví dụ:**
- "Tạo manifest cho Kubernetes" → `/tools:k8s-manifest`
- "Quét lỗ hổng bảo mật" → `/tools:security-scan`
- "Sinh tài liệu API" → `/tools:doc-generate`

## Định dạng lệnh

Slash command là các file markdown đơn giản, nơi:
- Tên file trở thành tên lệnh (ví dụ: `tools/api-scaffold.md` → `/tools:api-scaffold`)
- Nội dung file là prompt/hướng dẫn được thực thi khi gọi lệnh
- Sử dụng placeholder `$ARGUMENTS` cho đầu vào của người dùng

## Thực hành tốt nhất

### Lựa chọn lệnh
- **Để Claude Code tự động đề xuất** - Phân tích ngữ cảnh và chọn lệnh tối ưu
- **Sử dụng quy trình cho tác vụ phức tạp** - Các subagent phối hợp thực hiện đa miền
- **Dùng công cụ cho tác vụ tập trung** - Áp dụng lệnh cụ thể để cải thiện mục tiêu

### Sử dụng hiệu quả
- **Cung cấp đầy đủ ngữ cảnh** - Bao gồm công nghệ, ràng buộc và yêu cầu
- **Chuỗi lệnh một cách chiến lược** - Quy trình → Công cụ → Tinh chỉnh
- **Xây dựng trên kết quả trước** - Các lệnh được thiết kế để phối hợp

## Đóng góp

1. Tạo file `.md` trong `workflows/` hoặc `tools/`
2. Dùng tên viết thường-ngăn-cách-bằng-gạch-nối
3. Thêm `$ARGUMENTS` cho đầu vào của người dùng

## Khắc phục sự cố

**Không tìm thấy lệnh**: 
- Kiểm tra file nằm trong `~/.claude/commands/tools/` hoặc `~/.claude/commands/workflows/`
- Dùng đúng tiền tố: `/tools:tên-lệnh` hoặc `/workflows:tên-lệnh`
- Hoặc làm phẳng thư mục nếu không muốn tiền tố: `cp tools/*.md . && cp workflows/*.md .`

**Quy trình chậm**: Bình thường - chúng phối hợp nhiều subagent

**Kết quả chung chung**: Thêm ngữ cảnh cụ thể về công nghệ của bạn

**Vấn đề tích hợp**: Kiểm tra đường dẫn file và thứ tự lệnh

## Mẹo tăng hiệu suất

**Lựa chọn lệnh:**
- **Quy trình**: Phối hợp nhiều subagent cho chức năng phức tạp
- **Công cụ**: Tác vụ đơn lẻ cho mục tiêu cụ thể
- **Chỉnh sửa đơn giản**: Giữ lại agent chính

**Tối ưu hóa:**
- Bắt đầu với công cụ cho vấn đề đã biết
- Cung cấp yêu cầu chi tiết ngay từ đầu
- Xây dựng dựa trên các đầu ra lệnh trước đó
- Để các quy trình hoàn thành trước khi chỉnh sửa

### Thêm một quy trình mới:
- Tập trung vào logic phối hợp và ủy quyền của các subagent
- Chỉ định các subagent chuyên biệt sẽ sử dụng và thứ tự thực hiện
- Định nghĩa các mẫu phối hợp giữa các subagent

### Thêm một công cụ mới:
- Bao gồm các triển khai đầy đủ, sẵn sàng cho sản xuất
- Cấu trúc nội dung với các phần rõ ràng và đầu ra có thể thực thi
- Bao gồm ví dụ, thực tiễn tốt nhất và điểm tích hợp

## Tìm hiểu thêm

- [Tài liệu Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Tài liệu Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Tài liệu Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code trên GitHub](https://github.com/anthropics/claude-code)
- [Bộ sưu tập Claude Code Subagents](https://github.com/wshobson/agents) - Các subagent chuyên biệt được sử dụng bởi các lệnh này


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-08

---