<p align="center"><img src="https://ohmyzsh.s3.amazonaws.com/omz-ansi-github.png" alt="Oh My Zsh"></p>

Oh My Zsh là một framework mã nguồn mở, được cộng đồng phát triển để quản lý cấu hình [zsh](https://www.zsh.org/) của bạn.

Nghe thật nhàm chán. Hãy thử lại lần nữa.

**Oh My Zsh sẽ không biến bạn thành lập trình viên gấp 10 lần... nhưng bạn có thể cảm thấy như vậy.**

Sau khi cài đặt, shell terminal của bạn sẽ trở thành đề tài bàn tán của mọi người _hoặc bạn sẽ được hoàn tiền!_ Với mỗi lần gõ phím trong dấu nhắc lệnh, bạn sẽ tận dụng được hàng trăm plugin mạnh mẽ và các chủ đề tuyệt đẹp. Người lạ sẽ đến gặp bạn ở quán cà phê và hỏi bạn, _"thật tuyệt vời! bạn là thiên tài à?"_

Cuối cùng, bạn sẽ nhận được sự chú ý mà bạn luôn nghĩ mình xứng đáng có. ...hoặc có thể bạn sẽ dùng thời gian tiết kiệm được để bắt đầu đánh răng chỉ nha khoa thường xuyên hơn. 😬

Để tìm hiểu thêm, hãy truy cập [ohmyz.sh](https://ohmyz.sh), theo dõi [@ohmyzsh](https://x.com/ohmyzsh) trên X (trước đây là Twitter), và tham gia với chúng tôi trên [Discord](https://discord.gg/ohmyzsh).

[![CI](https://github.com/ohmyzsh/ohmyzsh/workflows/CI/badge.svg)](https://github.com/ohmyzsh/ohmyzsh/actions?query=workflow%3ACI)
[![X (formerly Twitter) Follow](https://img.shields.io/twitter/follow/ohmyzsh?label=%40ohmyzsh&logo=x&style=flat)](https://twitter.com/intent/follow?screen_name=ohmyzsh)
[![Mastodon Follow](https://img.shields.io/mastodon/follow/111169632522566717?label=%40ohmyzsh&domain=https%3A%2F%2Fmstdn.social&logo=mastodon&style=flat)](https://mstdn.social/@ohmyzsh)
[![Discord server](https://img.shields.io/discord/642496866407284746)](https://discord.gg/ohmyzsh)
[![Gitpod ready](https://img.shields.io/badge/Gitpod-ready-blue?logo=gitpod)](https://gitpod.io/#https://github.com/ohmyzsh/ohmyzsh)

<details>
<summary>Mục lục</summary>

- [Bắt đầu](#getting-started)
  - [Tương thích hệ điều hành](#operating-system-compatibility)
  - [Yêu cầu trước](#prerequisites)
  - [Cài đặt cơ bản](#basic-installation)
    - [Kiểm tra thủ công](#manual-inspection)
- [Sử dụng Oh My Zsh](#using-oh-my-zsh)
  - [Plugin](#plugins)
    - [Kích hoạt Plugin](#enabling-plugins)
    - [Sử dụng Plugin](#using-plugins)
  - [Chủ đề (Themes)](#themes)
    - [Chọn một Chủ đề](#selecting-a-theme)
  - [FAQ](#faq)
- [Chủ đề nâng cao](#advanced-topics)
  - [Cài đặt nâng cao](#advanced-installation)
    - [Thư mục tùy chỉnh](#custom-directory)
    - [Cài đặt không giám sát](#unattended-install)
    - [Cài đặt từ kho fork](#installing-from-a-forked-repository)
    - [Cài đặt thủ công](#manual-installation)
  - [Vấn đề cài đặt](#installation-problems)
  - [Plugin và chủ đề tùy chỉnh](#custom-plugins-and-themes)
  - [Bật GNU ls trên macOS và freeBSD](#enable-gnu-ls-in-macos-and-freebsd-systems)
  - [Bỏ qua alias](#skip-aliases)
  - [Async git prompt](#async-git-prompt)
- [Cập nhật](#getting-updates)
  - [Độ chi tiết khi cập nhật](#updates-verbosity)
  - [Cập nhật thủ công](#manual-updates)
- [Gỡ cài đặt Oh My Zsh](#uninstalling-oh-my-zsh)
- [Tôi đóng góp cho Oh My Zsh như thế nào?](#how-do-i-contribute-to-oh-my-zsh)
  - [Đừng gửi chủ đề cho chúng tôi](#do-not-send-us-themes)
- [Những người đóng góp](#contributors)
- [Theo dõi chúng tôi](#follow-us)
- [Hàng hóa](#merchandise)
- [Giấy phép](#license)
- [Về Planet Argon](#about-planet-argon)

</details>

## Bắt đầu

### Tương thích hệ điều hành

| Hệ điều hành   | Trạng thái |
| :------------- | :----: |
| Android        |   ✅   |
| freeBSD        |   ✅   |
| LCARS          |   🛸   |
| Linux          |   ✅   |
| macOS          |   ✅   |
| OS/2 Warp      |   ❌   |
| Windows (WSL2) |   ✅   |

### Yêu cầu trước

- [Zsh](https://www.zsh.org) phải được cài đặt (tối thiểu v4.3.9 nhưng khuyến nghị 5.0.8 trở lên). Nếu chưa được cài sẵn (chạy `zsh --version` để kiểm tra), xem hướng dẫn tại wiki: [Installing ZSH](https://github.com/ohmyzsh/ohmyzsh/wiki/Installing-ZSH)
- Phải cài đặt `curl` hoặc `wget`
- Phải cài đặt `git` (khuyến nghị v2.4.11 trở lên)

### Cài đặt cơ bản

Oh My Zsh được cài đặt bằng cách chạy một trong các lệnh sau trong terminal. Bạn có thể cài đặt qua dòng lệnh bằng `curl`, `wget` hoặc công cụ tương tự.

| Phương pháp    | Lệnh                                                                                           |
| :-------- | :------------------------------------------------------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |
| **wget**  | `sh -c "$(wget -O- https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"`   |
| **fetch** | `sh -c "$(fetch -o - https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)"` |

Ngoài ra, trình cài đặt cũng được nhân bản ngoài GitHub. Sử dụng URL này nếu bạn ở các quốc gia như Trung Quốc hoặc Ấn Độ (với một số ISP) chặn `raw.githubusercontent.com`:

| Phương pháp    | Lệnh                                           |
| :-------- | :------------------------------------------------ |
| **curl**  | `sh -c "$(curl -fsSL https://install.ohmyz.sh/)"` |
| **wget**  | `sh -c "$(wget -O- https://install.ohmyz.sh/)"`   |
| **fetch** | `sh -c "$(fetch -o - https://install.ohmyz.sh/)"` |

_Lưu ý rằng bất kỳ `.zshrc` trước đây sẽ được đổi tên thành `.zshrc.pre-oh-my-zsh`. Sau khi cài đặt, bạn có thể chuyển các cấu hình cần giữ lại vào `.zshrc` mới._

#### Kiểm tra thủ công

Bạn nên kiểm tra script cài đặt từ các dự án mà bạn chưa biết rõ. Bạn có thể tải script về, kiểm tra nội dung rồi mới chạy:

```sh
wget https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh
sh install.sh
```

Nếu URL trên bị time out hoặc gặp lỗi, hãy thay bằng `https://install.ohmyz.sh` để lấy script.

## Sử dụng Oh My Zsh

### Plugin

Oh My Zsh đi kèm rất nhiều plugin để bạn tận dụng. Hãy xem trong thư mục [plugins](https://github.com/ohmyzsh/ohmyzsh/tree/master/plugins) và/hoặc [wiki](https://github.com/ohmyzsh/ohmyzsh/wiki/Plugins) để xem các plugin hiện có.

#### Kích hoạt Plugin

Sau khi bạn chọn được plugin (hoặc nhiều plugin) muốn sử dụng, hãy kích hoạt chúng trong tệp `.zshrc`. Bạn sẽ tìm thấy tệp này trong thư mục `$HOME`. Mở nó bằng trình soạn thảo văn bản yêu thích và bạn sẽ thấy nơi liệt kê các plugin cần tải.

```sh
vi ~/.zshrc
```

Ví dụ, cấu hình có thể giống như sau:

```sh
plugins=(
  git
  bundler
  dotenv
  macos
  rake
  rbenv
  ruby
)
```

_Lưu ý rằng các plugin được phân tách bằng khoảng trắng (dấu cách, tab, dòng mới...). **Không** sử dụng dấu phẩy, nếu không sẽ gây lỗi._

#### Sử dụng Plugin

Mỗi plugin tích hợp đều có file **README**, tài liệu hướng dẫn. File này sẽ cho thấy các alias (nếu có) và các tiện ích kèm theo plugin đó.

### Chủ đề (Themes)

Chúng tôi thừa nhận, những ngày đầu của Oh My Zsh, chúng tôi hơi quá hào hứng với các chủ đề. Hiện nay có hơn 150 chủ đề được đóng gói sẵn. Phần lớn có [ảnh chụp màn hình](https://github.com/ohmyzsh/ohmyzsh/wiki/Themes) trên wiki (chúng tôi đang cập nhật thêm!). Hãy khám phá nhé!

#### Chọn một Chủ đề

_Chủ đề mặc định là của Robby. Nó không phải là chủ đề cầu kỳ nhất, cũng không phải đơn giản nhất. Đơn giản là phù hợp (với anh ấy)._

Sau khi bạn tìm được chủ đề muốn dùng, hãy chỉnh sửa tệp `~/.zshrc`. Bạn sẽ thấy một biến môi trường (chữ IN HOA) như sau:

```sh
ZSH_THEME="robbyrussell"
```

Để dùng chủ đề khác, chỉ cần thay đổi giá trị thành tên chủ đề mong muốn. Ví dụ:

```sh
ZSH_THEME="agnoster" # (đây là một trong những chủ đề đẹp)
# xem https://github.com/ohmyzsh/ohmyzsh/wiki/Themes#agnoster
```

<!-- prettier-ignore-start -->
> [!LƯU Ý]
> Bạn sẽ thấy nhiều ảnh chụp màn hình của chủ đề zsh, nhưng khi dùng lại không giống như vậy.
>
> Đó là vì nhiều chủ đề cần cài đặt [Powerline Font](https://github.com/powerline/fonts) hoặc [Nerd Font](https://github.com/ryanoasis/nerd-fonts) để hiển thị đúng. Nếu không, chủ đề sẽ hiển thị ký hiệu lạ. Xem [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#i-have-a-weird-character-in-my-prompt) để biết thêm.
>
> Ngoài ra, chủ đề chỉ điều khiển giao diện dấu nhắc lệnh, tức là văn bản trước/sau con trỏ chờ bạn nhập lệnh. Chủ đề không điều khiển màu nền cửa sổ terminal (gọi là _color scheme_) hay phông chữ của terminal. Đây là những thiết lập bạn có thể thay đổi trong phần mềm giả lập terminal. Xem thêm [chủ đề zsh là gì](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#what-is-a-zsh-theme).
<!-- prettier-ignore-end -->

Mở cửa sổ terminal mới và dấu nhắc lệnh sẽ trông như sau:

![Agnoster theme](https://cloud.githubusercontent.com/assets/2618447/6316862/70f58fb6-ba03-11e4-82c9-c083bf9a6574.png)

Nếu bạn không tìm được chủ đề phù hợp, hãy xem thêm [tại đây](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

Nếu bạn thích thú, có thể để máy tính chọn ngẫu nhiên một chủ đề mỗi lần mở terminal mới:

```sh
ZSH_THEME="random" # (...xin hãy là pie... xin hãy là pie..)
```

Nếu muốn chọn ngẫu nhiên từ danh sách các chủ đề yêu thích:

```sh
ZSH_THEME_RANDOM_CANDIDATES=(
  "robbyrussell"
  "agnoster"
)
```

Nếu bạn chỉ biết những chủ đề mình không thích, có thể thêm chúng vào danh sách bỏ qua:

```sh
ZSH_THEME_RANDOM_IGNORED=(pygmalion tjkirch_mod)
```

### FAQ

Nếu bạn có câu hỏi hoặc vấn đề, có thể tìm giải pháp trong [FAQ](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ).

## Chủ đề nâng cao

Nếu bạn thích vọc vạch, các phần sau sẽ phù hợp với bạn.

### Cài đặt nâng cao

Một số người dùng muốn cài đặt thủ công Oh My Zsh, hoặc thay đổi đường dẫn mặc định hay các thiết lập mà trình cài đặt hỗ trợ (các thiết lập này cũng được ghi chú ở đầu script cài đặt).

#### Thư mục tùy chỉnh

Vị trí mặc định là `~/.oh-my-zsh` (ẩn trong thư mục home, có thể truy cập bằng `cd ~/.oh-my-zsh`)

Nếu muốn thay đổi thư mục cài đặt với biến môi trường `ZSH`, hãy chạy `export ZSH=/your/path` trước khi cài đặt, hoặc thiết lập trước khi kết thúc pipeline cài đặt như sau:

```sh
ZSH="$HOME/.dotfiles/oh-my-zsh" sh install.sh
```

#### Cài đặt không giám sát

Nếu chạy script cài đặt Oh My Zsh như một phần của cài đặt tự động, bạn có thể truyền tham số `--unattended` cho script `install.sh`. Thao tác này sẽ không thay đổi shell mặc định, cũng không chạy `zsh` sau khi cài đặt xong.

```sh
sh -c "$(curl -fsSL https://raw.githubusercontent.com/ohmyzsh/ohmyzsh/master/tools/install.sh)" "" --unattended
```

Nếu bạn ở Trung Quốc, Ấn Độ, hoặc quốc gia chặn `raw.githubusercontent.com`, hãy thay bằng `https://install.ohmyz.sh` để cài đặt.

#### Cài đặt từ kho fork

Script cài đặt cũng chấp nhận các biến sau để cài đặt từ kho khác:

- `REPO` (mặc định: `ohmyzsh/ohmyzsh`): dạng `owner/repository`. Nếu đặt biến này, trình cài sẽ tìm kho tại `https://github.com/{owner}/{repository}`.

- `REMOTE` (mặc định: `https://github.com/${REPO}.git`): URL đầy đủ của kho git để clone. Dùng nếu muốn cài từ fork không phải GitHub (GitLab, Bitbucket...) hoặc clone qua SSH thay vì HTTPS (`git@github.com:user/project.git`).

  _LƯU Ý: không tương thích khi thiết lập biến `REPO`. Thiết lập này sẽ được ưu tiên._

- `BRANCH` (mặc định: `master`): dùng để đổi branch mặc định khi clone kho. Hữu ích khi test Pull Request hoặc muốn dùng branch khác `master`.

Ví dụ:

```sh
REPO=apjanke/oh-my-zsh BRANCH=edge sh install.sh
```

#### Cài đặt thủ công

##### 1. Clone kho <!-- omit in toc -->

```sh
git clone https://github.com/ohmyzsh/ohmyzsh.git ~/.oh-my-zsh
```

##### 2. _Tùy chọn_, sao lưu file `~/.zshrc` hiện có <!-- omit in toc -->

```sh
cp ~/.zshrc ~/.zshrc.orig
```

##### 3. Tạo file cấu hình Zsh mới <!-- omit in toc -->

Bạn có thể tạo file cấu hình zsh mới bằng cách sao chép mẫu có sẵn.

```sh
cp ~/.oh-my-zsh/templates/zshrc.zsh-template ~/.zshrc
```

##### 4. Đổi shell mặc định <!-- omit in toc -->

```sh
chsh -s $(which zsh)
```

Bạn cần đăng xuất khỏi phiên người dùng và đăng nhập lại để thấy thay đổi này.

##### 5. Khởi tạo cấu hình Zsh mới <!-- omit in toc -->

Khi mở cửa sổ terminal mới, zsh sẽ tải cấu hình Oh My Zsh.

### Vấn đề cài đặt

Nếu gặp trục trặc khi cài đặt, đây là một số cách khắc phục phổ biến.

- Có thể cần sửa `PATH` trong `~/.zshrc` nếu không tìm thấy một số lệnh sau khi chuyển sang `oh-my-zsh`.
- Nếu cài thủ công hoặc đổi vị trí cài, kiểm tra biến môi trường `ZSH` trong `~/.zshrc`.

### Plugin và chủ đề tùy chỉnh

Nếu muốn ghi đè bất kỳ hành vi mặc định nào, chỉ cần thêm tệp mới (đuôi `.zsh`) trong thư mục `custom/`.

Nếu có nhiều hàm liên quan, bạn có thể để chúng vào file `XYZ.plugin.zsh` trong thư mục `custom/plugins/` rồi kích hoạt plugin đó.

Nếu muốn ghi đè chức năng của plugin đã có trong Oh My Zsh, hãy tạo plugin cùng tên trong `custom/plugins/`, nó sẽ được tải thay cho plugin trong `plugins/`.

### Bật GNU ls trên macOS và FreeBSD

<a name="enable-gnu-ls"></a>

Mặc định Oh My Zsh sẽ dùng BSD `ls` trên macOS và FreeBSD. Nếu đã cài GNU `ls` (lệnh `gls`), bạn có thể chọn sử dụng nó thay thế. Để làm điều này, hãy thêm cấu hình dựa trên zstyle trước khi source `oh-my-zsh.sh`:

```zsh
zstyle ':omz:lib:theme-and-appearance' gnu-ls yes
```

_Lưu ý: Không tương thích với `DISABLE_LS_COLORS=true`_

### Bỏ qua alias

<a name="remove-directories-aliases"></a>

Nếu muốn bỏ qua alias mặc định của Oh My Zsh (định nghĩa trong các file `lib/*`) hoặc alias plugin, bạn có thể dùng các thiết lập dưới đây trong file `~/.zshrc`, **trước khi Oh My Zsh được tải**. Lưu ý có nhiều cách bỏ qua alias, tùy vào nhu cầu.

```sh
# Bỏ qua tất cả alias, trong các file lib và plugin đã bật
zstyle ':omz:*' aliases no

# Bỏ qua tất cả alias trong các file lib
zstyle ':omz:lib:*' aliases no
# Bỏ qua alias chỉ trong file directories.zsh
zstyle ':omz:lib:directories' aliases no

# Bỏ qua tất cả alias của plugin
zstyle ':omz:plugins:*' aliases no
# Bỏ qua alias chỉ từ plugin git
zstyle ':omz:plugins:git' aliases no
```

Có thể kết hợp các cách này, lưu ý phạm vi cụ thể sẽ ưu tiên hơn:

```sh
# Bỏ qua tất cả alias của plugin, trừ plugin git
zstyle ':omz:plugins:*' aliases no
zstyle ':omz:plugins:git' aliases yes
```

Phiên bản trước dùng thiết lập dưới đây, hiện đã loại bỏ:

```sh
zstyle ':omz:directories' aliases no
```

Thay vào đó, hãy dùng:

```sh
zstyle ':omz:lib:directories' aliases no
```

#### Thông báo <!-- omit in toc -->

> Tính năng này đang trong giai đoạn thử nghiệm và có thể thay đổi trong tương lai. Hiện chưa tương thích với các trình quản lý plugin như zpm hoặc zinit, vốn không source script khởi tạo (`oh-my-zsh.sh`) nơi tính năng này được cài đặt.
>
> Nó cũng chưa nhận diện "alias" được định nghĩa dưới dạng hàm. Ví dụ như các hàm `gccd`, `ggf`, hoặc `ggl` từ plugin git.

### Async git prompt

Các hàm prompt async là tính năng thử nghiệm (tích hợp từ ngày 3/4/2024), cho phép Oh My Zsh hiển thị thông tin prompt bất đồng bộ. Điều này có thể tăng hiệu năng, nhưng có thể không hoạt động tốt với một số cấu hình. Nếu gặp vấn đề với tính năng này, bạn có thể tắt bằng cách thêm vào file .zshrc, trước khi load Oh My Zsh:

```sh
zstyle ':omz:alpha:lib:git' async-prompt no
```

Nếu prompt git không hiển thị, hãy thử ép nó bằng cấu hình sau, trước khi source `oh-my-zsh.sh`. Nếu vẫn không được, vui lòng mở issue để báo lỗi.

```sh
zstyle ':omz:alpha:lib:git' async-prompt force
```

## Cập nhật

Mặc định, bạn sẽ được nhắc kiểm tra cập nhật mỗi 2 tuần. Có thể chọn chế độ cập nhật khác bằng cách thêm dòng sau vào `~/.zshrc`, **trước khi Oh My Zsh được tải**:

1. Tự động cập nhật không hỏi xác nhận:

   ```sh
   zstyle ':omz:update' mode auto
   ```

2. Chỉ nhắc nhở mỗi vài ngày nếu có bản cập nhật:

   ```sh
   zstyle ':omz:update' mode reminder
   ```

3. Tắt cập nhật tự động hoàn toàn:

   ```sh
   zstyle ':omz:update' mode disabled
   ```

LƯU Ý: bạn có thể điều chỉnh tần suất kiểm tra cập nhật bằng thiết lập sau:

```sh
# Kiểm tra cập nhật mỗi 7 ngày
zstyle ':omz:update' frequency 7
# Kiểm tra cập nhật mỗi lần mở terminal (không khuyến nghị)
zstyle ':omz:update' frequency 0
```

### Độ chi tiết khi cập nhật

Có thể giới hạn mức độ thông báo khi cập nhật bằng các thiết lập sau:

```sh
zstyle ':omz:update' verbose default # nhắc cập nhật mặc định

zstyle ':omz:update' verbose minimal # chỉ vài dòng

zstyle ':omz:update' verbose silent # chỉ báo lỗi
```

### Cập nhật thủ công

Nếu muốn cập nhật bất kỳ lúc nào (ví dụ có plugin mới mà không muốn đợi một tuần), chỉ cần chạy:

```sh
omz update
```

> [!LƯU Ý]
> Nếu muốn tự động hóa quá trình này trong script, hãy gọi trực tiếp script `upgrade` như sau:
>
> ```sh
> $ZSH/tools/upgrade.sh
> ```
>
> Xem thêm trong [FAQ: Làm sao để cập nhật Oh My Zsh?](https://github.com/ohmyzsh/ohmyzsh/wiki/FAQ#how-do-i-update-oh-my-zsh).
>
> **CHỨC NĂNG `omz update --unattended` ĐÃ BỊ LOẠI BỎ DO GÂY TÁC DỤNG PHỤ**.

Tuyệt diệu! 🎉

## Gỡ cài đặt Oh My Zsh

Oh My Zsh không phải dành cho tất cả mọi người. Chúng tôi sẽ nhớ bạn, nhưng muốn quá trình chia tay này thật dễ dàng.

Nếu muốn gỡ cài đặt `oh-my-zsh`, chỉ cần chạy `uninstall_oh_my_zsh` từ dòng lệnh. Script này sẽ tự xóa và khôi phục cấu hình `bash` hoặc `zsh` trước đó của bạn.

## Tôi đóng góp cho Oh My Zsh như thế nào?

Trước khi tham gia cộng đồng của chúng tôi, hãy đọc [quy tắc ứng xử](CODE_OF_CONDUCT.md).

Tôi không phải là chuyên gia [Zsh](https://www.zsh.org/) và chắc chắn còn nhiều cách cải thiện – nếu bạn có ý tưởng giúp cấu hình dễ bảo trì (và nhanh hơn), đừng ngần ngại fork và gửi pull request!

Chúng tôi cũng cần người thử nghiệm pull request. Hãy xem [các issue mở](https://github.com/ohmyzsh/ohmyzsh/issues) và giúp đỡ nếu có thể.

Xem [Hướng dẫn đóng góp](CONTRIBUTING.md) để biết thêm chi tiết.

### Đừng gửi chủ đề cho chúng tôi

Hiện chúng tôi đã có (hơn) đủ chủ đề. Vui lòng thêm chủ đề của bạn vào trang wiki [chủ đề bên ngoài](https://github.com/ohmyzsh/ohmyzsh/wiki/External-themes).

## Những người đóng góp

Oh My Zsh có cộng đồng người dùng sôi động và các cộng tác viên tuyệt vời. Nếu không có thời gian và sự giúp đỡ của họ, dự án đã không tuyệt vời như hiện nay.

Xin chân thành cảm ơn!

<a href="https://github.com/ohmyzsh/ohmyzsh/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=ohmyzsh/ohmyzsh" width="100%"/>
</a>

## Theo dõi chúng tôi

Chúng tôi có mặt trên mạng xã hội:

- [@ohmyzsh](https://x.com/ohmyzsh) trên X (trước đây là Twitter). Hãy theo dõi nhé.
- [Facebook](https://www.facebook.com/Oh-My-Zsh-296616263819290/) hãy kết nối với chúng tôi.
- [Instagram](https://www.instagram.com/_ohmyzsh/) tag chúng tôi trong bài đăng về Oh My Zsh của bạn!
- [Discord](https://discord.gg/ohmyzsh) để trò chuyện cùng chúng tôi!

## Hàng hóa

Chúng tôi có
[nhãn dán, áo thun, cốc cà phê](https://shop.planetargon.com/collections/oh-my-zsh?utm_source=github)
cho bạn thể hiện tình yêu với Oh My Zsh. Một lần nữa, bạn sẽ trở thành đề tài bàn tán!

## Giấy phép

Oh My Zsh phát hành theo [giấy phép MIT](LICENSE.txt).

## Về Planet Argon

![Planet Argon](https://pa-github-assets.s3.amazonaws.com/PARGON_logo_digital_COL-small.jpg)

Oh My Zsh được khởi đầu bởi đội ngũ tại [Planet Argon](https://www.planetargon.com/?utm_source=github), một
[agency phát triển Ruby on Rails](https://www.planetargon.com/services/ruby-on-rails-development?utm_source=github).
Xem thêm [các dự án mã nguồn mở khác](https://www.planetargon.com/open-source?utm_source=github) của chúng tôi.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---