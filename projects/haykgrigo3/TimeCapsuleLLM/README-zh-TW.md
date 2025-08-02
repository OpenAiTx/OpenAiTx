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
一個僅以特定時期資料訓練的LLM，以減少現代偏見。

想像一下，如果一個AI模型不只是模仿歷史，而是真的來自歷史。

基於 [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) ，核心訓練腳本與模型架構皆來自他。

# 專案目標

TimeCapsule LLM 是一個實驗性計畫，只會以特定時期所撰寫的文本進行訓練。目標是模擬特定歷史時代的世界觀與語言。

# 為什麼微調還不夠

如果你只是對預訓練模型做微調，你的LLM仍然會知道現代概念。當然，完全消除現代偏見很困難，但我希望盡可能接近這個目標。要做到完全無現代偏見，必須從零開始訓練模型。

# 預期成果

希望當模型完成時，它將不會知道現代概念，也無法超出訓練內容進行推理。它不應該認得現代概念/詞彙，也希望它不會臆造現代知識。

# 進度更新

## 2025年7月9日

我已設定目標時期為1800-1850年，地區為倫敦

我已收集了一份文本、書籍、文件的清單

目前已獲得50份txt檔案，即將開始訓練NanoGPT

只要有進展，我都會更新這裡

## 2025年7月13日

已用187MB的歷史文本資料訓練nanoGPT。

## 2025年7月15日

我開始下載第二輪訓練所需的文本。我從Internet Archive獲取所有資料，並將時期擴展到1800-1875年。為了獲得多元的文本，你可以在Internet Archive使用主題、出版地、時期及主題等篩選器。

![搜尋篩選器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我從Internet Archive下載了大約500個txt檔案，經過清理（僅刪除空白、Gutenberg標頭等）後，約有500MB的資料。這個資料集很小，但上次我只用187MB訓練，所以這次訓練第二個模型後，輸出應該至少會有一些明顯的差異。我希望這個模型至少能產生更通順、有意義的句子。當然這不能保證，畢竟資料集仍然很小，但已比上次多了。

這應該可以在我自己的硬體上完成，這也好，因為我可以在跳到更大的資料集、需要租用GPU之前，看到某種進步。但別擔心，我還是打算很快租用GPU，不過在那之前我想確保我的資料集已經盡可能精選和乾淨。我遇到的問題之一是清理，許多txt檔混入了亂碼。我用的清理腳本有效，但還不到100%完美。

我今天會訓練這個資料集，預計需要4-5小時。完成並測試後，我會提供更新。再次感謝所有關注我專案的人，有些人甚至給我OCR資源的連結，謝謝你們！希望有更多人嘗試這類計畫，並用自己的資料集實驗。

### 訓練進度更新

我開始用一份435MB（1.08億詞元）的語料庫訓練，目前進展順利。訓練損失在前2800次迭代中從10.9降到4.9。我預計大約需要8或9小時完成。完成後會再發佈更新。

## 2025年7月17日 凌晨2:13

第二個模型的訓練已完成，我的4060花了約8小時40分鐘（每小時3,900次迭代），共訓練33,000次（5個epoch）。最終訓練損失為3.73。輸出結果出乎意料地好，現在確實能生成通順的19世紀風格句子。

## 2025年7月28日

我已將v0.5上傳到Hugging Face，[歡迎查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你現在可以下載我的倉庫，並在本地運行。不過nanoGPT無法原生支援HuggingFace，所以你必須下載並本地運行模型。

另外我將開始整理下次訓練所需的資料，我認為要達到推理能力可能需要5-10倍的資料量。

# V0模型行為與限制

早期測試顯示，模型會以1800年代的語言和行為回應。例如，我用「Who art Henry?」作為提示，它回覆「I know that man, I have did not a black, the storm.」雖然這句話沒什麼意義，但LLM有辨識出我在問一個人。




![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

沒有提及現代概念，輸出內容大多使用十九世紀的詞彙與措辭。

目前還需要很多改進，僅用 187MB 來訓練，無法產生具有複雜推理的模型。

目前它產生的句子缺乏完整的句子結構，整體上也不太通順，但這對於這種訓練規模來說是正常的。

# V0.5 模型行為與限制

這比上一個模型有了明顯進步。寫作風格和詞彙是維多利亞時代的，幾乎每一句話都符合語法且有正確標點。這是從零開始訓練的，所以內容都圍繞十九世紀主題。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

有很多事實幻覺。很多（幾乎 100%）細節（日期、事件、歷史人物）都是虛構的。而且句子之間並沒有真正的關聯，有時也許只有兩句相關，但也僅止於此。另一個問題是有時會出現“Digitized by Google”這樣的尾註，下次訓練時我必須確保文本乾淨。總體來說，我對結果很滿意，雖然還遠稱不上 LLM，但已經是一個句子生成器。

我學到了很多，接下來幾週將開始找出需要改進的地方。很快就會上傳檔案！

# 未來規劃

（已完成）我即將開始 0.5 版本的工作，不再只用 50 本書訓練，而是理想上用 500-600 本。目前我正在用 1800-1850 年間倫敦的書籍來訓練 nanoGPT。遇到的挑戰包括確保所找到的書籍沒有更新過，也沒有現代詮釋，而是原汁原味的出版品。

我想訓練一個新模型（v1），使用更大的語料庫，可能是 v0.5 的 5-10 倍。我的目標是看看僅靠選擇性時代訓練能否出現推理能力，這會比較困難，我也不確定是否可行，因為有歷史資料的限制。未來幾週我會努力蒐集 5-10GB 的語料。我相信如果能取得乾淨高品質的數據並租用 GPU，會有所進展。

# 如何使用本專案

本專案主要聚焦於蒐集歷史資料、數據清理以及構建分詞器。不會涵蓋完整的 LLM 訓練過程，相關細節請參閱 Andrej Karpathy 的 nanoGPT。

# 步驟 1：收集與整理歷史文本

收集指定時期（如 1800-1850 年倫敦）的公有領域書籍、文件等 .txt 檔案。

如果需要，可以用 download_texts_improved.py 來自動下載書籍。

用腳本或手動方式清理文本檔案，去除 Project Gutenberg 的標頭/尾註、現代註解或 OCR 錯誤等。

prepare_dataset.py 應該可以正常使用。

# 步驟 2：建立自訂分詞器

在清理過的數據上執行 train_tokenizer.py 或 train_tokenizer_hf.py。
這會產生 vocab.json 與 merges.txt

這些檔案定義了模型的詞彙與合併規則

# 步驟 3：訓練你的模型（nanoGPT）

訓練流程請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)。

你也可以訓練其他 LLM，但我這裡用的是 nanoGPT

# 常見問答

## 什麼是選擇性時代訓練（Selective Temporal Training）？

選擇性時代訓練（STT）是一種機器學習方法，所有訓練數據都經過特定時期的精選。這是為了模擬那個時代的語言與知識，避免現代概念的影響。例如我目前的 v0.5 模型，就是專門用 1800-1875 年的數據從零訓練，所以輸出反映了當時的語言風格與歷史背景。

## 為什麼不用微調或 LoRA？

這個專案的目標是打造不受現代偏見影響的語言模型。如果用 GPT-2 這類預訓練模型微調，現有的現代知識無法完全消除。如果從零開始訓練，模型就不會“假裝”成舊時代，而是本身就是。這個專案目前的目標是打造一個只依據 1800-1850 年倫敦書籍知識來推理的模型。

## 你用什麼數據訓練？

我用的是 1800–1850 年倫敦的書籍、法律文件、報紙和其他著作。我分享的清單大約有 200 份，但第一次訓練只用 50 份、約 187 MB。檔案清單可參考：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 0 版模型有多大？

目前這個模型很小，純粹是為了樂趣而做，並嚴格遵守不使用現代來源的規則。參數數量約 1600 萬，但我會繼續蒐集舊文本，準備開始訓練新模型。進度會隨時更新。

## 訓練規格？

GPU：Geforce rtx 4060
CPU：i5-13400F
記憶體：16GB DDR5。


---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-02

---