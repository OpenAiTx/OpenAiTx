# ch32fun

یک محیط توسعه متن‌باز (ابزارها، هدرها، مثال‌ها) برای [CH32V003](http://www.wch-ic.com/products/CH32V003.html) (و بسیاری از چیپ‌های دیگر خانواده CH32V) با gcc-riscv64 که قابل استفاده در ویندوز (به‌صورت بومی)، لینوکس و/یا WSL است. CH32V003 یک قطعه ۱۰ سنتی با هسته RISC-V EC است که با فرکانس ۴۸MHz اجرا می‌شود، ۱۶ کیلوبایت فلش و ۲ کیلوبایت رم دارد و مجموعه‌ای از پریفرال‌ها را پشتیبانی می‌کند. همچنین در پکیج‌های SOP-8، QFN-20 و SOIC عرضه می‌شود. دیتاشیت آن را می‌توانید [اینجا](http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html) دریافت کنید.

هدف این پروژه توسعه ابزارها و محیط برای استفاده بهینه از CH32V003 است. از HALهای پیچیده پرهیز کنید و سخت‌افزار را به‌طور مستقیم استفاده کنید! EVT موجود بسیار حجیم و محیط توسعه سنگین است. این پروژه به طور خاص از HAL اجتناب کرده و به شما اجازه می‌دهد فقط از [TRM](http://www.wch-ic.com/downloads/CH32V003RM_PDF.html) استفاده کنید. در مقابل، برنامه Blinky فقط ۵۰۰ بایت با ch32fun حجم دارد، سریع‌تر بوت می‌شود و به طور قابل توجهی ساده‌تر است.

ch32fun شامل موارد زیر است:
1. مثال‌هایی با استفاده از ch32fun، اما نه به تعداد مثال‌های مبتنی بر HAL. بیشتر آن‌ها حول ch32v003 متمرکزند، اما بسیاری از آن‌ها با پردازنده‌های دیگر نیز سازگارند.
2. "minichlink" که از WCH CH-Link با libusb برای استفاده چندسکویی بهره می‌برد.
   * یک پروگرامر STM32F042، [NHC-Link042](https://github.com/NgoHungCuong/NHC-Link042)
   * یک پروگرامر ESP32S2، [esp32s2-funprog](https://github.com/cnlohr/esp32s2-cookbook/tree/master/ch32v003programmer)
   * پروگرامر رسمی WCH Link-E.
   * یک رابط مبتنی بر Arduino، [Ardulink](https://gitlab.com/BlueSyncLine/arduino-ch32v003-swio).
   * پشتیبانی از اشکال‌زدایی به سبک gdbserver جهت استفاده با Visual Studio.
   * پشتیبانی از printf از طریق تک‌سیم. (حدود ۴۰۰ کیلوبود)
3. یک کپی اضافی از libgcc برای امکان استفاده از زنجیره‌های ساخت RISC-V غیرمعمول، در مسیر `misc/libgcc.a`.
4. پوشه‌ای به نام "ch32fun" شامل یک فایل منبع و هدر خودکفا برای کامپایل برنامه‌ها برای ch32v003.
5. در برخی سیستم‌ها امکان ارسال "printf" برگشتی
6. یک بوت‌لودر نمایشی.

## پشتیبانی از خانواده‌های دیگر

در حال حاضر، پشتیبانی آزمایشی برای ch32v103، ch32v203، ch32v208، ch32v303، ch32v305 و ch32v307 وجود دارد. GDB عمدتاً روی ۰۰۳ تست شده است، اما تا حد محدودی روی سایر پردازنده‌ها نیز کار می‌کند.

## شروع به کار

برای دستورالعمل نصب/راه‌اندازی، به [صفحه ویکی اینجا](https://github.com/cnlohr/ch32fun/wiki/Installation) مراجعه کنید.

## امکانات!

###  اشکال‌زدایی سریع "printf" از طریق رابط پروگرامینگ

و منظور از سریع، واقعاً سریع است. معمولاً حدود ۳۶ کیلوبایت بر ثانیه.

```
./minichlink -T | pv > /dev/null
Found ESP32S2 Programmer
 536KiB 0:00:15 [36.7KiB/s] [        <=>                     ]
```

می‌توانید پروژه debugprintf را امتحان کنید یا فقط SetupDebugPrintf(); را فراخوانی و printf() کنید.

### پشتیبانی از اشکال‌زدایی!

از طریق gdbserver ساخته‌شده در minichlink! هم با `gdb-multiarch` و هم در Visual Studio Code کار می‌کند.

## ساخت و فلش کردن

```
cd examples/blink
make
```

text = کد، data = مقادیر ثابت و مقادیر مقداردهی اولیه، bss = مقادیر مقداردهی‌نشده  
dec جمع این ۳ است و نشان‌دهنده تعداد بایت‌هایی است که برنامه در فلش اشغال می‌کند.

فایل .bin تولیدشده توسط minichlink استفاده می‌شود و فایل .hex با ابزار رسمی WCH سازگار است.

## VSCode +/- PlatformIO

توجه: PlatformIO عمدتاً برای CI این مخزن استفاده می‌شود. در حالی که PlatformIO می‌تواند برای کدنویسی و دیباگ پروژه ch32fun در VSCode استفاده شود، می‌توانید کاملاً بدون PlatformIO هم این کار را انجام دهید: برای این منظور به [پروژه قالب](https://github.com/cnlohr/ch32fun/tree/master/examples/template/.vscode) مراجعه کنید.

این پروژه را می‌توان با VSCode و افزونه PlatformIO ساخت، آپلود و دیباگ کرد. کافی است پروژه را کلون و در VSCode باز کنید و افزونه PlatformIO نصب باشد. از [سوئیچر محیط پروژه](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) برای انتخاب مثال خاص مانند "blink" استفاده کنید.

برای ساخت یک پروژه firmware جدید PlatformIO مبتنی بر ch32fun، کافی است از ویزارد "New Project" در [PlatformIO Home](https://docs.platformio.org/en/latest/home/index.html) استفاده کرده و "Framework" را روی "ch32v003fun" بگذارید. [مثال‌های مختلف](https://github.com/Community-PIO-CH32V/platform-ch32v/tree/develop/examples/blinky-ch32v003fun) موجود است.

![pio_proj](https://raw.githubusercontent.com/cnlohr/ch32fun/master/.github/pio_project_creation.png)

معادل دستور [PlatformIO Core CLI](https://docs.platformio.org/en/latest/integration/ide/vscode.html#platformio-core-cli) به صورت زیر خواهد بود:
```sh
pio init -b genericCH32V003F4P6 -O "framework = ch32v003fun"
```

اگر می‌خواهید کد خود را مستقیماً به پروژه ch32fun اضافه کنید، لطفاً محیط‌های موجود در `platformio.ini` را طبق [دستورالعمل](https://github.com/cnlohr/ch32fun/blob/49640fbccf231191aa83c6a2bbe9d385535b2d1e/platformio.ini#L48-L53) گسترش دهید.

همچنین توجه داشته باشید زمانی که این پروژه را در PlatformIO باز می‌کنید، می‌توانید با [سوئیچر محیط پروژه](https://docs.platformio.org/en/latest/integration/ide/vscode.html#project-tasks) در پایین نوار وظیفه VSCode یک پوشه مثال خاص را انتخاب کنید. در غیر این صورت، "Build" به طور پیش‌فرض **همه** مثال‌ها را می‌سازد.

برای جزئیات بیشتر و نصب پلتفرم به [platform-ch32v](https://github.com/Community-PIO-CH32V/platform-ch32v) مراجعه کنید.

## clangd

اگر سرور زبان C/C++ یعنی clangd قادر به یافتن `ch32fun.h` نیست، باید مثال را با `make clean` پاک کرده و یکبار با `bear -- make build` بسازید تا فایل `compile_commands.json` تولید شود که clangd مسیرهای include مشخص‌شده در Makefileها را پیدا کند.  
`make clangd` این کار را در یک مرحله انجام می‌دهد.  
`build_all_clangd.sh` در `build scripts` این کار را برای همه مثال‌ها انجام می‌دهد.

## مرجع سریع
 * **اجباری** برای برنامه‌نویسی/دیباگ: `SWIO` روی `PD1` است. از PD1 برای چند عملکرد استفاده نکنید.
 * **اختیاری** `NRST` روی `PD7` است. مورد نیاز نیست، در برخی پیکربندی‌ها به طور پیش‌فرض به عنوان GPIO تنظیم می‌شود.
 * **اختیاری** UART `TX` روی: `PD5` قرار دارد. توصیه می‌شود برای اشکال‌زدایی printf از SWIO استفاده شود.

![ch32v003a4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003a4m6.svg)
![ch32v003f4p6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4p6.svg)
![ch32v003f4u6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003f4u6.svg)
![ch32v003j4m6](https://raw.githubusercontent.com/Tengo10/pinout-overview/main/pinouts/CH32v003/ch32v003j4m6.svg)

## مثال‌ها / پروژه‌های بیشتر؟

ابزارهای شخص ثالث دیگر در حال افزودن مثال‌ها و کتابخانه‌های زیادی هستند. برای کتابخانه‌های اضافه و غیره به مخازن زیر مراجعه کنید:
 * [ch32v003fun_wildwest](https://github.com/recallmenot/ch32v003fun_wildwest)
 * [ch32v003fun_libs](https://github.com/hexeguitar/ch32v003fun_libs)
 * [CH32V003_lib_uart](https://github.com/ADBeta/CH32V003_lib_uart)
 * [CH32Vxxx_lib_i2c](https://github.com/ADBeta/CH32Vxxx_lib_i2c)
 * [CH32Vxxx_lib_swi2c](https://github.com/ADBeta/CH32Vxxx_lib_swi2c)
 * [ch32v003fun_shenanigans](https://github.com/DeadBugEngineering/ch32v003fun_shenanigans)
 * [ch32fun-bmp280-driver](https://github.com/pabloestrado/ch32fun-bmp280-driver)
 * [ch32fun-aht20-driver](https://github.com/pabloestrado/ch32fun-aht20-driver)

## پشتیبانی

می‌توانید یک تیکت گیت‌هاب باز کنید یا به Discord من در کانال #ch32fun بپیوندید. در حال حاضر دعوت‌نامه‌ها خصوصی است، پس کافی است به من @cnlohr پیام دهید تا لینک دعوت را ارسال کنم. پیام خصوصی من باز است.

### پاورقی/لینک‌ها

 * https://raw.githubusercontent.com/openwch/ch32v003/main/RISC-V%20QingKeV2%20Microprocessor%20Debug%20Manual.pdf راهنمای اشکال‌زدایی
 * http://www.wch-ic.com/downloads/QingKeV2_Processor_Manual_PDF.html راهنمای پردازنده
 * http://www.wch-ic.com/downloads/CH32V003RM_PDF.html راهنمای مرجع فنی
 * http://www.wch-ic.com/downloads/CH32V003DS0_PDF.html دیتاشیت
 * https://github.com/CaiB/CH32V003-Architecture-Exploration/blob/main/InstructionTypes.md جزئیات ISA فشرده این چیپ
 * CH32V003 دارای xv extensions است، می‌توانید از نسخه سفارشی rvcodec.js برای کار با opcodeهای آن استفاده کنید: https://xw.macyler.moe/

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---