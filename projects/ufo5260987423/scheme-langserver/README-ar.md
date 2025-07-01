![](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/logo-no-background.png)
# Scheme-langserver
[![اطرح سؤالاً على DeepWiki](https://deepwiki.com/badge.svg)](https://deepwiki.com/ufo5260987423/scheme-langserver)

يمكنك قراءة [ورقتي البحثية](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf) والاستشهاد بها كالتالي:
> WANG, Z. (2025, May 12). Scheme-langserver: Treat Scheme Code Editing as the First-Class Concern. The 18th European Lisp Symposium (ELS`25), Zurich. https://doi.org/10.5281/zenodo.15384882

نظرًا لأن GitHub قد يحجب عناوين IP الصينية، اضطررت لنسخ هذا المستودع إلى [هنا](https://codeberg.org/ufo5260987423/scheme-langserver) و[هنا](https://gitee.com/ufo5260987423/scheme-langserver). سأستمر في تحديث جميع المستودعات ولكن لا أستطيع ضمان ذلك. أنا أتعاون الآن أيضًا مع [XmacsLabs](https://github.com/XmacsLabs)، ويمكنك أيضًا العثور على نسخة متفرعة [هنا](https://github.com/XmacsLabs/scheme-langserver).

<video src="https://github.com/user-attachments/assets/893bba98-6709-4fac-a4d3-dc7b6aab46fb" controls="controls" width="500" height="300"></video>

**الآن، يمكن لـ VSCode استخدام scheme-langserver!** يرجى الرجوع إلى [هنا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

>ملاحظة: هناك العديد من الأخطاء في scheme-langserver. أنا فقط أقوم بإصلاحها وأطلب المساعدة من المجتمع. يرجى التحلي بالصبر.

>ملاحظة: يمكنك العثور على معلومات النوع المولدة تلقائيًا [هنا](https://ufo5260987423.github.io/scheme-langserver/doc/analysis/type-inference-result). وهي تُستخدم الآن بشكل أساسي للتطوير في المرحلة القادمة (قد تشمل AKKU) ولأغراض التصحيح.

إن تنفيذ دعم مثل الإكمال التلقائي، الانتقال إلى التعريف، أو عرض التوثيق عند التمرير هو جهد كبير في البرمجة. ومع ذلك، بالمقارنة مع لغات أخرى مثل java، python، javascript وc، فإن تنفيذ بروتوكول خادم اللغة للغات lisp يتم غالبًا في فراغ. [Geiser](https://gitlab.com/emacs-geiser)، [racket langserver](https://github.com/jeapostrophe/racket-langserver) و[swish-lint](https://github.com/becls/swish-lint) وغيرها، جميع أعمالهم تعتمد على `repl` (حلقة القراءة-التقييم-الطباعة) أو محلل الكلمات الرئيسية بدلاً من البرمجة. على سبيل المثال، إذا كان المبرمج يعمل على مشروع غير مكتمل، حيث الشيفرة غير قابلة للتنفيذ بالكامل، فإن [Geiser](https://gitlab.com/emacs-geiser) أو غيره لن يكمل إلا معرفات الربط في المستوى الأعلى المدرجة بواسطة إجراء `environment-symbols` (لـ [Chez](https://cisco.github.io/ChezScheme/))، أو يكمل الرموز بدلاً من المعرفات. هذا يعني بالنسبة للربط المحلي والشيفرات غير المكتملة، على الرغم من أن بذل الجهد للبرمجة يفترض أنه الأهم غالبًا، فإن [Geiser](https://gitlab.com/emacs-geiser) ونظرائه لا يساعدون في التعرف على نطاق صلاحية المعرفات. حالات مشابهة تحدث مع الانتقال إلى التعريف والعديد من الوظائف الأخرى.

السبب الرئيسي هو أن scheme وغيرها من لهجات lisp، مجموعاتها البيانية الوفيرة وهياكل التحكم المرنة تطرح تحديًا كبيرًا لتحليل البرامج. خصوصًا الماكرو، يبدو أن scheme يستخدم أساسًا للعباقرة وبرمجة الميتا/الماكرو. لكنني أقول لا. يمكن لـ Scheme تقديم العديد من الأشياء الشيقة إذا تم توفير بيئة برمجة أفضل. والآن يمكنك [**البدء من هنا**](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md).

هذه الحزمة هي تنفيذ لبروتوكول خادم اللغة لمساعدة برمجة scheme. توفر الإكمال، التعريف، واستنتاج النوع. هذه الوظائف مبنية على تحليل الشيفرة الثابت مع [معيار r6rs](http://www.r6rs.org/) وبعض القواعد الواضحة للشيفرات غير المكتملة. هذه الحزمة نفسها والمكتبات المرتبطة بها منشورة أو سيتم نشرها مع [Akku](https://akkuscm.org/)، وهو مدير حزم لـ Scheme.

تم اختبار هذه الحزمة أيضًا مع [Chez Scheme](https://cisco.github.io/ChezScheme/) بالإصدارين 9.4 و9.5. وسيتم إجراء اختبار تفصيلي على الإصدار 10.0.0 بعد ترقية نظام تشغيل اللابتوب إلى إصدار أحدث.

أقوم بهذا العمل مفتوح المصدر فقط في أوقات فراغي ويمكنني أن أساهم بالعديد من الأفكار الرائعة للمجتمع مثل دمج تحليل تدفق البيانات في scheme-langserver أو أشياء أخرى كثيرة. وما زلت أطلب المزيد من التبرعات أو التمويل. يمكنك التبرع من خلال [صفحة patreon هذه](https://www.patreon.com/PoorProgrammer/membership) أو [爱发电](https://afdian.com/a/ufo5260987423).


## الترجمة، التثبيت & الإعداد من [هنا](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/startup.md)

## الحالة الحالية
سأستمر في إصلاح الأخطاء، وتحليل أداء الشيفرة، وجمع المعلومات لكتابي الضخم عن نظام استنتاج النوع محلي الصنع. سيستغرق هذا حوالي سنة واحدة. التطويرات المستقبلية تشمل إضافة إضافة [VScode](https://code.visualstudio.com/) وتحليل تدفق البيانات. لكن في الواقع، أعتبر هذا العمل المفتوح المصدر وظيفة بدوام جزئي الآن، ولا أستطيع ضمان جدول زمني.

## الإصدار
1.2.9 الآن، استمتع باستنتاج النوع!

للإصدارات السابقة يرجى الرجوع إلى [هذا الملف](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/release-log.md).

### الميزات
1. إكمال ربط المعرفات في المستوى الأعلى والمحلي.
![إكمال ربط المعرفات في المستوى الأعلى والمحلي](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion.png "Top-level and local identifiers binding")
2. الانتقال إلى التعريف.
![الانتقال إلى التعريف مع telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/definition.png "Goto Definition with telescope.nvim")
3. متوافق مع مدير الحزم: Akku.
4. مزامنة تغييرات الملفات وتغيير الفهرسة المقابلة.
5. العرض عند التمرير (Hover).
6. المراجع وإبراز المستند (المراجع ضمن المستند).
![البحث عن المراجع مع telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/find-references.png "Find references with telescope.nvim")
7. رمز المستند.
![البحث عن رموز المستند مع telescope.nvim](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/document-symbol.png "find document symbols with telescope.nvim")
8. التقاط ربط المعرفات المحلية بناءً على *-syntax (define-syntax, let-syntax، إلخ).
9. فهرسة متوازية عبر الأنظمة.
10. مشرح شيفرة مصدرية محلي الصنع ليكون متوافقًا مع ملفات .sps.
11. تحسين ثغرات الأداء لطلبات API مع مهمة قابلة للتعليق.
12. استنتاج النوع مع مفسر DSL محلي الصنع (أنا فخور به جدًا!). والآن تم تضمينه في الإكمال التلقائي. كما توضح الصورة التالية، فإن "length-b" و "length-a" اللتين تحملان نوع "integer?" تظهران في مقدمة الخيارات الموصى بها لأنها تتوافق مع نوع المعامل المطلوب من "<=".
![الإكمال التلقائي مع استنتاج النوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/figure/auto-completion-with-type-inference.png "Autocompletion with type inference")
يمكن لاختبار إثبات هذه النتيجة، فقط قم بتشغيل `scheme --script tests/protocol/apis/test-completion.sps` وسيحتوي ملف السجل `scheme-langserver.log` على نتائج مثل هذه:
```bash
send-message
2023 11 21 11 26 41 967266866
{"jsonrpc":"2.0","id":"3","result":[{"label":"length-a"},{"label":"length-b"},{"label":"lambda"},{"label":"latin-1-codec"},{"label":"lcm"},{"label":"least-fixnum"},{"label":"length"},{"label":"let"},{"label":"let*"},{"label":"let*-values"},{"label":"let-syntax"},{"label":"let-values"},{"label":"letrec"},{"label":"letrec*"},{"label":"letrec-syntax"},{"label":"lexical-violation?"},{"label":"list"},{"label":"list->string"},{"label":"list->vector"},{"label":"list-ref"},{"label":"list-sort"},{"label":"list-tail"},{"label":"list?"},{"label":"log"},{"label":"lookahead-char"},{"label":"lookahead-u8"}]}
```
13. مفسر تجريدي لالتقاط المعرفات بين امتدادات الملفات المختلفة مثل scm، ss، sps، sls وsld.

### المهام القادمة
14. إعادة التسمية.
15. التوافق الكامل مع [معيار r6rs](http://www.r6rs.org/).
16. موسع ماكرو خطوة بخطوة: في الواقع، لقد نفذت واحدًا وأردت أن أجعله خطوة رئيسية لالتقاط ربط المعرفات في الماكروهات المعرفة ذاتيًا. الآن، أجد أن هذا الالتقاط أصعب بكثير مما كنت أعتقد، ولا أعرف أين يمكن أن يعمل الموسع.
17. تقييم الشيفرة.
18. تشخيص الشيفرة.
19. إضافة دعم الدلالات عبر اللغات. حسنًا، هل يمكن دعم java، c، python والعديد من اللغات الأخرى مع محول AST؟
20. استخراج التعبيرات/التعليمات إلى إجراء.

## المهام القادمة: المساهمة

## التصحيح

### كيفية التصحيح
https://www.scheme.com/debug/debug.html#g1

### سجل الإخراج
باتباع النصائح من [البناء](#building)، [التثبيت لـ Lunar Vim](#installation-for-lunarvim) و [التثبيت لـ VScode](#todo-installation-for-vscode)، إذا أراد أي شخص القيام ببعض التطوير وتسجيل شيء ما، سيكون من الملائم إضافة `path-to-log-file` وإعادة كتابة الملف `~/.local/share/lunarvim/site/pack/packer/start/nvim-lspconfig/lua/lspconfig/server_configurations/scheme_langserver.lua` كما يلي:
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
`scheme-langserver`، تنفيذ لبروتوكول خادم اللغة لـ scheme
]]   ,
  },
```
}
```
### التكرار مع السجل (Log)
مع [سجل الإخراج](#output-log) أعلاه، يمكنك استخدام `tests/log-debug.sps` لتكرار الأخطاء:
1. أعد تسمية `{path-to-log}` (عادةً `~/scheme-langserver.log`) إلى `~/ready-for-analyse.log`;
2. شغّل `scheme --script tests/log-debug.sps`. إذا كنت ترغب في إعادة إنتاج بيئة متعددة الخيوط (multi-thread)، سيكون متاحاً أيضاً تشغيل `scheme --script tests/log-debug.sps`.

## الاختبار
تم اختبار جميع الإجراءات الرئيسية وواجهات برمجة التطبيقات تقريبًا. عملي يعتبر بدائياً ولكنه مفيد، ربما تود معرفة ما أنجزته في مجلد `tests` أو ببساطة شغّل الأمر التالي في `{scheme-langserver-root-directory}`
``` bash
bash test.sh
```
>ملاحظة
من الصعب إجراء اختبارات في بيئة متعددة الخيوط. لذا، تركز الاختبارات الحالية على الخيط الواحد فقط.

## استخدام Scheme-langserver لأغراض أخرى
### Script-Fu في GIMP
Script-Fu مبني على لغة مفسرة تسمى Scheme، ويعمل باستخدام دوال تتفاعل مع الدوال الداخلية لـ GIMP. باستخدام [هذا المثال](https://dalelane.co.uk/blog/?p=628) من السكريبت، يمكنك تطبيق scheme-langserver مع ملفات السكريبت ذات الامتداد "SCM".

### أخرى

حسنًا، أنا مهتم أيضًا بـ [OMN (Opusmodus Notation)](https://opusmodus.com/) وAutoLisp. لكن لا يزال لدي الكثير لأفعله.

## عدّ الشيفرة
```bash
find . -name "*.sls" ! -path "./.akku/*" |xargs wc -l
```
## وثائق مفصلة
1. [Scheme-langserver: التعامل مع تحرير كود Scheme كأولوية قصوى](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/paper.pdf).
2. [التقاط ربط المعرفات](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/identifier.md)
3. [المزامنة](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/util/synchronize.md)
4. [استنتاج النوع](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.md)،~~[类型推断](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/analysis/type-inference.cn.md)~~(مهمل، وأنا أكتب كتابًا باللغة الصينية حوله)
5. [تحليل API](https://raw.githubusercontent.com/ufo5260987423/scheme-langserver/main/./doc/protocol/analysis.md)
6. [Deepwiki](https://deepwiki.com/ufo5260987423/scheme-langserver)

## تاريخ النجوم

[![Star History Chart](https://api.star-history.com/svg?repos=ufo5260987423/scheme-langserver&type=Date)](https://star-history.com/#ufo5260987423/scheme-langserver)

## المساهمون

![Contributors](https://contrib.rocks/image?repo=ufo5260987423/scheme-langserver)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-01

---