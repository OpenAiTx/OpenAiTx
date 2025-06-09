Ini adalah Python versi 3.15.0 alpha 0
======================================

.. image:: https://github.com/python/cpython/actions/workflows/build.yml/badge.svg?branch=main&event=push
   :alt: Status build CPython di GitHub Actions
   :target: https://github.com/python/cpython/actions

.. image:: https://dev.azure.com/python/cpython/_apis/build/status/Azure%20Pipelines%20CI?branchName=main
   :alt: Status build CPython di Azure DevOps
   :target: https://dev.azure.com/python/cpython/_build/latest?definitionId=4&branchName=main

.. image:: https://img.shields.io/badge/discourse-join_chat-brightgreen.svg
   :alt: Obrolan Discourse Python
   :target: https://discuss.python.org/


Hak Cipta © 2001 Python Software Foundation.  Seluruh hak cipta dilindungi undang-undang.

Lihat bagian akhir file ini untuk informasi hak cipta dan lisensi lebih lanjut.

.. contents::

Informasi Umum
--------------

- Situs web: https://www.python.org
- Kode sumber: https://github.com/python/cpython
- Pelacak isu: https://github.com/python/cpython/issues
- Dokumentasi: https://docs.python.org
- Panduan Pengembang: https://devguide.python.org/

Kontribusi ke CPython
---------------------

Untuk instruksi yang lebih lengkap mengenai kontribusi pada pengembangan CPython,
lihat `Panduan Pengembang`_.

.. _Panduan Pengembang: https://devguide.python.org/

Menggunakan Python
------------------

Paket Python yang dapat diinstal, dan informasi tentang penggunaan Python, tersedia di
`python.org`_.

.. _python.org: https://www.python.org/

Instruksi Build
---------------

Di Unix, Linux, BSD, macOS, dan Cygwin::

    ./configure
    make
    make test
    sudo make install

Ini akan menginstal Python sebagai ``python3``.

Anda dapat memberikan banyak opsi ke skrip configure; jalankan ``./configure --help``
untuk mengetahui lebih lanjut.  Di sistem file macOS yang case-insensitive dan di Cygwin,
eksekutabelnya disebut ``python.exe``; di tempat lain hanya ``python``.

Membangun instalasi Python yang lengkap membutuhkan penggunaan berbagai
pustaka pihak ketiga tambahan, tergantung pada platform build dan
opsi configure Anda.  Tidak semua modul pustaka standar dapat dibangun atau
digunakan di semua platform.  Lihat bagian
`Install dependencies <https://devguide.python.org/getting-started/setup-building.html#build-dependencies>`_
dari `Panduan Pengembang`_ untuk informasi rinci terbaru tentang
dependensi untuk berbagai distribusi Linux dan macOS.

Di macOS, ada opsi configure dan build tambahan terkait
dengan framework macOS dan build universal.  Lihat `Mac/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Mac/README.rst>`_.

Di Windows, lihat `PCbuild/readme.txt
<https://raw.githubusercontent.com/python/cpython/main/PCbuild/readme.txt>`_.

Untuk membangun installer Windows, lihat `Tools/msi/README.txt
<https://raw.githubusercontent.com/python/cpython/main/Tools/msi/README.txt>`_.

Jika Anda mau, Anda dapat membuat subdirektori dan menjalankan configure dari sana.
Sebagai contoh::

    mkdir debug
    cd debug
    ../configure --with-pydebug
    make
    make test

(Hal ini akan gagal jika Anda *juga* membangun di direktori tingkat atas.  Anda harus menjalankan
``make clean`` di direktori tingkat atas terlebih dahulu.)

Untuk mendapatkan build Python yang dioptimalkan, jalankan ``configure --enable-optimizations``
sebelum Anda menjalankan ``make``.  Ini akan mengatur target make default agar mengaktifkan
Profile Guided Optimization (PGO) dan dapat digunakan untuk mengaktifkan Link Time
Optimization (LTO) secara otomatis di beberapa platform.  Untuk detail lebih lanjut, lihat bagian
di bawah ini.

Profile Guided Optimization
^^^^^^^^^^^^^^^^^^^^^^^^^^^

PGO memanfaatkan versi terbaru dari compiler GCC atau Clang.  Jika digunakan,
baik melalui ``configure --enable-optimizations`` atau dengan menjalankan
``make profile-opt`` secara manual tanpa memandang flag configure, proses build
yang dioptimalkan akan melakukan langkah-langkah berikut:

Seluruh direktori Python dibersihkan dari file sementara yang mungkin
dihasilkan dari kompilasi sebelumnya.

Sebuah versi interpreter yang terinstrumentasi dibangun, menggunakan flag compiler
yang sesuai untuk setiap varian. Perlu dicatat bahwa ini hanya langkah perantara.  Binary
yang dihasilkan dari langkah ini tidak baik untuk beban kerja nyata karena memiliki
instruksi profiling yang tertanam di dalamnya.

Setelah interpreter terinstrumentasi dibangun, Makefile akan menjalankan beban kerja pelatihan.
Ini diperlukan untuk melakukan profiling eksekusi interpreter.
Perlu dicatat juga bahwa setiap output, baik stdout maupun stderr, yang mungkin muncul pada langkah ini
akan disembunyikan.

Langkah terakhir adalah membangun interpreter yang sebenarnya, menggunakan informasi
yang dikumpulkan dari yang terinstrumentasi.  Hasil akhirnya adalah binary Python
yang telah dioptimalkan; cocok untuk distribusi atau instalasi produksi.

Link Time Optimization
^^^^^^^^^^^^^^^^^^^^^^

Diaktifkan melalui flag ``--with-lto`` pada configure.  LTO memanfaatkan
kemampuan toolchain compiler terbaru untuk mengoptimalkan lintas batas file ``.o``
saat membangun eksekutabel akhir atau pustaka bersama untuk mendapatkan kinerja tambahan.


Apa yang Baru
-------------

Kami memiliki ikhtisar lengkap mengenai perubahan di dokumen `Apa yang baru di Python
3.15 <https://docs.python.org/3.15/whatsnew/3.15.html>`_.  Untuk log perubahan yang lebih
rinci, baca `Misc/NEWS
<https://raw.githubusercontent.com/python/cpython/main/Misc/NEWS.d>`_, tetapi
daftar lengkap perubahan hanya dapat diperoleh dari `riwayat commit
<https://github.com/python/cpython/commits/main>`_.

Jika Anda ingin menginstal beberapa versi Python, lihat bagian di bawah ini
berjudul "Menginstal beberapa versi".


Dokumentasi
-----------

`Dokumentasi untuk Python 3.15 <https://docs.python.org/3.15/>`_ tersedia online,
diperbarui setiap hari.

Dokumentasi juga dapat diunduh dalam berbagai format untuk akses yang lebih cepat.
Dokumentasi dapat diunduh dalam format HTML, PDF, dan reStructuredText; versi terakhir
terutama untuk penulis dokumentasi, penerjemah, dan orang-orang dengan kebutuhan
formatting khusus.

Untuk informasi tentang membangun dokumentasi Python, lihat `Doc/README.rst
<https://raw.githubusercontent.com/python/cpython/main/Doc/README.rst>`_.

Pengujian
---------

Untuk menguji interpreter, ketik ``make test`` di direktori tingkat atas.  Set
uji akan menghasilkan beberapa output.  Anda umumnya dapat mengabaikan pesan tentang
uji yang dilewati karena fitur opsional yang tidak dapat diimpor.  Jika ada pesan
yang dicetak tentang uji yang gagal atau traceback atau core dump dihasilkan,
berarti ada yang salah.

Secara default, pengujian dicegah menggunakan sumber daya secara berlebihan seperti ruang disk dan
memori.  Untuk mengaktifkan pengujian ini, jalankan ``make buildbottest``.

Jika ada pengujian gagal, Anda dapat menjalankan ulang pengujian yang gagal dalam mode verbose.
Sebagai contoh, jika ``test_os`` dan ``test_gdb`` gagal, Anda dapat menjalankan::

    make test TESTOPTS="-v test_os test_gdb"

Jika kegagalan berlanjut dan tampaknya merupakan masalah dengan Python, bukan
lingkungan Anda, Anda dapat `melaporkan bug
<https://github.com/python/cpython/issues>`_ dan sertakan output relevan dari
perintah tersebut untuk menunjukkan masalahnya.

Lihat `Menjalankan & Menulis Tes <https://devguide.python.org/testing/run-write-tests.html>`_
untuk informasi lebih lanjut tentang menjalankan pengujian.

Menginstal beberapa versi
----------------------------

Di sistem Unix dan Mac jika Anda bermaksud menginstal beberapa versi Python
menggunakan prefix instalasi yang sama (argumen ``--prefix`` pada skrip configure)
Anda harus memastikan bahwa eksekutabel python utama Anda tidak
ditimpa oleh instalasi versi lain.  Semua file dan
direktori yang diinstal menggunakan ``make altinstall`` mencakup versi mayor dan minor
sehingga dapat hidup berdampingan.  ``make install`` juga membuat
``${prefix}/bin/python3`` yang merujuk ke ``${prefix}/bin/python3.X``.  Jika Anda
bermaksud menginstal beberapa versi menggunakan prefix yang sama Anda harus memutuskan versi mana
(jika ada) yang menjadi versi "utama" Anda.  Instal versi tersebut menggunakan
``make install``.  Instal semua versi lainnya menggunakan ``make altinstall``.

Sebagai contoh, jika Anda ingin menginstal Python 2.7, 3.6, dan 3.15 dengan 3.15 sebagai
versi utama, Anda harus menjalankan ``make install`` di direktori build 3.15 Anda
dan ``make altinstall`` di yang lainnya.


Jadwal Rilis
------------

Lihat `PEP 790 <https://peps.python.org/pep-0790/>`__ untuk detail rilis Python 3.15.


Informasi Hak Cipta dan Lisensi
------------------------------


Hak Cipta © 2001 Python Software Foundation.  Semua hak dilindungi undang-undang.

Hak Cipta © 2000 BeOpen.com.  Semua hak dilindungi undang-undang.

Hak Cipta © 1995-2001 Corporation for National Research Initiatives.  Semua
hak dilindungi undang-undang.

Hak Cipta © 1991-1995 Stichting Mathematisch Centrum.  Semua hak dilindungi undang-undang.

Lihat `LICENSE <https://github.com/python/cpython/blob/main/LICENSE>`_ untuk
informasi tentang sejarah perangkat lunak ini, syarat & ketentuan penggunaan, dan
PENAFIAN ATAS SEGALA JAMINAN.

Distribusi Python ini *tidak* mengandung kode GNU General Public License (GPL),
sehingga dapat digunakan dalam proyek proprietary.  Terdapat antarmuka ke beberapa kode GNU
namun ini sepenuhnya opsional.

Semua merek dagang yang disebutkan di sini adalah milik pemegangnya masing-masing.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-09

---