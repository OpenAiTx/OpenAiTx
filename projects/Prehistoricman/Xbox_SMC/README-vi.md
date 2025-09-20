
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
Các bản dump PIC16/Xyclops từ Xbox gốc và cơ sở dữ liệu IDA với một số nội dung dịch ngược đã thực hiện.

![Hình ảnh PIC16LC63A từ Xbox gốc](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# Flash Xyclops (XycloMod)
Xem [thư mục Xyclops và README](/Xyclops)

# Các bản Dump
Tệp .bin cho mỗi bản dump PIC đã được hoán đổi byte để tải đúng vào IDA. Vì vậy, từ đầu tiên của bộ nhớ PIC là byte_0 + byte_1 << 8.

Cơ sở dữ liệu .idb của IDA có thông tin về biến và một số nhận xét trên notepad của cơ sở dữ liệu.

Xem trang wiki này để biết phân tích các phiên bản SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
Được dump từ Xbox DVT3. Từ cấu hình giống với P01. Nó cũng có ID thiết bị được ghi trong vùng cấu hình là 0000 0000 000B 002A, không giống các PIC sản xuất.

Hoàn toàn thiếu thử thách khởi động.

## D01
Được dump từ XDK BETA 2 Xbox. Giống hệt với P01 ngoại trừ việc thiếu thử thách khởi động. Hàm tính toán phản hồi thử thách khởi động vẫn còn đó, nhưng không bao giờ được gọi.

## DXF
Được dump từ bộ kit debug XDK D2. Rất giống với D01 nhưng có logic khay, logic quá nhiệt và logic khởi động hơi khác. Thử thách khởi động bị thiếu giống như D01.

## D2E
Được dump từ bộ kit phát triển Tuscany (v1.6). Chip Xyclops được đánh dấu X01202-001, và thiếu dòng A-A02 hoặc A-B01 mà các đơn vị bán lẻ có.

Mã nối tiếp debug tại FC00 khớp với bản dump P2L bán lẻ. Có một mẫu dữ liệu lạ từ 0x4000 đến 0xFBFF.

## P01
Được dump từ Xbox v1.0. Từ cấu hình là 0x86:
- CP1:CP0 = 0 (Bật bảo vệ mã cho toàn bộ bộ nhớ)
- BODEN = 0 (Vô hiệu hóa reset brown-out)
- ~PWRTE = 0 (Bật bộ định thời khởi động)
- WDTE = 1 (Bật bộ định thời watchdog)
- FOSC1:FOSC0 = 2 (Bộ dao động HS)

Giá trị cấu hình 0x3FB6 phù hợp cho các bản sao SMC để không có bảo vệ mã được bật.

## P11
Được dump từ Xbox v1.3. Từ cấu hình giống như P01.

Có một vài thay đổi nhỏ trong P11 so với P01 bao gồm thêm một lệnh SMBus (ghi 0x22), ưu tiên LED khác nhau, và thời gian khởi động thoải mái hơn.

Tôi đã kiểm tra các bản dump bị xáo trộn của v1.3 so với v1.4 và chúng khớp nhau. Điều này có nghĩa rất có khả năng chúng dùng cùng một chương trình.

## P2L
Được trích xuất từ Xbox v1.6. Phiên bản Xyclops A-A02. Nó chứa mã Intel 8051 nhưng có nhiều thanh ghi chức năng đặc biệt với chức năng chưa rõ.

Cổng debug serial được cấp nguồn bởi mã tại FC00. Có vẻ như là một trình debug thô sơ có thể tạm dừng thực thi, trích xuất dữ liệu và ghi vào thanh ghi/RAM.

# Trích xuất Xyclops

Chip Xyclops có 3 chân dành cho 'debug': TXD (chân 64), RXD (chân 63), và DEBUG (chân 29). Đặt chân DEBUG lên mức cao để kích hoạt cổng serial trên các chân TX và RX. Serial hoạt động ở tốc độ 9600 baud.

Giao thức dựa trên các lệnh 4 byte, thường có định dạng `<cmd>` `<địa chỉ MSByte>` `<địa chỉ LSByte>` `<không quan tâm>`

Lệnh 0x14 trích xuất ra 64 byte dữ liệu BIOS mỗi lần và lệnh 0x15 trích xuất 64 byte dữ liệu chương trình SMC mỗi lần. Một bản dump từ Xyclops, P2L.bin, đã được đưa vào repo. [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) cũng được cung cấp để bạn trích xuất máy của riêng mình.

# Phương pháp trích xuất PIC
Bài viết đầy đủ tại https://wiki.recessim.com/view/PIC_Burnout

PIC đã bật chế độ bảo vệ mã nên tất cả dữ liệu đọc được đều là 0000. Tôi đã dùng một mẹo để lấy dữ liệu bị xáo trộn, phát hiện thuật toán xáo trộn bằng một con chip hi sinh, rồi dùng một kiểu khai thác để thay đổi dữ liệu ROM nhằm sửa một số bit về giá trị đã biết. Sau đó, tôi có thể trích xuất thông tin cần thiết từ nhiều bản dump bị xáo trộn để phục hồi dữ liệu gốc.

# PICProgrammer
PICProgrammer là một trong vài dự án Arduino dành cho RP2040 mà tôi đã sử dụng trong nghiên cứu. Nó cung cấp giao diện dòng lệnh đơn giản để thực hiện các thao tác ICSP (lập trình nối tiếp trong mạch) trên PIC. Giải pháp này được ưu tiên hơn dùng các thiết bị lập trình chuyên dụng như PICkit do tính linh hoạt và khả năng thực hiện các thao tác mà nhà sản xuất không dự kiến.

Bạn nên hiểu rõ về điện tử và lập trình trước khi sử dụng, và hãy xem kỹ các lệnh sẽ thực thi trước khi thực hiện chúng.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---