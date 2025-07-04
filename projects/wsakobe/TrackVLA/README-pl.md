<p align="center">
<h1 align="center"><strong>TrackVLA: Ucieleśnione Śledzenie Wizualne w Naturalnych Warunkach</strong></h1>
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
    Uniwersytet Pekiński&emsp; 
    Galbot&emsp; <br>
    Uniwersytet Beihang&emsp;
    Uniwersytet Normalny w Pekinie&emsp;
    Pekińska Akademia Sztucznej Inteligencji&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Projekt](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Wideo](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 O projekcie
<strong><em>TrackVLA</em></strong> to model wizja-język-akcja, zdolny do jednoczesnego rozpoznawania obiektów i śledzenia wizualnego, wytrenowany na zbiorze danych obejmującym 1,7 miliona próbek. Wykazuje solidne śledzenie, długoterminowe śledzenie oraz generalizację międzydomenową w różnorodnych, wymagających środowiskach.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Aktualności

* [25/07/02]: EVT-Bench jest już dostępny.

## 💡 Instalacja
1. **Przygotowanie środowiska conda**

   Najpierw należy zainstalować [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Po instalacji conda, utwórz nowe środowisko:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Instalacja habitat-sim przez conda**
   
   Należy zainstalować habitat-sim w wersji 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Instalacja habitat-lab ze źródeł**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Przygotowanie zbiorów danych**

    Pobierz zbiór Habitat Matterport 3D (HM3D) z [tego miejsca](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) oraz Matterport3D (MP3D) z [tego miejsca](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Następnie przenieś zbiór danych do `data/scene_datasets`. Struktura zbioru danych wygląda następująco:
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

    Następnie uruchom poniższy kod, aby pobrać dane dla humanoidalnych awatarów:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Ewaluacja
  Uruchom skrypt poleceniem:

    bash eval.sh

  Wyniki zostaną zapisane w określonej lokalizacji SAVE_PATH, która będzie zawierać katalog logów oraz katalog wideo. Aby monitorować wyniki podczas procesu ewaluacji, uruchom:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Aby zatrzymać ewaluację, użyj:

    bash kill_eval.sh


## 📝 Lista TODO
- [x] Publikacja artykułu arXiv w maju 2025.
- [x] Wydanie EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Wydanie wielkoskalowego zbioru danych do embodied visual tracking.
- [ ] Udostępnienie checkpointu oraz kodu TrackVLA.

## ✉️ Kontakt
W przypadku pytań prosimy o kontakt mailowy: wangshaoan@stu.pku.edu.cn. Odpowiemy tak szybko, jak to możliwe.


## 🔗 Cytowanie
Jeśli nasza praca okazała się pomocna, prosimy o jej cytowanie w następujący sposób:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licencja
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Niniejsza praca jest objęta licencją <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Uznanie autorstwa-Użycie niekomercyjne-Na tych samych warunkach 4.0 Międzynarodowa</a>.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---