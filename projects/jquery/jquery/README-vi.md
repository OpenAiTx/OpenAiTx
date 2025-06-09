# [jQuery](https://jquery.com/) — JavaScript Thế Hệ Mới

Các cuộc họp hiện được tổ chức trên nền tảng [matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Biên bản họp có thể được tìm thấy tại [meetings.jquery.org](https://meetings.jquery.org/category/core/).

Phiên bản mới nhất của jQuery có sẵn tại [https://jquery.com/download/](https://jquery.com/download/).

## Hỗ trợ phiên bản

| Phiên bản | Nhánh      | Trạng thái |
| --------- | ---------- | ---------- |
| 4.x       | main       | Beta       |
| 3.x       | 3.x-stable | Đang hoạt động |
| 2.x       | 2.x-stable | Không hoạt động |
| 1.x       | 1.x-stable | Không hoạt động |

Khi phiên bản 4.0.0 chính thức được phát hành, nhánh 3.x sẽ tiếp tục nhận được cập nhật trong một thời gian giới hạn. Các nhánh 2.x và 1.x không còn được hỗ trợ nữa.

Dịch vụ hỗ trợ thương mại cho các phiên bản không còn hoạt động được cung cấp bởi [HeroDevs](https://herodevs.com/nes).

Tìm hiểu thêm về [hỗ trợ phiên bản](https://jquery.com/support/).

## Hướng dẫn đóng góp

Theo tinh thần phát triển phần mềm mã nguồn mở, jQuery luôn khuyến khích cộng đồng đóng góp mã nguồn. Để bắt đầu và trước khi bạn viết mã, hãy chắc chắn đọc kỹ các hướng dẫn đóng góp quan trọng sau:

1. [Tham gia đóng góp](https://contribute.jquery.org/)
2. [Hướng dẫn phong cách code cho Core](https://contribute.jquery.org/style-guide/js/)
3. [Viết mã cho các dự án jQuery](https://contribute.jquery.org/code/)

### Tham chiếu đến issues/PRs

Các issue/PR trên GitHub thường được tham chiếu qua `gh-NUMBER`, trong đó `NUMBER` là ID số của issue/PR. Bạn có thể tìm issue/PR này tại `https://github.com/jquery/jquery/issues/NUMBER`.

jQuery từng sử dụng một trình theo dõi lỗi khác - dựa trên Trac - trước đây, có tại [bugs.jquery.com](https://bugs.jquery.com/). Nó được giữ ở chế độ chỉ đọc để có thể tham khảo các cuộc thảo luận trước đây. Khi mã nguồn jQuery tham chiếu đến một trong những issue này, nó sử dụng mẫu `trac-NUMBER`, trong đó `NUMBER` là ID số của issue. Bạn có thể tìm issue đó tại `https://bugs.jquery.com/ticket/NUMBER`.

## Môi trường sử dụng jQuery

- [Hỗ trợ trình duyệt](https://jquery.com/browser-support/)
- jQuery cũng hỗ trợ Node, tiện ích mở rộng trình duyệt và các môi trường không phải trình duyệt khác.

## Những gì bạn cần để tự build jQuery

Để build jQuery, bạn cần có Node.js/npm mới nhất và git 1.7 hoặc mới hơn. Các phiên bản cũ hơn có thể hoạt động, nhưng không được hỗ trợ.

Đối với Windows, bạn cần tải và cài đặt [git](https://git-scm.com/downloads) và [Node.js](https://nodejs.org/en/download/).

Người dùng macOS nên cài đặt [Homebrew](https://brew.sh/). Sau khi cài đặt Homebrew, chạy `brew install git` để cài git,
và `brew install node` để cài Node.js.

Người dùng Linux/BSD nên sử dụng trình quản lý gói phù hợp để cài đặt git và Node.js, hoặc tự build từ mã nguồn
nếu muốn. Rất đơn giản.

## Cách build jQuery của riêng bạn

Đầu tiên, [clone repo git của jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Sau đó, vào thư mục jquery, cài đặt các phụ thuộc và chạy script build:

```bash
cd jquery
npm install
npm run build
```

Phiên bản jQuery đã build sẽ được đặt trong thư mục `dist/`, cùng với một bản rút gọn và file map liên quan.

## Build tất cả các file phát hành của jQuery

Để build tất cả các biến thể của jQuery, chạy lệnh sau:

```bash
npm run build:all
```

Lệnh này sẽ tạo ra tất cả các biến thể mà jQuery bao gồm trong một bản phát hành, bao gồm `jquery.js`, `jquery.slim.js`, `jquery.module.js`, và `jquery.slim.module.js` cùng với các file rút gọn và sourcemap liên quan.

`jquery.module.js` và `jquery.slim.module.js` là [ECMAScript modules](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) xuất ra `jQuery` và `$` dưới dạng named export và được đặt trong thư mục `dist-module/` thay vì `dist/`.

## Build jQuery tuỳ chỉnh

Script build có thể được sử dụng để tạo một phiên bản jQuery tuỳ chỉnh chỉ bao gồm các module bạn cần.

Bất kỳ module nào đều có thể bị loại trừ ngoại trừ `core`. Khi loại trừ `selector`, nó không bị xoá hoàn toàn mà được thay thế bằng một wrapper nhỏ quanh `querySelectorAll` gốc của trình duyệt (xem thêm bên dưới để biết thêm chi tiết).

### Trợ giúp script build

Để xem danh sách đầy đủ các tuỳ chọn sẵn có cho script build, chạy lệnh sau:

```bash
npm run build -- --help
```

### Các module

Để loại trừ một module, truyền đường dẫn của nó (tương đối với thư mục `src`, không có phần mở rộng `.js`) cho tuỳ chọn `--exclude`. Khi sử dụng tuỳ chọn `--include`, các mặc định sẽ bị loại bỏ và chỉ build với các module được chỉ định.

Một số module ví dụ có thể loại trừ hoặc bao gồm là:

- **ajax**: Toàn bộ chức năng AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transports và các event AJAX shorthand như `.ajaxStart()`.
- **ajax/xhr**: Chỉ transport AJAX XMLHTTPRequest.
- **ajax/script**: Chỉ transport AJAX `<script>`; dùng để lấy script.
- **ajax/jsonp**: Chỉ transport AJAX JSONP; phụ thuộc vào ajax/script.
- **css**: Phương thức `.css()`. Việc loại trừ cũng loại bỏ **tất cả** các module phụ thuộc vào css (bao gồm **effects**, **dimensions** và **offset**).
- **css/showHide**: `.show()`, `.hide()` và `.toggle()` không hiệu ứng; có thể loại trừ nếu bạn dùng class hoặc gọi `.css()` để đặt thuộc tính `display`. Việc này cũng loại bỏ module **effects**.
- **deprecated**: Các phương thức đã được ghi chú là deprecated nhưng chưa bị loại bỏ.
- **dimensions**: Các phương thức `.width()` và `.height()`, bao gồm các biến thể `inner-` và `outer-`.
- **effects**: Phương thức `.animate()` và các shorthand như `.slideUp()` hoặc `.hide("slow")`.
- **event**: Các phương thức `.on()` và `.off()` cùng toàn bộ chức năng sự kiện.
- **event/trigger**: Các phương thức `.trigger()` và `.triggerHandler()`.
- **offset**: Các phương thức `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()` và `.scrollTop()`.
- **wrap**: Các phương thức `.wrap()`, `.wrapAll()`, `.wrapInner()` và `.unwrap()`.
- **core/ready**: Loại trừ module ready nếu bạn đặt script ở cuối body. Các callback ready được gắn với `jQuery()` sẽ được gọi ngay lập tức. Tuy nhiên, `jQuery(document).ready()` sẽ không còn là một hàm và `.on("ready", ...)` hoặc tương tự sẽ không được kích hoạt.
- **deferred**: Loại trừ jQuery.Deferred. Việc này cũng loại trừ tất cả các module phụ thuộc vào Deferred, bao gồm **ajax**, **effects** và **queue**, nhưng thay thế **core/ready** bằng **core/ready-no-deferred**.
- **exports/global**: Loại trừ việc gắn biến toàn cục jQuery ($ và jQuery) lên window.
- **exports/amd**: Loại trừ định nghĩa AMD.

- **selector**: Toàn bộ engine selector của jQuery. Khi module này bị loại trừ, nó sẽ được thay thế bằng một engine selector cơ bản dựa trên phương thức `querySelectorAll` của trình duyệt, không hỗ trợ các extension selector của jQuery hoặc các ngữ nghĩa nâng cao. Xem file [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) để biết chi tiết.

*Lưu ý*: Loại trừ toàn bộ module `selector` cũng sẽ loại trừ tất cả các extension selector của jQuery (như `effects/animatedSelector` và `css/hiddenVisibleSelectors`).

##### Tên AMD

Bạn có thể đặt tên module cho định nghĩa AMD của jQuery. Mặc định là "jquery", thuận tiện cho plugin và thư viện bên thứ ba, nhưng đôi khi bạn muốn thay đổi tên này. Truyền nó vào tham số `--amd`:

```bash
npm run build -- --amd="custom-name"
```

Hoặc, để định nghĩa ẩn danh, chỉ để trống tên.

```bash
npm run build -- --amd
```

##### Tên file và thư mục

Tên mặc định cho file jQuery đã build là `jquery.js`; nó được đặt dưới thư mục `dist/`. Có thể thay đổi tên file bằng `--filename` và thư mục bằng `--dir`. `--dir` là đường dẫn tương đối với thư mục gốc dự án.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Lệnh này sẽ tạo một phiên bản slim của jQuery và đặt tại `tmp/jquery.slim.js`.

##### Chế độ ECMAScript Module (ESM)

Theo mặc định, jQuery tạo một file JavaScript dạng script thông thường. Bạn cũng có thể tạo một ECMAScript module xuất `jQuery` dưới dạng default export bằng tham số `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Chế độ Factory

Theo mặc định, jQuery phụ thuộc vào một đối tượng `window` toàn cục. Đối với các môi trường không có window, bạn có thể tạo một bản factory build cho phép truyền vào một đối tượng `window` từ bên ngoài (xem [`README` của package đã phát hành](build/fixtures/README.md) để biết hướng dẫn sử dụng). Có thể tạo factory này bằng tham số `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Tùy chọn này có thể kết hợp với các tuỳ chọn khác như `--esm` hoặc `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Ví dụ Build Tuỳ Chỉnh

Tạo một bản build tuỳ chỉnh bằng cách dùng `npm run build`, liệt kê các module cần loại trừ. Loại trừ một module cấp cao sẽ loại luôn thư mục module tương ứng.

Loại trừ toàn bộ chức năng **ajax**:

```bash
npm run build -- --exclude=ajax
```

Loại trừ **css** cũng loại bỏ các module phụ thuộc: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Loại trừ nhiều module cùng lúc (`-e` là alias cho `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Có một alias đặc biệt để tạo build với cấu hình giống bản jQuery Slim chính thức:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Hoặc, để tạo slim build dưới dạng module esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Các bản dựng tùy chỉnh không chính thức không được kiểm tra thường xuyên. Sử dụng chúng có thể có rủi ro.*

## Chạy các bài kiểm tra đơn vị

Đảm bảo bạn đã cài đặt đầy đủ các phụ thuộc cần thiết:

```bash
npm install
```

Khởi động `npm start` để tự động xây dựng jQuery khi bạn làm việc:

```bash
npm start
```

Chạy các bài kiểm tra đơn vị với một máy chủ cục bộ hỗ trợ PHP. Đảm bảo rằng bạn chạy trang web từ thư mục gốc, không phải thư mục "test". Không cần cơ sở dữ liệu. Các máy chủ php cục bộ cấu hình sẵn có sẵn cho Windows và Mac. Dưới đây là một số lựa chọn:

- Windows: [Tải về WAMP](https://www.wampserver.com/en/)
- Mac: [Tải về MAMP](https://www.mamp.info/en/downloads/)
- Linux: [Cài đặt LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (nhiều nền tảng)](https://code.google.com/p/mongoose/)

## Git cơ bản

Vì mã nguồn được quản lý bởi hệ thống kiểm soát phiên bản Git, nên việc biết một số tính năng được sử dụng là hữu ích.

### Làm sạch

Nếu bạn muốn đưa thư mục làm việc của mình về trạng thái của upstream, có thể sử dụng các lệnh sau (lưu ý mọi thứ bạn đã làm việc sẽ bị xóa sau khi thực hiện):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebasing

Với các nhánh chức năng/chủ đề, bạn nên luôn sử dụng cờ `--rebase` cho `git pull`, hoặc nếu bạn thường xuyên xử lý nhiều nhánh tạm thời "để tạo pull request trên github", hãy chạy lệnh sau để tự động hóa:

```bash
git config branch.autosetuprebase local
```

(xem `man git-config` để biết thêm thông tin)

### Xử lý xung đột hợp nhất

Nếu bạn gặp xung đột hợp nhất khi merge, thay vì chỉnh sửa thủ công các tệp bị xung đột, bạn có thể sử dụng tính năng
`git mergetool`. Mặc dù công cụ mặc định `xxdiff` trông có vẻ cũ/kém, nhưng nó khá hữu ích.

Dưới đây là một số lệnh bạn có thể sử dụng:

- `Ctrl + Alt + M` - tự động hợp nhất nhiều nhất có thể
- `b` - chuyển đến xung đột tiếp theo
- `s` - thay đổi thứ tự các dòng bị xung đột
- `u` - hoàn tác một hợp nhất
- `chuột trái` - đánh dấu một khối là phần thắng
- `chuột giữa` - đánh dấu một dòng là phần thắng
- `Ctrl + S` - lưu
- `Ctrl + Q` - thoát

## Tham khảo [QUnit](https://api.qunitjs.com)

### Phương thức kiểm tra

```js
expect( numAssertions );
stop();
start();
```

*Lưu ý*: Việc QUnit bổ sung tham số cho stop/start sẽ bị bỏ qua trong bộ kiểm tra này để start và stop có thể được truyền làm callback mà không cần lo lắng về tham số.

### Các khẳng định kiểm tra

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Tham khảo các phương thức tiện lợi cho bộ kiểm tra

Xem [test/data/testinit.js](https://github.com/jquery/jquery/blob/main/test/data/testinit.js).

### Trả về một mảng các phần tử với các ID được chỉ định

```js
q( ... );
```

Ví dụ:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Khẳng định một lựa chọn khớp với các ID được chỉ định

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Ví dụ:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Kích hoạt sự kiện DOM gốc mà không qua jQuery

```js
fireNative( node, eventType );
```

Ví dụ:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Thêm số ngẫu nhiên vào url để tránh cache

```js
url( "some/url" );
```

Ví dụ:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Chạy kiểm tra trong iframe

Một số bài kiểm tra có thể yêu cầu tài liệu khác với fixture kiểm tra tiêu chuẩn,
và các bài này có thể được chạy trong một iframe riêng biệt. Mã kiểm tra thực tế và các khẳng định
vẫn nằm trong các tệp kiểm tra chính của jQuery; chỉ đánh dấu fixture kiểm tra tối thiểu
và mã thiết lập nên được đặt trong tệp iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Điều này sẽ tải một trang, xây dựng url với fileName `"./data/" + fileName`.
Trang iframe xác định thời điểm callback diễn ra trong kiểm tra bằng cách
bao gồm script "/test/data/iframeTest.js" và gọi
`startIframeTest( [ additional args ] )` khi thích hợp. Thường thì việc này
sẽ xảy ra sau khi tài liệu đã sẵn sàng hoặc `window.onload` được kích hoạt.

`testCallback` sẽ nhận đối tượng QUnit `assert` được tạo bởi `testIframe`
cho bài kiểm tra này, tiếp theo là các biến toàn cục `jQuery`, `window` và `document` từ
iframe. Nếu mã trong iframe truyền bất kỳ tham số nào cho `startIframeTest`,
chúng sẽ theo sau tham số `document`.

## Có câu hỏi?

Nếu bạn có bất kỳ câu hỏi nào, vui lòng đặt câu hỏi trên
[Diễn đàn phát triển jQuery Core](https://forum.jquery.com/developing-jquery-core) hoặc trong #jquery trên [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---