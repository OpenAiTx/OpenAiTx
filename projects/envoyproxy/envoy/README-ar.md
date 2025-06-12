![شعار Envoy](https://github.com/envoyproxy/artwork/blob/main/PNG/Envoy_Logo_Final_PANTONE.png)

[وكيل عالي الأداء للسحابة الأصلية على الحافة/الوسط/الخدمة](https://www.envoyproxy.io/)

يستضيف Envoy بواسطة [مؤسسة الحوسبة السحابية الأصلية](https://cncf.io) (CNCF). إذا كنت شركة ترغب في المساهمة في تشكيل تطور التقنيات التي تُحزم في حاويات، وتُجدول ديناميكيًا وموجهة نحو الخدمات المصغرة، فكر في الانضمام إلى CNCF. لمزيد من التفاصيل حول من يشارك وكيف يلعب Envoy دورًا، اقرأ [إعلان CNCF](https://www.cncf.io/blog/2017/09/13/cncf-hosts-envoy/).

[![أفضل ممارسات CII](https://bestpractices.coreinfrastructure.org/projects/1266/badge)](https://bestpractices.coreinfrastructure.org/projects/1266)
[![OpenSSF Scorecard](https://api.securityscorecards.dev/projects/github.com/envoyproxy/envoy/badge)](https://securityscorecards.dev/viewer/?uri=github.com/envoyproxy/envoy)
[![CLOMonitor](https://img.shields.io/endpoint?url=https://clomonitor.io/api/projects/cncf/envoy/badge)](https://clomonitor.io/projects/cncf/envoy)
[![Azure Pipelines](https://dev.azure.com/cncf/envoy/_apis/build/status/11?branchName=main)](https://dev.azure.com/cncf/envoy/_build/latest?definitionId=11&branchName=main)
[![حالة Fuzzing](https://oss-fuzz-build-logs.storage.googleapis.com/badges/envoy.svg)](https://bugs.chromium.org/p/oss-fuzz/issues/list?sort=-opened&can=1&q=proj:envoy)
[![Jenkins](https://powerci.osuosl.org/buildStatus/icon?job=build-envoy-static-master&subject=ppc64le%20build)](https://powerci.osuosl.org/job/build-envoy-static-master/)
[![Jenkins](https://ibmz-ci.osuosl.org/buildStatus/icon?job=Envoy_IBMZ_CI&subject=s390x%20build)](https://ibmz-ci.osuosl.org/job/Envoy_IBMZ_CI/)

## التوثيق

* [التوثيق الرسمي](https://www.envoyproxy.io/)
* [الأسئلة الشائعة](https://www.envoyproxy.io/docs/envoy/latest/faq/overview)
* [توثيق الأمثلة](https://github.com/envoyproxy/examples/)
* [مدونة](https://medium.com/@mattklein123/envoy-threading-model-a8d44b922310) حول نموذج الخيوط (threading model)
* [مدونة](https://medium.com/@mattklein123/envoy-hot-restart-1d16b14555b5) حول إعادة التشغيل السريعة (hot restart)
* [مدونة](https://medium.com/@mattklein123/envoy-stats-b65c7f363342) حول بنية الإحصاءات (stats architecture)
* [مدونة](https://medium.com/@mattklein123/the-universal-data-plane-api-d15cec7a) حول واجهة برمجة تطبيقات طبقة البيانات العالمية (universal data plane API)
* [مدونة](https://medium.com/@mattklein123/lyfts-envoy-dashboards-5c91738816b1) حول لوحات معلومات Envoy في Lyft

## ذو صلة

* [data-plane-api](https://github.com/envoyproxy/data-plane-api): تعريفات واجهة برمجة التطبيقات v2 كمستودع مستقل. هذا مرآة للقراءة فقط من [api](https://raw.githubusercontent.com/envoyproxy/envoy/main/api/).
* [envoy-perf](https://github.com/envoyproxy/envoy-perf): إطار اختبار الأداء.
* [envoy-filter-example](https://github.com/envoyproxy/envoy-filter-example): مثال على كيفية إضافة فلاتر جديدة وربطها بالمستودع الرئيسي.

## التواصل

* [envoy-announce](https://groups.google.com/forum/#!forum/envoy-announce): قائمة بريدية منخفضة التردد سنرسل فيها الإعلانات فقط.
* [envoy-security-announce](https://groups.google.com/forum/#!forum/envoy-security-announce): قائمة بريدية منخفضة التردد سنرسل فيها الإعلانات المتعلقة بالأمان فقط.
* [envoy-users](https://groups.google.com/forum/#!forum/envoy-users): نقاش المستخدمين العام.
* [envoy-dev](https://groups.google.com/forum/#!forum/envoy-dev): نقاش مطوري Envoy (واجهات برمجة التطبيقات، تصميم الميزات، إلخ).
* [envoy-maintainers](https://groups.google.com/forum/#!forum/envoy-maintainers): استخدم هذه القائمة للوصول إلى جميع القائمين على صيانة Envoy الأساسيين.
* [تويتر](https://twitter.com/EnvoyProxy/): تابعنا على تويتر!
* [Slack](https://envoyproxy.slack.com/): سلاك، للحصول على دعوة اذهب [هنا](https://communityinviter.com/apps/envoyproxy/envoy).
  * ملاحظة: الرد على أسئلة المستخدمين في سلاك هو على أساس أفضل جهد. للحصول على رد "مضمون" يرجى إرسال بريد إلكتروني إلى envoy-users@ حسب الإرشادات في الموضوع المرتبط التالي.

يرجى مراجعة [هذا](https://groups.google.com/forum/#!topic/envoy-announce/l9zjYsnS3TY) الموضوع لمعرفة معلومات حول استخدام القوائم البريدية.

## المساهمة

المساهمة في Envoy ممتعة و ++C الحديثة أقل تعقيدًا مما قد تظن إذا لم يكن لديك خبرة سابقة. للبدء:

* [دليل المساهمة](https://raw.githubusercontent.com/envoyproxy/envoy/main/CONTRIBUTING.md)
* [قضايا للمبتدئين](https://github.com/envoyproxy/envoy/issues?q=is%3Aopen+is%3Aissue+label%3Abeginner)
* [بدء سريع للبناء/الاختبار باستخدام docker](https://raw.githubusercontent.com/envoyproxy/envoy/main/ci#building-and-running-tests-as-a-developer)
* [دليل المطور](https://raw.githubusercontent.com/envoyproxy/envoy/main/DEVELOPER.md)
* فكر في تثبيت [مجموعة أدوات دعم تطوير Envoy](https://github.com/envoyproxy/envoy/blob/main/support/README.md)، والتي تساعد في أتمتة أجزاء من عملية التطوير، خاصةً تلك المتعلقة بمراجعة الكود.
* يرجى التأكد من إعلامنا إذا كنت تعمل على قضية حتى لا يتكرر العمل!

## اجتماع المجتمع

لدى فريق Envoy موعد اجتماع مجدول مرتين شهريًا يوم الثلاثاء في الساعة 9 صباحًا بتوقيت المحيط الهادئ. التقويم العام على Google هو [هنا](https://goo.gl/PkDijT). سيعقد الاجتماع فقط إذا كانت هناك بنود على جدول الأعمال مدرجة في [محضر الاجتماع](https://goo.gl/5Cergb). يجب أن يكون بإمكان أي عضو في المجتمع اقتراح بنود جدول الأعمال من خلال إضافتها إلى المحضر. سيقوم القائمون على الصيانة إما بتأكيد الإضافات على جدول الأعمال، أو إلغاء الاجتماع خلال 24 ساعة من الموعد المحدد إذا لم يكن هناك جدول أعمال مؤكد.

## الأمان

### تدقيق الأمان

كان هناك عدة عمليات تدقيق من جهات خارجية تركزت على أمان Envoy:
* في عام 2018 قامت Cure53 بإجراء تدقيق أمني، [التقرير الكامل](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_cure53_2018.pdf).
* في عام 2021 قامت Ada Logics بتدقيق على بنية اختبار التحمل (fuzzing infrastructure) مع توصيات للتحسين، [التقرير الكامل](https://raw.githubusercontent.com/envoyproxy/envoy/main/docs/security/audit_fuzzer_adalogics_2021.pdf).

### الإبلاغ عن ثغرات الأمان

إذا وجدت ثغرة أمنية أو احتمال وجود ثغرة في Envoy يرجى إبلاغنا على [envoy-security](mailto:envoy-security@googlegroups.com). سنرسل رسالة تأكيد عبر البريد الإلكتروني لاستلام تقريرك، وسنرسل رسالة أخرى عند تحديدنا للمشكلة بشكل إيجابي أو سلبي.

لمزيد من التفاصيل يرجى مراجعة [إجراءات إصدار الأمان الكاملة لدينا](https://raw.githubusercontent.com/envoyproxy/envoy/main/SECURITY.md).

### إصدارات ppc64le

الإصدارات الخاصة بمعمارية ppc64le أو باستخدام aws-lc غير مشمولة في سياسة أمان Envoy. معمارية ppc64le حالياً على أساس أفضل جهد وليست مدعومة من قبل القائمين على صيانة Envoy.

## الإصدارات

لمزيد من التفاصيل يرجى مراجعة [عملية الإصدار](https://github.com/envoyproxy/envoy/blob/main/RELEASES.md).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-12

---