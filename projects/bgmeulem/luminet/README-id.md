<div align="center">
  
# luminet
![ci-badge](https://img.shields.io/appveyor/build/bgmeulem/luminet?label=ci&style=flat-square) [![PyPI-badge](https://img.shields.io/pypi/v/luminet?pypiBaseUrl=https%3A%2F%2Fpypi.org&style=flat-square&logo=pypi&logoColor=white&link=https%3A%2F%2Fpypi.org%2Fproject%2Fluminet%2F)](https://pypi.org/project/luminet) [![Documentation Status](https://readthedocs.org/projects/luminet/badge/?version=latest&style=flat-square)](https://luminet.readthedocs.io/en/latest/?badge=latest) ![coverage](https://img.shields.io/codecov/c/github/bgmeulem/Luminet?style=flat-square) ![stars-badge](https://img.shields.io/github/stars/bgmeulem/Luminet?style=flat-square) ![license](https://img.shields.io/github/license/bgmeulem/Luminet?style=flat-square) [![Pixi Badge](https://img.shields.io/endpoint?url=https://raw.githubusercontent.com/prefix-dev/pixi/main/assets/badge/v0.json&style=flat-square)](https://pixi.sh)

Simulasikan dan visualisasikan lubang hitam Schwarzschild, berdasarkan metode yang dijelaskan dalam Luminet (1979).

![Contoh plot lubang hitam](https://raw.githubusercontent.com/bgmeulem/luminet/master/assets/bh_plot.png)
</div>

## ⚡ Instalasi
`luminet` tersedia di PyPI:

```shell
pip install luminet
```

## 📖 [Dokumentasi](https://luminet.readthedocs.io/en/latest/index.html)

## 🔩 Penggunaan

Semua variabel di repositori ini menggunakan satuan alami: $G=c=1$

```python
from luminet.black_hole import BlackHole
bh = BlackHole(
    mass=1,
    incl=1.5,           # inclination in radians
    acc=1,              # accretion rate
    outer_edge=40
)
```
Untuk membuat sebuah gambar:
```python
ax = bh.plot()          # Create image like above
```
Untuk mengambil sampel foton pada cakram akresi:

```python
bh.sample_photons(100)
bh.photons
```
```
radius  alpha   impact_parameter    z_factor    flux_o
10.2146 5.1946  1.8935              1.1290      1.8596e-05
... (99 more)
```
Perhatikan bahwa pengambilan sampel condong ke pusat lubang hitam, karena di sinilah sebagian besar luminositas berasal.


## 📝 Latar Belakang
Lubang hitam Schwarzschild memiliki orbit stabil terdalam pada $6M$, dan sebuah bola foton pada $3M$. Ini berarti bahwa
cakram akresi yang mengorbit lubang hitam memancarkan foton pada radius $r>6M$. Selama perige foton dalam ruang lengkung tetap lebih besar dari $3M$ (juga disebut bola foton), foton tidak ditangkap oleh lubang hitam dan secara teori dapat dilihat dari beberapa kerangka pengamat $(b, \alpha)$. Kelengkungan ruangwaktu paling mudah diinterpretasikan sebagai efek lensa antara kerangka lubang hitam $(r, \alpha)$ dan kerangka pengamat $(b, \alpha)$. Yang pertama adalah koordinat polar 2D yang mencakup area cakram akresi, dan yang kedua adalah koordinat polar 2D yang mencakup "pelat fotografi" dari kerangka pengamat. Anggap saja yang terakhir seperti kamera CCD literal. Perige orbit foton dan radius dalam kerangka pengamat $b$ berhubungan langsung:

$$b^2 = \frac{P^3}{P-2M}$$

Ini membuat banyak persamaan menjadi jauh lebih sederhana.
Anda mungkin memperhatikan bahwa persamaan ini memiliki kuadrat di sisi kiri, berbeda dengan Luminet (1979). Naskah asli memiliki beberapa kesalahan notasi. Saya telah menghubungi penulis tentang hal ini, yang dengan ramah menjawab:

> "[...] à l’époque je n'avais pas encore l’expérience de relire très soigneusement les épreuves. Mais mes calculs avaient  heureusement été faits avec les bonnes formules, sinon le résultat visuel n’aurait pas été correct!" 
>
>"Dulu, saya belum memiliki kebiasaan untuk sangat teliti memeriksa ulang bukti-bukti saya. Untungnya, saya menghitung hasilnya dengan rumus yang benar, kalau tidak gambarnya tidak akan benar!".

Hanya untuk diketahui. Saya berusaha teliti mencatat di mana kode ini berbeda dari makalah.

Hubungan antara sudut-sudut kedua sistem koordinat tersebut sepele, tetapi hubungan antara radius pada kedua kerangka acuan diberikan oleh Persamaan 13 yang mengerikan:

$$\frac{1}{r} = - \frac{Q - P + 2M}{4MP} + \frac{Q-P+6M}{4MP}{sn}^2\left( \frac{\gamma}{2}\sqrt{\frac{Q}{P}} + F(\zeta_\infty, k) \right)$$

Di sini, $F$ adalah integral eliptik tak lengkap Jacobian jenis pertama, $k$ dan $Q$ adalah fungsi dari perige $P$, $\zeta$ adalah fungsi trigonometri dari $P$, dan $\gamma$ memenuhi:

$$\cos(\gamma) = \frac{\cos(\alpha)}{\sqrt{\cos^2\alpha + \cot^2\theta_0}}$$

Dalam ruangwaktu lengkung, biasanya terdapat beberapa orbit foton yang berasal dari koordinat yang sama dan diproyeksikan ke kerangka pengamat (lihat misalnya pelensaan gravitasi dan salib Einstein). Orbit foton yang melengkung mengelilingi lubang hitam dan mencapai kerangka pengamat disebut gambar "orde lebih tinggi", atau gambar "hantu". Dalam kasus ini, $\gamma$ memenuhi:

$$2n\pi - \gamma = 2\sqrt{\frac{Q}{P}} \left( 2K(k) - F(\zeta_\infty, k) - F(\zeta_r, k)  \right)$$

Foton hantu inilah yang Anda lihat pada bagian bawah gambar di atas, serta halo cahaya yang nyaris tak terlihat yang melingkari bola foton dengan tipis. Untuk inklinasi yang kurang mendekati tepi, gambar hantu ini tidak begitu menonjol.

Repositori ini menggunakan `scipy.optimize.brentq` untuk menyelesaikan persamaan ini, dan menyediakan API yang mudah untuk konsep yang dipresentasikan dalam Luminet (1979). Kelas `BlackHole` adalah yang paling jelas, namun juga edukatif untuk bereksperimen dengan misalnya kelas `Isoradial`: garis-garis dalam kerangka pengamat yang menggambarkan foton yang dipancarkan dari radius yang sama dalam kerangka lubang hitam. Kelas `Isoredshift` menyediakan garis dengan pergeseran merah yang sama dalam kerangka pengamat.

## 📕 Daftar Pustaka
[1] Luminet, J.-P., [“Image of a spherical black hole with thin accretion disk.”](https://ui.adsabs.harvard.edu/abs/1979A%26A....75..228L/abstract), <i>Astronomy and Astrophysics</i>, vol. 75, hlm. 228–235, 1979.

[2] J.-P. Luminet, [“An Illustrated History of Black Hole Imaging : Personal Recollections (1972-2002).”](https://arxiv.org/abs/1902.11196) arXiv, 2019. doi: 10.48550/ARXIV.1902.11196. 



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-26

---