
<div align="right">
  <details>
    <summary >🌐 Bahasa</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=zh-TW">繁體中文</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=hi">हिन्दी</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=th">ไทย</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=es">Español</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=ar">العربية</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=fa">فارسی</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=vi">Tiếng Việt</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=id">Bahasa Indonesia</a>
        | <a href="https://openaitx.github.io/view.html?user=keishihara&project=flow-matching&lang=as">অসমীয়া</
      </div>
    </div>
  </details>
</div>

# Flow Matching di PyTorch

Repositori ini berisi implementasi PyTorch sederhana dari makalah [Flow Matching for Generative Modeling](https://arxiv.org/abs/2210.02747).

## Contoh Flow Matching 2D

Gif di bawah ini mendemonstrasikan pemetaan distribusi Gaussian tunggal ke distribusi papan catur, dengan visualisasi medan vektor.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/checkerboard/vector_field_and_samples_checkerboard.gif" height="400" />
</p>

Dan, berikut adalah contoh lain dari dataset moons.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/moons/vector_field_and_samples_moons.gif" height="400" />
</p>

## Memulai

Clone repositori dan atur lingkungan python.

```bash
git clone https://github.com/keishihara/flow-matching.git
cd flow-matching
```

Pastikan Anda telah menginstal Python 3.12+.
Instal `uv`:

```bash
curl -LsSf https://astral.sh/uv/install.sh | sh
```

Kemudian, atur lingkungan:

```bash
uv sync
```

## Conditional Flow Matching [Lipman+ 2023]

Ini adalah implementasi asli dari paper CFM [1]. Beberapa komponen kode diadaptasi dari [2] dan [3].

### Dataset Mainan 2D

Anda dapat melatih model CFM pada dataset sintetis 2D seperti `checkerboard` dan `moons`. Tentukan nama dataset menggunakan opsi `--dataset`. Parameter pelatihan sudah ditetapkan di skrip, dan visualisasi hasil pelatihan disimpan di direktori `outputs/`. Checkpoint model tidak disertakan karena dapat direproduksi dengan mudah menggunakan pengaturan default.

```bash
uv run scripts/train_flow_matching_2d.py --dataset checkerboard
```

Medan vektor dan sampel yang dihasilkan, seperti yang ditampilkan dalam bentuk GIF di bagian atas README ini, sekarang dapat ditemukan di direktori `outputs/cfm/`.

### Dataset Gambar

Anda juga dapat melatih model CFM bersyarat kelas pada dataset klasifikasi gambar yang populer. Baik sampel yang dihasilkan maupun checkpoint model akan disimpan di direktori `outputs/cfm`. Untuk daftar parameter pelatihan secara detail, jalankan `uv run scripts/train_flow_matching_on_image.py --help`.

Untuk melatih CFM bersyarat kelas pada dataset MNIST, jalankan:

```bash
uv run scripts/train_flow_matching_on_image.py --do_train --dataset mnist
```

Setelah pelatihan, Anda sekarang dapat menghasilkan sampel dengan:

```bash
uv run scripts/train_flow_matching_on_image.py --do_sample --dataset mnist
```
Sekarang, Anda seharusnya dapat melihat sampel yang dihasilkan di direktori `outputs/cfm/mnist/`.

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/cfm/mnist/trajectory.gif" height="400" />
</p>

## Rectified Flow [Liu+ 2023]

Ini adalah implementasi model Reflow (lebih spesifiknya 2-Rectified Flow) dari makalah Rectified Flow [2].

### Data Sintetis 2D

Kami telah mengimplementasikan Reflow pada dataset sintetis 2d, sama seperti CFM. Untuk melatih reflow, Anda harus menentukan checkpoint CFM yang sudah dilatih sebelumnya karena reflow adalah model distilasi.

Sebagai contoh, untuk melatih pada dataset `checkerboard` dengan checkpoint CFM yang telah dilatih sebelumnya:


```bash
uv run scripts/train_reflow_2d.py --dataset checkerboard
```

Hasil pelatihan, termasuk visualisasi medan vektor dan sampel yang dihasilkan, disimpan di dalam folder `outputs/reflow/`.

### Perbandingan proses sampling antara CFM dan Reflow

Untuk membandingkan CFM dan Reflow pada dataset 2d, jalankan:

```bash
uv run scripts/plot_comparison_2d.py --dataset checkerboard
```

GIF yang dihasilkan dapat ditemukan di bawah folder `outputs/comparisons/`. Berikut ini adalah contoh perbandingan dua metode pada dataset `checkerboard`:

<p align="center">
<img align="middle" src="https://raw.githubusercontent.com/keishihara/flow-matching/main/./outputs/comparisons/cfm_reflow_checkerboard.gif" height="400" />
</p>

## Referensi

- [1] Lipman, Yaron, dkk. "Flow Matching for Generative Modeling." [arXiv:2210.02747](https://arxiv.org/abs/2210.02747)
- [2] Liu, Xingchao, dkk. "Flow Straight and Fast: Learning to Generate and Transfer Data with Rectified Flow." [arXiv:2209.03003](https://arxiv.org/abs/2209.03003)
- [3] [facebookresearch/flow_matching](https://github.com/facebookresearch/flow_matching)
- [4] [atong01/conditional-flow-matching](https://github.com/atong01/conditional-flow-matching)


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-19

---