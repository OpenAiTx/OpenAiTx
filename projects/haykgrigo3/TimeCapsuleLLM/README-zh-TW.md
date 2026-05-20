<div align="right">
  <details>
<summary>🌐 語言</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# TimeCapsule LLM

*一個完全**從頭開始**訓練的語言模型，僅使用特定地點與時期的資料，以減少現代偏見並模仿該時代的語調、詞彙與世界觀。*

想像一下，如果 AI 模型不只是裝作歷史性，而是真的歷史性。

v0 和 v0.5 基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 核心訓練腳本與模型架構來自他的作品。

v1 基於 [Microsoft 的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)

v2 基於 llamaforcausallm

[Hugging Face 連結](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## 研究狀態
本專案是獨立發起與開發的。

目前在學術監督下進行，並與穆倫堡學院有合作研究。

## 引用

若您於學術作品中使用此資料集或模型，請引用：


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

## 加入 Vintage LLM Discord

如果你對**歷史語言模型**、**特定時期資料集**，或像**TimeCapsuleLLM**、**Violet-1.4B**、**Mr. Chatterbox**這樣的項目未來感興趣，歡迎加入社群。

我們使用這個伺服器來討論想法、分享進展，並與其他在這個領域打造產品的人交流。

[加入 Discord](https://discord.gg/JeWkk4z5)

## 模型行為與限制

### **v0**  

早期提示顯示模型以 1800 年代的語言和行為作回應。
範例：提示：「Who art Henry?」模型回覆：「I know that man, I have did not a black, the storm.」

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 不會提及現代概念  
- 多數使用該時代準確詞彙  
- 句子大多不通順（約 187MB 訓練資料，屬預期結果）

### **v0.5-london** 

比 v0 有顯著提升。
- 維多利亞時期寫作風格，適當標點符號，多數語法正確的句子  
- 仍有高比例事實幻覺  
- OCR 雜訊（如「Digitized by Google」）仍會出現在輸出中

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1-london**

首個能回憶並連結資料集內真實歷史事件與人物的模型。

範例：提示：「It was the year of our Lord 1834」

輸出：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」 

一開始我以為抗議只是巧合地發生在同一年，但請看看這個： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1-london**

使用來自 v2 的 90GB 數據集中的 15GB 樣本進行訓練。
模型僅訓練至 10K 步。

在分詞處理時出現了一個問題，導致輸出看起來像這樣：

提示：
查爾斯·狄更斯是誰？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

更正：

「查爾斯·狄更斯是誰？他的作品是否在大公司的農場裡發揮了更多的優秀與激動人心？我還需要引用傑克·皮克特什麼內容？你難道不知道他們是一種奔馳的物種，或是在胸口鋸割，或者在傑克森望著窗戶時應該做些什麼？一個英國人的成功是什麼？他的兒子尚未向我發現的是什麼，藉此完成如此重大的事？你曾經進入過老路，或者在我們船的底部錨風處停留過，必須離開我們嗎？事實是，不論週六晚上還是中午，或北方，或其他時候，風會從平原升起，我們都將被迫描述一個強大的障礙，其效果與現在相同。在這種情況下，至少可以說我們已經離開那個房間。我相信在《五百倍》中有三份副本可供參考，作為我們讀者中第一批想要...」

### **v2mini-eval2-london**

使用與eval1相同的15GB樣本訓練。
模型同樣僅訓練至10K步。

PROMPT:查爾斯·達爾文

查爾斯·達爾文ECCEMACY。先生——以下案例令我感興趣：——我在倫敦待了兩週，並因風濕病發作而深受影響。第一次風濕病發作是在我見您之前的一週，第二次是在我見您時，第三次也是在我見您時，並且第三次與前次時間相同。然而，第二次痛風發作並未伴隨任何發熱症狀，但卻伴隨尿液增多以及更大量的尿液排出。第三次發作是在我見您一小時後，並伴隨痛風發作復發及痛風更迅速復發。第四次發作也伴有發燒，但並不總是伴隨任何發熱症狀。第三次痛風發作是在您生病兩週後，第四次則伴隨痛風發作復發。第四次發作是在您被攻擊兩週後，並伴有一種感覺

### **v2-london**

使用90GB（112GB經過標記化）數據集訓練
訓練至182K步

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

### **接下來是什麼？**

- TimeCapsuleLLM v3已開始開發
- 擴大數據集規模及地理覆蓋範圍
- 擴展至倫敦以外的更多城市

此項工作與倫敦大學學院（UCL）的研究人員合作進行，並正在討論更多機構參與。 


##  數據集

### **v2**

- 90GB（原始）1800-1875年倫敦文本
- 136,344份文件
- 完整標記化數據集現已提供：https://huggingface.co/datasets/postgrammar/london-llm-1800

### 偏差統計
  ![代名詞偏差](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏差](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![時間偏差](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

請參閱 [v2 偏差報告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) 以獲得更多資訊。


-


## 如何使用

本項目主要專注於策劃歷史數據、準備訓練資料以及建立分詞器。本文不會涵蓋完整的大型語言模型訓練流程，若需了解請參考 Andrej Karpathy 的 nanoGPT。

### 步驟一：收集與準備歷史文本

- 收集你所選時期（如倫敦 1800-1875）的公共領域書籍、文件等 .txt 檔案
- 保持資料在你選擇的時空範圍內
- 使用腳本或手動清理文本檔案，移除 Project Gutenberg 的標頭/尾註、現代註解或 OCR 錯誤等內容

### 步驟二：建立自定義分詞器

- 在清理過的資料上執行 train_tokenizer.py 或 train_tokenizer_hf.py
- 這會產生 vocab.json 和 merges.txt
- 這些檔案定義了模型的詞彙與合併規則

### 步驟三：訓練你的模型

- 請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 的訓練流程或你選擇的架構文件

# 常見問題

## 什麼是選擇性時間訓練？

選擇性時間訓練（Selective Temporal Training，STT）是一種機器學習方法，所有訓練數據都特別策劃於特定歷史時期內。這樣做是為了模擬那個時代的語言與知識，不受現代概念影響。例如，目前我所擁有的模型（v0.5）僅基於 1800-1875 年的資料訓練，並非微調，而是從零開始訓練，因此能夠產出反映當時語言風格與歷史背景的內容。

## 為什麼不直接使用微調或 LoRA？

對於這個專案，我的目標是打造一個不受現代偏見影響的語言模型。如果我微調像 GPT-2 這樣的模型，它已經預先訓練過，這些資訊不會消失。如果我從零開始訓練，語言模型不會假裝是舊的，它就是舊的。這個專案目前的目標是創建一個只用 1800 到 1875 年間倫敦出版書籍的知識來推理的模型。

## 你用什麼樣的數據來訓練？

我使用了 1800–1875 年倫敦的書籍、法律文件、報紙和其他著作。我附上的清單（v0 版）大約有 200 份，但第一次訓練我只用了 50 份檔案，約 187 MB。你可以在這裡查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

數據集大小：
- v0：約 187MB
- v0.5：約 435MB 
- v1：約 6.25GB 
- v2mini-eval1：15GB（v2 的 90GB 之樣本）
- v2：90GB

## 模型有多大？

v0：1,600 萬參數

v0.5：1.23 億參數

v1：7 億參數

v2mini-eval1：3 億參數

v2mini-eval2：2 億參數

v2：12 億參數

## 訓練規格？

### v0/v0.5
GPU：Geforce rtx 4060
CPU：i5-13400F 
記憶體：16GB DDR5。

### v1
GPU：A100 SXM（租用）

### v2mini-eval1/eval2
GPU：A100 SXM 租用

### v2
GPU：H100 SXM 租用

## 相關工作

- **[talkie-1930-13b](https://talkie-lm.com/introducing-talkie)**
  -  13B 參數的 LLM，使用 1930 年以前的 2600 億字文本進行 Q&A 訓練。另有 [base](https://huggingface.co/talkie-lm/talkie-1930-13b-base) 版本。
 
- **[Violet 1.4B](https://huggingface.co/zakarth/violet-1b4-chat)**
  -  1.4B 參數的 LLM，使用 1800-1899 年的文本進行 Q&A 訓練。另有 [160M](https://huggingface.co/zakarth/violet-160m-chat) 版本。
 
- **[Mr. Chatterbox](https://huggingface.co/tventurella/mr_chatterbox_model)**
  -  340M 參數的 LLM，訓練於 1837-1899 年間超過 28,000 篇文本，並進行 Q&A。
 
- **[Ranke-4B](https://github.com/DGoettlich/history-llms/blob/main/ranke-4b/prerelease_notes.md)** 
  - 一系列基於 Qwen3 架構、4B 參數的 LLM，從零開始以 800 億個歷史數據字元訓練，知識截止年分分別為 1913、1929、1933、1939、1946。
 
- **[MondadGPT](https://huggingface.co/Pclanglais/MonadGPT)** 
  - MonadGPT 是以 Mistral-Hermes 2 微調於 11,000 篇早期現代英文、法文及拉丁文文本（主要來自 EEBO 與 Gallica）。

## 致謝

感謝 [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) 提供學術指導、研究框架與評估建議，並協助 v2 版本的 tokenizer 訓練與資料集準備。他的回饋與經驗對於完善本工作的呈現至關重要。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-05-20

---