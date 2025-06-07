<picture>
  <source media="(prefers-color-scheme: light)" srcset="docs/static/img/logo-dark.svg">
  <source media="(prefers-color-scheme: dark)" srcset="docs/static/img/logo-light.svg">
  <img alt="LangChain Logo" src="docs/static/img/logo-dark.svg" width="80%">
</picture>

<div>
<br>
</div>

[![Release Notes](https://img.shields.io/github/release/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/releases)
[![CI](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml/badge.svg)](https://github.com/langchain-ai/langchain/actions/workflows/check_diffs.yml)
[![PyPI - License](https://img.shields.io/pypi/l/langchain-core?style=flat-square)](https://opensource.org/licenses/MIT)
[![PyPI - Downloads](https://img.shields.io/pypi/dm/langchain-core?style=flat-square)](https://pypistats.org/packages/langchain-core)
[![GitHub star chart](https://img.shields.io/github/stars/langchain-ai/langchain?style=flat-square)](https://star-history.com/#langchain-ai/langchain)
[![Open Issues](https://img.shields.io/github/issues-raw/langchain-ai/langchain?style=flat-square)](https://github.com/langchain-ai/langchain/issues)
[![Open in Dev Containers](https://img.shields.io/static/v1?label=Dev%20Containers&message=Open&color=blue&logo=visualstudiocode&style=flat-square)](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/langchain-ai/langchain)
[<img src="https://github.com/codespaces/badge.svg" title="Open in Github Codespace" width="150" height="20">](https://codespaces.new/langchain-ai/langchain)
[![Twitter](https://img.shields.io/twitter/url/https/twitter.com/langchainai.svg?style=social&label=Follow%20%40LangChainAI)](https://twitter.com/langchainai)
[![CodSpeed Badge](https://img.shields.io/endpoint?url=https://codspeed.io/badge.json)](https://codspeed.io/langchain-ai/langchain)

> [!NOTE]
> Đang tìm thư viện JS/TS? Hãy xem [LangChain.js](https://github.com/langchain-ai/langchainjs).

LangChain là một framework xây dựng các ứng dụng sử dụng LLM. Framework này giúp bạn kết nối các thành phần tương thích và tích hợp bên thứ ba để đơn giản hóa quá trình phát triển ứng dụng AI — đồng thời đảm bảo các quyết định công nghệ của bạn vẫn phù hợp trong tương lai khi công nghệ nền tảng thay đổi.

```bash
pip install -U langchain
```

Để tìm hiểu thêm về LangChain, hãy tham khảo
[tài liệu hướng dẫn](https://python.langchain.com/docs/introduction/). Nếu bạn đang tìm kiếm khả năng tùy biến nâng cao hoặc điều phối agent, hãy xem
[LangGraph](https://langchain-ai.github.io/langgraph/), framework xây dựng luồng công việc agent có thể kiểm soát của chúng tôi.

## Tại sao sử dụng LangChain?

LangChain giúp các nhà phát triển xây dựng ứng dụng sử dụng LLM thông qua một giao diện chuẩn cho các mô hình, embeddings, kho vector, và nhiều hơn nữa.

Sử dụng LangChain cho:
- **Bổ sung dữ liệu theo thời gian thực**. Dễ dàng kết nối LLM với nhiều nguồn dữ liệu và các hệ thống bên ngoài/nội bộ, tận dụng thư viện tích hợp phong phú của LangChain với các nhà cung cấp mô hình, công cụ, kho vector, bộ truy xuất, và nhiều hơn nữa.
- **Khả năng tương tác giữa các mô hình**. Thay đổi linh hoạt các mô hình khi đội ngũ kỹ thuật thử nghiệm để tìm ra lựa chọn tốt nhất cho nhu cầu ứng dụng. Khi ngành công nghiệp phát triển, bạn có thể thích nghi nhanh chóng — các tầng trừu tượng của LangChain giúp bạn phát triển liên tục mà không bị chững lại.

## Hệ sinh thái của LangChain
Mặc dù framework LangChain có thể được sử dụng độc lập, nó cũng tích hợp liền mạch với bất kỳ sản phẩm nào của LangChain, cung cấp cho các nhà phát triển một bộ công cụ đầy đủ khi xây dựng ứng dụng LLM.

Để nâng cao quá trình phát triển ứng dụng LLM của bạn, hãy kết hợp LangChain với:

- [LangSmith](http://www.langchain.com/langsmith) - Hữu ích cho việc đánh giá agent và quan sát hệ thống. Gỡ lỗi các lần chạy ứng dụng LLM kém hiệu quả, đánh giá quá trình hoạt động của agent, theo dõi khi vận hành thực tế và cải thiện hiệu suất theo thời gian.
- [LangGraph](https://langchain-ai.github.io/langgraph/) - Xây dựng agent có khả năng xử lý các tác vụ phức tạp một cách đáng tin cậy với LangGraph, framework điều phối agent cấp thấp của chúng tôi. LangGraph cung cấp kiến trúc tùy chỉnh, bộ nhớ dài hạn, và quy trình có sự tham gia của con người — đã được tin dùng trong thực tế bởi các công ty như LinkedIn, Uber, Klarna và GitLab.
- [Nền tảng LangGraph](https://langchain-ai.github.io/langgraph/concepts/langgraph_platform/) - Triển khai và mở rộng agent dễ dàng với nền tảng triển khai chuyên biệt cho các quy trình làm việc có trạng thái, chạy lâu dài. Khám phá, tái sử dụng, cấu hình và chia sẻ agent giữa các đội nhóm — đồng thời thử nghiệm nhanh với mô hình trực quan trong
[LangGraph Studio](https://langchain-ai.github.io/langgraph/concepts/langgraph_studio/).

## Tài nguyên bổ sung
- [Hướng dẫn nhanh](https://python.langchain.com/docs/tutorials/): Các ví dụ minh họa đơn giản giúp bạn bắt đầu với LangChain.
- [Hướng dẫn thao tác](https://python.langchain.com/docs/how_to/): Đoạn mã nhanh, dễ áp dụng cho các chủ đề như gọi công cụ, các trường hợp sử dụng RAG, và nhiều hơn nữa.
- [Hướng dẫn khái niệm](https://python.langchain.com/docs/concepts/): Giải thích các khái niệm quan trọng phía sau framework LangChain.
- [Tham khảo API](https://python.langchain.com/api_reference/): Tham khảo chi tiết về cách sử dụng các package nền tảng và tích hợp của LangChain.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---