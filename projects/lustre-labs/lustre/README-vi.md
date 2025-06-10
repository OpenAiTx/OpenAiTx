<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Làm cho giao diện của bạn tỏa sáng</strong> ✨
</div>

<div align="center">
  Một framework để xây dựng ứng dụng Web bằng Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Có sẵn trên Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Tài liệu" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Bắt đầu nhanh
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Tham khảo
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Được xây dựng với ❤︎ bởi
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> và
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    các cộng tác viên
  </a>
</div>

---

## Mục lục

- [Tính năng](#features)
- [Ví dụ](#example)
- [Triết lý](#philosophy)
- [Cài đặt](#installation)
- [Tiếp theo](#where-next)
- [Hỗ trợ](#support)

## Tính năng {#features}

- Một API **khai báo**, hướng hàm để xây dựng HTML. Không template, không macro,
  chỉ có Gleam.

- Kiến trúc lấy cảm hứng từ Erlang và Elm để **quản lý trạng thái**.

- **Quản lý hiệu ứng phụ** để đảm bảo mã dự đoán được, dễ kiểm thử.

- Thành phần phổ dụng. **Viết một lần, chạy mọi nơi**. Elm gặp Phoenix LiveView.

- **CLI đầy đủ tiện ích** giúp tạo khung và xây dựng ứng dụng dễ dàng.

- **Render phía máy chủ** cho việc tạo template HTML tĩnh.

## Ví dụ {#example}

Lustre đi kèm với [hơn 20 ví dụ](https://hexdocs.pm/lustre/reference/examples.html)!
Đây là cách nó trông như sau:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Triết lý {#philosophy}

Lustre là một framework _có quan điểm rõ ràng_ để xây dựng các ứng dụng Web vừa và nhỏ.
Phát triển frontend hiện đại rất khó và phức tạp. Một phần của sự phức tạp đó là cần thiết, nhưng phần lớn là do ngẫu nhiên hoặc do có quá nhiều lựa chọn. Lustre có triết lý thiết kế giống với Gleam: nếu có thể, chỉ nên có một cách để làm việc đó.

Điều này có nghĩa là Lustre chỉ cung cấp một hệ thống quản lý trạng thái duy nhất, lấy cảm hứng từ Elm và Erlang/OTP. Khi mở bất kỳ ứng dụng Lustre nào, bạn sẽ cảm thấy quen thuộc ngay lập tức.

Nó cũng có nghĩa là chúng tôi khuyến khích các phương pháp đơn giản để xây dựng view thay vì các giải pháp phức tạp. Lustre _có_ cách tạo các thành phần trạng thái đóng gói (điều mà chúng tôi rất thiếu trong Elm) nhưng không nên coi đó là mặc định. Nên ưu tiên các hàm đơn giản hơn thành phần có trạng thái.

Khi thành phần _là_ cần thiết, hãy tận dụng thực tế rằng các thành phần Lustre có thể chạy _mọi nơi_. Lustre cung cấp cho bạn công cụ để viết các thành phần có thể chạy trong một ứng dụng Lustre sẵn có, xuất chúng dưới dạng Web Component độc lập, hoặc chạy phía máy chủ với runtime tối giản để cập nhật DOM. Lustre gọi chúng là **thành phần phổ dụng** và chúng được viết với nhiều mục tiêu của Gleam trong đầu.

## Cài đặt {#installation}

Lustre đã được phát hành trên [Hex](https://hex.pm/packages/lustre)! Bạn có thể thêm nó vào
dự án Gleam của mình từ dòng lệnh:

```sh
gleam add lustre
```

Lustre cũng có một gói đi kèm chứa các công cụ phát triển mà bạn có thể muốn cài đặt:

> **Lưu ý**: máy chủ phát triển lustre_dev_tools theo dõi hệ thống tập tin của bạn để
> phát hiện thay đổi code gleam và có thể tự động tải lại trình duyệt. Với người dùng linux, cần cài đặt [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## Tiếp theo {#where-next}

Để làm quen với Lustre, hãy xem [hướng dẫn bắt đầu nhanh](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Nếu bạn thích xem code, thư mục [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
chứa một số ứng dụng nhỏ minh họa các khía cạnh khác nhau của framework.

Bạn cũng có thể đọc tài liệu và tham khảo API tại
[HexDocs](https://hexdocs.pm/lustre).

## Hỗ trợ {#support}

Lustre chủ yếu được xây dựng bởi một mình tôi, [Hayleigh](https://github.com/hayleigh-dot-dev),
trong thời gian rảnh giữa hai công việc. Nếu bạn muốn ủng hộ công việc của tôi, bạn có thể [tài trợ cho tôi trên GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Chúng tôi cũng rất hoan nghênh mọi đóng góp! Nếu bạn phát hiện lỗi, hoặc muốn
đề xuất tính năng, hãy mở issue hoặc pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---