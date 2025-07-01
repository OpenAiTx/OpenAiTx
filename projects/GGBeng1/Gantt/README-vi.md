# Gantt
<div style="text-align: center"><p><a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=en"><img src="https://img.shields.io/badge/EN-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-CN"><img src="https://img.shields.io/badge/简中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=zh-TW"><img src="https://img.shields.io/badge/繁中-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ja"><img src="https://img.shields.io/badge/日本語-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ko"><img src="https://img.shields.io/badge/한국어-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=th"><img src="https://img.shields.io/badge/ไทย-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=fr"><img src="https://img.shields.io/badge/Français-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=de"><img src="https://img.shields.io/badge/Deutsch-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=es"><img src="https://img.shields.io/badge/Español-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=it"><img src="https://img.shields.io/badge/Italiano-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ru"><img src="https://img.shields.io/badge/Русский-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pt"><img src="https://img.shields.io/badge/Português-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=nl"><img src="https://img.shields.io/badge/Nederlands-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=pl"><img src="https://img.shields.io/badge/Polski-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=ar"><img src="https://img.shields.io/badge/العربية-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=tr"><img src="https://img.shields.io/badge/Türkçe-white" alt="version"></a> <a href="https://openaitx.github.io/view.html?user=GGBeng1&project=Gantt&lang=vi"><img src="https://img.shields.io/badge/Tiếng Việt-white" alt="version"></a> </p></div>
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
Biểu đồ Gantt phát triển dựa trên vue, có thể sử dụng cho các tình huống làm việc nhóm, phân chia nhiệm vụ trong các môi trường Agile

Hỗ trợ phân nhóm
Hỗ trợ kéo thả
Hỗ trợ kéo dãn
Hỗ trợ phần trăm
Hỗ trợ nhiều khung thời gian: ngày, tuần, tháng
Hiện tại chỉ mới viết nhóm cấp một, để tránh nhu cầu nhóm hai cấp hoặc đa cấp trong tương lai, ở lần cập nhật trước đã tái cấu trúc một phần mã nguồn, hỗ trợ nhóm nhiều cấp, tuy nhiên phiên bản hiện tại chưa phát triển

Ưu điểm: Khi thao tác kéo thả, kéo dãn, chỉnh sửa tiến độ, dữ liệu không cập nhật ngay lập tức mà chỉ cập nhật sau khi thao tác xong, giảm hao phí hiệu năng
         Khi chỉnh sửa, xóa, thêm mới, không thực hiện sửa đổi đệ quy toàn bộ instance mà chỉ thay đổi phần được chỉnh sửa

Đang chuẩn bị tổ chức lại để hướng tới dạng component, hiện tại nếu muốn sử dụng trong dự án chỉ cần import `gant.vue` trong dự án này là đủ
Phương pháp import/export dữ liệu hàng loạt đã viết sẵn, copy dùng trực tiếp!~

```

### Ghi chú cập nhật

- Hỗ trợ chỉnh sửa
- Hỗ trợ xóa
- Sửa lỗi không cuộn dọc được (đồng thời thêm cuộn đồng thời hai chiều) [#4](https://github.com/GGBeng1/Gantt/issues/4)
- Sửa lỗi gây ra bởi elementUI
- Vấn đề về khung thời gian [#5](https://github.com/GGBeng1/Gantt/issues/5)
- Hiện tại không thể thông qua thay đổi cấu hình khung thời gian để dùng các khung khác như thêm giờ v.v. Vì khi khởi tạo một số cấu hình đã cố định, sau này sẽ thay đổi và mở ra dưới dạng API


### Xem ví dụ

Xem [demo](https://ggbeng1.github.io/Gantt/#/)

### Hình minh họa

<img src="https://raw.githubusercontent.com/GGBeng1/Gantt/master/public/demo.png" alt="">

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---