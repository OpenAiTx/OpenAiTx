<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: Bilgi Grafikleri İçin Grafik ve İnsan-Tanıyabilir Nesne Tespiti Benchmark'ı
</h1>

## Veri Kümesi

Bu depo, "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics" başlıklı makalenin kodlarını içermektedir. İlgili verilere [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) üzerinden ulaşabilirsiniz.

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Nesne Tespit Modellerinin Değerlendirilmesi
Öncelikle ortamı kurmak için [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) talimatlarını izleyiniz.  

MMDetection kullanarak dört nesne tespit modelini eğitiyor ve test ediyoruz: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py) ve [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

İlgili dört konfigürasyonda "YOUR ROOT" ve "YOUR DATASET" alanlarını değiştirin.

Modelleri eğitmek için aşağıdaki komutları çalıştırın:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

Aşağıdaki şekilde, değerlendirilen nesne tespit modellerinin tespit sonuçları gösterilmektedir: (a) DINO-X ile sıfır-atış istemleme; (b) T-Rex2 ile 4-atış istemleme; (c) Co-DETR ile 4-atış ince ayar; (d) Co-DETR ile OrionBench üzerinde ince ayar. Renkli kenarlık kutuları, grafikler ve İnsan-Tanıyabilir Nesneler (HRO) için tahminlerdir.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

Ek olarak, benchmark ile birlikte geliştirilen InternImage tabanlı model [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) üzerinde mevcuttur.

## Makale Bağlantıları

### Ana Makale (Bu Depo)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### İlgili Makaleler

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Kaynaklar

Modelimizi veya veri kümemizi araştırmanızda kullanırsanız lütfen makalemizi kaynak olarak gösteriniz

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