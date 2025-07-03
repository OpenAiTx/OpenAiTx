# معرفی پروژه
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**ساده و کارآمد ساختن استقرار، مدیریت و نگهداری سرورهای بازی**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 مستندات](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 وب‌سایت رسمی](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 گروه QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 معرفی پروژه

GameServerManager (به اختصار GSManager) یک پلتفرم مدرن مدیریت سرور بازی مبتنی بر تکنولوژی **Docker** است که با هدف ساده‌سازی استقرار، مدیریت و نگهداری سرورهای بازی طراحی شده است.

### ✨ ویژگی‌های اصلی

- 🐳 **کانتینری‌سازی Docker** - اجرای کاملاً مبتنی بر Docker، ایزوله‌سازی محیط، سازگاری عالی
- 🎯 **استقرار با یک کلیک** - پشتیبانی از استقرار سریع چندین بازی محبوب
- 🌐 **رابط مدیریت وب** - رابط کاربری مدرن React، شهودی و آسان برای استفاده
- 🔧 **ترمینال بلادرنگ** - ترمینال وب داخلی با پشتیبانی از اجرای دستورات لحظه‌ای
- 📊 **پایش منابع** - پایش بلادرنگ مصرف منابع سرور
- 🔐 **مدیریت دسترسی‌ها** - سیستم احراز هویت و کنترل دسترسی کارآمد
- 🎮 **پشتیبانی چند بازی** - پشتیبانی از چندین سرور بازی محبوب پلتفرم Steam
- 💾 **ماندگاری داده‌ها** - نگاشت خارجی داده‌های بازی و فایل‌های پیکربندی، ایمن و قابل اطمینان

![پنل اطلاعات کانتینر](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 شروع سریع

### اسکریپت نصب با یک کلیک

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> برای debian (Docker را به صورت دستی نصب کنید) و centos لطفاً نصب دستی را انجام دهید، جزئیات در مستندات

---

## 🎮 بازی‌های پشتیبانی‌شده

| نام بازی | نام چینی | Steam ID | دانلود ناشناس | وضعیت |
|---------|--------|----------|----------|------|
| **بازی‌های محبوب** | | | | |
| Palworld |幻兽帕鲁 |2394010 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Rust |腐蚀 |258550 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Satisfactory |幸福工厂 |1690800 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Valheim |英灵神殿 |896660 |✅ |🟢 کاملاً پشتیبانی‌شده |
| 7 Days to Die |七日杀 |294420 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Project Zomboid |僵尸毁灭工程 |380870 |✅ |🟢 کاملاً پشتیبانی‌شده |
| ARK: Survival Evolved |方舟：生存进化 |376030 |✅ |🟢 کاملاً پشتیبانی‌شده |
| **بازی‌های شوتر** | | | | |
| Left 4 Dead 2 |求生之路2 |222860 |❌ |🟡 نیاز به نسخه اصلی |
| Team Fortress 2 |军团要塞2 |232250 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Squad |战术小队 |403240 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Insurgency: Sandstorm |叛乱：沙漠风暴 |581330 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Killing Floor 2 |杀戮空间2 |232130 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Insurgency (2014) |叛乱2 |237410 |✅ |🟢 کاملاً پشتیبانی‌شده |
| MORDHAU |雷霆一击 |629800 |✅ |🟢 کاملاً پشتیبانی‌شده |
| No More Room in Hell |地狱已满 |317670 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Fistful of Frags |Fistful of Frags |295230 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Half-Life |半条命 |90 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Half-Life 2: Deathmatch |半条命2 |232370 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Operation: Harsh Doorstop |行动代号：残酷之门 |950900 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Vox Machinae |Vox Machinae |944490 |✅ |🟡 نیاز به پیکربندی |
| **بازی‌های مستقل** | | | | |
| Unturned |未转变者 |1110390 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Don't Starve Together |饥荒联机版 |343050 |✅ |🟡 نیاز به پیکربندی |
| Last Oasis |最后的绿洲 |920720 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Hurtworld |伤害世界 |405100 |✅ |🟢 کاملاً پشتیبانی‌شده |
| Soulmask |灵魂面甲 |3017300 |✅ |🟢 کاملاً پشتیبانی‌شده |
| **بازی‌های شبیه‌سازی** | | | | |
| Euro Truck Simulator 2 |欧洲卡车模拟2 |1948160 |✅ |🟡 نیاز به پیکربندی |
| American Truck Simulator |美国卡车模拟 |2239530 |✅ |🟡 نیاز به پیکربندی |
| ECO |生态生存 |739590 |✅ |🟡 نیاز به پیکربندی |

> بازی‌های بیشتری به طور مستمر در حال اضافه شدن هستند...

---

## 🏗️ معماری فنی

### استک فناوری فرانت‌اند
- **React 18** - چارچوب مدرن رابط کاربری
- **Ant Design** - کتابخانه کامپوننت‌های UI سطح سازمانی
- **Monaco Editor** - ویرایشگر کد
- **Xterm.js** - شبیه‌ساز ترمینال وب
- **Vite** - ابزار ساخت سریع

### استک فناوری بک‌اند
- **Python 3.13** - زبان اصلی توسعه
- **Flask** - فریم‌ورک وب
- **Gunicorn** - سرور WSGI
- **Docker** - فناوری کانتینرسازی
- **SteamCMD** - ابزار خط فرمان Steam
- **Aria2** - دانلودر چندپروتکلی

---

## 📁 ساختار پروژه

```
GameServerManager/
├── app/                    # برنامه فرانت‌اند
│   ├── src/               # سورس React
│   ├── public/            # منابع استاتیک
│   └── package.json       # وابستگی‌های فرانت‌اند
├── server/                # سرویس بک‌اند
│   ├── api_server.py      # سرور اصلی API
│   ├── game_installer.py  # نصب‌کننده بازی
│   ├── pty_manager.py     # مدیریت ترمینال
│   ├── auth_middleware.py # میان‌افزار احراز هویت
│   └── installgame.json   # فایل پیکربندی بازی
├── docker-compose.yml     # فایل ارکستراسیون Docker
├── Dockerfile            # فایل ساخت ایمیج Docker
└── README.md             # مستندات پروژه
```

---

## 🔧 راهنمای پیکربندی

### پیکربندی پورت‌ها
- **5000** - رابط مدیریت وب
- **27015-27020** - بازه پورت سرور بازی Steam

### نگاشت داده‌ها (Volumes)
- `./game_data` → `/home/steam/games` - مسیر داده‌های بازی
- `./game_file` → `/home/steam/.config` - مسیر پیکربندی بازی
- `./game_file` → `/home/steam/.local` - مسیر ذخیره‌سازی بازی

### متغیرهای محیطی
- `TZ=Asia/Shanghai` - تنظیم منطقه زمانی
- `USE_GUNICORN=true` - فعال‌سازی Gunicorn
- `GUNICORN_TIMEOUT=120` - زمان انتظار درخواست
- `GUNICORN_PORT=5000` - پورت سرویس

---

## 🤝 راهنمای مشارکت

ما از هرگونه مشارکت استقبال می‌کنیم!

1. **Fork** پروژه
2. شاخه ویژگی خود را ایجاد کنید (`git checkout -b feature/AmazingFeature`)
3. تغییرات خود را ثبت کنید (`git commit -m 'Add some AmazingFeature'`)
4. به شاخه خود push کنید (`git push origin feature/AmazingFeature`)
5. یک **Pull Request** باز کنید

---

## 📞 پشتیبانی و بازخورد

- 🐛 **گزارش مشکلات**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **گروه QQ**: 1040201322
- 📖 **مستندات کامل**: [مشاهده مستندات](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 مجوز متن‌باز

این پروژه تحت مجوز [AGPL-3.0 license](LICENSE) متن‌باز است.

---

## 👨‍💻 درباره نویسنده

این پروژه به طور مستقل توسط **又菜又爱玩的小朱** توسعه و نگهداری می‌شود.

اگر این پروژه برای شما مفید بود، لطفاً با یک ⭐ Star از آن حمایت کنید!

---

## 📈 آمار پروژه

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 مدیریت سرور بازی را ساده و جذاب کنید!**

</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---