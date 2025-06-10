<div align="center">
<h1>Fish Speech</h1>

**English** | [簡體中文](docs/README.zh.md) | [Portuguese](docs/README.pt-BR.md) | [日本語](docs/README.ja.md) | [한국어](docs/README.ko.md) <br>

<a href="https://www.producthunt.com/posts/fish-speech-1-4?embed=true&utm_source=badge-featured&utm_medium=badge&utm_souce=badge-fish&#0045;speech&#0045;1&#0045;4" target="_blank">
    <img src="https://api.producthunt.com/widgets/embed-image/v1/featured.svg?post_id=488440&theme=light" alt="Fish&#0032;Speech&#0032;1&#0046;4 - Open&#0045;Source&#0032;Multilingual&#0032;Text&#0045;to&#0045;Speech&#0032;with&#0032;Voice&#0032;Cloning | Product Hunt" style="width: 250px; height: 54px;" width="250" height="54" />
</a>
<a href="https://trendshift.io/repositories/7014" target="_blank">
    <img src="https://trendshift.io/api/badge/repositories/7014" alt="fishaudio%2Ffish-speech | Trendshift" style="width: 250px; height: 55px;" width="250" height="55"/>
</a>
<br>
</div>
<br>

<div align="center">
    <img src="https://count.getloli.com/get/@fish-speech?theme=asoul" /><br>
</div>

<br>

<div align="center">
    <a target="_blank" href="https://discord.gg/Es5qTB9BcN">
        <img alt="Discord" src="https://img.shields.io/discord/1214047546020728892?color=%23738ADB&label=Discord&logo=discord&logoColor=white&style=flat-square"/>
    </a>
    <a target="_blank" href="https://hub.docker.com/r/fishaudio/fish-speech">
        <img alt="Docker" src="https://img.shields.io/docker/pulls/fishaudio/fish-speech?style=flat-square&logo=docker"/>
    </a>
    <a target="_blank" href="https://pd.qq.com/s/bwxia254o">
      <img alt="QQ Channel" src="https://img.shields.io/badge/QQ-blue?logo=tencentqq">
    </a>
</div>

<div align="center">
    <a target="_blank" href="https://huggingface.co/spaces/TTS-AGI/TTS-Arena-V2">
      <img alt="TTS-Arena2 Score" src="https://img.shields.io/badge/TTS_Arena2-Rank_%231-gold?style=flat-square&logo=trophy&logoColor=white">
    </a>
    <a target="_blank" href="https://huggingface.co/spaces/fishaudio/fish-speech-1">
        <img alt="Huggingface" src="https://img.shields.io/badge/🤗%20-space%20demo-yellow"/>
    </a>
    <a target="_blank" href="https://huggingface.co/fishaudio/openaudio-s1-mini">
        <img alt="HuggingFace Model" src="https://img.shields.io/badge/🤗%20-models-orange"/>
    </a>
</div>

> [!IMPORTANT]
> **授權聲明**  
> 本程式碼庫採用 **Apache License** 授權，所有模型權重則採用 **CC-BY-NC-SA-4.0 License** 授權。詳情請參閱 [LICENSE](LICENSE)。

> [!WARNING]
> **法律聲明**  
> 我們不對任何非法使用本程式碼庫的行為承擔任何責任。請遵守您當地有關 DMCA 及其他相關法律法規。

---

## 🎉 公告

我們很高興地宣布品牌升級為 **OpenAudio** —— 推出一系列基於 Fish-Speech 並具有革命性創新的高階文字轉語音（Text-to-Speech, TTS）模型。

我們自豪地發布本系列的首款模型 **OpenAudio-S1**，在品質、性能與功能上均有重大提升。

OpenAudio-S1 提供兩個版本：**OpenAudio-S1** 及 **OpenAudio-S1-mini**。兩者分別可於 [Fish Audio Playground](https://fish.audio)（**OpenAudio-S1**）及 [Hugging Face](https://huggingface.co/fishaudio/openaudio-s1-mini)（**OpenAudio-S1-mini**）取得。

更多部落格文章與技術報告，請參閱 [OpenAudio 官網](https://openaudio.com/blogs/s1)。

## 亮點 ✨

### **卓越 TTS 語音品質**

我們使用 Seed TTS 評測指標來評估模型表現，結果顯示 OpenAudio S1 在英文文本上達到 **0.008 WER** 和 **0.004 CER**，大幅優於先前模型。（英文，自動評測，基於 OpenAI gpt-4o-transcribe，說話人距離採用 Revai/pyannote-wespeaker-voxceleb-resnet34-LM）

| 模型 | 詞錯誤率 (WER) | 字元錯誤率 (CER) | 說話人距離 |
|-------|----------------------|---------------------------|------------------|
| **S1** | **0.008**  | **0.004**  | **0.332** |
| **S1-mini** | **0.011** | **0.005** | **0.380** |

### **TTS-Arena2 榜首 🏆**

OpenAudio S1 已在 [TTS-Arena2](https://arena.speechcolab.org/) —— 文字轉語音評測基準 —— 榮獲 **#1 排名**：

<div align="center">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Elo.jpg" alt="TTS-Arena2 Ranking" style="width: 75%;" />
</div>

### **語音控制**

OpenAudio S1 **支援多種情感、語氣及特殊標記**，讓語音合成更生動：

- **基礎情感**：
```
(angry) (sad) (excited) (surprised) (satisfied) (delighted) 
(scared) (worried) (upset) (nervous) (frustrated) (depressed)
(empathetic) (embarrassed) (disgusted) (moved) (proud) (relaxed)
(grateful) (confident) (interested) (curious) (confused) (joyful)
```

- **進階情感**：
```
(disdainful) (unhappy) (anxious) (hysterical) (indifferent) 
(impatient) (guilty) (scornful) (panicked) (furious) (reluctant)
(keen) (disapproving) (negative) (denying) (astonished) (serious)
(sarcastic) (conciliative) (comforting) (sincere) (sneering)
(hesitating) (yielding) (painful) (awkward) (amused)
```

- **語氣標記**：
```
(in a hurry tone) (shouting) (screaming) (whispering) (soft tone)
```

- **特殊音效**：
```
(laughing) (chuckling) (sobbing) (crying loudly) (sighing) (panting)
(groaning) (crowd laughing) (background laughter) (audience laughing)
```

你也可以使用 Ha,ha,ha 來控制，還有更多用法等你自行探索。

（目前支援英文、中文與日文，更多語言即將推出！）

### **雙版本模型選擇**

| 模型 | 參數量 | 取得管道 | 特色 |
|-------|------|--------------|----------|
| **S1** | 40 億參數 | 可於 [fish.audio](fish.audio) 使用 | 全功能旗艦模型 |
| **S1-mini** | 5 億參數 | 可於 huggingface [hf space](https://huggingface.co/spaces/fishaudio/openaudio-s1-mini) 使用 | 精簡版，保留核心能力 |

S1 與 S1-mini 均內建線上人類反饋強化學習（RLHF）。

## **功能特點**

1. **零樣本／少樣本 TTS：** 輸入 10~30 秒人聲樣本，即可生成高品質 TTS 輸出。**詳細操作參考 [Voice Cloning Best Practices](https://docs.fish.audio/text-to-speech/voice-clone-best-practices)。**

2. **多語種／跨語言支援：** 直接複製並貼上多語種文本至輸入框，無需擔心語種。目前支援英語、日語、韓語、中文、法語、德語、阿拉伯語及西班牙語。

3. **無需音素依賴：** 模型泛化能力強，語音合成不依賴音素，能處理任何語言文字。

4. **高度準確：** Seed-TTS 評測中，CER（字元錯誤率）約 0.4%，WER（詞錯誤率）約 0.8%。

5. **高效快速：** 搭載 fish-tech 加速，Nvidia RTX 4060 筆電實時係數約 1:5，Nvidia RTX 4090 約 1:15。

6. **WebUI 推理介面：** 內建基於 Gradio 的簡易網頁界面，支援 Chrome、Firefox、Edge 等主流瀏覽器。

7. **GUI 推理介面：** 提供 PyQt6 圖形界面，完美兼容 API 服務器。支援 Linux、Windows、macOS。[查看 GUI](https://github.com/AnyaCoder/fish-speech-gui)。

8. **易於部署：** 原生支援 Linux、Windows（MacOS 即將支援），搭建推理伺服器簡單，速度損耗小。

## **媒體與演示**

<div align="center">

### **社群媒體**
<a href="https://x.com/FishAudio/status/1929915992299450398" target="_blank">
    <img src="https://img.shields.io/badge/𝕏-Latest_Demo-black?style=for-the-badge&logo=x&logoColor=white" alt="Latest Demo on X" />
</a>

### **互動演示**
<a href="https://fish.audio" target="_blank">
    <img src="https://img.shields.io/badge/Fish_Audio-Try_OpenAudio_S1-blue?style=for-the-badge" alt="Try OpenAudio S1" />
</a>
<a href="https://huggingface.co/spaces/fishaudio/openaudio-s1-mini" target="_blank">
    <img src="https://img.shields.io/badge/Hugging_Face-Try_S1_Mini-yellow?style=for-the-badge" alt="Try S1 Mini" />
</a>

### **影片展示**

<a href="https://www.youtube.com/watch?v=SYuPvd7m06A" target="_blank">
    <img src="https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/assets/Thumbnail.jpg" alt="OpenAudio S1 Video" style="width: 50%;" />
</a>

### **音訊樣本**
<div style="margin: 20px 0;">
    <em> 高品質音訊樣本即將上線，將展示我們多語種 TTS 能力與多種情感。</em>
</div>

</div>

---

## 文件

- [建置環境](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/install.md)
- [推理流程](https://raw.githubusercontent.com/fishaudio/fish-speech/main/docs/en/inference.md)

## 致謝

- [VITS2 (daniilrobnikov)](https://github.com/daniilrobnikov/vits2)
- [Bert-VITS2](https://github.com/fishaudio/Bert-VITS2)
- [GPT VITS](https://github.com/innnky/gpt-vits)
- [MQTTS](https://github.com/b04901014/MQTTS)
- [GPT Fast](https://github.com/pytorch-labs/gpt-fast)
- [GPT-SoVITS](https://github.com/RVC-Boss/GPT-SoVITS)
- [Qwen3](https://github.com/QwenLM/Qwen3)

## 技術報告 (V1.4)
```bibtex
@misc{fish-speech-v1.4,
      title={Fish-Speech: Leveraging Large Language Models for Advanced Multilingual Text-to-Speech Synthesis},
      author={Shijia Liao and Yuxuan Wang and Tianyu Li and Yifan Cheng and Ruoyi Zhang and Rongzhi Zhou and Yijin Xing},
      year={2024},
      eprint={2411.01156},
      archivePrefix={arXiv},
      primaryClass={cs.SD},
      url={https://arxiv.org/abs/2411.01156},
}
```

---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-06-10

---