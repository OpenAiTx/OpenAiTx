# Desain Bahasa C#

[![Bergabung dalam chat di https://gitter.im/dotnet/csharplang](https://badges.gitter.im/dotnet/csharplang.svg)](https://gitter.im/dotnet/csharplang?utm_source=badge&utm_medium=badge&utm_campaign=pr-badge&utm_content=badge) [![Chat di Discord](https://discordapp.com/api/guilds/143867839282020352/widget.png)](https://aka.ms/dotnet-discord-csharp)

Selamat datang di repo resmi untuk desain bahasa C#. Di sinilah fitur bahasa C# baru dikembangkan, diadopsi, dan ditentukan.

C# dirancang oleh Tim Desain Bahasa C# (LDT) dalam koordinasi erat dengan proyek [Roslyn](https://github.com/dotnet/roslyn), yang mengimplementasikan bahasa tersebut.

Anda dapat menemukan:

- Proposal fitur bahasa C# aktif di [folder proposals](proposals)
- Catatan dari pertemuan desain bahasa C# di [folder meetings](meetings)
- Ringkasan [sejarah versi bahasa di sini](Language-Version-History.md).

Jika Anda menemukan bug atau kekurangan pada hal di atas, silakan tinggalkan issue untuk melaporkannya, atau lebih baik lagi: pull request untuk memperbaikinya.

Untuk *proposal fitur baru*, silakan ajukan untuk [diskusi](https://github.com/dotnet/csharplang/labels/Discussion), dan *hanya* ajukan proposal sebagai issue atau pull request jika diundang oleh anggota Tim Desain Bahasa (seorang "champion").

Proses desain lengkap dijelaskan [di sini](Design-Process.md). Gambaran singkatnya ada di bawah.

## Diskusi

Perdebatan terkait fitur bahasa berlangsung dalam bentuk [Diskusi](https://github.com/dotnet/csharplang/discussions) di repo ini.

Jika Anda ingin mengusulkan fitur, mendiskusikan catatan desain atau proposal saat ini, dsb., silakan [buka topik Diskusi baru](https://github.com/dotnet/csharplang/discussions/new).

Diskusi yang singkat dan tetap pada topik jauh lebih mungkin untuk dibaca. Jika Anda meninggalkan komentar nomor lima puluh, kemungkinan hanya sedikit orang yang akan membacanya. Agar diskusi lebih mudah dinavigasi dan bermanfaat, harap perhatikan beberapa aturan berikut:

- Diskusi harus relevan dengan desain bahasa C#. Jika tidak, diskusi akan segera ditutup.
- Pilih topik yang deskriptif dan jelas mengkomunikasikan ruang lingkup diskusi.
- Tetap pada topik diskusi. Jika komentar menyimpang, atau membahas subtopik secara mendalam, mulailah diskusi baru dan tautkan kembali.
- Apakah komentar Anda bermanfaat untuk dibaca orang lain, atau cukup diwakili dengan reaksi emoji pada komentar yang ada?

Proposal bahasa yang mencegah sintaks tertentu dapat diwujudkan dengan [Roslyn analyzer](https://docs.microsoft.com/visualstudio/extensibility/getting-started-with-roslyn-analyzers). Proposal yang hanya membuat sintaks yang ada menjadi ilegal secara opsional akan ditolak oleh komite desain bahasa untuk mencegah kompleksitas bahasa yang meningkat.

## Proposal

Ketika seorang anggota C# LDM merasa bahwa sebuah proposal layak dipertimbangkan oleh tim yang lebih luas, mereka dapat [Champion](https://github.com/dotnet/csharplang/issues?q=is%3Aopen+is%3Aissue+label%3A%22Proposal+champion%22) proposal tersebut, artinya mereka akan membawanya ke Pertemuan Desain Bahasa C#. Proposal selalu didiskusikan dalam diskusi yang ditautkan, bukan di issue champion. Kami tidak selalu mengikuti kebijakan ini, jadi banyak issue champion yang masih memiliki diskusi di dalamnya; sekarang kami mengunci issue untuk mencegah diskusi baru terjadi di sana. Setiap issue champion akan memiliki tautan diskusi di dalamnya.

## Proses Desain

[Proposal](proposals) berkembang sebagai hasil dari keputusan dalam [Pertemuan Desain Bahasa](meetings), yang diinformasikan oleh [diskusi](https://github.com/dotnet/csharplang/discussions), eksperimen, dan pekerjaan desain offline.

Dalam banyak kasus, perlu untuk mengimplementasikan dan membagikan prototipe fitur untuk mendapatkan desain yang tepat, dan akhirnya memutuskan apakah fitur tersebut akan diadopsi. Prototipe membantu menemukan masalah implementasi dan kegunaan dari sebuah fitur. Prototipe sebaiknya diimplementasikan pada fork dari [repo Roslyn](https://github.com/dotnet/roslyn) dan memenuhi standar berikut:

- Parsing (jika relevan) harus tahan terhadap eksperimen: pengetikan tidak boleh menyebabkan crash.
- Sertakan tes minimal yang mendemonstrasikan fitur tersebut secara end-to-end.
- Sertakan dukungan IDE minimal (pewarnaan keyword, pemformatan, pelengkapan).

Setelah disetujui, sebuah fitur harus diimplementasikan sepenuhnya di [Roslyn](https://github.com/dotnet/roslyn), dan dijelaskan secara penuh di [spesifikasi bahasa](spec), kemudian proposal dipindahkan ke folder yang sesuai untuk fitur yang telah selesai, misalnya [proposals C# 7.1](proposals/csharp-7.1).

**DISCLAIMER**: Proposal aktif sedang dipertimbangkan untuk dimasukkan ke versi bahasa pemrograman C# di masa depan, namun tidak ada jaminan akan benar-benar dimasukkan ke versi berikutnya atau versi mana pun dari bahasa tersebut. Sebuah proposal dapat ditunda atau ditolak kapan saja selama proses di atas berdasarkan masukan dari tim desain, komunitas, peninjau kode, atau pengujian.

### Milestone

Kami memiliki beberapa milestone berbeda untuk issue di repo ini:
* [Working Set](https://github.com/dotnet/csharplang/milestone/19) adalah kumpulan proposal champion yang saat ini sedang aktif dikerjakan. Tidak semua yang ada di milestone ini akan masuk ke versi C# berikutnya, tetapi akan mendapatkan waktu desain selama rilis mendatang.
* [Backlog](https://github.com/dotnet/csharplang/milestone/10) adalah kumpulan proposal champion yang sudah ditriase, tetapi belum dikerjakan secara aktif. Diskusi dan ide dari komunitas tetap diterima pada proposal ini, namun biaya pekerjaan desain dan peninjauan implementasi pada fitur ini terlalu tinggi untuk dipertimbangkan implementasi oleh komunitas hingga kami siap.
* [Any Time](https://github.com/dotnet/csharplang/milestone/14) adalah kumpulan proposal champion yang telah ditriase, tetapi belum dikerjakan secara aktif dan terbuka untuk implementasi oleh komunitas. Issue di milestone ini bisa dalam 2 status: membutuhkan spesifikasi yang disetujui, dan membutuhkan implementasi. Yang membutuhkan spesifikasi masih perlu dipresentasikan di LDM untuk persetujuan spesifikasinya, namun kami bersedia meluangkan waktu untuk itu segera setelah memungkinkan.
* [Likely Never](https://github.com/dotnet/csharplang/milestone/13) adalah kumpulan proposal yang telah ditolak LDM dari bahasa. Tanpa kebutuhan kuat atau masukan komunitas, proposal ini tidak akan dipertimbangkan di masa depan.
* Milestone bernomor adalah kumpulan fitur yang telah diimplementasikan untuk versi bahasa tertentu. Untuk milestone yang telah ditutup, ini adalah fitur yang dirilis bersama rilis tersebut. Untuk milestone yang masih terbuka, fitur dapat saja dibatalkan kemudian jika ditemukan masalah kompatibilitas atau lainnya saat mendekati rilis.

## Pertemuan Desain Bahasa

Pertemuan Desain Bahasa (LDM) diadakan oleh LDT dan tamu undangan tertentu, serta didokumentasikan dalam Catatan Pertemuan Desain di folder [meetings](meetings), yang diorganisir dalam folder per tahun. Masa hidup catatan pertemuan desain dijelaskan di [meetings/README.md](meetings/README.md). LDM adalah tempat keputusan tentang versi C# masa depan dibuat, termasuk proposal mana yang akan dikerjakan, bagaimana mengembangkan proposal, dan apakah serta kapan akan diadopsi.

## Spesifikasi Bahasa

Spesifikasi ECMA-334 terkini dapat ditemukan dalam format markdown di repositori [C# Language Standard](https://github.com/dotnet/csharpstandard/).

## Implementasi

Implementasi referensi dari bahasa C# dapat ditemukan di [repositori Roslyn](https://github.com/dotnet/roslyn). Repositori ini juga melacak [status implementasi fitur bahasa](https://github.com/dotnet/roslyn/blob/main/docs/Language%20Feature%20Status.md). Hingga baru-baru ini, di situlah artefak desain bahasa juga dilacak. Mohon bersabar seiring kami memindahkan proposal aktif ke sini.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-15

---