# EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh

<div align="center">

<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/Logo.png" alt="EX-4D Logo" width="250">

[📄 論文](https://arxiv.org/abs/2506.05554)  |  [🎥 首頁](https://tau-yihouxiang.github.io/projects/EX-4D/EX-4D.html)  |  [💻 原始碼](https://github.com/tau-yihouxiang/EX-4D)

</div>



## 🌟 亮點

- **🎯 極端視角合成**：生成高品質4D影片，支援攝影機從 -90° 到 90° 的運動
- **🔧 深度密封網格**：新穎的幾何表徵，同時建模可見與遮擋區域
- **⚡ 輕量級架構**：僅有14B影片擴散主幹網路1%（140M）的可訓練參數
- **🎭 無需多視角訓練**：創新遮罩策略，省去昂貴的多視角數據集
- **🏆 最先進的效能**：在極端攝影機角度下，表現優於現有方法

## 🎬 展示結果

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/teaser.png" alt="EX-4D Demo Results" width="800">
</div>

*EX-4D 能將單眼影片轉換為可控攝影機的4D體驗，在極端視角下仍保持物理一致性的效果。*

## 🏗️ 系統框架概述

<div align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/docs/overview.png" alt="EX-4D Architecture">
</div>

我們的框架包含三個關鍵組件：

1. **🔺 深度密封網格構建**：建立強健的幾何先驗，明確建模可見與遮擋區域
2. **🎭 模擬遮罩策略**：從單眼影片生成有效訓練數據，無需多視角數據集
3. **⚙️ 輕量化LoRA適配器**：高效整合幾何資訊與預訓練影片擴散模型

## 🚀 快速上手

### 安裝

```bash
# 複製倉庫
git clone https://github.com/tau-yihouxiang/EX-4D.git
cd EX-4D

# 建立conda環境
conda create -n ex4d python=3.10
conda activate ex4d
# 安裝PyTorch（建議2.x）
pip install torch==2.4.1 torchvision==0.19.1 torchaudio==2.4.1 --index-url https://download.pytorch.org/whl/cu124
# 安裝Nvdiffrast
pip install git+https://github.com/NVlabs/nvdiffrast.git
# 安裝依賴與diffsynth
pip install -e .
# 安裝depthcrafter以進行深度估計（依照DepthCrafter說明準備checkpoint）
git clone https://github.com/Tencent/DepthCrafter.git
```

### 下載預訓練模型
```bash
huggingface-cli download Wan-AI/Wan2.1-I2V-14B-480P --local-dir ./models/Wan-AI
huggingface-cli download yihouxiang/EX-4D --local-dir ./models/EX-4D
```

### 範例使用方式
#### 1. DW-Mesh 重建
```bash
# --cam 180 (30 / 60 / 90 / zoom_in / zoom_out )
python recon.py --input_video examples/flower/input.mp4 --cam 180 --output_dir outputs/flower --save_mesh
```
#### 2. EX-4D 生成（需48GB顯存）
```bash
python generate.py --color_video outputs/flower/color_180.mp4 --mask_video outputs/flower/mask_180.mp4 --output_video outputs/flower/output.mp4
```

<table>
<tr>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/input.gif" width="100%">
<br><b>輸入影片</b>
</td>
<td align="center">
<div style="font-size: 2em; color: #4A90E2; padding: 0 0px;">
  ➜
</div>
</td>
<td width="45%" align="center">
<img src="https://raw.githubusercontent.com/tau-yihouxiang/EX-4D/main/examples/flower/output.gif" width="100%">
<br><b>輸出影片</b>
</td>
</tr> 
</table>

<!-- ## 📊 效能

### 定量結果
| 方法 | FID (極端) ↓ | FVD (極端) ↓ | VBench 分數 ↑ |
|--------|-----------------|-----------------|----------------|
| ReCamMaster | 64.68 | 943.45 | 0.434 |
| TrajectoryCrafter | 65.33 | 893.80 | 0.447 |
| TrajectoryAttention | 62.49 | 912.14 | 0.389 |
| **EX-4D (本論文)** | **55.42** | **823.61** | **0.450** | -->

### 使用者研究結果

- **70.7%** 的參與者更偏好 EX-4D 相較於基線方法
- 在物理一致性及極端視角品質上表現更優異
- 隨著鏡頭角度越極端，改善幅度更顯著


## 🎯 應用場景

- **🎮 遊戲**：從 2D 影像創建沉浸式 3D 遊戲動畫
- **🎬 電影製作**：為後期製作生成新穎的鏡頭角度
- **🥽 VR/AR**：創建自由視角的影像體驗
- **📱 社群媒體**：為內容創作生成動態鏡頭運動
- **🏢 建築**：從多個視角可視化空間

<!-- ## 📈 基準測試 -->

<!-- ### 視角範圍評估

| 範圍 | 小 (0°→30°) | 大 (0°→60°) | 極端 (0°→90°) | 全域 (-90°→90°) |
|-------|----------------|----------------|------------------|-----------------|
| FID 分數 | 44.19 | 50.30 | 55.42 | - |
| 性能差距 | +9.1% 更佳 | +8.9% 更佳 | +11.3% 更佳 | +15.5% 更佳 | -->

<!-- *性能差距為相較於每一類別中第二佳方法的提升幅度。* -->

## ⚠️ 限制

- **深度依賴**：性能依賴於單目深度估計的品質
- **計算成本**：高解析度影片需大量運算
- **反光表面**：對反射或透明材質仍具挑戰

## 🔮 未來工作
- [ ] 實時推理優化（3DGS / 4DGS）
- [ ] 支援更高解析度（1K、2K）
- [ ] 神經網格細化技術

## 🙏 致謝

感謝 [DiffSynth-Studio v1.1.1](https://github.com/modelscope/DiffSynth-Studio/tree/v1.1.1) 專案提供基礎的擴散框架。

## 📚 參考文獻

如果您覺得本研究有幫助，請考慮引用：

```bibtex
@misc{hu2025ex4dextremeviewpoint4d,
      title={EX-4D: EXtreme Viewpoint 4D Video Synthesis via Depth Watertight Mesh}, 
      author={Tao Hu and Haoyang Peng and Xiao Liu and Yuewen Ma},
      year={2025},
      eprint={2506.05554},
      archivePrefix={arXiv},
      primaryClass={cs.CV},
      url={https://arxiv.org/abs/2506.05554}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---