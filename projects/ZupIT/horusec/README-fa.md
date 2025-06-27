<p align="center" margin="20 0"><a href="https://horusec.io/">
    <img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec_logo.png" alt="logo_header" width="65%" style="max-width:100%;"/></a></p>

<p align="center">
    <a href="https://github.com/ZupIT/horusec/releases" alt="version">
        <img src="https://img.shields.io/github/v/release/ZupIT/horusec?label=version"/></a>
    <a href="https://github.com/ZupIT/horusec/pulse" alt="activity">
        <img src="https://img.shields.io/github/commit-activity/m/ZupIT/horusec?label=activity"/></a>
    <a href="https://github.com/ZupIT/horusec/graphs/contributors" alt="contributors">
        <img src="https://img.shields.io/github/contributors/ZupIT/horusec?label=contributors"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/lint.yml" alt="lint">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Lint?label=lint"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/test.yml" alt="test">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Test?label=test"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/security.yml" alt="security">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Security?label=security"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/coverage.yml" alt="coverage">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Coverage?label=coverage"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/e2e.yml" alt="e2e">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/e2e?label=e2e"/></a>
    <a href="https://github.com/ZupIT/horusec/actions/workflows/build.yaml" alt="build">
        <img src="https://img.shields.io/github/workflow/status/ZupIT/horusec/Build?label=build"/></a>
    <a href="https://opensource.org/licenses/Apache-2.0" alt="license">
        <img src="https://img.shields.io/badge/license-Apache%202-blue"/></a>
    <a href="https://bestpractices.coreinfrastructure.org/projects/5146"><img src="https://bestpractices.coreinfrastructure.org/projects/5146/badge"></a>
</p>

## **فهرست مطالب**
### 1. [**درباره**](#about)
### 2. [**شروع به کار**](#getting-started)
>#### 2.1.   [**پیش‌نیازها**](#requirements)
>#### 2.2.  [**نصب**](#installing-horusec)
### 3. [**نحوه استفاده**](#usage)
>#### 3.1. [**استفاده از CLI**](#cli-usage)
>#### 3.2. [**استفاده از Docker**](#using-docker)
>#### 3.3. [**نسخه‌های قدیمی‌تر**](#older-versions)
>#### 3.4. [**استفاده از برنامه Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**استفاده از Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**استفاده از Pipeline**](#using-the-pipeline)
### 4. [**مستندات**](#documentation)       
### 5. [**نقشه راه**](#roadmap)
### 6. [**مشارکت**](#contributing)
### 7. [**قوانین رفتاری**](#code-of-conduct)
### 8. [**مجوز**](#license)
### 9. [**جامعه**](#community)



<br>
<br>
<br>

# **درباره**
Horusec یک ابزار متن‌باز است که تحلیل ایستای کد را برای شناسایی نقص‌های امنیتی در فرآیند توسعه انجام می‌دهد. در حال حاضر، زبان‌های پشتیبانی‌شده برای تحلیل شامل C#، Java، Kotlin، Python، Ruby، Golang، Terraform، Javascript، Typescript، Kubernetes، PHP، C، HTML، JSON، Dart، Elixir، Shell، Nginx هستند.
این ابزار گزینه‌هایی برای جستجوی نشت کلیدها و نقص‌های امنیتی در تمام فایل‌های پروژه شما و همچنین تاریخچه Git را دارد. Horusec می‌تواند توسط توسعه‌دهنده از طریق CLI و توسط تیم DevSecOps در محیط‌های CI/CD استفاده شود.

[**مستندات**](https://docs.horusec.io/docs/overview/) ما را بررسی کنید، لیست کامل ابزارها و زبان‌هایی که Horusec تحلیل می‌کند را مشاهده خواهید کرد.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **نمونه‌ای از خروجی را ببینید:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **شروع به کار**

## **پیش‌نیازها**

- داکر (Docker)

شما باید داکر را روی دستگاه خود نصب داشته باشید تا بتوانید Horusec را با تمام ابزارهای مورد استفاده اجرا کنید.
اگر داکر ندارید، یک [**فلگ**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) به نام `-D true` داریم که وابستگی را غیرفعال می‌کند، اما باعث کاهش قدرت تحلیل می‌شود.
توصیه می‌کنیم با داکر از آن استفاده کنید.

اگر فعال‌سازی نویسندگان commit با `-G true` را انجام دهید، وابستگی به `git` نیز وجود دارد.

## **نصب Horusec**
### **مک یا لینوکس**
```
make install
```

یا

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **بررسی نصب**
```bash
horusec version
```

### **ویندوز**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **بررسی نصب**
```bash
./horusec.exe version
```

### **و بیشتر**

- می‌توانید تمام فایل‌های اجرایی باینری را با نسخه‌های مختلف در [**صفحه انتشارها**](https://github.com/ZupIT/horusec/releases) بیابید.

- برای جزئیات بیشتر درباره نحوه نصب، [**مستندات**](https://docs.horusec.io/docs/cli/installation) را بررسی کنید.


## **نحوه استفاده**
### **استفاده از CLI**
برای استفاده از horusec-cli و بررسی آسیب‌پذیری‌های برنامه، از دستور زیر استفاده کنید:
```bash
horusec start -p .
```
> زمانی که Horusec یک تحلیل را آغاز می‌کند، پوشه‌ای به نام **`.horusec`** ایجاد می‌کند. این پوشه جهت عدم تغییر کد شما به وجود می‌آید. توصیه می‌کنیم خط **`.horusec`** را به فایل **`.gitignore`** خود اضافه کنید تا این پوشه به مخزن git شما ارسال نشود.

### **استفاده از Docker**
امکان استفاده از Horusec از طریق تصویر داکر **`horuszup/horusec-cli:latest`** وجود دارد.

برای این کار، دستور زیر را اجرا کنید:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- ما یک volume حاوی پروژه ایجاد کرده‌ایم `-v $(pwd):/src`.

با استفاده از تصویر داکر، دو مسیر برای دسترسی به پروژه خواهیم داشت.

فلگ `-p` مسیر پروژه داخل کانتینر را مشخص می‌کند، که در مثال ما `/src` است.
فلگ `-P` مسیر پروژه خارج از کانتینر را مشخص می‌کند، که در مثال ما `$(pwd)` است،
و همچنین باید مسیر پروژه را برای mount کردن volume با `-v $(pwd):/src` تعیین کنید.

### **نسخه‌های قدیمی‌تر**

نسخه v1 Horusec همچنان در دسترس است.

**هشدار:** نقطه پایان (endpoint) با v1 به زودی منسوخ می‌شود، لطفاً CLI خود را به v2 ارتقا دهید. جزئیات بیشتر را در [**مستندات**](https://docs.horusec.io/docs/migrate-v1-to-v2/) ببینید.

### **مک یا لینوکس**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **ویندوز**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- فایل‌های باینری قدیمی‌تر را می‌توانید در این نقطه پایان بیابید، از جمله آخرین نسخه v1 **`v1.10.3`**.
- از نسخه v2، فایل‌های باینری دیگر از این نقطه پایان توزیع نخواهند شد و شما می‌توانید آن‌ها را در [**صفحه انتشارها**](https://github.com/ZupIT/horusec/releases) پیدا کنید.

### **استفاده از برنامه Horusec-Web**
آسیب‌پذیری‌های خود را از طریق رابط وب ما مدیریت کنید. می‌توانید داشبوردی از شاخص‌ها درباره آسیب‌پذیری‌های خود، کنترل مثبت‌های کاذب، توکن احراز هویت، به‌روزرسانی آسیب‌پذیری‌ها و امکانات بیشتر داشته باشید.
برای اطلاعات بیشتر به بخش [**برنامه وب**](https://github.com/ZupIT/horusec-platform) مراجعه کنید.

نمونه زیر ارسال یک تحلیل به سرویس‌های وب Horusec را نشان می‌دهد:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

[**آموزش ساخت توکن احراز هویت از طریق سرویس وب Horusec Manager**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token) را ببینید.

**هشدار:** سرویس‌های وب ما به [**مخزن جدید**](https://github.com/ZupIT/horusec-platform) منتقل شده است. شما باید به v2 ارتقا دهید، [**نحوه مهاجرت از v1 به v2**](https://docs.horusec.io/docs/migrate-v1-to-v2) را ببینید.

### **استفاده از Visual Studio Code**
شما می‌توانید پروژه خود را با افزونه Horusec برای Visual Studio Code تحلیل کنید.
برای اطلاعات بیشتر [**مستندات را مشاهده کنید**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **استفاده از Pipeline**
می‌توانید قبل از استقرار پروژه در محیط خود، آن را تحلیل کرده و بیشترین امنیت را در سازمان خود تضمین کنید.
برای اطلاعات بیشتر [**مستندات را ببینید**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **ویژگی‌ها**
موارد زیر را ببینید:
- تحلیل همزمان ۱۸ زبان با ۲۰ ابزار امنیتی مختلف برای افزایش دقت؛
- جستجو در تاریخچه git برای کشف اسرار و سایر محتواهای افشا شده؛
- تحلیل شما کاملاً قابل پیکربندی است، [**تمام امکانات CLI را ببینید**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **مستندات**
مستندات Horusec را در [**وبسایت**](https://docs.horusec.io/docs/overview/) ما می‌توانید پیدا کنید.

## **نقشه راه**
ما یک [**نقشه راه پروژه**](ROADMAP.md) داریم، شما می‌توانید با ما همکاری کنید!

Horusec مخازن دیگری نیز دارد، آن‌ها را بررسی کنید:

- [**Horusec Platform**](https://github.com/ZupIT/horusec-platform)
- [**Horusec DevKit**](https://github.com/ZupIT/horusec-devkit)
- [**Horusec Engine**](https://github.com/ZupIT/horusec-engine)
- [**Horusec Operator**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **مشارکت**

لطفاً بدون نگرانی استفاده کنید، پیشنهادات بهبود دهید یا در پیاده‌سازی‌های جدید مشارکت کنید.

راهنمای [**مشارکت**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) ما را بررسی کنید تا با فرآیند توسعه، نحوه پیشنهاد رفع اشکال و بهبود آشنا شوید.

### **گواهینامه منشأ توسعه‌دهنده - DCO**

 این یک لایه امنیتی برای پروژه و توسعه‌دهندگان است. اجباری می‌باشد.
 
یکی از دو روش زیر را برای افزودن DCO به کامیت‌های خود دنبال کنید:
 
**۱. خط فرمان**
 مراحل زیر را دنبال کنید: 
 **گام ۱:** پیکربندی محیط گیت محلی خود با اضافه کردن همان نام و ایمیلی که در حساب GitHub خود تنظیم کرده‌اید. این کار برای امضای دستی کامیت‌ها هنگام بازبینی‌ها و پیشنهادات کمک می‌کند.

 ```
git config --global user.name “Name”
git config --global user.email “email@domain.com.br”
```
**گام ۲:** خط Signed-off-by را با فلگ `'-s'` در دستور git commit اضافه کنید:

```
$ git commit -s -m "This is my commit message"
```
**۲. وب‌سایت GitHub**

همچنین می‌توانید کامیت‌های خود را هنگام بازبینی‌ها و پیشنهادات در GitHub به‌صورت دستی امضا کنید، مراحل زیر را دنبال کنید: 

**گام ۱:** زمانی که جعبه تغییرات کامیت باز می‌شود، امضای خود را به صورت دستی در جعبه دیدگاه تایپ یا جایگذاری کنید، به مثال زیر توجه کنید:

```
Signed-off-by: Name < e-mail address >
```

در این روش، نام و ایمیل شما باید همان موارد ثبت‌شده در حساب GitHub شما باشد.

## **منشور رفتاری**
لطفاً در تمام تعاملات خود با پروژه ما، [**منشور رفتاری**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) را رعایت کنید.

## **مجوز**
 [**مجوز Apache نسخه ۲.۰**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **جامعه**

در صورت تمایل با ما در ارتباط باشید:

- [**مشکلات GitHub**](https://github.com/ZupIT/horusec/issues)
- اگر سؤالی یا ایده‌ای دارید، در [**فروم Open Source زاپ**](https://forum.zup.com.br) با ما گفتگو کنید.


این پروژه مدیون تمام مشارکت‌کنندگان است. شما عالی هستید! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---