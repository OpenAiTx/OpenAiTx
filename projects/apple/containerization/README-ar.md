# الحاويات

تسمح حزمة الحاويات للتطبيقات باستخدام حاويات لينكس.  
تم كتابة الحاويات بلغة [Swift](https://www.swift.org) وتستخدم [Virtualization.framework](https://developer.apple.com/documentation/virtualization) على شرائح أبل.

توفر الحاويات واجهات برمجة تطبيقات لـ:

- [إدارة صور OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).
- [التفاعل مع السجلات البعيدة](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).
- [إنشاء وملء أنظمة ملفات ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).
- [التفاعل مع عائلة مقبس Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).
- [إنشاء نواة لينكس محسّنة لأوقات إقلاع سريعة](https://raw.githubusercontent.com/apple/containerization/main/kernel/).
- [تشغيل آلات افتراضية خفيفة الوزن وإدارة بيئة التشغيل](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).
- [تشغيل والتفاعل مع العمليات المحوطة](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).
- استخدام Rosetta 2 لتشغيل حاويات linux/amd64 على شرائح أبل.

يرجى الاطلاع على [توثيق API](https://apple.github.io/containerization/documentation/) لمعلومات حول حزم Swift التي توفرها الحاويات.

## التصميم

تنفذ الحاويات كل حاوية لينكس داخل آلة افتراضية خفيفة الوزن خاصة بها. يمكن للعملاء إنشاء عناوين IP مخصصة لكل حاوية لإزالة الحاجة إلى توجيه منفذ فردي. تحقق الحاويات أوقات بدء أقل من ثانية باستخدام [تكوين نواة لينكس محسّنة](https://raw.githubusercontent.com/apple/containerization/main/kernel) ونظام ملفات جذر بسيط مع نظام init خفيف الوزن.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) هو نظام init صغير، وهو مشروع فرعي ضمن الحاويات.  
يتم تشغيل `vminitd` كعملية أولية داخل الآلة الافتراضية ويوفر واجهة GRPC عبر vsock.  
تتيح الواجهة تكوين بيئة التشغيل وتشغيل العمليات المحوطة.  
يوفر `vminitd` عمليات الإدخال/الإخراج، والإشارات، والأحداث للعملية المستدعية عند تشغيل عملية.

## المتطلبات

تحتاج إلى جهاز Mac بشريحة أبل لبناء وتشغيل الحاويات.

لبناء حزمة الحاويات، يجب أن يحتوي نظامك على أحد التالي:

- macOS 15 أو أحدث وXcode 26 بيتا
- macOS 26 بيتا أو أحدث

التطبيقات المبنية باستخدام الحزمة ستعمل على macOS 15 أو أحدث، لكن الميزات التالية غير متاحة على macOS 15:

- الشبكات غير المعزولة للحاويات - مع macOS 15، لا يمكن للحاويات على نفس شبكة vmnet التواصل مع بعضها.

## مثال على الاستخدام

للحصول على أمثلة عن كيفية استخدام بعض واجهات المكتبة، يعتبر التنفيذ التنفيذي cctl بداية جيدة. الوظيفة الأساسية لهذه الأداة هي كملعب لتجربة API. تحتوي على أوامر تمارس بعض الوظائف الأساسية للمنتجات المختلفة، مثل:

1. [التعامل مع صور OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [تسجيل الدخول إلى سجلات الحاويات](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [إنشاء كتل نظام ملفات الجذر](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [تشغيل حاويات لينكس بسيطة](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## نواة لينكس

نواة لينكس مطلوبة لتشغيل آلات افتراضية خفيفة الوزن على macOS.  
توفر الحاويات تكوين نواة محسّن موجود في دليل [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel).

يحتوي هذا الدليل على بيئة بناء محوطة لتسهيل تجميع نواة للاستخدام مع الحاويات.

تكوين النواة هو مجموعة ميزات بسيطة لدعم أوقات بدء سريعة وبيئة خفيفة الوزن.

بينما سيعمل هذا التكوين لمعظم أحمال العمل، نفهم أن بعض الحالات قد تحتاج إلى ميزات إضافية.  
لحل هذا، توفر الحاويات واجهات برمجة تطبيقات من الدرجة الأولى لاستخدام تكوينات وإصدارات نواة مختلفة على أساس كل حاوية.  
يمكن ذلك من تطوير الحاويات والتحقق منها عبر إصدارات نواة مختلفة.

راجع [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) في دليل النواة للحصول على تعليمات حول كيفية تجميع النواة المحسنة.

### نواة مبنية مسبقًا

إذا كنت ترغب في استخدام نواة مبنية مسبقًا، يجب أن تحتوي على برامج تشغيل `VIRTIO` مدمجة داخل النواة، وليس كوحدات.

يوفر مشروع [Kata Containers](https://github.com/kata-containers/kata-containers) نواة محسنة للحاويات مع تمكين جميع خيارات التكوين المطلوبة المتوفرة على صفحة [الإصدارات](https://github.com/kata-containers/kata-containers/releases/).

يمكن العثور على صورة النواة المسماة `vmlinux.container` في دليل `/opt/kata/share/kata-containers/` ضمن ملفات الإصدار.

## التحضير لبناء الحزمة

ثبت Swiftly، و[Swift](https://www.swift.org)، و[Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html):

```bash
make cross-prep
```

إذا كنت تستخدم تطبيق طرفية مخصص، قد تحتاج لنقل هذا الأمر من `.zprofile` إلى `.zshrc` (استبدل `<USERNAME>`):

```bash
# تم الإضافة بواسطة swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

أعد تشغيل تطبيق الطرفية. تأكد أن هذا الأمر يعيد `/Users/<USERNAME>/.swiftly/bin/swift` (استبدل `<USERNAME>`):

```bash
which swift
```

إذا قمت بتثبيت أو استخدام Static Linux SDK سابقًا، قد تحتاج إلى إزالة إصدارات SDK القديمة من النظام (استبدل `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## بناء الحزمة

بناء الحاويات من المصدر:

```bash
make all
```

## اختبار الحزمة

بعد البناء، شغّل اختبارات أساسية وتكاملية:

```bash
make test integration
```

النواة مطلوبة لتشغيل اختبارات التكامل.  
إذا لم يكن لديك نواة محلية للاستخدام، يمكن جلب نواة افتراضية باستخدام هدف `make fetch-default-kernel`.

يجب جلب النواة الافتراضية فقط بعد بناء أولي أو بعد `make clean`.

```bash
make fetch-default-kernel
make all test integration
```

## بروتوباف

تعتمد الحاويات على إصدارات محددة من `grpc-swift` و `swift-protobuf`. يمكنك تثبيتها وإعادة توليد واجهات RPC باستخدام:

```bash
make protos
```

## التوثيق

أنشئ توثيق API للمشاهدة المحلية باستخدام:

```bash
make docs
make serve-docs
```

عاين التوثيق بتشغيل الأمر في طرفية أخرى:

```bash
open http://localhost:8000/documentation/
```

## المساهمة

المساهمات في الحاويات مرحب بها ومشجعة. يرجى الاطلاع على [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) لمزيد من المعلومات.

## حالة المشروع

الإصدار 0.1.0 هو الإصدار الرسمي الأول للحاويات. الإصدارات السابقة لا تضمن استقرار المصدر.

نظرًا لأن مكتبة الحاويات قيد التطوير النشط، فإن استقرار المصدر مضمون فقط ضمن الإصدارات الفرعية (مثل بين 0.1.1 و0.1.2). إذا كنت لا تريد تحديثات قد تكسر المصدر، يمكنك تحديد اعتماد الحزمة باستخدام .upToNextMinorVersion(from: "0.1.0") بدلاً من ذلك.

قد تقدم الإصدارات الفرعية المستقبلية تغييرات على هذه القواعد حسب الحاجة.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---