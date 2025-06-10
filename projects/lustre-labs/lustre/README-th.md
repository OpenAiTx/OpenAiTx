<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>ทำให้ส่วนหน้าของคุณโดดเด่น</strong> ✨
</div>

<div align="center">
  เฟรมเวิร์กสำหรับสร้าง Web apps ด้วย Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="มีให้ใช้งานบน Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="เอกสารประกอบ" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      เว็บไซต์
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      เริ่มต้นอย่างรวดเร็ว
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      อ้างอิง
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>สร้างด้วย ❤︎ โดย
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> และ
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    ผู้ร่วมพัฒนา
  </a>
</div>

---

## สารบัญ

- [คุณสมบัติ](#features)
- [ตัวอย่าง](#example)
- [ปรัชญา](#philosophy)
- [การติดตั้ง](#installation)
- [ต่อไปที่ไหน](#where-next)
- [ซัพพอร์ต](#support)

## คุณสมบัติ {#features}

- API แบบ **ประกาศค่า** (declarative) และฟังก์ชันนัลสำหรับสร้าง HTML ไม่มีเทมเพลต ไม่มีแมโคร
  ใช้ Gleam ล้วน ๆ

- สถาปัตยกรรมที่ได้แรงบันดาลใจจาก Erlang และ Elm สำหรับ **จัดการสถานะ**

- **จัดการผลข้างเคียง** อย่างมีประสิทธิภาพ โค้ดสามารถคาดเดาและทดสอบได้

- คอมโพเนนต์แบบสากล **เขียนครั้งเดียว ใช้ได้ทุกที่** Elm ผสมผสานกับ Phoenix LiveView

- **CLI ที่มาพร้อมเครื่อง** ทำให้การสร้างโครงและสร้างแอปเป็นเรื่องง่าย

- **เรนเดอร์ฝั่งเซิร์ฟเวอร์** สำหรับเทมเพลต HTML แบบ static

## ตัวอย่าง {#example}

Lustre มาพร้อมกับ [ตัวอย่างมากกว่า 20 ตัวอย่าง](https://hexdocs.pm/lustre/reference/examples.html)!
ตัวอย่างเช่น:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## ปรัชญา {#philosophy}

Lustre เป็นเฟรมเวิร์ก _ที่มีความชัดเจนในแนวคิด_ สำหรับสร้าง Web Application ขนาดเล็กถึงกลาง การพัฒนา frontend สมัยใหม่มีความยากและซับซ้อน บางส่วนของความซับซ้อนนั้นเป็นสิ่งจำเป็น แต่หลาย ๆ อย่างเป็นความซับซ้อนโดยบังเอิญ หรือเกิดจากการมีทางเลือกมากเกินไป Lustre ยึดหลักการออกแบบเดียวกับ Gleam: ถ้าเป็นไปได้ ควรมีวิธีเดียวในการทำสิ่งต่าง ๆ

นั่นหมายถึง Lustre มาพร้อมระบบจัดการสถานะตัวเดียวจากกล่อง โดยยึดตามรูปแบบของ Elm และ Erlang/OTP เปิดแอปพลิเคชัน Lustre อันไหน คุณก็ควรจะรู้สึกเหมือนอยู่บ้าน

นอกจากนี้ เรายังส่งเสริมแนวทางการสร้างมุมมอง (view) แบบง่าย ๆ มากกว่าการสร้างที่ซับซ้อน Lustre _มี_ วิธีสร้างคอมโพเนนต์ที่มีสถานะในตัว (stateful component) (ซึ่งเป็นสิ่งที่เราคิดถึงใน Elm) แต่ไม่ควรเป็นค่าเริ่มต้น ควรเลือกใช้ฟังก์ชันธรรมดามากกว่าคอมโพเนนต์ที่มีสถานะ

ในกรณีที่จำเป็นต้องใช้คอมโพเนนต์ ให้ใช้ข้อได้เปรียบที่คอมโพเนนต์ของ Lustre สามารถ
รัน _ได้ทุกที่_ Lustre ให้เครื่องมือสำหรับเขียนคอมโพเนนต์ที่รันได้ทั้งภายในแอป Lustre ที่มีอยู่ เดินทางไปเป็น Web Component แบบสแตนด์อโลน หรือรันบนฝั่งเซิร์ฟเวอร์ด้วย runtime ขนาดเล็กสำหรับ patching DOM Lustre เรียกสิ่งนี้ว่า
**คอมโพเนนต์สากล** ซึ่งถูกเขียนโดยคำนึงถึงเป้าหมายหลายรูปแบบของ Gleam

## การติดตั้ง {#installation}

Lustre ถูกเผยแพร่บน [Hex](https://hex.pm/packages/lustre)! คุณสามารถเพิ่มเข้าไปในโปรเจกต์ Gleam ของคุณได้จากบรรทัดคำสั่ง:

```sh
gleam add lustre
```

Lustre ยังมีแพ็กเกจเสริมสำหรับเครื่องมือพัฒนา ที่คุณอาจต้องการติดตั้ง:

> **หมายเหตุ**: เซิร์ฟเวอร์ lustre_dev_tools สำหรับการพัฒนาจะตรวจสอบไฟล์ในระบบของคุณ
> หากมีการเปลี่ยนแปลงในโค้ด gleam จะรีโหลดเบราว์เซอร์ให้อัตโนมัติ สำหรับผู้ใช้ linux จำเป็นต้องติดตั้ง [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## ต่อไปที่ไหน {#where-next}

เพื่อเริ่มต้นใช้งาน Lustre อย่างรวดเร็ว โปรดดู [คู่มือเริ่มต้นอย่างรวดเร็ว](https://hexdocs.pm/lustre/guide/01-quickstart.html)
หากคุณอยากดูตัวอย่างโค้ด [โฟลเดอร์ตัวอย่าง](https://github.com/lustre-labs/lustre/tree/main/examples)
มีแอปขนาดเล็กหลายแอปที่แสดงแง่มุมต่าง ๆ ของเฟรมเวิร์กนี้

คุณยังสามารถอ่านเอกสารประกอบและอ้างอิง API ได้ที่
[HexDocs](https://hexdocs.pm/lustre)

## ซัพพอร์ต {#support}

Lustre ส่วนใหญ่ถูกพัฒนาโดยฉันคนเดียว [Hayleigh](https://github.com/hayleigh-dot-dev)
ควบคู่กับงานอีกสองที่ หากคุณต้องการสนับสนุนงานของฉัน คุณสามารถ [เป็นสปอนเซอร์ฉันบน GitHub](https://github.com/sponsors/hayleigh-dot-dev)

ยินดีต้อนรับการมีส่วนร่วม! หากคุณพบข้อบกพร่อง หรืออยากเสนอคุณสมบัติใหม่ กรุณาเปิด issue หรือ pull request

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---