# VANB (Video Audio Network Bridge)
# VANB (Video Assistant NDI Bridge)
# VANB (哇!! NB)

VANB là một công cụ chuyển đổi luồng video/âm thanh dựa trên GStreamer, hỗ trợ chuyển đổi hai chiều giữa giao thức NDI và RTMP. Nó cho phép đưa nguồn NDI lên máy chủ RTMP, hoặc chuyển đổi luồng RTMP thành đầu ra NDI.

Dự án này được phát hành mã nguồn mở theo giấy phép [GPL-3.0](https://www.gnu.org/licenses/gpl-3.0.html).

## Nền tảng hỗ trợ

Hiện tại chủ yếu hỗ trợ các nền tảng sau:
- macOS (Apple Silicon)

## Yêu cầu môi trường

### Phụ thuộc hệ thống
- [GStreamer 1.24+](https://gstreamer.freedesktop.org)
- [NewTek NDI SDK](https://www.ndi.tv/sdk/)

### Các bước cài đặt
1. Cài đặt [NewTek NDI SDK](https://www.ndi.tv/sdk/)

2. Cài đặt GStreamer qua Homebrew
```bash
brew install --cask --zap gstreamer-development
```

3. Clone kho dự án
```bash
git clone https://github.com/Ahua9527/VANB.git
cd VANB
```

4. Cài đặt các phụ thuộc Python
```bash
pip install -r requirements.txt
```

5. Cấu hình biến môi trường (tham khảo file .env)
```bash
# Cấu hình đường dẫn NDI SDK
export NDI_SDK_PATH=/Library/NDI SDK for Apple
# Cấu hình đường dẫn plugin GStreamer
export GST_PLUGIN_PATH=/opt/homebrew/lib/gstreamer-1.0:${NDI_SDK_PATH}/lib/macOS
export DYLD_LIBRARY_PATH=/opt/homebrew/lib:${NDI_SDK_PATH}/lib/macOS
export GI_TYPELIB_PATH=/opt/homebrew/lib/girepository-1.0:/usr/local/lib/girepository-1.0
```

## Cách sử dụng

### NDI sang RTMP (gửi đi)
```bash
python vanb_tx.py
```
Chương trình sẽ tự động quét các nguồn NDI khả dụng, và nhắc nhập địa chỉ RTMP để đẩy luồng.

### RTMP sang NDI (nhận về)
```bash
python vanb_rx.py
```
Nhập địa chỉ RTMP để lấy luồng, chương trình sẽ tự động tạo một đầu ra NDI mới.

## Trạng thái phát triển

### Tính năng đã hoàn thành
- ✓ Chuyển đổi từ NDI sang RTMP
- ✓ Chuyển đổi từ RTMP sang NDI
- ✓ Tự động thích nghi tốc độ khung hình và độ phân giải
- ✓ Đồng bộ hóa âm thanh và hình ảnh
- ✓ Tự động quét nguồn NDI
- ✓ Tự động đặt tên đầu ra NDI
- ✓ Mã hóa/giải mã phần cứng VideoToolbox

### Tính năng đang phát triển
- ⨯ Hỗ trợ file cấu hình (Profile/config.json)
  - Điều khiển tham số đầu vào/đầu ra qua file cấu hình
  - Hỗ trợ nhiều cấu hình preset chuyển mã
  - Cấu hình kích thước bộ đệm và độ trễ
  - Hỗ trợ cân bằng chất lượng và hiệu năng chuyển mã
- ⨯ Xử lý đồng thời nhiều luồng

## Tuyên bố về giấy phép

⚠️ **Lưu ý quan trọng: Giấy phép & Tuân thủ**

### Giấy phép phần mềm

Dự án này sử dụng giấy phép [GNU General Public License v3.0](https://www.gnu.org/licenses/gpl-3.0.html).

Lý do chọn GPL-3.0:
1. Dự án sử dụng nhiều plugin GStreamer theo giấy phép GPL:
   - `x264`: Bộ mã hóa video H.264 (GPL)
   - `x265`: Bộ mã hóa video HEVC/H.265 (GPL)
   - `faad`: Bộ giải mã âm thanh AAC (GPL)
2. Theo điều khoản truyền nhiễm của GPL, phần mềm sử dụng thành phần GPL cũng phải tuân theo giấy phép GPL
3. Chọn GPL-3.0 đảm bảo tương thích với tất cả các giấy phép phụ thuộc

### Yêu cầu về giấy phép

Khi sử dụng dự án này, bạn phải tuân thủ các yêu cầu sau:
1. **Mã nguồn mở**: Nếu bạn sửa đổi mã nguồn hoặc tích hợp vào dự án của bạn, phải mở toàn bộ mã nguồn của bạn
2. **Giữ nguyên giấy phép**: Dự án của bạn phải tiếp tục sử dụng giấy phép GPL-3.0
3. **Giữ nguyên tuyên bố bản quyền**: Bạn phải giữ lại tuyên bố bản quyền và giấy phép gốc
4. **Ghi chú rõ ràng**: Nếu bạn sửa đổi mã, phải ghi chú rõ những thay đổi của bạn
5. **Cấp phép bằng sáng chế**: GPL-3.0 bao gồm điều khoản cấp phép bằng sáng chế rõ ràng

### Giấy phép thành phần GStreamer
1. Dự án này chỉ sử dụng cho mục đích phát triển và thử nghiệm
2. NDI® là nhãn hiệu đã đăng ký của NewTek, Inc.
3. Sử dụng dự án này cần tuân thủ thỏa thuận cấp phép NewTek NDI® SDK
4. Trước khi sử dụng trong môi trường sản xuất, đảm bảo bạn đã có đầy đủ giấy phép và quyền sử dụng cần thiết

## Phản hồi vấn đề

Nếu gặp sự cố, vui lòng:
1. Kiểm tra xem đã cấu hình đúng biến môi trường chưa
2. Xác nhận plugin GStreamer đã được cài đặt đầy đủ chưa
3. Xem thông tin lỗi chi tiết trong file log
4. Gửi vấn đề qua Issues, kèm theo log và thông tin môi trường

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---