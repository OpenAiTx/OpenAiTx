<p align="center">
<h1 align="center"><strong>TrackVLA: Verkregen Visuele Tracking in de Wilde Omgeving</strong></h1>
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
    Peking University&emsp; 
    Galbot&emsp; <br>
    Beihang University&emsp;
    Beijing Normal University&emsp;
    Beijing Academy of Artificial Intelligence&emsp;
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

## 🏡 Over
<strong><em>TrackVLA</em></strong> is een visie-taal-actie model dat in staat is tot gelijktijdige objectherkenning en visuele tracking, getraind op een dataset van 1,7 miljoen voorbeelden. Het demonstreert robuuste tracking, tracking over lange termijn en cross-domein generalisatie in diverse uitdagende omgevingen.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Nieuws

* [25/07/02]: De EVT-Bench is nu beschikbaar.

## 💡 Installatie
1. **Conda omgeving voorbereiden**

   Je moet eerst [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) installeren. Zodra conda geïnstalleerd is, maak een nieuwe omgeving aan:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Conda installatie habitat-sim**
   
   Je moet habitat-sim v0.3.1 installeren
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Installeer habitat-lab vanaf bron**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Datasets voorbereiden**

    Download de Habitat Matterport 3D (HM3D) dataset van [hier](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) en Matterport3D (MP3D) van [hier](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Verplaats vervolgens de dataset naar `data/scene_datasets`. De structuur van de dataset is als volgt:
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

    Voer vervolgens de volgende code uit om data voor de humanoïde avatars te verkrijgen:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Evaluatie
  Voer het script uit met:

    bash eval.sh

  Resultaten worden opgeslagen in het opgegeven SAVE_PATH, dat een logmap en een videomap zal bevatten. Om de resultaten tijdens het evaluatieproces te monitoren, voer uit:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Om de evaluatie te stoppen, gebruik:

    bash kill_eval.sh


## 📝 TODO-lijst
- [x] Publiceer het arXiv-artikel in mei 2025.
- [x] Publiceer de EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Publiceer de grootschalige embodied visual tracking dataset.
- [ ] Publiceer de checkpoint en code van TrackVLA.

## ✉️ Contact
Voor vragen kun je gerust een e-mail sturen naar wangshaoan@stu.pku.edu.cn. We zullen zo snel mogelijk reageren.


## 🔗 Citaat
Als je ons werk nuttig vindt, overweeg dan het als volgt te citeren:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licentie
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Dit werk valt onder de <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Naamsvermelding-NietCommercieel-GelijkDelen 4.0 Internationale Licentie</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---