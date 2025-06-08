<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: Ein Benchmark für Diagramm- und menschenerkennbare Objekterkennung in Infografiken
</h1>

## Datensatz

Dieses Repository enthält den Code zum Paper "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics". Die zugehörigen Daten sind auf [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) verfügbar.

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Evaluierung von Objekterkennungsmodellen
Bitte folgen Sie zunächst den Anweisungen in [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection), um die Umgebung einzurichten.  

Wir trainieren und testen vier Objekterkennungsmodelle mit MMDetection: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py) und [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

Ändern Sie "YOUR ROOT" und "YOUR DATASET" in den jeweiligen vier Konfigurationsdateien.

Führen Sie folgenden Befehl aus, um die Modelle zu trainieren:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

Die folgende Abbildung zeigt die Erkennungsergebnisse der bewerteten Objekterkennungsmodelle: (a) Zero-Shot-Prompting mit DINO-X; (b) 4-Shot-Prompting mit T-Rex2; (c) 4-Shot-Fine-Tuning mit Co-DETR; (d) Fine-Tuning auf OrionBench mit Co-DETR. Farbige Begrenzungsrahmen sind die Vorhersagen für Diagramme und HROs.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

Zusätzlich ist das gemeinsam mit dem Benchmark entwickelte InternImage-basierte Modell auf [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) verfügbar.

## Paper-Links

### Hauptartikel (Dieses Repository)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### Relevante Arbeiten

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Referenzen

Bitte zitieren Sie unser Paper, wenn Sie unser Modell oder unseren Datensatz in Ihrer Forschung verwenden

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