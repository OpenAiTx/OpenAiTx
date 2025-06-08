<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench : Un Benchmark pour la Détection de Graphiques et d’Objets Reconnaissables par l’Humain dans les Infographies
</h1>

## Jeu de Données

Ce dépôt contient le code pour l’article « OrionBench : A Benchmark for Chart and Human-Recognizable Object Detection in Infographics ». Les données associées sont disponibles sur [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench).

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Évaluation des Modèles de Détection d’Objets
Veuillez suivre les instructions de [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) pour d’abord configurer l’environnement.

Nous entraînons et testons quatre modèles de détection d’objets à l’aide de MMDetection : [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), et [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

Modifiez « YOUR ROOT » et « YOUR DATASET » dans les quatre configurations correspondantes.

Exécutez la commande suivante pour entraîner les modèles :
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

La figure suivante présente les résultats de détection des modèles évalués : (a) Zero-shot prompting avec DINO-X ; (b) 4-shot prompting avec T-Rex2 ; (c) 4-shot fine-tuning avec Co-DETR ; (d) fine-tuning sur OrionBench avec Co-DETR. Les boîtes englobantes colorées correspondent aux prédictions pour les graphiques et les HROs.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

De plus, le modèle basé sur InternImage, co-développé avec le benchmark, est disponible sur [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO).

## Liens vers les Articles

### Article Principal (Ce Dépôt)

- **[OrionBench : A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### Articles Liés

- **[ChartGalaxy : A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA : A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Références

Veuillez citer notre article si vous utilisez notre modèle ou jeu de données dans vos travaux de recherche

```
@misc{zhu2025orionbench,
      title={OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics}, 
      author={Jiangning Zhu and Yuxing Zhou and Zheng Wang and Juntao Yao and Yima Gu and Yuhui Yuan and Shixia Liu},
      year={2025},
      eprint={2505.17473},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2505.17473}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-08

---