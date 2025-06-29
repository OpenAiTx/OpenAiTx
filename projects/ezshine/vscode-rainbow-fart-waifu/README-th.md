# 🌈 Rainbow Fart Waifu
![](https://s1.ax1x.com/2020/08/21/dNvHfS.gif)

เว็บไซต์：[https://rfw.jnsii.com](https://rfw.jnsii.com/index_en.html)

ภาษา: [简体中文](./README.zh.md) | English

## สรุป

----

ส่วนขยายนี้มีแนวคิดมาจาก [@SaekiRaku](https://github.com/SaekiRaku/vscode-rainbow-fart) ได้เขียนโค้ดใหม่ทั้งหมด รองรับแพ็กเกจเสียงทั้งหมด และเพิ่มฟีเจอร์ใหม่บางอย่าง

## ขอบคุณเป็นพิเศษ

---

1. ส่วนขยายนี้รวมแพ็กเกจเสียงภาษาจีนจาก [@justkowalski](https://github.com/JustKowalski) คุณสามารถ [ดาวน์โหลดแพ็กเกจเสียงเพิ่มเติมจาก github](https://github.com/topics/rainbow-fart)
2. ส่วนขยายนี้รวม cmdmp3win.exe จาก [@James K. Lawless](http://jiml.us)
3. โมเดลวาอิฟุเริ่มต้นจาก [@二夏](https://erxia207.lofter.com) หากคุณต้องการออกแบบวาอิฟุต้นฉบับที่เป็นของคุณเอง ติดต่อเธอได้
4. ส่วนขยายนี้รวมอีกโมเดลวาอิฟุชื่อ keysoban เปิดซอร์สโดย [@DenchiSoft](https://twitter.com/DenchiSoft/status/1036017773011525632)

[ดาวน์โหลดโมเดลวาอิฟุเพิ่มเติม](https://github.com/ezshine/live2d-model-collections)

## ระบบปฏิบัติการที่รองรับ

---

~~~~
รองรับเฉพาะ MacOS และ Windows10 เท่านั้น
~~~~

## คำถามที่พบบ่อย

---

#### _วาอิฟุไม่แสดงผล?_
> ตอบ: คุณต้อง [ดาวน์โหลด](https://github.com/ezshine/live2d-model-collections) waifu container หลังจากแตกไฟล์ zip ทั้งหมดแล้ว ให้รัน liv2dplayer.exe จากนั้นเรียกคำสั่งใน vscode แล้วลองสลับโมเดลวาอิฟุ

## คู่มือ, คำสั่ง

---

🌈 แสดงคำสั่ง Rainbow Fart Waifu

- "Switch Voice Packages"
- "Switch Waifu Models"
- "Open Resource Directory"

> หากคุณดาวน์โหลดแพ็กเกจเสียงหรือโมเดล ให้ใช้คำสั่งนี้เพื่อเปิดโฟลเดอร์ resource แล้วย้ายแพ็กเกจเหล่านั้นไปไว้ใน path นี้

- "Download Waifu Container and More Resources"

## ฟีเจอร์

---

1. ตัด WebUI ออก เล่นไฟล์เสียงด้วย 'afplay' บน MacOS และ 'cmdmp3win' บน Windows10
2. เชื่อมต่อกับ WaifuContainer วางวาอิฟุเสมือนบนหน้าจอเดสก์ท็อปให้อยู่กับคุณขณะเขียนโปรแกรม

## หมายเหตุเกี่ยวกับแพ็กเกจเสียง

---

~~~~
หมายเหตุสำหรับการปรับแต่งหรือใช้งานแพ็กเกจเสียงที่ดาวน์โหลดจากอินเทอร์เน็ต
~~~~

1. ใช้ 'contributes.json' ไม่ใช่ 'manifest.json'
2. เพิ่ม texts ใน 'contributes.json' เพื่อให้ตรงกับเนื้อหาเสียง

~~~~javascript
"contributes": [
    {
        "keywords": ["function", "=>", "func ", "def "],
        "voices":[
            "function_01.mp3",
            "function_02.mp3",
            "function_03.mp3"
        ],
        "texts":[
            "哇哦，你的回调函数写的好棒棒呀！",
            "这个函数的命名用我的名字怎么样呀？",
            "再厉害的函数，也执行不出我对你的喜欢！"
        ]
    }
]
~~~~

## สนับสนุนฉัน

---

ถ้าส่วนขยายนี้ทำให้การเขียนโปรแกรมของคุณมีความสุขขึ้น ขอรับโค้กซักขวดได้ไหม?

![](./resources/donate.jpg)

**ขอให้สนุก!**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---