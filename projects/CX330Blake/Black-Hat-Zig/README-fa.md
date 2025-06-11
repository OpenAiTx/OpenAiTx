# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>سلام هکرها. سلام توسعه‌دهندگان بدافزار. سلام معکوس‌کنندگان. خوشحالم که اینجا هستید تا قدرت تاریک Zig را کشف کنید!</b><br/><br/>
  <b>توسط <a href="https://github.com/cx330blake">@CX330Blake</a> مدیریت و نگهداری می‌شود</b>
</p>

---

## فهرست مطالب

- [مقدمه](#intro)
- [چرا Zig؟](#why-zig)
- [کامپایل کدها](#compiling-the-codes)
- [قراردهی Payload](#payload-placement)
- [ابهام‌سازی Payload](#payload-obfuscation)
- [رمزنگاری Payload](#payload-encryption)
- [اجرای Payload](#payload-execution)
- [شل معکوس](#reverse-shell)
- [تکنیک‌های بدافزاری](#malware-techniques)
- [ابزارهای Maldev](#maldev-tools)
- [مشارکت‌کنندگان](#contributors)
- [اعتبارات و منابع](#credits--references)
- [تاریخچه ستاره‌ها](#star-history)
- [سلب مسئولیت](#disclaimer)

## مقدمه

> [!IMPORTANT]
> این پروژه به طور مداوم بروزرسانی می‌شود!

این پروژه پیاده‌سازی بسیاری از تکنیک‌های بدافزاری با استفاده از Zig را فراهم می‌کند، چراکه من طرفدار بزرگ آن هستم. شما می‌توانید از این مخزن برای مسلح کردن Zig استفاده کنید. Black-Hat-Zig به طور مداوم بروز می‌شود تا مطمئن شود که تا حد امکان محتوای بیشتری دارد. اگر برای این پروژه PR ارسال کنید، عالی خواهد بود.

خب، بیایید سیاره را هک کنیم!

## چرا Zig؟

- 🤝 تعامل آسان با سورس کد C/C++
- 🔎 جدیدتر است، بنابراین شناسایی آن سخت‌تر است
- 💪 کنترل سطح پایین قوی، حتی پایین‌تر از C
- 😱 به دلیل کامپایلر مدرن، معکوس‌ مهندسی آن سخت‌تر است
- 🛡️ وابستگی‌های اجرایی حداقلی - بدون ردپای بزرگ کتابخانه استاندارد
- 🎯 بدون رفتار تعریف‌نشده - مدیریت صریح موارد خاص از کرش جلوگیری می‌کند

## کامپایل کدها

می‌توانید کدها را در هر پوشه بررسی کنید. همچنین اگر کد از Windows API استفاده کند، راهنما را در فایل `README.md` مربوط به آن پروژه خواهید دید، مانند [این مورد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

من قبلاً هدف ساخت پیش‌فرض را برای پروژه‌هایی که به Windows API نیاز دارند روی `windows-x86_64` تنظیم کرده‌ام، بنابراین می‌توانید به راحتی دستور زیر را برای کامپایل کد در هر جایی از لینوکس، ویندوز یا حتی مک‌اواس کپی و اجرا کنید! (اما همچنان برای اجرای فایل‌های اجرایی به محیط ویندوز نیاز دارید)

```bash
zig build
```

## قراردهی Payload

تکنیک‌هایی برای قرار دادن Payload مخرب در بخش‌های مختلف یک فایل اجرایی.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## ابهام‌سازی Payload

تکنیک‌های ابهام‌سازی برای پنهان کردن Payload و جلوگیری از شناسایی با آنالیز استاتیک یا تطبیق الگو.

- [ابهام‌سازی آدرس IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [ابهام‌سازی IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [رفع ابهام IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [ابهام‌سازی IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [رفع ابهام IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [ابهام‌سازی آدرس MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [ابهام‌سازی آدرس MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [رفع ابهام آدرس MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [ابهام‌سازی UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [ابهام‌سازی UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [رفع ابهام UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## رمزنگاری Payload

طرح‌های رمزنگاری مختلف برای پنهان کردن هدف واقعی Payload در زمان ذخیره‌سازی یا انتقال.

- [رمزنگاری XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR با کتابخانه استاندارد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [رمزنگاری RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 با SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [رمزنگاری AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES با Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES با کتابخانه استاندارد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES با TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## اجرای Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [شل‌کد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## شل معکوس

اجزایی برای ایجاد شل معکوس برای دسترسی C2 یا کنترل پس از بهره‌برداری.

- [شل معکوس با کتابخانه استاندارد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## تکنیک‌های بدافزاری

مجموعه‌ای از تکنیک‌های رایج تهاجمی که برای Zig تطبیق داده شده است.

- [تزریق پردازش](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [تزریق DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [تزریق شل‌کد](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [مرحله‌بندی Payload](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [از سرور وب](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [از رجیستری ویندوز](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [شمارش پردازش‌ها](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [با استفاده از CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [با استفاده از EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [با استفاده از NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## ابزارهای Maldev

- [ZYRA: زره‌ اجرایی شما](https://github.com/cx330blake/zyra)
  - یک بسته‌بند اجرایی نوشته شده با Zig
- [ZYPE: رمزنگار Payload شما](https://github.com/cx330blake/zype)
  - تولید یک قالب کد در Zig که حاوی Payload رمزنگاری/ابهام‌سازی شده شما و تابع رمزگشایی/رفع ابهام متناظر است.

## مشارکت‌کنندگان

این پروژه عمدتاً توسط [@CX330Blake](https://github.com/CX330Blake) نگهداری و مدیریت می‌شود. PRها خوش‌آمدند. امیدوارم افراد بیشتری از Zig برای توسعه بدافزار استفاده کنند تا اکوسیستم آن بالغ‌تر شود.

تشکر فراوان از این مشارکت‌کنندگان!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## اعتبارات و منابع

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## تاریخچه ستاره‌ها

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## سلب مسئولیت

این پروژه فقط برای اهداف اخلاقی و آموزشی است. مجرم سایبری نباشید.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---