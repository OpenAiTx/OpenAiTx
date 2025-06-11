# Containerization

بسته Containerization به برنامه‌ها اجازه می‌دهد تا از کانتینرهای لینوکسی استفاده کنند.  
Containerization با زبان [Swift](https://www.swift.org) نوشته شده و از [Virtualization.framework](https://developer.apple.com/documentation/virtualization) روی سیلیکون اپل استفاده می‌کند.

Containerization API‌هایی را برای موارد زیر فراهم می‌کند:

- [مدیریت تصاویر OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/).  
- [تعامل با رجیستری‌های از راه دور](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationOCI/Client/).  
- [ایجاد و پرکردن سیستم فایل ext4](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationEXT4/).  
- [تعامل با خانواده سوکت Netlink](https://raw.githubusercontent.com/apple/containerization/main/Sources/ContainerizationNetlink/).  
- [ساخت کرنل لینوکس بهینه‌شده برای زمان بوت سریع](https://raw.githubusercontent.com/apple/containerization/main/kernel/).  
- [ایجاد ماشین‌های مجازی سبک و مدیریت محیط زمان اجرا](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxContainer.swift).  
- [ایجاد و تعامل با فرآیندهای کانتینری](https://raw.githubusercontent.com/apple/containerization/main/Sources/Containerization/LinuxProcess.swift).  
- استفاده از Rosetta 2 برای اجرای کانتینرهای linux/amd64 روی سیلیکون اپل.

برای اطلاعات بیشتر در مورد بسته‌های Swift که Containerization ارائه می‌دهد، لطفاً [مستندات API](https://apple.github.io/containerization/documentation/) را مشاهده کنید.

## طراحی

Containerization هر کانتینر لینوکسی را داخل یک ماشین مجازی سبک اجرا می‌کند. مشتریان می‌توانند برای هر کانتینر آدرس IP اختصاصی ایجاد کنند تا نیاز به فوروارد پورت‌های جداگانه از بین برود. کانتینرها با استفاده از یک [کانفیگ کرنل لینوکس بهینه‌شده](https://raw.githubusercontent.com/apple/containerization/main/kernel) و یک سیستم فایل ریشه حداقلی با سیستم init سبک، زمان شروع کمتر از یک ثانیه را به دست می‌آورند.

[vminitd](https://raw.githubusercontent.com/apple/containerization/main/vminitd) یک سیستم init کوچک است که زیرپروژه‌ای در Containerization محسوب می‌شود.  
`vminitd` به عنوان فرآیند اولیه داخل ماشین مجازی اجرا می‌شود و یک API GRPC از طریق vsock ارائه می‌دهد.  
این API اجازه می‌دهد محیط زمان اجرا پیکربندی شده و فرآیندهای کانتینری راه‌اندازی شوند.  
`vminitd` ورودی/خروجی، سیگنال‌ها و رویدادها را به فرآیند فراخوان ارسال می‌کند وقتی فرآیندی اجرا می‌شود.

## نیازمندی‌ها

برای ساخت و اجرای Containerization به مک با سیلیکون اپل نیاز دارید.

برای ساخت بسته Containerization، سیستم شما باید یکی از موارد زیر را داشته باشد:

- macOS 15 یا بالاتر و نسخه بتای Xcode 26  
- نسخه بتای macOS 26 یا بالاتر

برنامه‌های ساخته شده با این بسته روی macOS 15 یا جدیدتر اجرا می‌شوند، اما ویژگی‌های زیر در macOS 15 در دسترس نیستند:

- شبکه‌بندی کانتینر غیر ایزوله - با macOS 15، کانتینرهایی که روی شبکه vmnet یکسان هستند نمی‌توانند با یکدیگر ارتباط برقرار کنند.

## نمونه استفاده

برای مثال‌هایی از نحوه استفاده از برخی کتابخانه‌ها، برنامه اجرایی cctl شروع خوبی است. این ابزار به عنوان یک محیط آزمایشی برای امتحان کردن API طراحی شده است. این ابزار شامل دستورات مختلفی است که برخی از عملکردهای اصلی محصولات مختلف را آزمایش می‌کند، مانند:

1. [دستکاری تصاویر OCI](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/ImageCommand.swift)  
2. [ورود به رجیستری‌های کانتینر](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/LoginCommand.swift)  
3. [ایجاد بلوک‌های سیستم فایل ریشه](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RootfsCommand.swift)  
4. [اجرای کانتینرهای ساده لینوکسی](https://raw.githubusercontent.com/apple/containerization/main/Sources/cctl/RunCommand.swift)  

## کرنل لینوکس

یک کرنل لینوکس برای ایجاد ماشین‌های مجازی سبک روی macOS لازم است.  
Containerization یک پیکربندی کرنل بهینه‌شده در دایرکتوری [kernel](https://raw.githubusercontent.com/apple/containerization/main/kernel) فراهم می‌کند.

این دایرکتوری شامل محیط ساخت کانتینری است که امکان کامپایل آسان کرنل برای استفاده با Containerization را فراهم می‌کند.

پیکربندی کرنل مجموعه‌ای حداقلی از امکانات برای پشتیبانی از زمان شروع سریع و محیط سبک است.

اگرچه این پیکربندی برای اغلب بارهای کاری مناسب است، درک می‌کنیم که برخی به امکانات اضافی نیاز دارند.  
برای حل این موضوع، Containerization APIهای سطح اولی را برای استفاده از پیکربندی‌ها و نسخه‌های مختلف کرنل به صورت جداگانه در هر کانتینر فراهم می‌کند.  
این امکان را می‌دهد که کانتینرها بر روی نسخه‌های مختلف کرنل توسعه و اعتبارسنجی شوند.

برای دستورالعمل‌های نحوه کامپایل کرنل بهینه‌شده، به [README](https://raw.githubusercontent.com/apple/containerization/main/kernel/README.md) در دایرکتوری کرنل مراجعه کنید.

### کرنل پیش‌ساخته

اگر می‌خواهید از کرنل پیش‌ساخته استفاده کنید، باید درایورهای `VIRTIO` به صورت کامپایل شده در کرنل باشند، نه به صورت ماژول.

پروژه [Kata Containers](https://github.com/kata-containers/kata-containers) کرنل بهینه‌شده‌ای برای کانتینرها با تمام گزینه‌های پیکربندی مورد نیاز فعال ارائه می‌دهد که در صفحه [releases](https://github.com/kata-containers/kata-containers/releases/) موجود است.

یک تصویر کرنل با نام `vmlinux.container` در دایرکتوری `/opt/kata/share/kata-containers/` در آرشیوهای نسخه یافت می‌شود.

## آماده‌سازی برای ساخت بسته

Swiftly، [Swift](https://www.swift.org) و [Static Linux SDK](https://www.swift.org/documentation/articles/static-linux-getting-started.html) را نصب کنید:

```bash
make cross-prep
```

اگر از برنامه ترمینال سفارشی استفاده می‌کنید، ممکن است لازم باشد این دستور را از `.zprofile` به `.zshrc` منتقل کنید (جایگزین `<USERNAME>`):

```bash
# Added by swiftly
. "/Users/<USERNAME>/.swiftly/env.sh"
```

برنامه ترمینال را مجدداً راه‌اندازی کنید. اطمینان حاصل کنید این دستور مقدار `/Users/<USERNAME>/.swiftly/bin/swift` را برمی‌گرداند (جایگزین `<USERNAME>`):

```bash
which swift
```

اگر قبلاً Static Linux SDK نصب یا استفاده کرده‌اید، ممکن است لازم باشد نسخه‌های قدیمی SDK را از سیستم حذف کنید (جایگزین `<SDK-ID>`):

```bash
swift sdk list
swift sdk remove <SDK-ID>
```

## ساخت بسته

برای ساخت Containerization از سورس:

```bash
make all
```

## تست بسته

پس از ساخت، تست‌های پایه و یکپارچه‌سازی را اجرا کنید:

```bash
make test integration
```

برای اجرای تست‌های یکپارچه‌سازی به کرنل نیاز است.  
اگر کرنل محلی ندارید، می‌توانید کرنل پیش‌فرض را با هدف `make fetch-default-kernel` دریافت کنید.

دریافت کرنل پیش‌فرض فقط پس از ساخت اولیه یا پس از اجرای `make clean` نیاز است.

```bash
make fetch-default-kernel
make all test integration
```

## پروتوباف‌ها

Containerization به نسخه‌های خاصی از `grpc-swift` و `swift-protobuf` وابسته است. می‌توانید آن‌ها را نصب کرده و رابط‌های RPC را دوباره تولید کنید با:

```bash
make protos
```

## مستندسازی

برای تولید مستندات API برای مشاهده محلی:

```bash
make docs
make serve-docs
```

برای پیش‌نمایش مستندات در ترمینال دیگر اجرا کنید:

```bash
open http://localhost:8000/documentation/
```

## مشارکت

مشارکت در Containerization خوش‌آمد گفته می‌شود و تشویق می‌شود. برای اطلاعات بیشتر به [CONTRIBUTING.md](https://raw.githubusercontent.com/apple/containerization/main/CONTRIBUTING.md) مراجعه کنید.

## وضعیت پروژه

نسخه 0.1.0 اولین نسخه رسمی Containerization است. نسخه‌های قبلی تضمینی برای پایداری سورس ندارند.

از آنجا که کتابخانه Containerization در حال توسعه فعال است، پایداری سورس فقط در نسخه‌های جزئی تضمین می‌شود (مثلاً بین 0.1.1 و 0.1.2). اگر نمی‌خواهید به‌روزرسانی‌هایی که ممکن است سورس را بشکنند دریافت کنید، می‌توانید وابستگی بسته خود را با `.upToNextMinorVersion(from: "0.1.0")` مشخص کنید.

نسخه‌های جزئی بعدی بسته ممکن است این قوانین را در صورت نیاز تغییر دهند.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---