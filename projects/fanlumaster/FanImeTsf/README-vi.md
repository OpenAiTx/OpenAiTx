## FanImeTsf

Đây là phần cuối TSF của [FanImeServer](https://github.com/fanlumaster/FanImeServer).

Lưu ý: hiện tại chỉ hỗ trợ các ứng dụng 64-bit.

## Cách xây dựng

### Yêu cầu

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

Đảm bảo rằng vcpkg và gsudo đã được cài đặt bằng **Scoop**.

## Các bước xây dựng

### Xây dựng

Đầu tiên, hãy clone kho lưu trữ,

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

Sau đó, chuẩn bị môi trường,

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

Tiếp theo, tiến hành xây dựng,

```powershell
.\scripts\lcompile.ps1
```

### Cài đặt

Khởi động powershell với quyền quản trị viên, đảm bảo bạn đã bật tùy chọn hệ thống `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

Sau đó, tạo một thư mục trong `C:\Program Files\` tên là `FanImeTsf`, và sao chép `FanImeTsf.dll` vào đó,

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

Tiếp theo, tiến hành cài đặt,

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### Gỡ cài đặt

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## Ảnh chụp màn hình

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## Lộ trình phát triển

Hiện tại chỉ hỗ trợ Xiaohe Shuangpin.

### Tiếng Trung

- Xiaohe Shuangpin
- Quanpin
- Các mã trợ giúp trong việc sử dụng thành phần Hán tự
- Từ điển có thể tùy chỉnh
- Bộ máy IME tùy chỉnh
- Giao diện (skin) tùy chỉnh
- Chuyển đổi giữa tiếng Trung Giản thể và Phồn thể
- Tự động hoàn thành tiếng Anh
- API IME đám mây mã nguồn mở
- Chuyển đổi giao diện cửa sổ lựa chọn ứng viên giữa chế độ dọc và ngang
- Công tắc tính năng: hầu hết các tính năng nên có thể tùy chỉnh hoặc bật/tắt tự do bởi người dùng

### Hỗ trợ tiếng Nhật

Có thể sẽ là một dự án khác.

Và có thể sẽ hỗ trợ thêm các ngôn ngữ khác.

### Tham khảo

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---