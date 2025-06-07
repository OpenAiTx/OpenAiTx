# Enthium - Engrammer bertemu Hands Down Promethium

![Foto Enthium v7 pada keyboard Glove80 saya](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-photograph-Enthium.jpg)

Adaptasi dari layout keyboard [Engrammer] dan [Hands Down Promethium] ini meningkatkan performa layout kedua pada analisa layout keyboard (lihat di bawah) dengan mencerminkan secara horizontal untuk mengembalikan kemiripan dengan layout [Engram 2.0 Arno] (CIEA pada home row tangan kiri; PF ditukar dengan WV agar seperti Engram) dan layout [Dvorak] (HTNS pada home row tangan kanan), serta mengoptimalkan peletakan tanda baca untuk pemrograman sesuai semangat layout Engrammer.

Perbedaan antara Engram/mer dan Enthium sangat minimal sehingga seseorang dapat sepenuhnya berpindah ke layout ini dengan sekitar 6 jam latihan, tersebar selama 2-3 hari (mulai Jumat dan gunakan akhir pekan), untuk membuka semua huruf dalam pelatihan [KeyBr].

Lihat juga: [post blog saya](https://sunaku.github.io/enthium-keyboard-layout.html) tentang perjalanan tak terduga "down the rabbit hole" yang membawa saya mengembangkan layout keyboard ini.

[Hands Down Promethium]: https://reddit.com/r/KeyboardLayouts/comments/1g66ivi
[Arno's Engram 2.0]:     https://engram.dev
[Engrammer]:             https://github.com/sunaku/engrammer
[Dvorak]:                https://www.dvzine.org
[KeyBr]:                 https://github.com/aradzie/keybr.com#readme

## Layout

      q y o u - x l d w z
    b c i e a , k h t n s v
      ' / = . ; j m g p f
                r

>![Rendering Enthium v7 di keyboard laptop.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)
>![Rendering Enthium v7 di keyboard Glove80 saya.](https://github.com/sunaku/glove80-keymaps/raw/main/README/base-layer-diagram-Enthium.png)

<!-- vim-markdown-toc GFM -->

* [Rasional](#rationale)
  * [Penyimpangan: PF dan WV](#deviation-pf-and-wv)
  * [Penyimpangan: B dan V](#deviation-b-and-v)
* [Performa](#performance)
  * [Analisa Cyanophage](#cyanophage-analyzer)
  * [Analisa KeySolve](#keysolve-analyzer)
  * [Analisa Oxey](#oxeys-analyzer)
  * [Perbandingan](#comparison)
* [Instalasi](#installation)
  * [Pengaturan Linux](#linux-setup)
  * [Pengaturan MacOS](#macos-setup)
    * [Instalasi](#installation-1)
    * [Modifikasi Kompleks](#complex-modification)
    * [Uninstalasi](#uninstallation)
* [Lisensi](#license)

<!-- vim-markdown-toc -->

## Rasional

* Q dan Z dipisahkan ke tangan yang berbeda untuk keseimbangan dan simetri.

* B dan V berada di home row pada tombol kelingking lateral (CapsLock, Apostrof) untuk menghindari harus meraih ke atas bagi mereka yang memiliki jari kelingking pendek atau [jari kelingking yang lemah].

* Tanda apostrof ditempatkan jauh (pada jari yang berbeda sepenuhnya) dari YOU dan I sehingga bisa diketik tanpa bigram jari yang sama seperti `you'd` dan `I'd`.

* Koma dan titik koma dikelompokkan untuk memudahkan pencarian f/F/t/T di Vim dan juga mencerminkan urutan relatif K dan J di tangan kanan.

* Walaupun titik dan koma terbalik secara simbol shift (`>` dan `<`), pengaturan ini membantu mengurangi bigram stretch lateral dan juga menumpuknya secara vertikal pada keyboard row-staggered tradisional.

* Tanda minus berada di jari telunjuk (seperti koma, titik, dan titik koma) untuk konsistensi penempatan tanda baca pemisah kata/kalimat dan untuk kemudahan akses ke karakter `_` (underscore) yang sering digunakan dalam pemrograman, terutama pada keyboard row-staggered di mana peletakannya mengikuti arah ekstensi alami jari telunjuk kiri, meminimalkan usaha.

* Slash dan titik memungkinkan rolling `/.`, `./`, dan `../` pada path sistem file.

[weakened pinky fingers]: https://reddit.com/r/KeyboardLayouts/comments/1fy8nve/_/lqulnww/

### Penyimpangan: PF dan WV

PF ditukar dengan WV untuk mengatasi ketidaknyamanan berikut:

* WN adalah bigram jari yang sama naik tangga (stair-step ascension) yang seharusnya bisa digeser ke bawah
* DW (lompat 2u) tidak senyaman di Vim seperti pada Engram (di mana mereka bersebelahan)
* FG (lompat 2u) tidak senyaman untuk job background shell (`bg`, `fg`) seperti pada Engram
* SW (setengah scissor) terasa sedikit lebih lemah menggulung ke dalam daripada meraih ke atas (seperti di Engram)
* FF (misal "stu*ff*") agak merepotkan bagi kelingking untuk menekan dua kali di baris atas

Saya sebenarnya tidak ingin menyimpang dari layout Hands Down Promethium yang asli (turunan "Enthium" ini awalnya hanya dimaksudkan sebagai cermin horizontal sederhana, plus beberapa tanda baca yang diatur ulang) sehingga saya dengan berat hati mencoba playground analisa layout keyboard untuk melihat seberapa buruk jika menukar PF dengan WV... dan ternyata, perubahan ini hampir tidak memengaruhi performa layout:

* Analisa Oxey tidak menunjukkan perubahan sama sekali pada statistik!
* Analisa KeySolve menunjukkan peningkatan FSB dari 0,14% menjadi 0,37% namun statistik lain membaik: FSS turun dari 0,82% ke 0,48%, HSB turun dari 6,05% ke 5,64%, dan HSS turun dari 5,97% ke 5,50%; sisanya identik.
* Analisa Cyanophage Total Word Effort naik dari 730,9 ke 735,9 tapi statistik lain tetap sama!

Saya _sangat senang_ eksperimen ini berhasil karena membuat layout jauh lebih nyaman untuk saya dalam praktik, dan juga semakin mengurangi hambatan bagi orang lain yang ingin beralih dari Engrammer ke Enthium. :)

### Penyimpangan: B dan V

B dan V dipindah dari baris atas ke home row lateral untuk menghindari harus meraih ke atas bagi mereka yang memiliki jari kelingking pendek atau [jari kelingking yang lemah]. Tombol mereka diisi ulang oleh huruf yang paling jarang digunakan dalam bahasa Inggris: Q dan Z.

Pada analisa Cyanophage, perubahan ini menurunkan Pinky/Ring Scissors dari 0,49% menjadi 0,35% (penurunan besar!) dan Skip Bigrams (2u) dari 0,30% menjadi 0,29%. Analisa lain tidak sepenuhnya memahami penempatan tombol kelingking lateral, sebagaimana dijelaskan pada catatan di setiap subjudul analisa, tetapi analisa Oxey melaporkan penurunan SFB yang signifikan dari 0,829% menjadi 0,818%.

## Performa

### [Analisa Cyanophage][cNT]

> **CATATAN:** Analisa ini saat ini memiliki keterbatasan yaitu hanya mendukung penempatan huruf pada ibu jari kiri dan bukan kanan, sehingga layout ini dicerminkan secara horizontal untuk analisa. Cerminan tidak mempengaruhi hasil.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/cyanophage.png)

Statistik keseluruhan:
* Total Word Effort: 748,5
* Effort:            432,54

Penggunaan jari:
* Same Finger Bigrams: 0,55%
* Skip Bigrams (2u):   0,29%
* Lat Stretch Bigrams: 0,23%
* Pinky/Ring Scissors: 0,34%

Statistik trigram:
* alt:             37,45%
* bigram roll in:  29,02%
* bigram roll out: 14,67%
* other:           8,28%
* alt sfs:         5,10%
* redirect:        2,14%
* roll in:         1,71%
* weak redirect:   1,32%
* roll out:        0,31%

### [Analisa KeySolve](https://grassfedreeve.github.io/keysolve-web/)

> **CATATAN:** Analisa ini saat ini tidak mendukung penempatan huruf di tombol kelingking lateral home row seperti CapsLock tradisional dan apostrof, sehingga hasil ini mungkin tidak akurat. Misalnya, persentase SFB di sini mengasumsikan bahwa R B V semuanya diketik dengan ibu jari padahal sebenarnya mereka pada jari berbeda: R di ibu jari kanan, B di kelingking kiri, V di kelingking kanan.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve1.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve2.png)
![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/keysolve3.png)

Statistik keseluruhan:

    BIGRAMS     SFB: 0.97%      LSB: 0.44%      HSB: 4.79%      FSB: 0.35%
    SKIPGRAMS   SFS: 6.99%      LSS: 0.92%      HSS: 4.66%      FSS: 0.38%
    TRIGRAMS    ALT: 41.24%     ROL: 40.71%     ONE: 2.47%      RED: 1.66%

Penggunaan jari:

    LEFT        LI: 13.91%      LM: 20.17%      LR: 8.70%       LP: 3.05%
    RIGHT       RI: 13.12%      RM: 14.59%      RR: 10.60%      RP: 7.94%
    TOTAL               LH: 45.83%                      RH: 54.17%

Sumber khusus untuk copy/paste:

    q y o u - x l d w z
    c i e a , k h t n s
    ' / = . ; j m g p f
    r b v

### [Analisa Oxey](https://oxey.dev/playground/index.html)

> **CATATAN:** Analisa ini saat ini tidak mendukung penempatan huruf di tombol kelingking lateral home row seperti CapsLock tradisional dan apostrof, sehingga hasil ini mungkin tidak akurat. Misalnya, persentase SFB di sini mengasumsikan bahwa B dan V diketik dengan ibu jari kiri padahal sebenarnya mereka pada jari berbeda: B dengan kelingking kiri dan V dengan kelingking kanan.

![Screenshot](https://raw.githubusercontent.com/sunaku/enthium/main/stats/enthium/oxey.png)

Statistik keseluruhan:
* Sfb:              0,811%
* Dsfb:             6,286%
* Lsb:              0,372%
* Inrolls:          29,442%
* Outrolls:         15,841%
* Total Rolls:      45,283%
* Onehands:         2,348%
* Alternates:       31,877%
* Alternates (sfs): 7,284%
* Total Alternates: 39,161%
* Redirects:        3,864%
* BadRedirects:     1,002%
* Total Redirects:  4,866%
* Other:            8,341%
* Invalid:          0,001%

Penggunaan jari:

    finger 0:   3,63%   finger 9:       8,60%
    finger 1:   9,08%   finger 8:       10,65%
    finger 2:   19,30%  finger 7:       14,56%
    finger 3:   13,28%  finger 6:       12,33%

    Left hand:   45,29% Right hand:     46,14%
    Left center: 1,384% Right center:   1,189%

    Home keys usage: 56,37%

Sfb% per jari:

    finger 0:   0,011%  finger 9:       0,024%
    finger 1:   0,047%  finger 8:       0,100%
    finger 2:   0,122%  finger 7:       0,051%
    finger 3:   0,339%  finger 6:       0,114%

### Perbandingan

> **CATATAN:** Analisa Oxey saat ini tidak mendukung penempatan huruf di tombol kelingking lateral home row seperti CapsLock tradisional dan apostrof, sehingga hasil ini mungkin tidak akurat. Misalnya, persentase SFB di sini mengasumsikan bahwa B dan V diketik dengan ibu jari kiri padahal sebenarnya mereka pada jari berbeda: B dengan kelingking kiri dan V dengan kelingking kanan. Sebagai gantinya, pertimbangkan [hasil analisa Cyanophage](#cyanophage-analyzer) karena memperhitungkan tombol kelingking lateral dan satu tombol huruf ibu jari.

Komunitas [layout keyboard][rKL] biasanya merekomendasikan [panduan dan tabel perbandingan Pascal Getreuer][PGt] sebagai titik awal eksplorasi layout, dan Anda akan lihat bahwa Enthium termasuk di antara layout terbaik (secara statistik) di sana:

* 0,811% SFBs -- juara 🥈 kedua; hanya dikalahkan Focal
* 0,372% LSBs -- juara 🥇 pertama; mengalahkan seluruh tabel!
* 45,283% rolls -- mengalahkan Nerps, Gallium, MTGAP, Graphite, Dvorak, Halmak, dll.
* 4,866% redirects -- mengalahkan MTGAP, Sturdy, Recurva, APTv3, Canary, Colemak, dll.
* 2,80% pinky off _tanpa_ lateral -- mengalahkan Graphite, Canary, Gallium, MTGAP, dll.
  * `Q` (0,10%) + `'` (0,48%) + `Z` (0,10%) + `F` (2,12%)
* 5,35% pinky off _dengan_ lateral -- mengalahkan Engram, Halmak; dikalahkan yang lain
  * `Q` (0,10%) + `'` (0,48%) + `Z` (0,10%) + `F` (2,12%) + `B` (1,49%) + `V` (1,06%)

[rKL]: https://www.reddit.com/r/KeyboardLayouts/
[PGt]: https://getreuer.info/posts/keyboards/alt-layouts/index.html#which-alt-keyboard-layout-should-i-learn

Untuk kelengkapan, saya telah membuat tabel [statistik untuk layout ini dan yang terkait](https://raw.githubusercontent.com/sunaku/enthium/main/stats/):

[cNT]: https://cyanophage.github.io/playground.html?layout=zwdlx-uoyq%5Csnthk%2Caeicbfpgmj%3B.%3D%2F%27vr&mode=ergo&lan=english
[cPM]: https://cyanophage.github.io/playground.html?layout=fpdlx%3Buoybzsnthk%2Caeicqvwgmj-.%27%3D%2F%5Cr&mode=ergo&lan=english
[cNG]: https://cyanophage.github.io/playground.html?layout=byou%27%3Bldwvzciea%2C.htsnqgxjk-%2Frmfp%5C%5E&mode=ergo&lan=english
[cDV]: https://cyanophage.github.io/playground.html?layout=%27%2C.pyfgcrl%2Faoeuidhtns-%3Bqjkxbmwvz%5C%5E&mode=ergo&lan=english
[cCD]: https://cyanophage.github.io/playground.html?layout=qwfpbjluy%3B-arstgmneio%27zxcdvkh%2C.%2F%5C%5E&mode=ergo&lan=english

| Analyzer   | Kategori  | Statistik           | [Enthium][cNT] | [Promethium][cPM] | [Engrammer][cNG] | [Dvorak][cDV] | [Colemak-DH][cCD] |
| ---------- | --------- | ------------------- | -------------- | ----------------- | ---------------- | ------------- | ----------------- |
| Oxey's     | Bigrams   | SFB                 | 0,811%         | 0,868%            | 1,511%           | 2,779%        | 1,367%            |
| Oxey's     | Bigrams   | DSFB                | 6,286%         | 6,761%            | 7,620%           | 6,979%        | 8,767%            |
| Oxey's     | Bigrams   | LSB                 | 0,372%         | 0,404%            | 0,671%           | 1,255%        | 1,975%            |
| Oxey's     | Trigrams  | Inrolls             | 29,442%        | 29,333%           | 28,273%          | 23,820%       | 25,173%           |
| Oxey's     | Trigrams  | Outrolls            | 15,841%        | 14,526%           | 14,050%          | 15,104%       | 20,940%           |
| Oxey's     | Trigrams  | Total Rolls         | 45,283%        | 43,858%           | 42,323%          | 38,924%       | 46,113%           |
| Oxey's     | Trigrams  | Onehands            | 2,348%         | 2,189%            | 2,146%           | 0,624%        | 2,484%            |
| Oxey's     | Trigrams  | Alternates          | 31,877%        | 33,770%           | 32,483%          | 35,769%       | 22,913%           |
| Oxey's     | Trigrams  | Alternates (SFS)    | 7,284%         | 8,205%            | 8,752%           | 8,787%        | 7,461%            |
| Oxey's     | Trigrams  | Total Alternates    | 39,161%        | 41,974%           | 41,235%          | 44,556%       | 30,375%           |
| Oxey's     | Trigrams  | Redirects           | 3,864%         | 2,273%            | 3,103%           | 2,639%        | 9,081%            |
| Oxey's     | Trigrams  | BadRedirects        | 1,002%         | 1,236%            | 1,386%           | 0,818%        | 1,498%            |
| Oxey's     | Trigrams  | Total Redirects     | 4,866%         | 3,509%            | 4,489%           | 3,458%        | 10,579%           |
| Oxey's     | Trigrams  | Other               | 8,341%         | 8,468%            | 9,806%           | 12,437%       | 9,202%            |
| Oxey's     | Trigrams  | Invalid             | 0,001%         | 0,001%            | 0,001%           | 0,001%        | 1,248%            |
| Oxey's     | Usage     | Finger 0            | 3,63%          | 9,56%             | 6,58%            | 8,50%         | 8,12%             |
| Oxey's     | Usage     | Finger 1            | 9,08%          | 10,65%            | 9,21%            | 8,72%         | 8,04%             |
| Oxey's     | Usage     | Finger 2            | 19,30%         | 14,56%            | 19,47%           | 12,99%        | 11,55%            |
| Oxey's     | Usage     | Finger 3            | 13,28%         | 12,33%            | 13,35%           | 14,95%        | 19,19%            |
| Oxey's     | Usage     | Finger 6            | 12,33%         | 13,28%            | 16,04%           | 16,33%        | 18,88%            |
| Oxey's     | Usage     | Finger 7            | 14,56%         | 19,77%            | 14,93%           | 13,73%        | 15,60%            |
| Oxey's     | Usage     | Finger 8            | 10,65%         | 9,01%             | 10,31%           | 13,84%        | 10,11%            |
| Oxey's     | Usage     | Finger 9            | 8,60%          | 4,62%             | 9,90%            | 10,59%        | 7,77%             |
| Oxey's     | Usage     | Left hand           | 45,29%         | 47,10%            | 48,61%           | 45,16%        | 46,89%            |
| Oxey's     | Usage     | Right hand          | 46,14%         | 46,68%            | 51,18%           | 54,49%        | 52,36%            |
| Oxey's     | Usage     | Left center         | 1,384%         | 1,189%            | 1,765%           | 9,208%        | 4,592%            |
| Oxey's     | Usage     | Right center        | 1,189%         | 1,384%            | 1,294%           | 7,257%        | 3,393%            |
| Oxey's     | Usage     | Home keys           | 56,37%         | 56,37%            | 56,37%           | 56,70%        | 62,31%            |
| Oxey's     | SFB%      | Finger 0            | 0,011%         | 0,028%            | 0,012%           | 0,020%        | 0,041%            |
| Oxey's     | SFB%      | Finger 1            | 0,047%         | 0,100%            | 0,089%           | 0,028%        | 0,047%            |
| Oxey's     | SFB%      | Finger 2            | 0,122%         | 0,051%            | 0,230%           | 0,253%        | 0,186%            |
| Oxey's     | SFB%      | Finger 3            | 0,339%         | 0,114%            | 0,591%           | 1,075%        | 0,219%            |
| Oxey's     | SFB%      | Finger 6            | 0,114%         | 0,339%            | 0,380%           | 0,433%        | 0,388%            |
| Oxey's     | SFB%      | Finger 7            | 0,051%         | 0,185%            | 0,053%           | 0,494%        | 0,341%            |
| Oxey's     | SFB%      | Finger 8            | 0,100%         | 0,040%            | 0,098%           | 0,256%        | 0,137%            |
| Oxey's     | SFB%      | Finger 9            | 0,024%         | 0,011%            | 0,058%           | 0,220%        | 0,007%            |
| KeySolve   | Bigrams   | SFB                 | 0,97%          | 0,94%             | 1,56%            | 2,62%         | 1,49%             |
| KeySolve   | Bigrams   | LSB                 | 0,44%          | 0,45%             | 0,98%            | 1,17%         | 2,21%             |
| KeySolve   | Bigrams   | HSB                 | 4,79%          | 6,04%             | 3,02%            | 6,11%         | 5,93%             |
| KeySolve   | Bigrams   | FSB                 | 0,35%          | 0,26%             | 0,30%            | 0,14%         | 0,37%             |
| KeySolve   | Skipgrams | SFS                 | 6,99%          | 7,02%             | 7,50%            | 7,00%         | 7,95%             |
| KeySolve   | Skipgrams | LSS                 | 0,92%          | 0,93%             | 1,34%            | 4,48%         | 1,75%             |
| KeySolve   | Skipgrams | HSS                 | 4,66%          | 6,11%             | 6,91%            | 8,56%         | 6,49%             |
| KeySolve   | Skipgrams | FSS                 | 0,38%          | 0,78%             | 0,81%            | 1,22%         | 0,78%             |
| KeySolve   | Trigrams  | ALT                 | 41,24%         | 40,37%            | 39,59%           | 41,70%        | 27,58%            |
| KeySolve   | Trigrams  | ROL                 | 40,71%         | 40,84%            | 39,35%           | 37,19%        | 42,78%            |
| KeySolve   | Trigrams  | ONE                 | 2,47%          | 2,66%             | 2,65%            | 0,43%         | 2,45%             |
| KeySolve   | Trigrams  | RED                 | 1,66%          | 1,78%             | 2,65%            | 2,25%         | 6,74%             |
| KeySolve   | Usage     | LI                  | 13,91%         | 13,91%            | 13,91%           | 14,56%        | 18,82%            |
| KeySolve   | Usage     | LM                  | 20,17%         | 20,92%            | 20,30%           | 13,96%        | 10,18%            |
| KeySolve   | Usage     | LR                  | 8,70%          | 8,70%             | 8,83%            | 9,55%         | 7,83%             |
| KeySolve   | Usage     | LP                  | 3,05%          | 3,64%             | 5,72%            | 8,24%         | 7,63%             |
| KeySolve   | Usage     | RI                  | 13,12%         | 13,12%            | 16,52%           | 16,90%        | 20,00%            |
| KeySolve   | Usage     | RM                  | 14,59%         | 14,59%            | 15,03%           | 13,35%        | 16,91%            |
| KeySolve   | Usage     | RR                  | 10,60%         | 10,60%            | 10,08%           | 13,36%        | 10,46%            |
| KeySolve   | Usage     | RP                  | 7,94%          | 8,95%             | 9,47%            | 10,08%        | 8,16%             |
| KeySolve   | Total     | LH                  | 45,83%         | 47,18%            | 48,75%           | 46,31%        | 44,46%            |
| KeySolve   | Total     | RH                  | 54,17%         | 52,82%            | 51,25%           | 53,69%        | 55,54%            |
| Cyanophage | Summary   | Total Word Effort   | 748,5          | 732,3             | 899,8            | 1185,5        | 1048,2            |
| Cyanophage | Summary   | Effort              | 432,54         | 398,07            | 457,44           | 769,78        | 535,05            |
| Cyanophage | Bigrams   | Same Finger Bigrams | 0,55%          | 0,58%             | 0,99%            | 1,87%         | 0,91%             |
| Cyanophage | Bigrams   | Skip Bigrams (2u)   | 0,29%          | 0,36%             | 0,39%            | 0,45%         | 0,41%             |
| Cyanophage | Bigrams   | Lat Stretch Bigrams | 0,23%          | 0,24%             | 0,41%            | 0,80%         | 1,27%             |
| Cyanophage | Bigrams   | Pinky/Ring Scissors | 0,34%          | 0,42%             | 0,71%            | 0,40%         | 0,65%             |
| Cyanophage | Trigrams  | Alt                 | 37,45%         | 36,98%            | 35,62%           | 39,08%        | 25,43%            |
| Cyanophage | Trigrams  | Alt SFS             | 5,10%          | 5,27%             | 5,93%            | 5,85%         | 5,47%             |
| Cyanophage | Trigrams  | Roll in             | 1,71%          | 1,37%             | 1,82%            | 0,86%         | 1,50%             |
| Cyanophage | Trigrams  | Roll out            | 0,31%          | 0,11%             | 0,29%            | 0,27%         | 0,98%             |
| Cyanophage | Trigrams  | Bigram roll in      | 29,02%         | 29,18%            | 28,14%           | 23,51%        | 25,18%            |
| Cyanophage | Trigrams  | Bigram roll out     | 14,67%         | 14,56%            | 14,03%           | 15,14%        | 21,55%            |
| Cyanophage | Trigrams  | Redirect            | 2,14%          | 2,03%             | 3,05%            | 2,57%         | 9,22%             |
| Cyanophage | Trigrams  | Weak redirect       | 1,32%          | 1,30%             | 1,40%            | 0,28%         | 1,52%             |
| Cyanophage | Trigrams  | Other               | 8,28%          | 9,20%             | 9,72%            | 12,44%        | 9,17%             |

## Instalasi

### Pengaturan Linux

>*Legenda:* QWERTY=putih; Engram=emas; Enthium=biru/hijau; Keanehan=merah muda.
>![Rendering layout ini pada keyboard row-staggered.](https://raw.githubusercontent.com/sunaku/enthium/main/linux/layout.png)

Instalasi:

    cd linux/
    sudo make install
    echo Sekarang restart sesi grafis Anda.

Aktifkan:

    setxkbmap -layout us    -variant enthium         # satu layout; tanpa switch
    setxkbmap -layout us,us -variant enthium,basic   # dual layout switching

Perbaiki (misal, setiap kali upgrade paket XKB sistem mengembalikan instalasi):

    cd linux/
    sudo make reinstall
    echo Sekarang restart sesi grafis Anda.

Uninstall:

    cd linux/
    sudo make uninstall
    echo Sekarang restart sesi grafis Anda.

### Pengaturan MacOS

#### Instalasi

Untuk menggunakan layout ini di MacOS, Anda perlu menginstal [Karabiner-Elements](https://karabiner-elements.pqrs.org/).

Anda dapat menginstalnya melalui [Homebrew](https://brew.sh/):

    brew install --cask karabiner-elements

Atau unduh dari [website utama Karabiner-Elements](https://karabiner-elements.pqrs.org/).

Setelah diunduh, cukup ikuti petunjuk pada [panduan instalasi](https://karabiner-elements.pqrs.org/docs/getting-started/installation/).

#### Modifikasi Kompleks

Setelah semua terinstal, Anda dapat menggunakan [fitur complex modification](https://karabiner-elements.pqrs.org/docs/manual/configuration/configure-complex-modifications/) untuk memetakan ulang tombol.

Modifikasi kompleks Enthium tersedia [di sini](https://ke-complex-modifications.pqrs.org/?q=enthium).

Untuk kembali ke layout dasar, Anda cukup menghapus modifikasi kompleks Enthium.

#### Uninstalasi

* Brew : `brew uninstall --cask karabiner-elements`
* Manual : Hapus `Karabiner-Elements.app` dari folder Aplikasi Anda.

## Lisensi

Dirilis dengan ketentuan yang sama seperti sumber layout keyboard [Engram 2.0 Arno]:

> MIT License
>
> Copyright 2022 Ricard Figueroa <https://github.com/rfiga>  
> Copyright 2021 Suraj Kurapati <https://github.com/sunaku>  
> Copyright 2021 Arno Klein <https://github.com/binarybottle>  
>
> Izin diberikan secara gratis kepada siapa pun yang memperoleh salinan
> perangkat lunak ini dan file dokumentasi terkait ("Perangkat Lunak"), untuk memperlakukan
> Perangkat Lunak tanpa batasan, termasuk namun tidak terbatas pada hak
> untuk menggunakan, menyalin, mengubah, menggabungkan, menerbitkan, mendistribusikan, melisensikan, dan/atau menjual
> salinan Perangkat Lunak, serta mengizinkan orang yang menerima Perangkat Lunak
> untuk melakukan hal yang sama, dengan ketentuan berikut:
>
> Pemberitahuan hak cipta di atas dan pemberitahuan izin ini harus disertakan dalam
> semua salinan atau bagian substansial dari Perangkat Lunak.
>
> PERANGKAT LUNAK INI DIBERIKAN "APA ADANYA", TANPA JAMINAN APA PUN, BAIK TERSURAT
> MAUPUN TERSIRAT, TERMASUK NAMUN TIDAK TERBATAS PADA JAMINAN DIPERDAGANGKAN,
> KESESUAIAN UNTUK TUJUAN TERTENTU DAN BEBAS PELANGGARAN. DALAM HAL APA PUN
> PENULIS ATAU PEMEGANG HAK CIPTA TIDAK BERTANGGUNG JAWAB ATAS KLAIM, KERUSAKAN ATAU
> KEWAJIBAN LAIN, BAIK DALAM TINDAKAN KONTRAK, KELALAIAN ATAU LAINNYA, YANG TIMBUL DARI,
> ATAU SEHUBUNGAN DENGAN PERANGKAT LUNAK ATAU PENGGUNAAN ATAU HAL-HAL LAIN DALAM
> PERANGKAT LUNAK.

---------------------------------------------------------------------------
[Spare A Life]: https://sunaku.github.io/vegan-for-life.html
> Suka dengan karya saya? 👍 Silakan [selamatkan satu nyawa] hari ini sebagai ucapan terima kasih! 🐄🐖🐑🐔🐣🐟✨🙊✌  
> Mengapa? Demi 💕 etika, lingkungan 🌎, dan kesehatan 💪; lihat tautan di atas. 🙇

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-07

---