<h1 align="center">ThinkSound</h1>

<p align="center">
  🌐
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=en">English</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-CN">简体中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=zh-TW">繁體中文</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=es">Español</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=fr">Français</a> |
  <a href="https://openaitx.github.io/view.html?user=FunAudioLLM&project=ThinkSound&lang=ja">日本語</a>
  
</p>

<p align="center">
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
    <img src="https://img.shields.io/badge/ModelScope-在线体验-green" alt="ModelScope"/>
  </a>
</p>

<p align="center">
  如果您覺得這個專案有幫助，<br>
  歡迎在 GitHub 上點個星星 ⭐ 支持我們！
</p>

---

**ThinkSound** 是一個統一的 Any2Audio 生成框架，結合了 Chain-of-Thought（CoT）推理引導的流匹配技術。

基於 PyTorch 的多模態音頻生成與編輯工具：可從影像、文字與音頻產生或編輯聲音，並由多模態大型語言模型（MLLMs）提供逐步推理支持。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 最新消息
- **2025.07.17** &nbsp; 🧠 開放微調功能：現已公開訓練與微調程式碼，並附有詳細操作說明，幫助您以自己的資料自訂與擴充 ThinkSound。
- **2025.07.15** &nbsp; 📦 安裝與使用更加簡易：PyPI 依賴輕鬆跨平台安裝；Windows `.bat` 腳本自動建立環境與運行腳本。
- **2025.07.08** &nbsp;  🔧 重大更新：模型更輕量、記憶體與 GPU 使用優化，現支援大規模高吞吐音頻生成！
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 與 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 上線互動式線上演示！
- **2025.07.01** &nbsp; 🔥釋出推理腳本與網頁介面；
- **2025.06** &nbsp; 🔥[ThinkSound 論文](https://arxiv.org/pdf/2506.21448) 已發佈於 arXiv！
- **2025.06** &nbsp; 🔥[線上演示](http://thinksound-project.github.io/) 已上線 - 歡迎體驗！

---


## 🚀 特色

- **Any2Audio**：支援從任意模態（影像、文字、音頻或其組合）生成音頻。
- **Video-to-Audio SOTA**：於多項 V2A 基準數據集達到最新技術水準。
- **CoT 推理驅動**：基於 MLLM 的 Chain-of-Thought 推理實現可組合、可控的音頻生成。
- **互動式物件導向編輯**：可點擊影像物件或使用文字指令來細緻編輯特定聲音事件。
- **統一框架**：一個基礎模型同時支援生成、編輯與互動式工作流。

---

## ✨ 方法概述

ThinkSound 將音頻生成與編輯分為三個互動階段，全部由 MLLM 驅動的 Chain-of-Thought（CoT）推理引導：

1. **Foley 生成：** 從影片中生成語意與時間對齊的基礎聲景。
2. **物件導向細化：** 透過在影片中點擊物件或區域，細化或新增使用者指定物件的聲音。
3. **目標音頻編輯：** 利用高階自然語言指令修改已生成的音頻。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模 CoT 標註資料集（**AudioCoT**）同時用於訓練推理模組與統一音頻基礎模型。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速開始

**環境準備：**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
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

## 📝 TODO 與未來計畫
* - [ ] 開源 AudioCoT 數據集與自動化流程（預計於 2025 年 7 月 23 日前）
* - [ ] 發布涵蓋多領域、更強大的基礎模型，以帶來更具吸引力與沉浸感的擬音創作（預計於 2025 年 8 月底前）
* - [ ] 增加對更多模態與下游任務的支援（預計於 2025 年 7 月底前）
* - [ ] 發布不同規模的模型（預計於 2025 年 7 月底前）
* - [x] 釋出 ThinkSound 模型訓練腳本
* - [x] 新手友好的 Windows 快速入門 README
---

## 📄 授權條款

本專案以 Apache 2.0 授權條款釋出。

> **注意：**
> 程式碼、模型及數據集**僅供研究與教育用途**。
> **禁止商業用途。**
> 如需商業授權，請聯繫作者。

**📦 第三方組件**

* **Stable Audio Open VAE**（由 Stability AI 提供）：
  本儲存庫包含自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) 微調之 VAE，授權依據 [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md)。
  **商業用途與再發佈需事先取得 Stability AI 許可。**

* 📘 **所有其他程式碼與模型**皆以 Apache License 2.0 釋出。

---

## 致謝

特別感謝：

* **stable-audio-tools**（由 Stability AI 提供）：
提供易於使用的音訊生成框架，以及 VAE 模組與權重。
* **MMAudio**：
  在音訊領域實現 MM-DiT 主幹架構。

---

## 📖 引用

若您在研究或工作中覺得 ThinkSound 有幫助，請引用本論文：




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
```
---

## 📬 聯絡我們

✨ 如果您有任何問題或建議，歡迎[提交議題](https://github.com/liuhuadai/ThinkSound/issues)或通過電子郵件聯繫我們（[liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)）！


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-17

---