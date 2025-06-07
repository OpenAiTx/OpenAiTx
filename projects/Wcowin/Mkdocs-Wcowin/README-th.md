# Wcowin for MkDocsธีม

**- สร้างขึ้นบนพื้นฐานของ Material for MkDocs เพื่อความสวยงาม**  
**- เรียบง่าย สวยงาม ฟังก์ชันครบครัน**  
**- ปรับแต่งสไตล์ได้เอง มีคู่มือภาษาไทยอย่างละเอียด**  
**- ใช้งานง่าย เหมาะสำหรับมือใหม่**  
**- 𝕙𝕒𝕧𝕖 𝕒 𝕘𝕠𝕠𝕕 𝕥𝕚𝕞𝕖 !**

## สารบัญ
- [Wcowin for MkDocsธีม](#wcowin-for-mkdocsธีม)
  - [สารบัญ](#สารบัญ)
  - [ตัวอย่าง](#ตัวอย่าง)
  - [วิธีใช้งานอย่างรวดเร็ว](#วิธีใช้งานอย่างรวดเร็ว)
  - [วิดีโอแนะนำ](#วิดีโอแนะนำ)
- [ติดต่อฉัน](#ติดต่อฉัน)
  - [ตัวอย่างการใช้งาน](#ตัวอย่างการใช้งาน)
  - [ประวัติ Star](#ประวัติ-star)
  - [ผู้สนับสนุน](#ผู้สนับสนุน)
  - [สนับสนุนผู้พัฒนา](#สนับสนุนผู้พัฒนา)
  - [สัญญาอนุญาต](#สัญญาอนุญาต)

## ตัวอย่าง  

<center>

**หน้าแรก**
![](https://pic4.zhimg.com/80/v2-b74491257518429555b9f58a3bdc1293_1440w.webp)   

**หน้าบทความ**
![](https://s1.imagehub.cc/images/2024/02/02/c15305494c69f311a721c0878b648b22.png)  

**หน้า Blog**
![](https://pic1.zhimg.com/80/v2-652abf2464779ebc6e5790ecaccaadde_1440w.webp) 

**เกี่ยวกับ**
<img width="1355" alt="image" src="https://github.com/Wcowin/Mkdocs-Wcowin/assets/99159173/bfc10737-260c-44c7-b036-8c7dba52be24">


**หน้าป้ายกำกับ**
![img](https://s1.imagehub.cc/images/2024/02/02/d20f0562838a8396724f18bfd09e19e8.png)  

**หน้าเพื่อนแบบเรียบง่าย**
![](https://pic2.zhimg.com/80/v2-551c0a6e858705f842e2984fd44ce7f7_1440w.webp)

**ส่วนท้ายของหน้า**
<img width="1363" alt="image" src="https://github.com/Wcowin/Mkdocs-Wcowin/assets/99159173/ac4db87b-396a-4d0e-99b5-51a1b316db33">

**ผลทดสอบ Lighthouse**
<img width="1363" alt="image" src="https://pic3.zhimg.com/80/v2-afef47cac915ad51071fdc2f6d990b30_1440w.webp">

<img width="1363" alt="image" src="https://s2.loli.net/2025/02/13/M7dgcDiGOI28PQs.png">

</center>

## วิธีใช้งานอย่างรวดเร็ว  

ก่อนอื่น แนะนำให้ติดตั้ง mkdocs-material ใน virtual environment:

```bash
pip install mkdocs-material
```

**วิธีที่ 1:**  
ดาวน์โหลดไฟล์ `Wcowin-for-MkDocs.zip` จาก [releases](https://github.com/Wcowin/Mkdocs-Wcowin/releases) แล้วแตกไฟล์ไปยังโฟลเดอร์ในเครื่องของคุณ จากนั้นเปิดเทอร์มินัลที่โฟลเดอร์นั้นแล้วรัน `mkdocs serve` ได้เลย

**วิธีที่ 2:**  
เปิดเทอร์มินัลที่โฟลเดอร์ในเครื่องของคุณ (ของฉันชื่อ Wcowin.github.io) แล้วรันคำสั่ง `git clone git@github.com:Wcowin/Mkdocs-Wcowin.git` เพื่อโคลนเทมเพลตนี้ลงเครื่อง

คัดลอกไฟล์ทั้งหมดจากโฟลเดอร์ที่โคลนมาไปใส่ไว้ในโฟลเดอร์ Wcowin.github.io (ดูรูปด้านล่าง) จากนั้นเปิดเทอร์มินัลที่โฟลเดอร์ Wcowin.github.io แล้วรัน `mkdocs serve` เพื่อใช้งาน หรือใช้วิธีอื่นคือดับเบิลคลิกไฟล์ `Mkdocs-serve.bat` ที่โฟลเดอร์หลัก (ใช้ได้เฉพาะบน Windows)
![image.png](https://s2.loli.net/2025/01/02/nsDEbN5OPk3atcp.png)

!หมายเหตุ: ถ้ามีแจ้งเตือนว่าไม่ได้ติดตั้งปลั๊กอิน git-committers หรืออื่น ๆ ให้รัน `pip install git-committers` ในเทอร์มินัล หรือหากต้องการติดตั้งทั้งหมดให้รัน `pip install -r requirements.txt`  

ดูคู่มือเบื้องต้นได้ที่: [การใช้ Mkdocs สำหรับสร้างเว็บไซต์ Static และอัปโหลดขึ้น GitHub Pages](https://raw.githubusercontent.com/Wcowin/Mkdocs-Wcowin/main/快速开始.md)

## วิดีโอแนะนำ

[วิดีโอสอน Mkdocs ภาษาไทย](https://space.bilibili.com/1407028951/lists/4566631?type=series) (สอนแบบ Step by step แนะนำสำหรับมือใหม่)

# ติดต่อฉัน

<center>

**Wechat**  
  <a href="https://pic3.zhimg.com/80/v2-5ef3dde831c9d0a41fe35fabb0cb8784_1440w.webp" target="_blank">
   <center>
    <img src="https://pic3.zhimg.com/80/v2-5ef3dde831c9d0a41fe35fabb0cb8784_1440w.webp" style="width: 450px; height: auto;">
    </center>  
  </a>  

**Telegram**

  <a href="https://t.me/wecowin" target="_blank" >
   <center>
    <img src="https://pica.zhimg.com/80/v2-d5876bc0c8c756ecbba8ff410ed29c14_1440w.webp" style="width: 450px; height: auto;">
    </center>  
  </a>

</center>


## ตัวอย่างการใช้งาน

[Lenny's Web](https://lennychen.top)  
[คู่มือของ苍镜月](https://pale-illusions.github.io/my-mkdocs/)  
[สมุดโน้ตของโลกแห่งแสง](https://lastwish.icu/)  
[ชีวิตของ Wen-Chieh Lee](https://wenchiehlee.github.io/mkdocs-life/)
[สมุดโน้ตของ BruceJin](https://brucejqs.github.io/MyNotebook/)  
[พื้นที่โค้ดของ 0X10CC](https://tang-jiapeng.github.io/)  
[โฮมเพจของ GENG Wei](https://wgeng.site/index.html)

ขอบคุณทุกท่าน~

## ประวัติ Star

[![Star History Chart](https://api.star-history.com/svg?repos=Wcowin/Mkdocs-Wcowin&type=Date)](https://star-history.com/#Wcowin/Mkdocs-Wcowin&Date)

![Alt](https://repobeats.axiom.co/api/embed/b824e1bf28f31c9fa190eb5079cc1d035e562e0b.svg "Repobeats analytics image")

## ผู้สนับสนุน
<a href="https://github.com/Wcowin/Mkdocs-Wcowin/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=Wcowin/Mkdocs-Wcowin" />
</a>

[![Built with Material for MkDocs](https://img.shields.io/badge/Material_for_MkDocs-526CFE?style=for-the-badge&logo=MaterialForMkDocs&logoColor=white)](https://squidfunk.github.io/mkdocs-material/)

<!-- ## ลิขสิทธิ์

ผลงานนี้ใช้สัญญาอนุญาต [ครีเอทีฟคอมมอนส์-แสดงที่มา-ไม่ใช้เพื่อการค้า-อนุญาตแบบเดียวกัน 4.0 สากล](https://creativecommons.org/licenses/by-nc-sa/4.0/deed.zh-hans) -->
## สนับสนุนผู้พัฒนา

  <a href="https://pic2.zhimg.com/80/v2-4384c32173a239a1609309aa1b1ee9f9_1440w.webp" target="_blank">
   <center>
    <img src="https://pic2.zhimg.com/80/v2-4384c32173a239a1609309aa1b1ee9f9_1440w.webp" style="width: 450px; height: auto;">
    </center>  
  </a> 


## สัญญาอนุญาต

**MIT License**

Copyright (c) 2022-2025 Wang Kewen

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to
deal in the Software without restriction, including without limitation the
rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
sell copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NON-INFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
IN THE SOFTWARE.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---