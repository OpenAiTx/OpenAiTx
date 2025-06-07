<a href="https://excalidraw.com/" target="_blank" rel="noopener">
  <picture>
    <source media="(prefers-color-scheme: dark)" alt="Excalidraw" srcset="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2_dark.png" />
    <img alt="Excalidraw" src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github/excalidraw_github_cover_2.png" />
  </picture>
</a>

<h4 align="center">
  <a href="https://excalidraw.com">Trình biên tập Excalidraw</a> |
  <a href="https://plus.excalidraw.com/blog">Blog</a> |
  <a href="https://docs.excalidraw.com">Tài liệu hướng dẫn</a> |
  <a href="https://plus.excalidraw.com">Excalidraw+</a>
</h4>

<div align="center">
  <h2>
    Bảng trắng ảo mã nguồn mở với phong cách vẽ tay. </br>
    Hỗ trợ cộng tác và mã hóa đầu-cuối. </br>
  <br />
  </h2>
</div>

<br />
<p align="center">
  <a href="https://github.com/excalidraw/excalidraw/blob/master/LICENSE">
    <img alt="Excalidraw được phát hành dưới giấy phép MIT." src="https://img.shields.io/badge/license-MIT-blue.svg"  />
  </a>
  <a href="https://www.npmjs.com/package/@excalidraw/excalidraw">
    <img alt="npm downloads/month" src="https://img.shields.io/npm/dm/@excalidraw/excalidraw"  />
  </a>
  <a href="https://docs.excalidraw.com/docs/introduction/contributing">
    <img alt="PRs welcome!" src="https://img.shields.io/badge/PRs-welcome-brightgreen.svg?style=flat"  />
  </a>
  <a href="https://discord.gg/UexuTaE">
    <img alt="Chat trên Discord" src="https://img.shields.io/discord/723672430744174682?color=738ad6&label=Chat%20on%20Discord&logo=discord&logoColor=ffffff&widge=false"/>
  </a>
  <a href="https://deepwiki.com/excalidraw/excalidraw">
    <img alt="Hỏi DeepWiki" src="https://deepwiki.com/badge.svg" />
  </a>
  <a href="https://twitter.com/excalidraw">
    <img alt="Theo dõi Excalidraw trên Twitter" src="https://img.shields.io/twitter/follow/excalidraw.svg?label=follow+@excalidraw&style=social&logo=twitter"/>
  </a>
</p>

<div align="center">
  <figure>
    <a href="https://excalidraw.com" target="_blank" rel="noopener">
      <img src="https://excalidraw.nyc3.cdn.digitaloceanspaces.com/github%2Fproduct_showcase.png" alt="Product showcase" />
    </a>
    <figcaption>
      <p align="center">
        Tạo sơ đồ, wireframe phong cách vẽ tay đẹp mắt hoặc bất cứ điều gì bạn thích.
      </p>
    </figcaption>
  </figure>
</div>

## Tính năng

Trình biên tập Excalidraw (gói npm) hỗ trợ:

- 💯&nbsp;Miễn phí & mã nguồn mở.
- 🎨&nbsp;Bảng trắng vô hạn dựa trên canvas.
- ✍️&nbsp;Phong cách vẽ tay.
- 🌓&nbsp;Chế độ tối.
- 🏗️&nbsp;Tùy biến linh hoạt.
- 📷&nbsp;Hỗ trợ hình ảnh.
- 😀&nbsp;Hỗ trợ thư viện hình dạng.
- 🌐&nbsp;Hỗ trợ đa ngôn ngữ (i18n).
- 🖼️&nbsp;Xuất ra PNG, SVG & clipboard.
- 💾&nbsp;Định dạng mở - xuất bản vẽ dưới dạng tệp json `.excalidraw`.
- ⚒️&nbsp;Đa dạng công cụ - hình chữ nhật, hình tròn, hình thoi, mũi tên, đường thẳng, vẽ tự do, tẩy...
- ➡️&nbsp;Mũi tên liên kết & mũi tên có nhãn.
- 🔙&nbsp;Hoàn tác / Làm lại.
- 🔍&nbsp;Hỗ trợ phóng to và di chuyển.

## Excalidraw.com

Ứng dụng được lưu trữ tại [excalidraw.com](https://excalidraw.com) là một bản trình diễn tối giản những gì bạn có thể xây dựng với Excalidraw. [Mã nguồn](https://github.com/excalidraw/excalidraw/tree/master/excalidraw-app) của ứng dụng này cũng là một phần trong kho lưu trữ này, với các tính năng:

- 📡&nbsp;Hỗ trợ PWA (hoạt động ngoại tuyến).
- 🤼&nbsp;Cộng tác thời gian thực.
- 🔒&nbsp;Mã hóa đầu-cuối.
- 💾&nbsp;Ưu tiên lưu trữ cục bộ (tự động lưu vào trình duyệt).
- 🔗&nbsp;Liên kết chia sẻ (xuất ra liên kết chỉ đọc có thể chia sẻ cho người khác).

Chúng tôi sẽ bổ sung các tính năng này dưới dạng plugin cho gói npm trong tương lai.

## Bắt đầu nhanh

**Lưu ý:** hướng dẫn sau dành cho việc cài đặt [gói npm Excalidraw](https://www.npmjs.com/package/@excalidraw/excalidraw) khi tích hợp Excalidraw vào ứng dụng của bạn. Để chạy kho lưu trữ này trên máy để phát triển, vui lòng tham khảo [Hướng dẫn phát triển](https://docs.excalidraw.com/docs/introduction/development) của chúng tôi.

Sử dụng `npm` hoặc `yarn` để cài đặt gói.

```bash
npm install react react-dom @excalidraw/excalidraw
# hoặc
yarn add react react-dom @excalidraw/excalidraw
```

Xem thêm chi tiết tại [tài liệu hướng dẫn](https://docs.excalidraw.com/docs/@excalidraw/excalidraw/installation)!

## Đóng góp

- Thiếu tính năng hoặc phát hiện lỗi? [Báo cáo tại đây](https://github.com/excalidraw/excalidraw/issues).
- Muốn đóng góp? Xem [hướng dẫn đóng góp](https://docs.excalidraw.com/docs/introduction/contributing) hoặc liên hệ với chúng tôi trên [Discord](https://discord.gg/UexuTaE).
- Muốn hỗ trợ dịch thuật? Xem [hướng dẫn dịch thuật](https://docs.excalidraw.com/docs/introduction/contributing#translating).

## Tích hợp

- [Tiện ích mở rộng VScode](https://marketplace.visualstudio.com/items?itemName=pomdtr.excalidraw-editor)
- [Gói npm](https://www.npmjs.com/package/@excalidraw/excalidraw)

## Ai đang tích hợp Excalidraw

[Google Cloud](https://googlecloudcheatsheet.withgoogle.com/architecture) • [Meta](https://meta.com/) • [CodeSandbox](https://codesandbox.io/) • [Obsidian Excalidraw](https://github.com/zsviczian/obsidian-excalidraw-plugin) • [Replit](https://replit.com/) • [Slite](https://slite.com/) • [Notion](https://notion.so/) • [HackerRank](https://www.hackerrank.com/) • và nhiều đơn vị khác

## Nhà tài trợ & hỗ trợ

Nếu bạn yêu thích dự án này, bạn có thể trở thành nhà tài trợ tại [Open Collective](https://opencollective.com/excalidraw) hoặc sử dụng [Excalidraw+](https://plus.excalidraw.com/).

## Cảm ơn bạn đã ủng hộ Excalidraw

[<img src="https://opencollective.com/excalidraw/tiers/sponsors/0/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/0/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/1/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/1/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/2/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/2/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/3/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/3/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/4/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/4/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/5/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/5/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/6/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/6/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/7/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/7/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/8/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/8/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/9/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/9/website) [<img src="https://opencollective.com/excalidraw/tiers/sponsors/10/avatar.svg?avatarHeight=120"/>](https://opencollective.com/excalidraw/tiers/sponsors/10/website)

<a href="https://opencollective.com/excalidraw#category-CONTRIBUTE" target="_blank"><img src="https://opencollective.com/excalidraw/tiers/backers.svg?avatarHeight=32"/></a>

Cuối cùng nhưng không kém phần quan trọng, chúng tôi xin cảm ơn các công ty này đã cung cấp dịch vụ miễn phí:

[![Vercel](./.github/assets/vercel.svg)](https://vercel.com) [![Sentry](./.github/assets/sentry.svg)](https://sentry.io) [![Crowdin](./.github/assets/crowdin.svg)](https://crowdin.com)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---