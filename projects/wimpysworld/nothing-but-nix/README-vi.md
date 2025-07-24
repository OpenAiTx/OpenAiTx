
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

**Biến runner GitHub Actions của bạn thành một cỗ máy [Nix](https://zero-to-nix.com/concepts/nix/) ❄️ mạnh mẽ bằng cách loại bỏ triệt để các phần mềm không cần thiết được cài sẵn.**

Runner của GitHub Actions chỉ cung cấp rất ít dung lượng đĩa cho Nix - chỉ khoảng ~20GB.
*Nothing but Nix* **loại bỏ tàn nhẫn** phần mềm không cần thiết, giúp bạn có **65GB đến 130GB** cho Nix store! 💪

## Cách sử dụng 🔧

Thêm action này **trước khi** cài đặt Nix trong workflow của bạn:

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

- Chỉ hỗ trợ các runner **Ubuntu** chính thức của GitHub Actions
- Phải chạy **trước khi** Nix được cài đặt

## Vấn đề: Tạo Không Gian Cho Nix Phát Triển 🌱

Các runner tiêu chuẩn của GitHub Actions bị nhồi nhét *"phần mềm thừa"* mà bạn sẽ không bao giờ dùng đến trong workflow Nix:

- 🌍 Trình duyệt web. Rất nhiều. Phải có đủ hết!
- 🐳 Docker images chiếm hàng gigabyte dung lượng ổ đĩa quý giá
- 💻 Runtime ngôn ngữ không cần thiết (.NET, Ruby, PHP, Java...)
- 📦 Trình quản lý gói chỉ để bám bụi số
- 📚 Tài liệu mà chẳng ai đọc bao giờ

Phần mềm thừa này chỉ để lại ~20GB cho kho Nix của bạn - quá ít cho các build Nix nghiêm túc! 😞

## Giải pháp: Chỉ Có Nix ️❄️

**Chỉ Có Nix** áp dụng cách tiếp cận “đốt sạch” với runner GitHub Actions và thu hồi dung lượng ổ đĩa không thương tiếc bằng hai giai đoạn:

1. **Chém Đầu Tiên:** Ngay lập tức tạo volume `/nix` lớn (~65GB) bằng cách lấy không gian trống từ `/mnt`
2. **Tàn Sát Nền:** Trong khi workflow của bạn tiếp tục, chúng tôi loại bỏ không thương tiếc phần mềm không cần thiết để mở rộng volume `/nix` lên tới ~130GB
   - Trình duyệt web? Không ⛔
   - Docker images? Xóa sạch 🗑️
   - Runtime ngôn ngữ? Tiêu diệt 💥
   - Quản lý gói? Hủy diệt 💣
   - Tài liệu? Bốc hơi ️👻

Việc thanh lọc hệ thống file được thực hiện bởi `rmz` (từ dự án [Fast Unix Commands (FUC)](https://github.com/SUPERCILEX/fuc)) - một lựa chọn thay thế hiệu suất cao cho `rm` giúp thu hồi dung lượng cực nhanh! ⚡
   - Nhanh hơn `rm` tiêu chuẩn cả một bậc
   - Xử lý xóa song song để đạt hiệu quả tối đa
   - **Thu hồi dung lượng ổ đĩa chỉ trong vài giây thay vì vài phút!** ️⏱️

Kết quả cuối cùng? Một runner GitHub Actions với **65GB đến 130GB** dung lượng sẵn sàng cho Nix! 😁

### Tăng Dung Lượng Động

Không như các giải pháp khác, **Chỉ Có Nix** tăng dung lượng `/nix` một cách linh hoạt:

1. **Tạo Volume Ban Đầu (1-10 giây):** (*tùy thuộc vào Giao thức Hatchet*)
   - Tạo thiết bị loop từ không gian trống trên `/mnt`
   - Thiết lập hệ thống file BTRFS ở cấu hình RAID0
   - Mount với chế độ nén và tối ưu hiệu năng
   - Ngay lập tức cung cấp 65GB `/nix`, ngay cả trước khi bắt đầu thanh lọc

2. **Mở Rộng Nền (30-180 giây):** (*tùy thuộc vào Giao thức Hatchet*)
   - Thực hiện các thao tác thanh lọc
   - Theo dõi không gian mới được giải phóng khi phần mềm thừa bị loại bỏ
   - Thêm đĩa mở rộng vào volume `/nix` một cách động
   - Cân bằng lại hệ thống file để tích hợp dung lượng mới

Volume `/nix` sẽ **tự động tăng lên trong quá trình thực thi workflow** 🎩🪄

### Chọn Vũ Khí: Giao Thức Hatchet 🪓

Kiểm soát cấp độ hủy diệt 💥 với tham số `hatchet-protocol`:

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
Khi `nix-permission-edict` được đặt thành `true`, hành động sẽ chạy `sudo chown -R "$(id --user)":"$(id --group)" /nix` sau khi gắn kết `/nix`.

Bây giờ hãy bắt tay vào xây dựng điều tuyệt vời với toàn bộ không gian Nix store tuyệt vời đó! ❄️


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-24

---