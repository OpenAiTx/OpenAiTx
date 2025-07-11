# 🎫 BiliTickerStorm

## ⚙️ คำอธิบายบริการ

| ชื่อบริการ             | คำอธิบาย              | หมายเหตุ    |
| --------------- | --------------- | ----- |
| `ticket-master` | บริการควบคุมหลัก รับผิดชอบการจัดสรรงาน     | ติดตั้งเดี่ยว |
| `ticket-worker` | worker สำหรับจองตั๋ว ขยายตามแนวราบได้ | รองรับหลายอินสแตนซ์ |
| `gt-python`     | บริการประมวลผล captcha ภาพ       | ติดตั้งเดี่ยว |

---

## 🚀 ขั้นตอนการติดตั้งอย่างรวดเร็ว

> การตั้งค่าคลัสเตอร์สามารถดูได้ที่ [คู่มือการตั้งค่าคลัสเตอร์](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md)

<details> <summary><strong>📦 ติดตั้งจากรีโมทรีโพซิทอรี (แนะนำ)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. ติดตั้ง Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` คือไดเรกทอรีไฟล์คอนฟิกสำหรับการจองตั๋ว จะถูก mount ให้กับคอนเทนเนอร์ `ticket-master` ไฟล์คอนฟิกสำหรับการจองตั๋วสามารถสร้างได้ที่ https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` คือการตั้งค่าการแจ้งเตือนผ่าน pushplus กำหนดค่านี้เพื่อรับการแจ้งเตือนผลการจองตั๋ว
> - `ticketWorker.ticketInterval` คือช่วงเวลาระหว่างการจองตั๋ว หน่วยเป็นมิลลิวินาที ค่าเริ่มต้น 300 มิลลิวินาที
> - `ticketWorker.ticketTimeStart` คือเวลาที่จะเริ่มต้นการจองตั๋วโดยอัตโนมัติ รูปแบบคือ `2025-05-20T13:14` หากไม่ระบุจะเริ่มจองตั๋วทันทีเมื่อเปิดคอนเทนเนอร์

### 3. อัปเกรด Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
---
</details> 
<details> <summary><strong>📦 การติดตั้ง Chart ในเครื่อง</strong></summary>


### 1. ติดตั้ง Chart

```bash
# โคลนรีโพซิทอรี
git clone https://github.com/mikumifa/biliTickerStorm
# ใช้แพ็กเกจ Chart ในเครื่อง
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. อัปเกรด Chart

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 คำสั่งทั่วไป</strong></summary>

### ⏹ ถอนการติดตั้ง
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 ข้อจำกัดความรับผิดชอบ

โครงการนี้ปฏิบัติตามข้อตกลงอนุญาตใช้ MIT License สำหรับการเรียนรู้และวิจัยส่วนบุคคลเท่านั้น โปรดอย่านำโครงการนี้ไปใช้เพื่อแสวงหากำไรในเชิงพาณิชย์ และห้ามใช้สำหรับการซื้อขายล่วงหน้า การกระทำผิดกฎหมาย หรือการใช้งานที่ฝ่าฝืนกฎระเบียบของแพลตฟอร์มที่เกี่ยวข้อง ผลกระทบใด ๆ ที่เกิดขึ้นจากการใช้งานถือเป็นความรับผิดชอบของผู้ใช้แต่เพียงผู้เดียว ไม่เกี่ยวข้องกับผู้พัฒนาแต่อย่างใด

หากคุณ fork หรือใช้งานโครงการนี้ กรุณาปฏิบัติตามกฎหมายที่เกี่ยวข้องและกฎระเบียบของแพลตฟอร์มเป้าหมายอย่างเคร่งครัด

## 💡 เกี่ยวกับความถี่ในการเข้าถึงและการควบคุมการทำงานพร้อมกัน
โครงการนี้ถูกออกแบบโดยยึดหลักการ "ไม่รบกวน" อย่างเคร่งครัด เพื่อหลีกเลี่ยงการรบกวนเซิร์ฟเวอร์เป้าหมาย (เช่น Bilibili)

ช่วงเวลาระหว่างการร้องขอผ่านเครือข่ายทั้งหมดสามารถกำหนดค่าโดยผู้ใช้เอง ค่าเริ่มต้นจะจำลองความเร็วในการดำเนินการด้วยมือของผู้ใช้ปกติ โปรแกรมจะทำงานแบบเธรดเดียวโดยค่าเริ่มต้น ไม่มีการทำงานพร้อมกัน หากพบข้อผิดพลาดในการร้องขอ โปรแกรมจะลองใหม่จำนวนจำกัดครั้ง และจะมีการหน่วงเวลาก่อนลองใหม่แต่ละครั้งเพื่อหลีกเลี่ยงการส่งคำขอบ่อยเกินไป โครงการนี้ใช้เฉพาะอินเทอร์เฟซสาธารณะและโครงสร้างหน้าเว็บของแพลตฟอร์มโดยสมบูรณ์ ไม่รวมวิธีการหลีกเลี่ยงระบบควบคุมความเสี่ยง การดักจับ API หรือวิธีการที่เป็นอันตรายอื่น ๆ
## 🛡️ คำประกาศเคารพต่อแพลตฟอร์ม

โปรแกรมนี้ได้รับการออกแบบโดยพยายามควบคุมความถี่ของการร้องขอให้มากที่สุดเท่าที่จะทำได้ เพื่อหลีกเลี่ยงการสร้างภาระหรือผลกระทบที่เห็นได้ชัดต่อเซิร์ฟเวอร์ของ Bilibili โครงการนี้จัดทำขึ้นเพื่อการศึกษาเท่านั้น ไม่รองรับการใช้งานในระดับใหญ่หรือการประมวลผลพร้อมกันจำนวนมาก และไม่มีเจตนาร้ายหรือความพยายามใด ๆ ที่จะรบกวนบริการ

หากโครงการนี้มีเนื้อหาที่ละเมิดสิทธิ์อันชอบธรรมของบริษัท Bilibili กรุณาติดต่อผ่านอีเมล [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com) ผมจะดำเนินการนำเนื้อหาที่เกี่ยวข้องออกและลบคลังนี้ทันที ขออภัยในความไม่สะดวกที่อาจเกิดขึ้น และขอขอบคุณในความเข้าใจและความกรุณาของคุณ

## 📄 สัญญาอนุญาต

[MIT License](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---