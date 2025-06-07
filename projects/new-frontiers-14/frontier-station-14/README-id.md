<div class="header" align="center">
<img alt="Frontier Station" height="300" src="https://github.com/new-frontiers-14/frontier-station-14/blob/master/Resources/Textures/_NF/Logo/logo.png?raw=true" />
</div>

Frontier Station adalah fork dari [Space Station 14](https://github.com/space-wizards/space-station-14) yang berjalan di atas engine [Robust Toolbox](https://github.com/space-wizards/RobustToolbox) yang ditulis dalam C#.

Ini adalah repo utama untuk Frontier Station.

Jika Anda ingin meng-host atau membuat konten untuk Frontier Station, inilah repo yang Anda butuhkan. Repo ini berisi RobustToolbox serta paket konten untuk pengembangan paket konten baru.

## Tautan

<div class="header" align="center">  
[Discord](https://discord.gg/tpuAT7d3zm/) | [Steam](https://store.steampowered.com/app/1255460/Space_Station_14/) | [Patreon](https://www.patreon.com/frontierstation14) | [Wiki](https://frontierstation.wiki.gg/)
</div>

## Dokumentasi/Wiki

[Wiki](https://frontierstation.wiki.gg/) kami memiliki dokumentasi tentang konten Frontier Station.

## Kontribusi

Kami dengan senang hati menerima kontribusi dari siapa saja. Gabunglah ke Discord jika Anda ingin membantu. Kami memiliki [daftar ide](https://discord.com/channels/1123826877245694004/1127017858833068114) yang dapat dikerjakan dan siapa saja bisa mengambilnya. Jangan ragu untuk meminta bantuan juga!

Saat ini kami tidak menerima terjemahan game di repository utama kami. Jika Anda ingin menerjemahkan game ke bahasa lain, pertimbangkan untuk membuat fork atau berkontribusi ke fork.

Jika Anda melakukan kontribusi apa pun, mohon pastikan membaca bagian marker di [MARKERS.md](https://github.com/new-frontiers-14/frontier-station-14/blob/master/MARKERS.md)
Setiap perubahan yang dilakukan pada file milik upstream kami harus diberi penanda sesuai dengan yang dijelaskan di sana.

## Pembangunan

1. Clone repo ini:
```shell
git clone https://github.com/new-frontiers-14/frontier-station-14.git
```
2. Masuk ke folder proyek dan jalankan `RUN_THIS.py` untuk menginisialisasi submodul dan memuat engine:
```shell
cd frontier-station-14
python RUN_THIS.py
```
3. Kompilasi solusi:  

Bangun server menggunakan `dotnet build`.

[Instruksi lebih detail tentang membangun proyek.](https://docs.spacestation14.com/en/general-development/setup.html)

## Lisensi

Konten yang dikontribusikan ke repository ini setelah commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 dilisensikan di bawah GNU Affero General Public License versi 3.0, kecuali dinyatakan lain (lihat bagian Atribusi di bawah). Lihat `LICENSE-AGPLv3.txt`.
Konten yang dikontribusikan sebelum commit 2fca06eaba205ae6fe3aceb8ae2a0594f0effee0 dilisensikan di bawah lisensi MIT, kecuali dinyatakan lain. Lihat `LICENSE-MIT.txt`.

[2fca06eaba205ae6fe3aceb8ae2a0594f0effee0](https://github.com/new-frontiers-14/frontier-station-14/commit/2fca06eaba205ae6fe3aceb8ae2a0594f0effee0) didorong pada 1 Juli 2024 pukul 16:04 UTC

Sebagian besar aset dilisensikan di bawah [CC-BY-SA 3.0](https://creativecommons.org/licenses/by-sa/3.0/) kecuali dinyatakan lain. Aset memiliki lisensi dan hak cipta yang ditentukan dalam file metadata. Sebagai contoh, lihat [metadata untuk crowbar](https://raw.githubusercontent.com/new-frontiers-14/frontier-station-14/master/Resources/Textures/Objects/Tools/crowbar.rsi/meta.json).  

Perhatikan bahwa beberapa aset dilisensikan di bawah [CC-BY-NC-SA 3.0](https://creativecommons.org/licenses/by-nc-sa/3.0/) non-komersial atau lisensi non-komersial serupa dan harus dihapus jika Anda ingin menggunakan proyek ini secara komersial.

## Atribusi

Ketika kami mengambil konten dari fork lain, kami mengorganisasi konten mereka ke subfolder khusus repo untuk melacak atribusi dan membatasi konflik merge.

Konten di bawah subdirektori ini berasal dari fork masing-masing dan mungkin berisi modifikasi. Modifikasi ini ditandai dengan komentar di sekitar baris yang diubah.

| Subdirektori | Nama Fork | Repo Fork | Lisensi |
|--------------|-----------|-----------|---------|
| `_NF` | Frontier Station | https://github.com/new-frontiers-14/frontier-station-14 | AGPL 3.0 |
| `_CD` | Cosmatic Drift | https://github.com/cosmatic-drift-14/cosmatic-drift | MIT |
| `_Corvax` | Corvax | https://github.com/space-syndicate/space-station-14 | MIT |
| `_Corvax` | Corvax Frontier | https://github.com/Corvax-Frontier/Frontier | AGPL 3.0 |
| `_DV` | Delta-V | https://github.com/DeltaV-Station/Delta-v | AGPL 3.0 |
| `_EE` | Einstein Engines | https://github.com/Simple-Station/Einstein-Engines | AGPL 3.0 |
| `_Emberfall` | Emberfall | https://github.com/emberfall-14/emberfall | MPL 2.0 |
| `_EstacaoPirata` | Estacao Pirata | https://github.com/Day-OS/estacao-pirata-14 | AGPL 3.0 |
| `_Goobstation` | Goob Station | https://github.com/Goob-Station/Goob-Station | AGPL 3.0 |
| `_Impstation` | Impstation | https://github.com/impstation/imp-station-14 | AGPL 3.0 |
| `_NC14` | Nuclear 14 | https://github.com/Vault-Overseers/nuclear-14 | AGPL 3.0 |
| `Nyanotrasen` | Nyanotrasen | https://github.com/Nyanotrasen/Nyanotrasen | MIT |

Repo tambahan yang telah kami port fitur-fiturnya tanpa subdirektori tercantum di bawah ini.

| Nama Fork | Repo Fork | Lisensi |
|-----------|-----------|---------|
| Monolith | https://github.com/Monolith-Station/Monolith | AGPL 3.0 |
| Space Station 14 | https://github.com/space-wizards/space-station-14 | MIT |
| White Dream | https://github.com/WWhiteDreamProject/wwdpublic | AGPL 3.0 |

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---