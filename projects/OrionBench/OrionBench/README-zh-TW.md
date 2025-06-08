<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench：資訊圖表中圖表與人類可識別物件偵測的基準數據集
</h1>

## 數據集

本儲存庫包含論文「OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics」的程式碼。相關數據可於 [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) 取得。

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## 評估物件偵測模型
請先依照 [MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection) 的說明設置環境。

我們使用 MMDetection 訓練與測試四種物件偵測模型：[Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py)、[YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py)、[RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py)、以及 [Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py)。

請於相應的四個配置檔中修改「YOUR ROOT」與「YOUR DATASET」。

執行下列指令以訓練模型：
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

下圖展示了評測物件偵測模型的偵測結果：(a) 使用 DINO-X 的 zero-shot prompting；(b) 使用 T-Rex2 的 4-shot prompting；(c) 使用 Co-DETR 的 4-shot 微調；(d) 在 OrionBench 上以 Co-DETR 微調。彩色邊框為圖表與人類可識別物件（HROs）的預測框。

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

此外，與本基準共同開發的基於 InternImage 的模型可於 [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) 取得。

## 論文連結

### 主要論文（本儲存庫）

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_  

### 相關論文

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_  

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_  

## 參考文獻

若您的研究中使用了我們的模型或數據集，請引用我們的論文：

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