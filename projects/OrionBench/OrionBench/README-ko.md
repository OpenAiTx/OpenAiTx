<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: 인포그래픽에서 차트 및 인간 인식 객체 감지를 위한 벤치마크
</h1>

## 데이터셋

이 저장소는 논문 "OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics"의 코드를 포함하고 있습니다. 관련 데이터는 [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench)에서 확인하실 수 있습니다.

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## 객체 감지 모델 평가
먼저 [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection)의 안내에 따라 환경을 설정하세요.  

MMDetection을 사용하여 네 가지 객체 감지 모델을 학습하고 테스트합니다: [Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py), [YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py), [RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py), 그리고 [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py).

각 모델의 설정 파일에서 "YOUR ROOT"와 "YOUR DATASET"을 수정하세요.

아래 명령어를 실행하여 모델을 학습할 수 있습니다:
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

다음 그림은 평가된 객체 감지 모델의 검출 결과를 보여줍니다: (a) DINO-X를 이용한 zero-shot prompting; (b) T-Rex2를 이용한 4-shot prompting; (c) Co-DETR를 이용한 4-shot 파인튜닝; (d) Co-DETR로 OrionBench에서 파인튜닝. 컬러 박스는 차트 및 HRO(인간 인식 객체)의 예측값을 나타냅니다.

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

또한, 벤치마크와 함께 공동 개발된 InternImage 기반 모델은 [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO)에서 확인하실 수 있습니다.

## 논문 링크

### 주요 논문 (이 저장소)

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### 관련 논문

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  


## 참고문헌

본 모델이나 데이터셋을 연구에 사용하실 경우 논문을 인용해 주세요.

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