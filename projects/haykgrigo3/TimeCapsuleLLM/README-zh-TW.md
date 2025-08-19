
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

v1 建立於 [微軟 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)


##  模型行為與限制

### **v0**  

早期提示顯示模型以十九世紀語言及行為回應。
範例：提示：「Who art Henry?」模型回覆：「I know that man, I have did not a black, the storm.」

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 未提及現代概念  
- 主要使用當代詞彙  
- 句子大多不連貫（約 187MB 訓練資料，屬預期現象）

### **v0.5** 

相較 v0 有顯著進步。  
- 維多利亞時期寫作風格，標點正確，句子語法大致正確  
- 事實虛構率仍高  
- 輸出仍有 OCR 雜訊（如「Digitized by Google」）

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首個能夠回憶並連結真實歷史事件及資料集中真實人物的模型。

範例：提示：「It was the year of our Lord 1834」 

模型輸出：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」 

我原以為抗議活動可能只是巧合地發生於該年，但請看這張圖：![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### 為何這很重要：

這是我模型首次將年份與真實歷史事件及相關人物（Lord Palmerston）連結。早期模型（v0 及 v0.5）雖可模仿十九世紀寫作風格，但總是虛構事件、人物及事實。這顯示模型開始記住資料集中的內容。

## 未來計畫 
- 在網際網路檔案館（Internet Archive）上，倫敦於1800-1875年間出版的文本近175,000份
- 我計劃擴展語料庫並進行更完善的清理，以提升推理能力
- 擴展至不同地區和時期，以建立更多歷史模型

## 如何使用

本專案主要聚焦於蒐集歷史資料，準備訓練並建立分詞器。完整的LLM訓練流程將不在此涵蓋，詳細請參考Andrej Karpathy的nanoGPT。

### 步驟1：蒐集並準備歷史文本

- 收集所選時期的公有領域書籍、文件等的.txt檔案（如：倫敦1800-1850）
- 保持在你選定的時間與地點範圍內
- 使用腳本清理文本檔案，或手動移除古騰堡計畫的頁首/頁尾、現代註釋或OCR錯誤等內容。

### 步驟2：建立自訂分詞器

- 在清理過的資料上執行train_tokenizer.py或train_tokenizer_hf.py
- 這會產生vocab.json和merges.txt
- 這些檔案定義了你的模型的詞彙及合併規則

### 步驟3：訓練你的模型

- 訓練流程請參考[Andrej Karpathy的nanoGPT](https://github.com/karpathy/nanoGPT)或你選用架構的官方文件。

# 常見問答

## 什麼是選擇性時代訓練（Selective Temporal Training）？

選擇性時代訓練（STT）是一種機器學習方法，所有訓練資料都特別挑選在特定歷史時期之內。這麼做是為了建模該時代的語言和知識，避免受現代概念影響。例如，我目前的模型（v0.5）完全以1800-1875年的資料訓練，並非微調，而是從零開始訓練，因此輸出能反映那個時期的語言風格和歷史語境。

## 為什麼不直接用微調或LoRA？

這個專案目標是打造不受現代偏見影響的語言模型。如果我微調如GPT-2，該模型已經預先訓練過，舊知識無法被完全替代。如果從零開始訓練，語言模型不會「假裝」古老，而是本身就具有那個時代的特質。現階段目標是建立一個能只用1800到1875年倫敦出版書籍的知識來推理的模型。

## 你用什麼資料訓練的？

我使用1800–1875年倫敦的書籍、法律文件、報紙與其他著作。我連結的清單（v0）約200份，但首次訓練只用50個檔案，約187 MB。你可以查閱文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt



資料集大小：
v0：約 187MB
v0.5：約 435MB
v1：約 6.25GB

## 模型有多大？

V0：16M 參數

V0.5：123M 參數

V1：700M 參數

# 訓練規格？

# V0/V0.5
GPU：Geforce RTX 4060
CPU：i5-13400F
記憶體：16GB DDR5。

# V1
GPU：租用的 A100














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---