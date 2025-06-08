<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: یک بنچمارک برای شناسایی نمودار و اشیاء قابل شناسایی توسط انسان در اینفوگرافیک‌ها
</h1>

## دیتاست

این مخزن شامل کد مقاله "OrionBench: یک بنچمارک برای شناسایی نمودار و اشیاء قابل شناسایی توسط انسان در اینفوگرافیک‌ها" است. داده‌های مرتبط در [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) موجود است.

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## ارزیابی مدل‌های شناسایی شیء
لطفاً ابتدا دستورالعمل‌های موجود در [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) را برای راه‌اندازی محیط دنبال کنید.

ما چهار مدل شناسایی شیء را با استفاده از MMDetection آموزش داده و ارزیابی می‌کنیم: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py)، [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py)، [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py)، و [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

"YOUR ROOT" و "YOUR DATASET" را در چهار پیکربندی مربوطه تغییر دهید.

برای آموزش مدل‌ها، دستور زیر را اجرا کنید:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

شکل زیر نتایج شناسایی مدل‌های ارزیابی‌شده شناسایی شیء را نشان می‌دهد: (الف) پرامپتینگ zero-shot با DINO-X؛ (ب) پرامپتینگ ۴-shot با T-Rex2؛ (ج) فاین‌تیونینگ ۴-shot با Co-DETR؛ (د) فاین‌تیونینگ روی OrionBench با Co-DETR. جعبه‌های رنگی، پیش‌بینی‌ها برای نمودارها و اشیاء قابل شناسایی توسط انسان (HROs) هستند.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

علاوه بر این، مدل مبتنی بر InternImage که همراه با این بنچمارک توسعه داده شده است، در [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) در دسترس است.

## لینک‌های مقاله

### مقاله اصلی (این مخزن)

- **[OrionBench: یک بنچمارک برای شناسایی نمودار و اشیاء قابل شناسایی توسط انسان در اینفوگرافیک‌ها](https://arxiv.org/abs/2505.17473)**  
  _جیانگنینگ ژو، یوکسینگ ژو، ژنگ وانگ، جونتائو یائو، ییمان گو، یوهوئی یوان، شیکسیائو لیو_  

### مقالات مرتبط

- **[ChartGalaxy: یک دیتاست برای درک و تولید نمودار اینفوگرافیکی](https://arxiv.org/abs/2505.18668)**  
  _ژن لی، دوان لی، یوکای گو، شینیوان گو، بوون لی، لانشی شیائو، شنیو چیائو، جیاشو چن، زیجیان وو، هوی ژانگ، شینهوان شو، شیکسیائو لیو_  

- **[InfoChartQA: یک بنچمارک برای پاسخ به پرسش‌های چندوجهی بر روی نمودارهای اینفوگرافیکی](https://arxiv.org/abs/2505.19028)**  
  _مینژی لین، تیانچی شی، منگ‌چن لیو، ییلین یه، چانگجیان چن، شیکسیائو لیو_  


## منابع

لطفاً اگر از مدل یا دیتاست ما در پژوهش خود استفاده می‌کنید به مقاله ما ارجاع دهید

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