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

Một bộ sưu tập toàn diện các subagent AI chuyên biệt cho [Claude Code](https://docs.anthropic.com/en/docs/claude-code), được thiết kế để nâng cao quy trình phát triển với kiến thức chuyên sâu theo từng lĩnh vực.

## Tổng quan

Kho lưu trữ này chứa 76 subagent chuyên biệt mở rộng năng lực của Claude Code. Mỗi subagent là chuyên gia trong một lĩnh vực cụ thể, được tự động kích hoạt dựa trên ngữ cảnh hoặc gọi thủ công khi cần thiết. Tất cả các agent đều được cấu hình với các mô hình Claude phù hợp theo độ phức tạp của tác vụ để tối ưu hiệu suất và chi phí.

## Các Subagent Có Sẵn

### Phát triển & Kiến trúc
- **[backend-architect](https://raw.githubusercontent.com/wshobson/agents/main/backend-architect.md)** - Thiết kế API RESTful, ranh giới vi dịch vụ và lược đồ cơ sở dữ liệu
- **[frontend-developer](https://raw.githubusercontent.com/wshobson/agents/main/frontend-developer.md)** - Xây dựng các thành phần React, triển khai bố cục đáp ứng và quản lý trạng thái phía máy khách
- **[ui-ux-designer](https://raw.githubusercontent.com/wshobson/agents/main/ui-ux-designer.md)** - Tạo thiết kế giao diện, wireframe và hệ thống thiết kế
- **[ui-visual-validator](https://raw.githubusercontent.com/wshobson/agents/main/ui-visual-validator.md)** - Xác minh xem các thay đổi UI có đạt được mục tiêu dự kiến hay chưa thông qua phân tích ảnh chụp màn hình nghiêm ngặt
- **[mobile-developer](https://raw.githubusercontent.com/wshobson/agents/main/mobile-developer.md)** - Phát triển ứng dụng React Native hoặc Flutter với tích hợp native
- **[graphql-architect](https://raw.githubusercontent.com/wshobson/agents/main/graphql-architect.md)** - Thiết kế lược đồ GraphQL, trình phân giải và liên kết
- **[architect-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/architect-review.md)** - Xem xét thay đổi mã để đảm bảo tính nhất quán và mẫu kiến trúc

### Chuyên gia ngôn ngữ
- **[python-pro](https://raw.githubusercontent.com/wshobson/agents/main/python-pro.md)** - Viết mã Python chuẩn với các tính năng nâng cao và tối ưu hóa
- **[ruby-pro](https://raw.githubusercontent.com/wshobson/agents/main/ruby-pro.md)** - Viết mã Ruby chuẩn với metaprogramming, mẫu Rails, phát triển gem và bộ kiểm thử
- **[golang-pro](https://raw.githubusercontent.com/wshobson/agents/main/golang-pro.md)** - Viết mã Go chuẩn với goroutine, channel và interface
- **[rust-pro](https://raw.githubusercontent.com/wshobson/agents/main/rust-pro.md)** - Viết mã Rust chuẩn với mẫu sở hữu, lifetime và triển khai trait
- **[c-pro](https://raw.githubusercontent.com/wshobson/agents/main/c-pro.md)** - Viết mã C hiệu quả với quản lý bộ nhớ và gọi hệ thống thích hợp
- **[cpp-pro](https://raw.githubusercontent.com/wshobson/agents/main/cpp-pro.md)** - Viết mã C++ chuẩn với các tính năng hiện đại, RAII, smart pointer và thuật toán STL
- **[javascript-pro](https://raw.githubusercontent.com/wshobson/agents/main/javascript-pro.md)** - Thành thạo JavaScript hiện đại với ES6+, mẫu async và API Node.js
- **[typescript-pro](https://raw.githubusercontent.com/wshobson/agents/main/typescript-pro.md)** - Thành thạo TypeScript với kiểu nâng cao, generic và kiểm tra kiểu chặt chẽ
- **[php-pro](https://raw.githubusercontent.com/wshobson/agents/main/php-pro.md)** - Viết mã PHP chuẩn với các tính năng hiện đại và tối ưu hóa hiệu suất
- **[java-pro](https://raw.githubusercontent.com/wshobson/agents/main/java-pro.md)** - Thành thạo Java hiện đại với stream, lập trình đồng thời và tối ưu hóa JVM
- **[elixir-pro](https://raw.githubusercontent.com/wshobson/agents/main/elixir-pro.md)** - Viết mã Elixir chuẩn với mẫu OTP, lập trình hàm và framework Phoenix
- **[csharp-pro](https://raw.githubusercontent.com/wshobson/agents/main/csharp-pro.md)** - Viết mã C# hiện đại với các tính năng nâng cao và tối ưu hóa .NET
- **[scala-pro](https://raw.githubusercontent.com/wshobson/agents/main/scala-pro.md)** - Thành thạo phát triển Scala doanh nghiệp với lập trình hàm, hệ phân tán và xử lý dữ liệu lớn
- **[flutter-expert](https://raw.githubusercontent.com/wshobson/agents/main/flutter-expert.md)** - Thành thạo phát triển Flutter với Dart, widget và tích hợp nền tảng
- **[unity-developer](https://raw.githubusercontent.com/wshobson/agents/main/unity-developer.md)** - Xây dựng game Unity với script tối ưu và tinh chỉnh hiệu suất
- **[minecraft-bukkit-pro](https://raw.githubusercontent.com/wshobson/agents/main/minecraft-bukkit-pro.md)** - Thành thạo phát triển plugin máy chủ Minecraft với Bukkit, Spigot và API Paper
- **[ios-developer](https://raw.githubusercontent.com/wshobson/agents/main/ios-developer.md)** - Phát triển ứng dụng iOS native với Swift/SwiftUI
- **[sql-pro](https://raw.githubusercontent.com/wshobson/agents/main/sql-pro.md)** - Viết truy vấn SQL phức tạp, tối ưu hóa kế hoạch thực thi và thiết kế lược đồ chuẩn hóa

### Hạ tầng & Vận hành
- **[devops-troubleshooter](https://raw.githubusercontent.com/wshobson/agents/main/devops-troubleshooter.md)** - Gỡ lỗi sự cố sản xuất, phân tích log và sửa lỗi triển khai
- **[deployment-engineer](https://raw.githubusercontent.com/wshobson/agents/main/deployment-engineer.md)** - Cấu hình pipeline CI/CD, container Docker và triển khai đám mây
- **[cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/cloud-architect.md)** - Thiết kế hạ tầng AWS/Azure/GCP và tối ưu hóa chi phí đám mây
- **[hybrid-cloud-architect](https://raw.githubusercontent.com/wshobson/agents/main/hybrid-cloud-architect.md)** - Thiết kế hạ tầng đám mây lai trên AWS/Azure/GCP và môi trường OpenStack tại chỗ
- **[kubernetes-architect](https://raw.githubusercontent.com/wshobson/agents/main/kubernetes-architect.md)** - Thiết kế hạ tầng cloud-native với Kubernetes làm lõi và nguyên tắc GitOps trên AWS/Azure/GCP cũng như môi trường lai.
- **[database-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/database-optimizer.md)** - Tối ưu hóa truy vấn SQL, thiết kế chỉ mục hiệu quả và xử lý di chuyển cơ sở dữ liệu
- **[database-admin](https://raw.githubusercontent.com/wshobson/agents/main/database-admin.md)** - Quản lý vận hành cơ sở dữ liệu, sao lưu, nhân bản và giám sát
- **[terraform-specialist](https://raw.githubusercontent.com/wshobson/agents/main/terraform-specialist.md)** - Viết module Terraform nâng cao, quản lý file trạng thái và triển khai thực hành IaC tốt nhất
- **[incident-responder](https://raw.githubusercontent.com/wshobson/agents/main/incident-responder.md)** - Xử lý sự cố sản xuất với tính cấp bách và độ chính xác
- **[network-engineer](https://raw.githubusercontent.com/wshobson/agents/main/network-engineer.md)** - Gỡ lỗi kết nối mạng, cấu hình bộ cân bằng tải và phân tích mẫu lưu lượng
- **[dx-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/dx-optimizer.md)** - Chuyên gia Trải nghiệm Nhà phát triển, cải thiện công cụ, thiết lập và quy trình làm việc

### Chất lượng & Bảo mật
- **[code-reviewer](https://raw.githubusercontent.com/wshobson/agents/main/code-reviewer.md)** - Chuyên gia kiểm tra mã với trọng tâm bảo mật cấu hình và độ tin cậy sản xuất
- **[security-auditor](https://raw.githubusercontent.com/wshobson/agents/main/security-auditor.md)** - Kiểm tra mã tìm lỗ hổng và đảm bảo tuân thủ OWASP
- **[test-automator](https://raw.githubusercontent.com/wshobson/agents/main/test-automator.md)** - Tạo bộ kiểm thử toàn diện gồm kiểm thử đơn vị, tích hợp và end-to-end
- **[performance-engineer](https://raw.githubusercontent.com/wshobson/agents/main/performance-engineer.md)** - Phân tích hiệu suất ứng dụng, tối ưu điểm nghẽn, và triển khai chiến lược lưu trữ
- **[debugger](https://raw.githubusercontent.com/wshobson/agents/main/debugger.md)** - Chuyên gia gỡ lỗi cho lỗi, thất bại kiểm thử và hành vi bất thường
- **[error-detective](https://raw.githubusercontent.com/wshobson/agents/main/error-detective.md)** - Tìm kiếm nhật ký và mã nguồn để phát hiện lỗi, dấu vết stack, và bất thường
- **[search-specialist](https://raw.githubusercontent.com/wshobson/agents/main/search-specialist.md)** - Chuyên gia nghiên cứu web sử dụng kỹ thuật tìm kiếm nâng cao và tổng hợp

### Dữ liệu & AI
- **[data-scientist](https://raw.githubusercontent.com/wshobson/agents/main/data-scientist.md)** - Chuyên gia phân tích dữ liệu cho truy vấn SQL, vận hành BigQuery, và khám phá dữ liệu
- **[data-engineer](https://raw.githubusercontent.com/wshobson/agents/main/data-engineer.md)** - Xây dựng pipeline ETL, kho dữ liệu và kiến trúc dữ liệu streaming
- **[ai-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ai-engineer.md)** - Xây dựng ứng dụng LLM, hệ thống RAG và pipeline prompt
- **[ml-engineer](https://raw.githubusercontent.com/wshobson/agents/main/ml-engineer.md)** - Triển khai pipeline ML, phục vụ mô hình và xây dựng đặc trưng dữ liệu
- **[mlops-engineer](https://raw.githubusercontent.com/wshobson/agents/main/mlops-engineer.md)** - Xây dựng pipeline ML, theo dõi thử nghiệm và quản lý mô hình
- **[prompt-engineer](https://raw.githubusercontent.com/wshobson/agents/main/prompt-engineer.md)** - Tối ưu hóa prompt cho các LLM và hệ thống AI

### Lĩnh vực chuyên biệt
- **[api-documenter](https://raw.githubusercontent.com/wshobson/agents/main/api-documenter.md)** - Tạo đặc tả OpenAPI/Swagger và viết tài liệu cho nhà phát triển
- **[payment-integration](https://raw.githubusercontent.com/wshobson/agents/main/payment-integration.md)** - Tích hợp Stripe, PayPal và các bộ xử lý thanh toán
- **[quant-analyst](https://raw.githubusercontent.com/wshobson/agents/main/quant-analyst.md)** - Xây dựng mô hình tài chính, kiểm thử chiến lược giao dịch và phân tích dữ liệu thị trường
- **[risk-manager](https://raw.githubusercontent.com/wshobson/agents/main/risk-manager.md)** - Giám sát rủi ro danh mục, R-multiples và giới hạn vị thế
- **[legacy-modernizer](https://raw.githubusercontent.com/wshobson/agents/main/legacy-modernizer.md)** - Tái cấu trúc mã nguồn cũ và triển khai hiện đại hóa từng bước
- **[context-manager](https://raw.githubusercontent.com/wshobson/agents/main/context-manager.md)** - Quản lý ngữ cảnh giữa nhiều agent và các tác vụ dài hạn

### Tài liệu
- **[docs-architect](https://raw.githubusercontent.com/wshobson/agents/main/docs-architect.md)** - Tạo tài liệu kỹ thuật toàn diện từ mã nguồn sẵn có
- **[mermaid-expert](https://raw.githubusercontent.com/wshobson/agents/main/mermaid-expert.md)** - Tạo sơ đồ Mermaid cho lưu đồ, chuỗi sự kiện, ERD và kiến trúc
- **[reference-builder](https://raw.githubusercontent.com/wshobson/agents/main/reference-builder.md)** - Tạo tài liệu kỹ thuật và tài liệu API toàn diện
- **[tutorial-engineer](https://raw.githubusercontent.com/wshobson/agents/main/tutorial-engineer.md)** - Tạo hướng dẫn từng bước và nội dung giáo dục từ mã nguồn

### Kinh doanh & Marketing
- **[business-analyst](https://raw.githubusercontent.com/wshobson/agents/main/business-analyst.md)** - Phân tích chỉ số, tạo báo cáo và theo dõi KPI
- **[content-marketer](https://raw.githubusercontent.com/wshobson/agents/main/content-marketer.md)** - Viết bài blog, nội dung mạng xã hội và bản tin email
- **[hp-pro](https://raw.githubusercontent.com/wshobson/agents/main/hp-pro.md)** - Đối tác tuyển dụng, onboarding/offboarding, nghỉ phép, hiệu suất, chính sách tuân thủ và quan hệ nhân viên.
- **[sales-automator](https://raw.githubusercontent.com/wshobson/agents/main/sales-automator.md)** - Soạn email lạnh, email theo dõi và mẫu đề xuất
- **[customer-support](https://raw.githubusercontent.com/wshobson/agents/main/customer-support.md)** - Xử lý phiếu hỗ trợ, trả lời FAQ và email khách hàng
- **[legal-advisor](https://raw.githubusercontent.com/wshobson/agents/main/legal-advisor.md)** - Soạn thảo chính sách quyền riêng tư, điều khoản dịch vụ, tuyên bố từ chối trách nhiệm và thông báo pháp lý

### SEO & Tối ưu hóa nội dung
- **[seo-content-auditor](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-auditor.md)** - Phân tích chất lượng nội dung, tín hiệu E-E-A-T và các thực hành SEO tốt nhất
- **[seo-meta-optimizer](https://raw.githubusercontent.com/wshobson/agents/main/seo-meta-optimizer.md)** - Tạo tiêu đề meta, mô tả và đề xuất URL tối ưu
- **[seo-keyword-strategist](https://raw.githubusercontent.com/wshobson/agents/main/seo-keyword-strategist.md)** - Phân tích sử dụng từ khóa, tính mật độ, đề xuất biến thể ngữ nghĩa
- **[seo-structure-architect](https://raw.githubusercontent.com/wshobson/agents/main/seo-structure-architect.md)** - Tối ưu hóa cấu trúc nội dung, thứ bậc tiêu đề và đánh dấu schema
- **[seo-snippet-hunter](https://raw.githubusercontent.com/wshobson/agents/main/seo-snippet-hunter.md)** - Định dạng nội dung cho đoạn trích nổi bật và các tính năng SERP
- **[seo-content-refresher](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-refresher.md)** - Xác định yếu tố lỗi thời và đề xuất cập nhật nội dung
- **[seo-cannibalization-detector](https://raw.githubusercontent.com/wshobson/agents/main/seo-cannibalization-detector.md)** - Phân tích nhiều trang để phát hiện trùng lặp và xung đột từ khóa
- **[seo-authority-builder](https://raw.githubusercontent.com/wshobson/agents/main/seo-authority-builder.md)** - Phân tích tín hiệu E-E-A-T và chỉ số uy tín trong nội dung
- **[seo-content-writer](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-writer.md)** - Viết nội dung tối ưu SEO dựa trên từ khóa và bản tóm tắt
- **[seo-content-planner](https://raw.githubusercontent.com/wshobson/agents/main/seo-content-planner.md)** - Lập đề cương nội dung, nhóm chủ đề và lịch đăng bài

## Phân công mô hình

Tất cả 76 tác vụ phụ đều được cấu hình với các mô hình Claude cụ thể dựa trên độ phức tạp nhiệm vụ:

### 🚀 Haiku (Nhanh & Tiết kiệm chi phí) - 15 tác vụ
**Mô hình:** `haiku`
- `data-scientist` - Truy vấn SQL và phân tích dữ liệu
- `api-documenter` - Tài liệu OpenAPI/Swagger
- `reference-builder` - Tham khảo kỹ thuật toàn diện và tài liệu API
- `business-analyst` - Theo dõi số liệu và KPI
- `content-marketer` - Bài đăng blog và mạng xã hội
- `customer-support` - Vé hỗ trợ và câu hỏi thường gặp
- `sales-automator` - Email tiếp cận và đề xuất
- `search-specialist` - Nghiên cứu web và thu thập thông tin
- `legal-advisor` - Chính sách quyền riêng tư và tài liệu tuân thủ
- `seo-meta-optimizer` - Tối ưu hóa tiêu đề meta và mô tả
- `seo-keyword-strategist` - Phân tích mật độ từ khóa và ngữ nghĩa
- `seo-structure-architect` - Cấu trúc nội dung và đánh dấu schema
- `seo-snippet-hunter` - Định dạng đoạn trích nổi bật
- `seo-content-refresher` - Cập nhật độ mới nội dung
- `seo-cannibalization-detector` - Phát hiện trùng lặp từ khóa
- `seo-content-planner` - Lập lịch và đề cương nội dung

### ⚡ Sonnet (Hiệu năng cân bằng) - 45 tác vụ
**Mô hình:** `sonnet`

**Phát triển & Ngôn ngữ:**
- `python-pro` - Phát triển Python với các tính năng nâng cao
- `ruby-pro` - Phát triển Ruby với metaprogramming, mẫu Rails và phát triển gem
- `javascript-pro` - JavaScript hiện đại và Node.js
- `typescript-pro` - TypeScript nâng cao với hệ thống kiểu dữ liệu
- `golang-pro` - Go với xử lý đồng thời và mẫu idiomatic
- `rust-pro` - Rust đảm bảo an toàn bộ nhớ và lập trình hệ thống
- `c-pro` - Lập trình C và hệ thống nhúng
- `cpp-pro` - C++ hiện đại với STL và template
- `php-pro` - PHP hiện đại với các tính năng nâng cao
- `java-pro` - Java hiện đại với streams và xử lý đồng thời
- `elixir-pro` - Elixir với mẫu OTP và Phoenix
- `csharp-pro` - C# hiện đại với các framework .NET và mẫu thiết kế
- `scala-pro` - Scala doanh nghiệp với Apache Pekko, Akka, Spark, và ZIO/Cats Effect
- `flutter-expert` - Phát triển Flutter với quản lý trạng thái và hoạt ảnh
- `unity-developer` - Phát triển game Unity và tối ưu hóa
- `minecraft-bukkit-pro` - Phát triển plugin Minecraft với Bukkit/Spigot/Paper
- `ios-developer` - Phát triển iOS native với Swift/SwiftUI
- `frontend-developer` - React component và giao diện người dùng
- `ui-ux-designer` - Thiết kế giao diện và wireframe
- `ui-visual-validator` - Kiểm tra UI nghiêm ngặt qua phân tích ảnh chụp màn hình
- `backend-architect` - Thiết kế API và microservices
- `mobile-developer` - Ứng dụng React Native/Flutter
- `sql-pro` - Tối ưu hóa SQL phức tạp
- `graphql-architect` - Thiết kế schema và resolver của GraphQL

**Hạ tầng & Vận hành:**
- `devops-troubleshooter` - Gỡ lỗi hệ thống sản xuất
- `deployment-engineer` - Quy trình CI/CD
- `database-optimizer` - Tối ưu hóa truy vấn
- `database-admin` - Vận hành cơ sở dữ liệu
- `terraform-specialist` - Hạ tầng dưới dạng mã nguồn
- `network-engineer` - Cấu hình mạng
- `dx-optimizer` - Tối ưu hóa trải nghiệm lập trình viên
- `data-engineer` - Quy trình ETL

**Chất lượng & Hỗ trợ:**
- `test-automator` - Tạo bộ kiểm thử tự động
- `code-reviewer` - Phân tích chất lượng mã nguồn
- `debugger` - Điều tra lỗi
- `error-detective` - Phân tích nhật ký lỗi
- `ml-engineer` - Triển khai mô hình ML
- `legacy-modernizer` - Di chuyển framework cũ sang mới
- `payment-integration` - Xử lý thanh toán
- `mermaid-expert` - Sơ đồ Mermaid và tài liệu trực quan
- `flutter-expert` - Phát triển Flutter
- `seo-content-auditor` - Kiểm toán chất lượng nội dung và phân tích E-E-A-T
- `seo-authority-builder` - Tối ưu hóa tín hiệu thẩm quyền
- `seo-content-writer` - Sáng tạo nội dung tối ưu hóa SEO

### 🧠 Opus (Khả năng tối đa) - 15 tác nhân
**Mô hình:** `opus`
- `ai-engineer` - Ứng dụng LLM và hệ thống RAG
- `security-auditor` - Phân tích lỗ hổng bảo mật
- `performance-engineer` - Tối ưu hóa hiệu năng ứng dụng
- `incident-responder` - Xử lý sự cố sản xuất
- `mlops-engineer` - Hạ tầng ML
- `architect-reviewer` - Đánh giá tính nhất quán kiến trúc
- `cloud-architect` - Thiết kế hạ tầng đám mây
- `prompt-engineer` - Tối ưu hóa prompt cho LLM
- `context-manager` - Phối hợp đa tác nhân
- `quant-analyst` - Mô hình hóa tài chính
- `risk-manager` - Quản lý rủi ro danh mục đầu tư
- `docs-architect` - Tài liệu kỹ thuật toàn diện từ mã nguồn
- `tutorial-engineer` - Nội dung hướng dẫn từng bước và giáo dục

## Cài đặt

Các tác nhân phụ này sẽ tự động khả dụng khi được đặt trong thư mục `~/.claude/agents/`.

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
- **frontend-developer**: Lập kế hoạch UI/UX, kiến trúc thành phần
- **ui-ux-designer**: Thiết kế giao diện, wireframes, hệ thống thiết kế, nghiên cứu người dùng
- **cloud-architect**: Thiết kế hạ tầng, lập kế hoạch mở rộng

### 🔧 Triển Khai & Phát Triển  
- **python-pro**: Các tác vụ phát triển chuyên biệt cho Python
- **ruby-pro**: Metaprogramming Ruby, ứng dụng Rails, phát triển gem, kiểm thử RSpec/Minitest
- **golang-pro**: Các tác vụ phát triển chuyên biệt cho Go
- **rust-pro**: Phát triển chuyên biệt cho Rust, an toàn bộ nhớ, lập trình hệ thống
- **c-pro**: Lập trình C, hệ thống nhúng, mã hiệu năng cao
- **javascript-pro**: JavaScript hiện đại, mẫu async, mã Node.js/trình duyệt
- **typescript-pro**: TypeScript nâng cao, generics, suy luận kiểu, mẫu doanh nghiệp
- **java-pro**: Phát triển Java hiện đại, luồng, đồng thời, Spring Boot
- **elixir-pro**: Phát triển Elixir, mẫu OTP, frameworks Phoenix, lập trình hàm
- **csharp-pro**: Phát triển C# hiện đại, frameworks .NET, mẫu doanh nghiệp
- **scala-pro**: Scala doanh nghiệp với lập trình hàm, Apache Pekko/Akka actors, Apache Spark, ZIO/Cats Effect, kiến trúc phản ứng
- **flutter-expert**: Phát triển Flutter, Dart, quản lý trạng thái, hoạt họa, triển khai đa nền tảng
- **unity-developer**: Phát triển game Unity, scripting C#, tối ưu hiệu năng
- **minecraft-bukkit-pro**: Phát triển plugin Minecraft, hệ thống sự kiện, tính năng phía server
- **ios-developer**: Phát triển iOS native với Swift/SwiftUI
- **sql-pro**: Truy vấn cơ sở dữ liệu, thiết kế sơ đồ, tối ưu truy vấn
- **mobile-developer**: Phát triển React Native/Flutter

### 🛠️ Vận Hành & Bảo Trì
- **devops-troubleshooter**: Vấn đề sản xuất, sự cố triển khai
- **incident-responder**: Sự cố nghiêm trọng cần phản ứng ngay
- **database-optimizer**: Hiệu năng truy vấn, chiến lược đánh chỉ mục
- **database-admin**: Chiến lược sao lưu, nhân bản, quản lý người dùng, phục hồi thảm họa
- **terraform-specialist**: Hạ tầng dưới dạng mã, module Terraform, quản lý trạng thái
- **network-engineer**: Kết nối mạng, cân bằng tải, SSL/TLS, gỡ lỗi DNS

### 📊 Phân Tích & Tối Ưu
- **performance-engineer**: Nút thắt hiệu năng ứng dụng, tối ưu hóa
- **security-auditor**: Quét lỗ hổng, kiểm tra tuân thủ
- **data-scientist**: Phân tích dữ liệu, nhận định, báo cáo
- **mlops-engineer**: Hạ tầng ML, theo dõi thí nghiệm, kho lưu trữ mô hình, tự động hóa pipeline

### 🧪 Đảm Bảo Chất Lượng
- **code-reviewer**: Chất lượng mã, bảo mật cấu hình, độ tin cậy sản xuất
- **test-automator**: Chiến lược kiểm thử, tạo bộ kiểm thử
- **debugger**: Điều tra lỗi, giải quyết lỗi
- **error-detective**: Phân tích log, nhận diện mẫu lỗi, phân tích nguyên nhân gốc rễ
- **search-specialist**: Nghiên cứu web sâu, phân tích cạnh tranh, kiểm tra tính xác thực

### 📚 Tài Liệu
- **api-documenter**: Đặc tả OpenAPI/Swagger, tài liệu API
- **docs-architect**: Tài liệu kỹ thuật tổng thể, hướng dẫn kiến trúc, sổ tay hệ thống
- **reference-builder**: Tham chiếu API đầy đủ, hướng dẫn cấu hình, tài liệu tham số
- **tutorial-engineer**: Hướng dẫn từng bước, lộ trình học, nội dung giáo dục

### 💼 Kinh Doanh & Chiến Lược
- **business-analyst**: KPI, mô hình doanh thu, dự báo tăng trưởng, chỉ số nhà đầu tư
- **risk-manager**: Rủi ro danh mục, chiến lược phòng ngừa, R-multiples, kích cỡ vị thế
- **content-marketer**: Nội dung SEO, bài blog, mạng xã hội, chiến dịch email
- **sales-automator**: Email tiếp cận, theo dõi, đề xuất, nuôi dưỡng khách hàng tiềm năng
- **customer-support**: Ticket hỗ trợ, câu hỏi thường gặp, tài liệu trợ giúp, xử lý sự cố
- **legal-advisor** - Soạn thảo chính sách quyền riêng tư, điều khoản dịch vụ, tuyên bố miễn trừ, và thông báo pháp lý

## Thực Tiễn Tốt Nhất

### 🎯 Phân Công Nhiệm Vụ
1. **Để Claude Code tự động phân công** - Tác nhân chính phân tích ngữ cảnh và chọn tác nhân tối ưu
2. **Cụ thể hóa yêu cầu** - Bao gồm các ràng buộc, công nghệ sử dụng, và yêu cầu chất lượng
3. **Tin tưởng vào chuyên môn của tác nhân** - Mỗi tác nhân được tối ưu cho lĩnh vực riêng

### 🔄 Quy Trình Đa Tác Nhân
4. **Bắt đầu với yêu cầu cấp cao** - Cho phép các tác nhân phối hợp các tác vụ đa bước phức tạp
5. **Cung cấp bối cảnh giữa các tác nhân** - Đảm bảo tác nhân có đủ thông tin nền cần thiết
6. **Kiểm tra điểm tích hợp** - Xem xét cách đầu ra của các tác nhân kết hợp với nhau

### 🎛️ Kiểm Soát Rõ Ràng
7. **Dùng gọi rõ ràng cho nhu cầu cụ thể** - Khi bạn cần quan điểm của chuyên gia nhất định
8. **Kết hợp nhiều tác nhân một cách chiến lược** - Các chuyên gia khác nhau có thể xác minh công việc của nhau
9. **Yêu cầu mẫu đánh giá cụ thể** - "Hãy để security-auditor đánh giá thiết kế API của backend-architect"

### 📈 Tối ưu hóa
10. **Giám sát hiệu quả của agent** - Tìm hiểu agent nào hoạt động tốt nhất cho các trường hợp sử dụng của bạn
11. **Lặp lại với các nhiệm vụ phức tạp** - Sử dụng phản hồi từ agent để hoàn thiện yêu cầu
12. **Tận dụng điểm mạnh của agent** - Phù hợp độ phức tạp của nhiệm vụ với khả năng của agent

## Đóng góp

Để thêm một subagent mới:
1. Tạo một file `.md` mới theo định dạng như trên
2. Sử dụng tên chữ thường, cách nhau bằng dấu gạch ngang
3. Viết mô tả rõ ràng về khi nào nên sử dụng subagent
4. Bao gồm hướng dẫn cụ thể trong lời nhắc hệ thống

## Xử lý sự cố

### Các vấn đề thường gặp

**Agent không tự động được kích hoạt:**
- Đảm bảo yêu cầu của bạn chỉ rõ lĩnh vực (vd: "vấn đề hiệu năng" → performance-engineer)
- Cụ thể về loại nhiệm vụ (vd: "kiểm tra mã nguồn" → code-reviewer)

**Agent được chọn không như mong đợi:**
- Cung cấp thêm ngữ cảnh về công nghệ và yêu cầu của bạn
- Dùng cách gọi cụ thể nếu bạn cần một agent nhất định

**Nhiều agent đưa ra lời khuyên xung đột:**
- Điều này là bình thường - các chuyên gia khác nhau có thể ưu tiên khác nhau
- Yêu cầu làm rõ: "Hòa giải các khuyến nghị từ security-auditor và performance-engineer"

**Agent dường như thiếu ngữ cảnh:**
- Cung cấp thông tin nền trong yêu cầu của bạn
- Tham chiếu các cuộc trò chuyện trước hoặc mẫu đã thiết lập

### Nhận hỗ trợ

Nếu các agent không hoạt động như mong đợi:
1. Kiểm tra mô tả agent trong từng file riêng
2. Thử sử dụng ngôn ngữ cụ thể hơn trong yêu cầu
3. Dùng cách gọi cụ thể để kiểm tra từng agent
4. Cung cấp thêm ngữ cảnh về dự án và mục tiêu của bạn

## Giấy phép

Dự án này được cấp phép theo Giấy phép MIT - xem tệp [LICENSE](LICENSE) để biết chi tiết.

## Tìm hiểu thêm

- [Tài liệu Claude Code](https://docs.anthropic.com/en/docs/claude-code)
- [Tài liệu Subagents](https://docs.anthropic.com/en/docs/claude-code/sub-agents)
- [Claude Code trên GitHub](https://github.com/anthropics/claude-code)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-04

---