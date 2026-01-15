
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=eze-is&project=ai-partner-chat&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# AI Partner Chat

Một dự án Claude Skills, giúp AI trở thành đối tác trò chuyện cá nhân hóa của bạn.

## Giới thiệu dự án

AI Partner Chat tích hợp hồ sơ người dùng, hồ sơ AI và ghi chú cá nhân đã được vector hóa, cung cấp trải nghiệm trò chuyện cá nhân hóa và nhận biết ngữ cảnh. Kỹ năng này giúp AI ghi nhớ và trích dẫn lại các ý tưởng, sở thích và kho kiến thức của bạn trước đó, tạo ra trải nghiệm tương tác liền mạch và cá nhân hóa hơn.

## Chức năng cốt lõi

### 🎭 Hệ thống hai ảnh chân dung
- **Ảnh chân dung người dùng**: Định nghĩa nền tảng, chuyên môn, sở thích và phong cách giao tiếp của bạn
- **Ảnh chân dung AI**: Tùy chỉnh vai trò, phong cách giao tiếp và cách tương tác của AI

### 📝 Tìm kiếm ghi chú thông minh
- Tự động lập chỉ mục các ghi chú Markdown của bạn
- Tìm kiếm thông minh các lịch sử liên quan dựa trên nội dung hội thoại
- Trích dẫn tự nhiên các ý tưởng và ghi chú trước đây của bạn trong hội thoại

### 💬 Hội thoại cá nhân hóa
- Tạo phản hồi cá nhân hóa dựa trên ảnh chân dung và ghi chú của bạn
- Giữ liên kết ngữ cảnh xuyên suốt hội thoại
- Trích dẫn ý tưởng của bạn một cách tự nhiên như một người bạn, thay vì máy móc "dựa theo ghi chú"

## Các trường hợp sử dụng

Khi bạn cần:
- Giao tiếp cá nhân hóa, thay vì phản hồi chung chung
- Phản hồi có nhận thức ngữ cảnh, AI nhớ nền tảng của bạn
- AI ghi nhớ và trích dẫn lại các ý tưởng và ghi chú trước đây của bạn
- Trải nghiệm hội thoại liên tục, thay vì mỗi lần đều bắt đầu mới hoàn toàn

## Cài đặt và sử dụng

### Cài đặt kỹ năng

Sao chép dự án này vào thư mục `.claude/skills/` trong thư mục làm việc của bạn:

```
<你的项目根目录>/
└── .claude/
    └── skills/
        └── ai-partner-chat/    # 本技能包
            ├── assets/
            ├── scripts/
            ├── SKILL.md
            └── README.md
```

### Sử dụng kỹ năng

Trong Claude Code, chỉ cần gửi các lệnh sau để kích hoạt kỹ năng này:

```
遵循 ai-partner-chat 对话
```

Tác nhân AI sẽ tự động:
- Đọc cấu hình kỹ năng và chỉ dẫn
- Tạo cấu trúc thư mục cần thiết (`notes/`, `config/`, `vector_db/` v.v.)
- Khởi tạo theo nhu cầu của bạn

### Quy trình khởi tạo

#### Cách 1: Để AI tự động tạo và cấu hình

Lần đầu sử dụng, bạn chỉ cần nói với AI:

```
我刚刚在 notes 里放入了对应的笔记，请根据笔记内容，进行向量化；并基于笔记内容，推测并更新 user-persona.md，以及最适合我的 ai-persona.md
```
AI agent sẽ:
1. Phân tích nội dung ghi chú trong thư mục `notes/`
2. Tự động chia nhỏ thông minh theo định dạng ghi chú và tạo cơ sở dữ liệu vector
3. Dựa vào nội dung ghi chú để suy đoán bối cảnh và sở thích của bạn
4. Tự động tạo và cập nhật `config/user-persona.md`
5. Đề xuất và tạo `config/ai-persona.md` dựa trên đặc điểm của bạn

#### Cách 2: Cấu hình hồ sơ thủ công

Nếu bạn muốn tự định nghĩa hồ sơ:
1. AI agent sẽ tự động tạo file hồ sơ từ mẫu vào thư mục `config/`
2. Bạn có thể chỉnh sửa thủ công các file này để tùy biến hồ sơ
3. Sau đó báo cho AI để tiến hành xử lý vector hóa

### Bắt đầu hội thoại

Sau khi cấu hình xong, mỗi lần sử dụng chỉ cần gửi:


```
遵循 ai-partner-chat 对话
```
AI sẽ:
- Đọc hồ sơ của bạn để hiểu về nền tảng của bạn
- Truy xuất các ghi chú lịch sử có liên quan
- Tạo ra các phản hồi cá nhân hóa và nhận biết ngữ cảnh

## Cấu trúc dự án

### Cấu trúc gói kỹ năng (nằm tại `.claude/skills/ai-partner-chat/`)


```
ai-partner-chat/
├── assets/              # 画像模板
│   ├── user-persona-template.md
│   └── ai-persona-template.md
├── scripts/             # 核心脚本
│   ├── chunk_schema.py
│   ├── vector_indexer.py
│   ├── vector_utils.py
│   └── requirements.txt
├── SKILL.md            # 技能详细文档（AI agent 会读取此文件）
└── README.md           # 本文件
```

### Thư mục dữ liệu người dùng (nằm ở thư mục gốc của dự án)

AI agent sẽ tạo cấu trúc sau trong thư mục gốc dự án của bạn:

```
<项目根目录>/
├── notes/              # 你的笔记（由你或 AI agent 创建）
├── config/             # 画像配置（由 AI agent 创建）
│   ├── user-persona.md
│   └── ai-persona.md
├── vector_db/          # 向量数据库（由 AI agent 创建）
└── venv/               # Python 虚拟环境（由 AI agent 创建）
```

**Quan trọng**: Dữ liệu người dùng và gói kỹ năng được tách biệt, thuận tiện cho việc sao lưu và di chuyển.

## Quy trình làm việc

1. **Nạp hồ sơ**: Đọc hồ sơ người dùng và hồ sơ AI, hiểu bối cảnh tương tác
2. **Truy xuất ghi chú**: Dựa trên truy vấn của người dùng, truy xuất ghi chú liên quan nhất từ cơ sở dữ liệu vector
3. **Xây dựng ngữ cảnh**: Tích hợp thông tin hồ sơ, ghi chú liên quan và lịch sử hội thoại
4. **Tạo phản hồi**: Sinh phản hồi cá nhân hóa, tự nhiên dựa trên ngữ cảnh

## Điểm nổi bật

### 🤖 AI Agent phân khúc thông minh
Hệ thống sẽ phân tích thực tế định dạng của từng ghi chú, tự động tạo ra chiến lược phân khúc phù hợp nhất thay vì dùng mẫu có sẵn. Điều này đảm bảo mọi định dạng ghi chú đều được xử lý tối ưu.

### 🎯 Trích dẫn tự nhiên
AI sẽ dẫn dắt thông tin cũ của bạn như một hồi ức tự nhiên, không nói "theo ghi nhận" một cách khô khan mà sẽ lồng ghép mượt mà vào hội thoại.

### 📦 Dữ liệu độc lập
Mọi dữ liệu của bạn (ghi chú, hồ sơ, cơ sở vector) đều lưu tại thư mục gốc dự án, dễ dàng sao lưu, di chuyển hoặc chia sẻ giữa các kỹ năng.

## Thực hành tốt nhất

### Thiết kế hồ sơ
- **Cụ thể, rõ ràng**: Hồ sơ mơ hồ sẽ dẫn đến phản hồi chung chung
- **Có ví dụ**: Trình bày mẫu tương tác mong muốn trong hồ sơ AI
- **Cập nhật định kỳ**: Liên tục tối ưu hồ sơ dựa trên chất lượng hội thoại

### Quản lý ghi chú
- **Định dạng tự do**: Hệ thống thích ứng với mọi cấu trúc ghi chú
- **Nội dung phong phú**: Ghi chú có chiều sâu mang lại hiệu quả truy xuất cao hơn
- **Cập nhật kịp thời**: Đừng quên thêm ghi chú mới vào chỉ mục

### Trải nghiệm hội thoại
- **Trích dẫn tự nhiên**: Chỉ trích dẫn khi thực sự liên quan
- **Giữ mạch hội thoại**: Không để trích dẫn làm gián đoạn dòng hội thoại tự nhiên
- **Chú trọng chất lượng**: Ưu tiên kết nối ý nghĩa hơn là số lượng

## Bảo trì và cập nhật

### Thêm ghi chú mới
Sau khi thêm ghi chú mới vào thư mục `notes/`, hãy thông báo cho AI:

```
我刚刚在 notes 里添加了新笔记，请更新向量数据库
```

Tác nhân AI sẽ tự động phân tích ghi chú mới và cập nhật chỉ mục.

### Cập nhật hồ sơ
Bạn có thể chỉnh sửa trực tiếp tệp hồ sơ trong thư mục `config/`, hoặc thông báo cho AI:

```
请根据我最近的笔记内容，更新 user-persona.md 和 ai-persona.md
```

### Tái tạo chỉ mục
Khi cấu trúc ghi chú thay đổi đáng kể, hãy thông báo cho AI:

```
请重新初始化向量数据库
```

AI agent sẽ phân tích lại tất cả ghi chú và xây dựng lại chỉ mục.

## Lưu ý

- **Chạy lần đầu**: Khi AI agent lần đầu tạo cơ sở dữ liệu vector, mô hình nhúng (~4.3GB) sẽ được tải về tự động, vui lòng chờ đợi
- **Môi trường Python**: AI agent sẽ tự động tạo môi trường ảo và cài đặt các phụ thuộc cần thiết
- **Lưu trữ dữ liệu**: Tất cả dữ liệu (ghi chú, hồ sơ, thư viện vector) được lưu tại thư mục gốc dự án, không phải trong thư mục gói kỹ năng
- **Vị trí kỹ năng**: Đảm bảo gói kỹ năng nằm trong thư mục `.claude/skills/ai-partner-chat/`

## Thông tin thêm

Vui lòng tham khảo tệp `SKILL.md` để biết tài liệu kỹ thuật và hướng dẫn sử dụng chi tiết.

---

Hãy để AI trở thành người bạn trò chuyện thực sự thấu hiểu bạn, chứ không chỉ là một công cụ.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-15

---