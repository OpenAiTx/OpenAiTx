# Spegel – Phản chiếu web qua AI

Tự động viết lại các trang web thành markdown tối ưu để xem trên terminal.
Đọc bài viết giới thiệu [tại đây](https://simedw.com/2025/06/23/introducing-spegel/)

Đây là một bằng chứng ý tưởng, có thể sẽ gặp lỗi nhưng bạn cứ thoải mái tạo issue hoặc pull request.

##  Ảnh chụp màn hình
Đôi khi bạn không muốn đọc qua cả câu chuyện đời người chỉ để lấy được công thức nấu ăn
![Ví dụ công thức](https://simedw.com/2025/06/23/introducing-spegel/images/recipe_example.png)


## Cài đặt

Yêu cầu Python 3.11+

```
pip install spegel
```
hoặc clone repo và cài đặt ở chế độ chỉnh sửa

```bash
# Clone và vào thư mục
$ git clone <repo-url>
$ cd spegel

# Cài đặt phụ thuộc và CLI
$ pip install -e .
```

## API Keys
Hiện tại Spegel chỉ hỗ trợ Gemini 2.5 Flash, để sử dụng bạn cần cung cấp API key trong biến môi trường

```
GEMINI_API_KEY=...
```


## Sử dụng

### Khởi chạy trình duyệt

```bash
spegel                # Bắt đầu với màn hình chào mừng
spegel bbc.com        # Mở URL ngay lập tức
```

Hoặc, tương đương:

```bash
python -m spegel      # Bắt đầu với màn hình chào mừng
python -m spegel bbc.com
```

### Điều khiển cơ bản
- `/`         – Mở nhập URL
- `Tab`/`Shift+Tab` – Chuyển liên kết
- `Enter`     – Mở liên kết được chọn
- `e`         – Chỉnh prompt LLM cho giao diện hiện tại
- `b`         – Quay lại
- `q`         – Thoát

## Chỉnh sửa cài đặt

Spegel tải các cài đặt từ file cấu hình TOML. Bạn có thể tùy chỉnh giao diện, prompt, và các tuỳ chọn UI.

**Thứ tự tìm kiếm file cấu hình:**
1. `./.spegel.toml` (thư mục hiện tại)
2. `~/.spegel.toml`
3. `~/.config/spegel/config.toml`

Để chỉnh sửa cài đặt:
1. Sao chép file cấu hình ví dụ:
   ```bash
   cp example_config.toml .spegel.toml
   # hoặc tạo ~/.spegel.toml
   ```
2. Chỉnh sửa `.spegel.toml` trong trình soạn thảo yêu thích của bạn.

Ví dụ đoạn cấu hình:
```toml
[settings]
default_view = "terminal"
app_title = "Spegel"

[[views]]
id = "raw"
name = "Raw View"
prompt = ""

[[views]]
id = "terminal"
name = "Terminal"
prompt = "Chuyển đổi trang web này thành trải nghiệm duyệt web hoàn hảo trên terminal! ..."
```

---

Để biết thêm, hãy xem mã nguồn hoặc tạo issue!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---