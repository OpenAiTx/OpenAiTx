<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="right">
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=en">English</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-CN">简体中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=zh-TW">繁體中文</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ja">日本語</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ko">한국어</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=hi">हिन्दी</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=th">ไทย</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fr">Français</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=de">Deutsch</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=es">Español</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=it">Itapano</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ru">Русский</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pt">Português</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=nl">Nederlands</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=pl">Polski</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=ar">العربية</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=fa">فارسی</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=tr">Türkçe</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=vi">Tiếng Việt</a></p>
        <p><a href="https://openaitx.github.io/view.html?user=ufo5260987423&project=scheme-langserver&lang=id">Bahasa Indonesia</a></p>
      </div>
    </div>
  </details>
</div>

![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![Ask DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

يمكنك قراءة [بحثي](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) والاستشهاد به على النحو التالي 
> وانغ، ز. (2025، 12 مايو). Scheme-langserver: التعامل مع تحرير كود Scheme باعتباره أولوية قصوى. الندوة الأوروبية الثامنة عشرة للليسْب (ELS`25)، زيورخ. https://doi.org/10.5281/zenodo.15384882

نظرًا لأن GitHub قد يقوم بحظر عناوين IP الصينية، اضطررت إلى نسخ هذا المستودع إلى [هنا](https://codeberg.org/ufo5260987423/scheme-langserver) و[هنا](https://gitee.com/ufo5260987423/scheme-langserver). سأستمر في تحديث جميع المستودعات لكن لا أستطيع ضمان ذلك. كما أنني أتعاون الآن مع [XmacsLabs](https://github.com/XmacsLabs)، ويمكنك أيضًا إيجاد نسخة [هنا](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**الآن، يمكن استخدام scheme-langserver في VSCode!** يرجى الرجوع إلى [هنا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>ملاحظة: هناك العديد من الأخطاء في scheme-langserver. أنا فقط أقوم بالإصلاح وأطلب المساعدة من المجتمع. يرجى التحلي بالصبر.

>ملاحظة: يمكنك العثور على معلومات النوع المولدة تلقائيًا [هنا](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). تستخدم حاليًا بشكل أساسي للتطوير المستقبلي (ربما يشمل AKKU) وتصحيح الأخطاء.

تطبيق ميزات مثل الإكمال التلقائي، الانتقال إلى التعريف، أو عرض التوثيق عند التمرير هو جهد كبير في البرمجة. ومع ذلك، بالمقارنة مع لغات أخرى مثل Java, Python, JavaScript و C، فإن تنفيذ بروتوكول خادم اللغة للغات Lisp يتم غالبًا في فراغ. [Geiser](https://gitlab.com/emacs-geiser)، [racket langserver](https://github.com/jeapostrophe/racket-langserver) و [swish-lint](https://github.com/becls/swish-lint) وغيرها، جميع أعمالهم تعتمد على `repl` (حلقة القراءة-التقييم-الطباعة) أو محلل كلمات رئيسية بدلاً من البرمجة. على سبيل المثال، إذا كان المبرمج يكتب في مشروع غير مكتمل، حيث لا يمكن تنفيذ الأكواد بالكامل، فإن [Geiser](https://gitlab.com/emacs-geiser) أو غيره سيكمل فقط معرفات الربط في المستوى الأعلى المدرجة بواسطة إجراء `environment-symbols` (لـ [Chez](https://cisco.github.io/ChezScheme/))، أو يكمل الرموز بدلاً من المعرفات. وهذا يعني أنه بالنسبة للروابط المحلية والأكواد غير المكتملة، رغم أن بذل الجهد في البرمجة يُعتبر في الغالب ذا أهمية قصوى، فإن [Geiser](https://gitlab.com/emacs-geiser) ونظائره لا يساعدون في التعرف على نطاق المعرف الصحيح. تحدث حالات مشابهة مع وظيفة الانتقال إلى التعريف والعديد من الوظائف الأخرى.

السبب الرئيسي هو أن Scheme ولهجات Lisp الأخرى، مجموعاتها الوفيرة من البيانات وهياكل التحكم المرنة تطرح تحديًا كبيرًا لتحليل البرامج. وخصوصًا الماكرو، يبدو أن Scheme يُستخدم بشكل أساسي للبرمجة العبقرية والبرمجة الفوقية/الماكرو. لكنني أقول لا. يمكن لـ Scheme إنجاز العديد من الأشياء المثيرة إذا تم توفير بيئة برمجة أفضل. والآن يمكنك [**البدء من هنا**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

هذه الحزمة هي تطبيق لبروتوكول خادم اللغة يدعم برمجة Scheme. توفر الإكمال، والتعريف، واستنتاج النوع. هذه الوظائف قائمة على تحليل الكود الثابت مع [معيار r6rs](http://www.r6rs.org/) وبعض القواعد الواضحة للأكواد غير المكتملة. هذه الحزمة نفسها والمكتبات ذات الصلة منشورة أو سيتم نشرها باستخدام [Akku](https://akkuscm.org/)، والذي هو مدير الحزم لـ Scheme. 

تم اختبار هذه الحزمة أيضًا مع [Chez Scheme](https://cisco.github.io/ChezScheme/) الإصدارات 9.4 و 9.5. سيتم إجراء اختبار مفصل على الإصدار 10.0.0 بعد ترقية نظام تشغيل اللابتوب الخاص بي إلى إصدار أحدث.

أقوم بهذا العمل المفتوح المصدر فقط في وقت فراغي ويمكنني أن أقدم العديد من الأفكار الرائعة للمجتمع مثل تضمين تحليل تدفق البيانات في scheme-langserver أو العديد من الأشياء الأخرى. وأنا مستمر في طلب المزيد من التبرعات أو التمويل. يمكنك التبرع عبر [صفحة Patreon هذه](https://www.patreon.com/PoorProgrammer/membership) أو [爱发电](https://afdian.com/a/ufo5260987423).


## الترجمة، التثبيت & الإعداد من [هنا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## الحالة الحالية
سأواصل إصلاح الأخطاء، وتحليل الكود، وجمع المعلومات لكتابي الضخم حول نظام استنتاج النوع المنزلي الصنع. سيستغرق هذا حوالي سنة واحدة. التطويرات المستقبلية تشمل إضافة إضافة [VScode](https://code.visualstudio.com/) وتحليل تدفق البيانات. ولكن فعليًا، أنا أعتبر هذا العمل المفتوح المصدر وظيفة بدوام جزئي، ولا أستطيع ضمان جدول زمني.

## الإصدارات 
1.2.9 الآن، استمتع باستنتاج النوع!

يرجى الرجوع إلى [هذا الملف](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md) للإصدارات السابقة.

### الميزات
1. إكمال الربط للمعرفات في المستوى الأعلى والمحلي.
![إكمال الربط للمعرفات في المستوى الأعلى والمحلي](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. الانتقال إلى التعريف.
![الانتقال إلى التعريف باستخدام telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. متوافق مع مدير الحزم: Akku.
4. مزامنة تغييرات الملفات وتغيير الفهارس المقابلة.
5. عرض التوثيق عند التمرير.
6. المراجع وتسليط الضوء على المستند (مراجع ضمن المستند).
![البحث عن المراجع باستخدام telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. رموز المستند.
![البحث عن رموز المستند باستخدام telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. التقاط ربط المعرفات المحلية بناءً على *-syntax (define-syntax, let-syntax، إلخ). 
9. الفهرسة المتوازية عبر المنصات.
10. مشرح كود المصدر ذاتي الصنع ليتوافق مع ملفات .sps.
11. تحسين "peephole" لطلبات واجهة برمجة التطبيقات مع مهام قابلة للإيقاف المؤقت.
12. استنتاج النوع باستخدام مترجم DSL منزلي الصنع (أنا فخور جدًا به!). والآن تم تضمينه في الإكمال التلقائي. كما هو موضح في الشكل التالي، فإن "length-b" و "length-a" اللذين لهما النوع "integer?" في مقدمة الخيارات الموصى بها لأنها تتطابق مع نوع المعامل المطلوب من "<=". 
![الإكمال التلقائي مع استنتاج النوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
اختبار يمكن أن يثبت هذه النتيجة، فقط شغل `scheme --script tests/protocol/apis/test-completion.sps` وسيتضمن ملف السجل `scheme-langserver.log` نتائج مثل:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. مترجم مجرد لالتقاط المعرفات بين امتدادات الملفات المختلفة مثل scm, ss, sps, sls و sld.

### المهام المستقبلية
14. إعادة التسمية. 
15. التوافق الكامل مع [معيار r6rs](http://www.r6rs.org/).
16. موسع ماكرو خطوة بخطوة: في الواقع، لقد نفذت واحدًا وأردت أن أجعله خطوة رئيسية لالتقاط ربط المعرف في الماكروهات المعرفة ذاتيًا. الآن أجد أن هذا الالتقاط أصعب بكثير مما توقعت، والموسع لا أعرف أين يمكن أن يعمل.
17. تقييم الكود.
18. تشخيص الكود.
19. إضافة دعم الدلالات عبر اللغات. حسنًا، هل يمكن دعم جافا، سي، بايثون والعديد من اللغات الأخرى من خلال محول AST؟
20. استخراج التعبيرات/التعليمات البرمجية إلى إجراء.

## TODO:المساهمة

## التصحيح (Debug)

### كيفية التصحيح
https://www.scheme.com/debug/debug.html#g1

### سجل الإخراج (Output Log)
باتباع النصائح من [البناء](#building)، [التثبيت لـ Lunar Vim](#installation-for-lunarvim) و [التثبيت لـ VScode](#todo-installation-for-vscode)، إذا كان أي شخص يريد القيام ببعض التطوير وتسجيل شيء ما، سيكون من الملائم إضافة `path-to-log-file` وإعادة كتابة الملف `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` كما يلي:
```lua
local util = require 'lspconfig.util'
local bin_name = '{path-to-run}'
local cmd = { bin_name ,"path-to-log-file"}

return {
  default_config = {
    cmd = cmd,
    filetypes = { 'scheme' },
    root_dir = util.find_git_ancestor,
    single_file_support = true,
  },
  docs = {
    description = [[
https://github.com/ufo5260987423/scheme-langserver
`scheme-langserver`، تطبيق لبروتوكول خادم اللغة للغة Scheme
]]   ,
  },
}
```
### إعادة التشغيل مع السجل
باستخدام [سجل الإخراج](#output-log) أعلاه، يمكنك استخدام `tests/log-debug.sps` لتكرار الأخطاء:
1. أعد تسمية `{path-to-log}` (عادةً `~/scheme-langserver.log`) إلى `~/ready-for-analyse.log`;
2. شغل `scheme --script tests/log-debug.sps`. إذا كنت ترغب في إعادة إنتاج بيئة متعددة الخيوط، سيكون من الممكن أيضًا تشغيل `scheme --script tests/log-debug.sps`.

## الاختبار (Test)
تم اختبار جميع الإجراءات الرئيسية وواجهات برمجة التطبيقات تقريبًا. عملي خشن لكنه مفيد، ربما ترغب في معرفة ما قمت به في مجلد `tests` أو فقط تنفيذ الأمر التالي في `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>ملاحظة
من الصعب إجراء اختبار في بيئة متعددة الخيوط. لذلك، تركز الاختبارات الحالية على الخيط الواحد فقط.

## استخدام Scheme-langserver لأغراض أخرى
### Script-Fu في GIMP
Script-Fu تعتمد على لغة مفسرة تسمى Scheme، وتعمل من خلال استخدام دوال تتفاعل مع الدوال الداخلية لـ GIMP. باستخدام نص [هذه الصفحة](https://dalelane.co.uk/blog/?p=628) كمثال، يمكنك تطبيق scheme-langserver مع ملفات السكريبت ذات امتداد "SCM".

### أخرى

حسنًا، أنا مهتم أيضًا بـ [OMN (Opusmodus Notation)](https://opusmodus.com/) و AutoLisp. لكن لا يزال لدي الكثير من الأمور لأقوم بها.

## عداد الكود
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## وثائق مفصلة
1. [Scheme-langserver: التعامل مع تحرير كود Scheme كأولوية أولى](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [التقاط ربط المعرفات](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [المزامنة](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [استنتاج النوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)،~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(مهمل، وأنا أكتب كتابًا صينيًا عنه)
5. [تحليل API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## سجل النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## المساهمون

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-02

---