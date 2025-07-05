# lsfg-vk
این پروژه [تولید فریم Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) را به لینوکس می‌آورد!
>[!NOTE]
> این پروژه در حال توسعه است. در حالی که تولید فریم در چند بازی کار کرده است، هنوز راه زیادی تا تکمیل باقی مانده است. لطفاً برای پشتیبانی ویکی را مرور کنید (ویکی هنوز نوشته نشده است)

## ساخت، نصب و اجرا

>[!CAUTION]
> دستورالعمل‌های ساخت اخیراً تغییر کرده‌اند. لطفاً آن‌ها را مرور کنید.

برای کامپایل LSFG، مطمئن شوید که اجزای زیر روی سیستم شما نصب شده باشند:
- ابزارهای ساخت سنتی (+ sed, git)
- کامپایلر Clang (این پروژه به راحتی با GCC کامپایل نمی‌شود)
- فایل‌های هدر Vulkan
- سیستم ساخت CMake
- سیستم ساخت Meson (برای DXVK)
- سیستم ساخت Ninja (backend برای CMake)

کامپایل lsfg-vk نسبتاً ساده است، زیرا همه چیز به طور منظم در CMake یکپارچه شده است:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
این دستور lsfg-vk را در مسیر ~/.local/lib و ~/.local/share/vulkan نصب می‌کند.

در مرحله بعد، باید Lossless Scaling را از استیم دانلود کنید. به شاخه `legacy_2.13` سوئیچ کنید یا دیپوی مربوطه را دانلود نمایید.
مسیر "Lossless.dll" را از فایل‌های بازی کپی یا یادداشت کنید.

در نهایت، بیایید واقعاً یک برنامه را با تولید فریم فعال اجرا کنیم. برای این مثال من از `vkcube` استفاده می‌کنم:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
حتماً مسیرها را متناسب با سیستم خود تنظیم کنید. بیایید هر کدام را بررسی کنیم:
- `VK_INSTANCE_LAYERS`: اینجا مقدار `VK_LAYER_LS_frame_generation` را مشخص کنید. این کار باعث می‌شود هر برنامه Vulkan لایه lsfg-vk را بارگذاری کند.
- `LSFG_DLL_PATH`: در اینجا فایل Lossless.dll که از استیم دانلود کردید را مشخص می‌کنید. lsfg-vk شیدرها را از اینجا استخراج و ترجمه می‌کند.
- `LSFG_MULTIPLIER`: این همان ضریبی است که باید با آن آشنا باشید. مقدار `2` را برای دو برابر کردن نرخ فریم و غیره تعیین کنید.
- `VK_LAYER_PATH`: اگر در مسیر `~/.local` یا `/usr` نصب نکرده‌اید، باید پوشه `explicit_layer.d` را اینجا مشخص کنید.

>[!WARNING]
> برخلاف ویندوز، LSFG_MULTIPLIER در اینجا (در حال حاضر!) به شدت محدود است. اگر سخت‌افزار شما بتواند ۸ تصویر swapchain ایجاد کند، تنظیم LSFG_MULTIPLIER روی ۴ چهار تای آن‌ها را اشغال می‌کند و فقط ۴ تصویر برای بازی باقی می‌گذارد. اگر بازی ۵ یا بیشتر درخواست کند، کرش خواهد کرد.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---