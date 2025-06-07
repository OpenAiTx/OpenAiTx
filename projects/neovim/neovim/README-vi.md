<h1 align="center">
  <img src="https://raw.githubusercontent.com/neovim/neovim.github.io/master/logos/neovim-logo-300x87.png" alt="Neovim">

  <a href="https://neovim.io/doc/">Tài liệu</a> |
  <a href="https://app.element.io/#/room/#neovim:matrix.org">Trò chuyện</a>
</h1>

[![Phân tích Coverity Scan](https://scan.coverity.com/projects/2227/badge.svg)](https://scan.coverity.com/projects/2227)
[![Gói phần mềm](https://repology.org/badge/tiny-repos/neovim.svg)](https://repology.org/metapackage/neovim)
[![Debian CI](https://badges.debian.net/badges/debian/testing/neovim/version.svg)](https://buildd.debian.org/neovim)
[![Lượt tải xuống](https://img.shields.io/github/downloads/neovim/neovim/total.svg?maxAge=2592001)](https://github.com/neovim/neovim/releases/)

Neovim là một dự án nhằm tái cấu trúc mạnh mẽ [Vim](https://www.vim.org/) với các mục tiêu:

- Đơn giản hóa việc bảo trì và khuyến khích [đóng góp](CONTRIBUTING.md)
- Phân chia công việc giữa nhiều nhà phát triển
- Cho phép [giao diện người dùng nâng cao] mà không cần chỉnh sửa lõi
- Tối đa hóa [khả năng mở rộng](https://neovim.io/doc/user/ui.html)

Xem trang wiki [Giới thiệu](https://github.com/neovim/neovim/wiki/Introduction) và [Lộ trình]
để biết thêm thông tin.

Tính năng
---------

- [Giao diện đồ họa hiện đại (GUI)](https://github.com/neovim/neovim/wiki/Related-projects#gui)
- [Truy cập API](https://github.com/neovim/neovim/wiki/Related-projects#api-clients)
  từ bất kỳ ngôn ngữ nào bao gồm C/C++, C#, Clojure, D, Elixir, Go, Haskell, Java/Kotlin,
  JavaScript/Node.js, Julia, Lisp, Lua, Perl, Python, Racket, Ruby, Rust
- [Trình giả lập terminal](https://neovim.io/doc/user/terminal.html) nhúng, có thể lập trình
- [Quản lý tiến trình bất đồng bộ](https://github.com/neovim/neovim/pull/2247)
- [Chia sẻ dữ liệu (shada)](https://github.com/neovim/neovim/pull/2506) giữa nhiều phiên bản trình soạn thảo
- Hỗ trợ [thư mục cơ sở XDG](https://github.com/neovim/neovim/pull/3470)
- Tương thích với hầu hết các plugin Vim, bao gồm plugin Ruby và Python

Xem [`:help nvim-features`][nvim-features] để biết danh sách đầy đủ và [`:help news`][nvim-news] để cập nhật những thay đổi nổi bật ở phiên bản mới nhất!

Cài đặt từ gói phần mềm
-----------------------

Các gói dựng sẵn cho Windows, macOS và Linux có tại trang
[Phát hành](https://github.com/neovim/neovim/releases/).

[Gói quản lý] có trong [Homebrew], [Debian], [Ubuntu], [Fedora], [Arch Linux], [Void Linux], [Gentoo] và nhiều nền tảng khác!

Cài đặt từ mã nguồn
-------------------

Xem [BUILD.md](./BUILD.md) và [nền tảng được hỗ trợ](https://neovim.io/doc/user/support.html#supported-platforms) để biết chi tiết.

Quy trình xây dựng dựa trên CMake, nhưng có cung cấp Makefile để tiện sử dụng.
Sau khi cài đặt các phụ thuộc, hãy chạy lệnh sau:

    make CMAKE_BUILD_TYPE=RelWithDebInfo
    sudo make install

Để cài đặt vào một vị trí không mặc định:

    make CMAKE_BUILD_TYPE=RelWithDebInfo CMAKE_INSTALL_PREFIX=/duong/dan/du/day/
    make install

Một số gợi ý CMake để kiểm tra quá trình build:

- `cmake --build build --target help` liệt kê tất cả các mục tiêu build.
- `build/CMakeCache.txt` (hoặc `cmake -LAH build/`) chứa giá trị đã được giải quyết của tất cả biến CMake.
- `build/compile_commands.json` hiển thị lệnh biên dịch đầy đủ cho từng đơn vị dịch.

Chuyển đổi từ Vim
-----------------

Xem [`:help nvim-from-vim`](https://neovim.io/doc/user/nvim.html#nvim-from-vim) để biết hướng dẫn.

Cấu trúc dự án
--------------

    ├─ cmake/           Tiện ích CMake
    ├─ cmake.config/    Định nghĩa CMake
    ├─ cmake.deps/      Tiểu dự án để lấy và xây dựng phụ thuộc (tùy chọn)
    ├─ runtime/         Plugin và tài liệu
    ├─ src/nvim/        Mã nguồn ứng dụng (xem src/nvim/README.md)
    │  ├─ api/          Phân hệ API
    │  ├─ eval/         Phân hệ Vimscript
    │  ├─ event/        Phân hệ vòng lặp sự kiện
    │  ├─ generators/   Sinh mã (tiền biên dịch)
    │  ├─ lib/          Cấu trúc dữ liệu tổng quát
    │  ├─ lua/          Phân hệ Lua
    │  ├─ msgpack_rpc/  Phân hệ RPC
    │  ├─ os/           Mã nền tảng cấp thấp
    │  └─ tui/          Giao diện người dùng tích hợp sẵn
    └─ test/            Kiểm thử (xem test/README.md)

Giấy phép
---------

Các đóng góp cho Neovim kể từ [b17d96][license-commit] được cấp phép theo giấy phép
Apache 2.0, ngoại trừ các đóng góp sao chép từ Vim (được nhận diện bởi token
`vim-patch`). Xem LICENSE để biết chi tiết.

    Vim là Charityware.  Bạn có thể sử dụng và sao chép tùy thích, nhưng khuyến khích
    quyên góp cho trẻ em khó khăn ở Uganda.  Vui lòng xem mục kcc trong tài liệu vim hoặc truy cập trang ICCF tại các địa chỉ sau:

            https://iccf-holland.org/
            https://www.vim.org/iccf/
            https://www.iccf.nl/

    Bạn cũng có thể tài trợ cho việc phát triển Vim.  Nhà tài trợ Vim có thể bình chọn
    cho các tính năng mới.  Tiền sẽ được chuyển đến Uganda.

[license-commit]: https://github.com/neovim/neovim/commit/b17d9691a24099c9210289f16afb1a498a89d803
[nvim-features]: https://neovim.io/doc/user/vim_diff.html#nvim-features
[nvim-news]: https://neovim.io/doc/user/news.html
[Roadmap]: https://neovim.io/roadmap/
[advanced UIs]: https://github.com/neovim/neovim/wiki/Related-projects#gui
[Managed packages]: ./INSTALL.md#install-from-package
[Debian]: https://packages.debian.org/testing/neovim
[Ubuntu]: https://packages.ubuntu.com/search?keywords=neovim
[Fedora]: https://packages.fedoraproject.org/pkgs/neovim/neovim/
[Arch Linux]: https://www.archlinux.org/packages/?q=neovim
[Void Linux]: https://voidlinux.org/packages/?arch=x86_64&q=neovim
[Gentoo]: https://packages.gentoo.org/packages/app-editors/neovim
[Homebrew]: https://formulae.brew.sh/formula/neovim

<!-- vim: set tw=80: -->

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---