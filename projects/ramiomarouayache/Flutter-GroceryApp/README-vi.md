# GroceryApp Starter

Mẫu ứng dụng mua sắm thực phẩm giúp trải nghiệm mua sắm trở nên đơn giản và hiệu quả. 🛒✨

Hãy đánh dấu ⭐ kho lưu trữ nếu bạn thấy nó hữu ích.

## Thiết kế

**Nhấn vào hình bên dưới để xem thiết kế Figma:**

[![Design Preview](https://github.com/ramiomarouayache/Flutter-GroceryApp/blob/main/screenshots/Cover.jpg)](https://www.figma.com/embed?embed_host=oembed&amp;url=https://www.figma.com/file/eyeYwe0hoEch31j6d3EXyE/GroceryApp-Starter-(Community)?type=design&amp;node-id=3-2&amp;mode=design&amp;t=LwLW2onM0GKLuFdU-0)



## ✨Yêu cầu

1. **Môi trường phát triển:**
   - Bất kỳ IDE nào đã cài đặt Flutter SDK (ví dụ: VSCode, Android Studio, IntelliJ...v.v.)

2. **Kiến thức nền tảng:**
   - Kiến thức cơ bản đến trung bình về Dart và Flutter
   - Hiểu biết về kiến trúc MVVM
   - Quen thuộc với việc xử lý API
   - Kiến thức cơ bản về quản lý trạng thái bằng GetX
  
## Kiểm thử
* Bạn có thể tải xuống phiên bản thử nghiệm cho thiết bị Android tại đây [releases](https://github.com/ramiomarouayache/Flutter-GroceryApp/releases/tag/v0.3.1).
<video src="https://github.com/ramiomarouayache/Flutter-GroceryApp/assets/98425058/5ae355c9-39e0-478e-9b3e-870953b566ca"></video>

  
## Cài đặt
* Bắt đầu bằng cách cấu hình endpoint sản phẩm, thông tin xác thực, và các tham số trong `lib\constants\AppConstants`.
* **Hoặc**, sử dụng endpoint miễn phí bên dưới (tại thời điểm chia sẻ) để kiểm thử thành công.
```dart
class AppConstants {
  // Thay thế "YOUR_API_PREFIX" bằng URL gốc API của bạn.
  static const String BASE_URL = "YOUR_API_PREFIX";
  static const String API_KEY = "YOUR_API_KEY"; //NẾU_CÓ

  // Để kiểm thử, sử dụng URL API miễn phí từ bản phát hành
  static const String BASE_URL = "https://world.openfoodfacts.org/api/v2";

  // Họ tên đầy đủ của chủ dự án.
  static const String projectOwnerName = "FULL_NAME";
}
```

## Lưu ý
* Để sử dụng endpoint API riêng, hãy tùy chỉnh các lớp logic theo hướng dẫn kiến trúc MVVM dựa trên tài liệu API của bạn.
* Một số hình ảnh trong bản thử nghiệm đã bị gỡ bỏ do hạn chế bản quyền.

## Đóng góp

Vui lòng fork kho lưu trữ này và đóng góp lại bằng
[pull requests](https://github.com/ramiomarouayache/Flutter-GroceryApp/pulls).

Mọi đóng góp, dù lớn hay nhỏ, các tính năng mới, sửa lỗi đều được hoan nghênh và đánh giá cao,
nhưng sẽ được xem xét kỹ lưỡng.


## Bắt đầu
Dự án này là điểm khởi đầu cho một ứng dụng Flutter.

Một số tài nguyên giúp bạn bắt đầu nếu đây là dự án Flutter đầu tiên của bạn:

- [Lab: Viết ứng dụng Flutter đầu tiên của bạn](https://flutter.io/docs/get-started/codelab)
- [Cookbook: Các ví dụ Flutter hữu ích](https://flutter.io/docs/cookbook)

## Lượt truy cập

<img align="left" src = "https://profile-counter.glitch.me/GroceryApp/count.svg" alt ="Loading">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---