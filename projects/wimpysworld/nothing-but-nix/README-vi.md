
<div align="right">
  <details>
    <summary >🌐 Ngôn ngữ</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=wimpysworld&project=nothing-but-nix&lang=id">Bahasa Indonesia</a>
      </div>
    </div>
  </details>
</div>

# Nothing but Nix

**Biến runner GitHub Actions của bạn thành một cỗ máy [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ mạnh mẽ bằng cách loại bỏ triệt để phần mềm dư thừa được cài sẵn.**

Các runner GitHub Actions chỉ cung cấp dung lượng đĩa rất hạn chế cho Nix - chỉ khoảng ~20GB.
*Nothing but Nix* **loại bỏ hoàn toàn** phần mềm không cần thiết, giúp bạn có **65GB đến 130GB** dành cho kho lưu trữ Nix của mình! 💪

## Sử dụng 🔧

Thêm hành động này **trước khi** cài đặt Nix trong quy trình làm việc của bạn:

```yaml
jobs:
  build:
    runs-on: ubuntu-latest
    permissions:
      contents: read
      id-token: write
    steps:
      - uses: actions/checkout@v4
      - uses: wimpysworld/nothing-but-nix@main
      - name: Install Nix
        uses: DeterminateSystems/nix-installer-action@main
      - name: Run Nix
        run: |
          nix --version
          # Your Nix-powered steps here...
```
### Yêu cầu ️✔️

- Chỉ hỗ trợ runner **Ubuntu** chính thức của GitHub Actions
- Phải chạy **trước khi** Nix được cài đặt
- **Runner macOS/Darwin**: Hành động này sẽ tự động bỏ qua với cảnh báo nếu chạy trên macOS. Runner macOS đã cung cấp đủ không gian cho Nix và không cần hành động này
- **Runner Windows**: Hành động này sẽ tự động bỏ qua với cảnh báo nếu chạy trên Windows. Runner Windows có bố cục hệ thống tập tin và các ràng buộc khác biệt

## Vấn đề: Tạo Không Gian Cho Nix Phát Triển 🌱

Runner tiêu chuẩn của GitHub Actions chứa đầy *"bloatware"* mà bạn sẽ không bao giờ sử dụng trong quy trình Nix:

- 🌍 Trình duyệt web. Rất nhiều. Phải có hết!
- 🐳 Ảnh Docker chiếm hàng gigabyte không gian ổ đĩa quý giá
- 💻 Runtime ngôn ngữ không cần thiết (.NET, Ruby, PHP, Java...)
- 📦 Trình quản lý gói tích tụ bụi số hóa
- 📚 Tài liệu mà không ai đọc

Việc này chỉ để lại ~20GB cho kho Nix của bạn - không đủ cho các bản dựng Nix nghiêm túc! 😞

## Giải pháp: Chỉ Có Nix ️❄️

**Chỉ Có Nix** sử dụng phương pháp dọn dẹp triệt để runner của GitHub Actions và thu hồi không gian ổ đĩa bằng một cuộc tấn công hai giai đoạn:

1. **Chém đầu tiên:** Tạo ngay một phân vùng `/nix` lớn (~65GB) bằng cách chiếm không gian trống từ `/mnt`
2. **Càn quét nền:** Trong khi quy trình của bạn tiếp tục, chúng tôi loại bỏ phần mềm không cần thiết để mở rộng phân vùng `/nix` lên đến ~130GB
   - Trình duyệt web? Không ⛔
   - Ảnh Docker? Xóa sạch 🗑️
   - Runtime ngôn ngữ? Tiêu diệt 💥
   - Trình quản lý gói? Hủy diệt 💣
   - Tài liệu? Bốc hơi ️👻

Việc dọn dẹp hệ thống tập tin được thực hiện bởi `rmz` (từ dự án [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - một lựa chọn thay thế hiệu suất cao cho `rm` giúp thu hồi không gian siêu nhanh! ⚡
   - Hiệu suất vượt trội so với `rm` tiêu chuẩn
   - Xử lý xóa song song tối ưu hóa hiệu quả
   - **Thu hồi không gian ổ đĩa chỉ trong vài giây thay vì vài phút!** ️⏱️

Kết quả cuối cùng? Một runner GitHub Actions với **65GB đến 130GB** không gian sẵn sàng cho Nix! 😁

### Tăng trưởng động của phân vùng

Không giống như các giải pháp khác, **Nothing but Nix** mở rộng phân vùng `/nix` của bạn một cách động:

1. **Tạo Volume Ban Đầu (1-10 giây):** (*tùy thuộc vào Giao Thức Hatchet*)
   - Tạo thiết bị loop từ không gian trống trên `/mnt`
   - Thiết lập hệ thống tập tin BTRFS ở cấu hình RAID0
   - Gắn kết với chế độ nén và tối ưu hiệu suất
   - Cung cấp ngay lập tức `/nix` 65GB, ngay cả trước khi quá trình dọn dẹp bắt đầu

2. **Mở Rộng Nền (30-180 giây):** (*tùy thuộc vào Giao Thức Hatchet*)
   - Thực hiện các thao tác dọn dẹp
   - Giám sát không gian mới được giải phóng khi các tệp rác bị loại bỏ
   - Tự động thêm ổ đĩa mở rộng vào phân vùng `/nix`
   - Cân bằng lại hệ thống tập tin để tích hợp không gian mới

Phân vùng `/nix` sẽ **tự động mở rộng trong quá trình thực thi workflow** 🎩🪄

### Chọn Vũ Khí Của Bạn: Giao Thức Hatchet 🪓

Kiểm soát mức độ hủy diệt 💥 với tham số đầu vào `hatchet-protocol`:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'cleave'  # Options: holster, carve, cleave (default), rampage
```

#### So sánh các giao thức ⚖️

| Giao thức | `/nix` | Mô tả                                            | Xóa apt    | Xóa docker   | Xóa snap   | Hệ thống tập tin bị xóa      |
|-----------|--------|--------------------------------------------------|------------|--------------|------------|------------------------------|
| Holster   | ~65GB  | Giữ lưỡi rìu trong bao, dùng dung lượng từ `/mnt`| Không      | Không        | Không      | Không có                     |
| Carve     | ~85GB  | Kết hợp và tận dụng không gian trống từ `/` và `/mnt` | Không      | Không        | Không      | Không có                     |
| Cleave    | ~115GB | Cắt mạnh và dứt khoát các gói lớn                | Tối thiểu  | Có           | Có         | `/opt` và `/usr/local`       |
| Rampage   | ~130GB | Loại bỏ toàn bộ rác một cách tàn bạo, không khoan nhượng | Mạnh tay   | Có           | Có         | Muahahaha! 🔥🌎              |

Hãy lựa chọn cẩn thận:
- **Holster** khi bạn cần các công cụ runner hoạt động đầy đủ
- **Carve** để giữ công cụ runner nhưng tận dụng toàn bộ không gian cho Nix
- **Cleave** (*mặc định*) để cân bằng giữa dung lượng và chức năng
- **Rampage** khi bạn cần tối đa không gian cho Nix và không quan tâm hệ thống hỏng gì `#nix-is-life`

### Chứng kiến sự tàn sát 🩸

Theo mặc định, quá trình xóa diễn ra âm thầm trong nền khi workflow của bạn tiếp tục. Nhưng nếu bạn muốn xem cảnh tàn sát trực tiếp:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    witness-carnage: true  # Default: false
```

### Tùy chỉnh Khu vực An toàn 🛡️

Kiểm soát lượng không gian cần dành ra khỏi việc chiếm dụng của kho Nix bằng kích thước khu vực an toàn tùy chỉnh:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    ️hatchet-protocol: 'cleave'
    root-safe-haven: '3072'   # Reserve 3GB on the / filesystem
    mnt-safe-haven: '2048'    # Reserve 2GB on the /mnt filesystem
```
Những vùng an toàn này xác định dung lượng không gian (tính bằng MB) sẽ được khoan dung giữ lại trong quá trình thu hồi không gian:
- Giá trị mặc định của `root-safe-haven` là 2048MB (2GB)
- Giá trị mặc định của `mnt-safe-haven` là 1024MB (1GB)

Tăng các giá trị này nếu bạn cần thêm không gian an toàn trên hệ thống tệp của mình, hoặc giảm chúng để không khoan nhượng! 😈

### Cấp quyền sở hữu thư mục /nix cho người dùng (Sắc lệnh quyền hạn Nix) 🧑‍⚖️

Một số trình cài đặt hoặc cấu hình Nix mong muốn thư mục `/nix` có thể ghi bởi người dùng hiện tại. Theo mặc định, `/nix` thuộc sở hữu của root. Nếu bạn cần quyền sở hữu của người dùng (ví dụ, cho một số script cài đặt Nix không sử dụng `sudo` cho tất cả thao tác trong `/nix`), bạn có thể kích hoạt `nix-permission-edict`:


```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    nix-permission-edict: true  # Default: false
```
Khi `nix-permission-edict` được đặt thành `true`, hành động này sẽ chạy lệnh `sudo chown -R "$(id --user)":"$(id --group)" /nix` sau khi gắn kết `/nix`.

### Cấu hình Nix để sử dụng /nix/build

Hành động này tạo `/nix/build` để các bản dựng Nix derivation sử dụng không gian đã thu hồi. Thêm `build-dir` vào cấu hình Nix của bạn:


```yaml
- uses: cachix/install-nix-action@v31
  with:
    extra_nix_config: |
      build-dir = /nix/build
```

Hoặc với DeterminateSystems:

```yaml
- uses: DeterminateSystems/nix-installer-action@main
  with:
    extra-conf: |
      build-dir = /nix/build
```

Điều này hướng dẫn Nix thực hiện các bản dựng trên phân vùng BTRFS lớn thay vì thư mục tạm thời mặc định của hệ thống.

## Khắc phục sự cố 🔍

### "No space left on device" trong quá trình build lớn

Nếu bản dựng của bạn hết dung lượng dù chỉ sử dụng Nothing but Nix, có thể là do quá trình dọn dẹp nền chưa hoàn thành trước khi bản dựng của bạn sử dụng hết không gian còn lại. Điều này thường ảnh hưởng đến:

- Các bài kiểm tra VM NixOS tạo ảnh đĩa lớn
- Các bản dựng có nhiều phụ thuộc không được lưu trong bộ nhớ đệm
- Bộ công cụ Rust và các lần biên dịch lớn khác

**Giải pháp:** Sử dụng `witness-carnage: true` để buộc dọn dẹp đồng bộ. Điều này đảm bảo toàn bộ dung lượng được thu hồi *trước khi* bản dựng của bạn bắt đầu:

```yaml
- uses: wimpysworld/nothing-but-nix@main
  with:
    hatchet-protocol: 'rampage'
    witness-carnage: true
```

Điều này thêm 30-180 giây vào quá trình thiết lập workflow của bạn, nhưng đảm bảo có tối đa không gian khi quá trình build bắt đầu.

Bây giờ hãy tạo ra điều tuyệt vời với toàn bộ không gian Nix store tuyệt vời đó! ❄️

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-18

---