<p align="center">
<h1 align="center"><strong>TrackVLA：野外實體視覺追蹤</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>王紹安</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>張家釗</a>&emsp;
    李明翰&emsp;
    劉嘉航&emsp;
    李安琪&emsp; <br>
    吳魁&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>鍾方維</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>余俊志</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>張智正</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>王赫</a>&emsp;
    <br>
    北京大學&emsp; 
    Galbot&emsp; <br>
    北京航空航天大學&emsp;
    北京師範大學&emsp;
    北京智源人工智能研究院&emsp;
    <br>
  </p>
</p>

<div id="top" align="center">

[![Project](https://img.shields.io/badge/Project-%239c403d?style=flat&logoColor=%23FA7F6F
)](https://pku-epic.github.io/TrackVLA-web/)
[![arXiv](https://img.shields.io/badge/Arxiv-%233b6291?style=flat&logoColor=%23FA7F6F
)](http://arxiv.org/abs/2505.23189)
[![Video](https://img.shields.io/badge/Video-%23c97937?style=flat&logoColor=%23FA7F6F
)](https://youtu.be/v51U3Nk-SK4?si=foz3zbYD8hLHSybC)

</div>

## 🏡 關於
<strong><em>TrackVLA</em></strong> 是一個視覺-語言-動作模型，能夠同時進行物體識別與視覺追蹤，基於170萬個樣本數據訓練。該模型展現了強大的追蹤能力、長時序追蹤能力，以及跨領域泛化能力，適用於各種具有挑戰性的環境中。
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 最新消息

* [25/07/02]：EVT-Bench 現已開放。

## 💡 安裝說明
1. **準備 conda 環境**

   首先，請安裝 [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/)。安裝完成後，建立新的環境：
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **使用 Conda 安裝 habitat-sim**
   
   你需要安裝 habitat-sim 版本 0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **從原始碼安裝 habitat-lab**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **準備數據集**

    從[這裡](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d)下載 Habitat Matterport 3D (HM3D) 數據集，從[這裡](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset)下載 Matterport3D (MP3D) 數據集。

    然後將數據集移動到 `data/scene_datasets`。資料夾結構如下：
    ```
    data/
     └── scene_datasets/
        ├── hm3d/
        │ ├── train/
        │ │   └── ...
        │ ├── val/
        │ │   └── ...
        │ └── minival
        │     └── ...
        └── mp3d/
          ├── 1LXtFkjw3qL
          │   └── ...
          └── ...
    ```

    接下來，運行以下指令以獲取人形虛擬人數據：
      ```
      python download_humanoid_data.py
      ```


## 🧪 評測
  運行以下腳本：

    bash eval.sh

  結果將儲存在指定的 SAVE_PATH，該路徑下會包含 log 目錄與 video 目錄。若要在評測過程中即時監控結果，請運行：
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  若要停止評估，請使用：

    bash kill_eval.sh


## 📝 TODO 清單
- [x] 於 2025 年 5 月發布 arXiv 論文。
- [x] 發布 EVT-Bench（具身視覺追蹤基準）。
- [ ] 發布大規模具身視覺追蹤資料集。
- [ ] 發布 TrackVLA 的檢查點與程式碼。

## ✉️ 聯絡方式
如有任何問題，請隨時發送電子郵件至 wangshaoan@stu.pku.edu.cn。我們會盡快回覆您。


## 🔗 引用
如果您覺得我們的工作有幫助，請考慮以下方式引用：

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 授權
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
本作品採用<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">創用CC 姓名標示-非商業性-相同方式分享 4.0 國際 授權條款</a>授權。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---