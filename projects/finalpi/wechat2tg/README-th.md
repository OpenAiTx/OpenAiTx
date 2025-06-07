# wechat2tg-mac

บนพื้นฐานของโปรโตคอล WeChat Mac สำหรับส่งและรับข้อความ WeChat บน Telegram, wx2tg-server ฝั่งเซิร์ฟเวอร์ไม่ได้เปิดซอร์สด้วยเหตุผลด้านความปลอดภัย

## กลุ่ม TG: [@Wx2TgUserGroup](https://t.me/+AD02MEZa-og3ZGY1)

## ฟีเจอร์หลัก

1. รับข้อความแชทเดี่ยวของ WeChat, ข้อความกลุ่ม WeChat, ข้อความ Official Account, รับข้อความ WeCom (WeChat Work)
2. ส่งข้อความจาก Telegram ไปยังผู้ใช้ WeChat, กลุ่ม WeChat, Official Account ที่ระบุ
3. บล็อกข้อความจากกลุ่มที่ระบุ

## ประเภทข้อความที่รองรับ

### รายการประเภทข้อความ WeChat ที่รองรับ

+ [x] ข้อความตัวอักษร
+ [x] ข้อความ WeCom (WeChat Work)
+ [x] สติ๊กเกอร์ WeChat
+ [x] ข้อความรูปภาพ
+ [x] ข้อความวิดีโอ
+ [x] การโทรด้วยเสียง/วิดีโอ (แจ้งเตือนเท่านั้น)
+ [x] ข้อความไฟล์
+ [x] ข้อความลิงก์
+ [x] ข้อความกลุ่ม
+ [x] ข้อความกลุ่ม @ (ทั้ง @ทุกคน และ @คุณ จะถูกแปลงเป็น Telegram @คุณ)
+ [x] ข้อความ Official Account
+ [x] emoji
+ [x] ข้อความตำแหน่ง
+ [x] ข้อความยกเลิก (Recall)
+ [x] ข้อความเสียง
+ [ ] ข้อความอั่งเปา (แจ้งเตือน, ไม่สามารถอ่านเนื้อหาอั่งเปาได้)
+ [ ] ข้อความ Mini Program

### รายการประเภทข้อความ Telegram ที่รองรับ

+ [x] ข้อความตัวอักษร
+ [x] สติ๊กเกอร์
+ [x] ข้อความรูปภาพ
+ [x] ข้อความวิดีโอ
+ [x] ข้อความไฟล์
+ [x] ข้อความเสียง

## หมายเหตุ

1. โปรเจกต์นี้ใช้เพื่อการวิจัยทางเทคนิคและการเรียนรู้เท่านั้น ห้ามนำไปใช้ในทางที่ผิดกฎหมาย
2. ไม่ว่าพบปัญหาใด สามารถส่ง issue ได้เสมอ

## การติดตั้งและดีพลอย

คัดลอก `.env.example` เป็นไฟล์ `.env` แล้วตั้งค่าตัวแปรแวดล้อมในไฟล์ `.env`

คัดลอก `app.conf.example` ในโปรเจกต์เป็นไฟล์ `app.conf` ไปยังโฟลเดอร์ `conf` ตั้งค่า Redis เป็นที่อยู่ Redis ที่คุณดีพลอย

### docker-compose

สร้างไฟล์ `docker-compose.yml`:

```yaml
version: '3'

services:
  wx2tg-mac:
    image: finalpi/wechat2tg-mac:latest
    container_name: wx2tg-mac
    volumes:
      - ./config:/app/storage
      - ./save-files:/app/save-files # หลังจาก mount โฟลเดอร์นี้แล้ว ไฟล์สติ๊กเกอร์ไม่ต้องแปลงใหม่
    env_file: ".env"
    restart: unless-stopped

  wx2tg-server:
    image: finalpi/wx2tg-server:latest # ดึง image
    container_name: wx2tg-server
    ports:
      - "8058:8058"
    volumes:
      - ./conf:/usr/wic-go/conf
    restart: unless-stopped

  wx2tg-redis:
    image: redis:7.2
    container_name: wx2tg-redis
    ports:
      - "16379:6379"
    volumes:
      - ./redis-data:/data
    command: ["redis-server", "--appendonly", "yes"]
    restart: unless-stopped
```

#### การรัน

```shell
docker-compose up -d
```

#### ปิดโหมดความเป็นส่วนตัวของ bot

ปิดโหมดความเป็นส่วนตัวของบอท โดยเปิด BotFather พิมพ์ `/mybots` เลือกบอทของคุณ คลิก `Bot Settings` - `Group Privacy` - `Turn off`
เมื่อขึ้น `Privacy mode is disabled for xxx` แปลว่าปิดสำเร็จแล้ว

## คำแนะนำการใช้งาน

### คำสั่ง BOT

- `/login`：รับ QR Code สำหรับเข้าสู่ระบบ; ครั้งแรกที่ deploy และ start คนที่ส่ง `/login` ก่อนจะกลายเป็นเจ้าของ `BOT`

- `/flogin`：รับ QR Code สำหรับ File Transfer Assistant รองรับรับวิดีโอและไฟล์

- `/update`：อัปเดตข้อมูลรูปโปรไฟล์และชื่อกลุ่ม

- `/message`：เปิด/ปิดการรับข้อความกลุ่ม

- `/forward`：เปิด/ปิดการส่งต่อข้อความจากสมาชิกคนอื่นหรือบอทในกลุ่ม

- `/user`：รับรายชื่อผู้ใช้ WeChat; กดปุ่มเพื่อสร้างกลุ่มใหม่หรือผูกผู้ใช้ (ค้นหาได้ด้วยชื่อหรือหมายเหตุ เช่น `/user 张` เพื่อค้นหาผู้ใช้ WeChat ที่มี "张")

- `/room`：รับรายชื่อกลุ่ม WeChat; กดปุ่มเพื่อสร้างกลุ่มใหม่หรือผูกกลุ่ม WeChat (ค้นหาได้ด้วยชื่อหรือหมายเหตุ เช่น `/room 外卖` เพื่อค้นหากลุ่ม WeChat ที่มี "外卖")

- `/settings`：ตั้งค่าซอฟต์แวร์

- `/unbind`：ยกเลิกการเชื่อมโยงกลุ่ม WeChat หรือผู้ใช้ WeChat (ใช้ได้ในกลุ่มเท่านั้น)

### คำอธิบายตัวแปรแวดล้อม

|ชื่อ| ต้องกรอก | คำอธิบาย                                                             |
|--|------|----------------------------------------------------------------|
|`BOT_TOKEN`| ใช่    | token ของ Telegram Bot สร้างโดย [BotFather](https://t.me/BotFather) |
|`API_ID`| ใช่    | API ID ของ Telegram API                                          |
|`API_HASH`| ใช่    | API HASH ของ Telegram API                                        |
|`BASE_API`| ใช่    | URL API ที่ wx2tg-server container ใช้งาน ต้องใส่ path แบบเต็ม                            |
|`PROXY_PROTOCOL`| ไม่จำเป็น    | ประเภท proxy เลือกได้ (socks5,http,https)                                     |
|`PROXY_HOST`| ไม่จำเป็น    | URL ของ proxy                                                        |
|`PROXY_PORT`| ไม่จำเป็น    | พอร์ต proxy                                                         |
|`PROXY_USERNAME`| ไม่จำเป็น    | ชื่อผู้ใช้ proxy                                                         |
|`PROXY_PASSWORD`| ไม่จำเป็น    | รหัสผ่าน proxy                                                          |
|`ROOM_MESSAGE`| ไม่จำเป็น    | รูปแบบการแสดงข้อความกลุ่ม WeChat ใน BOT                                              |
|`OFFICIAL_MESSAGE`| ไม่จำเป็น    | รูปแบบการแสดงข้อความ Official Account ใน BOT                                              |
|`CONTACT_MESSAGE`| ไม่จำเป็น    | รูปแบบการแสดงข้อความผู้ใช้ WeChat ใน BOT                                             |
|`ROOM_MESSAGE_GROUP`| ไม่จำเป็น    | รูปแบบการแสดงข้อความกลุ่ม WeChat ในกลุ่ม Telegram                                                 |
|`CONTACT_MESSAGE_GROUP`| ไม่จำเป็น    | รูปแบบการแสดงข้อความผู้ใช้ WeChat ในกลุ่ม Telegram                                                |
|`OFFICIAL_MESSAGE_GROUP`| ไม่จำเป็น    | รูปแบบการแสดงข้อความ Official Account ในกลุ่ม Telegram                                                 |
|`CREATE_ROOM_NAME`| ไม่จำเป็น    | รูปแบบชื่อกลุ่มเมื่อสร้างกลุ่ม WeChat อัตโนมัติ                                           |
|`CREATE_CONTACT_NAME`| ไม่จำเป็น    | รูปแบบชื่อกลุ่มเมื่อสร้างกลุ่มผู้ใช้ WeChat อัตโนมัติ                                         |
|`MESSAGE_DISPLAY`| ไม่จำเป็น    | รูปแบบการแสดงข้อความตัวอักษร                                                      |

 ---

### คำอธิบายคำสั่ง `/settings`

1.แสดง emoji WeChat เป็นลิงก์ภาพ: หากเปิดจะเปลี่ยนอีโมจิ WeChat (เหลือง) เป็นลิงก์รูปภาพ

1.ซิงค์ข้อมูลกลุ่มตอนเริ่มโปรแกรม: หากเปิดจะซิงค์ข้อมูลสมาชิกทั้งหมดตอนโปรแกรมเริ่ม (อัปเดตโปรไฟล์กลุ่มและชื่อ)

---

### แปลงเสียงเป็นข้อความ

1. ตั้งค่า `TENCENT_SECRET_ID` และ `TENCENT_SECRET_KEY` สามารถสมัครได้ที่ [Tencent Speech Recognition Console](https://console.cloud.tencent.com/asr)
   มีโควต้าฟรี
2. เปิดใช้งานแปลงเสียงเป็นข้อความอัตโนมัติใน `/settings`

---

### วิธีรับ `API_ID` และ `API_HASH`

1. ล็อกอิน [telegram account](https://my.telegram.org/)

2. คลิก "API development tools" แล้วกรอกรายละเอียดแอป (ใส่แค่ชื่อแอปและชื่อย่อก็พอ)

3. สุดท้ายคลิก "Create application"

---

### กำหนดรูปแบบข้อความเอง

หากต้องการแก้ไขรูปแบบผู้ส่งข้อความ ให้แก้ไขตัวแปรแวดล้อมใน docker หรือไฟล์ `.env`

Placeholder สำหรับกำหนดรูปแบบข้อความ:

`#[alias]`：หมายเหตุของผู้ติดต่อ

`#[name]`：ชื่อเล่นของผู้ติดต่อ

`#[topic]`：ชื่อกลุ่มแชท

`#[alias_first]`：แสดงหมายเหตุก่อน, ถ้าไม่มีจะใช้ชื่อเล่น

`#[identity]`：ข้อความระบุสถานะ

`#[body]`：เนื้อหาข้อความ

`#[br]`：ขึ้นบรรทัดใหม่

### วิธี @ทุกคน

ส่งข้อความที่ขึ้นต้นด้วย `@all` จะ @ทุกคน (รองรับเฉพาะข้อความตัวอักษร)

---

## คำถามที่พบบ่อย


## การร่วมพัฒนา

1. fork โปรเจกต์ สลับไปที่ branch `wx2tg-mac-dev` หรือสร้าง branch ใหม่ ห้าม commit ตรงไปยัง main
2. ส่ง Pull Request ไปที่ branch `wx2tg-mac-dev`


## License

[MIT](LICENSE)


## ขอบคุณ

ขอขอบคุณ Jetbrains สำหรับการสนับสนุนโปรเจกต์นี้

[<img src="https://resources.jetbrains.com/storage/products/company/brand/logos/jetbrains.png" width="200">](https://www.jetbrains.com)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---