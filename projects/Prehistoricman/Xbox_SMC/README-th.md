
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=Prehistoricman&project=Xbox_SMC&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Xbox_SMC
ไฟล์ dump จาก PIC16/Xyclops ของ Xbox รุ่นแรก และฐานข้อมูล IDA พร้อมการ reverse engineering บางส่วน

![ภาพของ PIC16LC63A จาก Xbox รุ่นแรก](https://raw.githubusercontent.com/Prehistoricman/Xbox_SMC/master/pic16lc63a.jpg)

# การแฟลช Xyclops (XycloMod)
ดู [ไดเรกทอรีและ README ของ Xyclops](/Xyclops)

# ดัมพ์
ไฟล์ .bin สำหรับแต่ละ PIC dump มีการสลับไบต์เพื่อให้โหลดเข้า IDA ได้อย่างถูกต้อง ดังนั้น word แรกของหน่วยความจำ PIC คือ byte_0 + byte_1 << 8

ฐานข้อมูล .idb ของ IDA มีข้อมูลเกี่ยวกับตัวแปรและข้อสังเกตบางประการใน notepad ของฐานข้อมูล

ดูหน้านี้ในวิกิสำหรับการแบ่งเวอร์ชัน SMC: https://xboxdevwiki.net/Xboxen_Info

## B2A
ดัมพ์จาก Xbox DVT3 คำกำหนดค่าเดียวกับ P01 และมี device ID ที่ถูกเขียนไว้ในพื้นที่ config เป็น 0000 0000 000B 002A ซึ่งแตกต่างจาก PIC ผลิตจริง

ขาด boot challenge อย่างสมบูรณ์

## D01
ดัมพ์จาก XDK BETA 2 Xbox เหมือนกับ P01 ทุกประการ ยกเว้นไม่มี boot challenge ฟังก์ชันคำนวณการตอบสนอง boot challenge ยังคงอยู่ แต่ไม่ถูกเรียกใช้

## DXF
ดัมพ์จาก XDK D2 debug kit คล้ายกับ D01 แต่มีตรรกะถาด, ตรรกะร้อนเกิน และตรรกะบูตที่แตกต่างกันเล็กน้อย boot challenge ไม่มีเช่นเดียวกับ D01

## D2E
ดัมพ์จาก Tuscany (v1.6) dev kit ชิป Xyclops ระบุว่า X01202-001 และไม่มีเส้น A-A02 หรือ A-B01 ที่ยูนิตขายปลีกมี

รหัส serial debug ที่ FC00 ตรงกับดัมพ์ P2L แบบขายปลีก มีรูปแบบข้อมูลแปลก ๆ จาก 0x4000 ถึง 0xFBFF

## P01
ดัมพ์จาก Xbox v1.0 คำกำหนดค่าเป็น 0x86:
- CP1:CP0 = 0 (เปิดใช้ Code Protection สำหรับหน่วยความจำทั้งหมด)
- BODEN = 0 (ปิดใช้งาน Brown-out Reset)
- ~PWRTE = 0 (เปิดใช้งาน Power-up Timer)
- WDTE = 1 (เปิดใช้งาน Watchdog Timer)
- FOSC1:FOSC0 = 2 (ใช้ HS oscillator)

ค่ากำหนดค่า 0x3FB6 เหมาะสำหรับ SMC clone เพื่อไม่ให้เปิดใช้งาน code protection

## P11
ดัมพ์จาก Xbox v1.3 คำกำหนดค่าเดียวกับ P01

มีการเปลี่ยนแปลงเล็กน้อยใน P11 เมื่อเทียบกับ P01 รวมถึงคำสั่ง SMBus เพิ่มเติม (เขียน 0x22) ลำดับความสำคัญ LED ที่ต่างกัน และเวลาในการบูตที่ผ่อนคลายขึ้น

ฉันตรวจสอบดัมพ์ scrambled ของ v1.3 กับ v1.4 แล้วพบว่าเหมือนกัน หมายความว่ามีโปรแกรมเดียวกันอย่างแน่นอน

## P2L
ดัมพ์มาจาก Xbox v1.6 รุ่น Xyclops A-A02 ซึ่งมีโค้ด Intel 8051 แต่มีรีจิสเตอร์ฟังก์ชันพิเศษจำนวนมากที่ยังไม่ทราบการทำงาน

พอร์ตอนุกรมดีบักนั้นใช้โค้ดที่ FC00 ดูเหมือนดีบักเกอร์แบบง่ายที่สามารถหยุดการทำงาน ดัมพ์ข้อมูล และเขียนรีจิสเตอร์/RAM ได้

# การดัมพ์ Xyclops

ชิป Xyclops มีขา 'debug' 3 ขา คือ TXD (ขา 64), RXD (ขา 63), และ DEBUG (ขา 29) ตั้งค่าขา DEBUG เป็นสูงเพื่อเปิดใช้งานพอร์ตอนุกรมบนขา TX และ RX โดยอนุกรมจะทำงานที่ 9600 baud

โปรโตคอลจะใช้คำสั่ง 4 ไบต์ซึ่งโดยปกติจะมีรูปแบบ `<cmd>` `<address MSByte>` `<address LSByte>` `<don't care>`

คำสั่ง 0x14 จะดัมพ์ข้อมูล BIOS ทีละ 64 ไบต์ และ 0x15 จะดัมพ์ข้อมูลโปรแกรม SMC ทีละ 64 ไบต์ ไฟล์ดัมพ์จาก Xyclops คือ P2L.bin รวมอยู่ใน repo แล้ว [xyclops_dumper.py](/Xyclops/xyclops_dumper.py) ก็รวมไว้สำหรับให้คุณดัมพ์เครื่องของคุณเองด้วย

# วิธีการดัมพ์ PIC
รายละเอียดเต็มที่ https://wiki.recessim.com/view/PIC_Burnout

PIC เปิดการป้องกันโค้ดไว้ ทำให้ข้อมูลทั้งหมดอ่านเป็น 0000 ฉันใช้เทคนิคบางอย่างเพื่อให้ได้ข้อมูลแบบ scrambled แทน ค้นพบอัลกอริทึม scrambling โดยใช้ชิปสังเวย แล้วใช้ exploit เพื่อเปลี่ยนข้อมูล ROM ให้บิตบางตัวกลายเป็นค่าที่ทราบแน่ จากนั้นจึงสกัดข้อมูลที่ต้องการจากหลายๆ ดัมพ์ scrambled เพื่อสร้างข้อมูลต้นฉบับขึ้นมาใหม่

# PICProgrammer
PICProgrammer เป็นหนึ่งในโปรเจกต์ Arduino สำหรับ RP2040 ที่ฉันใช้ในการวิจัย มันให้ส่วนติดต่อบรรทัดคำสั่งง่ายๆ สำหรับดำเนินการ ICSP (in-circuit serial programming) บน PIC ซึ่งจะนิยมใช้มากกว่าตัวโปรแกรมเมอร์เฉพาะทางเช่น PICkit เพราะความยืดหยุ่นและความสามารถในการทำสิ่งที่ผู้ผลิตไม่ได้ตั้งใจให้ทำ

คุณควรมีความเข้าใจเรื่องอิเล็กทรอนิกส์และการเขียนโปรแกรมก่อนใช้งาน และควรตรวจสอบการทำงานของแต่ละคำสั่งก่อนดำเนินการ


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-20

---