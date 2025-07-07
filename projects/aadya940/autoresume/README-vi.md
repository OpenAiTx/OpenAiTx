<p align="center">
  <img src="https://raw.githubusercontent.com/aadya940/autoresume/main/main_app/frontend/public/autoresume-logo.png" alt="autoResume Logo" title="autoResume Logo" width="180"/>
</p>

<h1 align="center">autoResume</h1>

<p align="center">
  <b>Trình tạo CV mã nguồn mở, dán liên kết của bạn, chỉnh sửa thủ công và để AI hỗ trợ bạn trong việc hoàn thiện, cập nhật và điều chỉnh CV.</b>
</p>

---

### Cách sử dụng?

[Liên kết Blog Medium](https://medium.com/@aadyachinubhai/autoresume-copy-and-paste-links-its-that-simple-8e50e6d155a1)

Blog này đã lỗi thời về giao diện người dùng và mẫu được sử dụng.

## Tính năng

- <b>Nhập liên kết dễ dàng:</b> Dán liên kết từ các trang web và nhanh chóng tạo CV PDF.
- <b>Bao gồm trình chỉnh sửa thủ công:</b> Tinh chỉnh hoặc tạo CV từ đầu với trình chỉnh sửa mã nhúng.
- <b>Gợi ý thông minh:</b> Chia sẻ phản hồi hoặc liên kết mới, smartedits sẽ giúp hoàn thiện và cập nhật CV của bạn.
- <b>Tùy chỉnh cho công việc:</b> Dán mô tả công việc và nhận đề xuất để căn chỉnh CV của bạn.
- <b>Chất lượng LaTeX:</b> Tất cả CV được tạo bằng LaTeX để bố cục sạch sẽ, chuyên nghiệp.
- <b>Xem trước tức thì:</b> Xem CV của bạn dưới dạng PDF theo thời gian thực.
- <b>Đặt lại dễ dàng:</b> Xóa và khởi động lại CV chỉ với một cú nhấp chuột.
- <b>Chạy cục bộ:</b> Ứng dụng chạy hoàn toàn trên máy của bạn bằng Docker.

---

## Bắt đầu

### Yêu cầu cần thiết
- [Docker](https://www.docker.com/get-started)
- [Docker Compose](https://docs.docker.com/compose/)

### Thiết lập

1. Sao chép kho lưu trữ:
   ```bash
   git clone https://github.com/aadya940/autoresume.git
   cd autoresume
   ```
2. Xây dựng và khởi động ứng dụng:
   ```bash
   docker compose up --build
   ```
3. Truy cập ứng dụng:
   
   [_http://localhost:5173_](http://localhost:5173)
---

## Sử dụng

1. Mở autoResume trên trình duyệt của bạn.
2. Nhấp vào biểu tượng :gear:, dán [GOOGLE API KEY](https://aistudio.google.com/) và Email của bạn.
3. Dán các liên kết tới thông tin nghề nghiệp của bạn (ví dụ: Github, trang web cá nhân, v.v.).
4. Tùy chọn, thêm phản hồi hoặc liên kết tin tuyển dụng để tùy chỉnh thêm.
5. Nhấp vào <b>Tạo CV</b> và để AI lo phần còn lại!

---

## Giấy phép

Dự án này được cấp phép theo Giấy phép Apache 2.0.

## Hướng dẫn đóng góp

### Frontend
- Triển khai các thành phần React trong thư mục `frontend/src/components/`
- Chúng tôi sử dụng Chakra UI để xây dựng các thành phần.
- Import và sử dụng thành phần của bạn trong `frontend/src/App.jsx`

### Backend
- Triển khai các route API trong thư mục `backend/src/routes/`
- Thêm chức năng AI trong thư mục `backend/src/ai/`
- Chúng tôi sử dụng bộ định dạng mã `black` cho mã Python
- Giữ các hàm xử lý route sạch sẽ và tách biệt logic

### Hướng dẫn chung
- Tạo nhánh mới cho tính năng/sửa lỗi của bạn: `git checkout -b ten-nhanh-cua-ban`
- Viết thông điệp commit rõ ràng
- Kiểm tra thay đổi của bạn trước khi gửi PR

### Gửi thay đổi
1. Tạo Pull Request
2. Trong mô tả PR của bạn, hãy bao gồm:
   - Những thay đổi bạn đã thực hiện
   - Lý do bạn thực hiện chúng
   - Bất kỳ ảnh chụp màn hình hoặc kết quả kiểm tra liên quan nào
   - Bất kỳ thay đổi phá vỡ hoặc bước di chuyển nào cần thiết

Chúng tôi đánh giá cao các đóng góp của bạn và sẽ xem xét PR của bạn sớm nhất có thể!


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-07

---