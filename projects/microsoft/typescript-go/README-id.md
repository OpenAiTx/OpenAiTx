# TypeScript 7

[Tidak yakin ini apa? Baca posting pengumumannya!](https://devblogs.microsoft.com/typescript/typescript-native-port/)

## Pratinjau

Build pratinjau tersedia di npm sebagai `@typescript/native-preview`.

```sh
npm install @typescript/native-preview
npx tsgo # Gunakan ini seperti Anda menggunakan tsc.
```

Ekstensi VS Code pratinjau [tersedia di marketplace VS Code](https://marketplace.visualstudio.com/items?itemName=TypeScriptTeam.native-preview).

Untuk menggunakannya, atur ini di pengaturan VS Code Anda:

```json
{
    "typescript.experimental.useTsgo": true
}
```

## Cara Membangun dan Menjalankan

Repo ini menggunakan [Go 1.24 atau lebih tinggi](https://go.dev/dl/), [Rust 1.85 atau lebih tinggi](https://www.rust-lang.org/tools/install), [Node.js dengan npm](https://nodejs.org/), dan [`hereby`](https://www.npmjs.com/package/hereby).

Untuk pengujian dan pembuatan kode, repo ini memiliki submodul git ke repo utama TypeScript yang mengarah ke commit yang sedang di-porting.
Saat mengkloning, Anda perlu mengkloning dengan submodul:

```sh
git clone --recurse-submodules https://github.com/microsoft/typescript-go.git
```

Jika Anda sudah mengkloning repo, Anda dapat menginisialisasi submodul dengan:

```sh
git submodule update --init --recursive
```

Dengan submodul sudah ada dan `npm ci`, Anda dapat menjalankan tugas melalui `hereby`, mirip dengan repo TypeScript:

```sh
hereby build          # Verifikasi bahwa proyek berhasil dibangun
hereby test           # Jalankan semua pengujian
hereby install-tools  # Instal alat tambahan seperti linter
hereby lint           # Jalankan semua linter
hereby format         # Format semua kode
hereby generate       # Menghasilkan semua kode Go (misal: diagnostics, dikomit ke repo)
```

Tugas tambahan masih dalam pengembangan.

`hereby` tidak wajib untuk bekerja di repo ini; tool `go` biasa (misal, `go build`, `go test ./...`) akan bekerja seperti biasa.
Tugas `hereby` disediakan sebagai kemudahan bagi yang sudah familiar dengan repo TypeScript.

### Menjalankan `tsgo`

Setelah menjalankan `hereby build`, Anda dapat menjalankan `built/local/tsgo`, yang perilakunya hampir sama dengan `tsc`.

### Menjalankan Prototipe LSP

Untuk debugging dan menjalankan ekstensi VS Code tanpa menginstalnya secara global:

* Jalankan VS Code di ruang kerja repo (`code .`)
* Salin `.vscode/launch.template.json` ke `.vscode/launch.json`
* <kbd>F5</kbd> (atau `Debug: Start Debugging` dari command palette)

Ini akan meluncurkan instance VS Code baru yang menggunakan Corsa LS sebagai backend. Jika sudah diatur dengan benar, Anda akan melihat "tsgo" di status bar saat file TypeScript atau JavaScript dibuka:

![LSP Prototype Screenshot](https://raw.githubusercontent.com/microsoft/typescript-go/main/.github/ls-screenshot.png)


## Apa Saja yang Sudah Berjalan?

Ini masih dalam tahap pengembangan dan belum sepenuhnya setara fitur dengan TypeScript. Bug mungkin ada. Harap periksa daftar ini dengan cermat sebelum membuat issue baru atau menganggap adanya perubahan yang disengaja.

| Fitur | Status | Catatan |
|---------|--------|-------|
| Pembuatan program | selesai | File dan resolusi modul sama dengan TS5.8. Tidak semua mode resolusi sudah didukung. |
| Parsing/pemindaian | selesai | Error sintaks sama persis seperti TS5.8 |
| Commandline dan parsing `tsconfig.json` | hampir selesai | Entry point sedikit berbeda untuk saat ini |
| Resolusi tipe | selesai | Tipe sama seperti TS5.8 |
| Pemeriksaan tipe | selesai | Error, lokasi, dan pesan sama seperti TS5.8. Printback tipe dalam error mungkin tampil berbeda (dalam progres) |
| Inferensi spesifik JavaScript dan JS Doc | belum siap | - |
| JSX | selesai | - |
| Declaration emit | dalam progres | Fitur paling umum sudah ada, tetapi beberapa edge case dan feature flag belum ditangani |
| Emit (output JS) | dalam progres | `target: esnext` didukung dengan baik, target lain mungkin ada kekurangan |
| Watch mode | prototipe | Memantau file dan membangun ulang, tapi belum ada pengecekan ulang inkremental |
| Build mode / referensi proyek | belum siap | - |
| Build inkremental | belum siap | - |
| Language service (LSP) | prototipe | Fungsionalitas minimal (error, hover, go to def). Fitur lebih banyak segera hadir |
| API | belum siap | - |

Definisi:

 * **selesai** alias "dianggap selesai": Saat ini kami tidak mengetahui kekurangan atau pekerjaan besar yang tersisa. Silakan laporkan bug
 * **dalam progres**: sedang dikerjakan; beberapa fitur mungkin sudah berjalan dan beberapa belum. Silakan laporkan panic, tapi jangan yang lain
 * **prototipe**: hanya proof-of-concept; jangan laporkan bug
 * **belum siap**: bahkan belum mulai, atau masih jauh dari siap sehingga sebaiknya jangan diutak-atik dulu

## Catatan Lain

Dalam jangka panjang, kami berharap repo ini dan isinya akan digabungkan ke `microsoft/TypeScript`.
Akibatnya, repo dan issue tracker untuk typescript-go pada akhirnya akan ditutup, jadi diskusi/issue harap disesuaikan.

Untuk daftar perubahan yang disengaja terkait TypeScript 5.7, lihat CHANGES.md.

## Kontribusi

Proyek ini menerima kontribusi dan saran. Sebagian besar kontribusi mengharuskan Anda menyetujui
Contributor License Agreement (CLA) yang menyatakan bahwa Anda memiliki hak untuk, dan benar-benar,
memberikan hak kepada kami untuk menggunakan kontribusi Anda. Untuk detailnya, kunjungi [Contributor License Agreements](https://cla.opensource.microsoft.com).

Saat Anda mengirim pull request, bot CLA akan secara otomatis menentukan apakah Anda perlu
menyediakan CLA dan menandai PR dengan benar (misal, status check, komentar). Cukup ikuti instruksi
yang diberikan oleh bot. Anda hanya perlu melakukan ini satu kali untuk semua repo yang menggunakan CLA kami.

Proyek ini mengadopsi [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/).
Untuk informasi lebih lanjut lihat [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) atau
hubungi [opencode@microsoft.com](mailto:opencode@microsoft.com) untuk pertanyaan atau komentar tambahan.

## Merek Dagang

Proyek ini mungkin mengandung merek dagang atau logo untuk proyek, produk, atau layanan tertentu. Penggunaan resmi merek dagang atau logo Microsoft tunduk pada dan harus mengikuti
[Pedoman Merek Dagang & Merek Microsoft](https://www.microsoft.com/legal/intellectualproperty/trademarks/usage/general).
Penggunaan merek dagang atau logo Microsoft pada versi modifikasi dari proyek ini tidak boleh menimbulkan kebingungan atau mengimplikasikan sponsor dari Microsoft.
Setiap penggunaan merek dagang atau logo pihak ketiga tunduk pada kebijakan pihak ketiga tersebut.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---