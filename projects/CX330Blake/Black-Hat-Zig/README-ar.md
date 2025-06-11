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
  <b>مرحباً بالهاكرز. مرحباً بمطوري البرمجيات الخبيثة. مرحباً بمحللي الهندسة العكسية. سعيد برؤيتكم هنا لاستكشاف قوة Zig المظلمة!</b><br/><br/>
  <b>يتم الصيانة والإدارة بواسطة <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## الفهرس

- [المقدمة](#intro)
- [لماذا Zig؟](#why-zig)
- [ترجمة الشيفرات](#compiling-the-codes)
- [وضع الحمولة](#payload-placement)
- [تمويه الحمولة](#payload-obfuscation)
- [تشفير الحمولة](#payload-encryption)
- [تنفيذ الحمولة](#payload-execution)
- [شيل عكسي](#reverse-shell)
- [تقنيات البرمجيات الخبيثة](#malware-techniques)
- [أدوات تطوير البرمجيات الخبيثة](#maldev-tools)
- [المساهمون](#contributors)
- [الشكر والمراجع](#credits--references)
- [تاريخ النجوم](#star-history)
- [إخلاء المسؤولية](#disclaimer)

## المقدمة

> [!IMPORTANT]
> هذا المشروع يتم تحديثه باستمرار!

يوفر هذا المشروع العديد من تطبيقات تقنيات البرمجيات الخبيثة باستخدام لغة Zig حيث أنني من عشاق هذه اللغة. يمكنك استخدام هذا المستودع لتسليح Zig. يتم تحديث Black-Hat-Zig باستمرار للتأكد من احتوائه على أكبر قدر ممكن من المحتوى. سيكون الأمر رائعًا إذا رغبت في إنشاء PR لهذا المشروع.

حسنًا، لنخترق العالم!

## لماذا Zig؟

- 🤝 سهل التفاعل مع شيفرات C/C++
- 🔎 جديد، لذا يصعب اكتشافه
- 💪 تحكم منخفض المستوى قوي، حتى أقل من C
- 😱 من الأصعب إجراء الهندسة العكسية عليه بسبب المترجم الحديث
- 🛡️ تبعيات وقت تشغيل قليلة - لا وجود لمكتبة قياسية ضخمة
- 🎯 لا يوجد سلوك غير معرف - معالجة صريحة للحالات الحديّة تمنع الأعطال

## ترجمة الشيفرات

يمكنك فحص الشيفرات داخل كل مجلد. أيضًا، إذا استخدم الكود واجهة برمجة تطبيقات ويندوز، سترى تلميحًا في ملف `README.md` الخاص بمجلد المشروع، على سبيل المثال، [هذا الملف](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

لقد قمت بالفعل بتعيين هدف البناء الافتراضي المناسب إلى `windows-x86_64` لتلك التي تحتاج إلى واجهة برمجة تطبيقات ويندوز، لذلك يمكنك ببساطة نسخ ولصق الأمر التالي لترجمة الكود أينما كنت على لينكس أو ويندوز أو حتى ماك أو إس! (لكن ستظل بحاجة إلى بيئة ويندوز لتشغيل الملفات التنفيذية)

```bash
zig build
```

## وضع الحمولة

تقنيات لوضع الحمولات الخبيثة في أقسام مختلفة من ملف تنفيذي.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## تمويه الحمولة

تقنيات التمويه لإخفاء الحمولات وتجنب الاكتشاف من خلال التحليل الساكن أو مطابقة الأنماط.

- [تمويه عنوان IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [تمويه IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [إزالة تمويه IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [تمويه IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [إزالة تمويه IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [تمويه عنوان MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [تمويه عنوان MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [إزالة تمويه عنوان MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [تمويه UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [تمويه UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [إزالة تمويه UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## تشفير الحمولة

مخططات تشفير متنوعة تُستخدم لإخفاء النوايا الحقيقية للحمولة أثناء التخزين أو النقل.

- [تشفير XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR باستخدام المكتبة القياسية](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [تشفير RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 باستخدام SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [تشفير AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES باستخدام Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES باستخدام المكتبة القياسية](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES باستخدام TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## تنفيذ الحمولة

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [شيل كود](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## شيل عكسي

بدائيات لإنشاء شيل عكسي للوصول عن بُعد أو التحكم بعد الاستغلال.

- [شيل عكسي باستخدام المكتبة القياسية](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## تقنيات البرمجيات الخبيثة

مجموعة من تقنيات الهجوم الشائعة المعدلة للعمل مع Zig.

- [حقن العمليات](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [حقن DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [حقن شيل كود](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [تسلسل الحمولة](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [من خادم ويب](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [من سجل ويندوز](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [تعداد العمليات](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [باستخدام CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [باستخدام EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [باستخدام NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## أدوات تطوير البرمجيات الخبيثة

- [ZYRA: درعك أثناء التنفيذ](https://github.com/cx330blake/zyra)
  - أداة ضغط تنفيذية مكتوبة بلغة Zig
- [ZYPE: مشفر الحمولات الخاص بك](https://github.com/cx330blake/zype)
  - أنشئ قالب كود بلغة Zig يحتوي على حمولتك المشفرة/المموهة ودالة فك التشفير/إزالة التمويه المقابلة.

## المساهمون

يتم صيانة وإدارة هذا المشروع بشكل رئيسي بواسطة [@CX330Blake](https://github.com/CX330Blake). مرحباً بالمساهمات (PRs). نأمل أن يستخدم المزيد من الأشخاص Zig لتطوير البرمجيات الخبيثة حتى ينضج النظام البيئي.

شكر كبير لهؤلاء المساهمين!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## الشكر والمراجع

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## تاريخ النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## إخلاء المسؤولية

هذا المشروع للأغراض الأخلاقية والتعليمية فقط. لا تكن مجرمًا إلكترونيًا.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---