![2](https://github.com/user-attachments/assets/a18257a3-a678-4fd4-bf77-750dab4d99bb)

# Agent

Một framework AI agent Python tốc độ cao, tự chủ, tận dụng OpenAI Python SDK để diễn giải các lệnh ngôn ngữ tự nhiên, sinh và thực thi mã động, đồng thời quản lý môi trường chạy thời gian thực mà không gặp trở ngại. Framework này có tính năng cài đặt phụ thuộc tự động, cấu hình môi trường an toàn, ghi log có cấu trúc, và giao diện plugin tối giản để nhúng các công cụ Python mạnh mẽ—tất cả đều dưới giấy phép Apache 2.0 cho phép sử dụng tự do.

## ⭐ Lịch sử Star

<p align="center">
  <a href="https://star-history.com/#machinegpt/agent&Date">
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=machinegpt/agent&type=Date&theme=dark" onerror="this.src='https://api.star-history.com/svg?repos=machinegpt/agent&type=Date'" />
  </a>
</p>


## 🔧 Thiết lập môi trường

### Môi trường ảo Python
Trước khi thiết lập dự án, bạn nên tạo một môi trường ảo. Thực hiện các bước sau:

Tìm hiểu về môi trường ảo: [Python Packaging Guide](https://packaging.python.org/en/latest/guides/installing-using-pip-and-virtual-environments/)

Tạo và kích hoạt môi trường ảo:

**Windows:**

```
py -m venv .venv
.venv\Scripts\activate
```

**macOS/Linux:**
```
python3 -m venv .venv
source .venv/bin/activate
```

### Thiết lập dự án
Dự án này yêu cầu khóa API OpenAI để hoạt động. Để cung cấp, hãy tạo một tệp .env trong thư mục gốc với nội dung sau:
```
OPENAI_API_KEY=
```
Ngoài ra, bạn có thể sao chép tệp .env.example được cung cấp và cập nhật khóa:
```
cp .env.example .env
```

## 🧠 Khởi động
Để bắt đầu agent, chỉ cần chạy:
```
git clone https://github.com/machinegpt/agent.git
cd agent

python machine.py
```

## ✨ Đóng góp

Chào mừng các đóng góp, đề xuất, báo cáo lỗi và sửa lỗi!

Đối với các tính năng, thành phần hoặc phần mở rộng mới, vui lòng mở một issue để thảo luận trước khi gửi PR.

## 💖 Dự án này tồn tại ở trạng thái hiện tại là nhờ tất cả những người đã đóng góp
<a href="https://github.com/machinegpt/agent/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=machinegpt/agent" />
</a>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---