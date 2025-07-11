# آراپژیاتور با کنترل حرکتی دست

آراپژیاتور، درام ماشین و ویژوالایزر صوتی که با حرکت دست کنترل می‌شود. دست‌هایتان را بالا ببرید تا سقف را بالا ببرید!

یک وب اپلیکیشن تعاملی ساخته‌شده با threejs، بینایی ماشین mediapipe، هوش مصنوعی rosebud و tone.js.

- دست شماره ۱ کنترل آراپژیوها را بر عهده دارد (بالا بردن دست برای بالا بردن گام، جمع کردن انگشتان برای تغییر حجم صدا)
- دست شماره ۲ کنترل درام را بر عهده دارد (بالا بردن انگشتان مختلف برای تغییر الگو)

[ویدیو](https://youtu.be/JepIs-DTBgk?si=4Y-FrQDF6KNy662C) | [دموی زنده](https://collidingscopes.github.io/arpeggiator/) | [کد بیشتر و آموزش‌ها](https://funwithcomputervision.com/)

<img src="https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/assets/demo.png">

## نیازمندی‌ها

- مرورگر وب مدرن با پشتیبانی از WebGL
- دسترسی به دوربین برای رهگیری دست

## فناوری‌ها

- **MediaPipe** برای رهگیری دست و تشخیص حرکات
- **Three.js** برای رندرینگ بصری واکنش‌گرا به صدا
- **Tone.js** برای تولید صداهای سینتی‌سایزر
- **بوم HTML5** برای فیدبک بصری
- **جاوااسکریپت** برای تعامل بلادرنگ
## راه‌اندازی برای توسعه

```bash
# این مخزن را کلون کنید
git clone https://github.com/collidingScopes/arpeggiator

# وارد پوشه پروژه شوید
cd arpeggiator

# با روش دلخواه خود سرو کنید (مثال با استفاده از پایتون)
python -m http.server
```

سپس در مرورگر خود به آدرس `http://localhost:8000` بروید.

## مجوز

مجوز MIT

## اعتبارها
- Three.js - https://threejs.org/
- MediaPipe - https://mediapipe.dev/
- Rosebud AI - https://rosebud.ai/
- Tone.js - https://tonejs.github.io/

## پروژه‌های مرتبط

من چندین پروژه بینایی کامپیوتر (همراه با کد و آموزش) را اینجا منتشر کرده‌ام:
[سرگرمی با بینایی کامپیوتر](https://www.funwithcomputervision.com/)

شما می‌توانید دسترسی مادام‌العمر خریداری کنید و فایل‌های کامل پروژه و آموزش‌ها را دریافت نمایید. من به طور منظم محتوای بیشتری اضافه می‌کنم 🪬

ممکن است برخی از پروژه‌های متن‌باز دیگر من را نیز دوست داشته باشید:

- [زمین بازی مدل سه‌بعدی](https://collidingScopes.github.io/3d-model-playground) - کنترل مدل‌های سه‌بعدی با صدا و حرکات دست
- [آموزش ردیابی دست با Threejs](https://collidingScopes.github.io/threejs-handtracking-101) - راه‌اندازی اولیه ردیابی دست با threejs و بینایی کامپیوتری MediaPipe
- [دریفت ذره‌ای](https://collidingScopes.github.io/particular-drift) - تبدیل عکس‌ها به انیمیشن‌های ذره‌ای جاری
- [ویدئو به ASCII](https://collidingScopes.github.io/ascii) - تبدیل ویدئوها به هنر پیکسلی ASCII
## تماس

- اینستاگرام: [@stereo.drift](https://www.instagram.com/stereo.drift/)
- توییتر/X: [@measure_plan](https://x.com/measure_plan)
- ایمیل: [stereodriftvisuals@gmail.com](https://raw.githubusercontent.com/collidingScopes/arpeggiator/main/mailto:stereodriftvisuals@gmail.com)
- گیت‌هاب: [collidingScopes](https://github.com/collidingScopes)

## کمک مالی

اگر این ابزار برای شما مفید بود، خوشحال می‌شوم اگر یک فنجان قهوه برای من بخرید.

نام من آلن است و من از ساخت نرم‌افزارهای متن‌باز برای بینایی ماشین، بازی‌ها و موارد دیگر لذت می‌برم. این حمایت شما در جلسات برنامه‌نویسی دیرهنگام بسیار ارزشمند خواهد بود!

[![برای من قهوه بخر](https://www.buymeacoffee.com/assets/img/custom_images/yellow_img.png)](https://www.buymeacoffee.com/stereoDrift)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---