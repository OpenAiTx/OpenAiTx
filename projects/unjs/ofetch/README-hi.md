# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

एक बेहतर fetch API। Node, ब्राउज़र और वर्कर्स पर काम करता है।

<details>
  <summary>स्पॉइलर</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 त्वरित प्रारंभ

इंस्टॉल करें:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

इंपोर्ट करें:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Node.js के साथ काम करता है

हम [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) का उपयोग Node.js का पता लगाने के लिए करते हैं
और स्वचालित रूप से [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native) का उपयोग करते हैं। यदि `globalThis.fetch` उपलब्ध है, तो वही उपयोग किया जाएगा। Node.js 17.5.0 की experimental native fetch API का लाभ उठाने के लिए [`--experimental-fetch` flag](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch) का उपयोग करें।

## ✔️ रिस्पॉन्स पार्सिंग

`ofetch` [destr](https://github.com/unjs/destr) का उपयोग करके स्मार्टली JSON और नेटिव वैल्यूज़ को पार्स करता है, और यदि पार्सिंग विफल होती है तो टेक्स्ट के रूप में लौटाता है।

```js
const { users } = await ofetch("/api/users");
```

बाइनरी कंटेंट टाइप्स के लिए, `ofetch` एक `Blob` ऑब्जेक्ट लौटाएगा।

आप वैकल्पिक रूप से `destr` के अलावा कोई दूसरा पार्सर दे सकते हैं, या `blob`, `arrayBuffer`, या `text` निर्दिष्ट कर सकते हैं ताकि बॉडी को संबंधित `FetchResponse` मेथड से पार्स किया जा सके।

```js
// JSON.parse का उपयोग करें
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// टेक्स्ट ज्यों का त्यों लौटाएं
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// रिस्पॉन्स का blob वर्शन प्राप्त करें
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ JSON बॉडी

यदि `body` विकल्प में कोई ऑब्जेक्ट या `.toJSON()` मेथड वाली क्लास पास की जाती है, तो `ofetch` उसे स्वतः स्ट्रिंगिफाई कर देता है।

`ofetch` पास किए गए ऑब्जेक्ट को कन्वर्ट करने के लिए `JSON.stringify()` का उपयोग करता है। जिन क्लासेस में `.toJSON()` मेथड नहीं है, उन्हें पहले से स्ट्रिंग वैल्यू में बदलना आवश्यक है, उसके बाद ही उन्हें `body` विकल्प में पास करें।

`PUT`, `PATCH`, और `POST` रिक्वेस्ट मेथड्स के लिए, जब कोई स्ट्रिंग या ऑब्जेक्ट बॉडी सेट होती है, तो `ofetch` डिफॉल्ट रूप से `content-type: "application/json"` और `accept: "application/json"` हेडर जोड़ता है (जिन्हें आप हमेशा ओवरराइड कर सकते हैं)।

इसके अलावा, `ofetch` बाइनरी रिस्पॉन्स को `Buffer`, `ReadableStream`, `Stream`, और [संगत बॉडी टाइप्स](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body) के साथ सपोर्ट करता है। स्ट्रीमिंग सपोर्ट के लिए `ofetch` स्वतः ही `duplex: "half"` विकल्प सेट कर देगा!

**उदाहरण:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ एरर हैंडलिंग

जब `response.ok` `false` होता है तो `ofetch` स्वतः ही एरर फेंकता है, जिसमें एक फ्रेंडली एरर मैसेज और संक्षिप्त स्टैक (इंटरनल्स को छुपाते हुए) होता है।

पार्स की गई एरर बॉडी `error.data` के साथ उपलब्ध होती है। आप `FetchError` टाइप का भी उपयोग कर सकते हैं।

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

एरर रिस्पॉन्स को पकड़ने के लिए:

```ts
```ts
await ofetch("/url").catch((error) => error.data);
```

स्थिति त्रुटि को पकड़ने को बायपास करने के लिए आप `ignoreResponseError` विकल्प सेट कर सकते हैं:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ ऑटो रिट्राई

`ofetch` स्वचालित रूप से अनुरोध को पुनः प्रयास करता है यदि कोई त्रुटि होती है और यदि प्रतिक्रिया स्थिति कोड `retryStatusCodes` सूची में शामिल है:

**रिट्राई स्थिति कोड्स:**

- `408` - अनुरोध का समय समाप्त
- `409` - टकराव
- `425` - बहुत जल्दी ([प्रयोगात्मक](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - बहुत अधिक अनुरोध
- `500` - आंतरिक सर्वर त्रुटि
- `502` - खराब गेटवे
- `503` - सेवा अनुपलब्ध
- `504` - गेटवे टाइमआउट

आप `retry` और `retryDelay` विकल्पों का उपयोग करके पुनः प्रयास की संख्या और उनके बीच की देरी निर्दिष्ट कर सकते हैं और साथ ही कस्टम कोड्स की एक एरे `retryStatusCodes` विकल्प द्वारा भेज सकते हैं।

`retry` के लिए डिफ़ॉल्ट मान `1` पुनः प्रयास है, सिवाय `POST`, `PUT`, `PATCH`, और `DELETE` विधियों के, जहाँ `ofetch` डिफ़ॉल्ट रूप से पुनः प्रयास नहीं करता ताकि दुष्प्रभाव से बचा जा सके। यदि आप `retry` के लिए एक कस्टम मान सेट करते हैं तो यह **हर अनुरोध के लिए हमेशा पुनः प्रयास करेगा**।

`retryDelay` के लिए डिफ़ॉल्ट मान `0` मिलीसेकंड है।

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // मिलीसेकंड में देरी
  retryStatusCodes: [ 404, 500 ], // पुनः प्रयास के लिए प्रतिक्रिया स्थिति कोड्स
});
```

## ✔️ टाइमआउट

आप मिलीसेकंड में `timeout` निर्दिष्ट कर सकते हैं ताकि एक निश्चित समय के बाद अनुरोध अपने आप रद्द हो जाए (डिफ़ॉल्ट रूप से अक्षम है)।

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // 3 सेकंड के बाद टाइमआउट
});
```

## ✔️ टाइप फ्रेंडली

प्रतिक्रिया को टाइप सहायता मिल सकती है:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// article.id के साथ ऑटो कंप्लीट काम करता है
```

## ✔️ `baseURL` जोड़ना

`baseURL` विकल्प का उपयोग करके, `ofetch` [ufo](https://github.com/unjs/ufo) का उपयोग करके बेसयूआरएल के लिए ट्रेलिंग/लीडिंग स्लैश और क्वेरी सर्च पैरामीटर्स को जोड़ता है:

```js
await ofetch("/config", { baseURL });
```

## ✔️ क्वेरी सर्च पैरामीटर्स जोड़ना

`query` विकल्प (या उपनाम के रूप में `params`) का उपयोग करके, `ofetch` अनुरोध में क्वेरी को सुरक्षित रखते हुए URL में क्वेरी सर्च पैरामीटर्स जोड़ता है [ufo](https://github.com/unjs/ufo) के माध्यम से:

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ इंटरसेप्टर्स

`ofetch` कॉल के लाइफसाइकिल इवेंट्स में हुक करने के लिए async इंटरसेप्टर्स प्रदान करना संभव है।

आप साझा इंटरसेप्टर्स सेट करने के लिए `ofetch.create` का उपयोग करना चाह सकते हैं।

### `onRequest({ request, options })`

`onRequest` जैसे ही `ofetch` कॉल किया जाता है, बुलाया जाता है, जिससे आप विकल्पों को संशोधित कर सकते हैं या साधारण लॉगिंग कर सकते हैं।

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // अनुरोध को लॉग करें
    console.log("[fetch request]", request, options);

    // क्वेरी सर्च पैरामीटर्स में `?t=1640125211170` जोड़ें
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

जब fetch अनुरोध विफल हो जाता है, तब `onRequestError` कॉल किया जाएगा।
```
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // त्रुटि लॉग करें
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` को `fetch` कॉल और बॉडी पार्स करने के बाद कॉल किया जाएगा।

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // रिस्पॉन्स लॉग करें
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` ठीक उसी तरह है जैसे `onResponse`, लेकिन यह तब कॉल किया जाएगा जब fetch होता है लेकिन `response.ok` `true` नहीं होता।

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // त्रुटि लॉग करें
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### इंटरसेप्टर्स की एक array पास करना

यदि आवश्यक हो, तो एक function की array भी पास करना संभव है, जिन्हें क्रमिक रूप से कॉल किया जाएगा।

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* कुछ करें */
    },
    () => {
      /* कुछ और करें */
    },
  ],
});
```

## ✔️ डिफ़ॉल्ट विकल्पों के साथ fetch बनाएं

यह यूटिलिटी तब उपयोगी होती है जब आपको कई fetch कॉल्स में सामान्य विकल्पों का उपयोग करना हो।

**नोट:** डिफ़ॉल्ट्स एक स्तर पर क्लोन किए जाएंगे और विरासत में लिए जाएंगे। जैसे `headers` जैसे नेस्टेड विकल्पों के बारे में सतर्क रहें।

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // यह ofetch('/test', { baseURL: '/api' }) के समान है
```

## 💡 हेडर्स जोड़ना

`headers` विकल्प का उपयोग करके, `ofetch` अनुरोध के डिफ़ॉल्ट हेडर्स के अलावा अतिरिक्त हेडर्स जोड़ता है:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 कच्चे रिस्पॉन्स तक पहुंच

यदि आपको कच्चे रिस्पॉन्स (जैसे कि हेडर्स आदि) तक पहुंचने की आवश्यकता है, तो आप `ofetch.raw` का उपयोग कर सकते हैं:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 नेटिव Fetch का उपयोग करना

शॉर्टकट के रूप में, आप `ofetch.native` का उपयोग कर सकते हैं, जो नेटिव `fetch` API प्रदान करता है

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ HTTP(S) एजेंट जोड़ना

Node.js (>= 18) वातावरणों में, आप अनुरोधों को इंटरसेप्ट करने और Proxy तथा स्वयं-हस्ताक्षरित प्रमाणपत्र जैसी सुविधाओं के समर्थन के लिए एक कस्टम डिस्पैचर प्रदान कर सकते हैं। यह सुविधा [undici](https://undici.nodejs.org/) द्वारा Node.js में अंतर्निहित रूप से सक्षम है। डिस्पैचर API के बारे में [यहाँ पढ़ें](https://undici.nodejs.org/#/docs/api/Dispatcher)।

कुछ उपलब्ध एजेंट्स:

- `ProxyAgent`: एक Proxy Agent क्लास जो Agent API को लागू करती है। यह सरल तरीके से एक प्रॉक्सी के माध्यम से कनेक्शन की अनुमति देती है। ([docs](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: एक mocked Agent क्लास जो Agent API को लागू करती है। यह undici के माध्यम से किए गए HTTP अनुरोधों को इंटरसेप्ट करने और mocked responses लौटाने की अनुमति देती है। ([docs](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent विभिन्न मूल (origins) के खिलाफ अनुरोध भेजने की अनुमति देता है। ([docs](https://undici.nodejs.org/#/docs/api/Agent))

**उदाहरण:** एक अनुरोध के लिए प्रॉक्सी एजेंट सेट करें:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**उदाहरण:** एक कस्टम fetch इंस्टेंस बनाएं जिसमें प्रॉक्सी सक्षम हो:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**उदाहरण:** सभी अनुरोधों के लिए प्रॉक्सी एजेंट सेट करें:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**उदाहरण:** स्वयं-हस्ताक्षरित प्रमाणपत्रों की अनुमति दें (अपने जोखिम पर उपयोग करें!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// नोट: इससे fetch MITM हमलों के खिलाफ असुरक्षित हो जाता है। अपने जोखिम पर उपयोग करें!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

पुराने Node.js संस्करण (<18) पर, आप `agent` का भी उपयोग कर सकते हैं:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### `keepAlive` समर्थन (केवल Node < 18 के लिए काम करता है)

`FETCH_KEEP_ALIVE` एनवायरनमेंट वेरिएबल को `true` पर सेट करने से एक HTTP/HTTPS एजेंट रजिस्टर्ड हो जाएगा जो सॉकेट्स को तब भी बनाए रखेगा जब कोई पेंडिंग अनुरोध न हो, ताकि भविष्य के अनुरोधों के लिए उनका पुन: उपयोग किया जा सके और हर बार नई TCP कनेक्शन स्थापित न करनी पड़े।

**नोट:** यह विकल्प संभवतः मेमोरी लीक का कारण बन सकता है। कृपया [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325) देखें।

## 📦 बंडलर नोट्स

- सभी टार्गेट्स Module और CommonJS फॉर्मेट में और नामित एक्सपोर्ट्स के साथ एक्सपोर्ट किए जाते हैं
- आधुनिक सिंटैक्स के लिए कोई भी एक्सपोर्ट ट्रांसपाइल नहीं किया गया है
  - आपको संभवतः ES5 समर्थन के लिए `ofetch`, `destr`, और `ufo` पैकेजेस को Babel के साथ ट्रांसपाइल करना होगा
- आपको पुराने ब्राउज़रों के समर्थन के लिए `fetch` ग्लोबल को पॉलीफिल करना होगा, जैसे कि [unfetch](https://github.com/developit/unfetch) का उपयोग करके

## ❓ अक्सर पूछे जाने वाले प्रश्न (FAQ)

**एक्सपोर्ट का नाम `ofetch` ही क्यों रखा गया है, `fetch` क्यों नहीं?**

`fetch` नाम का उपयोग करना भ्रमित कर सकता है क्योंकि API अलग है, लेकिन फिर भी यह fetch है, इसलिए सबसे निकटतम वैकल्पिक नाम का उपयोग किया गया है। हालांकि, आप `{ fetch }` को `ofetch` से इम्पोर्ट कर सकते हैं, जो Node.js के लिए ऑटो-पॉलीफिल है और अन्यथा नेटिव का उपयोग करता है।

**डिफॉल्ट एक्सपोर्ट क्यों नहीं है?**

डिफॉल्ट एक्सपोर्ट हमेशा CommonJS एक्सपोर्ट्स के साथ मिल सकते हैं, जिससे जोखिम रहता है।

इससे यह भी सुनिश्चित होता है कि हम बिना पैकेज तोड़े और अधिक यूटिल्स जोड़ सकते हैं और `ofetch` नाम के उपयोग को भी प्रोत्साहित कर सकते हैं।

**इसे ट्रांसपाइल क्यों नहीं किया गया?**

लाइब्रेरी को ट्रांसपाइल करने से हम वेब को पुराने कोड के साथ पीछे ले जाते हैं, जो कि अधिकांश उपयोगकर्ताओं के लिए अनावश्यक है।

यदि आपको पुराने उपयोगकर्ताओं का समर्थन करना है, तो आप अपनी build pipeline में लाइब्रेरी को ट्रांसपाइल कर सकते हैं।
```
## लाइसेंस

MIT. 💖 के साथ बनाया गया

<!-- बैज -->

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