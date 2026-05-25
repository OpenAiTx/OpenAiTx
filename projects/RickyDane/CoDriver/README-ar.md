<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=en">الإنجليزية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-CN">الصينية المبسطة</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=zh-TW">الصينية التقليدية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ja">اليابانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ko">الكورية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=hi">الهندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=th">التايلاندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fr">الفرنسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=de">الألمانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=es">الإسبانية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=it">الإيطالية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ru">الروسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pt">البرتغالية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=nl">الهولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=pl">البولندية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=fa">الفارسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=tr">التركية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=vi">الفيتنامية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=id">الإندونيسية</a>
        | <a href="https://openaitx.github.io/view.html?user=RickyDane&project=CoDriver&lang=as">الآسامية</a>
      </div>
    </div>
  </details>
</div>

<br/>
<p align="center"><img width="500" height="auto" alt="codriver_banner" src="https://github.com/user-attachments/assets/1957b950-db16-4ebd-b514-4f9b4f4abfd9" /></p>

<br/>

<a href="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml"><p align="center"><img src="https://github.com/RickyDane/CoDriver/actions/workflows/main.yml/badge.svg?branch=master"></p></a>

<p align="center">

  <img src="https://img.shields.io/badge/Windows-blue" />
  <img src="https://img.shields.io/badge/ macOS-white" />
  <img src="https://img.shields.io/badge/Linux-red" />
</p>

<p align="center">
  <a href="https://discord.gg/zSE27rjdzp">
      <img src="https://dcbadge.limes.pink/api/server/https://discord.gg/zSE27rjdzp" />
  </a>
</p>

<p align="center">
  <a href='https://ko-fi.com/rickydane'>
      <img height='36px' style='border: 0px; height: 36px;' src='https://storage.ko-fi.com/cdn/kofi2.png?v=3' border='0' alt='اشترِ لي قهوة على ko-fi.com' />
  </a>
</p>

<br/>

<p align="center">
  مستكشف ملفات بسيط وُلد لأنني أردت تعلم لغة Rust.
  <br>
  هو مستقل عن نظام التشغيل ومعدل للأمثلية.
</p>

<br/><br/>

يتم تحقيق الأداء بواسطة ["jwalk"](https://crates.io/crates/jwalk/versions) و ["Tauri"](https://tauri.app/).
<br/><br/>
لا يستخدم CoDriver التخزين المؤقت للمسارات للوصول إلى الملفات والمجلدات، لذا فإن الأداء يتحقق بفضل لغة Rust وسرعة القرص وقوة المعالج.

⁉️ يرجى الانتباه إلى أن هذا البرنامج لا يزال قيد التطوير وقد يحتوي على أخطاء!
<br/><br/>

# الروابط
- <a href="#basic-features">الميزات الأساسية</a>
- <a href="#advanced-features">الميزات المتقدمة</a>
- <a href="#dependencies-if-not-working-instantly">المتطلبات</a>
- <a href="#%EF%B8%8F-ftp-integration-sshfs">تنفيذ FTP (SSHFS)</a>
- <a href="#%EF%B8%8F-known-issues">المشاكل المعروفة</a>
- <a href="#-todos">قائمة المهام</a>
- <a href="#user-interface">واجهة المستخدم</a>

## الميزات الأساسية
- التنقل عبر الدلائل كما اعتدت عليه
- نسخ ولصق، حذف، إنشاء وإعادة تسمية الملفات والمجلدات
- التبديل بين أوضاع الشبكة، القائمة، وأعمدة ميلر
- إغلاق النوافذ المنبثقة بزر esc
- الانتقال المباشر إلى دليل باستخدام Ctrl / Cmd + G عبر إدخال المسار
- فرز العناصر في وضع القائمة حسب الحجم أو الاسم أو آخر تعديل

## الميزات المتقدمة
- ضغط الملفات والمجلدات
  - zip
  - zstd
  - brotli
  - density (https://github.com/g1mv/density)
- فك ضغط الأرشيفات
  - rar
  - zip
  - 7zip
  - tar (.gz, .bz2)
  - density
- الانتقال إلى دليل باستخدام الاختصار LAlt + 1 / 2 / 3 | (خيار macOS + 1 / 2 / 3)
  - قم بتكوين المسارات بنفسك في الإعدادات
- إنشاء ملف باستخدام F6
- إنشاء مجلد باستخدام F7
- عرض اللوحتين (Dual-Pane)
  - البحث عن الملفات باستخدام F8
  - نسخ العنصر المحدد الحالي إلى اللوحة الأخرى باستخدام F5
  - نقل العنصر المحدد الحالي إلى اللوحة الأخرى باستخدام LShift + F5
- سحب وإفلات الملفات في المستكشف لنسخها إلى الدليل الحالي
- إعادة تسمية متعددة للاختيار باستخدام Ctrl / Cmd + LShift + M
  - تنفيذ إعادة التسمية المتعددة باستخدام Ctrl / Cmd + Return
- معاينة سريعة للملفات -> حدد مدخل الدليل واضغط على مفتاح المسافة.
  - الملفات المدعومة: جميع ملفات الصور (.jpg، .png، ...)، .pdf، .mp4، .json، .txt، .html
  - جميع العناصر الأخرى ستعرض مربعاً صغيراً مع بعض المعلومات عنها (المسار، الحجم، آخر تعديل)
- تنقل فوري -> ابدأ بالكتابة وسيتم تصفية محتويات الدليل تلقائياً، مما يجعل <br/>
  التنقل إلى الموقع المطلوب أسرع في بعض الأحيان

## الاعتمادات (في حال لم تعمل مباشرة)

<details>
<summary>انقر للتوسيع</summary>

### لينكس

- openssl1.1

#### ديبيان / أوبونتو
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### القوس
```
sudo apt update
sudo apt install libwebkit2gtk-4.0-dev \
    build-essential \
    curl \
    wget \
    file \
    libssl-dev \
    libgtk-3-dev \
    libayatana-appindicator3-dev \
    librsvg2-dev
```

#### فيدورا
```
sudo dnf check-update
sudo dnf install openssl1.1 \
    webkit2gtk4.0-devel \
    openssl-devel \
    curl \
    wget \
    file \
    libappindicator-gtk3-devel \
    librsvg2-devel
sudo dnf group install "C Development Tools and Libraries"
```
</details>

## 🖥️ تكامل FTP (sshfs)
<details>
  <summary>انقر للتوسيع</summary>
  <br/>
  المتطلبات (يجب تثبيتها بشكل إضافي):
  <br/>

  | macOS | Linux | Windows |
  | ----- | ----- | ------- |
  | fuse-t <br/> fuse-t-sshfs | libfuse | غير مدعوم **_حتى الآن_** |

  ### التثبيت:
  #### macOS
  ```
  brew tap macos-fuse-t/homebrew-cask
  brew install fuse-t
  brew install fuse-t-sshfs
  ```
  #### لينكس
  ```
  sudo apt-get install sshfs
  ```

## 🏴‍☠️ دعم اللغة
- الإنجليزية
  - خيار اختيار بين اللغات قريباً ...
</details>

## ⚠️ المشاكل المعروفة:
- السحب والإفلات خارج النافذة لا يعمل دائماً على لينكس حالياً
- في ويندوز قد تحتاج لتثبيت [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/en-us/cpp/windows/latest-supported-vc-redist?view=msvc-170)
- الأذونات في نظام ms-windows غريبة بعض الشيء
  - قد تحتاج لتشغيل البرنامج كمسؤول إذا واجهت مشاكل في نسخ العناصر أو شيء مشابه
- قد تواجه مشكلة تتطلب تثبيت openssl1.1 على أنظمة لينكس، إذا لم يبدأ البرنامج

## 📝 المهام القادمة:
- لغات متعددة
- المفضلة
- الوصول إلى خدمات التخزين السحابية (Google drive وغيرها)

## واجهة المستخدم
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 16" src="https://github.com/user-attachments/assets/fc408504-3000-4325-bc2a-638cdd01ea0a" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 19 40" src="https://github.com/user-attachments/assets/5f772d02-6bc2-470c-b999-6982043496c1" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 02" src="https://github.com/user-attachments/assets/7f2ec5ea-a669-4630-a1f8-413c7ced3f3b" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 07" src="https://github.com/user-attachments/assets/4ac9930d-7b50-4910-afb3-d47c562c3b44" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 20 28" src="https://github.com/user-attachments/assets/7dcfb0fa-c106-401a-b917-06e766021368" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 18" src="https://github.com/user-attachments/assets/4bac06d1-22df-47d4-95c9-1ccb50083506" />
<img width="400" height="auto" alt="Screenshot 2026-05-24 at 12 23 39" src="https://github.com/user-attachments/assets/fdca23b0-9ed5-495b-9fec-18ecbfd4d5f2" />



## كيفية المساهمة
قم بإعداد جهازك لتطوير تطبيقات tauri v1: [متطلبات Tauri](https://tauri.app/v1/guides/getting-started/prerequisites)
</br></br>
عند الانتهاء، قم بتنفيذ ```git clone https://github.com/RickyDane/CoDriver``` أو ```gh repo clone RickyDane/CoDriver``` في مكان على جهازك.
</br></br>
يجب أن تتمكن من تشغيل ```cargo tauri dev``` في الدليل الجذري لهذا المشروع لبدء بناء وتشغيل CoDriver.
</br>
تأكد من تثبيت tauri-cli: ```cargo install tauri-cli```
</br>

## توقيع الإصدار
يجب توقيع وإضفاء الطابع الرسمي على المنتجات النهائية لنظام macOS لتجنب قيام Gatekeeper بالإبلاغ عن أن التطبيق المثبت تالف. راجع [توقيع وإضفاء الطابع الرسمي على macOS](https://raw.githubusercontent.com/RickyDane/CoDriver/master/docs/macos-signing-notarization.md) للحصول على أسرار GitHub Actions المطلوبة وأوامر التحقق.

## تاريخ النجوم

<a href="https://star-history.com/#rickydane/CoDriver&Date">
 <picture>
   <source media="(prefers-color-scheme: dark)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date&theme=dark" />
   <source media="(prefers-color-scheme: light)" srcset="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
   <img alt="مخطط تاريخ النجوم" src="https://api.star-history.com/svg?repos=rickydane/CoDriver&type=Date" />
 </picture>
</a>

#### برامج طرف ثالث أخرى
- DragSelect (https://github.com/ThibaultJanBeyer/DragSelect)



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-25

---