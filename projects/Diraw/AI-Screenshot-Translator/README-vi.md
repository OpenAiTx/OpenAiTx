# AI Công Cụ Dịch Ảnh Chụp Màn Hình (AI Screenshot Translator)

[![Python Version](https://img.shields.io/badge/python-3.8+-blue.svg)](https://www.python.org/downloads/) [![Nuitka](https://img.shields.io/badge/Nuitka-Compiled-purple)](https://nuitka.net/) [![Release Version](https://img.shields.io/badge/Release-v0.3.4-red)](https://github.com/Diraw/AI-Screenshot-Translator/releases/tag/v0.3.4-test)

# Giới thiệu

Công cụ này thông qua **thao tác chụp màn hình đơn giản**, gửi ảnh tới mô hình AI để nhận diện và dịch văn bản, đồng thời hiển thị kết quả dịch bằng định dạng HTML có thể tương tác trong một cửa sổ độc lập.

Công cụ hỗ trợ **tuỳ chỉnh phím tắt khởi động, quản lý kết quả đa cửa sổ cũng như chạy ở khay hệ thống**, giúp nâng cao hiệu quả dịch thuật trong công việc và học tập hàng ngày.

**Đặc điểm công cụ**: 1. Dịch qua ảnh chụp màn hình, khởi động bằng phím tắt; 2. Ảnh dịch dạng dán, có thể kéo, thu phóng tự do, tạo nhiều nhóm ảnh dịch; 3. Công thức có thể chuyển đổi sang văn bản gốc dễ dàng sao chép; 4. Tuỳ chỉnh API

**Vấn đề muốn giải quyết**: 1. Các công cụ dịch toàn bộ tài liệu trên thị trường hiện tại quá cồng kềnh; 2. Nếu chọn sao chép và dịch từ pdf, đôi khi các khối công thức bị lỗi hoặc không thể sao chép; 3. Đối với pdf quét ảnh, không thể sao chép văn bản

# Demo

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/0.1.gif" alt="" width="100%">

# Hiển thị cửa sổ

Cửa sổ dịch:

<img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v0.2.1.svg" alt="" width="100%">

Cửa sổ cấu hình:

<table>
  <tr>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.1.png" /></td>
    <td><img src="https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/img/v3.0.0_2.png" /></td>
  </tr>
</table>

Giới thiệu chi tiết hơn về các tuỳ chọn cấu hình có thể xem trong phần mềm hoặc xem trên web tại [提示](https://raw.githubusercontent.com/Diraw/AI-Screenshot-Translator/main/doc/hint.md)

# Cài đặt

Bạn có thể tải về mã nguồn để chạy, hoặc truy cập [Releases](https://github.com/Diraw/AI-Screenshot-Translator/releases) để tải tập tin thực thi

### 1. Clone kho mã

```bash
git clone https://github.com/Diraw/AI-Screenshot-Translator.git
cd AI-Screenshot-Translator/src
```

### 2. Tạo môi trường ảo và chạy

```bash
conda create -n AI-Translator python=3.8
conda activate AI-Translator
pip install -r requirements.txt
python main.py
```

# Kế hoạch cập nhật

- ~~Thêm cửa sổ cấu hình api, tối ưu hoá việc cấu hình file yaml thủ công thành tự động sinh bởi phần mềm (đã hoàn thành v0.3.0)~~
- Thêm hệ thống lưu trữ ảnh và công thức, tiện cho việc truy xuất sau này (dự kiến hoàn thành v0.4)
- (Mọi tính năng khác, hoan nghênh gửi issue hoặc đóng góp PR)

# Khác

- Biểu tượng phần mềm lấy từ [iconfinder](https://www.iconfinder.com/search?q=screenshot&price=free)
- Cảm ơn Gemini 2.5 Flash và DeepSeek-V3-0324 đã giúp tìm lỗi

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---