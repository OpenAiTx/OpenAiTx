<p align="center">
  <a href="https://getbootstrap.com/">
    <img src="https://getbootstrap.com/docs/5.3/assets/brand/bootstrap-logo-shadow.png" alt="Bootstrap logo" width="200" height="165">
  </a>
</p>

<h3 align="center">Bootstrap</h3>

<p align="center">
  Bộ khung giao diện hiện đại, trực quan và mạnh mẽ giúp phát triển web nhanh chóng và dễ dàng hơn.
  <br>
  <a href="https://getbootstrap.com/docs/5.3/"><strong>Khám phá tài liệu Bootstrap »</strong></a>
  <br>
  <br>
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=-&labels=bug&template=bug_report.yml">Báo cáo lỗi</a>
  ·
  <a href="https://github.com/twbs/bootstrap/issues/new?assignees=&labels=feature&template=feature_request.yml">Yêu cầu tính năng</a>
  ·
  <a href="https://themes.getbootstrap.com/">Giao diện</a>
  ·
  <a href="https://blog.getbootstrap.com/">Blog</a>
</p>

## Bootstrap 5

Nhánh mặc định của chúng tôi dành cho phát triển phiên bản Bootstrap 5. Truy cập [`v4-dev` branch](https://github.com/twbs/bootstrap/tree/v4-dev) để xem readme, tài liệu và mã nguồn của Bootstrap 4.

## Mục lục

- [Khởi động nhanh](#quick-start)
- [Trạng thái](#status)
- [Bao gồm những gì](#whats-included)
- [Báo lỗi và yêu cầu tính năng](#bugs-and-feature-requests)
- [Tài liệu](#documentation)
- [Đóng góp](#contributing)
- [Cộng đồng](#community)
- [Quản lý phiên bản](#versioning)
- [Tác giả](#creators)
- [Cảm ơn](#thanks)
- [Bản quyền và giấy phép](#copyright-and-license)

## Khởi động nhanh

Có nhiều lựa chọn khởi động nhanh:

- [Tải bản phát hành mới nhất](https://github.com/twbs/bootstrap/archive/v5.3.6.zip)
- Clone repo: `git clone https://github.com/twbs/bootstrap.git`
- Cài đặt với [npm](https://www.npmjs.com/): `npm install bootstrap@v5.3.6`
- Cài đặt với [yarn](https://yarnpkg.com/): `yarn add bootstrap@v5.3.6`
- Cài đặt với [Bun](https://bun.sh/): `bun add bootstrap@v5.3.6`
- Cài đặt với [Composer](https://getcomposer.org/): `composer require twbs/bootstrap:5.3.6`
- Cài đặt với [NuGet](https://www.nuget.org/): CSS: `Install-Package bootstrap` Sass: `Install-Package bootstrap.sass`

Đọc [Trang bắt đầu](https://getbootstrap.com/docs/5.3/getting-started/introduction/) để biết thông tin về nội dung framework, mẫu, ví dụ và nhiều hơn nữa.

## Trạng thái

[![Build Status](https://img.shields.io/github/actions/workflow/status/twbs/bootstrap/js.yml?branch=main&label=JS%20Tests&logo=github)](https://github.com/twbs/bootstrap/actions/workflows/js.yml?query=workflow%3AJS+branch%3Amain)
[![npm version](https://img.shields.io/npm/v/bootstrap?logo=npm&logoColor=fff)](https://www.npmjs.com/package/bootstrap)
[![Gem version](https://img.shields.io/gem/v/bootstrap?logo=rubygems&logoColor=fff)](https://rubygems.org/gems/bootstrap)
[![Meteor Atmosphere](https://img.shields.io/badge/meteor-twbs%3Abootstrap-blue?logo=meteor&logoColor=fff)](https://atmospherejs.com/twbs/bootstrap)
[![Packagist Prerelease](https://img.shields.io/packagist/vpre/twbs/bootstrap?logo=packagist&logoColor=fff)](https://packagist.org/packages/twbs/bootstrap)
[![NuGet](https://img.shields.io/nuget/vpre/bootstrap?logo=nuget&logoColor=fff)](https://www.nuget.org/packages/bootstrap/absoluteLatest)
[![Coverage Status](https://img.shields.io/coveralls/github/twbs/bootstrap/main?logo=coveralls&logoColor=fff)](https://coveralls.io/github/twbs/bootstrap?branch=main)
[![CSS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=gzip&label=CSS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![CSS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/css/bootstrap.min.css?compression=brotli&label=CSS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/css/bootstrap.min.css)
[![JS gzip size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=gzip&label=JS%20gzip%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![JS Brotli size](https://img.badgesize.io/twbs/bootstrap/main/dist/js/bootstrap.min.js?compression=brotli&label=JS%20Brotli%20size)](https://github.com/twbs/bootstrap/blob/main/dist/js/bootstrap.min.js)
[![Backers on Open Collective](https://img.shields.io/opencollective/backers/bootstrap?logo=opencollective&logoColor=fff)](#backers)
[![Sponsors on Open Collective](https://img.shields.io/opencollective/sponsors/bootstrap?logo=opencollective&logoColor=fff)](#sponsors)

## Bao gồm những gì

Trong bản tải xuống, bạn sẽ tìm thấy các thư mục và tệp sau, được nhóm hợp lý theo từng loại tài nguyên và cung cấp cả phiên bản đã biên dịch và rút gọn.

<details>
  <summary>Nội dung tải về</summary>

  ```text
  bootstrap/
  ├── css/
  │   ├── bootstrap-grid.css
  │   ├── bootstrap-grid.css.map
  │   ├── bootstrap-grid.min.css
  │   ├── bootstrap-grid.min.css.map
  │   ├── bootstrap-grid.rtl.css
  │   ├── bootstrap-grid.rtl.css.map
  │   ├── bootstrap-grid.rtl.min.css
  │   ├── bootstrap-grid.rtl.min.css.map
  │   ├── bootstrap-reboot.css
  │   ├── bootstrap-reboot.css.map
  │   ├── bootstrap-reboot.min.css
  │   ├── bootstrap-reboot.min.css.map
  │   ├── bootstrap-reboot.rtl.css
  │   ├── bootstrap-reboot.rtl.css.map
  │   ├── bootstrap-reboot.rtl.min.css
  │   ├── bootstrap-reboot.rtl.min.css.map
  │   ├── bootstrap-utilities.css
  │   ├── bootstrap-utilities.css.map
  │   ├── bootstrap-utilities.min.css
  │   ├── bootstrap-utilities.min.css.map
  │   ├── bootstrap-utilities.rtl.css
  │   ├── bootstrap-utilities.rtl.css.map
  │   ├── bootstrap-utilities.rtl.min.css
  │   ├── bootstrap-utilities.rtl.min.css.map
  │   ├── bootstrap.css
  │   ├── bootstrap.css.map
  │   ├── bootstrap.min.css
  │   ├── bootstrap.min.css.map
  │   ├── bootstrap.rtl.css
  │   ├── bootstrap.rtl.css.map
  │   ├── bootstrap.rtl.min.css
  │   └── bootstrap.rtl.min.css.map
  └── js/
      ├── bootstrap.bundle.js
      ├── bootstrap.bundle.js.map
      ├── bootstrap.bundle.min.js
      ├── bootstrap.bundle.min.js.map
      ├── bootstrap.esm.js
      ├── bootstrap.esm.js.map
      ├── bootstrap.esm.min.js
      ├── bootstrap.esm.min.js.map
      ├── bootstrap.js
      ├── bootstrap.js.map
      ├── bootstrap.min.js
      └── bootstrap.min.js.map
  ```
</details>

Chúng tôi cung cấp CSS và JS đã biên dịch (`bootstrap.*`), cũng như CSS và JS đã biên dịch và rút gọn (`bootstrap.min.*`). [Source map](https://web.dev/articles/source-maps) (`bootstrap.*.map`) có sẵn để sử dụng với các công cụ dành cho nhà phát triển trên một số trình duyệt nhất định. Các tệp JS gói sẵn (`bootstrap.bundle.js` và bản rút gọn `bootstrap.bundle.min.js`) bao gồm cả [Popper](https://popper.js.org/docs/v2/).

## Báo lỗi và yêu cầu tính năng

Bạn gặp lỗi hoặc có yêu cầu tính năng? Vui lòng đọc trước [hướng dẫn về issue](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md#using-the-issue-tracker) và tìm kiếm các vấn đề đã tồn tại hoặc đã đóng. Nếu vấn đề hoặc ý tưởng của bạn chưa được đề cập, [hãy tạo issue mới](https://github.com/twbs/bootstrap/issues/new/choose).

## Tài liệu

Tài liệu của Bootstrap, được bao gồm trong repo này tại thư mục gốc, được xây dựng bằng [Astro](https://astro.build/) và được công khai trên GitHub Pages tại <https://getbootstrap.com/>. Tài liệu cũng có thể chạy cục bộ.

Chức năng tìm kiếm tài liệu được cung cấp bởi [Algolia's DocSearch](https://docsearch.algolia.com/).

### Chạy tài liệu cục bộ

1. Chạy `npm install` để cài các phụ thuộc Node.js, bao gồm Astro (trình tạo trang).
2. Chạy `npm run test` (hoặc script npm cụ thể) để biên dịch lại các tệp CSS và JavaScript phân phối, cũng như tài sản tài liệu.
3. Từ thư mục gốc `/bootstrap`, chạy `npm run docs-serve` trong dòng lệnh.
4. Mở `http://localhost:9001/` trên trình duyệt, và xong.

Tìm hiểu thêm về cách sử dụng Astro bằng cách đọc [tài liệu](https://docs.astro.build/en/getting-started/) của nó.

### Tài liệu cho các bản phát hành trước

Bạn có thể tìm tất cả tài liệu các bản phát hành trước tại <https://getbootstrap.com/docs/versions/>.

[Các bản phát hành trước](https://github.com/twbs/bootstrap/releases) và tài liệu của chúng cũng có sẵn để tải về.

## Đóng góp

Vui lòng đọc kỹ [hướng dẫn đóng góp](https://github.com/twbs/bootstrap/blob/main/.github/CONTRIBUTING.md) của chúng tôi. Trong đó bao gồm hướng dẫn mở issue, tiêu chuẩn mã hóa, và ghi chú phát triển.

Ngoài ra, nếu pull request của bạn chứa bản vá hoặc tính năng JavaScript, bạn phải đính kèm [unit test liên quan](https://github.com/twbs/bootstrap/tree/main/js/tests). Tất cả HTML và CSS cần tuân thủ [Code Guide](https://github.com/mdo/code-guide), được duy trì bởi [Mark Otto](https://github.com/mdo).

Tùy chỉnh trình soạn thảo có tại [editor config](https://github.com/twbs/bootstrap/blob/main/.editorconfig) để dễ dàng sử dụng trong các trình soạn thảo văn bản phổ biến. Đọc thêm và tải plugin tại <https://editorconfig.org/>.

## Cộng đồng

Nhận cập nhật về quá trình phát triển của Bootstrap và trò chuyện với các quản trị viên dự án cũng như các thành viên cộng đồng.

- Theo dõi [@getbootstrap trên X](https://x.com/getbootstrap).
- Đọc và đăng ký [Blog chính thức của Bootstrap](https://blog.getbootstrap.com/).
- Đặt câu hỏi và khám phá [GitHub Discussions của chúng tôi](https://github.com/twbs/bootstrap/discussions).
- Thảo luận, đặt câu hỏi và hơn thế nữa trên [Discord cộng đồng](https://discord.gg/bZUvakRU3M) hoặc [Bootstrap subreddit](https://www.reddit.com/r/bootstrap/).
- Trò chuyện với các Bootstrappers khác trên IRC. Trên máy chủ `irc.libera.chat`, kênh `#bootstrap`.
- Hỗ trợ triển khai có thể tìm thấy tại Stack Overflow (tag [`bootstrap-5`](https://stackoverflow.com/questions/tagged/bootstrap-5)).
- Các nhà phát triển nên sử dụng từ khóa `bootstrap` trên các package mở rộng hoặc bổ sung chức năng cho Bootstrap khi phân phối qua [npm](https://www.npmjs.com/browse/keyword/bootstrap) hoặc các phương thức phân phối tương tự để tối đa hóa khả năng tìm kiếm.

## Quản lý phiên bản

Để minh bạch về chu kỳ phát hành và duy trì khả năng tương thích ngược, Bootstrap được duy trì theo [hướng dẫn Semantic Versioning](https://semver.org/). Đôi khi chúng tôi mắc lỗi, nhưng luôn cố gắng tuân thủ các quy tắc đó bất cứ khi nào có thể.

Xem [phần Releases của dự án GitHub](https://github.com/twbs/bootstrap/releases) để xem nhật ký thay đổi của từng phiên bản Bootstrap. Các bài đăng thông báo phát hành trên [blog chính thức của Bootstrap](https://blog.getbootstrap.com/) chứa tóm tắt các thay đổi nổi bật nhất trong mỗi bản phát hành.

## Tác giả

**Mark Otto**

- <https://x.com/mdo>
- <https://github.com/mdo>

**Jacob Thornton**

- <https://x.com/fat>
- <https://github.com/fat>

## Cảm ơn

<a href="https://www.browserstack.com/">
  <img src="https://live.browserstack.com/images/opensource/browserstack-logo.svg" alt="BrowserStack" width="192" height="42">
</a>

Cảm ơn [BrowserStack](https://www.browserstack.com/) đã cung cấp hạ tầng giúp chúng tôi kiểm thử trên các trình duyệt thực tế!

<a href="https://www.netlify.com/">
  <img src="https://www.netlify.com/v3/img/components/full-logo-light.svg" alt="Netlify" width="147" height="40">
</a>

Cảm ơn [Netlify](https://www.netlify.com/) đã cung cấp Deploy Previews cho chúng tôi!

## Nhà tài trợ

Hỗ trợ dự án này bằng cách trở thành nhà tài trợ. Logo của bạn sẽ xuất hiện ở đây với liên kết đến trang web của bạn. [[Trở thành nhà tài trợ](https://opencollective.com/bootstrap#sponsor)]

[![OC sponsor 0](https://opencollective.com/bootstrap/sponsor/0/avatar.svg)](https://opencollective.com/bootstrap/sponsor/0/website)
[![OC sponsor 1](https://opencollective.com/bootstrap/sponsor/1/avatar.svg)](https://opencollective.com/bootstrap/sponsor/1/website)
[![OC sponsor 2](https://opencollective.com/bootstrap/sponsor/2/avatar.svg)](https://opencollective.com/bootstrap/sponsor/2/website)
[![OC sponsor 3](https://opencollective.com/bootstrap/sponsor/3/avatar.svg)](https://opencollective.com/bootstrap/sponsor/3/website)
[![OC sponsor 4](https://opencollective.com/bootstrap/sponsor/4/avatar.svg)](https://opencollective.com/bootstrap/sponsor/4/website)
[![OC sponsor 5](https://opencollective.com/bootstrap/sponsor/5/avatar.svg)](https://opencollective.com/bootstrap/sponsor/5/website)
[![OC sponsor 6](https://opencollective.com/bootstrap/sponsor/6/avatar.svg)](https://opencollective.com/bootstrap/sponsor/6/website)
[![OC sponsor 7](https://opencollective.com/bootstrap/sponsor/7/avatar.svg)](https://opencollective.com/bootstrap/sponsor/7/website)
[![OC sponsor 8](https://opencollective.com/bootstrap/sponsor/8/avatar.svg)](https://opencollective.com/bootstrap/sponsor/8/website)
[![OC sponsor 9](https://opencollective.com/bootstrap/sponsor/9/avatar.svg)](https://opencollective.com/bootstrap/sponsor/9/website)

## Người ủng hộ

Cảm ơn tất cả những người đã ủng hộ chúng tôi! 🙏 [[Trở thành người ủng hộ](https://opencollective.com/bootstrap#backer)]

[![Backers](https://opencollective.com/bootstrap/backers.svg?width=890)](https://opencollective.com/bootstrap#backers)

## Bản quyền và giấy phép

Mã nguồn và tài liệu thuộc bản quyền 2011-2025 của [Các tác giả Bootstrap](https://github.com/twbs/bootstrap/graphs/contributors). Mã nguồn được phát hành theo [Giấy phép MIT](https://github.com/twbs/bootstrap/blob/main/LICENSE). Tài liệu được phát hành theo [Creative Commons](https://creativecommons.org/licenses/by/3.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---