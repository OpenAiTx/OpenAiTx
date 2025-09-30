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

### CORE: Lớp Bộ Nhớ Thống Nhất cho Claude, Cursor, ChatGPT & Mọi Công Cụ AI

<p align="center">
    <a href="https://deepwiki.com/RedPlanetHQ/core">
        <img src="https://deepwiki.com/badge.svg" alt="DeepWiki Badge" />
    </a>
</p>
<p align="center">
    <a href="https://docs.heysol.ai/core/overview"><b>Tài liệu hướng dẫn</b></a> •
    <a href="https://discord.gg/YGUZcvDjUa"><b>Discord</b></a>
</p>
</div>

## 🔥 Điểm nổi bật về nghiên cứu

Bộ nhớ CORE đạt **88,24%** độ chính xác trung bình trên bộ dữ liệu Locomo ở tất cả các nhiệm vụ suy luận, vượt trội đáng kể so với các nhà cung cấp bộ nhớ khác. Xem thêm bài [blog](https://blog.heysol.ai/we-built-memory-for-individuals-and-achieved-sota-on-locomo-benchmark/) để biết thêm thông tin.

<img width="6048" height="3428" alt="benchmark" src="https://github.com/user-attachments/assets/2e5fdac5-02ed-4d00-9312-c21d09974e1f" />
(1) Câu hỏi đơn bước yêu cầu trả lời dựa trên một phiên duy nhất; (2) Câu hỏi đa bước cần tổng hợp thông tin từ nhiều phiên khác nhau; (3) Câu hỏi kiến thức mở có thể trả lời bằng cách kết hợp thông tin người nói cung cấp với kiến thức ngoài như kiến thức thường thức hoặc thực tế thế giới; (4) Câu hỏi suy luận thời gian có thể trả lời bằng cách suy luận thời gian và nắm bắt dữ liệu liên quan đến thời gian trong hội thoại;

## Tổng quan

**Vấn đề** 

Nhà phát triển mất thời gian giải thích lại ngữ cảnh cho công cụ AI. Hết giới hạn token ở Claude? Bắt đầu lại và mất hết mọi thứ. Chuyển từ ChatGPT/Claude sang Cursor? Lại phải giải thích ngữ cảnh. Cuộc trò chuyện, quyết định, và nhận định của bạn biến mất giữa các phiên. Mỗi công cụ AI mới, chi phí chuyển ngữ cảnh lại tăng.

**Giải pháp** - **CORE** (**Contextual Observation & Recall Engine**)

CORE là lớp bộ nhớ hợp nhất, bền vững, mã nguồn mở cho tất cả công cụ AI của bạn. Ngữ cảnh của bạn đi theo từ Cursor sang Claude, từ ChatGPT tới Claude Code. Một đồ thị tri thức duy nhất ghi nhớ ai nói gì, khi nào và tại sao. Kết nối một lần, nhớ ở mọi nơi. Ngừng quản lý ngữ cảnh và bắt đầu xây dựng.

## 🚀 Bắt đầu ngay
**Xây dựng đồ thị bộ nhớ hợp nhất của bạn trong 5 phút:**

1. **Đăng ký** tại [core.heysol.ai](https://core.heysol.ai) và tạo tài khoản của bạn
2. **Thêm bộ nhớ đầu tiên** - chia sẻ ngữ cảnh về bản thân bạn

    <img width="2088" height="1212" alt="first-memory" src="https://github.com/user-attachments/assets/ecfab88e-e91a-474d-9ef5-fc6c19b655a8" />


3. **Hình dung đồ thị bộ nhớ của bạn** và xem cách CORE tự động kết nối các sự kiện
5. **Thử nghiệm** - hỏi "Bạn biết gì về tôi?" trong phần hội thoại
6. Kết nối với các công cụ của bạn:
   - [Claude](https://docs.heysol.ai/providers/claude) & [Cursor](https://docs.heysol.ai/providers/cursor) - lập trình có ngữ cảnh
   - [CLaude Code CLI](https://docs.heysol.ai/providers/claude-code) & [Gemini CLI](https://docs.heysol.ai/providers/claude-code) - lập trình trên terminal với bộ nhớ
   - [Thêm tiện ích mở rộng trình duyệt](https://docs.heysol.ai/providers/browser-extension) - mang bộ nhớ của bạn tới mọi website
   - [Linear](https://docs.heysol.ai/integrations/linear), [Github](https://docs.heysol.ai/integrations/github) - tự động thêm ngữ cảnh dự án

## 🧩 Tính Năng Chính

### 🧠 **Bộ Nhớ Hợp Nhất, Di Động**: 
Thêm và truy xuất bộ nhớ của bạn trên **Cursor, Windsurf, Claude Desktop, Claude Code, Gemini CLI, AWS's Kiro, VS Code và Roo Code** thông qua MCP

![core-claude](https://github.com/user-attachments/assets/56c98288-ee87-4cd0-8b02-860aca1c7f9a)


### 🕸️ **Đồ Thị Tri Thức Thời Gian + Hiện Thực**: 

Ghi nhớ câu chuyện đằng sau mỗi sự kiện—theo dõi ai nói gì, khi nào và tại sao với các mối quan hệ phong phú và nguồn gốc đầy đủ, không chỉ lưu trữ phẳng

![core-memory-graph](https://github.com/user-attachments/assets/5d1ee659-d519-4624-85d1-e0497cbdd60a)


### 🌐 **Tiện Ích Trình Duyệt**: 

Lưu các cuộc trò chuyện và nội dung từ ChatGPT, Grok, Gemini, Twitter, YouTube, bài viết blog, và bất kỳ trang web nào trực tiếp vào bộ nhớ CORE của bạn.

**Cách Sử Dụng Tiện Ích**
1. [Tải Tiện Ích](https://chromewebstore.google.com/detail/core-extension/cglndoindnhdbfcbijikibfjoholdjcc) từ Chrome Web Store.
2. Đăng nhập vào [bảng điều khiển CORE](https://core.heysol.ai)
   - Chuyển đến Cài đặt (góc dưới bên trái)
   - Vào API Key → Tạo khóa mới → Đặt tên là “extension.”
3. Mở tiện ích, dán API key của bạn và lưu lại.

https://github.com/user-attachments/assets/6e629834-1b9d-4fe6-ae58-a9068986036a


### 💬 **Trò Chuyện Với Bộ Nhớ**: 
Đặt câu hỏi như "Sở thích viết của tôi là gì?" với thông tin tức thì từ kho tri thức đã kết nối của bạn

![chat-with-memory](https://github.com/user-attachments/assets/d798802f-bd51-4daf-b2b5-46de7d206f66)


### ⚡ **Đồng Bộ Tự Động Từ Ứng Dụng**:

Tự động thu thập ngữ cảnh liên quan từ Linear, Slack, Notion, GitHub và các ứng dụng kết nối khác vào bộ nhớ CORE của bạn
📖 **[Xem Tất Cả Tích Hợp](https://raw.githubusercontent.com/RedPlanetHQ/core/main/./integrations/README.md)** - Danh sách đầy đủ các dịch vụ được hỗ trợ và các tính năng của chúng

![core-slack](https://github.com/user-attachments/assets/d5fefe38-221e-4076-8a44-8ed673960f03)


### 🔗 **Trung Tâm Tích Hợp MCP**: 

Kết nối Linear, Slack, GitHub, Notion một lần với CORE—sau đó sử dụng tất cả công cụ của họ trong Claude, Cursor hoặc bất kỳ máy khách MCP nào chỉ với một URL duy nhất


![core-linear-claude](https://github.com/user-attachments/assets/7d59d92b-8c56-4745-a7ab-9a3c0341aa32)



## Cách CORE tạo bộ nhớ

<img width="12885" height="3048" alt="memory-ingest-diagram" src="https://github.com/user-attachments/assets/c51679de-8260-4bee-bebf-aff32c6b8e13" />

Quy trình tiếp nhận của CORE có bốn giai đoạn nhằm ghi lại bối cảnh đang phát triển:

1. **Chuẩn hóa**: Liên kết thông tin mới với bối cảnh gần đây, chia nhỏ tài liệu dài thành các đoạn mạch lạc đồng thời giữ các tham chiếu chéo, và chuẩn hóa thuật ngữ để khi CORE trích xuất kiến thức, nó làm việc với đầu vào sạch, có bối cảnh thay vì văn bản lộn xộn.
2. **Trích xuất**: Rút ý nghĩa từ văn bản đã chuẩn hóa bằng cách xác định thực thể (con người, công cụ, dự án, khái niệm), biến chúng thành các phát biểu có bối cảnh, nguồn gốc và thời gian, và lập bản đồ mối quan hệ. Ví dụ, “Chúng tôi viết CORE bằng Next.js” thành: Thực thể (Core, Next.js), Phát biểu (CORE được phát triển bằng Next.js), và Mối quan hệ (được phát triển bằng).
3. **Giải quyết**: Phát hiện mâu thuẫn, theo dõi cách sở thích thay đổi, và bảo tồn nhiều góc nhìn cùng nguồn gốc thay vì ghi đè, để bộ nhớ phản ánh toàn bộ hành trình của bạn, không chỉ là ảnh chụp mới nhất.
4. **Tích hợp Đồ thị**: Kết nối thực thể, phát biểu và tập hợp thành đồ thị tri thức theo thời gian, liên kết sự kiện với bối cảnh và lịch sử, biến dữ liệu rời rạc thành mạng lưới tri thức sống mà các tác nhân thực sự sử dụng được.

Kết quả: Thay vì cơ sở dữ liệu phẳng, CORE mang đến cho bạn bộ nhớ phát triển và thay đổi cùng bạn - bảo toàn bối cảnh, sự tiến hóa và quyền sở hữu để các tác nhân thực sự sử dụng được.


![memory-ingest-eg](https://github.com/user-attachments/assets/1d0a8007-153a-4842-9586-f6f4de43e647)

## Cách CORE truy xuất bộ nhớ

<img width="10610" height="3454" alt="memory-search-diagram" src="https://github.com/user-attachments/assets/3541893e-f7c9-42b9-8fad-6dabf138dbeb" />

Khi bạn hỏi CORE một câu, nó không chỉ tra cứu văn bản—mà còn khai thác toàn bộ đồ thị tri thức của bạn để tìm câu trả lời hữu ích nhất.

1. **Tìm kiếm**: CORE rà soát bộ nhớ từ nhiều góc độ cùng lúc—tìm kiếm từ khóa cho kết quả chính xác, tìm kiếm ngữ nghĩa cho ý tưởng liên quan dù diễn đạt khác nhau, và duyệt đồ thị để theo liên kết giữa các khái niệm kết nối.
2. **Xếp hạng lại**: Kết quả truy xuất được sắp xếp lại để làm nổi bật các kết quả liên quan và đa dạng nhất, đảm bảo bạn không chỉ thấy các kết quả rõ ràng mà còn cả những kết nối sâu sắc hơn.
3. **Lọc**: CORE áp dụng bộ lọc thông minh dựa trên thời gian, độ tin cậy và sức mạnh mối quan hệ, để chỉ những kiến thức ý nghĩa nhất được hiện ra.

4. **Đầu ra**: Bạn nhận lại cả các sự kiện (khẳng định rõ ràng) và các tập truyện (ngữ cảnh gốc mà chúng xuất phát), vì vậy việc ghi nhớ luôn được đặt trong bối cảnh, thời gian, và câu chuyện.

Kết quả: CORE không chỉ ghi nhớ sự kiện - nó còn ghi nhớ chúng trong đúng bối cảnh, thời gian, và câu chuyện, giúp các tác nhân phản hồi như cách bạn ghi nhớ.

## Tài liệu hướng dẫn

Khám phá tài liệu của chúng tôi để tận dụng tối đa CORE

- [Khái niệm cơ bản](https://docs.heysol.ai/concepts/memory_graph)
- [Tự triển khai](https://docs.heysol.ai/self-hosting/overview)
- [Kết nối Core MCP với Claude](https://docs.heysol.ai/providers/claude)
- [Kết nối Core MCP với Cursor](https://docs.heysol.ai/providers/cursor)

- [Khái niệm cơ bản](https://docs.heysol.ai/overview)
- [Tham khảo API](https://docs.heysol.ai/local-setup)

## 🔒 Bảo mật

CORE rất coi trọng bảo mật. Chúng tôi triển khai các phương pháp bảo mật tiêu chuẩn ngành để bảo vệ dữ liệu của bạn:

- **Mã hóa dữ liệu**: Tất cả dữ liệu khi truyền (TLS 1.3) và lưu trữ (AES-256)
- **Xác thực**: OAuth 2.0 và xác thực liên kết ma thuật
- **Kiểm soát truy cập**: Cách ly theo không gian làm việc và phân quyền theo vai trò
- **Báo cáo lỗ hổng**: Vui lòng báo cáo các vấn đề bảo mật tới harshith@tegon.ai

Để biết thông tin bảo mật chi tiết, xem [Chính sách Bảo mật](https://raw.githubusercontent.com/RedPlanetHQ/core/main/SECURITY.md).

## 🧑‍💻 Hỗ trợ

Có câu hỏi hoặc phản hồi? Chúng tôi sẵn sàng hỗ trợ:

- Discord: [Tham gia kênh core-support](https://discord.gg/YGUZcvDjUa)
- Tài liệu hướng dẫn: [docs.heysol.ai](https://docs.heysol.ai)
- Email: manik@poozle.dev

## Hướng dẫn sử dụng

**Lưu trữ:**

- Lịch sử hội thoại
- Sở thích người dùng
- Bối cảnh nhiệm vụ
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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---