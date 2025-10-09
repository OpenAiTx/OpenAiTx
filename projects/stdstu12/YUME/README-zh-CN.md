<div align="center">
<img src=assets/yume.png width="20%"/>
</div>

# Yume：一个交互式世界生成模型

Yume 是一个长期项目，旨在通过文本、图像或视频的输入创建一个交互式、逼真且动态的世界。


<div align="center">




[![project page](https://img.shields.io/badge/Project-Page-2ea44f)](https://stdstu12.github.io/YUME-Project/)&nbsp;
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2507.17744-b31b1b.svg)](https://arxiv.org/abs/2507.17744)&nbsp;
[![model](https://img.shields.io/badge/%F0%9F%A4%97%20Hugging%20Face-Model-blue)](https://huggingface.co/stdstu123/Yume-I2V-540P)&nbsp;
[![YouTube](https://badges.aleen42.com/src/youtube.svg)](https://www.youtube.com/watch?v=51VII_iJ1EM)&nbsp;

</div>

- 视频 DiT 的蒸馏方案。
- [FramePack-Like](https://github.com/lllyasviel/FramePack) 训练代码。
- 支持 DDP/FSDP 采样的长视频生成方法。



## 🔧 安装
代码已在 Python 3.10.0、CUDA 12.1 和 A100 上测试。
```
./env_setup.sh fastvideo
pip install -r requirements.txt
```
您需要在每次修改代码后运行 `pip install .`，或者您也可以将修改后的文件直接复制到您的虚拟环境中。例如，如果我修改了 `wan/image2video.py`，并且我的虚拟环境是 `yume`，我可以将该文件复制到：
`envs/yume/lib/python3.10/site-packages/wan/image2video.py`。

## 🚀 推理

### ODE
对于图像到视频的生成，我们使用 `--jpg_dir="./jpg"` 指定输入图片目录，使用 `--caption_path="./caption.txt"` 提供文本条件输入，每一行对应一个生成实例，控制生成2秒的视频输出。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_jpg.sh 
```
我们还考虑使用来自 `./val` 的数据生成视频，其中 `--test_data_dir="./val"` 指定示例数据的位置。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample.sh 
```
### SDE
我们执行 TTS 采样，其中 `args.sde` 控制是否使用基于 SDE 的采样。
```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/inference/sample_tts.sh 
```
为了获得最佳效果，我们建议将实际距离、角速度变化率（转向速度）和视图旋转速度保持在0.1到10的范围内。

关键调整指南：  
1. 执行摄像机保持静止（·）时，减小实际距离值  
2. 执行人物保持静止时，降低角速度变化率和视图旋转速度值  

请注意，这些参数（实际距离、角速度变化率和视图旋转速度）确实会影响生成结果。作为替代方法，您也可以考虑完全移除这些参数以简化操作。

## 🎯 训练与蒸馏  
在模型训练中，我们使用 `args.MVDT` 启动 MVDT 框架，该框架至少需要16块A100 GPU。将T5加载到CPU上可以帮助节省GPU内存。我们使用 `args.Distil` 来启用对抗蒸馏。



```bash
# Download the model weights and place them in Path_To_Yume.
bash scripts/finetune/finetune.sh
```

## 🧱 数据集准备
请参考 https://github.com/Lixsp11/sekai-codebase 下载数据集。有关处理后数据的格式，请参见 `./test_video`。
```
path_to_processed_dataset_folder/
├── Keys_None_Mouse_Down/ 
│   ├── video_id.mp4
│   ├── video_id.txt
├── Keys_None_Mouse_Up
│──  ...
└── Keys_S_Mouse_·
```
所提供的TXT文件内容记录了相机运动控制参数或动画关键帧数据，字段定义如下：
```
Start Frame: 2 #Starting frame number (begins at frame 2 at origin video)

End Frame: 50 #Ending frame number

Duration: 49 frames #Total duration

Keys: W #Keyboard input

Mouse: ↓ #Mouse action
```
在 `scripts/finetune/finetune.sh` 中，`args.root_dir` 表示 `path_to_processed_dataset_folder`，而 `args.root_dir` 表示 Sekai 数据集的完整路径。


## 📑 开发计划
- 数据集处理
  - [ ] 提供处理后的数据集
- 代码更新
  - [ ] fp8 支持
  - [ ] 更好的蒸馏方法
- 模型更新
  - [ ] 量化和蒸馏模型
  - [ ] 支持 720p 分辨率生成的模型​

## 🤝 贡献
我们欢迎所有贡献。


## 致谢
我们学习并复用了以下项目的代码：
- [FastVideo](https://github.com/hao-ai-lab/FastVideo)
- [diffusers](https://github.com/huggingface/diffusers)
- [HunyuanVideo-I2V](https://github.com/Tencent-Hunyuan/HunyuanVideo-I2V)
- [Wan2.1](https://github.com/Wan-Video/Wan2.1)
- [Skywork-Reward-V2](https://github.com/SkyworkAI/Skywork-Reward-V2)
- [MDT](https://github.com/sail-sg/MDT)
- [AddSR](https://github.com/NJU-PCALab/AddSR)

## 引用
如果您在研究中使用了 Yume，请引用我们的论文：

```bibtex
@article{mao2025yume,
  title={Yume: An Interactive World Generation Model},
  author={Mao, Xiaofeng and Lin, Shaoheng and Li, Zhen and Li, Chuanhao and Peng, Wenshuo and He, Tong and Pang, Jiangmiao and Chi, Mingmin and Qiao, Yu and Zhang, Kaipeng},
  journal={arXiv preprint arXiv:2507.17744},
  year={2025}
}

```


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-10-09

---