# مقدمة المشروع
<div align="center">

# ![logo3](https://github.com/user-attachments/assets/8d1a37bd-5955-4dc2-b314-aecb04f985dc)

**اجعل نشر وإدارة وصيانة خوادم الألعاب بسيطًا وفعالًا**

[![GitHub Stars](https://badgen.net/github/stars/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/stargazers)
[![GitHub Release](https://badgen.net/github/release/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/releases)
[![Docker Pulls](https://badgen.net/docker/pulls/xiaozhu674/gameservermanager)](https://hub.docker.com/r/xiaozhu674/gameservermanager)
[![License](https://badgen.net/github/license/yxsj245/GameServerManager)](https://github.com/yxsj245/GameServerManager/blob/main/LICENSE)

[📖 موقع الوثائق](http://blogpage.xiaozhuhouses.asia/html6/index.html#/) • [🌐 الموقع الرسمي](http://blogpage.xiaozhuhouses.asia/html5/index.html) • [💬 مجموعة QQ](https://qm.qq.com/q/oNd4HvMj6M)

</div>

---

## 📋 نبذة عن المشروع

GameServerManager (اختصارًا GSManager) هو منصة حديثة لإدارة خوادم الألعاب تعتمد على تقنية **Docker**، ومصممة خصيصًا لتبسيط عمليات نشر وإدارة وصيانة خوادم الألعاب.

### ✨ الميزات الأساسية

- 🐳 **حاويات Docker** - يعمل بالكامل على Docker، عزل بيئي وتوافق عالي جدًا
- 🎯 **نشر بنقرة واحدة** - يدعم النشر السريع للعديد من الألعاب الشهيرة
- 🌐 **واجهة إدارة ويب** - واجهة React حديثة، بديهية وسهلة الاستخدام
- 🔧 **طرفية في الوقت الفعلي** - طرفية ويب مدمجة تدعم تنفيذ الأوامر الفوري
- 📊 **مراقبة الموارد** - مراقبة استخدام موارد الخادم في الوقت الفعلي
- 🔐 **إدارة الصلاحيات** - نظام متكامل للمصادقة والتحكم في الصلاحيات
- 🎮 **دعم ألعاب متعددة** - يدعم العديد من خوادم الألعاب الشهيرة على منصة Steam
- 💾 **استمرارية البيانات** - ربط بيانات اللعبة وملفات الإعدادات خارجيًا، آمن وموثوق

![لوحة معلومات الحاوية](http://images.server.xiaozhuhouses.asia:40061/i/2025/06/09/wbnc63.png)

---

## 🚀 البدء السريع

### سكريبت التثبيت بنقرة واحدة

```bash
rm -f install.py && wget http://blogpage.xiaozhuhouses.asia/api/api1/install.py && python3 install.py
```
> يُرجى استخدام التثبيت اليدوي لـ debian (تثبيت docker يدويًا) و centos، راجع موقع الوثائق للمزيد من التفاصيل

---

## 🎮 الألعاب المدعومة

| اسم اللعبة | الاسم الصيني | Steam ID | تنزيل مجهول | الحالة |
|------------|--------------|----------|-------------|--------|
| **ألعاب شهيرة** | | | | |
| Palworld |幻兽帕鲁| 2394010 | ✅ | 🟢 دعم كامل |
| Rust |腐蚀| 258550 | ✅ | 🟢 دعم كامل |
| Satisfactory |幸福工厂| 1690800 | ✅ | 🟢 دعم كامل |
| Valheim |英灵神殿| 896660 | ✅ | 🟢 دعم كامل |
| 7 Days to Die |七日杀| 294420 | ✅ | 🟢 دعم كامل |
| Project Zomboid |僵尸毁灭工程| 380870 | ✅ | 🟢 دعم كامل |
| ARK: Survival Evolved |方舟：生存进化| 376030 | ✅ | 🟢 دعم كامل |
| **ألعاب إطلاق النار** | | | | |
| Left 4 Dead 2 |求生之路2| 222860 | ❌ | 🟡 يتطلب نسخة أصلية |
| Team Fortress 2 |军团要塞2| 232250 | ✅ | 🟢 دعم كامل |
| Squad |战术小队| 403240 | ✅ | 🟢 دعم كامل |
| Insurgency: Sandstorm |叛乱：沙漠风暴| 581330 | ✅ | 🟢 دعم كامل |
| Killing Floor 2 |杀戮空间2| 232130 | ✅ | 🟢 دعم كامل |
| Insurgency (2014) |叛乱2| 237410 | ✅ | 🟢 دعم كامل |
| MORDHAU |雷霆一击| 629800 | ✅ | 🟢 دعم كامل |
| No More Room in Hell |地狱已满| 317670 | ✅ | 🟢 دعم كامل |
| Fistful of Frags |Fistful of Frags| 295230 | ✅ | 🟢 دعم كامل |
| Half-Life |半条命| 90 | ✅ | 🟢 دعم كامل |
| Half-Life 2: Deathmatch |半条命2| 232370 | ✅ | 🟢 دعم كامل |
| Operation: Harsh Doorstop |行动代号：残酷之门| 950900 | ✅ | 🟢 دعم كامل |
| Vox Machinae |Vox Machinae| 944490 | ✅ | 🟡 يحتاج إلى إعداد |
| **ألعاب مستقلة** | | | | |
| Unturned |未转变者| 1110390 | ✅ | 🟢 دعم كامل |
| Don't Starve Together |饥荒联机版| 343050 | ✅ | 🟡 يحتاج إلى إعداد |
| Last Oasis |最后的绿洲| 920720 | ✅ | 🟢 دعم كامل |
| Hurtworld |伤害世界| 405100 | ✅ | 🟢 دعم كامل |
| Soulmask |灵魂面甲| 3017300 | ✅ | 🟢 دعم كامل |
| **ألعاب محاكاة** | | | | |
| Euro Truck Simulator 2 |欧洲卡车模拟2| 1948160 | ✅ | 🟡 يحتاج إلى إعداد |
| American Truck Simulator |美国卡车模拟| 2239530 | ✅ | 🟡 يحتاج إلى إعداد |
| ECO |生态生存| 739590 | ✅ | 🟡 يحتاج إلى إعداد |

> دعم المزيد من الألعاب قيد الإضافة المستمرة...

---

## 🏗️ البنية التقنية

### تقنيات الواجهة الأمامية
- **React 18** - إطار عمل واجهة أمامية حديث
- **Ant Design** - مكتبة مكونات UI للمؤسسات
- **Monaco Editor** - محرر الشيفرة البرمجية
- **Xterm.js** - محاكي طرفية ويب
- **Vite** - أداة بناء سريعة

### تقنيات الواجهة الخلفية
- **Python 3.13** - لغة البرمجة الرئيسية
- **Flask** - إطار عمل ويب  
- **Gunicorn** - خادم WSGI  
- **Docker** - تقنية الحاويات  
- **SteamCMD** - أداة سطر أوامر Steam  
- **Aria2** - أداة تنزيل متعددة البروتوكولات  

---

## 📁 هيكلية المشروع

```
GameServerManager/
├── app/                    # تطبيق الواجهة الأمامية
│   ├── src/               # الشيفرة المصدرية لـ React
│   ├── public/            # الموارد الثابتة
│   └── package.json       # تبعيات الواجهة الأمامية
├── server/                # خدمات الواجهة الخلفية
│   ├── api_server.py      # خادم الـ API الرئيسي
│   ├── game_installer.py  # مثبت الألعاب
│   ├── pty_manager.py     # مدير الطرفيات
│   ├── auth_middleware.py # وسيط التحقق
│   └── installgame.json   # ملف إعدادات الألعاب
├── docker-compose.yml     # ملف تنسيق Docker
├── Dockerfile            # ملف بناء صورة Docker
└── README.md             # وثيقة شرح المشروع
```

---

## 🔧 شرح الإعدادات

### إعدادات المنافذ
- **5000** - واجهة إدارة الويب
- **27015-27020** - نطاق منافذ خوادم ألعاب Steam

### ربط مجلدات البيانات
- `./game_data` → `/home/steam/games` - دليل بيانات الألعاب
- `./game_file` → `/home/steam/.config` - دليل إعدادات الألعاب
- `./game_file` → `/home/steam/.local` - دليل حفظ الألعاب

### متغيرات البيئة
- `TZ=Asia/Shanghai` - إعداد المنطقة الزمنية
- `USE_GUNICORN=true` - تفعيل Gunicorn
- `GUNICORN_TIMEOUT=120` - مهلة الطلب
- `GUNICORN_PORT=5000` - منفذ الخدمة

---

## 🤝 دليل المساهمة

نرحب بجميع أشكال المساهمة!

1. **Fork** لهذا المشروع
2. أنشئ فرع الخاصيتك (`git checkout -b feature/AmazingFeature`)
3. قدم تعديلاتك (`git commit -m 'Add some AmazingFeature'`)
4. ادفع إلى الفرع (`git push origin feature/AmazingFeature`)
5. افتح **Pull Request**

---

## 📞 الدعم والملاحظات

- 🐛 **الإبلاغ عن المشكلات**: [GitHub Issues](https://github.com/yxsj245/GameServerManager/issues)
- 💬 **مجموعة QQ**: 1040201322
- 📖 **وثائق مفصلة**: [عرض الوثائق](http://blogpage.xiaozhuhouses.asia/html6/index.html#/)

---

## 📄 رخصة المصدر المفتوح

هذا المشروع يستخدم رخصة [AGPL-3.0 license](LICENSE) مفتوحة المصدر.

---

## 👨‍💻 عن المؤلف

تم تطوير وصيانة هذا المشروع بشكل مستقل بواسطة **又菜又爱玩的小朱**.

إذا كان هذا المشروع مفيداً لك، يرجى وضع ⭐ Star لدعمنا!

---

## 📈 إحصائيات المشروع

![Star History](https://api.star-history.com/svg?repos=yxsj245/GameServerManager&type=Date)

---

<div align="center">

**🎮 اجعل إدارة خوادم الألعاب سهلة وممتعة!**

</div>

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---