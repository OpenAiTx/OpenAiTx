# MoneyPrinter 💸

> ♥︎ ผู้สนับสนุน: แอปแชท AI ที่ดีที่สุด: [shiori.ai](https://www.shiori.ai)
---

> 𝕏 ติดตามฉันบน X ได้ที่: [@DevBySami](https://x.com/DevBySami).

ทำให้การสร้าง YouTube Shorts เป็นเรื่องอัตโนมัติ เพียงแค่ระบุหัวข้อวิดีโอที่ต้องการพูดถึง

<a href="https://trendshift.io/repositories/7545" target="_blank"><img src="https://trendshift.io/api/badge/repositories/7545" alt="FujiwaraChoki%2FMoneyPrinter | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/></a>

> **สำคัญ** กรุณาตรวจสอบปัญหาที่มีอยู่หรือปิดไปแล้วก่อนเปิดประเด็นใหม่ หากเป็นแค่คำถาม กรุณาเข้าร่วม [discord](https://dsc.gg/fuji-community) และถามในนั้น

> **🎥** รับชมวิดีโอบน [YouTube](https://youtu.be/mkZsaDA2JnA?si=pNne3MnluRVkWQbE)

ดูคำแนะนำสำหรับเวอร์ชันใช้งานในเครื่อง [ที่นี่](https://raw.githubusercontent.com/FujiwaraChoki/MoneyPrinter/main/Local.md)

## คำถามที่พบบ่อย 🤔

### จะรับ session ID ของ TikTok ได้อย่างไร?

คุณสามารถรับ session ID ของ TikTok ได้โดยการล็อกอินเข้า TikTok ในเบราว์เซอร์ของคุณ แล้วคัดลอกค่าของ cookie ที่ชื่อว่า `sessionid`

### ImageMagick binary ของฉันไม่ถูกตรวจพบ

ตรวจสอบให้แน่ใจว่าคุณตั้งค่าพาธไปยัง ImageMagick binary อย่างถูกต้องในไฟล์ `.env` ควรมีลักษณะดังนี้:

```env
IMAGEMAGICK_BINARY="C:\\Program Files\\ImageMagick-7.1.0-Q16\\magick.exe"
```

อย่าลืมใช้ backslash คู่ (`\\`) ในพาธ แทนที่จะใช้แค่ตัวเดียว

### ไม่สามารถติดตั้ง `playsound` ได้: Wheel failed to build

หากคุณมีปัญหาในการติดตั้ง `playsound` สามารถลองติดตั้งโดยใช้คำสั่งต่อไปนี้:

```bash
pip install -U wheel
pip install -U playsound
```

หากยังไม่สามารถแก้ปัญหาได้ กรุณาสอบถามใน discord หรือสร้างประเด็นใหม่ เพื่อให้ชุมชนช่วยเหลือคุณ

## บริจาค 🎁

หากคุณชอบและสนุกกับ `MoneyPrinter` และต้องการสนับสนุน สามารถคลิกปุ่มทางด้านขวาของ repository ได้เลย ❤️
ชื่อ (และ/หรือโลโก้) ของคุณจะถูกเพิ่มเข้า repository นี้ในฐานะผู้สนับสนุนเป็นการขอบคุณ

## การมีส่วนร่วม 🤝

ขณะนี้จะไม่รับ Pull Request

## ประวัติดาว 🌟

[![Star History Chart](https://api.star-history.com/svg?repos=FujiwaraChoki/MoneyPrinter&type=Date)](https://star-history.com/#FujiwaraChoki/MoneyPrinter&Date)

## ใบอนุญาต 📝

ดูข้อมูลเพิ่มเติมในไฟล์ [`LICENSE`](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---