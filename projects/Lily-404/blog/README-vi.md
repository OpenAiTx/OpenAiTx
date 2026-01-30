
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Lily-404&project=blog&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Blog của Jimmy

Một hệ thống blog cá nhân tối giản được xây dựng dựa trên Next.js 15+.

## Công nghệ sử dụng

- **Framework**: Next.js 13+ (App Router)
- **Giao diện**: Tailwind CSS
- **Biểu tượng**: Lucide Icons
- **Chủ đề**: Hỗ trợ chuyển đổi chế độ sáng/tối
- **Triển khai**: Vercel

## Tính năng nổi bật

- 📝 Hỗ trợ bài viết Markdown
- 🌓 Chuyển đổi chủ đề sáng/tối
- 📱 Thiết kế đáp ứng
- ⚡ Tải nhanh
- 📅 Hiển thị dòng thời gian bài viết
- 🔐 Quản trị trực tuyến (tạo bài viết trực tiếp qua GitHub API)

## Cấu trúc dự án

```
.
├── app/
│   ├── lib/           # 工具函数和数据处理
│   ├── posts/         # 博客文章
│   └── page.tsx       # 首页
├── content/
│   ├── notes/         # 随笔
│   └── posts/         # 文章
├── components/        # React 组件
├── public/            # 静态资源
└── styles/            # 全局样式
```

## Cài đặt và chạy

1. Nhân bản dự án

```bash
git clone https://github.com/Lily-404/blog.git
cd jimmy-blog
```

2. Cài đặt các phụ thuộc

```bash
npm install
```

3. Khởi động máy chủ phát triển

```bash
npm run dev
```

4. Xây dựng phiên bản sản xuất

```bash
npm run build
```

## Thêm bài viết mới

### Cách 1: Quản lý trực tuyến qua trang quản trị (khuyến nghị)

1. Truy cập trang `/admin`
2. Đăng nhập bằng mật khẩu quản trị viên
3. Điền thông tin bài viết và gửi
4. Bài viết sẽ được tạo tự động qua GitHub API, Vercel sẽ tự động triển khai lại

### Cách 2: Thêm file thủ công

1. Tạo file Markdown mới trong thư mục `content/posts`
2. Định dạng tên file: xxx.md`
3. Thêm metadata ở đầu file:

```markdown
---
title: 文章标题
date: YYYY-MM-DD
tags: ["标签1","标签2","标签3"]
---
```

## Thêm bài viết tùy ý

1. Tạo tệp Markdown mới trong thư mục `content/notes`
2. Định dạng tên tệp: `YYYY-MM-DD-title.md`
3. Thêm dữ liệu meta vào đầu tệp:

```markdown
---
date: YYYY-MM-DD
---
```

## Cấu hình trang quản trị

Trang quản trị sử dụng GitHub OAuth để xác thực, chỉ chủ sở hữu kho hoặc cộng tác viên mới có thể truy cập.

### 1. Tạo GitHub OAuth App

1. Truy cập [GitHub Settings > Developer settings > OAuth Apps](https://github.com/settings/developers)
2. Nhấn "New OAuth App"
3. Điền thông tin:
   - **Application name**: `Jimmy Blog Admin` (hoặc tên bất kỳ)
   - **Homepage URL**: `https://your-domain.com` (môi trường sản xuất) hoặc `http://localhost:3000` (phát triển cục bộ)
   - **Authorization callback URL**:
     - Môi trường sản xuất: `https://your-domain.com/api/auth/github/callback`
     - Phát triển cục bộ: `http://localhost:3000/api/auth/github/callback`
4. Nhấn "Register application"
5. Ghi lại **Client ID**
6. Nhấn "Generate a new client secret", ghi lại **Client secret**

### 2. Cấu hình biến môi trường

Thêm các biến môi trường sau vào phần cài đặt dự án Vercel:

- `GITHUB_CLIENT_ID`: Client ID của GitHub OAuth App
- `GITHUB_CLIENT_SECRET`: Client Secret của GitHub OAuth App
- `GITHUB_OWNER`: Tên người dùng GitHub (mặc định: `Lily-404`, dùng để xác thực quyền truy cập)
- `GITHUB_REPO`: Tên kho (mặc định: `blog`)
- `GITHUB_REDIRECT_URI`: URL callback của OAuth (tùy chọn, mặc định tự động tạo)
- `NEXT_PUBLIC_BASE_URL`: URL trang web của bạn (dùng để tạo callback URL, bắt buộc phải đặt ở môi trường sản xuất)
  - Môi trường sản xuất: `https://www.jimmy-blog.top`
  - Phát triển cục bộ: `http://localhost:3000`

### 3. Cấu hình phát triển cục bộ

Tạo file `.env.local` ở thư mục gốc của dự án:

```env
GITHUB_CLIENT_ID=你的Client_ID
GITHUB_CLIENT_SECRET=你的Client_Secret
GITHUB_OWNER=Lily-404
GITHUB_REPO=blog
NEXT_PUBLIC_BASE_URL=http://localhost:3000
```

### 4. Cấu hình môi trường sản xuất (Vercel)

Trong phần thiết lập dự án Vercel, hãy đảm bảo thiết lập:

```env
NEXT_PUBLIC_BASE_URL=https://www.jimmy-blog.top
```
⚠️ **Lưu ý**: 
- Tệp `.env.local` đã được thêm vào `.gitignore`, sẽ không bị đẩy lên Git
- Khi phát triển cục bộ, đảm bảo URL callback của OAuth App được đặt là `http://localhost:3000/api/auth/github/callback`
- **Môi trường sản xuất bắt buộc phải đặt `NEXT_PUBLIC_BASE_URL` là `https://www.jimmy-blog.top`**
- URL callback của OAuth App ở môi trường sản xuất nên được đặt là: `https://www.jimmy-blog.top/api/auth/github/callback`

## Triển khai

Dự án đã được cấu hình triển khai trên Vercel, hỗ trợ triển khai tự động. Chỉ cần đẩy mã nguồn lên kho GitHub, Vercel sẽ tự động build và triển khai.

### Ưu điểm khi sử dụng trang quản trị

- ✅ Không cần môi trường phát triển cục bộ
- ✅ Thêm bài viết mọi lúc mọi nơi
- ✅ Tự động kích hoạt Vercel triển khai lại
- ✅ Hoàn toàn miễn phí (GitHub OAuth và Vercel đều trong hạn mức miễn phí)
- ✅ An toàn (Xác thực GitHub OAuth, chỉ chủ kho/kho cộng tác viên mới truy cập được)
- ✅ Không cần quản lý mật khẩu, chỉ cần đăng nhập bằng tài khoản GitHub

## Đóng góp

Hoan nghênh gửi Issue và Pull Request!

## Giấy phép

MIT License



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---