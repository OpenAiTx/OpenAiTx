
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
        | <a href="https://openaitx.github.io/view.html?user=Virviil&project=oci2git&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# OCI2Git

แอปพลิเคชัน Rust ที่แปลงอิมเมจคอนเทนเนอร์ (Docker ฯลฯ) เป็นที่เก็บ Git โดยแต่ละเลเยอร์ของคอนเทนเนอร์จะถูกแทนด้วยคอมมิตของ Git เพื่อรักษาประวัติและโครงสร้างของอิมเมจต้นฉบับ

![ตัวอย่างการใช้ OCI2Git แปลงอิมเมจ nginx](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/nginx.gif)

## คุณสมบัติ

- วิเคราะห์ Docker image และดึงข้อมูล layer
- สร้าง Git repository โดยแต่ละ layer ของ image จะถูกแทนด้วย commit
- รองรับ layer ว่าง (เช่น ENV, WORKDIR ฯลฯ) เป็น commit ว่าง
- ดึงข้อมูล metadata อย่างครบถ้วนในรูปแบบ Markdown
- สถาปัตยกรรมที่ขยายได้สำหรับรองรับ container engine หลากหลายชนิด

## กรณีการใช้งาน

### การเปรียบเทียบความแตกต่างของ Layer
เมื่อแก้ไขปัญหาเกี่ยวกับ container คุณสามารถใช้ความสามารถในการเปรียบเทียบของ Git เพื่อระบุได้อย่างชัดเจนว่าอะไรเปลี่ยนแปลงไประหว่างสอง layer โดยการรัน `git diff` ระหว่าง commit วิศวกรจะเห็นได้อย่างแม่นยำว่าไฟล์ใดถูกเพิ่ม เปลี่ยนแปลง หรือถูกลบ ทำให้ง่ายต่อการเข้าใจผลกระทบของแต่ละ Dockerfile instruction และค้นหาการเปลี่ยนแปลงที่เป็นปัญหา
![ตัวอย่างการเปรียบเทียบ layer](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/layer-diff.png)

### การติดตามต้นกำเนิด
ด้วยการใช้ `git blame` นักพัฒนาสามารถระบุได้อย่างรวดเร็วว่า layer ใดนำไฟล์หรือบรรทัดของโค้ดนั้นเข้ามาในระบบ ซึ่งมีประโยชน์มากเมื่อวิเคราะห์ปัญหาเกี่ยวกับไฟล์คอนฟิกหรือ dependency แทนที่จะตรวจสอบแต่ละ layer ด้วยตัวเอง คุณสามารถติดตามต้นกำเนิดของไฟล์ไปยัง layer และ Dockerfile instruction ที่เกี่ยวข้องได้ทันที

### การติดตามวงจรชีวิตของไฟล์
OCI2Git ช่วยให้คุณสามารถติดตามเส้นทางของไฟล์แต่ละไฟล์ตลอดประวัติของ image ใน container คุณจะเห็นได้ว่าไฟล์ถูกสร้างขึ้นเมื่อใด ถูกปรับเปลี่ยนอย่างไรในแต่ละ layer และถูกลบเมื่อใดหากเกิดขึ้น มุมมองแบบครบวงจรนี้ช่วยให้เข้าใจวิวัฒนาการของไฟล์โดยไม่ต้องติดตามการเปลี่ยนแปลงด้วยตนเองในหลาย layer

หากต้องการติดตามประวัติของไฟล์ใน image ของ container — รวมถึงเวลาที่ไฟล์ปรากฏครั้งแรก ถูกเปลี่ยนแปลง หรือถูกลบ — คุณสามารถใช้คำสั่ง Git เหล่านี้หลังจากแปลงข้อมูล:

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
OCI2Git จะตรวจสอบเลเยอร์ที่ใช้ร่วมกันระหว่างอิมเมจโดยอัตโนมัติและสร้างโครงสร้างแบบกิ่งก้านที่สะท้อนฐานร่วมกันใน Git ประวัติจะปรากฏดังนี้:
- กิ่งหลักที่รวมทุกเลเยอร์ที่ใช้ร่วมกัน
- กิ่งย่อยแยกออกเมื่ออิมเมจมีความแตกต่างกันจริง ๆ เท่านั้น
- การแสดงผลที่ชัดเจนว่าจุดใดที่อิมเมจมีต้นกำเนิดร่วมกัน และจุดใดที่แยกเป็นเอกลักษณ์
- จัดการกับข้อมูลซ้ำอย่างชาญฉลาด: ถ้าอิมเมจเดียวกันถูกประมวลผลสองครั้ง อัลกอริทึมจะตรวจพบก่อนบันทึกเมทาดาต้าสุดท้ายและข้ามการสร้างกิ่งซ้ำ

แนวทางนี้มีคุณค่าโดยเฉพาะสำหรับ:
- **การวิเคราะห์ตระกูลอิมเมจ**: ทำความเข้าใจว่าอิมเมจแต่ละเวอร์ชัน สถาปัตยกรรม หรือการตั้งค่าเกี่ยวข้องกันอย่างไร
- **ผลกระทบจากอิมเมจฐาน**: ดูโดยตรงว่าการเปลี่ยนแปลงอิมเมจฐานส่งผลต่ออิมเมจที่ต่อยอดอย่างไร
- **โอกาสในการปรับแต่ง**: ค้นหาองค์ประกอบที่ใช้ร่วมกันซึ่งสามารถนำไปใช้กับอิมเมจหลากหลายเวอร์ชันได้ดียิ่งขึ้น

![โครงสร้างรีโพซิทอรีแบบหลายอิมเมจที่แสดงฐานร่วมและกิ่งที่แยกออก](https://raw.githubusercontent.com/Virviil/oci2git/main/./assets/multiimage.png)

### กรณีใช้งานเพิ่มเติม

- **การตรวจสอบด้านความปลอดภัย**: ระบุได้ทันทีว่าแพ็กเกจหรือการตั้งค่าที่มีช่องโหว่ถูกเพิ่มเข้ามาเมื่อไร และย้อนกลับไปยังคำสั่ง build ที่เฉพาะเจาะจงได้
- **การปรับแต่งอิมเมจ**: วิเคราะห์โครงสร้างเลเยอร์เพื่อค้นหากระบวนการที่ซ้ำซ้อนหรือไฟล์ขนาดใหญ่ที่สามารถรวบรวมเพื่อลดขนาดอิมเมจได้
- **การจัดการ Dependencies**: ติดตามว่า dependency ถูกเพิ่ม อัปเกรด หรือถูกลบออกเมื่อใดในประวัติอิมเมจ
- **การปรับปรุงกระบวนการ build**: ตรวจสอบองค์ประกอบของแต่ละเลเยอร์เพื่อปรับแต่งคำสั่ง Dockerfile ให้ cache ได้ดีขึ้นและลดขนาดอิมเมจ
- **การเปรียบเทียบข้ามอิมเมจ**: แปลงอิมเมจที่เกี่ยวข้องกันหลายตัวเป็นรีโพซิทอรี Git และใช้เครื่องมือเปรียบเทียบของ Git วิเคราะห์ความแตกต่างและส่วนที่เหมือนกัน

## การติดตั้ง

### ติดตั้งจากซอร์ส


```bash
# Clone the repository
git clone https://github.com/virviil/oci2git.git
cd oci2git

# Install locally
cargo install --path .
```

### จาก Crates.io

```bash
cargo install oci2git
```

## การใช้งาน

```bash
oci2git [OPTIONS] <IMAGE>
```
อาร์กิวเมนต์:
  `<IMAGE>`  ชื่ออิมเมจที่จะทำการแปลง (เช่น 'ubuntu:latest') หรือเส้นทางไปยังไฟล์ tar เมื่อต้องการใช้ tar engine

ตัวเลือก:
  `-o, --output <o>`  ไดเรกทอรีสำหรับผลลัพธ์เป็น Git repository [ค่าเริ่มต้น: ./container_repo]
  `-e, --engine <ENGINE>`  คอนเทนเนอร์เอนจินที่จะใช้ (docker, nerdctl, tar) [ค่าเริ่มต้น: docker]
  `-h, --help`            แสดงข้อมูลช่วยเหลือ
  `-V, --version`         แสดงข้อมูลเวอร์ชัน

ตัวแปรสภาพแวดล้อม:
  `TMPDIR`  กำหนดตัวแปรสภาพแวดล้อมนี้เพื่อเปลี่ยนตำแหน่งเริ่มต้นที่ใช้สำหรับการประมวลผลข้อมูลชั่วคราว ซึ่งขึ้นอยู่กับแพลตฟอร์ม (เช่น `TMPDIR` บน Unix/macOS, `TEMP` หรือ `TMP` บน Windows)

## ตัวอย่าง

การใช้งาน Docker engine (ค่าเริ่มต้น):

```bash
oci2git -o ./ubuntu-repo ubuntu:latest
```

การใช้ไฟล์อิมเมจ tarball ที่ดาวน์โหลดมาแล้ว:
```bash
oci2git -e tar -o ./ubuntu-repo /path/to/ubuntu-latest.tar
```

เอนจิน tar ต้องการไฟล์ tarball รูปแบบ OCI ที่ถูกต้อง ซึ่งโดยปกติจะถูกสร้างด้วยคำสั่ง `docker save`:
```bash
# Create a tarball from a local Docker image
docker save -o ubuntu-latest.tar ubuntu:latest

# Convert the tarball to a Git repository
oci2git -e tar -o ./ubuntu-repo ubuntu-latest.tar
```

สิ่งนี้จะสร้าง Git repository ใน `./ubuntu-repo` ที่ประกอบด้วย:
- `Image.md` - ข้อมูลเมตาทั้งหมดเกี่ยวกับอิมเมจในรูปแบบ Markdown
- `rootfs/` - เนื้อหาของไฟล์ระบบจากคอนเทนเนอร์

ประวัติของ Git จะสะท้อนประวัติเลเยอร์ของคอนเทนเนอร์:
- คอมมิตแรกประกอบด้วยไฟล์ `Image.md` เท่านั้นพร้อมข้อมูลเมตาเต็มรูปแบบ
- คอมมิตถัดไปแต่ละอันจะแสดงถึงเลเยอร์จากอิมเมจต้นฉบับ
- คอมมิตจะมีคำสั่ง Dockerfile เป็นข้อความคอมมิต

## โครงสร้างของรีโพสิตอรี

```
repository/
├── .git/
├── Image.md     # Complete image metadata
└── rootfs/      # Filesystem content from the container
```
  
## ข้อกำหนด

- Rust รุ่นปี 2021
- Docker CLI (สำหรับรองรับ Docker engine)
- Git

## ใบอนุญาต

MIT


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-26

---