<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=TwooSix&project=Alist-MikananiRss&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

<h1 align="center">
  Alist-MikananiRss
</h1>
<p align="center">
  احصل تلقائيًا على تحديثات الأنمي من <a href="https://mikanani.me/">مشروع ميكان</a> أو مصادر RSS الأخرى ذات الصلة بأنمي، وقم بتحميلها إلى سحابة التخزين المقابلة عبر Alist بدون اتصال.
</p>  
<p align="center">
  وبالاقتران مع استخدام ChatGPT لتحليل أسماء الموارد، يتم إعادة تسمية الملفات إلى تنسيق يمكن لـ Emby التعرف عليه.
</p>
</p>  

--- 

[دليل الاستخدام](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B)
## الميزات
- الحصول تلقائيًا على تحديثات الأنمي وتحميلها إلى السحابة المناسبة
- إرسال إشعارات التحديث عبر قنوات مثل PushPlus وTelegram
- إعادة التسمية تلقائيًا إلى تنسيق يمكن لـ emby التعرف عليه، مع دعم إعادة التعيين المخصص للنتائج المحللة تلقائيًا لجعل إعادة التسمية أكثر دقة

## التحضيرات
1. يرجى اتباع وثائق مشروع [Alist](https://github.com/alist-org/alist) لنشر Alist بنفسك (الإصدار يجب أن يكون >=3.42.0)، وبناء Aria2/qBittorrent للتحميل دون اتصال بالإنترنت
2. قم بالتسجيل في مشروع Mikan بنفسك، اشترك في الأنمي، واحصل على رابط الاشتراك

ملاحظة: تم تكييفه أيضًا مع مصادر RSS الأخرى، نظريًا يدعم معظم مصادر الاشتراك (ذات الصلة بالأنمي)، لأي RSS غير مدعوم، نرحب بطرح issue

## كيفية الاستخدام
لمزيد من طرق التشغيل مثل Docker أو التشغيل من المصدر راجع [دليل الاستخدام](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E5%BF%AB%E9%80%9F%E5%BC%80%E5%A7%8B) 

التثبيت والتشغيل عبر pip
1. تأكد من أن إصدار python لديك أعلى من 3.11
2. التثبيت عبر pip: `pip install alist-mikananirss`
3. أنشئ ملف إعدادات جديد باسم `config.yaml` في المجلد، واملأه كما يلي (لشرح مفصل لجميع الميزات راجع [توضيح الإعدادات](https://github.com/TwooSix/Alist-MikananiRss/wiki/%E9%85%8D%E7%BD%AE%E8%AF%B4%E6%98%8E))
   ```yaml
   common:
     interval_time: 300
   
   alist:
     base_url: https://example.com # 修改为你的alist访问地址
     token: alist-xxx # 修改为你的alist token；可在"管理员后台->设置->其他"中找到
     downloader: qBittorrent # 或者 aria2
     download_path: Onedrive/Anime # 修改为你的下载路径(Alist中的路径)

   mikan:
     subscribe_url:
       - https://mikanani.me/RSS/MyBangumi?token=xxx # 修改为你的蜜柑订阅地址
       # - https://mikanani.me/RSS/MyBangumi?token=xxx2 # 多条RSS订阅链接情况
   
     filters:
       - 非合集 # 程序暂不支持合集等形式的重命名，若使用重命名功能推荐使用此过滤器
   ```
4. شغّل الكود: `python -m alist_mikananirss --config /path/to/config.yaml`  
5. استمتع


## عرض تأثير إعادة التسمية
<div align=center>
<img src="https://github.com/TwooSix/Alist-MikananiRss/blob/master/imgs/show_pic1.png"/>
</div>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-12-23

---