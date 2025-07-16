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
  如果您覺得本專案有用，<br>
  歡迎在 GitHub 上給我們一顆星⭐！
</p>

---

**ThinkSound** 是一個統一的 Any2Audio 生成框架，通過 Chain-of-Thought (CoT) 推理進行流匹配指導。

基於 PyTorch 的多模態音頻生成與編輯實現：可從影片、文本與音頻生成或編輯音頻，並由多模態大型語言模型（MLLMs）逐步推理驅動。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 新聞動態
- **2025.07.15** &nbsp; 📦 安裝及易用性簡化：依賴庫已上傳至 PyPI，跨平台一鍵安裝；Windows `.bat` 腳本自動創建環境並執行腳本。
- **2025.07.08** &nbsp;  🔧 重大升級：模型輕量化並優化記憶體及 GPU 使用，現已支援大規模高吞吐音頻生成！
- **2025.07.01** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 與 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 在線體驗正式上線！
- **2025.07.01** &nbsp; 🔥推理腳本與網頁介面已釋出；
- **2025.06** &nbsp; 🔥[ThinkSound 論文](https://arxiv.org/pdf/2506.21448) 已發佈於 arXiv！
- **2025.06** &nbsp; 🔥[線上展示](http://thinksound-project.github.io/) 正式上線 - 歡迎體驗！

---


## 🚀 主要特色

- **Any2Audio**：支援從任意模態生成音頻——影片、文本、音頻或其組合。
- **影片轉音頻 SOTA**：在多個 V2A 基準數據集達到最先進效果。
- **CoT 推理驅動**：藉由 MLLMs 實現可組合、可控音頻生成的 Chain-of-Thought 推理。
- **互動式物件導向編輯**：可通過點擊視覺物件或文本指令，細緻編輯或優化特定聲音事件。
- **統一框架**：一個基礎模型同時支援生成、編輯與互動式工作流。

---

## ✨ 方法總覽

ThinkSound 將音頻生成與編輯拆分為三個互動階段，並全部由基於 MLLM 的 Chain-of-Thought (CoT) 推理引導：

1. **Foley 生成：** 從影片生成語義及時間對齊的基礎聲音場景。
2. **物件導向細化：** 針對用戶指定影片中的物件（點擊或區域），細化或新增聲音效果。
3. **目標音頻編輯：** 利用高階自然語言指令修改已生成音頻。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 大規模 CoT 標註數據集（**AudioCoT**）同時用於訓練推理模組與統一音頻基礎模型。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速上手

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
---

## 📝 TODO 與未來計劃
* - [ ] 發布 ThinkSound 模型的訓練腳本（預計 2025/07/20 前）
* - [ ] 開源 AudioCoT 數據集與自動化流程（預計 2025/07/23 前）
* - [ ] 提供可直接使用的環境映像檔（預計 2025/07/23 前）
* - [ ] 發布更強大的基礎模型，涵蓋多個領域，以提供更具吸引力與沉浸感的擬音創作（預計 2025 年 8 月底前）
* - [ ] 新增對其他模態與下游任務的支援（預計 2025 年 7 月底前）
* - [ ] 發布不同規模的模型（預計 2025 年 7 月底前）
* - [x] 提供新手友好的 Windows 快速入門 README
---


## 📄 授權條款

本專案以 Apache 2.0 授權條款釋出。

> **注意：**
> 原始碼、模型與數據集**僅供學術研究及教育用途**。
> **禁止商業用途。**
> 若需商業授權，請聯絡作者。

**📦 第三方元件**

* **Stable Audio Open VAE**（Stability AI 提供）：
  本儲存庫包含來自 [Stable Audio Open](https://huggingface.co/stabilityai/stable-audio-open-1.0/) 的微調 VAE，依照 [Stability AI Community License](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/./third_party/LICENSE_StabilityAI.md) 授權。
  **商業用途與再分發需事先獲得 Stability AI 的許可。**

* 📘 **所有其他原始碼與模型**皆以 Apache License 2.0 釋出。

---

## 致謝

特別感謝：

* **stable-audio-tools**（Stability AI 提供）：
  提供易於使用的音訊生成框架，以及 VAE 模組與權重。
* **MMAudio**：
  在音訊領域實作 MM-DiT 主幹架構。

---

## 📖 請引用

如果您在研究或工作中覺得 ThinkSound 有所幫助，請引用我們的論文：


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

## 📬 聯絡方式

✨ 如果您有任何問題或建議，歡迎[提交 Issue](https://github.com/liuhuadai/ThinkSound/issues) 或透過電子郵件聯絡我們（[liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)）！



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-16

---