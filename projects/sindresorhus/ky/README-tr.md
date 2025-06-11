<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky, [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) tabanlı küçük ve zarif bir HTTP istemcisidir.

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky, [modern tarayıcıları](#browser-support), Node.js, Bun ve Deno'yu hedefler.

Bağımlılığı olmayan, çok küçük bir pakettir.

## Düz `fetch`'e göre avantajları

- Daha basit API
- Metot kısayolları (`ky.post()`)
- 2xx dışındaki durum kodlarını hata olarak ele alır (yönlendirmelerden sonra)
- Başarısız istekleri yeniden dener
- JSON seçeneği
- Zaman aşımı desteği
- URL öneki seçeneği
- Özel varsayılanlarla örnekler
- Kancalar (Hooks)
- TypeScript kolaylıkları (örn. `.json()` generics destekler ve varsayılan olarak `unknown` döner, `any` değil)

## Kurulum

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Kullanım

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Düz `fetch` ile şöyle olurdu:

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

[Deno](https://github.com/denoland/deno) kullanıyorsanız, Ky'yi bir URL üzerinden içe aktarın. Örneğin, bir CDN kullanarak:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` ve `options`, [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) ile aynıdır, ayrıca ek `options` da mevcuttur (aşağıya bakınız).

Bir [`Response` nesnesi](https://developer.mozilla.org/en-US/docs/Web/API/Response) döner ve kolaylık olması açısından [`Body` metotları](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) eklenmiştir. Böylece örneğin, önce `Response`'u beklemeden doğrudan `ky.get(input).json()` çağrısı yapabilirsiniz. Böyle bir kullanımda, kullanılan body metoduna göre uygun bir `Accept` başlığı ayarlanır. `window.Fetch`'in `Body` metotlarının aksine, yanıt durumu `200...299` aralığında değilse bunlar bir `HTTPError` fırlatır. Ayrıca, gövde boşsa veya yanıt durumu `204` ise, `.json()` bir ayrıştırma hatası fırlatmak yerine boş bir string döner.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Opsiyonel bir [tip parametresi](https://www.typescriptlang.org/docs/handbook/2/generics.html) kabul eder, varsayılanı [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown)'dır ve `.json()`'un dönüş tipine iletilir.

```ts
import ky from 'ky';

// user1 tipi unknown
const user1 = await ky('/api/users/1').json();
// user2 tipi User
const user2 = await ky<User>('/api/users/2').json();
// user3 tipi User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

`options.method`'ı metot ismiyle ayarlar ve isteği yapar.

⌨️ **TypeScript:** JSON yanıtlarıyla kullanım için opsiyonel tip parametresi kabul eder (bkz. [`ky()`](#kyinput-options)).

#### input

Tür: `string` | `URL` | `Request`

[`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input) ile aynı.

Bir [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) örneğini `input` olarak kullanırken, URL'yi değiştiren seçenekler (ör. `prefixUrl`) yok sayılır.

#### options

Tür: `object`

[`fetch` options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options) ile aynı, ayrıca aşağıdaki ek seçenekler:

##### method

Tür: `string`\
Varsayılan: `'get'`

İstek yapmak için kullanılan HTTP metodu.

Dahili olarak, standart metotlar (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` ve `DELETE`) büyük harfe çevrilir, böylece harf duyarlılığına sahip sunucu hataları önlenir.

##### json

Tür: `object` ve [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) tarafından kabul edilen diğer değerler

JSON göndermek için kısayol. Bunu `body` seçeneği yerine kullanın. Herhangi bir düz nesne veya değeri kabul eder, bu değer `JSON.stringify()` ile gövdeye dönüştürülür ve doğru başlık ayarlanır.

##### searchParams

Tür: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Varsayılan: `''`

İstek URL'sine dahil edilecek arama parametreleri. Bunu ayarlamak, giriş URL'sindeki tüm mevcut arama parametrelerini geçersiz kılar.

[`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) tarafından desteklenen herhangi bir değeri kabul eder.

##### prefixUrl

Tür: `string | URL`

İstek yapılırken `input` URL'sinin başına eklenecek bir önek. Geçerli herhangi bir URL olabilir, göreli veya mutlak. Sondaki eğik çizgi `/` isteğe bağlıdır ve gerekirse otomatik olarak eklenir, `input` ile birleştirildiğinde. Sadece `input` bir string olduğunda etkilidir. Bu seçenek kullanılırken `input` argümanı eğik çizgi `/` ile başlayamaz.

[`ky.extend()`](#kyextenddefaultoptions) ile birlikte kullanıldığında, belirli alanlara özel Ky örnekleri oluşturmak için kullanışlıdır.

```js
import ky from 'ky';

// https://example.com adresinde

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Notlar:
 - `prefixUrl` ve `input` birleştirildikten sonra, sonuç sayfanın [temel URL'sine](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) (varsa) göre çözülür.
 - Bu seçenek kullanılırken `input`'ta baştaki eğik çizgilere izin verilmez; tutarlılığı sağlamak ve `input` URL'sinin nasıl işlendiğiyle ilgili kafa karışıklığını önlemek için, çünkü `prefixUrl` kullanıldığında normal URL çözümleme kuralları uygulanmaz ve baştaki eğik çizginin anlamı değişir.

##### retry

Tür: `object | number`\
Varsayılan:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

`limit`, `methods`, `statusCodes`, `afterStatusCodes` ve `maxRetryAfter` alanlarını temsil eden bir nesne; maksimum tekrar denemesi sayısı, izin verilen metodlar, izin verilen durum kodları, [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) süresinin kullanılmasına izin verilen durum kodları ve maksimum [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) süresi için kullanılır.

Eğer `retry` bir sayı ise, bu değer `limit` olarak kullanılır ve diğer varsayılanlar yerinde kalır.

Eğer yanıt, `afterStatusCodes` içinde bulunan bir HTTP durum kodu sağlarsa, Ky isteği yeniden denemeden önce [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) başlığında verilen tarih, zaman aşımı veya zaman damgası geçene kadar bekler. Eğer `Retry-After` eksikse, yerine standart dışı [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) başlığı yedek olarak kullanılır. Eğer sağlanan durum kodu listede yoksa, [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) başlığı dikkate alınmaz.

Eğer `maxRetryAfter` değeri `undefined` olarak ayarlanırsa, `options.timeout` kullanılır. Eğer [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) başlığı `maxRetryAfter` değerinden büyükse, `maxRetryAfter` kullanılır.

`backoffLimit` seçeneği, tekrar deneme başına gecikmenin milisaniye cinsinden üst sınırıdır.
Gecikmeyi sınırlamak için, örneğin `backoffLimit` değerini 1000 olarak ayarlayın.
Varsayılan olarak, gecikme şu şekilde hesaplanır: `0.3 * (2 ** (attemptCount - 1)) * 1000`. Gecikme üstel olarak artar.

`delay` seçeneği, tekrar denemeler arasındaki gecikmenin nasıl hesaplanacağını değiştirmek için kullanılabilir. Fonksiyon bir parametre alır, bu da deneme sayısıdır ve `1`'den başlar.

[Zaman aşımı](#timeout) sonrasında tekrar deneme yapılmaz.

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

Tür: `number | false`\
Varsayılan: `10000`

Yanıt almak için milisaniye cinsinden zaman aşımı, tekrar denemeler dahil. 2147483647’den büyük olamaz.
Eğer `false` olarak ayarlanırsa, zaman aşımı olmaz.

##### hooks

Tür: `object<string, Function[]>`\
Varsayılan: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hook’lar, istek yaşam döngüsü sırasında değişiklik yapmanıza olanak tanır. Hook fonksiyonları async olabilir ve ardışık olarak çalıştırılır.

###### hooks.beforeRequest

Tür: `Function[]`\
Varsayılan: `[]`

Bu hook, isteği gönderilmeden hemen önce değiştirmenize olanak tanır. Ky bundan sonra istekte başka bir değişiklik yapmaz. Hook fonksiyonu, `request` ve `options` argümanlarını alır. Örneğin, burada `request.headers`’ı değiştirebilirsiniz.

Hook, giden isteği değiştirmek için bir [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) döndürebilir veya tamamen bir HTTP isteği yapmamak için bir [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) döndürebilir. Bu, bir isteği taklit etmek, dahili bir önbelleği kontrol etmek vb. için kullanılabilir. Bu hook’tan bir istek veya yanıt döndürürken **önemli** bir husus, kalan `beforeRequest` hook’larının atlanacak olmasıdır; bu nedenle, bunları yalnızca son hook’tan döndürmek isteyebilirsiniz.

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

Tür: `Function[]`\
Varsayılan: `[]`

Bu hook, tekrar denemeden hemen önce isteği değiştirmenize olanak tanır. Ky bundan sonra istekte başka bir değişiklik yapmaz. Hook fonksiyonu, normalize edilmiş istek ve seçenekler, bir hata nesnesi ve tekrar deneme sayısı ile bir nesne alır. Örneğin, burada `request.headers`’ı değiştirebilirsiniz.

Eğer istek bir yanıt aldıysa, hata tipi `HTTPError` olur ve `Response` nesnesine `error.response` üzerinden erişilebilir. Ağ hatası gibi bazı hata türlerinde ise yanıt alınmamış olur. Bu durumda, hata bir `HTTPError` örneği olmaz.

Ky’ın isteği tekrar denemesini önlemek için bir hata fırlatabilirsiniz. Ky bunu hiçbir şekilde işlemez ve hata, istek başlatıcısına iletilir. Bu durumda kalan `beforeRetry` hook’ları çağrılmaz. Alternatif olarak, aynısını hata iletmeden yapmak için [`ky.stop`](#kystop) sembolünü döndürebilirsiniz (bazı kısıtlamaları vardır, ayrıntılar için `ky.stop` dokümantasyonuna bakınız).

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

Tür: `Function[]`\
Varsayılan: `[]`

Bu hook, `HTTPError` fırlatılmadan hemen önce onu değiştirmenize olanak tanır. Hook fonksiyonu bir `HTTPError` argümanı alır ve bir `HTTPError` örneği döndürmelidir.

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

Tür: `Function[]`\
Varsayılan: `[]`

Bu hook, yanıtı okumanıza ve isteğe bağlı olarak değiştirmenize olanak tanır. Hook fonksiyonu, normalize edilmiş istek, seçenekler ve yanıtın bir klonunu argüman olarak alır. Eğer hook fonksiyonunun dönüş değeri bir [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response`) örneğiyse, Ky bunu yanıt nesnesi olarak kullanır.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Yanıt ile bir şeyler yapabilirsiniz, örneğin, loglama.
				log(response);

				// Ya da yanıtı geçersiz kılmak için bir `Response` örneği döndürebilirsiniz.
				return new Response('A different response', {status: 200});
			},

			// Ya da 403 hatasında taze bir token ile tekrar deneyin
			async (request, options, response) => {
				if (response.status === 403) {
					// Taze bir token alın
					const token = await ky('https://example.com/token').text();

					// Token ile tekrar deneyin
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Tür: `boolean`\
Varsayılan: `true`

Yönlendirmeleri takip ettikten sonra, yanıt 2xx olmayan bir durum kodu içeriyorsa bir `HTTPError` fırlatır. Yönlendirmeleri takip etmek yerine onlar için de hata fırlatmak istiyorsanız, [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) seçeneğini `'manual'` olarak ayarlayın.

Bunu `false` olarak ayarlamak, kaynak kullanılabilirliğini kontrol ederken ve hata yanıtları beklerken faydalı olabilir.

Not: Eğer `false` ise, hata yanıtları başarılı kabul edilir ve istek tekrar denenmez.

##### onDownloadProgress

Tür: `Function`

İndirme ilerleme olayı işleyicisi.

Fonksiyon şu argümanları alır:
- `progress` aşağıdaki özelliklere sahip bir nesnedir:
- - `percent` ilerleme yüzdesini temsil eden 0 ile 1 arasında bir sayıdır.
- - `transferredBytes` şimdiye kadar aktarılan bayt sayısıdır.
- - `totalBytes` aktarılacak toplam bayt sayısıdır. Bu bir tahmindir ve toplam boyut belirlenemiyorsa 0 olabilir.
- `chunk`, gönderilen verileri içeren bir `Uint8Array` örneğidir. Not: İlk çağrıda boştur.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Örnek çıktı:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Tür: `Function`

Yükleme ilerleme olayı işleyicisi.

Fonksiyon şu argümanları alır:
- `progress` şu özelliklere sahip bir nesnedir:
- - `percent`, ilerleme yüzdesini temsil eden 0 ile 1 arasında bir sayıdır.
- - `transferredBytes`, şu ana kadar aktarılan bayt sayısıdır.
- - `totalBytes`, aktarılacak toplam bayt sayısıdır. Bu bir tahmindir ve toplam boyut belirlenemiyorsa 0 olabilir.
- `chunk`, gönderilen verileri içeren bir `Uint8Array` örneğidir. Not: Son çağrıda boştur.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Örnek çıktı:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

Tip: `Function`\
Varsayılan: `JSON.parse()`

Kullanıcı tanımlı JSON ayrıştırma fonksiyonu.

Kullanım senaryoları:
1. Prototip kirliliğinden korunmak için [`bourne` paketi](https://github.com/hapijs/bourne) ile JSON ayrıştırmak.
2. [`JSON.parse()`'ın `reviver` seçeneği](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) ile JSON ayrıştırmak.

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Tip: `Function`\
Varsayılan: `JSON.stringify()`

Kullanıcı tanımlı JSON dizeleştirme fonksiyonu.

Kullanım senaryoları:
1. Özel bir `replacer` fonksiyonu ile JSON dizeleştirmek.

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

Tip: `Function`\
Varsayılan: `fetch`

Kullanıcı tanımlı `fetch` fonksiyonu.
[Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) standardı ile tamamen uyumlu olmalıdır.

Kullanım senaryoları:
1. [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch) gibi özel `fetch` uygulamaları kullanmak.
2. Sunucu tarafı render (SSR) kullanan bazı frameworklerin sağladığı `fetch` sarmalayıcı fonksiyonunu kullanmak.

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Kendi varsayılanlarınız ile bazı varsayılanlar üzerine yazılmış yeni bir `ky` örneği oluşturun.

`ky.create()`'dan farklı olarak, `ky.extend()` varsayılanları üst sınıfından devralır.

Başlıkları bir `Headers` örneği veya düz bir nesne olarak geçebilirsiniz.

Bir başlığı, `undefined` değeri ile başlığı geçirerek `.extend()` ile kaldırabilirsiniz.
Bir başlığın yalnızca bir `Headers` örneğinden gelmesi durumunda, başlığı kaldırmak için `undefined` bir dize olarak geçilmelidir.

Benzer şekilde, var olan `hooks` girdilerini açıkça `undefined` ile uzatarak kaldırabilirsiniz.

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

Ayrıca, `.extend()` fonksiyonuna bir fonksiyon sağlayarak üst varsayılanlara başvurabilirsiniz.

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

Tamamen yeni varsayılanlarla yeni bir Ky örneği oluşturun.

```js
import ky from 'ky';

// https://my-site.com üzerinde

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Tip: `object`

### ky.stop

Bir `Symbol` olup, bir `beforeRetry` hook'u tarafından döndürülerek tekrar denemeyi durdurabilir. Bu, kalan `beforeRetry` hook'larını da kısa devre yapar.

Not: Bu sembolün döndürülmesi, Ky'ın işlemi iptal etmesine ve `undefined` bir yanıtla dönmesine neden olur. Yanıtın herhangi bir özelliğine erişmeden önce bir yanıt olup olmadığını kontrol ettiğinizden emin olun veya [opsiyonel zincirleme](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining) kullanın. Ayrıca, .json() veya .text() gibi body metotlarıyla uyumlu değildir, çünkü ayrıştırılacak bir yanıt yoktur. Genel olarak, bu sembolü döndürmek yerine hata fırlatmanızı öneririz, çünkü bu Ky'ın işlemi iptal edip ardından hata fırlatmasına neden olur ve bu sınırlamaları önler.

`ky.stop` için geçerli bir kullanım durumu, döndürülen verinin önemli olmadığı yan etkiler için yapılan isteklerde tekrar denemeleri önlemektir. Örneğin, istemci etkinliğini sunucuya kaydetmek.

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
```js
// Dikkat: Eğer `ky.stop` döndürülürse, response `undefined` olacaktır.
const response = await ky.post('https://example.com', options);

// `.text()` veya diğer body metodlarının kullanılması desteklenmez.
const text = await ky('https://example.com', options).text();
```

### HTTPError

`instanceof` kontrolleri için dışa aktarılmıştır. Hata, [`Response` nesnesi](https://developer.mozilla.org/en-US/docs/Web/API/Response) içeren bir `response` özelliğine, [`Request` nesnesi](https://developer.mozilla.org/en-US/docs/Web/API/Request) içeren bir `request` özelliğine ve normalize edilmiş seçenekleri içeren bir `options` özelliğine sahiptir (ya `ky.create()` ile bir örnek oluştururken ya da doğrudan istek yapılırken `ky`'ye geçirilen).

Bazı hata türlerinin, örneğin ağ hatalarının, doğası gereği bir yanıt alınmadığı anlamına geldiğini unutmayın. Bu durumda, hata bir HTTPError örneği olmayacak ve bir `response` özelliği içermeyecektir.

Bir `HTTPError` oluştuğunda gerçek yanıtı okumanız gerekiyorsa, yanıt nesnesi üzerinde ilgili ayrıştırıcı metodunu çağırın. Örneğin:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** İsteğe bağlı bir [tip parametresi](https://www.typescriptlang.org/docs/handbook/2/generics.html) kabul eder, varsayılan olarak [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) olur ve bu değer `error.response.json()` dönüş tipine iletilir.

### TimeoutError

İstek zaman aşımına uğradığında atılan hatadır. [`Request` nesnesi](https://developer.mozilla.org/en-US/docs/Web/API/Request) içeren bir `request` özelliğine sahiptir.

## İpuçları

### Form verisi gönderme

Ky'da form verisi göndermek `fetch` ile aynıdır. Sadece [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) örneğini `body` seçeneğine iletin. `Content-Type` başlığı otomatik olarak `multipart/form-data` olarak ayarlanacaktır.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Verileri `application/x-www-form-urlencoded` formatında göndermek istiyorsanız, verileri [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) ile kodlamanız gerekir.

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Özel bir `Content-Type` ayarlama

Ky, her istek için gövde verilerine bağlı olarak uygun [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) başlığını otomatik olarak ayarlar. Ancak, bazı API'lar `application/x-amz-json-1.1` gibi özel, standart dışı içerik tipleri gerektirir. `headers` seçeneğini kullanarak içerik tipini manuel olarak geçersiz kılabilirsiniz.

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

### İptal Etme

Fetch (ve dolayısıyla Ky), isteğin iptalini yerleşik olarak [`AbortController` API'si](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) ile destekler. [Daha fazla oku.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Örnek:

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

## SSS

#### Bunu Node.js'te nasıl kullanırım?

Node.js 18 ve sonrası `fetch`'i yerleşik olarak destekler, bu nedenle paketi doğrudan kullanabilirsiniz.

#### Bunu sunucu tarafı render (SSR) kullanan bir web uygulamasında (React, Vue.js vb.) nasıl kullanırım?

Yukarıdakiyle aynıdır.

#### Bunu kullanan bir tarayıcı kütüphanesini nasıl test ederim?

Mocha gibi tarayıcıda çalışabilen bir test koşucu kullanın veya [AVA](https://avajs.dev) ile `ky-universal` kullanın. [Daha fazla oku.](https://github.com/sindresorhus/ky-universal#faq)

#### Bunu Webpack gibi bir paketleyici olmadan nasıl kullanabilirim?

Kodunuzun bir JavaScript modülü (ESM) olarak çalıştığından emin olun, örneğin HTML belgenizde `<script type="module">` etiketi kullanarak. Böylece Ky, o modül tarafından bir paketleyici veya başka araçlar olmadan doğrudan içe aktarılabilir.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### [`got`](https://github.com/sindresorhus/got)'tan farkı nedir?

Cevabı [burada](https://twitter.com/sindresorhus/status/1037406558945042432) bulabilirsiniz. Got, Ky ile aynı kişiler tarafından geliştirilmektedir.

#### [`axios`](https://github.com/axios/axios)'tan farkı nedir?

Cevabı [burada](https://twitter.com/sindresorhus/status/1037763588826398720) bulabilirsiniz.

#### [`r2`](https://github.com/mikeal/r2)'dan farkı nedir?

Cevabı [#10](https://github.com/sindresorhus/ky/issues/10) numaralı konuda bulabilirsiniz.

#### `ky` ne anlama geliyor?

Sadece rastgele aldığım kısa bir npm paket adı. Ancak Japonca'da bir anlamı var:

> Metinle yazılabilir bir argo olan KY, 空気読めない (kuuki yomenai) ifadesinin kısaltmasıdır ve kelime anlamıyla "havayı okuyamamak" demektir. İma edilen anlamı kaçıran birine söylenir.

## Tarayıcı desteği

Chrome, Firefox ve Safari'nin en son sürümü.

## Node.js desteği

Node.js 18 ve sonrası.

## İlgili

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Fetch ile çalışmak için kullanışlı yardımcılar
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Nesnelerin istek ve yanıtlarında harf durumlarını değiştirmek için Ky kancaları

## Bakımcılar

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---