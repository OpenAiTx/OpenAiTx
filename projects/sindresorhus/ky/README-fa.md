<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> کی (Ky) یک کلاینت کوچک و زیبا برای HTTP است که بر پایه [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) ساخته شده است.

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

کی برای [مرورگرهای مدرن](#browser-support)، Node.js، Bun و Deno هدف‌گذاری شده است.

این فقط یک بسته‌ی کوچک بدون هیچ وابستگی است.

## مزایا نسبت به `fetch` ساده

- API ساده‌تر
- میانبرهای متد (مثلاً `ky.post()`)
- وضعیت‌های غیر ۲xx را به عنوان خطا در نظر می‌گیرد (پس از ریدایرکت‌ها)
- درخواست‌های ناموفق را مجدداً تلاش می‌کند
- گزینه ارسال JSON
- پشتیبانی از تایم‌اوت
- گزینه پیشوند URL
- نمونه‌هایی با مقادیر پیش‌فرض سفارشی
- هوک‌ها (Hooks)
- قابلیت‌های TypeScript (مثلاً `.json()` از جنریک پشتیبانی می‌کند و مقدار پیش‌فرض آن `unknown` است، نه `any`)

## نصب

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## استفاده

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

با استفاده از `fetch` ساده، این کد به شکل زیر خواهد بود:

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

اگر از [Deno](https://github.com/denoland/deno) استفاده می‌کنید، کی را از یک URL ایمپورت کنید. برای مثال، با استفاده از یک CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

پارامترهای `input` و `options` مشابه [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) هستند، با این تفاوت که گزینه‌های اضافه‌تری نیز دارند (در ادامه مشاهده کنید).

یک [شیء `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) با [متدهای `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) برای راحتی بیشتر بازمی‌گرداند. بنابراین، می‌توانید مثلاً مستقیماً `ky.get(input).json()` را صدا بزنید بدون آن‌که منتظر دریافت `Response` باشید. در این حالت، هدر `Accept` مناسب با توجه به متد body انتخاب خواهد شد. برخلاف متدهای `Body` در `window.Fetch`، این متدها در صورتی که وضعیت پاسخ در بازه `200...299` نباشد، یک خطای `HTTPError` پرتاب خواهند کرد. همچنین، `.json()` در صورتی که body خالی باشد یا وضعیت پاسخ `204` باشد، رشته خالی باز می‌گرداند، به جای این‌که خطای تجزیه به دلیل body خالی رخ دهد.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** پارامتر نوع اختیاری [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) را می‌پذیرد که مقدار پیش‌فرض آن [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) است و به نوع بازگشتی `.json()` منتقل می‌شود.

```ts
import ky from 'ky';

// user1 از نوع unknown است
const user1 = await ky('/api/users/1').json();
// user2 از نوع User است
const user2 = await ky<User>('/api/users/2').json();
// user3 از نوع User است
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

گزینه `options.method` را به نام متد مورد نظر تنظیم می‌کند و درخواست را ارسال می‌کند.

⌨️ **TypeScript:** پارامتر نوع اختیاری برای استفاده با پاسخ‌های JSON می‌پذیرد (به [ky()](#kyinput-options) مراجعه کنید).

#### input

نوع: `string` | `URL` | `Request`

مشابه [ورودی `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

هنگامی که از یک نمونه [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) به عنوان `input` استفاده شود، هرگونه گزینه‌ای که URL را تغییر می‌دهد (مانند `prefixUrl`) نادیده گرفته می‌شود.

#### options

نوع: `object`

مشابه [گزینه‌های `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options)، به علاوه گزینه‌های اضافی زیر:

##### method

نوع: `string`\
پیش‌فرض: `'get'`

متد HTTP مورد استفاده برای ارسال درخواست.

در داخل، متدهای استاندارد (`GET`، `POST`، `PUT`، `PATCH`، `HEAD` و `DELETE`) به حروف بزرگ تبدیل می‌شوند تا از بروز خطاهای سرور به دلیل حساسیت به حروف جلوگیری شود.

##### json

نوع: `object` و هر مقدار دیگری که توسط [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) پذیرفته می‌شود

میانبر برای ارسال JSON. به جای گزینه `body` از این استفاده کنید. هر شیء ساده یا مقداری را می‌پذیرد که با `JSON.stringify()` تبدیل و در body همراه با هدر مناسب ارسال می‌شود.

##### searchParams

نوع: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
پیش‌فرض: `''`

پارامترهای جستجو برای اضافه شدن به URL درخواست. تنظیم این گزینه همه پارامترهای جستجوی موجود در URL ورودی را بازنویسی می‌کند.

هر مقداری که توسط [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) پشتیبانی می‌شود را می‌پذیرد.

##### prefixUrl

نوع: `string | URL`

یک پیشوند برای اضافه شدن به URL ورودی هنگام ارسال درخواست. می‌تواند هر URL معتبر (نسبی یا مطلق) باشد. اسلش انتهایی `/` اختیاری است و در صورت نیاز به طور خودکار اضافه می‌شود. فقط هنگامی که `input` یک رشته باشد اعمال می‌شود. زمانی که از این گزینه استفاده می‌کنید، آرگومان `input` نباید با اسلش `/` شروع شود.

هنگام استفاده با [`ky.extend()`](#kyextenddefaultoptions) برای ساخت نمونه‌های کی مخصوص کاربردهای خاص مفید است.

```js
import ky from 'ky';

// روی https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

نکات:
 - پس از ترکیب `prefixUrl` و `input`، نتیجه نسبت به [آدرس پایه](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) صفحه (در صورت وجود) حل می‌شود.
 - استفاده از اسلش ابتدایی در `input` هنگام استفاده از این گزینه مجاز نیست تا یکپارچگی حفظ و ابهام در نحوه پردازش URL از بین برود، زیرا زمانی که `prefixUrl` استفاده می‌شود، `input` از قوانین معمول حل URL پیروی نمی‌کند و معنای اسلش ابتدایی تغییر می‌کند.

##### retry

نوع: `object | number`\
پیش‌فرض:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

یک شیء که نمایانگر فیلدهای `limit`، `methods`، `statusCodes`، `afterStatusCodes` و `maxRetryAfter` برای تعداد حداکثر تلاش مجدد، متدهای مجاز، کدهای وضعیت مجاز، کدهای وضعیتی که اجازه دارند از زمان [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) استفاده کنند و حداکثر زمان [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) است.

اگر مقدار `retry` یک عدد باشد، به عنوان `limit` استفاده خواهد شد و سایر مقادیر پیش‌فرض باقی می‌مانند.

اگر پاسخ حاوی یک کد وضعیت HTTP باشد که در `afterStatusCodes` آمده است، Ky تا زمانی که تاریخ، تایم‌اوت یا timestamp داده شده در هدر [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) سپری شود، برای تلاش مجدد منتظر می‌ماند. اگر هدر `Retry-After` وجود نداشته باشد، هدر غیر استاندارد [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) به عنوان جایگزین استفاده می‌شود. اگر کد وضعیت ارائه شده در لیست نباشد، هدر [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) نادیده گرفته می‌شود.

اگر `maxRetryAfter` برابر با `undefined` تنظیم شود، از `options.timeout` استفاده خواهد شد. اگر مقدار هدر [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) بزرگتر از `maxRetryAfter` باشد، از `maxRetryAfter` استفاده می‌شود.

گزینه `backoffLimit` حداکثر تاخیر به ازای هر تلاش مجدد بر حسب میلی‌ثانیه است.
برای محدود کردن تاخیر، به عنوان مثال مقدار `backoffLimit` را روی ۱۰۰۰ قرار دهید.
به طور پیش‌فرض، تاخیر با فرمول `0.3 * (2 ** (attemptCount - 1)) * 1000` محاسبه می‌شود. تاخیر به صورت نمایی افزایش می‌یابد.

گزینه `delay` می‌تواند برای تغییر نحوه محاسبه تاخیر بین تلاش‌های مجدد استفاده شود. این تابع یک پارامتر دریافت می‌کند که شمارنده تلاش است و از `1` شروع می‌شود.

تلاش مجدد پس از یک [timeout](#timeout) انجام نمی‌شود.

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

نوع: `number | false`\
پیش‌فرض: `10000`

تایم‌اوت بر حسب میلی‌ثانیه برای دریافت پاسخ، شامل هر گونه تلاش مجدد. نمی‌تواند از ۲۱۴۷۴۸۳۶۴۷ بیشتر باشد.
اگر مقدار آن `false` باشد، هیچ تایم‌اوتی وجود نخواهد داشت.

##### hooks

نوع: `object<string, Function[]>`\
پیش‌فرض: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

هوک‌ها امکان تغییر در طول چرخه درخواست را فراهم می‌کنند. توابع هوک می‌توانند async باشند و به صورت سری اجرا می‌شوند.

###### hooks.beforeRequest

نوع: `Function[]`\
پیش‌فرض: `[]`

این هوک به شما اجازه می‌دهد تا درست قبل از ارسال درخواست، آن را تغییر دهید. پس از این، Ky هیچ تغییری روی درخواست اعمال نمی‌کند. تابع هوک، `request` و `options` را به عنوان آرگومان دریافت می‌کند. برای مثال می‌توانید در این قسمت، `request.headers` را تغییر دهید.

این هوک می‌تواند یک [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) را برای جایگزین کردن درخواست ارسالی بازگرداند، یا یک [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) را بازگرداند تا به طور کامل از ارسال درخواست HTTP جلوگیری شود. این می‌تواند برای شبیه‌سازی درخواست، بررسی کش داخلی و غیره استفاده شود. یک نکته **مهم** هنگام بازگرداندن درخواست یا پاسخ از این هوک این است که هر هوک باقی‌مانده‌ی `beforeRequest` نادیده گرفته خواهد شد، بنابراین شاید بخواهید فقط از آخرین هوک آن را بازگردانید.

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

نوع: `Function[]`\
پیش‌فرض: `[]`

این هوک امکان تغییر درخواست درست قبل از تلاش مجدد را فراهم می‌کند. پس از این، Ky هیچ تغییری روی درخواست اعمال نمی‌کند. تابع هوک یک شیء شامل درخواست و گزینه‌های نرمال‌شده، یک نمونه خطا و شمارنده تلاش مجدد را دریافت می‌کند. برای مثال می‌توانید در این قسمت، `request.headers` را تغییر دهید.

اگر درخواست یک پاسخ دریافت کند، خطا از نوع `HTTPError` خواهد بود و شیء `Response` در `error.response` در دسترس است. توجه داشته باشید که برخی خطاها، مانند خطاهای شبکه، ذاتاً به این معنا هستند که پاسخی دریافت نشده است. در این صورت، خطا از نوع `HTTPError` نخواهد بود.

می‌توانید با پرتاب یک خطا، مانع تلاش مجدد Ky شوید. Ky آن را به هیچ وجه مدیریت نمی‌کند و خطا به فراخوان درخواست منتقل می‌شود. بقیه هوک‌های `beforeRetry` در این حالت فراخوانی نخواهند شد. به طور جایگزین، می‌توانید نماد [`ky.stop`](#kystop) را بازگردانید تا همین کار را بدون انتقال خطا انجام دهید (این گزینه محدودیت‌هایی دارد، برای جزئیات به مستندات `ky.stop` مراجعه کنید).

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

نوع: `Function[]`\
پیش‌فرض: `[]`

این هوک به شما امکان می‌دهد تا درست قبل از پرتاب خطای `HTTPError`، آن را تغییر دهید. تابع هوک یک `HTTPError` را به عنوان آرگومان دریافت می‌کند و باید یک نمونه `HTTPError` بازگرداند.

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

نوع: `Function[]`\
پیش‌فرض: `[]`

این هوک به شما امکان می‌دهد پاسخ را بخوانید و در صورت نیاز تغییر دهید. تابع هوک، درخواست نرمال‌شده، گزینه‌ها و یک کپی از پاسخ را به عنوان آرگومان دریافت می‌کند. اگر مقدار بازگشتی تابع هوک یک نمونه از [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) باشد، توسط Ky به عنوان شیء پاسخ استفاده خواهد شد.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// می‌توانید عملی روی پاسخ انجام دهید، مثلاً لاگ بگیرید.
				log(response);

				// یا یک نمونه `Response` برای بازنویسی پاسخ بازگردانید.
				return new Response('A different response', {status: 200});
			},

			// یا در خطای ۴۰۳، با یک توکن جدید دوباره تلاش کنید
			async (request, options, response) => {
				if (response.status === 403) {
					// دریافت توکن جدید
					const token = await ky('https://example.com/token').text();

					// تلاش مجدد با توکن جدید
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

نوع: `boolean`\
پیش‌فرض: `true`

وقتی که پس از دنبال کردن ریدایرکت‌ها، پاسخ دارای کد وضعیت غیر 2xx باشد، یک `HTTPError` پرتاب می‌کند. برای این که در ریدایرکت‌ها نیز خطا پرتاب شود (به جای دنبال کردن آن‌ها)، گزینه [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) را روی `'manual'` قرار دهید.

قرار دادن این مقدار روی `false` زمانی مفید است که دنبال بررسی در دسترس بودن منابع هستید و انتظار دریافت پاسخ خطا دارید.

توجه: اگر `false` باشد، پاسخ‌های خطا موفقیت‌آمیز تلقی می‌شوند و درخواست مجدداً تلاش نخواهد شد.

##### onDownloadProgress

نوع: `Function`

هندلر رویداد پیشرفت دانلود.

این تابع آرگومان‌های زیر را دریافت می‌کند:
- `progress` یک شیء با خواص زیر است:
- - `percent` عددی بین ۰ تا ۱ که درصد پیشرفت را نشان می‌دهد.
- - `transferredBytes` تعداد بایت‌های منتقل‌شده تا این لحظه است.
- - `totalBytes` مجموع بایت‌هایی است که باید منتقل شوند. این یک تخمین است و اگر اندازه کل قابل تعیین نباشد ممکن است ۰ باشد.
- `chunk` نمونه‌ای از `Uint8Array` است که داده ارسال‌شده را شامل می‌شود. توجه: در اولین فراخوانی خالی است.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// مثال خروجی:
		// `0% - 0 از 1271 بایت`
		// `100% - 1271 از 1271 بایت`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

نوع: `Function`
مدیر رویداد پیشرفت آپلود.

این تابع آرگومان‌های زیر را دریافت می‌کند:
- `progress` یک شی با این ویژگی‌ها است:
- - `percent` عددی بین ۰ و ۱ است که درصد پیشرفت را نشان می‌دهد.
- - `transferredBytes` تعداد بایت‌هایی است که تا کنون منتقل شده‌اند.
- - `totalBytes` کل تعداد بایت‌هایی است که باید منتقل شوند. این مقدار تقریبی است و ممکن است ۰ باشد اگر اندازه کل قابل تعیین نباشد.
- `chunk` یک نمونه از `Uint8Array` است که داده‌های ارسال‌شده را در خود دارد. توجه: برای فراخوانی نهایی، این مقدار خالی است.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// خروجی نمونه:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

نوع: `Function`\
پیش‌فرض: `JSON.parse()`

تابع کاربر برای تجزیه JSON.

موارد استفاده:
1. تجزیه JSON با استفاده از [بسته `bourne`](https://github.com/hapijs/bourne) برای محافظت در برابر آلودگی prototype.
2. تجزیه JSON با گزینه [`reviver` در `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

نوع: `Function`\
پیش‌فرض: `JSON.stringify()`

تابع کاربر برای رشته‌ای کردن JSON.

موارد استفاده:
1. رشته‌ای کردن JSON با یک تابع `replacer` سفارشی.

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

نوع: `Function`\
پیش‌فرض: `fetch`

تابع `fetch` تعریف‌شده توسط کاربر.
باید کاملاً با استاندارد [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) سازگار باشد.

موارد استفاده:
1. استفاده از پیاده‌سازی‌های سفارشی `fetch` مانند [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. استفاده از تابع بسته‌بندی `fetch` که توسط برخی فریم‌ورک‌ها برای رندر سمت سرور (SSR) ارائه می‌شود.

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

ایجاد یک نمونه جدید از `ky` با برخی پیش‌فرض‌ها که با مقادیر دلخواه شما بازنویسی شده‌اند.

برخلاف `ky.create()`، `ky.extend()` پیش‌فرض‌ها را از والد به ارث می‌برد.

شما می‌توانید headerها را به صورت یک نمونه از `Headers` یا یک شیء معمولی ارسال کنید.

می‌توانید یک header را با `.extend()` و با مقدار `undefined` حذف کنید.
ارسال `undefined` به صورت رشته، header را فقط زمانی حذف می‌کند که از یک نمونه `Headers` آمده باشد.

به همین ترتیب، می‌توانید ورودی‌های `hooks` موجود را با توسعه hook با مقدار `undefined` صریح حذف کنید.

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

همچنین می‌توانید با ارائه یک تابع به `.extend()` به پیش‌فرض‌های والد ارجاع دهید.

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

ایجاد یک نمونه جدید Ky با پیش‌فرض‌های کاملاً جدید.

```js
import ky from 'ky';

// روی https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

نوع: `object`

### ky.stop

یک `Symbol` که می‌تواند توسط hook `beforeRetry` برای توقف تلاش مجدد بازگردانده شود. این کار همچنین اجرای باقی‌مانده‌ی hookهای `beforeRetry` را کوتاه می‌کند.

توجه: بازگرداندن این symbol باعث می‌شود Ky عملیات را قطع کرده و با پاسخ `undefined` بازگردد. حتماً قبل از دسترسی به هر ویژگی روی پاسخ، وجود آن را بررسی کنید یا از [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining) استفاده نمایید. همچنین این مورد با متدهای body مانند `.json()` یا `.text()` ناسازگار است، زیرا پاسخی برای تجزیه وجود ندارد. به طور کلی، توصیه می‌کنیم به جای بازگرداندن این symbol، یک خطا پرتاب کنید تا Ky عملیات را قطع کند و سپس خطا پرتاب شود که این محدودیت‌ها را ندارد.

یک مورد استفاده معتبر برای `ky.stop` جلوگیری از تلاش مجدد هنگام ارسال درخواست‌هایی با اثر جانبی است که بازگشت داده مهم نیست. برای مثال، ثبت فعالیت کاربر در سرور.

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
// توجه داشته باشید که response در صورتی که `ky.stop` بازگردانده شود، مقدار `undefined` خواهد داشت.
const response = await ky.post('https://example.com', options);

// استفاده از `.text()` یا سایر متدهای بدنه پشتیبانی نمی‌شود.
const text = await ky('https://example.com', options).text();
```

### HTTPError

برای بررسی با `instanceof` در دسترس است. این خطا دارای ویژگی `response` با [شیء Response](https://developer.mozilla.org/en-US/docs/Web/API/Response)، ویژگی `request` با [شیء Request](https://developer.mozilla.org/en-US/docs/Web/API/Request)، و ویژگی `options` با گزینه‌های نرمال‌شده (که یا هنگام ساخت نمونه با `ky.create()` یا مستقیماً هنگام ارسال درخواست به ky داده شده‌اند) می‌باشد.

توجه داشته باشید که برخی از انواع خطاها، مانند خطاهای شبکه، ذاتاً به این معنی است که پاسخی دریافت نشده است. در این صورت، خطا نمونه‌ای از HTTPError نخواهد بود و ویژگی `response` را نخواهد داشت.

اگر نیاز دارید که پاسخ واقعی را هنگام رخ دادن `HTTPError` بخوانید، متد parser مربوطه را روی شیء response فراخوانی کنید. برای مثال:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** یک [پارامتر نوعی اختیاری](https://www.typescriptlang.org/docs/handbook/2/generics.html) را می‌پذیرد که پیش‌فرض آن [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) است و به نوع بازگشتی `error.response.json()` منتقل می‌شود.

### TimeoutError

این خطا زمانی پرتاب می‌شود که درخواست زمان‌بر می‌شود. دارای ویژگی `request` با [شیء Request](https://developer.mozilla.org/en-US/docs/Web/API/Request) است.

## نکات

### ارسال داده‌های فرم

ارسال داده‌های فرم در Ky دقیقاً مشابه `fetch` است. کافی است یک نمونه از [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) را به گزینه‌ی `body` بدهید. هدر `Content-Type` به طور خودکار روی `multipart/form-data` تنظیم می‌شود.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

اگر می‌خواهید داده‌ها را با فرمت `application/x-www-form-urlencoded` ارسال کنید، باید داده‌ها را با [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) رمزگذاری کنید.

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### تنظیم `Content-Type` سفارشی

Ky به طور خودکار هدر [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) مناسب را بر اساس داده‌های بدنه درخواست تنظیم می‌کند. با این حال، برخی APIها به نوع محتوای سفارشی و غیر استاندارد مانند `application/x-amz-json-1.1` نیاز دارند. با استفاده از گزینه‌ی `headers` می‌توانید نوع محتوا را به صورت دستی بازنویسی کنید.

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

### لغو درخواست

Fetch (و Ky) به طور داخلی از لغو درخواست از طریق [API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) پشتیبانی می‌کند. [بیشتر بخوانید.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

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
		console.log('Fetch aborted');
	} else {
		console.error('Fetch error:', error);
	}
}
```

## پرسش‌های متداول (FAQ)

#### چطور می‌توانم از این در Node.js استفاده کنم؟

Node.js 18 و بالاتر به صورت بومی از `fetch` پشتیبانی می‌کند، بنابراین می‌توانید این بسته را مستقیماً استفاده کنید.

#### چطور می‌توانم از این در یک اپ وب (React، Vue.js و غیره) که رندر سمت سرور (SSR) دارد استفاده کنم؟

همانند بالا.

#### چطور می‌توانم یک کتابخانه مرورگر که از این استفاده می‌کند را تست کنم؟

یا از یک تست رانر که می‌تواند در مرورگر اجرا شود مانند Mocha استفاده کنید، یا از [AVA](https://avajs.dev) با `ky-universal` بهره ببرید. [بیشتر بخوانید.](https://github.com/sindresorhus/ky-universal#faq)

#### چطور می‌توانم بدون یک باندلر مانند Webpack از این استفاده کنم؟

مطمئن شوید کد شما به صورت ماژول جاوااسکریپت (ESM) اجرا می‌شود، مثلاً با استفاده از تگ `<script type="module">` در سند HTML خود. سپس Ky را می‌توان مستقیماً بدون باندلر یا ابزار دیگر توسط آن ماژول وارد کرد.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### چه تفاوتی با [`got`](https://github.com/sindresorhus/got) دارد؟

پاسخ من را [اینجا](https://twitter.com/sindresorhus/status/1037406558945042432) ببینید. Got توسط همان تیم Ky نگهداری می‌شود.

#### چه تفاوتی با [`axios`](https://github.com/axios/axios) دارد؟

پاسخ من را [اینجا](https://twitter.com/sindresorhus/status/1037763588826398720) ببینید.

#### چه تفاوتی با [`r2`](https://github.com/mikeal/r2) دارد؟

پاسخ من را در [#10](https://github.com/sindresorhus/ky/issues/10) ببینید.

#### معنی `ky` چیست؟

این فقط یک نام تصادفی کوتاه برای بسته npm است که توانستم بگیرم. البته در زبان ژاپنی معنایی هم دارد:

> به عنوان یک اصطلاح اختصاری متنی، KY مخفف 空気読めない (kuuki yomenai) است که به معنای «توانایی نخواندن جو» می‌باشد. این عبارت به کسی گفته می‌شود که معنی ضمنی را متوجه نمی‌شود.

## پشتیبانی مرورگر

آخرین نسخه از Chrome، Firefox و Safari.

## پشتیبانی Node.js

Node.js نسخه ۱۸ و بالاتر.

## مرتبط

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - ابزارهای مفید برای کار با Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - هوک‌های Ky برای تغییر قالب درخواست‌ها و پاسخ‌های اشیاء

## نگهدارندگان

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---