```markdown
# ch32fun

بيئة تطوير مفتوحة المصدر (أدوات، رؤوس، أمثلة) لمعالج [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (وعدد كبير من الشرائح الأخرى ضمن عائلة CH32V) باستخدام gcc-riscv64، والتي يمكن استخدامها في أنظمة ويندوز (أصلي)، لينكس و/أو WSL. CH32V003 هو معالج بتكلفة 10 سنتات يحتوي على نواة RISC-V EC بسرعة 48 ميجاهرتز، و16 كيلوبايت من الفلاش و2 كيلوبايت من الذاكرة العشوائية RAM، بالإضافة إلى مجموعة من الوحدات الطرفية. يأتي أيضاً في حزم SOP-8 وQFN-20 وSOIC. يمكنك الحصول على ورقة البيانات من [هنا](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html).

هدف هذا المشروع هو تطوير الأدوات والبيئة لاستخدام فعال لمعالج CH32V003. تجنب استعمال واجهات HAL المعقدة، واستفد من العتاد بشكل مباشر! بيئة EVT الحالية ضخمة وبيئة التطوير ثقيلة. هذا المشروع يتجنب استخدام HAL ويتيح لك استخدام [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) مباشرة. على النقيض من ذلك، برنامج blinky لا يتجاوز 500 بايت مع ch32fun، ويعمل بسرعة أكبر وبشكل أبسط بكثير.

ch32fun يحتوي على:
1. أمثلة باستخدام ch32fun، لكنها ليست بعدد أمثلة HAL. معظمها يتركز حول ch32v003، لكن كثير منها متوافق مع معالجات أخرى.
2. "minichlink" والذي يستخدم WCH CH-Link مع libusb، للاستخدام عبر الأنظمة.
   * مبرمج STM32F042، [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * مبرمج ESP32S2، [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * مبرمج WCH Link-E الرسمي.
   * واجهة مبنية على أردوينو، [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * يدعم تصحيح الأخطاء بأسلوب gdbserver للاستخدام مع Visual Studio.
   * يدعم printf عبر سلك واحد. (بسرعة تقارب 400kBaud)
3. نسخة إضافية من libgcc لتتمكن من استخدام سلاسل بناء RISC-V غير اعتيادية، موجودة في `misc/libgcc.a`.
4. مجلد باسم "ch32fun" يحتوي على ملف مصدر وملف رأس مستقل لتجميع التطبيقات لمعالج ch32v003.
5. في بعض الأنظمة إمكانية "printf" عبر
6. محمل إقلاع تجريبي.

## دعم عائلات أخرى

حالياً، هناك دعم تجريبي لـ ch32v103، ch32v203، ch32v208، ch32v303، ch32v305 و ch32v307. تم اختبار GDB بشكل رئيسي على 003، لكنه يعمل بدرجة محدودة على معالجات أخرى.

## البدء السريع

لتعليمات التثبيت/الإعداد، راجع [صفحة الويكي هنا](https://github.com/cnlohr/ch32fun/wiki/Installation)

## الميزات!

### printf سريع للغاية للتصحيح عبر واجهة البرمجة

وسريع هنا تعني سريع جداً. عادة حوالي 36 كيلوبايت/ثانية.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

يمكنك تجربة مشروع debugprintf، أو استدعاء SetupDebugPrintf(); وابدأ باستخدام printf() مباشرة.

### دعم التصحيح!

عن طريق gdbserver المدمج في minichlink! يعمل مع `gdb-multiarch` وأيضاً داخل Visual Studio Code.

## البناء والبرمجة

```
cd examples/blink
make
```

text = كود البرنامج، data = القيم الثابتة وقيم التهيئة، bss = القيم غير المهيأة.  
dec هو مجموع الثلاثة ويعكس عدد البايتات في الفلاش التي سيشغلها البرنامج.

الملف .bin الناتج يستخدم بواسطة minichlink وملف .hex متوافق مع أداة WCH الرسمية للبرمجة.

## VSCode +/- PlatformIO

ملاحظة: PlatformIO يُستخدم عادةً في CI لهذا المستودع. بالرغم من أنه يمكن استخدام PlatformIO لكتابة وتصحيح مشاريع ch32fun داخل VSCode، يمكنك أيضاً القيام بذلك بدون PlatformIO: راجع [مشروع القالب](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode).

يمكن بناء، رفع، وتصحيح هذا المشروع باستخدام VSCode وامتداد PlatformIO. فقط قم باستنساخ وفتح المشروع في VSCode وتأكد من تثبيت الامتداد. استخدم [مبدّل بيئة المشروع](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) لاختيار مثال معين، مثل "blink".

لإنشاء مشروع firmware جديد في PlatformIO يعتمد على ch32fun، استخدم معالج "مشروع جديد" في [الصفحة الرئيسية لـ PlatformIO](https://docs.platformio.org/en/latest/home/index.html) واجعل "الإطار" هو "ch32v003fun". هناك [أمثلة متنوعة](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun).

![pio_proj](.github/pio_project_creation.png)

الأمر المكافئ في [منصة PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) هو:
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

إذا كنت ترغب بإضافة كودك مباشرة إلى مشروع ch32fun، يرجى توسيع البيئات المتاحة في `platformio.ini` كما هو [موضح هنا](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53).

يرجى أيضاً ملاحظة أنه عند فتح المشروع داخل PlatformIO، يمكنك استخدام [مبدّل بيئة المشروع](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) في أسفل شريط مهام VSCode لاختيار مجلد مثال معين. وإلا، فإن "Build" سيقوم بشكل افتراضي ببناء **جميع** الأمثلة.

راجع [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) لمزيد من التفاصيل وطريقة تثبيت المنصة.

## clangd

إذا لم يتمكن خادم لغة C/C++ (clangd) من العثور على `ch32fun.h`، يجب تنظيف المثال باستخدام `make clean` ثم بناؤه مرة واحدة مع `bear -- make build`، ما سينتج ملف `compile_commands.json`، والذي يستخدمه clangd للعثور على مسارات التضمين المحددة في ملفات make.  
`make clangd` يقوم بذلك في خطوة واحدة.  
`build_all_clangd.sh` الموجود في `build scripts` يقوم بذلك لجميع الأمثلة.

## مرجع سريع
 * **مطلوب** للبرمجة/التصحيح: `SWIO` على المنفذ `PD1`. لا تعيد استخدام PD1 لأكثر من وظيفة.
 * **اختياري** `NRST` على المنفذ `PD7`. ليس ضرورياً، ويعمل كـ GPIO افتراضياً في بعض الإعدادات.
 * **اختياري** UART `TX` على: `PD5`. نوصي باستخدام SWIO لتصحيح printf.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## المزيد من الأمثلة / المشاريع؟

هناك أدوات أخرى من أطراف ثالثة تضيف العديد من الأمثلة وغيرها. راجع المستودعات التالية لمكتبات إضافية وغيرها.
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## الدعم

يمكنك فتح تذكرة على github أو الانضمام إلى خادم Discord الخاص بي في قناة #ch32fun. حالياً الدعوات خاصة، فقط أرسل لي @cnlohr للحصول على رابط الدعوة. الرسائل الخاصة مفتوحة.

### الحواشي/الروابط

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf دليل التصحيح
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html دليل المعالج
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html الدليل المرجعي الفني
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html ورقة البيانات
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md تفاصيل ISA المضغوطة على هذه الشريحة.
 * يحتوي CH32V003 على امتدادات xv، يمكنك استخدام هذا الإصدار المخصص من rvcodec.js للعمل مع تعليماته البرمجية: https://xw.macyler.moe/
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---