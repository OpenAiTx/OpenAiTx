# Mamba: โปรแกรมจัดการแพ็กเกจที่รวดเร็วข้ามแพลตฟอร์ม

![mamba header image](https://raw.githubusercontent.com/mamba-org/mamba/main/docs/assets/mamba_header.png)

<!-- markdownlint-disable-file MD033 -->

<table>
<thead align="center" cellspacing="10">
  <tr>
    <th colspan="3" align="center" border="">ส่วนหนึ่งของ mamba-org</th>
  </tr>
</thead>
<tbody>
  <tr background="#FFF">
    <td align="center">โปรแกรมจัดการแพ็กเกจ <a href="https://github.com/mamba-org/mamba">mamba</a></td>
    <td align="center">เซิร์ฟเวอร์แพ็กเกจ <a href="https://github.com/mamba-org/quetz">quetz</a></td>
  </tr>
</tbody>
</table>

## mamba

[![Build Status](https://github.com/mamba-org/mamba/actions/workflows/tests.yml/badge.svg)](https://github.com/mamba-org/mamba/actions/workflows/tests.yml?query=branch%3Amain)
[![Join the Gitter Chat](https://badges.gitter.im/Join%20Chat.svg)](https://gitter.im/mamba-org/Lobby?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge)
[![docs](https://readthedocs.org/projects/mamba/badge/?version=latest&style=flat)](https://mamba.readthedocs.io/en/latest)
[![Gurubase](https://img.shields.io/badge/Gurubase-Ask%20mamba%20Guru-006BFF)](https://gurubase.io/g/mamba)

`mamba` คือการนำโปรแกรมจัดการแพ็กเกจ conda มาเขียนใหม่ด้วยภาษา C++ 

- ดาวน์โหลดข้อมูล repository และไฟล์แพ็กเกจแบบขนานโดยใช้มัลติเธรด
- ใช้ libsolv เพื่อแก้ไขข้อจำกัดการพึ่งพาได้รวดเร็วยิ่งขึ้น เป็นไลบรารีขั้นสูงที่ใช้ใน RPM package manager ของ Red Hat, Fedora และ OpenSUSE
- ส่วนหลักของ `mamba` ถูกพัฒนาด้วย C++ เพื่อประสิทธิภาพสูงสุด

ในขณะเดียวกัน `mamba` ใช้ parser คำสั่ง, การติดตั้งและถอนการติดตั้งแพ็กเกจ, รวมถึงกระบวนการตรวจสอบธุรกรรมเดียวกับ `conda` เพื่อให้สามารถใช้งานร่วมกันได้มากที่สุด

`mamba` เป็นส่วนหนึ่งของระบบนิเวศ [conda-forge](https://conda-forge.org/) ซึ่งยังประกอบด้วย `quetz` เซิร์ฟเวอร์แพ็กเกจ `conda` แบบโอเพนซอร์ส

คุณสามารถอ่าน [โพสต์ประกาศของเรา](https://medium.com/@QuantStack/open-software-packaging-for-science-61cecee7fc23)

## micromamba

`micromamba` คือเวอร์ชันที่ลิงก์แบบสแตติกของ `mamba`

สามารถติดตั้งเป็นโปรแกรมเดียวแบบสแตนด์อโลนโดยไม่ต้องมี dependencies ใด ๆ เหมาะอย่างยิ่งสำหรับ CI/CD pipeline และสภาพแวดล้อมที่เป็น container

ดู [เอกสารเกี่ยวกับ `micromamba`](https://mamba.readthedocs.io/en/latest/user_guide/micromamba.html) สำหรับรายละเอียด

## `mamba` v.s. `micromamba`

ควรเลือกใช้ `mamba` เมื่อ:

- มีการใช้ `libmambapy` หรือ `libmamba` โดยซอฟต์แวร์อื่นในสภาพแวดล้อมเดียวกัน
- กรณีที่จำเป็นต้องอัปเดตไลบรารีเป็นประจำ (โดยเฉพาะด้านความปลอดภัย)
- สภาพแวดล้อมที่เน้นการลดการใช้พื้นที่ดิสก์ของ dependencies

ควรเลือกใช้ `micromamba` เมื่อ:

- ต้องการพึ่งพาไฟล์โปรแกรมเดียวที่บรรจุทุกอย่าง
- ไม่มีการติดตั้ง miniforge distribution
- การใช้งานต้องการ runtime ที่น้อยที่สุด

## การติดตั้ง

โปรดดูคู่มือการติดตั้ง [mamba](https://mamba.readthedocs.io/en/latest/installation/mamba-installation.html)
และ [micromamba](https://mamba.readthedocs.io/en/latest/installation/micromamba-installation.html) ในเอกสารประกอบ

## ฟีเจอร์เพิ่มเติมใน Mamba และ Micromamba

`mamba` และ `micromamba` มาพร้อมกับฟีเจอร์เพิ่มเติมนอกเหนือจาก `conda` ปกติ

### `repoquery`

สำหรับการค้นหา repository และการตรวจสอบ dependencies ของแพ็กเกจอย่างมีประสิทธิภาพ สามารถใช้ `mamba repoquery` หรือ `micromamba repoquery`

ดู [เอกสาร repoquery](https://mamba.readthedocs.io/en/latest/user_guide/mamba.html#repoquery) สำหรับรายละเอียด

### การติดตั้ง lock files

`micromamba` สามารถใช้ติดตั้ง lock files ที่สร้างโดย [conda-lock](https://conda.github.io/conda-lock/) ได้โดยไม่ต้องติดตั้ง `conda-lock`

เพียงใช้คำสั่ง `micromamba create` พร้อมกับออปชัน `-f` ระบุไฟล์ lock ที่ชื่อจบด้วย
`-lock.yml` หรือ `-lock.yaml` เช่น

```bash
micromamba create -n my-env -f conda-lock.yml
```

### setup-micromamba (ตัวแทน setup-miniconda)

[setup-micromamba](https://github.com/marketplace/actions/setup-micromamba) เป็นตัวแทนของ [setup-miniconda](https://github.com/marketplace/actions/setup-miniconda) ที่ใช้ `micromamba`

สามารถลดเวลา setup CI ของคุณได้อย่างมากโดย:

- ใช้ `micromamba` ซึ่งใช้เวลาติดตั้งประมาณ 1 วินาที
- แคชการดาวน์โหลดแพ็กเกจ
- แคชสภาพแวดล้อม `conda` ทั้งหมด

## ความแตกต่างกับ `conda`

แม้ว่า `mamba` และ `micromamba` จะสามารถใช้แทน `conda` ได้โดยทั่วไป แต่ก็มีความแตกต่างบางประการ:

- `mamba` และ `micromamba` ไม่สนับสนุนการแก้ไขย้อนหลัง (ดูการอภิปรายที่ <https://github.com/mamba-org/mamba/issues/803>)
- `mamba` และ `micromamba` จะ normalize สตริง `MatchSpec` ให้อยู่ในรูปแบบที่ง่ายที่สุด ในขณะที่ `conda` จะใช้รูปแบบที่ละเอียดกว่า
  ซึ่งอาจทำให้ผลลัพธ์ของ `conda env export` และ `mamba env export` แตกต่างกันเล็กน้อย

## การติดตั้งสำหรับนักพัฒนา

โปรดดูคำแนะนำจาก [เอกสารทางการ](https://mamba.readthedocs.io/en/latest/developer_zone/dev_environment.html)

## เสถียรภาพของ API และ ABI

โครงการ Mamba ใช้ [semantic versioning](https://semver.org/) ในรูปแบบ `MAJOR.MINOR.PATCH`
แม้เราจะพยายามรักษาเสถียรภาพให้กับผู้ใช้ แต่บางครั้งก็จำเป็นต้องมีการเปลี่ยนแปลงที่ไม่เข้ากันเพื่อปรับปรุง
Mamba และลดภาระทางเทคนิค
เวอร์ชันในอนาคตของ Mamba อาจให้การรับประกันที่เข้มแข็งยิ่งขึ้น

### `libmamba` (C++)

เราไม่ทราบว่ามีผู้ใช้ API ของ C++ โดยตรง จึงเปิดโอกาสให้ปรับปรุงได้เต็มที่
สำหรับ `libmamba` คำว่า _backward compatible_ มีความหมายดังนี้:

- _ABI backward compatible_ หมายถึง คุณสามารถแทนที่ไบนารีของไลบรารีได้โดยไม่ต้องคอมไพล์โค้ดของคุณใหม่กับ header ที่อัปเดต
  พฤติกรรมที่ได้จะเหมือนเดิม ยกเว้นข้อผิดพลาด (ที่อาจหายไป) และประสิทธิภาพที่ดีขึ้น
- _API backward compatible_ หมายถึง คุณต้องคอมไพล์โค้ดของคุณใหม่กับไลบรารีเวอร์ชันใหม่ แต่ไม่ต้องแก้ไขโค้ด เพียงแค่ build ใหม่
  ทั้งนี้ต้องไม่ใช้งาน declaration ที่ถือว่าเป็น private เช่นใน sub-namespaces `detail`
  พฤติกรรมที่ได้จะเหมือนเดิม ยกเว้นข้อผิดพลาด (ที่อาจหายไป) และประสิทธิภาพที่ดีขึ้น
  หากมี declaration ที่ deprecated แต่ยังไม่ได้ลบและยังใช้งานได้ ถือว่ายังคง compatible เพราะเปลี่ยนเฉพาะพฤติกรรมขณะคอมไพล์

ด้วยเหตุนี้ `libmamba` ให้การรับประกันดังนี้:

- release แบบ `PATCH` จะ backward compatible ทั้ง API และ ABI
- release แบบ `MINOR` จะ compatible เฉพาะ API ใน `mamba/api`
  อาจเปลี่ยน API ที่อื่นและ ABI ที่ใดก็ได้
- release แบบ `MAJOR` ไม่มีการรับประกันใด ๆ

### `libmambapy` (Python)

สำหรับ `libmambapy` คำว่า _API backward compatible_ หมายความว่าโค้ด Python ของคุณจะทำงานได้เหมือนเดิมกับ `libmambapy` เวอร์ชันใหม่ ตราบใดที่คุณไม่ได้ใช้ declaration ที่ถือว่าเป็น private เช่น ฟังก์ชันที่ขึ้นต้นด้วย `_`
พฤติกรรมที่ได้จะเหมือนเดิม ยกเว้นข้อผิดพลาด (ที่อาจหายไป) และประสิทธิภาพที่ดีขึ้น
หากมี declaration ที่ deprecated แต่ยังไม่ได้ลบและยังใช้งานได้ ถือว่ายังคง compatible เพราะจะสังเกตเห็นเฉพาะเมื่อตั้งค่า Python ให้แสดง `DeprecationWarning` ซึ่งมักมีเฉพาะในโหมด development

ด้วยเหตุนี้ `libmambapy` ให้การรับประกันดังนี้:

- release แบบ `PATCH` จะ API backward compatible
- release แบบ `MINOR` จะ API backward compatible
- release แบบ `MAJOR` ไม่มีการรับประกันใด ๆ

### `mamba` และ `micromamba` (executables)

สำหรับ executables คำว่า _backward compatible_ หมายถึง input และ output ที่โปรแกรมสามารถประมวลผลได้ (programmable) และหมายความว่าโค้ดของคุณ (รวมถึง shell script) จะทำงานกับเวอร์ชันใหม่ของ executable ได้โดยไม่ต้องแก้ไข
input/output ที่โปรแกรมประมวลผลได้ ได้แก่ ชื่อโปรแกรม อาร์กิวเมนต์ในบรรทัดคำสั่ง ไฟล์คอนฟิก ตัวแปรสภาพแวดล้อม เอาต์พุต JSON ในบรรทัดคำสั่ง และไฟล์ที่ถูกสร้างขึ้น
**ไม่รวม** เอาต์พุตที่มนุษย์อ่านและข้อความ error ดังนั้นจึงไม่รวม warning ที่เป็น human-readable

ด้วยเหตุนี้ `mamba` และ `micromamba` ให้การรับประกันดังนี้:

- release แบบ `PATCH` จะ backward compatible
- release แบบ `MINOR` จะ backward compatible
- release แบบ `MAJOR` ไม่มีการรับประกันใด ๆ

## สนับสนุนเรา

มีเพียง `mamba` และ `micromamba` เวอร์ชัน 2.0 ขึ้นไปเท่านั้นที่ได้รับการสนับสนุนและพัฒนาอย่างต่อเนื่อง

สาขา `1.x` ดูแลเฉพาะสำหรับประเด็นความปลอดภัย เช่น CVEs

หากมีคำถาม สามารถเข้าร่วมพูดคุยกับเราได้ที่ [QuantStack Chat](https://gitter.im/QuantStack/Lobby)
หรือที่ [Conda channel](https://gitter.im/conda/conda) (โปรดทราบว่าโครงการนี้ไม่ได้มีความเกี่ยวข้องกับ `conda` หรือ Anaconda Inc. อย่างเป็นทางการ)

## ใบอนุญาต

เราใช้โมเดลลิขสิทธิ์ร่วมกันที่เปิดโอกาสให้ผู้ร่วมพัฒนาทุกคนยังคงเป็นเจ้าของลิขสิทธิ์ในผลงานของตน

ซอฟต์แวร์นี้อยู่ภายใต้ใบอนุญาต BSD-3-Clause ดูรายละเอียดได้ที่ไฟล์ [LICENSE](https://raw.githubusercontent.com/mamba-org/mamba/main/LICENSE)

---

### ประชุมนักพัฒนาทุกสองสัปดาห์

เรามีการประชุมผ่านวิดีโอคอนเฟอเรนซ์ทุกสองสัปดาห์เพื่อพูดคุยเกี่ยวกับสิ่งที่ได้ดำเนินการ และขอรับข้อเสนอแนะจากกันและกัน

ทุกคนสามารถเข้าร่วมได้ หากต้องการอภิปรายหัวข้อใดหรือเพียงแค่รับฟัง

- เมื่อไร: วันอังคาร [16:00 น. CET (ยุโรป)](https://calendar.google.com/calendar/u/0/embed?src=ab3jrfpede0kq0ubsroe82cd00@group.calendar.google.com&ctz=Europe/Paris)
- ที่ไหน: [Mamba jitsi](https://meet.jit.si/mamba-org)
- รายละเอียด: [บันทึกการประชุม](https://hackmd.io/@guj2k_aBSSyr1YHBG9raWw/HyHt-Ekzj)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---