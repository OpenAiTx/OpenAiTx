# Visage: Thư viện UI kết hợp với lập trình sáng tạo

**Visage** là một thư viện C++ đa nền tảng, tăng tốc GPU cho UI gốc và đồ họa 2D. Nó kết hợp cấu trúc của một framework UI với các tính năng của các thư viện đồ họa sáng tạo.

## Ví dụ cơ bản đầy đủ
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // Mở cửa sổ với kích thước 800 x 600 pixel
  app.runEventLoop(); // Chạy vòng lặp sự kiện cửa sổ. Trả về khi cửa sổ đóng.
  return 0;
}
```

## Các bản demo
- [Showcase](https://visage.dev/examples/Showcase/)
- [Chế độ hòa trộn (Blend Modes)](https://visage.dev/examples/BlendModes/)
- [Bloom](https://visage.dev/examples/Bloom/)
- [Gradient](https://visage.dev/examples/Gradients/)
- [Hiệu ứng Shader hậu kỳ (Post Shader Effects)](https://visage.dev/examples/PostEffects/)
- [Chỉnh sửa Shader trực tiếp (Live Shader Editing)](https://visage.dev/examples/LiveShaderEditing/)
- [Bố cục linh hoạt (Layout Flexing)](https://visage.dev/examples/Layout/)

## Tính năng UI

- **Chuẩn hóa sự kiện**  
&nbsp;&nbsp;&nbsp;Hỗ trợ đa nền tảng cho chuẩn hóa nhập liệu bàn phím và chuột.

- **Chuẩn hóa cửa sổ**  
&nbsp;&nbsp;&nbsp;Hỗ trợ đa nền tảng cho mở và xử lý cửa sổ.

- **Nhập liệu văn bản**  
&nbsp;&nbsp;&nbsp;Nhập liệu văn bản Unicode với chỉnh sửa nhiều dòng.

- **✨ Biểu tượng cảm xúc (Emojis) ✨**  
&nbsp;&nbsp;&nbsp;Nếu bạn thích loại này 🤷

- **Kết xuất một phần**  
&nbsp;&nbsp;&nbsp;Chỉ vẽ lại vùng bị thay đổi để tối ưu hiệu suất.

## Tính năng đồ họa

- **Chuyển động mượt mà**  
&nbsp;&nbsp;&nbsp;Khung hình mới hiển thị theo tần số quét của màn hình và hoạt ảnh mượt mà.

- **Nhóm hình dạng tự động**  
&nbsp;&nbsp;&nbsp;Tự động nhóm các hình dạng để kết xuất GPU hiệu quả.

- **Chế độ hòa trộn**  
&nbsp;&nbsp;&nbsp;Hỗ trợ hòa trộn các lớp với chế độ cộng, trừ hoặc bằng cách vẽ mặt nạ tùy chỉnh cho UI thông qua.

- **Shader**  
&nbsp;&nbsp;&nbsp;Viết shader một lần và chuyển đổi cho Direct3D, Metal và OpenGL.

- **Hiệu ứng đi kèm**  
&nbsp;&nbsp;&nbsp;Hiệu ứng thời gian thực như làm mờ lớn và bloom.

- **Độ chính xác điểm ảnh**  
&nbsp;&nbsp;&nbsp;Truy cập kích thước điểm ảnh thiết bị đảm bảo kết xuất chính xác không bị mờ.

## Nền tảng hỗ trợ
- **Windows**: Direct3D11
- **MacOS**: Metal  
- **Linux**: Vulkan
- **Web/Emscripten**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---