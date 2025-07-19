# ATI: 可控视频生成的任意轨迹指令

<div align="center">
  
[![arXiv](https://img.shields.io/badge/arXiv%20paper-2505.22944-b31b1b.svg)](https://arxiv.org/pdf/2505.22944)&nbsp;
[![project page](https://img.shields.io/badge/Project_page-ATI-green)](https://anytraj.github.io/)&nbsp;
<a href="https://huggingface.co/bytedance-research/ATI/"><img src="https://img.shields.io/static/v1?label=%F0%9F%A4%97%20Hugging%20Face&message=Model&color=orange"></a>
</div>


> [**ATI: 可控视频生成的任意轨迹指令**](https://anytraj.github.io/)<br>
> [Angtian Wang](https://angtianwang.github.io/), [Haibin Huang](https://brotherhuang.github.io/), Jacob Zhiyuan Fang, [Yiding Yang](https://ihollywhy.github.io/), [Chongyang Ma](http://www.chongyangma.com/)
> <br>字节跳动智能创作团队<br>

[![观看视频](https://raw.githubusercontent.com/bytedance/ATI/main/assets/thumbnail.jpg)](https://youtu.be/76jjPT0f8Hs)

这是Wan2.1 ATI（可控视频生成的任意轨迹指令）的代码库，一个基于轨迹的运动控制框架，统一了视频生成中的物体、局部和摄像机运动。该代码库基于[Wan2.1官方实现](https://github.com/Wan-Video/Wan2.1)。

相比原始Wan2.1，我们新增了以下文件：
- wan/modules/motion_patch.py          | 轨迹指令核心模块
- wan/utils/motion.py                  | 推理数据加载工具
- tools/plot_user_inputs.py            | 用户输入轨迹可视化工具
- tools/visualize_trajectory.py        | 生成视频可视化工具
- tools/trajectory_editor/             | 交互式轨迹编辑器
- examples/                            | 测试示例
- run_example.sh                       | 简易启动脚本

我们修改了以下文件：
- wan/image2video.py                   | 新增加载和解析轨迹的模块  #L256
- wan/configs/__init__.py              | 配置ATI相关内容
- generate.py                          | 新增入口以加载yaml格式推理示例

## 社区作品
### ComfyUI
感谢Kijai开发了ATI的ComfyUI节点：
[https://github.com/kijai/ComfyUI-WanVideoWrapper](https://github.com/kijai/ComfyUI-WanVideoWrapper)

FP8量化Huggingface模型：[https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors](https://huggingface.co/Kijai/WanVideo_comfy/blob/main/Wan2_1-I2V-ATI-14B_fp8_e4m3fn.safetensors)

### 指南
Benji的使用指南：[https://www.youtube.com/watch?v=UM35z2L1XbI](https://www.youtube.com/watch?v=UM35z2L1XbI)

## 安装

ATI需要与官方Wan 2.1相同的环境。请按照INSTALL.md（Wan2.1）的说明进行安装。

```
git clone https://github.com/bytedance/ATI.git
cd ATI
```
安装软件包


```
pip install .
```
首先，您需要下载Wan2.1的14B原始模型。


```
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./Wan2.1-I2V-14B-480P
```
然后从我们的 huggingface 仓库下载 ATI-Wan 模型。


```
huggingface-cli download bytedance-research/ATI --local-dir ./Wan2.1-ATI-14B-480P
```
最后，将VAE、T5及其他杂项检查点从原始Wan2.1文件夹复制到ATI检查点位置


```
cp ./Wan2.1-I2V-14B-480P/Wan2.1_VAE.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_t5_umt5-xxl-enc-bf16.pth ./Wan2.1-ATI-14B-480P/
cp ./Wan2.1-I2V-14B-480P/models_clip_open-clip-xlm-roberta-large-vit-huge-14.pth ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/xlm-roberta-large ./Wan2.1-ATI-14B-480P/
cp -r ./Wan2.1-I2V-14B-480P/google ./Wan2.1-ATI-14B-480P/
```

## Run

We provide a demo sript to run ATI.

```
bash run_example.sh -p examples/test.yaml -c ./Wan2.1-ATI-14B-480P -o samples
```
where `-p` 是配置文件的路径，`-c` 是检查点文件的路径，`-o` 是输出目录的路径，`-g` 定义使用的 GPU 数量（如果未指定，将使用所有可用 GPU；如果给定 `1`，则以单进程模式运行）。

完成后，您将看到以下内容：
- `samples/outputs` 目录下是原始输出视频。
- `samples/images_tracks` 显示输入图像及用户指定的轨迹。
- `samples/outputs_vis` 显示输出视频及用户指定的轨迹。

预期结果：


<table style="width: 100%; border-collapse: collapse; text-align: center; border: 1px solid #ccc;">
  <tr>
    <th style="text-align: center;">
      <strong>输入图像及轨迹</strong>
    </th>
    <th style="text-align: center;">
      <strong>生成的视频（叠加轨迹）</strong>
    </th>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.jpg" alt="Image 0" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/00.gif" alt="Image 0" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.jpg" alt="Image 1" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/01.gif" alt="Image 1" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.jpg" alt="Image 2" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/02.gif" alt="Image 2" style="height: 160px;">
    </td>
  </tr>

  </tr>
  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.jpg" alt="Image 3" style="height: 220px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/03.gif" alt="Image 3" style="height: 220px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.jpg" alt="Image 4" style="height: 240px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/04.gif" alt="Image 4" style="height: 240px;">
    </td>
  </tr>

  <tr>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.jpg" alt="Image 5" style="height: 160px;">
    </td>
    <td style="text-align: center; vertical-align: middle;">
      <img src="https://raw.githubusercontent.com/bytedance/ATI/main/assets/examples/05.gif" alt="Image 5" style="height: 160px;">
    </td>
  </tr>
</table>


## 创建您自己的轨迹

我们提供了一个交互式工具，允许用户在图像上绘制和编辑轨迹。

1. 首先运行：
```
cd tools/trajectory_editor
python3 app.py
```
then open this url [localhost:5000](http://localhost:5000/) in the browser. Note if you run the editor on the server, you need to replace `localhost` with the server's IP address.

2. Get the interface shown below, then click **Choose File** to open a local image.  
![Interface Screenshot](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor0.PNG)

3. Available trajectory functions:  
![Trajectory Functions](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor1.PNG)

   a. **Free Trajectory**: Click and then drag with the mouse directly on the image.  
   b. **Circular (Camera Control)**:  
      - Place a circle on the image, then drag to set its size for frame 0.  
      - Place a few (3–4 recommended) track points on the circle.  
      - Drag the radius control to achieve zoom-in/zoom-out effects.  

   c. **Static Point**: A point that remains stationary over time.  

   *Note:* Pay attention to the progress bar in the box to control motion speed.  
   ![Progress Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor2.PNG)

4. **Trajectory Editing**: Select a trajectory here, then delete, edit, or copy it. In edit mode, drag the trajectory directly on the image. The selected trajectory is highlighted by color.  
![Trajectory Editing](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor3.PNG)

5. **Camera Pan Control**: Enter horizontal (X) or vertical (Y) speed (pixels per frame). Positive X moves right; negative X moves left. Positive Y moves down; negative Y moves up. Click **Add to Selected** to apply to the current trajectory, or **Add to All** to apply to all trajectories. The selected points will gain a constant pan motion on top of their existing movement.  
![Camera Pan Control](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor4.PNG)

6. **Important:** After editing, click **Store Tracks** to save. Each image (not each trajectory) must be saved separately after drawing all trajectories.  
![Store Tracks](https://raw.githubusercontent.com/bytedance/ATI/main/assets/editor5.PNG)

7. Once all edits are complete, locate the `videos_example` folder in the **Trajectory Editor**.


## Citation
Please cite our paper if you find our work useful:
```
@article{wang2025ati,
  title={{ATI}: Any Trajectory Instruction for Controllable Video Generation},
  author={Wang, Angtian and Huang, Haibin and Fang, Zhiyuan and Yang, Yiding, and Ma, Chongyang}
  journal={arXiv preprint},
  volume={arXiv:2505.22944},
  year={2025}
}
```



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---