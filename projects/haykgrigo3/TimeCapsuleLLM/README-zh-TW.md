
<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="#" title="Coming soon">繁體中文 (即將推出)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="#" title="Coming soon">हिन्दी (即將推出)</a> |
        | <a href="#" title="Coming soon">ไทย (即將推出)</a> |
        | <a href="#" title="Coming soon">Français (即將推出)</a>
        | <a href="#" title="Coming soon">Deutsch (即將推出)</a>
        | <a href="#" title="Coming soon">Español (即將推出)</a>
        | <a href="#" title="Coming soon">Italiano (即將推出)</a>
        | <a href="#" title="Coming soon">Русский (即將推出)</a>
        | <a href="#" title="Coming soon">Português (即將推出)</a>
        | <a href="#" title="Coming soon">Nederlands (即將推出)</a>
        | <a href="#" title="Coming soon">Polski (即將推出)</a>
        | <a href="#" title="Coming soon">العربية (即將推出)</a>
        | <a href="#" title="Coming soon">فارسی (即將推出)</a>
        | <a href="#" title="Coming soon">Türkçe (即將推出)</a>
        | <a href="#" title="Coming soon">Tiếng Việt (即將推出)</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (即將推出)</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
一個僅以特定時期資料訓練的 LLM，以降低現代偏見。

想像一下，如果 AI 模型不只是「假裝」是歷史性的，而是真正如此。

基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 開發，核心訓練腳本與模型架構皆源自其作品。

# 專案目標

TimeCapsule LLM 是一個實驗性專案，僅以特定時期的文本進行訓練。目標是模擬特定歷史時代的世界觀與語言。

# 為什麼微調還不夠

如果你只是對預訓練模型進行微調，你的 LLM 仍然會知道現代的概念。當然要完全消除現代偏見非常困難，但我希望能盡可能接近這個目標。要做到完全沒有現代偏見，必須從零開始訓練模型。

# 預期成果

希望完成後，這個模型將不會知道現代概念，也無法推理超出訓練內容的知識。它不應該辨識現代詞彙／概念，也希望不會幻想出現代知識。

# 進度更新

## 2025 年 7 月 9 日

我將時間範圍設定為 1800-1850 年，地區為倫敦

已整理出一份文本、書籍、文件清單

目前已取得 50 份 txt 檔案，將很快開始訓練 NanoGPT

只要有進展會隨時更新

## 2025 年 7 月 13 日

已用 187MB 的歷史文本資料訓練 nanoGPT。

## 2025 年 7 月 15 日

我已開始下載第二次訓練所需的文本。全部都來自 Internet Archive，並將時間範圍擴大到 1800-1875 年。為了獲得多樣化文本，你可以使用 Internet Archive 的主題與搜尋篩選功能，按出版地點、時期及主題篩選。

![搜尋篩選器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025 年 7 月 16 日

我從 Internet Archive 下載了約 500 個 txt 檔案，經過清理（只刪除空白、Gutenberg 標頭等）後，約有 500MB 資料。資料集很小，但上次只用 187MB 訓練，所以這次訓練後輸出應該會有明顯差異。我希望這次的模型至少能產生較通順且有意義的句子。當然這沒有保證，畢竟資料集還是很小，但總比上次多了。

這應該能在我自己的硬體上完成訓練，也好，因為希望在跳到更大資料集、需要租用 GPU 之前，先看到一些進步。但別擔心，我仍然計畫很快租用 GPU，只是在此之前要確保我的資料集夠精選、夠乾淨。其中一個問題就是清理，很多 txt 檔案裡有亂碼。用過的清理腳本雖然有效，但不是 100% 有效。

我今天會訓練這個資料集，預計需要 4-5 小時。完成並測試後會再更新。再次感謝所有關注我專案的人，甚至有人提供 OCR 資源連結，感謝！希望有更多人嘗試並實驗自己的資料集。

## 2025 年 7 月 28 日

我已將 v0.5 上傳至 Hugging Face，[點此查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你現在可以下載我的 repo 並在本地運行。不幸的是 nanoGPT 無法直接與 HuggingFace 整合，所以必須下載模型到本地執行。

同時我會開始整理下一輪訓練所需的資料，我認為需要 5-10 倍的資料量才能讓模型有推理能力。

### 訓練進度更新

我已開始用 435MB（1.08 億詞元）的語料庫訓練，目前進展順利。訓練損失從 10.9 降到 4.9，僅 2800 次迭代。我預計總共要花 8~9 小時才能完成。等完成會再發布更新。

## 2025 年 7 月 17 日 2:13AM

第二個模型訓練完成，我的 4060 共花了約 8 小時 40 分鐘（每小時 3,900 次迭代），共 33,000 次迭代（5 輪）。最終訓練損失為 3.73。結果讓我驚訝，現在真的能產生通順的 19 世紀風格句子。

# V0 模型行為與限制

早期提示顯示模型會用 1800 年代的語言與行為回應。例如，我以 "Who art Henry?" 提示，它回覆 "I know that man, I have did not a black, the storm."——雖然語句不通，但 LLM 已能辨識我在詢問某個人。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

沒有提及現代概念，輸出內容大多為十九世紀的詞彙與用語。

目前還需要大量改進，僅以187MB的資料進行訓練，無法產生具有複雜推理能力的模型。

現在產出的句子缺乏完整句子結構，整體也不合邏輯，但這對於這樣的訓練規模來說是正常的。

# V0.5 模型行為與限制

這比上一個模型有明顯改進。寫作風格與詞彙屬於維多利亞時代，幾乎每個句子都文法正確且標點合宜。由於完全從零訓練，因此內容緊扣十九世紀主題。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

存在大量事實性幻覺。大多數細節（日期、事件、歷史人物）幾乎都是虛構的。另外句子之間沒有真正的連貫性，頂多兩句會有關聯，超過就沒有了。另一個問題是偶爾會有“Digitized by Google”的頁腳出現，下次訓練時必須確實清理文本。總體來說我對結果很滿意，雖然離LLM還很遠，但確實可以生成句子。

我學到了很多，接下來幾週會開始思考該如何改進。我很快會上傳檔案！

# 未來計畫

（已完成）我將開始製作0.5版，這次不再只用50本書訓練，而是目標500-600本。目前我正使用來自1800-1850年、特別是倫敦的書籍來訓練nanoGPT。挑戰包括確保找到的書沒有被修改或有現代詮釋，而是要選擇在目標時期內出版且未經更動的原始書籍。

我希望訓練一個（v1）更大的模型，語料庫規模可能會是v0.5的5-10倍。我的目標是觀察是否僅靠選擇性時期訓練能產生推理能力，這會更具挑戰性，甚至不確定可不可行，畢竟歷史資料有限。接下來幾週我會盡量整理出5-10GB的語料庫。我相信若能取得乾淨高品質的資料並租用GPU，應該會有進展。

# 如何使用本專案

本專案主要聚焦於整理歷史資料、準備訓練用數據及建立分詞器。不會涵蓋完整的LLM訓練流程，相關細節請參考Andrej Karpathy的nanoGPT。

# 步驟一：收集與準備歷史文本

蒐集你所選時期的公有領域書籍、文件等.txt檔（如倫敦1800-1850）

如需自動下載書籍，可使用 download_texts_improved.py。

使用腳本或手動清理文本檔，去除Gutenberg專案的標頭/頁腳、現代註釋或OCR錯誤等內容。

prepare_dataset.py 應該可以正常運作。

# 步驟二：建立自訂分詞器

在清理過的資料上運行 train_tokenizer.py 或 train_tokenizer_hf.py。
這將生成 vocab.json 與 merges.txt

這些檔案定義了模型的詞彙與合併規則。

# 步驟三：訓練你的模型（nanoGPT）

請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 的訓練流程。

你也可以訓練其他LLM，但我這裡使用的是 nanoGPT。

# 常見問答

## 什麼是 Selective Temporal Training ？

Selective Temporal Training（STT，選擇性時期訓練）是一種機器學習方法，所有訓練資料都經過特別挑選，僅限於特定歷史時期。這樣做是為了建構該時代的語言和知識模型，不受現代概念影響。例如，目前的模型（v0.5）只用1800-1875年的資料訓練，非微調，而是從零開始訓練，因此輸出能反映當時的語言風格與歷史脈絡。

## 為什麼不用微調或LoRA？

這個專案希望打造一個不受現代偏見影響的語言模型。如果用GPT-2之類的模型做微調，它原本的訓練資料依然存在，無法去除。如果從零開始訓練，語言模型就不會“假裝”是舊的，而是真的只會用舊知識。目前的目標是做出一個能只用1800到1850年倫敦書籍知識進行推理的模型。

## 你用什麼資料來訓練？

我使用了1800-1850年倫敦的書籍、法律文件、報紙和其他著作。我連結的清單有約200本，但第一次訓練只用了約50個檔案，總計約187MB。你可以在這裡查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0版模型有多大？

這個模型目前非常小，純粹是娛樂性質並嚴格遵守不使用現代資料的原則。參數接近1600萬個。我會開始收集更多舊文本，進行新一輪模型訓練。進度會隨時更新。

## 訓練規格？

GPU：Geforce rtx 4060
CPU：i5-13400F
記憶體：16GB DDR5。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-29

---