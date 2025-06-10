# Gantt

## Cài đặt

```
yarn install
```

### Chạy

```
yarn run serve
```

### Giải thích

```
Biểu đồ Gantt được phát triển dựa trên vue, có thể sử dụng trong các tình huống làm việc nhóm, phân chia nhiệm vụ trong môi trường Agile

Hỗ trợ phân nhóm
Hỗ trợ kéo thả
Hỗ trợ kéo giãn
Hỗ trợ phần trăm hoàn thành
Hỗ trợ các khoảng thời gian: ngày, tuần, tháng
Hiện tại chỉ viết nhóm cấp 1, để tránh nhu cầu nhóm cấp 2 hoặc đa cấp trong tương lai, ở lần commit trước đã tái cấu trúc một số đoạn mã để hỗ trợ nhóm đa cấp, nhưng phiên bản hiện tại chưa phát triển tính năng này

Ưu điểm: Khi thao tác kéo thả, kéo giãn, chỉnh sửa tiến độ,... dữ liệu không được cập nhật thời gian thực mà chỉ cập nhật sau thao tác, giảm thiểu hao tổn hiệu năng
         Khi chỉnh sửa, xóa, thêm mới, không thực hiện đệ quy toàn bộ để sửa đổi thực thể mà chỉ thêm/xóa/sửa phần thay đổi

Đang chuẩn bị tổ chức lại để hướng tới component hóa, hiện tại muốn sử dụng trong dự án chỉ cần import file `gant.vue` trong dự án này là được
Phương pháp nhập/xuất dữ liệu hàng loạt đã được viết xong, chỉ cần copy là dùng được!~
```

### Ghi chú cập nhật

- Hỗ trợ chỉnh sửa
- Hỗ trợ xóa
- Sửa lỗi không thể cuộn dọc (đồng thời thêm chức năng cuộn đồng thời hai chiều) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Sửa lỗi do elementUI gây ra
- Về vấn đề khoảng thời gian [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Hiện tại không thể thay đổi các cấu hình khoảng thời gian để thêm các khoảng khác như giờ,... vì một số cấu hình đã được cố định khi khởi tạo, sẽ cập nhật và đưa ra dưới dạng api trong tương lai

### Xem ví dụ

Xem [demo](https://ggbeng1.github.io/Gantt/#/)

### Hình ảnh minh họa

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---