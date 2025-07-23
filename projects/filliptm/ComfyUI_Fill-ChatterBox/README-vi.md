<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=filliptm&project=ComfyUI_Fill-ChatterBox&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# ComfyUI_Fill-ChatterBox

Nếu bạn thích dự án này, hãy cân nhắc ủng hộ tôi trên Patreon!
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

Một tiện ích node tùy chỉnh cho ComfyUI, bổ sung khả năng chuyển văn bản thành giọng nói (TTS) và chuyển đổi giọng nói (VC) sử dụng thư viện Chatterbox.
Hỗ trợ TỐI ĐA 40 giây. Tôi đã thử loại bỏ giới hạn này, nhưng mô hình hoạt động rất tệ với bất cứ thứ gì dài hơn, vì vậy giới hạn này vẫn giữ nguyên.

![ChatterBox Example](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## Cài đặt

1. Sao chép kho lưu trữ này vào thư mục custom_nodes của ComfyUI:

   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. Cài đặt các phụ thuộc cơ bản:

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3. (Tùy chọn) Cài đặt hỗ trợ đóng dấu mờ:

   ```bash
   pip install resemble-perth
   ```
**Lưu ý**: Gói `resemble-perth` có thể gặp vấn đề tương thích với Python 3.12+. Nếu bạn gặp lỗi import, các node vẫn sẽ hoạt động mà không có watermark.


## Sử dụng

### Node Chuyển Văn Bản Thành Giọng Nói (FL Chatterbox TTS)
- Thêm node "FL Chatterbox TTS" vào quy trình làm việc của bạn
- Cấu hình đầu vào văn bản và các tham số (exaggeration, cfg_weight, temperature)
- Tùy chọn cung cấp một đoạn âm thanh mẫu cho việc nhân bản giọng nói

### Node Chuyển Đổi Giọng Nói (FL Chatterbox VC)
- Thêm node "FL Chatterbox VC" vào quy trình làm việc của bạn
- Kết nối âm thanh đầu vào và giọng nói mục tiêu
- Cả hai node đều hỗ trợ chuyển sang CPU nếu gặp lỗi CUDA

## Nhật ký thay đổi

### 24/6/2025
- Thêm tham số seed vào cả node TTS và VC để tạo đầu ra có thể tái lập
- Khoảng giá trị seed: 0 đến 4.294.967.295 (số nguyên 32-bit)
- Cho phép xuất âm thanh nhất quán để debug và kiểm soát quy trình làm việc
- Tùy chọn hóa tính năng watermark Perth để sửa lỗi tương thích Python 3.12+
- Các node vẫn hoạt động bình thường nếu import resemble-perth thất bại

### 31/5/2025
- Thêm tính năng tải model liên tục và thanh trạng thái tải
- Thêm hỗ trợ cho Mac (cần kiểm tra thêm, liên hệ tôi)
- Loại bỏ thư viện chatterbox-tts và triển khai mã suy luận gốc.



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-23

---