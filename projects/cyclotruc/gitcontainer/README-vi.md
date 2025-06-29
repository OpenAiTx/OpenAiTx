![Gitcontainer](https://raw.githubusercontent.com/cyclotruc/gitcontainer/main/docs/image.png)

# Gitcontainer 🐳

**Biến bất kỳ kho lưu trữ GitHub nào thành Docker container sẵn sàng sản xuất với khả năng tạo Dockerfile tự động bằng AI.**

[![MIT License](https://img.shields.io/badge/License-MIT-green.svg)](https://choosealicense.com/licenses/mit/)
[![Python 3.9+](https://img.shields.io/badge/python-3.9+-blue.svg)](https://www.python.org/downloads/)
[![FastAPI](https://img.shields.io/badge/FastAPI-0.68+-00a393.svg)](https://fastapi.tiangolo.com/)

Gitcontainer là một ứng dụng web sử dụng AI để tự động tạo ra các Dockerfile sẵn sàng cho môi trường sản xuất bằng cách phân tích các kho lưu trữ GitHub. Chỉ cần dán URL GitHub, bạn sẽ nhận được Dockerfile phù hợp với việc lựa chọn base image thông minh, quản lý phụ thuộc, và tuân thủ các thực tiễn tốt nhất về Docker.

## 🌟 Truy cập nhanh

Chỉ cần thay thế `github.com` bằng `gitcontainer.com` trong bất kỳ URL kho lưu trữ GitHub nào để truy cập tức thì vào trang tạo Dockerfile cho kho lưu trữ đó.

Ví dụ:
```
https://github.com/username/repo  →  https://gitcontainer.com/username/repo
```

## ✨ Tính năng

- **🔄 Truy cập URL tức thì**: Chỉ cần thay 'github.com' bằng 'gitcontainer.com' trong bất kỳ URL GitHub nào
- **🤖 Phân tích bằng AI**: Sử dụng OpenAI GPT-4 để phân tích cấu trúc kho lưu trữ và tạo Dockerfile thông minh
- **⚡ Streaming thời gian thực**: Xem AI tạo Dockerfile của bạn trực tiếp bằng WebSocket streaming
- **🎯 Phát hiện thông minh**: Tự động phát hiện stack công nghệ (Python, Node.js, Java, Go, v.v.)
- **🔧 Sẵn sàng sản xuất**: Tạo Dockerfile tuân thủ các thực tiễn tốt nhất về bảo mật, build nhiều tầng, và tối ưu hóa
- **📋 Hướng dẫn bổ sung**: Thêm yêu cầu tùy chỉnh cho môi trường đặc thù
- **📄 Docker Compose**: Tự động gợi ý docker-compose.yml cho các ứng dụng phức tạp
- **🎨 Giao diện hiện đại**: Giao diện sạch sẽ, đáp ứng với trình soạn thảo Monaco hỗ trợ tô sáng cú pháp
- **📱 Thân thiện di động**: Hoạt động mượt mà trên cả máy tính và thiết bị di động

## 🚀 Bắt đầu nhanh

### Yêu cầu

- Python 3.9 hoặc cao hơn
- Git
- Khóa API OpenAI

### Cài đặt

1. **Clone kho lưu trữ:**
   ```bash
   git clone https://github.com/cyclotruc/gitcontainer.git
   cd gitcontainer
   ```

2. **Cài đặt phụ thuộc:**
   ```bash
   pip install -r requirements.txt
   ```

3. **Thiết lập biến môi trường:**
   ```bash
   # Tạo file .env
   echo "OPENAI_API_KEY=your_openai_api_key_here" > .env
   ```

4. **Chạy ứng dụng:**
   ```bash
   python app.py
   ```

5. **Mở trình duyệt:**
   Truy cập `http://localhost:8000`

## 🛠️ Cách hoạt động

1. **Xử lý URL**: Truy cập bất kỳ kho lưu trữ nào bằng cách thay 'github.com' bằng 'gitcontainer.com' trong URL
2. **Clone kho lưu trữ**: Gitcontainer sẽ clone kho lưu trữ GitHub về máy thông qua Git
3. **Phân tích mã nguồn**: Sử dụng [gitingest](https://github.com/cyclotruc/gitingest) để phân tích cấu trúc kho và trích xuất thông tin liên quan
4. **Tạo bằng AI**: Gửi phân tích đến OpenAI GPT-4 với prompt chuyên biệt để tạo Dockerfile
5. **Tối ưu hóa thông minh**: AI xem xét:
   - Phát hiện stack công nghệ
   - Quản lý phụ thuộc
   - Thực tiễn tốt nhất về bảo mật
   - Build nhiều tầng khi cần thiết
   - Cấu hình port
   - Biến môi trường
   - Health check

## 📁 Cấu trúc dự án

```
cyclotruc-gitcontainer/
├── app.py                 # Ứng dụng FastAPI chính
├── requirements.txt       # Các phụ thuộc Python
├── .env                  # Biến môi trường (tạo file này)
├── static/               # Tài sản tĩnh (icon, CSS)
├── templates/
│   └── index.jinja       # Template HTML chính
└── tools/                # Các module chức năng cốt lõi
    ├── __init__.py
    ├── create_container.py  # Tạo Dockerfile bằng AI
    ├── git_operations.py    # Clone kho GitHub
    └── gitingest.py        # Phân tích kho lưu trữ
```
## 🔧 Cấu hình

### Biến Môi Trường

| Biến      | Mô tả                            | Bắt buộc |
|-----------|----------------------------------|----------|
| `OPENAI_API_KEY` | Khóa API OpenAI của bạn           | Có       |
| `PORT`    | Cổng máy chủ (mặc định: 8000)    | Không    |
| `HOST`    | Địa chỉ máy chủ (mặc định: 0.0.0.0) | Không |

### Sử Dụng Nâng Cao

Bạn có thể sử dụng các công cụ bằng mã lập trình:

```python
from tools import clone_repo_tool, gitingest_tool, create_container_tool
import asyncio

async def generate_dockerfile(github_url):
    # Sao chép kho lưu trữ
    clone_result = await clone_repo_tool(github_url)
    
    # Phân tích với gitingest
    analysis = await gitingest_tool(clone_result['local_path'])
    
    # Tạo Dockerfile
    dockerfile = await create_container_tool(
        gitingest_summary=analysis['summary'],
        gitingest_tree=analysis['tree'],
        gitingest_content=analysis['content']
    )
    
    return dockerfile

# Sử dụng
result = asyncio.run(generate_dockerfile("https://github.com/user/repo"))
print(result['dockerfile'])
```

## 🎨 Tùy biến

### Thêm Hướng Dẫn Tùy Chỉnh

Sử dụng tính năng "Additional instructions" để tùy chỉnh quá trình tạo:

- `"Sử dụng Alpine Linux để giảm kích thước image"`
- `"Bao gồm Redis và PostgreSQL"`
- `"Tối ưu hóa cho triển khai môi trường sản xuất"`
- `"Thêm các công cụ phát triển để gỡ lỗi"`

## 📝 Giấy phép

Dự án này được cấp phép theo MIT License - xem tệp [LICENSE](LICENSE) để biết chi tiết.

## 🙏 Lời cảm ơn

- **[OpenAI](https://openai.com/)** đã cung cấp API GPT-4
- **[gitingest](https://github.com/cyclotruc/gitingest)** cho khả năng phân tích kho lưu trữ
- **[FastAPI](https://fastapi.tiangolo.com/)** cho framework web xuất sắc
- **[Monaco Editor](https://microsoft.github.io/monaco-editor/)** cho tính năng tô màu cú pháp mã nguồn

## 🔗 Liên kết

- **Kho lưu trữ GitHub**: [https://github.com/cyclotruc/gitcontainer](https://github.com/cyclotruc/gitcontainer)
- **Demo**: Dùng thử trực tiếp với các kho lưu trữ mẫu
- **Vấn đề**: [Báo lỗi hoặc yêu cầu tính năng](https://github.com/cyclotruc/gitcontainer/issues)

---

**Được tạo với ❤️ bởi [Romain Courtois](https://github.com/cyclotruc)**

*Biến bất kỳ kho lưu trữ nào thành container chỉ trong vài giây!*

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---