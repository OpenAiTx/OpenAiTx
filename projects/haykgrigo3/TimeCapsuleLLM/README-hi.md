
<div align="right">
  <details>
    <summary >🌐 भाषा</summary>
    <div>
      <div align="center">
        <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=en">अंग्रेज़ी</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN">सरलीकृत चीनी</a>
        | <a href="#" title="Coming soon">पारंपरिक चीनी (जल्द आ रहा है)</a> |
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja">जापानी</a>
        | <a href="https://openaitx.github.io/view.html?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko">कोरियाई</a>
        | <a href="#" title="Coming soon">हिन्दी (जल्द आ रहा है)</a> |
        | <a href="#" title="Coming soon">थाई (जल्द आ रहा है)</a> |
        | <a href="#" title="Coming soon">फ्रेंच (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">जर्मन (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">स्पेनिश (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">इटालियन (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">रूसी (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">पुर्तगाली (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">डच (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">पोलिश (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">अरबी (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">फारसी (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">तुर्की (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">वियतनामी (जल्द आ रहा है)</a>
        | <a href="#" title="Coming soon">इंडोनेशियाई (जल्द आ रहा है)</a>

      </div>
    </div>
  </details>
</div>

# टाइमकैप्सूल LLM

*एक भाषा मॉडल जो **शुरू से** विशेष स्थानों और समय अवधियों के डेटा पर प्रशिक्षित किया गया है ताकि आधुनिक पक्षपात को कम किया जा सके और उस युग की आवाज़, शब्दावली और दृष्टिकोण का अनुकरण किया जा सके।*

कल्पना कीजिए कि अगर एक एआई मॉडल केवल ऐतिहासिक बनने का दिखावा नहीं करता, बल्कि वास्तव में ऐतिहासिक होता।

v0 और v0.5 [Andrej Karpathy के nanoGPT](https://github.com/karpathy/nanoGPT) पर बनाए गए हैं। मुख्य प्रशिक्षण स्क्रिप्ट और मॉडल संरचना उन्हीं का कार्य है।

v1 [Microsoft के Phi 1.5](https://huggingface.co/microsoft/phi-1_5) पर आधारित है

[Hugging Face लिंक](https://huggingface.co/haykgrigorian/TimeCapsuleLLM)

##  मॉडल व्यवहार और सीमाएँ

### **v0**  

शुरुआती प्रॉम्प्ट्स में मॉडल 1800 के दशक की भाषा और व्यवहार में प्रतिक्रिया देता है। 
उदाहरण: प्रॉम्प्ट: "Who art Henry?" और उत्तर: "I know that man, I have did not a black, the storm."

![TimeLockLLM नमूना आउटपुट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- आधुनिक अवधारणाओं का कोई उल्लेख नहीं  
- अधिकांश शब्दावली युग-संगत है  
- वाक्य अक्सर असंगठित होते हैं (~187MB प्रशिक्षण डेटा के लिए अपेक्षित)

### **v0.5** 

v0 की तुलना में महत्वपूर्ण सुधार।
- विक्टोरियन लेखन शैली, उचित विराम चिह्न, अधिकांश वाक्य व्याकरणिक  
- तथ्यात्मक कल्पना दर अभी भी अधिक  
- OCR शोर (“Digitized by Google”) अभी भी आउटपुट में मौजूद

![TimeLockLLM नमूना आउटपुट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

पहला मॉडल जो डेटासेट से वास्तविक ऐतिहासिक घटना और उससे जुड़े व्यक्ति को याद और जोड़ सका।

उदाहरण: प्रॉम्प्ट: "It was the year of our Lord 1834"

आउटपुट: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

पहले मुझे लगा कि उसी वर्ष कोई विरोध प्रदर्शन संयोगवश हुआ होगा, लेकिन यह देखिए: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### यह क्यों महत्वपूर्ण है:

यह मेरे मॉडल्स का पहला उदाहरण है जहाँ किसी वर्ष को एक वास्तविक ऐतिहासिक घटना और उस घटना से जुड़े वास्तविक व्यक्ति (Lord Palmerston) से जोड़ा गया। पहले के मॉडल्स (v0 और v0.5) 19वीं सदी की लेखन शैली की नकल कर सकते थे लेकिन घटनाओं, लोगों और तथ्यों को हमेशा कल्पना करते थे। इससे पता चलता है कि मॉडल अब डेटासेट से चीजें याद रखना शुरू कर रहा है।


## आगामी योजनाएँ

- इंटरनेट आर्काइव पर 1800-1875 के बीच लंदन में प्रकाशित लगभग 175,000 ग्रंथ उपलब्ध हैं
- मैं इस कॉर्पस को विस्तार देने और इसे बेहतर तर्क क्षमताओं के लिए और अधिक साफ करने की योजना बना रहा हूँ
- अधिक ऐतिहासिक मॉडल के लिए विभिन्न क्षेत्रों और समय अवधियों में विस्तार

## उपयोग कैसे करें

यह प्रोजेक्ट मुख्य रूप से ऐतिहासिक डेटा को संकलित करने, प्रशिक्षण के लिए तैयार करने और एक टोकनाइज़र बनाने पर केंद्रित है। मैं पूरी LLM प्रशिक्षण प्रक्रिया को कवर नहीं करने जा रहा हूँ, उसके लिए Andrej Karpathy की nanoGPT देखें।

### चरण 1: ऐतिहासिक ग्रंथ एकत्रित करें और तैयार करें

- सार्वजनिक डोमेन की पुस्तकों, दस्तावेजों आदि की .txt फाइलें चुने गए समय अवधि से एकत्र करें (जैसे, लंदन 1800-1850)
- इन्हें अपनी चुनी हुई समय/स्थान सीमा के भीतर रखें
- टेक्स्ट फाइलों को एक स्क्रिप्ट से साफ करें या प्रोजेक्ट गुटेनबर्ग के हेडर/फूटर, आधुनिक एनोटेशन या OCR त्रुटियों को मैन्युअली हटाएँ

### चरण 2: कस्टम टोकनाइज़र बनाएं

- train_tokenizer.py या train_tokenizer_hf.py को साफ किए गए डेटा पर चलाएँ।
- इससे आपको vocab.json और merges.txt मिलेंगे
- ये फाइलें आपके मॉडल के लिए शब्दावली और मर्ज नियम परिभाषित करती हैं

### चरण 3: अपना मॉडल ट्रेन करें

- प्रशिक्षण प्रक्रिया के लिए [Andrej Karpathy की nanoGPT](https://github.com/karpathy/nanoGPT) या अपनी चुनी हुई आर्किटेक्चर के दस्तावेज़ देखें

# सामान्य प्रश्न

## चयनात्मक कालिक प्रशिक्षण (Selective Temporal Training) क्या है?

चयनात्मक कालिक प्रशिक्षण (STT) एक मशीन लर्निंग पद्धति है जिसमें सभी प्रशिक्षण डेटा विशेष रूप से एक निश्चित ऐतिहासिक समय अवधि के भीतर चुना जाता है। इसका उद्देश्य उस युग की भाषा और ज्ञान को आधुनिक अवधारणाओं के प्रभाव के बिना मॉडल करना है। उदाहरण के लिए, वर्तमान मॉडल (v0.5) केवल 1800-1875 के डेटा पर प्रशिक्षित है, यह फाइन ट्यून नहीं किया गया है बल्कि शुरू से ही प्रशिक्षित है जिससे आउटपुट उस समय अवधि की भाषाई शैली और ऐतिहासिक संदर्भ को दर्शाता है।

## बस फाइन-ट्यूनिंग या LoRA क्यों नहीं उपयोग करें?

इस परियोजना के लिए मैं ऐसा भाषा मॉडल बनाना चाहता हूँ जो आधुनिक पूर्वाग्रह से मुक्त हो। अगर मैं GPT-2 जैसा कुछ फाइन-ट्यून करता हूँ, तो वह पहले से ही प्री-ट्रेंड है और वह जानकारी नहीं हटेगी। यदि मैं शुरू से ट्रेन करता हूँ तो भाषा मॉडल पुराना होने का नाटक नहीं करेगा, वह वास्तव में वैसा ही होगा। इस परियोजना का उद्देश्य अभी ऐसा कुछ बनाना है जो केवल 1800 और 1875 के बीच लंदन में प्रकाशित किताबों के ज्ञान का उपयोग करके तर्क कर सके।

## प्रशिक्षण के लिए आपने किस प्रकार का डेटा इस्तेमाल किया?


मैं 1800–1875 लंदन की किताबें, कानूनी दस्तावेज़, समाचार पत्र और अन्य लेखन का उपयोग कर रहा हूँ। मैंने जो सूची लिंक की है (v0 के लिए) उसमें लगभग 200 दस्तावेज़ हैं, लेकिन पहली ट्रेनिंग के लिए मैंने सिर्फ 50 फाइलें ~187 एमबी के बारे में इस्तेमाल की थीं। आप दस्तावेजों की सूची देख सकते हैं:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

डेटासेट आकार:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## मॉडल कितने बड़े हैं?

V0: 16M पैरामीटर

V0.5 123M पैरामीटर

V1: 700M पैरामीटर

# प्रशिक्षण विशिष्टताएँ ?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
Ram: 16GB DDR5.

# V1
GPU: A100 किराए पर लिया गया

















---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-09-30

---