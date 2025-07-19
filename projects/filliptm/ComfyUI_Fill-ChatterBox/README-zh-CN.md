<translate-content># ComfyUI_Fill-ChatterBox

如果您喜欢这个项目，考虑在 Patreon 上支持我！
<p align="left">
  <a href="https://www.patreon.com/c/Machinedelusions">
    <img src="https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/assets/Patreon.png" width="150px" alt="Patreon">
  </a>
</p>

这是一个为 ComfyUI 定制的节点扩展，使用 Chatterbox 库添加文本转语音（TTS）和语音转换（VC）功能。
支持最长 40 秒。我尝试过取消这个限制，但模型在超过该时长时表现非常糟糕，所以限制依旧存在。

![ChatterBox 示例](https://raw.githubusercontent.com/filliptm/ComfyUI_Fill-ChatterBox/main/web/image.png)

## 安装

1. 将本仓库克隆到您的 ComfyUI custom_nodes 目录：
   ```bash
   cd /path/to/ComfyUI/custom_nodes
   git clone https://github.com/filliptm/ComfyUI_Fill-ChatterBox.git
   ```
2. 安装基础依赖项：

   ```bash
   pip install -r ComfyUI_Fill-ChatterBox/requirements.txt
   ```
3.（可选）安装水印支持：

   ```bash
   pip install resemble-perth
   ```
<translate-content>   **注意**：`resemble-perth` 包可能与 Python 3.12+ 存在兼容性问题。若遇到导入错误，节点仍可正常工作，但不带水印。


## 使用说明

### 文本转语音节点（FL Chatterbox TTS）
- 将“FL Chatterbox TTS”节点添加到工作流中
- 配置文本输入和参数（夸张度、cfg_weight、温度）
- 可选提供音频提示以进行语音克隆

### 语音转换节点（FL Chatterbox VC）
- 将“FL Chatterbox VC”节点添加到工作流中
- 连接输入音频和目标语音
- 两个节点均支持在发生 CUDA 错误时回退到 CPU

## 更新日志

### 2025年6月24日
- 为 TTS 和 VC 节点添加了种子参数以实现可复现生成
- 种子范围：0 到 4,294,967,295（32位整数）
- 支持调试和工作流控制时生成一致的音频输出
- 将 Perth 水印设为可选，修复了 Python 3.12+ 兼容性问题
- 若 resemble-perth 导入失败，节点将无水印运行

### 2025年5月31日
- 添加了持久化模型加载和加载条功能
- 添加了 Mac 支持（需测试，欢迎联系）
- 移除了 chatterbox-tts 库，改用原生推理代码实现。
</translate-content>


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-19

---