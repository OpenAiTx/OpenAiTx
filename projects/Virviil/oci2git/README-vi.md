
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
[![Lượt tải xuống](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock for future test.yaml)
[//]: # ([![Trạng thái kiểm thử]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

Một ứng dụng Rust chuyển đổi các ảnh container (Docker, v.v.) sang kho lưu trữ Git và tạo bill of materials hệ thống tệp (fsbom) ở định dạng YAML. Mỗi lớp container được biểu diễn dưới dạng một commit Git, giữ nguyên lịch sử và cấu trúc của ảnh gốc.

![Demo OCI2Git chuyển đổi ảnh nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Tính năng

- Phân tích ảnh Docker và trích xuất thông tin lớp
- Tạo kho lưu trữ Git trong đó mỗi lớp ảnh là một commit
- Sinh bill of materials hệ thống tệp (fsbom) dạng YAML với danh sách tệp từng lớp
- Hỗ trợ các lớp rỗng (ENV, WORKDIR, v.v.) như các commit rỗng
- Trích xuất đầy đủ metadata ra định dạng Markdown
- Kiến trúc mở rộng để hỗ trợ nhiều engine container khác nhau

## Các trường hợp sử dụng

### So sánh các lớp (Layer Diffing)
Khi xử lý sự cố container, bạn có thể sử dụng khả năng diff mạnh mẽ của Git để xác định chính xác sự thay đổi giữa hai lớp bất kỳ. Bằng cách chạy `git diff` giữa các commit, kỹ sư có thể xem chính xác tệp nào được thêm, sửa đổi hoặc xóa, giúp dễ dàng hiểu tác động của từng lệnh Dockerfile và xác định thay đổi gây lỗi.
![Ví dụ về so sánh lớp](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Truy vết nguồn gốc (Origin Tracking)
Dùng `git blame`, các nhà phát triển có thể nhanh chóng xác định lớp nào đã đưa vào một tệp hoặc dòng mã cụ thể. Điều này đặc biệt hữu ích khi xác định sự cố với tệp cấu hình hoặc thư viện phụ thuộc. Thay vì kiểm tra thủ công từng lớp, bạn có thể truy xuất ngay nguồn gốc của bất kỳ tệp nào về lớp gốc và lệnh Dockerfile tương ứng.

### Theo dõi vòng đời tệp (File Lifecycle Tracking)
OCI2Git cho phép bạn theo dõi hành trình của một tệp cụ thể trong suốt lịch sử ảnh container. Bạn có thể quan sát lúc tệp được tạo ra, cách nó thay đổi qua các lớp, và khi nào (nếu có) nó bị xóa. Cái nhìn toàn diện này giúp hiểu sự phát triển của tệp mà không cần theo dõi thủ công qua hàng chục lớp.

Để theo dõi lịch sử một tệp trong ảnh container của bạn — bao gồm lúc nó xuất hiện, bị thay đổi hoặc xóa — bạn có thể sử dụng các lệnh Git sau khi chuyển đổi:

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

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — hình ảnh OCI → kho Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

Tùy chọn:
  `-o, --output <OUTPUT>`  Thư mục đầu ra cho kho Git [mặc định: ./container_repo]
  `-e, --engine <ENGINE>`  Công cụ container sử dụng (docker, nerdctl, tar) [mặc định: docker]
  `-v, --verbose`          Chế độ chi tiết (-v cho thông tin, -vv cho debug, -vvv cho trace)

### `fsbom` — Danh mục vật liệu của hệ thống tập tin

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```

Tùy chọn:
  `-o, --output <OUTPUT>`  Đường dẫn xuất ra cho tệp YAML BOM [mặc định: ./fsbom.yml]
  `-e, --engine <ENGINE>`  Công cụ container để sử dụng (docker, nerdctl, tar) [mặc định: docker]
  `-v, --verbose`          Chế độ chi tiết (-v cho thông tin, -vv cho debug, -vvv cho trace)

Biến môi trường:
  `TMPDIR`  Đặt biến môi trường này để thay đổi vị trí mặc định dùng cho xử lý dữ liệu trung gian. Điều này phụ thuộc vào nền tảng (ví dụ: `TMPDIR` trên Unix/macOS, `TEMP` hoặc `TMP` trên Windows).

## Ví dụ

### Chuyển đổi

Sử dụng engine Docker (mặc định):
```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

Sử dụng một tarball hình ảnh đã được tải xuống:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

Công cụ tar yêu cầu một tệp tarball định dạng OCI hợp lệ, thường được tạo bằng lệnh `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

Điều này sẽ tạo một kho Git tại `./ubuntu-repo` chứa:
- `Image.md` - Dữ liệu metadata đầy đủ về hình ảnh ở định dạng Markdown
- `rootfs/` - Nội dung hệ thống tệp từ container

Lịch sử Git phản ánh lịch sử các lớp của container:
- Commit đầu tiên chỉ chứa tệp `Image.md` với metadata đầy đủ
- Mỗi commit tiếp theo đại diện cho một lớp từ hình ảnh gốc
- Commit bao gồm lệnh Dockerfile làm thông điệp commit

### Hóa đơn vật liệu hệ thống tệp (fsbom)

Tạo một tệp YAML liệt kê mọi tệp được thêm hoặc sửa đổi theo từng lớp:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```
Sử dụng tarball:

```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

Đầu ra YAML liệt kê mọi lớp với các mục của nó được gắn thẻ theo loại (`file`, `hardlink`, `symlink`, `directory`) và trạng thái (`n:uid:gid` cho mới, `m:uid:gid` cho đã sửa đổi). Các tệp đã xóa (OCI whiteouts) bị loại trừ.

```yaml
layers:
  - index: 0
    command: "ADD rootfs.tar.gz / # buildkit"
    digest: "sha256:45f3ea58..."
    entries:
      - type: file
        path: "bin/busybox"
        size: 919304
        mode: 493
        stat: "n:0:0"
      - type: hardlink
        path: "bin/sh"
        target: "bin/busybox"
        stat: "n:0:0"
      - type: symlink
        path: "lib64"
        target: "lib"
        stat: "n:0:0"
  - index: 1
    command: "RUN apk add --no-cache curl"
    digest: "sha256:..."
    entries:
      - type: file
        path: "usr/bin/curl"
        size: 204800
        mode: 493
        stat: "n:0:0"
      - type: file
        path: "etc/apk/world"
        size: 32
        mode: 420
        stat: "m:0:0"
```

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

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---