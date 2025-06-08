<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: Bộ chuẩn đánh giá phát hiện biểu đồ và đối tượng con người nhận biết trong đồ họa thông tin
</h1>

## Bộ dữ liệu

Kho lưu trữ này chứa mã nguồn cho bài báo "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics". Dữ liệu liên quan có sẵn tại [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench).

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## Đánh giá các mô hình phát hiện đối tượng
Vui lòng làm theo hướng dẫn trong [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) để thiết lập môi trường trước.  

Chúng tôi huấn luyện và kiểm tra bốn mô hình phát hiện đối tượng sử dụng MMDetection: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), và [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

Thay đổi "YOUR ROOT" và "YOUR DATASET" trong bốn cấu hình tương ứng.

Thực thi lệnh sau để huấn luyện các mô hình:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

Hình dưới đây minh họa kết quả phát hiện của các mô hình phát hiện đối tượng được đánh giá: (a) zero-shot prompting với DINO-X; (b) 4-shot prompting với T-Rex2; (c) 4-shot fine-tuning với Co-DETR; (d) fine-tuning trên OrionBench với Co-DETR. Các khung giới hạn có màu sắc là dự đoán cho biểu đồ và HROs.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

Ngoài ra, mô hình dựa trên InternImage được phát triển cùng với bộ chuẩn đánh giá này có sẵn tại [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO).

## Liên kết bài báo

### Bài báo chính (Kho lưu trữ này)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### Các bài báo liên quan

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## Tài liệu tham khảo

Vui lòng trích dẫn bài báo của chúng tôi nếu bạn sử dụng mô hình hoặc bộ dữ liệu trong nghiên cứu của mình

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