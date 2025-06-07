# EmuReady

Một nền tảng do cộng đồng đóng góp nhằm theo dõi khả năng tương thích giả lập trên nhiều thiết bị và trình giả lập khác nhau.

Truy cập trang web của chúng tôi: [https://emuready.com](https://emuready.com)

---

**Ảnh chụp màn hình Trang chủ**

<img src="https://github.com/user-attachments/assets/9a7077fd-a9b1-4a1c-8a81-8f9beed25581" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/df612c7c-4b9d-481b-ae92-175b2b6afb0b" width="48%">

---

**Ảnh chụp màn hình Trang Danh sách Tương thích**

<img src="https://github.com/user-attachments/assets/400c48d4-6340-4a60-8d86-f996a35f1bf4" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/4ca1c1de-3616-4c25-81b9-ad80f8a69458" width="48%">

---

**Ảnh chụp màn hình Trang Trò chơi**

<img src="https://github.com/user-attachments/assets/b036de53-18ed-4bf4-8117-5cd36e87ee31" width="48%">&nbsp;&nbsp;&nbsp;<img src="https://github.com/user-attachments/assets/9fbe12c4-3387-4e1d-986a-df80761134e3" width="48%">

---

## Tổng quan

EmuReady giúp người dùng chia sẻ và khám phá thông tin về khả năng tương thích giả lập trên nhiều cấu hình phần cứng và phần mềm khác nhau. Người dùng có thể đóng góp báo cáo tương thích, bình chọn các danh sách và thảo luận về các kết hợp trò chơi/thiết bị/giả lập cụ thể.

![License](https://img.shields.io/github/license/Producdevity/emuready?cacheSeconds=1)
![Stars](https://img.shields.io/github/stars/Producdevity/emuready?cacheSeconds=1)
![Forks](https://img.shields.io/github/forks/Producdevity/emuready?cacheSeconds=1)
![Issues](https://img.shields.io/github/issues/Producdevity/emuready?cacheSeconds=1)

## Tính năng

- **Cơ sở dữ liệu tương thích toàn diện**: Theo dõi hiệu suất trò chơi trên các trình giả lập và thiết bị khác nhau
- **Đóng góp từ người dùng**: Báo cáo và hệ thống bình chọn do cộng đồng đóng góp
- **Hệ thống thảo luận**: Chủ đề bình luận với chức năng bình chọn lên/xuống
- **Bảng điều khiển quản trị**: Quản lý người dùng, danh sách và kiểm duyệt nội dung
- **Thiết kế đáp ứng**: Hoạt động tốt trên di động, máy tính bảng và máy tính để bàn

## Những cải tiến gần đây

Cơ sở mã nguồn đã được cải thiện đáng kể với các điểm nâng cấp sau:

### Thành phần giao diện

- Tạo thành phần **ErrorBoundary** để xử lý và phục hồi lỗi tốt hơn
- Thêm thành phần **OptimizedImage** sử dụng Next.js Image để tăng hiệu suất
- Cải tiến **Phân trang** với các tính năng hỗ trợ tiếp cận, điều hướng bằng bàn phím và nâng cao trải nghiệm người dùng
- Nâng cấp thành phần **Badge** với nhiều kiểu, kích cỡ và tùy chọn hình viên thuốc
- Thêm thành phần **ThemeToggle** để chuyển đổi giữa các chế độ sáng, tối và theo hệ thống
- Triển khai **SortableHeader** để sắp xếp bảng với chỉ báo trực quan

### Bộ nhớ đệm & Hiệu năng

- Cải thiện cấu hình React Query với mặc định tốt hơn cho cache, thời gian hết hạn, và logic thử lại
- Thêm tối ưu hóa hình ảnh cho các hình ảnh thiết bị
- Thực hiện xử lý lỗi hợp lý trên toàn ứng dụng

### Khả năng tiếp cận

- Cải thiện điều hướng bằng bàn phím cho các thành phần tương tác
- Thêm các nhãn ARIA và vai trò phù hợp
- Quản lý tiêu điểm tốt hơn
- Tăng độ tương phản màu trong các thành phần giao diện

### Bảo mật

- Kiểm tra và làm sạch dữ liệu ở nhiều cấp độ (client, server, database)
- Triển khai Content Security Policy
- Bảo vệ chống tấn công XSS và CSRF
- Xác thực an toàn với NextAuth.js
- Kiểm tra và bảo mật tải lên tệp
- Giới hạn độ dài đầu vào và làm sạch hợp lý
- Kiểm tra hợp lệ UUID để ngăn chặn giả mạo tham số

### Trải nghiệm nhà phát triển

- Thêm các script npm bổ sung cho quy trình phát triển
- Cấu trúc dự án tốt hơn với các xuất khẩu nhất quán
- Nâng cao thông báo lỗi với ErrorBoundary tùy chỉnh
- Cải tiến trang 404 với tùy chọn điều hướng hữu ích

### Chủ đề giao diện

- Thêm phát hiện sở thích chủ đề hệ thống
- Tạo chuyển đổi chủ đề với nhiều tùy chọn giao diện
- Cải thiện chế độ tối trên toàn bộ thành phần

## Bắt đầu

### Yêu cầu

- Node.js 20+
- `npm`
- PostgreSQL (hoặc SQLite cho phát triển)

### Cài đặt

1. Sao chép kho lưu trữ

```bash
git clone https://github.com/Producdevity/emuready.git
cd emuready
```

2. Cài đặt các phụ thuộc

```bash
npm install
```

3. Thiết lập biến môi trường

```bash
cp .env.example .env
```

Sau đó chỉnh sửa file `.env` với thông tin cơ sở dữ liệu và cấu hình khác của bạn.

4. Thiết lập cơ sở dữ liệu

```bash
npx prisma generate
npx prisma db push
```

5. Chạy máy chủ phát triển

```bash
npm run dev
```

6. Mở [http://localhost:3000](http://localhost:3000) trên trình duyệt của bạn

## Các script có sẵn

- `npm run dev` - Khởi động máy chủ phát triển
- `npm run dev:strict` - Khởi động với chế độ nghiêm ngặt của React
- `npm run build` - Biên dịch cho môi trường sản xuất
- `npm run start` - Khởi động máy chủ sản xuất
- `npm run test` - Chạy kiểm thử
- `npm run lint` - Chạy ESLint
- `npm run lint:fix` - Sửa lỗi lint
- `npm run format` - Định dạng mã bằng Prettier
- `npm run typecheck` - Kiểm tra kiểu TypeScript
- `npm run analyze` - Phân tích kích thước bundle
- `npm run clean` - Xóa cache build
- `npm run prepare-deploy` - Chuẩn bị triển khai (lint, kiểm tra kiểu, kiểm thử, build)

### Lệnh Prisma

- `npx prisma db seed` - Gieo dữ liệu cho cơ sở dữ liệu
- `npx prisma studio` - Mở Prisma Studio
- `npx prisma db pull` - Kéo sơ đồ cơ sở dữ liệu
- `npx prisma db push` - Đẩy sơ đồ cơ sở dữ liệu

Xem [Tham khảo Prisma CLI](https://www.prisma.io/docs/orm/reference/prisma-cli-reference) để biết thêm chi tiết.

## Công nghệ sử dụng

- **Framework**: Next.js 15
- **ORM cho cơ sở dữ liệu**: Prisma
- **API**: tRPC
- **Xác thực**: NextAuth.js
- **Giao diện**: Tailwind CSS
- **Quản lý trạng thái**: React Query
- **Kiểm tra kiểu**: TypeScript
- **Hiệu ứng động**: Framer Motion
- **Kiểm tra hợp lệ**: Zod, Content Security Policy, Kiểm tra hợp lệ đầu vào

## Đóng góp

Chúng tôi hoan nghênh mọi đóng góp! Vui lòng xem [Hướng dẫn đóng góp](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CONTRIBUTING.md) để biết thêm chi tiết.

## Giấy phép

Dự án này được cấp phép theo MIT License - xem file [LICENSE](https://raw.githubusercontent.com/Producdevity/EmuReady/master/LICENSE) để biết chi tiết.

## Quy tắc ứng xử (TODO)

Lưu ý dự án này tuân theo [Quy tắc ứng xử](https://raw.githubusercontent.com/Producdevity/EmuReady/master/CODE_OF_CONDUCT.md). Tham gia dự án đồng nghĩa bạn đồng ý với các điều khoản này.

## Bảo mật (TODO)

Nếu bạn phát hiện lỗ hổng bảo mật, vui lòng làm theo [Chính sách bảo mật](https://raw.githubusercontent.com/Producdevity/EmuReady/master/SECURITY.md) của chúng tôi để báo cáo.

## Lời cảm ơn

- Toàn bộ [Những người đóng góp](https://github.com/Producdevity/emuready/graphs/contributors)
- Cộng đồng giả lập vì nguồn cảm hứng và sự hỗ trợ

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---