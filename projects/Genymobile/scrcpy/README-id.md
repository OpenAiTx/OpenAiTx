**Repo GitHub ini (<https://github.com/Genymobile/scrcpy>) adalah satu-satunya sumber resmi untuk proyek ini. Jangan mengunduh rilis dari situs web acak, meskipun namanya mengandung `scrcpy`.**

# scrcpy (v3.2)

<img src="app/data/icon.svg" width="128" height="128" alt="scrcpy" align="right" />

_diucapkan "**scr**een **c**o**py**"_

Aplikasi ini melakukan mirror perangkat Android (video dan audio) yang terhubung melalui USB atau [TCP/IP](doc/connection.md#tcpip-wireless) dan memungkinkan kontrol menggunakan keyboard dan mouse komputer. Tidak memerlukan akses _root_ atau aplikasi yang diinstal di perangkat. Berjalan di _Linux_, _Windows_, dan _macOS_.

![screenshot](assets/screenshot-debian-600.jpg)

Fokus pada:

 - **ringan**: native, hanya menampilkan layar perangkat
 - **performa**: 30~120fps, tergantung perangkat
 - **kualitas**: 1920×1080 atau lebih
 - **latensi rendah**: [35~70ms][lowlatency]
 - **waktu mulai cepat**: ~1 detik untuk menampilkan gambar pertama
 - **tidak mengganggu**: tidak ada yang tertinggal terpasang di perangkat Android
 - **manfaat pengguna**: tanpa akun, tanpa iklan, tanpa internet
 - **kebebasan**: perangkat lunak gratis dan sumber terbuka

[lowlatency]: https://github.com/Genymobile/scrcpy/pull/646

Fitur-fiturnya meliputi:
 - [penerusan audio](doc/audio.md) (Android 11+)
 - [perekaman](doc/recording.md)
 - [virtual display](doc/virtual_display.md)
 - mirror dengan [layar perangkat Android mati](doc/device.md#turn-screen-off)
 - [copy-paste](doc/control.md#copy-paste) dua arah
 - [kualitas yang dapat dikonfigurasi](doc/video.md)
 - [mirroring kamera](doc/camera.md) (Android 12+)
 - [mirror sebagai webcam (V4L2)](doc/v4l2.md) (hanya Linux)
 - simulasi fisik [keyboard][hid-keyboard] dan [mouse][hid-mouse] (HID)
 - dukungan [gamepad](doc/gamepad.md)
 - [mode OTG](doc/otg.md)
 - dan lainnya…

[hid-keyboard]: doc/keyboard.md#physical-keyboard-simulation
[hid-mouse]: doc/mouse.md#physical-mouse-simulation

## Prasyarat

Perangkat Android memerlukan minimal API 21 (Android 5.0).

[Penerusan audio](doc/audio.md) didukung untuk API >= 30 (Android 11+).

Pastikan Anda [mengaktifkan USB debugging][enable-adb] di perangkat Anda.

[enable-adb]: https://developer.android.com/studio/debug/dev-options#enable

Pada beberapa perangkat (terutama Xiaomi), Anda mungkin mendapatkan error berikut:

```
java.lang.SecurityException: Injecting input events requires the caller (or the source of the instrumentation, if any) to have the INJECT_EVENTS permission.
```

Dalam kasus tersebut, Anda perlu mengaktifkan [opsi tambahan][control] `USB debugging (Security Settings)` (ini item yang berbeda dari `USB debugging`) untuk mengontrolnya menggunakan keyboard dan mouse. Setelah opsi ini diatur, perangkat perlu direboot.

[control]: https://github.com/Genymobile/scrcpy/issues/70#issuecomment-373286323

Perlu dicatat bahwa USB debugging tidak diperlukan untuk menjalankan scrcpy dalam [mode OTG](doc/otg.md).


## Dapatkan aplikasinya

 - [Linux](doc/linux.md)
 - [Windows](doc/windows.md) (baca [cara menjalankan](doc/windows.md#run))
 - [macOS](doc/macos.md)


## Tips yang Wajib Diketahui

 - [Mengurangi resolusi](doc/video.md#size) dapat sangat meningkatkan performa (`scrcpy -m1024`)
 - [_Klik kanan_](doc/mouse.md#mouse-bindings) memicu `BACK`
 - [_Klik tengah_](doc/mouse.md#mouse-bindings) memicu `HOME`
 - <kbd>Alt</kbd>+<kbd>f</kbd> mengaktifkan [layar penuh](doc/window.md#fullscreen)
 - Terdapat banyak [shortcut](doc/shortcuts.md) lainnya


## Contoh penggunaan

Ada banyak opsi, [didokumentasikan](#user-documentation) di halaman terpisah. Berikut beberapa contoh yang umum.

 - Tangkap layar dalam H.265 (kualitas lebih baik), batasi ukuran ke 1920, batasi frame rate ke 60fps, nonaktifkan audio, dan kontrol perangkat dengan mensimulasikan keyboard fisik:

    ```bash
    scrcpy --video-codec=h265 --max-size=1920 --max-fps=60 --no-audio --keyboard=uhid
    scrcpy --video-codec=h265 -m1920 --max-fps=60 --no-audio -K  # versi singkat
    ```

 - Mulai VLC di virtual display baru (terpisah dari tampilan perangkat):

    ```bash
    scrcpy --new-display=1920x1080 --start-app=org.videolan.vlc
    ```

 - Rekam kamera perangkat dalam H.265 di 1920x1080 (dan mikrofon) ke file MP4:

    ```bash
    scrcpy --video-source=camera --video-codec=h265 --camera-size=1920x1080 --record=file.mp4
    ```

 - Tangkap kamera depan perangkat dan tampilkan sebagai webcam di komputer (di Linux):

    ```bash
    scrcpy --video-source=camera --camera-size=1920x1080 --camera-facing=front --v4l2-sink=/dev/video2 --no-playback
    ```

 - Kontrol perangkat tanpa mirror dengan mensimulasikan keyboard dan mouse fisik (USB debugging tidak diperlukan):

    ```bash
    scrcpy --otg
    ```

 - Kontrol perangkat menggunakan controller gamepad yang terpasang ke komputer:

    ```bash
    scrcpy --gamepad=uhid
    scrcpy -G  # versi singkat
    ```

## Dokumentasi pengguna

Aplikasi ini menyediakan banyak fitur dan opsi konfigurasi. Semuanya didokumentasikan pada halaman berikut:

 - [Koneksi](doc/connection.md)
 - [Video](doc/video.md)
 - [Audio](doc/audio.md)
 - [Kontrol](doc/control.md)
 - [Keyboard](doc/keyboard.md)
 - [Mouse](doc/mouse.md)
 - [Gamepad](doc/gamepad.md)
 - [Perangkat](doc/device.md)
 - [Jendela](doc/window.md)
 - [Perekaman](doc/recording.md)
 - [Virtual display](doc/virtual_display.md)
 - [Tunnel](doc/tunnels.md)
 - [OTG](doc/otg.md)
 - [Kamera](doc/camera.md)
 - [Video4Linux](doc/v4l2.md)
 - [Shortcut](doc/shortcuts.md)


## Sumber daya

 - [FAQ](FAQ.md)
 - [Terjemahan][wiki] (belum tentu terbaru)
 - [Instruksi build](doc/build.md)
 - [Developer](doc/develop.md)

[wiki]: https://github.com/Genymobile/scrcpy/wiki


## Artikel

- [Memperkenalkan scrcpy][article-intro]
- [Scrcpy sekarang dapat berjalan secara nirkabel][article-tcpip]
- [Scrcpy 2.0, dengan audio][article-scrcpy2]

[article-intro]: https://blog.rom1v.com/2018/03/introducing-scrcpy/
[article-tcpip]: https://www.genymotion.com/blog/open-source-project-scrcpy-now-works-wirelessly/
[article-scrcpy2]: https://blog.rom1v.com/2023/03/scrcpy-2-0-with-audio/

## Kontak

Anda dapat membuka sebuah [issue] untuk laporan bug, permintaan fitur, atau pertanyaan umum.

Untuk laporan bug, silakan baca [FAQ](FAQ.md) terlebih dahulu, mungkin Anda langsung menemukan solusinya.

[issue]: https://github.com/Genymobile/scrcpy/issues

Anda juga dapat menggunakan:

 - Reddit: [`r/scrcpy`](https://www.reddit.com/r/scrcpy)
 - BlueSky: [`@scrcpy.bsky.social`](https://bsky.app/profile/scrcpy.bsky.social)
 - Twitter: [`@scrcpy_app`](https://twitter.com/scrcpy_app)


## Donasi

Saya [@rom1v](https://github.com/rom1v), penulis dan maintainer _scrcpy_.

Jika Anda menghargai aplikasi ini, Anda dapat [mendukung pekerjaan sumber terbuka saya][donate]:
 - [GitHub Sponsors](https://github.com/sponsors/rom1v)
 - [Liberapay](https://liberapay.com/rom1v/)
 - [PayPal](https://paypal.me/rom2v)

[donate]: https://blog.rom1v.com/about/#support-my-open-source-work

## Lisensi

    Hak Cipta (C) 2018 Genymobile
    Hak Cipta (C) 2018-2025 Romain Vimont

    Dilisensikan di bawah Apache License, Versi 2.0 ("Lisensi");
    Anda tidak dapat menggunakan file ini kecuali sesuai dengan Lisensi.
    Anda dapat memperoleh salinan Lisensi di

        http://www.apache.org/licenses/LICENSE-2.0

    Kecuali diwajibkan oleh hukum yang berlaku atau disetujui secara tertulis, perangkat lunak
    yang didistribusikan di bawah Lisensi didistribusikan "APA ADANYA",
    TANPA JAMINAN APA PUN, baik tersurat maupun tersirat.
    Lihat Lisensi untuk perizinan khusus dan batasan bahasa.

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---