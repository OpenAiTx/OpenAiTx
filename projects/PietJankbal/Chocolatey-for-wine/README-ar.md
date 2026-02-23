<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

مدير حزم Chocolatey المثبت تلقائيًا في wine، مفيد لتثبيت البرامج بسرعة في wine (وبالتالي اكتشاف الأخطاء في wine ;) )  
تمت إضافة بعض الحلول لبعض الأخطاء مثل Visual Studio Community 2022 و nodejs، راجع التفاصيل لاحقًا.  

خلال فترة الإغلاق كتبت winetricks(.ps1) مخصص مع أوامر أجدها مفيدة. فقط نفذ 'winetricks' لرؤيتها.
لبعض الأوامر يلزم إعادة تشغيل كاملة لـ wine (بسبب تغييرات wine الأخيرة). ستظهر نافذة رسالة وسيتم إنهاء الجلسة. فقط ابدأ powershell مرة أخرى وأعد المحاولة. إذا تم ذلك مرة واحدة، لن تحتاج لتكرار ذلك لأي أمر آخر.  


مثال:

'winetricks vs22_interactiveinstaller'  ( --> سيتم إنهاء الجلسة)

قم بتنفيذ 'wine powershell'

قم بتنفيذ 'winetricks vs22_interactiveinstaller'

(بالمناسبة، عبر 'winetricks vs22_interactive_installer' يمكنك اختيار ما تريد تثبيته عبر مثبت Visual Studio 2022؛ 'winetricks vs22_interactive_installer' أدخلني خلال عشر دقائق إلى البرنامج الرئيسي (اخترت تطوير سطح المكتب باستخدام ++C)).

التثبيت:
- قم بتنزيل وفك ضغط ملف الإصدار ثم نفذ 'wine ChoCinstaller_0.5c.751.exe' (يستغرق إتمامه حوالي دقيقة)

اختياري:
- شغل المثبت مثل 'wine ChoCinstaller_0.5a.751.exe /s' ، عندها تُحفظ ملفات التثبيت (مثل Powershell*.msi و dotnet48)
  في MyDocuments ولا تحتاج لتنزيلها مجددًا إذا أنشأت بادئة جديدة)
اختياري:
- شغل المثبت مثل 'wine ChoCinstaller_0.5a.751.exe /q' لمنع الإطلاق التلقائي لنافذة powershell (أي التثبيت فقط).

اختياري:
- تحقق إن كانت الأمور تمت بنجاح: "choco install chromium" و "start chrome.exe (--no-sandbox لم يعد مطلوبًا منذ wine-8,4)"

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
حول PowerShell:

نصيحة: عادةً يقوم Chocolatey بتثبيت أحدث إصدار من البرنامج، مما قد يكشف عن أخطاء جديدة في wine. قد يكون لديك حظ أفضل مع إصدار أقدم من البرنامج.
مثال:

choco search --exact microsoft-edge --all (--> يعرض جميع الإصدارات)

choco install microsoft-edge --version --version='135.0.3179.98'

معلومات عامة:

- 'wine powershell.exe' يشغل وحدة تحكم PowerShell-Core.

 
حول ConEmu:


تعاني وحدة تحكم ConEmu من بعض أخطاء wine:
  - لا يعمل اختصار Ctrl^C لإنهاء برنامج لا يعود تلقائياً إلى وحدة التحكم. استخدم Shift^Ctrl^C بدلاً منه.
  - لا يتم تمييز النص عند تحديده في نافذة ConEmu (للنسخ/اللصق). تم تضمين حيلة مؤقتة للتغلب على هذا مع إصدارات wine الحديثة، لذا يجب أن يعمل التمييز الآن بشكل طبيعي.
   
حول winetricks(.ps1):

- إذا لم تقم بتشغيله ('winetricks' في وحدة تحكم powershell)، فلن يتم تنزيل أي شيء، ولا يوجد عبء إضافي في هذه الحالة.
- العديد من الأفعال (مثل powershell 5.1) تحتاج إلى بعض الملفات الأساسية لاستخلاص محتوى حزم msu. تثبيت هذه الملفات يتطلب تنزيلات ضخمة أولاً، ويستغرق وقتاً طويلاً في أول استخدام. لكن بعد التخزين المؤقت يصبح الأمر سريعاً. على سبيل المثال، إذا جربت 'winetricks ps51' أولاً، سيستغرق تقريباً 15 دقيقة. بعض الأفعال الأخرى قد تستغرق 5 دقائق عند أول استخدام. لكن بعد تنفيذ الفعل مرة واحدة ينتهي هذا الإزعاج.
- يتم تخزين الملفات مؤقتاً في مجلد MyDocuments. إذا استخدمت جميع الأفعال سيشغل ذلك حوالي 800 ميجابايت هناك.
- نأمل دعم أفضل للنواة 64-بت لبعض الأفعال.
- إمكانية استخراج ملف و(محاولة) تثبيته من ملف msu. نفذ 'winetricks install_dll_from_msu' لمعرفة الطريقة.
- إصدار أولي من Powershell 5.1.
- تثبيت تجريبي لـ dotnet481 و dotnet35 (قد تحتاجه تطبيقات غير راضية عن تثبيت dotnet48 الحالي).
- إكمال تلقائي للتاب. ملاحظة: عند استخدام أكثر من فعل من سطر الأوامر يجب فصلها بفاصلة
  من الآن فصاعداً (هكذا يتعامل powershell مع عدة متغيرات)
  لذا 'winetricks riched20 gdiplus' لن تعمل بعد الآن، استخدم 'winetricks riched20,gdiplus' بدلاً من ذلك
- بعض البرامج تفشل في التثبيت/التشغيل عند تجربتها عبر Chocolatey بسبب أخطاء wine. أضفت بعض الحلول المؤقتة لهذه الحالات في winetricks، راجع أدناه.
- أفعال خاصة (winetricks vs19, vs22 و vs22_interactive_installer) لتثبيت Visual Studio Community 2019 و2022 بنجاح (انظر الصورة، >10 دقائق للتثبيت وتتطلب حوالي 10 جيجابايت!، بعد التثبيت شغل devenv.exe من الدليل c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- فعل خاص للوصول إلى أوامر يونكس متنوعة مثل grep و sed و file و less و curl إلخ (winetricks git.portable، تنويه: بعض الأوامر لا تعمل بعد بسبب أخطاء wine)
- تم تضمين بعض سكريبتات powershell المعدلة من مقتطفات أكواد من الإنترنت:
    - كيفية تضمين exe في سكريبت powershell باستخدام Invoke-ReflectivePEInjection (لن يظهر exe في tasklist).
    - كيفية صنع رسائل منبثقة متقدمة
    - تحويل سكريبت powershell (ps1) إلى exe.
    - وبعض الأمور الأخرى
 
     
حول برامج النظام:

تمت إضافة ميزة لاستبدال برامج النظام البسيطة مثل setx.exe بوظيفة في
c:\\Program Files\Powershell\7\profile.ps1. أو إضافة برامج نظام مفقودة مثل getmac.exe.
إذا فشلت البرامج بسبب عدم توفر برامج نظام ناضجة أو مفقودة يمكن كتابة
دالة لإرجاع ما يتوقعه البرنامج.
مثلما أضفت في profile.ps1 (من بين أمور أخرى) wmic.exe يدعم بعض الخيارات الإضافية،
و setx.exe أساسي.
أو يمكنك ببساطة معالجة الوسيطات المرسلة إلى برنامج النظام. راجع profile.ps1 وchoc_install.ps1.
لا يوجد ضمان أن هذا يعمل مع برامج أكثر تعقيداً أيضاً... 
 
ملاحظات:

  - لا تستخدم على wineprefix موجود مسبقًا، فقط على prefix جديد تم إنشاؤه حديثًا! المُثبت يقوم بتثبيت dotnet48 بنفسه بطريقة غير مدروسة ويعبث بمفاتيح السجل.
    إذا كان لديك أي إصدار من dotnet مثبت بالفعل بواسطة winetricks.sh العادي، فمن المحتمل أن يفشل التثبيت، وحتى إذا نجح، ستنتهي غالبًا بـ prefix معطوب.
    إذا كنت بحاجة لتثبيت أشياء باستخدام winetricks.sh العادي للبرامج، لا تستخدم أي من أوامر dotnet*.
    بالمناسبة، أوامر 'Arial' و 'd3dcompiler_47' مثبتة بالفعل بشكل افتراضي.
  - WINEARCH=win32 غير مدعوم!
  - التحديث من إصدار سابق غير مدعوم حاليًا (ربما لاحقًا)

التجميع:
  - إذا كنت ترغب في التجميع بنفسك بدلاً من تنزيل الملفات التنفيذية: راجع تعليمات التجميع في mainv1.c و installer.c
  - ثم انسخ choc_install.ps1 إلى نفس الدليل
  - ثم نفّذ 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---