## Create React App [![Build & Test](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml/badge.svg?branch=main)](https://github.com/facebook/create-react-app/actions/workflows/build-and-test.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-green.svg)](https://github.com/facebook/create-react-app/blob/main/CONTRIBUTING.md)

> [!CAUTION]
>
> ## Đã ngừng phát triển
>
> Create React App là một trong những công cụ chủ chốt để khởi tạo dự án React trong giai đoạn 2017-2021, hiện tại đã được chuyển sang trạng thái bảo trì dài hạn và chúng tôi khuyến nghị bạn chuyển sang một trong các framework React được tài liệu tại [Bắt đầu một dự án React mới](https://react.dev/learn/start-a-new-react-project).
>
> Nếu bạn đang theo một hướng dẫn học React, vẫn có giá trị khi tiếp tục học, nhưng chúng tôi không khuyến khích bắt đầu các ứng dụng sản xuất dựa trên Create React App.

<img alt="Logo" align="right" src="https://create-react-app.dev/img/logo.svg" width="20%" />

Tạo ứng dụng React mà không cần cấu hình build.

- [Tạo một ứng dụng](#creating-an-app) – Cách tạo một ứng dụng mới.
- [Hướng dẫn sử dụng](https://facebook.github.io/create-react-app/) – Cách phát triển ứng dụng khởi tạo với Create React App.

Create React App hoạt động trên macOS, Windows và Linux.<br>
Nếu có điều gì không hoạt động, vui lòng [gửi báo lỗi](https://github.com/facebook/create-react-app/issues/new).<br>
Nếu bạn có câu hỏi hoặc cần trợ giúp, hãy hỏi tại [GitHub Discussions](https://github.com/facebook/create-react-app/discussions).

## Tổng quan nhanh

```sh
npx create-react-app my-app
cd my-app
npm start
```

Nếu bạn đã cài đặt `create-react-app` toàn cục trước đây qua `npm install -g create-react-app`, chúng tôi khuyến nghị bạn gỡ bỏ gói này bằng `npm uninstall -g create-react-app` hoặc `yarn global remove create-react-app` để đảm bảo npx luôn sử dụng phiên bản mới nhất.

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) đi kèm với npm 5.2+ trở lên, xem [hướng dẫn cho các phiên bản npm cũ hơn](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

Sau đó, mở [http://localhost:3000/](http://localhost:3000/) để xem ứng dụng của bạn.<br>
Khi bạn đã sẵn sàng để triển khai lên môi trường sản xuất, tạo một gói bundle đã được nén với `npm run build`.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/facebook/create-react-app@27b42ac7efa018f2541153ab30d63180f5fa39e0/screencast.svg' width='600' alt='npm start'>
</p>

### Bắt đầu ngay lập tức

Bạn **không** cần cài đặt hoặc cấu hình các công cụ như webpack hoặc Babel.<br>
Chúng đã được cấu hình sẵn và ẩn đi để bạn có thể tập trung vào viết mã.

Chỉ cần tạo dự án, và bạn đã sẵn sàng để bắt đầu.

## Tạo một ứng dụng

**Bạn cần có Node phiên bản 14.0.0 hoặc cao hơn trên máy phát triển cục bộ** (nhưng không bắt buộc trên máy chủ). Chúng tôi khuyến nghị sử dụng phiên bản LTS mới nhất. Bạn có thể sử dụng [nvm](https://github.com/creationix/nvm#installation) (macOS/Linux) hoặc [nvm-windows](https://github.com/coreybutler/nvm-windows#node-version-manager-nvm-for-windows) để chuyển đổi giữa các phiên bản Node cho các dự án khác nhau.

Để tạo một ứng dụng mới, bạn có thể chọn một trong các phương pháp sau:

### npx

```sh
npx create-react-app my-app
```

_([npx](https://medium.com/@maybekatz/introducing-npx-an-npm-package-runner-55f7d4bd282b) là công cụ chạy package đi kèm với npm 5.2+ trở lên, xem [hướng dẫn cho các phiên bản npm cũ hơn](https://gist.github.com/gaearon/4064d3c23a77c74a3614c498a8bb1c5f))_

### npm

```sh
npm init react-app my-app
```

_`npm init <initializer>` có sẵn từ npm 6+_

### Yarn

```sh
yarn create react-app my-app
```

_[`yarn create <starter-kit-package>`](https://yarnpkg.com/lang/en/docs/cli/create/) có sẵn từ Yarn 0.25+_

Lệnh này sẽ tạo một thư mục có tên `my-app` trong thư mục hiện tại.<br>
Bên trong thư mục đó, nó sẽ khởi tạo cấu trúc dự án ban đầu và cài đặt các phụ thuộc liên quan:

```
my-app
├── README.md
├── node_modules
├── package.json
├── .gitignore
├── public
│   ├── favicon.ico
│   ├── index.html
│   └── manifest.json
└── src
    ├── App.css
    ├── App.js
    ├── App.test.js
    ├── index.css
    ├── index.js
    ├── logo.svg
    └── serviceWorker.js
    └── setupTests.js
```

Không cần cấu hình hoặc cấu trúc thư mục phức tạp, chỉ các tệp cần thiết để xây dựng ứng dụng của bạn.<br>
Sau khi cài đặt xong, bạn có thể mở thư mục dự án:

```sh
cd my-app
```

Bên trong dự án vừa tạo, bạn có thể chạy một số lệnh tích hợp sẵn:

### `npm start` hoặc `yarn start`

Chạy ứng dụng ở chế độ phát triển.<br>
Mở [http://localhost:3000](http://localhost:3000) để xem trong trình duyệt.

Trang sẽ tự động tải lại nếu bạn thay đổi mã nguồn.<br>
Bạn sẽ thấy lỗi build và cảnh báo lint trong console.

<p align='center'>
<img src='https://cdn.jsdelivr.net/gh/marionebl/create-react-app@9f6282671c54f0874afd37a72f6689727b562498/screencast-error.svg' width='600' alt='Build errors'>
</p>

### `npm test` hoặc `yarn test`

Chạy chế độ test watcher ở chế độ tương tác.<br>
Mặc định, sẽ chạy các bài test liên quan đến các tệp đã thay đổi kể từ lần commit cuối cùng.

[Đọc thêm về kiểm thử.](https://facebook.github.io/create-react-app/docs/running-tests)

### `npm run build` hoặc `yarn build`

Build ứng dụng cho môi trường sản xuất vào thư mục `build`.<br>
Nó sẽ bundle React ở chế độ production và tối ưu hóa build để đạt hiệu năng tốt nhất.

Kết quả build được nén nhỏ và tên tệp có chứa hash.<br>

Ứng dụng của bạn đã sẵn sàng để triển khai.

## Hướng dẫn sử dụng

Bạn có thể tìm thấy hướng dẫn chi tiết về cách sử dụng Create React App và nhiều mẹo hữu ích trong [tài liệu của nó](https://facebook.github.io/create-react-app/).

## Làm thế nào để cập nhật phiên bản mới?

Vui lòng tham khảo [Hướng dẫn sử dụng](https://facebook.github.io/create-react-app/docs/updating-to-new-releases) để biết thông tin này và các thông tin khác.

## Triết lý

- **Chỉ một phụ thuộc:** Chỉ có một phụ thuộc build duy nhất. Nó sử dụng webpack, Babel, ESLint và các dự án tuyệt vời khác, nhưng cung cấp trải nghiệm được chọn lọc trên nền tảng đó.

- **Không cần cấu hình:** Bạn không cần cấu hình gì cả. Một cấu hình đủ tốt cho cả môi trường phát triển và sản xuất sẽ được lo liệu để bạn tập trung vào viết mã.

- **Không bị ràng buộc:** Bạn có thể “eject” sang cấu hình tùy chỉnh bất cứ lúc nào. Chạy một lệnh duy nhất, toàn bộ cấu hình và các phụ thuộc build sẽ được chuyển vào dự án của bạn, để bạn có thể tiếp tục phát triển theo ý muốn.

## Bao gồm những gì?

Môi trường của bạn sẽ có đầy đủ mọi thứ cần thiết để xây dựng một ứng dụng React hiện đại dạng trang đơn:

- Hỗ trợ React, JSX, ES6, TypeScript và Flow.
- Các tính năng mở rộng ngoài ES6 như toán tử spread cho object.
- CSS tự động thêm tiền tố, nên bạn không cần `-webkit-` hay các tiền tố khác.
- Trình chạy unit test nhanh, tương tác, có tích hợp báo cáo coverage.
- Máy chủ phát triển trực tiếp cảnh báo về các lỗi phổ biến.
- Script build để đóng gói JS, CSS, và hình ảnh cho production, có hash và sourcemap.
- [Service worker](https://developers.google.com/web/fundamentals/getting-started/primers/service-workers) ưu tiên offline và [manifest ứng dụng web](https://developers.google.com/web/fundamentals/engage-and-retain/web-app-manifest/), đáp ứng mọi tiêu chí [Progressive Web App](https://facebook.github.io/create-react-app/docs/making-a-progressive-web-app). (_Lưu ý: Việc sử dụng service worker là tùy chọn từ `react-scripts@2.0.0` trở lên_)
- Cập nhật dễ dàng cho các công cụ trên chỉ với một phụ thuộc duy nhất.

Tham khảo [hướng dẫn này](https://github.com/nitishdayal/cra_closer_look) để biết tổng quan cách các công cụ này phối hợp với nhau.

Đổi lại, **các công cụ này đã được cấu hình sẵn để hoạt động theo một cách nhất định**. Nếu dự án của bạn cần tùy biến nhiều hơn, bạn có thể ["eject"](https://facebook.github.io/create-react-app/docs/available-scripts#npm-run-eject) và tùy chỉnh, nhưng bạn sẽ cần tự duy trì cấu hình này.

## Các lựa chọn thay thế phổ biến

Create React App rất phù hợp cho:

- **Học React** trong môi trường phát triển tiện nghi và nhiều tính năng.
- **Khởi đầu ứng dụng React trang đơn mới.**
- **Tạo ví dụ minh họa** với React cho thư viện và các component của bạn.

Dưới đây là một số trường hợp phổ biến bạn nên thử giải pháp khác:

- Nếu bạn muốn **thử React** mà không cần đến hàng trăm phụ thuộc build, hãy [dùng một file HTML đơn hoặc sandbox trực tuyến](https://reactjs.org/docs/getting-started.html#try-react).

- Nếu bạn cần **tích hợp mã React với các framework template phía server** như Rails, Django hoặc Symfony, hoặc **không xây dựng ứng dụng trang đơn**, hãy cân nhắc sử dụng [nwb](https://github.com/insin/nwb), hoặc [Neutrino](https://neutrino.js.org/) linh hoạt hơn. Với Rails, bạn có thể dùng [Rails Webpacker](https://github.com/rails/webpacker). Với Symfony, thử [webpack Encore của Symfony](https://symfony.com/doc/current/frontend/encore/reactjs.html).

- Nếu bạn cần **xuất bản một component React**, [nwb](https://github.com/insin/nwb) cũng [có thể làm điều này](https://github.com/insin/nwb#react-components-and-libraries), cũng như [preset react-components của Neutrino](https://neutrino.js.org/packages/react-components/).

- Nếu bạn muốn làm **server rendering** với React và Node.js, hãy xem [Next.js](https://nextjs.org/) hoặc [Razzle](https://github.com/jaredpalmer/razzle). Create React App không phụ thuộc backend, chỉ tạo ra các bundle HTML/JS/CSS tĩnh.

- Nếu website của bạn **chủ yếu tĩnh** (ví dụ như portfolio hoặc blog), hãy cân nhắc dùng [Gatsby](https://www.gatsbyjs.org/) hoặc [Next.js](https://nextjs.org/). Không giống Create React App, Gatsby render sẵn website thành HTML khi build. Next.js hỗ trợ cả server rendering và pre-rendering.

- Cuối cùng, nếu bạn cần **tùy biến nhiều hơn**, hãy xem [Neutrino](https://neutrino.js.org/) và [React preset](https://neutrino.js.org/packages/react/) của nó.

Tất cả các công cụ trên đều có thể dùng với rất ít hoặc không cần cấu hình.

Nếu bạn thích tự cấu hình build, [làm theo hướng dẫn này](https://reactjs.org/docs/add-react-to-a-website.html).

## React Native

Bạn tìm kiếm công cụ tương tự nhưng cho React Native?<br>
Hãy xem [Expo CLI](https://github.com/expo/expo-cli).

## Đóng góp

Chúng tôi rất hoan nghênh sự đóng góp của bạn cho `create-react-app`! Xem [CONTRIBUTING.md](CONTRIBUTING.md) để biết thêm chi tiết về những gì chúng tôi cần và cách bắt đầu.

## Ủng hộ Create React App

Create React App là dự án được duy trì bởi cộng đồng và tất cả các cộng tác viên đều là tình nguyện viên. Nếu bạn muốn hỗ trợ sự phát triển tương lai của Create React App, hãy cân nhắc quyên góp cho [Open Collective](https://opencollective.com/create-react-app) của chúng tôi.

## Ghi nhận

Dự án này tồn tại nhờ tất cả những người đã [đóng góp](CONTRIBUTING.md).<br>
<a href="https://github.com/facebook/create-react-app/graphs/contributors"><img src="https://opencollective.com/create-react-app/contributors.svg?width=890&button=false" /></a>

Cảm ơn [Netlify](https://www.netlify.com/) đã tài trợ lưu trữ tài liệu.

## Lời cảm ơn

Chúng tôi biết ơn các tác giả của các dự án liên quan đã chia sẻ ý tưởng và hợp tác:

- [@eanplatter](https://github.com/eanplatter)
- [@insin](https://github.com/insin)
- [@mxstbr](https://github.com/mxstbr)

## Giấy phép

Create React App là phần mềm mã nguồn mở [được cấp phép MIT](https://github.com/facebook/create-react-app/blob/main/LICENSE). Logo Create React App được cấp phép theo [Creative Commons Attribution 4.0 International license](https://creativecommons.org/licenses/by/4.0/).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---