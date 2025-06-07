<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">Trang web trò chơi thân thiện trong khu phố của bạn.</p>
<br>

Chào mừng đến với MonkeyGG2, một trang web trò chơi giàu tính năng được tạo ra dành cho bạn! Với hơn 150 trò chơi để lựa chọn, MonkeyGG2 mang đến trải nghiệm chơi game độc đáo và có thể tuỳ chỉnh. Dù bạn là game thủ, lập trình viên hay người dùng thông thường, MonkeyGG2 cung cấp một môi trường chơi game mượt mà và thú vị.

> Hãy cân nhắc tặng chúng tôi một ngôi sao! Đặc biệt nếu bạn đã fork kho lưu trữ này hoặc tìm thấy mục đích sử dụng khác từ kho lưu trữ này.

## Tính năng

-   Hơn 150 trò chơi
-   Dễ sử dụng
-   Dễ triển khai
-   Có thể tuỳ chỉnh
-   Proxy
-   Và nhiều hơn nữa...

## Tuỳ chỉnh

### Cài đặt

#### Ẩn danh (Cloaking)

Ẩn danh đề cập đến việc mở trang trong một tab `about:blank`. Hành vi này được bật mặc định, tuy nhiên bạn có thể tắt nếu muốn. Có các thiết lập sẵn cho liên kết chuyển hướng nhưng bạn cũng có thể cấu hình thủ công.

#### Ngụy trang (Masking)

Ngụy trang đề cập đến việc thay đổi biểu tượng và tiêu đề tab của tab about:blank. Có các thiết lập sẵn cho biểu tượng và tiêu đề tab, tuy nhiên bạn cũng có thể tuỳ chỉnh thủ công.

#### Phím tắt

Bạn có thể tạo các phím tắt tuỳ chỉnh để thực hiện nhiều tác vụ khác nhau. Ví dụ, thoát game, ngụy trang tab, và chạy mã JavaScript tuỳ chỉnh đều được hỗ trợ.
> Lưu ý: nếu bạn muốn chạy JavaScript tuỳ chỉnh, hãy chắc chắn rằng bạn biết mình đang làm gì. Nếu có sự cố, chỉ cần tải lại trang là mọi thứ sẽ trở lại bình thường.

#### Giao diện

Các tuỳ chỉnh giao diện sau hiện đang được hỗ trợ:
- Bật/tắt hiệu ứng nền (nếu bạn lo lắng về hiệu suất khi đang chơi, đừng lo, hiệu ứng này sẽ tự động tắt khi bạn vào game)
- Màu nền
- Màu khối
- Màu nút
- Màu trò chơi
- Màu khi di chuột
- Màu thanh cuộn
- Màu rãnh cuộn
- Màu chữ

> Lưu ý: nếu bạn vô tình thay đổi màu sắc khiến trang web không sử dụng được, bạn cần xoá cookie và local storage.

### Tuỳ chỉnh nâng cao

> Cảnh báo: Các tuỳ chỉnh sau chỉ khả dụng cho chủ sở hữu kho lưu trữ hoặc bất kỳ ai fork kho lưu trữ này.

Tệp `config.jsonc` được định dạng để cấu hình cho toàn bộ trang web. Hiện tại, các mục sau được hỗ trợ:
- Trò chơi
- Giao diện (sắp ra mắt)
- Cấu hình Proxy

#### Trò chơi

Mỗi mục trò chơi có một key là tên hiển thị của trò chơi, và giá trị là một đối tượng gồm ba cặp key-value:
- `"path"`: Đường dẫn tới trò chơi từ thư mục `./games`
- `"aliases"`: Danh sách tên thay thế cho trò chơi để cải thiện tìm kiếm
- `"categories"`: Danh sách thể loại mà trò chơi thuộc về (hỗ trợ thêm biểu tượng sẽ ra mắt sau)

Bạn có thể thêm mục mới thủ công, nhưng khá tẻ nhạt, nhất là khi muốn sắp xếp theo thứ tự chữ và số (không bắt buộc để cấu hình hoạt động!).
Vì vậy, script `add-game-entry.js` được tạo ra, giúp bạn dễ dàng thêm trò chơi mới vào cấu hình mà không cần chỉnh sửa file thủ công.

```bash
# Bạn có thể sử dụng bất kỳ runtime js nào như node.js, bun, hoặc deno
# Ở ví dụ này dùng bun vì các phụ thuộc sẽ được cài đặt tự động
bun add-game-script.js
# Trả lời các câu hỏi và cấu hình sẽ được cập nhật
```

#### Giao diện

Chuẩn giao diện chưa được triển khai (TODO)

#### Proxy

Các tuỳ chọn cấu hình proxy nằm dưới khoá **"config"**.
Giá trị của khoá `"proxy"` là một giá trị boolean cho phép hoặc tắt chức năng proxy. Nếu `"proxy"` là false, người dùng sẽ thấy hộp thoại lỗi khi cố truy cập proxy.
Giá trị của khoá `"proxyPath"` là đường dẫn tới proxy. Có thể là đường dẫn tuyệt đối hoặc tương đối, nhưng proxy phải hỗ trợ **CORS** vì trang proxy sẽ được hiển thị dưới dạng iframe trên trang web.


## Triển khai

### Không dùng Proxy

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

Ngoài ra, bạn cũng có thể fork kho lưu trữ này trên [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) hoặc [Codeberg](https://codeberg.org/MonkeyGG2/pages) và triển khai lên GitHub Pages hoặc Codeberg Pages tương ứng.

### Có Proxy

Truy cập trang [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) để tìm hiểu thêm về việc host MonkeyGG2 với proxy.

### Chạy cục bộ

```bash
# CẢNH BÁO: nếu bạn có thư mục tên "monkeygg2", lệnh này sẽ xoá toàn bộ file trong thư mục đó
# hãy thay đổi tên thư mục trong 2 lệnh sau
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# từ đây bạn có thể dùng bất kỳ công cụ nào để chạy máy chủ tĩnh, ví dụ "live-server" từ npm sẽ được dùng ở đây
npm install -g live-server # chỉ cần nếu bạn chưa cài đặt
npx live-server
```

## Giấy phép

Phân phối theo giấy phép WTFPL. Xem thêm chi tiết [tại đây](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---