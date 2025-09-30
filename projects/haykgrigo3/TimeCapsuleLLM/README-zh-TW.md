
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">簡體中文</a>
        | <a href="#" title="Coming soon">繁體中文（即將推出）</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">韓國語</a>
        | <a href="#" title="Coming soon">हिन्दी（即將推出）</a> |
        | <a href="#" title="Coming soon">ไทย（即將推出）</a> |
        | <a href="#" title="Coming soon">Français（即將推出）</a>
        | <a href="#" title="Coming soon">Deutsch（即將推出）</a>
        | <a href="#" title="Coming soon">Español（即將推出）</a>
        | <a href="#" title="Coming soon">Italiano（即將推出）</a>
        | <a href="#" title="Coming soon">Русский（即將推出）</a>
        | <a href="#" title="Coming soon">Português（即將推出）</a>
        | <a href="#" title="Coming soon">Nederlands（即將推出）</a>
        | <a href="#" title="Coming soon">Polski（即將推出）</a>
        | <a href="#" title="Coming soon">العربية（即將推出）</a>
        | <a href="#" title="Coming soon">فارسی（即將推出）</a>
        | <a href="#" title="Coming soon">Türkçe（即將推出）</a>
        | <a href="#" title="Coming soon">Tiếng Việt（即將推出）</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia（即將推出）</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM

*一個語言模型，從零開始**專門**在特定地區和時期的資料上訓練，以減少現代偏見並模擬該時代的語音、詞彙和世界觀。*

想像一下，如果一個 AI 模型不只是假裝是歷史的，而是真的如此。

v0 和 v0.5 基於 [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) 核心訓練腳本及模型架構皆來自於他。

v1 建立於 [微軟的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)

[Hugging Face 連結](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  模型行為與限制

### **v0**  

早期提示讓模型以 1800 年代的語言和行為回應。
範例：提示："Who art Henry?"，它回覆 "I know that man, I have did not a black, the storm."

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 未提及現代概念  
- 大多使用符合時代的詞彙  
- 句子大多不通順（約 187MB 訓練資料時預期現象）

### **v0.5** 

相較於 v0 有顯著提升。  
- 維多利亞時代寫作風格，標點正確，句子多數語法正確  
- 事實幻覺率仍高  
- 輸出中仍有 OCR 噪音（如 "Digitized by Google"）

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首個能回想並連結真實歷史事件與資料集真實人物的模型。

範例：提示："It was the year of our Lord 1834"

輸出："It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity"

起初我以為抗議活動可能只是巧合地發生在同一年，但請看這裡：![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### 為何這很重要：

這是我模型首次將年份與真實歷史事件及與該事件有關的真實人物（Palmerston 勳爵）相連結的例子。早期模型（v0 和 v0.5）雖能模仿十九世紀的寫作風格，但總是捏造事件、人物和事實。這顯示模型開始能記住資料集中的內容。


## 未來計畫

- 在 Internet Archive 上，倫敦於1800-1875年間出版的文本有近175,000份
- 我計畫擴展語料庫並進一步清理，以提升推理能力
- 擴展到不同地區和時期，以建立更多的歷史模型

## 如何使用

本專案主要聚焦於整理歷史資料、準備訓練資料並建立分詞器。不會涵蓋完整的 LLM 訓練流程，相關內容請參考 Andrej Karpathy 的 nanoGPT。

### 步驟一：收集並準備歷史文本

- 收集你選定時期的公有領域書籍、文件等 .txt 檔（例如：倫敦 1800-1850）
- 請確保資料都在你選定的時間/地點範圍內
- 使用腳本清理文本檔，或手動移除如 Project Gutenberg 的標頭/頁尾、現代註解或 OCR 錯誤等雜訊。

### 步驟二：建立自訂分詞器

- 對清理過的資料執行 train_tokenizer.py 或 train_tokenizer_hf.py
- 這將產生 vocab.json 與 merges.txt
- 這些檔案定義了模型的詞彙表和合併規則

### 步驟三：訓練你的模型

- 有關訓練流程，請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 或你選用架構的官方文件。

# 常見問答

## 什麼是選擇性時期訓練（Selective Temporal Training）？

選擇性時期訓練（STT）是一種機器學習方法，所有訓練資料都特別整理，僅限於某個歷史時期。這麼做是為了建模該時代的語言與知識，不受現代概念影響。例如，目前的模型（v0.5）只用1800-1875年的資料訓練，並非微調，而是從零開始訓練，因此輸出能反映該時期的語言風格與歷史背景。

## 為什麼不直接用微調或 LoRA？

本專案目標是建立一個不受現代偏見影響的語言模型。如果用 GPT-2 這類模型微調，原本的預訓練資訊無法完全消除。從零開始訓練的語言模型不會假裝是舊的，而是本身就是。現階段目標是建立一個僅能用1800-1875年倫敦出版書籍知識推理的模型。

## 你用什麼資料來訓練？


我正在使用1800至1875年倫敦的書籍、法律文件、報紙以及其他著作。你可以查看我提供的清單（v0版本），裡面大約有200份文件，但在第一次訓練時我只用了50個檔案，約187MB。你可以在以下連結查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

資料集大小：
v0：約187MB
v0.5：約435MB
v1：約6.25GB

## 模型有多大？

V0：1600萬參數

V0.5：1億2300萬參數

V1：7億參數

# 訓練規格？

# V0/V0.5
GPU：Geforce RTX 4060
CPU：i5-13400F
記憶體：16GB DDR5。

# V1
GPU：租用A100

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---