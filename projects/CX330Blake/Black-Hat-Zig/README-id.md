# Black-Hat-Zig

<p align="center">
  <img alt="GitHub License" src="https://img.shields.io/github/license/CX330Blake/black-hat-zig">
  <img alt="GitHub top language" src="https://img.shields.io/github/languages/top/cx330blake/black-hat-zig">
  <img alt="GitHub repo size" src="https://img.shields.io/github/repo-size/cx330blake/black-hat-zig">
  <img alt="X (formerly Twitter) Follow" src="https://img.shields.io/twitter/follow/CX330Blake">
</p>

<p height="350px" align="center">
  <img src="https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Black-Hat-Zig.png">
  <br/>
  <b>Halo para hacker. Halo para maldevs. Halo para reverser. Senang bertemu kalian di sini untuk menjelajahi kekuatan gelap Zig!</b><br/><br/>
  <b>Dipelihara dan dikelola oleh <a href="https://github.com/cx330blake">@CX330Blake</a></b>
</p>

---

## Daftar Isi

- [Pendahuluan](#pendahuluan)
- [Mengapa Zig?](#mengapa-zig)
- [Mengompilasi kode](#mengompilasi-kode)
- [Penempatan Payload](#penempatan-payload)
- [Obfuskasi Payload](#obfuskasi-payload)
- [Enkripsi Payload](#enkripsi-payload)
- [Eksekusi Payload](#eksekusi-payload)
- [Reverse Shell](#reverse-shell)
- [Teknik Malware](#teknik-malware)
- [Alat Maldev](#alat-maldev)
- [Kontributor](#kontributor)
- [Kredit & Referensi](#kredit--referensi)
- [Riwayat Bintang](#riwayat-bintang)
- [Disclaimer](#disclaimer)

## Pendahuluan

> [!IMPORTANT]
> Proyek ini terus diperbarui!

Proyek ini menyediakan banyak implementasi teknik malware menggunakan Zig karena saya sangat menyukainya. Anda dapat menggunakan repo ini untuk mempersenjatai Zig. Black-Hat-Zig terus diperbarui untuk memastikan isinya semakin banyak. Akan sangat sempurna jika Anda ingin membuat PR untuk proyek ini.

Oke, mari hack planet ini!

## Mengapa Zig?

- 🤝 Mudah berinteraksi dengan source C/C++
- 🔎 Ini baru, jadi lebih sulit terdeteksi
- 💪 Kontrol tingkat rendah yang kuat, bahkan lebih rendah dari C
- 😱 Lebih sulit direverse engineering karena kompiler modern
- 🛡️ Ketergantungan runtime minimal - Tidak ada jejak pustaka standar yang besar
- 🎯 Tidak ada perilaku tidak terdefinisi - Penanganan eksplisit kasus tepi mencegah crash

## Mengompilasi kode

Anda dapat memeriksa kode di setiap direktori. Juga, jika kode menggunakan Windows API, Anda akan melihat petunjuk di direktori proyek terkait `README.md`, contohnya, [yang ini](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/).

Saya sudah mengatur target build default menjadi `windows-x86_64` untuk mereka yang membutuhkan Windows API, jadi Anda bisa langsung copy & paste perintah berikut untuk mengompilasi kode di Linux, Windows, bahkan MacOS! (Tapi Anda tetap butuh lingkungan Windows untuk menjalankan file executable-nya)

```bash
zig build
```

## Penempatan Payload

Teknik untuk menempatkan payload berbahaya di berbagai bagian file executable.

- [.data Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_data_section/)
- [.rdata Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rdata_section/)
- [.text Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_text_section/)
- [.rsrc Section](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Placement/dot_rsrc_section/)

## Obfuskasi Payload

Teknik obfuskasi untuk menyamarkan payload dan menghindari deteksi melalui analisis statis atau pencocokan pola.

- [Obfuskasi Alamat IP](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/)
  - [Obfuskasi IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_obfuscation/)
  - [Deobfuskasi IPv4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv4_deobfuscation/)
  - [Obfuskasi IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_obfuscation/)
  - [Deobfuskasi IPv6](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/IP-Address-Obfuscation/ipv6_deobfuscation/)
- [Obfuskasi Alamat MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/)
  - [Obfuskasi Alamat MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACFuscation/)
  - [Deobfuskasi Alamat MAC](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/MAC-Address-Obfuscation/MACDeobfuscation/)
- [Obfuskasi UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/)
  - [Obfuskasi UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDFuscation/)
  - [Deobfuskasi UUID](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Obfuscation/UUID-Obfuscation/UUIDDeobfuscation/)

## Enkripsi Payload

Berbagai skema enkripsi yang digunakan untuk menyembunyikan tujuan asli payload selama penyimpanan atau transmisi.

- [Enkripsi XOR](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/)
  - [XOR Dengan Pustaka Standar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/XOR/std_lib_xor/)
- [Enkripsi RC4](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/)
  - [RC4 Dengan SystemFunction032](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/RC4/system_function_032_rc4/)
- [Enkripsi AES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/)
  - [AES Dengan Bcrypt.h](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/bcrypt_aes/)
  - [AES Dengan Pustaka Standar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/std_aes/)
  - [AES Dengan TinyAES](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Encryption/AES/tiny_aes/)

## Eksekusi Payload

- [DLL](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/dll/)
- [Shellcode](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Payload-Execution/shellcode/)

## Reverse Shell

Primitif untuk membangun reverse shell untuk akses C2 atau kontrol pasca-eksploitasi.

- [Reverse Shell Dengan Pustaka Standar](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Reverse-Shell/std_reverse_shell/)

## Teknik Malware

Kumpulan teknik tradecraft ofensif umum yang diadaptasi ke Zig.

- [Process Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/)
  - [DLL Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/dll_injection/)
  - [Shellcode Injection](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Injection/shellcode_injection/)
- [Payload Staging](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/)
  - [Dari Web Server](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/web_server/)
  - [Dari Windows Registry](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Payload-Staging/windows_registry/)
- [Process Enumeration](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/)
  - [Menggunakan CreateToolhelp32Snapshot](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/create_tool_help_32_snapshot/)
  - [Menggunakan EnumProcesses](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/enum_processes/)
  - [Menggunakan NtQuerySystemInformation](https://raw.githubusercontent.com/CX330Blake/Black-Hat-Zig/main/Malware-Techniques/Process-Enumeration/nt_query_system_information/)

## Alat Maldev

- [ZYRA: Your Runtime Armor](https://github.com/cx330blake/zyra)
  - Sebuah packer executable yang ditulis dengan Zig
- [ZYPE: Your Payload Encryptor](https://github.com/cx330blake/zype)
  - Menghasilkan template kode dalam Zig yang berisi payload terenkripsi/terobfuskasi beserta fungsi dekripsi/deobfuskasi yang sesuai.

## Kontributor

Proyek ini terutama dipelihara & dikelola oleh [@CX330Blake](https://github.com/CX330Blake). PR sangat diterima. Semoga lebih banyak orang menggunakan Zig untuk pengembangan malware sehingga ekosistemnya semakin matang.

Terima kasih sebesar-besarnya untuk para kontributor berikut!

<a href="https://github.com/CX330Blake/black-hat-zig/graphs/contributors">
  <img src="https://contrib.rocks/image?repo=CX330Blake/black-hat-zig" />
</a>

## Kredit & Referensi

- [Maldev Academy](https://maldevacademy.com/)
- [OffensiveNim](https://github.com/byt3bl33d3r/OffensiveNim)

## Riwayat Bintang

[![Star History Chart](https://api.star-history.com/svg?repos=CX330blake/black-hat-zig&type=Date)](https://www.star-history.com/#CX330blake/black-hat-zig&Date)

## Disclaimer

Proyek ini hanya untuk tujuan etis dan edukasi. Jangan menjadi penjahat siber.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-11

---