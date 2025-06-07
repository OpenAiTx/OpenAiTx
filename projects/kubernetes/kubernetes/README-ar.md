# كوبرنيتيس (K8s)

[![أفضل الممارسات CII](https://bestpractices.coreinfrastructure.org/projects/569/badge)](https://bestpractices.coreinfrastructure.org/projects/569) [![تقرير Go](https://goreportcard.com/badge/github.com/kubernetes/kubernetes)](https://goreportcard.com/report/github.com/kubernetes/kubernetes) ![إصدار GitHub (أحدث SemVer)](https://img.shields.io/github/v/release/kubernetes/kubernetes?sort=semver)

<img src="https://github.com/kubernetes/kubernetes/raw/master/logo/logo.png" width="100">

----

كوبرنيتيس، والمعروف أيضاً باسم K8s، هو نظام مفتوح المصدر لإدارة [تطبيقات الحاويات] عبر عدة مضيفين. يوفر آليات أساسية لنشر التطبيقات وصيانتها وتوسعتها.

يعتمد كوبرنيتيس على أكثر من خمسة عشر عاماً من الخبرة في جوجل في تشغيل أحمال العمل الإنتاجية على نطاق واسع باستخدام نظام يُدعى [Borg]، بالإضافة إلى أفضل الأفكار والممارسات من المجتمع.

يستضيف كوبرنيتيس مؤسسة الحوسبة السحابية الأصلية ([CNCF]). إذا كانت شركتك ترغب في المساهمة في تطوير التقنيات المعبأة في حاويات، والمجدولة ديناميكياً، والموجهة نحو الخدمات المصغرة، ننصحك بالانضمام إلى CNCF. لمعرفة المزيد حول الجهات المشاركة ودور كوبرنيتيس، اقرأ [إعلان CNCF].

----

## للبدء في استخدام K8s

راجع وثائقنا على [kubernetes.io].

احصل على دورة مجانية حول [الخدمات المصغرة القابلة للتوسع باستخدام كوبرنيتيس].

لاستخدام كود كوبرنيتيس كمكتبة في تطبيقات أخرى، راجع [قائمة المكونات المنشورة](https://git.k8s.io/kubernetes/staging/README.md). استخدام وحدة `k8s.io/kubernetes` أو حزم `k8s.io/kubernetes/...` كمكتبات غير مدعوم.

## للبدء في تطوير K8s

يستضيف [مستودع المجتمع] جميع المعلومات حول بناء كوبرنيتيس من المصدر، وكيفية المساهمة بالكود والوثائق، ومن تتواصل معه، وغيرها.

إذا كنت ترغب في بناء كوبرنيتيس فوراً، لديك خياران:

##### لديك بيئة [Go] جاهزة.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make
```

##### لديك بيئة [Docker] جاهزة.

```
git clone https://github.com/kubernetes/kubernetes
cd kubernetes
make quick-release
```

للحصول على المزيد من التفاصيل، توجه إلى [وثائق المطورين].

## الدعم

إذا كنت بحاجة إلى الدعم، ابدأ بدليل [استكشاف الأخطاء وإصلاحها]، واتبع الخطوات المبيّنة.

مع ذلك، إذا كان لديك أسئلة، تواصل معنا [بأي طريقة][communication].

[announcement]: https://cncf.io/news/announcement/2015/07/new-cloud-native-computing-foundation-drive-alignment-among-container
[Borg]: https://research.google.com/pubs/pub43438.html?authuser=1
[CNCF]: https://www.cncf.io/about
[communication]: https://git.k8s.io/community/communication
[community repository]: https://git.k8s.io/community
[containerized applications]: https://kubernetes.io/docs/concepts/overview/what-is-kubernetes/
[developer's documentation]: https://git.k8s.io/community/contributors/devel#readme
[Docker environment]: https://docs.docker.com/engine
[Go environment]: https://go.dev/doc/install
[kubernetes.io]: https://kubernetes.io
[Scalable Microservices with Kubernetes]: https://www.udacity.com/course/scalable-microservices-with-kubernetes--ud615
[troubleshooting guide]: https://kubernetes.io/docs/tasks/debug/

## اجتماعات المجتمع

يحتوي [التقويم](https://www.kubernetes.dev/resources/calendar/) على قائمة بجميع الاجتماعات في مجتمع كوبرنيتيس في مكان واحد.

## المستخدمون

يحتوي موقع [دراسات الحالات العملية](https://kubernetes.io/case-studies/) على حالات استخدام واقعية لمؤسسات من مختلف القطاعات التي تقوم بنشر/ترحيل كوبرنيتيس.

## الحوكمة

يخضع مشروع كوبرنيتيس لإطار من المبادئ والقيم والسياسات والعمليات لمساعدة مجتمعنا والمشاركين على تحقيق أهدافنا المشتركة.

[مجتمع كوبرنيتيس](https://github.com/kubernetes/community/blob/master/governance.md) هو نقطة الانطلاق لمعرفة كيفية تنظيم أنفسنا.

يُستخدم [مستودع لجنة توجيه كوبرنيتيس](https://github.com/kubernetes/steering) من قبل لجنة توجيه كوبرنيتيس، التي تشرف على حوكمة المشروع.

## خارطة الطريق

يقدم [مستودع تحسينات كوبرنيتيس](https://github.com/kubernetes/enhancements) معلومات عن إصدارات كوبرنيتيس، بالإضافة إلى تتبع الميزات وقوائم الانتظار.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---