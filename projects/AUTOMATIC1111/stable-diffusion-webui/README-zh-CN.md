# Stable Diffusion 网页界面
使用 Gradio 库实现的 Stable Diffusion 网络接口。

![](https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/screenshot.png)

## 功能
[详细功能展示及图片](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features)：
- 原始的 txt2img 和 img2img 模式
- 一键安装和运行脚本（但你仍需安装 python 和 git）
- 外扩绘制
- 内填绘制
- 颜色草图
- 提示矩阵
- Stable Diffusion 放大
- 关注度，指定模型应更加关注文本的某些部分
    - 一个穿着 `((燕尾服))` 的男人 - 会更加关注燕尾服
    - 一个穿着 `(燕尾服:1.21)` 的男人 - 替代语法
    - 选中文本并按 `Ctrl+Up` 或 `Ctrl+Down`（macOS 上是 `Command+Up` 或 `Command+Down`）自动调整选中文本的关注度（代码由匿名用户贡献）
- 循环回传，多次运行 img2img 处理
- X/Y/Z 图，绘制具有不同参数的图像三维图的方式
- 文本反演
    - 可以拥有任意多的嵌入向量，并使用任何喜欢的名称
    - 支持多个嵌入，每个令牌可有不同数量的向量
    - 支持半精度浮点数
    - 可在 8GB 显存上训练嵌入（也有 6GB 可用的报告）
- 扩展标签页包含：
    - GFPGAN，修复人脸的神经网络
    - CodeFormer，作为 GFPGAN 替代的人脸修复工具
    - RealESRGAN，神经网络放大器
    - ESRGAN，带有许多第三方模型的神经网络放大器
    - SwinIR 和 Swin2SR（[见这里](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)），神经网络放大器
    - LDSR，潜在扩散超分辨率放大
- 调整宽高比选项
- 采样方法选择
    - 调整采样器 eta 值（噪声乘数）
    - 更高级的噪声设置选项
- 可随时中断处理
- 支持 4GB 显卡（也有 2GB 可用的报告）
- 批量正确的随机种子
- 实时提示令牌长度验证
- 生成参数
     - 生成图像时使用的参数会随图像保存
     - PNG 文件以 PNG 块形式保存，JPEG 以 EXIF 保存
     - 可以将图像拖到 PNG 信息标签页以恢复生成参数并自动复制到界面
     - 可在设置中禁用
     - 支持将图像/文本参数拖放到提示框
- 读取生成参数按钮，加载提示框中的参数到界面
- 设置页面
- 从界面运行任意 python 代码（需使用 `--allow-code` 运行以启用）
- 大多数界面元素有鼠标悬停提示
- 可通过文本配置更改默认值/混合值/最大值/步长值
- 瓦片支持，复选框用于创建可以平铺的纹理图像
- 进度条和实时图像生成预览
    - 可使用单独神经网络生成预览，几乎不占用显存或计算资源
- 负面提示，额外文本框允许列出不希望出现在生成图像中的内容
- 样式，保存部分提示并通过下拉菜单轻松应用
- 变体，生成相同图像但有微小差异的方式
- 种子缩放，生成相同图像但分辨率稍有不同
- CLIP 询问器，尝试从图像猜测提示的按钮
- 提示编辑，生成过程中更改提示，比如开始做西瓜，中途切换到动漫女孩
- 批量处理，使用 img2img 处理一组文件
- Img2img 替代方法，交叉注意力控制的反向欧拉方法
- 高分辨率修正，一键生成高分辨率图片且无通常失真
- 动态重新加载检查点
- 检查点合并，标签页允许合并最多 3 个检查点为一个
- [自定义脚本](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts)，社区提供多种扩展
- [可组合扩散](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)，同时使用多个提示的方式
     - 使用大写 `AND` 分隔提示
     - 支持提示权重：`一只猫 :1.2 AND 一只狗 AND 一只企鹅 :2.2`
- 提示无令牌限制（原始 Stable Diffusion 允许最多 75 个令牌）
- DeepDanbooru 集成，为动漫提示创建 danbooru 风格标签
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)，部分显卡大幅提升速度：（命令行参数添加 `--xformers`）
- 通过扩展：[历史标签](https://github.com/yfszzx/stable-diffusion-webui-images-browser)：方便在界面内查看、导向和删除图像
- 永远生成选项
- 训练标签页
     - 超网络和嵌入向量选项
     - 图像预处理：裁剪、镜像、使用 BLIP 或 deepdanbooru 自动标注（动漫专用）
- Clip skip
- 超网络
- Loras（与超网络类似，但更美观）
- 独立界面，可以选择并预览要添加到提示中的嵌入向量、超网络或 Loras
- 可从设置界面选择加载不同的 VAE
- 进度条显示估计完成时间
- API 支持
- 支持 RunwayML 提供的专用[内填绘制模型](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion)
- 通过扩展：[美学梯度](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)，使用 CLIP 图像嵌入生成特定美学图像的方法（实现自 [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients)）
- 支持 [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) - 见 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) 获取说明
- 支持 [Alt-Diffusion](https://arxiv.org/abs/2211.06679) - 见 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) 获取说明
- 现在无任何不良字母！
- 加载 safetensors 格式的检查点
- 放宽分辨率限制：生成图像尺寸必须是 8 的倍数，而非 64 的倍数
- 现在附带许可证！
- 可从设置界面重新排序 UI 元素
- 支持 [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## 安装与运行
确保满足所需的[依赖](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)，并按照以下说明操作：
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)（推荐）
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) 显卡。
- [Intel CPU，Intel GPU（集成与独立）](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon)（外部 wiki 页面）
- [昇腾 NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs)（外部维基页面）

或者，使用在线服务（如 Google Colab）：

- [在线服务列表](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### 使用发布包在 Windows 10/11 上安装带 NVidia GPU 的版本
1. 从 [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) 下载 `sd.webui.zip` 并解压其内容。
2. 运行 `update.bat`。
3. 运行 `run.bat`。
> 更多详情请参见 [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Windows 上的自动安装
1. 安装 [Python 3.10.6](https://www.python.org/downloads/release/python-3106/)（较新版本的 Python 不支持 torch），勾选“将 Python 添加到 PATH”。
2. 安装 [git](https://git-scm.com/download/win)。
3. 下载 stable-diffusion-webui 仓库，例如运行 `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`。
4. 在 Windows 资源管理器中以普通非管理员用户身份运行 `webui-user.bat`。

### Linux 上的自动安装
1. 安装依赖项：
```bash
# Debian-based:
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat-based:
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE-based:
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch-based:
sudo pacman -S wget git python3
```
如果您的系统非常新，您需要安装 python3.11 或 python3.10：
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # do not confuse with python3.11 package

# Only for 3.11
# Then set up env variable in launch script
export python_cmd="python3.11"
# or in webui-user.sh
python_cmd="python3.11"
```
2. 导航到您希望安装 webui 的目录并执行以下命令：
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
或者直接在你想要的位置克隆仓库：
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```
3. 运行 `webui.sh`。  
4. 查看 `webui-user.sh` 了解选项。  
### 在 Apple Silicon 上安装  

安装说明见[此处](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)。  

## 贡献  
以下是向此仓库添加代码的方法：[贡献指南](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)  

## 文档  

文档已从此 README 移至项目的[wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)。  

为了让 Google 和其他搜索引擎抓取 wiki，这里有一个（非为人类设计的）[可抓取 wiki 链接](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki)。  

## 致谢  
借用代码的许可证可在 `Settings -> Licenses` 界面以及 `html/licenses.html` 文件中找到。  

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref  
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git  
- Spandrel - https://github.com/chaiNNer-org/spandrel 实现了  
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git  
  - CodeFormer - https://github.com/sczhou/CodeFormer  
  - ESRGAN - https://github.com/xinntao/ESRGAN  
  - SwinIR - https://github.com/JingyunLiang/SwinIR  
  - Swin2SR - https://github.com/mv-lab/swin2sr  
- LDSR - https://github.com/Hafiidz/latent-diffusion  
- MiDaS - https://github.com/isl-org/MiDaS  
- 优化思路 - https://github.com/basujindal/stable-diffusion  
- 交叉注意力层优化 - Doggettx - https://github.com/Doggettx/stable-diffusion，提示编辑的原始想法。  
- 交叉注意力层优化 - InvokeAI，lstein - https://github.com/invoke-ai/InvokeAI（原项目 http://github.com/lstein/stable-diffusion）  
- 亚二次方复杂度交叉注意力层优化 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)  
- 文本反演 - Rinon Gal - https://github.com/rinongal/textual_inversion（我们未使用他的代码，但采纳了他的思路）。  
- SD 放大思路 - https://github.com/jquesnelle/txt2imghd  
- mk2 外延噪声生成 - https://github.com/parlance-zz/g-diffuser-bot  
- CLIP 询问器的想法及部分代码借用 - https://github.com/pharmapsychotic/clip-interrogator  
- 可组合扩散的思路 - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch  
- xformers - https://github.com/facebookresearch/xformers  
- DeepDanbooru - 动漫扩散器的询问器 https://github.com/KichangKim/DeepDanbooru  
- 从 float16 UNet 浮点32精度采样 - 感谢 marunine 的想法，Birch-san 的 Diffusers 示例实现（https://github.com/Birch-san/diffusers-play/tree/92feee6）  
- Instruct pix2pix - Tim Brooks（星标）、Aleksander Holynski（星标）、Alexei A. Efros（无星标）- https://github.com/timothybrooks/instruct-pix2pix  
- 安全建议 - RyotaK  
- UniPC 采样器 - Wenliang Zhao - https://github.com/wl-zhao/UniPC  
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd  
- LyCORIS - KohakuBlueleaf  
- 重新开始采样 - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling  
- Hypertile - tfernd - https://github.com/tfernd/HyperTile  
- 初始 Gradio 脚本 - 由匿名用户在 4chan 发布。感谢匿名用户。  
- （你）



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---