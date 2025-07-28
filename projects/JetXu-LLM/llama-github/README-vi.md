
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=JetXu-LLM&project=llama-github&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# llama-github

[Tài liệu chi tiết] https://deepwiki.com/JetXu-LLM/llama-github

[![Phiên bản PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Lượt tải về](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Giấy phép](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github là một công cụ mạnh mẽ giúp bạn truy xuất (dựa trên Agentic RAG) các đoạn mã, vấn đề và thông tin kho lưu trữ phù hợp nhất từ GitHub dựa trên truy vấn của bạn, chuyển đổi chúng thành ngữ cảnh kiến thức giá trị. Nó tăng cường cho các Chatbot LLM, AI Agent và Auto-dev Agent để giải quyết các nhiệm vụ lập trình phức tạp. Dù bạn là lập trình viên cần giải pháp nhanh hay kỹ sư triển khai các Auto Dev AI Agent tiên tiến, llama-github đều giúp công việc trở nên dễ dàng và hiệu quả.

Nếu bạn thích dự án này hoặc tin rằng nó có tiềm năng, hãy cho một ⭐️. Sự ủng hộ của bạn là động lực lớn nhất của chúng tôi!

## Kiến trúc
![Kiến trúc cấp cao](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Cài đặt
```
pip install llama-github
```

## Sử dụng

Dưới đây là một ví dụ đơn giản về cách sử dụng llama-github:

```python
from llama_github import GithubRAG

# Initialize GithubRAG with your credentials
github_rag = GithubRAG(
    github_access_token="your_github_access_token", 
    openai_api_key="your_openai_api_key", # Optional in Simple Mode
    jina_api_key="your_jina_api_key" # Optional - unless you want high concurrency production deployment (s.jina.ai API will be used in llama-github)
)

# Retrieve context for a coding question (simple_mode is default set to False)
query = "How to create a NumPy array in Python?"
context = github_rag.retrieve_context(
    query, # In professional mode, one query will take nearly 1 min to generate final contexts. You could set log level to INFO to monitor the retrieval progress
    # simple_mode = True
)

print(context)
```
Để sử dụng nâng cao hơn và xem các ví dụ, vui lòng tham khảo [tài liệu hướng dẫn](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md).

## Các Tính Năng Chính

- **🔍 Truy xuất GitHub thông minh**: Tận dụng sức mạnh của llama-github để truy xuất các đoạn mã, vấn đề, và thông tin kho lưu trữ liên quan nhất từ GitHub dựa trên truy vấn của người dùng. Kỹ thuật truy xuất tiên tiến đảm bảo bạn tìm thấy thông tin phù hợp nhất một cách nhanh chóng và hiệu quả.

- **⚡ Bộ nhớ đệm kho lưu trữ**: Llama-github có cơ chế bộ nhớ đệm kho lưu trữ sáng tạo. Bằng cách lưu đệm kho lưu trữ (bao gồm README, cấu trúc, mã nguồn và vấn đề) giữa các luồng, llama-github tăng tốc đáng kể hiệu suất truy xuất GitHub và giảm thiểu tiêu hao token API GitHub. Triển khai llama-github trong môi trường sản xuất đa luồng một cách tự tin, đảm bảo hiệu năng tối ưu và tiết kiệm tài nguyên quý giá.

- **🧠 Phân tích câu hỏi bằng LLM**: Tận dụng các mô hình ngôn ngữ tiên tiến để phân tích câu hỏi và tạo ra các chiến lược tìm kiếm hiệu quả. Llama-github phân tích thông minh các truy vấn phức tạp, đảm bảo bạn lấy được thông tin phù hợp nhất từ mạng lưới kho lưu trữ rộng lớn của GitHub.

- **📚 Sinh ngữ cảnh toàn diện**: Tạo ra các câu trả lời giàu ngữ cảnh bằng cách kết hợp liền mạch thông tin truy xuất từ GitHub với khả năng suy luận của các mô hình ngôn ngữ hiện đại. Llama-github xuất sắc trong xử lý các câu hỏi phức tạp, dài, cung cấp phản hồi toàn diện, sâu sắc kèm theo nhiều ngữ cảnh hỗ trợ nhu cầu phát triển của bạn.

- **🚀 Xử lý bất đồng bộ xuất sắc**: Llama-github được xây dựng từ đầu để tận dụng tối đa lập trình bất đồng bộ. Với các cơ chế bất đồng bộ được triển khai tỉ mỉ xuyên suốt mã nguồn, llama-github có thể xử lý nhiều yêu cầu cùng lúc, tăng đáng kể hiệu suất tổng thể. Cảm nhận sự khác biệt khi llama-github quản lý khối lượng công việc lớn mà không ảnh hưởng đến tốc độ hoặc chất lượng.

- **🔧 Tích hợp LLM linh hoạt**: Dễ dàng tích hợp llama-github với nhiều nhà cung cấp LLM, mô hình embedding, và mô hình reranking để điều chỉnh khả năng thư viện theo yêu cầu của bạn. Kiến trúc mở rộng cho phép bạn tùy chỉnh và nâng cao chức năng, đảm bảo thích nghi liền mạch với môi trường phát triển riêng biệt.

- **🔒 Xác thực bảo mật mạnh mẽ**: Llama-github hỗ trợ cả token truy cập cá nhân và xác thực GitHub App, cung cấp linh hoạt khi tích hợp vào các môi trường phát triển khác nhau. Dù bạn là lập trình viên cá nhân hay làm việc trong tổ chức, llama-github đều đáp ứng với cơ chế xác thực an toàn, tin cậy.

- **🛠️ Ghi log và xử lý lỗi**: Chúng tôi hiểu tầm quan trọng của vận hành mượt mà và dễ dàng khắc phục sự cố. Vì vậy, llama-github được trang bị hệ thống ghi log và xử lý lỗi toàn diện. Hiểu rõ hành vi thư viện, nhanh chóng chẩn đoán vấn đề và duy trì quy trình phát triển ổn định, tin cậy.

## 🤖 Thử Trợ Lý Đánh Giá PR AI: LlamaPReview

Nếu bạn thấy llama-github hữu ích, bạn cũng có thể quan tâm đến trợ lý đánh giá PR GitHub dùng AI, LlamaPReview. Công cụ này được thiết kế để bổ sung quy trình phát triển và nâng cao chất lượng mã nguồn.

### Các tính năng chính của LlamaPReview:
- 🚀 Cài đặt một lần bấm, không cần cấu hình, tự động hoàn toàn
- 💯 Hiện tại sử dụng miễn phí - không cần thẻ tín dụng hoặc thông tin thanh toán
- 🧠 Đánh giá PR tự động bằng AI với hiểu biết sâu về mã nguồn
- 🌐 Hỗ trợ nhiều ngôn ngữ lập trình

**LlamaPReview sử dụng truy xuất ngữ cảnh nâng cao và phân tích LLM của llama-github** để cung cấp đánh giá mã thông minh, nhận thức ngữ cảnh. Giống như có một lập trình viên kỳ cựu, nắm rõ toàn bộ kho lưu trữ, tự động kiểm tra từng PR cho bạn!

👉 [Cài đặt LlamaPReview ngay](https://github.com/marketplace/llamapreview/) (Miễn phí)

Bằng cách sử dụng llama-github để truy xuất ngữ cảnh và LlamaPReview để đánh giá mã, bạn có thể tạo ra môi trường phát triển mạnh mẽ, tăng cường bởi AI.

## Tầm Nhìn và Lộ Trình

### Tầm Nhìn

Tầm nhìn của chúng tôi là trở thành một mô-đun then chốt trong tương lai các giải pháp phát triển dựa trên AI, tích hợp liền mạch với GitHub để giúp LLM tự động giải quyết các tác vụ mã hóa phức tạp.

![Kiến trúc Tầm nhìn](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Lộ Trình

Để xem chi tiết lộ trình dự án, vui lòng truy cập [Lộ trình Dự án](https://github.com/users/JetXu-LLM/projects/2).

## Lời Cảm Ơn

Chúng tôi xin gửi lời cảm ơn đến các dự án mã nguồn mở sau đây vì sự hỗ trợ và đóng góp của họ:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Đã cung cấp nền tảng khung giúp tăng cường khả năng prompting và xử lý LLM cho llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Đã cung cấp API s.jina.ai và các mô hình reranker, embedding mã nguồn mở giúp tăng độ chính xác và liên quan của ngữ cảnh sinh ra trong llama-github.

Sự đóng góp của họ là rất quan trọng đối với sự phát triển của llama-github, chúng tôi khuyến khích bạn tham khảo các dự án này để khám phá thêm các giải pháp sáng tạo.

## Đóng Góp

Chúng tôi hoan nghênh mọi đóng góp cho llama-github! Vui lòng xem [hướng dẫn đóng góp](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) để biết thêm chi tiết.

## Giấy Phép

Dự án này được cấp phép theo các điều khoản của giấy phép Apache 2.0. Xem tệp [LICENSE](LICENSE) để biết thêm chi tiết.

## Liên Hệ

Nếu bạn có bất kỳ câu hỏi, đề xuất hoặc phản hồi nào, vui lòng liên hệ với chúng tôi qua [email của Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Cảm ơn bạn đã lựa chọn llama-github! Chúng tôi hy vọng thư viện này sẽ nâng cao trải nghiệm phát triển AI của bạn và giúp bạn xây dựng các ứng dụng mạnh mẽ một cách dễ dàng.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-28

---