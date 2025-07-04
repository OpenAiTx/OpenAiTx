<p align="center">
<h1 align="center"><strong>TrackVLA: Rastreamento Visual Incorporado em Ambiente Real</strong></h1>
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
    Universidade de Pequim&emsp; 
    Galbot&emsp; <br>
    Universidade Beihang&emsp;
    Universidade Normal de Pequim&emsp;
    Academia de Inteligência Artificial de Pequim&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Projeto](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Vídeo](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 Sobre
<strong><em>TrackVLA</em></strong> é um modelo de visão-linguagem-ação capaz de reconhecimento simultâneo de objetos e rastreamento visual, treinado em um conjunto de dados com 1,7 milhão de amostras. Ele demonstra rastreamento robusto, rastreamento de longo prazo e generalização entre domínios em diversos ambientes desafiadores.
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 Novidades

* [25/07/02]: O EVT-Bench já está disponível.

## 💡 Instalação
1. **Preparando o ambiente conda**

   Primeiro, é necessário instalar o [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/). Uma vez instalado, crie um novo ambiente:
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **Instalar habitat-sim via conda**
   
   É necessário instalar o habitat-sim v0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **Instalar habitat-lab a partir do código-fonte**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **Preparar conjuntos de dados**

    Baixe o conjunto de dados Habitat Matterport 3D (HM3D) [aqui](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d) e o Matterport3D (MP3D) [aqui](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset).

    Em seguida, mova o conjunto de dados para `data/scene_datasets`. A estrutura do conjunto de dados é a seguinte:
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

    Depois, execute o seguinte código para obter dados para os avatares humanóides:
      ```
      python download_humanoid_data.py
      ```


## 🧪 Avaliação
  Execute o script com:

    bash eval.sh

  Os resultados serão salvos no SAVE_PATH especificado, que incluirá um diretório de logs e um diretório de vídeos. Para monitorar os resultados durante o processo de avaliação, execute:
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  Para parar a avaliação, use:

    bash kill_eval.sh


## 📝 Lista de Tarefas (TODO)
- [x] Publicar o artigo no arXiv em maio de 2025.
- [x] Lançar o EVT-Bench (Embodied Visual Tracking Benchmark).
- [ ] Lançar o conjunto de dados em larga escala para acompanhamento visual incorporado.
- [ ] Lançar o checkpoint e o código do TrackVLA.

## ✉️ Contato
Para quaisquer dúvidas, sinta-se à vontade para enviar um e-mail para wangshaoan@stu.pku.edu.cn. Responderemos o mais rápido possível.


## 🔗 Citação
Se você considerar nosso trabalho útil, por favor, cite-o da seguinte forma:

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan e Zhang, Jiazhao e Li, Minghan e Liu, Jiahang e Li, Anqi e Wu, Kui e Zhong, Fangwei e Yu, Junzhi e Zhang, Zhizheng e Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 Licença
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
Este trabalho está sob a <a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">Licença Creative Commons Atribuição-NãoComercial-CompartilhaIgual 4.0 Internacional</a>.

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---