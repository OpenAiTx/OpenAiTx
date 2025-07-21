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

想像一下，如果AI模型不只是模仿歷史，而是真正「成為」歷史。

基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) ，核心訓練腳本及模型架構均來自於他。

# 專案目標

TimeCapsule LLM 是一個實驗性項目，僅會以特定時期撰寫的文本作為訓練資料。目標是模擬特定歷史時代的世界觀與語言。

# 為什麼微調還不夠

如果你只是微調一個已訓練模型，你的LLM依然會知道現代概念。當然要完全消除現代偏見很難，但我想儘量接近這個目標。想要毫無現代偏見必須從頭訓練模型。

# 預期成果

希望最終這個模型不會知道現代的概念，也無法超出其訓練內容進行推理。它不應該認識現代詞彙／概念，也希望它不會產生現代知識的幻覺。

# 進度更新

## 2025年7月9日

我已設定訓練時期為1800-1850年，地區：倫敦

我已蒐集了一份文本、書籍、文件清單

目前我已獲得50份txt檔案，即將開始訓練NanoGPT

只要有進展我會持續更新

## 2025年7月13日

以187MB的歷史文本資料訓練了nanoGPT。

## 2025年7月15日

我開始下載第二次訓練用的文本。我正從Internet Archive取得所有資料，並將訓練時期擴展到1800-1875年。為了取得多樣化文本，你可以在Internet Archive用出版地點、時期、主題等篩選條件。

![搜尋篩選條件](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我從Internet Archive下載了約500個txt檔，清理後（只刪除空白、Gutenberg標頭等）大約有500MB數據。這還是個小型資料集，但上次訓練只有187MB，所以這次訓練第二個模型後應該會有明顯的輸出差異。我希望這個模型至少能產生更有條理且大致合理的句子。當然這不是保證，畢竟還是很小的資料集，但比我上次用的多了。

這應該可以在我自己的硬體上完成，也好，因為我可以在跳到更大資料集（需要租用GPU）前，先看到一些改進。但別擔心，我仍計劃很快租GPU，不過在那之前我想確保資料集盡可能精選且乾淨。我遇到的問題之一就是清理，很多txt檔裡混有亂碼。我用來清理的腳本有效，但不是百分之百。

我今天會用這個資料集訓練，大概需要4-5小時。訓練完成並測試後會提供更新。再次感謝所有關注我專案的人，甚至有人給我OCR資源連結，謝謝！希望更多人能試試這個方法，用自己的資料集來實驗。

### 訓練更新

我用一個435MB（1.08億個字元）的語料庫開始訓練，目前進展順利。訓練損失從10.9降到4.9（前2800次迭代）。預計總共需8至9小時完成。完成後我會再發佈更新。

## 2025年7月17日 2:13AM

第二版模型訓練完成，我的4060花了約8小時40分鐘（每小時3900次迭代），總共33,000次迭代（5個epoch）。最終訓練損失為3.73。輸出結果令人驚喜，現在能夠產生連貫的19世紀風格句子。

# V0模型行為與限制

初步測試發現模型會用1800年代的語言及行為回應。例如，我以「Who art Henry?」作為提示，它回覆「I know that man, I have did not a black, the storm.」，雖然這句話沒什麼意義，但LLM已能辨識我是在問某人。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

沒有出現現代概念，輸出大多是1800年代的詞彙與措辭。

還需要很多改進，僅用187MB訓練無法得到能做複雜推理的模型。

現在產生的句子缺乏完整結構，總體上也沒什麼意義，不過這對這種訓練規模而言是正常現象。

# V0.5 模型行為與限制

這相比上一個模型有了不錯的提升。寫作風格和詞彙都是維多利亞時代的，幾乎每一句話在語法和標點上都正確。這個模型是從零開始訓練的，所以它只涉及 1800 年代的主題。

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

有很多事實性幻覺。很多（幾乎是 100%）細節（日期、事件、歷史人物）都是編造的。而且句子之間彼此沒有什麼關聯，有時也許兩句話有關，但大多數時候都沒有。另一個問題是有時會出現一些像“Digitized by Google”這樣的浮水印，所以下次訓練時我真的要確保文本徹底清理。總體來說我對結果很滿意，雖然還遠不是 LLM，但絕對是一個句子生成器。

我學到了很多，接下來幾週會開始思考該如何改進。我很快會上傳檔案！

# 即將到來的計畫

（已完成）我將開始進行 0.5 版的工作，這次不是用 50 本書訓練，而是理想上用 500-600 本。現在我正在用 1800-1850 年間倫敦的書籍訓練 nanoGPT。主要挑戰是確保我找到的書沒有經過改編或現代詮釋，而是我選定時期內原汁原味的出版物。

我想用更大的語料庫訓練一個新模型（v1），大概是 v0.5 用的 5-10 倍。我的目標是觀察僅靠選擇性時代訓練能否激發推理能力，這會更困難，我也不確定是否可能，因為歷史數據有限。接下來幾週我會嘗試整理出一個 5-10GB 的語料庫。我相信如果能獲得乾淨且高品質的數據並租用一張 GPU，應該會有所進展。

# 如何使用本專案

本專案主要專注於歷史數據的整理、預處理及建立分詞器。我不會覆蓋完整 LLM 訓練過程，這部分請參考 Andrej Karpathy 的 nanoGPT。

# 第一步：收集並準備歷史文本

蒐集選定時期（如倫敦 1800-1850 年）的公有領域書籍、文件等 .txt 檔。

如有需要，可以用 download_texts_improved.py 幫你下載書籍。

用腳本或手動清理文本檔，移除 Project Gutenberg 的標頭/頁腳、現代註釋或 OCR 錯誤等內容。

prepare_dataset.py 應該可以正常運作。

# 第二步：建立自訂分詞器

在清理過的數據上運行 train_tokenizer.py 或 train_tokenizer_hf.py。
這會生成 vocab.json 和 merges.txt

這些檔案定義了模型的詞彙和合併規則

# 第三步：訓練你的模型（nanoGPT）

訓練過程請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT)。

你也可以訓練其他 LLM，但我用的是 nanoGPT

# 常見問題

## 什麼是選擇性時代訓練？

選擇性時代訓練（STT）是一種機器學習方法，所有訓練數據都經過特別整理，只涵蓋特定歷史時期。這是為了模擬該時代的語言和知識，不受現代概念的影響。例如，我現在的模型（v0.5）就只用 1800-1875 年的數據訓練，完全從零開始，所以產出的內容反映了當時的語言風格和歷史背景。

## 為什麼不用微調或 LoRA？

這個專案是要打造一個不受現代偏見影響的語言模型。如果用 GPT-2 微調，它已經預訓練過，舊資訊不會消失。如果從零開始訓練，語言模型就不是假裝舊，而是真的舊。這個專案目前的目標，是製作一個只能用 1800-1850 年倫敦書籍知識推理的模型。

## 你用什麼數據訓練？

我用的是 1800-1850 年倫敦的書籍、法律文件、報紙和其他文獻。我連結的清單有約 200 份，但首次訓練只用 50 個檔案，約 187 MB。你可以查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 第 0 版模型有多大？

這個模型目前非常小，我只是為了好玩並嚴格遵守不使用現代資料的訓練規則。它有將近 1600 萬個參數，但我會開始收集更多舊文本來訓練新模型。之後會隨時更新進度。

## 訓練規格？

GPU：Geforce rtx 4060
CPU：i5-13400F
記憶體：16GB DDR5。



---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-07-21

---