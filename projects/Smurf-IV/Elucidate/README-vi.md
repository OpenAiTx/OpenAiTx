
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Smurf-IV&project=Elucidate&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

﻿# Elucidate

- [Mô tả Dự án](#project-description)
- [Yêu cầu hệ thống:](#os-requirements)
- [Câu hỏi thường gặp](#faqs)
- [lộ trình](#roadmap)
- [Ảnh chụp màn hình](#screenshots)

## Mô tả Dự án

Elucidate là một giao diện đồ họa người dùng (GUI) trên Windows cho ứng dụng dòng lệnh SnapRAID.

*Dự án này tiếp tục sự tổng hợp từ những đóng góp tuyệt vời của tôi và các cộng tác viên khác.

## Yêu Cầu Hệ Thống

- Hệ điều hành Windows
- .Net Runtime 4.8.0
- SnapRaid Phiên bản 11.5 hoặc thấp hơn
- 10MB dung lượng trống trên ổ đĩa đích

## Câu Hỏi Thường Gặp

**H**: SnapRAID là gì?<br/>
**Đ**: SnapRAID là một công cụ phần mềm tạo ảnh chụp nhanh dựa trên parity cho các hệ điều hành Windows và Linux. Ở mức cơ bản nhất, nó bảo vệ nội dung của hệ thống tệp dưới sự quản lý của nó bằng cách tính toán các hash của các tệp thành phần và lưu kết quả vào một tệp parity. Trong trường hợp xảy ra lỗi ổ cứng hoàn toàn, tệp parity này có thể được dùng để khôi phục dữ liệu bị mất. Xem chi tiết đầy đủ tại [so sánh chính thức về các công cụ bảo vệ tệp của SnapRAID.](http://snapraid.sourceforge.net/compare.html)

**H**: Tại sao lại cần GUI, dòng lệnh đã chạy tốt mà!<br/>
**Đ**: Mục tiêu lớn hơn là tạo ra một GUI đầy đủ chức năng với các tính năng quản lý bổ sung để hỗ trợ người dùng duy trì môi trường SnapRAID hoạt động ổn định. Đôi khi, “nhấn chuột” sẽ dễ dàng hơn cho người mới bắt đầu. Tài liệu kỹ thuật và khả năng cấu hình sâu của SnapRAID có thể khiến người dùng ngại thử nghiệm!

**H**: Tôi vẫn còn băn khoăn, có thêm thông tin gì không?<br/>
**Đ**: Có, hãy xem qua [tài liệu hướng dẫn](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./docs/Documentation.md) để xem hình ảnh minh họa v.v.

**H**: Vậy “Mục tiêu Lớn hơn” là gì?<br/>
**Đ**: Xem __Lộ trình phát triển__ bên dưới để biết chi tiết.

## Lộ trình phát triển

- [x] Giai đoạn I
  - [x] Cố gắng hỗ trợ tối thiểu phiên bản SnapRAID mới nhất. - __Đang tiếp tục.__
  - [x] Dễ sử dụng
  - [x] SnapRAID có ba lệnh, hãy làm cho chúng dễ truy cập cho người mới 
  - [x] Hiển thị tiến trình 
  - [x] Ghi log "Tương tác" và trực tiếp vào tệp log. 
  - [x] Tự động khởi động khi người dùng đăng nhập 
  - [x] Hướng dẫn bằng tool-tip •	

- [x] Giai đoạn II Yêu cầu tính năng Giai đoạn II
  - [x] Tạm dừng, Thay đổi ưu tiên, Hủy.
  - [x] Mở rộng Lệnh - "Cho phép các tham số bổ sung cho các giá trị mặc định được sử dụng."
  - [x] Lên lịch 
    - Đã loại bỏ, sử dụng CommandLine
  - [x] Xem dạng đồ họa của dữ liệu được bảo vệ.

- [ ] Giai đoạn III (Khởi động lại từ 2017-03 trở đi)
  - [x] Trình biên dịch mới và .Net 4.7.x	
  - [x] Giao diện dòng lệnh
  - [ ] Bố cục mới qua Krypton Toolkit / Navigator / v.v. 
    - Đang thực hiện
  - [ ] Dịch thuật 
  - [x] Lệnh mới
  - [ ] Trình gửi thư với báo cáo trạng thái
  - [ ] Tài liệu các bước kiểm thử
    - Đang thực hiện
  - [ ] Thêm vào Tài liệu / Cập nhật Hình ảnh
    - Đang thực hiện
  - [ ] Thêm báo cáo _Windows EventLog_ cho các lỗi
  - [x] Thêm _ExceptionLess_ để báo cáo lỗi trực tuyến
  - [x] Hiển thị những gì có thể được phục hồi. 

- [ ] Giai đoạn IV (Lệnh SnapRAID mới ?) 
  - [ ] Trợ giúp mở rộng với phục hồi đĩa - hướng dẫn tương tác v.v..
  - [ ] Thông báo cho người dùng nếu phiên bản SnapRAID đã lỗi thời
  - [ ] Diễn giải nhật ký SnapRAID (được sử dụng bởi các thay đổi bên dưới)
  - [ ] Cung cấp trạng thái của mảng sau khi chạy lệnh
  - [ ] Sửa đổi lệnh sync để bao gồm so sánh ban đầu
  - [ ] Sửa đổi lệnh sync để cảnh báo nếu diff báo cáo vấn đề vượt quá ngưỡng
  - [ ] Thêm cài đặt người dùng cấu hình cho yêu cầu ngưỡng đồng bộ hóa


## Ảnh chụp màn hình

![Giao diện khởi động](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/starting_view.png)

![Biểu mẫu Cài đặt](https://raw.githubusercontent.com/Smurf-IV/Elucidate/master/./Images/Settings_Form.PNG)


## Bạn có thể giúp không ? 
- Đang tìm kiếm người kiểm thử (Tất cả nền tảng .Net)
- Có thể giúp dịch
- Hỗ trợ / Hướng dẫn giao diện người dùng
- Bất kỳ ý tưởng nào khác :-)
- Các nhà phát triển cho những ý tưởng đó


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-30

---