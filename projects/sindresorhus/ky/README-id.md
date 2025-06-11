<div align="center">
	<br>
	<div>
		<img width="600" height="600" src="https://raw.githubusercontent.com/sindresorhus/ky/main/media/logo.svg" alt="ky">
	</div>
	<br>
	<br>
	<br>
</div>

> Ky adalah klien HTTP yang kecil dan elegan berdasarkan [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch)

[![Coverage Status](https://codecov.io/gh/sindresorhus/ky/branch/main/graph/badge.svg)](https://codecov.io/gh/sindresorhus/ky)
[![](https://badgen.net/bundlephobia/minzip/ky)](https://bundlephobia.com/result?p=ky)

Ky ditujukan untuk [browser modern](#browser-support), Node.js, Bun, dan Deno.

Ini hanyalah paket kecil tanpa dependensi.

## Manfaat dibandingkan `fetch` biasa

- API lebih sederhana
- Pintasan metode (`ky.post()`)
- Menganggap status kode non-2xx sebagai error (setelah redirect)
- Mencoba ulang permintaan yang gagal
- Opsi JSON
- Dukungan timeout
- Opsi prefix URL
- Instance dengan default khusus
- Hooks
- Kenyamanan TypeScript (misal, `.json()` mendukung generic dan default ke `unknown`, bukan `any`)

## Instalasi

```sh
npm install ky
```

###### CDN

- [jsdelivr](https://cdn.jsdelivr.net/npm/ky/+esm)
- [unpkg](https://unpkg.com/ky)
- [esm.sh](https://esm.sh/ky)

## Penggunaan

```js
import ky from 'ky';

const json = await ky.post('https://example.com', {json: {foo: true}}).json();

console.log(json);
//=> {data: '🦄'}
```

Dengan `fetch` biasa, akan seperti berikut:

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

Jika Anda menggunakan [Deno](https://github.com/denoland/deno), impor Ky dari sebuah URL. Contoh, menggunakan CDN:

```js
import ky from 'https://esm.sh/ky';
```

## API

### ky(input, options?)

`input` dan `options` sama seperti [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch), dengan opsi tambahan tersedia (lihat di bawah).

Mengembalikan sebuah [`Response` object](https://developer.mozilla.org/en-US/docs/Web/API/Response) dengan [`Body` methods](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API/Using_Fetch#body) yang ditambahkan untuk kemudahan. Jadi Anda bisa, misalnya, memanggil `ky.get(input).json()` langsung tanpa harus menunggu `Response` terlebih dahulu. Saat dipanggil seperti itu, header `Accept` yang sesuai akan diatur tergantung pada metode body yang digunakan. Tidak seperti metode `Body` dari `window.Fetch`, metode ini akan melempar `HTTPError` jika status respons tidak dalam rentang `200...299`. Selain itu, `.json()` akan mengembalikan string kosong jika body kosong atau status respons `204` alih-alih melempar error parsing karena body kosong.

```js
import ky from 'ky';

const user = await ky('/api/user').json();

console.log(user);
```

⌨️ **TypeScript:** Menerima [type parameter](https://www.typescriptlang.org/docs/handbook/2/generics.html) opsional, yang default-nya [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), dan diteruskan ke tipe pengembalian `.json()`.

```ts
import ky from 'ky';

// user1 bertipe unknown
const user1 = await ky('/api/users/1').json();
// user2 bertipe User
const user2 = await ky<User>('/api/users/2').json();
// user3 bertipe User
const user3 = await ky('/api/users/3').json<User>();

console.log([user1, user2, user3]);
```

### ky.get(input, options?)
### ky.post(input, options?)
### ky.put(input, options?)
### ky.patch(input, options?)
### ky.head(input, options?)
### ky.delete(input, options?)

Mengatur `options.method` ke nama metode dan melakukan permintaan.

⌨️ **TypeScript:** Menerima parameter tipe opsional untuk digunakan dengan respons JSON (lihat [`ky()`](#kyinput-options)).

#### input

Tipe: `string` | `URL` | `Request`

Sama seperti [`fetch` input](https://developer.mozilla.org/en-US/docs/Web/API/Request/Request#input).

Saat menggunakan instance [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) sebagai `input`, semua opsi pengubahan URL (seperti `prefixUrl`) akan diabaikan.

#### options

Tipe: `object`

Sama seperti opsi [`fetch`](https://developer.mozilla.org/en-US/docs/Web/API/fetch#options), ditambah opsi tambahan berikut:

##### method

Tipe: `string`\
Default: `'get'`

Metode HTTP yang digunakan untuk melakukan permintaan.

Secara internal, metode standar (`GET`, `POST`, `PUT`, `PATCH`, `HEAD`, dan `DELETE`) akan diubah menjadi huruf besar untuk menghindari error server akibat case sensitive.

##### json

Tipe: `object` dan nilai lain yang diterima oleh [`JSON.stringify()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/stringify)

Pintasan untuk mengirim JSON. Gunakan ini daripada opsi `body`. Menerima objek biasa atau nilai apapun, yang akan di-`JSON.stringify()` dan dikirimkan dalam body dengan header yang benar diatur.

##### searchParams

Tipe: `string | object<string, string | number | boolean> | Array<Array<string | number | boolean>> | URLSearchParams`\
Default: `''`

Parameter pencarian yang akan disertakan dalam URL permintaan. Mengatur ini akan menimpa semua parameter pencarian yang ada di URL input.

Menerima nilai apapun yang didukung oleh [`URLSearchParams()`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams/URLSearchParams).

##### prefixUrl

Tipe: `string | URL`

Prefiks yang akan ditambahkan ke URL `input` saat melakukan permintaan. Bisa berupa URL valid, baik relatif maupun absolut. Tanda garis miring `/` di akhir opsional dan akan ditambahkan secara otomatis jika diperlukan, saat digabungkan dengan `input`. Hanya berlaku jika `input` berupa string. Argumen `input` tidak boleh diawali dengan garis miring `/` saat menggunakan opsi ini.

Berguna saat digunakan dengan [`ky.extend()`](#kyextenddefaultoptions) untuk membuat Ky-instance khusus sesuai kebutuhan.

```js
import ky from 'ky';

// Pada https://example.com

const response = await ky('unicorn', {prefixUrl: '/api'});
//=> 'https://example.com/api/unicorn'

const response2 = await ky('unicorn', {prefixUrl: 'https://cats.com'});
//=> 'https://cats.com/unicorn'
```

Catatan:
 - Setelah `prefixUrl` dan `input` digabungkan, hasilnya akan di-resolve terhadap [base URL](https://developer.mozilla.org/en-US/docs/Web/API/Node/baseURI) halaman (jika ada).
 - Garis miring awal pada `input` tidak diperbolehkan saat menggunakan opsi ini untuk menegakkan konsistensi dan menghindari kebingungan tentang bagaimana URL `input` diperlakukan, mengingat `input` tidak akan mengikuti aturan resolusi URL normal saat `prefixUrl` digunakan, yang mengubah arti garis miring awal.

##### retry

Tipe: `object | number`\
Default:
- `limit`: `2`
- `methods`: `get` `put` `head` `delete` `options` `trace`
- `statusCodes`: [`408`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/408) [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413) [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429) [`500`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/500) [`502`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/502) [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503) [`504`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/504)
- `afterStatusCodes`: [`413`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/413), [`429`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/429), [`503`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Status/503)
- `maxRetryAfter`: `undefined`
- `backoffLimit`: `undefined`
- `delay`: `attemptCount => 0.3 * (2 ** (attemptCount - 1)) * 1000`
Sebuah objek yang merepresentasikan field `limit`, `methods`, `statusCodes`, `afterStatusCodes`, dan `maxRetryAfter` untuk jumlah maksimum percobaan ulang, metode yang diizinkan, kode status yang diizinkan, kode status yang diizinkan untuk menggunakan waktu [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After), dan waktu maksimum [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After).

Jika `retry` adalah sebuah angka, maka akan digunakan sebagai `limit` dan nilai default lainnya tetap berlaku.

Jika respons memberikan status HTTP yang terdapat di `afterStatusCodes`, Ky akan menunggu sampai tanggal, timeout, atau timestamp yang diberikan pada header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) telah berlalu untuk mencoba ulang permintaan. Jika `Retry-After` tidak ada, header non-standar [`RateLimit-Reset`](https://www.ietf.org/archive/id/draft-polli-ratelimit-headers-05.html#section-3.3) akan digunakan sebagai cadangan. Jika kode status yang diberikan tidak ada dalam daftar, maka header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) akan diabaikan.

Jika `maxRetryAfter` disetel ke `undefined`, maka akan menggunakan `options.timeout`. Jika header [`Retry-After`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Retry-After) lebih besar dari `maxRetryAfter`, maka akan menggunakan `maxRetryAfter`.

Opsi `backoffLimit` adalah batas atas dari penundaan per percobaan ulang dalam milidetik.
Untuk membatasi penundaan, setel `backoffLimit` ke 1000, misalnya.
Secara default, penundaan dihitung dengan `0.3 * (2 ** (attemptCount - 1)) * 1000`. Penundaan meningkat secara eksponensial.

Opsi `delay` dapat digunakan untuk mengubah cara penundaan antara percobaan ulang dihitung. Fungsi menerima satu parameter, jumlah percobaan, dimulai dari `1`.

Percobaan ulang tidak akan dipicu setelah terjadi [timeout](#timeout).

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

Tipe: `number | false`\
Default: `10000`

Timeout dalam milidetik untuk mendapatkan respons, termasuk percobaan ulang apa pun. Tidak dapat lebih dari 2147483647.
Jika disetel ke `false`, maka tidak akan ada timeout.

##### hooks

Tipe: `object<string, Function[]>`\
Default: `{beforeRequest: [], beforeRetry: [], afterResponse: []}`

Hooks memungkinkan modifikasi selama siklus hidup permintaan. Fungsi hook dapat bersifat async dan dijalankan secara berurutan.

###### hooks.beforeRequest

Tipe: `Function[]`\
Default: `[]`

Hook ini memungkinkan Anda memodifikasi permintaan tepat sebelum dikirim. Ky tidak akan melakukan perubahan lebih lanjut pada permintaan setelah ini. Fungsi hook menerima `request` dan `options` sebagai argumen. Anda dapat, misalnya, memodifikasi `request.headers` di sini.

Hook dapat mengembalikan sebuah [`Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request) untuk menggantikan permintaan yang akan dikirim, atau mengembalikan sebuah [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response) untuk sepenuhnya menghindari membuat permintaan HTTP. Ini dapat digunakan untuk memalsukan permintaan, memeriksa cache internal, dll. Pertimbangan **penting** saat mengembalikan permintaan atau respons dari hook ini adalah bahwa hook `beforeRequest` yang tersisa akan dilewati, jadi Anda mungkin hanya ingin mengembalikannya dari hook terakhir.

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

Tipe: `Function[]`\
Default: `[]`

Hook ini memungkinkan Anda memodifikasi permintaan tepat sebelum percobaan ulang. Ky tidak akan melakukan perubahan lebih lanjut pada permintaan setelah ini. Fungsi hook menerima sebuah objek dengan permintaan dan opsi yang telah dinormalisasi, instance error, dan jumlah percobaan ulang. Anda dapat, misalnya, memodifikasi `request.headers` di sini.

Jika permintaan menerima respons, error akan bertipe `HTTPError` dan objek `Response` akan tersedia di `error.response`. Perlu diketahui bahwa beberapa jenis error, seperti error jaringan, secara inheren berarti respons tidak diterima. Dalam kasus tersebut, error tidak akan berupa instance `HTTPError`.

Anda dapat mencegah Ky mencoba ulang permintaan dengan melempar error. Ky tidak akan menangani dengan cara apa pun dan error akan diteruskan ke inisiator permintaan. Sisanya dari hook `beforeRetry` tidak akan dipanggil dalam kasus ini. Alternatifnya, Anda dapat mengembalikan simbol [`ky.stop`](#kystop) untuk melakukan hal yang sama namun tanpa meneruskan error (ini memiliki beberapa keterbatasan, lihat dokumentasi `ky.stop` untuk detailnya).

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

Tipe: `Function[]`\
Default: `[]`

Hook ini memungkinkan Anda memodifikasi `HTTPError` tepat sebelum dilemparkan. Fungsi hook menerima sebuah `HTTPError` sebagai argumen dan harus mengembalikan instance dari `HTTPError`.

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

Tipe: `Function[]`\
Default: `[]`

Hook ini memungkinkan Anda membaca dan secara opsional memodifikasi respons. Fungsi hook menerima permintaan yang telah dinormalisasi, opsi, dan salinan dari respons sebagai argumen. Nilai kembali dari fungsi hook akan digunakan oleh Ky sebagai objek respons jika itu merupakan instance dari [`Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response).

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	hooks: {
		afterResponse: [
			(_request, _options, response) => {
				// Anda dapat melakukan sesuatu dengan respons, misalnya, mencatat log.
				log(response);

				// Atau mengembalikan instance `Response` untuk menimpa respons.
				return new Response('A different response', {status: 200});
			},

			// Atau mencoba ulang dengan token baru pada error 403
			async (request, options, response) => {
				if (response.status === 403) {
					// Dapatkan token baru
					const token = await ky('https://example.com/token').text();

					// Coba ulang dengan token
					request.headers.set('Authorization', `token ${token}`);

					return ky(request);
				}
			}
		]
	}
});
```

##### throwHttpErrors

Tipe: `boolean`\
Default: `true`

Melempar `HTTPError` ketika, setelah mengikuti redirect, respons memiliki kode status non-2xx. Untuk juga melempar pada redirect daripada mengikutinya, atur opsi [`redirect`](https://developer.mozilla.org/en-US/docs/Web/API/WindowOrWorkerGlobalScope/fetch#Parameters) ke `'manual'`.

Menyetel ini ke `false` mungkin berguna jika Anda memeriksa ketersediaan sumber daya dan mengharapkan respons error.

Catatan: Jika `false`, respons error dianggap berhasil dan permintaan tidak akan dicoba ulang.

##### onDownloadProgress

Tipe: `Function`

Handler event progres unduhan.

Fungsi menerima argumen berikut:
- `progress` adalah objek dengan properti berikut:
- - `percent` adalah angka antara 0 dan 1 yang merepresentasikan persentase progres.
- - `transferredBytes` adalah jumlah byte yang telah ditransfer sejauh ini.
- - `totalBytes` adalah total byte yang akan ditransfer. Ini adalah estimasi dan mungkin 0 jika ukuran total tidak dapat ditentukan.
- `chunk` adalah instance dari `Uint8Array` yang berisi data yang telah dikirim. Catatan: Ini kosong pada pemanggilan pertama.

```js
import ky from 'ky';

const response = await ky('https://example.com', {
	onDownloadProgress: (progress, chunk) => {
		// Contoh output:
		// `0% - 0 dari 1271 bytes`
		// `100% - 1271 dari 1271 bytes`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} dari ${progress.totalBytes} bytes`);
	}
});
```

##### onUploadProgress

Tipe: `Function`
Penanganan event progress upload.

Fungsi ini menerima argumen berikut:
- `progress` adalah objek dengan properti berikut:
- - `percent` adalah angka antara 0 dan 1 yang merepresentasikan persentase progres.
- - `transferredBytes` adalah jumlah byte yang telah ditransfer sejauh ini.
- - `totalBytes` adalah total byte yang akan ditransfer. Ini merupakan estimasi dan bisa saja 0 jika ukuran total tidak dapat ditentukan.
- `chunk` adalah instance dari `Uint8Array` yang berisi data yang telah dikirimkan. Catatan: Kosong pada pemanggilan terakhir.

```js
import ky from 'ky';

const response = await ky.post('https://example.com/upload', {
	body: largeFile,
	onUploadProgress: (progress, chunk) => {
		// Contoh output:
		// `0% - 0 dari 1271 byte`
		// `100% - 1271 dari 1271 byte`
		console.log(`${progress.percent * 100}% - ${progress.transferredBytes} dari ${progress.totalBytes} byte`);
	}
});
```

##### parseJson

Tipe: `Function`\
Default: `JSON.parse()`

Fungsi parsing JSON yang didefinisikan oleh pengguna.

Contoh penggunaan:
1. Parsing JSON menggunakan paket [`bourne`](https://github.com/hapijs/bourne) untuk melindungi dari prototype pollution.
2. Parsing JSON dengan opsi [`reviver` dari `JSON.parse()`](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Global_Objects/JSON/parse).

```js
import ky from 'ky';
import bourne from '@hapijs/bourne';

const json = await ky('https://example.com', {
	parseJson: text => bourne(text)
}).json();
```

##### stringifyJson

Tipe: `Function`\
Default: `JSON.stringify()`

Fungsi untuk mengubah objek ke string JSON yang didefinisikan oleh pengguna.

Contoh penggunaan:
1. Melakukan stringify JSON dengan fungsi `replacer` kustom.

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

Tipe: `Function`\
Default: `fetch`

Fungsi `fetch` yang didefinisikan oleh pengguna.
Harus sepenuhnya kompatibel dengan standar [Fetch API](https://developer.mozilla.org/en-US/docs/Web/API/Fetch_API).

Contoh penggunaan:
1. Menggunakan implementasi `fetch` kustom seperti [`isomorphic-unfetch`](https://www.npmjs.com/package/isomorphic-unfetch).
2. Menggunakan fungsi pembungkus `fetch` yang disediakan oleh beberapa framework yang menggunakan server-side rendering (SSR).

```js
import ky from 'ky';
import fetch from 'isomorphic-unfetch';

const json = await ky('https://example.com', {fetch}).json();
```

### ky.extend(defaultOptions)

Membuat instance `ky` baru dengan beberapa default yang diganti dengan milik Anda sendiri.

Berbeda dengan `ky.create()`, `ky.extend()` mewarisi default dari induknya.

Anda dapat memberikan header sebagai instance `Headers` atau objek biasa.

Anda dapat menghapus header dengan `.extend()` dengan memberikan header tersebut dengan nilai `undefined`.
Memberikan `undefined` sebagai string hanya akan menghapus header jika berasal dari instance `Headers`.

Demikian juga, Anda dapat menghapus entri `hooks` yang sudah ada dengan melakukan extend hook tersebut secara eksplisit dengan `undefined`.

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

Anda juga dapat merujuk ke default induk dengan memberikan fungsi pada `.extend()`.

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

Membuat instance Ky baru dengan default yang benar-benar baru.

```js
import ky from 'ky';

// Pada https://my-site.com

const api = ky.create({prefixUrl: 'https://example.com/api'});

const response = await api.get('users/123');
//=> 'https://example.com/api/users/123'

const response = await api.get('/status', {prefixUrl: ''});
//=> 'https://my-site.com/status'
```

#### defaultOptions

Tipe: `object`

### ky.stop

Sebuah `Symbol` yang dapat dikembalikan oleh hook `beforeRetry` untuk menghentikan proses retry. Ini juga akan memotong sisa hook `beforeRetry` yang tersisa.

Catatan: Mengembalikan simbol ini membuat Ky membatalkan dan mengembalikan respons dengan nilai `undefined`. Pastikan untuk memeriksa respons sebelum mengakses properti apa pun di dalamnya atau gunakan [optional chaining](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Reference/Operators/Optional_chaining). Ini juga tidak kompatibel dengan metode body seperti `.json()` atau `.text()`, karena tidak ada respons untuk diparse. Secara umum, kami menyarankan untuk melempar error daripada mengembalikan simbol ini, karena itu akan membuat Ky membatalkan dan kemudian melempar error, yang menghindari keterbatasan ini.

Contoh penggunaan yang valid untuk `ky.stop` adalah untuk mencegah retry ketika melakukan permintaan yang bersifat side effect, di mana data yang dikembalikan tidak penting. Misalnya, mencatat aktivitas klien ke server.

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
// Perhatikan bahwa response akan bernilai `undefined` jika `ky.stop` dikembalikan.
const response = await ky.post('https://example.com', options);

// Penggunaan `.text()` atau metode body lainnya tidak didukung.
const text = await ky('https://example.com', options).text();
```

### HTTPError

Diekspos untuk pengecekan `instanceof`. Error ini memiliki properti `response` dengan [objek `Response`](https://developer.mozilla.org/en-US/docs/Web/API/Response), properti `request` dengan [objek `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request), dan properti `options` dengan opsi yang sudah dinormalisasi (baik yang diberikan ke `ky` saat membuat instance dengan `ky.create()` atau langsung saat melakukan request).

Perlu diketahui bahwa beberapa tipe error, seperti error jaringan, secara inheren berarti response tidak diterima. Dalam kasus tersebut, error tidak akan menjadi instance dari HTTPError dan tidak akan memiliki properti `response`.

Jika Anda perlu membaca response aktual ketika terjadi `HTTPError`, panggil metode parser yang sesuai pada objek response. Contohnya:

```js
try {
	await ky('https://example.com').json();
} catch (error) {
	if (error.name === 'HTTPError') {
		const errorJson = await error.response.json();
	}
}
```

⌨️ **TypeScript:** Menerima [parameter tipe](https://www.typescriptlang.org/docs/handbook/2/generics.html) opsional, yang secara default adalah [`unknown`](https://www.typescriptlang.org/docs/handbook/2/functions.html#unknown), dan diteruskan ke tipe pengembalian dari `error.response.json()`.

### TimeoutError

Error yang dilemparkan saat permintaan melebihi waktu tunggu. Memiliki properti `request` dengan [objek `Request`](https://developer.mozilla.org/en-US/docs/Web/API/Request).

## Tips

### Mengirim form data

Mengirim form data di Ky sama persis dengan `fetch`. Cukup berikan instance [`FormData`](https://developer.mozilla.org/en-US/docs/Web/API/FormData) ke opsi `body`. Header `Content-Type` akan otomatis disetel ke `multipart/form-data`.

```js
import ky from 'ky';

// `multipart/form-data`
const formData = new FormData();
formData.append('food', 'fries');
formData.append('drink', 'icetea');

const response = await ky.post(url, {body: formData});
```

Jika Anda ingin mengirim data dalam format `application/x-www-form-urlencoded`, Anda perlu mengenkode data tersebut dengan [`URLSearchParams`](https://developer.mozilla.org/en-US/docs/Web/API/URLSearchParams).

```js
import ky from 'ky';

// `application/x-www-form-urlencoded`
const searchParams = new URLSearchParams();
searchParams.set('food', 'fries');
searchParams.set('drink', 'icetea');

const response = await ky.post(url, {body: searchParams});
```

### Menyetel `Content-Type` kustom

Ky secara otomatis menyetel header [`Content-Type`](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Content-Type) yang sesuai untuk setiap permintaan berdasarkan data di body permintaan. Namun, beberapa API membutuhkan tipe konten kustom, seperti `application/x-amz-json-1.1`. Dengan opsi `headers`, Anda dapat menimpa tipe konten secara manual.

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

### Pembatalan

Fetch (dan juga Ky) memiliki dukungan bawaan untuk pembatalan permintaan melalui [API `AbortController`](https://developer.mozilla.org/en-US/docs/Web/API/AbortController). [Baca selengkapnya.](https://developers.google.com/web/updates/2017/09/abortable-fetch)

Contoh:

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
		console.log('Fetch dibatalkan');
	} else {
		console.error('Error Fetch:', error);
	}
}
```

## FAQ

#### Bagaimana cara menggunakan ini di Node.js?

Node.js 18 dan yang lebih baru sudah mendukung `fetch` secara native, jadi Anda bisa langsung menggunakan package ini.

#### Bagaimana cara menggunakan ini dengan web app (React, Vue.js, dll.) yang menggunakan server-side rendering (SSR)?

Sama seperti di atas.

#### Bagaimana cara menguji pustaka browser yang menggunakan ini?

Gunakan test runner yang bisa berjalan di browser, seperti Mocha, atau gunakan [AVA](https://avajs.dev) dengan `ky-universal`. [Baca selengkapnya.](https://github.com/sindresorhus/ky-universal#faq)

#### Bagaimana cara menggunakan ini tanpa bundler seperti Webpack?

Pastikan kode Anda berjalan sebagai modul JavaScript (ESM), misalnya dengan menggunakan tag `<script type="module">` di dokumen HTML Anda. Maka Ky bisa diimpor langsung oleh modul tersebut tanpa bundler atau alat lain.

```html
<script type="module">
import ky from 'https://unpkg.com/ky/distribution/index.js';

const json = await ky('https://jsonplaceholder.typicode.com/todos/1').json();

console.log(json.title);
//=> 'delectus aut autem'
</script>
```

#### Apa perbedaannya dengan [`got`](https://github.com/sindresorhus/got)

Lihat jawaban saya [di sini](https://twitter.com/sindresorhus/status/1037406558945042432). Got dikelola oleh orang yang sama dengan Ky.

#### Apa perbedaannya dengan [`axios`](https://github.com/axios/axios)?

Lihat jawaban saya [di sini](https://twitter.com/sindresorhus/status/1037763588826398720).

#### Apa perbedaannya dengan [`r2`](https://github.com/mikeal/r2)?

Lihat jawaban saya di [#10](https://github.com/sindresorhus/ky/issues/10).

#### Apa arti `ky`?

Ini hanya nama package npm pendek acak yang berhasil saya dapatkan. Namun, kata ini memang punya arti dalam bahasa Jepang:

> Sebuah bentuk slang yang bisa diketik, KY adalah singkatan dari 空気読めない (kuuki yomenai), yang secara harfiah berarti “tidak bisa membaca suasana.” Ini adalah frasa yang digunakan untuk orang yang tidak menangkap makna implisit.

## Dukungan browser

Versi terbaru Chrome, Firefox, dan Safari.

## Dukungan Node.js

Node.js 18 ke atas.

## Terkait

- [fetch-extras](https://github.com/sindresorhus/fetch-extras) - Utilitas berguna untuk bekerja dengan Fetch
- [ky-hooks-change-case](https://github.com/alice-health/ky-hooks-change-case) - Hook Ky untuk mengubah case pada permintaan dan respons objek

## Pemelihara

- [Sindre Sorhus](https://github.com/sindresorhus)
- [Seth Holladay](https://github.com/sholladay)
- [Szymon Marczak](https://github.com/szmarczak)
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---