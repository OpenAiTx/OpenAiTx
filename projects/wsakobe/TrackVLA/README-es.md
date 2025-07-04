<p align="center">
<h1 align="center"><strong>TrackVLA: Seguimiento Visual Incorporado en Entornos No Controlados</strong></h1>
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
    Universidad de Pekín&emsp; 
    Galbot&emsp; <br>
    Universidad Beihang&emsp;
    Universidad Normal de Pekín&emsp;
    Academia de Inteligencia Artificial de Pekín&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Proyecto](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Vídeo](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Acerca de
<strong><em>TrackVLA</em></strong> es un modelo de visión-lenguaje-acción capaz de realizar reconocimiento de objetos y seguimiento visual simultáneamente, entrenado con un conjunto de datos de 1,7 millones de muestras. Demuestra un seguimiento robusto, seguimiento a largo plazo y generalización entre dominios en diversos entornos desafiantes.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Noticias

* [25/07/02]: El EVT-Bench ya está disponible.

## 💡 Instalación
1. **Preparar el entorno conda**

   Primero, necesitas instalar [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Una vez instalado conda, crea un nuevo entorno:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Instalación de habitat-sim con conda**
   
   Debes instalar habitat-sim v0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Instalar habitat-lab desde el código fuente**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Preparar conjuntos de datos**

    Descarga el conjunto de datos Habitat Matterport 3D (HM3D) desde [aquí](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) y Matterport3D (MP3D) desde [aquí](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Luego mueve el conjunto de datos a `data/scene_datasets`. La estructura del conjunto de datos es la siguiente:
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

    A continuación, ejecuta el siguiente código para obtener los datos de los avatares humanoides:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Evaluación
  Ejecuta el script con:

    bash eval.sh

  Los resultados se guardarán en la ruta SAVE_PATH especificada, la cual incluirá un directorio de logs y un directorio de vídeos. Para monitorear los resultados durante el proceso de evaluación, ejecuta:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Para detener la evaluación, utiliza:

    bash kill_eval.sh


## 📝 Lista de Tareas Pendientes
- [x] Publicar el artículo en arXiv en mayo de 2025.
- [x] Publicar EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Publicar el conjunto de datos a gran escala para visual tracking incorporado.
- [ ] Publicar el checkpoint y el código de TrackVLA.

## ✉️ Contacto
Para cualquier pregunta, no dudes en enviar un correo electrónico a wangshaoan@stu.pku.edu.cn. Responderemos lo antes posible.


## 🔗 Citación
Si consideras que nuestro trabajo es útil, por favor cítalo de la siguiente manera:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan y Zhang, Jiazhao y Li, Minghan y Liu, Jiahang y Li, Anqi y Wu, Kui y Zhong, Fangwei y Yu, Junzhi y Zhang, Zhizheng y Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licencia
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Este trabajo está bajo la <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Licencia Creative Commons Atribución-NoComercial-CompartirIgual 4.0 Internacional</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---