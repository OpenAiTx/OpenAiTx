# Deno

[![](https://img.shields.io/crates/v/deno.svg)](https://crates.io/crates/deno)
[![Twitter badge][]][Twitter link] [![Bluesky badge][]][Bluesky link]
[![Discord badge][]][Discord link] [![YouTube badge][]][YouTube link]

<img align="right" src="https://deno.land/logo.svg" height="150px" alt="the deno mascot dinosaur standing in the rain">

[Deno](https://deno.com)
([/ˈdiːnoʊ/](https://ipa-reader.com/?text=%CB%88di%CB%90no%CA%8A), phát âm là
`dee-no`) là một môi trường thực thi JavaScript, TypeScript và WebAssembly với các thiết lập mặc định an toàn và mang lại trải nghiệm tuyệt vời cho nhà phát triển. Nó được xây dựng trên nền tảng [V8](https://v8.dev/),
[Rust](https://www.rust-lang.org/), và [Tokio](https://tokio.rs/).

Tìm hiểu thêm về môi trường runtime Deno
[trong tài liệu hướng dẫn](https://docs.deno.com/runtime/manual).

## Cài đặt

Cài đặt môi trường runtime Deno trên hệ thống của bạn bằng một trong các lệnh dưới đây. Lưu ý rằng có nhiều cách để cài đặt Deno - danh sách đầy đủ các tùy chọn cài đặt có thể tìm thấy
[tại đây](https://docs.deno.com/runtime/manual/getting_started/installation).

Shell (Mac, Linux):

```sh
curl -fsSL https://deno.land/install.sh | sh
```

PowerShell (Windows):

```powershell
irm https://deno.land/install.ps1 | iex
```

[Homebrew](https://formulae.brew.sh/formula/deno) (Mac):

```sh
brew install deno
```

[Chocolatey](https://chocolatey.org/packages/deno) (Windows):

```powershell
choco install deno
```

[WinGet](https://winstall.app/apps/DenoLand.Deno) (Windows):

```powershell
winget install --id=DenoLand.Deno
```

### Biên dịch và cài đặt từ mã nguồn

Hướng dẫn đầy đủ để xây dựng Deno từ mã nguồn có thể được tìm thấy
[tại đây](https://github.com/denoland/deno/blob/main/.github/CONTRIBUTING.md#building-from-source).

## Chương trình Deno đầu tiên của bạn

Deno có thể được sử dụng cho nhiều ứng dụng khác nhau, nhưng phổ biến nhất là để xây dựng máy chủ web. Hãy tạo một tệp tên là `server.ts` và thêm đoạn mã TypeScript sau:

```ts
Deno.serve((_req: Request) => {
  return new Response("Hello, world!");
});
```

Chạy máy chủ của bạn bằng lệnh sau:

```sh
deno run --allow-net server.ts
```

Lệnh này sẽ khởi động một máy chủ web cục bộ tại
[http://localhost:8000](http://localhost:8000).

Tìm hiểu thêm về cách viết và chạy chương trình Deno
[trong tài liệu](https://docs.deno.com/runtime/manual).

## Tài nguyên bổ sung

- **[Deno Docs](https://docs.deno.com)**: hướng dẫn chính thức và tài liệu tham khảo cho môi trường runtime Deno, [Deno Deploy](https://deno.com/deploy), và nhiều hơn nữa.
- **[Deno Standard Library](https://jsr.io/@std)**: các tiện ích chung được hỗ trợ chính thức cho các chương trình Deno.
- **[JSR](https://jsr.io/)**: Kho lưu trữ gói nguồn mở cho JavaScript và TypeScript hiện đại.
- **[Developer Blog](https://deno.com/blog)**: Cập nhật sản phẩm, hướng dẫn và nhiều nội dung khác từ đội ngũ Deno.

## Đóng góp

Chúng tôi rất trân trọng sự đóng góp của bạn! Để tham gia đóng góp, vui lòng đọc
[hướng dẫn đóng góp](.github/CONTRIBUTING.md) của chúng tôi.

[Build status - Cirrus]: https://github.com/denoland/deno/workflows/ci/badge.svg?branch=main&event=push
[Build status]: https://github.com/denoland/deno/actions
[Twitter badge]: https://img.shields.io/twitter/follow/deno_land.svg?style=social&label=Follow
[Twitter link]: https://twitter.com/intent/follow?screen_name=deno_land
[Bluesky badge]: https://img.shields.io/badge/Follow-whitesmoke?logo=bluesky
[Bluesky link]: https://bsky.app/profile/deno.land
[YouTube badge]: https://img.shields.io/youtube/channel/subscribers/UCqC2G2M-rg4fzg1esKFLFIw?style=social
[YouTube link]: https://www.youtube.com/@deno_land
[Discord badge]: https://img.shields.io/discord/684898665143206084?logo=discord&style=social
[Discord link]: https://discord.gg/deno

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---