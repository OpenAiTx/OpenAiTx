[![Nuxt banner](https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/banner.svg)](https://nuxt.com)

# Nuxt

<p>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/v/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Version"></a>
  <a href="https://www.npmjs.com/package/nuxt"><img src="https://img.shields.io/npm/dm/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="Downloads"></a>
  <a href="https://github.com/nuxt/nuxt/tree/main/LICENSE"><img src="https://img.shields.io/github/license/nuxt/nuxt.svg?style=flat&colorA=18181B&colorB=28CF8D" alt="License"></a>
  <a href="https://nuxt.com"><img src="https://img.shields.io/badge/Nuxt%20Docs-18181B?logo=nuxt" alt="Website"></a>
  <a href="https://chat.nuxt.dev"><img src="https://img.shields.io/badge/Nuxt%20Discord-18181B?logo=discord" alt="Discord"></a>
  <a href="https://securityscorecards.dev/"><img src="https://api.securityscorecards.dev/projects/github.com/nuxt/nuxt/badge" alt="Nuxt openssf scorecard score"></a>
</p>

Nuxt là một framework miễn phí và mã nguồn mở với cách tiếp cận trực quan và mở rộng để tạo ra các ứng dụng web full-stack và website an toàn kiểu dữ liệu, hiệu năng cao, đạt chuẩn sản xuất với Vue.js.

Nó cung cấp nhiều tính năng giúp dễ dàng xây dựng các ứng dụng web nhanh, thân thiện với SEO và dễ mở rộng, bao gồm:
- Kết xuất phía máy chủ (Server-side rendering), Sinh trang tĩnh (Static Site Generation), Kết xuất lai (Hybrid Rendering) và Kết xuất phía biên (Edge-Side Rendering)
- Định tuyến tự động với tách mã và tải trước (code-splitting và pre-fetching)
- Lấy dữ liệu và quản lý trạng thái
- Tối ưu hóa SEO và định nghĩa thẻ Meta
- Tự động import các components, composables và utils
- TypeScript với cấu hình bằng 0
- Fullstack với thư mục server/
- Mở rộng với [200+ modules](https://nuxt.com/modules)
- Triển khai lên nhiều [nền tảng hosting](https://nuxt.com/deploy)
- ...[và còn nhiều hơn thế nữa](https://nuxt.com) 🚀

### Mục lục

- 🚀 [Bắt Đầu](#getting-started)
- 💻 [Phát Triển Vue](#vue-development)
- 📖 [Tài Liệu](#documentation)
- 🧩 [Modules](#modules)
- ❤️  [Đóng Góp](#contribute)
- 🏠 [Phát Triển Cục Bộ](#local-development)
- 🛟 [Hỗ Trợ Chuyên Nghiệp](#professional-support)
- 🔗 [Theo Dõi Chúng Tôi](#follow-us)
- ⚖️ [Giấy Phép](#license)

---

## <a name="getting-started">🚀 Bắt Đầu</a>

Sử dụng lệnh sau để tạo dự án khởi đầu mới. Lệnh này sẽ tạo một dự án khởi đầu với đầy đủ các tệp và phụ thuộc cần thiết:

```bash
npm create nuxt <my-project>
```

> [!TIP]
> Khám phá thêm [nuxt.new](https://nuxt.new): Mở một dự án Nuxt khởi đầu trên CodeSandbox, StackBlitz hoặc cục bộ để bắt đầu chỉ trong vài giây.

## <a name="vue-development">💻 Phát Triển Vue</a>

Đơn giản, trực quan và mạnh mẽ, Nuxt cho phép bạn viết các component Vue một cách hợp lý. Mọi tác vụ lặp đi lặp lại đều được tự động hóa, vì vậy bạn có thể tập trung xây dựng ứng dụng Vue full-stack với sự tự tin.

Ví dụ về `app.vue`:

```vue
<script setup lang="ts">
useSeoMeta({
  title: 'Meet Nuxt',
  description: 'The Intuitive Vue Framework.'
})
</script>

<template>
  <div id="app">
    <AppHeader />
    <NuxtPage />
    <AppFooter />
  </div>
</template>

<style scoped>
#app {
  background-color: #020420;
  color: #00DC82;
}
</style>
```

## <a name="documentation">📖 Tài Liệu</a>

Chúng tôi khuyến khích bạn nên xem qua [tài liệu Nuxt](https://nuxt.com/docs) để nâng cao kỹ năng. Đây là nguồn tài nguyên tuyệt vời để tìm hiểu thêm về framework, bao gồm từ những bước đầu tiên đến các chủ đề nâng cao.

## <a name="modules">🧩 Modules</a>

Khám phá [danh sách module](https://nuxt.com/modules) để tăng sức mạnh cho dự án Nuxt của bạn, được tạo bởi đội ngũ Nuxt và cộng đồng.

## <a name="contribute">❤️ Đóng Góp</a>

Chúng tôi mời bạn đóng góp và giúp cải thiện Nuxt 💚

Dưới đây là một số cách bạn có thể tham gia:
- **Báo cáo lỗi:** Nếu bạn gặp bất kỳ lỗi hoặc sự cố nào, vui lòng xem [hướng dẫn báo cáo lỗi](https://nuxt.com/docs/community/reporting-bugs) để biết cách gửi báo cáo lỗi.
- **Góp ý:** Có ý tưởng để cải thiện Nuxt? Chúng tôi rất mong nhận được! Xem [hướng dẫn đóng góp](https://nuxt.com/docs/community/contribution) để chia sẻ đề xuất của bạn.
- **Câu hỏi:** Nếu bạn có câu hỏi hoặc cần hỗ trợ, [hướng dẫn trợ giúp](https://nuxt.com/docs/community/getting-help) cung cấp các nguồn lực giúp bạn giải đáp.

## <a name="local-development">🏠 Phát Triển Cục Bộ</a>

Làm theo tài liệu để [Thiết Lập Môi Trường Phát Triển Cục Bộ](https://nuxt.com/docs/community/framework-contribution#setup) nhằm đóng góp cho framework và tài liệu.

## <a name="professional-support">🛟 Hỗ Trợ Chuyên Nghiệp</a>

- Đánh giá kỹ thuật & tư vấn: [Nuxt Experts](https://nuxt.com/enterprise/support)
- Phát triển theo yêu cầu & hơn thế nữa: [Đối Tác Đại Lý Nuxt](https://nuxt.com/enterprise/agencies)

## <a name="follow-us">🔗 Theo Dõi Chúng Tôi</a>

<p valign="center">
  <a href="https://go.nuxt.com/discord"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/discord.svg" alt="Discord"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/x"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/twitter.svg" alt="Twitter"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/github"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/github.svg" alt="GitHub"></a>&nbsp;&nbsp;<a href="https://go.nuxt.com/bluesky"><img width="20px" src="https://raw.githubusercontent.com/nuxt/nuxt/main/.github/assets/bluesky.svg" alt="Bluesky"></a>
</p>

## <a name="license">⚖️ Giấy Phép</a>

[MIT](https://github.com/nuxt/nuxt/tree/main/LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---