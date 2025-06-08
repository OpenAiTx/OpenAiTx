<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: ชุดทดสอบสำหรับการตรวจจับแผนภูมิและวัตถุที่มนุษย์จดจำได้ในอินโฟกราฟิก
</h1>

## ชุดข้อมูล

ที่เก็บข้อมูลนี้ประกอบด้วยโค้ดสำหรับงานวิจัย "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics" ข้อมูลที่เกี่ยวข้องสามารถดูได้ที่ [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench)

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## การประเมินโมเดลตรวจจับวัตถุ
กรุณาทำตามคำแนะนำใน [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) เพื่อเตรียมสภาพแวดล้อมก่อน  

เราได้ฝึกและทดสอบโมเดลตรวจจับวัตถุ 4 โมเดลโดยใช้ MMDetection ได้แก่ [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), และ [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py)

โปรดแก้ไข "YOUR ROOT" และ "YOUR DATASET" ในไฟล์คอนฟิกทั้งสี่ให้ถูกต้อง

รันคำสั่งต่อไปนี้เพื่อฝึกโมเดล:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

รูปด้านล่างแสดงผลลัพธ์การตรวจจับของโมเดลที่ถูกประเมิน: (a) zero-shot prompting ด้วย DINO-X; (b) 4-shot prompting ด้วย T-Rex2; (c) 4-shot fine-tuning ด้วย Co-DETR; (d) fine-tuning บน OrionBench ด้วย Co-DETR กล่องสีแสดงการทำนายสำหรับแผนภูมิและ HROs

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

นอกจากนี้ โมเดลที่พัฒนาร่วมกับชุดทดสอบโดยใช้ InternImage ยังมีให้ใช้งานที่ [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO)

## ลิงก์งานวิจัย

### งานวิจัยหลัก (ที่เก็บนี้)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### งานวิจัยที่เกี่ยวข้อง

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## การอ้างอิง

กรุณาอ้างอิงงานวิจัยของเราหากคุณใช้โมเดลหรือชุดข้อมูลของเราในการวิจัยของคุณ

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