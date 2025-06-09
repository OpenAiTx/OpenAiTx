<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">إملاء سلس مدعوم بنموذج Whisper من OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## حول التطبيق

Whispering هو تطبيق مفتوح المصدر لتحويل الكلام إلى نص، يوفر وظائف تحويل الكلام إلى نص بشكل عالمي، مع خيارات مثل اختصارات لوحة المفاتيح والنسخ واللصق التلقائي لجعل عملية الإملاء سلسة قدر الإمكان.

يعمل التطبيق بمحرك Whisper من OpenAI، مما يجعله أكثر دقة بكثير من ميزة الإملاء المدمجة في الأنظمة.

> **ملاحظة هامة**: تم تصميم Whispering أساسًا كأداة تحويل الكلام إلى نص، وليس كأداة تسجيل صوتي. للتسجيلات الطويلة حيث تكون الموثوقية أمرًا بالغ الأهمية، أنصح باستخدام تطبيق تسجيل صوتي مخصص على هاتفك أو جهازك يستعمل واجهات برمجة تطبيقات التسجيل الأصلية. هذا يضمن أفضل جودة صوت وثبات في التسجيل.

## عروض توضيحية

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## الميزات الرئيسية

1. **تحويل عالمي للكلام إلى نص**: يمكنك الوصول إلى وظيفة Whisper لتحويل الكلام إلى نص في أي مكان باستخدام اختصار لوحة مفاتيح عالمي أو بنقرتين فقط.
2. **تجربة متعددة المنصات**:
   - تطبيق سطح المكتب: يتيح التحويل العالمي للكلام إلى نص عبر جميع التطبيقات.
   - إضافة المتصفح: توفر التحويل العالمي للكلام إلى نص داخل المتصفح عن طريق التواصل مع تطبيق الويب.
3. **دمج مع الدردشة**: تضيف إضافة المتصفح زر تسجيل في مواقع ChatGPT وClaude، مما يسمح بإدخال الصوت مباشرة وتحويله إلى نص داخل واجهة الدردشة.
4. **إدارة التحويلات النصية**: راجع وعدل التحويلات النصية داخل تطبيق Whispering لضمان الدقة والوضوح.
5. **تكامل الحافظة التلقائي**: عند اكتمال التحويل، يتم نسخ النص تلقائيًا إلى الحافظة الخاصة بك. يتوفر خيار للنسخ واللصق التلقائي أيضًا.

## كيف يتم تخزين بياناتي؟

يقوم Whispering بتخزين أكبر قدر ممكن من البيانات محليًا على جهازك، بما في ذلك التسجيلات والتحويلات النصية. هذا النهج يضمن أقصى قدر من الخصوصية وأمان البيانات. فيما يلي نظرة عامة على كيفية التعامل مع البيانات:

1. **التخزين المحلي**: يتم تخزين التسجيلات الصوتية والتحويلات النصية في IndexedDB، والذي يُستخدم كمخزن للملفات (blob storage) ومكان لحفظ جميع بياناتك مثل النصوص والتحويلات.

2. **خدمة التحويل النصي**: البيانات الوحيدة التي قد تُرسل خارجيًا هي تسجيلك الصوتي إلى خدمة تحويل نصي خارجية — إذا اخترت ذلك. لديك الخيارات التالية:
   - خدمات خارجية مثل OpenAI أو Groq
   - خدمة تحويل نصي محلية مثل `faster-whisper-server`، والتي تبقي كل شيء على الجهاز

3. **إعدادات قابلة للتخصيص**: يمكنك تغيير خدمة التحويل النصي في الإعدادات لضمان أقصى قدر من العمل المحلي.

## التثبيت

### تطبيق الويب

قم بزيارة [whispering.bradenwong.com](https://whispering.bradenwong.com/)، حيث توجد أحدث نسخة من مجلد `apps/app` مستضافة على Vercel.

### إضافة Chrome

قم بتثبيت إضافة Chrome من متجر Chrome الإلكتروني [من هنا](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### تطبيق سطح المكتب

لتنزيل وتثبيت تطبيق Whispering لسطح المكتب، اتبع الخطوات الخاصة بنظام التشغيل لديك:

#### Windows

1. قم بتنزيل ملف التثبيت الذي ينتهي بـ `.msi` من [صفحة الإصدارات الأخيرة](https://github.com/braden-w/whispering/releases).
2. افتح ملف `.msi` الذي تم تنزيله لتشغيل برنامج التثبيت.
3. إذا ظهرت رسالة تفيد بعدم الأمان، انقر على `معلومات إضافية` -> `تشغيل على أي حال` للاستمرار في التثبيت.
4. اتبع التعليمات الظاهرة على الشاشة لإكمال التثبيت.

#### macOS

لنظام macOS، اتبع الخطوات التالية لتثبيت Whispering:

1. **تحميل ملف التثبيت**:
   - قم بزيارة [صفحة الإصدارات الأخيرة](https://github.com/braden-w/whispering/releases).
   - اختر الحزمة المناسبة:
     - لمعالجات Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - لمعالجات Intel: `Whispering_x.x.x_x64.dmg`

2. **تثبيت التطبيق**:
   - افتح ملف `.dmg` الذي تم تنزيله.
   - اسحب تطبيق Whispering إلى مجلد التطبيقات (Applications).

3. **تشغيل Whispering**:
   - افتح Whispering من مجلد التطبيقات.
   - إذا ظهرت رسالة تحذير حول مطور غير معروف:
     - انقر على `إلغاء`
     - انقر بزر الماوس الأيمن على التطبيق في Finder واختر `فتح`

4. **استكشاف الأخطاء (Apple Silicon فقط)**:
   إذا واجهت الخطأ `"Whispering" تالف ولا يمكن فتحه`:
   - افتح تطبيق Terminal
   - شغل الأمر التالي:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - حاول فتح التطبيق مجددًا

بعد إكمال هذه الخطوات، يجب أن يكون Whispering جاهزًا للاستخدام على نظام macOS الخاص بك.

#### Linux

لنظام Linux، هناك عدة خيارات متاحة للتثبيت. اختر الأنسب لبيئتك:

1. **AppImage**:

   - قم بتنزيل ملف `.AppImage` من [صفحة الإصدارات الأخيرة](https://github.com/braden-w/whispering/releases).
   - اجعل الملف قابلاً للتنفيذ:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - شغل ملف AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **حزمة DEB (Debian/Ubuntu)**:
   - قم بتنزيل ملف `.deb` من [صفحة الإصدارات الأخيرة](https://github.com/braden-w/whispering/releases).
   - ثبت الحزمة باستخدام `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - حل أي مشكلات في التبعيات:
     ```bash
     sudo apt-get install -f
     ```

بعد التثبيت، سيكون التطبيق جاهزًا للاستخدام.

## طريقة الاستخدام

### إضافة Chrome

بعد تثبيت إضافة Chrome، ستجد أيقونة Whispering في شريط إضافات Chrome. انقر على هذه الأيقونة لفتح الإضافة. انقر على زر الميكروفون لتسجيل صوتك، ثم انقر على الزر المربع عند الانتهاء. سيظهر النص المحول في مربع النص أدناه.

للوصول إلى ميزة ChatGPT أو Claude، انتقل إلى صفحة الويب الخاصة بـ ChatGPT أو Claude. ستلاحظ زر تسجيل جديد في واجهة الدردشة. انقر على هذا الزر لبدء وإيقاف التسجيل، وسيتم إدخال النص المحول تلقائيًا في حقل إدخال الدردشة.

للوصول إلى ميزة الاختصارات، اضغط على <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> أو <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (قابلة للتخصيص لاحقًا عبر اختصارات إضافة Chrome) لبدء التسجيل من أي موقع ويب. سيتم نسخ النص المحول تلقائيًا إلى الحافظة ولصقه في حقل الإدخال الحالي.

تتواصل إضافة Chrome مع [whispering.bradenwong.com](https://whispering.bradenwong.com)، وستحاول تلقائيًا إنشاء تبويب في الخلفية إذا لم تجد واحدًا. غالبية الأخطاء تُعزى إلى فشل هذا الاتصال، مثل حالات نادرة حيث يدخل التبويب في وضع النوم.

### تطبيق الويب

يمكنك الوصول إلى تطبيق الويب عبر [whispering.bradenwong.com](https://whispering.bradenwong.com). انقر على زر الميكروفون لتسجيل صوتك، ثم انقر على الزر المربع عند الانتهاء. سيظهر النص المحول في مربع النص.

### تطبيق سطح المكتب

بعد تثبيت تطبيق Whispering لسطح المكتب، اضغط على <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (قابلة للتخصيص من الإعدادات) لبدء التسجيل من أي مكان على سطح المكتب. سيتم نسخ النص المحول تلقائيًا إلى الحافظة ولصقه، مع إمكانية تفعيل أو تعطيل كلا الميزتين من الإعدادات.

## تم البناء باستخدام

#### الويب وسطح المكتب

تم بناء تطبيق Whispering باستخدام التقنيات والمكتبات التالية:

- [Svelte 5](https://svelte.dev): مكتبة التفاعل مع واجهة المستخدم المختارة.
- [SvelteKit](https://kit.svelte.dev/docs): من أجل إدارة التوجيه وتوليد المواقع الثابتة، وتستخدم لإنشاء كل من الموقع والواجهة الأمامية الثابتة لتطبيق Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): إطار عمل تطبيقات سطح المكتب.
- [Effect-TS](https://github.com/Effect-TS/effect): لإضافة بعض البرمجة الدالية وكتابة دوال عالية الأمان من ناحية النوع، حيث تكون الأخطاء ضمن نوع الإرجاع.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): مكتبة تنبيهات (toast) بسيطة وقابلة للتخصيص لتطبيقات Svelte. تُستخدم لعرض الأخطاء المرفوعة عبر Effect-TS باستخدام دالة `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): لتشغيل جميع جداول البيانات.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): واجهة برمجة تطبيقات منخفضة المستوى لتخزين كميات كبيرة من البيانات الهيكلية في المتصفح. تتم مزامنتها مع Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): مكتبة مكونات واجهة المستخدم المختارة.
- [TailwindCSS](https://tailwindcss.com/docs): إطار عمل CSS قائم على الأدوات لبناء واجهات المستخدم بسرعة.
- [Turborepo](https://turborepo.org/): لإدارة مستودع أحادي (monorepo) بحيث يمكن لكل من `apps/app` و`apps/extension` مشاركة نفس قاعدة الشيفرة، مما يقلل من التكرار ويضمن مصدرًا واحدًا للحقائق.
- [Rust](https://www.rust-lang.org): لتوسيع ميزات تطبيق سطح المكتب، مثل استخدام مكتبة `enigo` لمعالجة اللصق التلقائي.
- [Vercel](https://vercel.com/): استضافة مناسبة للمشاريع الشخصية وتتكامل جيدًا مع Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): مكتبة مؤثرات صوتية خالية من حقوق الملكية.

#### الإضافة

تم بناء إضافة Chrome الخاصة بـ Whispering باستخدام:

- [Plasmo](https://docs.plasmo.com/): إطار عمل لبناء إضافات Chrome. نستخدم [تدفق relay](https://docs.plasmo.com/framework/messaging#relay-flow) للتواصل مع موقع Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): لإضافة بعض البرمجة الدالية وكتابة دوال عالية الأمان من ناحية النوع، حيث تكون الأخطاء ضمن نوع الإرجاع.
- [React](https://reactjs.org): مكتبة التفاعل مع واجهة المستخدم لإضافة Chrome، حيث أن Plasmo لا يدعم Svelte 5 حاليًا.
- [ShadCN](https://github.com/shadcn): مكتبة مكونات واجهة المستخدم لإضافة Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): إطار عمل CSS يعتمد على الأدوات المساعدة لبناء واجهات مستخدم مخصصة بسرعة.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): واجهة برمجة تطبيقات إضافات كروم.
- [Zapsplat.com](https://www.zapsplat.com/): مكتبة مؤثرات صوتية خالية من حقوق الملكية.

## تشغيل Whispering في وضع التطوير المحلي

لإعداد المشروع على جهازك المحلي، اتبع الخطوات التالية:

1. استنسخ المستودع: `git clone https://github.com/braden-w/whispering.git`
2. انتقل إلى دليل المشروع: `cd whispering`
3. قم بتثبيت الاعتمادات اللازمة: `pnpm i`

لتشغيل تطبيق Whispering لسطح المكتب والموقع في وضع التطوير:

4. انتقل إلى دليل التطبيق: `cd apps/app`
5. شغّل خادم التطوير: `pnpm tauri dev`

يجب أن يفتح تطبيق سطح المكتب تلقائيًا لوضع التطوير المحلي. لتطوير تطبيق الويب، افتح متصفحك وانتقل إلى `http://localhost:5173`.

لتشغيل إضافة Whispering لمتصفح كروم في وضع التطوير:

4. انتقل إلى دليل الإضافة: `cd apps/extension`
5. شغّل خادم التطوير: `pnpm dev --target=chrome-mv3`

لتطوير إضافة كروم، حمّلها في كروم عن طريق الذهاب إلى `chrome://extensions`، وتفعيل وضع المطور، وتحميل مجلد `apps/extension/build/{platform}-{manifest-version}-dev` كإضافة غير مضغوطة.

## بناء الملف التنفيذي بنفسك

إذا كانت لديك أي مخاوف بشأن موثوقية برامج التثبيت أو كنت ترغب في مزيد من التحكم، يمكنك دائمًا بناء الملف التنفيذي بنفسك. يتطلب ذلك إعدادًا أكثر، لكنه يضمن أنك تشغّل الكود الذي تتوقعه. هذه هي روعة البرمجيات مفتوحة المصدر!

### كروم

1. انتقل إلى دليل الإضافة: `cd apps/extension`
2. قم بتثبيت الاعتمادات اللازمة: `pnpm i`
3. شغّل بناء Plasmo: `pnpm plasmo build --target=chrome-mv3`
4. يجب أن تجد المخرجات في `apps/extension/build/chrome-mv3-prod`، والتي يمكن تحميلها في كروم كإضافة غير مضغوطة.
5. بدلاً من ذلك، يمكنك بناء الإضافة لمتجر كروم: `pnpm plasmo build --target=chrome-mv3 --release`

### فايرفوكس

1. انتقل إلى دليل الإضافة: `cd apps/extension`
2. قم بتثبيت الاعتمادات اللازمة: `pnpm i`
3. شغّل بناء Plasmo: `pnpm plasmo build --target=firefox-mv3`
4. يجب أن تجد المخرجات في `apps/extension/build/firefox-mv3-prod`، والتي يمكن تحميلها في كروم كإضافة غير مضغوطة.
5. بدلاً من ذلك، يمكنك بناء الإضافة لمتجر كروم: `pnpm plasmo build --target=firefox-mv3 --release`

### سطح المكتب

1. انتقل إلى دليل التطبيق: `cd apps/app`
2. قم بتثبيت الاعتمادات اللازمة: `pnpm i`
3. شغّل بناء Tauri: `pnpm tauri build`
4. يمكنك العثور على الملف التنفيذي في دليل `apps/app/target/release`.

## المساهمة

نرحب بمساهمات المجتمع! إذا كنت ترغب في المساهمة في Whispering، يرجى اتباع الخطوات التالية:

1. قم بعمل Fork للمستودع.
2. أنشئ فرعًا جديدًا لميزتك أو إصلاحك: `git checkout -b feature/your-feature-name` أو `git checkout -b fix/your-bugfix-name`
3. قم بإجراء التغييرات وادفعها مع رسالة وصفية.
4. ادفع فرعك إلى المستودع الذي قمت بعمل Fork له: `git push origin your-branch-name`
5. أنشئ طلب دمج (pull request) من مستودعك إلى المستودع الأصلي.

يرجى التأكد من أن الكود الخاص بك يتبع القواعد المعتمدة ومُوثّق بشكل جيد.

## الترخيص

تم إصدار Whispering بموجب [رخصة MIT](https://opensource.org/licenses/MIT).

## الرعاة

يتم دعم هذا المشروع من قبل الأشخاص والمؤسسات الرائعة التالية:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## الدعم والملاحظات

إذا واجهت أي مشاكل أو كانت لديك اقتراحات للتحسين، يرجى فتح قضية في [علامة قضايا GitHub](https://github.com/braden-w/whispering/issues) أو التواصل معي عبر [whispering@bradenwong.com](mailto:whispering@bradenwong.com). أقدّر ملاحظاتك كثيرًا!

شكرًا لاستخدامك Whispering ونتمنى لك كتابة سعيدة!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---