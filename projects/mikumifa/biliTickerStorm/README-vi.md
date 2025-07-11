# 🎫 BiliTickerStorm

## ⚙️ Mô tả dịch vụ

| Tên dịch vụ        | Mô tả                   | Ghi chú       |
| ------------------ | ----------------------- | ------------- |
| `ticket-master`    | Dịch vụ điều khiển chính, chịu trách nhiệm điều phối nhiệm vụ | Triển khai đơn phiên bản |
| `ticket-worker`    | Worker săn vé, có thể mở rộng theo chiều ngang | Hỗ trợ đa phiên bản |
| `gt-python`        | Dịch vụ xử lý mã xác thực hình ảnh | Triển khai đơn phiên bản |

---

## 🚀 Các bước triển khai nhanh

> Tham khảo [Hướng dẫn xây dựng cụm](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) để xây dựng cụm.

<details> <summary><strong>📦 Cài đặt từ kho lưu trữ từ xa (Khuyến nghị)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. Cài đặt Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` là thư mục chứa file cấu hình mua vé, được mount cho container `ticket-master`. File cấu hình mua vé được tạo bằng https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` là cấu hình thông báo pushplus, sau khi thiết lập có thể nhận được thông báo kết quả mua vé.
> - `ticketWorker.ticketInterval` là khoảng thời gian giữa các lần mua vé, đơn vị là mili giây, mặc định là 300 mili giây.
> - `ticketWorker.ticketTimeStart` là thời gian bắt đầu theo lịch, định dạng `2025-05-20T13:14`, nếu không điền thì container sẽ bắt đầu mua vé ngay khi được mở.

### 3. Nâng cấp Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
---
</details> 
<details> <summary><strong>📦 Cài đặt Chart cục bộ</strong></summary>


### 1. Cài đặt Chart

```bash
# Clone kho lưu trữ
git clone https://github.com/mikumifa/biliTickerStorm
# Sử dụng gói Chart cục bộ
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/duong/dan/du/lieu/cua/ban \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. Nâng cấp Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 Lệnh chung</strong></summary>

### ⏹ Gỡ cài đặt
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 Tuyên bố miễn trừ trách nhiệm

Dự án này tuân thủ theo giấy phép MIT License, chỉ dùng cho mục đích học tập và nghiên cứu cá nhân. Vui lòng không sử dụng dự án này cho bất kỳ hoạt động thương mại trục lợi nào, đồng thời nghiêm cấm sử dụng cho bất kỳ hình thức cướp đoạt tự động, hành vi vi phạm pháp luật hoặc trái với quy định của nền tảng liên quan. Mọi hậu quả phát sinh từ việc sử dụng dự án này sẽ do người dùng tự chịu trách nhiệm, không liên quan đến tác giả.

Nếu bạn fork hoặc sử dụng dự án này, vui lòng tuân thủ pháp luật hiện hành và quy định của nền tảng mục tiêu.

## 💡 Về tần suất truy cập và kiểm soát đồng thời
Dự án này được thiết kế tuân thủ nghiêm ngặt nguyên tắc “không xâm lấn”, tránh gây bất kỳ sự can thiệp nào đến máy chủ đích (như Bilibili).

Tất cả khoảng thời gian giữa các yêu cầu mạng đều do người dùng tự cấu hình, giá trị mặc định mô phỏng tốc độ thao tác thủ công của người dùng thông thường. Chương trình mặc định chạy đơn luồng, không có tác vụ đồng thời. Khi gặp lỗi yêu cầu, chương trình sẽ thử lại với số lần giới hạn, đồng thời chèn khoảng thời gian trễ hợp lý giữa các lần thử lại, tránh tạo ra các điểm truy cập với tần suất cao. Dự án hoàn toàn dựa vào các giao diện công khai và cấu trúc trang web của nền tảng, không chứa các biện pháp phá hoại như né tránh kiểm soát rủi ro, chiếm quyền API, v.v.
## 🛡️ Tuyên bố tôn trọng nền tảng

Chương trình này đã được thiết kế để kiểm soát tần suất yêu cầu ở mức tối đa có thể, nhằm tránh gây ra bất kỳ tải trọng hoặc ảnh hưởng rõ rệt nào đến máy chủ Bilibili. Dự án chỉ phục vụ mục đích học tập, không có khả năng mở rộng quy mô lớn, xử lý đồng thời cao, và hoàn toàn không có bất kỳ hành vi độc hại hoặc ý đồ gây gián đoạn dịch vụ nào.

Nếu trong dự án này có bất kỳ nội dung nào xâm phạm quyền lợi hợp pháp của công ty Bilibili, xin vui lòng liên hệ với tôi qua email [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com). Tôi sẽ ngay lập tức gỡ bỏ nội dung liên quan và xóa kho lưu trữ này. Tôi xin chân thành xin lỗi về những bất tiện gây ra và cảm ơn sự thông cảm cũng như bao dung của bạn.

## 📄 Giấy phép

[Giấy phép MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---