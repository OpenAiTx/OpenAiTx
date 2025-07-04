# SparkyFitness - Giải pháp tự lưu trữ thay thế MyFitnessPal

SparkyFitness là một ứng dụng quản lý và theo dõi thể hình toàn diện được thiết kế để giúp người dùng giám sát dinh dưỡng, tập luyện và các chỉ số cơ thể. Ứng dụng cung cấp các công cụ theo dõi tiến trình hàng ngày, thiết lập mục tiêu và báo cáo chuyên sâu nhằm hỗ trợ lối sống lành mạnh.


## ✨ Tính năng

### 🍎 Theo dõi Dinh dưỡng

* **Ghi lại bữa ăn hàng ngày**
* **Tạo và quản lý thực phẩm tùy chỉnh và danh mục**
* **Xem tổng quan và phân tích xu hướng với biểu đồ tương tác**

### 💪 Ghi chú Tập luyện

* **Ghi lại các buổi tập**
* **Duyệt và tìm kiếm cơ sở dữ liệu bài tập toàn diện**
* **Theo dõi tiến trình thể hình theo thời gian**

### 💧 Theo dõi Lượng nước

* **Theo dõi mục tiêu uống nước hàng ngày**
* **Ghi chú lượng nước nhanh chóng, đơn giản**

### 📏 Chỉ số Cơ thể

* **Ghi lại các chỉ số cơ thể** (ví dụ: cân nặng, vòng eo, bắp tay)
* **Thêm loại chỉ số tùy chỉnh**
* **Hình dung tiến trình qua biểu đồ**

### 🎯 Thiết lập Mục tiêu

* **Thiết lập và quản lý mục tiêu dinh dưỡng, thể hình**
* **Theo dõi tiến trình theo thời gian**

### 🗓️ Điểm danh Hàng ngày

* **Theo dõi hoạt động hàng ngày**
* **Giữ thói quen với công cụ theo dõi thói quen**

### 🤖 Huấn luyện viên Dinh dưỡng AI (SparkyAI)

* **Ghi chú thực phẩm, tập luyện, chỉ số cơ thể, và số bước qua trò chuyện**
* **Tải ảnh món ăn để tự động ghi nhận bữa ăn**
* **Bao gồm lịch sử trò chuyện và hướng dẫn cá nhân hóa**

### 🔒 Xác thực & Hồ sơ Người dùng

* **Hệ thống đăng nhập an toàn**
* **Chuyển đổi giữa các hồ sơ người dùng**
* **Hỗ trợ quản lý và truy cập cho gia đình**

### 📊 Báo cáo Toàn diện

* **Tạo báo cáo tổng hợp về dinh dưỡng và chỉ số cơ thể**
* **Theo dõi xu hướng dài hạn qua tuần hoặc tháng**

### 🎨 Chủ đề Tùy chỉnh

* **Chuyển đổi giữa chế độ sáng và tối**
* **Thiết kế giao diện tối giản, không gây xao nhãng**

### Cần hỗ trợ?
* **Tham gia discord**
  https://discord.gg/vcnMT5cPEA
* **Đăng bài thảo luận**


![image](https://github.com/user-attachments/assets/ccc7f34e-a663-405f-a4d4-a9888c3197bc)


## 🚀 Bắt đầu

Để chạy ứng dụng SparkyFitness trên máy tính cá nhân, hãy làm theo các bước sau:

### Yêu cầu cần thiết

*   **Dự án Supabase**: Bạn cần thiết lập một dự án Supabase.
    *   **Tạo một dự án mới trên Supabase**: Truy cập [Supabase](https://app.supabase.com/) và tạo dự án mới. (Bạn cũng có thể thử thiết lập Supabase cục bộ nếu muốn.)
    *   Lấy URL Dự án Supabase và Anon Key từ phần cài đặt dự án (mục API).
    *   **Lưu ý quan trọng về xác thực Supabase:** Cập nhật cấu hình URL trong phần xác thực Supabase để khớp với tên miền của bạn. Điều này rất quan trọng để tên miền hoạt động và nhận được email mời đăng ký. Supabase cung cấp nhiều tính năng bảo mật và SSO bên thứ ba; hãy cấu hình theo nhu cầu dự án của bạn.
    *   Tự động triển khai cơ sở dữ liệu lên Supabase sẽ không hoạt động với IPV4 nếu bạn dùng phiên bản miễn phí của Supabase. Vì vậy, bạn cần cấu hình mạng sử dụng kết nối IPV6. Nếu không, quá trình di chuyển cơ sở dữ liệu sẽ thất bại và bạn phải triển khai thủ công.       


    

### Cài đặt

1.  **Cấu hình biến môi trường:**
    Tạo tệp `.env` trong thư mục private. Nếu bạn sử dụng Portainer, hãy tạo trực tiếp tại đó.
    Thêm thông tin Supabase của bạn:
    ```
    VITE_SUPABASE_URL="YOUR_SUPABASE_PROJECT_URL"
    VITE_SUPABASE_ANON_KEY="YOUR_SUPABASE_ANON_KEY"
    SUPABASE_PROJECT_REF="YOUR_SUPABASE_PROJECT_REF"    
    ```

2.  **Chạy với Docker Compose:**
    Kéo các Docker image và khởi động các dịch vụ:
    ```sh
```markdown
    docker compose pull
    docker compose up -d
    ```

3.  **Truy cập Ứng dụng:**
    Sau khi các dịch vụ đã khởi động, truy cập SparkyFitness trên trình duyệt web tại:
    ```
    http://localhost:3000
    ```

4.  **Cấu hình Tuỳ chọn cho AI Chatbot:**
    Để bật đầy đủ chức năng của AI Chatbot, bao gồm lưu trữ khóa API an toàn và truy cập cơ sở dữ liệu, hãy làm theo các bước sau:

    *   **Cấu hình `AI_API_ENCRYPTION_KEY`:** Tạo một secret trong "Supabase -> Edge Functions" -> "Environment Variables". Khóa này dùng để mã hóa các khóa AI của bạn khi lưu trữ trong Supabase.

    *   **Tạo `SUPABASE_ACCESS_TOKEN`:**
        1.  Truy cập vào bảng điều khiển Docker của bạn.
        2.  Chạy `supabase login` và xác thực bằng URL được cung cấp.
        3.  Lấy access token bằng cách chạy `cat ~/.supabase/access-token`.
        4.  Cập nhật tệp `docker-compose.yml` hoặc cấu hình Portainer với token này để triển khai lại.
        5.  Sau khi triển khai lại, đăng nhập vào SparkyFitness và cấu hình dịch vụ AI với nhà cung cấp bạn muốn.
     

### Triển khai Thủ công DB & Functions lên Supabase
**Phương pháp 1:  
**Nếu bạn chưa bật kết nối mạng IPV6, việc di chuyển DB sẽ thất bại vì phiên bản miễn phí của Supabase không hỗ trợ kết nối trực tiếp IPV4.

   1. Tải xuống bản phát hành mới nhất và giải nén vào máy tính của bạn.
   2. Di chuyển tới thư mục dự án. Docker cần phải được khởi động sẵn.
   3. Chạy các lệnh bên dưới. (Triển khai functions chỉ cần thiết cho cấu hình AI. Nếu bạn không dùng ChatBOT, có thể bỏ qua bước này)
``
      supabase login  
      supabase link  
      supabase db push  
      supabase functions deploy chat   
``
Chạy lại Docker compose. Ứng dụng giao diện sẽ bắt đầu hoạt động.

**Phương pháp 2:  
   1. Tải xuống bản phát hành mới nhất và giải nén vào máy tính của bạn.  
   2. Di chuyển tới thư mục dự án.  
   3. Truy cập vào supabase/migrations. Sao chép các câu lệnh SQL và chạy từng câu một trong Supabase-->Project-->SQL Editor theo thứ tự tăng dần ASC.  
   4. [Tuỳ chọn] Làm tương tự với supabase/functions/chat nếu bạn cần AI ChatBOT. Sao chép file index.js và chạy nó trong Supabase-->Project-->Edge Function-->Deploy new function.  
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---