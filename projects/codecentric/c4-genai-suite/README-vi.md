# c4 GenAI Suite

Một ứng dụng chatbot AI với tích hợp Nhà cung cấp Ngữ cảnh Mô hình (Model Context Provider - MCP), được hỗ trợ bởi Langchain và tương thích với tất cả các Mô hình Ngôn ngữ Lớn (LLM) và Mô hình Nhúng chính.

Quản trị viên có thể tạo các trợ lý với các khả năng khác nhau bằng cách thêm các phần mở rộng, chẳng hạn như dịch vụ RAG (Generation Tăng cường Truy hồi) hoặc máy chủ MCP. Ứng dụng được xây dựng bằng một ngăn xếp công nghệ hiện đại, bao gồm React, NestJS và Python FastAPI cho dịch vụ REI-S.

Người dùng có thể tương tác với các trợ lý thông qua giao diện thân thiện với người dùng. Tùy thuộc vào cấu hình của trợ lý, người dùng có thể đặt câu hỏi, tải lên tệp của riêng mình hoặc sử dụng các tính năng khác. Các trợ lý sẽ tương tác với các nhà cung cấp LLM khác nhau để cung cấp phản hồi dựa trên các phần mở rộng đã cấu hình. Thông tin ngữ cảnh do các phần mở rộng cấu hình cung cấp cho phép các trợ lý trả lời các câu hỏi chuyên ngành và cung cấp thông tin liên quan.

Ứng dụng được thiết kế theo hướng mô-đun và có thể mở rộng, cho phép người dùng tạo các trợ lý với các khả năng khác nhau bằng cách thêm các phần mở rộng.

![video demo ngắn về cách sử dụng cơ bản](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/preview.webp)

## Tính năng

### Mô hình Ngôn ngữ Lớn (LLM) và Mô hình Đa phương tiện

c4 GenAI Suite đã hỗ trợ trực tiếp nhiều mô hình. Nếu mô hình ưa thích của bạn chưa được hỗ trợ, bạn cũng có thể dễ dàng viết phần mở rộng để tích hợp nó.

* Mô hình tương thích OpenAI
* Mô hình Azure OpenAI
* Mô hình Bedrock
* Mô hình Google GenAI
* Mô hình tương thích Ollama
### Retrieval Augmented Generation (RAG)

Bộ công cụ c4 GenAI Suite bao gồm REI-S, một máy chủ để chuẩn bị các tệp cho việc sử dụng bởi LLM.

* REI-S, một máy chủ RAG tích hợp tùy chỉnh
  * Kho vector
    * pgvector
    * Azure AI Search
  * Mô hình embedding
    * Embedding tương thích OpenAI
    * Embedding Azure OpenAI
    * Embedding tương thích Ollama
  * Định dạng tệp:
    * pdf, docx, pptx, xlsx, ...
    * Chuyển đổi giọng nói từ tệp âm thanh (qua Whisper)

### Phần mở rộng

Bộ công cụ c4 GenAI Suite được thiết kế để dễ dàng mở rộng. Viết phần mở rộng rất dễ, cũng như sử dụng một máy chủ MCP đã có sẵn.

* Máy chủ Model Context Protocol (MCP)
* Hệ thống prompt tùy chỉnh
* Tìm kiếm Bing
* Máy tính (Calculator)

## Bắt đầu

### Sử dụng Docker-Compose

- Chạy `docker compose up` trong thư mục gốc của dự án.
- Mở [ứng dụng](http://localhost:3333) trên trình duyệt. Thông tin đăng nhập mặc định là người dùng `admin@example.com` và mật khẩu `secret`.

![video hướng dẫn cấu hình trợ lý](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/demo/assistants.webp)

### Sử dụng Helm & Kubernetes

Để triển khai trong môi trường Kubernetes, vui lòng tham khảo [README của Helm Chart chúng tôi](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/./helm-chart/README.md).

### Thiết lập Trợ lý và Tiện ích mở rộng

Bộ công cụ c4 GenAI Suite xoay quanh các *trợ lý*.
Mỗi trợ lý bao gồm một tập hợp các tiện ích mở rộng, xác định mô hình LLM và các công cụ mà nó có thể sử dụng.

- Trong khu vực quản trị (nhấp vào tên người dùng ở góc dưới bên trái), vào phần [trợ lý](http://localhost:3333/admin/assistants).
- Thêm một trợ lý bằng nút `+` màu xanh lá bên cạnh tiêu đề phần. Chọn tên và mô tả.
- Chọn trợ lý vừa tạo và nhấp vào `+ Thêm tiện ích mở rộng` màu xanh lá.
- Chọn mô hình và điền thông tin xác thực.
- Sử dụng nút `Kiểm tra` để kiểm tra hoạt động và `lưu`.

Bây giờ bạn có thể quay lại [trang trò chuyện](http://localhost:3333/chat) (nhấp vào `c4 GenAI Suite` ở góc trên bên trái) và bắt đầu cuộc trò chuyện mới với trợ lý của mình.

> [!TIP]
> `docker-compose` của chúng tôi bao gồm một Ollama cục bộ, chạy trên CPU. Bạn có thể dùng nó để kiểm thử nhanh. Tuy nhiên nó sẽ chậm và có lẽ bạn sẽ muốn sử dụng một mô hình khác. Nếu bạn muốn sử dụng Ollama, chỉ cần tạo tiện ích mở rộng mô hình sau trong Trợ lý của bạn.
> * Tiện ích mở rộng: `Dev: Ollama`
> * Endpoint: `http://ollama:11434`
> * Mô hình: `llama3.2`

### Giao thức Bối cảnh Mô hình (MCP) [tùy chọn]

Sử dụng bất kỳ máy chủ MCP nào cung cấp giao diện `sse` với Tiện ích mở rộng `MCP Tools` (hoặc sử dụng `mcp-tool-as-server` của chúng tôi làm proxy phía trước một máy chủ MCP `stdio`).
Mỗi máy chủ MCP có thể được cấu hình chi tiết như một tiện ích mở rộng.

### Tạo sinh tăng cường truy xuất (RAG) / Tìm kiếm Tệp [tùy chọn]

Sử dụng máy chủ RAG `REI-S` của chúng tôi để tìm kiếm các tệp do người dùng cung cấp. Chỉ cần cấu hình một tiện ích mở rộng `Search Files` cho trợ lý.
Quy trình này được mô tả chi tiết trong [thư mục con `services/reis`](services/reis/#example-configuration-in-c4).

## Đóng góp & Phát triển

* Xem [CONTRIBUTING.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/CONTRIBUTING.md) để biết hướng dẫn đóng góp.
* Đối với nhà phát triển mới, hãy kiểm tra [DEVELOPERS.md](https://raw.githubusercontent.com/codecentric/c4-genai-suite/main/DEVELOPERS.md).

## Các Khối Xây Dựng Chính

Ứng dụng bao gồm **Frontend**, **Backend** và dịch vụ **REI-S**.

```
┌──────────┐
│   Người dùng   │
└─────┬────┘
      │ truy cập
      ▼
┌──────────┐
│ Giao diện người dùng │
└─────┬────┘
      │ truy cập
      ▼
┌──────────┐     ┌─────────────────┐
│ Backend  │────►│      LLM        │
└─────┬────┘     └─────────────────┘
      │ truy cập
      ▼
┌──────────┐     ┌─────────────────┐
│  REI-S   │────►│ Mô hình Embedding │
│          │     └─────────────────┘
│          │
│          │     ┌─────────────────┐
│          │────►│  Kho vector     │
└──────────┘     └─────────────────┘
```
### Frontend

Frontend được xây dựng bằng React và TypeScript, cung cấp giao diện thân thiện với người dùng để tương tác với backend và dịch vụ REI-S. Nó bao gồm các tính năng quản lý trợ lý, tiện ích mở rộng và chức năng trò chuyện.

> Nguồn: `/frontend`

### Backend

Backend được phát triển bằng NestJS và TypeScript, đóng vai trò là lớp API chính cho ứng dụng. Nó xử lý các yêu cầu từ frontend và tương tác với các nhà cung cấp llm để hỗ trợ chức năng trò chuyện. Backend cũng quản lý các trợ lý và tiện ích mở rộng của chúng, cho phép người dùng cấu hình và sử dụng nhiều mô hình AI khác nhau cho các cuộc trò chuyện của mình.

Ngoài ra, backend còn quản lý xác thực người dùng, và giao tiếp với dịch vụ REI-S để lập chỉ mục và truy xuất tệp tin.

Để lưu trữ dữ liệu, backend sử dụng cơ sở dữ liệu **PostgreSQL**.

> Nguồn: `/backend`

### REI-S

REI-S (**R**etrieval **E**xtraction **I**ngestion **S**erver) là một máy chủ dựa trên Python cung cấp các khả năng cơ bản của RAG (Retrieval-Augmented Generation). Nó cho phép trích xuất nội dung tệp, lập chỉ mục và truy vấn, giúp ứng dụng xử lý các tập dữ liệu lớn một cách hiệu quả. Dịch vụ REI-S được thiết kế để hoạt động liền mạch với backend, cung cấp dữ liệu cần thiết cho chức năng trò chuyện và tìm kiếm tệp tin.

REI-S hỗ trợ Azure AI Search và pgvector cho lưu trữ vector, cho phép các tùy chọn truy xuất dữ liệu linh hoạt và khả năng mở rộng cao. Dịch vụ có thể được cấu hình bằng các biến môi trường để chỉ định loại kho lưu trữ vector và thông tin kết nối.

> Nguồn: `/services/reis`

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---