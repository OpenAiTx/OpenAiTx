
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

Một ứng dụng Rust chuyển đổi hình ảnh container (Docker, v.v.) thành kho lưu trữ Git. Mỗi lớp của container được thể hiện dưới dạng một lần commit trong Git, giữ nguyên lịch sử và cấu trúc của hình ảnh gốc.

![Demo OCI2Git chuyển đổi hình ảnh nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## Tính năng

- Phân tích các ảnh Docker và trích xuất thông tin về các lớp
- Tạo kho Git nơi mỗi lớp ảnh được đại diện bằng một commit
- Hỗ trợ các lớp rỗng (ENV, WORKDIR, v.v.) dưới dạng các commit rỗng
- Trích xuất đầy đủ metadata sang định dạng Markdown
- Kiến trúc mở rộng để hỗ trợ các engine container khác nhau

## Các trường hợp sử dụng

### So sánh các lớp
Khi xử lý sự cố container, bạn có thể sử dụng khả năng so sánh mạnh mẽ của Git để xác định chính xác sự thay đổi giữa hai lớp bất kỳ. Bằng cách chạy `git diff` giữa các commit, kỹ sư có thể xem rõ những tệp nào đã được thêm, sửa đổi hoặc xóa, giúp dễ dàng hiểu tác động của mỗi lệnh Dockerfile và xác định các thay đổi gây ra lỗi.
![Ví dụ về so sánh lớp](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### Theo dõi nguồn gốc
Sử dụng `git blame`, các lập trình viên có thể nhanh chóng xác định lớp nào đã tạo ra một tệp hoặc dòng mã cụ thể. Điều này đặc biệt hữu ích khi kiểm tra các vấn đề về tệp cấu hình hoặc phụ thuộc. Thay vì kiểm tra thủ công từng lớp, bạn có thể ngay lập tức truy dấu nguồn gốc của bất kỳ tệp nào về lớp nguồn và lệnh Dockerfile tương ứng.

### Theo dõi vòng đời tệp
OCI2Git cho phép bạn theo dõi quá trình phát triển của một tệp cụ thể xuyên suốt lịch sử ảnh container. Bạn có thể quan sát thời điểm tệp được tạo lần đầu, cách nó bị chỉnh sửa qua các lớp, và nếu/khi nó bị xóa. Góc nhìn toàn diện này giúp hiểu rõ sự phát triển của tệp mà không cần phải kiểm tra thủ công qua hàng chục lớp.

Để theo dõi lịch sử của một tệp trong ảnh container — bao gồm thời điểm xuất hiện, bị thay đổi hoặc xóa — bạn có thể sử dụng các lệnh Git sau khi chuyển đổi:

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
OCI2Git tự động phát hiện các lớp được chia sẻ giữa các ảnh và tạo ra cấu trúc phân nhánh phản ánh cơ sở chung của chúng. Lịch sử Git sẽ hiển thị:
- Một nhánh chính chung chứa tất cả các lớp được chia sẻ
- Các nhánh riêng biệt chỉ tách ra khi các ảnh thực sự khác nhau
- Hình ảnh trực quan rõ ràng về nơi các ảnh chia sẻ nguồn gốc chung so với nơi chúng trở nên độc lập
- Xử lý thông minh các bản sao: nếu cùng một ảnh được xử lý hai lần, thuật toán sẽ phát hiện trước khi cam kết metadata cuối cùng và bỏ qua việc tạo nhánh trùng lặp

Cách tiếp cận này đặc biệt có giá trị cho:
- **Phân tích họ ảnh**: Hiểu cách các biến thể khác nhau của một ảnh (các phiên bản, kiến trúc hoặc cấu hình khác nhau) liên quan đến nhau như thế nào
- **Ảnh cơ sở tác động**: Thấy chính xác cách thay đổi ảnh cơ sở ảnh hưởng đến nhiều ảnh dẫn xuất
- **Cơ hội tối ưu hóa**: Nhận diện các thành phần chia sẻ có thể tận dụng tốt hơn giữa các biến thể ảnh

![Cấu trúc kho lưu trữ đa ảnh hiển thị cơ sở chia sẻ và các nhánh phân kỳ](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### Các trường hợp sử dụng bổ sung

- **Kiểm toán bảo mật**: Xác định chính xác thời điểm các gói hoặc cấu hình dễ bị tấn công được thêm vào và truy vết về các hướng dẫn build cụ thể.
- **Tối ưu hóa ảnh**: Phân tích cấu trúc lớp để tìm các thao tác dư thừa hoặc các tệp lớn có thể được hợp nhất, giúp giảm kích thước ảnh.
- **Quản lý phụ thuộc**: Theo dõi khi nào các phụ thuộc được thêm, nâng cấp hoặc xóa trong lịch sử ảnh.
- **Cải tiến quy trình build**: Kiểm tra thành phần lớp để tối ưu hóa các hướng dẫn Dockerfile nhằm tăng hiệu quả cache và giảm kích thước ảnh.
- **So sánh ảnh chéo**: Chuyển đổi nhiều ảnh liên quan sang kho Git và sử dụng công cụ so sánh của Git để phân tích sự khác biệt và điểm chung của chúng.

## Cài đặt

### Từ mã nguồn


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### Từ Crates.io

```bash
cargo install oci2git
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

- Phiên bản Rust 2021
- Docker CLI (hỗ trợ Docker engine)
- Git

## Giấy phép

MIT

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---