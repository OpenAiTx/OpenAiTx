<p align="center">
<h1 align="center"><strong>TrackVLA: Verkörpertes Visuelles Tracking in freier Wildbahn</strong></h1>
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
    Peking Universität&emsp; 
    Galbot&emsp; <br>
    Beihang Universität&emsp;
    Beijing Normal Universität&emsp;
    Beijing Akademie für Künstliche Intelligenz&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Projekt](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Über
<strong><em>TrackVLA</em></strong> ist ein Vision-Language-Action-Modell, das simultane Objekterkennung und visuelles Tracking beherrscht und auf einem Datensatz mit 1,7 Millionen Beispielen trainiert wurde. Es zeigt robustes Tracking, langfristiges Tracking und Domänen-übergreifende Generalisierung in verschiedenen herausfordernden Umgebungen.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Neuigkeiten

* [25/07/02]: Die EVT-Bench ist jetzt verfügbar.

## 💡 Installation
1. **Vorbereitung der conda-Umgebung**

   Zuerst müssen Sie [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/) installieren. Nachdem conda installiert wurde, erstellen Sie eine neue Umgebung:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Conda-Installation von habitat-sim**
   
   Sie müssen habitat-sim v0.3.1 installieren
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Installation von habitat-lab aus dem Quellcode**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Vorbereitung der Datensätze**

    Laden Sie das Habitat Matterport 3D (HM3D) Dataset von [hier](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) und Matterport3D (MP3D) von [hier](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset) herunter.

    Verschieben Sie dann den Datensatz in `data/scene_datasets`. Die Struktur des Datensatzes ist wie folgt aufgebaut:
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

    Führen Sie anschließend den folgenden Code aus, um Daten für die humanoiden Avatare zu erhalten:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Auswertung
  Führen Sie das Skript mit folgendem Befehl aus:

    bash eval.sh

  Die Ergebnisse werden im angegebenen SAVE_PATH gespeichert, der ein Log-Verzeichnis und ein Video-Verzeichnis enthält. Um die Ergebnisse während des Auswertungsprozesses zu überwachen, führen Sie Folgendes aus:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Um die Auswertung zu stoppen, verwenden Sie:

    bash kill_eval.sh


## 📝 TODO-Liste
- [x] Veröffentlichung des arXiv-Papiers im Mai 2025.
- [x] Veröffentlichung des EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Veröffentlichung des groß angelegten Embodied Visual Tracking-Datensatzes.
- [ ] Veröffentlichung des Checkpoints und Codes von TrackVLA.

## ✉️ Kontakt
Bei Fragen können Sie gerne eine E-Mail an wangshaoan@stu.pku.edu.cn senden. Wir werden so schnell wie möglich antworten.


## 🔗 Zitation
Wenn Sie unsere Arbeit hilfreich finden, zitieren Sie sie bitte wie folgt:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Lizenz
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Diese Arbeit steht unter der <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---