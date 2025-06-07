# helm-chartsnap 📸 
[![Go Reference](https://pkg.go.dev/badge/github.com/jlandowner/helm-chartsnap.svg)](https://pkg.go.dev/github.com/jlandowner/helm-chartsnap)
[![Go Report Card](https://goreportcard.com/badge/github.com/jlandowner/helm-chartsnap)](https://goreportcard.com/report/github.com/jlandowner/helm-chartsnap)
[![codecov](https://codecov.io/gh/jlandowner/helm-chartsnap/graph/badge.svg?token=8ARG53CRL7)](https://codecov.io/gh/jlandowner/helm-chartsnap)
[![Workflow Status](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/release.yaml)
[![CI](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml/badge.svg)](https://github.com/jlandowner/helm-chartsnap/actions/workflows/ci.yaml)
[![GitHub Marketplace](https://img.shields.io/badge/Marketplace-Helm%20chartsnap%20action-blue.svg?colorA=24292e&colorB=0366d6&style=flat&longCache=true&logo=github)](https://github.com/marketplace/actions/helm-chartsnap-action)

ابزار تست اسنپ‌شات برای چارت‌های Helm.

قابلیت‌های قدرتمند تست UI را با حداقل پیکربندی تنها در فایل `values.yaml` به چارت Helm بیاورید. 

![screenshot](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/docs/screenshot.png)

## نمای کلی
- [ویژگی‌ها 🔑](#ویژگیها-)
- [چرا تست اسنپ‌شات؟ 📸](#چرا-تست-اسنپشات-)
  - [انگیزه](#انگیزه)
- [نصب 🚀](#نصب-)
- [نحوه استفاده](#نحوه-استفاده)
  - [مدیریت مقادیر داینامیک 💪](#مدیریت-مقادیر-داینامیک-)
- [نمونه‌ها و کاربران ✨](#نمونهها-و-کاربران-)


## ویژگی‌ها 🔑

* **تست اسنپ‌شات آسان و شهودی برای توسعه‌دهندگان Helm**
  
  - **بدون فرمت فایل TestSuite خاص ابزار:** برخلاف برخی ابزارها که نیاز به ایجاد TestSuiteهای جداگانه با فرمت‌های سفارشی دارند، این ابزار به هیچ فرمت فایل اضافی نیاز ندارد. تنها کافی است برای هر کیس تست، نسخه‌هایی از فایل استاندارد `values.yaml` را آماده کنید. این کار نیاز به یادگیری فرمت‌های جدید را از بین می‌برد و تست را ساده‌تر می‌کند.

* **بهینه‌شده برای چارت Helm**

  - **مدیریت خروجی داینامیک تولیدشده توسط توابع helm:** می‌توانید ویژگی‌های اضافی را در فایل values.yaml برای هر کیس تست مشخص کنید تا انعطاف بیشتری در تنظیم رفتار تست داشته باشید. برای مثال، می‌توانید خروجی داینامیک تولیدشده توسط توابع helm مانند [randAlphaNum](https://helm.sh/docs/chart_template_guide/function_list/) را کنترل کنید.

* **تست اسنپ‌شات پیوسته**

  - **[اکشن GitHub](https://github.com/jlandowner/helm-chartsnap-action) آماده است:** اکشن GitHub که تست اسنپ‌شات پیوسته را برای چارت‌های Helm محلی یا راه دور در CI شما فعال می‌کند، آماده است 🚀 -> [`helm-chart-action`](https://github.com/jlandowner/helm-chartsnap-action)

## چرا تست اسنپ‌شات؟ 📸

من معتقدم که تست اسنپ‌شات، که رویکرد محبوبی در تست وب یا UI با ابزارهایی مانند Jest است، بهترین روش برای تست چارت‌های Helm می‌باشد. تست اسنپ‌شات مزایای زیادی دارد:

- **مقایسه‌های بصری:** تست اسنپ‌شات یک خروجی مرجع ایجاد می‌کند و سپس آن را با نتایج تست بعدی مقایسه می‌کند. این امکان بررسی بصری آسان تغییرات و رگرسیون‌ها در رندرینگ چارت Helm را فراهم می‌کند.

- **نگهداری بهبود یافته:** تست اسنپ‌شات فرآیند آماده‌سازی تست را ساده‌تر می‌کند و به ویژه هنگام کار با چارت‌های Helm پیچیده، آن را قابل دسترس‌تر و قابل نگهداری‌تر می‌کند. ورودی چارت Helm ترکیبی از مقادیر است. تنها کافی است ترکیب‌های ورودی مورد انتظار (=values.yaml) و اسنپ‌شات‌های آنها را نگهداری کنیم.

- **تست پیوسته:** با گرفتن اسنپ‌شات‌های پیوسته از چارت Helm در فرآیند CI خود، می‌توانید به سرعت متوجه تغییرات در کل چارت خود شوید و از رگرسیون‌ها جلوگیری کنید.

این مزایا تنها محدود به چارت Helm ساخته‌شده توسط شما نیست، بلکه شامل چارت‌های شخص ثالثی که روی Kubernetes نصب کرده‌اید نیز می‌شود. هنگام ارتقای کلاستر، می‌توانید هرگونه تغییر در خروجی مانفیست‌های تولیدشده توسط *مقادیر* خود را متوجه شوید، حتی اگر جزئی باشند.


### انگیزه

ابزارهای تست Helm موجودی هستند که از تست اسنپ‌شات پشتیبانی می‌کنند.
- [helm-unittest](https://github.com/helm-unittest/helm-unittest)، یک ابزار یونیت تست محبوب، گزینه‌ای برای [تست اسنپ‌شات](https://github.com/helm-unittest/helm-unittest#snapshot-testing) دارد.
- [terratest](https://terratest.gruntwork.io/)، تست‌های خودکار برای کد زیرساخت شما. می‌توانید تست‌ها را به صورت کد Go بنویسید و ویژگی تست خروجی Helm را دارد. [پست بلاگ](https://blog.gruntwork.io/automated-testing-for-kubernetes-and-helm-charts-using-terratest-a4ddc4e67344)

> ابزار تست رسمی Helm با نام [`ct`](https://github.com/helm/chart-testing) برای یونیت تست یا تست اسنپ‌شات نیست بلکه برای lint و تست یکپارچه‌سازی است.

در حالی که این ابزارها برای تست چارت‌های Helm ارزشمند هستند، اما برای تست اسنپ‌شات محدودیت‌هایی دارند.

- حتی برای تست اسنپ‌شات باید فایل‌های Test Suite ابزار را یاد بگیرید و آماده کنید.

- به طور پیش‌فرض کل چارت را اسنپ‌شات نمی‌گیرند، بلکه برای هر فایل داخل چارت Helm تست انجام می‌دهند.

- خروجی‌های داینامیک توابع Helm را در نظر نمی‌گیرند.

helm-unittest طوری طراحی شده که تست‌ها را برای هر فایل داخل چارت Helm انجام می‌دهد. این بدان معناست که هر فایل به طور مستقل ارزیابی می‌شود و وقتی مقادیر یا شرایط چارت Helm باعث می‌شود فایلی به طور شرطی وارد یا حذف شود، ممکن است تست‌ها نتوانند سناریوهای مهم را پوشش دهند.

در اینجا یک مثال از فایل اسپک تست برای تست اسنپ‌شات در helm-unittest آمده است.

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

برای مثال، در سناریویی که چارت Helm ممکن است زمانی که هم TLS فعال باشد و هم cert-manager فعال باشد، منبعی از نوع `Certificate` برای cert-manager ایجاد کند، اما در صورتی که cert-manager فعال نباشد، منبع `Secret` مربوط به TLS را با استفاده از تابع [`genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#genselfsignedcert) ایجاد کند. علاوه بر این، فعال یا غیرفعال بودن TLS بر ویژگی‌های TLS در Ingress و گزینه‌های TLS مخصوص برنامه در Deployment تأثیر می‌گذارد.

در چنین مواردی، helm-unittest ممکن است نتواند رفتار کامل چارت را به طور کافی تست کند، چون خروجی این فایل‌های شرطی ممکن است خالی باشد و منجر به تست‌های ناقص شود.

اما با `helm-chartsnap` تنها کاری که باید انجام دهید آماده‌سازی چند فایل `values.yaml` از الگوهای مورد انتظار است 😊

## نصب 🚀

می‌توانید آن را به عنوان پلاگین Helm نصب کنید.

```sh
helm plugin install https://github.com/jlandowner/helm-chartsnap
```

گزینه‌های دیگر:

- نصب با Go

  ```sh
  go install github.com/jlandowner/helm-chartsnap@latest
  ```

- [دانلود باینری نسخه منتشرشده](https://github.com/jlandowner/helm-chartsnap/releases)

## نحوه استفاده

برای شروع سریع، فقط چارت خود را وارد کنید.

```
helm chartsnap -c YOUR_CHART
```

دایرکتوری `__snapshot__` در مسیر چارت ایجاد می‌شود و `default.snap` ساخته می‌شود.

همچنین می‌توانید کیس‌های تست را به صورت نسخه‌هایی از فایل Values چارت خود ایجاد کنید.

در اینجا نحوه کامل استفاده از دستور آمده است.

```sh
Usage:
  chartsnap -c CHART [flags]

Examples:

  # اسنپ‌شات با مقادیر پیش‌فرض:
  chartsnap -c YOUR_CHART
  
  # به‌روزرسانی فایل‌های اسنپ‌شات:
  chartsnap -c YOUR_CHART -u

  # اسنپ‌شات با مقادیر تست:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE
  
  # اسنپ‌شات همه کیس‌های تست:
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILES_DIRECTOY
  
  # تنظیم آرگومان‌ها یا فلگ‌های اضافی برای دستور 'helm template':
  chartsnap -c YOUR_CHART -f YOUR_TEST_VALUES_FILE -- --skip-tests

  # اسنپ‌شات چارت راه دور در ریپازیتوری Helm:
  chartsnap -c CHART_NAME -f YOUR_VALUES_FILE -- --repo HELM_REPO_URL

  # اسنپ‌شات چارت ingress-nginx (https://kubernetes.github.io/ingress-nginx/) برای نسخه خاص با فایل مقداردهی شما:
  chartsnap -c ingress-nginx -f YOUR_VALUES_FILE -- --repo https://kubernetes.github.io/ingress-nginx --namespace kube-system --version 4.8.3

  # اسنپ‌شات چارت cilium (https://cilium.io) با مقدار پیش‌فرض و فلگ‌های تنظیم شده:
  chartsnap -c cilium -- --repo https://helm.cilium.io --namespace kube-system --set hubble.relay.enabled=true --set hubble.ui.enabled=true

  # اسنپ‌شات چارت‌ها در رجیستری OCI
  chartsnap -c oci://ghcr.io/nginxinc/charts/nginx-gateway-fabric -n nginx-gateway

  # خروجی بدون رنگ:
  NO_COLOR=1 chartsnap -c YOUR_CHART

Flags:
  -c, --chart string              مسیر دایرکتوری چارت. این فلگ به 'helm template RELEASE_NAME CHART --values VALUES' به عنوان 'CHART' پاس داده می‌شود
      --config-file string        نام یا مسیر فایل پیکربندی که رفتار اسنپ‌شات را تعیین می‌کند مانند فیلدهای داینامیک (پیش‌فرض ".chartsnap.yaml")
  -N, --ctx-lines int             تعداد خطوط نمایش داده شده در خروجی تفاوت. ۰ برای نمایش کامل (پیش‌فرض ۳)
      --debug                     حالت اشکال‌زدایی
      --fail-helm-error           شکست در صورت خطای دستور 'helm template'
      --failfast                  توقف در اولین شکست هر کیس تست
  -h, --help                      راهنما برای chartsnap
  -n, --namespace string          نام فضای کاری (namespace). این فلگ به 'helm template RELEASE_NAME CHART --values VALUES --namespace NAMESPACE' به عنوان 'NAMESPACE' پاس داده می‌شود (پیش‌فرض "default")
  -o, --output-dir string         دایرکتوری که دایرکتوری __snapshot__ در آن ایجاد می‌شود. (پیش‌فرض: اگر --values تنظیم شده باشد دایرکتوری فایل مقدار؛ اگر چارت محلی باشد دایرکتوری چارت؛ وگرنه دایرکتوری جاری)
      --parallelism int           همزمانی تست هنگام گرفتن چند اسنپ‌شات از یک دایرکتوری فایل مقدار تست. پیش‌فرض نامحدود (پیش‌فرض -1)
      --release-name string       نام انتشار. این فلگ به 'helm template RELEASE_NAME CHART --values VALUES' به عنوان 'RELEASE_NAME' پاس داده می‌شود (پیش‌فرض "chartsnap")
      --snapshot-version string   استفاده از نسخه خاصی از فرمت اسنپ‌شات. v1، v2، v3 پشتیبانی می‌شوند. (پیش‌فرض: جدیدترین)
  -u, --update-snapshot           حالت به‌روزرسانی اسنپ‌شات
  -f, --values string             مسیر فایل مقدار تست یا دایرکتوری. اگر دایرکتوری تنظیم شود، همه فایل‌های تست بررسی می‌شوند. اگر خالی باشد، مقادیر پیش‌فرض استفاده می‌شوند. این فلگ به 'helm template RELEASE_NAME CHART --values VALUES' به عنوان 'VALUES' پاس داده می‌شود
  -v, --version                   نسخه chartsnap

```

### مدیریت مقادیر داینامیک 💪

Helm قابلیتی به نام "توابع Helm" دارد که مقادیر تصادفی یا گواهی‌های خودامضا تولید می‌کند مانند [`randAlphaNum`](https://helm.sh/docs/chart_template_guide/function_list/#randalphanum-randalpha-randnumeric-and-randascii) و [`genCA`, `genPrivateKey`, `genSelfSignedCert`](https://helm.sh/docs/chart_template_guide/function_list/#cryptographic-and-security-functions)

هنگام استفاده از این توابع، خروجی هر بار که Helm اجرا می‌شود متفاوت خواهد بود.
برای این حالت، chartsnap قابلیتی دارد که با جایگزینی آنها با مقدار ثابت `###DYNAMIC_FIELD###` از عدم تطابق اسنپ‌شات جلوگیری می‌کند.

می‌توانید مسیرهای مقادیر داینامیک را در YAML تولیدشده با استفاده از [JSONPath](https://datatracker.ietf.org/doc/html/rfc6901) مشخص کنید.

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

> نکته:
> در JSONPath، نحوه اسکیپ کردن کاراکتر / در [RFC6901, section 3](https://datatracker.ietf.org/doc/html/rfc6901#section-3) مستند شده است.
> ```
>    چون کاراکترهای '~' (%x7E) و '/' (%x2F) معانی خاصی در JSON Pointer دارند،
>    '~' باید به '~0' و '/' باید به '~1' رمزگذاری شوند زمانی که این کاراکترها در یک توکن مرجع ظاهر می‌شوند.
> ```
>
> بنابراین اگر با مانفیستی مانند زیر کار می‌کنید، باید مسیر json را به صورت `/metadata/annotaions/checksum~1values` مشخص کنید.
> 
> ```yaml
> metadata:
>   annotations:
>     checksum/values: RANDOM_VALUES
> ```

اگر یک دایرکتوری فایل مقدار تست دارید، آن را به عنوان فایل `.chartsnap.yaml` در همان دایرکتوری قرار دهید. این یک رفتار عمومی برای همه تست‌های اسنپ‌شات در آن دایرکتوری است.

برای مثال‌های بیشتر، به [example/app1](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) مراجعه کنید.

همچنین می‌توانید پیکربندی را مستقیماً در فایل مقدار تست به عنوان ویژگی `testSpec` اضافه کنید.
در این صورت، نیازی به آماده‌سازی `.chartsnap.yaml` ندارید. این برای گرفتن اسنپ‌شات از چارت‌های راه دور یا شخص ثالث با فایل مقدار تکی شما مناسب است.

فایل مقادیر شما می‌تواند به این شکل باشد:

```yaml
# این ویژگی را به مقادیر خود اضافه کنید.
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

# سایر مقادیر می‌تواند هر مقدار دلخواه چارت شما باشد.
# ...
```

برای مثال‌های بیشتر، به [example/remote](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) مراجعه کنید.

## نمونه‌ها و کاربران ✨

| کاربران / پروژه‌ها | توضیح | URL |
|:---|:---|:---|
| Example | چارت نمونه تولیدشده توسط دستور `helm create` | [`example/app1`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/app1) |
| Example | نمونه اسنپ‌شات گرفتن چارت‌های مخزن‌های Helm راه دور | [`example/remote`](https://raw.githubusercontent.com/jlandowner/helm-chartsnap/main/example/remote) |
| [helm-chartsnap-action](https://github.com/jlandowner/helm-chartsnap-action) | اکشن GitHub برای استفاده از helm chartsnap در CI | https://github.com/jlandowner/helm-chartsnap-action |
| [cosmo-workspace](https://github.com/cosmo-workspace/cosmo) | پلتفرم متن‌باز WebIDE و محیط توسعه بر بستر Kubernetes | https://github.com/cosmo-workspace/cosmo/tree/main/charts/cosmo/test |
| [Kong](https://github.com/Kong/kong) | 🦍 دروازه API ابری و هوش مصنوعی | https://github.com/Kong/charts |


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---