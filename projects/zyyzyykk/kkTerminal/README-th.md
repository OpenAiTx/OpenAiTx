# kkTerminal

> kkTerminal, เทอร์มินัลสำหรับการเชื่อมต่อ Web SSH
>
> ผู้เขียน: [zyyzyykk](https://github.com/zyyzyykk/)
>
> ซอร์สโค้ด: https://github.com/zyyzyykk/kkTerminal
>
> ที่อยู่ Docker Hub: https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general
>
> ตัวอย่าง: https://ssh.kkbpro.com/
>
> อัปเดตล่าสุด: 2025-03-15
>

<p align="center"><a href="https://ssh.kkbpro.com/" target="_blank" rel="noopener noreferrer"><img width="100" src="https://kkbapps.oss-cn-shanghai.aliyuncs.com/logo/terminal.png" alt="kkTerminal"></a></p>

<p align="center">
  <a href="https://hub.docker.com/repository/docker/zyyzyykk/kkterminal/general"><img src="https://img.shields.io/docker/pulls/zyyzyykk/kkterminal?logo=docker" alt="Docker Image"></a>
  <a href="https://www.oracle.com/cn/java/technologies/downloads/#java8-windows"><img src="https://img.shields.io/badge/jdk-1.8-orange?logo=openjdk&logoColor=%23e3731c" alt="JDK Version"></a>
  <a href="https://spring.io/projects/spring-boot"><img src="https://img.shields.io/badge/springboot-2.7.15-green?color=6db33f&logo=springboot" alt="SpringBoot Version"></a>
  <a href="https://cn.vuejs.org/"><img src="https://img.shields.io/badge/vue-3.x-green?color=42b883&logo=vue.js" alt="Vue Version"></a>
  <a href="https://www.apache.org/licenses/"><img src="https://img.shields.io/badge/licence-Apache-red?logo=apache&logoColor=%23D22128" alt="Apache Licence"></a>
  <a href="https://github.com/zyyzyykk/kkTerminal"><img src="https://img.shields.io/github/stars/zyyzyykk/kkterminal" alt="GitHub"></a>
</p>
<p align="center">English ｜ <a href="https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/zh_CN/README.md" >简体中文</a></p>

### ⚡ การเชื่อมต่ออย่างรวดเร็ว

ใช้แท็ก `iframe` ในหน้าเว็บ HTML เพื่อเชื่อมต่ออย่างรวดเร็ว:

```html
<iframe src="https://ssh.kkbpro.com/" height="400px" width="600px" ></iframe>
```

### 🐳 การติดตั้งด้วย Docker

1. ดึงอิมเมจ:

```bash
docker pull zyyzyykk/kkterminal
```

2. สร้างและรันคอนเทนเนอร์สำหรับการแมปพอร์ต: `-p port:3000`

```bash
docker run -d --name kkterminal -p 3000:3000 zyyzyykk/kkterminal
```

3. กำหนดคำศิลป์เอง: `-e TITLE="ArtWord"`

```bash
docker run -d --name kkterminal -p 3000:3000 -e TITLE="kkbpro" zyyzyykk/kkterminal
```

4. เข้าถึงผ่านเบราว์เซอร์: `http://server-ip:3000/`

### 🛸 ตัวอย่างการใช้งาน

เข้าชมเว็บไซต์: https://ssh.kkbpro.com/

![Connect](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Connect.png)

![Preference](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Preference.png)

![File](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/File.png)

![Editor](https://kkbapps.oss-cn-shanghai.aliyuncs.com/terminal/3.6.0/en/Editor.png)

[**ดูตัวอย่างโมดูลเพิ่มเติม**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/MODULE.md)

### 💡 คำอธิบายฟังก์ชัน

1. kkTerminal เป็นเทอร์มินัลสำหรับเชื่อมต่อ Web SSH คลิกไอคอนเทอร์มินัลที่มุมซ้ายบนและเลือกการตั้งค่าการเชื่อมต่อเพื่อสร้างการเชื่อมต่อ SSH

2. รองรับการใช้แท็ก `iframe` ในหน้าเว็บเพื่อเชื่อมต่ออย่างรวดเร็วกับเว็บไซต์ภายนอก

3. รองรับการปรับแต่งการตั้งค่าเทอร์มินัลผ่าน [พารามิเตอร์ URL](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/PARAMS.md)

4. รองรับการแปลภาษาและสลับระหว่างภาษาจีนกับอังกฤษ

5. รองรับการติดตั้งในเครื่อง PC เปิดหน้าต่างเบราว์เซอร์โดยอัตโนมัติเมื่อเริ่มต้นใช้งาน

6. รองรับการปรับขนาดหน้าต่างอัตโนมัติและรองรับการพิมพ์ภาษาจีน

7. รองรับการตั้งค่าความต้องการส่วนตัว ผู้ใช้สามารถเลือกสีพื้นหลัง/ตัวอักษร ขนาดฟอนต์ สไตล์การแสดงผลเคอร์เซอร์ เปิดใช้งาน TCode สำหรับเทอร์มินัล ฯลฯ

8. รองรับการรีสตาร์ท: ระบบจะรีสตาร์ทอัตโนมัติหลังจากแก้ไขการตั้งค่า SSH หรือการตั้งค่าความต้องการส่วนตัว หรือรีสตาร์ทเองได้หลังเชื่อมต่อ SSH ขาด

9. รองรับการคัดลอกและวาง:

   - คัดลอก: เหมือนเทอร์มินัล `Git` เลือกข้อความจะคัดลอกโดยอัตโนมัติ

   - วาง: เหมือนเทอร์มินัล `Cmd` คลิกขวาเพื่อวาง (ต้องอนุญาตการเข้าถึงของเบราว์เซอร์)


9. รองรับการจัดการไฟล์ เปิดโมดูล File Management เพื่อดู แตกไฟล์ อัปโหลดและดาวน์โหลดไฟล์/โฟลเดอร์

10. รองรับการใช้งานคีย์ลัด เช่น เลือกหลายไฟล์/ทั้งหมด คัดลอกและวาง ตัด สลับการเลือก เปิด ฯลฯ

11. รองรับการเรียกดูและแก้ไขไฟล์ แก้ไขไฟล์และบันทึกไปยังเซิร์ฟเวอร์ระยะไกลด้วย `ctrl+s`

12. รองรับ [TCode (Terminal Code)](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/TCODE.md) ซึ่งสามารถสร้าง Workflow อัตโนมัติคล้ายกับ Shell script ด้วย TCode ที่กำหนดเอง

13. รองรับการบันทึกการทำงานและซิงค์ข้อมูลกับคลาวด์

14. รองรับฟังก์ชัน Cooperate, Monitor และ Docker

### 👨‍💻 บันทึกการอัปเดต

##### zyyzyykk/kkterminal:3.6.0: ล่าสุด

- เพิ่มฟังก์ชัน Advance Cooperate
- เพิ่มฟังก์ชัน Advance Monitor
- เพิ่มฟังก์ชัน Advance Docker
- ปรับปรุงขนาดแพ็คเกจ & การแสดงผลหน้าเว็บ

##### zyyzyykk/kkterminal:3.5.6: 

- รองรับพารามิเตอร์ URL เพิ่มเติม
- เพิ่มการตั้งค่าขนาดข้อความ & รูปภาพใน editor เป็นเปอร์เซ็นต์
- ปรับปรุงการแสดงผลหน้าเว็บ

##### zyyzyykk/kkterminal:3.5.3: 

- เพิ่มพารามิเตอร์ URL สำหรับปรับแต่งเทอร์มินัล
- แก้ไขบั๊ก restart หลายหน้าต่าง
- เพิ่มฟังก์ชันบันทึกการทำงานและซิงค์ข้อมูลคลาวด์
- รีแฟกเตอร์บางส่วนของโค้ด

[**ดูบันทึกการอัปเดตย้อนหลัง**](https://raw.githubusercontent.com/zyyzyykk/kkTerminal/master/doc/en_US/UPDATE.md)

### 🧬 สถาปัตยกรรม

```markdown
+---------+     http      +-------------+    ssh     +---------------+
| browser | <===========> | kk Terminal | <========> | remote server |
+---------+   websocket   +-------------+    sftp    +---------------+
Vue + Xterm              SpringBoot + SSHJ                Linux OS    
```

### 🏘️ เกี่ยวกับโปรเจกต์นี้

เรียนผู้ใช้ทุกท่าน

ขอแจ้งให้ทราบว่าเนื่องด้วยข้อจำกัดด้านเวลาและพลังงาน ผมจะไม่สามารถดูแล `kkTerminal` ต่อไปในอนาคต

หากคุณสนใจใน `kkTerminal` หรืออยากสานต่อการดูแล สามารถติดต่อผมหรือแจ้ง issue ได้

หากคุณพบข้อผิดพลาดหรืออยากพัฒนาฟีเจอร์ใหม่ กรุณาแจ้ง issue ได้เช่นกัน

สุดท้ายนี้ขอขอบคุณสำหรับการสนับสนุน `kkTerminal` และหวังว่า `kkTerminal` จะเป็นประโยชน์กับคุณจริง ๆ

ขอแสดงความนับถือ

[zyyzyykk](https://github.com/zyyzyykk/)

2025.03.15

### 🌟 ดาว

[![Stars](https://starchart.cc/zyyzyykk/kkTerminal.svg?variant=adaptive)](https://starchart.cc/zyyzyykk/kkTerminal)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---