# Nút 3D Có Thể Nhấn Được

Một thành phần nút 3D chân thực được xây dựng bằng HTML, CSS và SVG, mô phỏng cảm giác nhấn một nút vật lý. Nút có các hiệu ứng hoạt ảnh mượt mà, màu sắc tùy chỉnh và tương tác đáp ứng.

Được tạo bởi [@BalintFerenczy](https://x.com/BalintFerenczy)

Lấy cảm hứng từ tác phẩm tuyệt vời tại [Resend](https://resend.com/)

## Tính năng

- **Giao diện 3D chân thực** sử dụng đồ họa SVG xếp lớp
- **Hoạt ảnh mượt mà** với các hàm easing tùy chỉnh
- **Các trạng thái tương tác** - hiệu ứng hover và nhấn
- **Màu sắc tùy chỉnh** thông qua biến CSS
- **Thiết kế đáp ứng** có thể co giãn theo kích thước vùng chứa

## Trình diễn
Nút phản hồi các tương tác của người dùng với ba trạng thái riêng biệt:
- **Bình thường**: Nút ở vị trí nghỉ
- **Di chuột**: Di chuyển nhẹ xuống dưới khi chuột di chuyển qua
- **Đang nhấn**: Di chuyển mạnh xuống dưới khi được nhấn/bấm

## Sử dụng

### Tùy chỉnh

Nút có thể dễ dàng tùy chỉnh bằng cách sử dụng các thuộc tính tùy chỉnh CSS:

```css
.frame {
    /* Kích thước nút */
    width: 400px; 
    height: 400px; 

    /* Khoảng cách di chuyển */
    --hover-travel: 3px;
    --press-travel: 40px;
    
    /* Tùy chỉnh màu sắc */
    --color: black;
    --brightness: 1;
    --blend-mode: color;

    /* Thiết lập chuyển đổi */
    --transition-duration: 0.4s;
    --transition-easing: ease-in-out;
}
```
#### Thay Đổi Văn Bản Nút

Chỉ cần chỉnh sửa nội dung văn bản:

```html
<p class="text">Nhấn Vào Tôi!</p>
```

#### Thay Đổi Kích Thước Nút

Điều chỉnh kích thước khung:

```css
.frame {
    width: 200px;
    height: 200px;
}
```
## Giấy phép

Dự án này là mã nguồn mở và được phát hành theo Giấy phép MIT.

## Đóng góp

Bạn hãy thoải mái fork dự án này và gửi pull request để cải thiện hoặc thêm tính năng mới!

## Tác giả

Được tạo bởi [@BalintFerenczy](https://x.com/BalintFerenczy)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-13

---