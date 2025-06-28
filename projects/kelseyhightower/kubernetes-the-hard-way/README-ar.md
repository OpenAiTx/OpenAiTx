# كوبرنيتيس بالطريقة الصعبة

يرشدك هذا الدليل خلال إعداد كوبرنيتيس بالطريقة الصعبة. هذا الدليل ليس مخصصاً لمن يبحث عن أداة مؤتمتة بالكامل لإنشاء عنقود كوبرنيتيس. "كوبرنيتيس بالطريقة الصعبة" مُصمم لأغراض التعلم، مما يعني اتباع الطريق الأطول لضمان فهمك لكل مهمة مطلوبة لإقلاع عنقود كوبرنيتيس.

> لا يجب اعتبار نتائج هذا الدليل جاهزة للإنتاج الفعلي، وقد تحصل على دعم محدود من المجتمع، ولكن لا تدع ذلك يمنعك من التعلم!

## حقوق النشر

<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="رخصة المشاع الإبداعي" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/88x31.png" /></a><br />هذا العمل مرخص بموجب <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">رخصة المشاع الإبداعي النسبية-غير تجارية-المشاركة بالمثل 4.0 الدولية</a>.


## الجمهور المستهدف

الجمهور المستهدف لهذا الدليل هو كل من يرغب في فهم أساسيات كوبرنيتيس وكيفية ترابط المكونات الأساسية معاً.

## تفاصيل العنقود

يرشدك "كوبرنيتيس بالطريقة الصعبة" خلال إقلاع عنقود كوبرنيتيس أساسي مع تشغيل جميع مكونات لوحة التحكم على عقدة واحدة، ووجود عقدتي عمل، وهو ما يكفي لتعلم المفاهيم الأساسية.

إصدارات المكونات:

* [kubernetes](https://github.com/kubernetes/kubernetes) v1.32.x
* [containerd](https://github.com/containerd/containerd) v2.1.x
* [cni](https://github.com/containernetworking/cni) v1.6.x
* [etcd](https://github.com/etcd-io/etcd) v3.6.x

## المختبرات

يتطلب هذا الدليل أربع (4) آلات افتراضية أو فعلية بمعمارية ARM64 أو AMD64 متصلة على نفس الشبكة.

* [المتطلبات المسبقة](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/01-prerequisites.md)
* [إعداد جهاز القفز (Jumpbox)](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/02-jumpbox.md)
* [توفير موارد الحوسبة](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/03-compute-resources.md)
* [توفير سلطة الشهادات وإنشاء شهادات TLS](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/04-certificate-authority.md)
* [إنشاء ملفات تهيئة كوبرنيتيس للمصادقة](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/05-kubernetes-configuration-files.md)
* [إنشاء إعداد تشفير البيانات والمفتاح](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/06-data-encryption-keys.md)
* [إقلاع عنقود etcd](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/07-bootstrapping-etcd.md)
* [إقلاع لوحة تحكم كوبرنيتيس](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/08-bootstrapping-kubernetes-controllers.md)
* [إقلاع عقد العمل في كوبرنيتيس](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/09-bootstrapping-kubernetes-workers.md)
* [تهيئة kubectl للوصول عن بعد](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/10-configuring-kubectl.md)
* [توفير مسارات شبكة البودات](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/11-pod-network-routes.md)
* [اختبار الدخان](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/12-smoke-test.md)
* [التنظيف](https://raw.githubusercontent.com/kelseyhightower/kubernetes-the-hard-way/master/docs/13-cleanup.md)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-28

---