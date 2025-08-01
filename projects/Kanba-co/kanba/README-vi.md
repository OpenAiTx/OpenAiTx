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

<div align="center">
  <br />
<br />
<a href="https://kanba.co">
  <img alt="Kanba" src="https://www.kanba.co/dark-hero.png" style=" width: 800px " />
</a>
    <br />
<br />
</div>

<div align="center">
  <br />
<br />
<a href="https://vercel.com/oss">
  <img alt="Vercel OSS Program" src="https://vercel.com/oss/program-badge.svg" />
</a>
    <br />
<br />
</div>
# Giải pháp thay thế Trello mã nguồn mở, nhẹ, dành cho makers và indie hackers.

Tập trung vào sự đơn giản, tốc độ và khả năng mở rộng.
Được xây dựng với công nghệ hiện đại: Tailwind CSS, shadcn/ui, Supabase, tích hợp Stripe.
Hỗ trợ không giới hạn dự án, cộng tác nhóm, chế độ tối/sáng, và trải nghiệm người dùng mượt mà.
Hoàn hảo cho các lập trình viên cá nhân và nhóm nhỏ muốn kiểm soát hoàn toàn mà không phức tạp không cần thiết.

## 🌟 Nếu bạn thấy dự án này hữu ích, hãy cho nó một sao! Điều này giúp người khác cũng khám phá ra nó.

# Hướng Dẫn Triển Khai

## Tổng Quan
Ứng dụng này hiện sử dụng các route API cục bộ của Next.js thay vì Supabase Edge Functions cho tích hợp Stripe. Điều này giúp việc triển khai dễ dàng hơn và cho phép bạn sử dụng các file .env tiêu chuẩn để cấu hình.

## Thiết Lập Biến Môi Trường

### 1. Tạo file .env.local
Sao chép `.env.example` thành `.env.local` và điền các giá trị thực tế của bạn:


```bash
cp .env.example .env.local
```

### 2. Biến Môi Trường Bắt Buộc

#### Cấu Hình Supabase
- `NEXT_PUBLIC_SUPABASE_URL` - URL dự án Supabase của bạn
- `NEXT_PUBLIC_SUPABASE_ANON_KEY` - Khóa ẩn danh của Supabase
- `SUPABASE_SERVICE_ROLE_KEY` - Khóa vai trò dịch vụ của Supabase (chỉ sử dụng phía máy chủ)

#### Cấu Hình Stripe (tùy chọn)
- `STRIPE_SECRET_KEY` - Khóa bí mật Stripe của bạn (chỉ sử dụng phía máy chủ)
- `NEXT_PUBLIC_STRIPE_PUBLISHABLE_KEY` - Khóa công khai Stripe của bạn
- `STRIPE_WEBHOOK_SECRET` - Khóa webhook Stripe của bạn

#### Cấu Hình Trang Web
- `NEXT_PUBLIC_SITE_URL` - URL trang web của bạn (cho môi trường production)
- `NEXTAUTH_URL` - URL trang web của bạn (giống như trên)
- `NEXTAUTH_SECRET` - Một chuỗi bí mật ngẫu nhiên cho NextAuth

## Phát Triển Cục Bộ

1. Cài đặt các phụ thuộc:
```bash
npm install
```

2. Thiết lập các biến môi trường của bạn trong `.env.local`

3. Khởi động máy chủ phát triển:
```bash
npm run dev
```

4. Kiểm tra webhook của Stripe cục bộ bằng Stripe CLI:
```bash
stripe listen --forward-to localhost:3000/api/stripe/webhook
```

## Triển khai sản xuất


### Triển khai trên Vercel

1. **Triển khai lên Vercel:**
```bash
npx vercel
```
2. **Biến Môi Trường:**
   Thêm tất cả biến môi trường thông qua bảng điều khiển hoặc CLI của Vercel

3. **Thiết Lập Stripe Webhook:**
   - Trỏ webhook đến: `https://your-domain.vercel.app/api/stripe/webhook`

## Các Đầu Mối API

Ứng dụng hiện sử dụng các tuyến API cục bộ sau:

- `POST /api/stripe/checkout` - Tạo phiên thanh toán Stripe
- `POST /api/stripe/webhook` - Xử lý các sự kiện webhook Stripe

## Lợi Ích của Tuyến API Cục Bộ

1. **Triển Khai Đơn Giản Hơn** - Không cần triển khai các hàm edge riêng biệt
2. **Biến Môi Trường** - Hỗ trợ tệp .env tiêu chuẩn
3. **Gỡ Lỗi Tốt Hơn** - Dễ dàng gỡ lỗi cục bộ
4. **Tích Hợp Framework** - Tích hợp tốt hơn với Next.js
5. **Không Bị Khóa Nhà Cung Cấp** - Có thể triển khai lên bất kỳ nền tảng nào hỗ trợ Next.js

## Xử Lý Sự Cố

1. **Vấn Đề Webhook:**
   - Đảm bảo `STRIPE_WEBHOOK_SECRET` khớp với endpoint webhook Stripe của bạn
   - Kiểm tra nhật ký webhook trong bảng điều khiển Stripe
   - Xác minh URL webhook chính xác

2. **Biến Môi Trường:**
   - Đảm bảo tất cả biến cần thiết đã được thiết lập
   - Kiểm tra lỗi chính tả trong tên biến
   - Xác minh khóa vai trò dịch vụ Supabase có đủ quyền hạn

3. **Vấn Đề CORS:**
   - Các tuyến API bao gồm header CORS phù hợp
   - Đảm bảo tên miền của bạn đã được cho phép nếu cần

## Ghi Chú Bảo Mật

- Không bao giờ tiết lộ `STRIPE_SECRET_KEY` hoặc `SUPABASE_SERVICE_ROLE_KEY` cho phía client
- Chỉ sử dụng tiền tố `NEXT_PUBLIC_` cho các biến phía client
- Thường xuyên thay đổi khóa bí mật webhook của bạn
- Giám sát việc gửi webhook trong bảng điều khiển Stripe



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-01

---