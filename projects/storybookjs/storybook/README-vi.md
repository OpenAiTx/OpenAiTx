<p align="center">
  <a href="https://storybook.js.org/">
    <picture>
      <source media="(prefers-color-scheme: dark)" srcset="https://user-images.githubusercontent.com/263385/199832481-bbbf5961-6a26-481d-8224-51258cce9b33.png">
      <img src="https://user-images.githubusercontent.com/321738/63501763-88dbf600-c4cc-11e9-96cd-94adadc2fd72.png" alt="Storybook" width="400" />
    </picture>
    
  </a>
  
</p>

<p align="center">Xây dựng các thành phần giao diện người dùng chống lỗi nhanh hơn</p>

<br/>

<p align="center">
  <a href="https://circleci.com/gh/storybookjs/storybook">
    <img src="https://circleci.com/gh/storybookjs/storybook.svg?style=shield" alt="Build Status on CircleCI" />
  </a>
  <a href="https://codecov.io/gh/storybookjs/storybook">
    <img src="https://codecov.io/gh/storybookjs/storybook/branch/main/graph/badge.svg" alt="codecov" />
  </a>
  <a href="https://github.com/storybookjs/storybook/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/storybookjs/storybook.svg" alt="License" />
  </a>
  <br/>
  <a href="https://discord.gg/storybook">
    <img src="https://img.shields.io/badge/discord-join-7289DA.svg?logo=discord&longCache=true&style=flat" />
  </a>
  <a href="https://storybook.js.org/community/">
    <img src="https://img.shields.io/badge/community-join-4BC424.svg" alt="Storybook Community" />
  </a>
  <a href="#backers">
    <img src="https://opencollective.com/storybook/backers/badge.svg" alt="Backers on Open Collective" />
  </a>
  <a href="#sponsors">
    <img src="https://opencollective.com/storybook/tiers/sponsors/badge.svg" alt="Sponsors on Open Collective" />
  </a>
  <a href="https://x.com/intent/follow?screen_name=storybookjs">
    <img src="https://img.shields.io/twitter/follow/storybookjs?color=blue&logo=twitter" alt="Official Twitter Handle" />
  </a>
  <a href="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook">
    <img src="https://api.securityscorecards.dev/projects/github.com/storybookjs/storybook/badge" alt="OpenSSF Scorecard"/>
  </a>
</p>

<p align="center">
Storybook là một xưởng phát triển frontend để xây dựng các thành phần UI và trang web một cách độc lập. Hàng ngàn đội nhóm sử dụng nó cho phát triển, kiểm thử và tài liệu giao diện người dùng. Tìm hiểu thêm tại https://storybook.js.org!
</p>

<center>
  <img src="https://raw.githubusercontent.com/storybookjs/storybook/main/media/storybook-intro.gif" width="100%" />
</center>

<p align="center">
  Xem README cho:<br/>
  <a href="https://github.com/storybookjs/storybook/blob/main/README.md" title="latest"><img alt="latest" src="https://img.shields.io/npm/v/@storybook/react/latest?style=for-the-badge&logo=storybook&logoColor=ffffff&color=66BF3C" /></a>
  <a href="https://github.com/storybookjs/storybook/blob/next/README.md" title="next"><img alt="next" src="https://img.shields.io/npm/v/@storybook/react/next?style=for-the-badge&logo=storybook&logoColor=ffffff&color=1EA7FD" /></a>
</p>

## Mục lục

- 🚀 [Bắt đầu](#getting-started)
- 📒 [Dự án](#projects)
  - 🛠 [Các framework hỗ trợ & Ví dụ](#supported-frameworks)
  - 🔗[Addons](#addons)
- 🏅 [Badges & Tài liệu thuyết trình](#badges--presentation-materials)
- 👥 [Cộng đồng](#community)
- 👏 [Đóng góp](#contributing)
  - 👨‍💻 [Script phát triển](#development-scripts)
  - 💸 [Nhà tài trợ](#sponsors)
  - 💵 [Người ủng hộ](#backers)
- :memo: [Giấy phép](#license)

## Bắt đầu

Truy cập [website Storybook](https://storybook.js.org) để tìm hiểu thêm về Storybook và bắt đầu sử dụng.

### Tài liệu

Tài liệu có thể được tìm thấy tại [trang docs của Storybook](https://storybook.js.org/docs).

### Ví dụ

Xem [Bách khoa toàn thư thành phần](https://storybook.js.org/showcase) để thấy cách các đội nhóm hàng đầu sử dụng Storybook.

Dùng [storybook.new](https://storybook.new) để nhanh chóng tạo một dự án ví dụ trên Stackblitz.

Storybook đi kèm với rất nhiều [addon](https://storybook.js.org/docs/configure/user-interface/storybook-addons) cho thiết kế thành phần, tài liệu, kiểm thử, tương tác, v.v. API của Storybook cho phép bạn cấu hình và mở rộng theo nhiều cách khác nhau. Nó thậm chí còn được mở rộng để hỗ trợ phát triển React Native, Android, iOS và Flutter cho di động.

### Cộng đồng

Để được hỗ trợ thêm, hãy chia sẻ vấn đề của bạn trong [GitHub Discussions của repo](https://github.com/storybookjs/storybook/discussions/new?category=help).

## Dự án

### Các framework hỗ trợ

| Renderer                                                       | Demo                                                                                                                                                                         |                                                                                                                                                       |
| -------------------------------------------------------------- | ---------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------- |
| [React](code/renderers/react)                                  | [![Storybook demo](https://img.shields.io/npm/v/@storybook/react/latest?style=flat-square&color=blue&label)](https://next--630511d655df72125520f051.chromatic.com/)          | [![React](https://img.shields.io/npm/dm/@storybook/react?style=flat-square&color=eee)](code/renderers/react)                                          |
| [Angular](code/frameworks/angular/)                            | [![Storybook demo](https://img.shields.io/npm/v/@storybook/angular/latest?style=flat-square&color=blue&label)](https://next--6322ce6af69825592bbb28fc.chromatic.com/)        | [![Angular](https://img.shields.io/npm/dm/@storybook/angular?style=flat-square&color=eee)](code/frameworks/angular/)                                  |
| [Vue 3](code/renderers/vue3)                                   | [![Storybook demo](https://img.shields.io/npm/v/@storybook/vue3/latest?style=flat-square&color=blue&label)](https://next--630513346a8e284ae244d415.chromatic.com/)           | [![Vue 3](https://img.shields.io/npm/dm/@storybook/vue3?style=flat-square&color=eee)](code/renderers/vue3/)                                           |
| [Web components](code/renderers/web-components)                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/web-components/latest?style=flat-square&color=blue&label)](https://next--638db5bf49adfdfe8cf545e0.chromatic.com/) | [![Svelte](https://img.shields.io/npm/dm/@storybook/web-components?style=flat-square&color=eee)](code/renderers/web-components)                       |
| [React Native](https://github.com/storybookjs/react-native)    | [![](https://img.shields.io/npm/v/@storybook/react-native/latest?style=flat-square&color=blue&label)](/)                                                                     | [![React Native](https://img.shields.io/npm/dm/@storybook/react-native?style=flat-square&color=eee)](https://github.com/storybookjs/react-native)     |
| [HTML](code/renderers/html)                                    | [![Storybook demo](https://img.shields.io/npm/v/@storybook/html/latest?style=flat-square&color=blue&label)](https://next--63dd39a158cf6fc05199b4bb.chromatic.com/)           | [![HTML](https://img.shields.io/npm/dm/@storybook/html?style=flat-square&color=eee)](code/renderers/html)                                             |
| [Ember](code/frameworks/ember/)                                | [![](https://img.shields.io/npm/v/@storybook/ember/latest?style=flat-square&color=blue&label)](/)                                                                            | [![Ember](https://img.shields.io/npm/dm/@storybook/ember?style=flat-square&color=eee)](code/frameworks/ember/)                                        |
| [Svelte](code/renderers/svelte)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/svelte/latest?style=flat-square&color=blue&label)](https://next--630873996e4e3557791c069c.chromatic.com/)         | [![Svelte](https://img.shields.io/npm/dm/@storybook/svelte?style=flat-square&color=eee)](code/renderers/svelte)                                       |
| [Preact](code/renderers/preact)                                | [![Storybook demo](https://img.shields.io/npm/v/@storybook/preact/latest?style=flat-square&color=blue&label)](https://next--63b588a512565bfaace15e7c.chromatic.com/)         | [![Preact](https://img.shields.io/npm/dm/@storybook/preact?style=flat-square&color=eee)](code/renderers/preact)                                       |
| [Qwik](https://github.com/literalpie/storybook-framework-qwik) | [![](https://img.shields.io/npm/v/storybook-framework-qwik/latest?style=flat-square&color=blue&label)](/)                                                                    | [![Qwik](https://img.shields.io/npm/dm/storybook-framework-qwik?style=flat-square&color=eee)](https://github.com/literalpie/storybook-framework-qwik) |
| [SolidJS](https://github.com/storybookjs/solidjs)              | [![](https://img.shields.io/npm/v/storybook-solidjs/latest?style=flat-square&color=blue&label)](/)                                                                           | [![SolidJS](https://img.shields.io/npm/dm/storybook-solidjs?style=flat-square&color=eee)](https://github.com/storybookjs/solidjs)                     |
| [Android, iOS, Flutter](https://github.com/storybookjs/native) | [![](https://img.shields.io/npm/v/@storybook/native/latest?style=flat-square&color=blue&label)](/)                                                                           | [![Native](https://img.shields.io/npm/dm/@storybook/native?style=flat-square&color=eee)](https://github.com/storybookjs/native)                       |

### Addons

| Addons                                                                    |                                                                            |
| ------------------------------------------------------------------------- | -------------------------------------------------------------------------- |
| [a11y](code/addons/a11y/)                                                 | Kiểm thử thành phần về khả năng truy cập người dùng trong Storybook         |
| [actions](code/core/src/actions/)                                         | Ghi lại hành động khi người dùng tương tác với thành phần trong UI Storybook|
| [backgrounds](code/core/src/backgrounds)                                  | Cho phép người dùng chọn nền trong UI Storybook                            |
| [cssresources](https://github.com/storybookjs/addon-cssresources)         | Thêm/xóa động các tài nguyên CSS vào iframe thành phần                     |
| [design assets](https://github.com/storybookjs/addon-design-assets)       | Xem hình ảnh, video và liên kết web cùng với story của bạn                  |
| [docs](code/addons/docs/)                                                 | Thêm tài liệu chất lượng cao cho thành phần của bạn                         |
| [events](https://github.com/storybookjs/addon-events)                     | Tương tác phát sự kiện tới các thành phần phản hồi EventEmitter             |
| [google-analytics](https://github.com/storybookjs/addon-google-analytics) | Báo cáo google analytics trên các story                                     |
| [graphql](https://github.com/storybookjs/addon-graphql)                   | Truy vấn máy chủ GraphQL trong các story Storybook                          |
| [jest](code/addons/jest/)                                                 | Xem kết quả kiểm thử đơn vị của các thành phần trong Storybook              |
| [links](code/addons/links/)                                               | Tạo liên kết giữa các story                                                 |
| [measure](code/core/src/measure/)                                         | Kiểm tra trực quan bố cục và box model trong UI Storybook                   |
| [outline](code/core/src/outline/)                                         | Gỡ lỗi trực quan bố cục và căn chỉnh CSS trong UI Storybook                 |
| [query params](https://github.com/storybookjs/addon-queryparams)          | Mô phỏng query params                                                       |
| [viewport](code/core/src/viewport/)                                       | Thay đổi kích thước và bố cục cho thành phần đáp ứng bằng Storybook         |

Xem [Bảng Hỗ trợ Addon / Framework](https://storybook.js.org/docs/configure/integration/frameworks-feature-support)

Để tiếp tục cải thiện trải nghiệm của bạn, chúng tôi sẽ dần loại bỏ hoặc thay thế một số addon nhất định bằng các công cụ mới và tốt hơn.

Nếu bạn đang dùng info/notes, chúng tôi khuyến nghị bạn chuyển sang [docs](code/addons/docs/), và [đây là hướng dẫn](code/addons/docs/docs/recipes.md#migrating-from-notesinfo-addons) để hỗ trợ bạn.

Nếu bạn đang dùng contexts, chúng tôi khuyến nghị bạn chuyển sang [toolbars](https://github.com/storybookjs/storybook/tree/next/code/addons/toolbars) và [đây là hướng dẫn](https://github.com/storybookjs/storybook/blob/next/MIGRATION.md#deprecated-addon-contexts) để hỗ trợ bạn.

Nếu bạn đang dùng addon-storyshots, chúng tôi khuyến nghị bạn chuyển sang Storybook [test-runner](https://github.com/storybookjs/test-runner) và [đây là hướng dẫn](https://storybook.js.org/docs/writing-tests/storyshots-migration-guide) để hỗ trợ bạn.

## Badges & Tài liệu thuyết trình

Chúng tôi có badge! Gắn nó vào ví dụ Storybook trực tuyến của bạn.

![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)

```md
[![Storybook](https://cdn.jsdelivr.net/gh/storybookjs/brand@main/badge/badge-storybook.svg)](liên kết tới trang web)
```

Nếu bạn đang tìm tài liệu để dùng trong thuyết trình Storybook, như logo, video, màu sắc chúng tôi sử dụng, bạn có thể tìm tất cả tại [repo thương hiệu của chúng tôi](https://github.com/storybookjs/brand).

## Cộng đồng

- Đăng tweet qua [@storybookjs](https://x.com/storybookjs)
- Viết blog tại [storybook.js.org](https://storybook.js.org/blog/) và [Medium](https://medium.com/storybookjs)
- Trò chuyện trên [Discord](https://discord.gg/storybook)
- Video và stream tại [YouTube](https://www.youtube.com/channel/UCr7Quur3eIyA_oe8FNYexfg)

## Đóng góp

Chúng tôi luôn chào đón các đóng góp cho Storybook!

- 📥 Pull requests và 🌟 Star luôn được hoan nghênh.
- Đọc [hướng dẫn đóng góp](CONTRIBUTING.md) của chúng tôi để bắt đầu,
  hoặc tìm chúng tôi trên [Discord](https://discord.gg/storybook), chúng tôi sẽ dành thời gian hướng dẫn bạn.

Tìm kiếm một vấn đề đầu tiên để giải quyết?

- Chúng tôi gắn nhãn các vấn đề với [![Good First Issue](https://img.shields.io/github/issues/storybookjs/storybook/good%20first%20issue.svg)](https://github.com/storybookjs/storybook/issues?q=is%3Aopen+is%3Aissue+label%3A%22good+first+issue%22) khi nghĩ rằng chúng phù hợp cho người mới tiếp cận mã nguồn hoặc OSS.
- [Trao đổi với chúng tôi](https://discord.gg/storybook), chúng tôi sẽ tìm thứ phù hợp với kỹ năng và sở thích học hỏi của bạn.

### Script phát triển

Storybook được tổ chức theo dạng monorepo. Một số script hữu ích gồm:

#### `yarn start`

> Chạy một storybook mẫu sandbox với các story kiểm thử

#### `yarn task`

> Như trên, nhưng cho phép bạn tùy chỉnh sandbox (ví dụ: chọn framework khác)

#### `yarn lint`

> Kiểm tra mã nguồn có tuân thủ quy tắc lint không - dùng remark & eslint

- `yarn lint:js` - kiểm tra js
- `yarn lint:md` - kiểm tra markdown + ví dụ mã nguồn
- `yarn lint:js --fix` - tự động sửa js

#### `yarn test`

> Kiểm tra các unit test có vượt qua không - dùng jest

- `yarn run test --core --watch` - chạy kiểm thử core ở chế độ watch

### Nhà tài trợ

Trở thành nhà tài trợ để logo và URL website của bạn xuất hiện trên README của chúng tôi trên Github. \[[Trở thành nhà tài trợ](https://opencollective.com/storybook#sponsor)]

<a href="https://opencollective.com/storybook/tiers/sponsors/0/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/0/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/1/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/1/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/2/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/2/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/3/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/3/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/4/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/4/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/5/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/5/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/6/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/6/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/7/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/7/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/8/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/8/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/9/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/9/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/10/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/10/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/11/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/11/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/12/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/12/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/13/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/13/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/14/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/14/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/15/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/15/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/16/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/16/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/17/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/17/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/18/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/18/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/19/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/19/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/20/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/20/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/21/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/21/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/22/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/22/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/23/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/23/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/24/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/24/avatar.svg?requireActive=true"></a>
<a href="https://opencollective.com/storybook/tiers/sponsors/25/website?requireActive=true" target="_blank"><img src="https://opencollective.com/storybook/tiers/sponsors/25/avatar.svg?requireActive=true"></a>

### Người ủng hộ

Bằng cách tài trợ định kỳ, bạn có thể hỗ trợ chúng tôi và công việc của chúng tôi. \[[Trở thành người ủng hộ](https://opencollective.com/storybook#backer)]

<a href="https://opencollective.com/storybook"><img src="https://opencollective.com/storybook/tiers/backers.svg?limit=80&button=false&avatarHeight=46&width=750"></a>

## Giấy phép

[MIT](https://github.com/storybookjs/storybook/blob/main/LICENSE)

-kết thúc-

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---