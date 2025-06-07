![terminal-logos](https://github.com/microsoft/terminal/assets/91625426/333ddc76-8ab2-4eb4-a8c0-4d7b953b1179)

[![Terminal Build Status](https://dev.azure.com/shine-oss/terminal/_apis/build/status%2FTerminal%20CI?branchName=main)](https://dev.azure.com/shine-oss/terminal/_build/latest?definitionId=1&branchName=main)

# Selamat Datang di Repo Windows Terminal, Console, dan Command-Line

<details>
  <summary><strong>Daftar Isi</strong></summary>

- [Menginstal dan menjalankan Windows Terminal](#menginstal-dan-menjalankan-windows-terminal)
  - [Microsoft Store \[Direkomendasikan\]](#microsoft-store-direkomendasikan)
  - [Metode instalasi lain](#metode-instalasi-lain)
    - [Melalui GitHub](#melalui-github)
    - [Melalui Windows Package Manager CLI (alias winget)](#melalui-windows-package-manager-cli-alias-winget)
    - [Melalui Chocolatey (tidak resmi)](#melalui-chocolatey-tidak-resmi)
    - [Melalui Scoop (tidak resmi)](#melalui-scoop-tidak-resmi)
- [Menginstal Windows Terminal Canary](#menginstal-windows-terminal-canary)
- [Roadmap Windows Terminal](#roadmap-windows-terminal)
- [Gambaran Terminal & Console](#gambaran-terminal--console)
  - [Windows Terminal](#windows-terminal)
  - [Windows Console Host](#windows-console-host)
  - [Komponen Bersama](#komponen-bersama)
  - [Membuat Windows Terminal Baru](#membuat-windows-terminal-baru)
- [Sumber Daya](#sumber-daya)
- [FAQ](#faq)
  - [Saya membangun dan menjalankan Terminal baru, tapi tampilannya sama seperti konsol lama](#saya-membangun-dan-menjalankan-terminal-baru-tapi-tampilannya-sama-seperti-konsol-lama)
- [Dokumentasi](#dokumentasi)
- [Kontribusi](#kontribusi)
- [Berkomunikasi dengan Tim](#berkomunikasi-dengan-tim)
- [Panduan Pengembang](#panduan-pengembang)
- [Prasyarat](#prasyarat)
- [Membangun Kode](#membangun-kode)
  - [Membangun di PowerShell](#membangun-di-powershell)
  - [Membangun di Cmd](#membangun-di-cmd)
- [Menjalankan & Debugging](#menjalankan--debugging)
  - [Panduan Pengkodean](#panduan-pengkodean)
- [Kode Etik](#kode-etik)

</details>

<br />

Repositori ini berisi kode sumber untuk:

* [Windows Terminal](https://aka.ms/terminal)
* [Windows Terminal Preview](https://aka.ms/terminal-preview)
* Windows console host (`conhost.exe`)
* Komponen yang digunakan bersama antara kedua proyek
* [ColorTool](./src/tools/ColorTool)
* [Proyek contoh](./samples)
  yang menunjukkan cara menggunakan Windows Console API

Repositori terkait meliputi:

* [Dokumentasi Windows Terminal](https://docs.microsoft.com/windows/terminal)
  ([Repo: Berkontribusi pada dokumen](https://github.com/MicrosoftDocs/terminal))
* [Dokumentasi Console API](https://github.com/MicrosoftDocs/Console-Docs)
* [Font Cascadia Code](https://github.com/Microsoft/Cascadia-Code)

## Menginstal dan menjalankan Windows Terminal

> [!NOTE]
> Windows Terminal memerlukan Windows 10 2004 (build 19041) atau yang lebih baru

### Microsoft Store [Direkomendasikan]

Instal [Windows Terminal dari Microsoft Store][store-install-link].
Ini memungkinkan Anda selalu mendapatkan versi terbaru saat kami merilis build baru
dengan pembaruan otomatis.

Ini adalah metode yang kami rekomendasikan.

### Metode instalasi lain

#### Melalui GitHub

Untuk pengguna yang tidak dapat menginstal Windows Terminal dari Microsoft Store,
build yang dirilis dapat diunduh secara manual dari [halaman Rilis](https://github.com/microsoft/terminal/releases) repositori ini.

Unduh file `Microsoft.WindowsTerminal_<versionNumber>.msixbundle` dari bagian **Assets**. Untuk menginstal aplikasi, Anda cukup klik dua kali pada file `.msixbundle`, dan penginstal aplikasi akan berjalan secara otomatis. Jika gagal karena alasan apa pun, Anda dapat mencoba perintah berikut di PowerShell:

```powershell
# CATATAN: Jika Anda menggunakan PowerShell 7+, silakan jalankan
# Import-Module Appx -UseWindowsPowerShell
# sebelum menggunakan Add-AppxPackage.

Add-AppxPackage Microsoft.WindowsTerminal_<versionNumber>.msixbundle
```

> [!NOTE]
> Jika Anda menginstal Terminal secara manual:
>
> * Anda mungkin perlu menginstal [VC++ v14 Desktop Framework Package](https://docs.microsoft.com/troubleshoot/cpp/c-runtime-packages-desktop-bridge#how-to-install-and-update-desktop-framework-packages).
>   Ini biasanya hanya diperlukan pada build Windows 10 yang lebih lama dan hanya jika Anda mendapatkan error terkait paket framework yang hilang.
> * Terminal tidak akan melakukan pembaruan otomatis saat build baru dirilis, jadi Anda harus
>   secara rutin menginstal rilis Terminal terbaru untuk mendapatkan semua perbaikan dan peningkatan terbaru!

#### Melalui Windows Package Manager CLI (alias winget)

Pengguna [winget](https://github.com/microsoft/winget-cli) dapat mengunduh dan menginstal
rilis Terminal terbaru dengan menginstal paket `Microsoft.WindowsTerminal`:

```powershell
winget install --id Microsoft.WindowsTerminal -e
```

> [!NOTE]
> Dukungan dependensi tersedia di WinGet versi [1.6.2631 atau lebih baru](https://github.com/microsoft/winget-cli/releases). Untuk menginstal rilis stabil Terminal 1.18 atau lebih baru, pastikan Anda memiliki versi terbaru dari klien WinGet.

#### Melalui Chocolatey (tidak resmi)

Pengguna [Chocolatey](https://chocolatey.org) dapat mengunduh dan menginstal rilis Terminal terbaru dengan menginstal paket `microsoft-windows-terminal`:

```powershell
choco install microsoft-windows-terminal
```

Untuk memperbarui Windows Terminal menggunakan Chocolatey, jalankan perintah berikut:

```powershell
choco upgrade microsoft-windows-terminal
```

Jika Anda mengalami masalah saat menginstal/memperbarui paket, silakan kunjungi [halaman paket Windows Terminal](https://chocolatey.org/packages/microsoft-windows-terminal) dan ikuti [proses triase Chocolatey](https://chocolatey.org/docs/package-triage-process)

#### Melalui Scoop (tidak resmi)

Pengguna [Scoop](https://scoop.sh) dapat mengunduh dan menginstal rilis Terminal terbaru dengan menginstal paket `windows-terminal`:

```powershell
scoop bucket add extras
scoop install windows-terminal
```

Untuk memperbarui Windows Terminal menggunakan Scoop, jalankan perintah berikut:

```powershell
scoop update windows-terminal
```

Jika Anda mengalami masalah saat menginstal/memperbarui paket, silakan cari atau laporkan di [halaman isu](https://github.com/lukesampson/scoop-extras/issues) dari repositori Scoop Extras bucket.

---

## Menginstal Windows Terminal Canary

Windows Terminal Canary adalah build harian (nightly build) dari Windows Terminal. Build ini memiliki kode terbaru dari cabang `main` kami, memberi Anda kesempatan untuk mencoba fitur-fitur sebelum fitur tersebut masuk ke Windows Terminal Preview.

Windows Terminal Canary adalah versi kami yang paling tidak stabil, sehingga Anda mungkin menemukan bug sebelum kami sempat menemukannya.

Windows Terminal Canary tersedia sebagai distribusi App Installer dan distribusi Portable ZIP.

Distribusi App Installer mendukung pembaruan otomatis. Karena keterbatasan platform, penginstal ini hanya berfungsi di Windows 11.

Distribusi Portable ZIP adalah aplikasi portabel. Tidak akan melakukan pembaruan otomatis dan tidak akan memeriksa pembaruan secara otomatis. Distribusi ZIP portabel ini berfungsi pada Windows 10 (19041+) dan Windows 11.

| Distribusi     | Arsitektur      | Tautan                                               |
|----------------|:---------------:|------------------------------------------------------|
| App Installer  | x64, arm64, x86 | [unduh](https://aka.ms/terminal-canary-installer)    |
| Portable ZIP   | x64             | [unduh](https://aka.ms/terminal-canary-zip-x64)      |
| Portable ZIP   | ARM64           | [unduh](https://aka.ms/terminal-canary-zip-arm64)    |
| Portable ZIP   | x86             | [unduh](https://aka.ms/terminal-canary-zip-x86)      |

_Pelajari lebih lanjut tentang [jenis distribusi Windows Terminal](https://learn.microsoft.com/windows/terminal/distributions)._

---

## Roadmap Windows Terminal

Rencana untuk Windows Terminal [dijelaskan di sini](/doc/roadmap-2023.md) dan
akan diperbarui seiring perkembangan proyek.

## Gambaran Terminal & Console

Silakan luangkan beberapa menit untuk membaca ringkasan di bawah ini sebelum mulai menjelajahi kode:

### Windows Terminal

Windows Terminal adalah aplikasi terminal baru yang modern, kaya fitur, dan produktif untuk pengguna command-line. Ini mencakup banyak fitur yang paling sering diminta oleh komunitas command-line Windows, termasuk dukungan untuk tab, teks kaya, globalisasi, konfigurasi, tema & styling, dan masih banyak lagi.

Terminal juga harus memenuhi tujuan dan tolok ukur kami untuk memastikan tetap cepat dan efisien, serta tidak mengonsumsi banyak memori atau daya.

### Windows Console Host

Windows Console host, `conhost.exe`, adalah pengalaman pengguna command-line asli Windows. Ia juga menjadi host infrastruktur command-line Windows dan server API Windows Console, mesin input, mesin rendering, preferensi pengguna, dll. Kode console host dalam repositori ini adalah sumber asli yang digunakan untuk membangun `conhost.exe` dalam Windows itu sendiri.

Sejak mengambil alih Windows command-line pada tahun 2014, tim telah menambahkan beberapa fitur baru ke Console, termasuk transparansi latar belakang, seleksi berbasis baris, dukungan untuk [sekuens ANSI / Virtual Terminal](https://en.wikipedia.org/wiki/ANSI_escape_code), [warna 24-bit](https://devblogs.microsoft.com/commandline/24-bit-color-in-the-windows-console/), [Pseudoconsole ("ConPTY")](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/), dan lainnya.

Namun, karena tujuan utama Windows Console adalah mempertahankan kompatibilitas ke belakang, kami tidak dapat menambahkan banyak fitur yang diinginkan komunitas (dan tim) selama beberapa tahun terakhir, seperti tab, teks unicode, dan emoji.

Keterbatasan-keterbatasan ini mendorong kami untuk membuat Windows Terminal yang baru.

> Anda dapat membaca lebih lanjut tentang evolusi command-line secara umum, dan command-line Windows secara khusus dalam [seri blog berikut](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/) di blog Tim Command-Line.

### Komponen Bersama

Saat memperbarui Windows Console, kami memodernisasi basis kodenya secara signifikan, memisahkan entitas logis ke dalam modul dan kelas, memperkenalkan beberapa titik ekstensi kunci, mengganti beberapa koleksi dan kontainer buatan lama dengan [kontainer STL](https://docs.microsoft.com/en-us/cpp/standard-library/stl-containers?view=vs-2022) yang lebih aman dan efisien, serta menyederhanakan dan mengamankan kode dengan menggunakan [Windows Implementation Libraries - WIL](https://github.com/Microsoft/wil) dari Microsoft.

Pembaruan ini menghasilkan beberapa komponen utama Console yang dapat digunakan kembali dalam implementasi terminal apa pun di Windows. Komponen ini meliputi mesin tata letak dan rendering teks berbasis DirectWrite yang baru, buffer teks yang mampu menyimpan UTF-16 dan UTF-8, parser/emitter VT, dan lainnya.

### Membuat Windows Terminal Baru

Saat kami mulai merencanakan aplikasi Windows Terminal baru, kami mengeksplorasi dan mengevaluasi beberapa pendekatan dan tumpukan teknologi. Kami akhirnya memutuskan bahwa tujuan kami akan paling baik dicapai dengan melanjutkan investasi kami pada basis kode C++, yang memungkinkan kami menggunakan kembali beberapa komponen modernisasi yang telah disebutkan sebelumnya baik di Console yang ada maupun Terminal baru. Selain itu, kami menyadari bahwa ini akan memungkinkan kami membangun sebagian besar inti Terminal sebagai kontrol UI yang dapat digunakan kembali oleh aplikasi lain.

Hasil dari pekerjaan ini terdapat dalam repo ini dan didistribusikan sebagai aplikasi Windows Terminal yang dapat Anda unduh dari Microsoft Store, atau [langsung dari rilis repo ini](https://github.com/microsoft/terminal/releases).

---

## Sumber Daya

Untuk informasi lebih lanjut tentang Windows Terminal, Anda dapat menemukan beberapa sumber daya berikut berguna dan menarik:

* [Blog Command-Line](https://devblogs.microsoft.com/commandline)
* [Seri Blog Command-Line Backgrounder](https://devblogs.microsoft.com/commandline/windows-command-line-backgrounder/)
* Peluncuran Windows Terminal: [Video "Sizzle" Terminal](https://www.youtube.com/watch?v=8gw0rXPMMPE&list=PLEHMQNlPj-Jzh9DkNpqipDGCZZuOwrQwR&index=2&t=0s)
* Peluncuran Windows Terminal: [Sesi Build 2019](https://www.youtube.com/watch?v=KMudkRcwjCw)
* Run As Radio: [Show 645 - Windows Terminal dengan Richard Turner](https://www.runasradio.com/Shows/Show/645)
* Azure Devops Podcast: [Episode 54 - Kayla Cinnamon dan Rich Turner tentang DevOps di Windows Terminal](http://azuredevopspodcast.clear-measure.com/kayla-cinnamon-and-rich-turner-on-devops-on-the-windows-terminal-team-episode-54)
* Microsoft Ignite 2019 Session: [The Modern Windows Command Line: Windows Terminal - BRK3321](https://myignite.techcommunity.microsoft.com/sessions/81329?source=sessions)

---

## FAQ

### Saya membangun dan menjalankan Terminal baru, tapi tampilannya sama seperti konsol lama

Penyebab: Anda menjalankan solusi yang salah di Visual Studio.

Solusi: Pastikan Anda membangun & menjalankan proyek `CascadiaPackage` di Visual Studio.

> [!NOTE]
> `OpenConsole.exe` hanyalah `conhost.exe` yang dibangun secara lokal, Console Windows klasik yang menjadi host infrastruktur command-line Windows. OpenConsole digunakan oleh Windows Terminal untuk terhubung dan berkomunikasi dengan aplikasi command-line (melalui [ConPty](https://devblogs.microsoft.com/commandline/windows-command-line-introducing-the-windows-pseudo-console-conpty/)).

---

## Dokumentasi

Semua dokumentasi proyek tersedia di [aka.ms/terminal-docs](https://aka.ms/terminal-docs). Jika Anda ingin
berkontribusi pada dokumentasi, silakan kirim pull request di [repo Dokumentasi Windows Terminal](https://github.com/MicrosoftDocs/terminal).

---

## Kontribusi

Kami sangat antusias untuk bekerja bersama Anda, komunitas luar biasa kami, untuk membangun dan meningkatkan Windows Terminal!

***SEBELUM Anda mulai mengerjakan fitur/perbaikan***, silakan baca & ikuti [Panduan Kontributor](./CONTRIBUTING.md) kami agar dapat menghindari usaha yang sia-sia atau duplikasi pekerjaan.

## Berkomunikasi dengan Tim

Cara termudah untuk berkomunikasi dengan tim adalah melalui isu GitHub.

Silakan buat isu baru, permintaan fitur, dan saran, tetapi **PASTIKAN untuk mencari isu terbuka/tertutup yang serupa sebelum membuat isu baru.**

Jika Anda ingin bertanya sesuatu yang menurut Anda belum perlu menjadi isu
(sementara), silakan hubungi kami melalui Twitter:

* Christopher Nguyen, Product Manager:
  [@nguyen_dows](https://twitter.com/nguyen_dows)
* Dustin Howett, Engineering Lead: [@dhowett](https://twitter.com/DHowett)
* Mike Griese, Senior Developer: [@zadjii@mastodon.social](https://mastodon.social/@zadjii)
* Carlos Zamora, Developer: [@cazamor_msft](https://twitter.com/cazamor_msft)
* Pankaj Bhojwani, Developer
* Leonard Hecker, Developer: [@LeonardHecker](https://twitter.com/LeonardHecker)

## Panduan Pengembang

## Prasyarat

Anda dapat mengonfigurasi lingkungan Anda untuk membangun Terminal dengan dua cara:

### Menggunakan file konfigurasi WinGet

Setelah mengkloning repositori, Anda dapat menggunakan [file konfigurasi WinGet](https://learn.microsoft.com/en-us/windows/package-manager/configuration/#use-a-winget-configuration-file-to-configure-your-machine)
untuk mengatur lingkungan Anda. [File konfigurasi default](.config/configuration.winget) menginstal Visual Studio 2022 Community & alat yang diperlukan lainnya. Ada dua varian file konfigurasi lainnya yang tersedia di direktori [.config](.config) untuk edisi Enterprise & Professional dari Visual Studio 2022. Untuk menjalankan file konfigurasi default, Anda bisa klik dua kali file tersebut dari explorer atau jalankan perintah berikut:

```powershell
winget configure .config\configuration.winget
```

### Konfigurasi manual

* Anda harus menjalankan Windows 10 2004 (build >= 10.0.19041.0) atau lebih baru untuk menjalankan Windows Terminal
* Anda harus [mengaktifkan Developer Mode di aplikasi Pengaturan Windows](https://docs.microsoft.com/en-us/windows/uwp/get-started/enable-your-device-for-development)
  untuk menginstal dan menjalankan Windows Terminal secara lokal
* Anda harus memiliki [PowerShell 7 atau lebih baru](https://github.com/PowerShell/PowerShell/releases/latest) terinstal
* Anda harus memiliki [Windows 11 (10.0.22621.0) SDK](https://developer.microsoft.com/en-us/windows/downloads/windows-sdk/)
  terinstal
* Anda harus memiliki minimal [VS 2022](https://visualstudio.microsoft.com/downloads/) terinstal
* Anda harus menginstal Workloads berikut melalui VS Installer. Catatan: Membuka solusi di VS 2022 akan [meminta Anda untuk menginstal komponen yang hilang secara otomatis](https://devblogs.microsoft.com/setup/configure-visual-studio-across-your-organization-with-vsconfig/):
  * Desktop Development with C++
  * Universal Windows Platform Development
  * **Komponen Individual berikut**
    * C++ (v143) Universal Windows Platform Tools
* Anda harus menginstal [.NET Framework Targeting Pack](https://docs.microsoft.com/dotnet/framework/install/guide-for-developers#to-install-the-net-framework-developer-pack-or-targeting-pack) untuk membangun proyek pengujian

## Membangun Kode

OpenConsole.sln dapat dibangun dari dalam Visual Studio atau dari command-line menggunakan serangkaian skrip & alat bantu di direktori **/tools**:

### Membangun di PowerShell

```powershell
Import-Module .\tools\OpenConsole.psm1
Set-MsBuildDevEnvironment
Invoke-OpenConsoleBuild
```

### Membangun di Cmd

```shell
.\tools\razzle.cmd
bcz
```

## Menjalankan & Debugging

Untuk melakukan debug Windows Terminal di VS, klik kanan pada `CascadiaPackage` (di Solution Explorer) dan buka properti. Pada menu Debug, ubah "Application process" dan "Background task process" menjadi "Native Only".

Anda kemudian dapat membangun & debug proyek Terminal dengan menekan <kbd>F5</kbd>. Pastikan untuk memilih platform "x64" atau "x86" - Terminal tidak dibangun untuk "Any Cpu" (karena Terminal adalah aplikasi C++, bukan aplikasi C#).

> 👉 Anda _tidak_ dapat menjalankan Terminal secara langsung dengan menjalankan WindowsTerminal.exe. Untuk detail lebih lanjut, lihat [#926](https://github.com/microsoft/terminal/issues/926), [#4043](https://github.com/microsoft/terminal/issues/4043)

### Panduan Pengkodean

Silakan baca dokumen singkat berikut tentang praktik pengkodean kami.

> 👉 Jika Anda menemukan sesuatu yang kurang dari dokumen ini, silakan berkontribusi ke
> salah satu file dokumentasi kami di mana pun dalam repositori (atau tulis dokumen baru!)

Ini adalah pekerjaan yang sedang berjalan seiring kami belajar apa yang perlu kami sediakan agar kontributor kami dapat bekerja secara efektif pada proyek ini.

* [Gaya Pengkodean](./doc/STYLE.md)
* [Organisasi Kode](./doc/ORGANIZATION.md)
* [Pengecualian di basis kode legacy kami](./doc/EXCEPTIONS.md)
* [Smart pointer dan makro yang bermanfaat untuk interfacing dengan Windows di WIL](./doc/WIL.md)

---

## Kode Etik

Proyek ini telah mengadopsi [Microsoft Open Source Code of Conduct][conduct-code]. Untuk informasi lebih lanjut, lihat [FAQ Kode Etik][conduct-FAQ] atau hubungi [opencode@microsoft.com][conduct-email] untuk pertanyaan atau komentar tambahan.

[conduct-code]: https://opensource.microsoft.com/codeofconduct/
[conduct-FAQ]: https://opensource.microsoft.com/codeofconduct/faq/
[conduct-email]: mailto:opencode@microsoft.com
[store-install-link]: https://aka.ms/terminal

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---