<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: Een Benchmark voor Diagram- en Mensherkenbare Objectdetectie in Infographics
</h1>

## Dataset

Deze repository bevat de code voor het artikel "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics". De bijbehorende data is beschikbaar op [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench).

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Evaluatie van Objectdetectiemodellen
Volg de instructies in [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) om eerst de omgeving op te zetten.  

We trainen en testen vier objectdetectiemodellen met MMDetection: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), en [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

Wijzig "YOUR ROOT" en "YOUR DATASET" in de vier betreffende configuraties.

Voer het volgende commando uit om de modellen te trainen:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

De onderstaande afbeelding toont detectieresultaten van geëvalueerde objectdetectiemodellen: (a) zero-shot prompting met DINO-X; (b) 4-shot prompting met T-Rex2; (c) 4-shot fine-tuning met Co-DETR; (d) fine-tuning op OrionBench met Co-DETR. Gekleurde bounding boxes zijn de voorspellingen voor diagrammen en HRO's.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

Daarnaast is het op InternImage gebaseerde model dat samen met de benchmark is ontwikkeld beschikbaar op [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO).

## Artikel Links

### Hoofdartikel (Deze Repository)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### Relevante Artikelen

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Referenties

Citeer ons artikel als u ons model of onze dataset gebruikt in uw onderzoek

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