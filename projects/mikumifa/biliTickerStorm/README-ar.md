# 🎫 BiliTickerStorm

## ⚙️ شرح الخدمة

| اسم الخدمة           | الشرح                | ملاحظات     |
| ----------------- | ------------------ | --------- |
| `ticket-master`   | خدمة التحكم الرئيسية، مسؤولة عن جدولة المهام    | نشر نسخة واحدة |
| `ticket-worker`   | عامل حجز التذاكر، قابل للتوسع الأفقي         | يدعم تعدد النسخ |
| `gt-python`       | خدمة معالجة رموز التحقق الصورية             | نشر نسخة واحدة  |

---

## 🚀 خطوات النشر السريع

> يمكن الرجوع إلى [دليل بناء الكلاستر](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/docs/集群搭建参考.md) لبناء الكلاستر.

<details> <summary><strong>📦 التثبيت من المستودع البعيد (موصى به)</strong></summary>

```bash
helm repo add bili-ticker-storm https://mikumifa.github.io/biliTickerStorm/
helm repo update
```
### 2. تثبيت Chart

```bash
helm install bili-ticker-storm bili-ticker-storm/bili-ticker-storm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
  
```

> - `hostDataPath` هو دليل ملفات إعدادات شراء التذاكر، يتم ربطه بحاوية `ticket-master`. يتم إنشاء ملفات إعدادات شراء التذاكر باستخدام https://github.com/mikumifa/biliTickerBuy
> - `ticketWorker.pushplusToken` هو إعداد دفع PlusPlus، بعد التعيين يمكن استقبال إشعارات نتائج شراء التذاكر.
> - `ticketWorker.ticketInterval` هو الفاصل الزمني بين عمليات شراء التذاكر بالثواني، الافتراضي 300 مللي ثانية.
> - `ticketWorker.ticketTimeStart` هو وقت بدء التشغيل المجدول، الصيغة هي `2025-05-20T13:14`، إذا لم يُملأ يبدأ شراء التذاكر عند تشغيل الحاوية مباشرة.

### 3. ترقية Chart

```bash
helm upgrade bili-ticker-storm bili-ticker-storm/bili-ticker-storm --reuse-values \
  --set ticketWorker.ticketInterval="600"
```
</details> 
<details> <summary><strong>📦 تثبيت المخطط محلياً (Chart)</strong></summary>


### 1. تثبيت المخطط (Chart)

```bash
# استنساخ المستودع
git clone https://github.com/mikumifa/biliTickerStorm
# استخدام حزمة المخطط المحلية
helm install bili-ticker-storm ./helm \
  --set ticketMaster.hostDataPath=/your/host/data/path \
  --set ticketWorker.pushplusToken="your_token" \
  --set ticketWorker.ticketInterval="300" \
  --set ticketWorker.ticketTimeStart="2025-05-20T13:14"
```
### 2. ترقية المخطط (Chart)

```bash
helm upgrade bili-ticker-storm ./helm --reuse-values
```
</details>
<details>
<summary><strong>📌 الأوامر العامة</strong></summary>

### ⏹ إلغاء التثبيت
```bash
helm uninstall bili-ticker-storm
```
</details>


## 📩 إخلاء المسؤولية

هذا المشروع يتبع رخصة MIT License ويقتصر استخدامه على التعلم والبحث الشخصي فقط. يرجى عدم استخدام هذا المشروع في أي أنشطة تجارية هادفة للربح، كما يُمنع منعاً باتاً استخدامه في أي شكل من أشكال الشراء الآلي أو الأنشطة غير القانونية أو أي استخدام ينتهك قواعد المنصات ذات الصلة. يتحمل المستخدم وحده كافة النتائج المترتبة على ذلك، ولا يتحمل صاحب المشروع أي مسؤولية.

إذا قمت بعمل fork أو استخدام هذا المشروع، يرجى التأكد من الالتزام بالقوانين واللوائح ذات الصلة وقواعد المنصة المستهدفة.

## 💡 حول معدل الوصول والتحكم في التزامن
تم تصميم هذا المشروع بناءً على مبدأ "عدم التدخل"، لتجنب أي إزعاج للخوادم المستهدفة (مثل Bilibili).

جميع فترات الانتظار بين الطلبات الشبكية يمكن للمستخدم ضبطها بنفسه، والقيم الافتراضية تحاكي سرعة العمليات اليدوية للمستخدم العادي. يعمل البرنامج بشكل افتراضي في وضع الخيط الواحد (single-threaded) بدون مهام متزامنة. في حال فشل الطلب، سيعيد البرنامج المحاولة لعدد محدود من المرات مع إضافة تأخير مناسب بين المحاولات، لتجنب تكوين طلبات متكررة عالية التردد. يعتمد المشروع بالكامل على الواجهات البرمجية والمنشورات العامة على المنصة ولا يتضمن أي وسائل تخطي نظام الحماية أو اختراق الواجهات البرمجية أو أي أساليب مدمرة أخرى.
## 🛡️ بيان احترام المنصة

تم تصميم هذا البرنامج مع محاولة التحكم في تكرار الطلبات قدر الإمكان، لتجنب أي حمل أو تأثير واضح على خوادم Bilibili. المشروع مخصص للأغراض التعليمية فقط، ولا يمتلك القدرة على العمل على نطاق واسع أو في بيئة عالية التزامن، كما أنه لا يحتوي على أي سلوك ضار أو نية لتعطيل الخدمة.

إذا كان هناك أي محتوى في هذا المشروع ينتهك الحقوق القانونية لشركة Bilibili، يرجى التواصل معي عبر البريد الإلكتروني [1055069518@qq.com](https://raw.githubusercontent.com/mikumifa/biliTickerStorm/main/mailto:1055069518@qq.com)، وسأقوم بإزالة المحتوى المعني وحذف هذا المستودع على الفور. أعتذر بشدة عن أي إزعاج قد يسببه ذلك، وأشكركم على تفهمكم وتسامحكم.

## 📄 الرخصة

[رخصة MIT](LICENSE)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-11

---