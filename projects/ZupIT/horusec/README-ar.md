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

## **جدول المحتويات**
### 1. [**حول**](#about)
### 2. [**البدء السريع**](#getting-started)
>#### 2.1.   [**المتطلبات**](#requirements)
>#### 2.2.  [**التثبيت**](#installing-horusec)
### 3. [**الاستخدام**](#usage)
>#### 3.1. [**استخدام CLI**](#cli-usage)
>#### 3.2. [**استخدام Docker**](#using-docker)
>#### 3.3. [**الإصدارات الأقدم**](#older-versions)
>#### 3.4. [**استخدام تطبيق Horusec-Web**](#using-horusec-web-application)
>#### 3.5.  [**استخدام Visual Studio Code**](#using-visual-studio-code)
>#### 3.6. [**استخدام خطوط الأنابيب Pipeline**](#using-the-pipeline)
### 4. [**التوثيق**](#documentation)       
### 5. [**خارطة الطريق**](#roadmap)
### 6. [**المساهمة**](#contributing)
### 7. [**مدونة السلوك**](#code-of-conduct)
### 8. [**الترخيص**](#license)
### 9. [**المجتمع**](#community)



<br>
<br>
<br>

# **حول**
Horusec هي أداة مفتوحة المصدر تقوم بتحليل الكود الثابت لاكتشاف العيوب الأمنية أثناء عملية التطوير. تدعم الأداة حالياً لغات التحليل التالية: C#، Java، Kotlin، Python، Ruby، Golang، Terraform، Javascript، Typescript، Kubernetes، PHP، C، HTML، JSON، Dart، Elixir، Shell، Nginx.
تحتوي الأداة على خيارات للبحث عن تسريبات المفاتيح والعيوب الأمنية في جميع ملفات مشروعك، بالإضافة إلى تاريخ Git. يمكن للمطور استخدام Horusec عبر CLI، ويمكن لفريق DevSecOps استخدامها على خطوط أنابيب CI/CD.

اطلع على [**التوثيق**](https://docs.horusec.io/docs/overview/) الخاص بنا لمشاهدة القائمة الكاملة للأدوات واللغات التي يدعمها Horusec في التحليل.

<p align="center" margin="20 0"><img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/horusec-complete-architecture.png" alt="architecture" width="100%" style="max-width:100%;"/></p>

### **شاهد مثالاً على المخرجات:**

<img src="https://raw.githubusercontent.com/ZupIT/horusec/main/assets/usage_horusec.gif" alt="usage_gif" width="100%" style="max-width:100%;"/>

# **البدء السريع**

## **المتطلبات**

- Docker

يجب أن يكون Docker مثبتاً على جهازك حتى تتمكن من تشغيل Horusec مع جميع الأدوات التي نستخدمها.
إذا لم يكن لديك Docker، لدينا [**علامة**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags) `-D true` لتعطيل الاعتماد على Docker، لكنك ستفقد الكثير من قوة التحليل.
ننصح باستخدامه مع Docker.

إذا قمت بتمكين مؤلفي الـ commit عبر `-G true`، فهناك أيضاً اعتماد على `git`.

## **تثبيت Horusec**
### **ماك أو لينكس**
```
make install
```

أو

```sh
curl -fsSL https://raw.githubusercontent.com/ZupIT/horusec/master/deployments/scripts/install.sh | bash -s latest
```

#### **التحقق من التثبيت**
```bash
horusec version
```

### **ويندوز**
- **amd64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_amd64.exe" -o "./horusec.exe" -L
    ```

- **arm64**
    ```sh
    curl -k "https://github.com/ZupIT/horusec/releases/latest/download/horusec_win_arm64.exe" -o "./horusec.exe" -L
    ```

#### **التحقق من التثبيت**
```bash
./horusec.exe version
```

### **والمزيد**

- يمكنك العثور على جميع الملفات التنفيذية مع الإصدارات في [**صفحة الإصدارات**](https://github.com/ZupIT/horusec/releases).

- لمزيد من التفاصيل حول كيفية التثبيت، راجع [**التوثيق**](https://docs.horusec.io/docs/cli/installation) 


## **الاستخدام**
### **استخدام CLI**
لاستخدام horusec-cli والتحقق من ثغرات التطبيق، استخدم الأمر التالي:
```bash
horusec start -p .
```
> عند بدء Horusec تحليل ما، يقوم بإنشاء مجلد باسم **`.horusec`**. هذا المجلد هو الأساس لعدم تغيير الكود الخاص بك. ننصحك بإضافة السطر **`.horusec`** إلى ملف **`.gitignore`** الخاص بك حتى لا تحتاج لإرسال هذا المجلد إلى خادم git.

### **استخدام Docker**
من الممكن استخدام Horusec عبر صورة Docker باسم **`horuszup/horusec-cli:latest`**.

لتنفيذ ذلك، شغّل الأمر التالي:
```sh
docker run -v /var/run/docker.sock:/var/run/docker.sock -v $(pwd):/src horuszup/horusec-cli:latest horusec start -p /src -P $(pwd)
```

- أنشأنا وحدة تخزين تحتوي على المشروع `-v $(pwd):/src`.

مع صورة Docker لدينا مساران حيث يمكن العثور على المشروع.

علامة `-p` تمثل مسار المشروع داخل الحاوية، في مثالنا `/src`.
علامة `-P` تمثل مسار المشروع خارج الحاوية، في مثالنا هو `$(pwd)`،
وسيكون من الضروري أيضاً تمرير مسار المشروع لتركيب وحدة التخزين `-v $(pwd):/src`.

### **الإصدارات الأقدم**

إصدار Horusec v1 لا يزال متاحاً.

**تحذير:** سيتم إيقاف نقطة النهاية الخاصة بـ v1، يرجى ترقية CLI إلى v2. اطلع على مزيد من التفاصيل في [**التوثيق**](https://docs.horusec.io/docs/migrate-v1-to-v2/). 

### **ماك أو لينكس**
``` sh
curl -fsSL https://horusec.io/bin/install.sh | bash -s latest
```

### **ويندوز**
```sh
curl "https://horusec.io/bin/latest/win_x64/horusec.exe" -o "./horusec.exe" && ./horusec.exe version
```

- يمكن العثور على الملفات التنفيذية الأقدم في نقطة النهاية هذه، بما في ذلك أحدث إصدار من v1 وهو **`v1.10.3`**.
- بداية من v2، لن يتم توزيع الملفات التنفيذية عبر نقطة النهاية هذه، ويمكنك العثور عليها في [**صفحة الإصدارات**](https://github.com/ZupIT/horusec/releases).

### **استخدام تطبيق Horusec-Web**
يمكنك إدارة ثغراتك الأمنية عبر واجهة الويب الخاصة بنا. يمكنك الحصول على لوحة معلومات للمقاييس حول الثغرات، والتحكم في الإيجابيات الكاذبة، وتوليد رمز تفويض، وتحديث الثغرات والمزيد.
راجع قسم [**تطبيق الويب**](https://github.com/ZupIT/horusec-platform) لمتابعة القراءة عنه.

اطلع على المثال أدناه، فهو يرسل تحليلًا إلى خدمات Horusec على الويب:
```bash
horusec start -p <PATH_TO_YOUR_PROJECT> -a <YOUR_AUTHORIZATION_TOKEN>
```

راجع [**الدليل حول كيفية إنشاء رمز تفويض من خلال Horusec Manager Web Service**](https://docs.horusec.io/docs/tutorials/how-to-create-an-authorization-token).

**تحذير:** تم نقل خدمات الويب الخاصة بنا إلى [**مستودع جديد**](https://github.com/ZupIT/horusec-platform). تحتاج إلى الترقية إلى v2، اطلع على [**كيفية الترقية من v1 إلى v2**](https://docs.horusec.io/docs/migrate-v1-to-v2).

### **استخدام Visual Studio Code**
يمكنك تحليل مشروعك باستخدام إضافة Horusec الخاصة بـ Visual Studio Code.
لمزيد من المعلومات، [**راجع التوثيق**](https://docs.horusec.io/docs/extensions/visual-studio-code/).

### **استخدام خطوط الأنابيب Pipeline**
يمكنك إجراء تحليل لمشروعك قبل تنفيذ النشر في بيئتك لضمان أعلى مستوى من الأمان في مؤسستك.
لمزيد من المعلومات، [**راجع التوثيق**](https://docs.horusec.io/docs/cli/installation/#installation-via-pipeline):

### **الميزات**
راجع أدناه:
- يحلل في وقت واحد 18 لغة باستخدام 20 أداة أمنية مختلفة لزيادة الدقة؛
- يبحث في تاريخ git عن الأسرار والمحتويات الأخرى المكشوفة؛
- يمكن أن يكون تحليلك قابلاً للتخصيص بالكامل، [**راجع جميع موارد CLI المتاحة**](https://docs.horusec.io/docs/cli/commands-and-flags/#3-flags).

## **التوثيق**
يمكنك العثور على توثيق Horusec على [**موقعنا الإلكتروني**](https://docs.horusec.io/docs/overview/).

## **خارطة الطريق**
لدينا [**خارطة طريق**](ROADMAP.md) خاصة بالمشروع، يمكنك المساهمة معنا!

يمتلك Horusec مستودعات أخرى، اطلع عليها:

- [**منصة Horusec**](https://github.com/ZupIT/horusec-platform)
- [**عدة تطوير Horusec**](https://github.com/ZupIT/horusec-devkit)
- [**محرك Horusec**](https://github.com/ZupIT/horusec-engine)
- [**مشغل Horusec**](https://github.com/ZupIT/horusec-operator)
- [**Horusec VsCode**](https://github.com/ZupIT/horusec-vscode-plugin)

## **المساهمة**

لا تتردد في استخدام المشروع أو اقتراح تحسينات أو المساهمة في تنفيذات جديدة.

اطلع على [**دليل المساهمة**](https://raw.githubusercontent.com/ZupIT/horusec/main/CONTRIBUTING.md) لتتعرف على عملية التطوير لدينا، وكيفية اقتراح إصلاحات للأخطاء أو تحسينات.

### **شهادة أصل المطور - DCO**

هذه طبقة أمان للمشروع وللمطورين. وهي إلزامية.

اتبع إحدى الطريقتين التاليتين لإضافة DCO إلى التزاماتك (commits):

**1. سطر الأوامر**
اتبع الخطوات التالية:
**الخطوة 1:** قم بتكوين بيئة git المحلية الخاصة بك بإضافة نفس الاسم والبريد الإلكتروني المسجلين في حسابك على GitHub. هذا يساعد على توقيع الالتزامات يدويًا أثناء المراجعات والاقتراحات.

```
git config --global user.name "Name"
git config --global user.email "email@domain.com.br"
```
**الخطوة 2:** أضف سطر Signed-off-by باستخدام الخيار `'-s'` في أمر git commit:

```
$ git commit -s -m "This is my commit message"
```
**2. موقع GitHub**

يمكنك أيضًا توقيع التزاماتك يدويًا أثناء المراجعات والاقتراحات على GitHub، اتبع الخطوات التالية:

**الخطوة 1:** عند فتح صندوق التغييرات للالتزام، اكتب أو الصق توقيعك يدويًا في صندوق التعليقات، كما في المثال:

```
Signed-off-by: Name < e-mail address >
```

لهذه الطريقة، يجب أن يكون اسمك وبريدك الإلكتروني هما نفسهما المسجلين في حسابك على GitHub.

## **مدونة السلوك**
يرجى اتباع [**مدونة السلوك**](https://github.com/ZupIT/horusec/blob/main/CODE_OF_CONDUCT.md) في جميع تفاعلاتك مع مشروعنا.

## **الرخصة**
[**رخصة أباتشي 2.0**](https://raw.githubusercontent.com/ZupIT/horusec/main/LICENSE).

## **المجتمع**

لا تتردد في التواصل معنا عبر:

- [**مشكلات GitHub**](https://github.com/ZupIT/horusec/issues)
- إذا كان لديك أي أسئلة أو أفكار، دعنا نتحاور في [**منتدى المصادر المفتوحة من Zup**](https://forum.zup.com.br).

هذا المشروع موجود بفضل جميع المساهمين. أنتم رائعون! ❤️ 🚀

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-27

---