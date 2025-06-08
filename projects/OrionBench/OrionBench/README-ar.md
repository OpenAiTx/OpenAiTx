<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: معيار لاكتشاف المخططات والأشياء القابلة للتعرف البشري في الرسوم المعلوماتية
</h1>

## مجموعة البيانات

يحتوي هذا المستودع على الشفرة الخاصة بورقة البحث "OrionBench: معيار لاكتشاف المخططات والأشياء القابلة للتعرف البشري في الرسوم المعلوماتية". البيانات ذات الصلة متوفرة على [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench).

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## تقييم نماذج اكتشاف الأشياء
يرجى اتباع التعليمات في [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) لإعداد البيئة أولاً.

قمنا بتدريب واختبار أربعة نماذج لاكتشاف الأشياء باستخدام MMDetection: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py)، [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py)، [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py)، و[Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

قم بتعديل "YOUR ROOT" و"YOUR DATASET" في التكوينات الأربعة المقابلة.

نفذ الأمر التالي لتدريب النماذج:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

توضح الصورة التالية نتائج اكتشاف نماذج اكتشاف الأشياء المقيمة: (أ) الاستدلال بدون تدريب مسبق مع DINO-X؛ (ب) الاستدلال بعد تدريب بأربع عينات مع T-Rex2؛ (ج) ضبط دقيق بأربع عينات مع Co-DETR؛ (د) الضبط الدقيق على OrionBench مع Co-DETR. الصناديق الملونة هي التنبؤات للمخططات والأشياء القابلة للتعرف البشري.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

بالإضافة إلى ذلك، النموذج المعتمد على InternImage والمطور بالتعاون مع المعيار متوفر على [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO).

## روابط الورقة

### الورقة الرئيسية (هذا المستودع)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _جيانينغ تشو، يوكسينغ تشو، تشنغ وانغ، جونتاو ياو، ييما غو، يوهوي يوان، شيشيا ليو_  

### أوراق ذات صلة

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _تشن لي، دوان لي، يوكاي قوه، شينيوان قوه، بوين لي، لانشي شياو، شينيو تشياو، جياشو تشن، زيجان وو، هوي تشانغ، شينخوان شو، شيشيا ليو_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _مينتشي لين، تيانشي شي، مينغتشن ليو، ييلين يي، تشانغجيان تشين، شيشيا ليو_  


## المراجع

يرجى الاستشهاد بورقتنا إذا استخدمت نموذجنا أو مجموعة بياناتنا في بحثك

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