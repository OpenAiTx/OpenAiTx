# Git Smart Squash

Ngừng lãng phí thời gian sắp xếp lại các commit thủ công. Hãy để AI làm điều đó cho bạn.

## Vấn Đề

Bạn đã từng ở đó: 15 commit cho một tính năng, một nửa trong số đó là "fix", "typo" hoặc "WIP". Bây giờ bạn cần dọn dẹp lại để gửi PR review. Việc squash và chỉnh sửa thủ công thật tẻ nhạt.

## Giải Pháp

Git Smart Squash phân tích các thay đổi của bạn và sắp xếp lại chúng thành các commit hợp lý với thông điệp rõ ràng:

```bash
# Trước: nhánh lộn xộn của bạn
* fix tests
* typo  
* more auth changes
* WIP: working on auth
* update tests
* initial auth implementation

# Sau: các commit sạch sẽ, hợp lý
* feat: triển khai hệ thống xác thực JWT
* test: thêm kiểm thử cho endpoint xác thực
```

## Bắt đầu nhanh

### 1. Cài đặt

```bash
# Sử dụng pip
pip install git-smart-squash

# Sử dụng pipx (khuyến nghị để cài đặt cách ly)
pipx install git-smart-squash

# Sử dụng uv (trình quản lý gói Python nhanh)
uv tool install git-smart-squash
```
### 2. Thiết lập AI

**Lựa chọn A: Cục bộ (Miễn phí, Riêng tư)**
```bash
# Cài đặt Ollama từ https://ollama.com
ollama pull devstral  # Mô hình mặc định
```

**Lựa chọn B: Đám mây (Kết quả tốt hơn)**
```bash
export OPENAI_API_KEY="your-key"
export ANTHROPIC_API_KEY="your-key"
export GEMINI_API_KEY="your-key"
```

### 3. Chạy

```bash
cd your-repo
git-smart-squash
```
Vậy là xong. Xem lại kế hoạch và phê duyệt.

## Tham Số Dòng Lệnh

| Tham số | Mô tả | Mặc định |
|---------|-------|----------|
| `--base` | Nhánh cơ sở để so sánh | Tệp cấu hình hoặc `main` |
| `--ai-provider` | Nhà cung cấp AI để sử dụng (openai, anthropic, local, gemini) | Được cấu hình trong cài đặt |
| `--model` | Mô hình AI cụ thể để sử dụng (xem các mô hình đề xuất bên dưới) | Mặc định nhà cung cấp |
| `--config` | Đường dẫn tới tệp cấu hình tùy chỉnh | `.git-smart-squash.yml` hoặc `~/.git-smart-squash.yml` |
| `--auto-apply` | Áp dụng kế hoạch commit mà không cần xác nhận | `false` |
| `--instructions`, `-i` | Hướng dẫn tùy chỉnh cho AI (ví dụ: "Nhóm theo khu vực tính năng") | Không có |
| `--no-attribution` | Tắt thông báo ghi nhận trong commit | `false` |
| `--debug` | Bật ghi log gỡ lỗi để có thông tin chi tiết | `false` |

## Các Mô Hình Đề Xuất

### Mô Hình Mặc Định
- **OpenAI**: `gpt-4.1` (mặc định)
- **Anthropic**: `claude-sonnet-4-20250514` (mặc định)
- **Gemini**: `gemini-2.5-pro` (mặc định)
- **Local/Ollama**: `devstral` (mặc định)
### Lựa chọn Mô hình
```bash
# Chỉ định một mô hình khác
git-smart-squash --ai-provider openai --model gpt-4.1-mini

# Đối với Ollama cục bộ
git-smart-squash --ai-provider local --model llama-3.1
```

## Hướng dẫn Tùy chỉnh

Tham số `--instructions` cho phép bạn kiểm soát cách các commit được tổ chức:

### Ví dụ
```bash
# Thêm tiền tố mã ticket
git-smart-squash -i "Prefix all commits with [ABC-1234]"

# Tách biệt theo loại
git-smart-squash -i "Keep backend and frontend changes in separate commits"
```
# Giới hạn số lượng commit
git-smart-squash -i "Tạo tối đa 3 commit tổng cộng"
```

### Mẹo để đạt kết quả tốt hơn
- **Hãy cụ thể**: "Nhóm các migration cơ sở dữ liệu riêng biệt" sẽ hiệu quả hơn "sắp xếp hợp lý"
- **Chỉ một hướng dẫn mỗi lần**: Hướng dẫn phức tạp nhiều phần có thể bị bỏ qua một phần
- **Sử dụng mô hình tốt hơn**: Các mô hình lớn tuân thủ hướng dẫn đáng tin cậy hơn các mô hình nhỏ

## Các trường hợp sử dụng phổ biến

### "Tôi cần dọn dẹp trước khi review PR"
```bash
git-smart-squash              # Hiển thị kế hoạch và yêu cầu xác nhận
git-smart-squash --auto-apply # Tự động áp dụng mà không cần xác nhận
```

### "Tôi làm việc với nhánh chính khác"
```bash
git-smart-squash --base develop
```
### "Tôi muốn sử dụng một nhà cung cấp AI cụ thể"
```bash
git-smart-squash --ai-provider openai
```

## An toàn

**Mã nguồn của bạn được an toàn:**
- Hiển thị kế hoạch trước khi thực hiện thay đổi
- Tạo nhánh sao lưu tự động
- Yêu cầu thư mục làm việc sạch
- Không bao giờ đẩy lên mà không có lệnh của bạn

**Nếu có sự cố xảy ra:**
```bash
# Tìm bản sao lưu
git branch | grep backup

# Khôi phục
git reset --hard your-branch-backup-[timestamp]
```

## Các nhà cung cấp AI

| Nhà cung cấp | Chi phí | Quyền riêng tư |
|--------------|---------|----------------|
| **Ollama**   | Miễn phí | Cục bộ         |
| **OpenAI**   | ~0,01 USD | Đám mây      |
| **Anthropic**| ~0,01 USD | Đám mây      |
| **Gemini**   | ~0,01 USD | Đám mây      |

## Cấu hình nâng cao (Tùy chọn)

Muốn tùy chỉnh? Tạo một tệp cấu hình:

**Dành riêng cho dự án** (`.git-smart-squash.yml` trong kho của bạn):
```yaml
ai:
  provider: openai  # Sử dụng OpenAI cho dự án này
base: develop       # Sử dụng develop làm nhánh cơ sở cho dự án này
```
**Mặc định toàn cục** (`~/.git-smart-squash.yml`):
```yaml
ai:
  provider: local   # Luôn sử dụng AI cục bộ theo mặc định
base: main          # Nhánh cơ sở mặc định cho tất cả dự án
```

## Xử lý sự cố

### Lỗi "Invalid JSON"
Điều này thường có nghĩa là mô hình AI không thể định dạng phản hồi đúng:
- **Với Ollama**: Chuyển từ `llama2` sang `mistral` hoặc `mixtral`
- **Giải pháp**: `ollama pull mistral` rồi thử lại
- **Thay thế**: Sử dụng nhà cung cấp đám mây với `--ai-provider openai`

### Mô hình không làm theo hướng dẫn
Một số mô hình gặp khó khăn với hướng dẫn phức tạp:
- **Dùng mô hình tốt hơn**: `--model gpt-4-turbo` hoặc `--model claude-3-opus`
- **Đơn giản hóa hướng dẫn**: Một chỉ thị rõ ràng sẽ hiệu quả hơn nhiều chỉ thị
- **Hãy rõ ràng**: "Thêm tiền tố [ABC-123]" chứ không phải "thêm số ticket"
### "Không tìm thấy Ollama"
```bash
# Cài đặt từ https://ollama.com
ollama serve
ollama pull devstral  # Mô hình mặc định
```

### Nhóm Commit Kém
Nếu AI tạo quá nhiều commit hoặc không nhóm tốt:
- **Mô hình không đủ mạnh**: Sử dụng mô hình lớn hơn
- **Thêm hướng dẫn**: `-i "Nhóm các thay đổi liên quan, tối đa 3 commit"`
- **Cung cấp phản hồi**: Tạo một issue trên GitHub và cho chúng tôi biết điều gì đã xảy ra

### Vấn Đề Cài Đặt (Mac)
Nếu bạn không có pip hoặc muốn cài đặt cách ly:
```bash
# Sử dụng pipx (khuyến nghị)
brew install pipx
pipx install git-smart-squash
```
### "Không có thay đổi để tổ chức lại"
```bash
git log --oneline main..HEAD  # Kiểm tra bạn có các commit
git diff main                 # Kiểm tra bạn có thay đổi
```

### Diff lớn / Giới hạn token
Các mô hình cục bộ có giới hạn ~32k token. Đối với thay đổi lớn:
- Sử dụng `--base` với một commit gần đây hơn
- Chuyển sang cloud: `--ai-provider openai`
- Chia thành các PR nhỏ hơn

### Cần thêm trợ giúp?

Xem [tài liệu chi tiết](https://raw.githubusercontent.com/edverma/git-smart-squash/main/DOCUMENTATION.md) của chúng tôi hoặc mở một issue!

## Giấy phép

Giấy phép MIT - xem tệp [LICENSE](LICENSE) để biết chi tiết.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-12

---