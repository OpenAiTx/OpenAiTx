<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky เป็น HTTP client ขนาดเล็กและหรูหราที่สร้างขึ้นบนพื้นฐานของ [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky รองรับ [เบราว์เซอร์สมัยใหม่](#browser-support), Node.js, Bun และ Deno

เป็นแพ็กเกจขนาดเล็กมากโดยไม่มี dependencies ใด ๆ

## ข้อดีเหนือ `fetch` แบบปกติ

- API ที่เรียบง่ายกว่า
- ช็อตคัตสำหรับเมธอด (`ky.post()`)
- ปฏิบัติต่อ status code ที่ไม่ใช่ 2xx ว่าเป็น error (หลังจาก redirect แล้ว)
- มีการ retry คำขอที่ล้มเหลว
- ตัวเลือก JSON
- รองรับ timeout
- ตัวเลือก prefix ของ URL
- อินสแตนซ์ที่สามารถตั้งค่าดีฟอลต์เองได้
- Hooks
- คุณสมบัติเด่นของ TypeScript (เช่น `.json()` รองรับ generics และค่าเริ่มต้นเป็น `unknown` ไม่ใช่ `any`)

## การติดตั้ง

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## วิธีใช้งาน

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

ถ้าใช้ `fetch` แบบปกติ จะเป็นดังนี้:

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

หากคุณใช้ [Deno](https://github.com/denoland/deno), ให้นำเข้า Ky จาก URL ตัวอย่างเช่นใช้ CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` และ `options` จะเหมือนกับ [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch) พร้อมตัวเลือกเพิ่มเติม (ดูรายละเอียดด้านล่าง)

คืนค่าเป็น [`Response` object](https://developer.mozilla.org/en-US/docs/Web/API/Response) พร้อม [`Body` methods](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) ที่เพิ่มเข้ามาเพื่อความสะดวก ดังนั้นคุณสามารถเรียก `ky.get(input).json()` ได้โดยตรงโดยไม่ต้อง await `Response` ก่อน เมื่อเรียกใช้งานแบบนี้จะมีการตั้งค่า `Accept` header ที่เหมาะสมตาม body method ที่ใช้ แตกต่างจาก `Body` methods ของ `window.Fetch` ที่จะโยน `HTTPError` หาก response status ไม่อยู่ในช่วง `200...299` และ `.json()` จะคืนค่าเป็น string ว่างหาก body ว่างเปล่าหรือ response status เป็น `204` แทนที่จะโยน parse error เพราะ body ว่าง

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** รองรับ [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) แบบเลือกได้ ซึ่งค่าเริ่มต้นคือ [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) และจะส่งผ่านไปยัง return type ของ `.json()`

```ts
import ky from 'ky';

// user1 คือ unknown
const user1 = await ky('/api/users/1').json();
// user2 คือ User
const user2 = await ky<User>('/api/users/2').json();
// user3 คือ User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

ตั้งค่า `options.method` ให้เป็นชื่อเมธอดและทำการ request

⌨️ **TypeScript:** รองรับ type parameter แบบเลือกได้สำหรับใช้กับ JSON responses (ดูที่ [`ky()`](#kyinput-options))

#### input

ประเภท: `string` | `URL` | `Request`

เหมือนกับ [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input)

เมื่อใช้ [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) instance เป็น `input` ตัวเลือกที่เปลี่ยนแปลง URL (เช่น `prefixUrl`) จะถูกละเลย

#### options

ประเภท: `object`

เหมือนกับ [`fetch` options](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options) พร้อมตัวเลือกเพิ่มเติมดังต่อไปนี้:

##### method

ประเภท: `string`\
ค่าเริ่มต้น: `'get'`

HTTP method ที่ใช้ในการ request

ภายในจะทำการแปลงชื่อเมธอดมาตรฐาน (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` และ `DELETE`) ให้เป็นตัวพิมพ์ใหญ่เพื่อหลีกเลี่ยง error จาก server ที่เกิดจากความแตกต่างระหว่างตัวพิมพ์ใหญ่-เล็ก

##### json

ประเภท: `object` และค่าประเภทอื่น ๆ ที่ [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) รองรับ

ช็อตคัตสำหรับส่ง JSON ให้ใช้แทนตัวเลือก `body` สามารถรับ plain object หรือค่าใด ๆ ก็ได้ ซึ่งจะถูกแปลงเป็น `JSON.stringify()` และส่งไปใน body พร้อมตั้งค่า header ที่ถูกต้อง

##### searchParams

ประเภท: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
ค่าเริ่มต้น: `''`

search parameters ที่จะรวมใน request URL การตั้งค่านี้จะ override search parameters ที่มีอยู่ใน input URL ทั้งหมด

รองรับค่าทุกประเภทที่ [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) รองรับ

##### prefixUrl

ประเภท: `string | URL`

prefix ที่จะเติมไว้หน้าค่า `input` URL เมื่อทำการ request สามารถเป็น URL ใด ๆ ที่ถูกต้อง ไม่ว่าจะเป็น relative หรือ absolute จะมีหรือไม่มีเครื่องหมาย `/` ท้ายก็ได้ ซึ่งจะถูกเติมให้อัตโนมัติถ้าจำเป็นเมื่อรวมกับ `input` ใช้ได้เฉพาะเมื่อ `input` เป็น string อาร์กิวเมนต์ `input` ห้ามขึ้นต้นด้วย `/` เมื่อใช้ตัวเลือกนี้

เหมาะสำหรับใช้งานร่วมกับ [`ky.extend()`](#kyextenddefaultoptions) เพื่อสร้าง Ky instance เฉพาะทาง

```js
import ky from 'ky';

// บน https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

หมายเหตุ:
 - หลังจากที่ `prefixUrl` และ `input` รวมกันแล้ว ผลลัพธ์จะถูก resolve กับ [base URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) ของหน้า (ถ้ามี)
 - `input` ที่ขึ้นต้นด้วย `/` จะไม่อนุญาตเมื่อใช้ตัวเลือกนี้ เพื่อรักษาความสอดคล้องและหลีกเลี่ยงความสับสนเกี่ยวกับวิธีจัดการ URL เนื่องจาก `input` จะไม่ทำตามกฎการ resolve URL ปกติเมื่อใช้ `prefixUrl` ซึ่งจะเปลี่ยนความหมายของ `/` ข้างหน้า

##### retry

ประเภท: `object | number`\
ค่าเริ่มต้น:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

วัตถุที่แสดงถึงฟิลด์ `limit`, `methods`, `statusCodes`, `afterStatusCodes` และ `maxRetryAfter` สำหรับการกำหนดจำนวนครั้งสูงสุดที่สามารถรีทรายได้, เมธอดที่อนุญาต, รหัสสถานะที่อนุญาต, รหัสสถานะที่อนุญาตให้ใช้เวลา [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) และเวลา [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) สูงสุด

ถ้า `retry` เป็นตัวเลข จะถูกใช้เป็น `limit` และค่าดีฟอลต์อื่น ๆ จะยังคงเหมือนเดิม

หาก response ให้ HTTP status ที่อยู่ใน `afterStatusCodes` Ky จะรอจนกว่าจะถึงวันที่, timeout หรือ timestamp ที่ระบุใน header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) ก่อนที่จะรีทรายคำขอ หากไม่มี `Retry-After` จะใช้ header ที่ไม่เป็นมาตรฐาน [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) แทนเป็นทางเลือกสุดท้าย หากรหัสสถานะที่ได้รับไม่อยู่ในรายการนี้ header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) จะถูกละเว้น

ถ้า `maxRetryAfter` ถูกตั้งค่าเป็น `undefined` จะใช้ `options.timeout` หากค่าใน header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) มากกว่า `maxRetryAfter` จะใช้ค่า `maxRetryAfter`

ตัวเลือก `backoffLimit` คือขีดสูงสุดของระยะเวลาหน่วงต่อการรีทรายแต่ละครั้ง (หน่วยเป็นมิลลิวินาที)
หากต้องการจำกัดระยะเวลา เช่น ตั้งค่า `backoffLimit` เป็น 1000
โดยดีฟอลต์ ระยะเวลาจะคำนวณโดยสูตร `0.3 * (2 ** (attemptCount - 1)) * 1000` โดยระยะเวลาจะเพิ่มขึ้นแบบเอ็กซ์โปเนนเชียล

ตัวเลือก `delay` สามารถใช้เปลี่ยนวิธีคำนวณระยะเวลาระหว่างการรีทราย ฟังก์ชันจะได้รับพารามิเตอร์เดียวคือ attempt count ซึ่งเริ่มต้นที่ `1`

การรีทรายจะไม่ถูกทริกเกอร์หลังจากเกิด [timeout](#timeout)

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

ประเภท: `number | false`\
ค่าเริ่มต้น: `10000`

ระยะเวลา timeout (มิลลิวินาที) สำหรับการรับ response รวมการรีทรายทั้งหมด จะต้องไม่มากกว่า 2147483647
หากตั้งค่าเป็น `false` จะไม่มี timeout

##### hooks

ประเภท: `object<string, Function[]>`\
ค่าเริ่มต้น: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks อนุญาตให้ปรับเปลี่ยนระหว่างวงจรชีวิตของ request ฟังก์ชัน hook อาจเป็น async และจะถูกรันตามลำดับ

###### hooks.beforeRequest

ประเภท: `Function[]`\
ค่าเริ่มต้น: `[]`

hook นี้อนุญาตให้คุณปรับเปลี่ยน request ก่อนที่จะถูกส่งออก Ky จะไม่เปลี่ยนแปลง request หลังจากนี้อีก ฟังก์ชัน hook จะได้รับ `request` และ `options` เป็นอาร์กิวเมนต์ คุณสามารถแก้ไข `request.headers` ได้ที่นี่

hook นี้สามารถ return [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) เพื่อแทนที่ request ที่จะส่งออก หรือ return [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) เพื่อหลีกเลี่ยงการส่ง HTTP request ทั้งหมด ใช้สำหรับ mock request, ตรวจสอบ cache ภายใน ฯลฯ ข้อควรระวัง **สำคัญ** หากคืนค่า request หรือ response จาก hook นี้ hook `beforeRequest` ที่เหลือจะถูกข้าม ดังนั้นคุณควรคืนค่าจาก hook สุดท้ายเท่านั้น

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

ประเภท: `Function[]`\
ค่าเริ่มต้น: `[]`

hook นี้อนุญาตให้คุณปรับเปลี่ยน request ก่อนที่จะรีทราย Ky จะไม่เปลี่ยนแปลง request หลังจากนี้ ฟังก์ชัน hook จะได้รับอ็อบเจ็กต์ที่มี request และ options ที่ normalized แล้ว, error instance และ retry count คุณสามารถแก้ไข `request.headers` ได้ที่นี่

ถ้า request ได้รับ response, error จะเป็นชนิด `HTTPError` และ `Response` object จะอยู่ที่ `error.response` โปรดทราบว่า error บางประเภท เช่น network error จะไม่มี response ในกรณีนี้ error จะไม่ใช่ instance ของ `HTTPError`

คุณสามารถป้องกันไม่ให้ Ky รีทราย request ได้โดยการ throw error Ky จะไม่จัดการ error นี้และ error จะถูกส่งต่อไปยัง initiator ของ request hook `beforeRetry` ที่เหลือจะไม่ถูกเรียกในกรณีนี้ หรือคุณสามารถ return สัญลักษณ์ [`ky.stop`](#kystop) เพื่อให้เกิดผลเดียวกันแต่ไม่ propagate error (มีข้อจำกัดบางประการ ดูรายละเอียดในเอกสาร `ky.stop`)

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

ประเภท: `Function[]`\
ค่าเริ่มต้น: `[]`

hook นี้อนุญาตให้คุณปรับเปลี่ยน `HTTPError` ก่อนที่จะถูก throw ฟังก์ชัน hook จะได้รับ `HTTPError` เป็นอาร์กิวเมนต์และควร return instance ของ `HTTPError`

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

ประเภท: `Function[]`\
ค่าเริ่มต้น: `[]`

hook นี้อนุญาตให้คุณอ่านและปรับเปลี่ยน response ได้ ฟังก์ชัน hook จะได้รับ request และ options ที่ normalized แล้ว และ clone ของ response เป็นอาร์กิวเมนต์ ค่าที่ return จากฟังก์ชัน hook จะถูกใช้โดย Ky เป็น response object หากเป็น instance ของ [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response)

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// คุณสามารถทำอะไรบางอย่างกับ response เช่น logging
				log(response);

				// หรือ return instance ของ `Response` เพื่อแทนที่ response
				return new Response('A different response', {status: 200});
			},

			// หรือรีทรายด้วย token ใหม่เมื่อพบ error 403
			async (request, options, response) => {
				if (response.status === 403) {
					// ขอ token ใหม่
					const token = await ky('https://example.com/token').text();

					// รีทรายด้วย token ใหม่
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

ประเภท: `boolean`\
ค่าเริ่มต้น: `true`

throw `HTTPError` เมื่อ หลังจากตาม redirect แล้ว response มีสถานะที่ไม่ใช่ 2xx หากต้องการ throw สำหรับ redirect ด้วยแทนที่จะตาม redirect ให้ตั้งค่า [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) เป็น `'manual'`

ตั้งค่านี้เป็น `false` อาจมีประโยชน์เมื่อคุณต้องการตรวจสอบความพร้อมใช้งานของ resource และคาดหวัง error response

หมายเหตุ: ถ้า `false` response ที่เป็น error จะถือว่าสำเร็จ และ request จะไม่ถูกรีทราย

##### onDownloadProgress

ประเภท: `Function`

ตัวจัดการ event ความคืบหน้าในการดาวน์โหลด

ฟังก์ชันจะได้รับอาร์กิวเมนต์ดังนี้:
- `progress` เป็นอ็อบเจ็กต์ที่มี property เหล่านี้:
- - `percent` เป็นตัวเลขระหว่าง 0 ถึง 1 แสดงเปอร์เซ็นต์ของความคืบหน้า
- - `transferredBytes` คือจำนวน byte ที่รับส่งไปแล้ว
- - `totalBytes` คือจำนวน byte ทั้งหมดที่จะถูกส่ง ซึ่งเป็นค่า estimate และอาจเป็น 0 ถ้าขนาดทั้งหมดไม่สามารถระบุได้
- `chunk` เป็น instance ของ `Uint8Array` ที่มีข้อมูลที่ถูกส่ง หมายเหตุ: จะว่างเปล่าสำหรับการเรียกครั้งแรก

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// ตัวอย่าง output:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

ประเภท: `Function`
ตัวจัดการเหตุการณ์แสดงความคืบหน้าการอัปโหลด

ฟังก์ชันนี้จะได้รับอาร์กิวเมนต์ดังต่อไปนี้:
- `progress` เป็นอ็อบเจ็กต์ที่มีพร็อพเพอร์ตี้ดังนี้:
- - `percent` เป็นตัวเลขระหว่าง 0 ถึง 1 แสดงเปอร์เซ็นต์ความคืบหน้า
- - `transferredBytes` คือจำนวนไบต์ที่ถ่ายโอนจนถึงตอนนี้
- - `totalBytes` คือจำนวนไบต์ทั้งหมดที่จะต้องถ่ายโอน ค่านี้เป็นการประมาณและอาจเป็น 0 หากไม่สามารถระบุขนาดทั้งหมดได้
- `chunk` เป็นอินสแตนซ์ของ `Uint8Array` ที่มีข้อมูลที่ถูกส่ง หมายเหตุ: จะว่างเปล่าในการเรียกครั้งสุดท้าย

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// ตัวอย่างผลลัพธ์:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

ชนิด: `Function`\
ค่าเริ่มต้น: `JSON.parse()`

ฟังก์ชันสำหรับแปลง JSON ที่ผู้ใช้กำหนดเอง

กรณีการใช้งาน:
1. แปลง JSON โดยใช้แพ็กเกจ [`bourne`](https://github.com/hapijs/bourne) เพื่อป้องกันการโจมตี prototype pollution
2. แปลง JSON โดยใช้ [`reviver` option ของ `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse)

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

ชนิด: `Function`\
ค่าเริ่มต้น: `JSON.stringify()`

ฟังก์ชันสำหรับแปลงข้อมูลเป็นสตริง JSON ที่ผู้ใช้กำหนดเอง

กรณีการใช้งาน:
1. แปลงข้อมูลเป็น JSON โดยใช้ฟังก์ชัน `replacer` ที่กำหนดเอง

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

ชนิด: `Function`\
ค่าเริ่มต้น: `fetch`

ฟังก์ชัน `fetch` ที่ผู้ใช้กำหนดเอง
ต้องสามารถใช้งานได้เข้ากันได้กับมาตรฐาน [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API) อย่างสมบูรณ์

กรณีการใช้งาน:
1. ใช้งาน `fetch` เวอร์ชันที่กำหนดเอง เช่น [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch)
2. ใช้ฟังก์ชัน wrapper ของ `fetch` ที่จัดเตรียมโดยเฟรมเวิร์กบางตัวที่ใช้ server-side rendering (SSR)

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

สร้างอินสแตนซ์ `ky` ใหม่โดยกำหนดค่าเริ่มต้นบางส่วนทับด้วยค่าของคุณเอง

แตกต่างจาก `ky.create()` ตรงที่ `ky.extend()` จะสืบทอดค่าเริ่มต้นจากอินสแตนซ์แม่

คุณสามารถส่งค่า header เป็น `Headers` instance หรืออ็อบเจ็กต์ธรรมดาก็ได้

คุณสามารถลบ header ออกได้โดยใช้ `.extend()` และส่งค่า header นั้นเป็น `undefined`
การส่ง `undefined` ในรูปแบบสตริงจะลบ header เฉพาะเมื่อ header นั้นมาจาก `Headers` instance เท่านั้น

ในทำนองเดียวกัน คุณสามารถลบรายการ `hooks` ที่มีอยู่ได้โดยการขยาย hook ด้วยค่า `undefined` โดยตรง

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

คุณยังสามารถอ้างอิงค่าเริ่มต้นของอินสแตนซ์แม่โดยส่งฟังก์ชันให้กับ `.extend()`

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

สร้างอินสแตนซ์ Ky ใหม่พร้อมค่าเริ่มต้นทั้งหมดที่กำหนดใหม่

```js
import ky from 'ky';

// ที่ https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

ชนิด: `object`

### ky.stop

`Symbol` ที่สามารถคืนค่าจาก hook `beforeRetry` เพื่อหยุดการ retry ได้ จะเป็นการยุติ hook `beforeRetry` ที่เหลือในทันที

หมายเหตุ: การคืนค่าสัญลักษณ์นี้จะทำให้ Ky ยกเลิกและคืนค่าด้วย response เป็น `undefined` ควรตรวจสอบ response ก่อนเข้าถึงพร็อพเพอร์ตี้ใด ๆ หรือใช้ [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining) นอกจากนี้ยังไม่สามารถใช้งานร่วมกับเมธอด body เช่น `.json()` หรือ `.text()` ได้ เพราะไม่มี response ให้แปลง โดยทั่วไป เราแนะนำให้โยน error แทนการคืนค่าสัญลักษณ์นี้ เพื่อให้ Ky ยกเลิกและโยนข้อผิดพลาด ซึ่งจะหลีกเลี่ยงข้อจำกัดเหล่านี้

ตัวอย่างการใช้งาน `ky.stop` ที่เหมาะสมคือการป้องกันการ retry เมื่อทำ request ที่เกิดผลข้างเคียง ซึ่งข้อมูลที่ส่งกลับไม่สำคัญ เช่น การบันทึกกิจกรรมของลูกค้าไปยังเซิร์ฟเวอร์

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
// โปรดทราบว่า response จะเป็น `undefined` ในกรณีที่มีการคืนค่า `ky.stop`
const response = await ky.post('https://example.com', options);

// ไม่รองรับการใช้ `.text()` หรือเมธอด body อื่น ๆ
const text = await ky('https://example.com', options).text();
```

### HTTPError

เปิดให้ใช้งานสำหรับการเช็ค `instanceof` ข้อผิดพลาดนี้จะมีพร็อพเพอร์ตี้ `response` ที่เป็น [อ็อบเจกต์ Response](https://developer.mozilla.org/en-US/docs/Web/API/Response), พร็อพเพอร์ตี้ `request` ที่เป็น [อ็อบเจกต์ Request](https://developer.mozilla.org/en-US/docs/Web/API/Request) และพร็อพเพอร์ตี้ `options` ที่เป็นออปชันที่ถูก normalize (ไม่ว่าจะส่งผ่านไปที่ `ky` ตอนสร้าง instance ด้วย `ky.create()` หรือส่งตรงตอนร้องขอ)

โปรดทราบว่าข้อผิดพลาดบางประเภท เช่น ข้อผิดพลาดเครือข่าย โดยเนื้อแท้หมายความว่าไม่ได้รับ response ในกรณีนี้ error จะไม่ใช่ instance ของ HTTPError และจะไม่มีพร็อพเพอร์ตี้ `response`

หากคุณต้องการอ่าน response จริงเมื่อเกิด `HTTPError` ให้เรียกใช้เมธอด parser ที่เกี่ยวข้องบนอ็อบเจกต์ response ตัวอย่างเช่น:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** รับ [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) แบบออปชัน ซึ่งค่าเริ่มต้นคือ [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown) และจะถูกส่งผ่านไปยัง return type ของ `error.response.json()`

### TimeoutError

ข้อผิดพลาดที่ถูก throw เมื่อการร้องขอหมดเวลา (timeout) จะมีพร็อพเพอร์ตี้ `request` ที่เป็น [อ็อบเจกต์ Request](https://developer.mozilla.org/en-US/docs/Web/API/Request)

## เคล็ดลับ

### การส่งข้อมูลฟอร์ม

การส่งข้อมูลฟอร์มใน Ky เหมือนกับ `fetch` ทุกประการ เพียงแค่ส่ง [FormData](https://developer.mozilla.org/en-US/docs/Web/API/FormData) ให้กับออปชัน `body` เฮดเดอร์ `Content-Type` จะถูกตั้งค่าเป็น `multipart/form-data` โดยอัตโนมัติ

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

หากต้องการส่งข้อมูลในรูปแบบ `application/x-www-form-urlencoded` คุณต้องเข้ารหัสข้อมูลด้วย [URLSearchParams](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams)

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### การตั้งค่า `Content-Type` แบบกำหนดเอง

Ky จะตั้งค่า [Content-Type](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) ที่เหมาะสมโดยอัตโนติให้กับแต่ละคำร้องขอโดยอิงจากข้อมูลใน body อย่างไรก็ตาม บาง API ต้องการ content type แบบกำหนดเอง เช่น `application/x-amz-json-1.1` คุณสามารถ override content type ได้ด้วยออปชัน `headers`

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

### การยกเลิกคำร้องขอ (Cancellation)

Fetch (และ Ky) รองรับการยกเลิกคำร้องขอในตัวผ่าน [AbortController API](https://developer.mozilla.org/en-US/docs/Web/API/AbortController) [อ่านเพิ่มเติม](https://developers.google.com/web/updates/2017/09/abortable-fetch)

ตัวอย่าง:

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

## คำถามที่พบบ่อย (FAQ)

#### จะใช้สิ่งนี้ใน Node.js ได้อย่างไร?

Node.js 18 ขึ้นไป รองรับ `fetch` ในตัว คุณจึงใช้แพ็กเกจนี้ได้โดยตรง

#### จะใช้สิ่งนี้กับเว็บแอป (React, Vue.js, ฯลฯ) ที่ใช้ server-side rendering (SSR) ได้อย่างไร?

เหมือนกับข้างต้น

#### จะทดสอบไลบรารีเบราว์เซอร์ที่ใช้สิ่งนี้ได้อย่างไร?

ใช้ตัวรันทดสอบที่สามารถรันในเบราว์เซอร์ เช่น Mocha หรือใช้ [AVA](https://avajs.dev) ร่วมกับ `ky-universal` [อ่านเพิ่มเติม](https://github.com/sindresorhus/ky-universal#faq)

#### จะใช้สิ่งนี้โดยไม่ใช้ bundler อย่าง Webpack ได้อย่างไร?

ให้แน่ใจว่าโค้ดของคุณรันเป็น JavaScript module (ESM) ตัวอย่างเช่นโดยใช้ `<script type="module">` ในเอกสาร HTML จากนั้น Ky สามารถนำเข้าโดยตรงโดยไม่ต้องใช้ bundler หรือเครื่องมืออื่น

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### แตกต่างจาก [`got`](https://github.com/sindresorhus/got) อย่างไร

ดูคำตอบของผู้เขียน [ที่นี่](https://twitter.com/sindresorhus/status/1037406558945042432) Got พัฒนาโดยทีมเดียวกับ Ky

#### แตกต่างจาก [`axios`](https://github.com/axios/axios) อย่างไร?

ดูคำตอบของผู้เขียน [ที่นี่](https://twitter.com/sindresorhus/status/1037763588826398720)

#### แตกต่างจาก [`r2`](https://github.com/mikeal/r2) อย่างไร?

ดูคำตอบใน [#10](https://github.com/sindresorhus/ky/issues/10)

#### `ky` หมายถึงอะไร?

เป็นชื่อแพ็คเกจ npm สั้น ๆ ที่สุ่มได้มา อย่างไรก็ดี ในภาษาญี่ปุ่น มีความหมายว่า:

> เป็นภาษาวัยรุ่นแบบย่อ KY มาจาก 空気読めない (kuuki yomenai) แปลตรงตัวว่า “อ่านบรรยากาศไม่ออก” ใช้เรียกคนที่จับความนัยไม่ได้

## การรองรับเบราว์เซอร์

เวอร์ชันล่าสุดของ Chrome, Firefox และ Safari

## รองรับ Node.js

Node.js 18 ขึ้นไป

## ที่เกี่ยวข้อง

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - ยูทิลิตี้ที่เป็นประโยชน์สำหรับการทำงานกับ Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Ky hooks สำหรับปรับรูปแบบตัวพิมพ์ใน request/response ของอ็อบเจกต์

## ผู้ดูแล

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---