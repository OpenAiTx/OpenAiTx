# Memvid - Trí Nhớ AI Dựa Trên Video 🧠📹

**Giải pháp nhẹ, mang tính đột phá cho trí nhớ AI ở quy mô lớn**

[![Phiên bản PyPI](https://badge.fury.io/py/memvid.svg)](https://pypi.org/project/memvid/)
[![Giấy phép: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
[![Python 3.8+](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/)
[![Kiểu mã: black](https://img.shields.io/badge/code%20style-black-000000.svg)](https://github.com/psf/black)

Memvid cách mạng hóa quản lý trí nhớ AI bằng cách mã hóa dữ liệu văn bản thành các video, cho phép **tìm kiếm ngữ nghĩa cực nhanh** trên hàng triệu đoạn văn bản với **thời gian truy xuất dưới một giây**. Khác với các cơ sở dữ liệu vector truyền thống tiêu tốn lượng lớn RAM và lưu trữ, Memvid nén kho tri thức của bạn thành các tệp video nhỏ gọn trong khi vẫn duy trì truy cập tức thì đến bất kỳ thông tin nào.

## 🎥 Demo

https://github.com/user-attachments/assets/ec550e93-e9c4-459f-a8a1-46e122b5851e

## ✨ Tính Năng Nổi Bật

- 🎥 **Video như Cơ Sở Dữ Liệu**: Lưu trữ hàng triệu đoạn văn bản trong một tệp MP4 duy nhất
- 🔍 **Tìm kiếm Ngữ nghĩa**: Tìm nội dung liên quan bằng truy vấn ngôn ngữ tự nhiên
- 💬 **Chat tích hợp**: Giao diện trò chuyện với phản hồi theo ngữ cảnh
- 📚 **Hỗ trợ PDF**: Nhập và lập chỉ mục tài liệu PDF trực tiếp
- 🚀 **Truy xuất Nhanh**: Tìm kiếm dưới một giây trên tập dữ liệu lớn
- 💾 **Lưu trữ Hiệu quả**: Nén gấp 10 lần so với cơ sở dữ liệu truyền thống
- 🔌 **LLM Cắm được**: Hoạt động với OpenAI, Anthropic hoặc mô hình cục bộ
- 🌐 **Ưu tiên Ngoại tuyến**: Không cần internet sau khi tạo video
- 🔧 **API Đơn giản**: Bắt đầu chỉ với 3 dòng mã

## 🎯 Trường Hợp Ứng Dụng

- **📖 Thư viện Số**: Lập chỉ mục hàng ngàn cuốn sách trong một tệp video duy nhất
- **🎓 Nội dung Giáo dục**: Tạo bộ nhớ video có thể tìm kiếm cho tài liệu khóa học
- **📰 Lưu trữ Tin tức**: Nén nhiều năm bài báo thành cơ sở dữ liệu video dễ quản lý
- **💼 Tri thức Doanh nghiệp**: Xây dựng kho tri thức có thể tìm kiếm trên toàn công ty
- **🔬 Bài báo Nghiên cứu**: Tìm kiếm ngữ nghĩa nhanh qua tài liệu khoa học
- **📝 Ghi chú Cá nhân**: Biến ghi chú của bạn thành trợ lý AI có thể tìm kiếm

## 🚀 Vì Sao Chọn Memvid?

### Đổi Mới Mang Tính Đột Phá
- **Video như Cơ Sở Dữ Liệu**: Lưu trữ hàng triệu đoạn văn bản trong một tệp MP4 duy nhất
- **Truy xuất Tức thì**: Tìm kiếm ngữ nghĩa dưới một giây trên dữ liệu lớn
- **Hiệu quả Lưu trữ gấp 10 lần**: Nén video giảm đáng kể dung lượng bộ nhớ
- **Không Hạ tầng**: Không cần máy chủ cơ sở dữ liệu, chỉ là các tệp bạn có thể sao chép ở bất cứ đâu
- **Ưu tiên Ngoại tuyến**: Hoạt động hoàn toàn ngoại tuyến sau khi tạo video

### Kiến Trúc Nhẹ
- **Phụ thuộc Tối thiểu**: Chức năng cốt lõi chỉ ~1000 dòng Python
- **Thân thiện CPU**: Chạy hiệu quả không cần GPU
- **Di động**: Một tệp video chứa toàn bộ kho tri thức của bạn
- **Có thể Truyền trực tuyến**: Video có thể truyền từ lưu trữ đám mây

## 📦 Cài Đặt

### Cài Nhanh
```bash
pip install memvid
```

### Để Hỗ Trợ PDF
```bash
pip install memvid PyPDF2
```

### Thiết lập Khuyến nghị (Môi trường ảo)
```bash
# Tạo thư mục dự án mới
mkdir my-memvid-project
cd my-memvid-project

# Tạo môi trường ảo
python -m venv venv

# Kích hoạt môi trường
# Trên macOS/Linux:
source venv/bin/activate
# Trên Windows:
venv\Scripts\activate

# Cài đặt memvid
pip install memvid

# Để hỗ trợ PDF:
pip install PyPDF2
```

## 🎯 Bắt Đầu Nhanh

### Sử Dụng Cơ Bản
```python
from memvid import MemvidEncoder, MemvidChat

# Tạo trí nhớ video từ các đoạn văn bản
chunks = ["Thông tin quan trọng 1", "Thông tin quan trọng 2", "Chi tiết sự kiện lịch sử"]
encoder = MemvidEncoder()
encoder.add_chunks(chunks)
encoder.build_video("memory.mp4", "memory_index.json")

# Trò chuyện với trí nhớ của bạn
chat = MemvidChat("memory.mp4", "memory_index.json")
chat.start_session()
response = chat.chat("Bạn biết gì về các sự kiện lịch sử?")
print(response)
```

### Tạo Trí Nhớ từ Tài Liệu
```python
from memvid import MemvidEncoder
import os

# Tải tài liệu
encoder = MemvidEncoder(chunk_size=512, overlap=50)

# Thêm tệp văn bản
for file in os.listdir("documents"):
    with open(f"documents/{file}", "r") as f:
        encoder.add_text(f.read(), metadata={"source": file})

# Tạo video tối ưu
encoder.build_video(
    "knowledge_base.mp4",
    "knowledge_index.json",
    fps=30,  # FPS cao hơn = nhiều đoạn mỗi giây hơn
    frame_size=512  # Kích thước khung lớn hơn = nhiều dữ liệu mỗi khung hơn
)
```

### Tìm kiếm & Truy xuất Nâng cao
```python
from memvid import MemvidRetriever

# Khởi tạo bộ truy xuất
retriever = MemvidRetriever("knowledge_base.mp4", "knowledge_index.json")

# Tìm kiếm ngữ nghĩa
results = retriever.search("thuật toán học máy", top_k=5)
for chunk, score in results:
    print(f"Điểm: {score:.3f} | {chunk[:100]}...")

# Lấy cửa sổ ngữ cảnh
context = retriever.get_context("giải thích mạng nơ-ron", max_tokens=2000)
print(context)
```

### Giao Diện Chat Tương Tác
```python
from memvid import MemvidInteractive

# Khởi động giao diện trò chuyện tương tác
interactive = MemvidInteractive("knowledge_base.mp4", "knowledge_index.json")
interactive.run()  # Mở giao diện web tại http://localhost:7860
```

### Kiểm tra với file_chat.py
Script `examples/file_chat.py` cung cấp cách kiểm thử toàn diện Memvid với tài liệu của bạn:

```bash
# Xử lý một thư mục tài liệu
python examples/file_chat.py --input-dir /path/to/documents --provider google

# Xử lý các tệp cụ thể
python examples/file_chat.py --files doc1.txt doc2.pdf --provider openai

# Sử dụng nén H.265 (cần Docker)
python examples/file_chat.py --input-dir docs/ --codec h265 --provider google

# Cắt đoạn tùy chỉnh cho tài liệu lớn
python examples/file_chat.py --files large.pdf --chunk-size 2048 --overlap 32 --provider google

# Tải trí nhớ hiện có
python examples/file_chat.py --load-existing output/my_memory --provider google
```

### Ví dụ Hoàn Chỉnh: Chat với một sách PDF
```bash
# 1. Tạo thư mục mới và thiết lập môi trường
mkdir book-chat-demo
cd book-chat-demo
python -m venv venv
source venv/bin/activate  # Trên Windows: venv\Scripts\activate

# 2. Cài đặt phụ thuộc
pip install memvid PyPDF2

# 3. Tạo book_chat.py
cat > book_chat.py << 'EOF'
from memvid import MemvidEncoder, chat_with_memory
import os

# Tệp PDF của bạn
book_pdf = "book.pdf"  # Thay thế bằng đường dẫn PDF của bạn

# Xây dựng trí nhớ video
encoder = MemvidEncoder()
encoder.add_pdf(book_pdf)
encoder.build_video("book_memory.mp4", "book_index.json")

# Chat với cuốn sách
api_key = os.getenv("OPENAI_API_KEY")  # Tùy chọn: cho phản hồi AI
chat_with_memory("book_memory.mp4", "book_index.json", api_key=api_key)
EOF

# 4. Chạy chương trình
export OPENAI_API_KEY="your-api-key"  # Tùy chọn
python book_chat.py
```

## 🛠️ Cấu Hình Nâng Cao

### Embeddings Tùy Chỉnh
```python
from sentence_transformers import SentenceTransformer

# Sử dụng mô hình embedding tùy chỉnh
custom_model = SentenceTransformer('sentence-transformers/all-mpnet-base-v2')
encoder = MemvidEncoder(embedding_model=custom_model)
```

### Tối Ưu Hóa Video
```python
# Để nén tối đa
encoder.build_video(
    "compressed.mp4",
    "index.json",
    fps=60,  # Nhiều khung hình mỗi giây hơn
    frame_size=256,  # Khung hình nhỏ hơn
    video_codec='h265',  # Nén tốt hơn
    crf=28  # Chất lượng nén (số càng nhỏ = chất lượng càng cao)
)
```

### Xử Lý Phân Tán
```python
# Xử lý tập dữ liệu lớn song song
encoder = MemvidEncoder(n_workers=8)
encoder.add_chunks_parallel(massive_chunk_list)
```

## 🐛 Khắc Phục Sự Cố

### Các Vấn Đề Thường Gặp

**ModuleNotFoundError: No module named 'memvid'**
```bash
# Đảm bảo bạn đang sử dụng đúng Python
which python  # Phải hiển thị đường dẫn môi trường ảo của bạn
# Nếu không, hãy kích hoạt môi trường ảo:
source venv/bin/activate  # Trên Windows: venv\Scripts\activate
```

**ImportError: PyPDF2 is required for PDF support**
```bash
pip install PyPDF2
```

**Vấn Đề Với API Key LLM**
```bash
# Thiết lập API key của bạn (lấy tại https://platform.openai.com)
export GOOGLE_API_KEY="AIzaSyB1-..."  # macOS/Linux
# Hoặc trên Windows:
set GOOGLE_API_KEY=AIzaSyB1-...
```

**Xử Lý PDF Lớn**
```python
# Với các PDF rất lớn, hãy dùng kích thước chunk nhỏ hơn
encoder = MemvidEncoder()
encoder.add_pdf("large_book.pdf", chunk_size=400, overlap=50)
```

## 🤝 Đóng Góp

Chúng tôi hoan nghênh mọi đóng góp! Vui lòng xem [Hướng dẫn Đóng góp](https://raw.githubusercontent.com/Olow304/memvid/main/CONTRIBUTING.md) để biết chi tiết.

```bash
# Chạy kiểm thử
pytest tests/

# Chạy với kiểm thử độ phủ
pytest --cov=memvid tests/

# Định dạng mã nguồn
black memvid/
```

## 🆚 So Sánh Với Các Giải Pháp Truyền Thống

| Tính năng           | Memvid   | Vector DBs | DB Truyền Thống |
|---------------------|----------|------------|-----------------|
| Hiệu quả lưu trữ    | ⭐⭐⭐⭐⭐    | ⭐⭐         | ⭐⭐⭐            |
| Độ phức tạp cấu hình| Đơn giản | Phức tạp   | Phức tạp        |
| Tìm kiếm ngữ nghĩa  | ✅        | ✅         | ❌              |
| Sử dụng ngoại tuyến | ✅        | ❌         | ✅              |
| Tính di động        | Tệp tin   | Server     | Server          |
| Khả năng mở rộng    | Hàng triệu| Hàng triệu | Hàng tỷ         |
| Chi phí             | Miễn phí  | $$$$       | $$$             |


## 📚 Ví Dụ

Hãy xem thư mục [examples/](https://raw.githubusercontent.com/Olow304/memvid/main/examples/) để biết:
- Xây dựng bộ nhớ từ dữ liệu Wikipedia dump
- Tạo kho kiến thức cá nhân
- Hỗ trợ đa ngôn ngữ
- Cập nhật bộ nhớ theo thời gian thực
- Tích hợp với các LLM phổ biến

## 🆘 Trợ Giúp

- 📖 [Tài liệu](https://github.com/olow304/memvid/wiki) - Hướng dẫn đầy đủ
- 💬 [Thảo luận](https://github.com/olow304/memvid/discussions) - Đặt câu hỏi
- 🐛 [Theo dõi lỗi](https://github.com/olow304/memvid/issues) - Báo cáo lỗi
- 🌟 [Show & Tell](https://github.com/olow304/memvid/discussions/categories/show-and-tell) - Chia sẻ dự án của bạn

## 🔗 Liên Kết

- [Kho GitHub](https://github.com/olow304/memvid)
- [Gói trên PyPI](https://pypi.org/project/memvid)
- [Nhật ký thay đổi](https://github.com/olow304/memvid/releases)


## 📄 Giấy Phép

Giấy phép MIT - xem tệp [LICENSE](https://raw.githubusercontent.com/Olow304/memvid/main/LICENSE) để biết chi tiết.

## 🙏 Lời Cảm Ơn

Được tạo bởi [Olow304](https://github.com/olow304) và cộng đồng Memvid.

Được xây dựng với ❤️ sử dụng:
- [sentence-transformers](https://www.sbert.net/) - Embeddings hiện đại cho tìm kiếm ngữ nghĩa
- [OpenCV](https://opencv.org/) - Thị giác máy tính và xử lý video
- [qrcode](https://github.com/lincolnloop/python-qrcode) - Tạo mã QR
- [FAISS](https://github.com/facebookresearch/faiss) - Tìm kiếm tương đồng hiệu quả
- [PyPDF2](https://github.com/py-pdf/pypdf) - Trích xuất văn bản PDF

Đặc biệt cảm ơn tất cả các cộng tác viên đã giúp Memvid ngày càng tốt hơn!

---

**Sẵn sàng cách mạng hóa quản lý bộ nhớ AI? Cài đặt Memvid và bắt đầu xây dựng ngay!** 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---