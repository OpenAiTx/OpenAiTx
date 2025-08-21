
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=m1dugh&project=RosettaStonks&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Rosetta Stonks

- [Giới thiệu](#introduction)
- [Cài đặt](#install)
  - [Chrome](#chrome-based-browsers)
    - [Hướng dẫn trực quan](#chrome-based-browsers)
  - [Firefox](#firefox-based-browsers)
- [Cách sử dụng](#how-to-use)
  - [Thêm thời gian](#adding-time)
    - [Nền tảng cơ bản](#adding-time-in-foundations)
    - [Trình xây dựng độ thông thạo](#adding-time-in-fluency-builder)
  - [Xác thực bài học](#validating-lesson)
    - [Nền tảng cơ bản](#validating-lesson-in-foundations)
    - [Trình xây dựng độ thông thạo](#validating-lesson-in-fluency-builder)

## Giới thiệu

RosettaStonks là một tiện ích mở rộng trình duyệt cho phép bạn thêm thời gian và xác thực
bài học trên nền tảng học ngôn ngữ Rosetta Stone.

> RosettaStonks, và viên đá Rosetta của bạn sẽ tăng giá trị.

## Cài đặt

### Trình duyệt dựa trên Chrome

➡️ **Bạn mới cài đặt tiện ích Chrome thủ công?** Xem [Hướng dẫn trực quan từng bước](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md) — có kèm ảnh minh họa hữu ích! 🖼️

#### 1. Sử dụng bản phát hành trên GitHub

Để sử dụng tiện ích trên trình duyệt dựa trên chrome, bạn cần:

- tải về file `rosettastonks-chrome.tar.gz` từ bản phát hành mới nhất về
  máy tính của bạn.
- tạo một thư mục tên là `rosettastonks` ở đâu đó trên máy để lưu trữ
  tiện ích mở rộng
- chạy lệnh sau trong thư mục `rosettastonks`.

```bash
$ tar xvzf /path/to/rosettastonks-chrome.tar.gz
```

2. Sử dụng trình quản lý gói nix

Thay vì các lệnh trước, nếu bạn đang sử dụng hệ thống nix **hỗ trợ
flakes**, bạn có thể chạy các lệnh sau, sẽ cài đặt một thư mục
dưới đường dẫn `/tmp/rosettastonks` với tất cả các tệp.

```bash
$ nix build --out-link "/tmp/rosettastonks" github:m1dugh/RosettaStonks#chrome
```
Thư mục hiện đã được cài đặt tại `/tmp/rosettastonks/`

**Phần này dành cho tất cả người dùng, bất kể bạn sử dụng phương pháp github
hay phương pháp nix.**

Trên trình duyệt của bạn:

- truy cập `chrome://extensions`
- bật tùy chọn `Chế độ nhà phát triển`
- nhấp vào `Tải gói chưa đóng`
- Chọn thư mục `rosettastonks` của bạn

### Trình duyệt dựa trên Firefox

- tải xuống tệp `rosettastonks.xpi` từ bản phát hành mới nhất.
- hoặc, nếu sử dụng trình quản lý gói nix với hỗ trợ flake, bạn có thể chạy
  lệnh sau.


```bash
$ nix build --out-link "/tmp/rosettatonks.xpi" github:m1dugh/RosettaStonks#mozilla
```

- truy cập `about:addons` trong trình duyệt của bạn
- nhấn nút cài đặt và vào `Debug addons`.
- nhấn `Load Temporary Add-On`
- chọn tệp `/tmp/rosettastonks.xpi` trong trình chọn tệp.

_Cảnh báo: Phương pháp này chỉ cài đặt tiện ích mở rộng tạm thời, nghĩa là nếu
bạn đóng trình duyệt, addon sẽ bị gỡ cài đặt. Điều này là do chính sách của firefox
không cho phép sử dụng các tiện ích chưa được xác minh._

## Cách sử dụng

### Thêm thời gian

#### Thêm thời gian trong Foundations

Để thêm thời gian vào sản phẩm `foundations`, bạn cần vào các bài tập của mình, và
nhấn bỏ qua hoặc giải ít nhất một câu hỏi. Khi hoàn thành, một trường thời gian
sẽ xuất hiện trên trang tiện ích để bạn thêm thời gian của mình.

#### Thêm thời gian trong Fluency builder

Để thêm thời gian vào sản phẩm `fluency builder`, bạn cần vào các bài tập của mình, và
trả lời ít nhất một bài tập. Nếu trường thêm thời gian không xuất hiện, nghĩa là
chưa có yêu cầu thời gian nào được ghi nhận, bạn cần làm mới câu hỏi và trả lời lại.
Để thời gian được cộng vào, bạn cần hoàn thành bài học mà bạn dùng để thêm thời gian.

_Lưu ý: Nếu bạn không thấy trường thêm thời gian, nghĩa là các hành động bạn thực hiện
trên trang Rosetta stone không dẫn đến việc cộng thời gian hợp lệ, do đó,
bạn cần trả lời các câu hỏi khác._

### Xác thực bài học

#### Xác thực bài học trong Foundations

Để xác thực một bài học, bạn cần bắt đầu một bài học, và đi qua tất cả các
câu hỏi bằng nút `ignore` ở góc dưới bên phải. Khi đã xem hết các câu hỏi,
nhấn nút `validate lesson` sẽ xác thực bài học. Nếu không được, hãy quay lại trang chủ,
nhấn vào cùng một bài học, nó

nên hỏi bạn `Bạn có muốn tiếp tục hay đặt lại không?`, bạn có thể chọn cả hai, và
xác thực bài học lại cho đến khi nó hoạt động. Nó sẽ hoạt động sau tối đa 3/4 lần.

#### Xác thực bài học trong Fluency builder

Hiện tại, tính năng xác thực bài học chưa có trên rosetta stonks.

## Xây dựng ứng dụng

### Xây dựng worker

Worker có thể được đóng gói bằng lệnh sau

```
$ deno task build:worker
```

Lệnh này sẽ tạo ra file đóng gói `/dist/worker.esm.js` là file đóng gói
dành cho worker.

### Xây dựng giao diện người dùng

Worker có thể được đóng gói bằng lệnh sau

```
$ deno task build:frontend
```

Lệnh này sẽ tạo ra file đóng gói `/dist/frontend.esm.js`, đây là file đã được đóng gói
dành cho frontend.

## Đóng gói tiện ích mở rộng

### Chrome

Để đóng gói tiện ích mở rộng cho chrome, có thể chạy lệnh sau:

```
$ make chrome
```

### Firefox

Để đóng gói tiện ích mở rộng cho Firefox, có thể chạy lệnh sau:

```
$ make firefox
```

Điều này sẽ tạo ra `rosettastonks.xpi`, là tệp mở rộng có thể được
tải vào firefox.

📸 Bạn thích hình ảnh? Xem [Hướng Dẫn Cài Đặt Chrome kèm Hình Ảnh](https://raw.githubusercontent.com/m1dugh/RosettaStonks/master/INSTALL_GUI.md)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-21

---