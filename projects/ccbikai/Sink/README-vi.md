# ⚡ Sink

**Một trình rút gọn liên kết Đơn giản / Nhanh chóng / Bảo mật với phân tích, vận hành 100% trên Cloudflare.**

<a href="https://trendshift.io/repositories/10421" target="_blank">
  <img
    src="https://trendshift.io/api/badge/repositories/10421"
    alt="ccbikai/Sink | Trendshift"
    width="250"
    height="55"
  />
</a>
<a href="https://news.ycombinator.com/item?id=40843683" target="_blank">
  <img
    src="https://hackernews-badge.vercel.app/api?id=40843683"
    alt="Featured on Hacker News"
    width="250"
    height="55"
  />
</a>
<a href="https://hellogithub.com/repository/57771fd91d1542c7a470959b677a9944" target="_blank">
  <img
    src="https://abroad.hellogithub.com/v1/widgets/recommend.svg?rid=57771fd91d1542c7a470959b677a9944&claim_uid=qi74Zp23wYKeAVB&theme=neutral"
    alt="Featured｜HelloGitHub"
    width="250"
    height="55"
  />
</a>
<a href="https://www.uneed.best/tool/sink" target="_blank">
  <img
    src="https://www.uneed.best/POTW1.png"
    alt="Uneed Badge"
    width="250"
    height="55"
  />
</a>

[<img src="https://devin.ai/assets/deepwiki-badge.png" alt="DeepWiki" height="20"/>](https://deepwiki.com/ccbikai/Sink)
![Cloudflare](https://img.shields.io/badge/Cloudflare-F69652?style=flat&logo=cloudflare&logoColor=white)
![Nuxt](https://img.shields.io/badge/Nuxt-00DC82?style=flat&logo=nuxtdotjs&logoColor=white)
![Tailwind CSS](https://img.shields.io/badge/Tailwind%20CSS-06B6D4?style=flat&logo=tailwindcss&logoColor=white)
![shadcn/ui](https://img.shields.io/badge/shadcn/ui-000000?style=flat&logo=shadcnui&logoColor=white)

![Hero](https://raw.githubusercontent.com/ccbikai/Sink/master/public/image.png)

----

## ✨ Tính năng

- **Rút gọn URL:** Nén các URL của bạn đến độ dài tối thiểu.
- **Phân tích:** Theo dõi số liệu liên kết và thu thập thống kê hữu ích.
- **Không máy chủ (Serverless):** Triển khai mà không cần máy chủ truyền thống.
- **Slug tùy chỉnh:** Hỗ trợ slug cá nhân hóa và phân biệt chữ hoa/thường.
- **🪄 AI Slug:** Tận dụng AI để tạo slug.
- **Hết hạn liên kết:** Đặt ngày hết hạn cho liên kết của bạn.

## 🪧 Bản demo

Trải nghiệm demo tại [Sink.Cool](https://sink.cool/dashboard). Đăng nhập bằng Site Token bên dưới:

```txt
Site Token: SinkCool
```

<details>
  <summary><b>Ảnh chụp màn hình</b></summary>
  <img alt="Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard.png"/>
  <img alt="Links" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_links.png"/>
  <img alt="Link Analytics" src="https://raw.githubusercontent.com/ccbikai/Sink/master/docs/images/sink.cool_dashboard_link_slug.png"/>
</details>

## 🧱 Công nghệ sử dụng

- **Framework**: [Nuxt](https://nuxt.com/)
- **Cơ sở dữ liệu**: [Cloudflare Workers KV](https://developers.cloudflare.com/kv/)
- **Công cụ phân tích**: [Cloudflare Workers Analytics Engine](https://developers.cloudflare.com/analytics/)
- **Thành phần UI**: [shadcn-vue](https://www.shadcn-vue.com/)
- **Thiết kế:** [Tailwind CSS](https://tailwindcss.com/)
- **Triển khai**: [Cloudflare](https://www.cloudflare.com/)

## 🚗 Lộ trình [Đang thực hiện]

Chúng tôi chào đón sự đóng góp và PR từ bạn.

- [x] Tiện ích mở rộng trình duyệt
      - [Sink Tool](https://github.com/zhuzhuyule/sink-extension)
- [x] Tiện ích mở rộng Raycast
      - [Raycast-Sink](https://github.com/foru17/raycast-sink)
- [x] Phím tắt Apple
      - [Sink Shortcuts](https://s.search1api.com/sink001)
- [x] Ứng dụng iOS
      - [Sink](https://apps.apple.com/app/id6745417598)
- [ ] Quản lý liên kết nâng cao (với Cloudflare D1)
- [ ] Nâng cao phân tích (Hỗ trợ kết hợp điều kiện lọc)
- [ ] Tối ưu hiệu năng Dashboard (Tải vô hạn)
- [ ] Kiểm thử đơn vị

## 🏗️ Triển khai

> Video hướng dẫn: [Xem tại đây](https://www.youtube.com/watch?v=MkU23U2VE9E)

Hiện chúng tôi hỗ trợ triển khai trên [Cloudflare Workers](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/workers.md) (khuyến nghị) và [Cloudflare Pages](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/deployment/pages.md).

## ⚒️ Cấu hình

[Tài liệu cấu hình](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/configuration.md)

## 🔌 API

[Tài liệu API](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/api.md)

## 🧰 MCP

Hiện tại chúng tôi chưa hỗ trợ máy chủ MCP gốc, nhưng đã có tài liệu OpenAPI, bạn có thể sử dụng phương pháp sau để hỗ trợ MCP.

> Thay thế tên miền trong `OPENAPI_SPEC_URL` bằng tên miền của bạn.
>
> `API_KEY` giống với `NUXT_SITE_TOKEN` trong biến môi trường.

```json
{
  "mcpServers": {
    "sink": {
      "command": "uvx",
      "args": [
        "mcp-openapi-proxy"
      ],
      "env": {
        "OPENAPI_SPEC_URL": "https://sink.cool/_docs/openapi.json",
        "API_KEY": "SinkCool",
        "TOOL_WHITELIST": "/api/link/create"
      }
    }
  }
}
```

## 🙋🏻 Câu hỏi thường gặp

[Câu hỏi thường gặp](https://raw.githubusercontent.com/ccbikai/Sink/master/docs/faqs.md)

## 💖 Ghi nhận

1. [**Cloudflare**](https://www.cloudflare.com/)
2. [**NuxtHub**](https://hub.nuxt.com/)
3. [**Astroship**](https://astroship.web3templates.com/)

## ☕ Tài trợ

1. [Theo dõi tôi trên X(Twitter)](https://404.li/kai).
2. [Trở thành nhà tài trợ trên GitHub](https://github.com/sponsors/ccbikai).


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---