# 🍡 scoop-proxy-cn

เหมาะสำหรับผู้ใช้ในจีนแผ่นดินใหญ่ที่ใช้ [Scoop](https://scoop.sh) buckets โปรเจกต์กระจก proxy mirror library ที่ซิงโครไนส์อัพเดตจากหลาย `bucket` ที่เป็นโอเพนซอร์ส ซึ่งประกอบด้วย:

- สาขา `sync` (ค่าเริ่มต้น): ซิงโครไนส์แอปจากหลายรีโป แต่ไม่ทำการแก้ไข proxy ghproxy ใดๆ **เหมาะสำหรับสถานการณ์ที่ใช้ scoop เวอร์ชันแก้ไขในจีนบน gitee**
- สาขา `main`: แก้ไขที่อยู่ดาวน์โหลดแอปจาก `github release` ให้ใช้ที่อยู่ proxy ดาวน์โหลดผ่าน `https://ghfast.top` แทน **เนื่องจากที่อยู่ proxy มักเปลี่ยนแปลงบ่อยและไม่เสถียร**

## การใช้งาน

เพิ่ม repository แอป `spc` ใช้งานร่วมกับ [scoop 镜像优化库](https://gitee.com/scoop-installer/scoop) สำหรับในจีน:

```bash
# เพิ่ม bucket โดยดึงสาขา sync เป็นค่าเริ่มต้น
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# ติดตั้งแอป
scoop install spc/<app_name>
```

ถ้าต้องการใช้ Scoop เวอร์ชันทางการเท่านั้น ให้เปลี่ยนสาขาที่ subscribe เป็น `main` ดังนี้:

```bash
# เข้าไปยังโฟลเดอร์ spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# หากตั้งตัวแปรสภาพแวดล้อม SCOOP ไว้ ให้ใช้คำสั่งนี้แทน
cd "$env:SCOOP\buckets\spc"

# สลับไปสาขา main
git fetch --all
git checkout -b main origin/main
```

## การติดตั้งและตั้งค่า Scoop

### วิธีที่ 1: ติดตั้งโดยใช้镜像定制ในประเทศ (แนะนำ)

เนื่องจากซอร์สโค้ดและ buckets ของ scoop ส่วนใหญ่เก็บไว้บน GitHub ซึ่งเข้าถึงยากในจีน การติดตั้ง อัพเดต และดาวน์โหลดแอปจึงมีประสบการณ์ใช้งานไม่ดี

ต่อไปนี้คือวิธีติดตั้งสำหรับ [scoop 国内镜像优化库](https://gitee.com/scoop-installer/scoop)

```bash
# เปลี่ยนนโยบายสคริปต์ให้อนุญาตอัตโนมัติ
Set-ExecutionPolicy RemoteSigned -scope CurrentUser -Force

# วิธีที่ 1: รันคำสั่งติดตั้ง (ติดตั้งในโฟลเดอร์ผู้ใช้เป็นค่าเริ่มต้น ถ้าต้องการเปลี่ยนโฟลเดอร์ให้ใช้คำสั่ง "กำหนดโฟลเดอร์ติดตั้ง" ด้านล่าง)
iwr -useb scoop.201704.xyz | iex


## วิธีที่ 2: กำหนดโฟลเดอร์ติดตั้งเอง (แก้ไขพาธให้เหมาะสม)
irm scoop.201704.xyz -outfile 'install.ps1'
.\install.ps1 -ScoopDir 'D:\Scoop' -ScoopGlobalDir 'D:\GlobalScoopApps'

# ถ้าติดตั้งแหล่งทางการไว้แล้ว สามารถเปลี่ยนเป็น镜像国内ได้ด้วยคำสั่งนี้
scoop config SCOOP_REPO "https://gitee.com/scoop-installer/scoop"

# เพิ่ม bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git

# อัพเดตที่เก็บข้อมูล
scoop update
```

 Scoop ที่ติดตั้งด้วยวิธีนี้จะถูกแก้ไขให้รองรับการกำหนด proxy เร่งความเร็ว และใช้ `scoop.201704.xyz` เป็น proxy ดาวน์โหลดแอปโดยอัตโนมัติ

```bash
# ตั้งค่า proxy
scoop config URL_PROXY "https://scoop.201704.xyz"

# ลบ proxy
scoop config rm URL_PROXY
```

### วิธีที่ 2: ติดตั้งแบบ proxy บนรีโปทางการ

เปิด `PowerShell` แล้วรันคำสั่งต่อไปนี้เพื่อติดตั้ง:

```bash
# ตั้งค่านโยบายสคริปต์
Set-ExecutionPolicy -ExecutionPolicy RemoteSigned -Scope CurrentUser
# irm -useb get.scoop.sh | iex
irm https://ghfast.top/raw.githubusercontent.com/lzwme/scoop-proxy-cn/main/install.ps1 | iex

# ตั้งค่า
scoop config SCOOP_REPO https://ghfast.top/github.com/ScoopInstaller/Scoop

# เพิ่ม bucket spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
# เข้าโฟลเดอร์ spc
cd "$env:USERPROFILE\scoop\buckets\spc"
# สลับไปสาขา main
git fetch --all && git checkout -b main origin/main

# แสดงคำสั่งช่วยเหลือ
scoop help

# ติดตั้ง 7zip, aria2, scoop-search...
scoop install spc/7zip spc/aria2 spc/scoop-search
```

### เกี่ยวกับ `scoop-search`

เนื่องจาก `scoop-proxy-cn` ซิงโครไนส์แอปกว่า `1.4w+` ตัว คำสั่ง `scoop search` ที่เขียนด้วย `PowerShell` ของทางการจึงทำงานช้าและไม่สะดวก จึงแนะนำให้ติดตั้งและใช้เครื่องมือ `scoop-search` ที่เขียนด้วย `go` แทน ตัวอย่าง:

```bash
scoop install scoop-search
# ใช้งาน scoop-search
scoop-search act
```

## ปัญหาที่พบบ่อย

### ปัญหาการดาวน์โหลดล้มเหลวเมื่อใช้ `aria2`

เมื่อมีการติดตั้ง `aria2` scoop จะใช้ aria2 เพื่อดาวน์โหลดแบบแบ่งส่วนเพื่อเร่งความเร็ว แต่บาง proxy ไม่รองรับหรือบล็อกการดาวน์โหลดแบบแบ่งส่วนของ aria2 ถ้าเจอปัญหานี้ให้ปิด aria2 ด้วยคำสั่ง:

```bash
scoop config aria2-enabled false
```

### ปัญหา `Hash Check Failed`

บางแอปกำหนดที่อยู่ดาวน์โหลดเป็นลิงก์เวอร์ชันล่าสุดแต่ยังตั้งค่า hash ไว้ ทำให้เมื่อมีอัพเดตจะเกิดปัญหา Hash Check Failed ให้ติดตั้งพร้อมพารามิเตอร์ `-s` เพื่อข้ามการตรวจสอบ hash เช่น:

```bash
scoop install scoop-search -s
```

### วิธีแก้ปัญหาเมื่อ proxy หมดอายุและต้องอัพเดต

เมื่อใช้ Scoop เวอร์ชันทางการและ subscribe สาขา `main` จะใช้ proxy เร่งความเร็วสำหรับ git repo และดาวน์โหลดแอป แต่ถ้า proxy เก่าหมดอายุจะทำให้ไม่สามารถอัพเดตได้ ให้รันคำสั่งดังนี้เพื่อตั้งค่าใหม่:

```bash
# อัพเดต scoop repo
scoop config scoop_repo https://ghfast.top/github.com/ScoopInstaller/Scoop.git

# วิธีที่ 1: อัพเดต repo ของ spc bucket
git -C "$env:USERPROFILE\scoop\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git
# หากเปลี่ยนพาธ buckets ให้รันคำสั่งนี้แทน
git -C "$env:SCOOP\buckets\spc" remote set-url origin https://gitee.com/wlzwme/scoop-proxy-cn.git

# วิธีที่ 2: ลบแล้วเพิ่ม spc bucket ใหม่
scoop bucket rm spc
scoop bucket add spc https://gitee.com/wlzwme/scoop-proxy-cn.git
```

## ซิงโครไนส์ Buckets จาก

- [ScoopInstaller/PHP](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/PHP)
- [ScoopInstaller/Main](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Main)
- [ScoopInstaller/Extras](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Extras)
- [ScoopInstaller/Java](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Java)
- [ScoopInstaller/Versions](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Versions)
- [ScoopInstaller/Nirsoft](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Nirsoft)
- [ScoopInstaller/Nonportable](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ScoopInstaller/Nonportable)
- [renxia/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/renxia/scoop-bucket)
- [scoopcn/scoopcn](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/scoopcn/scoopcn)
- [rasa/scoops](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/rasa/scoops)
- [amorphobia/siku](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/amorphobia/siku)
- [ACooper81/scoop-apps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ACooper81/scoop-apps)
- [kkzzhizhou/scoop-zapps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kkzzhizhou/scoop-zapps)
- [Calinou/scoop-games](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Calinou/scoop-games)
- [cderv/r-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/cderv/r-bucket)
- [chawyehsu/dorado](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/chawyehsu/dorado)
- [borger/scoop-galaxy-integrations](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/borger/scoop-galaxy-integrations)
- [ivaquero/scoopet](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ivaquero/scoopet)
- [KNOXDEV/wsl](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/KNOXDEV/wsl)
- [kodybrown/scoop-nirsoft](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kodybrown/scoop-nirsoft)
- [kidonng/sushi](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kidonng/sushi)
- [littleli/scoop-clojure](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/littleli/scoop-clojure)
- [niheaven/scoop-sysinternals](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/niheaven/scoop-sysinternals)
- [matthewjberger/scoop-nerd-fonts](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/matthewjberger/scoop-nerd-fonts)
- [TheCjw/scoop-retools](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheCjw/scoop-retools)
- [TheRandomLabs/Scoop-Bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Bucket)
- [TheRandomLabs/scoop-nonportable](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/scoop-nonportable)
- [TheRandomLabs/Scoop-Spotify](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Spotify)
- [Paxxs/Cluttered-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Paxxs/Cluttered-bucket)
- [zhoujin7/tomato](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/zhoujin7/tomato)
- [HCLonely/my-scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/HCLonely/my-scoop-bucket)
- [Weidows-projects/scoop-3rd](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/Weidows-projects/scoop-3rd)
- [hermanjustnu/scoop-emulators](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/hermanjustnu/scoop-emulators)
- [everyx/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/everyx/scoop-bucket)
- [borger/scoop-emulators](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/borger/scoop-emulators)
- [ZvonimirSun/scoop-iszy](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ZvonimirSun/scoop-iszy)
- [kiennq/scoop-misc](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/kiennq/scoop-misc)
- [wzv5/ScoopBucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/wzv5/ScoopBucket)
- [TheRandomLabs/Scoop-Python](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/TheRandomLabs/Scoop-Python)
- [naderi/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/naderi/scoop-bucket)
- [ViCrack/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ViCrack/scoop-bucket)
- [42wim/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/42wim/scoop-bucket)
- [akirco/aki-apps](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/akirco/aki-apps)
- [batkiz/backit](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/batkiz/backit)
- [iquiw/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/iquiw/scoop-bucket)
- [ygguorun/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/ygguorun/scoop-bucket)
- [seumsc/scoop-seu](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/seumsc/scoop-seu)
- [cc713/ownscoop](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/cc713/ownscoop)
- [aoisummer/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/aoisummer/scoop-bucket)
- [yuusakuri/scoop-bucket](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/yuusakuri/scoop-bucket)
- [hu3rror/scoop-muggle](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/hu3rror/scoop-muggle)
- [starise/Scoop-Confetti](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/starise/Scoop-Confetti)
- [dodorz/scoop](https://raw.githubusercontent.com/lzwme/scoop-proxy-cn/sync/dodorz/scoop)
- [SayCV/scoop-cvp](https://github.com/SayCV/scoop-cvp)
- [Qv2ray/mochi](https://github.com/Qv2ray/mochi)
- [Homeland-Community/scoop](https://github.com/Homeland-Community/scoop)
- [jingyu9575/scoop-jingyu9575](https://github.com/jingyu9575/scoop-jingyu9575)
- [couleur-tweak-tips/utils](https://github.com/couleur-tweak-tips/utils)
- [wangzq/scoop-bucket](https://github.com/wangzq/scoop-bucket)
- [jonz94/scoop-sarasa-nerd-fonts](https://github.com/jonz94/scoop-sarasa-nerd-fonts)
- [NyaMisty/scoop_bucket_misty](https://github.com/NyaMisty/scoop_bucket_misty)
- [jfut/scoop-jfut](https://github.com/jfut/scoop-jfut)
- [mogeko/scoop-sysinternals](https://github.com/mogeko/scoop-sysinternals)
- [ChungZH/peach](https://github.com/ChungZH/peach)
- [DoveBoy/Apps](https://github.com/DoveBoy/Apps)
- [Velgus/Scoop-Portapps](https://github.com/Velgus/Scoop-Portapps)
- [starise/Scoop-Gaming](https://github.com/starise/Scoop-Gaming)
- [mo-san/scoop-bucket](https://github.com/mo-san/scoop-bucket)
- [brian6932/dank-scoop](https://github.com/brian6932/dank-scoop)
- [AkariiinMKII/Scoop4kariiin](https://github.com/AkariiinMKII/Scoop4kariiin)
- [littleli/Scoop-littleli](https://github.com/littleli/Scoop-littleli)
- [ChinLong/scoop-customize](https://github.com/ChinLong/scoop-customize)
- [Darkatse/Scoop-KanColle](https://github.com/Darkatse/Scoop-KanColle)
- [aliesbelik/poldi](https://github.com/aliesbelik/poldi)
- [MCOfficer/scoop-bucket](https://github.com/MCOfficer/scoop-bucket)
- [KnotUntied/scoop-fonts](https://github.com/KnotUntied/scoop-fonts)
- [beerpiss/scoop-bucket](https://github.com/beerpiss/scoop-bucket)
- [HUMORCE/nuke](https://github.com/HUMORCE/nuke)
- [AkinoKaede/maple](https://github.com/AkinoKaede/maple)
- [hulucc/bucket](https://github.com/hulucc/bucket)
- [Deide/deide-bucket](https://github.com/Deide/deide-bucket)
- [echoiron/echo-scoop](https://github.com/echoiron/echo-scoop)
- [tetradice/scoop-iyokan-jp](https://github.com/tetradice/scoop-iyokan-jp)

## คำชี้แจง

> [!WARNING]
> ที่เก็บข้อมูลนี้ประกอบด้วยข้อมูลแอปพลิเคชันที่ซิงค์มาจากที่เก็บข้อมูลของบุคคลที่สามเท่านั้น ไม่มีการตรวจสอบความใช้งานได้หรือความปลอดภัยอย่างละเอียด กรุณาตรวจสอบและระบุความถูกต้องด้วยตนเองเมื่อเลือกติดตั้ง หากมีการละเมิดลิขสิทธิ์ กรุณาส่งประเด็น (issues) เพื่อดำเนินการแก้ไข

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---