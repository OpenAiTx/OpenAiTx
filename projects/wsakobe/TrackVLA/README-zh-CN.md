<p align="center">
<h1 align="center"><strong>TrackVLA: 野外具身视觉跟踪</strong></h1>
  <p align="center">
    <!--   	<strong>CoRL 2025</strong><br> -->
    <a href='https://wsakobe.github.io/' target='_blank'>王少安</a>&emsp;
	<a href='https://jzhzhang.github.io/' target='_blank'>张家钊</a>&emsp;
    李明翰&emsp;
    刘嘉航&emsp;
    李安琪&emsp; <br>
    吴奎&emsp;
    <a href='https://fangweizhong.xyz/' target='_blank'>钟方伟</a>&emsp;
    <a href='https://www.coe.pku.edu.cn/teaching/manufacturing/9993.html' target='_blank'>余俊志</a>&emsp;
	<a href='https://scholar.google.com/citations?user=X7M0I8kAAAAJ&hl=zh-CN' target='_blank'>张志铮</a>&emsp;
  <a href='https://hughw19.github.io/' target='_blank'>王贺</a>&emsp;
    <br>
    北京大学&emsp; 
    Galbot&emsp; <br>
    北京航空航天大学&emsp;
    北京师范大学&emsp;
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

## 🏡 简介
<strong><em>TrackVLA</em></strong> 是一个具备同时目标识别和视觉跟踪能力的视觉-语言-动作模型，在170万样本的数据集上训练。该模型在多样且具有挑战性的环境下展现出强大的跟踪能力、长时序跟踪能力以及跨领域泛化能力。
<div style="text-align: center;">
    <img src="https://raw.githubusercontent.com/wsakobe/TrackVLA/main/assets/teaser.png" alt="Dialogue_Teaser" width=100% >
</div>

## 📢 新闻

* [25/07/02]: EVT-Bench 现已开放。

## 💡 安装
1. **准备 conda 环境**

   首先需要安装 [conda](https://docs.conda.io/projects/conda/en/latest/user-guide/install/)。conda 安装完成后，创建一个新环境：
   ```bash
   conda create -n evt_bench python=3.9 cmake=3.14.0
   conda activate evt_bench
   ```

2. **用 conda 安装 habitat-sim**
   
   需要安装 habitat-sim v0.3.1
      ```
      conda install habitat-sim==0.3.1 withbullet -c conda-forge -c aihabitat
      ```

3. **从源码安装 habitat-lab**
      ```
      cd habitat-lab
      pip install -e habitat-lab
      ```

4. **准备数据集**

    从[这里](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#habitat-matterport-3d-research-dataset-hm3d)下载 Habitat Matterport 3D (HM3D) 数据集，从[这里](https://github.com/facebookresearch/habitat-sim/blob/main/DATASETS.md#matterport3d-mp3d-dataset)下载 Matterport3D (MP3D) 数据集。

    然后将数据集移动到 `data/scene_datasets` 目录下。数据集结构如下所示：
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

    接下来，运行以下代码以获取人形角色的数据：
      ```
      python download_humanoid_data.py
      ```


## 🧪 评测
  使用以下脚本运行：

    bash eval.sh

  结果将保存在指定的 SAVE_PATH 下，其中包括日志目录和视频目录。若需在评测过程中实时监控结果，请运行：
    watch -n 1 python analyze_results.py --path YOUR_RESULTS_PATH

  若要停止评估，请使用：

    bash kill_eval.sh


## 📝 待办事项
- [x] 于2025年5月发布arXiv论文。
- [x] 发布EVT-Bench（具身视觉追踪基准）。
- [ ] 发布大规模具身视觉追踪数据集。
- [ ] 发布TrackVLA的模型权重和代码。

## ✉️ 联系方式
如有任何问题，请随时发送邮件至 wangshaoan@stu.pku.edu.cn。我们会尽快回复您。


## 🔗 引用
如果您觉得我们的工作有帮助，请考虑按如下方式引用：

```bibtex
@article{wang2025trackvla,
  title={Trackvla: Embodied visual tracking in the wild},
  author={Wang, Shaoan and Zhang, Jiazhao and Li, Minghan and Liu, Jiahang and Li, Anqi and Wu, Kui and Zhong, Fangwei and Yu, Junzhi and Zhang, Zhizheng and Wang, He},
  journal={arXiv preprint arXiv:2505.23189},
  year={2025}
}
```

## 📄 许可证
<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-sa/4.0/80x15.png" /></a>
<br />
本作品采用<a rel="license" href="http://creativecommons.org/licenses/by-nc-sa/4.0/">知识共享署名-非商业性使用-相同方式共享 4.0 国际许可协议</a>进行许可。

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-04

---