<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: Бенчмарк для обнаружения диаграмм и объектов, распознаваемых человеком, на инфографике
</h1>

## Датасет

Этот репозиторий содержит код для статьи "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics". Соответствующие данные доступны на [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench).

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Оценка моделей обнаружения объектов
Пожалуйста, сначала выполните инструкции из [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) для настройки окружения.

Мы обучаем и тестируем четыре модели обнаружения объектов с использованием MMDetection: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py) и [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

Измените "YOUR ROOT" и "YOUR DATASET" в соответствующих четырех конфигурациях.

Выполните следующую команду для обучения моделей:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

На следующем рисунке показаны результаты обнаружения моделей: (a) zero-shot prompting с DINO-X; (b) 4-shot prompting с T-Rex2; (c) 4-shot дообучение с Co-DETR; (d) дообучение на OrionBench с Co-DETR. Ограничивающие рамки цветом — это предсказания для диаграмм и HRO.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

Кроме того, основанная на InternImage модель, разработанная совместно с этим бенчмарком, доступна на [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO).

## Ссылки на статьи

### Основная статья (этот репозиторий)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### Связанные статьи

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Ссылки

Пожалуйста, цитируйте нашу статью, если вы используете нашу модель или датасет в своих исследованиях

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