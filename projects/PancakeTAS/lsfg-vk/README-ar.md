# lsfg-vk
يجلب هذا المشروع [توليد الإطارات من Lossless Scaling](https://store.steampowered.com/app/993090/Lossless_Scaling/) إلى لينكس!
>[!NOTE]
> هذا العمل قيد الإنجاز. على الرغم من أن توليد الإطارات عمل في بعض الألعاب، لا يزال الطريق طويلاً أمامنا. يرجى مراجعة الويكي للدعم (الويكي لم يُكتب بعد)

## البناء، التثبيت والتشغيل

>[!CAUTION]
> تم تغيير تعليمات البناء مؤخراً. يرجى مراجعتها.

لكي تقوم بترجمة LSFG، تأكد من تثبيت المكونات التالية على نظامك:
- أدوات البناء التقليدية (+ sed, git)
- مترجم Clang (هذا المشروع لا يُترجم بسهولة مع GCC)
- ملفات ترويسة Vulkan
- نظام البناء CMake
- نظام البناء Meson (من أجل DXVK)
- نظام البناء Ninja (خلفية لـCMake)

ترجمة lsfg-vk مباشرة نسبياً، حيث أن كل شيء مدمج بشكل منظم في CMake:
```bash
$ cmake -B build -G Ninja \
    -DCMAKE_BUILD_TYPE=Release \
    -DCMAKE_INSTALL_PREFIX=~/.local \
    -DCMAKE_INTERPROCEDURAL_OPTIMIZATION=ON \
    -DCMAKE_CXX_CLANG_TIDY=""
$ cmake --build build
$ cmake --install build
```
سيتم تثبيت lsfg-vk في ~/.local/lib و ~/.local/share/vulkan.

بعد ذلك، ستحتاج إلى تنزيل Lossless Scaling من Steam. انتقل إلى الفرع `legacy_2.13` أو قم بتنزيل المستودع المقابل.
انسخ أو لاحظ مسار "Lossless.dll" من ملفات اللعبة.

وأخيراً، دعونا نبدأ برنامجاً مع تمكين توليد الإطارات. سأستخدم `vkcube` في هذا المثال:
```bash
VK_INSTANCE_LAYERS="VK_LAYER_LS_frame_generation" LSFG_DLL_PATH="/home/pancake/games/Lossless Scaling/Lossless.dll" LSFG_MULTIPLIER=4 vkcube
```
تأكد من تعديل المسارات. دعونا نفحص كل واحدة منها:
- `LVK_INSTANCE_LAYERS`: حدد هنا `VK_LAYER_LS_frame_generation`. هذا يجبر أي تطبيق Vulkan على تحميل طبقة lsfg-vk.
- `LSFG_DLL_PATH`: هنا تحدد ملف Lossless.dll الذي قمت بتنزيله من Steam. سيقوم lsfg-vk باستخراج وترجمة التظليلات من هنا.
- `LSFG_MULTIPLIER`: هذا هو المضاعف الذي يجب أن تكون على دراية به. حدد `2` لمضاعفة معدل الإطارات، وهكذا.
- `VK_LAYER_PATH`: إذا لم تثبت في `~/.local` أو `/usr`، يجب عليك تحديد مجلد `explicit_layer.d` هنا.

>[!WARNING]
> على عكس ويندوز، LSFG_MULTIPLIER هنا محدود بشكل كبير (في الوقت الحالي!). إذا كان جهازك يمكنه إنشاء 8 صور swapchain، فإن تعيين LSFG_MULTIPLIER إلى 4 سيشغل 4 منها، ويترك فقط 4 للعبة. إذا طلبت اللعبة 5 أو أكثر، فسوف تنهار.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-05

---