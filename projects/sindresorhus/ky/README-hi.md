<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky एक छोटा और आकर्षक HTTP क्लाइंट है जो [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) पर आधारित है

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky [आधुनिक ब्राउज़र](#browser-support), Node.js, Bun, और Deno को टार्गेट करता है।

यह केवल एक छोटा पैकेज है जिसमें कोई डिपेंडेंसी नहीं है।

## सामान्य `fetch` के मुकाबले फायदे

- सरल API
- मेथड शॉर्टकट्स (`ky.post()`)
- गैर-2xx स्टेटस कोड्स को (रिडायरेक्ट्स के बाद) एरर के रूप में ट्रीट करता है
- असफल अनुरोधों को पुनः प्रयास करता है (Retries)
- JSON विकल्प
- टाइमआउट सपोर्ट
- URL प्रीफिक्स विकल्प
- कस्टम डिफॉल्ट्स के साथ इंस्टेंस
- हुक्स
- TypeScript सुविधाएँ (जैसे `.json()` जनरिक्स को सपोर्ट करता है और डिफॉल्ट `unknown` होता है, `any` नहीं)

## इंस्टॉल करें

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## उपयोग

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

साधारण `fetch` के साथ यह ऐसा होगा:

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

यदि आप [Deno](https://github.com/denoland/deno) का उपयोग कर रहे हैं, तो Ky को किसी URL से इम्पोर्ट करें। उदाहरण के लिए, CDN का उपयोग करते समय:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` और `options` [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) के समान हैं, साथ ही अतिरिक्त `options` भी उपलब्ध हैं (नीचे देखें)।

यह एक [`Response` ऑब्जेक्ट](https://developer.mozilla.org/en-US/docs/Web/API/Response) लौटाता है जिसमें [`Body` मेथड्स](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) को सुविधा के लिए जोड़ा गया है। इसलिए आप, उदाहरण के लिए, `ky.get(input).json()` को सीधे कॉल कर सकते हैं, बिना पहले `Response` का इंतजार किए। जब ऐसे कॉल किया जाता है, तो उपयुक्त `Accept` हेडर सेट किया जाएगा, जो उपयोग किए गए बॉडी मेथड पर निर्भर करेगा। `window.Fetch` के `Body` मेथड्स के विपरीत, यदि रिस्पॉन्स स्टेटस `200...299` की रेंज में नहीं है तो ये एक `HTTPError` थ्रो करेंगे। साथ ही, अगर बॉडी खाली है या रिस्पॉन्स स्टेटस `204` है तो `.json()` एक खाली स्ट्रिंग लौटाएगा, खाली बॉडी के कारण पार्स एरर थ्रो करने के बजाय।

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** एक वैकल्पिक [टाइप पैरामीटर](https://www.typescriptlang.org/docs/handbook/2/generics.html) स्वीकार करता है, जो डिफॉल्ट रूप से [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) होता है, और यह `.json()` की रिटर्न टाइप में पास किया जाता है।

```ts
import ky from 'ky';

// user1 अज्ञात (unknown) है
const user1 = await ky('/api/users/1').json();
// user2 एक User है
const user2 = await ky<User>('/api/users/2').json();
// user3 एक User है
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

`options.method` को मेथड नाम पर सेट करता है और अनुरोध करता है।

⌨️ **TypeScript:** JSON रिस्पॉन्स के साथ उपयोग के लिए एक वैकल्पिक टाइप पैरामीटर स्वीकार करता है (देखें [`ky()`](#kyinput-options))।

#### input

प्रकार: `string` | `URL` | `Request`

[`fetch` इनपुट](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input) के समान।

जब [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) इंस्टेंस को `input` के रूप में उपयोग किया जाता है, तो कोई भी URL बदलने वाले विकल्प (जैसे कि `prefixUrl`) को अनदेखा कर दिया जाएगा।

#### options

प्रकार: `object`

[`fetch` विकल्प](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options) के समान, साथ ही निम्न अतिरिक्त विकल्प:

##### method

प्रकार: `string`\
डिफॉल्ट: `'get'`

अनुरोध करने के लिए उपयोग की जाने वाली HTTP मेथड।

आंतरिक रूप से, मानक मेथड्स (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` और `DELETE`) को अपरकेस किया जाता है ताकि केस सेंसिटिविटी के कारण सर्वर एरर से बचा जा सके।

##### json

प्रकार: `object` और कोई भी अन्य मान जिसे [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) स्वीकार करता है

JSON भेजने के लिए शॉर्टकट। इसे `body` विकल्प के बजाय उपयोग करें। कोई भी सामान्य ऑब्जेक्ट या मान स्वीकार करता है, जिसे `JSON.stringify()` किया जाएगा और सही हेडर के साथ बॉडी में भेजा जाएगा।

##### searchParams

प्रकार: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
डिफॉल्ट: `''`

अनुरोध URL में शामिल करने के लिए सर्च पैरामीटर्स। इसे सेट करने से इनपुट URL में मौजूद सभी सर्च पैरामीटर्स ओवरराइड हो जाएंगे।

कोई भी मान स्वीकार करता है जिसे [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) सपोर्ट करता है।

##### prefixUrl

प्रकार: `string | URL`

अनुरोध करते समय `input` URL से पहले जोड़ने के लिए एक प्रीफिक्स। यह कोई भी वैध URL हो सकता है, चाहे रिलेटिव हो या एब्सोल्यूट। एक ट्रेलिंग स्लैश `/` वैकल्पिक है और यदि आवश्यक हुआ तो स्वतः जोड़ दिया जाएगा, जब इसे `input` के साथ जोड़ा जाएगा। केवल तभी प्रभावी होता है जब `input` एक स्ट्रिंग हो। इस विकल्प का उपयोग करते समय `input` आर्ग्युमेंट स्लैश `/` से शुरू नहीं हो सकता।

[`ky.extend()`](#kyextenddefaultoptions) के साथ उपयोग करते समय यह खास Ky-इंस्टेंसेज़ बनाने में उपयोगी है।

```js
import ky from 'ky';

// https://example.com पर

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

नोट्स:
 - `prefixUrl` और `input` को जोड़ने के बाद, परिणाम पेज के [base URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) के अनुसार रेज़ॉल्व होता है (यदि कोई है)।
 - इस विकल्प का उपयोग करते समय, इनपुट में लीडिंग स्लैश की अनुमति नहीं है ताकि निरंतरता बनी रहे और भ्रम से बचा जा सके कि `input` URL कैसे हैंडल होगा, क्योंकि `prefixUrl` उपयोग होने पर यह सामान्य URL रेज़ॉल्यूशन नियमों का पालन नहीं करेगा, जिससे लीडिंग स्लैश का अर्थ बदल जाता है।

##### retry

प्रकार: `object | number`\
डिफॉल्ट:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`
`limit`, `methods`, `statusCodes`, `afterStatusCodes`, और `maxRetryAfter` फ़ील्ड का प्रतिनिधित्व करने वाली एक वस्तु, अधिकतम पुनः प्रयास गणना, अनुमत विधियाँ, अनुमत स्थिति कोड, [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) समय का उपयोग करने के लिए अनुमत स्थिति कोड, और अधिकतम [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) समय के लिए।

यदि `retry` एक संख्या है, तो इसे `limit` के रूप में उपयोग किया जाएगा और अन्य डिफ़ॉल्ट वैसे ही रहेंगे।

यदि प्रतिक्रिया में `afterStatusCodes` में शामिल कोई HTTP स्थिति कोड है, तो Ky [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) हेडर में दिए गए दिनांक, टाइमआउट, या टाइमस्टैम्प के बीतने तक अनुरोध को पुनः प्रयास करने के लिए प्रतीक्षा करेगा। यदि `Retry-After` अनुपस्थित है, तो उसके स्थान पर गैर-मानक [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) हेडर का उपयोग किया जाता है। यदि प्रदत्त स्थिति कोड सूची में नहीं है, तो [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) हेडर को अनदेखा कर दिया जाएगा।

यदि `maxRetryAfter` को `undefined` पर सेट किया गया है, तो यह `options.timeout` का उपयोग करेगा। यदि [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) हेडर `maxRetryAfter` से अधिक है, तो यह `maxRetryAfter` का उपयोग करेगा।

`backoffLimit` विकल्प प्रति पुनः प्रयास देरी की ऊपरी सीमा (मिलीसेकंड में) है।
देरी को क्लैंप करने के लिए, उदाहरण के लिए, `backoffLimit` को 1000 पर सेट करें।
डिफ़ॉल्ट रूप से, देरी की गणना `0.3 * (2 ** (attemptCount - 1)) * 1000` के साथ की जाती है। देरी घातीय रूप से बढ़ती है।

`delay` विकल्प का उपयोग यह बदलने के लिए किया जा सकता है कि पुनः प्रयासों के बीच की देरी कैसे गणना की जाती है। यह फ़ंक्शन एक पैरामीटर प्राप्त करता है, प्रयास गणना, जो `1` से शुरू होती है।

[timeout](#timeout) के बाद पुनः प्रयास ट्रिगर नहीं किए जाते हैं।

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

प्रकार: `number | false`\
डिफ़ॉल्ट: `10000`

प्रतिक्रिया प्राप्त करने के लिए मिलीसेकंड में टाइमआउट, जिसमें कोई भी पुनः प्रयास शामिल है। यह 2147483647 से अधिक नहीं हो सकता।
यदि `false` पर सेट किया गया है, तो कोई टाइमआउट नहीं होगा।

##### hooks

प्रकार: `object<string, Function[]>`\
डिफ़ॉल्ट: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks अनुरोध जीवनचक्र के दौरान संशोधन की अनुमति देते हैं। Hook फ़ंक्शन async हो सकते हैं और उन्हें क्रमिक रूप से चलाया जाता है।

###### hooks.beforeRequest

प्रकार: `Function[]`\
डिफ़ॉल्ट: `[]`

यह hook आपको अनुरोध भेजे जाने से ठीक पहले संशोधित करने की अनुमति देता है। इसके बाद Ky अनुरोध में कोई और बदलाव नहीं करेगा। Hook फ़ंक्शन को `request` और `options` तर्क के रूप में प्राप्त होते हैं। उदाहरण के लिए, आप यहां `request.headers` को संशोधित कर सकते हैं।

Hook एक [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) को लौटाकर आउटगोइंग अनुरोध को प्रतिस्थापित कर सकता है, या एक [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) को लौटाकर HTTP अनुरोध को पूरी तरह से टाल सकता है। इसका उपयोग अनुरोध को नकली (mock) करने, आंतरिक कैश की जांच, आदि के लिए किया जा सकता है। **महत्वपूर्ण** बात यह है कि यदि आप इस hook से कोई अनुरोध या प्रतिक्रिया लौटाते हैं, तो शेष सभी `beforeRequest` hooks छोड़ दिए जाएंगे, इसलिए आप केवल अंतिम hook से ही उन्हें लौटाना चाहेंगे।

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

प्रकार: `Function[]`\
डिफ़ॉल्ट: `[]`

यह hook आपको पुनः प्रयास से ठीक पहले अनुरोध को संशोधित करने की अनुमति देता है। इसके बाद Ky अनुरोध में कोई और बदलाव नहीं करेगा। Hook फ़ंक्शन को सामान्यीकृत अनुरोध और विकल्पों के साथ एक ऑब्जेक्ट, एक त्रुटि उदाहरण, और पुनः प्रयास गणना प्राप्त होती है। उदाहरण के लिए, आप यहां `request.headers` को संशोधित कर सकते हैं।

यदि अनुरोध को प्रतिक्रिया प्राप्त हुई, तो त्रुटि का प्रकार `HTTPError` होगा और `Response` ऑब्जेक्ट `error.response` में उपलब्ध होगा। ध्यान दें कि कुछ प्रकार की त्रुटियाँ, जैसे नेटवर्क त्रुटियाँ, स्वाभाविक रूप से प्रतिक्रिया न मिलने का अर्थ रखती हैं। ऐसे में, त्रुटि `HTTPError` का उदाहरण नहीं होगी।

आप त्रुटि फेंककर Ky को अनुरोध को पुनः प्रयास करने से रोक सकते हैं। Ky इसे किसी भी तरह से संभालेगा नहीं और त्रुटि अनुरोध आरंभकर्ता तक पहुँच जाएगी। शेष सभी `beforeRetry` hooks इस स्थिति में नहीं चलेंगे। वैकल्पिक रूप से, आप [`ky.stop`](#kystop) प्रतीक को लौटाकर भी यही कर सकते हैं, लेकिन बिना त्रुटि फैलाए (इसमें कुछ सीमाएँ हैं, विवरण के लिए `ky.stop` डॉक्स देखें)।

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

प्रकार: `Function[]`\
डिफ़ॉल्ट: `[]`

यह hook आपको `HTTPError` को फेंकने से ठीक पहले संशोधित करने की अनुमति देता है। Hook फ़ंक्शन को `HTTPError` तर्क के रूप में प्राप्त होता है और उसे `HTTPError` का एक उदाहरण लौटाना चाहिए।

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

प्रकार: `Function[]`\
डिफ़ॉल्ट: `[]`

यह hook आपको प्रतिक्रिया को पढ़ने और वैकल्पिक रूप से संशोधित करने की अनुमति देता है। Hook फ़ंक्शन को सामान्यीकृत अनुरोध, विकल्प, और प्रतिक्रिया की एक क्लोन प्राप्त होती है। यदि hook फ़ंक्शन का लौटाया गया मान [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) का उदाहरण है, तो Ky इसे प्रतिक्रिया ऑब्जेक्ट के रूप में उपयोग करेगा।

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// आप प्रतिक्रिया के साथ कुछ कर सकते हैं, जैसे लॉगिंग।
				log(response);

				// या प्रतिक्रिया को अधिलेखित करने के लिए `Response` उदाहरण लौटाएँ।
				return new Response('A different response', {status: 200});
			},

			// या 403 त्रुटि पर नया टोकन प्राप्त कर पुनः प्रयास करें
			async (request, options, response) => {
				if (response.status === 403) {
					// नया टोकन प्राप्त करें
					const token = await ky('https://example.com/token').text();

					// टोकन के साथ पुनः प्रयास करें
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

प्रकार: `boolean`\
डिफ़ॉल्ट: `true`

यदि, रीडायरेक्ट का पालन करने के बाद, प्रतिक्रिया में गैर-2xx स्थिति कोड है, तो `HTTPError` फेंके। रीडायरेक्ट के लिए भी त्रुटि फेंकने के लिए, बजाय उनका पालन करने के, [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) विकल्प को `'manual'` पर सेट करें।

इसे `false` पर सेट करना उपयोगी हो सकता है यदि आप संसाधन उपलब्धता की जांच कर रहे हैं और त्रुटि प्रतिक्रियाएँ अपेक्षित हैं।

नोट: यदि `false`, तो त्रुटि प्रतिक्रियाओं को सफल माना जाएगा और अनुरोध को पुनः प्रयास नहीं किया जाएगा।

##### onDownloadProgress

प्रकार: `Function`

डाउनलोड प्रगति ईवेंट हैंडलर।

यह फ़ंक्शन निम्न तर्क प्राप्त करता है:
- `progress` एक ऑब्जेक्ट है जिसमें ये गुण होते हैं:
- - `percent` 0 और 1 के बीच एक संख्या है, जो प्रगति प्रतिशत को दर्शाती है।
- - `transferredBytes` अब तक स्थानांतरित बाइट्स की संख्या है।
- - `totalBytes` स्थानांतरित की जाने वाली कुल बाइट्स की संख्या है। यह एक अनुमान है और यदि कुल आकार निर्धारित नहीं किया जा सकता है तो यह 0 हो सकता है।
- `chunk` `Uint8Array` का एक उदाहरण है जिसमें भेजा गया डेटा होता है। नोट: यह पहले कॉल के लिए खाली होता है।

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// उदाहरण आउटपुट:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

प्रकार: `Function`
अपलोड प्रगति इवेंट हैंडलर।

फ़ंक्शन को ये आर्गुमेंट्स मिलते हैं:
- `progress` एक ऑब्जेक्ट है जिसमें ये प्रॉपर्टीज़ होती हैं:
- - `percent` एक नंबर है जो 0 और 1 के बीच होता है, जो प्रगति प्रतिशत को दर्शाता है।
- - `transferredBytes` अब तक ट्रांसफर किए गए बाइट्स की संख्या है।
- - `totalBytes` कुल ट्रांसफर किए जाने वाले बाइट्स की संख्या है। यह एक अनुमान है और यदि कुल आकार निर्धारित नहीं किया जा सकता है तो यह 0 हो सकता है।
- `chunk` `Uint8Array` का एक इंस्टेंस है जिसमें भेजा गया डेटा होता है। नोट: अंतिम कॉल के लिए यह खाली होता है।

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// उदाहरण आउटपुट:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

प्रकार: `Function`\
डिफ़ॉल्ट: `JSON.parse()`

यूज़र-परिभाषित JSON-पार्सिंग फ़ंक्शन।

उपयोग के मामले:
1. [`bourne` पैकेज](https://github.com/hapijs/bourne) के माध्यम से JSON पार्स करें ताकि प्रोटोटाइप पॉल्यूशन से बचा जा सके।
2. [`JSON.parse()` के `reviver` विकल्प](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse) के साथ JSON पार्स करें।

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

प्रकार: `Function`\
डिफ़ॉल्ट: `JSON.stringify()`

यूज़र-परिभाषित JSON-स्ट्रिंगिफाइंग फ़ंक्शन।

उपयोग के मामले:
1. कस्टम `replacer` फ़ंक्शन के साथ JSON को स्ट्रिंगिफाई करें।

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

प्रकार: `Function`\
डिफ़ॉल्ट: `fetch`

यूज़र-परिभाषित `fetch` फ़ंक्शन।
यह पूरी तरह से [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) मानक के अनुकूल होना चाहिए।

उपयोग के मामले:
1. [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch) जैसी कस्टम `fetch` इम्प्लीमेंटेशन का उपयोग करें।
2. उन फ्रेमवर्क्स द्वारा उपलब्ध कराए गए `fetch` रैपर फ़ंक्शन का उपयोग करें जो सर्वर-साइड रेंडरिंग (SSR) का उपयोग करते हैं।

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

कुछ डिफ़ॉल्ट्स को अपनी पसंद के अनुसार ओवरराइड करके एक नया `ky` इंस्टेंस बनाएँ।

`ky.create()` के विपरीत, `ky.extend()` अपने पैरेंट से डिफ़ॉल्ट्स को इनहेरिट करता है।

आप हेडर्स को `Headers` इंस्टेंस या एक सामान्य ऑब्जेक्ट के रूप में पास कर सकते हैं।

आप `.extend()` के साथ किसी हेडर को `undefined` मान देकर हटा सकते हैं।
`undefined` को एक स्ट्रिंग के रूप में पास करने पर हेडर केवल तभी हटता है जब वह `Headers` इंस्टेंस से आता है।

इसी तरह, आप मौजूदा `hooks` एंट्रीज़ को स्पष्ट रूप से `undefined` के साथ एक्सटेंड करके हटा सकते हैं।

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

आप `.extend()` को फ़ंक्शन प्रदान करके पैरेंट डिफ़ॉल्ट्स का भी संदर्भ ले सकते हैं।

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

पूरी तरह से नए डिफ़ॉल्ट्स के साथ एक नया Ky इंस्टेंस बनाएँ।

```js
import ky from 'ky';

// On https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

प्रकार: `object`

### ky.stop

एक `Symbol` जिसे `beforeRetry` हुक द्वारा लौटाया जा सकता है ताकि रिट्राई को रोका जा सके। यह शेष बचे `beforeRetry` हुक्स को भी शॉर्ट सर्किट कर देगा।

नोट: इस सिंबल को लौटाने से Ky रद्द हो जाता है और एक `undefined` प्रतिक्रिया के साथ लौटता है। प्रतिक्रिया की किसी भी प्रॉपर्टी तक पहुँचने से पहले प्रतिक्रिया की जाँच करना या [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining) का उपयोग करना सुनिश्चित करें। यह बॉडी मेथड्स, जैसे `.json()` या `.text()` के साथ असंगत है, क्योंकि वहाँ कोई प्रतिक्रिया पार्स करने के लिए नहीं होती। सामान्यतः, हम इस सिंबल को लौटाने के बजाय एक त्रुटि फेंकने की सलाह देते हैं, क्योंकि इससे Ky रद्द हो जाता है और फिर त्रुटि फेंकता है, जिससे इन सीमाओं से बचा जा सकता है।

`ky.stop` का एक उपयुक्त उपयोग-वृत्तांत तब है जब साइड इफेक्ट्स के लिए अनुरोध किए जाते हैं, जहाँ रिटर्न डेटा महत्वपूर्ण नहीं होता। उदाहरण के लिए, क्लाइंट गतिविधि को सर्वर पर लॉग करना।

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
// ध्यान दें कि यदि `ky.stop` वापस किया गया है तो response `undefined` होगा।
const response = await ky.post('https://example.com', options);

// `.text()` या अन्य बॉडी मेथड्स का उपयोग समर्थित नहीं है।
const text = await ky('https://example.com', options).text();
```

### HTTPError

`instanceof` जांच के लिए एक्सपोज़ किया गया। इस त्रुटि में एक `response` प्रॉपर्टी होती है जिसमें [`Response` ऑब्जेक्ट](https://developer.mozilla.org/en-US/docs/Web/API/Response), एक `request` प्रॉपर्टी जिसमें [`Request` ऑब्जेक्ट](https://developer.mozilla.org/en-US/docs/Web/API/Request), और एक `options` प्रॉपर्टी होती है जिसमें सामान्यीकृत विकल्प होते हैं (या तो `ky.create()` के साथ इंस्टेंस बनाते समय या सीधे अनुरोध करते समय पास किए गए)।

ध्यान दें कि कुछ प्रकार की त्रुटियों, जैसे नेटवर्क त्रुटियाँ, स्वाभाविक रूप से इसका अर्थ है कि प्रतिक्रिया प्राप्त नहीं हुई। ऐसे मामलों में, त्रुटि HTTPError का इंस्टेंस नहीं होगी और उसमें `response` प्रॉपर्टी नहीं होगी।

यदि आपको HTTPError होने पर वास्तविक प्रतिक्रिया पढ़ने की आवश्यकता है, तो response ऑब्जेक्ट पर संबंधित पार्सर मेथड को कॉल करें। उदाहरण के लिए:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** एक वैकल्पिक [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) स्वीकार करता है, जो डिफ़ॉल्ट रूप से [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) होता है, और इसे `error.response.json()` के रिटर्न टाइप में पास किया जाता है।

### TimeoutError

वह त्रुटि जो अनुरोध के समय समाप्त होने पर फेंकी जाती है। इसमें [`Request` ऑब्जेक्ट](https://developer.mozilla.org/en-US/docs/Web/API/Request) के साथ एक `request` प्रॉपर्टी होती है।

## टिप्स

### फॉर्म डेटा भेजना

Ky में फॉर्म डेटा भेजना `fetch` के समान है। बस [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) की एक इंस्टेंस `body` विकल्प में पास करें। `Content-Type` हैडर स्वतः `multipart/form-data` पर सेट हो जाएगा।

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

यदि आप डेटा को `application/x-www-form-urlencoded` फॉर्मेट में भेजना चाहते हैं, तो आपको डेटा को [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams) के साथ एन्कोड करना होगा।

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### कस्टम `Content-Type` सेट करना

Ky प्रत्येक अनुरोध के लिए अनुरोध बॉडी के डेटा के आधार पर उपयुक्त [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) हैडर स्वतः सेट करता है। हालांकि, कुछ API को कस्टम, गैर-मानक कंटेंट टाइप की आवश्यकता होती है, जैसे कि `application/x-amz-json-1.1`। `headers` विकल्प का उपयोग करके, आप कंटेंट टाइप को मैन्युअली ओवरराइड कर सकते हैं।

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

### अनुरोध रद्द करना

Fetch (और इसलिए Ky) में [`AbortController` API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) के माध्यम से अनुरोध रद्द करने का इनबिल्ट समर्थन है। [और पढ़ें।](https://developers.google.com/web/updates/2017/09/abortable-fetch)

उदाहरण:

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

## अक्सर पूछे जाने वाले प्रश्न (FAQ)

#### मैं इसे Node.js में कैसे उपयोग करूं?

Node.js 18 और उसके बाद fetch को नेटिव रूप से सपोर्ट करता है, इसलिए आप इस पैकेज का सीधे उपयोग कर सकते हैं।

#### मैं इसे वेब ऐप (React, Vue.js, आदि) में कैसे उपयोग करूं जिसमें सर्वर-साइड रेंडरिंग (SSR) हो?

ऊपर जैसा ही।

#### मैं उस ब्राउज़र लाइब्रेरी का परीक्षण कैसे करूं जो इसका उपयोग करती है?

या तो Mocha जैसे ब्राउज़र में चलने वाले टेस्ट रनर का उपयोग करें, या [AVA](https://avajs.dev) को `ky-universal` के साथ उपयोग करें। [और पढ़ें।](https://github.com/sindresorhus/ky-universal#faq)

#### मैं इसे Webpack जैसे बंडलर के बिना कैसे उपयोग करूं?

सुनिश्चित करें कि आपका कोड एक JavaScript मॉड्यूल (ESM) के रूप में चल रहा है, उदाहरण के लिए अपने HTML डॉक्युमेंट में `<script type="module">` टैग का उपयोग करके। तब Ky को उस मॉड्यूल द्वारा बिना किसी बंडलर या अन्य टूल्स के सीधे आयात किया जा सकता है।

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### यह [`got`](https://github.com/sindresorhus/got) से कैसे अलग है?

मेरा उत्तर [यहाँ](https://twitter.com/sindresorhus/status/1037406558945042432) देखें। Got को Ky के समान ही लोग मेंटेन करते हैं।

#### यह [`axios`](https://github.com/axios/axios) से कैसे अलग है?

मेरा उत्तर [यहाँ](https://twitter.com/sindresorhus/status/1037763588826398720) देखें।

#### यह [`r2`](https://github.com/mikeal/r2) से कैसे अलग है?

[#10](https://github.com/sindresorhus/ky/issues/10) में मेरा उत्तर देखें।

#### `ky` का क्या अर्थ है?

यह सिर्फ एक रैंडम छोटा npm पैकेज नाम है जो मुझे मिल गया। हालांकि, इसका जापानी में एक अर्थ है:

> टेक्स्ट योग्य स्लैंग का एक रूप, KY का संक्षिप्त रूप है 空気読めない (kuuki yomenai), जिसका अर्थ है “हवा नहीं पढ़ सकता।” यह उस व्यक्ति के लिए उपयोग होता है जो निहित अर्थ नहीं समझता है।

## ब्राउज़र समर्थन

Chrome, Firefox, और Safari के नवीनतम संस्करण।

## Node.js समर्थन

Node.js 18 और उसके बाद के संस्करण।

## संबंधित

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Fetch के साथ काम करने के लिए उपयोगी यूटिलिटीज
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - ऑब्जेक्ट्स के अनुरोध और प्रतिक्रियाओं पर केस बदलने के लिए Ky hooks

## मेंटेनर

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---