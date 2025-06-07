# AutoGPT: Xây Dựng, Triển Khai và Vận Hành Các Tác Nhân AI

[![Discord Follow](https://dcbadge.vercel.app/api/server/autogpt?style=flat)](https://discord.gg/autogpt) &ensp;
[![Twitter Follow](https://img.shields.io/twitter/follow/Auto_GPT?style=social)](https://twitter.com/Auto_GPT) &ensp;
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)

**AutoGPT** là một nền tảng mạnh mẽ cho phép bạn tạo, triển khai và quản lý các tác nhân AI liên tục tự động hóa các quy trình phức tạp.

## Các Lựa Chọn Lưu Trữ 
   - Tải xuống để tự lưu trữ
   - [Tham gia danh sách chờ](https://bit.ly/3ZDijAI) cho bản beta lưu trữ đám mây  

## Cách Thiết Lập Để Tự Lưu Trữ
> [!LƯU Ý]
> Việc thiết lập và lưu trữ Nền tảng AutoGPT yêu cầu kiến thức kỹ thuật.
> Nếu bạn muốn một giải pháp hoạt động ngay, chúng tôi khuyên bạn nên [tham gia danh sách chờ](https://bit.ly/3ZDijAI) cho bản beta lưu trữ đám mây.

### Yêu Cầu Hệ Thống

Trước khi tiến hành cài đặt, hãy đảm bảo hệ thống của bạn đáp ứng các yêu cầu sau:

#### Yêu Cầu Phần Cứng
- CPU: Khuyến nghị 4 nhân trở lên
- RAM: Tối thiểu 8GB, khuyến nghị 16GB
- Lưu trữ: Tối thiểu 10GB dung lượng trống

#### Yêu Cầu Phần Mềm
- Hệ điều hành:
  - Linux (Khuyến nghị Ubuntu 20.04 hoặc mới hơn)
  - macOS (10.15 hoặc mới hơn)
  - Windows 10/11 với WSL2
- Phần mềm cần thiết (với phiên bản tối thiểu):
  - Docker Engine (20.10.0 hoặc mới hơn)
  - Docker Compose (2.0.0 hoặc mới hơn)
  - Git (2.30 hoặc mới hơn)
  - Node.js (16.x hoặc mới hơn)
  - npm (8.x hoặc mới hơn)
  - VSCode (1.60 hoặc mới hơn) hoặc bất kỳ trình soạn thảo mã nguồn hiện đại nào

#### Yêu Cầu Mạng
- Kết nối internet ổn định
- Truy cập vào các cổng cần thiết (sẽ được cấu hình trong Docker)
- Có thể thực hiện các kết nối HTTPS ra ngoài

### Hướng Dẫn Thiết Lập Mới Nhất:
Chúng tôi đã chuyển sang một trang tài liệu được duy trì và cập nhật thường xuyên.

👉 [Làm theo hướng dẫn tự lưu trữ chính thức tại đây](https://docs.agpt.co/platform/getting-started/)

Hướng dẫn này giả định bạn đã cài đặt Docker, VSCode, git và npm.

### 🧱 Giao Diện Người Dùng AutoGPT

Giao diện người dùng AutoGPT là nơi người dùng tương tác với nền tảng tự động hóa AI mạnh mẽ của chúng tôi. Nó cung cấp nhiều cách để bạn kết nối và khai thác các tác nhân AI. Đây là giao diện nơi bạn hiện thực hóa ý tưởng tự động hóa AI của mình:

   **Trình Xây Dựng Tác Nhân:** Dành cho những ai muốn tùy chỉnh, giao diện trực quan, ít mã cho phép bạn thiết kế và cấu hình tác nhân AI của riêng mình.
   
   **Quản Lý Quy Trình Làm Việc:** Xây dựng, chỉnh sửa và tối ưu quy trình tự động hóa dễ dàng. Bạn xây dựng tác nhân bằng cách kết nối các khối, mỗi khối thực hiện một hành động riêng lẻ.
   
   **Kiểm Soát Triển Khai:** Quản lý vòng đời của các tác nhân, từ thử nghiệm đến sản xuất.
   
   **Tác Nhân Sẵn Sàng Sử Dụng:** Không muốn tự xây dựng? Chỉ cần chọn từ thư viện tác nhân được cấu hình sẵn và sử dụng ngay lập tức.
   
   **Tương Tác Với Tác Nhân:** Dù bạn tự xây hay dùng tác nhân cấu hình sẵn, đều có thể dễ dàng chạy và tương tác qua giao diện thân thiện.
   
   **Giám Sát và Phân Tích:** Theo dõi hiệu suất tác nhân và nhận thông tin để cải thiện quy trình tự động hóa.

[Đọc hướng dẫn này](https://docs.agpt.co/platform/new_blocks/) để tìm hiểu cách xây dựng các khối tùy chỉnh của riêng bạn.

### 💽 Máy Chủ AutoGPT

Máy chủ AutoGPT là trung tâm sức mạnh của nền tảng. Đây là nơi các tác nhân của bạn hoạt động. Sau khi triển khai, các tác nhân có thể được kích hoạt từ các nguồn bên ngoài và vận hành liên tục. Nó chứa tất cả các thành phần thiết yếu giúp AutoGPT hoạt động trơn tru.

   **Mã Nguồn:** Logic cốt lõi điều khiển các tác nhân và quy trình tự động hóa.
   
   **Hạ Tầng:** Hệ thống mạnh mẽ đảm bảo hiệu suất ổn định và có thể mở rộng.
   
   **Chợ Ứng Dụng:** Một chợ toàn diện nơi bạn có thể tìm và triển khai nhiều tác nhân dựng sẵn.

### 🐙 Ví Dụ Về Tác Nhân

Dưới đây là hai ví dụ về những gì bạn có thể làm với AutoGPT:

1. **Tạo Video Lan Truyền Từ Các Chủ Đề Nổi Bật**
   - Tác nhân này đọc các chủ đề trên Reddit.
   - Xác định các chủ đề đang thịnh hành.
   - Tự động tạo video ngắn dựa trên nội dung đó.

2. **Nhận Diện Trích Dẫn Hay Nhất Từ Video Để Đăng Mạng Xã Hội**
   - Tác nhân này đăng ký kênh YouTube của bạn.
   - Khi bạn đăng video mới, nó sẽ phiên âm nội dung.
   - Sử dụng AI để xác định những trích dẫn ấn tượng nhất và tạo bản tóm tắt.
   - Sau đó, tự động viết bài đăng lên mạng xã hội của bạn.

Các ví dụ này chỉ là một phần nhỏ những gì bạn có thể làm với AutoGPT! Bạn có thể tạo các quy trình tùy chỉnh để xây dựng tác nhân cho bất kỳ trường hợp sử dụng nào.

---
### Sứ Mệnh và Giấy Phép
Sứ mệnh của chúng tôi là cung cấp công cụ để bạn tập trung vào những điều quan trọng:

- 🏗️ **Xây dựng** - Đặt nền móng cho điều tuyệt vời.
- 🧪 **Kiểm thử** - Tinh chỉnh tác nhân đến mức hoàn hảo.
- 🤝 **Ủy quyền** - Để AI làm việc cho bạn và biến ý tưởng thành hiện thực.

Hãy tham gia cuộc cách mạng! **AutoGPT** luôn tiên phong trong đổi mới AI.

**📖 [Tài liệu](https://docs.agpt.co)**
&ensp;|&ensp;
**🚀 [Đóng góp](CONTRIBUTING.md)**

**Giấy phép:**

Giấy phép MIT: Phần lớn kho AutoGPT tuân theo giấy phép MIT.

Giấy phép Polyform Shield: Áp dụng cho thư mục autogpt_platform.

Để biết thêm thông tin, xem https://agpt.co/blog/introducing-the-autogpt-platform

---
## 🤖 AutoGPT Classic
> Dưới đây là thông tin về phiên bản cổ điển của AutoGPT.

**🛠️ [Tự xây dựng Tác Nhân - Khởi động nhanh](classic/FORGE-QUICKSTART.md)**

### 🏗️ Forge

**Tự rèn tác nhân của bạn!** &ndash; Forge là bộ công cụ sẵn sàng sử dụng để xây dựng ứng dụng tác nhân riêng. Nó xử lý hầu hết mã khởi đầu, giúp bạn tập trung sáng tạo vào điểm khác biệt của *tác nhân của bạn*. Toàn bộ hướng dẫn nằm [tại đây](https://medium.com/@aiedge/autogpt-forge-e3de53cc58ec). Các thành phần từ [`forge`](/classic/forge/) cũng có thể dùng riêng lẻ để tăng tốc phát triển và giảm mã thừa cho dự án tác nhân.

🚀 [**Bắt đầu với Forge**](https://github.com/Significant-Gravitas/AutoGPT/blob/master/classic/forge/tutorials/001_getting_started.md) &ndash;
Hướng dẫn này sẽ chỉ bạn từng bước tạo tác nhân và sử dụng hệ thống benchmark cùng giao diện người dùng.

📘 [Tìm hiểu thêm](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/forge) về Forge

### 🎯 Benchmark

**Đo lường hiệu suất tác nhân của bạn!** `agbenchmark` có thể sử dụng với bất kỳ tác nhân nào hỗ trợ giao thức agent, và tích hợp với [CLI] của dự án giúp dễ dàng sử dụng với AutoGPT và các tác nhân dựa trên forge. Bộ benchmark cung cấp môi trường kiểm thử nghiêm ngặt. Khung kiểm thử của chúng tôi cho phép đánh giá tự động, khách quan, đảm bảo tác nhân sẵn sàng cho thực tiễn.

<!-- TODO: insert visual demonstrating the benchmark -->

📦 [`agbenchmark`](https://pypi.org/project/agbenchmark/) trên Pypi
&ensp;|&ensp;
📘 [Tìm hiểu thêm](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/benchmark) về Benchmark

### 💻 Giao Diện Người Dùng (UI)

**Giúp tác nhân dễ sử dụng!** `frontend` mang đến giao diện thân thiện để kiểm soát và giám sát tác nhân của bạn. Nó kết nối với các tác nhân qua [agent protocol](#-agent-protocol), đảm bảo tương thích với nhiều tác nhân bên trong và ngoài hệ sinh thái của chúng tôi.

<!-- TODO: insert screenshot of front end -->

Giao diện này sử dụng được ngay với tất cả các tác nhân trong kho. Chỉ cần dùng [CLI] để chạy tác nhân mà bạn muốn!

📘 [Tìm hiểu thêm](https://github.com/Significant-Gravitas/AutoGPT/tree/master/classic/frontend) về Giao Diện Người Dùng

### ⌨️ CLI

[CLI]: #-cli

Để dễ dàng sử dụng tất cả công cụ trong kho, một CLI đã được tích hợp tại thư mục gốc:

```shell
$ ./run
Usage: cli.py [OPTIONS] COMMAND [ARGS]...

Options:
  --help  Show this message and exit.

Commands:
  agent      Commands to create, start and stop agents
  benchmark  Commands to start the benchmark and list tests and categories
  setup      Installs dependencies needed for your system.
```

Chỉ cần clone kho, cài đặt phụ thuộc với `./run setup`, và bạn đã sẵn sàng sử dụng!

## 🤔 Câu hỏi? Vấn đề? Đề xuất?

### Nhận hỗ trợ - [Discord 💬](https://discord.gg/autogpt)

[![Tham gia Discord](https://invidget.switchblade.xyz/autogpt)](https://discord.gg/autogpt)

Để báo lỗi hoặc đề xuất tính năng, tạo một [GitHub Issue](https://github.com/Significant-Gravitas/AutoGPT/issues/new/choose). Hãy đảm bảo chưa có ai tạo issue về chủ đề đó trước.

## 🤝 Dự án liên kết

### 🔄 Agent Protocol

Nhằm duy trì tiêu chuẩn thống nhất và đảm bảo khả năng tương thích với nhiều ứng dụng hiện tại và tương lai, AutoGPT sử dụng tiêu chuẩn [agent protocol](https://agentprotocol.ai/) do AI Engineer Foundation phát triển. Tiêu chuẩn này chuẩn hóa đường truyền thông tin giữa tác nhân, giao diện người dùng và hệ thống benchmark.

---

## Thống kê ngôi sao (Stars)

<p align="center">
<a href="https://star-history.com/#Significant-Gravitas/AutoGPT">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=Significant-Gravitas/AutoGPT&type=Date" />
  </picture>
</a>
</p>


## ⚡ Những Người Đóng Góp

<a href="https://github.com/Significant-Gravitas/AutoGPT/graphs/contributors" alt="View Contributors">
  <img src="https://contrib.rocks/image?repo=Significant-Gravitas/AutoGPT&max=1000&columns=10" alt="Contributors" />
</a>

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---