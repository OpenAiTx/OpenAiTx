<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky là một client HTTP nhỏ gọn và thanh lịch dựa trên [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky hướng tới [trình duyệt hiện đại](#browser-support), Node.js, Bun và Deno.

Nó chỉ là một gói nhỏ gọn, không có phụ thuộc nào.

## Lợi ích so với `fetch` thuần túy

- API đơn giản hơn
- Các phương thức rút gọn (`ky.post()`)
- Xử lý các mã trạng thái không phải 2xx là lỗi (sau khi chuyển hướng)
- Tự động thử lại các yêu cầu thất bại
- Tùy chọn JSON
- Hỗ trợ timeout
- Tùy chọn tiền tố URL
- Các instance với mặc định tùy chỉnh
- Hooks
- Hỗ trợ TypeScript tốt (ví dụ: `.json()` hỗ trợ generics và mặc định là `unknown`, không phải `any`)

## Cài đặt

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Sử dụng

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Với `fetch` thuần túy, bạn sẽ làm như sau:

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

Nếu bạn đang sử dụng [Deno](https://github.com/denoland/deno), hãy import Ky từ một URL. Ví dụ, sử dụng CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` và `options` giống như [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), với các tùy chọn bổ sung (xem bên dưới).

Trả về một [`Đối tượng Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) với các [phương thức `Body`](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) được bổ sung để tiện sử dụng. Vì vậy, bạn có thể gọi trực tiếp `ky.get(input).json()` mà không cần phải await `Response` trước. Khi gọi như vậy, một header `Accept` phù hợp sẽ được tự động thiết lập tùy thuộc vào phương thức body được sử dụng. Không giống như các phương thức `Body` của `window.Fetch`, các phương thức này sẽ ném ra `HTTPError` nếu trạng thái phản hồi không nằm trong khoảng `200...299`. Ngoài ra, `.json()` sẽ trả về chuỗi rỗng nếu body rỗng hoặc trạng thái phản hồi là `204` thay vì ném lỗi parse do body rỗng.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Nhận một [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) tùy chọn, mặc định là [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), và được truyền vào kiểu trả về của `.json()`.

```ts
import ky from 'ky';

// user1 là unknown
const user1 = await ky('/api/users/1').json();
// user2 là User
const user2 = await ky<User>('/api/users/2').json();
// user3 là User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Thiết lập `options.method` thành tên phương thức và thực hiện yêu cầu.

⌨️ **TypeScript:** Nhận một type parameter tùy chọn khi sử dụng với phản hồi JSON (xem [`ky()`](#kyinput-options)).

#### input

Kiểu: `string` | `URL` | `Request`

Giống như [input của `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Khi sử dụng một instance [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) làm `input`, mọi tùy chọn thay đổi URL (như `prefixUrl`) sẽ bị bỏ qua.

#### options

Kiểu: `object`

Giống như [options của `fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), cộng thêm các tùy chọn bổ sung sau:

##### method

Kiểu: `string`\
Mặc định: `'get'`

Phương thức HTTP dùng để thực hiện yêu cầu.

Bên trong, các phương thức chuẩn (`GET`, `POST`, `PUT`, `PATCH`, `HEAD` và `DELETE`) sẽ được chuyển thành chữ hoa để tránh lỗi máy chủ do phân biệt chữ hoa/thường.

##### json

Kiểu: `object` và bất kỳ giá trị nào được [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify) chấp nhận

Lối tắt để gửi JSON. Sử dụng cái này thay cho tùy chọn `body`. Chấp nhận bất kỳ object thuần hoặc giá trị nào, sẽ được `JSON.stringify()` và gửi trong body với header chính xác được thiết lập.

##### searchParams

Kiểu: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Mặc định: `''`

Các tham số tìm kiếm để thêm vào URL yêu cầu. Thiết lập cái này sẽ ghi đè tất cả tham số tìm kiếm hiện có trong URL input.

Chấp nhận mọi giá trị được [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams) hỗ trợ.

##### prefixUrl

Kiểu: `string | URL`

Tiền tố để nối vào URL `input` khi thực hiện yêu cầu. Có thể là bất kỳ URL hợp lệ nào, tương đối hoặc tuyệt đối. Dấu gạch chéo `/` ở cuối là tùy chọn và sẽ được tự động thêm vào nếu cần khi nối với `input`. Chỉ có tác dụng khi `input` là chuỗi. Đối số `input` không được bắt đầu bằng dấu gạch chéo `/` khi sử dụng tùy chọn này.

Hữu ích khi dùng với [`ky.extend()`](#kyextenddefaultoptions) để tạo các instance Ky chuyên biệt cho từng mục đích.

```js
import ky from 'ky';

// Tại https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Lưu ý:
 - Sau khi `prefixUrl` và `input` được nối, kết quả sẽ được resolve dựa trên [base URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) của trang (nếu có).
 - Không được phép có dấu gạch chéo đầu trong `input` khi sử dụng tùy chọn này để đảm bảo tính nhất quán và tránh nhầm lẫn về cách xử lý URL `input`, vì `input` sẽ không tuân theo quy tắc resolve URL thông thường khi dùng `prefixUrl`, điều này làm thay đổi ý nghĩa của dấu gạch chéo đầu.

##### retry

Kiểu: `object | number`\
Mặc định:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`

Một đối tượng đại diện cho các trường `limit`, `methods`, `statusCodes`, `afterStatusCodes`, và `maxRetryAfter` dùng cho số lần thử lại tối đa, các phương thức được phép, các mã trạng thái được phép, các mã trạng thái được phép sử dụng thời gian [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), và thời gian [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) tối đa.

Nếu `retry` là một số, nó sẽ được sử dụng làm `limit` và các giá trị mặc định khác sẽ giữ nguyên.

Nếu phản hồi trả về mã trạng thái HTTP nằm trong `afterStatusCodes`, Ky sẽ chờ đến ngày, thời gian chờ, hoặc dấu thời gian được cung cấp trong header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) đã qua rồi mới thử lại yêu cầu. Nếu thiếu `Retry-After`, header không chuẩn [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) sẽ được dùng thay thế. Nếu mã trạng thái cung cấp không nằm trong danh sách, header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) sẽ bị bỏ qua.

Nếu `maxRetryAfter` được đặt là `undefined`, nó sẽ sử dụng `options.timeout`. Nếu giá trị header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) lớn hơn `maxRetryAfter`, nó sẽ dùng `maxRetryAfter`.

Tùy chọn `backoffLimit` là giới hạn trên của độ trễ cho mỗi lần thử lại tính bằng mili giây.
Để giới hạn độ trễ, ví dụ đặt `backoffLimit` là 1000.
Mặc định, độ trễ được tính bằng `0.3 * (2 ** (attemptCount - 1)) * 1000`. Độ trễ sẽ tăng theo hàm mũ.

Tùy chọn `delay` có thể được sử dụng để thay đổi cách tính độ trễ giữa các lần thử lại. Hàm này nhận một tham số là số lần thử, bắt đầu từ `1`.

Các lần thử lại sẽ không được kích hoạt sau một [timeout](#timeout).

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

Kiểu: `number | false`\
Mặc định: `10000`

Thời gian chờ tính bằng mili giây để nhận được phản hồi, bao gồm cả các lần thử lại. Không được lớn hơn 2147483647.
Nếu đặt là `false`, sẽ không có timeout.

##### hooks

Kiểu: `object<string, Function[]>`\
Mặc định: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks cho phép chỉnh sửa trong suốt vòng đời của yêu cầu. Các hàm hook có thể là async và được thực thi tuần tự.

###### hooks.beforeRequest

Kiểu: `Function[]`\
Mặc định: `[]`

Hook này cho phép bạn chỉnh sửa yêu cầu ngay trước khi gửi đi. Ky sẽ không thay đổi gì thêm sau đó. Hàm hook nhận các đối số là `request` và `options`. Ví dụ, bạn có thể chỉnh sửa `request.headers` tại đây.

Hook có thể trả về một [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) để thay thế yêu cầu gửi đi, hoặc trả về một [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) để hoàn toàn không thực hiện yêu cầu HTTP. Điều này có thể dùng để giả lập một yêu cầu, kiểm tra bộ nhớ đệm nội bộ, v.v. Một lưu ý **quan trọng** khi trả về request hoặc response từ hook này là các hook `beforeRequest` còn lại sẽ bị bỏ qua, nên bạn chỉ nên trả về chúng ở hook cuối cùng.

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

Kiểu: `Function[]`\
Mặc định: `[]`

Hook này cho phép bạn chỉnh sửa yêu cầu ngay trước khi thử lại. Ky sẽ không thay đổi gì thêm sau đó. Hàm hook nhận một đối tượng gồm request và options đã được chuẩn hóa, một instance lỗi, và số lần thử lại. Ví dụ, bạn có thể chỉnh sửa `request.headers` tại đây.

Nếu yêu cầu nhận được phản hồi, lỗi sẽ là kiểu `HTTPError` và đối tượng `Response` sẽ có tại `error.response`. Lưu ý rằng một số loại lỗi, như lỗi mạng, bản chất là không có phản hồi. Khi đó, lỗi sẽ không phải là một instance của `HTTPError`.

Bạn có thể ngăn Ky thử lại bằng cách ném ra một lỗi. Ky sẽ không xử lý gì thêm và lỗi sẽ được trả về phía gọi yêu cầu. Các hook `beforeRetry` còn lại sẽ không được gọi trong trường hợp này. Ngoài ra, bạn có thể trả về ký hiệu [`ky.stop`](#kystop) để làm điều tương tự mà không cần ném ra lỗi (có một số hạn chế, xem tài liệu về `ky.stop` để biết chi tiết).

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

Kiểu: `Function[]`\
Mặc định: `[]`

Hook này cho phép bạn chỉnh sửa `HTTPError` ngay trước khi nó được ném ra. Hàm hook nhận một đối số là `HTTPError` và nên trả về một instance của `HTTPError`.

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

Kiểu: `Function[]`\
Mặc định: `[]`

Hook này cho phép bạn đọc và tùy chọn chỉnh sửa phản hồi. Hàm hook nhận các đối số là request đã chuẩn hóa, options, và một bản sao của response. Giá trị trả về của hàm hook sẽ được Ky sử dụng làm đối tượng phản hồi nếu nó là instance của [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Bạn có thể làm gì đó với phản hồi, ví dụ, ghi log.
				log(response);

				// Hoặc trả về một instance `Response` để ghi đè phản hồi.
				return new Response('A different response', {status: 200});
			},

			// Hoặc thử lại với token mới khi gặp lỗi 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Lấy token mới
					const token = await ky('https://example.com/token').text();

					// Thử lại với token mới
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Kiểu: `boolean`\
Mặc định: `true`

Ném ra một `HTTPError` khi, sau khi theo dõi chuyển hướng, phản hồi có mã trạng thái không phải 2xx. Để cũng ném lỗi cho các chuyển hướng thay vì theo dõi chúng, hãy đặt tùy chọn [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) thành `'manual'`.

Đặt giá trị này là `false` có thể hữu ích nếu bạn kiểm tra sự tồn tại của tài nguyên và dự đoán các phản hồi lỗi.

Lưu ý: Nếu là `false`, các phản hồi lỗi được coi là thành công và yêu cầu sẽ không được thử lại.

##### onDownloadProgress

Kiểu: `Function`

Trình xử lý sự kiện tiến trình tải xuống.

Hàm này nhận các đối số sau:
- `progress` là một đối tượng với các thuộc tính:
- - `percent` là số nằm trong khoảng từ 0 đến 1 thể hiện phần trăm tiến trình.
- - `transferredBytes` là số byte đã được truyền đến thời điểm hiện tại.
- - `totalBytes` là tổng số byte sẽ được truyền. Đây là giá trị ước tính và có thể là 0 nếu không xác định được tổng kích thước.
- `chunk` là một instance của `Uint8Array` chứa dữ liệu đã gửi. Lưu ý: Lần gọi đầu tiên sẽ là rỗng.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Ví dụ kết quả:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Kiểu: `Function`
Trình xử lý sự kiện tiến trình tải lên.

Hàm nhận các tham số sau:
- `progress` là một đối tượng với các thuộc tính sau:
- - `percent` là một số nằm trong khoảng từ 0 đến 1 biểu thị phần trăm tiến trình.
- - `transferredBytes` là số byte đã được truyền cho đến thời điểm hiện tại.
- - `totalBytes` là tổng số byte sẽ được truyền. Đây là một giá trị ước tính và có thể là 0 nếu không xác định được tổng kích thước.
- `chunk` là một instance của `Uint8Array` chứa dữ liệu đã được gửi đi. Lưu ý: Ở lần gọi cuối cùng, nó sẽ rỗng.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Ví dụ kết quả xuất ra:
		// `0% - 0 of 1271 bytes`
		// `100% - 1271 of 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} of ${progress.totalBytes} bytes`);
	}
});
```

##### parseJson

Kiểu: `Function`\
Mặc định: `JSON.parse()`

Hàm phân tích JSON do người dùng định nghĩa.

Trường hợp sử dụng:
1. Phân tích JSON thông qua gói [`bourne`](https://github.com/hapijs/bourne) để bảo vệ khỏi ô nhiễm prototype.
2. Phân tích JSON với tùy chọn [`reviver` của `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Kiểu: `Function`\
Mặc định: `JSON.stringify()`

Hàm chuyển đổi JSON thành chuỗi do người dùng định nghĩa.

Trường hợp sử dụng:
1. Chuyển đổi JSON với hàm `replacer` tùy chỉnh.

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

Kiểu: `Function`\
Mặc định: `fetch`

Hàm `fetch` do người dùng định nghĩa.
Phải hoàn toàn tương thích với tiêu chuẩn [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Trường hợp sử dụng:
1. Sử dụng các triển khai `fetch` tùy chỉnh như [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Sử dụng hàm bọc `fetch` do một số framework cung cấp, sử dụng render phía server (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Tạo một instance `ky` mới với một số thiết lập mặc định được ghi đè bởi thiết lập của bạn.

Khác với `ky.create()`, `ky.extend()` kế thừa các thiết lập mặc định từ cha của nó.

Bạn có thể truyền headers dưới dạng một instance của `Headers` hoặc một đối tượng thông thường.

Bạn có thể xóa một header với `.extend()` bằng cách truyền header đó với giá trị là `undefined`.
Truyền `undefined` dưới dạng chuỗi chỉ xóa header nếu nó xuất phát từ một instance của `Headers`.

Tương tự, bạn cũng có thể xóa các entry `hooks` hiện có bằng cách mở rộng hook đó với giá trị `undefined` rõ ràng.

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

Bạn cũng có thể tham chiếu đến các thiết lập mặc định của cha bằng cách truyền một hàm cho `.extend()`.

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

Tạo một instance Ky mới với bộ thiết lập mặc định hoàn toàn mới.

```js
import ky from 'ky';

// Trên https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Kiểu: `object`

### ky.stop

Một `Symbol` có thể được trả về bởi hook `beforeRetry` để dừng việc thử lại. Điều này cũng sẽ bỏ qua các hook `beforeRetry` còn lại.

Lưu ý: Trả về symbol này sẽ khiến Ky hủy bỏ và trả về phản hồi là `undefined`. Hãy chắc chắn kiểm tra phản hồi trước khi truy cập bất kỳ thuộc tính nào trên đó hoặc sử dụng [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Nó cũng không tương thích với các phương thức trên body như `.json()` hoặc `.text()`, vì không có phản hồi để phân tích. Nói chung, chúng tôi khuyến nghị nên ném lỗi thay vì trả về symbol này, vì việc đó sẽ khiến Ky hủy bỏ và ném lỗi, tránh được những hạn chế này.

Một trường hợp hợp lệ để sử dụng `ky.stop` là để ngăn việc thử lại khi thực hiện các request có tác dụng phụ, nơi dữ liệu trả về không quan trọng. Ví dụ, ghi nhật ký hoạt động của client lên server.

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
// Lưu ý rằng response sẽ là `undefined` trong trường hợp `ky.stop` được trả về.
const response = await ky.post('https://example.com', options);

// Việc sử dụng `.text()` hoặc các phương thức body khác không được hỗ trợ.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Được xuất ra để kiểm tra với `instanceof`. Lỗi này có thuộc tính `response` với [đối tượng `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), thuộc tính `request` với [đối tượng `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), và thuộc tính `options` với các tùy chọn đã được chuẩn hóa (hoặc được truyền vào `ky` khi tạo instance với `ky.create()`, hoặc trực tiếp khi thực hiện request).

Lưu ý rằng một số loại lỗi, như lỗi mạng, vốn dĩ có nghĩa là không nhận được phản hồi. Trong trường hợp đó, lỗi sẽ không phải là một instance của HTTPError và sẽ không chứa thuộc tính `response`.

Nếu bạn cần đọc phản hồi thực tế khi xảy ra `HTTPError`, hãy gọi phương thức parser tương ứng trên đối tượng response. Ví dụ:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Chấp nhận một [tham số kiểu tùy chọn](https://www.typescriptlang.org/docs/handbook/2/generics.html), mặc định là [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), và được truyền đến kiểu trả về của `error.response.json()`.

### TimeoutError

Lỗi được ném ra khi yêu cầu vượt quá thời gian chờ. Nó có thuộc tính `request` với [đối tượng `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Mẹo

### Gửi dữ liệu biểu mẫu

Việc gửi dữ liệu biểu mẫu trong Ky giống hệt như với `fetch`. Chỉ cần truyền một instance của [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) vào tùy chọn `body`. Header `Content-Type` sẽ tự động được đặt là `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Nếu bạn muốn gửi dữ liệu ở định dạng `application/x-www-form-urlencoded`, bạn cần mã hóa dữ liệu bằng [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Thiết lập `Content-Type` tùy chỉnh

Ky tự động thiết lập header [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) phù hợp cho mỗi request dựa vào dữ liệu trong body của request. Tuy nhiên, một số API yêu cầu các kiểu content-type tùy chỉnh, không chuẩn, ví dụ như `application/x-amz-json-1.1`. Sử dụng tùy chọn `headers`, bạn có thể ghi đè kiểu content-type thủ công.

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

### Hủy yêu cầu

Fetch (và cả Ky) có hỗ trợ sẵn việc hủy yêu cầu thông qua [API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Đọc thêm.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Ví dụ:

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

## Câu hỏi thường gặp (FAQ)

#### Làm thế nào để sử dụng thư viện này trong Node.js?

Node.js 18 trở lên đã hỗ trợ `fetch` gốc, vì vậy bạn có thể sử dụng package này trực tiếp.

#### Làm thế nào để sử dụng với web app (React, Vue.js, v.v.) dùng server-side rendering (SSR)?

Giống như trên.

#### Làm sao để kiểm thử một thư viện trình duyệt sử dụng thư viện này?

Hoặc sử dụng một test runner chạy được trên trình duyệt, như Mocha, hoặc sử dụng [AVA](https://avajs.dev) với `ky-universal`. [Đọc thêm.](https://github.com/sindresorhus/ky-universal#faq)

#### Làm thế nào để sử dụng mà không cần bundler như Webpack?

Đảm bảo mã của bạn đang chạy như một module JavaScript (ESM), ví dụ bằng cách sử dụng thẻ `<script type="module">` trong tài liệu HTML của bạn. Sau đó Ky có thể được import trực tiếp bởi module đó mà không cần bundler hoặc công cụ khác.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Khác biệt gì so với [`got`](https://github.com/sindresorhus/got)

Xem câu trả lời của tôi [ở đây](https://twitter.com/sindresorhus/status/1037406558945042432). Got được duy trì bởi cùng nhóm phát triển với Ky.

#### Khác biệt gì so với [`axios`](https://github.com/axios/axios)?

Xem câu trả lời của tôi [ở đây](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Khác biệt gì so với [`r2`](https://github.com/mikeal/r2)?

Xem câu trả lời của tôi trong [#10](https://github.com/sindresorhus/ky/issues/10).

#### `ky` có nghĩa là gì?

Đó chỉ là một tên package npm ngắn, ngẫu nhiên mà tôi lấy được. Tuy nhiên, nó có nghĩa trong tiếng Nhật:

> Một dạng tiếng lóng có thể viết tắt, KY là viết tắt của 空気読めない (kuuki yomenai), dịch sát nghĩa là “không thể đọc không khí.” Đây là câu nói dành cho người không hiểu ý ngầm.

## Hỗ trợ trình duyệt

Phiên bản mới nhất của Chrome, Firefox và Safari.

## Hỗ trợ Node.js

Node.js 18 trở lên.

## Liên quan

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Các tiện ích hữu ích khi làm việc với Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Ky hooks để thay đổi kiểu chữ trên request và response của object

## Người bảo trì

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---