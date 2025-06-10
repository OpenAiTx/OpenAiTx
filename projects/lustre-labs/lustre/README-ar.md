<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>اجعل واجهتك الأمامية تتألق</strong> ✨
</div>

<div align="center">
  إطار عمل لبناء تطبيقات الويب باستخدام Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="متوفر على Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="التوثيق" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      الموقع الإلكتروني
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      البدء السريع
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      المرجع
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>تم تطويره بمحبة ❤︎ بواسطة
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> و
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    المساهمين
  </a>
</div>

---

## جدول المحتويات

- [الميزات](#features)
- [مثال](#example)
- [الفلسفة](#philosophy)
- [التثبيت](#installation)
- [إلى أين بعد ذلك](#where-next)
- [الدعم](#support)

## الميزات {#features}

- واجهة برمجية **إعلانية** ووظيفية لبناء HTML. لا قوالب، لا ماكروز،
  فقط Gleam.

- بنية مستوحاة من Erlang و Elm من أجل **إدارة الحالة**.

- **تأثيرات جانبية مُدارة** لكتابة كود يمكن اختباره ويمكن التنبؤ به.

- مكونات عالمية. **اكتب مرة واحدة، وشغّل في أي مكان**. Elm تلتقي مع Phoenix LiveView.

- **واجهة أوامر شاملة** تجعل إنشاء وبناء التطبيقات سهلاً.

- **عرض من جهة الخادم** لنمذجة HTML ثابتة.

## مثال {#example}

يأتي Lustre مع [أكثر من 20 مثالاً](https://hexdocs.pm/lustre/reference/examples.html)!
هكذا يبدو الأمر:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## الفلسفة {#philosophy}

Lustre هو إطار عمل _برأي محدد_ لبناء تطبيقات ويب صغيرة إلى متوسطة الحجم.
تطوير الواجهات الأمامية الحديثة صعب ومعقد. بعض من هذا التعقيد ضروري، لكن الكثير منه عرضي أو يأتي من وجود الكثير من الخيارات.
لدى Lustre نفس فلسفة التصميم مثل Gleam: حيثما أمكن، يجب أن يكون هناك طريقة واحدة فقط للقيام بالأشياء.

هذا يعني توفير نظام إدارة حالة واحد مع الإطار من البداية، مستوحى من Elm و Erlang/OTP.
افتح أي تطبيق Lustre ويجب أن تشعر وكأنك في منزلك.

ويعني أيضًا أننا نشجع الطرق البسيطة لبناء الواجهات بدلاً من الطرق المعقدة.
يحتوي Lustre على طريقة لإنشاء مكونات ذات حالة مغلقة (وهو شيء افتقدناه في Elm)
لكن لا ينبغي أن يكون ذلك هو الافتراضي. فضّل الدوال البسيطة على المكونات ذات الحالة.

عندما تكون المكونات _ضرورية_، استثمر في حقيقة أن مكونات Lustre يمكن أن تعمل _في أي مكان_.
يمنحك Lustre الأدوات لكتابة مكونات يمكن تشغيلها داخل تطبيق Lustre موجود،
أو تصديرها كمكون ويب مستقل، أو تشغيلها على الخادم مع وقت تشغيل بسيط لتعديل الـ DOM.
يطلق Lustre على هذه المكونات اسم **المكونات العالمية** ويتم كتابتها مع أخذ أهداف Gleam المتعددة في الاعتبار.

## التثبيت {#installation}

تم نشر Lustre على [Hex](https://hex.pm/packages/lustre)! يمكنك إضافته إلى مشاريع Gleam الخاصة بك من سطر الأوامر:

```sh
gleam add lustre
```

يحتوي Lustre أيضًا على حزمة مصاحبة تحتوي على أدوات تطوير قد ترغب في تثبيتها:

> **ملاحظة**: خادم التطوير lustre_dev_tools يراقب نظام ملفاتك
> لاكتشاف التغييرات في كود gleam الخاص بك ويمكنه إعادة تحميل المتصفح تلقائيًا.
> بالنسبة لمستخدمي لينكس، يتطلب ذلك تثبيت [inotify-tools]()

```sh
gleam add --dev lustre_dev_tools
```

## إلى أين بعد ذلك {#where-next}

للتعرف على Lustre بسرعة، راجع [دليل البدء السريع](https://hexdocs.pm/lustre/guide/01-quickstart.html).
إذا كنت تفضل رؤية بعض الكود، فإن مجلد [الأمثلة](https://github.com/lustre-labs/lustre/tree/main/examples)
يحتوي على مجموعة من التطبيقات الصغيرة التي توضح جوانب مختلفة من الإطار.

يمكنك أيضًا قراءة التوثيق ومرجع واجهة برمجة التطبيقات على
[HexDocs](https://hexdocs.pm/lustre).

## الدعم {#support}

يتم تطوير Lustre في الغالب من قبلي فقط، [Hayleigh](https://github.com/hayleigh-dot-dev)،
إلى جانب وظيفتين أخريين. إذا كنت ترغب في دعم عملي، يمكنك [رعايتي على GitHub](https://github.com/sponsors/hayleigh-dot-dev).

المساهمات مرحب بها دائمًا! إذا وجدت خطأ أو ترغب في اقتراح ميزة،
يرجى فتح تذكرة أو إرسال طلب دمج.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---