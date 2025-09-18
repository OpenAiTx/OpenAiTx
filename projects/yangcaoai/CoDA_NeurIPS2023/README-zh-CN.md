
## :book: CoDA：用于开放词汇3D物体检测的协作新颖盒发现与跨模态对齐（NeurIPS2023）
<p align="center">
  <small> 🔥请为CoDA⭐点赞并分享，谢谢🔥 </small>
</p>

> [[论文](https://arxiv.org/abs/2310.02960)] &emsp; [[项目主页](https://yangcaoai.github.io/publications/CoDA.html)] <br>
<!-- > [杨超](https://yangcaoai.github.io/), 曾怡涵, [徐航](https://xuhangcn.github.io/), [许丹](https://www.danxurgb.net) <br> -->
<!-- > 香港科技大学, 华为诺亚方舟实验室 -->
> [杨超](https://yangcaoai.github.io/), 曾怡涵, [徐航](https://xuhangcn.github.io/), [许丹](https://www.danxurgb.net) <br>
> 香港科技大学<br>
> 华为诺亚方舟实验室

:triangular_flag_on_post: **更新动态**  

&#9745; 我们的新工作 **CoDAv2** 被TPAMI接收，查看链接 [这里](https://arxiv.org/pdf/2406.00830v2)！

&#9745; 作为首个将3D高斯点渲染引入3D物体检测的工作，3DGS-DET已发布，链接见[这里](https://arxiv.org/pdf/2410.01647)！

&#9745; 最新的开放词汇感知相关论文与代码汇总见[这里](https://github.com/yangcaoai/Awesome-Open-Vocabulary-Perception)。

&#9745; 所有代码、数据和预训练模型均已发布！

&#9745; 训练和测试代码已发布。

&#9745; 预训练模型已发布。

&#9745; 开放词汇设置下的SUN-RGBD数据集已发布。  

&#9745; 开放词汇设置下的ScanNet数据集已发布。

&#9745; 论文LaTeX代码可在 https://scienhub.com/Yang/CoDA 获取。

## 框架  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/ov3d_det.png">

## 示例  
<img src="https://raw.githubusercontent.com/yangcaoai/CoDA_NeurIPS2023/main/assets/CoDA_sup_fig0_v3_cropped_compressed_v2.jpg">

## 安装
我们的代码基于 PyTorch 1.8.1、torchvision==0.9.1、CUDA 10.1 和 Python 3.7。它可能也适用于其他版本。

请同时安装以下 Python 依赖项：

```
matplotlib
opencv-python
plyfile
'trimesh>=2.35.39,<2.35.40'
'networkx>=2.2,<2.3'
scipy
```
请通过运行以下命令安装 `pointnet2` 层


```
cd third_party/pointnet2 && python setup.py install
```
请安装一个 Cython 实现的 gIOU 以加快训练速度。

```
conda install cython
cd utils && python cython_compile.py build_ext --inplace
```

## 数据集准备

为了实现开放词汇设置，我们重新组织了原始的 [ScanNet](https://github.com/facebookresearch/votenet/tree/main/scannet) 和 [SUN RGB-D](https://github.com/facebookresearch/votenet/tree/main/sunrgbd) 数据集，并采用了更多类别的标注。请直接下载我们提供的开放词汇设置数据集：[OV SUN RGB-D](https://huggingface.co/datasets/YangCaoCS/Open-Vocabulary-SUN-RGBD) 和 [OV ScanNet](https://hkustconnect-my.sharepoint.com/:f:/g/personal/ycaobd_connect_ust_hk/EsqoPe7-VFxOlY0a-v1-vPwBSiEHoGRTgK5cLIhnjyXiEQ?e=jY7nKT)。

然后对下载的 *.tar 文件运行：
```
bash data_preparation.sh
```

## 评估
在此处下载预训练模型 [here](https://drive.google.com/file/d/1fTKX1ML5u8jJ249GwAYqdCZGs941907H/view?usp=drive_link)。
然后运行：
```
bash test_release_models.sh
```

## 训练
```
bash scripts/coda_sunrgbd_stage1.sh
bash scripts/coda_sunrgbd_stage2.sh
```
## 运行示例
```
bash run_samples.sh
```

## :scroll: BibTeX
如果CoDA对您有帮助，请引用：
```
@inproceedings{cao2023coda,
  title={CoDA: Collaborative Novel Box Discovery and Cross-modal Alignment for Open-vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  booktitle={NeurIPS},
  year={2023}
}

@article{cao2024collaborative,
  title={Collaborative Novel Object Discovery and Box-Guided Cross-Modal Alignment for Open-Vocabulary 3D Object Detection},
  author={Cao, Yang and Zeng, Yihan and Xu, Hang and Xu, Dan},
  journal={IEEE Transactions on Pattern Analysis and Machine Intelligence (TPAMI)},
  year={2025}
}
```

## :e-mail: 联系方式

如果您有任何问题或合作需求（研究目的或商业目的），请发送邮件至 `yangcao.cs@gmail.com`。

## :scroll: 致谢
CoDA 的灵感来自 [CLIP](https://github.com/openai/CLIP) 和 [3DETR](https://github.com/facebookresearch/3detr)。我们感谢他们出色的代码。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-18

---