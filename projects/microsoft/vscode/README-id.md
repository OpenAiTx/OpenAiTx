# Visual Studio Code - Sumber Terbuka ("Code - OSS")

[![Permintaan Fitur](https://img.shields.io/github/issues/microsoft/vscode/feature-request.svg)](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
[![Bug](https://img.shields.io/github/issues/microsoft/vscode/bug.svg)](https://github.com/microsoft/vscode/issues?utf8=✓&q=is%3Aissue+is%3Aopen+label%3Abug)
[![Gitter](https://img.shields.io/badge/chat-on%20gitter-yellow.svg)](https://gitter.im/Microsoft/vscode)

## Repositori

Repositori ini ("`Code - OSS`") adalah tempat kami (Microsoft) mengembangkan produk [Visual Studio Code](https://code.visualstudio.com) bersama komunitas. Tidak hanya bekerja pada kode dan isu di sini, kami juga mempublikasikan [peta jalan](https://github.com/microsoft/vscode/wiki/Roadmap), [rencana iterasi bulanan](https://github.com/microsoft/vscode/wiki/Iteration-Plans), dan [rencana endgame](https://github.com/microsoft/vscode/wiki/Running-the-Endgame) kami. Kode sumber ini tersedia untuk semua orang di bawah [lisensi MIT](https://github.com/microsoft/vscode/blob/main/LICENSE.txt) standar.

## Visual Studio Code

<p align="center">
  <img alt="VS Code in action" src="https://user-images.githubusercontent.com/35271042/118224532-3842c400-b438-11eb-923d-a5f66fa6785a.png">
</p>

[Visual Studio Code](https://code.visualstudio.com) adalah distribusi dari repositori `Code - OSS` dengan kustomisasi khusus Microsoft yang dirilis di bawah [lisensi produk Microsoft](https://code.visualstudio.com/License/) tradisional.

[Visual Studio Code](https://code.visualstudio.com) menggabungkan kesederhanaan editor kode dengan kebutuhan utama pengembang untuk siklus edit-bangun-debug. VS Code menyediakan pengeditan kode yang komprehensif, navigasi, dan dukungan pemahaman, bersama dengan debugging ringan, model ekstensi yang kaya, dan integrasi ringan dengan alat yang sudah ada.

Visual Studio Code diperbarui setiap bulan dengan fitur baru dan perbaikan bug. Anda dapat mengunduhnya untuk Windows, macOS, dan Linux di [website Visual Studio Code](https://code.visualstudio.com/Download). Untuk mendapatkan rilis terbaru setiap hari, instal [build Insiders](https://code.visualstudio.com/insiders).

## Berkontribusi

Ada banyak cara Anda dapat berpartisipasi dalam proyek ini, misalnya:

* [Mengirimkan bug dan permintaan fitur](https://github.com/microsoft/vscode/issues), dan membantu kami memverifikasi saat mereka diperiksa
* Meninjau [perubahan kode sumber](https://github.com/microsoft/vscode/pulls)
* Meninjau [dokumentasi](https://github.com/microsoft/vscode-docs) dan membuat pull request untuk hal apapun, mulai dari salah ketik hingga konten tambahan dan baru

Jika Anda tertarik memperbaiki isu dan berkontribusi langsung ke basis kode,
silakan lihat dokumen [Cara Berkontribusi](https://github.com/microsoft/vscode/wiki/How-to-Contribute), yang mencakup hal-hal berikut:

* [Cara membangun dan menjalankan dari sumber](https://github.com/microsoft/vscode/wiki/How-to-Contribute)
* [Alur kerja pengembangan, termasuk debugging dan menjalankan tes](https://github.com/microsoft/vscode/wiki/How-to-Contribute#debugging)
* [Pedoman pengkodean](https://github.com/microsoft/vscode/wiki/Coding-Guidelines)
* [Mengirimkan pull request](https://github.com/microsoft/vscode/wiki/How-to-Contribute#pull-requests)
* [Menemukan isu untuk dikerjakan](https://github.com/microsoft/vscode/wiki/How-to-Contribute#where-to-contribute)
* [Berkontribusi pada terjemahan](https://aka.ms/vscodeloc)

## Umpan Balik

* Ajukan pertanyaan di [Stack Overflow](https://stackoverflow.com/questions/tagged/vscode)
* [Minta fitur baru](CONTRIBUTING.md)
* Beri suara pada [permintaan fitur populer](https://github.com/microsoft/vscode/issues?q=is%3Aopen+is%3Aissue+label%3Afeature-request+sort%3Areactions-%2B1-desc)
* [Laporkan masalah](https://github.com/microsoft/vscode/issues)
* Terhubung dengan komunitas penulis ekstensi di [GitHub Discussions](https://github.com/microsoft/vscode-discussions/discussions) atau [Slack](https://aka.ms/vscode-dev-community)
* Ikuti [@code](https://twitter.com/code) dan beri tahu kami pendapat Anda!

Lihat [wiki](https://github.com/microsoft/vscode/wiki/Feedback-Channels) kami untuk deskripsi masing-masing kanal ini dan informasi tentang kanal lain yang digerakkan oleh komunitas.

## Proyek Terkait

Banyak komponen inti dan ekstensi untuk VS Code berada di repositorinya masing-masing di GitHub. Sebagai contoh, repositori [node debug adapter](https://github.com/microsoft/vscode-node-debug) dan [mono debug adapter](https://github.com/microsoft/vscode-mono-debug) terpisah satu sama lain. Untuk daftar lengkap, silakan kunjungi halaman [Proyek Terkait](https://github.com/microsoft/vscode/wiki/Related-Projects) di [wiki](https://github.com/microsoft/vscode/wiki) kami.

## Ekstensi Bawaan

VS Code mencakup serangkaian ekstensi bawaan yang terletak di folder [extensions](extensions), termasuk grammar dan snippet untuk banyak bahasa. Ekstensi yang menyediakan dukungan bahasa yang kaya (penyelesaian kode, Go to Definition) untuk sebuah bahasa memiliki akhiran `language-features`. Misalnya, ekstensi `json` menyediakan pewarnaan untuk `JSON` dan ekstensi `json-language-features` menyediakan dukungan bahasa yang kaya untuk `JSON`.

## Kontainer Pengembangan

Repositori ini mencakup kontainer pengembangan Visual Studio Code Dev Containers / GitHub Codespaces.

* Untuk [Dev Containers](https://aka.ms/vscode-remote/download/containers), gunakan perintah **Dev Containers: Clone Repository in Container Volume...** yang membuat volume Docker untuk I/O disk yang lebih baik pada macOS dan Windows.
  * Jika Anda sudah menginstal VS Code dan Docker, Anda juga dapat klik [di sini](https://vscode.dev/redirect?url=vscode://ms-vscode-remote.remote-containers/cloneInVolume?url=https://github.com/microsoft/vscode) untuk memulai. Ini akan membuat VS Code secara otomatis menginstal ekstensi Dev Containers jika diperlukan, mengkloning kode sumber ke dalam volume kontainer, dan menjalankan kontainer pengembangan untuk digunakan.

* Untuk Codespaces, instal ekstensi [GitHub Codespaces](https://marketplace.visualstudio.com/items?itemName=GitHub.codespaces) di VS Code, dan gunakan perintah **Codespaces: Create New Codespace**.

Docker / Codespace sebaiknya memiliki minimal **4 Core dan 6 GB RAM (8 GB direkomendasikan)** untuk menjalankan build penuh. Lihat [README kontainer pengembangan](.devcontainer/README.md) untuk informasi lebih lanjut.

## Kode Etik

Proyek ini telah mengadopsi [Kode Etik Sumber Terbuka Microsoft](https://opensource.microsoft.com/codeofconduct/). Untuk informasi lebih lanjut lihat [FAQ Kode Etik](https://opensource.microsoft.com/codeofconduct/faq/) atau hubungi [opencode@microsoft.com](mailto:opencode@microsoft.com) untuk pertanyaan atau komentar tambahan.

## Lisensi

Hak Cipta (c) Microsoft Corporation. Seluruh hak cipta dilindungi.

Dilicensekan di bawah lisensi [MIT](LICENSE.txt).

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---