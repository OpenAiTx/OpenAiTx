# KestrelApp
ตัวอย่างการเขียนโปรแกรมเครือข่ายโดยใช้ Kestrel

### 1 วัตถุประสงค์ของโครงการ
1. เข้าใจว่าการเขียนโปรแกรมเครือข่ายไม่จำเป็นต้องเริ่มต้นจาก Socket อีกต่อไป
2. เข้าใจว่าการเขียนโปรแกรมเครือข่ายไม่จำเป็นต้องใช้เฟรมเวิร์คของบุคคลที่สาม (รวมถึง Dotnetty)
3. เข้าใจการเขียนโปรแกรมเครือข่ายแบบซ้อนชั้น เช่น `telnet` บน `websocket` บน `tls` บน `xxx การเข้ารหัสแบบกำหนดเอง` บน `tcp`
4. สามารถพัฒนาแอปพลิเคชันเครือข่ายโดยใช้ KestrelFramework

### 2 เอกสารข้อมูล
**เอกสารภายใน**：[docs](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/docs)

**เอกสารภายนอก**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
ไลบรารีพื้นฐานที่จำเป็นบางส่วนสำหรับการเขียนโปรแกรมเครือข่ายด้วย kestrel
1. อินเทอร์เฟซ Middleware ของ Kestrel และการลงทะเบียนกลาง
2. System.Buffers: คลาสสำหรับจัดการบัฟเฟอร์
3. System.IO: คลาสสำหรับจัดการสตรีม
4. System.IO.Pipelines: คลาสสำหรับการจัดการท่อแบบดูเพล็กซ์
5. Middleware: มิดเดิลแวร์บางส่วนของ kestrel

### 4 KestrelApp
แอปพลิเคชัน Kestrel เนื้อหาประกอบด้วย
1. การตั้งค่า EndPoint ที่จะรับฟัง (Listen)
2. การตั้งค่าพร็อตคอลที่ใช้กับ EndPoint

### 5 KestrelApp.Middleware
ไลบรารีคลาสมิดเดิลแวร์ของ KestrelApp
#### 5.1 Echo
ตัวอย่างโปรโตคอลแอปพลิเคชัน Echo อย่างง่าย

#### 5.2 FlowAnalyze
ตัวอย่างมิดเดิลแวร์สำหรับสถิติทราฟฟิกชั้นการขนส่ง

#### 5.3 FlowXor
ตัวอย่างมิดเดิลแวร์สำหรับการประมวลผลทราฟฟิกชั้นการขนส่งแบบ XOR

#### 5.4 HttpProxy
ตัวอย่างโปรโตคอลแอปพลิเคชันพร็อกซี http

#### 5.5 Telnet
ตัวอย่างโปรโตคอลแอปพลิเคชัน Telnet อย่างง่าย

#### 5.6 TelnetProxy
ตัวอย่างการส่งต่อทราฟฟิกไปยังเซิร์ฟเวอร์ telnet

#### 5.6 Redis
เซิร์ฟเวอร์โปรโตคอล redis ตัวอย่างการใช้งานมิดเดิลแวร์ในแอปพลิเคชัน

### โอเพ่นซอร์สจะดีขึ้นถ้ามีคุณร่วมด้วย
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---