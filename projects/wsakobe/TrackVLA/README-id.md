<p align="center">
<h1 align="center"><strong>TrackVLA: Pelacakan Visual Berbadan di Alam Liar</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Shaoan Wang</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Jiazhao Zhang</a>&emsp;
    Minghan Li&emsp;
    Jiahang Liu&emsp;
    Anqi Li&emsp; <br>
    Kui Wu&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Fangwei Zhong</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Junzhi Yu</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Zhizheng Zhang</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>He Wang</a>&emsp;
    <br>
    Universitas Peking&emsp; 
    Galbot&emsp; <br>
    Universitas Beihang&emsp;
    Universitas Normal Beijing&emsp;
    Akademi Kecerdasan Buatan Beijing&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Tentang
<strong><em>TrackVLA</em></strong> adalah model visi-bahasa-aksi yang mampu melakukan pengenalan objek dan pelacakan visual secara simultan, dilatih pada dataset sebanyak 1,7 juta sampel. Model ini menunjukkan pelacakan yang kuat, pelacakan jarak jauh, serta generalisasi lintas domain di berbagai lingkungan yang menantang.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Berita

* [25/07/02]: EVT-Bench sekarang sudah tersedia.

## 💡 Instalasi
1. **Menyiapkan lingkungan conda**

   Pertama, Anda perlu menginstal [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Setelah conda terpasang, buat lingkungan baru:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Instalasi habitat-sim melalui Conda**
   
   Anda perlu menginstal habitat-sim versi 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Instalasi habitat-lab dari source**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Menyiapkan dataset**

    Unduh dataset Habitat Matterport 3D (HM3D) dari [sini](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) dan Matterport3D (MP3D) dari [sini](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Kemudian pindahkan dataset ke `data/scene_datasets`. Struktur dataset dijabarkan sebagai berikut:
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    Selanjutnya, jalankan kode berikut untuk mendapatkan data avatar humanoid:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Evaluasi
  Jalankan skrip dengan:

    bash eval.sh

  Hasil akan disimpan di SAVE_PATH yang telah ditentukan, yang akan mencakup direktori log dan direktori video. Untuk memantau hasil selama proses evaluasi, jalankan:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Untuk menghentikan evaluasi, gunakan:

    bash kill_eval.sh


## 📝 Daftar TODO
- [x] Rilis makalah arXiv pada Mei 2025.
- [x] Rilis EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Rilis dataset embodied visual tracking skala besar.
- [ ] Rilis checkpoint dan kode TrackVLA.

## ✉️ Kontak
Untuk pertanyaan apapun, silakan email ke wangshaoan@stu.pku.edu.cn. Kami akan merespons secepat mungkin.


## 🔗 Sitasi
Jika Anda merasa pekerjaan kami bermanfaat, mohon pertimbangkan untuk mengutipnya sebagai berikut:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan dan Zhang, Jiazhao dan Li, Minghan dan Liu, Jiahang dan Li, Anqi dan Wu, Kui dan Zhong, Fangwei dan Yu, Junzhi dan Zhang, Zhizheng dan Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Lisensi
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Karya ini berada di bawah <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Lisensi Creative Commons Atribusi-NonKomersial-BerbagiSerupa 4.0 Internasional</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---