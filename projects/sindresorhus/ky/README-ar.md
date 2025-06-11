<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky هو عميل HTTP صغير وأنيق مبني على [واجهة برمجة تطبيقات الجلب Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

يستهدف Ky [المتصفحات الحديثة](#browser-support)، وNode.js، وBun، وDeno.

إنه مجرد حزمة صغيرة بدون أي تبعيات.

## الفوائد مقارنة بـ `fetch` العادي

- واجهة برمجة تطبيقات أبسط
- اختصارات للطرق (`ky.post()`)
- يعامل رموز الحالة غير 2xx كأخطاء (بعد عمليات إعادة التوجيه)
- يعيد المحاولة للطلبات الفاشلة
- خيار JSON
- دعم المهلة الزمنية
- خيار بادئة عنوان URL
- مثيلات بإعدادات افتراضية مخصصة
- Hooks
- ميزات TypeScript (على سبيل المثال، `.json()` يدعم الأنواع العامة ويفترض افتراضياً القيمة `unknown` وليس `any`)

## التثبيت

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## الاستخدام

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

باستخدام `fetch` العادي، سيكون الأمر كالتالي:

```js
class HTTPError extends Error {}

const response = await fetch('https://example.com', {
	method: 'POST',
	body: JSON.stringify({foo: true}),
	headers: {
		'content-type': 'application/json'
	}
});

if (!response.ok) {
	throw new HTTPError(`Fetch error: ${response.statusText}`);
}

const json = await response.json();

console.log(json);
//=> {data: '🦄'}
```

إذا كنت تستخدم [Deno](https://github.com/denoland/deno)، قم باستيراد Ky من عنوان URL. على سبيل المثال، باستخدام CDN:

```js
import ky from 'https://esm.sh/ky';
```

## واجهة برمجة التطبيقات (API)

### ky(input, options?)

المعاملان `input` و`options` هما نفس معاملَي [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)، مع توفر خيارات إضافية (انظر أدناه).

تعيد [كائن `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) مع [طرق `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) مضافة من أجل الراحة. لذا يمكنك، على سبيل المثال، استدعاء `ky.get(input).json()` مباشرة دون الحاجة إلى انتظار `Response` أولاً. عند الاستدعاء بهذه الطريقة، سيتم تعيين ترويسة `Accept` المناسبة حسب طريقة الجسم المستخدمة. على عكس طرق الجسم في `window.Fetch`، ستقوم هذه الطرق برمي خطأ من نوع `HTTPError` إذا لم تكن حالة الاستجابة ضمن النطاق `200...299`. أيضاً، ستعيد `.json()` سلسلة فارغة إذا كان الجسم فارغاً أو كانت حالة الاستجابة `204` بدلاً من رمي خطأ تحليل بسبب الجسم الفارغ.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** تقبل معلمة نوعية اختيارية [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html)، والتي تفترض افتراضياً [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)، ويتم تمريرها إلى نوع القيمة المرجعة من `.json()`.

```ts
import ky from 'ky';

// user1 هو unknown
const user1 = await ky('/api/users/1').json();
// user2 هو User
const user2 = await ky<User>('/api/users/2').json();
// user3 هو User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

يضبط `options.method` على اسم الطريقة ويجري الطلب.

⌨️ **TypeScript:** يقبل معلمة نوعية اختيارية للاستخدام مع استجابات JSON (انظر [`ky()`](#kyinput-options)).

#### input

النوع: `string` | `URL` | `Request`

نفس [مدخلات `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

عند استخدام كائن [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) كمدخل `input`، سيتم تجاهل أي خيارات تغير عنوان URL (مثل `prefixUrl`).

#### options

النوع: `object`

نفس [خيارات `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options)، بالإضافة إلى الخيارات الإضافية التالية:

##### method

النوع: `string`\
القيمة الافتراضية: `'get'`

طريقة HTTP المستخدمة لإجراء الطلب.

داخلياً، يتم تحويل الطرق القياسية (`GET`، `POST`، `PUT`، `PATCH`، `HEAD` و`DELETE`) إلى أحرف كبيرة لتجنب أخطاء الخادم الناتجة عن حساسية حالة الأحرف.

##### json

النوع: `object` وأي قيمة أخرى تقبلها [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

اختصار لإرسال JSON. استخدم هذا بدلاً من خيار `body`. يقبل أي كائن عادي أو قيمة، وسيتم تحويلها إلى `JSON.stringify()` وإرسالها في الجسم مع تعيين الترويسة الصحيحة تلقائياً.

##### searchParams

النوع: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
القيمة الافتراضية: `''`

معاملات البحث التي سيتم تضمينها في عنوان URL للطلب. تعيين هذا سيستبدل جميع معاملات البحث الموجودة في عنوان URL المدخل.

يقبل أي قيمة مدعومة من [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

النوع: `string | URL`

بادئة لإضافتها إلى عنوان URL المدخل عند إجراء الطلب. يمكن أن تكون أي عنوان URL صالح، سواء نسبي أو مطلق. الفاصلة المائلة `/` في النهاية اختيارية وستتم إضافتها تلقائياً إذا لزم الأمر عند ربطها بـ`input`. يسري هذا الخيار فقط عندما يكون `input` نصياً. لا يمكن أن يبدأ معامل `input` بشرطة مائلة `/` عند استخدام هذا الخيار.

مفيد عند استخدامه مع [`ky.extend()`](#kyextenddefaultoptions) لإنشاء مثيلات Ky مخصصة لمجالات محددة.

```js
import ky from 'ky';

// على https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

ملاحظات:
 - بعد دمج `prefixUrl` و`input`، يتم حل النتيجة مقابل [عنوان URL الأساسي](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) للصفحة (إن وجد).
 - الشرطات المائلة في بداية `input` غير مسموحة عند استخدام هذا الخيار للحفاظ على الاتساق وتجنب الالتباس حول كيفية التعامل مع عنوان URL المدخل، حيث أن `input` لن يتبع قواعد حل عنوان URL المعتادة عند استخدام `prefixUrl`، مما يغير معنى الشرطة المائلة في البداية.

##### retry

النوع: `object | number`\
القيم الافتراضية:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

كائن يُمثّل حقول `limit` و`methods` و`statusCodes` و`afterStatusCodes` و`maxRetryAfter` لعدد المحاولات القصوى، والأساليب المسموح بها، وأكواد الحالة المسموح بها، وأكواد الحالة المسموح لها باستخدام وقت [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After)، وأقصى وقت لـ [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

إذا كانت قيمة `retry` رقمًا، سيتم استخدامها كـ `limit` وستبقى القيم الافتراضية الأخرى كما هي.

إذا قدّم الرد كود HTTP موجود في `afterStatusCodes`، ستنتظر Ky حتى يمر التاريخ أو المهلة أو الطابع الزمني المُعطى في ترويسة [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) قبل إعادة محاولة الطلب. إذا كانت ترويسة `Retry-After` مفقودة، سيتم استخدام الترويسة غير القياسية [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) كخيار بديل. إذا لم يكن كود الحالة المُقدم موجودًا في القائمة، سيتم تجاهل ترويسة [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

إذا تم تعيين `maxRetryAfter` إلى `undefined`، سيتم استخدام `options.timeout`. إذا كانت قيمة ترويسة [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) أكبر من `maxRetryAfter`، سيتم استخدام `maxRetryAfter`.

خيار `backoffLimit` هو الحد الأعلى للتأخير لكل محاولة إعادة في المللي ثانية.
لتقييد التأخير، عيّن `backoffLimit` إلى 1000، كمثال.
افتراضيًا، يتم حساب التأخير باستخدام `0.3 * (2 ** (attemptCount - 1)) * 1000`. يزداد التأخير بشكل أُسي.

يمكن استخدام خيار `delay` لتغيير كيفية حساب التأخير بين المحاولات. تستقبل الدالة معاملًا واحدًا، وهو عدد المحاولة، بدءًا من `1`.

لا يتم تفعيل إعادة المحاولة بعد [انتهاء المهلة](#timeout).

```js
import ky from 'ky';

const json = await ky('https://example.com', {
	retry: {
		limit: 10,
		methods: ['get'],
		statusCodes: [413],
		backoffLimit: 3000
	}
}).json();
```

##### timeout

النوع: `number | false`\
القيمة الافتراضية: `10000`

المهلة بالمللي ثانية للحصول على استجابة، بما في ذلك أي محاولات إعادة. لا يمكن أن تكون أكبر من 2147483647.
إذا تم تعيينها إلى `false`، لن يكون هناك مهلة.

##### hooks

النوع: `object<string, Function[]>`\
القيمة الافتراضية: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

تسمح الـ Hooks بالتعديلات أثناء دورة حياة الطلب. قد تكون دوال الـ Hook غير متزامنة ويتم تنفيذها بشكل تسلسلي.

###### hooks.beforeRequest

النوع: `Function[]`\
القيمة الافتراضية: `[]`

يتيح لك هذا الـ hook تعديل الطلب مباشرة قبل إرساله. لن تقوم Ky بأي تغييرات أخرى على الطلب بعد ذلك. تستقبل دالة الـ hook وسيطي `request` و`options` كوسائط. يمكنك، على سبيل المثال، تعديل `request.headers` هنا.

يمكن أن تُرجع الـ hook كائن [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) لاستبدال الطلب المُرسل، أو تُرجع كائن [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) لتجنب إجراء طلب HTTP بالكامل. يمكن استخدام ذلك لمحاكاة طلب، أو التحقق من ذاكرة تخزين مؤقت داخلية، إلخ. من **المهم** عند إعادة طلب أو استجابة من هذا الـ hook أن أي hooks متبقية من `beforeRequest` سيتم تجاوزها، لذا قد ترغب في إرجاعها فقط من الـ hook الأخير.

```js
import ky from 'ky';

const api = ky.extend({
	hooks: {
		beforeRequest: [
			request => {
				request.headers.set('X-Requested-With', 'ky');
			}
		]
	}
});

const response = await api.get('https://example.com/api/users');
```

###### hooks.beforeRetry

النوع: `Function[]`\
القيمة الافتراضية: `[]`

يتيح لك هذا الـ hook تعديل الطلب مباشرة قبل إعادة المحاولة. لن تقوم Ky بأي تغييرات أخرى على الطلب بعد ذلك. تستقبل دالة الـ hook كائنًا يحتوي على الطلب والخيارات المُوحّدة، وكائن خطأ، وعدد المحاولة. يمكنك، على سبيل المثال، تعديل `request.headers` هنا.

إذا تلقى الطلب استجابة، سيكون الخطأ من نوع `HTTPError` وسيكون كائن `Response` متاحًا في `error.response`. انتبه إلى أن بعض أنواع الأخطاء، مثل أخطاء الشبكة، تعني بطبيعتها أنه لم يتم استلام استجابة. في هذه الحالة، لن يكون الخطأ من نوع `HTTPError`.

يمكنك منع Ky من إعادة محاولة الطلب عن طريق رمي خطأ. لن تتعامل Ky معه بأي طريقة وسيتم تمرير الخطأ إلى جهة استدعاء الطلب. لن يتم استدعاء بقية الـ hooks من نوع `beforeRetry` في هذه الحالة. بدلاً من ذلك، يمكنك إرجاع الرمز [`ky.stop`](#kystop) لتحقيق نفس الغرض ولكن دون تمرير خطأ (لهذا بعض القيود، راجع وثائق `ky.stop` لمزيد من التفاصيل).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		beforeRetry: [
			async ({request, options, error, retryCount}) => {
				const token = await ky('https://example.com/refresh-token');
				request.headers.set('Authorization', `token ${token}`);
			}
		]
	}
});
```

###### hooks.beforeError

النوع: `Function[]`\
القيمة الافتراضية: `[]`

يتيح لك هذا الـ hook تعديل كائن `HTTPError` مباشرة قبل رميه. تستقبل دالة الـ hook كائن `HTTPError` كوسيط ويجب أن تُعيد نسخة من `HTTPError`.

```js
import ky from 'ky';

await ky('https://example.com', {
	hooks: {
		beforeError: [
			error => {
				const {response} = error;
				if (response && response.body) {
					error.name = 'GitHubError';
					error.message = `${response.body.message} (${response.status})`;
				}

				return error;
			}
		]
	}
});
```

###### hooks.afterResponse

النوع: `Function[]`\
القيمة الافتراضية: `[]`

يتيح لك هذا الـ hook قراءة الاستجابة واختيارياً تعديلها. تستقبل دالة الـ hook الطلب المُوحّد، الخيارات، ونسخة من الاستجابة كوسائط. سيتم استخدام قيمة الإرجاع من دالة الـ hook بواسطة Ky ككائن استجابة إذا كانت نسخة من [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// يمكنك القيام بشيء مع الاستجابة، مثلاً تسجيلها.
				log(response);

				// أو إرجاع نسخة `Response` لاستبدال الاستجابة.
				return new Response('A different response', {status: 200});
			},

			// أو إعادة المحاولة باستخدام رمز جديد عند حدوث خطأ 403
			async (request, options, response) => {
				if (response.status === 403) {
					// الحصول على رمز جديد
					const token = await ky('https://example.com/token').text();

					// إعادة المحاولة باستخدام الرمز
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

النوع: `boolean`\
القيمة الافتراضية: `true`

إلقاء خطأ `HTTPError` عند حصول استجابة بكود حالة غير 2xx بعد اتباع التحويلات. لإلقاء خطأ أيضاً عند التحويلات بدلاً من متابعتها، عيّن خيار [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) إلى `'manual'`.

قد يكون تعيين هذا إلى `false` مفيدًا إذا كنت تتحقق من توفر المورد وتتوقع استجابات أخطاء.

ملاحظة: إذا كانت `false`، تعتبر استجابات الخطأ ناجحة ولن يتم إعادة محاولة الطلب.

##### onDownloadProgress

النوع: `Function`

معالج حدث تقدم التحميل.

تستقبل الدالة هذه الوسائط:
- `progress` وهو كائن يحتوي على هذه الخصائص:
- - `percent` رقم بين 0 و 1 يمثل نسبة التقدم.
- - `transferredBytes` هو عدد البايتات المنقولة حتى الآن.
- - `totalBytes` هو إجمالي عدد البايتات المطلوب نقلها. هذا تقديري وقد يكون 0 إذا تعذر تحديد الحجم الكلي.
- `chunk` هو نسخة من `Uint8Array` تحتوي على البيانات المرسلة. ملاحظة: تكون فارغة في أول استدعاء.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// مثال على الإخراج:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

النوع: `Function`

معالج حدث تقدم التحميل.

تستقبل الدالة الوسيطات التالية:
- `progress` هو كائن يحتوي على الخصائص التالية:
- - `percent` هو رقم بين 0 و 1 يمثل نسبة التقدم.
- - `transferredBytes` هو عدد البايتات التي تم نقلها حتى الآن.
- - `totalBytes` هو إجمالي عدد البايتات التي سيتم نقلها. هذا تقدير وقد يكون 0 إذا تعذر تحديد الحجم الكلي.
- `chunk` هو مثيل من `Uint8Array` يحتوي على البيانات التي تم إرسالها. ملاحظة: يكون فارغًا في الاستدعاء الأخير.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// مثال على المخرجات:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

النوع: `Function`\
القيمة الافتراضية: `JSON.parse()`

دالة تحليل JSON مخصصة من قبل المستخدم.

حالات الاستخدام:
1. تحليل JSON عبر حزمة [`bourne`](https://github.com/hapijs/bourne) للحماية من تلوث النماذج الأولية (prototype pollution).
2. تحليل JSON مع خيار [`reviver` في `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

النوع: `Function`\
القيمة الافتراضية: `JSON.stringify()`

دالة تحويل JSON إلى سلسلة نصية مخصصة من قبل المستخدم.

حالات الاستخدام:
1. تحويل JSON إلى نص مع دالة `replacer` مخصصة.

```js
import ky from 'ky';
import {DateTime} from 'luxon';

const json = await ky('https://example.com', {
	stringifyJson: data => JSON.stringify(data, (key, value) => {
		if (key.endsWith('_at')) {
			return DateTime.fromISO(value).toSeconds();
		}

		return value;
	})
}).json();
```

##### fetch

النوع: `Function`\
القيمة الافتراضية: `fetch`

دالة `fetch` مخصصة من قبل المستخدم.
يجب أن تكون متوافقة بالكامل مع معيار [واجهة برمجة التطبيقات Fetch](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

حالات الاستخدام:
1. استخدام تطبيقات `fetch` مخصصة مثل [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. استخدام دالة تغليف `fetch` التي توفرها بعض الأطر التي تستخدم العرض من جهة الخادم (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

إنشاء مثيل جديد من `ky` مع بعض القيم الافتراضية التي يتم تجاوزها بقيمك الخاصة.

على عكس `ky.create()`, فإن `ky.extend()` يرث القيم الافتراضية من الأصل.

يمكنك تمرير الرؤوس ككائن `Headers` أو ككائن عادي.

يمكنك إزالة رأس باستخدام `.extend()` عن طريق تمرير الرأس بقيمة `undefined`.
تمرير `undefined` كسلسلة يزيل الرأس فقط إذا كان قادمًا من كائن `Headers`.

وبالمثل، يمكنك إزالة إدخالات `hooks` الموجودة عن طريق توسيع hook بقيمة `undefined` صريحة.

```js
import ky from 'ky';

const url = 'https://sindresorhus.com';

const original = ky.create({
	headers: {
		rainbow: 'rainbow',
		unicorn: 'unicorn'
	},
	hooks: {
		beforeRequest: [ () => console.log('before 1') ],
		afterResponse: [ () => console.log('after 1') ],
	},
});

const extended = original.extend({
	headers: {
		rainbow: undefined
	},
	hooks: {
		beforeRequest: undefined,
		afterResponse: [ () => console.log('after 2') ],
	}
});

const response = await extended(url).json();
//=> after 1
//=> after 2

console.log('rainbow' in response);
//=> false

console.log('unicorn' in response);
//=> true
```

يمكنك أيضًا الرجوع إلى القيم الافتراضية للأصل عن طريق توفير دالة إلى `.extend()`.

```js
import ky from 'ky';

const api = ky.create({prefixUrl: 'https://example.com/api'});

const usersApi = api.extend((options) => ({prefixUrl: `${options.prefixUrl}/users`}));

const response = await usersApi.get('123');
//=> 'https://example.com/api/users/123'

const response = await api.get('version');
//=> 'https://example.com/api/version'
```

### ky.create(defaultOptions)

إنشاء مثيل جديد من Ky مع قيم افتراضية جديدة بالكامل.

```js
import ky from 'ky';

// على https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

النوع: `object`

### ky.stop

رمز `Symbol` يمكن إرجاعه بواسطة hook `beforeRetry` لإيقاف إعادة المحاولة. سيؤدي ذلك أيضًا إلى إنهاء hooks `beforeRetry` المتبقية.

ملاحظة: إرجاع هذا الرمز يجعل Ky يتوقف ويعيد استجابة بقيمة `undefined`. تأكد من التحقق من وجود استجابة قبل الوصول إلى أي خاصية فيها أو استخدم [اختيارية السلسلة](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). كما أنه غير متوافق مع دوال الجسم مثل `.json()` أو `.text()`، لأنه لا توجد استجابة لتحليلها. بشكل عام، ننصح برمي خطأ بدلاً من إرجاع هذا الرمز، لأن ذلك سيجعل Ky يتوقف ثم يرمي خطأ، مما يتجنب هذه القيود.

حالة استخدام صالحة لـ `ky.stop` هي منع إعادة المحاولة عند إجراء طلبات من أجل تأثيرات جانبية، حيث أن البيانات المرجعة غير مهمة. على سبيل المثال، تسجيل نشاط العميل على الخادم.

```js
import ky from 'ky';

const options = {
	hooks: {
		beforeRetry: [
			async ({request, options, error, retryCount}) => {
				const shouldStopRetry = await ky('https://example.com/api');
				if (shouldStopRetry) {
					return ky.stop;
				}
			}
		]
	}
};
```
```markdown
// لاحظ أن response ستكون `undefined` في حالة إرجاع `ky.stop`.
const response = await ky.post('https://example.com', options);

// استخدام `.text()` أو طرق أخرى للجسم غير مدعوم.
const text = await ky('https://example.com', options).text();
```

### HTTPError

مكشوف لاستخدامه في فحص `instanceof`. يحتوي الخطأ على خاصية `response` مع [كائن Response](https://developer.mozilla.org/en-US/docs/Web/API/Response)، وخاصية `request` مع [كائن Request](https://developer.mozilla.org/en-US/docs/Web/API/Request)، وخاصية `options` مع الخيارات المعيارية (إما الممررة إلى `ky` عند إنشاء نسخة باستخدام `ky.create()` أو مباشرة عند تنفيذ الطلب).

كن على علم أن بعض أنواع الأخطاء، مثل أخطاء الشبكة، تعني بطبيعتها أنه لم يتم استلام رد. في هذه الحالة، لن يكون الخطأ من نوع HTTPError ولن يحتوي على خاصية `response`.

إذا كنت بحاجة لقراءة الرد الفعلي عند حدوث `HTTPError`، استدعي طريقة التحليل المناسبة على كائن الرد. على سبيل المثال:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** يقبل [معامل نوع اختياري](https://www.typescriptlang.org/docs/handbook/2/generics.html)، والذي يكون افتراضياً [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)، ويتم تمريره إلى نوع الإرجاع لـ `error.response.json()`.

### TimeoutError

الخطأ الذي يتم إطلاقه عند انتهاء مهلة الطلب. يحتوي على خاصية `request` مع [كائن Request](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## نصائح

### إرسال بيانات النماذج

إرسال بيانات النماذج في Ky مطابق تماماً لـ `fetch`. فقط مرر [كائن FormData](https://developer.mozilla.org/en-US/docs/Web/API/FormData) إلى خيار `body`. سيتم تعيين ترويسة `Content-Type` تلقائياً إلى `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

إذا كنت ترغب في إرسال البيانات بصيغة `application/x-www-form-urlencoded`، ستحتاج إلى ترميز البيانات باستخدام [URLSearchParams](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### تعيين `Content-Type` مخصص

يقوم Ky تلقائياً بتعيين ترويسة [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) مناسبة لكل طلب بناءً على البيانات في جسم الطلب. ومع ذلك، تتطلب بعض واجهات برمجة التطبيقات أنواع محتوى مخصصة وغير قياسية، مثل `application/x-amz-json-1.1`. باستخدام خيار `headers` يمكنك تجاوز نوع المحتوى يدوياً.

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {
	headers: {
		'content-type': 'application/json'
	},
	json: {
		foo: true
	},
}).json();

console.log(json);
//=> {data: '🦄'}
```

### الإلغاء

يدعم Fetch (وبالتالي Ky) إلغاء الطلبات مدمجاً من خلال [واجهة AbortController](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [اقرأ المزيد.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

مثال:

```js
import ky from 'ky';

const controller = new AbortController();
const {signal} = controller;

setTimeout(() => {
	controller.abort();
}, 5000);

try {
	console.log(await ky(url, {signal}).text());
} catch (error) {
	if (error.name === 'AbortError') {
		console.log('تم إلغاء الجلب');
	} else {
		console.error('خطأ في الجلب:', error);
	}
}
```

## الأسئلة الشائعة

#### كيف أستخدم هذا في Node.js؟

يدعم Node.js 18 وما بعده `fetch` بشكل أصلي، لذلك يمكنك استخدام هذه الحزمة مباشرة.

#### كيف أستخدم هذا مع تطبيق ويب (React, Vue.js, إلخ) يستخدم التصيير من جهة الخادم (SSR)؟

نفس الطريقة المذكورة أعلاه.

#### كيف أختبر مكتبة متصفح تستخدم هذا؟

إما استخدم أداة اختبار يمكنها العمل في المتصفح، مثل Mocha، أو استخدم [AVA](https://avajs.dev) مع `ky-universal`. [اقرأ المزيد.](https://github.com/sindresorhus/ky-universal#faq)

#### كيف أستخدم هذا بدون أداة تجميع مثل Webpack؟

تأكد من أن الكود الخاص بك يعمل كـ وحدة جافاسكريبت (ESM)، على سبيل المثال باستخدام وسم `<script type="module">` في مستند HTML. بعد ذلك يمكن استيراد Ky مباشرة من تلك الوحدة دون الحاجة لأداة تجميع أو أدوات أخرى.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### كيف يختلف هذا عن [`got`](https://github.com/sindresorhus/got)

راجع إجابتي [هنا](https://twitter.com/sindresorhus/status/1037406558945042432). تتم صيانة Got بواسطة نفس الأشخاص الذين يطورون Ky.

#### كيف يختلف هذا عن [`axios`](https://github.com/axios/axios)؟

راجع إجابتي [هنا](https://twitter.com/sindresorhus/status/1037763588826398720).

#### كيف يختلف هذا عن [`r2`](https://github.com/mikeal/r2)؟

راجع إجابتي في [#10](https://github.com/sindresorhus/ky/issues/10).

#### ماذا يعني `ky`؟

إنه مجرد اسم حزمة npm قصير وعشوائي تمكنت من الحصول عليه. ومع ذلك، له معنى في اللغة اليابانية:

> شكل من أشكال الاختصار النصي، KY هو اختصار لـ 空気読めない (kuuki yomenai)، والذي يترجم حرفياً إلى "لا يستطيع قراءة الجو". إنها عبارة تطلق على شخص لا يفهم المعنى الضمني.

## دعم المتصفحات

أحدث إصدار من Chrome وFirefox وSafari.

## دعم Node.js

Node.js 18 وما بعده.

## ذات صلة

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - أدوات مساعدة للعمل مع Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - هوكات Ky لتعديل الحالات في الطلبات والردود على الكائنات

## القائمون على الصيانة

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---