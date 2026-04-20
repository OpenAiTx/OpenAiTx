<div align="right">
  <details>
    <summary >🌐 ภาษา</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=it">Italiano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=CodeWithCJ&project=SparkyFitness&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

# SparkyFitness

แพลตฟอร์มทางเลือกแบบโฮสต์เองที่เน้นความเป็นส่วนตัวสำหรับ MyFitnessPal ติดตามโภชนาการ การออกกำลังกาย ข้อมูลร่างกาย และสุขภาพ โดยคุณสามารถควบคุมข้อมูลของคุณได้อย่างเต็มที่

![Screenshot](https://raw.githubusercontent.com/CodeWithCJ/SparkyFitness/main/docs/public/web_screenshot.png)

SparkyFitness คือแพลตฟอร์มติดตามสุขภาพที่โฮสต์เอง ประกอบด้วย:

- เซิร์ฟเวอร์ backend (API + การจัดเก็บข้อมูล)
- ส่วนหน้าแบบเว็บ
- แอปมือถือเนทีฟสำหรับ iOS และ Android

จัดเก็บและจัดการข้อมูลสุขภาพบนโครงสร้างพื้นฐานที่คุณควบคุมได้ โดยไม่ต้องพึ่งพาบริการจากบุคคลที่สาม

## ฟีเจอร์หลัก

- ติดตามโภชนาการ การออกกำลังกาย การดื่มน้ำ การนอนหลับ การอดอาหาร อารมณ์ และการวัดร่างกาย
- กำหนดเป้าหมายและเช็คอินประจำวัน
- กราฟโต้ตอบและรายงานระยะยาว
- โปรไฟล์ผู้ใช้หลายคนและการเข้าถึงสำหรับครอบครัว
- ธีมสีสว่างและสีเข้ม
- OIDC, TOTP, Passkey, MFA ฯลฯ

## การเชื่อมต่อสุขภาพและอุปกรณ์

SparkyFitness สามารถซิงค์ข้อมูลจากแพลตฟอร์มสุขภาพและฟิตเนสหลายแห่ง:

- **Apple Health** (iOS)
- **Google Health Connect** (Android)
- **Fitbit**
- **Garmin Connect**
- **Withings**
- **Polar Flow** (ทดสอบบางส่วน)
- **Hevy** (ยังไม่ได้ทดสอบ)
- **OpenFoodFacts**
- **USDA**
- **Fatsecret**
- **Nutritioninx**
- **Mealie**
- **Tandoor**
- **Strava** (ทดสอบบางส่วน)

การเชื่อมต่อจะซิงค์ข้อมูลกิจกรรมโดยอัตโนมัติ เช่น จำนวนก้าว การออกกำลังกาย และการนอนหลับ พร้อมกับข้อมูลสุขภาพ เช่น น้ำหนักและการวัดร่างกาย ไปยังเซิร์ฟเวอร์ SparkyFitness ของคุณ

## ฟีเจอร์ AI เสริม (เบต้า)

SparkyAI มีอินเทอร์เฟซสนทนาเพื่อบันทึกข้อมูลและตรวจสอบความคืบหน้า

- บันทึกอาหาร ออกกำลังกาย สถิติร่างกาย และก้าวเดินผ่านแชท
- อัปโหลดรูปอาหารเพื่อบันทึกมื้ออาหารโดยอัตโนมัติ
- เก็บประวัติการสนทนาเพื่อใช้งานต่อเนื่อง

หมายเหตุ: ฟีเจอร์ AI ขณะนี้อยู่ในช่วงเบต้า

## เริ่มต้นอย่างรวดเร็ว (เซิร์ฟเวอร์)

เริ่มต้นใช้งานเซิร์ฟเวอร์ SparkyFitness ภายในไม่กี่นาทีด้วย Docker Compose

```bash
# 1. Create a new folder
mkdir sparkyfitness && cd sparkyfitness

# 2. Download Docker files only
curl -L -o docker-compose.yml https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/docker-compose.prod.yml
curl -L -o .env https://github.com/CodeWithCJ/SparkyFitness/releases/latest/download/default.env.example

# 3. (Optional) Edit .env to customize database credentials, ports, etc.

# 4. Start the app
docker compose pull && docker compose up -d

# Access application at http://localhost:8080
```

## 🎥 วิดีโอสอนการใช้งาน

[![ดูวิดีโอ](https://img.youtube.com/vi/B13IiL2DeQc/maxresdefault.jpg)](https://www.youtube.com/watch?v=B13IiL2DeQc)

วิดีโอสอนสั้นๆ 2 นาที แสดงวิธีติดตั้ง SparkyFitness (เครื่องติดตามฟิตเนสแบบโฮสต์เอง)



## เอกสารประกอบ

สำหรับคู่มือการติดตั้งแบบเต็ม ตัวเลือกการตั้งค่า และเอกสารสำหรับนักพัฒนา กรุณาเยี่ยมชม [เว็บไซต์เอกสารของเรา](https://codewithcj.github.io/SparkyFitness/)

### ลิงก์ด่วน

- **[คู่มือติดตั้ง](https://codewithcj.github.io/SparkyFitness/install/docker-compose)** - การปรับใช้และการตั้งค่าต่างๆ
- **[ภาพรวมฟีเจอร์](https://codewithcj.github.io/SparkyFitness/features)** - เอกสารฟีเจอร์อย่างครบถ้วน
- **[กระบวนการพัฒนา](https://codewithcj.github.io/SparkyFitness/developer/getting-started)** - คู่มือสำหรับนักพัฒนาและกระบวนการร่วมพัฒนา
- **[ข้อมูลแอพ iOS](https://github.com/CodeWithCJ/SparkyFitness/wiki/Apple-Health-Integration)** และ **[ข้อมูลแอพ Android](https://github.com/CodeWithCJ/SparkyFitness/wiki/Android-Mobile-App)**

### ต้องการความช่วยเหลือ?

- โพสต์ในหัวข้อปัญหาหรือการพูดคุยใน Github
- หากต้องการการตอบกลับที่รวดเร็วและรับความช่วยเหลือจากสมาชิกชุมชนคนอื่นๆ **[เข้าร่วม Discord ของเรา](https://discord.gg/vcnMT5cPEA)**

## ประวัติการกดดาว

<a href="https://star-history.com/#CodeWithCJ/SparkyFitness&Date">
  <picture>
    <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date&theme=dark" />
    <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" />
    <img alt="Star History Chart" src="https://api.star-history.com/svg?repos=CodeWithCJ/SparkyFitness&type=Date" width="100%" />
  </picture>
</a>

## การแปลภาษา

**[การแปลบน Weblate](https://hosted.weblate.org/engage/sparkyfitness)**

<a href="https://hosted.weblate.org/engage/sparkyfitness/">
<img src="https://hosted.weblate.org/widget/sparkyfitness/sparkyfitness-translations/multi-auto.svg" alt="สถานะการแปล" />
</a>

## กิจกรรมของคลังเก็บ

![Alt](https://repobeats.axiom.co/api/embed/828203d3070ff56c8873c727b6873b684c4ed399.svg "ภาพวิเคราะห์ Repobeats")

## ผู้ร่วมพัฒนา

<a href="https://github.com/CodeWithCJ/SparkyFitness/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CodeWithCJ/SparkyFitness" width="100%"/>
</a>

## ⚠️ ปัญหาที่ทราบแล้ว / ฟีเจอร์เบต้า ⚠️

SparkyFitness กำลังอยู่ระหว่างการพัฒนาอย่างต่อเนื่อง
อาจมีการเปลี่ยนแปลงที่ส่งผลกระทบระหว่างแต่ละเวอร์ชัน

- ไม่แนะนำให้ใช้การอัปเดตคอนเทนเนอร์แบบอัตโนมัติ
- ควรตรวจสอบบันทึกการปล่อยทุกครั้งก่อนการอัปเกรด

ฟีเจอร์ต่อไปนี้ยังอยู่ในสถานะเบต้าและอาจยังไม่ได้รับการทดสอบอย่างละเอียด คาดว่าจะพบข้อบกพร่องหรือฟังก์ชันที่ไม่สมบูรณ์:

- AI Chatbot
- การเข้าถึงสำหรับครอบครัว & เพื่อน
- เอกสาร API


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---