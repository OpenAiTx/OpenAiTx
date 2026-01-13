<div align="right">
  <details>
    <summary >🌐 語言</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">English</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">简体中文</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW">繁體中文</a> 
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">日本語</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">한국어</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as">हिन्दी</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th">ไทย</a> 
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr">Français</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de">Deutsch</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es">Español</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it">Italiano</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru">Русский</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt">Português</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl">Nederlands</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl">Polski</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar">العربية</a>
        | <a href="#" title="Coming soon">فارسی (coming soon)</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr">Türkçe</a>
        | <a href="https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi">Tiếng Việt</a>
        | <a href="#" title="Coming soon">Bahasa Indonesia (coming soon)</a>

      </div>
    </div>
  </details>
</div>


# TimeCapsule LLM

*一個**從零開始訓練**，僅使用特定地點與時期資料的大型語言模型，旨在減少現代偏見並模擬該時代的語言風格、詞彙與世界觀。*

想像一下，如果一個 AI 模型不只是「假裝」是歷史的，而是「真的」來自歷史。

v0 和 v0.5 基於 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 開發，核心訓練腳本與模型架構來自他。

v1 建立於 [Microsoft 的 Phi 1.5](https://huggingface.co/microsoft/phi-1_5)

v2 建立於 llamaforcausallm

[Hugging Face 連結](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  模型行為與限制

### **v0**  

早期提示顯示模型以 1800 年代的語言和行為作答。
範例：提示：「Who art Henry?」模型回覆：「I know that man, I have did not a black, the storm.」

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- 不提及現代概念  
- 多為時代準確詞彙  
- 句子大多不通順（約 187MB 訓練資料，屬預期現象）

### **v0.5** 

較 v0 有顯著提升。  
- 維多利亞時代文風，標點正確，句子多為文法正確  
- 仍有高比率事實幻覺  
- 輸出仍有 OCR 噪音（如「Digitized by Google」）

![TimeLockLLM 範例輸出](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

首個能回憶並連結資料集真實歷史事件與人物的模型。

範例：提示：「It was the year of our Lord 1834」

輸出：「It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity」

一開始我以為抗議活動只是在同一年巧合發生，但請看看這張圖：![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**


使用 v2 90GB 資料集中的 15GB 樣本進行訓練。
模型僅訓練至 10K 步。

在分詞過程中出現了一個問題，導致輸出看起來像這樣：

提示：
查爾斯·狄更斯是誰？


W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht

修正：

「誰是查爾斯·狄更斯？他的那些傑出激勵作品，在他的劇作、在大公司的農場中，是不是更有成效？我還要引用傑克·皮克特的哪些話？你難道不知道他們是一種疾馳，或是自我捶胸，或是在傑克森看著窗戶的時候該做些什麼？一個英國人的成功是什麼，他的兒子至今還沒向我揭示，藉此完成如此重大的目標？你可曾走過舊馬路，或是在我們船的船腳拋錨時感受到微風，你必須離開我們？事實是，無論週六夜晚或中午，風吹會不會從平原升起，或是吹向北方，或其他方向，我們將被迫描述一堵強大的屏障，效果與現狀相同。在這種情況下，至少可以說我們已離開那個房間。我相信在《五百倍》中有三份副本可供參考，作為希望...的首批讀者。」

### **v2mini-eval2**

使用與 eval1 相同的 15GB 樣本進行訓練。
模型同樣僅訓練到 10K 步。

PROMPT:查爾斯·達爾文

查爾斯·達爾文ECCEMACY。先生，——以下案例令我感到有趣：——我在倫敦待了兩星期，並深受風濕發作所影響。第一次風濕發作是在我見您一週前，第二次是在我見您時，第三次也是在我見您時，且第三次與前兩次同時發生。然而，第二次痛風發作並未伴隨任何熱症，而是伴隨尿量增加，並且尿液排放更為豐富。第三次發作是在我見您一小時後，隨後出現痛風發作與更快的痛風復發。第四次發作也伴隨著發燒，但並不總有熱症。第三次痛風發作是在您生病兩週後，第四次則是痛風復發。第四次發作是在您遭受攻擊後的兩週，並伴隨一種感覺


##  數據集

### **v2**

- 90GB 1800-1875 年倫敦文本
- 136,344 份文件
- 這 90GB 的完整數據尚未提供，因為尚未完成分詞，但你可以在此找到 15GB 樣本：https://huggingface.co/datasets/haykgrigorian/TimeCapsuleLLM-London-1800-1875-v2-15GB

 ### 偏見統計 
  ![代詞偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![地理偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![時間偏見](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

詳細資訊請參閱 [v2 偏見報告](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json)。


## 使用方法

本項目主要聚焦於歷史資料的整理、訓練前的準備與分詞器的構建。完整的大型語言模型訓練流程不在此覆蓋，請參考 Andrej Karpathy 的 nanoGPT。

### 步驟 1：收集與準備歷史文本 

- 收集所選時期（如倫敦 1800-1850 年）的公共領域書籍、文檔等 .txt 檔案
- 將它們保持在你選擇的時間/地點範圍內  
- 使用腳本清理文本檔案或手動移除古騰堡計劃、現代註釋或類似 OCR 錯誤的頁首/頁尾。

### 步驟2：建立自訂分詞器

- 在清理過的資料上執行 train_tokenizer.py 或 train_tokenizer_hf.py。
- 這將產生 vocab.json 和 merges.txt
- 這些檔案定義了你模型的詞彙和合併規則

### 步驟3：訓練你的模型

- 請參考 [Andrej Karpathy 的 nanoGPT](https://github.com/karpathy/nanoGPT) 訓練流程或你選擇的架構文件。

# 常見問題

## 什麼是選擇性時期訓練？

選擇性時期訓練（Selective Temporal Training，STT）是一種機器學習方法，所有訓練數據都特別挑選自特定歷史時期。這樣做是為了讓模型學習當時代的語言和知識，而不受現代理念影響。例如，我目前的模型（v0.5）僅用 1800-1875 年的資料訓練，並非微調，而是從頭訓練，因此輸出能反映該時期的語言風格與歷史背景。

## 為什麼不用微調或 LoRA？

這個專案的目標是建立一個不受現代偏見影響的語言模型。如果我用 GPT-2 之類的模型進行微調，它已經預訓練過，這些資訊無法抹去。如果從零開始訓練，語言模型就不會假裝是舊的——它本身就是舊的。目前這個專案的目標是創造一個只能以 1800 到 1875 年倫敦出版書籍知識來推理的模型。

## 你用什麼數據訓練？

我使用的是 1800–1875 年倫敦的書籍、法律文件、報紙及其他著作。我連結的清單（v0）大約有 200 份，但首次訓練只用了約 50 個檔案，約 187 MB。你可以在這裡查看文件清單：
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

資料集大小：
- v0: 約 187MB
- v0.5: 約 435MB 
- v1: 約 6.25GB 
- v2mini-eval1: 15GB

## 模型有多大？

v0：1,600 萬參數

v0.5：1.23 億參數

v1: 700M Parameters

v2mini-eval1: 300M Parameters

# Training Specs ? 

# v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# v1
GPU: A100 SXM rented

# v2mini-eval1

GPU: A100 SXM rented






























---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-01-13

---