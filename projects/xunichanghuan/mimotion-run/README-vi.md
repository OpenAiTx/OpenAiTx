# mimotion
![刷步数](https://github.com/xunichanghuan/mimotion-run/actions/workflows/run.yml/badge.svg)
[![GitHub forks](https://img.shields.io/github/forks/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/network)
[![GitHub stars](https://img.shields.io/github/stars/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/stargazers)
[![GitHub issues](https://img.shields.io/github/issues/xunichanghuan/mimotion-run?style=flat-square)](https://github.com/xunichanghuan/mimotion-run/issues)

# Tự động tăng số bước trên Xiaomi Sports

> Tự động tăng số bước trên Xiaomi Sports

## Hướng dẫn triển khai với Github Actions

### 1. Fork kho lưu trữ này

### 2. Thiết lập tài khoản và mật khẩu
# Thêm mới ngày 2023-02-24
Thêm biến có tên **CONFIG**: Settings-->Secrets-->New secret, cấu hình nhiều tài khoản theo mẫu json dưới đây, hỗ trợ email, số điện thoại
```
{
  "TG_BOT_TOKEN": "telegram TG_BOT_TOKEN, nếu không có, để trống",
  "TG_USER_ID": "telegram TG_USER_ID, nếu không có, để trống",
  "SKEY": "skey của KooPush, nếu không có, để trống",
  "SCKEY": "sckey của Server酱, nếu không có, để trống",
  "POSITION": "Bật thông báo qua WeCom, nếu không có, để trống",
  "CORPID": "ID doanh nghiệp, đăng nhập WeCom, xem trong Thông tin doanh nghiệp, nếu không có, để trống",
  "CORPSECRET": "Secret ứng dụng tự tạo trên WeCom, mỗi ứng dụng có secret riêng, nếu không có, để trống",
  "AGENTID": "ID ứng dụng tự tạo trên WeCom, nhập số nguyên, là AgentId, nếu không có, để trống",
  "TOUSER": "Danh sách ID thành viên nhận tin nhắn (nhiều người dùng dấu ”&#166;” ngăn cách, tối đa 1000). Đặc biệt: nhập ”@all” sẽ gửi cho tất cả thành viên ứng dụng. Nếu không có, để trống",
  "TOPARTY": "Danh sách ID phòng ban nhận tin nhắn (nhiều phòng ban dùng dấu ”&#166;” ngăn cách, tối đa 100). Khi touser là ”@all” thì nhập ”@all”, nếu không có, để trống",
  "TOTAG": "Danh sách ID nhãn nhận tin nhắn (nhiều nhãn dùng dấu ”&#166;” ngăn cách, tối đa 100). Khi touser là ”@all” thì nhập ”@all”, nếu không có, để trống",
  "OPEN_GET_WEATHER": "Bật giảm số bước theo thời tiết khu vực, nếu không có, để trống",
  "AREA": "Cài đặt khu vực lấy thời tiết (phải nhập nếu bật ở trên), ví dụ: 北京, nếu không có, để trống",
  "QWEATHER": "Nhập Private KEY của QWeather, đăng ký tại https://console.qweather.com/#/apps, nếu không có, để trống",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Nhập số bước tối đa cho tài khoản phụ, tham khảo trên",
      "min_step": "Nhập số bước tối thiểu cho tài khoản phụ, tham khảo trên",
      "password": "Nhập mật khẩu tài khoản phụ, tham khảo trên",
      "user": "Nhập số điện thoại tài khoản phụ, tham khảo trên"
    }
  ]
}
```
> Thêm biến có tên **PAT**: Settings-->Secrets-->New secret

| Secrets |  Định dạng  |
| ------- | ---------- |
| PAT     |   **PAT** cần được tạo, giá trị là github token, hướng dẫn chi tiết: https://www.jianshu.com/p/bb82b3ad1d11 , cần quyền repo và workflow, mục này bắt buộc để tránh lỗi quyền git push. |

**Ví dụ CONFIG**
```
{
  "TG_BOT_TOKEN": "",
  "TG_USER_ID": "",
  "SKEY": "",
  "SCKEY": "",
  "POSITION": "",
  "CORPID": "",
  "CORPSECRET": "",
  "AGENTID": "",
  "TOUSER": "",
  "TOPARTY": "",
  "TOTAG": "",
  "OPEN_GET_WEATHER": "",
  "AREA": "",
  "QWEATHER": "",
  "MIMOTION": [
    {
      "max_step": "20000",
      "min_step": "10000",
      "password": "Sitoi",
      "user": "18888xxxxxx"
    },
    {
      "max_step": "Nhập số bước tối đa cho tài khoản phụ, tham khảo trên",
      "min_step": "Nhập số bước tối thiểu cho tài khoản phụ, tham khảo trên",
      "password": "Nhập mật khẩu tài khoản phụ, tham khảo trên",
      "user": "Nhập số điện thoại tài khoản phụ, tham khảo trên"
    }
  ]
}
```

### 3. Tùy chỉnh thời gian khởi động

Chỉnh sửa **random_cron.sh**
Sửa thời gian trong câu lệnh **if** thành giờ UTC, tức là **giờ Bắc Kinh - 8**, ví dụ giờ Bắc Kinh là 8h thì giờ UTC là 0h, muốn chạy vào giờ nào thì lấy giờ cần chạy trừ 8 sẽ ra giờ UTC



## Lưu ý

1. Chạy 7 lần mỗi ngày, được kiểm soát bởi random_cron.sh, phút sẽ là giá trị ngẫu nhiên

2. Số lượng tài khoản và mật khẩu phải khớp nhau, nếu không sẽ không sử dụng được!!!

3. Thời gian khởi động phải là giờ UTC!

4. Đăng ký server酱 tại [bấm vào đây](https://sct.ftqq.com/)

5. Nếu Alipay không cập nhật số bước, vào Xiaomi Sports -> Cài đặt -> Tài khoản -> Đăng xuất tài khoản -> Xóa dữ liệu, sau đó đăng nhập lại, liên kết lại bên thứ ba

6. Xiaomi Sports sẽ không tự cập nhật số bước, chỉ những dịch vụ liên kết mới đồng bộ!!!!!!

7. Khi sử dụng hãy Fork [nhánh chính](https://github.com/xunichanghuan/mimotion-run/) để tránh lỗi không mong muốn.

8. Lưu ý, tài khoản không phải là [tài khoản Xiaomi], mà là tài khoản của [Xiaomi Sports].

## Số lượng Star trong lịch sử

[![Stargazers over time](https://starchart.cc/xunichanghuan/mimotion-run.svg)](https://starchart.cc/xunichanghuan/mimotion-run)

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx) - 2025-06-07

---