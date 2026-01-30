
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</a>
      </div>
    </div>
  </details>
</div>

<div align="center">
<img src="https://raw.githubusercontent.com/Virviil/oci2git/main/assets/logo.png" width="140px" />

# OCI2Git

[![Tài liệu](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![Giấy phép](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![Số lượt tải xuống](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (giả lập cho future test.yaml)
[//]: # ([![Trạng thái kiểm thử]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Một ứng dụng Rust giúp chuyển đổi các image container (Docker, v.v.) sang kho lưu trữ Git. Mỗi layer của container sẽ được biểu diễn dưới dạng một commit Git, giữ nguyên lịch sử và cấu trúc của image gốc.

![Demo OCI2Git chuyển đổi image nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Tính năng

- Phân tích image Docker và trích xuất thông tin layer
- Tạo kho Git, trong đó mỗi layer của image là một commit
- Hỗ trợ các layer rỗng (ENV, WORKDIR, v.v.) dưới dạng commit rỗng
- Trích xuất đầy đủ metadata sang định dạng Markdown
- Kiến trúc mở rộng, hỗ trợ nhiều engine container khác nhau

## Trường hợp sử dụng

### So sánh các layer
Khi xử lý sự cố container, bạn có thể sử dụng khả năng diff mạnh mẽ của Git để xác định chính xác những gì đã thay đổi giữa hai layer bất kỳ. Bằng cách chạy `git diff` giữa các commit, kỹ sư có thể thấy rõ tệp nào được thêm, sửa đổi hoặc xóa, giúp dễ dàng hiểu tác động của từng lệnh Dockerfile và xác định thay đổi gây vấn đề.
![Ví dụ về diff layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Theo dõi nguồn gốc
Sử dụng `git blame`, các nhà phát triển có thể nhanh chóng xác định layer nào đã giới thiệu một tệp hoặc dòng mã cụ thể. Điều này đặc biệt hữu ích khi xử lý sự cố với file cấu hình hoặc phụ thuộc. Thay vì kiểm tra từng layer một cách thủ công, bạn có thể truy dấu nguồn gốc bất kỳ tệp nào về đúng layer gốc và chỉ thị Dockerfile tương ứng.

### Theo dõi vòng đời tệp tin
OCI2Git cho phép bạn theo dõi hành trình của một tệp cụ thể xuyên suốt lịch sử của image container. Bạn có thể xem khi nào tệp lần đầu xuất hiện, bị chỉnh sửa qua các layer, và khi nào (nếu có) bị xóa. Góc nhìn toàn diện này giúp hiểu quá trình phát triển của file mà không cần theo dõi thủ công qua hàng chục layer.

Để theo dõi lịch sử của một tệp trong image container — gồm khi nào nó xuất hiện, bị thay đổi, hoặc bị xóa — bạn có thể dùng các lệnh Git sau sau khi chuyển đổi:

```bash
# Full history of a file (including renames)
git log --follow -- /rootfs/my/file/path

# First appearance (i.e. creation) - see which layer introduced the file
git log --diff-filter=A -- /rootfs/my/file/path

# All changes made to the file (with diffs)
git log -p --follow -- /rootfs/my/file/path

# When the file was deleted
git log --diff-filter=D -- /rootfs/my/file/path

# Show short commit info (concise layer history)
git log --follow --oneline -- /rootfs/my/file/path
```

Các lệnh này giúp dễ dàng truy vết toàn bộ lịch sử của bất kỳ tệp nào qua các lớp của container mà không cần phải trích xuất và so sánh các tệp tar của lớp một cách thủ công.

### Phân Tích Đa Lớp
Đôi khi những so sánh có giá trị nhất lại đến từ việc xem xét sự thay đổi qua nhiều lớp không liên tiếp. Với OCI2Git, bạn có thể dùng các công cụ so sánh của Git để phân tích cách các thành phần phát triển qua nhiều giai đoạn build, nhận diện các mẫu thay đổi mà có thể bị bỏ qua khi chỉ nhìn vào các lớp liền kề.

### Khám Phá Các Lớp
Bằng cách sử dụng `git checkout` để chuyển đến bất kỳ commit nào, bạn có thể kiểm tra hệ thống tệp container đúng như nó tồn tại ở lớp đó. Điều này cho phép các nhà phát triển kiểm tra trạng thái chính xác của tệp và thư mục tại mọi thời điểm trong quá trình tạo ảnh, cung cấp ngữ cảnh vô giá khi gỡ lỗi hoặc đánh giá hành vi của container.
![Checkout đến commit trước đó](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### Phân Tích Đa Ảnh

Khi làm việc với nhiều ảnh container có cùng nguồn gốc, OCI2Git sẽ thông minh tạo nhánh chỉ khi các ảnh thực sự tách biệt. Điều này cho phép bạn phân tích nhiều ảnh liên quan trong một kho lưu trữ duy nhất mà vẫn bảo toàn lịch sử chung của chúng.

```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git tự động phát hiện các lớp chia sẻ giữa các ảnh và tạo ra một cấu trúc phân nhánh phản ánh nền tảng chung của chúng. Lịch sử Git sẽ hiển thị:
- Một nhánh chính chứa tất cả các lớp dùng chung
- Các nhánh riêng biệt chỉ phân tách khi các ảnh thực sự khác nhau
- Hình dung rõ ràng vị trí các ảnh có chung tổ tiên và vị trí chúng trở nên độc lập
- Xử lý thông minh các bản sao: nếu cùng một ảnh được xử lý hai lần, thuật toán sẽ phát hiện trước khi commit siêu dữ liệu cuối cùng và bỏ qua việc tạo nhánh trùng lặp

Phương pháp này đặc biệt hữu ích cho:
- **Phân tích họ ảnh**: Hiểu cách các biến thể khác nhau của một ảnh (phiên bản, kiến trúc hoặc cấu hình khác nhau) liên quan đến nhau như thế nào
- **Ảnh nền tảng ảnh hưởng**: Xem chính xác cách các thay đổi đối với một ảnh nền tảng ảnh hưởng đến nhiều ảnh dẫn xuất
- **Cơ hội tối ưu hóa**: Xác định các thành phần dùng chung có thể được tận dụng tốt hơn giữa các biến thể ảnh

![Cấu trúc kho đa ảnh cho thấy nền tảng chung và các nhánh phân tách](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Trường hợp sử dụng bổ sung

- **Kiểm toán bảo mật**: Xác định chính xác thời điểm các gói hoặc cấu hình dễ bị tổn thương được đưa vào và truy vết chúng về các hướng dẫn xây dựng cụ thể.
- **Tối ưu hóa ảnh**: Phân tích cấu trúc lớp để tìm các thao tác dư thừa hoặc tập tin lớn có thể hợp nhất, giúp giảm kích thước ảnh.
- **Quản lý phụ thuộc**: Theo dõi khi nào các phụ thuộc được thêm, nâng cấp hoặc gỡ bỏ trong lịch sử ảnh.
- **Cải thiện quy trình xây dựng**: Kiểm tra thành phần lớp để tối ưu hóa các hướng dẫn Dockerfile nhằm tăng hiệu quả cache và giảm kích thước ảnh.
- **So sánh nhiều ảnh**: Chuyển đổi nhiều ảnh liên quan thành kho Git và sử dụng công cụ so sánh của Git để phân tích sự khác biệt và điểm chung của chúng.

## Cài đặt

### Trình quản lý gói

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### Debian / Ubuntu

Tải xuống và cài đặt gói .deb từ [phiên bản mới nhất](https://github.com/virviil/oci2git/releases/latest):

```bash
# For amd64 (x86_64)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_amd64.deb
sudo dpkg -i oci2git_VERSION_amd64.deb

# For arm64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git_VERSION_arm64.deb
sudo dpkg -i oci2git_VERSION_arm64.deb
```

#### Arch Linux (AUR)

```bash
# Using yay
yay -S oci2git-bin

# Using paru
paru -S oci2git-bin

# Manual installation
git clone https://aur.archlinux.org/oci2git-bin.git
cd oci2git-bin
makepkg -si
```

### Tệp nhị phân dựng sẵn

Tải xuống tệp nhị phân phù hợp với nền tảng của bạn từ [phát hành mới nhất](https://github.com/virviil/oci2git/releases/latest):

```bash
# Linux x86_64
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-linux-x86_64.tar.gz
tar xzf oci2git-linux-x86_64.tar.gz
sudo mv oci2git-linux-x86_64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git

# macOS (Apple Silicon)
wget https://github.com/virviil/oci2git/releases/latest/download/oci2git-darwin-aarch64.tar.gz
tar xzf oci2git-darwin-aarch64.tar.gz
sudo mv oci2git-darwin-aarch64 /usr/local/bin/oci2git
chmod +x /usr/local/bin/oci2git
```

### Từ Crates.io

```bash
cargo install oci2git
```

### Từ nguồn

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## Cách sử dụng

```bash
oci2git [OPTIONS] <IMAGE>
```

Tham số:
  `<IMAGE>`  Tên ảnh cần chuyển đổi (ví dụ: 'ubuntu:latest') hoặc đường dẫn tới file tar khi sử dụng engine tar

Tùy chọn:
  `-o, --output <o>`  Thư mục đầu ra cho kho Git [mặc định: ./container_repo]
  `-e, --engine <ENGINE>`  Engine container để sử dụng (docker, nerdctl, tar) [mặc định: docker]
  `-h, --help`            In thông tin trợ giúp
  `-V, --version`         In thông tin phiên bản

Biến môi trường:
  `TMPDIR`  Thiết lập biến môi trường này để thay đổi vị trí mặc định dùng cho xử lý dữ liệu trung gian. Tùy thuộc vào nền tảng (ví dụ: `TMPDIR` trên Unix/macOS, `TEMP` hoặc `TMP` trên Windows).

## Ví dụ

Sử dụng engine Docker (mặc định):
```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

Sử dụng một tarball hình ảnh đã được tải xuống:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Công cụ tar yêu cầu một tệp tarball định dạng OCI hợp lệ, thường được tạo bằng lệnh `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Điều này sẽ tạo một kho Git tại `./ubuntu-repo` chứa:
- `Image.md` - Metadata đầy đủ về ảnh dưới dạng Markdown
- `rootfs/` - Nội dung hệ thống tập tin từ container

Lịch sử Git phản ánh lịch sử các lớp của container:
- Commit đầu tiên chỉ chứa tệp `Image.md` với đầy đủ metadata
- Mỗi commit tiếp theo đại diện cho một lớp từ ảnh gốc
- Các commit bao gồm lệnh Dockerfile như thông điệp commit

## Cấu trúc Kho lưu trữ

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
## Yêu cầu

- Rust phiên bản 2021
- Docker CLI (hỗ trợ Docker engine)
- Git

## Giấy phép

MIT

[tài liệu]: https://docs.rs/oci2git/




---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-30

---