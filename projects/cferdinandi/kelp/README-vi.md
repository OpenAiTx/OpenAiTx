# Kelp

Một thư viện giao diện người dùng dành cho những người yêu thích HTML, được hỗ trợ bởi CSS hiện đại và Web Components.

**[Đọc tài liệu &rarr;](https://kelpui.com)**

_**Lưu ý:** Kelp hiện đang trong giai đoạn phát triển alpha. Vui lòng thoải mái sử dụng, thử nghiệm và báo cáo lỗi, nhưng hãy hiểu rằng mọi thứ có thể và sẽ thay đổi theo thời gian._



## Bắt Đầu Nhanh

Kelp hoạt động mà không cần bất kỳ bước build nào.

[CDN](https://cdn.jsdelivr.net/npm/kelpui/) là cách nhanh nhất và đơn giản nhất để bắt đầu, nhưng bạn cũng có thể [tải các tệp từ GitHub](https://github.com/cferdinandi/kelp) nếu muốn.

```html
<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/kelpui@0/css/kelp.css">
```

Kelp sử dụng phiên bản hóa theo quy tắc semver. Bạn có thể lấy phiên bản chính, phụ hoặc bản vá từ CDN với cú pháp `@1.2.3`. Bạn có thể tìm tất cả các phiên bản hiện có [tại phần releases](https://github.com/cferdinandi/kelp/tags).



## Demo

Tệp `index.html` đi kèm là một bản demo tổng hợp (kitchen sink) của Kelp. Nó bao gồm mọi tính năng và thành phần trong một tệp lớn.

Trong khi còn ở bản beta, Kelp không có bước biên dịch. Web component sử dụng ES imports, và yêu cầu chạy trên máy chủ cục bộ.

Hãy sử dụng máy chủ bạn thích, hoặc sử dụng `http-server` đi kèm bằng cách chạy `npm run dev`.

```bash
npm install
npm run dev
```

Khi Kelp tiến gần đến v1, nó sẽ sử dụng bước biên dịch để loại bỏ yêu cầu này.



## Kiểm Thử

Kelp sử dụng...

- [Playwright](https://playwright.dev) cho kiểm thử
- [Biome](https://biomejs.dev) cho linting và định dạng mã nguồn
- Một quy trình tích hợp liên tục trên các lần triển khai và PR

```bash
# Chạy kiểm thử
npm run test

# Chạy linter
npm run lint
```



## Giấy Phép

Miễn phí sử dụng theo [Giấy phép Kelp Commons](https://github.com/cferdinandi/kelp/blob/main/LICENSE.md). Ngoài ra còn có các [tùy chọn giấy phép thương mại](/license/) khác.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---