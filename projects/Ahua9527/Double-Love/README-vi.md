# Double Love

<div align="center">

[![Giấy phép GitHub](https://img.shields.io/github/license/Ahua9527/Double-Love)](https://github.com/Ahua9527/Double-Love/blob/main/LICENSE)
![Số sao GitHub](https://img.shields.io/github/stars/Ahua9527/Double-Love)

🎬 Giữa các khung hình là tình yêu, hiệu suất tăng gấp đôi

[//]: # (Trứng phục sinh trong mã nguồn)
<!Double Love：Để mỗi cảnh quay đều ẩn chứa tần số khung hình chưa được nói ra của tôi -->

[English](./README.en.md) · 简体中文 · [Trải nghiệm trực tuyến](https://double-love.ahua.space)

</div>

Double Love cung cấp xử lý chuẩn hóa tự động hóa cho metadata của slate. Hỗ trợ sử dụng ngoại tuyến. Thông qua xử lý hàng loạt và cục bộ, đảm bảo kết nối liền mạch với Adobe Premiere, Silverstack, DTG Slate để đảm bảo tính nhất quán của metadata. Nâng cao hiệu suất quy trình hậu kỳ một cách hiệu quả.

## ✨ Tính năng nổi bật

- 🎬 Hỗ trợ quy trình công nghiệp điện ảnh
- 📝 Xử lý chuẩn hóa metadata thông minh
- ⚡ Xử lý cục bộ không độ trễ
- 🧩 Kết nối liền mạch với Adobe Premiere

## 🚀 Bắt đầu nhanh

### Quy trình cơ bản

1. Ghi chú slate: Sử dụng DTG Slate để tạo phiếu slate tương tác
2. Quản lý dữ liệu: Nhập dữ liệu slate qua Silverstack Lab
3. Xuất file: Tạo file XML cho Adobe Premiere Pro
4. Chuẩn hóa xử lý: Sử dụng Double Love để tối ưu thông minh

Ví dụ:
- File xml đầu vào: `UnitA_304_20250127.xml`
- File xml đầu ra: `UnitA_304_20250127_Double_LOVE.xml`

### Ví dụ chi tiết

#### Tối ưu hóa đặt tên file
- Chương trình sẽ tự động xử lý định dạng số cảnh, số máy và số lần quay
- Tự động bổ sung số 0 ở đầu cho số
- Tự động chuẩn hóa chữ hoa/thường
- Tự động loại bỏ dấu gạch dưới thừa

#### Quy tắc đặt tên đoạn phim

Tên đoạn phim sau khi xử lý tuân theo định dạng sau:
```
{tiền tố dự án}{cảnh}_{máy}_{lần}{máy quay}{đánh giá}
```

- `prefix`: Tiền tố tùy chỉnh (tùy chọn)
- `scene`: Số cảnh (3 chữ số, ví dụ 001)
- `shot`: Số máy (2 chữ số, ví dụ 01)
- `take`: Số lần quay (2 chữ số, ví dụ 01)
- `camera`: Ký hiệu máy quay (chữ thường, ví dụ a)
- `Rating`: Đánh giá (ok/kp/ng)

#### Xử lý đánh giá
- `Circle` → `ok`
- `KEEP` → `kp`
- `NG` → `ng`

#### Thông tin DIT
- Tự động thêm thông tin DIT: 'DIT: 哆啦Ahua 🌱'
- Nếu muốn loại bỏ, vui lòng tự triển khai😁😁

#### Ví dụ tiền tố tùy chỉnh

1. Đặt tiền tố là "PROJECT_A_"：
   - File đầu vào: `A304C007_250123G3`
   - File đầu ra: `PROJECT_A_004_01_07a_kp`

2. Không đặt tiền tố:
   - File đầu vào: `A304C007_250123G3`
   - File đầu ra: `004_01_07a_kp`

#### Ví dụ cài đặt độ phân giải sequence

1. Độ phân giải FHD (mặc định):
   - Chiều rộng: 1920
   - Chiều cao: 1080   
2. Độ phân giải DCI 2K (tùy chỉnh):
   - Chiều rộng: 2048
   - Chiều cao: 1080   

#### Ví dụ xử lý hàng loạt

1. Tải lên nhiều file cùng lúc:
   ```
   UnitA_304_20250123.xml
   UnitA_305_20250124.xml
   UnitA_306_20250125.xml
   ```

2. Sau khi xử lý sẽ nhận được:
   ```
   UnitA_304_20250123_Double_LOVE.xml
   UnitA_305_20250124_Double_LOVE.xml
   UnitA_306_20250125_Double_LOVE.xml
   ```

## 🛠️ Công nghệ sử dụng

- React 18
- TypeScript
- Vite
- Tailwind CSS
- Lucide Icons
- Hỗ trợ PWA

## 📦 Cài đặt và sử dụng

1. Clone dự án

```bash
git clone https://github.com/Ahua9527/Double-Love.git
cd Double-Love
```

2. Cài đặt phụ thuộc

```bash
npm install
```

3. Phát triển cục bộ

```bash
npm run dev
```

4. Build dự án

```bash
npm run build
```

## 🔒 Lưu ý an toàn

- Tất cả xử lý file đều thực hiện trên trình duyệt, không tải lên máy chủ
- Hỗ trợ file có dung lượng tối đa 50MB
- Chỉ hỗ trợ xử lý file định dạng XML

## 🌈 Hướng dẫn phát triển

### Cấu trúc dự án

```
Double-Love/
├── src/
│   ├── components/     # Component React
│   ├── context/       # React Context
│   ├── utils/         # Hàm tiện ích
│   ├── styles/        # File style
│   └── App.tsx        # Component chính của ứng dụng
├── public/            # Tài nguyên tĩnh
└── ...file cấu hình
```

## 📃 Giấy phép

[Giấy phép MIT](LICENSE)

## 🤝 Hướng dẫn đóng góp

Hoan nghênh gửi Issue và Pull Request!

## 👨‍💻 Tác giả

哆啦Ahua🌱

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-17

---