# PSFree versi 1.5.1

PSFree adalah kumpulan eksploit untuk konsol PS4. Fokus utama repositori ini adalah untuk PS4, namun kami juga berusaha membuatnya portabel ke PS5.

## Fitur

- **Deteksi Otomatis:** Secara otomatis mendeteksi tipe konsol dan versi firmware (melalui [`src/config.mjs`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/src/config.mjs)).
- **WebKit Exploit (PSFree):** Titik masuk melalui peramban web konsol.
- **Kernel Exploit (Lapse):** Meningkatkan hak akses ke level kernel.
- **Payload Loader:** Setelah eksploitasi kernel berhasil, akan menunggu payload pada port 9020.

## Ruang Lingkup Kerentanan

|               | PSFree    | Lapse      |
| :------------ | :-------- | :--------- |
| PlayStation 4 | 6.00-9.60 | 1.01-12.02 |
| PlayStation 5 | 1.00-5.50 | 1.00-10.01 |

## Didukung oleh Repositori Ini

Tabel berikut menunjukkan versi firmware yang didukung _versi saat ini_ dari repositori ini dan menyediakan rantai eksploit yang fungsional serta telah diuji.

|               | PSFree    | Lapse     |
| :------------ | :-------- | :-------- |
| PlayStation 4 | 7.00-9.60 | 7.00-9.60 |
| PlayStation 5 | N/A       | N/A       |

_Catatan: Dukungan untuk firmware lain yang terdaftar pada tabel "Ruang Lingkup Kerentanan" bisa saja sedang dikerjakan, atau telah didukung pada versi sebelumnya dari repositori ini. Silakan cek [`CHANGELOG.md`](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/CHANGELOG.md) untuk riwayat dukungan._

## Daftar TODO

- [ ] Masalah layar hitam/penyimpanan pada beberapa game tertentu
- [ ] `lapse.mjs`: Cukup set bit untuk hak akses JIT
- [ ] `view.mjs`: Mengasumsikan PS4, tambahkan dukungan untuk PS5 juga
- [ ] Tambahkan dukungan PS5

## Hak Cipta dan Penulis:

AGPL-3.0-or-later (lihat [LICENSE](https://raw.githubusercontent.com/Al-Azif/psfree-lapse/main/LICENSE)). Repositori ini milik grup `anonymous`. Kami juga menyebut kontributor anonim sebagai "anonymous".

## Kredit:

- anonymous untuk dump kernel firmware PS4
- Periksa file terkait untuk setiap kontributor **tambahan**. Kecuali dinyatakan sebaliknya, semua yang ada di sini juga dapat dikreditkan kepada kami.

## Donasi

(Monero/XMR): **86Fk3X9AE94EGKidzRbvyiVgGNYD3qZnuKNq1ZbsomFWXHYm6TtAgz9GNGitPWadkS3Wr9uXoT29U1SfdMtJ7QNKQpW1CVS**

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---