# future-queue

[![future-queue on crates.io](https://img.shields.io/crates/v/future-queue)](https://crates.io/crates/future-queue)
[![Documentation (latest release)](https://img.shields.io/badge/docs-latest-brightgreen.svg)](https://docs.rs/future-queue/)
[![Documentation (main)](https://img.shields.io/badge/docs-main-purple)](https://nextest-rs.github.io/future-queue/rustdoc/future_queue)
[![Changelog](https://img.shields.io/badge/changelog-latest-blue)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CHANGELOG.md)
[![License](https://img.shields.io/badge/license-Apache-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT)

`future_queue` cung cấp các phương thức để chạy nhiều future:

* song song
* theo thứ tự chúng được sinh ra
* với giới hạn toàn cục
* và với một nhóm tùy chọn cho mỗi future, mỗi nhóm có giới hạn riêng.

Crate này là một phần của [tổ chức nextest](https://github.com/nextest-rs) trên GitHub, và
được thiết kế để phục vụ nhu cầu của [cargo-nextest](https://nexte.st).

## Động lực phát triển

Lập trình bất đồng bộ trong Rust thường sử dụng một bộ chuyển đổi gọi là
[`buffer_unordered`](https://docs.rs/futures/latest/futures/stream/trait.StreamExt.html#method.buffer_unordered):
bộ chuyển đổi này nhận một stream các future[^1], và thực thi tất cả các future với giới hạn
số lượng đồng thời tối đa.

* Các future được khởi động theo thứ tự stream trả về.
* Sau khi bắt đầu, các future được poll đồng thời, và các kết quả hoàn thành được trả về theo
  thứ tự bất kỳ (do đó là `unordered`).

Các trường hợp sử dụng phổ biến cho `buffer_unordered` bao gồm:

* Gửi các yêu cầu mạng song song, nhưng giới hạn số lượng đồng thời để tránh quá tải máy chủ từ xa.
* Chạy kiểm thử với một công cụ như [cargo-nextest](https://nexte.st).

`buffer_unordered` hoạt động tốt trong nhiều trường hợp. Tuy nhiên, một vấn đề là nó coi mọi
future đều tiêu tốn tài nguyên như nhau: không có cách nào để chỉ định rằng một số future tiêu
tốn nhiều tài nguyên hơn các future khác, hoặc một số nhóm future phải loại trừ lẫn nhau.

Đặc biệt với nextest, một số kiểm thử có thể nặng hơn nhiều so với những kiểm thử khác, và chỉ
nên chạy ít kiểm thử này cùng lúc. Ngoài ra, một số kiểm thử cần loại trừ lẫn nhau, hoặc cần
đặt các giới hạn đồng thời khác nhau lên chúng.

[^1]: Bộ chuyển đổi này nhận một stream các future để đạt tính tổng quát tối đa. Trong thực tế,
    nó thường là một *iterator* các future, được chuyển đổi sử dụng
    [`stream::iter`](https://docs.rs/futures/latest/futures/stream/fn.iter.html).

## Về crate này

Crate này cung cấp hai bộ chuyển đổi (adaptor) trên stream.

### 1. Bộ chuyển đổi `future_queue`

Bộ chuyển đổi [`future_queue`](StreamExt::future_queue) có thể chạy nhiều future đồng thời,
giới hạn số lượng đồng thời theo một *trọng số* tối đa.

Thay vì nhận một stream các future, bộ chuyển đổi này nhận một stream các cặp
`(usize, F)`, trong đó `usize` là trọng số của mỗi future,
và `F` là `FnOnce(FutureQueueContext) -> impl Future`. Bộ chuyển đổi này sẽ
lên lịch và lưu vào bộ đệm các future để chạy cho đến khi việc xếp thêm một future tiếp theo sẽ
vượt quá trọng số tối đa.

* Trọng số tối đa không bao giờ bị vượt quá khi các future đang chạy.
* Nếu trọng số của một future riêng lẻ lớn hơn trọng số tối đa, trọng số của nó sẽ được đặt bằng trọng số tối đa.

Khi tất cả future có thể đã được lên lịch, bộ chuyển đổi này sẽ đợi cho đến khi một số future đang chạy hoàn thành, và trọng số hiện tại của các future đang chạy giảm xuống dưới trọng số tối đa, trước khi lên lịch thêm future mới.

Trọng số của một future có thể bằng 0, khi đó nó không tính vào trọng số tối đa.

Nếu tất cả trọng số đều là 1, thì `future_queue` hoàn toàn giống với `buffer_unordered`.

#### Ví dụ

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![(1, recv_one), (2, recv_two)],
).map(|(weight, future)| {
    (weight, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue(10);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

### 2. Bộ chuyển đổi `future_queue_grouped`

Bộ chuyển đổi [`future_queue_grouped`](StreamExt::future_queue_grouped) giống như `future_queue`,
nhưng cho phép chỉ định một *nhóm* tùy chọn cho mỗi future. Mỗi nhóm có trọng số tối đa riêng, và một future chỉ được lên lịch nếu cả trọng số tối đa toàn cục và trọng số nhóm đều không bị vượt quá.

Bộ chuyển đổi này đảm bảo công bằng tối đa trong phạm vi các ràng buộc: nó sẽ lên lịch future theo thứ tự stream trả về, không sắp xếp lại dựa trên trọng số. Khi một future trong một nhóm hoàn thành, các future đã được xếp hàng trong nhóm đó sẽ được ưu tiên lên lịch trước các future khác từ stream.

Giống như [`future_queue`](StreamExt::future_queue):

* Trọng số tối đa toàn cục và nhóm không bao giờ bị vượt quá khi các future đang chạy.
* Khi tính toán trọng số toàn cục, nếu trọng số của một future lớn hơn trọng số tối đa, trọng số của nó sẽ được đặt bằng trọng số tối đa.
* *Nếu một future thuộc về một nhóm:* Khi tính toán trọng số nhóm, nếu trọng số của nó lớn hơn trọng số tối đa của nhóm, trọng số sẽ được đặt bằng trọng số tối đa của nhóm.

#### Ví dụ

```rust
use futures::{channel::oneshot, stream, StreamExt as _};
use future_queue::{FutureQueueContext, StreamExt as _};

let (send_one, recv_one) = oneshot::channel();
let (send_two, recv_two) = oneshot::channel();

let stream_of_futures = stream::iter(
    vec![
        (1, Some("group1"), recv_one),
        (2, None, recv_two),
    ],
).map(|(weight, group, future)| {
    (weight, group, move |_cx| future)
});
let mut queue = stream_of_futures.future_queue_grouped(10, [("group1", 5)]);

send_two.send("hello")?;
assert_eq!(queue.next().await, Some(Ok("hello")));

send_one.send("world")?;
assert_eq!(queue.next().await, Some(Ok("world")));

assert_eq!(queue.next().await, None);
```

## Phiên bản Rust tối thiểu được hỗ trợ (MSRV)

Phiên bản Rust tối thiểu được hỗ trợ là **Rust 1.70.** Tại mọi thời điểm, ít nhất sáu tháng phát hành Rust stable gần nhất được hỗ trợ.

Khi crate này còn ở giai đoạn tiền phát hành (0.x.x), nó có thể nâng MSRV trong một bản phát hành vá lỗi (patch). Khi crate này đạt 1.x, mọi lần nâng MSRV sẽ đi kèm một bản phát hành phiên bản nhỏ mới.

## Ghi chú

Crate này trước đây được gọi là `buffer-unordered-weighted`. Nó đã được đổi tên thành `future-queue` để mô tả rõ ràng hơn về chức năng thay vì cách triển khai.

## Đóng góp

Xem tệp [CONTRIBUTING](https://raw.githubusercontent.com/nextest-rs/future-queue/main/CONTRIBUTING.md) để biết cách đóng góp.

## Giấy phép

Dự án này được phát hành theo các điều khoản của cả [giấy phép Apache 2.0](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-APACHE) hoặc
[giấy phép MIT](https://raw.githubusercontent.com/nextest-rs/future-queue/main/LICENSE-MIT).

Mã nguồn được phát triển dựa trên [futures-rs](https://github.com/rust-lang/futures-rs), và được sử dụng theo giấy phép Apache 2.0 và MIT.

<!--
README.md được sinh ra từ README.tpl bằng cargo readme. Để tạo lại, hãy chạy từ thư mục gốc repository:

./scripts/regenerate-readmes.sh
-->

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---