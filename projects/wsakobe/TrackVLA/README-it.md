<p align="center">
<h1 align="center"><strong>TrackVLA: Tracciamento Visivo Incorporato in Ambienti Realistici</strong></h1>
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
    Università di Pechino&emsp; 
    Galbot&emsp; <br>
    Università Beihang&emsp;
    Università Normale di Pechino&emsp;
    Accademia di Intelligenza Artificiale di Pechino&emsp;
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

## 🏡 Informazioni
<strong><em>TrackVLA</em></strong> è un modello visione-linguaggio-azione capace di riconoscimento oggetti e tracciamento visivo simultanei, addestrato su un dataset di 1,7 milioni di campioni. Dimostra robustezza nel tracciamento, tracciamento su lunghe distanze e generalizzazione cross-domain in una grande varietà di ambienti impegnativi.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Novità

* [25/07/02]: EVT-Bench è ora disponibile.

## 💡 Installazione
1. **Preparazione dell’ambiente conda**

   Prima, è necessario installare [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Una volta installato conda, creare un nuovo ambiente:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Installare habitat-sim con conda**
   
   È necessario installare habitat-sim v0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Installare habitat-lab dal sorgente**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Preparare i dataset**

    Scaricare il dataset Habitat Matterport 3D (HM3D) da [qui](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) e Matterport3D (MP3D) da [qui](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Successivamente, spostare il dataset in `data/scene_datasets`. La struttura del dataset è la seguente:
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

    Poi, eseguire il seguente comando per ottenere i dati per gli avatar umanoidi:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Valutazione
  Eseguire lo script con:

    bash eval.sh

  I risultati verranno salvati nel percorso SAVE_PATH specificato, che includerà una directory di log e una directory video. Per monitorare i risultati durante il processo di valutazione, eseguire:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Per interrompere la valutazione, usa:

    bash kill_eval.sh


## 📝 Elenco TODO
- [x] Pubblicare l’articolo su arXiv a maggio 2025.
- [x] Rilasciare EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Rilasciare il dataset su larga scala per l’embodied visual tracking.
- [ ] Rilasciare il checkpoint e il codice di TrackVLA.

## ✉️ Contatto
Per qualsiasi domanda, non esitare a scrivere a wangshaoan@stu.pku.edu.cn. Ti risponderemo il prima possibile.


## 🔗 Citazione
Se trovi utile il nostro lavoro, considera di citarlo come segue:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licenza
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Questo lavoro è distribuito con licenza <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribuzione-NonCommerciale-Condividi allo stesso modo 4.0 Internazionale</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---