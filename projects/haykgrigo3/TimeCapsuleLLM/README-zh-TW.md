
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
        | <a href="#" title="Coming soon">印地語（即將推出）</a> |
        | <a href="#" title="Coming soon">泰語（即將推出）</a> |
        | <a href="#" title="Coming soon">法語（即將推出）</a>
        | <a href="#" title="Coming soon">德語（即將推出）</a>
        | <a href="#" title="Coming soon">西班牙語（即將推出）</a>
        | <a href="#" title="Coming soon">義大利語（即將推出）</a>
        | <a href="#" title="Coming soon">俄語（即將推出）</a>
        | <a href="#" title="Coming soon">葡萄牙語（即將推出）</a>
        | <a href="#" title="Coming soon">荷蘭語（即將推出）</a>
        | <a href="#" title="Coming soon">波蘭語（即將推出）</a>
        | <a href="#" title="Coming soon">阿拉伯語（即將推出）</a>
        | <a href="#" title="Coming soon">波斯語（即將推出）</a>
        | <a href="#" title="Coming soon">土耳其語（即將推出）</a>
        | <a href="#" title="Coming soon">越南語（即將推出）</a>
        | <a href="#" title="Coming soon">印尼語（即將推出）</a>

      </div>
    </div>
  </details>
</div>

# TimeCapsule LLM
一款僅以特定時期資料訓練的大型語言模型，旨在減少現代偏見。

想像一下，如果 AI 模型不僅僅是模仿歷史，而是真正具備歷史性。

基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 核心訓練腳本與模型架構均來自他的作品。

# 專案目標
TimeCapsule LLM 是一個實驗性專案，只會訓練在某些特定時期撰寫的文本。目標是模擬特定歷史時代的世界觀和語言。

# 為什麼微調還不夠

如果你只是微調一個預訓練模型，你的 LLM 仍然會知道現代概念。當然，實現完全零現代偏差很困難，但我想盡可能接近這一點。要做到沒有現代偏差，需要從零開始訓練一個模型。

# 預期成果

希望完成後，這個模型不會知道現代概念，也無法超越其訓練內容來推理。它不應該識別現代概念/詞彙，也不應該幻覺現代知識。

# 進度更新

## 2025年7月9日

我已設定訓練時期為1800-1850年，地區：倫敦

我已收集一份文本、書籍、文件清單

目前已經取得50個txt檔案，並即將開始訓練NanoGPT

只要有進展都會在此更新

## 2025年7月13日

用187MB的歷史文本數據訓練了nanoGPT。

## 2025年7月15日

我開始下載第二次訓練所需的文本。我從 Internet Archive 取得所有資料，並將時期擴展至1800-1875年。為了取得多元文本，可以在 Internet Archive 使用主題與搜尋篩選器來篩選出版地點、時間和主題。

![搜尋篩選器](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/searchfilter.jpg)

## 2025年7月16日

我從 Internet Archive 下載了約500個txt檔案，清理（僅刪除空白、Gutenberg標頭等）後約有500MB數據。這是一個很小的資料集，但上次我只用187MB訓練，因此這次訓練第二個模型後，輸出應該至少會有些明顯差異。我希望這個模型至少能產生更有條理、比較有邏輯的句子。當然這並不是保證，因為資料集還是非常小，但已經比上次多了。

這應該可以在我自己的硬體上完成，也很好，因為我希望在跳到更大資料集前能看到一些改進。更大的資料集需要租用GPU。但別擔心，我還是打算很快租GPU，在此之前我想確保我的資料集儘可能精選且乾淨。我遇到的一個問題是清理，很多txt檔裡混入了亂碼。我用來清理的腳本確實有效，但並非百分之百有效。

我今天會用這個資料集訓練，預計需要4-5小時。一旦完成並測試後我會給出更新。再次感謝所有關注我專案的人，甚至有人給我OCR資源連結，所以謝謝你們！我希望更多人嘗試並用自己的資料集來實驗。


## 2025年8月12日

版本1已經完成，這個版本採用Phi 1.5（700M參數），並在一個包含近7000篇文本的資料集上進行訓練。此模型的主要改進在於它有時能夠引用真實的人名與歷史事件。版本0和0.5無法做到這一點，當我提示那些模型類似「在1821年」時，輸出只會是幻覺，都是從未發生過的事情。以下是版本1的範例：

我的提示：主的1834年，

輸出：「主的1834年，倫敦街頭充滿了抗議與請願。原因如許多人所述，並非私事，而是在帕麥斯頓勳爵的同一天發生，公眾將會收到法律困難的簡短聲明。令人深感遺憾的是，當今世界歷史上的事件已然明朗，因此將被知曉。並非事實的是，最早在耶路撒冷定居福音的人竟然留下如此廣泛且有趣的繁榮記錄。」

起初我以為這可能是巧合，但請看看這個： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)


### 訓練更新

我開始在一個435MB（1.08億標記）語料庫上訓練，目前進展相當順利。訓練損失在前2800次迭代中從10.9降至4.9。我預計大約需要8至9小時完成。完成後我會再發布更新。

## 2025年7月17日

第二個模型的訓練已完成，我的4060花了約8小時40分鐘（每小時3900次迭代）進行了33,000次迭代（5個世代）。最終訓練損失為3.73。輸出效果令人驚訝，現在確實能生成連貫的19世紀風格句子。

## 2025年7月28日

我已經將v0.5上傳至Hugging Face，[歡迎查看](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)。你現在可以下載我的倉庫並在本地運行。不幸的是nanoGPT無法與HuggingFace原生兼容，所以你必須下載並在本地運行模型。

同時我將開始為下一次訓練整理資料，我認為要實現推理能力可能需要5-10倍的數據量。

## 2025年8月2日

我很快就要開始開發版本1。需要從nanoGPT的架構過渡到更現代的模型。我考慮了幾種開源LLM架構，包括：OpenLLaMA v3、Phi-2和Qwen 1.5B。為了支援升級到V1，我必須仔細整理一個更大且多元的資料集。至少需要5GB乾淨的訓練數據。

# V0模型行為與限制

早期提示顯示模型會用19世紀語言和風格回應。例如，我提示它「Who art Henry?」時，它回覆「I know that man, I have did not a black, the storm.」這句話雖然語意不通，但LLM能夠辨識我在詢問一個人。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

沒有提及現代概念，輸出主要包含19世紀的單詞與語法。

仍然需要大量改進，僅用187MB資料訓練無法讓模型產生具有複雜推理能力的文本。

目前它產生的句子缺乏完整的句子結構，整體上也毫無意義，但這對於這種訓練規模來說是正常的。

# V0.5 模型行為與限制

這比上個模型有了明顯的進步。寫作風格和詞彙屬於維多利亞時代，幾乎每個句子都符合文法且有正確標點。而且這是從零開始訓練的，所以主題都集中在1800年代。

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

事實性幻覺非常多。很多（幾乎100%）細節（日期、事件、歷史人物）都是虛構的。另外，句子之間基本沒有連貫性，有時可能有兩句相關，但除此之外就沒有了。另一個問題是有時會出現“Digitized by Google”這種雜亂的頁腳，所以下次訓練時我一定要確保文本徹底清理。整體來說我對結果很滿意，雖然還遠遠稱不上LLM，但確實已經是一個句子生成器。

我學到了很多，未來幾週會開始思考需要改進哪些地方。很快會上傳相關檔案！

# V1 模型行為與限制

我很快會上傳一些範例輸出，並用相同提示詞對三個模型做比較。我也會像上次一樣把V1上傳到huggingface，你可以在這裡找到我的huggingface帳號：https://huggingface.co/haykgrigorian/TimeCapsuleLLM

# 未來計畫

（已完成）我打算開始做0.5版，這次不是用50本書訓練，而是理想上用500到600本。目前我正用1800-1850年出版、專屬倫敦的書籍在訓練nanoGPT。面臨的挑戰有確保找到的書沒有現代修訂或解讀，而是完全未經改動、發行於選定時期的書。

我想用更大語料庫訓練新模型（v1），規模可能是v0.5的5到10倍。我的目標是觀察僅靠選擇性時代訓練是否能產生推理能力，這會更困難，我也不能完全確定是否可行，因為歷史資料有其限制。未來幾週我會嘗試整理5-10GB的數據。我相信只要能取得乾淨高品質的資料並租用GPU，會有進展。

# 如何使用本專案

本專案主要聚焦於整理歷史數據、資料訓練準備以及製作分詞器。不會涵蓋完整的LLM訓練流程，這部分請參考Andrej Karpathy的nanoGPT。

# 步驟一：蒐集與準備歷史文本

收集你選定時期（如倫敦1800-1850年）的公有領域書籍、文件等.txt檔案。

如果需要，你可以用 download_texts_improved.py 幫你下載書籍。

用腳本或手動清理文本檔案，去除古騰堡計畫的標頭/頁腳、現代註釋或OCR錯誤等。

prepare_dataset.py 應該能正常運作。

# 步驟二：建立自訂分詞器

在清理後的數據上運行 train_tokenizer.py 或 train_tokenizer_hf.py。
這將產生 vocab.json 和 merges.txt。
這些檔案定義了您的模型的詞彙和合併規則

# 步驟三：訓練您的模型（nanoGPT）

請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 來進行訓練流程。

如果您願意，也可以訓練其他 LLM，但我使用的是 nanoGPT

# 常見問題集

## 什麼是選擇性時代訓練？

選擇性時代訓練（Selective Temporal Training，STT）是一種機器學習方法論，所有訓練資料都特別策劃於某一特定歷史時期內。這麼做是為了建模該時代的語言和知識，避免受到現代概念的影響。例如，目前我使用的模型（v0.5）僅訓練自 1800-1875 年的資料，並非微調而是從零開始訓練，最終輸出反映出該時期的語言風格和歷史背景。

## 為什麼不直接用微調或 LoRA？

本專案目標是創造一個不受現代偏見影響的語言模型。如果我微調像 GPT-2 這樣的模型，它已經被預訓練過，那些資訊不會消失。如果我從零開始訓練，語言模型不會假裝是舊的，而是真正就是舊的。此專案目前的目標是創建一個僅能以 1800 至 1850 年間倫敦出版書籍的知識進行推理的模型。

## 訓練時使用了什麼樣的資料？

我使用了 1800–1850 年間倫敦的書籍、法律文件、報紙和其他文獻。我連結的清單大約有 200 份，但第一次訓練只用了 50 個檔案，約 187 MB。您可以查看文檔清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

## 模型有多大？

V0：16M 參數

V0.5：123M 參數

V1：700M 參數

# 訓練規格？

#V0/V0.5
GPU：Geforce rtx 4060
CPU：i5-13400F 
記憶體：16GB DDR5。

#V1

GPU: A100 rented









---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-12

---