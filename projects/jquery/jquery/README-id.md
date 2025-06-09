# [jQuery](https://jquery.com/) — JavaScript Gelombang Baru

Rapat saat ini diadakan di [platform matrix.org](https://matrix.to/#/#jquery_meeting:gitter.im).

Notulen rapat dapat ditemukan di [meetings.jquery.org](https://meetings.jquery.org/category/core/).

Versi terbaru jQuery tersedia di [https://jquery.com/download/](https://jquery.com/download/).

## Dukungan Versi

| Versi  | Cabang      | Status   |
| ------ | ----------- | -------- |
| 4.x    | main        | Beta     |
| 3.x    | 3.x-stable  | Aktif    |
| 2.x    | 2.x-stable  | Tidak Aktif |
| 1.x    | 1.x-stable  | Tidak Aktif |

Setelah 4.0.0 final dirilis, cabang 3.x akan terus menerima pembaruan untuk waktu yang terbatas. Cabang 2.x dan 1.x tidak lagi didukung.

Dukungan komersial untuk versi tidak aktif tersedia dari [HeroDevs](https://herodevs.com/nes).

Pelajari lebih lanjut tentang [dukungan versi kami](https://jquery.com/support/).

## Panduan Kontribusi

Dalam semangat pengembangan perangkat lunak open source, jQuery selalu mendorong kontribusi kode dari komunitas. Untuk membantu Anda memulai dan sebelum Anda mulai menulis kode, pastikan untuk membaca panduan kontribusi penting berikut secara menyeluruh:

1. [Mulai Terlibat](https://contribute.jquery.org/)
2. [Panduan Gaya Inti](https://contribute.jquery.org/style-guide/js/)
3. [Menulis Kode untuk Proyek jQuery](https://contribute.jquery.org/code/)

### Referensi ke issues/PR

Isu/PR GitHub biasanya direferensikan melalui `gh-NOMOR`, di mana `NOMOR` adalah ID numerik dari isu/PR tersebut. Anda dapat menemukan isu/PR tersebut di `https://github.com/jquery/jquery/issues/NOMOR`.

jQuery sebelumnya menggunakan pelacak bug berbeda - berbasis Trac - yang tersedia di [bugs.jquery.com](https://bugs.jquery.com/). Situs ini disimpan dalam mode hanya-baca sehingga referensi ke diskusi lama tetap memungkinkan. Ketika sumber jQuery mereferensikan salah satu isu tersebut, digunakan pola `trac-NOMOR`, di mana `NOMOR` adalah ID numerik isu. Anda dapat menemukan isu tersebut di `https://bugs.jquery.com/ticket/NOMOR`.

## Lingkungan Tempat Menggunakan jQuery

- [Dukungan browser](https://jquery.com/browser-support/)
- jQuery juga mendukung Node, ekstensi browser, dan lingkungan non-browser lainnya.

## Apa yang Anda Butuhkan untuk Membangun jQuery Sendiri

Untuk membangun jQuery, Anda perlu Node.js/npm terbaru dan git 1.7 atau lebih baru. Versi sebelumnya mungkin berfungsi, tetapi tidak didukung.

Untuk Windows, Anda harus mengunduh dan menginstal [git](https://git-scm.com/downloads) dan [Node.js](https://nodejs.org/en/download/).

Pengguna macOS sebaiknya menginstal [Homebrew](https://brew.sh/). Setelah Homebrew terinstal, jalankan `brew install git` untuk menginstal git,
dan `brew install node` untuk menginstal Node.js.

Pengguna Linux/BSD harus menggunakan manajer paket yang sesuai untuk menginstal git dan Node.js, atau membangun dari sumber
jika Anda lebih suka cara itu. Mudah sekali.

## Cara Membangun jQuery Sendiri

Pertama, [kloning repo git jQuery](https://help.github.com/en/github/creating-cloning-and-archiving-repositories/cloning-a-repository).

Kemudian, masuk ke direktori jquery, instal dependensi, dan jalankan skrip build:

```bash
cd jquery
npm install
npm run build
```

Versi jQuery yang sudah dibangun akan ditempatkan di direktori `dist/`, beserta salinan yang sudah diminimalkan dan berkas peta yang terkait.

## Membangun Semua Berkas Rilis jQuery

Untuk membangun semua varian jQuery, jalankan perintah berikut:

```bash
npm run build:all
```

Ini akan membuat semua varian yang disertakan jQuery dalam rilis, termasuk `jquery.js`, `jquery.slim.js`, `jquery.module.js`, dan `jquery.slim.module.js` beserta berkas hasil minifikasi dan sourcemaps-nya.

`jquery.module.js` dan `jquery.slim.module.js` adalah [modul ECMAScript](https://developer.mozilla.org/en-US/docs/Web/JavaScript/Guide/Modules) yang mengekspor `jQuery` dan `$` sebagai ekspor bernama dan ditempatkan di direktori `dist-module/` alih-alih `dist/`.

## Membangun jQuery Kustom

Skrip build dapat digunakan untuk membuat versi kustom jQuery yang hanya menyertakan modul yang Anda butuhkan.

Setiap modul dapat dikecualikan kecuali `core`. Ketika mengecualikan `selector`, modul tidak dihapus tetapi digantikan dengan pembungkus kecil di sekitar `querySelectorAll` bawaan (lihat penjelasan di bawah untuk informasi lebih lanjut).

### Bantuan Skrip Build

Untuk melihat daftar lengkap opsi yang tersedia untuk skrip build, jalankan perintah berikut:

```bash
npm run build -- --help
```

### Modul

Untuk mengecualikan sebuah modul, berikan path relatif ke folder `src` (tanpa ekstensi `.js`) ke opsi `--exclude`. Saat menggunakan opsi `--include`, modul default tidak disertakan dan build dibuat hanya dengan modul yang disebutkan.

Beberapa contoh modul yang dapat dikecualikan atau disertakan adalah:

- **ajax**: Semua fungsi AJAX: `$.ajax()`, `$.get()`, `$.post()`, `$.ajaxSetup()`, `.load()`, transport, dan event AJAX seperti `.ajaxStart()`.
- **ajax/xhr**: Hanya transport AJAX XMLHTTPRequest.
- **ajax/script**: Hanya transport AJAX `<script>`; digunakan untuk mengambil skrip.
- **ajax/jsonp**: Hanya transport AJAX JSONP; bergantung pada transport ajax/script.
- **css**: Metode `.css()`. Juga akan menghapus **semua** modul yang bergantung pada css (termasuk **effects**, **dimensions**, dan **offset**).
- **css/showHide**: `.show()`, `.hide()` dan `.toggle()` non-animasi; dapat dikecualikan jika Anda menggunakan kelas atau pemanggilan `.css()` eksplisit untuk mengatur properti `display`. Juga akan menghapus modul **effects**.
- **deprecated**: Metode yang didokumentasikan sebagai deprecated tetapi belum dihapus.
- **dimensions**: Metode `.width()` dan `.height()`, termasuk variasi `inner-` dan `outer-`.
- **effects**: Metode `.animate()` dan shorthand-nya seperti `.slideUp()` atau `.hide("slow")`.
- **event**: Metode `.on()` dan `.off()` serta semua fungsi event.
- **event/trigger**: Metode `.trigger()` dan `.triggerHandler()`.
- **offset**: Metode `.offset()`, `.position()`, `.offsetParent()`, `.scrollLeft()`, dan `.scrollTop()`.
- **wrap**: Metode `.wrap()`, `.wrapAll()`, `.wrapInner()`, dan `.unwrap()`.
- **core/ready**: Kecualikan modul ready jika Anda menempatkan skrip di akhir body. Callback ready yang diikat dengan `jQuery()` akan langsung dipanggil. Namun, `jQuery(document).ready()` tidak akan menjadi fungsi dan `.on("ready", ...)` atau sejenisnya tidak akan dipicu.
- **deferred**: Kecualikan jQuery.Deferred. Ini juga akan mengecualikan semua modul yang bergantung pada Deferred, termasuk **ajax**, **effects**, dan **queue**, tetapi menggantikan **core/ready** dengan **core/ready-no-deferred**.
- **exports/global**: Mengecualikan penempelan variabel global jQuery ($ dan jQuery) ke window.
- **exports/amd**: Mengecualikan definisi AMD.

- **selector**: Mesin selector jQuery penuh. Ketika modul ini dikecualikan, ia digantikan dengan mesin selector sederhana berbasis metode `querySelectorAll` browser yang tidak mendukung ekstensi selector jQuery atau semantik yang ditingkatkan. Lihat berkas [selector-native.js](https://github.com/jquery/jquery/blob/main/src/selector-native.js) untuk detail.

*Catatan*: Mengecualikan modul `selector` penuh juga akan mengecualikan semua ekstensi selector jQuery (seperti `effects/animatedSelector` dan `css/hiddenVisibleSelectors`).

##### Nama AMD

Anda dapat mengatur nama modul untuk definisi AMD jQuery. Secara default, namanya adalah "jquery", yang ramah dengan plugin dan pustaka pihak ketiga, tetapi ada kasus di mana Anda ingin mengubahnya. Berikan ke parameter `--amd`:

```bash
npm run build -- --amd="nama-kustom"
```

Atau, untuk mendefinisikan secara anonim, biarkan nama kosong.

```bash
npm run build -- --amd
```

##### Nama Berkas dan Direktori

Nama default untuk berkas jQuery hasil build adalah `jquery.js`; ditempatkan di bawah direktori `dist/`. Nama berkas dapat diubah menggunakan `--filename` dan direktori menggunakan `--dir`. `--dir` relatif terhadap root proyek.

```bash
npm run build -- --slim --filename="jquery.slim.js" --dir="/tmp"
```

Ini akan membuat versi slim dari jQuery dan menempatkannya di `tmp/jquery.slim.js`.

##### Mode Modul ECMAScript (ESM)

Secara default, jQuery menghasilkan berkas JavaScript biasa. Anda juga dapat menghasilkan modul ECMAScript yang mengekspor `jQuery` sebagai ekspor default menggunakan parameter `--esm`:

```bash
npm run build -- --filename=jquery.module.js --esm
```

##### Mode Factory

Secara default, jQuery bergantung pada global `window`. Untuk lingkungan yang tidak memilikinya, Anda dapat membuat build factory yang mengekspos fungsi yang menerima `window` sebagai parameter yang dapat Anda sediakan secara eksternal (lihat [`README` dari paket yang dipublikasikan](build/fixtures/README.md) untuk instruksi penggunaan). Anda dapat membuat factory seperti itu menggunakan parameter `--factory`:

```bash
npm run build -- --filename=jquery.factory.js --factory
```

Opsi ini dapat dikombinasikan dengan opsi lain seperti `--esm` atau `--slim`:

```bash
npm run build -- --filename=jquery.factory.slim.module.js --factory --esm --slim --dir="/dist-module"
```

#### Contoh Build Kustom

Buat build kustom menggunakan `npm run build`, dengan daftar modul yang ingin dikecualikan. Mengecualikan modul tingkat atas juga akan mengecualikan direktori modul terkait.

Kecualikan semua fungsi **ajax**:

```bash
npm run build -- --exclude=ajax
```

Mengecualikan **css** juga menghapus modul yang bergantung pada CSS: **effects**, **offset**, **dimensions**.

```bash
npm run build -- --exclude=css
```

Kecualikan beberapa modul sekaligus (`-e` adalah alias untuk `--exclude`):

```bash
npm run build -- -e ajax/jsonp -e css -e deprecated -e dimensions -e effects -e offset -e wrap
```

Ada alias khusus untuk menghasilkan build dengan konfigurasi yang sama seperti build resmi jQuery Slim:

```bash
npm run build -- --filename=jquery.slim.js --slim
```

Atau, untuk membuat build slim dalam bentuk modul esm:

```bash
npm run build -- --filename=jquery.slim.module.js --slim --esm
```
```

*Build kustom tidak resmi tidak diuji secara rutin. Gunakan dengan risiko Anda sendiri.*

## Menjalankan Unit Test

Pastikan Anda telah menginstal dependensi yang diperlukan:

```bash
npm install
```

Jalankan `npm start` untuk membangun jQuery secara otomatis saat Anda bekerja:

```bash
npm start
```

Jalankan unit test dengan server lokal yang mendukung PHP. Pastikan Anda menjalankan situs dari direktori root, bukan dari direktori "test". Tidak diperlukan database. Server PHP lokal yang sudah dikonfigurasi tersedia untuk Windows dan Mac. Berikut beberapa opsi:

- Windows: [WAMP download](https://www.wampserver.com/en/)
- Mac: [MAMP download](https://www.mamp.info/en/downloads/)
- Linux: [Setting up LAMP](https://www.linux.com/training-tutorials/easy-lamp-server-installation/)
- [Mongoose (kebanyakan platform)](https://code.google.com/p/mongoose/)

## Git Esensial

Karena kode sumber dikelola oleh sistem version control Git, ada baiknya mengetahui beberapa fitur yang digunakan.

### Pembersihan

Jika Anda ingin mengembalikan direktori kerja Anda ke status upstream, perintah berikut dapat digunakan (ingat semua pekerjaan Anda akan hilang setelah ini):

```bash
git reset --hard upstream/main
git clean -fdx
```

### Rebasing

Untuk branch fitur/topik, Anda sebaiknya selalu menggunakan flag `--rebase` pada `git pull`, atau jika Anda biasanya menangani banyak branch sementara "untuk pull request github", jalankan perintah berikut untuk mengotomatisasinya:

```bash
git config branch.autosetuprebase local
```

(lihat `man git-config` untuk informasi lebih lanjut)

### Menangani konflik merge

Jika Anda mendapatkan konflik merge saat melakukan merge, daripada mengedit file yang konflik secara manual, Anda dapat menggunakan fitur
`git mergetool`. Meskipun tool default `xxdiff` terlihat buruk/kuno, ini cukup berguna.

Berikut beberapa perintah yang dapat digunakan di sana:

- `Ctrl + Alt + M` - auto-merge sebanyak mungkin
- `b` - lompat ke konflik merge berikutnya
- `s` - ubah urutan baris yang konflik
- `u` - batalkan merge
- `left mouse button` - tandai blok sebagai pemenang
- `middle mouse button` - tandai baris sebagai pemenang
- `Ctrl + S` - simpan
- `Ctrl + Q` - keluar

## Referensi [QUnit](https://api.qunitjs.com)

### Metode Test

```js
expect( numAssertions );
stop();
start();
```

*Catatan*: Penambahan argumen pada stop/start oleh QUnit diabaikan pada test suite ini sehingga start dan stop dapat dipassing sebagai callback tanpa perlu khawatir dengan parameternya.

### Test assertions

```js
ok( value, [message] );
equal( actual, expected, [message] );
notEqual( actual, expected, [message] );
deepEqual( actual, expected, [message] );
notDeepEqual( actual, expected, [message] );
strictEqual( actual, expected, [message] );
notStrictEqual( actual, expected, [message] );
throws( block, [expected], [message] );
```

## Referensi Metode Kenyamanan Test Suite

Lihat [test/data/testinit.js](https://raw.githubusercontent.com/jquery/jquery/main/test/data/testinit.js).

### Mengembalikan array elemen dengan ID yang diberikan

```js
q( ... );
```

Contoh:

```js
q( "main", "foo", "bar" );

=> [ div#main, span#foo, input#bar ]
```

### Mengasersi bahwa seleksi cocok dengan ID yang diberikan

```js
t( testName, selector, [ "array", "of", "ids" ] );
```

Contoh:

```js
t("Check for something", "//[a]", ["foo", "bar"]);
```

### Memicu event DOM native tanpa melalui jQuery

```js
fireNative( node, eventType );
```

Contoh:

```js
fireNative( jQuery( "#elem" )[ 0 ], "click" );
```

### Menambahkan angka acak ke url untuk mencegah caching

```js
url( "some/url" );
```

Contoh:

```js
url( "index.html" );

=> "data/index.html?10538358428943"


url( "mock.php?foo=bar" );

=> "data/mock.php?foo=bar&10538358345554"
```

### Menjalankan test dalam iframe

Beberapa test mungkin memerlukan dokumen selain test fixture standar, dan
test tersebut dapat dijalankan dalam iframe terpisah. Kode test dan assertions utama
tetap berada di file test utama jQuery; hanya markup test fixture minimal
dan kode setup yang sebaiknya diletakkan di file iframe.

```js
testIframe( testName, fileName,
  function testCallback(
      assert, jQuery, window, document,
	  [ additional args ] ) {
	...
  } );
```

Ini memuat sebuah halaman, membangun url dengan fileName `"./data/" + fileName`.
Halaman dalam iframe menentukan kapan callback terjadi dalam test dengan
menyertakan script "/test/data/iframeTest.js" dan memanggil
`startIframeTest( [ additional args ] )` saat diperlukan. Seringkali ini
akan dilakukan setelah document ready atau setelah `window.onload` dipanggil.

`testCallback` menerima objek QUnit `assert` yang dibuat oleh `testIframe`
untuk test ini, diikuti oleh global `jQuery`, `window`, dan `document` dari
iframe. Jika kode iframe meneruskan argumen ke `startIframeTest`,
argumen tersebut mengikuti argumen `document`.

## Pertanyaan?

Jika Anda memiliki pertanyaan, silakan bertanya di
[forum Developing jQuery Core](https://forum.jquery.com/developing-jquery-core) atau di #jquery di [libera](https://web.libera.chat/).
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---