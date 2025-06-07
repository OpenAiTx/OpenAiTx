<p align="center">
  <img width="320" src="https://wpimg.wallstcn.com/ecc53a42-d79b-42e2-8852-5126b810a4c8.svg">
</p>

<p align="center">
  <a href="https://github.com/vuejs/vue">
    <img src="https://img.shields.io/badge/vue-2.6.10-brightgreen.svg" alt="vue">
  </a>
  <a href="https://github.com/ElemeFE/element">
    <img src="https://img.shields.io/badge/element--ui-2.7.0-brightgreen.svg" alt="element-ui">
  </a>
  <a href="https://travis-ci.org/PanJiaChen/vue-element-admin" rel="nofollow">
    <img src="https://travis-ci.org/PanJiaChen/vue-element-admin.svg?branch=master" alt="Build Status">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE">
    <img src="https://img.shields.io/github/license/mashape/apistatus.svg" alt="license">
  </a>
  <a href="https://github.com/PanJiaChen/vue-element-admin/releases">
    <img src="https://img.shields.io/github/release/PanJiaChen/vue-element-admin.svg" alt="GitHub release">
  </a>
  <a href="https://gitter.im/vue-element-admin/discuss">
    <img src="https://badges.gitter.im/Join%20Chat.svg" alt="gitter">
  </a>
  <a href="https://panjiachen.github.io/vue-element-admin-site/donate">
    <img src="https://img.shields.io/badge/%24-donate-ff69b4.svg" alt="donate">
  </a>
</p>

English | [简体中文](./README.zh-CN.md) | [日本語](./README.ja.md) | [Spanish](./README.es.md)

<!-- <p align="center">
  <b>SPONSORED BY</b>
</p>
<table align="center" cellspacing="0" cellpadding="0">
  <tbody>
    <tr>
      <td align="center" valign="middle">
       <a href="" title="" target="_blank" style="padding-right: 20px;">
        <img height="200px" style="padding-right: 20px;" src="" title="variantForm">
        </a>
      </td>
    </tr>
  </tbody> 
</table>-->

## Giới thiệu

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) là một giải pháp giao diện quản trị front-end sẵn sàng cho sản xuất. Nó được xây dựng dựa trên [vue](https://github.com/vuejs/vue) và sử dụng bộ công cụ giao diện [element-ui](https://github.com/ElemeFE/element).

[vue-element-admin](https://panjiachen.github.io/vue-element-admin) dựa trên stack phát triển mới nhất của vue và tích hợp sẵn giải pháp i18n, các mẫu template điển hình cho ứng dụng doanh nghiệp, cùng nhiều tính năng tuyệt vời. Nó giúp bạn xây dựng các ứng dụng đơn trang (SPA) lớn và phức tạp. Dù nhu cầu của bạn là gì, tôi tin rằng dự án này sẽ giúp ích cho bạn.

- [Xem trước](https://panjiachen.github.io/vue-element-admin)

- [Tài liệu](https://panjiachen.github.io/vue-element-admin-site/)

- [Gitter](https://gitter.im/vue-element-admin/discuss)

- [Ủng hộ](https://panjiachen.github.io/vue-element-admin-site/donate/)

- [Wiki](https://github.com/PanJiaChen/vue-element-admin/wiki)

- [Gitee](https://panjiachen.gitee.io/vue-element-admin/) Người dùng trong nước có thể truy cập địa chỉ này để xem trực tuyến

- Mẫu cơ bản khuyến nghị sử dụng: [vue-admin-template](https://github.com/PanJiaChen/vue-admin-template)
- Desktop: [electron-vue-admin](https://github.com/PanJiaChen/electron-vue-admin)
- Typescript: [vue-typescript-admin-template](https://github.com/Armour/vue-typescript-admin-template) (Cảm ơn: [@Armour](https://github.com/Armour))
- [awesome-project](https://github.com/PanJiaChen/vue-element-admin/issues/2312)

**Từ phiên bản `v4.1.0+`, nhánh master mặc định sẽ không hỗ trợ i18n. Vui lòng sử dụng [nhánh i18n](https://github.com/PanJiaChen/vue-element-admin/tree/i18n), nhánh này sẽ cập nhật cùng master**

**Phiên bản hiện tại là `v4.0+` xây dựng trên `vue-cli`. Nếu bạn phát hiện vấn đề, vui lòng gửi [issue](https://github.com/PanJiaChen/vue-element-admin/issues/new). Nếu muốn dùng phiên bản cũ, bạn có thể chuyển sang [tag/3.11.0](https://github.com/PanJiaChen/vue-element-admin/tree/tag/3.11.0), phiên bản này không phụ thuộc vào `vue-cli`**

**Dự án này không hỗ trợ các trình duyệt phiên bản thấp (ví dụ: IE). Vui lòng tự thêm polyfill nếu cần.**

## Chuẩn bị

Bạn cần cài đặt [node](https://nodejs.org/) và [git](https://git-scm.com/) trên máy tính. Dự án sử dụng [ES2015+](https://es6.ruanyifeng.com/), [vue](https://cn.vuejs.org/index.html), [vuex](https://vuex.vuejs.org/zh-cn/), [vue-router](https://router.vuejs.org/zh-cn/), [vue-cli](https://github.com/vuejs/vue-cli), [axios](https://github.com/axios/axios) và [element-ui](https://github.com/ElemeFE/element), tất cả dữ liệu yêu cầu đều được mô phỏng bằng [Mock.js](https://github.com/nuysoft/Mock).
Việc hiểu và học trước các kiến thức này sẽ giúp bạn sử dụng dự án dễ dàng hơn rất nhiều.

[![Chỉnh sửa trên CodeSandbox](https://codesandbox.io/static/img/play-codesandbox.svg)](https://codesandbox.io/s/github/PanJiaChen/vue-element-admin/tree/CodeSandbox)

<p align="center">
  <img width="900" src="https://wpimg.wallstcn.com/a5894c1b-f6af-456e-82df-1151da0839bf.png">
</p>

## Nhà tài trợ

Trở thành nhà tài trợ và có logo của bạn xuất hiện trên README của chúng tôi trên GitHub cùng liên kết tới trang web của bạn. [[Trở thành nhà tài trợ]](https://www.patreon.com/panjiachen)

### Akveo
<a href="https://store.akveo.com/products/vue-java-admin-dashboard-spring?utm_campaign=akveo_store-Vue-Vue_demo%2Fgithub&utm_source=vue_admin&utm_medium=referral&utm_content=github_banner"><img width="500px" src="https://raw.githubusercontent.com/PanJiaChen/vue-element-admin-site/master/docs/.vuepress/public/images/vue-java-banner.png" /></a><p>Nhận backend Java cho Vue admin với giảm giá 20%, chỉ còn 39$ khi sử dụng mã giảm giá SWB0RAZPZR1M
</p>

### Flatlogic

<a href="https://flatlogic.com/admin-dashboards?from=vue-element-admin"><img width="150px" src="https://wpimg.wallstcn.com/9c0b719b-5551-4c1e-b776-63994632d94a.png" /></a><p>Các mẫu Dashboard quản trị được làm với Vue, React và Angular.</p>

## Tính năng

```
- Đăng nhập / Đăng xuất

- Xác thực phân quyền
  - Phân quyền trang
  - Phân quyền chỉ thị
  - Trang cấu hình quyền hạn
  - Đăng nhập hai bước

- Xây dựng đa môi trường
  - Phát triển (dev)
  - sit
  - Kiểm thử giai đoạn (stage)
  - Sản xuất (prod)

- Tính năng toàn cục
  - I18n
  - Nhiều chủ đề động
  - Thanh điều hướng động (hỗ trợ định tuyến đa cấp)
  - Breadcrumb động
  - Tags-view (Tab hỗ trợ thao tác chuột phải)
  - Svg Sprite
  - Dữ liệu Mock
  - Toàn màn hình (Screenfull)
  - Thanh điều hướng đáp ứng

- Trình soạn thảo
  - Trình soạn thảo văn bản đa dạng
  - Trình soạn thảo Markdown
  - Trình soạn thảo JSON

- Excel
  - Xuất Excel
  - Tải lên Excel
  - Trực quan hóa Excel
  - Xuất zip

- Bảng
  - Bảng động
  - Kéo thả bảng
  - Chỉnh sửa trực tiếp trên bảng

- Trang lỗi
  - 401
  - 404

- Thành phần
  - Tải lên avatar
  - Trở về đầu trang
  - Kéo hộp thoại
  - Kéo chọn
  - Kéo Kanban
  - Kéo danh sách
  - SplitPane
  - Dropzone
  - Sticky
  - CountTo

- Ví dụ nâng cao
- Nhật ký lỗi
- Dashboard
- Trang hướng dẫn
- ECharts
- Clipboard
- Chuyển đổi Markdown sang html
```

## Bắt đầu

```bash
# sao chép dự án
git clone https://github.com/PanJiaChen/vue-element-admin.git

# vào thư mục dự án
cd vue-element-admin

# cài đặt phụ thuộc
npm install

# phát triển
npm run dev
```

Quá trình này sẽ tự động mở http://localhost:9527

## Build

```bash
# build cho môi trường kiểm thử
npm run build:stage

# build cho môi trường sản xuất
npm run build:prod
```

## Nâng cao

```bash
# xem trước hiệu ứng môi trường phát hành
npm run preview

# xem trước hiệu ứng môi trường phát hành + phân tích tài nguyên tĩnh
npm run preview -- --report

# kiểm tra định dạng mã nguồn
npm run lint

# kiểm tra và tự động sửa định dạng mã nguồn
npm run lint -- --fix
```

Tham khảo [Tài liệu](https://panjiachen.github.io/vue-element-admin-site/guide/essentials/deploy.html) để biết thêm chi tiết

## Nhật ký thay đổi

Các thay đổi chi tiết cho mỗi lần phát hành được ghi lại trong [release notes](https://github.com/PanJiaChen/vue-element-admin/releases).

## Demo trực tuyến

[Xem trước](https://panjiachen.github.io/vue-element-admin)

## Ủng hộ

Nếu bạn thấy dự án này hữu ích, bạn có thể mời tác giả một ly nước ép :tropical_drink:

![donate](https://wpimg.wallstcn.com/bd273f0d-83a0-4ef2-92e1-9ac8ed3746b9.png)

[Paypal Me](https://www.paypal.me/panfree23)

[Buy me a coffee](https://www.buymeacoffee.com/Pan)

## Hỗ trợ trình duyệt

Các trình duyệt hiện đại và Internet Explorer 10+.

| [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/edge/edge_48x48.png" alt="IE / Edge" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>IE / Edge | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/firefox/firefox_48x48.png" alt="Firefox" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Firefox | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/chrome/chrome_48x48.png" alt="Chrome" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Chrome | [<img src="https://raw.githubusercontent.com/alrra/browser-logos/master/src/safari/safari_48x48.png" alt="Safari" width="24px" height="24px" />](https://godban.github.io/browsers-support-badges/)</br>Safari |
| --------- | --------- | --------- | --------- |
| IE10, IE11, Edge | 2 phiên bản mới nhất | 2 phiên bản mới nhất | 2 phiên bản mới nhất |

## Giấy phép

[MIT](https://github.com/PanJiaChen/vue-element-admin/blob/master/LICENSE)

Bản quyền (c) 2017-nay PanJiaChen

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---