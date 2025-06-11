# Visage: کتابخانه رابط کاربری ملاقات با برنامه‌نویسی خلاقانه

**Visage** یک کتابخانه C++ شتاب‌یافته توسط GPU و چندسکویی برای رابط کاربری بومی و گرافیک دوبعدی است. این کتابخانه ساختار یک چارچوب رابط کاربری را با ویژگی‌های کتابخانه‌های گرافیکی خلاقانه ادغام می‌کند.

## مثال کامل پایه
```cpp
#include <https://raw.githubusercontent.com/VitalAudio/visage/main/visage_app/application_window.h>

int main() {
  visage::ApplicationWindow app;

  app.onDraw() = [&app](visage::Canvas& canvas) {
    canvas.setColor(0xffff00ff);
    canvas.fill(0, 0, app.width(), app.height());
  };

  app.show(800, 600); // باز می‌شود به عنوان پنجره‌ای با ابعاد ۸۰۰ در ۶۰۰ پیکسل
  app.runEventLoop(); // رویدادهای پنجره را اجرا می‌کند. وقتی پنجره بسته شود بازمی‌گردد.
  return 0;
}
```

## دموها
- [نمایشگاه](https://visage.dev/examples/Showcase/)
- [حالت‌های ترکیب](https://visage.dev/examples/BlendModes/)
- [بلوم](https://visage.dev/examples/Bloom/)
- [گرادیان‌ها](https://visage.dev/examples/Gradients/)
- [افکت‌های پس از شیدر](https://visage.dev/examples/PostEffects/)
- [ویرایش زنده شیدر](https://visage.dev/examples/LiveShaderEditing/)
- [چیدمان انعطاف‌پذیر](https://visage.dev/examples/Layout/)

## ویژگی‌های رابط کاربری

- **نرمال‌سازی رویدادها**  
&nbsp;&nbsp;&nbsp;پشتیبانی چندسکویی برای نرمال‌سازی ورودی صفحه‌کلید و ماوس.

- **نرمال‌سازی پنجره**  
&nbsp;&nbsp;&nbsp;پشتیبانی چندسکویی برای باز کردن و مدیریت پنجره‌ها.

- **ورود متن**  
&nbsp;&nbsp;&nbsp;ورود متن یونیکد با ویرایش متن چندخطی

- **✨ ایموجی‌ها ✨**  
&nbsp;&nbsp;&nbsp;اگر طرفدار این چیزها هستید 🤷

- **رندر جزئی**  
&nbsp;&nbsp;&nbsp;فقط مناطق تغییر یافته را بازنقاشی می‌کند برای عملکرد بهینه.

## ویژگی‌های گرافیکی

- **حرکت روان**  
&nbsp;&nbsp;&nbsp;فریم‌های جدید با نرخ تازه‌سازی مانیتور نمایش داده می‌شوند و انیمیشن‌ها روان هستند

- **گروه‌بندی خودکار اشکال**  
&nbsp;&nbsp;&nbsp;اشکال را به طور خودکار برای رندر کارآمد روی GPU گروه‌بندی می‌کند.

- **حالت‌های ترکیب**  
&nbsp;&nbsp;&nbsp;پشتیبانی از ترکیب لایه‌ها با حالت‌های جمعی، تفریقی یا با رسم ماسک سفارشی برای عبور رابط کاربری

- **شیدرها**  
&nbsp;&nbsp;&nbsp;شیدرها را یکبار بنویسید و آن‌ها را برای Direct3D، Metal و OpenGL تبدیل کنید

- **افکت‌های گنجانده شده**  
&nbsp;&nbsp;&nbsp;افکت‌های زمان واقعی مانند بلور بزرگ و بلوم

- **دقت پیکسلی**  
&nbsp;&nbsp;&nbsp;دسترسی به اندازه پیکسل دستگاه تضمین می‌کند که رندر دقیق بدون تار شدن انجام شود.

## پلتفرم‌های پشتیبانی شده
- **ویندوز**: Direct3D11
- **مک‌اواس**: Metal  
- **لینوکس**: Vulkan
- **وب/ام‌اسکریپتن**: WebGL

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---