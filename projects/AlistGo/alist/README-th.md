<div align="center">
  <a href="https://alist.nn.ci"><img width="100px" alt="logo" src="https://cdn.jsdelivr.net/gh/alist-org/logo@main/logo.svg"/></a>
  <p><em>🗂️โปรแกรมแสดงรายการไฟล์ที่รองรับที่เก็บข้อมูลหลายประเภท ขับเคลื่อนด้วย Gin และ Solidjs.</em></p>
<div>
  <a href="https://goreportcard.com/report/github.com/alist-org/alist/v3">
    <img src="https://goreportcard.com/badge/github.com/alist-org/alist/v3" alt="latest version" />
  </a>
  <a href="https://github.com/alist-org/alist/blob/main/LICENSE">
    <img src="https://img.shields.io/github/license/Xhofe/alist" alt="License" />
  </a>
  <a href="https://github.com/alist-org/alist/actions?query=workflow%3ABuild">
    <img src="https://img.shields.io/github/actions/workflow/status/Xhofe/alist/build.yml?branch=main" alt="Build status" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/release/Xhofe/alist" alt="latest version" />
  </a>
  <a title="Crowdin" target="_blank" href="https://crwd.in/alist">
    <img src="https://badges.crowdin.net/alist/localized.svg">
  </a>
</div>
<div>
  <a href="https://github.com/alist-org/alist/discussions">
    <img src="https://img.shields.io/github/discussions/Xhofe/alist?color=%23ED8936" alt="discussions" />
  </a>
  <a href="https://discord.gg/F4ymsH4xv2">
    <img src="https://img.shields.io/discord/1018870125102895134?logo=discord" alt="discussions" />
  </a>
  <a href="https://github.com/alist-org/alist/releases">
    <img src="https://img.shields.io/github/downloads/Xhofe/alist/total?color=%239F7AEA&logo=github" alt="Downloads" />
  </a>
  <a href="https://hub.docker.com/r/xhofe/alist">
    <img src="https://img.shields.io/docker/pulls/xhofe/alist?color=%2348BB78&logo=docker&label=pulls" alt="Downloads" />
  </a>
  <a href="https://alist.nn.ci/guide/sponsor.html">
    <img src="https://img.shields.io/badge/%24-sponsor-F87171.svg" alt="sponsor" />
  </a>
</div>
</div>

---

English | [中文](./README_cn.md) | [日本語](./README_ja.md) | [Contributing](./CONTRIBUTING.md) | [CODE_OF_CONDUCT](./CODE_OF_CONDUCT.md)

## คุณสมบัติ

- [x] รองรับที่เก็บข้อมูลหลายประเภท
    - [x] ที่เก็บข้อมูลในเครื่อง (Local storage)
    - [x] [Aliyundrive](https://www.alipan.com/)
    - [x] OneDrive / Sharepoint ([global](https://www.office.com/), [cn](https://portal.partner.microsoftonline.cn),de,us)
    - [x] [189cloud](https://cloud.189.cn) (บุคคล, ครอบครัว)
    - [x] [GoogleDrive](https://drive.google.com/)
    - [x] [123pan](https://www.123pan.com/)
    - [x] FTP / SFTP
    - [x] [PikPak](https://www.mypikpak.com/)
    - [x] [S3](https://aws.amazon.com/s3/)
    - [x] [Seafile](https://seafile.com/)
    - [x] [UPYUN Storage Service](https://www.upyun.com/products/file-storage)
    - [x] WebDav (รองรับ OneDrive/SharePoint โดยไม่ต้องใช้ API)
    - [x] Teambition ([China](https://www.teambition.com/ ),[International](https://us.teambition.com/ ))
    - [x] [Mediatrack](https://www.mediatrack.cn/)
    - [x] [139yun](https://yun.139.com/) (บุคคล, ครอบครัว, กลุ่ม)
    - [x] [YandexDisk](https://disk.yandex.com/)
    - [x] [BaiduNetdisk](http://pan.baidu.com/)
    - [x] [Terabox](https://www.terabox.com/main)
    - [x] [UC](https://drive.uc.cn)
    - [x] [Quark](https://pan.quark.cn)
    - [x] [Thunder](https://pan.xunlei.com)
    - [x] [Lanzou](https://www.lanzou.com/)
    - [x] [ILanzou](https://www.ilanzou.com/)
    - [x] [Aliyundrive share](https://www.alipan.com/)
    - [x] [Google photo](https://photos.google.com/)
    - [x] [Mega.nz](https://mega.nz)
    - [x] [Baidu photo](https://photo.baidu.com/)
    - [x] SMB
    - [x] [115](https://115.com/)
    - [X] Cloudreve
    - [x] [Dropbox](https://www.dropbox.com/)
    - [x] [FeijiPan](https://www.feijipan.com/)
    - [x] [dogecloud](https://www.dogecloud.com/product/oss)
    - [x] [Azure Blob Storage](https://azure.microsoft.com/products/storage/blobs)
- [x] ติดตั้งใช้งานง่าย พร้อมใช้งานทันที
- [x] แสดงตัวอย่างไฟล์ (PDF, markdown, โค้ด, ข้อความธรรมดา, ...)
- [x] แสดงตัวอย่างรูปภาพแบบแกลเลอรี่
- [x] แสดงตัวอย่างวิดีโอและเสียง รองรับเนื้อเพลงและคำบรรยาย
- [x] แสดงตัวอย่างเอกสาร Office (docx, pptx, xlsx, ...)
- [x] แสดงตัวอย่าง `README.md`
- [x] คัดลอกลิงก์ถาวรของไฟล์และดาวน์โหลดไฟล์โดยตรง
- [x] โหมดกลางคืน (Dark mode)
- [x] รองรับหลายภาษา (I18n)
- [x] เส้นทางที่มีการป้องกัน (ป้องกันด้วยรหัสผ่านและการยืนยันตัวตน)
- [x] WebDav (ดูรายละเอียดที่ https://alist.nn.ci/guide/webdav.html)
- [x] [Docker Deploy](https://hub.docker.com/r/xhofe/alist)
- [x] Cloudflare Workers proxy
- [x] ดาวน์โหลดไฟล์/โฟลเดอร์เป็นแพ็กเกจ
- [x] อัปโหลดผ่านเว็บ (อนุญาตให้ผู้เยี่ยมชมอัปโหลดได้), ลบ, สร้างโฟลเดอร์, เปลี่ยนชื่อ, ย้าย และคัดลอก
- [x] ดาวน์โหลดแบบออฟไลน์
- [x] คัดลอกไฟล์ระหว่างที่เก็บข้อมูลสองแห่ง
- [x] ดาวน์โหลด/สตรีมแบบมัลติเธรดเพื่อเร่งการดาวน์โหลดแบบเธรดเดียว

## เอกสาร

<https://alistgo.com/>

## ตัวอย่างการใช้งาน

<https://al.nn.ci>

## พูดคุยแลกเปลี่ยน

โปรดไปที่ [ฟอรั่มพูดคุย](https://github.com/alist-org/alist/discussions) สำหรับคำถามทั่วไป **issue ใช้สำหรับรายงานบั๊กและขอฟีเจอร์เท่านั้น**

## สนับสนุนโครงการ

AList เป็นซอฟต์แวร์โอเพ่นซอร์ส หากคุณชื่นชอบโปรเจกต์นี้และต้องการให้ดำเนินต่อไป กรุณาสนับสนุนหรือบริจาคให้ฉัน! ขอบคุณสำหรับทุกความรักและการสนับสนุน:
https://alist.nn.ci/guide/sponsor.html

### ผู้สนับสนุนพิเศษ

- [VidHub](https://apps.apple.com/app/apple-store/id1659622164?pt=118612019&ct=alist&mt=8) - เครื่องเล่นวิดีโอคลาวด์ที่หรูหราสำหรับอุปกรณ์ในระบบ Apple รองรับ iPhone, iPad, Mac และ Apple TV
- [เอเชียคลาวด์](https://www.asiayun.com/aff/QQCOOQKZ) - เซิร์ฟเวอร์ป้องกัน DDoS|ให้เช่าเซิร์ฟเวอร์|ฟูโจว|กวางตุ้ง|ฮ่องกง|อเมริกา|ต่างประเทศ - ผู้ให้บริการคลาวด์ระดับองค์กรที่เชื่อถือได้ในจีน (สนับสนุน API เซิร์ฟเวอร์จีน)
- [找资源](http://zhaoziyuan2.cc/) - เสิร์ชเอนจิ้นค้นหาทรัพยากร Aliyun Drive

## ผู้ร่วมพัฒนา

ขอขอบคุณผู้ร่วมพัฒนาเหล่านี้:

[![Contributors](http://contrib.nn.ci/api?repo=alist-org/alist&repo=alist-org/alist-web&repo=alist-org/docs)](https://github.com/alist-org/alist/graphs/contributors)

## ใบอนุญาต

`AList` เป็นซอฟต์แวร์โอเพ่นซอร์ส ภายใต้สัญญาอนุญาต AGPL-3.0

## ข้อจำกัดความรับผิดชอบ
- โปรแกรมนี้เป็นโปรเจกต์ฟรีและโอเพ่นซอร์ส ถูกออกแบบเพื่อแบ่งปันไฟล์บนคลาวด์ เพื่อความสะดวกในการดาวน์โหลดและเรียนรู้ Golang กรุณาปฏิบัติตามกฎหมายและข้อบังคับที่เกี่ยวข้อง และห้ามนำไปใช้ในทางที่ผิด;
- โปรแกรมนี้ทำงานผ่านการเรียกใช้ sdk/interface อย่างเป็นทางการ โดยไม่ทำลายพฤติกรรมการใช้งานของอินเทอร์เฟซ;
- โปรแกรมนี้ทำเพียงการเปลี่ยนเส้นทาง 302/ส่งต่อทราฟฟิกเท่านั้น ไม่ดักจับ เก็บข้อมูล หรือเปลี่ยนแปลงข้อมูลของผู้ใช้;
- ก่อนใช้งานโปรแกรมนี้ ควรเข้าใจและยอมรับความเสี่ยงที่เกี่ยวข้อง เช่น บัญชีถูกแบน จำกัดความเร็ว ฯลฯ ซึ่งไม่ใช่ความรับผิดชอบของโปรแกรมนี้;
- หากมีการละเมิดสิทธิ์ กรุณาติดต่อผมทาง [email](mailto:i@nn.ci) และจะดำเนินการแก้ไขทันที

---

> [@GitHub](https://github.com/alist-org) · [@TelegramGroup](https://t.me/alist_chat) · [@Discord](https://discord.gg/F4ymsH4xv2)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---