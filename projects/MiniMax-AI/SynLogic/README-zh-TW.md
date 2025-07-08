<div align="center">
  <picture>
    <source srcset="assets/minimax-logo.png" media="(prefers-color-scheme: dark)">
      <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/minimax-logo.png" width="60%" alt="MiniMax">
    </source>
  </picture>
</div>
<hr>

<div align="center" style="line-height: 1;">
<a href="https://arxiv.org/abs/2505.19641" target="_blank" style="margin: 2px;">
  <img alt="Paper" src="https://img.shields.io/badge/📖_Paper-Arxiv-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/datasets/MiniMaxAI/SynLogic" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Data-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
<a href="https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032" target="_blank" style="margin: 2px;">
  <img alt="Hugging Face" src="https://img.shields.io/badge/🤗_HF-Model-327DE6?style=flat-square&labelColor=2C3E50" style="display: inline-block; vertical-align: middle;"/>
</a>
</div>

<hr>

# SynLogic

本儲存庫包含 SynLogic 的代碼和數據，SynLogic 是一個全面的邏輯推理數據合成框架，可大規模生成多樣且可驗證的推理數據。我們的工作旨在解決用於開發大型語言模型（LLMs）通用推理能力時，高品質邏輯推理訓練數據短缺的關鍵問題。

<p align="center">
  <img src="https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/assets/main.jpg" alt="Laser main figure">
</p> 

## 最新消息
- **[2025/07/07]** :fire: 我們提供使用 SynLogic 數據配合 Verl 框架進行 RL 訓練的指導。詳情請見 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md)。

- **[2025/06/03]** :fire: 訓練模型已在 Hugging Face 上釋出：  
→ [MiniMaxAI/SynLogic Collection](https://huggingface.co/collections/MiniMaxAI/synlogic-6836c3246fca0277657ff032)  

- **[2025/05]** :fire: 我們很高興釋出論文 "SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond" 的相關資源

## 📋 概述

**SynLogic** 是一個數據合成框架及完整數據集，具備以下特點：
- 📊 **涵蓋 35 種多樣化邏輯推理任務**，包括數獨、24 點遊戲、密碼、箭頭迷宮等
- 🎯 **支持可控難度合成**，每個任務均可調整參數
- ✅ **提供可驗證獎勵**，通過基於規則的驗證適用於 RL 訓練
- 🚀 **實現開源數據集 SOTA 性能**，在 BBEH 上超越 DeepSeek-R1-Distill-Qwen-32B 6 分

### 主要特點
- **可擴展數據生成**：無限合成並可控制難度等級
- **全面任務覆蓋**：35 種獨特的邏輯推理任務，配備專屬生成器和驗證器
- **RL 友好**：所有示例均可通過簡單規則驗證，非常適合強化學習
- **跨領域遷移**：對數學和程式領域具有強泛化能力

## 🚀 快速開始

### 安裝
```bash
git clone https://github.com/MiniMax-AI/SynLogic.git
cd SynLogic
pip install -r requirements.txt
```

### 生成樣本數據（以箭頭迷宮為例）
```bash
# 使用箭頭迷宮的快速範例
bash games/tasks/arrow_maze/run.sh

# 或自定義參數
python scripts/arrow_maze.py \
  --num_of_data 1000 \
  --width 5 \
  --height 5 \
  --arrow_fill_rate_min 0.3 \
  --arrow_fill_rate_max 0.9
```

### 用於 RL 訓練

我們提供了如何在強化學習訓練中使用 SynLogic 數據的完整指導。請參考 [docs/training_guidance.md](https://raw.githubusercontent.com/MiniMax-AI/SynLogic/main/docs/training_guidance.md) 以了解與 Verl 框架集成的詳細說明。

## :rocket: 資源

### 數據集
| 數據集名稱 | 說明 | 連結 |
|:------------:|:------------|:----:|
| **SynLogic** | 數據集 | [🤗 HuggingFace](https://huggingface.co/datasets/MiniMaxAI/SynLogic) |



### 模型


| 模型名稱 | 說明 | 連結 |
|:-----------|:------------|:----:|
| **SynLogic-7B** | 基於 SynLogic 訓練的 7B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-7B) |
| **SynLogic-32B** | 基於 SynLogic 訓練的 32B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-32B) |
| **SynLogic-Mix-3-32B** | 基於混合 SynLogic、數學、程式數據訓練的 32B 模型 | [🤗 HuggingFace](https://huggingface.co/MiniMaxAI/SynLogic-Mix-3-32B) |

## 🔄 未來更新

我們正積極擴展 SynLogic，加入更多邏輯推理任務。

請關注我們的代碼庫以獲取最新動態與發佈！

## 引用
如果您覺得我們的工作對您有幫助，請引用我們的論文：

```bibtex
@misc{liu2025synlogic,
      title={SynLogic: Synthesizing Verifiable Reasoning Data at Scale for Learning Logical Reasoning and Beyond}, 
      author={Junteng Liu and Yuanxiang Fan and Zhuo Jiang and Han Ding and Yongyi Hu and Chi Zhang and Yiqi Shi and Shitong Weng and Aili Chen and Shiqi Chen and Yunan Huang and Mozhi Zhang and Pengyu Zhao and Junjie Yan and Junxian He},
      year={2025},
      eprint={2505.19641},
      archivePrefix={arXiv},
      primaryClass={cs.AI},
      url={https://arxiv.org/abs/2505.19641}, 
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-08

---