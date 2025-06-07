# Stable Diffusion web UI
基于 Gradio 库实现的 Stable Diffusion Web 界面。

![](screenshot.png)

## 功能
[带图片的详细功能展示](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features)：
- 原生 txt2img 和 img2img 模式
- 一键安装和运行脚本（但你仍需自行安装 Python 和 git）
- 外延绘图（Outpainting）
- 局部修复（Inpainting）
- 彩色草图（Color Sketch）
- 提示矩阵（Prompt Matrix）
- Stable Diffusion 超分（Upscale）
- 注意力机制，指定模型应重点关注的文本部分
    - a man in a `((tuxedo))` - 模型会更加关注“tuxedo”
    - a man in a `(tuxedo:1.21)` - 另一种语法
    - 选中文本后按下 `Ctrl+Up` 或 `Ctrl+Down`（MacOS 为 `Command+Up` 或 `Command+Down`）可自动调整选中文本的注意力（代码由匿名用户贡献）
- 循环处理，多次运行 img2img
- X/Y/Z 绘图，可根据不同参数绘制三维图片图表
- 文本反演（Textual Inversion）
    - 可以添加任意数量的嵌入，并使用自定义名称
    - 支持多个每 Token 不同向量数量的嵌入
    - 支持半精度浮点数
    - 可在 8GB 显存（也有 6GB 显存可用的报告）上训练嵌入
- 附加功能（Extras）选项卡，包含：
    - GFPGAN，修复人脸的神经网络
    - CodeFormer，作为 GFPGAN 替代的人脸修复工具
    - RealESRGAN，神经网络超分辨率
    - ESRGAN，支持大量第三方模型的神经网络超分
    - SwinIR 和 Swin2SR（[见此处](https://github.com/AUTOMATIC1111/stable-diffusion-webui/pull/2092)），神经网络超分
    - LDSR，潜空间扩散超分辨率
- 调整尺寸比例选项
- 采样方法选择
    - 调整采样器 eta 值（噪声倍率）
    - 提供更高级的噪声设置选项
- 随时中断处理
- 支持 4GB 显卡（也有 2GB 可用的报告）
- 批量生成时的种子校正
- 实时提示词 Token 长度校验
- 生成参数
     - 生成图片时所用参数会随图片保存
     - PNG 保存在 PNG 的 chunk 中，JPEG 保存在 EXIF 信息中
     - 可将图片拖至 PNG info 选项卡以恢复生成参数并自动复制到界面
     - 可在设置中禁用
     - 支持拖拽图片/文本参数到提示框
- 读取生成参数按钮，将提示框中的参数加载至界面
- 设置页面
- 可在界面运行任意 Python 代码（需使用 `--allow-code` 启动以启用）
- 大多数 UI 元素均带有鼠标悬浮提示
- 可通过文本配置更改 UI 元素的默认/最小/最大/步进值
- 平铺支持，勾选后可生成可拼接为贴图的图片
- 进度条与实时图片生成预览
    - 可使用独立神经网络生成几乎不占用显存或计算资源的预览图
- 负面提示词，额外的文本框可填写不希望在生成图片中出现的内容
- 样式（Styles），可保存部分提示词，后续通过下拉菜单快捷应用
- 变体（Variations），可生成几乎相同但略有不同的图片
- 种子缩放，生成几乎相同但分辨率略有差异的图片
- CLIP interrogator，一键猜测图片对应的提示词
- 提示词编辑，可在生成过程中修改提示词，例如从“生成西瓜”中途切换到“生成动漫女孩”
- 批量处理，使用 img2img 处理一组文件
- Img2img 替代方案，逆欧拉交叉注意力控制法
- 高清修复（Highres Fix），一键生成高清图片且避免常见变形
- 热更新模型权重（Reloading checkpoints on the fly）
- 模型权重合并器（Checkpoint Merger），可将最多 3 个模型权重合并为一个
- [自定义脚本](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Custom-Scripts)与社区丰富扩展
- [可组合扩散（Composable-Diffusion）](https://energy-based-model.github.io/Compositional-Visual-Generation-with-Composable-Diffusion-Models/)，可同时使用多个提示词
     - 用大写 `AND` 分隔提示词
     - 支持提示词权重：`a cat :1.2 AND a dog AND a penguin :2.2`
- 提示词无 Token 数限制（原生 stable diffusion 最多 75 个 Token）
- DeepDanbooru 集成，为动漫提示词自动生成 danbooru 风格标签
- [xformers](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Xformers)，对部分显卡显著提速（启动参数加 `--xformers`）
- 通过扩展：[历史记录选项卡](https://github.com/yfszzx/stable-diffusion-webui-images-browser)：界面内便捷查看、管理、删除图片
- 无限生成选项
- 训练选项卡
     - 超网络（hypernetworks）和嵌入（embeddings）选项
     - 预处理图片：裁剪、镜像、BLIP 或 deepdanbooru（动漫用）自动打标签
- Clip skip
- 超网络（Hypernetworks）
- Loras（功能同超网络但界面更美观）
- 独立界面，可预览并选择要加入提示词的嵌入、超网络或 Lora
- 可在设置界面选择加载不同的 VAE
- 进度条显示预计完成时间
- API
- 支持 RunwayML 的专用 [局部修复模型](https://github.com/runwayml/stable-diffusion#inpainting-with-stable-diffusion)
- 通过扩展：[Aesthetic Gradients](https://github.com/AUTOMATIC1111/stable-diffusion-webui-aesthetic-gradients)，通过 clip 图片嵌入生成特定美学风格图片（实现自 [https://github.com/vicgalle/stable-diffusion-aesthetic-gradients](https://github.com/vicgalle/stable-diffusion-aesthetic-gradients)）
- 支持 [Stable Diffusion 2.0](https://github.com/Stability-AI/stablediffusion) — 参见 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#stable-diffusion-20) 获取说明
- 支持 [Alt-Diffusion](https://arxiv.org/abs/2211.06679) — 参见 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Features#alt-diffusion) 获取说明
- 现已无任何违规字母！
- 支持 safetensors 格式模型权重
- 分辨率限制放宽：生成图片尺寸需为 8 的倍数（原为 64 的倍数）
- 现已添加许可证！
- 可在设置界面自定义 UI 元素顺序
- 支持 [Segmind Stable Diffusion](https://huggingface.co/segmind/SSD-1B)

## 安装与运行
请确保满足所需 [依赖项](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Dependencies)，并根据以下平台说明操作：
- [NVidia](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)（推荐）
- [AMD](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-AMD-GPUs) 显卡
- [Intel CPU、Intel GPU（集成及独显）](https://github.com/openvinotoolkit/stable-diffusion-webui/wiki/Installation-on-Intel-Silicon)（外部 wiki 页面）
- [Ascend NPU](https://github.com/wangshuai09/stable-diffusion-webui/wiki/Install-and-run-on-Ascend-NPUs)（外部 wiki 页面）

或者，使用在线服务（如 Google Colab）：

- [在线服务列表](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Online-Services)

### Windows 10/11 + NVidia 显卡，使用发行包自动安装
1. 从 [v1.0.0-pre](https://github.com/AUTOMATIC1111/stable-diffusion-webui/releases/tag/v1.0.0-pre) 下载 `sd.webui.zip` 并解压。
2. 运行 `update.bat`。
3. 运行 `run.bat`。
> 详情请见 [Install-and-Run-on-NVidia-GPUs](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Install-and-Run-on-NVidia-GPUs)

### Windows 自动安装
1. 安装 [Python 3.10.6](https://www.python.org/downloads/release/python-3106/)（新版 Python 不支持 torch），勾选“Add Python to PATH”。
2. 安装 [git](https://git-scm.com/download/win)。
3. 下载 stable-diffusion-webui 仓库，例如运行 `git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui.git`。
4. 以普通用户身份（非管理员）在资源管理器中运行 `webui-user.bat`。

### Linux 自动安装
1. 安装依赖项：
```bash
# Debian 系：
sudo apt install wget git python3 python3-venv libgl1 libglib2.0-0
# Red Hat 系：
sudo dnf install wget git python3 gperftools-libs libglvnd-glx
# openSUSE 系：
sudo zypper install wget git python3 libtcmalloc4 libglvnd
# Arch 系：
sudo pacman -S wget git python3
```
如果你的系统较新，需要安装 python3.11 或 python3.10：
```bash
# Ubuntu 24.04
sudo add-apt-repository ppa:deadsnakes/ppa
sudo apt update
sudo apt install python3.11

# Manjaro/Arch
sudo pacman -S yay
yay -S python311 # 注意不要与 python3.11 包混淆

# 仅适用于 3.11
# 然后在启动脚本设置环境变量
export python_cmd="python3.11"
# 或在 webui-user.sh 设置
python_cmd="python3.11"
```
2. 进入你想安装 webui 的目录，执行下列命令：
```bash
wget -q https://raw.githubusercontent.com/AUTOMATIC1111/stable-diffusion-webui/master/webui.sh
```
或在任意目录克隆仓库：
```bash
git clone https://github.com/AUTOMATIC1111/stable-diffusion-webui
```

3. 运行 `webui.sh`。
4. 查看 `webui-user.sh` 获取更多选项。
### Apple Silicon 安装

请参见[此处说明](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Installation-on-Apple-Silicon)。

## 贡献
如何向本仓库贡献代码：[贡献说明](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki/Contributing)

## 文档

文档已从本 README 移至项目 [wiki](https://github.com/AUTOMATIC1111/stable-diffusion-webui/wiki)。

为了便于 Google 及其他搜索引擎抓取 wiki，提供一个（非面向人类的）[可抓取 wiki](https://github-wiki-see.page/m/AUTOMATIC1111/stable-diffusion-webui/wiki) 链接。

## 致谢
相关借用代码的许可证可在 `设置 -> 许可证` 页面以及 `html/licenses.html` 文件中查阅。

- Stable Diffusion - https://github.com/Stability-AI/stablediffusion, https://github.com/CompVis/taming-transformers, https://github.com/mcmonkey4eva/sd3-ref
- k-diffusion - https://github.com/crowsonkb/k-diffusion.git
- Spandrel - https://github.com/chaiNNer-org/spandrel 实现
  - GFPGAN - https://github.com/TencentARC/GFPGAN.git
  - CodeFormer - https://github.com/sczhou/CodeFormer
  - ESRGAN - https://github.com/xinntao/ESRGAN
  - SwinIR - https://github.com/JingyunLiang/SwinIR
  - Swin2SR - https://github.com/mv-lab/swin2sr
- LDSR - https://github.com/Hafiidz/latent-diffusion
- MiDaS - https://github.com/isl-org/MiDaS
- 优化相关思路 - https://github.com/basujindal/stable-diffusion
- Cross Attention 层优化 - Doggettx - https://github.com/Doggettx/stable-diffusion，提示词编辑的原始思路。
- Cross Attention 层优化 - InvokeAI, lstein - https://github.com/invoke-ai/InvokeAI（原始项目 http://github.com/lstein/stable-diffusion）
- 次二次方 Cross Attention 层优化 - Alex Birch (https://github.com/Birch-san/diffusers/pull/1), Amin Rezaei (https://github.com/AminRezaei0x443/memory-efficient-attention)
- 文本反演（Textual Inversion）- Rinon Gal - https://github.com/rinongal/textual_inversion（我们未使用其代码，但借鉴了其思路）
- SD 超分思路 - https://github.com/jquesnelle/txt2imghd
- Outpainting mk2 噪声生成 - https://github.com/parlance-zz/g-diffuser-bot
- CLIP interrogator 思路及部分代码 - https://github.com/pharmapsychotic/clip-interrogator
- 可组合扩散思路 - https://github.com/energy-based-model/Compositional-Visual-Generation-with-Composable-Diffusion-Models-PyTorch
- xformers - https://github.com/facebookresearch/xformers
- DeepDanbooru - 动漫 diffusers interrogator https://github.com/KichangKim/DeepDanbooru
- 以 float32 精度采样 float16 UNet - marunine 提出思路，Birch-san 提供 Diffusers 实现示例（https://github.com/Birch-san/diffusers-play/tree/92feee6）
- Instruct pix2pix - Tim Brooks (star), Aleksander Holynski (star), Alexei A. Efros (no star) - https://github.com/timothybrooks/instruct-pix2pix
- 安全建议 - RyotaK
- UniPC 采样器 - Wenliang Zhao - https://github.com/wl-zhao/UniPC
- TAESD - Ollin Boer Bohan - https://github.com/madebyollin/taesd
- LyCORIS - KohakuBlueleaf
- 重启采样 - lambertae - https://github.com/Newbeeer/diffusion_restart_sampling
- Hypertile - tfernd - https://github.com/tfernd/HyperTile
- 最初的 Gradio 脚本 - 由匿名用户在 4chan 发布。感谢这位匿名用户。
- （你）

---

[Powered By OpenAiTx](https://github.com/OpenAiTx/OpenAiTx)

---