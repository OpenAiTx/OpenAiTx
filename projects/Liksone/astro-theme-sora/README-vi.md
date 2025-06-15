<div align="center">
<p>
<img src="https://raw.githubusercontent.com/Liksone/astro-theme-sora/main/docs/logo.svg" alt="logo" height="46" />
</p>
<p>Một chủ đề blog Astro</p>
<p>Sora có nghĩa là "穹" (bầu trời), tượng trưng cho khả năng vô hạn và sức sáng tạo rộng lớn</p>
<p>Nếu bạn thích chủ đề này, hãy để lại một 🌟Star nhé!</p>
<p><strong>Tiếng Trung giản thể</strong> | <a href="/README.en.md">English</a></p>
</div>

# Xem trước

[Blog của tôi](https://blog.liks.space)

## Ai đang sử dụng

Chào mừng bạn gửi một [Issue](https://github.com/Liksone/astro-theme-sora/issues/new?template=addWebsite.yml) để giới thiệu website của mình.

# Bắt đầu

1. Cài đặt chủ đề

   - Cài đặt [pnpm](https://pnpm.io/installation)
   - ```bash
     pnpm create astro@latest --template Liksone/astro-theme-sora
     ```

   - Vào thư mục dự án, chạy `pnpm dev` để khởi động dự án

2. Cấu hình chủ đề

   Chỉnh sửa file cấu hình `theme.config.ts` để tùy chỉnh chủ đề. Xem chi tiết tại [Cấu hình](#配置).

3. Chỉnh sửa bài viết

   Chỉnh sửa trong thư mục `src/content/`, hỗ trợ định dạng Markdown.

4. Triển khai website

   Chạy `pnpm build` để build website, sản phẩm build nằm trong thư mục `dist/`. Có thể chạy `pnpm preview` để xem trước website trên máy cục bộ.

   Tự triển khai website lên máy chủ, hoặc tham khảo [Tài liệu Astro](https://docs.astro.build/en/guides/deploy/) để triển khai website lên các nền tảng như Vercel, Netlify, GitHub Pages, v.v.

<!-- # 文档 -->

# Cấu hình

File cấu hình là `theme.config.ts`.

## Thông tin website

```typescript
site: {
  // Địa chỉ website
  url: "https://blog.liks.space",
  // Tiêu đề website
  title: "Sora",
  // Tên chủ website
  author: "Liks",
  // Mô tả website
  description: "A blog theme built with Astro",
  // Biểu tượng website
  // Hỗ trợ định dạng SVG, PNG, ICO
  // Đường dẫn file nội bộ nằm trong thư mục public/
  favicon: "/images/favicon.ico",
}
```

## Thiết lập toàn cục

```typescript
global: {
  // Ảnh đại diện
  // Đường dẫn file nội bộ nằm trong thư mục src/images/
  avatar: "avatar.jpg",
  // Bật RSS
  rss: true,
  // Bật hỗ trợ đa ngôn ngữ (đang phát triển)
  i18n: true,
}
```

## Thanh điều hướng

```typescript
nav: [
  {
    // Tên trang
    name: "Lưu trữ",
    // Địa chỉ trang
    url: "/archives",
  },
  {
    name: "Danh mục",
    url: "/categories",
  },
  {
    name: "Thẻ",
    url: "/tags",
  },
  {
    name: "Giới thiệu",
    url: "/about",
  },
  ...
];
```

## Chân trang

```typescript
footer: {
  // Bản quyền
  copyright: {
    // Thời gian xây dựng website
    time: "2024 - 2025",
    // Chủ sở hữu bản quyền
    owner: "Liks",
  },
  // Đăng ký (dành riêng cho Trung Quốc)
  beian: {
    // Đăng ký ICP
    icp: {
      // Bật
      enabled: false,
      // Số đăng ký
      number: "京 ICP 备 12345678 号",
    },
    // Đăng ký công an
    police: {
      // Bật
      enabled: false,
      // Số đăng ký
      number: "京公网安备 12345678901234 号",
      // Địa chỉ đăng ký
      url: "https://beian.mps.gov.cn/webcode=?",
    },
  },
}
```

## Trang chủ

```typescript
index: {
  // Mạng xã hội
  social: [
    {
      // Tên
      name: "GitHub",
      // Bật
      enabled: true,
      // Địa chỉ
      url: "https://github.com/Liksone",
    },
    ...
  ],
}
```

Hỗ trợ BiliBili, Email, Facebook, GitHub, Instagram, QQ, Telegram, Twitter/X, YouTube, Weibo, Xiaohongshu, Zhihu.

## Trang bài viết

```typescript
post: {
  // Giấy phép bản quyền
  copyright: {
    // Giấy phép CC
    CCLicense: {
      BY: true,
      NC: true,
      SA: true,
      ND: false,
    },
    // Địa chỉ giấy phép
    url: "https://creativecommons.org/licenses/by-nc-sa/4.0",
  },
}
```

## Ủng hộ

```typescript
sponsor: {
  // Bật
  enabled: true,
  // Mã QR Alipay
  alipay: {
    // Bật
    enabled: true,
    // Đường dẫn file nội bộ nằm trong thư mục src/images/
    image: "alipay.png",
  },
  // Mã QR WeChat
  wechat: {
    enabled: false,
  },
  // Hiển thị danh sách ủng hộ
  list: true,
}
```

## Bình luận

```typescript
comment: {
  // Kích hoạt
  enabled: false,
  // Artalk - https://artalk.js.org
  artalk: {
    enabled: false,
    // Địa chỉ máy chủ backend
    server: "https://artalk.example.com",
    // Tên trang web
    site: "Sora",
  },
}
```

## Công cụ

```typescript
tools: {
  // Umami - https://umami.is
  umami: {
    // Kích hoạt
    enabled: false,
    // Địa chỉ máy chủ
    src: "https://cloud.umami.is",
    // data-website-id
    websiteID: "c26d92e7-d859-43be-991c-5a5dd0503eb9",
  },
}
```


# Giấy phép

[GNU General Public License v3.0](https://github.com/Liksone/astro-theme-sora/blob/main/LICENSE)

# Lời cảm ơn

- [Pedro-null/halo-theme-hingle2.0](https://github.com/Pedro-null/halo-theme-hingle2.0)
- [Aziteee/halo-theme-lapis](https://github.com/Aziteee/halo-theme-lapis)
- [纸鹿摸鱼处](https://blog.zhilu.cyou/)
- [HowieHz/halo-theme-higan-hz](https://github.com/HowieHz/halo-theme-higan-hz)
- [saicaca/fuwari](https://github.com/saicaca/fuwari)
- [radishzzz/astro-theme-retypeset](https://github.com/radishzzz/astro-theme-retypeset)
- [EveSunMaple/Frosti](https://github.com/EveSunMaple/Frosti)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---