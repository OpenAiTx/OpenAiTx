# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

أداة اختبار اللقطات (Snapshot) لمخططات Helm.

اجلب إمكانيات اختبار واجهة المستخدم القوية لمخططات Helm مع الحد الأدنى من الإعداد فقط داخل ملف `values.yaml`.

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## نظرة عامة
- [الميزات 🔑](#الميزات-)
- [لماذا اختبار اللقطات؟ 📸](#لماذا-اختبار-اللقطات-)
  - [الدافع](#الدافع)
- [التثبيت 🚀](#التثبيت-)
- [الاستخدام](#الاستخدام)
  - [معالجة القيم الديناميكية 💪](#معالجة-القيم-الديناميكية-)
- [العرض والمستخدمون ✨](#العرض--والمستخدمون-)


## الميزات 🔑

* **اختبار لقطات سهل وبديهي لمطوري Helm**
  
  - **لا يوجد تنسيق ملف TestSuite خاص بالأداة:** على عكس بعض الأدوات التي تتطلب إنشاء TestSuites منفصلة بتنسيقات ملفات مخصصة، فإن هذه الأداة لا تتطلب أي تنسيقات ملفات إضافية. بدلاً من ذلك، يمكنك تجهيز نسخ متنوعة من ملف `values.yaml` القياسي لكل حالة اختبار. هذا يلغي الحاجة لتعلم تنسيقات جديدة ويبسّط الاختبار.

* **مصمم خصيصًا لمخططات Helm**

  - **معالجة المخرجات الديناميكية التي تولدها دوال helm:** يمكنك تحديد خصائص إضافية داخل ملف values.yaml لكل حالة اختبار لتوفير مرونة في ضبط سلوك الاختبار. على سبيل المثال، يمكنك التحكم في المخرجات التي يتم إنشاؤها ديناميكيًا بواسطة دوال helm مثل [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/).

* **اختبار لقطات مستمر**

  - **[إجراء GitHub جاهز](https://github.com/jlandowner/helm-chartsnap-action):** إجراء GitHub يمكّنك من إجراء اختبار لقطات مستمر لمخططات Helm المحلية أو البعيدة في سير عمل CI الخاص بك جاهز 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## لماذا اختبار اللقطات؟ 📸

أعتقد أن اختبار اللقطات، وهو نهج اختبار شائع في اختبار الويب أو واجهات المستخدم باستخدام أدوات مثل Jest، هو أفضل طريقة لاختبار مخططات Helm. يوفر اختبار اللقطات العديد من الفوائد:

- **المقارنات البصرية:** تنشئ اختبارات اللقطات مخرجات أساسية ثم تقارنها بنتائج الاختبار اللاحقة. يتيح ذلك فحصًا بصريًا سهلاً للتغييرات والانحدارات في إخراج مخطط Helm.

- **سهولة الصيانة:** يبسط اختبار اللقطات عملية إعداد الاختبار، مما يجعله أكثر سهولة وصيانة، خاصة عند التعامل مع مخططات Helm المعقدة. الإدخال لمخطط Helm هو مزيج من القيم. نحن بحاجة فقط للحفاظ على مجموعات الإدخال المفترضة (=values.yaml)، ولقطاتها.

- **اختبار مستمر:** من خلال التقاط لقطات لمخطط Helm باستمرار في سير عمل CI الخاص بك، يمكنك ملاحظة التغييرات بسرعة في المخطط بالكامل وتجنب الانحدارات.

هذه المزايا لا تقتصر على المخطط الذي أنشأته، بل تشمل أيضًا المخططات الخارجية التي قمت بتثبيتها على Kubernetes إذا كنت مسؤولاً عن الكلاستر. عند ترقية الكلاستر، يمكنك ملاحظة أي تغييرات في المخرجات التي تنتجها *القيم* الخاصة بك، مهما كانت صغيرة.

### الدافع

هناك أدوات اختبار Helm موجودة تدعم اختبارات اللقطات.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest)، أداة اختبار وحدات شائعة، لديها خيار لإجراء [اختبار لقطات](https://github.com/helm-unittest/helm-unittest#snapshot-testing).
- [terratest](https://terratest.gruntwork.io/)، اختبارات تلقائية لكود البنية التحتية. يمكنك كتابة الاختبارات كأكواد Go ولديها ميزة لاختبار مخرجات Helm. [مقالة](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> أداة اختبار Helm الرسمية [`ct`](https://github.com/helm/chart-testing) ليست لاختبارات الوحدات أو اختبارات اللقطات ولكن للفحص واختبارات التكامل

بينما هي أدوات قيمة لاختبار مخططات Helm، إلا أن لها بعض القيود فيما يتعلق باختبار اللقطات.

- تحتاج إلى تعلم وتجهيز ملفات Test Suite للأدوات حتى لو كان ذلك فقط لاختبار اللقطات.

- لا تلتقط اللقطة للمخطط بأكمله افتراضيًا، بل مصممة للاختبار على أساس كل ملف داخل مخطط Helm.

- لا تأخذ في الاعتبار المخرجات الديناميكية لدوال Helm.

تم تصميم helm-unittest لإجراء الاختبارات على أساس كل ملف داخل مخطط Helm. هذا يعني أنه يقيم كل ملف بشكل مستقل، وعندما تؤدي قيم أو شروط مخطط Helm إلى تضمين أو استبعاد ملف بالكامل بشكل شرطي، فقد يؤدي ذلك إلى عدم قدرة الاختبارات على تغطية سيناريوهات هامة.

فيما يلي مثال على ملف مواصفات اختبار لاختبار اللقطات في helm-unittest.

> https://github.com/helm-unittest/helm-unittest#snapshot-testing
> 
> ```yaml
> templates:
>   - templates/deployment.yaml
> tests:
>   - it: pod spec should match snapshot
>     asserts:
>       - matchSnapshot:
>           path: spec.template.spec
>   # or you can snapshot the whole manifest
>   - it: manifest should match snapshot
>     asserts:
>       - matchSnapshot: {}
> ```

على سبيل المثال، ضع في اعتبارك سيناريو قد ينشئ فيه مخطط Helm مورد `Certificate` من `cert-manager` عندما يكون كل من TLS وcert-manager مفعلين، ولكن ينشئ مورد `Secret` لشهادة TLS موقعة ذاتياً باستخدام دالة helm [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) عندما لا يكون cert-manager مفعلاً. علاوة على ذلك، يؤثر تفعيل أو تعطيل TLS على خصائص TLS الخاصة بـ Ingress وخيارات TLS الخاصة بالتطبيق في الـ Deployment، إلخ.

في مثل هذه الحالات، قد لا يتمكن helm-unittest من اختبار سلوك المخطط بالكامل بشكل كافٍ، حيث قد تكون مخرجات هذه الملفات الشرطية فارغة، مما يؤدي إلى اختبارات غير مكتملة.

ومع ذلك، كل ما عليك فعله مع `helm-chartsnap` هو فقط تجهيز بعض ملفات `values.yaml` للأنماط التي تتوقعها 😊

## التثبيت 🚀

يمكنك تثبيت الأداة كإضافة لـ Helm.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

خيارات أخرى:

- تثبيت بواسطة Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [تحميل الملف التنفيذي للإصدار](https://github.com/jlandowner/helm-chartsnap/releases)

## الاستخدام

فقط مرر المخطط الخاص بك للبدء بسرعة.

```
helm chartsnap -c YOUR_CHART
```

سيتم إنشاء مجلد `__snapshot__` في مجلد المخطط وسيتم إنشاء ملف `default.snap`.

يمكنك أيضًا إنشاء حالات اختبار كتنويعات لملفات القيم الخاصة بمخططك.

فيما يلي الاستخدام الكامل للأمر.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # لقطة مع القيم الافتراضية:
  chartsnap -c YOUR_CHART
  
  # تحديث ملفات اللقطات:
  chartsnap -c YOUR_CHART -u

  # لقطة مع قيم حالة اختبار:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # لقطة لجميع حالات الاختبار:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # تعيين معلمات أو أعلام إضافية لأمر 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # لقطة لمخطط بعيد في مستودع Helm:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # لقطة لمخطط ingress-nginx (https://kubernetes.github.io/ingress-nginx/) لإصدار محدد مع ملف القيم الخاص بك:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # لقطة لمخطط cilium (https://cilium.io) مع القيم الافتراضية وتعيين أعلام:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # لقطة لمخططات في سجل OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # إخراج بدون ألوان:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              مسار دليل المخطط. يتم تمرير هذا العلم إلى 'helm template RELEASE_NAME CHART --values VALUES' كـ 'CHART'
      --config-file string        اسم أو مسار ملف الإعدادات، والذي يحدد سلوك اللقطة مثل الحقول الديناميكية (الافتراضي ".chartsnap.yaml")
  -N, --ctx-lines int             عدد الأسطر التي تظهر في إخراج الفرق. 0 لإخراج كامل (الافتراضي 3)
      --debug                     وضع التصحيح
      --fail-helm-error           فشل إذا فشل أمر 'helm template'
      --failfast                  فشل عند فشل أي حالة اختبار
  -h, --help                      المساعدة لـ chartsnap
  -n, --namespace string          مساحة الأسماء. يتم تمرير هذا العلم إلى 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' كـ 'NAMESPACE' (الافتراضي "default")
  -o, --output-dir string         الدليل الذي يتم فيه إنشاء دليل __snapshot__. (الافتراضي: دليل ملف القيم إذا تم تعيين --values؛ دليل المخطط إذا كان المخطط محليًا؛ وإلا الدليل الحالي)
      --parallelism int           تزامن الاختبار عند التقاط لقطات متعددة لدليل ملفات القيم الاختبارية. الافتراضي غير محدود (الافتراضي -1)
      --release-name string       اسم الإصدار. يتم تمرير هذا العلم إلى 'helm template RELEASE_NAME CHART --values VALUES' كـ 'RELEASE_NAME' (الافتراضي "chartsnap")
      --snapshot-version string   استخدام إصدار معين من تنسيق اللقطة. v1, v2, v3 مدعومة. (الافتراضي: الأحدث)
  -u, --update-snapshot           وضع تحديث اللقطة
  -f, --values string             مسار ملف القيم الاختبارية أو الدليل. إذا تم تعيين الدليل، يتم اختبار جميع الملفات. إذا كان فارغًا، يتم استخدام القيم الافتراضية. يتم تمرير هذا العلم إلى 'helm template RELEASE_NAME CHART --values VALUES' كـ 'VALUES'
  -v, --version                   إصدار chartsnap

```

### معالجة القيم الديناميكية 💪

يحتوي Helm على ميزة تُسمى "دوال Helm" والتي تُولد قيمًا عشوائية أو شهادات موقعة ذاتيًا مثل [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) و [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

عند استخدام هذه الدوال، ستختلف المخرجات في كل مرة يتم فيها تنفيذ Helm.
لهذه الحالة، لدى chartsnap ميزة تمنع عدم تطابق اللقطات من خلال استبدالها بقيمة ثابتة، `###DYNAMIC_FIELD###`.

يمكنك تحديد مسارات القيم الديناميكية في الـ YAML الناتج باستخدام [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901).

```yaml:.chartsnap.yaml
dynamicFields:
  - apiVersion: v1
    kind: Secret
    name: cosmo-auth-env
    jsonPath:
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_BLOCKKEY
      - /data/COOKIE_HASHKEY
      - /data/COOKIE_SESSION_NAME
    base64: true
```

> ملاحظة:
> في JSONPath، يتم توثيق هروب الحرف / في [RFC6901، القسم 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3)
> ```
>    بسبب أن الحرفين '~' (%x7E) و '/' (%x2F) لهما معانٍ خاصة في JSON Pointer، يجب ترميز '~' كـ '~0' و'/' كـ '~1' عندما تظهر هذه الأحرف في رمز مرجعي.
> ```
>
> لذا إذا كنت تتعامل مع بيان مثل التالي، تحتاج إلى تحديد مسار json كـ `/metadata/annotaions/checksum~1values`.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

إذا كان لديك دليل لملفات القيم الاختبارية، ضع ملف `.chartsnap.yaml` بداخله. سيكون هذا السلوك شائعًا في جميع اختبارات اللقطات في الدليل.

لمزيد من الأمثلة، راجع [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1).

بدلاً من ذلك، يمكنك إضافة الإعداد مباشرة في ملف القيم الاختباري كخاصية `testSpec`.
في هذه الحالة، لا تحتاج إلى تجهيز ملف `.chartsnap.yaml`. هذا مناسب لأخذ لقطات لمخططات بعيدة أو من طرف ثالث مع ملف قيم واحد فقط.

يمكن أن يكون ملف القيم الخاص بك هكذا:

```yaml
# أضف هذه الخاصية إلى القيم الخاصة بك.
testSpec:
  dynamicFields:
    - apiVersion: v1
      kind: Secret
      name: cilium-ca
      jsonPath:
        - /data/ca.crt
        - /data/ca.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-server-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true
    - apiVersion: v1
      kind: Secret
      name: hubble-relay-client-certs
      jsonPath:
        - /data/ca.crt
        - /data/tls.crt
        - /data/tls.key
      base64: true

# الباقي يمكن أن يكون أي قيم لمخططك.
# ...
```

لمزيد من الأمثلة، راجع [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote).

## العرض والمستخدمون ✨

| المستخدمون / المشاريع | الوصف | الرابط |
|:---|:---|:---|
| مثال | مخطط مثال تم إنشاؤه بواسطة أمر `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| مثال | مثال على التقاط لقطات لمخططات في مستودعات Helm البعيدة | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | إجراء GitHub لاستخدام helm chartsnap في CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | منصة WebIDE و DevEnvironment مفتوحة المصدر على Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 بوابة واجهة برمجة التطبيقات السحابية الأصلية وبوابة الذكاء الاصطناعي. | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---