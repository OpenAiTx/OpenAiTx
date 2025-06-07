Bitcoin Core integrasi/pohon staging
=====================================

https://bitcoincore.org

Untuk versi biner Bitcoin Core yang langsung dapat digunakan, lihat
https://bitcoincore.org/en/download/.

Apa itu Bitcoin Core?
---------------------

Bitcoin Core terhubung ke jaringan peer-to-peer Bitcoin untuk mengunduh dan sepenuhnya
memvalidasi blok dan transaksi. Ini juga mencakup dompet dan antarmuka pengguna grafis, yang dapat dibangun secara opsional.

Informasi lebih lanjut tentang Bitcoin Core tersedia di [folder doc](/doc).

Lisensi
-------

Bitcoin Core dirilis di bawah ketentuan lisensi MIT. Lihat [COPYING](COPYING) untuk informasi lebih lanjut atau kunjungi https://opensource.org/license/MIT.

Proses Pengembangan
-------------------

Branch `master` secara rutin dibangun (lihat `doc/build-*.md` untuk petunjuk) dan diuji, namun tidak dijamin sepenuhnya stabil. [Tag](https://github.com/bitcoin/bitcoin/tags) dibuat
secara berkala dari branch rilis untuk menandai versi rilis resmi dan stabil dari Bitcoin Core.

Repositori https://github.com/bitcoin-core/gui digunakan secara eksklusif untuk
pengembangan GUI. Branch master-nya identik di semua repositori monotree.
Branch rilis dan tag tidak tersedia, jadi mohon jangan melakukan fork
repositori tersebut kecuali untuk alasan pengembangan.

Alur kontribusi dijelaskan di [CONTRIBUTING.md](CONTRIBUTING.md)
dan petunjuk bermanfaat untuk pengembang dapat ditemukan di [doc/developer-notes.md](doc/developer-notes.md).

Pengujian
-------

Pengujian dan tinjauan kode adalah hambatan utama dalam pengembangan; kami menerima lebih banyak pull request daripada yang dapat kami tinjau dan uji dalam waktu singkat. Mohon bersabar dan bantu dengan menguji pull request orang lain, dan ingat bahwa ini adalah proyek yang sangat penting untuk keamanan di mana setiap kesalahan dapat menyebabkan kerugian uang yang besar bagi orang lain.

### Pengujian Otomatis

Pengembang sangat dianjurkan untuk menulis [unit test](src/test/README.md) untuk kode baru, dan mengirimkan unit test baru untuk kode lama. Unit test dapat dikompilasi dan dijalankan
(dengan asumsi tidak dinonaktifkan saat pembuatan sistem build) dengan: `ctest`. Detail lebih lanjut tentang menjalankan
dan memperluas unit test dapat ditemukan di [/src/test/README.md](/src/test/README.md).

Terdapat juga [pengujian regresi dan integrasi](/test), yang ditulis
dalam Python.
Pengujian ini dapat dijalankan (jika [dependensi pengujian](/test) telah diinstal) dengan: `build/test/functional/test_runner.py`
(dengan asumsi `build` adalah direktori build Anda).

Sistem CI (Continuous Integration) memastikan setiap pull request dibangun untuk Windows, Linux, dan macOS,
dan bahwa pengujian unit/sanity dijalankan secara otomatis.

### Pengujian Manual Quality Assurance (QA)

Perubahan harus diuji oleh seseorang selain pengembang yang menulis
kode tersebut. Ini sangat penting untuk perubahan besar atau berisiko tinggi. Akan sangat berguna
untuk menambahkan rencana pengujian ke deskripsi pull request jika pengujian perubahan tidak sederhana.

Terjemahan
------------

Perubahan pada terjemahan serta terjemahan baru dapat diajukan ke
[halaman Transifex Bitcoin Core](https://www.transifex.com/bitcoin/bitcoin/).

Terjemahan secara berkala diambil dari Transifex dan digabungkan ke dalam repositori git. Lihat
[proses terjemahan](doc/translation_process.md) untuk detail tentang cara kerjanya.

**Penting**: Kami tidak menerima perubahan terjemahan sebagai pull request GitHub karena pengambilan berikutnya dari Transifex akan secara otomatis menimpanya kembali.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---