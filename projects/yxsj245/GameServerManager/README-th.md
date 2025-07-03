# แนะนำโครงการ
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**ทำให้การติดตั้ง ดูแล และบำรุงรักษาเซิร์ฟเวอร์เกมเป็นเรื่องง่ายและมีประสิทธิภาพ**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 เอกสาร](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 เว็บไซต์ทางการ](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 กลุ่ม QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 บทนำโครงการ

GameServerManager (เรียกสั้นๆ ว่า GSManager) คือแพลตฟอร์มการจัดการเซิร์ฟเวอร์เกมสมัยใหม่บนพื้นฐานเทคโนโลยี **Docker** ออกแบบมาเพื่อทำให้การติดตั้ง ดูแล และบำรุงรักษาเซิร์ฟเวอร์เกมเป็นเรื่องง่าย

### ✨ คุณสมบัติเด่น

- 🐳 **Docker คอนเทนเนอร์** - ทำงานบน Docker อย่างสมบูรณ์ แยกสภาพแวดล้อม รองรับสูง
- 🎯 **ติดตั้งด้วยคลิกเดียว** - รองรับการติดตั้งเกมยอดนิยมหลายรายการอย่างรวดเร็ว
- 🌐 **เว็บอินเทอร์เฟซจัดการ** - ส่วนหน้า React ทันสมัย ใช้งานง่าย
- 🔧 **เทอร์มินัลแบบเรียลไทม์** - มี Web Terminal ในตัว รองรับการรันคำสั่งแบบเรียลไทม์
- 📊 **ติดตามทรัพยากร** - ตรวจสอบการใช้งานทรัพยากรเซิร์ฟเวอร์แบบเรียลไทม์
- 🔐 **จัดการสิทธิ์** - ระบบรับรองตัวตนและควบคุมสิทธิ์ผู้ใช้งานครบถ้วน
- 🎮 **รองรับหลายเกม** - รองรับเซิร์ฟเวอร์เกมยอดนิยมหลายรายการบน Steam
- 💾 **ข้อมูลถาวร** - แม็ปข้อมูลเกมและไฟล์ตั้งค่าสู่ภายนอก ปลอดภัยไว้วางใจได้

![แผงข้อมูลคอนเทนเนอร์](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 เริ่มต้นอย่างรวดเร็ว

### สคริปต์ติดตั้งคลิกเดียว

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> debian (ติดตั้ง docker เอง) และ centos กรุณาติดตั้งด้วยตนเอง ดูรายละเอียดที่เอกสาร

---

## 🎮 เกมที่รองรับ

| ชื่อเกม | ชื่อภาษาจีน | Steam ID | ดาวน์โหลดแบบไม่ระบุชื่อ | สถานะ |
|---------|--------|----------|----------|------|
| **เกมยอดนิยม** | | | | |
| Palworld | 幻兽帕鲁 | 2394010 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Rust | 腐蚀 | 258550 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Satisfactory | 幸福工厂 | 1690800 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Valheim | 英灵神殿 | 896660 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| 7 Days to Die | 七日杀 | 294420 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Project Zomboid | 僵尸毁灭工程 | 380870 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| ARK: Survival Evolved | 方舟：生存进化 | 376030 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| **เกมยิง** | | | | |
| Left 4 Dead 2 | 求生之路2 | 222860 | ❌ | 🟡 ต้องใช้ลิขสิทธิ์แท้ |
| Team Fortress 2 | 军团要塞2 | 232250 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Squad | 战术小队 | 403240 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Insurgency: Sandstorm | 叛乱：沙漠风暴 | 581330 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Killing Floor 2 | 杀戮空间2 | 232130 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Insurgency (2014) | 叛乱2 | 237410 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| MORDHAU | 雷霆一击 | 629800 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| No More Room in Hell | 地狱已满 | 317670 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Fistful of Frags | Fistful of Frags | 295230 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Half-Life | 半条命 | 90 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Half-Life 2: Deathmatch | 半条命2 | 232370 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Operation: Harsh Doorstop | 行动代号：残酷之门 | 950900 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Vox Machinae | Vox Machinae | 944490 | ✅ | 🟡 ต้องตั้งค่าเอง |
| **เกมอินดี้** | | | | |
| Unturned | 未转变者 | 1110390 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Don't Starve Together | 饥荒联机版 | 343050 | ✅ | 🟡 ต้องตั้งค่าเอง |
| Last Oasis | 最后的绿洲 | 920720 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Hurtworld | 伤害世界 | 405100 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| Soulmask | 灵魂面甲 | 3017300 | ✅ | 🟢 รองรับเต็มรูปแบบ |
| **เกมจำลองสถานการณ์** | | | | |
| Euro Truck Simulator 2 | 欧洲卡车模拟2 | 1948160 | ✅ | 🟡 ต้องตั้งค่าเอง |
| American Truck Simulator | 美国卡车模拟 | 2239530 | ✅ | 🟡 ต้องตั้งค่าเอง |
| ECO | 生态生存 | 739590 | ✅ | 🟡 ต้องตั้งค่าเอง |

> มีเกมรองรับเพิ่มขึ้นเรื่อยๆ...

---

## 🏗️ สถาปัตยกรรมเทคโนโลยี

### เทคโนโลยีฝั่งหน้าเว็บ
- **React 18** - เฟรมเวิร์กส่วนหน้าทันสมัย
- **Ant Design** - ไลบรารี UI ระดับองค์กร
- **Monaco Editor** - ตัวแก้ไขโค้ด
- **Xterm.js** - ตัวจำลองเทอร์มินัลบนเว็บ
- **Vite** - เครื่องมือ build รวดเร็ว

### เทคโนโลยีฝั่งเซิร์ฟเวอร์
- **Python 3.13** - ภาษาโปรแกรมหลัก
- **Flask** - เว็บเฟรมเวิร์ก
- **Gunicorn** - เซิร์ฟเวอร์ WSGI
- **Docker** - เทคโนโลยีคอนเทนเนอร์
- **SteamCMD** - เครื่องมือบรรทัดคำสั่ง Steam
- **Aria2** - โปรแกรมดาวน์โหลดแบบหลายโปรโตคอล

---

## 📁 โครงสร้างโปรเจกต์

```
GameServerManager/
├── app/                    # แอปพลิเคชันฝั่งหน้าเว็บ
│   ├── src/               # ซอร์สโค้ด React
│   ├── public/            # ไฟล์สแตติก
│   └── package.json       # ไฟล์ dependencies ฝั่งหน้าเว็บ
├── server/                # เซิร์ฟเวอร์ฝั่งหลังบ้าน
│   ├── api_server.py      # API เซิร์ฟเวอร์หลัก
│   ├── game_installer.py  # ตัวติดตั้งเกม
│   ├── pty_manager.py     # ตัวจัดการเทอร์มินัล
│   ├── auth_middleware.py # มิดเดิลแวร์สำหรับการยืนยันตัวตน
│   └── installgame.json   # ไฟล์คอนฟิกเกม
├── docker-compose.yml     # ไฟล์ Docker Compose
├── Dockerfile            # ไฟล์สร้างอิมเมจ Docker
└── README.md             # เอกสารแนะนำโปรเจกต์
```

---

## 🔧 คำอธิบายการตั้งค่า

### การตั้งค่าพอร์ต
- **5000** - หน้าเว็บจัดการ
- **27015-27020** - ช่วงพอร์ตเซิร์ฟเวอร์เกม Steam

### การแมปโฟลเดอร์ข้อมูล
- `./game_data` → `/home/steam/games` - โฟลเดอร์ข้อมูลเกม
- `./game_file` → `/home/steam/.config` - โฟลเดอร์คอนฟิกเกม
- `./game_file` → `/home/steam/.local` - โฟลเดอร์เซฟเกม

### ตัวแปรสภาพแวดล้อม
- `TZ=Asia/Shanghai` - การตั้งค่าโซนเวลา
- `USE_GUNICORN=true` - เปิดใช้งาน Gunicorn
- `GUNICORN_TIMEOUT=120` - เวลาหมดเขตคำขอ
- `GUNICORN_PORT=5000` - พอร์ตเซิร์ฟเวอร์

---

## 🤝 แนวทางการมีส่วนร่วม

เรายินดีต้อนรับการมีส่วนร่วมทุกรูปแบบ!

1. **Fork** โปรเจกต์นี้
2. สร้าง branch ฟีเจอร์ของคุณ (`git checkout -b feature/AmazingFeature`)
3. คอมมิตการแก้ไขของคุณ (`git commit -m 'Add some AmazingFeature'`)
4. ผลักดันไปยัง branch (`git push origin feature/AmazingFeature`)
5. เปิด **Pull Request**

---

## 📞 การสนับสนุนและข้อเสนอแนะ

- 🐛 **รายงานปัญหา**：[GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **กลุ่ม QQ**：1040201322
- 📖 **เอกสารโดยละเอียด**：[ดูเอกสาร](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 สัญญาอนุญาตโอเพนซอร์ส

โปรเจกต์นี้ใช้สัญญาอนุญาตแบบ [AGPL-3.0 license](LICENSE)

---

## 👨‍💻 เกี่ยวกับผู้เขียน

โปรเจกต์นี้พัฒนาและดูแลโดย **又菜又爱玩的小朱** เพียงผู้เดียว

หากโปรเจกต์นี้มีประโยชน์กับคุณ อย่าลืมกด ⭐ Star ให้กำลังใจด้วยนะ!

---

## 📈 สถิติของโปรเจกต์

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 ให้การจัดการเซิร์ฟเวอร์เกมเป็นเรื่องง่ายและสนุก!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---