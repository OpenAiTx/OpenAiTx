warbleR: ทำให้การวิเคราะห์เสียงชีวภาพง่ายขึ้น
================

🌐 **ภาษา:**  
[อังกฤษ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en) |
[สเปน](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es) |
[ฝรั่งเศส](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr) |
[เยอรมัน](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de) |
[โปรตุเกส](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt) |
[อิตาลี](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it) |
[รัสเซีย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru) |
[จีน (ตัวง่าย)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN) |
[จีน (ตัวเต็ม)](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW) |
[ญี่ปุ่น](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja) |
[เกาหลี](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko) |
[ฮินดี](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi) |
[ไทย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th) |
[ดัตช์](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl) |
[โปแลนด์](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl) |
[อาหรับ](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar) |
[เปอร์เซีย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa) |
[ตุรกี](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr) |
[เวียดนาม](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi) |
[อินโดนีเซีย](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id) |
[อัสสัม](https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as)

<!-- README.md ถูกสร้างจาก README.Rmd กรุณาแก้ไขไฟล์นั้น -->
<!-- badges: start -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![Project Status: Active โครงการอยู่ในสถานะที่เสถียร ใช้งานได้
และกำลังพัฒนาอย่างต่อเนื่อง](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![License: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![CRAN_Status_Badge](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![Total
Downloads](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![Codecov test

coverage](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="warbleR logo" align="right" width = "25%" height="25%"/>

[warbleR](https://cran.r-project.org/package=warbleR) ถูกออกแบบมาเพื่อ
ช่วยวิเคราะห์โครงสร้างของสัญญาณเสียงสัตว์ใน
R ผู้ใช้สามารถรวบรวมการบันทึกเสียงนกแบบเปิดเผยหรือป้อนข้อมูลของตนเอง
เข้าสู่กระบวนการทำงานที่ช่วยให้เห็นภาพสเปกโตรกราฟและ
วัดพารามิเตอร์เสียง
[warbleR](https://cran.r-project.org/package=warbleR) ใช้
เครื่องมือวิเคราะห์เสียงพื้นฐานของแพ็กเกจ seewave และนำเสนอเครื่องมือใหม่
สำหรับการวิเคราะห์โครงสร้างเสียง เครื่องมือเหล่านี้สามารถใช้วิเคราะห์สัญญาณเสียงแบบกลุ่ม

คุณสมบัติหลักของแพ็กเกจนี้ ได้แก่:

- เครื่องมือหลากหลายสำหรับการวัดโครงสร้างเสียง
- การใช้ loop เพื่อประมวลผลงานกับสัญญาณเสียงที่อ้างอิงใน
  ตารางการเลือก
- การสร้างภาพในไดเรกทอรีทำงานด้วยสเปกโตรกราฟเพื่อ
  ให้ผู้ใช้จัดข้อมูลและตรวจสอบการวิเคราะห์เสียง

แพ็กเกจนี้มีฟังก์ชันสำหรับ:

- สำรวจและดาวน์โหลดการบันทึกเสียงจาก [Xeno‐Canto](https://xeno-canto.org/)
- สำรวจ จัดระเบียบ และจัดการไฟล์เสียงหลายไฟล์
- ตรวจจับสัญญาณโดยอัตโนมัติ (ในความถี่และเวลา) (แต่โปรดตรวจสอบแพ็กเกจ R
  [ohun](https://docs.ropensci.org/ohun/) สำหรับการใช้งานที่ละเอียดและเป็นมิตรมากกว่า)
- สร้างสเปกโตรกราฟของการบันทึกเสียงทั้งหมดหรือสัญญาณแต่ละส่วน
- ดำเนินการวัดโครงสร้างสัญญาณเสียงในรูปแบบต่าง ๆ
- ประเมินประสิทธิภาพของวิธีการวัด
- จัดหมวดหมู่สัญญาณ
- ลักษณะโครงสร้างระดับต่าง ๆ ในสัญญาณเสียง
- วิเคราะห์สถิติการประสานงานของการร้องคู่
- รวบรวมฐานข้อมูลและตารางคำอธิบายประกอบ

ฟังก์ชันส่วนใหญ่รองรับการประมวลผลแบบขนาน ซึ่ง
ช่วยแบ่งงานระหว่างโปรเซสเซอร์หลายตัวเพื่อเพิ่มประสิทธิภาพการคำนวณ


ประสิทธิภาพ เครื่องมือสำหรับประเมินประสิทธิผลของการวิเคราะห์ในแต่ละขั้นตอนก็มีให้ใช้งานเช่นกัน

## การติดตั้ง

ติดตั้ง/โหลดแพ็กเกจจาก CRAN ดังนี้:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```

ในการติดตั้งเวอร์ชันพัฒนาล่าสุดจาก
[github](https://github.com/) คุณจะต้องใช้แพ็กเกจ R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```

## การใช้งาน

แพ็กเกจนี้มีเอกสารประกอบหลายฉบับที่อธิบายคุณสมบัติหลักของแพ็กเกจ โดย
[แนะนำ warbleR](https://marce10.github.io/warbleR/articles/warbleR.html)
ให้ภาพรวมของฟังก์ชันการทำงานของแพ็กเกจ เอกสารประกอบ
[รูปแบบข้อมูลการกำกับคำอธิบาย](https://marce10.github.io/warbleR/articles/annotation_data_format.html)
ให้รายละเอียดเกี่ยวกับรูปแบบที่จำเป็นสำหรับข้อมูลนำเข้าการกำกับคำอธิบาย นอกจากนี้ยังมี [เอกสารประกอบเพิ่มเติมของแพ็กเกจ](https://marce10.github.io/warbleR/articles/) อีกสามฉบับพร้อมตัวอย่างวิธีการจัดระเบียบฟังก์ชันในเวิร์กโฟลว์การวิเคราะห์เสียง

คำอธิบายเต็มของแพ็กเกจ (แม้จะค่อนข้างเก่า) สามารถดูได้ใน
[บทความวารสารนี้](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624)

## แพ็กเกจอื่นๆ

แพ็กเกจ [seewave](https://cran.r-project.org/package=seewave) และ
[tuneR](https://cran.r-project.org/package=seewave) มีฟังก์ชันหลากหลายสำหรับวิเคราะห์และปรับแต่งเสียง โดยส่วนใหญ่จะทำงานกับวัตถุคลื่นเสียงที่นำเข้าแล้วในสภาพแวดล้อม R แพ็กเกจ [baRulho](https://cran.r-project.org/package=baRulho) เน้นการวัดการเสื่อมสภาพของสัญญาณเสียงที่เกิดจากถิ่นที่อยู่อาศัย โดยมีรูปแบบข้อมูลนำเข้าและส่งออกคล้ายกับของ
[warbleR](https://cran.r-project.org/package=warbleR) แพ็กเกจ
[Rraven](https://cran.r-project.org/package=Rraven) ช่วยแลกเปลี่ยนข้อมูลระหว่าง R และ [ซอฟต์แวร์วิเคราะห์เสียง Raven](https://www.ravensoundsoftware.com/) ([Cornell Lab of Ornithology](https://www.birds.cornell.edu/home)) และมีประโยชน์มากในการนำ Raven มาใช้เป็นเครื่องมือกำกับคำอธิบายในเวิร์กโฟลว์การวิเคราะห์เสียงใน R แพ็กเกจ
[ohun](https://docs.ropensci.org/ohun/) ใช้สำหรับตรวจจับเหตุการณ์เสียงโดยอัตโนมัติ ให้ฟังก์ชันสำหรับวินิจฉัยและปรับแต่งกระบวนการตรวจจับ [dynaSpec](https://cran.r-project.org/package=seewave) ช่วยสร้างสเปกโตรแกรมแบบไดนามิก (เช่น วิดีโอสเปกโตรแกรม)

## การอ้างอิง



















กรุณาอ้างอิง [warbleR](https://cran.r-project.org/package=warbleR) ดังนี้

Araya-Salas, M. และ Smith-Vidaurre, G. (2017), *warbleR: an r package to
streamline analysis of animal acoustic signals*. Methods Ecol Evol. 8,
184-191.

หมายเหตุ: กรุณาอ้างอิงแพ็กเกจ
[tuneR](https://cran.r-project.org/package=tuneR) และ
[seewave](https://cran.r-project.org/package=seewave) ด้วย หากคุณใช้ฟังก์ชันที่สร้างสเปกโตรแกรมหรือวัดเสียง





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-06-13

---