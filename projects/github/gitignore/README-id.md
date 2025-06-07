# Kumpulan Template `.gitignore`

Ini adalah kumpulan template file [`.gitignore`][man] milik GitHub.
Kami menggunakan daftar ini untuk mengisi pemilih template `.gitignore` yang tersedia
di antarmuka GitHub.com saat membuat repositori dan file baru.

Untuk informasi lebih lanjut tentang cara kerja file `.gitignore`, dan cara menggunakannya,
sumber daya berikut adalah tempat yang bagus untuk memulai:

- [Bab Mengabaikan File][chapter] dari buku [Pro Git][progit].
- [Artikel Mengabaikan File][help] di situs Bantuan GitHub.
- Halaman manual [gitignore(5)][man].

[man]: https://git-scm.com/docs/gitignore
[help]: https://help.github.com/articles/ignoring-files
[chapter]: https://git-scm.com/book/en/v2/Git-Basics-Recording-Changes-to-the-Repository#_ignoring
[progit]: https://git-scm.com/book

## Struktur Folder

Kami mendukung kumpulan template yang diorganisasi seperti berikut:

- Folder root berisi template yang umum digunakan, untuk membantu orang memulai
  dengan bahasa pemrograman dan teknologi populer. Template ini mendefinisikan
  seperangkat aturan yang bermakna untuk membantu memulai, dan memastikan Anda tidak
  meng-commit file yang tidak penting ke dalam repositori Anda.
- [`Global`](./Global) berisi template untuk berbagai editor, alat, dan
  sistem operasi yang dapat digunakan dalam situasi berbeda. Disarankan
  agar Anda [menambahkan ini ke template global Anda](https://docs.github.com/en/get-started/getting-started-with-git/ignoring-files#configuring-ignored-files-for-all-repositories-on-your-computer)
  atau menggabungkan aturan ini ke dalam template proyek spesifik Anda jika ingin
  menggunakannya secara permanen.
- [`community`](./community) berisi template khusus untuk bahasa,
  alat, dan proyek populer lainnya, yang saat ini belum termasuk dalam template utama.
  Template ini harus ditambahkan ke template proyek spesifik Anda saat Anda
  memutuskan untuk mengadopsi framework atau alat tersebut.

## Apa yang Membuat Template Bagus?

Sebuah template harus berisi serangkaian aturan untuk membantu repositori Git bekerja dengan
bahasa pemrograman, framework, alat, atau lingkungan tertentu.

Jika tidak memungkinkan untuk mengkurasi kumpulan aturan yang berguna untuk situasi ini,
maka template tersebut bukan pilihan yang tepat untuk koleksi ini.

Jika sebuah template sebagian besar adalah daftar file yang dipasang oleh versi tertentu dari
sebuah perangkat lunak (misalnya framework PHP), maka template tersebut dapat ditempatkan di bawah direktori `community`.
Lihat [template versi](#versioned-templates) untuk detail lebih lanjut.

Jika Anda memiliki kumpulan aturan kecil, atau ingin mendukung teknologi yang tidak
banyak digunakan, dan masih yakin ini akan membantu orang lain, silakan baca
bagian tentang [template khusus](#specialized-templates) untuk detail lebih lanjut.

Sertakan detail saat membuka pull request jika template tersebut penting dan terlihat. Kami
mungkin tidak langsung menerimanya, tetapi kami dapat mempromosikannya ke root di kemudian hari
berdasarkan minat.

Mohon juga dimengerti bahwa kami tidak dapat mencantumkan setiap alat yang pernah ada.
Tujuan kami adalah mengkurasi koleksi template _paling umum dan membantu_,
bukan memastikan mencakup setiap proyek yang mungkin. Jika kami memilih untuk tidak
menyertakan bahasa, alat, atau proyek Anda, bukan berarti itu tidak hebat.

## Pedoman Kontribusi

Kami sangat senang jika Anda membantu meningkatkan proyek ini. Untuk membantu kami menjaga koleksi ini
berkualitas tinggi, kami meminta kontribusi mengikuti pedoman berikut.

- **Sertakan tautan ke homepage aplikasi atau proyek**. Kecuali sangat populer,
  ada kemungkinan maintainer tidak mengetahui atau menggunakan
  bahasa, framework, editor, aplikasi, atau proyek yang Anda ubah.

- **Sertakan tautan ke dokumentasi** yang mendukung perubahan yang Anda lakukan.
  Dokumentasi resmi dan terkini yang menyebutkan file yang diabaikan adalah yang terbaik.
  Jika dokumentasi tidak tersedia untuk mendukung perubahan Anda, lakukan yang terbaik untuk
  menjelaskan untuk apa file yang diabaikan tersebut.

- **Jelaskan mengapa Anda melakukan perubahan**. Meskipun tampak jelas, mohon
  luangkan satu dua kalimat untuk memberi tahu kami mengapa perubahan atau penambahan Anda perlu dilakukan.
  Sangat membantu untuk menjelaskan mengapa perubahan ini berlaku untuk _semua orang_
  yang bekerja dengan teknologi terkait, bukan hanya Anda atau tim Anda.

- **Pertimbangkan cakupan perubahan Anda**. Jika perubahan Anda spesifik untuk
  bahasa atau framework tertentu, pastikan perubahan dilakukan pada
  template untuk bahasa atau framework tersebut, bukan pada template untuk
  editor, alat, atau sistem operasi.

- **Mohon hanya mengubah _satu template_ per pull request**. Ini membantu menjaga pull request
  dan umpan balik tetap fokus pada proyek atau teknologi tertentu.

Secara umum, semakin banyak Anda membantu kami memahami perubahan yang Anda buat,
semakin besar kemungkinan kontribusi Anda akan diterima dengan cepat.

## Template Versi

Beberapa template dapat berubah secara signifikan antar versi, dan jika Anda ingin berkontribusi
ke repositori ini, kami perlu mengikuti alur khusus berikut:

- template di root harus versi yang saat ini didukung
- template di root sebaiknya tidak memiliki versi di nama file (misal,
  "evergreen")
- versi sebelumnya dari template harus ditempatkan di bawah `community/`
- versi sebelumnya dari template harus mencantumkan versinya di nama file,
  agar mudah dibaca

Ini membantu memastikan pengguna mendapatkan versi terbaru (karena mereka akan menggunakan apa pun yang
ada di root) tetapi juga membantu maintainer mendukung versi lama yang masih digunakan.

## Template Khusus

Jika Anda memiliki template yang ingin Anda kontribusikan, tetapi belum cukup
mainstream, pertimbangkan untuk menambahkannya ke direktori `community` di bawah folder
yang paling sesuai.

Aturan dalam template khusus Anda harus spesifik untuk framework atau
alat, dan template tambahan lainnya sebaiknya disebutkan dalam komentar di
header template.

Sebagai contoh, template ini dapat ditempatkan di `community/DotNet/InforCRM.gitignore`:

```
# template gitignore untuk InforCRM (sebelumnya SalesLogix)
# situs web: https://www.infor.com/product-summary/cx/infor-crm/
#
# Direkomendasikan: VisualStudio.gitignore

# Abaikan file model yang dihasilkan otomatis
ModelIndex.xml
ExportedFiles.xml

# Abaikan file deployment
[Mm]odel/[Dd]eployment

# Paksa include portal SupportFiles
!Model/Portal/*/SupportFiles/[Bb]in/
!Model/Portal/PortalTemplates/*/SupportFiles/[Bb]in
```

## Alur Kerja Kontribusi

Berikut cara yang kami sarankan untuk mengusulkan perubahan pada proyek ini:

1. [Fork proyek ini][fork] ke akun Anda.
2. [Buat branch][branch] untuk perubahan yang ingin Anda lakukan.
3. Lakukan perubahan pada fork Anda.
4. [Kirim pull request][pr] dari branch fork Anda ke branch `main` kami.

Menggunakan antarmuka berbasis web juga diperbolehkan, dan akan membantu Anda
dengan otomatis melakukan fork proyek dan memandu untuk mengirim pull request juga.

[fork]: https://help.github.com/articles/fork-a-repo/
[branch]: https://help.github.com/articles/creating-and-deleting-branches-within-your-repository
[pr]: https://help.github.com/articles/using-pull-requests/

## Lisensi

[CC0-1.0](./LICENSE).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---