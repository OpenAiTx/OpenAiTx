# ofetch

[![npm version][npm-version-src]][npm-version-href]
[![npm downloads][npm-downloads-src]][npm-downloads-href]
[![bundle][bundle-src]][bundle-href]
[![Codecov][codecov-src]][codecov-href]
[![License][license-src]][license-href]
[![JSDocs][jsdocs-src]][jsdocs-href]

API fetch yang lebih baik. Berfungsi di node, browser, dan workers.

<details>
  <summary>Spoiler</summary>
  <img src="https://media.giphy.com/media/Dn1QRA9hqMcoMz9zVZ/giphy.gif">
</details>

## 🚀 Mulai Cepat

Instalasi:

```bash
# npm
npm i ofetch

# yarn
yarn add ofetch
```

Impor:

```js
// ESM / Typescript
import { ofetch } from "ofetch";

// CommonJS
const { ofetch } = require("ofetch");
```

## ✔️ Berfungsi dengan Node.js

Kami menggunakan [conditional exports](https://nodejs.org/api/packages.html#packages_conditional_exports) untuk mendeteksi Node.js
dan secara otomatis menggunakan [unjs/node-fetch-native](https://github.com/unjs/node-fetch-native). Jika `globalThis.fetch` tersedia, maka itu yang akan digunakan. Untuk memanfaatkan Node.js 17.5.0 experimental native fetch API, gunakan [`--experimental-fetch` flag](https://nodejs.org/dist/latest-v17.x/docs/api/cli.html#--experimental-fetch).

## ✔️ Mem-parsing Respons

`ofetch` secara cerdas akan mem-parsing JSON dan nilai native menggunakan [destr](https://github.com/unjs/destr), dan akan kembali ke teks jika gagal melakukan parsing.

```js
const { users } = await ofetch("/api/users");
```

Untuk tipe konten biner, `ofetch` akan mengembalikan objek `Blob`.

Anda juga dapat menyediakan parser berbeda selain `destr`, atau menentukan `blob`, `arrayBuffer`, atau `text` untuk memaksa parsing body menggunakan metode `FetchResponse` yang sesuai.

```js
// Gunakan JSON.parse
await ofetch("/movie?lang=en", { parseResponse: JSON.parse });

// Kembalikan teks apa adanya
await ofetch("/movie?lang=en", { parseResponse: (txt) => txt });

// Dapatkan versi blob dari respons
await ofetch("/api/generate-image", { responseType: "blob" });
```

## ✔️ Body JSON

Jika sebuah objek atau kelas dengan metode `.toJSON()` diberikan ke opsi `body`, `ofetch` akan secara otomatis mengubahnya menjadi string.

`ofetch` menggunakan `JSON.stringify()` untuk mengonversi objek yang diberikan. Kelas tanpa metode `.toJSON()` harus diubah menjadi nilai string terlebih dahulu sebelum diberikan ke opsi `body`.

Untuk metode permintaan `PUT`, `PATCH`, dan `POST`, ketika body string atau objek diatur, `ofetch` menambahkan header default `content-type: "application/json"` dan `accept: "application/json"` (yang dapat Anda timpa).

Selain itu, `ofetch` mendukung respons biner dengan `Buffer`, `ReadableStream`, `Stream`, dan [tipe body yang kompatibel](https://developer.mozilla.org/en-US/docs/Web/API/fetch#body). `ofetch` akan secara otomatis mengatur opsi `duplex: "half"` untuk mendukung streaming!

**Contoh:**

```js
const { users } = await ofetch("/api/users", {
  method: "POST",
  body: { some: "json" },
});
```

## ✔️ Menangani Error

`ofetch` secara otomatis melempar error saat `response.ok` bernilai `false` dengan pesan error yang ramah dan stack yang ringkas (menyembunyikan bagian internal).

Body error yang sudah di-parsing tersedia di `error.data`. Anda juga dapat menggunakan tipe `FetchError`.

```ts
await ofetch("https://google.com/404");
// FetchError: [GET] "https://google/404": 404 Not Found
//     at async main (/project/playground.ts:4:3)
```

Untuk menangkap respons error:

```ts
await ofetch("/url").catch((error) => error.data);
```

Untuk melewati penangkapan error status, Anda dapat mengatur opsi `ignoreResponseError`:

```ts
await ofetch("/url", { ignoreResponseError: true });
```

## ✔️ Auto Retry

`ofetch` secara otomatis mencoba ulang permintaan jika terjadi error dan jika kode status respons termasuk dalam daftar `retryStatusCodes`:

**Retry status codes:**

- `408` - Request Timeout
- `409` - Conflict
- `425` - Too Early ([Eksperimental](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/Early-Data))
- `429` - Too Many Requests
- `500` - Internal Server Error
- `502` - Bad Gateway
- `503` - Service Unavailable
- `504` - Gateway Timeout

Anda dapat menentukan jumlah percobaan ulang dan jeda di antaranya menggunakan opsi `retry` dan `retryDelay`, serta memberikan array kode kustom menggunakan opsi `retryStatusCodes`.

Nilai default untuk `retry` adalah `1` kali percobaan ulang, kecuali untuk metode `POST`, `PUT`, `PATCH`, dan `DELETE` di mana `ofetch` tidak mencoba ulang secara default untuk menghindari efek samping yang tidak diinginkan. Jika Anda menetapkan nilai kustom untuk `retry`, itu akan **selalu mencoba ulang** untuk semua permintaan.

Default untuk `retryDelay` adalah `0` ms.

```ts
await ofetch("http://google.com/404", {
  retry: 3,
  retryDelay: 500, // ms
  retryStatusCodes: [ 404, 500 ], // kode status respons yang akan dicoba ulang
});
```

## ✔️ Timeout

Anda dapat menentukan `timeout` dalam milidetik untuk secara otomatis membatalkan permintaan setelah batas waktu (default-nya dinonaktifkan).

```ts
await ofetch("http://google.com/404", {
  timeout: 3000, // Timeout setelah 3 detik
});
```

## ✔️ Type Friendly

Respons dapat dibantu tipe:

```ts
const article = await ofetch<Article>(`/api/article/${id}`);
// Auto complete bekerja dengan article.id
```

## ✔️ Menambahkan `baseURL`

Dengan menggunakan opsi `baseURL`, `ofetch` akan menambahkan awalan untuk slash di awal/akhir dan parameter pencarian query pada baseURL menggunakan [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/config", { baseURL });
```

## ✔️ Menambahkan Query Search Params

Dengan menggunakan opsi `query` (atau `params` sebagai alias), `ofetch` akan menambahkan parameter pencarian query ke URL dengan tetap mempertahankan query pada permintaan menggunakan [ufo](https://github.com/unjs/ufo):

```js
await ofetch("/movie?lang=en", { query: { id: 123 } });
```

## ✔️ Interceptor

Menyediakan interceptor async untuk mengaitkan ke dalam event siklus hidup pemanggilan `ofetch` dimungkinkan.

Anda mungkin ingin menggunakan `ofetch.create` untuk mengatur interceptor bersama.

### `onRequest({ request, options })`

`onRequest` dipanggil segera setelah `ofetch` dipanggil, memungkinkan Anda memodifikasi opsi atau melakukan logging sederhana.

```js
await ofetch("/api", {
  async onRequest({ request, options }) {
    // Log permintaan
    console.log("[fetch request]", request, options);

    // Tambahkan `?t=1640125211170` ke parameter pencarian query
    options.query = options.query || {};
    options.query.t = new Date();
  },
});
```

### `onRequestError({ request, options, error })`

`onRequestError` akan dipanggil ketika permintaan fetch gagal.
```js
await ofetch("/api", {
  async onRequestError({ request, options, error }) {
    // Catat error
    console.log("[fetch request error]", request, error);
  },
});
```

### `onResponse({ request, options, response })`

`onResponse` akan dipanggil setelah pemanggilan `fetch` dan parsing body.

```js
await ofetch("/api", {
  async onResponse({ request, response, options }) {
    // Catat respons
    console.log("[fetch response]", request, response.status, response.body);
  },
});
```

### `onResponseError({ request, options, response })`

`onResponseError` sama seperti `onResponse` tetapi akan dipanggil ketika fetch terjadi namun `response.ok` bukan `true`.

```js
await ofetch("/api", {
  async onResponseError({ request, response, options }) {
    // Catat error
    console.log(
      "[fetch response error]",
      request,
      response.status,
      response.body
    );
  },
});
```

### Mengirim array interceptor

Jika perlu, juga memungkinkan untuk mengirim array fungsi yang akan dipanggil secara berurutan.

```js
await ofetch("/api", {
  onRequest: [
    () => {
      /* Lakukan sesuatu */
    },
    () => {
      /* Lakukan hal lain */
    },
  ],
});
```

## ✔️ Membuat fetch dengan opsi default

Utilitas ini berguna jika Anda perlu menggunakan opsi umum pada beberapa pemanggilan fetch.

**Catatan:** Default akan dikloning pada satu level dan diturunkan. Hati-hati dengan opsi bertingkat seperti `headers`.

```js
const apiFetch = ofetch.create({ baseURL: "/api" });

apiFetch("/test"); // Sama dengan ofetch('/test', { baseURL: '/api' })
```

## 💡 Menambahkan headers

Dengan menggunakan opsi `headers`, `ofetch` menambahkan header tambahan selain header default permintaan:

```js
await ofetch("/movies", {
  headers: {
    Accept: "application/json",
    "Cache-Control": "no-cache",
  },
});
```

## 🍣 Akses ke Respons Mentah

Jika Anda perlu mengakses respons mentah (untuk headers, dll), Anda dapat menggunakan `ofetch.raw`:

```js
const response = await ofetch.raw("/sushi");

// response._data
// response.headers
// ...
```

## 🌿 Menggunakan Native Fetch

Sebagai jalan pintas, Anda dapat menggunakan `ofetch.native` yang menyediakan API `fetch` native

```js
const json = await ofetch.native("/sushi").then((r) => r.json());
```
```

## 🕵️ Menambahkan HTTP(S) Agent

Di lingkungan Node.js (>= 18), Anda dapat menyediakan dispatcher khusus untuk mencegat permintaan dan mendukung fitur seperti Proxy dan sertifikat self-signed. Fitur ini diaktifkan oleh [undici](https://undici.nodejs.org/) yang sudah terpasang di Node.js. [baca selengkapnya](https://undici.nodejs.org/#/docs/api/Dispatcher) tentang Dispatcher API.

Beberapa agent yang tersedia:

- `ProxyAgent`: Kelas Proxy Agent yang mengimplementasikan Agent API. Memungkinkan koneksi melalui proxy dengan cara yang sederhana. ([dokumentasi](https://undici.nodejs.org/#/docs/api/ProxyAgent))
- `MockAgent`: Kelas Agent yang dimock yang mengimplementasikan Agent API. Memungkinkan Anda mencegat permintaan HTTP yang dibuat melalui undici dan mengembalikan respons mock sebagai gantinya. ([dokumentasi](https://undici.nodejs.org/#/docs/api/MockAgent))
- `Agent`: Agent memungkinkan pengiriman permintaan ke berbagai origin yang berbeda. ([dokumentasi](https://undici.nodejs.org/#/docs/api/Agent))

**Contoh:** Atur proxy agent untuk satu permintaan:

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const data = await ofetch("https://icanhazip.com", { dispatcher: proxyAgent });
```

**Contoh:** Buat instance fetch kustom dengan proxy diaktifkan:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
const fetchWithProxy = ofetch.create({ dispatcher: proxyAgent });

const data = await fetchWithProxy("https://icanhazip.com");
```

**Contoh:** Atur proxy agent untuk semua permintaan:

```ts
import { ProxyAgent, setGlobalDispatcher } from "undici";
import { ofetch } from "ofetch";

const proxyAgent = new ProxyAgent("http://localhost:3128");
setGlobalDispatcher(proxyAgent);

const data = await ofetch("https://icanhazip.com");
```

**Contoh:** Izinkan sertifikat self-signed (GUNAKAN DENGAN RISIKO ANDA SENDIRI!)

```ts
import { ProxyAgent } from "undici";
import { ofetch } from "ofetch";

// Catatan: Ini membuat fetch menjadi tidak aman terhadap serangan MITM. GUNAKAN DENGAN RISIKO ANDA SENDIRI!
const unsecureProxyAgent = new ProxyAgent({ requestTls: { rejectUnauthorized: false } });
const unsecureFetch = ofetch.create({ dispatcher: unsecureProxyAgent });

const data = await unsecureFetch("https://www.squid-cache.org/");
```

Pada versi Node.js yang lebih lama (<18), Anda juga dapat menggunakan `agent`:

```ts
import { HttpsProxyAgent } from "https-proxy-agent";

await ofetch("/api", {
  agent: new HttpsProxyAgent("http://example.com"),
});
```

### Dukungan `keepAlive` (hanya berlaku untuk Node < 18)

Dengan mengatur variabel lingkungan `FETCH_KEEP_ALIVE` ke `true`, HTTP/HTTPS agent akan didaftarkan untuk menjaga socket tetap aktif meskipun tidak ada permintaan yang sedang berjalan, sehingga dapat digunakan untuk permintaan berikutnya tanpa harus membuat koneksi TCP baru.

**Catatan:** Opsi ini berpotensi menimbulkan kebocoran memori. Silakan cek [node-fetch/node-fetch#1325](https://github.com/node-fetch/node-fetch/pull/1325).

## 📦 Catatan Bundler

- Semua target diekspor dalam format Module dan CommonJS serta ekspor bernama
- Tidak ada ekspor yang ditranspilasi demi sintaks modern
  - Anda mungkin perlu men-transpile paket `ofetch`, `destr`, dan `ufo` dengan Babel untuk dukungan ES5
- Anda perlu polyfill global `fetch` untuk mendukung browser lawas seperti menggunakan [unfetch](https://github.com/developit/unfetch)

## ❓ FAQ

**Mengapa ekspor disebut `ofetch` bukan `fetch`?**

Menggunakan nama yang sama dengan `fetch` bisa membingungkan karena API-nya berbeda namun tetap merupakan fetch, sehingga digunakan alternatif nama terdekat. Namun, Anda bisa mengimpor `{ fetch }` dari `ofetch` yang otomatis polyfill untuk Node.js dan menggunakan native jika tersedia.

**Mengapa tidak ada default export?**

Default export berisiko tercampur dengan ekspor CommonJS.

Ini juga menjamin kami bisa menambahkan lebih banyak utilitas tanpa memecah paket dan juga mendorong penggunaan nama `ofetch`.

**Mengapa tidak di-transpile?**

Dengan men-transpile library, kita justru membawa web ke belakang dengan kode lawas yang tidak dibutuhkan oleh sebagian besar pengguna.

Jika Anda perlu mendukung pengguna lawas, Anda bisa men-transpile library ini secara opsional di pipeline build Anda.
```
## Lisensi

MIT. Dibuat dengan 💖

<!-- Lencana -->

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