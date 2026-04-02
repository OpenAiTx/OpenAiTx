
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
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

[![Documentation](https://docs.rs/oci2git/badge.svg)][documentation]
[![Crates.io](https://img.shields.io/crates/v/oci2git.svg)](https://crates.io/crates/oci2git)
[![License](https://img.shields.io/crates/l/oci2git.svg)](https://github.com/Virviil/oci2git/blob/master/LICENSE)
[![ดาวน์โหลด](https://img.shields.io/crates/d/oci2git.svg)](https://crates.io/crates/oci2git)

[//]: # (mock สำหรับ test.yaml ในอนาคต)
[//]: # ([![Test Status]&#40;https://img.shields.io/github/actions/workflow/status/Virviil/oci2git/rust.yml?branch=master&event=push&label=Test&#41;]&#40;https://github.com/Virviil/oci2git/actions&#41;)

<div align="left"> </div>  
</div>

แอปพลิเคชัน Rust ที่ใช้แปลงอิมเมจคอนเทนเนอร์ (Docker ฯลฯ) เป็น Git repository และสร้างไฟล์ bill of materials ของไฟล์ระบบ (fsbom) ในรูปแบบ YAML โดยแต่ละเลเยอร์ของคอนเทนเนอร์จะถูกแทนด้วย Git commit เพื่อรักษาประวัติและโครงสร้างของอิมเมจต้นฉบับ

![เดโม OCI2Git ที่แปลงอิมเมจ nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## คุณสมบัติ

- วิเคราะห์อิมเมจ Docker และดึงข้อมูลเลเยอร์
- สร้าง Git repository ที่แต่ละเลเยอร์ของอิมเมจแทนด้วย commit
- สร้างไฟล์ bill of materials ของไฟล์ระบบ (fsbom) ในรูปแบบ YAML พร้อมรายการไฟล์แยกแต่ละเลเยอร์
- รองรับเลเยอร์ว่าง (ENV, WORKDIR ฯลฯ) เป็น commit ว่าง
- ดึงข้อมูลเมทาดาทาครบถ้วนเป็นรูปแบบ Markdown
- สถาปัตยกรรมที่ขยายได้สำหรับรองรับ engine คอนเทนเนอร์ต่าง ๆ

## กรณีใช้งาน

### เปรียบเทียบเลเยอร์ (Layer Diffing)
เมื่อทำการแก้ไขปัญหาของคอนเทนเนอร์ คุณสามารถใช้ความสามารถ diff อันทรงพลังของ Git เพื่อตรวจสอบอย่างแม่นยำว่ามีอะไรเปลี่ยนแปลงระหว่างสองเลเยอร์ การใช้ `git diff` ระหว่าง commit วิศวกรจะเห็นได้ชัดเจนว่าไฟล์ใดถูกเพิ่ม แก้ไข หรือลบออก ทำให้เข้าใจผลกระทบของแต่ละคำสั่งใน Dockerfile และหาตำแหน่งของการเปลี่ยนแปลงที่มีปัญหาได้ง่ายขึ้น
![ตัวอย่างการเปรียบเทียบเลเยอร์](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### การติดตามต้นกำเนิด (Origin Tracking)
โดยใช้ `git blame` นักพัฒนาสามารถตรวจสอบได้อย่างรวดเร็วว่าเลเยอร์ใดสร้างไฟล์หรือโค้ดบรรทัดใดขึ้นมา โดยเฉพาะอย่างยิ่งเมื่อแก้ไขปัญหาไฟล์คอนฟิกหรือ dependencies แทนที่จะต้องตรวจสอบแต่ละเลเยอร์ด้วยตนเอง คุณสามารถติดตามต้นกำเนิดของไฟล์ใด ๆ กลับไปยังเลเยอร์ต้นทางและ Dockerfile ที่เกี่ยวข้องได้ทันที

### การติดตามวงจรชีวิตไฟล์ (File Lifecycle Tracking)
OCI2Git ช่วยให้คุณติดตามเส้นทางของไฟล์เฉพาะตลอดประวัติของอิมเมจคอนเทนเนอร์ คุณสามารถดูได้ว่าไฟล์ถูกสร้างขึ้นเมื่อใด มีการแก้ไขอย่างไรในแต่ละเลเยอร์ และถูกลบออกเมื่อใด การมองเห็นภาพรวมนี้ช่วยให้เข้าใจวิวัฒนาการของไฟล์โดยไม่ต้องติดตามการเปลี่ยนแปลงทีละเลเยอร์ด้วยตนเอง

หากต้องการติดตามประวัติของไฟล์ในอิมเมจคอนเทนเนอร์ของคุณ — รวมถึงช่วงเวลาที่ไฟล์ถูกสร้างขึ้นครั้งแรก มีการเปลี่ยนแปลง หรือถูกลบ — สามารถใช้คำสั่ง Git เหล่านี้หลังจากแปลงอิมเมจแล้ว:

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
คำสั่งเหล่านี้ช่วยให้ติดตามประวัติไฟล์แบบสมบูรณ์ในแต่ละชั้นของคอนเทนเนอร์ได้อย่างง่ายดาย โดยไม่ต้องยุ่งยากกับการแยกและเปรียบเทียบ tarball ของแต่ละชั้นด้วยตนเอง

### การวิเคราะห์หลายชั้น
บางครั้งการเปรียบเทียบที่ให้ข้อมูลเชิงลึกมากที่สุดมาจากการตรวจสอบการเปลี่ยนแปลงในหลายชั้นที่ไม่ต่อเนื่องกัน ด้วย OCI2Git คุณสามารถใช้เครื่องมือเปรียบเทียบของ Git เพื่อวิเคราะห์วิวัฒนาการของส่วนประกอบในแต่ละขั้นตอนการสร้าง ช่วยให้ระบุรูปแบบที่อาจมองไม่เห็นเมื่อดูเฉพาะชั้นที่อยู่ติดกัน

### การสำรวจชั้น
โดยใช้ `git checkout` เพื่อไปยังคอมมิตเฉพาะ คุณสามารถตรวจสอบระบบไฟล์ของคอนเทนเนอร์ได้อย่างแม่นยำตามที่มีอยู่ในชั้นนั้น สิ่งนี้ช่วยให้นักพัฒนาสามารถตรวจสอบสถานะที่แน่นอนของไฟล์และไดเรกทอรีในแต่ละช่วงของกระบวนการสร้างอิมเมจ ซึ่งให้บริบทที่สำคัญยิ่งเมื่อดีบักหรือศึกษาพฤติกรรมของคอนเทนเนอร์
![Checkout to previous commit](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/checkout.png)

### การวิเคราะห์หลายอิมเมจ

เมื่อทำงานกับอิมเมจคอนเทนเนอร์หลายตัวที่มีบรรพบุรุษร่วมกัน OCI2Git จะสร้างสาขาก็ต่อเมื่ออิมเมจเหล่านั้นแยกออกจากกันจริงๆ เท่านั้น ซึ่งช่วยให้สามารถวิเคราะห์อิมเมจที่เกี่ยวข้องกันหลายตัวในรีโพซิทอรีเดียว พร้อมทั้งรักษาประวัติร่วมกันไว้


```bash
# Convert first image to create the base repository
oci2git postgres:16.9-alpine3.21 -o alp

# Convert second image to the same output folder
oci2git nginx:1.28.0-alpine-slim -o alp
```
OCI2Git จะตรวจจับเลเยอร์ที่ใช้ร่วมกันระหว่างอิมเมจโดยอัตโนมัติและสร้างโครงสร้างแบบกิ่งที่สะท้อนถึงฐานร่วมกัน Git history จะแสดงดังนี้:
- ทรังก์หลักที่มีเลเยอร์ที่ใช้ร่วมกันทั้งหมด
- กิ่งแยกที่จะแตกต่างกันเฉพาะเมื่ออิมเมจมีความแตกต่างกันจริง ๆ
- การแสดงภาพที่ชัดเจนว่าอิมเมจใดมีรากฐานร่วมกันหรือเมื่อใดที่แตกต่างกันโดยสิ้นเชิง
- การจัดการสำเนาอัจฉริยะ: หากพบว่าอิมเมจเดียวกันถูกประมวลผลซ้ำสองครั้ง อัลกอริทึมจะตรวจจับได้ก่อนบันทึกข้อมูลเมตาสุดท้ายและข้ามการสร้างกิ่งสำเนาใหม่

แนวทางนี้มีประโยชน์อย่างยิ่งสำหรับ:
- **การวิเคราะห์กลุ่มอิมเมจ**: เข้าใจว่าสายพันธุ์ต่าง ๆ ของอิมเมจ (เวอร์ชัน สถาปัตยกรรม หรือการกำหนดค่าแตกต่างกัน) มีความสัมพันธ์กันอย่างไร
- **ผลกระทบของอิมเมจฐาน**: ดูได้อย่างชัดเจนว่าการเปลี่ยนแปลงในอิมเมจฐานส่งผลต่ออิมเมจที่ต่อยอดอย่างไรบ้าง
- **โอกาสในการเพิ่มประสิทธิภาพ**: ระบุส่วนประกอบที่ใช้ร่วมกันซึ่งสามารถนำมาใช้ให้เกิดประโยชน์มากขึ้นในสายพันธุ์อิมเมจต่าง ๆ

![โครงสร้างคลังหลายอิมเมจแสดงฐานร่วมและกิ่งที่แยกออกจากกัน](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### กรณีการใช้งานเพิ่มเติม

- **การตรวจสอบความปลอดภัย**: ระบุได้อย่างแม่นยำว่าแพ็คเกจหรือการตั้งค่าที่มีช่องโหว่ถูกเพิ่มเข้ามาเมื่อใดและย้อนกลับไปยังคำสั่ง build เฉพาะ
- **การเพิ่มประสิทธิภาพอิมเมจ**: วิเคราะห์โครงสร้างเลเยอร์เพื่อค้นหาการดำเนินการซ้ำซ้อนหรือไฟล์ขนาดใหญ่ที่สามารถถูกรวม เพื่อช่วยลดขนาดอิมเมจ
- **การจัดการการพึ่งพา**: ติดตามว่าการพึ่งพาถูกเพิ่ม อัปเกรด หรือถอดออกเมื่อใดในประวัติอิมเมจ
- **การปรับปรุงกระบวนการ build**: ตรวจสอบองค์ประกอบของเลเยอร์เพื่อปรับแต่ง Dockerfile ให้เหมาะสมสำหรับการแคชและขนาดอิมเมจที่เล็กลง
- **การเปรียบเทียบข้ามอิมเมจ**: แปลงอิมเมจที่เกี่ยวข้องหลายรายการเป็นคลัง Git แล้วใช้เครื่องมือเปรียบเทียบของ Git เพื่อวิเคราะห์ความแตกต่างและความเหมือน

## การติดตั้ง

### ตัวจัดการแพ็คเกจ

#### macOS / Linux (Homebrew)


```bash
brew tap virviil/oci2git
brew install oci2git
```

#### เดเบียน / อูบุนตู

ดาวน์โหลดและติดตั้งแพ็กเกจ .deb จาก [รุ่นล่าสุด](https://github.com/virviil/oci2git/releases/latest):

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

### ไบนารีสำเร็จรูป

ดาวน์โหลดไบนารีที่เหมาะสมกับแพลตฟอร์มของคุณจาก [รุ่นล่าสุด](https://github.com/virviil/oci2git/releases/latest):

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

### จาก Crates.io

```bash
cargo install oci2git
```

### จากแหล่งที่มา

```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

## การใช้งาน

```
oci2git [OPTIONS] <IMAGE>
oci2git convert [OPTIONS] <IMAGE>
oci2git fsbom [OPTIONS] <IMAGE>
```

### `convert` — ภาพ OCI → ที่เก็บ Git

```bash
oci2git convert [OPTIONS] <IMAGE>
# or simply:
oci2git <IMAGE>
```

ตัวเลือก:
  `-o, --output <OUTPUT>`  ไดเรกทอรีเอาต์พุตสำหรับที่เก็บ Git [ค่าเริ่มต้น: ./container_repo]
  `-e, --engine <ENGINE>`  เอนจินคอนเทนเนอร์ที่ใช้ (docker, nerdctl, tar) [ค่าเริ่มต้น: docker]
  `-v, --verbose`          โหมดแสดงรายละเอียด (-v สำหรับ info, -vv สำหรับ debug, -vvv สำหรับ trace)

### `fsbom` — รายการวัสดุของระบบไฟล์

```bash
oci2git fsbom [OPTIONS] <IMAGE>
```

ตัวเลือก:
  `-o, --output <OUTPUT>`  เส้นทางสำหรับไฟล์ YAML BOM [ค่าเริ่มต้น: ./fsbom.yml]
  `-e, --engine <ENGINE>`  เครื่องมือคอนเทนเนอร์ที่จะใช้ (docker, nerdctl, tar) [ค่าเริ่มต้น: docker]
  `-v, --verbose`          โหมดแสดงรายละเอียด (-v สำหรับ info, -vv สำหรับ debug, -vvv สำหรับ trace)

ตัวแปรสภาพแวดล้อม:
  `TMPDIR`  ตั้งค่าตัวแปรสภาพแวดล้อมนี้เพื่อเปลี่ยนตำแหน่งเริ่มต้นที่ใช้สำหรับการประมวลผลข้อมูลชั่วคราว ตำแหน่งนี้ขึ้นอยู่กับแพลตฟอร์ม (เช่น `TMPDIR` บน Unix/macOS, `TEMP` หรือ `TMP` บน Windows)

## ตัวอย่าง

### แปลง

ใช้งาน Docker engine (ค่าเริ่มต้น):
```bash
oci2git ubuntu:latest
# or explicitly:
oci2git convert ubuntu:latest -o ./ubuntu-repo
```

การใช้ไฟล์อิมเมจ tarball ที่ดาวน์โหลดมาแล้ว:
```bash
oci2git convert -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

เอนจิน tar ต้องการไฟล์ tarball รูปแบบ OCI ที่ถูกต้อง ซึ่งโดยปกติจะถูกสร้างด้วยคำสั่ง `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git convert -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

จะสร้างที่เก็บ Git ใน `./ubuntu-repo` ที่มี:
- `Image.md` - เมตาดาต้าครบถ้วนเกี่ยวกับอิมเมจในรูปแบบ Markdown
- `rootfs/` - เนื้อหาของระบบไฟล์จากคอนเทนเนอร์

ประวัติ Git สะท้อนประวัติเลเยอร์ของคอนเทนเนอร์:
- คอมมิทแรกมีแค่ไฟล์ `Image.md` พร้อมเมตาดาต้าครบถ้วน
- คอมมิทถัดไปแต่ละอันแสดงเลเยอร์จากอิมเมจต้นฉบับ
- คอมมิทจะมีคำสั่ง Dockerfile เป็นข้อความคอมมิท

### รายการวัสดุของระบบไฟล์ (fsbom)

สร้าง YAML ที่แสดงไฟล์ทุกไฟล์ที่ถูกเพิ่มหรือแก้ไขในแต่ละเลเยอร์:
```bash
oci2git fsbom ubuntu:latest -o ubuntu.yml
```

การใช้ไฟล์ tarball:
```bash
oci2git fsbom -e tar image.tar -o image-bom.yml
```

เอาต์พุต YAML จะแสดงทุกเลเยอร์โดยมีรายการที่ระบุประเภท (`file`, `hardlink`, `symlink`, `directory`) และสถานะ (`n:uid:gid` สำหรับใหม่, `m:uid:gid` สำหรับที่ถูกแก้ไข) ไฟล์ที่ถูกลบ (OCI whiteouts) จะไม่ถูกแสดง

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

## โครงสร้างที่เก็บข้อมูล

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```


## ข้อกำหนด

- Rust รุ่น 2021
- Docker CLI (สำหรับรองรับ Docker engine)
- Git

## ใบอนุญาต

MIT

[เอกสารประกอบ]: https://docs.rs/oci2git/


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-02

---