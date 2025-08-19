
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

v1 [Microsoft के Phi 1.5](https://huggingface.co/microsoft/phi-1_5) पर निर्मित


##  मॉडल व्यवहार एवं सीमाएँ

### **v0**  

प्रारंभिक प्रॉम्प्ट्स में मॉडल 1800 के दशक की भाषा और व्यवहार में उत्तर देता है। 
उदाहरण: प्रॉम्प्ट: "Who art Henry?" और उत्तर था "I know that man, I have did not a black, the storm." 

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- आधुनिक अवधारणाओं का कोई उल्लेख नहीं  
- अधिकांशतः युग-संगत शब्दावली  
- वाक्य अधिकतर असंगत (लगभग ~187MB प्रशिक्षण डेटा के लिए अपेक्षित)

### **v0.5** 

v0 की तुलना में महत्वपूर्ण सुधार।  
- विक्टोरियन लेखन शैली, उचित विराम चिन्ह, अधिकतर व्याकरणिक वाक्य  
- अब भी उच्च तथ्यात्मक भ्रम की दर  
- OCR शोर (“Digitized by Google”) अब भी आउटपुट में उपस्थित

![TimeLockLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

पहला मॉडल जो वास्तविक ऐतिहासिक घटना को डेटासेट के वास्तविक व्यक्ति से जोड़ता है।

उदाहरण: प्रॉम्प्ट: "It was the year of our Lord 1834" 

आउटपुट: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

पहले मुझे लगा कि उसी वर्ष में कोई विरोध संयोगवश हुआ होगा, लेकिन यह देखें: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### यह क्यों महत्वपूर्ण है:

यह मेरी मॉडलों के द्वारा किसी वर्ष को वास्तविक ऐतिहासिक घटना और उस घटना से जुड़े वास्तविक व्यक्ति (Lord Palmerston) से जोड़ने का पहला उदाहरण है। पहले के मॉडल (v0 और v0.5) 19वीं सदी की लेखन शैली की नकल कर सकते थे, लेकिन हमेशा घटनाओं, लोगों और तथ्यों का भ्रम पैदा करते थे। यह दर्शाता है कि मॉडल डेटासेट से चीजें याद रखना शुरू कर रहा है

## आगामी योजनाएँ 
- लंदन में 1800-1875 के बीच प्रकाशित लगभग 1,75,000 ग्रंथ Internet Archive पर उपलब्ध हैं
- मैं कार्पस को बढ़ाने और बेहतर तर्क क्षमताओं के लिए इसे और साफ करने की योजना बना रहा हूँ
- अधिक ऐतिहासिक मॉडलों के लिए विभिन्न क्षेत्रों और समय काल में विस्तार

## उपयोग कैसे करें

यह परियोजना मुख्य रूप से ऐतिहासिक डेटा को संकलित करने, प्रशिक्षण के लिए तैयार करने और एक टोकनाइज़र बनाने पर केंद्रित है। मैं पूरी LLM प्रशिक्षण प्रक्रिया को शामिल नहीं कर रहा हूँ, उसके लिए Andrej Karpathy के nanoGPT को देखें।

### चरण 1: ऐतिहासिक ग्रंथों को एकत्रित और तैयार करें

- सार्वजनिक डोमेन की पुस्तकों, दस्तावेज़ों आदि की .txt फाइलें अपने चुने हुए समय काल (जैसे, लंदन 1800-1850) से एकत्रित करें
- इन्हें अपने चुने हुए समय/स्थान की सीमा के भीतर रखें
- टेक्स्ट फाइलों को एक स्क्रिप्ट से या मैन्युअल रूप से साफ करें, जैसे Project Gutenberg के हेडर/फुटर, आधुनिक टिप्पणियाँ या OCR त्रुटियाँ हटाएँ।

### चरण 2: कस्टम टोकनाइज़र बनाएं

- साफ किए गए डेटा पर train_tokenizer.py या train_tokenizer_hf.py चलाएँ।
- इससे आपको vocab.json और merges.txt मिलेंगे
- ये फाइलें आपके मॉडल के लिए शब्दावली और मर्ज नियमों को परिभाषित करती हैं

### चरण 3: अपना मॉडल प्रशिक्षित करें

- प्रशिक्षण प्रक्रिया के लिए [nanoGPT by Andrej Karpathy](https://github.com/karpathy/nanoGPT) या आपके चुने हुए आर्किटेक्चर की डॉक्यूमेंटेशन देखें।

# सामान्य प्रश्न

## चयनित कालिक प्रशिक्षण (Selective Temporal Training) क्या है?

चयनित कालिक प्रशिक्षण (Selective Temporal Training - STT) मशीन लर्निंग की एक विधि है जिसमें सभी प्रशिक्षण डेटा को विशेष रूप से एक ऐतिहासिक समय अवधि के भीतर संकलित किया जाता है। इसका उद्देश्य उस युग की भाषा और ज्ञान को बिना आधुनिक अवधारणाओं के प्रभाव के मॉडल करना है। उदाहरण के लिए, वर्तमान में मेरे पास जो मॉडल (v0.5) है वह विशेष रूप से 1800-1875 के डेटा पर प्रशिक्षित है, यह फाइन ट्यून नहीं है बल्कि शुरू से ही प्रशिक्षित है जिससे उसके आउटपुट में उस समय की भाषाई शैली और ऐतिहासिक संदर्भ झलकता है।

## सिर्फ फाइन-ट्यूनिंग या LoRA क्यों नहीं इस्तेमाल करें?

इस परियोजना के लिए मैं ऐसा भाषा मॉडल बनाना चाहता हूँ जिसमें आधुनिक पक्षपात न हो। अगर मैं GPT-2 जैसे किसी मॉडल को फाइन-ट्यून करता हूँ, तो वह पहले से प्रशिक्षित है और उसकी जानकारी हटाई नहीं जा सकती। अगर मैं शुरू से प्रशिक्षण करता हूँ तो भाषा मॉडल पुराने जैसा दिखावा नहीं करेगा, वह सच में पुराना होगा। इस परियोजना का लक्ष्य है ऐसा मॉडल बनाना जो केवल 1800 और 1875 के बीच लंदन में प्रकाशित पुस्तकों के ज्ञान से ही तर्क कर सके।

## आपने प्रशिक्षण के लिए किस प्रकार के डेटा का उपयोग किया?

मैं 1800–1875 लंदन की पुस्तकें, कानूनी दस्तावेज़, समाचारपत्र और अन्य लेखन का उपयोग कर रहा हूँ। जो सूची मैंने लिंक की है (v0) उसमें लगभग 200 दस्तावेज़ हैं लेकिन पहले प्रशिक्षण के लिए मैंने सिर्फ 50 फाइलें, लगभग ~187 MB इस्तेमाल कीं। आप दस्तावेज़ों की सूची यहाँ देख सकते हैं:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt



डेटासेट आकार:
v0: ~187MB
v0.5: ~435MB 
v1: ~6.25GB 

## मॉडल कितने बड़े हैं ?

V0: 16M पैरामीटर्स

V0.5 123M पैरामीटर्स

V1: 700M पैरामीटर्स

# प्रशिक्षण विशिष्टताएँ ?

# V0/V0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
रैम: 16GB DDR5.

# V1
GPU: A100 किराए पर लिया गया














---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2025-08-19

---