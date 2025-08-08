
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
- **🤖 Quy trình**: Điều phối đa tác vụ cho các nhiệm vụ phức tạp
- **🔧 Công cụ**: Tiện ích chuyên biệt cho các thao tác cụ thể

### 🤝 Yêu cầu các Subagent Claude Code

Các lệnh này hoạt động với [Claude Code Subagents](https://github.com/wshobson/agents) để có khả năng điều phối.

## Cài đặt

```bash
cd ~/.claude
git clone https://github.com/wshobson/commands.git
git clone https://github.com/wshobson/agents.git  # Required for subagent orchestration
```

## Các lệnh có sẵn

- **🤖 Quy trình làm việc** - Điều phối nhiều tác nhân phụ cho các nhiệm vụ phức tạp
- **🔧 Công cụ** - Lệnh đơn chức năng cho các thao tác cụ thể

## Cách sử dụng

```bash
/api-scaffold user management with authentication
/security-scan check for vulnerabilities
/feature-development implement chat functionality
```
Claude Code tự động đề xuất các lệnh liên quan dựa trên ngữ cảnh.

## 🤖 Quy trình làm việc

Điều phối đa tác tử phụ cho các nhiệm vụ phức tạp:

### Phát triển Tính năng
- **[feature-development](https://raw.githubusercontent.com/wshobson/commands/main/workflows/feature-development.md)** - Các tác tử phụ backend, frontend, kiểm thử và triển khai xây dựng tính năng hoàn chỉnh
- **[full-review](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-review.md)** - Nhiều tác tử phụ đánh giá cung cấp phân tích mã toàn diện
- **[smart-fix](https://raw.githubusercontent.com/wshobson/commands/main/workflows/smart-fix.md)** - Phân tích sự cố và phân công cho các tác tử phụ chuyên biệt phù hợp

### Quy trình Phát triển
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/workflows/git-workflow.md)** - Triển khai quy trình Git hiệu quả với chiến lược nhánh và mẫu PR
- **[improve-agent](https://raw.githubusercontent.com/wshobson/commands/main/workflows/improve-agent.md)** - Nâng cao hiệu suất tác tử phụ thông qua tối ưu hóa prompt
- **[legacy-modernize](https://raw.githubusercontent.com/wshobson/commands/main/workflows/legacy-modernize.md)** - Hiện đại hóa mã nguồn cũ bằng các tác tử phụ chuyên biệt
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/workflows/ml-pipeline.md)** - Tạo pipeline ML với các tác tử phụ về dữ liệu và kỹ thuật ML
- **[multi-platform](https://raw.githubusercontent.com/wshobson/commands/main/workflows/multi-platform.md)** - Xây dựng ứng dụng đa nền tảng với tác tử phụ phối hợp
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/workflows/workflow-automate.md)** - Tự động hóa quy trình CI/CD, giám sát và triển khai

### Quy trình phối hợp Tác tử phụ
- **[full-stack-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/full-stack-feature.md)** - Tính năng đa nền tảng với các tác tử phụ backend, frontend và mobile
- **[security-hardening](https://raw.githubusercontent.com/wshobson/commands/main/workflows/security-hardening.md)** - Triển khai ưu tiên bảo mật với các tác tử phụ chuyên biệt
- **[data-driven-feature](https://raw.githubusercontent.com/wshobson/commands/main/workflows/data-driven-feature.md)** - Tính năng ứng dụng ML với các tác tử phụ khoa học dữ liệu
- **[performance-optimization](https://raw.githubusercontent.com/wshobson/commands/main/workflows/performance-optimization.md)** - Tối ưu hóa đầu-cuối với các tác tử phụ hiệu năng
- **[incident-response](https://raw.githubusercontent.com/wshobson/commands/main/workflows/incident-response.md)** - Giải quyết sự cố sản xuất với các tác tử phụ vận hành

## 🔧 Công cụ (Lệnh Đơn Nhiệm)

### AI & Máy học
- **[ai-assistant](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-assistant.md)** - Xây dựng trợ lý AI và chatbot sẵn sàng cho sản xuất
- **[ai-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/ai-review.md)** - Đánh giá chuyên biệt cho mã nguồn AI/ML
- **[langchain-agent](https://raw.githubusercontent.com/wshobson/commands/main/tools/langchain-agent.md)** - Tạo tác tử LangChain/LangGraph với mẫu hiện đại
- **[ml-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/ml-pipeline.md)** - Tạo pipeline ML đầu-cuối với MLOps
- **[prompt-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/prompt-optimize.md)** - Tối ưu hóa prompt AI cho hiệu suất và chất lượng

### Kiến trúc & Chất lượng Mã
- **[code-explain](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-explain.md)** - Tạo giải thích chi tiết cho mã phức tạp
- **[code-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/code-migrate.md)** - Di chuyển mã giữa các ngôn ngữ, framework hoặc phiên bản
- **[refactor-clean](https://raw.githubusercontent.com/wshobson/commands/main/tools/refactor-clean.md)** - Tái cấu trúc mã để dễ bảo trì và nâng cao hiệu suất
- **[tech-debt](https://raw.githubusercontent.com/wshobson/commands/main/tools/tech-debt.md)** - Phân tích và ưu tiên nợ kỹ thuật

### Dữ liệu & Cơ sở dữ liệu
- **[data-pipeline](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-pipeline.md)** - Thiết kế kiến trúc pipeline dữ liệu có khả năng mở rộng
- **[data-validation](https://raw.githubusercontent.com/wshobson/commands/main/tools/data-validation.md)** - Triển khai hệ thống xác thực dữ liệu toàn diện
- **[db-migrate](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)** - Chiến lược di chuyển cơ sở dữ liệu nâng cao

### DevOps & Hạ tầng
- **[deploy-checklist](https://raw.githubusercontent.com/wshobson/commands/main/tools/deploy-checklist.md)** - Tạo cấu hình và danh sách kiểm tra triển khai
- **[docker-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)** - Chiến lược tối ưu hóa container nâng cao
- **[k8s-manifest](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)** - Triển khai Kubernetes đạt chuẩn sản xuất
- **[monitor-setup](https://raw.githubusercontent.com/wshobson/commands/main/tools/monitor-setup.md)** - Thiết lập hệ thống giám sát và quan sát toàn diện
- **[slo-implement](https://raw.githubusercontent.com/wshobson/commands/main/tools/slo-implement.md)** - Triển khai Mục tiêu Mức độ Dịch vụ (SLO)
- **[workflow-automate](https://raw.githubusercontent.com/wshobson/commands/main/tools/workflow-automate.md)** - Tự động hóa quy trình phát triển và vận hành

### Phát triển & Kiểm thử
- **[api-mock](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-mock.md)** - Tạo mock API thực tế phục vụ phát triển và kiểm thử
- **[api-scaffold](https://raw.githubusercontent.com/wshobson/commands/main/tools/api-scaffold.md)** - Tạo endpoint API sẵn sàng sản xuất với ngăn xếp đầy đủ
- **[test-harness](https://raw.githubusercontent.com/wshobson/commands/main/tools/test-harness.md)** - Tạo bộ kiểm thử toàn diện với tự động nhận diện framework

### Bảo mật & Tuân thủ
- **[accessibility-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/accessibility-audit.md)** - Kiểm tra và sửa lỗi khả năng truy cập toàn diện
- **[compliance-check](https://raw.githubusercontent.com/wshobson/commands/main/tools/compliance-check.md)** - Đảm bảo tuân thủ quy định (GDPR, HIPAA, SOC2)
- **[security-scan](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)** - Quét bảo mật toàn diện với khắc phục tự động

### Gỡ lỗi & Phân tích
- **[debug-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/debug-trace.md)** - Chiến lược gỡ lỗi và truy vết nâng cao
- **[error-analysis](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-analysis.md)** - Phân tích mẫu lỗi sâu và phương án khắc phục
- **[error-trace](https://raw.githubusercontent.com/wshobson/commands/main/tools/error-trace.md)** - Truy vết và chẩn đoán lỗi sản xuất
- **[issue](https://raw.githubusercontent.com/wshobson/commands/main/tools/issue.md)** - Tạo issue GitHub/GitLab có cấu trúc tốt

### Phụ thuộc & Cấu hình
- **[config-validate](https://raw.githubusercontent.com/wshobson/commands/main/tools/config-validate.md)** - Xác thực và quản lý cấu hình ứng dụng
- **[deps-audit](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-audit.md)** - Kiểm toán phụ thuộc về bảo mật và bản quyền
- **[deps-upgrade](https://raw.githubusercontent.com/wshobson/commands/main/tools/deps-upgrade.md)** - Nâng cấp phụ thuộc dự án an toàn

### Tài liệu & Hợp tác
- **[doc-generate](https://raw.githubusercontent.com/wshobson/commands/main/tools/doc-generate.md)** - Tạo tài liệu toàn diện
- **[git-workflow](https://raw.githubusercontent.com/wshobson/commands/main/tools/git-workflow.md)** - Triển khai quy trình Git hiệu quả
- **[pr-enhance](https://raw.githubusercontent.com/wshobson/commands/main/tools/pr-enhance.md)** - Nâng cấp pull request với kiểm tra chất lượng

### Tối ưu hóa Chi phí
- **[cost-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/cost-optimize.md)** - Tối ưu hóa chi phí hạ tầng và cloud

### Onboarding & Thiết lập
- **[onboard](https://raw.githubusercontent.com/wshobson/commands/main/tools/onboard.md)** - Thiết lập môi trường phát triển cho thành viên mới

### Công cụ Tác tử phụ
- **[multi-agent-review](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-review.md)** - Đánh giá mã đa góc nhìn với các tác tử phụ chuyên biệt
- **[smart-debug](https://raw.githubusercontent.com/wshobson/commands/main/tools/smart-debug.md)** - Gỡ lỗi sâu với tác tử phụ debugger và hiệu năng
- **[multi-agent-optimize](https://raw.githubusercontent.com/wshobson/commands/main/tools/multi-agent-optimize.md)** - Tối ưu hóa full-stack với nhiều tác tử phụ
- **[context-save](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-save.md)** - Lưu ngữ cảnh dự án bằng tác tử phụ quản lý ngữ cảnh
- **[context-restore](https://raw.githubusercontent.com/wshobson/commands/main/tools/context-restore.md)** - Khôi phục ngữ cảnh đã lưu để đảm bảo liên tục

## Tính năng

- Triển khai sẵn sàng cho sản xuất
- Tự động nhận diện framework
- Thực hành bảo mật tốt nhất
- Tích hợp sẵn giám sát và kiểm thử

- Các lệnh hoạt động cùng nhau một cách liền mạch

## Số lượng lệnh

**Tổng cộng: 52 lệnh slash sẵn sàng cho sản xuất** được tổ chức thành:

### 🤖 Quy trình làm việc (14 lệnh)

- Phát triển & Đánh giá Tính năng (3 lệnh)
- Tự động hóa Quy trình Phát triển (6 lệnh)
- Quy trình do Subagent điều phối (5 lệnh)

### 🔧 Công cụ (38 lệnh)

- AI & Máy học (5 lệnh)
- Kiến trúc & Chất lượng mã (4 lệnh)
- Dữ liệu & Cơ sở dữ liệu (3 lệnh)
- DevOps & Hạ tầng (6 lệnh)
- Phát triển & Kiểm thử (3 lệnh)
- Bảo mật & Tuân thủ (3 lệnh)
- Gỡ lỗi & Phân tích (4 lệnh)
- Phụ thuộc & Cấu hình (3 lệnh)
- Tài liệu & Hợp tác (1 lệnh)
- Giới thiệu & Thiết lập (1 lệnh)
- Công cụ dành riêng cho Subagent (5 lệnh)

## Ví dụ sử dụng

### 🤖 Ví dụ về Quy trình

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

### 🔧 Ví dụ về công cụ (Lệnh chuyên dụng)

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

## Lệnh Nâng Cao

### Bảo mật & DevOps

#### [`/security-scan`](https://raw.githubusercontent.com/wshobson/commands/main/tools/security-scan.md)

Quét bảo mật toàn diện với khắc phục tự động.

- **Quét đa công cụ**: Bandit, Safety, Trivy, Semgrep, ESLint Security, Snyk
- **Khắc phục tự động**: Tự động sửa chữa các lỗ hổng phổ biến
- **Tích hợp CI/CD**: Cổng bảo mật cho GitHub Actions/GitLab CI
- **Quét container**: Phân tích lỗ hổng hình ảnh
- **Phát hiện bí mật**: Tích hợp GitLeaks và TruffleHog

#### [`/docker-optimize`](https://raw.githubusercontent.com/wshobson/commands/main/tools/docker-optimize.md)

Chiến lược tối ưu hóa container nâng cao.

- **Tối ưu hóa thông minh**: Phân tích và đề xuất cải tiến
- **Xây dựng đa giai đoạn**: Dockerfile tối ưu riêng cho từng framework
- **Công cụ hiện đại**: BuildKit, Bun, UV cho tốc độ xây dựng nhanh hơn
- **Tăng cường bảo mật**: Hình ảnh distroless, người dùng không phải root
- **Tích hợp lệnh chéo**: Hoạt động với đầu ra /api-scaffold

#### [`/k8s-manifest`](https://raw.githubusercontent.com/wshobson/commands/main/tools/k8s-manifest.md)

Triển khai Kubernetes cấp sản xuất.

- **Mẫu nâng cao**: Tiêu chuẩn bảo mật Pod, chính sách mạng, OPA
- **Sẵn sàng GitOps**: Cấu hình FluxCD và ArgoCD
- **Khả năng quan sát**: Prometheus ServiceMonitors, OpenTelemetry
- **Tự động mở rộng**: Cấu hình HPA, VPA, và cluster autoscaler
- **Service Mesh**: Tích hợp Istio/Linkerd

### Frontend & Dữ liệu

#### [`/db-migrate`](https://raw.githubusercontent.com/wshobson/commands/main/tools/db-migrate.md)

Chiến lược di chuyển cơ sở dữ liệu nâng cao.

- **Đa cơ sở dữ liệu**: PostgreSQL, MySQL, MongoDB, DynamoDB
- **Không gián đoạn**: Triển khai blue-green, di chuyển cuốn chiếu
- **Nguồn sự kiện**: Tích hợp Kafka/Kinesis cho CDC
- **Đa nền tảng**: Xử lý lưu trữ đa ngôn ngữ
- **Giám sát**: Kiểm tra sức khỏe di chuyển và quay lui

## Kết hợp quy trình công việc và công cụ

Sức mạnh thực sự đến từ việc kết hợp các quy trình làm việc và công cụ cho chu kỳ phát triển hoàn chỉnh:

### Ví dụ: Xây dựng một tính năng mới

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

### Ví dụ: Hiện đại hóa mã nguồn kế thừa

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

## Các Mẫu Điều Phối Lệnh

Các lệnh có thể được sử dụng riêng lẻ hoặc kết hợp theo các mẫu mạnh mẽ:

### Thực Thi Tuần Tự
```bash
# Build → Test → Secure → Deploy pipeline
/api-scaffold user management API
/test-harness comprehensive test suite for user API  
/security-scan check user API for vulnerabilities
/k8s-manifest deploy user API to production
```

### Phân Tích Song Song
```bash
# Multiple perspectives on the same codebase
/multi-agent-review comprehensive architecture and code review
/security-scan audit security posture  
/performance-optimization identify and fix bottlenecks
# Then consolidate findings
```

### Tinh chỉnh lặp đi lặp lại
```bash
# Start broad, then narrow focus
/feature-development implement payment processing
/security-scan focus on payment security
/compliance-check ensure PCI compliance
/test-harness add payment-specific tests
```

### Tích hợp đa miền
```bash
# Frontend + Backend + Infrastructure
/api-scaffold backend payment API
/multi-agent-optimize optimize payment flow performance
/docker-optimize containerize payment service
/monitor-setup payment metrics and alerts
```
## Khi nào nên sử dụng Quy trình làm việc so với Công cụ

### 🔀 Quy trình làm việc & Công cụ Subagent
- **Giải quyết vấn đề**: Phân tích và khắc phục sự cố một cách thích ứng
- **Nhiều góc nhìn**: Phối hợp các subagent chuyên gia
- **Nhiệm vụ phức tạp**: Quy trình nhiều bước trên nhiều lĩnh vực
- **Giải pháp chưa biết**: Để các subagent xác định phương pháp tiếp cận

### 🛠️ Công cụ chuyên biệt
- **Cài đặt hạ tầng**: Cấu hình môi trường
- **Sinh mã nguồn**: Tạo các triển khai cụ thể
- **Phân tích**: Tạo báo cáo mà không sửa lỗi
- **Tác vụ chuyên ngành**: Hoạt động đặc biệt cao

**Ví dụ:**
- "Triển khai hệ thống xác thực người dùng" → `/feature-development`
- "Khắc phục sự cố hiệu năng trên toàn bộ stack" → `/smart-fix`
- "Hiện đại hóa monolith cũ" → `/legacy-modernize`

### 🔧 Sử dụng Công cụ khi:
- **Cần chuyên môn cụ thể** - Nhiệm vụ rõ ràng, tập trung trong một lĩnh vực
- **Muốn kiểm soát chính xác** - Muốn chỉ đạo chi tiết triển khai cụ thể
- **Một phần của quy trình thủ công** - Tích hợp vào các quy trình hiện có
- **Yêu cầu chuyên sâu** - Cần triển khai ở cấp độ chuyên gia
- **Xây dựng trên công việc hiện có** - Nâng cấp hoặc hoàn thiện đầu ra trước đó

**Ví dụ:**
- "Tạo manifest Kubernetes" → `/k8s-manifest`
- "Quét lỗ hổng bảo mật" → `/security-scan`
- "Tạo tài liệu API" → `/doc-generate`

## Định dạng Lệnh

Lệnh dạng gạch chéo là các tệp markdown đơn giản, nơi:
- Tên tệp trở thành tên lệnh (vd: `api-scaffold.md` → `/api-scaffold`)
- Nội dung tệp là prompt/hướng dẫn thực thi khi được gọi
- Sử dụng biến `$ARGUMENTS` cho đầu vào người dùng

## Thực tiễn tốt nhất

### Lựa chọn lệnh
- **Để Claude Code tự động đề xuất** - Phân tích ngữ cảnh và chọn lệnh tối ưu
- **Sử dụng quy trình cho nhiệm vụ phức tạp** - Subagent phối hợp triển khai đa lĩnh vực
- **Sử dụng công cụ cho nhiệm vụ tập trung** - Áp dụng lệnh cụ thể cho cải tiến mục tiêu

### Sử dụng hiệu quả
- **Cung cấp ngữ cảnh đầy đủ** - Bao gồm stack công nghệ, ràng buộc, yêu cầu
- **Chuỗi lệnh một cách chiến lược** - Quy trình → Công cụ → Tinh chỉnh
- **Xây dựng trên đầu ra trước đó** - Các lệnh được thiết kế để phối hợp với nhau

## Đóng góp

1. Tạo tệp `.md` trong `workflows/` hoặc `tools/`
2. Sử dụng tên dạng chữ thường và dấu gạch nối
3. Bao gồm `$ARGUMENTS` cho đầu vào người dùng

## Khắc phục sự cố

**Không tìm thấy lệnh**: Kiểm tra tệp có nằm trong `~/.claude/commands/`

**Quy trình chậm**: Bình thường - do phối hợp nhiều subagent

**Đầu ra chung chung**: Bổ sung ngữ cảnh cụ thể về stack công nghệ của bạn

**Vấn đề tích hợp**: Xác minh đường dẫn tệp và trình tự lệnh

## Mẹo hiệu suất

**Lựa chọn lệnh:**
- **Quy trình làm việc**: Phối hợp multi-subagent cho tính năng phức tạp
- **Công cụ**: Thao tác đơn lẻ cho nhiệm vụ chuyên biệt
- **Chỉnh sửa đơn giản**: Sử dụng agent chính

**Tối ưu hóa:**
- Bắt đầu bằng công cụ cho vấn đề đã biết
- Cung cấp yêu cầu chi tiết ngay từ đầu
- Xây dựng trên đầu ra của lệnh trước
- Để quy trình hoàn thành trước khi sửa đổi

### Thêm quy trình mới:
- Tập trung vào logic điều phối và phân công subagent
- Chỉ rõ subagent chuyên biệt nào sử dụng và thứ tự thực hiện
- Định nghĩa mô hình phối hợp giữa các subagent

### Thêm công cụ mới:
- Bao gồm triển khai đầy đủ, sẵn sàng cho sản xuất
- Cấu trúc nội dung với các mục rõ ràng và đầu ra hành động
- Đưa ví dụ, thực tiễn tốt nhất, và điểm tích hợp

## Tìm hiểu thêm

- [Tài liệu Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Tài liệu Slash Commands](https://docs.anthropic.com/en/docs/claude-code/slash-commands)
- [Tài liệu Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code GitHub](https://github.com/anthropics/claude-code)
- [Bộ sưu tập Claude Code Subagents](https://github.com/wshobson/agents) - Các subagent chuyên biệt dùng cho các lệnh này



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-08

---