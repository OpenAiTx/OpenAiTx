# [React](https://react.dev/) &middot; [![GitHub license](https://img.shields.io/badge/license-MIT-blue.svg)](https://github.com/facebook/react/blob/main/LICENSE) [![npm version](https://img.shields.io/npm/v/react.svg?style=flat)](https://www.npmjs.com/package/react) [![(Runtime) Build and Test](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml/badge.svg)](https://github.com/facebook/react/actions/workflows/runtime_build_and_test.yml) [![(Compiler) TypeScript](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml/badge.svg?branch=main)](https://github.com/facebook/react/actions/workflows/compiler_typescript.yml) [![PRs Welcome](https://img.shields.io/badge/PRs-welcome-brightgreen.svg)](https://legacy.reactjs.org/docs/how-to-contribute.html#your-first-pull-request)

React adalah pustaka JavaScript untuk membangun antarmuka pengguna.

* **Deklaratif:** React membuat pembuatan UI interaktif menjadi mudah. Rancang tampilan sederhana untuk setiap status aplikasi Anda, dan React akan secara efisien memperbarui serta merender komponen yang tepat saat data Anda berubah. Tampilan deklaratif membuat kode Anda lebih mudah diprediksi, lebih sederhana untuk dipahami, dan lebih mudah untuk di-debug.
* **Berbasis Komponen:** Bangun komponen yang terenkapsulasi dan mengelola statusnya sendiri, lalu susun mereka untuk membuat UI yang kompleks. Karena logika komponen ditulis dalam JavaScript, bukan dalam template, Anda dapat dengan mudah mengalirkan data yang kaya di seluruh aplikasi dan menjaga status tetap berada di luar DOM.
* **Belajar Sekali, Tulis di Mana Saja:** Kami tidak membuat asumsi tentang tumpukan teknologi Anda, sehingga Anda dapat mengembangkan fitur baru di React tanpa menulis ulang kode yang sudah ada. React juga dapat melakukan render di server menggunakan [Node](https://nodejs.org/en) dan mendukung aplikasi mobile menggunakan [React Native](https://reactnative.dev/).

[Pelajari cara menggunakan React di proyek Anda](https://react.dev/learn).

## Instalasi

React telah dirancang untuk adopsi secara bertahap sejak awal, dan **Anda dapat menggunakan React sedikit atau sebanyak yang Anda butuhkan**:

* Gunakan [Quick Start](https://react.dev/learn) untuk mencoba React.
* [Tambahkan React ke Proyek yang Sudah Ada](https://react.dev/learn/add-react-to-an-existing-project) untuk menggunakan React sesuai kebutuhan Anda.
* [Buat Aplikasi React Baru](https://react.dev/learn/start-a-new-react-project) jika Anda mencari toolchain JavaScript yang kuat.

## Dokumentasi

Anda dapat menemukan dokumentasi React [di situs web](https://react.dev/).

Lihat halaman [Getting Started](https://react.dev/learn) untuk gambaran cepat.

Dokumentasi dibagi menjadi beberapa bagian:

* [Quick Start](https://react.dev/learn)
* [Tutorial](https://react.dev/learn/tutorial-tic-tac-toe)
* [Thinking in React](https://react.dev/learn/thinking-in-react)
* [Instalasi](https://react.dev/learn/installation)
* [Mendeskripsikan UI](https://react.dev/learn/describing-the-ui)
* [Menambahkan Interaktivitas](https://react.dev/learn/adding-interactivity)
* [Mengelola State](https://react.dev/learn/managing-state)
* [Panduan Lanjutan](https://react.dev/learn/escape-hatches)
* [Referensi API](https://react.dev/reference/react)
* [Di Mana Mendapatkan Dukungan](https://react.dev/community)
* [Panduan Kontribusi](https://legacy.reactjs.org/docs/how-to-contribute.html)

Anda dapat memperbaikinya dengan mengirim pull request ke [repositori ini](https://github.com/reactjs/react.dev).

## Contoh

Kami memiliki beberapa contoh [di situs web](https://react.dev/). Berikut contoh pertama untuk memulai:

```jsx
import { createRoot } from 'react-dom/client';

function HelloMessage({ name }) {
  return <div>Hello {name}</div>;
}

const root = createRoot(document.getElementById('container'));
root.render(<HelloMessage name="Taylor" />);
```

Contoh ini akan merender "Hello Taylor" ke dalam sebuah container pada halaman.

Anda akan melihat bahwa kami menggunakan sintaks mirip HTML; [kami menyebutnya JSX](https://react.dev/learn#writing-markup-with-jsx). JSX tidak diwajibkan untuk menggunakan React, namun membuat kode lebih mudah dibaca dan penulisannya terasa seperti menulis HTML.

## Kontribusi

Tujuan utama repositori ini adalah untuk terus mengembangkan inti React, membuatnya lebih cepat dan lebih mudah digunakan. Pengembangan React berlangsung secara terbuka di GitHub, dan kami berterima kasih kepada komunitas atas kontribusi perbaikan bug dan peningkatan. Bacalah di bawah ini untuk mengetahui bagaimana Anda dapat berpartisipasi dalam meningkatkan React.

### [Kode Etik](https://code.fb.com/codeofconduct)

Facebook telah mengadopsi Kode Etik yang kami harapkan dipatuhi oleh peserta proyek. Silakan baca [teks lengkapnya](https://code.fb.com/codeofconduct) agar Anda memahami tindakan apa yang akan dan tidak akan ditoleransi.

### [Panduan Kontribusi](https://legacy.reactjs.org/docs/how-to-contribute.html)

Baca [panduan kontribusi](https://legacy.reactjs.org/docs/how-to-contribute.html) kami untuk mempelajari proses pengembangan kami, cara mengajukan perbaikan bug dan peningkatan, serta cara membangun dan menguji perubahan Anda pada React.

### [Isu Pemula yang Bagus](https://github.com/facebook/react/labels/good%20first%20issue)

Untuk membantu Anda memulai dan membiasakan diri dengan proses kontribusi kami, kami memiliki daftar [isu pemula yang bagus](https://github.com/facebook/react/labels/good%20first%20issue) yang berisi bug dengan lingkup yang relatif terbatas. Ini adalah tempat yang baik untuk memulai.

### Lisensi

React dilisensikan di bawah [MIT](./LICENSE).

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---