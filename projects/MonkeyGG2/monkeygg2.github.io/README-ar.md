<p align="center"><img src="https://raw.githubusercontent.com/MonkeyGG2/monkeygg2.github.io/main/imgs/icon-256-256.png" height="200"></p>

<div align="center">
<a href="https://discord.com/invite/yPYyZ78qCB"><img alt="Discord" src="https://img.shields.io/discord/1051660971900407839?label=discord"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="Github Repo stars" src="https://img.shields.io/github/stars/MonkeyGG2/monkeygg2.github.io?label=github%20stars"></a>
<a href="https://github.com/MonkeyGG2/monkeygg2.github.io"><img alt="GitHub Repo forks" src="https://img.shields.io/github/forks/MonkeyGG2/monkeygg2.github.io?label=github%20forks"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo stars" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20stars&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=stars_count"></a>
<a href="https://codeberg.org/MonkeyGG2/pages"><img alt="Codeberg Repo forks" src="https://img.shields.io/badge/dynamic/json.svg?label=codeberg%20forks&url=https://codeberg.org/api/v1/repos/MonkeyGG2/pages&query=forks_count"></a>
<a href="http://www.wtfpl.net/about"><img alt="License: WTFPL" src="https://img.shields.io/badge/License-WTFPL-brightgreen.svg"></a>
</div>
<h1 align="center">MonkeyGG2</h1>
<p align="center" style="opacity: 0.65;">موقع الألعاب الصديق في الحي الخاص بك.</p>
<br>

مرحبًا بك في MonkeyGG2، موقع ألعاب غني بالميزات تم إنشاؤه من أجلك! مع أكثر من 150 لعبة للاختيار من بينها، يقدم MonkeyGG2 تجربة ألعاب فريدة وقابلة للتخصيص. سواء كنت لاعبًا، أو مطورًا، أو مستخدمًا عاديًا، يوفر MonkeyGG2 بيئة ألعاب سلسة وممتعة.

> يرجى التفكير في منحنا نجمة! خاصة إذا قمت بعمل fork لهذا المستودع أو وجدت له استخدامًا آخر.

## الميزات

-   أكثر من 150 لعبة
-   سهل الاستخدام
-   سهل النشر
-   قابل للتخصيص
-   بروكسي
-   والمزيد...

## التخصيص

### الإعدادات

#### الإخفاء (Cloaking)

الإخفاء يشير إلى فتح الصفحة في تبويب `about:blank`. هذا السلوك مفعل افتراضيًا، مع إمكانية تعطيله. هناك إعدادات مسبقة لرابط التحويل، ويمكن أيضًا تكوينها يدويًا.

#### التمويه (Masking)

التمويه يشير إلى تغيير الأيقونة وعنوان التبويب الخاص بـ about:blank. هناك إعدادات مسبقة للأيقونة وعنوان التبويب، ويمكن أيضًا تكوينها يدويًا.

#### الاختصارات

يمكن إنشاء اختصارات لوحة مفاتيح مخصصة لتنفيذ مجموعة متنوعة من المهام. على سبيل المثال، الخروج من اللعبة، تمويه التبويب، وتنفيذ جافاسكريبت مخصص كلها مدعومة.
> ملاحظة: إذا كنت ترغب في تنفيذ جافاسكريبت مخصص، تأكد من معرفتك بما تفعله. إذا حدث أي خلل، إعادة تحميل الصفحة دائمًا تكون الحل.

#### الثيم (Theme)

التخصيصات التالية للثيم مدعومة حاليًا:
- تفعيل/تعطيل حركة الخلفية (إذا كنت قلقًا بشأن الأداء أثناء اللعب، لا تقلق، يتم تعطيلها تلقائيًا عند اللعب)
- لون الخلفية
- لون الكتل
- لون الأزرار
- لون الألعاب
- لون التحويم
- لون شريط التمرير
- لون مسار التمرير
- لون الخط

> ملاحظة: إذا غيرت الألوان بالخطأ وجعلت الموقع غير قابل للاستخدام، عليك حذف الكوكيز والتخزين المحلي.

### التخصيص المتقدم

> إخلاء مسؤولية: التخصيصات التالية متاحة فقط لمالكي المستودع أو أي fork منه.

ملف `config.jsonc` مُعد لتضمين إعدادات الموقع بالكامل. حاليًا، العناصر التالية مدعومة:
- الألعاب
- الثيمات (قريبًا)
- إعدادات البروكسي

#### الألعاب

كل إدخال لعبة يحتوي على مفتاح يمثل اسم اللعبة المعروض، ويجب أن تكون القيمة كائنًا بثلاثة أزواج مفتاح-قيمة:
- `"path"`: مسار اللعبة من مجلد `./games`
- `"aliases"`: قائمة بأسماء بديلة للعبة لتحسين البحث
- `"categories"`: قائمة بالفئات التي تنتمي إليها اللعبة (دعم إضافة الأيقونات قريبًا)

إضافة إدخال يدويًا ممكن، لكنه ممل خاصة إذا أردت ترتيب القائمة أبجديًا (غير مطلوب لعمل الإعدادات!).
ولهذا تم إنشاء السكربت `add-game-entry.js`، وهو طريقة سهلة لإضافة لعبة جديدة في الإعدادات دون تعديل الملف يدويًا.

```bash
# يمكنك استخدام أي بيئة تشغيل جافاسكريبت مثل node.js أو bun أو deno
# في هذا المثال سيتم استخدام bun لأنه يثبت التبعيات تلقائيًا
bun add-game-script.js
# أجب على الأسئلة التي ستظهر وسيتم تحديث الإعدادات
```

#### الثيمات

معيار الثيم لم يُنفذ بعد (قريبًا)

#### البروكسي

خيارات إعداد البروكسي موجودة تحت مفتاح **"config"**.
قيمة المفتاح `"proxy"` هي قيمة منطقية (boolean) لتفعيل أو تعطيل وظيفة البروكسي. إذا تم تعيين `"proxy"` إلى false، سيظهر للمستخدم مربع حوار خطأ عند محاولة الوصول للبروكسي.
قيمة المفتاح `"proxyPath"` هي مسار البروكسي. يمكن أن يكون مسارًا مطلقًا أو نسبيًا، لكن يجب أن يدعم البروكسي **CORS** حيث سيتم عرض صفحة البروكسي كـ iframe في الموقع.

## النشر

### بدون بروكسي

[![Run on Replit](https://binbashbanana.github.io/deploy-buttons/buttons/remade/replit.svg)](https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Remix on Glitch](https://binbashbanana.github.io/deploy-buttons/buttons/remade/glitch.svg)](https://glitch.com/edit/#!/import/github/MonkeyGG2/monkeygg2.github.io)
[![Deploy to IBM Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/ibmcloud.svg)](https://cloud.ibm.com/devops/setup/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Amplify Console](https://binbashbanana.github.io/deploy-buttons/buttons/remade/amplifyconsole.svg)](https://console.aws.amazon.com/amplify/home#/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Run on Google Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/googlecloud.svg)](https://deploy.cloud.run/?git_repo=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Oracle Cloud](https://binbashbanana.github.io/deploy-buttons/buttons/remade/oraclecloud.svg)](https://cloud.oracle.com/resourcemanager/stacks/create?zipUrl=https://github.com/MonkeyGG2/monkeygg2.github.io/archive/refs/heads/main.zip)
[![Deploy with Vercel](https://binbashbanana.github.io/deploy-buttons/buttons/remade/vercel.svg)](https://vercel.com/new/clone?repository-url=https%3A%2F%2Fgithub.com%2FMonkeyGG2%2Fmonkeygg2.github.io)
[![Deploy with Netlify](https://binbashbanana.github.io/deploy-buttons/buttons/remade/netlify.svg)](https://app.netlify.com/start/deploy?repository=https://github.com/MonkeyGG2/monkeygg2.github.io)
[![Deploy to Render](https://binbashbanana.github.io/deploy-buttons/buttons/remade/render.svg)](https://render.com/deploy?repo=https://github.com/MonkeyGG2/monkeygg2.github.io)

بدلاً من ذلك، يمكنك ببساطة عمل fork لهذا المستودع على [GitHub](https://github.com/MonkeyGG2/monkeygg2.github.io) أو [Codeberg](https://codeberg.org/MonkeyGG2/pages) والنشر على GitHub Pages أو Codeberg Pages على التوالي.

### مع بروكسي

قم بزيارة صفحة [VioletGG2](https://github.com/MonkeyGG2/VioletGG2) لمعرفة المزيد حول استضافة MonkeyGG2 مع بروكسي.

### التشغيل محليًا

```bash
# تحذير: إذا كان لديك مجلد باسم "monkeygg2"، سيقوم هذا الأمر بحذف جميع الملفات داخله
# يرجى تغيير اسم الدليل في الأمرين التاليين
git clone https://github.com/MonkeyGG2/monkeygg2.github.io.git monkeygg2
cd monkeygg2
# من هنا يمكنك استخدام أي أداة لتشغيل سيرفر ثابت، سيتم استخدام "live-server" من npm في هذا المثال
npm install -g live-server # فقط إذا لم يكن مثبتًا لديك مسبقًا
npx live-server
```

## الرخصة

موزع بموجب رخصة WTFPL. انظر [هنا](https://github.com/MonkeyGG2/monkeygg2.github.io/blob/main/LICENSE) لمزيد من التفاصيل.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---