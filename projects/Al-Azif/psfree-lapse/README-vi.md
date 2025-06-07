# PSFree phiên bản 1.5.1

PSFree là một tập hợp các khai thác cho máy chơi game PS4. Trọng tâm chính của kho lưu trữ là cho PS4, nhưng chúng tôi cố gắng làm cho mọi thứ có thể chuyển đổi sang PS5.

## Tính năng

- **Tự động nhận diện:** Tự động nhận diện loại máy chơi game và phiên bản firmware (qua [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **Khai thác WebKit (PSFree):** Điểm nhập qua trình duyệt web của máy.
- **Khai thác Kernel (Lapse):** Nâng cấp đặc quyền lên cấp kernel.
- **Trình tải Payload:** Sau khi khai thác kernel thành công sẽ lắng nghe payload trên cổng 9020.

## Phạm vi lỗ hổng

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Được hỗ trợ bởi kho lưu trữ này

Bảng này chỉ ra các phiên bản firmware mà _phiên bản hiện tại_ của kho lưu trữ này cung cấp chuỗi khai thác hoạt động và đã được kiểm tra.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Lưu ý: Hỗ trợ cho các firmware khác được liệt kê trong bảng "Phạm vi lỗ hổng" có thể hoặc không được phát triển tích cực hoặc có thể đã được hỗ trợ ở các phiên bản trước của kho lưu trữ này. Vui lòng kiểm tra [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) để biết lịch sử hỗ trợ._

## Danh sách TODO

- [ ] Vấn đề màn hình đen/lưu với một số trò chơi nhất định
- [ ] `lapse.mjs`: Chỉ cần thiết lập bit cho đặc quyền JIT
- [ ] `view.mjs`: Giả định PS4, cần hỗ trợ PS5
- [ ] Thêm hỗ trợ PS5

## Bản quyền và Tác giả:

AGPL-3.0-or-later (xem [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Kho lưu trữ này thuộc về nhóm `anonymous`. Chúng tôi gọi các cộng tác viên ẩn danh là "anonymous".

## Ghi công:

- anonymous cho các bản dump kernel firmware PS4
- Kiểm tra các tệp tương ứng để biết các cộng tác viên **bổ sung**. Trừ khi có ghi chú khác, mọi thứ ở đây cũng có thể được ghi nhận cho chúng tôi.

## Quyên góp

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---