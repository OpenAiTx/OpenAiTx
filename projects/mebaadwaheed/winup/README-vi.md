<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=mebaadwaheed&project=winup&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

![Chào đón PRs](https://img.shields.io/badge/PRs-welcome-brightgreen)
![Python 3.9+](https://img.shields.io/badge/python-3.9%2B-blue)
![Component Driven](https://img.shields.io/badge/architecture-component--driven-orange)
![Ứng dụng Desktop](https://img.shields.io/badge/platform-desktop-lightgrey)
![Hỗ trợ CLI](https://img.shields.io/badge/CLI-supported-critical)
![Live Reload](https://img.shields.io/badge/live--reload-enabled-blue)

## Ví dụ về Hình ảnh

![image](https://github.com/user-attachments/assets/81d016e9-e10a-4438-ab94-99b6d76b8efe)

![image](https://github.com/user-attachments/assets/154dc3f4-ea8c-4f6f-84d3-88c7ab74a46f)

![image](https://github.com/user-attachments/assets/2318f701-6ec8-4402-abcc-40c879bf1a10)

# WinUp 🚀

## Đảm bảo tải về Bản Phát Hành Ổn Định Mới Nhất (LSR) chứ không phải bản mới nhất/LFR! LSR hiện tại: 2.4.9

`pip install winup==2.4.9`

**Một framework Pythonic mạnh mẽ đến mức khó tin để xây dựng các ứng dụng desktop tuyệt đẹp.**

WinUp là một framework giao diện người dùng hiện đại cho Python, bọc sức mạnh của PySide6 (Qt) trong một API đơn giản, khai báo và thân thiện với nhà phát triển. Nó được thiết kế để giúp bạn xây dựng ứng dụng nhanh hơn, viết mã sạch hơn và tận hưởng quá trình phát triển.

### ✨ Giờ đây đã hỗ trợ Web!
WinUp bây giờ cũng hỗ trợ xây dựng các ứng dụng web tương tác hoàn toàn, có trạng thái, sử dụng cùng một phương pháp dựa trên Python và component. Mô-đun web sử dụng FastAPI và WebSockets bên dưới để mang sự đơn giản của WinUp lên trình duyệt.

[Tài liệu Web](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/web/README.md)

> **Lưu ý:** Hỗ trợ Web là một tính năng tuỳ chọn. Để sử dụng, bạn cần cài đặt các phụ thuộc web:
> ```bash
> pip install "winup[web]"
> ```

[Đóng góp](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CONTRIBUTING.md)
[Nhật ký thay đổi](https://raw.githubusercontent.com/mebaadwaheed/winup/main/CHANGELOG.md)
[Giấy phép](LICENSE)

---

## Tại sao chọn WinUp? (Thay vì PySide6 thuần hoặc Tkinter)

Phát triển desktop bằng Python có thể cảm thấy cồng kềnh. WinUp được xây dựng để khắc phục điều đó.

| Tính năng                 | Cách WinUp ✨                                                                   | Cách PySide6 / Tkinter thuần 😟                                                                |
| ----------------------- | ------------------------------------------------------------------------------ | ------------------------------------------------------------------------------------------- |
| **Bố cục**             | `ui.Column(children=[...])`, `ui.Row(children=[...])`                          | `QVBoxLayout()`, `QHBoxLayout()`, `layout.addWidget()`, `pack()`, `grid()`                  |
| **Tùy chỉnh giao diện**             | `props={"background-color": "blue", "font-size": "16px"}`                      | Chuỗi QSS thủ công, `widget.setStyleSheet(...)`, đối tượng style phức tạp.                     |
| **Quản lý trạng thái**    | `state.bind(widget, "prop", "key")`                                            | Hàm callback thủ công, getter/setter, `StringVar()`, lặp lại mã ở khắp nơi.          |
| **Ràng buộc hai chiều**     | `state.bind_two_way(input_widget, "key")`                                      | Không có sẵn. Phải viết handler `on_change` thủ công để cập nhật trạng thái và UI.                  |
| **Công cụ dev**     | **Hot Reloading tích hợp**, profiler mã nguồn, và công cụ cửa sổ sẵn có.    | Không có sẵn. Phải khởi động lại toàn bộ app cho từng thay đổi UI nhỏ nhất.                            |
| **Cấu trúc mã**      | Component có thể tái sử dụng, tự đóng gói với `@component`.                         | Thường dẫn đến các class lớn, hoặc script thủ tục.                             |

**Tóm lại, WinUp cung cấp những "tính năng sát thủ" của các framework web hiện đại (như React hoặc Vue) cho desktop, giúp bạn tiết kiệm thời gian và tập trung vào logic ứng dụng.**

# 🧊 WinUp so với 🧱 PyEdifice (Theo yêu cầu Reddit User)

| Tính năng                          | WinUp      | PyEdifice                        |
|----------------------------------|--------------------------------------|----------------------------------|
| 🧱 Kiến trúc                  | Kiểu React + state       | Kiểu React + state              |
| 🌐 Định tuyến tích hợp              | ✅ Có (`Router(routes={...})`)      | ❌ Không có định tuyến tích hợp            |
| ♻️ Vòng đời component               | ✅ `on_mount`, `on_unmount`, v.v.    | ⚠️ Giới hạn (`did_mount`, v.v.)   |
| 🎨 Hệ thống chủ đề / tùy chỉnh     | ✅ Chủ đề toàn cục & cục bộ             | ❌ Chèn CSS thủ công           |
| 🔲 Tùy chọn bố cục                | ✅ Row, Column, Grid, Stack, Flexbox | ⚠️ Chủ yếu Box & HBox/VBox         |
| 🎞️ Hiệu ứng động                   | ✅ Tích hợp sẵn (fade, scale, v.v.)      | ❌ Không có sẵn                  |
| 🔁 Hot Reloading (LHR)          | ✅ Ổn định + nhanh (`loadup dev`)      | ⚠️ Thử nghiệm, hỗ trợ giới hạn  |
| 📦 Đóng gói                    | ✅ Với LoadUp (dựa trên PyInstaller)   | ❌ Phải tích hợp PyInstaller thủ công |
| 🧩 Tái sử dụng component        | ✅ Cao, khai báo                 | ✅ Cao                           |

| 🛠 Công cụ phát triển              | ✅ Đã lên kế hoạch DevTools, Inspector sắp có | ❌ Chưa có                        |
| 📱 Hỗ trợ di động                  | ❌ Chưa có                              | ❌ Không hỗ trợ                   |
| 🧠 Độ khó học                      | ✅ Dễ cho người dùng Python+React        | ✅ Dễ nhưng ít công cụ hơn         |

> ✅ = Tích hợp sẵn hoặc mạnh mẽ  
> ⚠️ = Hạn chế hoặc một phần  
> ❌ = Hoàn toàn thiếu
---

## Tính năng cốt lõi

*   **UI khai báo & Pythonic:** Xây dựng layout phức tạp với các đối tượng `Row` và `Column` đơn giản thay vì layout hộp rườm rà.
*   **Kiến trúc dựa trên thành phần:** Sử dụng decorator `@component` để tạo các widget UI dạng mô-đun và tái sử dụng từ các hàm đơn giản.
*   **Hệ thống tạo kiểu mạnh mẽ:** Tạo kiểu cho widget với dict Python đơn giản qua `props`. Tạo các class "giống CSS" toàn cục bằng `style.add_style_dict`.
*   **Khung ứng dụng hoàn chỉnh:** Xây dựng ứng dụng chuyên nghiệp với API khai báo cho `MenuBar`, `ToolBar`, `StatusBar`, và `SystemTrayIcon`.
*   **Chạy tác vụ bất đồng bộ:** Chạy các tác vụ dài ở nền mà không làm treo UI với decorator đơn giản `@tasks.run`.
*   **Hiệu suất mặc định:** Bao gồm decorator tự chọn `@memo` để cache render và tránh tính toán lại không cần thiết.
*   **Khả năng mở rộng nâng cao:**
    *   **Widget Factory:** Thay thế bất kỳ widget mặc định nào bằng bản tuỳ chỉnh (ví dụ, dựa trên C++) qua `ui.register_widget()`.
    *   **Nhiều cửa sổ:** Tạo và quản lý nhiều cửa sổ độc lập cho ứng dụng phức tạp như bảng công cụ hay trình phát nhạc.
*   **Quản lý trạng thái phản ứng:**
    *   **Ràng buộc một chiều:** Tự động cập nhật UI khi dữ liệu thay đổi với `state.bind()`.
    *   **Ràng buộc hai chiều:** Dễ dàng đồng bộ widget nhập liệu với trạng thái qua `state.bind_two_way()`.
    *   **Đăng ký lắng nghe:** Kích hoạt bất kỳ hàm nào khi trạng thái thay đổi với `state.subscribe()`.
*   **Công cụ thân thiện với lập trình viên:**
    *   **Tải nóng:** Xem thay đổi UI ngay lập tức mà không cần khởi động lại ứng dụng.
    *   **Profiler:** Đo hiệu suất bất kỳ hàm nào dễ dàng với decorator `@profiler.measure()`.
    *   **Công cụ cửa sổ:** Căn giữa, làm nhấp nháy, hoặc quản lý cửa sổ ứng dụng dễ dàng.
*   **Định tuyến tích hợp:** Tạo ứng dụng nhiều trang dễ dàng với router dựa trên trạng thái, trực quan.
*   **Lớp dữ liệu linh hoạt:** Bao gồm các connector đơn giản, nhất quán cho SQLite, PostgreSQL, MySQL, MongoDB và Firebase.

---

# Tài liệu

Tìm hiểu sâu hơn về các tính năng của WinUp:

## Khái niệm cốt lõi
- [**Mô hình thành phần & tạo kiểu**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md)
- [**Quản lý trạng thái**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/state.md)
- [**Vòng đời thành phần**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#component-lifecycle-hooks-on_mount-and-on_unmount)
- [**Định tuyến**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/concepts.md#routing)
- [**Định vị tuyệt đối (Nâng cao)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/absolute-layout.md)

## Công cụ phát triển
- [**Live Hot Reload (LHR)**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/live-hot-reload.md)
- [**Performance Profiler**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/profiler.md)
- [**Memoization**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/memoization.md)
- [**Async Task Runner**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/tasks.md)

## Thành phần UI
- [**Thư viện thành phần đầy đủ**](https://raw.githubusercontent.com/mebaadwaheed/winup/main/docs/components/README.md)

---

## Đóng góp

WinUp là dự án mã nguồn mở. Mọi đóng góp đều được chào đón!

## Giấy phép

Dự án này được cấp phép theo MIT License. Xem **LICENSE** để biết thêm chi tiết.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-18

---