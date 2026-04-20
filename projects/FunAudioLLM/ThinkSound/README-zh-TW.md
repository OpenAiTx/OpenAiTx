<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">簡體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>
<p align="center">
  <img src="https://img.shields.io/badge/NeurIPS%202025-Main%20Conference-blue.svg" alt="NeurIPS 2025"/>
  &nbsp;
  <a href="https://arxiv.org/pdf/2506.21448">
    <img src="https://img.shields.io/badge/arXiv-2506.21448-b31b1b.svg" alt="arXiv"/>
  </a>
  &nbsp;
  <a href="https://thinksound-project.github.io/">
    <img src="https://img.shields.io/badge/Online%20Demo-🌐-blue" alt="Online Demo"/>
  </a>
  &nbsp;
  <a href="https://huggingface.co/spaces/FunAudioLLM/ThinkSound">
    <img src="https://img.shields.io/badge/HuggingFace-Spaces-orange?logo=huggingface" alt="Hugging Face"/>
  </a>
  &nbsp;
  <a href="https://modelscope.cn/studios/iic/ThinkSound">
    <img src="https://img.shields.io/badge/ModelScope-在線體驗-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  如果您覺得這個專案有用，<br>
  歡迎在 GitHub 上給我們一顆星 ⭐！
</p>

---

## 專案目錄結構

這個 **ThinkSound** GitHub 儲存庫在不同分支上託管了兩個相關專案：

| 分支 | 專案 | 文件 |
|--------|---------|----------------|
| **`master`** | **ThinkSound** (NeurIPS 2025) — 統一的 Any2Audio 生成，結合 CoT 引導的 flow matching | 本文件：**`README.md`** |
| **`prismaudio`** | **PrismAudio** — 續作 (ICLR 2026)，以多維 CoT-RL 實現影像轉音訊 | [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 分支下的 **`README.md`** |

**ThinkSound** 請使用 **`master`** 分支（本 README）。如需 **PrismAudio**，請切換到 **`prismaudio`** 分支並參閱該分支的 **`README.md`**。

---

**ThinkSound** 是一個統一的 Any2Audio 生成框架，採用 Chain-of-Thought (CoT) 推理引導的 flow matching。

PyTorch 實現的多模態音訊生成與編輯：可從影像、文字、音訊生成或編輯音訊，並由多模態大型語言模型（MLLMs）逐步推理驅動。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 最新消息
- **2026.03.24** &nbsp; 🔥 **PrismAudio** 已於本倉庫 [`prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 分支釋出 — 請參閱該分支 **`README.md`** 以瞭解安裝與模型。
- **2026.01.26** &nbsp; 🎉 PrismAudio 入選 **ICLR 2026 主會議**（程式碼及文件於 `prismaudio` 分支）。
- **2025.11.25** &nbsp; 🔥 [PrismAudio 線上展示](http://prismaudio-project.github.io/) 已上線。
- **2025.11.25** &nbsp; 🔥 [PrismAudio 論文](https://arxiv.org/pdf/2511.18833) 發佈於 arXiv — 以多維 CoT-RL 實現影像轉音訊。
- **2025.09.19** &nbsp; 🎉 **ThinkSound** 入選 **NeurIPS 2025 主會議**！
- **2025.09.01** &nbsp; 我們的 AudioCoT 數據集現已開源，歡迎於 [Hugging Face](https://huggingface.co/datasets/liuhuadai/AudioCoT) 下載！
- **2025.07.17** &nbsp; 🧠 支援微調：訓練及微調程式碼公開，並附有清楚使用說明，助您以自有資料自訂與擴充 ThinkSound。
- **2025.07.15** &nbsp; 📦 安裝與使用流程簡化：依賴包已上架 PyPI，輕鬆跨平台安裝；Windows `.bat` 腳本自動建立環境並執行腳本。
- **2025.07.08** &nbsp;  🔧 重大更新：模型輕量化，並優化記憶體與 GPU 使用，支援大規模高吞吐量音訊生成！
- **2025.07.01** &nbsp; 線上展示於 [Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 及 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound)，可互動體驗！
- **2025.07.01** &nbsp; 已釋出推論腳本及網頁介面；
- **2025.06** &nbsp; [ThinkSound 論文](https://arxiv.org/pdf/2506.21448) 發佈於 arXiv！
- **2025.06** &nbsp; [線上展示](http://thinksound-project.github.io/) 上線 — 歡迎立即體驗！

---


<div align="center">

### 續作：PrismAudio（同倉庫，`prismaudio` 分支）
**PrismAudio** 是 ThinkSound（ICLR 2026）的後繼版本，以新名稱開發，但仍保存在此存儲庫的 **`prismaudio`** 分支。安裝、檢查點和引用資訊請參見該分支下的 **[`README.md`](https://github.com/liuhuadai/ThinkSound/blob/prismaudio/README.md)**。

👉 [`git checkout prismaudio`](https://github.com/liuhuadai/ThinkSound/tree/prismaudio) 或在 GitHub 上開啟該分支。

</div>

---


## 🚀 功能特點

- **Any2Audio**：從任意模態（影片、文字、音訊或其組合）生成音訊。
- **Video-to-Audio SOTA**：在多個 V2A 基準上達到最先進成果。
- **CoT 驅動推理**：透過 MLLM 進行 Chain-of-Thought 推理，實現組合性與可控的音訊生成。
- **互動式物件導向編輯**：透過點擊視覺物件或文字指令，精細編輯特定聲音事件。
- **統一框架**：一個基礎模型支援生成、編輯與互動式工作流程。

---

## ✨ 方法概述

ThinkSound 將音訊生成與編輯分解為三個互動階段，全部由基於 MLLM 的 Chain-of-Thought（CoT）推理引導：

1. **Foley 生成：** 從影片生成語義與時間一致的基礎聲景。
2. **物件導向精細化：** 透過點擊或影片中的區域，為指定物件精細化或添加聲音。
3. **目標音訊編輯：** 使用高階自然語言指令修改生成的音訊。

![ThinkSound 概述](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模 CoT 註釋資料集（**AudioCoT**）用於訓練推理模組與統一音訊基礎模型。
![AudioCoT 流程](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速開始

**環境準備：**

```bash
# ThinkSound code: branch master. PrismAudio: clone with -b prismaudio (see README.md on that branch).
git clone -b master https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
conda create -n thinksound python=3.10
conda activate thinksound
pip install thinksound
conda install -y -c conda-forge 'ffmpeg<7'
# Download pretrained weights https://huggingface.co/liuhuadai/ThinkSound to Directory ckpts/
# model weights can be also downloaded from https://www.modelscope.cn/models/iic/ThinkSound
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
# To improve inference and training speed, you may optionally install a FlashAttention backend compatible with your system and PyTorch version.
```
> ✅ **Windows 提示：**  
> Windows 使用者只需執行 `setup_windows.bat`（或雙擊它）即可自動建立 conda 環境、安裝所有依賴（包括 FFmpeg），並下載預訓練模型——無需手動設置。  
> 在執行腳本前，請確保 `conda` 和 `git` 已經安裝並且可在系統 PATH 中使用。


### ▶️ 執行示範

#### **Linux/macOS**


```bash
chmod +x scripts/demo.sh
./scripts/demo.sh <path-to-your-demo-video> <title> <CoT description> [use-half]
```
#### **Windows**

您也可以改用提供的 `.bat` 腳本：


```bash
.\scripts\demo.bat <path-to-your-demo-video> <title> <CoT description> [use-half]
```
**注意：**

* `<path-to-your-demo-video>`：單一影片的路徑
* `[use-half]`（可選）：在結尾加上 use-half 以啟用半精度特徵提取。

---

### 📦 批次推論

#### **Linux/macOS**


```bash
chmod +x scripts/eval_batch.sh
./scripts/eval_batch.sh <video_path> <csv_path> <save_path (optional)> [use-half]
```
#### **Windows**

請使用等效的 `.bat` 腳本：


```bash
.\scripts\eval_batch.bat <video_path> <csv_path> <save_path (optional)> [use-half]
```
**注意：**

* `<video_path>`：包含所有待處理 .mp4 影片的根目錄路徑（所有影片必須長度相同）。
* `<csv_path>`：每個影片的文字提示 CSV 檔案（格式請參考 `demo_test.csv`）。
* `<save_path>`（可選）：產生的音訊儲存位置。預設為 `results/features`。
* `[use-half]`（可選）：最後加上 use-half，可啟用半精度特徵擷取。

---

### 網頁介面使用方式

若需互動式操作，可啟動 Gradio 網頁介面：



```bash
python app.py
```
## 🏋️ 訓練模型

請參閱 [`Training.md`](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/docs/Training.md)


---


## 📄 授權條款

本專案依照 Apache 2.0 授權條款釋出。

> **注意：**
> 程式碼、模型與資料集**僅供學術研究與教育用途**。
> **禁止商業用途。**
> 若需商業授權，請聯絡作者。

**📦 第三方元件**

* **Stable Audio Open VAE**（由 Stability AI 提供）：
  本倉庫包含經微調的 VAE，來自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/)，並依據 [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 授權。
  **商業使用與再發佈需事先取得 Stability AI 的許可。**

* 📘 **其他所有程式碼與模型**均依據 Apache License 2.0 授權釋出。

---

## 鳴謝

特別感謝：

* **stable-audio-tools**（由 Stability AI 提供）：
感謝其提供易於使用的音訊生成框架，以及 VAE 模組與權重。
* **MMAudio**：
  感謝其在音訊領域實現 MM-DiT 主幹模型。

---



## 📖 引用

如果您在研究或工作中發現我們的專案有用，請引用我們的論文：

```bibtex
@misc{liu2025thinksoundchainofthoughtreasoningmultimodal,
      title={ThinkSound: Chain-of-Thought Reasoning in Multimodal Large Language Models for Audio Generation and Editing}, 
      author={Huadai Liu and Jialei Wang and Kaicheng Luo and Wen Wang and Qian Chen and Zhou Zhao and Wei Xue},
      year={2025},
      eprint={2506.21448},
      archivePrefix={arXiv},
      primaryClass={eess.AS},
      url={https://arxiv.org/abs/2506.21448}, 
}
@misc{liu2025prismaudiodecomposedchainofthoughtsmultidimensional,
          title={PrismAudio: Decomposed Chain-of-Thoughts and Multi-dimensional Rewards for Video-to-Audio Generation}, 
          author={Huadai Liu and Kaicheng Luo and Wen Wang and Qian Chen and Peiwen Sun and Rongjie Huang and Xiangang Li and Jieping Ye and Wei Xue},
          year={2025},
          eprint={2511.18833},
          archivePrefix={arXiv},
          primaryClass={cs.SD},
          url={https://arxiv.org/abs/2511.18833}, 
    }
```

---

## 📬 Contact


✨ Feel free to [open an issue](https://github.com/liuhuadai/ThinkSound/issues) or contact us via email ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) if you have any questions or suggestions!





---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-04-20

---