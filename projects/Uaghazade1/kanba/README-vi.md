<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=it">Itapano</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Uaghazade1&project=kanba&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Giải pháp thay thế Trello mã nguồn mở, nhẹ, được thiết kế cho makers và indie hackers.

Tập trung vào sự đơn giản, tốc độ và khả năng mở rộng.
Xây dựng với công nghệ hiện đại: Tailwind CSS, shadcn/ui, Supabase, tích hợp Stripe.
Hỗ trợ dự án không giới hạn, cộng tác nhóm, chế độ tối/sáng và trải nghiệm người dùng liền mạch.
Hoàn hảo cho các lập trình viên solo và nhóm nhỏ muốn kiểm soát hoàn toàn mà không phức tạp không cần thiết.

## 🌟 Nếu bạn thấy dự án này hữu ích, hãy tặng một ngôi sao! Điều này sẽ giúp người khác dễ dàng tìm thấy hơn.

# Hướng dẫn Triển khai

## Tổng quan
Ứng dụng này hiện sử dụng các tuyến API Next.js cục bộ thay cho Supabase Edge Functions để tích hợp Stripe. Điều này giúp triển khai đơn giản hơn và cho phép bạn sử dụng file .env tiêu chuẩn để cấu hình.

## Thiết lập Biến Môi trường

### 1. Tạo file .env.local
Sao chép `.env.example` thành `.env.local` và điền các giá trị thực tế của bạn:


```bash
cp .env.example .env.local
```
### 2. Các biến môi trường bắt buộc

#### Cấu hình Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL dự án Supabase của bạn
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Khóa ẩn danh Supabase của bạn
- `SUPABASE_SERVICE_ROLE_KEY` - Khóa vai trò dịch vụ Supabase của bạn (chỉ dùng phía máy chủ)

#### Cấu hình Stripe (tùy chọn)
- `STRIPE_SECRET_KEY` - Khóa bí mật Stripe của bạn (chỉ dùng phía máy chủ)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Khóa công khai Stripe của bạn
- `STRIPE_WEBHOOK_SECRET` - Bí mật webhook Stripe của bạn

#### Cấu hình trang web
- `NEXT_PUBLIC_SITE_URL` - URL trang web của bạn (dùng cho môi trường production)
- `NEXTAUTH_URL` - URL trang web của bạn (giống như trên)
- `NEXTAUTH_SECRET` - Một chuỗi bí mật ngẫu nhiên cho NextAuth

## Phát triển cục bộ

1. Cài đặt các phụ thuộc:

```bash
npm install
```
2. Thiết lập các biến môi trường của bạn trong `.env.local`

3. Chạy máy chủ phát triển:

```bash
npm run dev
```
4. Kiểm tra webhook của Stripe cục bộ bằng Stripe CLI:

```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```
## Triển khai Sản xuất


### Triển khai với Vercel

1. **Triển khai lên Vercel:**

```bash
npx vercel
```
2. **Biến Môi Trường:**
   Thêm tất cả các biến môi trường thông qua bảng điều khiển Vercel hoặc CLI

3. **Thiết Lập Stripe Webhook:**
   - Trỏ webhook đến: `https://your-domain.vercel.app/api/stripe/webhook`

## Các Đầu Mối API

Ứng dụng hiện sử dụng các tuyến API cục bộ sau:

- `POST /api/stripe/checkout` - Tạo phiên thanh toán Stripe
- `POST /api/stripe/webhook` - Xử lý các sự kiện webhook Stripe

## Lợi Ích của Tuyến API Cục Bộ

1. **Triển Khai Đơn Giản Hơn** - Không cần triển khai các hàm edge riêng biệt
2. **Biến Môi Trường** - Hỗ trợ tệp .env tiêu chuẩn
3. **Gỡ Lỗi Tốt Hơn** - Dễ dàng gỡ lỗi trên máy cục bộ
4. **Tích Hợp Framework** - Tích hợp tốt hơn với Next.js
5. **Không Bị Ràng Buộc Nhà Cung Cấp** - Có thể triển khai trên bất kỳ nền tảng nào hỗ trợ Next.js

## Xử Lý Sự Cố

1. **Sự Cố Webhook:**
   - Đảm bảo `STRIPE_WEBHOOK_SECRET` khớp với endpoint webhook Stripe của bạn
   - Kiểm tra nhật ký webhook trên bảng điều khiển Stripe
   - Xác minh URL webhook là chính xác

2. **Biến Môi Trường:**
   - Đảm bảo tất cả biến cần thiết đã được thiết lập
   - Kiểm tra lỗi chính tả trong tên biến
   - Xác nhận khóa vai trò dịch vụ Supabase có đủ quyền

3. **Sự Cố CORS:**
   - Các tuyến API bao gồm header CORS phù hợp
   - Đảm bảo tên miền của bạn đã được cho phép nếu cần

## Lưu Ý Bảo Mật

- Không bao giờ tiết lộ `STRIPE_SECRET_KEY` hoặc `SUPABASE_SERVICE_ROLE_KEY` cho phía client
- Chỉ sử dụng tiền tố `NEXT_PUBLIC_` cho các biến phía client
- Xoay vòng bí mật webhook thường xuyên
- Theo dõi việc gửi webhook trên bảng điều khiển Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-20

---