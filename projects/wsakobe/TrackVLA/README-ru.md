<p align="center">
<h1 align="center"><strong>TrackVLA: Воплощённое визуальное отслеживание в дикой среде</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>Шаоан Ван</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>Цзязхао Чжан</a>&emsp;
    Минхань Ли&emsp;
    Цзяхан Лю&emsp;
    Анци Ли&emsp; <br>
    Куи Ву&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>Фанвэй Чжун</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>Цзюньчжи Юй</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>Чжичжэн Чжан</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>Хэ Ван</a>&emsp;
    <br>
    Пекинский университет&emsp; 
    Galbot&emsp; <br>
    Университет Бэйхан&emsp;
    Пекинский педагогический университет&emsp;
    Пекинская академия искусственного интеллекта&emsp;
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

## 🏡 О проекте
<strong><em>TrackVLA</em></strong> — это модель «зрение-язык-действие», способная к одновременному распознаванию объектов и визуальному отслеживанию, обученная на датасете из 1,7 миллиона примеров. Она демонстрирует устойчивое отслеживание, отслеживание на больших дистанциях и кросс-доменную генерализацию в различных сложных средах.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Новости

* [25/07/02]: EVT-Bench теперь доступен.

## 💡 Установка
1. **Подготовка среды conda**

   Сначала необходимо установить [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). После установки conda создайте новую среду:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Установка habitat-sim через conda**
   
   Необходимо установить habitat-sim версии 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Установка habitat-lab из исходников**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Подготовка датасетов**

    Скачайте датасет Habitat Matterport 3D (HM3D) [отсюда](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) и Matterport3D (MP3D) [отсюда](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Затем переместите датасет в `data/scene_datasets`. Структура датасета приведена ниже:
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

    Далее выполните следующий код для получения данных для гуманоидных аватаров:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Оценка
  Запустите скрипт с помощью:

    bash eval.sh

  Результаты будут сохранены в указанном SAVE_PATH, который будет содержать директорию логов и директорию видео. Для мониторинга результатов во время процесса оценки выполните:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Чтобы остановить оценку, используйте:

    bash kill_eval.sh


## 📝 TODO Список
- [x] Опубликовать статью на arXiv в мае 2025 года.
- [x] Выпустить EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Опубликовать крупномасштабный датасет embodied visual tracking.
- [ ] Опубликовать контрольную точку и код TrackVLA.

## ✉️ Контакты
По любым вопросам, пожалуйста, пишите на почту wangshaoan@stu.pku.edu.cn. Мы ответим вам как можно скорее.


## 🔗 Цитирование
Если вы считаете нашу работу полезной, пожалуйста, процитируйте её следующим образом:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Лицензия
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Данная работа распространяется на условиях <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">международной лицензии Creative Commons Attribution-NonCommercial-ShareAlike 4.0</a>.


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---