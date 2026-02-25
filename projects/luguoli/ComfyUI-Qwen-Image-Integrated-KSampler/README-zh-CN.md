# 🐋 Qwen 图像集成 KSampler

[![GitHub](https://img.shields.io/badge/GitHub-luguoli-orange)](https://github.com/luguoli)
[![ComfyUI](https://img.shields.io/badge/ComfyUI-CustomNode-blue)](https://github.com/comfyanonymous/ComfyUI)

[English](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-en.md) | **[简体中文](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/README-zh.md)**

QwenImageIntegratedKSampler

这是一个集成的 ComfyUI Qwen-Image 图像生成采样节点，支持 Z-Image。相比官方 KSampler，消除了繁杂的连线，支持文本到图像和图像到图像生成，解决了官方节点的偏移问题，集成了提示词输入框、自动图像缩放、自动内存/显存清理、批量生成、自动保存等多项综合优化功能，妈妈再也不用担心我乱接线了~~~~

#### 如果本项目对你有帮助，请给它一个 ⭐Star — 这让我知道有人在使用它！

## 🏆 功能特点

### 🎨 支持的生成模式
- **Z-Image**：支持 Z-Image 模型
- **文本到图像**：根据文本提示生成图像
- **图像到图像**：基于参考图像生成，图像编辑，支持最多5张图像

### ⚡ 高级优化
- **优化偏移问题**：解决官方节点偏移问题，更好地遵循指令
- **集成采样算法（AuraFlow）**：集成采样算法（AuraFlow）节点，无需额外连线
- **集成 CFGNorm**：集成 CFGNorm 节点，无需额外连线

### 🖼️ 图像处理
- **集成提示词输入框**：集成提示词输入框，无需额外连线
- **多参考图像支持**：支持最多5张参考图像进行条件生成
- **自动图像缩放**：保持宽高比的同时缩放到目标尺寸

- **支持 ControlNet 控制**：额外连接到 [🐋 Qwen ControlNet 集成加载器] 以控制姿势、深度等

### 🔧 生产力提升
- **批量生成**：一次操作生成多张图像
- **自动显存清理**：自动清理 GPU/显存内存选项
- **自动内存清理**：自动清理 RAM 内存选项
- **自动保存结果**：自动将生成结果图像保存到指定文件夹
- **完成音效提醒**：生成完成后播放音频提醒

## 🍧 对比展示
### 🔄 工作流程复杂度比较
- **❌ 未使用 [Qwen Image Integrated KSampler] 的工作流程（复杂，节点过多，连线过多）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-1-en.png)
- **✅ 使用 [Qwen Image Integrated KSampler] 的工作流程（极其简单，单节点完成，几乎无连线）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/1-2-en.png)

### 🖼️ 生成图像效果比较
- **❌ 未使用 [Qwen Image Integrated KSampler] 的工作流程（明显偏移，缩放）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-1.png)
- **✅ 使用 [Qwen Image Integrated KSampler] 的工作流程（完全无偏移，缩放）**
![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/2-2.png)

## 📦 安装方法

### 方法一：通过 ComfyUI Manager（推荐）
1. 在 ComfyUI 界面打开 ComfyUI Manager
2. 搜索 “ComfyUI-Qwen-Image-Integrated-KSampler”
3. 点击安装

### 方法二：手动安装
1. 进入你的 ComfyUI 自定义节点目录：
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   ```

2. 克隆仓库：
   ```bash
   git clone https://github.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   or gitee repository:
   git clone https://gitee.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler.git
   ```

3. 安装依赖项：
   ```bash
   pip install -r requirements.txt
   ```
4. 重启 ComfyUI

## 🚀 使用方法

### [工作流示例](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/workflow_example.json)

### 基本文本到图像生成

1. 将“🐋 Qwen 图像集成 KSampler”节点添加到工作流中
2. 将 `generation_mode` 设置为“text-to-image”
3. 连接所需输入：
   - 模型 (🤖 Model)
   - CLIP (🟡 Clip)
   - VAE (🎨 Vae)
4. 输入正向和负向提示词
5. 设置宽度和高度（文本到图像必需）
6. 配置采样参数（步数，CFG，采样器，调度器）
7. 执行工作流

### 图像到图像生成

1. 将节点添加到工作流中
2. 将 `generation_mode` 设置为“image-to-image”
3. 连接至少一张参考图像（🖼️ Image1）
4. 可选添加最多 4 张其他参考图像
5. 输入正向/负向提示词和说明
6. 设置目标宽度/高度进行缩放（可选）
7. 根据需要配置其他参数
8. 执行工作流

### ControlNet 控制

1. 添加 [🐋 Qwen ControlNet 集成加载器] 节点，连接到 [📦 ControlNet 数据]

2. 连接姿态、深度控制图像

3. 选择 ControlNet 模型，设置控制类型和强度

4. 执行工作流

![alt text](https://raw.githubusercontent.com/luguoli/ComfyUI-Qwen-Image-Integrated-KSampler/main/images/3-en.png)

### 高级功能

- **内存管理**：启用 GPU/CPU 清理选项以提升资源效率
- **批处理**：将 batch_size 设置为大于1以生成多张图像
- **自动保存**：指定输出文件夹以实现自动保存
- **AuraFlow 调节**：调整 auraflow_shift 以平衡速度与质量
- **CFG 增强**：CFG 稳定器

## ⚠️ 注意事项

### 📝 使用要求
- **文本生成图像模式**：必须设置宽度（Width）和高度（Height），这是必填参数
- **图像生成图像模式**：必须至少提供一张参考图像（Image1），最多支持5张参考图像（Image1-Image5）

### 🎛️ 参数设置建议
- **批量大小**：选择 1-10，根据 GPU 内存调整，建议从1开始测试
- **分辨率（宽度/高度）**：必须是8的倍数，范围0-16384，建议从较低分辨率（如512x512）开始测试
- **采样步数**：Qwen模型推荐4-20步，过高可能增加计算时间但不一定提升质量
- **CFG值**：范围0-100，默认1.0，建议在1.0-7.0范围内
- **去噪强度**：范围0-1，默认1.0，图像生成图像模式下可适当降低
- **AuraFlow Shift**：范围0-100，默认3.0，用于平衡生成速度和质量
- **CFG归一化强度**：范围0-100，默认1.0，CFG的稳定器

### 🔧 图像处理
- **自动缩放**：文本生成图像必须输入宽度和高度参数，图像生成图像时自动缩放参考图像并保持长宽比，设置宽度或高度为0则禁用缩放
- **参考图像顺序**：支持最多5张参考图像，按顺序处理 Image1-Image5，Image1为主图像
- **图像格式**：支持标准图像输入格式，自动处理批量维度

### 💾 内存管理
- **GPU内存清理**：启用 enable_clean_gpu_memory 选项，自动在生成前后清理显存
- **CPU内存清理**：启用 enable_clean_cpu_memory_after_finish，生成完成后清理内存（包括文件缓存、进程、动态库）
- 对于持续的大规模生成，建议始终开启内存清理选项以防止内存溢出

### 💾 自动保存
- **输出文件夹**：设置 auto_save_output_folder 启用自动保存功能，留空则禁用，支持绝对路径和相对路径
- **文件命名**：output_filename_prefix 自定义前缀，默认“auto_save”
- 保存格式为 PNG，文件名包含种子和批次号（如：auto_save_123456_00000.png）


### 🔊 通知功能
- **声音通知**：仅支持Windows系统

## 📝 更新记录
### v1.0.6:
- **新增本地化脚本：** 从ComfyUI v0.3.68开始，中文语言文件失效。新增自动汉化脚本，双击[自动汉化节点.bat]并重启ComfyUI，需安装ComfyUI-DD-Translation插件


## 📞 特殊定制联系方式 📞
- 作者：@luguoli（墙上的向日葵）
- 作者邮箱：luguoli@vip.qq.com


---

**为ComfyUI社区倾心制作 ❤️**


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-02-25

---