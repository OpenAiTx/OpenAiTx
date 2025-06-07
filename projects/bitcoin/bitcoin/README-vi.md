Cây tích hợp/giai đoạn của Bitcoin Core
=======================================

https://bitcoincore.org

Để tải về phiên bản nhị phân của phần mềm Bitcoin Core có thể sử dụng ngay, xem tại
https://bitcoincore.org/en/download/.

Bitcoin Core là gì?
-------------------

Bitcoin Core kết nối với mạng ngang hàng của Bitcoin để tải về và xác thực đầy đủ các khối và giao dịch. Nó cũng bao gồm một ví và giao diện người dùng đồ họa, có thể được xây dựng thêm tùy chọn.

Thông tin chi tiết về Bitcoin Core có trong [thư mục doc](/doc).

Giấy phép
---------

Bitcoin Core được phát hành theo các điều khoản của giấy phép MIT. Xem [COPYING](COPYING) để biết thêm thông tin hoặc truy cập https://opensource.org/license/MIT.

Quy trình phát triển
--------------------

Nhánh `master` được xây dựng thường xuyên (xem `doc/build-*.md` để biết hướng dẫn) và được kiểm thử, nhưng không đảm bảo hoàn toàn ổn định. [Tag](https://github.com/bitcoin/bitcoin/tags) được tạo
định kỳ từ các nhánh phát hành để chỉ định các phiên bản phát hành chính thức, ổn định mới của Bitcoin Core.

Kho lưu trữ https://github.com/bitcoin-core/gui chỉ được sử dụng cho việc phát triển GUI. Nhánh master của nó giống hệt trong tất cả các kho monotree.
Không tồn tại các nhánh phát hành và tag, vì vậy vui lòng không fork kho lưu trữ đó trừ khi vì lý do phát triển.

Quy trình đóng góp được mô tả trong [CONTRIBUTING.md](CONTRIBUTING.md)
và các gợi ý hữu ích cho nhà phát triển có thể tìm thấy trong [doc/developer-notes.md](doc/developer-notes.md).

Kiểm thử
--------

Kiểm thử và rà soát mã nguồn là nút thắt cổ chai của quá trình phát triển; chúng tôi nhận được nhiều pull request hơn khả năng rà soát và kiểm thử trong thời gian ngắn. Vui lòng kiên nhẫn và hỗ trợ bằng cách kiểm thử pull request của người khác, và hãy nhớ đây là một dự án có tính bảo mật cao, bất kỳ sai sót nào cũng có thể khiến mọi người mất nhiều tiền.

### Kiểm thử tự động

Các nhà phát triển được khuyến khích mạnh mẽ viết [kiểm thử đơn vị](src/test/README.md) cho mã mới, và gửi kiểm thử đơn vị mới cho mã cũ. Kiểm thử đơn vị có thể được biên dịch và chạy (nếu chúng không bị tắt khi tạo hệ thống build) bằng lệnh: `ctest`. Thông tin chi tiết về cách chạy và mở rộng kiểm thử đơn vị có thể tìm thấy tại [/src/test/README.md](/src/test/README.md).

Ngoài ra còn có [kiểm thử hồi quy và kiểm thử tích hợp](/test), được viết bằng Python.
Các kiểm thử này có thể chạy (nếu đã cài đặt [các phụ thuộc kiểm thử](/test)) bằng lệnh: `build/test/functional/test_runner.py`
(giả sử `build` là thư mục build của bạn).

Các hệ thống CI (Tích hợp liên tục) đảm bảo mọi pull request đều được build cho Windows, Linux, và macOS,
và kiểm thử đơn vị/kiểm thử sanity được chạy tự động.

### Kiểm thử Đảm bảo Chất lượng (QA) thủ công

Các thay đổi nên được kiểm thử bởi người khác ngoài nhà phát triển đã viết mã. Điều này đặc biệt quan trọng với các thay đổi lớn hoặc có rủi ro cao. Nên thêm một kế hoạch kiểm thử vào mô tả pull request nếu việc kiểm thử các thay đổi không đơn giản.

Dịch thuật
----------

Các thay đổi về dịch thuật cũng như các bản dịch mới có thể được gửi lên
[trang Transifex của Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Các bản dịch sẽ được lấy định kỳ từ Transifex và hợp nhất vào kho git. Xem
[quy trình dịch thuật](doc/translation_process.md) để biết chi tiết về cách hoạt động của quy trình này.

**Lưu ý quan trọng**: Chúng tôi không chấp nhận các thay đổi dịch thuật dưới dạng pull request trên GitHub vì lần lấy tiếp theo từ Transifex sẽ tự động ghi đè các thay đổi đó.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---