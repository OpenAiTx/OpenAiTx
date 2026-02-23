
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=PietJankbal&project=Chocolatey-for-wine&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Chocolatey-for-wine

Chocolatey packagemanager pemasang otomatis di wine, praktis untuk menginstal program dengan cepat di wine (dan selanjutnya menemukan bug di wine ;) )  
Untuk beberapa bug telah ditambahkan solusi sementara seperti untuk Visual Studio Community 2022 dan nodejs, lihat penjelasan lebih lanjut di bawah.  

Karena saya bosan selama masa karantina, saya menulis winetricks(.ps1) kustom dengan verb yang menurut saya berguna. Cukup jalankan 'winetricks' untuk melihatnya.
Untuk beberapa verb, restart penuh wine dibutuhkan (karena perubahan terbaru pada wine). Anda akan melihat kotak pesan dan sesi akan diakhiri. Cukup jalankan powershell lagi dan coba ulangi verb tersebut. Jika ini sudah dilakukan sekali, tidak perlu dilakukan lagi untuk verb mana pun.  

Contoh:  

'winetricks vs22_interactiveinstaller'  ( --> sesi akan berakhir)  

lakukan 'wine powershell'  

lakukan 'winetricks vs22_interactiveinstaller'  


(Sebagai informasi, melalui 'winetricks vs22_interactive_installer' Anda dapat memilih apa yang ingin diinstal melalui installer Visual Studio 2022; 'winetricks vs22_interactive_installer' sekarang membawa saya dalam sepuluh menit ke program utama (memilih Desktop development with C++)).

Instal :
- Unduh dan ekstrak file zip rilis lalu lakukan 'wine ChoCinstaller_0.5c.751.exe' (memakan waktu sekitar satu menit untuk selesai)

Opsional:
- Jalankan installer seperti 'wine ChoCinstaller_0.5a.751.exe /s' , maka file instalasi (seperti Powershell*.msi dan dotnet48) akan disimpan di
  MyDocuments dan tidak perlu diunduh lagi jika Anda membuat prefix baru)
Opsional:
- Jalankan installer seperti 'wine ChoCinstaller_0.5a.751.exe /q' untuk mencegah peluncuran otomatis jendela powershell (jadi hanya instal saja). 

Opsional:
- Periksa apakah semuanya berjalan baik: "choco install chromium" dan "start chrome.exe (--no-sandbox tidak diperlukan lagi sejak wine-8,4)" 

![Screenshot from 2022-08-26 12-31-18](https://user-images.githubusercontent.com/26839562/186885380-d5a617c4-9cf4-4831-a475-2bd85a3b5784.png)
Tentang PowerShell:

Tips: Chocolatey biasanya menginstal versi terbaru dari suatu program, yang mungkin menunjukkan bug baru pada wine. Anda mungkin lebih beruntung menggunakan versi lama dari perangkat lunak tersebut.  
Contoh:  

choco search --exact microsoft-edge --all (--> daftar semua versi)  

choco install microsoft-edge --version --version='135.0.3179.98'

Info umum:

- 'wine powershell.exe' akan memulai konsol PowerShell-Core.

 
Tentang ConEmu:

Konsol ConEmu mengalami beberapa bug wine:
  - Ctrl^C untuk keluar dari program yang tidak kembali ke konsol tidak berfungsi. Gunakan Shift^Ctrl^C sebagai gantinya.
  - Memilih teks di jendela ConEmu (untuk copy/paste) tidak menyorot pilihan. Disertakan hack yang sangat sederhana untuk wine versi terbaru yang mengatasi masalah ini, jadi penyorotan seharusnya sudah berfungsi sekarang.
   
Tentang winetricks(.ps1):

- Jika Anda tidak memanggilnya ('winetricks' di konsol powershell), tidak ada yang diunduh sehingga tidak ada overhead.
- Banyak verb (seperti powershell 5.1) membutuhkan beberapa file penting untuk mengekstrak data dari paket msu. Menginstal file-file penting ini memerlukan unduhan besar terlebih dahulu, dan memakan waktu lama saat penggunaan pertama kali. Namun setelah file di-cache, prosesnya menjadi cepat. Misalnya, jika Anda ingin mencoba 'winetricks ps51' pertama kali, akan memakan waktu sekitar 15 menit. Beberapa verb lain mungkin memakan waktu 5 menit pada penggunaan pertama. Namun setelah Anda memanggil suatu verb sekali, gangguan ini hilang.
- File di-cache di direktori MyDocuments. Jika Anda memanggil semua verb, akan memakan ruang sekitar 800 MB di sana.
- Diharapkan dukungan 64-bit yang lebih baik untuk berbagai verb.
- Kemungkinan untuk mengekstrak file dan (mencoba) menginstal dari file msu. Lakukan 'winetricks install_dll_from_msu' untuk melihat caranya.
- Powershell 5.1 yang masih dasar.
- Instalasi dotnet481 yang eksperimental, dan dotnet35 (mungkin diperlukan oleh aplikasi yang tidak puas dengan instalasi dotnet48 saat ini).
- Autotab-completion. Catatan: saat menggunakan banyak verb dari command line, mereka harus dipisahkan dengan koma mulai sekarang (ini cara powershell menangani banyak argumen)
  Jadi 'winetricks riched20 gdiplus' tidak akan berfungsi lagi, gunakan 'winetricks riched20,gdiplus' sebagai gantinya
- Beberapa program gagal diinstal/dijalankan saat Anda mencoba melalui Chocolatey karena bug wine. Saya menambahkan beberapa solusi di winetricks untuk itu, lihat di bawah.
- Verb khusus (winetricks vs19, vs22, dan vs22_interactive_installer) untuk menginstal Visual Studio Community 2019 dan 2022 yang berfungsi (lihat screenshot, >10 menit instalasi dan membutuhkan sekitar 10GB!, setelah instalasi jalankan devenv.exe dari direktori c:\Program\ Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE/)
  ![screenshot](https://github.com/PietJankbal/Chocolatey-for-wine/assets/26839562/d576a619-c752-4eb1-81c2-6f6b66b50ff6)
- Verb khusus untuk mendapatkan akses ke berbagai perintah unix seperti grep, sed, file, less, curl, dll. (winetricks git.portable, Disclaimer: beberapa perintah belum berfungsi karena bug wine
- Juga disertakan beberapa skrip powershell yang diadaptasi dari potongan kode di internet:
    - Cara menyematkan exe di skrip powershell melalui Invoke-ReflectivePEInjection (exe tidak akan muncul di tasklist).
    - Cara membuat messagebox yang menarik
    - Mengonversi skrip powershell (ps1) menjadi exe.
    - Dan beberapa lainnya
 
     
Tentang program sistem:

Fitur ditambahkan untuk mengganti program sistem sederhana seperti misalnya setx.exe dengan fungsi di
c:\\Program Files\Powershell\7\profile.ps1. Atau menambahkan program sistem yang hilang seperti getmac.exe.
Jika program gagal karena program sistem yang tidak cukup matang atau hilang, Anda bisa menulis
fungsi untuk mengembalikan apa pun yang diharapkan program tersebut.
Seperti di profile.ps1 saya menambahkan (antara lain) wmic.exe yang mendukung lebih banyak opsi,
dan setx.exe dasar.
Atau Anda bisa saja memanipulasi argumen yang diteruskan ke program sistem. Lihat profile.ps1 dan choc_install.ps1.
Tidak ada jaminan ini juga akan berfungsi untuk program yang lebih kompleks...
 
Catatan:


  - JANGAN gunakan pada wineprefix yang sudah ada, hanya pada prefix baru yang baru saja dibuat! Installer ini hanya menginstal dotnet48 secara sembarangan dan mengacaukan registrykeys.
    Jika Anda sudah menginstal versi dotnet apa pun dengan winetricks.sh biasa, kemungkinan akan gagal, dan bahkan jika berhasil, Anda mungkin akan berakhir dengan prefix yang rusak.
    Jika Anda perlu menginstal sesuatu dengan winetricks.sh biasa untuk program, JANGAN gunakan salah satu dari dotnet* verbs.
    BTW 'Arial' dan 'd3dcompiler_47' verbs sudah terpasang secara default.
  - WINEARCH=win32 _tidak_ didukung!
  - Pembaruan dari versi sebelumnya untuk saat ini belum (belum) didukung, mungkin nanti

Kompilasi:
  - Jika Anda ingin mengkompilasi sendiri daripada mengunduh binary: lihat instruksi kompilasi di mainv1.c dan installer.c
  - Kemudian salin choc_install.ps1 ke direktori yang sama
  - Kemudian lakukan 'wine ChoCinstaller_0.5a.735.exe'
  


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-23

---