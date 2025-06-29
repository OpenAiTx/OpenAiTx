<div align="center">

<h1 style="border-bottom: none">
    <b><a href="https://next.yearning.io">Yearning</a></b><br />
</h1>
</div>

แพลตฟอร์มที่แข็งแกร่งและติดตั้งใช้งานในเครื่อง ออกแบบมาเพื่อการตรวจจับ SQL และตรวจสอบการสืบค้นอย่างไร้รอยต่อ เหมาะสำหรับ DBA และนักพัฒนาโดยเฉพาะ เน้นความเป็นส่วนตัวและประสิทธิภาพ ให้สภาพแวดล้อมที่ใช้งานง่ายและปลอดภัยสำหรับการตรวจสอบ MYSQL

---
[![OSCS Status](https://www.oscs1024.com/platform/badge/cookieY/Yearning.svg?size=small)](https://www.murphysec.com/dr/nDuoncnUbuFMdrZsh7)
![Platform Support](https://img.shields.io/badge/-x86_x64%20ARM%20Supports%20%E2%86%92-rgb(84,56,255)?style=flat-square&logoColor=white&logo=linux)
[![][github-license-shield]][github-license-link]
![GitHub top language](https://img.shields.io/github/languages/top/cookieY/Yearning?color=369eff&label=golang&labelColor=black&logo=golang&logoColor=white&style=flat-square)
[![][github-forks-shield]][github-forks-link]
[![][github-stars-shield]][github-stars-link]
[![Downloads](https://img.shields.io/github/downloads/cookieY/Yearning/total?labelColor=black&logo=download&logoColor=white&style=flat-square)](https://github.com/cookieY/Yearning/releases/latest)

English | [简体中文](https://raw.githubusercontent.com/cookieY/Yearning/next/README.zh-CN.md) | [日本語](https://raw.githubusercontent.com/cookieY/Yearning/next/README.ja-JP.md)

## ✨ คุณสมบัติ

- **ผู้ช่วย AI**: ผู้ช่วย AI ของเรานำเสนอข้อเสนอแนะในการปรับปรุง SQL แบบเรียลไทม์ เพื่อเพิ่มประสิทธิภาพของ SQL นอกจากนี้ยังรองรับการแปลงข้อความเป็น SQL ให้ผู้ใช้สามารถใส่ข้อความภาษาธรรมชาติและรับคำสั่ง SQL ที่ปรับแต่งแล้วได้ทันที

- **การตรวจสอบ SQL**: สร้างทิกเก็ตการตรวจสอบ SQL พร้อมกระบวนการอนุมัติและการตรวจสอบไวยากรณ์อัตโนมัติ ตรวจสอบความถูกต้อง ความปลอดภัย และการปฏิบัติตามข้อกำหนดของคำสั่ง SQL ระบบจะสร้างคำสั่ง Rollback อัตโนมัติสำหรับการดำเนินการ DDL/DML พร้อมประวัติการดำเนินงานที่สามารถติดตามได้อย่างครบถ้วน

- **การตรวจสอบการสืบค้น**: ตรวจสอบคำสืบค้นของผู้ใช้ จำกัดแหล่งข้อมูลและฐานข้อมูล และทำการปกปิดฟิลด์ที่มีข้อมูลสำคัญ บันทึกประวัติการสืบค้นเพื่อใช้อ้างอิงในอนาคต

- **กฎการตรวจสอบ**: ตัวตรวจสอบไวยากรณ์อัตโนมัติของเรารองรับกฎการตรวจสอบที่หลากหลาย เหมาะกับสถานการณ์การตรวจสอบอัตโนมัติส่วนใหญ่

- **เน้นความเป็นส่วนตัว**: Yearning เป็นโซลูชันโอเพ่นซอร์สที่ติดตั้งในเครื่อง ซึ่งรับประกันความปลอดภัยของฐานข้อมูลและคำสั่ง SQL ของคุณ มีระบบเข้ารหัสเพื่อปกป้องข้อมูลสำคัญ ให้ข้อมูลของคุณปลอดภัยแม้ในกรณีที่ถูกเข้าถึงโดยไม่ได้รับอนุญาต

- **RBAC (การควบคุมสิทธิ์ตามบทบาท)**: สร้างและจัดการบทบาทที่มีสิทธิ์เฉพาะ กำหนดขอบเขตการเข้าถึงงานสืบค้น การตรวจสอบ และการดำเนินการสำคัญอื่น ๆ ตามบทบาทของผู้ใช้

> \[!TIP]
> สำหรับข้อมูลเพิ่มเติม โปรดเยี่ยมชม [Yearning Guide](https://next.yearning.io)


## ⚙️ การติดตั้ง

ดาวน์โหลด [เวอร์ชันล่าสุด](https://github.com/cookieY/Yearning/releases/latest) และแตกไฟล์ ตรวจสอบให้แน่ใจว่าได้ตั้งค่า `./config.toml` ก่อนเริ่มใช้งาน

### การติดตั้งแบบแมนนวล

```bash
## เริ่มต้นฐานข้อมูล
./Yearning install

## เริ่มใช้งาน Yearning
./Yearning run

## วิธีใช้
./Yearning --help
```

### 🚀 การติดตั้งด้วย Docker
[![][docker-release-shield]][docker-release-link]
[![][docker-size-shield]][docker-size-link]
[![][docker-pulls-shield]][docker-pulls-link]
```bash
## เริ่มต้นฐานข้อมูล
docker run --rm -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning "/opt/Yearning install"

## เริ่มใช้งาน Yearning
docker run -d -it -p8000:8000 -e SECRET_KEY=$SECRET_KEY -e MYSQL_USER=$MYSQL_USER -e MYSQL_ADDR=$MYSQL_ADDR -e MYSQL_PASSWORD=$MYSQL_PASSWORD -e MYSQL_DB=$Yearning_DB -e Y_LANG=zh_CN yeelabs/yearning
```
## 🤖 ผู้ช่วย AI

ผู้ช่วย AI ของเราใช้โมเดลภาษาขนาดใหญ่เพื่อให้ข้อเสนอแนะในการปรับปรุง SQL และแปลงข้อความเป็น SQL ไม่ว่าจะใช้พรอมต์เริ่มต้นหรือที่กำหนดเอง ผู้ช่วย AI จะเพิ่มประสิทธิภาพของ SQL โดยการปรับแต่งคำสั่งและแปลงข้อความภาษาธรรมชาติเป็นคำสั่งสืบค้น SQL

![Text to SQL](https://raw.githubusercontent.com/cookieY/Yearning/next/img/text2sql.jpg)

## 🔖 ตัวตรวจสอบ SQL อัตโนมัติ

ตัวตรวจสอบ SQL อัตโนมัติจะประเมินคำสั่ง SQL ตามกฎที่กำหนดไว้ล่วงหน้าและไวยากรณ์ เพื่อให้แน่ใจว่าคำสั่งนั้นสอดคล้องกับมาตรฐานการเขียนโค้ด แนวทางปฏิบัติที่ดี และข้อกำหน้านความปลอดภัย ให้ชั้นการตรวจสอบที่แข็งแกร่ง

![SQL Audit](https://raw.githubusercontent.com/cookieY/Yearning/next/img/audit.png)

## 💡 ไฮไลท์ไวยากรณ์ SQL และการเติมข้อความอัตโนมัติ

เพิ่มประสิทธิภาพการเขียนสืบค้นของคุณด้วยไฮไลท์ไวยากรณ์ SQL และการเติมข้อความอัตโนมัติ ฟีเจอร์เหล่านี้ช่วยให้ผู้ใช้มองเห็นส่วนประกอบของสืบค้น SQL ได้ชัดเจน เช่น คีย์เวิร์ด ชื่อตาราง ชื่อคอลัมน์ และโอเปอเรเตอร์ ทำให้อ่านและเข้าใจโครงสร้างสืบค้นได้ง่ายขึ้น

![SQL Query](https://raw.githubusercontent.com/cookieY/Yearning/next/img/query.png)

## ⏺️ บันทึกคำสั่ง/สืบค้น

แพลตฟอร์มของเรารองรับการตรวจสอบคำสั่งและการสืบค้นของผู้ใช้ ฟีเจอร์นี้ช่วยให้คุณติดตามและบันทึกการสืบค้นทั้งหมด รวมถึงแหล่งข้อมูล ฐานข้อมูล และการจัดการฟิลด์ที่มีข้อมูลสำคัญ เพื่อให้เป็นไปตามข้อกำหนดและสามารถตรวจสอบประวัติการสืบค้นได้

![Order/Query Record](https://raw.githubusercontent.com/cookieY/Yearning/next/img/record.png)

ด้วยการมุ่งเน้นคุณสมบัติหลักเหล่านี้ Yearning ช่วยเพิ่มประสบการณ์ผู้ใช้ ปรับปรุงประสิทธิภาพ SQL และรับรองการปฏิบัติตามข้อกำหนดและการติดตามในกระบวนการทำงานกับฐานข้อมูล

## 🛠️ เครื่องมือแนะนำ

- [Spug - แพลตฟอร์มโอเพ่นซอร์สสำหรับงานปฏิบัติการอัตโนมัติน้ำหนักเบา](https://github.com/openspug/spug)

## ☎️ ติดต่อ

สอบถามข้อมูลเพิ่มเติม กรุณาติดต่อทางอีเมล: henry@yearning.io
## 📋 ใบอนุญาต

Yearning ได้รับอนุญาตภายใต้สัญญาอนุญาต AGPL ดูรายละเอียดเพิ่มเติมได้ที่ [LICENSE](LICENSE)

2024 © Henry Yee

---

ด้วย Yearning สัมผัสประสบการณ์การตรวจสอบและปรับแต่ง SQL ที่มีประสิทธิภาพ ปลอดภัย และเป็นระบบ


[docker-pulls-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-pulls-shield]: https://img.shields.io/docker/pulls/yeelabs/yearning?color=45cc11&labelColor=black&style=flat-square
[docker-release-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-release-shield]: https://img.shields.io/docker/v/yeelabs/yearning?color=369eff&label=docker&labelColor=black&logo=docker&logoColor=white&style=flat-square
[docker-size-link]: https://hub.docker.com/r/yeelabs/yearning
[docker-size-shield]: https://img.shields.io/docker/image-size/yeelabs/yearning?color=369eff&labelColor=black&style=flat-square
[github-forks-shield]: https://img.shields.io/github/forks/cookieY/Yearning?color=8ae8ff&labelColor=black&style=flat-square
[github-forks-link]: https://github.com/cookieY/Yearning/network/members
[github-stars-link]: https://github.com/cookieY/Yearning/network/stargazers
[github-stars-shield]: https://img.shields.io/github/stars/cookieY/Yearning?color=ffcb47&labelColor=black&style=flat-square
[github-license-link]: https://github.com/cookieY/Yearning/blob/main/LICENSE
[github-license-shield]: https://img.shields.io/badge/AGPL%203.0-white?labelColor=black&style=flat-square

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-29

---