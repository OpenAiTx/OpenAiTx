<picture>
  <source media="(prefers-color-scheme: dark)" srcset="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-white.svg">
  <img alt="Velopack Logo" src="https://raw.githubusercontent.com/velopack/velopack/develop/artwork/velopack-black.svg" width="400">
</picture>

---

[![Nuget](https://img.shields.io/nuget/v/Velopack?style=flat-square&logo=nuget&logoColor=white)](https://www.nuget.org/packages/Velopack/)
[![Discord](https://img.shields.io/badge/chat-Discord-5865F2?style=flat-square&logo=discord&logoColor=white)](https://discord.gg/M6he8ZPAAJ)
[![Build](https://img.shields.io/github/actions/workflow/status/velopack/velopack/build.yml?branch=develop&style=flat-square&logo=github&logoColor=white)](https://github.com/velopack/velopack/actions)
[![Codecov](https://img.shields.io/codecov/c/github/velopack/velopack?style=flat-square&logo=codecov&logoColor=white)](https://app.codecov.io/gh/velopack/velopack)
[![License](https://img.shields.io/github/license/velopack/velopack?style=flat-square)](https://github.com/velopack/velopack/blob/develop/LICENSE)

Velopack là một framework cài đặt và tự động cập nhật dành cho các ứng dụng đa nền tảng. Nó có quan điểm riêng, cực kỳ dễ sử dụng mà không cần cấu hình. Chỉ với một lệnh duy nhất, bạn đã có thể chạy ứng dụng với bộ cài đặt, và còn cực kỳ nhanh chóng cho người dùng cuối.

## Tính năng

- 😍 **Không cần cấu hình** – Velopack lấy kết quả biên dịch của bạn và tạo ra bộ cài đặt, bản cập nhật, các gói delta, và gói di động tự cập nhật chỉ với một lệnh.
- 🎯 **Đa nền tảng** – Velopack hỗ trợ xây dựng gói cho **Windows**, **OSX**, và **Linux**, giúp bạn chỉ cần một giải pháp cho tất cả các nền tảng.
- 🚀 **Di chuyển tự động** - Nếu bạn đang sử dụng các framework phổ biến khác (ví dụ [Squirrel](https://github.com/Squirrel/Squirrel.Windows)), Velopack có thể tự động di chuyển ứng dụng của bạn.
- ⚡️ **Cực nhanh** – Velopack được viết bằng Rust cho hiệu suất gốc. Gói delta giúp người dùng chỉ tải xuống những gì thay đổi giữa các phiên bản.
- 📔 **Không phụ thuộc ngôn ngữ** - Hỗ trợ C#, C++, JS, Rust và nhiều hơn nữa. Sử dụng API quen thuộc cho cập nhật dù dự án của bạn dùng ngôn ngữ nào.

https://github.com/velopack/velopack/assets/1287295/0ff1bea7-15ed-42ae-8bdd-9519f1033432

## Tài liệu
- 📖 [Đọc tài liệu](https://docs.velopack.io/)
- ⚡ [Hướng dẫn khởi động nhanh](https://docs.velopack.io/category/quick-start)
- 🕶️ [Xem các ứng dụng mẫu](https://docs.velopack.io/category/sample-apps)
- 📺 [Xem website & demo](https://velopack.io/)

## Cộng đồng
- ❓ Đặt câu hỏi, nhận hỗ trợ hoặc thảo luận ý tưởng tại [Discord](https://discord.gg/CjrCrNzd3F)
- 🗣️ Báo lỗi hoặc yêu cầu tính năng trên [GitHub Issues](https://github.com/velopack/velopack/issues)

## Đóng góp
- 💬 Tham gia cùng chúng tôi trên [Discord](https://discord.gg/CjrCrNzd3F) để tham gia các thảo luận phát triển
- 🚦 Đọc [hướng dẫn đóng góp](https://docs.velopack.io/category/contributing)

## Lời chứng thực 
Hiện tại tôi đã có ứng dụng hướng ra ngoài sử dụng velopack. Tôi rất ấn tượng. Có vẻ hoạt động cực kỳ tốt và nhanh hơn nhiều cả khi xây dựng lần đầu lẫn khi nâng cấp phần mềm trên máy người dùng cuối so với Squirrel. Thật tuyệt vời và là trình cài đặt tốt nhất mà tôi từng sử dụng trong hơn 30 năm làm phát triển. Cảm ơn rất nhiều! Bạn đang làm việc thật tuyệt vời!
[- Stefan (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1195642674078830613)

Chỉ muốn gửi lời cảm ơn to lớn. Tôi đã sử dụng Clowd.Squirrel vài năm nay kể từ khi Squirrel.Windows không còn phù hợp. Tình cờ ghé vào kho đó hôm nay để tìm tài liệu và phát hiện ra Velopack đã được phát hành. Thật bất ngờ! Nó hoạt động tuyệt vời và nhanh hơn rất nhiều, thật tuyệt! Cảm ơn bạn, lượng công việc bỏ ra cho cả Clowd.Squirrel và Velopack thật đáng kinh ngạc. Rất trân trọng.
[- Kizari (Discord)](https://discord.com/channels/767856501477343282/767856501477343286/1200837489640878180)

Tôi đã dùng rất nhiều framework cài đặt và Velopack là tốt nhất cho đến nay. Mọi thứ như có phép thuật: bạn chạy trình cài đặt, rồi ứng dụng tự động mở lên, sẵn sàng sử dụng. Cập nhật áp dụng và khởi động lại chỉ trong ~2 giây mà không có thông báo UAC. Quá trình tạo bộ cài đặt không đau đầu và tích hợp dễ dàng với ký mã, công cụ dòng lệnh giúp tải file cập nhật cực kỳ đơn giản. Bạn không cần phải lằng nhằng với các script cài đặt riêng ở ngôn ngữ lạ; bạn có thể xây dựng mọi hook vào chính ứng dụng của mình! Hỗ trợ cũng tuyệt vời; mọi thắc mắc của tôi đều được giải đáp. Đây là tương lai của trình cài đặt desktop.
[- RandomEngy (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1200897478036299861)

Tôi cực kỳ ấn tượng với hiệu suất của Velopack trong việc tạo bản phát hành cũng như kiểm tra và áp dụng cập nhật. Nó nhanh hơn đáng kể so với các công cụ khác. CLI vpk rất trực quan và dễ triển khai, ngay cả với pipeline build phức tạp của tôi. Nhờ Velopack, tôi đã tối ưu hóa quy trình làm việc và tiết kiệm thời gian quý báu. Đây là một công cụ tuyệt vời mà tôi rất khuyến nghị!
[- khdc (Discord)](https://discord.com/channels/767856501477343282/947444323765583913/1216460920696344576)

---

Powered By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---