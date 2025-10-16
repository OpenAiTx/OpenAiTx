<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=RedPlanetHQ&project=core&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
  <a href="https://core.heysol.ai">
    <img src="https://github.com/user-attachments/assets/89066cdd-204b-46c2-8ad4-4935f5ca9edd" width="200px" alt="CORE logo" />
  </a>

### CORE: Lớp Bộ Nhớ Cá Nhân cho Ứng Dụng AI của Bạn

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/introduction"><b>Tài liệu hướng dẫn</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Nổi bật nghiên cứu

CORE memory đạt **88,24%** độ chính xác trung bình trên bộ dữ liệu Locomo cho tất cả các tác vụ suy luận, vượt trội đáng kể so với các nhà cung cấp bộ nhớ khác. Xem thêm tại [blog này](https://blog.heysol.ai/core-build-memory-knowledge-graph-for-individuals-and-achieved-sota-on-locomo-benchmark/) để biết thêm thông tin.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Câu hỏi đơn tuyến yêu cầu trả lời dựa trên một phiên duy nhất; (2) Câu hỏi đa tuyến yêu cầu tổng hợp thông tin từ nhiều phiên khác nhau; (3) Câu hỏi kiến thức miền mở có thể trả lời bằng cách tích hợp thông tin người nói cung cấp với kiến thức bên ngoài như kiến thức thường thức hoặc sự kiện thế giới; (4) Câu hỏi suy luận thời gian có thể trả lời thông qua suy luận thời gian và nắm bắt các dữ liệu liên quan đến thời gian trong hội thoại;

## Tổng quan

**Vấn đề**

Nhà phát triển tốn thời gian giải thích lại bối cảnh cho các công cụ AI. Gặp giới hạn token ở Claude? Bắt đầu lại và mất toàn bộ dữ liệu. Chuyển từ ChatGPT/Claude sang Cursor? Lại phải giải thích lại bối cảnh. Các cuộc trò chuyện, quyết định và nhận định bị mất giữa các phiên. Với mỗi công cụ AI mới, chi phí chuyển đổi ngữ cảnh ngày càng tăng.

**Giải pháp** - **CORE** (**Contextual Observation & Recall Engine**)

CORE là lớp bộ nhớ hợp nhất, liên tục, mã nguồn mở cho tất cả công cụ AI của bạn. Bối cảnh của bạn sẽ di chuyển từ Cursor sang Claude, ChatGPT đến Claude Code. Một đồ thị tri thức ghi nhớ ai nói gì, khi nào và tại sao. Kết nối một lần, ghi nhớ mọi nơi. Ngừng quản lý ngữ cảnh và bắt đầu xây dựng.

## 🚀 Tự triển khai CORE
Muốn chạy CORE trên hạ tầng của riêng bạn? Tự triển khai giúp bạn kiểm soát hoàn toàn dữ liệu và cách triển khai.

**Yêu cầu trước**:

- Đã cài đặt Docker (20.10.0+) và Docker Compose (2.20.0+)
- Có khóa API OpenAI

> **Lưu ý về các mô hình mã nguồn mở:** Chúng tôi đã thử các lựa chọn OSS như Ollama và các mô hình GPT, nhưng khả năng trích xuất sự kiện và chất lượng đồ thị còn chưa đạt yêu cầu. Chúng tôi đang tích cực tìm kiếm thêm lựa chọn.

### Thiết lập

1. Sao chép kho lưu trữ:
```
git clone https://github.com/RedPlanetHQ/core.git
cd core
```
2. Cấu hình biến môi trường trong `core/.env`:
```
OPENAI_API_KEY=your_openai_api_key
```
3. Khởi động dịch vụ
```
docker-compose up -d
```
Khi đã triển khai, bạn có thể cấu hình các nhà cung cấp AI (OpenAI, Anthropic) và bắt đầu xây dựng đồ thị bộ nhớ của mình.

👉 [Xem hướng dẫn tự triển khai đầy đủ](https://docs.heysol.ai/self-hosting/docker)

Lưu ý: Chúng tôi đã thử các mô hình nguồn mở như Ollama hoặc GPT OSS nhưng kết quả tạo dữ kiện chưa tốt, chúng tôi vẫn đang nghiên cứu cải thiện và sẽ hỗ trợ các mô hình OSS khi ổn định.

## 🚀 CORE Cloud
**Xây dựng đồ thị bộ nhớ hợp nhất chỉ trong 5 phút:**

Không muốn quản lý hạ tầng? CORE Cloud cho phép bạn xây dựng hệ thống bộ nhớ cá nhân ngay lập tức - không cài đặt, không máy chủ, chỉ cần bộ nhớ hoạt động.

1. **Đăng ký** tại [core.heysol.ai](https://core.heysol.ai) và tạo tài khoản
2. **Trực quan hóa đồ thị bộ nhớ** và xem cách CORE tự động kết nối các dữ kiện với nhau
3. **Thử nghiệm** - hỏi "Bạn biết gì về tôi?" ở mục trò chuyện
4. Kết nối với các công cụ của bạn:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - lập trình có ngữ cảnh
   - [Claude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Codex CLI](https://docs.heysol.ai/providers/codex) - lập trình dựa trên terminal với bộ nhớ
   - [Thêm tiện ích trình duyệt](https://docs.heysol.ai/providers/browser-extension) - mang bộ nhớ đến mọi website
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - tự động thêm ngữ cảnh dự án

## 🧩 Tính năng chính

### 🧠 **Bộ nhớ hợp nhất, di động**: 
Thêm và truy xuất bộ nhớ trên **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code và Roo Code** thông qua MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Đồ thị tri thức thời gian + hiện thực hóa**: 

Ghi nhớ câu chuyện đằng sau mỗi dữ kiện—theo dõi ai nói gì, khi nào và tại sao với các mối quan hệ phong phú và nguồn gốc đầy đủ, không chỉ lưu trữ phẳng

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Tiện ích mở rộng trình duyệt**: 

Lưu hội thoại và nội dung từ ChatGPT, Grok, Gemini, Twitter, YouTube, bài đăng blog và bất kỳ trang web nào trực tiếp vào bộ nhớ CORE của bạn.


**Cách sử dụng tiện ích mở rộng**
1. [Tải tiện ích mở rộng](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) từ Chrome Web Store.
2. Đăng nhập vào [bảng điều khiển CORE](https://core.heysol.ai)
   - Điều hướng đến Cài đặt (góc dưới bên trái)
   - Vào Khóa API → Tạo khóa mới → Đặt tên là “extension.”
3. Mở tiện ích mở rộng, dán khóa API của bạn và lưu lại.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Trò chuyện với Bộ nhớ**: 
Đặt câu hỏi như "Sở thích viết của tôi là gì?" và nhận phản hồi tức thì từ kiến thức đã kết nối của bạn

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Đồng bộ hóa tự động từ các ứng dụng**:

Tự động thu thập ngữ cảnh liên quan từ Linear, Slack, Notion, GitHub và các ứng dụng đã kết nối khác vào bộ nhớ CORE của bạn

📖 **[Xem tất cả tích hợp](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Danh sách đầy đủ các dịch vụ được hỗ trợ và tính năng của chúng

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **Trung tâm tích hợp MCP**: 

Kết nối Linear, Slack, GitHub, Notion một lần với CORE—sau đó sử dụng mọi công cụ của họ trong Claude, Cursor, hoặc bất kỳ khách hàng MCP nào chỉ với một URL duy nhất


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Cách CORE tạo bộ nhớ

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

Quy trình nạp dữ liệu của CORE có bốn giai đoạn được thiết kế để thu thập ngữ cảnh thay đổi:

1. **Chuẩn hóa**: Liên kết thông tin mới với ngữ cảnh gần đây, chia tài liệu dài thành các đoạn mạch lạc đồng thời giữ các tham chiếu chéo, và chuẩn hóa thuật ngữ để khi CORE trích xuất tri thức, nó đang làm việc với đầu vào sạch, có ngữ cảnh thay vì văn bản lộn xộn.
2. **Trích xuất**: Rút ra ý nghĩa từ văn bản đã chuẩn hóa bằng cách nhận diện thực thể (con người, công cụ, dự án, khái niệm), chuyển thành phát biểu với ngữ cảnh, nguồn và thời gian, và lập bản đồ quan hệ. Ví dụ, “Chúng tôi viết CORE bằng Next.js” thành: Thực thể (Core, Next.js), Phát biểu (CORE được phát triển bằng Next.js), và Quan hệ (được phát triển bằng).
3. **Giải quyết**: Phát hiện mâu thuẫn, theo dõi sự thay đổi của sở thích, và bảo toàn nhiều góc nhìn với nguồn gốc thay vì ghi đè, để bộ nhớ phản ánh toàn bộ hành trình của bạn chứ không chỉ khoảnh khắc mới nhất.
4. **Tích hợp đồ thị**: Kết nối thực thể, phát biểu, và tập diễn ra thành một đồ thị tri thức theo thời gian liên kết sự kiện với ngữ cảnh và lịch sử, biến dữ liệu rời rạc thành mạng tri thức sống mà các agent có thể sử dụng.

Kết quả: Thay vì một cơ sở dữ liệu phẳng, CORE cung cấp cho bạn bộ nhớ phát triển và thay đổi cùng bạn - bảo toàn ngữ cảnh, tiến hóa và quyền sở hữu để các agent thực sự sử dụng được.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Cách CORE truy xuất từ bộ nhớ

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Khi bạn hỏi CORE một câu, nó không chỉ tra cứu văn bản - nó đào sâu vào toàn bộ đồ thị tri thức để tìm câu trả lời hữu ích nhất.

1. **Tìm kiếm**: CORE quét bộ nhớ từ nhiều góc cùng lúc - tìm kiếm theo từ khóa cho các kết quả chính xác, tìm kiếm ngữ nghĩa cho ý liên quan dù diễn đạt khác, và duyệt đồ thị để đi theo các liên kết giữa khái niệm.
2. **Xếp hạng lại**: Các kết quả truy xuất được sắp xếp lại để làm nổi bật các kết quả liên quan nhất và đa dạng nhất, đảm bảo bạn không chỉ thấy các kết quả rõ ràng mà còn cả các kết nối sâu hơn.
3. **Lọc**: CORE áp dụng bộ lọc thông minh dựa trên thời gian, độ tin cậy và độ mạnh mối quan hệ, chỉ làm nổi bật tri thức ý nghĩa nhất.
4. **Đầu ra**: Bạn nhận cả sự kiện (phát biểu rõ ràng) lẫn tập diễn ra (ngữ cảnh gốc của chúng), để việc truy xuất luôn dựa trên ngữ cảnh, thời gian và câu chuyện.

Kết quả: CORE không chỉ truy xuất sự kiện - mà còn truy xuất đúng ngữ cảnh, thời gian và câu chuyện, để agent phản hồi đúng như bạn ghi nhớ.

## Tài liệu

Khám phá tài liệu để tận dụng tối đa CORE

- [Khái niệm cơ bản](https://docs.heysol.ai/concepts/memory_graph)
- [Tự triển khai](https://docs.heysol.ai/self-hosting/overview)
- [Kết nối Core MCP với Claude](https://docs.heysol.ai/providers/claude)
- [Kết nối Core MCP với Cursor](https://docs.heysol.ai/providers/cursor)
- [Kết nối Core MCP với Claude Code](https://docs.heysol.ai/providers/claude-code)
- [Kết nối Core MCP với Codex](https://docs.heysol.ai/providers/codex) 

- [Khái niệm cơ bản](https://docs.heysol.ai/overview)
- [Tham chiếu API](https://docs.heysol.ai/api-reference/get-user-profile)

## 🔒 Bảo mật

CORE rất chú trọng đến bảo mật. Chúng tôi áp dụng các thực hành bảo mật tiêu chuẩn ngành để bảo vệ dữ liệu của bạn:

- **Mã hóa dữ liệu**: Tất cả dữ liệu khi truyền (TLS 1.3) và khi lưu trữ (AES-256)
- **Xác thực**: OAuth 2.0 và xác thực bằng liên kết ma thuật
- **Kiểm soát truy cập**: Cách ly theo không gian làm việc và phân quyền theo vai trò
- **Báo cáo lỗ hổng**: Vui lòng báo cáo các vấn đề bảo mật tới harshith@poozle.dev

Để biết thông tin bảo mật chi tiết, xem [Chính sách Bảo mật](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Hỗ trợ

Có câu hỏi hoặc góp ý? Chúng tôi sẵn sàng hỗ trợ:

- Discord: [Tham gia kênh core-support](https://discord.gg/YGUZcvDjUa)
- Tài liệu: [docs.heysol.ai](https://docs.heysol.ai)
- Email: manik@poozle.dev

## Nguyên tắc sử dụng

**Lưu trữ:**

- Lịch sử hội thoại
- Tùy chọn người dùng
- Ngữ cảnh nhiệm vụ
- Tài liệu tham khảo

**Không lưu trữ:**

- Dữ liệu nhạy cảm (PII)
- Thông tin đăng nhập
- Nhật ký hệ thống
- Dữ liệu tạm thời

## 👥 Người đóng góp

<a href="https://github.com/RedPlanetHQ/core/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=RedPlanetHQ/core" />
</a>















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-16

---