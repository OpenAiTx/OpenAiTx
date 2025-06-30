# ofetch

[![إصدار npm][npm-version-src]][npm-version-href]
[![تنزيلات npm][npm-downloads-src]][npm-downloads-href]
[![الحزمة][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![الرخصة][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

واجهة برمجة تطبيقات fetch محسّنة. تعمل على node، والمتصفح، وworkers.

<details>
  <summary>مفسد</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 البدء السريع

التثبيت:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

الاستيراد:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ يعمل مع Node.js

نستخدم [الصادرات الشرطية](https://nodejs.org/api/packages.html#packages_conditional_exports) لاكتشاف Node.js
واستخدام [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) تلقائيًا. إذا كان `globalThis.fetch` متاحًا، سيتم استخدامه بدلًا من ذلك. للاستفادة من واجهة fetch الأصلية التجريبية في Node.js 17.5.0 استخدم خيار [`--experimental-fetch`](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ تحليل الاستجابة

سيقوم `ofetch` بتحليل JSON والقيم الأصلية بذكاء باستخدام [destr](https://github.com/unjs/destr)، مع الرجوع إلى النص إذا فشل التحليل.

```js
const { users } = await ofetch("/api/users");
```

بالنسبة لأنواع المحتوى الثنائي، سيعيد `ofetch` كائن `Blob` بدلاً من ذلك.

يمكنك اختيارياً توفير محلل مختلف عن `destr`، أو تحديد `blob`، أو `arrayBuffer`، أو `text` لفرض تحليل الجسم باستخدام دالة `FetchResponse` المناسبة.

```js
// استخدم JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// إرجاع النص كما هو
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// الحصول على نسخة blob من الاستجابة
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ جسم JSON

إذا تم تمرير كائن أو فئة تحتوي على دالة `.toJSON()` إلى خيار `body`، سيقوم `ofetch` بتحويله تلقائيًا إلى سلسلة نصية.

يستخدم `ofetch` دالة `JSON.stringify()` لتحويل الكائن الممرر. يجب تحويل الفئات التي لا تحتوي على دالة `.toJSON()` إلى قيمة نصية مسبقًا قبل تمريرها إلى خيار `body`.

بالنسبة لطرق الطلب `PUT`، و`PATCH`، و`POST`، عند تعيين جسم نصي أو كائن، يضيف `ofetch` رؤوس `content-type: "application/json"` و`accept: "application/json"` الافتراضية (والتي يمكنك دائمًا تجاوزها).

بالإضافة إلى ذلك، يدعم `ofetch` الاستجابات الثنائية مع `Buffer`، و`ReadableStream`، و`Stream`، و[أنواع الأجسام المتوافقة](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). سيقوم `ofetch` تلقائيًا بتعيين خيار `duplex: "half"` لدعم البث!

**مثال:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ معالجة الأخطاء

يقوم `ofetch` تلقائيًا برمي الأخطاء عندما تكون قيمة `response.ok` هي `false` مع رسالة خطأ ودية ومكدس مختصر (مع إخفاء التفاصيل الداخلية).

يتوفر جسم الخطأ المحلل باستخدام `error.data`. يمكنك أيضًا استخدام نوع `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

لالتقاط استجابة الخطأ:

```ts
```markdown
await ofetch("/url").catch((error) => error.data);
```

لتجاوز التقاط أخطاء الحالة يمكنك تعيين خيار `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ إعادة المحاولة التلقائية

يقوم `ofetch` بإعادة محاولة الطلب تلقائيًا إذا حدث خطأ وكان رمز حالة الاستجابة مدرجًا في قائمة `retryStatusCodes`:

**رموز الحالة لإعادة المحاولة:**

- `408` - انتهت مهلة الطلب
- `409` - تعارض
- `425` - مبكر جدًا ([تجريبي](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - عدد كبير جدًا من الطلبات
- `500` - خطأ داخلي في الخادم
- `502` - بوابة غير صالحة
- `503` - الخدمة غير متوفرة
- `504` - انتهت مهلة البوابة

يمكنك تحديد عدد مرات إعادة المحاولة والفاصل الزمني بينها باستخدام خياري `retry` و`retryDelay` وأيضًا تمرير مصفوفة مخصصة من الرموز باستخدام خيار `retryStatusCodes`.

القيمة الافتراضية لـ `retry` هي محاولة واحدة فقط، باستثناء طرق `POST` و`PUT` و`PATCH` و`DELETE` حيث لا يقوم `ofetch` بإعادة المحاولة افتراضيًا لتجنب التسبب في آثار جانبية. إذا قمت بتعيين قيمة مخصصة لـ `retry` سيتم **دائمًا إعادة المحاولة** لجميع الطلبات.

القيمة الافتراضية لـ `retryDelay` هي `0` مللي ثانية.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // مللي ثانية
  retryStatusCodes: [ 404, 500 ], // رموز حالة الاستجابة لإعادة المحاولة
});
```

## ✔️ المهلة (Timeout)

يمكنك تحديد قيمة `timeout` بالملي ثانية لإلغاء الطلب تلقائيًا بعد انقضاء المهلة (الإعداد الافتراضي معطل).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // المهلة بعد 3 ثوانٍ
});
```

## ✔️ دعم الأنواع (Type Friendly)

يمكن أن تكون الاستجابة مدعومة بالأنواع:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// الإكمال التلقائي يعمل مع article.id
```

## ✔️ إضافة `baseURL`

باستخدام خيار `baseURL`، يقوم `ofetch` بإضافته مع دعم الشرطة المائلة في البداية/النهاية ومعاملات البحث في الاستعلام للـ baseURL باستخدام [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ إضافة معاملات البحث في الاستعلام

باستخدام خيار `query` (أو `params` كاسم بديل)، يضيف `ofetch` معاملات البحث في الاستعلام إلى عنوان URL مع الحفاظ على الاستعلام في الطلب نفسه باستخدام [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ المعترضات (Interceptors)

من الممكن توفير معترضات غير متزامنة للتعامل مع أحداث دورة حياة استدعاء `ofetch`.

قد ترغب في استخدام `ofetch.create` لتعيين معترضات مشتركة.

### `onRequest({ request, options })`

يتم استدعاء `onRequest` بمجرد استدعاء `ofetch`، مما يسمح لك بتعديل الخيارات أو تنفيذ تسجيل بسيط.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // تسجيل الطلب
    console.log("[fetch request]", request, options);

    // إضافة `?t=1640125211170` إلى معاملات البحث في الاستعلام
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

سيتم استدعاء `onRequestError` عند فشل طلب الجلب.
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // تسجيل الخطأ
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

سيتم استدعاء `onResponse` بعد استدعاء `fetch` وتحليل الجسم.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // تسجيل الاستجابة
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` هو نفسه `onResponse` ولكن سيتم استدعاؤه عندما يحدث الجلب ولكن `response.ok` ليست `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // تسجيل الخطأ
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### تمرير مصفوفة من المعترضين

إذا لزم الأمر، من الممكن أيضًا تمرير مصفوفة من الدوال التي سيتم استدعاؤها بشكل تسلسلي.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* قم بفعل شيء ما */
    },
    () => {
      /* قم بفعل شيء آخر */
    },
  ],
});
```

## ✔️ إنشاء fetch مع خيارات افتراضية

تكون هذه الأداة مفيدة إذا كنت بحاجة لاستخدام خيارات شائعة عبر عدة استدعاءات fetch.

**ملاحظة:** سيتم استنساخ القيم الافتراضية على مستوى واحد ووراثتها. كن حذرًا بشأن الخيارات المتداخلة مثل `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // نفس الأمر ofetch('/test', { baseURL: '/api' })
```

## 💡 إضافة رؤوس

باستخدام خيار `headers`، يضيف `ofetch` رؤوسًا إضافية بالإضافة إلى رؤوس الطلب الافتراضية:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 الوصول إلى الاستجابة الخام

إذا كنت بحاجة للوصول إلى الاستجابة الخام (للحصول على الرؤوس، إلخ)، يمكنك استخدام `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 استخدام Fetch الأصلي

كاختصار، يمكنك استخدام `ofetch.native` التي توفر واجهة برمجة تطبيقات `fetch` الأصلية

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ إضافة وكيل HTTP(S)

في بيئات Node.js (>= 18)، يمكنك توفير موزع مخصص لاعتراض الطلبات ودعم ميزات مثل البروكسي والشهادات الموقعة ذاتيًا. هذه الميزة مفعلة بواسطة [undici](https://undici.nodejs.org/) المدمج في Node.js. [اقرأ المزيد](https://undici.nodejs.org/#/docs/api/Dispatcher) حول واجهة برمجة تطبيقات Dispatcher.

بعض الوكلاء المتاحين:

- `ProxyAgent`: فئة وكيل بروكسي تنفذ واجهة برمجة تطبيقات الوكيل. تتيح الاتصال عبر بروكسي بطريقة بسيطة. ([التوثيق](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: فئة وكيل وهمي تنفذ واجهة برمجة تطبيقات الوكيل. تتيح اعتراض طلبات HTTP التي تتم عبر undici وإرجاع ردود وهمية بدلاً منها. ([التوثيق](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: يتيح الوكيل توجيه الطلبات إلى أصول مختلفة متعددة. ([التوثيق](https://undici.nodejs.org/#/docs/api/Agent))

**مثال:** تعيين وكيل بروكسي لطلب واحد:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**مثال:** إنشاء نسخة مخصصة من fetch مع تفعيل البروكسي:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**مثال:** تعيين وكيل بروكسي لجميع الطلبات:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**مثال:** السماح بالشهادات الموقعة ذاتيًا (استخدمه على مسؤوليتك الخاصة!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// ملاحظة: هذا يجعل fetch غير آمن ضد هجمات MITM. استخدمه على مسؤوليتك الخاصة!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

في إصدارات Node.js الأقدم (<18)، يمكنك أيضًا استخدام `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### دعم `keepAlive` (يعمل فقط مع Node < 18)

عن طريق تعيين متغير البيئة `FETCH_KEEP_ALIVE` إلى `true`، سيتم تسجيل وكيل HTTP/HTTPS يحتفظ بالاتصالات حتى عند عدم وجود طلبات معلقة، بحيث يمكن استخدامها للطلبات المستقبلية دون الحاجة إلى إعادة إنشاء اتصال TCP.

**ملاحظة:** قد يؤدي هذا الخيار إلى تسرب في الذاكرة. يرجى مراجعة [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 ملاحظات حول المجمع (Bundler)

- جميع الأهداف يتم تصديرها بتنسيق Module و CommonJS وتصدير مسمى
- لا يتم تحويل أي تصدير لصالح البنية الحديثة
  - ربما تحتاج إلى تحويل حزم `ofetch` و`destr` و`ufo` باستخدام Babel لدعم ES5
- تحتاج إلى توفير polyfill للمتغير العالمي `fetch` لدعم المتصفحات القديمة مثل استخدام [unfetch](https://github.com/developit/unfetch)

## ❓ الأسئلة الشائعة

**لماذا التصدير يسمى `ofetch` بدلاً من `fetch`؟**

استخدام نفس اسم `fetch` قد يكون مربكًا لأن الواجهة البرمجية مختلفة، لكنه لا يزال وظيفة fetch لذلك تم استخدام أقرب بديل ممكن. مع ذلك، يمكنك استيراد `{ fetch }` من `ofetch`، والذي يعد polyfill تلقائي لـ Node.js ويستخدم الأصلي في الحالات الأخرى.

**لماذا لا يوجد تصدير افتراضي؟**

التصديرات الافتراضية دائمًا ما تكون عرضة للخلط مع تصديرات CommonJS.

هذا يضمن أيضًا أنه يمكننا إضافة المزيد من الأدوات دون كسر الحزمة، ويشجع أيضًا على استخدام اسم `ofetch`.

**لماذا لم يتم تحويل الشيفرة؟**

عند تحويل المكتبات، فإننا نعيد الويب إلى الوراء بشيفرة قديمة ليست ضرورية لمعظم المستخدمين.

إذا كنت بحاجة لدعم المستخدمين القدامى، يمكنك اختيارياً تحويل المكتبة في خط التجميع الخاص بك.
```
## الترخيص

MIT. صُنع بحب 💖

<!-- الشارات -->

[npm-version-src]: https://img.shields.io/npm/v/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[npm-version-href]: https://npmjs.com/package/ofetch
[npm-downloads-src]: https://img.shields.io/npm/dm/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[npm-downloads-href]: https://npmjs.com/package/ofetch
[codecov-src]: https://img.shields.io/codecov/c/gh/unjs/ofetch/main?style=flat&colorA=18181B&colorB=F0DB4F
[codecov-href]: https://codecov.io/gh/unjs/ofetch
[bundle-src]: https://img.shields.io/bundlephobia/minzip/ofetch?style=flat&colorA=18181B&colorB=F0DB4F
[bundle-href]: https://bundlephobia.com/result?p=ofetch
[license-src]: https://img.shields.io/github/license/unjs/ofetch.svg?style=flat&colorA=18181B&colorB=F0DB4F
[license-href]: https://github.com/unjs/ofetch/blob/main/LICENSE
[jsdocs-src]: https://img.shields.io/badge/jsDocs.io-reference-18181B?style=flat&colorA=18181B&colorB=F0DB4F
[jsdocs-href]: https://www.jsdocs.io/package/ofetch

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-30

---