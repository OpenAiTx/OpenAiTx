# Cập Nhật Cơ Sở Dữ Liệu Browserslist

<img width="120" height="120" alt="Browserslist logo by Anton Popov"
     src="https://browsersl.ist/logo.svg" align="right">

Công cụ CLI để cập nhật `caniuse-lite` với cơ sở dữ liệu trình duyệt
từ cấu hình [Browserslist](https://github.com/browserslist/browserslist/).

Một số truy vấn như `last 2 versions` hoặc `>1%` phụ thuộc vào dữ liệu thực tế
từ `caniuse-lite`.

```sh
npx update-browserslist-db@latest
```

<a href="https://evilmartians.com/?utm_source=update-browserslist-db">
  <img src="https://evilmartians.com/badges/sponsored-by-evil-martians.svg"
       alt="Được tài trợ bởi Evil Martians" width="236" height="54">
</a>

## Tại sao bạn cần gọi nó thường xuyên

`npx update-browserslist-db@latest` sẽ cập nhật phiên bản `caniuse-lite`
trong tệp khóa npm, yarn hoặc pnpm của bạn.

Bản cập nhật này sẽ mang dữ liệu về các trình duyệt mới cho các công cụ polyfill
như Autoprefixer hoặc Babel và giảm các polyfill không còn cần thiết.

Bạn cần thực hiện thao tác này thường xuyên vì ba lý do sau:

1. Để sử dụng các phiên bản trình duyệt và thống kê mới nhất trong các truy vấn như
   `last 2 versions` hoặc `>1%`. Ví dụ, nếu bạn tạo dự án của mình
   2 năm trước và không cập nhật các phụ thuộc, `last 1 version`
   sẽ trả về các trình duyệt cách đây 2 năm.
2. Dữ liệu trình duyệt thực tế sẽ giúp sử dụng ít polyfill hơn. Điều này sẽ giảm
   kích thước các tệp JS và CSS, đồng thời cải thiện hiệu suất website.
3. Gỡ trùng lặp `caniuse-lite`: để đồng bộ hóa phiên bản giữa các công cụ khác nhau.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---