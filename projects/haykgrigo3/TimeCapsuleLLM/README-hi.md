<div align="right">
  <details>
<summary>🌐 भाषा</summary>

[English](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=en) | [简体中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-CN) | [繁體中文](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=zh-TW) | [日本語](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ja) | [한국어](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ko) | [हिन्दी](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=hi) | [ไทย](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=th) | [Français](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fr) | [Deutsch](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=de) | [Español](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=es) | [Italiano](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=it) | [Русский](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ru) | [Português](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pt) | [Nederlands](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=nl) | [Polski](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=pl) | [العربية](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=ar) | [فارسی](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=fa) | [Türkçe](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=tr) | [Tiếng Việt](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=vi) | [Bahasa Indonesia](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=id) | [অসমীয়া](https://openaitx.github.io/#/view?user=haykgrigo3&project=TimeCapsuleLLM&lang=as)
</details>
</div>


# टाइमकैप्सूल LLM

*एक भाषा मॉडल जिसे **शुरुआत से** विशेष स्थानों और समय अवधियों के डेटा पर प्रशिक्षित किया गया है ताकि आधुनिक पक्षपात को कम किया जा सके और उस युग की आवाज़, शब्दावली और दृष्टिकोण का अनुकरण किया जा सके।*

कल्पना कीजिए कि एक एआई मॉडल केवल ऐतिहासिक बनने का नाटक नहीं करता, बल्कि वास्तव में होता है।

v0 और v0.5 [Andrej Karpathy के nanoGPT](https://github.com/karpathy/nanoGPT) पर आधारित हैं। मुख्य प्रशिक्षण स्क्रिप्ट और मॉडल आर्किटेक्चर उनका कार्य है।

v1 [Microsoft के Phi 1.5](https://huggingface.co/microsoft/phi-1_5) पर आधारित है।

v2 llamaforcausallm पर आधारित है

[Hugging Face लिंक](https://huggingface.co/collections/haykgrigorian/timecapsulellm-1800-1875-london)

## अनुसंधान स्थिति
यह परियोजना स्वतंत्र रूप से प्रारंभ की गई और विकसित की गई थी।

वर्तमान में इसे शैक्षणिक पर्यवेक्षण में, Muhlenberg College में एक संबद्ध अनुसंधान सहयोग के साथ संचालित किया जा रहा है।

## संदर्भ

यदि आप इस डेटा सेट या मॉडल का शैक्षणिक कार्य में उपयोग करते हैं, तो कृपया इसका उल्लेख करें:


```bibtex
@misc{london_llm_1800,
  author = {Grigorian, Hayk and Yaghoobian, Hamed},
  title = {Historic London English (1800–1875)},
  year = {2025},
  publisher = {Hugging Face},
  howpublished = {\url{https://huggingface.co/datasets/postgrammar/london-llm-1800}}
}
```

##  मॉडल व्यवहार और सीमाएँ

### **v0**  

प्रारंभिक प्रॉम्प्ट में मॉडल 1800 के दशक की भाषा और व्यवहार में प्रतिक्रिया देता है।  
उदाहरण: प्रॉम्प्ट: "Who art Henry?" और जवाब: "I know that man, I have did not a black, the storm." 

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1850_v0/timelockllm_sample_output.png?raw=true)

- आधुनिक अवधारणाओं का कोई उल्लेख नहीं  
- अधिकांशतः युग-प्रासंगिक शब्दावली  
- वाक्य सामान्यतः असंगत (लगभग 187MB प्रशिक्षण डेटा के लिए अपेक्षित)

### **v0.5** 

v0 की तुलना में महत्वपूर्ण सुधार।  
- विक्टोरियन लेखन शैली, उचित विराम चिह्न, अधिकांशतः व्याकरणिक वाक्य  
- तथ्यों की कल्पना की दर अभी भी उच्च  
- OCR शोर ("Digitized by Google") अभी भी आउटपुट में मौजूद

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v0.5/fellowcitizens.png?raw=true)

### **v1**

पहला मॉडल जो डेटासेट से किसी वास्तविक ऐतिहासिक घटना को किसी वास्तविक व्यक्ति से जोड़ता है।

उदाहरण: प्रॉम्प्ट: "It was the year of our Lord 1834" 

आउटपुट: "It was the year of our Lord 1834 and the streets of London were filled with protest and petition. The cause, as many re counted, was not bound in the way of private, but having taken up the same day in the day of Lord Palmerston, the public will receive a short statement of the difficulties under which the day of law has reached us. It is a matter of deep regret, that the present events in the history of the world are clear, and consequently will be'known. It is not true that the very men who first settled in the Gospel at Jerusalem should have so extensive and so interesting a record of the prosperity and prosperity" 

शुरू में मुझे लगा कि संयोग से उसी वर्ष कोई विरोध हुआ होगा, लेकिन इसे देखें: ![1834protest](https://raw.githubusercontent.com/haykgrigo3/TimeCapsuleLLM/main/1834protest.png)

### **v2mini-eval1**

v2 के 90GB डेटासेट में से 15GB के सैंपल से प्रशिक्षित।
मॉडल को केवल 10K स्टेप्स तक प्रशिक्षित किया गया।

टोकनाइज़ेशन में एक समस्या थी जिससे आउटपुट इस तरह दिखता है:

चार्ल्स डिकेंस कौन हैं?



W ho is Charles D ic ens ? D oes that work more of h ise x cell ent st ir ring , in his pl ays , int he G reat C omp any 's f arm ? What I have y et to qu ote from J ack P ick ett ? D oy oun ot know th att hey were as pe cies of g all oping , ors aw ing oft heir bre asts , or what w ast ob ed one about the t im ew hen J acks on was looking ont hew ind ow ? What ist hes uccess of an English man , and which h isson has not be end is cover ing t ome , where by to acc omp lish such a we ight ? D idy ou ever m ake ap ass age int othe old road way , ort o an anch or - b ree ze att he foot of our boat , which you m ust le ave us ? The fact is , that whe ther the wind would rise up from the pl ain on S atur day night orn o ont ide , ort ill then orth , or other wise , wes hall be com pelled t od esc ribe af orm idable bar rier , with t hes ame e ffect s ast he p resent . In th iss itu ation , at le ast , itis not to omuch t os ay that we have le ft that room . I bel ieve there are three c op ies int he " F ive H undred - fold ," to bere fer red to , ast he first n umber of our read ers wh ow is ht
सुधारित:

"चार्ल्स डिकेंस कौन हैं? क्या वह अपने उत्कृष्ट प्रेरणादायक कार्यों के लिए, अपने नाटकों में, ग्रेट कंपनी की फार्म में अधिक काम करते हैं? मुझे जैक पिकेट से क्या उद्धृत करना है? क्या आप नहीं जानते कि वे दौड़ते हुए, या अपनी छाती को काटते हुए, या उस समय के बारे में क्या किया जाना था जब जैक्सन खिड़की पर देख रहा था, की एक प्रजाति थे? एक अंग्रेज की सफलता क्या है, और उसका बेटा मुझे अभी तक खोज नहीं पाया है, जिससे ऐसी भारी चीज को पूरा किया जा सके? क्या आपने कभी पुराने मार्ग में प्रवेश किया है, या हमारे नाव के तल पर एक एंकर-ब्रीज़ के लिए गए हैं, जिसे आपको छोड़ना पड़ेगा? तथ्य यह है, कि चाहे शनिवार रात या दोपहर या उत्तर की ओर से मैदान से हवा उठे या नहीं, या अन्यथा, हमें एक शक्तिशाली बाधा का वर्णन करना पड़ेगा, वर्तमान के समान प्रभावों के साथ। इस स्थिति में, कम से कम, यह कहना ज्यादा नहीं है कि हमने वह कमरा छोड़ दिया है। मुझे विश्वास है कि 'फाइव हंड्रेड-फोल्ड' में तीन प्रतियाँ हैं, जिनका संदर्भ लिया जा सकता है, हमारे पाठकों की पहली संख्या के रूप में जो त[o]..."

### **v2mini-eval2**

उसी 15GB सैंपल का उपयोग करके प्रशिक्षित किया गया, जिसका उपयोग eval1 के प्रशिक्षण में किया गया था।
मॉडल को फिर से केवल 10K स्टेप्स तक प्रशिक्षित किया गया है।

प्रॉम्प्ट: चार्ल्स डार्विन

चार्ल्स डार्विनECCEMACY। महोदय, — निम्नलिखित मामला मेरे लिए रुचिकर है : — मैं लंदन में एक पखवाड़े था, और मुझे गठिया का दौरा काफी प्रभावित कर गया। गठिया का पहला हमला आपके मिलने से एक सप्ताह पहले हुआ था, दूसरा जब मैं आपसे मिला, और तीसरा जब मैं आपसे मिला, और तीसरा उसी समय में। हालांकि, गाउट का दूसरा हमला किसी भी ज्वर के लक्षणों के साथ नहीं था, बल्कि पेशाब के प्रवाह में वृद्धि और अधिक मात्रा में पेशाब के साथ था। तीसरा हमला मेरे आपसे मिलने के एक घंटे बाद हुआ, और इसके बाद गाउट के दौरे की वापसी और गाउट की अधिक तेज वापसी हुई। चौथा हमला भी बुखार के साथ था, लेकिन हमेशा ज्वर के लक्षणों के साथ नहीं था। गाउट का तीसरा हमला आपके बीमार होने के दो सप्ताह बाद था, और चौथा गाउट के दौरे के साथ था। चौथा हमला आपके हमले के दो सप्ताह बाद था, और उसके साथ एक संवेदना थी

### **v2**

90GB (112GB टोकनाइज्ड) डेटासेट का उपयोग कर प्रशिक्षित
182K स्टेप्स तक प्रशिक्षित

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output1.png)

![TimeCapsuleLLM Sample Output](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2/v2output2.png)

##  डेटासेट्स

### **v2**

- 90GB(कच्चा) 1800-1875 लंदन ग्रंथों का
- 136,344 दस्तावेज़
- पूरा टोकनाइज्ड डेटासेट यहाँ उपलब्ध है: https://huggingface.co/datasets/postgrammar/london-llm-1800

 ### पूर्वाग्रह आंकड़े 
  ![सर्वनाम पूर्वाग्रह](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/pronoun_bias.png)

  ![भौगोलिक पूर्वाग्रह](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/geographic_bias.png)

  ![कालिक पूर्वाग्रह](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/temporal_bias.png)

अधिक जानकारी के लिए [v2 पूर्वाग्रह रिपोर्ट](https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/london_1800_1875_v2mini_eval1/v2_bias_report.json) देखें।


## उपयोग कैसे करें

यह परियोजना मुख्य रूप से ऐतिहासिक डेटा को एकत्र करने, उसे प्रशिक्षण के लिए तैयार करने और एक टोकनाइज़र बनाने पर केंद्रित है। मैं पूरी LLM प्रशिक्षण प्रक्रिया को कवर नहीं कर रहा हूँ, उसके लिए Andrej Karpathy के nanoGPT को देखें।

### चरण 1: ऐतिहासिक ग्रंथों को एकत्र करें और तैयार करें

- अपनी चुनी हुई समयावधि (जैसे, लंदन 1800-1850) के सार्वजनिक डोमेन पुस्तकों, दस्तावेज़ों आदि की .txt फाइलें एकत्र करें 
- इन्हें अपनी चुनी हुई समय/स्थान की सीमा में रखें  
- एक स्क्रिप्ट से या मैन्युअली, प्रोजेक्ट गुटेनबर्ग की हेडर/फुटर, आधुनिक टिप्पणियाँ या OCR त्रुटियाँ हटाकर टेक्स्ट फाइलों को साफ करें।

### चरण 2: कस्टम टोकनाइज़र बनाएं

- साफ किए गए डेटा पर train_tokenizer.py या train_tokenizer_hf.py चलाएं।
- इससे आपको vocab.json और merges.txt मिलेंगे
- ये फाइलें आपके मॉडल के लिए शब्दावली और मर्ज नियम परिभाषित करती हैं

### चरण 3: अपना मॉडल प्रशिक्षित करें

- प्रशिक्षण प्रक्रिया के लिए या आपके चुने हुए आर्किटेक्चर के दस्तावेज़ के लिए [Andrej Karpathy का nanoGPT](https://github.com/karpathy/nanoGPT) देखें।

# अक्सर पूछे जाने वाले प्रश्न (FAQ)

## चयनात्मक काल प्रशिक्षण (Selective Temporal Training) क्या है?

चयनात्मक काल प्रशिक्षण (STT) एक मशीन लर्निंग विधि है जिसमें सभी प्रशिक्षण डेटा को विशेष रूप से किसी निश्चित ऐतिहासिक समयावधि के भीतर चुना जाता है। यह उस युग की भाषा और ज्ञान को बिना आधुनिक अवधारणाओं के प्रभाव के मॉडल करने के लिए किया जाता है। उदाहरण स्वरूप, मेरा वर्तमान मॉडल (v0.5) केवल 1800-1875 के डेटा पर प्रशिक्षित है, इसे फाइन ट्यून नहीं किया गया बल्कि शुरू से प्रशिक्षित किया गया, जिससे उस समय की भाषाई शैली और ऐतिहासिक संदर्भ का प्रतिबिंब मिलता है।

## सिर्फ फाइन-ट्यूनिंग या LoRA का उपयोग क्यों नहीं?

इस परियोजना के लिए मैं एक ऐसा भाषा मॉडल बनाना चाहता हूँ जिसमें आधुनिक पक्षपात न हो। यदि मैं GPT-2 जैसे किसी मॉडल को फाइन-ट्यून करता हूँ, तो वह पहले से ही प्री-ट्रेंड है और वह जानकारी हटाई नहीं जा सकती। यदि मैं शुरू से प्रशिक्षण करता हूँ तो भाषा मॉडल पुराने युग की तरह दिखावा नहीं करेगा, वह वास्तव में वैसा ही होगा। इस परियोजना का वर्तमान लक्ष्य ऐसा कुछ बनाना है जो केवल 1800 से 1875 के बीच प्रकाशित लंदन की पुस्तकों के ज्ञान का ही उपयोग कर सके।

## आपने प्रशिक्षण के लिए किस तरह का डेटा उपयोग किया?

मैं 1800–1875 लंदन की किताबें, कानूनी दस्तावेज़, समाचार पत्र और अन्य लेखन का उपयोग कर रहा हूँ। मैंने लिंक की गई सूची (v0 के लिए) में लगभग 200 दस्तावेज़ दिए हैं, लेकिन पहले प्रशिक्षण के लिए मैंने केवल 50 फाइलें लगभग ~187 MB की उपयोग कीं। आप दस्तावेजों की सूची यहाँ देख सकते हैं:
https://github.com/haykgrigo3/TimeCapsuleLLM/blob/main/Copy%20of%20London%20Documents%20for%20Time%20Capsule%20LLM.txt

डाटासेट आकार:
- v0: ~187MB
- v0.5: ~435MB 
- v1: ~6.25GB 

- v2mini-eval1: 15GB (v2 के 90GB से नमूना)
- v2: 90GB

## मॉडल कितने बड़े हैं?

v0: 16M पैरामीटर्स

v0.5: 123M पैरामीटर्स

v1: 700M पैरामीटर्स

v2mini-eval1: 300M पैरामीटर्स

v2mini-eval2: 200M पैरामीटर्स

v2: 1.2B पैरामीटर्स

## प्रशिक्षण विशिष्टताएँ?

### v0/v0.5
GPU: Geforce rtx 4060
CPU: i5-13400F 
रैम: 16GB DDR5.

### v1
GPU: A100 SXM किराए पर लिया गया

### v2mini-eval1/eval2
GPU: A100 SXM किराए पर लिया गया

### v2
GPU: H100 SXM किराए पर लिया गया

## आभार

मैं [डॉ. हामेद याघूबियन](https://hamedyaghoobian.com) का शैक्षणिक पर्यवेक्षण, शोध रूपरेखा और मूल्यांकन में मार्गदर्शन, और v2 रिलीज के लिए टोकनाइज़र प्रशिक्षण तथा डेटासेट तैयारी में सहायता के लिए धन्यवाद देना चाहूंगा। उनके सुझाव और अनुभव इस कार्य की प्रस्तुति को परिष्कृत करने में महत्वपूर्ण रहे हैं।










































---

Tranlated By [Open Ai Tx](https://github.com/OpenAiTx/OpenAiTx) | Last indexed: 2026-03-03

---