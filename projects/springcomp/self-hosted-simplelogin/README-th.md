
<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=springcomp&project=self-hosted-simplelogin&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# SimpleLogin

นี่คือคอนฟิกูเรชัน docker-compose สำหรับ [SimpleLogin](https://simplelogin.io) ที่โฮสต์ด้วยตนเอง

## ข้อกำหนดเบื้องต้น

- เซิร์ฟเวอร์ Linux (จะเป็น VM หรือเซิร์ฟเวอร์เฉพาะก็ได้) เอกสารนี้จะแสดงวิธีตั้งค่าสำหรับ Ubuntu 18.04 LTS แต่สามารถนำไปประยุกต์ใช้กับดิสทริบิวชัน Linux อื่น ๆ ที่ได้รับความนิยมได้ ส่วนใหญ่ของคอมโพเนนต์จะทำงานในรูปแบบคอนเทนเนอร์ Docker และเนื่องจาก Docker อาจใช้งานทรัพยากรค่อนข้างมาก จึงแนะนำให้มี RAM อย่างน้อย 2 GB เซิร์ฟเวอร์ต้องเปิดพอร์ต 25 (อีเมล), 80, 443 (สำหรับเว็บแอป), 22 (สำหรับ ssh เข้าระบบ)

- โดเมนที่คุณสามารถกำหนดค่า DNS ได้ อาจเป็นซับโดเมนก็ได้ ในส่วนที่เหลือของเอกสารนี้ สมมติว่าเป็น `mydomain.com` สำหรับอีเมล และ `app.mydomain.com` สำหรับ SimpleLogin webapp กรุณาแทนค่าดังกล่าวด้วยชื่อโดเมนและซับโดเมนของคุณทุกครั้งที่ปรากฏในเอกสาร เคล็ดลับที่เราใช้คือดาวน์โหลดไฟล์ README นี้ลงในคอมพิวเตอร์ของคุณแล้วแทนที่ `mydomain.com` และ `app.mydomain.com` ทั้งหมดด้วยโดเมนของคุณ

ยกเว้นการตั้งค่า DNS ซึ่งมักจะทำบนอินเทอร์เฟซของผู้ให้บริการจดทะเบียนโดเมน ขั้นตอนด้านล่างทั้งหมดต้องทำบนเซิร์ฟเวอร์ของคุณ คำสั่งเหล่านี้ต้องรันด้วย `bash` (หรือเชลล์ที่เข้ากันได้กับ bash เช่น `zsh`) หากคุณใช้เชลล์อื่น เช่น `fish` กรุณาปรับคำสั่งให้เหมาะสม

- แพ็คเกจยูทิลิตี้บางตัวที่ใช้ตรวจสอบการตั้งค่า ติดตั้งได้โดย:

```bash
sudo apt update \
  && sudo apt install -y net-tools dnsutils
```

## การตั้งค่า DNS

_ดูรายละเอียดเพิ่มเติมได้ที่ [เอกสารอ้างอิง](https://github.com/springcomp/self-hosted-simplelogin/wiki/DNS-Configuration)_

> **โปรดทราบ** ว่าการเปลี่ยนแปลง DNS อาจใช้เวลาสูงสุดถึง 24 ชั่วโมงในการกระจายข้อมูล อย่างไรก็ตาม ในทางปฏิบัติมักจะเร็วมาก (~1 นาทีในกรณีทดสอบของเรา) ในการตั้งค่า DNS เรามักใช้โดเมนที่ลงท้ายด้วยจุด (`.`) เพื่อบังคับให้ใช้โดเมนแบบสัมบูรณ์

คุณจะต้องตั้งค่าบันทึก DNS ต่อไปนี้:

- **A**: แมปโดเมนของคุณกับที่อยู่ IPv4 ของเซิร์ฟเวอร์
- **AAAA**: แมปโดเมนของคุณกับที่อยู่ IPv6 ของเซิร์ฟเวอร์
- **MX**: กำหนดเส้นทางอีเมลขาเข้าไปยังเมลเซิร์ฟเวอร์ของคุณ (รวมถึง `*` ไวลด์การ์ด)
- **PTR**: แมปที่อยู่ IP ของเซิร์ฟเวอร์กลับไปยังชื่อโดเมนของคุณ

ตั้งค่านโยบายความปลอดภัยที่จำเป็น:

- **DKIM**: ลงลายมือชื่อดิจิทัลในอีเมลขาออกเพื่อยืนยันความถูกต้อง
- **DMARC**: กำหนดวิธีที่ผู้รับอีเมลควรจัดการกับข้อความที่ไม่ผ่านการตรวจสอบ
- **SPF**: อนุญาตให้เซิร์ฟเวอร์เมลที่ระบุส่งอีเมลจากโดเมนของคุณ

ขั้นตอนเพิ่มเติม:

- **CAA**: ระบุว่า CA ใดได้รับอนุญาตให้ออกใบรับรอง SSL ให้กับโดเมนของคุณ
- **MTA-STS**: บังคับให้มีการเชื่อมต่อที่ปลอดภัยและเข้ารหัสระหว่างเมลเซิร์ฟเวอร์
- **TLS-RPT**: รายงานข้อผิดพลาดการเชื่อมต่อ TLS เพื่อเพิ่มความปลอดภัยในการส่งอีเมล

**คำเตือน**: การตั้งค่าบันทึก CAA จะจำกัดว่า CA ใดสามารถออกใบรับรอง SSL ให้กับโดเมนของคุณได้สำเร็จ
ซึ่งจะป้องกันไม่ให้เซิร์ฟเวอร์ Let’s Encrypt ในโหมด staging ออกใบรับรองได้ คุณอาจต้องการเลื่อนการตั้งค่าบันทึก DNS นี้จนกว่าจะออกใบรับรอง SSL ให้กับโดเมนของคุณสำเร็จแล้ว

## Docker

หากคุณยังไม่ได้ติดตั้ง Docker บนเซิร์ฟเวอร์ของคุณ โปรดทำตามขั้นตอนใน [Docker CE for Ubuntu](https://docs.docker.com/v17.12/install/linux/docker-ce/ubuntu/) เพื่อติดตั้ง Docker

คุณยังสามารถติดตั้ง Docker ได้โดยใช้สคริปต์ [docker-install](https://github.com/docker/docker-install) ซึ่งเป็น

```bash
curl -fsSL https://get.docker.com | sh
```

เปิดใช้งาน IPv6 สำหรับ [เครือข่ายบริดจ์เริ่มต้น](https://docs.docker.com/config/daemon/ipv6/#use-ipv6-for-the-default-bridge-network)

```json
{
  "ipv6": true,
  "fixed-cidr-v6": "2001:db8:1::/64",
  "experimental": true,
  "ip6tables": true
}
```
ขั้นตอนนี้จะแนะนำวิธีการรันทั้งสแตกโดยใช้ Docker containers  
ซึ่งประกอบด้วย:

- traefik
- [SimpleLogin app](https://github.com/simple-login/app) containers
- postfix

รัน SimpleLogin จาก Docker containers:

1. โคลน repository นี้ไปที่ `/opt/simplelogin`
1. คัดลอก `.env.example` ไปเป็น `.env` และตั้งค่าตัวแปรให้เหมาะสม

    - ตั้งค่าตัวแปร `DOMAIN` เป็นโดเมนของคุณ
    - ตั้งค่าตัวแปร `SUBDOMAIN` เป็นซับโดเมนของคุณ โดยค่าเริ่มต้นคือ `app`
    - ตั้งค่าตัวแปร `POSTGRES_USER` ให้ตรงกับข้อมูลผู้ใช้ postgres (หากเริ่มใหม่ ให้ใช้ `simplelogin`)
    - ตั้งค่าตัวแปร `POSTGRES_PASSWORD` ให้ตรงกับรหัสผ่าน postgres (หากเริ่มใหม่ ให้กำหนดเป็นคีย์สุ่ม)
    - ตั้งค่าตัวแปร `FLASK_SECRET` เป็นรหัสลับใดๆ ก็ได้

### Postgres SQL

repository นี้จะรัน postgres SQL ใน Docker container

**คำเตือน**: repository เวอร์ชันก่อนหน้านี้ใช้เวอร์ชัน `12.1`  
โปรดดู [เอกสารอ้างอิง](https://github.com/springcomp/self-hosted-simplelogin/wiki/PostgreSQL) สำหรับรายละเอียดเพิ่มเติมและ  
คำแนะนำในการอัปเกรด

### การรันแอปพลิเคชัน

รันแอปพลิเคชันด้วยคำสั่งดังต่อไปนี้:


```sh
docker compose up --detach --remove-orphans --build && docker compose logs -f
```
คุณอาจต้องการตั้งค่า [Certificate Authority Authorization (CAA)](https://github.com/springcomp/self-hosted-simplelogin/wiki/dns-caa) ในขั้นตอนนี้

## ขั้นตอนถัดไป

หากทุกขั้นตอนข้างต้นสำเร็จ ให้เปิด <https://app.mydomain.com/> และสร้างบัญชีแรกของคุณ!

โดยปกติแล้วบัญชีใหม่จะไม่ใช่บัญชีแบบพรีเมียม ดังนั้นจะไม่สามารถมีนามแฝงได้ไม่จำกัด หากต้องการเปลี่ยนบัญชีของคุณเป็นพรีเมียม
โปรดไปที่ฐานข้อมูล ตาราง "users" และตั้งค่าคอลัมน์ "lifetime" เป็น "1" หรือ "TRUE":


```bash
docker compose exec -it postgres psql -U myuser simplelogin
> UPDATE users SET lifetime = TRUE;
> \q
```

เมื่อคุณสร้างบัญชีเข้าสู่ระบบที่ต้องการทั้งหมดแล้ว ให้เพิ่มบรรทัดเหล่านี้ลงใน `.env` เพื่อปิดการลงทะเบียนเพิ่มเติม:

```env
DISABLE_REGISTRATION=1
DISABLE_ONBOARDING=true
```
จากนั้น เพื่อเริ่มต้นเว็บแอปใหม่ ให้ใช้คำสั่ง: `docker compose restart app`

## เบ็ดเตล็ด

### การตั้งค่า Postfix - Spamhaus

โครงการ Spamhaus ดูแลรายชื่อ IP ที่เป็นแหล่งของสแปมอย่างเชื่อถือได้
คุณสามารถตรวจสอบว่า IP ที่กำหนดอยู่ในรายชื่อนี้หรือไม่โดยส่งคำขอไปยังโครงสร้าง DNS

เนื่องจาก Spamhaus บล็อกคำขอจาก DNS-Resolver สาธารณะ (เปิด) (ดู: <https://check.spamhaus.org/returnc/pub>) และคอนเทนเนอร์ postfix ของคุณอาจใช้
รีโซลเวอร์สาธารณีโดยค่าเริ่มต้น แนะนำให้สมัครใช้บริการ
[Spamhaus Data Query Service](https://www.spamhaus.com/free-trial/sign-up-for-a-free-data-query-service-account/)
และรับคีย์ Spamhaus DQS

วางคีย์นี้เป็น `SPAMHAUS_DQS_KEY` ในไฟล์ `.env` ของคุณ

หากไม่มี DQS-key คอนเทนเนอร์ postfix ของคุณจะตรวจสอบว่ามิเรอร์สาธารณะของ Spamhaus ยอมรับคำขอหรือไม่และจะใช้มิเรอร์เหล่านั้นแทน
หาก Spamhaus ปฏิเสธคำขอจากคอนเทนเนอร์ postfix ของคุณไปยังมิเรอร์สาธารณะ ระบบจะถูกปิดใช้งานทั้งหมด

### การตั้งค่า Postfix - Virtual aliases

การตั้งค่า postfix รองรับ virtual aliases โดยใช้ไฟล์ `postfix/conf.d/virtual` และ `postfix/conf.d/virtual-regexp`
ไฟล์เหล่านี้จะถูกสร้างขึ้นโดยอัตโนมัติเมื่อเริ่มต้นขึ้นตามไฟล์ต้นแบบ [`postfix/templates/virtual.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual.tpl)
และ [`postfix/templates/virtual-regexp.tpl`](https://raw.githubusercontent.com/springcomp/self-hosted-simplelogin/main/./postfix/templates/virtual-regexp.tpl)

การตั้งค่าเริ่มต้นเป็นดังนี้:

#### virtual.tpl

ไฟล์ `virtual` รองรับการตั้งค่า postfix `virtual_alias_maps`
ไฟล์นี้มีการกำหนด rule ที่แมป `unknown@mydomain.com` ไปยัง `contact@mydomain.com` เพื่อแสดงตัวอย่างการรับ
อีเมลจากที่อยู่เฉพาะที่ไม่ตรงกับ alias ที่มีอยู่ ไปยัง alias ที่มีอยู่


```postfix-conf
unknown@mydomain.com  contact@mydomain.com
```

#### virtual-regexp.tpl

ไฟล์ `virtual-regexp` รองรับการตั้งค่า `virtual_alias_maps` ของ postfix
มันมีการกำหนดกฎที่เขียนใหม่อีเมลที่ถูกส่งถึงซับโดเมนใด ๆ ที่ไม่มี alias ที่มีอยู่
ไปยัง alias ใหม่ที่อยู่ในไดเรกทอรีซึ่งชื่อถูกนำมาจากซับโดเมนนั้น
alias ดังกล่าวอาจถูกสร้างขึ้นทันทีหากยังไม่มีอยู่

```postfix-conf
/^([^@]+)@([^.]+)\.mydomain.com/   $2/$1@mydomain.com
```

ตัวอย่างเช่น อีเมลที่ส่งไปยัง `someone@directory.mydomain.com` จะถูกเปลี่ยนเส้นทางไปยัง `directory/someone@mydomain.com` โดย postfix

## วิธีอัปเกรดจาก 3.4.0

_ส่วนนี้ถูกย้ายไปยัง [เอกสารอ้างอิง](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-sl)_

## วิธีอัปเกรดจากการตั้งค่าแบบ NGinx ก่อนหน้า

_ส่วนนี้ถูกย้ายไปยัง [เอกสารอ้างอิง](https://github.com/springcomp/self-hosted-simplelogin/wiki/upgrade-from-nginx)_


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-15

---