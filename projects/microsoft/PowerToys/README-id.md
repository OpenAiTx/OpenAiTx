# Microsoft PowerToys

![Gambar utama Microsoft PowerToys](doc/images/overview/PT_hero_image.png)

[Cara menggunakan PowerToys][usingPowerToys-docs-link] | [Unduhan & Catatan Rilis][github-release-link] | [Berkontribusi pada PowerToys](#contributing) | [Apa yang Sedang Terjadi](#whats-happening) | [Peta Jalan](#powertoys-roadmap)

## Tentang

Microsoft PowerToys adalah serangkaian utilitas untuk pengguna tingkat lanjut untuk menyesuaikan dan menyederhanakan pengalaman Windows mereka demi meningkatkan produktivitas. Untuk info lebih lanjut tentang [ikhtisar PowerToys dan cara menggunakan utilitas][usingPowerToys-docs-link], atau alat dan sumber daya lain untuk [lingkungan pengembangan Windows](https://learn.microsoft.com/windows/dev-environment/overview), kunjungi [learn.microsoft.com][usingPowerToys-docs-link]!

|              | Utilitas saat ini: |              |
|--------------|--------------------|--------------|
| [Advanced Paste](https://aka.ms/PowerToysOverview_AdvancedPaste) | [Always on Top](https://aka.ms/PowerToysOverview_AoT) | [PowerToys Awake](https://aka.ms/PowerToysOverview_Awake) |
| [Color Picker](https://aka.ms/PowerToysOverview_ColorPicker) | [Command Not Found](https://aka.ms/PowerToysOverview_CmdNotFound) | [Command Palette](https://aka.ms/PowerToysOverview_CmdPal) |
| [Crop And Lock](https://aka.ms/PowerToysOverview_CropAndLock) | [Environment Variables](https://aka.ms/PowerToysOverview_EnvironmentVariables) | [FancyZones](https://aka.ms/PowerToysOverview_FancyZones) |
| [File Explorer Add-ons](https://aka.ms/PowerToysOverview_FileExplorerAddOns) | [File Locksmith](https://aka.ms/PowerToysOverview_FileLocksmith) | [Hosts File Editor](https://aka.ms/PowerToysOverview_HostsFileEditor) |
| [Image Resizer](https://aka.ms/PowerToysOverview_ImageResizer) | [Keyboard Manager](https://aka.ms/PowerToysOverview_KeyboardManager) | [Mouse utilities](https://aka.ms/PowerToysOverview_MouseUtilities) |
| [Mouse Without Borders](https://aka.ms/PowerToysOverview_MouseWithoutBorders) | [New+](https://aka.ms/PowerToysOverview_NewPlus) | [Paste as Plain Text](https://aka.ms/PowerToysOverview_PastePlain) |
| [Peek](https://aka.ms/PowerToysOverview_Peek) | [PowerRename](https://aka.ms/PowerToysOverview_PowerRename) | [PowerToys Run](https://aka.ms/PowerToysOverview_PowerToysRun) |
| [Quick Accent](https://aka.ms/PowerToysOverview_QuickAccent) | [Registry Preview](https://aka.ms/PowerToysOverview_RegistryPreview) | [Screen Ruler](https://aka.ms/PowerToysOverview_ScreenRuler) |
| [Shortcut Guide](https://aka.ms/PowerToysOverview_ShortcutGuide) | [Text Extractor](https://aka.ms/PowerToysOverview_TextExtractor) | [Workspaces](https://aka.ms/PowerToysOverview_Workspaces) |
| [ZoomIt](https://aka.ms/PowerToysOverview_ZoomIt) |

## Menginstal dan Menjalankan Microsoft PowerToys

### Persyaratan

- Windows 11 atau Windows 10 versi 2004 (kode nama 20H1 / nomor build 19041) atau yang lebih baru.
- Prosesor x64 atau ARM64
- Penginstal kami akan menginstal item berikut:
   - [Microsoft Edge WebView2 Runtime](https://go.microsoft.com/fwlink/p/?LinkId=2124703) bootstrapper. Ini akan menginstal versi terbaru.

### Melalui GitHub dengan EXE [Direkomendasikan]

Buka [halaman rilis Microsoft PowerToys di GitHub][github-release-link] dan klik `Assets` di bagian bawah untuk melihat file yang tersedia pada rilis tersebut. Silakan gunakan penginstal PowerToys yang sesuai dengan arsitektur mesin dan cakupan instalasi Anda. Untuk kebanyakan pengguna, gunakan `x64` dan per pengguna.

<!-- item yang perlu diperbarui setiap rilis -->
[github-next-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.92%22
[github-current-release-work]: https://github.com/microsoft/PowerToys/issues?q=is%3Aissue+milestone%3A%22PowerToys+0.91%22
[ptUserX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-x64.exe 
[ptUserArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysUserSetup-0.91.1-arm64.exe 
[ptMachineX64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-x64.exe 
[ptMachineArm64]: https://github.com/microsoft/PowerToys/releases/download/v0.91.1/PowerToysSetup-0.91.1-arm64.exe
 
|  Deskripsi   | Nama file | hash sha256 |
|--------------|-----------|-------------|
| Per pengguna - x64       | [PowerToysUserSetup-0.91.1-x64.exe][ptUserX64] | 42EA4A3E8C79A5456476D19E72B3E2AB9393A89C4DC7442EB7EE5A1E3490D38A |
| Per pengguna - ARM64     | [PowerToysUserSetup-0.91.1-arm64.exe][ptUserArm64] | F3F433FE04049F9197411D792AADEBF34E3BE7FE16327BD8B73D2A046ED8BAF6 |
| Seluruh mesin - x64      | [PowerToysSetup-0.91.1-x64.exe][ptMachineX64] | EC4BC3A8625775866B0ED4577CCF83E6EC7B1A0AD267379DDBAF4FE49C7B5BDD |
| Seluruh mesin - ARM64    | [PowerToysSetup-0.91.1-arm64.exe][ptMachineArm64] | 9CB8911008420D0E446AE3D5CE365E447FA4DF9DCF9337F3A80F933C00FC3689 |

Ini adalah metode yang kami rekomendasikan.

### Melalui Microsoft Store

Instal dari [halaman PowerToys di Microsoft Store][microsoft-store-link]. Anda harus menggunakan [Microsoft Store baru](https://blogs.windows.com/windowsExperience/2021/06/24/building-a-new-open-microsoft-store-on-windows-11/) yang tersedia untuk Windows 11 dan Windows 10.

### Melalui WinGet
Unduh PowerToys dari [WinGet][winget-link]. Memperbarui PowerToys melalui winget akan mengikuti cakupan instalasi PowerToys yang saat ini ada. Untuk menginstal PowerToys, jalankan perintah berikut dari command line / PowerShell:

#### Penginstal cakupan pengguna [default]
```powershell
winget install Microsoft.PowerToys -s winget
```

#### Penginstal cakupan seluruh mesin

```powershell
winget install --scope machine Microsoft.PowerToys -s winget
```

### Metode instalasi lainnya

Terdapat [metode instalasi berbasis komunitas](./doc/unofficialInstallMethods.md) seperti Chocolatey dan Scoop. Jika metode ini menjadi pilihan Anda, instruksi instalasinya dapat ditemukan di sana.

## Plugin Run Pihak Ketiga

Terdapat kumpulan [plugin pihak ketiga](./doc/thirdPartyRunPlugins.md) yang dibuat oleh komunitas dan tidak didistribusikan bersama PowerToys.

## Berkontribusi

Proyek ini menerima kontribusi dari semua jenis. Selain penambahan fitur/pembaruan bug melalui pemrograman, cara lain untuk membantu termasuk penulisan spesifikasi, desain, dokumentasi, dan menemukan bug. Kami sangat antusias bekerja sama dengan komunitas power user untuk membangun serangkaian alat agar Anda dapat memaksimalkan penggunaan Windows.

Kami meminta agar **sebelum Anda mulai mengerjakan fitur yang ingin Anda kontribusikan**, silakan baca [Panduan Kontributor](CONTRIBUTING.md) kami. Kami dengan senang hati akan bekerja sama dengan Anda untuk menemukan pendekatan terbaik, memberikan panduan dan pendampingan selama pengembangan fitur, serta membantu menghindari usaha yang sia-sia atau duplikasi.

Sebagian besar kontribusi mengharuskan Anda menyetujui [Perjanjian Lisensi Kontributor (CLA)][oss-CLA] yang menyatakan bahwa Anda memberikan kami hak untuk menggunakan kontribusi Anda dan bahwa Anda memiliki izin untuk melakukannya.

Untuk panduan pengembangan PowerToys, silakan baca [dokumen pengembang](/doc/devdocs) untuk penjelasan terperinci. Termasuk cara menyiapkan komputer Anda agar dapat melakukan kompilasi.

## Apa yang Sedang Terjadi

### Peta Jalan PowerToys

[Peta jalan prioritas][roadmap] fitur dan utilitas yang menjadi fokus tim inti.

### 0.91 - Pembaruan Mei 2025

Pada rilis ini, kami berfokus pada fitur baru, stabilitas, dan otomasi.

**✨Sorotan**

 - Kami berfokus pada peningkatan besar performa Command Palette dan memperbaiki banyak bug. Beberapa fitur baru yang kami tambahkan:
 - Menambahkan kemampuan bagi Command Palette untuk mencari file apa pun menggunakan perintah fallback.
 - Menambahkan kemampuan agar hotkey global Command Palette menjadi low-level keyboard hook.
 - Menambahkan perintah fallback untuk membuka URL pada ekstensi WebSearch, memungkinkan pengguna langsung membuka URL di browser dari Command Palette.
 - Anda kini dapat mendefinisikan format kustom pada plugin Tanggal dan Waktu di PT Run dan Command Palette. Terima kasih [@htcfreek](https://github.com/htcfreek)!

### Advanced Paste

 - Memperbaiki masalah di mana Advanced Paste gagal membuat mesin OCR untuk tag bahasa Inggris tertentu (misalnya, en-CA) dengan menginisialisasi mesin OCR menggunakan bahasa profil pengguna. Terima kasih [@cryolithic](https://github.com/cryolithic)!

### Color Picker

 - Memperbaiki masalah kebocoran sumber daya yang menyebabkan hang atau crash dengan membuang objek Graphics dengan benar. Terima kasih [@dcog989](https://github.com/dcog989)!
 - Memperbaiki masalah di mana Color Picker keluar saat tombol Backspace ditekan dengan memastikan hanya menutup saat fokus dan menyamakan perilaku Escape/Backspace. Terima kasih [@PesBandi](https://github.com/PesBandi)!
 - Menambahkan dukungan untuk format warna Oklab dan Oklch di Color Picker. Terima kasih [@lemonyte](https://github.com/lemonyte)!

### Command Not Found

 - Memperbarui skrip WinGet Command Not Found untuk hanya mengaktifkan fitur eksperimental jika memang ada.

### Command Palette

 - Memperbarui template bug untuk memasukkan modul Command Palette.
 - Memperbaiki masalah di mana jendela toast tidak diskalakan untuk DPI, menyebabkan masalah tata letak pada skala tampilan.
 - Memperbaiki masalah di mana navigasi keyboard Atas/Bawah tidak memindahkan seleksi saat caret di posisi 0, dan menambah navigasi berkelanjutan seperti PT Run v1. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!
 - Memperbarui kode ekstensi Waktu dan Tanggal untuk menyederhanakan dan meningkatkan kejelasan.
 - Memperbaiki masalah di mana kapitalisasi pada perintah menyebabkan kegagalan saat mencoba menuju pointer mouse, dengan mengubah perintah ke huruf kecil.
 - Menambahkan perintah fallback untuk membuka URL pada ekstensi WebSearch, memungkinkan pengguna langsung membuka URL di browser dari Command Palette. Terima kasih [@htcfreek](https://github.com/htcfreek)!
 - Menambahkan pengaturan untuk mengaktifkan/nonaktifkan ikon system tray di CmdPal dan menyelaraskan terminologi dengan Windows 11. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!
 - Memperbaiki masalah pembaruan alias dengan menghapus alias lama saat yang baru disetel.
 - Menyelesaikan konflik kapitalisasi GitHub dengan memigrasi Exts dan exts ke direktori ext baru, memastikan struktur konsisten di semua platform dan mencegah fragmentasi path.
 - Memperbaiki masalah di mana perintah 'Create New Extension' menghasilkan nama file kosong.
 - Menambahkan kemampuan agar hotkey global menjadi low-level keyboard hook.
 - Menambahkan dukungan untuk thumbnail JUMBO, memungkinkan akses ke ikon resolusi tinggi.
 - Memperbaiki crash saat CmdPal menyembunyikan diri sendiri secara otomatis saat dialog MSAL terbuka, dengan mencegah CmdPal menyembunyikan diri jika sedang dinonaktifkan.
 - Menambahkan dukungan untuk langsung memilih teks pencarian saat halaman dimuat.
 - Memperbaiki bug di mana halaman pengaturan ekstensi gagal dimuat ulang saat dibuka kembali dengan memperbarui form pengaturan saat pengaturan ekstensi disimpan.
 - Memperbaiki masalah di mana Command Palette gagal diluncurkan dari runner.
 - Melakukan refaktor dan porting logika kalkulator PowerToys Run v1 ke Command Palette, menambahkan dukungan pengaturan, dan memperbaiki perilaku fallback.
 - Menambahkan kembali dukungan untuk pintasan keyboard pada item daftar.
 - Meningkatkan aksesibilitas Command Palette dengan menambahkan label yang tepat, memperbaiki animasi, meningkatkan lokalisasi, dan memperbaiki isu a11y terkait.
 - Memporting dukungan format kustom ke plugin Waktu dan Tanggal, merapikan dan mengurutkan ulang pengaturan, memperbaiki pesan error, serta memperbaiki crash pada kasus tepi untuk perilaku lebih tangguh dan ramah pengguna. Terima kasih [@htcfreek](https://github.com/htcfreek)!
 - Menambahkan item fallback untuk perintah sistem.
 - Memperbaiki bug pada Windows System Command di mana prompt kunci salah menampilkan "Empty" untuk aksi "Open Recycle Bin". Terima kasih [@jironemo](https://github.com/jironemo)!
 - Memperbaiki masalah di mana daftar 'more commands' menampilkan perintah yang seharusnya tidak terlihat. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!
 - Memperbaiki masalah di mana tampilan detail di Command Palette menampilkan ikon yang terlalu besar dan teks tidak rata, menyamakannya dengan perilaku Windows Search.
 - Memperbaiki bug di mana konten layar kosong dan perintah command bar terpotong saat menggunakan label panjang, memastikan tata letak dan visibilitas yang tepat.
 - Meningkatkan integrasi WinGet CmdPal dengan memperbaiki tampilan versi untuk paket yang terinstal, memungkinkan pembaruan dengan ikon, dan memigrasi API preview winget ke versi stabil.
 - Memperbaiki bug di mana perintah untuk ContentPage tidak diperbarui sampai keluar, dengan memastikan menu konteks diinisialisasi penuh saat terjadi perubahan.
 - Menambahkan dukungan fallback ke ekstensi TimeDate, memungkinkan kueri tanggal/waktu langsung tanpa memilih perintah sebelumnya.
 - Menambahkan impor Common.Dotnet.AotCompatibility.props di beberapa file proyek CmdPal untuk meningkatkan dukungan kompilasi AOT.
 - Memperbaiki crash pada pengaturan CmdPal akibat HotKey null saat settings.json hilang atau tidak ada hotkey yang didefinisikan. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!
 - Menambahkan dukungan untuk menu konteks bersarang yang dapat difilter di CmdPal, termasuk kotak pencarian untuk mempertahankan perilaku fokus.
 - Melakukan refaktor kelas CmdPal untuk meningkatkan serialisasi JSON dan memperkenalkan konteks serialisasi baru demi performa dan pemeliharaan yang lebih baik.
 - Menambahkan dukungan untuk kompilasi ahead-of-time (AoT).
 - Menambahkan mekanisme retry untuk peluncuran CmdPal.
 - Menghapus beberapa file yang tidak digunakan dari CmdPal.Common untuk menyederhanakan kode dan memudahkan penandaan sebagai kompatibel AoT.
 - Memperbaiki bug di mana kondisi race pada pembaruan SearchText menyebabkan kursor di kotak input otomatis melompat ke akhir baris, memastikan SearchText hanya diperbarui setelah benar-benar berubah.
 - Menambahkan dukungan pencarian file apa pun di perintah fallback.
 - Merapikan kode terkait AoT untuk mencegah operasi duplikat selama pengujian.
 - Mengurangi waktu load CmdPal dengan memparalelkan startup ekstensi dan menambahkan timeout agar ekstensi bermasalah tidak memblokir yang lain.
 - Meningkatkan perilaku UI dengan menutup detail pane saat daftar dikosongkan, menghindari keadaan visual yang tidak konsisten.
 - Menambahkan dukungan untuk menghapus setelan perintah fallback di CmdPal saat tidak ada perintah yang cocok, memastikan perilaku reload yang lebih bersih.
 - Memperbaiki kebocoran pada template ekstensi CmdPal dengan memperbaiki penggunaan ComServer yang salah.
 - Mencegah jendela CmdPal memaksimalkan diri saat bar judul diklik dua kali untuk mempertahankan perilaku jendela yang diinginkan. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!
 - Memperbaiki masalah di mana antarmuka Settings diluncurkan terlalu kecil dengan membuat dimensi jendela sadar DPI dan menerapkan lebar serta tinggi minimum menggunakan WinUIEx.
 - Memperbaiki flash putih dan animasi satu kali di CmdPal dengan menyamarkan jendela alih-alih menyembunyikannya.
 - Memperbaiki bug di mana semua pengaturan ekstensi diambil saat startup dengan memuat pengaturan ekstensi secara lambat, sehingga mengurangi beban inisialisasi.
 - Menambahkan perlindungan pada CmdPal dari crash akibat kegagalan parsing Adaptive Card.
 - Mengganti shell:AppsFolder dengan URI activation di CmdPal untuk meningkatkan keandalan.
 - Menambahkan kemampuan membuka pengaturan CmdPal dari PowerToys Settings.
 - Menambahkan kemampuan bagi CmdPal untuk mengamati dan memperbarui detail ekstensi secara dinamis dengan melacak perubahan properti pada item yang dipilih.
 - Memperbarui versi toolkit yang digunakan pada template ekstensi CmdPal menjadi 0.2.0.

### Image Resizer

 - Memperbaiki masalah di mana menghapus preset Image Resizer justru menghapus preset yang salah.

### Keyboard Manager

 - Memperbaiki masalah di mana tombol modifier, saat disetel tanpa menentukan kiri atau kanan, menjadi macet karena penanganan kunci yang salah, dengan melacak tombol yang ditekan dan mengirimkan kunci yang benar sesuai urutan. Terima kasih [@mantaionut](https://github.com/mantaionut)!

### PowerRename

 - Meningkatkan kemampuan format waktu PowerRename dengan menambahkan pola format waktu 12 jam dengan dukungan AM/PM. Terima kasih [@bitmap4](https://github.com/bitmap4)!

### PowerToys Run

 - Menambahkan dukungan untuk format kustom pada plugin "Time and Date" dan meningkatkan pesan error untuk format input yang tidak valid. Terima kasih [@htcfreek](https://github.com/htcfreek)!
 - Memperbaiki dua crash: satu untuk WFT pada tanggal sangat awal dan satu lagi untuk perhitungan minggu bulan pada tanggal sangat akhir (misal, 31.12.9999), serta mengurutkan ulang pengaturan UI. Terima kasih [@htcfreek](https://github.com/htcfreek)!
 - Memperbaiki masalah di mana kapitalisasi pada perintah menyebabkan kegagalan saat mencoba menuju pointer mouse, dengan mengubah perintah ke huruf kecil.
 - Menambahkan detail versi ke pesan error plugin untuk 'Loading error' dan 'Init error'. Terima kasih [@htcfreek](https://github.com/htcfreek)!
 - Meningkatkan model hasil dengan menambahkan dukungan untuk mencegah pengurutan berbasis penggunaan, memberi pengembang plugin kontrol lebih besar atas perilaku pengurutan. Terima kasih [@CoreyHayward](https://github.com/CoreyHayward) dan [@htcfreek](https://github.com/htcfreek)!

### Quick Accent

 - Memperbarui pemetaan huruf pada GetDefaultLetterKeyEPO, menggantikan "ǔ" dengan "ŭ" untuk tombol VK_U guna mencerminkan fonetik Esperanto dengan akurat. Terima kasih [@OlegKharchevkin](https://github.com/OlegKharchevkin)!
 - Memperbaiki masalah di mana Quick Accent tidak berfungsi dengan baik saat menggunakan keyboard di layar. Terima kasih [@davidegiacometti](https://github.com/davidegiacometti)!

### Registry Preview

 - Meningkatkan Registry Preview agar mendukung penempelan kunci dan nilai registry tanpa menulis header file secara manual, serta menambahkan tombol baru untuk mereset aplikasi. Terima kasih [@htcfreek](https://github.com/htcfreek)!

### Settings

 - Memperbaiki masalah di mana aplikasi Settings secara acak menampilkan ikon kosong di taskbar dengan menunda penetapan ikon hingga jendela diaktifkan.
 - Menambahkan kemampuan untuk memaksimalkan jendela "What's New" agar pengalaman membaca lebih nyaman.

### Workspaces

 - Memperbaiki bug di mana game Steam tidak terdeteksi atau dijalankan dengan benar dengan memperbarui filter jendela dan mengintegrasikan penanganan protokol URL Steam.

### Dokumentasi

 - Menambahkan QuickNotes ke dokumentasi plugin pihak ketiga untuk PowerToys Run. Terima kasih [@ruslanlap](https://github.com/ruslanlap)!
 - Menambahkan plugin Cuaca dan Pomodoro ke dokumentasi plugin pihak ketiga PowerToys Run. Terima kasih [@ruslanlap](https://github.com/ruslanlap)!
 - Menambahkan plugin Linear ke dokumentasi plugin pihak ketiga PowerToys Run. Terima kasih [@vednig](https://github.com/vednig)!
 - Memperbaiki masalah format pada file dokumentasi serta memperbarui informasi kontributor dan anggota tim. Terima kasih [@DanielEScherzer](https://github.com/DanielEScherzer) dan [@RokyZevon](https://github.com/RokyZevon)!

### Pengembangan

 - Memperbarui GitHub Action untuk menginstal .NET 9 demi dukungan rilis MSStore.
 - Memperbarui placeholder versi pada bug_report.yml untuk mencegah penggunaan versi v0.70.0 yang salah pada pelaporan masalah.
 - Memperbarui GitHub Action dengan meningkatkan actions/setup-dotnet dari versi 3 ke versi 4 untuk rilis MSStore.
 - Menambahkan securityContext ke file konfigurasi WinGet, memungkinkan pemanggilan dari konteks pengguna dan meminta satu UAC untuk sumber daya yang membutuhkan hak istimewa dalam proses terpisah. Terima kasih [@mdanish-kh](https://github.com/mdanish-kh)!
 - Mengubah ekstensi file log dari .txt ke .log untuk mendukung asosiasi file yang tepat dan kompatibilitas alat, serta menambahkan log untuk Workspace. Terima kasih [@benwa](https://github.com/benwa)!
 - Meningkatkan dependensi framework pengujian dan menyelaraskan versi paket di seluruh komponen.
 - Meningkatkan dependensi untuk memperbaiki kerentanan.
 - Meningkatkan keamanan repositori dengan menyematkan GitHub Actions dan tag Docker ke commit panjang yang tidak dapat diubah serta mengintegrasikan pemindaian kerentanan dependensi secara otomatis melalui Dependency Review Workflow. Terima kasih [@Nick2bad4u](https://github.com/Nick2bad4u)!
 - Meningkatkan dependensi Boost ke versi lebih baru.
 - Meningkatkan toolkit ke versi terbaru, menyembunyikan peringatan terkait AoT.
 - Memperbaiki masalah di mana file yang baru ditambahkan tidak ditandatangani sehingga menyebabkan kegagalan build.
 - Memperbarui pipeline rilis untuk mencegah publikasi simbol privat selama 100 tahun.
 - Memperkenalkan fuzzing untuk PowerRename demi meningkatkan keandalan dan menambahkan panduan setup untuk memperluas fuzzing ke modul C++ lain.
 - Menambahkan pra-pembuatan terpusat untuk folder yang dihasilkan di semua proyek .csproj untuk mencegah kegagalan build.
 - Memperbarui WinAppSDK ke versi 1.7 terbaru.
 - Meningkatkan dependensi Boost ke versi terbaru untuk proyek PowerRename Fuzzing.
 - Memperbarui area path ADO di tsa.json untuk menyelesaikan error pipeline TSA akibat path yang sudah usang.
 - Memulai dukungan AoT untuk CmdPal dengan pekerjaan dasar yang sedang berlangsung.
  
### Alat/Umum

 - Menambahkan dukungan untuk mengotomasi pembuatan laporan bug dengan menghasilkan URL issue GitHub yang sudah terisi informasi sistem dan diagnostik. Terima kasih [@donlaci](https://github.com/donlaci)!
 - Menambahkan skrip untuk membangun penginstal secara lokal, memastikan CmdPal juga dapat dijalankan di lingkungan lokal.
 - Menghapus logika ekspor PFX untuk menghilangkan penggunaan password hardcoded dan menyelesaikan peringatan keamanan PSScriptAnalyzer.
 - Menambahkan skrip PowerShell dan integrasi CI untuk menegakkan penggunaan konsisten Common.Dotnet.CsWinRT.props di semua proyek C# di bawah folder src.
   
### Apa yang Direncanakan untuk Versi 0.92

Untuk [v0.92][github-next-release-work], kami akan mengerjakan item berikut:

 - Polesan lanjutan pada Command Palette
 - Pengujian Otomasi UI baru
 - Peningkatan penginstal
 - Peningkatan UI editor Keyboard Manager
 - Stabilitas / perbaikan bug

## Komunitas PowerToys

Tim PowerToys sangat berterima kasih atas [dukungan komunitas aktif yang luar biasa][community-link]. Kontribusi Anda sangatlah penting. PowerToys tidak akan menjadi seperti sekarang tanpa bantuan Anda melaporkan bug, memperbarui dokumentasi, mengarahkan desain, atau menulis fitur. Kami ingin mengucapkan terima kasih dan meluangkan waktu untuk mengapresiasi kerja Anda. Bulan demi bulan, Anda secara langsung membantu membuat PowerToys menjadi perangkat lunak yang lebih baik.

## Kode Etik

Proyek ini telah mengadopsi [Microsoft Open Source Code of Conduct][oss-conduct-code].

## Pernyataan Privasi

Aplikasi ini mencatat data diagnostik dasar (telemetri). Untuk informasi lebih lanjut mengenai privasi dan apa saja yang kami kumpulkan, lihat [dokumentasi Data dan Privasi PowerToys](https://aka.ms/powertoys-data-and-privacy-documentation).

[oss-CLA]: https://cla.opensource.microsoft.com
[oss-conduct-code]: CODE_OF_CONDUCT.md
[community-link]: COMMUNITY.md
[github-release-link]: https://aka.ms/installPowerToys
[microsoft-store-link]: https://aka.ms/getPowertoys
[winget-link]: https://github.com/microsoft/winget-cli#installing-the-client
[roadmap]: https://github.com/microsoft/PowerToys/wiki/Roadmap
[privacy-link]: http://go.microsoft.com/fwlink/?LinkId=521839
[loc-bug]: https://github.com/microsoft/PowerToys/issues/new?assignees=&labels=&template=translation_issue.md&title=
[usingPowerToys-docs-link]: https://aka.ms/powertoys-docs

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---