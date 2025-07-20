<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=qOeOp&project=XianyuAutoAgent&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# 🚀 Xianyu AutoAgent - Hệ thống robot chăm sóc khách hàng thông minh cho nền tảng Xianyu

[![Java Version](https://img.shields.io/badge/java21%2B-blue)](https://www.python.org/) [![LLM Powered](https://img.shields.io/badge/LLM-powered-FF6F61)](https://platform.openai.com/)

Giải pháp AI trực 24/7 thiết kế riêng cho nền tảng Xianyu, hỗ trợ tự động hóa trực nền tảng 7×24 giờ, cho phép phối hợp nhiều chuyên gia quyết định, đàm phán giá thông minh và đối thoại nhận biết ngữ cảnh.

## 🎮 Playground - Trải nghiệm nhanh (không cần cấu hình)

Không cần môi trường cục bộ hay thiết lập Secrets! **Truyền tham số trực tiếp qua trang web GitHub Actions** để khởi động robot Xianyu chỉ với một cú nhấp.

### Cách sử dụng
1. **Fork kho lưu trữ này** → Nhấp vào nút `Fork` ở góc trên bên phải
2. **Kích hoạt Action**:
   - Vào tab `Actions` trong kho của bạn
   - Chọn quy trình làm việc **`🚀 Run Service`**
   - Nhấp vào nút **`Run workflow`**, điền các tham số:
      - `API Key`: Dán API Key của mô hình lớn (ví dụ: Aliyun DashScope)
      - `Cookies`: Dán chuỗi Cookie đầy đủ từ phiên bản web của Xianyu
3. **Xem nhật ký chạy**:
   - Sau khi robot khởi động sẽ tự động lắng nghe tin nhắn Xianyu
   - Tìm kiếm `🤖 Reply:` trong nhật ký Action để xem lịch sử đối thoại

### Lưu ý
⚠️ Hạn chế khi chạy tạm thời:
- Mặc định chạy **30 phút** (giới hạn tài khoản miễn phí GitHub)
- Thông tin nhạy cảm (như Cookie) **không lưu trữ**, chỉ có hiệu lực cho lần chạy đó

<div align="center">
  <img src="https://raw.githubusercontent.com/qOeOp/XianyuAutoAgent/main/./screenshots/workflow.png" width="400px" alt="workflow">
</div>

## 🌟 Tính năng cốt lõi

### Động cơ đối thoại thông minh
| Mô-đun chức năng | Công nghệ thực hiện      | Đặc điểm chính                                               |
| ---------------- | ---------------------- | ------------------------------------------------------------ |
| Nhận biết ngữ cảnh| Lưu trữ lịch sử hội thoại| Quản lý trí nhớ đối thoại nhẹ, lịch sử đầy đủ làm đầu vào ngữ cảnh cho LLM|
| Định tuyến chuyên gia | LLM prompt + định tuyến theo quy tắc | Nhận diện ý định dựa trên prompt → Phân phối động cho Agent chuyên gia, hỗ trợ chuyển đổi đa tình huống như đàm phán giá/kỹ thuật/chăm sóc khách hàng |

### Ma trận chức năng nghiệp vụ
| Mô-đun   | Đã thực hiện                  | Đang lên kế hoạch             |
| -------- | ---------------------------- | ----------------------- |
| Động cơ cốt lõi | ✅ Trả lời tự động bằng LLM<br>✅ Quản lý ngữ cảnh | 🔄 Tăng cường phân tích cảm xúc |
| Hệ thống đàm phán giá | ✅ Chiến lược giảm giá theo bậc | 🔄 So sánh giá thị trường        |
| Hỗ trợ kỹ thuật | ✅ Tích hợp tìm kiếm web         | 🔄 Tăng cường kho kiến thức RAG  |

## 🚴 Bắt đầu nhanh

### Yêu cầu môi trường
- JDK 21+
- Maven 3.9.10+

### Các bước cài đặt

```bash
1. 克隆仓库
git clone https://github.com/qOeOp/XianyuAutoAgent.git
cd XianyuAutoAgent

2. 配置环境变量
- AI_DASHSCOPE_API_KEY : 阿里云大模型API-KEY
- COOKIES_STR : 闲鱼网页端Cookie

3. 执行命令
mvn spring-boot:run
注意：默认使用的模型是通义千问，如需使用其他API，请自行修改application.yml文件中的模型地址和模型名称；
COOKIES_STR自行在闲鱼网页端获取cookies(网页端F12打开控制台，选择Network，点击Fetch/XHR,点击一个请求，查看cookies)

4. (可选)创建提示词文件src/main/resources/*-prompt.txt
```
## 🤝 Tham gia đóng góp

Chào mừng bạn gửi đề xuất thông qua Issue hoặc đóng góp mã bằng PR, vui lòng tuân thủ [Hướng dẫn đóng góp](https://contributing.md/)



## 🛡 Lưu ý

⚠️ Lưu ý: **Dự án này chỉ dành cho mục đích học tập và trao đổi, nếu có vi phạm bản quyền xin liên hệ tác giả để xóa.**

Do tính chất đặc thù của dự án, nhóm phát triển có thể **ngừng cập nhật** hoặc **xóa dự án** vào bất kỳ thời điểm nào.


## 🧸 Đặc biệt cảm ơn

Dự án này được tái cấu trúc dựa trên các dự án mã nguồn mở sau:
- [XianyuAutoAgent](https://github.com/shaxiu/XianyuAutoAgent) - Hệ thống chatbot chăm sóc khách hàng Xianyu thông minh, do [@shaxiu](https://github.com/shaxiu) và [@cv-cat](https://github.com/cv-cat) phát triển


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---