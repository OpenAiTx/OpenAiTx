# ytdlp-gui
Giao diện GUI cho yt-dlp viết bằng Rust

- [Cài đặt](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [các bản phân phối khác](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [Xây dựng từ mã nguồn](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [Cấu hình](https://github.com/BKSalman/ytdlp-gui#configuration)
- [Đóng góp](https://github.com/BKSalman/ytdlp-gui#contribution)

# Xem trước
![image](https://github.com/user-attachments/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# Cài đặt
## Linux

### NixOS (Flake)
Bạn có thể sử dụng flake.nix trong kho lưu trữ

trong `flake.nix` của bạn:
```nix
{
  inputs = {
    nixpkgs.url = "github:nixos/nixpkgs/nixpkgs-unstable";

    ytdlp-gui = {
      url = "github:bksalman/ytdlp-gui";
    };
  };

    outputs = { nixpkgs, ytdlp-gui, ...}:
    let
      system = "x86_64-linux";

      pkgs = import nixpkgs {
        inherit system;
        overlays = [
          ytdlp-gui.overlay
        ];
      };
    in
    {
      ...snip
```

sau đó bạn có thể thêm nó như một gói bình thường, hoặc vào home-manager hoặc nixosConfiguration của bạn

### Fedora
tải gói rpm từ trang releases rồi cài bằng lệnh ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
tải gói deb từ trang releases rồi cài bằng lệnh ``sudo apt install ./<deb_package_name>``

### Arch

Có sẵn trong AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### các bản phân phối khác

#### 1- tải xuống ``yt-dlp``
hoặc

&nbsp; &nbsp; &nbsp; a- từ kho lưu trữ bản phân phối của bạn

&nbsp; &nbsp; &nbsp; b- hoặc tải xuống [binary](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp), sau đó di chuyển nó vào thư mục bin của bạn, và cấp quyền thực thi bằng lệnh `chmod +x <bin_file>`

#### 2- tải xuống ``ffmpeg`` hoặc ``ffmpeg-free`` từ kho lưu trữ bản phân phối của bạn


#### 3- tải xuống binary ``ytdlp-gui`` từ [trang releases](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### chỉ cần tải file zip từ trang releases, giải nén vào một thư mục con và khởi động ``ytdlp-gui.exe``

# Xây dựng từ mã nguồn
để xây dựng từ mã nguồn bạn cần có `cargo` và `rustc`, bạn có thể cài chúng qua `rustup` (trình quản lý toolchain Rust), hoặc từ kho lưu trữ bản phân phối của bạn, tùy bạn thích

sau đó chạy các lệnh sau:
```bash
# clone kho lưu trữ vào thư mục "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# vào thư mục
cd ytdlp-gui
# bạn có thể xây dựng dự án bằng lệnh này
cargo build
# hoặc xây dựng ở chế độ release để hiệu năng tốt hơn
cargo build -r
```
sau đó binary sẽ nằm ở `<project-root>/target/debug/ytdlp-gui` hoặc `<project-root>/target/release/ytdlp-gui`

và bạn có thể chạy trực tiếp:
```bash
# từ thư mục gốc dự án
./target/release/ytdlp-gui
```

hoặc dùng cargo:
```bash
cargo r
# hoặc cho chế độ release
cargo r -r
```

# Cấu hình

Từ phiên bản v0.2.2+ ứng dụng lưu cấu hình trong thư mục cấu hình mặc định của nền tảng/HĐH tương ứng tại ``<config_dir>/ytdlp-gui/config.toml``

file mặc định trông như sau:

```toml
# Tùy chọn
# Đây là thư mục chứa bin, không phải file bin
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) nếu không đặt, lệnh sẽ là `yt-dlp <app_args>`

# Tùy chọn
download_folder = "<some_cool_path>" # mặc định = "~/Videos"

[options]
video_resolution = "FullHD" # các lựa chọn: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # các lựa chọn: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # các lựa chọn: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  các lựa chọn: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### Lưu ý: các tùy chọn chất lượng/định dạng sẽ được tự động lưu khi nhấn nút tải xuống

# Đóng góp
Mọi hình thức đóng góp đều được hoan nghênh, dù là Pull requests, Issues (báo lỗi/yêu cầu cải tiến)

Tuy nhiên, tôi có thể không phản hồi nhanh hoặc thực hiện ngay những yêu cầu đó, vì tôi đang tập trung vào các việc khác

Nhưng tôi sẽ cố gắng hết sức 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---