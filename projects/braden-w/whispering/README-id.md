<p align="center">
  <a href="https://whispering.bradenwong.com">
    <img width="180" src="https://raw.githubusercontent.com/braden-w/whispering/main/apps/app/src-tauri/recorder-state-icons/studio_microphone.png" alt="Whispering">
  </a>
  <h1 align="center">Whispering</h1>
  <p align="center">Dikte tanpa hambatan didukung oleh Model Whisper dari OpenAI</p>
</p>

<p align="center">
  <!-- Latest Version Badge -->
  <img src="https://img.shields.io/github/v/release/braden-w/whispering?style=flat-square&label=Latest%20Version&color=brightgreen" />
  <!-- License Badge -->
  <a href="LICENSE" target="_blank">
    <img alt="MIT License" src="https://img.shields.io/github/license/braden-w/whispering.svg?style=flat-square" />
  </a>
  <!-- Badges for Technologies -->
  <img alt="TypeScript" src="https://img.shields.io/badge/-TypeScript-blue?style=flat-square&logo=typescript&logoColor=white" />
  <img alt="Rust" src="https://img.shields.io/badge/-Rust-orange?style=flat-square&logo=rust&logoColor=white" />
  <!-- Platform Support Badges -->
  <a href="https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo" target="_blank">
    <img alt="Chrome" src="https://img.shields.io/chrome-web-store/stars/oilbfihknpdbpfkcncojikmooipnlglo?color=blue&label=Chrome&style=flat-square&logo=google-chrome&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="macOS" src="https://img.shields.io/badge/-macOS-black?style=flat-square&logo=apple&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Windows" src="https://img.shields.io/badge/-Windows-blue?style=flat-square&logo=windows&logoColor=white" />
  </a>
  <a href="https://github.com/braden-w/whispering/releases" target="_blank">
    <img alt="Linux" src="https://img.shields.io/badge/-Linux-yellow?style=flat-square&logo=linux&logoColor=white" />
  </a>
</p>


## Tentang

Whispering adalah aplikasi transkripsi open-source yang menyediakan fungsionalitas konversi suara ke teks secara global, dengan opsi seperti pintasan keyboard dan salin-tempel otomatis untuk membuat proses dikte menjadi semudah mungkin.

Di balik layar, aplikasi ini didukung oleh model Whisper dari OpenAI, sehingga jauh lebih akurat dibandingkan dengan fitur dikte bawaan.

> **Catatan Penting**: Whispering dirancang terutama sebagai alat transkripsi, bukan alat perekam. Untuk rekaman yang lebih panjang di mana keandalan sangat penting, saya sarankan menggunakan aplikasi perekaman khusus di ponsel atau perangkat Anda yang memanfaatkan API perekaman bawaan. Ini memastikan kualitas audio dan stabilitas rekaman yang optimal.

## Demo

https://github.com/user-attachments/assets/eca93701-10a0-4d91-b38a-f715bd7e0357

https://github.com/user-attachments/assets/a7934f1f-d08b-4037-9bbc-aadd1b13501e

## Fitur Utama

1. **Transkripsi Global**: Akses fitur konversi suara ke teks dari Whisper di mana saja dengan pintasan keyboard global atau hanya dalam dua kali klik tombol.
2. **Pengalaman Lintas Platform**:
   - Aplikasi Desktop: Memungkinkan transkripsi global di semua aplikasi.
   - Ekstensi Browser: Menyediakan transkripsi global di browser dengan berkomunikasi dengan aplikasi web.
3. **Integrasi Chat**: Ekstensi browser menambahkan tombol rekam ke situs ChatGPT dan Claude, memungkinkan input suara langsung dan transkripsi di antarmuka chat.
4. **Manajemen Transkripsi**: Tinjau dan edit transkripsi di dalam aplikasi Whispering untuk memastikan akurasi dan kejelasan.
5. **Integrasi Clipboard Otomatis**: Setelah transkripsi selesai, teks secara otomatis disalin ke clipboard Anda. Opsi tempel otomatis juga tersedia.

## Bagaimana data saya disimpan?

Whispering menyimpan sebanyak mungkin data secara lokal di perangkat Anda, termasuk rekaman dan transkripsi teks. Pendekatan ini memastikan privasi dan keamanan data maksimum. Berikut gambaran tentang bagaimana data ditangani:

1. **Penyimpanan Lokal**: Rekaman suara dan transkripsi disimpan di IndexedDB, yang digunakan sebagai penyimpanan blob dan tempat untuk menyimpan semua data Anda seperti teks dan transkripsi.

2. **Layanan Transkripsi**: Satu-satunya data yang dikirim ke luar adalah rekaman Anda ke layanan transkripsi eksternal—jika Anda memilihnya. Anda memiliki pilihan berikut:
   - Layanan eksternal seperti OpenAI atau Groq
   - Layanan transkripsi lokal seperti `faster-whisper-server`, yang menjaga semuanya tetap di perangkat

3. **Pengaturan yang Dapat Dikustomisasi**: Anda dapat mengubah layanan transkripsi di pengaturan untuk memastikan fungsionalitas lokal semaksimal mungkin.


## Instalasi

### Aplikasi Web

Kunjungi [whispering.bradenwong.com](https://whispering.bradenwong.com/), yang memiliki versi terbaru dari folder `apps/app` yang dihosting di Vercel.

### Ekstensi Chrome

Instal Ekstensi Chrome dari Chrome Web Store [di sini](https://chrome.google.com/webstore/detail/whispering/oilbfihknpdbpfkcncojikmooipnlglo).

### Aplikasi Desktop

Untuk mengunduh dan menginstal aplikasi desktop Whispering, ikuti langkah-langkah sesuai sistem operasi Anda:

#### Windows

1. Unduh paket instalasi dengan akhiran `.msi` dari [halaman rilis terbaru](https://github.com/braden-w/whispering/releases).
2. Buka file `.msi` yang telah diunduh untuk menjalankan installer.
3. Jika ditandai tidak aman, klik `More Info` -> `Run Anyway` untuk melanjutkan instalasi.
4. Ikuti instruksi di layar untuk menyelesaikan instalasi.

#### macOS

Untuk macOS, ikuti langkah-langkah berikut untuk menginstal Whispering:

1. **Unduh paket instalasi**:
   - Kunjungi [halaman rilis terbaru](https://github.com/braden-w/whispering/releases).
   - Pilih paket yang sesuai:
     - Untuk Apple Silicon: `Whispering_x.x.x_aarch64.dmg`
     - Untuk Intel: `Whispering_x.x.x_x64.dmg`

2. **Instal aplikasi**:
   - Buka file `.dmg` yang telah diunduh.
   - Seret aplikasi Whispering ke folder Applications.

3. **Jalankan Whispering**:
   - Buka Whispering dari folder Applications.
   - Jika muncul peringatan tentang pengembang yang tidak diverifikasi:
     - Klik `Cancel`
     - Klik kanan aplikasi di Finder dan pilih `Open`

4. **Pemecahan Masalah** (khusus Apple Silicon):
   Jika Anda menemui error `"Whispering" is damaged and can't be opened`:
   - Buka Terminal
   - Jalankan perintah berikut:
     ```bash
     xattr -cr /Applications/Whispering.app
     ```
   - Coba buka kembali aplikasinya

Setelah langkah-langkah ini selesai, Whispering siap digunakan di sistem macOS Anda.

#### Linux

Untuk Linux, tersedia beberapa opsi instalasi. Pilih yang sesuai dengan lingkungan Anda:

1. **AppImage**:

   - Unduh file `.AppImage` dari [halaman rilis terbaru](https://github.com/braden-w/whispering/releases).
   - Jadikan file dapat dieksekusi:
     ```bash
     chmod +x whispering_x.x.x_amd64.AppImage
     ```
   - Jalankan AppImage:
     ```bash
     ./whispering_x.x.x_amd64.AppImage
     ```

2. **Paket DEB (Debian/Ubuntu)**:
   - Unduh file `.deb` dari [halaman rilis terbaru](https://github.com/braden-w/whispering/releases).
   - Instal paket menggunakan `dpkg`:
     ```bash
     sudo dpkg -i whispering_x.x.x_amd64.deb
     ```
   - Selesaikan masalah dependensi:
     ```bash
     sudo apt-get install -f
     ```

Setelah instalasi selesai, aplikasi siap digunakan.

## Penggunaan

### Ekstensi Chrome

Setelah menginstal Ekstensi Chrome, Anda akan menemukan ikon Whispering di bilah ekstensi Chrome. Klik ikon ini untuk membuka ekstensi. Klik tombol mikrofon untuk merekam suara Anda, lalu klik tombol kotak saat selesai. Transkripsi Anda akan muncul di kotak teks di bawah.

Untuk mengakses fitur ChatGPT atau Claude, buka halaman web ChatGPT atau Claude. Anda akan melihat tombol rekam baru di antarmuka chat. Klik tombol ini untuk memulai dan menghentikan rekaman, dan teks hasil transkripsi akan otomatis dimasukkan ke kolom input chat.

Untuk mengakses fitur pintasan, tekan <kbd>Control</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> atau <kbd>Command</kbd> + <kbd>Shift</kbd> + <kbd>X</kbd> (dapat dikonfigurasi kemudian melalui pintasan ekstensi Chrome) untuk mulai merekam dari situs web mana pun. Transkripsi akan otomatis disalin ke clipboard dan ditempel ke kolom input saat ini.

Ekstensi Chrome berkomunikasi dengan [whispering.bradenwong.com](https://whispering.bradenwong.com), dan secara otomatis akan mencoba membuat tab di latar belakang jika tidak menemukan tab yang sudah ada. Sebagian besar bug biasanya disebabkan kegagalan komunikasi ini, seperti kasus langka di mana tab tertidur.

### Aplikasi Web

Aplikasi web dapat diakses melalui [whispering.bradenwong.com](https://whispering.bradenwong.com). Klik tombol mikrofon untuk merekam suara Anda, lalu klik tombol kotak saat selesai. Transkripsi Anda akan muncul di kotak teks.

### Aplikasi Desktop

Setelah menginstal aplikasi desktop Whispering, tekan <kbd>Control/Command</kbd> + <kbd>Shift</kbd> + <kbd>;</kbd> (dapat dikonfigurasi di pengaturan) untuk mulai merekam dari mana saja di desktop Anda. Transkripsi akan otomatis disalin ke clipboard dan ditempelkan, meskipun kedua fitur ini dapat diatur di pengaturan.

## Dibangun Dengan

#### Web dan Desktop

Aplikasi Whispering dibangun menggunakan teknologi dan pustaka berikut:

- [Svelte 5](https://svelte.dev): Library reaktivitas UI pilihan.
- [SvelteKit](https://kit.svelte.dev/docs): Untuk routing dan pembuatan situs statis, digunakan untuk membuat website dan frontend statis aplikasi Tauri.
- [Tauri](https://tauri.studio/en/docs/intro/): Framework aplikasi desktop.
- [Effect-TS](https://github.com/Effect-TS/effect): Untuk menambahkan pemrograman fungsional dan menulis fungsi yang sangat aman secara tipe, di mana error disertakan dalam tipe hasil fungsi.
- [Svelte Sonner](https://svelte-sonner.vercel.app/): Pustaka toast sederhana dan dapat dikustomisasi untuk aplikasi Svelte. Digunakan untuk menangkap dan menampilkan error yang muncul lewat Effect-TS menggunakan fungsi `renderAsToast`.
- [TanStack Table](https://tanstack.com/table): Untuk menjalankan seluruh data tabel.
- [IndexedDB](https://developer.mozilla.org/en-US/docs/Web/API/IndexedDB_API): API tingkat rendah untuk menyimpan banyak data terstruktur di browser. Disinkronkan dengan Tanstack Table.
- [ShadCN-Svelte](https://github.com/huntabyte/shadcn-svelte): Library komponen UI pilihan.
- [TailwindCSS](https://tailwindcss.com/docs): Framework CSS utility-first untuk membangun antarmuka pengguna secara cepat.
- [Turborepo](https://turborepo.org/): Untuk manajemen monorepo, sehingga `apps/app` dan `apps/extension` dapat berbagi basis kode yang sama, secara drastis mengurangi duplikasi kode dan yang terpenting, menjaga satu sumber kebenaran.
- [Rust](https://www.rust-lang.org): Untuk memperluas fitur aplikasi desktop, seperti menggunakan crate `enigo` untuk menangani tempel otomatis.
- [Vercel](https://vercel.com/): Hosting yang cocok untuk proyek hobi dan terintegrasi baik dengan Turborepo.
- [Zapsplat.com](https://www.zapsplat.com/): Library efek suara bebas royalti.

#### Ekstensi

Ekstensi Chrome Whispering dibangun menggunakan:

- [Plasmo](https://docs.plasmo.com/): Framework untuk membangun ekstensi Chrome. Kami menggunakan [relay flow](https://docs.plasmo.com/framework/messaging#relay-flow) untuk berkomunikasi dengan situs web Whispering.
- [Effect-TS](https://github.com/Effect-TS/effect): Untuk menambahkan pemrograman fungsional dan menulis fungsi yang sangat aman secara tipe, di mana error disertakan dalam tipe hasil fungsi.
- [React](https://reactjs.org): Library reaktivitas UI untuk ekstensi Chrome, karena Plasmo sayangnya belum mendukung Svelte 5.
- [ShadCN](https://github.com/shadcn): Library komponen UI untuk ekstensi Chrome.
- [TailwindCSS](https://tailwindcss.com/docs): Sebuah framework CSS utility-first untuk membangun antarmuka pengguna kustom dengan cepat.
- [Chrome API](https://developer.chrome.com/docs/extensions/reference/): API ekstensi Chrome.
- [Zapsplat.com](https://www.zapsplat.com/): Pustaka efek suara bebas royalti.

## Menjalankan Whispering dalam Mode Pengembangan Lokal

Untuk mengatur proyek di mesin lokal Anda, ikuti langkah-langkah berikut:

1. Clone repositorinya: `git clone https://github.com/braden-w/whispering.git`
2. Masuk ke direktori proyek: `cd whispering`
3. Instal dependensi yang diperlukan: `pnpm i`

Untuk menjalankan aplikasi desktop dan website Whispering dalam mode pengembangan:

4. Masuk ke direktori aplikasi: `cd apps/app`
5. Jalankan server pengembangan: `pnpm tauri dev`

Aplikasi desktop akan terbuka secara otomatis untuk pengembangan lokal. Untuk mengembangkan aplikasi web, buka browser Anda dan buka `http://localhost:5173`.

Untuk menjalankan ekstensi Chrome Whispering dalam mode pengembangan:

4. Masuk ke direktori ekstensi: `cd apps/extension`
5. Jalankan server pengembangan: `pnpm dev --target=chrome-mv3`

Untuk mengembangkan ekstensi Chrome, muat ke Chrome dengan membuka `chrome://extensions`, aktifkan mode pengembang, dan muat folder `apps/extension/build/{platform}-{manifest-version}-dev` sebagai ekstensi yang tidak terpaket.

## Bangun Eksekusi Sendiri

Jika Anda memiliki kekhawatiran terkait kepercayaan pada installer atau ingin kontrol lebih, Anda selalu dapat membangun eksekusi sendiri. Ini membutuhkan lebih banyak pengaturan, tetapi memastikan bahwa Anda menjalankan kode yang Anda harapkan. Inilah keindahan perangkat lunak open-source!

### Chrome

1. Masuk ke direktori ekstensi: `cd apps/extension`
2. Instal dependensi yang diperlukan: `pnpm i`
3. Jalankan Plasmo build: `pnpm plasmo build --target=chrome-mv3`
4. Hasil output dapat ditemukan di `apps/extension/build/chrome-mv3-prod`, yang dapat dimuat ke Chrome sebagai ekstensi yang tidak terpaket.
5. Atau, Anda dapat membangun ekstensi untuk Chrome Web Store: `pnpm plasmo build --target=chrome-mv3 --release`

### Firefox

1. Masuk ke direktori ekstensi: `cd apps/extension`
2. Instal dependensi yang diperlukan: `pnpm i`
3. Jalankan Plasmo build: `pnpm plasmo build --target=firefox-mv3`
4. Hasil output dapat ditemukan di `apps/extension/build/firefox-mv3-prod`, yang dapat dimuat ke Chrome sebagai ekstensi yang tidak terpaket.
5. Atau, Anda dapat membangun ekstensi untuk Chrome Web Store: `pnpm plasmo build --target=firefox-mv3 --release`

### Desktop

1. Masuk ke direktori aplikasi: `cd apps/app`
2. Instal dependensi yang diperlukan: `pnpm i`
3. Jalankan Tauri Build: `pnpm tauri build`
4. Anda dapat menemukan file eksekusi di direktori `apps/app/target/release`.

## Kontribusi

Kami menyambut kontribusi dari komunitas! Jika Anda ingin berkontribusi pada Whispering, silakan ikuti langkah-langkah berikut:

1. Fork repositorinya.
2. Buat branch baru untuk fitur atau perbaikan bug Anda: `git checkout -b feature/your-feature-name` atau `git checkout -b fix/your-bugfix-name`
3. Lakukan perubahan dan commit dengan pesan yang deskriptif.
4. Push branch Anda ke repository hasil fork Anda: `git push origin your-branch-name`
5. Buat pull request dari repository hasil fork Anda ke repository asli.

Pastikan kode Anda mengikuti konvensi yang telah ditetapkan dan didokumentasikan dengan baik.

## Lisensi

Whispering dirilis di bawah [Lisensi MIT](https://opensource.org/licenses/MIT).

## Sponsor

Proyek ini didukung oleh orang-orang dan organisasi luar biasa berikut:

<!-- sponsors --><a href="https://github.com/DavidGP"><img src="https://github.com/DavidGP.png" width="60px" alt="" /></a><a href="https://github.com/cgbur"><img src="https://github.com/cgbur.png" width="60px" alt="Chris Burgess" /></a><a href="https://github.com/Wstnn"><img src="https://github.com/Wstnn.png" width="60px" alt="" /></a><a href="https://github.com/rkhrkh"><img src="https://github.com/rkhrkh.png" width="60px" alt="" /></a><a href="https://github.com/doxgt"><img src="https://github.com/doxgt.png" width="60px" alt="" /></a><a href="https://github.com/worldoptimizer"><img src="https://github.com/worldoptimizer.png" width="60px" alt="Max Ziebell" /></a><a href="https://github.com/AlpSantoGlobalMomentumLLC"><img src="https://github.com/AlpSantoGlobalMomentumLLC.png" width="60px" alt="" /></a><!-- sponsors -->

## Dukungan dan Masukan

Jika Anda menemukan masalah atau memiliki saran untuk perbaikan, silakan buka issue pada [tab issues GitHub](https://github.com/braden-w/whispering/issues) atau hubungi saya melalui [whispering@bradenwong.com](mailto:whispering@bradenwong.com). Saya sangat menghargai masukan Anda!

Terima kasih telah menggunakan Whispering dan selamat menulis!

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---