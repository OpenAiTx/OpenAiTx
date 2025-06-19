# Go-Deploy เครื่องมือสำหรับการดีพลอย

เครื่องมือดีพลอยแบบอัตโนมัติที่พัฒนาด้วยภาษา Go รองรับการอัปโหลดไฟล์ที่สร้างจากเครื่องของคุณไปยังเซิร์ฟเวอร์ระยะไกลผ่านโปรโตคอล SFTP

## คุณสมบัติ

- ✅ **การส่งข้อมูลปลอดภัย**: ใช้โปรโตคอล SFTP ส่งข้อมูลแบบเข้ารหัสผ่าน SSH
- ✅ **ซิงโครไนซ์ไดเรกทอรี**: อัปโหลดโครงสร้างไดเรกทอรีทั้งชุดแบบ recursive รักษาระดับโฟลเดอร์ไว้
- ✅ **สร้างโฟลเดอร์อัตโนมัติ**: สร้างโครงสร้างไดเรกทอรีบนเซิร์ฟเวอร์โดยอัตโนมัติ
- ✅ **ปรับเส้นทางอัตโนมัติ**: คำนวณเส้นทางไฟล์ในเครื่องโดยอัตโนมัติตามตำแหน่งไฟล์โปรแกรมที่รัน ไม่ต้องสนใจไดเรกทอรีที่รัน
- ✅ **รองรับไฟล์คอนฟิก**: รองรับไฟล์คอนฟิก JSON สะดวกต่อการจัดการคอนฟิกหลายสภาพแวดล้อม
- ✅ **ยกเว้นไฟล์**: รองรับรูปแบบ wildcard สำหรับยกเว้นไฟล์ที่ไม่ต้องการอัปโหลด
- ✅ **สำรองไฟล์อัตโนมัติ**: สำรองไฟล์บนเซิร์ฟเวอร์ก่อนอัปโหลดไฟล์ใหม่โดยอัตโนมัติ
- ✅ **กลไกรีเทรย์**: หากอัปโหลดล้มเหลวจะรีเทรย์อัตโนมัติ เพิ่มโอกาสสำเร็จ
- ✅ **สถิติโดยละเอียด**: แสดงจำนวนไฟล์ที่อัปโหลด, ขนาดไฟล์, เวลาที่ใช้ และความเร็ว
- ✅ **แสดงสถานะการอัปโหลด**: แสดงความคืบหน้าและข้อมูลไฟล์แบบเรียลไทม์
- ✅ **จัดการข้อผิดพลาด**: จัดการข้อผิดพลาดและแสดง log อย่างครบถ้วน

## ข้อกำหนดระบบ

- Go เวอร์ชัน 1.18 หรือสูงกว่า
- เซิร์ฟเวอร์ปลายทางรองรับโปรโตคอล SSH/SFTP

## คำแนะนำการติดตั้ง

### 1. โคลนโปรเจกต์

```bash
git clone <your-repo-url>
cd go-deploy
```

### 2. เริ่มต้นโมดูล Go

```bash
go mod init go-deploy
go mod tidy
```

### 3. ติดตั้งไลบรารีที่จำเป็น

โปรแกรมจะดาวน์โหลดไลบรารีดังต่อไปนี้อัตโนมัติ:

- `github.com/pkg/sftp` - SFTP client
- `golang.org/x/crypto/ssh` - SSH client

## คำอธิบายคอนฟิก

โปรแกรมรองรับการตั้งค่าคอนฟิก 2 รูปแบบ:

### 1. ใช้ไฟล์คอนฟิก (แนะนำ)

คัดลอก `config.example.json` เป็น `config.json` แล้วแก้ไขค่าตามต้องการ:

```bash
cp config.example.json config.json
```

จากนั้นแก้ไข `config.json`:

```json
{
  "server": {
    "host": "your-server-ip",
    "port": 22,
    "username": "your-username",
    "password": "your-password",
    "timeout": 10
  },
  "paths": {
    "local": "../../unpackage/dist/build/web",
    "remote": "/opt/your-path/dist"
  },
  "options": {
    "backup": true,
    "backup_suffix": ".backup",
    "exclude_patterns": [
      "*.log",
      "*.map",
      ".DS_Store",
      "node_modules"
    ],
    "max_retries": 3,
    "chunk_size": 1048576
  }
}
```

#### คำอธิบายแต่ละค่าคอนฟิก

**คอนฟิก server**:

- `host`: ที่อยู่ของเซิร์ฟเวอร์ SSH
- `port`: พอร์ต SSH ปกติเป็น 22
- `username`: ชื่อผู้ใช้ SSH
- `password`: รหัสผ่าน SSH (แนะนำให้ใช้ key ใน production)
- `timeout`: ระยะเวลาหมดเวลาเชื่อมต่อ (วินาที)

**คอนฟิก paths**:

- `local`: เส้นทางไดเรกทอรีในเครื่อง รองรับทั้งแบบ relative และ absolute
- `remote`: เส้นทางไดเรกทอรีบนเซิร์ฟเวอร์ ต้องเป็น absolute path

**คอนฟิก options**:

- `backup`: สร้างไฟล์สำรองบนเซิร์ฟเวอร์ก่อนอัปโหลดหรือไม่
- `backup_suffix`: ชื่อสกุลไฟล์สำรอง กำหนดได้เอง ข้ามหากไม่มีไฟล์ต้นฉบับ
- `exclude_patterns`: รูปแบบไฟล์ที่ต้องการยกเว้น รองรับ wildcard
- `max_retries`: จำนวนครั้งสูงสุดที่รีเทรย์เมื่ออัปโหลดล้มเหลว
- `chunk_size`: ขนาดบล็อกไฟล์ที่ส่งแต่ละครั้ง (ไบต์, ยังไม่รองรับ)

### 2. คอนฟิกเริ่มต้น (โหมดรองรับย้อนหลัง)

หากไม่มีไฟล์ `config.json` โปรแกรมจะใช้ค่าคอนฟิกที่มีอยู่ในตัวเพื่อรองรับการทำงานต่อเนื่อง

#### ลำดับความสำคัญของไฟล์คอนฟิก

1. **ไฟล์คอนฟิกที่ระบุผ่านคำสั่ง**: ผ่านพารามิเตอร์ `--config`
2. **ไฟล์คอนฟิกเริ่มต้น**: `config.json` ในโฟลเดอร์ปัจจุบัน
3. **คอนฟิกเริ่มต้นในโปรแกรม**: ใช้ค่าที่โปรแกรมกำหนดไว้ในตัว

#### กฎการจัดการเส้นทาง

- **เส้นทางไฟล์คอนฟิก**:

  - เส้นทางแบบ relative: อ้างอิงจากไดเรกทอรีที่ไฟล์โปรแกรมอยู่
  - เส้นทางแบบ absolute: ใช้เส้นทางที่ระบุโดยตรง
- **เส้นทางไดเรกทอรีในเครื่อง**:

  - เส้นทางแบบ relative: อ้างอิงจากไดเรกทอรีที่ไฟล์โปรแกรมอยู่
  - เส้นทางแบบ absolute: ใช้เส้นทางที่ระบุโดยตรง

## คำแนะนำการใช้งาน

### พารามิเตอร์บรรทัดคำสั่ง

โปรแกรมรองรับพารามิเตอร์ดังต่อไปนี้:

```bash
# แสดงข้อมูลช่วยเหลือ
./deploy --help

# แสดงเวอร์ชัน
./deploy --version

# ใช้ config.json เป็นไฟล์คอนฟิกเริ่มต้น
./deploy

# ใช้ไฟล์คอนฟิกที่ระบุ
./deploy --config prod.json

# ใช้ไฟล์คอนฟิกที่ระบุแบบ absolute path
./deploy --config /path/to/config.json
```

### รันในสภาพแวดล้อมพัฒนา

```bash
# ใช้คอนฟิกเริ่มต้น
go run main.go

# ใช้ไฟล์คอนฟิกที่ระบุ
go run main.go --config test.json

# แสดงข้อมูลช่วยเหลือ
go run main.go --help
```

### รันหลังคอมไพล์

```bash
# คอมไพล์
go build -o deploy main.go

# รันด้วยคอนฟิกเริ่มต้น
./deploy

# รันด้วยไฟล์คอนฟิกที่ระบุ
./deploy --config prod.json
```

## คำแนะนำการแพ็กเกจ

### 1. แพ็กเกจสำหรับแพลตฟอร์มปัจจุบัน

```bash
# คอมไพล์ไฟล์รันบนแพลตฟอร์มปัจจุบัน
go build -o deploy main.go
```

### 2. แพ็กเกจข้ามแพลตฟอร์ม

#### Linux 64 บิต

```bash
GOOS=linux GOARCH=amd64 go build -o deploy-linux-amd64 main.go
```

#### Windows 64 บิต
```bash
GOOS=windows GOARCH=amd64 go build -o deploy-windows-amd64.exe main.go
```

#### macOS 64位

```bash
GOOS=darwin GOARCH=amd64 go build -o deploy-darwin-amd64 main.go
```

#### macOS ARM64 (M1/M2)

```bash
GOOS=darwin GOARCH=arm64 go build -o deploy-darwin-arm64 main.go
```

### 3. ปรับแต่งการแพ็ก (ลดขนาดไฟล์)

```bash
# ลบข้อมูลดีบั๊กและตารางสัญลักษณ์
go build -ldflags="-s -w" -o deploy main.go

# ใช้ UPX บีบอัด (ต้องติดตั้ง UPX ก่อน)
upx --best deploy
```

### 4. สคริปต์แพ็กแบบกลุ่ม

สร้างสคริปต์ `build.sh` :

```bash
#!/bin/bash

# สร้างไดเรกทอรีสำหรับ build
mkdir -p builds

# สร้างไฟล์สำหรับแต่ละแพลตฟอร์ม
echo "กำลังสร้างเวอร์ชัน Linux 64บิต..."
GOOS=linux GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-linux-amd64 main.go

echo "กำลังสร้างเวอร์ชัน Windows 64บิต..."
GOOS=windows GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-windows-amd64.exe main.go

echo "กำลังสร้างเวอร์ชัน macOS 64บิต..."
GOOS=darwin GOARCH=amd64 go build -ldflags="-s -w" -o builds/deploy-darwin-amd64 main.go

echo "กำลังสร้างเวอร์ชัน macOS ARM64..."
GOOS=darwin GOARCH=arm64 go build -ldflags="-s -w" -o builds/deploy-darwin-arm64 main.go

echo "สร้างเสร็จสิ้น!"
ls -la builds/
```

เรียกใช้งานสคริปต์:

```bash
chmod +x build.sh
./build.sh
```

## ตัวอย่างการใช้งาน

### แสดงข้อมูลช่วยเหลือ

```bash
$ ./deploy --help
Go-Deploy เครื่องมือดีพลอย

วิธีใช้: ./deploy [options]

ตัวเลือก:
  -config string
        เส้นทางไฟล์คอนฟิก (default "config.json")
  -help
        แสดงข้อมูลช่วยเหลือ
  -version
        แสดงข้อมูลเวอร์ชัน

ตัวอย่าง:
  ./deploy                           # ใช้ไฟล์คอนฟิกเริ่มต้น config.json
  ./deploy --config prod.json        # ใช้ไฟล์คอนฟิกที่ระบุ
  ./deploy --config /path/to/config.json  # ใช้ไฟล์คอนฟิกแบบ path สมบูรณ์
```

### ใช้ไฟล์คอนฟิกที่ระบุ

```bash
$ ./deploy --config prod.json
เริ่มต้นดำเนินการดีพลอย...
พยายามอ่านไฟล์คอนฟิก: /path/to/go-deploy/prod.json
ใช้ไฟล์คอนฟิก...
ไดเรกทอรีโลคัล /path/to/project/dist มีอยู่แล้ว
กำลังเชื่อมต่อกับเซิร์ฟเวอร์ SSH...
เชื่อมต่อกับเซิร์ฟเวอร์ SSH สำเร็จ
...
```

### ใช้ไฟล์คอนฟิก

```bash
$ ./deploy
เริ่มต้นดำเนินการดีพลอย...
พยายามอ่านไฟล์คอนฟิก: /path/to/go-deploy/config.json
ใช้ไฟล์คอนฟิก...
ไดเรกทอรีโลคัล /path/to/project/unpackage/dist/build/web มีอยู่แล้ว
กำลังเชื่อมต่อกับเซิร์ฟเวอร์ SSH...
เชื่อมต่อกับเซิร์ฟเวอร์ SSH สำเร็จ
กำลังสร้าง SFTP client...
สร้าง SFTP client สำเร็จ
เตรียมอัปโหลดไปยังไดเรกทอรีปลายทาง: /opt/xsoft/nginx/html/app/dist
เริ่มอัปโหลดไดเรกทอรี...
กำลังวนไดเรกทอรีโลคัล: /path/to/project/unpackage/dist/build/web
สร้างไดเรกทอรี: /opt/xsoft/nginx/html/app/dist
ไฟล์ static/js/app.js.map ถูกยกเว้น ข้ามการอัปโหลด
สร้างแบ็กอัป: /opt/xsoft/nginx/html/app/dist/index.html -> /opt/xsoft/nginx/html/app/dist/index.html.backup
อัปโหลดไฟล์: /path/to/project/unpackage/dist/build/web/index.html -> /opt/xsoft/nginx/html/app/dist/index.html
ไฟล์ .DS_Store ถูกยกเว้น ข้ามการอัปโหลด
อัปโหลดไฟล์: /path/to/project/unpackage/dist/build/web/static/css/app.css -> /opt/xsoft/nginx/html/app/dist/static/css/app.css
อัปโหลดล้มเหลว (พยายาม 1/3): ข้อผิดพลาดเครือข่าย
ลองอัปโหลดใหม่ (2/3): /path/to/project/unpackage/dist/build/web/static/js/app.js
อัปโหลดไฟล์: /path/to/project/unpackage/dist/build/web/static/js/app.js -> /opt/xsoft/nginx/html/app/dist/static/js/app.js
...
อัปโหลดไดเรกทอรีสำเร็จ!
สถิติ:
  - จำนวนไฟล์ที่อัปโหลด: 485
  - จำนวนไดเรกทอรีที่สร้าง: 18
  - ขนาดที่ถ่ายโอน: 25.8 MB
  - เวลาที่ใช้อัปโหลด: 38.5s
  - เวลารวม: 39.2s
  - ความเร็วการถ่ายโอน: 0.67 MB/s
```

## หมายเหตุ

1. **ความปลอดภัย**:

   - แนะนำให้ใช้การยืนยันตัวตนด้วยคีย์ SSH แทนรหัสผ่านในระบบ production
   - ขณะนี้ใช้ `ssh.InsecureIgnoreHostKey()` ใน production ควรตรวจสอบ host key
2. **เครือข่าย**:

   - ตรวจสอบให้แน่ใจว่าเครื่อง local สามารถเข้าถึงพอร์ต 22 ของเซิร์ฟเวอร์ปลายทางได้
   - ความเร็วในการถ่ายโอนขึ้นอยู่กับแบนด์วิดท์และประสิทธิภาพเซิร์ฟเวอร์
3. **สิทธิ์**:

   - ตรวจสอบให้แน่ใจว่า user SSH มีสิทธิ์เขียนในไดเรกทอรีเป้าหมาย
   - หากจำเป็น อาจต้องใช้สิทธิ์ sudo
4. **เส้นทาง**:

   - เส้นทาง local จะคำนวณอัตโนมัติตามตำแหน่ง executable ไม่ต้องสนใจ working directory
   - เส้นทาง remote ใช้ absolute path

## การแก้ไขปัญหา

### ปัญหาที่พบบ่อย

1. **เชื่อมต่อหมดเวลา**

   ```
   เชื่อมต่อเซิร์ฟเวอร์ SSH ไม่สำเร็จ: dial tcp: i/o timeout
   ```

   - ตรวจสอบที่อยู่และพอร์ตของเซิร์ฟเวอร์
   - ตรวจสอบการเชื่อมต่อเครือข่าย
   - ตรวจสอบการตั้งค่า firewall
2. **ยืนยันตัวตนล้มเหลว**

   ```
   ล็อกอินล้มเหลว: ssh: handshake failed
   ```

   - ตรวจสอบชื่อผู้ใช้และรหัสผ่าน
   - ตรวจสอบว่า SSH service ทำงานอยู่
   - ตรวจสอบการตั้งค่า SSH
3. **สิทธิ์ไม่เพียงพอ**

   ```
   สร้างไดเรกทอรีล้มเหลว: permission denied
   ```

   - ตรวจสอบสิทธิ์การเขียนของผู้ใช้ในไดเรกทอรีเป้าหมาย
   - อาจต้องใช้ sudo หรือเปลี่ยนเจ้าของไดเรกทอรี
4. **ไม่มีไดเรกทอรี local**

   ```
   ข้อผิดพลาด: ไดเรกทอรี local /path/to/unpackage/dist/build/web ไม่พบ
   ```

   - ตรวจสอบว่า build local เสร็จสิ้นแล้ว
   - ตรวจสอบโครงสร้างไดเรกทอรีโครงการให้ถูกต้อง
   - โปรแกรมจะคำนวณ path อัตโนมัติ ไม่ต้องแก้ไข working directory เอง

## คำแนะนำสำหรับนักพัฒนา

### โครงสร้างโปรเจกต์

```
go-deploy/
├── main.go                 # ไฟล์โปรแกรมหลัก
├── go.mod                  # ไฟล์ Go module  
├── go.sum                  # ไฟล์ตรวจสอบ dependencies
```
├── README.md               # เอกสารคำอธิบายรายละเอียด  
├── Makefile                # เครื่องมือสำหรับการ build  
├── build.sh                # สคริปต์สำหรับแพ็คเกจแบบกลุ่ม  
├── install.sh              # สคริปต์ติดตั้งแบบคลิกเดียว  
└── config.example.json     # ตัวอย่างไฟล์คอนฟิก  
```

### ฟังก์ชันหลัก

- `main()` - ฟังก์ชันหลัก จัดการการเชื่อมต่อและเรียกใช้อัปโหลด
- `uploadDirectory()` - อัปโหลดไดเรกทอรีแบบ recursive
- `uploadFile()` - อัปโหลดไฟล์เดี่ยว
- `mkdirAll()` - สร้างไดเรกทอรีระยะไกลแบบ recursive

## ใบอนุญาต

MIT License

## การมีส่วนร่วม

ยินดีต้อนรับการส่ง Issue และ Pull Request!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-19

---