<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文（即將推出）</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
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
一個僅以特定時期數據訓練的 LLM，旨在減少現代偏見。

想像一下，如果一個 AI 模型不只是「假裝」歷史，而是真的「是」歷史。

基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 核心訓練腳本及模型架構來自他的工作。

# 專案目標

TimeCapsule LLM 是一個實驗性專案，僅以特定時期撰寫的文本進行訓練。目標是模擬特定歷史時代的世界觀與語言。

# 為什麼只微調還不夠

如果你只是微調一個預訓練模型，你的 LLM 仍然會了解現代概念。當然，實現完全沒有現代偏見很難，但我想盡量接近這個目標。要做到完全沒有現代偏見，就需要從零開始訓練模型。

# 預期成果

希望完成後，這個模型將不會知道現代概念，也無法做出超出訓練內容的推理。它不應該識別現代概念／詞彙，也希望不會憑空產生現代知識。

# 進度更新

## 2025 年 7 月 9 日

我已設定訓練時期為 1800-1850 年，地區：倫敦

我已經收集了一份文本、書籍、文件的清單

目前已獲得 50 份 txt 檔案，將很快開始訓練 NanoGPT

只要有進度我都會持續更新這裡

## 2025 年 7 月 13 日

使用 187MB 歷史文本數據訓練了 nanoGPT。

## 2025 年 7 月 15 日

我已經開始下載第二輪訓練所需的文本。全部都從 Internet Archive 取得，並將時期擴展到 1800-1875 年。為了取得多元的文本，你可以在 Internet Archive 透過主題、出版地點、時期和主題篩選器來搜尋。

![搜尋篩選器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025 年 7 月 16 日

我從 Internet Archive 下載了大約 500 份 txt 檔案，經過清理（刪除空白、Gutenberg 頭部等）後，總計約有 500MB 的數據。這是一個很小的資料集，但上次只用 187MB 也訓練過，所以訓練第二個模型後應該至少會有某些明顯的差異。我希望這個模型至少能生成更連貫且有意義的句子。當然這不是保證，畢竟這仍然是個非常小的數據集，但總比上次多。

這應該可以在我自己的硬體上完成，也不錯，因為在跳到更大的數據集、必須租用 GPU 前，我希望能先看到一些改進。但別擔心，我還是計劃很快租用 GPU，不過在那之前，我想確保我的數據集夠精選且乾淨。我遇到的問題之一是清理，很多 txt 檔案裡夾雜著亂碼。我用過的清理腳本雖然有用，但不是百分百有效。

我今天會訓練這個數據集，預計會花 4-5 小時。訓練完成並測試後我會更新進度。再次感謝大家關注我的專案，有些人甚至給我提供了 OCR 資源連結，非常感謝！希望有更多人試試看，並用自己的數據集做實驗。

### 訓練進度更新

我開始用 435MB（1.08 億 token）語料訓練，目前進展順利。訓練損失從 10.9 降到 4.9，只花了 2800 次迭代。我預計總共要 8 或 9 小時才能完成。等訓練完會再更新進度。

## 2025 年 7 月 17 日

第二版模型訓練完成，4060 顯卡耗時約 8 小時 40 分鐘（每小時 3,900 次迭代），共 33,000 次迭代（5 個 epoch）。最終訓練損失為 3.73。輸出結果出乎意料地好，現在真的能生成連貫的 19 世紀風格句子。

## 2025 年 7 月 28 日

我已將 v0.5 上傳至 Hugging Face，[歡迎查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你現在可以下載我的 repo 並在本地執行。不過 nanoGPT 無法原生支援 HuggingFace，所以必須下載模型後在本地運行。

同時我將開始為下一輪訓練蒐集數據，我認為可能需要 5-10 倍的數據量來實現推理能力。

## 2025 年 8 月 2 日

我很快就要開始開發 Version 1。我需要從 nanoGPT 的架構轉向更現代的方案。我考慮了幾個開源 LLM 架構，包括：OpenLLaMA v3、Phi-2 和 Qwen 1.5B。為了支持 V1 升級，我需要精心挑選一個更大且多元的數據集，至少需要 5GB 乾淨的訓練數據。



# V0 模型行為與限制

早期的提示顯示該模型會以 1800 年代的語言和行為回應。例如，我用「Who art Henry?」進行提示，它回覆說：「I know that man, I have did not a black, the storm.」這句話雖然語無倫次，但 LLM 能辨識出我是在詢問某個人。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

沒有提及現代概念，輸出內容大多包含 1800 年代的用字與措辭。

它仍然需要大量改進，僅以 187MB 進行訓練，無法得到能產生具備複雜推理能力的模型。

目前它產生的句子缺乏完整句構，整體意思不通，但這對於這種訓練規模來說是正常的。

# V0.5 模型行為與限制

相較於上一個模型，這是一個很大的進步。寫作風格與詞彙屬於維多利亞時期，幾乎每一句都語法正確且有適當標點。這同樣是從頭訓練，所以內容始終圍繞 1800 年代的主題。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

有大量的事實幻覺。許多（幾乎 100%）細節（日期、事件、歷史人物）都是虛構的。此外，句子之間大多沒有連貫關係，有時只有兩句彼此相關，再多就沒有了。另一個問題是偶爾會出現「Digitized by Google」這種殘留頁腳，所以下次訓練時我必須確保文本徹底清理。整體而言我對結果很滿意，雖然距離 LLM 還有很大差距，但已經是個句子生成器了。

我學到了很多，未來幾週會開始釐清哪些地方需要改進。很快就會上傳檔案！

# 即將到來的計畫

（已完成）我要開始著手 0.5 版的訓練，不再只用 50 本書，而是理想上用 500-600 本。目前我正用 1800-1850 年間、來自倫敦的書籍訓練 nanoGPT。挑戰之一是要確保找到的書不是後來增修或現代詮釋，而是真正未經改動、出版於指定時期的書籍。

我想用更大的語料庫（v1）訓練新模型，也許是 v0.5 的 5-10 倍。我的目標是看看僅靠選擇性時代訓練（Selective Temporal Training）能否讓推理能力自然湧現。這會更難，我甚至不確定是否可行，因為歷史數據有限。未來幾週我會嘗試整理出 5-10GB 的語料。如果能找到乾淨高品質的數據並租到 GPU，我相信會有進展。

# 如何使用本專案

本專案主要聚焦於歷史數據的蒐集、整理並為訓練建構分詞器。不涵蓋完整 LLM 訓練流程，相關內容請參考 Andrej Karpathy 的 nanoGPT。

# 步驟一：蒐集與準備歷史文本

收集所選時期的公共領域書籍、文件等 .txt 檔（例：倫敦 1800-1850）

如需批量下載書籍，可以使用 download_texts_improved.py。

用腳本清理或手動刪除 Project Gutenberg 頁首/頁尾、現代註解或 OCR 錯誤等。

prepare_dataset.py 應該能正常運作。

# 步驟二：建立自訂分詞器

在清理過的數據上執行 train_tokenizer.py 或 train_tokenizer_hf.py。
這會產生 vocab.json 與 merges.txt

這些檔案定義了模型的詞彙表與合併規則

# 步驟三：訓練你的模型（nanoGPT）

訓練流程請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)。

你想用別的 LLM 也可以，但我用的是 nanoGPT

# 常見問題

## 什麼是選擇性時代訓練（Selective Temporal Training）？

選擇性時代訓練（STT）是一種機器學習方法，所有訓練數據都精心篩選於特定歷史時期。目的是在不受現代概念影響下建模該時代的語言與知識。例如，我現在的模型（v0.5）只用 1800-1875 年的數據訓練，完全從零開始，因此輸出能反映當時的語言風格和歷史背景。

## 為什麼不用微調或 LoRA？

這個專案的目標是打造不受現代偏見影響的語言模型。如果對 GPT-2 等現有模型做微調，它已經有預訓練知識，無法徹底消除。如果從零訓練，語言模型不會假裝「古老」，而是真的如此。目前專案目標是讓模型只用 1800-1850 年間倫敦書籍的知識進行推理。

## 你用什麼數據訓練？

我使用 1800-1850 年間倫敦的書籍、法律文件、報紙及其他著作。連結中的清單有約 200 份，但首次訓練只用了 50 份檔案，共約 187MB。你可以查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0 版模型有多大？

這個模型目前很小，我只是為了好玩，且堅持不用現代資料進行嚴格訓練。它大約有一千六百萬個參數，我接下來會開始蒐集更多舊文本來訓練新模型。進度會隨時更新。

## 訓練規格？

GPU：Geforce rtx 4060
CPU：i5-13400F
記憶體：16GB DDR5。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-07

---