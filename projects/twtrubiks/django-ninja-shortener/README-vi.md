# Django Ninja Shortener - Dịch vụ rút gọn URL như Bitly

Dịch vụ rút gọn URL hiện đại được xây dựng bằng Django, Django Ninja và Tailwind CSS, lấy cảm hứng thiết kế từ Bitly.

Người dùng có thể đăng ký, đăng nhập và rút gọn URL, đồng thời theo dõi số lần nhấp chuột của từng URL rút gọn.

Dự án này sử dụng [Cline](https://github.com/twtrubiks/mcp-vscode-cline?tab=readme-ov-file#cline) để hỗ trợ hoàn thành, tham khảo [.clinerules/01_doc.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/.clinerules/01_doc.md)

## Ảnh màn hình

Trang rút gọn URL (không cần đăng ký cũng dùng được)

![alt tag](https://cdn.imgpile.com/f/qPDKjsy_xl.png)

Nếu đăng ký sẽ có thể theo dõi số lần nhấp

![alt tag](https://cdn.imgpile.com/f/4R3cy01_xl.png)

## ✨ Tính năng nổi bật

* **Xác thực người dùng**: Hỗ trợ đăng ký, đăng nhập, đăng xuất.
* **Tạo URL rút gọn**: Người dùng đăng nhập có thể tạo một URL rút gọn độc nhất từ URL dài.
* **Chuyển hướng URL rút gọn**: Nhấp vào URL rút gọn sẽ chuyển hướng người dùng đến URL gốc.
* **Theo dõi số lần nhấp**: Hệ thống tự động thống kê số lần mỗi URL rút gọn được nhấp.
* **Bảng điều khiển cá nhân**: Người dùng có thể xem tất cả URL rút gọn đã tạo và thống kê lượt nhấp của chúng.
* **RESTful API**: Cung cấp endpoint API để tạo URL rút gọn một cách lập trình.
* **Hỗ trợ Docker**: Cung cấp Dockerfile và cấu hình Docker Compose, đơn giản hóa quy trình phát triển và triển khai.

## 🛠️ Công nghệ sử dụng

* **Framework backend**: [Django](https://github.com/twtrubiks/django-tutorial)
* **Framework API**: [Django Ninja](https://github.com/twtrubiks/django_ninja_tutorial)
* **Giao diện frontend**: [Tailwind CSS](https://tailwindcss.com/) (tích hợp qua `django-tailwind`)
* **Cơ sở dữ liệu**:
  * Môi trường phát triển: SQLite (mặc định)
  * Môi trường sản xuất: Dễ dàng chuyển sang PostgreSQL (đã có sẵn cấu hình trong `settings.py`)
* **Mã hóa URL rút gọn**: Sử dụng `shortuuid`
* **Kiểm thử**: [Pytest](https://github.com/twtrubiks/django_pytest_tutorial)
* **Container hóa**: [Docker](https://github.com/twtrubiks/docker-tutorial)

## 🚀 Khởi động nhanh (Sử dụng Docker, nên dùng cách này)

Đây là cách khởi động được khuyến nghị nhất, đảm bảo sự nhất quán của môi trường phát triển.

**Các bước khởi động:**

1. **Khởi động dịch vụ:**

    Sử dụng Docker Compose để khởi động tất cả dịch vụ chỉ với một lệnh.

    ```bash
    docker compose up --build
    ```

    Lệnh này sẽ tạo image Docker, cài đặt phụ thuộc, thực hiện migrate cơ sở dữ liệu và khởi động server phát triển.

2. **Tạo siêu người dùng (tùy chọn):**

    Nếu muốn truy cập Django Admin, hãy chạy lệnh sau ở một cửa sổ terminal khác:

    ```bash
    docker compose exec django-ninja python manage.py createsuperuser
    ```

3. **Truy cập ứng dụng:**

    * **Trang chủ web**: [http://localhost:8000](http://localhost:8000)

    * **Tài liệu API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🔧 Phát triển cục bộ (Không dùng Docker)

Nếu bạn thích tự thiết lập môi trường trên máy tính cá nhân.

**Yêu cầu trước:**

* Python 3.12
* Node.js và npm (dùng cho Tailwind CSS)

**Các bước thiết lập:**

1. **Tạo và kích hoạt môi trường ảo:**

    ```bash
    python -m venv venv
    source venv/bin/activate  # Trên Windows dùng `venv\Scripts\activate`
    ```

2. **Cài đặt phụ thuộc Python:**

    ```bash
    pip install -r requirements.txt
    ```

3. **Cài đặt và cấu hình Tailwind CSS:**

    `django-tailwind` sẽ xử lý phần lớn cấu hình.

    ```bash
    python manage.py tailwind install
    ```

    Tham khảo [https://django-tailwind.readthedocs.io/en/latest/installation.html](https://django-tailwind.readthedocs.io/en/latest/installation.html)

4. **Chạy migrate cơ sở dữ liệu:**

    ```bash
    python manage.py migrate
    ```

5. **Tạo siêu người dùng (tùy chọn):**

    ```bash
    python manage.py createsuperuser
    ```

6. **Khởi động server phát triển:**

    Bạn cần khởi động đồng thời server Django và tiến trình biên dịch Tailwind CSS.

    ```bash
    python manage.py runserver
    ```

    Ở một cửa sổ terminal khác:

    ```bash
    python manage.py tailwind start
    ```

7. **Truy cập ứng dụng:**

    * **Trang chủ web**: [http://localhost:8000](http://localhost:8000)

    * **Tài liệu API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

## 🧪 Chạy kiểm thử

Dự án này sử dụng `pytest` để kiểm thử và đo lường độ bao phủ kiểm thử.

Kế hoạch kiểm thử tham khảo [TESTING_PLAN.md](https://raw.githubusercontent.com/twtrubiks/django-ninja-shortener/main/TESTING_PLAN.md)

* **Chạy kiểm thử bằng Docker:**

    ```bash
    docker compose --profile test up
    ```

    Báo cáo kiểm thử sẽ được tạo ở `htmlcov/index.html`.

* **Chạy kiểm thử cục bộ:**

    ```bash
    # Đảm bảo đã cài đặt các phụ thuộc phát triển
    pytest --cov=. --cov-report=html
    ```

![alt tag](https://cdn.imgpile.com/f/UZnApNQ_xl.png)

## 📄 Các endpoint API

API cung cấp phương thức lập trình để tương tác với dịch vụ rút gọn URL. Tất cả endpoint API nằm dưới đường dẫn `/api/`.

Khuyến khích truy cập trực tiếp **Tài liệu API (Swagger UI)**: [http://localhost:8000/api/docs](http://localhost:8000/api/docs)

![alt tag](https://cdn.imgpile.com/f/Foa4p5C_md.png)

Sử dụng [Ninja JWT](https://github.com/twtrubiks/django_ninja_tutorial/tree/main?tab=readme-ov-file#ninja-jwt), trước tiên gọi `/api/token/pair` với tên người dùng và mật khẩu để lấy token của bạn

![alt tag](https://cdn.imgpile.com/f/84ABFA4_xl.png)

Sau đó dán token lên góc phải, giờ bạn có thể gọi api

![alt tag](https://cdn.imgpile.com/f/aCbUddW_md.png)

## 📂 Cấu trúc dự án

```cmd
ninja_shortener/
├── Dockerfile
├── docker-compose.yml
├── manage.py
├── requirements.txt
├── ninja_shortener/      # Cấu hình dự án Django
│   ├── settings.py
│   └── urls.py
├── shortener/            # Ứng dụng rút gọn URL lõi
│   ├── models.py         # Mô hình cơ sở dữ liệu (Link)
│   ├── api.py            # Endpoint API Django Ninja
│   ├── views.py          # View trang và logic chuyển hướng
│   └── utils.py          # Công cụ tạo mã rút gọn
└── theme/                # Giao diện và template Django
    ├── templates/        # Template HTML
    └── static_src/       # Mã nguồn Tailwind CSS
```

## 💡 Định hướng phát triển

* **Chuyển sang PostgreSQL**: Chuẩn bị cho môi trường sản xuất với cơ sở dữ liệu ổn định hơn. (Đã hoàn thành)
* **Bảng phân tích chi tiết**: Cung cấp thêm nhiều dữ liệu về lượt nhấp như thời gian, nguồn, vị trí địa lý, v.v.
* **Tùy chỉnh liên kết rút gọn**: Cho phép người dùng tùy chỉnh mã của liên kết rút gọn.
* **Tạo mã QR Code**: Tạo mã QR Code tương ứng cho mỗi liên kết rút gọn.
* **Nhiệm vụ bất đồng bộ**: Sử dụng Celery để xử lý các tác vụ tốn thời gian, như phân tích dữ liệu.

## Quyên góp

Tất cả các bài viết đều do tôi tự nghiên cứu và sáng tạo, nếu chúng hữu ích với bạn và bạn muốn động viên tôi, xin mời mua cho tôi một ly cà phê :laughing:

ECPAY của Green World Technology (Không cần đăng ký thành viên)

![alt tag](https://payment.ecpay.com.tw/Upload/QRCode/201906/QRCode_672351b8-5ab3-42dd-9c7c-c24c3e6a10a0.png)

[Thanh toán quyên góp](http://bit.ly/2F7Jrha)

O’Pay (Cần đăng ký thành viên)

![alt tag](https://i.imgur.com/LRct9xa.png)

[Thanh toán quyên góp](https://payment.opay.tw/Broadcaster/Donate/9E47FDEF85ABE383A0F5FC6A218606F8)

## Danh sách nhà tài trợ

[Danh sách nhà tài trợ](https://github.com/twtrubiks/Thank-you-for-donate)

## Giấy phép

Giấy phép MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---