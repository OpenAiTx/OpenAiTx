## FanImeTsf

هذا هو طرف TSF الخاص بـ [FanImeServer](https://github.com/fanlumaster/FanImeServer).

ملاحظة: حالياً يدعم فقط التطبيقات ذات الإصدار 64-بت.

## كيفية البناء

### المتطلبات الأساسية

- Visual Studio 2022
- CMake
- vcpkg
- Python3
- gsudo

تأكد من تثبيت vcpkg وgsudo عبر **Scoop**.

## خطوات البناء

### البناء

أولاً، قم باستنساخ المستودع،

```powershell
git clone --recursive https://github.com/fanlumaster/FanImeTsf.git
```

ثم، حضّر البيئة،

```powershell
cd FanImeTsf
python .\scripts\prepare_env.py
```

بعد ذلك، قم بالبناء،

```powershell
.\scripts\lcompile.ps1
```

### التثبيت

قم بتشغيل powershell كمسؤول، وتأكد من تفعيل خيار النظام `Enable sudo`.

![](https://i.postimg.cc/zJCn9Cnn/image.png)

بعدها، أنشئ مجلدًا في `C:\Program Files\` باسم `FanImeTsf`، وانسخ ملف `FanImeTsf.dll` إليه،

```powershell
gsudo
Copy-Item -Path ".\FanImeTsf\build64\Debug\FanImeTsf.dll" -Destination "C:\Program Files\FanImeTsf"
```

ثم، قم بتثبيته،

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 .\FanImeTsf.dll
```

### إزالة التثبيت

```powershell
cd "C:\Program Files\FanImeTsf"
sudo regsvr32 /u .\FanImeTsf.dll
```

## لقطات شاشة

![](https://i.postimg.cc/v8Bpx6Gf/image.png)

![](https://i.postimg.cc/ssBgtM5M/image.png)

![](https://i.postimg.cc/ryDqXH0B/image.png)

![](https://i.postimg.cc/2m9WJTgR/image.png)

![](https://i.postimg.cc/L96qQZT8/image.png)

![](https://i.postimg.cc/FNcz9QTv/image.png)

## خارطة الطريق

حالياً يدعم فقط شوانغ بين شياوخه.

### الصينية

- شوانغ بين شياوخه
- الكتابة الكاملة (Quanpin)
- رموز المساعدة لاستخدام مكونات الحروف الصينية (Hanzi)
- قاموس قابل للتخصيص
- محرك إدخال قابل للتخصيص
- مظاهر قابلة للتخصيص
- التبديل بين الصينية المبسطة والتقليدية
- الإكمال التلقائي للغة الإنجليزية
- واجهة برمجة تطبيقات IME السحابية مفتوحة المصدر
- تبديل واجهة نافذة المرشحين بين الوضع الرأسي والأفقي
- مفاتيح التفعيل: يجب أن يكون بإمكان المستخدمين تفعيل أو تخصيص معظم الميزات بحرية

### دعم اللغة اليابانية

ربما سيكون مشروعًا آخر.

وربما دعم بعض اللغات الأخرى.

### المراجع

- [MS-TSF-IME-Demo](https://github.com/microsoft/Windows-classic-samples/tree/main/Samples/IME/cpp/SampleIME)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---