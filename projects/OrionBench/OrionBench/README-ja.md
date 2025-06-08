<h1>
  <img src="https://raw.githubusercontent.com/OrionBench/OrionBench/main/logo.png" alt="Logo" width="80" style="vertical-align: middle; margin-right: 10px;"/>
  OrionBench: インフォグラフィックスにおけるチャートおよび人間可読オブジェクト検出のためのベンチマーク
</h1>

## データセット

このリポジトリには、論文「OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics」のコードが含まれています。関連データは [Huggingface](https://huggingface.co/datasets/OrionBench/OrionBench) で入手可能です。

![TEASER](https://raw.githubusercontent.com/OrionBench/OrionBench/main/teaser.png)

## オブジェクト検出モデルの評価
まず[MMDetection](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection)の手順に従い環境をセットアップしてください。

MMDetectionを用いて、[Faster-Rcnn](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/faster_rcnn/faster-rcnn_my_full.py)、[YOLOv3](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/yolo/yolov3_my_full.py)、[RTMDet](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/configs/rtmdet/rtmdet_my_full.py)、[Co-DETR](https://raw.githubusercontent.com/OrionBench/OrionBench/main/mmdetection/projects/CO-DETR/configs/codino/co_dino_my_full.py)の4つのオブジェクト検出モデルを学習・テストします。

該当する4つの設定ファイル内の「YOUR ROOT」と「YOUR DATASET」を適宜修正してください。

以下のコマンドを実行してモデルを学習させます：
```
cd mmdetection
bash tools/dist_train.sh configs/faster_rcnn/faster-rcnn_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/faster-rcnn_my_full
bash tools/dist_train.sh configs/yolo/yolov3_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/yolov3_my_full
bash tools/dist_train.sh configs/rtmdet/rtmdet_my_full_new.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/rtmdet_my_full
bash tools/dist_train.sh projects/CO-DETR/configs/codino/co_dino_my_full.py 8 --cfg-options data.samples_per_gpu=1 optimizer_config.cumulative_iters=8 optimizer_config.type="GradientCumulativeOptimizerHook" --work-dir work_dir/codetr_my_full
```

次の図は、評価したオブジェクト検出モデルの検出結果を示しています：(a) DINO-Xによるゼロショットプロンプティング；(b) T-Rex2による4ショットプロンプティング；(c) Co-DETRによる4ショットファインチューニング；(d) Co-DETRを用いたOrionBenchでのファインチューニング。色付きのバウンディングボックスはチャートおよびHRO（Human-Recognizable Objects）の予測です。

![det_qual](https://raw.githubusercontent.com/OrionBench/OrionBench/main/det_qual.png)

さらに、ベンチマークと共同開発されたInternImageベースのモデルは [Huggingface](https://huggingface.co/OrionBench/InternImage_L_DINO) で利用可能です。

## 論文リンク

### メイン論文（本リポジトリ）

- **[OrionBench: A Benchmark for Chart and Human-Recognizable Object Detection in Infographics](https://arxiv.org/abs/2505.17473)**  
  _Jiangning Zhu, Yuxing Zhou, Zheng Wang, Juntao Yao, Yima Gu, Yuhui Yuan, Shixia Liu_

### 関連論文

- **[ChartGalaxy: A Dataset for Infographic Chart Understanding and Generation](https://arxiv.org/abs/2505.18668)**  
  _Zhen Li, Duan Li, Yukai Guo, Xinyuan Guo, Bowen Li, Lanxi Xiao, Shenyu Qiao, Jiashu Chen, Zijian Wu, Hui Zhang, Xinhuan Shu, Shixia Liu_

- **[InfoChartQA: A Benchmark for Multimodal Question Answering on Infographic Charts](https://arxiv.org/abs/2505.19028)**  
  _Minzhi Lin, Tianchi Xie, Mengchen Liu, Yilin Ye, Changjian Chen, Shixia Liu_


## 参考文献

本モデルまたはデータセットを研究で使用する場合は、以下の論文を引用してください。

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