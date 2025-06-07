[996.ICU](https://996.icu/#/en_US)
=======
**โปรดทราบว่า ไม่มีบัญชีทางการ แอป หรือสินค้าทางการอื่นใด นอกจากโดเมนและที่เก็บข้อมูลทางการนี้เท่านั้น**

* [中文版](./README_CN.md)

ชื่อ `996.ICU` หมายถึง **"ทำงานตามระบบ '996' จนป่วยต้องเข้า ICU"** ซึ่งเป็นวลีเสียดสีในหมู่นักพัฒนาซอฟต์แวร์ชาวจีน หมายความว่าการทำงานตามตารางเวลา "996" คุณกำลังเสี่ยงต่อการต้องเข้า ICU (หอผู้ป่วยวิกฤต)

[![Badge](https://img.shields.io/badge/link-996.icu-%23FF4D5B.svg?style=flat-square)](https://996.icu/#/en_US)
[![LICENSE](https://img.shields.io/badge/license-Anti%20996-blue.svg?style=flat-square)](https://github.com/996icu/996.ICU/blob/master/LICENSE)
[![Slack](https://img.shields.io/badge/slack-996icu-green.svg?style=flat-square)](https://join.slack.com/t/996icu/shared_invite/enQtNjI0MjEzMTUxNDI0LTkyMGViNmJiZjYwOWVlNzQ3NmQ4NTQyMDRiZTNmOWFkMzYxZWNmZGI0NDA4MWIwOGVhOThhMzc3NGQyMDBhZDc)
[![HitCount](http://hits.dwyl.com/996icu/996ICU.svg)](http://hits.dwyl.com/996icu/996ICU)


ข่าวที่เกี่ยวข้อง:
---
* *RadiiChina:* [GitHub Protest Over Chinese Tech Companies’ “996” Culture Goes Viral](https://radiichina.com/github-protest-chinese-tech-996/)
* *Financial Times:*  [China tech worker protest against long working hours goes viral](https://www.ft.com/content/72754638-55d1-11e9-91f9-b6515a54c5b1)
* *Wired:* [How GitHub is helping overworked Chinese programmers](https://www.wired.com/story/how-github-helping-overworked-chinese-programmers/)

ดู [รายชื่อข่าวทั้งหมด](externals/news_EN.md)



996 คืออะไร?
---

ตารางเวลาทำงาน "996" หมายถึงตารางเวลาทำงานที่ไม่เป็นทางการ (9 โมงเช้า&ndash;3 ทุ่ม, 6 วันต่อสัปดาห์) ที่กำลังได้รับความนิยม การทำงานในบริษัทที่สนับสนุนตารางเวลา "996" โดยปกติหมายถึงการทำงานอย่างน้อย 60 ชั่วโมงต่อสัปดาห์
เยี่ยมชม [ระบบเวลาทำงาน 996](https://en.wikipedia.org/wiki/996_working_hour_system) ในวิกิพีเดียเพื่อดูรายละเอียดเพิ่มเติม


ฉันสามารถทำอะไรได้บ้าง?
---

- อัปเดตรายการนี้ [list](blacklist/README.md) พร้อมหลักฐานเพื่อช่วยเหลือแรงงานทุกคน [ช่องทางรายการสมบูรณ์จากบุคคลที่สาม](https://www.996action.com/index.php/889799)
- เพิ่ม [badge](externals/instruction.md) นี้ลงในโปรเจกต์ของคุณเพื่อสนับสนุน 996.ICU  
- ใช้ไลเซนส์ [Anti 996 License](LICENSE) กับโปรเจกต์ของคุณ  
- เพิ่ม [ข้อเสนอแนะ](proposal/README.md) เพื่อแนะนำเกี่ยวกับการพัฒนา 996.ICU
- กลับบ้านเวลา 6 โมงเย็นโดยไม่ต้องรู้สึกผิด


เสียงสะท้อน
---

### สื่อของรัฐ
- [The 996 shall disappear](http://www.xinhuanet.com/politics/2019-04/15/c_1124370790.htm)


### ทุนนิยม
- **แจ็ค หม่า ผู้ก่อตั้งอาลีบาบา**: `มันเป็นพรอันยิ่งใหญ่ที่สามารถทำงาน '996' ได้`
- **ริชาร์ด หลิว ผู้ก่อตั้ง JD.com**: `เราจะไม่บังคับพนักงานให้ทำงานแบบ '996'`
(อย่างไรก็ตาม มีพนักงานนิรนามหลายคนอ้างว่ามี **รายชื่อ** ของแผนกที่ **จัดอันดับ** ตามชั่วโมงการทำงานล่วงเวลา ผู้ที่ชั่วโมงน้อยที่สุดจะถูกลงโทษ และผู้นำจะไม่ทิ้งหลักฐานเวลาเรียกร้องให้พนักงานทำงานแบบ '996')
- **ไป๋ หยา ผู้ก่อตั้ง Youzan**: `นี่จะเป็นการตัดสินใจที่ถูกต้องอย่างแน่นอนเมื่อมองย้อนกลับไปอีกไม่กี่ปีข้างหน้า`

### นักพัฒนา
- **Guido van Rossum, ผู้ก่อตั้ง Python**: [`ตารางเวลางาน '996' นั้นไร้มนุษยธรรม` ](https://twitter.com/gvanrossum/status/1111628076801236993)


หลักการและวัตถุประสงค์
---

* 996.ICU เป็นโครงการที่เริ่มต้นโดยผู้ปฏิบัติงานด้านไอที เรายินดีต้อนรับผู้คนจากสาขาอื่นและจากประเทศอื่นให้เข้าร่วมการอภิปราย

* นี่ไม่ใช่ขบวนการทางการเมือง เราสนับสนุนกฎหมายแรงงานอย่างแน่วแน่และเรียกร้องให้นายเคารพสิทธิและผลประโยชน์ที่ชอบด้วยกฎหมายของลูกจ้าง

* การพัฒนาจากโอเพ่นซอร์สแบบปิดเป็นโอเพ่นซอร์สถือเป็นความก้าวหน้าอย่างยิ่ง และจะเป็นความก้าวหน้าหากโอเพ่นซอร์สให้ความสำคัญกับสิทธิแรงงานในเวลาเดียวกัน เป้าหมายของเราคือการสร้างไลเซนส์ซอฟต์แวร์โอเพ่นซอร์สที่สนับสนุนสิทธิแรงงาน

* เรายินดีรับฟังข้อเสนอแนะที่เป็นบวกและสร้างสรรค์ทุกประการ และส่งเสริมการพูดที่มีวุฒิภาวะและมีความรับผิดชอบ


ขยายอิทธิพล
---

โปรด [แปลเนื้อหาของ 996.ICU](i18n/README.md) ได้อย่างเสรี ปรับแต่งรูปแบบ เพิ่มเนื้อหา หรือแก้ไขข้อผิดพลาดทางไวยากรณ์ โปรดทราบว่าการเพิ่มการแปลมากเกินไปอาจทำให้หลุดประเด็นหลักได้

พลังของชุมชน
---

 - [955.WLB](https://github.com/formulahendry/955.WLB) เป็น repo ที่รวบรวมรายชื่อบริษัทที่มีสมดุลชีวิตการทำงานแบบ 955
 - [996.LIST](https://github.com/fengT-T/996_list) เป็น repo จัดอันดับบริษัท 996 และ 955
 - [996.YAOCL](https://github.com/boycott996/yaocl) Yet Another Overtime Corps List, รายการโหวตแบบนิรนามอีกชุดหนึ่ง
 - [996.Leave](https://github.com/623637646/996.Leave) สนับสนุนและแนะนำการทำงานในต่างประเทศ
 - [996.RIP](https://web.archive.org/web/20190422174052/https://996.rip/) ข่าวเก่าไม่เคยหายไป
 - [996.Petition](https://github.com/xokctah/996.petition) ริเริ่มแคมเปญโดยส่งจดหมายเปิดผนึกถึงหน่วยงานรัฐบาลที่เกี่ยวข้อง
 - [996.avengers](https://github.com/996-icu-avengers/Natasha) เพิ่มแท็ก `996ICU` และ `955WLB` บนเว็บไซต์หางาน
 - [996.OD](https://github.com/zheolong/996.OD.git) โรคจากการทำงานเป็นสัญญาณเตือนของ ICU
 - [996.Q](https://github.com/alexddhuang/996.Q) คลังเก็บเรื่องล้อเลียน ตลก หรือมุกเกี่ยวกับ 996
 - [996.survey](https://github.com/0594mazhiyuan/996.survey) สำรวจสถานการณ์ 996
 - [support.996.ICU](https://github.com/msworkers/support.996.ICU) พนักงาน Microsoft และ GitHub สนับสนุน 996.ICU
 - [996.Blockchain](https://github.com/996BC/996.Blockchain) บล็อกเชนสำหรับหลักฐาน 996
 - [996.Error](https://github.com/MagicLu550/996Error) รวมข้อยกเว้น "996" ที่เขียนในหลายภาษาและสามารถนำไปใช้ในโปรเจกต์ได้ทันที

ปัญหาอยู่ที่ไหน?
---

แม้จะเปิดใช้งานข้อจำกัดการโต้ตอบ พื้นที่ issues ก็ยังควบคุมไม่ได้โดยสิ้นเชิง
ดังนั้น **ข้าพเจ้า** จึงตัดสินใจปิดฟีเจอร์นี้เอง ไม่ใช่โดย GitHub หรือบุคคลอื่น


ไลเซนส์
---

[Anti-996 License](LICENSE)

 - จุดประสงค์ของไลเซนส์นี้คือป้องกันบริษัทที่ละเมิดกฎหมายแรงงานจากการใช้ซอฟต์แวร์หรือโค้ดภายใต้ไลเซนส์นี้ และบังคับให้บริษัทเหล่านั้นต้องชั่งน้ำหนักวิธีการทำงานของตนเอง
 - ดู [รายชื่อโปรเจกต์ทั้งหมด](awesomelist/README.md) ภายใต้ Anti-996 License

 - ร่างนี้ดัดแปลงมาจากไลเซนส์ MIT ดูคำอธิบายโดยละเอียดได้ที่ [Wiki](https://github.com/kattgu7/996-License-Draft/wiki) ไลเซนส์นี้ออกแบบมาให้เข้ากันได้กับไลเซนส์โอเพ่นซอร์สหลักทุกรูปแบบ  
 - สำหรับผู้เชี่ยวชาญด้านกฎหมายหรือผู้ที่ต้องการช่วยเหลือเวอร์ชันถัดไปโดยตรง โปรดไปที่ [Anti-996-License-1.0](https://github.com/kattgu7/996-License-Draft) ขอบคุณ

บริจาค
---
เรารับเงินคริปโตต่อไปนี้:

- **ETH**: `0x57a7e421c8edfc7f13612f68a54365fc729f2355`

- **USDT**(ERC20): `0x57a7e421c8edfc7f13612f68a54365fc729f2355`

- **BTC**: `1CKB19MxFppcXC3GMG84URuuegifsy8GAr`

เงินบริจาคจะถูกนำไปใช้เพื่อดูแล/รักษาเว็บไซต์

ติดต่อ
---

คุณสามารถติดต่อฉันได้ทาง [E-mail](mailto:996icu.repo@gmail.com) หากต้องการ

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---