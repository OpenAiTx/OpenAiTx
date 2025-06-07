<div align="center">
  <h1>Lampo</h1>

  <img src="https://github.com/saradurante/lampo.docs/blob/dc0dce971c3052f0e9dd668fdf0c7376b12fee7b/imgs/web/icon-512.png?raw=true"  width="150" height="150" />


  <p>
    <strong>การพัฒนาเครือข่าย Lightning ที่รวดเร็วและเป็นโมดูลสำหรับการใช้งานทุกรูปแบบ เขียนด้วยภาษา Rust</strong>
  </p>

  <h4>
    <a href="https://lampo.devcrew.cc">โฮมเพจโครงการ</a>
  </h4>
</div>

## Crates

นี่คือรายการ crates ทั้งหมดที่รองรับในขณะนี้:

| Crate       | คำอธิบาย                                   | เวอร์ชัน     |
|:------------|:--------------------------------------------:|------------:|
| lampod-cli  | อินเทอร์เฟซบรรทัดคำสั่ง Lampo Daemon สำหรับรัน daemon | _unrelated_ |
| lampo-cli   | อินเทอร์เฟซบรรทัดคำสั่ง Lampo แบบง่ายสำหรับโต้ตอบกับ daemon | _unrelated_ |

## วิธีการติดตั้ง

เพื่อที่จะติดตั้งทุกความต้องการและไบนารี Lampo คุณจำเป็นต้องติดตั้ง rust และจากนั้นรันคำสั่งต่อไปนี้:

```
make install
```

หลังจากที่คุณมี `lampod-cli` และ `lampo-cli` พร้อมใช้งานแล้ว คุณสามารถรันคำสั่งต่อไปนี้เพื่อเปิด Lampo ในโหมด signet:

```
➜  ~ lampod-cli --network signet
✓ Wallet Generated, please store these words in a safe way
 wallet-keys  maple have fitness decide food joy flame coast stereo front grab stumble
```

>[!NOTE]
โปรดเก็บคำของกระเป๋าสตางค์ของคุณไว้ และใช้มันเพื่อกู้คืนกระเป๋าด้วย `--restore-wallet`
หากคุณไม่เก็บคำไว้ที่ไหนเลย เงินของคุณจะสูญหายเมื่อ Lampo เริ่มต้นครั้งต่อไป!

โปรดทราบว่าคุณต้องมีไฟล์ `lampo.conf` ในพาธ `~/.lampo/signet` ให้รันคำสั่งต่อไปนี้เพื่อใช้ไฟล์ config ตัวอย่าง:

```
cp lampo.example.conf ~/.lampo/signet/lampo.conf
```

จากนั้นคุณสามารถสั่งสอบถาม node ด้วยคำสั่งต่อไปนี้:

``` 
➜  ~ lampo-cli --network signet getinfo
{
  "node_id": "035b889551a44e502cd0cd6657acf067336034986cd6639b222cd4be563a7fc205",
  "peers": 0,
  "channels": 0
}
```

### การรันทดสอบแบบผสานกับ core lightning:

ตรวจสอบให้แน่ใจว่าคุณได้คอมไพล์ core-lightning ในโหมด developer แล้ว คู่มือการติดตั้งสามารถดูได้ที่ [ที่นี่](https://docs.corelightning.org/docs/installation)

สามารถรันทดสอบแบบผสานได้ด้วยคำสั่งต่อไปนี้:

```
make integration
```

## แนวทางการมีส่วนร่วม

โปรดอ่าน [คู่มือการมีส่วนร่วม](https://raw.githubusercontent.com/vincenzopalazzo/lampo.rs/main/CONTRIBUTING.md) ของเรา

## ชุมชน

เพื่อคงไว้ซึ่งความชัดเจน เราได้เลือกช่องทางการสื่อสารเฉพาะดังนี้:
- นักพัฒนา เข้าร่วมกับเราที่ [Zulip](https://lampo-dev.zulipchat.com/)
- สมาชิกชุมชน ร่วมแบ่งปันข้อคิดเห็นใน [Twitter community](https://twitter.com/i/communities/1736414802849706087)
- สำหรับคำถามด้านเทคนิคและข้อเสนอแนะฟีเจอร์ โปรดเข้าร่วมพูดคุยใน GitHub discussions ของเรา

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---