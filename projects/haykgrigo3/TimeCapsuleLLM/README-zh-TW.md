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

##  模型行為與限制

### **v0**  

早期提示顯示模型以 1800 年代的語言與行為作出回應。  
範例：提示：「Who art Henry?」模型回覆：「I know that man, I have did not a black, the storm.」

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 未提及現代概念  
- 主要為時代正確的詞彙  
- 句子多數不通順（約 187MB 訓練資料，預期如此）

### **v0.5** 

比 v0 有顯著提升。  
- 維多利亞時代寫作風格，標點正確，句子大多符合語法  
- 事實幻覺率仍高  
- 輸出仍有 OCR 噪音（如 "Digitized by Google"）

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首個能夠回憶並連結資料集中真實歷史事件與實際人物的模型。

範例：提示：「It was the year of our Lord 1834」 

輸出：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

起初我以為抗議活動可能只是巧合發生在同一年，但請看看這個： ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

使用 v2 的 90GB 資料集中的 15GB 樣本訓練。
模型僅訓練到 10K 步。

因分詞有問題，導致輸出如下：

查爾斯·狄更斯是誰？



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
修正後：

「查爾斯・狄更斯是誰？他在劇作、在大公司的農場中，是否展現出更多他那優秀且激勵人心的作品？我還需要引用傑克・皮克特的什麼？你難道不知道他們是一種奔馳的族類，或是拍打胸膛的人，還是說在傑克森正望向窗戶時，應該做些什麼？英國人的成功是什麼，而他的兒子又還沒向我揭示什麼，才能完成這樣的重擔？你是否曾經穿越舊有的車道，或是在我們船隻下方的錨風中停留，這些你都必須離開我們？事實是，不論週六夜晚或正午時分，風會不會從平原上升起，還是往北，或是其他方向，我們都將被迫面對一道強大的屏障，結果和現在一樣。在這種情形下，至少可以說我們已經離開了那個房間。我相信在《五百倍》中有三份副本可供參考，作為我們讀者中首先需要查閱的人……」

### **v2mini-eval2**

使用與eval1訓練相同的15GB樣本訓練。
模型僅訓練至10K步。

PROMPT: 查爾斯・達爾文

查爾斯・達爾文ECCEMACY。先生，—以下這個案例對我很有趣：—我在倫敦待了兩週，並且受到了風濕病發作的影響。第一次風濕病發作是在見您前一週，第二次是在見您時，第三次也是在同一時間。第二次痛風發作時，並未伴隨明顯的發燒症狀，但有尿量增加和排尿變多的現象。第三次發作是在見您一小時後，隨即又發生了一次痛風發作，且痛風復發更快。第四次發作也伴有發燒，但並不總有發燒症狀。第三次痛風發作是在您生病後兩週，第四次則再次出現痛風發作。第四次發作是在您遭遇發病後兩週，並伴隨一種感覺

### **v2**

使用90GB（112GB已標記）資料集訓練
訓練至182K步 

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  數據集

### **v2**

- 90GB（原始）1800-1875年倫敦文本
- 136,344份文件
- 完整標記數據集現已可於此獲取：https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### 偏見統計
  ![代名詞偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![時間偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

更多資訊請參考 [v2 偏見報告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)。


## 如何使用

本專案主要專注於整理歷史數據，將其準備好用於訓練並建立分詞器。我不會涵蓋完整的大型語言模型訓練流程，請參考 Andrej Karpathy 的 nanoGPT。

### 步驟 1：收集並準備歷史文本

- 收集你所選時期的公共領域書籍、文件等的 .txt 檔案（例如：倫敦 1800-1850）
- 保持在你所選的時間/地點範圍內
- 使用腳本或手動清理文本檔案，移除古騰堡計畫的頁首/頁尾、現代註解或如 OCR 錯誤等內容。

### 步驟 2：建立自訂分詞器

- 在清理好的數據上執行 train_tokenizer.py 或 train_tokenizer_hf.py。
- 這會產生 vocab.json 和 merges.txt
- 這些檔案定義了你的模型的詞彙和合併規則

### 步驟 3：訓練你的模型

- 請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 進行訓練流程或你所選架構的文件。

# 常見問題

## 什麼是選擇性時間訓練？

選擇性時間訓練（STT）是一種機器學習方法，所有訓練數據都特別整理為屬於特定歷史時期。這是為了建模該時代的語言和知識，不受現代觀念影響。例如，目前我擁有的模型（v0.5）僅訓練於 1800-1875 年的數據，並非微調，而是從零開始訓練，因此輸出反映該時期的語言風格和歷史背景。

## 為什麼不直接使用微調或 LoRA？

這個專案旨在創建一個不受現代偏見影響的語言模型。如果我微調像 GPT-2 這樣的模型，它已經預先訓練過，這些資訊不會消失。如果我從零開始訓練，語言模型不會假裝成舊時代，而是真正如此。目前此專案的目標是創造一個能夠僅以 1800-1875 年倫敦出版書籍的知識來推理的模型。

## 你用什麼樣的數據來訓練？

我使用的是 1800–1875 年倫敦的書籍、法律文件、報紙及其他著作。我連結的列表（v0）有約 200 份，但第一次訓練只用了 50 個檔案，大約 187 MB。你可以查看文件列表：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

數據集大小：
- v0: 約 187MB
- v0.5: 約 435MB
- v1: 約 6.25GB

- v2mini-eval1：15GB（從 v2 的 90GB 中抽樣）
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
GPU：租用 A100 SXM

### v2mini-eval1/eval2
GPU：租用 A100 SXM

### v2
GPU：租用 H100 SXM

## 致謝

我要感謝 [Dr. Hamed Yaghoobian](https://hamedyaghoobian.com) 提供學術監督、研究框架與評估指導，以及在 v2 版本標記器訓練和資料集準備上的協助。他的回饋與經驗對於本工作的呈現與精煉至關重要。










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---