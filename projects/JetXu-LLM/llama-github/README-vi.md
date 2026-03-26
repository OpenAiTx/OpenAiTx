
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
      </div>
    </div>
  </details>
</div>

# llama-github

[Tài liệu chi tiết] https://deepwiki.com/JetXu-LLM/llama-github

[![Phiên bản PyPI](https://badge.fury.io/py/llama-github.svg)](https://badge.fury.io/py/llama-github)
[![Lượt tải](https://static.pepy.tech/badge/Llama-github)](https://pepy.tech/project/Llama-github)
[![Giấy phép](https://img.shields.io/badge/License-Apache%202.0-blue.svg)](https://opensource.org/licenses/Apache-2.0)

Llama-github là một công cụ mạnh mẽ giúp bạn truy xuất (dựa trên Agentic RAG) các đoạn mã nguồn, vấn đề và thông tin kho lưu trữ phù hợp nhất từ GitHub dựa trên truy vấn của bạn, chuyển chúng thành bối cảnh kiến thức giá trị. Nó cung cấp sức mạnh cho các Chatbot LLM, AI Agent và Auto-dev Agent để giải quyết các nhiệm vụ mã hóa phức tạp. Cho dù bạn là nhà phát triển cần giải pháp nhanh hay kỹ sư đang triển khai các Auto Dev AI Agent tiên tiến, llama-github giúp mọi thứ trở nên dễ dàng và hiệu quả.

Nếu bạn thích dự án này hoặc tin rằng nó có tiềm năng, hãy cho nó một ⭐️. Sự ủng hộ của bạn là động lực lớn nhất của chúng tôi!

## Kiến trúc
![Kiến trúc cấp cao](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/high_level_architecture.drawio.svg)

## Cài đặt
```
pip install llama-github
```

Mục tiêu runtime hiện tại được duy trì: Python `3.10+`.

## Cách sử dụng

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
contexts = github_rag.retrieve_context(
    query,
    # simple_mode = True
)

print(contexts[0]["url"])
print(contexts[0]["context"])
```
`retrieve_context()` trả về một danh sách các từ điển ngữ cảnh. Mỗi phần tử chứa ít nhất `context` và `url`.

Để sử dụng nâng cao và xem ví dụ, vui lòng tham khảo [tài liệu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/docs/usage.md). Các ví dụ chạy được với chi phí thấp cũng có sẵn trong [`examples/`](examples).

## Tính Năng Chính

- **🔍 Truy xuất GitHub thông minh**: Tận dụng sức mạnh của llama-github để truy xuất các đoạn mã, issues, và thông tin kho lưu trữ liên quan cao từ GitHub dựa trên truy vấn người dùng. Kỹ thuật truy xuất tiên tiến giúp bạn tìm thông tin phù hợp nhất một cách nhanh chóng và hiệu quả.

- **⚡ Bộ nhớ đệm Pool Repository**: Llama-github có cơ chế bộ nhớ đệm pool repository sáng tạo. Bằng cách lưu cache các repository (bao gồm README, cấu trúc, mã nguồn, và issues) trên nhiều luồng, llama-github tăng tốc đáng kể hiệu suất tìm kiếm trên GitHub và giảm tối đa lượng token API GitHub tiêu thụ.

- **🧠 Phân tích câu hỏi bằng LLM**: Tận dụng mô hình ngôn ngữ hiện đại để phân tích câu hỏi của người dùng và tạo ra chiến lược, tiêu chí tìm kiếm hiệu quả. Llama-github phân tích thông minh các truy vấn phức tạp, đảm bảo bạn truy xuất được thông tin phù hợp nhất từ mạng lưới repository lớn của GitHub.

- **📚 Tạo ngữ cảnh toàn diện**: Tạo câu trả lời phong phú, phù hợp ngữ cảnh bằng cách kết hợp mượt mà thông tin truy xuất từ GitHub với khả năng suy luận của các mô hình ngôn ngữ tiên tiến. Llama-github xuất sắc trong việc xử lý các câu hỏi phức tạp, dài, đưa ra phản hồi toàn diện và sâu sắc với nhiều ngữ cảnh hỗ trợ cho nhu cầu phát triển của bạn.

- **🚀 Xử lý bất đồng bộ vượt trội**: Llama-github được xây dựng từ đầu để tận dụng tối đa sức mạnh của lập trình bất đồng bộ. Với các cơ chế bất đồng bộ được triển khai tỉ mỉ xuyên suốt mã nguồn, llama-github có thể xử lý nhiều yêu cầu đồng thời, tăng hiệu suất tổng thể đáng kể.

- **🔧 Tích hợp LLM linh hoạt**: Dễ dàng tích hợp llama-github với nhiều nhà cung cấp LLM, mô hình nhúng, mô hình reranking, hoặc mô hình chat tương thích với LangChain nhằm tùy chỉnh khả năng thư viện theo yêu cầu của bạn.

- **🔒 Tuỳ chọn xác thực mạnh mẽ**: Llama-github hỗ trợ cả token truy cập cá nhân và xác thực qua GitHub App, mang đến sự linh hoạt để tích hợp vào nhiều môi trường phát triển khác nhau. Dù bạn là lập trình viên cá nhân hay làm việc trong tổ chức, llama-github đều đáp ứng bảo mật và tin cậy.

- **🛠️ Ghi log và xử lý lỗi**: Chúng tôi hiểu tầm quan trọng của vận hành mượt mà và xử lý sự cố dễ dàng. Vì vậy, llama-github được trang bị hệ thống ghi log và xử lý lỗi toàn diện. Nắm bắt sâu sắc hành vi thư viện, chẩn đoán sự cố nhanh chóng, duy trì quy trình phát triển ổn định và tin cậy.

## 🤖 Thử trợ lý review PR dùng AI: LlamaPReview

Nếu bạn thấy llama-github hữu ích, bạn có thể quan tâm đến trợ lý review PR trên GitHub dùng AI, LlamaPReview. Nó được thiết kế để bổ sung cho quy trình phát triển và nâng cao chất lượng mã nguồn.

### Tính năng nổi bật của LlamaPReview:
- 🚀 Cài đặt một cú nhấp, không cần cấu hình, tự động hoàn toàn
- 💯 Hiện miễn phí sử dụng - không cần thẻ tín dụng hoặc thông tin thanh toán
- 🧠 AI tự động review PR với khả năng hiểu sâu mã nguồn
- 🌐 Hỗ trợ nhiều ngôn ngữ lập trình

**LlamaPReview sử dụng khả năng truy xuất ngữ cảnh tiên tiến và phân tích bằng LLM của llama-github** để cung cấp các review mã thông minh, hiểu ngữ cảnh. Giống như có một lập trình viên kỳ cựu, nắm toàn bộ ngữ cảnh repository, review mỗi PR tự động cho bạn!

👉 [Cài đặt LlamaPReview ngay](https://github.com/marketplace/llamapreview/) (Miễn phí)

Bằng cách dùng llama-github để truy xuất ngữ cảnh và LlamaPReview cho review mã, bạn có thể tạo ra một môi trường phát triển mạnh mẽ, tăng cường bởi AI.

## Tầm nhìn và lộ trình


### Tầm nhìn

Tầm nhìn của chúng tôi là trở thành một mô-đun then chốt trong tương lai của các giải pháp phát triển dựa trên AI, tích hợp liền mạch với GitHub để trao quyền cho các LLM tự động giải quyết các nhiệm vụ lập trình phức tạp.

![Kiến trúc Tầm nhìn](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/./docs/vision.drawio.svg)

### Lộ trình

Để xem lại lộ trình trước đây, vui lòng truy cập [Tầm nhìn và Lộ trình](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/VISION_AND_ROADMAP.md).

## Lời cảm ơn

Chúng tôi xin gửi lời cảm ơn đến các dự án mã nguồn mở sau đây vì sự hỗ trợ và đóng góp của họ:

- **[LangChain](https://github.com/langchain-ai/langchain)**: Đã cung cấp nền tảng giúp tăng cường khả năng nhắc lệnh và xử lý LLM trong llama-github.
- **[Jina.ai](https://github.com/jina-ai/reader)**: Đã cung cấp API s.jina.ai và các mô hình reranker, embedding mã nguồn mở giúp nâng cao độ chính xác và mức độ liên quan của các ngữ cảnh sinh ra trong llama-github.

Những đóng góp của họ đã đóng vai trò quan trọng trong quá trình phát triển llama-github, và chúng tôi khuyến khích bạn tham khảo các dự án này để khám phá thêm những giải pháp sáng tạo.

## Đóng góp

Chúng tôi hoan nghênh mọi đóng góp cho llama-github! Vui lòng xem [hướng dẫn đóng góp](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/CONTRIBUTING.md) của chúng tôi để biết thêm thông tin.

## Giấy phép

Dự án này được cấp phép theo các điều khoản của giấy phép Apache 2.0. Xem tệp [LICENSE](LICENSE) để biết thêm chi tiết.

## Liên hệ

Nếu bạn có bất kỳ câu hỏi, đề xuất hoặc phản hồi nào, vui lòng liên hệ với chúng tôi qua [email của Jet Xu](https://raw.githubusercontent.com/JetXu-LLM/llama-github/main/mailto:Voldemort.xu@foxmail.com).

---

Cảm ơn bạn đã lựa chọn llama-github! Chúng tôi hy vọng thư viện này sẽ nâng cao trải nghiệm phát triển AI của bạn và giúp bạn xây dựng các ứng dụng mạnh mẽ một cách dễ dàng.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-26

---