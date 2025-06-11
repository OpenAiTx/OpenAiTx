# การทำคอนเทนเนอร์ไรเซชัน

แพ็กเกจ Containerization ช่วยให้อุปกรณ์แอปพลิเคชันสามารถใช้คอนเทนเนอร์ Linux ได้  
Containerization เขียนด้วย [Swift](https://www.swift.org) และใช้ [Virtualization.framework](https://developer.apple.com/documentation/virtualization) บน Apple silicon

Containerization มี API เพื่อ:

- [จัดการภาพ OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/)  
- [โต้ตอบกับรีจิสตรีระยะไกล](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/)  
- [สร้างและเติมระบบไฟล์ ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/)  
- [โต้ตอบกับครอบครัวซ็อกเก็ต Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/)  
- [สร้างเคอร์เนล Linux ที่ปรับแต่งเพื่อบูตได้เร็ว](https://raw.githubusercontent.com/apple/containerization/main/kernel/)  
- [สร้างเครื่องเสมือนน้ำหนักเบาและจัดการสภาพแวดล้อมรันไทม์](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift)  
- [สร้างและโต้ตอบกับกระบวนการภายในคอนเทนเนอร์](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift)  
- ใช้ Rosetta 2 สำหรับรันคอนเทนเนอร์ linux/amd64 บน Apple silicon

โปรดดู [เอกสาร API](https://apple.github.io/containerization/documentation/) สำหรับข้อมูลเกี่ยวกับแพ็กเกจ Swift ที่ Containerization มีให้

## การออกแบบ

Containerization รันคอนเทนเนอร์ Linux แต่ละตัวภายในเครื่องเสมือนน้ำหนักเบาของตัวเอง ลูกค้าสามารถสร้างที่อยู่ IP เฉพาะสำหรับแต่ละคอนเทนเนอร์เพื่อลดความจำเป็นในการส่งต่อพอร์ตแยกต่างหาก คอนเทนเนอร์สามารถเริ่มทำงานได้ภายในเวลาต่ำกว่าหนึ่งวินาทีโดยใช้ [การกำหนดค่าเคอร์เนล Linux ที่ปรับแต่ง](https://raw.githubusercontent.com/apple/containerization/main/kernel) และระบบไฟล์รูทที่มีขนาดเล็กพร้อมระบบ init น้ำหนักเบา

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) คือระบบ init ขนาดเล็ก ซึ่งเป็นโครงการย่อยภายใน Containerization  
`vminitd` จะถูกสร้างขึ้นเป็นกระบวนการเริ่มต้นภายในเครื่องเสมือนและให้ API GRPC ผ่าน vsock  
API นี้ช่วยให้สามารถกำหนดค่าสภาพแวดล้อมรันไทม์และเปิดตัวกระบวนการในคอนเทนเนอร์ได้  
`vminitd` ให้บริการ I/O, สัญญาณ และเหตุการณ์ไปยังกระบวนการที่เรียกใช้เมื่อมีการรันกระบวนการ

## ความต้องการ

คุณต้องมี Mac ที่ใช้ Apple silicon เพื่อสร้างและรัน Containerization

ในการสร้างแพ็กเกจ Containerization ระบบของคุณต้องมีอย่างใดอย่างหนึ่ง:

- macOS 15 หรือใหม่กว่า และ Xcode 26 beta  
- macOS 26 beta หรือใหม่กว่า

แอปพลิเคชันที่สร้างด้วยแพ็กเกจนี้จะรันบน macOS 15 ขึ้นไป แต่คุณสมบัติดังต่อไปนี้จะไม่สามารถใช้งานได้บน macOS 15:

- เครือข่ายคอนเทนเนอร์ที่ไม่แยกส่วน - บน macOS 15 คอนเทนเนอร์ที่อยู่บนเครือข่าย vmnet เดียวกันไม่สามารถสื่อสารกันได้

## ตัวอย่างการใช้งาน

สำหรับตัวอย่างวิธีการใช้งานไลบรารีต่าง ๆ เครื่องมือ cctl เป็นจุดเริ่มต้นที่ดี เครื่องมือนี้ทำหน้าที่เป็นสนามเล่นเพื่อทดสอบ API โดยมีคำสั่งที่ทดสอบฟังก์ชันหลักของผลิตภัณฑ์ต่าง ๆ เช่น:

1. [จัดการภาพ OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [ล็อกอินไปยังรีจิสตรีคอนเทนเนอร์](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [สร้างบล็อกระบบไฟล์รูท](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [รันคอนเทนเนอร์ Linux ง่าย ๆ](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## เคอร์เนล Linux

เคอร์เนล Linux จำเป็นสำหรับการสร้างเครื่องเสมือนน้ำหนักเบาบน macOS  
Containerization ให้การกำหนดค่าเคอร์เนลที่ปรับแต่งไว้ในไดเร็กทอรี [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel)

ไดเร็กทอรีนี้รวมสภาพแวดล้อมการสร้างที่คอนเทนเนอร์เพื่อช่วยให้คอมไพล์เคอร์เนลสำหรับใช้กับ Containerization ได้ง่ายขึ้น

การกำหนดค่าเคอร์เนลนี้มีฟีเจอร์ขั้นต่ำเพื่อสนับสนุนเวลาบูตที่รวดเร็วและสภาพแวดล้อมที่เบา

แม้ว่าการกำหนดค่านี้จะเหมาะกับงานส่วนใหญ่ แต่เราก็เข้าใจว่าบางงานอาจต้องการฟีเจอร์เพิ่มเติม  
เพื่อแก้ปัญหานี้ Containerization มี API ชั้นหนึ่งเพื่อใช้การกำหนดค่าและเวอร์ชันเคอร์เนลที่แตกต่างกันในแต่ละคอนเทนเนอร์  
สิ่งนี้ช่วยให้สามารถพัฒนาและทดสอบคอนเทนเนอร์ข้ามเวอร์ชันเคอร์เนลต่าง ๆ ได้

ดู [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) ในไดเร็กทอรี kernel สำหรับคำแนะนำการคอมไพล์เคอร์เนลที่ปรับแต่งแล้ว

### เคอร์เนลที่คอมไพล์ไว้ล่วงหน้า

หากคุณต้องการใช้เคอร์เนลที่คอมไพล์ไว้ล่วงหน้า เคอร์เนลนั้นต้องมีไดรเวอร์ `VIRTIO` คอมไพล์เข้าไปในเคอร์เนล ไม่ใช่ในรูปแบบโมดูล

โครงการ [Kata Containers](https://github.com/kata-containers/kata-containers) มีเคอร์เนลที่ปรับแต่งสำหรับคอนเทนเนอร์ที่เปิดใช้งานตัวเลือกการกำหนดค่าที่จำเป็นทั้งหมด ซึ่งให้บริการบนหน้า [releases](https://github.com/kata-containers/kata-containers/releases/)

อิมเมจเคอร์เนลชื่อ `vmlinux.container` สามารถพบได้ในไดเร็กทอรี `/opt/kata/share/kata-containers/` ของไฟล์ปล่อย

## เตรียมตัวสร้างแพ็กเกจ

ติดตั้ง Swiftly, [Swift](https://www.swift.org), และ [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

ถ้าคุณใช้แอปเทอร์มินัลแบบกำหนดเอง คุณอาจต้องย้ายคำสั่งนี้จาก `.zprofile` ไปยัง `.zshrc` (เปลี่ยน `<USERNAME>`):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

รีสตาร์ทแอปเทอร์มินัล ตรวจสอบให้แน่ใจว่าคำสั่งนี้คืนค่า `/Users/<USERNAME>/.swiftly/bin/swift` (เปลี่ยน `<USERNAME>`):

```bash
which swift
```

ถ้าคุณเคยติดตั้งหรือใช้ Static Linux SDK มาก่อน อาจต้องลบ SDK เวอร์ชันเก่าออกจากระบบ (เปลี่ยน `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## สร้างแพ็กเกจ

สร้าง Containerization จากซอร์ส:

```bash
make all
```

## ทดสอบแพ็กเกจ

หลังจากสร้างแล้ว ให้รันการทดสอบพื้นฐานและการทดสอบแบบบูรณาการ:

```bash
make test integration
```

ต้องมีเคอร์เนลเพื่อรันทดสอบแบบบูรณาการ  
ถ้าคุณไม่มีเคอร์เนลในเครื่อง สามารถดึงเคอร์เนลเริ่มต้นได้โดยใช้คำสั่ง `make fetch-default-kernel`

การดึงเคอร์เนลเริ่มต้นต้องทำเพียงครั้งเดียวหลังการสร้างครั้งแรกหรือหลังใช้คำสั่ง `make clean`

```bash
make fetch-default-kernel
make all test integration
```

## Protobufs

Containerization พึ่งพาเวอร์ชันเฉพาะของ `grpc-swift` และ `swift-protobuf` คุณสามารถติดตั้งและสร้างอินเทอร์เฟซ RPC ใหม่ได้ด้วยคำสั่ง:

```bash
make protos
```

## เอกสาร

สร้างเอกสาร API สำหรับดูในเครื่องด้วยคำสั่ง:

```bash
make docs
make serve-docs
```

ดูตัวอย่างเอกสารโดยรันในเทอร์มินัลอีกหน้าหนึ่ง:

```bash
open http://localhost:8000/documentation/
```

## การร่วมพัฒนา

ยินดีและสนับสนุนให้ร่วมพัฒนา Containerization โปรดดู [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) สำหรับข้อมูลเพิ่มเติม

## สถานะโครงการ

เวอร์ชัน 0.1.0 เป็นรุ่นทางการครั้งแรกของ Containerization เวอร์ชันก่อนหน้านี้ไม่รับประกันความเสถียรของซอร์สโค้ด

เนื่องจากไลบรารี Containerization อยู่ในระหว่างการพัฒนาอย่างต่อเนื่อง ความเสถียรของซอร์สโค้ดจึงรับประกันเฉพาะในเวอร์ชันย่อย (เช่น ระหว่าง 0.1.1 ถึง 0.1.2) หากคุณไม่ต้องการการอัปเดตแพ็กเกจที่อาจทำลายซอร์สโค้ด คุณสามารถระบุการพึ่งพาแพ็กเกจโดยใช้ .upToNextMinorVersion(from: "0.1.0") แทน

เวอร์ชันย่อยในอนาคตของแพ็กเกจอาจมีการเปลี่ยนแปลงกฎเหล่านี้ตามความจำเป็น

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---