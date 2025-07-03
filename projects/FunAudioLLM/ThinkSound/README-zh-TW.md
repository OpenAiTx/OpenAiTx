# 🎶 ThinkSound

<p align="center">
  如果你覺得本專案有用，請在 GitHub 給我們一顆星 ⭐，非常感謝！
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

---

**ThinkSound** 是一個統一的 Any2Audio 生成框架，採用 Chain-of-Thought（CoT）推理指導的 Flow Matching。

基於 PyTorch 的多模態音訊生成與編輯實現：可從影片、文字、音訊生成或編輯音訊，並由多模態大型語言模型（MLLMs）逐步推理驅動。

![Teaser](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig1_teaser.png)
---

## 📰 最新消息
- **2025.07** &nbsp; 🔥[Hugging Face Spaces](https://huggingface.co/spaces/FunAudioLLM/ThinkSound) 及 [ModelScope](https://modelscope.cn/studios/iic/ThinkSound) 上線互動體驗！
- **2025.07** &nbsp; 🔥推理腳本與網頁介面開源發布；
- **2025.06** &nbsp; 🔥[ThinkSound 論文](https://arxiv.org/pdf/2506.21448) 發佈於 arXiv！
- **2025.06** &nbsp; 🔥[線上 Demo](http://thinksound-project.github.io/) 已上線 - 歡迎體驗！

---

## 🚀 特色

- **Any2Audio**：可從任意模態（影片、文字、音訊或其組合）生成音訊。
- **影片轉音訊 SOTA**：在多個 V2A 基準上達到最先進表現。
- **CoT 驅動推理**：透過多模態大型語言模型實現組合式與可控音訊生成的 Chain-of-Thought 推理。
- **互動式物件導向編輯**：可透過點擊視覺物件或文字指令細緻編輯或完善特定聲音事件。
- **統一框架**：一個基礎模型即支援生成、編輯與互動式流程。

---

## ✨ 方法概覽

ThinkSound 將音訊生成與編輯分為三個互動階段，皆由基於 MLLM 的 Chain-of-Thought（CoT）推理指導：

1. **Foley 生成：** 從影片生成語意與時間對齊的基礎音景。
2. **物件導向細緻化：** 透過點選或圈選影片中指定物件，細緻化或新增聲音。
3. **目標音訊編輯：** 使用高階自然語言指令修改生成音訊。

![ThinkSound Overview](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig3_model.png)
<!-- 一個大規模 CoT 註釋資料集（**AudioCoT**）用於訓練推理模組與統一音訊基礎模型。
![AudioCoT Pipeline](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/assets/figs/fig2_dataset.png) -->

---

## ⚡ 快速開始

**環境準備：**
```bash
git clone https://github.com/liuhuadai/ThinkSound.git
cd ThinkSound
pip install -r requirements.txt
conda install -y -c conda-forge 'ffmpeg<7'
# 下載預訓練權重 https://huggingface.co/liuhuadai/ThinkSound 至目錄 ckpts/
# 模型權重也可從 https://www.modelscope.cn/models/iic/ThinkSound 下載
git lfs install
git clone https://huggingface.co/liuhuadai/ThinkSound ckpts
```

**設為可執行**
```bash
chmod +x scripts/demo.sh
```

**執行腳本**
```bash
./scripts/demo.sh <video_path> <caption> <CoT description>
```


### 網頁介面使用

如需互動體驗，啟動 Gradio 網頁介面：

```bash
python app.py
```

---
## 📝 TODO

- ☐ 發佈 ThinkSound 模型的訓練腳本
- ☐ 開源 AudioCoT 數據集及自動化流程
- ☐ 提供詳細的文件與 API 參考
- ☐ 增加對更多模態及下游任務的支援

---

## 📄 授權條款

本專案依據 [Apache 2.0 授權條款](LICENSE) 發佈。

> **注意：**  
> 此程式碼、模型及數據集**僅供學術研究與教育用途**。  
> **禁止商業用途。**
>
> 若需商業授權，請聯絡作者。

---

## 📖 引用

如果您在研究或工作中覺得 ThinkSound 有幫助，請引用我們的論文：

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

✨ 如果您有任何問題或建議，歡迎[提交 issue](https://github.com/liuhuadai/ThinkSound/issues)或透過電子郵件 ([liuhuadai@zju.edu.cn](https://raw.githubusercontent.com/FunAudioLLM/ThinkSound/master/mailto:liuhuadai@zju.edu.cn)) 聯絡我們！

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-03

---