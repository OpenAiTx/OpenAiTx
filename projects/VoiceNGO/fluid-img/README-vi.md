# Thành Phần Web Ảnh Linh Hoạt

Hình ảnh có thể co giãn thông minh đến bất kỳ kích thước mong muốn nào (trong giới hạn hợp lý).

![Ảnh Linh Hoạt](https://raw.githubusercontent.com/VoiceNGO/fluid-img/refs/heads/main/resources/images/responsive-images.jpg)

**Rất nhỏ!:** 7kb sau khi thu nhỏ & nén gzip

## Cách sử dụng

```html
<script src="fluid-img.js"></script>
<fluid-img src="image.jpg"></fluid-img>
```

Chỉ vậy thôi. Phóng to hoặc thu nhỏ hình ảnh tùy ý, chúng sẽ tự động thích nghi.

## Demo

[Demo tại đây](https://voicengo.github.io/fluid-img/public/fluid-demo.html)

Một playground cũng có sẵn để [thử nghiệm với hình ảnh của riêng bạn](https://voicengo.github.io/fluid-img/public).
## Cài đặt

### Thư viện phía client

```sh
npm install fluid-img
```

Sau đó import `fluid-img` vào dự án của bạn, thư viện này cung cấp và đăng ký web-component:

```ts
import 'fluid-img';
```

Hoặc bao gồm script từ jsdelivr hoặc unpkg:

```html
<script src="https://cdn.jsdelivr.net/npm/fluid-img@latest/dist/fluid-img.js" />

<!-- hoặc -->

<script src="https://unpkg.com/fluid-img@latest/dist/fluid-img.js" />
```
### Lưu ý

Thành phần hình ảnh linh hoạt hoạt động tốt nhất khi phóng to hoặc thu nhỏ hình ảnh theo chiều ngang hoặc chiều dọc trong phạm vi khoảng 0.5x đến 1.5x so với kích thước gốc của chúng. Mặc dù nó có thể xử lý các tỉ lệ lớn hơn hoặc nhỏ hơn, chất lượng hình ảnh có thể bị giảm nhanh chóng. Không khuyến nghị sử dụng cho các hình ảnh mà độ chính xác từng điểm ảnh là quan trọng, chẳng hạn như ảnh chân dung, biểu đồ, hoặc bản vẽ kỹ thuật chi tiết, vì kỹ thuật seam carving có thể gây méo hình. Rất khuyến khích bạn kiểm tra hình ảnh ở nhiều kích thước khác nhau để đảm bảo đáp ứng mong đợi về mặt thị giác.

#### CORS

Do các hạn chế bảo mật của trình duyệt, hình ảnh được tải từ nguồn gốc khác (domain, giao thức, hoặc cổng) với trang web sẽ gây ra lỗi Chia sẻ tài nguyên giữa các nguồn (CORS). Thành phần này yêu cầu truy cập vào dữ liệu điểm ảnh thô của hình ảnh, điều này bị giới hạn bởi CORS.

Để sử dụng hình ảnh từ nguồn khác, máy chủ lưu trữ hình ảnh phải được cấu hình để gửi các header CORS phù hợp (ví dụ: `Access-Control-Allow-Origin: *` hoặc `Access-Control-Allow-Origin: your-domain.com`). Nếu không có các header này, thành phần sẽ không thể xử lý hình ảnh.

(Thông tin thêm: để kiểm thử, bất kỳ hình ảnh nào trên imgur đều có các header CORS cần thiết)

#### Phương án dự phòng

Nếu thành phần không tải được hoặc không xử lý được hình ảnh, hoặc xảy ra lỗi nội bộ, nó sẽ tự động chuyển sang chèn thẻ `<img>` tiêu chuẩn vào trong thành phần `<fluid-img>`, với chiều rộng và chiều cao 100%, đảm bảo hình ảnh vẫn được hiển thị.

## Tùy chọn

Cách sử dụng: `<fluid-img src="image.jpg" generator="random" max-carve-up-scale="5"></fluid-img>`

Theo mặc định, generator `random` được sử dụng vì tốc độ nhanh nhất.

| Tùy chọn                       | Giá trị                          | Mặc định     | Mô tả                                                                                                                  |
| ------------------------------ | -------------------------------- | ------------ | ---------------------------------------------------------------------------------------------------------------------- |
| `src`                          | URL                              |              | URL của hình ảnh cần xử lý.                                                                                            |
| `generator`                    | `random`, `predictive`           | `predictive` | Bộ sinh đường seam carving sử dụng. `random` nhanh hơn nhưng chất lượng thấp hơn.                                     |
| `scaling-axis`                 | `horizontal`, `vertical`, `auto` | `horizontal` | Trục phóng/thu nhỏ. `auto` sẽ tự động chọn phóng/thu ngang hoặc dọc dựa trên thay đổi tỉ lệ khung hình.               |
| `mask`                         | URL                              |              | URL của hình ảnh mặt nạ. Các vùng màu đen trên mặt nạ có năng lượng thấp hơn và có khả năng được giữ lại nhiều hơn.     |
| `carving-priority`             | Số (0-1, ví dụ `0.5`)            | `1`          | Tỉ lệ phần trăm phóng/thu thực hiện bằng seam carving so với phóng/thu ảnh truyền thống.                               |
| `max-carve-up-seam-percentage` | Số (0-1, ví dụ `0.5`)            | `0.6`        | Tỉ lệ phần trăm tối đa số seam được chèn vào khi phóng to. Giới hạn tạo seam mới để bảo toàn chất lượng hình ảnh.       |
| `max-carve-up-scale`           | Số (ví dụ `3`)                   | `3`          | Hệ số phóng to tối đa sử dụng seam carving. Vượt quá giá trị này sẽ dùng phương pháp phóng/thu truyền thống.            |
| `max-carve-down-scale`         | Số (0-1, ví dụ `0.7`)            | `0.7`        | Tỉ lệ phần trăm tối đa hình ảnh có thể bị loại bỏ bằng seam carving khi thu nhỏ hình.                                   |
### Các tùy chọn riêng cho Generator

Các tùy chọn riêng cho generator được thêm vào thành phần `<fluid-img>` nhưng chỉ hợp lệ khi thuộc tính
`generator` tương ứng cũng được thiết lập

#### Các Tùy Chọn của Generator Ngẫu Nhiên & Dự Đoán

| Tùy chọn            | Giá trị                | Mặc định | Mô tả                                               |
| ------------------- | ---------------------- | -------- | --------------------------------------------------- |
| `batch-percentage`  | Số (0-1, ví dụ 0.1)    | 0.1      | Tỷ lệ đường liền kề được tạo ra trên mỗi lô         |
| `min-batch-size`    | Số (ví dụ `10`)        | 10       | Số lượng đường liền kề tối thiểu tạo ra trên mỗi lô  |

## Cách hoạt động

Seam carving là một kỹ thuật thay đổi kích thước ảnh dựa trên nội dung, thông minh loại bỏ hoặc thêm pixel, cho phép thay đổi kích thước hình ảnh mà không làm biến dạng nội dung quan trọng. Để biết thêm thông tin, xem [bài viết Wikipedia](https://en.wikipedia.org/wiki/Seam_carving) về chủ đề này.

Trước đây, seam carving quá tốn tài nguyên tính toán để sử dụng thời gian thực trên trình duyệt web. Tuy nhiên, hạn chế này có thể được khắc phục bằng cách sử dụng các thuật toán thay thế ít đòi hỏi hơn và hoạt động tốt trong nhiều trường hợp.

Có hai cách triển khai generator seam carving:
### Cắt Ngẫu Nhiên

Phương pháp cắt đường liền ngẫu nhiên loại bỏ thuật toán cắt đường liền truyền thống, vốn quá chậm để thực thi theo thời gian thực trên trình duyệt.

Thay vào đó, nó tạo ra một tập hợp các đường liền ngẫu nhiên cung cấp mức phủ 100% hình ảnh bằng cách kết nối mỗi điểm ảnh trong một hàng với một điểm ảnh lân cận ở hàng tiếp theo. Sau đó, nó lặp qua từng đường liền, tính toán năng lượng của chúng, và loại bỏ một loạt các đường liền có năng lượng thấp nhất. Quá trình này lặp lại cho đến khi đạt được số lượng đường liền mong muốn. Phương pháp này mang lại kết quả đáng ngạc nhiên tốt đối với nhiều hình ảnh.

### Cắt Dự Đoán

Tương tự như cắt ngẫu nhiên, phương pháp này tạo ra một bản đồ năng lượng và tạo các đường liền theo lô. Nó cũng tạo ra một bản đồ năng lượng tối thiểu cho mỗi lô. Ý tưởng cốt lõi là tạo ra cả các đường liền “tốt” và “xấu”. Đường liền tốt có năng lượng thấp và được giữ lại. Đường liền xấu chứa các điểm ảnh có năng lượng cao, cho phép loại bỏ chúng về sau.

Bắt đầu từ hàng đầu tiên, nó kết nối các cặp điểm ảnh với các cặp tương ứng ở hàng tiếp theo. Đường liền có năng lượng thấp hơn từ phép tính đang chạy sẽ được nối với đường liền có năng lượng thấp hơn từ bản đồ năng lượng tối thiểu.

Kết quả là một đường liền thật sự tối ưu, nhiều đường liền “rất tốt”, nhiều đường liền “rất xấu” và khá nhiều đường liền trung bình. Chúng tôi chọn ra một lô các đường liền “tốt”, loại bỏ phần còn lại và lặp lại quá trình.

##

## VIỆC CẦN LÀM

### Ưu Tiên Cao

- [x] Thành phần web
- [x] Bộ kết xuất nhận dữ liệu từ các trình sinh và co giãn theo mọi kích thước
- [x] Bộ sinh ngẫu nhiên
- [x] Cắt dọc
- [x] Bộ sinh dự đoán
- [ ] Web workers cho tất cả các trình sinh
### Ưu Tiên Thấp

- [x] Che mặt
- [ ] Nhận diện khuôn mặt

### Mơ Ước

- [ ] Khắc 2D

## Giấy Phép

Phần mềm này được cấp phép theo Giấy phép Fluid-Img Revenue-Limited.

**Miễn phí sử dụng** cho cá nhân và tổ chức có tổng doanh thu hàng năm dưới 10.000.000 USD.

**Yêu cầu giấy phép thương mại** cho tổ chức có doanh thu hàng năm từ 10 triệu USD trở lên. Liên hệ [licensing@voice.ngo] để biết điều khoản cấp phép thương mại.

Xem tệp [LICENSE](./LICENSE) để biết đầy đủ các điều khoản.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---