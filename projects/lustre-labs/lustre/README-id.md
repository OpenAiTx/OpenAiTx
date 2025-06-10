<h1 align="center">Lustre</h1>

<div align="center">
  ✨ <strong>Buat frontend Anda bersinar</strong> ✨
</div>

<div align="center">
  Sebuah framework untuk membangun aplikasi Web di Gleam!
</div>

<br />

<div align="center">
  <a href="https://hex.pm/packages/lustre">
    <img src="https://img.shields.io/hexpm/v/lustre"
      alt="Tersedia di Hex" />
  </a>
  <a href="https://hexdocs.pm/lustre">
    <img src="https://img.shields.io/badge/hex-docs-ffaff3"
      alt="Dokumentasi" />
  </a>
</div>

<div align="center">
  <h3>
    <!--
    <a href="https://lustre.build">
      Website
    </a>
    <span> | </span>
    -->
    <a href="https://hexdocs.pm/lustre/guide/01-quickstart.html">
      Quickstart
    </a>
    <span> | </span>
    <a href="https://hexdocs.pm/lustre">
      Referensi
    </a>
    <span> | </span>
    <a href="https://discord.gg/Fm8Pwmy">
      Discord
    </a>
  </h3>
</div>

<div align="center">
  <sub>Dibuat dengan ❤︎ oleh
  <a href="https://twitter.com/hayleighdotdev">Hayleigh Thompson</a> dan
  <a href="https://github.com/lustre-labs/lustre/graphs/contributors">
    kontributor
  </a>
</div>

---

## Daftar isi

- [Fitur](#features)
- [Contoh](#example)
- [Filosofi](#philosophy)
- [Instalasi](#installation)
- [Langkah Selanjutnya](#where-next)
- [Dukungan](#support)

## Fitur {#features}

- API **deklaratif** dan fungsional untuk membangun HTML. Tanpa template, tanpa makro,
  hanya Gleam.

- Arsitektur terinspirasi dari Erlang dan Elm untuk **mengelola state**.

- **Efek samping terkelola** untuk kode yang prediktabel dan mudah diuji.

- Komponen universal. **Tulis sekali, jalankan di mana saja**. Elm bertemu Phoenix LiveView.

- **CLI dengan fitur lengkap** yang mempermudah scaffolding dan membangun aplikasi.

- **Rendering sisi server** untuk templating HTML statis.

## Contoh {#example}

Lustre hadir dengan [lebih dari 20 contoh](https://hexdocs.pm/lustre/reference/examples.html)!
Inilah tampilannya:

```gleam
import gleam/int
import lustre
import lustre/element.{text}
import lustre/element/html.{div, button, p}
import lustre/event.{on_click}

pub fn main() {
  let app = lustre.simple(init, update, view)
  let assert Ok(_) = lustre.start(app, "#app", Nil)

  Nil
}

fn init(_flags) {
  0
}

type Msg {
  Incr
  Decr
}

fn update(model, msg) {
  case msg {
    Incr -> model + 1
    Decr -> model - 1
  }
}

fn view(model) {
  let count = int.to_string(model)

  div([], [
    button([on_click(Incr)], [text(" + ")]),
    p([], [text(count)]),
    button([on_click(Decr)], [text(" - ")])
  ])
}
```

## Filosofi {#philosophy}

Lustre adalah framework _opinionated_ untuk membangun aplikasi Web berukuran kecil hingga menengah.
Pengembangan frontend modern itu sulit dan kompleks. Sebagian dari kompleksitas itu memang diperlukan, namun banyak juga yang muncul secara tidak sengaja atau karena terlalu banyak pilihan. Lustre memiliki filosofi desain yang sama seperti Gleam: jika memungkinkan, sebaiknya hanya ada satu cara untuk melakukan sesuatu.

Artinya, Lustre langsung menyediakan satu sistem manajemen state, dimodelkan dari Elm dan Erlang/OTP. Buka aplikasi Lustre mana pun dan Anda akan langsung merasa familiar.

Ini juga berarti kami mendorong pendekatan sederhana untuk membangun view daripada yang kompleks. Lustre _memang_ memiliki cara untuk membuat komponen stateful yang terenkapsulasi (sesuatu yang kami rindukan di Elm), tapi itu tidak seharusnya menjadi default. Utamakan fungsi-fungsi sederhana dibandingkan komponen stateful.

Jika komponen _memang_ diperlukan, manfaatkan kenyataan bahwa komponen Lustre dapat
berjalan _di mana saja_. Lustre memberi Anda alat untuk menulis komponen yang dapat berjalan di dalam aplikasi Lustre yang sudah ada, mengekspornya sebagai Web Component mandiri, atau menjalankannya di server dengan runtime minimal untuk memodifikasi DOM. Lustre menyebutnya **komponen universal** dan semuanya ditulis dengan mempertimbangkan banyak target Gleam.

## Instalasi {#installation}

Lustre sudah dipublikasikan di [Hex](https://hex.pm/packages/lustre)! Anda dapat menambahkannya ke
proyek Gleam Anda lewat command line:

```sh
gleam add lustre
```

Lustre juga memiliki paket pendamping yang berisi tooling pengembangan yang mungkin ingin Anda instal:

> **Catatan**: server pengembangan lustre_dev_tools memantau filesystem Anda untuk
> perubahan pada kode gleam Anda dan dapat memuat ulang browser secara otomatis. Untuk pengguna linux, ini memerlukan [inotify-tools]() terpasang

```sh
gleam add --dev lustre_dev_tools
```

## Langkah Selanjutnya {#where-next}

Untuk mulai menggunakan Lustre, lihat [panduan quickstart](https://hexdocs.pm/lustre/guide/01-quickstart.html).
Jika Anda lebih suka melihat kode, direktori [examples](https://github.com/lustre-labs/lustre/tree/main/examples)
berisi beberapa aplikasi kecil yang mendemonstrasikan berbagai
aspek dari framework ini.

Anda juga dapat membaca dokumentasi dan referensi API di
[HexDocs](https://hexdocs.pm/lustre).

## Dukungan {#support}

Lustre sebagian besar dikembangkan hanya oleh saya sendiri, [Hayleigh](https://github.com/hayleigh-dot-dev),
di sela-sela dua pekerjaan. Jika Anda ingin mendukung pekerjaan saya, Anda dapat [mensponsori saya di GitHub](https://github.com/sponsors/hayleigh-dot-dev).

Kontribusi juga sangat diterima! Jika Anda menemukan bug, atau ingin
mengusulkan fitur, silakan buka issue atau pull request.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---