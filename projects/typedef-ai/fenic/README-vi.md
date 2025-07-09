<!-- markdownlint-disable MD041 MD033 -->
<div align="center">
    <picture>
        <source media="(prefers-color-scheme: dark)" srcset="docs/images/typedef-fenic-logo-dark.png">
        <img src="https://raw.githubusercontent.com/typedef-ai/fenic/main/docs/images/typedef-fenic-logo.png" alt="fenic, by typedef" width="90%">
    </picture>
</div>

# fenic: dataframe được (tái) xây dựng cho suy luận LLM

[![Phiên bản PyPI](https://img.shields.io/pypi/v/fenic.svg)](https://pypi.org/project/fenic/)
[![Các phiên bản Python](https://img.shields.io/pypi/pyversions/fenic.svg)](https://pypi.org/project/fenic/)
[![Giấy phép](https://img.shields.io/github/license/typedef-ai/fenic.svg)](https://github.com/typedef-ai/fenic/blob/main/LICENSE)
[![Discord](https://img.shields.io/discord/1381706122322513952?label=Discord&logo=discord)](https://discord.gg/GdqF3J7huR)

---

## **Tài liệu**: [docs.fenic.ai](https://docs.fenic.ai/)

fenic là một framework DataFrame lấy cảm hứng từ PySpark, có định hướng rõ ràng, đến từ typedef.ai, dành cho việc xây dựng các ứng dụng AI và agentic. Chuyển đổi dữ liệu không có cấu trúc và có cấu trúc thành những thông tin giá trị bằng các thao tác DataFrame quen thuộc được tăng cường với trí tuệ ngữ nghĩa. Hỗ trợ ưu việt cho markdown, bản ghi hội thoại và các toán tử ngữ nghĩa, cùng với khả năng suy luận hàng loạt hiệu quả trên bất kỳ nhà cung cấp mô hình nào.
## Cài đặt

fenic hỗ trợ Python `[3.10, 3.11, 3.12]`

```bash
pip install fenic
```

### Thiết lập nhà cung cấp LLM

fenic yêu cầu một khóa API từ ít nhất một nhà cung cấp LLM. Thiết lập biến môi trường phù hợp cho nhà cung cấp bạn chọn:

```bash
# Đối với OpenAI
export OPENAI_API_KEY="your-openai-api-key"

# Đối với Anthropic
export ANTHROPIC_API_KEY="your-anthropic-api-key"

# Đối với Google
export GEMINI_API_KEY="your-google-api-key"
```

## Khởi động nhanh

Cách nhanh nhất để tìm hiểu về fenic là xem qua các ví dụ.

Dưới đây là danh sách nhanh các ví dụ trong kho lưu trữ này:

| Ví dụ                                                                   | Mô tả                                                                                                                               |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------- |
| [Hello World!](examples/hello_world)                                    | Giới thiệu về trích xuất ngữ nghĩa và phân loại sử dụng các toán tử cốt lõi của fenic thông qua phân tích nhật ký lỗi.              |
| [Enrichment](examples/enrichment)                                       | DataFrame nhiều giai đoạn với trích xuất văn bản dựa trên mẫu, kết nối, và chuyển đổi dựa trên LLM được minh họa qua enrich log.    |
| [Xử lý bản ghi cuộc họp](examples/meeting_transcript_processing)         | Phân tích bản ghi gốc, tích hợp schema Pydantic, và tổng hợp phức tạp được trình bày qua phân tích cuộc họp.                       |
| [Phân tích tin tức](examples/news_analysis)                             | Phân tích và trích xuất thông tin chi tiết từ các bài báo sử dụng toán tử ngữ nghĩa và xử lý dữ liệu có cấu trúc.                   |
| [Tóm tắt podcast](examples/podcast_summarization)                       | Xử lý và tóm tắt bản ghi podcast với phân tích nhận biết người nói và trích xuất ý chính.                                          |
| [Semantic Join](examples/semantic_joins)                                | Thay vì so khớp mờ đơn giản, sử dụng tính năng semantic join mạnh mẽ của fenic để so khớp dữ liệu giữa các bảng.                   |
| [Nhận diện thực thể có tên](examples/named_entity_recognition)          | Trích xuất và phân loại các thực thể có tên từ văn bản bằng cách sử dụng trích xuất và phân loại ngữ nghĩa.                         |
| [Xử lý Markdown](examples/markdown_processing)                          | Xử lý và chuyển đổi tài liệu markdown với trích xuất dữ liệu có cấu trúc và định dạng lại.                                          |
| [Xử lý JSON](examples/json_processing)                                  | Xử lý các cấu trúc dữ liệu JSON phức tạp với các thao tác ngữ nghĩa và xác thực schema.                                             |
| [Phân cụm phản hồi](examples/feedback_clustering)                       | Nhóm và phân tích phản hồi bằng sự tương đồng ngữ nghĩa và các thao tác phân cụm.                                                  |
| [Trích xuất tài liệu](examples/document_extraction)                     | Trích xuất thông tin có cấu trúc từ nhiều định dạng tài liệu khác nhau bằng các toán tử ngữ nghĩa.                                  |

(Bạn có thể nhấp vào bất kỳ ví dụ nào phía trên để chuyển ngay đến thư mục của nó.)
## Tại sao sử dụng fenic?

fenic là một framework DataFrame lấy cảm hứng từ PySpark, có quan điểm rõ ràng, dành cho việc xây dựng các ứng dụng AI và agentic trong môi trường sản xuất.

Không giống như các công cụ dữ liệu truyền thống được chỉnh sửa để phù hợp với LLM, bộ máy truy vấn của fenic được xây dựng từ đầu với mục đích phục vụ suy luận.

Chuyển đổi dữ liệu có cấu trúc và phi cấu trúc thành thông tin chi tiết bằng các thao tác DataFrame quen thuộc, được tăng cường với trí tuệ ngữ nghĩa. Hỗ trợ hàng đầu cho markdown, bản chép lời, và các toán tử ngữ nghĩa, cùng với khả năng suy luận hàng loạt hiệu quả trên bất kỳ nhà cung cấp mô hình nào.

fenic mang lại độ tin cậy của các pipeline dữ liệu truyền thống cho các tác vụ AI.

### Các tính năng chính

#### Được thiết kế riêng cho suy luận LLM

- Bộ máy truy vấn được thiết kế từ đầu cho các tác vụ AI, không phải chỉnh sửa lại
- Tối ưu hóa lô tự động cho các lệnh gọi API
- Logic thử lại tích hợp sẵn và giới hạn tốc độ
- Đếm token và theo dõi chi phí

#### Các toán tử ngữ nghĩa là công dân hạng nhất
- `semantic.analyze_sentiment` - Phân tích cảm xúc tích hợp sẵn
- `semantic.classify` - Phân loại văn bản với các ví dụ few-shot
- `semantic.extract` - Chuyển đổi văn bản phi cấu trúc thành dữ liệu có cấu trúc với các lược đồ
- `semantic.group_by` - Nhóm dữ liệu theo sự tương đồng về ngữ nghĩa
- `semantic.join` - Kết nối các DataFrame dựa trên ý nghĩa, không chỉ giá trị
- `semantic.map` - Áp dụng các biến đổi ngôn ngữ tự nhiên
- `semantic.predicate` - Tạo các điều kiện lọc hàng bằng ngôn ngữ tự nhiên
- `semantic.reduce` - Tổng hợp dữ liệu đã nhóm với các thao tác LLM

#### Hỗ Trợ Dữ Liệu Phi Cấu Trúc Gốc

Vượt xa các kiểu dữ liệu đa phương tiện thông thường (âm thanh, hình ảnh) bằng cách tạo ra các kiểu chuyên biệt cho khối lượng công việc nặng về văn bản:

- Phân tích cú pháp và trích xuất Markdown như một kiểu dữ liệu hạng nhất
- Xử lý bản ghi (SRT, các định dạng chung) với nhận diện người nói và thời gian
- Xử lý JSON với các biểu thức JQ cho dữ liệu lồng nhau
- Tự động chia nhỏ văn bản với cấu hình chồng lấn cho các tài liệu dài

#### Hạ Tầng Sẵn Sàng Cho Sản Xuất
- Hỗ trợ nhiều nhà cung cấp (OpenAI, Anthropic, Gemini)
- Backend thực thi cục bộ và đám mây
- Xử lý lỗi và ghi log toàn diện
- Tích hợp Pydantic để đảm bảo an toàn kiểu dữ liệu

#### API DataFrame Quen Thuộc

- Các thao tác tương thích với PySpark
- Đánh giá lười (lazy evaluation) và tối ưu hóa truy vấn
- Hỗ trợ SQL cho các truy vấn phức tạp
- Tích hợp liền mạch với các pipeline dữ liệu hiện có

### Tại Sao Chọn DataFrames Cho Các Ứng Dụng LLM và Agentic?

Các ứng dụng AI và agentic về cơ bản là các pipeline và quy trình làm việc - chính xác là những gì mà API DataFrame được thiết kế để xử lý. Thay vì phát minh lại các mẫu xử lý chuyển đổi dữ liệu, lọc và tổng hợp, fenic tận dụng hàng thập kỷ thực tiễn kỹ thuật đã được kiểm chứng.

#### Kiến Trúc Tách Rời Cho Agent Tốt Hơn

fenic tạo ra sự phân tách rõ ràng giữa các tác vụ suy luận nặng và tương tác tác nhân thời gian thực. Bằng cách chuyển xử lý theo lô ra khỏi môi trường runtime của tác nhân, bạn sẽ nhận được:

- Các agent dự đoán được và phản hồi nhanh hơn
- Tối ưu hóa sử dụng tài nguyên với các cuộc gọi LLM theo lô
- Phân tách rõ ràng hơn giữa lập kế hoạch/điều phối và thực thi
#### Dành cho Tất cả Kỹ sư

DataFrame không chỉ dành cho những người làm việc với dữ liệu. Thiết kế API linh hoạt, có thể kết hợp giúp bất kỳ kỹ sư nào cũng dễ tiếp cận:

- Kết chuỗi các thao tác một cách tự nhiên: `df.filter(...).semantic.group_by(...)`
- Kết hợp liền mạch giữa phong cách mệnh lệnh và khai báo
- Bắt đầu nhanh chóng với các mẫu quen thuộc từ pandas/PySpark hoặc SQL

## Hỗ trợ

Tham gia cộng đồng của chúng tôi trên [Discord](https://discord.gg/GdqF3J7huR) để kết nối với những người dùng khác, đặt câu hỏi và nhận hỗ trợ cho các dự án fenic của bạn. Cộng đồng của chúng tôi luôn vui mừng chào đón các thành viên mới!

Nếu bạn thấy fenic hữu ích, hãy cân nhắc tặng cho chúng tôi một ⭐ ở đầu kho lưu trữ này. Sự ủng hộ của bạn sẽ giúp chúng tôi phát triển và cải thiện framework này cho mọi người!

## Đóng góp

Chúng tôi hoan nghênh mọi hình thức đóng góp! Dù bạn quan tâm đến việc viết mã, cải thiện tài liệu, kiểm thử tính năng hay đề xuất ý tưởng mới, sự giúp đỡ của bạn đều rất quý giá đối với chúng tôi.

Đối với các nhà phát triển dự định gửi thay đổi mã nguồn, chúng tôi khuyến khích bạn mở một issue để thảo luận ý tưởng trước khi tạo Pull Request. Điều này giúp đảm bảo sự đồng thuận với hướng đi của dự án và tránh trùng lặp công việc.

Vui lòng tham khảo [hướng dẫn đóng góp](https://raw.githubusercontent.com/typedef-ai/fenic/main/CONTRIBUTING.md) của chúng tôi để biết thông tin chi tiết về quy trình phát triển và thiết lập dự án.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-09

---