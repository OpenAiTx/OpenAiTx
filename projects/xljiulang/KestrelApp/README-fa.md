# KestrelApp
نمونه‌ای از برنامه‌نویسی شبکه بر پایه Kestrel

### 1 هدف پروژه
1. درک این موضوع که برنامه‌نویسی شبکه دیگر نیاز به شروع از Socket ندارد
2. درک این موضوع که برنامه‌نویسی شبکه دیگر نیاز به چارچوب‌های شخص ثالث (شامل Dotnetty) ندارد
3. درک برنامه‌نویسی شبکه به صورت `telnet` روی `websocket` روی `tls` روی `xxx رمزگذاری اختصاصی` روی `tcp`
4. توانایی توسعه برنامه‌های شبکه بر پایه KestrelFramework

### 2 اسناد و منابع
**اسناد داخلی**：[docs](docs)

**اسناد خارجی**
* [Pipelines](https://learn.microsoft.com/zh-cn/dotnet/standard/io/pipelines)
* [Buffers](https://learn.microsoft.com/zh-cn/dotnet/standard/io/buffers)

### 3 KestrelFramework
برخی کتابخانه‌های پایه‌ای ضروری برای برنامه‌نویسی شبکه با kestrel
1. رابط میان‌افزار Kestrel و ثبت میان‌افزارها
2. System.Buffers: کلاس عملیات بافر
3. System.IO: کلاس عملیات جریان
4. System.IO.Pipelines: کلاس عملیات لوله‌های دوبلکس
5. Middleware: برخی میان‌افزارهای kestrel

### 4 KestrelApp
برنامه Kestrel، شامل موارد زیر
1. پیکربندی EndPointهای قابل شنود
2. پیکربندی پروتکل مورد استفاده توسط EndPoint

### 5 KestrelApp.Middleware
کتابخانه کلاس میان‌افزار KestrelApp
#### 5.1 Echo
نمونه‌ای از پروتکل برنامه Echo ساده

#### 5.2 FlowAnalyze
نمونه میان‌افزار آمارگیری ترافیک لایه انتقال

#### 5.3 FlowXor
نمونه میان‌افزار پردازش XOR ترافیک لایه انتقال

#### 5.4 HttpProxy
نمونه‌ای از پروتکل برنامه پراکسی http

#### 5.5 Telnet
نمونه‌ای از پروتکل برنامه Telnet ساده

#### 5.6 TelnetProxy
نمونه‌ای از ارسال ترافیک به سرور telnet

#### 5.6 Redis
سرور پروتکل redis، نمونه‌ای برای نمایش نحوه استفاده از میان‌افزار برنامه

### با حضور شما، متن‌باز جذاب‌تر است
![打赏](https://raw.githubusercontent.com/xljiulang/KestrelApp/master/reward.png)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-21

---