<div align="right">
  <details>
    <summary >🌐 اللغة</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=maRce10&project=warbleR&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>


warbleR: تسهيل التحليل الحيوي الصوتي
================

<!-- README.md تم إنشاؤه من README.Rmd. الرجاء تعديل ذلك الملف -->
<!-- الشارات: البداية -->

[![lifecycle](https://img.shields.io/badge/lifecycle-maturing-brightgreen.svg)](https://lifecycle.r-lib.org/articles/stages.html)
[![status](https://tinyverse.netlify.app/badge/warbleR)](https://CRAN.R-project.org/package=warbleR)
[![حالة المشروع: نشط وصل المشروع إلى حالة مستقرة وقابلة للاستخدام
ويتم تطويره بنشاط.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)
[![الترخيص: GPL
v3](https://img.shields.io/badge/License-GPLv3-blue.svg)](https://www.gnu.org/licenses/gpl-3.0)
[![شارة حالة CRAN](https://www.r-pkg.org/badges/version/warbleR)](https://cran.r-project.org/package=warbleR)
[![إجمالي
عمليات التحميل](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)](https://cranlogs.r-pkg.org/badges/grand-total/warbleR)
[![تغطية اختبار Codecov](https://codecov.io/gh/maRce10/warbleR/branch/master/graph/badge.svg)](https://app.codecov.io/gh/maRce10/warbleR?branch=master)
<!-- badges: end -->

<img src="https://raw.githubusercontent.com/maRce10/warbleR/master/man/figures/warbleR_sticker.png" alt="شعار warbleR" align="right" width = "25%" height="25%"/>

يهدف [warbleR](https://cran.r-project.org/package=warbleR) إلى
تسهيل تحليل بنية الإشارات الصوتية للحيوانات في
برنامج R. يمكن للمستخدمين جمع تسجيلات الطيور مفتوحة المصدر أو إدخال بياناتهم الخاصة
ضمن سير عمل يسهل التصور الطيفي
وقياس المعاملات الصوتية.
يستخدم [warbleR](https://cran.r-project.org/package=warbleR)
أدوات تحليل الصوت الأساسية من حزمة seewave، ويقدم أدوات جديدة
لتحليل البنية الصوتية. تتوفر هذه الأدوات لتحليل دفعات من الإشارات الصوتية.

الميزات الرئيسية للحزمة هي:

- أدوات متنوعة لقياس البنية الصوتية
- استخدام الحلقات لتطبيق المهام عبر إشارات صوتية مشار إليها في
  جدول تحديد
- إنتاج صور في دليل العمل تتضمن مخططات طيفية لتمكين المستخدمين من تنظيم البيانات والتحقق من التحليلات الصوتية

تقدم الحزمة وظائف لـ:

- استكشاف وتحميل تسجيلات [Xeno‐Canto](https://xeno-canto.org/)
- استكشاف وتنظيم ومعالجة ملفات صوتية متعددة
- اكتشاف الإشارات تلقائيًا (في التردد والزمن) (ولكن تحقق من حزمة R
  [ohun](https://docs.ropensci.org/ohun/) للحصول على تنفيذ أكثر شمولية وسهولة)
- إنشاء مخططات طيفية للتسجيلات الكاملة أو الإشارات الفردية





- تشغيل مقاييس مختلفة لبنية الإشارة الصوتية
- تقييم أداء طرق القياس
- فهرسة الإشارات
- توصيف المستويات البنيوية المختلفة في الإشارات الصوتية
- التحليل الإحصائي لتنسيق الثنائيات
- دمج قواعد البيانات وجداول التعليقات التوضيحية

تسمح معظم الوظائف بتنفيذ المهام بشكل متوازي،
مما يوزع المهام بين عدة معالجات لتحسين الكفاءة الحاسوبية.
تتوفر أيضًا أدوات لتقييم أداء التحليل في كل خطوة.

## التثبيت

قم بتثبيت/تحميل الحزمة من CRAN كما يلي:


``` r
install.packages("warbleR")

# load package
library(warbleR)
```

لتثبيت أحدث إصدار تطويري من
[github](https://github.com/) ستحتاج إلى حزمة R
[remotes](https://cran.r-project.org/package=remotes):

``` r
remotes::install_github("maRce10/warbleR")

# load package
library(warbleR)
```
## الاستخدام

تتضمن الحزمة عدة كتيبات شرح تشرح ميزاتها الرئيسية. يوفر [مقدمة إلى warbleR](https://marce10.github.io/warbleR/articles/warbleR.html) نظرة عامة على وظائف الحزمة. يقدم الكتيب [تنسيق بيانات التعليقات التوضيحية](https://marce10.github.io/warbleR/articles/annotation_data_format.html) وصفاً تفصيلياً للتنسيق المطلوب لتعليقات الإدخال. هناك أيضاً ثلاثة [كتيبات إضافية للحزمة](https://marce10.github.io/warbleR/articles/) تحتوي على أمثلة حول كيفية تنظيم الوظائف في سير عمل التحليل الصوتي.

يمكن العثور على وصف كامل للحزمة (رغم أنه قديم قليلاً) في [مقالة مجلة](https://besjournals.onlinelibrary.wiley.com/doi/10.1111/2041-210X.12624).

## حزم أخرى

توفر الحزمتان [seewave](https://cran.r-project.org/package=seewave) و [tuneR](https://cran.r-project.org/package=seewave) مجموعة ضخمة من الوظائف لتحليل الصوت ومعالجته. تعمل غالباً على كائنات الموجات التي تم استيرادها بالفعل إلى بيئة R. تركز الحزمة [baRulho](https://cran.r-project.org/package=baRulho) على قياس تدهور الإشارات الصوتية الناتج عن البيئة مع مدخلات ومخرجات بيانات مشابهة لتلك الخاصة بـ [warbleR](https://cran.r-project.org/package=warbleR). تسهل الحزمة [Rraven](https://cran.r-project.org/package=Rraven) تبادل البيانات بين R وبرنامج [تحليل الصوت Raven](https://www.ravensoundsoftware.com/) ([مختبر كورنيل لعلم الطيور](https://www.birds.cornell.edu/home)) ويمكن أن تكون مفيدة جداً لدمج Raven كأداة للتعليق التوضيحي في سير عمل التحليل الصوتي في R. تعمل الحزمة [ohun](https://docs.ropensci.org/ohun/) على الكشف التلقائي عن الأحداث الصوتية، وتوفر وظائف لتشخيص وتحسين روتينات الكشف. تسمح [dynaSpec](https://cran.r-project.org/package=seewave) بإنشاء مخططات طيفية ديناميكية (أي مقاطع فيديو للمخططات الطيفية).

## الاستشهاد





























يرجى الاستشهاد بحزمة [warbleR](https://cran.r-project.org/package=warbleR) كما يلي:

Araya-Salas، M. و Smith-Vidaurre، G. (2017)، *warbleR: حزمة r لتسهيل تحليل الإشارات الصوتية الحيوانية*. Methods Ecol Evol. 8، 184-191.

ملاحظة: يرجى أيضًا الاستشهاد بحزمتَي
[tuneR](https://cran.r-project.org/package=tuneR) و
[seewave](https://cran.r-project.org/package=seewave) إذا كنت
تستخدم أي وظائف لإنشاء المخططات الطيفية أو قياس الصوتيات






---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-11-15

---