# FFGO: 视频内容定制的首选起点

**“视频内容定制的首选起点”官方仓库**

**English:**  
[[网站](http://firstframego.github.io)] | [[论文](https://arxiv.org/abs/2511.15700)] | [[🔴 YouTube：非官方社区展示](https://www.youtube.com/watch?v=Dks3q5w7sdw)] | [[🔴 真实用户演示](https://github.com/kijai/ComfyUI-WanVideoWrapper/issues/1676)]

**中文:**  
[[新智元](https://mp.weixin.qq.com/s/XQGmskJqqFdKx4vCc45tDA)] | [[bilibili](https://www.bilibili.com/video/BV1DQSzB9Eo7/)]


![teaser.gif](https://raw.githubusercontent.com/zli12321/FFGO-Video-Customization/main/./asset/git.gif)



### 即将推出  
- 添加官方 ComfyUI 工作流支持，使用我们训练的 LoRA，所有参数设置与推理代码保持一致。  
- 待办事项：发布适用于更小规模基础模型的 LoRA - 混元 1.5 8B 或 Wan2.2 5B  


**🤗 Huggingface 上的 Lora 适配器：**  
- [FFGO-Lora-Adapter](https://huggingface.co/Video-Customization/FFGO-Lora-Adapter)


#### 训练数据示例  
- **请注意，我们目前只提供了 50 个训练视频的一个子集以演示数据格式。**

- 请查看 ```/Data/train/``` 文件夹

### 安装配置  
- 创建环境
```
conda create -n ffgo python=3.11
conda activate ffgo
```
- 克隆仓库并设置

```
git clone https://github.com/zli12321/FFGO-Video-Customization.git
cd FFGO-Video-Customization
bash setup.sh
```


### Test data
- Test data is available in [Data](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/combined_first_frames) folder. All test data involving personal portrait rights has been removed. [0-data.csv](https://github.com/zli12321/FFGO-Video-Customization/blob/main/Data/combined_first_frames/0-data.csv) has the input image path and the caption to generate the video.
- Test data materials are available in [data_materials](https://github.com/zli12321/FFGO-Video-Customization/tree/main/Data/data_materials) folder. These are materials that can form the final input image for video generations.
- Get your own test data: find any images online and segment out the elements as RGBA layer, then combine it with a background using our [combine script]().


### Running Inference

- **When running on your own data, make sure to append our learned transition phrase, "ad23r2 the camera view suddenly changes. ", to your text prompt to ensure the model behaves correctly.**

- **All video results in the paper are generated at 1280 × 720 resolution with 81 frames, which requires an H200 GPU for inference unless memory-saving techniques are applied. For lower resource usage, 640 × 480 resolution videos can be generated without H200. However outputs at this lower resolution can differ significantly in content from the 1280 × 720 results as we shown in the paper.**

- **We are using H200 (141GB RAM) to run inference. If you are using A100 or H100, the memory saving such as cpu offload features need to be turned on.**

1. Download [Wan2.2-I2V-14B](https://huggingface.co/Wan-AI/Wan2.2-I2V-A14B) from huggingface or modelscope and download our Lora adapters. 

```bash
bash download.sh
```


2. Run fun demo video inference

```
bash ./example_single_inference.sh
```
3. 在我们的示例测试数据集上运行连续推理

```
bash example_inference.sh
```

<!-- 
4. Run 4 Step Lora speedup (Will cause quality degrade and inconsistency.)

```
bash ./example_4_step_lora_inference.sh
``` -->


### 引用
```
@article{chen2025first,
  title={First Frame Is the Place to Go for Video Content Customization},
  author={Chen, Jingxi and Li, Zongxia and Liu, Zhichao and Shi, Guangyao and Wu, Xiyang and Liu, Fuxiao and Fermuller, Cornelia and Feng, Brandon Y and Aloimonos, Yiannis},
  journal={arXiv preprint arXiv:2511.15700},
  year={2025}
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-08

---