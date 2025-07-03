# Tome - Sách Phép Thuật AI

<img src="https://raw.githubusercontent.com/runebookai/tome/main/static/images/repo-header.png" alt="Tome" />

<p align="center">
    <code>một ứng dụng desktop kỳ diệu giúp mọi người tận dụng sức mạnh của LLMs và MCP</code>
</p>

<p align="center">
    <a href="https://discord.gg/9CH6us29YA" target="_blank"><img src="https://img.shields.io/discord/1365100902561742868?logo=discord&logoColor=fff&label=Join%20Us!&color=9D7CD8" alt="Tham gia Discord của chúng tôi" /></a>
    <a href="https://opensource.org/licenses/Apache-2.0" target="_blank"><img src="https://img.shields.io/badge/License-Apache_2.0-blue.svg" alt="Giấy phép: Apache 2.0" /></a>
    <a href="https://github.com/runebookai/tome/releases" target="_blank"><img src="https://img.shields.io/github/v/release/runebookai/tome" alt="Phát hành GitHub" /></a>
</p>

<p align="center">
    🔮 Tải ứng dụng Tome Desktop: <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_x64-setup.exe">Windows</a> | <a href="https://github.com/runebookai/tome/releases/download/0.6.0/Tome_0.6.0_aarch64.dmg">MacOS</a>
</p>

# Tome

Tome là một ứng dụng desktop cho phép **bất kỳ ai** khai thác sức mạnh kỳ diệu của LLMs và MCP. Tải Tome, kết nối với bất kỳ LLM cục bộ hoặc từ xa nào và liên kết với hàng ngàn máy chủ MCP để tạo ra cuốn sách phép thuật AI của riêng bạn.

🫥 Muốn tất cả hoạt động 100% cục bộ, 100% riêng tư? Hãy sử dụng Ollama và Qwen3 chỉ với các máy chủ MCP cục bộ để thi triển phép thuật trong vũ trụ túi của riêng bạn. ⚡ Muốn các mô hình đám mây hiện đại nhất với các máy chủ MCP từ xa mới nhất? Bạn cũng có thể làm được điều đó. Tất cả tùy thuộc vào bạn!

🏗️ Đây là phiên bản Kỹ Thuật Xem Trước nên hãy lưu ý rằng sẽ có một số điểm chưa hoàn thiện. [Tham gia Discord của chúng tôi](https://discord.gg/9CH6us29YA) để chia sẻ mẹo, thủ thuật và các vấn đề bạn gặp phải. Hãy gắn sao repo này để luôn cập nhật các bản phát hành và tính năng mới!

## 🪄 Tính Năng

- 🧙 **Trải nghiệm thân thiện với người mới**
  - Chỉ cần tải và cài đặt Tome, sau đó kết nối với LLM bạn muốn
  - Không cần chỉnh sửa JSON, Docker, python hay node
- 🤖 **Hỗ trợ đa dạng mô hình AI**
  - **Từ xa**: Google Gemini, OpenAI, bất kỳ endpoint tương thích API OpenAI nào
  - **Cục bộ**: Ollama, LM Studio, Cortex, bất kỳ endpoint tương thích API OpenAI nào
- 🔮 **Hỗ trợ MCP nâng cao**
  - Giao diện cài đặt, gỡ bỏ, bật/tắt máy chủ MCP
  - Hỗ trợ sẵn các máy chủ MCP npm, uvx, node, python
- 🏪 **Tích hợp vào registry [Smithery.ai](https://smithery.ai)**
  - Hàng ngàn máy chủ MCP có sẵn chỉ với một cú nhấp chuột cài đặt
- ✏️ **Tuỳ chỉnh cửa sổ ngữ cảnh và nhiệt độ**
- 🧰 **Hỗ trợ gốc cho gọi công cụ và mô hình suy luận**
  - Giao diện trực quan thể hiện rõ các lệnh gọi công cụ và thông báo suy nghĩ

## Demo

https://github.com/user-attachments/assets/0775d100-3eba-4219-9e2f-360a01f28cce

# Bắt Đầu

## Yêu Cầu

- MacOS hoặc Windows (Linux sẽ sớm ra mắt!)
- Nhà cung cấp LLM bạn chọn: [Ollama](https://ollama.com/) hoặc [Gemini API key](https://aistudio.google.com/app/apikey) đều dễ dàng/miễn phí
- [Tải bản phát hành mới nhất của Tome](https://github.com/runebookai/tome/releases)

## Bắt Đầu Nhanh

1. Cài đặt [Tome](https://github.com/runebookai/tome/releases)
2. Kết nối với nhà cung cấp LLM bạn muốn - OpenAI, Ollama và Gemini đã được thiết lập sẵn nhưng bạn cũng có thể thêm các nhà cung cấp như LM Studio bằng cách sử dụng http://localhost:1234/v1 làm URL
3. Mở tab MCP trong Tome và cài đặt máy chủ [MCP đầu tiên của bạn](https://github.com/modelcontextprotocol/servers) (Fetch là lựa chọn dễ bắt đầu, chỉ cần dán `uvx mcp-server-fetch` vào trường máy chủ).
4. Trò chuyện với mô hình của bạn được hỗ trợ bởi MCP! Hãy yêu cầu nó lấy tin nổi bật nhất trên Hacker News.

# Tầm Nhìn

Chúng tôi muốn giúp mọi người tiếp cận LLM cục bộ và MCP. Chúng tôi đang xây dựng một công cụ cho phép bạn sáng tạo với LLM, bất kể bạn là kỹ sư, người thích mày mò, nhà sáng tạo hay bất kỳ ai.

## Nguyên Tắc Cốt Lõi

- **Tome ưu tiên cục bộ:** Bạn kiểm soát nơi dữ liệu của mình được gửi đi.
- **Tome dành cho tất cả mọi người:** Bạn không cần phải quản lý các ngôn ngữ lập trình, trình quản lý gói hay các file cấu hình json.

## Kế Hoạch Tiếp Theo

Chúng tôi đã nhận được rất nhiều phản hồi tuyệt vời trong vài tuần kể từ khi phát hành Tome, nhưng chúng tôi còn nhiều kế hoạch lớn trong tương lai. Chúng tôi muốn đưa LLM ra khỏi hộp chat, và sẽ có rất nhiều tính năng mới để giúp các bạn làm điều đó.

- Nhiệm vụ theo lịch: LLM nên thực hiện những việc hữu ích ngay cả khi bạn không ngồi trước máy tính.
- Tích hợp gốc: Máy chủ MCP là cách tuyệt vời để truy cập công cụ và thông tin, nhưng chúng tôi muốn bổ sung các tích hợp mạnh mẽ hơn để tương tác với LLM theo cách độc đáo.
- Trình xây dựng ứng dụng: chúng tôi tin rằng về lâu dài, trải nghiệm tốt nhất sẽ không chỉ nằm ở giao diện chat. Chúng tôi có kế hoạch bổ sung thêm các công cụ để bạn tạo ra các ứng dụng và quy trình làm việc mạnh mẽ.
- ??? Hãy cho chúng tôi biết bạn muốn thấy gì! Tham gia cộng đồng qua các liên kết bên dưới, chúng tôi rất mong được lắng nghe ý kiến từ bạn.

# Cộng Đồng

[Discord](https://discord.gg/9CH6us29YA) [Blog](https://blog.runebook.ai) [Bluesky](https://bsky.app/profile/gettome.app) [Twitter](https://twitter.com/get_tome) 

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---