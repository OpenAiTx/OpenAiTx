# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

Daha iyi bir fetch API'si. Node, tarayıcı ve worker'larda çalışır.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Hızlı Başlangıç

Kurulum:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

İçe Aktarma:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Node.js ile Çalışır

[Şartlı dışa aktarımlar](https://nodejs.org/api/packages.html#packages_conditional_exports) kullanarak Node.js'i algılıyoruz
ve otomatik olarak [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) kullanıyoruz. Eğer `globalThis.fetch` mevcutsa, bunun yerine o kullanılır. Node.js 17.5.0 deneyselliğinde yerleşik fetch API'sini kullanmak için [`--experimental-fetch` bayrağını](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch) kullanın.

## ✔️ Yanıtı Ayrıştırma

`ofetch`, JSON ve yerel değerleri akıllıca [destr](https://github.com/unjs/destr) ile ayrıştırır, ayrıştırılamazsa metne döner.

```js
const { users } = await ofetch("/api/users");
```

İkili (binary) içerik tipleri için, `ofetch` bunun yerine bir `Blob` nesnesi döndürür.

İsteğe bağlı olarak `destr` dışında farklı bir ayrıştırıcı sağlayabilir veya gövdenin `blob`, `arrayBuffer` ya da `text` ile ilgili `FetchResponse` yöntemi ile zorla ayrıştırılmasını belirtebilirsiniz.

```js
// JSON.parse kullan
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Metni olduğu gibi döndür
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Yanıtın blob versiyonunu al
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON Gövdesi

Bir nesne veya `.toJSON()` yöntemine sahip bir sınıf `body` seçeneğine aktarılırsa, `ofetch` bunu otomatik olarak string'e çevirir.

`ofetch`, aktarılan nesneyi dönüştürmek için `JSON.stringify()` kullanır. `.toJSON()` yöntemi olmayan sınıflar, `body` seçeneğine aktarılmadan önce önceden string'e dönüştürülmelidir.

`PUT`, `PATCH` ve `POST` istek yöntemlerinde, bir string veya nesne gövdesi ayarlandığında, `ofetch` varsayılan olarak `content-type: "application/json"` ve `accept: "application/json"` başlıklarını ekler (bunları her zaman geçersiz kılabilirsiniz).

Ayrıca, `ofetch` `Buffer`, `ReadableStream`, `Stream` ve [uyumlu gövde türleri](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body) ile ikili (binary) yanıtları destekler. `ofetch`, akış desteği için otomatik olarak `duplex: "half"` seçeneğini ayarlar!

**Örnek:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Hataları Yönetme

`ofetch`, `response.ok` yanlış olduğunda otomatik olarak dostça bir hata mesajı ve sadeleştirilmiş bir yığın (stack) ile hata fırlatır (iç detaylar gizlenir).

Ayrıştırılmış hata gövdesi `error.data` ile sunulur. Ayrıca `FetchError` türünü de kullanabilirsiniz.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Hata yanıtını yakalamak için:

```ts
await ofetch("/url").catch((error) => error.data);
```

Durum hatası yakalamayı atlamak için `ignoreResponseError` seçeneğini ayarlayabilirsiniz:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Otomatik Tekrar Deneme (Auto Retry)

`ofetch`, bir hata oluşursa ve yanıt durum kodu `retryStatusCodes` listesinde yer alıyorsa isteği otomatik olarak tekrar dener:

**Tekrar denenecek durum kodları:**

- `408` - İstek Zaman Aşımı
- `409` - Çakışma
- `425` - Çok Erken ([Deneysel](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Çok Fazla İstek
- `500` - Dahili Sunucu Hatası
- `502` - Hatalı Ağ Geçidi
- `503` - Hizmet Kullanılamıyor
- `504` - Ağ Geçidi Zaman Aşımı

`retry` ve `retryDelay` seçeneklerini kullanarak tekrar deneme sayısını ve denemeler arasındaki gecikmeyi belirleyebilir, ayrıca `retryStatusCodes` seçeneğiyle özel bir kod dizisi iletebilirsiniz.

`retry` için varsayılan değer `1`'dir, ancak `POST`, `PUT`, `PATCH` ve `DELETE` metotlarında `ofetch` varsayılan olarak tekrar deneme yapmaz, yan etkilerden kaçınmak için. Eğer `retry` için özel bir değer ayarlarsanız, bu durumda **tüm istekler için her zaman tekrar dener**.

`retryDelay` için varsayılan değer `0` ms'dir.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // tekrar denenecek yanıt durum kodları
});
```

## ✔️ Zaman Aşımı (Timeout)

Bir isteği otomatik olarak zaman aşımına uğratmak için milisaniye cinsinden `timeout` belirtebilirsiniz (varsayılan olarak devre dışıdır).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3 saniye sonra zaman aşımı
});
```

## ✔️ Tip Dostu (Type Friendly)

Yanıt tip desteğiyle kullanılabilir:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// article.id ile otomatik tamamlama çalışır
```

## ✔️ `baseURL` Ekleme

`baseURL` seçeneğini kullanarak, `ofetch` [ufo](https://github.com/unjs/ufo) ile baseURL'nin başındaki/sonundaki slash'ları ve sorgu parametrelerini önceden ekler:

```js
await ofetch("/config", { baseURL });
```

## ✔️ Sorgu Parametreleri Ekleme (Query Search Params)

`query` seçeneği (veya takma adı `params`) ile, `ofetch` sorgu parametrelerini isteğin URL'sine ekler ve [ufo](https://github.com/unjs/ufo) kullanarak sorguyu korur:

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Yakalayıcılar (Interceptors)

`ofetch` çağrısının yaşam döngüsü olaylarına bağlanmak için asenkron yakalayıcılar sağlanabilir.

Ortak yakalayıcıları ayarlamak için `ofetch.create` kullanmak isteyebilirsiniz.

### `onRequest({ request, options })`

`onRequest`, `ofetch` çağrılır çağrılmaz tetiklenir, seçenekleri değiştirmenize veya basit günlükleme işlemleri yapmanıza imkan tanır.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // İstek kaydı
    console.log("[fetch request]", request, options);

    // Sorgu parametrelerine `?t=1640125211170` ekle
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError`, fetch isteği başarısız olduğunda çağrılır.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Hata kaydı
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse`, `fetch` çağrısı ve gövdenin ayrıştırılmasından sonra çağrılır.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Yanıt kaydı
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError`, `onResponse` ile aynıdır ancak fetch gerçekleştiğinde ve `response.ok` değeri `true` olmadığında çağrılır.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Hata kaydı
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Dizi halinde interceptor geçmek

Gerekirse, sıralı olarak çağrılacak fonksiyonlardan oluşan bir dizi de geçebilirsiniz.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Bir şeyler yap */
    },
    () => {
      /* Başka bir şeyler yap */
    },
  ],
});
```

## ✔️ Varsayılan seçeneklerle fetch oluşturma

Bu yardımcı araç, birkaç fetch çağrısında ortak seçenekler kullanmanız gerekiyorsa faydalıdır.

**Not:** Varsayılanlar bir seviye klonlanır ve devralınır. `headers` gibi iç içe geçmiş seçeneklere dikkat edin.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // ofetch('/test', { baseURL: '/api' }) ile aynı
```

## 💡 Header eklemek

`headers` seçeneğini kullanarak, `ofetch` istek varsayılan başlıklarına ek başlıklar ekler:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Ham Yanıta Erişim

Ham yanıta erişmeniz gerekiyorsa (örneğin başlıklar için), `ofetch.raw` kullanabilirsiniz:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Yerel Fetch Kullanımı

Kısayol olarak, yerel `fetch` API'si sağlayan `ofetch.native` kullanabilirsiniz.

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ HTTP(S) Aracısı (Agent) Ekleme

Node.js (>= 18) ortamlarında, isteklere müdahale etmek ve Proxy ile kendinden imzalı sertifikalar gibi özellikleri desteklemek için özel bir dispatcher sağlayabilirsiniz. Bu özellik, Node.js'e yerleşik olarak gelen [undici](https://undici.nodejs.org/) tarafından etkinleştirilmiştir. Dispatcher API hakkında [daha fazla bilgi edinin](https://undici.nodejs.org/#/docs/api/Dispatcher).

Mevcut bazı ajanlar:

- `ProxyAgent`: Agent API’sini uygulayan bir Proxy Agent sınıfıdır. Bağlantının kolay bir şekilde bir proxy üzerinden yapılmasına olanak sağlar. ([dokümantasyon](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Agent API’sini uygulayan bir Mock (sahte) Agent sınıfıdır. undici üzerinden yapılan HTTP isteklerini yakalamaya ve bunun yerine sahte yanıtlar döndürmeye olanak tanır. ([dokümantasyon](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent, birden fazla farklı origin’e karşı istek göndermeye olanak tanır. ([dokümantasyon](https://undici.nodejs.org/#/docs/api/Agent))

**Örnek:** Bir istek için proxy agent ayarlama:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Örnek:** Proxy etkinleştirilmiş özel bir fetch örneği oluşturma:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Örnek:** Tüm istekler için proxy agent ayarlama:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Örnek:** Kendinden imzalı sertifikalara izin verme (KENDİ RİSKİNİZE KULLANIN!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Not: Bu, fetch’i MITM saldırılarına karşı güvensiz hale getirir. KENDİ RİSKİNİZE KULLANIN!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Daha eski Node.js sürümlerinde (<18), ayrıca `agent` kullanabilirsiniz:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` desteği (yalnızca Node < 18 için çalışır)

`FETCH_KEEP_ALIVE` ortam değişkenini `true` olarak ayarlayarak, istek olmasa bile soketleri açık tutan bir HTTP/HTTPS agent kaydedilir. Böylece gelecekteki istekler için TCP bağlantısı yeniden kurulmadan kullanılabilir.

**Not:** Bu seçenek potansiyel olarak bellek sızıntılarına neden olabilir. Lütfen [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325) kontrol edin.

## 📦 Paketleyici Notları

- Tüm hedefler, Modül ve CommonJS formatında ve adlandırılmış dışa aktarımlar ile dışa aktarılır
- Hiçbir dışa aktarma, modern sözdizimi nedeniyle transpile edilmemiştir
  - ES5 desteği için muhtemelen `ofetch`, `destr` ve `ufo` paketlerini Babel ile transpile etmeniz gerekir
- Eski tarayıcıları desteklemek için [unfetch](https://github.com/developit/unfetch) gibi bir çözümle `fetch` globalini polyfill etmeniz gerekir

## ❓ SSS

**Neden dışa aktarma ismi `fetch` değil de `ofetch`?**

`fetch` ile aynı ismin kullanılması kafa karıştırıcı olabilir çünkü API farklıdır, fakat yine de bir fetch olduğu için en yakın alternatifi kullandık. Yine de, `ofetch` üzerinden `{ fetch }` olarak içe aktarım yapabilirsiniz; bu, Node.js için otomatik polyfill sağlar ve diğer ortamlarda yereli kullanır.

**Neden varsayılan dışa aktarma yok?**

Varsayılan dışa aktarmalar, CommonJS dışa aktarmaları ile karışmaya her zaman açıktır.

Bu aynı zamanda, paketi bozmadan daha fazla yardımcı araç ekleyebileceğimizi ve ayrıca `ofetch` adının kullanılmasını teşvik eder.

**Neden transpile edilmiyor?**

Kütüphaneleri transpile ederek, gereksiz yere çoğu kullanıcı için eski kodu web’e taşımış oluruz.

Eski kullanıcıları desteklemeniz gerekiyorsa, bu kütüphaneyi derleme hattınızda isteğe bağlı olarak transpile edebilirsiniz.
```
## Lisans

MIT. 💖 ile yapıldı

<!-- Rozetler -->

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