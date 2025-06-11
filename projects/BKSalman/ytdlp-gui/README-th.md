# ytdlp-gui
GUI สำหรับ yt-dlp เขียนด้วยภาษา Rust

- [การติดตั้ง](https://github.com/BKSalman/ytdlp-gui#installation)
  - [NixOS (Flake)](https://github.com/BKSalman/ytdlp-gui#nixos-flake)
  - [Fedora](https://github.com/BKSalman/ytdlp-gui#fedora)
  - [Ubuntu](https://github.com/BKSalman/ytdlp-gui#ubuntu)
  - [การแจกจ่ายอื่นๆ](https://github.com/BKSalman/ytdlp-gui#other-distributions)
  - [Windows](https://github.com/BKSalman/ytdlp-gui#windows)
- [การสร้างจากซอร์สโค้ด](https://github.com/BKSalman/ytdlp-gui#build-from-source)
- [การตั้งค่า](https://github.com/BKSalman/ytdlp-gui#configuration)
- [การมีส่วนร่วม](https://github.com/BKSalman/ytdlp-gui#contribution)

# ตัวอย่าง
![image](https://raw.githubusercontent.com/BKSalman/ytdlp-gui/main/assets/edeecfe8-4d5b-4f10-b5e3-35188d9a23a5)


# การติดตั้ง
## Linux

### NixOS (Flake)
คุณสามารถใช้ flake.nix ในรีโปนี้ได้

ในไฟล์ `flake.nix` ของคุณ:
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

จากนั้นคุณสามารถเพิ่มเป็นแพ็กเกจปกติ ไม่ว่าจะเป็นสำหรับ home-manager หรือ nixosConfiguration

### Fedora
ดาวน์โหลดแพ็กเกจ rpm จากหน้าปล่อยเวอร์ชัน แล้วติดตั้งด้วยคำสั่ง ``sudo dnf localinstall <rpm_package_name>``

### Ubuntu
ดาวน์โหลดแพ็กเกจ deb จากหน้าปล่อยเวอร์ชัน แล้วติดตั้งด้วยคำสั่ง ``sudo apt install ./<deb_package_name>``

### Arch

มีให้ใน AUR [ytdlp-gui](https://aur.archlinux.org/packages/ytdlp-gui)

### การแจกจ่ายอื่นๆ

#### 1- ดาวน์โหลด ``yt-dlp``
โดย

&nbsp; &nbsp; &nbsp; ก- จากรีโปของการแจกจ่ายของคุณ

&nbsp; &nbsp; &nbsp; ข- หรือดาวน์โหลด [binary](https://github.com/yt-dlp/yt-dlp/releases/latest/download/yt-dlp) แล้วย้ายไปยังโฟลเดอร์ bin ของคุณ และทำให้เป็นไฟล์ที่สามารถรันได้โดยใช้คำสั่ง `chmod +x <bin_file>`

#### 2- ดาวน์โหลด ``ffmpeg`` หรือ ``ffmpeg-free`` จากรีโปของการแจกจ่ายของคุณ


#### 3- ดาวน์โหลด binary ของ ``ytdlp-gui`` จาก [หน้าปล่อยเวอร์ชัน](https://github.com/BKSalman/ytdlp-gui/releases)

## Windows
##### เพียงดาวน์โหลดไฟล์ zip จากหน้าปล่อยเวอร์ชัน แตกไฟล์ในโฟลเดอร์ย่อย แล้วเริ่มต้น ``ytdlp-gui.exe``

# การสร้างจากซอร์สโค้ด
เพื่อสร้างจากซอร์สโค้ด คุณต้องมี `cargo` และ `rustc` คุณสามารถติดตั้งผ่าน `rustup` (ตัวจัดการ toolchain ของ Rust) หรือจากรีโปของการแจกจ่ายของคุณก็ได้

หลังจากนั้นให้รันคำสั่งต่อไปนี้:
```bash
# โคลนรีโปไปยังโฟลเดอร์ "ytdlp-gui"
git clone https://github.com/BKSalman/ytdlp-gui
# เข้าไปในโฟลเดอร์
cd ytdlp-gui
# คุณสามารถสร้างโปรเจคโดยใช้คำสั่งนี้
cargo build
# หรือสร้างในโหมด release เพื่อประสิทธิภาพที่ดีกว่า
cargo build -r
```
จากนั้นไฟล์ไบนารีจะอยู่ที่ `<project-root>/target/debug/ytdlp-gui` หรือ `<project-root>/target/release/ytdlp-gui`

และคุณสามารถรันได้โดยตรง:
```bash
# จากโฟลเดอร์โปรเจค
./target/release/ytdlp-gui
```

หรือใช้ cargo:
```bash
cargo r
# หรือสำหรับโหมด release
cargo r -r
```

# การตั้งค่า

สำหรับเวอร์ชัน v0.2.2+ แอปพลิเคชันจะบันทึกการตั้งค่าไว้ในไดเรกทอรีการตั้งค่าเริ่มต้นของแพลตฟอร์ม/ระบบปฏิบัติการนั้นๆ ที่ ``<config_dir>/ytdlp-gui/config.toml``

ไฟล์เริ่มต้นจะมีลักษณะดังนี้:

```toml
# ตัวเลือก
# นี่คือไดเรกทอรีของ bin ไม่ใช่ bin เอง
# bin_path = "<some_cool_path>" # (0.2.4)

bin_dir = "<some_cool_path>" # (0.2.5+) หากไม่ตั้งค่า คำสั่งจะเป็น `yt-dlp <app_args>`

# ตัวเลือก
download_folder = "<some_cool_path>" # ค่าเริ่มต้น = "~/Videos"

[options]
video_resolution = "FullHD" # ตัวเลือก: "Sd" "Hd" "FullHD" "TwoK" "FourK"
video_format = "Mp4" # ตัวเลือก: "Mp4" "Mkv" "Webm"
audio_quality = "Good" # ตัวเลือก: "Best" "Good" "Medium" "Low"
audio_format = "Mp3" #  ตัวเลือก: "Mp3" "Wav" "Vorbis" "M4a" "Opus"
```

### หมายเหตุ: ตัวเลือกคุณภาพ/รูปแบบจะถูกบันทึกโดยอัตโนมัติเมื่อกดปุ่มดาวน์โหลด

# การมีส่วนร่วม
ยินดีต้อนรับทุกรูปแบบของการมีส่วนร่วม ไม่ว่าจะเป็น Pull requests, Issues (รายงานบั๊ก/คำขอปรับปรุง)

อย่างไรก็ตาม ฉันอาจไม่ตอบกลับหรือดำเนินการตามคำขอได้รวดเร็ว เพราะกำลังมุ่งเน้นงานอื่น

แต่ฉันจะพยายามเต็มที่ 👍

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---